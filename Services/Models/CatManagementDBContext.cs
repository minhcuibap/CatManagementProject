using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Services.Models
{
    public partial class CatManagementDBContext : DbContext
    {
        public CatManagementDBContext()
        {
        }

        public CatManagementDBContext(DbContextOptions<CatManagementDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<RegisteredService> RegisteredServices { get; set; }
        public virtual DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=CatManagementDB;TrustServerCertificate=True");
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:CatManagementDB"];
            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("AccountID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cat>(entity =>
            {
                entity.Property(e => e.CatId)
                    .ValueGeneratedNever()
                    .HasColumnName("CatID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Breed)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Cats)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Cats__AccountID__3C69FB99");
            });

            modelBuilder.Entity<RegisteredService>(entity =>
            {
                entity.HasKey(e => e.RegisteredId)
                    .HasName("PK__Register__EED49BA9827D9F39");

                entity.Property(e => e.RegisteredId)
                    .ValueGeneratedNever()
                    .HasColumnName("RegisteredID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.RegisteredServices)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Registere__Accou__403A8C7D");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.RegisteredServices)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__Registere__CatID__412EB0B6");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.RegisteredServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK__Registere__Servi__4222D4EF");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.ServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ServiceID");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
