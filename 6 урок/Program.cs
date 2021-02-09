using System;
using System.Diagnostics;


namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            Process[] processes = Process.GetProcesses();

            foreach (Process pro in processes)
                Console.WriteLine(pro);

            Console.Write("Введите название процесса, который вы хотите удалить: ");
            
            string Nameproc = Console.ReadLine();
            Process.GetProcessesByName(Nameproc);
            Console.WriteLine(Process.GetProcessesByName(Nameproc));
            System.Diagnostics.Process[] listofproc = Process.GetProcessesByName(Nameproc);

            foreach (Process pro in listofproc)
                Console.WriteLine(pro);
            try {
                
                listofproc[0].Kill();
                listofproc[0].WaitForExit();
                
             }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Программа не работает. Её нельзя удалить.");
            }
        }
    }
}
