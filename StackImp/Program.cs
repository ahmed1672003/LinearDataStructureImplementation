using StackImp;

namespace LinearDataStructureImplementation;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter text: ");
        Console.WriteLine();
        if (Console.ReadLine().IsBalanced())
            Console.WriteLine(" text is balanced !");
        else
            Console.WriteLine("text is not balanced !");


    }
}