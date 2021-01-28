using System;

namespace ConsoleApp12
{
    class Program
    {


        static void Main(string[] args)
        {
            GetFullName("Виолетта", "Стругатская", "Александровна");
            GetFullName("Максим", "Иванов", "Сергеевич");
            GetFullName("Мария", "Аризанская", "Вадимовна");
            GetFullName("Наруто", "Узумаки", "Минатович");
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string clued_name = firstName + " " + lastName + " " + patronymic;
            Console.WriteLine(clued_name);
           
            return clued_name;
        }
    }
     
}

