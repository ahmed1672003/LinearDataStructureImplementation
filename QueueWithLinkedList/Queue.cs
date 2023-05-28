namespace QueueWithLinkedList;

public class Queue<T>
{
    private LinkedList<T> _linkedList = new();
    public int Count => _linkedList.Count;
    public void Enqueue(T value) =>
        _linkedList.AddLast(value);
    public T Peek()
    {
        if (!(_linkedList.Count > 0))
        {
            Console.WriteLine("Queue is Empty !");
            return default;
        }
        return _linkedList.First.Value;
    }
    public T Dequeue()
    {
        if (!(_linkedList.Count > 0))
        {
            Console.WriteLine("Queue is Empty !");
            return default;
        }

        T value = _linkedList.First.Value;

        _linkedList.RemoveFirst();
        return value;
    }
    public void Display()
    {
        var enumerator = _linkedList.GetEnumerator();
        while (enumerator.MoveNext())
            Console.WriteLine(enumerator.Current);
    }
    public void Clear() => _linkedList.Clear();
}
