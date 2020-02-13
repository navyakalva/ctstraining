using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhismexample
{
    class Delivery
    {
        public void displaydetails(string bowler, string batsman)
        {
            Console.WriteLine("bowler"+" " + bowler + " " +"batsman"+" "+ batsman);
        }
        public void displaydetails(long runs)
        {
           
            if (runs == 6)
            {
                Console.WriteLine("six");
                
            }
            else if (runs == 4)
            {
                Console.WriteLine("four");
                
            }
            else
                Console.WriteLine(runs);

        }
        
    }
}
