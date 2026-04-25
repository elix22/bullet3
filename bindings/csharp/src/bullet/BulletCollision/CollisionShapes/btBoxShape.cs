// machine generated, do not edit
public static partial class Bullet
{
    ///The btBoxShape is a box primitive around the origin, its sides axis aligned with length specified by half extents, in local shape coordinates. When used as part of a btCollisionObject or btRigidBody it will be an oriented box in world space.
    /// Generated from class `btBoxShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btPolyhedralConvexShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    ///     `btConvexInternalShape`
    /// This is the const half of the class.
    public class Const_BtBoxShape : Bullet.Object<Const_BtBoxShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_Destroy(_Underlying *_this);
            __btBoxShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtBoxShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionShape(Const_BtBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionShape._Underlying *__btBoxShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.Const_BtCollisionShape ret = new(__btBoxShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexShape(Const_BtBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexShape._Underlying *__btBoxShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.Const_BtConvexShape ret = new(__btBoxShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexInternalShape(Const_BtBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexInternalShape._Underlying *__btBoxShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.Const_BtConvexInternalShape ret = new(__btBoxShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtPolyhedralConvexShape(Const_BtBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_UpcastTo_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_UpcastTo_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtPolyhedralConvexShape._Underlying *__btBoxShape_UpcastTo_btPolyhedralConvexShape(_Underlying *_this);
            Bullet.Const_BtPolyhedralConvexShape ret = new(__btBoxShape_UpcastTo_btPolyhedralConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtBoxShape?(Bullet.Const_BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btBoxShape_DynamicDowncastFrom_btCollisionShape(Bullet.Const_BtCollisionShape._Underlying *_this);
            var ptr = __btBoxShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtBoxShape?(Bullet.Const_BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btBoxShape_DynamicDowncastFrom_btConvexShape(Bullet.Const_BtConvexShape._Underlying *_this);
            var ptr = __btBoxShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtBoxShape?(Bullet.Const_BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btBoxShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.Const_BtConvexInternalShape._Underlying *_this);
            var ptr = __btBoxShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtBoxShape?(Bullet.Const_BtPolyhedralConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape(Bullet.Const_BtPolyhedralConvexShape._Underlying *_this);
            var ptr = __btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtBoxShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public unsafe Const_BtBoxShape(Bullet._ByValue_BtBoxShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtBoxShape._Underlying *__btBoxShape_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtBoxShape._Underlying *_other);
            _UnderlyingPtr = __btBoxShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public Const_BtBoxShape(Const_BtBoxShape _other) : this(new _ByValue_BtBoxShape(_other)) {}

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public Const_BtBoxShape(BtBoxShape _other) : this((Const_BtBoxShape)_other) {}

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public unsafe Const_BtBoxShape(Bullet.Const_BtVector3 boxHalfExtents) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtBoxShape._Underlying *__btBoxShape_Construct(Bullet.Const_BtVector3._Underlying *boxHalfExtents);
            _UnderlyingPtr = __btBoxShape_Construct(boxHalfExtents._UnderlyingPtr);
        }

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public static unsafe implicit operator Const_BtBoxShape(Bullet.Const_BtVector3 boxHalfExtents) {return new(boxHalfExtents);}

        //btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
        /// Generated from method `btBoxShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btBoxShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btBoxShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btBoxShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btBoxShape_unsigned_long(sizeInBytes);
        }

        //btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
        /// Generated from method `btBoxShape::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btBoxShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btBoxShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btBoxShape_void_ptr(void *ptr);
            __Bullet_delete_btBoxShape_void_ptr(ptr);
        }

        //btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
        /// Generated from method `btBoxShape::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btBoxShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btBoxShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btBoxShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btBoxShape_unsigned_long_void_ptr(_1, ptr);
        }

        //btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
        /// Generated from method `btBoxShape::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btBoxShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btBoxShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btBoxShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btBoxShape_void_ptr_void_ptr(_1, _2);
        }

        //btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
        /// Generated from method `btBoxShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btBoxShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btBoxShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btBoxShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btBoxShape_unsigned_long(sizeInBytes);
        }

        //btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
        /// Generated from method `btBoxShape::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btBoxShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btBoxShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btBoxShape_void_ptr(void *ptr);
            __Bullet_delete_array_btBoxShape_void_ptr(ptr);
        }

        //btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
        /// Generated from method `btBoxShape::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btBoxShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btBoxShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btBoxShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btBoxShape_unsigned_long_void_ptr(_1, ptr);
        }

        //btVector3	m_boxHalfExtents1; //use m_implicitShapeDimensions instead
        /// Generated from method `btBoxShape::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btBoxShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btBoxShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btBoxShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btBoxShape_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btBoxShape::getHalfExtentsWithMargin`.
        public unsafe Bullet.BtVector3 GetHalfExtentsWithMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getHalfExtentsWithMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getHalfExtentsWithMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btBoxShape_getHalfExtentsWithMargin(_Underlying *_this);
            return new(__btBoxShape_getHalfExtentsWithMargin(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btBoxShape::getHalfExtentsWithoutMargin`.
        public unsafe Bullet.Const_BtVector3 GetHalfExtentsWithoutMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getHalfExtentsWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getHalfExtentsWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btBoxShape_getHalfExtentsWithoutMargin(_Underlying *_this);
            return new(__btBoxShape_getHalfExtentsWithoutMargin(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btBoxShape::localGetSupportingVertex`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertex(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btBoxShape_localGetSupportingVertex(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btBoxShape_localGetSupportingVertex(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btBoxShape::localGetSupportingVertexWithoutMargin`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btBoxShape_localGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btBoxShape_localGetSupportingVertexWithoutMargin(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btBoxShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
        public unsafe void BatchedUnitVectorGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3? vectors, Bullet.BtVector3? supportVerticesOut, int numVectors)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vectors, Bullet.BtVector3._Underlying *supportVerticesOut, int numVectors);
            __btBoxShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_UnderlyingPtr, vectors is not null ? vectors._UnderlyingPtr : null, supportVerticesOut is not null ? supportVerticesOut._UnderlyingPtr : null, numVectors);
        }

        /// Generated from method `btBoxShape::getAabb`.
        public unsafe void GetAabb(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_getAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btBoxShape_getAabb(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::calculateLocalInertia`.
        public unsafe void CalculateLocalInertia(double mass, Bullet.BtVector3 inertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_calculateLocalInertia(_Underlying *_this, double mass, Bullet.BtVector3._Underlying *inertia);
            __btBoxShape_calculateLocalInertia(_UnderlyingPtr, mass, inertia._UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getPlane`.
        public unsafe void GetPlane(Bullet.BtVector3 planeNormal, Bullet.BtVector3 planeSupport, int i)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_getPlane(_Underlying *_this, Bullet.BtVector3._Underlying *planeNormal, Bullet.BtVector3._Underlying *planeSupport, int i);
            __btBoxShape_getPlane(_UnderlyingPtr, planeNormal._UnderlyingPtr, planeSupport._UnderlyingPtr, i);
        }

        /// Generated from method `btBoxShape::getNumPlanes`.
        public unsafe int GetNumPlanes()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getNumPlanes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getNumPlanes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btBoxShape_getNumPlanes(_Underlying *_this);
            return __btBoxShape_getNumPlanes(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getNumVertices`.
        public unsafe int GetNumVertices()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getNumVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getNumVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btBoxShape_getNumVertices(_Underlying *_this);
            return __btBoxShape_getNumVertices(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getNumEdges`.
        public unsafe int GetNumEdges()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getNumEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getNumEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btBoxShape_getNumEdges(_Underlying *_this);
            return __btBoxShape_getNumEdges(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getVertex`.
        public unsafe void GetVertex(int i, Bullet.BtVector3 vtx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_getVertex(_Underlying *_this, int i, Bullet.BtVector3._Underlying *vtx);
            __btBoxShape_getVertex(_UnderlyingPtr, i, vtx._UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getEdge`.
        public unsafe void GetEdge(int i, Bullet.BtVector3 pa, Bullet.BtVector3 pb)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getEdge", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getEdge", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_getEdge(_Underlying *_this, int i, Bullet.BtVector3._Underlying *pa, Bullet.BtVector3._Underlying *pb);
            __btBoxShape_getEdge(_UnderlyingPtr, i, pa._UnderlyingPtr, pb._UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::isInside`.
        public unsafe bool IsInside(Bullet.Const_BtVector3 pt, double tolerance)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_isInside", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_isInside", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_isInside(_Underlying *_this, Bullet.Const_BtVector3._Underlying *pt, double tolerance);
            return __btBoxShape_isInside(_UnderlyingPtr, pt._UnderlyingPtr, tolerance) != 0;
        }

        //debugging
        /// Generated from method `btBoxShape::getName`.
        public unsafe byte? GetName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__btBoxShape_getName(_Underlying *_this);
            var __c_ret = __btBoxShape_getName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btBoxShape::getNumPreferredPenetrationDirections`.
        public unsafe int GetNumPreferredPenetrationDirections()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btBoxShape_getNumPreferredPenetrationDirections(_Underlying *_this);
            return __btBoxShape_getNumPreferredPenetrationDirections(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getPreferredPenetrationDirection`.
        public unsafe void GetPreferredPenetrationDirection(int index, Bullet.BtVector3 penetrationVector)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_getPreferredPenetrationDirection(_Underlying *_this, int index, Bullet.BtVector3._Underlying *penetrationVector);
            __btBoxShape_getPreferredPenetrationDirection(_UnderlyingPtr, index, penetrationVector._UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getImplicitShapeDimensions`.
        public unsafe Bullet.Const_BtVector3 GetImplicitShapeDimensions()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btBoxShape_getImplicitShapeDimensions(_Underlying *_this);
            return new(__btBoxShape_getImplicitShapeDimensions(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btBoxShape::getAabbSlow`.
        public unsafe void GetAabbSlow(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_getAabbSlow(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btBoxShape_getAabbSlow(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getLocalScaling`.
        public unsafe Bullet.Const_BtVector3 GetLocalScaling()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btBoxShape_getLocalScaling(_Underlying *_this);
            return new(__btBoxShape_getLocalScaling(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btBoxShape::getLocalScalingNV`.
        public unsafe Bullet.Const_BtVector3 GetLocalScalingNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btBoxShape_getLocalScalingNV(_Underlying *_this);
            return new(__btBoxShape_getLocalScalingNV(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btBoxShape::getMargin`.
        public unsafe double GetMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btBoxShape_getMargin(_Underlying *_this);
            return __btBoxShape_getMargin(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getMarginNV`.
        public unsafe double GetMarginNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btBoxShape_getMarginNV(_Underlying *_this);
            return __btBoxShape_getMarginNV(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btBoxShape_calculateSerializeBufferSize(_Underlying *_this);
            return __btBoxShape_calculateSerializeBufferSize(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::localGetSupportVertexWithoutMarginNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexWithoutMarginNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btBoxShape_localGetSupportVertexWithoutMarginNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btBoxShape_localGetSupportVertexWithoutMarginNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btBoxShape::localGetSupportVertexNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btBoxShape_localGetSupportVertexNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btBoxShape_localGetSupportVertexNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btBoxShape::getMarginNonVirtual`.
        public unsafe double GetMarginNonVirtual()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btBoxShape_getMarginNonVirtual(_Underlying *_this);
            return __btBoxShape_getMarginNonVirtual(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getAabbNonVirtual`.
        public unsafe void GetAabbNonVirtual(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_getAabbNonVirtual(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btBoxShape_getAabbNonVirtual(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::project`.
        public unsafe void Project(Bullet.Const_BtTransform trans, Bullet.Const_BtVector3 dir, ref double minProj, ref double maxProj, Bullet.BtVector3 witnesPtMin, Bullet.BtVector3 witnesPtMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_project(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans, Bullet.Const_BtVector3._Underlying *dir, double *minProj, double *maxProj, Bullet.BtVector3._Underlying *witnesPtMin, Bullet.BtVector3._Underlying *witnesPtMax);
            fixed (double *__ptr_minProj = &minProj)
            {
                fixed (double *__ptr_maxProj = &maxProj)
                {
                    __btBoxShape_project(_UnderlyingPtr, trans._UnderlyingPtr, dir._UnderlyingPtr, __ptr_minProj, __ptr_maxProj, witnesPtMin._UnderlyingPtr, witnesPtMax._UnderlyingPtr);
                }
            }
        }

        /// Generated from method `btBoxShape::getBoundingSphere`.
        public unsafe void GetBoundingSphere(Bullet.BtVector3 center, ref double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_getBoundingSphere(_Underlying *_this, Bullet.BtVector3._Underlying *center, double *radius);
            fixed (double *__ptr_radius = &radius)
            {
                __btBoxShape_getBoundingSphere(_UnderlyingPtr, center._UnderlyingPtr, __ptr_radius);
            }
        }

        ///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
        /// Generated from method `btBoxShape::getAngularMotionDisc`.
        public unsafe double GetAngularMotionDisc()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btBoxShape_getAngularMotionDisc(_Underlying *_this);
            return __btBoxShape_getAngularMotionDisc(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getContactBreakingThreshold`.
        public unsafe double GetContactBreakingThreshold(double defaultContactThresholdFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btBoxShape_getContactBreakingThreshold(_Underlying *_this, double defaultContactThresholdFactor);
            return __btBoxShape_getContactBreakingThreshold(_UnderlyingPtr, defaultContactThresholdFactor);
        }

        ///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
        ///result is conservative
        /// Generated from method `btBoxShape::calculateTemporalAabb`.
        public unsafe void CalculateTemporalAabb(Bullet.Const_BtTransform curTrans, Bullet.Const_BtVector3 linvel, Bullet.Const_BtVector3 angvel, double timeStep, Bullet.BtVector3 temporalAabbMin, Bullet.BtVector3 temporalAabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_calculateTemporalAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *curTrans, Bullet.Const_BtVector3._Underlying *linvel, Bullet.Const_BtVector3._Underlying *angvel, double timeStep, Bullet.BtVector3._Underlying *temporalAabbMin, Bullet.BtVector3._Underlying *temporalAabbMax);
            __btBoxShape_calculateTemporalAabb(_UnderlyingPtr, curTrans._UnderlyingPtr, linvel._UnderlyingPtr, angvel._UnderlyingPtr, timeStep, temporalAabbMin._UnderlyingPtr, temporalAabbMax._UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::isPolyhedral`.
        public unsafe bool IsPolyhedral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_isPolyhedral(_Underlying *_this);
            return __btBoxShape_isPolyhedral(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btBoxShape::isConvex2d`.
        public unsafe bool IsConvex2d()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_isConvex2d(_Underlying *_this);
            return __btBoxShape_isConvex2d(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btBoxShape::isConvex`.
        public unsafe bool IsConvex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_isConvex(_Underlying *_this);
            return __btBoxShape_isConvex(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btBoxShape::isNonMoving`.
        public unsafe bool IsNonMoving()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_isNonMoving(_Underlying *_this);
            return __btBoxShape_isNonMoving(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btBoxShape::isConcave`.
        public unsafe bool IsConcave()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_isConcave(_Underlying *_this);
            return __btBoxShape_isConcave(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btBoxShape::isCompound`.
        public unsafe bool IsCompound()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_isCompound(_Underlying *_this);
            return __btBoxShape_isCompound(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btBoxShape::isSoftBody`.
        public unsafe bool IsSoftBody()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_isSoftBody(_Underlying *_this);
            return __btBoxShape_isSoftBody(_UnderlyingPtr) != 0;
        }

        ///isInfinite is used to catch simulation error (aabb check)
        /// Generated from method `btBoxShape::isInfinite`.
        public unsafe bool IsInfinite()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_isInfinite(_Underlying *_this);
            return __btBoxShape_isInfinite(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btBoxShape::getShapeType`.
        public unsafe int GetShapeType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btBoxShape_getShapeType(_Underlying *_this);
            return __btBoxShape_getShapeType(_UnderlyingPtr);
        }

        ///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
        ///See Bullet/Demos/RollingFrictionDemo for an example
        /// Generated from method `btBoxShape::getAnisotropicRollingFrictionDirection`.
        public unsafe Bullet.BtVector3 GetAnisotropicRollingFrictionDirection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btBoxShape_getAnisotropicRollingFrictionDirection(_Underlying *_this);
            return new(__btBoxShape_getAnisotropicRollingFrictionDirection(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btBoxShape::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btBoxShape_getUserPointer(_Underlying *_this);
            return __btBoxShape_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btBoxShape_getUserIndex(_Underlying *_this);
            return __btBoxShape_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btBoxShape::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btBoxShape_getUserIndex2(_Underlying *_this);
            return __btBoxShape_getUserIndex2(_UnderlyingPtr);
        }
    }

    ///The btBoxShape is a box primitive around the origin, its sides axis aligned with length specified by half extents, in local shape coordinates. When used as part of a btCollisionObject or btRigidBody it will be an oriented box in world space.
    /// Generated from class `btBoxShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btPolyhedralConvexShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    ///     `btConvexInternalShape`
    /// This is the non-const half of the class.
    public class BtBoxShape : Const_BtBoxShape
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionShape(BtBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionShape._Underlying *__btBoxShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.BtCollisionShape ret = new(__btBoxShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexShape(BtBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexShape._Underlying *__btBoxShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.BtConvexShape ret = new(__btBoxShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexInternalShape(BtBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexInternalShape._Underlying *__btBoxShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.BtConvexInternalShape ret = new(__btBoxShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtPolyhedralConvexShape(BtBoxShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_UpcastTo_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_UpcastTo_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtPolyhedralConvexShape._Underlying *__btBoxShape_UpcastTo_btPolyhedralConvexShape(_Underlying *_this);
            Bullet.BtPolyhedralConvexShape ret = new(__btBoxShape_UpcastTo_btPolyhedralConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtBoxShape?(Bullet.BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btBoxShape_DynamicDowncastFrom_btCollisionShape(Bullet.BtCollisionShape._Underlying *_this);
            var ptr = __btBoxShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtBoxShape?(Bullet.BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btBoxShape_DynamicDowncastFrom_btConvexShape(Bullet.BtConvexShape._Underlying *_this);
            var ptr = __btBoxShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtBoxShape?(Bullet.BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btBoxShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.BtConvexInternalShape._Underlying *_this);
            var ptr = __btBoxShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtBoxShape?(Bullet.BtPolyhedralConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape(Bullet.BtPolyhedralConvexShape._Underlying *_this);
            var ptr = __btBoxShape_DynamicDowncastFrom_btPolyhedralConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtBoxShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtBoxShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public unsafe BtBoxShape(Bullet._ByValue_BtBoxShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtBoxShape._Underlying *__btBoxShape_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtBoxShape._Underlying *_other);
            _UnderlyingPtr = __btBoxShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public BtBoxShape(Const_BtBoxShape _other) : this(new _ByValue_BtBoxShape(_other)) {}

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public BtBoxShape(BtBoxShape _other) : this((Const_BtBoxShape)_other) {}

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public unsafe BtBoxShape(Bullet.Const_BtVector3 boxHalfExtents) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtBoxShape._Underlying *__btBoxShape_Construct(Bullet.Const_BtVector3._Underlying *boxHalfExtents);
            _UnderlyingPtr = __btBoxShape_Construct(boxHalfExtents._UnderlyingPtr);
        }

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public static unsafe implicit operator BtBoxShape(Bullet.Const_BtVector3 boxHalfExtents) {return new(boxHalfExtents);}

        /// Generated from method `btBoxShape::operator=`.
        public unsafe Bullet.BtBoxShape Assign(Bullet._ByValue_BtBoxShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtBoxShape._Underlying *__btBoxShape_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtBoxShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btBoxShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btBoxShape::setMargin`.
        public unsafe void SetMargin(double collisionMargin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_setMargin(_Underlying *_this, double collisionMargin);
            __btBoxShape_setMargin(_UnderlyingPtr, collisionMargin);
        }

        /// Generated from method `btBoxShape::setLocalScaling`.
        public unsafe void SetLocalScaling(Bullet.Const_BtVector3 scaling)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_setLocalScaling(_Underlying *_this, Bullet.Const_BtVector3._Underlying *scaling);
            __btBoxShape_setLocalScaling(_UnderlyingPtr, scaling._UnderlyingPtr);
        }

        ///optional method mainly used to generate multiple contact points by clipping polyhedral features (faces/edges)
        ///experimental/work-in-progress
        /// Generated from method `btBoxShape::initializePolyhedralFeatures`.
        /// Parameter `shiftVerticesByMargin` defaults to `0`.
        public unsafe bool InitializePolyhedralFeatures(int? shiftVerticesByMargin = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_initializePolyhedralFeatures", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_initializePolyhedralFeatures", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btBoxShape_initializePolyhedralFeatures(_Underlying *_this, int *shiftVerticesByMargin);
            int __deref_shiftVerticesByMargin = shiftVerticesByMargin.GetValueOrDefault();
            return __btBoxShape_initializePolyhedralFeatures(_UnderlyingPtr, shiftVerticesByMargin.HasValue ? &__deref_shiftVerticesByMargin : null) != 0;
        }

        ///warning: use setImplicitShapeDimensions with care
        ///changing a collision shape while the body is in the world is not recommended,
        ///it is best to remove the body from the world, then make the change, and re-add it
        ///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
        /// Generated from method `btBoxShape::setImplicitShapeDimensions`.
        public unsafe void SetImplicitShapeDimensions(Bullet.Const_BtVector3 dimensions)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_setImplicitShapeDimensions(_Underlying *_this, Bullet.Const_BtVector3._Underlying *dimensions);
            __btBoxShape_setImplicitShapeDimensions(_UnderlyingPtr, dimensions._UnderlyingPtr);
        }

        ///optional user data pointer
        /// Generated from method `btBoxShape::setUserPointer`.
        /// Parameter `userPtr` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPtr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_setUserPointer(_Underlying *_this, void *userPtr);
            __btBoxShape_setUserPointer(_UnderlyingPtr, userPtr);
        }

        /// Generated from method `btBoxShape::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_setUserIndex(_Underlying *_this, int index);
            __btBoxShape_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btBoxShape::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btBoxShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btBoxShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btBoxShape_setUserIndex2(_Underlying *_this, int index);
            __btBoxShape_setUserIndex2(_UnderlyingPtr, index);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtBoxShape` by value.
    /// Usage:
    /// * Pass an instance of `BtBoxShape`/`Const_BtBoxShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtBoxShape
    {
        #pragma warning disable CS0649
        internal readonly Const_BtBoxShape? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtBoxShape(Const_BtBoxShape new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtBoxShape(Const_BtBoxShape arg) {return new(arg);}
        public _ByValue_BtBoxShape(Bullet._Moved<BtBoxShape> moved) {Value = moved.Value; PassByMode = Bullet._PassBy.move;}
        public static implicit operator _ByValue_BtBoxShape(Bullet._Moved<BtBoxShape> arg) {return new(arg);}

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public static unsafe implicit operator _ByValue_BtBoxShape(Bullet.Const_BtVector3 boxHalfExtents) {return new Bullet._Moved<Bullet.BtBoxShape>(boxHalfExtents);}
    }

    /// This is used for optional parameters of class `BtBoxShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtBoxShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtBoxShape`/`Const_BtBoxShape` directly.
    public class _InOptMut_BtBoxShape
    {
        public BtBoxShape? Opt;

        public _InOptMut_BtBoxShape() {}
        public _InOptMut_BtBoxShape(BtBoxShape value) {Opt = value;}
        public static implicit operator _InOptMut_BtBoxShape(BtBoxShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtBoxShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtBoxShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtBoxShape`/`Const_BtBoxShape` to pass it to the function.
    public class _InOptConst_BtBoxShape
    {
        public Const_BtBoxShape? Opt;

        public _InOptConst_BtBoxShape() {}
        public _InOptConst_BtBoxShape(Const_BtBoxShape value) {Opt = value;}
        public static implicit operator _InOptConst_BtBoxShape(Const_BtBoxShape value) {return new(value);}

        /// Generated from constructor `btBoxShape::btBoxShape`.
        public static unsafe implicit operator _InOptConst_BtBoxShape(Bullet.Const_BtVector3 boxHalfExtents) {return new Const_BtBoxShape(boxHalfExtents);}
    }
}
