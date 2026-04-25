// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionDispatch/btCollisionDispatcherMt.h"

#include <BulletCollision/BroadphaseCollision/btDispatcher.h>
#include <BulletCollision/CollisionDispatch/btCollisionConfiguration.h>
#include <BulletCollision/CollisionDispatch/btCollisionDispatcher.h>
#include <BulletCollision/CollisionDispatch/btCollisionDispatcherMt.h>
#include <BulletCollision/CollisionDispatch/btCollisionObject.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btCollisionDispatcherMt *btCollisionDispatcherMt_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionDispatcherMt *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionDispatcherMt);
    return (btCollisionDispatcherMt *)new btCollisionDispatcherMt(btCollisionDispatcherMt(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionDispatcherMt), btCollisionDispatcherMt) MRBINDC_CLASSARG_MOVE(_other, (btCollisionDispatcherMt), btCollisionDispatcherMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionDispatcherMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionDispatcherMt) MRBINDC_CLASSARG_END(_other, btCollisionDispatcherMt))
    ));
}

const btCollisionDispatcherMt *btCollisionDispatcherMt_OffsetPtr(const btCollisionDispatcherMt *ptr, ptrdiff_t i)
{
    return (const btCollisionDispatcherMt *)(((const btCollisionDispatcherMt *)ptr) + i);
}

btCollisionDispatcherMt *btCollisionDispatcherMt_OffsetMutablePtr(btCollisionDispatcherMt *ptr, ptrdiff_t i)
{
    return (btCollisionDispatcherMt *)(((btCollisionDispatcherMt *)ptr) + i);
}

const btDispatcher *btCollisionDispatcherMt_UpcastTo_btDispatcher(const btCollisionDispatcherMt *object)
{
    return (const btDispatcher *)(static_cast<const btDispatcher *>(
        ((const btCollisionDispatcherMt *)object)
    ));
}

btDispatcher *btCollisionDispatcherMt_MutableUpcastTo_btDispatcher(btCollisionDispatcherMt *object)
{
    return (btDispatcher *)(static_cast<btDispatcher *>(
        ((btCollisionDispatcherMt *)object)
    ));
}

const btCollisionDispatcherMt *btCollisionDispatcherMt_StaticDowncastFrom_btDispatcher(const btDispatcher *object)
{
    return (const btCollisionDispatcherMt *)(static_cast<const btCollisionDispatcherMt *>(
        ((const btDispatcher *)object)
    ));
}

btCollisionDispatcherMt *btCollisionDispatcherMt_MutableStaticDowncastFrom_btDispatcher(btDispatcher *object)
{
    return (btCollisionDispatcherMt *)(static_cast<btCollisionDispatcherMt *>(
        ((btDispatcher *)object)
    ));
}

const btCollisionDispatcherMt *btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher(const btDispatcher *object)
{
    return (const btCollisionDispatcherMt *)(dynamic_cast<const btCollisionDispatcherMt *>(
        ((const btDispatcher *)object)
    ));
}

btCollisionDispatcherMt *btCollisionDispatcherMt_MutableDynamicDowncastFrom_btDispatcher(btDispatcher *object)
{
    return (btCollisionDispatcherMt *)(dynamic_cast<btCollisionDispatcherMt *>(
        ((btDispatcher *)object)
    ));
}

const btCollisionDispatcherMt *btCollisionDispatcherMt_DynamicDowncastFromOrFail_btDispatcher(const btDispatcher *object)
{
    return (const btCollisionDispatcherMt *)std::addressof(dynamic_cast<const btCollisionDispatcherMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btDispatcher *)(object))
    ));
}

btCollisionDispatcherMt *btCollisionDispatcherMt_MutableDynamicDowncastFromOrFail_btDispatcher(btDispatcher *object)
{
    return (btCollisionDispatcherMt *)std::addressof(dynamic_cast<btCollisionDispatcherMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btDispatcher *)(object))
    ));
}

const btCollisionDispatcher *btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher(const btCollisionDispatcherMt *object)
{
    return (const btCollisionDispatcher *)(static_cast<const btCollisionDispatcher *>(
        ((const btCollisionDispatcherMt *)object)
    ));
}

btCollisionDispatcher *btCollisionDispatcherMt_MutableUpcastTo_btCollisionDispatcher(btCollisionDispatcherMt *object)
{
    return (btCollisionDispatcher *)(static_cast<btCollisionDispatcher *>(
        ((btCollisionDispatcherMt *)object)
    ));
}

const btCollisionDispatcherMt *btCollisionDispatcherMt_StaticDowncastFrom_btCollisionDispatcher(const btCollisionDispatcher *object)
{
    return (const btCollisionDispatcherMt *)(static_cast<const btCollisionDispatcherMt *>(
        ((const btCollisionDispatcher *)object)
    ));
}

btCollisionDispatcherMt *btCollisionDispatcherMt_MutableStaticDowncastFrom_btCollisionDispatcher(btCollisionDispatcher *object)
{
    return (btCollisionDispatcherMt *)(static_cast<btCollisionDispatcherMt *>(
        ((btCollisionDispatcher *)object)
    ));
}

const btCollisionDispatcherMt *btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher(const btCollisionDispatcher *object)
{
    return (const btCollisionDispatcherMt *)(dynamic_cast<const btCollisionDispatcherMt *>(
        ((const btCollisionDispatcher *)object)
    ));
}

btCollisionDispatcherMt *btCollisionDispatcherMt_MutableDynamicDowncastFrom_btCollisionDispatcher(btCollisionDispatcher *object)
{
    return (btCollisionDispatcherMt *)(dynamic_cast<btCollisionDispatcherMt *>(
        ((btCollisionDispatcher *)object)
    ));
}

const btCollisionDispatcherMt *btCollisionDispatcherMt_DynamicDowncastFromOrFail_btCollisionDispatcher(const btCollisionDispatcher *object)
{
    return (const btCollisionDispatcherMt *)std::addressof(dynamic_cast<const btCollisionDispatcherMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionDispatcher *)(object))
    ));
}

btCollisionDispatcherMt *btCollisionDispatcherMt_MutableDynamicDowncastFromOrFail_btCollisionDispatcher(btCollisionDispatcher *object)
{
    return (btCollisionDispatcherMt *)std::addressof(dynamic_cast<btCollisionDispatcherMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionDispatcher *)(object))
    ));
}

btCollisionDispatcherMt *btCollisionDispatcherMt_Construct(btCollisionConfiguration *config, const int *grainSize)
{
    return (btCollisionDispatcherMt *)new btCollisionDispatcherMt(btCollisionDispatcherMt(
        ((btCollisionConfiguration *)config),
        (grainSize ? *grainSize : static_cast<int>(40))
    ));
}

void btCollisionDispatcherMt_Destroy(const btCollisionDispatcherMt *_this)
{
    delete ((const btCollisionDispatcherMt *)_this);
}

void btCollisionDispatcherMt_DestroyArray(const btCollisionDispatcherMt *_this)
{
    delete[] ((const btCollisionDispatcherMt *)_this);
}

btCollisionDispatcherMt *btCollisionDispatcherMt_AssignFromAnother(btCollisionDispatcherMt *_this, Bullet_PassBy _other_pass_by, btCollisionDispatcherMt *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionDispatcherMt);
    return (btCollisionDispatcherMt *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcherMt *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (btCollisionDispatcherMt), btCollisionDispatcherMt) MRBINDC_CLASSARG_MOVE(_other, (btCollisionDispatcherMt), btCollisionDispatcherMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionDispatcherMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionDispatcherMt) MRBINDC_CLASSARG_END(_other, btCollisionDispatcherMt))
    ));
}

int btCollisionDispatcherMt_getDispatcherFlags(const btCollisionDispatcherMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionDispatcherMt *)(_this)).getDispatcherFlags();
}

void btCollisionDispatcherMt_setDispatcherFlags(btCollisionDispatcherMt *_this, int flags)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcherMt *)(_this)).setDispatcherFlags(
        flags
    );
}

int btCollisionDispatcherMt_getNumManifolds(const btCollisionDispatcherMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionDispatcherMt *)(_this)).getNumManifolds();
}

bool btCollisionDispatcherMt_needsCollision(btCollisionDispatcherMt *_this, const btCollisionObject *body0, const btCollisionObject *body1)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcherMt *)(_this)).needsCollision(
        ((const btCollisionObject *)body0),
        ((const btCollisionObject *)body1)
    );
}

bool btCollisionDispatcherMt_needsResponse(btCollisionDispatcherMt *_this, const btCollisionObject *body0, const btCollisionObject *body1)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcherMt *)(_this)).needsResponse(
        ((const btCollisionObject *)body0),
        ((const btCollisionObject *)body1)
    );
}

void *btCollisionDispatcherMt_allocateCollisionAlgorithm(btCollisionDispatcherMt *_this, int size)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcherMt *)(_this)).allocateCollisionAlgorithm(
        size
    );
}

void btCollisionDispatcherMt_freeCollisionAlgorithm(btCollisionDispatcherMt *_this, void *ptr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcherMt *)(_this)).freeCollisionAlgorithm(
        ptr
    );
}

void btCollisionDispatcherMt_setCollisionConfiguration(btCollisionDispatcherMt *_this, btCollisionConfiguration *config)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionDispatcherMt *)(_this)).setCollisionConfiguration(
        ((btCollisionConfiguration *)config)
    );
}

