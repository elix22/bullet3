// machine generated, do not edit
#pragma once

#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.


///The btMotionState interface class allows the dynamics world to synchronize and interpolate the updated world transforms with graphics
///For optimizations, potentially only moving objects get synchronized (using setWorldPosition/setWorldOrientation)
/// Generated from class `btMotionState`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btDefaultMotionState`
typedef struct btMotionState btMotionState;

/// Destroys a heap-allocated instance of `btMotionState`. Does nothing if the pointer is null.
BULLET_API void btMotionState_Destroy(const btMotionState *_this);

/// Destroys a heap-allocated array of `btMotionState`. Does nothing if the pointer is null.
BULLET_API void btMotionState_DestroyArray(const btMotionState *_this);

/// Generated from method `btMotionState::getWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `worldTrans` can not be null. It is a single object.
BULLET_API void btMotionState_getWorldTransform(const btMotionState *_this, btTransform *worldTrans);

//Bullet only calls the update of worldtransform for active objects
/// Generated from method `btMotionState::setWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `worldTrans` can not be null. It is a single object.
BULLET_API void btMotionState_setWorldTransform(btMotionState *_this, const btTransform *worldTrans);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btMotionState *btMotionState_OffsetPtr(const btMotionState *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btMotionState *btMotionState_OffsetMutablePtr(btMotionState *ptr, ptrdiff_t i);

#ifdef __cplusplus
} // extern "C"
#endif
