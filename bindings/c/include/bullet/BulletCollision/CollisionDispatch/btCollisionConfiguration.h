// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


///btCollisionConfiguration allows to configure Bullet collision detection
///stack allocator size, default collision algorithms and persistent manifold pool size
///@todo: describe the meaning
/// Generated from class `btCollisionConfiguration`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btDefaultCollisionConfiguration`
typedef struct btCollisionConfiguration btCollisionConfiguration;

/// Destroys a heap-allocated instance of `btCollisionConfiguration`. Does nothing if the pointer is null.
BULLET_API void btCollisionConfiguration_Destroy(const btCollisionConfiguration *_this);

/// Destroys a heap-allocated array of `btCollisionConfiguration`. Does nothing if the pointer is null.
BULLET_API void btCollisionConfiguration_DestroyArray(const btCollisionConfiguration *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionConfiguration *btCollisionConfiguration_OffsetPtr(const btCollisionConfiguration *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionConfiguration *btCollisionConfiguration_OffsetMutablePtr(btCollisionConfiguration *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
