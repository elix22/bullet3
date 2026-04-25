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


///The btCapsuleShape represents a capsule around the Y axis, there is also the btCapsuleShapeX aligned around the X axis and btCapsuleShapeZ around the Z axis.
///The total height is height+2*radius, so the height is just the height between the center of each 'sphere' of the capsule caps.
///The btCapsuleShape is a convex hull of two spheres. The btMultiSphereShape is a more general collision shape that takes the convex hull of multiple sphere, so it can also represent a capsule when just using two spheres.
/// Generated from class `btCapsuleShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `btConvexInternalShape`
///   Indirect: (non-virtual)
///     `btCollisionShape`
///     `btConvexShape`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCapsuleShape btCapsuleShape;

/// Generated from constructor `btCapsuleShape::btCapsuleShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCapsuleShape_Destroy()` to free it when you're done using it.
BULLET_API btCapsuleShape *btCapsuleShape_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCapsuleShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCapsuleShape *btCapsuleShape_OffsetPtr(const btCapsuleShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCapsuleShape *btCapsuleShape_OffsetMutablePtr(btCapsuleShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `btCapsuleShape` to its base class `btCollisionShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionShape *btCapsuleShape_UpcastTo_btCollisionShape(const btCapsuleShape *object);

/// Upcasts an instance of `btCapsuleShape` to its base class `btCollisionShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionShape *btCapsuleShape_MutableUpcastTo_btCollisionShape(btCapsuleShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCapsuleShape *btCapsuleShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCapsuleShape *btCapsuleShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCapsuleShape *btCapsuleShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btCapsuleShape *btCapsuleShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object);

/// Upcasts an instance of `btCapsuleShape` to its base class `btConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexShape *btCapsuleShape_UpcastTo_btConvexShape(const btCapsuleShape *object);

/// Upcasts an instance of `btCapsuleShape` to its base class `btConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexShape *btCapsuleShape_MutableUpcastTo_btConvexShape(btCapsuleShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCapsuleShape *btCapsuleShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCapsuleShape *btCapsuleShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCapsuleShape *btCapsuleShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btCapsuleShape *btCapsuleShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object);

/// Upcasts an instance of `btCapsuleShape` to its base class `btConvexInternalShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btCapsuleShape_UpcastTo_btConvexInternalShape(const btCapsuleShape *object);

/// Upcasts an instance of `btCapsuleShape` to its base class `btConvexInternalShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btCapsuleShape_MutableUpcastTo_btConvexInternalShape(btCapsuleShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCapsuleShape *btCapsuleShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btCapsuleShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCapsuleShape *btCapsuleShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCapsuleShape *btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btCapsuleShape *btCapsuleShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btCapsuleShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object);

/// Generated from constructor `btCapsuleShape::btCapsuleShape`.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCapsuleShape_Destroy()` to free it when you're done using it.
BULLET_API btCapsuleShape *btCapsuleShape_Construct(double radius, double height);

/// Destroys a heap-allocated instance of `btCapsuleShape`. Does nothing if the pointer is null.
BULLET_API void btCapsuleShape_Destroy(const btCapsuleShape *_this);

/// Destroys a heap-allocated array of `btCapsuleShape`. Does nothing if the pointer is null.
BULLET_API void btCapsuleShape_DestroyArray(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCapsuleShape *btCapsuleShape_AssignFromAnother(btCapsuleShape *_this, Bullet_PassBy _other_pass_by, btCapsuleShape *_other);

/// Generated from method `btCapsuleShape::operator new`.
BULLET_API void *Bullet_new_btCapsuleShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btCapsuleShape::operator delete`.
BULLET_API void Bullet_delete_btCapsuleShape_void_ptr(void *ptr);

/// Generated from method `btCapsuleShape::operator new`.
BULLET_API void *Bullet_new_btCapsuleShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btCapsuleShape::operator delete`.
BULLET_API void Bullet_delete_btCapsuleShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btCapsuleShape::operator new[]`.
BULLET_API void *Bullet_new_array_btCapsuleShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btCapsuleShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btCapsuleShape_void_ptr(void *ptr);

/// Generated from method `btCapsuleShape::operator new[]`.
BULLET_API void *Bullet_new_array_btCapsuleShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btCapsuleShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btCapsuleShape_void_ptr_void_ptr(void *_1, void *_2);

///CollisionShape Interface
/// Generated from method `btCapsuleShape::calculateLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btCapsuleShape_calculateLocalInertia(const btCapsuleShape *_this, double mass, btVector3 *inertia);

/// btConvexShape Interface
/// Generated from method `btCapsuleShape::localGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btCapsuleShape_localGetSupportingVertexWithoutMargin(const btCapsuleShape *_this, const btVector3 *vec);

/// Generated from method `btCapsuleShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCapsuleShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btCapsuleShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors);

/// Generated from method `btCapsuleShape::setMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCapsuleShape_setMargin(btCapsuleShape *_this, double collisionMargin);

/// Generated from method `btCapsuleShape::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btCapsuleShape_getAabb(const btCapsuleShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btCapsuleShape::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btCapsuleShape_getName(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getUpAxis`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCapsuleShape_getUpAxis(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getRadius`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCapsuleShape_getRadius(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getHalfHeight`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCapsuleShape_getHalfHeight(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::setLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `scaling` can not be null. It is a single object.
BULLET_API void btCapsuleShape_setLocalScaling(btCapsuleShape *_this, const btVector3 *scaling);

/// Generated from method `btCapsuleShape::getAnisotropicRollingFrictionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btCapsuleShape_getAnisotropicRollingFrictionDirection(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCapsuleShape_calculateSerializeBufferSize(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::localGetSupportingVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btCapsuleShape_localGetSupportingVertex(const btCapsuleShape *_this, const btVector3 *vec);

/// Generated from method `btCapsuleShape::getImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btCapsuleShape_getImplicitShapeDimensions(const btCapsuleShape *_this);

///warning: use setImplicitShapeDimensions with care
///changing a collision shape while the body is in the world is not recommended,
///it is best to remove the body from the world, then make the change, and re-add it
///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
/// Generated from method `btCapsuleShape::setImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `dimensions` can not be null. It is a single object.
BULLET_API void btCapsuleShape_setImplicitShapeDimensions(btCapsuleShape *_this, const btVector3 *dimensions);

/// Generated from method `btCapsuleShape::getAabbSlow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btCapsuleShape_getAabbSlow(const btCapsuleShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btCapsuleShape::getLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btCapsuleShape_getLocalScaling(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getLocalScalingNV`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btCapsuleShape_getLocalScalingNV(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCapsuleShape_getMargin(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getMarginNV`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCapsuleShape_getMarginNV(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getNumPreferredPenetrationDirections`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCapsuleShape_getNumPreferredPenetrationDirections(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getPreferredPenetrationDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `penetrationVector` can not be null. It is a single object.
BULLET_API void btCapsuleShape_getPreferredPenetrationDirection(const btCapsuleShape *_this, int index, btVector3 *penetrationVector);

/// Generated from method `btCapsuleShape::localGetSupportVertexWithoutMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btCapsuleShape_localGetSupportVertexWithoutMarginNonVirtual(const btCapsuleShape *_this, const btVector3 *vec);

/// Generated from method `btCapsuleShape::localGetSupportVertexNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btCapsuleShape_localGetSupportVertexNonVirtual(const btCapsuleShape *_this, const btVector3 *vec);

/// Generated from method `btCapsuleShape::getMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCapsuleShape_getMarginNonVirtual(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getAabbNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btCapsuleShape_getAabbNonVirtual(const btCapsuleShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btCapsuleShape::project`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
/// Parameter `dir` can not be null. It is a single object.
/// Parameter `minProj` can not be null. It is a single object.
/// Parameter `maxProj` can not be null. It is a single object.
/// Parameter `witnesPtMin` can not be null. It is a single object.
/// Parameter `witnesPtMax` can not be null. It is a single object.
BULLET_API void btCapsuleShape_project(const btCapsuleShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax);

/// Generated from method `btCapsuleShape::getBoundingSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `center` can not be null. It is a single object.
/// Parameter `radius` can not be null. It is a single object.
BULLET_API void btCapsuleShape_getBoundingSphere(const btCapsuleShape *_this, btVector3 *center, double *radius);

///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
/// Generated from method `btCapsuleShape::getAngularMotionDisc`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCapsuleShape_getAngularMotionDisc(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getContactBreakingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCapsuleShape_getContactBreakingThreshold(const btCapsuleShape *_this, double defaultContactThresholdFactor);

///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
///result is conservative
/// Generated from method `btCapsuleShape::calculateTemporalAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `curTrans` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
/// Parameter `temporalAabbMin` can not be null. It is a single object.
/// Parameter `temporalAabbMax` can not be null. It is a single object.
BULLET_API void btCapsuleShape_calculateTemporalAabb(const btCapsuleShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax);

/// Generated from method `btCapsuleShape::isPolyhedral`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCapsuleShape_isPolyhedral(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::isConvex2d`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCapsuleShape_isConvex2d(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::isConvex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCapsuleShape_isConvex(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::isNonMoving`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCapsuleShape_isNonMoving(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::isConcave`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCapsuleShape_isConcave(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::isCompound`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCapsuleShape_isCompound(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::isSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCapsuleShape_isSoftBody(const btCapsuleShape *_this);

///isInfinite is used to catch simulation error (aabb check)
/// Generated from method `btCapsuleShape::isInfinite`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCapsuleShape_isInfinite(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::getShapeType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCapsuleShape_getShapeType(const btCapsuleShape *_this);

///optional user data pointer
/// Generated from method `btCapsuleShape::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCapsuleShape_setUserPointer(btCapsuleShape *_this, void *userPtr);

/// Generated from method `btCapsuleShape::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btCapsuleShape_getUserPointer(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCapsuleShape_setUserIndex(btCapsuleShape *_this, int index);

/// Generated from method `btCapsuleShape::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCapsuleShape_getUserIndex(const btCapsuleShape *_this);

/// Generated from method `btCapsuleShape::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCapsuleShape_setUserIndex2(btCapsuleShape *_this, int index);

/// Generated from method `btCapsuleShape::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCapsuleShape_getUserIndex2(const btCapsuleShape *_this);

#ifdef __cplusplus
} // extern "C"
#endif
