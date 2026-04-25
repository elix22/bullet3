// machine generated, do not edit
public static partial class Bullet
{
    ///The btDispatcher interface class can be used in combination with broadphase to dispatch calculations for overlapping pairs.
    ///For example for pairwise collision detection, calculating contact points stored in btPersistentManifold or user callbacks (game logic).
    /// Generated from class `btDispatcher`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionDispatcher`
    ///   Indirect: (non-virtual)
    ///     `btCollisionDispatcherMt`
    /// This is the const half of the class.
    public class Const_BtDispatcher : Bullet.Object<Const_BtDispatcher>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDispatcher_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDispatcher_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDispatcher_Destroy(_Underlying *_this);
            __btDispatcher_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtDispatcher() {Dispose(false);}

        internal unsafe Const_BtDispatcher(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btDispatcher::getNumManifolds`.
        public unsafe int GetNumManifolds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDispatcher_getNumManifolds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDispatcher_getNumManifolds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDispatcher_getNumManifolds(_Underlying *_this);
            return __btDispatcher_getNumManifolds(_UnderlyingPtr);
        }
    }

    ///The btDispatcher interface class can be used in combination with broadphase to dispatch calculations for overlapping pairs.
    ///For example for pairwise collision detection, calculating contact points stored in btPersistentManifold or user callbacks (game logic).
    /// Generated from class `btDispatcher`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionDispatcher`
    ///   Indirect: (non-virtual)
    ///     `btCollisionDispatcherMt`
    /// This is the non-const half of the class.
    public class BtDispatcher : Const_BtDispatcher
    {
        internal unsafe BtDispatcher(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from method `btDispatcher::needsCollision`.
        public unsafe bool NeedsCollision(Bullet.Const_BtCollisionObject? body0, Bullet.Const_BtCollisionObject? body1)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDispatcher_needsCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDispatcher_needsCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDispatcher_needsCollision(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *body0, Bullet.Const_BtCollisionObject._Underlying *body1);
            return __btDispatcher_needsCollision(_UnderlyingPtr, body0 is not null ? body0._UnderlyingPtr : null, body1 is not null ? body1._UnderlyingPtr : null) != 0;
        }

        /// Generated from method `btDispatcher::needsResponse`.
        public unsafe bool NeedsResponse(Bullet.Const_BtCollisionObject? body0, Bullet.Const_BtCollisionObject? body1)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDispatcher_needsResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDispatcher_needsResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDispatcher_needsResponse(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *body0, Bullet.Const_BtCollisionObject._Underlying *body1);
            return __btDispatcher_needsResponse(_UnderlyingPtr, body0 is not null ? body0._UnderlyingPtr : null, body1 is not null ? body1._UnderlyingPtr : null) != 0;
        }

        /// Generated from method `btDispatcher::allocateCollisionAlgorithm`.
        /// Returns a mutable pointer.
        public unsafe void *AllocateCollisionAlgorithm(int size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDispatcher_allocateCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDispatcher_allocateCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btDispatcher_allocateCollisionAlgorithm(_Underlying *_this, int size);
            return __btDispatcher_allocateCollisionAlgorithm(_UnderlyingPtr, size);
        }

        /// Generated from method `btDispatcher::freeCollisionAlgorithm`.
        /// Parameter `ptr` is a mutable pointer.
        public unsafe void FreeCollisionAlgorithm(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDispatcher_freeCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDispatcher_freeCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDispatcher_freeCollisionAlgorithm(_Underlying *_this, void *ptr);
            __btDispatcher_freeCollisionAlgorithm(_UnderlyingPtr, ptr);
        }
    }

    /// This is used for optional parameters of class `BtDispatcher` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtDispatcher`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDispatcher`/`Const_BtDispatcher` directly.
    public class _InOptMut_BtDispatcher
    {
        public BtDispatcher? Opt;

        public _InOptMut_BtDispatcher() {}
        public _InOptMut_BtDispatcher(BtDispatcher value) {Opt = value;}
        public static implicit operator _InOptMut_BtDispatcher(BtDispatcher value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtDispatcher` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtDispatcher`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDispatcher`/`Const_BtDispatcher` to pass it to the function.
    public class _InOptConst_BtDispatcher
    {
        public Const_BtDispatcher? Opt;

        public _InOptConst_BtDispatcher() {}
        public _InOptConst_BtDispatcher(Const_BtDispatcher value) {Opt = value;}
        public static implicit operator _InOptConst_BtDispatcher(Const_BtDispatcher value) {return new(value);}
    }
}
