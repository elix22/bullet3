// machine generated, do not edit
public static partial class Bullet
{
    ///
    /// btSequentialImpulseConstraintSolverMt
    ///
    ///  A multithreaded variant of the sequential impulse constraint solver. The constraints to be solved are grouped into
    ///  batches and phases where each batch of constraints within a given phase can be solved in parallel with the rest.
    ///  Ideally we want as few phases as possible, and each phase should have many batches, and all of the batches should
    ///  have about the same number of constraints.
    ///  This method works best on a large island of many constraints.
    ///
    ///  Supports all of the features of the normal sequential impulse solver such as:
    ///    - split penetration impulse
    ///    - rolling friction
    ///    - interleaving constraints
    ///    - warmstarting
    ///    - 2 friction directions
    ///    - randomized constraint ordering
    ///    - early termination when leastSquaresResidualThreshold is satisfied
    ///
    ///  When the SOLVER_INTERLEAVE_CONTACT_AND_FRICTION_CONSTRAINTS flag is enabled, unlike the normal SequentialImpulse solver,
    ///  the rolling friction is interleaved as well.
    ///  Interleaving the contact penetration constraints with friction reduces the number of parallel loops that need to be done,
    ///  which reduces threading overhead so it can be a performance win, however, it does seem to produce a less stable simulation,
    ///  at least on stacks of blocks.
    ///
    ///  When the SOLVER_RANDMIZE_ORDER flag is enabled, the ordering of phases, and the ordering of constraints within each batch
    ///  is randomized, however it does not swap constraints between batches.
    ///  This is to avoid regenerating the batches for each solver iteration which would be quite costly in performance.
    ///
    ///  Note that a non-zero leastSquaresResidualThreshold could possibly affect the determinism of the simulation
    ///  if the task scheduler's parallelSum operation is non-deterministic. The parallelSum operation can be non-deterministic
    ///  because floating point addition is not associative due to rounding errors.
    ///  The task scheduler can and should ensure that the result of any parallelSum operation is deterministic.
    ///
    /// Generated from class `btSequentialImpulseConstraintSolverMt`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btSequentialImpulseConstraintSolver`
    ///   Indirect: (non-virtual)
    ///     `btConstraintSolver`
    /// This is the const half of the class.
    public class Const_BtSequentialImpulseConstraintSolverMt : Bullet.Object<Const_BtSequentialImpulseConstraintSolverMt>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSequentialImpulseConstraintSolverMt_Destroy(_Underlying *_this);
            __btSequentialImpulseConstraintSolverMt_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtSequentialImpulseConstraintSolverMt() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtConstraintSolver(Const_BtSequentialImpulseConstraintSolverMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConstraintSolver._Underlying *__btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver(_Underlying *_this);
            Bullet.Const_BtConstraintSolver ret = new(__btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtSequentialImpulseConstraintSolver(Const_BtSequentialImpulseConstraintSolverMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtSequentialImpulseConstraintSolver._Underlying *__btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver(_Underlying *_this);
            Bullet.Const_BtSequentialImpulseConstraintSolver ret = new(__btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtSequentialImpulseConstraintSolverMt?(Bullet.Const_BtConstraintSolver parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver(Bullet.Const_BtConstraintSolver._Underlying *_this);
            var ptr = __btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtSequentialImpulseConstraintSolverMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtSequentialImpulseConstraintSolverMt?(Bullet.Const_BtSequentialImpulseConstraintSolver parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver(Bullet.Const_BtSequentialImpulseConstraintSolver._Underlying *_this);
            var ptr = __btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtSequentialImpulseConstraintSolverMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        // whether to allow nested parallel operations
        public static unsafe ref bool SAllowNestedParallelForLoops
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_GetMutable_s_allowNestedParallelForLoops", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_GetMutable_s_allowNestedParallelForLoops", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__btSequentialImpulseConstraintSolverMt_GetMutable_s_allowNestedParallelForLoops();
                return ref *__btSequentialImpulseConstraintSolverMt_GetMutable_s_allowNestedParallelForLoops();
            }
        }

        // don't even try to batch if fewer manifolds than this
        public static unsafe ref int SMinimumContactManifoldsForBatching
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_GetMutable_s_minimumContactManifoldsForBatching", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_GetMutable_s_minimumContactManifoldsForBatching", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btSequentialImpulseConstraintSolverMt_GetMutable_s_minimumContactManifoldsForBatching();
                return ref *__btSequentialImpulseConstraintSolverMt_GetMutable_s_minimumContactManifoldsForBatching();
            }
        }

        // desired number of constraints per batch
        public static unsafe ref int SMinBatchSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_GetMutable_s_minBatchSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_GetMutable_s_minBatchSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btSequentialImpulseConstraintSolverMt_GetMutable_s_minBatchSize();
                return ref *__btSequentialImpulseConstraintSolverMt_GetMutable_s_minBatchSize();
            }
        }

        public static unsafe ref int SMaxBatchSize
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_GetMutable_s_maxBatchSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_GetMutable_s_maxBatchSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btSequentialImpulseConstraintSolverMt_GetMutable_s_maxBatchSize();
                return ref *__btSequentialImpulseConstraintSolverMt_GetMutable_s_maxBatchSize();
            }
        }

        internal unsafe Const_BtSequentialImpulseConstraintSolverMt(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BtSequentialImpulseConstraintSolverMt() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolverMt._Underlying *__btSequentialImpulseConstraintSolverMt_DefaultConstruct();
            _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_DefaultConstruct();
        }

        /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btSequentialImpulseConstraintSolverMt`.
        public unsafe Const_BtSequentialImpulseConstraintSolverMt(Bullet._ByValue_BtSequentialImpulseConstraintSolverMt _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolverMt._Underlying *__btSequentialImpulseConstraintSolverMt_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtSequentialImpulseConstraintSolverMt._Underlying *_other);
            _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btSequentialImpulseConstraintSolverMt`.
        public Const_BtSequentialImpulseConstraintSolverMt(Const_BtSequentialImpulseConstraintSolverMt _other) : this(new _ByValue_BtSequentialImpulseConstraintSolverMt(_other)) {}

        /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btSequentialImpulseConstraintSolverMt`.
        public Const_BtSequentialImpulseConstraintSolverMt(BtSequentialImpulseConstraintSolverMt _other) : this((Const_BtSequentialImpulseConstraintSolverMt)_other) {}

        /// Generated from method `btSequentialImpulseConstraintSolverMt::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr(void *ptr);
            __Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr(ptr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr(void *ptr);
            __Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr(ptr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btSequentialImpulseConstraintSolverMt_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btSequentialImpulseConstraintSolverMt_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::getRandSeed`.
        public unsafe ulong GetRandSeed()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_getRandSeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_getRandSeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __btSequentialImpulseConstraintSolverMt_getRandSeed(_Underlying *_this);
            return __btSequentialImpulseConstraintSolverMt_getRandSeed(_UnderlyingPtr);
        }

        // temp struct used for setting up joint constraints in parallel
        /// Generated from class `btSequentialImpulseConstraintSolverMt::JointParams`.
        /// This is the const half of the class.
        public class Const_JointParams : Bullet.Object<Const_JointParams>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btSequentialImpulseConstraintSolverMt_JointParams_Destroy(_Underlying *_this);
                __btSequentialImpulseConstraintSolverMt_JointParams_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_JointParams() {Dispose(false);}

            public unsafe int mSolverConstraint
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverConstraint(_Underlying *_this);
                    return *__btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverConstraint(_UnderlyingPtr);
                }
            }

            public unsafe int mSolverBodyA
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyA", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyA", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyA(_Underlying *_this);
                    return *__btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyA(_UnderlyingPtr);
                }
            }

            public unsafe int mSolverBodyB
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyB(_Underlying *_this);
                    return *__btSequentialImpulseConstraintSolverMt_JointParams_Get_m_solverBodyB(_UnderlyingPtr);
                }
            }

            internal unsafe Const_JointParams(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_JointParams() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *__btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct();
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct();
            }

            /// Constructs `btSequentialImpulseConstraintSolverMt::JointParams` elementwise.
            public unsafe Const_JointParams(int m_solverConstraint, int m_solverBodyA, int m_solverBodyB) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *__btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom(int m_solverConstraint, int m_solverBodyA, int m_solverBodyB);
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom(m_solverConstraint, m_solverBodyA, m_solverBodyB);
            }

            /// Generated from constructor `btSequentialImpulseConstraintSolverMt::JointParams::JointParams`.
            public unsafe Const_JointParams(Bullet.BtSequentialImpulseConstraintSolverMt.Const_JointParams _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *__btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother(Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *_other);
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btSequentialImpulseConstraintSolverMt::JointParams::JointParams`.
            public Const_JointParams(JointParams _other) : this((Const_JointParams)_other) {}
        }

        // temp struct used for setting up joint constraints in parallel
        /// Generated from class `btSequentialImpulseConstraintSolverMt::JointParams`.
        /// This is the non-const half of the class.
        public class JointParams : Const_JointParams
        {
            public new unsafe ref int mSolverConstraint
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverConstraint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverConstraint(_Underlying *_this);
                    return ref *__btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverConstraint(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mSolverBodyA
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyA", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyA", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyA(_Underlying *_this);
                    return ref *__btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyA(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mSolverBodyB
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyB", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyB(_Underlying *_this);
                    return ref *__btSequentialImpulseConstraintSolverMt_JointParams_GetMutable_m_solverBodyB(_UnderlyingPtr);
                }
            }

            internal unsafe JointParams(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe JointParams() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *__btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct();
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_JointParams_DefaultConstruct();
            }

            /// Constructs `btSequentialImpulseConstraintSolverMt::JointParams` elementwise.
            public unsafe JointParams(int m_solverConstraint, int m_solverBodyA, int m_solverBodyB) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *__btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom(int m_solverConstraint, int m_solverBodyA, int m_solverBodyB);
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_JointParams_ConstructFrom(m_solverConstraint, m_solverBodyA, m_solverBodyB);
            }

            /// Generated from constructor `btSequentialImpulseConstraintSolverMt::JointParams::JointParams`.
            public unsafe JointParams(Bullet.BtSequentialImpulseConstraintSolverMt.Const_JointParams _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *__btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother(Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *_other);
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_JointParams_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btSequentialImpulseConstraintSolverMt::JointParams::JointParams`.
            public JointParams(JointParams _other) : this((Const_JointParams)_other) {}

            /// Generated from method `btSequentialImpulseConstraintSolverMt::JointParams::operator=`.
            public unsafe Bullet.BtSequentialImpulseConstraintSolverMt.JointParams Assign(Bullet.BtSequentialImpulseConstraintSolverMt.Const_JointParams _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_JointParams_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *__btSequentialImpulseConstraintSolverMt_JointParams_AssignFromAnother(_Underlying *_this, Bullet.BtSequentialImpulseConstraintSolverMt.JointParams._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__btSequentialImpulseConstraintSolverMt_JointParams_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `JointParams` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_JointParams`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `JointParams`/`Const_JointParams` directly.
        public class _InOptMut_JointParams
        {
            public JointParams? Opt;

            public _InOptMut_JointParams() {}
            public _InOptMut_JointParams(JointParams value) {Opt = value;}
            public static implicit operator _InOptMut_JointParams(JointParams value) {return new(value);}
        }

        /// This is used for optional parameters of class `JointParams` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_JointParams`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `JointParams`/`Const_JointParams` to pass it to the function.
        public class _InOptConst_JointParams
        {
            public Const_JointParams? Opt;

            public _InOptConst_JointParams() {}
            public _InOptConst_JointParams(Const_JointParams value) {Opt = value;}
            public static implicit operator _InOptConst_JointParams(Const_JointParams value) {return new(value);}
        }

        // temp struct used to collect info from persistent manifolds into a cache-friendly struct using multiple threads
        /// Generated from class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo`.
        /// This is the const half of the class.
        public class Const_BtContactManifoldCachedInfo : Bullet.Object<Const_BtContactManifoldCachedInfo>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Destroy(_Underlying *_this);
                __btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_BtContactManifoldCachedInfo() {Dispose(false);}

            public static unsafe int MAXNUMCONTACTPOINTS
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_MAX_NUM_CONTACT_POINTS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_MAX_NUM_CONTACT_POINTS", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_MAX_NUM_CONTACT_POINTS();
                    return *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_MAX_NUM_CONTACT_POINTS();
                }
            }

            public unsafe int numTouchingContacts
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_numTouchingContacts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_numTouchingContacts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_numTouchingContacts(_Underlying *_this);
                    return *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_numTouchingContacts(_UnderlyingPtr);
                }
            }

            public unsafe ref Bullet.ArrayInt2 solverBodyIds
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_solverBodyIds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_solverBodyIds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.ArrayInt2 *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_solverBodyIds(_Underlying *_this);
                    return ref *(__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_solverBodyIds(_UnderlyingPtr));
                }
            }

            public unsafe int contactIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactIndex(_Underlying *_this);
                    return *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactIndex(_UnderlyingPtr);
                }
            }

            public unsafe int rollingFrictionIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_rollingFrictionIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_rollingFrictionIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_rollingFrictionIndex(_Underlying *_this);
                    return *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_rollingFrictionIndex(_UnderlyingPtr);
                }
            }

            public unsafe ref Bullet.ArrayBool4 contactHasRollingFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactHasRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactHasRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.ArrayBool4 *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactHasRollingFriction(_Underlying *_this);
                    return ref *(__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_Get_contactHasRollingFriction(_UnderlyingPtr));
                }
            }

            internal unsafe Const_BtContactManifoldCachedInfo(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_BtContactManifoldCachedInfo() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.BtContactManifoldCachedInfo._Underlying *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct();
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct();
            }

            /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::btContactManifoldCachedInfo`.
            public unsafe Const_BtContactManifoldCachedInfo(Bullet.BtSequentialImpulseConstraintSolverMt.Const_BtContactManifoldCachedInfo _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.BtContactManifoldCachedInfo._Underlying *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother(Bullet.BtSequentialImpulseConstraintSolverMt.BtContactManifoldCachedInfo._Underlying *_other);
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::btContactManifoldCachedInfo`.
            public Const_BtContactManifoldCachedInfo(BtContactManifoldCachedInfo _other) : this((Const_BtContactManifoldCachedInfo)_other) {}
        }

        // temp struct used to collect info from persistent manifolds into a cache-friendly struct using multiple threads
        /// Generated from class `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo`.
        /// This is the non-const half of the class.
        public class BtContactManifoldCachedInfo : Const_BtContactManifoldCachedInfo
        {
            public new unsafe ref int numTouchingContacts
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_numTouchingContacts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_numTouchingContacts", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_numTouchingContacts(_Underlying *_this);
                    return ref *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_numTouchingContacts(_UnderlyingPtr);
                }
            }

            new public unsafe ref Bullet.ArrayInt2 solverBodyIds
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_solverBodyIds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_solverBodyIds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.ArrayInt2 *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_solverBodyIds(_Underlying *_this);
                    return ref *(__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_solverBodyIds(_UnderlyingPtr));
                }
            }

            public new unsafe ref int contactIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactIndex(_Underlying *_this);
                    return ref *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactIndex(_UnderlyingPtr);
                }
            }

            public new unsafe ref int rollingFrictionIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_rollingFrictionIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_rollingFrictionIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_rollingFrictionIndex(_Underlying *_this);
                    return ref *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_rollingFrictionIndex(_UnderlyingPtr);
                }
            }

            new public unsafe ref Bullet.ArrayBool4 contactHasRollingFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactHasRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactHasRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.ArrayBool4 *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactHasRollingFriction(_Underlying *_this);
                    return ref *(__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_GetMutable_contactHasRollingFriction(_UnderlyingPtr));
                }
            }

            internal unsafe BtContactManifoldCachedInfo(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe BtContactManifoldCachedInfo() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.BtContactManifoldCachedInfo._Underlying *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct();
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_DefaultConstruct();
            }

            /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::btContactManifoldCachedInfo`.
            public unsafe BtContactManifoldCachedInfo(Bullet.BtSequentialImpulseConstraintSolverMt.Const_BtContactManifoldCachedInfo _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.BtContactManifoldCachedInfo._Underlying *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother(Bullet.BtSequentialImpulseConstraintSolverMt.BtContactManifoldCachedInfo._Underlying *_other);
                _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::btContactManifoldCachedInfo`.
            public BtContactManifoldCachedInfo(BtContactManifoldCachedInfo _other) : this((Const_BtContactManifoldCachedInfo)_other) {}

            /// Generated from method `btSequentialImpulseConstraintSolverMt::btContactManifoldCachedInfo::operator=`.
            public unsafe Bullet.BtSequentialImpulseConstraintSolverMt.BtContactManifoldCachedInfo Assign(Bullet.BtSequentialImpulseConstraintSolverMt.Const_BtContactManifoldCachedInfo _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtSequentialImpulseConstraintSolverMt.BtContactManifoldCachedInfo._Underlying *__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_AssignFromAnother(_Underlying *_this, Bullet.BtSequentialImpulseConstraintSolverMt.BtContactManifoldCachedInfo._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__btSequentialImpulseConstraintSolverMt_btContactManifoldCachedInfo_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `BtContactManifoldCachedInfo` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_BtContactManifoldCachedInfo`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `BtContactManifoldCachedInfo`/`Const_BtContactManifoldCachedInfo` directly.
        public class _InOptMut_BtContactManifoldCachedInfo
        {
            public BtContactManifoldCachedInfo? Opt;

            public _InOptMut_BtContactManifoldCachedInfo() {}
            public _InOptMut_BtContactManifoldCachedInfo(BtContactManifoldCachedInfo value) {Opt = value;}
            public static implicit operator _InOptMut_BtContactManifoldCachedInfo(BtContactManifoldCachedInfo value) {return new(value);}
        }

        /// This is used for optional parameters of class `BtContactManifoldCachedInfo` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_BtContactManifoldCachedInfo`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `BtContactManifoldCachedInfo`/`Const_BtContactManifoldCachedInfo` to pass it to the function.
        public class _InOptConst_BtContactManifoldCachedInfo
        {
            public Const_BtContactManifoldCachedInfo? Opt;

            public _InOptConst_BtContactManifoldCachedInfo() {}
            public _InOptConst_BtContactManifoldCachedInfo(Const_BtContactManifoldCachedInfo value) {Opt = value;}
            public static implicit operator _InOptConst_BtContactManifoldCachedInfo(Const_BtContactManifoldCachedInfo value) {return new(value);}
        }
    }

    ///
    /// btSequentialImpulseConstraintSolverMt
    ///
    ///  A multithreaded variant of the sequential impulse constraint solver. The constraints to be solved are grouped into
    ///  batches and phases where each batch of constraints within a given phase can be solved in parallel with the rest.
    ///  Ideally we want as few phases as possible, and each phase should have many batches, and all of the batches should
    ///  have about the same number of constraints.
    ///  This method works best on a large island of many constraints.
    ///
    ///  Supports all of the features of the normal sequential impulse solver such as:
    ///    - split penetration impulse
    ///    - rolling friction
    ///    - interleaving constraints
    ///    - warmstarting
    ///    - 2 friction directions
    ///    - randomized constraint ordering
    ///    - early termination when leastSquaresResidualThreshold is satisfied
    ///
    ///  When the SOLVER_INTERLEAVE_CONTACT_AND_FRICTION_CONSTRAINTS flag is enabled, unlike the normal SequentialImpulse solver,
    ///  the rolling friction is interleaved as well.
    ///  Interleaving the contact penetration constraints with friction reduces the number of parallel loops that need to be done,
    ///  which reduces threading overhead so it can be a performance win, however, it does seem to produce a less stable simulation,
    ///  at least on stacks of blocks.
    ///
    ///  When the SOLVER_RANDMIZE_ORDER flag is enabled, the ordering of phases, and the ordering of constraints within each batch
    ///  is randomized, however it does not swap constraints between batches.
    ///  This is to avoid regenerating the batches for each solver iteration which would be quite costly in performance.
    ///
    ///  Note that a non-zero leastSquaresResidualThreshold could possibly affect the determinism of the simulation
    ///  if the task scheduler's parallelSum operation is non-deterministic. The parallelSum operation can be non-deterministic
    ///  because floating point addition is not associative due to rounding errors.
    ///  The task scheduler can and should ensure that the result of any parallelSum operation is deterministic.
    ///
    /// Generated from class `btSequentialImpulseConstraintSolverMt`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btSequentialImpulseConstraintSolver`
    ///   Indirect: (non-virtual)
    ///     `btConstraintSolver`
    /// This is the non-const half of the class.
    public class BtSequentialImpulseConstraintSolverMt : Const_BtSequentialImpulseConstraintSolverMt
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtConstraintSolver(BtSequentialImpulseConstraintSolverMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolver._Underlying *__btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver(_Underlying *_this);
            Bullet.BtConstraintSolver ret = new(__btSequentialImpulseConstraintSolverMt_UpcastTo_btConstraintSolver(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtSequentialImpulseConstraintSolver(BtSequentialImpulseConstraintSolverMt self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolver._Underlying *__btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver(_Underlying *_this);
            Bullet.BtSequentialImpulseConstraintSolver ret = new(__btSequentialImpulseConstraintSolverMt_UpcastTo_btSequentialImpulseConstraintSolver(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtSequentialImpulseConstraintSolverMt?(Bullet.BtConstraintSolver parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver(Bullet.BtConstraintSolver._Underlying *_this);
            var ptr = __btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btConstraintSolver(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtSequentialImpulseConstraintSolverMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtSequentialImpulseConstraintSolverMt?(Bullet.BtSequentialImpulseConstraintSolver parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver(Bullet.BtSequentialImpulseConstraintSolver._Underlying *_this);
            var ptr = __btSequentialImpulseConstraintSolverMt_DynamicDowncastFrom_btSequentialImpulseConstraintSolver(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtSequentialImpulseConstraintSolverMt ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtSequentialImpulseConstraintSolverMt(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BtSequentialImpulseConstraintSolverMt() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolverMt._Underlying *__btSequentialImpulseConstraintSolverMt_DefaultConstruct();
            _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_DefaultConstruct();
        }

        /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btSequentialImpulseConstraintSolverMt`.
        public unsafe BtSequentialImpulseConstraintSolverMt(Bullet._ByValue_BtSequentialImpulseConstraintSolverMt _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolverMt._Underlying *__btSequentialImpulseConstraintSolverMt_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtSequentialImpulseConstraintSolverMt._Underlying *_other);
            _UnderlyingPtr = __btSequentialImpulseConstraintSolverMt_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btSequentialImpulseConstraintSolverMt`.
        public BtSequentialImpulseConstraintSolverMt(Const_BtSequentialImpulseConstraintSolverMt _other) : this(new _ByValue_BtSequentialImpulseConstraintSolverMt(_other)) {}

        /// Generated from constructor `btSequentialImpulseConstraintSolverMt::btSequentialImpulseConstraintSolverMt`.
        public BtSequentialImpulseConstraintSolverMt(BtSequentialImpulseConstraintSolverMt _other) : this((Const_BtSequentialImpulseConstraintSolverMt)_other) {}

        /// Generated from method `btSequentialImpulseConstraintSolverMt::operator=`.
        public unsafe Bullet.BtSequentialImpulseConstraintSolverMt Assign(Bullet._ByValue_BtSequentialImpulseConstraintSolverMt _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolverMt._Underlying *__btSequentialImpulseConstraintSolverMt_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtSequentialImpulseConstraintSolverMt._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btSequentialImpulseConstraintSolverMt_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::internalAllocContactConstraints`.
        public unsafe void InternalAllocContactConstraints(Bullet.BtSequentialImpulseConstraintSolverMt.Const_BtContactManifoldCachedInfo? cachedInfoArray, int numManifolds)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_internalAllocContactConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_internalAllocContactConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSequentialImpulseConstraintSolverMt_internalAllocContactConstraints(_Underlying *_this, Bullet.BtSequentialImpulseConstraintSolverMt.Const_BtContactManifoldCachedInfo._Underlying *cachedInfoArray, int numManifolds);
            __btSequentialImpulseConstraintSolverMt_internalAllocContactConstraints(_UnderlyingPtr, cachedInfoArray is not null ? cachedInfoArray._UnderlyingPtr : null, numManifolds);
        }

        ///clear internal cached data and reset random seed
        /// Generated from method `btSequentialImpulseConstraintSolverMt::reset`.
        public unsafe void Reset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSequentialImpulseConstraintSolverMt_reset(_Underlying *_this);
            __btSequentialImpulseConstraintSolverMt_reset(_UnderlyingPtr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::btRand2`.
        public unsafe ulong BtRand2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btRand2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btRand2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __btSequentialImpulseConstraintSolverMt_btRand2(_Underlying *_this);
            return __btSequentialImpulseConstraintSolverMt_btRand2(_UnderlyingPtr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::btRandInt2`.
        public unsafe int BtRandInt2(int n)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btRandInt2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_btRandInt2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btSequentialImpulseConstraintSolverMt_btRandInt2(_Underlying *_this, int n);
            return __btSequentialImpulseConstraintSolverMt_btRandInt2(_UnderlyingPtr, n);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::setRandSeed`.
        public unsafe void SetRandSeed(ulong seed)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_setRandSeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_setRandSeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSequentialImpulseConstraintSolverMt_setRandSeed(_Underlying *_this, ulong seed);
            __btSequentialImpulseConstraintSolverMt_setRandSeed(_UnderlyingPtr, seed);
        }

        /// Generated from method `btSequentialImpulseConstraintSolverMt::prepareSolve`.
        public unsafe void PrepareSolve(int _1, int _2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_prepareSolve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolverMt_prepareSolve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSequentialImpulseConstraintSolverMt_prepareSolve(_Underlying *_this, int _1, int _2);
            __btSequentialImpulseConstraintSolverMt_prepareSolve(_UnderlyingPtr, _1, _2);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtSequentialImpulseConstraintSolverMt` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `BtSequentialImpulseConstraintSolverMt`/`Const_BtSequentialImpulseConstraintSolverMt` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtSequentialImpulseConstraintSolverMt
    {
        #pragma warning disable CS0649
        internal readonly Const_BtSequentialImpulseConstraintSolverMt? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtSequentialImpulseConstraintSolverMt() {PassByMode = Bullet._PassBy.default_construct;}
        public _ByValue_BtSequentialImpulseConstraintSolverMt(Const_BtSequentialImpulseConstraintSolverMt new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtSequentialImpulseConstraintSolverMt(Const_BtSequentialImpulseConstraintSolverMt arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtSequentialImpulseConstraintSolverMt` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtSequentialImpulseConstraintSolverMt`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtSequentialImpulseConstraintSolverMt`/`Const_BtSequentialImpulseConstraintSolverMt` directly.
    public class _InOptMut_BtSequentialImpulseConstraintSolverMt
    {
        public BtSequentialImpulseConstraintSolverMt? Opt;

        public _InOptMut_BtSequentialImpulseConstraintSolverMt() {}
        public _InOptMut_BtSequentialImpulseConstraintSolverMt(BtSequentialImpulseConstraintSolverMt value) {Opt = value;}
        public static implicit operator _InOptMut_BtSequentialImpulseConstraintSolverMt(BtSequentialImpulseConstraintSolverMt value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtSequentialImpulseConstraintSolverMt` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtSequentialImpulseConstraintSolverMt`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtSequentialImpulseConstraintSolverMt`/`Const_BtSequentialImpulseConstraintSolverMt` to pass it to the function.
    public class _InOptConst_BtSequentialImpulseConstraintSolverMt
    {
        public Const_BtSequentialImpulseConstraintSolverMt? Opt;

        public _InOptConst_BtSequentialImpulseConstraintSolverMt() {}
        public _InOptConst_BtSequentialImpulseConstraintSolverMt(Const_BtSequentialImpulseConstraintSolverMt value) {Opt = value;}
        public static implicit operator _InOptConst_BtSequentialImpulseConstraintSolverMt(Const_BtSequentialImpulseConstraintSolverMt value) {return new(value);}
    }
}
