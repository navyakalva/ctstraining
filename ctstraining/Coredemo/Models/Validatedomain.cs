using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Coredemo.Models
{
    public class Validatedomain:ValidationAttribute
    {
        public readonly string allowDomain;
        public Validatedomain(string allowDomain)
        {
            this.allowDomain = allowDomain;
        }
        public override bool IsValid(object value)
        {
            string[] email = value.ToString().Split('@');
            if (email[1] == this.allowDomain)
                return true;
            else
                return false;
        }
    }
}
