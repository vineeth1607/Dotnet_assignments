using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy4
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();

            Console.WriteLine("WELCOME TO STUDENT DETAILS");
            do
            {
                Console.WriteLine("Choose from the below options");
                Console.WriteLine("1. Insert student\n2. Delete Student\n3. Get Details\n4. StudentsDetails\n5. Exit");
                Console.WriteLine("Enter the option you want");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    student student = new student();
                    Console.WriteLine("Please enter the Id");
                    student.studentId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the Name");
                    student.name = Console.ReadLine();
                    Console.WriteLine("Please enter the age");
                    student.age = Convert.ToInt32(Console.ReadLine());
                    int result = helper.InsertStudent(student);
                    if (result == 1)
                    {
                        Console.WriteLine("The details are Inserted Successfully");
                    }

                }
                if (x == 2)
                {
                    Console.WriteLine("Please enter the id to delete");
                    int id = Convert.ToInt32(Console.ReadLine());
                    int res = helper.DeleteStudent(id);
                    if (res == 1)
                    {
                        Console.WriteLine("Details are deleted Successfully");
                    }
                }
                if (x == 3)
                {
                    Console.WriteLine("Please enter id to get Details");
                    int id = Convert.ToInt32(Console.ReadLine());
                    student s = helper.GetDetails(id);
                    Console.WriteLine("------------------");
                    Console.WriteLine("STUDENTID  NAME  AGE");
                    Console.WriteLine("  " + s.studentId + "          " + s.name + "      " + s.age);
                    Console.WriteLine("------------------");

                }
                if (x == 4)
                {
                    List<student> list = new List<student>();
                    list = helper.Details();
                    Console.WriteLine("                     ");
                    Console.WriteLine("STUDENTID  " + "    " +     "NAME   "  + "    " +   "AGE");

                    foreach (var s in list)
                    {
                        Console.WriteLine( s.studentId + "    " + s.name + "   " + s.age);

                    }
                    Console.WriteLine("                       ");

                }
                if (x == 5)
                {
                    Environment.Exit(0);
                }
            } while (true);
        }
    }
}