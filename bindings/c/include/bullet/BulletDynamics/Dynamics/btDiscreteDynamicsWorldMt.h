// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btBroadphaseInterface btBroadphaseInterface; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btBroadphaseInterface.h>`.
typedef struct btCollisionConfiguration btCollisionConfiguration; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionConfiguration.h>`.
typedef struct btCollisionObject btCollisionObject; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionObject.h>`.
typedef struct btCollisionShape btCollisionShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btCollisionShape.h>`.
typedef struct btCollisionWorld btCollisionWorld; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionWorld.h>`.
typedef struct btCollisionWorld_ContactResultCallback btCollisionWorld_ContactResultCallback; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionWorld.h>`.
typedef struct btCollisionWorld_ConvexResultCallback btCollisionWorld_ConvexResultCallback; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionWorld.h>`.
typedef struct btCollisionWorld_RayResultCallback btCollisionWorld_RayResultCallback; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionWorld.h>`.
typedef struct btConstraintSolver btConstraintSolver; // Defined in `#include <bullet/BulletDynamics/ConstraintSolver/btConstraintSolver.h>`.
typedef struct btConvexShape btConvexShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btConvexShape.h>`.
typedef struct btDiscreteDynamicsWorld btDiscreteDynamicsWorld; // Defined in `#include <bullet/BulletDynamics/Dynamics/btDiscreteDynamicsWorld.h>`.
typedef struct btDispatcher btDispatcher; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btDispatcher.h>`.
typedef struct btDynamicsWorld btDynamicsWorld; // Defined in `#include <bullet/BulletDynamics/Dynamics/btDynamicsWorld.h>`.
typedef struct btOverlappingPairCache btOverlappingPairCache; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>`.
typedef struct btRigidBody btRigidBody; // Defined in `#include <bullet/BulletDynamics/Dynamics/btRigidBody.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///
/// btConstraintSolverPoolMt - masquerades as a constraint solver, but really it is a threadsafe pool of them.
///
///  Each solver in the pool is protected by a mutex.  When solveGroup is called from a thread,
///  the pool looks for a solver that isn't being used by another thread, locks it, and dispatches the
///  call to the solver.
///  So long as there are at least as many solvers as there are hardware threads, it should never need to
///  spin wait.
///
/// Generated from class `btConstraintSolverPoolMt`.
/// Base classes:
///   Direct: (non-virtual)
///     `btConstraintSolver`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btConstraintSolverPoolMt btConstraintSolverPoolMt;

///
/// btDiscreteDynamicsWorldMt -- a version of DiscreteDynamicsWorld with some minor changes to support
///                              solving simulation islands on multiple threads.
///
///  Should function exactly like btDiscreteDynamicsWorld.
///  Also 3 methods that iterate over all of the rigidbodies can run in parallel:
///     - predictUnconstraintMotion
///     - integrateTransforms
///     - createPredictiveContacts
///
/// Generated from class `btDiscreteDynamicsWorldMt`.
/// Base classes:
///   Direct: (non-virtual)
///     `btDiscreteDynamicsWorld`
///   Indirect: (non-virtual)
///     `btCollisionWorld`
///     `btDynamicsWorld`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btDiscreteDynamicsWorldMt btDiscreteDynamicsWorldMt;

/// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btConstraintSolverPoolMt_Destroy()` to free it when you're done using it.
BULLET_API btConstraintSolverPoolMt *btConstraintSolverPoolMt_ConstructFromAnother(Bullet_PassBy _other_pass_by, btConstraintSolverPoolMt *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btConstraintSolverPoolMt *btConstraintSolverPoolMt_OffsetPtr(const btConstraintSolverPoolMt *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btConstraintSolverPoolMt *btConstraintSolverPoolMt_OffsetMutablePtr(btConstraintSolverPoolMt *ptr, ptrdiff_t i);

/// Upcasts an instance of `btConstraintSolverPoolMt` to its base class `btConstraintSolver`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConstraintSolver *btConstraintSolverPoolMt_UpcastTo_btConstraintSolver(const btConstraintSolverPoolMt *object);

/// Upcasts an instance of `btConstraintSolverPoolMt` to its base class `btConstraintSolver`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConstraintSolver *btConstraintSolverPoolMt_MutableUpcastTo_btConstraintSolver(btConstraintSolverPoolMt *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btConstraintSolverPoolMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConstraintSolverPoolMt *btConstraintSolverPoolMt_StaticDowncastFrom_btConstraintSolver(const btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btConstraintSolverPoolMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConstraintSolverPoolMt *btConstraintSolverPoolMt_MutableStaticDowncastFrom_btConstraintSolver(btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btConstraintSolverPoolMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btConstraintSolverPoolMt *btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver(const btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btConstraintSolverPoolMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btConstraintSolverPoolMt *btConstraintSolverPoolMt_MutableDynamicDowncastFrom_btConstraintSolver(btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btConstraintSolverPoolMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btConstraintSolverPoolMt *btConstraintSolverPoolMt_DynamicDowncastFromOrFail_btConstraintSolver(const btConstraintSolver *object);

/// Downcasts an instance of `btConstraintSolver` to a derived class `btConstraintSolverPoolMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btConstraintSolverPoolMt *btConstraintSolverPoolMt_MutableDynamicDowncastFromOrFail_btConstraintSolver(btConstraintSolver *object);

// create the solvers for me
/// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
/// Never returns null. Returns an instance allocated on the heap! Must call `btConstraintSolverPoolMt_Destroy()` to free it when you're done using it.
BULLET_API btConstraintSolverPoolMt *btConstraintSolverPoolMt_Construct_1(int numSolvers);

// pass in fully constructed solvers (destructor will delete them)
/// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
/// Never returns null. Returns an instance allocated on the heap! Must call `btConstraintSolverPoolMt_Destroy()` to free it when you're done using it.
BULLET_API btConstraintSolverPoolMt *btConstraintSolverPoolMt_Construct_2(btConstraintSolver **solvers, int numSolvers);

/// Destroys a heap-allocated instance of `btConstraintSolverPoolMt`. Does nothing if the pointer is null.
BULLET_API void btConstraintSolverPoolMt_Destroy(const btConstraintSolverPoolMt *_this);

/// Destroys a heap-allocated array of `btConstraintSolverPoolMt`. Does nothing if the pointer is null.
BULLET_API void btConstraintSolverPoolMt_DestroyArray(const btConstraintSolverPoolMt *_this);

/// Generated from method `btConstraintSolverPoolMt::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btConstraintSolverPoolMt *btConstraintSolverPoolMt_AssignFromAnother(btConstraintSolverPoolMt *_this, Bullet_PassBy _other_pass_by, btConstraintSolverPoolMt *_other);

/// Generated from method `btConstraintSolverPoolMt::reset`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConstraintSolverPoolMt_reset(btConstraintSolverPoolMt *_this);

/// Generated from method `btConstraintSolverPoolMt::prepareSolve`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btConstraintSolverPoolMt_prepareSolve(btConstraintSolverPoolMt *_this, int _1, int _2);

/// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btDiscreteDynamicsWorldMt_Destroy()` to free it when you're done using it.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_ConstructFromAnother(Bullet_PassBy _other_pass_by, btDiscreteDynamicsWorldMt *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_OffsetPtr(const btDiscreteDynamicsWorldMt *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_OffsetMutablePtr(btDiscreteDynamicsWorldMt *ptr, ptrdiff_t i);

/// Upcasts an instance of `btDiscreteDynamicsWorldMt` to its base class `btCollisionWorld`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld *btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld(const btDiscreteDynamicsWorldMt *object);

/// Upcasts an instance of `btDiscreteDynamicsWorldMt` to its base class `btCollisionWorld`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld *btDiscreteDynamicsWorldMt_MutableUpcastTo_btCollisionWorld(btDiscreteDynamicsWorldMt *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_StaticDowncastFrom_btCollisionWorld(const btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableStaticDowncastFrom_btCollisionWorld(btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld(const btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFrom_btCollisionWorld(btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFromOrFail_btCollisionWorld(const btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFromOrFail_btCollisionWorld(btCollisionWorld *object);

/// Upcasts an instance of `btDiscreteDynamicsWorldMt` to its base class `btDynamicsWorld`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDynamicsWorld *btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld(const btDiscreteDynamicsWorldMt *object);

/// Upcasts an instance of `btDiscreteDynamicsWorldMt` to its base class `btDynamicsWorld`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDynamicsWorld *btDiscreteDynamicsWorldMt_MutableUpcastTo_btDynamicsWorld(btDiscreteDynamicsWorldMt *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_StaticDowncastFrom_btDynamicsWorld(const btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableStaticDowncastFrom_btDynamicsWorld(btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld(const btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFrom_btDynamicsWorld(btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFromOrFail_btDynamicsWorld(const btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFromOrFail_btDynamicsWorld(btDynamicsWorld *object);

/// Upcasts an instance of `btDiscreteDynamicsWorldMt` to its base class `btDiscreteDynamicsWorld`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorld *btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld(const btDiscreteDynamicsWorldMt *object);

/// Upcasts an instance of `btDiscreteDynamicsWorldMt` to its base class `btDiscreteDynamicsWorld`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorldMt_MutableUpcastTo_btDiscreteDynamicsWorld(btDiscreteDynamicsWorldMt *object);

/// Downcasts an instance of `btDiscreteDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_StaticDowncastFrom_btDiscreteDynamicsWorld(const btDiscreteDynamicsWorld *object);

/// Downcasts an instance of `btDiscreteDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableStaticDowncastFrom_btDiscreteDynamicsWorld(btDiscreteDynamicsWorld *object);

/// Downcasts an instance of `btDiscreteDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld(const btDiscreteDynamicsWorld *object);

/// Downcasts an instance of `btDiscreteDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFrom_btDiscreteDynamicsWorld(btDiscreteDynamicsWorld *object);

/// Downcasts an instance of `btDiscreteDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFromOrFail_btDiscreteDynamicsWorld(const btDiscreteDynamicsWorld *object);

/// Downcasts an instance of `btDiscreteDynamicsWorld` to a derived class `btDiscreteDynamicsWorldMt`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFromOrFail_btDiscreteDynamicsWorld(btDiscreteDynamicsWorld *object);

/// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
/// Never returns null. Returns an instance allocated on the heap! Must call `btDiscreteDynamicsWorldMt_Destroy()` to free it when you're done using it.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_Construct(btDispatcher *dispatcher, btBroadphaseInterface *pairCache, btConstraintSolverPoolMt *solverPool, btConstraintSolver *constraintSolverMt, btCollisionConfiguration *collisionConfiguration);

/// Destroys a heap-allocated instance of `btDiscreteDynamicsWorldMt`. Does nothing if the pointer is null.
BULLET_API void btDiscreteDynamicsWorldMt_Destroy(const btDiscreteDynamicsWorldMt *_this);

/// Destroys a heap-allocated array of `btDiscreteDynamicsWorldMt`. Does nothing if the pointer is null.
BULLET_API void btDiscreteDynamicsWorldMt_DestroyArray(const btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_AssignFromAnother(btDiscreteDynamicsWorldMt *_this, Bullet_PassBy _other_pass_by, btDiscreteDynamicsWorldMt *_other);

/// Generated from method `btDiscreteDynamicsWorldMt::operator new`.
BULLET_API void *Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btDiscreteDynamicsWorldMt::operator delete`.
BULLET_API void Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr(void *ptr);

/// Generated from method `btDiscreteDynamicsWorldMt::operator new`.
BULLET_API void *Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btDiscreteDynamicsWorldMt::operator delete`.
BULLET_API void Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btDiscreteDynamicsWorldMt::operator new[]`.
BULLET_API void *Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btDiscreteDynamicsWorldMt::operator delete[]`.
BULLET_API void Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr(void *ptr);

/// Generated from method `btDiscreteDynamicsWorldMt::operator new[]`.
BULLET_API void *Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btDiscreteDynamicsWorldMt::operator delete[]`.
BULLET_API void Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btDiscreteDynamicsWorldMt::stepSimulation`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btDiscreteDynamicsWorldMt_stepSimulation(btDiscreteDynamicsWorldMt *_this, double timeStep, int maxSubSteps, double fixedTimeStep);

/// Generated from method `btDiscreteDynamicsWorldMt::synchronizeMotionStates`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_synchronizeMotionStates(btDiscreteDynamicsWorldMt *_this);

///this can be useful to synchronize a single rigid body -> graphics object
/// Generated from method `btDiscreteDynamicsWorldMt::synchronizeSingleMotionState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_synchronizeSingleMotionState(btDiscreteDynamicsWorldMt *_this, btRigidBody *body);

/// Generated from method `btDiscreteDynamicsWorldMt::getCollisionWorld`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btCollisionWorld *btDiscreteDynamicsWorldMt_getCollisionWorld(btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::setGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `gravity` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_setGravity(btDiscreteDynamicsWorldMt *_this, const btVector3 *gravity);

/// Generated from method `btDiscreteDynamicsWorldMt::getGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btDiscreteDynamicsWorldMt_getGravity(const btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::addCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `collisionFilterGroup` has a default argument: `btBroadphaseProxy::StaticFilter`, pass a null pointer to use it.
/// Parameter `collisionFilterMask` has a default argument: `btBroadphaseProxy::AllFilter^btBroadphaseProxy::StaticFilter`, pass a null pointer to use it.
BULLET_API void btDiscreteDynamicsWorldMt_addCollisionObject(btDiscreteDynamicsWorldMt *_this, btCollisionObject *collisionObject, const int *collisionFilterGroup, const int *collisionFilterMask);

/// Generated from method `btDiscreteDynamicsWorldMt::removeRigidBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_removeRigidBody(btDiscreteDynamicsWorldMt *_this, btRigidBody *body);

///removeCollisionObject will first check if it is a rigid body, if so call removeRigidBody otherwise call btCollisionWorld::removeCollisionObject
/// Generated from method `btDiscreteDynamicsWorldMt::removeCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_removeCollisionObject(btDiscreteDynamicsWorldMt *_this, btCollisionObject *collisionObject);

/// Generated from method `btDiscreteDynamicsWorldMt::debugDrawWorld`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_debugDrawWorld(btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::setConstraintSolver`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_setConstraintSolver(btDiscreteDynamicsWorldMt *_this, btConstraintSolver *solver);

/// Generated from method `btDiscreteDynamicsWorldMt::getConstraintSolver`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btConstraintSolver *btDiscreteDynamicsWorldMt_getConstraintSolver(btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::getNumConstraints`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btDiscreteDynamicsWorldMt_getNumConstraints(const btDiscreteDynamicsWorldMt *_this);

///the forces on each rigidbody is accumulating together with gravity. clear this after each timestep.
/// Generated from method `btDiscreteDynamicsWorldMt::clearForces`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_clearForces(btDiscreteDynamicsWorldMt *_this);

///apply gravity, call this once per timestep
/// Generated from method `btDiscreteDynamicsWorldMt::applyGravity`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_applyGravity(btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::setNumTasks`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_setNumTasks(btDiscreteDynamicsWorldMt *_this, int numTasks);

///obsolete, use updateActions instead
/// Generated from method `btDiscreteDynamicsWorldMt::updateVehicles`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_updateVehicles(btDiscreteDynamicsWorldMt *_this, double timeStep);

/// Generated from method `btDiscreteDynamicsWorldMt::setSynchronizeAllMotionStates`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_setSynchronizeAllMotionStates(btDiscreteDynamicsWorldMt *_this, bool synchronizeAll);

/// Generated from method `btDiscreteDynamicsWorldMt::getSynchronizeAllMotionStates`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDiscreteDynamicsWorldMt_getSynchronizeAllMotionStates(const btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::setApplySpeculativeContactRestitution`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_setApplySpeculativeContactRestitution(btDiscreteDynamicsWorldMt *_this, bool enable);

/// Generated from method `btDiscreteDynamicsWorldMt::getApplySpeculativeContactRestitution`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDiscreteDynamicsWorldMt_getApplySpeculativeContactRestitution(const btDiscreteDynamicsWorldMt *_this);

///Interpolate motion state between previous and current transform, instead of current and next transform.
///This can relieve discontinuities in the rendering, due to penetrations
/// Generated from method `btDiscreteDynamicsWorldMt::setLatencyMotionStateInterpolation`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_setLatencyMotionStateInterpolation(btDiscreteDynamicsWorldMt *_this, bool latencyInterpolation);

/// Generated from method `btDiscreteDynamicsWorldMt::getLatencyMotionStateInterpolation`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDiscreteDynamicsWorldMt_getLatencyMotionStateInterpolation(const btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::setWorldUserInfo`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_setWorldUserInfo(btDiscreteDynamicsWorldMt *_this, void *worldUserInfo);

/// Generated from method `btDiscreteDynamicsWorldMt::getWorldUserInfo`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btDiscreteDynamicsWorldMt_getWorldUserInfo(const btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::setBroadphase`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_setBroadphase(btDiscreteDynamicsWorldMt *_this, btBroadphaseInterface *pairCache);

/// Generated from method `btDiscreteDynamicsWorldMt::getPairCache`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btOverlappingPairCache *btDiscreteDynamicsWorldMt_getPairCache(btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::updateSingleAabb`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_updateSingleAabb(btDiscreteDynamicsWorldMt *_this, btCollisionObject *colObj);

/// Generated from method `btDiscreteDynamicsWorldMt::updateAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_updateAabbs(btDiscreteDynamicsWorldMt *_this);

///the computeOverlappingPairs is usually already called by performDiscreteCollisionDetection (or stepSimulation)
///it can be useful to use if you perform ray tests without collision detection/simulation
/// Generated from method `btDiscreteDynamicsWorldMt::computeOverlappingPairs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_computeOverlappingPairs(btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::debugDrawObject`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `worldTransform` can not be null. It is a single object.
/// Parameter `color` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_debugDrawObject(btDiscreteDynamicsWorldMt *_this, const btTransform *worldTransform, const btCollisionShape *shape, const btVector3 *color);

/// Generated from method `btDiscreteDynamicsWorldMt::getNumCollisionObjects`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btDiscreteDynamicsWorldMt_getNumCollisionObjects(const btDiscreteDynamicsWorldMt *_this);

/// rayTest performs a raycast on all objects in the btCollisionWorld, and calls the resultCallback
/// This allows for several queries: first hit, all hits, any hit, dependent on the value returned by the callback.
/// Generated from method `btDiscreteDynamicsWorldMt::rayTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rayFromWorld` can not be null. It is a single object.
/// Parameter `rayToWorld` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_rayTest(const btDiscreteDynamicsWorldMt *_this, const btVector3 *rayFromWorld, const btVector3 *rayToWorld, btCollisionWorld_RayResultCallback *resultCallback);

/// convexTest performs a swept convex cast on all objects in the btCollisionWorld, and calls the resultCallback
/// This allows for several queries: first hit, all hits, any hit, dependent on the value return by the callback.
/// Generated from method `btDiscreteDynamicsWorldMt::convexSweepTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `from` can not be null. It is a single object.
/// Parameter `to` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
/// Parameter `allowedCcdPenetration` has a default argument: `btScalar(0.0)`, pass a null pointer to use it.
BULLET_API void btDiscreteDynamicsWorldMt_convexSweepTest(const btDiscreteDynamicsWorldMt *_this, const btConvexShape *castShape, const btTransform *from, const btTransform *to, btCollisionWorld_ConvexResultCallback *resultCallback, const double *allowedCcdPenetration);

///contactTest performs a discrete collision test between colObj against all objects in the btCollisionWorld, and calls the resultCallback.
///it reports one or more contact points for every overlapping object (including the one with deepest penetration)
/// Generated from method `btDiscreteDynamicsWorldMt::contactTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_contactTest(btDiscreteDynamicsWorldMt *_this, btCollisionObject *colObj, btCollisionWorld_ContactResultCallback *resultCallback);

///contactTest performs a discrete collision test between two collision objects and calls the resultCallback if overlap if detected.
///it reports one or more contact points (including the one with deepest penetration)
/// Generated from method `btDiscreteDynamicsWorldMt::contactPairTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_contactPairTest(btDiscreteDynamicsWorldMt *_this, btCollisionObject *colObjA, btCollisionObject *colObjB, btCollisionWorld_ContactResultCallback *resultCallback);

/// rayTestSingle performs a raycast call and calls the resultCallback. It is used internally by rayTest.
/// In a future implementation, we consider moving the ray test as a virtual method in btCollisionShape.
/// This allows more customization.
/// Generated from method `btDiscreteDynamicsWorldMt::rayTestSingle`.
/// Parameter `rayFromTrans` can not be null. It is a single object.
/// Parameter `rayToTrans` can not be null. It is a single object.
/// Parameter `colObjWorldTransform` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_rayTestSingle(const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_RayResultCallback *resultCallback);

/// objectQuerySingle performs a collision detection query and calls the resultCallback. It is used internally by rayTest.
/// Generated from method `btDiscreteDynamicsWorldMt::objectQuerySingle`.
/// Parameter `rayFromTrans` can not be null. It is a single object.
/// Parameter `rayToTrans` can not be null. It is a single object.
/// Parameter `colObjWorldTransform` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_objectQuerySingle(const btConvexShape *castShape, const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_ConvexResultCallback *resultCallback, double allowedPenetration);

/// Generated from method `btDiscreteDynamicsWorldMt::refreshBroadphaseProxy`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_refreshBroadphaseProxy(btDiscreteDynamicsWorldMt *_this, btCollisionObject *collisionObject);

/// Generated from method `btDiscreteDynamicsWorldMt::performDiscreteCollisionDetection`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_performDiscreteCollisionDetection(btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::getForceUpdateAllAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDiscreteDynamicsWorldMt_getForceUpdateAllAabbs(const btDiscreteDynamicsWorldMt *_this);

/// Generated from method `btDiscreteDynamicsWorldMt::setForceUpdateAllAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorldMt_setForceUpdateAllAabbs(btDiscreteDynamicsWorldMt *_this, bool forceUpdateAllAabbs);

#ifdef __cplusplus
} // extern "C"
#endif
