
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest1
{
    internal class Program
    {
        class Passenger
        {
            public String name { get; set; }
            public int age { get; set; }
            public String dateOfTravell { get; set; }
            public  Passenger (String name , int age ,String dateOfTravell, int noOfTickets )
            {
                this.name = name;
                this.age = age;
                this.dateOfTravell = dateOfTravell;
                
                

            }
            public static void TicketBooking (int noOfTickets)
                {
                noOfTickets = noOfTickets;
                Console.WriteLine("Tickets booked successfully");
            }
        }

        public class Ticket
            {
            public int noOfTickets
            {
                get => noOfTickets;
                set
                {
                    if (value > 5)
                        throw new Exception("Can not book more than 5 tickets");
                    noOfTickets = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Passenger pass = new Passenger ("Vineeth", 23, "05/05/2022",2);
            Console.WriteLine("Enter the No.of tickets you want to book");
            pass.TicketBooking(int.Parse(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
