using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountsexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter acc no");
            int actno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter account name");
            string name  = (Console.ReadLine());
            Console.WriteLine("enter account type");
            string type =(Console.ReadLine());
            Accounts ac = new Accounts(actno, name,type);
            Console.WriteLine("enter trans type");
            string trans = Console.ReadLine();
            if(trans=="D"||trans=="d")
            {
                Console.WriteLine("enter amount to deposit");
                double amount = Double.Parse(Console.ReadLine());
                ac.Credit(amount);
               
            }

            if (trans == "W" || trans == "w")
            {
                Console.WriteLine("enter amount to withdraw");
                double amount = Double.Parse(Console.ReadLine());
                ac.Debit(amount);

            }
            ac.Showdata(500);
            Console.ReadKey();


        }
    }
}
