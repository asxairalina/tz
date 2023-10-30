using tz.Class;

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
    public string Model { get; set; }
    public string Category { get; set; }
    public bool Rent { get; set; }
    public int Wheels { get; set; }
    public string Motor { get; set; }


    public abstract void Speed();

}


public virtual void Speed()
{
    Console.WriteLine($"{Motor} - влияет на скорость");
}