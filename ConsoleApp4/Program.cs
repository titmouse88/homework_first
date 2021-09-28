using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число А");
            string nomberA = Console.ReadLine();
            float operand1 = Convert.ToInt32(nomberA);
            Console.WriteLine("введите число B");
            string nomberB = Console.ReadLine();
            float operand2 = Convert.ToInt32(nomberB);
            Console.WriteLine("введите число С");
            string nomberC = Console.ReadLine();
            float operand3 = Convert.ToInt32(nomberC);
            Console.WriteLine("результат");
            float calculationResult = (operand3 - operand2) / ( operand1);
            Console.WriteLine(calculationResult);
            if (float.IsInfinity(calculationResult))
                Console.WriteLine("деление на ноль! введите числа не равные 0");
        }
    }
}
