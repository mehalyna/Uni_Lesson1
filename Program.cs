namespace Uni_Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LESSON 1: C# Basics ===\n");

            VariablesAndDataTypesDemo.Run();
            ArithmeticOperationsDemo.Run();
            StringOperationsDemo.Run();
            ConditionalStatementsDemo.Run();
            SwitchStatementDemo.Run();
            LoopsDemo.Run();
            ArraysDemo.Run();
            UserInputDemo.Run();
            TypeConversionDemo.Run();

            SayHello("Group 302");

            Console.ReadKey();
        }

        // Method that doesn't return a value
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // Method that returns a value
        static int Add(int x, int y)
        {
            return x + y;
        }

        // Method with calculation
        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
