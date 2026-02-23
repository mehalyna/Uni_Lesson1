using System;

namespace Uni_Lesson1
{
    internal static class UserInputDemo
    {
        internal static void Run()
        {
            // 8. USER INPUT
            Console.WriteLine("--- 8. User Input ---");
            Console.Write("Enter your name: ");
            string? userName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string? ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int userAge))
            {
                Console.WriteLine($"Hello, {userName}! You are {userAge} years old.");
                Console.WriteLine($"In 10 years, you will be {userAge + 10} years old.\n");
            }
            else
            {
                Console.WriteLine("Invalid age input.\n");
            }
        }
    }
}

