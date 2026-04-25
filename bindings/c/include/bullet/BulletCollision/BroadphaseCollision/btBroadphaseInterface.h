// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btDispatcher btDispatcher; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btDispatcher.h>`.
typedef struct btOverlappingPairCache btOverlappingPairCache; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///The btBroadphaseInterface class provides an interface to detect aabb-overlapping object pairs.
///Some implementations for this broadphase interface include btAxisSweep3, bt32BitAxisSweep3 and btDbvtBroadphase.
///The actual overlapping pair management, storage, adding and removing of pairs is dealt by the btOverlappingPairCache class.
/// Generated from class `btBroadphaseInterface`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btDbvtBroadphase`
typedef struct btBroadphaseInterface btBroadphaseInterface;

/// Destroys a heap-allocated instance of `btBroadphaseInterface`. Does nothing if the pointer is null.
BULLET_API void btBroadphaseInterface_Destroy(const btBroadphaseInterface *_this);

/// Destroys a heap-allocated array of `btBroadphaseInterface`. Does nothing if the pointer is null.
BULLET_API void btBroadphaseInterface_DestroyArray(const btBroadphaseInterface *_this);

///calculateOverlappingPairs is optional: incremental algorithms (sweep and prune) might do it during the set aabb
/// Generated from method `btBroadphaseInterface::calculateOverlappingPairs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btBroadphaseInterface_calculateOverlappingPairs(btBroadphaseInterface *_this, btDispatcher *dispatcher);

/// Generated from method `btBroadphaseInterface::getOverlappingPairCache`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btOverlappingPairCache *btBroadphaseInterface_getOverlappingPairCache_mut(btBroadphaseInterface *_this);

/// Generated from method `btBroadphaseInterface::getOverlappingPairCache`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btOverlappingPairCache *btBroadphaseInterface_getOverlappingPairCache(const btBroadphaseInterface *_this);

///getAabb returns the axis aligned bounding box in the 'global' coordinate frame
///will add some transform later
/// Generated from method `btBroadphaseInterface::getBroadphaseAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btBroadphaseInterface_getBroadphaseAabb(const btBroadphaseInterface *_this, btVector3 *aabbMin, btVector3 *aabbMax);

///reset broadphase internal structures, to ensure determinism/reproducability
/// Generated from method `btBroadphaseInterface::resetPool`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btBroadphaseInterface_resetPool(btBroadphaseInterface *_this, btDispatcher *dispatcher);

/// Generated from method `btBroadphaseInterface::printStats`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btBroadphaseInterface_printStats(btBroadphaseInterface *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btBroadphaseInterface *btBroadphaseInterface_OffsetPtr(const btBroadphaseInterface *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btBroadphaseInterface *btBroadphaseInterface_OffsetMutablePtr(btBroadphaseInterface *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
