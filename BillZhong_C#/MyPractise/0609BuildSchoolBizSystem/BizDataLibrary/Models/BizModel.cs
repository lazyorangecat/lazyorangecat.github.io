using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace BizDataLibrary.Models
{
    public partial class BizModel : DbContext
    {
        public BizModel()
            : base("name=BizModel")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());
        }

        public virtual DbSet<Procurement> Procurement { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SalesMan> SalesMan { get; set; }
        public virtual DbSet<Selling> Selling { get; set; }
        public virtual DbSet<SellingSource> SellingSource { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
