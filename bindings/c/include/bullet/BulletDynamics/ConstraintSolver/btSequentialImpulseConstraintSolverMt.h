// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btConstraintSolver btConstraintSolver; // Defined in `#include <bullet/BulletDynamics/ConstraintSolver/btConstraintSolver.h>`.
typedef struct btSequentialImpulseConstraintSolver btSequentialImpulseConstraintSolver; // Defined in `#include <bullet/BulletDynamics/ConstraintSolver/btSequentialImpulseConstraintSolver.h>`.


// temp struct used to collect info from persistent manifolds into a cache-friendly struct using multiple threads
/// Generated from class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo`.
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo;

// temp struct used for setting up joint constraints in parallel
/// Generated from class `btSequentialImpulseConstraintSolverMt::JointParams`.
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btSequentialImpulseConstraintSolverMt_JointParams btSequentialImpulseConstraintSolverMt_JointParams;

///
/// btSequentialImpulseConstraintSolverMt
///
///  A multithreaded variant of the sequential impulse constraint solver. The constraints to be solved are grouped into
///  batches and phases where each batch of constraints within a given phase can be solved in parallel with the rest.
///  Ideally we want as few phases as possible, and each phase should have many batches, and all of the batches should
///  have about the same number of constraints.
///  This method works best on a large island of many constraints.
///
///  Supports all of the features of the normal sequential impulse solver such as:
///    - split penetration impulse
///    - rolling friction
///    - interleaving constraints
///    - warmstarting
///    - 2 friction directions
///    - randomized constraint ordering
///    - early termination when leastSquaresResidualThreshold is satisfied
///
///  When the SOLVER_INTERLEAVE_CONTACT_AND_FRICTION_CONSTRAINTS flag is enabled, unlike the normal SequentialImpulse solver,
///  the rolling friction is interleaved as well.
///  Interleaving the contact penetration constraints with friction reduces the number of parallel loops that need to be done,
///  which reduces threading overhead so it can be a performance win, however, it does seem to produce a less stable simulation,
///  at least on stacks of blocks.
///
///  When the SOLVER_RANDMIZE_ORDER flag is enabled, the ordering of phases, and the ordering of constraints within each batch
///  is randomized, however it does not swap constraints between batches.
///  This is to avoid regenerating the batches for each solver iteration which would be quite costly in performance.
///
///  Note that a non-zero leastSquaresResidualThreshold could possibly affect the determinism of the simulation
///  if the task scheduler's parallelSum operation is non-deterministic. The parallelSum operation can be non-deterministic
///  because floating point addition is not associative due to rounding errors.
///  The task scheduler can and should ensure that the result of any parallelSum operation is deterministic.
///
/// Generated from class `btSequentialImpulseConstraintSolverMt`.
/// Base classes:
///   Direct: (non-virtual)
///     `btSequentialImpulseConstraintSolver`
///   Indirect: (non-virtual)
///     `btConstraintSolver`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btSequentialImpulseConstraintSolverMt btSequentialImpulseConstraintSolverMt;

// whether to allow nested parallel operations
/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_allowNestedParallelForLoops`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const bool *btSequentialImpulseConstraintSolverMt_Get_s_allowNestedParallelForLoops(void);

// whether to allow nested parallel operations
/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_allowNestedParallelForLoops`.
/// When this function is called, this object will drop object references it held previously in `s_allowNestedParallelForLoops`.
BULLET_API void btSequentialImpulseConstraintSolverMt_Set_s_allowNestedParallelForLoops(bool value);

// whether to allow nested parallel operations
/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_allowNestedParallelForLoops`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API bool *btSequentialImpulseConstraintSolverMt_GetMutable_s_allowNestedParallelForLoops(void);

// don't even try to batch if fewer manifolds than this
/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_minimumContactManifoldsForBatching`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_Get_s_minimumContactManifoldsForBatching(void);

// don't even try to batch if fewer manifolds than this
/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_minimumContactManifoldsForBatching`.
/// When this function is called, this object will drop object references it held previously in `s_minimumContactManifoldsForBatching`.
BULLET_API void btSequentialImpulseConstraintSolverMt_Set_s_minimumContactManifoldsForBatching(int value);

// don't even try to batch if fewer manifolds than this
/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_minimumContactManifoldsForBatching`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API int *btSequentialImpulseConstraintSolverMt_GetMutable_s_minimumContactManifoldsForBatching(void);

// desired number of constraints per batch
/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_minBatchSize`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_Get_s_minBatchSize(void);

// desired number of constraints per batch
/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_minBatchSize`.
/// When this function is called, this object will drop object references it held previously in `s_minBatchSize`.
BULLET_API void btSequentialImpulseConstraintSolverMt_Set_s_minBatchSize(int value);

// desired number of constraints per batch
/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_minBatchSize`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API int *btSequentialImpulseConstraintSolverMt_GetMutable_s_minBatchSize(void);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_maxBatchSize`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_Get_s_maxBatchSize(void);

/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_maxBatchSize`.
/// When this function is called, this object will drop object references it held previously in `s_maxBatchSize`.
BULLET_API void btSequentialImpulseConstraintSolverMt_Set_s_maxBatchSize(int value);

/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt` named `s_maxBatchSize`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API int *btSequentialImpulseConstraintSolverMt_GetMutable_s_maxBatchSize(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSequentialImpulseConstraintSolverMt_Destroy()` to free it when you're done using it.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btSequentialImpulseConstraintSolverMt_DestroyArray()`.
/// Use `btSequentialImpulseConstraintSolverMt_OffsetMutablePtr()` and `btSequentialImpulseConstraintSolverMt_OffsetPtr()` to access the array elements.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_OffsetPtr(const btSequentialImpulseConstraintSolverMt *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_OffsetMutablePtr(btSequentialImpulseConstraintSolverMt *ptr, ptrdiff_t i);

/// Upcasts an instance of `btSequentialImpulseConstraintSolverMt` to its base class `btConstraintSolver`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConstraintSolver *btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver(const btSequentialImpulseConstraintSolverMt *object);

/// Upcasts an instance of `btSequentialImpulseConstraintSolverMt` to its base class `btConstraintSolver`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConstraintSolver *btSequentialImpulseConstraintSolverMt_MutableUpcastTo_btConstraintSolver(btSequentialImpulseConstraintSolverMt *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_StaticDowncastFrom_btConstraintSolver(const btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableStaticDowncastFrom_btConstraintSolver(btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver(const btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableDynamicDowncastFrom_btConstraintSolver(btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DynamicDowncastFromOrFail_btConstraintSolver(const btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableDynamicDowncastFromOrFail_btConstraintSolver(btConstraintSolver *object);

/// Upcasts an instance of `btSequentialImpulseConstraintSolverMt` to its base class `btSequentialImpulseConstraintSolver`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver(const btSequentialImpulseConstraintSolverMt *object);

/// Upcasts an instance of `btSequentialImpulseConstraintSolverMt` to its base class `btSequentialImpulseConstraintSolver`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolverMt_MutableUpcastTo_btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolverMt *object);

/// Downcasts an instance of `btSequentialImpulseConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_StaticDowncastFrom_btSequentialImpulseConstraintSolver(const btSequentialImpulseConstraintSolver *object);

/// Downcasts an instance of `btSequentialImpulseConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableStaticDowncastFrom_btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolver *object);

/// Downcasts an instance of `btSequentialImpulseConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver(const btSequentialImpulseConstraintSolver *object);

/// Downcasts an instance of `btSequentialImpulseConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableDynamicDowncastFrom_btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolver *object);

/// Downcasts an instance of `btSequentialImpulseConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DynamicDowncastFromOrFail_btSequentialImpulseConstraintSolver(const btSequentialImpulseConstraintSolver *object);

/// Downcasts an instance of `btSequentialImpulseConstraintSolver` to a derived class `btSequentialImpulseConstraintSolverMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableDynamicDowncastFromOrFail_btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolver *object);

/// Generated from constructor `btSequentialImpulseConstraintSolverMt::btSequentialImpulseConstraintSolverMt`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSequentialImpulseConstraintSolverMt_Destroy()` to free it when you're done using it.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_ConstructFromAnother(Bullet_PassBy _other_pass_by, btSequentialImpulseConstraintSolverMt *_other);

/// Destroys a heap-allocated instance of `btSequentialImpulseConstraintSolverMt`. Does nothing if the pointer is null.
BULLET_API void btSequentialImpulseConstraintSolverMt_Destroy(const btSequentialImpulseConstraintSolverMt *_this);

/// Destroys a heap-allocated array of `btSequentialImpulseConstraintSolverMt`. Does nothing if the pointer is null.
BULLET_API void btSequentialImpulseConstraintSolverMt_DestroyArray(const btSequentialImpulseConstraintSolverMt *_this);

/// Generated from method `btSequentialImpulseConstraintSolverMt::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_AssignFromAnother(btSequentialImpulseConstraintSolverMt *_this, Bullet_PassBy _other_pass_by, btSequentialImpulseConstraintSolverMt *_other);

/// Generated from method `btSequentialImpulseConstraintSolverMt::operator new`.
BULLET_API void *Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btSequentialImpulseConstraintSolverMt::operator delete`.
BULLET_API void Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr(void *ptr);

/// Generated from method `btSequentialImpulseConstraintSolverMt::operator new`.
BULLET_API void *Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btSequentialImpulseConstraintSolverMt::operator delete`.
BULLET_API void Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btSequentialImpulseConstraintSolverMt::operator new[]`.
BULLET_API void *Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btSequentialImpulseConstraintSolverMt::operator delete[]`.
BULLET_API void Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr(void *ptr);

/// Generated from method `btSequentialImpulseConstraintSolverMt::operator new[]`.
BULLET_API void *Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btSequentialImpulseConstraintSolverMt::operator delete[]`.
BULLET_API void Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btSequentialImpulseConstraintSolverMt::internalAllocContactConstraints`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSequentialImpulseConstraintSolverMt_internalAllocContactConstraints(btSequentialImpulseConstraintSolverMt *_this, const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *cachedInfoArray, int numManifolds);

///clear internal cached data and reset random seed
/// Generated from method `btSequentialImpulseConstraintSolverMt::reset`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSequentialImpulseConstraintSolverMt_reset(btSequentialImpulseConstraintSolverMt *_this);

/// Generated from method `btSequentialImpulseConstraintSolverMt::btRand2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API unsigned long btSequentialImpulseConstraintSolverMt_btRand2(btSequentialImpulseConstraintSolverMt *_this);

/// Generated from method `btSequentialImpulseConstraintSolverMt::btRandInt2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btSequentialImpulseConstraintSolverMt_btRandInt2(btSequentialImpulseConstraintSolverMt *_this, int n);

/// Generated from method `btSequentialImpulseConstraintSolverMt::setRandSeed`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSequentialImpulseConstraintSolverMt_setRandSeed(btSequentialImpulseConstraintSolverMt *_this, unsigned long seed);

/// Generated from method `btSequentialImpulseConstraintSolverMt::getRandSeed`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API unsigned long btSequentialImpulseConstraintSolverMt_getRandSeed(const btSequentialImpulseConstraintSolverMt *_this);

/// Generated from method `btSequentialImpulseConstraintSolverMt::prepareSolve`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btSequentialImpulseConstraintSolverMt_prepareSolve(btSequentialImpulseConstraintSolverMt *_this, int _1, int _2);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `MAX_NUM_CONTACT_POINTS`.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_MAX_NUM_CONTACT_POINTS(void);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `numTouchingContacts`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_numTouchingContacts(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `numTouchingContacts`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `numTouchingContacts`.
BULLET_API void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Set_numTouchingContacts(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this, int value);

/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `numTouchingContacts`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_numTouchingContacts(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `solverBodyIds`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_solverBodyIds(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `solverBodyIds`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_solverBodyIds(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Returns the size of the array member of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `solverBodyIds`. The size is `2`.
BULLET_API size_t btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetSize_solverBodyIds(void);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `contactIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactIndex(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `contactIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `contactIndex`.
BULLET_API void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Set_contactIndex(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this, int value);

/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `contactIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactIndex(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `rollingFrictionIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_rollingFrictionIndex(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `rollingFrictionIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `rollingFrictionIndex`.
BULLET_API void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Set_rollingFrictionIndex(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this, int value);

/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `rollingFrictionIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_rollingFrictionIndex(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `contactHasRollingFriction`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const bool *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactHasRollingFriction(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `contactHasRollingFriction`. This is a pointer to the first element of an array.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API bool *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactHasRollingFriction(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Returns the size of the array member of class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo` named `contactHasRollingFriction`. The size is `4`.
BULLET_API size_t btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetSize_contactHasRollingFriction(void);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Destroy()` to free it when you're done using it.
BULLET_API btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DestroyArray()`.
/// Use `btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_OffsetMutablePtr()` and `btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_OffsetPtr()` to access the array elements.
BULLET_API btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_OffsetPtr(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_OffsetMutablePtr(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *ptr, ptrdiff_t i);

/// Generated from constructor `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::btContactManifoldCachedInfo`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Destroy()` to free it when you're done using it.
BULLET_API btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_other);

/// Destroys a heap-allocated instance of `btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo`. Does nothing if the pointer is null.
BULLET_API void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Destroy(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Destroys a heap-allocated array of `btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo`. Does nothing if the pointer is null.
BULLET_API void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DestroyArray(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this);

/// Generated from method `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_AssignFromAnother(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this, const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_other);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::JointParams` named `m_solverConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverConstraint(const btSequentialImpulseConstraintSolverMt_JointParams *_this);

/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt::JointParams` named `m_solverConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_solverConstraint`.
BULLET_API void btSequentialImpulseConstraintSolverMt_JointParams_Set_m_solverConstraint(btSequentialImpulseConstraintSolverMt_JointParams *_this, int value);

/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::JointParams` named `m_solverConstraint`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverConstraint(btSequentialImpulseConstraintSolverMt_JointParams *_this);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::JointParams` named `m_solverBodyA`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyA(const btSequentialImpulseConstraintSolverMt_JointParams *_this);

/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt::JointParams` named `m_solverBodyA`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_solverBodyA`.
BULLET_API void btSequentialImpulseConstraintSolverMt_JointParams_Set_m_solverBodyA(btSequentialImpulseConstraintSolverMt_JointParams *_this, int value);

/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::JointParams` named `m_solverBodyA`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyA(btSequentialImpulseConstraintSolverMt_JointParams *_this);

/// Returns a pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::JointParams` named `m_solverBodyB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyB(const btSequentialImpulseConstraintSolverMt_JointParams *_this);

/// Modifies a member variable of class `btSequentialImpulseConstraintSolverMt::JointParams` named `m_solverBodyB`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_solverBodyB`.
BULLET_API void btSequentialImpulseConstraintSolverMt_JointParams_Set_m_solverBodyB(btSequentialImpulseConstraintSolverMt_JointParams *_this, int value);

/// Returns a mutable pointer to a member variable of class `btSequentialImpulseConstraintSolverMt::JointParams` named `m_solverBodyB`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyB(btSequentialImpulseConstraintSolverMt_JointParams *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSequentialImpulseConstraintSolverMt_JointParams_Destroy()` to free it when you're done using it.
BULLET_API btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btSequentialImpulseConstraintSolverMt_JointParams_DestroyArray()`.
/// Use `btSequentialImpulseConstraintSolverMt_JointParams_OffsetMutablePtr()` and `btSequentialImpulseConstraintSolverMt_JointParams_OffsetPtr()` to access the array elements.
BULLET_API btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstructArray(size_t num_elems);

/// Constructs `btSequentialImpulseConstraintSolverMt::JointParams` elementwise.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSequentialImpulseConstraintSolverMt_JointParams_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom(int m_solverConstraint, int m_solverBodyA, int m_solverBodyB);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_OffsetPtr(const btSequentialImpulseConstraintSolverMt_JointParams *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_OffsetMutablePtr(btSequentialImpulseConstraintSolverMt_JointParams *ptr, ptrdiff_t i);

/// Generated from constructor `btSequentialImpulseConstraintSolverMt::JointParams::JointParams`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btSequentialImpulseConstraintSolverMt_JointParams_Destroy()` to free it when you're done using it.
BULLET_API btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother(const btSequentialImpulseConstraintSolverMt_JointParams *_other);

/// Destroys a heap-allocated instance of `btSequentialImpulseConstraintSolverMt_JointParams`. Does nothing if the pointer is null.
BULLET_API void btSequentialImpulseConstraintSolverMt_JointParams_Destroy(const btSequentialImpulseConstraintSolverMt_JointParams *_this);

/// Destroys a heap-allocated array of `btSequentialImpulseConstraintSolverMt_JointParams`. Does nothing if the pointer is null.
BULLET_API void btSequentialImpulseConstraintSolverMt_JointParams_DestroyArray(const btSequentialImpulseConstraintSolverMt_JointParams *_this);

/// Generated from method `btSequentialImpulseConstraintSolverMt::JointParams::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_AssignFromAnother(btSequentialImpulseConstraintSolverMt_JointParams *_this, const btSequentialImpulseConstraintSolverMt_JointParams *_other);

#ifdef __cplusplus
} // extern "C"
#endif
