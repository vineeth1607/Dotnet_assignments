using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstudentAssignment
{
        interface IStudent
        {
            void showdetails(int student_ID, string student_Name);
        }

        class DayScholar : IStudent
        {
            public void showdetails(int student_ID, string student_Name)
            {
                Console.WriteLine($"The studentID : {student_ID}, Name of the student : {student_Name}", student_ID, student_Name);
            }
        }

        class Resident : IStudent
        {
            public void showdetails(int student_ID, string student_Name)
            {
                Console.WriteLine($"The studentid :  {student_ID} , Name of the student : {student_Name}", student_ID, student_Name);
            }
        }
        class MainClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Details of the Dayscholar student");
                IStudent student = new DayScholar();
                student.showdetails(333, "Vineeth");

                Console.WriteLine("Details of the residential student");
                IStudent istudent = new Resident();
                istudent.showdetails(308, "Sunil");

                Console.ReadLine();
            }
        }
    }