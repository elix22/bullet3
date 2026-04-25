// machine generated, do not edit
public static partial class Bullet
{
    ///The btOverlappingPairCache provides an interface for overlapping pair management (add, remove, storage), used by the btBroadphaseInterface broadphases.
    ///The btHashedOverlappingPairCache and btSortedOverlappingPairCache classes are two implementations.
    /// Generated from class `btOverlappingPairCache`.
    /// This is the const half of the class.
    public class Const_BtOverlappingPairCache : Bullet.Object<Const_BtOverlappingPairCache>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btOverlappingPairCache_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btOverlappingPairCache_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btOverlappingPairCache_Destroy(_Underlying *_this);
            __btOverlappingPairCache_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtOverlappingPairCache() {Dispose(false);}

        internal unsafe Const_BtOverlappingPairCache(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btOverlappingPairCache::getNumOverlappingPairs`.
        public unsafe int GetNumOverlappingPairs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btOverlappingPairCache_getNumOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btOverlappingPairCache_getNumOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btOverlappingPairCache_getNumOverlappingPairs(_Underlying *_this);
            return __btOverlappingPairCache_getNumOverlappingPairs(_UnderlyingPtr);
        }
    }

    ///The btOverlappingPairCache provides an interface for overlapping pair management (add, remove, storage), used by the btBroadphaseInterface broadphases.
    ///The btHashedOverlappingPairCache and btSortedOverlappingPairCache classes are two implementations.
    /// Generated from class `btOverlappingPairCache`.
    /// This is the non-const half of the class.
    public class BtOverlappingPairCache : Const_BtOverlappingPairCache
    {
        internal unsafe BtOverlappingPairCache(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from method `btOverlappingPairCache::hasDeferredRemoval`.
        public unsafe bool HasDeferredRemoval()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btOverlappingPairCache_hasDeferredRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btOverlappingPairCache_hasDeferredRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btOverlappingPairCache_hasDeferredRemoval(_Underlying *_this);
            return __btOverlappingPairCache_hasDeferredRemoval(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btOverlappingPairCache::sortOverlappingPairs`.
        public unsafe void SortOverlappingPairs(Bullet.BtDispatcher? dispatcher)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btOverlappingPairCache_sortOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btOverlappingPairCache_sortOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btOverlappingPairCache_sortOverlappingPairs(_Underlying *_this, Bullet.BtDispatcher._Underlying *dispatcher);
            __btOverlappingPairCache_sortOverlappingPairs(_UnderlyingPtr, dispatcher is not null ? dispatcher._UnderlyingPtr : null);
        }
    }

    /// This is used for optional parameters of class `BtOverlappingPairCache` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtOverlappingPairCache`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtOverlappingPairCache`/`Const_BtOverlappingPairCache` directly.
    public class _InOptMut_BtOverlappingPairCache
    {
        public BtOverlappingPairCache? Opt;

        public _InOptMut_BtOverlappingPairCache() {}
        public _InOptMut_BtOverlappingPairCache(BtOverlappingPairCache value) {Opt = value;}
        public static implicit operator _InOptMut_BtOverlappingPairCache(BtOverlappingPairCache value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtOverlappingPairCache` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtOverlappingPairCache`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtOverlappingPairCache`/`Const_BtOverlappingPairCache` to pass it to the function.
    public class _InOptConst_BtOverlappingPairCache
    {
        public Const_BtOverlappingPairCache? Opt;

        public _InOptConst_BtOverlappingPairCache() {}
        public _InOptConst_BtOverlappingPairCache(Const_BtOverlappingPairCache value) {Opt = value;}
        public static implicit operator _InOptConst_BtOverlappingPairCache(Const_BtOverlappingPairCache value) {return new(value);}
    }
}
