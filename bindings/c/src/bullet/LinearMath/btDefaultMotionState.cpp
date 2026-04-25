// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/LinearMath/btDefaultMotionState.h"

#include <LinearMath/btDefaultMotionState.h>
#include <LinearMath/btMotionState.h>
#include <LinearMath/btTransform.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


const btTransform *btDefaultMotionState_Get_m_graphicsWorldTrans(const btDefaultMotionState *_this)
{
    return (const btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDefaultMotionState *)(_this)).m_graphicsWorldTrans);
}

btTransform *btDefaultMotionState_GetMutable_m_graphicsWorldTrans(btDefaultMotionState *_this)
{
    return (btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultMotionState *)(_this)).m_graphicsWorldTrans);
}

const btTransform *btDefaultMotionState_Get_m_centerOfMassOffset(const btDefaultMotionState *_this)
{
    return (const btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDefaultMotionState *)(_this)).m_centerOfMassOffset);
}

btTransform *btDefaultMotionState_GetMutable_m_centerOfMassOffset(btDefaultMotionState *_this)
{
    return (btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultMotionState *)(_this)).m_centerOfMassOffset);
}

const btTransform *btDefaultMotionState_Get_m_startWorldTrans(const btDefaultMotionState *_this)
{
    return (const btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDefaultMotionState *)(_this)).m_startWorldTrans);
}

btTransform *btDefaultMotionState_GetMutable_m_startWorldTrans(btDefaultMotionState *_this)
{
    return (btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultMotionState *)(_this)).m_startWorldTrans);
}

void *const *btDefaultMotionState_Get_m_userPointer(const btDefaultMotionState *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDefaultMotionState *)(_this)).m_userPointer);
}

void btDefaultMotionState_Set_m_userPointer(btDefaultMotionState *_this, void *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultMotionState *)(_this)).m_userPointer = value;
}

void **btDefaultMotionState_GetMutable_m_userPointer(btDefaultMotionState *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultMotionState *)(_this)).m_userPointer);
}

btDefaultMotionState *btDefaultMotionState_Construct(const btTransform *startTrans, const btTransform *centerOfMassOffset)
{
    return (btDefaultMotionState *)new btDefaultMotionState(btDefaultMotionState(
        (startTrans ? *(const btTransform *)(startTrans) : static_cast<const btTransform &>(btTransform::getIdentity())),
        (centerOfMassOffset ? *(const btTransform *)(centerOfMassOffset) : static_cast<const btTransform &>(btTransform::getIdentity()))
    ));
}

btDefaultMotionState *btDefaultMotionState_DefaultConstructArray(size_t num_elems)
{
    return (btDefaultMotionState *)(new btDefaultMotionState[num_elems]{});
}

const btDefaultMotionState *btDefaultMotionState_OffsetPtr(const btDefaultMotionState *ptr, ptrdiff_t i)
{
    return (const btDefaultMotionState *)(((const btDefaultMotionState *)ptr) + i);
}

btDefaultMotionState *btDefaultMotionState_OffsetMutablePtr(btDefaultMotionState *ptr, ptrdiff_t i)
{
    return (btDefaultMotionState *)(((btDefaultMotionState *)ptr) + i);
}

const btMotionState *btDefaultMotionState_UpcastTo_btMotionState(const btDefaultMotionState *object)
{
    return (const btMotionState *)(static_cast<const btMotionState *>(
        ((const btDefaultMotionState *)object)
    ));
}

btMotionState *btDefaultMotionState_MutableUpcastTo_btMotionState(btDefaultMotionState *object)
{
    return (btMotionState *)(static_cast<btMotionState *>(
        ((btDefaultMotionState *)object)
    ));
}

const btDefaultMotionState *btDefaultMotionState_StaticDowncastFrom_btMotionState(const btMotionState *object)
{
    return (const btDefaultMotionState *)(static_cast<const btDefaultMotionState *>(
        ((const btMotionState *)object)
    ));
}

btDefaultMotionState *btDefaultMotionState_MutableStaticDowncastFrom_btMotionState(btMotionState *object)
{
    return (btDefaultMotionState *)(static_cast<btDefaultMotionState *>(
        ((btMotionState *)object)
    ));
}

const btDefaultMotionState *btDefaultMotionState_DynamicDowncastFrom_btMotionState(const btMotionState *object)
{
    return (const btDefaultMotionState *)(dynamic_cast<const btDefaultMotionState *>(
        ((const btMotionState *)object)
    ));
}

btDefaultMotionState *btDefaultMotionState_MutableDynamicDowncastFrom_btMotionState(btMotionState *object)
{
    return (btDefaultMotionState *)(dynamic_cast<btDefaultMotionState *>(
        ((btMotionState *)object)
    ));
}

const btDefaultMotionState *btDefaultMotionState_DynamicDowncastFromOrFail_btMotionState(const btMotionState *object)
{
    return (const btDefaultMotionState *)std::addressof(dynamic_cast<const btDefaultMotionState &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btMotionState *)(object))
    ));
}

btDefaultMotionState *btDefaultMotionState_MutableDynamicDowncastFromOrFail_btMotionState(btMotionState *object)
{
    return (btDefaultMotionState *)std::addressof(dynamic_cast<btDefaultMotionState &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btMotionState *)(object))
    ));
}

btDefaultMotionState *btDefaultMotionState_ConstructFromAnother(Bullet_PassBy _other_pass_by, btDefaultMotionState *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btDefaultMotionState);
    return (btDefaultMotionState *)new btDefaultMotionState(btDefaultMotionState(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, btDefaultMotionState) MRBINDC_CLASSARG_COPY(_other, (btDefaultMotionState), btDefaultMotionState) MRBINDC_CLASSARG_MOVE(_other, (btDefaultMotionState), btDefaultMotionState) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btDefaultMotionState) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btDefaultMotionState) MRBINDC_CLASSARG_END(_other, btDefaultMotionState))
    ));
}

void btDefaultMotionState_Destroy(const btDefaultMotionState *_this)
{
    delete ((const btDefaultMotionState *)_this);
}

void btDefaultMotionState_DestroyArray(const btDefaultMotionState *_this)
{
    delete[] ((const btDefaultMotionState *)_this);
}

btDefaultMotionState *btDefaultMotionState_AssignFromAnother(btDefaultMotionState *_this, Bullet_PassBy _other_pass_by, btDefaultMotionState *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btDefaultMotionState);
    return (btDefaultMotionState *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultMotionState *)(_this)).operator=(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, btDefaultMotionState) MRBINDC_CLASSARG_COPY(_other, (btDefaultMotionState), btDefaultMotionState) MRBINDC_CLASSARG_MOVE(_other, (btDefaultMotionState), btDefaultMotionState) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btDefaultMotionState) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btDefaultMotionState) MRBINDC_CLASSARG_END(_other, btDefaultMotionState))
    ));
}

void *Bullet_new_btDefaultMotionState_unsigned_long(unsigned long sizeInBytes)
{
    return btDefaultMotionState::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btDefaultMotionState_void_ptr(void *ptr)
{
    btDefaultMotionState::operator delete(
        ptr
    );
}

void *Bullet_new_btDefaultMotionState_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btDefaultMotionState::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btDefaultMotionState_void_ptr_void_ptr(void *_1, void *_2)
{
    btDefaultMotionState::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btDefaultMotionState_unsigned_long(unsigned long sizeInBytes)
{
    return btDefaultMotionState::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btDefaultMotionState_void_ptr(void *ptr)
{
    btDefaultMotionState::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btDefaultMotionState_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btDefaultMotionState::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btDefaultMotionState_void_ptr_void_ptr(void *_1, void *_2)
{
    btDefaultMotionState::operator delete[](
        _1,
        _2
    );
}

void btDefaultMotionState_getWorldTransform(const btDefaultMotionState *_this, btTransform *centerOfMassWorldTrans)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDefaultMotionState *)(_this)).getWorldTransform(
        ((centerOfMassWorldTrans ? void() : MRBINDC_THROW("Parameter `centerOfMassWorldTrans` can not be null.", void)), *(btTransform *)(centerOfMassWorldTrans))
    );
}

void btDefaultMotionState_setWorldTransform(btDefaultMotionState *_this, const btTransform *centerOfMassWorldTrans)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDefaultMotionState *)(_this)).setWorldTransform(
        ((centerOfMassWorldTrans ? void() : MRBINDC_THROW("Parameter `centerOfMassWorldTrans` can not be null.", void)), *(const btTransform *)(centerOfMassWorldTrans))
    );
}

