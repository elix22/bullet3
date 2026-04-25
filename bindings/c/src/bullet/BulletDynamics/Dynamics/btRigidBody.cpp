// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletDynamics/Dynamics/btRigidBody.h"

#include <BulletCollision/CollisionDispatch/btCollisionObject.h>
#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletDynamics/Dynamics/btRigidBody.h>
#include <LinearMath/btMatrix3x3.h>
#include <LinearMath/btMotionState.h>
#include <LinearMath/btQuaternion.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


const int *btRigidBody_Get_m_contactSolverType(const btRigidBody *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).m_contactSolverType);
}

void btRigidBody_Set_m_contactSolverType(btRigidBody *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).m_contactSolverType = value;
}

int *btRigidBody_GetMutable_m_contactSolverType(btRigidBody *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).m_contactSolverType);
}

const int *btRigidBody_Get_m_frictionSolverType(const btRigidBody *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).m_frictionSolverType);
}

void btRigidBody_Set_m_frictionSolverType(btRigidBody *_this, int value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).m_frictionSolverType = value;
}

int *btRigidBody_GetMutable_m_frictionSolverType(btRigidBody *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).m_frictionSolverType);
}

btRigidBody *btRigidBody_ConstructFromAnother(Bullet_PassBy _other_pass_by, btRigidBody *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btRigidBody);
    return (btRigidBody *)new btRigidBody(btRigidBody(
        (MRBINDC_CLASSARG_COPY(_other, (btRigidBody), btRigidBody) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btRigidBody) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btRigidBody) MRBINDC_CLASSARG_END(_other, btRigidBody))
    ));
}

const btRigidBody *btRigidBody_OffsetPtr(const btRigidBody *ptr, ptrdiff_t i)
{
    return (const btRigidBody *)(((const btRigidBody *)ptr) + i);
}

btRigidBody *btRigidBody_OffsetMutablePtr(btRigidBody *ptr, ptrdiff_t i)
{
    return (btRigidBody *)(((btRigidBody *)ptr) + i);
}

const btCollisionObject *btRigidBody_UpcastTo_btCollisionObject(const btRigidBody *object)
{
    return (const btCollisionObject *)(static_cast<const btCollisionObject *>(
        ((const btRigidBody *)object)
    ));
}

btCollisionObject *btRigidBody_MutableUpcastTo_btCollisionObject(btRigidBody *object)
{
    return (btCollisionObject *)(static_cast<btCollisionObject *>(
        ((btRigidBody *)object)
    ));
}

const btRigidBody *btRigidBody_StaticDowncastFrom_btCollisionObject(const btCollisionObject *object)
{
    return (const btRigidBody *)(static_cast<const btRigidBody *>(
        ((const btCollisionObject *)object)
    ));
}

btRigidBody *btRigidBody_MutableStaticDowncastFrom_btCollisionObject(btCollisionObject *object)
{
    return (btRigidBody *)(static_cast<btRigidBody *>(
        ((btCollisionObject *)object)
    ));
}

const btRigidBody *btRigidBody_DynamicDowncastFrom_btCollisionObject(const btCollisionObject *object)
{
    return (const btRigidBody *)(dynamic_cast<const btRigidBody *>(
        ((const btCollisionObject *)object)
    ));
}

btRigidBody *btRigidBody_MutableDynamicDowncastFrom_btCollisionObject(btCollisionObject *object)
{
    return (btRigidBody *)(dynamic_cast<btRigidBody *>(
        ((btCollisionObject *)object)
    ));
}

const btRigidBody *btRigidBody_DynamicDowncastFromOrFail_btCollisionObject(const btCollisionObject *object)
{
    return (const btRigidBody *)std::addressof(dynamic_cast<const btRigidBody &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionObject *)(object))
    ));
}

btRigidBody *btRigidBody_MutableDynamicDowncastFromOrFail_btCollisionObject(btCollisionObject *object)
{
    return (btRigidBody *)std::addressof(dynamic_cast<btRigidBody &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionObject *)(object))
    ));
}

btRigidBody *btRigidBody_Construct_1(const btRigidBody_btRigidBodyConstructionInfo *constructionInfo)
{
    return (btRigidBody *)new btRigidBody(btRigidBody(
        ((constructionInfo ? void() : MRBINDC_THROW("Parameter `constructionInfo` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(constructionInfo))
    ));
}

btRigidBody *btRigidBody_Construct_4(double mass, btMotionState *motionState, btCollisionShape *collisionShape, const btVector3 *localInertia)
{
    return (btRigidBody *)new btRigidBody(btRigidBody(
        mass,
        ((btMotionState *)motionState),
        ((btCollisionShape *)collisionShape),
        (localInertia ? *(const btVector3 *)(localInertia) : static_cast<const btVector3 &>(btVector3(0, 0, 0)))
    ));
}

void btRigidBody_Destroy(const btRigidBody *_this)
{
    delete ((const btRigidBody *)_this);
}

void btRigidBody_DestroyArray(const btRigidBody *_this)
{
    delete[] ((const btRigidBody *)_this);
}

btRigidBody *btRigidBody_AssignFromAnother(btRigidBody *_this, Bullet_PassBy _other_pass_by, btRigidBody *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btRigidBody);
    return (btRigidBody *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_COPY(_other, (btRigidBody), btRigidBody) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btRigidBody) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btRigidBody) MRBINDC_CLASSARG_END(_other, btRigidBody)))
    ));
}

void btRigidBody_proceedToTransform(btRigidBody *_this, const btTransform *newTrans)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).proceedToTransform(
        ((newTrans ? void() : MRBINDC_THROW("Parameter `newTrans` can not be null.", void)), *(const btTransform *)(newTrans))
    );
}

const btRigidBody *btRigidBody_upcast_const_btCollisionObject_ptr(const btCollisionObject *colObj)
{
    return (const btRigidBody *)(btRigidBody::upcast(
        ((const btCollisionObject *)colObj)
    ));
}

btRigidBody *btRigidBody_upcast_btCollisionObject_ptr(btCollisionObject *colObj)
{
    return (btRigidBody *)(btRigidBody::upcast(
        ((btCollisionObject *)colObj)
    ));
}

void btRigidBody_predictIntegratedTransform(btRigidBody *_this, double step, btTransform *predictedTransform)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).predictIntegratedTransform(
        step,
        ((predictedTransform ? void() : MRBINDC_THROW("Parameter `predictedTransform` can not be null.", void)), *(btTransform *)(predictedTransform))
    );
}

void btRigidBody_saveKinematicState(btRigidBody *_this, double step)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).saveKinematicState(
        step
    );
}

void btRigidBody_applyGravity(btRigidBody *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyGravity();
}

void btRigidBody_clearGravity(btRigidBody *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).clearGravity();
}

void btRigidBody_setGravity(btRigidBody *_this, const btVector3 *acceleration)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setGravity(
        ((acceleration ? void() : MRBINDC_THROW("Parameter `acceleration` can not be null.", void)), *(const btVector3 *)(acceleration))
    );
}

const btVector3 *btRigidBody_getGravity(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getGravity());
}

void btRigidBody_setDamping(btRigidBody *_this, double lin_damping, double ang_damping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setDamping(
        lin_damping,
        ang_damping
    );
}

double btRigidBody_getLinearDamping(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getLinearDamping();
}

double btRigidBody_getAngularDamping(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getAngularDamping();
}

double btRigidBody_getLinearSleepingThreshold(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getLinearSleepingThreshold();
}

double btRigidBody_getAngularSleepingThreshold(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getAngularSleepingThreshold();
}

void btRigidBody_applyDamping(btRigidBody *_this, double timeStep)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyDamping(
        timeStep
    );
}

const btCollisionShape *btRigidBody_getCollisionShape(const btRigidBody *_this)
{
    return (const btCollisionShape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getCollisionShape());
}

btCollisionShape *btRigidBody_getCollisionShape_mut(btRigidBody *_this)
{
    return (btCollisionShape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).getCollisionShape());
}

void btRigidBody_setMassProps(btRigidBody *_this, double mass, const btVector3 *inertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setMassProps(
        mass,
        ((inertia ? void() : MRBINDC_THROW("Parameter `inertia` can not be null.", void)), *(const btVector3 *)(inertia))
    );
}

const btVector3 *btRigidBody_getLinearFactor(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getLinearFactor());
}

void btRigidBody_setLinearFactor(btRigidBody *_this, const btVector3 *linearFactor)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setLinearFactor(
        ((linearFactor ? void() : MRBINDC_THROW("Parameter `linearFactor` can not be null.", void)), *(const btVector3 *)(linearFactor))
    );
}

double btRigidBody_getInvMass(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getInvMass();
}

double btRigidBody_getMass(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getMass();
}

const btMatrix3x3 *btRigidBody_getInvInertiaTensorWorld(const btRigidBody *_this)
{
    return (const btMatrix3x3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getInvInertiaTensorWorld());
}

void btRigidBody_integrateVelocities(btRigidBody *_this, double step)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).integrateVelocities(
        step
    );
}

void btRigidBody_setCenterOfMassTransform(btRigidBody *_this, const btTransform *xform)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setCenterOfMassTransform(
        ((xform ? void() : MRBINDC_THROW("Parameter `xform` can not be null.", void)), *(const btTransform *)(xform))
    );
}

void btRigidBody_applyCentralForce(btRigidBody *_this, const btVector3 *force)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyCentralForce(
        ((force ? void() : MRBINDC_THROW("Parameter `force` can not be null.", void)), *(const btVector3 *)(force))
    );
}

const btVector3 *btRigidBody_getTotalForce(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getTotalForce());
}

const btVector3 *btRigidBody_getTotalTorque(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getTotalTorque());
}

const btVector3 *btRigidBody_getInvInertiaDiagLocal(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getInvInertiaDiagLocal());
}

void btRigidBody_setInvInertiaDiagLocal(btRigidBody *_this, const btVector3 *diagInvInertia)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setInvInertiaDiagLocal(
        ((diagInvInertia ? void() : MRBINDC_THROW("Parameter `diagInvInertia` can not be null.", void)), *(const btVector3 *)(diagInvInertia))
    );
}

void btRigidBody_setSleepingThresholds(btRigidBody *_this, double linear, double angular)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setSleepingThresholds(
        linear,
        angular
    );
}

void btRigidBody_applyTorque(btRigidBody *_this, const btVector3 *torque)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyTorque(
        ((torque ? void() : MRBINDC_THROW("Parameter `torque` can not be null.", void)), *(const btVector3 *)(torque))
    );
}

void btRigidBody_applyForce(btRigidBody *_this, const btVector3 *force, const btVector3 *rel_pos)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyForce(
        ((force ? void() : MRBINDC_THROW("Parameter `force` can not be null.", void)), *(const btVector3 *)(force)),
        ((rel_pos ? void() : MRBINDC_THROW("Parameter `rel_pos` can not be null.", void)), *(const btVector3 *)(rel_pos))
    );
}

void btRigidBody_applyCentralImpulse(btRigidBody *_this, const btVector3 *impulse)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyCentralImpulse(
        ((impulse ? void() : MRBINDC_THROW("Parameter `impulse` can not be null.", void)), *(const btVector3 *)(impulse))
    );
}

void btRigidBody_applyTorqueImpulse(btRigidBody *_this, const btVector3 *torque)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyTorqueImpulse(
        ((torque ? void() : MRBINDC_THROW("Parameter `torque` can not be null.", void)), *(const btVector3 *)(torque))
    );
}

void btRigidBody_applyImpulse(btRigidBody *_this, const btVector3 *impulse, const btVector3 *rel_pos)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyImpulse(
        ((impulse ? void() : MRBINDC_THROW("Parameter `impulse` can not be null.", void)), *(const btVector3 *)(impulse)),
        ((rel_pos ? void() : MRBINDC_THROW("Parameter `rel_pos` can not be null.", void)), *(const btVector3 *)(rel_pos))
    );
}

void btRigidBody_applyPushImpulse(btRigidBody *_this, const btVector3 *impulse, const btVector3 *rel_pos)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyPushImpulse(
        ((impulse ? void() : MRBINDC_THROW("Parameter `impulse` can not be null.", void)), *(const btVector3 *)(impulse)),
        ((rel_pos ? void() : MRBINDC_THROW("Parameter `rel_pos` can not be null.", void)), *(const btVector3 *)(rel_pos))
    );
}

btVector3 *btRigidBody_getPushVelocity(const btRigidBody *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getPushVelocity());
}

btVector3 *btRigidBody_getTurnVelocity(const btRigidBody *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getTurnVelocity());
}

void btRigidBody_setPushVelocity(btRigidBody *_this, const btVector3 *v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setPushVelocity(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

void btRigidBody_setTurnVelocity(btRigidBody *_this, const btVector3 *v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setTurnVelocity(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

void btRigidBody_applyCentralPushImpulse(btRigidBody *_this, const btVector3 *impulse)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyCentralPushImpulse(
        ((impulse ? void() : MRBINDC_THROW("Parameter `impulse` can not be null.", void)), *(const btVector3 *)(impulse))
    );
}

void btRigidBody_applyTorqueTurnImpulse(btRigidBody *_this, const btVector3 *torque)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).applyTorqueTurnImpulse(
        ((torque ? void() : MRBINDC_THROW("Parameter `torque` can not be null.", void)), *(const btVector3 *)(torque))
    );
}

void btRigidBody_clearForces(btRigidBody *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).clearForces();
}

void btRigidBody_updateInertiaTensor(btRigidBody *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).updateInertiaTensor();
}

const btVector3 *btRigidBody_getCenterOfMassPosition(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getCenterOfMassPosition());
}

btQuaternion *btRigidBody_getOrientation(const btRigidBody *_this)
{
    return (btQuaternion *)new btQuaternion(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getOrientation());
}

const btTransform *btRigidBody_getCenterOfMassTransform(const btRigidBody *_this)
{
    return (const btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getCenterOfMassTransform());
}

const btVector3 *btRigidBody_getLinearVelocity(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getLinearVelocity());
}

const btVector3 *btRigidBody_getAngularVelocity(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getAngularVelocity());
}

void btRigidBody_setLinearVelocity(btRigidBody *_this, const btVector3 *lin_vel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setLinearVelocity(
        ((lin_vel ? void() : MRBINDC_THROW("Parameter `lin_vel` can not be null.", void)), *(const btVector3 *)(lin_vel))
    );
}

void btRigidBody_setAngularVelocity(btRigidBody *_this, const btVector3 *ang_vel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setAngularVelocity(
        ((ang_vel ? void() : MRBINDC_THROW("Parameter `ang_vel` can not be null.", void)), *(const btVector3 *)(ang_vel))
    );
}

btVector3 *btRigidBody_getVelocityInLocalPoint(const btRigidBody *_this, const btVector3 *rel_pos)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getVelocityInLocalPoint(
        ((rel_pos ? void() : MRBINDC_THROW("Parameter `rel_pos` can not be null.", void)), *(const btVector3 *)(rel_pos))
    ));
}

btVector3 *btRigidBody_getPushVelocityInLocalPoint(const btRigidBody *_this, const btVector3 *rel_pos)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getPushVelocityInLocalPoint(
        ((rel_pos ? void() : MRBINDC_THROW("Parameter `rel_pos` can not be null.", void)), *(const btVector3 *)(rel_pos))
    ));
}

void btRigidBody_translate(btRigidBody *_this, const btVector3 *v)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).translate(
        ((v ? void() : MRBINDC_THROW("Parameter `v` can not be null.", void)), *(const btVector3 *)(v))
    );
}

void btRigidBody_getAabb(const btRigidBody *_this, btVector3 *aabbMin, btVector3 *aabbMax)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getAabb(
        ((aabbMin ? void() : MRBINDC_THROW("Parameter `aabbMin` can not be null.", void)), *(btVector3 *)(aabbMin)),
        ((aabbMax ? void() : MRBINDC_THROW("Parameter `aabbMax` can not be null.", void)), *(btVector3 *)(aabbMax))
    );
}

double btRigidBody_computeImpulseDenominator(const btRigidBody *_this, const btVector3 *pos, const btVector3 *normal)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).computeImpulseDenominator(
        ((pos ? void() : MRBINDC_THROW("Parameter `pos` can not be null.", void)), *(const btVector3 *)(pos)),
        ((normal ? void() : MRBINDC_THROW("Parameter `normal` can not be null.", void)), *(const btVector3 *)(normal))
    );
}

double btRigidBody_computeAngularImpulseDenominator(const btRigidBody *_this, const btVector3 *axis)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).computeAngularImpulseDenominator(
        ((axis ? void() : MRBINDC_THROW("Parameter `axis` can not be null.", void)), *(const btVector3 *)(axis))
    );
}

void btRigidBody_updateDeactivation(btRigidBody *_this, double timeStep)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).updateDeactivation(
        timeStep
    );
}

bool btRigidBody_wantsSleeping(btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).wantsSleeping();
}

btMotionState *btRigidBody_getMotionState_mut(btRigidBody *_this)
{
    return (btMotionState *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).getMotionState());
}

const btMotionState *btRigidBody_getMotionState(const btRigidBody *_this)
{
    return (const btMotionState *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getMotionState());
}

void btRigidBody_setMotionState(btRigidBody *_this, btMotionState *motionState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setMotionState(
        ((btMotionState *)motionState)
    );
}

void btRigidBody_setAngularFactor_btVector3(btRigidBody *_this, const btVector3 *angFac)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setAngularFactor(
        ((angFac ? void() : MRBINDC_THROW("Parameter `angFac` can not be null.", void)), *(const btVector3 *)(angFac))
    );
}

void btRigidBody_setAngularFactor_double(btRigidBody *_this, double angFac)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setAngularFactor(
        angFac
    );
}

const btVector3 *btRigidBody_getAngularFactor(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getAngularFactor());
}

bool btRigidBody_isInWorld(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).isInWorld();
}

int btRigidBody_getNumConstraintRefs(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getNumConstraintRefs();
}

void btRigidBody_setFlags(btRigidBody *_this, int flags)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setFlags(
        flags
    );
}

int btRigidBody_getFlags(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getFlags();
}

btVector3 *btRigidBody_computeGyroscopicImpulseImplicit_World(const btRigidBody *_this, double dt)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).computeGyroscopicImpulseImplicit_World(
        dt
    ));
}

btVector3 *btRigidBody_computeGyroscopicImpulseImplicit_Body(const btRigidBody *_this, double step)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).computeGyroscopicImpulseImplicit_Body(
        step
    ));
}

btVector3 *btRigidBody_computeGyroscopicForceExplicit(const btRigidBody *_this, double maxGyroscopicForce)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).computeGyroscopicForceExplicit(
        maxGyroscopicForce
    ));
}

btVector3 *btRigidBody_getLocalInertia(const btRigidBody *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getLocalInertia());
}

int btRigidBody_calculateSerializeBufferSize(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).calculateSerializeBufferSize();
}

bool btRigidBody_mergesSimulationIslands(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).mergesSimulationIslands();
}

const btVector3 *btRigidBody_getAnisotropicFriction(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getAnisotropicFriction());
}

void btRigidBody_setAnisotropicFriction(btRigidBody *_this, const btVector3 *anisotropicFriction, const int *frictionMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setAnisotropicFriction(
        ((anisotropicFriction ? void() : MRBINDC_THROW("Parameter `anisotropicFriction` can not be null.", void)), *(const btVector3 *)(anisotropicFriction)),
        (frictionMode ? *frictionMode : static_cast<int>(btCollisionObject::CF_ANISOTROPIC_FRICTION))
    );
}

bool btRigidBody_hasAnisotropicFriction(const btRigidBody *_this, const int *frictionMode)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).hasAnisotropicFriction(
        (frictionMode ? *frictionMode : static_cast<int>(btCollisionObject::CF_ANISOTROPIC_FRICTION))
    );
}

void btRigidBody_setContactProcessingThreshold(btRigidBody *_this, double contactProcessingThreshold)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setContactProcessingThreshold(
        contactProcessingThreshold
    );
}

double btRigidBody_getContactProcessingThreshold(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getContactProcessingThreshold();
}

bool btRigidBody_isStaticObject(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).isStaticObject();
}

bool btRigidBody_isKinematicObject(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).isKinematicObject();
}

bool btRigidBody_isStaticOrKinematicObject(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).isStaticOrKinematicObject();
}

bool btRigidBody_hasContactResponse(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).hasContactResponse();
}

void btRigidBody_setCollisionShape(btRigidBody *_this, btCollisionShape *collisionShape)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setCollisionShape(
        ((btCollisionShape *)collisionShape)
    );
}

void btRigidBody_setIgnoreCollisionCheck(btRigidBody *_this, const btCollisionObject *co, bool ignoreCollisionCheck)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setIgnoreCollisionCheck(
        ((const btCollisionObject *)co),
        ignoreCollisionCheck
    );
}

int btRigidBody_getNumObjectsWithoutCollision(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getNumObjectsWithoutCollision();
}

const btCollisionObject *btRigidBody_getObjectWithoutCollision(btRigidBody *_this, int index)
{
    return (const btCollisionObject *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).getObjectWithoutCollision(
        index
    ));
}

bool btRigidBody_checkCollideWithOverride(const btRigidBody *_this, const btCollisionObject *co)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).checkCollideWithOverride(
        ((const btCollisionObject *)co)
    );
}

void *btRigidBody_internalGetExtensionPointer(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).internalGetExtensionPointer();
}

void btRigidBody_internalSetExtensionPointer(btRigidBody *_this, void *pointer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).internalSetExtensionPointer(
        pointer
    );
}

int btRigidBody_getActivationState(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getActivationState();
}

void btRigidBody_setActivationState(const btRigidBody *_this, int newState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).setActivationState(
        newState
    );
}

void btRigidBody_setDeactivationTime(btRigidBody *_this, double time)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setDeactivationTime(
        time
    );
}

double btRigidBody_getDeactivationTime(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getDeactivationTime();
}

void btRigidBody_forceActivationState(const btRigidBody *_this, int newState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).forceActivationState(
        newState
    );
}

void btRigidBody_activate(const btRigidBody *_this, const bool *forceActivation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).activate(
        (forceActivation ? *forceActivation : static_cast<bool>(false))
    );
}

bool btRigidBody_isActive(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).isActive();
}

void btRigidBody_setRestitution(btRigidBody *_this, double rest)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setRestitution(
        rest
    );
}

double btRigidBody_getRestitution(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getRestitution();
}

void btRigidBody_setFriction(btRigidBody *_this, double frict)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setFriction(
        frict
    );
}

double btRigidBody_getFriction(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getFriction();
}

void btRigidBody_setRollingFriction(btRigidBody *_this, double frict)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setRollingFriction(
        frict
    );
}

double btRigidBody_getRollingFriction(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getRollingFriction();
}

void btRigidBody_setSpinningFriction(btRigidBody *_this, double frict)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setSpinningFriction(
        frict
    );
}

double btRigidBody_getSpinningFriction(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getSpinningFriction();
}

void btRigidBody_setContactStiffnessAndDamping(btRigidBody *_this, double stiffness, double damping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setContactStiffnessAndDamping(
        stiffness,
        damping
    );
}

double btRigidBody_getContactStiffness(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getContactStiffness();
}

double btRigidBody_getContactDamping(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getContactDamping();
}

int btRigidBody_getInternalType(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getInternalType();
}

void btRigidBody_setWorldTransform(btRigidBody *_this, const btTransform *worldTrans)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setWorldTransform(
        ((worldTrans ? void() : MRBINDC_THROW("Parameter `worldTrans` can not be null.", void)), *(const btTransform *)(worldTrans))
    );
}

void btRigidBody_setInterpolationWorldTransform(btRigidBody *_this, const btTransform *trans)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setInterpolationWorldTransform(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans))
    );
}

void btRigidBody_setInterpolationLinearVelocity(btRigidBody *_this, const btVector3 *linvel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setInterpolationLinearVelocity(
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel))
    );
}

void btRigidBody_setInterpolationAngularVelocity(btRigidBody *_this, const btVector3 *angvel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setInterpolationAngularVelocity(
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel))
    );
}

const btVector3 *btRigidBody_getInterpolationLinearVelocity(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getInterpolationLinearVelocity());
}

const btVector3 *btRigidBody_getInterpolationAngularVelocity(const btRigidBody *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getInterpolationAngularVelocity());
}

int btRigidBody_getIslandTag(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getIslandTag();
}

void btRigidBody_setIslandTag(btRigidBody *_this, int tag)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setIslandTag(
        tag
    );
}

int btRigidBody_getCompanionId(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getCompanionId();
}

void btRigidBody_setCompanionId(btRigidBody *_this, int id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setCompanionId(
        id
    );
}

int btRigidBody_getWorldArrayIndex(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getWorldArrayIndex();
}

void btRigidBody_setWorldArrayIndex(btRigidBody *_this, int ix)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setWorldArrayIndex(
        ix
    );
}

double btRigidBody_getHitFraction(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getHitFraction();
}

void btRigidBody_setHitFraction(btRigidBody *_this, double hitFraction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setHitFraction(
        hitFraction
    );
}

int btRigidBody_getCollisionFlags(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getCollisionFlags();
}

void btRigidBody_setCollisionFlags(btRigidBody *_this, int flags)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setCollisionFlags(
        flags
    );
}

double btRigidBody_getCcdSweptSphereRadius(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getCcdSweptSphereRadius();
}

void btRigidBody_setCcdSweptSphereRadius(btRigidBody *_this, double radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setCcdSweptSphereRadius(
        radius
    );
}

double btRigidBody_getCcdMotionThreshold(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getCcdMotionThreshold();
}

double btRigidBody_getCcdSquareMotionThreshold(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getCcdSquareMotionThreshold();
}

void btRigidBody_setCcdMotionThreshold(btRigidBody *_this, double ccdMotionThreshold)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setCcdMotionThreshold(
        ccdMotionThreshold
    );
}

void *btRigidBody_getUserPointer(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getUserPointer();
}

int btRigidBody_getUserIndex(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getUserIndex();
}

int btRigidBody_getUserIndex2(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getUserIndex2();
}

int btRigidBody_getUserIndex3(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getUserIndex3();
}

void btRigidBody_setUserPointer(btRigidBody *_this, void *userPointer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setUserPointer(
        userPointer
    );
}

void btRigidBody_setUserIndex(btRigidBody *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setUserIndex(
        index
    );
}

void btRigidBody_setUserIndex2(btRigidBody *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setUserIndex2(
        index
    );
}

void btRigidBody_setUserIndex3(btRigidBody *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setUserIndex3(
        index
    );
}

int btRigidBody_getUpdateRevisionInternal(const btRigidBody *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getUpdateRevisionInternal();
}

void btRigidBody_setCustomDebugColor(btRigidBody *_this, const btVector3 *colorRGB)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).setCustomDebugColor(
        ((colorRGB ? void() : MRBINDC_THROW("Parameter `colorRGB` can not be null.", void)), *(const btVector3 *)(colorRGB))
    );
}

void btRigidBody_removeCustomDebugColor(btRigidBody *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody *)(_this)).removeCustomDebugColor();
}

bool btRigidBody_getCustomDebugColor(const btRigidBody *_this, btVector3 *colorRGB)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).getCustomDebugColor(
        ((colorRGB ? void() : MRBINDC_THROW("Parameter `colorRGB` can not be null.", void)), *(btVector3 *)(colorRGB))
    );
}

bool btRigidBody_checkCollideWith(const btRigidBody *_this, const btCollisionObject *co)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody *)(_this)).checkCollideWith(
        ((const btCollisionObject *)co)
    );
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_mass(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_mass);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_mass(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_mass = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_mass(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_mass);
}

btMotionState *const *btRigidBody_btRigidBodyConstructionInfo_Get_m_motionState(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return (btMotionState *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_motionState);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_motionState(btRigidBody_btRigidBodyConstructionInfo *_this, btMotionState *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_motionState = ((btMotionState *)value);
}

btMotionState **btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_motionState(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return (btMotionState **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_motionState);
}

const btTransform *btRigidBody_btRigidBodyConstructionInfo_Get_m_startWorldTransform(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return (const btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_startWorldTransform);
}

btTransform *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_startWorldTransform(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return (btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_startWorldTransform);
}

btCollisionShape *const *btRigidBody_btRigidBodyConstructionInfo_Get_m_collisionShape(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return (btCollisionShape *const *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_collisionShape);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_collisionShape(btRigidBody_btRigidBodyConstructionInfo *_this, btCollisionShape *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_collisionShape = ((btCollisionShape *)value);
}

btCollisionShape **btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_collisionShape(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return (btCollisionShape **)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_collisionShape);
}

const btVector3 *btRigidBody_btRigidBodyConstructionInfo_Get_m_localInertia(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_localInertia);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_localInertia(btRigidBody_btRigidBodyConstructionInfo *_this, const btVector3 *value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_localInertia = ((value ? void() : MRBINDC_THROW("Parameter `value` can not be null.", void)), btVector3(*(btVector3 *)value));
}

btVector3 *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_localInertia(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return (btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_localInertia);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_linearDamping(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_linearDamping);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_linearDamping(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_linearDamping = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearDamping(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_linearDamping);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_angularDamping(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_angularDamping);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_angularDamping(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_angularDamping = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularDamping(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_angularDamping);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_friction(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_friction);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_friction(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_friction = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_friction(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_friction);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_rollingFriction(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_rollingFriction);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_rollingFriction(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_rollingFriction = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_rollingFriction(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_rollingFriction);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_spinningFriction(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_spinningFriction);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_spinningFriction(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_spinningFriction = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_spinningFriction(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_spinningFriction);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_restitution(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_restitution);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_restitution(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_restitution = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_restitution(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_restitution);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_linearSleepingThreshold(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_linearSleepingThreshold);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_linearSleepingThreshold(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_linearSleepingThreshold = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearSleepingThreshold(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_linearSleepingThreshold);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_angularSleepingThreshold(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_angularSleepingThreshold);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_angularSleepingThreshold(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_angularSleepingThreshold = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularSleepingThreshold(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_angularSleepingThreshold);
}

const bool *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDamping(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalDamping);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalDamping(btRigidBody_btRigidBodyConstructionInfo *_this, bool value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalDamping = value;
}

bool *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDamping(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalDamping);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDampingFactor(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalDampingFactor);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalDampingFactor(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalDampingFactor = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDampingFactor(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalDampingFactor);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalLinearDampingThresholdSqr(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalLinearDampingThresholdSqr);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalLinearDampingThresholdSqr(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalLinearDampingThresholdSqr = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalLinearDampingThresholdSqr(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalLinearDampingThresholdSqr);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingThresholdSqr(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalAngularDampingThresholdSqr);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalAngularDampingThresholdSqr(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalAngularDampingThresholdSqr = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingThresholdSqr(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalAngularDampingThresholdSqr);
}

const double *btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingFactor(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalAngularDampingFactor);
}

void btRigidBody_btRigidBodyConstructionInfo_Set_m_additionalAngularDampingFactor(btRigidBody_btRigidBodyConstructionInfo *_this, double value)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalAngularDampingFactor = value;
}

double *btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingFactor(btRigidBody_btRigidBodyConstructionInfo *_this)
{
    return std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).m_additionalAngularDampingFactor);
}

btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother(Bullet_PassBy _other_pass_by, btRigidBody_btRigidBodyConstructionInfo *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btRigidBody::btRigidBodyConstructionInfo);
    return (btRigidBody_btRigidBodyConstructionInfo *)new btRigidBody::btRigidBodyConstructionInfo(btRigidBody::btRigidBodyConstructionInfo(
        (MRBINDC_CLASSARG_COPY(_other, (btRigidBody::btRigidBodyConstructionInfo), btRigidBody::btRigidBodyConstructionInfo) MRBINDC_CLASSARG_MOVE(_other, (btRigidBody::btRigidBodyConstructionInfo), btRigidBody::btRigidBodyConstructionInfo) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btRigidBody::btRigidBodyConstructionInfo) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btRigidBody::btRigidBodyConstructionInfo) MRBINDC_CLASSARG_END(_other, btRigidBody::btRigidBodyConstructionInfo))
    ));
}

const btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_OffsetPtr(const btRigidBody_btRigidBodyConstructionInfo *ptr, ptrdiff_t i)
{
    return (const btRigidBody_btRigidBodyConstructionInfo *)(((const btRigidBody::btRigidBodyConstructionInfo *)ptr) + i);
}

btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_OffsetMutablePtr(btRigidBody_btRigidBodyConstructionInfo *ptr, ptrdiff_t i)
{
    return (btRigidBody_btRigidBodyConstructionInfo *)(((btRigidBody::btRigidBodyConstructionInfo *)ptr) + i);
}

btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_Construct(double mass, btMotionState *motionState, btCollisionShape *collisionShape, const btVector3 *localInertia)
{
    return (btRigidBody_btRigidBodyConstructionInfo *)new btRigidBody::btRigidBodyConstructionInfo(btRigidBody::btRigidBodyConstructionInfo(
        mass,
        ((btMotionState *)motionState),
        ((btCollisionShape *)collisionShape),
        (localInertia ? *(const btVector3 *)(localInertia) : static_cast<const btVector3 &>(btVector3(0, 0, 0)))
    ));
}

void btRigidBody_btRigidBodyConstructionInfo_Destroy(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    delete ((const btRigidBody::btRigidBodyConstructionInfo *)_this);
}

void btRigidBody_btRigidBodyConstructionInfo_DestroyArray(const btRigidBody_btRigidBodyConstructionInfo *_this)
{
    delete[] ((const btRigidBody::btRigidBodyConstructionInfo *)_this);
}

btRigidBody_btRigidBodyConstructionInfo *btRigidBody_btRigidBodyConstructionInfo_AssignFromAnother(btRigidBody_btRigidBodyConstructionInfo *_this, Bullet_PassBy _other_pass_by, btRigidBody_btRigidBodyConstructionInfo *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btRigidBody::btRigidBodyConstructionInfo);
    return (btRigidBody_btRigidBodyConstructionInfo *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btRigidBody::btRigidBodyConstructionInfo *)(_this)).operator=(
        (MRBINDC_CLASSARG_COPY(_other, (btRigidBody::btRigidBodyConstructionInfo), btRigidBody::btRigidBodyConstructionInfo) MRBINDC_CLASSARG_MOVE(_other, (btRigidBody::btRigidBodyConstructionInfo), btRigidBody::btRigidBodyConstructionInfo) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btRigidBody::btRigidBodyConstructionInfo) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btRigidBody::btRigidBodyConstructionInfo) MRBINDC_CLASSARG_END(_other, btRigidBody::btRigidBodyConstructionInfo))
    ));
}

