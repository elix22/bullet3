// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///The btCollisionShape class provides an interface for collision shapes that can be shared among btCollisionObjects.
/// Generated from class `btCollisionShape`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btConvexShape`
///   Indirect: (non-virtual)
///     `btBoxShape`
///     `btCapsuleShape`
///     `btConvexInternalAabbCachingShape`
///     `btConvexInternalShape`
///     `btPolyhedralConvexAabbCachingShape`
///     `btPolyhedralConvexShape`
///     `btSphereShape`
typedef struct btCollisionShape btCollisionShape;

/// Destroys a heap-allocated instance of `btCollisionShape`. Does nothing if the pointer is null.
BULLET_API void btCollisionShape_Destroy(const btCollisionShape *_this);

/// Destroys a heap-allocated array of `btCollisionShape`. Does nothing if the pointer is null.
BULLET_API void btCollisionShape_DestroyArray(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::operator new`.
BULLET_API void *Bullet_new_btCollisionShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btCollisionShape::operator delete`.
BULLET_API void Bullet_delete_btCollisionShape_void_ptr(void *ptr);

/// Generated from method `btCollisionShape::operator new`.
BULLET_API void *Bullet_new_btCollisionShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btCollisionShape::operator delete`.
BULLET_API void Bullet_delete_btCollisionShape_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btCollisionShape::operator new[]`.
BULLET_API void *Bullet_new_array_btCollisionShape_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btCollisionShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btCollisionShape_void_ptr(void *ptr);

/// Generated from method `btCollisionShape::operator new[]`.
BULLET_API void *Bullet_new_array_btCollisionShape_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btCollisionShape::operator delete[]`.
BULLET_API void Bullet_delete_array_btCollisionShape_void_ptr_void_ptr(void *_1, void *_2);

///getAabb returns the axis aligned bounding box in the coordinate frame of the given transform t.
/// Generated from method `btCollisionShape::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btCollisionShape_getAabb(const btCollisionShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btCollisionShape::getBoundingSphere`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `center` can not be null. It is a single object.
/// Parameter `radius` can not be null. It is a single object.
BULLET_API void btCollisionShape_getBoundingSphere(const btCollisionShape *_this, btVector3 *center, double *radius);

///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
/// Generated from method `btCollisionShape::getAngularMotionDisc`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionShape_getAngularMotionDisc(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::getContactBreakingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionShape_getContactBreakingThreshold(const btCollisionShape *_this, double defaultContactThresholdFactor);

///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
///result is conservative
/// Generated from method `btCollisionShape::calculateTemporalAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `curTrans` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
/// Parameter `temporalAabbMin` can not be null. It is a single object.
/// Parameter `temporalAabbMax` can not be null. It is a single object.
BULLET_API void btCollisionShape_calculateTemporalAabb(const btCollisionShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax);

/// Generated from method `btCollisionShape::isPolyhedral`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionShape_isPolyhedral(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::isConvex2d`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionShape_isConvex2d(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::isConvex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionShape_isConvex(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::isNonMoving`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionShape_isNonMoving(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::isConcave`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionShape_isConcave(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::isCompound`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionShape_isCompound(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::isSoftBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionShape_isSoftBody(const btCollisionShape *_this);

///isInfinite is used to catch simulation error (aabb check)
/// Generated from method `btCollisionShape::isInfinite`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionShape_isInfinite(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::setLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `scaling` can not be null. It is a single object.
BULLET_API void btCollisionShape_setLocalScaling(btCollisionShape *_this, const btVector3 *scaling);

/// Generated from method `btCollisionShape::getLocalScaling`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btCollisionShape_getLocalScaling(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::calculateLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btCollisionShape_calculateLocalInertia(const btCollisionShape *_this, double mass, btVector3 *inertia);

//debugging support
/// Generated from method `btCollisionShape::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btCollisionShape_getName(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::getShapeType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionShape_getShapeType(const btCollisionShape *_this);

///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
///See Bullet/Demos/RollingFrictionDemo for an example
/// Generated from method `btCollisionShape::getAnisotropicRollingFrictionDirection`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btCollisionShape_getAnisotropicRollingFrictionDirection(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::setMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionShape_setMargin(btCollisionShape *_this, double margin);

/// Generated from method `btCollisionShape::getMargin`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionShape_getMargin(const btCollisionShape *_this);

///optional user data pointer
/// Generated from method `btCollisionShape::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionShape_setUserPointer(btCollisionShape *_this, void *userPtr);

/// Generated from method `btCollisionShape::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btCollisionShape_getUserPointer(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionShape_setUserIndex(btCollisionShape *_this, int index);

/// Generated from method `btCollisionShape::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionShape_getUserIndex(const btCollisionShape *_this);

/// Generated from method `btCollisionShape::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionShape_setUserIndex2(btCollisionShape *_this, int index);

/// Generated from method `btCollisionShape::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionShape_getUserIndex2(const btCollisionShape *_this);

// clang-format on
/// Generated from method `btCollisionShape::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionShape_calculateSerializeBufferSize(const btCollisionShape *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionShape *btCollisionShape_OffsetPtr(const btCollisionShape *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionShape *btCollisionShape_OffsetMutablePtr(btCollisionShape *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
