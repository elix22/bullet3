// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif


//
// btITaskScheduler -- subclass this to implement a task scheduler that can dispatch work to
//                     worker threads
//
/// Generated from class `btITaskScheduler`.
typedef struct btITaskScheduler btITaskScheduler;

/// Destroys a heap-allocated instance of `btITaskScheduler`. Does nothing if the pointer is null.
BULLET_API void btITaskScheduler_Destroy(const btITaskScheduler *_this);

/// Destroys a heap-allocated array of `btITaskScheduler`. Does nothing if the pointer is null.
BULLET_API void btITaskScheduler_DestroyArray(const btITaskScheduler *_this);

/// Generated from method `btITaskScheduler::getName`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const char *btITaskScheduler_getName(const btITaskScheduler *_this);

/// Generated from method `btITaskScheduler::getMaxNumThreads`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btITaskScheduler_getMaxNumThreads(const btITaskScheduler *_this);

/// Generated from method `btITaskScheduler::getNumThreads`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btITaskScheduler_getNumThreads(const btITaskScheduler *_this);

/// Generated from method `btITaskScheduler::setNumThreads`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btITaskScheduler_setNumThreads(btITaskScheduler *_this, int numThreads);

/// Generated from method `btITaskScheduler::sleepWorkerThreadsHint`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btITaskScheduler_sleepWorkerThreadsHint(btITaskScheduler *_this);

// internal use only
/// Generated from method `btITaskScheduler::activate`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btITaskScheduler_activate(btITaskScheduler *_this);

/// Generated from method `btITaskScheduler::deactivate`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btITaskScheduler_deactivate(btITaskScheduler *_this);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btITaskScheduler *btITaskScheduler_OffsetPtr(const btITaskScheduler *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btITaskScheduler *btITaskScheduler_OffsetMutablePtr(btITaskScheduler *ptr, ptrdiff_t i);

// set the task scheduler to use for all calls to btParallelFor()
// NOTE: you must set this prior to using any of the multi-threaded "Mt" classes
/// Generated from function `btSetTaskScheduler`.
BULLET_API void btSetTaskScheduler(btITaskScheduler *ts);

// get the current task scheduler
/// Generated from function `btGetTaskScheduler`.
BULLET_API btITaskScheduler *btGetTaskScheduler(void);

// create a default task scheduler (Win32 or pthreads based)
/// Generated from function `btCreateDefaultTaskScheduler`.
BULLET_API btITaskScheduler *btCreateDefaultTaskScheduler(void);

#ifdef __cplusplus
} // extern "C"
#endif
