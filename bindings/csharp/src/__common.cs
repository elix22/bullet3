// machine generated, do not edit
public static partial class Bullet
{
    /// This is the base class for all our classes.
    public abstract class Object<T> : Bullet.KeepAliveHolder<T>
    {
        protected bool _IsOwningVal;
        /// Returns true if this is an owning instance, and when disposed, will destroy the underlying C++ instance.
        /// If false, we assume that the underlying C++ instance will live long enough.
        public virtual bool _IsOwning => _IsOwningVal;

        internal Object(bool is_owning) {_IsOwningVal = is_owning;}
    }

    /// This is used for optional in/out parameters, since `ref` can't be nullable.
    public class InOut<T> where T: unmanaged
    {
        public T Value;

        public InOut() {}
        public InOut(T NewValue) {Value = NewValue;}
    }

    /// A reference to a C object. This is sometimes used to return optional references, since `ref` can't be nullable. Or to return references from operators, since those can't return `ref`s.
    /// This object itself isn't nullable, we return `Ref<T>?` when nullability is needed.
    public unsafe class Ref<T> where T: unmanaged
    {
        // Should never be null.
        private T *Ptr;
        // Should never be given a null pointer.
        internal Ref(T *new_ptr)
        {
            System.Diagnostics.Trace.Assert(new_ptr is not null);
            Ptr = new_ptr;
        }
        // 
        internal unsafe Ref(ref T new_ref)
        {
            fixed (T *new_ptr = &new_ref)
            {
                // Smuggling fixed pointers like this seems sketchy at first, but we deal with `ref`s created from pointers all the time, and assume they don't break.
                Ptr = new_ptr;
            }
        }

        public ref T Value => ref *Ptr;

        public static implicit operator T(Ref<T> wrapper) {return wrapper.Value;}
    }

    /// Wraps the object in a wrapper that indicates that it should be treated as a temporary object.
    /// This can be used with `_ByValue_...` function parameters, to indicate that the argument should be moved.
    /// See those structs for a longer explanation.
    public static _Moved<T> Move<T>(T new_value) {return new(new_value);}

    /// A wrapper for `T` that indicates that it's a temporary object, or should be treated as such.
    /// If you're calling a function that returns this, you can safely convert this to `T`.
    /// If you're calling a function that takes this as a parameter, use the `Move()` function to create this wrapper.
    public readonly struct _Moved<T>
    {
        public readonly T Value;
        internal _Moved(T new_value) {Value = new_value;}
        public static implicit operator T(_Moved<T> moved) {return moved.Value;}
    }

    internal enum _PassBy : int
    {
        default_construct,
        copy,
        move,
        move_and_destroy,
        default_arg,
        no_object,
    }

    /// This is the base classes that keep other classes alive.
    /// This is generic to keep static fields separate.
    public abstract class KeepAliveHolder<T>
    {
        /// Which objects need to be kept alive while this object exists?
        Dictionary<string, HashSet<object>>? _KeepAliveData;
        static Dictionary<string, HashSet<object>>? _StaticKeepAliveData;

        /// A special holder for the enclosing object when returning a reference to its subobject.
        public object? _KeepAliveEnclosingObject = null;

        /// Keeps `obj` alive as long as this object exists.
        /// If `key` is specified, it's an optional tag for this object.
        public void _KeepAlive(object obj, string key = "")
        {
            if (_KeepAliveData is null)
                _KeepAliveData = new();
            if (!_KeepAliveData.ContainsKey(key))
                _KeepAliveData[key] = new();
            _KeepAliveData[key].Add(obj);
        }
        public static void _StaticKeepAlive(object obj, string key = "")
        {
            if (_StaticKeepAliveData is null)
                _StaticKeepAliveData = new();
            if (!_StaticKeepAliveData.ContainsKey(key))
                _StaticKeepAliveData[key] = new();
            _StaticKeepAliveData[key].Add(obj);
        }

        /// Discards the objects kept alive by this object.
        /// If `key` is not empty, only discards the objects with the same key. Otherwise discards all of them.
        /// This intentionally doesn't discard `_KeepAliveEnclosingObject`.
        public void _DiscardKeepAlive(string key = "")
        {
            if (_KeepAliveData is null)
                return;
            if (key == "")
            {
                _KeepAliveData.Clear(); // I could also make it null, but I don't think it's worth it.
                return;
            }
            HashSet<object>? set;
            if (_KeepAliveData.TryGetValue(key, out set))
                set.Clear(); // Or we could `.Remove(key)`, but keeping a slot in the map looks better to me.
        }
        public static void _StaticDiscardKeepAlive(string key = "")
        {
            if (_StaticKeepAliveData is null)
                return;
            if (key == "")
            {
                _StaticKeepAliveData.Clear(); // I could also make it null, but I don't think it's worth it.
                return;
            }
            HashSet<object>? set;
            if (_StaticKeepAliveData.TryGetValue(key, out set))
                set.Clear(); // Or we could `.Remove(key)`, but keeping a slot in the map looks better to me.
        }
    }


    public struct ArrayDouble4
    {
        public unsafe fixed double _elem[4];
        public unsafe ref double this[nint i] => ref _elem[i];
    }
}
