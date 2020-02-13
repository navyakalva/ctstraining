using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class BuyerBo
    {

        static List<Buyer> blist = new List<Buyer>();
        public void Signup(int Id, string Name, string Address, string Mail, int Phoneno, string Password, DateTime CreatedDate)
        {
            // List<Buyer> b = new List<Buyer>();
            blist.Add(new Buyer(Id, Name, Address, Mail, Phoneno, Password, CreatedDate));


        }
        public bool Login(int bId, string password)
        {

            Buyer bo = blist.Find(e => e.Id == bId && e.Password == password);
            if (bo != null)
            {

                // bb.InitializeBuyersList(bid, bname, Password, mobile, Email, CreatedDate);
                //Console.WriteLine("success");
                return true;
            }
            else
            {
                // Console.WriteLine("invalid.......SignIn");
                return false;

            }
        }

    }

}

