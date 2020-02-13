using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMvc.Models
{
    public class Category
    {
        [Key]
        public int Cid { get; set; }
        public string Catname { get; set; }
        public string Briefdetails { get; set; }


        public Category(int Cid, string Catname, String Briefdetails)
        {
            this.Cid = Cid;
            this.Catname = Catname;
            this.Briefdetails = Briefdetails;
        }


    }
}
