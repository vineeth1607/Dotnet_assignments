using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy3
{
    class ScreenClass : UserInterFace
    {
        HashSet<String> hs = new HashSet<string>();
        Dictionary<string, string> user = new Dictionary<string, string>();
        public void introduceNewCourseScreen()
        {
            Console.WriteLine("Please enter the new course name to add");
            string coursename = Console.ReadLine();
            hs.Add(coursename);
            Console.WriteLine("New Course " + coursename + " is added succesfully");
        }
        public void showAdminScreen()
        {
            Console.WriteLine("WELCOME TO ADMIN PORTAL");

            do
            {
                Console.WriteLine("Choose the below options : \n1. List of students\n2. Add new course\n3. Modify/Update the course\n4. Show all courses\n5. Close");
                Console.WriteLine("Enter your choice ( 1 or 2 or 3 ) : ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    showAllStudentsScreen();

                }
                if (a == 2)
                {
                    introduceNewCourseScreen();
                }
                if (a == 3)
                {
                    updateCourse();
                }
                if (a == 4)
                {
                    Console.WriteLine("     COURSES     ");
                    foreach (var x in hs)
                    {
                        Console.WriteLine(x + "\n");
                    }
                    Console.WriteLine(" ");

                }
                if (a > 4)
                {
                    showFirstScreen();
                }

            }
                while (true);

        }

        public void showAllCoursesScreen()
        {

            Console.WriteLine("Pease enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter password");
            string pass = Console.ReadLine();
            if (user.ContainsKey(username))
            {
                foreach (KeyValuePair<string, string> x in user)
                {
                    if (x.Key == username && x.Value == pass)
                    {
                        Console.WriteLine("     COURSES     ");
                        foreach (string c in hs)
                            Console.WriteLine(c + "\n");
                        Console.WriteLine(" ");
                    }
                    else
                    { 
                        Console.WriteLine("Entered credentials are invalid ");
                        Console.WriteLine("Pease try Again");
                        showAllCoursesScreen();
                    }
                }
            }
            else
            {
                Console.WriteLine("Please register for the courses");
                showStudentRegistrationScreen();
            }
        }

        public void showAllStudentsScreen()
        {
            Console.WriteLine("         STUDENTS            ");

            foreach (KeyValuePair<string, string> x in user)
            {
                Console.WriteLine(x.Key);
            }
            Console.WriteLine(" ");

        }
        public void showFirstScreen()
        {

            Console.WriteLine("WELCOME TO STUDENT MANAGEMENT SYSTEM ");

            do
            { 
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. Close");

                Console.WriteLine("Enter your choice ( 1 or 2 or 3 ) : ");

                int fs = Convert.ToInt32(Console.ReadLine());

                if (fs == 1)
                {
                    showStudentScreen();

                }
                if (fs == 2)
                {
                    showAdminScreen();
                }
                if (fs > 2)
                {
                    showFirstScreen();
                }

            }
                while (true);

        }
        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("WELCOME TO STUDENT REGISTRATION PORTAL ");
            Console.WriteLine("Please enter username :");
            String username = Console.ReadLine();
            Console.WriteLine("Please enter Password");
            string password = Console.ReadLine();
            user.Add(username, password);
            Console.WriteLine("Registration was successfull");
        }

        public void showStudentScreen()
        {
            Console.WriteLine("WELCOME TO STUDENT PORTAL");

            do
            {
                Console.WriteLine("Choose the below options : \n1. Student Registration\n2. All Courses\n3. Close");

                Console.WriteLine("Enter your choice ( 1 or 2 or 3) : ");

                int ss = Convert.ToInt32(Console.ReadLine());
                if (ss == 1)
                {
                    showStudentRegistrationScreen();

                }
                if (ss == 2)
                {
                    showAllCoursesScreen();
                }
                if (ss > 2)
                {
                    showFirstScreen();
                }
            } while (true);

        }

        public void updateCourse()
        {
            Console.WriteLine("Please enter the name of the course to be updated :");
            string oldCourse = Console.ReadLine();
            Console.WriteLine("Please enter new Course name :");
            string newCourse = Console.ReadLine();

            if (hs.Contains(oldCourse))
            {
                hs.Remove(oldCourse);
                hs.Add(newCourse);
            }
            else
            {
                Console.WriteLine("Enter correct course name to update");

            }
            if (hs.Contains(newCourse))
            {
                Console.WriteLine("Course is updated successfully");
                Console.WriteLine("Updated Courses");
                Console.WriteLine("         COURSES          ");
                foreach (var x in hs)
                {
                    Console.WriteLine(x + "\n");
                }
                Console.WriteLine(" ");

            }
        }
    }
}
