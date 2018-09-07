using System.Collections.Generic;



namespace Andeart.JsonButlerIde.Utilities
{

    internal class TwoWayDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _forward;
        private readonly Dictionary<TValue, TKey> _backward;

        public int Count => _forward.Count;

        public TwoWayDictionary ()
        {
            _forward = new Dictionary<TKey, TValue> ();
            _backward = new Dictionary<TValue, TKey> ();
        }

        public Dictionary<TKey, TValue>.Enumerator GetEnumerator ()
        {
            return _forward.GetEnumerator ();
        }

        public void Add (TKey t1, TValue t2)
        {
            _forward.Add (t1, t2);
            _backward.Add (t2, t1);
        }

        public bool ContainsKey (TKey key)
        {
            return _forward.ContainsKey (key);
        }

        public TValue GetValue (TKey key)
        {
            return _forward[key];
        }

        public bool TryGetValue (TKey key, out TValue value)
        {
            return _forward.TryGetValue (key, out value);
        }

        public bool ContainsValue (TValue value)
        {
            return _backward.ContainsKey (value);
        }

        public TKey GetKey (TValue value)
        {
            return _backward[value];
        }

        public bool TryGetKey (TValue value, out TKey key)
        {
            return _backward.TryGetValue (value, out key);
        }
    }

}