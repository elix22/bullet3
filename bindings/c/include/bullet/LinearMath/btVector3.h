// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/**@brief btVector3 can be used to represent 3D points and vectors.
* It has an un-used w component to suit 16-byte alignment when btVector3 is stored in containers. This extra component can be used by derived classes (Quaternion?) or by user
* Ideally, this class should be replaced by a platform optimized SIMD version that keeps the data in registers
*/
/// Generated from class `btVector3`.
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btVector3 btVector3;

/// Returns a pointer to a member variable of class `btVector3` named `m_floats`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btVector3_Get_m_floats(const btVector3 *_this);

/// Returns a mutable pointer to a member variable of class `btVector3` named `m_floats`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btVector3_GetMutable_m_floats(btVector3 *_this);

/// Returns the size of the array member of class `btVector3` named `m_floats`. The size is `4`.
BULLET_API size_t btVector3_GetSize_m_floats(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btVector3_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btVector3_DestroyArray()`.
/// Use `btVector3_OffsetMutablePtr()` and `btVector3_OffsetPtr()` to access the array elements.
BULLET_API btVector3 *btVector3_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btVector3 *btVector3_OffsetPtr(const btVector3 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btVector3 *btVector3_OffsetMutablePtr(btVector3 *ptr, ptrdiff_t i);

/// Generated from constructor `btVector3::btVector3`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btVector3_ConstructFromAnother(const btVector3 *_other);

/**@brief Constructor from scalars 
* @param x X value
* @param y Y value 
* @param z Z value 
*/
/// Generated from constructor `btVector3::btVector3`.
/// Parameter `_x` can not be null. It is a single object.
/// Parameter `_y` can not be null. It is a single object.
/// Parameter `_z` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btVector3_Construct(const double *_x, const double *_y, const double *_z);

/// Destroys a heap-allocated instance of `btVector3`. Does nothing if the pointer is null.
BULLET_API void btVector3_Destroy(const btVector3 *_this);

/// Destroys a heap-allocated array of `btVector3`. Does nothing if the pointer is null.
BULLET_API void btVector3_DestroyArray(const btVector3 *_this);

//SIMD_FORCE_INLINE btScalar&       operator[](int i)       { return (&m_floats[0])[i];	}
//SIMD_FORCE_INLINE const btScalar& operator[](int i) const { return (&m_floats[0])[i]; }
///operator btScalar*() replaces operator[], using implicit conversion. We added operator != and operator == to avoid pointer comparisons.
/// Generated from conversion operator `btVector3::operator double *`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double *btVector3_ConvertTo_double_ptr(btVector3 *_this);

/// Generated from conversion operator `btVector3::operator const double *`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const double *btVector3_ConvertTo_const_double_ptr(const btVector3 *_this);

/// Generated from method `btVector3::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btVector3 *btVector3_AssignFromAnother(btVector3 *_this, const btVector3 *_other);

/// Generated from method `btVector3::operator new`.
BULLET_API void *Bullet_new_btVector3_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btVector3::operator delete`.
BULLET_API void Bullet_delete_btVector3_void_ptr(void *ptr);

/// Generated from method `btVector3::operator new`.
BULLET_API void *Bullet_new_btVector3_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btVector3::operator delete`.
BULLET_API void Bullet_delete_btVector3_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btVector3::operator new[]`.
BULLET_API void *Bullet_new_array_btVector3_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btVector3::operator delete[]`.
BULLET_API void Bullet_delete_array_btVector3_void_ptr(void *ptr);

/// Generated from method `btVector3::operator new[]`.
BULLET_API void *Bullet_new_array_btVector3_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btVector3::operator delete[]`.
BULLET_API void Bullet_delete_array_btVector3_void_ptr_void_ptr(void *_1, void *_2);

/**@brief Add a vector to this one 
* @param The vector to add to this one */
/// Generated from method `btVector3::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btVector3 *btVector3_add_assign(btVector3 *_this, const btVector3 *v);

/**@brief Subtract a vector from this one
* @param The vector to subtract */
/// Generated from method `btVector3::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btVector3 *btVector3_sub_assign(btVector3 *_this, const btVector3 *v);

/**@brief Scale the vector
* @param s Scale factor */
/// Generated from method `btVector3::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `s` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btVector3 *btVector3_mul_assign_double(btVector3 *_this, const double *s);

/**@brief Inversely scale the vector 
* @param s Scale factor to divide by */
/// Generated from method `btVector3::operator/=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `s` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btVector3 *btVector3_div_assign(btVector3 *_this, const double *s);

/**@brief Return the dot product
* @param v The other vector in the dot product */
/// Generated from method `btVector3::dot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API double btVector3_dot(const btVector3 *_this, const btVector3 *v);

/**@brief Return the length of the vector squared */
/// Generated from method `btVector3::length2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btVector3_length2(const btVector3 *_this);

/**@brief Return the length of the vector */
/// Generated from method `btVector3::length`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btVector3_length(const btVector3 *_this);

/**@brief Return the norm (length) of the vector */
/// Generated from method `btVector3::norm`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btVector3_norm(const btVector3 *_this);

/**@brief Return the norm (length) of the vector */
/// Generated from method `btVector3::safeNorm`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btVector3_safeNorm(const btVector3 *_this);

/**@brief Return the distance squared between the ends of this and another vector
* This is symantically treating the vector like a point */
/// Generated from method `btVector3::distance2`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API double btVector3_distance2(const btVector3 *_this, const btVector3 *v);

/**@brief Return the distance between the ends of this and another vector
* This is symantically treating the vector like a point */
/// Generated from method `btVector3::distance`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API double btVector3_distance(const btVector3 *_this, const btVector3 *v);

/// Generated from method `btVector3::safeNormalize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btVector3 *btVector3_safeNormalize(btVector3 *_this);

/**@brief Normalize this vector 
* x^2 + y^2 + z^2 = 1 */
/// Generated from method `btVector3::normalize`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btVector3 *btVector3_normalize(btVector3 *_this);

/**@brief Return a normalized version of this vector */
/// Generated from method `btVector3::normalized`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btVector3_normalized(const btVector3 *_this);

/**@brief Return a rotated version of this vector
* @param wAxis The axis to rotate about 
* @param angle The angle to rotate by */
/// Generated from method `btVector3::rotate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `wAxis` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btVector3_rotate(const btVector3 *_this, const btVector3 *wAxis, double angle);

/**@brief Return the angle between this and another vector
* @param v The other vector */
/// Generated from method `btVector3::angle`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API double btVector3_angle(const btVector3 *_this, const btVector3 *v);

/**@brief Return a vector with the absolute values of each element */
/// Generated from method `btVector3::absolute`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btVector3_absolute(const btVector3 *_this);

/**@brief Return the cross product between this and another vector 
* @param v The other vector */
/// Generated from method `btVector3::cross`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btVector3_cross(const btVector3 *_this, const btVector3 *v);

/// Generated from method `btVector3::triple`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v1` can not be null. It is a single object.
/// Parameter `v2` can not be null. It is a single object.
BULLET_API double btVector3_triple(const btVector3 *_this, const btVector3 *v1, const btVector3 *v2);

/**@brief Return the axis with the smallest value 
* Note return values are 0,1,2 for x, y, or z */
/// Generated from method `btVector3::minAxis`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btVector3_minAxis(const btVector3 *_this);

/**@brief Return the axis with the largest value 
* Note return values are 0,1,2 for x, y, or z */
/// Generated from method `btVector3::maxAxis`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btVector3_maxAxis(const btVector3 *_this);

/// Generated from method `btVector3::furthestAxis`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btVector3_furthestAxis(const btVector3 *_this);

/// Generated from method `btVector3::closestAxis`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btVector3_closestAxis(const btVector3 *_this);

/// Generated from method `btVector3::setInterpolate3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v0` can not be null. It is a single object.
/// Parameter `v1` can not be null. It is a single object.
BULLET_API void btVector3_setInterpolate3(btVector3 *_this, const btVector3 *v0, const btVector3 *v1, double rt);

/**@brief Return the linear interpolation between this and another vector 
* @param v The other vector 
* @param t The ration of this to v (t = 0 => return this, t=1 => return other) */
/// Generated from method `btVector3::lerp`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btVector3_lerp(const btVector3 *_this, const btVector3 *v, const double *t);

/**@brief Elementwise multiply this vector by the other 
* @param v The other vector */
/// Generated from method `btVector3::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btVector3 *btVector3_mul_assign_btVector3(btVector3 *_this, const btVector3 *v);

/**@brief Return the x value */
/// Generated from method `btVector3::getX`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btVector3_getX(const btVector3 *_this);

/**@brief Return the y value */
/// Generated from method `btVector3::getY`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btVector3_getY(const btVector3 *_this);

/**@brief Return the z value */
/// Generated from method `btVector3::getZ`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btVector3_getZ(const btVector3 *_this);

/**@brief Set the x value */
/// Generated from method `btVector3::setX`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btVector3_setX(btVector3 *_this, double _x);

/**@brief Set the y value */
/// Generated from method `btVector3::setY`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btVector3_setY(btVector3 *_this, double _y);

/**@brief Set the z value */
/// Generated from method `btVector3::setZ`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btVector3_setZ(btVector3 *_this, double _z);

/**@brief Set the w value */
/// Generated from method `btVector3::setW`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btVector3_setW(btVector3 *_this, double _w);

/**@brief Return the x value */
/// Generated from method `btVector3::x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btVector3_x(const btVector3 *_this);

/**@brief Return the y value */
/// Generated from method `btVector3::y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btVector3_y(const btVector3 *_this);

/**@brief Return the z value */
/// Generated from method `btVector3::z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btVector3_z(const btVector3 *_this);

/**@brief Return the w value */
/// Generated from method `btVector3::w`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btVector3_w(const btVector3 *_this);

/// Generated from method `btVector3::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API bool Bullet_equal_btVector3(const btVector3 *_this, const btVector3 *other);

/// Generated from method `btVector3::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API bool Bullet_not_equal_btVector3(const btVector3 *_this, const btVector3 *other);

/**@brief Set each element to the max of the current values and the values of another btVector3
* @param other The other btVector3 to compare with 
*/
/// Generated from method `btVector3::setMax`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API void btVector3_setMax(btVector3 *_this, const btVector3 *other);

/**@brief Set each element to the min of the current values and the values of another btVector3
* @param other The other btVector3 to compare with 
*/
/// Generated from method `btVector3::setMin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API void btVector3_setMin(btVector3 *_this, const btVector3 *other);

/// Generated from method `btVector3::setValue`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_x` can not be null. It is a single object.
/// Parameter `_y` can not be null. It is a single object.
/// Parameter `_z` can not be null. It is a single object.
BULLET_API void btVector3_setValue(btVector3 *_this, const double *_x, const double *_y, const double *_z);

/// Generated from method `btVector3::getSkewSymmetricMatrix`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btVector3_getSkewSymmetricMatrix(const btVector3 *_this, btVector3 *v0, btVector3 *v1, btVector3 *v2);

/// Generated from method `btVector3::setZero`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btVector3_setZero(btVector3 *_this);

/// Generated from method `btVector3::isZero`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btVector3_isZero(const btVector3 *_this);

/// Generated from method `btVector3::fuzzyZero`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btVector3_fuzzyZero(const btVector3 *_this);

/**@brief returns index of maximum dot product between this and vectors in array[]
* @param array The other vectors 
* @param array_count The number of other vectors 
* @param dotOut The maximum dot product */
/// Generated from method `btVector3::maxDot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `dotOut` can not be null. It is a single object.
BULLET_API long btVector3_maxDot(const btVector3 *_this, const btVector3 *array, long array_count, double *dotOut);

/**@brief returns index of minimum dot product between this and vectors in array[]
* @param array The other vectors 
* @param array_count The number of other vectors 
* @param dotOut The minimum dot product */
/// Generated from method `btVector3::minDot`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `dotOut` can not be null. It is a single object.
BULLET_API long btVector3_minDot(const btVector3 *_this, const btVector3 *array, long array_count, double *dotOut);

/* create a vector as  btVector3( this->dot( btVector3 v0 ), this->dot( btVector3 v1), this->dot( btVector3 v2 ))  */
/// Generated from method `btVector3::dot3`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v0` can not be null. It is a single object.
/// Parameter `v1` can not be null. It is a single object.
/// Parameter `v2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btVector3_dot3(const btVector3 *_this, const btVector3 *v0, const btVector3 *v1, const btVector3 *v2);

#ifdef __cplusplus
} // extern "C"
#endif
