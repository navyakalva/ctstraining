using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorydemo
{
    interface Ifactory
    {
        void manufacture(int cnt);
    }
    class bike:Ifactory
    {
       public void manufacture(int cnt)
        {
            Console.Write("bike manufacturing" + cnt);
        }
    }
    class car:Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.Write("bike manufacturing" + cnt);
        }
    }
    abstract class Vehiclefactory
    {
        public abstract void generatevehicle(int cnt);
    }
    class Concretevehiclefactory:Vehiclefactory
    {
        public override  void generatevehicle(string type)
        {
            switch (type)
            {
                case "Bike":
                    new bike();
                    break;
                case "car":
                    new car();
                    break;
                
            }

        }
    }
}
