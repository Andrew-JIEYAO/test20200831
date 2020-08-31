using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace test0831
{
    public partial class MyDatabase01Context : DbContext
    {
        public MyDatabase01Context()
        {
        }

        public MyDatabase01Context(DbContextOptions<MyDatabase01Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TAddressBook> TAddressBook { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:msit12716dbserver0831.database.windows.net,1433;Initial Catalog=MyDatabase01;Persist Security Info=False;User ID=andrew;Password=@ndrew15452;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAddressBook>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tAddressBook");

                entity.Property(e => e.FId).HasColumnName("fId");

                entity.Property(e => e.FAddress)
                    .HasColumnName("fAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(50);

                entity.Property(e => e.FPhone)
                    .HasColumnName("fPhone")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
