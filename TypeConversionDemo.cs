using System;

namespace Uni_Lesson1
{
    internal static class TypeConversionDemo
    {
        internal static void Run()
        {
            // 9. TYPE CONVERSION
            Console.WriteLine("--- 9. Type Conversion ---");
            string numberString = "123";
            int convertedNumber = int.Parse(numberString);
            Console.WriteLine($"String to int: '{numberString}' -> {convertedNumber}");

            double pi = 3.14159;
            int piInt = (int)pi; // Explicit casting
            Console.WriteLine($"Double to int: {pi} -> {piInt}");

            int wholeNumber = 42;
            string numberAsString = wholeNumber.ToString();
            Console.WriteLine($"Int to string: {wholeNumber} -> '{numberAsString}'\n");
        }
    }
}

