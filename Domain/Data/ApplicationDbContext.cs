﻿using Domain.Models;
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
    public class ApplicationDbContext: IdentityDbContext<IdentityUser, IdentityRole, string>
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
            builder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(100);

            builder.Entity<User>()
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

            // Invoke the base implementation
            base.OnModelCreating(builder);
        }
        public DbSet<User> Users
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
