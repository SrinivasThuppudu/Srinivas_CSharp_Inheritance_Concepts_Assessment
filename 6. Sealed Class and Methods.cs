using System;

public class Account
{
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Calculating interest in Account class (P - (P * (1 + R/100) ^ N))");
    }
}

public class SavingsAccount : Account
{
    public sealed override void CalculateInterest()
    {
        base.CalculateInterest();
        Console.WriteLine("Calculating interest in SavingsAccount class (P * T * R) / 100");
    }
}