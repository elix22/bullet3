// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btMotionState btMotionState; // Defined in `#include <bullet/LinearMath/btMotionState.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.


///The btDefaultMotionState provides a common implementation to synchronize world transforms with offsets.
/// Generated from class `btDefaultMotionState`.
/// Base classes:
///   Direct: (non-virtual)
///     `btMotionState`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btDefaultMotionState btDefaultMotionState;

/// Returns a pointer to a member variable of class `btDefaultMotionState` named `m_graphicsWorldTrans`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btTransform *btDefaultMotionState_Get_m_graphicsWorldTrans(const btDefaultMotionState *_this);

/// Returns a mutable pointer to a member variable of class `btDefaultMotionState` named `m_graphicsWorldTrans`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btTransform *btDefaultMotionState_GetMutable_m_graphicsWorldTrans(btDefaultMotionState *_this);

/// Returns a pointer to a member variable of class `btDefaultMotionState` named `m_centerOfMassOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btTransform *btDefaultMotionState_Get_m_centerOfMassOffset(const btDefaultMotionState *_this);

/// Returns a mutable pointer to a member variable of class `btDefaultMotionState` named `m_centerOfMassOffset`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btTransform *btDefaultMotionState_GetMutable_m_centerOfMassOffset(btDefaultMotionState *_this);

/// Returns a pointer to a member variable of class `btDefaultMotionState` named `m_startWorldTrans`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btTransform *btDefaultMotionState_Get_m_startWorldTrans(const btDefaultMotionState *_this);

/// Returns a mutable pointer to a member variable of class `btDefaultMotionState` named `m_startWorldTrans`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btTransform *btDefaultMotionState_GetMutable_m_startWorldTrans(btDefaultMotionState *_this);

/// Returns a pointer to a member variable of class `btDefaultMotionState` named `m_userPointer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API void *const *btDefaultMotionState_Get_m_userPointer(const btDefaultMotionState *_this);

/// Modifies a member variable of class `btDefaultMotionState` named `m_userPointer`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_userPointer`.
/// When this function is called, this object will drop object references it held previously in `m_userPointer`.
BULLET_API void btDefaultMotionState_Set_m_userPointer(btDefaultMotionState *_this, void *value);

/// Returns a mutable pointer to a member variable of class `btDefaultMotionState` named `m_userPointer`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API void **btDefaultMotionState_GetMutable_m_userPointer(btDefaultMotionState *_this);

/// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
/// Parameter `startTrans` is a single object.
/// Parameter `startTrans` has a default argument: `btTransform::getIdentity()`, pass a null pointer to use it.
/// Parameter `centerOfMassOffset` is a single object.
/// Parameter `centerOfMassOffset` has a default argument: `btTransform::getIdentity()`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `btDefaultMotionState_Destroy()` to free it when you're done using it.
BULLET_API btDefaultMotionState *btDefaultMotionState_Construct(const btTransform *startTrans, const btTransform *centerOfMassOffset);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btDefaultMotionState_DestroyArray()`.
/// Use `btDefaultMotionState_OffsetMutablePtr()` and `btDefaultMotionState_OffsetPtr()` to access the array elements.
BULLET_API btDefaultMotionState *btDefaultMotionState_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btDefaultMotionState *btDefaultMotionState_OffsetPtr(const btDefaultMotionState *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btDefaultMotionState *btDefaultMotionState_OffsetMutablePtr(btDefaultMotionState *ptr, ptrdiff_t i);

/// Upcasts an instance of `btDefaultMotionState` to its base class `btMotionState`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btMotionState *btDefaultMotionState_UpcastTo_btMotionState(const btDefaultMotionState *object);

/// Upcasts an instance of `btDefaultMotionState` to its base class `btMotionState`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btMotionState *btDefaultMotionState_MutableUpcastTo_btMotionState(btDefaultMotionState *object);

/// Downcasts an instance of `btMotionState` to a derived class `btDefaultMotionState`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDefaultMotionState *btDefaultMotionState_StaticDowncastFrom_btMotionState(const btMotionState *object);

/// Downcasts an instance of `btMotionState` to a derived class `btDefaultMotionState`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDefaultMotionState *btDefaultMotionState_MutableStaticDowncastFrom_btMotionState(btMotionState *object);

/// Downcasts an instance of `btMotionState` to a derived class `btDefaultMotionState`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDefaultMotionState *btDefaultMotionState_DynamicDowncastFrom_btMotionState(const btMotionState *object);

/// Downcasts an instance of `btMotionState` to a derived class `btDefaultMotionState`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDefaultMotionState *btDefaultMotionState_MutableDynamicDowncastFrom_btMotionState(btMotionState *object);

/// Downcasts an instance of `btMotionState` to a derived class `btDefaultMotionState`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btDefaultMotionState *btDefaultMotionState_DynamicDowncastFromOrFail_btMotionState(const btMotionState *object);

/// Downcasts an instance of `btMotionState` to a derived class `btDefaultMotionState`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btDefaultMotionState *btDefaultMotionState_MutableDynamicDowncastFromOrFail_btMotionState(btMotionState *object);

/// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btDefaultMotionState_Destroy()` to free it when you're done using it.
BULLET_API btDefaultMotionState *btDefaultMotionState_ConstructFromAnother(Bullet_PassBy _other_pass_by, btDefaultMotionState *_other);

/// Destroys a heap-allocated instance of `btDefaultMotionState`. Does nothing if the pointer is null.
BULLET_API void btDefaultMotionState_Destroy(const btDefaultMotionState *_this);

/// Destroys a heap-allocated array of `btDefaultMotionState`. Does nothing if the pointer is null.
BULLET_API void btDefaultMotionState_DestroyArray(const btDefaultMotionState *_this);

/// Generated from method `btDefaultMotionState::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btDefaultMotionState *btDefaultMotionState_AssignFromAnother(btDefaultMotionState *_this, Bullet_PassBy _other_pass_by, btDefaultMotionState *_other);

/// Generated from method `btDefaultMotionState::operator new`.
BULLET_API void *Bullet_new_btDefaultMotionState_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btDefaultMotionState::operator delete`.
BULLET_API void Bullet_delete_btDefaultMotionState_void_ptr(void *ptr);

/// Generated from method `btDefaultMotionState::operator new`.
BULLET_API void *Bullet_new_btDefaultMotionState_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btDefaultMotionState::operator delete`.
BULLET_API void Bullet_delete_btDefaultMotionState_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btDefaultMotionState::operator new[]`.
BULLET_API void *Bullet_new_array_btDefaultMotionState_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btDefaultMotionState::operator delete[]`.
BULLET_API void Bullet_delete_array_btDefaultMotionState_void_ptr(void *ptr);

/// Generated from method `btDefaultMotionState::operator new[]`.
BULLET_API void *Bullet_new_array_btDefaultMotionState_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btDefaultMotionState::operator delete[]`.
BULLET_API void Bullet_delete_array_btDefaultMotionState_void_ptr_void_ptr(void *_1, void *_2);

///synchronizes world transform from user to physics
/// Generated from method `btDefaultMotionState::getWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `centerOfMassWorldTrans` can not be null. It is a single object.
BULLET_API void btDefaultMotionState_getWorldTransform(const btDefaultMotionState *_this, btTransform *centerOfMassWorldTrans);

///synchronizes world transform from physics to user
///Bullet only calls the update of worldtransform for active objects
/// Generated from method `btDefaultMotionState::setWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `centerOfMassWorldTrans` can not be null. It is a single object.
BULLET_API void btDefaultMotionState_setWorldTransform(btDefaultMotionState *_this, const btTransform *centerOfMassWorldTrans);

#ifdef __cplusplus
} // extern "C"
#endif
