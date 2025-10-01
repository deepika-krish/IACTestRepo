using System;

namespace IACTestRepo
{
    class ConsoleDiv
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division Calculator\n===================");
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            
            try
            {
                double num1 = Convert.ToDouble(input1);
                double num2 = Convert.ToDouble(input2);
                
                if (num2 == 0)
                {
                    Console.WriteLine("\nError: Division by zero is not allowed.");
                }
                else
                {
                    Console.WriteLine($"\nResult: {num1} / {num2} = {num1 / num2}");
                }
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