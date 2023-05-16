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

    private void ResizeArray(int newSize)
    {
        Type[] newArray = new Type[newSize];

        for (int i = 0 ; i < _size ; i++)
        {
            newArray[i] = _items[i];
        }

        _items = newArray;
    }
    public void Display()
    {
        for (int i = 0 ; i < _items.Length ; i++)
            Console.WriteLine(_items[i]);
    }
}