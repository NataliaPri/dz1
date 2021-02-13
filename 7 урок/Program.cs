using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret = "some secret password";
            Console.WriteLine("Enter password:");
            string input = Console.ReadLine();
            if (input == secret)
            {
                Console.WriteLine("Welcome!");
            }
        }
    }
}
