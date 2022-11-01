﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EDMCrud.EDM
{
    public partial class CompanyContext : DbContext
    {
        public CompanyContext()
        {
        }

        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<State> States { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=ASHISHV\\SQLEXPRESS;Database=Company;Integrated Security=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.StateId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AF2DBB990AB92612");

                entity.ToTable("Employee");

                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fname).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(10);

                entity.Property(e => e.Salary).HasMaxLength(50);

                entity.Property(e => e.StateId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State");

                entity.Property(e => e.StateName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
