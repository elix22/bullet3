// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionShapes/btBoxShape.h"

#include <BulletCollision/CollisionShapes/btBoxShape.h>
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


btBoxShape *btBoxShape_ConstructFromAnother(Bullet_PassBy _other_pass_by, btBoxShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btBoxShape);
    return (btBoxShape *)new btBoxShape(btBoxShape(
        (MRBINDC_CLASSARG_COPY(_other, (btBoxShape), btBoxShape) MRBINDC_CLASSARG_MOVE(_other, (btBoxShape), btBoxShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btBoxShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btBoxShape) MRBINDC_CLASSARG_END(_other, btBoxShape))
    ));
}

const btBoxShape *btBoxShape_OffsetPtr(const btBoxShape *ptr, ptrdiff_t i)
{
    return (const btBoxShape *)(((const btBoxShape *)ptr) + i);
}

btBoxShape *btBoxShape_OffsetMutablePtr(btBoxShape *ptr, ptrdiff_t i)
{
    return (btBoxShape *)(((btBoxShape *)ptr) + i);
}

const btCollisionShape *btBoxShape_UpcastTo_btCollisionShape(const btBoxShape *object)
{
    return (const btCollisionShape *)(static_cast<const btCollisionShape *>(
        ((const btBoxShape *)object)
    ));
}

btCollisionShape *btBoxShape_MutableUpcastTo_btCollisionShape(btBoxShape *object)
{
    return (btCollisionShape *)(static_cast<btCollisionShape *>(
        ((btBoxShape *)object)
    ));
}

const btBoxShape *btBoxShape_StaticDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btBoxShape *)(static_cast<const btBoxShape *>(
        ((const btCollisionShape *)object)
    ));
}

btBoxShape *btBoxShape_MutableStaticDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btBoxShape *)(static_cast<btBoxShape *>(
        ((btCollisionShape *)object)
    ));
}

const btBoxShape *btBoxShape_DynamicDowncastFrom_btCollisionShape(const btCollisionShape *object)
{
    return (const btBoxShape *)(dynamic_cast<const btBoxShape *>(
        ((const btCollisionShape *)object)
    ));
}

btBoxShape *btBoxShape_MutableDynamicDowncastFrom_btCollisionShape(btCollisionShape *object)
{
    return (btBoxShape *)(dynamic_cast<btBoxShape *>(
        ((btCollisionShape *)object)
    ));
}

const btBoxShape *btBoxShape_DynamicDowncastFromOrFail_btCollisionShape(const btCollisionShape *object)
{
    return (const btBoxShape *)std::addressof(dynamic_cast<const btBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionShape *)(object))
    ));
}

btBoxShape *btBoxShape_MutableDynamicDowncastFromOrFail_btCollisionShape(btCollisionShape *object)
{
    return (btBoxShape *)std::addressof(dynamic_cast<btBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionShape *)(object))
    ));
}

const btConvexShape *btBoxShape_UpcastTo_btConvexShape(const btBoxShape *object)
{
    return (const btConvexShape *)(static_cast<const btConvexShape *>(
        ((const btBoxShape *)object)
    ));
}

btConvexShape *btBoxShape_MutableUpcastTo_btConvexShape(btBoxShape *object)
{
    return (btConvexShape *)(static_cast<btConvexShape *>(
        ((btBoxShape *)object)
    ));
}

const btBoxShape *btBoxShape_StaticDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btBoxShape *)(static_cast<const btBoxShape *>(
        ((const btConvexShape *)object)
    ));
}

btBoxShape *btBoxShape_MutableStaticDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btBoxShape *)(static_cast<btBoxShape *>(
        ((btConvexShape *)object)
    ));
}

const btBoxShape *btBoxShape_DynamicDowncastFrom_btConvexShape(const btConvexShape *object)
{
    return (const btBoxShape *)(dynamic_cast<const btBoxShape *>(
        ((const btConvexShape *)object)
    ));
}

btBoxShape *btBoxShape_MutableDynamicDowncastFrom_btConvexShape(btConvexShape *object)
{
    return (btBoxShape *)(dynamic_cast<btBoxShape *>(
        ((btConvexShape *)object)
    ));
}

const btBoxShape *btBoxShape_DynamicDowncastFromOrFail_btConvexShape(const btConvexShape *object)
{
    return (const btBoxShape *)std::addressof(dynamic_cast<const btBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexShape *)(object))
    ));
}

btBoxShape *btBoxShape_MutableDynamicDowncastFromOrFail_btConvexShape(btConvexShape *object)
{
    return (btBoxShape *)std::addressof(dynamic_cast<btBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexShape *)(object))
    ));
}

const btConvexInternalShape *btBoxShape_UpcastTo_btConvexInternalShape(const btBoxShape *object)
{
    return (const btConvexInternalShape *)(static_cast<const btConvexInternalShape *>(
        ((const btBoxShape *)object)
    ));
}

btConvexInternalShape *btBoxShape_MutableUpcastTo_btConvexInternalShape(btBoxShape *object)
{
    return (btConvexInternalShape *)(static_cast<btConvexInternalShape *>(
        ((btBoxShape *)object)
    ));
}

const btBoxShape *btBoxShape_StaticDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btBoxShape *)(static_cast<const btBoxShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btBoxShape *btBoxShape_MutableStaticDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btBoxShape *)(static_cast<btBoxShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btBoxShape *btBoxShape_DynamicDowncastFrom_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btBoxShape *)(dynamic_cast<const btBoxShape *>(
        ((const btConvexInternalShape *)object)
    ));
}

btBoxShape *btBoxShape_MutableDynamicDowncastFrom_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btBoxShape *)(dynamic_cast<btBoxShape *>(
        ((btConvexInternalShape *)object)
    ));
}

const btBoxShape *btBoxShape_DynamicDowncastFromOrFail_btConvexInternalShape(const btConvexInternalShape *object)
{
    return (const btBoxShape *)std::addressof(dynamic_cast<const btBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConvexInternalShape *)(object))
    ));
}

btBoxShape *btBoxShape_MutableDynamicDowncastFromOrFail_btConvexInternalShape(btConvexInternalShape *object)
{
    return (btBoxShape *)std::addressof(dynamic_cast<btBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConvexInternalShape *)(object))
    ));
}

const btPolyhedralConvexShape *btBoxShape_UpcastTo_btPolyhedralConvexShape(const btBoxShape *object)
{
    return (const btPolyhedralConvexShape *)(static_cast<const btPolyhedralConvexShape *>(
        ((const btBoxShape *)object)
    ));
}

btPolyhedralConvexShape *btBoxShape_MutableUpcastTo_btPolyhedralConvexShape(btBoxShape *object)
{
    return (btPolyhedralConvexShape *)(static_cast<btPolyhedralConvexShape *>(
        ((btBoxShape *)object)
    ));
}

const btBoxShape *btBoxShape_StaticDowncastFrom_btPolyhedralConvexShape(const btPolyhedralConvexShape *object)
{
    return (const btBoxShape *)(static_cast<const btBoxShape *>(
        ((const btPolyhedralConvexShape *)object)
    ));
}

btBoxShape *btBoxShape_MutableStaticDowncastFrom_btPolyhedralConvexShape(btPolyhedralConvexShape *object)
{
    return (btBoxShape *)(static_cast<btBoxShape *>(
        ((btPolyhedralConvexShape *)object)
    ));
}

const btBoxShape *btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape(const btPolyhedralConvexShape *object)
{
    return (const btBoxShape *)(dynamic_cast<const btBoxShape *>(
        ((const btPolyhedralConvexShape *)object)
    ));
}

btBoxShape *btBoxShape_MutableDynamicDowncastFrom_btPolyhedralConvexShape(btPolyhedralConvexShape *object)
{
    return (btBoxShape *)(dynamic_cast<btBoxShape *>(
        ((btPolyhedralConvexShape *)object)
    ));
}

const btBoxShape *btBoxShape_DynamicDowncastFromOrFail_btPolyhedralConvexShape(const btPolyhedralConvexShape *object)
{
    return (const btBoxShape *)std::addressof(dynamic_cast<const btBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btPolyhedralConvexShape *)(object))
    ));
}

btBoxShape *btBoxShape_MutableDynamicDowncastFromOrFail_btPolyhedralConvexShape(btPolyhedralConvexShape *object)
{
    return (btBoxShape *)std::addressof(dynamic_cast<btBoxShape &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btPolyhedralConvexShape *)(object))
    ));
}

btBoxShape *btBoxShape_Construct(const btVector3 *boxHalfExtents)
{
    return (btBoxShape *)new btBoxShape(btBoxShape(
        ((boxHalfExtents ? void() : MRBINDC_THROW("Parameter `boxHalfExtents` can not be null.", void)), *(const btVector3 *)(boxHalfExtents))
    ));
}

void btBoxShape_Destroy(const btBoxShape *_this)
{
    delete ((const btBoxShape *)_this);
}

void btBoxShape_DestroyArray(const btBoxShape *_this)
{
    delete[] ((const btBoxShape *)_this);
}

btBoxShape *btBoxShape_AssignFromAnother(btBoxShape *_this, Bullet_PassBy _other_pass_by, btBoxShape *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btBoxShape);
    return (btBoxShape *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBoxShape *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (btBoxShape), btBoxShape) MRBINDC_CLASSARG_MOVE(_other, (btBoxShape), btBoxShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btBoxShape) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btBoxShape) MRBINDC_CLASSARG_END(_other, btBoxShape))
    ));
}

void *Bullet_new_btBoxShape_unsigned_long(unsigned long sizeInBytes)
{
    return btBoxShape::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btBoxShape_void_ptr(void *ptr)
{
    btBoxShape::operator delete(
        ptr
    );
}

void *Bullet_new_btBoxShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btBoxShape::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btBoxShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btBoxShape::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btBoxShape_unsigned_long(unsigned long sizeInBytes)
{
    return btBoxShape::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btBoxShape_void_ptr(void *ptr)
{
    btBoxShape::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btBoxShape_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btBoxShape::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btBoxShape_void_ptr_void_ptr(void *_1, void *_2)
{
    btBoxShape::operator delete[](
        _1,
        _2
    );
}

btVector3 *btBoxShape_getHalfExtentsWithMargin(const btBoxShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getHalfExtentsWithMargin());
}

const btVector3 *btBoxShape_getHalfExtentsWithoutMargin(const btBoxShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getHalfExtentsWithoutMargin());
}

btVector3 *btBoxShape_localGetSupportingVertex(const btBoxShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).localGetSupportingVertex(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btBoxShape_localGetSupportingVertexWithoutMargin(const btBoxShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).localGetSupportingVertexWithoutMargin(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

void btBoxShape_batchedUnitVectorGetSupportingVertexWithoutMargin(const btBoxShape *_this, const btVector3 *vectors, btVector3 *supportVerticesOut, int numVectors)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).batchedUnitVectorGetSupportingVertexWithoutMargin(
        ((const btVector3 *)vectors),
        ((btVector3 *)supportVerticesOut),
        numVectors
    );
}

void btBoxShape_setMargin(btBoxShape *_this, double collisionMargin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBoxShape *)(_this)).setMargin(
        collisionMargin
    );
}

void btBoxShape_setLocalScaling(btBoxShape *_this, const btVector3 *scaling)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBoxShape *)(_this)).setLocalScaling(
        ((scaling ? void() : MRBINDC_THROW("Parameter `scaling` can not be null.", void)), *(const btVector3 *)(scaling))
    );
}

void btBoxShape_getAabb(const btBoxShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getAabb(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btBoxShape_calculateLocalInertia(const btBoxShape *_this, double mass, btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).calculateLocalInertia(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(btVector3 *)(inertia))
    );
}

void btBoxShape_getPlane(const btBoxShape *_this, btVector3 *planeNormal, btVector3 *planeSupport, int i)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getPlane(
        ((planeNormal ? void() : MRBINDC_THROW("Parameter `planeNormal` can not be null.", void)), *(btVector3 *)(planeNormal)),
        ((planeSupport ? void() : MRBINDC_THROW("Parameter `planeSupport` can not be null.", void)), *(btVector3 *)(planeSupport)),
        i
    );
}

int btBoxShape_getNumPlanes(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getNumPlanes();
}

int btBoxShape_getNumVertices(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getNumVertices();
}

int btBoxShape_getNumEdges(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getNumEdges();
}

void btBoxShape_getVertex(const btBoxShape *_this, int i, btVector3 *vtx)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getVertex(
        i,
        ((vtx ? void() : MRBINDC_THROW("Parameter `vtx` can not be null.", void)), *(btVector3 *)(vtx))
    );
}

void btBoxShape_getEdge(const btBoxShape *_this, int i, btVector3 *pa, btVector3 *pb)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getEdge(
        i,
        ((pa ? void() : MRBINDC_THROW("Parameter `pa` can not be null.", void)), *(btVector3 *)(pa)),
        ((pb ? void() : MRBINDC_THROW("Parameter `pb` can not be null.", void)), *(btVector3 *)(pb))
    );
}

bool btBoxShape_isInside(const btBoxShape *_this, const btVector3 *pt, double tolerance)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).isInside(
        ((pt ? void() : MRBINDC_THROW("Parameter `pt` can not be null.", void)), *(const btVector3 *)(pt)),
        tolerance
    );
}

const char *btBoxShape_getName(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getName();
}

int btBoxShape_getNumPreferredPenetrationDirections(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getNumPreferredPenetrationDirections();
}

void btBoxShape_getPreferredPenetrationDirection(const btBoxShape *_this, int index, btVector3 *penetrationVector)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getPreferredPenetrationDirection(
        index,
        ((penetrationVector ? void() : MRBINDC_THROW("Parameter `penetrationVector` can not be null.", void)), *(btVector3 *)(penetrationVector))
    );
}

bool btBoxShape_initializePolyhedralFeatures(btBoxShape *_this, const int *shiftVerticesByMargin)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBoxShape *)(_this)).initializePolyhedralFeatures(
        (shiftVerticesByMargin ? *shiftVerticesByMargin : static_cast<int>(0))
    );
}

const btVector3 *btBoxShape_getImplicitShapeDimensions(const btBoxShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getImplicitShapeDimensions());
}

void btBoxShape_setImplicitShapeDimensions(btBoxShape *_this, const btVector3 *dimensions)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBoxShape *)(_this)).setImplicitShapeDimensions(
        ((dimensions ? void() : MRBINDC_THROW("Parameter `dimensions` can not be null.", void)), *(const btVector3 *)(dimensions))
    );
}

void btBoxShape_getAabbSlow(const btBoxShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getAabbSlow(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

const btVector3 *btBoxShape_getLocalScaling(const btBoxShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getLocalScaling());
}

const btVector3 *btBoxShape_getLocalScalingNV(const btBoxShape *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getLocalScalingNV());
}

double btBoxShape_getMargin(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getMargin();
}

double btBoxShape_getMarginNV(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getMarginNV();
}

int btBoxShape_calculateSerializeBufferSize(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).calculateSerializeBufferSize();
}

btVector3 *btBoxShape_localGetSupportVertexWithoutMarginNonVirtual(const btBoxShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).localGetSupportVertexWithoutMarginNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

btVector3 *btBoxShape_localGetSupportVertexNonVirtual(const btBoxShape *_this, const btVector3 *vec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).localGetSupportVertexNonVirtual(
        ((vec ? void() : MRBINDC_THROW("Parameter `vec` can not be null.", void)), *(const btVector3 *)(vec))
    ));
}

double btBoxShape_getMarginNonVirtual(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getMarginNonVirtual();
}

void btBoxShape_getAabbNonVirtual(const btBoxShape *_this, const btTransform *t, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getAabbNonVirtual(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t)),
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

void btBoxShape_project(const btBoxShape *_this, const btTransform *trans, const btVector3 *dir, double *minProj, double *maxProj, btVector3 *witnesPtMin, btVector3 *witnesPtMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).project(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans)),
        ((dir ? void() : MRBINDC_THROW("Parameter `dir` can not be null.", void)), *(const btVector3 *)(dir)),
        ((minProj ? void() : MRBINDC_THROW("Parameter `minProj` can not be null.", void)), *minProj),
        ((maxProj ? void() : MRBINDC_THROW("Parameter `maxProj` can not be null.", void)), *maxProj),
        ((witnesPtMin ? void() : MRBINDC_THROW("Parameter `witnesPtMin` can not be null.", void)), *(btVector3 *)(witnesPtMin)),
        ((witnesPtMax ? void() : MRBINDC_THROW("Parameter `witnesPtMax` can not be null.", void)), *(btVector3 *)(witnesPtMax))
    );
}

void btBoxShape_getBoundingSphere(const btBoxShape *_this, btVector3 *center, double *radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getBoundingSphere(
        ((center ? void() : MRBINDC_THROW("Parameter `center` can not be null.", void)), *(btVector3 *)(center)),
        ((radius ? void() : MRBINDC_THROW("Parameter `radius` can not be null.", void)), *radius)
    );
}

double btBoxShape_getAngularMotionDisc(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getAngularMotionDisc();
}

double btBoxShape_getContactBreakingThreshold(const btBoxShape *_this, double defaultContactThresholdFactor)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getContactBreakingThreshold(
        defaultContactThresholdFactor
    );
}

void btBoxShape_calculateTemporalAabb(const btBoxShape *_this, const btTransform *curTrans, const btVector3 *linvel, const btVector3 *angvel, double timeStep, btVector3 *temporalAabbMin, btVector3 *temporalAabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).calculateTemporalAabb(
        ((curTrans ? void() : MRBINDC_THROW("Parameter `curTrans` can not be null.", void)), *(const btTransform *)(curTrans)),
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel)),
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel)),
        timeStep,
        ((temporalAabbMin ? void() : MRBINDC_THROW("Parameter `temporalAabbMin` can not be null.", void)), *(btVector3 *)(temporalAabbMin)),
        ((temporalAabbMax ? void() : MRBINDC_THROW("Parameter `temporalAabbMax` can not be null.", void)), *(btVector3 *)(temporalAabbMax))
    );
}

bool btBoxShape_isPolyhedral(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).isPolyhedral();
}

bool btBoxShape_isConvex2d(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).isConvex2d();
}

bool btBoxShape_isConvex(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).isConvex();
}

bool btBoxShape_isNonMoving(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).isNonMoving();
}

bool btBoxShape_isConcave(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).isConcave();
}

bool btBoxShape_isCompound(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).isCompound();
}

bool btBoxShape_isSoftBody(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).isSoftBody();
}

bool btBoxShape_isInfinite(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).isInfinite();
}

int btBoxShape_getShapeType(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getShapeType();
}

btVector3 *btBoxShape_getAnisotropicRollingFrictionDirection(const btBoxShape *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getAnisotropicRollingFrictionDirection());
}

void btBoxShape_setUserPointer(btBoxShape *_this, void *userPtr)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBoxShape *)(_this)).setUserPointer(
        userPtr
    );
}

void *btBoxShape_getUserPointer(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getUserPointer();
}

void btBoxShape_setUserIndex(btBoxShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBoxShape *)(_this)).setUserIndex(
        index
    );
}

int btBoxShape_getUserIndex(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getUserIndex();
}

void btBoxShape_setUserIndex2(btBoxShape *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btBoxShape *)(_this)).setUserIndex2(
        index
    );
}

int btBoxShape_getUserIndex2(const btBoxShape *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btBoxShape *)(_this)).getUserIndex2();
}

