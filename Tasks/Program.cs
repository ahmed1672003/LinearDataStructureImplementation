namespace LinearDataStructureImplementation;
internal class Program
{
    static void Main(string[] args)
    {
        LinkedList<Student> list = new();

        Student student0 = new() { Id = 1, Name = "Ahmed" };
        Student student1 = new() { Id = 1, Name = "Ahmed" };
        list.AddLast(student1);
        Console.WriteLine(list.Contains(student0));
    }
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public override bool Equals(object? obj)
    {
        return this.Id == (obj as Student)!.Id;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override string ToString()
    {
        return $"id: {Id} , name: {Name}";
    }
}