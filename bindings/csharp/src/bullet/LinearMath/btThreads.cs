// machine generated, do not edit
public static partial class Bullet
{
    //
    // btITaskScheduler -- subclass this to implement a task scheduler that can dispatch work to
    //                     worker threads
    //
    /// Generated from class `btITaskScheduler`.
    /// This is the const half of the class.
    public class Const_BtITaskScheduler : Bullet.Object<Const_BtITaskScheduler>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btITaskScheduler_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btITaskScheduler_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btITaskScheduler_Destroy(_Underlying *_this);
            __btITaskScheduler_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtITaskScheduler() {Dispose(false);}

        internal unsafe Const_BtITaskScheduler(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btITaskScheduler::getName`.
        public unsafe byte? GetName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btITaskScheduler_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btITaskScheduler_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__btITaskScheduler_getName(_Underlying *_this);
            var __c_ret = __btITaskScheduler_getName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btITaskScheduler::getMaxNumThreads`.
        public unsafe int GetMaxNumThreads()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btITaskScheduler_getMaxNumThreads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btITaskScheduler_getMaxNumThreads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btITaskScheduler_getMaxNumThreads(_Underlying *_this);
            return __btITaskScheduler_getMaxNumThreads(_UnderlyingPtr);
        }

        /// Generated from method `btITaskScheduler::getNumThreads`.
        public unsafe int GetNumThreads()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btITaskScheduler_getNumThreads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btITaskScheduler_getNumThreads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btITaskScheduler_getNumThreads(_Underlying *_this);
            return __btITaskScheduler_getNumThreads(_UnderlyingPtr);
        }
    }

    //
    // btITaskScheduler -- subclass this to implement a task scheduler that can dispatch work to
    //                     worker threads
    //
    /// Generated from class `btITaskScheduler`.
    /// This is the non-const half of the class.
    public class BtITaskScheduler : Const_BtITaskScheduler
    {
        internal unsafe BtITaskScheduler(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from method `btITaskScheduler::setNumThreads`.
        public unsafe void SetNumThreads(int numThreads)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btITaskScheduler_setNumThreads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btITaskScheduler_setNumThreads", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btITaskScheduler_setNumThreads(_Underlying *_this, int numThreads);
            __btITaskScheduler_setNumThreads(_UnderlyingPtr, numThreads);
        }

        /// Generated from method `btITaskScheduler::sleepWorkerThreadsHint`.
        public unsafe void SleepWorkerThreadsHint()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btITaskScheduler_sleepWorkerThreadsHint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btITaskScheduler_sleepWorkerThreadsHint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btITaskScheduler_sleepWorkerThreadsHint(_Underlying *_this);
            __btITaskScheduler_sleepWorkerThreadsHint(_UnderlyingPtr);
        }

        // internal use only
        /// Generated from method `btITaskScheduler::activate`.
        public unsafe void Activate()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btITaskScheduler_activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btITaskScheduler_activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btITaskScheduler_activate(_Underlying *_this);
            __btITaskScheduler_activate(_UnderlyingPtr);
        }

        /// Generated from method `btITaskScheduler::deactivate`.
        public unsafe void Deactivate()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btITaskScheduler_deactivate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btITaskScheduler_deactivate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btITaskScheduler_deactivate(_Underlying *_this);
            __btITaskScheduler_deactivate(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `BtITaskScheduler` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtITaskScheduler`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtITaskScheduler`/`Const_BtITaskScheduler` directly.
    public class _InOptMut_BtITaskScheduler
    {
        public BtITaskScheduler? Opt;

        public _InOptMut_BtITaskScheduler() {}
        public _InOptMut_BtITaskScheduler(BtITaskScheduler value) {Opt = value;}
        public static implicit operator _InOptMut_BtITaskScheduler(BtITaskScheduler value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtITaskScheduler` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtITaskScheduler`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtITaskScheduler`/`Const_BtITaskScheduler` to pass it to the function.
    public class _InOptConst_BtITaskScheduler
    {
        public Const_BtITaskScheduler? Opt;

        public _InOptConst_BtITaskScheduler() {}
        public _InOptConst_BtITaskScheduler(Const_BtITaskScheduler value) {Opt = value;}
        public static implicit operator _InOptConst_BtITaskScheduler(Const_BtITaskScheduler value) {return new(value);}
    }

    // set the task scheduler to use for all calls to btParallelFor()
    // NOTE: you must set this prior to using any of the multi-threaded "Mt" classes
    /// Generated from function `btSetTaskScheduler`.
    public static unsafe void BtSetTaskScheduler(Bullet.BtITaskScheduler? ts)
    {
        #if __IOS__
        [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSetTaskScheduler", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSetTaskScheduler", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static void __btSetTaskScheduler(Bullet.BtITaskScheduler._Underlying *ts);
        __btSetTaskScheduler(ts is not null ? ts._UnderlyingPtr : null);
    }

    // get the current task scheduler
    /// Generated from function `btGetTaskScheduler`.
    public static unsafe Bullet.BtITaskScheduler? BtGetTaskScheduler()
    {
        #if __IOS__
        [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btGetTaskScheduler", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btGetTaskScheduler", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static Bullet.BtITaskScheduler._Underlying *__btGetTaskScheduler();
        var __c_ret = __btGetTaskScheduler();
        return __c_ret is not null ? new Bullet.BtITaskScheduler(__c_ret, is_owning: false) : null;
    }

    // create a default task scheduler (Win32 or pthreads based)
    /// Generated from function `btCreateDefaultTaskScheduler`.
    public static unsafe Bullet.BtITaskScheduler? BtCreateDefaultTaskScheduler()
    {
        #if __IOS__
        [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCreateDefaultTaskScheduler", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #else
        [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCreateDefaultTaskScheduler", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
        #endif
        extern static Bullet.BtITaskScheduler._Underlying *__btCreateDefaultTaskScheduler();
        var __c_ret = __btCreateDefaultTaskScheduler();
        return __c_ret is not null ? new Bullet.BtITaskScheduler(__c_ret, is_owning: false) : null;
    }
}
