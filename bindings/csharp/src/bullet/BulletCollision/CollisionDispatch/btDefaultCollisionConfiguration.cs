// machine generated, do not edit
public static partial class Bullet
{
    ///btCollisionConfiguration allows to configure Bullet collision detection
    ///stack allocator, pool memory allocators
    ///@todo: describe the meaning
    /// Generated from class `btDefaultCollisionConfiguration`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionConfiguration`
    /// This is the const half of the class.
    public class Const_BtDefaultCollisionConfiguration : Bullet.Object<Const_BtDefaultCollisionConfiguration>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDefaultCollisionConfiguration_Destroy(_Underlying *_this);
            __btDefaultCollisionConfiguration_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtDefaultCollisionConfiguration() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionConfiguration(Const_BtDefaultCollisionConfiguration self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionConfiguration._Underlying *__btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration(_Underlying *_this);
            Bullet.Const_BtCollisionConfiguration ret = new(__btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtDefaultCollisionConfiguration?(Bullet.Const_BtCollisionConfiguration parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration(Bullet.Const_BtCollisionConfiguration._Underlying *_this);
            var ptr = __btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtDefaultCollisionConfiguration ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtDefaultCollisionConfiguration(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btDefaultCollisionConfiguration::btDefaultCollisionConfiguration`.
        public unsafe Const_BtDefaultCollisionConfiguration(Bullet._ByValue_BtDefaultCollisionConfiguration _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDefaultCollisionConfiguration._Underlying *__btDefaultCollisionConfiguration_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtDefaultCollisionConfiguration._Underlying *_other);
            _UnderlyingPtr = __btDefaultCollisionConfiguration_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btDefaultCollisionConfiguration::btDefaultCollisionConfiguration`.
        public Const_BtDefaultCollisionConfiguration(Const_BtDefaultCollisionConfiguration _other) : this(new _ByValue_BtDefaultCollisionConfiguration(_other)) {}

        /// Generated from constructor `btDefaultCollisionConfiguration::btDefaultCollisionConfiguration`.
        public Const_BtDefaultCollisionConfiguration(BtDefaultCollisionConfiguration _other) : this((Const_BtDefaultCollisionConfiguration)_other) {}
    }

    ///btCollisionConfiguration allows to configure Bullet collision detection
    ///stack allocator, pool memory allocators
    ///@todo: describe the meaning
    /// Generated from class `btDefaultCollisionConfiguration`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionConfiguration`
    /// This is the non-const half of the class.
    public class BtDefaultCollisionConfiguration : Const_BtDefaultCollisionConfiguration
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionConfiguration(BtDefaultCollisionConfiguration self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionConfiguration._Underlying *__btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration(_Underlying *_this);
            Bullet.BtCollisionConfiguration ret = new(__btDefaultCollisionConfiguration_UpcastTo_btCollisionConfiguration(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtDefaultCollisionConfiguration?(Bullet.BtCollisionConfiguration parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration(Bullet.BtCollisionConfiguration._Underlying *_this);
            var ptr = __btDefaultCollisionConfiguration_DynamicDowncastFrom_btCollisionConfiguration(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtDefaultCollisionConfiguration ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtDefaultCollisionConfiguration(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btDefaultCollisionConfiguration::btDefaultCollisionConfiguration`.
        public unsafe BtDefaultCollisionConfiguration(Bullet._ByValue_BtDefaultCollisionConfiguration _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDefaultCollisionConfiguration._Underlying *__btDefaultCollisionConfiguration_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtDefaultCollisionConfiguration._Underlying *_other);
            _UnderlyingPtr = __btDefaultCollisionConfiguration_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btDefaultCollisionConfiguration::btDefaultCollisionConfiguration`.
        public BtDefaultCollisionConfiguration(Const_BtDefaultCollisionConfiguration _other) : this(new _ByValue_BtDefaultCollisionConfiguration(_other)) {}

        /// Generated from constructor `btDefaultCollisionConfiguration::btDefaultCollisionConfiguration`.
        public BtDefaultCollisionConfiguration(BtDefaultCollisionConfiguration _other) : this((Const_BtDefaultCollisionConfiguration)_other) {}

        /// Generated from method `btDefaultCollisionConfiguration::operator=`.
        public unsafe Bullet.BtDefaultCollisionConfiguration Assign(Bullet._ByValue_BtDefaultCollisionConfiguration _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDefaultCollisionConfiguration._Underlying *__btDefaultCollisionConfiguration_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtDefaultCollisionConfiguration._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btDefaultCollisionConfiguration_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        ///Use this method to allow to generate multiple contact points between at once, between two objects using the generic convex-convex algorithm.
        ///By default, this feature is disabled for best performance.
        ///@param numPerturbationIterations controls the number of collision queries. Set it to zero to disable the feature.
        ///@param minimumPointsPerturbationThreshold is the minimum number of points in the contact cache, above which the feature is disabled
        ///3 is a good value for both params, if you want to enable the feature. This is because the default contact cache contains a maximum of 4 points, and one collision query at the unperturbed orientation is performed first.
        ///See Bullet/Demos/CollisionDemo for an example how this feature gathers multiple points.
        ///@todo we could add a per-object setting of those parameters, for level-of-detail collision detection.
        /// Generated from method `btDefaultCollisionConfiguration::setConvexConvexMultipointIterations`.
        /// Parameter `numPerturbationIterations` defaults to `3`.
        /// Parameter `minimumPointsPerturbationThreshold` defaults to `3`.
        public unsafe void SetConvexConvexMultipointIterations(int? numPerturbationIterations = null, int? minimumPointsPerturbationThreshold = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_setConvexConvexMultipointIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_setConvexConvexMultipointIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDefaultCollisionConfiguration_setConvexConvexMultipointIterations(_Underlying *_this, int *numPerturbationIterations, int *minimumPointsPerturbationThreshold);
            int __deref_numPerturbationIterations = numPerturbationIterations.GetValueOrDefault();
            int __deref_minimumPointsPerturbationThreshold = minimumPointsPerturbationThreshold.GetValueOrDefault();
            __btDefaultCollisionConfiguration_setConvexConvexMultipointIterations(_UnderlyingPtr, numPerturbationIterations.HasValue ? &__deref_numPerturbationIterations : null, minimumPointsPerturbationThreshold.HasValue ? &__deref_minimumPointsPerturbationThreshold : null);
        }

        /// Generated from method `btDefaultCollisionConfiguration::setPlaneConvexMultipointIterations`.
        /// Parameter `numPerturbationIterations` defaults to `3`.
        /// Parameter `minimumPointsPerturbationThreshold` defaults to `3`.
        public unsafe void SetPlaneConvexMultipointIterations(int? numPerturbationIterations = null, int? minimumPointsPerturbationThreshold = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultCollisionConfiguration_setPlaneConvexMultipointIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultCollisionConfiguration_setPlaneConvexMultipointIterations", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDefaultCollisionConfiguration_setPlaneConvexMultipointIterations(_Underlying *_this, int *numPerturbationIterations, int *minimumPointsPerturbationThreshold);
            int __deref_numPerturbationIterations = numPerturbationIterations.GetValueOrDefault();
            int __deref_minimumPointsPerturbationThreshold = minimumPointsPerturbationThreshold.GetValueOrDefault();
            __btDefaultCollisionConfiguration_setPlaneConvexMultipointIterations(_UnderlyingPtr, numPerturbationIterations.HasValue ? &__deref_numPerturbationIterations : null, minimumPointsPerturbationThreshold.HasValue ? &__deref_minimumPointsPerturbationThreshold : null);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtDefaultCollisionConfiguration` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `BtDefaultCollisionConfiguration`/`Const_BtDefaultCollisionConfiguration` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtDefaultCollisionConfiguration
    {
        #pragma warning disable CS0649
        internal readonly Const_BtDefaultCollisionConfiguration? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtDefaultCollisionConfiguration() {PassByMode = Bullet._PassBy.default_construct;}
        public _ByValue_BtDefaultCollisionConfiguration(Const_BtDefaultCollisionConfiguration new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtDefaultCollisionConfiguration(Const_BtDefaultCollisionConfiguration arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtDefaultCollisionConfiguration` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtDefaultCollisionConfiguration`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDefaultCollisionConfiguration`/`Const_BtDefaultCollisionConfiguration` directly.
    public class _InOptMut_BtDefaultCollisionConfiguration
    {
        public BtDefaultCollisionConfiguration? Opt;

        public _InOptMut_BtDefaultCollisionConfiguration() {}
        public _InOptMut_BtDefaultCollisionConfiguration(BtDefaultCollisionConfiguration value) {Opt = value;}
        public static implicit operator _InOptMut_BtDefaultCollisionConfiguration(BtDefaultCollisionConfiguration value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtDefaultCollisionConfiguration` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtDefaultCollisionConfiguration`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDefaultCollisionConfiguration`/`Const_BtDefaultCollisionConfiguration` to pass it to the function.
    public class _InOptConst_BtDefaultCollisionConfiguration
    {
        public Const_BtDefaultCollisionConfiguration? Opt;

        public _InOptConst_BtDefaultCollisionConfiguration() {}
        public _InOptConst_BtDefaultCollisionConfiguration(Const_BtDefaultCollisionConfiguration value) {Opt = value;}
        public static implicit operator _InOptConst_BtDefaultCollisionConfiguration(Const_BtDefaultCollisionConfiguration value) {return new(value);}
    }
}
