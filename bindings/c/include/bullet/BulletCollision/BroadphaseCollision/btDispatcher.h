// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btCollisionObject btCollisionObject; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionObject.h>`.


///The btDispatcher interface class can be used in combination with broadphase to dispatch calculations for overlapping pairs.
///For example for pairwise collision detection, calculating contact points stored in btPersistentManifold or user callbacks (game logic).
/// Generated from class `btDispatcher`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btCollisionDispatcher`
typedef struct btDispatcher btDispatcher;

/// Destroys a heap-allocated instance of `btDispatcher`. Does nothing if the pointer is null.
BULLET_API void btDispatcher_Destroy(const btDispatcher *_this);

/// Destroys a heap-allocated array of `btDispatcher`. Does nothing if the pointer is null.
BULLET_API void btDispatcher_DestroyArray(const btDispatcher *_this);

/// Generated from method `btDispatcher::needsCollision`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDispatcher_needsCollision(btDispatcher *_this, const btCollisionObject *body0, const btCollisionObject *body1);

/// Generated from method `btDispatcher::needsResponse`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDispatcher_needsResponse(btDispatcher *_this, const btCollisionObject *body0, const btCollisionObject *body1);

/// Generated from method `btDispatcher::getNumManifolds`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btDispatcher_getNumManifolds(const btDispatcher *_this);

/// Generated from method `btDispatcher::allocateCollisionAlgorithm`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btDispatcher_allocateCollisionAlgorithm(btDispatcher *_this, int size);

/// Generated from method `btDispatcher::freeCollisionAlgorithm`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDispatcher_freeCollisionAlgorithm(btDispatcher *_this, void *ptr);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btDispatcher *btDispatcher_OffsetPtr(const btDispatcher *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btDispatcher *btDispatcher_OffsetMutablePtr(btDispatcher *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
