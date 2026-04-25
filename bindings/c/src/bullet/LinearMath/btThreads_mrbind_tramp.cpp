// machine generated, do not edit
#include <LinearMath/btThreads.h>

extern "C" void _mrbind_tramp_btSetTaskScheduler(btITaskScheduler * ts)
{
    btSetTaskScheduler(ts);
}

extern "C" btITaskScheduler * _mrbind_tramp_btGetTaskScheduler()
{
    return btGetTaskScheduler();
}

extern "C" btITaskScheduler * _mrbind_tramp_btCreateDefaultTaskScheduler()
{
    return btCreateDefaultTaskScheduler();
}

