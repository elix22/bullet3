#!/bin/bash
# Build script for cbullet library on Linux
# Usage: ./build-cbullet-linux.sh [build_type]
# Example: ./build-cbullet-linux.sh Release
# Example: ./build-cbullet-linux.sh Debug

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
BULLET_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"
BINDINGS_C_DIR="$BULLET_DIR/bindings/c"
BUILD_DIR="$BULLET_DIR/build-linux"

# Parse arguments - default to Release
BUILD_TYPE="${1:-Release}"

echo "=========================================="
echo "Building cbullet for Linux"
echo "Build Type: $BUILD_TYPE"
echo "=========================================="

# Create build directory
mkdir -p "$BUILD_DIR"
cd "$BUILD_DIR"

# Configure with CMake
cmake "$BINDINGS_C_DIR" \
    -DCMAKE_BUILD_TYPE="$BUILD_TYPE"

# Build
cmake --build . --config "$BUILD_TYPE" -- -j$(nproc)

echo "=========================================="
echo "Build complete!"
echo "Output: $BUILD_DIR/libcbullet.so"
echo "=========================================="

# Verify the library was created
if [ -f "$BUILD_DIR/libcbullet.so" ]; then
    echo "✓ Successfully built libcbullet.so"
    file "$BUILD_DIR/libcbullet.so"

    # Copy to the expected location
    ARCH="X64"  # Use X64 instead of x86_64 to match .NET expectations
    if [ "$BUILD_TYPE" = "Debug" ]; then
        OUTPUT_DIR="$BULLET_DIR/libs/linux/$ARCH/debug"
    else
        OUTPUT_DIR="$BULLET_DIR/libs/linux/$ARCH/release"
    fi

    mkdir -p "$OUTPUT_DIR"
    cp "$BUILD_DIR/libcbullet.so" "$OUTPUT_DIR/"

    echo "=========================================="
    echo "✓ Copied to: $OUTPUT_DIR/libcbullet.so"
    echo "=========================================="
else
    echo "✗ Failed to build libcbullet.so"
    exit 1
fi
