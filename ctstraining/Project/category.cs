using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Category
    {
        public int cid;
        public string catname;
       public  string briefdetails;
        
        public int Cid { get => cid; set => cid = value; }
        public string Catname { get => catname; set => catname = value; }
        public string Briefdetails { get => briefdetails; set => briefdetails = value; }

        public Category(int cid, string catname,String briefdetails)
        {
            this.cid = cid;
            this.catname = catname;
            this.briefdetails = briefdetails;
        }
       
           

    }
}
