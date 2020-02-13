using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeinstance
{
    class Employee
    {
        public string empid;
        public string emp_name;
        public string empdesign;
        public Employee(string empid, string emp_name, string empdesign)
        {
            this.empid = empid;
            this.emp_name = emp_name;
            this.empdesign = empdesign;
        }
        public override string ToString()
        {
            return this.empid + this.emp_name + this.empdesign;
        }

    }

}

