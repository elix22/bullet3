// machine generated, do not edit
public static partial class Bullet
{
    /**@brief The btMatrix3x3 class implements a 3x3 rotation matrix, to perform linear algebra in combination with btQuaternion, btTransform and btVector3.
    * Make sure to only include a pure orthogonal matrix without scaling. */
    /// Generated from class `btMatrix3x3`.
    /// This is the const half of the class.
    public class Const_BtMatrix3x3 : Bullet.Object<Const_BtMatrix3x3>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_Destroy(_Underlying *_this);
            __btMatrix3x3_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtMatrix3x3() {Dispose(false);}

        internal unsafe Const_BtMatrix3x3(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BtMatrix3x3() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_DefaultConstruct();
            _UnderlyingPtr = __btMatrix3x3_DefaultConstruct();
        }

        /** @brief Copy constructor */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public unsafe Const_BtMatrix3x3(Bullet._ByValue_BtMatrix3x3 other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_ConstructFromAnother(Bullet._PassBy other_pass_by, Bullet.BtMatrix3x3._Underlying *other);
            _UnderlyingPtr = __btMatrix3x3_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /** @brief Copy constructor */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public Const_BtMatrix3x3(Const_BtMatrix3x3 other) : this(new _ByValue_BtMatrix3x3(other)) {}

        /** @brief Copy constructor */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public Const_BtMatrix3x3(BtMatrix3x3 other) : this((Const_BtMatrix3x3)other) {}

        /**@brief Constructor from Quaternion */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public unsafe Const_BtMatrix3x3(Bullet.Const_BtQuaternion q) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_Construct_1(Bullet.Const_BtQuaternion._Underlying *q);
            _UnderlyingPtr = __btMatrix3x3_Construct_1(q._UnderlyingPtr);
        }

        /*
        template <typename btScalar>
        Matrix3x3(const btScalar& yaw, const btScalar& pitch, const btScalar& roll)
        { 
        setEulerYPR(yaw, pitch, roll);
        }
        */
        /** @brief Constructor with row major formatting */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public unsafe Const_BtMatrix3x3(double xx, double xy, double xz, double yx, double yy, double yz, double zx, double zy, double zz) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_Construct_9(double *xx, double *xy, double *xz, double *yx, double *yy, double *yz, double *zx, double *zy, double *zz);
            _UnderlyingPtr = __btMatrix3x3_Construct_9(&xx, &xy, &xz, &yx, &yy, &yz, &zx, &zy, &zz);
        }

        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public unsafe Const_BtMatrix3x3(Bullet.Const_BtVector3 v0, Bullet.Const_BtVector3 v1, Bullet.Const_BtVector3 v2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_Construct_3(Bullet.Const_BtVector3._Underlying *v0, Bullet.Const_BtVector3._Underlying *v1, Bullet.Const_BtVector3._Underlying *v2);
            _UnderlyingPtr = __btMatrix3x3_Construct_3(v0._UnderlyingPtr, v1._UnderlyingPtr, v2._UnderlyingPtr);
        }

        /** @brief Get a column of the matrix as a vector 
        *  @param i Column number 0 indexed */
        /// Generated from method `btMatrix3x3::getColumn`.
        public unsafe Bullet.BtVector3 GetColumn(int i)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_getColumn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_getColumn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btMatrix3x3_getColumn(_Underlying *_this, int i);
            return new(__btMatrix3x3_getColumn(_UnderlyingPtr, i), is_owning: true);
        }

        /** @brief Get a row of the matrix as a vector 
        *  @param i Row number 0 indexed */
        /// Generated from method `btMatrix3x3::getRow`.
        public unsafe Bullet.Const_BtVector3 GetRow(int i)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_getRow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_getRow", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btMatrix3x3_getRow(_Underlying *_this, int i);
            return new(__btMatrix3x3_getRow(_UnderlyingPtr, i), is_owning: false);
        }

        /** @brief Get a const reference to a row of the matrix as a vector 
        *  @param i Row number 0 indexed */
        /// Generated from method `btMatrix3x3::operator[]`.
        public unsafe Bullet.Const_BtVector3 this[int i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_index", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.Const_BtVector3._Underlying *__btMatrix3x3_index(_Underlying *_this, int i);
                return new(__btMatrix3x3_index(_UnderlyingPtr, i), is_owning: false);
            }
        }

        /// Generated from method `btMatrix3x3::getIdentity`.
        public static unsafe Bullet.Const_BtMatrix3x3 GetIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_getIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_getIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtMatrix3x3._Underlying *__btMatrix3x3_getIdentity();
            return new(__btMatrix3x3_getIdentity(), is_owning: false);
        }

        /**@brief Fill the rotational part of an OpenGL matrix and clear the shear/perspective
        * @param m The array to be filled */
        /// Generated from method `btMatrix3x3::getOpenGLSubMatrix`.
        public unsafe void GetOpenGLSubMatrix(Bullet.InOut<double>? m)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_getOpenGLSubMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_getOpenGLSubMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_getOpenGLSubMatrix(_Underlying *_this, double *m);
            double __value_m = m is not null ? m.Value : default(double);
            if (m is not null) m.Value = __value_m;
            __btMatrix3x3_getOpenGLSubMatrix(_UnderlyingPtr, m is not null ? &__value_m : null);
        }

        /**@brief Get the matrix represented as a quaternion 
        * @param q The quaternion which will be set */
        /// Generated from method `btMatrix3x3::getRotation`.
        public unsafe void GetRotation(Bullet.BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_getRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_getRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_getRotation(_Underlying *_this, Bullet.BtQuaternion._Underlying *q);
            __btMatrix3x3_getRotation(_UnderlyingPtr, q._UnderlyingPtr);
        }

        /**@brief Get the matrix represented as euler angles around YXZ, roundtrip with setEulerYPR
        * @param yaw Yaw around Y axis
        * @param pitch Pitch around X axis
        * @param roll around Z axis */
        /// Generated from method `btMatrix3x3::getEulerYPR`.
        public unsafe void GetEulerYPR(ref double yaw, ref double pitch, ref double roll)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_getEulerYPR", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_getEulerYPR", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_getEulerYPR(_Underlying *_this, double *yaw, double *pitch, double *roll);
            fixed (double *__ptr_yaw = &yaw)
            {
                fixed (double *__ptr_pitch = &pitch)
                {
                    fixed (double *__ptr_roll = &roll)
                    {
                        __btMatrix3x3_getEulerYPR(_UnderlyingPtr, __ptr_yaw, __ptr_pitch, __ptr_roll);
                    }
                }
            }
        }

        /**@brief Get the matrix represented as euler angles around ZYX
        * @param yaw Yaw around Z axis
        * @param pitch Pitch around Y axis
        * @param roll around X axis 
        * @param solution_number Which solution of two possible solutions ( 1 or 2) are possible values*/
        /// Generated from method `btMatrix3x3::getEulerZYX`.
        /// Parameter `solution_number` defaults to `1`.
        public unsafe void GetEulerZYX(ref double yaw, ref double pitch, ref double roll, uint? solution_number = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_getEulerZYX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_getEulerZYX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_getEulerZYX(_Underlying *_this, double *yaw, double *pitch, double *roll, uint *solution_number);
            fixed (double *__ptr_yaw = &yaw)
            {
                fixed (double *__ptr_pitch = &pitch)
                {
                    fixed (double *__ptr_roll = &roll)
                    {
                        uint __deref_solution_number = solution_number.GetValueOrDefault();
                        __btMatrix3x3_getEulerZYX(_UnderlyingPtr, __ptr_yaw, __ptr_pitch, __ptr_roll, solution_number.HasValue ? &__deref_solution_number : null);
                    }
                }
            }
        }

        /**@brief Create a scaled copy of the matrix 
        * @param s Scaling vector The elements of the vector will scale each column */
        /// Generated from method `btMatrix3x3::scaled`.
        public unsafe Bullet.BtMatrix3x3 Scaled(Bullet.Const_BtVector3 s)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_scaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_scaled", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_scaled(_Underlying *_this, Bullet.Const_BtVector3._Underlying *s);
            return new(__btMatrix3x3_scaled(_UnderlyingPtr, s._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the determinant of the matrix */
        /// Generated from method `btMatrix3x3::determinant`.
        public unsafe double Determinant()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_determinant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_determinant", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btMatrix3x3_determinant(_Underlying *_this);
            return __btMatrix3x3_determinant(_UnderlyingPtr);
        }

        /**@brief Return the adjoint of the matrix */
        /// Generated from method `btMatrix3x3::adjoint`.
        public unsafe Bullet.BtMatrix3x3 Adjoint()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_adjoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_adjoint", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_adjoint(_Underlying *_this);
            return new(__btMatrix3x3_adjoint(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the matrix with all values non negative */
        /// Generated from method `btMatrix3x3::absolute`.
        public unsafe Bullet.BtMatrix3x3 Absolute()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_absolute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_absolute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_absolute(_Underlying *_this);
            return new(__btMatrix3x3_absolute(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the transpose of the matrix */
        /// Generated from method `btMatrix3x3::transpose`.
        public unsafe Bullet.BtMatrix3x3 Transpose()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_transpose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_transpose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_transpose(_Underlying *_this);
            return new(__btMatrix3x3_transpose(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the inverse of the matrix */
        /// Generated from method `btMatrix3x3::inverse`.
        public unsafe Bullet.BtMatrix3x3 Inverse()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_inverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_inverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_inverse(_Underlying *_this);
            return new(__btMatrix3x3_inverse(_UnderlyingPtr), is_owning: true);
        }

        /// Solve A * x = b, where b is a column vector. This is more efficient
        /// than computing the inverse in one-shot cases.
        ///Solve33 is from Box2d, thanks to Erin Catto,
        /// Generated from method `btMatrix3x3::solve33`.
        public unsafe Bullet.BtVector3 Solve33(Bullet.Const_BtVector3 b)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_solve33", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_solve33", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btMatrix3x3_solve33(_Underlying *_this, Bullet.Const_BtVector3._Underlying *b);
            return new(__btMatrix3x3_solve33(_UnderlyingPtr, b._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btMatrix3x3::transposeTimes`.
        public unsafe Bullet.BtMatrix3x3 TransposeTimes(Bullet.Const_BtMatrix3x3 m)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_transposeTimes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_transposeTimes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_transposeTimes(_Underlying *_this, Bullet.Const_BtMatrix3x3._Underlying *m);
            return new(__btMatrix3x3_transposeTimes(_UnderlyingPtr, m._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btMatrix3x3::timesTranspose`.
        public unsafe Bullet.BtMatrix3x3 TimesTranspose(Bullet.Const_BtMatrix3x3 m)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_timesTranspose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_timesTranspose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_timesTranspose(_Underlying *_this, Bullet.Const_BtMatrix3x3._Underlying *m);
            return new(__btMatrix3x3_timesTranspose(_UnderlyingPtr, m._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btMatrix3x3::tdotx`.
        public unsafe double Tdotx(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_tdotx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_tdotx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btMatrix3x3_tdotx(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            return __btMatrix3x3_tdotx(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /// Generated from method `btMatrix3x3::tdoty`.
        public unsafe double Tdoty(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_tdoty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_tdoty", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btMatrix3x3_tdoty(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            return __btMatrix3x3_tdoty(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /// Generated from method `btMatrix3x3::tdotz`.
        public unsafe double Tdotz(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_tdotz", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_tdotz", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btMatrix3x3_tdotz(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            return __btMatrix3x3_tdotz(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /**@brief Calculate the matrix cofactor 
        * @param r1 The first row to use for calculating the cofactor
        * @param c1 The first column to use for calculating the cofactor
        * @param r1 The second row to use for calculating the cofactor
        * @param c1 The second column to use for calculating the cofactor
        * See http://en.wikipedia.org/wiki/Cofactor_(linear_algebra) for more details
        */
        /// Generated from method `btMatrix3x3::cofac`.
        public unsafe double Cofac(int r1, int c1, int r2, int c2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_cofac", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_cofac", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btMatrix3x3_cofac(_Underlying *_this, int r1, int c1, int r2, int c2);
            return __btMatrix3x3_cofac(_UnderlyingPtr, r1, c1, r2, c2);
        }
    }

    /**@brief The btMatrix3x3 class implements a 3x3 rotation matrix, to perform linear algebra in combination with btQuaternion, btTransform and btVector3.
    * Make sure to only include a pure orthogonal matrix without scaling. */
    /// Generated from class `btMatrix3x3`.
    /// This is the non-const half of the class.
    public class BtMatrix3x3 : Const_BtMatrix3x3
    {
        internal unsafe BtMatrix3x3(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BtMatrix3x3() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_DefaultConstruct();
            _UnderlyingPtr = __btMatrix3x3_DefaultConstruct();
        }

        /** @brief Copy constructor */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public unsafe BtMatrix3x3(Bullet._ByValue_BtMatrix3x3 other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_ConstructFromAnother(Bullet._PassBy other_pass_by, Bullet.BtMatrix3x3._Underlying *other);
            _UnderlyingPtr = __btMatrix3x3_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /** @brief Copy constructor */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public BtMatrix3x3(Const_BtMatrix3x3 other) : this(new _ByValue_BtMatrix3x3(other)) {}

        /** @brief Copy constructor */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public BtMatrix3x3(BtMatrix3x3 other) : this((Const_BtMatrix3x3)other) {}

        /**@brief Constructor from Quaternion */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public unsafe BtMatrix3x3(Bullet.Const_BtQuaternion q) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_Construct_1", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_Construct_1(Bullet.Const_BtQuaternion._Underlying *q);
            _UnderlyingPtr = __btMatrix3x3_Construct_1(q._UnderlyingPtr);
        }

        /*
        template <typename btScalar>
        Matrix3x3(const btScalar& yaw, const btScalar& pitch, const btScalar& roll)
        { 
        setEulerYPR(yaw, pitch, roll);
        }
        */
        /** @brief Constructor with row major formatting */
        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public unsafe BtMatrix3x3(double xx, double xy, double xz, double yx, double yy, double yz, double zx, double zy, double zz) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_Construct_9", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_Construct_9(double *xx, double *xy, double *xz, double *yx, double *yy, double *yz, double *zx, double *zy, double *zz);
            _UnderlyingPtr = __btMatrix3x3_Construct_9(&xx, &xy, &xz, &yx, &yy, &yz, &zx, &zy, &zz);
        }

        /// Generated from constructor `btMatrix3x3::btMatrix3x3`.
        public unsafe BtMatrix3x3(Bullet.Const_BtVector3 v0, Bullet.Const_BtVector3 v1, Bullet.Const_BtVector3 v2) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_Construct_3(Bullet.Const_BtVector3._Underlying *v0, Bullet.Const_BtVector3._Underlying *v1, Bullet.Const_BtVector3._Underlying *v2);
            _UnderlyingPtr = __btMatrix3x3_Construct_3(v0._UnderlyingPtr, v1._UnderlyingPtr, v2._UnderlyingPtr);
        }

        /** @brief Assignment Operator */
        /// Generated from method `btMatrix3x3::operator=`.
        public unsafe Bullet.BtMatrix3x3 Assign(Bullet._ByValue_BtMatrix3x3 other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_AssignFromAnother(_Underlying *_this, Bullet._PassBy other_pass_by, Bullet.BtMatrix3x3._Underlying *other);
            Bullet.BtMatrix3x3 __ret;
            __ret = new(__btMatrix3x3_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (other.Value is not null) _KeepAlive(other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }

        /** @brief Get a mutable reference to a row of the matrix as a vector 
        *  @param i Row number 0 indexed */
        /// Generated from method `btMatrix3x3::operator[]`.
        public unsafe new Bullet.BtVector3 this[int i]
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_index_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.BtVector3._Underlying *__btMatrix3x3_index_mut(_Underlying *_this, int i);
                return new(__btMatrix3x3_index_mut(_UnderlyingPtr, i), is_owning: false);
            }
        }

        /** @brief Multiply by the target matrix on the right
        *  @param m Rotation matrix to be applied 
        * Equivilant to this = this * m */
        /// Generated from method `btMatrix3x3::operator*=`.
        public unsafe Bullet.BtMatrix3x3 MulAssign(Bullet.Const_BtMatrix3x3 m)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_mul_assign(_Underlying *_this, Bullet.Const_BtMatrix3x3._Underlying *m);
            Bullet.BtMatrix3x3 __ret;
            __ret = new(__btMatrix3x3_mul_assign(_UnderlyingPtr, m._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /** @brief Adds by the target matrix on the right
        *  @param m matrix to be applied 
        * Equivilant to this = this + m */
        /// Generated from method `btMatrix3x3::operator+=`.
        public unsafe Bullet.BtMatrix3x3 AddAssign(Bullet.Const_BtMatrix3x3 m)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_add_assign(_Underlying *_this, Bullet.Const_BtMatrix3x3._Underlying *m);
            Bullet.BtMatrix3x3 __ret;
            __ret = new(__btMatrix3x3_add_assign(_UnderlyingPtr, m._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /** @brief Substractss by the target matrix on the right
        *  @param m matrix to be applied 
        * Equivilant to this = this - m */
        /// Generated from method `btMatrix3x3::operator-=`.
        public unsafe Bullet.BtMatrix3x3 SubAssign(Bullet.Const_BtMatrix3x3 m)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btMatrix3x3_sub_assign(_Underlying *_this, Bullet.Const_BtMatrix3x3._Underlying *m);
            Bullet.BtMatrix3x3 __ret;
            __ret = new(__btMatrix3x3_sub_assign(_UnderlyingPtr, m._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /** @brief Set from the rotational part of a 4x4 OpenGL matrix
        *  @param m A pointer to the beginning of the array of scalars*/
        /// Generated from method `btMatrix3x3::setFromOpenGLSubMatrix`.
        public unsafe void SetFromOpenGLSubMatrix(double? m)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_setFromOpenGLSubMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_setFromOpenGLSubMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_setFromOpenGLSubMatrix(_Underlying *_this, double *m);
            double __deref_m = m.GetValueOrDefault();
            __btMatrix3x3_setFromOpenGLSubMatrix(_UnderlyingPtr, m.HasValue ? &__deref_m : null);
        }

        /** @brief Set the values of the matrix explicitly (row major)
        *  @param xx Top left
        *  @param xy Top Middle
        *  @param xz Top Right
        *  @param yx Middle Left
        *  @param yy Middle Middle
        *  @param yz Middle Right
        *  @param zx Bottom Left
        *  @param zy Bottom Middle
        *  @param zz Bottom Right*/
        /// Generated from method `btMatrix3x3::setValue`.
        public unsafe void SetValue(double xx, double xy, double xz, double yx, double yy, double yz, double zx, double zy, double zz)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_setValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_setValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_setValue(_Underlying *_this, double *xx, double *xy, double *xz, double *yx, double *yy, double *yz, double *zx, double *zy, double *zz);
            __btMatrix3x3_setValue(_UnderlyingPtr, &xx, &xy, &xz, &yx, &yy, &yz, &zx, &zy, &zz);
        }

        /** @brief Set the matrix from a quaternion
        *  @param q The Quaternion to match */
        /// Generated from method `btMatrix3x3::setRotation`.
        public unsafe void SetRotation(Bullet.Const_BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_setRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_setRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_setRotation(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q);
            __btMatrix3x3_setRotation(_UnderlyingPtr, q._UnderlyingPtr);
        }

        /** @brief Set the matrix from euler angles using YPR around YXZ respectively
        *  @param yaw Yaw about Y axis
        *  @param pitch Pitch about X axis
        *  @param roll Roll about Z axis 
        */
        /// Generated from method `btMatrix3x3::setEulerYPR`.
        public unsafe void SetEulerYPR(double yaw, double pitch, double roll)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_setEulerYPR", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_setEulerYPR", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_setEulerYPR(_Underlying *_this, double *yaw, double *pitch, double *roll);
            __btMatrix3x3_setEulerYPR(_UnderlyingPtr, &yaw, &pitch, &roll);
        }

        /** @brief Set the matrix from euler angles YPR around ZYX axes
        * @param eulerX Roll about X axis
        * @param eulerY Pitch around Y axis
        * @param eulerZ Yaw about Z axis
        * 
        * These angles are used to produce a rotation matrix. The euler
        * angles are applied in ZYX order. I.e a vector is first rotated 
        * about X then Y and then Z
        **/
        /// Generated from method `btMatrix3x3::setEulerZYX`.
        public unsafe void SetEulerZYX(double eulerX, double eulerY, double eulerZ)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_setEulerZYX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_setEulerZYX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_setEulerZYX(_Underlying *_this, double eulerX, double eulerY, double eulerZ);
            __btMatrix3x3_setEulerZYX(_UnderlyingPtr, eulerX, eulerY, eulerZ);
        }

        /**@brief Set the matrix to the identity */
        /// Generated from method `btMatrix3x3::setIdentity`.
        public unsafe void SetIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_setIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_setIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_setIdentity(_Underlying *_this);
            __btMatrix3x3_setIdentity(_UnderlyingPtr);
        }

        /**@brief Set the matrix to the identity */
        /// Generated from method `btMatrix3x3::setZero`.
        public unsafe void SetZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_setZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_setZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_setZero(_Underlying *_this);
            __btMatrix3x3_setZero(_UnderlyingPtr);
        }

        ///extractRotation is from "A robust method to extract the rotational part of deformations"
        ///See http://dl.acm.org/citation.cfm?doid=2994258.2994269
        ///decomposes a matrix A in a orthogonal matrix R and a
        ///symmetric matrix S:
        ///A = R*S.
        ///note that R can include both rotation and scaling.
        /// Generated from method `btMatrix3x3::extractRotation`.
        /// Parameter `tolerance` defaults to `1.0000000000000001e-9`.
        /// Parameter `maxIter` defaults to `100`.
        public unsafe void ExtractRotation(Bullet.BtQuaternion q, double? tolerance = null, int? maxIter = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_extractRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_extractRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_extractRotation(_Underlying *_this, Bullet.BtQuaternion._Underlying *q, double *tolerance, int *maxIter);
            double __deref_tolerance = tolerance.GetValueOrDefault();
            int __deref_maxIter = maxIter.GetValueOrDefault();
            __btMatrix3x3_extractRotation(_UnderlyingPtr, q._UnderlyingPtr, tolerance.HasValue ? &__deref_tolerance : null, maxIter.HasValue ? &__deref_maxIter : null);
        }

        /**@brief diagonalizes this matrix by the Jacobi method.
        * @param rot stores the rotation from the coordinate system in which the matrix is diagonal to the original
        * coordinate system, i.e., old_this = rot * new_this * rot^T.
        * @param threshold See iteration
        * @param iteration The iteration stops when all off-diagonal elements are less than the threshold multiplied
        * by the sum of the absolute values of the diagonal, or when maxSteps have been executed.
        *
        * Note that this matrix is assumed to be symmetric.
        */
        /// Generated from method `btMatrix3x3::diagonalize`.
        public unsafe void Diagonalize(Bullet.BtMatrix3x3 rot, double threshold, int maxSteps)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btMatrix3x3_diagonalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btMatrix3x3_diagonalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btMatrix3x3_diagonalize(_Underlying *_this, Bullet.BtMatrix3x3._Underlying *rot, double threshold, int maxSteps);
            __btMatrix3x3_diagonalize(_UnderlyingPtr, rot._UnderlyingPtr, threshold, maxSteps);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtMatrix3x3` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `BtMatrix3x3`/`Const_BtMatrix3x3` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtMatrix3x3
    {
        #pragma warning disable CS0649
        internal readonly Const_BtMatrix3x3? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtMatrix3x3() {PassByMode = Bullet._PassBy.default_construct;}
        public _ByValue_BtMatrix3x3(Const_BtMatrix3x3 new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtMatrix3x3(Const_BtMatrix3x3 arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtMatrix3x3` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtMatrix3x3`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtMatrix3x3`/`Const_BtMatrix3x3` directly.
    public class _InOptMut_BtMatrix3x3
    {
        public BtMatrix3x3? Opt;

        public _InOptMut_BtMatrix3x3() {}
        public _InOptMut_BtMatrix3x3(BtMatrix3x3 value) {Opt = value;}
        public static implicit operator _InOptMut_BtMatrix3x3(BtMatrix3x3 value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtMatrix3x3` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtMatrix3x3`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtMatrix3x3`/`Const_BtMatrix3x3` to pass it to the function.
    public class _InOptConst_BtMatrix3x3
    {
        public Const_BtMatrix3x3? Opt;

        public _InOptConst_BtMatrix3x3() {}
        public _InOptConst_BtMatrix3x3(Const_BtMatrix3x3 value) {Opt = value;}
        public static implicit operator _InOptConst_BtMatrix3x3(Const_BtMatrix3x3 value) {return new(value);}
    }
}
