// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionShapes/btPolyhedralConvexShape.h"

#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletCollision/CollisionShapes/btConvexInternalShape.h>
#include <BulletCollision/CollisionShapes/btConvexShape.h>
#include <BulletCollision/CollisionShapes/btPolyhedralConvexShape.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


void btPolyhedralConvexShape_Destroy(const btPolyhedralConvexShape *_this)
{
    delete ((const btPolyhedralConvexShape *)_this);
}

void btPolyhedralConvexShape_DestroyArray(const btPolyhedralConvexShape *_this)
{
    delete[] ((const btPolyhedralConvexShape *)_this);
}

void *Bullet_new_btPolyhedralConvexShape_unsigned_long(unsigned long sizeInBytes)
{
    return btPolyhedralConvexShape::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btPolyhedralConvexShape_void_ptr(void *ptr)
{
    btPolyhedralConvexShape::operator delete(
        ptr
    );
}

void *Bullet_new_btPolyhedralConvexShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btPolyhedralConvexShape::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btPolyhedralConvexShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btPolyhedralConvexShape::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btPolyhedralConvexShape_unsigned_long(unsigned long sizeInBytes)
{
    return btPolyhedralConvexShape::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btPolyhedralConvexShape_void_ptr(void *ptr)
{
    btPolyhedralConvexShape::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btPolyhedralConvexShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btPolyhedralConvexShape::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btPolyhedralConvexShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btPolyhedralConvexShape::operator delete[](
        _1,
        _2
    );
}

bool btPolyhedralConvexShape_initializePolyhedralFeatures(btPolyhedralConvexShape *_this, const int *shiftVerticesByMargin)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexShape *)(_this)).initializePolyhedralFeatures(
        (shiftVerticesByMargin ? *shiftVerticesByMargin : static_cast<int>(0))
    );
}

btVector3 *btPolyhedralConvexShape_localGetSupportingVertexWithoutMargin(const btPolyhedralConvexShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).localGetSupportingVertexWithoutMargin(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

void btPolyhedralConvexShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btPolyhedralConvexShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).batchedUnitVectorGetSupportingVertexWithoutMargin(
        ((const btVector3 *)vectors),
        ((btVector3 *)supportVerticesOut),
        numVectors
    );
}

void btPolyhedralConvexShape_calculateLocalInertia(const btPolyhedralConvexShape *_this, double mass, btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).calculateLocalInertia(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(btVector3 *)(inertia))
    );
}

int btPolyhedralConvexShape_getNumVertices(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getNumVertices();
}

int btPolyhedralConvexShape_getNumEdges(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getNumEdges();
}

void btPolyhedralConvexShape_getEdge(const btPolyhedralConvexShape *_this, int i, btVector3 *pa, btVector3 *pb)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getEdge(
        i,
        ((pa ? void() : MRBINDC_THROW("Parameter `pa` can not be null.", void)), *(btVector3 *)(pa)),
        ((pb ? void() : MRBINDC_THROW("Parameter `pb` can not be null.", void)), *(btVector3 *)(pb))
    );
}

void btPolyhedralConvexShape_getVertex(const btPolyhedralConvexShape *_this, int i, btVector3 *vtx)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getVertex(
        i,
        ((vtx ? void() : MRBINDC_THROW("Parameter `vtx` can not be null.", void)), *(btVector3 *)(vtx))
    );
}

int btPolyhedralConvexShape_getNumPlanes(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getNumPlanes();
}

void btPolyhedralConvexShape_getPlane(const btPolyhedralConvexShape *_this, btVector3 *planeNormal, btVector3 *planeSupport, int i)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getPlane(
        ((planeNormal ? void() : MRBINDC_THROW("Parameter `planeNormal` can not be null.", void)), *(btVector3 *)(planeNormal)),
        ((planeSupport ? void() : MRBINDC_THROW("Parameter `planeSupport` can not be null.", void)), *(btVector3 *)(planeSupport)),
        i
    );
}

bool btPolyhedralConvexShape_isInside(const btPolyhedralConvexShape *_this, const btVector3 *pt, double tolerance)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).isInside(
        ((pt ? void() : MRBINDC_THROW("Parameter `pt` can not be null.", void)), *(const btVector3 *)(pt)),
        tolerance
    );
}

btVector3 *btPolyhedralConvexShape_localGetSupportingVertex(const btPolyhedralConvexShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).localGetSupportingVertex(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

const btVector3 *btPolyhedralConvexShape_getImplicitShapeDimensions(const btPolyhedralConvexShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getImplicitShapeDimensions());
}

void btPolyhedralConvexShape_setImplicitShapeDimensions(btPolyhedralConvexShape *_this, const btVector3 *dimensions)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexShape *)(_this)).setImplicitShapeDimensions(
        ((dimensions ? void() : MRBINDC_THROW("Parameter `dimensions` can not be null.", void)), *(const btVector3 *)(dimensions))
    );
}

void btPolyhedralConvexShape_getAabb(const btPolyhedralConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getAabb(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btPolyhedralConvexShape_getAabbSlow(const btPolyhedralConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getAabbSlow(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btPolyhedralConvexShape_setLocalScaling(btPolyhedralConvexShape *_this, const btVector3 *scaling)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexShape *)(_this)).setLocalScaling(
        ((scaling ? void() : MRBINDC_THROW("Parameter `scaling` can not be null.", void)), *(const btVector3 *)(scaling))
    );
}

const btVector3 *btPolyhedralConvexShape_getLocalScaling(const btPolyhedralConvexShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getLocalScaling());
}

const btVector3 *btPolyhedralConvexShape_getLocalScalingNV(const btPolyhedralConvexShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getLocalScalingNV());
}

void btPolyhedralConvexShape_setMargin(btPolyhedralConvexShape *_this, double margin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexShape *)(_this)).setMargin(
        margin
    );
}

double btPolyhedralConvexShape_getMargin(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getMargin();
}

double btPolyhedralConvexShape_getMarginNV(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getMarginNV();
}

int btPolyhedralConvexShape_getNumPreferredPenetrationDirections(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getNumPreferredPenetrationDirections();
}

void btPolyhedralConvexShape_getPreferredPenetrationDirection(const btPolyhedralConvexShape *_this, int index, btVector3 *penetrationVector)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getPreferredPenetrationDirection(
        index,
        ((penetrationVector ? void() : MRBINDC_THROW("Parameter `penetrationVector` can not be null.", void)), *(btVector3 *)(penetrationVector))
    );
}

int btPolyhedralConvexShape_calculateSerializeBufferSize(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).calculateSerializeBufferSize();
}

btVector3 *btPolyhedralConvexShape_localGetSupportVertexWithoutMarginNonVirtual(const btPolyhedralConvexShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).localGetSupportVertexWithoutMarginNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btPolyhedralConvexShape_localGetSupportVertexNonVirtual(const btPolyhedralConvexShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).localGetSupportVertexNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

double btPolyhedralConvexShape_getMarginNonVirtual(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getMarginNonVirtual();
}

void btPolyhedralConvexShape_getAabbNonVirtual(const btPolyhedralConvexShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getAabbNonVirtual(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btPolyhedralConvexShape_project(const btPolyhedralConvexShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).project(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans)),
        ((dir ? void() : MRBINDC_THROW("Parameter `dir` can not be null.", void)), *(const btVector3 *)(dir)),
        ((minProj ? void() : MRBINDC_THROW("Parameter `minProj` can not be null.", void)), *minProj),
        ((maxProj ? void() : MRBINDC_THROW("Parameter `maxProj` can not be null.", void)), *maxProj),
        ((witnesPtMin ? void() : MRBINDC_THROW("Parameter `witnesPtMin` can not be null.", void)), *(btVector3 *)(witnesPtMin)),
        ((witnesPtMax ? void() : MRBINDC_THROW("Parameter `witnesPtMax` can not be null.", void)), *(btVector3 *)(witnesPtMax))
    );
}

void btPolyhedralConvexShape_getBoundingSphere(const btPolyhedralConvexShape *_this, btVector3 *center, double *radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getBoundingSphere(
        ((center ? void() : MRBINDC_THROW("Parameter `center` can not be null.", void)), *(btVector3 *)(center)),
        ((radius ? void() : MRBINDC_THROW("Parameter `radius` can not be null.", void)), *radius)
    );
}

double btPolyhedralConvexShape_getAngularMotionDisc(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getAngularMotionDisc();
}

double btPolyhedralConvexShape_getContactBreakingThreshold(const btPolyhedralConvexShape *_this, double defaultContactThresholdFactor)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getContactBreakingThreshold(
        defaultContactThresholdFactor
    );
}

void btPolyhedralConvexShape_calculateTemporalAabb(const btPolyhedralConvexShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).calculateTemporalAabb(
        ((curTrans ? void() : MRBINDC_THROW("Parameter `curTrans` can not be null.", void)), *(const btTransform *)(curTrans)),
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel)),
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel)),
        timeStep,
        ((temporalAabbMin ? void() : MRBINDC_THROW("Parameter `temporalAabbMin` can not be null.", void)), *(btVector3 *)(temporalAabbMin)),
        ((temporalAabbMax ? void() : MRBINDC_THROW("Parameter `temporalAabbMax` can not be null.", void)), *(btVector3 *)(temporalAabbMax))
    );
}

bool btPolyhedralConvexShape_isPolyhedral(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).isPolyhedral();
}

bool btPolyhedralConvexShape_isConvex2d(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).isConvex2d();
}

bool btPolyhedralConvexShape_isConvex(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).isConvex();
}

bool btPolyhedralConvexShape_isNonMoving(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).isNonMoving();
}

bool btPolyhedralConvexShape_isConcave(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).isConcave();
}

bool btPolyhedralConvexShape_isCompound(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).isCompound();
}

bool btPolyhedralConvexShape_isSoftBody(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).isSoftBody();
}

bool btPolyhedralConvexShape_isInfinite(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).isInfinite();
}

const char *btPolyhedralConvexShape_getName(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getName();
}

int btPolyhedralConvexShape_getShapeType(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getShapeType();
}

btVector3 *btPolyhedralConvexShape_getAnisotropicRollingFrictionDirection(const btPolyhedralConvexShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getAnisotropicRollingFrictionDirection());
}

void btPolyhedralConvexShape_setUserPointer(btPolyhedralConvexShape *_this, void *userPtr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexShape *)(_this)).setUserPointer(
        userPtr
    );
}

void *btPolyhedralConvexShape_getUserPointer(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getUserPointer();
}

void btPolyhedralConvexShape_setUserIndex(btPolyhedralConvexShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexShape *)(_this)).setUserIndex(
        index
    );
}

int btPolyhedralConvexShape_getUserIndex(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getUserIndex();
}

void btPolyhedralConvexShape_setUserIndex2(btPolyhedralConvexShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexShape *)(_this)).setUserIndex2(
        index
    );
}

int btPolyhedralConvexShape_getUserIndex2(const btPolyhedralConvexShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexShape *)(_this)).getUserIndex2();
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_OffsetPtr(const btPolyhedralConvexShape *ptr, ptrdiff_t i)
{
    return (const btPolyhedralConvexShape *)(((const btPolyhedralConvexShape *)ptr) + i);
}

btPolyhedralConvexShape *btPolyhedralConvexShape_OffsetMutablePtr(btPolyhedralConvexShape *ptr, ptrdiff_t i)
{
    return (btPolyhedralConvexShape *)(((btPolyhedralConvexShape *)ptr) + i);
}

const btCollisionShape *btPolyhedralConvexShape_UpcastTo_btCollisionShape(const btPolyhedralConvexShape *object)
{
    return (const btCollisionShape *)(static_cast<const btCollisionShape *>(
        ((const btPolyhedralConvexShape *)object)
    ));
}

btCollisionShape *btPolyhedralConvexShape_MutableUpcastTo_btCollisionShape(btPolyhedralConvexShape *object)
{
    return (btCollisionShape *)(static_cast<btCollisionShape *>(
        ((btPolyhedralConvexShape *)object)
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btPolyhedralConvexShape *)(static_cast<const btPolyhedralConvexShape *>(
        ((const btCollisionShape *)object)
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btPolyhedralConvexShape *)(static_cast<btPolyhedralConvexShape *>(
        ((btCollisionShape *)object)
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btPolyhedralConvexShape *)(dynamic_cast<const btPolyhedralConvexShape *>(
        ((const btCollisionShape *)object)
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btPolyhedralConvexShape *)(dynamic_cast<btPolyhedralConvexShape *>(
        ((btCollisionShape *)object)
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object)
{
    return (const btPolyhedralConvexShape *)std::addressof(dynamic_cast<const btPolyhedralConvexShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionShape *)(object))
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object)
{
    return (btPolyhedralConvexShape *)std::addressof(dynamic_cast<btPolyhedralConvexShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionShape *)(object))
    ));
}

const btConvexShape *btPolyhedralConvexShape_UpcastTo_btConvexShape(const btPolyhedralConvexShape *object)
{
    return (const btConvexShape *)(static_cast<const btConvexShape *>(
        ((const btPolyhedralConvexShape *)object)
    ));
}

btConvexShape *btPolyhedralConvexShape_MutableUpcastTo_btConvexShape(btPolyhedralConvexShape *object)
{
    return (btConvexShape *)(static_cast<btConvexShape *>(
        ((btPolyhedralConvexShape *)object)
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btPolyhedralConvexShape *)(static_cast<const btPolyhedralConvexShape *>(
        ((const btConvexShape *)object)
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btPolyhedralConvexShape *)(static_cast<btPolyhedralConvexShape *>(
        ((btConvexShape *)object)
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btPolyhedralConvexShape *)(dynamic_cast<const btPolyhedralConvexShape *>(
        ((const btConvexShape *)object)
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btPolyhedralConvexShape *)(dynamic_cast<btPolyhedralConvexShape *>(
        ((btConvexShape *)object)
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object)
{
    return (const btPolyhedralConvexShape *)std::addressof(dynamic_cast<const btPolyhedralConvexShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexShape *)(object))
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object)
{
    return (btPolyhedralConvexShape *)std::addressof(dynamic_cast<btPolyhedralConvexShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexShape *)(object))
    ));
}

const btConvexInternalShape *btPolyhedralConvexShape_UpcastTo_btConvexInternalShape(const btPolyhedralConvexShape *object)
{
    return (const btConvexInternalShape *)(static_cast<const btConvexInternalShape *>(
        ((const btPolyhedralConvexShape *)object)
    ));
}

btConvexInternalShape *btPolyhedralConvexShape_MutableUpcastTo_btConvexInternalShape(btPolyhedralConvexShape *object)
{
    return (btConvexInternalShape *)(static_cast<btConvexInternalShape *>(
        ((btPolyhedralConvexShape *)object)
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btPolyhedralConvexShape *)(static_cast<const btPolyhedralConvexShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btPolyhedralConvexShape *)(static_cast<btPolyhedralConvexShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btPolyhedralConvexShape *)(dynamic_cast<const btPolyhedralConvexShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btPolyhedralConvexShape *)(dynamic_cast<btPolyhedralConvexShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btPolyhedralConvexShape *)std::addressof(dynamic_cast<const btPolyhedralConvexShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexInternalShape *)(object))
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btPolyhedralConvexShape *)std::addressof(dynamic_cast<btPolyhedralConvexShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexInternalShape *)(object))
    ));
}

void btPolyhedralConvexAabbCachingShape_Destroy(const btPolyhedralConvexAabbCachingShape *_this)
{
    delete ((const btPolyhedralConvexAabbCachingShape *)_this);
}

void btPolyhedralConvexAabbCachingShape_DestroyArray(const btPolyhedralConvexAabbCachingShape *_this)
{
    delete[] ((const btPolyhedralConvexAabbCachingShape *)_this);
}

void btPolyhedralConvexAabbCachingShape_getNonvirtualAabb(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *trans, btVector3 *aabbMin, btVector3 *aabbMax, double margin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getNonvirtualAabb(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax)),
        margin
    );
}

void btPolyhedralConvexAabbCachingShape_setLocalScaling(btPolyhedralConvexAabbCachingShape *_this, const btVector3 *scaling)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexAabbCachingShape *)(_this)).setLocalScaling(
        ((scaling ? void() : MRBINDC_THROW("Parameter `scaling` can not be null.", void)), *(const btVector3 *)(scaling))
    );
}

void btPolyhedralConvexAabbCachingShape_getAabb(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getAabb(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btPolyhedralConvexAabbCachingShape_recalcLocalAabb(btPolyhedralConvexAabbCachingShape *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexAabbCachingShape *)(_this)).recalcLocalAabb();
}

bool btPolyhedralConvexAabbCachingShape_initializePolyhedralFeatures(btPolyhedralConvexAabbCachingShape *_this, const int *shiftVerticesByMargin)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexAabbCachingShape *)(_this)).initializePolyhedralFeatures(
        (shiftVerticesByMargin ? *shiftVerticesByMargin : static_cast<int>(0))
    );
}

btVector3 *btPolyhedralConvexAabbCachingShape_localGetSupportingVertexWithoutMargin(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).localGetSupportingVertexWithoutMargin(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

void btPolyhedralConvexAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).batchedUnitVectorGetSupportingVertexWithoutMargin(
        ((const btVector3 *)vectors),
        ((btVector3 *)supportVerticesOut),
        numVectors
    );
}

void btPolyhedralConvexAabbCachingShape_calculateLocalInertia(const btPolyhedralConvexAabbCachingShape *_this, double mass, btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).calculateLocalInertia(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(btVector3 *)(inertia))
    );
}

int btPolyhedralConvexAabbCachingShape_getNumVertices(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getNumVertices();
}

int btPolyhedralConvexAabbCachingShape_getNumEdges(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getNumEdges();
}

void btPolyhedralConvexAabbCachingShape_getEdge(const btPolyhedralConvexAabbCachingShape *_this, int i, btVector3 *pa, btVector3 *pb)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getEdge(
        i,
        ((pa ? void() : MRBINDC_THROW("Parameter `pa` can not be null.", void)), *(btVector3 *)(pa)),
        ((pb ? void() : MRBINDC_THROW("Parameter `pb` can not be null.", void)), *(btVector3 *)(pb))
    );
}

void btPolyhedralConvexAabbCachingShape_getVertex(const btPolyhedralConvexAabbCachingShape *_this, int i, btVector3 *vtx)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getVertex(
        i,
        ((vtx ? void() : MRBINDC_THROW("Parameter `vtx` can not be null.", void)), *(btVector3 *)(vtx))
    );
}

int btPolyhedralConvexAabbCachingShape_getNumPlanes(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getNumPlanes();
}

void btPolyhedralConvexAabbCachingShape_getPlane(const btPolyhedralConvexAabbCachingShape *_this, btVector3 *planeNormal, btVector3 *planeSupport, int i)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getPlane(
        ((planeNormal ? void() : MRBINDC_THROW("Parameter `planeNormal` can not be null.", void)), *(btVector3 *)(planeNormal)),
        ((planeSupport ? void() : MRBINDC_THROW("Parameter `planeSupport` can not be null.", void)), *(btVector3 *)(planeSupport)),
        i
    );
}

bool btPolyhedralConvexAabbCachingShape_isInside(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *pt, double tolerance)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).isInside(
        ((pt ? void() : MRBINDC_THROW("Parameter `pt` can not be null.", void)), *(const btVector3 *)(pt)),
        tolerance
    );
}

btVector3 *btPolyhedralConvexAabbCachingShape_localGetSupportingVertex(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).localGetSupportingVertex(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

const btVector3 *btPolyhedralConvexAabbCachingShape_getImplicitShapeDimensions(const btPolyhedralConvexAabbCachingShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getImplicitShapeDimensions());
}

void btPolyhedralConvexAabbCachingShape_setImplicitShapeDimensions(btPolyhedralConvexAabbCachingShape *_this, const btVector3 *dimensions)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexAabbCachingShape *)(_this)).setImplicitShapeDimensions(
        ((dimensions ? void() : MRBINDC_THROW("Parameter `dimensions` can not be null.", void)), *(const btVector3 *)(dimensions))
    );
}

void btPolyhedralConvexAabbCachingShape_getAabbSlow(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getAabbSlow(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

const btVector3 *btPolyhedralConvexAabbCachingShape_getLocalScaling(const btPolyhedralConvexAabbCachingShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getLocalScaling());
}

const btVector3 *btPolyhedralConvexAabbCachingShape_getLocalScalingNV(const btPolyhedralConvexAabbCachingShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getLocalScalingNV());
}

void btPolyhedralConvexAabbCachingShape_setMargin(btPolyhedralConvexAabbCachingShape *_this, double margin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexAabbCachingShape *)(_this)).setMargin(
        margin
    );
}

double btPolyhedralConvexAabbCachingShape_getMargin(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getMargin();
}

double btPolyhedralConvexAabbCachingShape_getMarginNV(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getMarginNV();
}

int btPolyhedralConvexAabbCachingShape_getNumPreferredPenetrationDirections(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getNumPreferredPenetrationDirections();
}

void btPolyhedralConvexAabbCachingShape_getPreferredPenetrationDirection(const btPolyhedralConvexAabbCachingShape *_this, int index, btVector3 *penetrationVector)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getPreferredPenetrationDirection(
        index,
        ((penetrationVector ? void() : MRBINDC_THROW("Parameter `penetrationVector` can not be null.", void)), *(btVector3 *)(penetrationVector))
    );
}

int btPolyhedralConvexAabbCachingShape_calculateSerializeBufferSize(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).calculateSerializeBufferSize();
}

btVector3 *btPolyhedralConvexAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).localGetSupportVertexWithoutMarginNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btPolyhedralConvexAabbCachingShape_localGetSupportVertexNonVirtual(const btPolyhedralConvexAabbCachingShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).localGetSupportVertexNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

double btPolyhedralConvexAabbCachingShape_getMarginNonVirtual(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getMarginNonVirtual();
}

void btPolyhedralConvexAabbCachingShape_getAabbNonVirtual(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getAabbNonVirtual(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btPolyhedralConvexAabbCachingShape_project(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).project(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans)),
        ((dir ? void() : MRBINDC_THROW("Parameter `dir` can not be null.", void)), *(const btVector3 *)(dir)),
        ((minProj ? void() : MRBINDC_THROW("Parameter `minProj` can not be null.", void)), *minProj),
        ((maxProj ? void() : MRBINDC_THROW("Parameter `maxProj` can not be null.", void)), *maxProj),
        ((witnesPtMin ? void() : MRBINDC_THROW("Parameter `witnesPtMin` can not be null.", void)), *(btVector3 *)(witnesPtMin)),
        ((witnesPtMax ? void() : MRBINDC_THROW("Parameter `witnesPtMax` can not be null.", void)), *(btVector3 *)(witnesPtMax))
    );
}

void btPolyhedralConvexAabbCachingShape_getBoundingSphere(const btPolyhedralConvexAabbCachingShape *_this, btVector3 *center, double *radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getBoundingSphere(
        ((center ? void() : MRBINDC_THROW("Parameter `center` can not be null.", void)), *(btVector3 *)(center)),
        ((radius ? void() : MRBINDC_THROW("Parameter `radius` can not be null.", void)), *radius)
    );
}

double btPolyhedralConvexAabbCachingShape_getAngularMotionDisc(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getAngularMotionDisc();
}

double btPolyhedralConvexAabbCachingShape_getContactBreakingThreshold(const btPolyhedralConvexAabbCachingShape *_this, double defaultContactThresholdFactor)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getContactBreakingThreshold(
        defaultContactThresholdFactor
    );
}

void btPolyhedralConvexAabbCachingShape_calculateTemporalAabb(const btPolyhedralConvexAabbCachingShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).calculateTemporalAabb(
        ((curTrans ? void() : MRBINDC_THROW("Parameter `curTrans` can not be null.", void)), *(const btTransform *)(curTrans)),
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel)),
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel)),
        timeStep,
        ((temporalAabbMin ? void() : MRBINDC_THROW("Parameter `temporalAabbMin` can not be null.", void)), *(btVector3 *)(temporalAabbMin)),
        ((temporalAabbMax ? void() : MRBINDC_THROW("Parameter `temporalAabbMax` can not be null.", void)), *(btVector3 *)(temporalAabbMax))
    );
}

bool btPolyhedralConvexAabbCachingShape_isPolyhedral(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).isPolyhedral();
}

bool btPolyhedralConvexAabbCachingShape_isConvex2d(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).isConvex2d();
}

bool btPolyhedralConvexAabbCachingShape_isConvex(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).isConvex();
}

bool btPolyhedralConvexAabbCachingShape_isNonMoving(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).isNonMoving();
}

bool btPolyhedralConvexAabbCachingShape_isConcave(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).isConcave();
}

bool btPolyhedralConvexAabbCachingShape_isCompound(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).isCompound();
}

bool btPolyhedralConvexAabbCachingShape_isSoftBody(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).isSoftBody();
}

bool btPolyhedralConvexAabbCachingShape_isInfinite(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).isInfinite();
}

const char *btPolyhedralConvexAabbCachingShape_getName(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getName();
}

int btPolyhedralConvexAabbCachingShape_getShapeType(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getShapeType();
}

btVector3 *btPolyhedralConvexAabbCachingShape_getAnisotropicRollingFrictionDirection(const btPolyhedralConvexAabbCachingShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getAnisotropicRollingFrictionDirection());
}

void btPolyhedralConvexAabbCachingShape_setUserPointer(btPolyhedralConvexAabbCachingShape *_this, void *userPtr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexAabbCachingShape *)(_this)).setUserPointer(
        userPtr
    );
}

void *btPolyhedralConvexAabbCachingShape_getUserPointer(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getUserPointer();
}

void btPolyhedralConvexAabbCachingShape_setUserIndex(btPolyhedralConvexAabbCachingShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexAabbCachingShape *)(_this)).setUserIndex(
        index
    );
}

int btPolyhedralConvexAabbCachingShape_getUserIndex(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getUserIndex();
}

void btPolyhedralConvexAabbCachingShape_setUserIndex2(btPolyhedralConvexAabbCachingShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btPolyhedralConvexAabbCachingShape *)(_this)).setUserIndex2(
        index
    );
}

int btPolyhedralConvexAabbCachingShape_getUserIndex2(const btPolyhedralConvexAabbCachingShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btPolyhedralConvexAabbCachingShape *)(_this)).getUserIndex2();
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_OffsetPtr(const btPolyhedralConvexAabbCachingShape *ptr, ptrdiff_t i)
{
    return (const btPolyhedralConvexAabbCachingShape *)(((const btPolyhedralConvexAabbCachingShape *)ptr) + i);
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_OffsetMutablePtr(btPolyhedralConvexAabbCachingShape *ptr, ptrdiff_t i)
{
    return (btPolyhedralConvexAabbCachingShape *)(((btPolyhedralConvexAabbCachingShape *)ptr) + i);
}

const btCollisionShape *btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape(const btPolyhedralConvexAabbCachingShape *object)
{
    return (const btCollisionShape *)(static_cast<const btCollisionShape *>(
        ((const btPolyhedralConvexAabbCachingShape *)object)
    ));
}

btCollisionShape *btPolyhedralConvexAabbCachingShape_MutableUpcastTo_btCollisionShape(btPolyhedralConvexAabbCachingShape *object)
{
    return (btCollisionShape *)(static_cast<btCollisionShape *>(
        ((btPolyhedralConvexAabbCachingShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)(static_cast<const btPolyhedralConvexAabbCachingShape *>(
        ((const btCollisionShape *)object)
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)(static_cast<btPolyhedralConvexAabbCachingShape *>(
        ((btCollisionShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)(dynamic_cast<const btPolyhedralConvexAabbCachingShape *>(
        ((const btCollisionShape *)object)
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)(dynamic_cast<btPolyhedralConvexAabbCachingShape *>(
        ((btCollisionShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)std::addressof(dynamic_cast<const btPolyhedralConvexAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionShape *)(object))
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)std::addressof(dynamic_cast<btPolyhedralConvexAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionShape *)(object))
    ));
}

const btConvexShape *btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape(const btPolyhedralConvexAabbCachingShape *object)
{
    return (const btConvexShape *)(static_cast<const btConvexShape *>(
        ((const btPolyhedralConvexAabbCachingShape *)object)
    ));
}

btConvexShape *btPolyhedralConvexAabbCachingShape_MutableUpcastTo_btConvexShape(btPolyhedralConvexAabbCachingShape *object)
{
    return (btConvexShape *)(static_cast<btConvexShape *>(
        ((btPolyhedralConvexAabbCachingShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)(static_cast<const btPolyhedralConvexAabbCachingShape *>(
        ((const btConvexShape *)object)
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)(static_cast<btPolyhedralConvexAabbCachingShape *>(
        ((btConvexShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)(dynamic_cast<const btPolyhedralConvexAabbCachingShape *>(
        ((const btConvexShape *)object)
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)(dynamic_cast<btPolyhedralConvexAabbCachingShape *>(
        ((btConvexShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)std::addressof(dynamic_cast<const btPolyhedralConvexAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexShape *)(object))
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)std::addressof(dynamic_cast<btPolyhedralConvexAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexShape *)(object))
    ));
}

const btConvexInternalShape *btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape(const btPolyhedralConvexAabbCachingShape *object)
{
    return (const btConvexInternalShape *)(static_cast<const btConvexInternalShape *>(
        ((const btPolyhedralConvexAabbCachingShape *)object)
    ));
}

btConvexInternalShape *btPolyhedralConvexAabbCachingShape_MutableUpcastTo_btConvexInternalShape(btPolyhedralConvexAabbCachingShape *object)
{
    return (btConvexInternalShape *)(static_cast<btConvexInternalShape *>(
        ((btPolyhedralConvexAabbCachingShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)(static_cast<const btPolyhedralConvexAabbCachingShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)(static_cast<btPolyhedralConvexAabbCachingShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)(dynamic_cast<const btPolyhedralConvexAabbCachingShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)(dynamic_cast<btPolyhedralConvexAabbCachingShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)std::addressof(dynamic_cast<const btPolyhedralConvexAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexInternalShape *)(object))
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)std::addressof(dynamic_cast<btPolyhedralConvexAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexInternalShape *)(object))
    ));
}

const btPolyhedralConvexShape *btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape(const btPolyhedralConvexAabbCachingShape *object)
{
    return (const btPolyhedralConvexShape *)(static_cast<const btPolyhedralConvexShape *>(
        ((const btPolyhedralConvexAabbCachingShape *)object)
    ));
}

btPolyhedralConvexShape *btPolyhedralConvexAabbCachingShape_MutableUpcastTo_btPolyhedralConvexShape(btPolyhedralConvexAabbCachingShape *object)
{
    return (btPolyhedralConvexShape *)(static_cast<btPolyhedralConvexShape *>(
        ((btPolyhedralConvexAabbCachingShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_StaticDowncastFrom_btPolyhedralConvexShape(const btPolyhedralConvexShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)(static_cast<const btPolyhedralConvexAabbCachingShape *>(
        ((const btPolyhedralConvexShape *)object)
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableStaticDowncastFrom_btPolyhedralConvexShape(btPolyhedralConvexShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)(static_cast<btPolyhedralConvexAabbCachingShape *>(
        ((btPolyhedralConvexShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape(const btPolyhedralConvexShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)(dynamic_cast<const btPolyhedralConvexAabbCachingShape *>(
        ((const btPolyhedralConvexShape *)object)
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFrom_btPolyhedralConvexShape(btPolyhedralConvexShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)(dynamic_cast<btPolyhedralConvexAabbCachingShape *>(
        ((btPolyhedralConvexShape *)object)
    ));
}

const btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_DynamicDowncastFromOrFail_btPolyhedralConvexShape(const btPolyhedralConvexShape *object)
{
    return (const btPolyhedralConvexAabbCachingShape *)std::addressof(dynamic_cast<const btPolyhedralConvexAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btPolyhedralConvexShape *)(object))
    ));
}

btPolyhedralConvexAabbCachingShape *btPolyhedralConvexAabbCachingShape_MutableDynamicDowncastFromOrFail_btPolyhedralConvexShape(btPolyhedralConvexShape *object)
{
    return (btPolyhedralConvexAabbCachingShape *)std::addressof(dynamic_cast<btPolyhedralConvexAabbCachingShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btPolyhedralConvexShape *)(object))
    ));
}

