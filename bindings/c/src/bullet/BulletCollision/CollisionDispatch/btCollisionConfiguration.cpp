// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletCollision/CollisionDispatch/btCollisionConfiguration.h"

#include <BulletCollision/CollisionDispatch/btCollisionConfiguration.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void btCollisionConfiguration_Destroy(const btCollisionConfiguration *_this)
{
    delete ((const btCollisionConfiguration *)_this);
}

void btCollisionConfiguration_DestroyArray(const btCollisionConfiguration *_this)
{
    delete[] ((const btCollisionConfiguration *)_this);
}

const btCollisionConfiguration *btCollisionConfiguration_OffsetPtr(const btCollisionConfiguration *ptr, ptrdiff_t i)
{
    return (const btCollisionConfiguration *)(((const btCollisionConfiguration *)ptr) + i);
}

btCollisionConfiguration *btCollisionConfiguration_OffsetMutablePtr(btCollisionConfiguration *ptr, ptrdiff_t i)
{
    return (btCollisionConfiguration *)(((btCollisionConfiguration *)ptr) + i);
}

