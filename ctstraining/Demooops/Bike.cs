using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demooops
{
    class Bike
    {
        string name;
        string color;
        //public void Setdetails(string name,string color)
        //{ }
        public void Startengine()
        {
            Console.WriteLine("bike started at " + DateTime.Now.Hour);
        }
        public void Fillgas(int litre)
        {
            Console.WriteLine("bike filled with" + litre + "litres");
        }
        public int Travel(int distnce,int speed)
        {
            int time = (int)(distnce / speed);
            Console.WriteLine("you will reach your destination" );
            return time;
        }

    }
}
