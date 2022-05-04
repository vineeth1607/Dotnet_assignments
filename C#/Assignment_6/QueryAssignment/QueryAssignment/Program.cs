using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryAssignment
{
    class Employee
    {
        public int Employee_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Employee_Title { get; set; }
        public string DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }


        public List<Employee> GetEmployees()
        {
            List<Employee> Emplist = new List<Employee>();
            Employee emp1 = new Employee { Employee_Id = 1001,  First_Name = "Malcolm", Last_Name = "Daruwalla", Employee_Title = "Manager",           DOB = "16/11/1984", DOJ = DateTime.Parse("8/6/2011"),  City = "Mumbai" };
            Employee emp2 = new Employee { Employee_Id = 1002,  First_Name = "Asdin",   Last_Name = "Dhalla",    Employee_Title = "Assistant Manager", DOB = "20/08/1984", DOJ = DateTime.Parse("7/7/2012"),  City = "Mumbai" };
            Employee emp3 = new Employee { Employee_Id = 1003,  First_Name = "Madhavi", Last_Name = "Oza",       Employee_Title = "Consultant",        DOB = "14/11/1987", DOJ = DateTime.Parse("12/4/2015"), City = "Pune" };
            Employee emp4 = new Employee { Employee_Id = 1004,  First_Name = "Saba",    Last_Name = "Shaikh",    Employee_Title = "SE",                DOB = "3/6/1990",   DOJ = DateTime.Parse("2/2/2016"),  City = "Pune" };
            Employee emp5 = new Employee { Employee_Id = 1005,  First_Name = "Nazia",   Last_Name = "Shaikh",    Employee_Title = "SE",                DOB = "8/3/1991",   DOJ = DateTime.Parse("2/2/2016"),  City = "Mumbai" };
            Employee emp6 = new Employee { Employee_Id = 1006,  First_Name = "Amit",    Last_Name = "Pathak",    Employee_Title = "Consultant",        DOB = "7/11/1989",  DOJ = DateTime.Parse("8/8/2014"),  City = "Chennai" };
            Employee emp7 = new Employee { Employee_Id = 1007,  First_Name = "Vijay",   Last_Name = "Natrajan",  Employee_Title = "Consultant",        DOB = "2/12/1989",  DOJ = DateTime.Parse("1/6/2015"),  City = "Mumbai" };
            Employee emp8 = new Employee { Employee_Id = 1008,  First_Name = "Rahul",   Last_Name = "Dubey",     Employee_Title = "Associate",         DOB = "11/11/1993", DOJ = DateTime.Parse("6/11/2014"), City = "Chennai" };
            Employee emp9 = new Employee { Employee_Id = 1009,  First_Name = "Suresh",  Last_Name = "Mistry",    Employee_Title = "Associate",         DOB = "12/8/1992",  DOJ = DateTime.Parse("3/12/2014"), City = "Chennai" };
            Employee emp10 = new Employee { Employee_Id = 1010, First_Name = "Sumit",   Last_Name = "Shah",      Employee_Title = "Manager",           DOB = "12/4/1991",  DOJ = DateTime.Parse("2/1/2016"),  City = "Pune" };
            Emplist.Add(emp1);
            Emplist.Add(emp2);
            Emplist.Add(emp3);
            Emplist.Add(emp4);
            Emplist.Add(emp5);
            Emplist.Add(emp6);
            Emplist.Add(emp7);
            Emplist.Add(emp8);
            Emplist.Add(emp9);
            Emplist.Add(emp10);
            return Emplist;
        }

        public override string ToString()
        {

            return string.Format("EmployeeID :" + " " + Employee_Id +  " , " + "FirstName :" + " " + First_Name + " _ " + "LastName :" + " " + Last_Name + " , " + "EmpTitle :" + "  " + Employee_Title + " , " + "DOB :" + "  " + DOB + " , " + "DOJ :" + "  " + DOJ + " , " + " City :" + "  " + City);
        }
    }

    class Query
    {
        static void Main()
        {
            Employee emp = new Employee();
            Console.WriteLine("                                                     ");
            Console.WriteLine("     DETAILS OF THE EMPLOYEES : ");
            Console.WriteLine("                                                     ");

            IEnumerable<Employee> employees = from employee in emp.GetEmployees()
                                              select employee;

            foreach (var emps in employees)
            {
                Console.WriteLine(emps.ToString());
            }

            Console.WriteLine("                                                     ");
            Console.WriteLine("     CITIES OF THE EMPLOYESS :              ");
            Console.WriteLine("                                                     ");

            IEnumerable<Employee> ecity = from empcitys in emp.GetEmployees()
                                          where (empcitys.City) != "Mumbai"
                                          select empcitys;

            foreach (var employee_City in ecity)
            {
                Console.WriteLine(employee_City);
            }


            Console.WriteLine("                                                                 ");
            Console.WriteLine("     TITTLE OF THE EMPLOYEES :                         ");
            Console.WriteLine("                                                     ");

            IEnumerable<Employee> emptitle = from etitle in emp.GetEmployees()
                                             where etitle.Employee_Title.Equals("Assistant Manager")
                                             select etitle;

            foreach (var employee_Title in emptitle)
            {
                Console.WriteLine(employee_Title);
            }

            Console.WriteLine("                                                                 ");
            Console.WriteLine("    NAME OF THE EMPLOYEE WHOSE LAST_NAME STARTS WITH THE LETTER 'S'  ");
            Console.WriteLine("                                                     ");

            IEnumerable<Employee> empname = from employeenames in emp.GetEmployees()
                                            where employeenames.Last_Name.StartsWith("S")
                                            select employeenames;
            foreach (var employee_Name in empname)
            {
                Console.WriteLine(employee_Name);
            }

            Console.WriteLine("                                                                             ");
            Console.WriteLine("     DATE_OF_JOINING OF EMPLOYEE ON OR BEFORE  1/1/2015 : ");
            Console.WriteLine("                                                     ");

            IEnumerable<Employee> empdoj = from Emp in emp.GetEmployees()
                                           where Emp.DOJ <= Convert.ToDateTime("01/01/2015")
                                           select Emp;

            foreach (var employee_Doj in empdoj)
            {
                Console.WriteLine(employee_Doj);
            }



            Console.ReadLine();
        }
    }
}