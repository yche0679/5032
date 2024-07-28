using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _5A.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<MOCK_DATA> MOCK_DATA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<MOCK_DATA>()
                .Property(e => e.ip_address)
                .IsUnicode(false);
        }
    }
}
