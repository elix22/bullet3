// machine generated, do not edit
public static partial class Bullet
{
    ///The btSequentialImpulseConstraintSolver is a fast SIMD implementation of the Projected Gauss Seidel (iterative LCP) method.
    /// Generated from class `btSequentialImpulseConstraintSolver`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConstraintSolver`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btSequentialImpulseConstraintSolverMt`
    /// This is the const half of the class.
    public class Const_BtSequentialImpulseConstraintSolver : Bullet.Object<Const_BtSequentialImpulseConstraintSolver>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSequentialImpulseConstraintSolver_Destroy(_Underlying *_this);
            __btSequentialImpulseConstraintSolver_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtSequentialImpulseConstraintSolver() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtConstraintSolver(Const_BtSequentialImpulseConstraintSolver self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConstraintSolver._Underlying *__btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver(_Underlying *_this);
            Bullet.Const_BtConstraintSolver ret = new(__btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtSequentialImpulseConstraintSolver?(Bullet.Const_BtConstraintSolver parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver(Bullet.Const_BtConstraintSolver._Underlying *_this);
            var ptr = __btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtSequentialImpulseConstraintSolver ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtSequentialImpulseConstraintSolver(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BtSequentialImpulseConstraintSolver() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolver._Underlying *__btSequentialImpulseConstraintSolver_DefaultConstruct();
            _UnderlyingPtr = __btSequentialImpulseConstraintSolver_DefaultConstruct();
        }

        /// Generated from constructor `btSequentialImpulseConstraintSolver::btSequentialImpulseConstraintSolver`.
        public unsafe Const_BtSequentialImpulseConstraintSolver(Bullet._ByValue_BtSequentialImpulseConstraintSolver _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolver._Underlying *__btSequentialImpulseConstraintSolver_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtSequentialImpulseConstraintSolver._Underlying *_other);
            _UnderlyingPtr = __btSequentialImpulseConstraintSolver_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btSequentialImpulseConstraintSolver::btSequentialImpulseConstraintSolver`.
        public Const_BtSequentialImpulseConstraintSolver(Const_BtSequentialImpulseConstraintSolver _other) : this(new _ByValue_BtSequentialImpulseConstraintSolver(_other)) {}

        /// Generated from constructor `btSequentialImpulseConstraintSolver::btSequentialImpulseConstraintSolver`.
        public Const_BtSequentialImpulseConstraintSolver(BtSequentialImpulseConstraintSolver _other) : this((Const_BtSequentialImpulseConstraintSolver)_other) {}

        /// Generated from method `btSequentialImpulseConstraintSolver::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr(void *ptr);
            __Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr(ptr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btSequentialImpulseConstraintSolver_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr(void *ptr);
            __Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr(ptr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btSequentialImpulseConstraintSolver_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btSequentialImpulseConstraintSolver_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::getRandSeed`.
        public unsafe ulong GetRandSeed()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_getRandSeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_getRandSeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __btSequentialImpulseConstraintSolver_getRandSeed(_Underlying *_this);
            return __btSequentialImpulseConstraintSolver_getRandSeed(_UnderlyingPtr);
        }
    }

    ///The btSequentialImpulseConstraintSolver is a fast SIMD implementation of the Projected Gauss Seidel (iterative LCP) method.
    /// Generated from class `btSequentialImpulseConstraintSolver`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConstraintSolver`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btSequentialImpulseConstraintSolverMt`
    /// This is the non-const half of the class.
    public class BtSequentialImpulseConstraintSolver : Const_BtSequentialImpulseConstraintSolver
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtConstraintSolver(BtSequentialImpulseConstraintSolver self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolver._Underlying *__btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver(_Underlying *_this);
            Bullet.BtConstraintSolver ret = new(__btSequentialImpulseConstraintSolver_UpcastTo_btConstraintSolver(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtSequentialImpulseConstraintSolver?(Bullet.BtConstraintSolver parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver(Bullet.BtConstraintSolver._Underlying *_this);
            var ptr = __btSequentialImpulseConstraintSolver_DynamicDowncastFrom_btConstraintSolver(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtSequentialImpulseConstraintSolver ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtSequentialImpulseConstraintSolver(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BtSequentialImpulseConstraintSolver() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolver._Underlying *__btSequentialImpulseConstraintSolver_DefaultConstruct();
            _UnderlyingPtr = __btSequentialImpulseConstraintSolver_DefaultConstruct();
        }

        /// Generated from constructor `btSequentialImpulseConstraintSolver::btSequentialImpulseConstraintSolver`.
        public unsafe BtSequentialImpulseConstraintSolver(Bullet._ByValue_BtSequentialImpulseConstraintSolver _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolver._Underlying *__btSequentialImpulseConstraintSolver_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtSequentialImpulseConstraintSolver._Underlying *_other);
            _UnderlyingPtr = __btSequentialImpulseConstraintSolver_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btSequentialImpulseConstraintSolver::btSequentialImpulseConstraintSolver`.
        public BtSequentialImpulseConstraintSolver(Const_BtSequentialImpulseConstraintSolver _other) : this(new _ByValue_BtSequentialImpulseConstraintSolver(_other)) {}

        /// Generated from constructor `btSequentialImpulseConstraintSolver::btSequentialImpulseConstraintSolver`.
        public BtSequentialImpulseConstraintSolver(BtSequentialImpulseConstraintSolver _other) : this((Const_BtSequentialImpulseConstraintSolver)_other) {}

        /// Generated from method `btSequentialImpulseConstraintSolver::operator=`.
        public unsafe Bullet.BtSequentialImpulseConstraintSolver Assign(Bullet._ByValue_BtSequentialImpulseConstraintSolver _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSequentialImpulseConstraintSolver._Underlying *__btSequentialImpulseConstraintSolver_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtSequentialImpulseConstraintSolver._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btSequentialImpulseConstraintSolver_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        ///clear internal cached data and reset random seed
        /// Generated from method `btSequentialImpulseConstraintSolver::reset`.
        public unsafe void Reset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSequentialImpulseConstraintSolver_reset(_Underlying *_this);
            __btSequentialImpulseConstraintSolver_reset(_UnderlyingPtr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::btRand2`.
        public unsafe ulong BtRand2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_btRand2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_btRand2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static ulong __btSequentialImpulseConstraintSolver_btRand2(_Underlying *_this);
            return __btSequentialImpulseConstraintSolver_btRand2(_UnderlyingPtr);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::btRandInt2`.
        public unsafe int BtRandInt2(int n)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_btRandInt2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_btRandInt2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btSequentialImpulseConstraintSolver_btRandInt2(_Underlying *_this, int n);
            return __btSequentialImpulseConstraintSolver_btRandInt2(_UnderlyingPtr, n);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::setRandSeed`.
        public unsafe void SetRandSeed(ulong seed)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_setRandSeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_setRandSeed", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSequentialImpulseConstraintSolver_setRandSeed(_Underlying *_this, ulong seed);
            __btSequentialImpulseConstraintSolver_setRandSeed(_UnderlyingPtr, seed);
        }

        /// Generated from method `btSequentialImpulseConstraintSolver::prepareSolve`.
        public unsafe void PrepareSolve(int _1, int _2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_prepareSolve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSequentialImpulseConstraintSolver_prepareSolve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSequentialImpulseConstraintSolver_prepareSolve(_Underlying *_this, int _1, int _2);
            __btSequentialImpulseConstraintSolver_prepareSolve(_UnderlyingPtr, _1, _2);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtSequentialImpulseConstraintSolver` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `BtSequentialImpulseConstraintSolver`/`Const_BtSequentialImpulseConstraintSolver` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtSequentialImpulseConstraintSolver
    {
        #pragma warning disable CS0649
        internal readonly Const_BtSequentialImpulseConstraintSolver? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtSequentialImpulseConstraintSolver() {PassByMode = Bullet._PassBy.default_construct;}
        public _ByValue_BtSequentialImpulseConstraintSolver(Const_BtSequentialImpulseConstraintSolver new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtSequentialImpulseConstraintSolver(Const_BtSequentialImpulseConstraintSolver arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtSequentialImpulseConstraintSolver` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtSequentialImpulseConstraintSolver`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtSequentialImpulseConstraintSolver`/`Const_BtSequentialImpulseConstraintSolver` directly.
    public class _InOptMut_BtSequentialImpulseConstraintSolver
    {
        public BtSequentialImpulseConstraintSolver? Opt;

        public _InOptMut_BtSequentialImpulseConstraintSolver() {}
        public _InOptMut_BtSequentialImpulseConstraintSolver(BtSequentialImpulseConstraintSolver value) {Opt = value;}
        public static implicit operator _InOptMut_BtSequentialImpulseConstraintSolver(BtSequentialImpulseConstraintSolver value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtSequentialImpulseConstraintSolver` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtSequentialImpulseConstraintSolver`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtSequentialImpulseConstraintSolver`/`Const_BtSequentialImpulseConstraintSolver` to pass it to the function.
    public class _InOptConst_BtSequentialImpulseConstraintSolver
    {
        public Const_BtSequentialImpulseConstraintSolver? Opt;

        public _InOptConst_BtSequentialImpulseConstraintSolver() {}
        public _InOptConst_BtSequentialImpulseConstraintSolver(Const_BtSequentialImpulseConstraintSolver value) {Opt = value;}
        public static implicit operator _InOptConst_BtSequentialImpulseConstraintSolver(Const_BtSequentialImpulseConstraintSolver value) {return new(value);}
    }
}
