// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionShapes/btConvexShape.h"

#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletCollision/CollisionShapes/btConvexShape.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


void btConvexShape_Destroy(const btConvexShape *_this)
{
    delete ((const btConvexShape *)_this);
}

void btConvexShape_DestroyArray(const btConvexShape *_this)
{
    delete[] ((const btConvexShape *)_this);
}

void *Bullet_new_btConvexShape_unsigned_long(unsigned long sizeInBytes)
{
    return btConvexShape::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btConvexShape_void_ptr(void *ptr)
{
    btConvexShape::operator delete(
        ptr
    );
}

void *Bullet_new_btConvexShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btConvexShape::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btConvexShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btConvexShape::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btConvexShape_unsigned_long(unsigned long sizeInBytes)
{
    return btConvexShape::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btConvexShape_void_ptr(void *ptr)
{
    btConvexShape::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btConvexShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btConvexShape::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btConvexShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btConvexShape::operator delete[](
        _1,
        _2
    );
}

btVector3 *btConvexShape_localGetSupportingVertex(const btConvexShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).localGetSupportingVertex(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btConvexShape_localGetSupportingVertexWithoutMargin(const btConvexShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).localGetSupportingVertexWithoutMargin(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btConvexShape_localGetSupportVertexWithoutMarginNonVirtual(const btConvexShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).localGetSupportVertexWithoutMarginNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btConvexShape_localGetSupportVertexNonVirtual(const btConvexShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).localGetSupportVertexNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

double btConvexShape_getMarginNonVirtual(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getMarginNonVirtual();
}

void btConvexShape_getAabbNonVirtual(const btConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getAabbNonVirtual(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btConvexShape_project(const btConvexShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).project(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans)),
        ((dir ? void() : MRBINDC_THROW("Parameter `dir` can not be null.", void)), *(const btVector3 *)(dir)),
        ((minProj ? void() : MRBINDC_THROW("Parameter `minProj` can not be null.", void)), *minProj),
        ((maxProj ? void() : MRBINDC_THROW("Parameter `maxProj` can not be null.", void)), *maxProj),
        ((witnesPtMin ? void() : MRBINDC_THROW("Parameter `witnesPtMin` can not be null.", void)), *(btVector3 *)(witnesPtMin)),
        ((witnesPtMax ? void() : MRBINDC_THROW("Parameter `witnesPtMax` can not be null.", void)), *(btVector3 *)(witnesPtMax))
    );
}

void btConvexShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btConvexShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).batchedUnitVectorGetSupportingVertexWithoutMargin(
        ((const btVector3 *)vectors),
        ((btVector3 *)supportVerticesOut),
        numVectors
    );
}

void btConvexShape_getAabb(const btConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getAabb(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btConvexShape_getAabbSlow(const btConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getAabbSlow(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btConvexShape_setLocalScaling(btConvexShape *_this, const btVector3 *scaling)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexShape *)(_this)).setLocalScaling(
        ((scaling ? void() : MRBINDC_THROW("Parameter `scaling` can not be null.", void)), *(const btVector3 *)(scaling))
    );
}

const btVector3 *btConvexShape_getLocalScaling(const btConvexShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getLocalScaling());
}

void btConvexShape_setMargin(btConvexShape *_this, double margin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexShape *)(_this)).setMargin(
        margin
    );
}

double btConvexShape_getMargin(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getMargin();
}

int btConvexShape_getNumPreferredPenetrationDirections(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getNumPreferredPenetrationDirections();
}

void btConvexShape_getPreferredPenetrationDirection(const btConvexShape *_this, int index, btVector3 *penetrationVector)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getPreferredPenetrationDirection(
        index,
        ((penetrationVector ? void() : MRBINDC_THROW("Parameter `penetrationVector` can not be null.", void)), *(btVector3 *)(penetrationVector))
    );
}

void btConvexShape_getBoundingSphere(const btConvexShape *_this, btVector3 *center, double *radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getBoundingSphere(
        ((center ? void() : MRBINDC_THROW("Parameter `center` can not be null.", void)), *(btVector3 *)(center)),
        ((radius ? void() : MRBINDC_THROW("Parameter `radius` can not be null.", void)), *radius)
    );
}

double btConvexShape_getAngularMotionDisc(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getAngularMotionDisc();
}

double btConvexShape_getContactBreakingThreshold(const btConvexShape *_this, double defaultContactThresholdFactor)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getContactBreakingThreshold(
        defaultContactThresholdFactor
    );
}

void btConvexShape_calculateTemporalAabb(const btConvexShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).calculateTemporalAabb(
        ((curTrans ? void() : MRBINDC_THROW("Parameter `curTrans` can not be null.", void)), *(const btTransform *)(curTrans)),
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel)),
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel)),
        timeStep,
        ((temporalAabbMin ? void() : MRBINDC_THROW("Parameter `temporalAabbMin` can not be null.", void)), *(btVector3 *)(temporalAabbMin)),
        ((temporalAabbMax ? void() : MRBINDC_THROW("Parameter `temporalAabbMax` can not be null.", void)), *(btVector3 *)(temporalAabbMax))
    );
}

bool btConvexShape_isPolyhedral(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).isPolyhedral();
}

bool btConvexShape_isConvex2d(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).isConvex2d();
}

bool btConvexShape_isConvex(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).isConvex();
}

bool btConvexShape_isNonMoving(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).isNonMoving();
}

bool btConvexShape_isConcave(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).isConcave();
}

bool btConvexShape_isCompound(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).isCompound();
}

bool btConvexShape_isSoftBody(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).isSoftBody();
}

bool btConvexShape_isInfinite(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).isInfinite();
}

void btConvexShape_calculateLocalInertia(const btConvexShape *_this, double mass, btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).calculateLocalInertia(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(btVector3 *)(inertia))
    );
}

const char *btConvexShape_getName(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getName();
}

int btConvexShape_getShapeType(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getShapeType();
}

btVector3 *btConvexShape_getAnisotropicRollingFrictionDirection(const btConvexShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getAnisotropicRollingFrictionDirection());
}

void btConvexShape_setUserPointer(btConvexShape *_this, void *userPtr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexShape *)(_this)).setUserPointer(
        userPtr
    );
}

void *btConvexShape_getUserPointer(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getUserPointer();
}

void btConvexShape_setUserIndex(btConvexShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexShape *)(_this)).setUserIndex(
        index
    );
}

int btConvexShape_getUserIndex(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getUserIndex();
}

void btConvexShape_setUserIndex2(btConvexShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexShape *)(_this)).setUserIndex2(
        index
    );
}

int btConvexShape_getUserIndex2(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).getUserIndex2();
}

int btConvexShape_calculateSerializeBufferSize(const btConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexShape *)(_this)).calculateSerializeBufferSize();
}

const btConvexShape *btConvexShape_OffsetPtr(const btConvexShape *ptr, ptrdiff_t i)
{
    return (const btConvexShape *)(((const btConvexShape *)ptr) + i);
}

btConvexShape *btConvexShape_OffsetMutablePtr(btConvexShape *ptr, ptrdiff_t i)
{
    return (btConvexShape *)(((btConvexShape *)ptr) + i);
}

const btCollisionShape *btConvexShape_UpcastTo_btCollisionShape(const btConvexShape *object)
{
    return (const btCollisionShape *)(static_cast<const btCollisionShape *>(
        ((const btConvexShape *)object)
    ));
}

btCollisionShape *btConvexShape_MutableUpcastTo_btCollisionShape(btConvexShape *object)
{
    return (btCollisionShape *)(static_cast<btCollisionShape *>(
        ((btConvexShape *)object)
    ));
}

const btConvexShape *btConvexShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btConvexShape *)(static_cast<const btConvexShape *>(
        ((const btCollisionShape *)object)
    ));
}

btConvexShape *btConvexShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btConvexShape *)(static_cast<btConvexShape *>(
        ((btCollisionShape *)object)
    ));
}

const btConvexShape *btConvexShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btConvexShape *)(dynamic_cast<const btConvexShape *>(
        ((const btCollisionShape *)object)
    ));
}

btConvexShape *btConvexShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btConvexShape *)(dynamic_cast<btConvexShape *>(
        ((btCollisionShape *)object)
    ));
}

const btConvexShape *btConvexShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object)
{
    return (const btConvexShape *)std::addressof(dynamic_cast<const btConvexShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionShape *)(object))
    ));
}

btConvexShape *btConvexShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object)
{
    return (btConvexShape *)std::addressof(dynamic_cast<btConvexShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionShape *)(object))
    ));
}

