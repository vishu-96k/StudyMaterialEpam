using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebAPI3.Models;

using System;
using System.Data.Entity;
using WebAPI3.Models;

namespace CodeFirst.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // You can add Fluent API configurations here if needed
            // Example:
            // modelBuilder.Entity<User>()
            //     .Property(u => u.FirstName)
            //     .HasMaxLength(50)
            //     .IsRequired();
        }
    }
}

