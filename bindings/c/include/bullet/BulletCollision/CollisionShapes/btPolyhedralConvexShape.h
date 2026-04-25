// machine generated, do not edit
#pragma once

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


///The btPolyhedralConvexShape is an internal interface class for polyhedral convex shapes.
/// Generated from class `btPolyhedralConvexShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `btConvexInternalShape`
///   Indirect: (non-virtual)
///     `btCollisionShape`
///     `btConvexShape`
/// Derived classes:
///   Direct: (non-virtual)
///     `btBoxShape`
///     `btPolyhedralConvexAabbCachingShape`
typedef struct btPolyhedralConvexShape btPolyhedralConvexShape;

///The btPolyhedralConvexAabbCachingShape adds aabb caching to the btPolyhedralConvexShape
/// Generated from class `btPolyhedralConvexAabbCachingShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `btPolyhedralConvexShape`
///   Indirect: (non-virtual)
///     `btCollisionShape`
///     `btConvexShape`
///     `btConvexInternalShape`
typedef struct btPolyhedralConvexAabbCachingShape btPolyhedralConvexAabbCachingShape;

/// Destroys a heap-allocated instance of `btPolyhedralConvexShape`. Does nothing if the pointer is null.
BULLET_API void btPolyhedralConvexShape_Destroy(const btPolyhedralConvexShape *_this);

/// Destroys a heap-allocated array of `btPolyhedralConvexShape`. Does nothing if the pointer is null.
BULLET_API void btPolyhedralConvexShape_DestroyArray(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::operator new`.
BULLET_API void *Bullet_new_btPolyhedralConvexShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btPolyhedralConvexShape::operator delete`.
BULLET_API void Bullet_delete_btPolyhedralConvexShape_void_ptr(void *ptr);

/// Generated from method `btPolyhedralConvexShape::operator new`.
BULLET_API void *Bullet_new_btPolyhedralConvexShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btPolyhedralConvexShape::operator delete`.
BULLET_API void Bullet_delete_btPolyhedralConvexShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btPolyhedralConvexShape::operator new[]`.
BULLET_API void *Bullet_new_array_btPolyhedralConvexShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btPolyhedralConvexShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btPolyhedralConvexShape_void_ptr(void *ptr);

/// Generated from method `btPolyhedralConvexShape::operator new[]`.
BULLET_API void *Bullet_new_array_btPolyhedralConvexShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btPolyhedralConvexShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btPolyhedralConvexShape_void_ptr_void_ptr(void *_1, void *_2);

///optional method mainly used to generate multiple contact points by clipping polyhedral features (faces/edges)
///experimental/work-in-progress
/// Generated from method `btPolyhedralConvexShape::initializePolyhedralFeatures`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `shiftVerticesByMargin` has a default argument: `0`, pass a null pointer to use it.
BULLET_API bool btPolyhedralConvexShape_initializePolyhedralFeatures(btPolyhedralConvexShape *_this, const int *shiftVerticesByMargin);

//brute force implementations
/// Generated from method `btPolyhedralConvexShape::localGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexShape_localGetSupportingVertexWithoutMargin(const btPolyhedralConvexShape *_this, const btVector3 *vec);

/// Generated from method `btPolyhedralConvexShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btPolyhedralConvexShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors);

/// Generated from method `btPolyhedralConvexShape::calculateLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_calculateLocalInertia(const btPolyhedralConvexShape *_this, double mass, btVector3 *inertia);

/// Generated from method `btPolyhedralConvexShape::getNumVertices`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexShape_getNumVertices(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getNumEdges`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexShape_getNumEdges(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getEdge`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `pa` can not be null. It is a single object.
/// Parameter `pb` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_getEdge(const btPolyhedralConvexShape *_this, int i, btVector3 *pa, btVector3 *pb);

/// Generated from method `btPolyhedralConvexShape::getVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vtx` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_getVertex(const btPolyhedralConvexShape *_this, int i, btVector3 *vtx);

/// Generated from method `btPolyhedralConvexShape::getNumPlanes`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexShape_getNumPlanes(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `planeNormal` can not be null. It is a single object.
/// Parameter `planeSupport` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_getPlane(const btPolyhedralConvexShape *_this, btVector3 *planeNormal, btVector3 *planeSupport, int i);

//	virtual int getIndex(int i) const = 0 ;
/// Generated from method `btPolyhedralConvexShape::isInside`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `pt` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexShape_isInside(const btPolyhedralConvexShape *_this, const btVector3 *pt, double tolerance);

/// Generated from method `btPolyhedralConvexShape::localGetSupportingVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexShape_localGetSupportingVertex(const btPolyhedralConvexShape *_this, const btVector3 *vec);

/// Generated from method `btPolyhedralConvexShape::getImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btPolyhedralConvexShape_getImplicitShapeDimensions(const btPolyhedralConvexShape *_this);

///warning: use setImplicitShapeDimensions with care
///changing a collision shape while the body is in the world is not recommended,
///it is best to remove the body from the world, then make the change, and re-add it
///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
/// Generated from method `btPolyhedralConvexShape::setImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `dimensions` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_setImplicitShapeDimensions(btPolyhedralConvexShape *_this, const btVector3 *dimensions);

///getAabb's default implementation is brute force, expected derived classes to implement a fast dedicated version
/// Generated from method `btPolyhedralConvexShape::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_getAabb(const btPolyhedralConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btPolyhedralConvexShape::getAabbSlow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_getAabbSlow(const btPolyhedralConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btPolyhedralConvexShape::setLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `scaling` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_setLocalScaling(btPolyhedralConvexShape *_this, const btVector3 *scaling);

/// Generated from method `btPolyhedralConvexShape::getLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btPolyhedralConvexShape_getLocalScaling(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getLocalScalingNV`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btPolyhedralConvexShape_getLocalScalingNV(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::setMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_setMargin(btPolyhedralConvexShape *_this, double margin);

/// Generated from method `btPolyhedralConvexShape::getMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexShape_getMargin(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getMarginNV`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexShape_getMarginNV(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getNumPreferredPenetrationDirections`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexShape_getNumPreferredPenetrationDirections(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getPreferredPenetrationDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `penetrationVector` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_getPreferredPenetrationDirection(const btPolyhedralConvexShape *_this, int index, btVector3 *penetrationVector);

/// Generated from method `btPolyhedralConvexShape::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexShape_calculateSerializeBufferSize(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::localGetSupportVertexWithoutMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexShape_localGetSupportVertexWithoutMarginNonVirtual(const btPolyhedralConvexShape *_this, const btVector3 *vec);

/// Generated from method `btPolyhedralConvexShape::localGetSupportVertexNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexShape_localGetSupportVertexNonVirtual(const btPolyhedralConvexShape *_this, const btVector3 *vec);

/// Generated from method `btPolyhedralConvexShape::getMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexShape_getMarginNonVirtual(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getAabbNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_getAabbNonVirtual(const btPolyhedralConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btPolyhedralConvexShape::project`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
/// Parameter `dir` can not be null. It is a single object.
/// Parameter `minProj` can not be null. It is a single object.
/// Parameter `maxProj` can not be null. It is a single object.
/// Parameter `witnesPtMin` can not be null. It is a single object.
/// Parameter `witnesPtMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_project(const btPolyhedralConvexShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax);

/// Generated from method `btPolyhedralConvexShape::getBoundingSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `center` can not be null. It is a single object.
/// Parameter `radius` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_getBoundingSphere(const btPolyhedralConvexShape *_this, btVector3 *center, double *radius);

///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
/// Generated from method `btPolyhedralConvexShape::getAngularMotionDisc`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexShape_getAngularMotionDisc(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getContactBreakingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexShape_getContactBreakingThreshold(const btPolyhedralConvexShape *_this, double defaultContactThresholdFactor);

///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
///result is conservative
/// Generated from method `btPolyhedralConvexShape::calculateTemporalAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `curTrans` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
/// Parameter `temporalAabbMin` can not be null. It is a single object.
/// Parameter `temporalAabbMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_calculateTemporalAabb(const btPolyhedralConvexShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax);

/// Generated from method `btPolyhedralConvexShape::isPolyhedral`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexShape_isPolyhedral(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::isConvex2d`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexShape_isConvex2d(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::isConvex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexShape_isConvex(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::isNonMoving`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexShape_isNonMoving(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::isConcave`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexShape_isConcave(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::isCompound`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexShape_isCompound(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::isSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexShape_isSoftBody(const btPolyhedralConvexShape *_this);

///isInfinite is used to catch simulation error (aabb check)
/// Generated from method `btPolyhedralConvexShape::isInfinite`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexShape_isInfinite(const btPolyhedralConvexShape *_this);

//debugging support
/// Generated from method `btPolyhedralConvexShape::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btPolyhedralConvexShape_getName(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::getShapeType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexShape_getShapeType(const btPolyhedralConvexShape *_this);

///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
///See Bullet/Demos/RollingFrictionDemo for an example
/// Generated from method `btPolyhedralConvexShape::getAnisotropicRollingFrictionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexShape_getAnisotropicRollingFrictionDirection(const btPolyhedralConvexShape *_this);

///optional user data pointer
/// Generated from method `btPolyhedralConvexShape::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_setUserPointer(btPolyhedralConvexShape *_this, void *userPtr);

/// Generated from method `btPolyhedralConvexShape::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btPolyhedralConvexShape_getUserPointer(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_setUserIndex(btPolyhedralConvexShape *_this, int index);

/// Generated from method `btPolyhedralConvexShape::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexShape_getUserIndex(const btPolyhedralConvexShape *_this);

/// Generated from method `btPolyhedralConvexShape::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexShape_setUserIndex2(btPolyhedralConvexShape *_this, int index);

/// Generated from method `btPolyhedralConvexShape::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexShape_getUserIndex2(const btPolyhedralConvexShape *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_OffsetPtr(const btPolyhedralConvexShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_OffsetMutablePtr(btPolyhedralConvexShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `btPolyhedralConvexShape` to its base class `btCollisionShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionShape *btPolyhedralConvexShape_UpcastTo_btCollisionShape(const btPolyhedralConvexShape *object);

/// Upcasts an instance of `btPolyhedralConvexShape` to its base class `btCollisionShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionShape *btPolyhedralConvexShape_MutableUpcastTo_btCollisionShape(btPolyhedralConvexShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object);

/// Upcasts an instance of `btPolyhedralConvexShape` to its base class `btConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexShape *btPolyhedralConvexShape_UpcastTo_btConvexShape(const btPolyhedralConvexShape *object);

/// Upcasts an instance of `btPolyhedralConvexShape` to its base class `btConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexShape *btPolyhedralConvexShape_MutableUpcastTo_btConvexShape(btPolyhedralConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object);

/// Upcasts an instance of `btPolyhedralConvexShape` to its base class `btConvexInternalShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btPolyhedralConvexShape_UpcastTo_btConvexInternalShape(const btPolyhedralConvexShape *object);

/// Upcasts an instance of `btPolyhedralConvexShape` to its base class `btConvexInternalShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btPolyhedralConvexShape_MutableUpcastTo_btConvexInternalShape(btPolyhedralConvexShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object);

/// Destroys a heap-allocated instance of `btPolyhedralConvexAabbCachingShape`. Does nothing if the pointer is null.
BULLET_API void btPolyhedralConvexAabbCachingShape_Destroy(const btPolyhedralConvexAabbCachingShape *_this);

/// Destroys a heap-allocated array of `btPolyhedralConvexAabbCachingShape`. Does nothing if the pointer is null.
BULLET_API void btPolyhedralConvexAabbCachingShape_DestroyArray(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getNonvirtualAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_getNonvirtualAabb(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *trans, btVector3 *aabbMin, btVector3 *aabbMax, double margin);

/// Generated from method `btPolyhedralConvexAabbCachingShape::setLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `scaling` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_setLocalScaling(btPolyhedralConvexAabbCachingShape *_this, const btVector3 *scaling);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_getAabb(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btPolyhedralConvexAabbCachingShape::recalcLocalAabb`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_recalcLocalAabb(btPolyhedralConvexAabbCachingShape *_this);

///optional method mainly used to generate multiple contact points by clipping polyhedral features (faces/edges)
///experimental/work-in-progress
/// Generated from method `btPolyhedralConvexAabbCachingShape::initializePolyhedralFeatures`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `shiftVerticesByMargin` has a default argument: `0`, pass a null pointer to use it.
BULLET_API bool btPolyhedralConvexAabbCachingShape_initializePolyhedralFeatures(btPolyhedralConvexAabbCachingShape *_this, const int *shiftVerticesByMargin);

//brute force implementations
/// Generated from method `btPolyhedralConvexAabbCachingShape::localGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexAabbCachingShape_localGetSupportingVertexWithoutMargin(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vec);

/// Generated from method `btPolyhedralConvexAabbCachingShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors);

/// Generated from method `btPolyhedralConvexAabbCachingShape::calculateLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_calculateLocalInertia(const btPolyhedralConvexAabbCachingShape *_this, double mass, btVector3 *inertia);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getNumVertices`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexAabbCachingShape_getNumVertices(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getNumEdges`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexAabbCachingShape_getNumEdges(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getEdge`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `pa` can not be null. It is a single object.
/// Parameter `pb` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_getEdge(const btPolyhedralConvexAabbCachingShape *_this, int i, btVector3 *pa, btVector3 *pb);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vtx` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_getVertex(const btPolyhedralConvexAabbCachingShape *_this, int i, btVector3 *vtx);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getNumPlanes`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexAabbCachingShape_getNumPlanes(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `planeNormal` can not be null. It is a single object.
/// Parameter `planeSupport` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_getPlane(const btPolyhedralConvexAabbCachingShape *_this, btVector3 *planeNormal, btVector3 *planeSupport, int i);

//	virtual int getIndex(int i) const = 0 ;
/// Generated from method `btPolyhedralConvexAabbCachingShape::isInside`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `pt` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexAabbCachingShape_isInside(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *pt, double tolerance);

/// Generated from method `btPolyhedralConvexAabbCachingShape::localGetSupportingVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexAabbCachingShape_localGetSupportingVertex(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vec);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btPolyhedralConvexAabbCachingShape_getImplicitShapeDimensions(const btPolyhedralConvexAabbCachingShape *_this);

///warning: use setImplicitShapeDimensions with care
///changing a collision shape while the body is in the world is not recommended,
///it is best to remove the body from the world, then make the change, and re-add it
///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
/// Generated from method `btPolyhedralConvexAabbCachingShape::setImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `dimensions` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_setImplicitShapeDimensions(btPolyhedralConvexAabbCachingShape *_this, const btVector3 *dimensions);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getAabbSlow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_getAabbSlow(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btPolyhedralConvexAabbCachingShape_getLocalScaling(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getLocalScalingNV`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btPolyhedralConvexAabbCachingShape_getLocalScalingNV(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::setMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_setMargin(btPolyhedralConvexAabbCachingShape *_this, double margin);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexAabbCachingShape_getMargin(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getMarginNV`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexAabbCachingShape_getMarginNV(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getNumPreferredPenetrationDirections`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexAabbCachingShape_getNumPreferredPenetrationDirections(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getPreferredPenetrationDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `penetrationVector` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_getPreferredPenetrationDirection(const btPolyhedralConvexAabbCachingShape *_this, int index, btVector3 *penetrationVector);

/// Generated from method `btPolyhedralConvexAabbCachingShape::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexAabbCachingShape_calculateSerializeBufferSize(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::localGetSupportVertexWithoutMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vec);

/// Generated from method `btPolyhedralConvexAabbCachingShape::localGetSupportVertexNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexAabbCachingShape_localGetSupportVertexNonVirtual(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vec);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexAabbCachingShape_getMarginNonVirtual(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getAabbNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_getAabbNonVirtual(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btPolyhedralConvexAabbCachingShape::project`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
/// Parameter `dir` can not be null. It is a single object.
/// Parameter `minProj` can not be null. It is a single object.
/// Parameter `maxProj` can not be null. It is a single object.
/// Parameter `witnesPtMin` can not be null. It is a single object.
/// Parameter `witnesPtMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_project(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getBoundingSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `center` can not be null. It is a single object.
/// Parameter `radius` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_getBoundingSphere(const btPolyhedralConvexAabbCachingShape *_this, btVector3 *center, double *radius);

///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
/// Generated from method `btPolyhedralConvexAabbCachingShape::getAngularMotionDisc`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexAabbCachingShape_getAngularMotionDisc(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getContactBreakingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btPolyhedralConvexAabbCachingShape_getContactBreakingThreshold(const btPolyhedralConvexAabbCachingShape *_this, double defaultContactThresholdFactor);

///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
///result is conservative
/// Generated from method `btPolyhedralConvexAabbCachingShape::calculateTemporalAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `curTrans` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
/// Parameter `temporalAabbMin` can not be null. It is a single object.
/// Parameter `temporalAabbMax` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_calculateTemporalAabb(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax);

/// Generated from method `btPolyhedralConvexAabbCachingShape::isPolyhedral`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexAabbCachingShape_isPolyhedral(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::isConvex2d`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexAabbCachingShape_isConvex2d(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::isConvex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexAabbCachingShape_isConvex(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::isNonMoving`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexAabbCachingShape_isNonMoving(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::isConcave`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexAabbCachingShape_isConcave(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::isCompound`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexAabbCachingShape_isCompound(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::isSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexAabbCachingShape_isSoftBody(const btPolyhedralConvexAabbCachingShape *_this);

///isInfinite is used to catch simulation error (aabb check)
/// Generated from method `btPolyhedralConvexAabbCachingShape::isInfinite`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btPolyhedralConvexAabbCachingShape_isInfinite(const btPolyhedralConvexAabbCachingShape *_this);

//debugging support
/// Generated from method `btPolyhedralConvexAabbCachingShape::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btPolyhedralConvexAabbCachingShape_getName(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getShapeType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexAabbCachingShape_getShapeType(const btPolyhedralConvexAabbCachingShape *_this);

///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
///See Bullet/Demos/RollingFrictionDemo for an example
/// Generated from method `btPolyhedralConvexAabbCachingShape::getAnisotropicRollingFrictionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btPolyhedralConvexAabbCachingShape_getAnisotropicRollingFrictionDirection(const btPolyhedralConvexAabbCachingShape *_this);

///optional user data pointer
/// Generated from method `btPolyhedralConvexAabbCachingShape::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_setUserPointer(btPolyhedralConvexAabbCachingShape *_this, void *userPtr);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btPolyhedralConvexAabbCachingShape_getUserPointer(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_setUserIndex(btPolyhedralConvexAabbCachingShape *_this, int index);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexAabbCachingShape_getUserIndex(const btPolyhedralConvexAabbCachingShape *_this);

/// Generated from method `btPolyhedralConvexAabbCachingShape::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btPolyhedralConvexAabbCachingShape_setUserIndex2(btPolyhedralConvexAabbCachingShape *_this, int index);

/// Generated from method `btPolyhedralConvexAabbCachingShape::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btPolyhedralConvexAabbCachingShape_getUserIndex2(const btPolyhedralConvexAabbCachingShape *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_OffsetPtr(const btPolyhedralConvexAabbCachingShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_OffsetMutablePtr(btPolyhedralConvexAabbCachingShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `btPolyhedralConvexAabbCachingShape` to its base class `btCollisionShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionShape *btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape(const btPolyhedralConvexAabbCachingShape *object);

/// Upcasts an instance of `btPolyhedralConvexAabbCachingShape` to its base class `btCollisionShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionShape *btPolyhedralConvexAabbCachingShape_MutableUpcastTo_btCollisionShape(btPolyhedralConvexAabbCachingShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object);

/// Upcasts an instance of `btPolyhedralConvexAabbCachingShape` to its base class `btConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexShape *btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape(const btPolyhedralConvexAabbCachingShape *object);

/// Upcasts an instance of `btPolyhedralConvexAabbCachingShape` to its base class `btConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexShape *btPolyhedralConvexAabbCachingShape_MutableUpcastTo_btConvexShape(btPolyhedralConvexAabbCachingShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object);

/// Upcasts an instance of `btPolyhedralConvexAabbCachingShape` to its base class `btConvexInternalShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape(const btPolyhedralConvexAabbCachingShape *object);

/// Upcasts an instance of `btPolyhedralConvexAabbCachingShape` to its base class `btConvexInternalShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btPolyhedralConvexAabbCachingShape_MutableUpcastTo_btConvexInternalShape(btPolyhedralConvexAabbCachingShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object);

/// Upcasts an instance of `btPolyhedralConvexAabbCachingShape` to its base class `btPolyhedralConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexShape *btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape(const btPolyhedralConvexAabbCachingShape *object);

/// Upcasts an instance of `btPolyhedralConvexAabbCachingShape` to its base class `btPolyhedralConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexShape *btPolyhedralConvexAabbCachingShape_MutableUpcastTo_btPolyhedralConvexShape(btPolyhedralConvexAabbCachingShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_StaticDowncastFrom_btPolyhedralConvexShape(const btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableStaticDowncastFrom_btPolyhedralConvexShape(btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape(const btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFrom_btPolyhedralConvexShape(btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFromOrFail_btPolyhedralConvexShape(const btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btPolyhedralConvexAabbCachingShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFromOrFail_btPolyhedralConvexShape(btPolyhedralConvexShape *object);

#ifdef __cplusplus
} // extern "C"
#endif
