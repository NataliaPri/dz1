using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово:");
            string s = Console.ReadLine(); 
            for (int i = s.Length - 1; i >= 0; i--)
                Console.Write(s[i]);
            Console.ReadLine();
        }
    }
}