using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Referance of student marks program
            Student objStudent = new Student(96358, "Akash", "Btech", "4 th Semister", "CS");
            objStudent.displayStudentData();
            objStudent.displayStudentResult();

            // Referance of car program
            cars objCar = new cars(0007, "Weganor", "Maruti Suzuki");
            objCar.displaycardetails();
            cars objCar2 = new cars(800000);

            // Refearance of loan amount calculator
            CalculateIntrest objCalculateInt = new CalculateIntrest();
            objCalculateInt.IntrestCalculator(200000);
            Console.ReadLine();
        }
    }
    
}
