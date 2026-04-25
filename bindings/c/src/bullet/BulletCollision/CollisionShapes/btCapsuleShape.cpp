// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionShapes/btCapsuleShape.h"

#include <BulletCollision/CollisionShapes/btCapsuleShape.h>
#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletCollision/CollisionShapes/btConvexInternalShape.h>
#include <BulletCollision/CollisionShapes/btConvexShape.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btCapsuleShape *btCapsuleShape_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCapsuleShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCapsuleShape);
    return (btCapsuleShape *)new btCapsuleShape(btCapsuleShape(
        (MRBINDC_CLASSARG_COPY(_other, (btCapsuleShape), btCapsuleShape) MRBINDC_CLASSARG_MOVE(_other, (btCapsuleShape), btCapsuleShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCapsuleShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCapsuleShape) MRBINDC_CLASSARG_END(_other, btCapsuleShape))
    ));
}

const btCapsuleShape *btCapsuleShape_OffsetPtr(const btCapsuleShape *ptr, ptrdiff_t i)
{
    return (const btCapsuleShape *)(((const btCapsuleShape *)ptr) + i);
}

btCapsuleShape *btCapsuleShape_OffsetMutablePtr(btCapsuleShape *ptr, ptrdiff_t i)
{
    return (btCapsuleShape *)(((btCapsuleShape *)ptr) + i);
}

const btCollisionShape *btCapsuleShape_UpcastTo_btCollisionShape(const btCapsuleShape *object)
{
    return (const btCollisionShape *)(static_cast<const btCollisionShape *>(
        ((const btCapsuleShape *)object)
    ));
}

btCollisionShape *btCapsuleShape_MutableUpcastTo_btCollisionShape(btCapsuleShape *object)
{
    return (btCollisionShape *)(static_cast<btCollisionShape *>(
        ((btCapsuleShape *)object)
    ));
}

const btCapsuleShape *btCapsuleShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btCapsuleShape *)(static_cast<const btCapsuleShape *>(
        ((const btCollisionShape *)object)
    ));
}

btCapsuleShape *btCapsuleShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btCapsuleShape *)(static_cast<btCapsuleShape *>(
        ((btCollisionShape *)object)
    ));
}

const btCapsuleShape *btCapsuleShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btCapsuleShape *)(dynamic_cast<const btCapsuleShape *>(
        ((const btCollisionShape *)object)
    ));
}

btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btCapsuleShape *)(dynamic_cast<btCapsuleShape *>(
        ((btCollisionShape *)object)
    ));
}

const btCapsuleShape *btCapsuleShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object)
{
    return (const btCapsuleShape *)std::addressof(dynamic_cast<const btCapsuleShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionShape *)(object))
    ));
}

btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object)
{
    return (btCapsuleShape *)std::addressof(dynamic_cast<btCapsuleShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionShape *)(object))
    ));
}

const btConvexShape *btCapsuleShape_UpcastTo_btConvexShape(const btCapsuleShape *object)
{
    return (const btConvexShape *)(static_cast<const btConvexShape *>(
        ((const btCapsuleShape *)object)
    ));
}

btConvexShape *btCapsuleShape_MutableUpcastTo_btConvexShape(btCapsuleShape *object)
{
    return (btConvexShape *)(static_cast<btConvexShape *>(
        ((btCapsuleShape *)object)
    ));
}

const btCapsuleShape *btCapsuleShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btCapsuleShape *)(static_cast<const btCapsuleShape *>(
        ((const btConvexShape *)object)
    ));
}

btCapsuleShape *btCapsuleShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btCapsuleShape *)(static_cast<btCapsuleShape *>(
        ((btConvexShape *)object)
    ));
}

const btCapsuleShape *btCapsuleShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btCapsuleShape *)(dynamic_cast<const btCapsuleShape *>(
        ((const btConvexShape *)object)
    ));
}

btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btCapsuleShape *)(dynamic_cast<btCapsuleShape *>(
        ((btConvexShape *)object)
    ));
}

const btCapsuleShape *btCapsuleShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object)
{
    return (const btCapsuleShape *)std::addressof(dynamic_cast<const btCapsuleShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexShape *)(object))
    ));
}

btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object)
{
    return (btCapsuleShape *)std::addressof(dynamic_cast<btCapsuleShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexShape *)(object))
    ));
}

const btConvexInternalShape *btCapsuleShape_UpcastTo_btConvexInternalShape(const btCapsuleShape *object)
{
    return (const btConvexInternalShape *)(static_cast<const btConvexInternalShape *>(
        ((const btCapsuleShape *)object)
    ));
}

btConvexInternalShape *btCapsuleShape_MutableUpcastTo_btConvexInternalShape(btCapsuleShape *object)
{
    return (btConvexInternalShape *)(static_cast<btConvexInternalShape *>(
        ((btCapsuleShape *)object)
    ));
}

const btCapsuleShape *btCapsuleShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btCapsuleShape *)(static_cast<const btCapsuleShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btCapsuleShape *btCapsuleShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btCapsuleShape *)(static_cast<btCapsuleShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btCapsuleShape *btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btCapsuleShape *)(dynamic_cast<const btCapsuleShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btCapsuleShape *)(dynamic_cast<btCapsuleShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btCapsuleShape *btCapsuleShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btCapsuleShape *)std::addressof(dynamic_cast<const btCapsuleShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexInternalShape *)(object))
    ));
}

btCapsuleShape *btCapsuleShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btCapsuleShape *)std::addressof(dynamic_cast<btCapsuleShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexInternalShape *)(object))
    ));
}

btCapsuleShape *btCapsuleShape_Construct(double radius, double height)
{
    return (btCapsuleShape *)new btCapsuleShape(btCapsuleShape(
        radius,
        height
    ));
}

void btCapsuleShape_Destroy(const btCapsuleShape *_this)
{
    delete ((const btCapsuleShape *)_this);
}

void btCapsuleShape_DestroyArray(const btCapsuleShape *_this)
{
    delete[] ((const btCapsuleShape *)_this);
}

btCapsuleShape *btCapsuleShape_AssignFromAnother(btCapsuleShape *_this, Bullet_PassBy _other_pass_by, btCapsuleShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCapsuleShape);
    return (btCapsuleShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCapsuleShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (btCapsuleShape), btCapsuleShape) MRBINDC_CLASSARG_MOVE(_other, (btCapsuleShape), btCapsuleShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCapsuleShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCapsuleShape) MRBINDC_CLASSARG_END(_other, btCapsuleShape))
    ));
}

void *Bullet_new_btCapsuleShape_unsigned_long(unsigned long sizeInBytes)
{
    return btCapsuleShape::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btCapsuleShape_void_ptr(void *ptr)
{
    btCapsuleShape::operator delete(
        ptr
    );
}

void *Bullet_new_btCapsuleShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btCapsuleShape::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btCapsuleShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btCapsuleShape::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btCapsuleShape_unsigned_long(unsigned long sizeInBytes)
{
    return btCapsuleShape::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btCapsuleShape_void_ptr(void *ptr)
{
    btCapsuleShape::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btCapsuleShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btCapsuleShape::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btCapsuleShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btCapsuleShape::operator delete[](
        _1,
        _2
    );
}

void btCapsuleShape_calculateLocalInertia(const btCapsuleShape *_this, double mass, btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).calculateLocalInertia(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(btVector3 *)(inertia))
    );
}

btVector3 *btCapsuleShape_localGetSupportingVertexWithoutMargin(const btCapsuleShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).localGetSupportingVertexWithoutMargin(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

void btCapsuleShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btCapsuleShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).batchedUnitVectorGetSupportingVertexWithoutMargin(
        ((const btVector3 *)vectors),
        ((btVector3 *)supportVerticesOut),
        numVectors
    );
}

void btCapsuleShape_setMargin(btCapsuleShape *_this, double collisionMargin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCapsuleShape *)(_this)).setMargin(
        collisionMargin
    );
}

void btCapsuleShape_getAabb(const btCapsuleShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getAabb(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

const char *btCapsuleShape_getName(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getName();
}

int btCapsuleShape_getUpAxis(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getUpAxis();
}

double btCapsuleShape_getRadius(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getRadius();
}

double btCapsuleShape_getHalfHeight(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getHalfHeight();
}

void btCapsuleShape_setLocalScaling(btCapsuleShape *_this, const btVector3 *scaling)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCapsuleShape *)(_this)).setLocalScaling(
        ((scaling ? void() : MRBINDC_THROW("Parameter `scaling` can not be null.", void)), *(const btVector3 *)(scaling))
    );
}

btVector3 *btCapsuleShape_getAnisotropicRollingFrictionDirection(const btCapsuleShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getAnisotropicRollingFrictionDirection());
}

int btCapsuleShape_calculateSerializeBufferSize(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).calculateSerializeBufferSize();
}

btVector3 *btCapsuleShape_localGetSupportingVertex(const btCapsuleShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).localGetSupportingVertex(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

const btVector3 *btCapsuleShape_getImplicitShapeDimensions(const btCapsuleShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getImplicitShapeDimensions());
}

void btCapsuleShape_setImplicitShapeDimensions(btCapsuleShape *_this, const btVector3 *dimensions)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCapsuleShape *)(_this)).setImplicitShapeDimensions(
        ((dimensions ? void() : MRBINDC_THROW("Parameter `dimensions` can not be null.", void)), *(const btVector3 *)(dimensions))
    );
}

void btCapsuleShape_getAabbSlow(const btCapsuleShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getAabbSlow(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

const btVector3 *btCapsuleShape_getLocalScaling(const btCapsuleShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getLocalScaling());
}

const btVector3 *btCapsuleShape_getLocalScalingNV(const btCapsuleShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getLocalScalingNV());
}

double btCapsuleShape_getMargin(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getMargin();
}

double btCapsuleShape_getMarginNV(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getMarginNV();
}

int btCapsuleShape_getNumPreferredPenetrationDirections(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getNumPreferredPenetrationDirections();
}

void btCapsuleShape_getPreferredPenetrationDirection(const btCapsuleShape *_this, int index, btVector3 *penetrationVector)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getPreferredPenetrationDirection(
        index,
        ((penetrationVector ? void() : MRBINDC_THROW("Parameter `penetrationVector` can not be null.", void)), *(btVector3 *)(penetrationVector))
    );
}

btVector3 *btCapsuleShape_localGetSupportVertexWithoutMarginNonVirtual(const btCapsuleShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).localGetSupportVertexWithoutMarginNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btCapsuleShape_localGetSupportVertexNonVirtual(const btCapsuleShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).localGetSupportVertexNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

double btCapsuleShape_getMarginNonVirtual(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getMarginNonVirtual();
}

void btCapsuleShape_getAabbNonVirtual(const btCapsuleShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getAabbNonVirtual(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btCapsuleShape_project(const btCapsuleShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).project(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans)),
        ((dir ? void() : MRBINDC_THROW("Parameter `dir` can not be null.", void)), *(const btVector3 *)(dir)),
        ((minProj ? void() : MRBINDC_THROW("Parameter `minProj` can not be null.", void)), *minProj),
        ((maxProj ? void() : MRBINDC_THROW("Parameter `maxProj` can not be null.", void)), *maxProj),
        ((witnesPtMin ? void() : MRBINDC_THROW("Parameter `witnesPtMin` can not be null.", void)), *(btVector3 *)(witnesPtMin)),
        ((witnesPtMax ? void() : MRBINDC_THROW("Parameter `witnesPtMax` can not be null.", void)), *(btVector3 *)(witnesPtMax))
    );
}

void btCapsuleShape_getBoundingSphere(const btCapsuleShape *_this, btVector3 *center, double *radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getBoundingSphere(
        ((center ? void() : MRBINDC_THROW("Parameter `center` can not be null.", void)), *(btVector3 *)(center)),
        ((radius ? void() : MRBINDC_THROW("Parameter `radius` can not be null.", void)), *radius)
    );
}

double btCapsuleShape_getAngularMotionDisc(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getAngularMotionDisc();
}

double btCapsuleShape_getContactBreakingThreshold(const btCapsuleShape *_this, double defaultContactThresholdFactor)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getContactBreakingThreshold(
        defaultContactThresholdFactor
    );
}

void btCapsuleShape_calculateTemporalAabb(const btCapsuleShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).calculateTemporalAabb(
        ((curTrans ? void() : MRBINDC_THROW("Parameter `curTrans` can not be null.", void)), *(const btTransform *)(curTrans)),
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel)),
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel)),
        timeStep,
        ((temporalAabbMin ? void() : MRBINDC_THROW("Parameter `temporalAabbMin` can not be null.", void)), *(btVector3 *)(temporalAabbMin)),
        ((temporalAabbMax ? void() : MRBINDC_THROW("Parameter `temporalAabbMax` can not be null.", void)), *(btVector3 *)(temporalAabbMax))
    );
}

bool btCapsuleShape_isPolyhedral(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).isPolyhedral();
}

bool btCapsuleShape_isConvex2d(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).isConvex2d();
}

bool btCapsuleShape_isConvex(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).isConvex();
}

bool btCapsuleShape_isNonMoving(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).isNonMoving();
}

bool btCapsuleShape_isConcave(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).isConcave();
}

bool btCapsuleShape_isCompound(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).isCompound();
}

bool btCapsuleShape_isSoftBody(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).isSoftBody();
}

bool btCapsuleShape_isInfinite(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).isInfinite();
}

int btCapsuleShape_getShapeType(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getShapeType();
}

void btCapsuleShape_setUserPointer(btCapsuleShape *_this, void *userPtr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCapsuleShape *)(_this)).setUserPointer(
        userPtr
    );
}

void *btCapsuleShape_getUserPointer(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getUserPointer();
}

void btCapsuleShape_setUserIndex(btCapsuleShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCapsuleShape *)(_this)).setUserIndex(
        index
    );
}

int btCapsuleShape_getUserIndex(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getUserIndex();
}

void btCapsuleShape_setUserIndex2(btCapsuleShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCapsuleShape *)(_this)).setUserIndex2(
        index
    );
}

int btCapsuleShape_getUserIndex2(const btCapsuleShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCapsuleShape *)(_this)).getUserIndex2();
}

