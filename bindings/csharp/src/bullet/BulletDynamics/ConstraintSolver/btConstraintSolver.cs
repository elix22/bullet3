// machine generated, do not edit
public static partial class Bullet
{
    /// Generated from class `btConstraintSolver`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btConstraintSolverPoolMt`
    ///     `btSequentialImpulseConstraintSolver`
    ///   Indirect: (non-virtual)
    ///     `btSequentialImpulseConstraintSolverMt`
    /// This is the const half of the class.
    public class Const_BtConstraintSolver : Bullet.Object<Const_BtConstraintSolver>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolver_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolver_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConstraintSolver_Destroy(_Underlying *_this);
            __btConstraintSolver_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtConstraintSolver() {Dispose(false);}

        internal unsafe Const_BtConstraintSolver(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}
    }

    /// Generated from class `btConstraintSolver`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btConstraintSolverPoolMt`
    ///     `btSequentialImpulseConstraintSolver`
    ///   Indirect: (non-virtual)
    ///     `btSequentialImpulseConstraintSolverMt`
    /// This is the non-const half of the class.
    public class BtConstraintSolver : Const_BtConstraintSolver
    {
        internal unsafe BtConstraintSolver(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from method `btConstraintSolver::prepareSolve`.
        public unsafe void PrepareSolve(int _1, int _2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolver_prepareSolve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolver_prepareSolve", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConstraintSolver_prepareSolve(_Underlying *_this, int _1, int _2);
            __btConstraintSolver_prepareSolve(_UnderlyingPtr, _1, _2);
        }

        ///clear internal cached data and reset random seed
        /// Generated from method `btConstraintSolver::reset`.
        public unsafe void Reset()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConstraintSolver_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConstraintSolver_reset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConstraintSolver_reset(_Underlying *_this);
            __btConstraintSolver_reset(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `BtConstraintSolver` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtConstraintSolver`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtConstraintSolver`/`Const_BtConstraintSolver` directly.
    public class _InOptMut_BtConstraintSolver
    {
        public BtConstraintSolver? Opt;

        public _InOptMut_BtConstraintSolver() {}
        public _InOptMut_BtConstraintSolver(BtConstraintSolver value) {Opt = value;}
        public static implicit operator _InOptMut_BtConstraintSolver(BtConstraintSolver value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtConstraintSolver` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtConstraintSolver`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtConstraintSolver`/`Const_BtConstraintSolver` to pass it to the function.
    public class _InOptConst_BtConstraintSolver
    {
        public Const_BtConstraintSolver? Opt;

        public _InOptConst_BtConstraintSolver() {}
        public _InOptConst_BtConstraintSolver(Const_BtConstraintSolver value) {Opt = value;}
        public static implicit operator _InOptConst_BtConstraintSolver(Const_BtConstraintSolver value) {return new(value);}
    }
}
