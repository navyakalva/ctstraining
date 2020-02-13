using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhismexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery d = new Delivery();
            long runs;
            
            Console.WriteLine("1.player details\n2.runs details");
            Console.WriteLine("enter choice");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("enter names of bowler,batsman");
                string bowler = (Console.ReadLine());
                string batsman = Console.ReadLine();
                d.displaydetails(bowler, batsman);
            }
            else if (choice == 2)
            {
                Console.WriteLine("enter number of runs");
                runs = int.Parse(Console.ReadLine());
                d.displaydetails(runs);
            }
            else
            {
                
                Console.WriteLine("invalid");
            }
                
                Console.ReadKey();

        }
    }
}
