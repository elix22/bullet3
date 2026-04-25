// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btMatrix3x3 btMatrix3x3; // Defined in `#include <bullet/LinearMath/btMatrix3x3.h>`.
typedef struct btQuaternion btQuaternion; // Defined in `#include <bullet/LinearMath/btQuaternion.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


/**@brief The btTransform class supports rigid transforms with only translation and rotation and no scaling/shear.
*It can be used in combination with btVector3, btQuaternion and btMatrix3x3 linear algebra classes. */
/// Generated from class `btTransform`.
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btTransform btTransform;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btTransform_Destroy()` to free it when you're done using it.
BULLET_API btTransform *btTransform_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btTransform_DestroyArray()`.
/// Use `btTransform_OffsetMutablePtr()` and `btTransform_OffsetPtr()` to access the array elements.
BULLET_API btTransform *btTransform_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btTransform *btTransform_OffsetPtr(const btTransform *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btTransform *btTransform_OffsetMutablePtr(btTransform *ptr, ptrdiff_t i);

/**@brief Copy constructor */
/// Generated from constructor `btTransform::btTransform`.
/// The reference to things referred to by the parameter `other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btTransform_Destroy()` to free it when you're done using it.
BULLET_API btTransform *btTransform_ConstructFromAnother(Bullet_PassBy other_pass_by, btTransform *other);

/**@brief Constructor from btQuaternion (optional btVector3 )
* @param q Rotation from quaternion 
* @param c Translation from Vector (default 0,0,0) */
/// Generated from constructor `btTransform::btTransform`.
/// Parameter `q` can not be null. It is a single object.
/// Parameter `c` is a single object.
/// Parameter `c` has a default argument: `btVector3(btScalar(0), btScalar(0), btScalar(0))`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `btTransform_Destroy()` to free it when you're done using it.
BULLET_API btTransform *btTransform_Construct_btQuaternion(const btQuaternion *q, const btVector3 *c);

/**@brief Constructor from btMatrix3x3 (optional btVector3)
* @param b Rotation from Matrix 
* @param c Translation from Vector default (0,0,0)*/
/// Generated from constructor `btTransform::btTransform`.
/// Parameter `b` can not be null. It is a single object.
/// Parameter `c` is a single object.
/// Parameter `c` has a default argument: `btVector3(btScalar(0), btScalar(0), btScalar(0))`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `btTransform_Destroy()` to free it when you're done using it.
BULLET_API btTransform *btTransform_Construct_btMatrix3x3(const btMatrix3x3 *b, const btVector3 *c);

/// Destroys a heap-allocated instance of `btTransform`. Does nothing if the pointer is null.
BULLET_API void btTransform_Destroy(const btTransform *_this);

/// Destroys a heap-allocated array of `btTransform`. Does nothing if the pointer is null.
BULLET_API void btTransform_DestroyArray(const btTransform *_this);

/**@brief Assignment Operator */
/// Generated from method `btTransform::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btTransform *btTransform_AssignFromAnother(btTransform *_this, Bullet_PassBy other_pass_by, btTransform *other);

/// Generated from method `btTransform::operator new`.
BULLET_API void *Bullet_new_btTransform_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btTransform::operator delete`.
BULLET_API void Bullet_delete_btTransform_void_ptr(void *ptr);

/// Generated from method `btTransform::operator new`.
BULLET_API void *Bullet_new_btTransform_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btTransform::operator delete`.
BULLET_API void Bullet_delete_btTransform_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btTransform::operator new[]`.
BULLET_API void *Bullet_new_array_btTransform_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btTransform::operator delete[]`.
BULLET_API void Bullet_delete_array_btTransform_void_ptr(void *ptr);

/// Generated from method `btTransform::operator new[]`.
BULLET_API void *Bullet_new_array_btTransform_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btTransform::operator delete[]`.
BULLET_API void Bullet_delete_array_btTransform_void_ptr_void_ptr(void *_1, void *_2);

/**@brief Set the current transform as the value of the product of two transforms
* @param t1 Transform 1
* @param t2 Transform 2
* This = Transform1 * Transform2 */
/// Generated from method `btTransform::mult`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t1` can not be null. It is a single object.
/// Parameter `t2` can not be null. It is a single object.
BULLET_API void btTransform_mult(btTransform *_this, const btTransform *t1, const btTransform *t2);

/**@brief Return the transform of the vector */
/// Generated from method `btTransform::operator()`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `x` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btTransform_call(const btTransform *_this, const btVector3 *x);

/**@brief Return the transform of the vector */
/// Generated from method `btTransform::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `x` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *Bullet_mul_btTransform_btVector3(const btTransform *_this, const btVector3 *x);

/**@brief Return the transform of the btQuaternion */
/// Generated from method `btTransform::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *Bullet_mul_btTransform_btQuaternion(const btTransform *_this, const btQuaternion *q);

/**@brief Return the basis matrix for the rotation */
/// Generated from method `btTransform::getBasis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btMatrix3x3 *btTransform_getBasis_mut(btTransform *_this);

/**@brief Return the basis matrix for the rotation */
/// Generated from method `btTransform::getBasis`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btMatrix3x3 *btTransform_getBasis(const btTransform *_this);

/**@brief Return the origin vector translation */
/// Generated from method `btTransform::getOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btVector3 *btTransform_getOrigin_mut(btTransform *_this);

/**@brief Return the origin vector translation */
/// Generated from method `btTransform::getOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btTransform_getOrigin(const btTransform *_this);

/**@brief Return a quaternion representing the rotation */
/// Generated from method `btTransform::getRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btTransform_getRotation(const btTransform *_this);

/**@brief Set from an array 
* @param m A pointer to a 16 element array (12 rotation(row major padded on the right by 1), and 3 translation */
/// Generated from method `btTransform::setFromOpenGLMatrix`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btTransform_setFromOpenGLMatrix(btTransform *_this, const double *m);

/**@brief Fill an array representation
* @param m A pointer to a 16 element array (12 rotation(row major padded on the right by 1), and 3 translation */
/// Generated from method `btTransform::getOpenGLMatrix`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btTransform_getOpenGLMatrix(const btTransform *_this, double *m);

/**@brief Set the translational element
* @param origin The vector to set the translation to */
/// Generated from method `btTransform::setOrigin`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `origin` can not be null. It is a single object.
BULLET_API void btTransform_setOrigin(btTransform *_this, const btVector3 *origin);

/// Generated from method `btTransform::invXform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inVec` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btTransform_invXform(const btTransform *_this, const btVector3 *inVec);

/**@brief Set the rotational element by btMatrix3x3 */
/// Generated from method `btTransform::setBasis`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `basis` can not be null. It is a single object.
BULLET_API void btTransform_setBasis(btTransform *_this, const btMatrix3x3 *basis);

/**@brief Set the rotational element by btQuaternion */
/// Generated from method `btTransform::setRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
BULLET_API void btTransform_setRotation(btTransform *_this, const btQuaternion *q);

/**@brief Set this transformation to the identity */
/// Generated from method `btTransform::setIdentity`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btTransform_setIdentity(btTransform *_this);

/**@brief Multiply this Transform by another(this = this * another) 
* @param t The other transform */
/// Generated from method `btTransform::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btTransform *btTransform_mul_assign(btTransform *_this, const btTransform *t);

/**@brief Return the inverse of this transform */
/// Generated from method `btTransform::inverse`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btTransform_Destroy()` to free it when you're done using it.
BULLET_API btTransform *btTransform_inverse(const btTransform *_this);

/**@brief Return the inverse of this transform times the other transform
* @param t The other transform 
* return this.inverse() * the other */
/// Generated from method `btTransform::inverseTimes`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btTransform_Destroy()` to free it when you're done using it.
BULLET_API btTransform *btTransform_inverseTimes(const btTransform *_this, const btTransform *t);

/**@brief Return the product of this transform and the other */
/// Generated from method `btTransform::operator*`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `t` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btTransform_Destroy()` to free it when you're done using it.
BULLET_API btTransform *Bullet_mul_btTransform(const btTransform *_this, const btTransform *t);

/**@brief Return an identity transform */
/// Generated from method `btTransform::getIdentity`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btTransform *btTransform_getIdentity(void);

#ifdef __cplusplus
} // extern "C"
#endif
