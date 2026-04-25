// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletDynamics/Dynamics/btDiscreteDynamicsWorldMt.h"

#include <BulletCollision/BroadphaseCollision/btBroadphaseInterface.h>
#include <BulletCollision/BroadphaseCollision/btDispatcher.h>
#include <BulletCollision/BroadphaseCollision/btOverlappingPairCache.h>
#include <BulletCollision/CollisionDispatch/btCollisionConfiguration.h>
#include <BulletCollision/CollisionDispatch/btCollisionObject.h>
#include <BulletCollision/CollisionDispatch/btCollisionWorld.h>
#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <BulletCollision/CollisionShapes/btConvexShape.h>
#include <BulletDynamics/ConstraintSolver/btConstraintSolver.h>
#include <BulletDynamics/Dynamics/btDiscreteDynamicsWorld.h>
#include <BulletDynamics/Dynamics/btDiscreteDynamicsWorldMt.h>
#include <BulletDynamics/Dynamics/btDynamicsWorld.h>
#include <BulletDynamics/Dynamics/btRigidBody.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btConstraintSolverPoolMt *btConstraintSolverPoolMt_ConstructFromAnother(Bullet_PassBy _other_pass_by, btConstraintSolverPoolMt *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btConstraintSolverPoolMt);
    return (btConstraintSolverPoolMt *)new btConstraintSolverPoolMt(btConstraintSolverPoolMt(
        (MRBINDC_CLASSARG_COPY(_other, (btConstraintSolverPoolMt), btConstraintSolverPoolMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btConstraintSolverPoolMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btConstraintSolverPoolMt) MRBINDC_CLASSARG_END(_other, btConstraintSolverPoolMt))
    ));
}

const btConstraintSolverPoolMt *btConstraintSolverPoolMt_OffsetPtr(const btConstraintSolverPoolMt *ptr, ptrdiff_t i)
{
    return (const btConstraintSolverPoolMt *)(((const btConstraintSolverPoolMt *)ptr) + i);
}

btConstraintSolverPoolMt *btConstraintSolverPoolMt_OffsetMutablePtr(btConstraintSolverPoolMt *ptr, ptrdiff_t i)
{
    return (btConstraintSolverPoolMt *)(((btConstraintSolverPoolMt *)ptr) + i);
}

const btConstraintSolver *btConstraintSolverPoolMt_UpcastTo_btConstraintSolver(const btConstraintSolverPoolMt *object)
{
    return (const btConstraintSolver *)(static_cast<const btConstraintSolver *>(
        ((const btConstraintSolverPoolMt *)object)
    ));
}

btConstraintSolver *btConstraintSolverPoolMt_MutableUpcastTo_btConstraintSolver(btConstraintSolverPoolMt *object)
{
    return (btConstraintSolver *)(static_cast<btConstraintSolver *>(
        ((btConstraintSolverPoolMt *)object)
    ));
}

const btConstraintSolverPoolMt *btConstraintSolverPoolMt_StaticDowncastFrom_btConstraintSolver(const btConstraintSolver *object)
{
    return (const btConstraintSolverPoolMt *)(static_cast<const btConstraintSolverPoolMt *>(
        ((const btConstraintSolver *)object)
    ));
}

btConstraintSolverPoolMt *btConstraintSolverPoolMt_MutableStaticDowncastFrom_btConstraintSolver(btConstraintSolver *object)
{
    return (btConstraintSolverPoolMt *)(static_cast<btConstraintSolverPoolMt *>(
        ((btConstraintSolver *)object)
    ));
}

const btConstraintSolverPoolMt *btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver(const btConstraintSolver *object)
{
    return (const btConstraintSolverPoolMt *)(dynamic_cast<const btConstraintSolverPoolMt *>(
        ((const btConstraintSolver *)object)
    ));
}

btConstraintSolverPoolMt *btConstraintSolverPoolMt_MutableDynamicDowncastFrom_btConstraintSolver(btConstraintSolver *object)
{
    return (btConstraintSolverPoolMt *)(dynamic_cast<btConstraintSolverPoolMt *>(
        ((btConstraintSolver *)object)
    ));
}

const btConstraintSolverPoolMt *btConstraintSolverPoolMt_DynamicDowncastFromOrFail_btConstraintSolver(const btConstraintSolver *object)
{
    return (const btConstraintSolverPoolMt *)std::addressof(dynamic_cast<const btConstraintSolverPoolMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btConstraintSolver *)(object))
    ));
}

btConstraintSolverPoolMt *btConstraintSolverPoolMt_MutableDynamicDowncastFromOrFail_btConstraintSolver(btConstraintSolver *object)
{
    return (btConstraintSolverPoolMt *)std::addressof(dynamic_cast<btConstraintSolverPoolMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btConstraintSolver *)(object))
    ));
}

btConstraintSolverPoolMt *btConstraintSolverPoolMt_Construct_1(int numSolvers)
{
    return (btConstraintSolverPoolMt *)new btConstraintSolverPoolMt(btConstraintSolverPoolMt(
        numSolvers
    ));
}

btConstraintSolverPoolMt *btConstraintSolverPoolMt_Construct_2(btConstraintSolver **solvers, int numSolvers)
{
    return (btConstraintSolverPoolMt *)new btConstraintSolverPoolMt(btConstraintSolverPoolMt(
        ((btConstraintSolver **)solvers),
        numSolvers
    ));
}

void btConstraintSolverPoolMt_Destroy(const btConstraintSolverPoolMt *_this)
{
    delete ((const btConstraintSolverPoolMt *)_this);
}

void btConstraintSolverPoolMt_DestroyArray(const btConstraintSolverPoolMt *_this)
{
    delete[] ((const btConstraintSolverPoolMt *)_this);
}

btConstraintSolverPoolMt *btConstraintSolverPoolMt_AssignFromAnother(btConstraintSolverPoolMt *_this, Bullet_PassBy _other_pass_by, btConstraintSolverPoolMt *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btConstraintSolverPoolMt);
    return (btConstraintSolverPoolMt *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConstraintSolverPoolMt *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_COPY(_other, (btConstraintSolverPoolMt), btConstraintSolverPoolMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btConstraintSolverPoolMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btConstraintSolverPoolMt) MRBINDC_CLASSARG_END(_other, btConstraintSolverPoolMt)))
    ));
}

void btConstraintSolverPoolMt_reset(btConstraintSolverPoolMt *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConstraintSolverPoolMt *)(_this)).reset();
}

void btConstraintSolverPoolMt_prepareSolve(btConstraintSolverPoolMt *_this, int _1, int _2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConstraintSolverPoolMt *)(_this)).prepareSolve(
        _1,
        _2
    );
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_ConstructFromAnother(Bullet_PassBy _other_pass_by, btDiscreteDynamicsWorldMt *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btDiscreteDynamicsWorldMt);
    return (btDiscreteDynamicsWorldMt *)new btDiscreteDynamicsWorldMt(btDiscreteDynamicsWorldMt(
        (MRBINDC_CLASSARG_COPY(_other, (btDiscreteDynamicsWorldMt), btDiscreteDynamicsWorldMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btDiscreteDynamicsWorldMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btDiscreteDynamicsWorldMt) MRBINDC_CLASSARG_END(_other, btDiscreteDynamicsWorldMt))
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_OffsetPtr(const btDiscreteDynamicsWorldMt *ptr, ptrdiff_t i)
{
    return (const btDiscreteDynamicsWorldMt *)(((const btDiscreteDynamicsWorldMt *)ptr) + i);
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_OffsetMutablePtr(btDiscreteDynamicsWorldMt *ptr, ptrdiff_t i)
{
    return (btDiscreteDynamicsWorldMt *)(((btDiscreteDynamicsWorldMt *)ptr) + i);
}

const btCollisionWorld *btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld(const btDiscreteDynamicsWorldMt *object)
{
    return (const btCollisionWorld *)(static_cast<const btCollisionWorld *>(
        ((const btDiscreteDynamicsWorldMt *)object)
    ));
}

btCollisionWorld *btDiscreteDynamicsWorldMt_MutableUpcastTo_btCollisionWorld(btDiscreteDynamicsWorldMt *object)
{
    return (btCollisionWorld *)(static_cast<btCollisionWorld *>(
        ((btDiscreteDynamicsWorldMt *)object)
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_StaticDowncastFrom_btCollisionWorld(const btCollisionWorld *object)
{
    return (const btDiscreteDynamicsWorldMt *)(static_cast<const btDiscreteDynamicsWorldMt *>(
        ((const btCollisionWorld *)object)
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableStaticDowncastFrom_btCollisionWorld(btCollisionWorld *object)
{
    return (btDiscreteDynamicsWorldMt *)(static_cast<btDiscreteDynamicsWorldMt *>(
        ((btCollisionWorld *)object)
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld(const btCollisionWorld *object)
{
    return (const btDiscreteDynamicsWorldMt *)(dynamic_cast<const btDiscreteDynamicsWorldMt *>(
        ((const btCollisionWorld *)object)
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFrom_btCollisionWorld(btCollisionWorld *object)
{
    return (btDiscreteDynamicsWorldMt *)(dynamic_cast<btDiscreteDynamicsWorldMt *>(
        ((btCollisionWorld *)object)
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFromOrFail_btCollisionWorld(const btCollisionWorld *object)
{
    return (const btDiscreteDynamicsWorldMt *)std::addressof(dynamic_cast<const btDiscreteDynamicsWorldMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btCollisionWorld *)(object))
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFromOrFail_btCollisionWorld(btCollisionWorld *object)
{
    return (btDiscreteDynamicsWorldMt *)std::addressof(dynamic_cast<btDiscreteDynamicsWorldMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btCollisionWorld *)(object))
    ));
}

const btDynamicsWorld *btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld(const btDiscreteDynamicsWorldMt *object)
{
    return (const btDynamicsWorld *)(static_cast<const btDynamicsWorld *>(
        ((const btDiscreteDynamicsWorldMt *)object)
    ));
}

btDynamicsWorld *btDiscreteDynamicsWorldMt_MutableUpcastTo_btDynamicsWorld(btDiscreteDynamicsWorldMt *object)
{
    return (btDynamicsWorld *)(static_cast<btDynamicsWorld *>(
        ((btDiscreteDynamicsWorldMt *)object)
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_StaticDowncastFrom_btDynamicsWorld(const btDynamicsWorld *object)
{
    return (const btDiscreteDynamicsWorldMt *)(static_cast<const btDiscreteDynamicsWorldMt *>(
        ((const btDynamicsWorld *)object)
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableStaticDowncastFrom_btDynamicsWorld(btDynamicsWorld *object)
{
    return (btDiscreteDynamicsWorldMt *)(static_cast<btDiscreteDynamicsWorldMt *>(
        ((btDynamicsWorld *)object)
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld(const btDynamicsWorld *object)
{
    return (const btDiscreteDynamicsWorldMt *)(dynamic_cast<const btDiscreteDynamicsWorldMt *>(
        ((const btDynamicsWorld *)object)
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFrom_btDynamicsWorld(btDynamicsWorld *object)
{
    return (btDiscreteDynamicsWorldMt *)(dynamic_cast<btDiscreteDynamicsWorldMt *>(
        ((btDynamicsWorld *)object)
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFromOrFail_btDynamicsWorld(const btDynamicsWorld *object)
{
    return (const btDiscreteDynamicsWorldMt *)std::addressof(dynamic_cast<const btDiscreteDynamicsWorldMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btDynamicsWorld *)(object))
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFromOrFail_btDynamicsWorld(btDynamicsWorld *object)
{
    return (btDiscreteDynamicsWorldMt *)std::addressof(dynamic_cast<btDiscreteDynamicsWorldMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btDynamicsWorld *)(object))
    ));
}

const btDiscreteDynamicsWorld *btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld(const btDiscreteDynamicsWorldMt *object)
{
    return (const btDiscreteDynamicsWorld *)(static_cast<const btDiscreteDynamicsWorld *>(
        ((const btDiscreteDynamicsWorldMt *)object)
    ));
}

btDiscreteDynamicsWorld *btDiscreteDynamicsWorldMt_MutableUpcastTo_btDiscreteDynamicsWorld(btDiscreteDynamicsWorldMt *object)
{
    return (btDiscreteDynamicsWorld *)(static_cast<btDiscreteDynamicsWorld *>(
        ((btDiscreteDynamicsWorldMt *)object)
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_StaticDowncastFrom_btDiscreteDynamicsWorld(const btDiscreteDynamicsWorld *object)
{
    return (const btDiscreteDynamicsWorldMt *)(static_cast<const btDiscreteDynamicsWorldMt *>(
        ((const btDiscreteDynamicsWorld *)object)
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableStaticDowncastFrom_btDiscreteDynamicsWorld(btDiscreteDynamicsWorld *object)
{
    return (btDiscreteDynamicsWorldMt *)(static_cast<btDiscreteDynamicsWorldMt *>(
        ((btDiscreteDynamicsWorld *)object)
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld(const btDiscreteDynamicsWorld *object)
{
    return (const btDiscreteDynamicsWorldMt *)(dynamic_cast<const btDiscreteDynamicsWorldMt *>(
        ((const btDiscreteDynamicsWorld *)object)
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFrom_btDiscreteDynamicsWorld(btDiscreteDynamicsWorld *object)
{
    return (btDiscreteDynamicsWorldMt *)(dynamic_cast<btDiscreteDynamicsWorldMt *>(
        ((btDiscreteDynamicsWorld *)object)
    ));
}

const btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_DynamicDowncastFromOrFail_btDiscreteDynamicsWorld(const btDiscreteDynamicsWorld *object)
{
    return (const btDiscreteDynamicsWorldMt *)std::addressof(dynamic_cast<const btDiscreteDynamicsWorldMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(const btDiscreteDynamicsWorld *)(object))
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_MutableDynamicDowncastFromOrFail_btDiscreteDynamicsWorld(btDiscreteDynamicsWorld *object)
{
    return (btDiscreteDynamicsWorldMt *)std::addressof(dynamic_cast<btDiscreteDynamicsWorldMt &>(
        ((object ? void() : MRBINDC_THROW("Parameter `object` can not be null.", void)), *(btDiscreteDynamicsWorld *)(object))
    ));
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_Construct(btDispatcher *dispatcher, btBroadphaseInterface *pairCache, btConstraintSolverPoolMt *solverPool, btConstraintSolver *constraintSolverMt, btCollisionConfiguration *collisionConfiguration)
{
    return (btDiscreteDynamicsWorldMt *)new btDiscreteDynamicsWorldMt(btDiscreteDynamicsWorldMt(
        ((btDispatcher *)dispatcher),
        ((btBroadphaseInterface *)pairCache),
        ((btConstraintSolverPoolMt *)solverPool),
        ((btConstraintSolver *)constraintSolverMt),
        ((btCollisionConfiguration *)collisionConfiguration)
    ));
}

void btDiscreteDynamicsWorldMt_Destroy(const btDiscreteDynamicsWorldMt *_this)
{
    delete ((const btDiscreteDynamicsWorldMt *)_this);
}

void btDiscreteDynamicsWorldMt_DestroyArray(const btDiscreteDynamicsWorldMt *_this)
{
    delete[] ((const btDiscreteDynamicsWorldMt *)_this);
}

btDiscreteDynamicsWorldMt *btDiscreteDynamicsWorldMt_AssignFromAnother(btDiscreteDynamicsWorldMt *_this, Bullet_PassBy _other_pass_by, btDiscreteDynamicsWorldMt *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btDiscreteDynamicsWorldMt);
    return (btDiscreteDynamicsWorldMt *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_COPY(_other, (btDiscreteDynamicsWorldMt), btDiscreteDynamicsWorldMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btDiscreteDynamicsWorldMt) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btDiscreteDynamicsWorldMt) MRBINDC_CLASSARG_END(_other, btDiscreteDynamicsWorldMt)))
    ));
}

void *Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long(unsigned long sizeInBytes)
{
    return btDiscreteDynamicsWorldMt::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr(void *ptr)
{
    btDiscreteDynamicsWorldMt::operator delete(
        ptr
    );
}

void *Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btDiscreteDynamicsWorldMt::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr_void_ptr(void *_1, void *_2)
{
    btDiscreteDynamicsWorldMt::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long(unsigned long sizeInBytes)
{
    return btDiscreteDynamicsWorldMt::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr(void *ptr)
{
    btDiscreteDynamicsWorldMt::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btDiscreteDynamicsWorldMt::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr_void_ptr(void *_1, void *_2)
{
    btDiscreteDynamicsWorldMt::operator delete[](
        _1,
        _2
    );
}

int btDiscreteDynamicsWorldMt_stepSimulation(btDiscreteDynamicsWorldMt *_this, double timeStep, int maxSubSteps, double fixedTimeStep)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).stepSimulation(
        timeStep,
        maxSubSteps,
        fixedTimeStep
    );
}

void btDiscreteDynamicsWorldMt_synchronizeMotionStates(btDiscreteDynamicsWorldMt *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).synchronizeMotionStates();
}

void btDiscreteDynamicsWorldMt_synchronizeSingleMotionState(btDiscreteDynamicsWorldMt *_this, btRigidBody *body)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).synchronizeSingleMotionState(
        ((btRigidBody *)body)
    );
}

btCollisionWorld *btDiscreteDynamicsWorldMt_getCollisionWorld(btDiscreteDynamicsWorldMt *_this)
{
    return (btCollisionWorld *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).getCollisionWorld());
}

void btDiscreteDynamicsWorldMt_setGravity(btDiscreteDynamicsWorldMt *_this, const btVector3 *gravity)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).setGravity(
        ((gravity ? void() : MRBINDC_THROW("Parameter `gravity` can not be null.", void)), *(const btVector3 *)(gravity))
    );
}

btVector3 *btDiscreteDynamicsWorldMt_getGravity(const btDiscreteDynamicsWorldMt *_this)
{
    return (btVector3 *)new btVector3(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).getGravity());
}

void btDiscreteDynamicsWorldMt_addCollisionObject(btDiscreteDynamicsWorldMt *_this, btCollisionObject *collisionObject, const int *collisionFilterGroup, const int *collisionFilterMask)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).addCollisionObject(
        ((btCollisionObject *)collisionObject),
        (collisionFilterGroup ? *collisionFilterGroup : static_cast<int>(btBroadphaseProxy::StaticFilter)),
        (collisionFilterMask ? *collisionFilterMask : static_cast<int>(btBroadphaseProxy::AllFilter ^ btBroadphaseProxy::StaticFilter))
    );
}

void btDiscreteDynamicsWorldMt_removeRigidBody(btDiscreteDynamicsWorldMt *_this, btRigidBody *body)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).removeRigidBody(
        ((btRigidBody *)body)
    );
}

void btDiscreteDynamicsWorldMt_removeCollisionObject(btDiscreteDynamicsWorldMt *_this, btCollisionObject *collisionObject)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).removeCollisionObject(
        ((btCollisionObject *)collisionObject)
    );
}

void btDiscreteDynamicsWorldMt_debugDrawWorld(btDiscreteDynamicsWorldMt *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).debugDrawWorld();
}

void btDiscreteDynamicsWorldMt_setConstraintSolver(btDiscreteDynamicsWorldMt *_this, btConstraintSolver *solver)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).setConstraintSolver(
        ((btConstraintSolver *)solver)
    );
}

btConstraintSolver *btDiscreteDynamicsWorldMt_getConstraintSolver(btDiscreteDynamicsWorldMt *_this)
{
    return (btConstraintSolver *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).getConstraintSolver());
}

int btDiscreteDynamicsWorldMt_getNumConstraints(const btDiscreteDynamicsWorldMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).getNumConstraints();
}

void btDiscreteDynamicsWorldMt_clearForces(btDiscreteDynamicsWorldMt *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).clearForces();
}

void btDiscreteDynamicsWorldMt_applyGravity(btDiscreteDynamicsWorldMt *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).applyGravity();
}

void btDiscreteDynamicsWorldMt_setNumTasks(btDiscreteDynamicsWorldMt *_this, int numTasks)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).setNumTasks(
        numTasks
    );
}

void btDiscreteDynamicsWorldMt_updateVehicles(btDiscreteDynamicsWorldMt *_this, double timeStep)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).updateVehicles(
        timeStep
    );
}

void btDiscreteDynamicsWorldMt_setSynchronizeAllMotionStates(btDiscreteDynamicsWorldMt *_this, bool synchronizeAll)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).setSynchronizeAllMotionStates(
        synchronizeAll
    );
}

bool btDiscreteDynamicsWorldMt_getSynchronizeAllMotionStates(const btDiscreteDynamicsWorldMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).getSynchronizeAllMotionStates();
}

void btDiscreteDynamicsWorldMt_setApplySpeculativeContactRestitution(btDiscreteDynamicsWorldMt *_this, bool enable)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).setApplySpeculativeContactRestitution(
        enable
    );
}

bool btDiscreteDynamicsWorldMt_getApplySpeculativeContactRestitution(const btDiscreteDynamicsWorldMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).getApplySpeculativeContactRestitution();
}

void btDiscreteDynamicsWorldMt_setLatencyMotionStateInterpolation(btDiscreteDynamicsWorldMt *_this, bool latencyInterpolation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).setLatencyMotionStateInterpolation(
        latencyInterpolation
    );
}

bool btDiscreteDynamicsWorldMt_getLatencyMotionStateInterpolation(const btDiscreteDynamicsWorldMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).getLatencyMotionStateInterpolation();
}

void btDiscreteDynamicsWorldMt_setWorldUserInfo(btDiscreteDynamicsWorldMt *_this, void *worldUserInfo)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).setWorldUserInfo(
        worldUserInfo
    );
}

void *btDiscreteDynamicsWorldMt_getWorldUserInfo(const btDiscreteDynamicsWorldMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).getWorldUserInfo();
}

void btDiscreteDynamicsWorldMt_setBroadphase(btDiscreteDynamicsWorldMt *_this, btBroadphaseInterface *pairCache)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).setBroadphase(
        ((btBroadphaseInterface *)pairCache)
    );
}

btOverlappingPairCache *btDiscreteDynamicsWorldMt_getPairCache(btDiscreteDynamicsWorldMt *_this)
{
    return (btOverlappingPairCache *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).getPairCache());
}

void btDiscreteDynamicsWorldMt_updateSingleAabb(btDiscreteDynamicsWorldMt *_this, btCollisionObject *colObj)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).updateSingleAabb(
        ((btCollisionObject *)colObj)
    );
}

void btDiscreteDynamicsWorldMt_updateAabbs(btDiscreteDynamicsWorldMt *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).updateAabbs();
}

void btDiscreteDynamicsWorldMt_computeOverlappingPairs(btDiscreteDynamicsWorldMt *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).computeOverlappingPairs();
}

void btDiscreteDynamicsWorldMt_debugDrawObject(btDiscreteDynamicsWorldMt *_this, const btTransform *worldTransform, const btCollisionShape *shape, const btVector3 *color)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).debugDrawObject(
        ((worldTransform ? void() : MRBINDC_THROW("Parameter `worldTransform` can not be null.", void)), *(const btTransform *)(worldTransform)),
        ((const btCollisionShape *)shape),
        ((color ? void() : MRBINDC_THROW("Parameter `color` can not be null.", void)), *(const btVector3 *)(color))
    );
}

int btDiscreteDynamicsWorldMt_getNumCollisionObjects(const btDiscreteDynamicsWorldMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).getNumCollisionObjects();
}

void btDiscreteDynamicsWorldMt_rayTest(const btDiscreteDynamicsWorldMt *_this, const btVector3 *rayFromWorld, const btVector3 *rayToWorld, btCollisionWorld_RayResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).rayTest(
        ((rayFromWorld ? void() : MRBINDC_THROW("Parameter `rayFromWorld` can not be null.", void)), *(const btVector3 *)(rayFromWorld)),
        ((rayToWorld ? void() : MRBINDC_THROW("Parameter `rayToWorld` can not be null.", void)), *(const btVector3 *)(rayToWorld)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(resultCallback))
    );
}

void btDiscreteDynamicsWorldMt_convexSweepTest(const btDiscreteDynamicsWorldMt *_this, const btConvexShape *castShape, const btTransform *from, const btTransform *to, btCollisionWorld_ConvexResultCallback *resultCallback, const double *allowedCcdPenetration)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).convexSweepTest(
        ((const btConvexShape *)castShape),
        ((from ? void() : MRBINDC_THROW("Parameter `from` can not be null.", void)), *(const btTransform *)(from)),
        ((to ? void() : MRBINDC_THROW("Parameter `to` can not be null.", void)), *(const btTransform *)(to)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(resultCallback)),
        (allowedCcdPenetration ? *allowedCcdPenetration : static_cast<double>(btScalar(0.)))
    );
}

void btDiscreteDynamicsWorldMt_contactTest(btDiscreteDynamicsWorldMt *_this, btCollisionObject *colObj, btCollisionWorld_ContactResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).contactTest(
        ((btCollisionObject *)colObj),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(resultCallback))
    );
}

void btDiscreteDynamicsWorldMt_contactPairTest(btDiscreteDynamicsWorldMt *_this, btCollisionObject *colObjA, btCollisionObject *colObjB, btCollisionWorld_ContactResultCallback *resultCallback)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).contactPairTest(
        ((btCollisionObject *)colObjA),
        ((btCollisionObject *)colObjB),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ContactResultCallback *)(resultCallback))
    );
}

void btDiscreteDynamicsWorldMt_rayTestSingle(const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_RayResultCallback *resultCallback)
{
    btDiscreteDynamicsWorldMt::rayTestSingle(
        ((rayFromTrans ? void() : MRBINDC_THROW("Parameter `rayFromTrans` can not be null.", void)), *(const btTransform *)(rayFromTrans)),
        ((rayToTrans ? void() : MRBINDC_THROW("Parameter `rayToTrans` can not be null.", void)), *(const btTransform *)(rayToTrans)),
        ((btCollisionObject *)collisionObject),
        ((const btCollisionShape *)collisionShape),
        ((colObjWorldTransform ? void() : MRBINDC_THROW("Parameter `colObjWorldTransform` can not be null.", void)), *(const btTransform *)(colObjWorldTransform)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::RayResultCallback *)(resultCallback))
    );
}

void btDiscreteDynamicsWorldMt_objectQuerySingle(const btConvexShape *castShape, const btTransform *rayFromTrans, const btTransform *rayToTrans, btCollisionObject *collisionObject, const btCollisionShape *collisionShape, const btTransform *colObjWorldTransform, btCollisionWorld_ConvexResultCallback *resultCallback, double allowedPenetration)
{
    btDiscreteDynamicsWorldMt::objectQuerySingle(
        ((const btConvexShape *)castShape),
        ((rayFromTrans ? void() : MRBINDC_THROW("Parameter `rayFromTrans` can not be null.", void)), *(const btTransform *)(rayFromTrans)),
        ((rayToTrans ? void() : MRBINDC_THROW("Parameter `rayToTrans` can not be null.", void)), *(const btTransform *)(rayToTrans)),
        ((btCollisionObject *)collisionObject),
        ((const btCollisionShape *)collisionShape),
        ((colObjWorldTransform ? void() : MRBINDC_THROW("Parameter `colObjWorldTransform` can not be null.", void)), *(const btTransform *)(colObjWorldTransform)),
        ((resultCallback ? void() : MRBINDC_THROW("Parameter `resultCallback` can not be null.", void)), *(btCollisionWorld::ConvexResultCallback *)(resultCallback)),
        allowedPenetration
    );
}

void btDiscreteDynamicsWorldMt_refreshBroadphaseProxy(btDiscreteDynamicsWorldMt *_this, btCollisionObject *collisionObject)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).refreshBroadphaseProxy(
        ((btCollisionObject *)collisionObject)
    );
}

void btDiscreteDynamicsWorldMt_performDiscreteCollisionDetection(btDiscreteDynamicsWorldMt *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).performDiscreteCollisionDetection();
}

bool btDiscreteDynamicsWorldMt_getForceUpdateAllAabbs(const btDiscreteDynamicsWorldMt *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btDiscreteDynamicsWorldMt *)(_this)).getForceUpdateAllAabbs();
}

void btDiscreteDynamicsWorldMt_setForceUpdateAllAabbs(btDiscreteDynamicsWorldMt *_this, bool forceUpdateAllAabbs)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btDiscreteDynamicsWorldMt *)(_this)).setForceUpdateAllAabbs(
        forceUpdateAllAabbs
    );
}

