using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name1 = ("Маша");
            string Name2 = ("Вика");
            string Name3 = ("Соня");
            string Name4 = ("Вова");
            string Name5 = ("Саша");

            string number1 = ("83049273386");
            string number2 = ("80239477019");
            string number3 = ("80651002932");
            string mail4 = ("green@mail.ru");
            string mail5 = ("sky@mail.ru");

            string[,] matrix = new string[5, 2];
            matrix[0, 0] = Name1;
            matrix[1, 0] = Name2;
            matrix[2, 0] = Name3;
            matrix[3, 0] = Name4;
            matrix[4, 0] = Name5;
            matrix[0, 1] = number1;
            matrix[1, 1] = number2;
            matrix[2, 1] = number3;
            matrix[3, 1] = mail4;
            matrix[4, 1] = mail5;
            
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
