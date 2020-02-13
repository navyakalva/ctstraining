using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatedemo
{
    public delegate void delegatePointer();
    public delegate double calAreapointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            //delegatePointer mydelegate = new delegatePointer(print);
            Program p = new Program();
            delegatePointer mydelegate = p.print;
            mydelegate += p.display;
            mydelegate();
            mydelegate -= p.print;
            mydelegate();
            Calculate c = new Calculate();

            calAreapointer cptr = c.calArea;
            double area = cptr(20);
            cptr += Calculate.caldistance;
            Console.WriteLine(area);

            Console.ReadKey();
        }
        public void print()
        {
            Console.WriteLine("welcome to deligate");
        }
        public void display()
        {
            Console.WriteLine("welcome to multicast delegate");
        }
    }
}

