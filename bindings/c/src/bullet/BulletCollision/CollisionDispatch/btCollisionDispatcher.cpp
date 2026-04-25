// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionDispatch/btCollisionDispatcher.h"

#include <BulletCollision/BroadphaseCollision/btDispatcher.h>
#include <BulletCollision/CollisionDispatch/btCollisionConfiguration.h>
#include <BulletCollision/CollisionDispatch/btCollisionDispatcher.h>
#include <BulletCollision/CollisionDispatch/btCollisionObject.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btCollisionDispatcher *btCollisionDispatcher_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionDispatcher *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionDispatcher);
    return (btCollisionDispatcher *)new btCollisionDispatcher(btCollisionDispatcher(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionDispatcher), btCollisionDispatcher) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionDispatcher) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionDispatcher) MRBINDC_CLASSARG_END(_other, btCollisionDispatcher))
    ));
}

const btCollisionDispatcher *btCollisionDispatcher_OffsetPtr(const btCollisionDispatcher *ptr, ptrdiff_t i)
{
    return (const btCollisionDispatcher *)(((const btCollisionDispatcher *)ptr) + i);
}

btCollisionDispatcher *btCollisionDispatcher_OffsetMutablePtr(btCollisionDispatcher *ptr, ptrdiff_t i)
{
    return (btCollisionDispatcher *)(((btCollisionDispatcher *)ptr) + i);
}

const btDispatcher *btCollisionDispatcher_UpcastTo_btDispatcher(const btCollisionDispatcher *object)
{
    return (const btDispatcher *)(static_cast<const btDispatcher *>(
        ((const btCollisionDispatcher *)object)
    ));
}

btDispatcher *btCollisionDispatcher_MutableUpcastTo_btDispatcher(btCollisionDispatcher *object)
{
    return (btDispatcher *)(static_cast<btDispatcher *>(
        ((btCollisionDispatcher *)object)
    ));
}

const btCollisionDispatcher *btCollisionDispatcher_StaticDowncastFrom_btDispatcher(const btDispatcher *object)
{
    return (const btCollisionDispatcher *)(static_cast<const btCollisionDispatcher *>(
        ((const btDispatcher *)object)
    ));
}

btCollisionDispatcher *btCollisionDispatcher_MutableStaticDowncastFrom_btDispatcher(btDispatcher *object)
{
    return (btCollisionDispatcher *)(static_cast<btCollisionDispatcher *>(
        ((btDispatcher *)object)
    ));
}

const btCollisionDispatcher *btCollisionDispatcher_DynamicDowncastFrom_btDispatcher(const btDispatcher *object)
{
    return (const btCollisionDispatcher *)(dynamic_cast<const btCollisionDispatcher *>(
        ((const btDispatcher *)object)
    ));
}

btCollisionDispatcher *btCollisionDispatcher_MutableDynamicDowncastFrom_btDispatcher(btDispatcher *object)
{
    return (btCollisionDispatcher *)(dynamic_cast<btCollisionDispatcher *>(
        ((btDispatcher *)object)
    ));
}

const btCollisionDispatcher *btCollisionDispatcher_DynamicDowncastFromOrFail_btDispatcher(const btDispatcher *object)
{
    return (const btCollisionDispatcher *)std::addressof(dynamic_cast<const btCollisionDispatcher &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btDispatcher *)(object))
    ));
}

btCollisionDispatcher *btCollisionDispatcher_MutableDynamicDowncastFromOrFail_btDispatcher(btDispatcher *object)
{
    return (btCollisionDispatcher *)std::addressof(dynamic_cast<btCollisionDispatcher &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btDispatcher *)(object))
    ));
}

btCollisionDispatcher *btCollisionDispatcher_Construct(btCollisionConfiguration *collisionConfiguration)
{
    return (btCollisionDispatcher *)new btCollisionDispatcher(btCollisionDispatcher(
        ((btCollisionConfiguration *)collisionConfiguration)
    ));
}

void btCollisionDispatcher_Destroy(const btCollisionDispatcher *_this)
{
    delete ((const btCollisionDispatcher *)_this);
}

void btCollisionDispatcher_DestroyArray(const btCollisionDispatcher *_this)
{
    delete[] ((const btCollisionDispatcher *)_this);
}

btCollisionDispatcher *btCollisionDispatcher_AssignFromAnother(btCollisionDispatcher *_this, Bullet_PassBy _other_pass_by, btCollisionDispatcher *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionDispatcher);
    return (btCollisionDispatcher *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcher *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_COPY(_other, (btCollisionDispatcher), btCollisionDispatcher) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionDispatcher) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionDispatcher) MRBINDC_CLASSARG_END(_other, btCollisionDispatcher)))
    ));
}

int btCollisionDispatcher_getDispatcherFlags(const btCollisionDispatcher *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionDispatcher *)(_this)).getDispatcherFlags();
}

void btCollisionDispatcher_setDispatcherFlags(btCollisionDispatcher *_this, int flags)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcher *)(_this)).setDispatcherFlags(
        flags
    );
}

int btCollisionDispatcher_getNumManifolds(const btCollisionDispatcher *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionDispatcher *)(_this)).getNumManifolds();
}

bool btCollisionDispatcher_needsCollision(btCollisionDispatcher *_this, const btCollisionObject *body0, const btCollisionObject *body1)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcher *)(_this)).needsCollision(
        ((const btCollisionObject *)body0),
        ((const btCollisionObject *)body1)
    );
}

bool btCollisionDispatcher_needsResponse(btCollisionDispatcher *_this, const btCollisionObject *body0, const btCollisionObject *body1)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcher *)(_this)).needsResponse(
        ((const btCollisionObject *)body0),
        ((const btCollisionObject *)body1)
    );
}

void *btCollisionDispatcher_allocateCollisionAlgorithm(btCollisionDispatcher *_this, int size)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcher *)(_this)).allocateCollisionAlgorithm(
        size
    );
}

void btCollisionDispatcher_freeCollisionAlgorithm(btCollisionDispatcher *_this, void *ptr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcher *)(_this)).freeCollisionAlgorithm(
        ptr
    );
}

btCollisionConfiguration *btCollisionDispatcher_getCollisionConfiguration_mut(btCollisionDispatcher *_this)
{
    return (btCollisionConfiguration *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcher *)(_this)).getCollisionConfiguration());
}

const btCollisionConfiguration *btCollisionDispatcher_getCollisionConfiguration(const btCollisionDispatcher *_this)
{
    return (const btCollisionConfiguration *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionDispatcher *)(_this)).getCollisionConfiguration());
}

void btCollisionDispatcher_setCollisionConfiguration(btCollisionDispatcher *_this, btCollisionConfiguration *config)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcher *)(_this)).setCollisionConfiguration(
        ((btCollisionConfiguration *)config)
    );
}

