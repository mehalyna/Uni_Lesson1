using System;

namespace Uni_Lesson1
{
    internal static class ConditionalStatementsDemo
    {
        internal static void Run()
        {
            // 4. CONDITIONAL STATEMENTS
            Console.WriteLine("--- 4. Conditional Statements (if-else) ---");
            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            // Ternary operator
            string result = score >= 60 ? "Pass" : "Fail";
            Console.WriteLine($"Result: {result}\n");
        }
    }
}

