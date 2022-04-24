using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallindromeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter a string");
            string s = Console.ReadLine();
            string revv = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revv += s[i].ToString();
            }
            if (revv == s)
            {
                Console.WriteLine("Given value is a palindrome");
            }
            else
            {
                Console.WriteLine("Given value is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
