// machine generated, do not edit
public static partial class Bullet
{
    ///The btConvexInternalShape is an internal base class, shared by most convex shape implementations.
    ///The btConvexInternalShape uses a default collision margin set to CONVEX_DISTANCE_MARGIN.
    ///This collision margin used by Gjk and some other algorithms, see also btCollisionMargin.h
    ///Note that when creating small shapes (derived from btConvexInternalShape),
    ///you need to make sure to set a smaller collision margin, using the 'setMargin' API
    ///There is a automatic mechanism 'setSafeMargin' used by btBoxShape and btCylinderShape
    /// Generated from class `btConvexInternalShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btCapsuleShape`
    ///     `btConvexInternalAabbCachingShape`
    ///     `btPolyhedralConvexShape`
    ///     `btSphereShape`
    ///   Indirect: (non-virtual)
    ///     `btBoxShape`
    ///     `btPolyhedralConvexAabbCachingShape`
    /// This is the const half of the class.
    public class Const_BtConvexInternalShape : Bullet.Object<Const_BtConvexInternalShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_Destroy(_Underlying *_this);
            __btConvexInternalShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtConvexInternalShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionShape(Const_BtConvexInternalShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionShape._Underlying *__btConvexInternalShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.Const_BtCollisionShape ret = new(__btConvexInternalShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexShape(Const_BtConvexInternalShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexShape._Underlying *__btConvexInternalShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.Const_BtConvexShape ret = new(__btConvexInternalShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtConvexInternalShape?(Bullet.Const_BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalShape_DynamicDowncastFrom_btCollisionShape(Bullet.Const_BtCollisionShape._Underlying *_this);
            var ptr = __btConvexInternalShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtConvexInternalShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtConvexInternalShape?(Bullet.Const_BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalShape_DynamicDowncastFrom_btConvexShape(Bullet.Const_BtConvexShape._Underlying *_this);
            var ptr = __btConvexInternalShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtConvexInternalShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtConvexInternalShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btConvexInternalShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btConvexInternalShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btConvexInternalShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btConvexInternalShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btConvexInternalShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btConvexInternalShape::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btConvexInternalShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btConvexInternalShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btConvexInternalShape_void_ptr(void *ptr);
            __Bullet_delete_btConvexInternalShape_void_ptr(ptr);
        }

        /// Generated from method `btConvexInternalShape::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btConvexInternalShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btConvexInternalShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btConvexInternalShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btConvexInternalShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btConvexInternalShape::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btConvexInternalShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btConvexInternalShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btConvexInternalShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btConvexInternalShape_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btConvexInternalShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btConvexInternalShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btConvexInternalShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btConvexInternalShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btConvexInternalShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btConvexInternalShape::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btConvexInternalShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btConvexInternalShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btConvexInternalShape_void_ptr(void *ptr);
            __Bullet_delete_array_btConvexInternalShape_void_ptr(ptr);
        }

        /// Generated from method `btConvexInternalShape::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btConvexInternalShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btConvexInternalShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btConvexInternalShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btConvexInternalShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btConvexInternalShape::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btConvexInternalShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btConvexInternalShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btConvexInternalShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btConvexInternalShape_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btConvexInternalShape::localGetSupportingVertex`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertex(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalShape_localGetSupportingVertex(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btConvexInternalShape_localGetSupportingVertex(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalShape::getImplicitShapeDimensions`.
        public unsafe Bullet.Const_BtVector3 GetImplicitShapeDimensions()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btConvexInternalShape_getImplicitShapeDimensions(_Underlying *_this);
            return new(__btConvexInternalShape_getImplicitShapeDimensions(_UnderlyingPtr), is_owning: false);
        }

        ///getAabb's default implementation is brute force, expected derived classes to implement a fast dedicated version
        /// Generated from method `btConvexInternalShape::getAabb`.
        public unsafe void GetAabb(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_getAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btConvexInternalShape_getAabb(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::getAabbSlow`.
        public unsafe void GetAabbSlow(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_getAabbSlow(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btConvexInternalShape_getAabbSlow(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::getLocalScaling`.
        public unsafe Bullet.Const_BtVector3 GetLocalScaling()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btConvexInternalShape_getLocalScaling(_Underlying *_this);
            return new(__btConvexInternalShape_getLocalScaling(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btConvexInternalShape::getLocalScalingNV`.
        public unsafe Bullet.Const_BtVector3 GetLocalScalingNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btConvexInternalShape_getLocalScalingNV(_Underlying *_this);
            return new(__btConvexInternalShape_getLocalScalingNV(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btConvexInternalShape::getMargin`.
        public unsafe double GetMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalShape_getMargin(_Underlying *_this);
            return __btConvexInternalShape_getMargin(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::getMarginNV`.
        public unsafe double GetMarginNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalShape_getMarginNV(_Underlying *_this);
            return __btConvexInternalShape_getMarginNV(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::getNumPreferredPenetrationDirections`.
        public unsafe int GetNumPreferredPenetrationDirections()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalShape_getNumPreferredPenetrationDirections(_Underlying *_this);
            return __btConvexInternalShape_getNumPreferredPenetrationDirections(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::getPreferredPenetrationDirection`.
        public unsafe void GetPreferredPenetrationDirection(int index, Bullet.BtVector3 penetrationVector)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_getPreferredPenetrationDirection(_Underlying *_this, int index, Bullet.BtVector3._Underlying *penetrationVector);
            __btConvexInternalShape_getPreferredPenetrationDirection(_UnderlyingPtr, index, penetrationVector._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalShape_calculateSerializeBufferSize(_Underlying *_this);
            return __btConvexInternalShape_calculateSerializeBufferSize(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::localGetSupportingVertexWithoutMargin`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalShape_localGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btConvexInternalShape_localGetSupportingVertexWithoutMargin(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalShape::localGetSupportVertexWithoutMarginNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexWithoutMarginNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalShape_localGetSupportVertexWithoutMarginNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btConvexInternalShape_localGetSupportVertexWithoutMarginNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalShape::localGetSupportVertexNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalShape_localGetSupportVertexNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btConvexInternalShape_localGetSupportVertexNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalShape::getMarginNonVirtual`.
        public unsafe double GetMarginNonVirtual()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalShape_getMarginNonVirtual(_Underlying *_this);
            return __btConvexInternalShape_getMarginNonVirtual(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::getAabbNonVirtual`.
        public unsafe void GetAabbNonVirtual(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_getAabbNonVirtual(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btConvexInternalShape_getAabbNonVirtual(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::project`.
        public unsafe void Project(Bullet.Const_BtTransform trans, Bullet.Const_BtVector3 dir, ref double minProj, ref double maxProj, Bullet.BtVector3 witnesPtMin, Bullet.BtVector3 witnesPtMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_project(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans, Bullet.Const_BtVector3._Underlying *dir, double *minProj, double *maxProj, Bullet.BtVector3._Underlying *witnesPtMin, Bullet.BtVector3._Underlying *witnesPtMax);
            fixed (double *__ptr_minProj = &minProj)
            {
                fixed (double *__ptr_maxProj = &maxProj)
                {
                    __btConvexInternalShape_project(_UnderlyingPtr, trans._UnderlyingPtr, dir._UnderlyingPtr, __ptr_minProj, __ptr_maxProj, witnesPtMin._UnderlyingPtr, witnesPtMax._UnderlyingPtr);
                }
            }
        }

        //notice that the vectors should be unit length
        /// Generated from method `btConvexInternalShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
        public unsafe void BatchedUnitVectorGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3? vectors, Bullet.BtVector3? supportVerticesOut, int numVectors)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vectors, Bullet.BtVector3._Underlying *supportVerticesOut, int numVectors);
            __btConvexInternalShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_UnderlyingPtr, vectors is not null ? vectors._UnderlyingPtr : null, supportVerticesOut is not null ? supportVerticesOut._UnderlyingPtr : null, numVectors);
        }

        /// Generated from method `btConvexInternalShape::getBoundingSphere`.
        public unsafe void GetBoundingSphere(Bullet.BtVector3 center, ref double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_getBoundingSphere(_Underlying *_this, Bullet.BtVector3._Underlying *center, double *radius);
            fixed (double *__ptr_radius = &radius)
            {
                __btConvexInternalShape_getBoundingSphere(_UnderlyingPtr, center._UnderlyingPtr, __ptr_radius);
            }
        }

        ///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
        /// Generated from method `btConvexInternalShape::getAngularMotionDisc`.
        public unsafe double GetAngularMotionDisc()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalShape_getAngularMotionDisc(_Underlying *_this);
            return __btConvexInternalShape_getAngularMotionDisc(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::getContactBreakingThreshold`.
        public unsafe double GetContactBreakingThreshold(double defaultContactThresholdFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalShape_getContactBreakingThreshold(_Underlying *_this, double defaultContactThresholdFactor);
            return __btConvexInternalShape_getContactBreakingThreshold(_UnderlyingPtr, defaultContactThresholdFactor);
        }

        ///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
        ///result is conservative
        /// Generated from method `btConvexInternalShape::calculateTemporalAabb`.
        public unsafe void CalculateTemporalAabb(Bullet.Const_BtTransform curTrans, Bullet.Const_BtVector3 linvel, Bullet.Const_BtVector3 angvel, double timeStep, Bullet.BtVector3 temporalAabbMin, Bullet.BtVector3 temporalAabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_calculateTemporalAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *curTrans, Bullet.Const_BtVector3._Underlying *linvel, Bullet.Const_BtVector3._Underlying *angvel, double timeStep, Bullet.BtVector3._Underlying *temporalAabbMin, Bullet.BtVector3._Underlying *temporalAabbMax);
            __btConvexInternalShape_calculateTemporalAabb(_UnderlyingPtr, curTrans._UnderlyingPtr, linvel._UnderlyingPtr, angvel._UnderlyingPtr, timeStep, temporalAabbMin._UnderlyingPtr, temporalAabbMax._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::isPolyhedral`.
        public unsafe bool IsPolyhedral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalShape_isPolyhedral(_Underlying *_this);
            return __btConvexInternalShape_isPolyhedral(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalShape::isConvex2d`.
        public unsafe bool IsConvex2d()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalShape_isConvex2d(_Underlying *_this);
            return __btConvexInternalShape_isConvex2d(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalShape::isConvex`.
        public unsafe bool IsConvex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalShape_isConvex(_Underlying *_this);
            return __btConvexInternalShape_isConvex(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalShape::isNonMoving`.
        public unsafe bool IsNonMoving()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalShape_isNonMoving(_Underlying *_this);
            return __btConvexInternalShape_isNonMoving(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalShape::isConcave`.
        public unsafe bool IsConcave()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalShape_isConcave(_Underlying *_this);
            return __btConvexInternalShape_isConcave(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalShape::isCompound`.
        public unsafe bool IsCompound()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalShape_isCompound(_Underlying *_this);
            return __btConvexInternalShape_isCompound(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalShape::isSoftBody`.
        public unsafe bool IsSoftBody()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalShape_isSoftBody(_Underlying *_this);
            return __btConvexInternalShape_isSoftBody(_UnderlyingPtr) != 0;
        }

        ///isInfinite is used to catch simulation error (aabb check)
        /// Generated from method `btConvexInternalShape::isInfinite`.
        public unsafe bool IsInfinite()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalShape_isInfinite(_Underlying *_this);
            return __btConvexInternalShape_isInfinite(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalShape::calculateLocalInertia`.
        public unsafe void CalculateLocalInertia(double mass, Bullet.BtVector3 inertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_calculateLocalInertia(_Underlying *_this, double mass, Bullet.BtVector3._Underlying *inertia);
            __btConvexInternalShape_calculateLocalInertia(_UnderlyingPtr, mass, inertia._UnderlyingPtr);
        }

        //debugging support
        /// Generated from method `btConvexInternalShape::getName`.
        public unsafe byte? GetName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__btConvexInternalShape_getName(_Underlying *_this);
            var __c_ret = __btConvexInternalShape_getName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btConvexInternalShape::getShapeType`.
        public unsafe int GetShapeType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalShape_getShapeType(_Underlying *_this);
            return __btConvexInternalShape_getShapeType(_UnderlyingPtr);
        }

        ///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
        ///See Bullet/Demos/RollingFrictionDemo for an example
        /// Generated from method `btConvexInternalShape::getAnisotropicRollingFrictionDirection`.
        public unsafe Bullet.BtVector3 GetAnisotropicRollingFrictionDirection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalShape_getAnisotropicRollingFrictionDirection(_Underlying *_this);
            return new(__btConvexInternalShape_getAnisotropicRollingFrictionDirection(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalShape::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btConvexInternalShape_getUserPointer(_Underlying *_this);
            return __btConvexInternalShape_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalShape_getUserIndex(_Underlying *_this);
            return __btConvexInternalShape_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalShape_getUserIndex2(_Underlying *_this);
            return __btConvexInternalShape_getUserIndex2(_UnderlyingPtr);
        }
    }

    ///The btConvexInternalShape is an internal base class, shared by most convex shape implementations.
    ///The btConvexInternalShape uses a default collision margin set to CONVEX_DISTANCE_MARGIN.
    ///This collision margin used by Gjk and some other algorithms, see also btCollisionMargin.h
    ///Note that when creating small shapes (derived from btConvexInternalShape),
    ///you need to make sure to set a smaller collision margin, using the 'setMargin' API
    ///There is a automatic mechanism 'setSafeMargin' used by btBoxShape and btCylinderShape
    /// Generated from class `btConvexInternalShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btCapsuleShape`
    ///     `btConvexInternalAabbCachingShape`
    ///     `btPolyhedralConvexShape`
    ///     `btSphereShape`
    ///   Indirect: (non-virtual)
    ///     `btBoxShape`
    ///     `btPolyhedralConvexAabbCachingShape`
    /// This is the non-const half of the class.
    public class BtConvexInternalShape : Const_BtConvexInternalShape
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionShape(BtConvexInternalShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionShape._Underlying *__btConvexInternalShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.BtCollisionShape ret = new(__btConvexInternalShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexShape(BtConvexInternalShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexShape._Underlying *__btConvexInternalShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.BtConvexShape ret = new(__btConvexInternalShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtConvexInternalShape?(Bullet.BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalShape_DynamicDowncastFrom_btCollisionShape(Bullet.BtCollisionShape._Underlying *_this);
            var ptr = __btConvexInternalShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtConvexInternalShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtConvexInternalShape?(Bullet.BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalShape_DynamicDowncastFrom_btConvexShape(Bullet.BtConvexShape._Underlying *_this);
            var ptr = __btConvexInternalShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtConvexInternalShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtConvexInternalShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        ///warning: use setImplicitShapeDimensions with care
        ///changing a collision shape while the body is in the world is not recommended,
        ///it is best to remove the body from the world, then make the change, and re-add it
        ///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
        /// Generated from method `btConvexInternalShape::setImplicitShapeDimensions`.
        public unsafe void SetImplicitShapeDimensions(Bullet.Const_BtVector3 dimensions)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_setImplicitShapeDimensions(_Underlying *_this, Bullet.Const_BtVector3._Underlying *dimensions);
            __btConvexInternalShape_setImplicitShapeDimensions(_UnderlyingPtr, dimensions._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::setSafeMargin`.
        /// Parameter `defaultMarginMultiplier` defaults to `0.100000001f`.
        public unsafe void SetSafeMargin(double minDimension, double? defaultMarginMultiplier = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_setSafeMargin_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_setSafeMargin_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_setSafeMargin_double(_Underlying *_this, double minDimension, double *defaultMarginMultiplier);
            double __deref_defaultMarginMultiplier = defaultMarginMultiplier.GetValueOrDefault();
            __btConvexInternalShape_setSafeMargin_double(_UnderlyingPtr, minDimension, defaultMarginMultiplier.HasValue ? &__deref_defaultMarginMultiplier : null);
        }

        /// Generated from method `btConvexInternalShape::setSafeMargin`.
        /// Parameter `defaultMarginMultiplier` defaults to `0.100000001f`.
        public unsafe void SetSafeMargin(Bullet.Const_BtVector3 halfExtents, double? defaultMarginMultiplier = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_setSafeMargin_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_setSafeMargin_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_setSafeMargin_btVector3(_Underlying *_this, Bullet.Const_BtVector3._Underlying *halfExtents, double *defaultMarginMultiplier);
            double __deref_defaultMarginMultiplier = defaultMarginMultiplier.GetValueOrDefault();
            __btConvexInternalShape_setSafeMargin_btVector3(_UnderlyingPtr, halfExtents._UnderlyingPtr, defaultMarginMultiplier.HasValue ? &__deref_defaultMarginMultiplier : null);
        }

        /// Generated from method `btConvexInternalShape::setLocalScaling`.
        public unsafe void SetLocalScaling(Bullet.Const_BtVector3 scaling)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_setLocalScaling(_Underlying *_this, Bullet.Const_BtVector3._Underlying *scaling);
            __btConvexInternalShape_setLocalScaling(_UnderlyingPtr, scaling._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalShape::setMargin`.
        public unsafe void SetMargin(double margin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_setMargin(_Underlying *_this, double margin);
            __btConvexInternalShape_setMargin(_UnderlyingPtr, margin);
        }

        ///optional user data pointer
        /// Generated from method `btConvexInternalShape::setUserPointer`.
        /// Parameter `userPtr` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPtr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_setUserPointer(_Underlying *_this, void *userPtr);
            __btConvexInternalShape_setUserPointer(_UnderlyingPtr, userPtr);
        }

        /// Generated from method `btConvexInternalShape::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_setUserIndex(_Underlying *_this, int index);
            __btConvexInternalShape_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btConvexInternalShape::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalShape_setUserIndex2(_Underlying *_this, int index);
            __btConvexInternalShape_setUserIndex2(_UnderlyingPtr, index);
        }
    }

    /// This is used for optional parameters of class `BtConvexInternalShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtConvexInternalShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtConvexInternalShape`/`Const_BtConvexInternalShape` directly.
    public class _InOptMut_BtConvexInternalShape
    {
        public BtConvexInternalShape? Opt;

        public _InOptMut_BtConvexInternalShape() {}
        public _InOptMut_BtConvexInternalShape(BtConvexInternalShape value) {Opt = value;}
        public static implicit operator _InOptMut_BtConvexInternalShape(BtConvexInternalShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtConvexInternalShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtConvexInternalShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtConvexInternalShape`/`Const_BtConvexInternalShape` to pass it to the function.
    public class _InOptConst_BtConvexInternalShape
    {
        public Const_BtConvexInternalShape? Opt;

        public _InOptConst_BtConvexInternalShape() {}
        public _InOptConst_BtConvexInternalShape(Const_BtConvexInternalShape value) {Opt = value;}
        public static implicit operator _InOptConst_BtConvexInternalShape(Const_BtConvexInternalShape value) {return new(value);}
    }

    ///btConvexInternalAabbCachingShape adds local aabb caching for convex shapes, to avoid expensive bounding box calculations
    /// Generated from class `btConvexInternalAabbCachingShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexInternalShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    /// This is the const half of the class.
    public class Const_BtConvexInternalAabbCachingShape : Bullet.Object<Const_BtConvexInternalAabbCachingShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_Destroy(_Underlying *_this);
            __btConvexInternalAabbCachingShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtConvexInternalAabbCachingShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionShape(Const_BtConvexInternalAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionShape._Underlying *__btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.Const_BtCollisionShape ret = new(__btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexShape(Const_BtConvexInternalAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexShape._Underlying *__btConvexInternalAabbCachingShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.Const_BtConvexShape ret = new(__btConvexInternalAabbCachingShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexInternalShape(Const_BtConvexInternalAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexInternalShape._Underlying *__btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.Const_BtConvexInternalShape ret = new(__btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtConvexInternalAabbCachingShape?(Bullet.Const_BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape(Bullet.Const_BtCollisionShape._Underlying *_this);
            var ptr = __btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtConvexInternalAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtConvexInternalAabbCachingShape?(Bullet.Const_BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape(Bullet.Const_BtConvexShape._Underlying *_this);
            var ptr = __btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtConvexInternalAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtConvexInternalAabbCachingShape?(Bullet.Const_BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.Const_BtConvexInternalShape._Underlying *_this);
            var ptr = __btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtConvexInternalAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtConvexInternalAabbCachingShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btConvexInternalAabbCachingShape::getAabb`.
        public unsafe void GetAabb(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_getAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btConvexInternalAabbCachingShape_getAabb(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::localGetSupportingVertex`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertex(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalAabbCachingShape_localGetSupportingVertex(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btConvexInternalAabbCachingShape_localGetSupportingVertex(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getImplicitShapeDimensions`.
        public unsafe Bullet.Const_BtVector3 GetImplicitShapeDimensions()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btConvexInternalAabbCachingShape_getImplicitShapeDimensions(_Underlying *_this);
            return new(__btConvexInternalAabbCachingShape_getImplicitShapeDimensions(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getAabbSlow`.
        public unsafe void GetAabbSlow(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_getAabbSlow(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btConvexInternalAabbCachingShape_getAabbSlow(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getLocalScaling`.
        public unsafe Bullet.Const_BtVector3 GetLocalScaling()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btConvexInternalAabbCachingShape_getLocalScaling(_Underlying *_this);
            return new(__btConvexInternalAabbCachingShape_getLocalScaling(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getLocalScalingNV`.
        public unsafe Bullet.Const_BtVector3 GetLocalScalingNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btConvexInternalAabbCachingShape_getLocalScalingNV(_Underlying *_this);
            return new(__btConvexInternalAabbCachingShape_getLocalScalingNV(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getMargin`.
        public unsafe double GetMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalAabbCachingShape_getMargin(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_getMargin(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getMarginNV`.
        public unsafe double GetMarginNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalAabbCachingShape_getMarginNV(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_getMarginNV(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getNumPreferredPenetrationDirections`.
        public unsafe int GetNumPreferredPenetrationDirections()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalAabbCachingShape_getNumPreferredPenetrationDirections(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_getNumPreferredPenetrationDirections(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getPreferredPenetrationDirection`.
        public unsafe void GetPreferredPenetrationDirection(int index, Bullet.BtVector3 penetrationVector)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_getPreferredPenetrationDirection(_Underlying *_this, int index, Bullet.BtVector3._Underlying *penetrationVector);
            __btConvexInternalAabbCachingShape_getPreferredPenetrationDirection(_UnderlyingPtr, index, penetrationVector._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalAabbCachingShape_calculateSerializeBufferSize(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_calculateSerializeBufferSize(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::localGetSupportingVertexWithoutMargin`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalAabbCachingShape_localGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btConvexInternalAabbCachingShape_localGetSupportingVertexWithoutMargin(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::localGetSupportVertexWithoutMarginNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexWithoutMarginNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btConvexInternalAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::localGetSupportVertexNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalAabbCachingShape_localGetSupportVertexNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btConvexInternalAabbCachingShape_localGetSupportVertexNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getMarginNonVirtual`.
        public unsafe double GetMarginNonVirtual()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalAabbCachingShape_getMarginNonVirtual(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_getMarginNonVirtual(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getAabbNonVirtual`.
        public unsafe void GetAabbNonVirtual(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_getAabbNonVirtual(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btConvexInternalAabbCachingShape_getAabbNonVirtual(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::project`.
        public unsafe void Project(Bullet.Const_BtTransform trans, Bullet.Const_BtVector3 dir, ref double minProj, ref double maxProj, Bullet.BtVector3 witnesPtMin, Bullet.BtVector3 witnesPtMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_project(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans, Bullet.Const_BtVector3._Underlying *dir, double *minProj, double *maxProj, Bullet.BtVector3._Underlying *witnesPtMin, Bullet.BtVector3._Underlying *witnesPtMax);
            fixed (double *__ptr_minProj = &minProj)
            {
                fixed (double *__ptr_maxProj = &maxProj)
                {
                    __btConvexInternalAabbCachingShape_project(_UnderlyingPtr, trans._UnderlyingPtr, dir._UnderlyingPtr, __ptr_minProj, __ptr_maxProj, witnesPtMin._UnderlyingPtr, witnesPtMax._UnderlyingPtr);
                }
            }
        }

        //notice that the vectors should be unit length
        /// Generated from method `btConvexInternalAabbCachingShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
        public unsafe void BatchedUnitVectorGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3? vectors, Bullet.BtVector3? supportVerticesOut, int numVectors)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vectors, Bullet.BtVector3._Underlying *supportVerticesOut, int numVectors);
            __btConvexInternalAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_UnderlyingPtr, vectors is not null ? vectors._UnderlyingPtr : null, supportVerticesOut is not null ? supportVerticesOut._UnderlyingPtr : null, numVectors);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getBoundingSphere`.
        public unsafe void GetBoundingSphere(Bullet.BtVector3 center, ref double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_getBoundingSphere(_Underlying *_this, Bullet.BtVector3._Underlying *center, double *radius);
            fixed (double *__ptr_radius = &radius)
            {
                __btConvexInternalAabbCachingShape_getBoundingSphere(_UnderlyingPtr, center._UnderlyingPtr, __ptr_radius);
            }
        }

        ///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
        /// Generated from method `btConvexInternalAabbCachingShape::getAngularMotionDisc`.
        public unsafe double GetAngularMotionDisc()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalAabbCachingShape_getAngularMotionDisc(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_getAngularMotionDisc(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getContactBreakingThreshold`.
        public unsafe double GetContactBreakingThreshold(double defaultContactThresholdFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btConvexInternalAabbCachingShape_getContactBreakingThreshold(_Underlying *_this, double defaultContactThresholdFactor);
            return __btConvexInternalAabbCachingShape_getContactBreakingThreshold(_UnderlyingPtr, defaultContactThresholdFactor);
        }

        ///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
        ///result is conservative
        /// Generated from method `btConvexInternalAabbCachingShape::calculateTemporalAabb`.
        public unsafe void CalculateTemporalAabb(Bullet.Const_BtTransform curTrans, Bullet.Const_BtVector3 linvel, Bullet.Const_BtVector3 angvel, double timeStep, Bullet.BtVector3 temporalAabbMin, Bullet.BtVector3 temporalAabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_calculateTemporalAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *curTrans, Bullet.Const_BtVector3._Underlying *linvel, Bullet.Const_BtVector3._Underlying *angvel, double timeStep, Bullet.BtVector3._Underlying *temporalAabbMin, Bullet.BtVector3._Underlying *temporalAabbMax);
            __btConvexInternalAabbCachingShape_calculateTemporalAabb(_UnderlyingPtr, curTrans._UnderlyingPtr, linvel._UnderlyingPtr, angvel._UnderlyingPtr, timeStep, temporalAabbMin._UnderlyingPtr, temporalAabbMax._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::isPolyhedral`.
        public unsafe bool IsPolyhedral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalAabbCachingShape_isPolyhedral(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_isPolyhedral(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalAabbCachingShape::isConvex2d`.
        public unsafe bool IsConvex2d()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalAabbCachingShape_isConvex2d(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_isConvex2d(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalAabbCachingShape::isConvex`.
        public unsafe bool IsConvex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalAabbCachingShape_isConvex(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_isConvex(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalAabbCachingShape::isNonMoving`.
        public unsafe bool IsNonMoving()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalAabbCachingShape_isNonMoving(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_isNonMoving(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalAabbCachingShape::isConcave`.
        public unsafe bool IsConcave()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalAabbCachingShape_isConcave(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_isConcave(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalAabbCachingShape::isCompound`.
        public unsafe bool IsCompound()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalAabbCachingShape_isCompound(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_isCompound(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalAabbCachingShape::isSoftBody`.
        public unsafe bool IsSoftBody()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalAabbCachingShape_isSoftBody(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_isSoftBody(_UnderlyingPtr) != 0;
        }

        ///isInfinite is used to catch simulation error (aabb check)
        /// Generated from method `btConvexInternalAabbCachingShape::isInfinite`.
        public unsafe bool IsInfinite()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btConvexInternalAabbCachingShape_isInfinite(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_isInfinite(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btConvexInternalAabbCachingShape::calculateLocalInertia`.
        public unsafe void CalculateLocalInertia(double mass, Bullet.BtVector3 inertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_calculateLocalInertia(_Underlying *_this, double mass, Bullet.BtVector3._Underlying *inertia);
            __btConvexInternalAabbCachingShape_calculateLocalInertia(_UnderlyingPtr, mass, inertia._UnderlyingPtr);
        }

        //debugging support
        /// Generated from method `btConvexInternalAabbCachingShape::getName`.
        public unsafe byte? GetName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__btConvexInternalAabbCachingShape_getName(_Underlying *_this);
            var __c_ret = __btConvexInternalAabbCachingShape_getName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getShapeType`.
        public unsafe int GetShapeType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalAabbCachingShape_getShapeType(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_getShapeType(_UnderlyingPtr);
        }

        ///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
        ///See Bullet/Demos/RollingFrictionDemo for an example
        /// Generated from method `btConvexInternalAabbCachingShape::getAnisotropicRollingFrictionDirection`.
        public unsafe Bullet.BtVector3 GetAnisotropicRollingFrictionDirection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btConvexInternalAabbCachingShape_getAnisotropicRollingFrictionDirection(_Underlying *_this);
            return new(__btConvexInternalAabbCachingShape_getAnisotropicRollingFrictionDirection(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btConvexInternalAabbCachingShape_getUserPointer(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalAabbCachingShape_getUserIndex(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btConvexInternalAabbCachingShape_getUserIndex2(_Underlying *_this);
            return __btConvexInternalAabbCachingShape_getUserIndex2(_UnderlyingPtr);
        }
    }

    ///btConvexInternalAabbCachingShape adds local aabb caching for convex shapes, to avoid expensive bounding box calculations
    /// Generated from class `btConvexInternalAabbCachingShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexInternalShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    /// This is the non-const half of the class.
    public class BtConvexInternalAabbCachingShape : Const_BtConvexInternalAabbCachingShape
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionShape(BtConvexInternalAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionShape._Underlying *__btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.BtCollisionShape ret = new(__btConvexInternalAabbCachingShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexShape(BtConvexInternalAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexShape._Underlying *__btConvexInternalAabbCachingShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.BtConvexShape ret = new(__btConvexInternalAabbCachingShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexInternalShape(BtConvexInternalAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexInternalShape._Underlying *__btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.BtConvexInternalShape ret = new(__btConvexInternalAabbCachingShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtConvexInternalAabbCachingShape?(Bullet.BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape(Bullet.BtCollisionShape._Underlying *_this);
            var ptr = __btConvexInternalAabbCachingShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtConvexInternalAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtConvexInternalAabbCachingShape?(Bullet.BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape(Bullet.BtConvexShape._Underlying *_this);
            var ptr = __btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtConvexInternalAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtConvexInternalAabbCachingShape?(Bullet.BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.BtConvexInternalShape._Underlying *_this);
            var ptr = __btConvexInternalAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtConvexInternalAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtConvexInternalAabbCachingShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from method `btConvexInternalAabbCachingShape::setLocalScaling`.
        public unsafe void SetLocalScaling(Bullet.Const_BtVector3 scaling)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_setLocalScaling(_Underlying *_this, Bullet.Const_BtVector3._Underlying *scaling);
            __btConvexInternalAabbCachingShape_setLocalScaling(_UnderlyingPtr, scaling._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::recalcLocalAabb`.
        public unsafe void RecalcLocalAabb()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_recalcLocalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_recalcLocalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_recalcLocalAabb(_Underlying *_this);
            __btConvexInternalAabbCachingShape_recalcLocalAabb(_UnderlyingPtr);
        }

        ///warning: use setImplicitShapeDimensions with care
        ///changing a collision shape while the body is in the world is not recommended,
        ///it is best to remove the body from the world, then make the change, and re-add it
        ///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
        /// Generated from method `btConvexInternalAabbCachingShape::setImplicitShapeDimensions`.
        public unsafe void SetImplicitShapeDimensions(Bullet.Const_BtVector3 dimensions)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_setImplicitShapeDimensions(_Underlying *_this, Bullet.Const_BtVector3._Underlying *dimensions);
            __btConvexInternalAabbCachingShape_setImplicitShapeDimensions(_UnderlyingPtr, dimensions._UnderlyingPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::setMargin`.
        public unsafe void SetMargin(double margin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_setMargin(_Underlying *_this, double margin);
            __btConvexInternalAabbCachingShape_setMargin(_UnderlyingPtr, margin);
        }

        ///optional user data pointer
        /// Generated from method `btConvexInternalAabbCachingShape::setUserPointer`.
        /// Parameter `userPtr` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPtr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_setUserPointer(_Underlying *_this, void *userPtr);
            __btConvexInternalAabbCachingShape_setUserPointer(_UnderlyingPtr, userPtr);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_setUserIndex(_Underlying *_this, int index);
            __btConvexInternalAabbCachingShape_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btConvexInternalAabbCachingShape::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btConvexInternalAabbCachingShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btConvexInternalAabbCachingShape_setUserIndex2(_Underlying *_this, int index);
            __btConvexInternalAabbCachingShape_setUserIndex2(_UnderlyingPtr, index);
        }
    }

    /// This is used for optional parameters of class `BtConvexInternalAabbCachingShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtConvexInternalAabbCachingShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtConvexInternalAabbCachingShape`/`Const_BtConvexInternalAabbCachingShape` directly.
    public class _InOptMut_BtConvexInternalAabbCachingShape
    {
        public BtConvexInternalAabbCachingShape? Opt;

        public _InOptMut_BtConvexInternalAabbCachingShape() {}
        public _InOptMut_BtConvexInternalAabbCachingShape(BtConvexInternalAabbCachingShape value) {Opt = value;}
        public static implicit operator _InOptMut_BtConvexInternalAabbCachingShape(BtConvexInternalAabbCachingShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtConvexInternalAabbCachingShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtConvexInternalAabbCachingShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtConvexInternalAabbCachingShape`/`Const_BtConvexInternalAabbCachingShape` to pass it to the function.
    public class _InOptConst_BtConvexInternalAabbCachingShape
    {
        public Const_BtConvexInternalAabbCachingShape? Opt;

        public _InOptConst_BtConvexInternalAabbCachingShape() {}
        public _InOptConst_BtConvexInternalAabbCachingShape(Const_BtConvexInternalAabbCachingShape value) {Opt = value;}
        public static implicit operator _InOptConst_BtConvexInternalAabbCachingShape(Const_BtConvexInternalAabbCachingShape value) {return new(value);}
    }
}
