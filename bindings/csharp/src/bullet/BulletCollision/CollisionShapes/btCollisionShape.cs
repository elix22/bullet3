// machine generated, do not edit
public static partial class Bullet
{
    ///The btCollisionShape class provides an interface for collision shapes that can be shared among btCollisionObjects.
    /// Generated from class `btCollisionShape`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btConvexShape`
    ///   Indirect: (non-virtual)
    ///     `btBoxShape`
    ///     `btCapsuleShape`
    ///     `btConvexInternalAabbCachingShape`
    ///     `btConvexInternalShape`
    ///     `btPolyhedralConvexAabbCachingShape`
    ///     `btPolyhedralConvexShape`
    ///     `btSphereShape`
    /// This is the const half of the class.
    public class Const_BtCollisionShape : Bullet.Object<Const_BtCollisionShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_Destroy(_Underlying *_this);
            __btCollisionShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtCollisionShape() {Dispose(false);}

        internal unsafe Const_BtCollisionShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btCollisionShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btCollisionShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btCollisionShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btCollisionShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btCollisionShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btCollisionShape::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btCollisionShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btCollisionShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btCollisionShape_void_ptr(void *ptr);
            __Bullet_delete_btCollisionShape_void_ptr(ptr);
        }

        /// Generated from method `btCollisionShape::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btCollisionShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btCollisionShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btCollisionShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btCollisionShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btCollisionShape::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btCollisionShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btCollisionShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btCollisionShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btCollisionShape_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btCollisionShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btCollisionShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btCollisionShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btCollisionShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btCollisionShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btCollisionShape::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btCollisionShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btCollisionShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btCollisionShape_void_ptr(void *ptr);
            __Bullet_delete_array_btCollisionShape_void_ptr(ptr);
        }

        /// Generated from method `btCollisionShape::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btCollisionShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btCollisionShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btCollisionShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btCollisionShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btCollisionShape::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btCollisionShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btCollisionShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btCollisionShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btCollisionShape_void_ptr_void_ptr(_1, _2);
        }

        ///getAabb returns the axis aligned bounding box in the coordinate frame of the given transform t.
        /// Generated from method `btCollisionShape::getAabb`.
        public unsafe void GetAabb(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_getAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btCollisionShape_getAabb(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btCollisionShape::getBoundingSphere`.
        public unsafe void GetBoundingSphere(Bullet.BtVector3 center, ref double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_getBoundingSphere(_Underlying *_this, Bullet.BtVector3._Underlying *center, double *radius);
            fixed (double *__ptr_radius = &radius)
            {
                __btCollisionShape_getBoundingSphere(_UnderlyingPtr, center._UnderlyingPtr, __ptr_radius);
            }
        }

        ///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
        /// Generated from method `btCollisionShape::getAngularMotionDisc`.
        public unsafe double GetAngularMotionDisc()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionShape_getAngularMotionDisc(_Underlying *_this);
            return __btCollisionShape_getAngularMotionDisc(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionShape::getContactBreakingThreshold`.
        public unsafe double GetContactBreakingThreshold(double defaultContactThresholdFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionShape_getContactBreakingThreshold(_Underlying *_this, double defaultContactThresholdFactor);
            return __btCollisionShape_getContactBreakingThreshold(_UnderlyingPtr, defaultContactThresholdFactor);
        }

        ///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
        ///result is conservative
        /// Generated from method `btCollisionShape::calculateTemporalAabb`.
        public unsafe void CalculateTemporalAabb(Bullet.Const_BtTransform curTrans, Bullet.Const_BtVector3 linvel, Bullet.Const_BtVector3 angvel, double timeStep, Bullet.BtVector3 temporalAabbMin, Bullet.BtVector3 temporalAabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_calculateTemporalAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *curTrans, Bullet.Const_BtVector3._Underlying *linvel, Bullet.Const_BtVector3._Underlying *angvel, double timeStep, Bullet.BtVector3._Underlying *temporalAabbMin, Bullet.BtVector3._Underlying *temporalAabbMax);
            __btCollisionShape_calculateTemporalAabb(_UnderlyingPtr, curTrans._UnderlyingPtr, linvel._UnderlyingPtr, angvel._UnderlyingPtr, timeStep, temporalAabbMin._UnderlyingPtr, temporalAabbMax._UnderlyingPtr);
        }

        /// Generated from method `btCollisionShape::isPolyhedral`.
        public unsafe bool IsPolyhedral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionShape_isPolyhedral(_Underlying *_this);
            return __btCollisionShape_isPolyhedral(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionShape::isConvex2d`.
        public unsafe bool IsConvex2d()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionShape_isConvex2d(_Underlying *_this);
            return __btCollisionShape_isConvex2d(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionShape::isConvex`.
        public unsafe bool IsConvex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionShape_isConvex(_Underlying *_this);
            return __btCollisionShape_isConvex(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionShape::isNonMoving`.
        public unsafe bool IsNonMoving()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionShape_isNonMoving(_Underlying *_this);
            return __btCollisionShape_isNonMoving(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionShape::isConcave`.
        public unsafe bool IsConcave()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionShape_isConcave(_Underlying *_this);
            return __btCollisionShape_isConcave(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionShape::isCompound`.
        public unsafe bool IsCompound()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionShape_isCompound(_Underlying *_this);
            return __btCollisionShape_isCompound(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionShape::isSoftBody`.
        public unsafe bool IsSoftBody()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionShape_isSoftBody(_Underlying *_this);
            return __btCollisionShape_isSoftBody(_UnderlyingPtr) != 0;
        }

        ///isInfinite is used to catch simulation error (aabb check)
        /// Generated from method `btCollisionShape::isInfinite`.
        public unsafe bool IsInfinite()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionShape_isInfinite(_Underlying *_this);
            return __btCollisionShape_isInfinite(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionShape::getLocalScaling`.
        public unsafe Bullet.Const_BtVector3 GetLocalScaling()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btCollisionShape_getLocalScaling(_Underlying *_this);
            return new(__btCollisionShape_getLocalScaling(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCollisionShape::calculateLocalInertia`.
        public unsafe void CalculateLocalInertia(double mass, Bullet.BtVector3 inertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_calculateLocalInertia(_Underlying *_this, double mass, Bullet.BtVector3._Underlying *inertia);
            __btCollisionShape_calculateLocalInertia(_UnderlyingPtr, mass, inertia._UnderlyingPtr);
        }

        //debugging support
        /// Generated from method `btCollisionShape::getName`.
        public unsafe byte? GetName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__btCollisionShape_getName(_Underlying *_this);
            var __c_ret = __btCollisionShape_getName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btCollisionShape::getShapeType`.
        public unsafe int GetShapeType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionShape_getShapeType(_Underlying *_this);
            return __btCollisionShape_getShapeType(_UnderlyingPtr);
        }

        ///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
        ///See Bullet/Demos/RollingFrictionDemo for an example
        /// Generated from method `btCollisionShape::getAnisotropicRollingFrictionDirection`.
        public unsafe Bullet.BtVector3 GetAnisotropicRollingFrictionDirection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btCollisionShape_getAnisotropicRollingFrictionDirection(_Underlying *_this);
            return new(__btCollisionShape_getAnisotropicRollingFrictionDirection(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btCollisionShape::getMargin`.
        public unsafe double GetMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionShape_getMargin(_Underlying *_this);
            return __btCollisionShape_getMargin(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionShape::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btCollisionShape_getUserPointer(_Underlying *_this);
            return __btCollisionShape_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionShape::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionShape_getUserIndex(_Underlying *_this);
            return __btCollisionShape_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionShape::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionShape_getUserIndex2(_Underlying *_this);
            return __btCollisionShape_getUserIndex2(_UnderlyingPtr);
        }

        // clang-format on
        /// Generated from method `btCollisionShape::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionShape_calculateSerializeBufferSize(_Underlying *_this);
            return __btCollisionShape_calculateSerializeBufferSize(_UnderlyingPtr);
        }
    }

    ///The btCollisionShape class provides an interface for collision shapes that can be shared among btCollisionObjects.
    /// Generated from class `btCollisionShape`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btConvexShape`
    ///   Indirect: (non-virtual)
    ///     `btBoxShape`
    ///     `btCapsuleShape`
    ///     `btConvexInternalAabbCachingShape`
    ///     `btConvexInternalShape`
    ///     `btPolyhedralConvexAabbCachingShape`
    ///     `btPolyhedralConvexShape`
    ///     `btSphereShape`
    /// This is the non-const half of the class.
    public class BtCollisionShape : Const_BtCollisionShape
    {
        internal unsafe BtCollisionShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from method `btCollisionShape::setLocalScaling`.
        public unsafe void SetLocalScaling(Bullet.Const_BtVector3 scaling)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_setLocalScaling(_Underlying *_this, Bullet.Const_BtVector3._Underlying *scaling);
            __btCollisionShape_setLocalScaling(_UnderlyingPtr, scaling._UnderlyingPtr);
        }

        /// Generated from method `btCollisionShape::setMargin`.
        public unsafe void SetMargin(double margin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_setMargin(_Underlying *_this, double margin);
            __btCollisionShape_setMargin(_UnderlyingPtr, margin);
        }

        ///optional user data pointer
        /// Generated from method `btCollisionShape::setUserPointer`.
        /// Parameter `userPtr` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPtr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_setUserPointer(_Underlying *_this, void *userPtr);
            __btCollisionShape_setUserPointer(_UnderlyingPtr, userPtr);
        }

        /// Generated from method `btCollisionShape::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_setUserIndex(_Underlying *_this, int index);
            __btCollisionShape_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btCollisionShape::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionShape_setUserIndex2(_Underlying *_this, int index);
            __btCollisionShape_setUserIndex2(_UnderlyingPtr, index);
        }
    }

    /// This is used for optional parameters of class `BtCollisionShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtCollisionShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionShape`/`Const_BtCollisionShape` directly.
    public class _InOptMut_BtCollisionShape
    {
        public BtCollisionShape? Opt;

        public _InOptMut_BtCollisionShape() {}
        public _InOptMut_BtCollisionShape(BtCollisionShape value) {Opt = value;}
        public static implicit operator _InOptMut_BtCollisionShape(BtCollisionShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtCollisionShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtCollisionShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionShape`/`Const_BtCollisionShape` to pass it to the function.
    public class _InOptConst_BtCollisionShape
    {
        public Const_BtCollisionShape? Opt;

        public _InOptConst_BtCollisionShape() {}
        public _InOptConst_BtCollisionShape(Const_BtCollisionShape value) {Opt = value;}
        public static implicit operator _InOptConst_BtCollisionShape(Const_BtCollisionShape value) {return new(value);}
    }
}
