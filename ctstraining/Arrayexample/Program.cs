using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayexample
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter size");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];


            if (n % 2 == 0)
                Console.WriteLine("print odd number");
            else
            {
                
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                int k = a[0];
                if (n == 1)
                    Console.WriteLine(a[0]);
                if (a[0] > a[n / 2] && a[0] > a[n - 1])

                    Console.WriteLine("highest is " + a[0]);
                else
                {
                    if (a[n / 2] > a[0] && a[n / 2] > a[n - 1])
                        Console.WriteLine("highest is" + a[n / 2]);
                    else
                        Console.WriteLine("highest is" + a[n - 1]);
                }

            }
            Console.ReadKey();

        }
    }
}
