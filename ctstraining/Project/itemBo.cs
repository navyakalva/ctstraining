using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class itemBo
    {
        static List<items> li = new List<items>();
        static List<SubCategory> lsc = new List<SubCategory>();
        public void Additems(int cid, string catname, int sub_id, string sub_name, string briefdetails, float GST, int iid, string itemname, double price, string description, int stock_number, string remarks)
        {
            SubCategory sco = new SubCategory( cid, catname,sub_id, sub_name, briefdetails, GST);
            lsc.Add(sco);
            items i = new items(iid, price, itemname, description, stock_number, remarks);
            li.Add(i);
        }
        public void DisplayProducts()
        {
            foreach (Category i in lsc)
            {
                Console.WriteLine("CategoryId :" + i.cid + "   Category Name :" + i.catname + "  Category Details :" + i.briefdetails);
                //Console.WriteLine( "           "+i.cid + "             " + i.cname + "            " + i.details);
            }
            Console.WriteLine("\n \n Enter Cid to display the Subcategories");
            int ch = int.Parse(Console.ReadLine());
            foreach (SubCategory s in lsc)
            {
                if (s.cid == ch)
                {
                    Console.WriteLine("SubCategory Id :" + s.Sub_id + "  SubCategory Name :" + s.Sub_name + "   SubCategory Desc :" + s.briefdetails); ;
                    // Console.WriteLine("\t"+s.sbid+ " \t  " + s.sbname + " \t" + s.details);
                }
            }
            Console.WriteLine("\n \n Enter subcategory id to display the Items");
            int ch1 = int.Parse(Console.ReadLine());
            foreach (items j in li)
            {
                if (j.iid == ch1)
                {
                    Console.WriteLine("Item Id :" + j.iid + "  IteamNeam  :" + j.itemname + "   stocknumber :" + j.stock_number + "   price :" + j.price + "   remarks :" + j.remarks);
                    //       Console.WriteLine(j.iid+"   " + j.itemname + "   " +j.stock_number +" "+j.price+"  "+j.remarks);
                }
            }
        }

    }
}
