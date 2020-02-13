using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HandsOnModelValidations.Models
{
    public class Login
    {
        [Required(ErrorMessage="Username is Required")]
        [DisplayName("UserName")]
        public string Uname { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
    }
}
