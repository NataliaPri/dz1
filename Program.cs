using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3];

            matrix[0, 0] = 1;
            matrix[1, 1] = 5;
            matrix[2, 2] = 9;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i, j]} ");
                }
                System.Console.WriteLine();
            }


        }
    }
}
