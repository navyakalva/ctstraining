using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMvc.Models
{
    public class SubCategory:Category
    {
        [Key]
        private int Sub_id { get; set; }
        private string Sub_name { get; set; }
        private float GST { get; set; }

        
        public SubCategory(int Cid, string Catname, int Sub_id, string Sub_name, string Briefdetails, float GST) : base(Cid, Catname, Briefdetails)
        {
            this.Sub_id = Sub_id;
            this.Sub_name = Sub_name;
            this.Cid = Cid;
            this.Catname = Catname;
            this.Briefdetails = Briefdetails;
            this.GST = GST;

        }
    }
}
