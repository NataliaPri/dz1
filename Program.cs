using System;

namespace ConsolApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите дату: ");
            string date = Console.ReadLine();

            Console.WriteLine("Здраствуйте, {0}, Сегодня {1}. ", name, date);
        }
    }
}
