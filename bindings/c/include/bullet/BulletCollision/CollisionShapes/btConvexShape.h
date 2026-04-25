// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btCollisionShape btCollisionShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btCollisionShape.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


/// The btConvexShape is an abstract shape interface, implemented by all convex shapes such as btBoxShape, btConvexHullShape etc.
/// It describes general convex shapes using the localGetSupportingVertex interface, used by collision detectors such as btGjkPairDetector.
/// Generated from class `btConvexShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `btCollisionShape`
/// Derived classes:
///   Direct: (non-virtual)
///     `btConvexInternalShape`
///   Indirect: (non-virtual)
///     `btBoxShape`
///     `btCapsuleShape`
///     `btConvexInternalAabbCachingShape`
///     `btPolyhedralConvexAabbCachingShape`
///     `btPolyhedralConvexShape`
///     `btSphereShape`
typedef struct btConvexShape btConvexShape;

/// Destroys a heap-allocated instance of `btConvexShape`. Does nothing if the pointer is null.
BULLET_API void btConvexShape_Destroy(const btConvexShape *_this);

/// Destroys a heap-allocated array of `btConvexShape`. Does nothing if the pointer is null.
BULLET_API void btConvexShape_DestroyArray(const btConvexShape *_this);

/// Generated from method `btConvexShape::operator new`.
BULLET_API void *Bullet_new_btConvexShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btConvexShape::operator delete`.
BULLET_API void Bullet_delete_btConvexShape_void_ptr(void *ptr);

/// Generated from method `btConvexShape::operator new`.
BULLET_API void *Bullet_new_btConvexShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btConvexShape::operator delete`.
BULLET_API void Bullet_delete_btConvexShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btConvexShape::operator new[]`.
BULLET_API void *Bullet_new_array_btConvexShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btConvexShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btConvexShape_void_ptr(void *ptr);

/// Generated from method `btConvexShape::operator new[]`.
BULLET_API void *Bullet_new_array_btConvexShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btConvexShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btConvexShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btConvexShape::localGetSupportingVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexShape_localGetSupportingVertex(const btConvexShape *_this, const btVector3 *vec);

/// Generated from method `btConvexShape::localGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexShape_localGetSupportingVertexWithoutMargin(const btConvexShape *_this, const btVector3 *vec);

/// Generated from method `btConvexShape::localGetSupportVertexWithoutMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexShape_localGetSupportVertexWithoutMarginNonVirtual(const btConvexShape *_this, const btVector3 *vec);

/// Generated from method `btConvexShape::localGetSupportVertexNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexShape_localGetSupportVertexNonVirtual(const btConvexShape *_this, const btVector3 *vec);

/// Generated from method `btConvexShape::getMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexShape_getMarginNonVirtual(const btConvexShape *_this);

/// Generated from method `btConvexShape::getAabbNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btConvexShape_getAabbNonVirtual(const btConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btConvexShape::project`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
/// Parameter `dir` can not be null. It is a single object.
/// Parameter `minProj` can not be null. It is a single object.
/// Parameter `maxProj` can not be null. It is a single object.
/// Parameter `witnesPtMin` can not be null. It is a single object.
/// Parameter `witnesPtMax` can not be null. It is a single object.
BULLET_API void btConvexShape_project(const btConvexShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax);

//notice that the vectors should be unit length
/// Generated from method `btConvexShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btConvexShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors);

///getAabb's default implementation is brute force, expected derived classes to implement a fast dedicated version
/// Generated from method `btConvexShape::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btConvexShape_getAabb(const btConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btConvexShape::getAabbSlow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btConvexShape_getAabbSlow(const btConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btConvexShape::setLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `scaling` can not be null. It is a single object.
BULLET_API void btConvexShape_setLocalScaling(btConvexShape *_this, const btVector3 *scaling);

/// Generated from method `btConvexShape::getLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btConvexShape_getLocalScaling(const btConvexShape *_this);

/// Generated from method `btConvexShape::setMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexShape_setMargin(btConvexShape *_this, double margin);

/// Generated from method `btConvexShape::getMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexShape_getMargin(const btConvexShape *_this);

/// Generated from method `btConvexShape::getNumPreferredPenetrationDirections`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexShape_getNumPreferredPenetrationDirections(const btConvexShape *_this);

/// Generated from method `btConvexShape::getPreferredPenetrationDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `penetrationVector` can not be null. It is a single object.
BULLET_API void btConvexShape_getPreferredPenetrationDirection(const btConvexShape *_this, int index, btVector3 *penetrationVector);

/// Generated from method `btConvexShape::getBoundingSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `center` can not be null. It is a single object.
/// Parameter `radius` can not be null. It is a single object.
BULLET_API void btConvexShape_getBoundingSphere(const btConvexShape *_this, btVector3 *center, double *radius);

///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
/// Generated from method `btConvexShape::getAngularMotionDisc`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexShape_getAngularMotionDisc(const btConvexShape *_this);

/// Generated from method `btConvexShape::getContactBreakingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexShape_getContactBreakingThreshold(const btConvexShape *_this, double defaultContactThresholdFactor);

///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
///result is conservative
/// Generated from method `btConvexShape::calculateTemporalAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `curTrans` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
/// Parameter `temporalAabbMin` can not be null. It is a single object.
/// Parameter `temporalAabbMax` can not be null. It is a single object.
BULLET_API void btConvexShape_calculateTemporalAabb(const btConvexShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax);

/// Generated from method `btConvexShape::isPolyhedral`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexShape_isPolyhedral(const btConvexShape *_this);

/// Generated from method `btConvexShape::isConvex2d`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexShape_isConvex2d(const btConvexShape *_this);

/// Generated from method `btConvexShape::isConvex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexShape_isConvex(const btConvexShape *_this);

/// Generated from method `btConvexShape::isNonMoving`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexShape_isNonMoving(const btConvexShape *_this);

/// Generated from method `btConvexShape::isConcave`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexShape_isConcave(const btConvexShape *_this);

/// Generated from method `btConvexShape::isCompound`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexShape_isCompound(const btConvexShape *_this);

/// Generated from method `btConvexShape::isSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexShape_isSoftBody(const btConvexShape *_this);

///isInfinite is used to catch simulation error (aabb check)
/// Generated from method `btConvexShape::isInfinite`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexShape_isInfinite(const btConvexShape *_this);

/// Generated from method `btConvexShape::calculateLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btConvexShape_calculateLocalInertia(const btConvexShape *_this, double mass, btVector3 *inertia);

//debugging support
/// Generated from method `btConvexShape::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btConvexShape_getName(const btConvexShape *_this);

/// Generated from method `btConvexShape::getShapeType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexShape_getShapeType(const btConvexShape *_this);

///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
///See Bullet/Demos/RollingFrictionDemo for an example
/// Generated from method `btConvexShape::getAnisotropicRollingFrictionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexShape_getAnisotropicRollingFrictionDirection(const btConvexShape *_this);

///optional user data pointer
/// Generated from method `btConvexShape::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexShape_setUserPointer(btConvexShape *_this, void *userPtr);

/// Generated from method `btConvexShape::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btConvexShape_getUserPointer(const btConvexShape *_this);

/// Generated from method `btConvexShape::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexShape_setUserIndex(btConvexShape *_this, int index);

/// Generated from method `btConvexShape::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexShape_getUserIndex(const btConvexShape *_this);

/// Generated from method `btConvexShape::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexShape_setUserIndex2(btConvexShape *_this, int index);

/// Generated from method `btConvexShape::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexShape_getUserIndex2(const btConvexShape *_this);

// clang-format on
/// Generated from method `btConvexShape::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexShape_calculateSerializeBufferSize(const btConvexShape *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btConvexShape *btConvexShape_OffsetPtr(const btConvexShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btConvexShape *btConvexShape_OffsetMutablePtr(btConvexShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `btConvexShape` to its base class `btCollisionShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionShape *btConvexShape_UpcastTo_btCollisionShape(const btConvexShape *object);

/// Upcasts an instance of `btConvexShape` to its base class `btCollisionShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionShape *btConvexShape_MutableUpcastTo_btCollisionShape(btConvexShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexShape *btConvexShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexShape *btConvexShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexShape *btConvexShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexShape *btConvexShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btConvexShape *btConvexShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btConvexShape *btConvexShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object);

#ifdef __cplusplus
} // extern "C"
#endif
