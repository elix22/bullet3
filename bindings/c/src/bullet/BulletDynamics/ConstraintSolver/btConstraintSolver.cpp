// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "bullet/BulletDynamics/ConstraintSolver/btConstraintSolver.h"

#include <BulletDynamics/ConstraintSolver/btConstraintSolver.h>
#include <__mrbind_c_details.h>

#include <cstddef>
#include <stdexcept>


void btConstraintSolver_Destroy(const btConstraintSolver *_this)
{
    delete ((const btConstraintSolver *)_this);
}

void btConstraintSolver_DestroyArray(const btConstraintSolver *_this)
{
    delete[] ((const btConstraintSolver *)_this);
}

void btConstraintSolver_prepareSolve(btConstraintSolver *_this, int _1, int _2)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConstraintSolver *)(_this)).prepareSolve(
        _1,
        _2
    );
}

void btConstraintSolver_reset(btConstraintSolver *_this)
{
    ((_this ? void() : MRBINDC_THROW("Parameter `_this` can not be null.", void)), *(btConstraintSolver *)(_this)).reset();
}

const btConstraintSolver *btConstraintSolver_OffsetPtr(const btConstraintSolver *ptr, ptrdiff_t i)
{
    return (const btConstraintSolver *)(((const btConstraintSolver *)ptr) + i);
}

btConstraintSolver *btConstraintSolver_OffsetMutablePtr(btConstraintSolver *ptr, ptrdiff_t i)
{
    return (btConstraintSolver *)(((btConstraintSolver *)ptr) + i);
}

