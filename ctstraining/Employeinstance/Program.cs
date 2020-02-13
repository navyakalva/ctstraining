using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeinstance
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char ch1;
            List<Employee> l = new List<Employee>();
            do
            {
                Console.WriteLine("menu");
                Console.WriteLine("1.insert employee details");
                Console.WriteLine("2.display all employee details");
                Console.WriteLine("3.update employee details");
                Console.WriteLine("4.delete a specific employee whos id is given");
                Console.WriteLine("enter option");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    Console.WriteLine("enter size");
                    int size = int.Parse(Console.ReadLine());
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("enter empname,empid,empdesign");
                        string empid = Console.ReadLine();
                        string emp_name = Console.ReadLine();
                        string empdesign = Console.ReadLine();
                        l.Add(new Employee(empid, emp_name, empdesign));
                    }
                }
                else if (ch == 2)
                {
                    foreach (Employee x in l)
                        Console.WriteLine(x.ToString());
                }
                else if (ch == 3)
                {
                    Console.WriteLine("enter employee id to update details");
                    string s = Console.ReadLine();
                    Console.WriteLine("enter name,designation to update");
                    string s1 = Console.ReadLine();
                    string s2 = Console.ReadLine();

                    foreach (Employee c in l)
                    {
                        if (c.empid == s)
                        {
                            c.emp_name = s1;
                            c.empdesign = s2;
                        }
                    }

                    foreach (Employee x in l)
                        Console.WriteLine(x.ToString());
                }
                else if (ch == 4)
                {
                    Console.WriteLine("enter employee id to delete");
                    string s = Console.ReadLine();

                    foreach (Employee c in l)
                    {
                        if (c.empid == s)
                        {
                            l.Remove(c);
                        }
                    }
                }
                else
                    Environment.Exit(0);
                Console.ReadKey();
                Console.WriteLine("enter y to continue");
                ch1 = char.Parse(Console.ReadLine());
            } while (ch1 == 'y');
        }
    }
}

