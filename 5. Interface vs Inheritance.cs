using System;

public interface IMovable
{
    void Move();
}

public class Machine
{
    public void Start()
    {
        Console.WriteLine("Machine starting...");
    }
}

public class Robot : Machine, IMovable
{
    public void Move()
    {
        Console.WriteLine("Robot moving...");
    }
}

