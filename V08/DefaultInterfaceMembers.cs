interface IThing
{
    string Name { get; set; }
    int ProductionYear { get; set; }
    // int GetAge();
}

public class Thing : IThing
{
    public Thing(string name, int year)
    {
        Name = name;
        ProductionYear = year;
    }

    public string Name { get; set; }
    public int ProductionYear { get; set; }
}