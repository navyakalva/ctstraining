using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface

{
    interface loan
    {
        void interest();
    }
    interface gloan : loan
    {
        void ginterest();
    }
   public  abstract class Bank
    {
        protected string name;
        protected string location;
        public Bank(string name,string location)
        {
            this.name = name;
            this.location = location;
        }
        public abstract void Displaydetails();
    }
    public class SBI : Bank,loan
    {
        string manager;
        public SBI(string name,string location,string manager):base(name,location)
        {
            this.manager = manager;
        }
        public override void Displaydetails()
        {
            Console.WriteLine(this.name + " " + this.location + " " + this.manager);
        }
        public void interest()
        {
            Console.WriteLine("sbi interest is 12%");
        }
        public void ginterest()
        {
            Console.WriteLine("sbi ginterest is 12%");
        }
    }
    public class ICICI :Bank,loan,gloan
    {
        string head;
        public ICICI(string name, string location,string head):base(name, location)
        {
            this.head = head;
        }
        public override void Displaydetails()
        {
            Console.WriteLine(this.name + " " + this.location + " " + this.head);
        }
        public void interest()
        {
            Console.WriteLine("icici interest is 12%");
        }
        public void ginterest()
        {
            Console.WriteLine("icici ginterest is 12%");
        }
    }
}
