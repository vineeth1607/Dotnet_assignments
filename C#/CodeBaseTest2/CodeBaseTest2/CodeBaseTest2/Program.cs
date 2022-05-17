using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseTest2
{
    class Program
    {

        public delegate void calculator(int x, int y);

         class Programm
        {
            public static void addition(int x, int y)
            {
                int res = x + y;
                Console.WriteLine($"result of addition : {res}");
            }
            public static void substraction(int x, int y)
            {
                int res = x - y;
                Console.WriteLine($"result of substraction : {res}");
            }
            public static void multiplication(int x, int y)
            {
                int res = x * y;
                Console.WriteLine($" result of multiplication : {res}");
            }
            public static void division(int x, int y)
            {
                int res = x / y;
                Console.WriteLine($" result of division : {res}");
            }
            static void Main(string[] args)
            {
                calculator obj = new calculator(Programm.addition);
                obj.Invoke(30, 40);
                obj = substraction;
                obj(30, 10);
                obj = multiplication;
                obj(20, 30);
                obj = division;
                obj(40, 20);
                Console.ReadLine();
            }
        }
    }
}