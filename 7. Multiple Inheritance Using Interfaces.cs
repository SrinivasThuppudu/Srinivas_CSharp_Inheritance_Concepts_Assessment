using System;

public interface IFlyable
{
    void Fly();
}

public interface ISwimmable
{
    void Swim();
}

public class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("The duck is flying.");
    }

    public void Swim()
    {
        Console.WriteLine("The duck is swimming.");
    }
}

