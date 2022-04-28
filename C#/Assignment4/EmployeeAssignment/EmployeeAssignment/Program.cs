
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    public class Employee
    {
        
        public string employeeName;
        public int employeeId;
        public float employeeSalary;

        public Employee(string employeeName,int employeeId, float employeeSalary)
        {
            
            this.employeeName = employeeName;
            this.employeeId = employeeId;
            this.employeeSalary = employeeSalary;
        }
        public void EmployeeDetails()
        {
            Console.WriteLine($"\nEmployee Named {employeeName} with empployee Id {employeeId} earns the salary per month is {employeeSalary}");
        }
    }
    public class PartTimeEmployee
    {
        public int wages = 750;

        public void PartTimeEmployeeDetails()
        {
            Console.WriteLine($"The parttime employee earns the daily wages of " + wages);
        }



        public static void Main(string[] args)
        {


            Employee employee = new Employee("Vineeth",333, 28000);
            employee.EmployeeDetails();
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.PartTimeEmployeeDetails();

            Console.ReadLine();
        }
    }
}

