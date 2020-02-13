using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Coredemo.Models
{
    public class Employ
    {
       
        public int Id { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="Length can be max 10")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Invalid")]
        [Validatedomain(allowDomain:"cts.com")]
        [Remote(action:"IsEmailExist",controller:"Employ")]
        public string Email { get; set; }
        public Dept dept { get; set; }

        //public enum Dept
        //{
        //    IT=0,Accounts=1,Insurance=2,HealthCare=3
        //}

        public Employ()
        {

        }
        public Employ(int Id, string Name, string Email, Dept dept)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.dept = dept;
        }

    }
}
