// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/LinearMath/btTransform.h"

#include <LinearMath/btMatrix3x3.h>
#include <LinearMath/btQuaternion.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btTransform *btTransform_DefaultConstruct(void)
{
    return (btTransform *)new btTransform(btTransform());
}

btTransform *btTransform_DefaultConstructArray(size_t num_elems)
{
    return (btTransform *)(new btTransform[num_elems]{});
}

const btTransform *btTransform_OffsetPtr(const btTransform *ptr, ptrdiff_t i)
{
    return (const btTransform *)(((const btTransform *)ptr) + i);
}

btTransform *btTransform_OffsetMutablePtr(btTransform *ptr, ptrdiff_t i)
{
    return (btTransform *)(((btTransform *)ptr) + i);
}

btTransform *btTransform_ConstructFromAnother(Bullet_PassBy other_pass_by, btTransform *other)
{
    MRBINDC_CLASSARG_GUARD(other, btTransform);
    return (btTransform *)new btTransform(btTransform(
        (MRBINDC_CLASSARG_DEF_CTOR(other, btTransform) MRBINDC_CLASSARG_COPY(other, (btTransform), btTransform) MRBINDC_CLASSARG_NO_DEF_ARG(other, Bullet_PassBy_DefaultArgument, btTransform) MRBINDC_CLASSARG_NO_DEF_ARG(other, Bullet_PassBy_NoObject, btTransform) MRBINDC_CLASSARG_END(other, btTransform))
    ));
}

btTransform *btTransform_Construct_btQuaternion(const btQuaternion *q, const btVector3 *c)
{
    return (btTransform *)new btTransform(btTransform(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q)),
        (c ? *(const btVector3 *)(c) : static_cast<const btVector3 &>(btVector3(btScalar(0), btScalar(0), btScalar(0))))
    ));
}

btTransform *btTransform_Construct_btMatrix3x3(const btMatrix3x3 *b, const btVector3 *c)
{
    return (btTransform *)new btTransform(btTransform(
        ((b ? void() : MRBINDC_THROW("Parameter `b` can not be null.", void)), *(const btMatrix3x3 *)(b)),
        (c ? *(const btVector3 *)(c) : static_cast<const btVector3 &>(btVector3(btScalar(0), btScalar(0), btScalar(0))))
    ));
}

void btTransform_Destroy(const btTransform *_this)
{
    delete ((const btTransform *)_this);
}

void btTransform_DestroyArray(const btTransform *_this)
{
    delete[] ((const btTransform *)_this);
}

btTransform *btTransform_AssignFromAnother(btTransform *_this, Bullet_PassBy other_pass_by, btTransform *other)
{
    MRBINDC_CLASSARG_GUARD(other, btTransform);
    return (btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(other, btTransform) MRBINDC_CLASSARG_COPY(other, (btTransform), btTransform) MRBINDC_CLASSARG_NO_DEF_ARG(other, Bullet_PassBy_DefaultArgument, btTransform) MRBINDC_CLASSARG_NO_DEF_ARG(other, Bullet_PassBy_NoObject, btTransform) MRBINDC_CLASSARG_END(other, btTransform)))
    ));
}

void *Bullet_new_btTransform_unsigned_long(unsigned long sizeInBytes)
{
    return btTransform::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btTransform_void_ptr(void *ptr)
{
    btTransform::operator delete(
        ptr
    );
}

void *Bullet_new_btTransform_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btTransform::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btTransform_void_ptr_void_ptr(void *_1, void *_2)
{
    btTransform::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btTransform_unsigned_long(unsigned long sizeInBytes)
{
    return btTransform::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btTransform_void_ptr(void *ptr)
{
    btTransform::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btTransform_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btTransform::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btTransform_void_ptr_void_ptr(void *_1, void *_2)
{
    btTransform::operator delete[](
        _1,
        _2
    );
}

void btTransform_mult(btTransform *_this, const btTransform *t1, const btTransform *t2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).mult(
        ((t1 ? void() : MRBINDC_THROW("Parameter `t1` can not be null.", void)), *(const btTransform *)(t1)),
        ((t2 ? void() : MRBINDC_THROW("Parameter `t2` can not be null.", void)), *(const btTransform *)(t2))
    );
}

btVector3 *btTransform_call(const btTransform *_this, const btVector3 *x)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).operator()(
        ((x ? void() : MRBINDC_THROW("Parameter `x` can not be null.", void)), *(const btVector3 *)(x))
    ));
}

btVector3 *Bullet_mul_btTransform_btVector3(const btTransform *_this, const btVector3 *x)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).operator*(
        ((x ? void() : MRBINDC_THROW("Parameter `x` can not be null.", void)), *(const btVector3 *)(x))
    ));
}

btQuaternion *Bullet_mul_btTransform_btQuaternion(const btTransform *_this, const btQuaternion *q)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).operator*(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    ));
}

btMatrix3x3 *btTransform_getBasis_mut(btTransform *_this)
{
    return (btMatrix3x3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).getBasis());
}

const btMatrix3x3 *btTransform_getBasis(const btTransform *_this)
{
    return (const btMatrix3x3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).getBasis());
}

btVector3 *btTransform_getOrigin_mut(btTransform *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).getOrigin());
}

const btVector3 *btTransform_getOrigin(const btTransform *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).getOrigin());
}

btQuaternion *btTransform_getRotation(const btTransform *_this)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).getRotation());
}

void btTransform_setFromOpenGLMatrix(btTransform *_this, const double *m)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).setFromOpenGLMatrix(
        m
    );
}

void btTransform_getOpenGLMatrix(const btTransform *_this, double *m)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).getOpenGLMatrix(
        m
    );
}

void btTransform_setOrigin(btTransform *_this, const btVector3 *origin)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).setOrigin(
        ((origin ? void() : MRBINDC_THROW("Parameter `origin` can not be null.", void)), *(const btVector3 *)(origin))
    );
}

btVector3 *btTransform_invXform(const btTransform *_this, const btVector3 *inVec)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).invXform(
        ((inVec ? void() : MRBINDC_THROW("Parameter `inVec` can not be null.", void)), *(const btVector3 *)(inVec))
    ));
}

void btTransform_setBasis(btTransform *_this, const btMatrix3x3 *basis)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).setBasis(
        ((basis ? void() : MRBINDC_THROW("Parameter `basis` can not be null.", void)), *(const btMatrix3x3 *)(basis))
    );
}

void btTransform_setRotation(btTransform *_this, const btQuaternion *q)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).setRotation(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    );
}

void btTransform_setIdentity(btTransform *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).setIdentity();
}

btTransform *btTransform_mul_assign(btTransform *_this, const btTransform *t)
{
    return (btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btTransform *)(_this)).operator*=(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t))
    ));
}

btTransform *btTransform_inverse(const btTransform *_this)
{
    return (btTransform *)new btTransform(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).inverse());
}

btTransform *btTransform_inverseTimes(const btTransform *_this, const btTransform *t)
{
    return (btTransform *)new btTransform(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).inverseTimes(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t))
    ));
}

btTransform *Bullet_mul_btTransform(const btTransform *_this, const btTransform *t)
{
    return (btTransform *)new btTransform(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btTransform *)(_this)).operator*(
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *(const btTransform *)(t))
    ));
}

const btTransform *btTransform_getIdentity(void)
{
    return (const btTransform *)std::addressof(btTransform::getIdentity());
}

