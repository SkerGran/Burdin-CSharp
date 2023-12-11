using System;

namespace ConsoleApp3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размер числового массива:");
            int arrayLenght = GetNumber();
            int[] testArray = new int[arrayLenght];

            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент массива:");
                testArray[i] = GetNumber();
            }

            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i] % 3 == 0)
                {
                    Console.WriteLine(testArray[i]);
                }
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
