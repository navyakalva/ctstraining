using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    class Program
    {
        string name;//instance variable
        static double salary;//static variable
        static void Main(string[] args)
        {
            int i=10;//local variable
            int[] a = new int[4] { 12, 23, 34, 45 };

            Console.WriteLine(i);
            Console.WriteLine(Program.salary);
            Program obj = new Program();
            Console.WriteLine(obj.name);
           
            object o1 = "rahul";
            o1 = 100;
            int k = 100;
            string name = "rohan";
            Console.WriteLine("Name:{0} Age:{1}", name, k);
            Console.ReadKey();


        }
    }
}
