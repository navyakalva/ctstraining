using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Model
{
    public class Sellerrep:SellerInterface
    {
        private List<Seller> sel;
        public Sellerrep()
        {
            sel = new List<Seller>() { new Seller(1,"navya","navya","tenali","navya@gmail.com","seventy","hdfc"),
                 new Seller(2,"mani","mani","tenali","navya@gmail.com","seventy","hdfc"),
                  new Seller(3,"anil","anil","tenali","navya@gmail.com","seventy","hdfc")};
        }
        public Seller GetSeller(int sid)
        {
            Seller e = sel.FirstOrDefault(e => e.Sid == sid);
            //foreach(Seller X in sel)
            //{
            //    if (X.Sid == sid) return X;

            return e;
        }

    }
}
