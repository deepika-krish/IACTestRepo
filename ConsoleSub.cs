using System;

namespace IACTestRepo
{
    class ConsoleSub
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Subtraction Calculator\n======================");
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            
            try
            {
                double num1 = Convert.ToDouble(input1);
                double num2 = Convert.ToDouble(input2);
                Console.WriteLine($"\nResult: {num1} - {num2} = {num1 - num2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}