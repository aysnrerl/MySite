using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MySite.Models
{
    public partial class MySiteContext : DbContext
    {
        public MySiteContext()
        {
        }

        public MySiteContext(DbContextOptions<MySiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAbout> TblAbouts { get; set; } = null!;
        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblCertificate> TblCertificates { get; set; } = null!;
        public virtual DbSet<TblEducation> TblEducations { get; set; } = null!;
        public virtual DbSet<TblExperience> TblExperiences { get; set; } = null!;
        public virtual DbSet<TblFeature> TblFeatures { get; set; } = null!;
        public virtual DbSet<TblFooter> TblFooters { get; set; } = null!;
        public virtual DbSet<TblProject> TblProjects { get; set; } = null!;
        public virtual DbSet<TblSkill> TblSkills { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NK4JT39\\SQLEXPRESS;Database=MySite;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAbout>(entity =>
            {
                entity.HasKey(e => e.AboutId);

                entity.ToTable("TblAbout");

                entity.Property(e => e.AboutDescription).HasMaxLength(700);

                entity.Property(e => e.AboutTitle).HasMaxLength(50);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_TblCategory_1");

                entity.ToTable("TblCategory");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblCertificate>(entity =>
            {
                entity.HasKey(e => e.CertificateId);

                entity.ToTable("TblCertificate");

                entity.Property(e => e.CertificateName).HasMaxLength(50);

                entity.Property(e => e.CertificateYear)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.OrganizationName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblEducation>(entity =>
            {
                entity.HasKey(e => e.EducationId);

                entity.ToTable("TblEducation");

                entity.Property(e => e.EducationTitle).HasMaxLength(50);

                entity.Property(e => e.EducationYear).HasMaxLength(50);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Subtitle).HasMaxLength(50);
            });

            modelBuilder.Entity<TblExperience>(entity =>
            {
                entity.HasKey(e => e.ExperienceId);

                entity.ToTable("TblExperience");

                entity.Property(e => e.ExperienceDescripition).HasMaxLength(200);

                entity.Property(e => e.ExperienceIndustry).HasMaxLength(100);

                entity.Property(e => e.ExperienceName).HasMaxLength(50);

                entity.Property(e => e.ExperienceYear).HasMaxLength(50);
            });

            modelBuilder.Entity<TblFeature>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.ToTable("TblFeature");

                entity.Property(e => e.FeatureDescription).HasMaxLength(200);

                entity.Property(e => e.FeatureName).HasMaxLength(50);

                entity.Property(e => e.FeatureTitle).HasMaxLength(50);

                entity.Property(e => e.ImageUrl).HasMaxLength(200);
            });

            modelBuilder.Entity<TblFooter>(entity =>
            {
                entity.HasKey(e => e.FooterId);

                entity.ToTable("TblFooter");

                entity.Property(e => e.FooterDescription).HasMaxLength(100);

                entity.Property(e => e.FooterTitle).HasMaxLength(50);

                entity.Property(e => e.Icon).HasMaxLength(50);
            });

            modelBuilder.Entity<TblProject>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("TblProject");

                entity.Property(e => e.ImageUrl).HasMaxLength(200);

                entity.Property(e => e.ProjectDescription).HasMaxLength(200);

                entity.Property(e => e.ProjectTitle).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblProjects)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblProject_TblCategory");
            });

            modelBuilder.Entity<TblSkill>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("TblSkill");

                entity.Property(e => e.SkillName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
