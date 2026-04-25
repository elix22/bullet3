// machine generated, do not edit
public static partial class Bullet
{
    /// btCollisionObject can be used to manage collision detection objects.
    /// btCollisionObject maintains all information that is needed for a collision detection: Shape, Transform and AABB proxy.
    /// They can be added to the btCollisionWorld.
    /// Generated from class `btCollisionObject`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btRigidBody`
    /// This is the const half of the class.
    public class Const_BtCollisionObject : Bullet.Object<Const_BtCollisionObject>, System.IDisposable
    {
        internal struct _Underlying {} // Represents the underlying C++ type.

        internal unsafe _Underlying *_UnderlyingPtr;

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (_UnderlyingPtr is null || !_IsOwningVal)
                return;
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_Destroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_Destroy(_Underlying *_this);
            __btCollisionObject_Destroy(_UnderlyingPtr);
            _UnderlyingPtr = null;
        }
        public virtual void Dispose() {Dispose(true); GC.SuppressFinalize(this);}
        ~Const_BtCollisionObject() {Dispose(false);}

        internal unsafe Const_BtCollisionObject(_Underlying *ptr, bool is_owning) : base(is_owning) {_UnderlyingPtr = ptr;}

        /// Constructs an empty (default-constructed) instance.
        public unsafe Const_BtCollisionObject() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionObject._Underlying *__btCollisionObject_DefaultConstruct();
            _UnderlyingPtr = __btCollisionObject_DefaultConstruct();
        }

        /// Generated from constructor `btCollisionObject::btCollisionObject`.
        public unsafe Const_BtCollisionObject(Bullet._ByValue_BtCollisionObject _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionObject._Underlying *__btCollisionObject_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionObject._Underlying *_other);
            _UnderlyingPtr = __btCollisionObject_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCollisionObject::btCollisionObject`.
        public Const_BtCollisionObject(Const_BtCollisionObject _other) : this(new _ByValue_BtCollisionObject(_other)) {}

        /// Generated from constructor `btCollisionObject::btCollisionObject`.
        public Const_BtCollisionObject(BtCollisionObject _other) : this((Const_BtCollisionObject)_other) {}

        /// Generated from method `btCollisionObject::operator new`.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btCollisionObject_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btCollisionObject_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btCollisionObject_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_btCollisionObject_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btCollisionObject::operator delete`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void Delete(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btCollisionObject_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btCollisionObject_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btCollisionObject_void_ptr(void *ptr);
            __Bullet_delete_btCollisionObject_void_ptr(ptr);
        }

        /// Generated from method `btCollisionObject::operator new`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *New(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_btCollisionObject_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_btCollisionObject_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_btCollisionObject_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_btCollisionObject_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btCollisionObject::operator delete`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void Delete(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_btCollisionObject_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_btCollisionObject_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_btCollisionObject_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_btCollisionObject_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btCollisionObject::operator new[]`.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong sizeInBytes)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btCollisionObject_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btCollisionObject_unsigned_long", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btCollisionObject_unsigned_long(ulong sizeInBytes);
            return __Bullet_new_array_btCollisionObject_unsigned_long(sizeInBytes);
        }

        /// Generated from method `btCollisionObject::operator delete[]`.
        /// Parameter `ptr` is a mutable pointer.
        public static unsafe void DeleteArray(void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btCollisionObject_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btCollisionObject_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btCollisionObject_void_ptr(void *ptr);
            __Bullet_delete_array_btCollisionObject_void_ptr(ptr);
        }

        /// Generated from method `btCollisionObject::operator new[]`.
        /// Parameter `ptr` is a mutable pointer.
        /// Returns a mutable pointer.
        public static unsafe void *NewArray(ulong _1, void *ptr)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_new_array_btCollisionObject_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_new_array_btCollisionObject_unsigned_long_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__Bullet_new_array_btCollisionObject_unsigned_long_void_ptr(ulong _1, void *ptr);
            return __Bullet_new_array_btCollisionObject_unsigned_long_void_ptr(_1, ptr);
        }

        /// Generated from method `btCollisionObject::operator delete[]`.
        /// Parameter `_1` is a mutable pointer.
        /// Parameter `_2` is a mutable pointer.
        public static unsafe void DeleteArray(void *_1, void *_2)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "Bullet_delete_array_btCollisionObject_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "Bullet_delete_array_btCollisionObject_void_ptr_void_ptr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __Bullet_delete_array_btCollisionObject_void_ptr_void_ptr(void *_1, void *_2);
            __Bullet_delete_array_btCollisionObject_void_ptr_void_ptr(_1, _2);
        }

        /// Generated from method `btCollisionObject::mergesSimulationIslands`.
        public unsafe bool MergesSimulationIslands()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_mergesSimulationIslands", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_mergesSimulationIslands", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_mergesSimulationIslands(_Underlying *_this);
            return __btCollisionObject_mergesSimulationIslands(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionObject::getAnisotropicFriction`.
        public unsafe Bullet.Const_BtVector3 GetAnisotropicFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btCollisionObject_getAnisotropicFriction(_Underlying *_this);
            return new(__btCollisionObject_getAnisotropicFriction(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCollisionObject::hasAnisotropicFriction`.
        /// Parameter `frictionMode` defaults to `CF_ANISOTROPIC_FRICTION`.
        public unsafe bool HasAnisotropicFriction(int? frictionMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_hasAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_hasAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_hasAnisotropicFriction(_Underlying *_this, int *frictionMode);
            int __deref_frictionMode = frictionMode.GetValueOrDefault();
            return __btCollisionObject_hasAnisotropicFriction(_UnderlyingPtr, frictionMode.HasValue ? &__deref_frictionMode : null) != 0;
        }

        /// Generated from method `btCollisionObject::getContactProcessingThreshold`.
        public unsafe double GetContactProcessingThreshold()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getContactProcessingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getContactProcessingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getContactProcessingThreshold(_Underlying *_this);
            return __btCollisionObject_getContactProcessingThreshold(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::isStaticObject`.
        public unsafe bool IsStaticObject()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_isStaticObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_isStaticObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_isStaticObject(_Underlying *_this);
            return __btCollisionObject_isStaticObject(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionObject::isKinematicObject`.
        public unsafe bool IsKinematicObject()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_isKinematicObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_isKinematicObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_isKinematicObject(_Underlying *_this);
            return __btCollisionObject_isKinematicObject(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionObject::isStaticOrKinematicObject`.
        public unsafe bool IsStaticOrKinematicObject()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_isStaticOrKinematicObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_isStaticOrKinematicObject", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_isStaticOrKinematicObject(_Underlying *_this);
            return __btCollisionObject_isStaticOrKinematicObject(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionObject::hasContactResponse`.
        public unsafe bool HasContactResponse()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_hasContactResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_hasContactResponse", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_hasContactResponse(_Underlying *_this);
            return __btCollisionObject_hasContactResponse(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionObject::getCollisionShape`.
        public unsafe Bullet.Const_BtCollisionShape? GetCollisionShape()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionShape._Underlying *__btCollisionObject_getCollisionShape(_Underlying *_this);
            var __c_ret = __btCollisionObject_getCollisionShape(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.Const_BtCollisionShape(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btCollisionObject::getNumObjectsWithoutCollision`.
        public unsafe int GetNumObjectsWithoutCollision()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getNumObjectsWithoutCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getNumObjectsWithoutCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getNumObjectsWithoutCollision(_Underlying *_this);
            return __btCollisionObject_getNumObjectsWithoutCollision(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::checkCollideWithOverride`.
        public unsafe bool CheckCollideWithOverride(Bullet.Const_BtCollisionObject? co)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_checkCollideWithOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_checkCollideWithOverride", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_checkCollideWithOverride(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *co);
            return __btCollisionObject_checkCollideWithOverride(_UnderlyingPtr, co is not null ? co._UnderlyingPtr : null) != 0;
        }

        ///Avoid using this internal API call, the extension pointer is used by some Bullet extensions.
        ///If you need to store your own user pointer, use 'setUserPointer/getUserPointer' instead.
        /// Generated from method `btCollisionObject::internalGetExtensionPointer`.
        /// Returns a mutable pointer.
        public unsafe void *InternalGetExtensionPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_internalGetExtensionPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_internalGetExtensionPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btCollisionObject_internalGetExtensionPointer(_Underlying *_this);
            return __btCollisionObject_internalGetExtensionPointer(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getActivationState`.
        public unsafe int GetActivationState()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getActivationState(_Underlying *_this);
            return __btCollisionObject_getActivationState(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::setActivationState`.
        public unsafe void SetActivationState(int newState)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setActivationState(_Underlying *_this, int newState);
            __btCollisionObject_setActivationState(_UnderlyingPtr, newState);
        }

        /// Generated from method `btCollisionObject::getDeactivationTime`.
        public unsafe double GetDeactivationTime()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getDeactivationTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getDeactivationTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getDeactivationTime(_Underlying *_this);
            return __btCollisionObject_getDeactivationTime(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::forceActivationState`.
        public unsafe void ForceActivationState(int newState)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_forceActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_forceActivationState", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_forceActivationState(_Underlying *_this, int newState);
            __btCollisionObject_forceActivationState(_UnderlyingPtr, newState);
        }

        /// Generated from method `btCollisionObject::activate`.
        /// Parameter `forceActivation` defaults to `false`.
        public unsafe void Activate(bool? forceActivation = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_activate", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_activate(_Underlying *_this, byte *forceActivation);
            byte __deref_forceActivation = forceActivation.GetValueOrDefault() ? (byte)1 : (byte)0;
            __btCollisionObject_activate(_UnderlyingPtr, forceActivation.HasValue ? &__deref_forceActivation : null);
        }

        /// Generated from method `btCollisionObject::isActive`.
        public unsafe bool IsActive()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_isActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_isActive", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_isActive(_Underlying *_this);
            return __btCollisionObject_isActive(_UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionObject::getRestitution`.
        public unsafe double GetRestitution()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getRestitution(_Underlying *_this);
            return __btCollisionObject_getRestitution(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getFriction`.
        public unsafe double GetFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getFriction(_Underlying *_this);
            return __btCollisionObject_getFriction(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getRollingFriction`.
        public unsafe double GetRollingFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getRollingFriction(_Underlying *_this);
            return __btCollisionObject_getRollingFriction(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getSpinningFriction`.
        public unsafe double GetSpinningFriction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getSpinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getSpinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getSpinningFriction(_Underlying *_this);
            return __btCollisionObject_getSpinningFriction(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getContactStiffness`.
        public unsafe double GetContactStiffness()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getContactStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getContactStiffness", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getContactStiffness(_Underlying *_this);
            return __btCollisionObject_getContactStiffness(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getContactDamping`.
        public unsafe double GetContactDamping()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getContactDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getContactDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getContactDamping(_Underlying *_this);
            return __btCollisionObject_getContactDamping(_UnderlyingPtr);
        }

        ///reserved for Bullet internal usage
        /// Generated from method `btCollisionObject::getInternalType`.
        public unsafe int GetInternalType()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getInternalType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getInternalType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getInternalType(_Underlying *_this);
            return __btCollisionObject_getInternalType(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getWorldTransform`.
        public unsafe Bullet.Const_BtTransform GetWorldTransform()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtTransform._Underlying *__btCollisionObject_getWorldTransform(_Underlying *_this);
            return new(__btCollisionObject_getWorldTransform(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCollisionObject::getInterpolationWorldTransform`.
        public unsafe Bullet.Const_BtTransform GetInterpolationWorldTransform()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getInterpolationWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getInterpolationWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtTransform._Underlying *__btCollisionObject_getInterpolationWorldTransform(_Underlying *_this);
            return new(__btCollisionObject_getInterpolationWorldTransform(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCollisionObject::getInterpolationLinearVelocity`.
        public unsafe Bullet.Const_BtVector3 GetInterpolationLinearVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getInterpolationLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getInterpolationLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btCollisionObject_getInterpolationLinearVelocity(_Underlying *_this);
            return new(__btCollisionObject_getInterpolationLinearVelocity(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCollisionObject::getInterpolationAngularVelocity`.
        public unsafe Bullet.Const_BtVector3 GetInterpolationAngularVelocity()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getInterpolationAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getInterpolationAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtVector3._Underlying *__btCollisionObject_getInterpolationAngularVelocity(_Underlying *_this);
            return new(__btCollisionObject_getInterpolationAngularVelocity(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCollisionObject::getIslandTag`.
        public unsafe int GetIslandTag()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getIslandTag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getIslandTag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getIslandTag(_Underlying *_this);
            return __btCollisionObject_getIslandTag(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getCompanionId`.
        public unsafe int GetCompanionId()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getCompanionId", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getCompanionId", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getCompanionId(_Underlying *_this);
            return __btCollisionObject_getCompanionId(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getWorldArrayIndex`.
        public unsafe int GetWorldArrayIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getWorldArrayIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getWorldArrayIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getWorldArrayIndex(_Underlying *_this);
            return __btCollisionObject_getWorldArrayIndex(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getHitFraction`.
        public unsafe double GetHitFraction()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getHitFraction(_Underlying *_this);
            return __btCollisionObject_getHitFraction(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getCollisionFlags`.
        public unsafe int GetCollisionFlags()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getCollisionFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getCollisionFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getCollisionFlags(_Underlying *_this);
            return __btCollisionObject_getCollisionFlags(_UnderlyingPtr);
        }

        ///Swept sphere radius (0.0 by default), see btConvexConvexAlgorithm::
        /// Generated from method `btCollisionObject::getCcdSweptSphereRadius`.
        public unsafe double GetCcdSweptSphereRadius()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getCcdSweptSphereRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getCcdSweptSphereRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getCcdSweptSphereRadius(_Underlying *_this);
            return __btCollisionObject_getCcdSweptSphereRadius(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getCcdMotionThreshold`.
        public unsafe double GetCcdMotionThreshold()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getCcdMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getCcdMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getCcdMotionThreshold(_Underlying *_this);
            return __btCollisionObject_getCcdMotionThreshold(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getCcdSquareMotionThreshold`.
        public unsafe double GetCcdSquareMotionThreshold()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getCcdSquareMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getCcdSquareMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static double __btCollisionObject_getCcdSquareMotionThreshold(_Underlying *_this);
            return __btCollisionObject_getCcdSquareMotionThreshold(_UnderlyingPtr);
        }

        ///users can point to their objects, userPointer is not used by Bullet
        /// Generated from method `btCollisionObject::getUserPointer`.
        /// Returns a mutable pointer.
        public unsafe void *GetUserPointer()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void *__btCollisionObject_getUserPointer(_Underlying *_this);
            return __btCollisionObject_getUserPointer(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getUserIndex`.
        public unsafe int GetUserIndex()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getUserIndex(_Underlying *_this);
            return __btCollisionObject_getUserIndex(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getUserIndex2`.
        public unsafe int GetUserIndex2()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getUserIndex2(_Underlying *_this);
            return __btCollisionObject_getUserIndex2(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getUserIndex3`.
        public unsafe int GetUserIndex3()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getUserIndex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getUserIndex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getUserIndex3(_Underlying *_this);
            return __btCollisionObject_getUserIndex3(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getUpdateRevisionInternal`.
        public unsafe int GetUpdateRevisionInternal()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getUpdateRevisionInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getUpdateRevisionInternal", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_getUpdateRevisionInternal(_Underlying *_this);
            return __btCollisionObject_getUpdateRevisionInternal(_UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getCustomDebugColor`.
        public unsafe bool GetCustomDebugColor(Bullet.BtVector3 colorRGB)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_getCustomDebugColor(_Underlying *_this, Bullet.BtVector3._Underlying *colorRGB);
            return __btCollisionObject_getCustomDebugColor(_UnderlyingPtr, colorRGB._UnderlyingPtr) != 0;
        }

        /// Generated from method `btCollisionObject::checkCollideWith`.
        public unsafe bool CheckCollideWith(Bullet.Const_BtCollisionObject? co)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_checkCollideWith", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_checkCollideWith", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static byte __btCollisionObject_checkCollideWith(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *co);
            return __btCollisionObject_checkCollideWith(_UnderlyingPtr, co is not null ? co._UnderlyingPtr : null) != 0;
        }

        // clang-format on
        /// Generated from method `btCollisionObject::calculateSerializeBufferSize`.
        public unsafe int CalculateSerializeBufferSize()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_calculateSerializeBufferSize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static int __btCollisionObject_calculateSerializeBufferSize(_Underlying *_this);
            return __btCollisionObject_calculateSerializeBufferSize(_UnderlyingPtr);
        }

        public enum AnisotropicFrictionFlags : uint
        {
            CFANISOTROPICFRICTIONDISABLED = 0,
            CFANISOTROPICFRICTION = 1,
            CFANISOTROPICROLLINGFRICTION = 2,
        }

        public enum CollisionFlags : uint
        {
            CFDYNAMICOBJECT = 0,
            CFSTATICOBJECT = 1,
            CFKINEMATICOBJECT = 2,
            CFNOCONTACTRESPONSE = 4,
            //this allows per-triangle material (friction/restitution)
            CFCUSTOMMATERIALCALLBACK = 8,
            CFCHARACTEROBJECT = 16,
            //disable debug drawing
            CFDISABLEVISUALIZEOBJECT = 32,
            //disable parallel/SPU processing
            CFDISABLESPUCOLLISIONPROCESSING = 64,
            CFHASCONTACTSTIFFNESSDAMPING = 128,
            CFHASCUSTOMDEBUGRENDERINGCOLOR = 256,
            CFHASFRICTIONANCHOR = 512,
            CFHASCOLLISIONSOUNDTRIGGER = 1024,
        }

        public enum CollisionObjectTypes : uint
        {
            COCOLLISIONOBJECT = 1,
            CORIGIDBODY = 2,
            ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
            ///It is useful for collision sensors, explosion objects, character controller etc.
            COGHOSTOBJECT = 4,
            ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
            ///It is useful for collision sensors, explosion objects, character controller etc.
            COSOFTBODY = 8,
            ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
            ///It is useful for collision sensors, explosion objects, character controller etc.
            COHFFLUID = 16,
            ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
            ///It is useful for collision sensors, explosion objects, character controller etc.
            COUSERTYPE = 32,
            ///CO_GHOST_OBJECT keeps track of all objects overlapping its AABB and that pass its collision filter
            ///It is useful for collision sensors, explosion objects, character controller etc.
            COFEATHERSTONELINK = 64,
        }
    }

    /// btCollisionObject can be used to manage collision detection objects.
    /// btCollisionObject maintains all information that is needed for a collision detection: Shape, Transform and AABB proxy.
    /// They can be added to the btCollisionWorld.
    /// Generated from class `btCollisionObject`.
    /// Derived classes:
    ///   Direct: (non-virtual)
    ///     `btRigidBody`
    /// This is the non-const half of the class.
    public class BtCollisionObject : Const_BtCollisionObject
    {
        internal unsafe BtCollisionObject(_Underlying *ptr, bool is_owning) : base(ptr, is_owning) {}

        /// Constructs an empty (default-constructed) instance.
        public unsafe BtCollisionObject() : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_DefaultConstruct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionObject._Underlying *__btCollisionObject_DefaultConstruct();
            _UnderlyingPtr = __btCollisionObject_DefaultConstruct();
        }

        /// Generated from constructor `btCollisionObject::btCollisionObject`.
        public unsafe BtCollisionObject(Bullet._ByValue_BtCollisionObject _other) : this(null, is_owning: true)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_ConstructFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionObject._Underlying *__btCollisionObject_ConstructFromAnother(Bullet._PassBy _other_pass_by, Bullet.BtCollisionObject._Underlying *_other);
            _UnderlyingPtr = __btCollisionObject_ConstructFromAnother(_other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null);
            if (_other.Value is not null) _KeepAlive(_other.Value);
        }

        /// Generated from constructor `btCollisionObject::btCollisionObject`.
        public BtCollisionObject(Const_BtCollisionObject _other) : this(new _ByValue_BtCollisionObject(_other)) {}

        /// Generated from constructor `btCollisionObject::btCollisionObject`.
        public BtCollisionObject(BtCollisionObject _other) : this((Const_BtCollisionObject)_other) {}

        /// Generated from method `btCollisionObject::operator=`.
        public unsafe Bullet.BtCollisionObject Assign(Bullet._ByValue_BtCollisionObject _other)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_AssignFromAnother", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionObject._Underlying *__btCollisionObject_AssignFromAnother(_Underlying *_this, Bullet._PassBy _other_pass_by, Bullet.BtCollisionObject._Underlying *_other);
            _DiscardKeepAlive();
            if (_other.Value is not null) _KeepAlive(_other.Value);
            return new(__btCollisionObject_AssignFromAnother(_UnderlyingPtr, _other.PassByMode, _other.Value is not null ? _other.Value._UnderlyingPtr : null), is_owning: false);
        }

        /// Generated from method `btCollisionObject::setAnisotropicFriction`.
        /// Parameter `frictionMode` defaults to `CF_ANISOTROPIC_FRICTION`.
        public unsafe void SetAnisotropicFriction(Bullet.Const_BtVector3 anisotropicFriction, int? frictionMode = null)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setAnisotropicFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setAnisotropicFriction(_Underlying *_this, Bullet.Const_BtVector3._Underlying *anisotropicFriction, int *frictionMode);
            int __deref_frictionMode = frictionMode.GetValueOrDefault();
            __btCollisionObject_setAnisotropicFriction(_UnderlyingPtr, anisotropicFriction._UnderlyingPtr, frictionMode.HasValue ? &__deref_frictionMode : null);
        }

        ///the constraint solver can discard solving contacts, if the distance is above this threshold. 0 by default.
        ///Note that using contacts with positive distance can improve stability. It increases, however, the chance of colliding with degerate contacts, such as 'interior' triangle edges
        /// Generated from method `btCollisionObject::setContactProcessingThreshold`.
        public unsafe void SetContactProcessingThreshold(double contactProcessingThreshold)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setContactProcessingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setContactProcessingThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setContactProcessingThreshold(_Underlying *_this, double contactProcessingThreshold);
            __btCollisionObject_setContactProcessingThreshold(_UnderlyingPtr, contactProcessingThreshold);
        }

        /// Generated from method `btCollisionObject::setCollisionShape`.
        public unsafe void SetCollisionShape(Bullet.BtCollisionShape? collisionShape)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setCollisionShape", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setCollisionShape(_Underlying *_this, Bullet.BtCollisionShape._Underlying *collisionShape);
            __btCollisionObject_setCollisionShape(_UnderlyingPtr, collisionShape is not null ? collisionShape._UnderlyingPtr : null);
        }

        /// Generated from method `btCollisionObject::getCollisionShape`.
        public unsafe new Bullet.BtCollisionShape? GetCollisionShape()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getCollisionShape_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getCollisionShape_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtCollisionShape._Underlying *__btCollisionObject_getCollisionShape_mut(_Underlying *_this);
            var __c_ret = __btCollisionObject_getCollisionShape_mut(_UnderlyingPtr);
            return __c_ret is not null ? new Bullet.BtCollisionShape(__c_ret, is_owning: false) : null;
        }

        /// Generated from method `btCollisionObject::setIgnoreCollisionCheck`.
        public unsafe void SetIgnoreCollisionCheck(Bullet.Const_BtCollisionObject? co, bool ignoreCollisionCheck)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setIgnoreCollisionCheck", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setIgnoreCollisionCheck", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setIgnoreCollisionCheck(_Underlying *_this, Bullet.Const_BtCollisionObject._Underlying *co, byte ignoreCollisionCheck);
            __btCollisionObject_setIgnoreCollisionCheck(_UnderlyingPtr, co is not null ? co._UnderlyingPtr : null, ignoreCollisionCheck ? (byte)1 : (byte)0);
        }

        /// Generated from method `btCollisionObject::getObjectWithoutCollision`.
        public unsafe Bullet.Const_BtCollisionObject? GetObjectWithoutCollision(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getObjectWithoutCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getObjectWithoutCollision", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.Const_BtCollisionObject._Underlying *__btCollisionObject_getObjectWithoutCollision(_Underlying *_this, int index);
            var __c_ret = __btCollisionObject_getObjectWithoutCollision(_UnderlyingPtr, index);
            return __c_ret is not null ? new Bullet.Const_BtCollisionObject(__c_ret, is_owning: false) : null;
        }

        ///Avoid using this internal API call, the extension pointer is used by some Bullet extensions
        ///If you need to store your own user pointer, use 'setUserPointer/getUserPointer' instead.
        /// Generated from method `btCollisionObject::internalSetExtensionPointer`.
        /// Parameter `pointer` is a mutable pointer.
        public unsafe void InternalSetExtensionPointer(void *pointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_internalSetExtensionPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_internalSetExtensionPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_internalSetExtensionPointer(_Underlying *_this, void *pointer);
            __btCollisionObject_internalSetExtensionPointer(_UnderlyingPtr, pointer);
        }

        /// Generated from method `btCollisionObject::setDeactivationTime`.
        public unsafe void SetDeactivationTime(double time)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setDeactivationTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setDeactivationTime", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setDeactivationTime(_Underlying *_this, double time);
            __btCollisionObject_setDeactivationTime(_UnderlyingPtr, time);
        }

        /// Generated from method `btCollisionObject::setRestitution`.
        public unsafe void SetRestitution(double rest)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setRestitution", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setRestitution(_Underlying *_this, double rest);
            __btCollisionObject_setRestitution(_UnderlyingPtr, rest);
        }

        /// Generated from method `btCollisionObject::setFriction`.
        public unsafe void SetFriction(double frict)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setFriction(_Underlying *_this, double frict);
            __btCollisionObject_setFriction(_UnderlyingPtr, frict);
        }

        /// Generated from method `btCollisionObject::setRollingFriction`.
        public unsafe void SetRollingFriction(double frict)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setRollingFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setRollingFriction(_Underlying *_this, double frict);
            __btCollisionObject_setRollingFriction(_UnderlyingPtr, frict);
        }

        /// Generated from method `btCollisionObject::setSpinningFriction`.
        public unsafe void SetSpinningFriction(double frict)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setSpinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setSpinningFriction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setSpinningFriction(_Underlying *_this, double frict);
            __btCollisionObject_setSpinningFriction(_UnderlyingPtr, frict);
        }

        /// Generated from method `btCollisionObject::setContactStiffnessAndDamping`.
        public unsafe void SetContactStiffnessAndDamping(double stiffness, double damping)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setContactStiffnessAndDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setContactStiffnessAndDamping", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setContactStiffnessAndDamping(_Underlying *_this, double stiffness, double damping);
            __btCollisionObject_setContactStiffnessAndDamping(_UnderlyingPtr, stiffness, damping);
        }

        /// Generated from method `btCollisionObject::getWorldTransform`.
        public unsafe new Bullet.BtTransform GetWorldTransform()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getWorldTransform_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getWorldTransform_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btCollisionObject_getWorldTransform_mut(_Underlying *_this);
            return new(__btCollisionObject_getWorldTransform_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCollisionObject::setWorldTransform`.
        public unsafe void SetWorldTransform(Bullet.Const_BtTransform worldTrans)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setWorldTransform(_Underlying *_this, Bullet.Const_BtTransform._Underlying *worldTrans);
            __btCollisionObject_setWorldTransform(_UnderlyingPtr, worldTrans._UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::getInterpolationWorldTransform`.
        public unsafe new Bullet.BtTransform GetInterpolationWorldTransform()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_getInterpolationWorldTransform_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_getInterpolationWorldTransform_mut", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static Bullet.BtTransform._Underlying *__btCollisionObject_getInterpolationWorldTransform_mut(_Underlying *_this);
            return new(__btCollisionObject_getInterpolationWorldTransform_mut(_UnderlyingPtr), is_owning: false);
        }

        /// Generated from method `btCollisionObject::setInterpolationWorldTransform`.
        public unsafe void SetInterpolationWorldTransform(Bullet.Const_BtTransform trans)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setInterpolationWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setInterpolationWorldTransform", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setInterpolationWorldTransform(_Underlying *_this, Bullet.Const_BtTransform._Underlying *trans);
            __btCollisionObject_setInterpolationWorldTransform(_UnderlyingPtr, trans._UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::setInterpolationLinearVelocity`.
        public unsafe void SetInterpolationLinearVelocity(Bullet.Const_BtVector3 linvel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setInterpolationLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setInterpolationLinearVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setInterpolationLinearVelocity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *linvel);
            __btCollisionObject_setInterpolationLinearVelocity(_UnderlyingPtr, linvel._UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::setInterpolationAngularVelocity`.
        public unsafe void SetInterpolationAngularVelocity(Bullet.Const_BtVector3 angvel)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setInterpolationAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setInterpolationAngularVelocity", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setInterpolationAngularVelocity(_Underlying *_this, Bullet.Const_BtVector3._Underlying *angvel);
            __btCollisionObject_setInterpolationAngularVelocity(_UnderlyingPtr, angvel._UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::setIslandTag`.
        public unsafe void SetIslandTag(int tag)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setIslandTag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setIslandTag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setIslandTag(_Underlying *_this, int tag);
            __btCollisionObject_setIslandTag(_UnderlyingPtr, tag);
        }

        /// Generated from method `btCollisionObject::setCompanionId`.
        public unsafe void SetCompanionId(int id)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setCompanionId", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setCompanionId", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setCompanionId(_Underlying *_this, int id);
            __btCollisionObject_setCompanionId(_UnderlyingPtr, id);
        }

        // only should be called by CollisionWorld
        /// Generated from method `btCollisionObject::setWorldArrayIndex`.
        public unsafe void SetWorldArrayIndex(int ix)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setWorldArrayIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setWorldArrayIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setWorldArrayIndex(_Underlying *_this, int ix);
            __btCollisionObject_setWorldArrayIndex(_UnderlyingPtr, ix);
        }

        /// Generated from method `btCollisionObject::setHitFraction`.
        public unsafe void SetHitFraction(double hitFraction)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setHitFraction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setHitFraction(_Underlying *_this, double hitFraction);
            __btCollisionObject_setHitFraction(_UnderlyingPtr, hitFraction);
        }

        /// Generated from method `btCollisionObject::setCollisionFlags`.
        public unsafe void SetCollisionFlags(int flags)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setCollisionFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setCollisionFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setCollisionFlags(_Underlying *_this, int flags);
            __btCollisionObject_setCollisionFlags(_UnderlyingPtr, flags);
        }

        ///Swept sphere radius (0.0 by default), see btConvexConvexAlgorithm::
        /// Generated from method `btCollisionObject::setCcdSweptSphereRadius`.
        public unsafe void SetCcdSweptSphereRadius(double radius)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setCcdSweptSphereRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setCcdSweptSphereRadius", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setCcdSweptSphereRadius(_Underlying *_this, double radius);
            __btCollisionObject_setCcdSweptSphereRadius(_UnderlyingPtr, radius);
        }

        /// Don't do continuous collision detection if the motion (in one step) is less then m_ccdMotionThreshold
        /// Generated from method `btCollisionObject::setCcdMotionThreshold`.
        public unsafe void SetCcdMotionThreshold(double ccdMotionThreshold)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setCcdMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setCcdMotionThreshold", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setCcdMotionThreshold(_Underlying *_this, double ccdMotionThreshold);
            __btCollisionObject_setCcdMotionThreshold(_UnderlyingPtr, ccdMotionThreshold);
        }

        ///users can point to their objects, userPointer is not used by Bullet
        /// Generated from method `btCollisionObject::setUserPointer`.
        /// Parameter `userPointer` is a mutable pointer.
        public unsafe void SetUserPointer(void *userPointer)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setUserPointer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setUserPointer(_Underlying *_this, void *userPointer);
            __btCollisionObject_setUserPointer(_UnderlyingPtr, userPointer);
        }

        ///users can point to their objects, userPointer is not used by Bullet
        /// Generated from method `btCollisionObject::setUserIndex`.
        public unsafe void SetUserIndex(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setUserIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setUserIndex(_Underlying *_this, int index);
            __btCollisionObject_setUserIndex(_UnderlyingPtr, index);
        }

        /// Generated from method `btCollisionObject::setUserIndex2`.
        public unsafe void SetUserIndex2(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setUserIndex2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setUserIndex2(_Underlying *_this, int index);
            __btCollisionObject_setUserIndex2(_UnderlyingPtr, index);
        }

        /// Generated from method `btCollisionObject::setUserIndex3`.
        public unsafe void SetUserIndex3(int index)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setUserIndex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setUserIndex3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setUserIndex3(_Underlying *_this, int index);
            __btCollisionObject_setUserIndex3(_UnderlyingPtr, index);
        }

        /// Generated from method `btCollisionObject::setCustomDebugColor`.
        public unsafe void SetCustomDebugColor(Bullet.Const_BtVector3 colorRGB)
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_setCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_setCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_setCustomDebugColor(_Underlying *_this, Bullet.Const_BtVector3._Underlying *colorRGB);
            __btCollisionObject_setCustomDebugColor(_UnderlyingPtr, colorRGB._UnderlyingPtr);
        }

        /// Generated from method `btCollisionObject::removeCustomDebugColor`.
        public unsafe void RemoveCustomDebugColor()
        {
            #if __IOS__
            [System.Runtime.InteropServices.DllImport("@rpath/cbullet.framework/cbullet", EntryPoint = "btCollisionObject_removeCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #else
            [System.Runtime.InteropServices.DllImport("cbullet", EntryPoint = "btCollisionObject_removeCustomDebugColor", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, ExactSpelling = true)]
            #endif
            extern static void __btCollisionObject_removeCustomDebugColor(_Underlying *_this);
            __btCollisionObject_removeCustomDebugColor(_UnderlyingPtr);
        }
    }

    /// This is used as a function parameter when the underlying function receives `BtCollisionObject` by value.
    /// Usage:
    /// * Pass `new()` to default-construct the instance.
    /// * Pass an instance of `BtCollisionObject`/`Const_BtCollisionObject` to copy it into the function.
    /// * Pass `null` to use the default argument, assuming the parameter has a default argument (has `?` in the type).
    public class _ByValue_BtCollisionObject
    {
        #pragma warning disable CS0649
        internal readonly Const_BtCollisionObject? Value;
        #pragma warning restore CS0649
        internal readonly Bullet._PassBy PassByMode;
        public _ByValue_BtCollisionObject() {PassByMode = Bullet._PassBy.default_construct;}
        public _ByValue_BtCollisionObject(Const_BtCollisionObject new_value) {Value = new_value; PassByMode = Bullet._PassBy.copy;}
        public static implicit operator _ByValue_BtCollisionObject(Const_BtCollisionObject arg) {return new(arg);}
    }

    /// This is used for optional parameters of class `BtCollisionObject` with default arguments.
    /// This is only used mutable parameters. For const ones we have `_InOptConst_BtCollisionObject`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionObject`/`Const_BtCollisionObject` directly.
    public class _InOptMut_BtCollisionObject
    {
        public BtCollisionObject? Opt;

        public _InOptMut_BtCollisionObject() {}
        public _InOptMut_BtCollisionObject(BtCollisionObject value) {Opt = value;}
        public static implicit operator _InOptMut_BtCollisionObject(BtCollisionObject value) {return new(value);}
    }

    /// This is used for optional parameters of class `BtCollisionObject` with default arguments.
    /// This is only used const parameters. For non-const ones we have `_InOptMut_BtCollisionObject`.
    /// Usage:
    /// * Pass `null` to use the default argument.
    /// * Pass `new()` to pass no object.
    /// * Pass an instance of `BtCollisionObject`/`Const_BtCollisionObject` to pass it to the function.
    public class _InOptConst_BtCollisionObject
    {
        public Const_BtCollisionObject? Opt;

        public _InOptConst_BtCollisionObject() {}
        public _InOptConst_BtCollisionObject(Const_BtCollisionObject value) {Opt = value;}
        public static implicit operator _InOptConst_BtCollisionObject(Const_BtCollisionObject value) {return new(value);}
    }
}
