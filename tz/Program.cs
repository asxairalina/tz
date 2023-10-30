using tz.Class;
Transport Transport = new Transport();
Transport Boat = new Boat();
Transport Car = new Car();
Transport Bicycle = new Bicycle();
Transport Motrcycle = new Motrcycle();
Transport Scooter = new Scooter();

Console.WriteLine(Boat);
Console.WriteLine(Car);
Console.WriteLine(Bicycle);
Console.WriteLine(Motrcycle);
Console.WriteLine(Scooter);

List<Transport> lst = new List<Transport>();
lst.Add(new Boat());
lst.Add(new Car());
lst.Add(new Bicycle());
lst.Add(new Motrcycle());
lst.Add(new Scooter());

abstract class Transport
{

    public string Color { get; set; }
    public string Category { get; set; }
    public bool Rent { get; set; }
    public int Wheels { get; set; }
    public string Motor { get; set; }
    public string Inventor { get; set; }
    public int Age { get; set; }

    protected virtual string Model { get; set; }

    public virtual string MakeSound()
    {
        return "Transport makes a sound";
    }


    public void Speed()
    {
        Console.WriteLine($"Мотор: {Motor} для данного вида транспорта");
    }

    public Transport()
    {
        Inventor = "Unknown";
        Age = 2;
    }


}
