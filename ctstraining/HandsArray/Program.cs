using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[4];//decleration
            i[0] = 1;//assign value
            i[1] = 2;
            i[2] = 3;
            i[3] = 4;
            int k = i[2];
            //display at location
            Console.WriteLine(i[1]);
            //display values
            for(int a=0;a<4;a++)
            {
                Console.WriteLine(i[a]);
            }
            foreach(int b in i)
           {
                Console.WriteLine(b);
            }

            Console.ReadKey();


        }
    }
}
