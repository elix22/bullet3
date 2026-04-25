// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btQuaternion btQuaternion; // Defined in `#include <bullet/LinearMath/btQuaternion.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


/**@brief The btMatrix3x3 class implements a 3x3 rotation matrix, to perform linear algebra in combination with btQuaternion, btTransform and btVector3.
* Make sure to only include a pure orthogonal matrix without scaling. */
/// Generated from class `btMatrix3x3`.
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btMatrix3x3 btMatrix3x3;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btMatrix3x3_DestroyArray()`.
/// Use `btMatrix3x3_OffsetMutablePtr()` and `btMatrix3x3_OffsetPtr()` to access the array elements.
BULLET_API btMatrix3x3 *btMatrix3x3_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btMatrix3x3 *btMatrix3x3_OffsetPtr(const btMatrix3x3 *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btMatrix3x3 *btMatrix3x3_OffsetMutablePtr(btMatrix3x3 *ptr, ptrdiff_t i);

/** @brief Copy constructor */
/// Generated from constructor `btMatrix3x3::btMatrix3x3`.
/// The reference to things referred to by the parameter `other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_ConstructFromAnother(Bullet_PassBy other_pass_by, btMatrix3x3 *other);

/**@brief Constructor from Quaternion */
/// Generated from constructor `btMatrix3x3::btMatrix3x3`.
/// Parameter `q` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_Construct_1(const btQuaternion *q);

/*
template <typename btScalar>
Matrix3x3(const btScalar& yaw, const btScalar& pitch, const btScalar& roll)
{ 
setEulerYPR(yaw, pitch, roll);
}
*/
/** @brief Constructor with row major formatting */
/// Generated from constructor `btMatrix3x3::btMatrix3x3`.
/// Parameter `xx` can not be null. It is a single object.
/// Parameter `xy` can not be null. It is a single object.
/// Parameter `xz` can not be null. It is a single object.
/// Parameter `yx` can not be null. It is a single object.
/// Parameter `yy` can not be null. It is a single object.
/// Parameter `yz` can not be null. It is a single object.
/// Parameter `zx` can not be null. It is a single object.
/// Parameter `zy` can not be null. It is a single object.
/// Parameter `zz` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_Construct_9(const double *xx, const double *xy, const double *xz, const double *yx, const double *yy, const double *yz, const double *zx, const double *zy, const double *zz);

/// Generated from constructor `btMatrix3x3::btMatrix3x3`.
/// Parameter `v0` can not be null. It is a single object.
/// Parameter `v1` can not be null. It is a single object.
/// Parameter `v2` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_Construct_3(const btVector3 *v0, const btVector3 *v1, const btVector3 *v2);

/// Destroys a heap-allocated instance of `btMatrix3x3`. Does nothing if the pointer is null.
BULLET_API void btMatrix3x3_Destroy(const btMatrix3x3 *_this);

/// Destroys a heap-allocated array of `btMatrix3x3`. Does nothing if the pointer is null.
BULLET_API void btMatrix3x3_DestroyArray(const btMatrix3x3 *_this);

/** @brief Assignment Operator */
/// Generated from method `btMatrix3x3::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btMatrix3x3 *btMatrix3x3_AssignFromAnother(btMatrix3x3 *_this, Bullet_PassBy other_pass_by, btMatrix3x3 *other);

/** @brief Get a column of the matrix as a vector 
*  @param i Column number 0 indexed */
/// Generated from method `btMatrix3x3::getColumn`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btMatrix3x3_getColumn(const btMatrix3x3 *_this, int i);

/** @brief Get a row of the matrix as a vector 
*  @param i Row number 0 indexed */
/// Generated from method `btMatrix3x3::getRow`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btMatrix3x3_getRow(const btMatrix3x3 *_this, int i);

/** @brief Get a mutable reference to a row of the matrix as a vector 
*  @param i Row number 0 indexed */
/// Generated from method `btMatrix3x3::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btVector3 *btMatrix3x3_index_mut(btMatrix3x3 *_this, int i);

/** @brief Get a const reference to a row of the matrix as a vector 
*  @param i Row number 0 indexed */
/// Generated from method `btMatrix3x3::operator[]`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btMatrix3x3_index(const btMatrix3x3 *_this, int i);

/** @brief Multiply by the target matrix on the right
*  @param m Rotation matrix to be applied 
* Equivilant to this = this * m */
/// Generated from method `btMatrix3x3::operator*=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `m` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btMatrix3x3 *btMatrix3x3_mul_assign(btMatrix3x3 *_this, const btMatrix3x3 *m);

/** @brief Adds by the target matrix on the right
*  @param m matrix to be applied 
* Equivilant to this = this + m */
/// Generated from method `btMatrix3x3::operator+=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `m` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btMatrix3x3 *btMatrix3x3_add_assign(btMatrix3x3 *_this, const btMatrix3x3 *m);

/** @brief Substractss by the target matrix on the right
*  @param m matrix to be applied 
* Equivilant to this = this - m */
/// Generated from method `btMatrix3x3::operator-=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `m` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved in the return value.
BULLET_API btMatrix3x3 *btMatrix3x3_sub_assign(btMatrix3x3 *_this, const btMatrix3x3 *m);

/** @brief Set from the rotational part of a 4x4 OpenGL matrix
*  @param m A pointer to the beginning of the array of scalars*/
/// Generated from method `btMatrix3x3::setFromOpenGLSubMatrix`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btMatrix3x3_setFromOpenGLSubMatrix(btMatrix3x3 *_this, const double *m);

/** @brief Set the values of the matrix explicitly (row major)
*  @param xx Top left
*  @param xy Top Middle
*  @param xz Top Right
*  @param yx Middle Left
*  @param yy Middle Middle
*  @param yz Middle Right
*  @param zx Bottom Left
*  @param zy Bottom Middle
*  @param zz Bottom Right*/
/// Generated from method `btMatrix3x3::setValue`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `xx` can not be null. It is a single object.
/// Parameter `xy` can not be null. It is a single object.
/// Parameter `xz` can not be null. It is a single object.
/// Parameter `yx` can not be null. It is a single object.
/// Parameter `yy` can not be null. It is a single object.
/// Parameter `yz` can not be null. It is a single object.
/// Parameter `zx` can not be null. It is a single object.
/// Parameter `zy` can not be null. It is a single object.
/// Parameter `zz` can not be null. It is a single object.
BULLET_API void btMatrix3x3_setValue(btMatrix3x3 *_this, const double *xx, const double *xy, const double *xz, const double *yx, const double *yy, const double *yz, const double *zx, const double *zy, const double *zz);

/** @brief Set the matrix from a quaternion
*  @param q The Quaternion to match */
/// Generated from method `btMatrix3x3::setRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
BULLET_API void btMatrix3x3_setRotation(btMatrix3x3 *_this, const btQuaternion *q);

/** @brief Set the matrix from euler angles using YPR around YXZ respectively
*  @param yaw Yaw about Y axis
*  @param pitch Pitch about X axis
*  @param roll Roll about Z axis 
*/
/// Generated from method `btMatrix3x3::setEulerYPR`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `yaw` can not be null. It is a single object.
/// Parameter `pitch` can not be null. It is a single object.
/// Parameter `roll` can not be null. It is a single object.
BULLET_API void btMatrix3x3_setEulerYPR(btMatrix3x3 *_this, const double *yaw, const double *pitch, const double *roll);

/** @brief Set the matrix from euler angles YPR around ZYX axes
* @param eulerX Roll about X axis
* @param eulerY Pitch around Y axis
* @param eulerZ Yaw about Z axis
* 
* These angles are used to produce a rotation matrix. The euler
* angles are applied in ZYX order. I.e a vector is first rotated 
* about X then Y and then Z
**/
/// Generated from method `btMatrix3x3::setEulerZYX`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btMatrix3x3_setEulerZYX(btMatrix3x3 *_this, double eulerX, double eulerY, double eulerZ);

/**@brief Set the matrix to the identity */
/// Generated from method `btMatrix3x3::setIdentity`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btMatrix3x3_setIdentity(btMatrix3x3 *_this);

/**@brief Set the matrix to the identity */
/// Generated from method `btMatrix3x3::setZero`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btMatrix3x3_setZero(btMatrix3x3 *_this);

/// Generated from method `btMatrix3x3::getIdentity`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btMatrix3x3 *btMatrix3x3_getIdentity(void);

/**@brief Fill the rotational part of an OpenGL matrix and clear the shear/perspective
* @param m The array to be filled */
/// Generated from method `btMatrix3x3::getOpenGLSubMatrix`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btMatrix3x3_getOpenGLSubMatrix(const btMatrix3x3 *_this, double *m);

/**@brief Get the matrix represented as a quaternion 
* @param q The quaternion which will be set */
/// Generated from method `btMatrix3x3::getRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
BULLET_API void btMatrix3x3_getRotation(const btMatrix3x3 *_this, btQuaternion *q);

/**@brief Get the matrix represented as euler angles around YXZ, roundtrip with setEulerYPR
* @param yaw Yaw around Y axis
* @param pitch Pitch around X axis
* @param roll around Z axis */
/// Generated from method `btMatrix3x3::getEulerYPR`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `yaw` can not be null. It is a single object.
/// Parameter `pitch` can not be null. It is a single object.
/// Parameter `roll` can not be null. It is a single object.
BULLET_API void btMatrix3x3_getEulerYPR(const btMatrix3x3 *_this, double *yaw, double *pitch, double *roll);

/**@brief Get the matrix represented as euler angles around ZYX
* @param yaw Yaw around Z axis
* @param pitch Pitch around Y axis
* @param roll around X axis 
* @param solution_number Which solution of two possible solutions ( 1 or 2) are possible values*/
/// Generated from method `btMatrix3x3::getEulerZYX`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `yaw` can not be null. It is a single object.
/// Parameter `pitch` can not be null. It is a single object.
/// Parameter `roll` can not be null. It is a single object.
/// Parameter `solution_number` has a default argument: `1`, pass a null pointer to use it.
BULLET_API void btMatrix3x3_getEulerZYX(const btMatrix3x3 *_this, double *yaw, double *pitch, double *roll, const unsigned int *solution_number);

/**@brief Create a scaled copy of the matrix 
* @param s Scaling vector The elements of the vector will scale each column */
/// Generated from method `btMatrix3x3::scaled`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `s` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_scaled(const btMatrix3x3 *_this, const btVector3 *s);

/**@brief Return the determinant of the matrix */
/// Generated from method `btMatrix3x3::determinant`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btMatrix3x3_determinant(const btMatrix3x3 *_this);

/**@brief Return the adjoint of the matrix */
/// Generated from method `btMatrix3x3::adjoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_adjoint(const btMatrix3x3 *_this);

/**@brief Return the matrix with all values non negative */
/// Generated from method `btMatrix3x3::absolute`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_absolute(const btMatrix3x3 *_this);

/**@brief Return the transpose of the matrix */
/// Generated from method `btMatrix3x3::transpose`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_transpose(const btMatrix3x3 *_this);

/**@brief Return the inverse of the matrix */
/// Generated from method `btMatrix3x3::inverse`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_inverse(const btMatrix3x3 *_this);

/// Solve A * x = b, where b is a column vector. This is more efficient
/// than computing the inverse in one-shot cases.
///Solve33 is from Box2d, thanks to Erin Catto,
/// Generated from method `btMatrix3x3::solve33`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `b` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btMatrix3x3_solve33(const btMatrix3x3 *_this, const btVector3 *b);

/// Generated from method `btMatrix3x3::transposeTimes`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `m` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_transposeTimes(const btMatrix3x3 *_this, const btMatrix3x3 *m);

/// Generated from method `btMatrix3x3::timesTranspose`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `m` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btMatrix3x3_Destroy()` to free it when you're done using it.
BULLET_API btMatrix3x3 *btMatrix3x3_timesTranspose(const btMatrix3x3 *_this, const btMatrix3x3 *m);

/// Generated from method `btMatrix3x3::tdotx`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API double btMatrix3x3_tdotx(const btMatrix3x3 *_this, const btVector3 *v);

/// Generated from method `btMatrix3x3::tdoty`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API double btMatrix3x3_tdoty(const btMatrix3x3 *_this, const btVector3 *v);

/// Generated from method `btMatrix3x3::tdotz`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API double btMatrix3x3_tdotz(const btMatrix3x3 *_this, const btVector3 *v);

///extractRotation is from "A robust method to extract the rotational part of deformations"
///See http://dl.acm.org/citation.cfm?doid=2994258.2994269
///decomposes a matrix A in a orthogonal matrix R and a
///symmetric matrix S:
///A = R*S.
///note that R can include both rotation and scaling.
/// Generated from method `btMatrix3x3::extractRotation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `q` can not be null. It is a single object.
/// Parameter `tolerance` has a default argument: `1.0000000000000001e-9`, pass a null pointer to use it.
/// Parameter `maxIter` has a default argument: `100`, pass a null pointer to use it.
BULLET_API void btMatrix3x3_extractRotation(btMatrix3x3 *_this, btQuaternion *q, const double *tolerance, const int *maxIter);

/**@brief diagonalizes this matrix by the Jacobi method.
* @param rot stores the rotation from the coordinate system in which the matrix is diagonal to the original
* coordinate system, i.e., old_this = rot * new_this * rot^T.
* @param threshold See iteration
* @param iteration The iteration stops when all off-diagonal elements are less than the threshold multiplied
* by the sum of the absolute values of the diagonal, or when maxSteps have been executed.
*
* Note that this matrix is assumed to be symmetric.
*/
/// Generated from method `btMatrix3x3::diagonalize`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rot` can not be null. It is a single object.
BULLET_API void btMatrix3x3_diagonalize(btMatrix3x3 *_this, btMatrix3x3 *rot, double threshold, int maxSteps);

/**@brief Calculate the matrix cofactor 
* @param r1 The first row to use for calculating the cofactor
* @param c1 The first column to use for calculating the cofactor
* @param r1 The second row to use for calculating the cofactor
* @param c1 The second column to use for calculating the cofactor
* See http://en.wikipedia.org/wiki/Cofactor_(linear_algebra) for more details
*/
/// Generated from method `btMatrix3x3::cofac`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btMatrix3x3_cofac(const btMatrix3x3 *_this, int r1, int c1, int r2, int c2);

#ifdef __cplusplus
} // extern "C"
#endif
