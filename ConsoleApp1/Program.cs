using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("введите число А");
            string nomberA = Console.ReadLine();
            int operand1 = Convert.ToInt32(nomberA);
            Console.WriteLine("введите число B");
            string nomberB = Console.ReadLine();
            int operand2 = Convert.ToInt32(nomberB);
            Console.WriteLine("результат");
            int calculationResult = (operand1 * 5 + operand2 * operand2) / (operand2 - operand1);
            Console.WriteLine(calculationResult);
        }
    }
}