using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsexample
{
    class Student
    {
        
       private int rollno;
       public string name{ get; set; }
        float sem;
        string branch;
        int marks;
        public int  Rollno
        {
            get
            {
                return rollno;
            }
            set
            {
                rollno = value;
            }
        }
        public float Sem
        {
            get
            {
                return sem;
            }
            set
            {
                sem = value;
            }
        }
       
        public int Marks
        {
            get
            {
                return marks;
            }
            
        }
        public string Branch
        {
            get
            {
                return branch;
            }
            set
            {
                branch = value;
            }
        }
        public Student()//default constructor
        {
            sem = 3;
            branch = "cse";
            rollno = 67;
            marks = 100;
            name = "navya";

         }
        public Student(int rollno, string name,string branch,float sem,int marks)
        {
           this. name = name;
            this.rollno = rollno;
           this. branch = branch;
           this. sem = sem;
            this.marks = marks;
        }
        public void Acceptstddetails()
        {
           Console.WriteLine("enter marks");
            marks = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the branch");
            branch =Console.ReadLine();
            Console.WriteLine("student details are accepted");
        }
        public void Displaystddetails()
        {
            Console.WriteLine(name + "\n" + rollno + "\n" + sem + "\n" + branch + "\n" + marks);
            Console.WriteLine("student details are displayed");
        }
    }
}
