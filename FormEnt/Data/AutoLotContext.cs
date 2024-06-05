using System;
using System.Collections.Generic;
using FormEnt.Models;
using Microsoft.EntityFrameworkCore;

namespace FormEnt.Data;

public partial class AutoLotContext : DbContext
{
    private readonly string _connectionString;

    public AutoLotContext(string connectionString)
    {
        _connectionString = connectionString;
    }
    public AutoLotContext()
    {
    }

    public AutoLotContext(DbContextOptions<AutoLotContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Costumer> Costumers { get; set; }

    public virtual DbSet<Credit> Credits { get; set; }

    public virtual DbSet<CreditRisk> CreditRisks { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Make> Makes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(_connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Costumer>(entity =>
        {
            entity.ToTable("costumers");
        });

        modelBuilder.Entity<Credit>(entity =>
        {
            entity.ToTable("credits");
        });

        modelBuilder.Entity<CreditRisk>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_CreditRisks_CustomerId");

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Customer).WithMany(p => p.CreditRisks)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CreditRisks_Customers");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.ToTable("Inventory");

            entity.HasIndex(e => e.MakeId, "IX_Inventory_MakeId");

            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.PetName).HasMaxLength(50);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Make).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.MakeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Make_Inventory");
        });

        modelBuilder.Entity<Make>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasIndex(e => e.CarId, "IX_Orders_CarId");

            entity.HasIndex(e => new { e.CustomerId, e.CarId }, "IX_Orders_CustomerId_CarId").IsUnique();

            entity.Property(e => e.TimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Car).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Inventory");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Orders_Customers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
