using System;

namespace ConsoleApp
{
    // Define a class named 'MathOperations'
    class MathOperations
    {
        // Create a method named 'PerformOperation' that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // The first line of the method does a math operation on num1. 
            // For this example, let's square the first number.
            int result = num1 * num1;

            // Print out the result of the operation on num1
            Console.WriteLine($"The result of squaring {num1} is: {result}");

            // Print out the second number num2 to the screen
            Console.WriteLine($"The second integer is: {num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an object of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method with two numbers (e.g., 5 and 3)
            // This will pass the numbers to the method where num1 will be squared, and num2 will be displayed.
            mathOps.PerformOperation(5, 3);

            // Call the PerformOperation method again, but this time specify the parameters by name.
            // This is useful to show how named arguments can improve readability and prevent errors with parameter order.
            mathOps.PerformOperation(num1: 8, num2: 10);

            // To ensure the console window stays open after execution
            Console.ReadLine();
        }
    }
}
