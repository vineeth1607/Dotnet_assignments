using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanAssignment
{
    internal class Loan
    {
        double rateOfIntrest;
        public void loanCalculator(double loan_amount)
        {
            Console.WriteLine("\nEnter the rate of interest:");
            rateOfIntrest = Convert.ToDouble(Console.ReadLine());
            double interest = (loan_amount * rateOfIntrest) / 100;
            Console.WriteLine("\nRate of interest for " + rateOfIntrest + "%  is : " + interest);
        }

        public static void Main(string[] args)
        {
            Loan lo = new Loan();
            Console.WriteLine("\nEnter loan amount: ");
            lo.loanCalculator(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();

        }
    }
}
