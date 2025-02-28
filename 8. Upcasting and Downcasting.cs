using System;

public class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }

    public void DisplayInfo()
    {                    
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student : Person
{
    public int StudentID { get; set; }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}");
    }
}
