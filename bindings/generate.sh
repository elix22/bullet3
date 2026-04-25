#!/bin/bash

SCRIPT_DIR="$(cd "$(dirname "$BASH_SOURCE")" && pwd)"
# deps/bullet/bindings -> go up three levels to reach the repo root
cd "$SCRIPT_DIR/../../.."

set -euo pipefail

if [[ ! -f build/mrbind ]]; then
    echo 'Did not find build/mrbind. Build MRBind first.'
    exit 1
fi

# Find compiler config (check repo root first, fall back to examples/).
CXX_FILE=""
for f in cxx.txt examples/cxx.txt; do
    if [[ -f "$f" ]]; then CXX_FILE="$f"; break; fi
done
if [[ -z "$CXX_FILE" ]]; then
    echo 'Did not find cxx.txt. Put your compiler name in it (e.g. clang++).'
    exit 1
fi
export CLANG_CXX="$(xargs <"$CXX_FILE")"

./deps/bullet/bindings/clean.sh

BINDINGS="deps/bullet/bindings"
mkdir -p "$BINDINGS/c/include" "$BINDINGS/c/src" "$BINDINGS/csharp/src" "$BINDINGS/tmp"

# clean.sh removes bindings/c/ entirely; restore the CMakeLists.txt that the
# build scripts rely on (it is the authoritative copy — edit here, not there).
cp "$BINDINGS/CMakeLists.txt" "$BINDINGS/c/CMakeLists.txt"

BULLET_SRC="$(pwd)/deps/bullet/src"

# Clang-style flags for the parser.
EXTRA_PARSER_CXX_FLAGS=(
    -std=c++17 -Wall -Wextra
    -fparse-all-comments
    -DBT_USE_DOUBLE_PRECISION
    -DBT_THREADSAFE=1
    -I"$BULLET_SRC"
)

# Optional tunable flags for the parser.
EXTRA_PARSER_FLAGS=(
    --copy-inherited-members
)

# Optional tunable flags for the C generator.
EXTRA_GEN_C_FLAGS=(
    --max-header-name-length 100
    --no-handle-exceptions
)

# Optional tunable flags for the C# generator.
EXTRA_GEN_FLAGS=(
    --csharp-version=12
    --dotnet-version=std2.0
)

# Optional tunable flags for the C bindings compilation.
EXTRA_CXX_FLAGS=(
    -g
)

DOTNET=dotnet
SHARED_LIBRARY_EXT=.so
SHARED_LIBRARY_PREFIX=lib

# Need extra flags on MSYS2.
if [[ $(uname -o 2>/dev/null) == Msys ]]; then
    EXTRA_PARSER_CXX_FLAGS+=(--sysroot="$MSYSTEM_PREFIX")
    DOTNET="C:/Program Files/dotnet/dotnet"
    SHARED_LIBRARY_EXT=.dll
    SHARED_LIBRARY_PREFIX=
fi

# Need the SDK sysroot on macOS.
if [[ $(uname) == Darwin ]]; then
    EXTRA_PARSER_CXX_FLAGS+=(-isysroot "$(xcrun --show-sdk-path)")
    SHARED_LIBRARY_EXT=.dylib
    SHARED_LIBRARY_PREFIX=lib
fi

set -x

# Assemble the combined input header.
echo "#pragma once" >"$BINDINGS/tmp/combined_input.h"
echo "#include <btBulletDynamicsCommon.h>" >>"$BINDINGS/tmp/combined_input.h"
# Multithreaded variants (require BT_THREADSAFE=1).
echo "#include <BulletCollision/CollisionDispatch/btCollisionDispatcherMt.h>" >>"$BINDINGS/tmp/combined_input.h"
echo "#include <BulletDynamics/ConstraintSolver/btSequentialImpulseConstraintSolverMt.h>" >>"$BINDINGS/tmp/combined_input.h"
echo "#include <BulletDynamics/Dynamics/btDiscreteDynamicsWorldMt.h>" >>"$BINDINGS/tmp/combined_input.h"
echo "#include <LinearMath/btThreads.h>" >>"$BINDINGS/tmp/combined_input.h"

# Parse the input header.
./build/mrbind \
    "$BINDINGS/tmp/combined_input.h" \
    -o "$BINDINGS/tmp/parse_result.json" \
    --ignore :: \
    --skip-mentions-of btDbvt \
    --skip-mentions-of btDbvtProxy \
    --skip-mentions-of btDbvtNode \
    --skip-mentions-of btDbvtAabbMm \
    --skip-mentions-of btDbvtVolume \
    --skip-mentions-of btOverlappingPairCallback \
    --skip-mentions-of btBroadphasePair \
    --skip-mentions-of btBroadphasePairArray \
    --skip-mentions-of btBroadphaseProxy \
    --skip-mentions-of btPoolAllocator \
    --skip-mentions-of btDispatcherInfo \
    --skip-mentions-of btDispatcherQueryType \
    --skip-mentions-of btSimulationIslandManager \
    --skip-mentions-of btSolverAnalyticsData \
    --skip-mentions-of btSolverBody \
    --skip-mentions-of btSingleConstraintRowSolver \
    --skip-mentions-of btBatchedConstraints \
    --skip-mentions-of btConstraintArray \
    --skip-mentions-of btContactSolverInfo \
    --skip-mentions-of btJacobianEntry \
    --skip-mentions-of btPersistentManifold \
    --skip-mentions-of btManifoldArray \
    --skip-mentions-of btNearCallback \
    --skip-mentions-of btInternalTickCallback \
    --skip-mentions-of btUnionFind \
    --skip-mentions-of btNodeStack \
    --skip-mentions-of btSSEUnion \
    --skip-mentions-of btSpinMutex \
    --skip-mentions-of btIParallelForBody \
    --skip-mentions-of btSimulationIslandManagerMt \
    --skip-mentions-of btContactManifoldCachedInfo \
    --skip-mentions-of btClock \
    --skip-mentions-of btQuantizedBvh \
    --skip-mentions-of btVertexArray \
    --skip-mentions-of btSimplePairArray \
    --skip-mentions-of btAngularLimit \
    --skip-mentions-of btConvexSeparatingDistanceUtil \
    --skip-mentions-of btConvexTriangleCallback \
    --skip-mentions-of btVector3DoubleData \
    --skip-mentions-of btVector3FloatData \
    --skip-mentions-of btQuaternionDoubleData \
    --skip-mentions-of btQuaternionFloatData \
    --skip-mentions-of btTransformDoubleData \
    --skip-mentions-of btTransformFloatData \
    --skip-mentions-of btMatrix3x3DoubleData \
    --skip-mentions-of btMatrix3x3FloatData \
    --skip-mentions-of btRigidBodyDoubleData \
    --skip-mentions-of btRigidBodyFloatData \
    --skip-mentions-of btCollisionObjectDoubleData \
    --skip-mentions-of btCollisionObjectFloatData \
    --skip-mentions-of btDynamicsWorldDoubleData \
    --skip-mentions-of btDynamicsWorldFloatData \
    --allow btVector3 \
    --allow btQuadWord \
    --allow btQuaternion \
    --allow btTransform \
    --allow btMatrix3x3 \
    --allow btScalar \
    --allow btRigidBody \
    --allow btCollisionObject \
    --allow btDiscreteDynamicsWorld \
    --allow btDynamicsWorld \
    --allow btCollisionWorld \
    --allow btCollisionShape \
    --allow btConvexShape \
    --allow btConvexInternalShape \
    --allow btPolyhedralConvexShape \
    --allow btPolyhedralConvexAabbCachingShape \
    --allow btConvexInternalAabbCachingShape \
    --allow btBoxShape \
    --allow btSphereShape \
    --allow btCapsuleShape \
    --allow btMotionState \
    --allow btDefaultMotionState \
    --allow btCollisionConfiguration \
    --allow btDefaultCollisionConfiguration \
    --allow btDispatcher \
    --allow btCollisionDispatcher \
    --allow btBroadphaseInterface \
    --allow btDbvtBroadphase \
    --allow btOverlappingPairCache \
    --allow btConstraintSolver \
    --allow btSequentialImpulseConstraintSolver \
    --allow btCollisionDispatcherMt \
    --allow btSequentialImpulseConstraintSolverMt \
    --allow btConstraintSolverPoolMt \
    --allow btDiscreteDynamicsWorldMt \
    --allow btITaskScheduler \
    --allow btCreateDefaultTaskScheduler \
    --allow btSetTaskScheduler \
    --allow btGetTaskScheduler \
    "${EXTRA_PARSER_FLAGS[@]+"${EXTRA_PARSER_FLAGS[@]}"}" \
    -- \
    -xc++-header \
    -resource-dir="$("$CLANG_CXX" -print-resource-dir)" \
    -I"$BULLET_SRC" \
    "${EXTRA_PARSER_CXX_FLAGS[@]}"

# Generate the C bindings.
./build/mrbind_gen_c \
    --input "$BINDINGS/tmp/parse_result.json" \
    --output-header-dir "$BINDINGS/c/include" \
    --output-source-dir "$BINDINGS/c/src" \
    --output-desc-json "$BINDINGS/tmp/c_desc.json" \
    --helper-name-prefix Bullet_ \
    --helper-macro-name-prefix BULLET_ \
    --map-path "$BULLET_SRC" bullet \
    --assume-include-dir "$BULLET_SRC" \
    --force-emit-common-helpers \
    "${EXTRA_GEN_C_FLAGS[@]}"

# Fix ODR: btContactManifoldCachedInfo::MAX_NUM_CONTACT_POINTS is 'static const int'
# with an in-class initialiser but no out-of-class definition in Bullet's own sources.
# The generated binding odr-uses it via std::addressof, which requires a definition.
printf '\nconst int btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::MAX_NUM_CONTACT_POINTS;\n' \
    >> "$BINDINGS/c/src/bullet/BulletDynamics/ConstraintSolver/btSequentialImpulseConstraintSolverMt.cpp"

# Generate the C# bindings.
./build/mrbind_gen_csharp \
    --input-json "$BINDINGS/tmp/c_desc.json" \
    --output-dir "$BINDINGS/csharp/src" \
    --imported-lib-name cbullet \
    --helpers-namespace Bullet \
    --force-namespace Bullet \
    "${EXTRA_GEN_FLAGS[@]}"


