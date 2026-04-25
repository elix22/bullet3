// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/LinearMath/btMatrix3x3.h"

#include <LinearMath/btMatrix3x3.h>
#include <LinearMath/btQuaternion.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btMatrix3x3 *btMatrix3x3_DefaultConstruct(void)
{
    return (btMatrix3x3 *)new btMatrix3x3(btMatrix3x3());
}

btMatrix3x3 *btMatrix3x3_DefaultConstructArray(size_t num_elems)
{
    return (btMatrix3x3 *)(new btMatrix3x3[num_elems]{});
}

const btMatrix3x3 *btMatrix3x3_OffsetPtr(const btMatrix3x3 *ptr, ptrdiff_t i)
{
    return (const btMatrix3x3 *)(((const btMatrix3x3 *)ptr) + i);
}

btMatrix3x3 *btMatrix3x3_OffsetMutablePtr(btMatrix3x3 *ptr, ptrdiff_t i)
{
    return (btMatrix3x3 *)(((btMatrix3x3 *)ptr) + i);
}

btMatrix3x3 *btMatrix3x3_ConstructFromAnother(Bullet_PassBy other_pass_by, btMatrix3x3 *other)
{
    MRBINDC_CLASSARG_GUARD(other, btMatrix3x3);
    return (btMatrix3x3 *)new btMatrix3x3(btMatrix3x3(
        (MRBINDC_CLASSARG_DEF_CTOR(other, btMatrix3x3) MRBINDC_CLASSARG_COPY(other, (btMatrix3x3), btMatrix3x3) MRBINDC_CLASSARG_NO_DEF_ARG(other, Bullet_PassBy_DefaultArgument, btMatrix3x3) MRBINDC_CLASSARG_NO_DEF_ARG(other, Bullet_PassBy_NoObject, btMatrix3x3) MRBINDC_CLASSARG_END(other, btMatrix3x3))
    ));
}

btMatrix3x3 *btMatrix3x3_Construct_1(const btQuaternion *q)
{
    return (btMatrix3x3 *)new btMatrix3x3(btMatrix3x3(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    ));
}

btMatrix3x3 *btMatrix3x3_Construct_9(const double *xx, const double *xy, const double *xz, const double *yx, const double *yy, const double *yz, const double *zx, const double *zy, const double *zz)
{
    return (btMatrix3x3 *)new btMatrix3x3(btMatrix3x3(
        ((xx ? void() : MRBINDC_THROW("Parameter `xx` can not be null.", void)), *xx),
        ((xy ? void() : MRBINDC_THROW("Parameter `xy` can not be null.", void)), *xy),
        ((xz ? void() : MRBINDC_THROW("Parameter `xz` can not be null.", void)), *xz),
        ((yx ? void() : MRBINDC_THROW("Parameter `yx` can not be null.", void)), *yx),
        ((yy ? void() : MRBINDC_THROW("Parameter `yy` can not be null.", void)), *yy),
        ((yz ? void() : MRBINDC_THROW("Parameter `yz` can not be null.", void)), *yz),
        ((zx ? void() : MRBINDC_THROW("Parameter `zx` can not be null.", void)), *zx),
        ((zy ? void() : MRBINDC_THROW("Parameter `zy` can not be null.", void)), *zy),
        ((zz ? void() : MRBINDC_THROW("Parameter `zz` can not be null.", void)), *zz)
    ));
}

btMatrix3x3 *btMatrix3x3_Construct_3(const btVector3 *v0, const btVector3 *v1, const btVector3 *v2)
{
    return (btMatrix3x3 *)new btMatrix3x3(btMatrix3x3(
        ((v0 ? void() : MRBINDC_THROW("Parameter `v0` can not be null.", void)), *(const btVector3 *)(v0)),
        ((v1 ? void() : MRBINDC_THROW("Parameter `v1` can not be null.", void)), *(const btVector3 *)(v1)),
        ((v2 ? void() : MRBINDC_THROW("Parameter `v2` can not be null.", void)), *(const btVector3 *)(v2))
    ));
}

void btMatrix3x3_Destroy(const btMatrix3x3 *_this)
{
    delete ((const btMatrix3x3 *)_this);
}

void btMatrix3x3_DestroyArray(const btMatrix3x3 *_this)
{
    delete[] ((const btMatrix3x3 *)_this);
}

btMatrix3x3 *btMatrix3x3_AssignFromAnother(btMatrix3x3 *_this, Bullet_PassBy other_pass_by, btMatrix3x3 *other)
{
    MRBINDC_CLASSARG_GUARD(other, btMatrix3x3);
    return (btMatrix3x3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(other, btMatrix3x3) MRBINDC_CLASSARG_COPY(other, (btMatrix3x3), btMatrix3x3) MRBINDC_CLASSARG_NO_DEF_ARG(other, Bullet_PassBy_DefaultArgument, btMatrix3x3) MRBINDC_CLASSARG_NO_DEF_ARG(other, Bullet_PassBy_NoObject, btMatrix3x3) MRBINDC_CLASSARG_END(other, btMatrix3x3)))
    ));
}

btVector3 *btMatrix3x3_getColumn(const btMatrix3x3 *_this, int i)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).getColumn(
        i
    ));
}

const btVector3 *btMatrix3x3_getRow(const btMatrix3x3 *_this, int i)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).getRow(
        i
    ));
}

btVector3 *btMatrix3x3_index_mut(btMatrix3x3 *_this, int i)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).operator[](
        i
    ));
}

const btVector3 *btMatrix3x3_index(const btMatrix3x3 *_this, int i)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).operator[](
        i
    ));
}

btMatrix3x3 *btMatrix3x3_mul_assign(btMatrix3x3 *_this, const btMatrix3x3 *m)
{
    return (btMatrix3x3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).operator*=(
        ((m ? void() : MRBINDC_THROW("Parameter `m` can not be null.", void)), *(const btMatrix3x3 *)(m))
    ));
}

btMatrix3x3 *btMatrix3x3_add_assign(btMatrix3x3 *_this, const btMatrix3x3 *m)
{
    return (btMatrix3x3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).operator+=(
        ((m ? void() : MRBINDC_THROW("Parameter `m` can not be null.", void)), *(const btMatrix3x3 *)(m))
    ));
}

btMatrix3x3 *btMatrix3x3_sub_assign(btMatrix3x3 *_this, const btMatrix3x3 *m)
{
    return (btMatrix3x3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).operator-=(
        ((m ? void() : MRBINDC_THROW("Parameter `m` can not be null.", void)), *(const btMatrix3x3 *)(m))
    ));
}

void btMatrix3x3_setFromOpenGLSubMatrix(btMatrix3x3 *_this, const double *m)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).setFromOpenGLSubMatrix(
        m
    );
}

void btMatrix3x3_setValue(btMatrix3x3 *_this, const double *xx, const double *xy, const double *xz, const double *yx, const double *yy, const double *yz, const double *zx, const double *zy, const double *zz)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).setValue(
        ((xx ? void() : MRBINDC_THROW("Parameter `xx` can not be null.", void)), *xx),
        ((xy ? void() : MRBINDC_THROW("Parameter `xy` can not be null.", void)), *xy),
        ((xz ? void() : MRBINDC_THROW("Parameter `xz` can not be null.", void)), *xz),
        ((yx ? void() : MRBINDC_THROW("Parameter `yx` can not be null.", void)), *yx),
        ((yy ? void() : MRBINDC_THROW("Parameter `yy` can not be null.", void)), *yy),
        ((yz ? void() : MRBINDC_THROW("Parameter `yz` can not be null.", void)), *yz),
        ((zx ? void() : MRBINDC_THROW("Parameter `zx` can not be null.", void)), *zx),
        ((zy ? void() : MRBINDC_THROW("Parameter `zy` can not be null.", void)), *zy),
        ((zz ? void() : MRBINDC_THROW("Parameter `zz` can not be null.", void)), *zz)
    );
}

void btMatrix3x3_setRotation(btMatrix3x3 *_this, const btQuaternion *q)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).setRotation(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(const btQuaternion *)(q))
    );
}

void btMatrix3x3_setEulerYPR(btMatrix3x3 *_this, const double *yaw, const double *pitch, const double *roll)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).setEulerYPR(
        ((yaw ? void() : MRBINDC_THROW("Parameter `yaw` can not be null.", void)), *yaw),
        ((pitch ? void() : MRBINDC_THROW("Parameter `pitch` can not be null.", void)), *pitch),
        ((roll ? void() : MRBINDC_THROW("Parameter `roll` can not be null.", void)), *roll)
    );
}

void btMatrix3x3_setEulerZYX(btMatrix3x3 *_this, double eulerX, double eulerY, double eulerZ)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).setEulerZYX(
        eulerX,
        eulerY,
        eulerZ
    );
}

void btMatrix3x3_setIdentity(btMatrix3x3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).setIdentity();
}

void btMatrix3x3_setZero(btMatrix3x3 *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).setZero();
}

const btMatrix3x3 *btMatrix3x3_getIdentity(void)
{
    return (const btMatrix3x3 *)std::addressof(btMatrix3x3::getIdentity());
}

void btMatrix3x3_getOpenGLSubMatrix(const btMatrix3x3 *_this, double *m)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).getOpenGLSubMatrix(
        m
    );
}

void btMatrix3x3_getRotation(const btMatrix3x3 *_this, btQuaternion *q)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).getRotation(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(btQuaternion *)(q))
    );
}

void btMatrix3x3_getEulerYPR(const btMatrix3x3 *_this, double *yaw, double *pitch, double *roll)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).getEulerYPR(
        ((yaw ? void() : MRBINDC_THROW("Parameter `yaw` can not be null.", void)), *yaw),
        ((pitch ? void() : MRBINDC_THROW("Parameter `pitch` can not be null.", void)), *pitch),
        ((roll ? void() : MRBINDC_THROW("Parameter `roll` can not be null.", void)), *roll)
    );
}

void btMatrix3x3_getEulerZYX(const btMatrix3x3 *_this, double *yaw, double *pitch, double *roll, const unsigned int *solution_number)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).getEulerZYX(
        ((yaw ? void() : MRBINDC_THROW("Parameter `yaw` can not be null.", void)), *yaw),
        ((pitch ? void() : MRBINDC_THROW("Parameter `pitch` can not be null.", void)), *pitch),
        ((roll ? void() : MRBINDC_THROW("Parameter `roll` can not be null.", void)), *roll),
        (solution_number ? *solution_number : static_cast<unsigned int>(1))
    );
}

btMatrix3x3 *btMatrix3x3_scaled(const btMatrix3x3 *_this, const btVector3 *s)
{
    return (btMatrix3x3 *)new btMatrix3x3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).scaled(
        ((s ? void() : MRBINDC_THROW("Parameter `s` can not be null.", void)), *(const btVector3 *)(s))
    ));
}

double btMatrix3x3_determinant(const btMatrix3x3 *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).determinant();
}

btMatrix3x3 *btMatrix3x3_adjoint(const btMatrix3x3 *_this)
{
    return (btMatrix3x3 *)new btMatrix3x3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).adjoint());
}

btMatrix3x3 *btMatrix3x3_absolute(const btMatrix3x3 *_this)
{
    return (btMatrix3x3 *)new btMatrix3x3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).absolute());
}

btMatrix3x3 *btMatrix3x3_transpose(const btMatrix3x3 *_this)
{
    return (btMatrix3x3 *)new btMatrix3x3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).transpose());
}

btMatrix3x3 *btMatrix3x3_inverse(const btMatrix3x3 *_this)
{
    return (btMatrix3x3 *)new btMatrix3x3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).inverse());
}

btVector3 *btMatrix3x3_solve33(const btMatrix3x3 *_this, const btVector3 *b)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).solve33(
        ((b ? void() : MRBINDC_THROW("Parameter `b` can not be null.", void)), *(const btVector3 *)(b))
    ));
}

btMatrix3x3 *btMatrix3x3_transposeTimes(const btMatrix3x3 *_this, const btMatrix3x3 *m)
{
    return (btMatrix3x3 *)new btMatrix3x3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).transposeTimes(
        ((m ? void() : MRBINDC_THROW("Parameter `m` can not be null.", void)), *(const btMatrix3x3 *)(m))
    ));
}

btMatrix3x3 *btMatrix3x3_timesTranspose(const btMatrix3x3 *_this, const btMatrix3x3 *m)
{
    return (btMatrix3x3 *)new btMatrix3x3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).timesTranspose(
        ((m ? void() : MRBINDC_THROW("Parameter `m` can not be null.", void)), *(const btMatrix3x3 *)(m))
    ));
}

double btMatrix3x3_tdotx(const btMatrix3x3 *_this, const btVector3 *v)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).tdotx(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

double btMatrix3x3_tdoty(const btMatrix3x3 *_this, const btVector3 *v)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).tdoty(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

double btMatrix3x3_tdotz(const btMatrix3x3 *_this, const btVector3 *v)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).tdotz(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

void btMatrix3x3_extractRotation(btMatrix3x3 *_this, btQuaternion *q, const double *tolerance, const int *maxIter)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).extractRotation(
        ((q ? void() : MRBINDC_THROW("Parameter `q` can not be null.", void)), *(btQuaternion *)(q)),
        (tolerance ? *tolerance : static_cast<double>(1.0000000000000001E-9)),
        (maxIter ? *maxIter : static_cast<int>(100))
    );
}

void btMatrix3x3_diagonalize(btMatrix3x3 *_this, btMatrix3x3 *rot, double threshold, int maxSteps)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMatrix3x3 *)(_this)).diagonalize(
        ((rot ? void() : MRBINDC_THROW("Parameter `rot` can not be null.", void)), *(btMatrix3x3 *)(rot)),
        threshold,
        maxSteps
    );
}

double btMatrix3x3_cofac(const btMatrix3x3 *_this, int r1, int c1, int r2, int c2)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMatrix3x3 *)(_this)).cofac(
        r1,
        c1,
        r2,
        c2
    );
}

