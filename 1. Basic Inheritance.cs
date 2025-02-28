using System;

class Vehicle
{
    public string Brand { get; set; } = string.Empty;
    public int Speed { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed}KM/H");
    }
}

class Car : Vehicle
{
}

class Bike : Vehicle
{
}

