using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApp.Models.DL
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<InputSlip> InputSlips { get; set; }
        public virtual DbSet<InputSlipDetail> InputSlipDetails { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<OutputSlip> OutputSlips { get; set; }
        public virtual DbSet<OutputSlipDetail> OutputSlipDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InputSlip>(entity =>
            {
                entity.ToTable("InputSlip");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.WarehouseId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.InputSlips)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InputSlip__Custo__49C3F6B7");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.InputSlips)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InputSlip__Wareh__4AB81AF0");
            });

            modelBuilder.Entity<InputSlipDetail>(entity =>
            {
                entity.ToTable("InputSlipDetail");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.InputSlipId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.InputSlip)
                    .WithMany(p => p.InputSlipDetails)
                    .HasForeignKey(d => d.InputSlipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InputSlip__Input__4D94879B");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InputSlipDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InputSlip__Produ__4E88ABD4");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("Inventory");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WarehouseId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Produ__3F466844");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Wareh__3E52440B");
            });

            modelBuilder.Entity<OutputSlip>(entity =>
            {
                entity.ToTable("OutputSlip");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.WarehouseId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OutputSlips)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OutputSli__Custo__4222D4EF");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.OutputSlips)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OutputSli__Wareh__4316F928");
            });

            modelBuilder.Entity<OutputSlipDetail>(entity =>
            {
                entity.ToTable("OutputSlipDetail");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.OutputSlipId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.OutputSlip)
                    .WithMany(p => p.OutputSlipDetails)
                    .HasForeignKey(d => d.OutputSlipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OutputSli__Outpu__45F365D3");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OutputSlipDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OutputSli__Produ__46E78A0C");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WarehouseId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__Warehou__3B75D760");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("Warehouse");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.NameKeeper).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
