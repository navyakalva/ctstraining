using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter size");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int high, low;
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            high = num[0];
            low = num[0];
            for (int i = 0; i < n; i++)
            {
                if (num[i] > high)
                    high = num[i];
                if (num[i] < low)
                    low = num[i];

            }
            Console.WriteLine(high + "\n" + low);
            Console.ReadKey();
        }
        
    }
}
