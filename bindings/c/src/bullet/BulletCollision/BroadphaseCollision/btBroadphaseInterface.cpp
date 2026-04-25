// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/BroadphaseCollision/btBroadphaseInterface.h"

#include <BulletCollision/BroadphaseCollision/btBroadphaseInterface.h>
#include <BulletCollision/BroadphaseCollision/btDispatcher.h>
#include <BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void btBroadphaseInterface_Destroy(const btBroadphaseInterface *_this)
{
    delete ((const btBroadphaseInterface *)_this);
}

void btBroadphaseInterface_DestroyArray(const btBroadphaseInterface *_this)
{
    delete[] ((const btBroadphaseInterface *)_this);
}

void btBroadphaseInterface_calculateOverlappingPairs(btBroadphaseInterface *_this, btDispatcher *dispatcher)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBroadphaseInterface *)(_this)).calculateOverlappingPairs(
        ((btDispatcher *)dispatcher)
    );
}

btOverlappingPairCache *btBroadphaseInterface_getOverlappingPairCache_mut(btBroadphaseInterface *_this)
{
    return (btOverlappingPairCache *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBroadphaseInterface *)(_this)).getOverlappingPairCache());
}

const btOverlappingPairCache *btBroadphaseInterface_getOverlappingPairCache(const btBroadphaseInterface *_this)
{
    return (const btOverlappingPairCache *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBroadphaseInterface *)(_this)).getOverlappingPairCache());
}

void btBroadphaseInterface_getBroadphaseAabb(const btBroadphaseInterface *_this, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBroadphaseInterface *)(_this)).getBroadphaseAabb(
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btBroadphaseInterface_resetPool(btBroadphaseInterface *_this, btDispatcher *dispatcher)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBroadphaseInterface *)(_this)).resetPool(
        ((btDispatcher *)dispatcher)
    );
}

void btBroadphaseInterface_printStats(btBroadphaseInterface *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBroadphaseInterface *)(_this)).printStats();
}

const btBroadphaseInterface *btBroadphaseInterface_OffsetPtr(const btBroadphaseInterface *ptr, ptrdiff_t i)
{
    return (const btBroadphaseInterface *)(((const btBroadphaseInterface *)ptr) + i);
}

btBroadphaseInterface *btBroadphaseInterface_OffsetMutablePtr(btBroadphaseInterface *ptr, ptrdiff_t i)
{
    return (btBroadphaseInterface *)(((btBroadphaseInterface *)ptr) + i);
}

