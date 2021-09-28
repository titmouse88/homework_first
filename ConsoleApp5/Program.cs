using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите координату Х1");
            string nomberA = Console.ReadLine();
            int coordX1 = Convert.ToInt32(nomberA);
            Console.WriteLine("введите координату Х2");
            string nomberB = Console.ReadLine();
            int coordX2 = Convert.ToInt32(nomberB);
            Console.WriteLine("введите координату Y1");
            string nomberC = Console.ReadLine();
            int coordY1 = Convert.ToInt32(nomberC);
            Console.WriteLine("введите координату Y2");
            string nomberD = Console.ReadLine();
            int coordY2 = Convert.ToInt32(nomberD);
             Console.WriteLine("функция с такими координатами имеет формулу");
            int calculationResult1 = (coordY2 - coordY1) / (coordX2 - coordX1);
            int calcu = (coordY2 - coordY1) / (coordX2 - coordX1);
            int calculationResult2 = (coordY1 - calcu * coordX1);

            Console.WriteLine("y=" + calculationResult1+ "*x+" +calculationResult2);
        }
    }
}
