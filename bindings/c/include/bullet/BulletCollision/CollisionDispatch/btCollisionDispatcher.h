// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btCollisionConfiguration btCollisionConfiguration; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionConfiguration.h>`.
typedef struct btCollisionObject btCollisionObject; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionObject.h>`.
typedef struct btDispatcher btDispatcher; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btDispatcher.h>`.


typedef enum btCollisionDispatcher_DispatcherFlags
{
    btCollisionDispatcher_DispatcherFlags_CD_STATIC_STATIC_REPORTED = 1,
    btCollisionDispatcher_DispatcherFlags_CD_USE_RELATIVE_CONTACT_BREAKING_THRESHOLD = 2,
    btCollisionDispatcher_DispatcherFlags_CD_DISABLE_CONTACTPOOL_DYNAMIC_ALLOCATION = 4,
} btCollisionDispatcher_DispatcherFlags;

///btCollisionDispatcher supports algorithms that handle ConvexConvex and ConvexConcave collision pairs.
///Time of Impact, Closest Points and Penetration Depth.
/// Generated from class `btCollisionDispatcher`.
/// Base classes:
///   Direct: (non-virtual)
///     `btDispatcher`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionDispatcher btCollisionDispatcher;

/// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionDispatcher_Destroy()` to free it when you're done using it.
BULLET_API btCollisionDispatcher *btCollisionDispatcher_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionDispatcher *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionDispatcher *btCollisionDispatcher_OffsetPtr(const btCollisionDispatcher *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionDispatcher *btCollisionDispatcher_OffsetMutablePtr(btCollisionDispatcher *ptr, ptrdiff_t i);

/// Upcasts an instance of `btCollisionDispatcher` to its base class `btDispatcher`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDispatcher *btCollisionDispatcher_UpcastTo_btDispatcher(const btCollisionDispatcher *object);

/// Upcasts an instance of `btCollisionDispatcher` to its base class `btDispatcher`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDispatcher *btCollisionDispatcher_MutableUpcastTo_btDispatcher(btCollisionDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcher`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionDispatcher *btCollisionDispatcher_StaticDowncastFrom_btDispatcher(const btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcher`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionDispatcher *btCollisionDispatcher_MutableStaticDowncastFrom_btDispatcher(btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcher`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionDispatcher *btCollisionDispatcher_DynamicDowncastFrom_btDispatcher(const btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcher`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionDispatcher *btCollisionDispatcher_MutableDynamicDowncastFrom_btDispatcher(btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcher`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btCollisionDispatcher *btCollisionDispatcher_DynamicDowncastFromOrFail_btDispatcher(const btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcher`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btCollisionDispatcher *btCollisionDispatcher_MutableDynamicDowncastFromOrFail_btDispatcher(btDispatcher *object);

/// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionDispatcher_Destroy()` to free it when you're done using it.
BULLET_API btCollisionDispatcher *btCollisionDispatcher_Construct(btCollisionConfiguration *collisionConfiguration);

/// Destroys a heap-allocated instance of `btCollisionDispatcher`. Does nothing if the pointer is null.
BULLET_API void btCollisionDispatcher_Destroy(const btCollisionDispatcher *_this);

/// Destroys a heap-allocated array of `btCollisionDispatcher`. Does nothing if the pointer is null.
BULLET_API void btCollisionDispatcher_DestroyArray(const btCollisionDispatcher *_this);

/// Generated from method `btCollisionDispatcher::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionDispatcher *btCollisionDispatcher_AssignFromAnother(btCollisionDispatcher *_this, Bullet_PassBy _other_pass_by, btCollisionDispatcher *_other);

/// Generated from method `btCollisionDispatcher::getDispatcherFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionDispatcher_getDispatcherFlags(const btCollisionDispatcher *_this);

/// Generated from method `btCollisionDispatcher::setDispatcherFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionDispatcher_setDispatcherFlags(btCollisionDispatcher *_this, int flags);

/// Generated from method `btCollisionDispatcher::getNumManifolds`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionDispatcher_getNumManifolds(const btCollisionDispatcher *_this);

/// Generated from method `btCollisionDispatcher::needsCollision`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionDispatcher_needsCollision(btCollisionDispatcher *_this, const btCollisionObject *body0, const btCollisionObject *body1);

/// Generated from method `btCollisionDispatcher::needsResponse`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionDispatcher_needsResponse(btCollisionDispatcher *_this, const btCollisionObject *body0, const btCollisionObject *body1);

/// Generated from method `btCollisionDispatcher::allocateCollisionAlgorithm`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btCollisionDispatcher_allocateCollisionAlgorithm(btCollisionDispatcher *_this, int size);

/// Generated from method `btCollisionDispatcher::freeCollisionAlgorithm`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionDispatcher_freeCollisionAlgorithm(btCollisionDispatcher *_this, void *ptr);

/// Generated from method `btCollisionDispatcher::getCollisionConfiguration`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btCollisionConfiguration *btCollisionDispatcher_getCollisionConfiguration_mut(btCollisionDispatcher *_this);

/// Generated from method `btCollisionDispatcher::getCollisionConfiguration`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btCollisionConfiguration *btCollisionDispatcher_getCollisionConfiguration(const btCollisionDispatcher *_this);

/// Generated from method `btCollisionDispatcher::setCollisionConfiguration`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionDispatcher_setCollisionConfiguration(btCollisionDispatcher *_this, btCollisionConfiguration *config);

#ifdef __cplusplus
} // extern "C"
#endif
