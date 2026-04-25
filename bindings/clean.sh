#!/bin/bash

SCRIPT_DIR="$(cd "$(dirname "$BASH_SOURCE")" && pwd)"
cd "$SCRIPT_DIR/../../.."   # repo root

rm -rf deps/bullet/bindings/c \
       deps/bullet/bindings/csharp/src \
       deps/bullet/bindings/csharp/bin \
       deps/bullet/bindings/csharp/obj \
       deps/bullet/bindings/tmp
