using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите случайное число:");
                int testNumber = Convert.ToInt32(Console.ReadLine());
                if (testNumber > 7)
                {
                    Console.WriteLine("Привет");
                }
                Console.Read();
        }
    }
}
