using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStuday1
{
  
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public Student(int id, string name, string dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
        }
    }
    public class Course
    {
        public int Id;
        public string Name;
        public int duration;
        public float fees;
        public Course(int Id, string Name, int dura, float Fees)
        {
            this.Id = Id;
            this.Name = Name;
            this.duration = dura; this.fees = Fees;
        }
    }
    public class Info
    {
        public void display(Student student)
        {
            Console.WriteLine($"Details of the students are student ID : {student.Id}, Student Name : {student.Name}, Student DOB : {student.DOB}");
        }

        public void display(Course course)

        {
            Console.WriteLine($"Student ID : {course.Id}, Student name : {course.Name}, Course duration : {course.duration}, Course fee : {course.fees}");
        }
    }
    class App
    {
        Info info = new Info();
        public void Scenerio1()
        {
            Student s1 = new Student(111, "Sai kumar", "15/10/2000");
            Student s2 = new Student(122, "Mukhendar", "20/09/2001");
            info.display(s1);
            info.display(s2);
        }
        public void Scenerio2()
        {
            Student[] students = new Student[2];
            students[0] = new Student(110, "Vinnu", "12/05/1999");
            students[1] = new Student(120, "Karna", "11/11/2001");
            for (int i = 0; i < students.Length; i++)
            {
                info.display(students[i]);
            }
        }
        public void Scenerio3()
        {
            Student[] student = new Student[3];
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter Student Id,Student name and DOB");
                student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            }
            for (int i = 0; i < student.Length; i++)
            {
                info.display(student[i]);
            }
            Console.ReadLine();
        }
        public void courseclass()
        {
            Course course = new Course(01, "Vinnu", 33, 10000.00f);
            info.display(course);
        }
    
        public static void main (string[] args)
        {
            App a= new App();
            a.Scenerio1();
            a.Scenerio2();
            a.Scenerio3();
            a.courseclass();
            Console.Read();
        }
    }
}