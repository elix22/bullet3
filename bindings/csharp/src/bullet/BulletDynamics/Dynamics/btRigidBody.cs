// machine generated, do not edit
public static partial class Bullet
{
    ///The btRigidBody is the main class for rigid body objects. It is derived from btCollisionObject, so it keeps a pointer to a btCollisionShape.
    ///It is recommended for performance and memory use to share btCollisionShape objects whenever possible.
    ///There are 3 types of rigid bodies:
    ///- A) Dynamic rigid bodies, with positive mass. Motion is controlled by rigid body dynamics.
    ///- B) Fixed objects with zero mass. They are not moving (basically collision objects)
    ///- C) Kinematic objects, which are objects without mass, but the user can move them. There is one-way interaction, and Bullet calculates a velocity based on the timestep and previous and current world transform.
    ///Bullet automatically deactivates dynamic rigid bodies, when the velocity is below a threshold for a given time.
    ///Deactivated (sleeping) rigid bodies don't take any processing time, except a minor broadphase collision detection impact (to allow active objects to activate/wake up sleeping objects)
    /// Generated from class `btRigidBody`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionObject`
    /// This is the const half of the class.
    public class Const_BtRigidBody : Bullet.Object<Const_BtRigidBody>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_Destroy(_Underlying *_this);
            __btRigidBody_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtRigidBody() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtCollisionObject(Const_BtRigidBody self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_UpcastTo_btCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_UpcastTo_btCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionObject._Underlying *__btRigidBody_UpcastTo_btCollisionObject(_Underlying *_this);
            Bullet.Const_BtCollisionObject ret = new(__btRigidBody_UpcastTo_btCollisionObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtRigidBody?(Bullet.Const_BtCollisionObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_DynamicDowncastFrom_btCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_DynamicDowncastFrom_btCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btRigidBody_DynamicDowncastFrom_btCollisionObject(Bullet.Const_BtCollisionObject._Underlying *_this);
            var ptr = __btRigidBody_DynamicDowncastFrom_btCollisionObject(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtRigidBody ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        //for experimental overriding of friction/contact solver func
        public unsafe int mContactSolverType
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_Get_m_contactSolverType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_Get_m_contactSolverType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btRigidBody_Get_m_contactSolverType(_Underlying *_this);
                return *__btRigidBody_Get_m_contactSolverType(_UnderlyingPtr);
            }
        }

        public unsafe int mFrictionSolverType
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_Get_m_frictionSolverType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_Get_m_frictionSolverType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btRigidBody_Get_m_frictionSolverType(_Underlying *_this);
                return *__btRigidBody_Get_m_frictionSolverType(_UnderlyingPtr);
            }
        }

        internal unsafe Const_BtRigidBody(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Generated from constructor `btRigidBody::btRigidBody`.
        public unsafe Const_BtRigidBody(Bullet._ByValue_BtRigidBody _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtRigidBody._Underlying *__btRigidBody_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtRigidBody._Underlying *_other);
            _UnderlyingPtr = __btRigidBody_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btRigidBody::btRigidBody`.
        public Const_BtRigidBody(Const_BtRigidBody _other) : this(new _ByValue_BtRigidBody(_other)) {}

        /// Generated from constructor `btRigidBody::btRigidBody`.
        public Const_BtRigidBody(BtRigidBody _other) : this((Const_BtRigidBody)_other) {}

        ///btRigidBody constructor using construction info
        /// Generated from constructor `btRigidBody::btRigidBody`.
        public unsafe Const_BtRigidBody(Bullet.BtRigidBody.Const_BtRigidBodyConstructionInfo constructionInfo) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtRigidBody._Underlying *__btRigidBody_Construct_1(Bullet.BtRigidBody.Const_BtRigidBodyConstructionInfo._Underlying *constructionInfo);
            _UnderlyingPtr = __btRigidBody_Construct_1(constructionInfo._UnderlyingPtr);
        }

        ///btRigidBody constructor using construction info
        /// Generated from constructor `btRigidBody::btRigidBody`.
        public static unsafe implicit operator Const_BtRigidBody(Bullet.BtRigidBody.Const_BtRigidBodyConstructionInfo constructionInfo) {return new(constructionInfo);}

        ///btRigidBody constructor for backwards compatibility.
        ///To specify friction (etc) during rigid body construction, please use the other constructor (using btRigidBodyConstructionInfo)
        /// Generated from constructor `btRigidBody::btRigidBody`.
        /// Parameter `localInertia` defaults to `btVector3(0, 0, 0)`.
        public unsafe Const_BtRigidBody(double mass, Bullet.BtMotionState? motionState, Bullet.BtCollisionShape? collisionShape, Bullet.Const_BtVector3? localInertia = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtRigidBody._Underlying *__btRigidBody_Construct_4(double mass, Bullet.BtMotionState._Underlying *motionState, Bullet.BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtVector3._Underlying *localInertia);
            _UnderlyingPtr = __btRigidBody_Construct_4(mass, motionState is not null ? motionState._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, localInertia is not null ? localInertia._UnderlyingPtr : null);
        }

        ///to keep collision detection and dynamics separate we don't store a rigidbody pointer
        ///but a rigidbody is derived from btCollisionObject, so we can safely perform an upcast
        /// Generated from method `btRigidBody::upcast`.
        public static unsafe Bullet.Const_BtRigidBody? Upcast(Bullet.Const_BtCollisionObject? colObj)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_upcast_const_btCollisionObject_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_upcast_const_btCollisionObject_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtRigidBody._Underlying *__btRigidBody_upcast_const_btCollisionObject_ptr(Bullet.Const_BtCollisionObject._Underlying *colObj);
            var __c_ret = __btRigidBody_upcast_const_btCollisionObject_ptr(colObj is not null ? colObj._UnderlyingPtr : null);
            return __c_ret is not null ? new Bullet.Const_BtRigidBody(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btRigidBody::upcast`.
        public static unsafe Bullet.BtRigidBody? Upcast(Bullet.BtCollisionObject? colObj)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_upcast_btCollisionObject_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_upcast_btCollisionObject_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtRigidBody._Underlying *__btRigidBody_upcast_btCollisionObject_ptr(Bullet.BtCollisionObject._Underlying *colObj);
            var __c_ret = __btRigidBody_upcast_btCollisionObject_ptr(colObj is not null ? colObj._UnderlyingPtr : null);
            return __c_ret is not null ? new Bullet.BtRigidBody(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btRigidBody::getGravity`.
        public unsafe Bullet.Const_BtVector3 GetGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getGravity(_Underlying *_this);
            return new(__btRigidBody_getGravity(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getLinearDamping`.
        public unsafe double GetLinearDamping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getLinearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getLinearDamping(_Underlying *_this);
            return __btRigidBody_getLinearDamping(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getAngularDamping`.
        public unsafe double GetAngularDamping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getAngularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getAngularDamping(_Underlying *_this);
            return __btRigidBody_getAngularDamping(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getLinearSleepingThreshold`.
        public unsafe double GetLinearSleepingThreshold()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getLinearSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getLinearSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getLinearSleepingThreshold(_Underlying *_this);
            return __btRigidBody_getLinearSleepingThreshold(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getAngularSleepingThreshold`.
        public unsafe double GetAngularSleepingThreshold()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getAngularSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getAngularSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getAngularSleepingThreshold(_Underlying *_this);
            return __btRigidBody_getAngularSleepingThreshold(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getCollisionShape`.
        public unsafe Bullet.Const_BtCollisionShape? GetCollisionShape()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionShape._Underlying *__btRigidBody_getCollisionShape(_Underlying *_this);
            var __c_ret = __btRigidBody_getCollisionShape(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Const_BtCollisionShape(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btRigidBody::getLinearFactor`.
        public unsafe Bullet.Const_BtVector3 GetLinearFactor()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getLinearFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getLinearFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getLinearFactor(_Underlying *_this);
            return new(__btRigidBody_getLinearFactor(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getInvMass`.
        public unsafe double GetInvMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getInvMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getInvMass(_Underlying *_this);
            return __btRigidBody_getInvMass(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getMass`.
        public unsafe double GetMass()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getMass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getMass(_Underlying *_this);
            return __btRigidBody_getMass(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getInvInertiaTensorWorld`.
        public unsafe Bullet.Const_BtMatrix3x3 GetInvInertiaTensorWorld()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getInvInertiaTensorWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getInvInertiaTensorWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtMatrix3x3._Underlying *__btRigidBody_getInvInertiaTensorWorld(_Underlying *_this);
            return new(__btRigidBody_getInvInertiaTensorWorld(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getTotalForce`.
        public unsafe Bullet.Const_BtVector3 GetTotalForce()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getTotalForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getTotalForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getTotalForce(_Underlying *_this);
            return new(__btRigidBody_getTotalForce(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getTotalTorque`.
        public unsafe Bullet.Const_BtVector3 GetTotalTorque()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getTotalTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getTotalTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getTotalTorque(_Underlying *_this);
            return new(__btRigidBody_getTotalTorque(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getInvInertiaDiagLocal`.
        public unsafe Bullet.Const_BtVector3 GetInvInertiaDiagLocal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getInvInertiaDiagLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getInvInertiaDiagLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getInvInertiaDiagLocal(_Underlying *_this);
            return new(__btRigidBody_getInvInertiaDiagLocal(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getPushVelocity`.
        public unsafe Bullet.BtVector3 GetPushVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getPushVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getPushVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btRigidBody_getPushVelocity(_Underlying *_this);
            return new(__btRigidBody_getPushVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btRigidBody::getTurnVelocity`.
        public unsafe Bullet.BtVector3 GetTurnVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getTurnVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getTurnVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btRigidBody_getTurnVelocity(_Underlying *_this);
            return new(__btRigidBody_getTurnVelocity(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btRigidBody::getCenterOfMassPosition`.
        public unsafe Bullet.Const_BtVector3 GetCenterOfMassPosition()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCenterOfMassPosition", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getCenterOfMassPosition(_Underlying *_this);
            return new(__btRigidBody_getCenterOfMassPosition(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getOrientation`.
        public unsafe Bullet.BtQuaternion GetOrientation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getOrientation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getOrientation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btRigidBody_getOrientation(_Underlying *_this);
            return new(__btRigidBody_getOrientation(_UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btRigidBody::getCenterOfMassTransform`.
        public unsafe Bullet.Const_BtTransform GetCenterOfMassTransform()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtTransform._Underlying *__btRigidBody_getCenterOfMassTransform(_Underlying *_this);
            return new(__btRigidBody_getCenterOfMassTransform(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getLinearVelocity`.
        public unsafe Bullet.Const_BtVector3 GetLinearVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getLinearVelocity(_Underlying *_this);
            return new(__btRigidBody_getLinearVelocity(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getAngularVelocity`.
        public unsafe Bullet.Const_BtVector3 GetAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getAngularVelocity(_Underlying *_this);
            return new(__btRigidBody_getAngularVelocity(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getVelocityInLocalPoint`.
        public unsafe Bullet.BtVector3 GetVelocityInLocalPoint(Bullet.Const_BtVector3 rel_pos)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getVelocityInLocalPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getVelocityInLocalPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btRigidBody_getVelocityInLocalPoint(_Underlying *_this, Bullet.Const_BtVector3._Underlying *rel_pos);
            return new(__btRigidBody_getVelocityInLocalPoint(_UnderlyingPtr, rel_pos._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btRigidBody::getPushVelocityInLocalPoint`.
        public unsafe Bullet.BtVector3 GetPushVelocityInLocalPoint(Bullet.Const_BtVector3 rel_pos)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getPushVelocityInLocalPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getPushVelocityInLocalPoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btRigidBody_getPushVelocityInLocalPoint(_Underlying *_this, Bullet.Const_BtVector3._Underlying *rel_pos);
            return new(__btRigidBody_getPushVelocityInLocalPoint(_UnderlyingPtr, rel_pos._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btRigidBody::getAabb`.
        public unsafe void GetAabb(Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_getAabb(_Underlying *_this, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btRigidBody_getAabb(_UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::computeImpulseDenominator`.
        public unsafe double ComputeImpulseDenominator(Bullet.Const_BtVector3 pos, Bullet.Const_BtVector3 normal)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_computeImpulseDenominator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_computeImpulseDenominator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_computeImpulseDenominator(_Underlying *_this, Bullet.Const_BtVector3._Underlying *pos, Bullet.Const_BtVector3._Underlying *normal);
            return __btRigidBody_computeImpulseDenominator(_UnderlyingPtr, pos._UnderlyingPtr, normal._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::computeAngularImpulseDenominator`.
        public unsafe double ComputeAngularImpulseDenominator(Bullet.Const_BtVector3 axis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_computeAngularImpulseDenominator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_computeAngularImpulseDenominator", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_computeAngularImpulseDenominator(_Underlying *_this, Bullet.Const_BtVector3._Underlying *axis);
            return __btRigidBody_computeAngularImpulseDenominator(_UnderlyingPtr, axis._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getMotionState`.
        public unsafe Bullet.Const_BtMotionState? GetMotionState()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtMotionState._Underlying *__btRigidBody_getMotionState(_Underlying *_this);
            var __c_ret = __btRigidBody_getMotionState(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Const_BtMotionState(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btRigidBody::getAngularFactor`.
        public unsafe Bullet.Const_BtVector3 GetAngularFactor()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getAngularFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getAngularFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getAngularFactor(_Underlying *_this);
            return new(__btRigidBody_getAngularFactor(_UnderlyingPtr), is_owning: false);
        }

        //is this rigidbody added to a btCollisionWorld/btDynamicsWorld/btBroadphase?
        /// Generated from method `btRigidBody::isInWorld`.
        public unsafe bool IsInWorld()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_isInWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_isInWorld", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_isInWorld(_Underlying *_this);
            return __btRigidBody_isInWorld(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btRigidBody::getNumConstraintRefs`.
        public unsafe int GetNumConstraintRefs()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getNumConstraintRefs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getNumConstraintRefs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getNumConstraintRefs(_Underlying *_this);
            return __btRigidBody_getNumConstraintRefs(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getFlags`.
        public unsafe int GetFlags()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getFlags(_Underlying *_this);
            return __btRigidBody_getFlags(_UnderlyingPtr);
        }

        ///perform implicit force computation in world space
        /// Generated from method `btRigidBody::computeGyroscopicImpulseImplicit_World`.
        public unsafe Bullet.BtVector3 ComputeGyroscopicImpulseImplicitWorld(double dt)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_computeGyroscopicImpulseImplicit_World", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_computeGyroscopicImpulseImplicit_World", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btRigidBody_computeGyroscopicImpulseImplicit_World(_Underlying *_this, double dt);
            return new(__btRigidBody_computeGyroscopicImpulseImplicit_World(_UnderlyingPtr, dt), is_owning: true);
        }

        ///perform implicit force computation in body space (inertial frame)
        /// Generated from method `btRigidBody::computeGyroscopicImpulseImplicit_Body`.
        public unsafe Bullet.BtVector3 ComputeGyroscopicImpulseImplicitBody(double step)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_computeGyroscopicImpulseImplicit_Body", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_computeGyroscopicImpulseImplicit_Body", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btRigidBody_computeGyroscopicImpulseImplicit_Body(_Underlying *_this, double step);
            return new(__btRigidBody_computeGyroscopicImpulseImplicit_Body(_UnderlyingPtr, step), is_owning: true);
        }

        ///explicit version is best avoided, it gains energy
        /// Generated from method `btRigidBody::computeGyroscopicForceExplicit`.
        public unsafe Bullet.BtVector3 ComputeGyroscopicForceExplicit(double maxGyroscopicForce)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_computeGyroscopicForceExplicit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_computeGyroscopicForceExplicit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btRigidBody_computeGyroscopicForceExplicit(_Underlying *_this, double maxGyroscopicForce);
            return new(__btRigidBody_computeGyroscopicForceExplicit(_UnderlyingPtr, maxGyroscopicForce), is_owning: true);
        }

        /// Generated from method `btRigidBody::getLocalInertia`.
        public unsafe Bullet.BtVector3 GetLocalInertia()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getLocalInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btRigidBody_getLocalInertia(_Underlying *_this);
            return new(__btRigidBody_getLocalInertia(_UnderlyingPtr), is_owning: true);
        }

        ///////////////////////////////////////////////
        /// Generated from method `btRigidBody::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_calculateSerializeBufferSize(_Underlying *_this);
            return __btRigidBody_calculateSerializeBufferSize(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::mergesSimulationIslands`.
        public unsafe bool MergesSimulationIslands()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_mergesSimulationIslands", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_mergesSimulationIslands", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_mergesSimulationIslands(_Underlying *_this);
            return __btRigidBody_mergesSimulationIslands(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btRigidBody::getAnisotropicFriction`.
        public unsafe Bullet.Const_BtVector3 GetAnisotropicFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getAnisotropicFriction(_Underlying *_this);
            return new(__btRigidBody_getAnisotropicFriction(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::hasAnisotropicFriction`.
        /// Parameter `frictionMode` defaults to `CF_ANISOTROPIC_FRICTION`.
        public unsafe bool HasAnisotropicFriction(int? frictionMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_hasAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_hasAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_hasAnisotropicFriction(_Underlying *_this, int *frictionMode);
            int __deref_frictionMode = frictionMode.GetValueOrDefault();
            return __btRigidBody_hasAnisotropicFriction(_UnderlyingPtr, frictionMode.HasValue ? &__deref_frictionMode : null) != 0;
        }

        /// Generated from method `btRigidBody::getContactProcessingThreshold`.
        public unsafe double GetContactProcessingThreshold()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getContactProcessingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getContactProcessingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getContactProcessingThreshold(_Underlying *_this);
            return __btRigidBody_getContactProcessingThreshold(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::isStaticObject`.
        public unsafe bool IsStaticObject()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_isStaticObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_isStaticObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_isStaticObject(_Underlying *_this);
            return __btRigidBody_isStaticObject(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btRigidBody::isKinematicObject`.
        public unsafe bool IsKinematicObject()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_isKinematicObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_isKinematicObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_isKinematicObject(_Underlying *_this);
            return __btRigidBody_isKinematicObject(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btRigidBody::isStaticOrKinematicObject`.
        public unsafe bool IsStaticOrKinematicObject()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_isStaticOrKinematicObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_isStaticOrKinematicObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_isStaticOrKinematicObject(_Underlying *_this);
            return __btRigidBody_isStaticOrKinematicObject(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btRigidBody::hasContactResponse`.
        public unsafe bool HasContactResponse()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_hasContactResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_hasContactResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_hasContactResponse(_Underlying *_this);
            return __btRigidBody_hasContactResponse(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btRigidBody::getNumObjectsWithoutCollision`.
        public unsafe int GetNumObjectsWithoutCollision()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getNumObjectsWithoutCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getNumObjectsWithoutCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getNumObjectsWithoutCollision(_Underlying *_this);
            return __btRigidBody_getNumObjectsWithoutCollision(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::checkCollideWithOverride`.
        public unsafe bool CheckCollideWithOverride(Bullet.Const_BtCollisionObject? co)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_checkCollideWithOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_checkCollideWithOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_checkCollideWithOverride(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *co);
            return __btRigidBody_checkCollideWithOverride(_UnderlyingPtr, co is not null ? co._UnderlyingPtr : null) != 0;
        }

        ///Avoid using this internal API call, the extension pointer is used by some Bullet extensions.
        ///If you need to store your own user pointer, use 'setUserPointer/getUserPointer' instead.
        /// Generated from method `btRigidBody::internalGetExtensionPointer`.
        /// Returns a mutable pointer.
        public unsafe void *InternalGetExtensionPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_internalGetExtensionPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_internalGetExtensionPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btRigidBody_internalGetExtensionPointer(_Underlying *_this);
            return __btRigidBody_internalGetExtensionPointer(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getActivationState`.
        public unsafe int GetActivationState()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getActivationState(_Underlying *_this);
            return __btRigidBody_getActivationState(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setActivationState`.
        public unsafe void SetActivationState(int newState)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setActivationState(_Underlying *_this, int newState);
            __btRigidBody_setActivationState(_UnderlyingPtr, newState);
        }

        /// Generated from method `btRigidBody::getDeactivationTime`.
        public unsafe double GetDeactivationTime()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getDeactivationTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getDeactivationTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getDeactivationTime(_Underlying *_this);
            return __btRigidBody_getDeactivationTime(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::forceActivationState`.
        public unsafe void ForceActivationState(int newState)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_forceActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_forceActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_forceActivationState(_Underlying *_this, int newState);
            __btRigidBody_forceActivationState(_UnderlyingPtr, newState);
        }

        /// Generated from method `btRigidBody::activate`.
        /// Parameter `forceActivation` defaults to `false`.
        public unsafe void Activate(bool? forceActivation = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_activate(_Underlying *_this, byte *forceActivation);
            byte __deref_forceActivation = forceActivation.GetValueOrDefault() ? (byte)1 : (byte)0;
            __btRigidBody_activate(_UnderlyingPtr, forceActivation.HasValue ? &__deref_forceActivation : null);
        }

        /// Generated from method `btRigidBody::isActive`.
        public unsafe bool IsActive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_isActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_isActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_isActive(_Underlying *_this);
            return __btRigidBody_isActive(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btRigidBody::getRestitution`.
        public unsafe double GetRestitution()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getRestitution(_Underlying *_this);
            return __btRigidBody_getRestitution(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getFriction`.
        public unsafe double GetFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getFriction(_Underlying *_this);
            return __btRigidBody_getFriction(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getRollingFriction`.
        public unsafe double GetRollingFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getRollingFriction(_Underlying *_this);
            return __btRigidBody_getRollingFriction(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getSpinningFriction`.
        public unsafe double GetSpinningFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getSpinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getSpinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getSpinningFriction(_Underlying *_this);
            return __btRigidBody_getSpinningFriction(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getContactStiffness`.
        public unsafe double GetContactStiffness()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getContactStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getContactStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getContactStiffness(_Underlying *_this);
            return __btRigidBody_getContactStiffness(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getContactDamping`.
        public unsafe double GetContactDamping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getContactDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getContactDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getContactDamping(_Underlying *_this);
            return __btRigidBody_getContactDamping(_UnderlyingPtr);
        }

        ///reserved for Bullet internal usage
        /// Generated from method `btRigidBody::getInternalType`.
        public unsafe int GetInternalType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getInternalType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getInternalType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getInternalType(_Underlying *_this);
            return __btRigidBody_getInternalType(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getInterpolationLinearVelocity`.
        public unsafe Bullet.Const_BtVector3 GetInterpolationLinearVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getInterpolationLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getInterpolationLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getInterpolationLinearVelocity(_Underlying *_this);
            return new(__btRigidBody_getInterpolationLinearVelocity(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getInterpolationAngularVelocity`.
        public unsafe Bullet.Const_BtVector3 GetInterpolationAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getInterpolationAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getInterpolationAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_getInterpolationAngularVelocity(_Underlying *_this);
            return new(__btRigidBody_getInterpolationAngularVelocity(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btRigidBody::getIslandTag`.
        public unsafe int GetIslandTag()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getIslandTag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getIslandTag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getIslandTag(_Underlying *_this);
            return __btRigidBody_getIslandTag(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getCompanionId`.
        public unsafe int GetCompanionId()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCompanionId", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCompanionId", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getCompanionId(_Underlying *_this);
            return __btRigidBody_getCompanionId(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getWorldArrayIndex`.
        public unsafe int GetWorldArrayIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getWorldArrayIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getWorldArrayIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getWorldArrayIndex(_Underlying *_this);
            return __btRigidBody_getWorldArrayIndex(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getHitFraction`.
        public unsafe double GetHitFraction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getHitFraction(_Underlying *_this);
            return __btRigidBody_getHitFraction(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getCollisionFlags`.
        public unsafe int GetCollisionFlags()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCollisionFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCollisionFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getCollisionFlags(_Underlying *_this);
            return __btRigidBody_getCollisionFlags(_UnderlyingPtr);
        }

        ///Swept sphere radius (0.0 by default), see btConvexConvexAlgorithm::
        /// Generated from method `btRigidBody::getCcdSweptSphereRadius`.
        public unsafe double GetCcdSweptSphereRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCcdSweptSphereRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCcdSweptSphereRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getCcdSweptSphereRadius(_Underlying *_this);
            return __btRigidBody_getCcdSweptSphereRadius(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getCcdMotionThreshold`.
        public unsafe double GetCcdMotionThreshold()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCcdMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCcdMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getCcdMotionThreshold(_Underlying *_this);
            return __btRigidBody_getCcdMotionThreshold(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getCcdSquareMotionThreshold`.
        public unsafe double GetCcdSquareMotionThreshold()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCcdSquareMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCcdSquareMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btRigidBody_getCcdSquareMotionThreshold(_Underlying *_this);
            return __btRigidBody_getCcdSquareMotionThreshold(_UnderlyingPtr);
        }

        ///users can point to their objects, userPointer is not used by Bullet
        /// Generated from method `btRigidBody::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btRigidBody_getUserPointer(_Underlying *_this);
            return __btRigidBody_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getUserIndex(_Underlying *_this);
            return __btRigidBody_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getUserIndex2(_Underlying *_this);
            return __btRigidBody_getUserIndex2(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getUserIndex3`.
        public unsafe int GetUserIndex3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getUserIndex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getUserIndex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getUserIndex3(_Underlying *_this);
            return __btRigidBody_getUserIndex3(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getUpdateRevisionInternal`.
        public unsafe int GetUpdateRevisionInternal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getUpdateRevisionInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getUpdateRevisionInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btRigidBody_getUpdateRevisionInternal(_Underlying *_this);
            return __btRigidBody_getUpdateRevisionInternal(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::getCustomDebugColor`.
        public unsafe bool GetCustomDebugColor(Bullet.BtVector3 colorRGB)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_getCustomDebugColor(_Underlying *_this, Bullet.BtVector3._Underlying *colorRGB);
            return __btRigidBody_getCustomDebugColor(_UnderlyingPtr, colorRGB._UnderlyingPtr) != 0;
        }

        /// Generated from method `btRigidBody::checkCollideWith`.
        public unsafe bool CheckCollideWith(Bullet.Const_BtCollisionObject? co)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_checkCollideWith", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_checkCollideWith", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_checkCollideWith(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *co);
            return __btRigidBody_checkCollideWith(_UnderlyingPtr, co is not null ? co._UnderlyingPtr : null) != 0;
        }

        ///The btRigidBodyConstructionInfo structure provides information to create a rigid body. Setting mass to zero creates a fixed (non-dynamic) rigid body.
        ///For dynamic objects, you can use the collision shape to approximate the local inertia tensor, otherwise use the zero vector (default argument)
        ///You can use the motion state to synchronize the world transform between physics and graphics objects.
        ///And if the motion state is provided, the rigid body will initialize its initial world transform from the motion state,
        ///m_startWorldTransform is only used when you don't provide a motion state.
        /// Generated from class `btRigidBody::btRigidBodyConstructionInfo`.
        /// This is the const half of the class.
        public class Const_BtRigidBodyConstructionInfo : Bullet.Object<Const_BtRigidBodyConstructionInfo>, System.IDisposable
        {
            internal struct _Underlying {} // Represents the underlying C++ type.

            internal unsafe _Underlying *_UnderlyingPtr;

            protected virtual unsafe void Dispose(bool disposing)
            {
                if (_UnderlyingPtr is null || !_IsOwningVal)
                    return;
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static void __btRigidBody_btRigidBodyConstructionInfo_Destroy(_Underlying *_this);
                __btRigidBody_btRigidBodyConstructionInfo_Destroy(_UnderlyingPtr);
                _UnderlyingPtr = null;
            }
            public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
            ~Const_BtRigidBodyConstructionInfo() {Dispose(false);}

            public unsafe double mMass
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_mass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_mass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_mass(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_mass(_UnderlyingPtr);
                }
            }

            ///When a motionState is provided, the rigid body will initialize its world transform from the motion state
            ///In this case, m_startWorldTransform is ignored.
            public unsafe Bullet.BtMotionState? mMotionState
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_motionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_motionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtMotionState._Underlying **__btRigidBody_btRigidBodyConstructionInfo_Get_m_motionState(Const_BtRigidBodyConstructionInfo._Underlying *_this);
                    var ptr = __btRigidBody_btRigidBodyConstructionInfo_Get_m_motionState(_UnderlyingPtr);
                    Bullet.BtMotionState? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe Bullet.Const_BtTransform mStartWorldTransform
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_startWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_startWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtTransform._Underlying *__btRigidBody_btRigidBodyConstructionInfo_Get_m_startWorldTransform(_Underlying *_this);
                    Bullet.Const_BtTransform __ret;
                    __ret = new(__btRigidBody_btRigidBodyConstructionInfo_Get_m_startWorldTransform(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe Bullet.BtCollisionShape? mCollisionShape
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_collisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_collisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtCollisionShape._Underlying **__btRigidBody_btRigidBodyConstructionInfo_Get_m_collisionShape(Const_BtRigidBodyConstructionInfo._Underlying *_this);
                    var ptr = __btRigidBody_btRigidBodyConstructionInfo_Get_m_collisionShape(_UnderlyingPtr);
                    Bullet.BtCollisionShape? value = null;
                    if (*ptr is not null)
                    {
                        value = new(*ptr, is_owning: false);
                        value._KeepAliveEnclosingObject = this;
                    }
                    return value;
                }
            }

            public unsafe Bullet.Const_BtVector3 mLocalInertia
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_localInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_localInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.Const_BtVector3._Underlying *__btRigidBody_btRigidBodyConstructionInfo_Get_m_localInertia(_Underlying *_this);
                    Bullet.Const_BtVector3 __ret;
                    __ret = new(__btRigidBody_btRigidBodyConstructionInfo_Get_m_localInertia(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public unsafe double mLinearDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_linearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_linearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_linearDamping(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_linearDamping(_UnderlyingPtr);
                }
            }

            public unsafe double mAngularDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_angularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_angularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_angularDamping(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_angularDamping(_UnderlyingPtr);
                }
            }

            ///best simulation results when friction is non-zero
            public unsafe double mFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_friction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_friction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_friction(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_friction(_UnderlyingPtr);
                }
            }

            ///the m_rollingFriction prevents rounded shapes, such as spheres, cylinders and capsules from rolling forever.
            ///See Bullet/Demos/RollingFrictionDemo for usage
            public unsafe double mRollingFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_rollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_rollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_rollingFriction(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_rollingFriction(_UnderlyingPtr);
                }
            }

            //torsional friction around contact normal
            public unsafe double mSpinningFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_spinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_spinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_spinningFriction(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_spinningFriction(_UnderlyingPtr);
                }
            }

            ///best simulation results using zero restitution.
            public unsafe double mRestitution
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_restitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_restitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_restitution(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_restitution(_UnderlyingPtr);
                }
            }

            public unsafe double mLinearSleepingThreshold
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_linearSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_linearSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_linearSleepingThreshold(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_linearSleepingThreshold(_UnderlyingPtr);
                }
            }

            public unsafe double mAngularSleepingThreshold
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_angularSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_angularSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_angularSleepingThreshold(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_angularSleepingThreshold(_UnderlyingPtr);
                }
            }

            //Additional damping can help avoiding lowpass jitter motion, help stability for ragdolls etc.
            //Such damping is undesirable, so once the overall simulation quality of the rigid body dynamics system has improved, this should become obsolete
            public unsafe bool mAdditionalDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDamping(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDamping(_UnderlyingPtr);
                }
            }

            public unsafe double mAdditionalDampingFactor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDampingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDampingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDampingFactor(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalDampingFactor(_UnderlyingPtr);
                }
            }

            public unsafe double mAdditionalLinearDampingThresholdSqr
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalLinearDampingThresholdSqr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalLinearDampingThresholdSqr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalLinearDampingThresholdSqr(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalLinearDampingThresholdSqr(_UnderlyingPtr);
                }
            }

            public unsafe double mAdditionalAngularDampingThresholdSqr
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingThresholdSqr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingThresholdSqr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingThresholdSqr(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingThresholdSqr(_UnderlyingPtr);
                }
            }

            public unsafe double mAdditionalAngularDampingFactor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingFactor(_Underlying *_this);
                    return *__btRigidBody_btRigidBodyConstructionInfo_Get_m_additionalAngularDampingFactor(_UnderlyingPtr);
                }
            }

            internal unsafe Const_BtRigidBodyConstructionInfo(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

            /// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
            public unsafe Const_BtRigidBodyConstructionInfo(Bullet.BtRigidBody._ByValue_BtRigidBodyConstructionInfo _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtRigidBody.BtRigidBodyConstructionInfo._Underlying *__btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtRigidBody.BtRigidBodyConstructionInfo._Underlying *_other);
                _UnderlyingPtr = __btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
            public Const_BtRigidBodyConstructionInfo(Const_BtRigidBodyConstructionInfo _other) : this(new _ByValue_BtRigidBodyConstructionInfo(_other)) {}

            /// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
            public Const_BtRigidBodyConstructionInfo(BtRigidBodyConstructionInfo _other) : this((Const_BtRigidBodyConstructionInfo)_other) {}

            /// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
            /// Parameter `localInertia` defaults to `btVector3(0, 0, 0)`.
            public unsafe Const_BtRigidBodyConstructionInfo(double mass, Bullet.BtMotionState? motionState, Bullet.BtCollisionShape? collisionShape, Bullet.Const_BtVector3? localInertia = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtRigidBody.BtRigidBodyConstructionInfo._Underlying *__btRigidBody_btRigidBodyConstructionInfo_Construct(double mass, Bullet.BtMotionState._Underlying *motionState, Bullet.BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtVector3._Underlying *localInertia);
                _UnderlyingPtr = __btRigidBody_btRigidBodyConstructionInfo_Construct(mass, motionState is not null ? motionState._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, localInertia is not null ? localInertia._UnderlyingPtr : null);
            }
        }

        ///The btRigidBodyConstructionInfo structure provides information to create a rigid body. Setting mass to zero creates a fixed (non-dynamic) rigid body.
        ///For dynamic objects, you can use the collision shape to approximate the local inertia tensor, otherwise use the zero vector (default argument)
        ///You can use the motion state to synchronize the world transform between physics and graphics objects.
        ///And if the motion state is provided, the rigid body will initialize its initial world transform from the motion state,
        ///m_startWorldTransform is only used when you don't provide a motion state.
        /// Generated from class `btRigidBody::btRigidBodyConstructionInfo`.
        /// This is the non-const half of the class.
        public class BtRigidBodyConstructionInfo : Const_BtRigidBodyConstructionInfo
        {
            public new unsafe ref double mMass
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_mass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_mass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_mass(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_mass(_UnderlyingPtr);
                }
            }

            ///When a motionState is provided, the rigid body will initialize its world transform from the motion state
            ///In this case, m_startWorldTransform is ignored.
            public new unsafe Bullet.BtMotionState? mMotionState
            {
                get => base.mMotionState;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_motionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_motionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtMotionState._Underlying **__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_motionState(BtRigidBodyConstructionInfo._Underlying *_this);
                    var ptr = __btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_motionState(_UnderlyingPtr);
                    _DiscardKeepAlive("m_motionState");
                    if (value is not null)
                        _KeepAlive(value, "m_motionState");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe Bullet.BtTransform mStartWorldTransform
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_startWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_startWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtTransform._Underlying *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_startWorldTransform(_Underlying *_this);
                    Bullet.BtTransform __ret;
                    __ret = new(__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_startWorldTransform(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe Bullet.BtCollisionShape? mCollisionShape
            {
                get => base.mCollisionShape;
                set
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_collisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_collisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtCollisionShape._Underlying **__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_collisionShape(BtRigidBodyConstructionInfo._Underlying *_this);
                    var ptr = __btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_collisionShape(_UnderlyingPtr);
                    _DiscardKeepAlive("m_collisionShape");
                    if (value is not null)
                        _KeepAlive(value, "m_collisionShape");
                    *ptr = (value is not null ? value._UnderlyingPtr : null);
                }
            }

            public new unsafe Bullet.BtVector3 mLocalInertia
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_localInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_localInertia", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static Bullet.BtVector3._Underlying *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_localInertia(_Underlying *_this);
                    Bullet.BtVector3 __ret;
                    __ret = new(__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_localInertia(_UnderlyingPtr), is_owning: false);
                    __ret._KeepAliveEnclosingObject = this;
                    return __ret;
                }
            }

            public new unsafe ref double mLinearDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearDamping(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearDamping(_UnderlyingPtr);
                }
            }

            public new unsafe ref double mAngularDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularDamping(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularDamping(_UnderlyingPtr);
                }
            }

            ///best simulation results when friction is non-zero
            public new unsafe ref double mFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_friction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_friction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_friction(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_friction(_UnderlyingPtr);
                }
            }

            ///the m_rollingFriction prevents rounded shapes, such as spheres, cylinders and capsules from rolling forever.
            ///See Bullet/Demos/RollingFrictionDemo for usage
            public new unsafe ref double mRollingFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_rollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_rollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_rollingFriction(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_rollingFriction(_UnderlyingPtr);
                }
            }

            //torsional friction around contact normal
            public new unsafe ref double mSpinningFriction
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_spinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_spinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_spinningFriction(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_spinningFriction(_UnderlyingPtr);
                }
            }

            ///best simulation results using zero restitution.
            public new unsafe ref double mRestitution
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_restitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_restitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_restitution(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_restitution(_UnderlyingPtr);
                }
            }

            public new unsafe ref double mLinearSleepingThreshold
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearSleepingThreshold(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_linearSleepingThreshold(_UnderlyingPtr);
                }
            }

            public new unsafe ref double mAngularSleepingThreshold
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularSleepingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularSleepingThreshold(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_angularSleepingThreshold(_UnderlyingPtr);
                }
            }

            //Additional damping can help avoiding lowpass jitter motion, help stability for ragdolls etc.
            //Such damping is undesirable, so once the overall simulation quality of the rigid body dynamics system has improved, this should become obsolete
            public new unsafe ref bool mAdditionalDamping
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static bool *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDamping(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDamping(_UnderlyingPtr);
                }
            }

            public new unsafe ref double mAdditionalDampingFactor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDampingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDampingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDampingFactor(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalDampingFactor(_UnderlyingPtr);
                }
            }

            public new unsafe ref double mAdditionalLinearDampingThresholdSqr
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalLinearDampingThresholdSqr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalLinearDampingThresholdSqr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalLinearDampingThresholdSqr(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalLinearDampingThresholdSqr(_UnderlyingPtr);
                }
            }

            public new unsafe ref double mAdditionalAngularDampingThresholdSqr
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingThresholdSqr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingThresholdSqr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingThresholdSqr(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingThresholdSqr(_UnderlyingPtr);
                }
            }

            public new unsafe ref double mAdditionalAngularDampingFactor
            {
                get
                {
                    #if __IOS__
                    [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #else
                    [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                    #endif
                    extern static double *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingFactor(_Underlying *_this);
                    return ref *__btRigidBody_btRigidBodyConstructionInfo_GetMutable_m_additionalAngularDampingFactor(_UnderlyingPtr);
                }
            }

            internal unsafe BtRigidBodyConstructionInfo(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

            /// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
            public unsafe BtRigidBodyConstructionInfo(Bullet.BtRigidBody._ByValue_BtRigidBodyConstructionInfo _other) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtRigidBody.BtRigidBodyConstructionInfo._Underlying *__btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtRigidBody.BtRigidBodyConstructionInfo._Underlying *_other);
                _UnderlyingPtr = __btRigidBody_btRigidBodyConstructionInfo_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
                if (_other.Value is not null) _KeepAlive(_other.Value);
            }

            /// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
            public BtRigidBodyConstructionInfo(Const_BtRigidBodyConstructionInfo _other) : this(new _ByValue_BtRigidBodyConstructionInfo(_other)) {}

            /// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
            public BtRigidBodyConstructionInfo(BtRigidBodyConstructionInfo _other) : this((Const_BtRigidBodyConstructionInfo)_other) {}

            /// Generated from constructor `btRigidBody::btRigidBodyConstructionInfo::btRigidBodyConstructionInfo`.
            /// Parameter `localInertia` defaults to `btVector3(0, 0, 0)`.
            public unsafe BtRigidBodyConstructionInfo(double mass, Bullet.BtMotionState? motionState, Bullet.BtCollisionShape? collisionShape, Bullet.Const_BtVector3? localInertia = null) : this(null, is_owning: true)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtRigidBody.BtRigidBodyConstructionInfo._Underlying *__btRigidBody_btRigidBodyConstructionInfo_Construct(double mass, Bullet.BtMotionState._Underlying *motionState, Bullet.BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtVector3._Underlying *localInertia);
                _UnderlyingPtr = __btRigidBody_btRigidBodyConstructionInfo_Construct(mass, motionState is not null ? motionState._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, localInertia is not null ? localInertia._UnderlyingPtr : null);
            }

            /// Generated from method `btRigidBody::btRigidBodyConstructionInfo::operator=`.
            public unsafe Bullet.BtRigidBody.BtRigidBodyConstructionInfo Assign(Bullet.BtRigidBody._ByValue_BtRigidBodyConstructionInfo _other)
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_btRigidBodyConstructionInfo_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtRigidBody.BtRigidBodyConstructionInfo._Underlying *__btRigidBody_btRigidBodyConstructionInfo_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtRigidBody.BtRigidBodyConstructionInfo._Underlying *_other);
                _DiscardKeepAlive();
                if (_other.Value is not null) _KeepAlive(_other.Value);
                return new(__btRigidBody_btRigidBodyConstructionInfo_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
            }
        }

        /// This is used as a function parameter when the underlying function receives `BtRigidBodyConstructionInfo` by value.
        /// Usage:
        /// * Pass an instance of `BtRigidBodyConstructionInfo`/`Const_BtRigidBodyConstructionInfo` to copy it into the function.
        /// * Pass `Move(instance)` to move it into the function. This is a more efficient form of copying that might invalidate the input object.
        ///   Be careful if your input isn't a unique reference to this object.
        /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
        public class _ByValue_BtRigidBodyConstructionInfo
        {
            #pragma warning disable CS0649
            internal readonly Const_BtRigidBodyConstructionInfo? Value;
            #pragma warning restore CS0649
            internal readonly Bullet._PassBy PassByMode;
            public _ByValue_BtRigidBodyConstructionInfo(Const_BtRigidBodyConstructionInfo new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
            public static implicit operator _ByValue_BtRigidBodyConstructionInfo(Const_BtRigidBodyConstructionInfo arg) {return new(arg);}
            public _ByValue_BtRigidBodyConstructionInfo(Bullet._Moved<BtRigidBodyConstructionInfo> moved) {Value = moved.Value; PassByMode = Bullet._PassBy.move;}
            public static implicit operator _ByValue_BtRigidBodyConstructionInfo(Bullet._Moved<BtRigidBodyConstructionInfo> arg) {return new(arg);}
        }

        /// This is used for optional parameters of class `BtRigidBodyConstructionInfo` with default arguments.
        /// This is only used mutable parameters. For const ones we have `_InOptConst_BtRigidBodyConstructionInfo`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `BtRigidBodyConstructionInfo`/`Const_BtRigidBodyConstructionInfo` directly.
        public class _InOptMut_BtRigidBodyConstructionInfo
        {
            public BtRigidBodyConstructionInfo? Opt;

            public _InOptMut_BtRigidBodyConstructionInfo() {}
            public _InOptMut_BtRigidBodyConstructionInfo(BtRigidBodyConstructionInfo value) {Opt = value;}
            public static implicit operator _InOptMut_BtRigidBodyConstructionInfo(BtRigidBodyConstructionInfo value) {return new(value);}
        }

        /// This is used for optional parameters of class `BtRigidBodyConstructionInfo` with default arguments.
        /// This is only used const parameters. For non-const ones we have `_InOptMut_BtRigidBodyConstructionInfo`.
        /// Usage:
        /// * Pass `null` to use the default argument.
        /// * Pass `new()` to pass no object.
        /// * Pass an instance of `BtRigidBodyConstructionInfo`/`Const_BtRigidBodyConstructionInfo` to pass it to the function.
        public class _InOptConst_BtRigidBodyConstructionInfo
        {
            public Const_BtRigidBodyConstructionInfo? Opt;

            public _InOptConst_BtRigidBodyConstructionInfo() {}
            public _InOptConst_BtRigidBodyConstructionInfo(Const_BtRigidBodyConstructionInfo value) {Opt = value;}
            public static implicit operator _InOptConst_BtRigidBodyConstructionInfo(Const_BtRigidBodyConstructionInfo value) {return new(value);}
        }
    }

    ///The btRigidBody is the main class for rigid body objects. It is derived from btCollisionObject, so it keeps a pointer to a btCollisionShape.
    ///It is recommended for performance and memory use to share btCollisionShape objects whenever possible.
    ///There are 3 types of rigid bodies:
    ///- A) Dynamic rigid bodies, with positive mass. Motion is controlled by rigid body dynamics.
    ///- B) Fixed objects with zero mass. They are not moving (basically collision objects)
    ///- C) Kinematic objects, which are objects without mass, but the user can move them. There is one-way interaction, and Bullet calculates a velocity based on the timestep and previous and current world transform.
    ///Bullet automatically deactivates dynamic rigid bodies, when the velocity is below a threshold for a given time.
    ///Deactivated (sleeping) rigid bodies don't take any processing time, except a minor broadphase collision detection impact (to allow active objects to activate/wake up sleeping objects)
    /// Generated from class `btRigidBody`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btCollisionObject`
    /// This is the non-const half of the class.
    public class BtRigidBody : Const_BtRigidBody
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtCollisionObject(BtRigidBody self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_UpcastTo_btCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_UpcastTo_btCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionObject._Underlying *__btRigidBody_UpcastTo_btCollisionObject(_Underlying *_this);
            Bullet.BtCollisionObject ret = new(__btRigidBody_UpcastTo_btCollisionObject(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtRigidBody?(Bullet.BtCollisionObject parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_DynamicDowncastFrom_btCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_DynamicDowncastFrom_btCollisionObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btRigidBody_DynamicDowncastFrom_btCollisionObject(Bullet.BtCollisionObject._Underlying *_this);
            var ptr = __btRigidBody_DynamicDowncastFrom_btCollisionObject(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtRigidBody ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        //for experimental overriding of friction/contact solver func
        public new unsafe ref int mContactSolverType
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_GetMutable_m_contactSolverType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_GetMutable_m_contactSolverType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btRigidBody_GetMutable_m_contactSolverType(_Underlying *_this);
                return ref *__btRigidBody_GetMutable_m_contactSolverType(_UnderlyingPtr);
            }
        }

        public new unsafe ref int mFrictionSolverType
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_GetMutable_m_frictionSolverType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_GetMutable_m_frictionSolverType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btRigidBody_GetMutable_m_frictionSolverType(_Underlying *_this);
                return ref *__btRigidBody_GetMutable_m_frictionSolverType(_UnderlyingPtr);
            }
        }

        internal unsafe BtRigidBody(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Generated from constructor `btRigidBody::btRigidBody`.
        public unsafe BtRigidBody(Bullet._ByValue_BtRigidBody _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtRigidBody._Underlying *__btRigidBody_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtRigidBody._Underlying *_other);
            _UnderlyingPtr = __btRigidBody_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btRigidBody::btRigidBody`.
        public BtRigidBody(Const_BtRigidBody _other) : this(new _ByValue_BtRigidBody(_other)) {}

        /// Generated from constructor `btRigidBody::btRigidBody`.
        public BtRigidBody(BtRigidBody _other) : this((Const_BtRigidBody)_other) {}

        ///btRigidBody constructor using construction info
        /// Generated from constructor `btRigidBody::btRigidBody`.
        public unsafe BtRigidBody(Bullet.BtRigidBody.Const_BtRigidBodyConstructionInfo constructionInfo) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtRigidBody._Underlying *__btRigidBody_Construct_1(Bullet.BtRigidBody.Const_BtRigidBodyConstructionInfo._Underlying *constructionInfo);
            _UnderlyingPtr = __btRigidBody_Construct_1(constructionInfo._UnderlyingPtr);
        }

        ///btRigidBody constructor using construction info
        /// Generated from constructor `btRigidBody::btRigidBody`.
        public static unsafe implicit operator BtRigidBody(Bullet.BtRigidBody.Const_BtRigidBodyConstructionInfo constructionInfo) {return new(constructionInfo);}

        ///btRigidBody constructor for backwards compatibility.
        ///To specify friction (etc) during rigid body construction, please use the other constructor (using btRigidBodyConstructionInfo)
        /// Generated from constructor `btRigidBody::btRigidBody`.
        /// Parameter `localInertia` defaults to `btVector3(0, 0, 0)`.
        public unsafe BtRigidBody(double mass, Bullet.BtMotionState? motionState, Bullet.BtCollisionShape? collisionShape, Bullet.Const_BtVector3? localInertia = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtRigidBody._Underlying *__btRigidBody_Construct_4(double mass, Bullet.BtMotionState._Underlying *motionState, Bullet.BtCollisionShape._Underlying *collisionShape, Bullet.Const_BtVector3._Underlying *localInertia);
            _UnderlyingPtr = __btRigidBody_Construct_4(mass, motionState is not null ? motionState._UnderlyingPtr : null, collisionShape is not null ? collisionShape._UnderlyingPtr : null, localInertia is not null ? localInertia._UnderlyingPtr : null);
        }

        /// Generated from method `btRigidBody::operator=`.
        public unsafe Bullet.BtRigidBody Assign(Bullet._ByValue_BtRigidBody _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtRigidBody._Underlying *__btRigidBody_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtRigidBody._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btRigidBody_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btRigidBody::proceedToTransform`.
        public unsafe void ProceedToTransform(Bullet.Const_BtTransform newTrans)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_proceedToTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_proceedToTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_proceedToTransform(_Underlying *_this, Bullet.Const_BtTransform._Underlying *newTrans);
            __btRigidBody_proceedToTransform(_UnderlyingPtr, newTrans._UnderlyingPtr);
        }

        /// continuous collision detection needs prediction
        /// Generated from method `btRigidBody::predictIntegratedTransform`.
        public unsafe void PredictIntegratedTransform(double step, Bullet.BtTransform predictedTransform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_predictIntegratedTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_predictIntegratedTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_predictIntegratedTransform(_Underlying *_this, double step, Bullet.BtTransform._Underlying *predictedTransform);
            __btRigidBody_predictIntegratedTransform(_UnderlyingPtr, step, predictedTransform._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::saveKinematicState`.
        public unsafe void SaveKinematicState(double step)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_saveKinematicState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_saveKinematicState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_saveKinematicState(_Underlying *_this, double step);
            __btRigidBody_saveKinematicState(_UnderlyingPtr, step);
        }

        /// Generated from method `btRigidBody::applyGravity`.
        public unsafe void ApplyGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyGravity(_Underlying *_this);
            __btRigidBody_applyGravity(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::clearGravity`.
        public unsafe void ClearGravity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_clearGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_clearGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_clearGravity(_Underlying *_this);
            __btRigidBody_clearGravity(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setGravity`.
        public unsafe void SetGravity(Bullet.Const_BtVector3 acceleration)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setGravity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setGravity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *acceleration);
            __btRigidBody_setGravity(_UnderlyingPtr, acceleration._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setDamping`.
        public unsafe void SetDamping(double lin_damping, double ang_damping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setDamping(_Underlying *_this, double lin_damping, double ang_damping);
            __btRigidBody_setDamping(_UnderlyingPtr, lin_damping, ang_damping);
        }

        /// Generated from method `btRigidBody::applyDamping`.
        public unsafe void ApplyDamping(double timeStep)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyDamping(_Underlying *_this, double timeStep);
            __btRigidBody_applyDamping(_UnderlyingPtr, timeStep);
        }

        /// Generated from method `btRigidBody::getCollisionShape`.
        public unsafe new Bullet.BtCollisionShape? GetCollisionShape()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getCollisionShape_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getCollisionShape_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionShape._Underlying *__btRigidBody_getCollisionShape_mut(_Underlying *_this);
            var __c_ret = __btRigidBody_getCollisionShape_mut(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtCollisionShape(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btRigidBody::setMassProps`.
        public unsafe void SetMassProps(double mass, Bullet.Const_BtVector3 inertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setMassProps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setMassProps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setMassProps(_Underlying *_this, double mass, Bullet.Const_BtVector3._Underlying *inertia);
            __btRigidBody_setMassProps(_UnderlyingPtr, mass, inertia._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setLinearFactor`.
        public unsafe void SetLinearFactor(Bullet.Const_BtVector3 linearFactor)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setLinearFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setLinearFactor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setLinearFactor(_Underlying *_this, Bullet.Const_BtVector3._Underlying *linearFactor);
            __btRigidBody_setLinearFactor(_UnderlyingPtr, linearFactor._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::integrateVelocities`.
        public unsafe void IntegrateVelocities(double step)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_integrateVelocities", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_integrateVelocities", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_integrateVelocities(_Underlying *_this, double step);
            __btRigidBody_integrateVelocities(_UnderlyingPtr, step);
        }

        /// Generated from method `btRigidBody::setCenterOfMassTransform`.
        public unsafe void SetCenterOfMassTransform(Bullet.Const_BtTransform xform)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setCenterOfMassTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setCenterOfMassTransform(_Underlying *_this, Bullet.Const_BtTransform._Underlying *xform);
            __btRigidBody_setCenterOfMassTransform(_UnderlyingPtr, xform._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::applyCentralForce`.
        public unsafe void ApplyCentralForce(Bullet.Const_BtVector3 force)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyCentralForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyCentralForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyCentralForce(_Underlying *_this, Bullet.Const_BtVector3._Underlying *force);
            __btRigidBody_applyCentralForce(_UnderlyingPtr, force._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setInvInertiaDiagLocal`.
        public unsafe void SetInvInertiaDiagLocal(Bullet.Const_BtVector3 diagInvInertia)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setInvInertiaDiagLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setInvInertiaDiagLocal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setInvInertiaDiagLocal(_Underlying *_this, Bullet.Const_BtVector3._Underlying *diagInvInertia);
            __btRigidBody_setInvInertiaDiagLocal(_UnderlyingPtr, diagInvInertia._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setSleepingThresholds`.
        public unsafe void SetSleepingThresholds(double linear, double angular)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setSleepingThresholds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setSleepingThresholds", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setSleepingThresholds(_Underlying *_this, double linear, double angular);
            __btRigidBody_setSleepingThresholds(_UnderlyingPtr, linear, angular);
        }

        /// Generated from method `btRigidBody::applyTorque`.
        public unsafe void ApplyTorque(Bullet.Const_BtVector3 torque)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyTorque", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyTorque(_Underlying *_this, Bullet.Const_BtVector3._Underlying *torque);
            __btRigidBody_applyTorque(_UnderlyingPtr, torque._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::applyForce`.
        public unsafe void ApplyForce(Bullet.Const_BtVector3 force, Bullet.Const_BtVector3 rel_pos)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyForce", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyForce(_Underlying *_this, Bullet.Const_BtVector3._Underlying *force, Bullet.Const_BtVector3._Underlying *rel_pos);
            __btRigidBody_applyForce(_UnderlyingPtr, force._UnderlyingPtr, rel_pos._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::applyCentralImpulse`.
        public unsafe void ApplyCentralImpulse(Bullet.Const_BtVector3 impulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyCentralImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyCentralImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyCentralImpulse(_Underlying *_this, Bullet.Const_BtVector3._Underlying *impulse);
            __btRigidBody_applyCentralImpulse(_UnderlyingPtr, impulse._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::applyTorqueImpulse`.
        public unsafe void ApplyTorqueImpulse(Bullet.Const_BtVector3 torque)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyTorqueImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyTorqueImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyTorqueImpulse(_Underlying *_this, Bullet.Const_BtVector3._Underlying *torque);
            __btRigidBody_applyTorqueImpulse(_UnderlyingPtr, torque._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::applyImpulse`.
        public unsafe void ApplyImpulse(Bullet.Const_BtVector3 impulse, Bullet.Const_BtVector3 rel_pos)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyImpulse(_Underlying *_this, Bullet.Const_BtVector3._Underlying *impulse, Bullet.Const_BtVector3._Underlying *rel_pos);
            __btRigidBody_applyImpulse(_UnderlyingPtr, impulse._UnderlyingPtr, rel_pos._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::applyPushImpulse`.
        public unsafe void ApplyPushImpulse(Bullet.Const_BtVector3 impulse, Bullet.Const_BtVector3 rel_pos)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyPushImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyPushImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyPushImpulse(_Underlying *_this, Bullet.Const_BtVector3._Underlying *impulse, Bullet.Const_BtVector3._Underlying *rel_pos);
            __btRigidBody_applyPushImpulse(_UnderlyingPtr, impulse._UnderlyingPtr, rel_pos._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setPushVelocity`.
        public unsafe void SetPushVelocity(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setPushVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setPushVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setPushVelocity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            __btRigidBody_setPushVelocity(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setTurnVelocity`.
        public unsafe void SetTurnVelocity(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setTurnVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setTurnVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setTurnVelocity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            __btRigidBody_setTurnVelocity(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::applyCentralPushImpulse`.
        public unsafe void ApplyCentralPushImpulse(Bullet.Const_BtVector3 impulse)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyCentralPushImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyCentralPushImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyCentralPushImpulse(_Underlying *_this, Bullet.Const_BtVector3._Underlying *impulse);
            __btRigidBody_applyCentralPushImpulse(_UnderlyingPtr, impulse._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::applyTorqueTurnImpulse`.
        public unsafe void ApplyTorqueTurnImpulse(Bullet.Const_BtVector3 torque)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_applyTorqueTurnImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_applyTorqueTurnImpulse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_applyTorqueTurnImpulse(_Underlying *_this, Bullet.Const_BtVector3._Underlying *torque);
            __btRigidBody_applyTorqueTurnImpulse(_UnderlyingPtr, torque._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::clearForces`.
        public unsafe void ClearForces()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_clearForces", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_clearForces", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_clearForces(_Underlying *_this);
            __btRigidBody_clearForces(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::updateInertiaTensor`.
        public unsafe void UpdateInertiaTensor()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_updateInertiaTensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_updateInertiaTensor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_updateInertiaTensor(_Underlying *_this);
            __btRigidBody_updateInertiaTensor(_UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setLinearVelocity`.
        public unsafe void SetLinearVelocity(Bullet.Const_BtVector3 lin_vel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setLinearVelocity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *lin_vel);
            __btRigidBody_setLinearVelocity(_UnderlyingPtr, lin_vel._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setAngularVelocity`.
        public unsafe void SetAngularVelocity(Bullet.Const_BtVector3 ang_vel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setAngularVelocity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *ang_vel);
            __btRigidBody_setAngularVelocity(_UnderlyingPtr, ang_vel._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::translate`.
        public unsafe void Translate(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_translate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_translate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_translate(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            __btRigidBody_translate(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::updateDeactivation`.
        public unsafe void UpdateDeactivation(double timeStep)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_updateDeactivation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_updateDeactivation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_updateDeactivation(_Underlying *_this, double timeStep);
            __btRigidBody_updateDeactivation(_UnderlyingPtr, timeStep);
        }

        /// Generated from method `btRigidBody::wantsSleeping`.
        public unsafe bool WantsSleeping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_wantsSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_wantsSleeping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btRigidBody_wantsSleeping(_Underlying *_this);
            return __btRigidBody_wantsSleeping(_UnderlyingPtr) != 0;
        }

        //btMotionState allows to automatic synchronize the world transform for active objects
        /// Generated from method `btRigidBody::getMotionState`.
        public unsafe new Bullet.BtMotionState? GetMotionState()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getMotionState_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getMotionState_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMotionState._Underlying *__btRigidBody_getMotionState_mut(_Underlying *_this);
            var __c_ret = __btRigidBody_getMotionState_mut(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtMotionState(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btRigidBody::setMotionState`.
        public unsafe void SetMotionState(Bullet.BtMotionState? motionState)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setMotionState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setMotionState(_Underlying *_this, Bullet.BtMotionState._Underlying *motionState);
            __btRigidBody_setMotionState(_UnderlyingPtr, motionState is not null ? motionState._UnderlyingPtr : null);
        }

        /// Generated from method `btRigidBody::setAngularFactor`.
        public unsafe void SetAngularFactor(Bullet.Const_BtVector3 angFac)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setAngularFactor_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setAngularFactor_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setAngularFactor_btVector3(_Underlying *_this, Bullet.Const_BtVector3._Underlying *angFac);
            __btRigidBody_setAngularFactor_btVector3(_UnderlyingPtr, angFac._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setAngularFactor`.
        public unsafe void SetAngularFactor(double angFac)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setAngularFactor_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setAngularFactor_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setAngularFactor_double(_Underlying *_this, double angFac);
            __btRigidBody_setAngularFactor_double(_UnderlyingPtr, angFac);
        }

        /// Generated from method `btRigidBody::setFlags`.
        public unsafe void SetFlags(int flags)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setFlags(_Underlying *_this, int flags);
            __btRigidBody_setFlags(_UnderlyingPtr, flags);
        }

        /// Generated from method `btRigidBody::setAnisotropicFriction`.
        /// Parameter `frictionMode` defaults to `CF_ANISOTROPIC_FRICTION`.
        public unsafe void SetAnisotropicFriction(Bullet.Const_BtVector3 anisotropicFriction, int? frictionMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setAnisotropicFriction(_Underlying *_this, Bullet.Const_BtVector3._Underlying *anisotropicFriction, int *frictionMode);
            int __deref_frictionMode = frictionMode.GetValueOrDefault();
            __btRigidBody_setAnisotropicFriction(_UnderlyingPtr, anisotropicFriction._UnderlyingPtr, frictionMode.HasValue ? &__deref_frictionMode : null);
        }

        ///the constraint solver can discard solving contacts, if the distance is above this threshold. 0 by default.
        ///Note that using contacts with positive distance can improve stability. It increases, however, the chance of colliding with degerate contacts, such as 'interior' triangle edges
        /// Generated from method `btRigidBody::setContactProcessingThreshold`.
        public unsafe void SetContactProcessingThreshold(double contactProcessingThreshold)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setContactProcessingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setContactProcessingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setContactProcessingThreshold(_Underlying *_this, double contactProcessingThreshold);
            __btRigidBody_setContactProcessingThreshold(_UnderlyingPtr, contactProcessingThreshold);
        }

        /// Generated from method `btRigidBody::setCollisionShape`.
        public unsafe void SetCollisionShape(Bullet.BtCollisionShape? collisionShape)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setCollisionShape(_Underlying *_this, Bullet.BtCollisionShape._Underlying *collisionShape);
            __btRigidBody_setCollisionShape(_UnderlyingPtr, collisionShape is not null ? collisionShape._UnderlyingPtr : null);
        }

        /// Generated from method `btRigidBody::setIgnoreCollisionCheck`.
        public unsafe void SetIgnoreCollisionCheck(Bullet.Const_BtCollisionObject? co, bool ignoreCollisionCheck)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setIgnoreCollisionCheck", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setIgnoreCollisionCheck", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setIgnoreCollisionCheck(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *co, byte ignoreCollisionCheck);
            __btRigidBody_setIgnoreCollisionCheck(_UnderlyingPtr, co is not null ? co._UnderlyingPtr : null, ignoreCollisionCheck ? (byte)1 : (byte)0);
        }

        /// Generated from method `btRigidBody::getObjectWithoutCollision`.
        public unsafe Bullet.Const_BtCollisionObject? GetObjectWithoutCollision(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_getObjectWithoutCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_getObjectWithoutCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionObject._Underlying *__btRigidBody_getObjectWithoutCollision(_Underlying *_this, int index);
            var __c_ret = __btRigidBody_getObjectWithoutCollision(_UnderlyingPtr, index);
            return __c_ret is not null ? new Bullet.Const_BtCollisionObject(__c_ret, is_owning: false) : null;
        }

        ///Avoid using this internal API call, the extension pointer is used by some Bullet extensions
        ///If you need to store your own user pointer, use 'setUserPointer/getUserPointer' instead.
        /// Generated from method `btRigidBody::internalSetExtensionPointer`.
        /// Parameter `pointer` is a mutable pointer.
        public unsafe void InternalSetExtensionPointer(void *pointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_internalSetExtensionPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_internalSetExtensionPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_internalSetExtensionPointer(_Underlying *_this, void *pointer);
            __btRigidBody_internalSetExtensionPointer(_UnderlyingPtr, pointer);
        }

        /// Generated from method `btRigidBody::setDeactivationTime`.
        public unsafe void SetDeactivationTime(double time)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setDeactivationTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setDeactivationTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setDeactivationTime(_Underlying *_this, double time);
            __btRigidBody_setDeactivationTime(_UnderlyingPtr, time);
        }

        /// Generated from method `btRigidBody::setRestitution`.
        public unsafe void SetRestitution(double rest)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setRestitution(_Underlying *_this, double rest);
            __btRigidBody_setRestitution(_UnderlyingPtr, rest);
        }

        /// Generated from method `btRigidBody::setFriction`.
        public unsafe void SetFriction(double frict)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setFriction(_Underlying *_this, double frict);
            __btRigidBody_setFriction(_UnderlyingPtr, frict);
        }

        /// Generated from method `btRigidBody::setRollingFriction`.
        public unsafe void SetRollingFriction(double frict)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setRollingFriction(_Underlying *_this, double frict);
            __btRigidBody_setRollingFriction(_UnderlyingPtr, frict);
        }

        /// Generated from method `btRigidBody::setSpinningFriction`.
        public unsafe void SetSpinningFriction(double frict)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setSpinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setSpinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setSpinningFriction(_Underlying *_this, double frict);
            __btRigidBody_setSpinningFriction(_UnderlyingPtr, frict);
        }

        /// Generated from method `btRigidBody::setContactStiffnessAndDamping`.
        public unsafe void SetContactStiffnessAndDamping(double stiffness, double damping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setContactStiffnessAndDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setContactStiffnessAndDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setContactStiffnessAndDamping(_Underlying *_this, double stiffness, double damping);
            __btRigidBody_setContactStiffnessAndDamping(_UnderlyingPtr, stiffness, damping);
        }

        /// Generated from method `btRigidBody::setWorldTransform`.
        public unsafe void SetWorldTransform(Bullet.Const_BtTransform worldTrans)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setWorldTransform(_Underlying *_this, Bullet.Const_BtTransform._Underlying *worldTrans);
            __btRigidBody_setWorldTransform(_UnderlyingPtr, worldTrans._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setInterpolationWorldTransform`.
        public unsafe void SetInterpolationWorldTransform(Bullet.Const_BtTransform trans)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setInterpolationWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setInterpolationWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setInterpolationWorldTransform(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans);
            __btRigidBody_setInterpolationWorldTransform(_UnderlyingPtr, trans._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setInterpolationLinearVelocity`.
        public unsafe void SetInterpolationLinearVelocity(Bullet.Const_BtVector3 linvel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setInterpolationLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setInterpolationLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setInterpolationLinearVelocity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *linvel);
            __btRigidBody_setInterpolationLinearVelocity(_UnderlyingPtr, linvel._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setInterpolationAngularVelocity`.
        public unsafe void SetInterpolationAngularVelocity(Bullet.Const_BtVector3 angvel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setInterpolationAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setInterpolationAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setInterpolationAngularVelocity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *angvel);
            __btRigidBody_setInterpolationAngularVelocity(_UnderlyingPtr, angvel._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::setIslandTag`.
        public unsafe void SetIslandTag(int tag)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setIslandTag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setIslandTag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setIslandTag(_Underlying *_this, int tag);
            __btRigidBody_setIslandTag(_UnderlyingPtr, tag);
        }

        /// Generated from method `btRigidBody::setCompanionId`.
        public unsafe void SetCompanionId(int id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setCompanionId", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setCompanionId", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setCompanionId(_Underlying *_this, int id);
            __btRigidBody_setCompanionId(_UnderlyingPtr, id);
        }

        // only should be called by CollisionWorld
        /// Generated from method `btRigidBody::setWorldArrayIndex`.
        public unsafe void SetWorldArrayIndex(int ix)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setWorldArrayIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setWorldArrayIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setWorldArrayIndex(_Underlying *_this, int ix);
            __btRigidBody_setWorldArrayIndex(_UnderlyingPtr, ix);
        }

        /// Generated from method `btRigidBody::setHitFraction`.
        public unsafe void SetHitFraction(double hitFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setHitFraction(_Underlying *_this, double hitFraction);
            __btRigidBody_setHitFraction(_UnderlyingPtr, hitFraction);
        }

        /// Generated from method `btRigidBody::setCollisionFlags`.
        public unsafe void SetCollisionFlags(int flags)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setCollisionFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setCollisionFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setCollisionFlags(_Underlying *_this, int flags);
            __btRigidBody_setCollisionFlags(_UnderlyingPtr, flags);
        }

        ///Swept sphere radius (0.0 by default), see btConvexConvexAlgorithm::
        /// Generated from method `btRigidBody::setCcdSweptSphereRadius`.
        public unsafe void SetCcdSweptSphereRadius(double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setCcdSweptSphereRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setCcdSweptSphereRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setCcdSweptSphereRadius(_Underlying *_this, double radius);
            __btRigidBody_setCcdSweptSphereRadius(_UnderlyingPtr, radius);
        }

        /// Don't do continuous collision detection if the motion (in one step) is less then m_ccdMotionThreshold
        /// Generated from method `btRigidBody::setCcdMotionThreshold`.
        public unsafe void SetCcdMotionThreshold(double ccdMotionThreshold)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setCcdMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setCcdMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setCcdMotionThreshold(_Underlying *_this, double ccdMotionThreshold);
            __btRigidBody_setCcdMotionThreshold(_UnderlyingPtr, ccdMotionThreshold);
        }

        ///users can point to their objects, userPointer is not used by Bullet
        /// Generated from method `btRigidBody::setUserPointer`.
        /// Parameter `userPointer` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setUserPointer(_Underlying *_this, void *userPointer);
            __btRigidBody_setUserPointer(_UnderlyingPtr, userPointer);
        }

        ///users can point to their objects, userPointer is not used by Bullet
        /// Generated from method `btRigidBody::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setUserIndex(_Underlying *_this, int index);
            __btRigidBody_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btRigidBody::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setUserIndex2(_Underlying *_this, int index);
            __btRigidBody_setUserIndex2(_UnderlyingPtr, index);
        }

        /// Generated from method `btRigidBody::setUserIndex3`.
        public unsafe void SetUserIndex3(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setUserIndex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setUserIndex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setUserIndex3(_Underlying *_this, int index);
            __btRigidBody_setUserIndex3(_UnderlyingPtr, index);
        }

        /// Generated from method `btRigidBody::setCustomDebugColor`.
        public unsafe void SetCustomDebugColor(Bullet.Const_BtVector3 colorRGB)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_setCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_setCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_setCustomDebugColor(_Underlying *_this, Bullet.Const_BtVector3._Underlying *colorRGB);
            __btRigidBody_setCustomDebugColor(_UnderlyingPtr, colorRGB._UnderlyingPtr);
        }

        /// Generated from method `btRigidBody::removeCustomDebugColor`.
        public unsafe void RemoveCustomDebugColor()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btRigidBody_removeCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btRigidBody_removeCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btRigidBody_removeCustomDebugColor(_Underlying *_this);
            __btRigidBody_removeCustomDebugColor(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtRigidBody` by value.
    /// Usage:
    /// * Pass an instance of `BtRigidBody`/`Const_BtRigidBody` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtRigidBody
    {
        #pragma warning disable CS0649
        internal readonly Const_BtRigidBody? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtRigidBody(Const_BtRigidBody new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtRigidBody(Const_BtRigidBody arg) {return new(arg);}

        ///btRigidBody constructor using construction info
        /// Generated from constructor `btRigidBody::btRigidBody`.
        public static unsafe implicit operator _ByValue_BtRigidBody(Bullet.BtRigidBody.Const_BtRigidBodyConstructionInfo constructionInfo) {return new Bullet.BtRigidBody(constructionInfo);}
    }

    /// This is used for optional parameters of class `BtRigidBody` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtRigidBody`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtRigidBody`/`Const_BtRigidBody` directly.
    public class _InOptMut_BtRigidBody
    {
        public BtRigidBody? Opt;

        public _InOptMut_BtRigidBody() {}
        public _InOptMut_BtRigidBody(BtRigidBody value) {Opt = value;}
        public static implicit operator _InOptMut_BtRigidBody(BtRigidBody value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtRigidBody` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtRigidBody`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtRigidBody`/`Const_BtRigidBody` to pass it to the function.
    public class _InOptConst_BtRigidBody
    {
        public Const_BtRigidBody? Opt;

        public _InOptConst_BtRigidBody() {}
        public _InOptConst_BtRigidBody(Const_BtRigidBody value) {Opt = value;}
        public static implicit operator _InOptConst_BtRigidBody(Const_BtRigidBody value) {return new(value);}

        ///btRigidBody constructor using construction info
        /// Generated from constructor `btRigidBody::btRigidBody`.
        public static unsafe implicit operator _InOptConst_BtRigidBody(Bullet.BtRigidBody.Const_BtRigidBodyConstructionInfo constructionInfo) {return new Const_BtRigidBody(constructionInfo);}
    }
}
