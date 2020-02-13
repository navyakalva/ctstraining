using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coredemo.Models
{
   public interface Interface
    {
        Employ GetEmploy(int id);
        List<Employ> DisplayDetails();
        bool AddEmploy(Employ empl);
    }
}
