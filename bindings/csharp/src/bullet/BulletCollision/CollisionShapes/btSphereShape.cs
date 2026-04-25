// machine generated, do not edit
public static partial class Bullet
{
    ///The btSphereShape implements an implicit sphere, centered around a local origin with radius.
    /// Generated from class `btSphereShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexInternalShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    /// This is the const half of the class.
    public class Const_BtSphereShape : Bullet.Object<Const_BtSphereShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_Destroy(_Underlying *_this);
            __btSphereShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtSphereShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionShape(Const_BtSphereShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionShape._Underlying *__btSphereShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.Const_BtCollisionShape ret = new(__btSphereShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexShape(Const_BtSphereShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexShape._Underlying *__btSphereShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.Const_BtConvexShape ret = new(__btSphereShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexInternalShape(Const_BtSphereShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexInternalShape._Underlying *__btSphereShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.Const_BtConvexInternalShape ret = new(__btSphereShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtSphereShape?(Bullet.Const_BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSphereShape_DynamicDowncastFrom_btCollisionShape(Bullet.Const_BtCollisionShape._Underlying *_this);
            var ptr = __btSphereShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtSphereShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtSphereShape?(Bullet.Const_BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSphereShape_DynamicDowncastFrom_btConvexShape(Bullet.Const_BtConvexShape._Underlying *_this);
            var ptr = __btSphereShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtSphereShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtSphereShape?(Bullet.Const_BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSphereShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.Const_BtConvexInternalShape._Underlying *_this);
            var ptr = __btSphereShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtSphereShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtSphereShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public unsafe Const_BtSphereShape(Bullet._ByValue_BtSphereShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSphereShape._Underlying *__btSphereShape_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtSphereShape._Underlying *_other);
            _UnderlyingPtr = __btSphereShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public Const_BtSphereShape(Const_BtSphereShape _other) : this(new _ByValue_BtSphereShape(_other)) {}

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public Const_BtSphereShape(BtSphereShape _other) : this((Const_BtSphereShape)_other) {}

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public unsafe Const_BtSphereShape(double radius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSphereShape._Underlying *__btSphereShape_Construct(double radius);
            _UnderlyingPtr = __btSphereShape_Construct(radius);
        }

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public static unsafe implicit operator Const_BtSphereShape(double radius) {return new(radius);}

        /// Generated from method `btSphereShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btSphereShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btSphereShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btSphereShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btSphereShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btSphereShape::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btSphereShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btSphereShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btSphereShape_void_ptr(void *ptr);
            __Bullet_delete_btSphereShape_void_ptr(ptr);
        }

        /// Generated from method `btSphereShape::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btSphereShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btSphereShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btSphereShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btSphereShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btSphereShape::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btSphereShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btSphereShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btSphereShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btSphereShape_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btSphereShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btSphereShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btSphereShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btSphereShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btSphereShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btSphereShape::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btSphereShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btSphereShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btSphereShape_void_ptr(void *ptr);
            __Bullet_delete_array_btSphereShape_void_ptr(ptr);
        }

        /// Generated from method `btSphereShape::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btSphereShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btSphereShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btSphereShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btSphereShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btSphereShape::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btSphereShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btSphereShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btSphereShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btSphereShape_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btSphereShape::localGetSupportingVertex`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertex(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btSphereShape_localGetSupportingVertex(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btSphereShape_localGetSupportingVertex(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btSphereShape::localGetSupportingVertexWithoutMargin`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btSphereShape_localGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btSphereShape_localGetSupportingVertexWithoutMargin(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        //notice that the vectors should be unit length
        /// Generated from method `btSphereShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
        public unsafe void BatchedUnitVectorGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3? vectors, Bullet.BtVector3? supportVerticesOut, int numVectors)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vectors, Bullet.BtVector3._Underlying *supportVerticesOut, int numVectors);
            __btSphereShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_UnderlyingPtr, vectors is not null ? vectors._UnderlyingPtr : null, supportVerticesOut is not null ? supportVerticesOut._UnderlyingPtr : null, numVectors);
        }

        /// Generated from method `btSphereShape::calculateLocalInertia`.
        public unsafe void CalculateLocalInertia(double mass, Bullet.BtVector3 inertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_calculateLocalInertia(_Underlying *_this, double mass, Bullet.BtVector3._Underlying *inertia);
            __btSphereShape_calculateLocalInertia(_UnderlyingPtr, mass, inertia._UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getAabb`.
        public unsafe void GetAabb(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_getAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btSphereShape_getAabb(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getRadius`.
        public unsafe double GetRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btSphereShape_getRadius(_Underlying *_this);
            return __btSphereShape_getRadius(_UnderlyingPtr);
        }

        //debugging
        /// Generated from method `btSphereShape::getName`.
        public unsafe byte? GetName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__btSphereShape_getName(_Underlying *_this);
            var __c_ret = __btSphereShape_getName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btSphereShape::getMargin`.
        public unsafe double GetMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btSphereShape_getMargin(_Underlying *_this);
            return __btSphereShape_getMargin(_UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getImplicitShapeDimensions`.
        public unsafe Bullet.Const_BtVector3 GetImplicitShapeDimensions()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btSphereShape_getImplicitShapeDimensions(_Underlying *_this);
            return new(__btSphereShape_getImplicitShapeDimensions(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btSphereShape::getAabbSlow`.
        public unsafe void GetAabbSlow(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_getAabbSlow(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btSphereShape_getAabbSlow(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getLocalScaling`.
        public unsafe Bullet.Const_BtVector3 GetLocalScaling()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btSphereShape_getLocalScaling(_Underlying *_this);
            return new(__btSphereShape_getLocalScaling(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btSphereShape::getLocalScalingNV`.
        public unsafe Bullet.Const_BtVector3 GetLocalScalingNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btSphereShape_getLocalScalingNV(_Underlying *_this);
            return new(__btSphereShape_getLocalScalingNV(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btSphereShape::getMarginNV`.
        public unsafe double GetMarginNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btSphereShape_getMarginNV(_Underlying *_this);
            return __btSphereShape_getMarginNV(_UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getNumPreferredPenetrationDirections`.
        public unsafe int GetNumPreferredPenetrationDirections()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btSphereShape_getNumPreferredPenetrationDirections(_Underlying *_this);
            return __btSphereShape_getNumPreferredPenetrationDirections(_UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getPreferredPenetrationDirection`.
        public unsafe void GetPreferredPenetrationDirection(int index, Bullet.BtVector3 penetrationVector)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_getPreferredPenetrationDirection(_Underlying *_this, int index, Bullet.BtVector3._Underlying *penetrationVector);
            __btSphereShape_getPreferredPenetrationDirection(_UnderlyingPtr, index, penetrationVector._UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btSphereShape_calculateSerializeBufferSize(_Underlying *_this);
            return __btSphereShape_calculateSerializeBufferSize(_UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::localGetSupportVertexWithoutMarginNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexWithoutMarginNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btSphereShape_localGetSupportVertexWithoutMarginNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btSphereShape_localGetSupportVertexWithoutMarginNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btSphereShape::localGetSupportVertexNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btSphereShape_localGetSupportVertexNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btSphereShape_localGetSupportVertexNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btSphereShape::getMarginNonVirtual`.
        public unsafe double GetMarginNonVirtual()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btSphereShape_getMarginNonVirtual(_Underlying *_this);
            return __btSphereShape_getMarginNonVirtual(_UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getAabbNonVirtual`.
        public unsafe void GetAabbNonVirtual(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_getAabbNonVirtual(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btSphereShape_getAabbNonVirtual(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::project`.
        public unsafe void Project(Bullet.Const_BtTransform trans, Bullet.Const_BtVector3 dir, ref double minProj, ref double maxProj, Bullet.BtVector3 witnesPtMin, Bullet.BtVector3 witnesPtMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_project(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans, Bullet.Const_BtVector3._Underlying *dir, double *minProj, double *maxProj, Bullet.BtVector3._Underlying *witnesPtMin, Bullet.BtVector3._Underlying *witnesPtMax);
            fixed (double *__ptr_minProj = &minProj)
            {
                fixed (double *__ptr_maxProj = &maxProj)
                {
                    __btSphereShape_project(_UnderlyingPtr, trans._UnderlyingPtr, dir._UnderlyingPtr, __ptr_minProj, __ptr_maxProj, witnesPtMin._UnderlyingPtr, witnesPtMax._UnderlyingPtr);
                }
            }
        }

        /// Generated from method `btSphereShape::getBoundingSphere`.
        public unsafe void GetBoundingSphere(Bullet.BtVector3 center, ref double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_getBoundingSphere(_Underlying *_this, Bullet.BtVector3._Underlying *center, double *radius);
            fixed (double *__ptr_radius = &radius)
            {
                __btSphereShape_getBoundingSphere(_UnderlyingPtr, center._UnderlyingPtr, __ptr_radius);
            }
        }

        ///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
        /// Generated from method `btSphereShape::getAngularMotionDisc`.
        public unsafe double GetAngularMotionDisc()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btSphereShape_getAngularMotionDisc(_Underlying *_this);
            return __btSphereShape_getAngularMotionDisc(_UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getContactBreakingThreshold`.
        public unsafe double GetContactBreakingThreshold(double defaultContactThresholdFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btSphereShape_getContactBreakingThreshold(_Underlying *_this, double defaultContactThresholdFactor);
            return __btSphereShape_getContactBreakingThreshold(_UnderlyingPtr, defaultContactThresholdFactor);
        }

        ///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
        ///result is conservative
        /// Generated from method `btSphereShape::calculateTemporalAabb`.
        public unsafe void CalculateTemporalAabb(Bullet.Const_BtTransform curTrans, Bullet.Const_BtVector3 linvel, Bullet.Const_BtVector3 angvel, double timeStep, Bullet.BtVector3 temporalAabbMin, Bullet.BtVector3 temporalAabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_calculateTemporalAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *curTrans, Bullet.Const_BtVector3._Underlying *linvel, Bullet.Const_BtVector3._Underlying *angvel, double timeStep, Bullet.BtVector3._Underlying *temporalAabbMin, Bullet.BtVector3._Underlying *temporalAabbMax);
            __btSphereShape_calculateTemporalAabb(_UnderlyingPtr, curTrans._UnderlyingPtr, linvel._UnderlyingPtr, angvel._UnderlyingPtr, timeStep, temporalAabbMin._UnderlyingPtr, temporalAabbMax._UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::isPolyhedral`.
        public unsafe bool IsPolyhedral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btSphereShape_isPolyhedral(_Underlying *_this);
            return __btSphereShape_isPolyhedral(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btSphereShape::isConvex2d`.
        public unsafe bool IsConvex2d()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btSphereShape_isConvex2d(_Underlying *_this);
            return __btSphereShape_isConvex2d(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btSphereShape::isConvex`.
        public unsafe bool IsConvex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btSphereShape_isConvex(_Underlying *_this);
            return __btSphereShape_isConvex(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btSphereShape::isNonMoving`.
        public unsafe bool IsNonMoving()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btSphereShape_isNonMoving(_Underlying *_this);
            return __btSphereShape_isNonMoving(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btSphereShape::isConcave`.
        public unsafe bool IsConcave()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btSphereShape_isConcave(_Underlying *_this);
            return __btSphereShape_isConcave(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btSphereShape::isCompound`.
        public unsafe bool IsCompound()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btSphereShape_isCompound(_Underlying *_this);
            return __btSphereShape_isCompound(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btSphereShape::isSoftBody`.
        public unsafe bool IsSoftBody()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btSphereShape_isSoftBody(_Underlying *_this);
            return __btSphereShape_isSoftBody(_UnderlyingPtr) != 0;
        }

        ///isInfinite is used to catch simulation error (aabb check)
        /// Generated from method `btSphereShape::isInfinite`.
        public unsafe bool IsInfinite()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btSphereShape_isInfinite(_Underlying *_this);
            return __btSphereShape_isInfinite(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btSphereShape::getShapeType`.
        public unsafe int GetShapeType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btSphereShape_getShapeType(_Underlying *_this);
            return __btSphereShape_getShapeType(_UnderlyingPtr);
        }

        ///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
        ///See Bullet/Demos/RollingFrictionDemo for an example
        /// Generated from method `btSphereShape::getAnisotropicRollingFrictionDirection`.
        public unsafe Bullet.BtVector3 GetAnisotropicRollingFrictionDirection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btSphereShape_getAnisotropicRollingFrictionDirection(_Underlying *_this);
            return new(__btSphereShape_getAnisotropicRollingFrictionDirection(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btSphereShape::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btSphereShape_getUserPointer(_Underlying *_this);
            return __btSphereShape_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btSphereShape_getUserIndex(_Underlying *_this);
            return __btSphereShape_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btSphereShape_getUserIndex2(_Underlying *_this);
            return __btSphereShape_getUserIndex2(_UnderlyingPtr);
        }
    }

    ///The btSphereShape implements an implicit sphere, centered around a local origin with radius.
    /// Generated from class `btSphereShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexInternalShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    /// This is the non-const half of the class.
    public class BtSphereShape : Const_BtSphereShape
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionShape(BtSphereShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionShape._Underlying *__btSphereShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.BtCollisionShape ret = new(__btSphereShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexShape(BtSphereShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexShape._Underlying *__btSphereShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.BtConvexShape ret = new(__btSphereShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexInternalShape(BtSphereShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexInternalShape._Underlying *__btSphereShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.BtConvexInternalShape ret = new(__btSphereShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtSphereShape?(Bullet.BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSphereShape_DynamicDowncastFrom_btCollisionShape(Bullet.BtCollisionShape._Underlying *_this);
            var ptr = __btSphereShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtSphereShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtSphereShape?(Bullet.BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSphereShape_DynamicDowncastFrom_btConvexShape(Bullet.BtConvexShape._Underlying *_this);
            var ptr = __btSphereShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtSphereShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtSphereShape?(Bullet.BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btSphereShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.BtConvexInternalShape._Underlying *_this);
            var ptr = __btSphereShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtSphereShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtSphereShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public unsafe BtSphereShape(Bullet._ByValue_BtSphereShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSphereShape._Underlying *__btSphereShape_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtSphereShape._Underlying *_other);
            _UnderlyingPtr = __btSphereShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public BtSphereShape(Const_BtSphereShape _other) : this(new _ByValue_BtSphereShape(_other)) {}

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public BtSphereShape(BtSphereShape _other) : this((Const_BtSphereShape)_other) {}

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public unsafe BtSphereShape(double radius) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSphereShape._Underlying *__btSphereShape_Construct(double radius);
            _UnderlyingPtr = __btSphereShape_Construct(radius);
        }

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public static unsafe implicit operator BtSphereShape(double radius) {return new(radius);}

        /// Generated from method `btSphereShape::operator=`.
        public unsafe Bullet.BtSphereShape Assign(Bullet._ByValue_BtSphereShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtSphereShape._Underlying *__btSphereShape_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtSphereShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btSphereShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btSphereShape::setUnscaledRadius`.
        public unsafe void SetUnscaledRadius(double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_setUnscaledRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_setUnscaledRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_setUnscaledRadius(_Underlying *_this, double radius);
            __btSphereShape_setUnscaledRadius(_UnderlyingPtr, radius);
        }

        /// Generated from method `btSphereShape::setMargin`.
        public unsafe void SetMargin(double margin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_setMargin(_Underlying *_this, double margin);
            __btSphereShape_setMargin(_UnderlyingPtr, margin);
        }

        ///warning: use setImplicitShapeDimensions with care
        ///changing a collision shape while the body is in the world is not recommended,
        ///it is best to remove the body from the world, then make the change, and re-add it
        ///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
        /// Generated from method `btSphereShape::setImplicitShapeDimensions`.
        public unsafe void SetImplicitShapeDimensions(Bullet.Const_BtVector3 dimensions)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_setImplicitShapeDimensions(_Underlying *_this, Bullet.Const_BtVector3._Underlying *dimensions);
            __btSphereShape_setImplicitShapeDimensions(_UnderlyingPtr, dimensions._UnderlyingPtr);
        }

        /// Generated from method `btSphereShape::setLocalScaling`.
        public unsafe void SetLocalScaling(Bullet.Const_BtVector3 scaling)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_setLocalScaling(_Underlying *_this, Bullet.Const_BtVector3._Underlying *scaling);
            __btSphereShape_setLocalScaling(_UnderlyingPtr, scaling._UnderlyingPtr);
        }

        ///optional user data pointer
        /// Generated from method `btSphereShape::setUserPointer`.
        /// Parameter `userPtr` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPtr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_setUserPointer(_Underlying *_this, void *userPtr);
            __btSphereShape_setUserPointer(_UnderlyingPtr, userPtr);
        }

        /// Generated from method `btSphereShape::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_setUserIndex(_Underlying *_this, int index);
            __btSphereShape_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btSphereShape::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btSphereShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btSphereShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btSphereShape_setUserIndex2(_Underlying *_this, int index);
            __btSphereShape_setUserIndex2(_UnderlyingPtr, index);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtSphereShape` by value.
    /// Usage:
    /// * Pass an instance of `BtSphereShape`/`Const_BtSphereShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtSphereShape
    {
        #pragma warning disable CS0649
        internal readonly Const_BtSphereShape? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtSphereShape(Const_BtSphereShape new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtSphereShape(Const_BtSphereShape arg) {return new(arg);}
        public _ByValue_BtSphereShape(Bullet._Moved<BtSphereShape> moved) {Value = moved.Value; PassByMode = Bullet._PassBy.move;}
        public static implicit operator _ByValue_BtSphereShape(Bullet._Moved<BtSphereShape> arg) {return new(arg);}

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public static unsafe implicit operator _ByValue_BtSphereShape(double radius) {return new Bullet._Moved<Bullet.BtSphereShape>(radius);}
    }

    /// This is used for optional parameters of class `BtSphereShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtSphereShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtSphereShape`/`Const_BtSphereShape` directly.
    public class _InOptMut_BtSphereShape
    {
        public BtSphereShape? Opt;

        public _InOptMut_BtSphereShape() {}
        public _InOptMut_BtSphereShape(BtSphereShape value) {Opt = value;}
        public static implicit operator _InOptMut_BtSphereShape(BtSphereShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtSphereShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtSphereShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtSphereShape`/`Const_BtSphereShape` to pass it to the function.
    public class _InOptConst_BtSphereShape
    {
        public Const_BtSphereShape? Opt;

        public _InOptConst_BtSphereShape() {}
        public _InOptConst_BtSphereShape(Const_BtSphereShape value) {Opt = value;}
        public static implicit operator _InOptConst_BtSphereShape(Const_BtSphereShape value) {return new(value);}

        /// Generated from constructor `btSphereShape::btSphereShape`.
        public static unsafe implicit operator _InOptConst_BtSphereShape(double radius) {return new Const_BtSphereShape(radius);}
    }
}
