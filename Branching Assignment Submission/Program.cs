using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title banner
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================================");
            Console.WriteLine("   Welcome to Package Express Shipping Quote   ");
            Console.WriteLine("===============================================");
            Console.ResetColor();

            Console.WriteLine("Please follow the instructions below.\n");

            // --- Get Package Weight ---
            decimal weight = GetDecimalInput("Please enter the package weight (lbs): ");
            if (weight > 50)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good day!");
                Console.ResetColor();
                return;
            }

            // --- Get Dimensions ---
            decimal width = GetDecimalInput("Please enter the package width (inches): ");
            decimal height = GetDecimalInput("Please enter the package height (inches): ");
            decimal length = GetDecimalInput("Please enter the package length (inches): ");

            // --- Check Total Size ---
            decimal dimensionTotal = width + height + length;
            if (dimensionTotal > 50)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                Console.ResetColor();
                return;
            }

            // --- Calculate Quote ---
            decimal quote = (width * height * length * weight) / 100;

            // --- Display Result ---
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYour estimated total for shipping this package is: {quote:C}");
            Console.ResetColor();
            Console.WriteLine("Thank you for choosing Package Express!");
        }

        /// <summary>
        /// Prompts the user for a decimal input and validates it.
        /// Keeps asking until a valid decimal is entered.
        /// </summary>
        static decimal GetDecimalInput(string prompt)
        {
            decimal value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out value) && value > 0)
                {
                    return value;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Invalid entry. Please enter a positive numeric value.\n");
                Console.ResetColor();
            }
        }
    }
}
