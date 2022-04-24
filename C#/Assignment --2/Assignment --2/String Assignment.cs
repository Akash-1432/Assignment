using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___2
{
    internal class String_Assignment
    {
        public void stringlengthByArray()
        {
            Console.WriteLine("Please enter user name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Given user name is : " + name);
            Console.WriteLine("Given string length is : " + name.Length);
            int stringLength = name.Length;

            for (int indexer = stringLength - 1; indexer >= 0; indexer--)
            {
                char userString = name[indexer];
                Console.Write(userString);
            }
            Console.WriteLine();

        }
    }
}
