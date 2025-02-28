using System;

public class Vehicle1
{
    public string Brand1 { get; set; } = string.Empty;
    public int Speed1 { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand1}, Speed: {Speed1}KM/H");
    }
}

public class Car1 : Vehicle1
{
    public int NumberOfDoors { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
}

public class Bike1 : Vehicle1
{
    public string Fuel_type { get; set; } = string.Empty;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Type: {Fuel_type}");
    }
}
