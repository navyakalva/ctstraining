using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter rollno");
           int  rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = (Console.ReadLine());
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter sem");
            int sem = int.Parse(Console.ReadLine());
            Console.WriteLine("enter branch");
           string branch =(Console.ReadLine());
            int[] marks = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("enter marks for subject" + (i+1));
                marks[i] =int.Parse( Console.ReadLine());
            }
            Student std = new Student(rollno,name,year,sem,branch);
            std.Displayresult(marks);
            std.Displaydata();
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter rollno");
           int  rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = (Console.ReadLine());
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter sem");
            int sem = int.Parse(Console.ReadLine());
            Console.WriteLine("enter branch");
           string branch =(Console.ReadLine());
            int[] marks = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("enter marks for subject" + (i+1));
                marks[i] =int.Parse( Console.ReadLine());
            }
            Student std = new Student(rollno,name,year,sem,branch);
            std.Displayresult(marks);
            std.Displaydata();
            Console.ReadKey();
        }
    }
}
