using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket
{
    class Passenger
    {
        string name;
        int age;
        public Passenger(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void TicketBooking(int no_of_tickets)
        {
            try
            {
                if (no_of_tickets > 2)
                    throw new TicketException("cannot book more than 2");
                else
                    Console.WriteLine("Tickets booked Successfully");
            }
            catch (TicketException t)
            {
                Console.WriteLine(t.Message + " " + t.StackTrace);
            }
        }
    }
}
