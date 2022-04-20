using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Two integer are equal");
            }
            else
            {
                Console.WriteLine(" Two integer are not equal");
            }

            int number;
            Console.WriteLine("Enter the number to check whether it is positive or negative");
            number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Given number is positive");
            }
            else
            {
                Console.WriteLine("Given number is negative");
            }

            int number1, number2, result;
            char operation;
            Console.WriteLine("Enter the first number :");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number :");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("choose the operation");
            Console.WriteLine("1 addition");
            Console.WriteLine("2 subtraction ");
            Console.WriteLine("3 multiplication");
            Console.WriteLine("4 division");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    result = number1 + number2;
                    Console.WriteLine("The addition of two numbers is : {0}", result);
                    break;
                case '2':
                    result = number1 - number2;
                    Console.WriteLine("The subtraction of two numbers is : {0}", result);
                    break;
                case '3':
                    result = number1 * number2;
                    Console.WriteLine("the multiplication of two numbers is : {0}", result);
                    break;
                case '4':
                    result = number / number2;
                    Console.WriteLine("The division of two numbers is : {0}", result);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }

            Console.ReadLine();

        }
    }
}
