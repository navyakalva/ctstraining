using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent pobj = new Parent();
           // Child cobj = new Child();
           // Grandchild gobj = new Grandchild();
           // pobj.Getvalues(12, "ch");
          //  pobj.Display();
           // cobj.Getvalues(23, "asp.net");
            //cobj.Display();
            //cobj.Calculate(30);
            //gobj.Getvalues(30, "asp.netcore");
           // gobj.Display();
           // gobj.Calculate(20);
            //gobj.Multiply(30);
           // Vehicle v = new Vehicle();
            Car c = new Car("blue",150,"premium");
            Bus b = new Bus();
            //v.start();
          //  v.stop();
            c.start();
            c.drive();
            c.stop();
            c.fillfuel();
            b.start();
            b.stop();
            b.run();
            b.fillfuel();
            Console.ReadKey();
        }
    }
}



