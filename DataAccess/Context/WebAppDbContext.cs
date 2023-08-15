using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context;

public class WebAppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WebAppDB;Integrated Security=true;Encrypt=False");
        base.OnConfiguring(optionsBuilder);
    }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<User>().Property(a => a.Name).HasColumnType("VARCHAR").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<User>().Property(a => a.Email).HasColumnType("VARCHAR").HasMaxLength(200).IsRequired();
        modelBuilder.Entity<User>().Property(a => a.Password).HasColumnType("VARCHAR").HasMaxLength(8000).IsRequired();

        modelBuilder.Entity<City>().Property(a => a.Name).HasColumnType("VARCHAR").HasMaxLength(500);

        modelBuilder.Entity<Category>().Property(a => a.Name).HasColumnType("VARCHAR").HasMaxLength(300);

        modelBuilder.Entity<Product>().Property(a => a.Price).HasColumnType("FLOAT");
        modelBuilder.Entity<Product>().Property(a => a.Title).HasColumnType("VARCHAR").HasMaxLength(300);
        modelBuilder.Entity<Product>().Property(a => a.Description).HasColumnType("VARCHAR").HasMaxLength(300);
        modelBuilder.Entity<Product>().Property(a => a.ImgUrl).HasColumnType("VARCHAR").HasMaxLength(300);
        modelBuilder.Entity<Product>().Property(a => a.Sold).HasColumnType("INT").HasMaxLength(2);



        base.OnModelCreating(modelBuilder);
    }
}
