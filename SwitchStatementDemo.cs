using System;

namespace Uni_Lesson1
{
    internal static class SwitchStatementDemo
    {
        internal static void Run()
        {
            // 5. SWITCH STATEMENT
            Console.WriteLine("--- 5. Switch Statement ---");
            int dayNumber = 3;
            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day";
                    break;
            }
            Console.WriteLine($"Day {dayNumber}: {dayName}\n");
        }
    }
}

