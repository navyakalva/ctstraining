using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class program1
    {
        static void Main(string[] args)
        {
            SBI s = new SBI("sbi","hyd","abc");
            ICICI ic = new ICICI("icici", "mum", "cde");
            s.Displaydetails();
            s.interest();
            s.ginterest();
            ic.Displaydetails();
            ic.interest();
            ic.ginterest();
            Console.ReadKey();



        }
    }
}
