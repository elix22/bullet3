// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/LinearMath/btQuaternion.h"

#include <LinearMath/btQuadWord.h>
#include <LinearMath/btQuaternion.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btQuaternion *btQuaternion_DefaultConstruct(void)
{
    return (btQuaternion *)new btQuaternion(btQuaternion());
}

btQuaternion *btQuaternion_DefaultConstructArray(size_t num_elems)
{
    return (btQuaternion *)(new btQuaternion[num_elems]{});
}

const btQuaternion *btQuaternion_OffsetPtr(const btQuaternion *ptr, ptrdiff_t i)
{
    return (const btQuaternion *)(((const btQuaternion *)ptr) + i);
}

btQuaternion *btQuaternion_OffsetMutablePtr(btQuaternion *ptr, ptrdiff_t i)
{
    return (btQuaternion *)(((btQuaternion *)ptr) + i);
}

const btQuadWord *btQuaternion_UpcastTo_btQuadWord(const btQuaternion *object)
{
    return (const btQuadWord *)(static_cast<const btQuadWord *>(
        ((const btQuaternion *)object)
    ));
}

btQuadWord *btQuaternion_MutableUpcastTo_btQuadWord(btQuaternion *object)
{
    return (btQuadWord *)(static_cast<btQuadWord *>(
        ((btQuaternion *)object)
    ));
}

const btQuaternion *btQuaternion_StaticDowncastFrom_btQuadWord(const btQuadWord *object)
{
    return (const btQuaternion *)(static_cast<const btQuaternion *>(
        ((const btQuadWord *)object)
    ));
}

btQuaternion *btQuaternion_MutableStaticDowncastFrom_btQuadWord(btQuadWord *object)
{
    return (btQuaternion *)(static_cast<btQuaternion *>(
        ((btQuadWord *)object)
    ));
}

btQuaternion *btQuaternion_ConstructFromAnother(const btQuaternion *_other)
{
    return (btQuaternion *)new btQuaternion(btQuaternion(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btQuaternion(*(btQuaternion *)_other))
    ));
}

btQuaternion *btQuaternion_Construct_4(const double *_x, const double *_y, const double *_z, const double *_w)
{
    return (btQuaternion *)new btQuaternion(btQuaternion(
        ((_x ? void() : MRBINDC_THROW("Parameter `_x` can not be null.", void)), *_x),
        ((_y ? void() : MRBINDC_THROW("Parameter `_y` can not be null.", void)), *_y),
        ((_z ? void() : MRBINDC_THROW("Parameter `_z` can not be null.", void)), *_z),
        ((_w ? void() : MRBINDC_THROW("Parameter `_w` can not be null.", void)), *_w)
    ));
}

btQuaternion *btQuaternion_Construct_2(const btVector3 *_axis, const double *_angle)
{
    return (btQuaternion *)new btQuaternion(btQuaternion(
        ((_axis ? void() : MRBINDC_THROW("Parameter `_axis` can not be null.", void)), *(const btVector3 *)(_axis)),
        ((_angle ? void() : MRBINDC_THROW("Parameter `_angle` can not be null.", void)), *_angle)
    ));
}

btQuaternion *btQuaternion_Construct_3(const double *yaw, const double *pitch, const double *roll)
{
    return (btQuaternion *)new btQuaternion(btQuaternion(
        ((yaw ? void() : MRBINDC_THROW("Parameter `yaw` can not be null.", void)), *yaw),
        ((pitch ? void() : MRBINDC_THROW("Parameter `pitch` can not be null.", void)), *pitch),
        ((roll ? void() : MRBINDC_THROW("Parameter `roll` can not be null.", void)), *roll)
    ));
}

void btQuaternion_Destroy(const btQuaternion *_this)
{
    delete ((const btQuaternion *)_this);
}

void btQuaternion_DestroyArray(const btQuaternion *_this)
{
    delete[] ((const btQuaternion *)_this);
}

double *btQuaternion_ConvertTo_double_ptr(btQuaternion *_this)
{
    return (double *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)));
}

const double *btQuaternion_ConvertTo_const_double_ptr(const btQuaternion *_this)
{
    return (const double *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)));
}

btQuaternion *btQuaternion_AssignFromAnother(btQuaternion *_this, const btQuaternion *_other)
{
    return (btQuaternion *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btQuaternion(*(btQuaternion *)_other))
    ));
}

void btQuaternion_setRotation(btQuaternion *_this, const btVector3 *axis, const double *_angle)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).setRotation(
        ((axis ? void() : MRBINDC_THROW("Parameter `axis` can not be null.", void)), *(const btVector3 *)(axis)),
        ((_angle ? void() : MRBINDC_THROW("Parameter `_angle` can not be null.", void)), *_angle)
    );
}

void btQuaternion_setEuler(btQuaternion *_this, const double *yaw, const double *pitch, const double *roll)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).setEuler(
        ((yaw ? void() : MRBINDC_THROW("Parameter `yaw` can not be null.", void)), *yaw),
        ((pitch ? void() : MRBINDC_THROW("Parameter `pitch` can not be null.", void)), *pitch),
        ((roll ? void() : MRBINDC_THROW("Parameter `roll` can not be null.", void)), *roll)
    );
}

void btQuaternion_setEulerZYX(btQuaternion *_this, const double *yawZ, const double *pitchY, const double *rollX)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).setEulerZYX(
        ((yawZ ? void() : MRBINDC_THROW("Parameter `yawZ` can not be null.", void)), *yawZ),
        ((pitchY ? void() : MRBINDC_THROW("Parameter `pitchY` can not be null.", void)), *pitchY),
        ((rollX ? void() : MRBINDC_THROW("Parameter `rollX` can not be null.", void)), *rollX)
    );
}

void btQuaternion_getEulerZYX(const btQuaternion *_this, double *yawZ, double *pitchY, double *rollX)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).getEulerZYX(
        ((yawZ ? void() : MRBINDC_THROW("Parameter `yawZ` can not be null.", void)), *yawZ),
        ((pitchY ? void() : MRBINDC_THROW("Parameter `pitchY` can not be null.", void)), *pitchY),
        ((rollX ? void() : MRBINDC_THROW("Parameter `rollX` can not be null.", void)), *rollX)
    );
}

btQuaternion *btQuaternion_add_assign(btQuaternion *_this, const btQuaternion *q)
{
    return (btQuaternion *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).operator+=(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    ));
}

btQuaternion *btQuaternion_sub_assign(btQuaternion *_this, const btQuaternion *q)
{
    return (btQuaternion *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).operator-=(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    ));
}

btQuaternion *btQuaternion_mul_assign_double(btQuaternion *_this, const double *s)
{
    return (btQuaternion *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).operator*=(
        ((s ? void() : MRBINDC_THROW("Parameter `s` can not be null.", void)), *s)
    ));
}

btQuaternion *btQuaternion_mul_assign_btQuaternion(btQuaternion *_this, const btQuaternion *q)
{
    return (btQuaternion *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).operator*=(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    ));
}

double btQuaternion_dot(const btQuaternion *_this, const btQuaternion *q)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).dot(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    );
}

double btQuaternion_length2(const btQuaternion *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).length2();
}

double btQuaternion_length(const btQuaternion *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).length();
}

btQuaternion *btQuaternion_safeNormalize(btQuaternion *_this)
{
    return (btQuaternion *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).safeNormalize());
}

btQuaternion *btQuaternion_normalize(btQuaternion *_this)
{
    return (btQuaternion *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).normalize());
}

btQuaternion *Bullet_mul_btQuaternion_double(const btQuaternion *_this, const double *s)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).operator*(
        ((s ? void() : MRBINDC_THROW("Parameter `s` can not be null.", void)), *s)
    ));
}

btQuaternion *Bullet_div_btQuaternion_double(const btQuaternion *_this, const double *s)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).operator/(
        ((s ? void() : MRBINDC_THROW("Parameter `s` can not be null.", void)), *s)
    ));
}

btQuaternion *btQuaternion_div_assign(btQuaternion *_this, const double *s)
{
    return (btQuaternion *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).operator/=(
        ((s ? void() : MRBINDC_THROW("Parameter `s` can not be null.", void)), *s)
    ));
}

btQuaternion *btQuaternion_normalized(const btQuaternion *_this)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).normalized());
}

double btQuaternion_angle(const btQuaternion *_this, const btQuaternion *q)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).angle(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    );
}

double btQuaternion_angleShortestPath(const btQuaternion *_this, const btQuaternion *q)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).angleShortestPath(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    );
}

double btQuaternion_getAngle(const btQuaternion *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).getAngle();
}

double btQuaternion_getAngleShortestPath(const btQuaternion *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).getAngleShortestPath();
}

btVector3 *btQuaternion_getAxis(const btQuaternion *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).getAxis());
}

btQuaternion *btQuaternion_inverse(const btQuaternion *_this)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).inverse());
}

btQuaternion *Bullet_add_btQuaternion(const btQuaternion *_this, const btQuaternion *q2)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).operator+(
        ((q2 ? void() : MRBINDC_THROW("Parameter `q2` can not be null.", void)), *(const btQuaternion *)(q2))
    ));
}

btQuaternion *Bullet_sub_btQuaternion(const btQuaternion *_this, const btQuaternion *q2)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).operator-(
        ((q2 ? void() : MRBINDC_THROW("Parameter `q2` can not be null.", void)), *(const btQuaternion *)(q2))
    ));
}

btQuaternion *Bullet_neg_btQuaternion(const btQuaternion *_this)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).operator-());
}

btQuaternion *btQuaternion_farthest(const btQuaternion *_this, const btQuaternion *qd)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).farthest(
        ((qd ? void() : MRBINDC_THROW("Parameter `qd` can not be null.", void)), *(const btQuaternion *)(qd))
    ));
}

btQuaternion *btQuaternion_nearest(const btQuaternion *_this, const btQuaternion *qd)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).nearest(
        ((qd ? void() : MRBINDC_THROW("Parameter `qd` can not be null.", void)), *(const btQuaternion *)(qd))
    ));
}

btQuaternion *btQuaternion_slerp(const btQuaternion *_this, const btQuaternion *q, const double *t)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).slerp(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q)),
        ((t ? void() : MRBINDC_THROW("Parameter `t` can not be null.", void)), *t)
    ));
}

const btQuaternion *btQuaternion_getIdentity(void)
{
    return (const btQuaternion *)std::addressof(btQuaternion::getIdentity());
}

const double *btQuaternion_getW(const btQuaternion *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).getW());
}

const double *btQuaternion_getX(const btQuaternion *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).getX());
}

const double *btQuaternion_getY(const btQuaternion *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).getY());
}

const double *btQuaternion_getZ(const btQuaternion *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).getZ());
}

void btQuaternion_setX(btQuaternion *_this, double _x)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).setX(
        _x
    );
}

void btQuaternion_setY(btQuaternion *_this, double _y)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).setY(
        _y
    );
}

void btQuaternion_setZ(btQuaternion *_this, double _z)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).setZ(
        _z
    );
}

void btQuaternion_setW(btQuaternion *_this, double _w)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).setW(
        _w
    );
}

const double *btQuaternion_x(const btQuaternion *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).x());
}

const double *btQuaternion_y(const btQuaternion *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).y());
}

const double *btQuaternion_z(const btQuaternion *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).z());
}

const double *btQuaternion_w(const btQuaternion *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).w());
}

bool Bullet_equal_btQuaternion_btQuadWord(const btQuaternion *_this, const btQuadWord *other)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).operator==(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btQuadWord *)(other))
    );
}

bool Bullet_not_equal_btQuaternion_btQuadWord(const btQuaternion *_this, const btQuadWord *other)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btQuaternion *)(_this)).operator!=(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btQuadWord *)(other))
    );
}

void btQuaternion_setMax(btQuaternion *_this, const btQuadWord *other)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).setMax(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btQuadWord *)(other))
    );
}

void btQuaternion_setMin(btQuaternion *_this, const btQuadWord *other)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btQuaternion *)(_this)).setMin(
        ((other ? void() : MRBINDC_THROW("Parameter `other` can not be null.", void)), *(const btQuadWord *)(other))
    );
}

