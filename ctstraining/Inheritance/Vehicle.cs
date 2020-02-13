using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   abstract class Vehicle
    {
        protected string color;
        public  Vehicle()
        {
            this.color = "white";
            Console.WriteLine("constuctor from vehicle");
        }
        public Vehicle(string clr)
        {
            this.color = clr;
            Console.WriteLine("PARAMETER");
        }
        public abstract void fillfuel();
        
        public  virtual void   start()
        {
            Console.WriteLine(" started");
        }
        public void stop()
        {
            Console.WriteLine(" stopped");
        }
    }
    class Bus:Vehicle
    {
        int seating;
        int speed;
        public Bus():base("red")
        {
            this.seating = 80;
            this.speed = 120;
            Console.WriteLine("constuctor from bus");
        }
        public override void fillfuel()
        {
            Console.WriteLine("filled diesel");
        }
        public void run()
        {
            Console.WriteLine(this.color +"bus is running at speed"+this.speed+"with"+this.seating+"passengers");
        }
        public override void start()
        {
            Console.WriteLine("bus started");
        }
       
    }
    class Car:Vehicle
    {
        int speed;
        string type;
        public Car()
        {
            this.speed = 160;
            this.type = "standard";
            Console.WriteLine("constuctor from car");
        }
        public Car(string clr,int spd,string type):base(clr)
        {
            this.speed = spd;
            this.type = type;
        }
        public override void fillfuel()
        {
            Console.WriteLine("filled diesel/petrol/gas");
        }
        public void drive()
        {
            Console.WriteLine(this.color+"car is driving at speed"+this.speed+"type"+this.type);
        }
    }
}