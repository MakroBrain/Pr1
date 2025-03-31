using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.DBContext
{
    public partial class ModelIF : DbContext
    {
        public ModelIF()
            : base("name=ModelIF")
        {
        }

        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Roles)
                .HasForeignKey(e => e.RoleID);
        }
    }
}
