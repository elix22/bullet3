// machine generated, do not edit
public static partial class Bullet
{
    ///The btDbvtBroadphase implements a broadphase using two dynamic AABB bounding volume hierarchies/trees (see btDbvt).
    ///One tree is used for static/non-moving objects, and another tree is used for dynamic objects. Objects can move from one tree to the other.
    ///This is a very fast broadphase, especially for very dynamic worlds where many objects are moving. Its insert/add and remove of objects is generally faster than the sweep and prune broadphases btAxisSweep3 and bt32BitAxisSweep3.
    /// Generated from class `btDbvtBroadphase`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btBroadphaseInterface`
    /// This is the const half of the class.
    public class Const_BtDbvtBroadphase : Bullet.Object<Const_BtDbvtBroadphase>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_Destroy(_Underlying *_this);
            __btDbvtBroadphase_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtDbvtBroadphase() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtBroadphaseInterface(Const_BtDbvtBroadphase self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_UpcastTo_btBroadphaseInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_UpcastTo_btBroadphaseInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtBroadphaseInterface._Underlying *__btDbvtBroadphase_UpcastTo_btBroadphaseInterface(_Underlying *_this);
            Bullet.Const_BtBroadphaseInterface ret = new(__btDbvtBroadphase_UpcastTo_btBroadphaseInterface(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator Const_BtDbvtBroadphase?(Bullet.Const_BtBroadphaseInterface parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface(Bullet.Const_BtBroadphaseInterface._Underlying *_this);
            var ptr = __btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface(parent._UnderlyingPtr);
            if (ptr is null) return null;
            Const_BtDbvtBroadphase ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        // Pair cache
        public unsafe Bullet.BtOverlappingPairCache? mPaircache
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_paircache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_paircache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtOverlappingPairCache._Underlying **__btDbvtBroadphase_Get_m_paircache(Const_BtDbvtBroadphase._Underlying *_this);
                var ptr = __btDbvtBroadphase_Get_m_paircache(_UnderlyingPtr);
                Bullet.BtOverlappingPairCache? value = null;
                if (*ptr is not null)
                {
                    value = new(*ptr, is_owning: false);
                    value._KeepAliveEnclosingObject = this;
                }
                return value;
            }
        }

        // Velocity prediction
        public unsafe double mPrediction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_prediction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_prediction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__btDbvtBroadphase_Get_m_prediction(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_prediction(_UnderlyingPtr);
            }
        }

        // Current stage
        public unsafe int mStageCurrent
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_stageCurrent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_stageCurrent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_Get_m_stageCurrent(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_stageCurrent(_UnderlyingPtr);
            }
        }

        // % of fixed updates per frame
        public unsafe int mFupdates
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_fupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_fupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_Get_m_fupdates(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_fupdates(_UnderlyingPtr);
            }
        }

        // % of dynamic updates per frame
        public unsafe int mDupdates
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_dupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_dupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_Get_m_dupdates(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_dupdates(_UnderlyingPtr);
            }
        }

        // % of cleanup updates per frame
        public unsafe int mCupdates
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_cupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_cupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_Get_m_cupdates(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_cupdates(_UnderlyingPtr);
            }
        }

        // Number of pairs created
        public unsafe int mNewpairs
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_newpairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_newpairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_Get_m_newpairs(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_newpairs(_UnderlyingPtr);
            }
        }

        // Fixed optimization left
        public unsafe int mFixedleft
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_fixedleft", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_fixedleft", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_Get_m_fixedleft(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_fixedleft(_UnderlyingPtr);
            }
        }

        // Number of updates call
        public unsafe uint mUpdatesCall
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_updates_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_updates_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__btDbvtBroadphase_Get_m_updates_call(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_updates_call(_UnderlyingPtr);
            }
        }

        // Number of updates done
        public unsafe uint mUpdatesDone
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_updates_done", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_updates_done", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__btDbvtBroadphase_Get_m_updates_done(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_updates_done(_UnderlyingPtr);
            }
        }

        // m_updates_done/m_updates_call
        public unsafe double mUpdatesRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_updates_ratio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_updates_ratio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__btDbvtBroadphase_Get_m_updates_ratio(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_updates_ratio(_UnderlyingPtr);
            }
        }

        // Parse id
        public unsafe int mPid
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_pid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_pid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_Get_m_pid(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_pid(_UnderlyingPtr);
            }
        }

        // Cleanup index
        public unsafe int mCid
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_cid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_cid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_Get_m_cid(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_cid(_UnderlyingPtr);
            }
        }

        // Gen id
        public unsafe int mGid
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_gid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_gid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_Get_m_gid(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_gid(_UnderlyingPtr);
            }
        }

        // Release pair cache on delete
        public unsafe bool mReleasepaircache
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_releasepaircache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_releasepaircache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__btDbvtBroadphase_Get_m_releasepaircache(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_releasepaircache(_UnderlyingPtr);
            }
        }

        // Defere dynamic/static collision to collide call
        public unsafe bool mDeferedcollide
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_deferedcollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_deferedcollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__btDbvtBroadphase_Get_m_deferedcollide(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_deferedcollide(_UnderlyingPtr);
            }
        }

        // Need to run cleanup?
        public unsafe bool mNeedcleanup
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Get_m_needcleanup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Get_m_needcleanup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__btDbvtBroadphase_Get_m_needcleanup(_Underlying *_this);
                return *__btDbvtBroadphase_Get_m_needcleanup(_UnderlyingPtr);
            }
        }

        internal unsafe Const_BtDbvtBroadphase(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /* Methods		*/
        /// Generated from constructor `btDbvtBroadphase::btDbvtBroadphase`.
        public unsafe Const_BtDbvtBroadphase(Bullet.BtOverlappingPairCache? paircache = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDbvtBroadphase._Underlying *__btDbvtBroadphase_Construct(Bullet.BtOverlappingPairCache._Underlying *paircache);
            _UnderlyingPtr = __btDbvtBroadphase_Construct(paircache is not null ? paircache._UnderlyingPtr : null);
        }

        /* Methods		*/
        /// Generated from constructor `btDbvtBroadphase::btDbvtBroadphase`.
        public static unsafe implicit operator Const_BtDbvtBroadphase(Bullet.BtOverlappingPairCache? paircache) {return new(paircache);}

        /// Generated from method `btDbvtBroadphase::getOverlappingPairCache`.
        public unsafe Bullet.Const_BtOverlappingPairCache? GetOverlappingPairCache()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_getOverlappingPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_getOverlappingPairCache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtOverlappingPairCache._Underlying *__btDbvtBroadphase_getOverlappingPairCache(_Underlying *_this);
            var __c_ret = __btDbvtBroadphase_getOverlappingPairCache(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Const_BtOverlappingPairCache(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btDbvtBroadphase::getBroadphaseAabb`.
        public unsafe void GetBroadphaseAabb(Bullet.BtVector3 aabbMin, Bullet.BtVector3 aabbMax)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_getBroadphaseAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_getBroadphaseAabb", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_getBroadphaseAabb(_Underlying *_this, Bullet.BtVector3._Underlying *aabbMin, Bullet.BtVector3._Underlying *aabbMax);
            __btDbvtBroadphase_getBroadphaseAabb(_UnderlyingPtr, aabbMin._UnderlyingPtr, aabbMax._UnderlyingPtr);
        }

        /// Generated from method `btDbvtBroadphase::getVelocityPrediction`.
        public unsafe double GetVelocityPrediction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_getVelocityPrediction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_getVelocityPrediction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btDbvtBroadphase_getVelocityPrediction(_Underlying *_this);
            return __btDbvtBroadphase_getVelocityPrediction(_UnderlyingPtr);
        }

        /// Generated from method `btDbvtBroadphase::benchmark`.
        public static unsafe void Benchmark(Bullet.BtBroadphaseInterface? _1)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_benchmark", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_benchmark", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_benchmark(Bullet.BtBroadphaseInterface._Underlying *_1);
            __btDbvtBroadphase_benchmark(_1 is not null ? _1._UnderlyingPtr : null);
        }

        /* Config		*/
        public enum UnnamedEnumAtUsersElialoniDevelopmentCOMPILERSMrbindDepsBulletSrcBulletCollisionBroadphaseCollisionBtDbvtBroadphaseH65_2 : uint
        {
            /* Dynamic set index	*/
            DYNAMICSET = 0,
            /* Fixed set index		*/
            FIXEDSET = 1,
            /* Number of stages		*/
            STAGECOUNT = 2,
        }
    }

    ///The btDbvtBroadphase implements a broadphase using two dynamic AABB bounding volume hierarchies/trees (see btDbvt).
    ///One tree is used for static/non-moving objects, and another tree is used for dynamic objects. Objects can move from one tree to the other.
    ///This is a very fast broadphase, especially for very dynamic worlds where many objects are moving. Its insert/add and remove of objects is generally faster than the sweep and prune broadphases btAxisSweep3 and bt32BitAxisSweep3.
    /// Generated from class `btDbvtBroadphase`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btBroadphaseInterface`
    /// This is the non-const half of the class.
    public class BtDbvtBroadphase : Const_BtDbvtBroadphase
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtBroadphaseInterface(BtDbvtBroadphase self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_UpcastTo_btBroadphaseInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_UpcastTo_btBroadphaseInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtBroadphaseInterface._Underlying *__btDbvtBroadphase_UpcastTo_btBroadphaseInterface(_Underlying *_this);
            Bullet.BtBroadphaseInterface ret = new(__btDbvtBroadphase_UpcastTo_btBroadphaseInterface(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        // Downcasts:
        public static unsafe explicit operator BtDbvtBroadphase?(Bullet.BtBroadphaseInterface parent)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static _Underlying *__btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface(Bullet.BtBroadphaseInterface._Underlying *_this);
            var ptr = __btDbvtBroadphase_DynamicDowncastFrom_btBroadphaseInterface(parent._UnderlyingPtr);
            if (ptr is null) return null;
            BtDbvtBroadphase ret = new(ptr, is_owning: false);
            ret._KeepAliveEnclosingObject = parent;
            return ret;
        }

        // Pair cache
        public new unsafe Bullet.BtOverlappingPairCache? mPaircache
        {
            get => base.mPaircache;
            set
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_paircache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_paircache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtOverlappingPairCache._Underlying **__btDbvtBroadphase_GetMutable_m_paircache(BtDbvtBroadphase._Underlying *_this);
                var ptr = __btDbvtBroadphase_GetMutable_m_paircache(_UnderlyingPtr);
                _DiscardKeepAlive("m_paircache");
                if (value is not null)
                    _KeepAlive(value, "m_paircache");
                *ptr = (value is not null ? value._UnderlyingPtr : null);
            }
        }

        // Velocity prediction
        public new unsafe ref double mPrediction
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_prediction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_prediction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__btDbvtBroadphase_GetMutable_m_prediction(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_prediction(_UnderlyingPtr);
            }
        }

        // Current stage
        public new unsafe ref int mStageCurrent
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_stageCurrent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_stageCurrent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_GetMutable_m_stageCurrent(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_stageCurrent(_UnderlyingPtr);
            }
        }

        // % of fixed updates per frame
        public new unsafe ref int mFupdates
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_fupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_fupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_GetMutable_m_fupdates(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_fupdates(_UnderlyingPtr);
            }
        }

        // % of dynamic updates per frame
        public new unsafe ref int mDupdates
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_dupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_dupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_GetMutable_m_dupdates(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_dupdates(_UnderlyingPtr);
            }
        }

        // % of cleanup updates per frame
        public new unsafe ref int mCupdates
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_cupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_cupdates", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_GetMutable_m_cupdates(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_cupdates(_UnderlyingPtr);
            }
        }

        // Number of pairs created
        public new unsafe ref int mNewpairs
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_newpairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_newpairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_GetMutable_m_newpairs(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_newpairs(_UnderlyingPtr);
            }
        }

        // Fixed optimization left
        public new unsafe ref int mFixedleft
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_fixedleft", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_fixedleft", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_GetMutable_m_fixedleft(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_fixedleft(_UnderlyingPtr);
            }
        }

        // Number of updates call
        public new unsafe ref uint mUpdatesCall
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_updates_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_updates_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__btDbvtBroadphase_GetMutable_m_updates_call(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_updates_call(_UnderlyingPtr);
            }
        }

        // Number of updates done
        public new unsafe ref uint mUpdatesDone
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_updates_done", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_updates_done", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static uint *__btDbvtBroadphase_GetMutable_m_updates_done(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_updates_done(_UnderlyingPtr);
            }
        }

        // m_updates_done/m_updates_call
        public new unsafe ref double mUpdatesRatio
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_updates_ratio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_updates_ratio", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static double *__btDbvtBroadphase_GetMutable_m_updates_ratio(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_updates_ratio(_UnderlyingPtr);
            }
        }

        // Parse id
        public new unsafe ref int mPid
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_pid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_pid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_GetMutable_m_pid(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_pid(_UnderlyingPtr);
            }
        }

        // Cleanup index
        public new unsafe ref int mCid
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_cid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_cid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_GetMutable_m_cid(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_cid(_UnderlyingPtr);
            }
        }

        // Gen id
        public new unsafe ref int mGid
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_gid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_gid", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static int *__btDbvtBroadphase_GetMutable_m_gid(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_gid(_UnderlyingPtr);
            }
        }

        // Release pair cache on delete
        public new unsafe ref bool mReleasepaircache
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_releasepaircache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_releasepaircache", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__btDbvtBroadphase_GetMutable_m_releasepaircache(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_releasepaircache(_UnderlyingPtr);
            }
        }

        // Defere dynamic/static collision to collide call
        public new unsafe ref bool mDeferedcollide
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_deferedcollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_deferedcollide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__btDbvtBroadphase_GetMutable_m_deferedcollide(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_deferedcollide(_UnderlyingPtr);
            }
        }

        // Need to run cleanup?
        public new unsafe ref bool mNeedcleanup
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_needcleanup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_GetMutable_m_needcleanup", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static bool *__btDbvtBroadphase_GetMutable_m_needcleanup(_Underlying *_this);
                return ref *__btDbvtBroadphase_GetMutable_m_needcleanup(_UnderlyingPtr);
            }
        }

        internal unsafe BtDbvtBroadphase(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /* Methods		*/
        /// Generated from constructor `btDbvtBroadphase::btDbvtBroadphase`.
        public unsafe BtDbvtBroadphase(Bullet.BtOverlappingPairCache? paircache = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDbvtBroadphase._Underlying *__btDbvtBroadphase_Construct(Bullet.BtOverlappingPairCache._Underlying *paircache);
            _UnderlyingPtr = __btDbvtBroadphase_Construct(paircache is not null ? paircache._UnderlyingPtr : null);
        }

        /* Methods		*/
        /// Generated from constructor `btDbvtBroadphase::btDbvtBroadphase`.
        public static unsafe implicit operator BtDbvtBroadphase(Bullet.BtOverlappingPairCache? paircache) {return new(paircache);}

        /// Generated from method `btDbvtBroadphase::operator=`.
        public unsafe Bullet.BtDbvtBroadphase Assign(Bullet._ByValue_BtDbvtBroadphase _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtDbvtBroadphase._Underlying *__btDbvtBroadphase_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtDbvtBroadphase._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btDbvtBroadphase_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btDbvtBroadphase::collide`.
        public unsafe void Collide(Bullet.BtDispatcher? dispatcher)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_collide", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_collide(_Underlying *_this, Bullet.BtDispatcher._Underlying *dispatcher);
            __btDbvtBroadphase_collide(_UnderlyingPtr, dispatcher is not null ? dispatcher._UnderlyingPtr : null);
        }

        /// Generated from method `btDbvtBroadphase::optimize`.
        public unsafe void Optimize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_optimize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_optimize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_optimize(_Underlying *_this);
            __btDbvtBroadphase_optimize(_UnderlyingPtr);
        }

        /// Generated from method `btDbvtBroadphase::calculateOverlappingPairs`.
        public unsafe void CalculateOverlappingPairs(Bullet.BtDispatcher? dispatcher)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_calculateOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_calculateOverlappingPairs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_calculateOverlappingPairs(_Underlying *_this, Bullet.BtDispatcher._Underlying *dispatcher);
            __btDbvtBroadphase_calculateOverlappingPairs(_UnderlyingPtr, dispatcher is not null ? dispatcher._UnderlyingPtr : null);
        }

        /// Generated from method `btDbvtBroadphase::getOverlappingPairCache`.
        public unsafe new Bullet.BtOverlappingPairCache? GetOverlappingPairCache()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_getOverlappingPairCache_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_getOverlappingPairCache_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtOverlappingPairCache._Underlying *__btDbvtBroadphase_getOverlappingPairCache_mut(_Underlying *_this);
            var __c_ret = __btDbvtBroadphase_getOverlappingPairCache_mut(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtOverlappingPairCache(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btDbvtBroadphase::printStats`.
        public unsafe void PrintStats()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_printStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_printStats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_printStats(_Underlying *_this);
            __btDbvtBroadphase_printStats(_UnderlyingPtr);
        }

        ///reset broadphase internal structures, to ensure determinism/reproducability
        /// Generated from method `btDbvtBroadphase::resetPool`.
        public unsafe void ResetPool(Bullet.BtDispatcher? dispatcher)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_resetPool", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_resetPool", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_resetPool(_Underlying *_this, Bullet.BtDispatcher._Underlying *dispatcher);
            __btDbvtBroadphase_resetPool(_UnderlyingPtr, dispatcher is not null ? dispatcher._UnderlyingPtr : null);
        }

        /// Generated from method `btDbvtBroadphase::performDeferredRemoval`.
        public unsafe void PerformDeferredRemoval(Bullet.BtDispatcher? dispatcher)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_performDeferredRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_performDeferredRemoval", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_performDeferredRemoval(_Underlying *_this, Bullet.BtDispatcher._Underlying *dispatcher);
            __btDbvtBroadphase_performDeferredRemoval(_UnderlyingPtr, dispatcher is not null ? dispatcher._UnderlyingPtr : null);
        }

        /// Generated from method `btDbvtBroadphase::setVelocityPrediction`.
        public unsafe void SetVelocityPrediction(double prediction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btDbvtBroadphase_setVelocityPrediction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btDbvtBroadphase_setVelocityPrediction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btDbvtBroadphase_setVelocityPrediction(_Underlying *_this, double prediction);
            __btDbvtBroadphase_setVelocityPrediction(_UnderlyingPtr, prediction);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtDbvtBroadphase` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtDbvtBroadphase
    {
        #pragma warning disable CS0649
        internal readonly Const_BtDbvtBroadphase? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtDbvtBroadphase() {PassByMode = Bullet._PassBy.default_construct;}
    }

    /// This is used for optional parameters of class `BtDbvtBroadphase` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtDbvtBroadphase`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDbvtBroadphase`/`Const_BtDbvtBroadphase` directly.
    public class _InOptMut_BtDbvtBroadphase
    {
        public BtDbvtBroadphase? Opt;

        public _InOptMut_BtDbvtBroadphase() {}
        public _InOptMut_BtDbvtBroadphase(BtDbvtBroadphase value) {Opt = value;}
        public static implicit operator _InOptMut_BtDbvtBroadphase(BtDbvtBroadphase value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtDbvtBroadphase` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtDbvtBroadphase`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtDbvtBroadphase`/`Const_BtDbvtBroadphase` to pass it to the function.
    public class _InOptConst_BtDbvtBroadphase
    {
        public Const_BtDbvtBroadphase? Opt;

        public _InOptConst_BtDbvtBroadphase() {}
        public _InOptConst_BtDbvtBroadphase(Const_BtDbvtBroadphase value) {Opt = value;}
        public static implicit operator _InOptConst_BtDbvtBroadphase(Const_BtDbvtBroadphase value) {return new(value);}

        /* Methods		*/
        /// Generated from constructor `btDbvtBroadphase::btDbvtBroadphase`.
        public static unsafe implicit operator _InOptConst_BtDbvtBroadphase(Bullet.BtOverlappingPairCache? paircache) {return new Const_BtDbvtBroadphase(paircache);}
    }
}
