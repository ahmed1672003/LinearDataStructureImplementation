namespace QueueImp
{
    public class Queue<T>
    {
        private T[] _items;
        private int _head;
        private int _tail;
        private int _count;
        private const int DefaultCapacity = 4;

        public Queue()
        {
            _items = new T[DefaultCapacity];
            _head = 0;
            _tail = 0;
            _count = 0;
        }

        public int Count => _count;

        public void Enqueue(T item)
        {
            if (_count == _items.Length)
            {
                ResizeArray(_items.Length * 2);
            }

            _items[_tail++] = item;
            _count++;

            if (_tail == _items.Length)
            {
                _tail = 0;
            }
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = _items[_head];
            _items[_head] = default(T);
            _head++;
            _count--;

            if (_head == _items.Length)
            {
                _head = 0;
            }

            if (_count > 0 && _count == _items.Length / 4)
            {
                ResizeArray(_items.Length / 2);
            }

            return item;
        }

        public T Peek()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _items[_head];
        }

        private void ResizeArray(int newSize)
        {
            T[] newArray = new T[newSize];

            if (_count > 0)
            {
                if (_head < _tail)
                {
                    Array.Copy(_items, _head, newArray, 0, _count);
                }
                else
                {
                    Array.Copy(_items, _head, newArray, 0, _items.Length - _head);
                    Array.Copy(_items, 0, newArray, _items.Length - _head, _tail);
                }
            }

            _items = newArray;
            _head = 0;
            _tail = (_count == newSize) ? 0 : _count;
        }
    }

}