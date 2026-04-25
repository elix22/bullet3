// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/LinearMath/btMotionState.h"

#include <LinearMath/btMotionState.h>
#include <LinearMath/btTransform.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void btMotionState_Destroy(const btMotionState *_this)
{
    delete ((const btMotionState *)_this);
}

void btMotionState_DestroyArray(const btMotionState *_this)
{
    delete[] ((const btMotionState *)_this);
}

void btMotionState_getWorldTransform(const btMotionState *_this, btTransform *worldTrans)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btMotionState *)(_this)).getWorldTransform(
        ((worldTrans ? void() : MRBINDC_THROW("Parameter `worldTrans` can not be null.", void)), *(btTransform *)(worldTrans))
    );
}

void btMotionState_setWorldTransform(btMotionState *_this, const btTransform *worldTrans)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btMotionState *)(_this)).setWorldTransform(
        ((worldTrans ? void() : MRBINDC_THROW("Parameter `worldTrans` can not be null.", void)), *(const btTransform *)(worldTrans))
    );
}

const btMotionState *btMotionState_OffsetPtr(const btMotionState *ptr, ptrdiff_t i)
{
    return (const btMotionState *)(((const btMotionState *)ptr) + i);
}

btMotionState *btMotionState_OffsetMutablePtr(btMotionState *ptr, ptrdiff_t i)
{
    return (btMotionState *)(((btMotionState *)ptr) + i);
}

