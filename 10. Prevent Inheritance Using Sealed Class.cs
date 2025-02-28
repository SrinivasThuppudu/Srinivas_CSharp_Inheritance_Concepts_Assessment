using System;

    // Sealed class
    public sealed class SecuritySystem
    {
        public void AuthenticateUser()
        {
            Console.WriteLine("User authenticated.");
        }
    }

    // // Attempt to derive from sealed class (this will cause a compiler error)
    // public class AdvancedSecuritySystem : SecuritySystem
    // {
    // }