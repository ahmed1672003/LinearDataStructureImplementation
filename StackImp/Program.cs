namespace LinearDataStructureImplementation;

internal class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        var enumera = stack.GetStackEnumerator();

        while (enumera.MoveNext())
        {
            Console.WriteLine(enumera.Current);
        }

    }
}