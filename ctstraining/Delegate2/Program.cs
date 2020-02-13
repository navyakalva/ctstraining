using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    public delegate double calAreapointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            calAreapointer cptr = new calAreapointer(calArea);
            calAreapointer cptr1 = new calAreapointer(delegate (double r) { return 3.14 * r * r; });//anonymous method



            double area = cptr(12);
            Console.WriteLine(area);

            //above code can be simplified with lambda
            calAreapointer cptr2 = (r => 3.14 * r * r);
            double real = cptr1(10);
            Console.WriteLine(real);

            //prebuild delegats Func<>,Action<>,Predicate<>

            Func<double, double> f1 = (r => 3.14 * r * r);
           double area2 = f1(14);
           Console.WriteLine(area2);

            Action<string> act = (x => Console.WriteLine(x));
            act("welcome");

            Predicate<string> pt = (y => y.Length > 3);
            Console.WriteLine(pt("cts"));

            //methods which are using built in delegats

            int[] array = new int[] { 1, 2, 3, 4 };
            List<string> names = new List<string>();
            names.Add("anil");
            names.Add("mani");
            names.Add("navya");
            int b = array.Count(x => x>1);
             Console.WriteLine(b);

            List<string> sn = names.FindAll(y => y.Contains('l'));
            foreach(string n in sn)
            {
                Console.WriteLine(n);
            }






            Console.ReadKey();
        }
        public static double calArea(double r)
        {
            return 3.14 * r * r;
        }
    }
}
