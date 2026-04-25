// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


/// Generated from class `btConstraintSolver`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btSequentialImpulseConstraintSolver`
typedef struct btConstraintSolver btConstraintSolver;

/// Destroys a heap-allocated instance of `btConstraintSolver`. Does nothing if the pointer is null.
BULLET_API void btConstraintSolver_Destroy(const btConstraintSolver *_this);

/// Destroys a heap-allocated array of `btConstraintSolver`. Does nothing if the pointer is null.
BULLET_API void btConstraintSolver_DestroyArray(const btConstraintSolver *_this);

/// Generated from method `btConstraintSolver::prepareSolve`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConstraintSolver_prepareSolve(btConstraintSolver *_this, int _1, int _2);

///clear internal cached data and reset random seed
/// Generated from method `btConstraintSolver::reset`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConstraintSolver_reset(btConstraintSolver *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btConstraintSolver *btConstraintSolver_OffsetPtr(const btConstraintSolver *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btConstraintSolver *btConstraintSolver_OffsetMutablePtr(btConstraintSolver *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
