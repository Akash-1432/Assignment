using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CaseStudy
{
    class AppEngine
    {
        public static SqlConnection connection;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

       
        public void introduce(Course course)
        {
            Console.WriteLine(course.Id + " " + course.Name + " " + course.duration + " " + course.fees);
        }

 

        public void register(Student student)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = getConnection();

                cmd = new SqlCommand("insert into Students values(@Id,@SName,@dob)", connection);
                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@SName", student.Name);
                cmd.Parameters.AddWithValue("@dob", student.DOB);
                int res = cmd.ExecuteNonQuery();
               
                if (res > 0)
                {
                    Console.WriteLine("Row inserted");
                } else {
                    Console.WriteLine("Not Inserted");
                }                 


            }
            catch (SqlException e)
            {
                Console.WriteLine(e); 
            }
            finally
            {

                connection.Close();
            }
        }

        

        public void AllStudentDetails()
        {
            try
            {
                connection = getConnection();
                cmd = new SqlCommand("Select * from Students", connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateStudent()
        {
            try
            {
                Console.WriteLine("Enter the Student id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Student DOB :");

                string dob = Console.ReadLine();
                connection = getConnection();
                cmd = new SqlCommand("update Students set Name=@Name,dob=@dob where Id=@Id", connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public void ParticularStudent()
        {
            try
            {
                connection = getConnection();
                Console.WriteLine("Enter The Student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from Students where Id =@Id", connection);
                cmd.Parameters.AddWithValue("@Id", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {                                                                                                                                                                                                                                                                   
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public void AllCoursesLists()
        {
            try
            {
                connection = getConnection();
                cmd = new SqlCommand("select * from Courses", connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ParticularCourse()
        {
            ParticularCourse(dr);
        }

        public void ParticularCourse(SqlDataReader dr)
        {
            try
            {
                connection = getConnection();
                Console.WriteLine("Enter The Course Id ");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from Courses where CourseId=@Cid", connection);
                cmd.Parameters.AddWithValue("@cid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public void updateCourse()
        {
            try
            {
                Console.WriteLine("Enter the Course id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course Duration :");
                int duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course Fees :");
                float fee = Convert.ToSingle(Console.ReadLine());
                connection = getConnection();
                cmd = new SqlCommand("update Courses set courseDuration=@courseDuration,courseFees=@courseFees where CourseId=@CourseId", connection);
                cmd.Parameters.AddWithValue("@CourseId", id);
                cmd.Parameters.AddWithValue("@courseDuration", duration);
                cmd.Parameters.AddWithValue("@courseFees", fee);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

       
        public void insertingCourse()
        {
            try
            {
                connection = getConnection();
                Console.WriteLine("Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Course Duration : ");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Couration Fees : ");
                float fee = Convert.ToSingle(Console.ReadLine());
                cmd = new SqlCommand("insert into Courses values(@CourseId,@CourseName,@courseDuration,@courseFees)", connection);
                cmd.Parameters.AddWithValue("@CourseId", id);
                cmd.Parameters.AddWithValue("@CourseName", name);
                cmd.Parameters.AddWithValue("@courseDuration", dur);
                cmd.Parameters.AddWithValue("@courseFees", fee);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public void EnrollDetailslists()
        {
            try
            {
                connection = getConnection();
                Console.WriteLine("Enter the Student Id :");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course id :");
                int cid = Convert.ToInt32(Console.ReadLine());
                DateTime Enrolldate = DateTime.UtcNow;
                cmd = new SqlCommand("insert into enroll_student_course values(@CourseId,@studentId,@EnrollDate)", connection);
                cmd.Parameters.AddWithValue("@CourseId", cid);
                cmd.Parameters.AddWithValue("@studentId", sid);
                cmd.Parameters.AddWithValue("@EnrollDate", Enrolldate);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted Successfully");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted ");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }
        static SqlConnection getConnection()
        {
            connection = new SqlConnection(@"data source = POOLW42SLPC6866\SQLEXPRESS; Initial Catalog=case_study_db; user id=sa; password=Temp1234");
            connection.Open();
            return connection;
        }
    }
}
