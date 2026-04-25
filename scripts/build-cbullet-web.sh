#!/bin/bash
# Build script for cbullet library for Web/Emscripten
# Usage: ./build-cbullet-web.sh [build_type]
# Example: ./build-cbullet-web.sh Release
# Example: ./build-cbullet-web.sh Debug

set -e  # Exit on any error

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
BULLET_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"
BINDINGS_C_DIR="$BULLET_DIR/bindings/c"

# Parse arguments
BUILD_TYPE="${1:-Release}"

# Set Emscripten version
EMSCRIPTEN_VERSION="3.1.56"

echo "=========================================="
echo "Building cbullet for Web/Emscripten"
echo "Build Type: $BUILD_TYPE"
echo "Emscripten Version: $EMSCRIPTEN_VERSION"
echo "=========================================="

# Determine build directory based on build type
BUILD_TYPE_LOWER=$(echo "$BUILD_TYPE" | tr '[:upper:]' '[:lower:]')
BUILD_DIR="$BULLET_DIR/build-emscripten-$BUILD_TYPE_LOWER"

# Clean up existing build directory for a fresh build
echo "Cleaning build directory: $BUILD_DIR"
rm -rf "$BUILD_DIR"

# Create build directory
echo "Creating build directory: $BUILD_DIR"
mkdir -p "$BUILD_DIR"
cd "$BUILD_DIR"

# Configure with CMake using Emscripten toolchain
echo "Configuring CMake..."
emcmake cmake "$BINDINGS_C_DIR" \
    -DCMAKE_BUILD_TYPE="$BUILD_TYPE"

# Build
echo "Building..."
cmake --build . --config "$BUILD_TYPE"

echo "=========================================="
echo "Build complete!"
echo "Output: $BUILD_DIR/cbullet.a"
echo "=========================================="

# Verify the library was created
if [ -f "$BUILD_DIR/cbullet.a" ]; then
    echo "✓ Successfully built cbullet.a"
    ls -lh "$BUILD_DIR/cbullet.a"

    # Copy to libs folder
    OUTPUT_DIR="$BULLET_DIR/libs/emscripten/x86/$BUILD_TYPE_LOWER"
    mkdir -p "$OUTPUT_DIR"
    cp "$BUILD_DIR/cbullet.a" "$OUTPUT_DIR/"

    echo "=========================================="
    echo "✓ Copied to: $OUTPUT_DIR/cbullet.a"
    echo "=========================================="
else
    echo "✗ Failed to build cbullet.a"
    exit 1
fi
