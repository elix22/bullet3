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
typedef struct btConvexShape btConvexShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btConvexShape.h>`.
typedef struct btDispatcher btDispatcher; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btDispatcher.h>`.
typedef struct btOverlappingPairCache btOverlappingPairCache; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///LocalShapeInfo gives extra information for complex shapes
///Currently, only btTriangleMeshShape is available, so it just contains triangleIndex and subpart
/// Generated from class `btCollisionWorld::LocalShapeInfo`.
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionWorld_LocalShapeInfo btCollisionWorld_LocalShapeInfo;

/// Generated from class `btCollisionWorld::LocalRayResult`.
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionWorld_LocalRayResult btCollisionWorld_LocalRayResult;

///RayResultCallback is used to report new raycast results
/// Generated from class `btCollisionWorld::RayResultCallback`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btCollisionWorld::AllHitsRayResultCallback`
///     `btCollisionWorld::ClosestRayResultCallback`
typedef struct btCollisionWorld_RayResultCallback btCollisionWorld_RayResultCallback;

/// Generated from class `btCollisionWorld::ClosestRayResultCallback`.
/// Base classes:
///   Direct: (non-virtual)
///     `btCollisionWorld::RayResultCallback`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionWorld_ClosestRayResultCallback btCollisionWorld_ClosestRayResultCallback;

/// Generated from class `btCollisionWorld::AllHitsRayResultCallback`.
/// Base classes:
///   Direct: (non-virtual)
///     `btCollisionWorld::RayResultCallback`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionWorld_AllHitsRayResultCallback btCollisionWorld_AllHitsRayResultCallback;

/// Generated from class `btCollisionWorld::LocalConvexResult`.
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionWorld_LocalConvexResult btCollisionWorld_LocalConvexResult;

///RayResultCallback is used to report new raycast results
/// Generated from class `btCollisionWorld::ConvexResultCallback`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btCollisionWorld::ClosestConvexResultCallback`
typedef struct btCollisionWorld_ConvexResultCallback btCollisionWorld_ConvexResultCallback;

/// Generated from class `btCollisionWorld::ClosestConvexResultCallback`.
/// Base classes:
///   Direct: (non-virtual)
///     `btCollisionWorld::ConvexResultCallback`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionWorld_ClosestConvexResultCallback btCollisionWorld_ClosestConvexResultCallback;

///ContactResultCallback is used to report contact points
/// Generated from class `btCollisionWorld::ContactResultCallback`.
typedef struct btCollisionWorld_ContactResultCallback btCollisionWorld_ContactResultCallback;

///CollisionWorld is interface and container for the collision detection
/// Generated from class `btCollisionWorld`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btDynamicsWorld`
///   Indirect: (non-virtual)
///     `btDiscreteDynamicsWorld`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionWorld btCollisionWorld;

/// Generated from constructor `btCollisionWorld::btCollisionWorld`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld *btCollisionWorld_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionWorld *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld *btCollisionWorld_OffsetPtr(const btCollisionWorld *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld *btCollisionWorld_OffsetMutablePtr(btCollisionWorld *ptr, ptrdiff_t i);

//this constructor doesn't own the dispatcher and paircache/broadphase
/// Generated from constructor `btCollisionWorld::btCollisionWorld`.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld *btCollisionWorld_Construct(btDispatcher *dispatcher, btBroadphaseInterface *broadphasePairCache, btCollisionConfiguration *collisionConfiguration);

/// Destroys a heap-allocated instance of `btCollisionWorld`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_Destroy(const btCollisionWorld *_this);

/// Destroys a heap-allocated array of `btCollisionWorld`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_DestroyArray(const btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionWorld *btCollisionWorld_AssignFromAnother(btCollisionWorld *_this, Bullet_PassBy _other_pass_by, btCollisionWorld *_other);

/// Generated from method `btCollisionWorld::setBroadphase`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionWorld_setBroadphase(btCollisionWorld *_this, btBroadphaseInterface *pairCache);

/// Generated from method `btCollisionWorld::getBroadphase`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btBroadphaseInterface *btCollisionWorld_getBroadphase(const btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::getBroadphase`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btBroadphaseInterface *btCollisionWorld_getBroadphase_mut(btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::getPairCache`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btOverlappingPairCache *btCollisionWorld_getPairCache(btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::getDispatcher`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btDispatcher *btCollisionWorld_getDispatcher_mut(btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::getDispatcher`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btDispatcher *btCollisionWorld_getDispatcher(const btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::updateSingleAabb`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionWorld_updateSingleAabb(btCollisionWorld *_this, btCollisionObject *colObj);

/// Generated from method `btCollisionWorld::updateAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionWorld_updateAabbs(btCollisionWorld *_this);

///the computeOverlappingPairs is usually already called by performDiscreteCollisionDetection (or stepSimulation)
///it can be useful to use if you perform ray tests without collision detection/simulation
/// Generated from method `btCollisionWorld::computeOverlappingPairs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionWorld_computeOverlappingPairs(btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::debugDrawWorld`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionWorld_debugDrawWorld(btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::debugDrawObject`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `worldTransform` can not be null. It is a single object.
/// Parameter `color` can not be null. It is a single object.
BULLET_API void btCollisionWorld_debugDrawObject(btCollisionWorld *_this, const btTransform *worldTransform, const btCollisionShape *shape, const btVector3 *color);

/// Generated from method `btCollisionWorld::getNumCollisionObjects`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionWorld_getNumCollisionObjects(const btCollisionWorld *_this);

/// rayTest performs a raycast on all objects in the btCollisionWorld, and calls the resultCallback
/// This allows for several queries: first hit, all hits, any hit, dependent on the value returned by the callback.
/// Generated from method `btCollisionWorld::rayTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rayFromWorld` can not be null. It is a single object.
/// Parameter `rayToWorld` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btCollisionWorld_rayTest(const btCollisionWorld *_this, const btVector3 *rayFromWorld, const btVector3 *rayToWorld, btCollisionWorld_RayResultCallback *resultCallback);

/// convexTest performs a swept convex cast on all objects in the btCollisionWorld, and calls the resultCallback
/// This allows for several queries: first hit, all hits, any hit, dependent on the value return by the callback.
/// Generated from method `btCollisionWorld::convexSweepTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `from` can not be null. It is a single object.
/// Parameter `to` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
/// Parameter `allowedCcdPenetration` has a default argument: `btScalar(0.0)`, pass a null pointer to use it.
BULLET_API void btCollisionWorld_convexSweepTest(const btCollisionWorld *_this, const btConvexShape *castShape, const btTransform *from, const btTransform *to, btCollisionWorld_ConvexResultCallback *resultCallback, const double *allowedCcdPenetration);

///contactTest performs a discrete collision test between colObj against all objects in the btCollisionWorld, and calls the resultCallback.
///it reports one or more contact points for every overlapping object (including the one with deepest penetration)
/// Generated from method `btCollisionWorld::contactTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btCollisionWorld_contactTest(btCollisionWorld *_this, btCollisionObject *colObj, btCollisionWorld_ContactResultCallback *resultCallback);

///contactTest performs a discrete collision test between two collision objects and calls the resultCallback if overlap if detected.
///it reports one or more contact points (including the one with deepest penetration)
/// Generated from method `btCollisionWorld::contactPairTest`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btCollisionWorld_contactPairTest(btCollisionWorld *_this, btCollisionObject *colObjA, btCollisionObject *colObjB, btCollisionWorld_ContactResultCallback *resultCallback);

/// rayTestSingle performs a raycast call and calls the resultCallback. It is used internally by rayTest.
/// In a future implementation, we consider moving the ray test as a virtual method in btCollisionShape.
/// This allows more customization.
/// Generated from method `btCollisionWorld::rayTestSingle`.
/// Parameter `rayFromTrans` can not be null. It is a single object.
/// Parameter `rayToTrans` can not be null. It is a single object.
/// Parameter `colObjWorldTransform` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btCollisionWorld_rayTestSingle(const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_RayResultCallback *resultCallback);

/// objectQuerySingle performs a collision detection query and calls the resultCallback. It is used internally by rayTest.
/// Generated from method `btCollisionWorld::objectQuerySingle`.
/// Parameter `rayFromTrans` can not be null. It is a single object.
/// Parameter `rayToTrans` can not be null. It is a single object.
/// Parameter `colObjWorldTransform` can not be null. It is a single object.
/// Parameter `resultCallback` can not be null. It is a single object.
BULLET_API void btCollisionWorld_objectQuerySingle(const btConvexShape *castShape, const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_ConvexResultCallback *resultCallback, double allowedPenetration);

/// Generated from method `btCollisionWorld::addCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `collisionFilterGroup` has a default argument: `btBroadphaseProxy::DefaultFilter`, pass a null pointer to use it.
/// Parameter `collisionFilterMask` has a default argument: `btBroadphaseProxy::AllFilter`, pass a null pointer to use it.
BULLET_API void btCollisionWorld_addCollisionObject(btCollisionWorld *_this, btCollisionObject *collisionObject, const int *collisionFilterGroup, const int *collisionFilterMask);

/// Generated from method `btCollisionWorld::refreshBroadphaseProxy`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionWorld_refreshBroadphaseProxy(btCollisionWorld *_this, btCollisionObject *collisionObject);

/// Generated from method `btCollisionWorld::removeCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionWorld_removeCollisionObject(btCollisionWorld *_this, btCollisionObject *collisionObject);

/// Generated from method `btCollisionWorld::performDiscreteCollisionDetection`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionWorld_performDiscreteCollisionDetection(btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::getForceUpdateAllAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionWorld_getForceUpdateAllAabbs(const btCollisionWorld *_this);

/// Generated from method `btCollisionWorld::setForceUpdateAllAabbs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionWorld_setForceUpdateAllAabbs(btCollisionWorld *_this, bool forceUpdateAllAabbs);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalShapeInfo` named `m_shapePart`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_LocalShapeInfo_Get_m_shapePart(const btCollisionWorld_LocalShapeInfo *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalShapeInfo` named `m_shapePart`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_shapePart`.
BULLET_API void btCollisionWorld_LocalShapeInfo_Set_m_shapePart(btCollisionWorld_LocalShapeInfo *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalShapeInfo` named `m_shapePart`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_LocalShapeInfo_GetMutable_m_shapePart(btCollisionWorld_LocalShapeInfo *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalShapeInfo` named `m_triangleIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_LocalShapeInfo_Get_m_triangleIndex(const btCollisionWorld_LocalShapeInfo *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalShapeInfo` named `m_triangleIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_triangleIndex`.
BULLET_API void btCollisionWorld_LocalShapeInfo_Set_m_triangleIndex(btCollisionWorld_LocalShapeInfo *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalShapeInfo` named `m_triangleIndex`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_LocalShapeInfo_GetMutable_m_triangleIndex(btCollisionWorld_LocalShapeInfo *_this);

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_LocalShapeInfo_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btCollisionWorld_LocalShapeInfo_DestroyArray()`.
/// Use `btCollisionWorld_LocalShapeInfo_OffsetMutablePtr()` and `btCollisionWorld_LocalShapeInfo_OffsetPtr()` to access the array elements.
BULLET_API btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_DefaultConstructArray(size_t num_elems);

/// Constructs `btCollisionWorld::LocalShapeInfo` elementwise.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_LocalShapeInfo_Destroy()` to free it when you're done using it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_ConstructFrom(int m_shapePart, int m_triangleIndex);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_OffsetPtr(const btCollisionWorld_LocalShapeInfo *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_OffsetMutablePtr(btCollisionWorld_LocalShapeInfo *ptr, ptrdiff_t i);

/// Generated from constructor `btCollisionWorld::LocalShapeInfo::LocalShapeInfo`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_LocalShapeInfo_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_ConstructFromAnother(const btCollisionWorld_LocalShapeInfo *_other);

/// Destroys a heap-allocated instance of `btCollisionWorld_LocalShapeInfo`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_LocalShapeInfo_Destroy(const btCollisionWorld_LocalShapeInfo *_this);

/// Destroys a heap-allocated array of `btCollisionWorld_LocalShapeInfo`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_LocalShapeInfo_DestroyArray(const btCollisionWorld_LocalShapeInfo *_this);

/// Generated from method `btCollisionWorld::LocalShapeInfo::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_AssignFromAnother(btCollisionWorld_LocalShapeInfo *_this, const btCollisionWorld_LocalShapeInfo *_other);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalRayResult` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject *const *btCollisionWorld_LocalRayResult_Get_m_collisionObject(const btCollisionWorld_LocalRayResult *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalRayResult` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_collisionObject`.
/// When this function is called, this object will drop object references it held previously in `m_collisionObject`.
BULLET_API void btCollisionWorld_LocalRayResult_Set_m_collisionObject(btCollisionWorld_LocalRayResult *_this, const btCollisionObject *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalRayResult` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject **btCollisionWorld_LocalRayResult_GetMutable_m_collisionObject(btCollisionWorld_LocalRayResult *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalRayResult` named `m_localShapeInfo`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btCollisionWorld_LocalShapeInfo *const *btCollisionWorld_LocalRayResult_Get_m_localShapeInfo(const btCollisionWorld_LocalRayResult *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalRayResult` named `m_localShapeInfo`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_localShapeInfo`.
/// When this function is called, this object will drop object references it held previously in `m_localShapeInfo`.
BULLET_API void btCollisionWorld_LocalRayResult_Set_m_localShapeInfo(btCollisionWorld_LocalRayResult *_this, btCollisionWorld_LocalShapeInfo *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalRayResult` named `m_localShapeInfo`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btCollisionWorld_LocalShapeInfo **btCollisionWorld_LocalRayResult_GetMutable_m_localShapeInfo(btCollisionWorld_LocalRayResult *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalRayResult` named `m_hitNormalLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_LocalRayResult_Get_m_hitNormalLocal(const btCollisionWorld_LocalRayResult *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalRayResult` named `m_hitNormalLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_hitNormalLocal`.
/// When this function is called, this object will drop object references it held previously in `m_hitNormalLocal`.
BULLET_API void btCollisionWorld_LocalRayResult_Set_m_hitNormalLocal(btCollisionWorld_LocalRayResult *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalRayResult` named `m_hitNormalLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_LocalRayResult_GetMutable_m_hitNormalLocal(btCollisionWorld_LocalRayResult *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalRayResult` named `m_hitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btCollisionWorld_LocalRayResult_Get_m_hitFraction(const btCollisionWorld_LocalRayResult *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalRayResult` named `m_hitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_hitFraction`.
BULLET_API void btCollisionWorld_LocalRayResult_Set_m_hitFraction(btCollisionWorld_LocalRayResult *_this, double value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalRayResult` named `m_hitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btCollisionWorld_LocalRayResult_GetMutable_m_hitFraction(btCollisionWorld_LocalRayResult *_this);

/// Generated from constructor `btCollisionWorld::LocalRayResult::LocalRayResult`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_LocalRayResult_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_ConstructFromAnother(const btCollisionWorld_LocalRayResult *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_OffsetPtr(const btCollisionWorld_LocalRayResult *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_OffsetMutablePtr(btCollisionWorld_LocalRayResult *ptr, ptrdiff_t i);

/// Generated from constructor `btCollisionWorld::LocalRayResult::LocalRayResult`.
/// Parameter `hitNormalLocal` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_LocalRayResult_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_Construct(const btCollisionObject *collisionObject, btCollisionWorld_LocalShapeInfo *localShapeInfo, const btVector3 *hitNormalLocal, double hitFraction);

/// Destroys a heap-allocated instance of `btCollisionWorld_LocalRayResult`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_LocalRayResult_Destroy(const btCollisionWorld_LocalRayResult *_this);

/// Destroys a heap-allocated array of `btCollisionWorld_LocalRayResult`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_LocalRayResult_DestroyArray(const btCollisionWorld_LocalRayResult *_this);

/// Generated from method `btCollisionWorld::LocalRayResult::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_AssignFromAnother(btCollisionWorld_LocalRayResult *_this, const btCollisionWorld_LocalRayResult *_other);

/// Returns a pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btCollisionWorld_RayResultCallback_Get_m_closestHitFraction(const btCollisionWorld_RayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::RayResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_closestHitFraction`.
BULLET_API void btCollisionWorld_RayResultCallback_Set_m_closestHitFraction(btCollisionWorld_RayResultCallback *_this, double value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btCollisionWorld_RayResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_RayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject *const *btCollisionWorld_RayResultCallback_Get_m_collisionObject(const btCollisionWorld_RayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::RayResultCallback` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_collisionObject`.
/// When this function is called, this object will drop object references it held previously in `m_collisionObject`.
BULLET_API void btCollisionWorld_RayResultCallback_Set_m_collisionObject(btCollisionWorld_RayResultCallback *_this, const btCollisionObject *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject **btCollisionWorld_RayResultCallback_GetMutable_m_collisionObject(btCollisionWorld_RayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_RayResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_RayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::RayResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterGroup`.
BULLET_API void btCollisionWorld_RayResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_RayResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_RayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_RayResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_RayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::RayResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterMask`.
BULLET_API void btCollisionWorld_RayResultCallback_Set_m_collisionFilterMask(btCollisionWorld_RayResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_RayResultCallback *_this);

//@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
/// Returns a pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_flags`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const unsigned int *btCollisionWorld_RayResultCallback_Get_m_flags(const btCollisionWorld_RayResultCallback *_this);

//@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
/// Modifies a member variable of class `btCollisionWorld::RayResultCallback` named `m_flags`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_flags`.
/// When this function is called, this object will drop object references it held previously in `m_flags`.
BULLET_API void btCollisionWorld_RayResultCallback_Set_m_flags(btCollisionWorld_RayResultCallback *_this, unsigned int value);

//@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
/// Returns a mutable pointer to a member variable of class `btCollisionWorld::RayResultCallback` named `m_flags`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API unsigned int *btCollisionWorld_RayResultCallback_GetMutable_m_flags(btCollisionWorld_RayResultCallback *_this);

/// Destroys a heap-allocated instance of `btCollisionWorld_RayResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_RayResultCallback_Destroy(const btCollisionWorld_RayResultCallback *_this);

/// Destroys a heap-allocated array of `btCollisionWorld_RayResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_RayResultCallback_DestroyArray(const btCollisionWorld_RayResultCallback *_this);

/// Generated from method `btCollisionWorld::RayResultCallback::hasHit`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionWorld_RayResultCallback_hasHit(const btCollisionWorld_RayResultCallback *_this);

/// Generated from method `btCollisionWorld::RayResultCallback::addSingleResult`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rayResult` can not be null. It is a single object.
BULLET_API double btCollisionWorld_RayResultCallback_addSingleResult(btCollisionWorld_RayResultCallback *_this, btCollisionWorld_LocalRayResult *rayResult, bool normalInWorldSpace);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld_RayResultCallback *btCollisionWorld_RayResultCallback_OffsetPtr(const btCollisionWorld_RayResultCallback *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld_RayResultCallback *btCollisionWorld_RayResultCallback_OffsetMutablePtr(btCollisionWorld_RayResultCallback *ptr, ptrdiff_t i);

//used to calculate hitPointWorld from hitFraction
/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_rayFromWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_ClosestRayResultCallback_Get_m_rayFromWorld(const btCollisionWorld_ClosestRayResultCallback *_this);

//used to calculate hitPointWorld from hitFraction
/// Modifies a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_rayFromWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_rayFromWorld`.
/// When this function is called, this object will drop object references it held previously in `m_rayFromWorld`.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Set_m_rayFromWorld(btCollisionWorld_ClosestRayResultCallback *_this, const btVector3 *value);

//used to calculate hitPointWorld from hitFraction
/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_rayFromWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayFromWorld(btCollisionWorld_ClosestRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_rayToWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_ClosestRayResultCallback_Get_m_rayToWorld(const btCollisionWorld_ClosestRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_rayToWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_rayToWorld`.
/// When this function is called, this object will drop object references it held previously in `m_rayToWorld`.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Set_m_rayToWorld(btCollisionWorld_ClosestRayResultCallback *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_rayToWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayToWorld(btCollisionWorld_ClosestRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_hitNormalWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_ClosestRayResultCallback_Get_m_hitNormalWorld(const btCollisionWorld_ClosestRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_hitNormalWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_hitNormalWorld`.
/// When this function is called, this object will drop object references it held previously in `m_hitNormalWorld`.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Set_m_hitNormalWorld(btCollisionWorld_ClosestRayResultCallback *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_hitNormalWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitNormalWorld(btCollisionWorld_ClosestRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_hitPointWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_ClosestRayResultCallback_Get_m_hitPointWorld(const btCollisionWorld_ClosestRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_hitPointWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_hitPointWorld`.
/// When this function is called, this object will drop object references it held previously in `m_hitPointWorld`.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Set_m_hitPointWorld(btCollisionWorld_ClosestRayResultCallback *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_hitPointWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitPointWorld(btCollisionWorld_ClosestRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btCollisionWorld_ClosestRayResultCallback_Get_m_closestHitFraction(const btCollisionWorld_ClosestRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_closestHitFraction`.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Set_m_closestHitFraction(btCollisionWorld_ClosestRayResultCallback *_this, double value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_ClosestRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject *const *btCollisionWorld_ClosestRayResultCallback_Get_m_collisionObject(const btCollisionWorld_ClosestRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_collisionObject`.
/// When this function is called, this object will drop object references it held previously in `m_collisionObject`.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Set_m_collisionObject(btCollisionWorld_ClosestRayResultCallback *_this, const btCollisionObject *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject **btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionObject(btCollisionWorld_ClosestRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_ClosestRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterGroup`.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_ClosestRayResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_ClosestRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_ClosestRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterMask`.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Set_m_collisionFilterMask(btCollisionWorld_ClosestRayResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_ClosestRayResultCallback *_this);

//@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_flags`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const unsigned int *btCollisionWorld_ClosestRayResultCallback_Get_m_flags(const btCollisionWorld_ClosestRayResultCallback *_this);

//@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
/// Modifies a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_flags`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_flags`.
/// When this function is called, this object will drop object references it held previously in `m_flags`.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Set_m_flags(btCollisionWorld_ClosestRayResultCallback *_this, unsigned int value);

//@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestRayResultCallback` named `m_flags`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API unsigned int *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_flags(btCollisionWorld_ClosestRayResultCallback *_this);

/// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_ClosestRayResultCallback_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionWorld_ClosestRayResultCallback *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_OffsetPtr(const btCollisionWorld_ClosestRayResultCallback *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_OffsetMutablePtr(btCollisionWorld_ClosestRayResultCallback *ptr, ptrdiff_t i);

/// Upcasts an instance of `btCollisionWorld::ClosestRayResultCallback` to its base class `btCollisionWorld::RayResultCallback`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld_RayResultCallback *btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(const btCollisionWorld_ClosestRayResultCallback *object);

/// Upcasts an instance of `btCollisionWorld::ClosestRayResultCallback` to its base class `btCollisionWorld::RayResultCallback`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld_RayResultCallback *btCollisionWorld_ClosestRayResultCallback_MutableUpcastTo_btCollisionWorld_RayResultCallback(btCollisionWorld_ClosestRayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::ClosestRayResultCallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_StaticDowncastFrom_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::ClosestRayResultCallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_MutableStaticDowncastFrom_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::ClosestRayResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::ClosestRayResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_MutableDynamicDowncastFrom_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::ClosestRayResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFromOrFail_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::ClosestRayResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_MutableDynamicDowncastFromOrFail_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object);

/// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
/// Parameter `rayFromWorld` can not be null. It is a single object.
/// Parameter `rayToWorld` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_ClosestRayResultCallback_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_Construct(const btVector3 *rayFromWorld, const btVector3 *rayToWorld);

/// Destroys a heap-allocated instance of `btCollisionWorld_ClosestRayResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_Destroy(const btCollisionWorld_ClosestRayResultCallback *_this);

/// Destroys a heap-allocated array of `btCollisionWorld_ClosestRayResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_ClosestRayResultCallback_DestroyArray(const btCollisionWorld_ClosestRayResultCallback *_this);

/// Generated from method `btCollisionWorld::ClosestRayResultCallback::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_AssignFromAnother(btCollisionWorld_ClosestRayResultCallback *_this, Bullet_PassBy _other_pass_by, btCollisionWorld_ClosestRayResultCallback *_other);

/// Generated from method `btCollisionWorld::ClosestRayResultCallback::addSingleResult`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rayResult` can not be null. It is a single object.
BULLET_API double btCollisionWorld_ClosestRayResultCallback_addSingleResult(btCollisionWorld_ClosestRayResultCallback *_this, btCollisionWorld_LocalRayResult *rayResult, bool normalInWorldSpace);

/// Generated from method `btCollisionWorld::ClosestRayResultCallback::hasHit`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionWorld_ClosestRayResultCallback_hasHit(const btCollisionWorld_ClosestRayResultCallback *_this);

//used to calculate hitPointWorld from hitFraction
/// Returns a pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_rayFromWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_AllHitsRayResultCallback_Get_m_rayFromWorld(const btCollisionWorld_AllHitsRayResultCallback *_this);

//used to calculate hitPointWorld from hitFraction
/// Modifies a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_rayFromWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_rayFromWorld`.
/// When this function is called, this object will drop object references it held previously in `m_rayFromWorld`.
BULLET_API void btCollisionWorld_AllHitsRayResultCallback_Set_m_rayFromWorld(btCollisionWorld_AllHitsRayResultCallback *_this, const btVector3 *value);

//used to calculate hitPointWorld from hitFraction
/// Returns a mutable pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_rayFromWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayFromWorld(btCollisionWorld_AllHitsRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_rayToWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_AllHitsRayResultCallback_Get_m_rayToWorld(const btCollisionWorld_AllHitsRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_rayToWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_rayToWorld`.
/// When this function is called, this object will drop object references it held previously in `m_rayToWorld`.
BULLET_API void btCollisionWorld_AllHitsRayResultCallback_Set_m_rayToWorld(btCollisionWorld_AllHitsRayResultCallback *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_rayToWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayToWorld(btCollisionWorld_AllHitsRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btCollisionWorld_AllHitsRayResultCallback_Get_m_closestHitFraction(const btCollisionWorld_AllHitsRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_closestHitFraction`.
BULLET_API void btCollisionWorld_AllHitsRayResultCallback_Set_m_closestHitFraction(btCollisionWorld_AllHitsRayResultCallback *_this, double value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_AllHitsRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject *const *btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionObject(const btCollisionWorld_AllHitsRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_collisionObject`.
/// When this function is called, this object will drop object references it held previously in `m_collisionObject`.
BULLET_API void btCollisionWorld_AllHitsRayResultCallback_Set_m_collisionObject(btCollisionWorld_AllHitsRayResultCallback *_this, const btCollisionObject *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_collisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject **btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionObject(btCollisionWorld_AllHitsRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_AllHitsRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterGroup`.
BULLET_API void btCollisionWorld_AllHitsRayResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_AllHitsRayResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_AllHitsRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_AllHitsRayResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterMask`.
BULLET_API void btCollisionWorld_AllHitsRayResultCallback_Set_m_collisionFilterMask(btCollisionWorld_AllHitsRayResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_AllHitsRayResultCallback *_this);

//@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
/// Returns a pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_flags`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const unsigned int *btCollisionWorld_AllHitsRayResultCallback_Get_m_flags(const btCollisionWorld_AllHitsRayResultCallback *_this);

//@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
/// Modifies a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_flags`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_flags`.
/// When this function is called, this object will drop object references it held previously in `m_flags`.
BULLET_API void btCollisionWorld_AllHitsRayResultCallback_Set_m_flags(btCollisionWorld_AllHitsRayResultCallback *_this, unsigned int value);

//@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
/// Returns a mutable pointer to a member variable of class `btCollisionWorld::AllHitsRayResultCallback` named `m_flags`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API unsigned int *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_flags(btCollisionWorld_AllHitsRayResultCallback *_this);

/// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_AllHitsRayResultCallback_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionWorld_AllHitsRayResultCallback *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_OffsetPtr(const btCollisionWorld_AllHitsRayResultCallback *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_OffsetMutablePtr(btCollisionWorld_AllHitsRayResultCallback *ptr, ptrdiff_t i);

/// Upcasts an instance of `btCollisionWorld::AllHitsRayResultCallback` to its base class `btCollisionWorld::RayResultCallback`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld_RayResultCallback *btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(const btCollisionWorld_AllHitsRayResultCallback *object);

/// Upcasts an instance of `btCollisionWorld::AllHitsRayResultCallback` to its base class `btCollisionWorld::RayResultCallback`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld_RayResultCallback *btCollisionWorld_AllHitsRayResultCallback_MutableUpcastTo_btCollisionWorld_RayResultCallback(btCollisionWorld_AllHitsRayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::AllHitsRayResultCallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_StaticDowncastFrom_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::AllHitsRayResultCallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_MutableStaticDowncastFrom_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::AllHitsRayResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::AllHitsRayResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_MutableDynamicDowncastFrom_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::AllHitsRayResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFromOrFail_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::RayResultCallback` to a derived class `btCollisionWorld::AllHitsRayResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_MutableDynamicDowncastFromOrFail_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object);

/// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
/// Parameter `rayFromWorld` can not be null. It is a single object.
/// Parameter `rayToWorld` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_AllHitsRayResultCallback_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_Construct(const btVector3 *rayFromWorld, const btVector3 *rayToWorld);

/// Destroys a heap-allocated instance of `btCollisionWorld_AllHitsRayResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_AllHitsRayResultCallback_Destroy(const btCollisionWorld_AllHitsRayResultCallback *_this);

/// Destroys a heap-allocated array of `btCollisionWorld_AllHitsRayResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_AllHitsRayResultCallback_DestroyArray(const btCollisionWorld_AllHitsRayResultCallback *_this);

/// Generated from method `btCollisionWorld::AllHitsRayResultCallback::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_AssignFromAnother(btCollisionWorld_AllHitsRayResultCallback *_this, Bullet_PassBy _other_pass_by, btCollisionWorld_AllHitsRayResultCallback *_other);

/// Generated from method `btCollisionWorld::AllHitsRayResultCallback::addSingleResult`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rayResult` can not be null. It is a single object.
BULLET_API double btCollisionWorld_AllHitsRayResultCallback_addSingleResult(btCollisionWorld_AllHitsRayResultCallback *_this, btCollisionWorld_LocalRayResult *rayResult, bool normalInWorldSpace);

/// Generated from method `btCollisionWorld::AllHitsRayResultCallback::hasHit`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionWorld_AllHitsRayResultCallback_hasHit(const btCollisionWorld_AllHitsRayResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject *const *btCollisionWorld_LocalConvexResult_Get_m_hitCollisionObject(const btCollisionWorld_LocalConvexResult *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_hitCollisionObject`.
/// When this function is called, this object will drop object references it held previously in `m_hitCollisionObject`.
BULLET_API void btCollisionWorld_LocalConvexResult_Set_m_hitCollisionObject(btCollisionWorld_LocalConvexResult *_this, const btCollisionObject *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject **btCollisionWorld_LocalConvexResult_GetMutable_m_hitCollisionObject(btCollisionWorld_LocalConvexResult *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_localShapeInfo`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btCollisionWorld_LocalShapeInfo *const *btCollisionWorld_LocalConvexResult_Get_m_localShapeInfo(const btCollisionWorld_LocalConvexResult *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalConvexResult` named `m_localShapeInfo`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_localShapeInfo`.
/// When this function is called, this object will drop object references it held previously in `m_localShapeInfo`.
BULLET_API void btCollisionWorld_LocalConvexResult_Set_m_localShapeInfo(btCollisionWorld_LocalConvexResult *_this, btCollisionWorld_LocalShapeInfo *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_localShapeInfo`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btCollisionWorld_LocalShapeInfo **btCollisionWorld_LocalConvexResult_GetMutable_m_localShapeInfo(btCollisionWorld_LocalConvexResult *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitNormalLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_LocalConvexResult_Get_m_hitNormalLocal(const btCollisionWorld_LocalConvexResult *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitNormalLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_hitNormalLocal`.
/// When this function is called, this object will drop object references it held previously in `m_hitNormalLocal`.
BULLET_API void btCollisionWorld_LocalConvexResult_Set_m_hitNormalLocal(btCollisionWorld_LocalConvexResult *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitNormalLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_LocalConvexResult_GetMutable_m_hitNormalLocal(btCollisionWorld_LocalConvexResult *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitPointLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_LocalConvexResult_Get_m_hitPointLocal(const btCollisionWorld_LocalConvexResult *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitPointLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_hitPointLocal`.
/// When this function is called, this object will drop object references it held previously in `m_hitPointLocal`.
BULLET_API void btCollisionWorld_LocalConvexResult_Set_m_hitPointLocal(btCollisionWorld_LocalConvexResult *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitPointLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_LocalConvexResult_GetMutable_m_hitPointLocal(btCollisionWorld_LocalConvexResult *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btCollisionWorld_LocalConvexResult_Get_m_hitFraction(const btCollisionWorld_LocalConvexResult *_this);

/// Modifies a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_hitFraction`.
BULLET_API void btCollisionWorld_LocalConvexResult_Set_m_hitFraction(btCollisionWorld_LocalConvexResult *_this, double value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::LocalConvexResult` named `m_hitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btCollisionWorld_LocalConvexResult_GetMutable_m_hitFraction(btCollisionWorld_LocalConvexResult *_this);

/// Generated from constructor `btCollisionWorld::LocalConvexResult::LocalConvexResult`.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_LocalConvexResult_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_ConstructFromAnother(const btCollisionWorld_LocalConvexResult *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_OffsetPtr(const btCollisionWorld_LocalConvexResult *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_OffsetMutablePtr(btCollisionWorld_LocalConvexResult *ptr, ptrdiff_t i);

/// Generated from constructor `btCollisionWorld::LocalConvexResult::LocalConvexResult`.
/// Parameter `hitNormalLocal` can not be null. It is a single object.
/// Parameter `hitPointLocal` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_LocalConvexResult_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_Construct(const btCollisionObject *hitCollisionObject, btCollisionWorld_LocalShapeInfo *localShapeInfo, const btVector3 *hitNormalLocal, const btVector3 *hitPointLocal, double hitFraction);

/// Destroys a heap-allocated instance of `btCollisionWorld_LocalConvexResult`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_LocalConvexResult_Destroy(const btCollisionWorld_LocalConvexResult *_this);

/// Destroys a heap-allocated array of `btCollisionWorld_LocalConvexResult`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_LocalConvexResult_DestroyArray(const btCollisionWorld_LocalConvexResult *_this);

/// Generated from method `btCollisionWorld::LocalConvexResult::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `_other` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_AssignFromAnother(btCollisionWorld_LocalConvexResult *_this, const btCollisionWorld_LocalConvexResult *_other);

/// Returns a pointer to a member variable of class `btCollisionWorld::ConvexResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btCollisionWorld_ConvexResultCallback_Get_m_closestHitFraction(const btCollisionWorld_ConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ConvexResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_closestHitFraction`.
BULLET_API void btCollisionWorld_ConvexResultCallback_Set_m_closestHitFraction(btCollisionWorld_ConvexResultCallback *_this, double value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ConvexResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btCollisionWorld_ConvexResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_ConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ConvexResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_ConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ConvexResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterGroup`.
BULLET_API void btCollisionWorld_ConvexResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_ConvexResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ConvexResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_ConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ConvexResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_ConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ConvexResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterMask`.
BULLET_API void btCollisionWorld_ConvexResultCallback_Set_m_collisionFilterMask(btCollisionWorld_ConvexResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ConvexResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_ConvexResultCallback *_this);

/// Destroys a heap-allocated instance of `btCollisionWorld_ConvexResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_ConvexResultCallback_Destroy(const btCollisionWorld_ConvexResultCallback *_this);

/// Destroys a heap-allocated array of `btCollisionWorld_ConvexResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_ConvexResultCallback_DestroyArray(const btCollisionWorld_ConvexResultCallback *_this);

/// Generated from method `btCollisionWorld::ConvexResultCallback::hasHit`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionWorld_ConvexResultCallback_hasHit(const btCollisionWorld_ConvexResultCallback *_this);

/// Generated from method `btCollisionWorld::ConvexResultCallback::addSingleResult`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `convexResult` can not be null. It is a single object.
BULLET_API double btCollisionWorld_ConvexResultCallback_addSingleResult(btCollisionWorld_ConvexResultCallback *_this, btCollisionWorld_LocalConvexResult *convexResult, bool normalInWorldSpace);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld_ConvexResultCallback *btCollisionWorld_ConvexResultCallback_OffsetPtr(const btCollisionWorld_ConvexResultCallback *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld_ConvexResultCallback *btCollisionWorld_ConvexResultCallback_OffsetMutablePtr(btCollisionWorld_ConvexResultCallback *ptr, ptrdiff_t i);

//used to calculate hitPointWorld from hitFraction
/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_convexFromWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_ClosestConvexResultCallback_Get_m_convexFromWorld(const btCollisionWorld_ClosestConvexResultCallback *_this);

//used to calculate hitPointWorld from hitFraction
/// Modifies a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_convexFromWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_convexFromWorld`.
/// When this function is called, this object will drop object references it held previously in `m_convexFromWorld`.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_Set_m_convexFromWorld(btCollisionWorld_ClosestConvexResultCallback *_this, const btVector3 *value);

//used to calculate hitPointWorld from hitFraction
/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_convexFromWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexFromWorld(btCollisionWorld_ClosestConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_convexToWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_ClosestConvexResultCallback_Get_m_convexToWorld(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_convexToWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_convexToWorld`.
/// When this function is called, this object will drop object references it held previously in `m_convexToWorld`.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_Set_m_convexToWorld(btCollisionWorld_ClosestConvexResultCallback *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_convexToWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexToWorld(btCollisionWorld_ClosestConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_hitNormalWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_ClosestConvexResultCallback_Get_m_hitNormalWorld(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_hitNormalWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_hitNormalWorld`.
/// When this function is called, this object will drop object references it held previously in `m_hitNormalWorld`.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_Set_m_hitNormalWorld(btCollisionWorld_ClosestConvexResultCallback *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_hitNormalWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitNormalWorld(btCollisionWorld_ClosestConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_hitPointWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btCollisionWorld_ClosestConvexResultCallback_Get_m_hitPointWorld(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_hitPointWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_hitPointWorld`.
/// When this function is called, this object will drop object references it held previously in `m_hitPointWorld`.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_Set_m_hitPointWorld(btCollisionWorld_ClosestConvexResultCallback *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_hitPointWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitPointWorld(btCollisionWorld_ClosestConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_hitCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject *const *btCollisionWorld_ClosestConvexResultCallback_Get_m_hitCollisionObject(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_hitCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_hitCollisionObject`.
/// When this function is called, this object will drop object references it held previously in `m_hitCollisionObject`.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_Set_m_hitCollisionObject(btCollisionWorld_ClosestConvexResultCallback *_this, const btCollisionObject *value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_hitCollisionObject`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btCollisionObject **btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitCollisionObject(btCollisionWorld_ClosestConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btCollisionWorld_ClosestConvexResultCallback_Get_m_closestHitFraction(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_closestHitFraction`.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_Set_m_closestHitFraction(btCollisionWorld_ClosestConvexResultCallback *_this, double value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_closestHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_ClosestConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterGroup`.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_ClosestConvexResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_ClosestConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterMask`.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_Set_m_collisionFilterMask(btCollisionWorld_ClosestConvexResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ClosestConvexResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_ClosestConvexResultCallback *_this);

/// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_ClosestConvexResultCallback_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionWorld_ClosestConvexResultCallback *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_OffsetPtr(const btCollisionWorld_ClosestConvexResultCallback *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_OffsetMutablePtr(btCollisionWorld_ClosestConvexResultCallback *ptr, ptrdiff_t i);

/// Upcasts an instance of `btCollisionWorld::ClosestConvexResultCallback` to its base class `btCollisionWorld::ConvexResultCallback`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld_ConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback(const btCollisionWorld_ClosestConvexResultCallback *object);

/// Upcasts an instance of `btCollisionWorld::ClosestConvexResultCallback` to its base class `btCollisionWorld::ConvexResultCallback`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld_ConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_MutableUpcastTo_btCollisionWorld_ConvexResultCallback(btCollisionWorld_ClosestConvexResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::ConvexResultCallback` to a derived class `btCollisionWorld::ClosestConvexResultCallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_StaticDowncastFrom_btCollisionWorld_ConvexResultCallback(const btCollisionWorld_ConvexResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::ConvexResultCallback` to a derived class `btCollisionWorld::ClosestConvexResultCallback`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_MutableStaticDowncastFrom_btCollisionWorld_ConvexResultCallback(btCollisionWorld_ConvexResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::ConvexResultCallback` to a derived class `btCollisionWorld::ClosestConvexResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback(const btCollisionWorld_ConvexResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::ConvexResultCallback` to a derived class `btCollisionWorld::ClosestConvexResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_MutableDynamicDowncastFrom_btCollisionWorld_ConvexResultCallback(btCollisionWorld_ConvexResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::ConvexResultCallback` to a derived class `btCollisionWorld::ClosestConvexResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFromOrFail_btCollisionWorld_ConvexResultCallback(const btCollisionWorld_ConvexResultCallback *object);

/// Downcasts an instance of `btCollisionWorld::ConvexResultCallback` to a derived class `btCollisionWorld::ClosestConvexResultCallback`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_MutableDynamicDowncastFromOrFail_btCollisionWorld_ConvexResultCallback(btCollisionWorld_ConvexResultCallback *object);

/// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
/// Parameter `convexFromWorld` can not be null. It is a single object.
/// Parameter `convexToWorld` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionWorld_ClosestConvexResultCallback_Destroy()` to free it when you're done using it.
BULLET_API btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_Construct(const btVector3 *convexFromWorld, const btVector3 *convexToWorld);

/// Destroys a heap-allocated instance of `btCollisionWorld_ClosestConvexResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_Destroy(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Destroys a heap-allocated array of `btCollisionWorld_ClosestConvexResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_ClosestConvexResultCallback_DestroyArray(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Generated from method `btCollisionWorld::ClosestConvexResultCallback::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_AssignFromAnother(btCollisionWorld_ClosestConvexResultCallback *_this, Bullet_PassBy _other_pass_by, btCollisionWorld_ClosestConvexResultCallback *_other);

/// Generated from method `btCollisionWorld::ClosestConvexResultCallback::addSingleResult`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `convexResult` can not be null. It is a single object.
BULLET_API double btCollisionWorld_ClosestConvexResultCallback_addSingleResult(btCollisionWorld_ClosestConvexResultCallback *_this, btCollisionWorld_LocalConvexResult *convexResult, bool normalInWorldSpace);

/// Generated from method `btCollisionWorld::ClosestConvexResultCallback::hasHit`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionWorld_ClosestConvexResultCallback_hasHit(const btCollisionWorld_ClosestConvexResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ContactResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_ContactResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_ContactResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ContactResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterGroup`.
BULLET_API void btCollisionWorld_ContactResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_ContactResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ContactResultCallback` named `m_collisionFilterGroup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_ContactResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ContactResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btCollisionWorld_ContactResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_ContactResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ContactResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_collisionFilterMask`.
BULLET_API void btCollisionWorld_ContactResultCallback_Set_m_collisionFilterMask(btCollisionWorld_ContactResultCallback *_this, int value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ContactResultCallback` named `m_collisionFilterMask`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_ContactResultCallback *_this);

/// Returns a pointer to a member variable of class `btCollisionWorld::ContactResultCallback` named `m_closestDistanceThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btCollisionWorld_ContactResultCallback_Get_m_closestDistanceThreshold(const btCollisionWorld_ContactResultCallback *_this);

/// Modifies a member variable of class `btCollisionWorld::ContactResultCallback` named `m_closestDistanceThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_closestDistanceThreshold`.
BULLET_API void btCollisionWorld_ContactResultCallback_Set_m_closestDistanceThreshold(btCollisionWorld_ContactResultCallback *_this, double value);

/// Returns a mutable pointer to a member variable of class `btCollisionWorld::ContactResultCallback` named `m_closestDistanceThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btCollisionWorld_ContactResultCallback_GetMutable_m_closestDistanceThreshold(btCollisionWorld_ContactResultCallback *_this);

/// Destroys a heap-allocated instance of `btCollisionWorld_ContactResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_ContactResultCallback_Destroy(const btCollisionWorld_ContactResultCallback *_this);

/// Destroys a heap-allocated array of `btCollisionWorld_ContactResultCallback`. Does nothing if the pointer is null.
BULLET_API void btCollisionWorld_ContactResultCallback_DestroyArray(const btCollisionWorld_ContactResultCallback *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionWorld_ContactResultCallback *btCollisionWorld_ContactResultCallback_OffsetPtr(const btCollisionWorld_ContactResultCallback *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionWorld_ContactResultCallback *btCollisionWorld_ContactResultCallback_OffsetMutablePtr(btCollisionWorld_ContactResultCallback *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
