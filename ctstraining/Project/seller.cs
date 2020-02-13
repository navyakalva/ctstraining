namespace Project
{
    class Seller
    {
        private int sid;
        string sname;
        public string password;
        
        string postalAddress;
       
        string email;
        string GSTIN;
        string bankdetails;


        public string Sname { get => sname; set => sname = value; }
        
        
       
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string PostalAddress { get => postalAddress; set => postalAddress = value; }
      
        public int Sid { get => sid; set => sid = value; }
        public string Bankdetails { get => bankdetails; set => bankdetails = value; }
        public string GSTIN1 { get => GSTIN; set => GSTIN = value; }

        public Seller(int sid, string sname, string password,  string postalAddress,  string email,string GSTIN ,string bankdetails)
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


