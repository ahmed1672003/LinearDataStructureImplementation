namespace LinearDataStructureImplementation;

internal class Program
{
    static void Main(string[] args)
    {
        Queue<int> queue = new(5);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);
        queue.Display();

    }
}