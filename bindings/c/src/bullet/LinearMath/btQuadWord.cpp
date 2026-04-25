// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/LinearMath/btQuadWord.h"

#include <LinearMath/btQuadWord.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btQuadWord *btQuadWord_DefaultConstruct(void)
{
    return (btQuadWord *)new btQuadWord(btQuadWord());
}

btQuadWord *btQuadWord_DefaultConstructArray(size_t num_elems)
{
    return (btQuadWord *)(new btQuadWord[num_elems]{});
}

const btQuadWord *btQuadWord_OffsetPtr(const btQuadWord *ptr, ptrdiff_t i)
{
    return (const btQuadWord *)(((const btQuadWord *)ptr) + i);
}

btQuadWord *btQuadWord_OffsetMutablePtr(btQuadWord *ptr, ptrdiff_t i)
{
    return (btQuadWord *)(((btQuadWord *)ptr) + i);
}

btQuadWord *btQuadWord_ConstructFromAnother(const btQuadWord *_other)
{
    return (btQuadWord *)new btQuadWord(btQuadWord(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btQuadWord(*(btQuadWord *)_other))
    ));
}

btQuadWord *btQuadWord_Construct_3(const double *_x, const double *_y, const double *_z)
{
    return (btQuadWord *)new btQuadWord(btQuadWord(
        ((_x ? void() : MRBINDC_THROW("Parameter `_x` can not be null.", void)), *_x),
        ((_y ? void() : MRBINDC_THROW("Parameter `_y` can not be null.", void)), *_y),
        ((_z ? void() : MRBINDC_THROW("Parameter `_z` can not be null.", void)), *_z)
    ));
}

btQuadWord *btQuadWord_Construct_4(const double *_x, const double *_y, const double *_z, const double *_w)
{
    return (btQuadWord *)new btQuadWord(btQuadWord(
        ((_x ? void() : MRBINDC_THROW("Parameter `_x` can not be null.", void)), *_x),
        ((_y ? void() : MRBINDC_THROW("Parameter `_y` can not be null.", void)), *_y),
        ((_z ? void() : MRBINDC_THROW("Parameter `_z` can not be null.", void)), *_z),
        ((_w ? void() : MRBINDC_THROW("Parameter `_w` can not be null.", void)), *_w)
    ));
}

void btQuadWord_Destroy(const btQuadWord *_this)
{
    delete ((const btQuadWord *)_this);
}

void btQuadWord_DestroyArray(const btQuadWord *_this)
{
    delete[] ((const btQuadWord *)_this);
}

double *btQuadWord_ConvertTo_double_ptr(btQuadWord *_this)
{
    return (double *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)));
}

const double *btQuadWord_ConvertTo_const_double_ptr(const btQuadWord *_this)
{
    return (const double *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)));
}

btQuadWord *btQuadWord_AssignFromAnother(btQuadWord *_this, const btQuadWord *_other)
{
    return (btQuadWord *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btQuadWord(*(btQuadWord *)_other))
    ));
}

const double *btQuadWord_getX(const btQuadWord *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)).getX());
}

const double *btQuadWord_getY(const btQuadWord *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)).getY());
}

const double *btQuadWord_getZ(const btQuadWord *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)).getZ());
}

void btQuadWord_setX(btQuadWord *_this, double _x)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)).setX(
        _x
    );
}

void btQuadWord_setY(btQuadWord *_this, double _y)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)).setY(
        _y
    );
}

void btQuadWord_setZ(btQuadWord *_this, double _z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)).setZ(
        _z
    );
}

void btQuadWord_setW(btQuadWord *_this, double _w)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)).setW(
        _w
    );
}

const double *btQuadWord_x(const btQuadWord *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)).x());
}

const double *btQuadWord_y(const btQuadWord *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)).y());
}

const double *btQuadWord_z(const btQuadWord *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)).z());
}

const double *btQuadWord_w(const btQuadWord *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)).w());
}

bool Bullet_equal_btQuadWord(const btQuadWord *_this, const btQuadWord *other)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)).operator==(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btQuadWord *)(other))
    );
}

bool Bullet_not_equal_btQuadWord(const btQuadWord *_this, const btQuadWord *other)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuadWord *)(_this)).operator!=(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btQuadWord *)(other))
    );
}

void btQuadWord_setValue_3(btQuadWord *_this, const double *_x, const double *_y, const double *_z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)).setValue(
        ((_x ? void() : MRBINDC_THROW("Parameter `_x` can not be null.", void)), *_x),
        ((_y ? void() : MRBINDC_THROW("Parameter `_y` can not be null.", void)), *_y),
        ((_z ? void() : MRBINDC_THROW("Parameter `_z` can not be null.", void)), *_z)
    );
}

void btQuadWord_setValue_4(btQuadWord *_this, const double *_x, const double *_y, const double *_z, const double *_w)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)).setValue(
        ((_x ? void() : MRBINDC_THROW("Parameter `_x` can not be null.", void)), *_x),
        ((_y ? void() : MRBINDC_THROW("Parameter `_y` can not be null.", void)), *_y),
        ((_z ? void() : MRBINDC_THROW("Parameter `_z` can not be null.", void)), *_z),
        ((_w ? void() : MRBINDC_THROW("Parameter `_w` can not be null.", void)), *_w)
    );
}

void btQuadWord_setMax(btQuadWord *_this, const btQuadWord *other)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)).setMax(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btQuadWord *)(other))
    );
}

void btQuadWord_setMin(btQuadWord *_this, const btQuadWord *other)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuadWord *)(_this)).setMin(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btQuadWord *)(other))
    );
}

