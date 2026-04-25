// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btCollisionShape btCollisionShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btCollisionShape.h>`.
typedef struct btConvexInternalShape btConvexInternalShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btConvexInternalShape.h>`.
typedef struct btConvexShape btConvexShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btConvexShape.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///The btSphereShape implements an implicit sphere, centered around a local origin with radius.
/// Generated from class `btSphereShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `btConvexInternalShape`
///   Indirect: (non-virtual)
///     `btCollisionShape`
///     `btConvexShape`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btSphereShape btSphereShape;

/// Generated from constructor `btSphereShape::btSphereShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSphereShape_Destroy()` to free it when you're done using it.
BULLET_API btSphereShape *btSphereShape_ConstructFromAnother(Bullet_PassBy _other_pass_by, btSphereShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btSphereShape *btSphereShape_OffsetPtr(const btSphereShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btSphereShape *btSphereShape_OffsetMutablePtr(btSphereShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `btSphereShape` to its base class `btCollisionShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionShape *btSphereShape_UpcastTo_btCollisionShape(const btSphereShape *object);

/// Upcasts an instance of `btSphereShape` to its base class `btCollisionShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionShape *btSphereShape_MutableUpcastTo_btCollisionShape(btSphereShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btSphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSphereShape *btSphereShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btSphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSphereShape *btSphereShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSphereShape *btSphereShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSphereShape *btSphereShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btSphereShape *btSphereShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btSphereShape *btSphereShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object);

/// Upcasts an instance of `btSphereShape` to its base class `btConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexShape *btSphereShape_UpcastTo_btConvexShape(const btSphereShape *object);

/// Upcasts an instance of `btSphereShape` to its base class `btConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexShape *btSphereShape_MutableUpcastTo_btConvexShape(btSphereShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btSphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSphereShape *btSphereShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btSphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSphereShape *btSphereShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSphereShape *btSphereShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSphereShape *btSphereShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btSphereShape *btSphereShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btSphereShape *btSphereShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object);

/// Upcasts an instance of `btSphereShape` to its base class `btConvexInternalShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btSphereShape_UpcastTo_btConvexInternalShape(const btSphereShape *object);

/// Upcasts an instance of `btSphereShape` to its base class `btConvexInternalShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btSphereShape_MutableUpcastTo_btConvexInternalShape(btSphereShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btSphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSphereShape *btSphereShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btSphereShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSphereShape *btSphereShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSphereShape *btSphereShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSphereShape *btSphereShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btSphereShape *btSphereShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btSphereShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btSphereShape *btSphereShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object);

/// Generated from constructor `btSphereShape::btSphereShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSphereShape_Destroy()` to free it when you're done using it.
BULLET_API btSphereShape *btSphereShape_Construct(double radius);

/// Destroys a heap-allocated instance of `btSphereShape`. Does nothing if the pointer is null.
BULLET_API void btSphereShape_Destroy(const btSphereShape *_this);

/// Destroys a heap-allocated array of `btSphereShape`. Does nothing if the pointer is null.
BULLET_API void btSphereShape_DestroyArray(const btSphereShape *_this);

/// Generated from method `btSphereShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btSphereShape *btSphereShape_AssignFromAnother(btSphereShape *_this, Bullet_PassBy _other_pass_by, btSphereShape *_other);

/// Generated from method `btSphereShape::operator new`.
BULLET_API void *Bullet_new_btSphereShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btSphereShape::operator delete`.
BULLET_API void Bullet_delete_btSphereShape_void_ptr(void *ptr);

/// Generated from method `btSphereShape::operator new`.
BULLET_API void *Bullet_new_btSphereShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btSphereShape::operator delete`.
BULLET_API void Bullet_delete_btSphereShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btSphereShape::operator new[]`.
BULLET_API void *Bullet_new_array_btSphereShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btSphereShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btSphereShape_void_ptr(void *ptr);

/// Generated from method `btSphereShape::operator new[]`.
BULLET_API void *Bullet_new_array_btSphereShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btSphereShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btSphereShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btSphereShape::localGetSupportingVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btSphereShape_localGetSupportingVertex(const btSphereShape *_this, const btVector3 *vec);

/// Generated from method `btSphereShape::localGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btSphereShape_localGetSupportingVertexWithoutMargin(const btSphereShape *_this, const btVector3 *vec);

//notice that the vectors should be unit length
/// Generated from method `btSphereShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSphereShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btSphereShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors);

/// Generated from method `btSphereShape::calculateLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btSphereShape_calculateLocalInertia(const btSphereShape *_this, double mass, btVector3 *inertia);

/// Generated from method `btSphereShape::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btSphereShape_getAabb(const btSphereShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btSphereShape::getRadius`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btSphereShape_getRadius(const btSphereShape *_this);

/// Generated from method `btSphereShape::setUnscaledRadius`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSphereShape_setUnscaledRadius(btSphereShape *_this, double radius);

//debugging
/// Generated from method `btSphereShape::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btSphereShape_getName(const btSphereShape *_this);

/// Generated from method `btSphereShape::setMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSphereShape_setMargin(btSphereShape *_this, double margin);

/// Generated from method `btSphereShape::getMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btSphereShape_getMargin(const btSphereShape *_this);

/// Generated from method `btSphereShape::getImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btSphereShape_getImplicitShapeDimensions(const btSphereShape *_this);

///warning: use setImplicitShapeDimensions with care
///changing a collision shape while the body is in the world is not recommended,
///it is best to remove the body from the world, then make the change, and re-add it
///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
/// Generated from method `btSphereShape::setImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `dimensions` can not be null. It is a single object.
BULLET_API void btSphereShape_setImplicitShapeDimensions(btSphereShape *_this, const btVector3 *dimensions);

/// Generated from method `btSphereShape::getAabbSlow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btSphereShape_getAabbSlow(const btSphereShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btSphereShape::setLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `scaling` can not be null. It is a single object.
BULLET_API void btSphereShape_setLocalScaling(btSphereShape *_this, const btVector3 *scaling);

/// Generated from method `btSphereShape::getLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btSphereShape_getLocalScaling(const btSphereShape *_this);

/// Generated from method `btSphereShape::getLocalScalingNV`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btSphereShape_getLocalScalingNV(const btSphereShape *_this);

/// Generated from method `btSphereShape::getMarginNV`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btSphereShape_getMarginNV(const btSphereShape *_this);

/// Generated from method `btSphereShape::getNumPreferredPenetrationDirections`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btSphereShape_getNumPreferredPenetrationDirections(const btSphereShape *_this);

/// Generated from method `btSphereShape::getPreferredPenetrationDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `penetrationVector` can not be null. It is a single object.
BULLET_API void btSphereShape_getPreferredPenetrationDirection(const btSphereShape *_this, int index, btVector3 *penetrationVector);

/// Generated from method `btSphereShape::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btSphereShape_calculateSerializeBufferSize(const btSphereShape *_this);

/// Generated from method `btSphereShape::localGetSupportVertexWithoutMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btSphereShape_localGetSupportVertexWithoutMarginNonVirtual(const btSphereShape *_this, const btVector3 *vec);

/// Generated from method `btSphereShape::localGetSupportVertexNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btSphereShape_localGetSupportVertexNonVirtual(const btSphereShape *_this, const btVector3 *vec);

/// Generated from method `btSphereShape::getMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btSphereShape_getMarginNonVirtual(const btSphereShape *_this);

/// Generated from method `btSphereShape::getAabbNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btSphereShape_getAabbNonVirtual(const btSphereShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btSphereShape::project`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
/// Parameter `dir` can not be null. It is a single object.
/// Parameter `minProj` can not be null. It is a single object.
/// Parameter `maxProj` can not be null. It is a single object.
/// Parameter `witnesPtMin` can not be null. It is a single object.
/// Parameter `witnesPtMax` can not be null. It is a single object.
BULLET_API void btSphereShape_project(const btSphereShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax);

/// Generated from method `btSphereShape::getBoundingSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `center` can not be null. It is a single object.
/// Parameter `radius` can not be null. It is a single object.
BULLET_API void btSphereShape_getBoundingSphere(const btSphereShape *_this, btVector3 *center, double *radius);

///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
/// Generated from method `btSphereShape::getAngularMotionDisc`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btSphereShape_getAngularMotionDisc(const btSphereShape *_this);

/// Generated from method `btSphereShape::getContactBreakingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btSphereShape_getContactBreakingThreshold(const btSphereShape *_this, double defaultContactThresholdFactor);

///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
///result is conservative
/// Generated from method `btSphereShape::calculateTemporalAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `curTrans` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
/// Parameter `temporalAabbMin` can not be null. It is a single object.
/// Parameter `temporalAabbMax` can not be null. It is a single object.
BULLET_API void btSphereShape_calculateTemporalAabb(const btSphereShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax);

/// Generated from method `btSphereShape::isPolyhedral`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btSphereShape_isPolyhedral(const btSphereShape *_this);

/// Generated from method `btSphereShape::isConvex2d`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btSphereShape_isConvex2d(const btSphereShape *_this);

/// Generated from method `btSphereShape::isConvex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btSphereShape_isConvex(const btSphereShape *_this);

/// Generated from method `btSphereShape::isNonMoving`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btSphereShape_isNonMoving(const btSphereShape *_this);

/// Generated from method `btSphereShape::isConcave`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btSphereShape_isConcave(const btSphereShape *_this);

/// Generated from method `btSphereShape::isCompound`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btSphereShape_isCompound(const btSphereShape *_this);

/// Generated from method `btSphereShape::isSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btSphereShape_isSoftBody(const btSphereShape *_this);

///isInfinite is used to catch simulation error (aabb check)
/// Generated from method `btSphereShape::isInfinite`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btSphereShape_isInfinite(const btSphereShape *_this);

/// Generated from method `btSphereShape::getShapeType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btSphereShape_getShapeType(const btSphereShape *_this);

///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
///See Bullet/Demos/RollingFrictionDemo for an example
/// Generated from method `btSphereShape::getAnisotropicRollingFrictionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btSphereShape_getAnisotropicRollingFrictionDirection(const btSphereShape *_this);

///optional user data pointer
/// Generated from method `btSphereShape::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSphereShape_setUserPointer(btSphereShape *_this, void *userPtr);

/// Generated from method `btSphereShape::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btSphereShape_getUserPointer(const btSphereShape *_this);

/// Generated from method `btSphereShape::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSphereShape_setUserIndex(btSphereShape *_this, int index);

/// Generated from method `btSphereShape::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btSphereShape_getUserIndex(const btSphereShape *_this);

/// Generated from method `btSphereShape::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSphereShape_setUserIndex2(btSphereShape *_this, int index);

/// Generated from method `btSphereShape::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btSphereShape_getUserIndex2(const btSphereShape *_this);

#ifdef __cplusplus
} // extern "C"
#endif
