using Domain.Models;
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
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

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
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp= new Guid().ToString() },
                new IdentityRole { Id = "2", Name = "Employee", NormalizedName = "EMPLOYEE", ConcurrencyStamp = new Guid().ToString() },
                new IdentityRole { Id = "3", Name = "Applicant", NormalizedName = "APPLICANT", ConcurrencyStamp = new Guid().ToString() }
            );

            List<ApplicationUser> users = new()
            {
                new ApplicationUser{
                Id = "1",
                UserName = "admin@xyz.com",
                Email = "admin@xyz.com",
                NormalizedUserName = "ADMIN@XYZ.COM",
                NormalizedEmail = "ADMIN@XYZ.COM",
                EmailConfirmed = true
                },
                new ApplicationUser{
                 Id = "2",
                UserName = "employee@xyz.com",
                Email = "employee@xyz.com",
                NormalizedUserName = "EMPLOYEE@XYZ.COM",
                NormalizedEmail = "EMPLOYEE@XYZ.COM",

                EmailConfirmed = true
                },
                new ApplicationUser{
                Id = "3",
                UserName = "applicant@xyz.com",
                Email = "applicant@xyz.com",
                NormalizedUserName = "APPLICANT@XYZ.COM",
                NormalizedEmail = "APPLICANT@XYZ.COM",
                EmailConfirmed = true
                }

            };

            builder.Entity<ApplicationUser>().HasData(users);

            for (int i = 0; i < users.Count; i++)
            {
                var passwordhasher = new PasswordHasher<ApplicationUser>();
                users[i].PasswordHash = passwordhasher.HashPassword(users[i], "P@ssw0rd");
            }

            List<IdentityUserRole<string>> userRoles = new() {
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "2"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = "3"
                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);

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
