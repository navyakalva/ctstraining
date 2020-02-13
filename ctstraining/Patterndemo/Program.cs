using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterndemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s1 = new Singleton();
            Singleton s1 = Singleton.getinstance;
            s1.printdetails("HI");
            //Singleton s2 = new Singleton();
            Singleton s2 = Singleton.getinstance;
            s2.printdetails("welcome");
            Console.ReadKey();

        }
    }
}
