// machine generated, do not edit
public static partial class Bullet
{
    ///btCollisionDispatcher supports algorithms that handle ConvexConvex and ConvexConcave collision pairs.
    ///Time of Impact, Closest Points and Penetration Depth.
    /// Generated from class `btCollisionDispatcher`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btDispatcher`
    /// This is the const half of the class.
    public class Const_BtCollisionDispatcher : Bullet.Object<Const_BtCollisionDispatcher>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionDispatcher_Destroy(_Underlying *_this);
            __btCollisionDispatcher_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtCollisionDispatcher() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtDispatcher(Const_BtCollisionDispatcher self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_UpcastTo_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_UpcastTo_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtDispatcher._Underlying *__btCollisionDispatcher_UpcastTo_btDispatcher(_Underlying *_this);
            Bullet.Const_BtDispatcher ret = new(__btCollisionDispatcher_UpcastTo_btDispatcher(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtCollisionDispatcher?(Bullet.Const_BtDispatcher parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_DynamicDowncastFrom_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_DynamicDowncastFrom_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCollisionDispatcher_DynamicDowncastFrom_btDispatcher(Bullet.Const_BtDispatcher._Underlying *_this);
            var ptr = __btCollisionDispatcher_DynamicDowncastFrom_btDispatcher(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtCollisionDispatcher ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtCollisionDispatcher(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public unsafe Const_BtCollisionDispatcher(Bullet._ByValue_BtCollisionDispatcher _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcher._Underlying *__btCollisionDispatcher_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionDispatcher._Underlying *_other);
            _UnderlyingPtr = __btCollisionDispatcher_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public Const_BtCollisionDispatcher(Const_BtCollisionDispatcher _other) : this(new _ByValue_BtCollisionDispatcher(_other)) {}

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public Const_BtCollisionDispatcher(BtCollisionDispatcher _other) : this((Const_BtCollisionDispatcher)_other) {}

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public unsafe Const_BtCollisionDispatcher(Bullet.BtCollisionConfiguration? collisionConfiguration) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcher._Underlying *__btCollisionDispatcher_Construct(Bullet.BtCollisionConfiguration._Underlying *collisionConfiguration);
            _UnderlyingPtr = __btCollisionDispatcher_Construct(collisionConfiguration is not null ? collisionConfiguration._UnderlyingPtr : null);
        }

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public static unsafe implicit operator Const_BtCollisionDispatcher(Bullet.BtCollisionConfiguration? collisionConfiguration) {return new(collisionConfiguration);}

        /// Generated from method `btCollisionDispatcher::getDispatcherFlags`.
        public unsafe int GetDispatcherFlags()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_getDispatcherFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_getDispatcherFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionDispatcher_getDispatcherFlags(_Underlying *_this);
            return __btCollisionDispatcher_getDispatcherFlags(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionDispatcher::getNumManifolds`.
        public unsafe int GetNumManifolds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_getNumManifolds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_getNumManifolds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionDispatcher_getNumManifolds(_Underlying *_this);
            return __btCollisionDispatcher_getNumManifolds(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionDispatcher::getCollisionConfiguration`.
        public unsafe Bullet.Const_BtCollisionConfiguration? GetCollisionConfiguration()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_getCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_getCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionConfiguration._Underlying *__btCollisionDispatcher_getCollisionConfiguration(_Underlying *_this);
            var __c_ret = __btCollisionDispatcher_getCollisionConfiguration(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Const_BtCollisionConfiguration(__c_ret, is_owning: false) : null;
        }

        public enum DispatcherFlags : uint
        {
            CDSTATICSTATICREPORTED = 1,
            CDUSERELATIVECONTACTBREAKINGTHRESHOLD = 2,
            CDDISABLECONTACTPOOLDYNAMICALLOCATION = 4,
        }
    }

    ///btCollisionDispatcher supports algorithms that handle ConvexConvex and ConvexConcave collision pairs.
    ///Time of Impact, Closest Points and Penetration Depth.
    /// Generated from class `btCollisionDispatcher`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btDispatcher`
    /// This is the non-const half of the class.
    public class BtCollisionDispatcher : Const_BtCollisionDispatcher
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtDispatcher(BtCollisionDispatcher self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_UpcastTo_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_UpcastTo_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDispatcher._Underlying *__btCollisionDispatcher_UpcastTo_btDispatcher(_Underlying *_this);
            Bullet.BtDispatcher ret = new(__btCollisionDispatcher_UpcastTo_btDispatcher(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtCollisionDispatcher?(Bullet.BtDispatcher parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_DynamicDowncastFrom_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_DynamicDowncastFrom_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCollisionDispatcher_DynamicDowncastFrom_btDispatcher(Bullet.BtDispatcher._Underlying *_this);
            var ptr = __btCollisionDispatcher_DynamicDowncastFrom_btDispatcher(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtCollisionDispatcher ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtCollisionDispatcher(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public unsafe BtCollisionDispatcher(Bullet._ByValue_BtCollisionDispatcher _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcher._Underlying *__btCollisionDispatcher_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionDispatcher._Underlying *_other);
            _UnderlyingPtr = __btCollisionDispatcher_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public BtCollisionDispatcher(Const_BtCollisionDispatcher _other) : this(new _ByValue_BtCollisionDispatcher(_other)) {}

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public BtCollisionDispatcher(BtCollisionDispatcher _other) : this((Const_BtCollisionDispatcher)_other) {}

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public unsafe BtCollisionDispatcher(Bullet.BtCollisionConfiguration? collisionConfiguration) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcher._Underlying *__btCollisionDispatcher_Construct(Bullet.BtCollisionConfiguration._Underlying *collisionConfiguration);
            _UnderlyingPtr = __btCollisionDispatcher_Construct(collisionConfiguration is not null ? collisionConfiguration._UnderlyingPtr : null);
        }

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public static unsafe implicit operator BtCollisionDispatcher(Bullet.BtCollisionConfiguration? collisionConfiguration) {return new(collisionConfiguration);}

        /// Generated from method `btCollisionDispatcher::operator=`.
        public unsafe Bullet.BtCollisionDispatcher Assign(Bullet._ByValue_BtCollisionDispatcher _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcher._Underlying *__btCollisionDispatcher_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtCollisionDispatcher._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btCollisionDispatcher_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btCollisionDispatcher::setDispatcherFlags`.
        public unsafe void SetDispatcherFlags(int flags)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_setDispatcherFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_setDispatcherFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionDispatcher_setDispatcherFlags(_Underlying *_this, int flags);
            __btCollisionDispatcher_setDispatcherFlags(_UnderlyingPtr, flags);
        }

        /// Generated from method `btCollisionDispatcher::needsCollision`.
        public unsafe bool NeedsCollision(Bullet.Const_BtCollisionObject? body0, Bullet.Const_BtCollisionObject? body1)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_needsCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_needsCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionDispatcher_needsCollision(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *body0, Bullet.Const_BtCollisionObject._Underlying *body1);
            return __btCollisionDispatcher_needsCollision(_UnderlyingPtr, body0 is not null ? body0._UnderlyingPtr : null, body1 is not null ? body1._UnderlyingPtr : null) != 0;
        }

        /// Generated from method `btCollisionDispatcher::needsResponse`.
        public unsafe bool NeedsResponse(Bullet.Const_BtCollisionObject? body0, Bullet.Const_BtCollisionObject? body1)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_needsResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_needsResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionDispatcher_needsResponse(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *body0, Bullet.Const_BtCollisionObject._Underlying *body1);
            return __btCollisionDispatcher_needsResponse(_UnderlyingPtr, body0 is not null ? body0._UnderlyingPtr : null, body1 is not null ? body1._UnderlyingPtr : null) != 0;
        }

        /// Generated from method `btCollisionDispatcher::allocateCollisionAlgorithm`.
        /// Returns a mutable pointer.
        public unsafe void *AllocateCollisionAlgorithm(int size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_allocateCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_allocateCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btCollisionDispatcher_allocateCollisionAlgorithm(_Underlying *_this, int size);
            return __btCollisionDispatcher_allocateCollisionAlgorithm(_UnderlyingPtr, size);
        }

        /// Generated from method `btCollisionDispatcher::freeCollisionAlgorithm`.
        /// Parameter `ptr` is a mutable pointer.
        public unsafe void FreeCollisionAlgorithm(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_freeCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_freeCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionDispatcher_freeCollisionAlgorithm(_Underlying *_this, void *ptr);
            __btCollisionDispatcher_freeCollisionAlgorithm(_UnderlyingPtr, ptr);
        }

        /// Generated from method `btCollisionDispatcher::getCollisionConfiguration`.
        public unsafe new Bullet.BtCollisionConfiguration? GetCollisionConfiguration()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_getCollisionConfiguration_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_getCollisionConfiguration_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionConfiguration._Underlying *__btCollisionDispatcher_getCollisionConfiguration_mut(_Underlying *_this);
            var __c_ret = __btCollisionDispatcher_getCollisionConfiguration_mut(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtCollisionConfiguration(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btCollisionDispatcher::setCollisionConfiguration`.
        public unsafe void SetCollisionConfiguration(Bullet.BtCollisionConfiguration? config)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcher_setCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcher_setCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionDispatcher_setCollisionConfiguration(_Underlying *_this, Bullet.BtCollisionConfiguration._Underlying *config);
            __btCollisionDispatcher_setCollisionConfiguration(_UnderlyingPtr, config is not null ? config._UnderlyingPtr : null);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtCollisionDispatcher` by value.
    /// Usage:
    /// * Pass an instance of `BtCollisionDispatcher`/`Const_BtCollisionDispatcher` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtCollisionDispatcher
    {
        #pragma warning disable CS0649
        internal readonly Const_BtCollisionDispatcher? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtCollisionDispatcher(Const_BtCollisionDispatcher new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtCollisionDispatcher(Const_BtCollisionDispatcher arg) {return new(arg);}

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public static unsafe implicit operator _ByValue_BtCollisionDispatcher(Bullet.BtCollisionConfiguration? collisionConfiguration) {return new Bullet.BtCollisionDispatcher(collisionConfiguration);}
    }

    /// This is used for optional parameters of class `BtCollisionDispatcher` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtCollisionDispatcher`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionDispatcher`/`Const_BtCollisionDispatcher` directly.
    public class _InOptMut_BtCollisionDispatcher
    {
        public BtCollisionDispatcher? Opt;

        public _InOptMut_BtCollisionDispatcher() {}
        public _InOptMut_BtCollisionDispatcher(BtCollisionDispatcher value) {Opt = value;}
        public static implicit operator _InOptMut_BtCollisionDispatcher(BtCollisionDispatcher value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtCollisionDispatcher` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtCollisionDispatcher`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionDispatcher`/`Const_BtCollisionDispatcher` to pass it to the function.
    public class _InOptConst_BtCollisionDispatcher
    {
        public Const_BtCollisionDispatcher? Opt;

        public _InOptConst_BtCollisionDispatcher() {}
        public _InOptConst_BtCollisionDispatcher(Const_BtCollisionDispatcher value) {Opt = value;}
        public static implicit operator _InOptConst_BtCollisionDispatcher(Const_BtCollisionDispatcher value) {return new(value);}

        /// Generated from constructor `btCollisionDispatcher::btCollisionDispatcher`.
        public static unsafe implicit operator _InOptConst_BtCollisionDispatcher(Bullet.BtCollisionConfiguration? collisionConfiguration) {return new Const_BtCollisionDispatcher(collisionConfiguration);}
    }
}
