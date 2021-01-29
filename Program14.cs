using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 & x <= 12) GetMonth(x);
            else
            {
                while (x < 1 || x > 12)
                {
                    Console.Write("Ошибка. Введите число от 1 до 12: ");
                    x = int.Parse(Console.ReadLine());

                }
                if (x >= 1 & x <= 12) GetMonth(x);
            }

        
        }
            
        private static int GetMonth(int x)
        {

            if (x == 12 || x == 1 || x == 2) Console.WriteLine("Зима");
            else
            if (x == 3 || x == 4 || x == 5) Console.WriteLine("Весна");
            else
            if (x == 6 || x == 7 || x == 8) Console.WriteLine("Лето");
            else
            if (x == 9 || x == 10 || x == 11) Console.WriteLine("Осень");
            return(x);
 
        }

        
    }
}
