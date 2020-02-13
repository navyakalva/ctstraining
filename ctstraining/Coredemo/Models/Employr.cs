using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coredemo.Models
{
    public class Employr:Interface
    {
        private List<Employ> emp;
        public Employr()
        {
            emp = new List<Employ>() { new Employ ( 1, "navya","navi@gmail.com",Dept.Insurance),
           new Employ ( 2, "mani","mani@gmail.com",Dept.Healthcare),
            new Employ ( 3, "anil","anil@gmail.com",Dept.Accounts) };
        }
        public Employ GetEmploy(int id)
        {
            Employ e = emp.FirstOrDefault(e => e.Id == id);
            //foreach(Employ X in emp)
            //{
            //    if (X.Id == id) return X;

            return e;
        }
        public List<Employ>DisplayDetails()
        {
            return emp;
        }
        public bool AddEmploy(Employ empl)
        {
            empl.Id = emp.Max(e => e.Id) + 1;
            emp.Add(empl);
            return true;
        }
    }
}
