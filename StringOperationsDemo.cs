using System;

namespace Uni_Lesson1
{
    internal static class StringOperationsDemo
    {
        internal static void Run()
        {
            // 3. STRING OPERATIONS
            Console.WriteLine("--- 3. String Operations ---");
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName; // Concatenation

            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Length: {fullName.Length}");
            Console.WriteLine($"Uppercase: {fullName.ToUpper()}");
            Console.WriteLine($"Lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Contains 'John': {fullName.Contains("John")}\n");
        }
    }
}

