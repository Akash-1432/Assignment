using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___2
{
    internal class Pallindrome
    {
        public void CalculatePallindromeString()
        {
            Console.WriteLine("Please Enter String");
            string strUserString = "";
            string name = Console.ReadLine();
            int count = name.Length;
           
            for (int index = count - 1; index >= 0; index--)  {

                char charUserInput = name[index];
                strUserString = strUserString + charUserInput;

            }

            if (name.Equals(strUserString))
                Console.WriteLine("Given string array size  is palindrome  : " + name);
            else
                Console.WriteLine("Given string array size is not palindrome  : " + name);
        }
    }
}
