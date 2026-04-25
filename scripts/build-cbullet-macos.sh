#!/bin/bash
# Build script for cbullet library on macOS
# Usage: ./build-cbullet-macos.sh [architecture] [build_type]
# Example: ./build-cbullet-macos.sh arm64 Release
# Example: ./build-cbullet-macos.sh x86_64 Debug

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
BULLET_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"
BINDINGS_C_DIR="$BULLET_DIR/bindings/c"

# Parse arguments
ARCH="${1:-arm64}"
BUILD_TYPE="${2:-Release}"

BUILD_DIR="$BULLET_DIR/build-xcode-macos-$ARCH"

echo "=========================================="
echo "Building cbullet for macOS"
echo "Architecture: $ARCH"
echo "Build Type: $BUILD_TYPE"
echo "=========================================="

# Create build directory
mkdir -p "$BUILD_DIR"
cd "$BUILD_DIR"

# Configure with CMake
cmake "$BINDINGS_C_DIR" \
    -G Xcode \
    -DCMAKE_OSX_ARCHITECTURES="$ARCH" \
    -DCMAKE_OSX_DEPLOYMENT_TARGET="11.0"

# Build
cmake --build . --config "$BUILD_TYPE"

echo "=========================================="
echo "Build complete!"
echo "Output: $BUILD_DIR/$BUILD_TYPE/libcbullet.dylib"
echo "=========================================="

# Verify the library was created
if [ -f "$BUILD_DIR/$BUILD_TYPE/libcbullet.dylib" ]; then
    echo "✓ Successfully built libcbullet.dylib"
    file "$BUILD_DIR/$BUILD_TYPE/libcbullet.dylib"

    # Copy to libs folder
    OUTPUT_DIR="$BULLET_DIR/libs/macos/$ARCH/$(echo "$BUILD_TYPE" | tr '[:upper:]' '[:lower:]')"
    mkdir -p "$OUTPUT_DIR"
    cp "$BUILD_DIR/$BUILD_TYPE/libcbullet.dylib" "$OUTPUT_DIR/"

    echo "=========================================="
    echo "✓ Copied to: $OUTPUT_DIR/libcbullet.dylib"
    echo "=========================================="
else
    echo "✗ Failed to build libcbullet.dylib"
    exit 1
fi
