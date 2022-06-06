using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CaseStudy
{
    class UserInterFace : IUseraction
    {
        AppEngine objAppEngine = new AppEngine();

        string res;
        public void showFirstScreen()
        {
            do
            {
                Console.WriteLine("Welcome to Student Management System(Student Mgmt. System) v1.0");
                Console.WriteLine("Tell us about who you are : \n1. Student\n2. Admin");
                Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                    default:
                        Console.WriteLine("Choose Correct Option");
                        break;
                }
                Console.WriteLine("Do you want to continue With a Main Screen:Y or N");
                res = Console.ReadLine();
            }
            while ((res == "Y") || (res == "y"));
        }

        public void showStudentScreen()
        {
            do
            {
                Console.WriteLine("Select: \n1.Check your Old student details\n2.Registration new student\n3.Search Available Courses\n4.Enroll to Course in List");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        // Checks  Particular student details
                        objAppEngine.ParticularStudent();
                        Console.WriteLine("Operation Completed you may Exit....!");
                        break;
                    case 2://New registration
                        this.showStudentRegistrationScreen();
                        Console.WriteLine("Operation Completed you may Exit....!");
                        break;
                    case 3:
                        //Showcase all available courses
                        Console.WriteLine("--------------------Below is list of courses------------------------");
                        objAppEngine.AllCoursesLists();
                        Console.WriteLine("Operation Completed you may Exit....!");
                        break;
                    case 4:
                        //Student enrolling to particular course
                        objAppEngine.EnrollDetailslists();
                        Console.WriteLine("You have successfully enrolled you may Exit the Screen now");
                        break;
                    default:
                        Console.WriteLine("Enter valid Option....!");
                        break;
                }
                Console.WriteLine("Do you want to continue Student Screen:Y or N");
                res = Console.ReadLine();
            } while ((res == "Y") || (res == "y"));
        }
        public void showAdminScreen()
        {
            do
            {
                Console.WriteLine("Select: \n1.Register New Course\n2.Courses Available\n3.Update Course Details\n4.Update Student Details\n5.All Registered Students");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //If any new course want to add for Organization
                        this.introduceNewCourseScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 2:
                        //list of existing courses
                        Console.WriteLine("-------------All Available Courses-------------------");
                        showAllCoursesScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 3:
                        //updates in Course structure
                        objAppEngine.updateCourse();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                  
                    case 4:
                        //modify existing student details
                        objAppEngine.UpdateStudent();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 5:
                        //Gives ALL Students Details
                        showAllStudentsScreen();
                        break;

                    default:
                        Console.WriteLine("Enter valid Option....!");
                        break;
                }
                Console.WriteLine("Do you want to continue Admin Screen:Y or N");
                res = Console.ReadLine();
            } while ((res == "Y") || (res == "y"));

        }
        public void showAllStudentsScreen()
        {
            Console.WriteLine("List of All Student Details : ");
            objAppEngine.AllStudentDetails();
        }
        public void showStudentRegistrationScreen() // Execute the register method of AppEngine class
        {
            Console.WriteLine("You are Entering into Student Registration form :");
            Console.WriteLine("Enter the Student Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Student DOB:");
            string dob = Console.ReadLine();
            objAppEngine.register(new Student(id, name, dob));
        }

        public void introduceNewCourseScreen()
        {
            objAppEngine.insertingCourse();
        }
        public void showAllCoursesScreen()
        {
            Console.WriteLine("List of all courses : ");
            objAppEngine.AllCoursesLists();
        }
    }
}

