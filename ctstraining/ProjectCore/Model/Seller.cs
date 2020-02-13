using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Model
{
    public class Seller
    {
        public int sid;
        string sname;
        public string password;
        string postalAddress;
        string email;
        string GSTIN;
        string bankdetails;
        public int Sid { get => sid; set => sid = value; }
        public string Sname { get => sname; set => sname = value; }
       public string Password { get => password; set => password = value; }

        public string PostalAddress { get => postalAddress; set => postalAddress = value; }
        public string Email { get => email; set => email = value; }

        public string GSTIN1 { get => GSTIN; set => GSTIN = value; }
        public string Bankdetails { get => bankdetails; set => bankdetails = value; }
        

        public Seller(int sid, string sname, string password, string postalAddress, string email, string GSTIN, string bankdetails)
        {
            this.sid = sid;
            this.sname = sname;
            this.password = password;
            this.postalAddress = postalAddress;
            this.email = email;
            this.GSTIN1 = GSTIN;
            this.bankdetails = bankdetails;

        }
    }

}

