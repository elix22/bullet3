// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionDispatch/btDefaultCollisionConfiguration.h"

#include <BulletCollision/CollisionDispatch/btCollisionConfiguration.h>
#include <BulletCollision/CollisionDispatch/btDefaultCollisionConfiguration.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_ConstructFromAnother(Bullet_PassBy _other_pass_by, btDefaultCollisionConfiguration *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btDefaultCollisionConfiguration);
    return (btDefaultCollisionConfiguration *)new btDefaultCollisionConfiguration(btDefaultCollisionConfiguration(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, btDefaultCollisionConfiguration) MRBINDC_CLASSARG_COPY(_other, (btDefaultCollisionConfiguration), btDefaultCollisionConfiguration) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btDefaultCollisionConfiguration) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btDefaultCollisionConfiguration) MRBINDC_CLASSARG_END(_other, btDefaultCollisionConfiguration))
    ));
}

const btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_OffsetPtr(const btDefaultCollisionConfiguration *ptr, ptrdiff_t i)
{
    return (const btDefaultCollisionConfiguration *)(((const btDefaultCollisionConfiguration *)ptr) + i);
}

btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_OffsetMutablePtr(btDefaultCollisionConfiguration *ptr, ptrdiff_t i)
{
    return (btDefaultCollisionConfiguration *)(((btDefaultCollisionConfiguration *)ptr) + i);
}

const btCollisionConfiguration *btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration(const btDefaultCollisionConfiguration *object)
{
    return (const btCollisionConfiguration *)(static_cast<const btCollisionConfiguration *>(
        ((const btDefaultCollisionConfiguration *)object)
    ));
}

btCollisionConfiguration *btDefaultCollisionConfiguration_MutableUpcastTo_btCollisionConfiguration(btDefaultCollisionConfiguration *object)
{
    return (btCollisionConfiguration *)(static_cast<btCollisionConfiguration *>(
        ((btDefaultCollisionConfiguration *)object)
    ));
}

const btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_StaticDowncastFrom_btCollisionConfiguration(const btCollisionConfiguration *object)
{
    return (const btDefaultCollisionConfiguration *)(static_cast<const btDefaultCollisionConfiguration *>(
        ((const btCollisionConfiguration *)object)
    ));
}

btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_MutableStaticDowncastFrom_btCollisionConfiguration(btCollisionConfiguration *object)
{
    return (btDefaultCollisionConfiguration *)(static_cast<btDefaultCollisionConfiguration *>(
        ((btCollisionConfiguration *)object)
    ));
}

const btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration(const btCollisionConfiguration *object)
{
    return (const btDefaultCollisionConfiguration *)(dynamic_cast<const btDefaultCollisionConfiguration *>(
        ((const btCollisionConfiguration *)object)
    ));
}

btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_MutableDynamicDowncastFrom_btCollisionConfiguration(btCollisionConfiguration *object)
{
    return (btDefaultCollisionConfiguration *)(dynamic_cast<btDefaultCollisionConfiguration *>(
        ((btCollisionConfiguration *)object)
    ));
}

const btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_DynamicDowncastFromOrFail_btCollisionConfiguration(const btCollisionConfiguration *object)
{
    return (const btDefaultCollisionConfiguration *)std::addressof(dynamic_cast<const btDefaultCollisionConfiguration &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionConfiguration *)(object))
    ));
}

btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_MutableDynamicDowncastFromOrFail_btCollisionConfiguration(btCollisionConfiguration *object)
{
    return (btDefaultCollisionConfiguration *)std::addressof(dynamic_cast<btDefaultCollisionConfiguration &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionConfiguration *)(object))
    ));
}

void btDefaultCollisionConfiguration_Destroy(const btDefaultCollisionConfiguration *_this)
{
    delete ((const btDefaultCollisionConfiguration *)_this);
}

void btDefaultCollisionConfiguration_DestroyArray(const btDefaultCollisionConfiguration *_this)
{
    delete[] ((const btDefaultCollisionConfiguration *)_this);
}

btDefaultCollisionConfiguration *btDefaultCollisionConfiguration_AssignFromAnother(btDefaultCollisionConfiguration *_this, Bullet_PassBy _other_pass_by, btDefaultCollisionConfiguration *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btDefaultCollisionConfiguration);
    return (btDefaultCollisionConfiguration *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultCollisionConfiguration *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, btDefaultCollisionConfiguration) MRBINDC_CLASSARG_COPY(_other, (btDefaultCollisionConfiguration), btDefaultCollisionConfiguration) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btDefaultCollisionConfiguration) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btDefaultCollisionConfiguration) MRBINDC_CLASSARG_END(_other, btDefaultCollisionConfiguration)))
    ));
}

void btDefaultCollisionConfiguration_setConvexConvexMultipointIterations(btDefaultCollisionConfiguration *_this, const int *numPerturbationIterations, const int *minimumPointsPerturbationThreshold)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultCollisionConfiguration *)(_this)).setConvexConvexMultipointIterations(
        (numPerturbationIterations ? *numPerturbationIterations : static_cast<int>(3)),
        (minimumPointsPerturbationThreshold ? *minimumPointsPerturbationThreshold : static_cast<int>(3))
    );
}

void btDefaultCollisionConfiguration_setPlaneConvexMultipointIterations(btDefaultCollisionConfiguration *_this, const int *numPerturbationIterations, const int *minimumPointsPerturbationThreshold)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultCollisionConfiguration *)(_this)).setPlaneConvexMultipointIterations(
        (numPerturbationIterations ? *numPerturbationIterations : static_cast<int>(3)),
        (minimumPointsPerturbationThreshold ? *minimumPointsPerturbationThreshold : static_cast<int>(3))
    );
}

