// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btCollisionShape btCollisionShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btCollisionShape.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


typedef enum btCollisionObject_CollisionFlags
{
    btCollisionObject_CollisionFlags_CF_DYNAMIC_OBJECT = 0,
    btCollisionObject_CollisionFlags_CF_STATIC_OBJECT = 1,
    btCollisionObject_CollisionFlags_CF_KINEMATIC_OBJECT = 2,
    btCollisionObject_CollisionFlags_CF_NO_CONTACT_RESPONSE = 4,
    //this allows per-triangle material (friction/restitution)
    btCollisionObject_CollisionFlags_CF_CUSTOM_MATERIAL_CALLBACK = 8,
    btCollisionObject_CollisionFlags_CF_CHARACTER_OBJECT = 16,
    //disable debug drawing
    btCollisionObject_CollisionFlags_CF_DISABLE_VISUALIZE_OBJECT = 32,
    //disable parallel/SPU processing
    btCollisionObject_CollisionFlags_CF_DISABLE_SPU_COLLISION_PROCESSING = 64,
    btCollisionObject_CollisionFlags_CF_HAS_CONTACT_STIFFNESS_DAMPING = 128,
    btCollisionObject_CollisionFlags_CF_HAS_CUSTOM_DEBUG_RENDERING_COLOR = 256,
    btCollisionObject_CollisionFlags_CF_HAS_FRICTION_ANCHOR = 512,
    btCollisionObject_CollisionFlags_CF_HAS_COLLISION_SOUND_TRIGGER = 1024,
} btCollisionObject_CollisionFlags;

typedef enum btCollisionObject_CollisionObjectTypes
{
    btCollisionObject_CollisionObjectTypes_CO_COLLISION_OBJECT = 1,
    btCollisionObject_CollisionObjectTypes_CO_RIGID_BODY = 2,
    ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
    ///It is useful for collision sensors, explosion objects, character controller etc.
    btCollisionObject_CollisionObjectTypes_CO_GHOST_OBJECT = 4,
    ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
    ///It is useful for collision sensors, explosion objects, character controller etc.
    btCollisionObject_CollisionObjectTypes_CO_SOFT_BODY = 8,
    ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
    ///It is useful for collision sensors, explosion objects, character controller etc.
    btCollisionObject_CollisionObjectTypes_CO_HF_FLUID = 16,
    ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
    ///It is useful for collision sensors, explosion objects, character controller etc.
    btCollisionObject_CollisionObjectTypes_CO_USER_TYPE = 32,
    ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
    ///It is useful for collision sensors, explosion objects, character controller etc.
    btCollisionObject_CollisionObjectTypes_CO_FEATHERSTONE_LINK = 64,
} btCollisionObject_CollisionObjectTypes;

typedef enum btCollisionObject_AnisotropicFrictionFlags
{
    btCollisionObject_AnisotropicFrictionFlags_CF_ANISOTROPIC_FRICTION_DISABLED = 0,
    btCollisionObject_AnisotropicFrictionFlags_CF_ANISOTROPIC_FRICTION = 1,
    btCollisionObject_AnisotropicFrictionFlags_CF_ANISOTROPIC_ROLLING_FRICTION = 2,
} btCollisionObject_AnisotropicFrictionFlags;

/// btCollisionObject can be used to manage collision detection objects.
/// btCollisionObject maintains all information that is needed for a collision detection: Shape, Transform and AABB proxy.
/// They can be added to the btCollisionWorld.
/// Generated from class `btCollisionObject`.
/// Derived classes:
///   Direct: (non-virtual)
///     `btRigidBody`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_DefaultConstruct`, `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btCollisionObject btCollisionObject;

/// Constructs an empty (default-constructed) instance.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionObject_Destroy()` to free it when you're done using it.
BULLET_API btCollisionObject *btCollisionObject_DefaultConstruct(void);

/// Constructs an array of empty (default-constructed) instances, of the specified size. Will never return null.
/// The array must be destroyed using `btCollisionObject_DestroyArray()`.
/// Use `btCollisionObject_OffsetMutablePtr()` and `btCollisionObject_OffsetPtr()` to access the array elements.
BULLET_API btCollisionObject *btCollisionObject_DefaultConstructArray(size_t num_elems);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btCollisionObject *btCollisionObject_OffsetPtr(const btCollisionObject *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btCollisionObject *btCollisionObject_OffsetMutablePtr(btCollisionObject *ptr, ptrdiff_t i);

/// Generated from constructor `btCollisionObject::btCollisionObject`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btCollisionObject_Destroy()` to free it when you're done using it.
BULLET_API btCollisionObject *btCollisionObject_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionObject *_other);

/// Destroys a heap-allocated instance of `btCollisionObject`. Does nothing if the pointer is null.
BULLET_API void btCollisionObject_Destroy(const btCollisionObject *_this);

/// Destroys a heap-allocated array of `btCollisionObject`. Does nothing if the pointer is null.
BULLET_API void btCollisionObject_DestroyArray(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btCollisionObject *btCollisionObject_AssignFromAnother(btCollisionObject *_this, Bullet_PassBy _other_pass_by, btCollisionObject *_other);

/// Generated from method `btCollisionObject::operator new`.
BULLET_API void *Bullet_new_btCollisionObject_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btCollisionObject::operator delete`.
BULLET_API void Bullet_delete_btCollisionObject_void_ptr(void *ptr);

/// Generated from method `btCollisionObject::operator new`.
BULLET_API void *Bullet_new_btCollisionObject_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btCollisionObject::operator delete`.
BULLET_API void Bullet_delete_btCollisionObject_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btCollisionObject::operator new[]`.
BULLET_API void *Bullet_new_array_btCollisionObject_unsigned_long(unsigned long sizeInBytes);

/// Generated from method `btCollisionObject::operator delete[]`.
BULLET_API void Bullet_delete_array_btCollisionObject_void_ptr(void *ptr);

/// Generated from method `btCollisionObject::operator new[]`.
BULLET_API void *Bullet_new_array_btCollisionObject_unsigned_long_void_ptr(unsigned long _1, void *ptr);

/// Generated from method `btCollisionObject::operator delete[]`.
BULLET_API void Bullet_delete_array_btCollisionObject_void_ptr_void_ptr(void *_1, void *_2);

/// Generated from method `btCollisionObject::mergesSimulationIslands`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionObject_mergesSimulationIslands(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getAnisotropicFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btCollisionObject_getAnisotropicFriction(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setAnisotropicFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `anisotropicFriction` can not be null. It is a single object.
/// Parameter `frictionMode` has a default argument: `CF_ANISOTROPIC_FRICTION`, pass a null pointer to use it.
BULLET_API void btCollisionObject_setAnisotropicFriction(btCollisionObject *_this, const btVector3 *anisotropicFriction, const int *frictionMode);

/// Generated from method `btCollisionObject::hasAnisotropicFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `frictionMode` has a default argument: `CF_ANISOTROPIC_FRICTION`, pass a null pointer to use it.
BULLET_API bool btCollisionObject_hasAnisotropicFriction(const btCollisionObject *_this, const int *frictionMode);

///the constraint solver can discard solving contacts, if the distance is above this threshold. 0 by default.
///Note that using contacts with positive distance can improve stability. It increases, however, the chance of colliding with degerate contacts, such as 'interior' triangle edges
/// Generated from method `btCollisionObject::setContactProcessingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setContactProcessingThreshold(btCollisionObject *_this, double contactProcessingThreshold);

/// Generated from method `btCollisionObject::getContactProcessingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getContactProcessingThreshold(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::isStaticObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionObject_isStaticObject(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::isKinematicObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionObject_isKinematicObject(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::isStaticOrKinematicObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionObject_isStaticOrKinematicObject(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::hasContactResponse`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionObject_hasContactResponse(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setCollisionShape`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setCollisionShape(btCollisionObject *_this, btCollisionShape *collisionShape);

/// Generated from method `btCollisionObject::getCollisionShape`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btCollisionShape *btCollisionObject_getCollisionShape(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getCollisionShape`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btCollisionShape *btCollisionObject_getCollisionShape_mut(btCollisionObject *_this);

/// Generated from method `btCollisionObject::setIgnoreCollisionCheck`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setIgnoreCollisionCheck(btCollisionObject *_this, const btCollisionObject *co, bool ignoreCollisionCheck);

/// Generated from method `btCollisionObject::getNumObjectsWithoutCollision`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getNumObjectsWithoutCollision(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getObjectWithoutCollision`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btCollisionObject *btCollisionObject_getObjectWithoutCollision(btCollisionObject *_this, int index);

/// Generated from method `btCollisionObject::checkCollideWithOverride`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionObject_checkCollideWithOverride(const btCollisionObject *_this, const btCollisionObject *co);

///Avoid using this internal API call, the extension pointer is used by some Bullet extensions.
///If you need to store your own user pointer, use 'setUserPointer/getUserPointer' instead.
/// Generated from method `btCollisionObject::internalGetExtensionPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btCollisionObject_internalGetExtensionPointer(const btCollisionObject *_this);

///Avoid using this internal API call, the extension pointer is used by some Bullet extensions
///If you need to store your own user pointer, use 'setUserPointer/getUserPointer' instead.
/// Generated from method `btCollisionObject::internalSetExtensionPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_internalSetExtensionPointer(btCollisionObject *_this, void *pointer);

/// Generated from method `btCollisionObject::getActivationState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getActivationState(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setActivationState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setActivationState(const btCollisionObject *_this, int newState);

/// Generated from method `btCollisionObject::setDeactivationTime`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setDeactivationTime(btCollisionObject *_this, double time);

/// Generated from method `btCollisionObject::getDeactivationTime`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getDeactivationTime(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::forceActivationState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_forceActivationState(const btCollisionObject *_this, int newState);

/// Generated from method `btCollisionObject::activate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `forceActivation` has a default argument: `false`, pass a null pointer to use it.
BULLET_API void btCollisionObject_activate(const btCollisionObject *_this, const bool *forceActivation);

/// Generated from method `btCollisionObject::isActive`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionObject_isActive(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setRestitution`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setRestitution(btCollisionObject *_this, double rest);

/// Generated from method `btCollisionObject::getRestitution`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getRestitution(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setFriction(btCollisionObject *_this, double frict);

/// Generated from method `btCollisionObject::getFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getFriction(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setRollingFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setRollingFriction(btCollisionObject *_this, double frict);

/// Generated from method `btCollisionObject::getRollingFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getRollingFriction(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setSpinningFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setSpinningFriction(btCollisionObject *_this, double frict);

/// Generated from method `btCollisionObject::getSpinningFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getSpinningFriction(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setContactStiffnessAndDamping`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setContactStiffnessAndDamping(btCollisionObject *_this, double stiffness, double damping);

/// Generated from method `btCollisionObject::getContactStiffness`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getContactStiffness(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getContactDamping`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getContactDamping(const btCollisionObject *_this);

///reserved for Bullet internal usage
/// Generated from method `btCollisionObject::getInternalType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getInternalType(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btTransform *btCollisionObject_getWorldTransform_mut(btCollisionObject *_this);

/// Generated from method `btCollisionObject::getWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btTransform *btCollisionObject_getWorldTransform(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `worldTrans` can not be null. It is a single object.
BULLET_API void btCollisionObject_setWorldTransform(btCollisionObject *_this, const btTransform *worldTrans);

/// Generated from method `btCollisionObject::getInterpolationWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btTransform *btCollisionObject_getInterpolationWorldTransform(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getInterpolationWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btTransform *btCollisionObject_getInterpolationWorldTransform_mut(btCollisionObject *_this);

/// Generated from method `btCollisionObject::setInterpolationWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
BULLET_API void btCollisionObject_setInterpolationWorldTransform(btCollisionObject *_this, const btTransform *trans);

/// Generated from method `btCollisionObject::setInterpolationLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
BULLET_API void btCollisionObject_setInterpolationLinearVelocity(btCollisionObject *_this, const btVector3 *linvel);

/// Generated from method `btCollisionObject::setInterpolationAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
BULLET_API void btCollisionObject_setInterpolationAngularVelocity(btCollisionObject *_this, const btVector3 *angvel);

/// Generated from method `btCollisionObject::getInterpolationLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btCollisionObject_getInterpolationLinearVelocity(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getInterpolationAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btCollisionObject_getInterpolationAngularVelocity(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getIslandTag`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getIslandTag(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setIslandTag`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setIslandTag(btCollisionObject *_this, int tag);

/// Generated from method `btCollisionObject::getCompanionId`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getCompanionId(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setCompanionId`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setCompanionId(btCollisionObject *_this, int id);

/// Generated from method `btCollisionObject::getWorldArrayIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getWorldArrayIndex(const btCollisionObject *_this);

// only should be called by CollisionWorld
/// Generated from method `btCollisionObject::setWorldArrayIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setWorldArrayIndex(btCollisionObject *_this, int ix);

/// Generated from method `btCollisionObject::getHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getHitFraction(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setHitFraction(btCollisionObject *_this, double hitFraction);

/// Generated from method `btCollisionObject::getCollisionFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getCollisionFlags(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setCollisionFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setCollisionFlags(btCollisionObject *_this, int flags);

///Swept sphere radius (0.0 by default), see btConvexConvexAlgorithm::
/// Generated from method `btCollisionObject::getCcdSweptSphereRadius`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getCcdSweptSphereRadius(const btCollisionObject *_this);

///Swept sphere radius (0.0 by default), see btConvexConvexAlgorithm::
/// Generated from method `btCollisionObject::setCcdSweptSphereRadius`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setCcdSweptSphereRadius(btCollisionObject *_this, double radius);

/// Generated from method `btCollisionObject::getCcdMotionThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getCcdMotionThreshold(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getCcdSquareMotionThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btCollisionObject_getCcdSquareMotionThreshold(const btCollisionObject *_this);

/// Don't do continuous collision detection if the motion (in one step) is less then m_ccdMotionThreshold
/// Generated from method `btCollisionObject::setCcdMotionThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setCcdMotionThreshold(btCollisionObject *_this, double ccdMotionThreshold);

///users can point to their objects, userPointer is not used by Bullet
/// Generated from method `btCollisionObject::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btCollisionObject_getUserPointer(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getUserIndex(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getUserIndex2(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::getUserIndex3`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getUserIndex3(const btCollisionObject *_this);

///users can point to their objects, userPointer is not used by Bullet
/// Generated from method `btCollisionObject::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setUserPointer(btCollisionObject *_this, void *userPointer);

///users can point to their objects, userPointer is not used by Bullet
/// Generated from method `btCollisionObject::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setUserIndex(btCollisionObject *_this, int index);

/// Generated from method `btCollisionObject::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setUserIndex2(btCollisionObject *_this, int index);

/// Generated from method `btCollisionObject::setUserIndex3`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_setUserIndex3(btCollisionObject *_this, int index);

/// Generated from method `btCollisionObject::getUpdateRevisionInternal`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_getUpdateRevisionInternal(const btCollisionObject *_this);

/// Generated from method `btCollisionObject::setCustomDebugColor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `colorRGB` can not be null. It is a single object.
BULLET_API void btCollisionObject_setCustomDebugColor(btCollisionObject *_this, const btVector3 *colorRGB);

/// Generated from method `btCollisionObject::removeCustomDebugColor`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btCollisionObject_removeCustomDebugColor(btCollisionObject *_this);

/// Generated from method `btCollisionObject::getCustomDebugColor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `colorRGB` can not be null. It is a single object.
BULLET_API bool btCollisionObject_getCustomDebugColor(const btCollisionObject *_this, btVector3 *colorRGB);

/// Generated from method `btCollisionObject::checkCollideWith`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btCollisionObject_checkCollideWith(const btCollisionObject *_this, const btCollisionObject *co);

// clang-format on
/// Generated from method `btCollisionObject::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btCollisionObject_calculateSerializeBufferSize(const btCollisionObject *_this);

#ifdef __cplusplus
} // extern "C"
#endif
