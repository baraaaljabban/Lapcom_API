using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lapcom_API.Models
{
    public partial class LapcomContext : DbContext
    {
        public LapcomContext()
        {
        }

        public LapcomContext(DbContextOptions<LapcomContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<DocumentTime> DocumentTime { get; set; }
        public virtual DbSet<GraduationNotice> GraduationNotice { get; set; }
        public virtual DbSet<RegisterationDocument> RegisterationDocument { get; set; }
        public virtual DbSet<RegistreationDocument> RegistreationDocument { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<SuspendRegisteration> SuspendRegisteration { get; set; }
        public virtual DbSet<UnivercityLife> UnivercityLife { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=BJN_ROG\\SQLEXPRESS;Database=Lapcom;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Account_Student");
            });

            modelBuilder.Entity<DocumentTime>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdImage).HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnType("date");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.DocumentTime)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DocumentTime_DocumentTime");
            });

            modelBuilder.Entity<GraduationNotice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdImage).HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.GraduationNotice)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_GraduationNotice_Student");
            });

            modelBuilder.Entity<RegisterationDocument>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<RegisterationDocument>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterationDocument_RegisterationDocument");
            });

            modelBuilder.Entity<RegistreationDocument>(entity =>
            {
                entity.Property(e => e.IdImage).HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.RegistreationDocument)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_RegistreationDocument_Student");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptanceMethode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Average)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GraduationYear).HasColumnType("date");

                entity.Property(e => e.MinistryOfDonors).HasMaxLength(10);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfAcertificate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paddress)
                    .HasColumnName("PAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecitDivision)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specilaization)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Taddress)
                    .HasColumnName("TAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuspendRegisteration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdImage).HasMaxLength(50);

                entity.Property(e => e.RequestYear).HasColumnType("date");

                entity.Property(e => e.Simester).HasColumnType("date");

                entity.Property(e => e.Year).HasColumnType("date");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.SuspendRegisteration)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_SuspendRegisteration_Student");
            });

            modelBuilder.Entity<UnivercityLife>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdImage).HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("date");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.UnivercityLife)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_UnivercityLife_Student");
            });
        }
    }
}
