// machine generated, do not edit
public static partial class Bullet
{
    ///btDiscreteDynamicsWorld provides discrete rigid body simulation
    ///those classes replace the obsolete CcdPhysicsEnvironment/CcdPhysicsController
    /// Generated from class `btDiscreteDynamicsWorld`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btDynamicsWorld`
    ///   Indirect: (non-virtual)
    ///     `btCollisionWorld`
    /// This is the const half of the class.
    public class Const_BtDiscreteDynamicsWorld : Bullet.Object<Const_BtDiscreteDynamicsWorld>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_Destroy(_Underlying *_this);
            __btDiscreteDynamicsWorld_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtDiscreteDynamicsWorld() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionWorld(Const_BtDiscreteDynamicsWorld self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionWorld._Underlying *__btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld(_Underlying *_this);
            Bullet.Const_BtCollisionWorld ret = new(__btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.Const_BtDynamicsWorld(Const_BtDiscreteDynamicsWorld self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtDynamicsWorld._Underlying *__btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld(_Underlying *_this);
            Bullet.Const_BtDynamicsWorld ret = new(__btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtDiscreteDynamicsWorld?(Bullet.Const_BtCollisionWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(Bullet.Const_BtCollisionWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtDiscreteDynamicsWorld ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator Const_BtDiscreteDynamicsWorld?(Bullet.Const_BtDynamicsWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld(Bullet.Const_BtDynamicsWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtDiscreteDynamicsWorld ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtDiscreteDynamicsWorld(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
        public unsafe Const_BtDiscreteDynamicsWorld(Bullet._ByValue_BtDiscreteDynamicsWorld _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorld._Underlying *__btDiscreteDynamicsWorld_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtDiscreteDynamicsWorld._Underlying *_other);
            _UnderlyingPtr = __btDiscreteDynamicsWorld_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
        public Const_BtDiscreteDynamicsWorld(Const_BtDiscreteDynamicsWorld _other) : this(new _ByValue_BtDiscreteDynamicsWorld(_other)) {}

        /// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
        public Const_BtDiscreteDynamicsWorld(BtDiscreteDynamicsWorld _other) : this((Const_BtDiscreteDynamicsWorld)_other) {}

        ///this btDiscreteDynamicsWorld constructor gets created objects from the user, and will not delete those
        /// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
        public unsafe Const_BtDiscreteDynamicsWorld(Bullet.BtDispatcher? dispatcher, Bullet.BtBroadphaseInterface? pairCache, Bullet.BtConstraintSolver? constraintSolver, Bullet.BtCollisionConfiguration? collisionConfiguration) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorld._Underlying *__btDiscreteDynamicsWorld_Construct(Bullet.BtDispatcher._Underlying *dispatcher, Bullet.BtBroadphaseInterface._Underlying *pairCache, Bullet.BtConstraintSolver._Underlying *constraintSolver, Bullet.BtCollisionConfiguration._Underlying *collisionConfiguration);
            _UnderlyingPtr = __btDiscreteDynamicsWorld_Construct(dispatcher is not null ? dispatcher._UnderlyingPtr : null, pairCache is not null ? pairCache._UnderlyingPtr : null, constraintSolver is not null ? constraintSolver._UnderlyingPtr : null, collisionConfiguration is not null ? collisionConfiguration._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btDiscreteDynamicsWorld_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btDiscreteDynamicsWorld_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btDiscreteDynamicsWorld_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btDiscreteDynamicsWorld_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btDiscreteDynamicsWorld::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btDiscreteDynamicsWorld_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btDiscreteDynamicsWorld_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btDiscreteDynamicsWorld_void_ptr(void *ptr);
            __Bullet_delete_btDiscreteDynamicsWorld_void_ptr(ptr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btDiscreteDynamicsWorld_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btDiscreteDynamicsWorld_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btDiscreteDynamicsWorld_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btDiscreteDynamicsWorld_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btDiscreteDynamicsWorld_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btDiscreteDynamicsWorld_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btDiscreteDynamicsWorld_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btDiscreteDynamicsWorld_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btDiscreteDynamicsWorld::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btDiscreteDynamicsWorld::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr(void *ptr);
            __Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr(ptr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btDiscreteDynamicsWorld_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btDiscreteDynamicsWorld_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btDiscreteDynamicsWorld::getGravity`.
        public unsafe Bullet.BtVector3 GetGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btDiscreteDynamicsWorld_getGravity(_Underlying *_this);
            return new(__btDiscreteDynamicsWorld_getGravity(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btDiscreteDynamicsWorld::getNumConstraints`.
        public unsafe int GetNumConstraints()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getNumConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getNumConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDiscreteDynamicsWorld_getNumConstraints(_Underlying *_this);
            return __btDiscreteDynamicsWorld_getNumConstraints(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::getSynchronizeAllMotionStates`.
        public unsafe bool GetSynchronizeAllMotionStates()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getSynchronizeAllMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getSynchronizeAllMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDiscreteDynamicsWorld_getSynchronizeAllMotionStates(_Underlying *_this);
            return __btDiscreteDynamicsWorld_getSynchronizeAllMotionStates(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btDiscreteDynamicsWorld::getApplySpeculativeContactRestitution`.
        public unsafe bool GetApplySpeculativeContactRestitution()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getApplySpeculativeContactRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getApplySpeculativeContactRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDiscreteDynamicsWorld_getApplySpeculativeContactRestitution(_Underlying *_this);
            return __btDiscreteDynamicsWorld_getApplySpeculativeContactRestitution(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btDiscreteDynamicsWorld::getLatencyMotionStateInterpolation`.
        public unsafe bool GetLatencyMotionStateInterpolation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getLatencyMotionStateInterpolation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getLatencyMotionStateInterpolation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDiscreteDynamicsWorld_getLatencyMotionStateInterpolation(_Underlying *_this);
            return __btDiscreteDynamicsWorld_getLatencyMotionStateInterpolation(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btDiscreteDynamicsWorld::getWorldUserInfo`.
        /// Returns a mutable pointer.
        public unsafe void *GetWorldUserInfo()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btDiscreteDynamicsWorld_getWorldUserInfo(_Underlying *_this);
            return __btDiscreteDynamicsWorld_getWorldUserInfo(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::getNumCollisionObjects`.
        public unsafe int GetNumCollisionObjects()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getNumCollisionObjects", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getNumCollisionObjects", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDiscreteDynamicsWorld_getNumCollisionObjects(_Underlying *_this);
            return __btDiscreteDynamicsWorld_getNumCollisionObjects(_UnderlyingPtr);
        }

        /// rayTest performs a raycast on all objects in the btCollisionWorld, and calls the resultCallback
        /// This allows for several queries: first hit, all hits, any hit, dependent on the value returned by the callback.
        /// Generated from method `btDiscreteDynamicsWorld::rayTest`.
        public unsafe void RayTest(Bullet.Const_BtVector3 rayFromWorld, Bullet.Const_BtVector3 rayToWorld, Bullet.BtCollisionWorld.RayResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_rayTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_rayTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_rayTest(_Underlying *_this, Bullet.Const_BtVector3._Underlying *rayFromWorld, Bullet.Const_BtVector3._Underlying *rayToWorld, Bullet.BtCollisionWorld.RayResultCallback._Underlying *resultCallback);
            __btDiscreteDynamicsWorld_rayTest(_UnderlyingPtr, rayFromWorld._UnderlyingPtr, rayToWorld._UnderlyingPtr, resultCallback._UnderlyingPtr);
        }

        /// convexTest performs a swept convex cast on all objects in the btCollisionWorld, and calls the resultCallback
        /// This allows for several queries: first hit, all hits, any hit, dependent on the value return by the callback.
        /// Generated from method `btDiscreteDynamicsWorld::convexSweepTest`.
        /// Parameter `allowedCcdPenetration` defaults to `btScalar(0.0)`.
        public unsafe void ConvexSweepTest(Bullet.Const_BtConvexShape? castShape, Bullet.Const_BtTransform from, Bullet.Const_BtTransform to, Bullet.BtCollisionWorld.ConvexResultCallback resultCallback, double? allowedCcdPenetration = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_convexSweepTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_convexSweepTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_convexSweepTest(_Underlying *_this, Bullet.Const_BtConvexShape._Underlying *castShape, Bullet.Const_BtTransform._Underlying *from, Bullet.Const_BtTransform._Underlying *to, Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *resultCallback, double *allowedCcdPenetration);
            double __deref_allowedCcdPenetration = allowedCcdPenetration.GetValueOrDefault();
            __btDiscreteDynamicsWorld_convexSweepTest(_UnderlyingPtr, castShape is not null ? castShape._UnderlyingPtr : null, from._UnderlyingPtr, to._UnderlyingPtr, resultCallback._UnderlyingPtr, allowedCcdPenetration.HasValue ? &__deref_allowedCcdPenetration : null);
        }

        /// rayTestSingle performs a raycast call and calls the resultCallback. It is used internally by rayTest.
        /// In a future implementation, we consider moving the ray test as a virtual method in btCollisionShape.
        /// This allows more customization.
        /// Generated from method `btDiscreteDynamicsWorld::rayTestSingle`.
        public static unsafe void RayTestSingle(Bullet.Const_BtTransform rayFromTrans, Bullet.Const_BtTransform rayToTrans, Bullet.BtCollisionObject? collisionObject, Bullet.Const_BtCollisionShape? collisionShape, Bullet.Const_BtTransform colObjWorldTransform, Bullet.BtCollisionWorld.RayResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_rayTestSingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_rayTestSingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_rayTestSingle(Bullet.Const_BtTransform._Underlying *rayFromTrans, Bullet.Const_BtTransform._Underlying *rayToTrans, Bullet.BtCollisionObject._Underlying *collisionObject, Bullet.Const_BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtTransform._Underlying *colObjWorldTransform, Bullet.BtCollisionWorld.RayResultCallback._Underlying *resultCallback);
            __btDiscreteDynamicsWorld_rayTestSingle(rayFromTrans._UnderlyingPtr, rayToTrans._UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, colObjWorldTransform._UnderlyingPtr, resultCallback._UnderlyingPtr);
        }

        /// objectQuerySingle performs a collision detection query and calls the resultCallback. It is used internally by rayTest.
        /// Generated from method `btDiscreteDynamicsWorld::objectQuerySingle`.
        public static unsafe void ObjectQuerySingle(Bullet.Const_BtConvexShape? castShape, Bullet.Const_BtTransform rayFromTrans, Bullet.Const_BtTransform rayToTrans, Bullet.BtCollisionObject? collisionObject, Bullet.Const_BtCollisionShape? collisionShape, Bullet.Const_BtTransform colObjWorldTransform, Bullet.BtCollisionWorld.ConvexResultCallback resultCallback, double allowedPenetration)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_objectQuerySingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_objectQuerySingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_objectQuerySingle(Bullet.Const_BtConvexShape._Underlying *castShape, Bullet.Const_BtTransform._Underlying *rayFromTrans, Bullet.Const_BtTransform._Underlying *rayToTrans, Bullet.BtCollisionObject._Underlying *collisionObject, Bullet.Const_BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtTransform._Underlying *colObjWorldTransform, Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *resultCallback, double allowedPenetration);
            __btDiscreteDynamicsWorld_objectQuerySingle(castShape is not null ? castShape._UnderlyingPtr : null, rayFromTrans._UnderlyingPtr, rayToTrans._UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, colObjWorldTransform._UnderlyingPtr, resultCallback._UnderlyingPtr, allowedPenetration);
        }

        /// Generated from method `btDiscreteDynamicsWorld::getForceUpdateAllAabbs`.
        public unsafe bool GetForceUpdateAllAabbs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDiscreteDynamicsWorld_getForceUpdateAllAabbs(_Underlying *_this);
            return __btDiscreteDynamicsWorld_getForceUpdateAllAabbs(_UnderlyingPtr) != 0;
        }
    }

    ///btDiscreteDynamicsWorld provides discrete rigid body simulation
    ///those classes replace the obsolete CcdPhysicsEnvironment/CcdPhysicsController
    /// Generated from class `btDiscreteDynamicsWorld`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btDynamicsWorld`
    ///   Indirect: (non-virtual)
    ///     `btCollisionWorld`
    /// This is the non-const half of the class.
    public class BtDiscreteDynamicsWorld : Const_BtDiscreteDynamicsWorld
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionWorld(BtDiscreteDynamicsWorld self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld(_Underlying *_this);
            Bullet.BtCollisionWorld ret = new(__btDiscreteDynamicsWorld_UpcastTo_btCollisionWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }
        public static unsafe implicit operator Bullet.BtDynamicsWorld(BtDiscreteDynamicsWorld self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDynamicsWorld._Underlying *__btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld(_Underlying *_this);
            Bullet.BtDynamicsWorld ret = new(__btDiscreteDynamicsWorld_UpcastTo_btDynamicsWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtDiscreteDynamicsWorld?(Bullet.BtCollisionWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(Bullet.BtCollisionWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtDiscreteDynamicsWorld ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }
        public static unsafe explicit operator BtDiscreteDynamicsWorld?(Bullet.BtDynamicsWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld(Bullet.BtDynamicsWorld._Underlying *_this);
            var ptr = __btDiscreteDynamicsWorld_DynamicDowncastFrom_btDynamicsWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtDiscreteDynamicsWorld ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtDiscreteDynamicsWorld(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
        public unsafe BtDiscreteDynamicsWorld(Bullet._ByValue_BtDiscreteDynamicsWorld _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorld._Underlying *__btDiscreteDynamicsWorld_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtDiscreteDynamicsWorld._Underlying *_other);
            _UnderlyingPtr = __btDiscreteDynamicsWorld_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
        public BtDiscreteDynamicsWorld(Const_BtDiscreteDynamicsWorld _other) : this(new _ByValue_BtDiscreteDynamicsWorld(_other)) {}

        /// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
        public BtDiscreteDynamicsWorld(BtDiscreteDynamicsWorld _other) : this((Const_BtDiscreteDynamicsWorld)_other) {}

        ///this btDiscreteDynamicsWorld constructor gets created objects from the user, and will not delete those
        /// Generated from constructor `btDiscreteDynamicsWorld::btDiscreteDynamicsWorld`.
        public unsafe BtDiscreteDynamicsWorld(Bullet.BtDispatcher? dispatcher, Bullet.BtBroadphaseInterface? pairCache, Bullet.BtConstraintSolver? constraintSolver, Bullet.BtCollisionConfiguration? collisionConfiguration) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorld._Underlying *__btDiscreteDynamicsWorld_Construct(Bullet.BtDispatcher._Underlying *dispatcher, Bullet.BtBroadphaseInterface._Underlying *pairCache, Bullet.BtConstraintSolver._Underlying *constraintSolver, Bullet.BtCollisionConfiguration._Underlying *collisionConfiguration);
            _UnderlyingPtr = __btDiscreteDynamicsWorld_Construct(dispatcher is not null ? dispatcher._UnderlyingPtr : null, pairCache is not null ? pairCache._UnderlyingPtr : null, constraintSolver is not null ? constraintSolver._UnderlyingPtr : null, collisionConfiguration is not null ? collisionConfiguration._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::operator=`.
        public unsafe Bullet.BtDiscreteDynamicsWorld Assign(Bullet._ByValue_BtDiscreteDynamicsWorld _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDiscreteDynamicsWorld._Underlying *__btDiscreteDynamicsWorld_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtDiscreteDynamicsWorld._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btDiscreteDynamicsWorld_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        ///if maxSubSteps > 0, it will interpolate motion between fixedTimeStep's
        /// Generated from method `btDiscreteDynamicsWorld::stepSimulation`.
        /// Parameter `maxSubSteps` defaults to `1`.
        /// Parameter `fixedTimeStep` defaults to `btScalar(1.0)/btScalar(60.0)`.
        public unsafe int StepSimulation(double timeStep, int? maxSubSteps = null, double? fixedTimeStep = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_stepSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_stepSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDiscreteDynamicsWorld_stepSimulation(_Underlying *_this, double timeStep, int *maxSubSteps, double *fixedTimeStep);
            int __deref_maxSubSteps = maxSubSteps.GetValueOrDefault();
            double __deref_fixedTimeStep = fixedTimeStep.GetValueOrDefault();
            return __btDiscreteDynamicsWorld_stepSimulation(_UnderlyingPtr, timeStep, maxSubSteps.HasValue ? &__deref_maxSubSteps : null, fixedTimeStep.HasValue ? &__deref_fixedTimeStep : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::synchronizeMotionStates`.
        public unsafe void SynchronizeMotionStates()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_synchronizeMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_synchronizeMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_synchronizeMotionStates(_Underlying *_this);
            __btDiscreteDynamicsWorld_synchronizeMotionStates(_UnderlyingPtr);
        }

        ///this can be useful to synchronize a single rigid body -> graphics object
        /// Generated from method `btDiscreteDynamicsWorld::synchronizeSingleMotionState`.
        public unsafe void SynchronizeSingleMotionState(Bullet.BtRigidBody? body)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_synchronizeSingleMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_synchronizeSingleMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_synchronizeSingleMotionState(_Underlying *_this, Bullet.BtRigidBody._Underlying *body);
            __btDiscreteDynamicsWorld_synchronizeSingleMotionState(_UnderlyingPtr, body is not null ? body._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::getCollisionWorld`.
        public unsafe Bullet.BtCollisionWorld? GetCollisionWorld()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btDiscreteDynamicsWorld_getCollisionWorld(_Underlying *_this);
            var __c_ret = __btDiscreteDynamicsWorld_getCollisionWorld(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtCollisionWorld(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btDiscreteDynamicsWorld::setGravity`.
        public unsafe void SetGravity(Bullet.Const_BtVector3 gravity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_setGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_setGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_setGravity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *gravity);
            __btDiscreteDynamicsWorld_setGravity(_UnderlyingPtr, gravity._UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::addCollisionObject`.
        /// Parameter `collisionFilterGroup` defaults to `btBroadphaseProxy::StaticFilter`.
        /// Parameter `collisionFilterMask` defaults to `btBroadphaseProxy::AllFilter^btBroadphaseProxy::StaticFilter`.
        public unsafe void AddCollisionObject(Bullet.BtCollisionObject? collisionObject, int? collisionFilterGroup = null, int? collisionFilterMask = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_addCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_addCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_addCollisionObject(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject, int *collisionFilterGroup, int *collisionFilterMask);
            int __deref_collisionFilterGroup = collisionFilterGroup.GetValueOrDefault();
            int __deref_collisionFilterMask = collisionFilterMask.GetValueOrDefault();
            __btDiscreteDynamicsWorld_addCollisionObject(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionFilterGroup.HasValue ? &__deref_collisionFilterGroup : null, collisionFilterMask.HasValue ? &__deref_collisionFilterMask : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::addRigidBody`.
        public unsafe void AddRigidBody(Bullet.BtRigidBody? body)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_addRigidBody_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_addRigidBody_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_addRigidBody_1(_Underlying *_this, Bullet.BtRigidBody._Underlying *body);
            __btDiscreteDynamicsWorld_addRigidBody_1(_UnderlyingPtr, body is not null ? body._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::addRigidBody`.
        public unsafe void AddRigidBody(Bullet.BtRigidBody? body, int group, int mask)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_addRigidBody_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_addRigidBody_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_addRigidBody_3(_Underlying *_this, Bullet.BtRigidBody._Underlying *body, int group, int mask);
            __btDiscreteDynamicsWorld_addRigidBody_3(_UnderlyingPtr, body is not null ? body._UnderlyingPtr : null, group, mask);
        }

        /// Generated from method `btDiscreteDynamicsWorld::removeRigidBody`.
        public unsafe void RemoveRigidBody(Bullet.BtRigidBody? body)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_removeRigidBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_removeRigidBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_removeRigidBody(_Underlying *_this, Bullet.BtRigidBody._Underlying *body);
            __btDiscreteDynamicsWorld_removeRigidBody(_UnderlyingPtr, body is not null ? body._UnderlyingPtr : null);
        }

        ///removeCollisionObject will first check if it is a rigid body, if so call removeRigidBody otherwise call btCollisionWorld::removeCollisionObject
        /// Generated from method `btDiscreteDynamicsWorld::removeCollisionObject`.
        public unsafe void RemoveCollisionObject(Bullet.BtCollisionObject? collisionObject)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_removeCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_removeCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_removeCollisionObject(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject);
            __btDiscreteDynamicsWorld_removeCollisionObject(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::debugDrawWorld`.
        public unsafe void DebugDrawWorld()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_debugDrawWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_debugDrawWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_debugDrawWorld(_Underlying *_this);
            __btDiscreteDynamicsWorld_debugDrawWorld(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::setConstraintSolver`.
        public unsafe void SetConstraintSolver(Bullet.BtConstraintSolver? solver)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_setConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_setConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_setConstraintSolver(_Underlying *_this, Bullet.BtConstraintSolver._Underlying *solver);
            __btDiscreteDynamicsWorld_setConstraintSolver(_UnderlyingPtr, solver is not null ? solver._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::getConstraintSolver`.
        public unsafe Bullet.BtConstraintSolver? GetConstraintSolver()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolver._Underlying *__btDiscreteDynamicsWorld_getConstraintSolver(_Underlying *_this);
            var __c_ret = __btDiscreteDynamicsWorld_getConstraintSolver(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtConstraintSolver(__c_ret, is_owning: false) : null;
        }

        ///the forces on each rigidbody is accumulating together with gravity. clear this after each timestep.
        /// Generated from method `btDiscreteDynamicsWorld::clearForces`.
        public unsafe void ClearForces()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_clearForces", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_clearForces", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_clearForces(_Underlying *_this);
            __btDiscreteDynamicsWorld_clearForces(_UnderlyingPtr);
        }

        ///apply gravity, call this once per timestep
        /// Generated from method `btDiscreteDynamicsWorld::applyGravity`.
        public unsafe void ApplyGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_applyGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_applyGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_applyGravity(_Underlying *_this);
            __btDiscreteDynamicsWorld_applyGravity(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::setNumTasks`.
        public unsafe void SetNumTasks(int numTasks)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_setNumTasks", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_setNumTasks", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_setNumTasks(_Underlying *_this, int numTasks);
            __btDiscreteDynamicsWorld_setNumTasks(_UnderlyingPtr, numTasks);
        }

        ///obsolete, use updateActions instead
        /// Generated from method `btDiscreteDynamicsWorld::updateVehicles`.
        public unsafe void UpdateVehicles(double timeStep)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_updateVehicles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_updateVehicles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_updateVehicles(_Underlying *_this, double timeStep);
            __btDiscreteDynamicsWorld_updateVehicles(_UnderlyingPtr, timeStep);
        }

        /// Generated from method `btDiscreteDynamicsWorld::setSynchronizeAllMotionStates`.
        public unsafe void SetSynchronizeAllMotionStates(bool synchronizeAll)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_setSynchronizeAllMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_setSynchronizeAllMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_setSynchronizeAllMotionStates(_Underlying *_this, byte synchronizeAll);
            __btDiscreteDynamicsWorld_setSynchronizeAllMotionStates(_UnderlyingPtr, synchronizeAll ? (byte)1 : (byte)0);
        }

        /// Generated from method `btDiscreteDynamicsWorld::setApplySpeculativeContactRestitution`.
        public unsafe void SetApplySpeculativeContactRestitution(bool enable)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_setApplySpeculativeContactRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_setApplySpeculativeContactRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_setApplySpeculativeContactRestitution(_Underlying *_this, byte enable);
            __btDiscreteDynamicsWorld_setApplySpeculativeContactRestitution(_UnderlyingPtr, enable ? (byte)1 : (byte)0);
        }

        ///Interpolate motion state between previous and current transform, instead of current and next transform.
        ///This can relieve discontinuities in the rendering, due to penetrations
        /// Generated from method `btDiscreteDynamicsWorld::setLatencyMotionStateInterpolation`.
        public unsafe void SetLatencyMotionStateInterpolation(bool latencyInterpolation)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_setLatencyMotionStateInterpolation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_setLatencyMotionStateInterpolation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_setLatencyMotionStateInterpolation(_Underlying *_this, byte latencyInterpolation);
            __btDiscreteDynamicsWorld_setLatencyMotionStateInterpolation(_UnderlyingPtr, latencyInterpolation ? (byte)1 : (byte)0);
        }

        /// Generated from method `btDiscreteDynamicsWorld::setWorldUserInfo`.
        /// Parameter `worldUserInfo` is a mutable pointer.
        public unsafe void SetWorldUserInfo(void *worldUserInfo)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_setWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_setWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_setWorldUserInfo(_Underlying *_this, void *worldUserInfo);
            __btDiscreteDynamicsWorld_setWorldUserInfo(_UnderlyingPtr, worldUserInfo);
        }

        /// Generated from method `btDiscreteDynamicsWorld::setBroadphase`.
        public unsafe void SetBroadphase(Bullet.BtBroadphaseInterface? pairCache)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_setBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_setBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_setBroadphase(_Underlying *_this, Bullet.BtBroadphaseInterface._Underlying *pairCache);
            __btDiscreteDynamicsWorld_setBroadphase(_UnderlyingPtr, pairCache is not null ? pairCache._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::getPairCache`.
        public unsafe Bullet.BtOverlappingPairCache? GetPairCache()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_getPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_getPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtOverlappingPairCache._Underlying *__btDiscreteDynamicsWorld_getPairCache(_Underlying *_this);
            var __c_ret = __btDiscreteDynamicsWorld_getPairCache(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtOverlappingPairCache(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btDiscreteDynamicsWorld::updateSingleAabb`.
        public unsafe void UpdateSingleAabb(Bullet.BtCollisionObject? colObj)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_updateSingleAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_updateSingleAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_updateSingleAabb(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObj);
            __btDiscreteDynamicsWorld_updateSingleAabb(_UnderlyingPtr, colObj is not null ? colObj._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::updateAabbs`.
        public unsafe void UpdateAabbs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_updateAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_updateAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_updateAabbs(_Underlying *_this);
            __btDiscreteDynamicsWorld_updateAabbs(_UnderlyingPtr);
        }

        ///the computeOverlappingPairs is usually already called by performDiscreteCollisionDetection (or stepSimulation)
        ///it can be useful to use if you perform ray tests without collision detection/simulation
        /// Generated from method `btDiscreteDynamicsWorld::computeOverlappingPairs`.
        public unsafe void ComputeOverlappingPairs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_computeOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_computeOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_computeOverlappingPairs(_Underlying *_this);
            __btDiscreteDynamicsWorld_computeOverlappingPairs(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::debugDrawObject`.
        public unsafe void DebugDrawObject(Bullet.Const_BtTransform worldTransform, Bullet.Const_BtCollisionShape? shape, Bullet.Const_BtVector3 color)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_debugDrawObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_debugDrawObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_debugDrawObject(_Underlying *_this, Bullet.Const_BtTransform._Underlying *worldTransform, Bullet.Const_BtCollisionShape._Underlying *shape, Bullet.Const_BtVector3._Underlying *color);
            __btDiscreteDynamicsWorld_debugDrawObject(_UnderlyingPtr, worldTransform._UnderlyingPtr, shape is not null ? shape._UnderlyingPtr : null, color._UnderlyingPtr);
        }

        ///contactTest performs a discrete collision test between colObj against all objects in the btCollisionWorld, and calls the resultCallback.
        ///it reports one or more contact points for every overlapping object (including the one with deepest penetration)
        /// Generated from method `btDiscreteDynamicsWorld::contactTest`.
        public unsafe void ContactTest(Bullet.BtCollisionObject? colObj, Bullet.BtCollisionWorld.ContactResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_contactTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_contactTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_contactTest(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObj, Bullet.BtCollisionWorld.ContactResultCallback._Underlying *resultCallback);
            __btDiscreteDynamicsWorld_contactTest(_UnderlyingPtr, colObj is not null ? colObj._UnderlyingPtr : null, resultCallback._UnderlyingPtr);
        }

        ///contactTest performs a discrete collision test between two collision objects and calls the resultCallback if overlap if detected.
        ///it reports one or more contact points (including the one with deepest penetration)
        /// Generated from method `btDiscreteDynamicsWorld::contactPairTest`.
        public unsafe void ContactPairTest(Bullet.BtCollisionObject? colObjA, Bullet.BtCollisionObject? colObjB, Bullet.BtCollisionWorld.ContactResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_contactPairTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_contactPairTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_contactPairTest(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObjA, Bullet.BtCollisionObject._Underlying *colObjB, Bullet.BtCollisionWorld.ContactResultCallback._Underlying *resultCallback);
            __btDiscreteDynamicsWorld_contactPairTest(_UnderlyingPtr, colObjA is not null ? colObjA._UnderlyingPtr : null, colObjB is not null ? colObjB._UnderlyingPtr : null, resultCallback._UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::refreshBroadphaseProxy`.
        public unsafe void RefreshBroadphaseProxy(Bullet.BtCollisionObject? collisionObject)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_refreshBroadphaseProxy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_refreshBroadphaseProxy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_refreshBroadphaseProxy(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject);
            __btDiscreteDynamicsWorld_refreshBroadphaseProxy(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null);
        }

        /// Generated from method `btDiscreteDynamicsWorld::performDiscreteCollisionDetection`.
        public unsafe void PerformDiscreteCollisionDetection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_performDiscreteCollisionDetection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_performDiscreteCollisionDetection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_performDiscreteCollisionDetection(_Underlying *_this);
            __btDiscreteDynamicsWorld_performDiscreteCollisionDetection(_UnderlyingPtr);
        }

        /// Generated from method `btDiscreteDynamicsWorld::setForceUpdateAllAabbs`.
        public unsafe void SetForceUpdateAllAabbs(bool forceUpdateAllAabbs)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDiscreteDynamicsWorld_setForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDiscreteDynamicsWorld_setForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDiscreteDynamicsWorld_setForceUpdateAllAabbs(_Underlying *_this, byte forceUpdateAllAabbs);
            __btDiscreteDynamicsWorld_setForceUpdateAllAabbs(_UnderlyingPtr, forceUpdateAllAabbs ? (byte)1 : (byte)0);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtDiscreteDynamicsWorld` by value.
    /// Usage:
    /// * Pass an instance of `BtDiscreteDynamicsWorld`/`Const_BtDiscreteDynamicsWorld` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtDiscreteDynamicsWorld
    {
        #pragma warning disable CS0649
        internal readonly Const_BtDiscreteDynamicsWorld? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtDiscreteDynamicsWorld(Const_BtDiscreteDynamicsWorld new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtDiscreteDynamicsWorld(Const_BtDiscreteDynamicsWorld arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtDiscreteDynamicsWorld` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtDiscreteDynamicsWorld`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDiscreteDynamicsWorld`/`Const_BtDiscreteDynamicsWorld` directly.
    public class _InOptMut_BtDiscreteDynamicsWorld
    {
        public BtDiscreteDynamicsWorld? Opt;

        public _InOptMut_BtDiscreteDynamicsWorld() {}
        public _InOptMut_BtDiscreteDynamicsWorld(BtDiscreteDynamicsWorld value) {Opt = value;}
        public static implicit operator _InOptMut_BtDiscreteDynamicsWorld(BtDiscreteDynamicsWorld value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtDiscreteDynamicsWorld` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtDiscreteDynamicsWorld`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDiscreteDynamicsWorld`/`Const_BtDiscreteDynamicsWorld` to pass it to the function.
    public class _InOptConst_BtDiscreteDynamicsWorld
    {
        public Const_BtDiscreteDynamicsWorld? Opt;

        public _InOptConst_BtDiscreteDynamicsWorld() {}
        public _InOptConst_BtDiscreteDynamicsWorld(Const_BtDiscreteDynamicsWorld value) {Opt = value;}
        public static implicit operator _InOptConst_BtDiscreteDynamicsWorld(Const_BtDiscreteDynamicsWorld value) {return new(value);}
    }
}
