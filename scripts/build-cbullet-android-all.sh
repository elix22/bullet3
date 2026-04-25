#!/bin/bash
# Build script for cbullet library for all Android architectures
# Usage: ./build-cbullet-android-all.sh [build_type]
# Example: ./build-cbullet-android-all.sh Release
# Example: ./build-cbullet-android-all.sh Debug

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
BUILD_TYPE="${1:-Release}"

echo "=========================================="
echo "Building cbullet for all Android architectures"
echo "Build Type: $BUILD_TYPE"
echo "=========================================="

# Android ABIs to build
ANDROID_ABIS=("arm64-v8a" "armeabi-v7a" "x86_64")

for ABI in "${ANDROID_ABIS[@]}"; do
    echo ""
    echo "Building for Android $ABI..."
    "$SCRIPT_DIR/build-cbullet-android.sh" "$ABI" "$BUILD_TYPE"
done

echo ""
echo "=========================================="
echo "All Android builds completed successfully!"
echo "=========================================="

# Show built libraries
echo ""
echo "Built libraries:"
BULLET_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"
if [ -d "$BULLET_DIR/libs/android" ]; then
    find "$BULLET_DIR/libs/android" -name "libcbullet.so" -type f | sort
else
    echo "No libraries found in $BULLET_DIR/libs/android"
fi

echo ""
echo "Library details:"
find "$BULLET_DIR/libs/android" -name "libcbullet.so" -type f -exec ls -lh {} \;
