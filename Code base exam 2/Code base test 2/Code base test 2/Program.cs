using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_base_test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new
                Calculator();
            double result = calc.Calculate(Calculator.CalculateTypeEnum.Multiply, 5 , 3);
            Console.WriteLine(result);
            Console.Read();
        }
        public class Calculator
        {
            internal double 
                Calculate(CalculateTypeEnum type,double x, double y)
            { switch(type)
                {
                    case
                        CalculateTypeEnum.Add: calculate = new
                            CalculateDelegate(Add);
                        break;
                    case CalculateTypeEnum.Subtract: calculate = new
                            CalculateDelegate(subtract);
                        break;
                    case
                        CalculateTypeEnum.Multiply: calculate = new
                            CalculateDelegate(Multiply);
                        break;
                    case
                        CalculateTypeEnum.Divide: calculate = new
                            CalculateDelegate(Divide);
                        break;
                }
                return calculate(x, y);
            }
            private double Add(double x, double y) 
                { return x + y; }
            private double subtract(double x , double y)
            { return x - y; }
            private double Multiply (double x, double y)
                { return x * y; }
            private double Divide (double x , double y)
                { return x / y; }
               public enum 
                CalculateTypeEnum
            {
                Add,
                Subtract,
                Multiply,
                Divide,
            }
            private delegate double CalculateDelegate(double x , double y);
            private CalculateDelegate calculate;

        }
    }
}
