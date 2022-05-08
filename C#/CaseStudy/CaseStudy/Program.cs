using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Program
    {
        public class Student
        {
            public int StudentId;
            public string Name;
            public string DateofBirth;
            
            public Student(int id,string name, string DateofBirth)
            {
                this.StudentId = id;
                this.Name = name;
                this.DateofBirth = DateofBirth;
            }
            public Student()
            {

            }
            
            public void setId(int id)
            {
                this.StudentId = id;
            }
            public int getId()
            {
                return StudentId;
            }
            public void setName(string name)
            {
                this.Name= name;
            }
            public string getName()
            {
                return Name;
            }
            public void set (string DateofBirth)
            {
                this.DateofBirth = DateofBirth;
            }
            public string getDob()
            {
                return DateofBirth;
            }
        }
        public class Info
        {
            public void display(Student student1,Student student2,Student student3,Student student4)
            {
                
                Console.WriteLine("the details of the given students are: ");
                Console.WriteLine($"the student name is {student1.getName()} with id {student1.getId()} and DateofBirth {student1.getDob()}");
                Console.WriteLine($"the student name is {student2.getName()} with id {student2.getId()} and  DateofBirth {student2.getDob()}");
                Console.WriteLine($"the student name is {student3.getName()} with id {student3.getId()} and DateofBirth {student3.getDob()}");
                Console.WriteLine($"the student name is {student4.getName()} with id {student4.getId()} and  DateofBirth {student4.getDob()}");

            }
                
        }
        public class App
        {
            public void scenerio1()
            {
                Student student = new Student(1,"Akash patil","12/04/1998");
                Student student2 = new Student(2, "Aniket jadgale", "12/06/2000");
                Student student3 = new Student(3, "Vikas wagh", "24/12/1996");
                Student student4 = new Student(4, "krishna ghule", "08/02/1998");

                Info info = new Info();
                info.display(student,student2,student3,student4);
            }
            public void scenerio2()
            {
                Student[] arr = new Student[3];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("enter the name");
                    string name=Console.ReadLine();
                    Console.WriteLine("enter id");
                    int id = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    
                    Console.WriteLine();
                }
            }
        }
        public static void Main(string[] args)
        {
            App app = new App();
            app.scenerio1();
            app.scenerio2();

            Console.ReadLine();
        }
    }
}
