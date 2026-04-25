# Build script for cbullet library on Windows
# Usage: .\build-cbullet-windows.ps1 [-Architecture <arch>] [-BuildType <type>]
# Example: .\build-cbullet-windows.ps1 -Architecture x64 -BuildType Release
# Example: .\build-cbullet-windows.ps1 -Architecture Win32 -BuildType Debug
# Architectures: x64, Win32, ARM64

param(
    [string]$Architecture = "x64",
    [string]$BuildType = "Release"
)

$ErrorActionPreference = "Stop"

$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$BulletDir = Split-Path -Parent $ScriptDir
$BindingsCDir = Join-Path $BulletDir "bindings\c"
$BuildDir = Join-Path $BulletDir "build-windows-$Architecture"

Write-Host "==========================================" -ForegroundColor Cyan
Write-Host "Building cbullet for Windows" -ForegroundColor Cyan
Write-Host "Architecture: $Architecture" -ForegroundColor Cyan
Write-Host "Build Type: $BuildType" -ForegroundColor Cyan
Write-Host "==========================================" -ForegroundColor Cyan

# Create build directory
New-Item -ItemType Directory -Force -Path $BuildDir | Out-Null
Set-Location $BuildDir

# Configure with CMake
Write-Host "Configuring CMake..." -ForegroundColor Yellow
cmake $BindingsCDir `
    -G "Visual Studio 17 2022" `
    -A $Architecture `
    -DCMAKE_BUILD_TYPE="$BuildType"

if ($LASTEXITCODE -ne 0) {
    Write-Host "✗ CMake configuration failed" -ForegroundColor Red
    exit 1
}

# Build
Write-Host "Building..." -ForegroundColor Yellow
cmake --build . --config $BuildType

if ($LASTEXITCODE -ne 0) {
    Write-Host "✗ Build failed" -ForegroundColor Red
    exit 1
}

Write-Host "==========================================" -ForegroundColor Cyan
Write-Host "Build complete!" -ForegroundColor Green
Write-Host "Output: $BuildDir\$BuildType\cbullet.dll" -ForegroundColor Green
Write-Host "==========================================" -ForegroundColor Cyan

# Verify the library was created
$DllPath = Join-Path $BuildDir "$BuildType\cbullet.dll"
if (Test-Path $DllPath) {
    Write-Host "✓ Successfully built cbullet.dll" -ForegroundColor Green
    Get-Item $DllPath | Format-Table Name, Length, LastWriteTime

    # Copy to libs folder
    $BuildTypeLower = $BuildType.ToLower()
    $OutputDir = Join-Path $BulletDir "libs\windows\$Architecture\$BuildTypeLower"
    New-Item -ItemType Directory -Force -Path $OutputDir | Out-Null
    Copy-Item $DllPath $OutputDir

    Write-Host "==========================================" -ForegroundColor Cyan
    Write-Host "✓ Copied to: $OutputDir\cbullet.dll" -ForegroundColor Green
    Write-Host "==========================================" -ForegroundColor Cyan
} else {
    Write-Host "✗ Failed to build cbullet.dll" -ForegroundColor Red
    exit 1
}
