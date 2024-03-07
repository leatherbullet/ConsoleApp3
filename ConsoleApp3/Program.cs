using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int maxElement = int.MinValue;

            int minValue = 0;
            int maxValue = 10;

            int[,] array = new int[10, 10];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue,maxValue);

                    Console.Write(array[i, j] + " ");

                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("максимальный элемент " + maxElement);

            for (int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0;j < array.GetLength(1); j++)
                {
                    if(array[i, j] == maxElement)
                    {
                        array[i,j] = 0;
                    }

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
