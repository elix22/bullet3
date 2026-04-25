// machine generated, do not edit
public static partial class Bullet
{
    ///The btCapsuleShape represents a capsule around the Y axis, there is also the btCapsuleShapeX aligned around the X axis and btCapsuleShapeZ around the Z axis.
    ///The total height is height+2*radius, so the height is just the height between the center of each 'sphere' of the capsule caps.
    ///The btCapsuleShape is a convex hull of two spheres. The btMultiSphereShape is a more general collision shape that takes the convex hull of multiple sphere, so it can also represent a capsule when just using two spheres.
    /// Generated from class `btCapsuleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexInternalShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    /// This is the const half of the class.
    public class Const_BtCapsuleShape : Bullet.Object<Const_BtCapsuleShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_Destroy(_Underlying *_this);
            __btCapsuleShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtCapsuleShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionShape(Const_BtCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionShape._Underlying *__btCapsuleShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.Const_BtCollisionShape ret = new(__btCapsuleShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexShape(Const_BtCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexShape._Underlying *__btCapsuleShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.Const_BtConvexShape ret = new(__btCapsuleShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexInternalShape(Const_BtCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexInternalShape._Underlying *__btCapsuleShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.Const_BtConvexInternalShape ret = new(__btCapsuleShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtCapsuleShape?(Bullet.Const_BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCapsuleShape_DynamicDowncastFrom_btCollisionShape(Bullet.Const_BtCollisionShape._Underlying *_this);
            var ptr = __btCapsuleShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtCapsuleShape?(Bullet.Const_BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCapsuleShape_DynamicDowncastFrom_btConvexShape(Bullet.Const_BtConvexShape._Underlying *_this);
            var ptr = __btCapsuleShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtCapsuleShape?(Bullet.Const_BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.Const_BtConvexInternalShape._Underlying *_this);
            var ptr = __btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtCapsuleShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btCapsuleShape::btCapsuleShape`.
        public unsafe Const_BtCapsuleShape(Bullet._ByValue_BtCapsuleShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCapsuleShape._Underlying *__btCapsuleShape_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCapsuleShape._Underlying *_other);
            _UnderlyingPtr = __btCapsuleShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCapsuleShape::btCapsuleShape`.
        public Const_BtCapsuleShape(Const_BtCapsuleShape _other) : this(new _ByValue_BtCapsuleShape(_other)) {}

        /// Generated from constructor `btCapsuleShape::btCapsuleShape`.
        public Const_BtCapsuleShape(BtCapsuleShape _other) : this((Const_BtCapsuleShape)_other) {}

        /// Generated from constructor `btCapsuleShape::btCapsuleShape`.
        public unsafe Const_BtCapsuleShape(double radius, double height) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCapsuleShape._Underlying *__btCapsuleShape_Construct(double radius, double height);
            _UnderlyingPtr = __btCapsuleShape_Construct(radius, height);
        }

        /// Generated from method `btCapsuleShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btCapsuleShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btCapsuleShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btCapsuleShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btCapsuleShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btCapsuleShape::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btCapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btCapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btCapsuleShape_void_ptr(void *ptr);
            __Bullet_delete_btCapsuleShape_void_ptr(ptr);
        }

        /// Generated from method `btCapsuleShape::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btCapsuleShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btCapsuleShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btCapsuleShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btCapsuleShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btCapsuleShape::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btCapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btCapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btCapsuleShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btCapsuleShape_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btCapsuleShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btCapsuleShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btCapsuleShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btCapsuleShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btCapsuleShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btCapsuleShape::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btCapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btCapsuleShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btCapsuleShape_void_ptr(void *ptr);
            __Bullet_delete_array_btCapsuleShape_void_ptr(ptr);
        }

        /// Generated from method `btCapsuleShape::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btCapsuleShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btCapsuleShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btCapsuleShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btCapsuleShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btCapsuleShape::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btCapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btCapsuleShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btCapsuleShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btCapsuleShape_void_ptr_void_ptr(_1, _2);
        }

        ///CollisionShape Interface
        /// Generated from method `btCapsuleShape::calculateLocalInertia`.
        public unsafe void CalculateLocalInertia(double mass, Bullet.BtVector3 inertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_calculateLocalInertia(_Underlying *_this, double mass, Bullet.BtVector3._Underlying *inertia);
            __btCapsuleShape_calculateLocalInertia(_UnderlyingPtr, mass, inertia._UnderlyingPtr);
        }

        /// btConvexShape Interface
        /// Generated from method `btCapsuleShape::localGetSupportingVertexWithoutMargin`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btCapsuleShape_localGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btCapsuleShape_localGetSupportingVertexWithoutMargin(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btCapsuleShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
        public unsafe void BatchedUnitVectorGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3? vectors, Bullet.BtVector3? supportVerticesOut, int numVectors)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vectors, Bullet.BtVector3._Underlying *supportVerticesOut, int numVectors);
            __btCapsuleShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_UnderlyingPtr, vectors is not null ? vectors._UnderlyingPtr : null, supportVerticesOut is not null ? supportVerticesOut._UnderlyingPtr : null, numVectors);
        }

        /// Generated from method `btCapsuleShape::getAabb`.
        public unsafe void GetAabb(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_getAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btCapsuleShape_getAabb(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getName`.
        public unsafe byte? GetName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__btCapsuleShape_getName(_Underlying *_this);
            var __c_ret = __btCapsuleShape_getName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btCapsuleShape::getUpAxis`.
        public unsafe int GetUpAxis()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getUpAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getUpAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCapsuleShape_getUpAxis(_Underlying *_this);
            return __btCapsuleShape_getUpAxis(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getRadius`.
        public unsafe double GetRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCapsuleShape_getRadius(_Underlying *_this);
            return __btCapsuleShape_getRadius(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getHalfHeight`.
        public unsafe double GetHalfHeight()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getHalfHeight", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCapsuleShape_getHalfHeight(_Underlying *_this);
            return __btCapsuleShape_getHalfHeight(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getAnisotropicRollingFrictionDirection`.
        public unsafe Bullet.BtVector3 GetAnisotropicRollingFrictionDirection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btCapsuleShape_getAnisotropicRollingFrictionDirection(_Underlying *_this);
            return new(__btCapsuleShape_getAnisotropicRollingFrictionDirection(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btCapsuleShape::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCapsuleShape_calculateSerializeBufferSize(_Underlying *_this);
            return __btCapsuleShape_calculateSerializeBufferSize(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::localGetSupportingVertex`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertex(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btCapsuleShape_localGetSupportingVertex(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btCapsuleShape_localGetSupportingVertex(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btCapsuleShape::getImplicitShapeDimensions`.
        public unsafe Bullet.Const_BtVector3 GetImplicitShapeDimensions()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btCapsuleShape_getImplicitShapeDimensions(_Underlying *_this);
            return new(__btCapsuleShape_getImplicitShapeDimensions(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCapsuleShape::getAabbSlow`.
        public unsafe void GetAabbSlow(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_getAabbSlow(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btCapsuleShape_getAabbSlow(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getLocalScaling`.
        public unsafe Bullet.Const_BtVector3 GetLocalScaling()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btCapsuleShape_getLocalScaling(_Underlying *_this);
            return new(__btCapsuleShape_getLocalScaling(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCapsuleShape::getLocalScalingNV`.
        public unsafe Bullet.Const_BtVector3 GetLocalScalingNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btCapsuleShape_getLocalScalingNV(_Underlying *_this);
            return new(__btCapsuleShape_getLocalScalingNV(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCapsuleShape::getMargin`.
        public unsafe double GetMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCapsuleShape_getMargin(_Underlying *_this);
            return __btCapsuleShape_getMargin(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getMarginNV`.
        public unsafe double GetMarginNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCapsuleShape_getMarginNV(_Underlying *_this);
            return __btCapsuleShape_getMarginNV(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getNumPreferredPenetrationDirections`.
        public unsafe int GetNumPreferredPenetrationDirections()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCapsuleShape_getNumPreferredPenetrationDirections(_Underlying *_this);
            return __btCapsuleShape_getNumPreferredPenetrationDirections(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getPreferredPenetrationDirection`.
        public unsafe void GetPreferredPenetrationDirection(int index, Bullet.BtVector3 penetrationVector)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_getPreferredPenetrationDirection(_Underlying *_this, int index, Bullet.BtVector3._Underlying *penetrationVector);
            __btCapsuleShape_getPreferredPenetrationDirection(_UnderlyingPtr, index, penetrationVector._UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::localGetSupportVertexWithoutMarginNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexWithoutMarginNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btCapsuleShape_localGetSupportVertexWithoutMarginNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btCapsuleShape_localGetSupportVertexWithoutMarginNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btCapsuleShape::localGetSupportVertexNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btCapsuleShape_localGetSupportVertexNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btCapsuleShape_localGetSupportVertexNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btCapsuleShape::getMarginNonVirtual`.
        public unsafe double GetMarginNonVirtual()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCapsuleShape_getMarginNonVirtual(_Underlying *_this);
            return __btCapsuleShape_getMarginNonVirtual(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getAabbNonVirtual`.
        public unsafe void GetAabbNonVirtual(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_getAabbNonVirtual(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btCapsuleShape_getAabbNonVirtual(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::project`.
        public unsafe void Project(Bullet.Const_BtTransform trans, Bullet.Const_BtVector3 dir, ref double minProj, ref double maxProj, Bullet.BtVector3 witnesPtMin, Bullet.BtVector3 witnesPtMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_project(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans, Bullet.Const_BtVector3._Underlying *dir, double *minProj, double *maxProj, Bullet.BtVector3._Underlying *witnesPtMin, Bullet.BtVector3._Underlying *witnesPtMax);
            fixed (double *__ptr_minProj = &minProj)
            {
                fixed (double *__ptr_maxProj = &maxProj)
                {
                    __btCapsuleShape_project(_UnderlyingPtr, trans._UnderlyingPtr, dir._UnderlyingPtr, __ptr_minProj, __ptr_maxProj, witnesPtMin._UnderlyingPtr, witnesPtMax._UnderlyingPtr);
                }
            }
        }

        /// Generated from method `btCapsuleShape::getBoundingSphere`.
        public unsafe void GetBoundingSphere(Bullet.BtVector3 center, ref double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_getBoundingSphere(_Underlying *_this, Bullet.BtVector3._Underlying *center, double *radius);
            fixed (double *__ptr_radius = &radius)
            {
                __btCapsuleShape_getBoundingSphere(_UnderlyingPtr, center._UnderlyingPtr, __ptr_radius);
            }
        }

        ///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
        /// Generated from method `btCapsuleShape::getAngularMotionDisc`.
        public unsafe double GetAngularMotionDisc()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCapsuleShape_getAngularMotionDisc(_Underlying *_this);
            return __btCapsuleShape_getAngularMotionDisc(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getContactBreakingThreshold`.
        public unsafe double GetContactBreakingThreshold(double defaultContactThresholdFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCapsuleShape_getContactBreakingThreshold(_Underlying *_this, double defaultContactThresholdFactor);
            return __btCapsuleShape_getContactBreakingThreshold(_UnderlyingPtr, defaultContactThresholdFactor);
        }

        ///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
        ///result is conservative
        /// Generated from method `btCapsuleShape::calculateTemporalAabb`.
        public unsafe void CalculateTemporalAabb(Bullet.Const_BtTransform curTrans, Bullet.Const_BtVector3 linvel, Bullet.Const_BtVector3 angvel, double timeStep, Bullet.BtVector3 temporalAabbMin, Bullet.BtVector3 temporalAabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_calculateTemporalAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *curTrans, Bullet.Const_BtVector3._Underlying *linvel, Bullet.Const_BtVector3._Underlying *angvel, double timeStep, Bullet.BtVector3._Underlying *temporalAabbMin, Bullet.BtVector3._Underlying *temporalAabbMax);
            __btCapsuleShape_calculateTemporalAabb(_UnderlyingPtr, curTrans._UnderlyingPtr, linvel._UnderlyingPtr, angvel._UnderlyingPtr, timeStep, temporalAabbMin._UnderlyingPtr, temporalAabbMax._UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::isPolyhedral`.
        public unsafe bool IsPolyhedral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCapsuleShape_isPolyhedral(_Underlying *_this);
            return __btCapsuleShape_isPolyhedral(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCapsuleShape::isConvex2d`.
        public unsafe bool IsConvex2d()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCapsuleShape_isConvex2d(_Underlying *_this);
            return __btCapsuleShape_isConvex2d(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCapsuleShape::isConvex`.
        public unsafe bool IsConvex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCapsuleShape_isConvex(_Underlying *_this);
            return __btCapsuleShape_isConvex(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCapsuleShape::isNonMoving`.
        public unsafe bool IsNonMoving()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCapsuleShape_isNonMoving(_Underlying *_this);
            return __btCapsuleShape_isNonMoving(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCapsuleShape::isConcave`.
        public unsafe bool IsConcave()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCapsuleShape_isConcave(_Underlying *_this);
            return __btCapsuleShape_isConcave(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCapsuleShape::isCompound`.
        public unsafe bool IsCompound()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCapsuleShape_isCompound(_Underlying *_this);
            return __btCapsuleShape_isCompound(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCapsuleShape::isSoftBody`.
        public unsafe bool IsSoftBody()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCapsuleShape_isSoftBody(_Underlying *_this);
            return __btCapsuleShape_isSoftBody(_UnderlyingPtr) != 0;
        }

        ///isInfinite is used to catch simulation error (aabb check)
        /// Generated from method `btCapsuleShape::isInfinite`.
        public unsafe bool IsInfinite()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCapsuleShape_isInfinite(_Underlying *_this);
            return __btCapsuleShape_isInfinite(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCapsuleShape::getShapeType`.
        public unsafe int GetShapeType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCapsuleShape_getShapeType(_Underlying *_this);
            return __btCapsuleShape_getShapeType(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btCapsuleShape_getUserPointer(_Underlying *_this);
            return __btCapsuleShape_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCapsuleShape_getUserIndex(_Underlying *_this);
            return __btCapsuleShape_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btCapsuleShape::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCapsuleShape_getUserIndex2(_Underlying *_this);
            return __btCapsuleShape_getUserIndex2(_UnderlyingPtr);
        }
    }

    ///The btCapsuleShape represents a capsule around the Y axis, there is also the btCapsuleShapeX aligned around the X axis and btCapsuleShapeZ around the Z axis.
    ///The total height is height+2*radius, so the height is just the height between the center of each 'sphere' of the capsule caps.
    ///The btCapsuleShape is a convex hull of two spheres. The btMultiSphereShape is a more general collision shape that takes the convex hull of multiple sphere, so it can also represent a capsule when just using two spheres.
    /// Generated from class `btCapsuleShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexInternalShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    /// This is the non-const half of the class.
    public class BtCapsuleShape : Const_BtCapsuleShape
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionShape(BtCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionShape._Underlying *__btCapsuleShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.BtCollisionShape ret = new(__btCapsuleShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexShape(BtCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexShape._Underlying *__btCapsuleShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.BtConvexShape ret = new(__btCapsuleShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexInternalShape(BtCapsuleShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexInternalShape._Underlying *__btCapsuleShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.BtConvexInternalShape ret = new(__btCapsuleShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtCapsuleShape?(Bullet.BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCapsuleShape_DynamicDowncastFrom_btCollisionShape(Bullet.BtCollisionShape._Underlying *_this);
            var ptr = __btCapsuleShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtCapsuleShape?(Bullet.BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCapsuleShape_DynamicDowncastFrom_btConvexShape(Bullet.BtConvexShape._Underlying *_this);
            var ptr = __btCapsuleShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtCapsuleShape?(Bullet.BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.BtConvexInternalShape._Underlying *_this);
            var ptr = __btCapsuleShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtCapsuleShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtCapsuleShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btCapsuleShape::btCapsuleShape`.
        public unsafe BtCapsuleShape(Bullet._ByValue_BtCapsuleShape _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCapsuleShape._Underlying *__btCapsuleShape_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCapsuleShape._Underlying *_other);
            _UnderlyingPtr = __btCapsuleShape_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCapsuleShape::btCapsuleShape`.
        public BtCapsuleShape(Const_BtCapsuleShape _other) : this(new _ByValue_BtCapsuleShape(_other)) {}

        /// Generated from constructor `btCapsuleShape::btCapsuleShape`.
        public BtCapsuleShape(BtCapsuleShape _other) : this((Const_BtCapsuleShape)_other) {}

        /// Generated from constructor `btCapsuleShape::btCapsuleShape`.
        public unsafe BtCapsuleShape(double radius, double height) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCapsuleShape._Underlying *__btCapsuleShape_Construct(double radius, double height);
            _UnderlyingPtr = __btCapsuleShape_Construct(radius, height);
        }

        /// Generated from method `btCapsuleShape::operator=`.
        public unsafe Bullet.BtCapsuleShape Assign(Bullet._ByValue_BtCapsuleShape _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCapsuleShape._Underlying *__btCapsuleShape_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtCapsuleShape._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btCapsuleShape_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btCapsuleShape::setMargin`.
        public unsafe void SetMargin(double collisionMargin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_setMargin(_Underlying *_this, double collisionMargin);
            __btCapsuleShape_setMargin(_UnderlyingPtr, collisionMargin);
        }

        /// Generated from method `btCapsuleShape::setLocalScaling`.
        public unsafe void SetLocalScaling(Bullet.Const_BtVector3 scaling)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_setLocalScaling(_Underlying *_this, Bullet.Const_BtVector3._Underlying *scaling);
            __btCapsuleShape_setLocalScaling(_UnderlyingPtr, scaling._UnderlyingPtr);
        }

        ///warning: use setImplicitShapeDimensions with care
        ///changing a collision shape while the body is in the world is not recommended,
        ///it is best to remove the body from the world, then make the change, and re-add it
        ///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
        /// Generated from method `btCapsuleShape::setImplicitShapeDimensions`.
        public unsafe void SetImplicitShapeDimensions(Bullet.Const_BtVector3 dimensions)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_setImplicitShapeDimensions(_Underlying *_this, Bullet.Const_BtVector3._Underlying *dimensions);
            __btCapsuleShape_setImplicitShapeDimensions(_UnderlyingPtr, dimensions._UnderlyingPtr);
        }

        ///optional user data pointer
        /// Generated from method `btCapsuleShape::setUserPointer`.
        /// Parameter `userPtr` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPtr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_setUserPointer(_Underlying *_this, void *userPtr);
            __btCapsuleShape_setUserPointer(_UnderlyingPtr, userPtr);
        }

        /// Generated from method `btCapsuleShape::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_setUserIndex(_Underlying *_this, int index);
            __btCapsuleShape_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btCapsuleShape::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCapsuleShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCapsuleShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCapsuleShape_setUserIndex2(_Underlying *_this, int index);
            __btCapsuleShape_setUserIndex2(_UnderlyingPtr, index);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtCapsuleShape` by value.
    /// Usage:
    /// * Pass an instance of `BtCapsuleShape`/`Const_BtCapsuleShape` to copy it into the function.
    /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
    ///   Be careful if your input isn't a unique reference to this object.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtCapsuleShape
    {
        #pragma warning disable CS0649
        internal readonly Const_BtCapsuleShape? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtCapsuleShape(Const_BtCapsuleShape new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtCapsuleShape(Const_BtCapsuleShape arg) {return new(arg);}
        public _ByValue_BtCapsuleShape(Bullet._Moved<BtCapsuleShape> moved) {Value = moved.Value; PassByMode = Bullet._PassBy.move;}
        public static implicit operator _ByValue_BtCapsuleShape(Bullet._Moved<BtCapsuleShape> arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtCapsuleShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtCapsuleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCapsuleShape`/`Const_BtCapsuleShape` directly.
    public class _InOptMut_BtCapsuleShape
    {
        public BtCapsuleShape? Opt;

        public _InOptMut_BtCapsuleShape() {}
        public _InOptMut_BtCapsuleShape(BtCapsuleShape value) {Opt = value;}
        public static implicit operator _InOptMut_BtCapsuleShape(BtCapsuleShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtCapsuleShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtCapsuleShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCapsuleShape`/`Const_BtCapsuleShape` to pass it to the function.
    public class _InOptConst_BtCapsuleShape
    {
        public Const_BtCapsuleShape? Opt;

        public _InOptConst_BtCapsuleShape() {}
        public _InOptConst_BtCapsuleShape(Const_BtCapsuleShape value) {Opt = value;}
        public static implicit operator _InOptConst_BtCapsuleShape(Const_BtCapsuleShape value) {return new(value);}
    }
}
