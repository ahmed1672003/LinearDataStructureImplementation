using QueueImp;

namespace LinearDataStructureImplementation;

internal class Program
{
    static void Main(string[] args)
    {
        CustomQueue queue = new(3);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        var enumerator = queue.GetQueueEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }


    }
}