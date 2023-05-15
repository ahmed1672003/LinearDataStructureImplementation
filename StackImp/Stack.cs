namespace StackImp
{
    public class Stack<T>
    {
        private T[] _items;
        private int _size;
        private const int DefaultCapacity = 4;

        public Stack()
        {
            _items = new T[DefaultCapacity];
        }

        public int Count => _size;

        public void Push(T item)
        {
            if (_size == _items.Length)
            {
                ResizeArray(_items.Length * 2);
            }

            _items[_size++] = item;
        }

        public T Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = _items[--_size];
            _items[_size] = default(T);

            if (_size > 0 && _size == _items.Length / 4)
            {
                ResizeArray(_items.Length / 2);
            }

            return item;
        }

        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _items[_size - 1];
        }

        private void ResizeArray(int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0 ; i < _size ; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
        }
    }

}