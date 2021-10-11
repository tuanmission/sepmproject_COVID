using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using COVIDtestSite.Models;

#nullable disable

namespace COVIDtestSite.Data
{
    public partial class covidTestSiteDBContext : IdentityDbContext
    {
        public covidTestSiteDBContext()
        {
        }

        public covidTestSiteDBContext(DbContextOptions<covidTestSiteDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<TestingSite> TestingSites { get; set; }
        public virtual DbSet<TestsiteType> TestsiteTypes { get; set; }

        public virtual DbSet<checkin> checkins { get; set; }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=covidTestSiteDB;Trusted_Connection=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Provider");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

           

            modelBuilder.Entity<TestingSite>(entity =>
            {
                entity.ToTable("TestingSite");

                entity.Property(e => e.TestSiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.latitude).HasPrecision(12, 9);
                entity.Property(e => e.longitude).HasPrecision(12, 9);

                entity.Property(e => e.WaitingTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TestingSites)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_provider");

                entity.HasOne(d => d.TestsiteType)
                    .WithMany(p => p.TestingSites)
                    .HasForeignKey(d => d.TestsiteTypeId)
                    .HasConstraintName("fk_testsideid");
            });

            modelBuilder.Entity<TestsiteType>(entity =>
            {
                entity.ToTable("TestsiteType");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
