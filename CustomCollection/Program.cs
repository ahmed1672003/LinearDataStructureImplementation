using System.Collections;

namespace CustomCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new();
        }
    }
}

public class Employees : CollectionBase
{

    public Employee this[int index]
    {
        get { return (this.List[index] as Employee)!; }

        set { this.List[index] = value; }
    }
    public int IndexOf(Employee item)

    {

        return base.List.IndexOf(item);

    }
    public int Add(Employee item)

    {

        return this.List.Add(item);

    }



    public void Remove(Employee item)

    {

        this.InnerList.Remove(item);

    }
    public void CopyTo(Array array, int index)

    {
        this.List.CopyTo(array, index);
    }
    public void AddRange(Employees collection)

    {
        for (int i = 0 ; i < collection.Count ; i++)

        {
            this.List.Add(collection[i]);
        }
    }
    public void AddRange(Employee[] collection)
    {
        this.AddRange(collection);
    }
    public bool Contains(Employee item)
    {

        return this.List.Contains(item);
    }
    public void Insert(int index, Employee item)
    {
        this.List.Insert(index, item);
    }
}