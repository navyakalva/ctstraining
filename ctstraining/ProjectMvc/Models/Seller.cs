using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMvc.Models
{
    public class Seller
    {
       [Key]
        [Required(ErrorMessage = "enter the id")]
        [DisplayName("Seller Id")]
        public int Sid { get; set; }

        [Required(ErrorMessage = "enter the Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name should be between the length")]
        public string Sname { get; set; }
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "invlaid")]
        public string Password { get; set; }
        public string PostalAddress { get; set; }
        [Required(ErrorMessage = "enter email")]
        [EmailAddress(ErrorMessage = "invalid email id")]
        public string Email { get; set; }
        public string Website { get; set; }
        public string Companyname { get; set; }
        public string Bankdetails { get; set; }
        public string PhotoPath { get; set; }
        public Seller()
        { }

       

        public Seller(int Sid, string Sname, string Password, string PostalAddress, string Email, string Website,string Companyname, string Bankdetails,string PhotoPath)
       {
            this.Sid = Sid;
            this.Sname = Sname;
            this.Password = Password;
            this.PostalAddress = PostalAddress;
            this.Email = Email;
            this.Website = Website;
            this.Companyname = Companyname;
            this.Bankdetails = Bankdetails;
            this.PhotoPath = PhotoPath;

       }
        
    }
}
