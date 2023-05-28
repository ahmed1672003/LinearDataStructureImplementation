namespace QueueWithLinkedList;

public class Car
{
    public int Id { get; set; }
    public int Number { get; set; }
    public string Letters { get; set; }
    public string Plate
    {
        get { return $"[{Number} - {Letters}]"; }
    }

    public override string? ToString()
    {
        return $"id: {Id} , plate: {Plate}";
    }
}
