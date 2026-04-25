// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionShapes/btConvexInternalShape.h"

#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletCollision/CollisionShapes/btConvexInternalShape.h>
#include <BulletCollision/CollisionShapes/btConvexShape.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


void btConvexInternalShape_Destroy(const btConvexInternalShape *_this)
{
    delete ((const btConvexInternalShape *)_this);
}

void btConvexInternalShape_DestroyArray(const btConvexInternalShape *_this)
{
    delete[] ((const btConvexInternalShape *)_this);
}

void *Bullet_new_btConvexInternalShape_unsigned_long(unsigned long sizeInBytes)
{
    return btConvexInternalShape::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btConvexInternalShape_void_ptr(void *ptr)
{
    btConvexInternalShape::operator delete(
        ptr
    );
}

void *Bullet_new_btConvexInternalShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btConvexInternalShape::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btConvexInternalShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btConvexInternalShape::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btConvexInternalShape_unsigned_long(unsigned long sizeInBytes)
{
    return btConvexInternalShape::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btConvexInternalShape_void_ptr(void *ptr)
{
    btConvexInternalShape::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btConvexInternalShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btConvexInternalShape::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btConvexInternalShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btConvexInternalShape::operator delete[](
        _1,
        _2
    );
}

btVector3 *btConvexInternalShape_localGetSupportingVertex(const btConvexInternalShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).localGetSupportingVertex(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

const btVector3 *btConvexInternalShape_getImplicitShapeDimensions(const btConvexInternalShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getImplicitShapeDimensions());
}

void btConvexInternalShape_setImplicitShapeDimensions(btConvexInternalShape *_this, const btVector3 *dimensions)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalShape *)(_this)).setImplicitShapeDimensions(
        ((dimensions ? void() : MRBINDC_THROW("Parameter `dimensions` can not be null.", void)), *(const btVector3 *)(dimensions))
    );
}

void btConvexInternalShape_setSafeMargin_double(btConvexInternalShape *_this, double minDimension, const double *defaultMarginMultiplier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalShape *)(_this)).setSafeMargin(
        minDimension,
        (defaultMarginMultiplier ? *defaultMarginMultiplier : static_cast<double>(0.100000001F))
    );
}

void btConvexInternalShape_setSafeMargin_btVector3(btConvexInternalShape *_this, const btVector3 *halfExtents, const double *defaultMarginMultiplier)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalShape *)(_this)).setSafeMargin(
        ((halfExtents ? void() : MRBINDC_THROW("Parameter `halfExtents` can not be null.", void)), *(const btVector3 *)(halfExtents)),
        (defaultMarginMultiplier ? *defaultMarginMultiplier : static_cast<double>(0.100000001F))
    );
}

void btConvexInternalShape_getAabb(const btConvexInternalShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getAabb(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btConvexInternalShape_getAabbSlow(const btConvexInternalShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getAabbSlow(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btConvexInternalShape_setLocalScaling(btConvexInternalShape *_this, const btVector3 *scaling)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalShape *)(_this)).setLocalScaling(
        ((scaling ? void() : MRBINDC_THROW("Parameter `scaling` can not be null.", void)), *(const btVector3 *)(scaling))
    );
}

const btVector3 *btConvexInternalShape_getLocalScaling(const btConvexInternalShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getLocalScaling());
}

const btVector3 *btConvexInternalShape_getLocalScalingNV(const btConvexInternalShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getLocalScalingNV());
}

void btConvexInternalShape_setMargin(btConvexInternalShape *_this, double margin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalShape *)(_this)).setMargin(
        margin
    );
}

double btConvexInternalShape_getMargin(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getMargin();
}

double btConvexInternalShape_getMarginNV(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getMarginNV();
}

int btConvexInternalShape_getNumPreferredPenetrationDirections(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getNumPreferredPenetrationDirections();
}

void btConvexInternalShape_getPreferredPenetrationDirection(const btConvexInternalShape *_this, int index, btVector3 *penetrationVector)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getPreferredPenetrationDirection(
        index,
        ((penetrationVector ? void() : MRBINDC_THROW("Parameter `penetrationVector` can not be null.", void)), *(btVector3 *)(penetrationVector))
    );
}

int btConvexInternalShape_calculateSerializeBufferSize(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).calculateSerializeBufferSize();
}

btVector3 *btConvexInternalShape_localGetSupportingVertexWithoutMargin(const btConvexInternalShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).localGetSupportingVertexWithoutMargin(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btConvexInternalShape_localGetSupportVertexWithoutMarginNonVirtual(const btConvexInternalShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).localGetSupportVertexWithoutMarginNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btConvexInternalShape_localGetSupportVertexNonVirtual(const btConvexInternalShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).localGetSupportVertexNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

double btConvexInternalShape_getMarginNonVirtual(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getMarginNonVirtual();
}

void btConvexInternalShape_getAabbNonVirtual(const btConvexInternalShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getAabbNonVirtual(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btConvexInternalShape_project(const btConvexInternalShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).project(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans)),
        ((dir ? void() : MRBINDC_THROW("Parameter `dir` can not be null.", void)), *(const btVector3 *)(dir)),
        ((minProj ? void() : MRBINDC_THROW("Parameter `minProj` can not be null.", void)), *minProj),
        ((maxProj ? void() : MRBINDC_THROW("Parameter `maxProj` can not be null.", void)), *maxProj),
        ((witnesPtMin ? void() : MRBINDC_THROW("Parameter `witnesPtMin` can not be null.", void)), *(btVector3 *)(witnesPtMin)),
        ((witnesPtMax ? void() : MRBINDC_THROW("Parameter `witnesPtMax` can not be null.", void)), *(btVector3 *)(witnesPtMax))
    );
}

void btConvexInternalShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btConvexInternalShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).batchedUnitVectorGetSupportingVertexWithoutMargin(
        ((const btVector3 *)vectors),
        ((btVector3 *)supportVerticesOut),
        numVectors
    );
}

void btConvexInternalShape_getBoundingSphere(const btConvexInternalShape *_this, btVector3 *center, double *radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getBoundingSphere(
        ((center ? void() : MRBINDC_THROW("Parameter `center` can not be null.", void)), *(btVector3 *)(center)),
        ((radius ? void() : MRBINDC_THROW("Parameter `radius` can not be null.", void)), *radius)
    );
}

double btConvexInternalShape_getAngularMotionDisc(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getAngularMotionDisc();
}

double btConvexInternalShape_getContactBreakingThreshold(const btConvexInternalShape *_this, double defaultContactThresholdFactor)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getContactBreakingThreshold(
        defaultContactThresholdFactor
    );
}

void btConvexInternalShape_calculateTemporalAabb(const btConvexInternalShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).calculateTemporalAabb(
        ((curTrans ? void() : MRBINDC_THROW("Parameter `curTrans` can not be null.", void)), *(const btTransform *)(curTrans)),
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel)),
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel)),
        timeStep,
        ((temporalAabbMin ? void() : MRBINDC_THROW("Parameter `temporalAabbMin` can not be null.", void)), *(btVector3 *)(temporalAabbMin)),
        ((temporalAabbMax ? void() : MRBINDC_THROW("Parameter `temporalAabbMax` can not be null.", void)), *(btVector3 *)(temporalAabbMax))
    );
}

bool btConvexInternalShape_isPolyhedral(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).isPolyhedral();
}

bool btConvexInternalShape_isConvex2d(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).isConvex2d();
}

bool btConvexInternalShape_isConvex(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).isConvex();
}

bool btConvexInternalShape_isNonMoving(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).isNonMoving();
}

bool btConvexInternalShape_isConcave(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).isConcave();
}

bool btConvexInternalShape_isCompound(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).isCompound();
}

bool btConvexInternalShape_isSoftBody(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).isSoftBody();
}

bool btConvexInternalShape_isInfinite(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).isInfinite();
}

void btConvexInternalShape_calculateLocalInertia(const btConvexInternalShape *_this, double mass, btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).calculateLocalInertia(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(btVector3 *)(inertia))
    );
}

const char *btConvexInternalShape_getName(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getName();
}

int btConvexInternalShape_getShapeType(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getShapeType();
}

btVector3 *btConvexInternalShape_getAnisotropicRollingFrictionDirection(const btConvexInternalShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getAnisotropicRollingFrictionDirection());
}

void btConvexInternalShape_setUserPointer(btConvexInternalShape *_this, void *userPtr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalShape *)(_this)).setUserPointer(
        userPtr
    );
}

void *btConvexInternalShape_getUserPointer(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getUserPointer();
}

void btConvexInternalShape_setUserIndex(btConvexInternalShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalShape *)(_this)).setUserIndex(
        index
    );
}

int btConvexInternalShape_getUserIndex(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getUserIndex();
}

void btConvexInternalShape_setUserIndex2(btConvexInternalShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalShape *)(_this)).setUserIndex2(
        index
    );
}

int btConvexInternalShape_getUserIndex2(const btConvexInternalShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalShape *)(_this)).getUserIndex2();
}

const btConvexInternalShape *btConvexInternalShape_OffsetPtr(const btConvexInternalShape *ptr, ptrdiff_t i)
{
    return (const btConvexInternalShape *)(((const btConvexInternalShape *)ptr) + i);
}

btConvexInternalShape *btConvexInternalShape_OffsetMutablePtr(btConvexInternalShape *ptr, ptrdiff_t i)
{
    return (btConvexInternalShape *)(((btConvexInternalShape *)ptr) + i);
}

const btCollisionShape *btConvexInternalShape_UpcastTo_btCollisionShape(const btConvexInternalShape *object)
{
    return (const btCollisionShape *)(static_cast<const btCollisionShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btCollisionShape *btConvexInternalShape_MutableUpcastTo_btCollisionShape(btConvexInternalShape *object)
{
    return (btCollisionShape *)(static_cast<btCollisionShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btConvexInternalShape *btConvexInternalShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btConvexInternalShape *)(static_cast<const btConvexInternalShape *>(
        ((const btCollisionShape *)object)
    ));
}

btConvexInternalShape *btConvexInternalShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btConvexInternalShape *)(static_cast<btConvexInternalShape *>(
        ((btCollisionShape *)object)
    ));
}

const btConvexInternalShape *btConvexInternalShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btConvexInternalShape *)(dynamic_cast<const btConvexInternalShape *>(
        ((const btCollisionShape *)object)
    ));
}

btConvexInternalShape *btConvexInternalShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btConvexInternalShape *)(dynamic_cast<btConvexInternalShape *>(
        ((btCollisionShape *)object)
    ));
}

const btConvexInternalShape *btConvexInternalShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object)
{
    return (const btConvexInternalShape *)std::addressof(dynamic_cast<const btConvexInternalShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionShape *)(object))
    ));
}

btConvexInternalShape *btConvexInternalShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object)
{
    return (btConvexInternalShape *)std::addressof(dynamic_cast<btConvexInternalShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionShape *)(object))
    ));
}

const btConvexShape *btConvexInternalShape_UpcastTo_btConvexShape(const btConvexInternalShape *object)
{
    return (const btConvexShape *)(static_cast<const btConvexShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btConvexShape *btConvexInternalShape_MutableUpcastTo_btConvexShape(btConvexInternalShape *object)
{
    return (btConvexShape *)(static_cast<btConvexShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btConvexInternalShape *btConvexInternalShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btConvexInternalShape *)(static_cast<const btConvexInternalShape *>(
        ((const btConvexShape *)object)
    ));
}

btConvexInternalShape *btConvexInternalShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btConvexInternalShape *)(static_cast<btConvexInternalShape *>(
        ((btConvexShape *)object)
    ));
}

const btConvexInternalShape *btConvexInternalShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btConvexInternalShape *)(dynamic_cast<const btConvexInternalShape *>(
        ((const btConvexShape *)object)
    ));
}

btConvexInternalShape *btConvexInternalShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btConvexInternalShape *)(dynamic_cast<btConvexInternalShape *>(
        ((btConvexShape *)object)
    ));
}

const btConvexInternalShape *btConvexInternalShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object)
{
    return (const btConvexInternalShape *)std::addressof(dynamic_cast<const btConvexInternalShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexShape *)(object))
    ));
}

btConvexInternalShape *btConvexInternalShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object)
{
    return (btConvexInternalShape *)std::addressof(dynamic_cast<btConvexInternalShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexShape *)(object))
    ));
}

void btConvexInternalAabbCachingShape_Destroy(const btConvexInternalAabbCachingShape *_this)
{
    delete ((const btConvexInternalAabbCachingShape *)_this);
}

void btConvexInternalAabbCachingShape_DestroyArray(const btConvexInternalAabbCachingShape *_this)
{
    delete[] ((const btConvexInternalAabbCachingShape *)_this);
}

void btConvexInternalAabbCachingShape_setLocalScaling(btConvexInternalAabbCachingShape *_this, const btVector3 *scaling)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalAabbCachingShape *)(_this)).setLocalScaling(
        ((scaling ? void() : MRBINDC_THROW("Parameter `scaling` can not be null.", void)), *(const btVector3 *)(scaling))
    );
}

void btConvexInternalAabbCachingShape_getAabb(const btConvexInternalAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getAabb(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btConvexInternalAabbCachingShape_recalcLocalAabb(btConvexInternalAabbCachingShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalAabbCachingShape *)(_this)).recalcLocalAabb();
}

btVector3 *btConvexInternalAabbCachingShape_localGetSupportingVertex(const btConvexInternalAabbCachingShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).localGetSupportingVertex(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

const btVector3 *btConvexInternalAabbCachingShape_getImplicitShapeDimensions(const btConvexInternalAabbCachingShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getImplicitShapeDimensions());
}

void btConvexInternalAabbCachingShape_setImplicitShapeDimensions(btConvexInternalAabbCachingShape *_this, const btVector3 *dimensions)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalAabbCachingShape *)(_this)).setImplicitShapeDimensions(
        ((dimensions ? void() : MRBINDC_THROW("Parameter `dimensions` can not be null.", void)), *(const btVector3 *)(dimensions))
    );
}

void btConvexInternalAabbCachingShape_getAabbSlow(const btConvexInternalAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getAabbSlow(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

const btVector3 *btConvexInternalAabbCachingShape_getLocalScaling(const btConvexInternalAabbCachingShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getLocalScaling());
}

const btVector3 *btConvexInternalAabbCachingShape_getLocalScalingNV(const btConvexInternalAabbCachingShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getLocalScalingNV());
}

void btConvexInternalAabbCachingShape_setMargin(btConvexInternalAabbCachingShape *_this, double margin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalAabbCachingShape *)(_this)).setMargin(
        margin
    );
}

double btConvexInternalAabbCachingShape_getMargin(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getMargin();
}

double btConvexInternalAabbCachingShape_getMarginNV(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getMarginNV();
}

int btConvexInternalAabbCachingShape_getNumPreferredPenetrationDirections(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getNumPreferredPenetrationDirections();
}

void btConvexInternalAabbCachingShape_getPreferredPenetrationDirection(const btConvexInternalAabbCachingShape *_this, int index, btVector3 *penetrationVector)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getPreferredPenetrationDirection(
        index,
        ((penetrationVector ? void() : MRBINDC_THROW("Parameter `penetrationVector` can not be null.", void)), *(btVector3 *)(penetrationVector))
    );
}

int btConvexInternalAabbCachingShape_calculateSerializeBufferSize(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).calculateSerializeBufferSize();
}

btVector3 *btConvexInternalAabbCachingShape_localGetSupportingVertexWithoutMargin(const btConvexInternalAabbCachingShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).localGetSupportingVertexWithoutMargin(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btConvexInternalAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual(const btConvexInternalAabbCachingShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).localGetSupportVertexWithoutMarginNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btConvexInternalAabbCachingShape_localGetSupportVertexNonVirtual(const btConvexInternalAabbCachingShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).localGetSupportVertexNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

double btConvexInternalAabbCachingShape_getMarginNonVirtual(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getMarginNonVirtual();
}

void btConvexInternalAabbCachingShape_getAabbNonVirtual(const btConvexInternalAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getAabbNonVirtual(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btConvexInternalAabbCachingShape_project(const btConvexInternalAabbCachingShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).project(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans)),
        ((dir ? void() : MRBINDC_THROW("Parameter `dir` can not be null.", void)), *(const btVector3 *)(dir)),
        ((minProj ? void() : MRBINDC_THROW("Parameter `minProj` can not be null.", void)), *minProj),
        ((maxProj ? void() : MRBINDC_THROW("Parameter `maxProj` can not be null.", void)), *maxProj),
        ((witnesPtMin ? void() : MRBINDC_THROW("Parameter `witnesPtMin` can not be null.", void)), *(btVector3 *)(witnesPtMin)),
        ((witnesPtMax ? void() : MRBINDC_THROW("Parameter `witnesPtMax` can not be null.", void)), *(btVector3 *)(witnesPtMax))
    );
}

void btConvexInternalAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btConvexInternalAabbCachingShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).batchedUnitVectorGetSupportingVertexWithoutMargin(
        ((const btVector3 *)vectors),
        ((btVector3 *)supportVerticesOut),
        numVectors
    );
}

void btConvexInternalAabbCachingShape_getBoundingSphere(const btConvexInternalAabbCachingShape *_this, btVector3 *center, double *radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getBoundingSphere(
        ((center ? void() : MRBINDC_THROW("Parameter `center` can not be null.", void)), *(btVector3 *)(center)),
        ((radius ? void() : MRBINDC_THROW("Parameter `radius` can not be null.", void)), *radius)
    );
}

double btConvexInternalAabbCachingShape_getAngularMotionDisc(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getAngularMotionDisc();
}

double btConvexInternalAabbCachingShape_getContactBreakingThreshold(const btConvexInternalAabbCachingShape *_this, double defaultContactThresholdFactor)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getContactBreakingThreshold(
        defaultContactThresholdFactor
    );
}

void btConvexInternalAabbCachingShape_calculateTemporalAabb(const btConvexInternalAabbCachingShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).calculateTemporalAabb(
        ((curTrans ? void() : MRBINDC_THROW("Parameter `curTrans` can not be null.", void)), *(const btTransform *)(curTrans)),
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel)),
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel)),
        timeStep,
        ((temporalAabbMin ? void() : MRBINDC_THROW("Parameter `temporalAabbMin` can not be null.", void)), *(btVector3 *)(temporalAabbMin)),
        ((temporalAabbMax ? void() : MRBINDC_THROW("Parameter `temporalAabbMax` can not be null.", void)), *(btVector3 *)(temporalAabbMax))
    );
}

bool btConvexInternalAabbCachingShape_isPolyhedral(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).isPolyhedral();
}

bool btConvexInternalAabbCachingShape_isConvex2d(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).isConvex2d();
}

bool btConvexInternalAabbCachingShape_isConvex(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).isConvex();
}

bool btConvexInternalAabbCachingShape_isNonMoving(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).isNonMoving();
}

bool btConvexInternalAabbCachingShape_isConcave(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).isConcave();
}

bool btConvexInternalAabbCachingShape_isCompound(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).isCompound();
}

bool btConvexInternalAabbCachingShape_isSoftBody(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).isSoftBody();
}

bool btConvexInternalAabbCachingShape_isInfinite(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).isInfinite();
}

void btConvexInternalAabbCachingShape_calculateLocalInertia(const btConvexInternalAabbCachingShape *_this, double mass, btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).calculateLocalInertia(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(btVector3 *)(inertia))
    );
}

const char *btConvexInternalAabbCachingShape_getName(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getName();
}

int btConvexInternalAabbCachingShape_getShapeType(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getShapeType();
}

btVector3 *btConvexInternalAabbCachingShape_getAnisotropicRollingFrictionDirection(const btConvexInternalAabbCachingShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getAnisotropicRollingFrictionDirection());
}

void btConvexInternalAabbCachingShape_setUserPointer(btConvexInternalAabbCachingShape *_this, void *userPtr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalAabbCachingShape *)(_this)).setUserPointer(
        userPtr
    );
}

void *btConvexInternalAabbCachingShape_getUserPointer(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getUserPointer();
}

void btConvexInternalAabbCachingShape_setUserIndex(btConvexInternalAabbCachingShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalAabbCachingShape *)(_this)).setUserIndex(
        index
    );
}

int btConvexInternalAabbCachingShape_getUserIndex(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getUserIndex();
}

void btConvexInternalAabbCachingShape_setUserIndex2(btConvexInternalAabbCachingShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConvexInternalAabbCachingShape *)(_this)).setUserIndex2(
        index
    );
}

int btConvexInternalAabbCachingShape_getUserIndex2(const btConvexInternalAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btConvexInternalAabbCachingShape *)(_this)).getUserIndex2();
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_OffsetPtr(const btConvexInternalAabbCachingShape *ptr, ptrdiff_t i)
{
    return (const btConvexInternalAabbCachingShape *)(((const btConvexInternalAabbCachingShape *)ptr) + i);
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_OffsetMutablePtr(btConvexInternalAabbCachingShape *ptr, ptrdiff_t i)
{
    return (btConvexInternalAabbCachingShape *)(((btConvexInternalAabbCachingShape *)ptr) + i);
}

const btCollisionShape *btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape(const btConvexInternalAabbCachingShape *object)
{
    return (const btCollisionShape *)(static_cast<const btCollisionShape *>(
        ((const btConvexInternalAabbCachingShape *)object)
    ));
}

btCollisionShape *btConvexInternalAabbCachingShape_MutableUpcastTo_btCollisionShape(btConvexInternalAabbCachingShape *object)
{
    return (btCollisionShape *)(static_cast<btCollisionShape *>(
        ((btConvexInternalAabbCachingShape *)object)
    ));
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btConvexInternalAabbCachingShape *)(static_cast<const btConvexInternalAabbCachingShape *>(
        ((const btCollisionShape *)object)
    ));
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btConvexInternalAabbCachingShape *)(static_cast<btConvexInternalAabbCachingShape *>(
        ((btCollisionShape *)object)
    ));
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btConvexInternalAabbCachingShape *)(dynamic_cast<const btConvexInternalAabbCachingShape *>(
        ((const btCollisionShape *)object)
    ));
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btConvexInternalAabbCachingShape *)(dynamic_cast<btConvexInternalAabbCachingShape *>(
        ((btCollisionShape *)object)
    ));
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object)
{
    return (const btConvexInternalAabbCachingShape *)std::addressof(dynamic_cast<const btConvexInternalAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionShape *)(object))
    ));
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object)
{
    return (btConvexInternalAabbCachingShape *)std::addressof(dynamic_cast<btConvexInternalAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionShape *)(object))
    ));
}

const btConvexShape *btConvexInternalAabbCachingShape_UpcastTo_btConvexShape(const btConvexInternalAabbCachingShape *object)
{
    return (const btConvexShape *)(static_cast<const btConvexShape *>(
        ((const btConvexInternalAabbCachingShape *)object)
    ));
}

btConvexShape *btConvexInternalAabbCachingShape_MutableUpcastTo_btConvexShape(btConvexInternalAabbCachingShape *object)
{
    return (btConvexShape *)(static_cast<btConvexShape *>(
        ((btConvexInternalAabbCachingShape *)object)
    ));
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btConvexInternalAabbCachingShape *)(static_cast<const btConvexInternalAabbCachingShape *>(
        ((const btConvexShape *)object)
    ));
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btConvexInternalAabbCachingShape *)(static_cast<btConvexInternalAabbCachingShape *>(
        ((btConvexShape *)object)
    ));
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btConvexInternalAabbCachingShape *)(dynamic_cast<const btConvexInternalAabbCachingShape *>(
        ((const btConvexShape *)object)
    ));
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btConvexInternalAabbCachingShape *)(dynamic_cast<btConvexInternalAabbCachingShape *>(
        ((btConvexShape *)object)
    ));
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object)
{
    return (const btConvexInternalAabbCachingShape *)std::addressof(dynamic_cast<const btConvexInternalAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexShape *)(object))
    ));
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object)
{
    return (btConvexInternalAabbCachingShape *)std::addressof(dynamic_cast<btConvexInternalAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexShape *)(object))
    ));
}

const btConvexInternalShape *btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape(const btConvexInternalAabbCachingShape *object)
{
    return (const btConvexInternalShape *)(static_cast<const btConvexInternalShape *>(
        ((const btConvexInternalAabbCachingShape *)object)
    ));
}

btConvexInternalShape *btConvexInternalAabbCachingShape_MutableUpcastTo_btConvexInternalShape(btConvexInternalAabbCachingShape *object)
{
    return (btConvexInternalShape *)(static_cast<btConvexInternalShape *>(
        ((btConvexInternalAabbCachingShape *)object)
    ));
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btConvexInternalAabbCachingShape *)(static_cast<const btConvexInternalAabbCachingShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btConvexInternalAabbCachingShape *)(static_cast<btConvexInternalAabbCachingShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btConvexInternalAabbCachingShape *)(dynamic_cast<const btConvexInternalAabbCachingShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btConvexInternalAabbCachingShape *)(dynamic_cast<btConvexInternalAabbCachingShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btConvexInternalAabbCachingShape *)std::addressof(dynamic_cast<const btConvexInternalAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexInternalShape *)(object))
    ));
}

btConvexInternalAabbCachingShape *btConvexInternalAabbCachingShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btConvexInternalAabbCachingShape *)std::addressof(dynamic_cast<btConvexInternalAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexInternalShape *)(object))
    ));
}

