using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace EntitySample001.Models
{
    public partial class ContactsModel : DbContext
    {
        public ContactsModel()
            : base("name=ContactsModel")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());
        }

        public virtual DbSet<ContactsTable> ContactsTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactsTable>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<ContactsTable>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<ContactsTable>()
                .Property(e => e.Phone)
                .IsFixedLength();
        }
    }
}
