using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    interface IStudent
    {
        void DisplayDetails(int StudentId, string StudentName);
    }
    class DaySholar : IStudent
    {
        public void DisplayDetails(int StudentId, string StudentName)
        {
            Console.WriteLine("Student id is:{0}", StudentId);
            Console.WriteLine("Name of the Student is:{0}", StudentName);
        }
    }
    class Resident : IStudent
    {
        public void DisplayDetails(int StudentId, string StudentName)
        {
            Console.WriteLine("Student id is:{0}", StudentId);
            Console.WriteLine("Name of the Student is:{0}", StudentName);
        }
    }
    class InterfaeEg
    {
        static void Main(string[] args)
        {

            IStudent obj = new DaySholar();
            obj.DisplayDetails(100, "Akash");


            IStudent obj1 = new Resident();
            obj1.DisplayDetails(101, "Mahesh");
            Console.ReadLine();

        }
    }

}
    

