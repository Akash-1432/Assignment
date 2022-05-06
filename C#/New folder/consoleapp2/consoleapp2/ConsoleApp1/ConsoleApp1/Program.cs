using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = 20;
            Console.WriteLine("Number: " +num);

            if(num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("divisible by 3 and 5");
            }
            else
            {
                Console.WriteLine("not divisible by 3 and 5");
            }
            Console.ReadLine();
        }
    }
}
