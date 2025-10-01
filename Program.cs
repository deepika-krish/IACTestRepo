using System;

namespace IACTestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleAdd calculator = new ConsoleAdd();
            double addResult = calculator.Add(11.5, 6.3);
            Console.WriteLine($"Direct calculation: 11.5 + 6.3 = {addResult}");

            ConsoleSub calculatorSub = new ConsoleSub();
            double subResult = calculatorSub.Subtract(11.5, 6.3);
            Console.WriteLine($"Direct calculation: 11.5 - 6.3 = {subResult}");

            ConsoleMul calculatorMul = new ConsoleMul();
            double mulResult = calculatorMul.Multiply(10.5, 5.3);
            Console.WriteLine($"Direct calculation: 10.5 * 5.3 = {mulResult}");

            ConsoleDiv calculatorDiv = new ConsoleDiv();
            double divResult = calculatorDiv.Divide(10.5, 5.3);
            Console.WriteLine($"Direct calculation: 10.5 / 5.3 = {divResult}");
            
        }
    }
}