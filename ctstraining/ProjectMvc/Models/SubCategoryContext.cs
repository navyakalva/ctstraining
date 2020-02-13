using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMvc.Models
{
    public class SubCategoryContext:DbContext
    {
        public SubCategoryContext(DbContextOptions<SubCategoryContext> options) : base(options)
        { }
        public DbSet<SubCategory> SubCategory { get; set; }
    }
}
