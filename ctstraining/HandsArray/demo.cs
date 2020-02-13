using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsArray
{
    class demo
    {
        static void Main()
        {
            int[] a = new int[5] { 10, 3, 4, 6, 8 };
            int sum = 0;
            foreach (int k in a)
            {
                sum = sum + k;

                Console.WriteLine(sum);

                if(k%2==0)
                {
                    Console.WriteLine(k);//print eeven values
                }
            }
            Console.ReadKey();
        }
    }
}
