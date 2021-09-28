using System;

namespace ConsoleApp3
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
            Console.WriteLine("целая часть");
            int calculationResult = (operand1) / (operand2);
            Console.WriteLine(calculationResult);
            Console.WriteLine("остаток");
            int calculationResult2 = (operand1) % (operand2);
            Console.WriteLine(calculationResult2);
        }
    }
}
