using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger pa = new Passenger("chandu", 25);
            Console.WriteLine("Enter noof tickets");
            int no_of_tickets = int.Parse(Console.ReadLine());
            pa.TicketBooking(no_of_tickets);
            Console.ReadLine();
        }
    }
    public class TicketException : Exception
    {
        public TicketException(string s) : base(s)
        {

        }

    }
}
    

