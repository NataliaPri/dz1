using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел: ");
            string s = Console.ReadLine();
            Numbers text = new Numbers(s);
            Console.Write(text);

            String separator = " ";
            String[] listOfNumber = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            
            byte[] byteNum = new byte[listOfNumber.Length];
           
            for (int i = 0; i < listOfNumber.Length; i++)
            {
                int x = int.Parse(listOfNumber[i]);
                byte y = Convert.ToByte(x);
                byteNum[i] = y;
            }

            File.WriteAllBytes("bytes.bin", byteNum);


        }
    }
}
