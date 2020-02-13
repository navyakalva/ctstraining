using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpMvc.Models;

namespace EmpMvc.Data
{
    public class EmpMvcContext : DbContext
    {
        public EmpMvcContext (DbContextOptions<EmpMvcContext> options)
            : base(options)
        {
        }

        public DbSet<EmpMvc.Models.Employ> Employ { get; set; }
    }
}
