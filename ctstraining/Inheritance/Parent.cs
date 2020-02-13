using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Parent
    {
       protected internal int a;
       protected string b;

        public int A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }

        public void Getvalues(int x,string y)
        {
            this.A = x;
            this.B = y;
        }

        public void Display()
        {
            Console.WriteLine(this.A + " " + this.B);
        }
    }
    class Child:Parent
    {
       protected int c;
        public void Calculate(int num)
        {
           
            c = this.a + num;
            Console.WriteLine(c);
        }
    }
    class Grandchild:Child
    {
        int d;
        public void Multiply(int num2)
        {
            this.d = num2;
            Console.WriteLine(this.d * this.c * this.a);
        }
    }

}
namespace Demoprotected
{
    class Exchild : Inheritance.Parent
    {
        public void Exdisplay()
        {
            Console.WriteLine(this.a + " " + this.b);
        }
    }

}
