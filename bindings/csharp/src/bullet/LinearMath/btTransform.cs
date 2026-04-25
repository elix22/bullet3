// machine generated, do not edit
public static partial class Bullet
{
    /**@brief The btTransform class supports rigid transforms with only translation and rotation and no scaling/shear.
    *It can be used in combination with btVector3, btQuaternion and btMatrix3x3 linear algebra classes. */
    /// Generated from class `btTransform`.
    /// This is the const half of the class.
    public class Const_BtTransform : Bullet.Object<Const_BtTransform>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btTransform_Destroy(_Underlying *_this);
            __btTransform_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtTransform() {Dispose(false);}

        internal unsafe Const_BtTransform(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BtTransform() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_DefaultConstruct();
            _UnderlyingPtr = __btTransform_DefaultConstruct();
        }

        /**@brief Copy constructor */
        /// Generated from constructor `btTransform::btTransform`.
        public unsafe Const_BtTransform(Bullet._ByValue_BtTransform other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_ConstructFromAnother(Bullet._PassBy other_pass_by, Bullet.BtTransform._Underlying *other);
            _UnderlyingPtr = __btTransform_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /**@brief Copy constructor */
        /// Generated from constructor `btTransform::btTransform`.
        public Const_BtTransform(Const_BtTransform other) : this(new _ByValue_BtTransform(other)) {}

        /**@brief Copy constructor */
        /// Generated from constructor `btTransform::btTransform`.
        public Const_BtTransform(BtTransform other) : this((Const_BtTransform)other) {}

        /**@brief Constructor from btQuaternion (optional btVector3 )
        * @param q Rotation from quaternion 
        * @param c Translation from Vector (default 0,0,0) */
        /// Generated from constructor `btTransform::btTransform`.
        /// Parameter `c` defaults to `btVector3(btScalar(0), btScalar(0), btScalar(0))`.
        public unsafe Const_BtTransform(Bullet.Const_BtQuaternion q, Bullet.Const_BtVector3? c = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_Construct_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_Construct_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_Construct_btQuaternion(Bullet.Const_BtQuaternion._Underlying *q, Bullet.Const_BtVector3._Underlying *c);
            _UnderlyingPtr = __btTransform_Construct_btQuaternion(q._UnderlyingPtr, c is not null ? c._UnderlyingPtr : null);
        }

        /**@brief Constructor from btMatrix3x3 (optional btVector3)
        * @param b Rotation from Matrix 
        * @param c Translation from Vector default (0,0,0)*/
        /// Generated from constructor `btTransform::btTransform`.
        /// Parameter `c` defaults to `btVector3(btScalar(0), btScalar(0), btScalar(0))`.
        public unsafe Const_BtTransform(Bullet.Const_BtMatrix3x3 b, Bullet.Const_BtVector3? c = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_Construct_btMatrix3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_Construct_btMatrix3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_Construct_btMatrix3x3(Bullet.Const_BtMatrix3x3._Underlying *b, Bullet.Const_BtVector3._Underlying *c);
            _UnderlyingPtr = __btTransform_Construct_btMatrix3x3(b._UnderlyingPtr, c is not null ? c._UnderlyingPtr : null);
        }

        /// Generated from method `btTransform::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btTransform_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btTransform_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btTransform_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btTransform_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btTransform::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btTransform_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btTransform_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btTransform_void_ptr(void *ptr);
            __Bullet_delete_btTransform_void_ptr(ptr);
        }

        /// Generated from method `btTransform::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btTransform_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btTransform_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btTransform_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btTransform_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btTransform::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btTransform_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btTransform_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btTransform_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btTransform_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btTransform::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btTransform_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btTransform_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btTransform_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btTransform_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btTransform::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btTransform_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btTransform_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btTransform_void_ptr(void *ptr);
            __Bullet_delete_array_btTransform_void_ptr(ptr);
        }

        /// Generated from method `btTransform::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btTransform_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btTransform_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btTransform_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btTransform_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btTransform::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btTransform_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btTransform_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btTransform_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btTransform_void_ptr_void_ptr(_1, _2);
        }

        /**@brief Return the transform of the vector */
        /// Generated from method `btTransform::operator()`.
        public unsafe Bullet.BtVector3 Call(Bullet.Const_BtVector3 x)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_call", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btTransform_call(_Underlying *_this, Bullet.Const_BtVector3._Underlying *x);
            return new(__btTransform_call(_UnderlyingPtr, x._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the transform of the vector */
        /// Generated from method `btTransform::operator*`.
        public static unsafe Bullet.BtVector3 operator*(Bullet.Const_BtTransform _this, Bullet.Const_BtVector3 x)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_mul_btTransform_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_mul_btTransform_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__Bullet_mul_btTransform_btVector3(Bullet.Const_BtTransform._Underlying *_this, Bullet.Const_BtVector3._Underlying *x);
            return new(__Bullet_mul_btTransform_btVector3(_this._UnderlyingPtr, x._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the transform of the btQuaternion */
        /// Generated from method `btTransform::operator*`.
        public static unsafe Bullet.BtQuaternion operator*(Bullet.Const_BtTransform _this, Bullet.Const_BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_mul_btTransform_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_mul_btTransform_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__Bullet_mul_btTransform_btQuaternion(Bullet.Const_BtTransform._Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q);
            return new(__Bullet_mul_btTransform_btQuaternion(_this._UnderlyingPtr, q._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the basis matrix for the rotation */
        /// Generated from method `btTransform::getBasis`.
        public unsafe Bullet.Const_BtMatrix3x3 GetBasis()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_getBasis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_getBasis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtMatrix3x3._Underlying *__btTransform_getBasis(_Underlying *_this);
            return new(__btTransform_getBasis(_UnderlyingPtr), is_owning: false);
        }

        /**@brief Return the origin vector translation */
        /// Generated from method `btTransform::getOrigin`.
        public unsafe Bullet.Const_BtVector3 GetOrigin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_getOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_getOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btTransform_getOrigin(_Underlying *_this);
            return new(__btTransform_getOrigin(_UnderlyingPtr), is_owning: false);
        }

        /**@brief Return a quaternion representing the rotation */
        /// Generated from method `btTransform::getRotation`.
        public unsafe Bullet.BtQuaternion GetRotation()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_getRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_getRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtQuaternion._Underlying *__btTransform_getRotation(_Underlying *_this);
            return new(__btTransform_getRotation(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Fill an array representation
        * @param m A pointer to a 16 element array (12 rotation(row major padded on the right by 1), and 3 translation */
        /// Generated from method `btTransform::getOpenGLMatrix`.
        public unsafe void GetOpenGLMatrix(Bullet.InOut<double>? m)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_getOpenGLMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_getOpenGLMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btTransform_getOpenGLMatrix(_Underlying *_this, double *m);
            double __value_m = m is not null ? m.Value : default(double);
            if (m is not null) m.Value = __value_m;
            __btTransform_getOpenGLMatrix(_UnderlyingPtr, m is not null ? &__value_m : null);
        }

        /// Generated from method `btTransform::invXform`.
        public unsafe Bullet.BtVector3 InvXform(Bullet.Const_BtVector3 inVec)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_invXform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_invXform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btTransform_invXform(_Underlying *_this, Bullet.Const_BtVector3._Underlying *inVec);
            return new(__btTransform_invXform(_UnderlyingPtr, inVec._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the inverse of this transform */
        /// Generated from method `btTransform::inverse`.
        public unsafe Bullet.BtTransform Inverse()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_inverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_inverse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_inverse(_Underlying *_this);
            return new(__btTransform_inverse(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the inverse of this transform times the other transform
        * @param t The other transform 
        * return this.inverse() * the other */
        /// Generated from method `btTransform::inverseTimes`.
        public unsafe Bullet.BtTransform InverseTimes(Bullet.Const_BtTransform t)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_inverseTimes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_inverseTimes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_inverseTimes(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t);
            return new(__btTransform_inverseTimes(_UnderlyingPtr, t._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the product of this transform and the other */
        /// Generated from method `btTransform::operator*`.
        public static unsafe Bullet.BtTransform operator*(Bullet.Const_BtTransform _this, Bullet.Const_BtTransform t)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_mul_btTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_mul_btTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__Bullet_mul_btTransform(Bullet.Const_BtTransform._Underlying *_this, Bullet.Const_BtTransform._Underlying *t);
            return new(__Bullet_mul_btTransform(_this._UnderlyingPtr, t._UnderlyingPtr), is_owning: true);
        }

        /**@brief Return an identity transform */
        /// Generated from method `btTransform::getIdentity`.
        public static unsafe Bullet.Const_BtTransform GetIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_getIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_getIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtTransform._Underlying *__btTransform_getIdentity();
            return new(__btTransform_getIdentity(), is_owning: false);
        }
    }

    /**@brief The btTransform class supports rigid transforms with only translation and rotation and no scaling/shear.
    *It can be used in combination with btVector3, btQuaternion and btMatrix3x3 linear algebra classes. */
    /// Generated from class `btTransform`.
    /// This is the non-const half of the class.
    public class BtTransform : Const_BtTransform
    {
        internal unsafe BtTransform(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BtTransform() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_DefaultConstruct();
            _UnderlyingPtr = __btTransform_DefaultConstruct();
        }

        /**@brief Copy constructor */
        /// Generated from constructor `btTransform::btTransform`.
        public unsafe BtTransform(Bullet._ByValue_BtTransform other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_ConstructFromAnother(Bullet._PassBy other_pass_by, Bullet.BtTransform._Underlying *other);
            _UnderlyingPtr = __btTransform_ConstructFromAnother(other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null);
            if (other.Value is not null) _KeepAlive(other.Value);
        }

        /**@brief Copy constructor */
        /// Generated from constructor `btTransform::btTransform`.
        public BtTransform(Const_BtTransform other) : this(new _ByValue_BtTransform(other)) {}

        /**@brief Copy constructor */
        /// Generated from constructor `btTransform::btTransform`.
        public BtTransform(BtTransform other) : this((Const_BtTransform)other) {}

        /**@brief Constructor from btQuaternion (optional btVector3 )
        * @param q Rotation from quaternion 
        * @param c Translation from Vector (default 0,0,0) */
        /// Generated from constructor `btTransform::btTransform`.
        /// Parameter `c` defaults to `btVector3(btScalar(0), btScalar(0), btScalar(0))`.
        public unsafe BtTransform(Bullet.Const_BtQuaternion q, Bullet.Const_BtVector3? c = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_Construct_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_Construct_btQuaternion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_Construct_btQuaternion(Bullet.Const_BtQuaternion._Underlying *q, Bullet.Const_BtVector3._Underlying *c);
            _UnderlyingPtr = __btTransform_Construct_btQuaternion(q._UnderlyingPtr, c is not null ? c._UnderlyingPtr : null);
        }

        /**@brief Constructor from btMatrix3x3 (optional btVector3)
        * @param b Rotation from Matrix 
        * @param c Translation from Vector default (0,0,0)*/
        /// Generated from constructor `btTransform::btTransform`.
        /// Parameter `c` defaults to `btVector3(btScalar(0), btScalar(0), btScalar(0))`.
        public unsafe BtTransform(Bullet.Const_BtMatrix3x3 b, Bullet.Const_BtVector3? c = null) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_Construct_btMatrix3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_Construct_btMatrix3x3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_Construct_btMatrix3x3(Bullet.Const_BtMatrix3x3._Underlying *b, Bullet.Const_BtVector3._Underlying *c);
            _UnderlyingPtr = __btTransform_Construct_btMatrix3x3(b._UnderlyingPtr, c is not null ? c._UnderlyingPtr : null);
        }

        /**@brief Assignment Operator */
        /// Generated from method `btTransform::operator=`.
        public unsafe Bullet.BtTransform Assign(Bullet._ByValue_BtTransform other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_AssignFromAnother(_Underlying *_this, Bullet._PassBy other_pass_by, Bullet.BtTransform._Underlying *other);
            Bullet.BtTransform __ret;
            __ret = new(__btTransform_AssignFromAnother(_UnderlyingPtr, other.PassByMode, other.Value is not null ? other.Value._UnderlyingPtr : null), is_owning: false);
            _DiscardKeepAlive();
            if (other.Value is not null) _KeepAlive(other.Value);
            __ret._KeepAlive(this);
            return __ret;
        }

        /**@brief Set the current transform as the value of the product of two transforms
        * @param t1 Transform 1
        * @param t2 Transform 2
        * This = Transform1 * Transform2 */
        /// Generated from method `btTransform::mult`.
        public unsafe void Mult(Bullet.Const_BtTransform t1, Bullet.Const_BtTransform t2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_mult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_mult", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btTransform_mult(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t1, Bullet.Const_BtTransform._Underlying *t2);
            __btTransform_mult(_UnderlyingPtr, t1._UnderlyingPtr, t2._UnderlyingPtr);
        }

        /**@brief Return the basis matrix for the rotation */
        /// Generated from method `btTransform::getBasis`.
        public unsafe new Bullet.BtMatrix3x3 GetBasis()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_getBasis_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_getBasis_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtMatrix3x3._Underlying *__btTransform_getBasis_mut(_Underlying *_this);
            return new(__btTransform_getBasis_mut(_UnderlyingPtr), is_owning: false);
        }

        /**@brief Return the origin vector translation */
        /// Generated from method `btTransform::getOrigin`.
        public unsafe new Bullet.BtVector3 GetOrigin()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_getOrigin_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_getOrigin_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btTransform_getOrigin_mut(_Underlying *_this);
            return new(__btTransform_getOrigin_mut(_UnderlyingPtr), is_owning: false);
        }

        /**@brief Set from an array 
        * @param m A pointer to a 16 element array (12 rotation(row major padded on the right by 1), and 3 translation */
        /// Generated from method `btTransform::setFromOpenGLMatrix`.
        public unsafe void SetFromOpenGLMatrix(double? m)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_setFromOpenGLMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_setFromOpenGLMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btTransform_setFromOpenGLMatrix(_Underlying *_this, double *m);
            double __deref_m = m.GetValueOrDefault();
            __btTransform_setFromOpenGLMatrix(_UnderlyingPtr, m.HasValue ? &__deref_m : null);
        }

        /**@brief Set the translational element
        * @param origin The vector to set the translation to */
        /// Generated from method `btTransform::setOrigin`.
        public unsafe void SetOrigin(Bullet.Const_BtVector3 origin)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_setOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_setOrigin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btTransform_setOrigin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *origin);
            __btTransform_setOrigin(_UnderlyingPtr, origin._UnderlyingPtr);
        }

        /**@brief Set the rotational element by btMatrix3x3 */
        /// Generated from method `btTransform::setBasis`.
        public unsafe void SetBasis(Bullet.Const_BtMatrix3x3 basis)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_setBasis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_setBasis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btTransform_setBasis(_Underlying *_this, Bullet.Const_BtMatrix3x3._Underlying *basis);
            __btTransform_setBasis(_UnderlyingPtr, basis._UnderlyingPtr);
        }

        /**@brief Set the rotational element by btQuaternion */
        /// Generated from method `btTransform::setRotation`.
        public unsafe void SetRotation(Bullet.Const_BtQuaternion q)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_setRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_setRotation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btTransform_setRotation(_Underlying *_this, Bullet.Const_BtQuaternion._Underlying *q);
            __btTransform_setRotation(_UnderlyingPtr, q._UnderlyingPtr);
        }

        /**@brief Set this transformation to the identity */
        /// Generated from method `btTransform::setIdentity`.
        public unsafe void SetIdentity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_setIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_setIdentity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btTransform_setIdentity(_Underlying *_this);
            __btTransform_setIdentity(_UnderlyingPtr);
        }

        /**@brief Multiply this Transform by another(this = this * another) 
        * @param t The other transform */
        /// Generated from method `btTransform::operator*=`.
        public unsafe Bullet.BtTransform MulAssign(Bullet.Const_BtTransform t)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btTransform_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btTransform_mul_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btTransform_mul_assign(_Underlying *_this, Bullet.Const_BtTransform._Underlying *t);
            Bullet.BtTransform __ret;
            __ret = new(__btTransform_mul_assign(_UnderlyingPtr, t._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtTransform` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `BtTransform`/`Const_BtTransform` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtTransform
    {
        #pragma warning disable CS0649
        internal readonly Const_BtTransform? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtTransform() {PassByMode = Bullet._PassBy.default_construct;}
        public _ByValue_BtTransform(Const_BtTransform new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtTransform(Const_BtTransform arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtTransform` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtTransform`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtTransform`/`Const_BtTransform` directly.
    public class _InOptMut_BtTransform
    {
        public BtTransform? Opt;

        public _InOptMut_BtTransform() {}
        public _InOptMut_BtTransform(BtTransform value) {Opt = value;}
        public static implicit operator _InOptMut_BtTransform(BtTransform value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtTransform` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtTransform`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtTransform`/`Const_BtTransform` to pass it to the function.
    public class _InOptConst_BtTransform
    {
        public Const_BtTransform? Opt;

        public _InOptConst_BtTransform() {}
        public _InOptConst_BtTransform(Const_BtTransform value) {Opt = value;}
        public static implicit operator _InOptConst_BtTransform(Const_BtTransform value) {return new(value);}
    }
}
