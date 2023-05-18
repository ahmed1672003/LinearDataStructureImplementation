using System.Collections;

namespace QueueImp;

public class CustomQueue
{
    private int _rear, _front, _count;
    private int[] _items;
    public int Count => _count;
    public CustomQueue(int size)
    {
        _rear = _front = -1;
        _count = 0;
        _items = new int[size];
    }

    private bool IsEmpty() => _front == -1 || _front > _rear;
    private bool IsFull() => _rear == _items.Length - 1;

    public void Enqueue(int item)
    {
        if (IsFull())
        {
            Console.WriteLine(" Queue Over flow !");
            return;
        }
        if (_front.Equals(-1))
            _front++;

        _items[++_rear] = item;
        _count++;
    }

    public int? Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue under flow !");
            return null;
        }

        int item = _items[_front++];

        if (_front > _rear)
            _front = _rear = -1;
        _count--;
        return item;
    }

    public int? Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue under flow !");
            return null;
        }
        return _items[_front];
    }

    public Enumerator GetQueueEnumerator() => GetEnumerator();
    private Enumerator GetEnumerator()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Queue under flow !");
        }

        return new(_items);
    }

    public struct Enumerator : IEnumerator<int>
    {
        private int _position;
        private int[] _items;
        public Enumerator(int[] items)
        {
            _items = items;
            _position = -1;
        }

        public int Current
        {
            get
            {
                return _items[_position];
            }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            _position++;
            return _position <= _items.Length - 1;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
