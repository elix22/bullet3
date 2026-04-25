// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/BroadphaseCollision/btDbvtBroadphase.h"

#include <BulletCollision/BroadphaseCollision/btBroadphaseInterface.h>
#include <BulletCollision/BroadphaseCollision/btDbvtBroadphase.h>
#include <BulletCollision/BroadphaseCollision/btDispatcher.h>
#include <BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btOverlappingPairCache *const *btDbvtBroadphase_Get_m_paircache(const btDbvtBroadphase *_this)
{
    return (btOverlappingPairCache *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_paircache);
}

void btDbvtBroadphase_Set_m_paircache(btDbvtBroadphase *_this, btOverlappingPairCache *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_paircache = ((btOverlappingPairCache *)value);
}

btOverlappingPairCache **btDbvtBroadphase_GetMutable_m_paircache(btDbvtBroadphase *_this)
{
    return (btOverlappingPairCache **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_paircache);
}

const double *btDbvtBroadphase_Get_m_prediction(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_prediction);
}

void btDbvtBroadphase_Set_m_prediction(btDbvtBroadphase *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_prediction = value;
}

double *btDbvtBroadphase_GetMutable_m_prediction(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_prediction);
}

const int *btDbvtBroadphase_Get_m_stageCurrent(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_stageCurrent);
}

void btDbvtBroadphase_Set_m_stageCurrent(btDbvtBroadphase *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_stageCurrent = value;
}

int *btDbvtBroadphase_GetMutable_m_stageCurrent(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_stageCurrent);
}

const int *btDbvtBroadphase_Get_m_fupdates(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_fupdates);
}

void btDbvtBroadphase_Set_m_fupdates(btDbvtBroadphase *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_fupdates = value;
}

int *btDbvtBroadphase_GetMutable_m_fupdates(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_fupdates);
}

const int *btDbvtBroadphase_Get_m_dupdates(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_dupdates);
}

void btDbvtBroadphase_Set_m_dupdates(btDbvtBroadphase *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_dupdates = value;
}

int *btDbvtBroadphase_GetMutable_m_dupdates(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_dupdates);
}

const int *btDbvtBroadphase_Get_m_cupdates(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_cupdates);
}

void btDbvtBroadphase_Set_m_cupdates(btDbvtBroadphase *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_cupdates = value;
}

int *btDbvtBroadphase_GetMutable_m_cupdates(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_cupdates);
}

const int *btDbvtBroadphase_Get_m_newpairs(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_newpairs);
}

void btDbvtBroadphase_Set_m_newpairs(btDbvtBroadphase *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_newpairs = value;
}

int *btDbvtBroadphase_GetMutable_m_newpairs(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_newpairs);
}

const int *btDbvtBroadphase_Get_m_fixedleft(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_fixedleft);
}

void btDbvtBroadphase_Set_m_fixedleft(btDbvtBroadphase *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_fixedleft = value;
}

int *btDbvtBroadphase_GetMutable_m_fixedleft(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_fixedleft);
}

const unsigned int *btDbvtBroadphase_Get_m_updates_call(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_updates_call);
}

void btDbvtBroadphase_Set_m_updates_call(btDbvtBroadphase *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_updates_call = value;
}

unsigned int *btDbvtBroadphase_GetMutable_m_updates_call(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_updates_call);
}

const unsigned int *btDbvtBroadphase_Get_m_updates_done(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_updates_done);
}

void btDbvtBroadphase_Set_m_updates_done(btDbvtBroadphase *_this, unsigned int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_updates_done = value;
}

unsigned int *btDbvtBroadphase_GetMutable_m_updates_done(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_updates_done);
}

const double *btDbvtBroadphase_Get_m_updates_ratio(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_updates_ratio);
}

void btDbvtBroadphase_Set_m_updates_ratio(btDbvtBroadphase *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_updates_ratio = value;
}

double *btDbvtBroadphase_GetMutable_m_updates_ratio(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_updates_ratio);
}

const int *btDbvtBroadphase_Get_m_pid(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_pid);
}

void btDbvtBroadphase_Set_m_pid(btDbvtBroadphase *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_pid = value;
}

int *btDbvtBroadphase_GetMutable_m_pid(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_pid);
}

const int *btDbvtBroadphase_Get_m_cid(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_cid);
}

void btDbvtBroadphase_Set_m_cid(btDbvtBroadphase *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_cid = value;
}

int *btDbvtBroadphase_GetMutable_m_cid(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_cid);
}

const int *btDbvtBroadphase_Get_m_gid(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_gid);
}

void btDbvtBroadphase_Set_m_gid(btDbvtBroadphase *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_gid = value;
}

int *btDbvtBroadphase_GetMutable_m_gid(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_gid);
}

const bool *btDbvtBroadphase_Get_m_releasepaircache(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_releasepaircache);
}

void btDbvtBroadphase_Set_m_releasepaircache(btDbvtBroadphase *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_releasepaircache = value;
}

bool *btDbvtBroadphase_GetMutable_m_releasepaircache(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_releasepaircache);
}

const bool *btDbvtBroadphase_Get_m_deferedcollide(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_deferedcollide);
}

void btDbvtBroadphase_Set_m_deferedcollide(btDbvtBroadphase *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_deferedcollide = value;
}

bool *btDbvtBroadphase_GetMutable_m_deferedcollide(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_deferedcollide);
}

const bool *btDbvtBroadphase_Get_m_needcleanup(const btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).m_needcleanup);
}

void btDbvtBroadphase_Set_m_needcleanup(btDbvtBroadphase *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_needcleanup = value;
}

bool *btDbvtBroadphase_GetMutable_m_needcleanup(btDbvtBroadphase *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).m_needcleanup);
}

btDbvtBroadphase *btDbvtBroadphase_Construct(btOverlappingPairCache *paircache)
{
    return (btDbvtBroadphase *)new btDbvtBroadphase(btDbvtBroadphase(
        ((btOverlappingPairCache *)paircache)
    ));
}

btDbvtBroadphase *btDbvtBroadphase_DefaultConstructArray(size_t num_elems)
{
    return (btDbvtBroadphase *)(new btDbvtBroadphase[num_elems]{});
}

const btDbvtBroadphase *btDbvtBroadphase_OffsetPtr(const btDbvtBroadphase *ptr, ptrdiff_t i)
{
    return (const btDbvtBroadphase *)(((const btDbvtBroadphase *)ptr) + i);
}

btDbvtBroadphase *btDbvtBroadphase_OffsetMutablePtr(btDbvtBroadphase *ptr, ptrdiff_t i)
{
    return (btDbvtBroadphase *)(((btDbvtBroadphase *)ptr) + i);
}

const btBroadphaseInterface *btDbvtBroadphase_UpcastTo_btBroadphaseInterface(const btDbvtBroadphase *object)
{
    return (const btBroadphaseInterface *)(static_cast<const btBroadphaseInterface *>(
        ((const btDbvtBroadphase *)object)
    ));
}

btBroadphaseInterface *btDbvtBroadphase_MutableUpcastTo_btBroadphaseInterface(btDbvtBroadphase *object)
{
    return (btBroadphaseInterface *)(static_cast<btBroadphaseInterface *>(
        ((btDbvtBroadphase *)object)
    ));
}

const btDbvtBroadphase *btDbvtBroadphase_StaticDowncastFrom_btBroadphaseInterface(const btBroadphaseInterface *object)
{
    return (const btDbvtBroadphase *)(static_cast<const btDbvtBroadphase *>(
        ((const btBroadphaseInterface *)object)
    ));
}

btDbvtBroadphase *btDbvtBroadphase_MutableStaticDowncastFrom_btBroadphaseInterface(btBroadphaseInterface *object)
{
    return (btDbvtBroadphase *)(static_cast<btDbvtBroadphase *>(
        ((btBroadphaseInterface *)object)
    ));
}

const btDbvtBroadphase *btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface(const btBroadphaseInterface *object)
{
    return (const btDbvtBroadphase *)(dynamic_cast<const btDbvtBroadphase *>(
        ((const btBroadphaseInterface *)object)
    ));
}

btDbvtBroadphase *btDbvtBroadphase_MutableDynamicDowncastFrom_btBroadphaseInterface(btBroadphaseInterface *object)
{
    return (btDbvtBroadphase *)(dynamic_cast<btDbvtBroadphase *>(
        ((btBroadphaseInterface *)object)
    ));
}

const btDbvtBroadphase *btDbvtBroadphase_DynamicDowncastFromOrFail_btBroadphaseInterface(const btBroadphaseInterface *object)
{
    return (const btDbvtBroadphase *)std::addressof(dynamic_cast<const btDbvtBroadphase &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btBroadphaseInterface *)(object))
    ));
}

btDbvtBroadphase *btDbvtBroadphase_MutableDynamicDowncastFromOrFail_btBroadphaseInterface(btBroadphaseInterface *object)
{
    return (btDbvtBroadphase *)std::addressof(dynamic_cast<btDbvtBroadphase &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btBroadphaseInterface *)(object))
    ));
}

void btDbvtBroadphase_Destroy(const btDbvtBroadphase *_this)
{
    delete ((const btDbvtBroadphase *)_this);
}

void btDbvtBroadphase_DestroyArray(const btDbvtBroadphase *_this)
{
    delete[] ((const btDbvtBroadphase *)_this);
}

btDbvtBroadphase *btDbvtBroadphase_AssignFromAnother(btDbvtBroadphase *_this, Bullet_PassBy _other_pass_by, btDbvtBroadphase *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btDbvtBroadphase);
    return (btDbvtBroadphase *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, btDbvtBroadphase) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btDbvtBroadphase) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btDbvtBroadphase) MRBINDC_CLASSARG_END(_other, btDbvtBroadphase)))
    ));
}

void btDbvtBroadphase_collide(btDbvtBroadphase *_this, btDispatcher *dispatcher)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).collide(
        ((btDispatcher *)dispatcher)
    );
}

void btDbvtBroadphase_optimize(btDbvtBroadphase *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).optimize();
}

void btDbvtBroadphase_calculateOverlappingPairs(btDbvtBroadphase *_this, btDispatcher *dispatcher)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).calculateOverlappingPairs(
        ((btDispatcher *)dispatcher)
    );
}

btOverlappingPairCache *btDbvtBroadphase_getOverlappingPairCache_mut(btDbvtBroadphase *_this)
{
    return (btOverlappingPairCache *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).getOverlappingPairCache());
}

const btOverlappingPairCache *btDbvtBroadphase_getOverlappingPairCache(const btDbvtBroadphase *_this)
{
    return (const btOverlappingPairCache *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).getOverlappingPairCache());
}

void btDbvtBroadphase_getBroadphaseAabb(const btDbvtBroadphase *_this, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).getBroadphaseAabb(
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btDbvtBroadphase_printStats(btDbvtBroadphase *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).printStats();
}

void btDbvtBroadphase_resetPool(btDbvtBroadphase *_this, btDispatcher *dispatcher)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).resetPool(
        ((btDispatcher *)dispatcher)
    );
}

void btDbvtBroadphase_performDeferredRemoval(btDbvtBroadphase *_this, btDispatcher *dispatcher)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).performDeferredRemoval(
        ((btDispatcher *)dispatcher)
    );
}

void btDbvtBroadphase_setVelocityPrediction(btDbvtBroadphase *_this, double prediction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDbvtBroadphase *)(_this)).setVelocityPrediction(
        prediction
    );
}

double btDbvtBroadphase_getVelocityPrediction(const btDbvtBroadphase *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDbvtBroadphase *)(_this)).getVelocityPrediction();
}

void btDbvtBroadphase_benchmark(btBroadphaseInterface *_1)
{
    btDbvtBroadphase::benchmark(
        ((btBroadphaseInterface *)_1)
    );
}

