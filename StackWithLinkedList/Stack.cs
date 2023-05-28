﻿namespace StackWithLinkedList;

public class Stack<T>
{
    private LinkedList<T> _linkedList = new();
    public void Push(T value) => _linkedList.AddFirst(value);
    public T Peek()
    {
        if (!(_linkedList.Count > 0))
        {
            Console.WriteLine("Stack is Empty !");
            return default;
        }

        return _linkedList.First.Value;
    }
    public T Pop()
    {
        if (!(_linkedList.Count > 0))
        {
            Console.WriteLine("Stack is Empty !");
            return default;
        }
        T value = _linkedList.First.Value;
        _linkedList.RemoveFirst();
        return value;
    }
    public void Display()
    {
        if (!(_linkedList.Count > 0))
        {
            Console.WriteLine("Stack is Empty !");
            return;
        }
        var enumerator = _linkedList.GetEnumerator();
        while (enumerator.MoveNext())
            Console.WriteLine(enumerator.Current);
    }
    public void Clear() => _linkedList.Clear();
}
