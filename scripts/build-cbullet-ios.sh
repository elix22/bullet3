#!/bin/bash
# Build script for cbullet framework on iOS
# Usage: ./build-cbullet-ios.sh [architecture] [build_type]
# Example: ./build-cbullet-ios.sh arm64 Release
# Example: ./build-cbullet-ios.sh x86_64 Debug (for simulator)

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
BULLET_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"
BINDINGS_C_DIR="$BULLET_DIR/bindings/c"
BUILD_DIR="$BULLET_DIR/build-xcode-ios"

# Parse arguments
ARCH="${1:-arm64}"
BUILD_TYPE="${2:-Release}"

echo "=========================================="
echo "Building cbullet framework for iOS"
echo "Architecture: $ARCH"
echo "Build Type: $BUILD_TYPE"
echo "=========================================="

# Check if bindings/c directory exists
if [ ! -d "$BINDINGS_C_DIR" ]; then
    echo "Error: bindings/c directory not found at $BINDINGS_C_DIR"
    exit 1
fi

# Create build directory
rm -rf "$BUILD_DIR"
mkdir -p "$BUILD_DIR"
cd "$BUILD_DIR"

# Determine SDK and deployment target based on architecture
if [ "$ARCH" = "arm64" ]; then
    SDK="iphoneos"
    DEPLOYMENT_TARGET="13.0"
else
    SDK="iphonesimulator"
    DEPLOYMENT_TARGET="13.0"
fi

# Configure with CMake for iOS
cmake "$BINDINGS_C_DIR" \
    -G Xcode \
    -DCMAKE_SYSTEM_NAME=iOS \
    -DCMAKE_OSX_ARCHITECTURES="$ARCH" \
    -DCMAKE_OSX_DEPLOYMENT_TARGET="$DEPLOYMENT_TARGET" \
    -DCMAKE_XCODE_ATTRIBUTE_DEVELOPMENT_TEAM="" \
    -DCMAKE_XCODE_ATTRIBUTE_CODE_SIGNING_ALLOWED=NO

# Build
cmake --build . --config "$BUILD_TYPE"

# Create destination directory
DEST_DIR="$BULLET_DIR/libs/ios/$(echo "$BUILD_TYPE" | tr '[:upper:]' '[:lower:]')"
mkdir -p "$DEST_DIR"

# Copy framework to destination
echo "Copying framework to $DEST_DIR..."
FRAMEWORK_PATH="$BUILD_DIR/$BUILD_TYPE-$SDK/cbullet.framework"
DEST_FRAMEWORK="$DEST_DIR/cbullet.framework"

if [ -d "$FRAMEWORK_PATH" ]; then
    rm -rf "$DEST_FRAMEWORK"
    cp -R "$FRAMEWORK_PATH" "$DEST_FRAMEWORK"
else
    echo "Error: Framework not found at $FRAMEWORK_PATH"
    echo "Available files in build directory:"
    find "$BUILD_DIR" -name "*.framework" -type d 2>/dev/null || echo "No .framework directories found"
    find "$BUILD_DIR" -name "cbullet*" -type f 2>/dev/null || echo "No cbullet files found"
    exit 1
fi

echo "=========================================="
echo "Build complete!"
echo "Output: $DEST_DIR"
echo "=========================================="

# Verify the framework was created
if [ -d "$DEST_FRAMEWORK" ]; then
    echo "✓ Successfully built cbullet framework"
    ls -lah "$DEST_FRAMEWORK"

    # Show framework info
    echo ""
    echo "Framework info:"
    if [ -f "$DEST_FRAMEWORK/Info.plist" ]; then
        /usr/libexec/PlistBuddy -c "Print CFBundleIdentifier" "$DEST_FRAMEWORK/Info.plist" 2>/dev/null || echo "Could not read bundle identifier"
        /usr/libexec/PlistBuddy -c "Print CFBundleVersion" "$DEST_FRAMEWORK/Info.plist" 2>/dev/null || echo "Could not read bundle version"
    fi

    # Check if the binary exists
    if [ -f "$DEST_FRAMEWORK/cbullet" ]; then
        file "$DEST_FRAMEWORK/cbullet"
    else
        echo "Warning: Framework binary not found"
    fi
else
    echo "✗ Failed to build cbullet framework"
    exit 1
fi
