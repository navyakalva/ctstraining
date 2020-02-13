using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsArray
{
    class Search
    {
        static void Main()
        {
            string[] name = new string[5]
            {
                "aaaa",
                "bbbb",
                "cccc",
                "dddd",
                "eeee",

            };
           for(int a=0;a<4;a++)
            {

                string m = Console.ReadLine(name[a]);
                if(name=m)
                    Console.WriteLine("present");
                else
                    Console.WriteLine("absent");

            }
            Console.ReadKey();
        }
        
       
            
    }
}
