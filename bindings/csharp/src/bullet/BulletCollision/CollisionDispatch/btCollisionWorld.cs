// machine generated, do not edit
public static partial class Bullet
{
    ///CollisionWorld is interface and container for the collision detection
    /// Generated from class `btCollisionWorld`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDynamicsWorld`
    ///   Indirect: (non-virtual)
    ///     `btDiscreteDynamicsWorld`
    /// This is the const half of the class.
    public class Const_BtCollisionWorld : Bullet.Object<Const_BtCollisionWorld>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_Destroy(_Underlying *_this);
            __btCollisionWorld_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtCollisionWorld() {Dispose(false);}

        internal unsafe Const_BtCollisionWorld(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btCollisionWorld::btCollisionWorld`.
        public unsafe Const_BtCollisionWorld(Bullet._ByValue_BtCollisionWorld _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btCollisionWorld_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld._Underlying *_other);
            _UnderlyingPtr = __btCollisionWorld_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCollisionWorld::btCollisionWorld`.
        public Const_BtCollisionWorld(Const_BtCollisionWorld _other) : this(new _ByValue_BtCollisionWorld(_other)) {}

        /// Generated from constructor `btCollisionWorld::btCollisionWorld`.
        public Const_BtCollisionWorld(BtCollisionWorld _other) : this((Const_BtCollisionWorld)_other) {}

        //this constructor doesn't own the dispatcher and paircache/broadphase
        /// Generated from constructor `btCollisionWorld::btCollisionWorld`.
        public unsafe Const_BtCollisionWorld(Bullet.BtDispatcher? dispatcher, Bullet.BtBroadphaseInterface? broadphasePairCache, Bullet.BtCollisionConfiguration? collisionConfiguration) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btCollisionWorld_Construct(Bullet.BtDispatcher._Underlying *dispatcher, Bullet.BtBroadphaseInterface._Underlying *broadphasePairCache, Bullet.BtCollisionConfiguration._Underlying *collisionConfiguration);
            _UnderlyingPtr = __btCollisionWorld_Construct(dispatcher is not null ? dispatcher._UnderlyingPtr : null, broadphasePairCache is not null ? broadphasePairCache._UnderlyingPtr : null, collisionConfiguration is not null ? collisionConfiguration._UnderlyingPtr : null);
        }

        /// Generated from method `btCollisionWorld::getBroadphase`.
        public unsafe Bullet.Const_BtBroadphaseInterface? GetBroadphase()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_getBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_getBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtBroadphaseInterface._Underlying *__btCollisionWorld_getBroadphase(_Underlying *_this);
            var __c_ret = __btCollisionWorld_getBroadphase(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Const_BtBroadphaseInterface(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btCollisionWorld::getDispatcher`.
        public unsafe Bullet.Const_BtDispatcher? GetDispatcher()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_getDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_getDispatcher", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtDispatcher._Underlying *__btCollisionWorld_getDispatcher(_Underlying *_this);
            var __c_ret = __btCollisionWorld_getDispatcher(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Const_BtDispatcher(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btCollisionWorld::getNumCollisionObjects`.
        public unsafe int GetNumCollisionObjects()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_getNumCollisionObjects", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_getNumCollisionObjects", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionWorld_getNumCollisionObjects(_Underlying *_this);
            return __btCollisionWorld_getNumCollisionObjects(_UnderlyingPtr);
        }

        /// rayTest performs a raycast on all objects in the btCollisionWorld, and calls the resultCallback
        /// This allows for several queries: first hit, all hits, any hit, dependent on the value returned by the callback.
        /// Generated from method `btCollisionWorld::rayTest`.
        public unsafe void RayTest(Bullet.Const_BtVector3 rayFromWorld, Bullet.Const_BtVector3 rayToWorld, Bullet.BtCollisionWorld.RayResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_rayTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_rayTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_rayTest(_Underlying *_this, Bullet.Const_BtVector3._Underlying *rayFromWorld, Bullet.Const_BtVector3._Underlying *rayToWorld, Bullet.BtCollisionWorld.RayResultCallback._Underlying *resultCallback);
            __btCollisionWorld_rayTest(_UnderlyingPtr, rayFromWorld._UnderlyingPtr, rayToWorld._UnderlyingPtr, resultCallback._UnderlyingPtr);
        }

        /// convexTest performs a swept convex cast on all objects in the btCollisionWorld, and calls the resultCallback
        /// This allows for several queries: first hit, all hits, any hit, dependent on the value return by the callback.
        /// Generated from method `btCollisionWorld::convexSweepTest`.
        /// Parameter `allowedCcdPenetration` defaults to `btScalar(0.0)`.
        public unsafe void ConvexSweepTest(Bullet.Const_BtConvexShape? castShape, Bullet.Const_BtTransform from, Bullet.Const_BtTransform to, Bullet.BtCollisionWorld.ConvexResultCallback resultCallback, double? allowedCcdPenetration = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_convexSweepTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_convexSweepTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_convexSweepTest(_Underlying *_this, Bullet.Const_BtConvexShape._Underlying *castShape, Bullet.Const_BtTransform._Underlying *from, Bullet.Const_BtTransform._Underlying *to, Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *resultCallback, double *allowedCcdPenetration);
            double __deref_allowedCcdPenetration = allowedCcdPenetration.GetValueOrDefault();
            __btCollisionWorld_convexSweepTest(_UnderlyingPtr, castShape is not null ? castShape._UnderlyingPtr : null, from._UnderlyingPtr, to._UnderlyingPtr, resultCallback._UnderlyingPtr, allowedCcdPenetration.HasValue ? &__deref_allowedCcdPenetration : null);
        }

        /// rayTestSingle performs a raycast call and calls the resultCallback. It is used internally by rayTest.
        /// In a future implementation, we consider moving the ray test as a virtual method in btCollisionShape.
        /// This allows more customization.
        /// Generated from method `btCollisionWorld::rayTestSingle`.
        public static unsafe void RayTestSingle(Bullet.Const_BtTransform rayFromTrans, Bullet.Const_BtTransform rayToTrans, Bullet.BtCollisionObject? collisionObject, Bullet.Const_BtCollisionShape? collisionShape, Bullet.Const_BtTransform colObjWorldTransform, Bullet.BtCollisionWorld.RayResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_rayTestSingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_rayTestSingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_rayTestSingle(Bullet.Const_BtTransform._Underlying *rayFromTrans, Bullet.Const_BtTransform._Underlying *rayToTrans, Bullet.BtCollisionObject._Underlying *collisionObject, Bullet.Const_BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtTransform._Underlying *colObjWorldTransform, Bullet.BtCollisionWorld.RayResultCallback._Underlying *resultCallback);
            __btCollisionWorld_rayTestSingle(rayFromTrans._UnderlyingPtr, rayToTrans._UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, colObjWorldTransform._UnderlyingPtr, resultCallback._UnderlyingPtr);
        }

        /// objectQuerySingle performs a collision detection query and calls the resultCallback. It is used internally by rayTest.
        /// Generated from method `btCollisionWorld::objectQuerySingle`.
        public static unsafe void ObjectQuerySingle(Bullet.Const_BtConvexShape? castShape, Bullet.Const_BtTransform rayFromTrans, Bullet.Const_BtTransform rayToTrans, Bullet.BtCollisionObject? collisionObject, Bullet.Const_BtCollisionShape? collisionShape, Bullet.Const_BtTransform colObjWorldTransform, Bullet.BtCollisionWorld.ConvexResultCallback resultCallback, double allowedPenetration)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_objectQuerySingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_objectQuerySingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_objectQuerySingle(Bullet.Const_BtConvexShape._Underlying *castShape, Bullet.Const_BtTransform._Underlying *rayFromTrans, Bullet.Const_BtTransform._Underlying *rayToTrans, Bullet.BtCollisionObject._Underlying *collisionObject, Bullet.Const_BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtTransform._Underlying *colObjWorldTransform, Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *resultCallback, double allowedPenetration);
            __btCollisionWorld_objectQuerySingle(castShape is not null ? castShape._UnderlyingPtr : null, rayFromTrans._UnderlyingPtr, rayToTrans._UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, colObjWorldTransform._UnderlyingPtr, resultCallback._UnderlyingPtr, allowedPenetration);
        }

        /// Generated from method `btCollisionWorld::getForceUpdateAllAabbs`.
        public unsafe bool GetForceUpdateAllAabbs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_getForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_getForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionWorld_getForceUpdateAllAabbs(_Underlying *_this);
            return __btCollisionWorld_getForceUpdateAllAabbs(_UnderlyingPtr) != 0;
        }

        /// Generated from class `btCollisionWorld::AllHitsRayResultCallback`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::RayResultCallback`
        /// This is the const half of the class.
        public class Const_AllHitsRayResultCallback : Bullet.Object<Const_AllHitsRayResultCallback>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btCollisionWorld_AllHitsRayResultCallback_Destroy(_Underlying *_this);
                __btCollisionWorld_AllHitsRayResultCallback_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_AllHitsRayResultCallback() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Bullet.BtCollisionWorld.Const_RayResultCallback(Const_AllHitsRayResultCallback self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.Const_RayResultCallback._Underlying *__btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(_Underlying *_this);
                Bullet.BtCollisionWorld.Const_RayResultCallback ret = new(__btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_AllHitsRayResultCallback?(Bullet.BtCollisionWorld.Const_RayResultCallback parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(Bullet.BtCollisionWorld.Const_RayResultCallback._Underlying *_this);
                var ptr = __btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_AllHitsRayResultCallback ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            //used to calculate hitPointWorld from hitFraction
            public unsafe Bullet.Const_BtVector3 mRayFromWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_rayFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_rayFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_AllHitsRayResultCallback_Get_m_rayFromWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_AllHitsRayResultCallback_Get_m_rayFromWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.Const_BtVector3 mRayToWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_rayToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_rayToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_AllHitsRayResultCallback_Get_m_rayToWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_AllHitsRayResultCallback_Get_m_rayToWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_AllHitsRayResultCallback_Get_m_closestHitFraction(_Underlying *_this);
                    return *__btCollisionWorld_AllHitsRayResultCallback_Get_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public unsafe Bullet.Const_BtCollisionObject? mCollisionObject
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionObject(Const_AllHitsRayResultCallback._Underlying *_this);
                    var ptr = __btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionObject(_UnderlyingPtr);
                    Bullet.Const_BtCollisionObject? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterGroup(_Underlying *_this);
                    return *__btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public unsafe int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterMask(_Underlying *_this);
                    return *__btCollisionWorld_AllHitsRayResultCallback_Get_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            //@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
            public unsafe uint mFlags
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Get_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__btCollisionWorld_AllHitsRayResultCallback_Get_m_flags(_Underlying *_this);
                    return *__btCollisionWorld_AllHitsRayResultCallback_Get_m_flags(_UnderlyingPtr);
                }
            }

            internal unsafe Const_AllHitsRayResultCallback(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
            public unsafe Const_AllHitsRayResultCallback(Bullet.BtCollisionWorld._ByValue_AllHitsRayResultCallback _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.AllHitsRayResultCallback._Underlying *__btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld.AllHitsRayResultCallback._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
            public Const_AllHitsRayResultCallback(Const_AllHitsRayResultCallback _other) : this(new _ByValue_AllHitsRayResultCallback(_other)) {}

            /// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
            public Const_AllHitsRayResultCallback(AllHitsRayResultCallback _other) : this((Const_AllHitsRayResultCallback)_other) {}

            /// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
            public unsafe Const_AllHitsRayResultCallback(Bullet.Const_BtVector3 rayFromWorld, Bullet.Const_BtVector3 rayToWorld) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.AllHitsRayResultCallback._Underlying *__btCollisionWorld_AllHitsRayResultCallback_Construct(Bullet.Const_BtVector3._Underlying *rayFromWorld, Bullet.Const_BtVector3._Underlying *rayToWorld);
                _UnderlyingPtr = __btCollisionWorld_AllHitsRayResultCallback_Construct(rayFromWorld._UnderlyingPtr, rayToWorld._UnderlyingPtr);
            }

            /// Generated from method `btCollisionWorld::AllHitsRayResultCallback::hasHit`.
            public unsafe bool HasHit()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __btCollisionWorld_AllHitsRayResultCallback_hasHit(_Underlying *_this);
                return __btCollisionWorld_AllHitsRayResultCallback_hasHit(_UnderlyingPtr) != 0;
            }
        }

        /// Generated from class `btCollisionWorld::AllHitsRayResultCallback`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::RayResultCallback`
        /// This is the non-const half of the class.
        public class AllHitsRayResultCallback : Const_AllHitsRayResultCallback
        {
            // Upcasts:
            public static unsafe implicit operator Bullet.BtCollisionWorld.RayResultCallback(AllHitsRayResultCallback self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.RayResultCallback._Underlying *__btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(_Underlying *_this);
                Bullet.BtCollisionWorld.RayResultCallback ret = new(__btCollisionWorld_AllHitsRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator AllHitsRayResultCallback?(Bullet.BtCollisionWorld.RayResultCallback parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(Bullet.BtCollisionWorld.RayResultCallback._Underlying *_this);
                var ptr = __btCollisionWorld_AllHitsRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(parent._UnderlyingPtr);
                if (ptr is null) return null;
                AllHitsRayResultCallback ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            //used to calculate hitPointWorld from hitFraction
            public new unsafe Bullet.BtVector3 mRayFromWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayFromWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayFromWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.BtVector3 mRayToWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayToWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_rayToWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe ref double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_closestHitFraction(_Underlying *_this);
                    return ref *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public new unsafe Bullet.Const_BtCollisionObject? mCollisionObject
            {
                get => base.mCollisionObject;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionObject(AllHitsRayResultCallback._Underlying *_this);
                    var ptr = __btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionObject(_UnderlyingPtr);
                    _DiscardKeepAlive("m_collisionObject");
                    if (value is not null)
                        _KeepAlive(value, "m_collisionObject");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe ref int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterGroup(_Underlying *_this);
                    return ref *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterMask(_Underlying *_this);
                    return ref *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            //@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
            public new unsafe ref uint mFlags
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_flags(_Underlying *_this);
                    return ref *__btCollisionWorld_AllHitsRayResultCallback_GetMutable_m_flags(_UnderlyingPtr);
                }
            }

            internal unsafe AllHitsRayResultCallback(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
            public unsafe AllHitsRayResultCallback(Bullet.BtCollisionWorld._ByValue_AllHitsRayResultCallback _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.AllHitsRayResultCallback._Underlying *__btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld.AllHitsRayResultCallback._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_AllHitsRayResultCallback_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
            public AllHitsRayResultCallback(Const_AllHitsRayResultCallback _other) : this(new _ByValue_AllHitsRayResultCallback(_other)) {}

            /// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
            public AllHitsRayResultCallback(AllHitsRayResultCallback _other) : this((Const_AllHitsRayResultCallback)_other) {}

            /// Generated from constructor `btCollisionWorld::AllHitsRayResultCallback::AllHitsRayResultCallback`.
            public unsafe AllHitsRayResultCallback(Bullet.Const_BtVector3 rayFromWorld, Bullet.Const_BtVector3 rayToWorld) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.AllHitsRayResultCallback._Underlying *__btCollisionWorld_AllHitsRayResultCallback_Construct(Bullet.Const_BtVector3._Underlying *rayFromWorld, Bullet.Const_BtVector3._Underlying *rayToWorld);
                _UnderlyingPtr = __btCollisionWorld_AllHitsRayResultCallback_Construct(rayFromWorld._UnderlyingPtr, rayToWorld._UnderlyingPtr);
            }

            /// Generated from method `btCollisionWorld::AllHitsRayResultCallback::operator=`.
            public unsafe Bullet.BtCollisionWorld.AllHitsRayResultCallback Assign(Bullet.BtCollisionWorld._ByValue_AllHitsRayResultCallback _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.AllHitsRayResultCallback._Underlying *__btCollisionWorld_AllHitsRayResultCallback_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld.AllHitsRayResultCallback._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__btCollisionWorld_AllHitsRayResultCallback_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }

            /// Generated from method `btCollisionWorld::AllHitsRayResultCallback::addSingleResult`.
            public unsafe double AddSingleResult(Bullet.BtCollisionWorld.LocalRayResult rayResult, bool normalInWorldSpace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AllHitsRayResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __btCollisionWorld_AllHitsRayResultCallback_addSingleResult(_Underlying *_this, Bullet.BtCollisionWorld.LocalRayResult._Underlying *rayResult, byte normalInWorldSpace);
                return __btCollisionWorld_AllHitsRayResultCallback_addSingleResult(_UnderlyingPtr, rayResult._UnderlyingPtr, normalInWorldSpace ? (byte)1 : (byte)0);
            }
        }

        /// This is used as a function parameter when the underlying function receives `AllHitsRayResultCallback` by value.
        /// Usage:
        /// * Pass an instance of `AllHitsRayResultCallback`/`Const_AllHitsRayResultCallback` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_AllHitsRayResultCallback
        {
            #pragma warning disable CS0649
            internal readonly Const_AllHitsRayResultCallback? Value;
            #pragma warning restore CS0649
            internal readonly Bullet._PassBy PassByMode;
            public _ByValue_AllHitsRayResultCallback(Const_AllHitsRayResultCallback new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
            public static implicit operator _ByValue_AllHitsRayResultCallback(Const_AllHitsRayResultCallback arg) {return new(arg);}
            public _ByValue_AllHitsRayResultCallback(Bullet._Moved<AllHitsRayResultCallback> moved) {Value = moved.Value; PassByMode = Bullet._PassBy.move;}
            public static implicit operator _ByValue_AllHitsRayResultCallback(Bullet._Moved<AllHitsRayResultCallback> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `AllHitsRayResultCallback` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_AllHitsRayResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `AllHitsRayResultCallback`/`Const_AllHitsRayResultCallback` directly.
        public class _InOptMut_AllHitsRayResultCallback
        {
            public AllHitsRayResultCallback? Opt;

            public _InOptMut_AllHitsRayResultCallback() {}
            public _InOptMut_AllHitsRayResultCallback(AllHitsRayResultCallback value) {Opt = value;}
            public static implicit operator _InOptMut_AllHitsRayResultCallback(AllHitsRayResultCallback value) {return new(value);}
        }

        /// This is used for optional parameters of class `AllHitsRayResultCallback` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_AllHitsRayResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `AllHitsRayResultCallback`/`Const_AllHitsRayResultCallback` to pass it to the function.
        public class _InOptConst_AllHitsRayResultCallback
        {
            public Const_AllHitsRayResultCallback? Opt;

            public _InOptConst_AllHitsRayResultCallback() {}
            public _InOptConst_AllHitsRayResultCallback(Const_AllHitsRayResultCallback value) {Opt = value;}
            public static implicit operator _InOptConst_AllHitsRayResultCallback(Const_AllHitsRayResultCallback value) {return new(value);}
        }

        /// Generated from class `btCollisionWorld::ClosestConvexResultCallback`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::ConvexResultCallback`
        /// This is the const half of the class.
        public class Const_ClosestConvexResultCallback : Bullet.Object<Const_ClosestConvexResultCallback>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btCollisionWorld_ClosestConvexResultCallback_Destroy(_Underlying *_this);
                __btCollisionWorld_ClosestConvexResultCallback_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_ClosestConvexResultCallback() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Bullet.BtCollisionWorld.Const_ConvexResultCallback(Const_ClosestConvexResultCallback self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.Const_ConvexResultCallback._Underlying *__btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback(_Underlying *_this);
                Bullet.BtCollisionWorld.Const_ConvexResultCallback ret = new(__btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_ClosestConvexResultCallback?(Bullet.BtCollisionWorld.Const_ConvexResultCallback parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback(Bullet.BtCollisionWorld.Const_ConvexResultCallback._Underlying *_this);
                var ptr = __btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_ClosestConvexResultCallback ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            //used to calculate hitPointWorld from hitFraction
            public unsafe Bullet.Const_BtVector3 mConvexFromWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_convexFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_convexFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_ClosestConvexResultCallback_Get_m_convexFromWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestConvexResultCallback_Get_m_convexFromWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.Const_BtVector3 mConvexToWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_convexToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_convexToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_ClosestConvexResultCallback_Get_m_convexToWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestConvexResultCallback_Get_m_convexToWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.Const_BtVector3 mHitNormalWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_hitNormalWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_hitNormalWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_ClosestConvexResultCallback_Get_m_hitNormalWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestConvexResultCallback_Get_m_hitNormalWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.Const_BtVector3 mHitPointWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_hitPointWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_hitPointWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_ClosestConvexResultCallback_Get_m_hitPointWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestConvexResultCallback_Get_m_hitPointWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.Const_BtCollisionObject? mHitCollisionObject
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_hitCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_hitCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_ClosestConvexResultCallback_Get_m_hitCollisionObject(Const_ClosestConvexResultCallback._Underlying *_this);
                    var ptr = __btCollisionWorld_ClosestConvexResultCallback_Get_m_hitCollisionObject(_UnderlyingPtr);
                    Bullet.Const_BtCollisionObject? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_ClosestConvexResultCallback_Get_m_closestHitFraction(_Underlying *_this);
                    return *__btCollisionWorld_ClosestConvexResultCallback_Get_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public unsafe int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterGroup(_Underlying *_this);
                    return *__btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public unsafe int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterMask(_Underlying *_this);
                    return *__btCollisionWorld_ClosestConvexResultCallback_Get_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            internal unsafe Const_ClosestConvexResultCallback(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
            public unsafe Const_ClosestConvexResultCallback(Bullet.BtCollisionWorld._ByValue_ClosestConvexResultCallback _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestConvexResultCallback._Underlying *__btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld.ClosestConvexResultCallback._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
            public Const_ClosestConvexResultCallback(Const_ClosestConvexResultCallback _other) : this(new _ByValue_ClosestConvexResultCallback(_other)) {}

            /// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
            public Const_ClosestConvexResultCallback(ClosestConvexResultCallback _other) : this((Const_ClosestConvexResultCallback)_other) {}

            /// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
            public unsafe Const_ClosestConvexResultCallback(Bullet.Const_BtVector3 convexFromWorld, Bullet.Const_BtVector3 convexToWorld) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestConvexResultCallback._Underlying *__btCollisionWorld_ClosestConvexResultCallback_Construct(Bullet.Const_BtVector3._Underlying *convexFromWorld, Bullet.Const_BtVector3._Underlying *convexToWorld);
                _UnderlyingPtr = __btCollisionWorld_ClosestConvexResultCallback_Construct(convexFromWorld._UnderlyingPtr, convexToWorld._UnderlyingPtr);
            }

            /// Generated from method `btCollisionWorld::ClosestConvexResultCallback::hasHit`.
            public unsafe bool HasHit()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __btCollisionWorld_ClosestConvexResultCallback_hasHit(_Underlying *_this);
                return __btCollisionWorld_ClosestConvexResultCallback_hasHit(_UnderlyingPtr) != 0;
            }
        }

        /// Generated from class `btCollisionWorld::ClosestConvexResultCallback`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::ConvexResultCallback`
        /// This is the non-const half of the class.
        public class ClosestConvexResultCallback : Const_ClosestConvexResultCallback
        {
            // Upcasts:
            public static unsafe implicit operator Bullet.BtCollisionWorld.ConvexResultCallback(ClosestConvexResultCallback self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *__btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback(_Underlying *_this);
                Bullet.BtCollisionWorld.ConvexResultCallback ret = new(__btCollisionWorld_ClosestConvexResultCallback_UpcastTo_btCollisionWorld_ConvexResultCallback(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator ClosestConvexResultCallback?(Bullet.BtCollisionWorld.ConvexResultCallback parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback(Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *_this);
                var ptr = __btCollisionWorld_ClosestConvexResultCallback_DynamicDowncastFrom_btCollisionWorld_ConvexResultCallback(parent._UnderlyingPtr);
                if (ptr is null) return null;
                ClosestConvexResultCallback ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            //used to calculate hitPointWorld from hitFraction
            public new unsafe Bullet.BtVector3 mConvexFromWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexFromWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexFromWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.BtVector3 mConvexToWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexToWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_convexToWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.BtVector3 mHitNormalWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitNormalWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitNormalWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitNormalWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitNormalWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.BtVector3 mHitPointWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitPointWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitPointWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitPointWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitPointWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.Const_BtCollisionObject? mHitCollisionObject
            {
                get => base.mHitCollisionObject;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitCollisionObject(ClosestConvexResultCallback._Underlying *_this);
                    var ptr = __btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_hitCollisionObject(_UnderlyingPtr);
                    _DiscardKeepAlive("m_hitCollisionObject");
                    if (value is not null)
                        _KeepAlive(value, "m_hitCollisionObject");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe ref double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_closestHitFraction(_Underlying *_this);
                    return ref *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterGroup(_Underlying *_this);
                    return ref *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterMask(_Underlying *_this);
                    return ref *__btCollisionWorld_ClosestConvexResultCallback_GetMutable_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            internal unsafe ClosestConvexResultCallback(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
            public unsafe ClosestConvexResultCallback(Bullet.BtCollisionWorld._ByValue_ClosestConvexResultCallback _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestConvexResultCallback._Underlying *__btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld.ClosestConvexResultCallback._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_ClosestConvexResultCallback_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
            public ClosestConvexResultCallback(Const_ClosestConvexResultCallback _other) : this(new _ByValue_ClosestConvexResultCallback(_other)) {}

            /// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
            public ClosestConvexResultCallback(ClosestConvexResultCallback _other) : this((Const_ClosestConvexResultCallback)_other) {}

            /// Generated from constructor `btCollisionWorld::ClosestConvexResultCallback::ClosestConvexResultCallback`.
            public unsafe ClosestConvexResultCallback(Bullet.Const_BtVector3 convexFromWorld, Bullet.Const_BtVector3 convexToWorld) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestConvexResultCallback._Underlying *__btCollisionWorld_ClosestConvexResultCallback_Construct(Bullet.Const_BtVector3._Underlying *convexFromWorld, Bullet.Const_BtVector3._Underlying *convexToWorld);
                _UnderlyingPtr = __btCollisionWorld_ClosestConvexResultCallback_Construct(convexFromWorld._UnderlyingPtr, convexToWorld._UnderlyingPtr);
            }

            /// Generated from method `btCollisionWorld::ClosestConvexResultCallback::operator=`.
            public unsafe Bullet.BtCollisionWorld.ClosestConvexResultCallback Assign(Bullet.BtCollisionWorld._ByValue_ClosestConvexResultCallback _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestConvexResultCallback._Underlying *__btCollisionWorld_ClosestConvexResultCallback_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld.ClosestConvexResultCallback._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__btCollisionWorld_ClosestConvexResultCallback_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }

            /// Generated from method `btCollisionWorld::ClosestConvexResultCallback::addSingleResult`.
            public unsafe double AddSingleResult(Bullet.BtCollisionWorld.LocalConvexResult convexResult, bool normalInWorldSpace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestConvexResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __btCollisionWorld_ClosestConvexResultCallback_addSingleResult(_Underlying *_this, Bullet.BtCollisionWorld.LocalConvexResult._Underlying *convexResult, byte normalInWorldSpace);
                return __btCollisionWorld_ClosestConvexResultCallback_addSingleResult(_UnderlyingPtr, convexResult._UnderlyingPtr, normalInWorldSpace ? (byte)1 : (byte)0);
            }
        }

        /// This is used as a function parameter when the underlying function receives `ClosestConvexResultCallback` by value.
        /// Usage:
        /// * Pass an instance of `ClosestConvexResultCallback`/`Const_ClosestConvexResultCallback` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_ClosestConvexResultCallback
        {
            #pragma warning disable CS0649
            internal readonly Const_ClosestConvexResultCallback? Value;
            #pragma warning restore CS0649
            internal readonly Bullet._PassBy PassByMode;
            public _ByValue_ClosestConvexResultCallback(Const_ClosestConvexResultCallback new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
            public static implicit operator _ByValue_ClosestConvexResultCallback(Const_ClosestConvexResultCallback arg) {return new(arg);}
            public _ByValue_ClosestConvexResultCallback(Bullet._Moved<ClosestConvexResultCallback> moved) {Value = moved.Value; PassByMode = Bullet._PassBy.move;}
            public static implicit operator _ByValue_ClosestConvexResultCallback(Bullet._Moved<ClosestConvexResultCallback> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `ClosestConvexResultCallback` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_ClosestConvexResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `ClosestConvexResultCallback`/`Const_ClosestConvexResultCallback` directly.
        public class _InOptMut_ClosestConvexResultCallback
        {
            public ClosestConvexResultCallback? Opt;

            public _InOptMut_ClosestConvexResultCallback() {}
            public _InOptMut_ClosestConvexResultCallback(ClosestConvexResultCallback value) {Opt = value;}
            public static implicit operator _InOptMut_ClosestConvexResultCallback(ClosestConvexResultCallback value) {return new(value);}
        }

        /// This is used for optional parameters of class `ClosestConvexResultCallback` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_ClosestConvexResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `ClosestConvexResultCallback`/`Const_ClosestConvexResultCallback` to pass it to the function.
        public class _InOptConst_ClosestConvexResultCallback
        {
            public Const_ClosestConvexResultCallback? Opt;

            public _InOptConst_ClosestConvexResultCallback() {}
            public _InOptConst_ClosestConvexResultCallback(Const_ClosestConvexResultCallback value) {Opt = value;}
            public static implicit operator _InOptConst_ClosestConvexResultCallback(Const_ClosestConvexResultCallback value) {return new(value);}
        }

        /// Generated from class `btCollisionWorld::ClosestRayResultCallback`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::RayResultCallback`
        /// This is the const half of the class.
        public class Const_ClosestRayResultCallback : Bullet.Object<Const_ClosestRayResultCallback>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btCollisionWorld_ClosestRayResultCallback_Destroy(_Underlying *_this);
                __btCollisionWorld_ClosestRayResultCallback_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_ClosestRayResultCallback() {Dispose(false);}

            // Upcasts:
            public static unsafe implicit operator Bullet.BtCollisionWorld.Const_RayResultCallback(Const_ClosestRayResultCallback self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.Const_RayResultCallback._Underlying *__btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(_Underlying *_this);
                Bullet.BtCollisionWorld.Const_RayResultCallback ret = new(__btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator Const_ClosestRayResultCallback?(Bullet.BtCollisionWorld.Const_RayResultCallback parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(Bullet.BtCollisionWorld.Const_RayResultCallback._Underlying *_this);
                var ptr = __btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(parent._UnderlyingPtr);
                if (ptr is null) return null;
                Const_ClosestRayResultCallback ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            //used to calculate hitPointWorld from hitFraction
            public unsafe Bullet.Const_BtVector3 mRayFromWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_rayFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_rayFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_ClosestRayResultCallback_Get_m_rayFromWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestRayResultCallback_Get_m_rayFromWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.Const_BtVector3 mRayToWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_rayToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_rayToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_ClosestRayResultCallback_Get_m_rayToWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestRayResultCallback_Get_m_rayToWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.Const_BtVector3 mHitNormalWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_hitNormalWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_hitNormalWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_ClosestRayResultCallback_Get_m_hitNormalWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestRayResultCallback_Get_m_hitNormalWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.Const_BtVector3 mHitPointWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_hitPointWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_hitPointWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_ClosestRayResultCallback_Get_m_hitPointWorld(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestRayResultCallback_Get_m_hitPointWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_ClosestRayResultCallback_Get_m_closestHitFraction(_Underlying *_this);
                    return *__btCollisionWorld_ClosestRayResultCallback_Get_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public unsafe Bullet.Const_BtCollisionObject? mCollisionObject
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_ClosestRayResultCallback_Get_m_collisionObject(Const_ClosestRayResultCallback._Underlying *_this);
                    var ptr = __btCollisionWorld_ClosestRayResultCallback_Get_m_collisionObject(_UnderlyingPtr);
                    Bullet.Const_BtCollisionObject? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterGroup(_Underlying *_this);
                    return *__btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public unsafe int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterMask(_Underlying *_this);
                    return *__btCollisionWorld_ClosestRayResultCallback_Get_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            //@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
            public unsafe uint mFlags
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Get_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__btCollisionWorld_ClosestRayResultCallback_Get_m_flags(_Underlying *_this);
                    return *__btCollisionWorld_ClosestRayResultCallback_Get_m_flags(_UnderlyingPtr);
                }
            }

            internal unsafe Const_ClosestRayResultCallback(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
            public unsafe Const_ClosestRayResultCallback(Bullet.BtCollisionWorld._ByValue_ClosestRayResultCallback _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestRayResultCallback._Underlying *__btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld.ClosestRayResultCallback._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
            public Const_ClosestRayResultCallback(Const_ClosestRayResultCallback _other) : this(new _ByValue_ClosestRayResultCallback(_other)) {}

            /// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
            public Const_ClosestRayResultCallback(ClosestRayResultCallback _other) : this((Const_ClosestRayResultCallback)_other) {}

            /// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
            public unsafe Const_ClosestRayResultCallback(Bullet.Const_BtVector3 rayFromWorld, Bullet.Const_BtVector3 rayToWorld) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestRayResultCallback._Underlying *__btCollisionWorld_ClosestRayResultCallback_Construct(Bullet.Const_BtVector3._Underlying *rayFromWorld, Bullet.Const_BtVector3._Underlying *rayToWorld);
                _UnderlyingPtr = __btCollisionWorld_ClosestRayResultCallback_Construct(rayFromWorld._UnderlyingPtr, rayToWorld._UnderlyingPtr);
            }

            /// Generated from method `btCollisionWorld::ClosestRayResultCallback::hasHit`.
            public unsafe bool HasHit()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __btCollisionWorld_ClosestRayResultCallback_hasHit(_Underlying *_this);
                return __btCollisionWorld_ClosestRayResultCallback_hasHit(_UnderlyingPtr) != 0;
            }
        }

        /// Generated from class `btCollisionWorld::ClosestRayResultCallback`.
        /// Base classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::RayResultCallback`
        /// This is the non-const half of the class.
        public class ClosestRayResultCallback : Const_ClosestRayResultCallback
        {
            // Upcasts:
            public static unsafe implicit operator Bullet.BtCollisionWorld.RayResultCallback(ClosestRayResultCallback self)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.RayResultCallback._Underlying *__btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(_Underlying *_this);
                Bullet.BtCollisionWorld.RayResultCallback ret = new(__btCollisionWorld_ClosestRayResultCallback_UpcastTo_btCollisionWorld_RayResultCallback(self._UnderlyingPtr), is_owning: false);
                ret._KeepAliveEnclosingObject = self;
                return ret;
            }

            // Downcasts:
            public static unsafe explicit operator ClosestRayResultCallback?(Bullet.BtCollisionWorld.RayResultCallback parent)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static _Underlying *__btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(Bullet.BtCollisionWorld.RayResultCallback._Underlying *_this);
                var ptr = __btCollisionWorld_ClosestRayResultCallback_DynamicDowncastFrom_btCollisionWorld_RayResultCallback(parent._UnderlyingPtr);
                if (ptr is null) return null;
                ClosestRayResultCallback ret = new(ptr, is_owning: false);
                ret._KeepAliveEnclosingObject = parent;
                return ret;
            }

            //used to calculate hitPointWorld from hitFraction
            public new unsafe Bullet.BtVector3 mRayFromWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayFromWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayFromWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayFromWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.BtVector3 mRayToWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayToWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayToWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_rayToWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.BtVector3 mHitNormalWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitNormalWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitNormalWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitNormalWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitNormalWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.BtVector3 mHitPointWorld
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitPointWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitPointWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitPointWorld(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_hitPointWorld(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe ref double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_closestHitFraction(_Underlying *_this);
                    return ref *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public new unsafe Bullet.Const_BtCollisionObject? mCollisionObject
            {
                get => base.mCollisionObject;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionObject(ClosestRayResultCallback._Underlying *_this);
                    var ptr = __btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionObject(_UnderlyingPtr);
                    _DiscardKeepAlive("m_collisionObject");
                    if (value is not null)
                        _KeepAlive(value, "m_collisionObject");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe ref int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterGroup(_Underlying *_this);
                    return ref *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterMask(_Underlying *_this);
                    return ref *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            //@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
            public new unsafe ref uint mFlags
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_GetMutable_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_flags(_Underlying *_this);
                    return ref *__btCollisionWorld_ClosestRayResultCallback_GetMutable_m_flags(_UnderlyingPtr);
                }
            }

            internal unsafe ClosestRayResultCallback(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
            public unsafe ClosestRayResultCallback(Bullet.BtCollisionWorld._ByValue_ClosestRayResultCallback _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestRayResultCallback._Underlying *__btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld.ClosestRayResultCallback._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_ClosestRayResultCallback_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
            public ClosestRayResultCallback(Const_ClosestRayResultCallback _other) : this(new _ByValue_ClosestRayResultCallback(_other)) {}

            /// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
            public ClosestRayResultCallback(ClosestRayResultCallback _other) : this((Const_ClosestRayResultCallback)_other) {}

            /// Generated from constructor `btCollisionWorld::ClosestRayResultCallback::ClosestRayResultCallback`.
            public unsafe ClosestRayResultCallback(Bullet.Const_BtVector3 rayFromWorld, Bullet.Const_BtVector3 rayToWorld) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestRayResultCallback._Underlying *__btCollisionWorld_ClosestRayResultCallback_Construct(Bullet.Const_BtVector3._Underlying *rayFromWorld, Bullet.Const_BtVector3._Underlying *rayToWorld);
                _UnderlyingPtr = __btCollisionWorld_ClosestRayResultCallback_Construct(rayFromWorld._UnderlyingPtr, rayToWorld._UnderlyingPtr);
            }

            /// Generated from method `btCollisionWorld::ClosestRayResultCallback::operator=`.
            public unsafe Bullet.BtCollisionWorld.ClosestRayResultCallback Assign(Bullet.BtCollisionWorld._ByValue_ClosestRayResultCallback _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.ClosestRayResultCallback._Underlying *__btCollisionWorld_ClosestRayResultCallback_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld.ClosestRayResultCallback._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__btCollisionWorld_ClosestRayResultCallback_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }

            /// Generated from method `btCollisionWorld::ClosestRayResultCallback::addSingleResult`.
            public unsafe double AddSingleResult(Bullet.BtCollisionWorld.LocalRayResult rayResult, bool normalInWorldSpace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ClosestRayResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __btCollisionWorld_ClosestRayResultCallback_addSingleResult(_Underlying *_this, Bullet.BtCollisionWorld.LocalRayResult._Underlying *rayResult, byte normalInWorldSpace);
                return __btCollisionWorld_ClosestRayResultCallback_addSingleResult(_UnderlyingPtr, rayResult._UnderlyingPtr, normalInWorldSpace ? (byte)1 : (byte)0);
            }
        }

        /// This is used as a function parameter when the underlying function receives `ClosestRayResultCallback` by value.
        /// Usage:
        /// * Pass an instance of `ClosestRayResultCallback`/`Const_ClosestRayResultCallback` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_ClosestRayResultCallback
        {
            #pragma warning disable CS0649
            internal readonly Const_ClosestRayResultCallback? Value;
            #pragma warning restore CS0649
            internal readonly Bullet._PassBy PassByMode;
            public _ByValue_ClosestRayResultCallback(Const_ClosestRayResultCallback new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
            public static implicit operator _ByValue_ClosestRayResultCallback(Const_ClosestRayResultCallback arg) {return new(arg);}
            public _ByValue_ClosestRayResultCallback(Bullet._Moved<ClosestRayResultCallback> moved) {Value = moved.Value; PassByMode = Bullet._PassBy.move;}
            public static implicit operator _ByValue_ClosestRayResultCallback(Bullet._Moved<ClosestRayResultCallback> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `ClosestRayResultCallback` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_ClosestRayResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `ClosestRayResultCallback`/`Const_ClosestRayResultCallback` directly.
        public class _InOptMut_ClosestRayResultCallback
        {
            public ClosestRayResultCallback? Opt;

            public _InOptMut_ClosestRayResultCallback() {}
            public _InOptMut_ClosestRayResultCallback(ClosestRayResultCallback value) {Opt = value;}
            public static implicit operator _InOptMut_ClosestRayResultCallback(ClosestRayResultCallback value) {return new(value);}
        }

        /// This is used for optional parameters of class `ClosestRayResultCallback` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_ClosestRayResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `ClosestRayResultCallback`/`Const_ClosestRayResultCallback` to pass it to the function.
        public class _InOptConst_ClosestRayResultCallback
        {
            public Const_ClosestRayResultCallback? Opt;

            public _InOptConst_ClosestRayResultCallback() {}
            public _InOptConst_ClosestRayResultCallback(Const_ClosestRayResultCallback value) {Opt = value;}
            public static implicit operator _InOptConst_ClosestRayResultCallback(Const_ClosestRayResultCallback value) {return new(value);}
        }

        ///ContactResultCallback is used to report contact points
        /// Generated from class `btCollisionWorld::ContactResultCallback`.
        /// This is the const half of the class.
        public class Const_ContactResultCallback : Bullet.Object<Const_ContactResultCallback>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btCollisionWorld_ContactResultCallback_Destroy(_Underlying *_this);
                __btCollisionWorld_ContactResultCallback_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_ContactResultCallback() {Dispose(false);}

            public unsafe int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ContactResultCallback_Get_m_collisionFilterGroup(_Underlying *_this);
                    return *__btCollisionWorld_ContactResultCallback_Get_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public unsafe int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ContactResultCallback_Get_m_collisionFilterMask(_Underlying *_this);
                    return *__btCollisionWorld_ContactResultCallback_Get_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            public unsafe double mClosestDistanceThreshold
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_Get_m_closestDistanceThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_Get_m_closestDistanceThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_ContactResultCallback_Get_m_closestDistanceThreshold(_Underlying *_this);
                    return *__btCollisionWorld_ContactResultCallback_Get_m_closestDistanceThreshold(_UnderlyingPtr);
                }
            }

            internal unsafe Const_ContactResultCallback(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}
        }

        ///ContactResultCallback is used to report contact points
        /// Generated from class `btCollisionWorld::ContactResultCallback`.
        /// This is the non-const half of the class.
        public class ContactResultCallback : Const_ContactResultCallback
        {
            public new unsafe ref int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterGroup(_Underlying *_this);
                    return ref *__btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterMask(_Underlying *_this);
                    return ref *__btCollisionWorld_ContactResultCallback_GetMutable_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            public new unsafe ref double mClosestDistanceThreshold
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_GetMutable_m_closestDistanceThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ContactResultCallback_GetMutable_m_closestDistanceThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_ContactResultCallback_GetMutable_m_closestDistanceThreshold(_Underlying *_this);
                    return ref *__btCollisionWorld_ContactResultCallback_GetMutable_m_closestDistanceThreshold(_UnderlyingPtr);
                }
            }

            internal unsafe ContactResultCallback(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}
        }

        /// This is used for optional parameters of class `ContactResultCallback` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_ContactResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `ContactResultCallback`/`Const_ContactResultCallback` directly.
        public class _InOptMut_ContactResultCallback
        {
            public ContactResultCallback? Opt;

            public _InOptMut_ContactResultCallback() {}
            public _InOptMut_ContactResultCallback(ContactResultCallback value) {Opt = value;}
            public static implicit operator _InOptMut_ContactResultCallback(ContactResultCallback value) {return new(value);}
        }

        /// This is used for optional parameters of class `ContactResultCallback` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_ContactResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `ContactResultCallback`/`Const_ContactResultCallback` to pass it to the function.
        public class _InOptConst_ContactResultCallback
        {
            public Const_ContactResultCallback? Opt;

            public _InOptConst_ContactResultCallback() {}
            public _InOptConst_ContactResultCallback(Const_ContactResultCallback value) {Opt = value;}
            public static implicit operator _InOptConst_ContactResultCallback(Const_ContactResultCallback value) {return new(value);}
        }

        ///RayResultCallback is used to report new raycast results
        /// Generated from class `btCollisionWorld::ConvexResultCallback`.
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::ClosestConvexResultCallback`
        /// This is the const half of the class.
        public class Const_ConvexResultCallback : Bullet.Object<Const_ConvexResultCallback>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btCollisionWorld_ConvexResultCallback_Destroy(_Underlying *_this);
                __btCollisionWorld_ConvexResultCallback_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_ConvexResultCallback() {Dispose(false);}

            public unsafe double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_ConvexResultCallback_Get_m_closestHitFraction(_Underlying *_this);
                    return *__btCollisionWorld_ConvexResultCallback_Get_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public unsafe int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterGroup(_Underlying *_this);
                    return *__btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public unsafe int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterMask(_Underlying *_this);
                    return *__btCollisionWorld_ConvexResultCallback_Get_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            internal unsafe Const_ConvexResultCallback(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from method `btCollisionWorld::ConvexResultCallback::hasHit`.
            public unsafe bool HasHit()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __btCollisionWorld_ConvexResultCallback_hasHit(_Underlying *_this);
                return __btCollisionWorld_ConvexResultCallback_hasHit(_UnderlyingPtr) != 0;
            }
        }

        ///RayResultCallback is used to report new raycast results
        /// Generated from class `btCollisionWorld::ConvexResultCallback`.
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::ClosestConvexResultCallback`
        /// This is the non-const half of the class.
        public class ConvexResultCallback : Const_ConvexResultCallback
        {
            public new unsafe ref double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_ConvexResultCallback_GetMutable_m_closestHitFraction(_Underlying *_this);
                    return ref *__btCollisionWorld_ConvexResultCallback_GetMutable_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterGroup(_Underlying *_this);
                    return ref *__btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterMask(_Underlying *_this);
                    return ref *__btCollisionWorld_ConvexResultCallback_GetMutable_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            internal unsafe ConvexResultCallback(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from method `btCollisionWorld::ConvexResultCallback::addSingleResult`.
            public unsafe double AddSingleResult(Bullet.BtCollisionWorld.LocalConvexResult convexResult, bool normalInWorldSpace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConvexResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __btCollisionWorld_ConvexResultCallback_addSingleResult(_Underlying *_this, Bullet.BtCollisionWorld.LocalConvexResult._Underlying *convexResult, byte normalInWorldSpace);
                return __btCollisionWorld_ConvexResultCallback_addSingleResult(_UnderlyingPtr, convexResult._UnderlyingPtr, normalInWorldSpace ? (byte)1 : (byte)0);
            }
        }

        /// This is used for optional parameters of class `ConvexResultCallback` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_ConvexResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `ConvexResultCallback`/`Const_ConvexResultCallback` directly.
        public class _InOptMut_ConvexResultCallback
        {
            public ConvexResultCallback? Opt;

            public _InOptMut_ConvexResultCallback() {}
            public _InOptMut_ConvexResultCallback(ConvexResultCallback value) {Opt = value;}
            public static implicit operator _InOptMut_ConvexResultCallback(ConvexResultCallback value) {return new(value);}
        }

        /// This is used for optional parameters of class `ConvexResultCallback` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_ConvexResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `ConvexResultCallback`/`Const_ConvexResultCallback` to pass it to the function.
        public class _InOptConst_ConvexResultCallback
        {
            public Const_ConvexResultCallback? Opt;

            public _InOptConst_ConvexResultCallback() {}
            public _InOptConst_ConvexResultCallback(Const_ConvexResultCallback value) {Opt = value;}
            public static implicit operator _InOptConst_ConvexResultCallback(Const_ConvexResultCallback value) {return new(value);}
        }

        /// Generated from class `btCollisionWorld::LocalConvexResult`.
        /// This is the const half of the class.
        public class Const_LocalConvexResult : Bullet.Object<Const_LocalConvexResult>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btCollisionWorld_LocalConvexResult_Destroy(_Underlying *_this);
                __btCollisionWorld_LocalConvexResult_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_LocalConvexResult() {Dispose(false);}

            public unsafe Bullet.Const_BtCollisionObject? mHitCollisionObject
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_hitCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_hitCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_LocalConvexResult_Get_m_hitCollisionObject(Const_LocalConvexResult._Underlying *_this);
                    var ptr = __btCollisionWorld_LocalConvexResult_Get_m_hitCollisionObject(_UnderlyingPtr);
                    Bullet.Const_BtCollisionObject? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe Bullet.BtCollisionWorld.LocalShapeInfo? mLocalShapeInfo
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_localShapeInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_localShapeInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying **__btCollisionWorld_LocalConvexResult_Get_m_localShapeInfo(Const_LocalConvexResult._Underlying *_this);
                    var ptr = __btCollisionWorld_LocalConvexResult_Get_m_localShapeInfo(_UnderlyingPtr);
                    Bullet.BtCollisionWorld.LocalShapeInfo? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe Bullet.Const_BtVector3 mHitNormalLocal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_hitNormalLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_hitNormalLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_LocalConvexResult_Get_m_hitNormalLocal(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_LocalConvexResult_Get_m_hitNormalLocal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.Const_BtVector3 mHitPointLocal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_hitPointLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_hitPointLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_LocalConvexResult_Get_m_hitPointLocal(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_LocalConvexResult_Get_m_hitPointLocal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe double mHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_hitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Get_m_hitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_LocalConvexResult_Get_m_hitFraction(_Underlying *_this);
                    return *__btCollisionWorld_LocalConvexResult_Get_m_hitFraction(_UnderlyingPtr);
                }
            }

            internal unsafe Const_LocalConvexResult(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from constructor `btCollisionWorld::LocalConvexResult::LocalConvexResult`.
            public unsafe Const_LocalConvexResult(Bullet.BtCollisionWorld.Const_LocalConvexResult _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalConvexResult._Underlying *__btCollisionWorld_LocalConvexResult_ConstructFromAnother(Bullet.BtCollisionWorld.LocalConvexResult._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_LocalConvexResult_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btCollisionWorld::LocalConvexResult::LocalConvexResult`.
            public Const_LocalConvexResult(LocalConvexResult _other) : this((Const_LocalConvexResult)_other) {}

            /// Generated from constructor `btCollisionWorld::LocalConvexResult::LocalConvexResult`.
            public unsafe Const_LocalConvexResult(Bullet.Const_BtCollisionObject? hitCollisionObject, Bullet.BtCollisionWorld.LocalShapeInfo? localShapeInfo, Bullet.Const_BtVector3 hitNormalLocal, Bullet.Const_BtVector3 hitPointLocal, double hitFraction) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalConvexResult._Underlying *__btCollisionWorld_LocalConvexResult_Construct(Bullet.Const_BtCollisionObject._Underlying *hitCollisionObject, Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *localShapeInfo, Bullet.Const_BtVector3._Underlying *hitNormalLocal, Bullet.Const_BtVector3._Underlying *hitPointLocal, double hitFraction);
                _UnderlyingPtr = __btCollisionWorld_LocalConvexResult_Construct(hitCollisionObject is not null ? hitCollisionObject._UnderlyingPtr : null, localShapeInfo is not null ? localShapeInfo._UnderlyingPtr : null, hitNormalLocal._UnderlyingPtr, hitPointLocal._UnderlyingPtr, hitFraction);
            }
        }

        /// Generated from class `btCollisionWorld::LocalConvexResult`.
        /// This is the non-const half of the class.
        public class LocalConvexResult : Const_LocalConvexResult
        {
            public new unsafe Bullet.Const_BtCollisionObject? mHitCollisionObject
            {
                get => base.mHitCollisionObject;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_hitCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_hitCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_LocalConvexResult_GetMutable_m_hitCollisionObject(LocalConvexResult._Underlying *_this);
                    var ptr = __btCollisionWorld_LocalConvexResult_GetMutable_m_hitCollisionObject(_UnderlyingPtr);
                    _DiscardKeepAlive("m_hitCollisionObject");
                    if (value is not null)
                        _KeepAlive(value, "m_hitCollisionObject");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe Bullet.BtCollisionWorld.LocalShapeInfo? mLocalShapeInfo
            {
                get => base.mLocalShapeInfo;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_localShapeInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_localShapeInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying **__btCollisionWorld_LocalConvexResult_GetMutable_m_localShapeInfo(LocalConvexResult._Underlying *_this);
                    var ptr = __btCollisionWorld_LocalConvexResult_GetMutable_m_localShapeInfo(_UnderlyingPtr);
                    _DiscardKeepAlive("m_localShapeInfo");
                    if (value is not null)
                        _KeepAlive(value, "m_localShapeInfo");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe Bullet.BtVector3 mHitNormalLocal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_hitNormalLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_hitNormalLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_LocalConvexResult_GetMutable_m_hitNormalLocal(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_LocalConvexResult_GetMutable_m_hitNormalLocal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.BtVector3 mHitPointLocal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_hitPointLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_hitPointLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_LocalConvexResult_GetMutable_m_hitPointLocal(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_LocalConvexResult_GetMutable_m_hitPointLocal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe ref double mHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_hitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_GetMutable_m_hitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_LocalConvexResult_GetMutable_m_hitFraction(_Underlying *_this);
                    return ref *__btCollisionWorld_LocalConvexResult_GetMutable_m_hitFraction(_UnderlyingPtr);
                }
            }

            internal unsafe LocalConvexResult(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from constructor `btCollisionWorld::LocalConvexResult::LocalConvexResult`.
            public unsafe LocalConvexResult(Bullet.BtCollisionWorld.Const_LocalConvexResult _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalConvexResult._Underlying *__btCollisionWorld_LocalConvexResult_ConstructFromAnother(Bullet.BtCollisionWorld.LocalConvexResult._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_LocalConvexResult_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btCollisionWorld::LocalConvexResult::LocalConvexResult`.
            public LocalConvexResult(LocalConvexResult _other) : this((Const_LocalConvexResult)_other) {}

            /// Generated from constructor `btCollisionWorld::LocalConvexResult::LocalConvexResult`.
            public unsafe LocalConvexResult(Bullet.Const_BtCollisionObject? hitCollisionObject, Bullet.BtCollisionWorld.LocalShapeInfo? localShapeInfo, Bullet.Const_BtVector3 hitNormalLocal, Bullet.Const_BtVector3 hitPointLocal, double hitFraction) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalConvexResult._Underlying *__btCollisionWorld_LocalConvexResult_Construct(Bullet.Const_BtCollisionObject._Underlying *hitCollisionObject, Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *localShapeInfo, Bullet.Const_BtVector3._Underlying *hitNormalLocal, Bullet.Const_BtVector3._Underlying *hitPointLocal, double hitFraction);
                _UnderlyingPtr = __btCollisionWorld_LocalConvexResult_Construct(hitCollisionObject is not null ? hitCollisionObject._UnderlyingPtr : null, localShapeInfo is not null ? localShapeInfo._UnderlyingPtr : null, hitNormalLocal._UnderlyingPtr, hitPointLocal._UnderlyingPtr, hitFraction);
            }

            /// Generated from method `btCollisionWorld::LocalConvexResult::operator=`.
            public unsafe Bullet.BtCollisionWorld.LocalConvexResult Assign(Bullet.BtCollisionWorld.Const_LocalConvexResult _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalConvexResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalConvexResult._Underlying *__btCollisionWorld_LocalConvexResult_AssignFromAnother(_Underlying *_this, Bullet.BtCollisionWorld.LocalConvexResult._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__btCollisionWorld_LocalConvexResult_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `LocalConvexResult` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_LocalConvexResult`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LocalConvexResult`/`Const_LocalConvexResult` directly.
        public class _InOptMut_LocalConvexResult
        {
            public LocalConvexResult? Opt;

            public _InOptMut_LocalConvexResult() {}
            public _InOptMut_LocalConvexResult(LocalConvexResult value) {Opt = value;}
            public static implicit operator _InOptMut_LocalConvexResult(LocalConvexResult value) {return new(value);}
        }

        /// This is used for optional parameters of class `LocalConvexResult` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_LocalConvexResult`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LocalConvexResult`/`Const_LocalConvexResult` to pass it to the function.
        public class _InOptConst_LocalConvexResult
        {
            public Const_LocalConvexResult? Opt;

            public _InOptConst_LocalConvexResult() {}
            public _InOptConst_LocalConvexResult(Const_LocalConvexResult value) {Opt = value;}
            public static implicit operator _InOptConst_LocalConvexResult(Const_LocalConvexResult value) {return new(value);}
        }

        /// Generated from class `btCollisionWorld::LocalRayResult`.
        /// This is the const half of the class.
        public class Const_LocalRayResult : Bullet.Object<Const_LocalRayResult>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btCollisionWorld_LocalRayResult_Destroy(_Underlying *_this);
                __btCollisionWorld_LocalRayResult_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_LocalRayResult() {Dispose(false);}

            public unsafe Bullet.Const_BtCollisionObject? mCollisionObject
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Get_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Get_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_LocalRayResult_Get_m_collisionObject(Const_LocalRayResult._Underlying *_this);
                    var ptr = __btCollisionWorld_LocalRayResult_Get_m_collisionObject(_UnderlyingPtr);
                    Bullet.Const_BtCollisionObject? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe Bullet.BtCollisionWorld.LocalShapeInfo? mLocalShapeInfo
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Get_m_localShapeInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Get_m_localShapeInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying **__btCollisionWorld_LocalRayResult_Get_m_localShapeInfo(Const_LocalRayResult._Underlying *_this);
                    var ptr = __btCollisionWorld_LocalRayResult_Get_m_localShapeInfo(_UnderlyingPtr);
                    Bullet.BtCollisionWorld.LocalShapeInfo? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe Bullet.Const_BtVector3 mHitNormalLocal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Get_m_hitNormalLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Get_m_hitNormalLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btCollisionWorld_LocalRayResult_Get_m_hitNormalLocal(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btCollisionWorld_LocalRayResult_Get_m_hitNormalLocal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe double mHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Get_m_hitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Get_m_hitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_LocalRayResult_Get_m_hitFraction(_Underlying *_this);
                    return *__btCollisionWorld_LocalRayResult_Get_m_hitFraction(_UnderlyingPtr);
                }
            }

            internal unsafe Const_LocalRayResult(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from constructor `btCollisionWorld::LocalRayResult::LocalRayResult`.
            public unsafe Const_LocalRayResult(Bullet.BtCollisionWorld.Const_LocalRayResult _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalRayResult._Underlying *__btCollisionWorld_LocalRayResult_ConstructFromAnother(Bullet.BtCollisionWorld.LocalRayResult._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_LocalRayResult_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btCollisionWorld::LocalRayResult::LocalRayResult`.
            public Const_LocalRayResult(LocalRayResult _other) : this((Const_LocalRayResult)_other) {}

            /// Generated from constructor `btCollisionWorld::LocalRayResult::LocalRayResult`.
            public unsafe Const_LocalRayResult(Bullet.Const_BtCollisionObject? collisionObject, Bullet.BtCollisionWorld.LocalShapeInfo? localShapeInfo, Bullet.Const_BtVector3 hitNormalLocal, double hitFraction) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalRayResult._Underlying *__btCollisionWorld_LocalRayResult_Construct(Bullet.Const_BtCollisionObject._Underlying *collisionObject, Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *localShapeInfo, Bullet.Const_BtVector3._Underlying *hitNormalLocal, double hitFraction);
                _UnderlyingPtr = __btCollisionWorld_LocalRayResult_Construct(collisionObject is not null ? collisionObject._UnderlyingPtr : null, localShapeInfo is not null ? localShapeInfo._UnderlyingPtr : null, hitNormalLocal._UnderlyingPtr, hitFraction);
            }
        }

        /// Generated from class `btCollisionWorld::LocalRayResult`.
        /// This is the non-const half of the class.
        public class LocalRayResult : Const_LocalRayResult
        {
            public new unsafe Bullet.Const_BtCollisionObject? mCollisionObject
            {
                get => base.mCollisionObject;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_GetMutable_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_GetMutable_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_LocalRayResult_GetMutable_m_collisionObject(LocalRayResult._Underlying *_this);
                    var ptr = __btCollisionWorld_LocalRayResult_GetMutable_m_collisionObject(_UnderlyingPtr);
                    _DiscardKeepAlive("m_collisionObject");
                    if (value is not null)
                        _KeepAlive(value, "m_collisionObject");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe Bullet.BtCollisionWorld.LocalShapeInfo? mLocalShapeInfo
            {
                get => base.mLocalShapeInfo;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_GetMutable_m_localShapeInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_GetMutable_m_localShapeInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying **__btCollisionWorld_LocalRayResult_GetMutable_m_localShapeInfo(LocalRayResult._Underlying *_this);
                    var ptr = __btCollisionWorld_LocalRayResult_GetMutable_m_localShapeInfo(_UnderlyingPtr);
                    _DiscardKeepAlive("m_localShapeInfo");
                    if (value is not null)
                        _KeepAlive(value, "m_localShapeInfo");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe Bullet.BtVector3 mHitNormalLocal
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_GetMutable_m_hitNormalLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_GetMutable_m_hitNormalLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btCollisionWorld_LocalRayResult_GetMutable_m_hitNormalLocal(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btCollisionWorld_LocalRayResult_GetMutable_m_hitNormalLocal(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe ref double mHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_GetMutable_m_hitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_GetMutable_m_hitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_LocalRayResult_GetMutable_m_hitFraction(_Underlying *_this);
                    return ref *__btCollisionWorld_LocalRayResult_GetMutable_m_hitFraction(_UnderlyingPtr);
                }
            }

            internal unsafe LocalRayResult(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from constructor `btCollisionWorld::LocalRayResult::LocalRayResult`.
            public unsafe LocalRayResult(Bullet.BtCollisionWorld.Const_LocalRayResult _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalRayResult._Underlying *__btCollisionWorld_LocalRayResult_ConstructFromAnother(Bullet.BtCollisionWorld.LocalRayResult._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_LocalRayResult_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btCollisionWorld::LocalRayResult::LocalRayResult`.
            public LocalRayResult(LocalRayResult _other) : this((Const_LocalRayResult)_other) {}

            /// Generated from constructor `btCollisionWorld::LocalRayResult::LocalRayResult`.
            public unsafe LocalRayResult(Bullet.Const_BtCollisionObject? collisionObject, Bullet.BtCollisionWorld.LocalShapeInfo? localShapeInfo, Bullet.Const_BtVector3 hitNormalLocal, double hitFraction) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalRayResult._Underlying *__btCollisionWorld_LocalRayResult_Construct(Bullet.Const_BtCollisionObject._Underlying *collisionObject, Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *localShapeInfo, Bullet.Const_BtVector3._Underlying *hitNormalLocal, double hitFraction);
                _UnderlyingPtr = __btCollisionWorld_LocalRayResult_Construct(collisionObject is not null ? collisionObject._UnderlyingPtr : null, localShapeInfo is not null ? localShapeInfo._UnderlyingPtr : null, hitNormalLocal._UnderlyingPtr, hitFraction);
            }

            /// Generated from method `btCollisionWorld::LocalRayResult::operator=`.
            public unsafe Bullet.BtCollisionWorld.LocalRayResult Assign(Bullet.BtCollisionWorld.Const_LocalRayResult _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalRayResult_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalRayResult._Underlying *__btCollisionWorld_LocalRayResult_AssignFromAnother(_Underlying *_this, Bullet.BtCollisionWorld.LocalRayResult._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__btCollisionWorld_LocalRayResult_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `LocalRayResult` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_LocalRayResult`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LocalRayResult`/`Const_LocalRayResult` directly.
        public class _InOptMut_LocalRayResult
        {
            public LocalRayResult? Opt;

            public _InOptMut_LocalRayResult() {}
            public _InOptMut_LocalRayResult(LocalRayResult value) {Opt = value;}
            public static implicit operator _InOptMut_LocalRayResult(LocalRayResult value) {return new(value);}
        }

        /// This is used for optional parameters of class `LocalRayResult` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_LocalRayResult`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LocalRayResult`/`Const_LocalRayResult` to pass it to the function.
        public class _InOptConst_LocalRayResult
        {
            public Const_LocalRayResult? Opt;

            public _InOptConst_LocalRayResult() {}
            public _InOptConst_LocalRayResult(Const_LocalRayResult value) {Opt = value;}
            public static implicit operator _InOptConst_LocalRayResult(Const_LocalRayResult value) {return new(value);}
        }

        ///LocalShapeInfo gives extra information for complex shapes
        ///Currently, only btTriangleMeshShape is available, so it just contains triangleIndex and subpart
        /// Generated from class `btCollisionWorld::LocalShapeInfo`.
        /// This is the const half of the class.
        public class Const_LocalShapeInfo : Bullet.Object<Const_LocalShapeInfo>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btCollisionWorld_LocalShapeInfo_Destroy(_Underlying *_this);
                __btCollisionWorld_LocalShapeInfo_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_LocalShapeInfo() {Dispose(false);}

            public unsafe int mShapePart
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_Get_m_shapePart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_Get_m_shapePart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_LocalShapeInfo_Get_m_shapePart(_Underlying *_this);
                    return *__btCollisionWorld_LocalShapeInfo_Get_m_shapePart(_UnderlyingPtr);
                }
            }

            public unsafe int mTriangleIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_Get_m_triangleIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_Get_m_triangleIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_LocalShapeInfo_Get_m_triangleIndex(_Underlying *_this);
                    return *__btCollisionWorld_LocalShapeInfo_Get_m_triangleIndex(_UnderlyingPtr);
                }
            }

            internal unsafe Const_LocalShapeInfo(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Constructs an empty (default-constructed) instance.
            public unsafe Const_LocalShapeInfo() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *__btCollisionWorld_LocalShapeInfo_DefaultConstruct();
                _UnderlyingPtr = __btCollisionWorld_LocalShapeInfo_DefaultConstruct();
            }

            /// Constructs `btCollisionWorld::LocalShapeInfo` elementwise.
            public unsafe Const_LocalShapeInfo(int m_shapePart, int m_triangleIndex) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *__btCollisionWorld_LocalShapeInfo_ConstructFrom(int m_shapePart, int m_triangleIndex);
                _UnderlyingPtr = __btCollisionWorld_LocalShapeInfo_ConstructFrom(m_shapePart, m_triangleIndex);
            }

            /// Generated from constructor `btCollisionWorld::LocalShapeInfo::LocalShapeInfo`.
            public unsafe Const_LocalShapeInfo(Bullet.BtCollisionWorld.Const_LocalShapeInfo _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *__btCollisionWorld_LocalShapeInfo_ConstructFromAnother(Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_LocalShapeInfo_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btCollisionWorld::LocalShapeInfo::LocalShapeInfo`.
            public Const_LocalShapeInfo(LocalShapeInfo _other) : this((Const_LocalShapeInfo)_other) {}
        }

        ///LocalShapeInfo gives extra information for complex shapes
        ///Currently, only btTriangleMeshShape is available, so it just contains triangleIndex and subpart
        /// Generated from class `btCollisionWorld::LocalShapeInfo`.
        /// This is the non-const half of the class.
        public class LocalShapeInfo : Const_LocalShapeInfo
        {
            public new unsafe ref int mShapePart
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_GetMutable_m_shapePart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_GetMutable_m_shapePart", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_LocalShapeInfo_GetMutable_m_shapePart(_Underlying *_this);
                    return ref *__btCollisionWorld_LocalShapeInfo_GetMutable_m_shapePart(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mTriangleIndex
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_GetMutable_m_triangleIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_GetMutable_m_triangleIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_LocalShapeInfo_GetMutable_m_triangleIndex(_Underlying *_this);
                    return ref *__btCollisionWorld_LocalShapeInfo_GetMutable_m_triangleIndex(_UnderlyingPtr);
                }
            }

            internal unsafe LocalShapeInfo(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Constructs an empty (default-constructed) instance.
            public unsafe LocalShapeInfo() : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *__btCollisionWorld_LocalShapeInfo_DefaultConstruct();
                _UnderlyingPtr = __btCollisionWorld_LocalShapeInfo_DefaultConstruct();
            }

            /// Constructs `btCollisionWorld::LocalShapeInfo` elementwise.
            public unsafe LocalShapeInfo(int m_shapePart, int m_triangleIndex) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_ConstructFrom", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *__btCollisionWorld_LocalShapeInfo_ConstructFrom(int m_shapePart, int m_triangleIndex);
                _UnderlyingPtr = __btCollisionWorld_LocalShapeInfo_ConstructFrom(m_shapePart, m_triangleIndex);
            }

            /// Generated from constructor `btCollisionWorld::LocalShapeInfo::LocalShapeInfo`.
            public unsafe LocalShapeInfo(Bullet.BtCollisionWorld.Const_LocalShapeInfo _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *__btCollisionWorld_LocalShapeInfo_ConstructFromAnother(Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *_other);
                _UnderlyingPtr = __btCollisionWorld_LocalShapeInfo_ConstructFromAnother(_other._UnderlyingPtr);
                _KeepAlive(_other);
            }

            /// Generated from constructor `btCollisionWorld::LocalShapeInfo::LocalShapeInfo`.
            public LocalShapeInfo(LocalShapeInfo _other) : this((Const_LocalShapeInfo)_other) {}

            /// Generated from method `btCollisionWorld::LocalShapeInfo::operator=`.
            public unsafe Bullet.BtCollisionWorld.LocalShapeInfo Assign(Bullet.BtCollisionWorld.Const_LocalShapeInfo _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_LocalShapeInfo_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *__btCollisionWorld_LocalShapeInfo_AssignFromAnother(_Underlying *_this, Bullet.BtCollisionWorld.LocalShapeInfo._Underlying *_other);
                _DiscardKeepAlive();
                _KeepAlive(_other);
                return new(__btCollisionWorld_LocalShapeInfo_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
            }
        }

        /// This is used for optional parameters of class `LocalShapeInfo` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_LocalShapeInfo`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LocalShapeInfo`/`Const_LocalShapeInfo` directly.
        public class _InOptMut_LocalShapeInfo
        {
            public LocalShapeInfo? Opt;

            public _InOptMut_LocalShapeInfo() {}
            public _InOptMut_LocalShapeInfo(LocalShapeInfo value) {Opt = value;}
            public static implicit operator _InOptMut_LocalShapeInfo(LocalShapeInfo value) {return new(value);}
        }

        /// This is used for optional parameters of class `LocalShapeInfo` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_LocalShapeInfo`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `LocalShapeInfo`/`Const_LocalShapeInfo` to pass it to the function.
        public class _InOptConst_LocalShapeInfo
        {
            public Const_LocalShapeInfo? Opt;

            public _InOptConst_LocalShapeInfo() {}
            public _InOptConst_LocalShapeInfo(Const_LocalShapeInfo value) {Opt = value;}
            public static implicit operator _InOptConst_LocalShapeInfo(Const_LocalShapeInfo value) {return new(value);}
        }

        ///RayResultCallback is used to report new raycast results
        /// Generated from class `btCollisionWorld::RayResultCallback`.
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::AllHitsRayResultCallback`
        ///     `btCollisionWorld::ClosestRayResultCallback`
        /// This is the const half of the class.
        public class Const_RayResultCallback : Bullet.Object<Const_RayResultCallback>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btCollisionWorld_RayResultCallback_Destroy(_Underlying *_this);
                __btCollisionWorld_RayResultCallback_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_RayResultCallback() {Dispose(false);}

            public unsafe double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_RayResultCallback_Get_m_closestHitFraction(_Underlying *_this);
                    return *__btCollisionWorld_RayResultCallback_Get_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public unsafe Bullet.Const_BtCollisionObject? mCollisionObject
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_RayResultCallback_Get_m_collisionObject(Const_RayResultCallback._Underlying *_this);
                    var ptr = __btCollisionWorld_RayResultCallback_Get_m_collisionObject(_UnderlyingPtr);
                    Bullet.Const_BtCollisionObject? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_RayResultCallback_Get_m_collisionFilterGroup(_Underlying *_this);
                    return *__btCollisionWorld_RayResultCallback_Get_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public unsafe int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_RayResultCallback_Get_m_collisionFilterMask(_Underlying *_this);
                    return *__btCollisionWorld_RayResultCallback_Get_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            //@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
            public unsafe uint mFlags
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_Get_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__btCollisionWorld_RayResultCallback_Get_m_flags(_Underlying *_this);
                    return *__btCollisionWorld_RayResultCallback_Get_m_flags(_UnderlyingPtr);
                }
            }

            internal unsafe Const_RayResultCallback(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from method `btCollisionWorld::RayResultCallback::hasHit`.
            public unsafe bool HasHit()
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_hasHit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static byte __btCollisionWorld_RayResultCallback_hasHit(_Underlying *_this);
                return __btCollisionWorld_RayResultCallback_hasHit(_UnderlyingPtr) != 0;
            }
        }

        ///RayResultCallback is used to report new raycast results
        /// Generated from class `btCollisionWorld::RayResultCallback`.
        /// Derived classes:
        ///   Direct: (non-virtual)
        ///     `btCollisionWorld::AllHitsRayResultCallback`
        ///     `btCollisionWorld::ClosestRayResultCallback`
        /// This is the non-const half of the class.
        public class RayResultCallback : Const_RayResultCallback
        {
            public new unsafe ref double mClosestHitFraction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_closestHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btCollisionWorld_RayResultCallback_GetMutable_m_closestHitFraction(_Underlying *_this);
                    return ref *__btCollisionWorld_RayResultCallback_GetMutable_m_closestHitFraction(_UnderlyingPtr);
                }
            }

            public new unsafe Bullet.Const_BtCollisionObject? mCollisionObject
            {
                get => base.mCollisionObject;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_collisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtCollisionObject._Underlying **__btCollisionWorld_RayResultCallback_GetMutable_m_collisionObject(RayResultCallback._Underlying *_this);
                    var ptr = __btCollisionWorld_RayResultCallback_GetMutable_m_collisionObject(_UnderlyingPtr);
                    _DiscardKeepAlive("m_collisionObject");
                    if (value is not null)
                        _KeepAlive(value, "m_collisionObject");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe ref int mCollisionFilterGroup
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterGroup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterGroup(_Underlying *_this);
                    return ref *__btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterGroup(_UnderlyingPtr);
                }
            }

            public new unsafe ref int mCollisionFilterMask
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterMask", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static int *__btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterMask(_Underlying *_this);
                    return ref *__btCollisionWorld_RayResultCallback_GetMutable_m_collisionFilterMask(_UnderlyingPtr);
                }
            }

            //@BP Mod - Custom flags, currently used to enable backface culling on tri-meshes, see btRaycastCallback.h. Apply any of the EFlags defined there on m_flags here to invoke.
            public new unsafe ref uint mFlags
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_GetMutable_m_flags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static uint *__btCollisionWorld_RayResultCallback_GetMutable_m_flags(_Underlying *_this);
                    return ref *__btCollisionWorld_RayResultCallback_GetMutable_m_flags(_UnderlyingPtr);
                }
            }

            internal unsafe RayResultCallback(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from method `btCollisionWorld::RayResultCallback::addSingleResult`.
            public unsafe double AddSingleResult(Bullet.BtCollisionWorld.LocalRayResult rayResult, bool normalInWorldSpace)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_RayResultCallback_addSingleResult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double __btCollisionWorld_RayResultCallback_addSingleResult(_Underlying *_this, Bullet.BtCollisionWorld.LocalRayResult._Underlying *rayResult, byte normalInWorldSpace);
                return __btCollisionWorld_RayResultCallback_addSingleResult(_UnderlyingPtr, rayResult._UnderlyingPtr, normalInWorldSpace ? (byte)1 : (byte)0);
            }
        }

        /// This is used for optional parameters of class `RayResultCallback` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_RayResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RayResultCallback`/`Const_RayResultCallback` directly.
        public class _InOptMut_RayResultCallback
        {
            public RayResultCallback? Opt;

            public _InOptMut_RayResultCallback() {}
            public _InOptMut_RayResultCallback(RayResultCallback value) {Opt = value;}
            public static implicit operator _InOptMut_RayResultCallback(RayResultCallback value) {return new(value);}
        }

        /// This is used for optional parameters of class `RayResultCallback` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_RayResultCallback`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `RayResultCallback`/`Const_RayResultCallback` to pass it to the function.
        public class _InOptConst_RayResultCallback
        {
            public Const_RayResultCallback? Opt;

            public _InOptConst_RayResultCallback() {}
            public _InOptConst_RayResultCallback(Const_RayResultCallback value) {Opt = value;}
            public static implicit operator _InOptConst_RayResultCallback(Const_RayResultCallback value) {return new(value);}
        }
    }

    ///CollisionWorld is interface and container for the collision detection
    /// Generated from class `btCollisionWorld`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDynamicsWorld`
    ///   Indirect: (non-virtual)
    ///     `btDiscreteDynamicsWorld`
    /// This is the non-const half of the class.
    public class BtCollisionWorld : Const_BtCollisionWorld
    {
        internal unsafe BtCollisionWorld(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btCollisionWorld::btCollisionWorld`.
        public unsafe BtCollisionWorld(Bullet._ByValue_BtCollisionWorld _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btCollisionWorld_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld._Underlying *_other);
            _UnderlyingPtr = __btCollisionWorld_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCollisionWorld::btCollisionWorld`.
        public BtCollisionWorld(Const_BtCollisionWorld _other) : this(new _ByValue_BtCollisionWorld(_other)) {}

        /// Generated from constructor `btCollisionWorld::btCollisionWorld`.
        public BtCollisionWorld(BtCollisionWorld _other) : this((Const_BtCollisionWorld)_other) {}

        //this constructor doesn't own the dispatcher and paircache/broadphase
        /// Generated from constructor `btCollisionWorld::btCollisionWorld`.
        public unsafe BtCollisionWorld(Bullet.BtDispatcher? dispatcher, Bullet.BtBroadphaseInterface? broadphasePairCache, Bullet.BtCollisionConfiguration? collisionConfiguration) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btCollisionWorld_Construct(Bullet.BtDispatcher._Underlying *dispatcher, Bullet.BtBroadphaseInterface._Underlying *broadphasePairCache, Bullet.BtCollisionConfiguration._Underlying *collisionConfiguration);
            _UnderlyingPtr = __btCollisionWorld_Construct(dispatcher is not null ? dispatcher._UnderlyingPtr : null, broadphasePairCache is not null ? broadphasePairCache._UnderlyingPtr : null, collisionConfiguration is not null ? collisionConfiguration._UnderlyingPtr : null);
        }

        /// Generated from method `btCollisionWorld::operator=`.
        public unsafe Bullet.BtCollisionWorld Assign(Bullet._ByValue_BtCollisionWorld _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btCollisionWorld_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtCollisionWorld._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btCollisionWorld_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btCollisionWorld::setBroadphase`.
        public unsafe void SetBroadphase(Bullet.BtBroadphaseInterface? pairCache)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_setBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_setBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_setBroadphase(_Underlying *_this, Bullet.BtBroadphaseInterface._Underlying *pairCache);
            __btCollisionWorld_setBroadphase(_UnderlyingPtr, pairCache is not null ? pairCache._UnderlyingPtr : null);
        }

        /// Generated from method `btCollisionWorld::getBroadphase`.
        public unsafe new Bullet.BtBroadphaseInterface? GetBroadphase()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_getBroadphase_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_getBroadphase_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtBroadphaseInterface._Underlying *__btCollisionWorld_getBroadphase_mut(_Underlying *_this);
            var __c_ret = __btCollisionWorld_getBroadphase_mut(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtBroadphaseInterface(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btCollisionWorld::getPairCache`.
        public unsafe Bullet.BtOverlappingPairCache? GetPairCache()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_getPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_getPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtOverlappingPairCache._Underlying *__btCollisionWorld_getPairCache(_Underlying *_this);
            var __c_ret = __btCollisionWorld_getPairCache(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtOverlappingPairCache(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btCollisionWorld::getDispatcher`.
        public unsafe new Bullet.BtDispatcher? GetDispatcher()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_getDispatcher_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_getDispatcher_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDispatcher._Underlying *__btCollisionWorld_getDispatcher_mut(_Underlying *_this);
            var __c_ret = __btCollisionWorld_getDispatcher_mut(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtDispatcher(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btCollisionWorld::updateSingleAabb`.
        public unsafe void UpdateSingleAabb(Bullet.BtCollisionObject? colObj)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_updateSingleAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_updateSingleAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_updateSingleAabb(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObj);
            __btCollisionWorld_updateSingleAabb(_UnderlyingPtr, colObj is not null ? colObj._UnderlyingPtr : null);
        }

        /// Generated from method `btCollisionWorld::updateAabbs`.
        public unsafe void UpdateAabbs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_updateAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_updateAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_updateAabbs(_Underlying *_this);
            __btCollisionWorld_updateAabbs(_UnderlyingPtr);
        }

        ///the computeOverlappingPairs is usually already called by performDiscreteCollisionDetection (or stepSimulation)
        ///it can be useful to use if you perform ray tests without collision detection/simulation
        /// Generated from method `btCollisionWorld::computeOverlappingPairs`.
        public unsafe void ComputeOverlappingPairs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_computeOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_computeOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_computeOverlappingPairs(_Underlying *_this);
            __btCollisionWorld_computeOverlappingPairs(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionWorld::debugDrawWorld`.
        public unsafe void DebugDrawWorld()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_debugDrawWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_debugDrawWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_debugDrawWorld(_Underlying *_this);
            __btCollisionWorld_debugDrawWorld(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionWorld::debugDrawObject`.
        public unsafe void DebugDrawObject(Bullet.Const_BtTransform worldTransform, Bullet.Const_BtCollisionShape? shape, Bullet.Const_BtVector3 color)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_debugDrawObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_debugDrawObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_debugDrawObject(_Underlying *_this, Bullet.Const_BtTransform._Underlying *worldTransform, Bullet.Const_BtCollisionShape._Underlying *shape, Bullet.Const_BtVector3._Underlying *color);
            __btCollisionWorld_debugDrawObject(_UnderlyingPtr, worldTransform._UnderlyingPtr, shape is not null ? shape._UnderlyingPtr : null, color._UnderlyingPtr);
        }

        ///contactTest performs a discrete collision test between colObj against all objects in the btCollisionWorld, and calls the resultCallback.
        ///it reports one or more contact points for every overlapping object (including the one with deepest penetration)
        /// Generated from method `btCollisionWorld::contactTest`.
        public unsafe void ContactTest(Bullet.BtCollisionObject? colObj, Bullet.BtCollisionWorld.ContactResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_contactTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_contactTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_contactTest(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObj, Bullet.BtCollisionWorld.ContactResultCallback._Underlying *resultCallback);
            __btCollisionWorld_contactTest(_UnderlyingPtr, colObj is not null ? colObj._UnderlyingPtr : null, resultCallback._UnderlyingPtr);
        }

        ///contactTest performs a discrete collision test between two collision objects and calls the resultCallback if overlap if detected.
        ///it reports one or more contact points (including the one with deepest penetration)
        /// Generated from method `btCollisionWorld::contactPairTest`.
        public unsafe void ContactPairTest(Bullet.BtCollisionObject? colObjA, Bullet.BtCollisionObject? colObjB, Bullet.BtCollisionWorld.ContactResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_contactPairTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_contactPairTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_contactPairTest(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObjA, Bullet.BtCollisionObject._Underlying *colObjB, Bullet.BtCollisionWorld.ContactResultCallback._Underlying *resultCallback);
            __btCollisionWorld_contactPairTest(_UnderlyingPtr, colObjA is not null ? colObjA._UnderlyingPtr : null, colObjB is not null ? colObjB._UnderlyingPtr : null, resultCallback._UnderlyingPtr);
        }

        /// Generated from method `btCollisionWorld::addCollisionObject`.
        /// Parameter `collisionFilterGroup` defaults to `btBroadphaseProxy::DefaultFilter`.
        /// Parameter `collisionFilterMask` defaults to `btBroadphaseProxy::AllFilter`.
        public unsafe void AddCollisionObject(Bullet.BtCollisionObject? collisionObject, int? collisionFilterGroup = null, int? collisionFilterMask = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_addCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_addCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_addCollisionObject(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject, int *collisionFilterGroup, int *collisionFilterMask);
            int __deref_collisionFilterGroup = collisionFilterGroup.GetValueOrDefault();
            int __deref_collisionFilterMask = collisionFilterMask.GetValueOrDefault();
            __btCollisionWorld_addCollisionObject(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionFilterGroup.HasValue ? &__deref_collisionFilterGroup : null, collisionFilterMask.HasValue ? &__deref_collisionFilterMask : null);
        }

        /// Generated from method `btCollisionWorld::refreshBroadphaseProxy`.
        public unsafe void RefreshBroadphaseProxy(Bullet.BtCollisionObject? collisionObject)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_refreshBroadphaseProxy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_refreshBroadphaseProxy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_refreshBroadphaseProxy(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject);
            __btCollisionWorld_refreshBroadphaseProxy(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null);
        }

        /// Generated from method `btCollisionWorld::removeCollisionObject`.
        public unsafe void RemoveCollisionObject(Bullet.BtCollisionObject? collisionObject)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_removeCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_removeCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_removeCollisionObject(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject);
            __btCollisionWorld_removeCollisionObject(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null);
        }

        /// Generated from method `btCollisionWorld::performDiscreteCollisionDetection`.
        public unsafe void PerformDiscreteCollisionDetection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_performDiscreteCollisionDetection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_performDiscreteCollisionDetection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_performDiscreteCollisionDetection(_Underlying *_this);
            __btCollisionWorld_performDiscreteCollisionDetection(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionWorld::setForceUpdateAllAabbs`.
        public unsafe void SetForceUpdateAllAabbs(bool forceUpdateAllAabbs)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionWorld_setForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionWorld_setForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionWorld_setForceUpdateAllAabbs(_Underlying *_this, byte forceUpdateAllAabbs);
            __btCollisionWorld_setForceUpdateAllAabbs(_UnderlyingPtr, forceUpdateAllAabbs ? (byte)1 : (byte)0);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtCollisionWorld` by value.
    /// Usage:
    /// * Pass an instance of `BtCollisionWorld`/`Const_BtCollisionWorld` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtCollisionWorld
    {
        #pragma warning disable CS0649
        internal readonly Const_BtCollisionWorld? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtCollisionWorld(Const_BtCollisionWorld new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtCollisionWorld(Const_BtCollisionWorld arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtCollisionWorld` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtCollisionWorld`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionWorld`/`Const_BtCollisionWorld` directly.
    public class _InOptMut_BtCollisionWorld
    {
        public BtCollisionWorld? Opt;

        public _InOptMut_BtCollisionWorld() {}
        public _InOptMut_BtCollisionWorld(BtCollisionWorld value) {Opt = value;}
        public static implicit operator _InOptMut_BtCollisionWorld(BtCollisionWorld value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtCollisionWorld` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtCollisionWorld`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionWorld`/`Const_BtCollisionWorld` to pass it to the function.
    public class _InOptConst_BtCollisionWorld
    {
        public Const_BtCollisionWorld? Opt;

        public _InOptConst_BtCollisionWorld() {}
        public _InOptConst_BtCollisionWorld(Const_BtCollisionWorld value) {Opt = value;}
        public static implicit operator _InOptConst_BtCollisionWorld(Const_BtCollisionWorld value) {return new(value);}
    }
}
