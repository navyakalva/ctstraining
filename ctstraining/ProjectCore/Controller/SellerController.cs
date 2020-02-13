using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using ProjectCore.Model;


namespace ProjectCore.Model
{
    public class SellerController:Controller
    {
        //SellerInterface selli = new Sellerrep();

        private readonly SellerInterface selli;
        public SellerController(SellerInterface sell)
        {
            selli = sell;
        }

        public string Search()
        {
            Seller sel = selli.GetSeller(1);
            return sel.sid+"\n"+sel.Sname+"\n"+sel.password+"\n"+sel.PostalAddress+"\n"+sel.Email+"\n"+sel.GSTIN1+"\n"+sel.Bankdetails;
        }
    }
}
