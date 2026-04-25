// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btCollisionShape btCollisionShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btCollisionShape.h>`.
typedef struct btConvexShape btConvexShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btConvexShape.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///The btConvexInternalShape is an internal base class, shared by most convex shape implementations.
///The btConvexInternalShape uses a default collision margin set to CONVEX_DISTANCE_MARGIN.
///This collision margin used by Gjk and some other algorithms, see also btCollisionMargin.h
///Note that when creating small shapes (derived from btConvexInternalShape),
///you need to make sure to set a smaller collision margin, using the 'setMargin' API
///There is a automatic mechanism 'setSafeMargin' used by btBoxShape and btCylinderShape
/// Generated from class `btConvexInternalShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `btConvexShape`
///   Indirect: (non-virtual)
///     `btCollisionShape`
/// Derived classes:
///   Direct: (non-virtual)
///     `btCapsuleShape`
///     `btConvexInternalAabbCachingShape`
///     `btPolyhedralConvexShape`
///     `btSphereShape`
///   Indirect: (non-virtual)
///     `btBoxShape`
///     `btPolyhedralConvexAabbCachingShape`
typedef struct btConvexInternalShape btConvexInternalShape;

///btConvexInternalAabbCachingShape adds local aabb caching for convex shapes, to avoid expensive bounding box calculations
/// Generated from class `btConvexInternalAabbCachingShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `btConvexInternalShape`
///   Indirect: (non-virtual)
///     `btCollisionShape`
///     `btConvexShape`
typedef struct btConvexInternalAabbCachingShape btConvexInternalAabbCachingShape;

/// Destroys a heap-allocated instance of `btConvexInternalShape`. Does nothing if the pointer is null.
BULLET_API void btConvexInternalShape_Destroy(const btConvexInternalShape *_this);

/// Destroys a heap-allocated array of `btConvexInternalShape`. Does nothing if the pointer is null.
BULLET_API void btConvexInternalShape_DestroyArray(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::operator new`.
BULLET_API void *Bullet_new_btConvexInternalShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btConvexInternalShape::operator delete`.
BULLET_API void Bullet_delete_btConvexInternalShape_void_ptr(void *ptr);

/// Generated from method `btConvexInternalShape::operator new`.
BULLET_API void *Bullet_new_btConvexInternalShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btConvexInternalShape::operator delete`.
BULLET_API void Bullet_delete_btConvexInternalShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btConvexInternalShape::operator new[]`.
BULLET_API void *Bullet_new_array_btConvexInternalShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btConvexInternalShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btConvexInternalShape_void_ptr(void *ptr);

/// Generated from method `btConvexInternalShape::operator new[]`.
BULLET_API void *Bullet_new_array_btConvexInternalShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btConvexInternalShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btConvexInternalShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btConvexInternalShape::localGetSupportingVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalShape_localGetSupportingVertex(const btConvexInternalShape *_this, const btVector3 *vec);

/// Generated from method `btConvexInternalShape::getImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btConvexInternalShape_getImplicitShapeDimensions(const btConvexInternalShape *_this);

///warning: use setImplicitShapeDimensions with care
///changing a collision shape while the body is in the world is not recommended,
///it is best to remove the body from the world, then make the change, and re-add it
///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
/// Generated from method `btConvexInternalShape::setImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `dimensions` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_setImplicitShapeDimensions(btConvexInternalShape *_this, const btVector3 *dimensions);

/// Generated from method `btConvexInternalShape::setSafeMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `defaultMarginMultiplier` has a default argument: `0.100000001f`, pass a null pointer to use it.
BULLET_API void btConvexInternalShape_setSafeMargin_double(btConvexInternalShape *_this, double minDimension, const double *defaultMarginMultiplier);

/// Generated from method `btConvexInternalShape::setSafeMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `halfExtents` can not be null. It is a single object.
/// Parameter `defaultMarginMultiplier` has a default argument: `0.100000001f`, pass a null pointer to use it.
BULLET_API void btConvexInternalShape_setSafeMargin_btVector3(btConvexInternalShape *_this, const btVector3 *halfExtents, const double *defaultMarginMultiplier);

///getAabb's default implementation is brute force, expected derived classes to implement a fast dedicated version
/// Generated from method `btConvexInternalShape::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_getAabb(const btConvexInternalShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btConvexInternalShape::getAabbSlow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_getAabbSlow(const btConvexInternalShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btConvexInternalShape::setLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `scaling` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_setLocalScaling(btConvexInternalShape *_this, const btVector3 *scaling);

/// Generated from method `btConvexInternalShape::getLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btConvexInternalShape_getLocalScaling(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::getLocalScalingNV`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btConvexInternalShape_getLocalScalingNV(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::setMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_setMargin(btConvexInternalShape *_this, double margin);

/// Generated from method `btConvexInternalShape::getMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalShape_getMargin(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::getMarginNV`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalShape_getMarginNV(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::getNumPreferredPenetrationDirections`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalShape_getNumPreferredPenetrationDirections(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::getPreferredPenetrationDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `penetrationVector` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_getPreferredPenetrationDirection(const btConvexInternalShape *_this, int index, btVector3 *penetrationVector);

/// Generated from method `btConvexInternalShape::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalShape_calculateSerializeBufferSize(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::localGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalShape_localGetSupportingVertexWithoutMargin(const btConvexInternalShape *_this, const btVector3 *vec);

/// Generated from method `btConvexInternalShape::localGetSupportVertexWithoutMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalShape_localGetSupportVertexWithoutMarginNonVirtual(const btConvexInternalShape *_this, const btVector3 *vec);

/// Generated from method `btConvexInternalShape::localGetSupportVertexNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalShape_localGetSupportVertexNonVirtual(const btConvexInternalShape *_this, const btVector3 *vec);

/// Generated from method `btConvexInternalShape::getMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalShape_getMarginNonVirtual(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::getAabbNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_getAabbNonVirtual(const btConvexInternalShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btConvexInternalShape::project`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
/// Parameter `dir` can not be null. It is a single object.
/// Parameter `minProj` can not be null. It is a single object.
/// Parameter `maxProj` can not be null. It is a single object.
/// Parameter `witnesPtMin` can not be null. It is a single object.
/// Parameter `witnesPtMax` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_project(const btConvexInternalShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax);

//notice that the vectors should be unit length
/// Generated from method `btConvexInternalShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btConvexInternalShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors);

/// Generated from method `btConvexInternalShape::getBoundingSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `center` can not be null. It is a single object.
/// Parameter `radius` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_getBoundingSphere(const btConvexInternalShape *_this, btVector3 *center, double *radius);

///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
/// Generated from method `btConvexInternalShape::getAngularMotionDisc`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalShape_getAngularMotionDisc(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::getContactBreakingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalShape_getContactBreakingThreshold(const btConvexInternalShape *_this, double defaultContactThresholdFactor);

///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
///result is conservative
/// Generated from method `btConvexInternalShape::calculateTemporalAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `curTrans` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
/// Parameter `temporalAabbMin` can not be null. It is a single object.
/// Parameter `temporalAabbMax` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_calculateTemporalAabb(const btConvexInternalShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax);

/// Generated from method `btConvexInternalShape::isPolyhedral`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalShape_isPolyhedral(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::isConvex2d`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalShape_isConvex2d(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::isConvex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalShape_isConvex(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::isNonMoving`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalShape_isNonMoving(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::isConcave`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalShape_isConcave(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::isCompound`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalShape_isCompound(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::isSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalShape_isSoftBody(const btConvexInternalShape *_this);

///isInfinite is used to catch simulation error (aabb check)
/// Generated from method `btConvexInternalShape::isInfinite`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalShape_isInfinite(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::calculateLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_calculateLocalInertia(const btConvexInternalShape *_this, double mass, btVector3 *inertia);

//debugging support
/// Generated from method `btConvexInternalShape::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btConvexInternalShape_getName(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::getShapeType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalShape_getShapeType(const btConvexInternalShape *_this);

///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
///See Bullet/Demos/RollingFrictionDemo for an example
/// Generated from method `btConvexInternalShape::getAnisotropicRollingFrictionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalShape_getAnisotropicRollingFrictionDirection(const btConvexInternalShape *_this);

///optional user data pointer
/// Generated from method `btConvexInternalShape::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_setUserPointer(btConvexInternalShape *_this, void *userPtr);

/// Generated from method `btConvexInternalShape::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btConvexInternalShape_getUserPointer(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_setUserIndex(btConvexInternalShape *_this, int index);

/// Generated from method `btConvexInternalShape::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalShape_getUserIndex(const btConvexInternalShape *_this);

/// Generated from method `btConvexInternalShape::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalShape_setUserIndex2(btConvexInternalShape *_this, int index);

/// Generated from method `btConvexInternalShape::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalShape_getUserIndex2(const btConvexInternalShape *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btConvexInternalShape_OffsetPtr(const btConvexInternalShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btConvexInternalShape *btConvexInternalShape_OffsetMutablePtr(btConvexInternalShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `btConvexInternalShape` to its base class `btCollisionShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionShape *btConvexInternalShape_UpcastTo_btCollisionShape(const btConvexInternalShape *object);

/// Upcasts an instance of `btConvexInternalShape` to its base class `btCollisionShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionShape *btConvexInternalShape_MutableUpcastTo_btCollisionShape(btConvexInternalShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btConvexInternalShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btConvexInternalShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btConvexInternalShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btConvexInternalShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btConvexInternalShape *btConvexInternalShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btConvexInternalShape *btConvexInternalShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object);

/// Upcasts an instance of `btConvexInternalShape` to its base class `btConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexShape *btConvexInternalShape_UpcastTo_btConvexShape(const btConvexInternalShape *object);

/// Upcasts an instance of `btConvexInternalShape` to its base class `btConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexShape *btConvexInternalShape_MutableUpcastTo_btConvexShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btConvexInternalShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btConvexInternalShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btConvexInternalShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btConvexInternalShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btConvexInternalShape *btConvexInternalShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btConvexInternalShape *btConvexInternalShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object);

/// Destroys a heap-allocated instance of `btConvexInternalAabbCachingShape`. Does nothing if the pointer is null.
BULLET_API void btConvexInternalAabbCachingShape_Destroy(const btConvexInternalAabbCachingShape *_this);

/// Destroys a heap-allocated array of `btConvexInternalAabbCachingShape`. Does nothing if the pointer is null.
BULLET_API void btConvexInternalAabbCachingShape_DestroyArray(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::setLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `scaling` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_setLocalScaling(btConvexInternalAabbCachingShape *_this, const btVector3 *scaling);

/// Generated from method `btConvexInternalAabbCachingShape::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_getAabb(const btConvexInternalAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btConvexInternalAabbCachingShape::recalcLocalAabb`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_recalcLocalAabb(btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::localGetSupportingVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalAabbCachingShape_localGetSupportingVertex(const btConvexInternalAabbCachingShape *_this, const btVector3 *vec);

/// Generated from method `btConvexInternalAabbCachingShape::getImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btConvexInternalAabbCachingShape_getImplicitShapeDimensions(const btConvexInternalAabbCachingShape *_this);

///warning: use setImplicitShapeDimensions with care
///changing a collision shape while the body is in the world is not recommended,
///it is best to remove the body from the world, then make the change, and re-add it
///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
/// Generated from method `btConvexInternalAabbCachingShape::setImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `dimensions` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_setImplicitShapeDimensions(btConvexInternalAabbCachingShape *_this, const btVector3 *dimensions);

/// Generated from method `btConvexInternalAabbCachingShape::getAabbSlow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_getAabbSlow(const btConvexInternalAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btConvexInternalAabbCachingShape::getLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btConvexInternalAabbCachingShape_getLocalScaling(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::getLocalScalingNV`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btConvexInternalAabbCachingShape_getLocalScalingNV(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::setMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_setMargin(btConvexInternalAabbCachingShape *_this, double margin);

/// Generated from method `btConvexInternalAabbCachingShape::getMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalAabbCachingShape_getMargin(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::getMarginNV`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalAabbCachingShape_getMarginNV(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::getNumPreferredPenetrationDirections`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalAabbCachingShape_getNumPreferredPenetrationDirections(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::getPreferredPenetrationDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `penetrationVector` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_getPreferredPenetrationDirection(const btConvexInternalAabbCachingShape *_this, int index, btVector3 *penetrationVector);

/// Generated from method `btConvexInternalAabbCachingShape::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalAabbCachingShape_calculateSerializeBufferSize(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::localGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalAabbCachingShape_localGetSupportingVertexWithoutMargin(const btConvexInternalAabbCachingShape *_this, const btVector3 *vec);

/// Generated from method `btConvexInternalAabbCachingShape::localGetSupportVertexWithoutMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual(const btConvexInternalAabbCachingShape *_this, const btVector3 *vec);

/// Generated from method `btConvexInternalAabbCachingShape::localGetSupportVertexNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalAabbCachingShape_localGetSupportVertexNonVirtual(const btConvexInternalAabbCachingShape *_this, const btVector3 *vec);

/// Generated from method `btConvexInternalAabbCachingShape::getMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalAabbCachingShape_getMarginNonVirtual(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::getAabbNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_getAabbNonVirtual(const btConvexInternalAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btConvexInternalAabbCachingShape::project`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
/// Parameter `dir` can not be null. It is a single object.
/// Parameter `minProj` can not be null. It is a single object.
/// Parameter `maxProj` can not be null. It is a single object.
/// Parameter `witnesPtMin` can not be null. It is a single object.
/// Parameter `witnesPtMax` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_project(const btConvexInternalAabbCachingShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax);

//notice that the vectors should be unit length
/// Generated from method `btConvexInternalAabbCachingShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btConvexInternalAabbCachingShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors);

/// Generated from method `btConvexInternalAabbCachingShape::getBoundingSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `center` can not be null. It is a single object.
/// Parameter `radius` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_getBoundingSphere(const btConvexInternalAabbCachingShape *_this, btVector3 *center, double *radius);

///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
/// Generated from method `btConvexInternalAabbCachingShape::getAngularMotionDisc`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalAabbCachingShape_getAngularMotionDisc(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::getContactBreakingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btConvexInternalAabbCachingShape_getContactBreakingThreshold(const btConvexInternalAabbCachingShape *_this, double defaultContactThresholdFactor);

///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
///result is conservative
/// Generated from method `btConvexInternalAabbCachingShape::calculateTemporalAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `curTrans` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
/// Parameter `temporalAabbMin` can not be null. It is a single object.
/// Parameter `temporalAabbMax` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_calculateTemporalAabb(const btConvexInternalAabbCachingShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax);

/// Generated from method `btConvexInternalAabbCachingShape::isPolyhedral`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalAabbCachingShape_isPolyhedral(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::isConvex2d`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalAabbCachingShape_isConvex2d(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::isConvex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalAabbCachingShape_isConvex(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::isNonMoving`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalAabbCachingShape_isNonMoving(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::isConcave`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalAabbCachingShape_isConcave(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::isCompound`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalAabbCachingShape_isCompound(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::isSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalAabbCachingShape_isSoftBody(const btConvexInternalAabbCachingShape *_this);

///isInfinite is used to catch simulation error (aabb check)
/// Generated from method `btConvexInternalAabbCachingShape::isInfinite`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btConvexInternalAabbCachingShape_isInfinite(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::calculateLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_calculateLocalInertia(const btConvexInternalAabbCachingShape *_this, double mass, btVector3 *inertia);

//debugging support
/// Generated from method `btConvexInternalAabbCachingShape::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btConvexInternalAabbCachingShape_getName(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::getShapeType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalAabbCachingShape_getShapeType(const btConvexInternalAabbCachingShape *_this);

///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
///See Bullet/Demos/RollingFrictionDemo for an example
/// Generated from method `btConvexInternalAabbCachingShape::getAnisotropicRollingFrictionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btConvexInternalAabbCachingShape_getAnisotropicRollingFrictionDirection(const btConvexInternalAabbCachingShape *_this);

///optional user data pointer
/// Generated from method `btConvexInternalAabbCachingShape::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_setUserPointer(btConvexInternalAabbCachingShape *_this, void *userPtr);

/// Generated from method `btConvexInternalAabbCachingShape::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btConvexInternalAabbCachingShape_getUserPointer(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_setUserIndex(btConvexInternalAabbCachingShape *_this, int index);

/// Generated from method `btConvexInternalAabbCachingShape::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalAabbCachingShape_getUserIndex(const btConvexInternalAabbCachingShape *_this);

/// Generated from method `btConvexInternalAabbCachingShape::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConvexInternalAabbCachingShape_setUserIndex2(btConvexInternalAabbCachingShape *_this, int index);

/// Generated from method `btConvexInternalAabbCachingShape::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btConvexInternalAabbCachingShape_getUserIndex2(const btConvexInternalAabbCachingShape *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_OffsetPtr(const btConvexInternalAabbCachingShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_OffsetMutablePtr(btConvexInternalAabbCachingShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `btConvexInternalAabbCachingShape` to its base class `btCollisionShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionShape *btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape(const btConvexInternalAabbCachingShape *object);

/// Upcasts an instance of `btConvexInternalAabbCachingShape` to its base class `btCollisionShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionShape *btConvexInternalAabbCachingShape_MutableUpcastTo_btCollisionShape(btConvexInternalAabbCachingShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object);

/// Upcasts an instance of `btConvexInternalAabbCachingShape` to its base class `btConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexShape *btConvexInternalAabbCachingShape_UpcastTo_btConvexShape(const btConvexInternalAabbCachingShape *object);

/// Upcasts an instance of `btConvexInternalAabbCachingShape` to its base class `btConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexShape *btConvexInternalAabbCachingShape_MutableUpcastTo_btConvexShape(btConvexInternalAabbCachingShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object);

/// Upcasts an instance of `btConvexInternalAabbCachingShape` to its base class `btConvexInternalShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape(const btConvexInternalAabbCachingShape *object);

/// Upcasts an instance of `btConvexInternalAabbCachingShape` to its base class `btConvexInternalShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btConvexInternalAabbCachingShape_MutableUpcastTo_btConvexInternalShape(btConvexInternalAabbCachingShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btConvexInternalAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object);

#ifdef __cplusplus
} // extern "C"
#endif
