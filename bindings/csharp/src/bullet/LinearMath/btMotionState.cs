// machine generated, do not edit
public static partial class Bullet
{
    ///The btMotionState interface class allows the dynamics world to synchronize and interpolate the updated world transforms with graphics
    ///For optimizations, potentially only moving objects get synchronized (using setWorldPosition/setWorldOrientation)
    /// Generated from class `btMotionState`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDefaultMotionState`
    /// This is the const half of the class.
    public class Const_BtMotionState : Bullet.Object<Const_BtMotionState>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMotionState_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMotionState_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMotionState_Destroy(_Underlying *_this);
            __btMotionState_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtMotionState() {Dispose(false);}

        internal unsafe Const_BtMotionState(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btMotionState::getWorldTransform`.
        public unsafe void GetWorldTransform(Bullet.BtTransform worldTrans)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMotionState_getWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMotionState_getWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMotionState_getWorldTransform(_Underlying *_this, Bullet.BtTransform._Underlying *worldTrans);
            __btMotionState_getWorldTransform(_UnderlyingPtr, worldTrans._UnderlyingPtr);
        }
    }

    ///The btMotionState interface class allows the dynamics world to synchronize and interpolate the updated world transforms with graphics
    ///For optimizations, potentially only moving objects get synchronized (using setWorldPosition/setWorldOrientation)
    /// Generated from class `btMotionState`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDefaultMotionState`
    /// This is the non-const half of the class.
    public class BtMotionState : Const_BtMotionState
    {
        internal unsafe BtMotionState(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        //Bullet only calls the update of worldtransform for active objects
        /// Generated from method `btMotionState::setWorldTransform`.
        public unsafe void SetWorldTransform(Bullet.Const_BtTransform worldTrans)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMotionState_setWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMotionState_setWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMotionState_setWorldTransform(_Underlying *_this, Bullet.Const_BtTransform._Underlying *worldTrans);
            __btMotionState_setWorldTransform(_UnderlyingPtr, worldTrans._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `BtMotionState` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtMotionState`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtMotionState`/`Const_BtMotionState` directly.
    public class _InOptMut_BtMotionState
    {
        public BtMotionState? Opt;

        public _InOptMut_BtMotionState() {}
        public _InOptMut_BtMotionState(BtMotionState value) {Opt = value;}
        public static implicit operator _InOptMut_BtMotionState(BtMotionState value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtMotionState` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtMotionState`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtMotionState`/`Const_BtMotionState` to pass it to the function.
    public class _InOptConst_BtMotionState
    {
        public Const_BtMotionState? Opt;

        public _InOptConst_BtMotionState() {}
        public _InOptConst_BtMotionState(Const_BtMotionState value) {Opt = value;}
        public static implicit operator _InOptConst_BtMotionState(Const_BtMotionState value) {return new(value);}
    }
}
