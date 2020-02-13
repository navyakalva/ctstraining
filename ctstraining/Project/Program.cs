using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyerBo buyer = new BuyerBo();
            SellerBo seller = new SellerBo();
             itemBo item = new itemBo();
            while (true)
            {
                Console.WriteLine("MENU" + "\n" + "1.Buyer" + "\n" + "2.Seller" + "\n" + "3.Admin");
                Console.WriteLine("enter choice");
                int choice = int.Parse(Console.ReadLine());
                bool status = true;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1.Login" + "\n" + "2.Register");
                        Console.WriteLine("enter choice");

                        int ch = int.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("enter id");
                                int bId = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter password");
                                string password = Console.ReadLine();
                                status = buyer.Login(bId, password);
                                if (status == false)
                                    Console.WriteLine("invalid.......SignIn");
                                break;
                            case 2:
                                Console.WriteLine("enter id");
                                int Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter  the name  :");
                                string Name = Console.ReadLine();
                                Console.WriteLine("Enter  the address :");
                                string Address = Console.ReadLine();
                                Console.WriteLine("enter mail:");
                                string Mail = Console.ReadLine();
                                Console.WriteLine("Enter mobile number");
                                int Phoneno = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter password:");
                                string Password = Console.ReadLine();
                                Console.WriteLine("Dateof Creation:");
                                DateTime CreatedDate = Convert.ToDateTime(DateTime.Now);
                                Console.WriteLine(CreatedDate);
                                buyer.Signup(Id, Name, Address, Mail, Phoneno, Password, CreatedDate);

                                break;
                            default:
                                Console.WriteLine("invalid number");
                                break;

                        }
                        if (status == false)
                            break;
                        //Console.WriteLine("*****Product Details*****");
                        //Console.WriteLine("1.Electronics" + "\n" + "2.fashion" + "\n" + "3.furniture" + "\n" + "4.books");
                        //Console.WriteLine("Enter Category :");
                        //int op = int.Parse(Console.ReadLine());
                        //switch (op)
                       // {
                         //   case 1:
                          //      //items.elist();
                           //     break;
                           // default:
                            //    Console.WriteLine("invalid");
                            //    break;
                        //}
                        break;
                    case 2:
                        Console.WriteLine("1.login" + "\n" + "2.register");
                        Console.WriteLine("enter choice");

                        int ch1 = int.Parse(Console.ReadLine());
                        switch (ch1)
                        {
                            case 1:
                                Console.WriteLine("enter id");
                                int sId = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter password");
                                string password = Console.ReadLine();
                                status = seller.Login(sId, password);
                                if (status == false)
                                    Console.WriteLine("invalid.......SignIn");
                                break;
                            case 2:
                                Console.WriteLine("enter id");
                                int sid = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter  the name  :");
                                string sname = Console.ReadLine();
                                Console.WriteLine("enter password:");
                                string spassword = Console.ReadLine();
                                Console.WriteLine("enter company name:");
                                string companyname = Console.ReadLine();
                                Console.WriteLine("Enter  the address :");
                                string postalAddress = Console.ReadLine();
                                Console.WriteLine("enter GSTIN:");
                                string GSTIN = Console.ReadLine();
                                Console.WriteLine("enter mail:");
                                string email = Console.ReadLine();
                                Console.WriteLine("Enter bank details");
                                string bankdetails = Console.ReadLine();
                                Console.WriteLine("Dateof Creation:");
                                DateTime CreatedDate = Convert.ToDateTime(DateTime.Now);
                                Console.WriteLine(CreatedDate);
                                seller.Signup(sid, sname, spassword, postalAddress, email, GSTIN , bankdetails );

                                
                                
                                break;
                                
                                          default:
                                          Console.WriteLine("invalid number");
                                          break;
                        }
                        if (status == false)
                            break;
                       
                        Console.WriteLine("----------------Seller Activities--------------------");
                        Console.WriteLine(" 1.Add Items \n2.View items\n Enter Your option :");
                        int opt2 = int.Parse(Console.ReadLine());
                        switch (opt2)
                        { 
                        
                            case 1:
                                Console.WriteLine("Enter The Items by category and sub-Category  :");
                                Console.WriteLine("Enter item Category id :");
                                int cid = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter item Category Name :");
                                string cname = Console.ReadLine();
                                Console.WriteLine("Enter item sub-Category id :");
                                int sbid = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter item sub-Category Name :");
                                string sbname = Console.ReadLine();
                                Console.WriteLine("Enter item Details :");
                                string details = Console.ReadLine();
                                Console.WriteLine("Enter the GST percentage on Category  :");
                                float GST = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter item id :");
                                int iid = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter item  Name :");
                                string itemname = Console.ReadLine();
                                Console.WriteLine("Enter item price :");
                                double price = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter the item description :");
                                string description = Console.ReadLine();
                                Console.WriteLine("Enter stock number :");
                                int stock_number = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Remarks:");
                                string remarks = Console.ReadLine();
                                item.Additems(cid, cname, sbid, sbname, details, GST, iid, itemname, price, description, stock_number, remarks);
                                
                                break;
                           case 2:
                                item.DisplayProducts();
                                break;
                        }
                    


                        break;

                }


            }

        }
    }
}

    

