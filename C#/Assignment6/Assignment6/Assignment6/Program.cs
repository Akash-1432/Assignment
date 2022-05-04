using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    interface IStudent
    {
        void showdetails(int studentid, string studentName);
    }

    class DayScholar:IStudent
    {
        public void showdetails(int studentid, string studentName)
        {
            Console.WriteLine($"The student details is studentid is {studentid}, student name is {studentName}", studentid, studentName);
        }
    }

    class Resident : IStudent
    {
        public void showdetails(int studentid, string studentName)
        {
            Console.WriteLine($"The student details is studentid is {studentid}, student name is {studentName}", studentid, studentName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dayscholar Details");
            IStudent ds = new DayScholar();
            ds.showdetails(1432, "Akash");

            Console.WriteLine("Resident Details");
            IStudent re = new Resident();
            re.showdetails(2341, "Prerna");

            Console.ReadLine();
        }
    }
}
