using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
<<<<<<< HEAD
    public class WithdrawException : ApplicationException
=======
     public class WithdrawException : ApplicationException
>>>>>>> 915b0c8cb0af5d13f5e4b2e780099a36f0a1c93a
    {
        public WithdrawException(string msg) : base(msg)
        {

        }
    }
    public class Bank
    {
        float Amount = 15000;
        float Blnc;
        string Account_Holder_Name;
        string Account_Number;

        public Bank()
        {
            Console.WriteLine("Please Enter the Account Number : ");
            Account_Number = Console.ReadLine();
            Console.WriteLine("Please Enter The Account Holder Name :");
            Account_Holder_Name = Console.ReadLine();

            Console.WriteLine($"Account Details Are" +
                $" Account Number : {Account_Number}, Account Holder Name : {Account_Holder_Name}, Account Balance : {Amount}");

        }


        public void Amount_Deposited()
        {
            Console.WriteLine("Please Enter The Amount You Want To Deposit : ");
            float Deposit_Amount = Convert.ToSingle(Console.ReadLine());

            if (Deposit_Amount == 0)
            {
                Console.WriteLine("Minimum Deposit Amount Should Be 100 ");

            }
            else
            {
                Blnc = Amount + Deposit_Amount;
                Console.WriteLine("Account Balance After Deposite : " + Blnc);
            }
        }

        public void Amount_Withdrawn()
        {

            Console.WriteLine("Please Enter The Amount You Want To Withdraw : ");
            float Withdrawn_Amount = Convert.ToSingle(Console.ReadLine());


            if (Withdrawn_Amount > Blnc)
            {
                throw (new WithdrawException("Account Balance Are Insufficient"));
            }
            else
            {
                Blnc = Blnc - Withdrawn_Amount;
                Console.WriteLine("Account Balance After Withdraw : " + Blnc);
            }
        }
    }
     class MainClass
    {
        static void Main (string[] args)
        {
            Bank b = new Bank();
            try
            {
                b.Amount_Deposited();
                b.Amount_Withdrawn();

            }
            catch (WithdrawException withExp)
            {
                Console.WriteLine(withExp.Message);
            }
            catch (FormatException forExp)
            {
                Console.WriteLine($"Enter only numbers ", forExp);
            }
            Console.Read();
        }
    }
}
