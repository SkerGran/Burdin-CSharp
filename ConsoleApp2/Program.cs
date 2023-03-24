using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите случайное имя:");
            string testName = Console.ReadLine();
            if (testName == "Вячеслав")
            {
                Console.WriteLine("Привет, Вячеслав");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
            Console.Read();
        }
    }
}
