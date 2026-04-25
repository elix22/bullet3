// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btBroadphaseInterface btBroadphaseInterface; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btBroadphaseInterface.h>`.
typedef struct btDispatcher btDispatcher; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btDispatcher.h>`.
typedef struct btOverlappingPairCache btOverlappingPairCache; // Defined in `#include <bullet/BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


/* Config		*/
typedef enum btDbvtBroadphase_unnamed_enum_at_Users_elialoni_Development_COMPILERS_mrbind_deps_bullet_src_BulletCollision_BroadphaseCollision_btDbvtBroadphase_h_65_2
{
    /* Dynamic set index	*/
    btDbvtBroadphase_unnamed_enum_at_Users_elialoni_Development_COMPILERS_mrbind_deps_bullet_src_BulletCollision_BroadphaseCollision_btDbvtBroadphase_h_65_2_DYNAMIC_SET = 0,
    /* Fixed set index		*/
    btDbvtBroadphase_unnamed_enum_at_Users_elialoni_Development_COMPILERS_mrbind_deps_bullet_src_BulletCollision_BroadphaseCollision_btDbvtBroadphase_h_65_2_FIXED_SET = 1,
    /* Number of stages		*/
    btDbvtBroadphase_unnamed_enum_at_Users_elialoni_Development_COMPILERS_mrbind_deps_bullet_src_BulletCollision_BroadphaseCollision_btDbvtBroadphase_h_65_2_STAGECOUNT = 2,
} btDbvtBroadphase_unnamed_enum_at_Users_elialoni_Development_COMPILERS_mrbind_deps_bullet_src_BulletCollision_BroadphaseCollision_btDbvtBroadphase_h_65_2;

///The btDbvtBroadphase implements a broadphase using two dynamic AABB bounding volume hierarchies/trees (see btDbvt).
///One tree is used for static/non-moving objects, and another tree is used for dynamic objects. Objects can move from one tree to the other.
///This is a very fast broadphase, especially for very dynamic worlds where many objects are moving. Its insert/add and remove of objects is generally faster than the sweep and prune broadphases btAxisSweep3 and bt32BitAxisSweep3.
/// Generated from class `btDbvtBroadphase`.
/// Base classes:
///   Direct: (non-virtual)
///     `btBroadphaseInterface`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btDbvtBroadphase btDbvtBroadphase;

// Pair cache
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_paircache`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btOverlappingPairCache *const *btDbvtBroadphase_Get_m_paircache(const btDbvtBroadphase *_this);

// Pair cache
/// Modifies a member variable of class `btDbvtBroadphase` named `m_paircache`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_paircache`.
/// When this function is called, this object will drop object references it held previously in `m_paircache`.
BULLET_API void btDbvtBroadphase_Set_m_paircache(btDbvtBroadphase *_this, btOverlappingPairCache *value);

// Pair cache
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_paircache`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btOverlappingPairCache **btDbvtBroadphase_GetMutable_m_paircache(btDbvtBroadphase *_this);

// Velocity prediction
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_prediction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btDbvtBroadphase_Get_m_prediction(const btDbvtBroadphase *_this);

// Velocity prediction
/// Modifies a member variable of class `btDbvtBroadphase` named `m_prediction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_prediction`.
BULLET_API void btDbvtBroadphase_Set_m_prediction(btDbvtBroadphase *_this, double value);

// Velocity prediction
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_prediction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btDbvtBroadphase_GetMutable_m_prediction(btDbvtBroadphase *_this);

// Current stage
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_stageCurrent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btDbvtBroadphase_Get_m_stageCurrent(const btDbvtBroadphase *_this);

// Current stage
/// Modifies a member variable of class `btDbvtBroadphase` named `m_stageCurrent`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_stageCurrent`.
BULLET_API void btDbvtBroadphase_Set_m_stageCurrent(btDbvtBroadphase *_this, int value);

// Current stage
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_stageCurrent`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btDbvtBroadphase_GetMutable_m_stageCurrent(btDbvtBroadphase *_this);

// % of fixed updates per frame
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_fupdates`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btDbvtBroadphase_Get_m_fupdates(const btDbvtBroadphase *_this);

// % of fixed updates per frame
/// Modifies a member variable of class `btDbvtBroadphase` named `m_fupdates`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_fupdates`.
BULLET_API void btDbvtBroadphase_Set_m_fupdates(btDbvtBroadphase *_this, int value);

// % of fixed updates per frame
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_fupdates`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btDbvtBroadphase_GetMutable_m_fupdates(btDbvtBroadphase *_this);

// % of dynamic updates per frame
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_dupdates`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btDbvtBroadphase_Get_m_dupdates(const btDbvtBroadphase *_this);

// % of dynamic updates per frame
/// Modifies a member variable of class `btDbvtBroadphase` named `m_dupdates`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_dupdates`.
BULLET_API void btDbvtBroadphase_Set_m_dupdates(btDbvtBroadphase *_this, int value);

// % of dynamic updates per frame
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_dupdates`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btDbvtBroadphase_GetMutable_m_dupdates(btDbvtBroadphase *_this);

// % of cleanup updates per frame
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_cupdates`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btDbvtBroadphase_Get_m_cupdates(const btDbvtBroadphase *_this);

// % of cleanup updates per frame
/// Modifies a member variable of class `btDbvtBroadphase` named `m_cupdates`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_cupdates`.
BULLET_API void btDbvtBroadphase_Set_m_cupdates(btDbvtBroadphase *_this, int value);

// % of cleanup updates per frame
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_cupdates`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btDbvtBroadphase_GetMutable_m_cupdates(btDbvtBroadphase *_this);

// Number of pairs created
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_newpairs`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btDbvtBroadphase_Get_m_newpairs(const btDbvtBroadphase *_this);

// Number of pairs created
/// Modifies a member variable of class `btDbvtBroadphase` named `m_newpairs`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_newpairs`.
BULLET_API void btDbvtBroadphase_Set_m_newpairs(btDbvtBroadphase *_this, int value);

// Number of pairs created
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_newpairs`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btDbvtBroadphase_GetMutable_m_newpairs(btDbvtBroadphase *_this);

// Fixed optimization left
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_fixedleft`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btDbvtBroadphase_Get_m_fixedleft(const btDbvtBroadphase *_this);

// Fixed optimization left
/// Modifies a member variable of class `btDbvtBroadphase` named `m_fixedleft`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_fixedleft`.
BULLET_API void btDbvtBroadphase_Set_m_fixedleft(btDbvtBroadphase *_this, int value);

// Fixed optimization left
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_fixedleft`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btDbvtBroadphase_GetMutable_m_fixedleft(btDbvtBroadphase *_this);

// Number of updates call
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_updates_call`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const unsigned int *btDbvtBroadphase_Get_m_updates_call(const btDbvtBroadphase *_this);

// Number of updates call
/// Modifies a member variable of class `btDbvtBroadphase` named `m_updates_call`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_updates_call`.
/// When this function is called, this object will drop object references it held previously in `m_updates_call`.
BULLET_API void btDbvtBroadphase_Set_m_updates_call(btDbvtBroadphase *_this, unsigned int value);

// Number of updates call
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_updates_call`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API unsigned int *btDbvtBroadphase_GetMutable_m_updates_call(btDbvtBroadphase *_this);

// Number of updates done
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_updates_done`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const unsigned int *btDbvtBroadphase_Get_m_updates_done(const btDbvtBroadphase *_this);

// Number of updates done
/// Modifies a member variable of class `btDbvtBroadphase` named `m_updates_done`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_updates_done`.
/// When this function is called, this object will drop object references it held previously in `m_updates_done`.
BULLET_API void btDbvtBroadphase_Set_m_updates_done(btDbvtBroadphase *_this, unsigned int value);

// Number of updates done
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_updates_done`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API unsigned int *btDbvtBroadphase_GetMutable_m_updates_done(btDbvtBroadphase *_this);

// m_updates_done/m_updates_call
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_updates_ratio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btDbvtBroadphase_Get_m_updates_ratio(const btDbvtBroadphase *_this);

// m_updates_done/m_updates_call
/// Modifies a member variable of class `btDbvtBroadphase` named `m_updates_ratio`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_updates_ratio`.
BULLET_API void btDbvtBroadphase_Set_m_updates_ratio(btDbvtBroadphase *_this, double value);

// m_updates_done/m_updates_call
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_updates_ratio`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btDbvtBroadphase_GetMutable_m_updates_ratio(btDbvtBroadphase *_this);

// Parse id
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_pid`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btDbvtBroadphase_Get_m_pid(const btDbvtBroadphase *_this);

// Parse id
/// Modifies a member variable of class `btDbvtBroadphase` named `m_pid`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_pid`.
BULLET_API void btDbvtBroadphase_Set_m_pid(btDbvtBroadphase *_this, int value);

// Parse id
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_pid`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btDbvtBroadphase_GetMutable_m_pid(btDbvtBroadphase *_this);

// Cleanup index
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_cid`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btDbvtBroadphase_Get_m_cid(const btDbvtBroadphase *_this);

// Cleanup index
/// Modifies a member variable of class `btDbvtBroadphase` named `m_cid`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_cid`.
BULLET_API void btDbvtBroadphase_Set_m_cid(btDbvtBroadphase *_this, int value);

// Cleanup index
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_cid`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btDbvtBroadphase_GetMutable_m_cid(btDbvtBroadphase *_this);

// Gen id
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_gid`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btDbvtBroadphase_Get_m_gid(const btDbvtBroadphase *_this);

// Gen id
/// Modifies a member variable of class `btDbvtBroadphase` named `m_gid`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_gid`.
BULLET_API void btDbvtBroadphase_Set_m_gid(btDbvtBroadphase *_this, int value);

// Gen id
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_gid`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btDbvtBroadphase_GetMutable_m_gid(btDbvtBroadphase *_this);

// Release pair cache on delete
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_releasepaircache`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const bool *btDbvtBroadphase_Get_m_releasepaircache(const btDbvtBroadphase *_this);

// Release pair cache on delete
/// Modifies a member variable of class `btDbvtBroadphase` named `m_releasepaircache`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_releasepaircache`.
BULLET_API void btDbvtBroadphase_Set_m_releasepaircache(btDbvtBroadphase *_this, bool value);

// Release pair cache on delete
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_releasepaircache`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API bool *btDbvtBroadphase_GetMutable_m_releasepaircache(btDbvtBroadphase *_this);

// Defere dynamic/static collision to collide call
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_deferedcollide`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const bool *btDbvtBroadphase_Get_m_deferedcollide(const btDbvtBroadphase *_this);

// Defere dynamic/static collision to collide call
/// Modifies a member variable of class `btDbvtBroadphase` named `m_deferedcollide`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_deferedcollide`.
BULLET_API void btDbvtBroadphase_Set_m_deferedcollide(btDbvtBroadphase *_this, bool value);

// Defere dynamic/static collision to collide call
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_deferedcollide`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API bool *btDbvtBroadphase_GetMutable_m_deferedcollide(btDbvtBroadphase *_this);

// Need to run cleanup?
/// Returns a pointer to a member variable of class `btDbvtBroadphase` named `m_needcleanup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const bool *btDbvtBroadphase_Get_m_needcleanup(const btDbvtBroadphase *_this);

// Need to run cleanup?
/// Modifies a member variable of class `btDbvtBroadphase` named `m_needcleanup`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_needcleanup`.
BULLET_API void btDbvtBroadphase_Set_m_needcleanup(btDbvtBroadphase *_this, bool value);

// Need to run cleanup?
/// Returns a mutable pointer to a member variable of class `btDbvtBroadphase` named `m_needcleanup`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API bool *btDbvtBroadphase_GetMutable_m_needcleanup(btDbvtBroadphase *_this);

/* Methods		*/
/// Generated from constructor `btDbvtBroadphase::btDbvtBroadphase`.
/// Parameter `paircache` defaults to a null pointer in C++.
/// Never returns null. Returns an instance allocated on the heap! Must call `btDbvtBroadphase_Destroy()` to free it when you're done using it.
BULLET_API btDbvtBroadphase *btDbvtBroadphase_Construct(btOverlappingPairCache *paircache);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btDbvtBroadphase_DestroyArray()`.
/// Use `btDbvtBroadphase_OffsetMutablePtr()` and `btDbvtBroadphase_OffsetPtr()` to access the array elements.
BULLET_API btDbvtBroadphase *btDbvtBroadphase_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btDbvtBroadphase *btDbvtBroadphase_OffsetPtr(const btDbvtBroadphase *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btDbvtBroadphase *btDbvtBroadphase_OffsetMutablePtr(btDbvtBroadphase *ptr, ptrdiff_t i);

/// Upcasts an instance of `btDbvtBroadphase` to its base class `btBroadphaseInterface`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btBroadphaseInterface *btDbvtBroadphase_UpcastTo_btBroadphaseInterface(const btDbvtBroadphase *object);

/// Upcasts an instance of `btDbvtBroadphase` to its base class `btBroadphaseInterface`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btBroadphaseInterface *btDbvtBroadphase_MutableUpcastTo_btBroadphaseInterface(btDbvtBroadphase *object);

/// Downcasts an instance of `btBroadphaseInterface` to a derived class `btDbvtBroadphase`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDbvtBroadphase *btDbvtBroadphase_StaticDowncastFrom_btBroadphaseInterface(const btBroadphaseInterface *object);

/// Downcasts an instance of `btBroadphaseInterface` to a derived class `btDbvtBroadphase`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDbvtBroadphase *btDbvtBroadphase_MutableStaticDowncastFrom_btBroadphaseInterface(btBroadphaseInterface *object);

/// Downcasts an instance of `btBroadphaseInterface` to a derived class `btDbvtBroadphase`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btDbvtBroadphase *btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface(const btBroadphaseInterface *object);

/// Downcasts an instance of `btBroadphaseInterface` to a derived class `btDbvtBroadphase`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btDbvtBroadphase *btDbvtBroadphase_MutableDynamicDowncastFrom_btBroadphaseInterface(btBroadphaseInterface *object);

/// Downcasts an instance of `btBroadphaseInterface` to a derived class `btDbvtBroadphase`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btDbvtBroadphase *btDbvtBroadphase_DynamicDowncastFromOrFail_btBroadphaseInterface(const btBroadphaseInterface *object);

/// Downcasts an instance of `btBroadphaseInterface` to a derived class `btDbvtBroadphase`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btDbvtBroadphase *btDbvtBroadphase_MutableDynamicDowncastFromOrFail_btBroadphaseInterface(btBroadphaseInterface *object);

/// Destroys a heap-allocated instance of `btDbvtBroadphase`. Does nothing if the pointer is null.
BULLET_API void btDbvtBroadphase_Destroy(const btDbvtBroadphase *_this);

/// Destroys a heap-allocated array of `btDbvtBroadphase`. Does nothing if the pointer is null.
BULLET_API void btDbvtBroadphase_DestroyArray(const btDbvtBroadphase *_this);

/// Generated from method `btDbvtBroadphase::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btDbvtBroadphase *btDbvtBroadphase_AssignFromAnother(btDbvtBroadphase *_this, Bullet_PassBy _other_pass_by, btDbvtBroadphase *_other);

/// Generated from method `btDbvtBroadphase::collide`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDbvtBroadphase_collide(btDbvtBroadphase *_this, btDispatcher *dispatcher);

/// Generated from method `btDbvtBroadphase::optimize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDbvtBroadphase_optimize(btDbvtBroadphase *_this);

/// Generated from method `btDbvtBroadphase::calculateOverlappingPairs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDbvtBroadphase_calculateOverlappingPairs(btDbvtBroadphase *_this, btDispatcher *dispatcher);

/// Generated from method `btDbvtBroadphase::getOverlappingPairCache`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btOverlappingPairCache *btDbvtBroadphase_getOverlappingPairCache_mut(btDbvtBroadphase *_this);

/// Generated from method `btDbvtBroadphase::getOverlappingPairCache`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btOverlappingPairCache *btDbvtBroadphase_getOverlappingPairCache(const btDbvtBroadphase *_this);

/// Generated from method `btDbvtBroadphase::getBroadphaseAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btDbvtBroadphase_getBroadphaseAabb(const btDbvtBroadphase *_this, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btDbvtBroadphase::printStats`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDbvtBroadphase_printStats(btDbvtBroadphase *_this);

///reset broadphase internal structures, to ensure determinism/reproducability
/// Generated from method `btDbvtBroadphase::resetPool`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDbvtBroadphase_resetPool(btDbvtBroadphase *_this, btDispatcher *dispatcher);

/// Generated from method `btDbvtBroadphase::performDeferredRemoval`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDbvtBroadphase_performDeferredRemoval(btDbvtBroadphase *_this, btDispatcher *dispatcher);

/// Generated from method `btDbvtBroadphase::setVelocityPrediction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btDbvtBroadphase_setVelocityPrediction(btDbvtBroadphase *_this, double prediction);

/// Generated from method `btDbvtBroadphase::getVelocityPrediction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btDbvtBroadphase_getVelocityPrediction(const btDbvtBroadphase *_this);

/// Generated from method `btDbvtBroadphase::benchmark`.
BULLET_API void btDbvtBroadphase_benchmark(btBroadphaseInterface *_1);

#ifdef __cplusplus
} // extern "C"
#endif
