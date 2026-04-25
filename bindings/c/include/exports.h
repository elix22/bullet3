// machine generated, do not edit
#pragma once

#ifndef BULLET_API
#  ifdef _WIN32
#    ifdef BULLET_BUILD_LIBRARY
#      define BULLET_API __declspec(dllexport)
#    else
#      define BULLET_API __declspec(dllimport)
#    endif
#  else
#    define BULLET_API __attribute__((__visibility__("default")))
#  endif
#endif

