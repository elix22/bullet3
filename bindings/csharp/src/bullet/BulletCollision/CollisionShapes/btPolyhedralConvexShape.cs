// machine generated, do not edit
public static partial class Bullet
{
    ///The btPolyhedralConvexShape is an internal interface class for polyhedral convex shapes.
    /// Generated from class `btPolyhedralConvexShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexInternalShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btBoxShape`
    ///     `btPolyhedralConvexAabbCachingShape`
    /// This is the const half of the class.
    public class Const_BtPolyhedralConvexShape : Bullet.Object<Const_BtPolyhedralConvexShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_Destroy(_Underlying *_this);
            __btPolyhedralConvexShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtPolyhedralConvexShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionShape(Const_BtPolyhedralConvexShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionShape._Underlying *__btPolyhedralConvexShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.Const_BtCollisionShape ret = new(__btPolyhedralConvexShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexShape(Const_BtPolyhedralConvexShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexShape._Underlying *__btPolyhedralConvexShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.Const_BtConvexShape ret = new(__btPolyhedralConvexShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexInternalShape(Const_BtPolyhedralConvexShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexInternalShape._Underlying *__btPolyhedralConvexShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.Const_BtConvexInternalShape ret = new(__btPolyhedralConvexShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtPolyhedralConvexShape?(Bullet.Const_BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape(Bullet.Const_BtCollisionShape._Underlying *_this);
            var ptr = __btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtPolyhedralConvexShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtPolyhedralConvexShape?(Bullet.Const_BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape(Bullet.Const_BtConvexShape._Underlying *_this);
            var ptr = __btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtPolyhedralConvexShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtPolyhedralConvexShape?(Bullet.Const_BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.Const_BtConvexInternalShape._Underlying *_this);
            var ptr = __btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtPolyhedralConvexShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtPolyhedralConvexShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btPolyhedralConvexShape::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btPolyhedralConvexShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btPolyhedralConvexShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btPolyhedralConvexShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btPolyhedralConvexShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btPolyhedralConvexShape::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btPolyhedralConvexShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btPolyhedralConvexShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btPolyhedralConvexShape_void_ptr(void *ptr);
            __Bullet_delete_btPolyhedralConvexShape_void_ptr(ptr);
        }

        /// Generated from method `btPolyhedralConvexShape::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btPolyhedralConvexShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btPolyhedralConvexShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btPolyhedralConvexShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btPolyhedralConvexShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btPolyhedralConvexShape::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btPolyhedralConvexShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btPolyhedralConvexShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btPolyhedralConvexShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btPolyhedralConvexShape_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btPolyhedralConvexShape::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btPolyhedralConvexShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btPolyhedralConvexShape_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btPolyhedralConvexShape_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btPolyhedralConvexShape_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btPolyhedralConvexShape::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btPolyhedralConvexShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btPolyhedralConvexShape_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btPolyhedralConvexShape_void_ptr(void *ptr);
            __Bullet_delete_array_btPolyhedralConvexShape_void_ptr(ptr);
        }

        /// Generated from method `btPolyhedralConvexShape::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btPolyhedralConvexShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btPolyhedralConvexShape_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btPolyhedralConvexShape_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btPolyhedralConvexShape_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btPolyhedralConvexShape::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btPolyhedralConvexShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btPolyhedralConvexShape_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btPolyhedralConvexShape_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btPolyhedralConvexShape_void_ptr_void_ptr(_1, _2);
        }

        //brute force implementations
        /// Generated from method `btPolyhedralConvexShape::localGetSupportingVertexWithoutMargin`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexShape_localGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btPolyhedralConvexShape_localGetSupportingVertexWithoutMargin(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
        public unsafe void BatchedUnitVectorGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3? vectors, Bullet.BtVector3? supportVerticesOut, int numVectors)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vectors, Bullet.BtVector3._Underlying *supportVerticesOut, int numVectors);
            __btPolyhedralConvexShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_UnderlyingPtr, vectors is not null ? vectors._UnderlyingPtr : null, supportVerticesOut is not null ? supportVerticesOut._UnderlyingPtr : null, numVectors);
        }

        /// Generated from method `btPolyhedralConvexShape::calculateLocalInertia`.
        public unsafe void CalculateLocalInertia(double mass, Bullet.BtVector3 inertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_calculateLocalInertia(_Underlying *_this, double mass, Bullet.BtVector3._Underlying *inertia);
            __btPolyhedralConvexShape_calculateLocalInertia(_UnderlyingPtr, mass, inertia._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getNumVertices`.
        public unsafe int GetNumVertices()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getNumVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getNumVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexShape_getNumVertices(_Underlying *_this);
            return __btPolyhedralConvexShape_getNumVertices(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getNumEdges`.
        public unsafe int GetNumEdges()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getNumEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getNumEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexShape_getNumEdges(_Underlying *_this);
            return __btPolyhedralConvexShape_getNumEdges(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getEdge`.
        public unsafe void GetEdge(int i, Bullet.BtVector3 pa, Bullet.BtVector3 pb)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getEdge", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getEdge", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_getEdge(_Underlying *_this, int i, Bullet.BtVector3._Underlying *pa, Bullet.BtVector3._Underlying *pb);
            __btPolyhedralConvexShape_getEdge(_UnderlyingPtr, i, pa._UnderlyingPtr, pb._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getVertex`.
        public unsafe void GetVertex(int i, Bullet.BtVector3 vtx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_getVertex(_Underlying *_this, int i, Bullet.BtVector3._Underlying *vtx);
            __btPolyhedralConvexShape_getVertex(_UnderlyingPtr, i, vtx._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getNumPlanes`.
        public unsafe int GetNumPlanes()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getNumPlanes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getNumPlanes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexShape_getNumPlanes(_Underlying *_this);
            return __btPolyhedralConvexShape_getNumPlanes(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getPlane`.
        public unsafe void GetPlane(Bullet.BtVector3 planeNormal, Bullet.BtVector3 planeSupport, int i)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_getPlane(_Underlying *_this, Bullet.BtVector3._Underlying *planeNormal, Bullet.BtVector3._Underlying *planeSupport, int i);
            __btPolyhedralConvexShape_getPlane(_UnderlyingPtr, planeNormal._UnderlyingPtr, planeSupport._UnderlyingPtr, i);
        }

        //	virtual int getIndex(int i) const = 0 ;
        /// Generated from method `btPolyhedralConvexShape::isInside`.
        public unsafe bool IsInside(Bullet.Const_BtVector3 pt, double tolerance)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_isInside", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_isInside", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_isInside(_Underlying *_this, Bullet.Const_BtVector3._Underlying *pt, double tolerance);
            return __btPolyhedralConvexShape_isInside(_UnderlyingPtr, pt._UnderlyingPtr, tolerance) != 0;
        }

        /// Generated from method `btPolyhedralConvexShape::localGetSupportingVertex`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertex(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexShape_localGetSupportingVertex(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btPolyhedralConvexShape_localGetSupportingVertex(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexShape::getImplicitShapeDimensions`.
        public unsafe Bullet.Const_BtVector3 GetImplicitShapeDimensions()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btPolyhedralConvexShape_getImplicitShapeDimensions(_Underlying *_this);
            return new(__btPolyhedralConvexShape_getImplicitShapeDimensions(_UnderlyingPtr), is_owning: false);
        }

        ///getAabb's default implementation is brute force, expected derived classes to implement a fast dedicated version
        /// Generated from method `btPolyhedralConvexShape::getAabb`.
        public unsafe void GetAabb(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_getAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btPolyhedralConvexShape_getAabb(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getAabbSlow`.
        public unsafe void GetAabbSlow(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_getAabbSlow(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btPolyhedralConvexShape_getAabbSlow(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getLocalScaling`.
        public unsafe Bullet.Const_BtVector3 GetLocalScaling()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btPolyhedralConvexShape_getLocalScaling(_Underlying *_this);
            return new(__btPolyhedralConvexShape_getLocalScaling(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btPolyhedralConvexShape::getLocalScalingNV`.
        public unsafe Bullet.Const_BtVector3 GetLocalScalingNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btPolyhedralConvexShape_getLocalScalingNV(_Underlying *_this);
            return new(__btPolyhedralConvexShape_getLocalScalingNV(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btPolyhedralConvexShape::getMargin`.
        public unsafe double GetMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexShape_getMargin(_Underlying *_this);
            return __btPolyhedralConvexShape_getMargin(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getMarginNV`.
        public unsafe double GetMarginNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexShape_getMarginNV(_Underlying *_this);
            return __btPolyhedralConvexShape_getMarginNV(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getNumPreferredPenetrationDirections`.
        public unsafe int GetNumPreferredPenetrationDirections()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexShape_getNumPreferredPenetrationDirections(_Underlying *_this);
            return __btPolyhedralConvexShape_getNumPreferredPenetrationDirections(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getPreferredPenetrationDirection`.
        public unsafe void GetPreferredPenetrationDirection(int index, Bullet.BtVector3 penetrationVector)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_getPreferredPenetrationDirection(_Underlying *_this, int index, Bullet.BtVector3._Underlying *penetrationVector);
            __btPolyhedralConvexShape_getPreferredPenetrationDirection(_UnderlyingPtr, index, penetrationVector._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexShape_calculateSerializeBufferSize(_Underlying *_this);
            return __btPolyhedralConvexShape_calculateSerializeBufferSize(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::localGetSupportVertexWithoutMarginNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexWithoutMarginNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexShape_localGetSupportVertexWithoutMarginNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btPolyhedralConvexShape_localGetSupportVertexWithoutMarginNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexShape::localGetSupportVertexNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexShape_localGetSupportVertexNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btPolyhedralConvexShape_localGetSupportVertexNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexShape::getMarginNonVirtual`.
        public unsafe double GetMarginNonVirtual()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexShape_getMarginNonVirtual(_Underlying *_this);
            return __btPolyhedralConvexShape_getMarginNonVirtual(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getAabbNonVirtual`.
        public unsafe void GetAabbNonVirtual(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_getAabbNonVirtual(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btPolyhedralConvexShape_getAabbNonVirtual(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::project`.
        public unsafe void Project(Bullet.Const_BtTransform trans, Bullet.Const_BtVector3 dir, ref double minProj, ref double maxProj, Bullet.BtVector3 witnesPtMin, Bullet.BtVector3 witnesPtMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_project(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans, Bullet.Const_BtVector3._Underlying *dir, double *minProj, double *maxProj, Bullet.BtVector3._Underlying *witnesPtMin, Bullet.BtVector3._Underlying *witnesPtMax);
            fixed (double *__ptr_minProj = &minProj)
            {
                fixed (double *__ptr_maxProj = &maxProj)
                {
                    __btPolyhedralConvexShape_project(_UnderlyingPtr, trans._UnderlyingPtr, dir._UnderlyingPtr, __ptr_minProj, __ptr_maxProj, witnesPtMin._UnderlyingPtr, witnesPtMax._UnderlyingPtr);
                }
            }
        }

        /// Generated from method `btPolyhedralConvexShape::getBoundingSphere`.
        public unsafe void GetBoundingSphere(Bullet.BtVector3 center, ref double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_getBoundingSphere(_Underlying *_this, Bullet.BtVector3._Underlying *center, double *radius);
            fixed (double *__ptr_radius = &radius)
            {
                __btPolyhedralConvexShape_getBoundingSphere(_UnderlyingPtr, center._UnderlyingPtr, __ptr_radius);
            }
        }

        ///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
        /// Generated from method `btPolyhedralConvexShape::getAngularMotionDisc`.
        public unsafe double GetAngularMotionDisc()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexShape_getAngularMotionDisc(_Underlying *_this);
            return __btPolyhedralConvexShape_getAngularMotionDisc(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getContactBreakingThreshold`.
        public unsafe double GetContactBreakingThreshold(double defaultContactThresholdFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexShape_getContactBreakingThreshold(_Underlying *_this, double defaultContactThresholdFactor);
            return __btPolyhedralConvexShape_getContactBreakingThreshold(_UnderlyingPtr, defaultContactThresholdFactor);
        }

        ///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
        ///result is conservative
        /// Generated from method `btPolyhedralConvexShape::calculateTemporalAabb`.
        public unsafe void CalculateTemporalAabb(Bullet.Const_BtTransform curTrans, Bullet.Const_BtVector3 linvel, Bullet.Const_BtVector3 angvel, double timeStep, Bullet.BtVector3 temporalAabbMin, Bullet.BtVector3 temporalAabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_calculateTemporalAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *curTrans, Bullet.Const_BtVector3._Underlying *linvel, Bullet.Const_BtVector3._Underlying *angvel, double timeStep, Bullet.BtVector3._Underlying *temporalAabbMin, Bullet.BtVector3._Underlying *temporalAabbMax);
            __btPolyhedralConvexShape_calculateTemporalAabb(_UnderlyingPtr, curTrans._UnderlyingPtr, linvel._UnderlyingPtr, angvel._UnderlyingPtr, timeStep, temporalAabbMin._UnderlyingPtr, temporalAabbMax._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::isPolyhedral`.
        public unsafe bool IsPolyhedral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_isPolyhedral(_Underlying *_this);
            return __btPolyhedralConvexShape_isPolyhedral(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexShape::isConvex2d`.
        public unsafe bool IsConvex2d()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_isConvex2d(_Underlying *_this);
            return __btPolyhedralConvexShape_isConvex2d(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexShape::isConvex`.
        public unsafe bool IsConvex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_isConvex(_Underlying *_this);
            return __btPolyhedralConvexShape_isConvex(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexShape::isNonMoving`.
        public unsafe bool IsNonMoving()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_isNonMoving(_Underlying *_this);
            return __btPolyhedralConvexShape_isNonMoving(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexShape::isConcave`.
        public unsafe bool IsConcave()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_isConcave(_Underlying *_this);
            return __btPolyhedralConvexShape_isConcave(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexShape::isCompound`.
        public unsafe bool IsCompound()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_isCompound(_Underlying *_this);
            return __btPolyhedralConvexShape_isCompound(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexShape::isSoftBody`.
        public unsafe bool IsSoftBody()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_isSoftBody(_Underlying *_this);
            return __btPolyhedralConvexShape_isSoftBody(_UnderlyingPtr) != 0;
        }

        ///isInfinite is used to catch simulation error (aabb check)
        /// Generated from method `btPolyhedralConvexShape::isInfinite`.
        public unsafe bool IsInfinite()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_isInfinite(_Underlying *_this);
            return __btPolyhedralConvexShape_isInfinite(_UnderlyingPtr) != 0;
        }

        //debugging support
        /// Generated from method `btPolyhedralConvexShape::getName`.
        public unsafe byte? GetName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__btPolyhedralConvexShape_getName(_Underlying *_this);
            var __c_ret = __btPolyhedralConvexShape_getName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btPolyhedralConvexShape::getShapeType`.
        public unsafe int GetShapeType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexShape_getShapeType(_Underlying *_this);
            return __btPolyhedralConvexShape_getShapeType(_UnderlyingPtr);
        }

        ///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
        ///See Bullet/Demos/RollingFrictionDemo for an example
        /// Generated from method `btPolyhedralConvexShape::getAnisotropicRollingFrictionDirection`.
        public unsafe Bullet.BtVector3 GetAnisotropicRollingFrictionDirection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexShape_getAnisotropicRollingFrictionDirection(_Underlying *_this);
            return new(__btPolyhedralConvexShape_getAnisotropicRollingFrictionDirection(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexShape::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btPolyhedralConvexShape_getUserPointer(_Underlying *_this);
            return __btPolyhedralConvexShape_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexShape_getUserIndex(_Underlying *_this);
            return __btPolyhedralConvexShape_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexShape_getUserIndex2(_Underlying *_this);
            return __btPolyhedralConvexShape_getUserIndex2(_UnderlyingPtr);
        }
    }

    ///The btPolyhedralConvexShape is an internal interface class for polyhedral convex shapes.
    /// Generated from class `btPolyhedralConvexShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btConvexInternalShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btBoxShape`
    ///     `btPolyhedralConvexAabbCachingShape`
    /// This is the non-const half of the class.
    public class BtPolyhedralConvexShape : Const_BtPolyhedralConvexShape
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionShape(BtPolyhedralConvexShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionShape._Underlying *__btPolyhedralConvexShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.BtCollisionShape ret = new(__btPolyhedralConvexShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexShape(BtPolyhedralConvexShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexShape._Underlying *__btPolyhedralConvexShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.BtConvexShape ret = new(__btPolyhedralConvexShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexInternalShape(BtPolyhedralConvexShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexInternalShape._Underlying *__btPolyhedralConvexShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.BtConvexInternalShape ret = new(__btPolyhedralConvexShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtPolyhedralConvexShape?(Bullet.BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape(Bullet.BtCollisionShape._Underlying *_this);
            var ptr = __btPolyhedralConvexShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtPolyhedralConvexShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtPolyhedralConvexShape?(Bullet.BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape(Bullet.BtConvexShape._Underlying *_this);
            var ptr = __btPolyhedralConvexShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtPolyhedralConvexShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtPolyhedralConvexShape?(Bullet.BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.BtConvexInternalShape._Underlying *_this);
            var ptr = __btPolyhedralConvexShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtPolyhedralConvexShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtPolyhedralConvexShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        ///optional method mainly used to generate multiple contact points by clipping polyhedral features (faces/edges)
        ///experimental/work-in-progress
        /// Generated from method `btPolyhedralConvexShape::initializePolyhedralFeatures`.
        /// Parameter `shiftVerticesByMargin` defaults to `0`.
        public unsafe bool InitializePolyhedralFeatures(int? shiftVerticesByMargin = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_initializePolyhedralFeatures", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_initializePolyhedralFeatures", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexShape_initializePolyhedralFeatures(_Underlying *_this, int *shiftVerticesByMargin);
            int __deref_shiftVerticesByMargin = shiftVerticesByMargin.GetValueOrDefault();
            return __btPolyhedralConvexShape_initializePolyhedralFeatures(_UnderlyingPtr, shiftVerticesByMargin.HasValue ? &__deref_shiftVerticesByMargin : null) != 0;
        }

        ///warning: use setImplicitShapeDimensions with care
        ///changing a collision shape while the body is in the world is not recommended,
        ///it is best to remove the body from the world, then make the change, and re-add it
        ///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
        /// Generated from method `btPolyhedralConvexShape::setImplicitShapeDimensions`.
        public unsafe void SetImplicitShapeDimensions(Bullet.Const_BtVector3 dimensions)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_setImplicitShapeDimensions(_Underlying *_this, Bullet.Const_BtVector3._Underlying *dimensions);
            __btPolyhedralConvexShape_setImplicitShapeDimensions(_UnderlyingPtr, dimensions._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::setLocalScaling`.
        public unsafe void SetLocalScaling(Bullet.Const_BtVector3 scaling)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_setLocalScaling(_Underlying *_this, Bullet.Const_BtVector3._Underlying *scaling);
            __btPolyhedralConvexShape_setLocalScaling(_UnderlyingPtr, scaling._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::setMargin`.
        public unsafe void SetMargin(double margin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_setMargin(_Underlying *_this, double margin);
            __btPolyhedralConvexShape_setMargin(_UnderlyingPtr, margin);
        }

        ///optional user data pointer
        /// Generated from method `btPolyhedralConvexShape::setUserPointer`.
        /// Parameter `userPtr` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPtr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_setUserPointer(_Underlying *_this, void *userPtr);
            __btPolyhedralConvexShape_setUserPointer(_UnderlyingPtr, userPtr);
        }

        /// Generated from method `btPolyhedralConvexShape::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_setUserIndex(_Underlying *_this, int index);
            __btPolyhedralConvexShape_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btPolyhedralConvexShape::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexShape_setUserIndex2(_Underlying *_this, int index);
            __btPolyhedralConvexShape_setUserIndex2(_UnderlyingPtr, index);
        }
    }

    /// This is used for optional parameters of class `BtPolyhedralConvexShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtPolyhedralConvexShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtPolyhedralConvexShape`/`Const_BtPolyhedralConvexShape` directly.
    public class _InOptMut_BtPolyhedralConvexShape
    {
        public BtPolyhedralConvexShape? Opt;

        public _InOptMut_BtPolyhedralConvexShape() {}
        public _InOptMut_BtPolyhedralConvexShape(BtPolyhedralConvexShape value) {Opt = value;}
        public static implicit operator _InOptMut_BtPolyhedralConvexShape(BtPolyhedralConvexShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtPolyhedralConvexShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtPolyhedralConvexShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtPolyhedralConvexShape`/`Const_BtPolyhedralConvexShape` to pass it to the function.
    public class _InOptConst_BtPolyhedralConvexShape
    {
        public Const_BtPolyhedralConvexShape? Opt;

        public _InOptConst_BtPolyhedralConvexShape() {}
        public _InOptConst_BtPolyhedralConvexShape(Const_BtPolyhedralConvexShape value) {Opt = value;}
        public static implicit operator _InOptConst_BtPolyhedralConvexShape(Const_BtPolyhedralConvexShape value) {return new(value);}
    }

    ///The btPolyhedralConvexAabbCachingShape adds aabb caching to the btPolyhedralConvexShape
    /// Generated from class `btPolyhedralConvexAabbCachingShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btPolyhedralConvexShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    ///     `btConvexInternalShape`
    /// This is the const half of the class.
    public class Const_BtPolyhedralConvexAabbCachingShape : Bullet.Object<Const_BtPolyhedralConvexAabbCachingShape>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_Destroy(_Underlying *_this);
            __btPolyhedralConvexAabbCachingShape_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtPolyhedralConvexAabbCachingShape() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionShape(Const_BtPolyhedralConvexAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionShape._Underlying *__btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.Const_BtCollisionShape ret = new(__btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexShape(Const_BtPolyhedralConvexAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexShape._Underlying *__btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.Const_BtConvexShape ret = new(__btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtConvexInternalShape(Const_BtPolyhedralConvexAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtConvexInternalShape._Underlying *__btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.Const_BtConvexInternalShape ret = new(__btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtPolyhedralConvexShape(Const_BtPolyhedralConvexAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtPolyhedralConvexShape._Underlying *__btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape(_Underlying *_this);
            Bullet.Const_BtPolyhedralConvexShape ret = new(__btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtPolyhedralConvexAabbCachingShape?(Bullet.Const_BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape(Bullet.Const_BtCollisionShape._Underlying *_this);
            var ptr = __btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtPolyhedralConvexAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtPolyhedralConvexAabbCachingShape?(Bullet.Const_BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape(Bullet.Const_BtConvexShape._Underlying *_this);
            var ptr = __btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtPolyhedralConvexAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtPolyhedralConvexAabbCachingShape?(Bullet.Const_BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.Const_BtConvexInternalShape._Underlying *_this);
            var ptr = __btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtPolyhedralConvexAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtPolyhedralConvexAabbCachingShape?(Bullet.Const_BtPolyhedralConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape(Bullet.Const_BtPolyhedralConvexShape._Underlying *_this);
            var ptr = __btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtPolyhedralConvexAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtPolyhedralConvexAabbCachingShape(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getNonvirtualAabb`.
        public unsafe void GetNonvirtualAabb(Bullet.Const_BtTransform trans, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax, double margin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNonvirtualAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNonvirtualAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_getNonvirtualAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax, double margin);
            __btPolyhedralConvexAabbCachingShape_getNonvirtualAabb(_UnderlyingPtr, trans._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr, margin);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getAabb`.
        public unsafe void GetAabb(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_getAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btPolyhedralConvexAabbCachingShape_getAabb(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        //brute force implementations
        /// Generated from method `btPolyhedralConvexAabbCachingShape::localGetSupportingVertexWithoutMargin`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_localGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexAabbCachingShape_localGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btPolyhedralConvexAabbCachingShape_localGetSupportingVertexWithoutMargin(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::batchedUnitVectorGetSupportingVertexWithoutMargin`.
        public unsafe void BatchedUnitVectorGetSupportingVertexWithoutMargin(Bullet.Const_BtVector3? vectors, Bullet.BtVector3? supportVerticesOut, int numVectors)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vectors, Bullet.BtVector3._Underlying *supportVerticesOut, int numVectors);
            __btPolyhedralConvexAabbCachingShape_batchedUnitVectorGetSupportingVertexWithoutMargin(_UnderlyingPtr, vectors is not null ? vectors._UnderlyingPtr : null, supportVerticesOut is not null ? supportVerticesOut._UnderlyingPtr : null, numVectors);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::calculateLocalInertia`.
        public unsafe void CalculateLocalInertia(double mass, Bullet.BtVector3 inertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_calculateLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_calculateLocalInertia(_Underlying *_this, double mass, Bullet.BtVector3._Underlying *inertia);
            __btPolyhedralConvexAabbCachingShape_calculateLocalInertia(_UnderlyingPtr, mass, inertia._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getNumVertices`.
        public unsafe int GetNumVertices()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNumVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNumVertices", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexAabbCachingShape_getNumVertices(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getNumVertices(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getNumEdges`.
        public unsafe int GetNumEdges()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNumEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNumEdges", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexAabbCachingShape_getNumEdges(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getNumEdges(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getEdge`.
        public unsafe void GetEdge(int i, Bullet.BtVector3 pa, Bullet.BtVector3 pb)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getEdge", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getEdge", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_getEdge(_Underlying *_this, int i, Bullet.BtVector3._Underlying *pa, Bullet.BtVector3._Underlying *pb);
            __btPolyhedralConvexAabbCachingShape_getEdge(_UnderlyingPtr, i, pa._UnderlyingPtr, pb._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getVertex`.
        public unsafe void GetVertex(int i, Bullet.BtVector3 vtx)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_getVertex(_Underlying *_this, int i, Bullet.BtVector3._Underlying *vtx);
            __btPolyhedralConvexAabbCachingShape_getVertex(_UnderlyingPtr, i, vtx._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getNumPlanes`.
        public unsafe int GetNumPlanes()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNumPlanes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNumPlanes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexAabbCachingShape_getNumPlanes(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getNumPlanes(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getPlane`.
        public unsafe void GetPlane(Bullet.BtVector3 planeNormal, Bullet.BtVector3 planeSupport, int i)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getPlane", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_getPlane(_Underlying *_this, Bullet.BtVector3._Underlying *planeNormal, Bullet.BtVector3._Underlying *planeSupport, int i);
            __btPolyhedralConvexAabbCachingShape_getPlane(_UnderlyingPtr, planeNormal._UnderlyingPtr, planeSupport._UnderlyingPtr, i);
        }

        //	virtual int getIndex(int i) const = 0 ;
        /// Generated from method `btPolyhedralConvexAabbCachingShape::isInside`.
        public unsafe bool IsInside(Bullet.Const_BtVector3 pt, double tolerance)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isInside", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isInside", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_isInside(_Underlying *_this, Bullet.Const_BtVector3._Underlying *pt, double tolerance);
            return __btPolyhedralConvexAabbCachingShape_isInside(_UnderlyingPtr, pt._UnderlyingPtr, tolerance) != 0;
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::localGetSupportingVertex`.
        public unsafe Bullet.BtVector3 LocalGetSupportingVertex(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_localGetSupportingVertex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexAabbCachingShape_localGetSupportingVertex(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btPolyhedralConvexAabbCachingShape_localGetSupportingVertex(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getImplicitShapeDimensions`.
        public unsafe Bullet.Const_BtVector3 GetImplicitShapeDimensions()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btPolyhedralConvexAabbCachingShape_getImplicitShapeDimensions(_Underlying *_this);
            return new(__btPolyhedralConvexAabbCachingShape_getImplicitShapeDimensions(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getAabbSlow`.
        public unsafe void GetAabbSlow(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAabbSlow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_getAabbSlow(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btPolyhedralConvexAabbCachingShape_getAabbSlow(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getLocalScaling`.
        public unsafe Bullet.Const_BtVector3 GetLocalScaling()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btPolyhedralConvexAabbCachingShape_getLocalScaling(_Underlying *_this);
            return new(__btPolyhedralConvexAabbCachingShape_getLocalScaling(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getLocalScalingNV`.
        public unsafe Bullet.Const_BtVector3 GetLocalScalingNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getLocalScalingNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btPolyhedralConvexAabbCachingShape_getLocalScalingNV(_Underlying *_this);
            return new(__btPolyhedralConvexAabbCachingShape_getLocalScalingNV(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getMargin`.
        public unsafe double GetMargin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexAabbCachingShape_getMargin(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getMargin(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getMarginNV`.
        public unsafe double GetMarginNV()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getMarginNV", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexAabbCachingShape_getMarginNV(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getMarginNV(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getNumPreferredPenetrationDirections`.
        public unsafe int GetNumPreferredPenetrationDirections()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getNumPreferredPenetrationDirections", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexAabbCachingShape_getNumPreferredPenetrationDirections(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getNumPreferredPenetrationDirections(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getPreferredPenetrationDirection`.
        public unsafe void GetPreferredPenetrationDirection(int index, Bullet.BtVector3 penetrationVector)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getPreferredPenetrationDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_getPreferredPenetrationDirection(_Underlying *_this, int index, Bullet.BtVector3._Underlying *penetrationVector);
            __btPolyhedralConvexAabbCachingShape_getPreferredPenetrationDirection(_UnderlyingPtr, index, penetrationVector._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexAabbCachingShape_calculateSerializeBufferSize(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_calculateSerializeBufferSize(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::localGetSupportVertexWithoutMarginNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexWithoutMarginNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btPolyhedralConvexAabbCachingShape_localGetSupportVertexWithoutMarginNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::localGetSupportVertexNonVirtual`.
        public unsafe Bullet.BtVector3 LocalGetSupportVertexNonVirtual(Bullet.Const_BtVector3 vec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_localGetSupportVertexNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexAabbCachingShape_localGetSupportVertexNonVirtual(_Underlying *_this, Bullet.Const_BtVector3._Underlying *vec);
            return new(__btPolyhedralConvexAabbCachingShape_localGetSupportVertexNonVirtual(_UnderlyingPtr, vec._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getMarginNonVirtual`.
        public unsafe double GetMarginNonVirtual()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getMarginNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexAabbCachingShape_getMarginNonVirtual(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getMarginNonVirtual(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getAabbNonVirtual`.
        public unsafe void GetAabbNonVirtual(Bullet.Const_BtTransform t, Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAabbNonVirtual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_getAabbNonVirtual(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btPolyhedralConvexAabbCachingShape_getAabbNonVirtual(_UnderlyingPtr, t._UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::project`.
        public unsafe void Project(Bullet.Const_BtTransform trans, Bullet.Const_BtVector3 dir, ref double minProj, ref double maxProj, Bullet.BtVector3 witnesPtMin, Bullet.BtVector3 witnesPtMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_project", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_project(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans, Bullet.Const_BtVector3._Underlying *dir, double *minProj, double *maxProj, Bullet.BtVector3._Underlying *witnesPtMin, Bullet.BtVector3._Underlying *witnesPtMax);
            fixed (double *__ptr_minProj = &minProj)
            {
                fixed (double *__ptr_maxProj = &maxProj)
                {
                    __btPolyhedralConvexAabbCachingShape_project(_UnderlyingPtr, trans._UnderlyingPtr, dir._UnderlyingPtr, __ptr_minProj, __ptr_maxProj, witnesPtMin._UnderlyingPtr, witnesPtMax._UnderlyingPtr);
                }
            }
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getBoundingSphere`.
        public unsafe void GetBoundingSphere(Bullet.BtVector3 center, ref double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getBoundingSphere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_getBoundingSphere(_Underlying *_this, Bullet.BtVector3._Underlying *center, double *radius);
            fixed (double *__ptr_radius = &radius)
            {
                __btPolyhedralConvexAabbCachingShape_getBoundingSphere(_UnderlyingPtr, center._UnderlyingPtr, __ptr_radius);
            }
        }

        ///getAngularMotionDisc returns the maximum radius needed for Conservative Advancement to handle time-of-impact with rotations.
        /// Generated from method `btPolyhedralConvexAabbCachingShape::getAngularMotionDisc`.
        public unsafe double GetAngularMotionDisc()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAngularMotionDisc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexAabbCachingShape_getAngularMotionDisc(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getAngularMotionDisc(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getContactBreakingThreshold`.
        public unsafe double GetContactBreakingThreshold(double defaultContactThresholdFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getContactBreakingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btPolyhedralConvexAabbCachingShape_getContactBreakingThreshold(_Underlying *_this, double defaultContactThresholdFactor);
            return __btPolyhedralConvexAabbCachingShape_getContactBreakingThreshold(_UnderlyingPtr, defaultContactThresholdFactor);
        }

        ///calculateTemporalAabb calculates the enclosing aabb for the moving object over interval [0..timeStep)
        ///result is conservative
        /// Generated from method `btPolyhedralConvexAabbCachingShape::calculateTemporalAabb`.
        public unsafe void CalculateTemporalAabb(Bullet.Const_BtTransform curTrans, Bullet.Const_BtVector3 linvel, Bullet.Const_BtVector3 angvel, double timeStep, Bullet.BtVector3 temporalAabbMin, Bullet.BtVector3 temporalAabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_calculateTemporalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_calculateTemporalAabb(_Underlying *_this, Bullet.Const_BtTransform._Underlying *curTrans, Bullet.Const_BtVector3._Underlying *linvel, Bullet.Const_BtVector3._Underlying *angvel, double timeStep, Bullet.BtVector3._Underlying *temporalAabbMin, Bullet.BtVector3._Underlying *temporalAabbMax);
            __btPolyhedralConvexAabbCachingShape_calculateTemporalAabb(_UnderlyingPtr, curTrans._UnderlyingPtr, linvel._UnderlyingPtr, angvel._UnderlyingPtr, timeStep, temporalAabbMin._UnderlyingPtr, temporalAabbMax._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::isPolyhedral`.
        public unsafe bool IsPolyhedral()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isPolyhedral", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_isPolyhedral(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_isPolyhedral(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::isConvex2d`.
        public unsafe bool IsConvex2d()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isConvex2d", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_isConvex2d(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_isConvex2d(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::isConvex`.
        public unsafe bool IsConvex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isConvex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_isConvex(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_isConvex(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::isNonMoving`.
        public unsafe bool IsNonMoving()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isNonMoving", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_isNonMoving(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_isNonMoving(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::isConcave`.
        public unsafe bool IsConcave()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isConcave", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_isConcave(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_isConcave(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::isCompound`.
        public unsafe bool IsCompound()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isCompound", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_isCompound(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_isCompound(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::isSoftBody`.
        public unsafe bool IsSoftBody()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isSoftBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_isSoftBody(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_isSoftBody(_UnderlyingPtr) != 0;
        }

        ///isInfinite is used to catch simulation error (aabb check)
        /// Generated from method `btPolyhedralConvexAabbCachingShape::isInfinite`.
        public unsafe bool IsInfinite()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_isInfinite", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_isInfinite(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_isInfinite(_UnderlyingPtr) != 0;
        }

        //debugging support
        /// Generated from method `btPolyhedralConvexAabbCachingShape::getName`.
        public unsafe byte? GetName()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte *__btPolyhedralConvexAabbCachingShape_getName(_Underlying *_this);
            var __c_ret = __btPolyhedralConvexAabbCachingShape_getName(_UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getShapeType`.
        public unsafe int GetShapeType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getShapeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexAabbCachingShape_getShapeType(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getShapeType(_UnderlyingPtr);
        }

        ///the getAnisotropicRollingFrictionDirection can be used in combination with setAnisotropicFriction
        ///See Bullet/Demos/RollingFrictionDemo for an example
        /// Generated from method `btPolyhedralConvexAabbCachingShape::getAnisotropicRollingFrictionDirection`.
        public unsafe Bullet.BtVector3 GetAnisotropicRollingFrictionDirection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getAnisotropicRollingFrictionDirection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btPolyhedralConvexAabbCachingShape_getAnisotropicRollingFrictionDirection(_Underlying *_this);
            return new(__btPolyhedralConvexAabbCachingShape_getAnisotropicRollingFrictionDirection(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btPolyhedralConvexAabbCachingShape_getUserPointer(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexAabbCachingShape_getUserIndex(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btPolyhedralConvexAabbCachingShape_getUserIndex2(_Underlying *_this);
            return __btPolyhedralConvexAabbCachingShape_getUserIndex2(_UnderlyingPtr);
        }
    }

    ///The btPolyhedralConvexAabbCachingShape adds aabb caching to the btPolyhedralConvexShape
    /// Generated from class `btPolyhedralConvexAabbCachingShape`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btPolyhedralConvexShape`
    ///   Indirect: (non-virtual)
    ///     `btCollisionShape`
    ///     `btConvexShape`
    ///     `btConvexInternalShape`
    /// This is the non-const half of the class.
    public class BtPolyhedralConvexAabbCachingShape : Const_BtPolyhedralConvexAabbCachingShape
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionShape(BtPolyhedralConvexAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionShape._Underlying *__btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape(_Underlying *_this);
            Bullet.BtCollisionShape ret = new(__btPolyhedralConvexAabbCachingShape_UpcastTo_btCollisionShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexShape(BtPolyhedralConvexAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexShape._Underlying *__btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape(_Underlying *_this);
            Bullet.BtConvexShape ret = new(__btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtConvexInternalShape(BtPolyhedralConvexAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConvexInternalShape._Underlying *__btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape(_Underlying *_this);
            Bullet.BtConvexInternalShape ret = new(__btPolyhedralConvexAabbCachingShape_UpcastTo_btConvexInternalShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtPolyhedralConvexShape(BtPolyhedralConvexAabbCachingShape self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtPolyhedralConvexShape._Underlying *__btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape(_Underlying *_this);
            Bullet.BtPolyhedralConvexShape ret = new(__btPolyhedralConvexAabbCachingShape_UpcastTo_btPolyhedralConvexShape(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtPolyhedralConvexAabbCachingShape?(Bullet.BtCollisionShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape(Bullet.BtCollisionShape._Underlying *_this);
            var ptr = __btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btCollisionShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtPolyhedralConvexAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtPolyhedralConvexAabbCachingShape?(Bullet.BtConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape(Bullet.BtConvexShape._Underlying *_this);
            var ptr = __btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtPolyhedralConvexAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtPolyhedralConvexAabbCachingShape?(Bullet.BtConvexInternalShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(Bullet.BtConvexInternalShape._Underlying *_this);
            var ptr = __btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btConvexInternalShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtPolyhedralConvexAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtPolyhedralConvexAabbCachingShape?(Bullet.BtPolyhedralConvexShape parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape(Bullet.BtPolyhedralConvexShape._Underlying *_this);
            var ptr = __btPolyhedralConvexAabbCachingShape_DynamicDowncastFrom_btPolyhedralConvexShape(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtPolyhedralConvexAabbCachingShape ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtPolyhedralConvexAabbCachingShape(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from method `btPolyhedralConvexAabbCachingShape::setLocalScaling`.
        public unsafe void SetLocalScaling(Bullet.Const_BtVector3 scaling)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setLocalScaling", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_setLocalScaling(_Underlying *_this, Bullet.Const_BtVector3._Underlying *scaling);
            __btPolyhedralConvexAabbCachingShape_setLocalScaling(_UnderlyingPtr, scaling._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::recalcLocalAabb`.
        public unsafe void RecalcLocalAabb()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_recalcLocalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_recalcLocalAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_recalcLocalAabb(_Underlying *_this);
            __btPolyhedralConvexAabbCachingShape_recalcLocalAabb(_UnderlyingPtr);
        }

        ///optional method mainly used to generate multiple contact points by clipping polyhedral features (faces/edges)
        ///experimental/work-in-progress
        /// Generated from method `btPolyhedralConvexAabbCachingShape::initializePolyhedralFeatures`.
        /// Parameter `shiftVerticesByMargin` defaults to `0`.
        public unsafe bool InitializePolyhedralFeatures(int? shiftVerticesByMargin = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_initializePolyhedralFeatures", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_initializePolyhedralFeatures", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btPolyhedralConvexAabbCachingShape_initializePolyhedralFeatures(_Underlying *_this, int *shiftVerticesByMargin);
            int __deref_shiftVerticesByMargin = shiftVerticesByMargin.GetValueOrDefault();
            return __btPolyhedralConvexAabbCachingShape_initializePolyhedralFeatures(_UnderlyingPtr, shiftVerticesByMargin.HasValue ? &__deref_shiftVerticesByMargin : null) != 0;
        }

        ///warning: use setImplicitShapeDimensions with care
        ///changing a collision shape while the body is in the world is not recommended,
        ///it is best to remove the body from the world, then make the change, and re-add it
        ///alternatively flush the contact points, see documentation for 'cleanProxyFromPairs'
        /// Generated from method `btPolyhedralConvexAabbCachingShape::setImplicitShapeDimensions`.
        public unsafe void SetImplicitShapeDimensions(Bullet.Const_BtVector3 dimensions)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setImplicitShapeDimensions", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_setImplicitShapeDimensions(_Underlying *_this, Bullet.Const_BtVector3._Underlying *dimensions);
            __btPolyhedralConvexAabbCachingShape_setImplicitShapeDimensions(_UnderlyingPtr, dimensions._UnderlyingPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::setMargin`.
        public unsafe void SetMargin(double margin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setMargin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_setMargin(_Underlying *_this, double margin);
            __btPolyhedralConvexAabbCachingShape_setMargin(_UnderlyingPtr, margin);
        }

        ///optional user data pointer
        /// Generated from method `btPolyhedralConvexAabbCachingShape::setUserPointer`.
        /// Parameter `userPtr` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPtr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_setUserPointer(_Underlying *_this, void *userPtr);
            __btPolyhedralConvexAabbCachingShape_setUserPointer(_UnderlyingPtr, userPtr);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_setUserIndex(_Underlying *_this, int index);
            __btPolyhedralConvexAabbCachingShape_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btPolyhedralConvexAabbCachingShape::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btPolyhedralConvexAabbCachingShape_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btPolyhedralConvexAabbCachingShape_setUserIndex2(_Underlying *_this, int index);
            __btPolyhedralConvexAabbCachingShape_setUserIndex2(_UnderlyingPtr, index);
        }
    }

    /// This is used for optional parameters of class `BtPolyhedralConvexAabbCachingShape` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtPolyhedralConvexAabbCachingShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtPolyhedralConvexAabbCachingShape`/`Const_BtPolyhedralConvexAabbCachingShape` directly.
    public class _InOptMut_BtPolyhedralConvexAabbCachingShape
    {
        public BtPolyhedralConvexAabbCachingShape? Opt;

        public _InOptMut_BtPolyhedralConvexAabbCachingShape() {}
        public _InOptMut_BtPolyhedralConvexAabbCachingShape(BtPolyhedralConvexAabbCachingShape value) {Opt = value;}
        public static implicit operator _InOptMut_BtPolyhedralConvexAabbCachingShape(BtPolyhedralConvexAabbCachingShape value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtPolyhedralConvexAabbCachingShape` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtPolyhedralConvexAabbCachingShape`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtPolyhedralConvexAabbCachingShape`/`Const_BtPolyhedralConvexAabbCachingShape` to pass it to the function.
    public class _InOptConst_BtPolyhedralConvexAabbCachingShape
    {
        public Const_BtPolyhedralConvexAabbCachingShape? Opt;

        public _InOptConst_BtPolyhedralConvexAabbCachingShape() {}
        public _InOptConst_BtPolyhedralConvexAabbCachingShape(Const_BtPolyhedralConvexAabbCachingShape value) {Opt = value;}
        public static implicit operator _InOptConst_BtPolyhedralConvexAabbCachingShape(Const_BtPolyhedralConvexAabbCachingShape value) {return new(value);}
    }
}
