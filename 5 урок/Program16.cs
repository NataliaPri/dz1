using System;
using System.IO;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string time2 = DateTime.Now.ToString();
            Console.WriteLine(DateTime.Now);
            File.AppendAllLines("startup.txt", new[] { time2 });
            string updateTime = File.ReadAllText("startup.txt");
            Console.WriteLine(updateTime);
        }
    }
}
