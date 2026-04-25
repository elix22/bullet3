// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletDynamics/Dynamics/btDiscreteDynamicsWorld.h"

#include <BulletCollision/BroadphaseCollision/btBroadphaseInterface.h>
#include <BulletCollision/BroadphaseCollision/btDispatcher.h>
#include <BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>
#include <BulletCollision/CollisionDispatch/btCollisionConfiguration.h>
#include <BulletCollision/CollisionDispatch/btCollisionObject.h>
#include <BulletCollision/CollisionDispatch/btCollisionWorld.h>
#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletCollision/CollisionShapes/btConvexShape.h>
#include <BulletDynamics/ConstraintSolver/btConstraintSolver.h>
#include <BulletDynamics/Dynamics/btDiscreteDynamicsWorld.h>
#include <BulletDynamics/Dynamics/btDynamicsWorld.h>
#include <BulletDynamics/Dynamics/btRigidBody.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_ConstructFromAnother(Bullet_PassBy _other_pass_by, btDiscreteDynamicsWorld *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btDiscreteDynamicsWorld);
    return (btDiscreteDynamicsWorld *)new btDiscreteDynamicsWorld(btDiscreteDynamicsWorld(
        (MRBINDC_CLASSARG_COPY(_other, (btDiscreteDynamicsWorld), btDiscreteDynamicsWorld) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btDiscreteDynamicsWorld) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btDiscreteDynamicsWorld) MRBINDC_CLASSARG_END(_other, btDiscreteDynamicsWorld))
    ));
}

const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_OffsetPtr(const btDiscreteDynamicsWorld *ptr, ptrdiff_t i)
{
    return (const btDiscreteDynamicsWorld *)(((const btDiscreteDynamicsWorld *)ptr) + i);
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_OffsetMutablePtr(btDiscreteDynamicsWorld *ptr, ptrdiff_t i)
{
    return (btDiscreteDynamicsWorld *)(((btDiscreteDynamicsWorld *)ptr) + i);
}

const btCollisionWorld *btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld(const btDiscreteDynamicsWorld *object)
{
    return (const btCollisionWorld *)(static_cast<const btCollisionWorld *>(
        ((const btDiscreteDynamicsWorld *)object)
    ));
}

btCollisionWorld *btDiscreteDynamicsWorld_MutableUpcastTo_btCollisionWorld(btDiscreteDynamicsWorld *object)
{
    return (btCollisionWorld *)(static_cast<btCollisionWorld *>(
        ((btDiscreteDynamicsWorld *)object)
    ));
}

const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_StaticDowncastFrom_btCollisionWorld(const btCollisionWorld *object)
{
    return (const btDiscreteDynamicsWorld *)(static_cast<const btDiscreteDynamicsWorld *>(
        ((const btCollisionWorld *)object)
    ));
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableStaticDowncastFrom_btCollisionWorld(btCollisionWorld *object)
{
    return (btDiscreteDynamicsWorld *)(static_cast<btDiscreteDynamicsWorld *>(
        ((btCollisionWorld *)object)
    ));
}

const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(const btCollisionWorld *object)
{
    return (const btDiscreteDynamicsWorld *)(dynamic_cast<const btDiscreteDynamicsWorld *>(
        ((const btCollisionWorld *)object)
    ));
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableDynamicDowncastFrom_btCollisionWorld(btCollisionWorld *object)
{
    return (btDiscreteDynamicsWorld *)(dynamic_cast<btDiscreteDynamicsWorld *>(
        ((btCollisionWorld *)object)
    ));
}

const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_DynamicDowncastFromOrFail_btCollisionWorld(const btCollisionWorld *object)
{
    return (const btDiscreteDynamicsWorld *)std::addressof(dynamic_cast<const btDiscreteDynamicsWorld &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionWorld *)(object))
    ));
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableDynamicDowncastFromOrFail_btCollisionWorld(btCollisionWorld *object)
{
    return (btDiscreteDynamicsWorld *)std::addressof(dynamic_cast<btDiscreteDynamicsWorld &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionWorld *)(object))
    ));
}

const btDynamicsWorld *btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld(const btDiscreteDynamicsWorld *object)
{
    return (const btDynamicsWorld *)(static_cast<const btDynamicsWorld *>(
        ((const btDiscreteDynamicsWorld *)object)
    ));
}

btDynamicsWorld *btDiscreteDynamicsWorld_MutableUpcastTo_btDynamicsWorld(btDiscreteDynamicsWorld *object)
{
    return (btDynamicsWorld *)(static_cast<btDynamicsWorld *>(
        ((btDiscreteDynamicsWorld *)object)
    ));
}

const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_StaticDowncastFrom_btDynamicsWorld(const btDynamicsWorld *object)
{
    return (const btDiscreteDynamicsWorld *)(static_cast<const btDiscreteDynamicsWorld *>(
        ((const btDynamicsWorld *)object)
    ));
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableStaticDowncastFrom_btDynamicsWorld(btDynamicsWorld *object)
{
    return (btDiscreteDynamicsWorld *)(static_cast<btDiscreteDynamicsWorld *>(
        ((btDynamicsWorld *)object)
    ));
}

const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld(const btDynamicsWorld *object)
{
    return (const btDiscreteDynamicsWorld *)(dynamic_cast<const btDiscreteDynamicsWorld *>(
        ((const btDynamicsWorld *)object)
    ));
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableDynamicDowncastFrom_btDynamicsWorld(btDynamicsWorld *object)
{
    return (btDiscreteDynamicsWorld *)(dynamic_cast<btDiscreteDynamicsWorld *>(
        ((btDynamicsWorld *)object)
    ));
}

const btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_DynamicDowncastFromOrFail_btDynamicsWorld(const btDynamicsWorld *object)
{
    return (const btDiscreteDynamicsWorld *)std::addressof(dynamic_cast<const btDiscreteDynamicsWorld &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btDynamicsWorld *)(object))
    ));
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_MutableDynamicDowncastFromOrFail_btDynamicsWorld(btDynamicsWorld *object)
{
    return (btDiscreteDynamicsWorld *)std::addressof(dynamic_cast<btDiscreteDynamicsWorld &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btDynamicsWorld *)(object))
    ));
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_Construct(btDispatcher *dispatcher, btBroadphaseInterface *pairCache, btConstraintSolver *constraintSolver, btCollisionConfiguration *collisionConfiguration)
{
    return (btDiscreteDynamicsWorld *)new btDiscreteDynamicsWorld(btDiscreteDynamicsWorld(
        ((btDispatcher *)dispatcher),
        ((btBroadphaseInterface *)pairCache),
        ((btConstraintSolver *)constraintSolver),
        ((btCollisionConfiguration *)collisionConfiguration)
    ));
}

void btDiscreteDynamicsWorld_Destroy(const btDiscreteDynamicsWorld *_this)
{
    delete ((const btDiscreteDynamicsWorld *)_this);
}

void btDiscreteDynamicsWorld_DestroyArray(const btDiscreteDynamicsWorld *_this)
{
    delete[] ((const btDiscreteDynamicsWorld *)_this);
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorld_AssignFromAnother(btDiscreteDynamicsWorld *_this, Bullet_PassBy _other_pass_by, btDiscreteDynamicsWorld *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btDiscreteDynamicsWorld);
    return (btDiscreteDynamicsWorld *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_COPY(_other, (btDiscreteDynamicsWorld), btDiscreteDynamicsWorld) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btDiscreteDynamicsWorld) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btDiscreteDynamicsWorld) MRBINDC_CLASSARG_END(_other, btDiscreteDynamicsWorld)))
    ));
}

void *Bullet_new_btDiscreteDynamicsWorld_unsigned_long(unsigned long sizeInBytes)
{
    return btDiscreteDynamicsWorld::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btDiscreteDynamicsWorld_void_ptr(void *ptr)
{
    btDiscreteDynamicsWorld::operator delete(
        ptr
    );
}

void *Bullet_new_btDiscreteDynamicsWorld_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btDiscreteDynamicsWorld::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btDiscreteDynamicsWorld_void_ptr_void_ptr(void *_1, void *_2)
{
    btDiscreteDynamicsWorld::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long(unsigned long sizeInBytes)
{
    return btDiscreteDynamicsWorld::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr(void *ptr)
{
    btDiscreteDynamicsWorld::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btDiscreteDynamicsWorld::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr_void_ptr(void *_1, void *_2)
{
    btDiscreteDynamicsWorld::operator delete[](
        _1,
        _2
    );
}

int btDiscreteDynamicsWorld_stepSimulation(btDiscreteDynamicsWorld *_this, double timeStep, const int *maxSubSteps, const double *fixedTimeStep)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).stepSimulation(
        timeStep,
        (maxSubSteps ? *maxSubSteps : static_cast<int>(1)),
        (fixedTimeStep ? *fixedTimeStep : static_cast<double>(btScalar(1.) / btScalar(60.)))
    );
}

void btDiscreteDynamicsWorld_synchronizeMotionStates(btDiscreteDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).synchronizeMotionStates();
}

void btDiscreteDynamicsWorld_synchronizeSingleMotionState(btDiscreteDynamicsWorld *_this, btRigidBody *body)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).synchronizeSingleMotionState(
        ((btRigidBody *)body)
    );
}

btCollisionWorld *btDiscreteDynamicsWorld_getCollisionWorld(btDiscreteDynamicsWorld *_this)
{
    return (btCollisionWorld *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).getCollisionWorld());
}

void btDiscreteDynamicsWorld_setGravity(btDiscreteDynamicsWorld *_this, const btVector3 *gravity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).setGravity(
        ((gravity ? void() : MRBINDC_THROW("Parameter `gravity` can not be null.", void)), *(const btVector3 *)(gravity))
    );
}

btVector3 *btDiscreteDynamicsWorld_getGravity(const btDiscreteDynamicsWorld *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).getGravity());
}

void btDiscreteDynamicsWorld_addCollisionObject(btDiscreteDynamicsWorld *_this, btCollisionObject *collisionObject, const int *collisionFilterGroup, const int *collisionFilterMask)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).addCollisionObject(
        ((btCollisionObject *)collisionObject),
        (collisionFilterGroup ? *collisionFilterGroup : static_cast<int>(btBroadphaseProxy::StaticFilter)),
        (collisionFilterMask ? *collisionFilterMask : static_cast<int>(btBroadphaseProxy::AllFilter ^ btBroadphaseProxy::StaticFilter))
    );
}

void btDiscreteDynamicsWorld_addRigidBody_1(btDiscreteDynamicsWorld *_this, btRigidBody *body)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).addRigidBody(
        ((btRigidBody *)body)
    );
}

void btDiscreteDynamicsWorld_addRigidBody_3(btDiscreteDynamicsWorld *_this, btRigidBody *body, int group, int mask)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).addRigidBody(
        ((btRigidBody *)body),
        group,
        mask
    );
}

void btDiscreteDynamicsWorld_removeRigidBody(btDiscreteDynamicsWorld *_this, btRigidBody *body)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).removeRigidBody(
        ((btRigidBody *)body)
    );
}

void btDiscreteDynamicsWorld_removeCollisionObject(btDiscreteDynamicsWorld *_this, btCollisionObject *collisionObject)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).removeCollisionObject(
        ((btCollisionObject *)collisionObject)
    );
}

void btDiscreteDynamicsWorld_debugDrawWorld(btDiscreteDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).debugDrawWorld();
}

void btDiscreteDynamicsWorld_setConstraintSolver(btDiscreteDynamicsWorld *_this, btConstraintSolver *solver)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).setConstraintSolver(
        ((btConstraintSolver *)solver)
    );
}

btConstraintSolver *btDiscreteDynamicsWorld_getConstraintSolver(btDiscreteDynamicsWorld *_this)
{
    return (btConstraintSolver *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).getConstraintSolver());
}

int btDiscreteDynamicsWorld_getNumConstraints(const btDiscreteDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).getNumConstraints();
}

void btDiscreteDynamicsWorld_clearForces(btDiscreteDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).clearForces();
}

void btDiscreteDynamicsWorld_applyGravity(btDiscreteDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).applyGravity();
}

void btDiscreteDynamicsWorld_setNumTasks(btDiscreteDynamicsWorld *_this, int numTasks)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).setNumTasks(
        numTasks
    );
}

void btDiscreteDynamicsWorld_updateVehicles(btDiscreteDynamicsWorld *_this, double timeStep)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).updateVehicles(
        timeStep
    );
}

void btDiscreteDynamicsWorld_setSynchronizeAllMotionStates(btDiscreteDynamicsWorld *_this, bool synchronizeAll)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).setSynchronizeAllMotionStates(
        synchronizeAll
    );
}

bool btDiscreteDynamicsWorld_getSynchronizeAllMotionStates(const btDiscreteDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).getSynchronizeAllMotionStates();
}

void btDiscreteDynamicsWorld_setApplySpeculativeContactRestitution(btDiscreteDynamicsWorld *_this, bool enable)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).setApplySpeculativeContactRestitution(
        enable
    );
}

bool btDiscreteDynamicsWorld_getApplySpeculativeContactRestitution(const btDiscreteDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).getApplySpeculativeContactRestitution();
}

void btDiscreteDynamicsWorld_setLatencyMotionStateInterpolation(btDiscreteDynamicsWorld *_this, bool latencyInterpolation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).setLatencyMotionStateInterpolation(
        latencyInterpolation
    );
}

bool btDiscreteDynamicsWorld_getLatencyMotionStateInterpolation(const btDiscreteDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).getLatencyMotionStateInterpolation();
}

void btDiscreteDynamicsWorld_setWorldUserInfo(btDiscreteDynamicsWorld *_this, void *worldUserInfo)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).setWorldUserInfo(
        worldUserInfo
    );
}

void *btDiscreteDynamicsWorld_getWorldUserInfo(const btDiscreteDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).getWorldUserInfo();
}

void btDiscreteDynamicsWorld_setBroadphase(btDiscreteDynamicsWorld *_this, btBroadphaseInterface *pairCache)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).setBroadphase(
        ((btBroadphaseInterface *)pairCache)
    );
}

btOverlappingPairCache *btDiscreteDynamicsWorld_getPairCache(btDiscreteDynamicsWorld *_this)
{
    return (btOverlappingPairCache *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).getPairCache());
}

void btDiscreteDynamicsWorld_updateSingleAabb(btDiscreteDynamicsWorld *_this, btCollisionObject *colObj)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).updateSingleAabb(
        ((btCollisionObject *)colObj)
    );
}

void btDiscreteDynamicsWorld_updateAabbs(btDiscreteDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).updateAabbs();
}

void btDiscreteDynamicsWorld_computeOverlappingPairs(btDiscreteDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).computeOverlappingPairs();
}

void btDiscreteDynamicsWorld_debugDrawObject(btDiscreteDynamicsWorld *_this, const btTransform *worldTransform, const btCollisionShape *shape, const btVector3 *color)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).debugDrawObject(
        ((worldTransform ? void() : MRBINDC_THROW("Parameter `worldTransform` can not be null.", void)), *(const btTransform *)(worldTransform)),
        ((const btCollisionShape *)shape),
        ((color ? void() : MRBINDC_THROW("Parameter `color` can not be null.", void)), *(const btVector3 *)(color))
    );
}

int btDiscreteDynamicsWorld_getNumCollisionObjects(const btDiscreteDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).getNumCollisionObjects();
}

void btDiscreteDynamicsWorld_rayTest(const btDiscreteDynamicsWorld *_this, const btVector3 *rayFromWorld, const btVector3 *rayToWorld, btCollisionWorld_RayResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).rayTest(
        ((rayFromWorld ? void() : MRBINDC_THROW("Parameter `rayFromWorld` can not be null.", void)), *(const btVector3 *)(rayFromWorld)),
        ((rayToWorld ? void() : MRBINDC_THROW("Parameter `rayToWorld` can not be null.", void)), *(const btVector3 *)(rayToWorld)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(resultCallback))
    );
}

void btDiscreteDynamicsWorld_convexSweepTest(const btDiscreteDynamicsWorld *_this, const btConvexShape *castShape, const btTransform *from, const btTransform *to, btCollisionWorld_ConvexResultCallback *resultCallback, const double *allowedCcdPenetration)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).convexSweepTest(
        ((const btConvexShape *)castShape),
        ((from ? void() : MRBINDC_THROW("Parameter `from` can not be null.", void)), *(const btTransform *)(from)),
        ((to ? void() : MRBINDC_THROW("Parameter `to` can not be null.", void)), *(const btTransform *)(to)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(resultCallback)),
        (allowedCcdPenetration ? *allowedCcdPenetration : static_cast<double>(btScalar(0.)))
    );
}

void btDiscreteDynamicsWorld_contactTest(btDiscreteDynamicsWorld *_this, btCollisionObject *colObj, btCollisionWorld_ContactResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).contactTest(
        ((btCollisionObject *)colObj),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(resultCallback))
    );
}

void btDiscreteDynamicsWorld_contactPairTest(btDiscreteDynamicsWorld *_this, btCollisionObject *colObjA, btCollisionObject *colObjB, btCollisionWorld_ContactResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).contactPairTest(
        ((btCollisionObject *)colObjA),
        ((btCollisionObject *)colObjB),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(resultCallback))
    );
}

void btDiscreteDynamicsWorld_rayTestSingle(const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_RayResultCallback *resultCallback)
{
    btDiscreteDynamicsWorld::rayTestSingle(
        ((rayFromTrans ? void() : MRBINDC_THROW("Parameter `rayFromTrans` can not be null.", void)), *(const btTransform *)(rayFromTrans)),
        ((rayToTrans ? void() : MRBINDC_THROW("Parameter `rayToTrans` can not be null.", void)), *(const btTransform *)(rayToTrans)),
        ((btCollisionObject *)collisionObject),
        ((const btCollisionShape *)collisionShape),
        ((colObjWorldTransform ? void() : MRBINDC_THROW("Parameter `colObjWorldTransform` can not be null.", void)), *(const btTransform *)(colObjWorldTransform)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(resultCallback))
    );
}

void btDiscreteDynamicsWorld_objectQuerySingle(const btConvexShape *castShape, const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_ConvexResultCallback *resultCallback, double allowedPenetration)
{
    btDiscreteDynamicsWorld::objectQuerySingle(
        ((const btConvexShape *)castShape),
        ((rayFromTrans ? void() : MRBINDC_THROW("Parameter `rayFromTrans` can not be null.", void)), *(const btTransform *)(rayFromTrans)),
        ((rayToTrans ? void() : MRBINDC_THROW("Parameter `rayToTrans` can not be null.", void)), *(const btTransform *)(rayToTrans)),
        ((btCollisionObject *)collisionObject),
        ((const btCollisionShape *)collisionShape),
        ((colObjWorldTransform ? void() : MRBINDC_THROW("Parameter `colObjWorldTransform` can not be null.", void)), *(const btTransform *)(colObjWorldTransform)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(resultCallback)),
        allowedPenetration
    );
}

void btDiscreteDynamicsWorld_refreshBroadphaseProxy(btDiscreteDynamicsWorld *_this, btCollisionObject *collisionObject)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).refreshBroadphaseProxy(
        ((btCollisionObject *)collisionObject)
    );
}

void btDiscreteDynamicsWorld_performDiscreteCollisionDetection(btDiscreteDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).performDiscreteCollisionDetection();
}

bool btDiscreteDynamicsWorld_getForceUpdateAllAabbs(const btDiscreteDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(_this)).getForceUpdateAllAabbs();
}

void btDiscreteDynamicsWorld_setForceUpdateAllAabbs(btDiscreteDynamicsWorld *_this, bool forceUpdateAllAabbs)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorld *)(_this)).setForceUpdateAllAabbs(
        forceUpdateAllAabbs
    );
}

