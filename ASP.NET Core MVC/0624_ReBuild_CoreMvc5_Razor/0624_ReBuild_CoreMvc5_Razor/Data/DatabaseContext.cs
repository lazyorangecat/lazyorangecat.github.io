using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _0624_ReBuild_CoreMvc5_Razor.Models;

namespace _0624_ReBuild_CoreMvc5_Razor.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<_0624_ReBuild_CoreMvc5_Razor.Models.Student> Student { get; set; }
    }
}
