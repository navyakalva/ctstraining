using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsonMVC.Models;

namespace HandsonMVC.Repsitories
{
    public class Userrep
    {
        public static List<User> list = new List<User>()
        {
            new User()
            {
                Name = "Anil",
                Country = "USA",
                Uname = "Anil",
                Password = "12345",}
            };
        public Userrep()
        {

        }
       
        public void Add(User item)
        {
            list.Add(item);//add user data into list
        }
        public User Validate(string uname,string password)
        {
            foreach(var item in list)
            {
                if(item.Uname==uname&&item.Password==password)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
