using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using UniversityKitchen.Data.Enum;
using UniversityKitchen.Data.Models;

namespace UniversityKitchen.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<Company> Companies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
     

        // modelBuilder.Entity<User>().HasData(
        //     new User()
        //     {
        //         Id = 1,
        //         Username = "super",
        //         Password = "admin",
        //         CreatedAt = null,
        //         RoleEnum = RoleEnum.SuperAdmin,
        //         Email = null,
        //         Firstname = "Unkonw",
        //         Lastname = "Unkonw",
        //         Year = null,
        //         PhoneNumber = null,
        //         IsVerified = true
        //     }
        // );
    }
    
}