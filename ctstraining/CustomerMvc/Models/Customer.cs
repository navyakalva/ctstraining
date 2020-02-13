using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CustomerMvc.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
         public int Accounts { get; set; }
        public Customer()
        {

        }
        public Customer(int Id,string Name,string Email,int Accounts)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Accounts = Accounts;
        }

    }
}
