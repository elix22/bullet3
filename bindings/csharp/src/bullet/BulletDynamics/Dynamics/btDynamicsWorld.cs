// machine generated, do not edit
public static partial class Bullet
{
    ///The btDynamicsWorld is the interface class for several dynamics implementation, basic, discrete, parallel, and continuous etc.
    /// Generated from class `btDynamicsWorld`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionWorld`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDiscreteDynamicsWorld`
    /// This is the const half of the class.
    public class Const_BtDynamicsWorld : Bullet.Object<Const_BtDynamicsWorld>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_Destroy(_Underlying *_this);
            __btDynamicsWorld_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtDynamicsWorld() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionWorld(Const_BtDynamicsWorld self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionWorld._Underlying *__btDynamicsWorld_UpcastTo_btCollisionWorld(_Underlying *_this);
            Bullet.Const_BtCollisionWorld ret = new(__btDynamicsWorld_UpcastTo_btCollisionWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtDynamicsWorld?(Bullet.Const_BtCollisionWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(Bullet.Const_BtCollisionWorld._Underlying *_this);
            var ptr = __btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtDynamicsWorld ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe Const_BtDynamicsWorld(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from method `btDynamicsWorld::getGravity`.
        public unsafe Bullet.BtVector3 GetGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_getGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_getGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btDynamicsWorld_getGravity(_Underlying *_this);
            return new(__btDynamicsWorld_getGravity(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btDynamicsWorld::getNumConstraints`.
        public unsafe int GetNumConstraints()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_getNumConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_getNumConstraints", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDynamicsWorld_getNumConstraints(_Underlying *_this);
            return __btDynamicsWorld_getNumConstraints(_UnderlyingPtr);
        }

        /// Generated from method `btDynamicsWorld::getWorldUserInfo`.
        /// Returns a mutable pointer.
        public unsafe void *GetWorldUserInfo()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_getWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_getWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btDynamicsWorld_getWorldUserInfo(_Underlying *_this);
            return __btDynamicsWorld_getWorldUserInfo(_UnderlyingPtr);
        }

        /// Generated from method `btDynamicsWorld::getNumCollisionObjects`.
        public unsafe int GetNumCollisionObjects()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_getNumCollisionObjects", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_getNumCollisionObjects", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDynamicsWorld_getNumCollisionObjects(_Underlying *_this);
            return __btDynamicsWorld_getNumCollisionObjects(_UnderlyingPtr);
        }

        /// rayTest performs a raycast on all objects in the btCollisionWorld, and calls the resultCallback
        /// This allows for several queries: first hit, all hits, any hit, dependent on the value returned by the callback.
        /// Generated from method `btDynamicsWorld::rayTest`.
        public unsafe void RayTest(Bullet.Const_BtVector3 rayFromWorld, Bullet.Const_BtVector3 rayToWorld, Bullet.BtCollisionWorld.RayResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_rayTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_rayTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_rayTest(_Underlying *_this, Bullet.Const_BtVector3._Underlying *rayFromWorld, Bullet.Const_BtVector3._Underlying *rayToWorld, Bullet.BtCollisionWorld.RayResultCallback._Underlying *resultCallback);
            __btDynamicsWorld_rayTest(_UnderlyingPtr, rayFromWorld._UnderlyingPtr, rayToWorld._UnderlyingPtr, resultCallback._UnderlyingPtr);
        }

        /// convexTest performs a swept convex cast on all objects in the btCollisionWorld, and calls the resultCallback
        /// This allows for several queries: first hit, all hits, any hit, dependent on the value return by the callback.
        /// Generated from method `btDynamicsWorld::convexSweepTest`.
        /// Parameter `allowedCcdPenetration` defaults to `btScalar(0.0)`.
        public unsafe void ConvexSweepTest(Bullet.Const_BtConvexShape? castShape, Bullet.Const_BtTransform from, Bullet.Const_BtTransform to, Bullet.BtCollisionWorld.ConvexResultCallback resultCallback, double? allowedCcdPenetration = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_convexSweepTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_convexSweepTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_convexSweepTest(_Underlying *_this, Bullet.Const_BtConvexShape._Underlying *castShape, Bullet.Const_BtTransform._Underlying *from, Bullet.Const_BtTransform._Underlying *to, Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *resultCallback, double *allowedCcdPenetration);
            double __deref_allowedCcdPenetration = allowedCcdPenetration.GetValueOrDefault();
            __btDynamicsWorld_convexSweepTest(_UnderlyingPtr, castShape is not null ? castShape._UnderlyingPtr : null, from._UnderlyingPtr, to._UnderlyingPtr, resultCallback._UnderlyingPtr, allowedCcdPenetration.HasValue ? &__deref_allowedCcdPenetration : null);
        }

        /// rayTestSingle performs a raycast call and calls the resultCallback. It is used internally by rayTest.
        /// In a future implementation, we consider moving the ray test as a virtual method in btCollisionShape.
        /// This allows more customization.
        /// Generated from method `btDynamicsWorld::rayTestSingle`.
        public static unsafe void RayTestSingle(Bullet.Const_BtTransform rayFromTrans, Bullet.Const_BtTransform rayToTrans, Bullet.BtCollisionObject? collisionObject, Bullet.Const_BtCollisionShape? collisionShape, Bullet.Const_BtTransform colObjWorldTransform, Bullet.BtCollisionWorld.RayResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_rayTestSingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_rayTestSingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_rayTestSingle(Bullet.Const_BtTransform._Underlying *rayFromTrans, Bullet.Const_BtTransform._Underlying *rayToTrans, Bullet.BtCollisionObject._Underlying *collisionObject, Bullet.Const_BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtTransform._Underlying *colObjWorldTransform, Bullet.BtCollisionWorld.RayResultCallback._Underlying *resultCallback);
            __btDynamicsWorld_rayTestSingle(rayFromTrans._UnderlyingPtr, rayToTrans._UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, colObjWorldTransform._UnderlyingPtr, resultCallback._UnderlyingPtr);
        }

        /// objectQuerySingle performs a collision detection query and calls the resultCallback. It is used internally by rayTest.
        /// Generated from method `btDynamicsWorld::objectQuerySingle`.
        public static unsafe void ObjectQuerySingle(Bullet.Const_BtConvexShape? castShape, Bullet.Const_BtTransform rayFromTrans, Bullet.Const_BtTransform rayToTrans, Bullet.BtCollisionObject? collisionObject, Bullet.Const_BtCollisionShape? collisionShape, Bullet.Const_BtTransform colObjWorldTransform, Bullet.BtCollisionWorld.ConvexResultCallback resultCallback, double allowedPenetration)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_objectQuerySingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_objectQuerySingle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_objectQuerySingle(Bullet.Const_BtConvexShape._Underlying *castShape, Bullet.Const_BtTransform._Underlying *rayFromTrans, Bullet.Const_BtTransform._Underlying *rayToTrans, Bullet.BtCollisionObject._Underlying *collisionObject, Bullet.Const_BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtTransform._Underlying *colObjWorldTransform, Bullet.BtCollisionWorld.ConvexResultCallback._Underlying *resultCallback, double allowedPenetration);
            __btDynamicsWorld_objectQuerySingle(castShape is not null ? castShape._UnderlyingPtr : null, rayFromTrans._UnderlyingPtr, rayToTrans._UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, colObjWorldTransform._UnderlyingPtr, resultCallback._UnderlyingPtr, allowedPenetration);
        }

        /// Generated from method `btDynamicsWorld::getForceUpdateAllAabbs`.
        public unsafe bool GetForceUpdateAllAabbs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_getForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_getForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btDynamicsWorld_getForceUpdateAllAabbs(_Underlying *_this);
            return __btDynamicsWorld_getForceUpdateAllAabbs(_UnderlyingPtr) != 0;
        }
    }

    ///The btDynamicsWorld is the interface class for several dynamics implementation, basic, discrete, parallel, and continuous etc.
    /// Generated from class `btDynamicsWorld`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionWorld`
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btDiscreteDynamicsWorld`
    /// This is the non-const half of the class.
    public class BtDynamicsWorld : Const_BtDynamicsWorld
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionWorld(BtDynamicsWorld self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_UpcastTo_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionWorld._Underlying *__btDynamicsWorld_UpcastTo_btCollisionWorld(_Underlying *_this);
            Bullet.BtCollisionWorld ret = new(__btDynamicsWorld_UpcastTo_btCollisionWorld(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtDynamicsWorld?(Bullet.BtCollisionWorld parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(Bullet.BtCollisionWorld._Underlying *_this);
            var ptr = __btDynamicsWorld_DynamicDowncastFrom_btCollisionWorld(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtDynamicsWorld ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        internal unsafe BtDynamicsWorld(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        ///stepSimulation proceeds the simulation over 'timeStep', units in preferably in seconds.
        ///By default, Bullet will subdivide the timestep in constant substeps of each 'fixedTimeStep'.
        ///in order to keep the simulation real-time, the maximum number of substeps can be clamped to 'maxSubSteps'.
        ///You can disable subdividing the timestep/substepping by passing maxSubSteps=0 as second argument to stepSimulation, but in that case you have to keep the timeStep constant.
        /// Generated from method `btDynamicsWorld::stepSimulation`.
        /// Parameter `maxSubSteps` defaults to `1`.
        /// Parameter `fixedTimeStep` defaults to `btScalar(1.0)/btScalar(60.0)`.
        public unsafe int StepSimulation(double timeStep, int? maxSubSteps = null, double? fixedTimeStep = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_stepSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_stepSimulation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btDynamicsWorld_stepSimulation(_Underlying *_this, double timeStep, int *maxSubSteps, double *fixedTimeStep);
            int __deref_maxSubSteps = maxSubSteps.GetValueOrDefault();
            double __deref_fixedTimeStep = fixedTimeStep.GetValueOrDefault();
            return __btDynamicsWorld_stepSimulation(_UnderlyingPtr, timeStep, maxSubSteps.HasValue ? &__deref_maxSubSteps : null, fixedTimeStep.HasValue ? &__deref_fixedTimeStep : null);
        }

        /// Generated from method `btDynamicsWorld::debugDrawWorld`.
        public unsafe void DebugDrawWorld()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_debugDrawWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_debugDrawWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_debugDrawWorld(_Underlying *_this);
            __btDynamicsWorld_debugDrawWorld(_UnderlyingPtr);
        }

        //once a rigidbody is added to the dynamics world, it will get this gravity assigned
        //existing rigidbodies in the world get gravity assigned too, during this method
        /// Generated from method `btDynamicsWorld::setGravity`.
        public unsafe void SetGravity(Bullet.Const_BtVector3 gravity)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_setGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_setGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_setGravity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *gravity);
            __btDynamicsWorld_setGravity(_UnderlyingPtr, gravity._UnderlyingPtr);
        }

        /// Generated from method `btDynamicsWorld::synchronizeMotionStates`.
        public unsafe void SynchronizeMotionStates()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_synchronizeMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_synchronizeMotionStates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_synchronizeMotionStates(_Underlying *_this);
            __btDynamicsWorld_synchronizeMotionStates(_UnderlyingPtr);
        }

        /// Generated from method `btDynamicsWorld::addRigidBody`.
        public unsafe void AddRigidBody(Bullet.BtRigidBody? body)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_addRigidBody_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_addRigidBody_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_addRigidBody_1(_Underlying *_this, Bullet.BtRigidBody._Underlying *body);
            __btDynamicsWorld_addRigidBody_1(_UnderlyingPtr, body is not null ? body._UnderlyingPtr : null);
        }

        /// Generated from method `btDynamicsWorld::addRigidBody`.
        public unsafe void AddRigidBody(Bullet.BtRigidBody? body, int group, int mask)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_addRigidBody_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_addRigidBody_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_addRigidBody_3(_Underlying *_this, Bullet.BtRigidBody._Underlying *body, int group, int mask);
            __btDynamicsWorld_addRigidBody_3(_UnderlyingPtr, body is not null ? body._UnderlyingPtr : null, group, mask);
        }

        /// Generated from method `btDynamicsWorld::removeRigidBody`.
        public unsafe void RemoveRigidBody(Bullet.BtRigidBody? body)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_removeRigidBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_removeRigidBody", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_removeRigidBody(_Underlying *_this, Bullet.BtRigidBody._Underlying *body);
            __btDynamicsWorld_removeRigidBody(_UnderlyingPtr, body is not null ? body._UnderlyingPtr : null);
        }

        /// Generated from method `btDynamicsWorld::setConstraintSolver`.
        public unsafe void SetConstraintSolver(Bullet.BtConstraintSolver? solver)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_setConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_setConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_setConstraintSolver(_Underlying *_this, Bullet.BtConstraintSolver._Underlying *solver);
            __btDynamicsWorld_setConstraintSolver(_UnderlyingPtr, solver is not null ? solver._UnderlyingPtr : null);
        }

        /// Generated from method `btDynamicsWorld::getConstraintSolver`.
        public unsafe Bullet.BtConstraintSolver? GetConstraintSolver()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_getConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_getConstraintSolver", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtConstraintSolver._Underlying *__btDynamicsWorld_getConstraintSolver(_Underlying *_this);
            var __c_ret = __btDynamicsWorld_getConstraintSolver(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtConstraintSolver(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btDynamicsWorld::clearForces`.
        public unsafe void ClearForces()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_clearForces", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_clearForces", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_clearForces(_Underlying *_this);
            __btDynamicsWorld_clearForces(_UnderlyingPtr);
        }

        /// Generated from method `btDynamicsWorld::setWorldUserInfo`.
        /// Parameter `worldUserInfo` is a mutable pointer.
        public unsafe void SetWorldUserInfo(void *worldUserInfo)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_setWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_setWorldUserInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_setWorldUserInfo(_Underlying *_this, void *worldUserInfo);
            __btDynamicsWorld_setWorldUserInfo(_UnderlyingPtr, worldUserInfo);
        }

        /// Generated from method `btDynamicsWorld::setBroadphase`.
        public unsafe void SetBroadphase(Bullet.BtBroadphaseInterface? pairCache)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_setBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_setBroadphase", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_setBroadphase(_Underlying *_this, Bullet.BtBroadphaseInterface._Underlying *pairCache);
            __btDynamicsWorld_setBroadphase(_UnderlyingPtr, pairCache is not null ? pairCache._UnderlyingPtr : null);
        }

        /// Generated from method `btDynamicsWorld::getPairCache`.
        public unsafe Bullet.BtOverlappingPairCache? GetPairCache()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_getPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_getPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtOverlappingPairCache._Underlying *__btDynamicsWorld_getPairCache(_Underlying *_this);
            var __c_ret = __btDynamicsWorld_getPairCache(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtOverlappingPairCache(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btDynamicsWorld::updateSingleAabb`.
        public unsafe void UpdateSingleAabb(Bullet.BtCollisionObject? colObj)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_updateSingleAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_updateSingleAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_updateSingleAabb(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObj);
            __btDynamicsWorld_updateSingleAabb(_UnderlyingPtr, colObj is not null ? colObj._UnderlyingPtr : null);
        }

        /// Generated from method `btDynamicsWorld::updateAabbs`.
        public unsafe void UpdateAabbs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_updateAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_updateAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_updateAabbs(_Underlying *_this);
            __btDynamicsWorld_updateAabbs(_UnderlyingPtr);
        }

        ///the computeOverlappingPairs is usually already called by performDiscreteCollisionDetection (or stepSimulation)
        ///it can be useful to use if you perform ray tests without collision detection/simulation
        /// Generated from method `btDynamicsWorld::computeOverlappingPairs`.
        public unsafe void ComputeOverlappingPairs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_computeOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_computeOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_computeOverlappingPairs(_Underlying *_this);
            __btDynamicsWorld_computeOverlappingPairs(_UnderlyingPtr);
        }

        /// Generated from method `btDynamicsWorld::debugDrawObject`.
        public unsafe void DebugDrawObject(Bullet.Const_BtTransform worldTransform, Bullet.Const_BtCollisionShape? shape, Bullet.Const_BtVector3 color)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_debugDrawObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_debugDrawObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_debugDrawObject(_Underlying *_this, Bullet.Const_BtTransform._Underlying *worldTransform, Bullet.Const_BtCollisionShape._Underlying *shape, Bullet.Const_BtVector3._Underlying *color);
            __btDynamicsWorld_debugDrawObject(_UnderlyingPtr, worldTransform._UnderlyingPtr, shape is not null ? shape._UnderlyingPtr : null, color._UnderlyingPtr);
        }

        ///contactTest performs a discrete collision test between colObj against all objects in the btCollisionWorld, and calls the resultCallback.
        ///it reports one or more contact points for every overlapping object (including the one with deepest penetration)
        /// Generated from method `btDynamicsWorld::contactTest`.
        public unsafe void ContactTest(Bullet.BtCollisionObject? colObj, Bullet.BtCollisionWorld.ContactResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_contactTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_contactTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_contactTest(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObj, Bullet.BtCollisionWorld.ContactResultCallback._Underlying *resultCallback);
            __btDynamicsWorld_contactTest(_UnderlyingPtr, colObj is not null ? colObj._UnderlyingPtr : null, resultCallback._UnderlyingPtr);
        }

        ///contactTest performs a discrete collision test between two collision objects and calls the resultCallback if overlap if detected.
        ///it reports one or more contact points (including the one with deepest penetration)
        /// Generated from method `btDynamicsWorld::contactPairTest`.
        public unsafe void ContactPairTest(Bullet.BtCollisionObject? colObjA, Bullet.BtCollisionObject? colObjB, Bullet.BtCollisionWorld.ContactResultCallback resultCallback)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_contactPairTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_contactPairTest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_contactPairTest(_Underlying *_this, Bullet.BtCollisionObject._Underlying *colObjA, Bullet.BtCollisionObject._Underlying *colObjB, Bullet.BtCollisionWorld.ContactResultCallback._Underlying *resultCallback);
            __btDynamicsWorld_contactPairTest(_UnderlyingPtr, colObjA is not null ? colObjA._UnderlyingPtr : null, colObjB is not null ? colObjB._UnderlyingPtr : null, resultCallback._UnderlyingPtr);
        }

        /// Generated from method `btDynamicsWorld::addCollisionObject`.
        /// Parameter `collisionFilterGroup` defaults to `btBroadphaseProxy::DefaultFilter`.
        /// Parameter `collisionFilterMask` defaults to `btBroadphaseProxy::AllFilter`.
        public unsafe void AddCollisionObject(Bullet.BtCollisionObject? collisionObject, int? collisionFilterGroup = null, int? collisionFilterMask = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_addCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_addCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_addCollisionObject(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject, int *collisionFilterGroup, int *collisionFilterMask);
            int __deref_collisionFilterGroup = collisionFilterGroup.GetValueOrDefault();
            int __deref_collisionFilterMask = collisionFilterMask.GetValueOrDefault();
            __btDynamicsWorld_addCollisionObject(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null, collisionFilterGroup.HasValue ? &__deref_collisionFilterGroup : null, collisionFilterMask.HasValue ? &__deref_collisionFilterMask : null);
        }

        /// Generated from method `btDynamicsWorld::refreshBroadphaseProxy`.
        public unsafe void RefreshBroadphaseProxy(Bullet.BtCollisionObject? collisionObject)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_refreshBroadphaseProxy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_refreshBroadphaseProxy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_refreshBroadphaseProxy(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject);
            __btDynamicsWorld_refreshBroadphaseProxy(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null);
        }

        /// Generated from method `btDynamicsWorld::removeCollisionObject`.
        public unsafe void RemoveCollisionObject(Bullet.BtCollisionObject? collisionObject)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_removeCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_removeCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_removeCollisionObject(_Underlying *_this, Bullet.BtCollisionObject._Underlying *collisionObject);
            __btDynamicsWorld_removeCollisionObject(_UnderlyingPtr, collisionObject is not null ? collisionObject._UnderlyingPtr : null);
        }

        /// Generated from method `btDynamicsWorld::performDiscreteCollisionDetection`.
        public unsafe void PerformDiscreteCollisionDetection()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_performDiscreteCollisionDetection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_performDiscreteCollisionDetection", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_performDiscreteCollisionDetection(_Underlying *_this);
            __btDynamicsWorld_performDiscreteCollisionDetection(_UnderlyingPtr);
        }

        /// Generated from method `btDynamicsWorld::setForceUpdateAllAabbs`.
        public unsafe void SetForceUpdateAllAabbs(bool forceUpdateAllAabbs)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDynamicsWorld_setForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDynamicsWorld_setForceUpdateAllAabbs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDynamicsWorld_setForceUpdateAllAabbs(_Underlying *_this, byte forceUpdateAllAabbs);
            __btDynamicsWorld_setForceUpdateAllAabbs(_UnderlyingPtr, forceUpdateAllAabbs ? (byte)1 : (byte)0);
        }
    }

    /// This is used for optional parameters of class `BtDynamicsWorld` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtDynamicsWorld`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDynamicsWorld`/`Const_BtDynamicsWorld` directly.
    public class _InOptMut_BtDynamicsWorld
    {
        public BtDynamicsWorld? Opt;

        public _InOptMut_BtDynamicsWorld() {}
        public _InOptMut_BtDynamicsWorld(BtDynamicsWorld value) {Opt = value;}
        public static implicit operator _InOptMut_BtDynamicsWorld(BtDynamicsWorld value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtDynamicsWorld` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtDynamicsWorld`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDynamicsWorld`/`Const_BtDynamicsWorld` to pass it to the function.
    public class _InOptConst_BtDynamicsWorld
    {
        public Const_BtDynamicsWorld? Opt;

        public _InOptConst_BtDynamicsWorld() {}
        public _InOptConst_BtDynamicsWorld(Const_BtDynamicsWorld value) {Opt = value;}
        public static implicit operator _InOptConst_BtDynamicsWorld(Const_BtDynamicsWorld value) {return new(value);}
    }
}
