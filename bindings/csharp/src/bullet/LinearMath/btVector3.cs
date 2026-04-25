// machine generated, do not edit
public static partial class Bullet
{
    /**@brief btVector3 can be used to represent 3D points and vectors.
    * It has an un-used w component to suit 16-byte alignment when btVector3 is stored in containers. This extra component can be used by derived classes (Quaternion?) or by user
    * Ideally, this class should be replaced by a platform optimized SIMD version that keeps the data in registers
    */
    /// Generated from class `btVector3`.
    /// This is the const half of the class.
    public class Const_BtVector3 : Bullet.Object<Const_BtVector3>, System.IDisposable, System.IEquatable<Bullet.Const_BtVector3>
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_Destroy(_Underlying *_this);
            __btVector3_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtVector3() {Dispose(false);}

        public unsafe ref Bullet.ArrayDouble4 mFloats
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_Get_m_floats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_Get_m_floats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.ArrayDouble4 *__btVector3_Get_m_floats(_Underlying *_this);
                return ref *(__btVector3_Get_m_floats(_UnderlyingPtr));
            }
        }

        internal unsafe Const_BtVector3(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BtVector3() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_DefaultConstruct();
            _UnderlyingPtr = __btVector3_DefaultConstruct();
        }

        /// Generated from constructor `btVector3::btVector3`.
        public unsafe Const_BtVector3(Bullet.Const_BtVector3 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_ConstructFromAnother(Bullet.BtVector3._Underlying *_other);
            _UnderlyingPtr = __btVector3_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `btVector3::btVector3`.
        public Const_BtVector3(BtVector3 _other) : this((Const_BtVector3)_other) {}

        /**@brief Constructor from scalars 
        * @param x X value
        * @param y Y value 
        * @param z Z value 
        */
        /// Generated from constructor `btVector3::btVector3`.
        public unsafe Const_BtVector3(double _x, double _y, double _z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_Construct(double *_x, double *_y, double *_z);
            _UnderlyingPtr = __btVector3_Construct(&_x, &_y, &_z);
        }

        /// Generated from conversion operator `btVector3::operator const double *`.
        public static unsafe implicit operator double?(Bullet.Const_BtVector3 _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_ConvertTo_const_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_ConvertTo_const_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btVector3_ConvertTo_const_double_ptr(Bullet.Const_BtVector3._Underlying *_this);
            var __c_ret = __btVector3_ConvertTo_const_double_ptr(_this._UnderlyingPtr);
            return __c_ret is not null ? *__c_ret : null;
        }

        /// Generated from method `btVector3::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btVector3_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btVector3_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btVector3_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btVector3_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btVector3::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btVector3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btVector3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btVector3_void_ptr(void *ptr);
            __Bullet_delete_btVector3_void_ptr(ptr);
        }

        /// Generated from method `btVector3::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btVector3_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btVector3_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btVector3_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btVector3_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btVector3::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btVector3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btVector3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btVector3_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btVector3_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btVector3::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btVector3_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btVector3_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btVector3_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btVector3_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btVector3::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btVector3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btVector3_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btVector3_void_ptr(void *ptr);
            __Bullet_delete_array_btVector3_void_ptr(ptr);
        }

        /// Generated from method `btVector3::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btVector3_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btVector3_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btVector3_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btVector3_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btVector3::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btVector3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btVector3_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btVector3_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btVector3_void_ptr_void_ptr(_1, _2);
        }

        /**@brief Return the dot product
        * @param v The other vector in the dot product */
        /// Generated from method `btVector3::dot`.
        public unsafe double Dot(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_dot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btVector3_dot(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            return __btVector3_dot(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /**@brief Return the length of the vector squared */
        /// Generated from method `btVector3::length2`.
        public unsafe double Length2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_length2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_length2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btVector3_length2(_Underlying *_this);
            return __btVector3_length2(_UnderlyingPtr);
        }

        /**@brief Return the length of the vector */
        /// Generated from method `btVector3::length`.
        public unsafe double Length()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_length", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btVector3_length(_Underlying *_this);
            return __btVector3_length(_UnderlyingPtr);
        }

        /**@brief Return the norm (length) of the vector */
        /// Generated from method `btVector3::norm`.
        public unsafe double Norm()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_norm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_norm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btVector3_norm(_Underlying *_this);
            return __btVector3_norm(_UnderlyingPtr);
        }

        /**@brief Return the norm (length) of the vector */
        /// Generated from method `btVector3::safeNorm`.
        public unsafe double SafeNorm()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_safeNorm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_safeNorm", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btVector3_safeNorm(_Underlying *_this);
            return __btVector3_safeNorm(_UnderlyingPtr);
        }

        /**@brief Return the distance squared between the ends of this and another vector
        * This is symantically treating the vector like a point */
        /// Generated from method `btVector3::distance2`.
        public unsafe double Distance2(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_distance2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_distance2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btVector3_distance2(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            return __btVector3_distance2(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /**@brief Return the distance between the ends of this and another vector
        * This is symantically treating the vector like a point */
        /// Generated from method `btVector3::distance`.
        public unsafe double Distance(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_distance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_distance", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btVector3_distance(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            return __btVector3_distance(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /**@brief Return a normalized version of this vector */
        /// Generated from method `btVector3::normalized`.
        public unsafe Bullet.BtVector3 Normalized()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_normalized", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_normalized(_Underlying *_this);
            return new(__btVector3_normalized(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Return a rotated version of this vector
        * @param wAxis The axis to rotate about 
        * @param angle The angle to rotate by */
        /// Generated from method `btVector3::rotate`.
        public unsafe Bullet.BtVector3 Rotate(Bullet.Const_BtVector3 wAxis, double angle)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_rotate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_rotate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_rotate(_Underlying *_this, Bullet.Const_BtVector3._Underlying *wAxis, double angle);
            return new(__btVector3_rotate(_UnderlyingPtr, wAxis._UnderlyingPtr, angle), is_owning: true);
        }

        /**@brief Return the angle between this and another vector
        * @param v The other vector */
        /// Generated from method `btVector3::angle`.
        public unsafe double Angle(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_angle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_angle", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btVector3_angle(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            return __btVector3_angle(_UnderlyingPtr, v._UnderlyingPtr);
        }

        /**@brief Return a vector with the absolute values of each element */
        /// Generated from method `btVector3::absolute`.
        public unsafe Bullet.BtVector3 Absolute()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_absolute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_absolute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_absolute(_Underlying *_this);
            return new(__btVector3_absolute(_UnderlyingPtr), is_owning: true);
        }

        /**@brief Return the cross product between this and another vector 
        * @param v The other vector */
        /// Generated from method `btVector3::cross`.
        public unsafe Bullet.BtVector3 Cross(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_cross", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_cross", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_cross(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            return new(__btVector3_cross(_UnderlyingPtr, v._UnderlyingPtr), is_owning: true);
        }

        /// Generated from method `btVector3::triple`.
        public unsafe double Triple(Bullet.Const_BtVector3 v1, Bullet.Const_BtVector3 v2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_triple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_triple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btVector3_triple(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v1, Bullet.Const_BtVector3._Underlying *v2);
            return __btVector3_triple(_UnderlyingPtr, v1._UnderlyingPtr, v2._UnderlyingPtr);
        }

        /**@brief Return the axis with the smallest value 
        * Note return values are 0,1,2 for x, y, or z */
        /// Generated from method `btVector3::minAxis`.
        public unsafe int MinAxis()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_minAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_minAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btVector3_minAxis(_Underlying *_this);
            return __btVector3_minAxis(_UnderlyingPtr);
        }

        /**@brief Return the axis with the largest value 
        * Note return values are 0,1,2 for x, y, or z */
        /// Generated from method `btVector3::maxAxis`.
        public unsafe int MaxAxis()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_maxAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_maxAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btVector3_maxAxis(_Underlying *_this);
            return __btVector3_maxAxis(_UnderlyingPtr);
        }

        /// Generated from method `btVector3::furthestAxis`.
        public unsafe int FurthestAxis()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_furthestAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_furthestAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btVector3_furthestAxis(_Underlying *_this);
            return __btVector3_furthestAxis(_UnderlyingPtr);
        }

        /// Generated from method `btVector3::closestAxis`.
        public unsafe int ClosestAxis()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_closestAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_closestAxis", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btVector3_closestAxis(_Underlying *_this);
            return __btVector3_closestAxis(_UnderlyingPtr);
        }

        /**@brief Return the linear interpolation between this and another vector 
        * @param v The other vector 
        * @param t The ration of this to v (t = 0 => return this, t=1 => return other) */
        /// Generated from method `btVector3::lerp`.
        public unsafe Bullet.BtVector3 Lerp(Bullet.Const_BtVector3 v, double t)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_lerp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_lerp", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_lerp(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v, double *t);
            return new(__btVector3_lerp(_UnderlyingPtr, v._UnderlyingPtr, &t), is_owning: true);
        }

        /**@brief Return the x value */
        /// Generated from method `btVector3::getX`.
        public unsafe double GetX()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_getX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_getX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btVector3_getX(_Underlying *_this);
            return *__btVector3_getX(_UnderlyingPtr);
        }

        /**@brief Return the y value */
        /// Generated from method `btVector3::getY`.
        public unsafe double GetY()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_getY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_getY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btVector3_getY(_Underlying *_this);
            return *__btVector3_getY(_UnderlyingPtr);
        }

        /**@brief Return the z value */
        /// Generated from method `btVector3::getZ`.
        public unsafe double GetZ()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_getZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_getZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btVector3_getZ(_Underlying *_this);
            return *__btVector3_getZ(_UnderlyingPtr);
        }

        /**@brief Return the x value */
        /// Generated from method `btVector3::x`.
        public unsafe double X()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_x", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btVector3_x(_Underlying *_this);
            return *__btVector3_x(_UnderlyingPtr);
        }

        /**@brief Return the y value */
        /// Generated from method `btVector3::y`.
        public unsafe double Y()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_y", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btVector3_y(_Underlying *_this);
            return *__btVector3_y(_UnderlyingPtr);
        }

        /**@brief Return the z value */
        /// Generated from method `btVector3::z`.
        public unsafe double Z()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_z", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btVector3_z(_Underlying *_this);
            return *__btVector3_z(_UnderlyingPtr);
        }

        /**@brief Return the w value */
        /// Generated from method `btVector3::w`.
        public unsafe double W()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_w", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btVector3_w(_Underlying *_this);
            return *__btVector3_w(_UnderlyingPtr);
        }

        /// Generated from method `btVector3::operator==`.
        public static unsafe bool operator==(Bullet.Const_BtVector3 _this, Bullet.Const_BtVector3 other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_equal_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_equal_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __Bullet_equal_btVector3(Bullet.Const_BtVector3._Underlying *_this, Bullet.Const_BtVector3._Underlying *other);
            return __Bullet_equal_btVector3(_this._UnderlyingPtr, other._UnderlyingPtr) != 0;
        }

        public static unsafe bool operator!=(Bullet.Const_BtVector3 _this, Bullet.Const_BtVector3 other)
        {
            return !(_this == other);
        }

        /// Generated from method `btVector3::getSkewSymmetricMatrix`.
        public unsafe void GetSkewSymmetricMatrix(Bullet.BtVector3? v0, Bullet.BtVector3? v1, Bullet.BtVector3? v2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_getSkewSymmetricMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_getSkewSymmetricMatrix", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_getSkewSymmetricMatrix(_Underlying *_this, Bullet.BtVector3._Underlying *v0, Bullet.BtVector3._Underlying *v1, Bullet.BtVector3._Underlying *v2);
            __btVector3_getSkewSymmetricMatrix(_UnderlyingPtr, v0 is not null ? v0._UnderlyingPtr : null, v1 is not null ? v1._UnderlyingPtr : null, v2 is not null ? v2._UnderlyingPtr : null);
        }

        /// Generated from method `btVector3::isZero`.
        public unsafe bool IsZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_isZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_isZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btVector3_isZero(_Underlying *_this);
            return __btVector3_isZero(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btVector3::fuzzyZero`.
        public unsafe bool FuzzyZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_fuzzyZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_fuzzyZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btVector3_fuzzyZero(_Underlying *_this);
            return __btVector3_fuzzyZero(_UnderlyingPtr) != 0;
        }

        /**@brief returns index of maximum dot product between this and vectors in array[]
        * @param array The other vectors 
        * @param array_count The number of other vectors 
        * @param dotOut The maximum dot product */
        /// Generated from method `btVector3::maxDot`.
        public unsafe long MaxDot(Bullet.Const_BtVector3? array, long array_count, ref double dotOut)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_maxDot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_maxDot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static long __btVector3_maxDot(_Underlying *_this, Bullet.Const_BtVector3._Underlying *array, long array_count, double *dotOut);
            fixed (double *__ptr_dotOut = &dotOut)
            {
                return __btVector3_maxDot(_UnderlyingPtr, array is not null ? array._UnderlyingPtr : null, array_count, __ptr_dotOut);
            }
        }

        /**@brief returns index of minimum dot product between this and vectors in array[]
        * @param array The other vectors 
        * @param array_count The number of other vectors 
        * @param dotOut The minimum dot product */
        /// Generated from method `btVector3::minDot`.
        public unsafe long MinDot(Bullet.Const_BtVector3? array, long array_count, ref double dotOut)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_minDot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_minDot", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static long __btVector3_minDot(_Underlying *_this, Bullet.Const_BtVector3._Underlying *array, long array_count, double *dotOut);
            fixed (double *__ptr_dotOut = &dotOut)
            {
                return __btVector3_minDot(_UnderlyingPtr, array is not null ? array._UnderlyingPtr : null, array_count, __ptr_dotOut);
            }
        }

        /* create a vector as  btVector3( this->dot( btVector3 v0 ), this->dot( btVector3 v1), this->dot( btVector3 v2 ))  */
        /// Generated from method `btVector3::dot3`.
        public unsafe Bullet.BtVector3 Dot3(Bullet.Const_BtVector3 v0, Bullet.Const_BtVector3 v1, Bullet.Const_BtVector3 v2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_dot3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_dot3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_dot3(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v0, Bullet.Const_BtVector3._Underlying *v1, Bullet.Const_BtVector3._Underlying *v2);
            return new(__btVector3_dot3(_UnderlyingPtr, v0._UnderlyingPtr, v1._UnderlyingPtr, v2._UnderlyingPtr), is_owning: true);
        }

        // IEquatable:

        public bool Equals(Bullet.Const_BtVector3? other)
        {
            if (other is null)
                return false;
            return this == other;
        }

        public override bool Equals(object? other)
        {
            if (other is null)
                return false;
            if (other is Bullet.Const_BtVector3)
                return this == (Bullet.Const_BtVector3)other;
            return false;
        }
    }

    /**@brief btVector3 can be used to represent 3D points and vectors.
    * It has an un-used w component to suit 16-byte alignment when btVector3 is stored in containers. This extra component can be used by derived classes (Quaternion?) or by user
    * Ideally, this class should be replaced by a platform optimized SIMD version that keeps the data in registers
    */
    /// Generated from class `btVector3`.
    /// This is the non-const half of the class.
    public class BtVector3 : Const_BtVector3
    {
        new public unsafe ref Bullet.ArrayDouble4 mFloats
        {
            get
            {
                #if __IOS__
                [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_GetMutable_m_floats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #else
                [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_GetMutable_m_floats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
                #endif
                extern static Bullet.ArrayDouble4 *__btVector3_GetMutable_m_floats(_Underlying *_this);
                return ref *(__btVector3_GetMutable_m_floats(_UnderlyingPtr));
            }
        }

        internal unsafe BtVector3(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BtVector3() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_DefaultConstruct();
            _UnderlyingPtr = __btVector3_DefaultConstruct();
        }

        /// Generated from constructor `btVector3::btVector3`.
        public unsafe BtVector3(Bullet.Const_BtVector3 _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_ConstructFromAnother(Bullet.BtVector3._Underlying *_other);
            _UnderlyingPtr = __btVector3_ConstructFromAnother(_other._UnderlyingPtr);
            _KeepAlive(_other);
        }

        /// Generated from constructor `btVector3::btVector3`.
        public BtVector3(BtVector3 _other) : this((Const_BtVector3)_other) {}

        /**@brief Constructor from scalars 
        * @param x X value
        * @param y Y value 
        * @param z Z value 
        */
        /// Generated from constructor `btVector3::btVector3`.
        public unsafe BtVector3(double _x, double _y, double _z) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_Construct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_Construct(double *_x, double *_y, double *_z);
            _UnderlyingPtr = __btVector3_Construct(&_x, &_y, &_z);
        }

        //SIMD_FORCE_INLINE btScalar&       operator[](int i)       { return (&m_floats[0])[i];	}
        //SIMD_FORCE_INLINE const btScalar& operator[](int i) const { return (&m_floats[0])[i]; }
        ///operator btScalar*() replaces operator[], using implicit conversion. We added operator != and operator == to avoid pointer comparisons.
        /// Generated from conversion operator `btVector3::operator double *`.
        public static unsafe implicit operator Bullet.Ref<double>?(Bullet.BtVector3 _this)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_ConvertTo_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_ConvertTo_double_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double *__btVector3_ConvertTo_double_ptr(Bullet.BtVector3._Underlying *_this);
            var __c_ret = __btVector3_ConvertTo_double_ptr(_this._UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Ref<double>(__c_ret) : null;
        }

        /// Generated from method `btVector3::operator=`.
        public unsafe Bullet.BtVector3 Assign(Bullet.Const_BtVector3 _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_AssignFromAnother(_Underlying *_this, Bullet.BtVector3._Underlying *_other);
            _DiscardKeepAlive();
            _KeepAlive(_other);
            return new(__btVector3_AssignFromAnother(_UnderlyingPtr, _other._UnderlyingPtr), is_owning: false);
        }

        /**@brief Add a vector to this one 
        * @param The vector to add to this one */
        /// Generated from method `btVector3::operator+=`.
        public unsafe Bullet.BtVector3 AddAssign(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_add_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_add_assign(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            Bullet.BtVector3 __ret;
            __ret = new(__btVector3_add_assign(_UnderlyingPtr, v._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /**@brief Subtract a vector from this one
        * @param The vector to subtract */
        /// Generated from method `btVector3::operator-=`.
        public unsafe Bullet.BtVector3 SubAssign(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_sub_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_sub_assign(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            Bullet.BtVector3 __ret;
            __ret = new(__btVector3_sub_assign(_UnderlyingPtr, v._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /**@brief Scale the vector
        * @param s Scale factor */
        /// Generated from method `btVector3::operator*=`.
        public unsafe Bullet.BtVector3 MulAssign(double s)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_mul_assign_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_mul_assign_double", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_mul_assign_double(_Underlying *_this, double *s);
            Bullet.BtVector3 __ret;
            __ret = new(__btVector3_mul_assign_double(_UnderlyingPtr, &s), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /**@brief Inversely scale the vector 
        * @param s Scale factor to divide by */
        /// Generated from method `btVector3::operator/=`.
        public unsafe Bullet.BtVector3 DivAssign(double s)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_div_assign", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_div_assign(_Underlying *_this, double *s);
            Bullet.BtVector3 __ret;
            __ret = new(__btVector3_div_assign(_UnderlyingPtr, &s), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /// Generated from method `btVector3::safeNormalize`.
        public unsafe Bullet.BtVector3 SafeNormalize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_safeNormalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_safeNormalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_safeNormalize(_Underlying *_this);
            return new(__btVector3_safeNormalize(_UnderlyingPtr), is_owning: false);
        }

        /**@brief Normalize this vector 
        * x^2 + y^2 + z^2 = 1 */
        /// Generated from method `btVector3::normalize`.
        public unsafe Bullet.BtVector3 Normalize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_normalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_normalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_normalize(_Underlying *_this);
            return new(__btVector3_normalize(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btVector3::setInterpolate3`.
        public unsafe void SetInterpolate3(Bullet.Const_BtVector3 v0, Bullet.Const_BtVector3 v1, double rt)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_setInterpolate3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_setInterpolate3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_setInterpolate3(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v0, Bullet.Const_BtVector3._Underlying *v1, double rt);
            __btVector3_setInterpolate3(_UnderlyingPtr, v0._UnderlyingPtr, v1._UnderlyingPtr, rt);
        }

        /**@brief Elementwise multiply this vector by the other 
        * @param v The other vector */
        /// Generated from method `btVector3::operator*=`.
        public unsafe Bullet.BtVector3 MulAssign(Bullet.Const_BtVector3 v)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_mul_assign_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_mul_assign_btVector3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtVector3._Underlying *__btVector3_mul_assign_btVector3(_Underlying *_this, Bullet.Const_BtVector3._Underlying *v);
            Bullet.BtVector3 __ret;
            __ret = new(__btVector3_mul_assign_btVector3(_UnderlyingPtr, v._UnderlyingPtr), is_owning: false);
            __ret._KeepAlive(this);
            return __ret;
        }

        /**@brief Set the x value */
        /// Generated from method `btVector3::setX`.
        public unsafe void SetX(double _x)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_setX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_setX", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_setX(_Underlying *_this, double _x);
            __btVector3_setX(_UnderlyingPtr, _x);
        }

        /**@brief Set the y value */
        /// Generated from method `btVector3::setY`.
        public unsafe void SetY(double _y)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_setY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_setY", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_setY(_Underlying *_this, double _y);
            __btVector3_setY(_UnderlyingPtr, _y);
        }

        /**@brief Set the z value */
        /// Generated from method `btVector3::setZ`.
        public unsafe void SetZ(double _z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_setZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_setZ", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_setZ(_Underlying *_this, double _z);
            __btVector3_setZ(_UnderlyingPtr, _z);
        }

        /**@brief Set the w value */
        /// Generated from method `btVector3::setW`.
        public unsafe void SetW(double _w)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_setW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_setW", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_setW(_Underlying *_this, double _w);
            __btVector3_setW(_UnderlyingPtr, _w);
        }

        /**@brief Set each element to the max of the current values and the values of another btVector3
        * @param other The other btVector3 to compare with 
        */
        /// Generated from method `btVector3::setMax`.
        public unsafe void SetMax(Bullet.Const_BtVector3 other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_setMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_setMax", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_setMax(_Underlying *_this, Bullet.Const_BtVector3._Underlying *other);
            __btVector3_setMax(_UnderlyingPtr, other._UnderlyingPtr);
        }

        /**@brief Set each element to the min of the current values and the values of another btVector3
        * @param other The other btVector3 to compare with 
        */
        /// Generated from method `btVector3::setMin`.
        public unsafe void SetMin(Bullet.Const_BtVector3 other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_setMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_setMin", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_setMin(_Underlying *_this, Bullet.Const_BtVector3._Underlying *other);
            __btVector3_setMin(_UnderlyingPtr, other._UnderlyingPtr);
        }

        /// Generated from method `btVector3::setValue`.
        public unsafe void SetValue(double _x, double _y, double _z)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_setValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_setValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_setValue(_Underlying *_this, double *_x, double *_y, double *_z);
            __btVector3_setValue(_UnderlyingPtr, &_x, &_y, &_z);
        }

        /// Generated from method `btVector3::setZero`.
        public unsafe void SetZero()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btVector3_setZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btVector3_setZero", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btVector3_setZero(_Underlying *_this);
            __btVector3_setZero(_UnderlyingPtr);
        }
    }

    /// This is used for optional parameters of class `BtVector3` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtVector3`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtVector3`/`Const_BtVector3` directly.
    public class _InOptMut_BtVector3
    {
        public BtVector3? Opt;

        public _InOptMut_BtVector3() {}
        public _InOptMut_BtVector3(BtVector3 value) {Opt = value;}
        public static implicit operator _InOptMut_BtVector3(BtVector3 value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtVector3` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtVector3`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtVector3`/`Const_BtVector3` to pass it to the function.
    public class _InOptConst_BtVector3
    {
        public Const_BtVector3? Opt;

        public _InOptConst_BtVector3() {}
        public _InOptConst_BtVector3(Const_BtVector3 value) {Opt = value;}
        public static implicit operator _InOptConst_BtVector3(Const_BtVector3 value) {return new(value);}
    }
}
