using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentoops
{
    class Student
    {
        static string colname="crr";
        int rollno;
        string name;
        int year;
        int sem;
        string branch;
        int[] marks = new int[5];
        public Student()
        { }
        public Student(int rollno,string name,int year,int sem,string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.year = year;
            this.sem = sem;
            this.branch = branch;

        }
        public void Displaydata()
        {
            Console.WriteLine(this.rollno + " " + this.name + " " + this.year + " " + this.sem + " " + this.branch);
        }
        public void Displayresult(int[] marks)
        {
            int sum = 0;
            int flag=0;
            for(int i=0;i<5;i++)
            {
               sum += marks[i];
            }
            float avg = sum / 5;

            Console.WriteLine("avg is "+avg);
            for (int i = 0; i <5; i++)
            {
                if (marks[i] < 50 || avg < 50)
                {
                    flag = 0;
                }
                else
                    flag = 1;
            }

                if (flag == 0)

                    Console.WriteLine("fail");
                else
                    Console.WriteLine("pass");



            
            
        }
       
            

             
    }
}
