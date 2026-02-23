using System;

namespace Uni_Lesson1
{
    internal static class ArraysDemo
    {
        internal static void Run()
        {
            // 7. ARRAYS
            Console.WriteLine("--- 7. Arrays ---");
            int[] numbers = { 10, 20, 30, 40, 50 };
            string[] fruits = new string[3] { "Apple", "Banana", "Orange" };

            Console.WriteLine($"First number: {numbers[0]}");
            Console.WriteLine($"Array length: {numbers.Length}");

            Console.Write("All numbers: ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            Console.Write("All fruits: ");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write($"{fruits[i]} ");
            }
            Console.WriteLine("\n");
        }
    }
}

