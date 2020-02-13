using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Shape
    {
        int lenght;
        int width;
        int breadth;
        public void draw()
        {
            Console.WriteLine("a shape csn be drawn");

        }
        public void draw(int l)
        {
            this.lenght = l;
            Console.WriteLine("a square can be drawn");

        }
        public void draw(int l,int w)
        {
            Console.WriteLine("a rectangle can be drawn");
        }
        public void draw(int l, int w,int b)
        {
            Console.WriteLine("a rectangle can be drawn");
        }
        public void draw(int l, int w, int b,string name)
        {
            Console.WriteLine(name+" can be drawn");
        }
    }
}
