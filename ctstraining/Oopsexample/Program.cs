using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            //std.name = "navi";
            //std.Sem = 4.1f;
            //std.Rollno = 100;
            //std.Acceptstddetails();
            std.Displaystddetails();
            Student std2 = new Student(87, "sumi", "cse", 3.1f, 980) ;
            std2.Displaystddetails();
            Console.ReadKey();
            
        }
    }
}
