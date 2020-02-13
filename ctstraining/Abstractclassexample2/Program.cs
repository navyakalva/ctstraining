using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassexample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.undergraduate\n 2.graduate");
            Console.WriteLine("enter menu");
            int menu = int.Parse(Console.ReadLine());
            if(menu==1)
            {
                Console.WriteLine("enter grade");
                int grade = int.Parse(Console.ReadLine());
                ug g = new ug();
                g.ispassed(grade);

            }
            else
            {
                Console.WriteLine("enter grade");
                int grade = int.Parse(Console.ReadLine());

                g g1 = new g();
                g1.ispassed(grade);
            }

            Console.ReadKey();
        }
    }
}
