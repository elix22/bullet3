// machine generated, do not edit
public static partial class Bullet
{
    /**@brief The btQuaternion implements quaternion to perform linear algebra rotations in combination with btMatrix3x3, btVector3 and btTransform. */
    /// Generated from class `btQuaternion`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btQuadWord`
    /// This is the const half of the class.
    public class Const_BtQuaternion : Bullet.Object<Const_BtQuaternion>, System.IDisposable, System.IEquatable<Bullet.Const_BtQuadWord>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_Destroy(_Underlying *_this);
            __btQuaternion_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtQuaternion() {Dispose(false);}

        // Upcasts:
        public static unsafe implicit operator Bullet.Const_BtQuadWord(Const_BtQuaternion self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_UpcastTo_btQuadWord", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_UpcastTo_btQuadWord", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtQuadWord._Underlying *__btQuaternion_UpcastTo_btQuadWord(_Underlying *_this);
            Bullet.Const_BtQuadWord ret = new(__btQuaternion_UpcastTo_btQuadWord(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe Const_BtQuaternion(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BtQuaternion() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_DefaultConstruct();
            _UnderlyingPtr = __btQuaternion_DefaultConstruct();
        }

        /// Generated from constructor `btQuaternion::btQuaternion`.
        public unsafe Const_BtQuaternion(Bullet.Const_BtQuaternion _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_ConstructFromAnother(Bullet.BtQuaternion._Underlying *_other);
            _UnderlyingPtr = __btQuaternion_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `btQuaternion::btQuaternion`.
        public Const_BtQuaternion(BtQuaternion _other) : this((Const_BtQuaternion)_other) {}

        //		template <typename btScalar>
        //		explicit Quaternion(const btScalar *v) : Tuple4<btScalar>(v) {}
        /**@brief Constructor from scalars */
        /// Generated from constructor `btQuaternion::btQuaternion`.
        public unsafe Const_BtQuaternion(double _x, double _y, double _z, double _w) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_Construct_4(double *_x, double *_y, double *_z, double *_w);
            _UnderlyingPtr = __btQuaternion_Construct_4(&_x, &_y, &_z, &_w);
        }

        /**@brief Axis angle Constructor
        * @param axis The axis which the rotation is around
        * @param angle The magnitude of the rotation around the angle (Radians) */
        /// Generated from constructor `btQuaternion::btQuaternion`.
        public unsafe Const_BtQuaternion(Bullet.Const_BtVector3 _axis, double _angle) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_Construct_2(Bullet.Const_BtVector3._Underlying *_axis, double *_angle);
            _UnderlyingPtr = __btQuaternion_Construct_2(_axis._UnderlyingPtr, &_angle);
        }

        /**@brief Constructor from Euler angles
        * @param yaw Angle around Y unless BT_EULER_DEFAULT_ZYX defined then Z
        * @param pitch Angle around X unless BT_EULER_DEFAULT_ZYX defined then Y
        * @param roll Angle around Z unless BT_EULER_DEFAULT_ZYX defined then X */
        /// Generated from constructor `btQuaternion::btQuaternion`.
        public unsafe Const_BtQuaternion(double yaw, double pitch, double roll) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_Construct_3(double *yaw, double *pitch, double *roll);
            _UnderlyingPtr = __btQuaternion_Construct_3(&yaw, &pitch, &roll);
        }

        /// Generated from conversion operator `btQuaternion::operator const double *`.
        public static unsafe implicit operator double?(Bullet.Const_BtQuaternion _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_ConvertTo_const_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_ConvertTo_const_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_ConvertTo_const_double_ptr(Bullet.Const_BtQuaternion._Underlying *_this);
            var __c_ret = __btQuaternion_ConvertTo_const_double_ptr(_this._UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /**@brief Get the euler angles from this quaternion
        * @param yaw Angle around Z
        * @param pitch Angle around Y
        * @param roll Angle around X */
        /// Generated from method `btQuaternion::getEulerZYX`.
        public unsafe void GetEulerZYX(ref double yawZ, ref double pitchY, ref double rollX)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_getEulerZYX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_getEulerZYX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_getEulerZYX(_Underlying *_this, double *yawZ, double *pitchY, double *rollX);
            fixed (double *__ptr_yawZ = &yawZ)
            {
                fixed (double *__ptr_pitchY = &pitchY)
                {
                    fixed (double *__ptr_rollX = &rollX)
                    {
                        __btQuaternion_getEulerZYX(_UnderlyingPtr, __ptr_yawZ, __ptr_pitchY, __ptr_rollX);
                    }
                }
            }
        }

        /**@brief Return the dot product between this quaternion and another
        * @param q The other quaternion */
        /// Generated from method `btQuaternion::dot`.
        public unsafe double Dot(Bullet.Const_BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btQuaternion_dot(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q);
            return __btQuaternion_dot(_UnderlyingPtr, q._UnderlyingPtr);
        }

        /**@brief Return the length squared of the quaternion */
        /// Generated from method `btQuaternion::length2`.
        public unsafe double Length2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_length2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_length2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btQuaternion_length2(_Underlying *_this);
            return __btQuaternion_length2(_UnderlyingPtr);
        }

        /**@brief Return the length of the quaternion */
        /// Generated from method `btQuaternion::length`.
        public unsafe double Length()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btQuaternion_length(_Underlying *_this);
            return __btQuaternion_length(_UnderlyingPtr);
        }

        /**@brief Return a scaled version of this quaternion
        * @param s The scale factor */
        /// Generated from method `btQuaternion::operator*`.
        public static unsafe Bullet.BtQuaternion operator*(Bullet.Const_BtQuaternion _this, double s)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_mul_btQuaternion_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_mul_btQuaternion_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__Bullet_mul_btQuaternion_double(Bullet.Const_BtQuaternion._Underlying *_this, double *s);
            return new(__Bullet_mul_btQuaternion_double(_this._UnderlyingPtr, &s), is_owning: true);
        }

        /**@brief Return an inversely scaled versionof this quaternion
        * @param s The inverse scale factor */
        /// Generated from method `btQuaternion::operator/`.
        public static unsafe Bullet.BtQuaternion operator/(Bullet.Const_BtQuaternion _this, double s)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_div_btQuaternion_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_div_btQuaternion_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__Bullet_div_btQuaternion_double(Bullet.Const_BtQuaternion._Underlying *_this, double *s);
            return new(__Bullet_div_btQuaternion_double(_this._UnderlyingPtr, &s), is_owning: true);
        }

        /**@brief Return a normalized version of this quaternion */
        /// Generated from method `btQuaternion::normalized`.
        public unsafe Bullet.BtQuaternion Normalized()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_normalized(_Underlying *_this);
            return new(__btQuaternion_normalized(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the ***half*** angle between this quaternion and the other
        * @param q The other quaternion */
        /// Generated from method `btQuaternion::angle`.
        public unsafe double Angle(Bullet.Const_BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_angle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_angle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btQuaternion_angle(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q);
            return __btQuaternion_angle(_UnderlyingPtr, q._UnderlyingPtr);
        }

        /**@brief Return the angle between this quaternion and the other along the shortest path
        * @param q The other quaternion */
        /// Generated from method `btQuaternion::angleShortestPath`.
        public unsafe double AngleShortestPath(Bullet.Const_BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_angleShortestPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_angleShortestPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btQuaternion_angleShortestPath(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q);
            return __btQuaternion_angleShortestPath(_UnderlyingPtr, q._UnderlyingPtr);
        }

        /**@brief Return the angle [0, 2Pi] of rotation represented by this quaternion */
        /// Generated from method `btQuaternion::getAngle`.
        public unsafe double GetAngle()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_getAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_getAngle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btQuaternion_getAngle(_Underlying *_this);
            return __btQuaternion_getAngle(_UnderlyingPtr);
        }

        /**@brief Return the angle [0, Pi] of rotation represented by this quaternion along the shortest path */
        /// Generated from method `btQuaternion::getAngleShortestPath`.
        public unsafe double GetAngleShortestPath()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_getAngleShortestPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_getAngleShortestPath", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btQuaternion_getAngleShortestPath(_Underlying *_this);
            return __btQuaternion_getAngleShortestPath(_UnderlyingPtr);
        }

        /**@brief Return the axis of the rotation represented by this quaternion */
        /// Generated from method `btQuaternion::getAxis`.
        public unsafe Bullet.BtVector3 GetAxis()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_getAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_getAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btQuaternion_getAxis(_Underlying *_this);
            return new(__btQuaternion_getAxis(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the inverse of this quaternion */
        /// Generated from method `btQuaternion::inverse`.
        public unsafe Bullet.BtQuaternion Inverse()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_inverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_inverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_inverse(_Underlying *_this);
            return new(__btQuaternion_inverse(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the sum of this quaternion and the other 
        * @param q2 The other quaternion */
        /// Generated from method `btQuaternion::operator+`.
        public static unsafe Bullet.BtQuaternion operator+(Bullet.Const_BtQuaternion _this, Bullet.Const_BtQuaternion q2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_add_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_add_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__Bullet_add_btQuaternion(Bullet.Const_BtQuaternion._Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q2);
            return new(__Bullet_add_btQuaternion(_this._UnderlyingPtr, q2._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the difference between this quaternion and the other 
        * @param q2 The other quaternion */
        /// Generated from method `btQuaternion::operator-`.
        public static unsafe Bullet.BtQuaternion operator-(Bullet.Const_BtQuaternion _this, Bullet.Const_BtQuaternion q2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_sub_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_sub_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__Bullet_sub_btQuaternion(Bullet.Const_BtQuaternion._Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q2);
            return new(__Bullet_sub_btQuaternion(_this._UnderlyingPtr, q2._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the negative of this quaternion 
        * This simply negates each element */
        /// Generated from method `btQuaternion::operator-`.
        public static unsafe Bullet.BtQuaternion operator-(Bullet.Const_BtQuaternion _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_neg_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_neg_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__Bullet_neg_btQuaternion(Bullet.Const_BtQuaternion._Underlying *_this);
            return new(__Bullet_neg_btQuaternion(_this._UnderlyingPtr), is_owning: true);
        }

        /**@todo document this and it's use */
        /// Generated from method `btQuaternion::farthest`.
        public unsafe Bullet.BtQuaternion Farthest(Bullet.Const_BtQuaternion qd)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_farthest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_farthest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_farthest(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *qd);
            return new(__btQuaternion_farthest(_UnderlyingPtr, qd._UnderlyingPtr), is_owning: true);
        }

        /**@todo document this and it's use */
        /// Generated from method `btQuaternion::nearest`.
        public unsafe Bullet.BtQuaternion Nearest(Bullet.Const_BtQuaternion qd)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_nearest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_nearest", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_nearest(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *qd);
            return new(__btQuaternion_nearest(_UnderlyingPtr, qd._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the quaternion which is the result of Spherical Linear Interpolation between this and the other quaternion
        * @param q The other quaternion to interpolate with 
        * @param t The ratio between this and q to interpolate.  If t = 0 the result is this, if t=1 the result is q.
        * Slerp interpolates assuming constant velocity.  */
        /// Generated from method `btQuaternion::slerp`.
        public unsafe Bullet.BtQuaternion Slerp(Bullet.Const_BtQuaternion q, double t)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_slerp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_slerp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_slerp(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q, double *t);
            return new(__btQuaternion_slerp(_UnderlyingPtr, q._UnderlyingPtr, &t), is_owning: true);
        }

        /// Generated from method `btQuaternion::getIdentity`.
        public static unsafe Bullet.Const_BtQuaternion GetIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_getIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_getIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtQuaternion._Underlying *__btQuaternion_getIdentity();
            return new(__btQuaternion_getIdentity(), is_owning: false);
        }

        /// Generated from method `btQuaternion::getW`.
        public unsafe double GetW()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_getW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_getW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_getW(_Underlying *_this);
            return *__btQuaternion_getW(_UnderlyingPtr);
        }

        /**@brief Return the x value */
        /// Generated from method `btQuaternion::getX`.
        public unsafe double GetX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_getX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_getX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_getX(_Underlying *_this);
            return *__btQuaternion_getX(_UnderlyingPtr);
        }

        /**@brief Return the y value */
        /// Generated from method `btQuaternion::getY`.
        public unsafe double GetY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_getY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_getY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_getY(_Underlying *_this);
            return *__btQuaternion_getY(_UnderlyingPtr);
        }

        /**@brief Return the z value */
        /// Generated from method `btQuaternion::getZ`.
        public unsafe double GetZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_getZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_getZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_getZ(_Underlying *_this);
            return *__btQuaternion_getZ(_UnderlyingPtr);
        }

        /**@brief Return the x value */
        /// Generated from method `btQuaternion::x`.
        public unsafe double X()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_x(_Underlying *_this);
            return *__btQuaternion_x(_UnderlyingPtr);
        }

        /**@brief Return the y value */
        /// Generated from method `btQuaternion::y`.
        public unsafe double Y()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_y(_Underlying *_this);
            return *__btQuaternion_y(_UnderlyingPtr);
        }

        /**@brief Return the z value */
        /// Generated from method `btQuaternion::z`.
        public unsafe double Z()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_z(_Underlying *_this);
            return *__btQuaternion_z(_UnderlyingPtr);
        }

        /**@brief Return the w value */
        /// Generated from method `btQuaternion::w`.
        public unsafe double W()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_w(_Underlying *_this);
            return *__btQuaternion_w(_UnderlyingPtr);
        }

        /// Generated from method `btQuaternion::operator==`.
        public static unsafe bool operator==(Bullet.Const_BtQuaternion _this, Bullet.Const_BtQuadWord other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_equal_btQuaternion_btQuadWord", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_equal_btQuaternion_btQuadWord", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Bullet_equal_btQuaternion_btQuadWord(Bullet.Const_BtQuaternion._Underlying *_this, Bullet.Const_BtQuadWord._Underlying *other);
            return __Bullet_equal_btQuaternion_btQuadWord(_this._UnderlyingPtr, other._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(Bullet.Const_BtQuaternion _this, Bullet.Const_BtQuadWord other)
        {
            return !(_this == other);
        }

        // IEquatable:

        public bool Equals(Bullet.Const_BtQuadWord? other)
        {
            if (other is null)
                return false;
            return this == other;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is Bullet.Const_BtQuadWord)
                return this == (Bullet.Const_BtQuadWord)other;
            return false;
        }
    }

    /**@brief The btQuaternion implements quaternion to perform linear algebra rotations in combination with btMatrix3x3, btVector3 and btTransform. */
    /// Generated from class `btQuaternion`.
    /// Base classes:
    ///   Direct: (non-virtual)
    ///     `btQuadWord`
    /// This is the non-const half of the class.
    public class BtQuaternion : Const_BtQuaternion
    {
        // Upcasts:
        public static unsafe implicit operator Bullet.BtQuadWord(BtQuaternion self)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_UpcastTo_btQuadWord", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_UpcastTo_btQuadWord", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuaternion_UpcastTo_btQuadWord(_Underlying *_this);
            Bullet.BtQuadWord ret = new(__btQuaternion_UpcastTo_btQuadWord(self._UnderlyingPtr), is_owning: false);
            ret._KeepAliveEnclosingObject = self;
            return ret;
        }

        internal unsafe BtQuaternion(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BtQuaternion() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_DefaultConstruct();
            _UnderlyingPtr = __btQuaternion_DefaultConstruct();
        }

        /// Generated from constructor `btQuaternion::btQuaternion`.
        public unsafe BtQuaternion(Bullet.Const_BtQuaternion _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_ConstructFromAnother(Bullet.BtQuaternion._Underlying *_other);
            _UnderlyingPtr = __btQuaternion_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `btQuaternion::btQuaternion`.
        public BtQuaternion(BtQuaternion _other) : this((Const_BtQuaternion)_other) {}

        //		template <typename btScalar>
        //		explicit Quaternion(const btScalar *v) : Tuple4<btScalar>(v) {}
        /**@brief Constructor from scalars */
        /// Generated from constructor `btQuaternion::btQuaternion`.
        public unsafe BtQuaternion(double _x, double _y, double _z, double _w) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_Construct_4(double *_x, double *_y, double *_z, double *_w);
            _UnderlyingPtr = __btQuaternion_Construct_4(&_x, &_y, &_z, &_w);
        }

        /**@brief Axis angle Constructor
        * @param axis The axis which the rotation is around
        * @param angle The magnitude of the rotation around the angle (Radians) */
        /// Generated from constructor `btQuaternion::btQuaternion`.
        public unsafe BtQuaternion(Bullet.Const_BtVector3 _axis, double _angle) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_Construct_2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_Construct_2(Bullet.Const_BtVector3._Underlying *_axis, double *_angle);
            _UnderlyingPtr = __btQuaternion_Construct_2(_axis._UnderlyingPtr, &_angle);
        }

        /**@brief Constructor from Euler angles
        * @param yaw Angle around Y unless BT_EULER_DEFAULT_ZYX defined then Z
        * @param pitch Angle around X unless BT_EULER_DEFAULT_ZYX defined then Y
        * @param roll Angle around Z unless BT_EULER_DEFAULT_ZYX defined then X */
        /// Generated from constructor `btQuaternion::btQuaternion`.
        public unsafe BtQuaternion(double yaw, double pitch, double roll) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_Construct_3(double *yaw, double *pitch, double *roll);
            _UnderlyingPtr = __btQuaternion_Construct_3(&yaw, &pitch, &roll);
        }

        //SIMD_FORCE_INLINE btScalar&       operator[](int i)       { return (&m_floats[0])[i];	}
        //SIMD_FORCE_INLINE const btScalar& operator[](int i) const { return (&m_floats[0])[i]; }
        ///operator btScalar*() replaces operator[], using implicit conversion. We added operator != and operator == to avoid pointer comparisons.
        /// Generated from conversion operator `btQuaternion::operator double *`.
        public static unsafe implicit operator Bullet.Ref<double>?(Bullet.BtQuaternion _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_ConvertTo_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_ConvertTo_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuaternion_ConvertTo_double_ptr(Bullet.BtQuaternion._Underlying *_this);
            var __c_ret = __btQuaternion_ConvertTo_double_ptr(_this._UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Ref<double>(__c_ret) : null;
        }

        /// Generated from method `btQuaternion::operator=`.
        public unsafe Bullet.BtQuaternion Assign(Bullet.Const_BtQuaternion _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_AssignFromAnother(_Underlying *_this, Bullet.BtQuaternion._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__btQuaternion_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /**@brief Set the rotation using axis angle notation 
        * @param axis The axis around which to rotate
        * @param angle The magnitude of the rotation in Radians */
        /// Generated from method `btQuaternion::setRotation`.
        public unsafe void SetRotation(Bullet.Const_BtVector3 axis, double _angle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_setRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_setRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_setRotation(_Underlying *_this, Bullet.Const_BtVector3._Underlying *axis, double *_angle);
            __btQuaternion_setRotation(_UnderlyingPtr, axis._UnderlyingPtr, &_angle);
        }

        /**@brief Set the quaternion using Euler angles
        * @param yaw Angle around Y
        * @param pitch Angle around X
        * @param roll Angle around Z */
        /// Generated from method `btQuaternion::setEuler`.
        public unsafe void SetEuler(double yaw, double pitch, double roll)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_setEuler", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_setEuler", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_setEuler(_Underlying *_this, double *yaw, double *pitch, double *roll);
            __btQuaternion_setEuler(_UnderlyingPtr, &yaw, &pitch, &roll);
        }

        /**@brief Set the quaternion using euler angles 
        * @param yaw Angle around Z
        * @param pitch Angle around Y
        * @param roll Angle around X */
        /// Generated from method `btQuaternion::setEulerZYX`.
        public unsafe void SetEulerZYX(double yawZ, double pitchY, double rollX)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_setEulerZYX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_setEulerZYX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_setEulerZYX(_Underlying *_this, double *yawZ, double *pitchY, double *rollX);
            __btQuaternion_setEulerZYX(_UnderlyingPtr, &yawZ, &pitchY, &rollX);
        }

        /**@brief Add two quaternions
        * @param q The quaternion to add to this one */
        /// Generated from method `btQuaternion::operator+=`.
        public unsafe Bullet.BtQuaternion AddAssign(Bullet.Const_BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_add_assign(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q);
            Bullet.BtQuaternion __ret;
            __ret = new(__btQuaternion_add_assign(_UnderlyingPtr, q._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /**@brief Subtract out a quaternion
        * @param q The quaternion to subtract from this one */
        /// Generated from method `btQuaternion::operator-=`.
        public unsafe Bullet.BtQuaternion SubAssign(Bullet.Const_BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_sub_assign(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q);
            Bullet.BtQuaternion __ret;
            __ret = new(__btQuaternion_sub_assign(_UnderlyingPtr, q._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /**@brief Scale this quaternion
        * @param s The scalar to scale by */
        /// Generated from method `btQuaternion::operator*=`.
        public unsafe Bullet.BtQuaternion MulAssign(double s)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_mul_assign_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_mul_assign_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_mul_assign_double(_Underlying *_this, double *s);
            Bullet.BtQuaternion __ret;
            __ret = new(__btQuaternion_mul_assign_double(_UnderlyingPtr, &s), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /**@brief Multiply this quaternion by q on the right
        * @param q The other quaternion 
        * Equivilant to this = this * q */
        /// Generated from method `btQuaternion::operator*=`.
        public unsafe Bullet.BtQuaternion MulAssign(Bullet.Const_BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_mul_assign_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_mul_assign_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_mul_assign_btQuaternion(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q);
            Bullet.BtQuaternion __ret;
            __ret = new(__btQuaternion_mul_assign_btQuaternion(_UnderlyingPtr, q._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Generated from method `btQuaternion::safeNormalize`.
        public unsafe Bullet.BtQuaternion SafeNormalize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_safeNormalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_safeNormalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_safeNormalize(_Underlying *_this);
            return new(__btQuaternion_safeNormalize(_UnderlyingPtr), is_owning: false);
        }

        /**@brief Normalize the quaternion 
        * Such that x^2 + y^2 + z^2 +w^2 = 1 */
        /// Generated from method `btQuaternion::normalize`.
        public unsafe Bullet.BtQuaternion Normalize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_normalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_normalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_normalize(_Underlying *_this);
            return new(__btQuaternion_normalize(_UnderlyingPtr), is_owning: false);
        }

        /**@brief Inversely scale this quaternion
        * @param s The scale factor */
        /// Generated from method `btQuaternion::operator/=`.
        public unsafe Bullet.BtQuaternion DivAssign(double s)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btQuaternion_div_assign(_Underlying *_this, double *s);
            Bullet.BtQuaternion __ret;
            __ret = new(__btQuaternion_div_assign(_UnderlyingPtr, &s), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /**@brief Set the x value */
        /// Generated from method `btQuaternion::setX`.
        public unsafe void SetX(double _x)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_setX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_setX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_setX(_Underlying *_this, double _x);
            __btQuaternion_setX(_UnderlyingPtr, _x);
        }

        /**@brief Set the y value */
        /// Generated from method `btQuaternion::setY`.
        public unsafe void SetY(double _y)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_setY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_setY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_setY(_Underlying *_this, double _y);
            __btQuaternion_setY(_UnderlyingPtr, _y);
        }

        /**@brief Set the z value */
        /// Generated from method `btQuaternion::setZ`.
        public unsafe void SetZ(double _z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_setZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_setZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_setZ(_Underlying *_this, double _z);
            __btQuaternion_setZ(_UnderlyingPtr, _z);
        }

        /**@brief Set the w value */
        /// Generated from method `btQuaternion::setW`.
        public unsafe void SetW(double _w)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_setW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_setW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_setW(_Underlying *_this, double _w);
            __btQuaternion_setW(_UnderlyingPtr, _w);
        }

        /**@brief Set each element to the max of the current values and the values of another btQuadWord
        * @param other The other btQuadWord to compare with 
        */
        /// Generated from method `btQuaternion::setMax`.
        public unsafe void SetMax(Bullet.Const_BtQuadWord other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_setMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_setMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_setMax(_Underlying *_this, Bullet.Const_BtQuadWord._Underlying *other);
            __btQuaternion_setMax(_UnderlyingPtr, other._UnderlyingPtr);
        }

        /**@brief Set each element to the min of the current values and the values of another btQuadWord
        * @param other The other btQuadWord to compare with 
        */
        /// Generated from method `btQuaternion::setMin`.
        public unsafe void SetMin(Bullet.Const_BtQuadWord other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuaternion_setMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuaternion_setMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuaternion_setMin(_Underlying *_this, Bullet.Const_BtQuadWord._Underlying *other);
            __btQuaternion_setMin(_UnderlyingPtr, other._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `BtQuaternion` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtQuaternion`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtQuaternion`/`Const_BtQuaternion` directly.
    public class _InOptMut_BtQuaternion
    {
        public BtQuaternion? Opt;

        public _InOptMut_BtQuaternion() {}
        public _InOptMut_BtQuaternion(BtQuaternion value) {Opt = value;}
        public static implicit operator _InOptMut_BtQuaternion(BtQuaternion value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtQuaternion` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtQuaternion`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtQuaternion`/`Const_BtQuaternion` to pass it to the function.
    public class _InOptConst_BtQuaternion
    {
        public Const_BtQuaternion? Opt;

        public _InOptConst_BtQuaternion() {}
        public _InOptConst_BtQuaternion(Const_BtQuaternion value) {Opt = value;}
        public static implicit operator _InOptConst_BtQuaternion(Const_BtQuaternion value) {return new(value);}
    }
}
