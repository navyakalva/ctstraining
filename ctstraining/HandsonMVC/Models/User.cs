using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace HandsonMVC.Models
{
    public class User
    {
        [Required(ErrorMessage = "enter the Name")]
        [DisplayName("Employee Name")]
        public string Name { set; get; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "invalid email id")]
        public string Email { get; set; }
        [Required(ErrorMessage = "enter the DOB")]

        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "select country",AllowEmptyStrings =false)]

        public string Country { get; set; }
        [Required(ErrorMessage = "Mobile no is required")]
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "invalid mobile no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "username is required")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "password is required")]
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "invlaid")]
        public string Password { get; set; }
    }
}
