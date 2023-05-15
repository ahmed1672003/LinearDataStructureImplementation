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
}