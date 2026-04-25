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
typedef struct btCollisionDispatcher btCollisionDispatcher; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionDispatcher.h>`.
typedef struct btCollisionObject btCollisionObject; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionObject.h>`.
typedef struct btDispatcher btDispatcher; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btDispatcher.h>`.


/// Generated from class `btCollisionDispatcherMt`.
/// Base classes:
///   Direct: (non-virtual)
///     `btCollisionDispatcher`
///   Indirect: (non-virtual)
///     `btDispatcher`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionDispatcherMt btCollisionDispatcherMt;

/// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionDispatcherMt_Destroy()` to free it when you're done using it.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionDispatcherMt *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionDispatcherMt *btCollisionDispatcherMt_OffsetPtr(const btCollisionDispatcherMt *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_OffsetMutablePtr(btCollisionDispatcherMt *ptr, ptrdiff_t i);

/// Upcasts an instance of `btCollisionDispatcherMt` to its base class `btDispatcher`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDispatcher *btCollisionDispatcherMt_UpcastTo_btDispatcher(const btCollisionDispatcherMt *object);

/// Upcasts an instance of `btCollisionDispatcherMt` to its base class `btDispatcher`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDispatcher *btCollisionDispatcherMt_MutableUpcastTo_btDispatcher(btCollisionDispatcherMt *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionDispatcherMt *btCollisionDispatcherMt_StaticDowncastFrom_btDispatcher(const btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_MutableStaticDowncastFrom_btDispatcher(btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionDispatcherMt *btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher(const btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_MutableDynamicDowncastFrom_btDispatcher(btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btCollisionDispatcherMt *btCollisionDispatcherMt_DynamicDowncastFromOrFail_btDispatcher(const btDispatcher *object);

/// Downcasts an instance of `btDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_MutableDynamicDowncastFromOrFail_btDispatcher(btDispatcher *object);

/// Upcasts an instance of `btCollisionDispatcherMt` to its base class `btCollisionDispatcher`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionDispatcher *btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher(const btCollisionDispatcherMt *object);

/// Upcasts an instance of `btCollisionDispatcherMt` to its base class `btCollisionDispatcher`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionDispatcher *btCollisionDispatcherMt_MutableUpcastTo_btCollisionDispatcher(btCollisionDispatcherMt *object);

/// Downcasts an instance of `btCollisionDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionDispatcherMt *btCollisionDispatcherMt_StaticDowncastFrom_btCollisionDispatcher(const btCollisionDispatcher *object);

/// Downcasts an instance of `btCollisionDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_MutableStaticDowncastFrom_btCollisionDispatcher(btCollisionDispatcher *object);

/// Downcasts an instance of `btCollisionDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionDispatcherMt *btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher(const btCollisionDispatcher *object);

/// Downcasts an instance of `btCollisionDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_MutableDynamicDowncastFrom_btCollisionDispatcher(btCollisionDispatcher *object);

/// Downcasts an instance of `btCollisionDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btCollisionDispatcherMt *btCollisionDispatcherMt_DynamicDowncastFromOrFail_btCollisionDispatcher(const btCollisionDispatcher *object);

/// Downcasts an instance of `btCollisionDispatcher` to a derived class `btCollisionDispatcherMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_MutableDynamicDowncastFromOrFail_btCollisionDispatcher(btCollisionDispatcher *object);

/// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
/// Parameter `grainSize` has a default argument: `40`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionDispatcherMt_Destroy()` to free it when you're done using it.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_Construct(btCollisionConfiguration *config, const int *grainSize);

/// Destroys a heap-allocated instance of `btCollisionDispatcherMt`. Does nothing if the pointer is null.
BULLET_API void btCollisionDispatcherMt_Destroy(const btCollisionDispatcherMt *_this);

/// Destroys a heap-allocated array of `btCollisionDispatcherMt`. Does nothing if the pointer is null.
BULLET_API void btCollisionDispatcherMt_DestroyArray(const btCollisionDispatcherMt *_this);

/// Generated from method `btCollisionDispatcherMt::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionDispatcherMt *btCollisionDispatcherMt_AssignFromAnother(btCollisionDispatcherMt *_this, Bullet_PassBy _other_pass_by, btCollisionDispatcherMt *_other);

/// Generated from method `btCollisionDispatcherMt::getDispatcherFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionDispatcherMt_getDispatcherFlags(const btCollisionDispatcherMt *_this);

/// Generated from method `btCollisionDispatcherMt::setDispatcherFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionDispatcherMt_setDispatcherFlags(btCollisionDispatcherMt *_this, int flags);

/// Generated from method `btCollisionDispatcherMt::getNumManifolds`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionDispatcherMt_getNumManifolds(const btCollisionDispatcherMt *_this);

/// Generated from method `btCollisionDispatcherMt::needsCollision`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionDispatcherMt_needsCollision(btCollisionDispatcherMt *_this, const btCollisionObject *body0, const btCollisionObject *body1);

/// Generated from method `btCollisionDispatcherMt::needsResponse`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionDispatcherMt_needsResponse(btCollisionDispatcherMt *_this, const btCollisionObject *body0, const btCollisionObject *body1);

/// Generated from method `btCollisionDispatcherMt::allocateCollisionAlgorithm`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btCollisionDispatcherMt_allocateCollisionAlgorithm(btCollisionDispatcherMt *_this, int size);

/// Generated from method `btCollisionDispatcherMt::freeCollisionAlgorithm`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionDispatcherMt_freeCollisionAlgorithm(btCollisionDispatcherMt *_this, void *ptr);

/// Generated from method `btCollisionDispatcherMt::setCollisionConfiguration`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionDispatcherMt_setCollisionConfiguration(btCollisionDispatcherMt *_this, btCollisionConfiguration *config);

#ifdef __cplusplus
} // extern "C"
#endif
