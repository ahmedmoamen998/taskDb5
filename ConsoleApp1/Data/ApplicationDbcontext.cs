using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5Db.Models;

namespace task5Db.Data
{
    internal class ApplicationDbcontext : DbContext
    {
             public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\NEWMSSQLSERVER;" +
                "Initial Catalog=EF506;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(e => e.Id);
            modelBuilder.Entity<Customer>().Property(e => e.email).HasMaxLength(80).IsUnicode(true);
            modelBuilder.Entity<Customer>().Property(e => e.CustomerName).HasMaxLength(100).IsUnicode(false);
            modelBuilder.Entity<Sale>().HasKey(e => e.SaleId);
            modelBuilder.Entity<Product>().HasKey(e => e.Id);
            modelBuilder.Entity<Product>().Property(e => e.Name).HasMaxLength(100).IsUnicode(true);
            modelBuilder.Entity<Store>().HasKey(e => e.Id);
            modelBuilder.Entity<Store>().Property(e => e.Name).HasMaxLength(80).IsUnicode(true);
            //-------------------------------------------------------
            modelBuilder.Entity<Sale>().Property(e => e.DateTime).HasColumnName("Date");
            //------------------------------------------------------------------
            modelBuilder.Entity<Customer>().HasMany(e => e.salesCustomer).WithOne(e => e.custId).HasForeignKey(e => e.Customer);
            modelBuilder.Entity<Store>().HasMany(e => e.salesStore).WithOne(e => e.StoreId).HasForeignKey(e => e.Store);
            modelBuilder.Entity<Product>().HasMany(e => e.salesProduct).WithOne(e => e.ProductId).HasForeignKey(e => e.Product);

        }
    }
    }

