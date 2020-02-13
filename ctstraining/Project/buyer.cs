using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Buyer
    {
        public int id;
        string name;
        string address;
        string mail;
        int phoneno;
        public string password;
        DateTime createddate;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Phoneno { get => phoneno; set => phoneno = value; }
        public string Password { get => password; set => password = value; }
        public DateTime CreatedDate { get; set; }

        public Buyer(int Id, string Name, string Address, string Mail, int Phoneno, string Password, DateTime CreatedDate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Mail = Mail;
            this.Phoneno = Phoneno;
            this.Password = Password;
            this.CreatedDate = CreatedDate;
        }
    }

}
