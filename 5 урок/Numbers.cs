using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    public class Numbers
    {
        
        
        public string someNum { get; set; }
       

        public Numbers(string someNum)
        {
            String separator = " ";
            String[] listOfNumber = someNum.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (String a in listOfNumber)
            {
                int.Parse(a);
            }
            Console.WriteLine(listOfNumber);

            return;
        }
        
    }
}

