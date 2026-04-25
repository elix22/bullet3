cmake_minimum_required(VERSION 3.14)
project(cbullet)

set(BULLET_SRC_DIR "${CMAKE_CURRENT_SOURCE_DIR}/../../src")

file(GLOB_RECURSE BINDING_SOURCES
    "${CMAKE_CURRENT_SOURCE_DIR}/src/*.cpp"
)

set(BULLET_AMALGAM_SOURCES
    "${BULLET_SRC_DIR}/btBulletCollisionAll.cpp"
    "${BULLET_SRC_DIR}/btBulletDynamicsAll.cpp"
    "${BULLET_SRC_DIR}/btLinearMathAll.cpp"
)

if(EMSCRIPTEN)
    add_library(cbullet STATIC ${BINDING_SOURCES} ${BULLET_AMALGAM_SOURCES})
    set_target_properties(cbullet PROPERTIES PREFIX "")
else()
    add_library(cbullet SHARED ${BINDING_SOURCES} ${BULLET_AMALGAM_SOURCES})
endif()

target_include_directories(cbullet PRIVATE
    "${CMAKE_CURRENT_SOURCE_DIR}/include"
    "${CMAKE_CURRENT_SOURCE_DIR}/src"
    "${BULLET_SRC_DIR}"
)

target_compile_definitions(cbullet PRIVATE
    BT_USE_DOUBLE_PRECISION
)

set_target_properties(cbullet PROPERTIES
    OUTPUT_NAME "cbullet"
    POSITION_INDEPENDENT_CODE ON
    CXX_STANDARD 17
    CXX_STANDARD_REQUIRED ON
)

if(MSVC AND NOT CMAKE_CXX_COMPILER_ID STREQUAL "Clang")
    # Pure MSVC: /EHsc assumes extern "C" are noexcept; replace with /EHs.
    string(REPLACE "/EHsc" "/EHs" CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS}")
else()
    target_compile_options(cbullet PRIVATE
        -fvisibility=hidden
        -fvisibility-inlines-hidden
    )
endif()

if(APPLE AND CMAKE_SYSTEM_NAME STREQUAL "iOS")
    set_target_properties(cbullet PROPERTIES
        FRAMEWORK TRUE
        FRAMEWORK_VERSION A
        MACOSX_FRAMEWORK_IDENTIFIER com.bullet.cbullet
        MACOSX_FRAMEWORK_INFO_PLIST "${CMAKE_CURRENT_SOURCE_DIR}/../../scripts/Info.plist"
    )
endif()

# Multithreading (not supported on Emscripten / WebAssembly).
# The amalgamated sources (btBulletCollisionAll, btBulletDynamicsAll,
# btLinearMathAll) already #include all Mt and threading .cpp files, so no
# additional target_sources are needed — just define BT_THREADSAFE=1.
if(NOT EMSCRIPTEN)
    target_compile_definitions(cbullet PRIVATE BT_THREADSAFE=1)

    # SIMD: armeabi-v7a needs an explicit -mfpu=neon flag; every other supported
    # target already exposes NEON (arm64) or SSE2 (x86-64) by default.
    if(ANDROID AND ANDROID_ABI STREQUAL "armeabi-v7a")
        target_compile_options(cbullet PRIVATE -mfpu=neon)
    elseif(NOT (MSVC AND NOT CMAKE_CXX_COMPILER_ID STREQUAL "Clang"))
        # Clang / GCC (macOS, Linux, iOS, non-v7a Android, ClangCL on Windows).
        # Add SSE 4.1 for x86-64 targets to improve auto-vectorisation of
        # double-precision loops; arm64 already has NEON with no extra flag.
        if(CMAKE_OSX_ARCHITECTURES STREQUAL "x86_64" OR
           (NOT CMAKE_OSX_ARCHITECTURES AND
            CMAKE_SYSTEM_PROCESSOR MATCHES "x86_64|AMD64|amd64"))
            target_compile_options(cbullet PRIVATE -msse4.1)
        endif()
    endif()
endif()
