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
typedef struct btDispatcher btDispatcher; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btDispatcher.h>`.
typedef struct btDynamicsWorld btDynamicsWorld; // Defined in `#include <bullet/BulletDynamics/Dynamics/btDynamicsWorld.h>`.
typedef struct btOverlappingPairCache btOverlappingPairCache; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>`.
typedef struct btRigidBody btRigidBody; // Defined in `#include <bullet/BulletDynamics/Dynamics/btRigidBody.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///btDiscreteDynamicsWorld provides discrete rigid body simulation
///those classes replace the obsolete CcdPhysicsEnvironment/CcdPhysicsController
/// Generated from class `btDiscreteDynamicsWorld`.
/// Base classes:
///   Direct: (non-virtual)
///     `btDynamicsWorld`
///   Indirect: (non-virtual)
///     `btCollisionWorld`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btDiscreteDynamicsWorld btDiscreteDynamicsWorld;

/// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btDiscreteDynamicsWorld_Destroy()` to free it when you're done using it.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_ConstructFromAnother(Bullet_PassBy _other_pass_by, btDiscreteDynamicsWorld *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_OffsetPtr(const btDiscreteDynamicsWorld *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_OffsetMutablePtr(btDiscreteDynamicsWorld *ptr, ptrdiff_t i);

/// Upcasts an instance of `btDiscreteDynamicsWorld` to its base class `btCollisionWorld`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld *btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld(const btDiscreteDynamicsWorld *object);

/// Upcasts an instance of `btDiscreteDynamicsWorld` to its base class `btCollisionWorld`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld *btDiscreteDynamicsWorld_MutableUpcastTo_btCollisionWorld(btDiscreteDynamicsWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_StaticDowncastFrom_btCollisionWorld(const btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableStaticDowncastFrom_btCollisionWorld(btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(const btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableDynamicDowncastFrom_btCollisionWorld(btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_DynamicDowncastFromOrFail_btCollisionWorld(const btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableDynamicDowncastFromOrFail_btCollisionWorld(btCollisionWorld *object);

/// Upcasts an instance of `btDiscreteDynamicsWorld` to its base class `btDynamicsWorld`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDynamicsWorld *btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld(const btDiscreteDynamicsWorld *object);

/// Upcasts an instance of `btDiscreteDynamicsWorld` to its base class `btDynamicsWorld`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDynamicsWorld *btDiscreteDynamicsWorld_MutableUpcastTo_btDynamicsWorld(btDiscreteDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_StaticDowncastFrom_btDynamicsWorld(const btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableStaticDowncastFrom_btDynamicsWorld(btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld(const btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableDynamicDowncastFrom_btDynamicsWorld(btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_DynamicDowncastFromOrFail_btDynamicsWorld(const btDynamicsWorld *object);

/// Downcasts an instance of `btDynamicsWorld` to a derived class `btDiscreteDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableDynamicDowncastFromOrFail_btDynamicsWorld(btDynamicsWorld *object);

///this btDiscreteDynamicsWorld constructor gets created objects from the user, and will not delete those
/// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
/// Never returns null. Returns an instance allocated on the heap! Must call `btDiscreteDynamicsWorld_Destroy()` to free it when you're done using it.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_Construct(btDispatcher *dispatcher, btBroadphaseInterface *pairCache, btConstraintSolver *constraintSolver, btCollisionConfiguration *collisionConfiguration);

/// Destroys a heap-allocated instance of `btDiscreteDynamicsWorld`. Does nothing if the pointer is null.
BULLET_API void btDiscreteDynamicsWorld_Destroy(const btDiscreteDynamicsWorld *_this);

/// Destroys a heap-allocated array of `btDiscreteDynamicsWorld`. Does nothing if the pointer is null.
BULLET_API void btDiscreteDynamicsWorld_DestroyArray(const btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_AssignFromAnother(btDiscreteDynamicsWorld *_this, Bullet_PassBy _other_pass_by, btDiscreteDynamicsWorld *_other);

/// Generated from method `btDiscreteDynamicsWorld::operator new`.
BULLET_API void *Bullet_new_btDiscreteDynamicsWorld_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btDiscreteDynamicsWorld::operator delete`.
BULLET_API void Bullet_delete_btDiscreteDynamicsWorld_void_ptr(void *ptr);

/// Generated from method `btDiscreteDynamicsWorld::operator new`.
BULLET_API void *Bullet_new_btDiscreteDynamicsWorld_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btDiscreteDynamicsWorld::operator delete`.
BULLET_API void Bullet_delete_btDiscreteDynamicsWorld_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btDiscreteDynamicsWorld::operator new[]`.
BULLET_API void *Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btDiscreteDynamicsWorld::operator delete[]`.
BULLET_API void Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr(void *ptr);

/// Generated from method `btDiscreteDynamicsWorld::operator new[]`.
BULLET_API void *Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btDiscreteDynamicsWorld::operator delete[]`.
BULLET_API void Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr_void_ptr(void *_1, void *_2);

///if maxSubSteps > 0, it will interpolate motion between fixedTimeStep's
/// Generated from method `btDiscreteDynamicsWorld::stepSimulation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `maxSubSteps` has a default argument: `1`, pass a null pointer to use it.
/// Parameter `fixedTimeStep` has a default argument: `btScalar(1.0)/btScalar(60.0)`, pass a null pointer to use it.
BULLET_API int btDiscreteDynamicsWorld_stepSimulation(btDiscreteDynamicsWorld *_this, double timeStep, const int *maxSubSteps, const double *fixedTimeStep);

/// Generated from method `btDiscreteDynamicsWorld::synchronizeMotionStates`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_synchronizeMotionStates(btDiscreteDynamicsWorld *_this);

///this can be useful to synchronize a single rigid body -> graphics object
/// Generated from method `btDiscreteDynamicsWorld::synchronizeSingleMotionState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_synchronizeSingleMotionState(btDiscreteDynamicsWorld *_this, btRigidBody *body);

/// Generated from method `btDiscreteDynamicsWorld::getCollisionWorld`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btCollisionWorld *btDiscreteDynamicsWorld_getCollisionWorld(btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::setGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `gravity` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_setGravity(btDiscreteDynamicsWorld *_this, const btVector3 *gravity);

/// Generated from method `btDiscreteDynamicsWorld::getGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btDiscreteDynamicsWorld_getGravity(const btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::addCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `collisionFilterGroup` has a default argument: `btBroadphaseProxy::StaticFilter`, pass a null pointer to use it.
/// Parameter `collisionFilterMask` has a default argument: `btBroadphaseProxy::AllFilter^btBroadphaseProxy::StaticFilter`, pass a null pointer to use it.
BULLET_API void btDiscreteDynamicsWorld_addCollisionObject(btDiscreteDynamicsWorld *_this, btCollisionObject *collisionObject, const int *collisionFilterGroup, const int *collisionFilterMask);

/// Generated from method `btDiscreteDynamicsWorld::addRigidBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_addRigidBody_1(btDiscreteDynamicsWorld *_this, btRigidBody *body);

/// Generated from method `btDiscreteDynamicsWorld::addRigidBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_addRigidBody_3(btDiscreteDynamicsWorld *_this, btRigidBody *body, int group, int mask);

/// Generated from method `btDiscreteDynamicsWorld::removeRigidBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_removeRigidBody(btDiscreteDynamicsWorld *_this, btRigidBody *body);

///removeCollisionObject will first check if it is a rigid body, if so call removeRigidBody otherwise call btCollisionWorld::removeCollisionObject
/// Generated from method `btDiscreteDynamicsWorld::removeCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_removeCollisionObject(btDiscreteDynamicsWorld *_this, btCollisionObject *collisionObject);

/// Generated from method `btDiscreteDynamicsWorld::debugDrawWorld`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_debugDrawWorld(btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::setConstraintSolver`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_setConstraintSolver(btDiscreteDynamicsWorld *_this, btConstraintSolver *solver);

/// Generated from method `btDiscreteDynamicsWorld::getConstraintSolver`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btConstraintSolver *btDiscreteDynamicsWorld_getConstraintSolver(btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::getNumConstraints`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btDiscreteDynamicsWorld_getNumConstraints(const btDiscreteDynamicsWorld *_this);

///the forces on each rigidbody is accumulating together with gravity. clear this after each timestep.
/// Generated from method `btDiscreteDynamicsWorld::clearForces`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_clearForces(btDiscreteDynamicsWorld *_this);

///apply gravity, call this once per timestep
/// Generated from method `btDiscreteDynamicsWorld::applyGravity`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_applyGravity(btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::setNumTasks`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_setNumTasks(btDiscreteDynamicsWorld *_this, int numTasks);

///obsolete, use updateActions instead
/// Generated from method `btDiscreteDynamicsWorld::updateVehicles`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_updateVehicles(btDiscreteDynamicsWorld *_this, double timeStep);

/// Generated from method `btDiscreteDynamicsWorld::setSynchronizeAllMotionStates`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_setSynchronizeAllMotionStates(btDiscreteDynamicsWorld *_this, bool synchronizeAll);

/// Generated from method `btDiscreteDynamicsWorld::getSynchronizeAllMotionStates`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDiscreteDynamicsWorld_getSynchronizeAllMotionStates(const btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::setApplySpeculativeContactRestitution`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_setApplySpeculativeContactRestitution(btDiscreteDynamicsWorld *_this, bool enable);

/// Generated from method `btDiscreteDynamicsWorld::getApplySpeculativeContactRestitution`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDiscreteDynamicsWorld_getApplySpeculativeContactRestitution(const btDiscreteDynamicsWorld *_this);

///Interpolate motion state between previous and current transform, instead of current and next transform.
///This can relieve discontinuities in the rendering, due to penetrations
/// Generated from method `btDiscreteDynamicsWorld::setLatencyMotionStateInterpolation`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_setLatencyMotionStateInterpolation(btDiscreteDynamicsWorld *_this, bool latencyInterpolation);

/// Generated from method `btDiscreteDynamicsWorld::getLatencyMotionStateInterpolation`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDiscreteDynamicsWorld_getLatencyMotionStateInterpolation(const btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::setWorldUserInfo`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_setWorldUserInfo(btDiscreteDynamicsWorld *_this, void *worldUserInfo);

/// Generated from method `btDiscreteDynamicsWorld::getWorldUserInfo`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btDiscreteDynamicsWorld_getWorldUserInfo(const btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::setBroadphase`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_setBroadphase(btDiscreteDynamicsWorld *_this, btBroadphaseInterface *pairCache);

/// Generated from method `btDiscreteDynamicsWorld::getPairCache`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btOverlappingPairCache *btDiscreteDynamicsWorld_getPairCache(btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::updateSingleAabb`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_updateSingleAabb(btDiscreteDynamicsWorld *_this, btCollisionObject *colObj);

/// Generated from method `btDiscreteDynamicsWorld::updateAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_updateAabbs(btDiscreteDynamicsWorld *_this);

///the computeOverlappingPairs is usually already called by performDiscreteCollisionDetection (or stepSimulation)
///it can be useful to use if you perform ray tests without collision detection/simulation
/// Generated from method `btDiscreteDynamicsWorld::computeOverlappingPairs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_computeOverlappingPairs(btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::debugDrawObject`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `worldTransform` can not be null. It is a single object.
/// Parameter `color` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_debugDrawObject(btDiscreteDynamicsWorld *_this, const btTransform *worldTransform, const btCollisionShape *shape, const btVector3 *color);

/// Generated from method `btDiscreteDynamicsWorld::getNumCollisionObjects`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btDiscreteDynamicsWorld_getNumCollisionObjects(const btDiscreteDynamicsWorld *_this);

/// rayTest performs a raycast on all objects in the btCollisionWorld, and calls the resultCallback
/// This allows for several queries: first hit, all hits, any hit, dependent on the value returned by the callback.
/// Generated from method `btDiscreteDynamicsWorld::rayTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rayFromWorld` can not be null. It is a single object.
/// Parameter `rayToWorld` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_rayTest(const btDiscreteDynamicsWorld *_this, const btVector3 *rayFromWorld, const btVector3 *rayToWorld, btCollisionWorld_RayResultCallback *resultCallback);

/// convexTest performs a swept convex cast on all objects in the btCollisionWorld, and calls the resultCallback
/// This allows for several queries: first hit, all hits, any hit, dependent on the value return by the callback.
/// Generated from method `btDiscreteDynamicsWorld::convexSweepTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `from` can not be null. It is a single object.
/// Parameter `to` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
/// Parameter `allowedCcdPenetration` has a default argument: `btScalar(0.0)`, pass a null pointer to use it.
BULLET_API void btDiscreteDynamicsWorld_convexSweepTest(const btDiscreteDynamicsWorld *_this, const btConvexShape *castShape, const btTransform *from, const btTransform *to, btCollisionWorld_ConvexResultCallback *resultCallback, const double *allowedCcdPenetration);

///contactTest performs a discrete collision test between colObj against all objects in the btCollisionWorld, and calls the resultCallback.
///it reports one or more contact points for every overlapping object (including the one with deepest penetration)
/// Generated from method `btDiscreteDynamicsWorld::contactTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_contactTest(btDiscreteDynamicsWorld *_this, btCollisionObject *colObj, btCollisionWorld_ContactResultCallback *resultCallback);

///contactTest performs a discrete collision test between two collision objects and calls the resultCallback if overlap if detected.
///it reports one or more contact points (including the one with deepest penetration)
/// Generated from method `btDiscreteDynamicsWorld::contactPairTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_contactPairTest(btDiscreteDynamicsWorld *_this, btCollisionObject *colObjA, btCollisionObject *colObjB, btCollisionWorld_ContactResultCallback *resultCallback);

/// rayTestSingle performs a raycast call and calls the resultCallback. It is used internally by rayTest.
/// In a future implementation, we consider moving the ray test as a virtual method in btCollisionShape.
/// This allows more customization.
/// Generated from method `btDiscreteDynamicsWorld::rayTestSingle`.
/// Parameter `rayFromTrans` can not be null. It is a single object.
/// Parameter `rayToTrans` can not be null. It is a single object.
/// Parameter `colObjWorldTransform` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_rayTestSingle(const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_RayResultCallback *resultCallback);

/// objectQuerySingle performs a collision detection query and calls the resultCallback. It is used internally by rayTest.
/// Generated from method `btDiscreteDynamicsWorld::objectQuerySingle`.
/// Parameter `rayFromTrans` can not be null. It is a single object.
/// Parameter `rayToTrans` can not be null. It is a single object.
/// Parameter `colObjWorldTransform` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_objectQuerySingle(const btConvexShape *castShape, const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_ConvexResultCallback *resultCallback, double allowedPenetration);

/// Generated from method `btDiscreteDynamicsWorld::refreshBroadphaseProxy`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_refreshBroadphaseProxy(btDiscreteDynamicsWorld *_this, btCollisionObject *collisionObject);

/// Generated from method `btDiscreteDynamicsWorld::performDiscreteCollisionDetection`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_performDiscreteCollisionDetection(btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::getForceUpdateAllAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDiscreteDynamicsWorld_getForceUpdateAllAabbs(const btDiscreteDynamicsWorld *_this);

/// Generated from method `btDiscreteDynamicsWorld::setForceUpdateAllAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDiscreteDynamicsWorld_setForceUpdateAllAabbs(btDiscreteDynamicsWorld *_this, bool forceUpdateAllAabbs);

#ifdef __cplusplus
} // extern "C"
#endif
