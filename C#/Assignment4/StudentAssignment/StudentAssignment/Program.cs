using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssignment
{

    abstract public class Student
    {
        public String Name;
        public int StudentId;
        public abstract void BooleanIspassed(int Grade);
    }
        public class Undergraduate : Student
        {
        public override void BooleanIspassed(int Grade)
        {
            try
            {

                Console.WriteLine("Enter the grade of undergraduate student ");
                Grade = Convert.ToInt32(Console.ReadLine());
                if (Grade > 70)
                {
                    Console.WriteLine("Undergraduate student passed the course ");
                }
                else
                {
                    Console.WriteLine("Undergraduate student failed the course ");
                }

            }
            catch (Exception exp)
            {
                Console.WriteLine("Invalid input " + exp
                    .StackTrace);
            }
        }
    }

        class Graduate : Student
        {
            public override void BooleanIspassed(int Grade)
            {
                try
                {
                    Console.WriteLine("\nEnter the grade of graduate student");
                    Grade = Convert.ToInt32(Console.ReadLine());
                    if (Grade > 80)
                    {
                        Console.WriteLine("Graduate student passed the course ");
                    }
                    else
                    {
                        Console.WriteLine("Graduate student failed the course ");
                    }
                }
                catch (Exception exp2)
                {
                    Console.WriteLine("Invalid input" + exp2.StackTrace);
                }
            }

            static void Main(string[] args)
            {
                Undergraduate ugraduate = new Undergraduate();
                ugraduate.BooleanIspassed(10);
                ugraduate.Name = "Vineeth";
                ugraduate.StudentId = 333;
                Console.WriteLine($"Name of the student : {ugraduate.Name} and StudentId : {ugraduate.StudentId}");

                Graduate graduate = new Graduate();
                graduate.Name = "Sunil";
                graduate.StudentId = 318;
                graduate.BooleanIspassed(20);
                Console.WriteLine($"Name of the student : {graduate.Name} and StudentId : {graduate.StudentId}");

                Console.ReadLine();
            }
        }
}


