using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{

    class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeTitle { get; set; } 
        public string DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string City { get; set; }


        public List<Employee> GetEmployees()
        {
            List<Employee> Emplist = new List<Employee>();
            Employee e1 = new Employee { EmployeeId = 1001, FirstName = "anniruddh",LastName = "jadhav",  EmployeeTitle = "Manager",     DateOfBirth = "1/11/1984", DateOfJoining = DateTime.Parse("8/6/2011"), City = "Aurangabad" };
            Employee e2 = new Employee { EmployeeId = 1002, FirstName = "sumit",    LastName = "ghawyat", EmployeeTitle = "AsstManager", DateOfBirth = "30/08/1984",DateOfJoining = DateTime.Parse("7/7/2012"), City = "Mumbai" };
            Employee e3 = new Employee { EmployeeId = 1003, FirstName = "prerna",   LastName = "chhabda", EmployeeTitle = "Consultant",  DateOfBirth = "2/11/1987", DateOfJoining = DateTime.Parse("12/4/2015"),City = "Pune" };
            Employee e4 = new Employee { EmployeeId = 1004, FirstName = "pooja",    LastName = "gade",    EmployeeTitle = "SE",          DateOfBirth = "29/6/1990", DateOfJoining = DateTime.Parse("2/2/2016"), City = "Nasik" };
            Employee e5 = new Employee { EmployeeId = 1005, FirstName = "sayli",    LastName = "nikam",   EmployeeTitle = "SE",          DateOfBirth = "3/3/1991",  DateOfJoining = DateTime.Parse("2/2/2016"), City = "washim" };
            Employee e6 = new Employee { EmployeeId = 1006, FirstName = "Amit",     LastName = "patil",   EmployeeTitle = "Consultant",  DateOfBirth = "28/11/1989",DateOfJoining = DateTime.Parse("8/8/2014"), City = "nagpur" };
            Employee e7 = new Employee { EmployeeId = 1007, FirstName = "tejal",    LastName = "salunkhe",EmployeeTitle  ="Consultant",  DateOfBirth = "4/12/1989", DateOfJoining = DateTime.Parse("1/6/2015"), City = "Mumbai" };
            Employee e8 = new Employee { EmployeeId = 1008, FirstName = "aniket",   LastName ="jagdale",  EmployeeTitle = "Associate",   DateOfBirth = "27/11/1993",DateOfJoining = DateTime.Parse("6/11/2014"),City=  "pune" };
            Employee e9 = new Employee { EmployeeId = 1009, FirstName = "nupur",    LastName = "patni",   EmployeeTitle = "Associate",   DateOfBirth = "5/8/1992",  DateOfJoining = DateTime.Parse("3/12/2014"),City = "Aurangabad" };
            Employee e10 =new Employee { EmployeeId = 1010, FirstName = "sapna",    LastName = "sharma",  EmployeeTitle = "Manager",     DateOfBirth = "26/4/1991", DateOfJoining = DateTime.Parse("2/1/2016"), City = "Pune" };
            Emplist.Add(e1);
            Emplist.Add(e2);
            Emplist.Add(e3);
            Emplist.Add(e4);
            Emplist.Add(e5);
            Emplist.Add(e6);
            Emplist.Add(e7);
            Emplist.Add(e8);
            Emplist.Add(e9);
            Emplist.Add(e10);
            return Emplist;
        }

        public override string ToString()
        {
           
            return string.Format("Empid :" + " " + EmployeeId + "  " + "FirstName :"+" " + FirstName + "  " + "LastName :"+" " + LastName + "  " +"EmpTitle :"+"  "+EmployeeTitle+" "+"DOB :"+"  "+DateOfBirth+"  "+"DOJ :"+
                "  "+DateOfJoining+"  "+" City :"+"  "+City);
        }


    }
    internal class QueryExpressionEg
    {
       static void Main()
        {
            Employee emp =new Employee();
            Console.WriteLine("The Employee details is : ");

            IEnumerable<Employee> employees = from e in emp.GetEmployees()
                                              select e;

            foreach(var emps in employees)
            {
                Console.WriteLine(emps.ToString());
            }

            Console.WriteLine("-");
            Console.WriteLine("Employee citys-");

            IEnumerable<Employee> ecity = from empcitys in emp.GetEmployees()
                                          where (empcitys.City) != "Mumbai"
                                          select empcitys;

            foreach(var ec in ecity)
            {
                Console.WriteLine(ec);
            }


            Console.WriteLine("-");
            Console.WriteLine("Employee titles-");

            IEnumerable<Employee>emptitle = from etitle in emp.GetEmployees()
                                            where etitle.EmployeeTitle.Equals("AsstManager")
                                            select etitle;

            foreach (var et in emptitle)
            {
                Console.WriteLine(et);
            }

            Console.WriteLine("-");
            Console.WriteLine("Employee Lastname starts with s-");

            IEnumerable<Employee> empname = from enames in emp.GetEmployees()
                                            where enames.LastName.StartsWith("S")
                                            select enames;
            foreach (var en in empname)
            {
                Console.WriteLine(en);
            }

            Console.WriteLine("-");
            Console.WriteLine("Employee Date of joining on before 1/1/2015-");

            IEnumerable<Employee> empdoj = from Emp in emp.GetEmployees()
                                           where Emp.DateOfJoining<= Convert.ToDateTime("01/01/2015")
                                           select Emp;

            foreach (var ed in empdoj)
            {
                Console.WriteLine(ed);
            }



            Console.ReadLine();
        }
    }
}
