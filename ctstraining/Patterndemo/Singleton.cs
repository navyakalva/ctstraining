using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterndemo
{
    class Singleton
    {
        static int count = 0;
        static Singleton Instance=null;
        public static Singleton getinstance
        {
            get
            {
                if (Instance == null)
                    return new Singleton();
                else
                    return Instance;
            }
        }

        public Singleton()
        {
            count++;
            Console.WriteLine(count);

        }
        public void printdetails(string s)
        {
            Console.WriteLine("printing"+" " + s);
        }
    }
}
