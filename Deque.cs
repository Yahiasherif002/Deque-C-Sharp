using System.Collections;

internal partial class Program
{
    class Deque<T>:IEnumerable<T>
    {
        private LinkedList<T> _items = new LinkedList<T>();

        public void Add(params T[] values)
        {
            foreach (T value in values)
            {
                _items.AddLast(value);
            }
        }
        public void AddFront(T item)
        {
            _items.AddFirst(item);
        }
        public void AddRear(T item)
        {
            _items.AddLast(item);
        }
        public T RemoveFront()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The deque is empty");
            }
            T value = _items.First.Value;
            _items.RemoveFirst();
            return value;
        }
        public T RemoveRear()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The deque is empty");
            }
            T value = _items.Last.Value;
            _items.RemoveLast();
            return value;
        }
        public T PeekFront()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The deque is empty");
            }
            return _items.First.Value;
        }
        public T PeekRear()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The deque is empty");
            }
            return _items.Last.Value;
        }

        public void Clear()
        {
            _items.Clear();
        }
        public int count =>_items.Count;

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in _items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator<T>)GetEnumerator();


    }
}