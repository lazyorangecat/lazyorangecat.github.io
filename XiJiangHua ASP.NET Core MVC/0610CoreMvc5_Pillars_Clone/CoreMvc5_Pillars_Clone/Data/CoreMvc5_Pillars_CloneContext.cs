using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreMvc5_Pillars_Clone.Models;

namespace CoreMvc5_Pillars_Clone.Data
{
    public class CoreMvc5_Pillars_CloneContext : DbContext
    {
        public CoreMvc5_Pillars_CloneContext (DbContextOptions<CoreMvc5_Pillars_CloneContext> options)
            : base(options)
        {
        }

        public DbSet<Friend> Friend { get; set; }
    }
}
