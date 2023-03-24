using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размер числового массива:");
            int arrayLenght = Convert.ToInt32(Console.ReadLine());
            int[] testArray = new int[arrayLenght];
            for(int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент массива:");
                testArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i] % 3 == 0)
                {
                    Console.WriteLine(testArray[i]);
                }
            }
            Console.Read();
        }
    }
}
