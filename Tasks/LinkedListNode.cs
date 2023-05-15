namespace LinearDataStructureImplementation;

public class LinkedListNode<TData>
{
    public TData Value { get; set; }
    public LinkedListNode<TData> Next { get; set; }

    public LinkedListNode(TData value)
    {
        Value = value;
        Next = null;
    }
}