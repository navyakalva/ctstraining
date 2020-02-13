using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SubCategory:Category
    {
        private int sub_id;
        private string sub_name;
        private float gST;

        public int Sub_id { get => sub_id; set => sub_id = value; }
        public string Sub_name { get => sub_name; set => sub_name = value; }
        public float GST { get => gST; set => gST = value; }

        public SubCategory(int cid, string catname, int sub_id, string sub_name, string briefdetails, float GST):base(cid,catname,briefdetails)
        {
            this.Sub_id = sub_id;
            this.Sub_name = sub_name;
            this.cid = cid;
            this.catname = catname;
            this.briefdetails = briefdetails;
            this.GST = GST;

        }
    }
}
