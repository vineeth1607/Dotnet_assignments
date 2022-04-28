using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarHostellerAssignment
{
    public class Students
    {
        public int student_Id;
        public string student_Name;
        public double exam_fee;


        public void displayDetails()
        {
            Console.WriteLine($"\nStudent name : {student_Name} bearing the Student Id of {student_Id} has exam paid the exam fee of {exam_fee}");
        }
        public void pay_Fee()
        {
            Console.WriteLine("\nEnter student id: ");
            student_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student name: ");
            student_Name = Console.ReadLine();
            Console.WriteLine("Exam fee:" + 1000);
            Console.WriteLine("Enter the exam fee amount to pay:");
            exam_fee = int.Parse(Console.ReadLine());
            double remainingfee = 1000 - exam_fee;
            if (exam_fee == 1000)
            {
                Console.WriteLine("Full fees paid ");
            }
            else
            {
                Console.WriteLine("The remaining fee: " + remainingfee);
            }
        }
    }
    class DayScholar
    {
        public double transportfees;

        public DayScholar(double transportfees)
        {
            this.transportfees = transportfees;
            double remainingfee2 = 20000 - transportfees;

            Console.WriteLine("\nThe transport fee to pay : " + 20000 + " per year ");


            Console.WriteLine($"The dayscholar  paid the transpot fees of {transportfees} and remaining due fee is {remainingfee2}");
            
        }

    }
    public class Hosteller
    {
        public double hostelfee;

        public Hosteller(double hostelfee)
        {

            this.hostelfee = hostelfee;

            double remaining_fee3 = 30000 - hostelfee;
            Console.WriteLine("hostel  fee to pay : " + 30000 + " per year ");

            Console.WriteLine($"The Hosteller  paid the hostel fees of {hostelfee} and remaining due fee is {remaining_fee3} ");
            Console.WriteLine();
        }

        public static void Main(String[] args)
        {
            Students st= new Students();
            st.pay_Fee();
            st.displayDetails();
            Console.WriteLine("Enter the tranport fee to pay : ");
            DayScholar day = new DayScholar(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the hostel fee to pay : ");
            Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));


            Console.ReadLine();
        }
    }
}
