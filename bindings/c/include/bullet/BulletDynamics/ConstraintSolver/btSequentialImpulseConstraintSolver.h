// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btConstraintSolver btConstraintSolver; // Defined in `#include <bullet/BulletDynamics/ConstraintSolver/btConstraintSolver.h>`.


///The btSequentialImpulseConstraintSolver is a fast SIMD implementation of the Projected Gauss Seidel (iterative LCP) method.
/// Generated from class `btSequentialImpulseConstraintSolver`.
/// Base classes:
///   Direct: (non-virtual)
///     `btConstraintSolver`
/// Derived classes:
///   Direct: (non-virtual)
///     `btSequentialImpulseConstraintSolverMt`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btSequentialImpulseConstraintSolver btSequentialImpulseConstraintSolver;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSequentialImpulseConstraintSolver_Destroy()` to free it when you're done using it.
BULLET_API btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btSequentialImpulseConstraintSolver_DestroyArray()`.
/// Use `btSequentialImpulseConstraintSolver_OffsetMutablePtr()` and `btSequentialImpulseConstraintSolver_OffsetPtr()` to access the array elements.
BULLET_API btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_OffsetPtr(const btSequentialImpulseConstraintSolver *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_OffsetMutablePtr(btSequentialImpulseConstraintSolver *ptr, ptrdiff_t i);

/// Upcasts an instance of `btSequentialImpulseConstraintSolver` to its base class `btConstraintSolver`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConstraintSolver *btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver(const btSequentialImpulseConstraintSolver *object);

/// Upcasts an instance of `btSequentialImpulseConstraintSolver` to its base class `btConstraintSolver`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConstraintSolver *btSequentialImpulseConstraintSolver_MutableUpcastTo_btConstraintSolver(btSequentialImpulseConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolver`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_StaticDowncastFrom_btConstraintSolver(const btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolver`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_MutableStaticDowncastFrom_btConstraintSolver(btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolver`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver(const btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolver`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_MutableDynamicDowncastFrom_btConstraintSolver(btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolver`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_DynamicDowncastFromOrFail_btConstraintSolver(const btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolver`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_MutableDynamicDowncastFromOrFail_btConstraintSolver(btConstraintSolver *object);

/// Generated from constructor `btSequentialImpulseConstraintSolver::btSequentialImpulseConstraintSolver`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSequentialImpulseConstraintSolver_Destroy()` to free it when you're done using it.
BULLET_API btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_ConstructFromAnother(Bullet_PassBy _other_pass_by, btSequentialImpulseConstraintSolver *_other);

/// Destroys a heap-allocated instance of `btSequentialImpulseConstraintSolver`. Does nothing if the pointer is null.
BULLET_API void btSequentialImpulseConstraintSolver_Destroy(const btSequentialImpulseConstraintSolver *_this);

/// Destroys a heap-allocated array of `btSequentialImpulseConstraintSolver`. Does nothing if the pointer is null.
BULLET_API void btSequentialImpulseConstraintSolver_DestroyArray(const btSequentialImpulseConstraintSolver *_this);

/// Generated from method `btSequentialImpulseConstraintSolver::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_AssignFromAnother(btSequentialImpulseConstraintSolver *_this, Bullet_PassBy _other_pass_by, btSequentialImpulseConstraintSolver *_other);

/// Generated from method `btSequentialImpulseConstraintSolver::operator new`.
BULLET_API void *Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btSequentialImpulseConstraintSolver::operator delete`.
BULLET_API void Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr(void *ptr);

/// Generated from method `btSequentialImpulseConstraintSolver::operator new`.
BULLET_API void *Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btSequentialImpulseConstraintSolver::operator delete`.
BULLET_API void Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btSequentialImpulseConstraintSolver::operator new[]`.
BULLET_API void *Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btSequentialImpulseConstraintSolver::operator delete[]`.
BULLET_API void Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr(void *ptr);

/// Generated from method `btSequentialImpulseConstraintSolver::operator new[]`.
BULLET_API void *Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btSequentialImpulseConstraintSolver::operator delete[]`.
BULLET_API void Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr_void_ptr(void *_1, void *_2);

///clear internal cached data and reset random seed
/// Generated from method `btSequentialImpulseConstraintSolver::reset`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSequentialImpulseConstraintSolver_reset(btSequentialImpulseConstraintSolver *_this);

/// Generated from method `btSequentialImpulseConstraintSolver::btRand2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API unsigned long btSequentialImpulseConstraintSolver_btRand2(btSequentialImpulseConstraintSolver *_this);

/// Generated from method `btSequentialImpulseConstraintSolver::btRandInt2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btSequentialImpulseConstraintSolver_btRandInt2(btSequentialImpulseConstraintSolver *_this, int n);

/// Generated from method `btSequentialImpulseConstraintSolver::setRandSeed`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSequentialImpulseConstraintSolver_setRandSeed(btSequentialImpulseConstraintSolver *_this, unsigned long seed);

/// Generated from method `btSequentialImpulseConstraintSolver::getRandSeed`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API unsigned long btSequentialImpulseConstraintSolver_getRandSeed(const btSequentialImpulseConstraintSolver *_this);

/// Generated from method `btSequentialImpulseConstraintSolver::prepareSolve`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSequentialImpulseConstraintSolver_prepareSolve(btSequentialImpulseConstraintSolver *_this, int _1, int _2);

#ifdef __cplusplus
} // extern "C"
#endif
