// machine generated, do not edit
public static partial class Bullet
{
    ///
    /// btConstraintSolverPoolMt - masquerades as a constraint solver, but really it is a threadsafe pool of them.
    ///
    ///  Each solver in the pool is protected by a mutex.  When solveGroup is called from a thread,
    ///  the pool looks for a solver that isn't being used by another thread, locks it, and dispatches the
    ///  call to the solver.
    ///  So long as there are at least as many solvers as there are hardware threads, it should never need to
    ///  spin wait.
    ///
    /// Generated from class `btConstraintSolverPoolMt`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConstraintSolver`
    /// This is the const half of the class.
    public class Const_BtConstraintSolverPoolMt : Bullet.Object<Const_BtConstraintSolverPoolMt>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConstraintSolverPoolMt_Destroy(_Underlying *_this);
            __btConstraintSolverPoolMt_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtConstraintSolverPoolMt() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtConstraintSolver(Const_BtConstraintSolverPoolMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConstraintSolver._Underlying *__btConstraintSolverPoolMt_UpcastTo_btConstraintSolver(_Underlying *_this);
            Bullet.Const_BtConstraintSolver ret = new(__btConstraintSolverPoolMt_UpcastTo_btConstraintSolver(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtConstraintSolverPoolMt?(Bullet.Const_BtConstraintSolver parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver(Bullet.Const_BtConstraintSolver._Underlying *_this);
            var ptr = __btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtConstraintSolverPoolMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtConstraintSolverPoolMt(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public unsafe Const_BtConstraintSolverPoolMt(Bullet._ByValue_BtConstraintSolverPoolMt _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolverPoolMt._Underlying *__btConstraintSolverPoolMt_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtConstraintSolverPoolMt._Underlying *_other);
            _UnderlyingPtr = __btConstraintSolverPoolMt_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public Const_BtConstraintSolverPoolMt(Const_BtConstraintSolverPoolMt _other) : this(new _ByValue_BtConstraintSolverPoolMt(_other)) {}

        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public Const_BtConstraintSolverPoolMt(BtConstraintSolverPoolMt _other) : this((Const_BtConstraintSolverPoolMt)_other) {}

        // create the solvers for me
        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public unsafe Const_BtConstraintSolverPoolMt(int numSolvers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolverPoolMt._Underlying *__btConstraintSolverPoolMt_Construct_1(int numSolvers);
            _UnderlyingPtr = __btConstraintSolverPoolMt_Construct_1(numSolvers);
        }

        // pass in fully constructed solvers (destructor will delete them)
        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public unsafe Const_BtConstraintSolverPoolMt(void **solvers, int numSolvers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolverPoolMt._Underlying *__btConstraintSolverPoolMt_Construct_2(void **solvers, int numSolvers);
            _UnderlyingPtr = __btConstraintSolverPoolMt_Construct_2(solvers, numSolvers);
        }
    }

    ///
    /// btConstraintSolverPoolMt - masquerades as a constraint solver, but really it is a threadsafe pool of them.
    ///
    ///  Each solver in the pool is protected by a mutex.  When solveGroup is called from a thread,
    ///  the pool looks for a solver that isn't being used by another thread, locks it, and dispatches the
    ///  call to the solver.
    ///  So long as there are at least as many solvers as there are hardware threads, it should never need to
    ///  spin wait.
    ///
    /// Generated from class `btConstraintSolverPoolMt`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConstraintSolver`
    /// This is the non-const half of the class.
    public class BtConstraintSolverPoolMt : Const_BtConstraintSolverPoolMt
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtConstraintSolver(BtConstraintSolverPoolMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolver._Underlying *__btConstraintSolverPoolMt_UpcastTo_btConstraintSolver(_Underlying *_this);
            Bullet.BtConstraintSolver ret = new(__btConstraintSolverPoolMt_UpcastTo_btConstraintSolver(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtConstraintSolverPoolMt?(Bullet.BtConstraintSolver parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver(Bullet.BtConstraintSolver._Underlying *_this);
            var ptr = __btConstraintSolverPoolMt_DynamicDowncastFrom_btConstraintSolver(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtConstraintSolverPoolMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtConstraintSolverPoolMt(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public unsafe BtConstraintSolverPoolMt(Bullet._ByValue_BtConstraintSolverPoolMt _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolverPoolMt._Underlying *__btConstraintSolverPoolMt_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtConstraintSolverPoolMt._Underlying *_other);
            _UnderlyingPtr = __btConstraintSolverPoolMt_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public BtConstraintSolverPoolMt(Const_BtConstraintSolverPoolMt _other) : this(new _ByValue_BtConstraintSolverPoolMt(_other)) {}

        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public BtConstraintSolverPoolMt(BtConstraintSolverPoolMt _other) : this((Const_BtConstraintSolverPoolMt)_other) {}

        // create the solvers for me
        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public unsafe BtConstraintSolverPoolMt(int numSolvers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolverPoolMt._Underlying *__btConstraintSolverPoolMt_Construct_1(int numSolvers);
            _UnderlyingPtr = __btConstraintSolverPoolMt_Construct_1(numSolvers);
        }

        // pass in fully constructed solvers (destructor will delete them)
        /// Generated from constructor `btConstraintSolverPoolMt::btConstraintSolverPoolMt`.
        public unsafe BtConstraintSolverPoolMt(void **solvers, int numSolvers) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolverPoolMt._Underlying *__btConstraintSolverPoolMt_Construct_2(void **solvers, int numSolvers);
            _UnderlyingPtr = __btConstraintSolverPoolMt_Construct_2(solvers, numSolvers);
        }

        /// Generated from method `btConstraintSolverPoolMt::operator=`.
        public unsafe Bullet.BtConstraintSolverPoolMt Assign(Bullet._ByValue_BtConstraintSolverPoolMt _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolverPoolMt._Underlying *__btConstraintSolverPoolMt_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtConstraintSolverPoolMt._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btConstraintSolverPoolMt_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btConstraintSolverPoolMt::reset`.
        public unsafe void Reset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConstraintSolverPoolMt_reset(_Underlying *_this);
            __btConstraintSolverPoolMt_reset(_UnderlyingPtr);
        }

        /// Generated from method `btConstraintSolverPoolMt::prepareSolve`.
        public unsafe void PrepareSolve(int _1, int _2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolverPoolMt_prepareSolve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolverPoolMt_prepareSolve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConstraintSolverPoolMt_prepareSolve(_Underlying *_this, int _1, int _2);
            __btConstraintSolverPoolMt_prepareSolve(_UnderlyingPtr, _1, _2);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtConstraintSolverPoolMt` by value.
    /// Usage:
    /// * Pass an instance of `BtConstraintSolverPoolMt`/`Const_BtConstraintSolverPoolMt` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtConstraintSolverPoolMt
    {
        #pragma warning disable CS0649
        internal readonly Const_BtConstraintSolverPoolMt? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtConstraintSolverPoolMt(Const_BtConstraintSolverPoolMt new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtConstraintSolverPoolMt(Const_BtConstraintSolverPoolMt arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtConstraintSolverPoolMt` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtConstraintSolverPoolMt`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtConstraintSolverPoolMt`/`Const_BtConstraintSolverPoolMt` directly.
    public class _InOptMut_BtConstraintSolverPoolMt
    {
        public BtConstraintSolverPoolMt? Opt;

        public _InOptMut_BtConstraintSolverPoolMt() {}
        public _InOptMut_BtConstraintSolverPoolMt(BtConstraintSolverPoolMt value) {Opt = value;}
        public static implicit operator _InOptMut_BtConstraintSolverPoolMt(BtConstraintSolverPoolMt value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtConstraintSolverPoolMt` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtConstraintSolverPoolMt`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtConstraintSolverPoolMt`/`Const_BtConstraintSolverPoolMt` to pass it to the function.
    public class _InOptConst_BtConstraintSolverPoolMt
    {
        public Const_BtConstraintSolverPoolMt? Opt;

        public _InOptConst_BtConstraintSolverPoolMt() {}
        public _InOptConst_BtConstraintSolverPoolMt(Const_BtConstraintSolverPoolMt value) {Opt = value;}
        public static implicit operator _InOptConst_BtConstraintSolverPoolMt(Const_BtConstraintSolverPoolMt value) {return new(value);}
    }

    ///
    /// btDiscreteDynamicsWorldMt -- a version of DiscreteDynamicsWorld with some minor changes to support
    ///                              solving simulation islands on multiple threads.
    ///
    ///  Should function exactly like btDiscreteDynamicsWorld.
    ///  Also 3 methods that iterate over all of the rigidbodies can run in parallel:
    ///     - predictUnconstraintMotion
    ///     - integrateTransforms
    ///     - createPredictiveContacts
    ///
    /// Generated from class `btDiscreteDynamicsWorldMt`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btDiscreteDynamicsWorld`
    ///   Indirect: (non-virtual)
    ///     `btCollisionWorld`
    ///     `btDynamicsWorld`
    /// This is the const half of the class.
    public class Const_BtDiscreteDynamicsWorldMt : Bullet.Object<Const_BtDiscreteDynamicsWorldMt>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_Destroy(_Underlying *_this);
            __btDiscreteDynamicsWorldMt_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtDiscreteDynamicsWorldMt() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionWorld(Const_BtDiscreteDynamicsWorldMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionWorld._Underlying *__btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld(_Underlying *_this);
            Bullet.Const_BtCollisionWorld ret = new(__btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtDynamicsWorld(Const_BtDiscreteDynamicsWorldMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtDynamicsWorld._Underlying *__btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld(_Underlying *_this);
            Bullet.Const_BtDynamicsWorld ret = new(__btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtDiscreteDynamicsWorld(Const_BtDiscreteDynamicsWorldMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtDiscreteDynamicsWorld._Underlying *__btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld(_Underlying *_this);
            Bullet.Const_BtDiscreteDynamicsWorld ret = new(__btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtDiscreteDynamicsWorldMt?(Bullet.Const_BtCollisionWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld(Bullet.Const_BtCollisionWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtDiscreteDynamicsWorldMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtDiscreteDynamicsWorldMt?(Bullet.Const_BtDynamicsWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld(Bullet.Const_BtDynamicsWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtDiscreteDynamicsWorldMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtDiscreteDynamicsWorldMt?(Bullet.Const_BtDiscreteDynamicsWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld(Bullet.Const_BtDiscreteDynamicsWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtDiscreteDynamicsWorldMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtDiscreteDynamicsWorldMt(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
        public unsafe Const_BtDiscreteDynamicsWorldMt(Bullet._ByValue_BtDiscreteDynamicsWorldMt _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorldMt._Underlying *__btDiscreteDynamicsWorldMt_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtDiscreteDynamicsWorldMt._Underlying *_other);
            _UnderlyingPtr = __btDiscreteDynamicsWorldMt_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
        public Const_BtDiscreteDynamicsWorldMt(Const_BtDiscreteDynamicsWorldMt _other) : this(new _ByValue_BtDiscreteDynamicsWorldMt(_other)) {}

        /// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
        public Const_BtDiscreteDynamicsWorldMt(BtDiscreteDynamicsWorldMt _other) : this((Const_BtDiscreteDynamicsWorldMt)_other) {}

        /// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
        public unsafe Const_BtDiscreteDynamicsWorldMt(Bullet.BtDispatcher? dispatcher, Bullet.BtBroadphaseInterface? pairCache, Bullet.BtConstraintSolverPoolMt? solverPool, Bullet.BtConstraintSolver? constraintSolverMt, Bullet.BtCollisionConfiguration? collisionConfiguration) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorldMt._Underlying *__btDiscreteDynamicsWorldMt_Construct(Bullet.BtDispatcher._Underlying *dispatcher, Bullet.BtBroadphaseInterface._Underlying *pairCache, Bullet.BtConstraintSolverPoolMt._Underlying *solverPool, Bullet.BtConstraintSolver._Underlying *constraintSolverMt, Bullet.BtCollisionConfiguration._Underlying *collisionConfiguration);
            _UnderlyingPtr = __btDiscreteDynamicsWorldMt_Construct(dispatcher is not null ? dispatcher._UnderlyingPtr : null, pairCache is not null ? pairCache._UnderlyingPtr : null, solverPool is not null ? solverPool._UnderlyingPtr : null, constraintSolverMt is not null ? constraintSolverMt._UnderlyingPtr : null, collisionConfiguration is not null ? collisionConfiguration._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr(void *ptr);
            __Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr(ptr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btDiscreteDynamicsWorldMt_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr(void *ptr);
            __Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr(ptr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btDiscreteDynamicsWorldMt_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btDiscreteDynamicsWorldMt_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getGravity`.
        public unsafe Bullet.BtVector3 GetGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btDiscreteDynamicsWorldMt_getGravity(_Underlying *_this);
            return new(__btDiscreteDynamicsWorldMt_getGravity(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getNumConstraints`.
        public unsafe int GetNumConstraints()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getNumConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getNumConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDiscreteDynamicsWorldMt_getNumConstraints(_Underlying *_this);
            return __btDiscreteDynamicsWorldMt_getNumConstraints(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getSynchronizeAllMotionStates`.
        public unsafe bool GetSynchronizeAllMotionStates()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getSynchronizeAllMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getSynchronizeAllMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDiscreteDynamicsWorldMt_getSynchronizeAllMotionStates(_Underlying *_this);
            return __btDiscreteDynamicsWorldMt_getSynchronizeAllMotionStates(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getApplySpeculativeContactRestitution`.
        public unsafe bool GetApplySpeculativeContactRestitution()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getApplySpeculativeContactRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getApplySpeculativeContactRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDiscreteDynamicsWorldMt_getApplySpeculativeContactRestitution(_Underlying *_this);
            return __btDiscreteDynamicsWorldMt_getApplySpeculativeContactRestitution(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getLatencyMotionStateInterpolation`.
        public unsafe bool GetLatencyMotionStateInterpolation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getLatencyMotionStateInterpolation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getLatencyMotionStateInterpolation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDiscreteDynamicsWorldMt_getLatencyMotionStateInterpolation(_Underlying *_this);
            return __btDiscreteDynamicsWorldMt_getLatencyMotionStateInterpolation(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getWorldUserInfo`.
        /// Returns a mutable pointer.
        public unsafe void *GetWorldUserInfo()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btDiscreteDynamicsWorldMt_getWorldUserInfo(_Underlying *_this);
            return __btDiscreteDynamicsWorldMt_getWorldUserInfo(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getNumCollisionObjects`.
        public unsafe int GetNumCollisionObjects()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getNumCollisionObjects", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getNumCollisionObjects", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDiscreteDynamicsWorldMt_getNumCollisionObjects(_Underlying *_this);
            return __btDiscreteDynamicsWorldMt_getNumCollisionObjects(_UnderlyingPtr);
        }

        /// rayTest performs a raycast on all objects in the btCollisionWorld, and calls the resultCallback
        /// This allows for several queries: first hit, all hits, any hit, dependent on the value returned by the callback.
        /// Generated from method `btDiscreteDynamicsWorldMt::rayTest`.
        public unsafe void RayTest(Bullet.Const_BtVector3 rayFromWorld, Bullet.Const_BtVector3 rayToWorld, Bullet.BtCollisionWorld.RayResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_rayTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_rayTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_rayTest(_Underlying *_this, Bullet.Const_BtVector3._Underlying *rayFromWorld, Bullet.Const_BtVector3._Underlying *rayToWorld, Bullet.BtCollisionWorld.RayResultCallback._Underlying *resultCallback);
            __btDiscreteDynamicsWorldMt_rayTest(_UnderlyingPtr, rayFromWorld._UnderlyingPtr, rayToWorld._UnderlyingPtr, resultCallback._UnderlyingPtr);
        }

        /// convexTest performs a swept convex cast on all objects in the btCollisionWorld, and calls the resultCallback
        /// This allows for several queries: first hit, all hits, any hit, dependent on the value return by the callback.
        /// Generated from method `btDiscreteDynamicsWorldMt::convexSweepTest`.
        /// Parameter `allowedCcdPenetration` defaults to `btScalar(0.0)`.
        public unsafe void ConvexSweepTest(Bullet.Const_BtConvexShape? castShape, Bullet.Const_BtTransform from, Bullet.Const_BtTransform to, Bullet.BtCollisionWorld.ConvexResultCallback resultCallback, double? allowedCcdPenetration = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_convexSweepTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_convexSweepTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_convexSweepTest(_Underlying *_this, Bullet.Const_BtConvexShape._Underlying *castShape, Bullet.Const_BtTransform._Underlying *from, Bullet.Const_BtTransform._Underlying *to, Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *resultCallback, double *allowedCcdPenetration);
            double __deref_allowedCcdPenetration = allowedCcdPenetration.GetValueOrDefault();
            __btDiscreteDynamicsWorldMt_convexSweepTest(_UnderlyingPtr, castShape is not null ? castShape._UnderlyingPtr : null, from._UnderlyingPtr, to._UnderlyingPtr, resultCallback._UnderlyingPtr, allowedCcdPenetration.HasValue ? &__deref_allowedCcdPenetration : null);
        }

        /// rayTestSingle performs a raycast call and calls the resultCallback. It is used internally by rayTest.
        /// In a future implementation, we consider moving the ray test as a virtual method in btCollisionShape.
        /// This allows more customization.
        /// Generated from method `btDiscreteDynamicsWorldMt::rayTestSingle`.
        public static unsafe void RayTestSingle(Bullet.Const_BtTransform rayFromTrans, Bullet.Const_BtTransform rayToTrans, Bullet.BtCollisionObject? collisionObject, Bullet.Const_BtCollisionShape? collisionShape, Bullet.Const_BtTransform colObjWorldTransform, Bullet.BtCollisionWorld.RayResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_rayTestSingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_rayTestSingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_rayTestSingle(Bullet.Const_BtTransform._Underlying *rayFromTrans, Bullet.Const_BtTransform._Underlying *rayToTrans, Bullet.BtCollisionObject._Underlying *collisionObject, Bullet.Const_BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtTransform._Underlying *colObjWorldTransform, Bullet.BtCollisionWorld.RayResultCallback._Underlying *resultCallback);
            __btDiscreteDynamicsWorldMt_rayTestSingle(rayFromTrans._UnderlyingPtr, rayToTrans._UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, colObjWorldTransform._UnderlyingPtr, resultCallback._UnderlyingPtr);
        }

        /// objectQuerySingle performs a collision detection query and calls the resultCallback. It is used internally by rayTest.
        /// Generated from method `btDiscreteDynamicsWorldMt::objectQuerySingle`.
        public static unsafe void ObjectQuerySingle(Bullet.Const_BtConvexShape? castShape, Bullet.Const_BtTransform rayFromTrans, Bullet.Const_BtTransform rayToTrans, Bullet.BtCollisionObject? collisionObject, Bullet.Const_BtCollisionShape? collisionShape, Bullet.Const_BtTransform colObjWorldTransform, Bullet.BtCollisionWorld.ConvexResultCallback resultCallback, double allowedPenetration)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_objectQuerySingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_objectQuerySingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_objectQuerySingle(Bullet.Const_BtConvexShape._Underlying *castShape, Bullet.Const_BtTransform._Underlying *rayFromTrans, Bullet.Const_BtTransform._Underlying *rayToTrans, Bullet.BtCollisionObject._Underlying *collisionObject, Bullet.Const_BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtTransform._Underlying *colObjWorldTransform, Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *resultCallback, double allowedPenetration);
            __btDiscreteDynamicsWorldMt_objectQuerySingle(castShape is not null ? castShape._UnderlyingPtr : null, rayFromTrans._UnderlyingPtr, rayToTrans._UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, colObjWorldTransform._UnderlyingPtr, resultCallback._UnderlyingPtr, allowedPenetration);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getForceUpdateAllAabbs`.
        public unsafe bool GetForceUpdateAllAabbs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDiscreteDynamicsWorldMt_getForceUpdateAllAabbs(_Underlying *_this);
            return __btDiscreteDynamicsWorldMt_getForceUpdateAllAabbs(_UnderlyingPtr) != 0;
        }
    }

    ///
    /// btDiscreteDynamicsWorldMt -- a version of DiscreteDynamicsWorld with some minor changes to support
    ///                              solving simulation islands on multiple threads.
    ///
    ///  Should function exactly like btDiscreteDynamicsWorld.
    ///  Also 3 methods that iterate over all of the rigidbodies can run in parallel:
    ///     - predictUnconstraintMotion
    ///     - integrateTransforms
    ///     - createPredictiveContacts
    ///
    /// Generated from class `btDiscreteDynamicsWorldMt`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btDiscreteDynamicsWorld`
    ///   Indirect: (non-virtual)
    ///     `btCollisionWorld`
    ///     `btDynamicsWorld`
    /// This is the non-const half of the class.
    public class BtDiscreteDynamicsWorldMt : Const_BtDiscreteDynamicsWorldMt
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionWorld(BtDiscreteDynamicsWorldMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld(_Underlying *_this);
            Bullet.BtCollisionWorld ret = new(__btDiscreteDynamicsWorldMt_UpcastTo_btCollisionWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtDynamicsWorld(BtDiscreteDynamicsWorldMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDynamicsWorld._Underlying *__btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld(_Underlying *_this);
            Bullet.BtDynamicsWorld ret = new(__btDiscreteDynamicsWorldMt_UpcastTo_btDynamicsWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtDiscreteDynamicsWorld(BtDiscreteDynamicsWorldMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorld._Underlying *__btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld(_Underlying *_this);
            Bullet.BtDiscreteDynamicsWorld ret = new(__btDiscreteDynamicsWorldMt_UpcastTo_btDiscreteDynamicsWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtDiscreteDynamicsWorldMt?(Bullet.BtCollisionWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld(Bullet.BtCollisionWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btCollisionWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtDiscreteDynamicsWorldMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtDiscreteDynamicsWorldMt?(Bullet.BtDynamicsWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld(Bullet.BtDynamicsWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDynamicsWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtDiscreteDynamicsWorldMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtDiscreteDynamicsWorldMt?(Bullet.BtDiscreteDynamicsWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld(Bullet.BtDiscreteDynamicsWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorldMt_DynamicDowncastFrom_btDiscreteDynamicsWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtDiscreteDynamicsWorldMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtDiscreteDynamicsWorldMt(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
        public unsafe BtDiscreteDynamicsWorldMt(Bullet._ByValue_BtDiscreteDynamicsWorldMt _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorldMt._Underlying *__btDiscreteDynamicsWorldMt_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtDiscreteDynamicsWorldMt._Underlying *_other);
            _UnderlyingPtr = __btDiscreteDynamicsWorldMt_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
        public BtDiscreteDynamicsWorldMt(Const_BtDiscreteDynamicsWorldMt _other) : this(new _ByValue_BtDiscreteDynamicsWorldMt(_other)) {}

        /// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
        public BtDiscreteDynamicsWorldMt(BtDiscreteDynamicsWorldMt _other) : this((Const_BtDiscreteDynamicsWorldMt)_other) {}

        /// Generated from constructor `btDiscreteDynamicsWorldMt::btDiscreteDynamicsWorldMt`.
        public unsafe BtDiscreteDynamicsWorldMt(Bullet.BtDispatcher? dispatcher, Bullet.BtBroadphaseInterface? pairCache, Bullet.BtConstraintSolverPoolMt? solverPool, Bullet.BtConstraintSolver? constraintSolverMt, Bullet.BtCollisionConfiguration? collisionConfiguration) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorldMt._Underlying *__btDiscreteDynamicsWorldMt_Construct(Bullet.BtDispatcher._Underlying *dispatcher, Bullet.BtBroadphaseInterface._Underlying *pairCache, Bullet.BtConstraintSolverPoolMt._Underlying *solverPool, Bullet.BtConstraintSolver._Underlying *constraintSolverMt, Bullet.BtCollisionConfiguration._Underlying *collisionConfiguration);
            _UnderlyingPtr = __btDiscreteDynamicsWorldMt_Construct(dispatcher is not null ? dispatcher._UnderlyingPtr : null, pairCache is not null ? pairCache._UnderlyingPtr : null, solverPool is not null ? solverPool._UnderlyingPtr : null, constraintSolverMt is not null ? constraintSolverMt._UnderlyingPtr : null, collisionConfiguration is not null ? collisionConfiguration._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::operator=`.
        public unsafe Bullet.BtDiscreteDynamicsWorldMt Assign(Bullet._ByValue_BtDiscreteDynamicsWorldMt _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorldMt._Underlying *__btDiscreteDynamicsWorldMt_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtDiscreteDynamicsWorldMt._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btDiscreteDynamicsWorldMt_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::stepSimulation`.
        public unsafe int StepSimulation(double timeStep, int maxSubSteps, double fixedTimeStep)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_stepSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_stepSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDiscreteDynamicsWorldMt_stepSimulation(_Underlying *_this, double timeStep, int maxSubSteps, double fixedTimeStep);
            return __btDiscreteDynamicsWorldMt_stepSimulation(_UnderlyingPtr, timeStep, maxSubSteps, fixedTimeStep);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::synchronizeMotionStates`.
        public unsafe void SynchronizeMotionStates()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_synchronizeMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_synchronizeMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_synchronizeMotionStates(_Underlying *_this);
            __btDiscreteDynamicsWorldMt_synchronizeMotionStates(_UnderlyingPtr);
        }

        ///this can be useful to synchronize a single rigid body -> graphics object
        /// Generated from method `btDiscreteDynamicsWorldMt::synchronizeSingleMotionState`.
        public unsafe void SynchronizeSingleMotionState(Bullet.BtRigidBody? body)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_synchronizeSingleMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_synchronizeSingleMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_synchronizeSingleMotionState(_Underlying *_this, Bullet.BtRigidBody._Underlying *body);
            __btDiscreteDynamicsWorldMt_synchronizeSingleMotionState(_UnderlyingPtr, body is not null ? body._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getCollisionWorld`.
        public unsafe Bullet.BtCollisionWorld? GetCollisionWorld()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btDiscreteDynamicsWorldMt_getCollisionWorld(_Underlying *_this);
            var __c_ret = __btDiscreteDynamicsWorldMt_getCollisionWorld(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtCollisionWorld(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::setGravity`.
        public unsafe void SetGravity(Bullet.Const_BtVector3 gravity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_setGravity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *gravity);
            __btDiscreteDynamicsWorldMt_setGravity(_UnderlyingPtr, gravity._UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::addCollisionObject`.
        /// Parameter `collisionFilterGroup` defaults to `btBroadphaseProxy::StaticFilter`.
        /// Parameter `collisionFilterMask` defaults to `btBroadphaseProxy::AllFilter^btBroadphaseProxy::StaticFilter`.
        public unsafe void AddCollisionObject(Bullet.BtCollisionObject? collisionObject, int? collisionFilterGroup = null, int? collisionFilterMask = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_addCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_addCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_addCollisionObject(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject, int *collisionFilterGroup, int *collisionFilterMask);
            int __deref_collisionFilterGroup = collisionFilterGroup.GetValueOrDefault();
            int __deref_collisionFilterMask = collisionFilterMask.GetValueOrDefault();
            __btDiscreteDynamicsWorldMt_addCollisionObject(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionFilterGroup.HasValue ? &__deref_collisionFilterGroup : null, collisionFilterMask.HasValue ? &__deref_collisionFilterMask : null);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::removeRigidBody`.
        public unsafe void RemoveRigidBody(Bullet.BtRigidBody? body)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_removeRigidBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_removeRigidBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_removeRigidBody(_Underlying *_this, Bullet.BtRigidBody._Underlying *body);
            __btDiscreteDynamicsWorldMt_removeRigidBody(_UnderlyingPtr, body is not null ? body._UnderlyingPtr : null);
        }

        ///removeCollisionObject will first check if it is a rigid body, if so call removeRigidBody otherwise call btCollisionWorld::removeCollisionObject
        /// Generated from method `btDiscreteDynamicsWorldMt::removeCollisionObject`.
        public unsafe void RemoveCollisionObject(Bullet.BtCollisionObject? collisionObject)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_removeCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_removeCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_removeCollisionObject(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject);
            __btDiscreteDynamicsWorldMt_removeCollisionObject(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::debugDrawWorld`.
        public unsafe void DebugDrawWorld()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_debugDrawWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_debugDrawWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_debugDrawWorld(_Underlying *_this);
            __btDiscreteDynamicsWorldMt_debugDrawWorld(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::setConstraintSolver`.
        public unsafe void SetConstraintSolver(Bullet.BtConstraintSolver? solver)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_setConstraintSolver(_Underlying *_this, Bullet.BtConstraintSolver._Underlying *solver);
            __btDiscreteDynamicsWorldMt_setConstraintSolver(_UnderlyingPtr, solver is not null ? solver._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getConstraintSolver`.
        public unsafe Bullet.BtConstraintSolver? GetConstraintSolver()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolver._Underlying *__btDiscreteDynamicsWorldMt_getConstraintSolver(_Underlying *_this);
            var __c_ret = __btDiscreteDynamicsWorldMt_getConstraintSolver(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtConstraintSolver(__c_ret, is_owning: false) : null;
        }

        ///the forces on each rigidbody is accumulating together with gravity. clear this after each timestep.
        /// Generated from method `btDiscreteDynamicsWorldMt::clearForces`.
        public unsafe void ClearForces()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_clearForces", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_clearForces", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_clearForces(_Underlying *_this);
            __btDiscreteDynamicsWorldMt_clearForces(_UnderlyingPtr);
        }

        ///apply gravity, call this once per timestep
        /// Generated from method `btDiscreteDynamicsWorldMt::applyGravity`.
        public unsafe void ApplyGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_applyGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_applyGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_applyGravity(_Underlying *_this);
            __btDiscreteDynamicsWorldMt_applyGravity(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::setNumTasks`.
        public unsafe void SetNumTasks(int numTasks)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setNumTasks", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setNumTasks", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_setNumTasks(_Underlying *_this, int numTasks);
            __btDiscreteDynamicsWorldMt_setNumTasks(_UnderlyingPtr, numTasks);
        }

        ///obsolete, use updateActions instead
        /// Generated from method `btDiscreteDynamicsWorldMt::updateVehicles`.
        public unsafe void UpdateVehicles(double timeStep)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_updateVehicles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_updateVehicles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_updateVehicles(_Underlying *_this, double timeStep);
            __btDiscreteDynamicsWorldMt_updateVehicles(_UnderlyingPtr, timeStep);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::setSynchronizeAllMotionStates`.
        public unsafe void SetSynchronizeAllMotionStates(bool synchronizeAll)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setSynchronizeAllMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setSynchronizeAllMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_setSynchronizeAllMotionStates(_Underlying *_this, byte synchronizeAll);
            __btDiscreteDynamicsWorldMt_setSynchronizeAllMotionStates(_UnderlyingPtr, synchronizeAll ? (byte)1 : (byte)0);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::setApplySpeculativeContactRestitution`.
        public unsafe void SetApplySpeculativeContactRestitution(bool enable)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setApplySpeculativeContactRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setApplySpeculativeContactRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_setApplySpeculativeContactRestitution(_Underlying *_this, byte enable);
            __btDiscreteDynamicsWorldMt_setApplySpeculativeContactRestitution(_UnderlyingPtr, enable ? (byte)1 : (byte)0);
        }

        ///Interpolate motion state between previous and current transform, instead of current and next transform.
        ///This can relieve discontinuities in the rendering, due to penetrations
        /// Generated from method `btDiscreteDynamicsWorldMt::setLatencyMotionStateInterpolation`.
        public unsafe void SetLatencyMotionStateInterpolation(bool latencyInterpolation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setLatencyMotionStateInterpolation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setLatencyMotionStateInterpolation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_setLatencyMotionStateInterpolation(_Underlying *_this, byte latencyInterpolation);
            __btDiscreteDynamicsWorldMt_setLatencyMotionStateInterpolation(_UnderlyingPtr, latencyInterpolation ? (byte)1 : (byte)0);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::setWorldUserInfo`.
        /// Parameter `worldUserInfo` is a mutable pointer.
        public unsafe void SetWorldUserInfo(void *worldUserInfo)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_setWorldUserInfo(_Underlying *_this, void *worldUserInfo);
            __btDiscreteDynamicsWorldMt_setWorldUserInfo(_UnderlyingPtr, worldUserInfo);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::setBroadphase`.
        public unsafe void SetBroadphase(Bullet.BtBroadphaseInterface? pairCache)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_setBroadphase(_Underlying *_this, Bullet.BtBroadphaseInterface._Underlying *pairCache);
            __btDiscreteDynamicsWorldMt_setBroadphase(_UnderlyingPtr, pairCache is not null ? pairCache._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::getPairCache`.
        public unsafe Bullet.BtOverlappingPairCache? GetPairCache()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_getPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtOverlappingPairCache._Underlying *__btDiscreteDynamicsWorldMt_getPairCache(_Underlying *_this);
            var __c_ret = __btDiscreteDynamicsWorldMt_getPairCache(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtOverlappingPairCache(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::updateSingleAabb`.
        public unsafe void UpdateSingleAabb(Bullet.BtCollisionObject? colObj)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_updateSingleAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_updateSingleAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_updateSingleAabb(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObj);
            __btDiscreteDynamicsWorldMt_updateSingleAabb(_UnderlyingPtr, colObj is not null ? colObj._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::updateAabbs`.
        public unsafe void UpdateAabbs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_updateAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_updateAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_updateAabbs(_Underlying *_this);
            __btDiscreteDynamicsWorldMt_updateAabbs(_UnderlyingPtr);
        }

        ///the computeOverlappingPairs is usually already called by performDiscreteCollisionDetection (or stepSimulation)
        ///it can be useful to use if you perform ray tests without collision detection/simulation
        /// Generated from method `btDiscreteDynamicsWorldMt::computeOverlappingPairs`.
        public unsafe void ComputeOverlappingPairs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_computeOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_computeOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_computeOverlappingPairs(_Underlying *_this);
            __btDiscreteDynamicsWorldMt_computeOverlappingPairs(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::debugDrawObject`.
        public unsafe void DebugDrawObject(Bullet.Const_BtTransform worldTransform, Bullet.Const_BtCollisionShape? shape, Bullet.Const_BtVector3 color)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_debugDrawObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_debugDrawObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_debugDrawObject(_Underlying *_this, Bullet.Const_BtTransform._Underlying *worldTransform, Bullet.Const_BtCollisionShape._Underlying *shape, Bullet.Const_BtVector3._Underlying *color);
            __btDiscreteDynamicsWorldMt_debugDrawObject(_UnderlyingPtr, worldTransform._UnderlyingPtr, shape is not null ? shape._UnderlyingPtr : null, color._UnderlyingPtr);
        }

        ///contactTest performs a discrete collision test between colObj against all objects in the btCollisionWorld, and calls the resultCallback.
        ///it reports one or more contact points for every overlapping object (including the one with deepest penetration)
        /// Generated from method `btDiscreteDynamicsWorldMt::contactTest`.
        public unsafe void ContactTest(Bullet.BtCollisionObject? colObj, Bullet.BtCollisionWorld.ContactResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_contactTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_contactTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_contactTest(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObj, Bullet.BtCollisionWorld.ContactResultCallback._Underlying *resultCallback);
            __btDiscreteDynamicsWorldMt_contactTest(_UnderlyingPtr, colObj is not null ? colObj._UnderlyingPtr : null, resultCallback._UnderlyingPtr);
        }

        ///contactTest performs a discrete collision test between two collision objects and calls the resultCallback if overlap if detected.
        ///it reports one or more contact points (including the one with deepest penetration)
        /// Generated from method `btDiscreteDynamicsWorldMt::contactPairTest`.
        public unsafe void ContactPairTest(Bullet.BtCollisionObject? colObjA, Bullet.BtCollisionObject? colObjB, Bullet.BtCollisionWorld.ContactResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_contactPairTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_contactPairTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_contactPairTest(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObjA, Bullet.BtCollisionObject._Underlying *colObjB, Bullet.BtCollisionWorld.ContactResultCallback._Underlying *resultCallback);
            __btDiscreteDynamicsWorldMt_contactPairTest(_UnderlyingPtr, colObjA is not null ? colObjA._UnderlyingPtr : null, colObjB is not null ? colObjB._UnderlyingPtr : null, resultCallback._UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::refreshBroadphaseProxy`.
        public unsafe void RefreshBroadphaseProxy(Bullet.BtCollisionObject? collisionObject)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_refreshBroadphaseProxy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_refreshBroadphaseProxy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_refreshBroadphaseProxy(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject);
            __btDiscreteDynamicsWorldMt_refreshBroadphaseProxy(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::performDiscreteCollisionDetection`.
        public unsafe void PerformDiscreteCollisionDetection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_performDiscreteCollisionDetection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_performDiscreteCollisionDetection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_performDiscreteCollisionDetection(_Underlying *_this);
            __btDiscreteDynamicsWorldMt_performDiscreteCollisionDetection(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorldMt::setForceUpdateAllAabbs`.
        public unsafe void SetForceUpdateAllAabbs(bool forceUpdateAllAabbs)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorldMt_setForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorldMt_setForceUpdateAllAabbs(_Underlying *_this, byte forceUpdateAllAabbs);
            __btDiscreteDynamicsWorldMt_setForceUpdateAllAabbs(_UnderlyingPtr, forceUpdateAllAabbs ? (byte)1 : (byte)0);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtDiscreteDynamicsWorldMt` by value.
    /// Usage:
    /// * Pass an instance of `BtDiscreteDynamicsWorldMt`/`Const_BtDiscreteDynamicsWorldMt` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtDiscreteDynamicsWorldMt
    {
        #pragma warning disable CS0649
        internal readonly Const_BtDiscreteDynamicsWorldMt? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtDiscreteDynamicsWorldMt(Const_BtDiscreteDynamicsWorldMt new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtDiscreteDynamicsWorldMt(Const_BtDiscreteDynamicsWorldMt arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtDiscreteDynamicsWorldMt` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtDiscreteDynamicsWorldMt`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDiscreteDynamicsWorldMt`/`Const_BtDiscreteDynamicsWorldMt` directly.
    public class _InOptMut_BtDiscreteDynamicsWorldMt
    {
        public BtDiscreteDynamicsWorldMt? Opt;

        public _InOptMut_BtDiscreteDynamicsWorldMt() {}
        public _InOptMut_BtDiscreteDynamicsWorldMt(BtDiscreteDynamicsWorldMt value) {Opt = value;}
        public static implicit operator _InOptMut_BtDiscreteDynamicsWorldMt(BtDiscreteDynamicsWorldMt value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtDiscreteDynamicsWorldMt` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtDiscreteDynamicsWorldMt`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDiscreteDynamicsWorldMt`/`Const_BtDiscreteDynamicsWorldMt` to pass it to the function.
    public class _InOptConst_BtDiscreteDynamicsWorldMt
    {
        public Const_BtDiscreteDynamicsWorldMt? Opt;

        public _InOptConst_BtDiscreteDynamicsWorldMt() {}
        public _InOptConst_BtDiscreteDynamicsWorldMt(Const_BtDiscreteDynamicsWorldMt value) {Opt = value;}
        public static implicit operator _InOptConst_BtDiscreteDynamicsWorldMt(Const_BtDiscreteDynamicsWorldMt value) {return new(value);}
    }
}
