using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("Enter array size");
            t = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[t];
            Console.WriteLine("Enter array values");
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Enter array value of : " + i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array elements are");
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Average of the given array is " + array.Average());
            Console.WriteLine("Maximum number in an array is " + array.Max());
            Console.WriteLine("Minimum number in an array is " + array.Min());

           
            Array a = new Array();
            a.ToString();

            Console.ReadLine();
        }
    }
}

