using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountsexample
{
    class Accounts
    {
        int actno;
        string name;
        double amount;
        string transtype;
        string acttype;
        int balance;

        public Accounts()
        { }
        public Accounts(int actno, string name, string acttype)
        {
            this.actno = actno;
            this.name = name;
            this.acttype = acttype;
        }
        public void Showdata(double amount)
        {
            Console.WriteLine(this.actno + " " + this.name + " " + this.acttype+" "+this.balance);
            
        }
        public int Credit(double amount)
        {
            this.transtype = "D";
            this.balance +=balance;
            return balance;

        }
        public int Debit(double amount)
        {
            this.transtype = "W";
            this.balance -= balance;
            return balance;
        }
    }
}
