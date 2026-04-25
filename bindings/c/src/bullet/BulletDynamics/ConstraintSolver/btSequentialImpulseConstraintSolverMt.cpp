// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletDynamics/ConstraintSolver/btSequentialImpulseConstraintSolverMt.h"

#include <BulletDynamics/ConstraintSolver/btConstraintSolver.h>
#include <BulletDynamics/ConstraintSolver/btSequentialImpulseConstraintSolver.h>
#include <BulletDynamics/ConstraintSolver/btSequentialImpulseConstraintSolverMt.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>
#include <type_traits>


const bool *btSequentialImpulseConstraintSolverMt_Get_s_allowNestedParallelForLoops(void)
{
    return std::addressof(btSequentialImpulseConstraintSolverMt::s_allowNestedParallelForLoops);
}

void btSequentialImpulseConstraintSolverMt_Set_s_allowNestedParallelForLoops(bool value)
{
    btSequentialImpulseConstraintSolverMt::s_allowNestedParallelForLoops = value;
}

bool *btSequentialImpulseConstraintSolverMt_GetMutable_s_allowNestedParallelForLoops(void)
{
    return std::addressof(btSequentialImpulseConstraintSolverMt::s_allowNestedParallelForLoops);
}

const int *btSequentialImpulseConstraintSolverMt_Get_s_minimumContactManifoldsForBatching(void)
{
    return std::addressof(btSequentialImpulseConstraintSolverMt::s_minimumContactManifoldsForBatching);
}

void btSequentialImpulseConstraintSolverMt_Set_s_minimumContactManifoldsForBatching(int value)
{
    btSequentialImpulseConstraintSolverMt::s_minimumContactManifoldsForBatching = value;
}

int *btSequentialImpulseConstraintSolverMt_GetMutable_s_minimumContactManifoldsForBatching(void)
{
    return std::addressof(btSequentialImpulseConstraintSolverMt::s_minimumContactManifoldsForBatching);
}

const int *btSequentialImpulseConstraintSolverMt_Get_s_minBatchSize(void)
{
    return std::addressof(btSequentialImpulseConstraintSolverMt::s_minBatchSize);
}

void btSequentialImpulseConstraintSolverMt_Set_s_minBatchSize(int value)
{
    btSequentialImpulseConstraintSolverMt::s_minBatchSize = value;
}

int *btSequentialImpulseConstraintSolverMt_GetMutable_s_minBatchSize(void)
{
    return std::addressof(btSequentialImpulseConstraintSolverMt::s_minBatchSize);
}

const int *btSequentialImpulseConstraintSolverMt_Get_s_maxBatchSize(void)
{
    return std::addressof(btSequentialImpulseConstraintSolverMt::s_maxBatchSize);
}

void btSequentialImpulseConstraintSolverMt_Set_s_maxBatchSize(int value)
{
    btSequentialImpulseConstraintSolverMt::s_maxBatchSize = value;
}

int *btSequentialImpulseConstraintSolverMt_GetMutable_s_maxBatchSize(void)
{
    return std::addressof(btSequentialImpulseConstraintSolverMt::s_maxBatchSize);
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DefaultConstruct(void)
{
    return (btSequentialImpulseConstraintSolverMt *)new btSequentialImpulseConstraintSolverMt(btSequentialImpulseConstraintSolverMt());
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DefaultConstructArray(size_t num_elems)
{
    return (btSequentialImpulseConstraintSolverMt *)(new btSequentialImpulseConstraintSolverMt[num_elems]{});
}

const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_OffsetPtr(const btSequentialImpulseConstraintSolverMt *ptr, ptrdiff_t i)
{
    return (const btSequentialImpulseConstraintSolverMt *)(((const btSequentialImpulseConstraintSolverMt *)ptr) + i);
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_OffsetMutablePtr(btSequentialImpulseConstraintSolverMt *ptr, ptrdiff_t i)
{
    return (btSequentialImpulseConstraintSolverMt *)(((btSequentialImpulseConstraintSolverMt *)ptr) + i);
}

const btConstraintSolver *btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver(const btSequentialImpulseConstraintSolverMt *object)
{
    return (const btConstraintSolver *)(static_cast<const btConstraintSolver *>(
        ((const btSequentialImpulseConstraintSolverMt *)object)
    ));
}

btConstraintSolver *btSequentialImpulseConstraintSolverMt_MutableUpcastTo_btConstraintSolver(btSequentialImpulseConstraintSolverMt *object)
{
    return (btConstraintSolver *)(static_cast<btConstraintSolver *>(
        ((btSequentialImpulseConstraintSolverMt *)object)
    ));
}

const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_StaticDowncastFrom_btConstraintSolver(const btConstraintSolver *object)
{
    return (const btSequentialImpulseConstraintSolverMt *)(static_cast<const btSequentialImpulseConstraintSolverMt *>(
        ((const btConstraintSolver *)object)
    ));
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableStaticDowncastFrom_btConstraintSolver(btConstraintSolver *object)
{
    return (btSequentialImpulseConstraintSolverMt *)(static_cast<btSequentialImpulseConstraintSolverMt *>(
        ((btConstraintSolver *)object)
    ));
}

const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver(const btConstraintSolver *object)
{
    return (const btSequentialImpulseConstraintSolverMt *)(dynamic_cast<const btSequentialImpulseConstraintSolverMt *>(
        ((const btConstraintSolver *)object)
    ));
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableDynamicDowncastFrom_btConstraintSolver(btConstraintSolver *object)
{
    return (btSequentialImpulseConstraintSolverMt *)(dynamic_cast<btSequentialImpulseConstraintSolverMt *>(
        ((btConstraintSolver *)object)
    ));
}

const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DynamicDowncastFromOrFail_btConstraintSolver(const btConstraintSolver *object)
{
    return (const btSequentialImpulseConstraintSolverMt *)std::addressof(dynamic_cast<const btSequentialImpulseConstraintSolverMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConstraintSolver *)(object))
    ));
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableDynamicDowncastFromOrFail_btConstraintSolver(btConstraintSolver *object)
{
    return (btSequentialImpulseConstraintSolverMt *)std::addressof(dynamic_cast<btSequentialImpulseConstraintSolverMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConstraintSolver *)(object))
    ));
}

const btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver(const btSequentialImpulseConstraintSolverMt *object)
{
    return (const btSequentialImpulseConstraintSolver *)(static_cast<const btSequentialImpulseConstraintSolver *>(
        ((const btSequentialImpulseConstraintSolverMt *)object)
    ));
}

btSequentialImpulseConstraintSolver *btSequentialImpulseConstraintSolverMt_MutableUpcastTo_btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolverMt *object)
{
    return (btSequentialImpulseConstraintSolver *)(static_cast<btSequentialImpulseConstraintSolver *>(
        ((btSequentialImpulseConstraintSolverMt *)object)
    ));
}

const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_StaticDowncastFrom_btSequentialImpulseConstraintSolver(const btSequentialImpulseConstraintSolver *object)
{
    return (const btSequentialImpulseConstraintSolverMt *)(static_cast<const btSequentialImpulseConstraintSolverMt *>(
        ((const btSequentialImpulseConstraintSolver *)object)
    ));
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableStaticDowncastFrom_btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolver *object)
{
    return (btSequentialImpulseConstraintSolverMt *)(static_cast<btSequentialImpulseConstraintSolverMt *>(
        ((btSequentialImpulseConstraintSolver *)object)
    ));
}

const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver(const btSequentialImpulseConstraintSolver *object)
{
    return (const btSequentialImpulseConstraintSolverMt *)(dynamic_cast<const btSequentialImpulseConstraintSolverMt *>(
        ((const btSequentialImpulseConstraintSolver *)object)
    ));
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableDynamicDowncastFrom_btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolver *object)
{
    return (btSequentialImpulseConstraintSolverMt *)(dynamic_cast<btSequentialImpulseConstraintSolverMt *>(
        ((btSequentialImpulseConstraintSolver *)object)
    ));
}

const btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_DynamicDowncastFromOrFail_btSequentialImpulseConstraintSolver(const btSequentialImpulseConstraintSolver *object)
{
    return (const btSequentialImpulseConstraintSolverMt *)std::addressof(dynamic_cast<const btSequentialImpulseConstraintSolverMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btSequentialImpulseConstraintSolver *)(object))
    ));
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_MutableDynamicDowncastFromOrFail_btSequentialImpulseConstraintSolver(btSequentialImpulseConstraintSolver *object)
{
    return (btSequentialImpulseConstraintSolverMt *)std::addressof(dynamic_cast<btSequentialImpulseConstraintSolverMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btSequentialImpulseConstraintSolver *)(object))
    ));
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_ConstructFromAnother(Bullet_PassBy _other_pass_by, btSequentialImpulseConstraintSolverMt *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btSequentialImpulseConstraintSolverMt);
    return (btSequentialImpulseConstraintSolverMt *)new btSequentialImpulseConstraintSolverMt(btSequentialImpulseConstraintSolverMt(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, btSequentialImpulseConstraintSolverMt) MRBINDC_CLASSARG_COPY(_other, (btSequentialImpulseConstraintSolverMt), btSequentialImpulseConstraintSolverMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btSequentialImpulseConstraintSolverMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btSequentialImpulseConstraintSolverMt) MRBINDC_CLASSARG_END(_other, btSequentialImpulseConstraintSolverMt))
    ));
}

void btSequentialImpulseConstraintSolverMt_Destroy(const btSequentialImpulseConstraintSolverMt *_this)
{
    delete ((const btSequentialImpulseConstraintSolverMt *)_this);
}

void btSequentialImpulseConstraintSolverMt_DestroyArray(const btSequentialImpulseConstraintSolverMt *_this)
{
    delete[] ((const btSequentialImpulseConstraintSolverMt *)_this);
}

btSequentialImpulseConstraintSolverMt *btSequentialImpulseConstraintSolverMt_AssignFromAnother(btSequentialImpulseConstraintSolverMt *_this, Bullet_PassBy _other_pass_by, btSequentialImpulseConstraintSolverMt *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btSequentialImpulseConstraintSolverMt);
    return (btSequentialImpulseConstraintSolverMt *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, btSequentialImpulseConstraintSolverMt) MRBINDC_CLASSARG_COPY(_other, (btSequentialImpulseConstraintSolverMt), btSequentialImpulseConstraintSolverMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btSequentialImpulseConstraintSolverMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btSequentialImpulseConstraintSolverMt) MRBINDC_CLASSARG_END(_other, btSequentialImpulseConstraintSolverMt)))
    ));
}

void *Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long(unsigned long sizeInBytes)
{
    return btSequentialImpulseConstraintSolverMt::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr(void *ptr)
{
    btSequentialImpulseConstraintSolverMt::operator delete(
        ptr
    );
}

void *Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btSequentialImpulseConstraintSolverMt::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr(void *_1, void *_2)
{
    btSequentialImpulseConstraintSolverMt::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long(unsigned long sizeInBytes)
{
    return btSequentialImpulseConstraintSolverMt::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr(void *ptr)
{
    btSequentialImpulseConstraintSolverMt::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btSequentialImpulseConstraintSolverMt::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr(void *_1, void *_2)
{
    btSequentialImpulseConstraintSolverMt::operator delete[](
        _1,
        _2
    );
}

void btSequentialImpulseConstraintSolverMt_internalAllocContactConstraints(btSequentialImpulseConstraintSolverMt *_this, const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *cachedInfoArray, int numManifolds)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt *)(_this)).internalAllocContactConstraints(
        ((const btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)cachedInfoArray),
        numManifolds
    );
}

void btSequentialImpulseConstraintSolverMt_reset(btSequentialImpulseConstraintSolverMt *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt *)(_this)).reset();
}

unsigned long btSequentialImpulseConstraintSolverMt_btRand2(btSequentialImpulseConstraintSolverMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt *)(_this)).btRand2();
}

int btSequentialImpulseConstraintSolverMt_btRandInt2(btSequentialImpulseConstraintSolverMt *_this, int n)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt *)(_this)).btRandInt2(
        n
    );
}

void btSequentialImpulseConstraintSolverMt_setRandSeed(btSequentialImpulseConstraintSolverMt *_this, unsigned long seed)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt *)(_this)).setRandSeed(
        seed
    );
}

unsigned long btSequentialImpulseConstraintSolverMt_getRandSeed(const btSequentialImpulseConstraintSolverMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolverMt *)(_this)).getRandSeed();
}

void btSequentialImpulseConstraintSolverMt_prepareSolve(btSequentialImpulseConstraintSolverMt *_this, int _1, int _2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt *)(_this)).prepareSolve(
        _1,
        _2
    );
}

const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_MAX_NUM_CONTACT_POINTS(void)
{
    return std::addressof(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::MAX_NUM_CONTACT_POINTS);
}

const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_numTouchingContacts(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).numTouchingContacts);
}

void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Set_numTouchingContacts(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).numTouchingContacts = value;
}

int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_numTouchingContacts(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).numTouchingContacts);
}

const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_solverBodyIds(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).solverBodyIds[0]);
}

int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_solverBodyIds(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).solverBodyIds[0]);
}

size_t btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetSize_solverBodyIds(void)
{
    return std::extent_v<decltype(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::solverBodyIds)>;
}

const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactIndex(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).contactIndex);
}

void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Set_contactIndex(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).contactIndex = value;
}

int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactIndex(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).contactIndex);
}

const int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_rollingFrictionIndex(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).rollingFrictionIndex);
}

void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Set_rollingFrictionIndex(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).rollingFrictionIndex = value;
}

int *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_rollingFrictionIndex(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).rollingFrictionIndex);
}

const bool *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactHasRollingFriction(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).contactHasRollingFriction[0]);
}

bool *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactHasRollingFriction(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).contactHasRollingFriction[0]);
}

size_t btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetSize_contactHasRollingFriction(void)
{
    return std::extent_v<decltype(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::contactHasRollingFriction)>;
}

btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct(void)
{
    return (btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *)new btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo());
}

btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstructArray(size_t num_elems)
{
    return (btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *)(new btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo[num_elems]{});
}

const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_OffsetPtr(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *ptr, ptrdiff_t i)
{
    return (const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *)(((const btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)ptr) + i);
}

btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_OffsetMutablePtr(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *ptr, ptrdiff_t i)
{
    return (btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *)(((btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)ptr) + i);
}

btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_other)
{
    return (btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *)new btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo(*(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)_other))
    ));
}

void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Destroy(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    delete ((const btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)_this);
}

void btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DestroyArray(const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this)
{
    delete[] ((const btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)_this);
}

btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_AssignFromAnother(btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_this, const btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *_other)
{
    return (btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo(*(btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo *)_other))
    ));
}

const int *btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverConstraint(const btSequentialImpulseConstraintSolverMt_JointParams *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).m_solverConstraint);
}

void btSequentialImpulseConstraintSolverMt_JointParams_Set_m_solverConstraint(btSequentialImpulseConstraintSolverMt_JointParams *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).m_solverConstraint = value;
}

int *btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverConstraint(btSequentialImpulseConstraintSolverMt_JointParams *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).m_solverConstraint);
}

const int *btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyA(const btSequentialImpulseConstraintSolverMt_JointParams *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).m_solverBodyA);
}

void btSequentialImpulseConstraintSolverMt_JointParams_Set_m_solverBodyA(btSequentialImpulseConstraintSolverMt_JointParams *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).m_solverBodyA = value;
}

int *btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyA(btSequentialImpulseConstraintSolverMt_JointParams *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).m_solverBodyA);
}

const int *btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyB(const btSequentialImpulseConstraintSolverMt_JointParams *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).m_solverBodyB);
}

void btSequentialImpulseConstraintSolverMt_JointParams_Set_m_solverBodyB(btSequentialImpulseConstraintSolverMt_JointParams *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).m_solverBodyB = value;
}

int *btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyB(btSequentialImpulseConstraintSolverMt_JointParams *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).m_solverBodyB);
}

btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct(void)
{
    return (btSequentialImpulseConstraintSolverMt_JointParams *)new btSequentialImpulseConstraintSolverMt::JointParams(btSequentialImpulseConstraintSolverMt::JointParams());
}

btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstructArray(size_t num_elems)
{
    return (btSequentialImpulseConstraintSolverMt_JointParams *)(new btSequentialImpulseConstraintSolverMt::JointParams[num_elems]{});
}

btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom(int m_solverConstraint, int m_solverBodyA, int m_solverBodyB)
{
    return (btSequentialImpulseConstraintSolverMt_JointParams *)new btSequentialImpulseConstraintSolverMt::JointParams(btSequentialImpulseConstraintSolverMt::JointParams{
        m_solverConstraint,
        m_solverBodyA,
        m_solverBodyB
    });
}

const btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_OffsetPtr(const btSequentialImpulseConstraintSolverMt_JointParams *ptr, ptrdiff_t i)
{
    return (const btSequentialImpulseConstraintSolverMt_JointParams *)(((const btSequentialImpulseConstraintSolverMt::JointParams *)ptr) + i);
}

btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_OffsetMutablePtr(btSequentialImpulseConstraintSolverMt_JointParams *ptr, ptrdiff_t i)
{
    return (btSequentialImpulseConstraintSolverMt_JointParams *)(((btSequentialImpulseConstraintSolverMt::JointParams *)ptr) + i);
}

btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother(const btSequentialImpulseConstraintSolverMt_JointParams *_other)
{
    return (btSequentialImpulseConstraintSolverMt_JointParams *)new btSequentialImpulseConstraintSolverMt::JointParams(btSequentialImpulseConstraintSolverMt::JointParams(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btSequentialImpulseConstraintSolverMt::JointParams(*(btSequentialImpulseConstraintSolverMt::JointParams *)_other))
    ));
}

void btSequentialImpulseConstraintSolverMt_JointParams_Destroy(const btSequentialImpulseConstraintSolverMt_JointParams *_this)
{
    delete ((const btSequentialImpulseConstraintSolverMt::JointParams *)_this);
}

void btSequentialImpulseConstraintSolverMt_JointParams_DestroyArray(const btSequentialImpulseConstraintSolverMt_JointParams *_this)
{
    delete[] ((const btSequentialImpulseConstraintSolverMt::JointParams *)_this);
}

btSequentialImpulseConstraintSolverMt_JointParams *btSequentialImpulseConstraintSolverMt_JointParams_AssignFromAnother(btSequentialImpulseConstraintSolverMt_JointParams *_this, const btSequentialImpulseConstraintSolverMt_JointParams *_other)
{
    return (btSequentialImpulseConstraintSolverMt_JointParams *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btSequentialImpulseConstraintSolverMt::JointParams *)(_this)).operator=(
        ((_other ? void() : MRBINDC_THROW("Parameter `_other` can not be null.", void)), btSequentialImpulseConstraintSolverMt::JointParams(*(btSequentialImpulseConstraintSolverMt::JointParams *)_other))
    ));
}


const int btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::MAX_NUM_CONTACT_POINTS;
