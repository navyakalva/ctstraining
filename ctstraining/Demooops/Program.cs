using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demooops
{

    class Program
    {
        static void Main(string[] args)
        {
            Bike enfield = new Bike();
            enfield.Startengine();
            enfield.Fillgas(10);
            int a=enfield.Travel(100, 50);
            Console.WriteLine(a);
            Console.ReadKey();


        }
    }
}
