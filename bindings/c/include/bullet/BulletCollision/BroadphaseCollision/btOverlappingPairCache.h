// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btDispatcher btDispatcher; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btDispatcher.h>`.


///The btOverlappingPairCache provides an interface for overlapping pair management (add, remove, storage), used by the btBroadphaseInterface broadphases.
///The btHashedOverlappingPairCache and btSortedOverlappingPairCache classes are two implementations.
/// Generated from class `btOverlappingPairCache`.
typedef struct btOverlappingPairCache btOverlappingPairCache;

/// Destroys a heap-allocated instance of `btOverlappingPairCache`. Does nothing if the pointer is null.
BULLET_API void btOverlappingPairCache_Destroy(const btOverlappingPairCache *_this);

/// Destroys a heap-allocated array of `btOverlappingPairCache`. Does nothing if the pointer is null.
BULLET_API void btOverlappingPairCache_DestroyArray(const btOverlappingPairCache *_this);

/// Generated from method `btOverlappingPairCache::getNumOverlappingPairs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btOverlappingPairCache_getNumOverlappingPairs(const btOverlappingPairCache *_this);

/// Generated from method `btOverlappingPairCache::hasDeferredRemoval`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btOverlappingPairCache_hasDeferredRemoval(btOverlappingPairCache *_this);

/// Generated from method `btOverlappingPairCache::sortOverlappingPairs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btOverlappingPairCache_sortOverlappingPairs(btOverlappingPairCache *_this, btDispatcher *dispatcher);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btOverlappingPairCache *btOverlappingPairCache_OffsetPtr(const btOverlappingPairCache *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btOverlappingPairCache *btOverlappingPairCache_OffsetMutablePtr(btOverlappingPairCache *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
