using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class CalculateIntrest
    {
        double intrestRate;

        public void IntrestCalculator(double loanamt)
        {
            Console.WriteLine("Please enter rate of interest");
            intrestRate = Convert.ToDouble(Console.ReadLine());
            double interest = (loanamt * intrestRate) / 100;
            Console.WriteLine("Rate of interest for " + intrestRate + "(in percentage ) %  is : " + intrestRate);
        }
    }
}

