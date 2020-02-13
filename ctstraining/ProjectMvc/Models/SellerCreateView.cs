using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMvc.Models
{
    public class SellerCreateView
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Password { get; set; }
        public string PostalAddress { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Companyname { get; set; }
        public string Bankdetails { get; set; }
        public IFormFile PhotoPath { get; set; }

       
    }
}
