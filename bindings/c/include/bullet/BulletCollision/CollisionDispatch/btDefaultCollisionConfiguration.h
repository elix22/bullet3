// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btCollisionConfiguration btCollisionConfiguration; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionConfiguration.h>`.


///btCollisionConfiguration allows to configure Bullet collision detection
///stack allocator, pool memory allocators
///@todo: describe the meaning
/// Generated from class `btDefaultCollisionConfiguration`.
/// Base classes:
///   Direct: (non-virtual)
///     `btCollisionConfiguration`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btDefaultCollisionConfiguration btDefaultCollisionConfiguration;

/// Generated from constructor `btDefaultCollisionConfiguration::btDefaultCollisionConfiguration`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btDefaultCollisionConfiguration_Destroy()` to free it when you're done using it.
BULLET_API btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_ConstructFromAnother(Bullet_PassBy _other_pass_by, btDefaultCollisionConfiguration *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_OffsetPtr(const btDefaultCollisionConfiguration *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_OffsetMutablePtr(btDefaultCollisionConfiguration *ptr, ptrdiff_t i);

/// Upcasts an instance of `btDefaultCollisionConfiguration` to its base class `btCollisionConfiguration`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionConfiguration *btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration(const btDefaultCollisionConfiguration *object);

/// Upcasts an instance of `btDefaultCollisionConfiguration` to its base class `btCollisionConfiguration`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionConfiguration *btDefaultCollisionConfiguration_MutableUpcastTo_btCollisionConfiguration(btDefaultCollisionConfiguration *object);

/// Downcasts an instance of `btCollisionConfiguration` to a derived class `btDefaultCollisionConfiguration`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_StaticDowncastFrom_btCollisionConfiguration(const btCollisionConfiguration *object);

/// Downcasts an instance of `btCollisionConfiguration` to a derived class `btDefaultCollisionConfiguration`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_MutableStaticDowncastFrom_btCollisionConfiguration(btCollisionConfiguration *object);

/// Downcasts an instance of `btCollisionConfiguration` to a derived class `btDefaultCollisionConfiguration`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration(const btCollisionConfiguration *object);

/// Downcasts an instance of `btCollisionConfiguration` to a derived class `btDefaultCollisionConfiguration`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_MutableDynamicDowncastFrom_btCollisionConfiguration(btCollisionConfiguration *object);

/// Downcasts an instance of `btCollisionConfiguration` to a derived class `btDefaultCollisionConfiguration`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_DynamicDowncastFromOrFail_btCollisionConfiguration(const btCollisionConfiguration *object);

/// Downcasts an instance of `btCollisionConfiguration` to a derived class `btDefaultCollisionConfiguration`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_MutableDynamicDowncastFromOrFail_btCollisionConfiguration(btCollisionConfiguration *object);

/// Destroys a heap-allocated instance of `btDefaultCollisionConfiguration`. Does nothing if the pointer is null.
BULLET_API void btDefaultCollisionConfiguration_Destroy(const btDefaultCollisionConfiguration *_this);

/// Destroys a heap-allocated array of `btDefaultCollisionConfiguration`. Does nothing if the pointer is null.
BULLET_API void btDefaultCollisionConfiguration_DestroyArray(const btDefaultCollisionConfiguration *_this);

/// Generated from method `btDefaultCollisionConfiguration::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_AssignFromAnother(btDefaultCollisionConfiguration *_this, Bullet_PassBy _other_pass_by, btDefaultCollisionConfiguration *_other);

///Use this method to allow to generate multiple contact points between at once, between two objects using the generic convex-convex algorithm.
///By default, this feature is disabled for best performance.
///@param numPerturbationIterations controls the number of collision queries. Set it to zero to disable the feature.
///@param minimumPointsPerturbationThreshold is the minimum number of points in the contact cache, above which the feature is disabled
///3 is a good value for both params, if you want to enable the feature. This is because the default contact cache contains a maximum of 4 points, and one collision query at the unperturbed orientation is performed first.
///See Bullet/Demos/CollisionDemo for an example how this feature gathers multiple points.
///@todo we could add a per-object setting of those parameters, for level-of-detail collision detection.
/// Generated from method `btDefaultCollisionConfiguration::setConvexConvexMultipointIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `numPerturbationIterations` has a default argument: `3`, pass a null pointer to use it.
/// Parameter `minimumPointsPerturbationThreshold` has a default argument: `3`, pass a null pointer to use it.
BULLET_API void btDefaultCollisionConfiguration_setConvexConvexMultipointIterations(btDefaultCollisionConfiguration *_this, const int *numPerturbationIterations, const int *minimumPointsPerturbationThreshold);

/// Generated from method `btDefaultCollisionConfiguration::setPlaneConvexMultipointIterations`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `numPerturbationIterations` has a default argument: `3`, pass a null pointer to use it.
/// Parameter `minimumPointsPerturbationThreshold` has a default argument: `3`, pass a null pointer to use it.
BULLET_API void btDefaultCollisionConfiguration_setPlaneConvexMultipointIterations(btDefaultCollisionConfiguration *_this, const int *numPerturbationIterations, const int *minimumPointsPerturbationThreshold);

#ifdef __cplusplus
} // extern "C"
#endif
