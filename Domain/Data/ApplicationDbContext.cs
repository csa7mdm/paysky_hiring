using Domain.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configure relationships using Fluent API
            builder.Entity<Application>()
                .HasOne(a => a.Vacancy)
                .WithMany(v => v.Applications)
                .HasForeignKey(a => a.VacancyId);
            builder.Entity<Application>()
                .HasOne(a => a.Applicant)
                .WithMany(u => u.Applications)
                .HasForeignKey(a => a.ApplicantId);

            // Set up data validations and constraints
            builder.Entity<ApplicationUser>()
                .Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Entity<ApplicationUser>()
                .Property(u => u.Password)
                .HasMaxLength(100);

            builder.Entity<ApplicationUser>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Entity<Vacancy>()
                .Property(v => v.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Entity<Vacancy>()
                .Property(v => v.Description)
                .IsRequired();

            builder.Entity<Vacancy>()
                .Property(v => v.Location)
                .IsRequired()
                .HasMaxLength(100);

            builder.Entity<Application>()
                .Property(a => a.ApplicationDate)
                .IsRequired();

            builder.Entity<Application>()
                .Property(a => a.CoverLetter)
                .IsRequired();

            builder.Entity<Application>()
                .Property(a => a.Resume)
                .IsRequired();
            builder.Entity<Vacancy>()
                .Property(v => v.Salary)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            // Configure Role entity
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Employee", NormalizedName = "EMPLOYEE" },
                new IdentityRole { Id = "3", Name = "Applicant", NormalizedName = "APPLICANT" }
            );

            builder.Entity<IdentityUser>().HasData(
               new IdentityUser { 
                   Id = "1", UserName = "Admin", 
                   Email = "admin@xyz.com", 
                   NormalizedUserName = "ADMIN", 
                   EmailConfirmed = true, 
                   PasswordHash = new PasswordHasher().HashPassword("1234")
               },
               
               new IdentityUser { 
                   Id = "2", 
                   UserName = "Employee", 
                   Email = "employee@xyz.com", 
                   NormalizedUserName = "EMPLOYEE", 
                   EmailConfirmed = true, 
                   PasswordHash = new PasswordHasher().HashPassword("1234") 
               },
               
               new IdentityUser { 
                   Id = "3", UserName = "Applicant", 
                   Email = "applicant@xyz.com", 
                   NormalizedUserName = "APPLICANT", 
                   EmailConfirmed = true, 
                   PasswordHash = new PasswordHasher().HashPassword("1234") 
               }
           );

            // Invoke the base implementation
            base.OnModelCreating(builder);
        }

        public DbSet<ApplicationUser> Users
        {
            get;
            set;
        }
        public DbSet<Vacancy> Vacancys
        {
            get;
            set;
        }
        public DbSet<Application> Applications
        {
            get;
            set;
        }
    }
}
