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

if(MSVC)
    # /EHsc (the CMake default) assumes extern "C" functions are noexcept (/EHc).
    # In that noexcept context MSVC tries to verify copy-constructibility of ternary
    # result types, triggering C2280 on non-copyable Bullet classes.
    # Replace /EHsc with /EHs to drop that assumption while keeping C++ exception support.
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
