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
typedef struct btPolyhedralConvexShape btPolyhedralConvexShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btPolyhedralConvexShape.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///The btBoxShape is a box primitive around the origin, its sides axis aligned with length specified by half extents, in local shape coordinates. When used as part of a btCollisionObject or btRigidBody it will be an oriented box in world space.
/// Generated from class `btBoxShape`.
/// Base classes:
///   Direct: (non-virtual)
///     `btPolyhedralConvexShape`
///   Indirect: (non-virtual)
///     `btCollisionShape`
///     `btConvexShape`
///     `btConvexInternalShape`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btBoxShape btBoxShape;

/// Generated from constructor `btBoxShape::btBoxShape`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btBoxShape_Destroy()` to free it when you're done using it.
BULLET_API btBoxShape *btBoxShape_ConstructFromAnother(Bullet_PassBy _other_pass_by, btBoxShape *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btBoxShape *btBoxShape_OffsetPtr(const btBoxShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btBoxShape *btBoxShape_OffsetMutablePtr(btBoxShape *ptr, ptrdiff_t i);

/// Upcasts an instance of `btBoxShape` to its base class `btCollisionShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionShape *btBoxShape_UpcastTo_btCollisionShape(const btBoxShape *object);

/// Upcasts an instance of `btBoxShape` to its base class `btCollisionShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionShape *btBoxShape_MutableUpcastTo_btCollisionShape(btBoxShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btBoxShape *btBoxShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btBoxShape *btBoxShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btBoxShape *btBoxShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btBoxShape *btBoxShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btBoxShape *btBoxShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object);

/// Downcasts an instance of `btCollisionShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btBoxShape *btBoxShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object);

/// Upcasts an instance of `btBoxShape` to its base class `btConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexShape *btBoxShape_UpcastTo_btConvexShape(const btBoxShape *object);

/// Upcasts an instance of `btBoxShape` to its base class `btConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexShape *btBoxShape_MutableUpcastTo_btConvexShape(btBoxShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btBoxShape *btBoxShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btBoxShape *btBoxShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btBoxShape *btBoxShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btBoxShape *btBoxShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btBoxShape *btBoxShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object);

/// Downcasts an instance of `btConvexShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btBoxShape *btBoxShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object);

/// Upcasts an instance of `btBoxShape` to its base class `btConvexInternalShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConvexInternalShape *btBoxShape_UpcastTo_btConvexInternalShape(const btBoxShape *object);

/// Upcasts an instance of `btBoxShape` to its base class `btConvexInternalShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConvexInternalShape *btBoxShape_MutableUpcastTo_btConvexInternalShape(btBoxShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btBoxShape *btBoxShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btBoxShape *btBoxShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btBoxShape *btBoxShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btBoxShape *btBoxShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btBoxShape *btBoxShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object);

/// Downcasts an instance of `btConvexInternalShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btBoxShape *btBoxShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object);

/// Upcasts an instance of `btBoxShape` to its base class `btPolyhedralConvexShape`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btPolyhedralConvexShape *btBoxShape_UpcastTo_btPolyhedralConvexShape(const btBoxShape *object);

/// Upcasts an instance of `btBoxShape` to its base class `btPolyhedralConvexShape`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btPolyhedralConvexShape *btBoxShape_MutableUpcastTo_btPolyhedralConvexShape(btBoxShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btBoxShape *btBoxShape_StaticDowncastFrom_btPolyhedralConvexShape(const btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btBoxShape`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btBoxShape *btBoxShape_MutableStaticDowncastFrom_btPolyhedralConvexShape(btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btBoxShape *btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape(const btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btBoxShape *btBoxShape_MutableDynamicDowncastFrom_btPolyhedralConvexShape(btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btBoxShape *btBoxShape_DynamicDowncastFromOrFail_btPolyhedralConvexShape(const btPolyhedralConvexShape *object);

/// Downcasts an instance of `btPolyhedralConvexShape` to a derived class `btBoxShape`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btBoxShape *btBoxShape_MutableDynamicDowncastFromOrFail_btPolyhedralConvexShape(btPolyhedralConvexShape *object);

/// Generated from constructor `btBoxShape::btBoxShape`.
/// Parameter `boxHalfExtents` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btBoxShape_Destroy()` to free it when you're done using it.
BULLET_API btBoxShape *btBoxShape_Construct(const btVector3 *boxHalfExtents);

/// Destroys a heap-allocated instance of `btBoxShape`. Does nothing if the pointer is null.
BULLET_API void btBoxShape_Destroy(const btBoxShape *_this);

/// Destroys a heap-allocated array of `btBoxShape`. Does nothing if the pointer is null.
BULLET_API void btBoxShape_DestroyArray(const btBoxShape *_this);

/// Generated from method `btBoxShape::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btBoxShape *btBoxShape_AssignFromAnother(btBoxShape *_this, Bullet_PassBy _other_pass_by, btBoxShape *_other);

//btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
/// Generated from method `btBoxShape::operator new`.
BULLET_API void *Bullet_new_btBoxShape_unsigned_long(unsigned long sizeInBytes);

//btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
/// Generated from method `btBoxShape::operator delete`.
BULLET_API void Bullet_delete_btBoxShape_void_ptr(void *ptr);

//btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
/// Generated from method `btBoxShape::operator new`.
BULLET_API void *Bullet_new_btBoxShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

//btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
/// Generated from method `btBoxShape::operator delete`.
BULLET_API void Bullet_delete_btBoxShape_void_ptr_void_ptr(void *_1, void *_2);

//btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
/// Generated from method `btBoxShape::operator new[]`.
BULLET_API void *Bullet_new_array_btBoxShape_unsigned_long(unsigned long sizeInBytes);

//btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
/// Generated from method `btBoxShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btBoxShape_void_ptr(void *ptr);

//btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
/// Generated from method `btBoxShape::operator new[]`.
BULLET_API void *Bullet_new_array_btBoxShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

//btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
/// Generated from method `btBoxShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btBoxShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btBoxShape::getHalfExtentsWithMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btBoxShape_getHalfExtentsWithMargin(const btBoxShape *_this);

/// Generated from method `btBoxShape::getHalfExtentsWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btBoxShape_getHalfExtentsWithoutMargin(const btBoxShape *_this);

/// Generated from method `btBoxShape::localGetSupportingVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btBoxShape_localGetSupportingVertex(const btBoxShape *_this, const btVector3 *vec);

/// Generated from method `btBoxShape::localGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btBoxShape_localGetSupportingVertexWithoutMargin(const btBoxShape *_this, const btVector3 *vec);

/// Generated from method `btBoxShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btBoxShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btBoxShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors);

/// Generated from method `btBoxShape::setMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btBoxShape_setMargin(btBoxShape *_this, double collisionMargin);

/// Generated from method `btBoxShape::setLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `scaling` can not be null. It is a single object.
BULLET_API void btBoxShape_setLocalScaling(btBoxShape *_this, const btVector3 *scaling);

/// Generated from method `btBoxShape::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btBoxShape_getAabb(const btBoxShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btBoxShape::calculateLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btBoxShape_calculateLocalInertia(const btBoxShape *_this, double mass, btVector3 *inertia);

/// Generated from method `btBoxShape::getPlane`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `planeNormal` can not be null. It is a single object.
/// Parameter `planeSupport` can not be null. It is a single object.
BULLET_API void btBoxShape_getPlane(const btBoxShape *_this, btVector3 *planeNormal, btVector3 *planeSupport, int i);

/// Generated from method `btBoxShape::getNumPlanes`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btBoxShape_getNumPlanes(const btBoxShape *_this);

/// Generated from method `btBoxShape::getNumVertices`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btBoxShape_getNumVertices(const btBoxShape *_this);

/// Generated from method `btBoxShape::getNumEdges`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btBoxShape_getNumEdges(const btBoxShape *_this);

/// Generated from method `btBoxShape::getVertex`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vtx` can not be null. It is a single object.
BULLET_API void btBoxShape_getVertex(const btBoxShape *_this, int i, btVector3 *vtx);

/// Generated from method `btBoxShape::getEdge`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `pa` can not be null. It is a single object.
/// Parameter `pb` can not be null. It is a single object.
BULLET_API void btBoxShape_getEdge(const btBoxShape *_this, int i, btVector3 *pa, btVector3 *pb);

/// Generated from method `btBoxShape::isInside`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `pt` can not be null. It is a single object.
BULLET_API bool btBoxShape_isInside(const btBoxShape *_this, const btVector3 *pt, double tolerance);

//debugging
/// Generated from method `btBoxShape::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btBoxShape_getName(const btBoxShape *_this);

/// Generated from method `btBoxShape::getNumPreferredPenetrationDirections`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btBoxShape_getNumPreferredPenetrationDirections(const btBoxShape *_this);

/// Generated from method `btBoxShape::getPreferredPenetrationDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `penetrationVector` can not be null. It is a single object.
BULLET_API void btBoxShape_getPreferredPenetrationDirection(const btBoxShape *_this, int index, btVector3 *penetrationVector);

///optional method mainly used to generate multiple contact points by clipping polyhedral features (faces/edges)
///experimental/work-in-progress
/// Generated from method `btBoxShape::initializePolyhedralFeatures`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `shiftVerticesByMargin` has a default argument: `0`, pass a null pointer to use it.
BULLET_API bool btBoxShape_initializePolyhedralFeatures(btBoxShape *_this, const int *shiftVerticesByMargin);

/// Generated from method `btBoxShape::getImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btBoxShape_getImplicitShapeDimensions(const btBoxShape *_this);

///warning: use setImplicitShapeDimensions with care
///changing a collision shape while the body is in the world is not recommended,
///it is best to remove the body from the world, then make the change, and re-add it
///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
/// Generated from method `btBoxShape::setImplicitShapeDimensions`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `dimensions` can not be null. It is a single object.
BULLET_API void btBoxShape_setImplicitShapeDimensions(btBoxShape *_this, const btVector3 *dimensions);

/// Generated from method `btBoxShape::getAabbSlow`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btBoxShape_getAabbSlow(const btBoxShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btBoxShape::getLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btBoxShape_getLocalScaling(const btBoxShape *_this);

/// Generated from method `btBoxShape::getLocalScalingNV`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btBoxShape_getLocalScalingNV(const btBoxShape *_this);

/// Generated from method `btBoxShape::getMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btBoxShape_getMargin(const btBoxShape *_this);

/// Generated from method `btBoxShape::getMarginNV`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btBoxShape_getMarginNV(const btBoxShape *_this);

/// Generated from method `btBoxShape::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btBoxShape_calculateSerializeBufferSize(const btBoxShape *_this);

/// Generated from method `btBoxShape::localGetSupportVertexWithoutMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btBoxShape_localGetSupportVertexWithoutMarginNonVirtual(const btBoxShape *_this, const btVector3 *vec);

/// Generated from method `btBoxShape::localGetSupportVertexNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `vec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btBoxShape_localGetSupportVertexNonVirtual(const btBoxShape *_this, const btVector3 *vec);

/// Generated from method `btBoxShape::getMarginNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btBoxShape_getMarginNonVirtual(const btBoxShape *_this);

/// Generated from method `btBoxShape::getAabbNonVirtual`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btBoxShape_getAabbNonVirtual(const btBoxShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btBoxShape::project`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
/// Parameter `dir` can not be null. It is a single object.
/// Parameter `minProj` can not be null. It is a single object.
/// Parameter `maxProj` can not be null. It is a single object.
/// Parameter `witnesPtMin` can not be null. It is a single object.
/// Parameter `witnesPtMax` can not be null. It is a single object.
BULLET_API void btBoxShape_project(const btBoxShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax);

/// Generated from method `btBoxShape::getBoundingSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `center` can not be null. It is a single object.
/// Parameter `radius` can not be null. It is a single object.
BULLET_API void btBoxShape_getBoundingSphere(const btBoxShape *_this, btVector3 *center, double *radius);

///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
/// Generated from method `btBoxShape::getAngularMotionDisc`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btBoxShape_getAngularMotionDisc(const btBoxShape *_this);

/// Generated from method `btBoxShape::getContactBreakingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btBoxShape_getContactBreakingThreshold(const btBoxShape *_this, double defaultContactThresholdFactor);

///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
///result is conservative
/// Generated from method `btBoxShape::calculateTemporalAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `curTrans` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
/// Parameter `temporalAabbMin` can not be null. It is a single object.
/// Parameter `temporalAabbMax` can not be null. It is a single object.
BULLET_API void btBoxShape_calculateTemporalAabb(const btBoxShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax);

/// Generated from method `btBoxShape::isPolyhedral`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btBoxShape_isPolyhedral(const btBoxShape *_this);

/// Generated from method `btBoxShape::isConvex2d`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btBoxShape_isConvex2d(const btBoxShape *_this);

/// Generated from method `btBoxShape::isConvex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btBoxShape_isConvex(const btBoxShape *_this);

/// Generated from method `btBoxShape::isNonMoving`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btBoxShape_isNonMoving(const btBoxShape *_this);

/// Generated from method `btBoxShape::isConcave`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btBoxShape_isConcave(const btBoxShape *_this);

/// Generated from method `btBoxShape::isCompound`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btBoxShape_isCompound(const btBoxShape *_this);

/// Generated from method `btBoxShape::isSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btBoxShape_isSoftBody(const btBoxShape *_this);

///isInfinite is used to catch simulation error (aabb check)
/// Generated from method `btBoxShape::isInfinite`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btBoxShape_isInfinite(const btBoxShape *_this);

/// Generated from method `btBoxShape::getShapeType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btBoxShape_getShapeType(const btBoxShape *_this);

///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
///See Bullet/Demos/RollingFrictionDemo for an example
/// Generated from method `btBoxShape::getAnisotropicRollingFrictionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btBoxShape_getAnisotropicRollingFrictionDirection(const btBoxShape *_this);

///optional user data pointer
/// Generated from method `btBoxShape::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btBoxShape_setUserPointer(btBoxShape *_this, void *userPtr);

/// Generated from method `btBoxShape::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btBoxShape_getUserPointer(const btBoxShape *_this);

/// Generated from method `btBoxShape::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btBoxShape_setUserIndex(btBoxShape *_this, int index);

/// Generated from method `btBoxShape::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btBoxShape_getUserIndex(const btBoxShape *_this);

/// Generated from method `btBoxShape::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btBoxShape_setUserIndex2(btBoxShape *_this, int index);

/// Generated from method `btBoxShape::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btBoxShape_getUserIndex2(const btBoxShape *_this);

#ifdef __cplusplus
} // extern "C"
#endif
