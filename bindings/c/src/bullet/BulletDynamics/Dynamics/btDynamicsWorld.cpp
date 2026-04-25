// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletDynamics/Dynamics/btDynamicsWorld.h"

#include <BulletCollision/BroadphaseCollision/btBroadphaseInterface.h>
#include <BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>
#include <BulletCollision/CollisionDispatch/btCollisionObject.h>
#include <BulletCollision/CollisionDispatch/btCollisionWorld.h>
#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletCollision/CollisionShapes/btConvexShape.h>
#include <BulletDynamics/ConstraintSolver/btConstraintSolver.h>
#include <BulletDynamics/Dynamics/btDynamicsWorld.h>
#include <BulletDynamics/Dynamics/btRigidBody.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


void btDynamicsWorld_Destroy(const btDynamicsWorld *_this)
{
    delete ((const btDynamicsWorld *)_this);
}

void btDynamicsWorld_DestroyArray(const btDynamicsWorld *_this)
{
    delete[] ((const btDynamicsWorld *)_this);
}

int btDynamicsWorld_stepSimulation(btDynamicsWorld *_this, double timeStep, const int *maxSubSteps, const double *fixedTimeStep)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).stepSimulation(
        timeStep,
        (maxSubSteps ? *maxSubSteps : static_cast<int>(1)),
        (fixedTimeStep ? *fixedTimeStep : static_cast<double>(btScalar(1.) / btScalar(60.)))
    );
}

void btDynamicsWorld_debugDrawWorld(btDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).debugDrawWorld();
}

void btDynamicsWorld_setGravity(btDynamicsWorld *_this, const btVector3 *gravity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).setGravity(
        ((gravity ? void() : MRBINDC_THROW("Parameter `gravity` can not be null.", void)), *(const btVector3 *)(gravity))
    );
}

btVector3 *btDynamicsWorld_getGravity(const btDynamicsWorld *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDynamicsWorld *)(_this)).getGravity());
}

void btDynamicsWorld_synchronizeMotionStates(btDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).synchronizeMotionStates();
}

void btDynamicsWorld_addRigidBody_1(btDynamicsWorld *_this, btRigidBody *body)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).addRigidBody(
        ((btRigidBody *)body)
    );
}

void btDynamicsWorld_addRigidBody_3(btDynamicsWorld *_this, btRigidBody *body, int group, int mask)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).addRigidBody(
        ((btRigidBody *)body),
        group,
        mask
    );
}

void btDynamicsWorld_removeRigidBody(btDynamicsWorld *_this, btRigidBody *body)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).removeRigidBody(
        ((btRigidBody *)body)
    );
}

void btDynamicsWorld_setConstraintSolver(btDynamicsWorld *_this, btConstraintSolver *solver)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).setConstraintSolver(
        ((btConstraintSolver *)solver)
    );
}

btConstraintSolver *btDynamicsWorld_getConstraintSolver(btDynamicsWorld *_this)
{
    return (btConstraintSolver *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).getConstraintSolver());
}

int btDynamicsWorld_getNumConstraints(const btDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDynamicsWorld *)(_this)).getNumConstraints();
}

void btDynamicsWorld_clearForces(btDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).clearForces();
}

void btDynamicsWorld_setWorldUserInfo(btDynamicsWorld *_this, void *worldUserInfo)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).setWorldUserInfo(
        worldUserInfo
    );
}

void *btDynamicsWorld_getWorldUserInfo(const btDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDynamicsWorld *)(_this)).getWorldUserInfo();
}

void btDynamicsWorld_setBroadphase(btDynamicsWorld *_this, btBroadphaseInterface *pairCache)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).setBroadphase(
        ((btBroadphaseInterface *)pairCache)
    );
}

btOverlappingPairCache *btDynamicsWorld_getPairCache(btDynamicsWorld *_this)
{
    return (btOverlappingPairCache *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).getPairCache());
}

void btDynamicsWorld_updateSingleAabb(btDynamicsWorld *_this, btCollisionObject *colObj)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).updateSingleAabb(
        ((btCollisionObject *)colObj)
    );
}

void btDynamicsWorld_updateAabbs(btDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).updateAabbs();
}

void btDynamicsWorld_computeOverlappingPairs(btDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).computeOverlappingPairs();
}

void btDynamicsWorld_debugDrawObject(btDynamicsWorld *_this, const btTransform *worldTransform, const btCollisionShape *shape, const btVector3 *color)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).debugDrawObject(
        ((worldTransform ? void() : MRBINDC_THROW("Parameter `worldTransform` can not be null.", void)), *(const btTransform *)(worldTransform)),
        ((const btCollisionShape *)shape),
        ((color ? void() : MRBINDC_THROW("Parameter `color` can not be null.", void)), *(const btVector3 *)(color))
    );
}

int btDynamicsWorld_getNumCollisionObjects(const btDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDynamicsWorld *)(_this)).getNumCollisionObjects();
}

void btDynamicsWorld_rayTest(const btDynamicsWorld *_this, const btVector3 *rayFromWorld, const btVector3 *rayToWorld, btCollisionWorld_RayResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDynamicsWorld *)(_this)).rayTest(
        ((rayFromWorld ? void() : MRBINDC_THROW("Parameter `rayFromWorld` can not be null.", void)), *(const btVector3 *)(rayFromWorld)),
        ((rayToWorld ? void() : MRBINDC_THROW("Parameter `rayToWorld` can not be null.", void)), *(const btVector3 *)(rayToWorld)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(resultCallback))
    );
}

void btDynamicsWorld_convexSweepTest(const btDynamicsWorld *_this, const btConvexShape *castShape, const btTransform *from, const btTransform *to, btCollisionWorld_ConvexResultCallback *resultCallback, const double *allowedCcdPenetration)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDynamicsWorld *)(_this)).convexSweepTest(
        ((const btConvexShape *)castShape),
        ((from ? void() : MRBINDC_THROW("Parameter `from` can not be null.", void)), *(const btTransform *)(from)),
        ((to ? void() : MRBINDC_THROW("Parameter `to` can not be null.", void)), *(const btTransform *)(to)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(resultCallback)),
        (allowedCcdPenetration ? *allowedCcdPenetration : static_cast<double>(btScalar(0.)))
    );
}

void btDynamicsWorld_contactTest(btDynamicsWorld *_this, btCollisionObject *colObj, btCollisionWorld_ContactResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).contactTest(
        ((btCollisionObject *)colObj),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(resultCallback))
    );
}

void btDynamicsWorld_contactPairTest(btDynamicsWorld *_this, btCollisionObject *colObjA, btCollisionObject *colObjB, btCollisionWorld_ContactResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).contactPairTest(
        ((btCollisionObject *)colObjA),
        ((btCollisionObject *)colObjB),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(resultCallback))
    );
}

void btDynamicsWorld_rayTestSingle(const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_RayResultCallback *resultCallback)
{
    btDynamicsWorld::rayTestSingle(
        ((rayFromTrans ? void() : MRBINDC_THROW("Parameter `rayFromTrans` can not be null.", void)), *(const btTransform *)(rayFromTrans)),
        ((rayToTrans ? void() : MRBINDC_THROW("Parameter `rayToTrans` can not be null.", void)), *(const btTransform *)(rayToTrans)),
        ((btCollisionObject *)collisionObject),
        ((const btCollisionShape *)collisionShape),
        ((colObjWorldTransform ? void() : MRBINDC_THROW("Parameter `colObjWorldTransform` can not be null.", void)), *(const btTransform *)(colObjWorldTransform)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(resultCallback))
    );
}

void btDynamicsWorld_objectQuerySingle(const btConvexShape *castShape, const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_ConvexResultCallback *resultCallback, double allowedPenetration)
{
    btDynamicsWorld::objectQuerySingle(
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

void btDynamicsWorld_addCollisionObject(btDynamicsWorld *_this, btCollisionObject *collisionObject, const int *collisionFilterGroup, const int *collisionFilterMask)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).addCollisionObject(
        ((btCollisionObject *)collisionObject),
        (collisionFilterGroup ? *collisionFilterGroup : static_cast<int>(btBroadphaseProxy::DefaultFilter)),
        (collisionFilterMask ? *collisionFilterMask : static_cast<int>(btBroadphaseProxy::AllFilter))
    );
}

void btDynamicsWorld_refreshBroadphaseProxy(btDynamicsWorld *_this, btCollisionObject *collisionObject)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).refreshBroadphaseProxy(
        ((btCollisionObject *)collisionObject)
    );
}

void btDynamicsWorld_removeCollisionObject(btDynamicsWorld *_this, btCollisionObject *collisionObject)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).removeCollisionObject(
        ((btCollisionObject *)collisionObject)
    );
}

void btDynamicsWorld_performDiscreteCollisionDetection(btDynamicsWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).performDiscreteCollisionDetection();
}

bool btDynamicsWorld_getForceUpdateAllAabbs(const btDynamicsWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDynamicsWorld *)(_this)).getForceUpdateAllAabbs();
}

void btDynamicsWorld_setForceUpdateAllAabbs(btDynamicsWorld *_this, bool forceUpdateAllAabbs)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDynamicsWorld *)(_this)).setForceUpdateAllAabbs(
        forceUpdateAllAabbs
    );
}

const btDynamicsWorld *btDynamicsWorld_OffsetPtr(const btDynamicsWorld *ptr, ptrdiff_t i)
{
    return (const btDynamicsWorld *)(((const btDynamicsWorld *)ptr) + i);
}

btDynamicsWorld *btDynamicsWorld_OffsetMutablePtr(btDynamicsWorld *ptr, ptrdiff_t i)
{
    return (btDynamicsWorld *)(((btDynamicsWorld *)ptr) + i);
}

const btCollisionWorld *btDynamicsWorld_UpcastTo_btCollisionWorld(const btDynamicsWorld *object)
{
    return (const btCollisionWorld *)(static_cast<const btCollisionWorld *>(
        ((const btDynamicsWorld *)object)
    ));
}

btCollisionWorld *btDynamicsWorld_MutableUpcastTo_btCollisionWorld(btDynamicsWorld *object)
{
    return (btCollisionWorld *)(static_cast<btCollisionWorld *>(
        ((btDynamicsWorld *)object)
    ));
}

const btDynamicsWorld *btDynamicsWorld_StaticDowncastFrom_btCollisionWorld(const btCollisionWorld *object)
{
    return (const btDynamicsWorld *)(static_cast<const btDynamicsWorld *>(
        ((const btCollisionWorld *)object)
    ));
}

btDynamicsWorld *btDynamicsWorld_MutableStaticDowncastFrom_btCollisionWorld(btCollisionWorld *object)
{
    return (btDynamicsWorld *)(static_cast<btDynamicsWorld *>(
        ((btCollisionWorld *)object)
    ));
}

const btDynamicsWorld *btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(const btCollisionWorld *object)
{
    return (const btDynamicsWorld *)(dynamic_cast<const btDynamicsWorld *>(
        ((const btCollisionWorld *)object)
    ));
}

btDynamicsWorld *btDynamicsWorld_MutableDynamicDowncastFrom_btCollisionWorld(btCollisionWorld *object)
{
    return (btDynamicsWorld *)(dynamic_cast<btDynamicsWorld *>(
        ((btCollisionWorld *)object)
    ));
}

const btDynamicsWorld *btDynamicsWorld_DynamicDowncastFromOrFail_btCollisionWorld(const btCollisionWorld *object)
{
    return (const btDynamicsWorld *)std::addressof(dynamic_cast<const btDynamicsWorld &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionWorld *)(object))
    ));
}

btDynamicsWorld *btDynamicsWorld_MutableDynamicDowncastFromOrFail_btCollisionWorld(btCollisionWorld *object)
{
    return (btDynamicsWorld *)std::addressof(dynamic_cast<btDynamicsWorld &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionWorld *)(object))
    ));
}

