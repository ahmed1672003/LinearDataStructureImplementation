using System.Collections;

namespace LinearDataStructureImplementation;

public class Stack<Type>
{
    private Type[] _items;
    private int _size;
    private const int DefaultCapacity = 4;
    public Stack()
    {
        _items = new Type[DefaultCapacity];
    }
    public int Count => _size;
    public void Push(Type item)
    {
        if (_size == _items.Length)
            ResizeArray(_items.Length * 2);

        _items[_size++] = item;
    }
    public Type Pop()
    {
        if (_size == 0)
            Console.WriteLine("Stack is empty !");

        Type item = _items[--_size];
        _items[_size] = default(Type)!;

        if (_size > 0 && _size == _items.Length / 4)
            ResizeArray(_items.Length / 2);

        return item;
    }
    public Type Peek()
    {
        if (_size == 0)
            Console.WriteLine("Stack is empty !");

        return _items[_size - 1];
    }

    public bool Contains(Type value)
    {
        if (_items.Contains(value))
            return true;

        return false;
    }
    private void ResizeArray(int newSize)
    {
        Type[] newArray = new Type[newSize];

        for (int i = 0 ; i < _size ; i++)
        {
            newArray[i] = _items[i];
        }
        _items = newArray;
    }

    private void TrimExcess()
    {

    }
    public Enumerator GetStackEnumerator()
    {
        return GetEnumerator();
    }
    Enumerator GetEnumerator()
    {
        if (this._items == null)
        {
            throw new InvalidOperationException("Stack cannot be changed during iteration.");
        }
        return new Enumerator(_items);
    }
    public struct Enumerator : IEnumerator<Type>
    {
        Type[] _items;

        int position;

        public Enumerator(Type[] items)
        {
            _items = items;
            position = _items.Length;
        }
        public Type Current
        {
            get
            {
                try
                {
                    return _items[position];
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    return default(Type)!;
                }
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position--;
            return position >= 0;
        }
        public void Reset()
        {
            position = -1;
        }
    }
}


