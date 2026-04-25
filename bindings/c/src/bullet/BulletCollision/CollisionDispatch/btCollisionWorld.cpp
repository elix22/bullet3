// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionDispatch/btCollisionWorld.h"

#include <BulletCollision/BroadphaseCollision/btBroadphaseInterface.h>
#include <BulletCollision/BroadphaseCollision/btDispatcher.h>
#include <BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>
#include <BulletCollision/CollisionDispatch/btCollisionConfiguration.h>
#include <BulletCollision/CollisionDispatch/btCollisionObject.h>
#include <BulletCollision/CollisionDispatch/btCollisionWorld.h>
#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletCollision/CollisionShapes/btConvexShape.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btCollisionWorld *btCollisionWorld_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionWorld *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionWorld);
    return (btCollisionWorld *)new btCollisionWorld(btCollisionWorld(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionWorld), btCollisionWorld) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionWorld) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionWorld) MRBINDC_CLASSARG_END(_other, btCollisionWorld))
    ));
}

const btCollisionWorld *btCollisionWorld_OffsetPtr(const btCollisionWorld *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld *)(((const btCollisionWorld *)ptr) + i);
}

btCollisionWorld *btCollisionWorld_OffsetMutablePtr(btCollisionWorld *ptr, ptrdiff_t i)
{
    return (btCollisionWorld *)(((btCollisionWorld *)ptr) + i);
}

btCollisionWorld *btCollisionWorld_Construct(btDispatcher *dispatcher, btBroadphaseInterface *broadphasePairCache, btCollisionConfiguration *collisionConfiguration)
{
    return (btCollisionWorld *)new btCollisionWorld(btCollisionWorld(
        ((btDispatcher *)dispatcher),
        ((btBroadphaseInterface *)broadphasePairCache),
        ((btCollisionConfiguration *)collisionConfiguration)
    ));
}

void btCollisionWorld_Destroy(const btCollisionWorld *_this)
{
    delete ((const btCollisionWorld *)_this);
}

void btCollisionWorld_DestroyArray(const btCollisionWorld *_this)
{
    delete[] ((const btCollisionWorld *)_this);
}

btCollisionWorld *btCollisionWorld_AssignFromAnother(btCollisionWorld *_this, Bullet_PassBy _other_pass_by, btCollisionWorld *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionWorld);
    return (btCollisionWorld *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_COPY(_other, (btCollisionWorld), btCollisionWorld) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionWorld) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionWorld) MRBINDC_CLASSARG_END(_other, btCollisionWorld)))
    ));
}

void btCollisionWorld_setBroadphase(btCollisionWorld *_this, btBroadphaseInterface *pairCache)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).setBroadphase(
        ((btBroadphaseInterface *)pairCache)
    );
}

const btBroadphaseInterface *btCollisionWorld_getBroadphase(const btCollisionWorld *_this)
{
    return (const btBroadphaseInterface *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld *)(_this)).getBroadphase());
}

btBroadphaseInterface *btCollisionWorld_getBroadphase_mut(btCollisionWorld *_this)
{
    return (btBroadphaseInterface *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).getBroadphase());
}

btOverlappingPairCache *btCollisionWorld_getPairCache(btCollisionWorld *_this)
{
    return (btOverlappingPairCache *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).getPairCache());
}

btDispatcher *btCollisionWorld_getDispatcher_mut(btCollisionWorld *_this)
{
    return (btDispatcher *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).getDispatcher());
}

const btDispatcher *btCollisionWorld_getDispatcher(const btCollisionWorld *_this)
{
    return (const btDispatcher *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld *)(_this)).getDispatcher());
}

void btCollisionWorld_updateSingleAabb(btCollisionWorld *_this, btCollisionObject *colObj)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).updateSingleAabb(
        ((btCollisionObject *)colObj)
    );
}

void btCollisionWorld_updateAabbs(btCollisionWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).updateAabbs();
}

void btCollisionWorld_computeOverlappingPairs(btCollisionWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).computeOverlappingPairs();
}

void btCollisionWorld_debugDrawWorld(btCollisionWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).debugDrawWorld();
}

void btCollisionWorld_debugDrawObject(btCollisionWorld *_this, const btTransform *worldTransform, const btCollisionShape *shape, const btVector3 *color)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).debugDrawObject(
        ((worldTransform ? void() : MRBINDC_THROW("Parameter `worldTransform` can not be null.", void)), *(const btTransform *)(worldTransform)),
        ((const btCollisionShape *)shape),
        ((color ? void() : MRBINDC_THROW("Parameter `color` can not be null.", void)), *(const btVector3 *)(color))
    );
}

int btCollisionWorld_getNumCollisionObjects(const btCollisionWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld *)(_this)).getNumCollisionObjects();
}

void btCollisionWorld_rayTest(const btCollisionWorld *_this, const btVector3 *rayFromWorld, const btVector3 *rayToWorld, btCollisionWorld_RayResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld *)(_this)).rayTest(
        ((rayFromWorld ? void() : MRBINDC_THROW("Parameter `rayFromWorld` can not be null.", void)), *(const btVector3 *)(rayFromWorld)),
        ((rayToWorld ? void() : MRBINDC_THROW("Parameter `rayToWorld` can not be null.", void)), *(const btVector3 *)(rayToWorld)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(resultCallback))
    );
}

void btCollisionWorld_convexSweepTest(const btCollisionWorld *_this, const btConvexShape *castShape, const btTransform *from, const btTransform *to, btCollisionWorld_ConvexResultCallback *resultCallback, const double *allowedCcdPenetration)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld *)(_this)).convexSweepTest(
        ((const btConvexShape *)castShape),
        ((from ? void() : MRBINDC_THROW("Parameter `from` can not be null.", void)), *(const btTransform *)(from)),
        ((to ? void() : MRBINDC_THROW("Parameter `to` can not be null.", void)), *(const btTransform *)(to)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(resultCallback)),
        (allowedCcdPenetration ? *allowedCcdPenetration : static_cast<double>(btScalar(0.)))
    );
}

void btCollisionWorld_contactTest(btCollisionWorld *_this, btCollisionObject *colObj, btCollisionWorld_ContactResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).contactTest(
        ((btCollisionObject *)colObj),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(resultCallback))
    );
}

void btCollisionWorld_contactPairTest(btCollisionWorld *_this, btCollisionObject *colObjA, btCollisionObject *colObjB, btCollisionWorld_ContactResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).contactPairTest(
        ((btCollisionObject *)colObjA),
        ((btCollisionObject *)colObjB),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(resultCallback))
    );
}

void btCollisionWorld_rayTestSingle(const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_RayResultCallback *resultCallback)
{
    btCollisionWorld::rayTestSingle(
        ((rayFromTrans ? void() : MRBINDC_THROW("Parameter `rayFromTrans` can not be null.", void)), *(const btTransform *)(rayFromTrans)),
        ((rayToTrans ? void() : MRBINDC_THROW("Parameter `rayToTrans` can not be null.", void)), *(const btTransform *)(rayToTrans)),
        ((btCollisionObject *)collisionObject),
        ((const btCollisionShape *)collisionShape),
        ((colObjWorldTransform ? void() : MRBINDC_THROW("Parameter `colObjWorldTransform` can not be null.", void)), *(const btTransform *)(colObjWorldTransform)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(resultCallback))
    );
}

void btCollisionWorld_objectQuerySingle(const btConvexShape *castShape, const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_ConvexResultCallback *resultCallback, double allowedPenetration)
{
    btCollisionWorld::objectQuerySingle(
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

void btCollisionWorld_addCollisionObject(btCollisionWorld *_this, btCollisionObject *collisionObject, const int *collisionFilterGroup, const int *collisionFilterMask)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).addCollisionObject(
        ((btCollisionObject *)collisionObject),
        (collisionFilterGroup ? *collisionFilterGroup : static_cast<int>(btBroadphaseProxy::DefaultFilter)),
        (collisionFilterMask ? *collisionFilterMask : static_cast<int>(btBroadphaseProxy::AllFilter))
    );
}

void btCollisionWorld_refreshBroadphaseProxy(btCollisionWorld *_this, btCollisionObject *collisionObject)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).refreshBroadphaseProxy(
        ((btCollisionObject *)collisionObject)
    );
}

void btCollisionWorld_removeCollisionObject(btCollisionWorld *_this, btCollisionObject *collisionObject)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).removeCollisionObject(
        ((btCollisionObject *)collisionObject)
    );
}

void btCollisionWorld_performDiscreteCollisionDetection(btCollisionWorld *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).performDiscreteCollisionDetection();
}

bool btCollisionWorld_getForceUpdateAllAabbs(const btCollisionWorld *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld *)(_this)).getForceUpdateAllAabbs();
}

void btCollisionWorld_setForceUpdateAllAabbs(btCollisionWorld *_this, bool forceUpdateAllAabbs)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld *)(_this)).setForceUpdateAllAabbs(
        forceUpdateAllAabbs
    );
}

const int *btCollisionWorld_LocalShapeInfo_Get_m_shapePart(const btCollisionWorld_LocalShapeInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalShapeInfo *)(_this)).m_shapePart);
}

void btCollisionWorld_LocalShapeInfo_Set_m_shapePart(btCollisionWorld_LocalShapeInfo *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalShapeInfo *)(_this)).m_shapePart = value;
}

int *btCollisionWorld_LocalShapeInfo_GetMutable_m_shapePart(btCollisionWorld_LocalShapeInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalShapeInfo *)(_this)).m_shapePart);
}

const int *btCollisionWorld_LocalShapeInfo_Get_m_triangleIndex(const btCollisionWorld_LocalShapeInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalShapeInfo *)(_this)).m_triangleIndex);
}

void btCollisionWorld_LocalShapeInfo_Set_m_triangleIndex(btCollisionWorld_LocalShapeInfo *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalShapeInfo *)(_this)).m_triangleIndex = value;
}

int *btCollisionWorld_LocalShapeInfo_GetMutable_m_triangleIndex(btCollisionWorld_LocalShapeInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalShapeInfo *)(_this)).m_triangleIndex);
}

btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_DefaultConstruct(void)
{
    return (btCollisionWorld_LocalShapeInfo *)new btCollisionWorld::LocalShapeInfo(btCollisionWorld::LocalShapeInfo());
}

btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_DefaultConstructArray(size_t num_elems)
{
    return (btCollisionWorld_LocalShapeInfo *)(new btCollisionWorld::LocalShapeInfo[num_elems]{});
}

btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_ConstructFrom(int m_shapePart, int m_triangleIndex)
{
    return (btCollisionWorld_LocalShapeInfo *)new btCollisionWorld::LocalShapeInfo(btCollisionWorld::LocalShapeInfo{
        m_shapePart,
        m_triangleIndex
    });
}

const btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_OffsetPtr(const btCollisionWorld_LocalShapeInfo *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld_LocalShapeInfo *)(((const btCollisionWorld::LocalShapeInfo *)ptr) + i);
}

btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_OffsetMutablePtr(btCollisionWorld_LocalShapeInfo *ptr, ptrdiff_t i)
{
    return (btCollisionWorld_LocalShapeInfo *)(((btCollisionWorld::LocalShapeInfo *)ptr) + i);
}

btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_ConstructFromAnother(const btCollisionWorld_LocalShapeInfo *_other)
{
    return (btCollisionWorld_LocalShapeInfo *)new btCollisionWorld::LocalShapeInfo(btCollisionWorld::LocalShapeInfo(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btCollisionWorld::LocalShapeInfo(*(btCollisionWorld::LocalShapeInfo *)_other))
    ));
}

void btCollisionWorld_LocalShapeInfo_Destroy(const btCollisionWorld_LocalShapeInfo *_this)
{
    delete ((const btCollisionWorld::LocalShapeInfo *)_this);
}

void btCollisionWorld_LocalShapeInfo_DestroyArray(const btCollisionWorld_LocalShapeInfo *_this)
{
    delete[] ((const btCollisionWorld::LocalShapeInfo *)_this);
}

btCollisionWorld_LocalShapeInfo *btCollisionWorld_LocalShapeInfo_AssignFromAnother(btCollisionWorld_LocalShapeInfo *_this, const btCollisionWorld_LocalShapeInfo *_other)
{
    return (btCollisionWorld_LocalShapeInfo *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalShapeInfo *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btCollisionWorld::LocalShapeInfo(*(btCollisionWorld::LocalShapeInfo *)_other))
    ));
}

const btCollisionObject *const *btCollisionWorld_LocalRayResult_Get_m_collisionObject(const btCollisionWorld_LocalRayResult *_this)
{
    return (const btCollisionObject *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalRayResult *)(_this)).m_collisionObject);
}

void btCollisionWorld_LocalRayResult_Set_m_collisionObject(btCollisionWorld_LocalRayResult *_this, const btCollisionObject *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(_this)).m_collisionObject = ((const btCollisionObject *)value);
}

const btCollisionObject **btCollisionWorld_LocalRayResult_GetMutable_m_collisionObject(btCollisionWorld_LocalRayResult *_this)
{
    return (const btCollisionObject **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(_this)).m_collisionObject);
}

btCollisionWorld_LocalShapeInfo *const *btCollisionWorld_LocalRayResult_Get_m_localShapeInfo(const btCollisionWorld_LocalRayResult *_this)
{
    return (btCollisionWorld_LocalShapeInfo *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalRayResult *)(_this)).m_localShapeInfo);
}

void btCollisionWorld_LocalRayResult_Set_m_localShapeInfo(btCollisionWorld_LocalRayResult *_this, btCollisionWorld_LocalShapeInfo *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(_this)).m_localShapeInfo = ((btCollisionWorld::LocalShapeInfo *)value);
}

btCollisionWorld_LocalShapeInfo **btCollisionWorld_LocalRayResult_GetMutable_m_localShapeInfo(btCollisionWorld_LocalRayResult *_this)
{
    return (btCollisionWorld_LocalShapeInfo **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(_this)).m_localShapeInfo);
}

const btVector3 *btCollisionWorld_LocalRayResult_Get_m_hitNormalLocal(const btCollisionWorld_LocalRayResult *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalRayResult *)(_this)).m_hitNormalLocal);
}

void btCollisionWorld_LocalRayResult_Set_m_hitNormalLocal(btCollisionWorld_LocalRayResult *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(_this)).m_hitNormalLocal = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_LocalRayResult_GetMutable_m_hitNormalLocal(btCollisionWorld_LocalRayResult *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(_this)).m_hitNormalLocal);
}

const double *btCollisionWorld_LocalRayResult_Get_m_hitFraction(const btCollisionWorld_LocalRayResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalRayResult *)(_this)).m_hitFraction);
}

void btCollisionWorld_LocalRayResult_Set_m_hitFraction(btCollisionWorld_LocalRayResult *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(_this)).m_hitFraction = value;
}

double *btCollisionWorld_LocalRayResult_GetMutable_m_hitFraction(btCollisionWorld_LocalRayResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(_this)).m_hitFraction);
}

btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_ConstructFromAnother(const btCollisionWorld_LocalRayResult *_other)
{
    return (btCollisionWorld_LocalRayResult *)new btCollisionWorld::LocalRayResult(btCollisionWorld::LocalRayResult(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btCollisionWorld::LocalRayResult(*(btCollisionWorld::LocalRayResult *)_other))
    ));
}

const btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_OffsetPtr(const btCollisionWorld_LocalRayResult *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld_LocalRayResult *)(((const btCollisionWorld::LocalRayResult *)ptr) + i);
}

btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_OffsetMutablePtr(btCollisionWorld_LocalRayResult *ptr, ptrdiff_t i)
{
    return (btCollisionWorld_LocalRayResult *)(((btCollisionWorld::LocalRayResult *)ptr) + i);
}

btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_Construct(const btCollisionObject *collisionObject, btCollisionWorld_LocalShapeInfo *localShapeInfo, const btVector3 *hitNormalLocal, double hitFraction)
{
    return (btCollisionWorld_LocalRayResult *)new btCollisionWorld::LocalRayResult(btCollisionWorld::LocalRayResult(
        ((const btCollisionObject *)collisionObject),
        ((btCollisionWorld::LocalShapeInfo *)localShapeInfo),
        ((hitNormalLocal ? void() : MRBINDC_THROW("Parameter `hitNormalLocal` can not be null.", void)), *(const btVector3 *)(hitNormalLocal)),
        hitFraction
    ));
}

void btCollisionWorld_LocalRayResult_Destroy(const btCollisionWorld_LocalRayResult *_this)
{
    delete ((const btCollisionWorld::LocalRayResult *)_this);
}

void btCollisionWorld_LocalRayResult_DestroyArray(const btCollisionWorld_LocalRayResult *_this)
{
    delete[] ((const btCollisionWorld::LocalRayResult *)_this);
}

btCollisionWorld_LocalRayResult *btCollisionWorld_LocalRayResult_AssignFromAnother(btCollisionWorld_LocalRayResult *_this, const btCollisionWorld_LocalRayResult *_other)
{
    return (btCollisionWorld_LocalRayResult *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btCollisionWorld::LocalRayResult(*(btCollisionWorld::LocalRayResult *)_other))
    ));
}

const double *btCollisionWorld_RayResultCallback_Get_m_closestHitFraction(const btCollisionWorld_RayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::RayResultCallback *)(_this)).m_closestHitFraction);
}

void btCollisionWorld_RayResultCallback_Set_m_closestHitFraction(btCollisionWorld_RayResultCallback *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_closestHitFraction = value;
}

double *btCollisionWorld_RayResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_RayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_closestHitFraction);
}

const btCollisionObject *const *btCollisionWorld_RayResultCallback_Get_m_collisionObject(const btCollisionWorld_RayResultCallback *_this)
{
    return (const btCollisionObject *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::RayResultCallback *)(_this)).m_collisionObject);
}

void btCollisionWorld_RayResultCallback_Set_m_collisionObject(btCollisionWorld_RayResultCallback *_this, const btCollisionObject *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_collisionObject = ((const btCollisionObject *)value);
}

const btCollisionObject **btCollisionWorld_RayResultCallback_GetMutable_m_collisionObject(btCollisionWorld_RayResultCallback *_this)
{
    return (const btCollisionObject **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_collisionObject);
}

const int *btCollisionWorld_RayResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_RayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::RayResultCallback *)(_this)).m_collisionFilterGroup);
}

void btCollisionWorld_RayResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_RayResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_collisionFilterGroup = value;
}

int *btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_RayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_collisionFilterGroup);
}

const int *btCollisionWorld_RayResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_RayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::RayResultCallback *)(_this)).m_collisionFilterMask);
}

void btCollisionWorld_RayResultCallback_Set_m_collisionFilterMask(btCollisionWorld_RayResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_collisionFilterMask = value;
}

int *btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_RayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_collisionFilterMask);
}

const unsigned int *btCollisionWorld_RayResultCallback_Get_m_flags(const btCollisionWorld_RayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::RayResultCallback *)(_this)).m_flags);
}

void btCollisionWorld_RayResultCallback_Set_m_flags(btCollisionWorld_RayResultCallback *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_flags = value;
}

unsigned int *btCollisionWorld_RayResultCallback_GetMutable_m_flags(btCollisionWorld_RayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).m_flags);
}

void btCollisionWorld_RayResultCallback_Destroy(const btCollisionWorld_RayResultCallback *_this)
{
    delete ((const btCollisionWorld::RayResultCallback *)_this);
}

void btCollisionWorld_RayResultCallback_DestroyArray(const btCollisionWorld_RayResultCallback *_this)
{
    delete[] ((const btCollisionWorld::RayResultCallback *)_this);
}

bool btCollisionWorld_RayResultCallback_hasHit(const btCollisionWorld_RayResultCallback *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::RayResultCallback *)(_this)).hasHit();
}

double btCollisionWorld_RayResultCallback_addSingleResult(btCollisionWorld_RayResultCallback *_this, btCollisionWorld_LocalRayResult *rayResult, bool normalInWorldSpace)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(_this)).addSingleResult(
        ((rayResult ? void() : MRBINDC_THROW("Parameter `rayResult` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(rayResult)),
        normalInWorldSpace
    );
}

const btCollisionWorld_RayResultCallback *btCollisionWorld_RayResultCallback_OffsetPtr(const btCollisionWorld_RayResultCallback *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld_RayResultCallback *)(((const btCollisionWorld::RayResultCallback *)ptr) + i);
}

btCollisionWorld_RayResultCallback *btCollisionWorld_RayResultCallback_OffsetMutablePtr(btCollisionWorld_RayResultCallback *ptr, ptrdiff_t i)
{
    return (btCollisionWorld_RayResultCallback *)(((btCollisionWorld::RayResultCallback *)ptr) + i);
}

const btVector3 *btCollisionWorld_ClosestRayResultCallback_Get_m_rayFromWorld(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).m_rayFromWorld);
}

void btCollisionWorld_ClosestRayResultCallback_Set_m_rayFromWorld(btCollisionWorld_ClosestRayResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_rayFromWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayFromWorld(btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_rayFromWorld);
}

const btVector3 *btCollisionWorld_ClosestRayResultCallback_Get_m_rayToWorld(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).m_rayToWorld);
}

void btCollisionWorld_ClosestRayResultCallback_Set_m_rayToWorld(btCollisionWorld_ClosestRayResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_rayToWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayToWorld(btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_rayToWorld);
}

const btVector3 *btCollisionWorld_ClosestRayResultCallback_Get_m_hitNormalWorld(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).m_hitNormalWorld);
}

void btCollisionWorld_ClosestRayResultCallback_Set_m_hitNormalWorld(btCollisionWorld_ClosestRayResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_hitNormalWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitNormalWorld(btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_hitNormalWorld);
}

const btVector3 *btCollisionWorld_ClosestRayResultCallback_Get_m_hitPointWorld(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).m_hitPointWorld);
}

void btCollisionWorld_ClosestRayResultCallback_Set_m_hitPointWorld(btCollisionWorld_ClosestRayResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_hitPointWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitPointWorld(btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_hitPointWorld);
}

const double *btCollisionWorld_ClosestRayResultCallback_Get_m_closestHitFraction(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).m_closestHitFraction);
}

void btCollisionWorld_ClosestRayResultCallback_Set_m_closestHitFraction(btCollisionWorld_ClosestRayResultCallback *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_closestHitFraction = value;
}

double *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_ClosestRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_closestHitFraction);
}

const btCollisionObject *const *btCollisionWorld_ClosestRayResultCallback_Get_m_collisionObject(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (const btCollisionObject *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).m_collisionObject);
}

void btCollisionWorld_ClosestRayResultCallback_Set_m_collisionObject(btCollisionWorld_ClosestRayResultCallback *_this, const btCollisionObject *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_collisionObject = ((const btCollisionObject *)value);
}

const btCollisionObject **btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionObject(btCollisionWorld_ClosestRayResultCallback *_this)
{
    return (const btCollisionObject **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_collisionObject);
}

const int *btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).m_collisionFilterGroup);
}

void btCollisionWorld_ClosestRayResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_ClosestRayResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_collisionFilterGroup = value;
}

int *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_ClosestRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_collisionFilterGroup);
}

const int *btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).m_collisionFilterMask);
}

void btCollisionWorld_ClosestRayResultCallback_Set_m_collisionFilterMask(btCollisionWorld_ClosestRayResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_collisionFilterMask = value;
}

int *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_ClosestRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_collisionFilterMask);
}

const unsigned int *btCollisionWorld_ClosestRayResultCallback_Get_m_flags(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).m_flags);
}

void btCollisionWorld_ClosestRayResultCallback_Set_m_flags(btCollisionWorld_ClosestRayResultCallback *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_flags = value;
}

unsigned int *btCollisionWorld_ClosestRayResultCallback_GetMutable_m_flags(btCollisionWorld_ClosestRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).m_flags);
}

btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionWorld_ClosestRayResultCallback *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionWorld::ClosestRayResultCallback);
    return (btCollisionWorld_ClosestRayResultCallback *)new btCollisionWorld::ClosestRayResultCallback(btCollisionWorld::ClosestRayResultCallback(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionWorld::ClosestRayResultCallback), btCollisionWorld::ClosestRayResultCallback) MRBINDC_CLASSARG_MOVE(_other, (btCollisionWorld::ClosestRayResultCallback), btCollisionWorld::ClosestRayResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionWorld::ClosestRayResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionWorld::ClosestRayResultCallback) MRBINDC_CLASSARG_END(_other, btCollisionWorld::ClosestRayResultCallback))
    ));
}

const btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_OffsetPtr(const btCollisionWorld_ClosestRayResultCallback *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld_ClosestRayResultCallback *)(((const btCollisionWorld::ClosestRayResultCallback *)ptr) + i);
}

btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_OffsetMutablePtr(btCollisionWorld_ClosestRayResultCallback *ptr, ptrdiff_t i)
{
    return (btCollisionWorld_ClosestRayResultCallback *)(((btCollisionWorld::ClosestRayResultCallback *)ptr) + i);
}

const btCollisionWorld_RayResultCallback *btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(const btCollisionWorld_ClosestRayResultCallback *object)
{
    return (const btCollisionWorld_RayResultCallback *)(static_cast<const btCollisionWorld::RayResultCallback *>(
        ((const btCollisionWorld::ClosestRayResultCallback *)object)
    ));
}

btCollisionWorld_RayResultCallback *btCollisionWorld_ClosestRayResultCallback_MutableUpcastTo_btCollisionWorld_RayResultCallback(btCollisionWorld_ClosestRayResultCallback *object)
{
    return (btCollisionWorld_RayResultCallback *)(static_cast<btCollisionWorld::RayResultCallback *>(
        ((btCollisionWorld::ClosestRayResultCallback *)object)
    ));
}

const btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_StaticDowncastFrom_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object)
{
    return (const btCollisionWorld_ClosestRayResultCallback *)(static_cast<const btCollisionWorld::ClosestRayResultCallback *>(
        ((const btCollisionWorld::RayResultCallback *)object)
    ));
}

btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_MutableStaticDowncastFrom_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object)
{
    return (btCollisionWorld_ClosestRayResultCallback *)(static_cast<btCollisionWorld::ClosestRayResultCallback *>(
        ((btCollisionWorld::RayResultCallback *)object)
    ));
}

const btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object)
{
    return (const btCollisionWorld_ClosestRayResultCallback *)(dynamic_cast<const btCollisionWorld::ClosestRayResultCallback *>(
        ((const btCollisionWorld::RayResultCallback *)object)
    ));
}

btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_MutableDynamicDowncastFrom_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object)
{
    return (btCollisionWorld_ClosestRayResultCallback *)(dynamic_cast<btCollisionWorld::ClosestRayResultCallback *>(
        ((btCollisionWorld::RayResultCallback *)object)
    ));
}

const btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFromOrFail_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object)
{
    return (const btCollisionWorld_ClosestRayResultCallback *)std::addressof(dynamic_cast<const btCollisionWorld::ClosestRayResultCallback &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionWorld::RayResultCallback *)(object))
    ));
}

btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_MutableDynamicDowncastFromOrFail_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object)
{
    return (btCollisionWorld_ClosestRayResultCallback *)std::addressof(dynamic_cast<btCollisionWorld::ClosestRayResultCallback &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(object))
    ));
}

btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_Construct(const btVector3 *rayFromWorld, const btVector3 *rayToWorld)
{
    return (btCollisionWorld_ClosestRayResultCallback *)new btCollisionWorld::ClosestRayResultCallback(btCollisionWorld::ClosestRayResultCallback(
        ((rayFromWorld ? void() : MRBINDC_THROW("Parameter `rayFromWorld` can not be null.", void)), *(const btVector3 *)(rayFromWorld)),
        ((rayToWorld ? void() : MRBINDC_THROW("Parameter `rayToWorld` can not be null.", void)), *(const btVector3 *)(rayToWorld))
    ));
}

void btCollisionWorld_ClosestRayResultCallback_Destroy(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    delete ((const btCollisionWorld::ClosestRayResultCallback *)_this);
}

void btCollisionWorld_ClosestRayResultCallback_DestroyArray(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    delete[] ((const btCollisionWorld::ClosestRayResultCallback *)_this);
}

btCollisionWorld_ClosestRayResultCallback *btCollisionWorld_ClosestRayResultCallback_AssignFromAnother(btCollisionWorld_ClosestRayResultCallback *_this, Bullet_PassBy _other_pass_by, btCollisionWorld_ClosestRayResultCallback *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionWorld::ClosestRayResultCallback);
    return (btCollisionWorld_ClosestRayResultCallback *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionWorld::ClosestRayResultCallback), btCollisionWorld::ClosestRayResultCallback) MRBINDC_CLASSARG_MOVE(_other, (btCollisionWorld::ClosestRayResultCallback), btCollisionWorld::ClosestRayResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionWorld::ClosestRayResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionWorld::ClosestRayResultCallback) MRBINDC_CLASSARG_END(_other, btCollisionWorld::ClosestRayResultCallback))
    ));
}

double btCollisionWorld_ClosestRayResultCallback_addSingleResult(btCollisionWorld_ClosestRayResultCallback *_this, btCollisionWorld_LocalRayResult *rayResult, bool normalInWorldSpace)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestRayResultCallback *)(_this)).addSingleResult(
        ((rayResult ? void() : MRBINDC_THROW("Parameter `rayResult` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(rayResult)),
        normalInWorldSpace
    );
}

bool btCollisionWorld_ClosestRayResultCallback_hasHit(const btCollisionWorld_ClosestRayResultCallback *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestRayResultCallback *)(_this)).hasHit();
}

const btVector3 *btCollisionWorld_AllHitsRayResultCallback_Get_m_rayFromWorld(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_rayFromWorld);
}

void btCollisionWorld_AllHitsRayResultCallback_Set_m_rayFromWorld(btCollisionWorld_AllHitsRayResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_rayFromWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayFromWorld(btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_rayFromWorld);
}

const btVector3 *btCollisionWorld_AllHitsRayResultCallback_Get_m_rayToWorld(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_rayToWorld);
}

void btCollisionWorld_AllHitsRayResultCallback_Set_m_rayToWorld(btCollisionWorld_AllHitsRayResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_rayToWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayToWorld(btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_rayToWorld);
}

const double *btCollisionWorld_AllHitsRayResultCallback_Get_m_closestHitFraction(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_closestHitFraction);
}

void btCollisionWorld_AllHitsRayResultCallback_Set_m_closestHitFraction(btCollisionWorld_AllHitsRayResultCallback *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_closestHitFraction = value;
}

double *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_closestHitFraction);
}

const btCollisionObject *const *btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionObject(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return (const btCollisionObject *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_collisionObject);
}

void btCollisionWorld_AllHitsRayResultCallback_Set_m_collisionObject(btCollisionWorld_AllHitsRayResultCallback *_this, const btCollisionObject *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_collisionObject = ((const btCollisionObject *)value);
}

const btCollisionObject **btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionObject(btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return (const btCollisionObject **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_collisionObject);
}

const int *btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_collisionFilterGroup);
}

void btCollisionWorld_AllHitsRayResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_AllHitsRayResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_collisionFilterGroup = value;
}

int *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_collisionFilterGroup);
}

const int *btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_collisionFilterMask);
}

void btCollisionWorld_AllHitsRayResultCallback_Set_m_collisionFilterMask(btCollisionWorld_AllHitsRayResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_collisionFilterMask = value;
}

int *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_collisionFilterMask);
}

const unsigned int *btCollisionWorld_AllHitsRayResultCallback_Get_m_flags(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_flags);
}

void btCollisionWorld_AllHitsRayResultCallback_Set_m_flags(btCollisionWorld_AllHitsRayResultCallback *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_flags = value;
}

unsigned int *btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_flags(btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).m_flags);
}

btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionWorld_AllHitsRayResultCallback *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionWorld::AllHitsRayResultCallback);
    return (btCollisionWorld_AllHitsRayResultCallback *)new btCollisionWorld::AllHitsRayResultCallback(btCollisionWorld::AllHitsRayResultCallback(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionWorld::AllHitsRayResultCallback), btCollisionWorld::AllHitsRayResultCallback) MRBINDC_CLASSARG_MOVE(_other, (btCollisionWorld::AllHitsRayResultCallback), btCollisionWorld::AllHitsRayResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionWorld::AllHitsRayResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionWorld::AllHitsRayResultCallback) MRBINDC_CLASSARG_END(_other, btCollisionWorld::AllHitsRayResultCallback))
    ));
}

const btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_OffsetPtr(const btCollisionWorld_AllHitsRayResultCallback *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld_AllHitsRayResultCallback *)(((const btCollisionWorld::AllHitsRayResultCallback *)ptr) + i);
}

btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_OffsetMutablePtr(btCollisionWorld_AllHitsRayResultCallback *ptr, ptrdiff_t i)
{
    return (btCollisionWorld_AllHitsRayResultCallback *)(((btCollisionWorld::AllHitsRayResultCallback *)ptr) + i);
}

const btCollisionWorld_RayResultCallback *btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(const btCollisionWorld_AllHitsRayResultCallback *object)
{
    return (const btCollisionWorld_RayResultCallback *)(static_cast<const btCollisionWorld::RayResultCallback *>(
        ((const btCollisionWorld::AllHitsRayResultCallback *)object)
    ));
}

btCollisionWorld_RayResultCallback *btCollisionWorld_AllHitsRayResultCallback_MutableUpcastTo_btCollisionWorld_RayResultCallback(btCollisionWorld_AllHitsRayResultCallback *object)
{
    return (btCollisionWorld_RayResultCallback *)(static_cast<btCollisionWorld::RayResultCallback *>(
        ((btCollisionWorld::AllHitsRayResultCallback *)object)
    ));
}

const btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_StaticDowncastFrom_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object)
{
    return (const btCollisionWorld_AllHitsRayResultCallback *)(static_cast<const btCollisionWorld::AllHitsRayResultCallback *>(
        ((const btCollisionWorld::RayResultCallback *)object)
    ));
}

btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_MutableStaticDowncastFrom_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object)
{
    return (btCollisionWorld_AllHitsRayResultCallback *)(static_cast<btCollisionWorld::AllHitsRayResultCallback *>(
        ((btCollisionWorld::RayResultCallback *)object)
    ));
}

const btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object)
{
    return (const btCollisionWorld_AllHitsRayResultCallback *)(dynamic_cast<const btCollisionWorld::AllHitsRayResultCallback *>(
        ((const btCollisionWorld::RayResultCallback *)object)
    ));
}

btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_MutableDynamicDowncastFrom_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object)
{
    return (btCollisionWorld_AllHitsRayResultCallback *)(dynamic_cast<btCollisionWorld::AllHitsRayResultCallback *>(
        ((btCollisionWorld::RayResultCallback *)object)
    ));
}

const btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFromOrFail_btCollisionWorld_RayResultCallback(const btCollisionWorld_RayResultCallback *object)
{
    return (const btCollisionWorld_AllHitsRayResultCallback *)std::addressof(dynamic_cast<const btCollisionWorld::AllHitsRayResultCallback &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionWorld::RayResultCallback *)(object))
    ));
}

btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_MutableDynamicDowncastFromOrFail_btCollisionWorld_RayResultCallback(btCollisionWorld_RayResultCallback *object)
{
    return (btCollisionWorld_AllHitsRayResultCallback *)std::addressof(dynamic_cast<btCollisionWorld::AllHitsRayResultCallback &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(object))
    ));
}

btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_Construct(const btVector3 *rayFromWorld, const btVector3 *rayToWorld)
{
    return (btCollisionWorld_AllHitsRayResultCallback *)new btCollisionWorld::AllHitsRayResultCallback(btCollisionWorld::AllHitsRayResultCallback(
        ((rayFromWorld ? void() : MRBINDC_THROW("Parameter `rayFromWorld` can not be null.", void)), *(const btVector3 *)(rayFromWorld)),
        ((rayToWorld ? void() : MRBINDC_THROW("Parameter `rayToWorld` can not be null.", void)), *(const btVector3 *)(rayToWorld))
    ));
}

void btCollisionWorld_AllHitsRayResultCallback_Destroy(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    delete ((const btCollisionWorld::AllHitsRayResultCallback *)_this);
}

void btCollisionWorld_AllHitsRayResultCallback_DestroyArray(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    delete[] ((const btCollisionWorld::AllHitsRayResultCallback *)_this);
}

btCollisionWorld_AllHitsRayResultCallback *btCollisionWorld_AllHitsRayResultCallback_AssignFromAnother(btCollisionWorld_AllHitsRayResultCallback *_this, Bullet_PassBy _other_pass_by, btCollisionWorld_AllHitsRayResultCallback *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionWorld::AllHitsRayResultCallback);
    return (btCollisionWorld_AllHitsRayResultCallback *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionWorld::AllHitsRayResultCallback), btCollisionWorld::AllHitsRayResultCallback) MRBINDC_CLASSARG_MOVE(_other, (btCollisionWorld::AllHitsRayResultCallback), btCollisionWorld::AllHitsRayResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionWorld::AllHitsRayResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionWorld::AllHitsRayResultCallback) MRBINDC_CLASSARG_END(_other, btCollisionWorld::AllHitsRayResultCallback))
    ));
}

double btCollisionWorld_AllHitsRayResultCallback_addSingleResult(btCollisionWorld_AllHitsRayResultCallback *_this, btCollisionWorld_LocalRayResult *rayResult, bool normalInWorldSpace)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::AllHitsRayResultCallback *)(_this)).addSingleResult(
        ((rayResult ? void() : MRBINDC_THROW("Parameter `rayResult` can not be null.", void)), *(btCollisionWorld::LocalRayResult *)(rayResult)),
        normalInWorldSpace
    );
}

bool btCollisionWorld_AllHitsRayResultCallback_hasHit(const btCollisionWorld_AllHitsRayResultCallback *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::AllHitsRayResultCallback *)(_this)).hasHit();
}

const btCollisionObject *const *btCollisionWorld_LocalConvexResult_Get_m_hitCollisionObject(const btCollisionWorld_LocalConvexResult *_this)
{
    return (const btCollisionObject *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalConvexResult *)(_this)).m_hitCollisionObject);
}

void btCollisionWorld_LocalConvexResult_Set_m_hitCollisionObject(btCollisionWorld_LocalConvexResult *_this, const btCollisionObject *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_hitCollisionObject = ((const btCollisionObject *)value);
}

const btCollisionObject **btCollisionWorld_LocalConvexResult_GetMutable_m_hitCollisionObject(btCollisionWorld_LocalConvexResult *_this)
{
    return (const btCollisionObject **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_hitCollisionObject);
}

btCollisionWorld_LocalShapeInfo *const *btCollisionWorld_LocalConvexResult_Get_m_localShapeInfo(const btCollisionWorld_LocalConvexResult *_this)
{
    return (btCollisionWorld_LocalShapeInfo *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalConvexResult *)(_this)).m_localShapeInfo);
}

void btCollisionWorld_LocalConvexResult_Set_m_localShapeInfo(btCollisionWorld_LocalConvexResult *_this, btCollisionWorld_LocalShapeInfo *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_localShapeInfo = ((btCollisionWorld::LocalShapeInfo *)value);
}

btCollisionWorld_LocalShapeInfo **btCollisionWorld_LocalConvexResult_GetMutable_m_localShapeInfo(btCollisionWorld_LocalConvexResult *_this)
{
    return (btCollisionWorld_LocalShapeInfo **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_localShapeInfo);
}

const btVector3 *btCollisionWorld_LocalConvexResult_Get_m_hitNormalLocal(const btCollisionWorld_LocalConvexResult *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalConvexResult *)(_this)).m_hitNormalLocal);
}

void btCollisionWorld_LocalConvexResult_Set_m_hitNormalLocal(btCollisionWorld_LocalConvexResult *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_hitNormalLocal = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_LocalConvexResult_GetMutable_m_hitNormalLocal(btCollisionWorld_LocalConvexResult *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_hitNormalLocal);
}

const btVector3 *btCollisionWorld_LocalConvexResult_Get_m_hitPointLocal(const btCollisionWorld_LocalConvexResult *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalConvexResult *)(_this)).m_hitPointLocal);
}

void btCollisionWorld_LocalConvexResult_Set_m_hitPointLocal(btCollisionWorld_LocalConvexResult *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_hitPointLocal = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_LocalConvexResult_GetMutable_m_hitPointLocal(btCollisionWorld_LocalConvexResult *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_hitPointLocal);
}

const double *btCollisionWorld_LocalConvexResult_Get_m_hitFraction(const btCollisionWorld_LocalConvexResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::LocalConvexResult *)(_this)).m_hitFraction);
}

void btCollisionWorld_LocalConvexResult_Set_m_hitFraction(btCollisionWorld_LocalConvexResult *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_hitFraction = value;
}

double *btCollisionWorld_LocalConvexResult_GetMutable_m_hitFraction(btCollisionWorld_LocalConvexResult *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).m_hitFraction);
}

btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_ConstructFromAnother(const btCollisionWorld_LocalConvexResult *_other)
{
    return (btCollisionWorld_LocalConvexResult *)new btCollisionWorld::LocalConvexResult(btCollisionWorld::LocalConvexResult(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btCollisionWorld::LocalConvexResult(*(btCollisionWorld::LocalConvexResult *)_other))
    ));
}

const btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_OffsetPtr(const btCollisionWorld_LocalConvexResult *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld_LocalConvexResult *)(((const btCollisionWorld::LocalConvexResult *)ptr) + i);
}

btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_OffsetMutablePtr(btCollisionWorld_LocalConvexResult *ptr, ptrdiff_t i)
{
    return (btCollisionWorld_LocalConvexResult *)(((btCollisionWorld::LocalConvexResult *)ptr) + i);
}

btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_Construct(const btCollisionObject *hitCollisionObject, btCollisionWorld_LocalShapeInfo *localShapeInfo, const btVector3 *hitNormalLocal, const btVector3 *hitPointLocal, double hitFraction)
{
    return (btCollisionWorld_LocalConvexResult *)new btCollisionWorld::LocalConvexResult(btCollisionWorld::LocalConvexResult(
        ((const btCollisionObject *)hitCollisionObject),
        ((btCollisionWorld::LocalShapeInfo *)localShapeInfo),
        ((hitNormalLocal ? void() : MRBINDC_THROW("Parameter `hitNormalLocal` can not be null.", void)), *(const btVector3 *)(hitNormalLocal)),
        ((hitPointLocal ? void() : MRBINDC_THROW("Parameter `hitPointLocal` can not be null.", void)), *(const btVector3 *)(hitPointLocal)),
        hitFraction
    ));
}

void btCollisionWorld_LocalConvexResult_Destroy(const btCollisionWorld_LocalConvexResult *_this)
{
    delete ((const btCollisionWorld::LocalConvexResult *)_this);
}

void btCollisionWorld_LocalConvexResult_DestroyArray(const btCollisionWorld_LocalConvexResult *_this)
{
    delete[] ((const btCollisionWorld::LocalConvexResult *)_this);
}

btCollisionWorld_LocalConvexResult *btCollisionWorld_LocalConvexResult_AssignFromAnother(btCollisionWorld_LocalConvexResult *_this, const btCollisionWorld_LocalConvexResult *_other)
{
    return (btCollisionWorld_LocalConvexResult *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btCollisionWorld::LocalConvexResult(*(btCollisionWorld::LocalConvexResult *)_other))
    ));
}

const double *btCollisionWorld_ConvexResultCallback_Get_m_closestHitFraction(const btCollisionWorld_ConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ConvexResultCallback *)(_this)).m_closestHitFraction);
}

void btCollisionWorld_ConvexResultCallback_Set_m_closestHitFraction(btCollisionWorld_ConvexResultCallback *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(_this)).m_closestHitFraction = value;
}

double *btCollisionWorld_ConvexResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_ConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(_this)).m_closestHitFraction);
}

const int *btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_ConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ConvexResultCallback *)(_this)).m_collisionFilterGroup);
}

void btCollisionWorld_ConvexResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_ConvexResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(_this)).m_collisionFilterGroup = value;
}

int *btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_ConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(_this)).m_collisionFilterGroup);
}

const int *btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_ConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ConvexResultCallback *)(_this)).m_collisionFilterMask);
}

void btCollisionWorld_ConvexResultCallback_Set_m_collisionFilterMask(btCollisionWorld_ConvexResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(_this)).m_collisionFilterMask = value;
}

int *btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_ConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(_this)).m_collisionFilterMask);
}

void btCollisionWorld_ConvexResultCallback_Destroy(const btCollisionWorld_ConvexResultCallback *_this)
{
    delete ((const btCollisionWorld::ConvexResultCallback *)_this);
}

void btCollisionWorld_ConvexResultCallback_DestroyArray(const btCollisionWorld_ConvexResultCallback *_this)
{
    delete[] ((const btCollisionWorld::ConvexResultCallback *)_this);
}

bool btCollisionWorld_ConvexResultCallback_hasHit(const btCollisionWorld_ConvexResultCallback *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ConvexResultCallback *)(_this)).hasHit();
}

double btCollisionWorld_ConvexResultCallback_addSingleResult(btCollisionWorld_ConvexResultCallback *_this, btCollisionWorld_LocalConvexResult *convexResult, bool normalInWorldSpace)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(_this)).addSingleResult(
        ((convexResult ? void() : MRBINDC_THROW("Parameter `convexResult` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(convexResult)),
        normalInWorldSpace
    );
}

const btCollisionWorld_ConvexResultCallback *btCollisionWorld_ConvexResultCallback_OffsetPtr(const btCollisionWorld_ConvexResultCallback *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld_ConvexResultCallback *)(((const btCollisionWorld::ConvexResultCallback *)ptr) + i);
}

btCollisionWorld_ConvexResultCallback *btCollisionWorld_ConvexResultCallback_OffsetMutablePtr(btCollisionWorld_ConvexResultCallback *ptr, ptrdiff_t i)
{
    return (btCollisionWorld_ConvexResultCallback *)(((btCollisionWorld::ConvexResultCallback *)ptr) + i);
}

const btVector3 *btCollisionWorld_ClosestConvexResultCallback_Get_m_convexFromWorld(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_convexFromWorld);
}

void btCollisionWorld_ClosestConvexResultCallback_Set_m_convexFromWorld(btCollisionWorld_ClosestConvexResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_convexFromWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexFromWorld(btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_convexFromWorld);
}

const btVector3 *btCollisionWorld_ClosestConvexResultCallback_Get_m_convexToWorld(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_convexToWorld);
}

void btCollisionWorld_ClosestConvexResultCallback_Set_m_convexToWorld(btCollisionWorld_ClosestConvexResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_convexToWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexToWorld(btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_convexToWorld);
}

const btVector3 *btCollisionWorld_ClosestConvexResultCallback_Get_m_hitNormalWorld(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_hitNormalWorld);
}

void btCollisionWorld_ClosestConvexResultCallback_Set_m_hitNormalWorld(btCollisionWorld_ClosestConvexResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_hitNormalWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitNormalWorld(btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_hitNormalWorld);
}

const btVector3 *btCollisionWorld_ClosestConvexResultCallback_Get_m_hitPointWorld(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_hitPointWorld);
}

void btCollisionWorld_ClosestConvexResultCallback_Set_m_hitPointWorld(btCollisionWorld_ClosestConvexResultCallback *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_hitPointWorld = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitPointWorld(btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_hitPointWorld);
}

const btCollisionObject *const *btCollisionWorld_ClosestConvexResultCallback_Get_m_hitCollisionObject(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (const btCollisionObject *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_hitCollisionObject);
}

void btCollisionWorld_ClosestConvexResultCallback_Set_m_hitCollisionObject(btCollisionWorld_ClosestConvexResultCallback *_this, const btCollisionObject *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_hitCollisionObject = ((const btCollisionObject *)value);
}

const btCollisionObject **btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitCollisionObject(btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return (const btCollisionObject **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_hitCollisionObject);
}

const double *btCollisionWorld_ClosestConvexResultCallback_Get_m_closestHitFraction(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_closestHitFraction);
}

void btCollisionWorld_ClosestConvexResultCallback_Set_m_closestHitFraction(btCollisionWorld_ClosestConvexResultCallback *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_closestHitFraction = value;
}

double *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_closestHitFraction(btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_closestHitFraction);
}

const int *btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_collisionFilterGroup);
}

void btCollisionWorld_ClosestConvexResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_ClosestConvexResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_collisionFilterGroup = value;
}

int *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_collisionFilterGroup);
}

const int *btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_collisionFilterMask);
}

void btCollisionWorld_ClosestConvexResultCallback_Set_m_collisionFilterMask(btCollisionWorld_ClosestConvexResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_collisionFilterMask = value;
}

int *btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).m_collisionFilterMask);
}

btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionWorld_ClosestConvexResultCallback *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionWorld::ClosestConvexResultCallback);
    return (btCollisionWorld_ClosestConvexResultCallback *)new btCollisionWorld::ClosestConvexResultCallback(btCollisionWorld::ClosestConvexResultCallback(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionWorld::ClosestConvexResultCallback), btCollisionWorld::ClosestConvexResultCallback) MRBINDC_CLASSARG_MOVE(_other, (btCollisionWorld::ClosestConvexResultCallback), btCollisionWorld::ClosestConvexResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionWorld::ClosestConvexResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionWorld::ClosestConvexResultCallback) MRBINDC_CLASSARG_END(_other, btCollisionWorld::ClosestConvexResultCallback))
    ));
}

const btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_OffsetPtr(const btCollisionWorld_ClosestConvexResultCallback *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld_ClosestConvexResultCallback *)(((const btCollisionWorld::ClosestConvexResultCallback *)ptr) + i);
}

btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_OffsetMutablePtr(btCollisionWorld_ClosestConvexResultCallback *ptr, ptrdiff_t i)
{
    return (btCollisionWorld_ClosestConvexResultCallback *)(((btCollisionWorld::ClosestConvexResultCallback *)ptr) + i);
}

const btCollisionWorld_ConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback(const btCollisionWorld_ClosestConvexResultCallback *object)
{
    return (const btCollisionWorld_ConvexResultCallback *)(static_cast<const btCollisionWorld::ConvexResultCallback *>(
        ((const btCollisionWorld::ClosestConvexResultCallback *)object)
    ));
}

btCollisionWorld_ConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_MutableUpcastTo_btCollisionWorld_ConvexResultCallback(btCollisionWorld_ClosestConvexResultCallback *object)
{
    return (btCollisionWorld_ConvexResultCallback *)(static_cast<btCollisionWorld::ConvexResultCallback *>(
        ((btCollisionWorld::ClosestConvexResultCallback *)object)
    ));
}

const btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_StaticDowncastFrom_btCollisionWorld_ConvexResultCallback(const btCollisionWorld_ConvexResultCallback *object)
{
    return (const btCollisionWorld_ClosestConvexResultCallback *)(static_cast<const btCollisionWorld::ClosestConvexResultCallback *>(
        ((const btCollisionWorld::ConvexResultCallback *)object)
    ));
}

btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_MutableStaticDowncastFrom_btCollisionWorld_ConvexResultCallback(btCollisionWorld_ConvexResultCallback *object)
{
    return (btCollisionWorld_ClosestConvexResultCallback *)(static_cast<btCollisionWorld::ClosestConvexResultCallback *>(
        ((btCollisionWorld::ConvexResultCallback *)object)
    ));
}

const btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback(const btCollisionWorld_ConvexResultCallback *object)
{
    return (const btCollisionWorld_ClosestConvexResultCallback *)(dynamic_cast<const btCollisionWorld::ClosestConvexResultCallback *>(
        ((const btCollisionWorld::ConvexResultCallback *)object)
    ));
}

btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_MutableDynamicDowncastFrom_btCollisionWorld_ConvexResultCallback(btCollisionWorld_ConvexResultCallback *object)
{
    return (btCollisionWorld_ClosestConvexResultCallback *)(dynamic_cast<btCollisionWorld::ClosestConvexResultCallback *>(
        ((btCollisionWorld::ConvexResultCallback *)object)
    ));
}

const btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFromOrFail_btCollisionWorld_ConvexResultCallback(const btCollisionWorld_ConvexResultCallback *object)
{
    return (const btCollisionWorld_ClosestConvexResultCallback *)std::addressof(dynamic_cast<const btCollisionWorld::ClosestConvexResultCallback &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionWorld::ConvexResultCallback *)(object))
    ));
}

btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_MutableDynamicDowncastFromOrFail_btCollisionWorld_ConvexResultCallback(btCollisionWorld_ConvexResultCallback *object)
{
    return (btCollisionWorld_ClosestConvexResultCallback *)std::addressof(dynamic_cast<btCollisionWorld::ClosestConvexResultCallback &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(object))
    ));
}

btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_Construct(const btVector3 *convexFromWorld, const btVector3 *convexToWorld)
{
    return (btCollisionWorld_ClosestConvexResultCallback *)new btCollisionWorld::ClosestConvexResultCallback(btCollisionWorld::ClosestConvexResultCallback(
        ((convexFromWorld ? void() : MRBINDC_THROW("Parameter `convexFromWorld` can not be null.", void)), *(const btVector3 *)(convexFromWorld)),
        ((convexToWorld ? void() : MRBINDC_THROW("Parameter `convexToWorld` can not be null.", void)), *(const btVector3 *)(convexToWorld))
    ));
}

void btCollisionWorld_ClosestConvexResultCallback_Destroy(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    delete ((const btCollisionWorld::ClosestConvexResultCallback *)_this);
}

void btCollisionWorld_ClosestConvexResultCallback_DestroyArray(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    delete[] ((const btCollisionWorld::ClosestConvexResultCallback *)_this);
}

btCollisionWorld_ClosestConvexResultCallback *btCollisionWorld_ClosestConvexResultCallback_AssignFromAnother(btCollisionWorld_ClosestConvexResultCallback *_this, Bullet_PassBy _other_pass_by, btCollisionWorld_ClosestConvexResultCallback *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionWorld::ClosestConvexResultCallback);
    return (btCollisionWorld_ClosestConvexResultCallback *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionWorld::ClosestConvexResultCallback), btCollisionWorld::ClosestConvexResultCallback) MRBINDC_CLASSARG_MOVE(_other, (btCollisionWorld::ClosestConvexResultCallback), btCollisionWorld::ClosestConvexResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionWorld::ClosestConvexResultCallback) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionWorld::ClosestConvexResultCallback) MRBINDC_CLASSARG_END(_other, btCollisionWorld::ClosestConvexResultCallback))
    ));
}

double btCollisionWorld_ClosestConvexResultCallback_addSingleResult(btCollisionWorld_ClosestConvexResultCallback *_this, btCollisionWorld_LocalConvexResult *convexResult, bool normalInWorldSpace)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ClosestConvexResultCallback *)(_this)).addSingleResult(
        ((convexResult ? void() : MRBINDC_THROW("Parameter `convexResult` can not be null.", void)), *(btCollisionWorld::LocalConvexResult *)(convexResult)),
        normalInWorldSpace
    );
}

bool btCollisionWorld_ClosestConvexResultCallback_hasHit(const btCollisionWorld_ClosestConvexResultCallback *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ClosestConvexResultCallback *)(_this)).hasHit();
}

const int *btCollisionWorld_ContactResultCallback_Get_m_collisionFilterGroup(const btCollisionWorld_ContactResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ContactResultCallback *)(_this)).m_collisionFilterGroup);
}

void btCollisionWorld_ContactResultCallback_Set_m_collisionFilterGroup(btCollisionWorld_ContactResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(_this)).m_collisionFilterGroup = value;
}

int *btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterGroup(btCollisionWorld_ContactResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(_this)).m_collisionFilterGroup);
}

const int *btCollisionWorld_ContactResultCallback_Get_m_collisionFilterMask(const btCollisionWorld_ContactResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ContactResultCallback *)(_this)).m_collisionFilterMask);
}

void btCollisionWorld_ContactResultCallback_Set_m_collisionFilterMask(btCollisionWorld_ContactResultCallback *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(_this)).m_collisionFilterMask = value;
}

int *btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterMask(btCollisionWorld_ContactResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(_this)).m_collisionFilterMask);
}

const double *btCollisionWorld_ContactResultCallback_Get_m_closestDistanceThreshold(const btCollisionWorld_ContactResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionWorld::ContactResultCallback *)(_this)).m_closestDistanceThreshold);
}

void btCollisionWorld_ContactResultCallback_Set_m_closestDistanceThreshold(btCollisionWorld_ContactResultCallback *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(_this)).m_closestDistanceThreshold = value;
}

double *btCollisionWorld_ContactResultCallback_GetMutable_m_closestDistanceThreshold(btCollisionWorld_ContactResultCallback *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(_this)).m_closestDistanceThreshold);
}

void btCollisionWorld_ContactResultCallback_Destroy(const btCollisionWorld_ContactResultCallback *_this)
{
    delete ((const btCollisionWorld::ContactResultCallback *)_this);
}

void btCollisionWorld_ContactResultCallback_DestroyArray(const btCollisionWorld_ContactResultCallback *_this)
{
    delete[] ((const btCollisionWorld::ContactResultCallback *)_this);
}

const btCollisionWorld_ContactResultCallback *btCollisionWorld_ContactResultCallback_OffsetPtr(const btCollisionWorld_ContactResultCallback *ptr, ptrdiff_t i)
{
    return (const btCollisionWorld_ContactResultCallback *)(((const btCollisionWorld::ContactResultCallback *)ptr) + i);
}

btCollisionWorld_ContactResultCallback *btCollisionWorld_ContactResultCallback_OffsetMutablePtr(btCollisionWorld_ContactResultCallback *ptr, ptrdiff_t i)
{
    return (btCollisionWorld_ContactResultCallback *)(((btCollisionWorld::ContactResultCallback *)ptr) + i);
}

