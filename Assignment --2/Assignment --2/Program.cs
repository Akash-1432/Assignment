using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("Please enter array size in number : ");
            userInput = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[userInput];
            Console.WriteLine("Please enter array values : ");
            for (int incremental = 0; incremental < userInput; incremental++)
            {
                Console.WriteLine("Please enter array value of : " + incremental);
                array[incremental] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entered array elements are as below :");
            for (int indexer = 0; indexer < userInput; indexer++)
            {
                Console.WriteLine(array[indexer]);
            }
            Console.WriteLine("Average of the given array is " + array.Average() );
            Console.WriteLine("Maximum nuber in array is " + array.Max() );
            Console.WriteLine("Minimum nuber in array is " + array.Min() );

            //Ten Marks referance
            TenMarks objTenMarks = new TenMarks();
            objTenMarks.studentTenMarks();

            // referance of String Class
            String_Assignment objstrAssigment = new String_Assignment();
            objstrAssigment.stringlengthByArray();
            //referance of same strings 
            samestrings objSomeString = new samestrings();
            objSomeString.isStringIdentical();
            //referance pallindrome string
            Pallindrome objPallindromeNumber = new Pallindrome();
            objPallindromeNumber.CalculatePallindromeString();
            Console.ReadLine();
        }
    }
}
