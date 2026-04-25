// machine generated, do not edit
public static partial class Bullet
{
    ///The btDefaultMotionState provides a common implementation to synchronize world transforms with offsets.
    /// Generated from class `btDefaultMotionState`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btMotionState`
    /// This is the const half of the class.
    public class Const_BtDefaultMotionState : Bullet.Object<Const_BtDefaultMotionState>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDefaultMotionState_Destroy(_Underlying *_this);
            __btDefaultMotionState_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtDefaultMotionState() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtMotionState(Const_BtDefaultMotionState self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_UpcastTo_btMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_UpcastTo_btMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtMotionState._Underlying *__btDefaultMotionState_UpcastTo_btMotionState(_Underlying *_this);
            Bullet.Const_BtMotionState ret = new(__btDefaultMotionState_UpcastTo_btMotionState(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtDefaultMotionState?(Bullet.Const_BtMotionState parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_DynamicDowncastFrom_btMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_DynamicDowncastFrom_btMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDefaultMotionState_DynamicDowncastFrom_btMotionState(Bullet.Const_BtMotionState._Underlying *_this);
            var ptr = __btDefaultMotionState_DynamicDowncastFrom_btMotionState(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtDefaultMotionState ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public unsafe Bullet.Const_BtTransform mGraphicsWorldTrans
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_Get_m_graphicsWorldTrans", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_Get_m_graphicsWorldTrans", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.Const_BtTransform._Underlying *__btDefaultMotionState_Get_m_graphicsWorldTrans(_Underlying *_this);
                Bullet.Const_BtTransform __ret;
                __ret = new(__btDefaultMotionState_Get_m_graphicsWorldTrans(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe Bullet.Const_BtTransform mCenterOfMassOffset
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_Get_m_centerOfMassOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_Get_m_centerOfMassOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.Const_BtTransform._Underlying *__btDefaultMotionState_Get_m_centerOfMassOffset(_Underlying *_this);
                Bullet.Const_BtTransform __ret;
                __ret = new(__btDefaultMotionState_Get_m_centerOfMassOffset(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public unsafe Bullet.Const_BtTransform mStartWorldTrans
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_Get_m_startWorldTrans", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_Get_m_startWorldTrans", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.Const_BtTransform._Underlying *__btDefaultMotionState_Get_m_startWorldTrans(_Underlying *_this);
                Bullet.Const_BtTransform __ret;
                __ret = new(__btDefaultMotionState_Get_m_startWorldTrans(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe Const_BtDefaultMotionState(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        /// Parameter `startTrans` defaults to `btTransform::getIdentity()`.
        /// Parameter `centerOfMassOffset` defaults to `btTransform::getIdentity()`.
        public unsafe Const_BtDefaultMotionState(Bullet.Const_BtTransform? startTrans = null, Bullet.Const_BtTransform? centerOfMassOffset = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDefaultMotionState._Underlying *__btDefaultMotionState_Construct(Bullet.Const_BtTransform._Underlying *startTrans, Bullet.Const_BtTransform._Underlying *centerOfMassOffset);
            _UnderlyingPtr = __btDefaultMotionState_Construct(startTrans is not null ? startTrans._UnderlyingPtr : null, centerOfMassOffset is not null ? centerOfMassOffset._UnderlyingPtr : null);
        }

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        /// Parameter `startTrans` defaults to `btTransform::getIdentity()`.
        /// Parameter `centerOfMassOffset` defaults to `btTransform::getIdentity()`.
        public static unsafe implicit operator Const_BtDefaultMotionState(Bullet.Const_BtTransform? startTrans) {return new(startTrans);}

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        public unsafe Const_BtDefaultMotionState(Bullet._ByValue_BtDefaultMotionState _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDefaultMotionState._Underlying *__btDefaultMotionState_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtDefaultMotionState._Underlying *_other);
            _UnderlyingPtr = __btDefaultMotionState_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        public Const_BtDefaultMotionState(Const_BtDefaultMotionState _other) : this(new _ByValue_BtDefaultMotionState(_other)) {}

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        public Const_BtDefaultMotionState(BtDefaultMotionState _other) : this((Const_BtDefaultMotionState)_other) {}

        /// Generated from method `btDefaultMotionState::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btDefaultMotionState_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btDefaultMotionState_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btDefaultMotionState_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btDefaultMotionState_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btDefaultMotionState::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btDefaultMotionState_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btDefaultMotionState_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btDefaultMotionState_void_ptr(void *ptr);
            __Bullet_delete_btDefaultMotionState_void_ptr(ptr);
        }

        /// Generated from method `btDefaultMotionState::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btDefaultMotionState_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btDefaultMotionState_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btDefaultMotionState_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btDefaultMotionState_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btDefaultMotionState::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btDefaultMotionState_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btDefaultMotionState_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btDefaultMotionState_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btDefaultMotionState_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btDefaultMotionState::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btDefaultMotionState_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btDefaultMotionState_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btDefaultMotionState_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btDefaultMotionState_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btDefaultMotionState::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btDefaultMotionState_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btDefaultMotionState_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btDefaultMotionState_void_ptr(void *ptr);
            __Bullet_delete_array_btDefaultMotionState_void_ptr(ptr);
        }

        /// Generated from method `btDefaultMotionState::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btDefaultMotionState_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btDefaultMotionState_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btDefaultMotionState_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btDefaultMotionState_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btDefaultMotionState::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btDefaultMotionState_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btDefaultMotionState_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btDefaultMotionState_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btDefaultMotionState_void_ptr_void_ptr(_1, _2);
        }

        ///synchronizes world transform from user to physics
        /// Generated from method `btDefaultMotionState::getWorldTransform`.
        public unsafe void GetWorldTransform(Bullet.BtTransform centerOfMassWorldTrans)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_getWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_getWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDefaultMotionState_getWorldTransform(_Underlying *_this, Bullet.BtTransform._Underlying *centerOfMassWorldTrans);
            __btDefaultMotionState_getWorldTransform(_UnderlyingPtr, centerOfMassWorldTrans._UnderlyingPtr);
        }
    }

    ///The btDefaultMotionState provides a common implementation to synchronize world transforms with offsets.
    /// Generated from class `btDefaultMotionState`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btMotionState`
    /// This is the non-const half of the class.
    public class BtDefaultMotionState : Const_BtDefaultMotionState
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtMotionState(BtDefaultMotionState self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_UpcastTo_btMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_UpcastTo_btMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMotionState._Underlying *__btDefaultMotionState_UpcastTo_btMotionState(_Underlying *_this);
            Bullet.BtMotionState ret = new(__btDefaultMotionState_UpcastTo_btMotionState(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtDefaultMotionState?(Bullet.BtMotionState parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_DynamicDowncastFrom_btMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_DynamicDowncastFrom_btMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDefaultMotionState_DynamicDowncastFrom_btMotionState(Bullet.BtMotionState._Underlying *_this);
            var ptr = __btDefaultMotionState_DynamicDowncastFrom_btMotionState(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtDefaultMotionState ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        public new unsafe Bullet.BtTransform mGraphicsWorldTrans
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_GetMutable_m_graphicsWorldTrans", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_GetMutable_m_graphicsWorldTrans", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtTransform._Underlying *__btDefaultMotionState_GetMutable_m_graphicsWorldTrans(_Underlying *_this);
                Bullet.BtTransform __ret;
                __ret = new(__btDefaultMotionState_GetMutable_m_graphicsWorldTrans(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe Bullet.BtTransform mCenterOfMassOffset
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_GetMutable_m_centerOfMassOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_GetMutable_m_centerOfMassOffset", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtTransform._Underlying *__btDefaultMotionState_GetMutable_m_centerOfMassOffset(_Underlying *_this);
                Bullet.BtTransform __ret;
                __ret = new(__btDefaultMotionState_GetMutable_m_centerOfMassOffset(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        public new unsafe Bullet.BtTransform mStartWorldTrans
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_GetMutable_m_startWorldTrans", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_GetMutable_m_startWorldTrans", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtTransform._Underlying *__btDefaultMotionState_GetMutable_m_startWorldTrans(_Underlying *_this);
                Bullet.BtTransform __ret;
                __ret = new(__btDefaultMotionState_GetMutable_m_startWorldTrans(_UnderlyingPtr), is_owning: false);
                __ret._KeepAliveEnclosingObject = this;
                return __ret;
            }
        }

        internal unsafe BtDefaultMotionState(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        /// Parameter `startTrans` defaults to `btTransform::getIdentity()`.
        /// Parameter `centerOfMassOffset` defaults to `btTransform::getIdentity()`.
        public unsafe BtDefaultMotionState(Bullet.Const_BtTransform? startTrans = null, Bullet.Const_BtTransform? centerOfMassOffset = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDefaultMotionState._Underlying *__btDefaultMotionState_Construct(Bullet.Const_BtTransform._Underlying *startTrans, Bullet.Const_BtTransform._Underlying *centerOfMassOffset);
            _UnderlyingPtr = __btDefaultMotionState_Construct(startTrans is not null ? startTrans._UnderlyingPtr : null, centerOfMassOffset is not null ? centerOfMassOffset._UnderlyingPtr : null);
        }

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        /// Parameter `startTrans` defaults to `btTransform::getIdentity()`.
        /// Parameter `centerOfMassOffset` defaults to `btTransform::getIdentity()`.
        public static unsafe implicit operator BtDefaultMotionState(Bullet.Const_BtTransform? startTrans) {return new(startTrans);}

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        public unsafe BtDefaultMotionState(Bullet._ByValue_BtDefaultMotionState _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDefaultMotionState._Underlying *__btDefaultMotionState_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtDefaultMotionState._Underlying *_other);
            _UnderlyingPtr = __btDefaultMotionState_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        public BtDefaultMotionState(Const_BtDefaultMotionState _other) : this(new _ByValue_BtDefaultMotionState(_other)) {}

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        public BtDefaultMotionState(BtDefaultMotionState _other) : this((Const_BtDefaultMotionState)_other) {}

        /// Generated from method `btDefaultMotionState::operator=`.
        public unsafe Bullet.BtDefaultMotionState Assign(Bullet._ByValue_BtDefaultMotionState _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDefaultMotionState._Underlying *__btDefaultMotionState_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtDefaultMotionState._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btDefaultMotionState_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        ///synchronizes world transform from physics to user
        ///Bullet only calls the update of worldtransform for active objects
        /// Generated from method `btDefaultMotionState::setWorldTransform`.
        public unsafe void SetWorldTransform(Bullet.Const_BtTransform centerOfMassWorldTrans)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDefaultMotionState_setWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDefaultMotionState_setWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDefaultMotionState_setWorldTransform(_Underlying *_this, Bullet.Const_BtTransform._Underlying *centerOfMassWorldTrans);
            __btDefaultMotionState_setWorldTransform(_UnderlyingPtr, centerOfMassWorldTrans._UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtDefaultMotionState` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `BtDefaultMotionState`/`Const_BtDefaultMotionState` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtDefaultMotionState
    {
        #pragma warning disable CS0649
        internal readonly Const_BtDefaultMotionState? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtDefaultMotionState() {PassByMode = Bullet._PassBy.default_construct;}
        public _ByValue_BtDefaultMotionState(Const_BtDefaultMotionState new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtDefaultMotionState(Const_BtDefaultMotionState arg) {return new(arg);}
        public _ByValue_BtDefaultMotionState(Bullet._Moved<BtDefaultMotionState> moved) {Value = moved.Value; PassByMode = Bullet._PassBy.move;}
        public static implicit operator _ByValue_BtDefaultMotionState(Bullet._Moved<BtDefaultMotionState> arg) {return new(arg);}

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        /// Parameter `startTrans` defaults to `btTransform::getIdentity()`.
        /// Parameter `centerOfMassOffset` defaults to `btTransform::getIdentity()`.
        public static unsafe implicit operator _ByValue_BtDefaultMotionState(Bullet.Const_BtTransform? startTrans) {return new Bullet._Moved<Bullet.BtDefaultMotionState>(startTrans);}
    }

    /// This is used for optional parameters of class `BtDefaultMotionState` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtDefaultMotionState`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDefaultMotionState`/`Const_BtDefaultMotionState` directly.
    public class _InOptMut_BtDefaultMotionState
    {
        public BtDefaultMotionState? Opt;

        public _InOptMut_BtDefaultMotionState() {}
        public _InOptMut_BtDefaultMotionState(BtDefaultMotionState value) {Opt = value;}
        public static implicit operator _InOptMut_BtDefaultMotionState(BtDefaultMotionState value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtDefaultMotionState` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtDefaultMotionState`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDefaultMotionState`/`Const_BtDefaultMotionState` to pass it to the function.
    public class _InOptConst_BtDefaultMotionState
    {
        public Const_BtDefaultMotionState? Opt;

        public _InOptConst_BtDefaultMotionState() {}
        public _InOptConst_BtDefaultMotionState(Const_BtDefaultMotionState value) {Opt = value;}
        public static implicit operator _InOptConst_BtDefaultMotionState(Const_BtDefaultMotionState value) {return new(value);}

        /// Generated from constructor `btDefaultMotionState::btDefaultMotionState`.
        /// Parameter `startTrans` defaults to `btTransform::getIdentity()`.
        /// Parameter `centerOfMassOffset` defaults to `btTransform::getIdentity()`.
        public static unsafe implicit operator _InOptConst_BtDefaultMotionState(Bullet.Const_BtTransform? startTrans) {return new Const_BtDefaultMotionState(startTrans);}
    }
}
