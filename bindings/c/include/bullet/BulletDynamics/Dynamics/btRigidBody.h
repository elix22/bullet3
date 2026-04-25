// machine generated, do not edit
#pragma once

#include <common.h>
#include <exports.h>

#include <stdbool.h>
#include <stddef.h>

#ifdef __cplusplus
extern "C" {
#endif

typedef struct btCollisionObject btCollisionObject; // Defined in `#include <bullet/BulletCollision/CollisionDispatch/btCollisionObject.h>`.
typedef struct btCollisionShape btCollisionShape; // Defined in `#include <bullet/BulletCollision/CollisionShapes/btCollisionShape.h>`.
typedef struct btMatrix3x3 btMatrix3x3; // Defined in `#include <bullet/LinearMath/btMatrix3x3.h>`.
typedef struct btMotionState btMotionState; // Defined in `#include <bullet/LinearMath/btMotionState.h>`.
typedef struct btQuaternion btQuaternion; // Defined in `#include <bullet/LinearMath/btQuaternion.h>`.
typedef struct btTransform btTransform; // Defined in `#include <bullet/LinearMath/btTransform.h>`.
typedef struct btVector3 btVector3; // Defined in `#include <bullet/LinearMath/btVector3.h>`.


///The btRigidBodyConstructionInfo structure provides information to create a rigid body. Setting mass to zero creates a fixed (non-dynamic) rigid body.
///For dynamic objects, you can use the collision shape to approximate the local inertia tensor, otherwise use the zero vector (default argument)
///You can use the motion state to synchronize the world transform between physics and graphics objects.
///And if the motion state is provided, the rigid body will initialize its initial world transform from the motion state,
///m_startWorldTransform is only used when you don't provide a motion state.
/// Generated from class `btRigidBody::btRigidBodyConstructionInfo`.
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy`, `Bullet_PassBy_Move` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btRigidBody_btRigidBodyConstructionInfo btRigidBody_btRigidBodyConstructionInfo;

///The btRigidBody is the main class for rigid body objects. It is derived from btCollisionObject, so it keeps a pointer to a btCollisionShape.
///It is recommended for performance and memory use to share btCollisionShape objects whenever possible.
///There are 3 types of rigid bodies:
///- A) Dynamic rigid bodies, with positive mass. Motion is controlled by rigid body dynamics.
///- B) Fixed objects with zero mass. They are not moving (basically collision objects)
///- C) Kinematic objects, which are objects without mass, but the user can move them. There is one-way interaction, and Bullet calculates a velocity based on the timestep and previous and current world transform.
///Bullet automatically deactivates dynamic rigid bodies, when the velocity is below a threshold for a given time.
///Deactivated (sleeping) rigid bodies don't take any processing time, except a minor broadphase collision detection impact (to allow active objects to activate/wake up sleeping objects)
/// Generated from class `btRigidBody`.
/// Base classes:
///   Direct: (non-virtual)
///     `btCollisionObject`
/// Supported `Bullet_PassBy` modes: `Bullet_PassBy_Copy` (and `Bullet_PassBy_DefaultArgument` and `Bullet_PassBy_NoObject` if supported by the callee).
typedef struct btRigidBody btRigidBody;

//for experimental overriding of friction/contact solver func
/// Returns a pointer to a member variable of class `btRigidBody` named `m_contactSolverType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btRigidBody_Get_m_contactSolverType(const btRigidBody *_this);

//for experimental overriding of friction/contact solver func
/// Modifies a member variable of class `btRigidBody` named `m_contactSolverType`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_contactSolverType`.
BULLET_API void btRigidBody_Set_m_contactSolverType(btRigidBody *_this, int value);

//for experimental overriding of friction/contact solver func
/// Returns a mutable pointer to a member variable of class `btRigidBody` named `m_contactSolverType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btRigidBody_GetMutable_m_contactSolverType(btRigidBody *_this);

/// Returns a pointer to a member variable of class `btRigidBody` named `m_frictionSolverType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const int *btRigidBody_Get_m_frictionSolverType(const btRigidBody *_this);

/// Modifies a member variable of class `btRigidBody` named `m_frictionSolverType`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_frictionSolverType`.
BULLET_API void btRigidBody_Set_m_frictionSolverType(btRigidBody *_this, int value);

/// Returns a mutable pointer to a member variable of class `btRigidBody` named `m_frictionSolverType`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API int *btRigidBody_GetMutable_m_frictionSolverType(btRigidBody *_this);

/// Generated from constructor `btRigidBody::btRigidBody`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btRigidBody_Destroy()` to free it when you're done using it.
BULLET_API btRigidBody *btRigidBody_ConstructFromAnother(Bullet_PassBy _other_pass_by, btRigidBody *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btRigidBody *btRigidBody_OffsetPtr(const btRigidBody *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btRigidBody *btRigidBody_OffsetMutablePtr(btRigidBody *ptr, ptrdiff_t i);

/// Upcasts an instance of `btRigidBody` to its base class `btCollisionObject`.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btCollisionObject *btRigidBody_UpcastTo_btCollisionObject(const btRigidBody *object);

/// Upcasts an instance of `btRigidBody` to its base class `btCollisionObject`.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btCollisionObject *btRigidBody_MutableUpcastTo_btCollisionObject(btRigidBody *object);

/// Downcasts an instance of `btCollisionObject` to a derived class `btRigidBody`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btRigidBody *btRigidBody_StaticDowncastFrom_btCollisionObject(const btCollisionObject *object);

/// Downcasts an instance of `btCollisionObject` to a derived class `btRigidBody`.
/// This is a static downcast, it trusts the programmer that the target type is correct. Results in UB and returns an invalid pointer otherwise.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btRigidBody *btRigidBody_MutableStaticDowncastFrom_btCollisionObject(btCollisionObject *object);

/// Downcasts an instance of `btCollisionObject` to a derived class `btRigidBody`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// This version is acting on mutable pointers.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API const btRigidBody *btRigidBody_DynamicDowncastFrom_btCollisionObject(const btCollisionObject *object);

/// Downcasts an instance of `btCollisionObject` to a derived class `btRigidBody`.
/// This is a dynamic downcast, it checks the type before casting. This version will return zero if the target type is wrong.
/// The reference to the parameter `object` might be preserved in the return value.
BULLET_API btRigidBody *btRigidBody_MutableDynamicDowncastFrom_btCollisionObject(btCollisionObject *object);

/// Downcasts an instance of `btCollisionObject` to a derived class `btRigidBody`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// This version is acting on mutable pointers.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btRigidBody *btRigidBody_DynamicDowncastFromOrFail_btCollisionObject(const btCollisionObject *object);

/// Downcasts an instance of `btCollisionObject` to a derived class `btRigidBody`.
/// This is a dynamic downcast, it checks the type before casting. This version will throw if the target type is wrong.
/// Parameter `object` can not be null. It is a single object.
/// The reference to the parameter `object` might be preserved in the return value.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API btRigidBody *btRigidBody_MutableDynamicDowncastFromOrFail_btCollisionObject(btCollisionObject *object);

///btRigidBody constructor using construction info
/// Generated from constructor `btRigidBody::btRigidBody`.
/// Parameter `constructionInfo` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btRigidBody_Destroy()` to free it when you're done using it.
BULLET_API btRigidBody *btRigidBody_Construct_1(const btRigidBody_btRigidBodyConstructionInfo *constructionInfo);

///btRigidBody constructor for backwards compatibility.
///To specify friction (etc) during rigid body construction, please use the other constructor (using btRigidBodyConstructionInfo)
/// Generated from constructor `btRigidBody::btRigidBody`.
/// Parameter `localInertia` is a single object.
/// Parameter `localInertia` has a default argument: `btVector3(0, 0, 0)`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `btRigidBody_Destroy()` to free it when you're done using it.
BULLET_API btRigidBody *btRigidBody_Construct_4(double mass, btMotionState *motionState, btCollisionShape *collisionShape, const btVector3 *localInertia);

/// Destroys a heap-allocated instance of `btRigidBody`. Does nothing if the pointer is null.
BULLET_API void btRigidBody_Destroy(const btRigidBody *_this);

/// Destroys a heap-allocated array of `btRigidBody`. Does nothing if the pointer is null.
BULLET_API void btRigidBody_DestroyArray(const btRigidBody *_this);

/// Generated from method `btRigidBody::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btRigidBody *btRigidBody_AssignFromAnother(btRigidBody *_this, Bullet_PassBy _other_pass_by, btRigidBody *_other);

/// Generated from method `btRigidBody::proceedToTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `newTrans` can not be null. It is a single object.
BULLET_API void btRigidBody_proceedToTransform(btRigidBody *_this, const btTransform *newTrans);

///to keep collision detection and dynamics separate we don't store a rigidbody pointer
///but a rigidbody is derived from btCollisionObject, so we can safely perform an upcast
/// Generated from method `btRigidBody::upcast`.
BULLET_API const btRigidBody *btRigidBody_upcast_const_btCollisionObject_ptr(const btCollisionObject *colObj);

/// Generated from method `btRigidBody::upcast`.
BULLET_API btRigidBody *btRigidBody_upcast_btCollisionObject_ptr(btCollisionObject *colObj);

/// continuous collision detection needs prediction
/// Generated from method `btRigidBody::predictIntegratedTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `predictedTransform` can not be null. It is a single object.
BULLET_API void btRigidBody_predictIntegratedTransform(btRigidBody *_this, double step, btTransform *predictedTransform);

/// Generated from method `btRigidBody::saveKinematicState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_saveKinematicState(btRigidBody *_this, double step);

/// Generated from method `btRigidBody::applyGravity`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_applyGravity(btRigidBody *_this);

/// Generated from method `btRigidBody::clearGravity`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_clearGravity(btRigidBody *_this);

/// Generated from method `btRigidBody::setGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `acceleration` can not be null. It is a single object.
BULLET_API void btRigidBody_setGravity(btRigidBody *_this, const btVector3 *acceleration);

/// Generated from method `btRigidBody::getGravity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getGravity(const btRigidBody *_this);

/// Generated from method `btRigidBody::setDamping`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setDamping(btRigidBody *_this, double lin_damping, double ang_damping);

/// Generated from method `btRigidBody::getLinearDamping`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getLinearDamping(const btRigidBody *_this);

/// Generated from method `btRigidBody::getAngularDamping`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getAngularDamping(const btRigidBody *_this);

/// Generated from method `btRigidBody::getLinearSleepingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getLinearSleepingThreshold(const btRigidBody *_this);

/// Generated from method `btRigidBody::getAngularSleepingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getAngularSleepingThreshold(const btRigidBody *_this);

/// Generated from method `btRigidBody::applyDamping`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_applyDamping(btRigidBody *_this, double timeStep);

/// Generated from method `btRigidBody::getCollisionShape`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btCollisionShape *btRigidBody_getCollisionShape(const btRigidBody *_this);

/// Generated from method `btRigidBody::getCollisionShape`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btCollisionShape *btRigidBody_getCollisionShape_mut(btRigidBody *_this);

/// Generated from method `btRigidBody::setMassProps`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `inertia` can not be null. It is a single object.
BULLET_API void btRigidBody_setMassProps(btRigidBody *_this, double mass, const btVector3 *inertia);

/// Generated from method `btRigidBody::getLinearFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getLinearFactor(const btRigidBody *_this);

/// Generated from method `btRigidBody::setLinearFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `linearFactor` can not be null. It is a single object.
BULLET_API void btRigidBody_setLinearFactor(btRigidBody *_this, const btVector3 *linearFactor);

/// Generated from method `btRigidBody::getInvMass`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getInvMass(const btRigidBody *_this);

/// Generated from method `btRigidBody::getMass`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getMass(const btRigidBody *_this);

/// Generated from method `btRigidBody::getInvInertiaTensorWorld`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btMatrix3x3 *btRigidBody_getInvInertiaTensorWorld(const btRigidBody *_this);

/// Generated from method `btRigidBody::integrateVelocities`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_integrateVelocities(btRigidBody *_this, double step);

/// Generated from method `btRigidBody::setCenterOfMassTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `xform` can not be null. It is a single object.
BULLET_API void btRigidBody_setCenterOfMassTransform(btRigidBody *_this, const btTransform *xform);

/// Generated from method `btRigidBody::applyCentralForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `force` can not be null. It is a single object.
BULLET_API void btRigidBody_applyCentralForce(btRigidBody *_this, const btVector3 *force);

/// Generated from method `btRigidBody::getTotalForce`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getTotalForce(const btRigidBody *_this);

/// Generated from method `btRigidBody::getTotalTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getTotalTorque(const btRigidBody *_this);

/// Generated from method `btRigidBody::getInvInertiaDiagLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getInvInertiaDiagLocal(const btRigidBody *_this);

/// Generated from method `btRigidBody::setInvInertiaDiagLocal`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `diagInvInertia` can not be null. It is a single object.
BULLET_API void btRigidBody_setInvInertiaDiagLocal(btRigidBody *_this, const btVector3 *diagInvInertia);

/// Generated from method `btRigidBody::setSleepingThresholds`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setSleepingThresholds(btRigidBody *_this, double linear, double angular);

/// Generated from method `btRigidBody::applyTorque`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `torque` can not be null. It is a single object.
BULLET_API void btRigidBody_applyTorque(btRigidBody *_this, const btVector3 *torque);

/// Generated from method `btRigidBody::applyForce`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `force` can not be null. It is a single object.
/// Parameter `rel_pos` can not be null. It is a single object.
BULLET_API void btRigidBody_applyForce(btRigidBody *_this, const btVector3 *force, const btVector3 *rel_pos);

/// Generated from method `btRigidBody::applyCentralImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `impulse` can not be null. It is a single object.
BULLET_API void btRigidBody_applyCentralImpulse(btRigidBody *_this, const btVector3 *impulse);

/// Generated from method `btRigidBody::applyTorqueImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `torque` can not be null. It is a single object.
BULLET_API void btRigidBody_applyTorqueImpulse(btRigidBody *_this, const btVector3 *torque);

/// Generated from method `btRigidBody::applyImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `impulse` can not be null. It is a single object.
/// Parameter `rel_pos` can not be null. It is a single object.
BULLET_API void btRigidBody_applyImpulse(btRigidBody *_this, const btVector3 *impulse, const btVector3 *rel_pos);

/// Generated from method `btRigidBody::applyPushImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `impulse` can not be null. It is a single object.
/// Parameter `rel_pos` can not be null. It is a single object.
BULLET_API void btRigidBody_applyPushImpulse(btRigidBody *_this, const btVector3 *impulse, const btVector3 *rel_pos);

/// Generated from method `btRigidBody::getPushVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btRigidBody_getPushVelocity(const btRigidBody *_this);

/// Generated from method `btRigidBody::getTurnVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btRigidBody_getTurnVelocity(const btRigidBody *_this);

/// Generated from method `btRigidBody::setPushVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API void btRigidBody_setPushVelocity(btRigidBody *_this, const btVector3 *v);

/// Generated from method `btRigidBody::setTurnVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API void btRigidBody_setTurnVelocity(btRigidBody *_this, const btVector3 *v);

/// Generated from method `btRigidBody::applyCentralPushImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `impulse` can not be null. It is a single object.
BULLET_API void btRigidBody_applyCentralPushImpulse(btRigidBody *_this, const btVector3 *impulse);

/// Generated from method `btRigidBody::applyTorqueTurnImpulse`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `torque` can not be null. It is a single object.
BULLET_API void btRigidBody_applyTorqueTurnImpulse(btRigidBody *_this, const btVector3 *torque);

/// Generated from method `btRigidBody::clearForces`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_clearForces(btRigidBody *_this);

/// Generated from method `btRigidBody::updateInertiaTensor`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_updateInertiaTensor(btRigidBody *_this);

/// Generated from method `btRigidBody::getCenterOfMassPosition`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getCenterOfMassPosition(const btRigidBody *_this);

/// Generated from method `btRigidBody::getOrientation`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btQuaternion_Destroy()` to free it when you're done using it.
BULLET_API btQuaternion *btRigidBody_getOrientation(const btRigidBody *_this);

/// Generated from method `btRigidBody::getCenterOfMassTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btTransform *btRigidBody_getCenterOfMassTransform(const btRigidBody *_this);

/// Generated from method `btRigidBody::getLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getLinearVelocity(const btRigidBody *_this);

/// Generated from method `btRigidBody::getAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getAngularVelocity(const btRigidBody *_this);

/// Generated from method `btRigidBody::setLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `lin_vel` can not be null. It is a single object.
BULLET_API void btRigidBody_setLinearVelocity(btRigidBody *_this, const btVector3 *lin_vel);

/// Generated from method `btRigidBody::setAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `ang_vel` can not be null. It is a single object.
BULLET_API void btRigidBody_setAngularVelocity(btRigidBody *_this, const btVector3 *ang_vel);

/// Generated from method `btRigidBody::getVelocityInLocalPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rel_pos` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btRigidBody_getVelocityInLocalPoint(const btRigidBody *_this, const btVector3 *rel_pos);

/// Generated from method `btRigidBody::getPushVelocityInLocalPoint`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `rel_pos` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btRigidBody_getPushVelocityInLocalPoint(const btRigidBody *_this, const btVector3 *rel_pos);

/// Generated from method `btRigidBody::translate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `v` can not be null. It is a single object.
BULLET_API void btRigidBody_translate(btRigidBody *_this, const btVector3 *v);

/// Generated from method `btRigidBody::getAabb`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `aabbMin` can not be null. It is a single object.
/// Parameter `aabbMax` can not be null. It is a single object.
BULLET_API void btRigidBody_getAabb(const btRigidBody *_this, btVector3 *aabbMin, btVector3 *aabbMax);

/// Generated from method `btRigidBody::computeImpulseDenominator`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `pos` can not be null. It is a single object.
/// Parameter `normal` can not be null. It is a single object.
BULLET_API double btRigidBody_computeImpulseDenominator(const btRigidBody *_this, const btVector3 *pos, const btVector3 *normal);

/// Generated from method `btRigidBody::computeAngularImpulseDenominator`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `axis` can not be null. It is a single object.
BULLET_API double btRigidBody_computeAngularImpulseDenominator(const btRigidBody *_this, const btVector3 *axis);

/// Generated from method `btRigidBody::updateDeactivation`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_updateDeactivation(btRigidBody *_this, double timeStep);

/// Generated from method `btRigidBody::wantsSleeping`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_wantsSleeping(btRigidBody *_this);

//btMotionState allows to automatic synchronize the world transform for active objects
/// Generated from method `btRigidBody::getMotionState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API btMotionState *btRigidBody_getMotionState_mut(btRigidBody *_this);

/// Generated from method `btRigidBody::getMotionState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btMotionState *btRigidBody_getMotionState(const btRigidBody *_this);

/// Generated from method `btRigidBody::setMotionState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setMotionState(btRigidBody *_this, btMotionState *motionState);

/// Generated from method `btRigidBody::setAngularFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `angFac` can not be null. It is a single object.
BULLET_API void btRigidBody_setAngularFactor_btVector3(btRigidBody *_this, const btVector3 *angFac);

/// Generated from method `btRigidBody::setAngularFactor`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setAngularFactor_double(btRigidBody *_this, double angFac);

/// Generated from method `btRigidBody::getAngularFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getAngularFactor(const btRigidBody *_this);

//is this rigidbody added to a btCollisionWorld/btDynamicsWorld/btBroadphase?
/// Generated from method `btRigidBody::isInWorld`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_isInWorld(const btRigidBody *_this);

/// Generated from method `btRigidBody::getNumConstraintRefs`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getNumConstraintRefs(const btRigidBody *_this);

/// Generated from method `btRigidBody::setFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setFlags(btRigidBody *_this, int flags);

/// Generated from method `btRigidBody::getFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getFlags(const btRigidBody *_this);

///perform implicit force computation in world space
/// Generated from method `btRigidBody::computeGyroscopicImpulseImplicit_World`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btRigidBody_computeGyroscopicImpulseImplicit_World(const btRigidBody *_this, double dt);

///perform implicit force computation in body space (inertial frame)
/// Generated from method `btRigidBody::computeGyroscopicImpulseImplicit_Body`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btRigidBody_computeGyroscopicImpulseImplicit_Body(const btRigidBody *_this, double step);

///explicit version is best avoided, it gains energy
/// Generated from method `btRigidBody::computeGyroscopicForceExplicit`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btRigidBody_computeGyroscopicForceExplicit(const btRigidBody *_this, double maxGyroscopicForce);

/// Generated from method `btRigidBody::getLocalInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btVector3_Destroy()` to free it when you're done using it.
BULLET_API btVector3 *btRigidBody_getLocalInertia(const btRigidBody *_this);

///////////////////////////////////////////////
/// Generated from method `btRigidBody::calculateSerializeBufferSize`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_calculateSerializeBufferSize(const btRigidBody *_this);

/// Generated from method `btRigidBody::mergesSimulationIslands`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_mergesSimulationIslands(const btRigidBody *_this);

/// Generated from method `btRigidBody::getAnisotropicFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getAnisotropicFriction(const btRigidBody *_this);

/// Generated from method `btRigidBody::setAnisotropicFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `anisotropicFriction` can not be null. It is a single object.
/// Parameter `frictionMode` has a default argument: `CF_ANISOTROPIC_FRICTION`, pass a null pointer to use it.
BULLET_API void btRigidBody_setAnisotropicFriction(btRigidBody *_this, const btVector3 *anisotropicFriction, const int *frictionMode);

/// Generated from method `btRigidBody::hasAnisotropicFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `frictionMode` has a default argument: `CF_ANISOTROPIC_FRICTION`, pass a null pointer to use it.
BULLET_API bool btRigidBody_hasAnisotropicFriction(const btRigidBody *_this, const int *frictionMode);

///the constraint solver can discard solving contacts, if the distance is above this threshold. 0 by default.
///Note that using contacts with positive distance can improve stability. It increases, however, the chance of colliding with degerate contacts, such as 'interior' triangle edges
/// Generated from method `btRigidBody::setContactProcessingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setContactProcessingThreshold(btRigidBody *_this, double contactProcessingThreshold);

/// Generated from method `btRigidBody::getContactProcessingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getContactProcessingThreshold(const btRigidBody *_this);

/// Generated from method `btRigidBody::isStaticObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_isStaticObject(const btRigidBody *_this);

/// Generated from method `btRigidBody::isKinematicObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_isKinematicObject(const btRigidBody *_this);

/// Generated from method `btRigidBody::isStaticOrKinematicObject`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_isStaticOrKinematicObject(const btRigidBody *_this);

/// Generated from method `btRigidBody::hasContactResponse`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_hasContactResponse(const btRigidBody *_this);

/// Generated from method `btRigidBody::setCollisionShape`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setCollisionShape(btRigidBody *_this, btCollisionShape *collisionShape);

/// Generated from method `btRigidBody::setIgnoreCollisionCheck`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setIgnoreCollisionCheck(btRigidBody *_this, const btCollisionObject *co, bool ignoreCollisionCheck);

/// Generated from method `btRigidBody::getNumObjectsWithoutCollision`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getNumObjectsWithoutCollision(const btRigidBody *_this);

/// Generated from method `btRigidBody::getObjectWithoutCollision`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API const btCollisionObject *btRigidBody_getObjectWithoutCollision(btRigidBody *_this, int index);

/// Generated from method `btRigidBody::checkCollideWithOverride`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_checkCollideWithOverride(const btRigidBody *_this, const btCollisionObject *co);

///Avoid using this internal API call, the extension pointer is used by some Bullet extensions.
///If you need to store your own user pointer, use 'setUserPointer/getUserPointer' instead.
/// Generated from method `btRigidBody::internalGetExtensionPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btRigidBody_internalGetExtensionPointer(const btRigidBody *_this);

///Avoid using this internal API call, the extension pointer is used by some Bullet extensions
///If you need to store your own user pointer, use 'setUserPointer/getUserPointer' instead.
/// Generated from method `btRigidBody::internalSetExtensionPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_internalSetExtensionPointer(btRigidBody *_this, void *pointer);

/// Generated from method `btRigidBody::getActivationState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getActivationState(const btRigidBody *_this);

/// Generated from method `btRigidBody::setActivationState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setActivationState(const btRigidBody *_this, int newState);

/// Generated from method `btRigidBody::setDeactivationTime`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setDeactivationTime(btRigidBody *_this, double time);

/// Generated from method `btRigidBody::getDeactivationTime`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getDeactivationTime(const btRigidBody *_this);

/// Generated from method `btRigidBody::forceActivationState`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_forceActivationState(const btRigidBody *_this, int newState);

/// Generated from method `btRigidBody::activate`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `forceActivation` has a default argument: `false`, pass a null pointer to use it.
BULLET_API void btRigidBody_activate(const btRigidBody *_this, const bool *forceActivation);

/// Generated from method `btRigidBody::isActive`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_isActive(const btRigidBody *_this);

/// Generated from method `btRigidBody::setRestitution`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setRestitution(btRigidBody *_this, double rest);

/// Generated from method `btRigidBody::getRestitution`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getRestitution(const btRigidBody *_this);

/// Generated from method `btRigidBody::setFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setFriction(btRigidBody *_this, double frict);

/// Generated from method `btRigidBody::getFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getFriction(const btRigidBody *_this);

/// Generated from method `btRigidBody::setRollingFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setRollingFriction(btRigidBody *_this, double frict);

/// Generated from method `btRigidBody::getRollingFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getRollingFriction(const btRigidBody *_this);

/// Generated from method `btRigidBody::setSpinningFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setSpinningFriction(btRigidBody *_this, double frict);

/// Generated from method `btRigidBody::getSpinningFriction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getSpinningFriction(const btRigidBody *_this);

/// Generated from method `btRigidBody::setContactStiffnessAndDamping`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setContactStiffnessAndDamping(btRigidBody *_this, double stiffness, double damping);

/// Generated from method `btRigidBody::getContactStiffness`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getContactStiffness(const btRigidBody *_this);

/// Generated from method `btRigidBody::getContactDamping`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getContactDamping(const btRigidBody *_this);

///reserved for Bullet internal usage
/// Generated from method `btRigidBody::getInternalType`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getInternalType(const btRigidBody *_this);

/// Generated from method `btRigidBody::setWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `worldTrans` can not be null. It is a single object.
BULLET_API void btRigidBody_setWorldTransform(btRigidBody *_this, const btTransform *worldTrans);

/// Generated from method `btRigidBody::setInterpolationWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `trans` can not be null. It is a single object.
BULLET_API void btRigidBody_setInterpolationWorldTransform(btRigidBody *_this, const btTransform *trans);

/// Generated from method `btRigidBody::setInterpolationLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `linvel` can not be null. It is a single object.
BULLET_API void btRigidBody_setInterpolationLinearVelocity(btRigidBody *_this, const btVector3 *linvel);

/// Generated from method `btRigidBody::setInterpolationAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `angvel` can not be null. It is a single object.
BULLET_API void btRigidBody_setInterpolationAngularVelocity(btRigidBody *_this, const btVector3 *angvel);

/// Generated from method `btRigidBody::getInterpolationLinearVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getInterpolationLinearVelocity(const btRigidBody *_this);

/// Generated from method `btRigidBody::getInterpolationAngularVelocity`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
BULLET_API const btVector3 *btRigidBody_getInterpolationAngularVelocity(const btRigidBody *_this);

/// Generated from method `btRigidBody::getIslandTag`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getIslandTag(const btRigidBody *_this);

/// Generated from method `btRigidBody::setIslandTag`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setIslandTag(btRigidBody *_this, int tag);

/// Generated from method `btRigidBody::getCompanionId`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getCompanionId(const btRigidBody *_this);

/// Generated from method `btRigidBody::setCompanionId`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setCompanionId(btRigidBody *_this, int id);

/// Generated from method `btRigidBody::getWorldArrayIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getWorldArrayIndex(const btRigidBody *_this);

// only should be called by CollisionWorld
/// Generated from method `btRigidBody::setWorldArrayIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setWorldArrayIndex(btRigidBody *_this, int ix);

/// Generated from method `btRigidBody::getHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getHitFraction(const btRigidBody *_this);

/// Generated from method `btRigidBody::setHitFraction`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setHitFraction(btRigidBody *_this, double hitFraction);

/// Generated from method `btRigidBody::getCollisionFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getCollisionFlags(const btRigidBody *_this);

/// Generated from method `btRigidBody::setCollisionFlags`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setCollisionFlags(btRigidBody *_this, int flags);

///Swept sphere radius (0.0 by default), see btConvexConvexAlgorithm::
/// Generated from method `btRigidBody::getCcdSweptSphereRadius`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getCcdSweptSphereRadius(const btRigidBody *_this);

///Swept sphere radius (0.0 by default), see btConvexConvexAlgorithm::
/// Generated from method `btRigidBody::setCcdSweptSphereRadius`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setCcdSweptSphereRadius(btRigidBody *_this, double radius);

/// Generated from method `btRigidBody::getCcdMotionThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getCcdMotionThreshold(const btRigidBody *_this);

/// Generated from method `btRigidBody::getCcdSquareMotionThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API double btRigidBody_getCcdSquareMotionThreshold(const btRigidBody *_this);

/// Don't do continuous collision detection if the motion (in one step) is less then m_ccdMotionThreshold
/// Generated from method `btRigidBody::setCcdMotionThreshold`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setCcdMotionThreshold(btRigidBody *_this, double ccdMotionThreshold);

///users can point to their objects, userPointer is not used by Bullet
/// Generated from method `btRigidBody::getUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void *btRigidBody_getUserPointer(const btRigidBody *_this);

/// Generated from method `btRigidBody::getUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getUserIndex(const btRigidBody *_this);

/// Generated from method `btRigidBody::getUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getUserIndex2(const btRigidBody *_this);

/// Generated from method `btRigidBody::getUserIndex3`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getUserIndex3(const btRigidBody *_this);

///users can point to their objects, userPointer is not used by Bullet
/// Generated from method `btRigidBody::setUserPointer`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setUserPointer(btRigidBody *_this, void *userPointer);

///users can point to their objects, userPointer is not used by Bullet
/// Generated from method `btRigidBody::setUserIndex`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setUserIndex(btRigidBody *_this, int index);

/// Generated from method `btRigidBody::setUserIndex2`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setUserIndex2(btRigidBody *_this, int index);

/// Generated from method `btRigidBody::setUserIndex3`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_setUserIndex3(btRigidBody *_this, int index);

/// Generated from method `btRigidBody::getUpdateRevisionInternal`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API int btRigidBody_getUpdateRevisionInternal(const btRigidBody *_this);

/// Generated from method `btRigidBody::setCustomDebugColor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `colorRGB` can not be null. It is a single object.
BULLET_API void btRigidBody_setCustomDebugColor(btRigidBody *_this, const btVector3 *colorRGB);

/// Generated from method `btRigidBody::removeCustomDebugColor`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API void btRigidBody_removeCustomDebugColor(btRigidBody *_this);

/// Generated from method `btRigidBody::getCustomDebugColor`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `colorRGB` can not be null. It is a single object.
BULLET_API bool btRigidBody_getCustomDebugColor(const btRigidBody *_this, btVector3 *colorRGB);

/// Generated from method `btRigidBody::checkCollideWith`.
/// Parameter `_this` can not be null. It is a single object.
BULLET_API bool btRigidBody_checkCollideWith(const btRigidBody *_this, const btCollisionObject *co);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_mass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_mass(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_mass`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_mass`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_mass(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_mass`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_mass(btRigidBody_btRigidBodyConstructionInfo *_this);

///When a motionState is provided, the rigid body will initialize its world transform from the motion state
///In this case, m_startWorldTransform is ignored.
/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_motionState`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btMotionState *const *btRigidBody_btRigidBodyConstructionInfo_Get_m_motionState(const btRigidBody_btRigidBodyConstructionInfo *_this);

///When a motionState is provided, the rigid body will initialize its world transform from the motion state
///In this case, m_startWorldTransform is ignored.
/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_motionState`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_motionState`.
/// When this function is called, this object will drop object references it held previously in `m_motionState`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_motionState(btRigidBody_btRigidBodyConstructionInfo *_this, btMotionState *value);

///When a motionState is provided, the rigid body will initialize its world transform from the motion state
///In this case, m_startWorldTransform is ignored.
/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_motionState`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btMotionState **btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_motionState(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_startWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btTransform *btRigidBody_btRigidBodyConstructionInfo_Get_m_startWorldTransform(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_startWorldTransform`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btTransform *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_startWorldTransform(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_collisionShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btCollisionShape *const *btRigidBody_btRigidBodyConstructionInfo_Get_m_collisionShape(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_collisionShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_collisionShape`.
/// When this function is called, this object will drop object references it held previously in `m_collisionShape`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_collisionShape(btRigidBody_btRigidBodyConstructionInfo *_this, btCollisionShape *value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_collisionShape`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btCollisionShape **btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_collisionShape(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_localInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const btVector3 *btRigidBody_btRigidBodyConstructionInfo_Get_m_localInertia(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_localInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// Parameter `value` can not be null. It is a single object.
/// The reference to the parameter `value` might be preserved in this object in element `m_localInertia`.
/// When this function is called, this object will drop object references it held previously in `m_localInertia`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_localInertia(btRigidBody_btRigidBodyConstructionInfo *_this, const btVector3 *value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_localInertia`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API btVector3 *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_localInertia(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_linearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_linearDamping(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_linearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_linearDamping`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_linearDamping(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_linearDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearDamping(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_angularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_angularDamping(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_angularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_angularDamping`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_angularDamping(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_angularDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularDamping(btRigidBody_btRigidBodyConstructionInfo *_this);

///best simulation results when friction is non-zero
/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_friction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_friction(const btRigidBody_btRigidBodyConstructionInfo *_this);

///best simulation results when friction is non-zero
/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_friction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_friction`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_friction(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

///best simulation results when friction is non-zero
/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_friction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_friction(btRigidBody_btRigidBodyConstructionInfo *_this);

///the m_rollingFriction prevents rounded shapes, such as spheres, cylinders and capsules from rolling forever.
///See Bullet/Demos/RollingFrictionDemo for usage
/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_rollingFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_rollingFriction(const btRigidBody_btRigidBodyConstructionInfo *_this);

///the m_rollingFriction prevents rounded shapes, such as spheres, cylinders and capsules from rolling forever.
///See Bullet/Demos/RollingFrictionDemo for usage
/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_rollingFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_rollingFriction`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_rollingFriction(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

///the m_rollingFriction prevents rounded shapes, such as spheres, cylinders and capsules from rolling forever.
///See Bullet/Demos/RollingFrictionDemo for usage
/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_rollingFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_rollingFriction(btRigidBody_btRigidBodyConstructionInfo *_this);

//torsional friction around contact normal
/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_spinningFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_spinningFriction(const btRigidBody_btRigidBodyConstructionInfo *_this);

//torsional friction around contact normal
/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_spinningFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_spinningFriction`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_spinningFriction(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

//torsional friction around contact normal
/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_spinningFriction`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_spinningFriction(btRigidBody_btRigidBodyConstructionInfo *_this);

///best simulation results using zero restitution.
/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_restitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_restitution(const btRigidBody_btRigidBodyConstructionInfo *_this);

///best simulation results using zero restitution.
/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_restitution`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_restitution`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_restitution(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

///best simulation results using zero restitution.
/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_restitution`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_restitution(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_linearSleepingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_linearSleepingThreshold(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_linearSleepingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_linearSleepingThreshold`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_linearSleepingThreshold(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_linearSleepingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearSleepingThreshold(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_angularSleepingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_angularSleepingThreshold(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_angularSleepingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_angularSleepingThreshold`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_angularSleepingThreshold(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_angularSleepingThreshold`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularSleepingThreshold(btRigidBody_btRigidBodyConstructionInfo *_this);

//Additional damping can help avoiding lowpass jitter motion, help stability for ragdolls etc.
//Such damping is undesirable, so once the overall simulation quality of the rigid body dynamics system has improved, this should become obsolete
/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const bool *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDamping(const btRigidBody_btRigidBodyConstructionInfo *_this);

//Additional damping can help avoiding lowpass jitter motion, help stability for ragdolls etc.
//Such damping is undesirable, so once the overall simulation quality of the rigid body dynamics system has improved, this should become obsolete
/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_additionalDamping`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalDamping(btRigidBody_btRigidBodyConstructionInfo *_this, bool value);

//Additional damping can help avoiding lowpass jitter motion, help stability for ragdolls etc.
//Such damping is undesirable, so once the overall simulation quality of the rigid body dynamics system has improved, this should become obsolete
/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalDamping`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API bool *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDamping(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalDampingFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDampingFactor(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalDampingFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_additionalDampingFactor`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalDampingFactor(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalDampingFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDampingFactor(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalLinearDampingThresholdSqr`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalLinearDampingThresholdSqr(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalLinearDampingThresholdSqr`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_additionalLinearDampingThresholdSqr`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalLinearDampingThresholdSqr(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalLinearDampingThresholdSqr`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalLinearDampingThresholdSqr(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalAngularDampingThresholdSqr`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingThresholdSqr(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalAngularDampingThresholdSqr`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_additionalAngularDampingThresholdSqr`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalAngularDampingThresholdSqr(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalAngularDampingThresholdSqr`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingThresholdSqr(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Returns a pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalAngularDampingFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingFactor(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Modifies a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalAngularDampingFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// When this function is called, this object will drop object references it held previously in `m_additionalAngularDampingFactor`.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalAngularDampingFactor(btRigidBody_btRigidBodyConstructionInfo *_this, double value);

/// Returns a mutable pointer to a member variable of class `btRigidBody::btRigidBodyConstructionInfo` named `m_additionalAngularDampingFactor`.
/// Parameter `_this` can not be null. It is a single object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// The reference to this object might be preserved as the return value.
BULLET_API double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingFactor(btRigidBody_btRigidBodyConstructionInfo *_this);

/// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in the constructed object.
/// Never returns null. Returns an instance allocated on the heap! Must call `btRigidBody_btRigidBodyConstructionInfo_Destroy()` to free it when you're done using it.
BULLET_API btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother(Bullet_PassBy _other_pass_by, btRigidBody_btRigidBodyConstructionInfo *_other);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API const btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_OffsetPtr(const btRigidBody_btRigidBodyConstructionInfo *ptr, ptrdiff_t i);

/// Offsets a pointer to an array element by `i` positions (not bytes). Use only if you're certain that the pointer points to an array element.
/// The reference to the parameter `ptr` might be preserved in the return value.
BULLET_API btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_OffsetMutablePtr(btRigidBody_btRigidBodyConstructionInfo *ptr, ptrdiff_t i);

/// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
/// Parameter `localInertia` is a single object.
/// Parameter `localInertia` has a default argument: `btVector3(0, 0, 0)`, pass a null pointer to use it.
/// Never returns null. Returns an instance allocated on the heap! Must call `btRigidBody_btRigidBodyConstructionInfo_Destroy()` to free it when you're done using it.
BULLET_API btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_Construct(double mass, btMotionState *motionState, btCollisionShape *collisionShape, const btVector3 *localInertia);

/// Destroys a heap-allocated instance of `btRigidBody_btRigidBodyConstructionInfo`. Does nothing if the pointer is null.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_Destroy(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Destroys a heap-allocated array of `btRigidBody_btRigidBodyConstructionInfo`. Does nothing if the pointer is null.
BULLET_API void btRigidBody_btRigidBodyConstructionInfo_DestroyArray(const btRigidBody_btRigidBodyConstructionInfo *_this);

/// Generated from method `btRigidBody::btRigidBodyConstructionInfo::operator=`.
/// Parameter `_this` can not be null. It is a single object.
/// The reference to things referred to by the parameter `_other` (if any) might be preserved in this object.
/// The returned pointer will never be null. It is non-owning, do NOT destroy it.
/// When this function is called, this object will drop any object references it held previously.
BULLET_API btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_AssignFromAnother(btRigidBody_btRigidBodyConstructionInfo *_this, Bullet_PassBy _other_pass_by, btRigidBody_btRigidBodyConstructionInfo *_other);

#ifdef __cplusplus
} // extern "C"
#endif
