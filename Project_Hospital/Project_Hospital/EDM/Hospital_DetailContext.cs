using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project_Hospital.EDM
{
    public partial class Hospital_DetailContext : DbContext
    {
        public Hospital_DetailContext()
        {
        }

        public Hospital_DetailContext(DbContextOptions<Hospital_DetailContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<HAdmin> HAdmins { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<TblHospital> TblHospitals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=ASHISHV\\SQLEXPRESS;Database=Hospital_Detail;Integrated Security=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.ToTable("Appointment");

                entity.Property(e => e.AppId).HasColumnName("App_Id");

                entity.Property(e => e.AppoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Appo_Date");

                entity.Property(e => e.AppoStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Appo_Status");

                entity.Property(e => e.DId)
                    .HasMaxLength(10)
                    .HasColumnName("D_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.HopId).HasColumnName("Hop_Id");

                entity.Property(e => e.PtId).HasColumnName("Pt_id");

                entity.HasOne(d => d.Hop)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.HopId)
                    .HasConstraintName("FK__Appointme__Hop_I__32E0915F");

                entity.HasOne(d => d.Pt)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PtId)
                    .HasConstraintName("FK__Appointme__Pt_id__31EC6D26");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.CityId).HasColumnName("City_Id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasColumnName("City_Name");

                entity.Property(e => e.StId).HasColumnName("St_Id");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StId)
                    .HasConstraintName("FK__City__St_Id__30F848ED");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("Doctor");

                entity.Property(e => e.DocId).HasColumnName("Doc_Id");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("FName");

                entity.Property(e => e.HId).HasColumnName("H_id");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("LName");

                entity.Property(e => e.Qualification).HasMaxLength(50);

                entity.Property(e => e.Specialitites).HasMaxLength(50);

                entity.HasOne(d => d.HIdNavigation)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.HId)
                    .HasConstraintName("FK__Doctor__H_id__300424B4");
            });

            modelBuilder.Entity<HAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK_Admin");

                entity.ToTable("H_Admin");

                entity.Property(e => e.AdminId).HasColumnName("Admin_Id");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("LName");

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatId);

                entity.ToTable("Patient");

                entity.Property(e => e.PatId).HasColumnName("Pat_Id");

                entity.Property(e => e.CId).HasColumnName("C_Id");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("LName");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.PImg).HasColumnName("P_img");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.SId).HasColumnName("S_Id");

                entity.HasOne(d => d.CIdNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.CId)
                    .HasConstraintName("FK__Patient__C_Id__34C8D9D1");

                entity.HasOne(d => d.SIdNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.SId)
                    .HasConstraintName("FK__Patient__S_Id__33D4B598");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.StatId);

                entity.ToTable("State");

                entity.Property(e => e.StatId).HasColumnName("Stat_Id");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .HasColumnName("State_Name");
            });

            modelBuilder.Entity<TblHospital>(entity =>
            {
                entity.HasKey(e => e.HospId)
                    .HasName("PK_Hospital");

                entity.ToTable("TblHospital");

                entity.Property(e => e.HospId).HasColumnName("Hosp_Id");

                entity.Property(e => e.HLogImg).HasColumnName("H_Log_Img");

                entity.Property(e => e.Hname)
                    .HasMaxLength(50)
                    .HasColumnName("HName");

                entity.Property(e => e.HospEmail)
                    .HasMaxLength(50)
                    .HasColumnName("Hosp_Email");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
