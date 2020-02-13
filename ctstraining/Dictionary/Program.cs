using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter the count");
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, int> dt = new Dictionary<string, int>();
            string name;
            int sal;
            for (int i=0;i<count;i++)
            {
                Console.WriteLine("emter name of employee");
                name = Console.ReadLine();
                Console.WriteLine("emter salary of employee");
               sal =int.Parse(Console.ReadLine());
                dt.Add(name, sal);

            }
            int hsal = 0;
            string hname="";
            foreach(KeyValuePair<string,int> emp in dt)
            {
                if(emp.Value>hsal)
                {
                    hsal = emp.Value;
                    hname = emp.Key;
                    
                }
            }
            Console.WriteLine("the highest paid emp is" + " " + hname);
            Console.ReadKey();
         }   
    }
}
