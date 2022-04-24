using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter a string");
             string s1 = Console.ReadLine();
            Console.WriteLine("the given input: " + s1);
            Console.WriteLine("\nEnter a string");
            string s2 = Console.ReadLine();
            string rev = "";
            for (int i = s2.Length - 1; i >= 0; i--)
            {
                rev += s2[i].ToString();
            }
            Console.WriteLine("the reversed string; " + rev);
            Console.ReadLine();
        }
    }
}