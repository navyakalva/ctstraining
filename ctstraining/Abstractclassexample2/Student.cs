using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclassexample2
{
    
    
        public abstract class student
        {
            string name;
            int stdid;
            int grade;
            public abstract Boolean ispassed(int grade);
           

        }
        class ug : student
        {

        public override bool ispassed(int grade)
        {
            if (grade > 70)
            {
                Console.WriteLine("passed");
                return true;
            }
            else
                return false;
        }

              
        }
        class g:student
        {
            public override bool ispassed(int grade)
            {
            if (grade > 0)
            {
                Console.WriteLine("passed");
                return true;
            }
            else
                return false;
            }

        }
               
            
        
    
}
