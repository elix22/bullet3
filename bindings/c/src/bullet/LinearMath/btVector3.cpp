// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/LinearMath/btVector3.h"

#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>
#include <type_traits>


const double *btVector3_Get_m_floats(const btVector3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).m_floats[0]);
}

double *btVector3_GetMutable_m_floats(btVector3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).m_floats[0]);
}

size_t btVector3_GetSize_m_floats(void)
{
    return std::extent_v<decltype(btVector3::m_floats)>;
}

btVector3 *btVector3_DefaultConstruct(void)
{
    return (btVector3 *)new btVector3(btVector3());
}

btVector3 *btVector3_DefaultConstructArray(size_t num_elems)
{
    return (btVector3 *)(new btVector3[num_elems]{});
}

const btVector3 *btVector3_OffsetPtr(const btVector3 *ptr, ptrdiff_t i)
{
    return (const btVector3 *)(((const btVector3 *)ptr) + i);
}

btVector3 *btVector3_OffsetMutablePtr(btVector3 *ptr, ptrdiff_t i)
{
    return (btVector3 *)(((btVector3 *)ptr) + i);
}

btVector3 *btVector3_ConstructFromAnother(const btVector3 *_other)
{
    return (btVector3 *)new btVector3(btVector3(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btVector3(*(btVector3 *)_other))
    ));
}

btVector3 *btVector3_Construct(const double *_x, const double *_y, const double *_z)
{
    return (btVector3 *)new btVector3(btVector3(
        ((_x ? void() : MRBINDC_THROW("Parameter `_x` can not be null.", void)), *_x),
        ((_y ? void() : MRBINDC_THROW("Parameter `_y` can not be null.", void)), *_y),
        ((_z ? void() : MRBINDC_THROW("Parameter `_z` can not be null.", void)), *_z)
    ));
}

void btVector3_Destroy(const btVector3 *_this)
{
    delete ((const btVector3 *)_this);
}

void btVector3_DestroyArray(const btVector3 *_this)
{
    delete[] ((const btVector3 *)_this);
}

double *btVector3_ConvertTo_double_ptr(btVector3 *_this)
{
    return (double *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)));
}

const double *btVector3_ConvertTo_const_double_ptr(const btVector3 *_this)
{
    return (const double *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)));
}

btVector3 *btVector3_AssignFromAnother(btVector3 *_this, const btVector3 *_other)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btVector3(*(btVector3 *)_other))
    ));
}

void *Bullet_new_btVector3_unsigned_long(unsigned long sizeInBytes)
{
    return btVector3::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btVector3_void_ptr(void *ptr)
{
    btVector3::operator delete(
        ptr
    );
}

void *Bullet_new_btVector3_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btVector3::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btVector3_void_ptr_void_ptr(void *_1, void *_2)
{
    btVector3::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btVector3_unsigned_long(unsigned long sizeInBytes)
{
    return btVector3::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btVector3_void_ptr(void *ptr)
{
    btVector3::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btVector3_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btVector3::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btVector3_void_ptr_void_ptr(void *_1, void *_2)
{
    btVector3::operator delete[](
        _1,
        _2
    );
}

btVector3 *btVector3_add_assign(btVector3 *_this, const btVector3 *v)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).operator+=(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    ));
}

btVector3 *btVector3_sub_assign(btVector3 *_this, const btVector3 *v)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).operator-=(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    ));
}

btVector3 *btVector3_mul_assign_double(btVector3 *_this, const double *s)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).operator*=(
        ((s ? void() : MRBINDC_THROW("Parameter `s` can not be null.", void)), *s)
    ));
}

btVector3 *btVector3_div_assign(btVector3 *_this, const double *s)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).operator/=(
        ((s ? void() : MRBINDC_THROW("Parameter `s` can not be null.", void)), *s)
    ));
}

double btVector3_dot(const btVector3 *_this, const btVector3 *v)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).dot(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

double btVector3_length2(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).length2();
}

double btVector3_length(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).length();
}

double btVector3_norm(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).norm();
}

double btVector3_safeNorm(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).safeNorm();
}

double btVector3_distance2(const btVector3 *_this, const btVector3 *v)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).distance2(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

double btVector3_distance(const btVector3 *_this, const btVector3 *v)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).distance(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

btVector3 *btVector3_safeNormalize(btVector3 *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).safeNormalize());
}

btVector3 *btVector3_normalize(btVector3 *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).normalize());
}

btVector3 *btVector3_normalized(const btVector3 *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).normalized());
}

btVector3 *btVector3_rotate(const btVector3 *_this, const btVector3 *wAxis, double angle)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).rotate(
        ((wAxis ? void() : MRBINDC_THROW("Parameter `wAxis` can not be null.", void)), *(const btVector3 *)(wAxis)),
        angle
    ));
}

double btVector3_angle(const btVector3 *_this, const btVector3 *v)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).angle(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

btVector3 *btVector3_absolute(const btVector3 *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).absolute());
}

btVector3 *btVector3_cross(const btVector3 *_this, const btVector3 *v)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).cross(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    ));
}

double btVector3_triple(const btVector3 *_this, const btVector3 *v1, const btVector3 *v2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).triple(
        ((v1 ? void() : MRBINDC_THROW("Parameter `v1` can not be null.", void)), *(const btVector3 *)(v1)),
        ((v2 ? void() : MRBINDC_THROW("Parameter `v2` can not be null.", void)), *(const btVector3 *)(v2))
    );
}

int btVector3_minAxis(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).minAxis();
}

int btVector3_maxAxis(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).maxAxis();
}

int btVector3_furthestAxis(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).furthestAxis();
}

int btVector3_closestAxis(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).closestAxis();
}

void btVector3_setInterpolate3(btVector3 *_this, const btVector3 *v0, const btVector3 *v1, double rt)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).setInterpolate3(
        ((v0 ? void() : MRBINDC_THROW("Parameter `v0` can not be null.", void)), *(const btVector3 *)(v0)),
        ((v1 ? void() : MRBINDC_THROW("Parameter `v1` can not be null.", void)), *(const btVector3 *)(v1)),
        rt
    );
}

btVector3 *btVector3_lerp(const btVector3 *_this, const btVector3 *v, const double *t)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).lerp(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v)),
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *t)
    ));
}

btVector3 *btVector3_mul_assign_btVector3(btVector3 *_this, const btVector3 *v)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).operator*=(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    ));
}

const double *btVector3_getX(const btVector3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).getX());
}

const double *btVector3_getY(const btVector3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).getY());
}

const double *btVector3_getZ(const btVector3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).getZ());
}

void btVector3_setX(btVector3 *_this, double _x)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).setX(
        _x
    );
}

void btVector3_setY(btVector3 *_this, double _y)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).setY(
        _y
    );
}

void btVector3_setZ(btVector3 *_this, double _z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).setZ(
        _z
    );
}

void btVector3_setW(btVector3 *_this, double _w)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).setW(
        _w
    );
}

const double *btVector3_x(const btVector3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).x());
}

const double *btVector3_y(const btVector3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).y());
}

const double *btVector3_z(const btVector3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).z());
}

const double *btVector3_w(const btVector3 *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).w());
}

bool Bullet_equal_btVector3(const btVector3 *_this, const btVector3 *other)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).operator==(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btVector3 *)(other))
    );
}

bool Bullet_not_equal_btVector3(const btVector3 *_this, const btVector3 *other)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).operator!=(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btVector3 *)(other))
    );
}

void btVector3_setMax(btVector3 *_this, const btVector3 *other)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).setMax(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btVector3 *)(other))
    );
}

void btVector3_setMin(btVector3 *_this, const btVector3 *other)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).setMin(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btVector3 *)(other))
    );
}

void btVector3_setValue(btVector3 *_this, const double *_x, const double *_y, const double *_z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).setValue(
        ((_x ? void() : MRBINDC_THROW("Parameter `_x` can not be null.", void)), *_x),
        ((_y ? void() : MRBINDC_THROW("Parameter `_y` can not be null.", void)), *_y),
        ((_z ? void() : MRBINDC_THROW("Parameter `_z` can not be null.", void)), *_z)
    );
}

void btVector3_getSkewSymmetricMatrix(const btVector3 *_this, btVector3 *v0, btVector3 *v1, btVector3 *v2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).getSkewSymmetricMatrix(
        ((btVector3 *)v0),
        ((btVector3 *)v1),
        ((btVector3 *)v2)
    );
}

void btVector3_setZero(btVector3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btVector3 *)(_this)).setZero();
}

bool btVector3_isZero(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).isZero();
}

bool btVector3_fuzzyZero(const btVector3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).fuzzyZero();
}

long btVector3_maxDot(const btVector3 *_this, const btVector3 *array, long array_count, double *dotOut)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).maxDot(
        ((const btVector3 *)array),
        array_count,
        ((dotOut ? void() : MRBINDC_THROW("Parameter `dotOut` can not be null.", void)), *dotOut)
    );
}

long btVector3_minDot(const btVector3 *_this, const btVector3 *array, long array_count, double *dotOut)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).minDot(
        ((const btVector3 *)array),
        array_count,
        ((dotOut ? void() : MRBINDC_THROW("Parameter `dotOut` can not be null.", void)), *dotOut)
    );
}

btVector3 *btVector3_dot3(const btVector3 *_this, const btVector3 *v0, const btVector3 *v1, const btVector3 *v2)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btVector3 *)(_this)).dot3(
        ((v0 ? void() : MRBINDC_THROW("Parameter `v0` can not be null.", void)), *(const btVector3 *)(v0)),
        ((v1 ? void() : MRBINDC_THROW("Parameter `v1` can not be null.", void)), *(const btVector3 *)(v1)),
        ((v2 ? void() : MRBINDC_THROW("Parameter `v2` can not be null.", void)), *(const btVector3 *)(v2))
    ));
}

