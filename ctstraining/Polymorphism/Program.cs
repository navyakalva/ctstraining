using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape pic = new Shape();
            pic.draw();
            pic.draw(10);
            pic.draw(10, 20);
            pic.draw(12, 23, 12);
            pic.draw(1, 1, 1, "cube");
            Console.ReadKey();

        }
    }
}
