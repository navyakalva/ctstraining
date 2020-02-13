using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
            long l2 = 12500;
            int i2 = (int)l2;
            int i = 256;
            byte b1 = (byte)i;
            Console.WriteLine("values:{0} value2{1}",i2, b1);
            Console.ReadKey();
        }
    }
}
