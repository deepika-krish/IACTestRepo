using System;

namespace IACTestRepo
{
    class ConsoleSub
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Subtraction Calculator");
            Console.WriteLine("==================");
            
            // Get first number from user
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            
            // Get second number from user
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            
            try
            {
                // Convert inputs to double for decimal support
                double num1 = Convert.ToDouble(input1);
                double num2 = Convert.ToDouble(input2);
                
                // Calculate the sum
                double result = num1 + num2;
                
                // Display the result
                Console.WriteLine($"\nResult: {num1} - {num2} = {result}");
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