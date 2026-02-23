using System;

namespace Uni_Lesson1
{
    internal static class LoopsDemo
    {
        internal static void Run()
        {
            // 6. LOOPS
            Console.WriteLine("--- 6. Loops ---");

            // For loop
            Console.Write("For loop (1-5): ");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // While loop
            Console.Write("While loop (countdown from 5): ");
            int counter = 5;
            while (counter > 0)
            {
                Console.Write($"{counter} ");
                counter--;
            }
            Console.WriteLine();

            // Do-while loop
            Console.Write("Do-while loop: ");
            int num = 1;
            do
            {
                Console.Write($"{num} ");
                num++;
            } while (num <= 3);
            Console.WriteLine("\n");
        }
    }
}

