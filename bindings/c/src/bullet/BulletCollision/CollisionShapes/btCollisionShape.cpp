// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionShapes/btCollisionShape.h"

#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


void btCollisionShape_Destroy(const btCollisionShape *_this)
{
    delete ((const btCollisionShape *)_this);
}

void btCollisionShape_DestroyArray(const btCollisionShape *_this)
{
    delete[] ((const btCollisionShape *)_this);
}

void *Bullet_new_btCollisionShape_unsigned_long(unsigned long sizeInBytes)
{
    return btCollisionShape::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btCollisionShape_void_ptr(void *ptr)
{
    btCollisionShape::operator delete(
        ptr
    );
}

void *Bullet_new_btCollisionShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btCollisionShape::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btCollisionShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btCollisionShape::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btCollisionShape_unsigned_long(unsigned long sizeInBytes)
{
    return btCollisionShape::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btCollisionShape_void_ptr(void *ptr)
{
    btCollisionShape::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btCollisionShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btCollisionShape::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btCollisionShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btCollisionShape::operator delete[](
        _1,
        _2
    );
}

void btCollisionShape_getAabb(const btCollisionShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getAabb(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btCollisionShape_getBoundingSphere(const btCollisionShape *_this, btVector3 *center, double *radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getBoundingSphere(
        ((center ? void() : MRBINDC_THROW("Parameter `center` can not be null.", void)), *(btVector3 *)(center)),
        ((radius ? void() : MRBINDC_THROW("Parameter `radius` can not be null.", void)), *radius)
    );
}

double btCollisionShape_getAngularMotionDisc(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getAngularMotionDisc();
}

double btCollisionShape_getContactBreakingThreshold(const btCollisionShape *_this, double defaultContactThresholdFactor)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getContactBreakingThreshold(
        defaultContactThresholdFactor
    );
}

void btCollisionShape_calculateTemporalAabb(const btCollisionShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).calculateTemporalAabb(
        ((curTrans ? void() : MRBINDC_THROW("Parameter `curTrans` can not be null.", void)), *(const btTransform *)(curTrans)),
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel)),
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel)),
        timeStep,
        ((temporalAabbMin ? void() : MRBINDC_THROW("Parameter `temporalAabbMin` can not be null.", void)), *(btVector3 *)(temporalAabbMin)),
        ((temporalAabbMax ? void() : MRBINDC_THROW("Parameter `temporalAabbMax` can not be null.", void)), *(btVector3 *)(temporalAabbMax))
    );
}

bool btCollisionShape_isPolyhedral(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).isPolyhedral();
}

bool btCollisionShape_isConvex2d(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).isConvex2d();
}

bool btCollisionShape_isConvex(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).isConvex();
}

bool btCollisionShape_isNonMoving(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).isNonMoving();
}

bool btCollisionShape_isConcave(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).isConcave();
}

bool btCollisionShape_isCompound(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).isCompound();
}

bool btCollisionShape_isSoftBody(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).isSoftBody();
}

bool btCollisionShape_isInfinite(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).isInfinite();
}

void btCollisionShape_setLocalScaling(btCollisionShape *_this, const btVector3 *scaling)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionShape *)(_this)).setLocalScaling(
        ((scaling ? void() : MRBINDC_THROW("Parameter `scaling` can not be null.", void)), *(const btVector3 *)(scaling))
    );
}

const btVector3 *btCollisionShape_getLocalScaling(const btCollisionShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getLocalScaling());
}

void btCollisionShape_calculateLocalInertia(const btCollisionShape *_this, double mass, btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).calculateLocalInertia(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(btVector3 *)(inertia))
    );
}

const char *btCollisionShape_getName(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getName();
}

int btCollisionShape_getShapeType(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getShapeType();
}

btVector3 *btCollisionShape_getAnisotropicRollingFrictionDirection(const btCollisionShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getAnisotropicRollingFrictionDirection());
}

void btCollisionShape_setMargin(btCollisionShape *_this, double margin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionShape *)(_this)).setMargin(
        margin
    );
}

double btCollisionShape_getMargin(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getMargin();
}

void btCollisionShape_setUserPointer(btCollisionShape *_this, void *userPtr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionShape *)(_this)).setUserPointer(
        userPtr
    );
}

void *btCollisionShape_getUserPointer(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getUserPointer();
}

void btCollisionShape_setUserIndex(btCollisionShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionShape *)(_this)).setUserIndex(
        index
    );
}

int btCollisionShape_getUserIndex(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getUserIndex();
}

void btCollisionShape_setUserIndex2(btCollisionShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionShape *)(_this)).setUserIndex2(
        index
    );
}

int btCollisionShape_getUserIndex2(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).getUserIndex2();
}

int btCollisionShape_calculateSerializeBufferSize(const btCollisionShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionShape *)(_this)).calculateSerializeBufferSize();
}

const btCollisionShape *btCollisionShape_OffsetPtr(const btCollisionShape *ptr, ptrdiff_t i)
{
    return (const btCollisionShape *)(((const btCollisionShape *)ptr) + i);
}

btCollisionShape *btCollisionShape_OffsetMutablePtr(btCollisionShape *ptr, ptrdiff_t i)
{
    return (btCollisionShape *)(((btCollisionShape *)ptr) + i);
}

