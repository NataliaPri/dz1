using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

        
         Console.WriteLine("Введите несколько чисел через пробел:");
         string s = Console.ReadLine();

            String separator = " ";
            String[] listOfNumber = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int d = 0;
            foreach (String a in listOfNumber)
            {
                var number = int.Parse(a);
                d = d + number;
                
            }
         Console.WriteLine("Результат: " + d);
        }
    }
}
