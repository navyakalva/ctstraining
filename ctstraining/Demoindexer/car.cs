using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoindexer
{
    class car
    {
        int year;
        string[] name = new string[4];
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public string this[int x]
        {
            get
            {
                return name[x];
            }
            set
            {
                name[x] = value;
            }
        }
        public void display()
        {
            foreach(string val in name)
            Console.WriteLine(val);
        }
        //public string[]  Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}
    }
}
