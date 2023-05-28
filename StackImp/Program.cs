namespace LinearDataStructureImplementation;

internal class Program
{
    static void Main(string[] args)
    {
        Stack<int> numbers = new();
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        numbers.Push(4);
        numbers.Push(5);
        numbers.Push(6);
        numbers.Push(7);
        Console.WriteLine(numbers.Pop());
        Console.WriteLine(numbers.Pop());
        Console.WriteLine(numbers.Pop());
        Console.WriteLine(numbers.Pop());
        Console.WriteLine(numbers.Pop());
        Console.WriteLine(numbers.Pop());
        Console.WriteLine(numbers.Pop());

    }
}