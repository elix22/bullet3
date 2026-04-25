// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletDynamics/ConstraintSolver/btSequentialImpulseConstraintSolver.h"

#include <BulletDynamics/ConstraintSolver/btConstraintSolver.h>
#include <BulletDynamics/ConstraintSolver/btSequentialImpulseConstraintSolver.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_DefaultConstruct(void)
{
    return (btSequentialImpulseConstraintSolver *)new btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolver());
}

btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_DefaultConstructArray(size_t num_elems)
{
    return (btSequentialImpulseConstraintSolver *)(new btSequentialImpulseConstraintSolver[num_elems]{});
}

const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_OffsetPtr(const btSequentialImpulseConstraintSolver *ptr, ptrdiff_t i)
{
    return (const btSequentialImpulseConstraintSolver *)(((const btSequentialImpulseConstraintSolver *)ptr) + i);
}

btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_OffsetMutablePtr(btSequentialImpulseConstraintSolver *ptr, ptrdiff_t i)
{
    return (btSequentialImpulseConstraintSolver *)(((btSequentialImpulseConstraintSolver *)ptr) + i);
}

const btConstraintSolver *btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver(const btSequentialImpulseConstraintSolver *object)
{
    return (const btConstraintSolver *)(static_cast<const btConstraintSolver *>(
        ((const btSequentialImpulseConstraintSolver *)object)
    ));
}

btConstraintSolver *btSequentialImpulseConstraintSolver_MutableUpcastTo_btConstraintSolver(btSequentialImpulseConstraintSolver *object)
{
    return (btConstraintSolver *)(static_cast<btConstraintSolver *>(
        ((btSequentialImpulseConstraintSolver *)object)
    ));
}

const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_StaticDowncastFrom_btConstraintSolver(const btConstraintSolver *object)
{
    return (const btSequentialImpulseConstraintSolver *)(static_cast<const btSequentialImpulseConstraintSolver *>(
        ((const btConstraintSolver *)object)
    ));
}

btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_MutableStaticDowncastFrom_btConstraintSolver(btConstraintSolver *object)
{
    return (btSequentialImpulseConstraintSolver *)(static_cast<btSequentialImpulseConstraintSolver *>(
        ((btConstraintSolver *)object)
    ));
}

const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver(const btConstraintSolver *object)
{
    return (const btSequentialImpulseConstraintSolver *)(dynamic_cast<const btSequentialImpulseConstraintSolver *>(
        ((const btConstraintSolver *)object)
    ));
}

btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_MutableDynamicDowncastFrom_btConstraintSolver(btConstraintSolver *object)
{
    return (btSequentialImpulseConstraintSolver *)(dynamic_cast<btSequentialImpulseConstraintSolver *>(
        ((btConstraintSolver *)object)
    ));
}

const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_DynamicDowncastFromOrFail_btConstraintSolver(const btConstraintSolver *object)
{
    return (const btSequentialImpulseConstraintSolver *)std::addressof(dynamic_cast<const btSequentialImpulseConstraintSolver &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConstraintSolver *)(object))
    ));
}

btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_MutableDynamicDowncastFromOrFail_btConstraintSolver(btConstraintSolver *object)
{
    return (btSequentialImpulseConstraintSolver *)std::addressof(dynamic_cast<btSequentialImpulseConstraintSolver &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConstraintSolver *)(object))
    ));
}

btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_ConstructFromAnother(Bullet_PassBy _other_pass_by, btSequentialImpulseConstraintSolver *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btSequentialImpulseConstraintSolver);
    return (btSequentialImpulseConstraintSolver *)new btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolver(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, btSequentialImpulseConstraintSolver) MRBINDC_CLASSARG_COPY(_other, (btSequentialImpulseConstraintSolver), btSequentialImpulseConstraintSolver) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btSequentialImpulseConstraintSolver) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btSequentialImpulseConstraintSolver) MRBINDC_CLASSARG_END(_other, btSequentialImpulseConstraintSolver))
    ));
}

void btSequentialImpulseConstraintSolver_Destroy(const btSequentialImpulseConstraintSolver *_this)
{
    delete ((const btSequentialImpulseConstraintSolver *)_this);
}

void btSequentialImpulseConstraintSolver_DestroyArray(const btSequentialImpulseConstraintSolver *_this)
{
    delete[] ((const btSequentialImpulseConstraintSolver *)_this);
}

btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolver_AssignFromAnother(btSequentialImpulseConstraintSolver *_this, Bullet_PassBy _other_pass_by, btSequentialImpulseConstraintSolver *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btSequentialImpulseConstraintSolver);
    return (btSequentialImpulseConstraintSolver *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolver *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, btSequentialImpulseConstraintSolver) MRBINDC_CLASSARG_COPY(_other, (btSequentialImpulseConstraintSolver), btSequentialImpulseConstraintSolver) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btSequentialImpulseConstraintSolver) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btSequentialImpulseConstraintSolver) MRBINDC_CLASSARG_END(_other, btSequentialImpulseConstraintSolver)))
    ));
}

void *Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long(unsigned long sizeInBytes)
{
    return btSequentialImpulseConstraintSolver::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr(void *ptr)
{
    btSequentialImpulseConstraintSolver::operator delete(
        ptr
    );
}

void *Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btSequentialImpulseConstraintSolver::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr_void_ptr(void *_1, void *_2)
{
    btSequentialImpulseConstraintSolver::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long(unsigned long sizeInBytes)
{
    return btSequentialImpulseConstraintSolver::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr(void *ptr)
{
    btSequentialImpulseConstraintSolver::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btSequentialImpulseConstraintSolver::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr_void_ptr(void *_1, void *_2)
{
    btSequentialImpulseConstraintSolver::operator delete[](
        _1,
        _2
    );
}

void btSequentialImpulseConstraintSolver_reset(btSequentialImpulseConstraintSolver *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolver *)(_this)).reset();
}

unsigned long btSequentialImpulseConstraintSolver_btRand2(btSequentialImpulseConstraintSolver *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolver *)(_this)).btRand2();
}

int btSequentialImpulseConstraintSolver_btRandInt2(btSequentialImpulseConstraintSolver *_this, int n)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolver *)(_this)).btRandInt2(
        n
    );
}

void btSequentialImpulseConstraintSolver_setRandSeed(btSequentialImpulseConstraintSolver *_this, unsigned long seed)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolver *)(_this)).setRandSeed(
        seed
    );
}

unsigned long btSequentialImpulseConstraintSolver_getRandSeed(const btSequentialImpulseConstraintSolver *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolver *)(_this)).getRandSeed();
}

void btSequentialImpulseConstraintSolver_prepareSolve(btSequentialImpulseConstraintSolver *_this, int _1, int _2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolver *)(_this)).prepareSolve(
        _1,
        _2
    );
}

