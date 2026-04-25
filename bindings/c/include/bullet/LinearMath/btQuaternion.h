// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btQuadWord btQuadWord; // Defined in `#include <bullet/LinearMath/btQuadWord.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


/**@brief The btQuaternion implements quaternion to perform linear algebra rotations in combination with btMatrix3x3, btVector3 and btTransform. */
/// Generated from class `btQuaternion`.
/// Base classes:
///   Direct: (non-virtual)
///     `btQuadWord`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btQuaternion btQuaternion;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btQuaternion_DestroyArray()`.
/// Use `btQuaternion_OffsetMutablePtr()` and `btQuaternion_OffsetPtr()` to access the array elements.
BULLET_API btQuaternion *btQuaternion_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btQuaternion *btQuaternion_OffsetPtr(const btQuaternion *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btQuaternion *btQuaternion_OffsetMutablePtr(btQuaternion *ptr, ptrdiff_t i);

/// Upcasts an instance of `btQuaternion` to its base class `btQuadWord`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btQuadWord *btQuaternion_UpcastTo_btQuadWord(const btQuaternion *object);

/// Upcasts an instance of `btQuaternion` to its base class `btQuadWord`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btQuadWord *btQuaternion_MutableUpcastTo_btQuadWord(btQuaternion *object);

/// Downcasts an instance of `btQuadWord` to a derived class `btQuaternion`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btQuaternion *btQuaternion_StaticDowncastFrom_btQuadWord(const btQuadWord *object);

/// Downcasts an instance of `btQuadWord` to a derived class `btQuaternion`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btQuaternion *btQuaternion_MutableStaticDowncastFrom_btQuadWord(btQuadWord *object);

/// Generated from constructor `btQuaternion::btQuaternion`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_ConstructFromAnother(const btQuaternion *_other);

//		template <typename btScalar>
//		explicit Quaternion(const btScalar *v) : Tuple4<btScalar>(v) {}
/**@brief Constructor from scalars */
/// Generated from constructor `btQuaternion::btQuaternion`.
/// Parameter `_x` can not be null. It is a single object.
/// Parameter `_y` can not be null. It is a single object.
/// Parameter `_z` can not be null. It is a single object.
/// Parameter `_w` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_Construct_4(const double *_x, const double *_y, const double *_z, const double *_w);

/**@brief Axis angle Constructor
* @param axis The axis which the rotation is around
* @param angle The magnitude of the rotation around the angle (Radians) */
/// Generated from constructor `btQuaternion::btQuaternion`.
/// Parameter `_axis` can not be null. It is a single object.
/// Parameter `_angle` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_Construct_2(const btVector3 *_axis, const double *_angle);

/**@brief Constructor from Euler angles
* @param yaw Angle around Y unless BT_EULER_DEFAULT_ZYX defined then Z
* @param pitch Angle around X unless BT_EULER_DEFAULT_ZYX defined then Y
* @param roll Angle around Z unless BT_EULER_DEFAULT_ZYX defined then X */
/// Generated from constructor `btQuaternion::btQuaternion`.
/// Parameter `yaw` can not be null. It is a single object.
/// Parameter `pitch` can not be null. It is a single object.
/// Parameter `roll` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_Construct_3(const double *yaw, const double *pitch, const double *roll);

/// Destroys a heap-allocated instance of `btQuaternion`. Does nothing if the pointer is null.
BULLET_API void btQuaternion_Destroy(const btQuaternion *_this);

/// Destroys a heap-allocated array of `btQuaternion`. Does nothing if the pointer is null.
BULLET_API void btQuaternion_DestroyArray(const btQuaternion *_this);

//SIMD_FORCE_INLINE btScalar&       operator[](int i)       { return (&m_floats[0])[i];	}
//SIMD_FORCE_INLINE const btScalar& operator[](int i) const { return (&m_floats[0])[i]; }
///operator btScalar*() replaces operator[], using implicit conversion. We added operator != and operator == to avoid pointer comparisons.
/// Generated from conversion operator `btQuaternion::operator double *`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double *btQuaternion_ConvertTo_double_ptr(btQuaternion *_this);

/// Generated from conversion operator `btQuaternion::operator const double *`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const double *btQuaternion_ConvertTo_const_double_ptr(const btQuaternion *_this);

/// Generated from method `btQuaternion::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btQuaternion *btQuaternion_AssignFromAnother(btQuaternion *_this, const btQuaternion *_other);

/**@brief Set the rotation using axis angle notation 
* @param axis The axis around which to rotate
* @param angle The magnitude of the rotation in Radians */
/// Generated from method `btQuaternion::setRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `axis` can not be null. It is a single object.
/// Parameter `_angle` can not be null. It is a single object.
BULLET_API void btQuaternion_setRotation(btQuaternion *_this, const btVector3 *axis, const double *_angle);

/**@brief Set the quaternion using Euler angles
* @param yaw Angle around Y
* @param pitch Angle around X
* @param roll Angle around Z */
/// Generated from method `btQuaternion::setEuler`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `yaw` can not be null. It is a single object.
/// Parameter `pitch` can not be null. It is a single object.
/// Parameter `roll` can not be null. It is a single object.
BULLET_API void btQuaternion_setEuler(btQuaternion *_this, const double *yaw, const double *pitch, const double *roll);

/**@brief Set the quaternion using euler angles 
* @param yaw Angle around Z
* @param pitch Angle around Y
* @param roll Angle around X */
/// Generated from method `btQuaternion::setEulerZYX`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `yawZ` can not be null. It is a single object.
/// Parameter `pitchY` can not be null. It is a single object.
/// Parameter `rollX` can not be null. It is a single object.
BULLET_API void btQuaternion_setEulerZYX(btQuaternion *_this, const double *yawZ, const double *pitchY, const double *rollX);

/**@brief Get the euler angles from this quaternion
* @param yaw Angle around Z
* @param pitch Angle around Y
* @param roll Angle around X */
/// Generated from method `btQuaternion::getEulerZYX`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `yawZ` can not be null. It is a single object.
/// Parameter `pitchY` can not be null. It is a single object.
/// Parameter `rollX` can not be null. It is a single object.
BULLET_API void btQuaternion_getEulerZYX(const btQuaternion *_this, double *yawZ, double *pitchY, double *rollX);

/**@brief Add two quaternions
* @param q The quaternion to add to this one */
/// Generated from method `btQuaternion::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btQuaternion *btQuaternion_add_assign(btQuaternion *_this, const btQuaternion *q);

/**@brief Subtract out a quaternion
* @param q The quaternion to subtract from this one */
/// Generated from method `btQuaternion::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btQuaternion *btQuaternion_sub_assign(btQuaternion *_this, const btQuaternion *q);

/**@brief Scale this quaternion
* @param s The scalar to scale by */
/// Generated from method `btQuaternion::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `s` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btQuaternion *btQuaternion_mul_assign_double(btQuaternion *_this, const double *s);

/**@brief Multiply this quaternion by q on the right
* @param q The other quaternion 
* Equivilant to this = this * q */
/// Generated from method `btQuaternion::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btQuaternion *btQuaternion_mul_assign_btQuaternion(btQuaternion *_this, const btQuaternion *q);

/**@brief Return the dot product between this quaternion and another
* @param q The other quaternion */
/// Generated from method `btQuaternion::dot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
BULLET_API double btQuaternion_dot(const btQuaternion *_this, const btQuaternion *q);

/**@brief Return the length squared of the quaternion */
/// Generated from method `btQuaternion::length2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btQuaternion_length2(const btQuaternion *_this);

/**@brief Return the length of the quaternion */
/// Generated from method `btQuaternion::length`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btQuaternion_length(const btQuaternion *_this);

/// Generated from method `btQuaternion::safeNormalize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btQuaternion *btQuaternion_safeNormalize(btQuaternion *_this);

/**@brief Normalize the quaternion 
* Such that x^2 + y^2 + z^2 +w^2 = 1 */
/// Generated from method `btQuaternion::normalize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btQuaternion *btQuaternion_normalize(btQuaternion *_this);

/**@brief Return a scaled version of this quaternion
* @param s The scale factor */
/// Generated from method `btQuaternion::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `s` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *Bullet_mul_btQuaternion_double(const btQuaternion *_this, const double *s);

/**@brief Return an inversely scaled versionof this quaternion
* @param s The inverse scale factor */
/// Generated from method `btQuaternion::operator/`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `s` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *Bullet_div_btQuaternion_double(const btQuaternion *_this, const double *s);

/**@brief Inversely scale this quaternion
* @param s The scale factor */
/// Generated from method `btQuaternion::operator/=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `s` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btQuaternion *btQuaternion_div_assign(btQuaternion *_this, const double *s);

/**@brief Return a normalized version of this quaternion */
/// Generated from method `btQuaternion::normalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_normalized(const btQuaternion *_this);

/**@brief Return the ***half*** angle between this quaternion and the other
* @param q The other quaternion */
/// Generated from method `btQuaternion::angle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
BULLET_API double btQuaternion_angle(const btQuaternion *_this, const btQuaternion *q);

/**@brief Return the angle between this quaternion and the other along the shortest path
* @param q The other quaternion */
/// Generated from method `btQuaternion::angleShortestPath`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
BULLET_API double btQuaternion_angleShortestPath(const btQuaternion *_this, const btQuaternion *q);

/**@brief Return the angle [0, 2Pi] of rotation represented by this quaternion */
/// Generated from method `btQuaternion::getAngle`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btQuaternion_getAngle(const btQuaternion *_this);

/**@brief Return the angle [0, Pi] of rotation represented by this quaternion along the shortest path */
/// Generated from method `btQuaternion::getAngleShortestPath`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btQuaternion_getAngleShortestPath(const btQuaternion *_this);

/**@brief Return the axis of the rotation represented by this quaternion */
/// Generated from method `btQuaternion::getAxis`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btQuaternion_getAxis(const btQuaternion *_this);

/**@brief Return the inverse of this quaternion */
/// Generated from method `btQuaternion::inverse`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_inverse(const btQuaternion *_this);

/**@brief Return the sum of this quaternion and the other 
* @param q2 The other quaternion */
/// Generated from method `btQuaternion::operator+`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *Bullet_add_btQuaternion(const btQuaternion *_this, const btQuaternion *q2);

/**@brief Return the difference between this quaternion and the other 
* @param q2 The other quaternion */
/// Generated from method `btQuaternion::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *Bullet_sub_btQuaternion(const btQuaternion *_this, const btQuaternion *q2);

/**@brief Return the negative of this quaternion 
* This simply negates each element */
/// Generated from method `btQuaternion::operator-`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *Bullet_neg_btQuaternion(const btQuaternion *_this);

/**@todo document this and it's use */
/// Generated from method `btQuaternion::farthest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `qd` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_farthest(const btQuaternion *_this, const btQuaternion *qd);

/**@todo document this and it's use */
/// Generated from method `btQuaternion::nearest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `qd` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_nearest(const btQuaternion *_this, const btQuaternion *qd);

/**@brief Return the quaternion which is the result of Spherical Linear Interpolation between this and the other quaternion
* @param q The other quaternion to interpolate with 
* @param t The ratio between this and q to interpolate.  If t = 0 the result is this, if t=1 the result is q.
* Slerp interpolates assuming constant velocity.  */
/// Generated from method `btQuaternion::slerp`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btQuaternion_slerp(const btQuaternion *_this, const btQuaternion *q, const double *t);

/// Generated from method `btQuaternion::getIdentity`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btQuaternion *btQuaternion_getIdentity(void);

/// Generated from method `btQuaternion::getW`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuaternion_getW(const btQuaternion *_this);

/**@brief Return the x value */
/// Generated from method `btQuaternion::getX`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuaternion_getX(const btQuaternion *_this);

/**@brief Return the y value */
/// Generated from method `btQuaternion::getY`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuaternion_getY(const btQuaternion *_this);

/**@brief Return the z value */
/// Generated from method `btQuaternion::getZ`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuaternion_getZ(const btQuaternion *_this);

/**@brief Set the x value */
/// Generated from method `btQuaternion::setX`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btQuaternion_setX(btQuaternion *_this, double _x);

/**@brief Set the y value */
/// Generated from method `btQuaternion::setY`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btQuaternion_setY(btQuaternion *_this, double _y);

/**@brief Set the z value */
/// Generated from method `btQuaternion::setZ`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btQuaternion_setZ(btQuaternion *_this, double _z);

/**@brief Set the w value */
/// Generated from method `btQuaternion::setW`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btQuaternion_setW(btQuaternion *_this, double _w);

/**@brief Return the x value */
/// Generated from method `btQuaternion::x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuaternion_x(const btQuaternion *_this);

/**@brief Return the y value */
/// Generated from method `btQuaternion::y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuaternion_y(const btQuaternion *_this);

/**@brief Return the z value */
/// Generated from method `btQuaternion::z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuaternion_z(const btQuaternion *_this);

/**@brief Return the w value */
/// Generated from method `btQuaternion::w`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuaternion_w(const btQuaternion *_this);

/// Generated from method `btQuaternion::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API bool Bullet_equal_btQuaternion_btQuadWord(const btQuaternion *_this, const btQuadWord *other);

/// Generated from method `btQuaternion::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API bool Bullet_not_equal_btQuaternion_btQuadWord(const btQuaternion *_this, const btQuadWord *other);

/**@brief Set each element to the max of the current values and the values of another btQuadWord
* @param other The other btQuadWord to compare with 
*/
/// Generated from method `btQuaternion::setMax`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API void btQuaternion_setMax(btQuaternion *_this, const btQuadWord *other);

/**@brief Set each element to the min of the current values and the values of another btQuadWord
* @param other The other btQuadWord to compare with 
*/
/// Generated from method `btQuaternion::setMin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API void btQuaternion_setMin(btQuaternion *_this, const btQuadWord *other);

#ifdef __cplusplus
} // extern "C"
#endif
