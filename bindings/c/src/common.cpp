// machine generated, do not edit
#define BULLET_BUILD_LIBRARY
#include "common.h"

#include <cstddef>


void *Bullet_Alloc(size_t num_bytes)
{
    return operator new(
        num_bytes
    );
}

void Bullet_Free(void *ptr)
{
    operator delete(
        ptr
    );
}

void *Bullet_AllocArray(size_t num_bytes)
{
    return operator new[](
        num_bytes
    );
}

void Bullet_FreeArray(void *ptr)
{
    operator delete[](
        ptr
    );
}

