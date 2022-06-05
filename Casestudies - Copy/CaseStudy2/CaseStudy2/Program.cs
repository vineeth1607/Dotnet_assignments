using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Course course1 = new Course(1, "DoNet", 1, 10000);
            Course course2 = new Course(2, "Python", 6, 20000);
            Course course3 = new Course(3, "Java full stack development",6, 35000);

            Student student = new Student(10, "Vineeth", "16/07/1998");
            Student student1 = new Student(20, "Sunil", "20/09/1998");
            Student student2 = new Student(30, "Sufian", "08/08/1999");

            AppEngine appengine = new AppEngine();
            appengine.introduce(course1);
            appengine.introduce(course2);
            appengine.introduce(course3);

            appengine.register(student);
            appengine.register(student1);
            appengine.register(student2);



            appengine.enroll(student, course1);
            appengine.enroll(student1, course2);
            appengine.enroll(student2, course3);

            Student[] students = appengine.listOfStudents();

            for (int i = 0; i < appengine.studentlistsize; i++)
            {
                Info.display(students[i]);
            }
            Course[] courses = appengine.listOfCourses();
            for (int i = 0; i < appengine.courselistsize; i++)
            {
                Info.display(courses[i]);
            }
            Enroll[] enrolls = appengine.listOfEnrollments();
            for (int i = 0; i < appengine.enrolllistsize; i++)
            {
                Info.display(enrolls[i]);
            }
            Console.Read();
        }
    }

}