// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionShapes/btSphereShape.h"

#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletCollision/CollisionShapes/btConvexInternalShape.h>
#include <BulletCollision/CollisionShapes/btConvexShape.h>
#include <BulletCollision/CollisionShapes/btSphereShape.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btSphereShape *btSphereShape_ConstructFromAnother(Bullet_PassBy _other_pass_by, btSphereShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btSphereShape);
    return (btSphereShape *)new btSphereShape(btSphereShape(
        (MRBINDC_CLASSARG_COPY(_other, (btSphereShape), btSphereShape) MRBINDC_CLASSARG_MOVE(_other, (btSphereShape), btSphereShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btSphereShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btSphereShape) MRBINDC_CLASSARG_END(_other, btSphereShape))
    ));
}

const btSphereShape *btSphereShape_OffsetPtr(const btSphereShape *ptr, ptrdiff_t i)
{
    return (const btSphereShape *)(((const btSphereShape *)ptr) + i);
}

btSphereShape *btSphereShape_OffsetMutablePtr(btSphereShape *ptr, ptrdiff_t i)
{
    return (btSphereShape *)(((btSphereShape *)ptr) + i);
}

const btCollisionShape *btSphereShape_UpcastTo_btCollisionShape(const btSphereShape *object)
{
    return (const btCollisionShape *)(static_cast<const btCollisionShape *>(
        ((const btSphereShape *)object)
    ));
}

btCollisionShape *btSphereShape_MutableUpcastTo_btCollisionShape(btSphereShape *object)
{
    return (btCollisionShape *)(static_cast<btCollisionShape *>(
        ((btSphereShape *)object)
    ));
}

const btSphereShape *btSphereShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btSphereShape *)(static_cast<const btSphereShape *>(
        ((const btCollisionShape *)object)
    ));
}

btSphereShape *btSphereShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btSphereShape *)(static_cast<btSphereShape *>(
        ((btCollisionShape *)object)
    ));
}

const btSphereShape *btSphereShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btSphereShape *)(dynamic_cast<const btSphereShape *>(
        ((const btCollisionShape *)object)
    ));
}

btSphereShape *btSphereShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btSphereShape *)(dynamic_cast<btSphereShape *>(
        ((btCollisionShape *)object)
    ));
}

const btSphereShape *btSphereShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object)
{
    return (const btSphereShape *)std::addressof(dynamic_cast<const btSphereShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionShape *)(object))
    ));
}

btSphereShape *btSphereShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object)
{
    return (btSphereShape *)std::addressof(dynamic_cast<btSphereShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionShape *)(object))
    ));
}

const btConvexShape *btSphereShape_UpcastTo_btConvexShape(const btSphereShape *object)
{
    return (const btConvexShape *)(static_cast<const btConvexShape *>(
        ((const btSphereShape *)object)
    ));
}

btConvexShape *btSphereShape_MutableUpcastTo_btConvexShape(btSphereShape *object)
{
    return (btConvexShape *)(static_cast<btConvexShape *>(
        ((btSphereShape *)object)
    ));
}

const btSphereShape *btSphereShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btSphereShape *)(static_cast<const btSphereShape *>(
        ((const btConvexShape *)object)
    ));
}

btSphereShape *btSphereShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btSphereShape *)(static_cast<btSphereShape *>(
        ((btConvexShape *)object)
    ));
}

const btSphereShape *btSphereShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btSphereShape *)(dynamic_cast<const btSphereShape *>(
        ((const btConvexShape *)object)
    ));
}

btSphereShape *btSphereShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btSphereShape *)(dynamic_cast<btSphereShape *>(
        ((btConvexShape *)object)
    ));
}

const btSphereShape *btSphereShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object)
{
    return (const btSphereShape *)std::addressof(dynamic_cast<const btSphereShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexShape *)(object))
    ));
}

btSphereShape *btSphereShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object)
{
    return (btSphereShape *)std::addressof(dynamic_cast<btSphereShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexShape *)(object))
    ));
}

const btConvexInternalShape *btSphereShape_UpcastTo_btConvexInternalShape(const btSphereShape *object)
{
    return (const btConvexInternalShape *)(static_cast<const btConvexInternalShape *>(
        ((const btSphereShape *)object)
    ));
}

btConvexInternalShape *btSphereShape_MutableUpcastTo_btConvexInternalShape(btSphereShape *object)
{
    return (btConvexInternalShape *)(static_cast<btConvexInternalShape *>(
        ((btSphereShape *)object)
    ));
}

const btSphereShape *btSphereShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btSphereShape *)(static_cast<const btSphereShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btSphereShape *btSphereShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btSphereShape *)(static_cast<btSphereShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btSphereShape *btSphereShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btSphereShape *)(dynamic_cast<const btSphereShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btSphereShape *btSphereShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btSphereShape *)(dynamic_cast<btSphereShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btSphereShape *btSphereShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btSphereShape *)std::addressof(dynamic_cast<const btSphereShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexInternalShape *)(object))
    ));
}

btSphereShape *btSphereShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btSphereShape *)std::addressof(dynamic_cast<btSphereShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexInternalShape *)(object))
    ));
}

btSphereShape *btSphereShape_Construct(double radius)
{
    return (btSphereShape *)new btSphereShape(btSphereShape(
        radius
    ));
}

void btSphereShape_Destroy(const btSphereShape *_this)
{
    delete ((const btSphereShape *)_this);
}

void btSphereShape_DestroyArray(const btSphereShape *_this)
{
    delete[] ((const btSphereShape *)_this);
}

btSphereShape *btSphereShape_AssignFromAnother(btSphereShape *_this, Bullet_PassBy _other_pass_by, btSphereShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btSphereShape);
    return (btSphereShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSphereShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (btSphereShape), btSphereShape) MRBINDC_CLASSARG_MOVE(_other, (btSphereShape), btSphereShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btSphereShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btSphereShape) MRBINDC_CLASSARG_END(_other, btSphereShape))
    ));
}

void *Bullet_new_btSphereShape_unsigned_long(unsigned long sizeInBytes)
{
    return btSphereShape::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btSphereShape_void_ptr(void *ptr)
{
    btSphereShape::operator delete(
        ptr
    );
}

void *Bullet_new_btSphereShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btSphereShape::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btSphereShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btSphereShape::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btSphereShape_unsigned_long(unsigned long sizeInBytes)
{
    return btSphereShape::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btSphereShape_void_ptr(void *ptr)
{
    btSphereShape::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btSphereShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btSphereShape::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btSphereShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btSphereShape::operator delete[](
        _1,
        _2
    );
}

btVector3 *btSphereShape_localGetSupportingVertex(const btSphereShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).localGetSupportingVertex(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btSphereShape_localGetSupportingVertexWithoutMargin(const btSphereShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).localGetSupportingVertexWithoutMargin(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

void btSphereShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btSphereShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).batchedUnitVectorGetSupportingVertexWithoutMargin(
        ((const btVector3 *)vectors),
        ((btVector3 *)supportVerticesOut),
        numVectors
    );
}

void btSphereShape_calculateLocalInertia(const btSphereShape *_this, double mass, btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).calculateLocalInertia(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(btVector3 *)(inertia))
    );
}

void btSphereShape_getAabb(const btSphereShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getAabb(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

double btSphereShape_getRadius(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getRadius();
}

void btSphereShape_setUnscaledRadius(btSphereShape *_this, double radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSphereShape *)(_this)).setUnscaledRadius(
        radius
    );
}

const char *btSphereShape_getName(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getName();
}

void btSphereShape_setMargin(btSphereShape *_this, double margin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSphereShape *)(_this)).setMargin(
        margin
    );
}

double btSphereShape_getMargin(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getMargin();
}

const btVector3 *btSphereShape_getImplicitShapeDimensions(const btSphereShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getImplicitShapeDimensions());
}

void btSphereShape_setImplicitShapeDimensions(btSphereShape *_this, const btVector3 *dimensions)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSphereShape *)(_this)).setImplicitShapeDimensions(
        ((dimensions ? void() : MRBINDC_THROW("Parameter `dimensions` can not be null.", void)), *(const btVector3 *)(dimensions))
    );
}

void btSphereShape_getAabbSlow(const btSphereShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getAabbSlow(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btSphereShape_setLocalScaling(btSphereShape *_this, const btVector3 *scaling)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSphereShape *)(_this)).setLocalScaling(
        ((scaling ? void() : MRBINDC_THROW("Parameter `scaling` can not be null.", void)), *(const btVector3 *)(scaling))
    );
}

const btVector3 *btSphereShape_getLocalScaling(const btSphereShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getLocalScaling());
}

const btVector3 *btSphereShape_getLocalScalingNV(const btSphereShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getLocalScalingNV());
}

double btSphereShape_getMarginNV(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getMarginNV();
}

int btSphereShape_getNumPreferredPenetrationDirections(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getNumPreferredPenetrationDirections();
}

void btSphereShape_getPreferredPenetrationDirection(const btSphereShape *_this, int index, btVector3 *penetrationVector)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getPreferredPenetrationDirection(
        index,
        ((penetrationVector ? void() : MRBINDC_THROW("Parameter `penetrationVector` can not be null.", void)), *(btVector3 *)(penetrationVector))
    );
}

int btSphereShape_calculateSerializeBufferSize(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).calculateSerializeBufferSize();
}

btVector3 *btSphereShape_localGetSupportVertexWithoutMarginNonVirtual(const btSphereShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).localGetSupportVertexWithoutMarginNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btSphereShape_localGetSupportVertexNonVirtual(const btSphereShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).localGetSupportVertexNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

double btSphereShape_getMarginNonVirtual(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getMarginNonVirtual();
}

void btSphereShape_getAabbNonVirtual(const btSphereShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getAabbNonVirtual(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btSphereShape_project(const btSphereShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).project(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans)),
        ((dir ? void() : MRBINDC_THROW("Parameter `dir` can not be null.", void)), *(const btVector3 *)(dir)),
        ((minProj ? void() : MRBINDC_THROW("Parameter `minProj` can not be null.", void)), *minProj),
        ((maxProj ? void() : MRBINDC_THROW("Parameter `maxProj` can not be null.", void)), *maxProj),
        ((witnesPtMin ? void() : MRBINDC_THROW("Parameter `witnesPtMin` can not be null.", void)), *(btVector3 *)(witnesPtMin)),
        ((witnesPtMax ? void() : MRBINDC_THROW("Parameter `witnesPtMax` can not be null.", void)), *(btVector3 *)(witnesPtMax))
    );
}

void btSphereShape_getBoundingSphere(const btSphereShape *_this, btVector3 *center, double *radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getBoundingSphere(
        ((center ? void() : MRBINDC_THROW("Parameter `center` can not be null.", void)), *(btVector3 *)(center)),
        ((radius ? void() : MRBINDC_THROW("Parameter `radius` can not be null.", void)), *radius)
    );
}

double btSphereShape_getAngularMotionDisc(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getAngularMotionDisc();
}

double btSphereShape_getContactBreakingThreshold(const btSphereShape *_this, double defaultContactThresholdFactor)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getContactBreakingThreshold(
        defaultContactThresholdFactor
    );
}

void btSphereShape_calculateTemporalAabb(const btSphereShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).calculateTemporalAabb(
        ((curTrans ? void() : MRBINDC_THROW("Parameter `curTrans` can not be null.", void)), *(const btTransform *)(curTrans)),
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel)),
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel)),
        timeStep,
        ((temporalAabbMin ? void() : MRBINDC_THROW("Parameter `temporalAabbMin` can not be null.", void)), *(btVector3 *)(temporalAabbMin)),
        ((temporalAabbMax ? void() : MRBINDC_THROW("Parameter `temporalAabbMax` can not be null.", void)), *(btVector3 *)(temporalAabbMax))
    );
}

bool btSphereShape_isPolyhedral(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).isPolyhedral();
}

bool btSphereShape_isConvex2d(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).isConvex2d();
}

bool btSphereShape_isConvex(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).isConvex();
}

bool btSphereShape_isNonMoving(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).isNonMoving();
}

bool btSphereShape_isConcave(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).isConcave();
}

bool btSphereShape_isCompound(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).isCompound();
}

bool btSphereShape_isSoftBody(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).isSoftBody();
}

bool btSphereShape_isInfinite(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).isInfinite();
}

int btSphereShape_getShapeType(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getShapeType();
}

btVector3 *btSphereShape_getAnisotropicRollingFrictionDirection(const btSphereShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getAnisotropicRollingFrictionDirection());
}

void btSphereShape_setUserPointer(btSphereShape *_this, void *userPtr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSphereShape *)(_this)).setUserPointer(
        userPtr
    );
}

void *btSphereShape_getUserPointer(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getUserPointer();
}

void btSphereShape_setUserIndex(btSphereShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSphereShape *)(_this)).setUserIndex(
        index
    );
}

int btSphereShape_getUserIndex(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getUserIndex();
}

void btSphereShape_setUserIndex2(btSphereShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSphereShape *)(_this)).setUserIndex2(
        index
    );
}

int btSphereShape_getUserIndex2(const btSphereShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSphereShape *)(_this)).getUserIndex2();
}

