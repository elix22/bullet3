// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Generated from class `btQuadWord`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btQuaternion`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btQuadWord btQuadWord;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuadWord_Destroy()` to free it when you're done using it.
BULLET_API btQuadWord *btQuadWord_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btQuadWord_DestroyArray()`.
/// Use `btQuadWord_OffsetMutablePtr()` and `btQuadWord_OffsetPtr()` to access the array elements.
BULLET_API btQuadWord *btQuadWord_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btQuadWord *btQuadWord_OffsetPtr(const btQuadWord *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btQuadWord *btQuadWord_OffsetMutablePtr(btQuadWord *ptr, ptrdiff_t i);

/// Generated from constructor `btQuadWord::btQuadWord`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuadWord_Destroy()` to free it when you're done using it.
BULLET_API btQuadWord *btQuadWord_ConstructFromAnother(const btQuadWord *_other);

/**@brief Three argument constructor (zeros w)
* @param x Value of x
* @param y Value of y
* @param z Value of z
*/
/// Generated from constructor `btQuadWord::btQuadWord`.
/// Parameter `_x` can not be null. It is a single object.
/// Parameter `_y` can not be null. It is a single object.
/// Parameter `_z` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuadWord_Destroy()` to free it when you're done using it.
BULLET_API btQuadWord *btQuadWord_Construct_3(const double *_x, const double *_y, const double *_z);

/**@brief Initializing constructor
* @param x Value of x
* @param y Value of y
* @param z Value of z
* @param w Value of w
*/
/// Generated from constructor `btQuadWord::btQuadWord`.
/// Parameter `_x` can not be null. It is a single object.
/// Parameter `_y` can not be null. It is a single object.
/// Parameter `_z` can not be null. It is a single object.
/// Parameter `_w` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuadWord_Destroy()` to free it when you're done using it.
BULLET_API btQuadWord *btQuadWord_Construct_4(const double *_x, const double *_y, const double *_z, const double *_w);

/// Destroys a heap-allocated instance of `btQuadWord`. Does nothing if the pointer is null.
BULLET_API void btQuadWord_Destroy(const btQuadWord *_this);

/// Destroys a heap-allocated array of `btQuadWord`. Does nothing if the pointer is null.
BULLET_API void btQuadWord_DestroyArray(const btQuadWord *_this);

//SIMD_FORCE_INLINE btScalar&       operator[](int i)       { return (&m_floats[0])[i];	}
//SIMD_FORCE_INLINE const btScalar& operator[](int i) const { return (&m_floats[0])[i]; }
///operator btScalar*() replaces operator[], using implicit conversion. We added operator != and operator == to avoid pointer comparisons.
/// Generated from conversion operator `btQuadWord::operator double *`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double *btQuadWord_ConvertTo_double_ptr(btQuadWord *_this);

/// Generated from conversion operator `btQuadWord::operator const double *`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const double *btQuadWord_ConvertTo_const_double_ptr(const btQuadWord *_this);

/// Generated from method `btQuadWord::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btQuadWord *btQuadWord_AssignFromAnother(btQuadWord *_this, const btQuadWord *_other);

/**@brief Return the x value */
/// Generated from method `btQuadWord::getX`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuadWord_getX(const btQuadWord *_this);

/**@brief Return the y value */
/// Generated from method `btQuadWord::getY`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuadWord_getY(const btQuadWord *_this);

/**@brief Return the z value */
/// Generated from method `btQuadWord::getZ`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuadWord_getZ(const btQuadWord *_this);

/**@brief Set the x value */
/// Generated from method `btQuadWord::setX`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btQuadWord_setX(btQuadWord *_this, double _x);

/**@brief Set the y value */
/// Generated from method `btQuadWord::setY`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btQuadWord_setY(btQuadWord *_this, double _y);

/**@brief Set the z value */
/// Generated from method `btQuadWord::setZ`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btQuadWord_setZ(btQuadWord *_this, double _z);

/**@brief Set the w value */
/// Generated from method `btQuadWord::setW`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btQuadWord_setW(btQuadWord *_this, double _w);

/**@brief Return the x value */
/// Generated from method `btQuadWord::x`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuadWord_x(const btQuadWord *_this);

/**@brief Return the y value */
/// Generated from method `btQuadWord::y`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuadWord_y(const btQuadWord *_this);

/**@brief Return the z value */
/// Generated from method `btQuadWord::z`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuadWord_z(const btQuadWord *_this);

/**@brief Return the w value */
/// Generated from method `btQuadWord::w`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const double *btQuadWord_w(const btQuadWord *_this);

/// Generated from method `btQuadWord::operator==`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API bool Bullet_equal_btQuadWord(const btQuadWord *_this, const btQuadWord *other);

/// Generated from method `btQuadWord::operator!=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API bool Bullet_not_equal_btQuadWord(const btQuadWord *_this, const btQuadWord *other);

/**@brief Set x,y,z and zero w 
* @param x Value of x
* @param y Value of y
* @param z Value of z
*/
/// Generated from method `btQuadWord::setValue`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_x` can not be null. It is a single object.
/// Parameter `_y` can not be null. It is a single object.
/// Parameter `_z` can not be null. It is a single object.
BULLET_API void btQuadWord_setValue_3(btQuadWord *_this, const double *_x, const double *_y, const double *_z);

/*		void getValue(btScalar *m) const 
{
m[0] = m_floats[0];
m[1] = m_floats[1];
m[2] = m_floats[2];
}
*/
/**@brief Set the values 
* @param x Value of x
* @param y Value of y
* @param z Value of z
* @param w Value of w
*/
/// Generated from method `btQuadWord::setValue`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_x` can not be null. It is a single object.
/// Parameter `_y` can not be null. It is a single object.
/// Parameter `_z` can not be null. It is a single object.
/// Parameter `_w` can not be null. It is a single object.
BULLET_API void btQuadWord_setValue_4(btQuadWord *_this, const double *_x, const double *_y, const double *_z, const double *_w);

/**@brief Set each element to the max of the current values and the values of another btQuadWord
* @param other The other btQuadWord to compare with 
*/
/// Generated from method `btQuadWord::setMax`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API void btQuadWord_setMax(btQuadWord *_this, const btQuadWord *other);

/**@brief Set each element to the min of the current values and the values of another btQuadWord
* @param other The other btQuadWord to compare with 
*/
/// Generated from method `btQuadWord::setMin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `other` can not be null. It is a single object.
BULLET_API void btQuadWord_setMin(btQuadWord *_this, const btQuadWord *other);

#ifdef __cplusplus
} // extern "C"
#endif
