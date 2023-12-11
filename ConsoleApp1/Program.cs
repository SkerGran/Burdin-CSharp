using System;

namespace ConsoleApp1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите случайное число:");
            int input = GetNumber();
            if (input > 7)
            {
                Console.WriteLine("Привет");
            }
            int GetNumber()
            {
                int checkedNumber;
                while (true)
                {
                    string input = Console.ReadLine();
                    bool result = int.TryParse(input, out checkedNumber);
                    if (result)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введено не число, повторите ввод.");
                    }
                }
                return checkedNumber;
            }
        }
    }
}
