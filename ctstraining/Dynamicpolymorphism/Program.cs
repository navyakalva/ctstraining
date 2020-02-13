using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamicpolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //B b = new B();
            //C c = new C();
           // a.display();
           // b.display();
           // c.display();

            A a = new A();
            a.display();
            a = new B();
            a.display();
            a = new C();
            a.display();
            Console.ReadKey();


        }
    }
    
}
