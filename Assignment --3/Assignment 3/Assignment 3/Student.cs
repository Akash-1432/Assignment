using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Student
    {
        
        
            int rollno;
            string name;
            string stclass;
            string semister;
            string branch;

            public void displayStudentResult()
            {
                int[] marks = new int[5];
                marks[0] = 29;
                marks[1] = 49;
                marks[2] = 41;
                marks[3] = 50;
                marks[4] = 90;

                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine(marks[i]);
                }

                double average = marks.Average();
                Console.WriteLine("The total subject of average : " + average);

                for (int i = 0; i < marks.Length; i++)
                {

                    if (marks[i] < 35)
                    {
                        Console.WriteLine(marks[i] + " subject is failed");
                    }
                    else if (marks[i] > 35 && average < 50)
                    {
                        Console.WriteLine("Student result is failed");
                    }
                    else if (average > 50)
                    {
                        Console.WriteLine("student result is passed ");
                    }
                    else
                    {
                        Console.WriteLine("Please enter student valid details");
                    }
                }

            }

            public Student(int rollno, String name, string stclass, string semister, string branch)
            {
                this.rollno     = rollno;
                this.name       = name;
                this.stclass    = stclass;
                this.semister   = semister;
                this.branch     = branch;
                Console.WriteLine($"Rollno is:{rollno}, Name is{name},Student class is{stclass}, Semister is{semister},Branch is :{branch}");

        }
            public void displayStudentData()
            {
                Console.WriteLine("-------------------The result is----------------------------");

            }
    }
}
