using System;

namespace IACTestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleAdd calculator = new ConsoleAdd();
            double addResult = calculator.Add(23.5, 6.3);
            Console.WriteLine($"Direct calculation: 23.5 + 6.3 = {addResult}");

            ConsoleSub calculatorSub = new ConsoleSub();
            double subResult = calculatorSub.Subtract(23.5, 6.3);
            Console.WriteLine($"Direct calculation: 23.5 - 6.3 = {subResult}");

            ConsoleMul calculatorMul = new ConsoleMul();
            double mulResult = calculatorMul.Multiply(23.5, 6.3);
            Console.WriteLine($"Direct calculation: 23.5 * 6.3 = {mulResult}");
            
            ConsoleDiv calculatorDiv = new ConsoleDiv();
            double divResult = calculatorDiv.Divide(23.5, 6.3);
            Console.WriteLine($"Direct calculation: 23.5 / 6.3 = {divResult}");

        }
    }
}