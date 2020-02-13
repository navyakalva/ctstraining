using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMvc.Models
{
    public class Buyer
    {
        [Key]
        [Required(ErrorMessage = "enter the id")]
         [DisplayName("Buyer Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "enter the Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name should be between the length")]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "enter email")]
        [EmailAddress(ErrorMessage = "invalid email id")]
        public string Mail { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "invalid mobile no")]
        public  int Phoneno { get; set; }
        [RegularExpression("[a-z0-9]{6,8}", ErrorMessage = "invlaid")]
        public string Password { get; set; }
        
        public  DateTime Createddate { get; set; }

        public Buyer()
        { }

        public Buyer(int Id, string Name, string Address, string Mail, int Phoneno, string Password, DateTime Createddate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Mail = Mail;
            this.Phoneno = Phoneno;
            this.Password = Password;
            this.Createddate = Createddate;
        }
    }
}
