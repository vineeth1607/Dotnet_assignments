using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    internal class Car
    {
        int car_no;
        string car_name;
        string car_type;
        readonly double cost = 700000;
        public Car(int car_no, string car_name, string car_type, double cost)
        {
            this.car_no = car_no;
            this.car_name = car_name;
            this.car_type = car_type;
            this.cost = cost;
            Console.WriteLine($"car_number :{car_no},car_name : {car_name},car_type :{car_type},cost : {cost} ");
        }
        public void showDetails()
        {
            Console.WriteLine("before changing the car ");
            Console.WriteLine($"car_number : {car_no},car_name: {car_name},car_type: {car_type},cost :{cost} ");
        }
        public Car(double car_cost)
        {
            Console.WriteLine("after changing the car");
            Console.WriteLine($"car_number : {car_no},car_name:{car_name},car_type:{car_type},cost :{cost} ");
            Console.ReadLine();

        }

            public static void Main(string[] args)
            {

                Car car = new Car(8888, "XUV", "sports", 60001000);
                car.showDetails();
                Car car2 = new Car(999,"SUV","Sports",30000000);
                Console.ReadLine();
            }
        }
    }