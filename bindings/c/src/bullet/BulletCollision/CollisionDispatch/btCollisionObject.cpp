// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionDispatch/btCollisionObject.h"

#include <BulletCollision/CollisionDispatch/btCollisionObject.h>
#include <BulletCollision/CollisionShapes/btCollisionShape.h>
#include <LinearMath/btTransform.h>
#include <LinearMath/btVector3.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <memory>
#include <stdexcept>


btCollisionObject *btCollisionObject_DefaultConstruct(void)
{
    return (btCollisionObject *)new btCollisionObject(btCollisionObject());
}

btCollisionObject *btCollisionObject_DefaultConstructArray(size_t num_elems)
{
    return (btCollisionObject *)(new btCollisionObject[num_elems]{});
}

const btCollisionObject *btCollisionObject_OffsetPtr(const btCollisionObject *ptr, ptrdiff_t i)
{
    return (const btCollisionObject *)(((const btCollisionObject *)ptr) + i);
}

btCollisionObject *btCollisionObject_OffsetMutablePtr(btCollisionObject *ptr, ptrdiff_t i)
{
    return (btCollisionObject *)(((btCollisionObject *)ptr) + i);
}

btCollisionObject *btCollisionObject_ConstructFromAnother(Bullet_PassBy _other_pass_by, btCollisionObject *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionObject);
    return (btCollisionObject *)new btCollisionObject(btCollisionObject(
        (MRBINDC_CLASSARG_DEF_CTOR(_other, btCollisionObject) MRBINDC_CLASSARG_COPY(_other, (btCollisionObject), btCollisionObject) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionObject) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionObject) MRBINDC_CLASSARG_END(_other, btCollisionObject))
    ));
}

void btCollisionObject_Destroy(const btCollisionObject *_this)
{
    delete ((const btCollisionObject *)_this);
}

void btCollisionObject_DestroyArray(const btCollisionObject *_this)
{
    delete[] ((const btCollisionObject *)_this);
}

btCollisionObject *btCollisionObject_AssignFromAnother(btCollisionObject *_this, Bullet_PassBy _other_pass_by, btCollisionObject *_other)
{
    MRBINDC_CLASSARG_GUARD(_other, btCollisionObject);
    return (btCollisionObject *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).operator=(
        mrbindc_details::unmove((MRBINDC_CLASSARG_DEF_CTOR(_other, btCollisionObject) MRBINDC_CLASSARG_COPY(_other, (btCollisionObject), btCollisionObject) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_DefaultArgument, btCollisionObject) MRBINDC_CLASSARG_NO_DEF_ARG(_other, Bullet_PassBy_NoObject, btCollisionObject) MRBINDC_CLASSARG_END(_other, btCollisionObject)))
    ));
}

void *Bullet_new_btCollisionObject_unsigned_long(unsigned long sizeInBytes)
{
    return btCollisionObject::operator new(
        sizeInBytes
    );
}

void Bullet_delete_btCollisionObject_void_ptr(void *ptr)
{
    btCollisionObject::operator delete(
        ptr
    );
}

void *Bullet_new_btCollisionObject_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btCollisionObject::operator new(
        _1,
        ptr
    );
}

void Bullet_delete_btCollisionObject_void_ptr_void_ptr(void *_1, void *_2)
{
    btCollisionObject::operator delete(
        _1,
        _2
    );
}

void *Bullet_new_array_btCollisionObject_unsigned_long(unsigned long sizeInBytes)
{
    return btCollisionObject::operator new[](
        sizeInBytes
    );
}

void Bullet_delete_array_btCollisionObject_void_ptr(void *ptr)
{
    btCollisionObject::operator delete[](
        ptr
    );
}

void *Bullet_new_array_btCollisionObject_unsigned_long_void_ptr(unsigned long _1, void *ptr)
{
    return btCollisionObject::operator new[](
        _1,
        ptr
    );
}

void Bullet_delete_array_btCollisionObject_void_ptr_void_ptr(void *_1, void *_2)
{
    btCollisionObject::operator delete[](
        _1,
        _2
    );
}

bool btCollisionObject_mergesSimulationIslands(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).mergesSimulationIslands();
}

const btVector3 *btCollisionObject_getAnisotropicFriction(const btCollisionObject *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getAnisotropicFriction());
}

void btCollisionObject_setAnisotropicFriction(btCollisionObject *_this, const btVector3 *anisotropicFriction, const int *frictionMode)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setAnisotropicFriction(
        ((anisotropicFriction ? void() : MRBINDC_THROW("Parameter `anisotropicFriction` can not be null.", void)), *(const btVector3 *)(anisotropicFriction)),
        (frictionMode ? *frictionMode : static_cast<int>(btCollisionObject::CF_ANISOTROPIC_FRICTION))
    );
}

bool btCollisionObject_hasAnisotropicFriction(const btCollisionObject *_this, const int *frictionMode)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).hasAnisotropicFriction(
        (frictionMode ? *frictionMode : static_cast<int>(btCollisionObject::CF_ANISOTROPIC_FRICTION))
    );
}

void btCollisionObject_setContactProcessingThreshold(btCollisionObject *_this, double contactProcessingThreshold)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setContactProcessingThreshold(
        contactProcessingThreshold
    );
}

double btCollisionObject_getContactProcessingThreshold(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getContactProcessingThreshold();
}

bool btCollisionObject_isStaticObject(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).isStaticObject();
}

bool btCollisionObject_isKinematicObject(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).isKinematicObject();
}

bool btCollisionObject_isStaticOrKinematicObject(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).isStaticOrKinematicObject();
}

bool btCollisionObject_hasContactResponse(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).hasContactResponse();
}

void btCollisionObject_setCollisionShape(btCollisionObject *_this, btCollisionShape *collisionShape)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setCollisionShape(
        ((btCollisionShape *)collisionShape)
    );
}

const btCollisionShape *btCollisionObject_getCollisionShape(const btCollisionObject *_this)
{
    return (const btCollisionShape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getCollisionShape());
}

btCollisionShape *btCollisionObject_getCollisionShape_mut(btCollisionObject *_this)
{
    return (btCollisionShape *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).getCollisionShape());
}

void btCollisionObject_setIgnoreCollisionCheck(btCollisionObject *_this, const btCollisionObject *co, bool ignoreCollisionCheck)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setIgnoreCollisionCheck(
        ((const btCollisionObject *)co),
        ignoreCollisionCheck
    );
}

int btCollisionObject_getNumObjectsWithoutCollision(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getNumObjectsWithoutCollision();
}

const btCollisionObject *btCollisionObject_getObjectWithoutCollision(btCollisionObject *_this, int index)
{
    return (const btCollisionObject *)(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).getObjectWithoutCollision(
        index
    ));
}

bool btCollisionObject_checkCollideWithOverride(const btCollisionObject *_this, const btCollisionObject *co)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).checkCollideWithOverride(
        ((const btCollisionObject *)co)
    );
}

void *btCollisionObject_internalGetExtensionPointer(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).internalGetExtensionPointer();
}

void btCollisionObject_internalSetExtensionPointer(btCollisionObject *_this, void *pointer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).internalSetExtensionPointer(
        pointer
    );
}

int btCollisionObject_getActivationState(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getActivationState();
}

void btCollisionObject_setActivationState(const btCollisionObject *_this, int newState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).setActivationState(
        newState
    );
}

void btCollisionObject_setDeactivationTime(btCollisionObject *_this, double time)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setDeactivationTime(
        time
    );
}

double btCollisionObject_getDeactivationTime(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getDeactivationTime();
}

void btCollisionObject_forceActivationState(const btCollisionObject *_this, int newState)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).forceActivationState(
        newState
    );
}

void btCollisionObject_activate(const btCollisionObject *_this, const bool *forceActivation)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).activate(
        (forceActivation ? *forceActivation : static_cast<bool>(false))
    );
}

bool btCollisionObject_isActive(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).isActive();
}

void btCollisionObject_setRestitution(btCollisionObject *_this, double rest)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setRestitution(
        rest
    );
}

double btCollisionObject_getRestitution(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getRestitution();
}

void btCollisionObject_setFriction(btCollisionObject *_this, double frict)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setFriction(
        frict
    );
}

double btCollisionObject_getFriction(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getFriction();
}

void btCollisionObject_setRollingFriction(btCollisionObject *_this, double frict)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setRollingFriction(
        frict
    );
}

double btCollisionObject_getRollingFriction(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getRollingFriction();
}

void btCollisionObject_setSpinningFriction(btCollisionObject *_this, double frict)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setSpinningFriction(
        frict
    );
}

double btCollisionObject_getSpinningFriction(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getSpinningFriction();
}

void btCollisionObject_setContactStiffnessAndDamping(btCollisionObject *_this, double stiffness, double damping)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setContactStiffnessAndDamping(
        stiffness,
        damping
    );
}

double btCollisionObject_getContactStiffness(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getContactStiffness();
}

double btCollisionObject_getContactDamping(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getContactDamping();
}

int btCollisionObject_getInternalType(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getInternalType();
}

btTransform *btCollisionObject_getWorldTransform_mut(btCollisionObject *_this)
{
    return (btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).getWorldTransform());
}

const btTransform *btCollisionObject_getWorldTransform(const btCollisionObject *_this)
{
    return (const btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getWorldTransform());
}

void btCollisionObject_setWorldTransform(btCollisionObject *_this, const btTransform *worldTrans)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setWorldTransform(
        ((worldTrans ? void() : MRBINDC_THROW("Parameter `worldTrans` can not be null.", void)), *(const btTransform *)(worldTrans))
    );
}

const btTransform *btCollisionObject_getInterpolationWorldTransform(const btCollisionObject *_this)
{
    return (const btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getInterpolationWorldTransform());
}

btTransform *btCollisionObject_getInterpolationWorldTransform_mut(btCollisionObject *_this)
{
    return (btTransform *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).getInterpolationWorldTransform());
}

void btCollisionObject_setInterpolationWorldTransform(btCollisionObject *_this, const btTransform *trans)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setInterpolationWorldTransform(
        ((trans ? void() : MRBINDC_THROW("Parameter `trans` can not be null.", void)), *(const btTransform *)(trans))
    );
}

void btCollisionObject_setInterpolationLinearVelocity(btCollisionObject *_this, const btVector3 *linvel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setInterpolationLinearVelocity(
        ((linvel ? void() : MRBINDC_THROW("Parameter `linvel` can not be null.", void)), *(const btVector3 *)(linvel))
    );
}

void btCollisionObject_setInterpolationAngularVelocity(btCollisionObject *_this, const btVector3 *angvel)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setInterpolationAngularVelocity(
        ((angvel ? void() : MRBINDC_THROW("Parameter `angvel` can not be null.", void)), *(const btVector3 *)(angvel))
    );
}

const btVector3 *btCollisionObject_getInterpolationLinearVelocity(const btCollisionObject *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getInterpolationLinearVelocity());
}

const btVector3 *btCollisionObject_getInterpolationAngularVelocity(const btCollisionObject *_this)
{
    return (const btVector3 *)std::addressof(((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getInterpolationAngularVelocity());
}

int btCollisionObject_getIslandTag(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getIslandTag();
}

void btCollisionObject_setIslandTag(btCollisionObject *_this, int tag)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setIslandTag(
        tag
    );
}

int btCollisionObject_getCompanionId(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getCompanionId();
}

void btCollisionObject_setCompanionId(btCollisionObject *_this, int id)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setCompanionId(
        id
    );
}

int btCollisionObject_getWorldArrayIndex(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getWorldArrayIndex();
}

void btCollisionObject_setWorldArrayIndex(btCollisionObject *_this, int ix)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setWorldArrayIndex(
        ix
    );
}

double btCollisionObject_getHitFraction(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getHitFraction();
}

void btCollisionObject_setHitFraction(btCollisionObject *_this, double hitFraction)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setHitFraction(
        hitFraction
    );
}

int btCollisionObject_getCollisionFlags(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getCollisionFlags();
}

void btCollisionObject_setCollisionFlags(btCollisionObject *_this, int flags)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setCollisionFlags(
        flags
    );
}

double btCollisionObject_getCcdSweptSphereRadius(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getCcdSweptSphereRadius();
}

void btCollisionObject_setCcdSweptSphereRadius(btCollisionObject *_this, double radius)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setCcdSweptSphereRadius(
        radius
    );
}

double btCollisionObject_getCcdMotionThreshold(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getCcdMotionThreshold();
}

double btCollisionObject_getCcdSquareMotionThreshold(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getCcdSquareMotionThreshold();
}

void btCollisionObject_setCcdMotionThreshold(btCollisionObject *_this, double ccdMotionThreshold)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setCcdMotionThreshold(
        ccdMotionThreshold
    );
}

void *btCollisionObject_getUserPointer(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getUserPointer();
}

int btCollisionObject_getUserIndex(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getUserIndex();
}

int btCollisionObject_getUserIndex2(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getUserIndex2();
}

int btCollisionObject_getUserIndex3(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getUserIndex3();
}

void btCollisionObject_setUserPointer(btCollisionObject *_this, void *userPointer)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setUserPointer(
        userPointer
    );
}

void btCollisionObject_setUserIndex(btCollisionObject *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setUserIndex(
        index
    );
}

void btCollisionObject_setUserIndex2(btCollisionObject *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setUserIndex2(
        index
    );
}

void btCollisionObject_setUserIndex3(btCollisionObject *_this, int index)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setUserIndex3(
        index
    );
}

int btCollisionObject_getUpdateRevisionInternal(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getUpdateRevisionInternal();
}

void btCollisionObject_setCustomDebugColor(btCollisionObject *_this, const btVector3 *colorRGB)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).setCustomDebugColor(
        ((colorRGB ? void() : MRBINDC_THROW("Parameter `colorRGB` can not be null.", void)), *(const btVector3 *)(colorRGB))
    );
}

void btCollisionObject_removeCustomDebugColor(btCollisionObject *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btCollisionObject *)(_this)).removeCustomDebugColor();
}

bool btCollisionObject_getCustomDebugColor(const btCollisionObject *_this, btVector3 *colorRGB)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).getCustomDebugColor(
        ((colorRGB ? void() : MRBINDC_THROW("Parameter `colorRGB` can not be null.", void)), *(btVector3 *)(colorRGB))
    );
}

bool btCollisionObject_checkCollideWith(const btCollisionObject *_this, const btCollisionObject *co)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).checkCollideWith(
        ((const btCollisionObject *)co)
    );
}

int btCollisionObject_calculateSerializeBufferSize(const btCollisionObject *_this)
{
    return ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(const btCollisionObject *)(_this)).calculateSerializeBufferSize();
}

