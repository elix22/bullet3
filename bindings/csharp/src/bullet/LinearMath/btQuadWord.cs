// machine generated, do not edit
public static partial class Bullet
{
    /// Generated from class `btQuadWord`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btQuaternion`
    /// This is the const half of the class.
    public class Const_BtQuadWord : Bullet.Object<Const_BtQuadWord>, System.IDisposable, System.IEquatable<Bullet.Const_BtQuadWord>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuadWord_Destroy(_Underlying *_this);
            __btQuadWord_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtQuadWord() {Dispose(false);}

        internal unsafe Const_BtQuadWord(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BtQuadWord() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuadWord_DefaultConstruct();
            _UnderlyingPtr = __btQuadWord_DefaultConstruct();
        }

        /// Generated from constructor `btQuadWord::btQuadWord`.
        public unsafe Const_BtQuadWord(Bullet.Const_BtQuadWord _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuadWord_ConstructFromAnother(Bullet.BtQuadWord._Underlying *_other);
            _UnderlyingPtr = __btQuadWord_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `btQuadWord::btQuadWord`.
        public Const_BtQuadWord(BtQuadWord _other) : this((Const_BtQuadWord)_other) {}

        /**@brief Three argument constructor (zeros w)
        * @param x Value of x
        * @param y Value of y
        * @param z Value of z
        */
        /// Generated from constructor `btQuadWord::btQuadWord`.
        public unsafe Const_BtQuadWord(double _x, double _y, double _z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuadWord_Construct_3(double *_x, double *_y, double *_z);
            _UnderlyingPtr = __btQuadWord_Construct_3(&_x, &_y, &_z);
        }

        /**@brief Initializing constructor
        * @param x Value of x
        * @param y Value of y
        * @param z Value of z
        * @param w Value of w
        */
        /// Generated from constructor `btQuadWord::btQuadWord`.
        public unsafe Const_BtQuadWord(double _x, double _y, double _z, double _w) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuadWord_Construct_4(double *_x, double *_y, double *_z, double *_w);
            _UnderlyingPtr = __btQuadWord_Construct_4(&_x, &_y, &_z, &_w);
        }

        /// Generated from conversion operator `btQuadWord::operator const double *`.
        public static unsafe implicit operator double?(Bullet.Const_BtQuadWord _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_ConvertTo_const_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_ConvertTo_const_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuadWord_ConvertTo_const_double_ptr(Bullet.Const_BtQuadWord._Underlying *_this);
            var __c_ret = __btQuadWord_ConvertTo_const_double_ptr(_this._UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /**@brief Return the x value */
        /// Generated from method `btQuadWord::getX`.
        public unsafe double GetX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_getX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_getX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuadWord_getX(_Underlying *_this);
            return *__btQuadWord_getX(_UnderlyingPtr);
        }

        /**@brief Return the y value */
        /// Generated from method `btQuadWord::getY`.
        public unsafe double GetY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_getY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_getY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuadWord_getY(_Underlying *_this);
            return *__btQuadWord_getY(_UnderlyingPtr);
        }

        /**@brief Return the z value */
        /// Generated from method `btQuadWord::getZ`.
        public unsafe double GetZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_getZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_getZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuadWord_getZ(_Underlying *_this);
            return *__btQuadWord_getZ(_UnderlyingPtr);
        }

        /**@brief Return the x value */
        /// Generated from method `btQuadWord::x`.
        public unsafe double X()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuadWord_x(_Underlying *_this);
            return *__btQuadWord_x(_UnderlyingPtr);
        }

        /**@brief Return the y value */
        /// Generated from method `btQuadWord::y`.
        public unsafe double Y()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuadWord_y(_Underlying *_this);
            return *__btQuadWord_y(_UnderlyingPtr);
        }

        /**@brief Return the z value */
        /// Generated from method `btQuadWord::z`.
        public unsafe double Z()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuadWord_z(_Underlying *_this);
            return *__btQuadWord_z(_UnderlyingPtr);
        }

        /**@brief Return the w value */
        /// Generated from method `btQuadWord::w`.
        public unsafe double W()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuadWord_w(_Underlying *_this);
            return *__btQuadWord_w(_UnderlyingPtr);
        }

        /// Generated from method `btQuadWord::operator==`.
        public static unsafe bool operator==(Bullet.Const_BtQuadWord _this, Bullet.Const_BtQuadWord other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_equal_btQuadWord", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_equal_btQuadWord", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Bullet_equal_btQuadWord(Bullet.Const_BtQuadWord._Underlying *_this, Bullet.Const_BtQuadWord._Underlying *other);
            return __Bullet_equal_btQuadWord(_this._UnderlyingPtr, other._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(Bullet.Const_BtQuadWord _this, Bullet.Const_BtQuadWord other)
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

    /// Generated from class `btQuadWord`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btQuaternion`
    /// This is the non-const half of the class.
    public class BtQuadWord : Const_BtQuadWord
    {
        internal unsafe BtQuadWord(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BtQuadWord() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuadWord_DefaultConstruct();
            _UnderlyingPtr = __btQuadWord_DefaultConstruct();
        }

        /// Generated from constructor `btQuadWord::btQuadWord`.
        public unsafe BtQuadWord(Bullet.Const_BtQuadWord _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuadWord_ConstructFromAnother(Bullet.BtQuadWord._Underlying *_other);
            _UnderlyingPtr = __btQuadWord_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `btQuadWord::btQuadWord`.
        public BtQuadWord(BtQuadWord _other) : this((Const_BtQuadWord)_other) {}

        /**@brief Three argument constructor (zeros w)
        * @param x Value of x
        * @param y Value of y
        * @param z Value of z
        */
        /// Generated from constructor `btQuadWord::btQuadWord`.
        public unsafe BtQuadWord(double _x, double _y, double _z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_Construct_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuadWord_Construct_3(double *_x, double *_y, double *_z);
            _UnderlyingPtr = __btQuadWord_Construct_3(&_x, &_y, &_z);
        }

        /**@brief Initializing constructor
        * @param x Value of x
        * @param y Value of y
        * @param z Value of z
        * @param w Value of w
        */
        /// Generated from constructor `btQuadWord::btQuadWord`.
        public unsafe BtQuadWord(double _x, double _y, double _z, double _w) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_Construct_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuadWord_Construct_4(double *_x, double *_y, double *_z, double *_w);
            _UnderlyingPtr = __btQuadWord_Construct_4(&_x, &_y, &_z, &_w);
        }

        //SIMD_FORCE_INLINE btScalar&       operator[](int i)       { return (&m_floats[0])[i];	}
        //SIMD_FORCE_INLINE const btScalar& operator[](int i) const { return (&m_floats[0])[i]; }
        ///operator btScalar*() replaces operator[], using implicit conversion. We added operator != and operator == to avoid pointer comparisons.
        /// Generated from conversion operator `btQuadWord::operator double *`.
        public static unsafe implicit operator Bullet.Ref<double>?(Bullet.BtQuadWord _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_ConvertTo_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_ConvertTo_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btQuadWord_ConvertTo_double_ptr(Bullet.BtQuadWord._Underlying *_this);
            var __c_ret = __btQuadWord_ConvertTo_double_ptr(_this._UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Ref<double>(__c_ret) : null;
        }

        /// Generated from method `btQuadWord::operator=`.
        public unsafe Bullet.BtQuadWord Assign(Bullet.Const_BtQuadWord _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuadWord._Underlying *__btQuadWord_AssignFromAnother(_Underlying *_this, Bullet.BtQuadWord._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__btQuadWord_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /**@brief Set the x value */
        /// Generated from method `btQuadWord::setX`.
        public unsafe void SetX(double _x)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_setX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_setX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuadWord_setX(_Underlying *_this, double _x);
            __btQuadWord_setX(_UnderlyingPtr, _x);
        }

        /**@brief Set the y value */
        /// Generated from method `btQuadWord::setY`.
        public unsafe void SetY(double _y)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_setY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_setY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuadWord_setY(_Underlying *_this, double _y);
            __btQuadWord_setY(_UnderlyingPtr, _y);
        }

        /**@brief Set the z value */
        /// Generated from method `btQuadWord::setZ`.
        public unsafe void SetZ(double _z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_setZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_setZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuadWord_setZ(_Underlying *_this, double _z);
            __btQuadWord_setZ(_UnderlyingPtr, _z);
        }

        /**@brief Set the w value */
        /// Generated from method `btQuadWord::setW`.
        public unsafe void SetW(double _w)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_setW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_setW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuadWord_setW(_Underlying *_this, double _w);
            __btQuadWord_setW(_UnderlyingPtr, _w);
        }

        /**@brief Set x,y,z and zero w 
        * @param x Value of x
        * @param y Value of y
        * @param z Value of z
        */
        /// Generated from method `btQuadWord::setValue`.
        public unsafe void SetValue(double _x, double _y, double _z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_setValue_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_setValue_3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuadWord_setValue_3(_Underlying *_this, double *_x, double *_y, double *_z);
            __btQuadWord_setValue_3(_UnderlyingPtr, &_x, &_y, &_z);
        }

        /*		void getValue(btScalar *m) const 
        {
        m[0] = m_floats[0];
        m[1] = m_floats[1];
        m[2] = m_floats[2];
        }
        */
        /**@brief Set the values 
        * @param x Value of x
        * @param y Value of y
        * @param z Value of z
        * @param w Value of w
        */
        /// Generated from method `btQuadWord::setValue`.
        public unsafe void SetValue(double _x, double _y, double _z, double _w)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_setValue_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_setValue_4", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuadWord_setValue_4(_Underlying *_this, double *_x, double *_y, double *_z, double *_w);
            __btQuadWord_setValue_4(_UnderlyingPtr, &_x, &_y, &_z, &_w);
        }

        /**@brief Set each element to the max of the current values and the values of another btQuadWord
        * @param other The other btQuadWord to compare with 
        */
        /// Generated from method `btQuadWord::setMax`.
        public unsafe void SetMax(Bullet.Const_BtQuadWord other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_setMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_setMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuadWord_setMax(_Underlying *_this, Bullet.Const_BtQuadWord._Underlying *other);
            __btQuadWord_setMax(_UnderlyingPtr, other._UnderlyingPtr);
        }

        /**@brief Set each element to the min of the current values and the values of another btQuadWord
        * @param other The other btQuadWord to compare with 
        */
        /// Generated from method `btQuadWord::setMin`.
        public unsafe void SetMin(Bullet.Const_BtQuadWord other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btQuadWord_setMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btQuadWord_setMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btQuadWord_setMin(_Underlying *_this, Bullet.Const_BtQuadWord._Underlying *other);
            __btQuadWord_setMin(_UnderlyingPtr, other._UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `BtQuadWord` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtQuadWord`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtQuadWord`/`Const_BtQuadWord` directly.
    public class _InOptMut_BtQuadWord
    {
        public BtQuadWord? Opt;

        public _InOptMut_BtQuadWord() {}
        public _InOptMut_BtQuadWord(BtQuadWord value) {Opt = value;}
        public static implicit operator _InOptMut_BtQuadWord(BtQuadWord value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtQuadWord` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtQuadWord`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtQuadWord`/`Const_BtQuadWord` to pass it to the function.
    public class _InOptConst_BtQuadWord
    {
        public Const_BtQuadWord? Opt;

        public _InOptConst_BtQuadWord() {}
        public _InOptConst_BtQuadWord(Const_BtQuadWord value) {Opt = value;}
        public static implicit operator _InOptConst_BtQuadWord(Const_BtQuadWord value) {return new(value);}
    }
}
