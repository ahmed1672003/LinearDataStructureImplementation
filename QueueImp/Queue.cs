namespace LinearDataStructureImplementation;

#region MyRegion
//public class Queue<T>
//{
//    private T[] _items;
//    private int _head;
//    private int _tail;
//    private int _count;
//    private const int DefaultCapacity = 4;

//    public Queue()
//    {
//        _items = new T[DefaultCapacity];
//        _head = 0;
//        _tail = 0;
//        _count = 0;
//    }

//    public int Count => _count;

//    public void Enqueue(T item)
//    {
//        if (_count == _items.Length)
//        {
//            ResizeArray(_items.Length + 1);
//        }

//        _items[_tail++] = item;
//        _count++;

//        if (_tail == _items.Length)
//        {
//            _tail = 0;
//        }
//    }

//    public T Dequeue()
//    {
//        if (_count == 0)
//        {
//            Console.WriteLine("Queue is empty");
//            return default!;
//        }

//        T item = _items[_head];
//        _items[_head] = default!;
//        _head++;
//        _count--;

//        if (_head == _items.Length)
//        {
//            _head = 0;
//        }

//        if (_count > 0 && _count == _items.Length / 4)
//        {
//            ResizeArray(_items.Length / 2);
//        }

//        return item;
//    }

//    public T Peek()
//    {
//        if (_count == 0)
//        {
//            throw new InvalidOperationException("Queue is empty");
//        }

//        return _items[_head];
//    }

//    private void ResizeArray(int newSize)
//    {
//        T[] newArray = new T[newSize];

//        if (_count > 0)
//        {
//            if (_head < _tail)
//            {
//                Array.Copy
//                    (_items,
//                    _head,
//                    newArray,
//                    0,
//                    _count);
//            }
//            else
//            {
//                Array.Copy(
//                    _items,
//                    _head,
//                    newArray,
//                    0,
//                    _items.Length - _head);

//                Array.Copy(_items,
//                    0,
//                    newArray,
//                    _items.Length - _head,
//                    _tail);
//            }
//        }

//        _items = newArray;
//        _head = 0;
//        _tail = (_count == newSize) ? 0 : _count;
//    }
//} 
#endregion

public class Queue<T>
{
    T[] queue;
    static int Max;
    int _rear, _front, _size;
    public int Count => _size;
    public Queue(int max)
    {
        Max = max;
        _rear = _front = -1;
        _size = 0;
        queue = new T[Max];
    }
    public bool IsEmpty() => _front == -1 || _front > _rear;
    public bool IsFull() => _rear == queue.Length - 1;
    public void Enqueue(T value)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue over flow !");
            return;
        }

        if (_front == -1)
            _front++;

        queue[++_rear] = value;
        _size++;
    }
    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue under flow !");
            return default;
        }
        return queue[_front];
    }
    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue under flow !");
            return default;
        }
        _size--;
        return queue[_front++];
    }
    public void Display()
    {
        for (int i = 0 ; i < queue.Length ; i++)
            Console.WriteLine(queue[]);

    }
}