using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___2
{
    internal class samestrings
    {
        public void isStringIdentical()
        {
            Console.WriteLine("Please enter String first : ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Please enter string second :");
            string str2 = Console.ReadLine();

            if (str1 == str2)
            {
                Console.WriteLine("Both are Identical");
            }
            else
                Console.WriteLine("Both aren't Identical");
        }
    }
}
