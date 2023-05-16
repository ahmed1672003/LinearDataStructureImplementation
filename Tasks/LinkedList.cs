namespace LinearDataStructureImplementation;

public class LinkedList<TData>
{
    public LinkedListNode<TData> Head { get; set; }
    public int Count { get; set; }
    public LinkedList()
    {
        Head = null;
        Count = 0;
    }
    public void AddFirst(TData value)
    {
        LinkedListNode<TData> node = new(value);
        node.Next = Head;
        Head = node;
        Count++;
    }
    public void AddLast(TData value)
    {
        LinkedListNode<TData> node = new(value);

        if (Head == null)
        {
            Head = node;
        }
        else
        {
            LinkedListNode<TData> current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
        }

        Count++;
    }
    public void RemoveFirst()
    {
        if (Head != null)
        {
            Head = Head.Next;
            Count--;
        }
    }
    public void RemoveLast()
    {
        if (Head == null)
        {
            return;
        }

        if (Head.Next == null)
        {
            Head = null;
            Count--;
            return;
        }

        LinkedListNode<TData> current = Head;

        while (current.Next.Next != null)
        {
            current = current.Next;
        }

        current.Next = null;
        Count--;
    }
    public bool Contains(TData value)
    {
        LinkedListNode<TData> current = Head;

        while (current != null)
        {
            if (current.Value.Equals(value))
            {
                return true;
            }

            current = current.Next;
        }
        return false;
    }
    public void Print()
    {
        LinkedListNode<TData> current = Head;
        while (current is not null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
    public void Remove(TData data)
    {
        if (Head is null)
        {
            Console.WriteLine("linked list is empty !");
            return;
        }

        if (!Contains(data))
        {
            Console.WriteLine("data is not found !");
            return;
        }

        if (Head.Value!.Equals(data))
        {
            Head = Head.Next;
            return;
        }

        LinkedListNode<TData> current = Head;
        LinkedListNode<TData> target = null!;

        while (current!.Next!.Next is not null)
        {
            if (current.Next.Value!.Equals(data))
            {
                if (current.Next.Value!.Equals(data))
                {
                    target = current.Next.Next;
                    current.Next = null!;
                    break;
                }
            }
            current = current.Next;
        }

        current.Next = target!;
        Count--;
    }
}