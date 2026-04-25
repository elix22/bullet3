// machine generated, do not edit
public static partial class Bullet
{
    /// Generated from class `btCollisionDispatcherMt`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionDispatcher`
    ///   Indirect: (non-virtual)
    ///     `btDispatcher`
    /// This is the const half of the class.
    public class Const_BtCollisionDispatcherMt : Bullet.Object<Const_BtCollisionDispatcherMt>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionDispatcherMt_Destroy(_Underlying *_this);
            __btCollisionDispatcherMt_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtCollisionDispatcherMt() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtDispatcher(Const_BtCollisionDispatcherMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_UpcastTo_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_UpcastTo_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtDispatcher._Underlying *__btCollisionDispatcherMt_UpcastTo_btDispatcher(_Underlying *_this);
            Bullet.Const_BtDispatcher ret = new(__btCollisionDispatcherMt_UpcastTo_btDispatcher(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtCollisionDispatcher(Const_BtCollisionDispatcherMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionDispatcher._Underlying *__btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher(_Underlying *_this);
            Bullet.Const_BtCollisionDispatcher ret = new(__btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtCollisionDispatcherMt?(Bullet.Const_BtDispatcher parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher(Bullet.Const_BtDispatcher._Underlying *_this);
            var ptr = __btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtCollisionDispatcherMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtCollisionDispatcherMt?(Bullet.Const_BtCollisionDispatcher parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher(Bullet.Const_BtCollisionDispatcher._Underlying *_this);
            var ptr = __btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtCollisionDispatcherMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtCollisionDispatcherMt(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        public unsafe Const_BtCollisionDispatcherMt(Bullet._ByValue_BtCollisionDispatcherMt _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcherMt._Underlying *__btCollisionDispatcherMt_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionDispatcherMt._Underlying *_other);
            _UnderlyingPtr = __btCollisionDispatcherMt_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        public Const_BtCollisionDispatcherMt(Const_BtCollisionDispatcherMt _other) : this(new _ByValue_BtCollisionDispatcherMt(_other)) {}

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        public Const_BtCollisionDispatcherMt(BtCollisionDispatcherMt _other) : this((Const_BtCollisionDispatcherMt)_other) {}

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        /// Parameter `grainSize` defaults to `40`.
        public unsafe Const_BtCollisionDispatcherMt(Bullet.BtCollisionConfiguration? config, int? grainSize = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcherMt._Underlying *__btCollisionDispatcherMt_Construct(Bullet.BtCollisionConfiguration._Underlying *config, int *grainSize);
            int __deref_grainSize = grainSize.GetValueOrDefault();
            _UnderlyingPtr = __btCollisionDispatcherMt_Construct(config is not null ? config._UnderlyingPtr : null, grainSize.HasValue ? &__deref_grainSize : null);
        }

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        /// Parameter `grainSize` defaults to `40`.
        public static unsafe implicit operator Const_BtCollisionDispatcherMt(Bullet.BtCollisionConfiguration? config) {return new(config);}

        /// Generated from method `btCollisionDispatcherMt::getDispatcherFlags`.
        public unsafe int GetDispatcherFlags()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_getDispatcherFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_getDispatcherFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionDispatcherMt_getDispatcherFlags(_Underlying *_this);
            return __btCollisionDispatcherMt_getDispatcherFlags(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionDispatcherMt::getNumManifolds`.
        public unsafe int GetNumManifolds()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_getNumManifolds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_getNumManifolds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionDispatcherMt_getNumManifolds(_Underlying *_this);
            return __btCollisionDispatcherMt_getNumManifolds(_UnderlyingPtr);
        }
    }

    /// Generated from class `btCollisionDispatcherMt`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionDispatcher`
    ///   Indirect: (non-virtual)
    ///     `btDispatcher`
    /// This is the non-const half of the class.
    public class BtCollisionDispatcherMt : Const_BtCollisionDispatcherMt
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtDispatcher(BtCollisionDispatcherMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_UpcastTo_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_UpcastTo_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDispatcher._Underlying *__btCollisionDispatcherMt_UpcastTo_btDispatcher(_Underlying *_this);
            Bullet.BtDispatcher ret = new(__btCollisionDispatcherMt_UpcastTo_btDispatcher(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtCollisionDispatcher(BtCollisionDispatcherMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcher._Underlying *__btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher(_Underlying *_this);
            Bullet.BtCollisionDispatcher ret = new(__btCollisionDispatcherMt_UpcastTo_btCollisionDispatcher(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtCollisionDispatcherMt?(Bullet.BtDispatcher parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher(Bullet.BtDispatcher._Underlying *_this);
            var ptr = __btCollisionDispatcherMt_DynamicDowncastFrom_btDispatcher(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtCollisionDispatcherMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtCollisionDispatcherMt?(Bullet.BtCollisionDispatcher parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher(Bullet.BtCollisionDispatcher._Underlying *_this);
            var ptr = __btCollisionDispatcherMt_DynamicDowncastFrom_btCollisionDispatcher(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtCollisionDispatcherMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtCollisionDispatcherMt(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        public unsafe BtCollisionDispatcherMt(Bullet._ByValue_BtCollisionDispatcherMt _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcherMt._Underlying *__btCollisionDispatcherMt_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionDispatcherMt._Underlying *_other);
            _UnderlyingPtr = __btCollisionDispatcherMt_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        public BtCollisionDispatcherMt(Const_BtCollisionDispatcherMt _other) : this(new _ByValue_BtCollisionDispatcherMt(_other)) {}

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        public BtCollisionDispatcherMt(BtCollisionDispatcherMt _other) : this((Const_BtCollisionDispatcherMt)_other) {}

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        /// Parameter `grainSize` defaults to `40`.
        public unsafe BtCollisionDispatcherMt(Bullet.BtCollisionConfiguration? config, int? grainSize = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcherMt._Underlying *__btCollisionDispatcherMt_Construct(Bullet.BtCollisionConfiguration._Underlying *config, int *grainSize);
            int __deref_grainSize = grainSize.GetValueOrDefault();
            _UnderlyingPtr = __btCollisionDispatcherMt_Construct(config is not null ? config._UnderlyingPtr : null, grainSize.HasValue ? &__deref_grainSize : null);
        }

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        /// Parameter `grainSize` defaults to `40`.
        public static unsafe implicit operator BtCollisionDispatcherMt(Bullet.BtCollisionConfiguration? config) {return new(config);}

        /// Generated from method `btCollisionDispatcherMt::operator=`.
        public unsafe Bullet.BtCollisionDispatcherMt Assign(Bullet._ByValue_BtCollisionDispatcherMt _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionDispatcherMt._Underlying *__btCollisionDispatcherMt_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtCollisionDispatcherMt._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btCollisionDispatcherMt_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btCollisionDispatcherMt::setDispatcherFlags`.
        public unsafe void SetDispatcherFlags(int flags)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_setDispatcherFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_setDispatcherFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionDispatcherMt_setDispatcherFlags(_Underlying *_this, int flags);
            __btCollisionDispatcherMt_setDispatcherFlags(_UnderlyingPtr, flags);
        }

        /// Generated from method `btCollisionDispatcherMt::needsCollision`.
        public unsafe bool NeedsCollision(Bullet.Const_BtCollisionObject? body0, Bullet.Const_BtCollisionObject? body1)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_needsCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_needsCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionDispatcherMt_needsCollision(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *body0, Bullet.Const_BtCollisionObject._Underlying *body1);
            return __btCollisionDispatcherMt_needsCollision(_UnderlyingPtr, body0 is not null ? body0._UnderlyingPtr : null, body1 is not null ? body1._UnderlyingPtr : null) != 0;
        }

        /// Generated from method `btCollisionDispatcherMt::needsResponse`.
        public unsafe bool NeedsResponse(Bullet.Const_BtCollisionObject? body0, Bullet.Const_BtCollisionObject? body1)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_needsResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_needsResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionDispatcherMt_needsResponse(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *body0, Bullet.Const_BtCollisionObject._Underlying *body1);
            return __btCollisionDispatcherMt_needsResponse(_UnderlyingPtr, body0 is not null ? body0._UnderlyingPtr : null, body1 is not null ? body1._UnderlyingPtr : null) != 0;
        }

        /// Generated from method `btCollisionDispatcherMt::allocateCollisionAlgorithm`.
        /// Returns a mutable pointer.
        public unsafe void *AllocateCollisionAlgorithm(int size)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_allocateCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_allocateCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btCollisionDispatcherMt_allocateCollisionAlgorithm(_Underlying *_this, int size);
            return __btCollisionDispatcherMt_allocateCollisionAlgorithm(_UnderlyingPtr, size);
        }

        /// Generated from method `btCollisionDispatcherMt::freeCollisionAlgorithm`.
        /// Parameter `ptr` is a mutable pointer.
        public unsafe void FreeCollisionAlgorithm(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_freeCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_freeCollisionAlgorithm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionDispatcherMt_freeCollisionAlgorithm(_Underlying *_this, void *ptr);
            __btCollisionDispatcherMt_freeCollisionAlgorithm(_UnderlyingPtr, ptr);
        }

        /// Generated from method `btCollisionDispatcherMt::setCollisionConfiguration`.
        public unsafe void SetCollisionConfiguration(Bullet.BtCollisionConfiguration? config)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionDispatcherMt_setCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionDispatcherMt_setCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionDispatcherMt_setCollisionConfiguration(_Underlying *_this, Bullet.BtCollisionConfiguration._Underlying *config);
            __btCollisionDispatcherMt_setCollisionConfiguration(_UnderlyingPtr, config is not null ? config._UnderlyingPtr : null);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtCollisionDispatcherMt` by value.
    /// Usage:
    /// * Pass an instance of `BtCollisionDispatcherMt`/`Const_BtCollisionDispatcherMt` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtCollisionDispatcherMt
    {
        #pragma warning disable CS0649
        internal readonly Const_BtCollisionDispatcherMt? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtCollisionDispatcherMt(Const_BtCollisionDispatcherMt new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtCollisionDispatcherMt(Const_BtCollisionDispatcherMt arg) {return new(arg);}
        public _ByValue_BtCollisionDispatcherMt(Bullet._Moved<BtCollisionDispatcherMt> moved) {Value = moved.Value; PassByMode = Bullet._PassBy.move;}
        public static implicit operator _ByValue_BtCollisionDispatcherMt(Bullet._Moved<BtCollisionDispatcherMt> arg) {return new(arg);}

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        /// Parameter `grainSize` defaults to `40`.
        public static unsafe implicit operator _ByValue_BtCollisionDispatcherMt(Bullet.BtCollisionConfiguration? config) {return new Bullet._Moved<Bullet.BtCollisionDispatcherMt>(config);}
    }

    /// This is used for optional parameters of class `BtCollisionDispatcherMt` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtCollisionDispatcherMt`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionDispatcherMt`/`Const_BtCollisionDispatcherMt` directly.
    public class _InOptMut_BtCollisionDispatcherMt
    {
        public BtCollisionDispatcherMt? Opt;

        public _InOptMut_BtCollisionDispatcherMt() {}
        public _InOptMut_BtCollisionDispatcherMt(BtCollisionDispatcherMt value) {Opt = value;}
        public static implicit operator _InOptMut_BtCollisionDispatcherMt(BtCollisionDispatcherMt value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtCollisionDispatcherMt` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtCollisionDispatcherMt`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionDispatcherMt`/`Const_BtCollisionDispatcherMt` to pass it to the function.
    public class _InOptConst_BtCollisionDispatcherMt
    {
        public Const_BtCollisionDispatcherMt? Opt;

        public _InOptConst_BtCollisionDispatcherMt() {}
        public _InOptConst_BtCollisionDispatcherMt(Const_BtCollisionDispatcherMt value) {Opt = value;}
        public static implicit operator _InOptConst_BtCollisionDispatcherMt(Const_BtCollisionDispatcherMt value) {return new(value);}

        /// Generated from constructor `btCollisionDispatcherMt::btCollisionDispatcherMt`.
        /// Parameter `grainSize` defaults to `40`.
        public static unsafe implicit operator _InOptConst_BtCollisionDispatcherMt(Bullet.BtCollisionConfiguration? config) {return new Const_BtCollisionDispatcherMt(config);}
    }
}
