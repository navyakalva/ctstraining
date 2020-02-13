using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexample
{
    interface istudent
    {
        int sid { get; set; }
        string name { get; set; }
        void showdetails();
    }
    class resident : istudent
    {
        int sid;
        string name;
        int istudent.sid { get { return sid; } set { sid = value; } }
        string istudent.name { get { return name; } set { name = value; } }

        public resident(int id, string name)
        {
            this.sid = id;
            this.name = name;
        }
        public void showdetails()
        {
            Console.WriteLine(this.name + " " + this.sid);
        }
    }
    class dayscholar : istudent
    {
        int sid;
        string name;
        int istudent.sid { get { return sid; } set { sid = value; } }
        string istudent.name { get { return name; } set { name = value; } }

        public dayscholar(int id, string name)
        {
            this.sid = id;
            this.name = name;
        }
        public void showdetails()
        {
            Console.WriteLine(this.name + " " + this.sid);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dayscholar");
            string name = Console.ReadLine();
            int sid = int.Parse(Console.ReadLine());
            dayscholar ds = new dayscholar(sid,name);

            Console.WriteLine("Resident");
            string name1 = Console.ReadLine();
            int sid1 = int.Parse(Console.ReadLine());
            resident rs = new resident(sid1, name1);
            ds.showdetails();
            rs.showdetails();
            Console.ReadKey();




        }
    }
}
