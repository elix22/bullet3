// machine generated, do not edit
public static partial class Bullet
{
    ///The btBroadphaseInterface class provides an interface to detect aabb-overlapping object pairs.
    ///Some implementations for this broadphase interface include btAxisSweep3, bt32BitAxisSweep3 and btDbvtBroadphase.
    ///The actual overlapping pair management, storage, adding and removing of pairs is dealt by the btOverlappingPairCache class.
    /// Generated from class `btBroadphaseInterface`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDbvtBroadphase`
    /// This is the const half of the class.
    public class Const_BtBroadphaseInterface : Bullet.Object<Const_BtBroadphaseInterface>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBroadphaseInterface_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBroadphaseInterface_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBroadphaseInterface_Destroy(_Underlying *_this);
            __btBroadphaseInterface_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtBroadphaseInterface() {Dispose(false);}

        internal unsafe Const_BtBroadphaseInterface(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btBroadphaseInterface::getOverlappingPairCache`.
        public unsafe Bullet.Const_BtOverlappingPairCache? GetOverlappingPairCache()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBroadphaseInterface_getOverlappingPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBroadphaseInterface_getOverlappingPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtOverlappingPairCache._Underlying *__btBroadphaseInterface_getOverlappingPairCache(_Underlying *_this);
            var __c_ret = __btBroadphaseInterface_getOverlappingPairCache(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Const_BtOverlappingPairCache(__c_ret, is_owning: false) : null;
        }

        ///getAabb returns the axis aligned bounding box in the 'global' coordinate frame
        ///will add some transform later
        /// Generated from method `btBroadphaseInterface::getBroadphaseAabb`.
        public unsafe void GetBroadphaseAabb(Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBroadphaseInterface_getBroadphaseAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBroadphaseInterface_getBroadphaseAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBroadphaseInterface_getBroadphaseAabb(_Underlying *_this, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btBroadphaseInterface_getBroadphaseAabb(_UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }
    }

    ///The btBroadphaseInterface class provides an interface to detect aabb-overlapping object pairs.
    ///Some implementations for this broadphase interface include btAxisSweep3, bt32BitAxisSweep3 and btDbvtBroadphase.
    ///The actual overlapping pair management, storage, adding and removing of pairs is dealt by the btOverlappingPairCache class.
    /// Generated from class `btBroadphaseInterface`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDbvtBroadphase`
    /// This is the non-const half of the class.
    public class BtBroadphaseInterface : Const_BtBroadphaseInterface
    {
        internal unsafe BtBroadphaseInterface(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        ///calculateOverlappingPairs is optional: incremental algorithms (sweep and prune) might do it during the set aabb
        /// Generated from method `btBroadphaseInterface::calculateOverlappingPairs`.
        public unsafe void CalculateOverlappingPairs(Bullet.BtDispatcher? dispatcher)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBroadphaseInterface_calculateOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBroadphaseInterface_calculateOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBroadphaseInterface_calculateOverlappingPairs(_Underlying *_this, Bullet.BtDispatcher._Underlying *dispatcher);
            __btBroadphaseInterface_calculateOverlappingPairs(_UnderlyingPtr, dispatcher is not null ? dispatcher._UnderlyingPtr : null);
        }

        /// Generated from method `btBroadphaseInterface::getOverlappingPairCache`.
        public unsafe new Bullet.BtOverlappingPairCache? GetOverlappingPairCache()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBroadphaseInterface_getOverlappingPairCache_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBroadphaseInterface_getOverlappingPairCache_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtOverlappingPairCache._Underlying *__btBroadphaseInterface_getOverlappingPairCache_mut(_Underlying *_this);
            var __c_ret = __btBroadphaseInterface_getOverlappingPairCache_mut(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtOverlappingPairCache(__c_ret, is_owning: false) : null;
        }

        ///reset broadphase internal structures, to ensure determinism/reproducability
        /// Generated from method `btBroadphaseInterface::resetPool`.
        public unsafe void ResetPool(Bullet.BtDispatcher? dispatcher)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBroadphaseInterface_resetPool", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBroadphaseInterface_resetPool", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBroadphaseInterface_resetPool(_Underlying *_this, Bullet.BtDispatcher._Underlying *dispatcher);
            __btBroadphaseInterface_resetPool(_UnderlyingPtr, dispatcher is not null ? dispatcher._UnderlyingPtr : null);
        }

        /// Generated from method `btBroadphaseInterface::printStats`.
        public unsafe void PrintStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBroadphaseInterface_printStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBroadphaseInterface_printStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBroadphaseInterface_printStats(_Underlying *_this);
            __btBroadphaseInterface_printStats(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `BtBroadphaseInterface` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtBroadphaseInterface`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtBroadphaseInterface`/`Const_BtBroadphaseInterface` directly.
    public class _InOptMut_BtBroadphaseInterface
    {
        public BtBroadphaseInterface? Opt;

        public _InOptMut_BtBroadphaseInterface() {}
        public _InOptMut_BtBroadphaseInterface(BtBroadphaseInterface value) {Opt = value;}
        public static implicit operator _InOptMut_BtBroadphaseInterface(BtBroadphaseInterface value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtBroadphaseInterface` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtBroadphaseInterface`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtBroadphaseInterface`/`Const_BtBroadphaseInterface` to pass it to the function.
    public class _InOptConst_BtBroadphaseInterface
    {
        public Const_BtBroadphaseInterface? Opt;

        public _InOptConst_BtBroadphaseInterface() {}
        public _InOptConst_BtBroadphaseInterface(Const_BtBroadphaseInterface value) {Opt = value;}
        public static implicit operator _InOptConst_BtBroadphaseInterface(Const_BtBroadphaseInterface value) {return new(value);}
    }
}
