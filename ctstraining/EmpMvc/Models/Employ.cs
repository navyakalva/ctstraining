using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EmpMvc.Models
{
    public enum department
    {
        It=0, Accounts=1 ,Insurance=2 ,Healthcare=3
    }
    public class Employ
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public department Dept { get; set; }

    }
}
