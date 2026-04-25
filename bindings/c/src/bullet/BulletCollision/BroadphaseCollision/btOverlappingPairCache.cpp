// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/BroadphaseCollision/btOverlappingPairCache.h"

#include <BulletCollision/BroadphaseCollision/btDispatcher.h>
#include <BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void btOverlappingPairCache_Destroy(const btOverlappingPairCache *_this)
{
    delete ((const btOverlappingPairCache *)_this);
}

void btOverlappingPairCache_DestroyArray(const btOverlappingPairCache *_this)
{
    delete[] ((const btOverlappingPairCache *)_this);
}

int btOverlappingPairCache_getNumOverlappingPairs(const btOverlappingPairCache *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btOverlappingPairCache *)(_this)).getNumOverlappingPairs();
}

bool btOverlappingPairCache_hasDeferredRemoval(btOverlappingPairCache *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btOverlappingPairCache *)(_this)).hasDeferredRemoval();
}

void btOverlappingPairCache_sortOverlappingPairs(btOverlappingPairCache *_this, btDispatcher *dispatcher)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btOverlappingPairCache *)(_this)).sortOverlappingPairs(
        ((btDispatcher *)dispatcher)
    );
}

const btOverlappingPairCache *btOverlappingPairCache_OffsetPtr(const btOverlappingPairCache *ptr, ptrdiff_t i)
{
    return (const btOverlappingPairCache *)(((const btOverlappingPairCache *)ptr) + i);
}

btOverlappingPairCache *btOverlappingPairCache_OffsetMutablePtr(btOverlappingPairCache *ptr, ptrdiff_t i)
{
    return (btOverlappingPairCache *)(((btOverlappingPairCache *)ptr) + i);
}

