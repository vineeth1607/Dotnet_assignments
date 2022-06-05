using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStuday1
{
    internal class Program
    {
        public class Student
        {
            public string id;
            public string name;
            public string dob;
            public override string ToString()
            {
                return "StudentId : " +  this.id + ", "+ "Student Name : " +  this.name +", " +  "Student DOB : " +  this.dob;
            }

            public Student(string id, string name, string dob)
            {
                this.id = id;
                this.name = name;
                this.dob = dob;
            }
            public Student()
            {

            }

            public void setId(string id)
            {
                this.id = id;
            }
            public string getId()
            {
                return id;
            }
            public void setName(string name)
            {
                this.name = name;
            }
            public string getName()
            {
                return name;
            }
            public void setDob(string dob)
            {
                this.dob = dob;
            }
            public string getDob()
            {
                return dob;
            }
        }
        public class Info
        {
            public static void display(Student student)
            {
                Console.WriteLine($"Details of the students are student ID : {student.id}, Student Name : {student.name}, Student DOB : {student.dob}");
            }

        }
        public class App
        {
            public void scenerio1()
            {
                Student student1 = new Student("1", "Vineeth", "16/07/1998");
                Student student2 = new Student("2", "Sunil", "17/08/1999");
                Student student3 = new Student("3", "Sufian", "20/02/1998");

                Info.display(student1);
                Info.display(student2);
                Info.display(student3);
            }
            public void scenerio2()
            {
                Student[] student = new Student[2];

                student[0] = new Student("001", "Ruthwik", "12/08/1999");
                student[1] = new Student("002", "Lucky", "11/11/2000");

                for (int i = 0; i < student.Length; i++)
                {
                    Info.display(student[i]);
                }
            }

            public void Scenerio3()
            {
                Console.WriteLine("Enter no.of students:");
                int n = Convert.ToInt32(Console.ReadLine( ));
                object[] array = new object[n];

                for (int i = 0; i < n; i++)
                {
                    Student student = new Student();
                    Console.WriteLine("Enter student ID:");
                    student.id = Console.ReadLine();
                    Console.WriteLine("Enter student Name:");
                    student.name = Console.ReadLine();
                    Console.WriteLine("Enter student DOB");
                    student.dob = Console.ReadLine();
                    array[i] = student;
                }
                foreach (object ob in array)
                {
                    Console.WriteLine("Details of the students : " + ob);
                }
            }

        }
        public class Test
        {
            public static void Main(string[] args)
            {
                do
                {
                    Console.WriteLine("Choose one");
                    Console.WriteLine("1. Scenerio1");
                    Console.WriteLine("2. Scenerio2");
                    Console.WriteLine("3. Scenerio3");
                    Console.WriteLine("4. Close");
                    int x = Convert.ToInt32(Console.ReadLine());
                    App ap = new App();
                    if (x==1)
                    {

                        ap.scenerio1();
                    }
                    if (x==2)
                    {
                        ap.scenerio2();
                    }
                    if (x==3)
                    {
                        ap.Scenerio3();
                    }
                    if (x==4)
                    {
                        Environment.Exit(0);
                    }


                } while (true);
            }
        }
    }
}