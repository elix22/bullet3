// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btBroadphaseInterface btBroadphaseInterface; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btBroadphaseInterface.h>`.
typedef struct btCollisionObject btCollisionObject; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionObject.h>`.
typedef struct btCollisionShape btCollisionShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btCollisionShape.h>`.
typedef struct btCollisionWorld btCollisionWorld; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionWorld.h>`.
typedef struct btCollisionWorld_ContactResultCallback btCollisionWorld_ContactResultCallback; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionWorld.h>`.
typedef struct btCollisionWorld_ConvexResultCallback btCollisionWorld_ConvexResultCallback; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionWorld.h>`.
typedef struct btCollisionWorld_RayResultCallback btCollisionWorld_RayResultCallback; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionWorld.h>`.
typedef struct btConstraintSolver btConstraintSolver; // Defined in `#include <bullet/BulletDynamics/ConstraintSolver/btConstraintSolver.h>`.
typedef struct btConvexShape btConvexShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btConvexShape.h>`.
typedef struct btOverlappingPairCache btOverlappingPairCache; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>`.
typedef struct btRigidBody btRigidBody; // Defined in `#include <bullet/BulletDynamics/Dynamics/btRigidBody.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///The btDynamicsWorld is the interface class for several dynamics implementation, basic, discrete, parallel, and continuous etc.
/// Generated from class `btDynamicsWorld`.
/// Base classes:
///   Direct: (non-virtual)
///     `btCollisionWorld`
/// Derived classes:
///   Direct: (non-virtual)
///     `btDiscreteDynamicsWorld`
typedef struct btDynamicsWorld btDynamicsWorld;

/// Destroys a heap-allocated instance of `btDynamicsWorld`. Does nothing if the pointer is null.
BULLET_API void btDynamicsWorld_Destroy(const btDynamicsWorld *_this);

/// Destroys a heap-allocated array of `btDynamicsWorld`. Does nothing if the pointer is null.
BULLET_API void btDynamicsWorld_DestroyArray(const btDynamicsWorld *_this);

///stepSimulation proceeds the simulation over 'timeStep', units in preferably in seconds.
///By default, Bullet will subdivide the timestep in constant substeps of each 'fixedTimeStep'.
///in order to keep the simulation real-time, the maximum number of substeps can be clamped to 'maxSubSteps'.
///You can disable subdividing the timestep/substepping by passing maxSubSteps=0 as second argument to stepSimulation, but in that case you have to keep the timeStep constant.
/// Generated from method `btDynamicsWorld::stepSimulation`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `maxSubSteps` has a default argument: `1`, pass a null pointer to use it.
/// Parameter `fixedTimeStep` has a default argument: `btScalar(1.0)/btScalar(60.0)`, pass a null pointer to use it.
BULLET_API int btDynamicsWorld_stepSimulation(btDynamicsWorld *_this, double timeStep, const int *maxSubSteps, const double *fixedTimeStep);

/// Generated from method `btDynamicsWorld::debugDrawWorld`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_debugDrawWorld(btDynamicsWorld *_this);

//once a rigidbody is added to the dynamics world, it will get this gravity assigned
//existing rigidbodies in the world get gravity assigned too, during this method
/// Generated from method `btDynamicsWorld::setGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `gravity` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_setGravity(btDynamicsWorld *_this, const btVector3 *gravity);

/// Generated from method `btDynamicsWorld::getGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btDynamicsWorld_getGravity(const btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::synchronizeMotionStates`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_synchronizeMotionStates(btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::addRigidBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_addRigidBody_1(btDynamicsWorld *_this, btRigidBody *body);

/// Generated from method `btDynamicsWorld::addRigidBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_addRigidBody_3(btDynamicsWorld *_this, btRigidBody *body, int group, int mask);

/// Generated from method `btDynamicsWorld::removeRigidBody`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_removeRigidBody(btDynamicsWorld *_this, btRigidBody *body);

/// Generated from method `btDynamicsWorld::setConstraintSolver`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_setConstraintSolver(btDynamicsWorld *_this, btConstraintSolver *solver);

/// Generated from method `btDynamicsWorld::getConstraintSolver`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btConstraintSolver *btDynamicsWorld_getConstraintSolver(btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::getNumConstraints`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btDynamicsWorld_getNumConstraints(const btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::clearForces`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_clearForces(btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::setWorldUserInfo`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_setWorldUserInfo(btDynamicsWorld *_this, void *worldUserInfo);

/// Generated from method `btDynamicsWorld::getWorldUserInfo`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btDynamicsWorld_getWorldUserInfo(const btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::setBroadphase`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_setBroadphase(btDynamicsWorld *_this, btBroadphaseInterface *pairCache);

/// Generated from method `btDynamicsWorld::getPairCache`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btOverlappingPairCache *btDynamicsWorld_getPairCache(btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::updateSingleAabb`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_updateSingleAabb(btDynamicsWorld *_this, btCollisionObject *colObj);

/// Generated from method `btDynamicsWorld::updateAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_updateAabbs(btDynamicsWorld *_this);

///the computeOverlappingPairs is usually already called by performDiscreteCollisionDetection (or stepSimulation)
///it can be useful to use if you perform ray tests without collision detection/simulation
/// Generated from method `btDynamicsWorld::computeOverlappingPairs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_computeOverlappingPairs(btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::debugDrawObject`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `worldTransform` can not be null. It is a single object.
/// Parameter `color` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_debugDrawObject(btDynamicsWorld *_this, const btTransform *worldTransform, const btCollisionShape *shape, const btVector3 *color);

/// Generated from method `btDynamicsWorld::getNumCollisionObjects`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btDynamicsWorld_getNumCollisionObjects(const btDynamicsWorld *_this);

/// rayTest performs a raycast on all objects in the btCollisionWorld, and calls the resultCallback
/// This allows for several queries: first hit, all hits, any hit, dependent on the value returned by the callback.
/// Generated from method `btDynamicsWorld::rayTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rayFromWorld` can not be null. It is a single object.
/// Parameter `rayToWorld` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_rayTest(const btDynamicsWorld *_this, const btVector3 *rayFromWorld, const btVector3 *rayToWorld, btCollisionWorld_RayResultCallback *resultCallback);

/// convexTest performs a swept convex cast on all objects in the btCollisionWorld, and calls the resultCallback
/// This allows for several queries: first hit, all hits, any hit, dependent on the value return by the callback.
/// Generated from method `btDynamicsWorld::convexSweepTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `from` can not be null. It is a single object.
/// Parameter `to` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
/// Parameter `allowedCcdPenetration` has a default argument: `btScalar(0.0)`, pass a null pointer to use it.
BULLET_API void btDynamicsWorld_convexSweepTest(const btDynamicsWorld *_this, const btConvexShape *castShape, const btTransform *from, const btTransform *to, btCollisionWorld_ConvexResultCallback *resultCallback, const double *allowedCcdPenetration);

///contactTest performs a discrete collision test between colObj against all objects in the btCollisionWorld, and calls the resultCallback.
///it reports one or more contact points for every overlapping object (including the one with deepest penetration)
/// Generated from method `btDynamicsWorld::contactTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_contactTest(btDynamicsWorld *_this, btCollisionObject *colObj, btCollisionWorld_ContactResultCallback *resultCallback);

///contactTest performs a discrete collision test between two collision objects and calls the resultCallback if overlap if detected.
///it reports one or more contact points (including the one with deepest penetration)
/// Generated from method `btDynamicsWorld::contactPairTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_contactPairTest(btDynamicsWorld *_this, btCollisionObject *colObjA, btCollisionObject *colObjB, btCollisionWorld_ContactResultCallback *resultCallback);

/// rayTestSingle performs a raycast call and calls the resultCallback. It is used internally by rayTest.
/// In a future implementation, we consider moving the ray test as a virtual method in btCollisionShape.
/// This allows more customization.
/// Generated from method `btDynamicsWorld::rayTestSingle`.
/// Parameter `rayFromTrans` can not be null. It is a single object.
/// Parameter `rayToTrans` can not be null. It is a single object.
/// Parameter `colObjWorldTransform` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_rayTestSingle(const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_RayResultCallback *resultCallback);

/// objectQuerySingle performs a collision detection query and calls the resultCallback. It is used internally by rayTest.
/// Generated from method `btDynamicsWorld::objectQuerySingle`.
/// Parameter `rayFromTrans` can not be null. It is a single object.
/// Parameter `rayToTrans` can not be null. It is a single object.
/// Parameter `colObjWorldTransform` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_objectQuerySingle(const btConvexShape *castShape, const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_ConvexResultCallback *resultCallback, double allowedPenetration);

/// Generated from method `btDynamicsWorld::addCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `collisionFilterGroup` has a default argument: `btBroadphaseProxy::DefaultFilter`, pass a null pointer to use it.
/// Parameter `collisionFilterMask` has a default argument: `btBroadphaseProxy::AllFilter`, pass a null pointer to use it.
BULLET_API void btDynamicsWorld_addCollisionObject(btDynamicsWorld *_this, btCollisionObject *collisionObject, const int *collisionFilterGroup, const int *collisionFilterMask);

/// Generated from method `btDynamicsWorld::refreshBroadphaseProxy`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_refreshBroadphaseProxy(btDynamicsWorld *_this, btCollisionObject *collisionObject);

/// Generated from method `btDynamicsWorld::removeCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_removeCollisionObject(btDynamicsWorld *_this, btCollisionObject *collisionObject);

/// Generated from method `btDynamicsWorld::performDiscreteCollisionDetection`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_performDiscreteCollisionDetection(btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::getForceUpdateAllAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btDynamicsWorld_getForceUpdateAllAabbs(const btDynamicsWorld *_this);

/// Generated from method `btDynamicsWorld::setForceUpdateAllAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDynamicsWorld_setForceUpdateAllAabbs(btDynamicsWorld *_this, bool forceUpdateAllAabbs);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btDynamicsWorld *btDynamicsWorld_OffsetPtr(const btDynamicsWorld *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btDynamicsWorld *btDynamicsWorld_OffsetMutablePtr(btDynamicsWorld *ptr, ptrdiff_t i);

/// Upcasts an instance of `btDynamicsWorld` to its base class `btCollisionWorld`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld *btDynamicsWorld_UpcastTo_btCollisionWorld(const btDynamicsWorld *object);

/// Upcasts an instance of `btDynamicsWorld` to its base class `btCollisionWorld`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld *btDynamicsWorld_MutableUpcastTo_btCollisionWorld(btDynamicsWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDynamicsWorld`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDynamicsWorld *btDynamicsWorld_StaticDowncastFrom_btCollisionWorld(const btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDynamicsWorld`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDynamicsWorld *btDynamicsWorld_MutableStaticDowncastFrom_btCollisionWorld(btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDynamicsWorld *btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(const btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDynamicsWorld *btDynamicsWorld_MutableDynamicDowncastFrom_btCollisionWorld(btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btDynamicsWorld *btDynamicsWorld_DynamicDowncastFromOrFail_btCollisionWorld(const btCollisionWorld *object);

/// Downcasts an instance of `btCollisionWorld` to a derived class `btDynamicsWorld`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btDynamicsWorld *btDynamicsWorld_MutableDynamicDowncastFromOrFail_btCollisionWorld(btCollisionWorld *object);

#ifdef __cplusplus
} // extern "C"
#endif
