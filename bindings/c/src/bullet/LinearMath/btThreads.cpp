// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/LinearMath/btThreads.h"

#include <LinearMath/btThreads.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void btITaskScheduler_Destroy(const btITaskScheduler *_this)
{
    delete ((const btITaskScheduler *)_this);
}

void btITaskScheduler_DestroyArray(const btITaskScheduler *_this)
{
    delete[] ((const btITaskScheduler *)_this);
}

const char *btITaskScheduler_getName(const btITaskScheduler *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btITaskScheduler *)(_this)).getName();
}

int btITaskScheduler_getMaxNumThreads(const btITaskScheduler *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btITaskScheduler *)(_this)).getMaxNumThreads();
}

int btITaskScheduler_getNumThreads(const btITaskScheduler *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btITaskScheduler *)(_this)).getNumThreads();
}

void btITaskScheduler_setNumThreads(btITaskScheduler *_this, int numThreads)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btITaskScheduler *)(_this)).setNumThreads(
        numThreads
    );
}

void btITaskScheduler_sleepWorkerThreadsHint(btITaskScheduler *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btITaskScheduler *)(_this)).sleepWorkerThreadsHint();
}

void btITaskScheduler_activate(btITaskScheduler *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btITaskScheduler *)(_this)).activate();
}

void btITaskScheduler_deactivate(btITaskScheduler *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btITaskScheduler *)(_this)).deactivate();
}

const btITaskScheduler *btITaskScheduler_OffsetPtr(const btITaskScheduler *ptr, ptrdiff_t i)
{
    return (const btITaskScheduler *)(((const btITaskScheduler *)ptr) + i);
}

btITaskScheduler *btITaskScheduler_OffsetMutablePtr(btITaskScheduler *ptr, ptrdiff_t i)
{
    return (btITaskScheduler *)(((btITaskScheduler *)ptr) + i);
}

void btSetTaskScheduler(btITaskScheduler *ts)
{
    ::btSetTaskScheduler(
        ((btITaskScheduler *)ts)
    );
}

btITaskScheduler *btGetTaskScheduler(void)
{
    return (btITaskScheduler *)(::btGetTaskScheduler());
}

btITaskScheduler *btCreateDefaultTaskScheduler(void)
{
    return (btITaskScheduler *)(::btCreateDefaultTaskScheduler());
}

