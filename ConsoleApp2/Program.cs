using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое слово");
            string word1 = Console.ReadLine();
            Console.WriteLine("введите первое слово");
            string word2 = Console.ReadLine();
            string word3 = word1;
            word1 = word2;
            word2 = word3;

            Console.WriteLine("немного магии");
            Console.WriteLine(word1 + "  " + word2);
        }
    }
}
