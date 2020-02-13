using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SellerBo
    {
        static List<Seller> slist = new List<Seller>();
        public void Signup(int sid, string sname, string password,  string postalAddress,  string email, string GSTIN,string bankdetails)
        {
            // List<Buyer> b = new List<Buyer>();
            slist.Add(new Seller(sid, sname, password, postalAddress, email,GSTIN,bankdetails));


        }
       
        public bool Login(int bId, string password)
        {

            Seller so = slist.Find(e => e.Sid == bId && e.password == password);
            if (so != null)
            {


                //Console.WriteLine("success");
                return true;
            }
            else
            {
                // Console.WriteLine("invalid.......SignIn");
                return false;

            }
        }
        public void DisplayDetails(int sid, string spassword, string sname, string email, string postalAddress, string GSTIN, string Bankdetails)
        {
            Console.WriteLine("Details...............");
            Console.WriteLine("Id : " + sid);
            Console.WriteLine("Name : " + sname);
            Console.WriteLine("Email  : " + email);
            Console.WriteLine("Company address : " + postalAddress);
            Console.WriteLine("GSTIN : " + GSTIN);
            Console.WriteLine("Bank Details  : " + Bankdetails);

        }

    }
}
