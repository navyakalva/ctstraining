using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace HandsOnModelValidations.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "enter the id")]
        [DisplayName("Employee Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "enter the Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name should be between the length")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "invalid email id")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="invalid mobile no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "username is required")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "password is required")]
        [RegularExpression("[a-z0-9]{6,8}",ErrorMessage="invlaid")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="password mismatch")]
        public string CPwd { get; set; }

    }
}
