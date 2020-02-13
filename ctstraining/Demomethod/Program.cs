using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demomethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int result =cal.Add(x, y);
            cal.Sub(x, y,out int res);
            Console.WriteLine(res);
            Console.WriteLine(result);
            cal.Swap(ref x, ref y);
            Console.WriteLine(x + " " + y);
            Console.ReadKey();
        }
    }
}
