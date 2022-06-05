using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class Info
    {
        public static void display(Student s)
        {
            Console.WriteLine("Student id : " +s.StudentId +", "+ "Student name : " + s.StudentName +", "+ "DOB : " + s.DateOfBirth);
        }
        public static void display(Course c)
        {
            Console.WriteLine("Course id : " + c.Id + ", "+ "Course name : " + c.Name +", "+ "Duration in months : " + c.duration +", " + "Course fees : " + c.fees);
        }
        public static void display(Enroll enroll)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("Details of enrollment :");
            display(enroll.students);
            display(enroll.courses);
            Console.WriteLine("Enrollment date : " + enroll.datetime);
        }


    }
}
