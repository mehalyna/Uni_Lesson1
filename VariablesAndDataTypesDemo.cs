using System;

namespace Uni_Lesson1
{
    internal static class VariablesAndDataTypesDemo
    {
        internal static void Run()
        {
            // 1. VARIABLES AND DATA TYPES
            Console.WriteLine("--- 1. Variables and Data Types ---");

            // Integer types
            int age = 25;
            long population = 8000000000L;

            // Floating-point types
            double price = 19.99;
            float temperature = 36.6f;
            decimal bankBalance = 1500.50m; // Use for financial calculations

            // Character and string types
            char grade = 'A';
            string name = "Alice";

            // Boolean type
            bool isStudent = true;

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
            Console.WriteLine($"Price: ${price}, Balance: ${bankBalance}");
            Console.WriteLine($"Is Student: {isStudent}\n");
        }
    }
}

