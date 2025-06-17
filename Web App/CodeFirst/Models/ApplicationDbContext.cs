using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirst.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Disable Cascade Delete for Foreign Keys
            modelBuilder.Entity<User>()
                .HasRequired(u => u.Gender)
                .WithMany()
                .HasForeignKey(u => u.GenderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(u => u.Country)
                .WithMany()
                .HasForeignKey(u => u.CountryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(u => u.State)
                .WithMany()
                .HasForeignKey(u => u.StateID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasRequired(s => s.Country)
                .WithMany()
                .HasForeignKey(s => s.CountryID)
                .WillCascadeOnDelete(false);
        }
    }
}