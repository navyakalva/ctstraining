using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "welcome";
            Console.WriteLine(str.Length + " " + str.Replace("e", "k") + " " + str.ToUpper());
            Console.WriteLine(str.Contains("lc"));
            Console.WriteLine(String.Compare("hello", "Hello"));
            string str2 = "navya";
            Console.WriteLine(str.Equals(str2, StringComparison.InvariantCultureIgnoreCase));
            int n = string.Compare("welcome", 3, "come", 0, 4, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(n);
            string input = Console.ReadLine();
            string[] data = input.Split(' ', '/');
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("ram", "300", 20000));
            elist.Add(new Employee("jay", "300", 20000));
            elist.Add(new Employee("ram", "300", 20000));
            elist.Add(new Employee("ram", "300", 20000));




            Console.ReadKey();

        }
    }
}
