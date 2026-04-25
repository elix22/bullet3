// machine generated, do not edit
public static partial class Bullet
{
    ///btCollisionConfiguration allows to configure Bullet collision detection
    ///stack allocator size, default collision algorithms and persistent manifold pool size
    ///@todo: describe the meaning
    /// Generated from class `btCollisionConfiguration`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDefaultCollisionConfiguration`
    /// This is the const half of the class.
    public class Const_BtCollisionConfiguration : Bullet.Object<Const_BtCollisionConfiguration>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionConfiguration_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionConfiguration_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionConfiguration_Destroy(_Underlying *_this);
            __btCollisionConfiguration_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtCollisionConfiguration() {Dispose(false);}

        internal unsafe Const_BtCollisionConfiguration(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}
    }

    ///btCollisionConfiguration allows to configure Bullet collision detection
    ///stack allocator size, default collision algorithms and persistent manifold pool size
    ///@todo: describe the meaning
    /// Generated from class `btCollisionConfiguration`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDefaultCollisionConfiguration`
    /// This is the non-const half of the class.
    public class BtCollisionConfiguration : Const_BtCollisionConfiguration
    {
        internal unsafe BtCollisionConfiguration(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}
    }

    /// This is used for optional parameters of class `BtCollisionConfiguration` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtCollisionConfiguration`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionConfiguration`/`Const_BtCollisionConfiguration` directly.
    public class _InOptMut_BtCollisionConfiguration
    {
        public BtCollisionConfiguration? Opt;

        public _InOptMut_BtCollisionConfiguration() {}
        public _InOptMut_BtCollisionConfiguration(BtCollisionConfiguration value) {Opt = value;}
        public static implicit operator _InOptMut_BtCollisionConfiguration(BtCollisionConfiguration value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtCollisionConfiguration` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtCollisionConfiguration`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionConfiguration`/`Const_BtCollisionConfiguration` to pass it to the function.
    public class _InOptConst_BtCollisionConfiguration
    {
        public Const_BtCollisionConfiguration? Opt;

        public _InOptConst_BtCollisionConfiguration() {}
        public _InOptConst_BtCollisionConfiguration(Const_BtCollisionConfiguration value) {Opt = value;}
        public static implicit operator _InOptConst_BtCollisionConfiguration(Const_BtCollisionConfiguration value) {return new(value);}
    }
}
