using System;

namespace Uni_Lesson1
{
    internal static class ArithmeticOperationsDemo
    {
        internal static void Run()
        {
            // 2. ARITHMETIC OPERATIONS
            Console.WriteLine("--- 2. Arithmetic Operations ---");
            int a = 10;
            int b = 3;

            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            Console.WriteLine($"Division: {a} / {b} = {a / b}"); // Integer division
            Console.WriteLine($"Division (decimal): {a} / {b} = {(double)a / b}");
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}\n");
        }
    }
}

