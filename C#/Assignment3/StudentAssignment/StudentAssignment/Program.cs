using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssignment
{
    internal class Student
    {
        int rollno;
        String name;
        String branch;
        String sem;
        String clas;

        static public void displayResult()
        {
            int[] marks = new int[5];
            marks[0] = 30;
            marks[1] = 66;
            marks[2] = 35;
            marks[3] = 56;
            marks[4] = 85;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("marks of " + i + " subs are: " + marks[i]);
            }

            double average = marks.Average();

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("FAIL");
                }
                else if (marks[i] > 35 && average < 50)
                {
                    Console.WriteLine("FAIL");
                }
                else if (average > 50)
                {
                    Console.WriteLine("PASS");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
        }
        public Student(int rollno, String name, String branch, String sem, String clas)
        {
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.sem = sem;
            this.clas = clas;
            Console.WriteLine($"\nStudent Rollno: {rollno}, Name of Student: {name},class: {clas}, Sem: {sem},Branch : {branch}");
        }
        public static void displayData()
        {
            Console.WriteLine("\nMarks: " );
            Console.ReadLine();
        }
            public static void Main(string[] args)
            {

                Student.displayResult();
                Student student = new Student(33, "Vineeth", "mechanical", "4-2", "mechancial-c");
                Student.displayData();
                Console.ReadLine();
            }
        }
    }
