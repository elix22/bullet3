// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/BroadphaseCollision/btDispatcher.h"

#include <BulletCollision/BroadphaseCollision/btDispatcher.h>
#include <BulletCollision/CollisionDispatch/btCollisionObject.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void btDispatcher_Destroy(const btDispatcher *_this)
{
    delete ((const btDispatcher *)_this);
}

void btDispatcher_DestroyArray(const btDispatcher *_this)
{
    delete[] ((const btDispatcher *)_this);
}

bool btDispatcher_needsCollision(btDispatcher *_this, const btCollisionObject *body0, const btCollisionObject *body1)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDispatcher *)(_this)).needsCollision(
        ((const btCollisionObject *)body0),
        ((const btCollisionObject *)body1)
    );
}

bool btDispatcher_needsResponse(btDispatcher *_this, const btCollisionObject *body0, const btCollisionObject *body1)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDispatcher *)(_this)).needsResponse(
        ((const btCollisionObject *)body0),
        ((const btCollisionObject *)body1)
    );
}

int btDispatcher_getNumManifolds(const btDispatcher *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDispatcher *)(_this)).getNumManifolds();
}

void *btDispatcher_allocateCollisionAlgorithm(btDispatcher *_this, int size)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDispatcher *)(_this)).allocateCollisionAlgorithm(
        size
    );
}

void btDispatcher_freeCollisionAlgorithm(btDispatcher *_this, void *ptr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDispatcher *)(_this)).freeCollisionAlgorithm(
        ptr
    );
}

const btDispatcher *btDispatcher_OffsetPtr(const btDispatcher *ptr, ptrdiff_t i)
{
    return (const btDispatcher *)(((const btDispatcher *)ptr) + i);
}

btDispatcher *btDispatcher_OffsetMutablePtr(btDispatcher *ptr, ptrdiff_t i)
{
    return (btDispatcher *)(((btDispatcher *)ptr) + i);
}

