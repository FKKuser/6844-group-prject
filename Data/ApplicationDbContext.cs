using Microsoft.EntityFrameworkCore;
using RestaurantAdminProject.Models;


public class ApplicationDbContext : DbContext
{
  public DbSet<MenuItem> MenuItems { get; set; }
  public DbSet<SetMeal> SetMeals { get; set; }
  public DbSet<SetMealMenuItem> SetMealMenuItems { get; set; }
  public DbSet<Staff> Staffs { get; set; }

  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    // MenuItem
    modelBuilder.Entity<MenuItem>().HasData(
        new MenuItem { Id = 1, Name = "Burger", Category = CategoryType.Mains, Price = 5.99m, Status = SaleStatus.OnSale },
        new MenuItem { Id = 2, Name = "Fries", Category = CategoryType.Starters, Price = 2.99m, Status = SaleStatus.OnSale },
        new MenuItem { Id = 3, Name = "Coke", Category = CategoryType.Drinks, Price = 1.99m, Status = SaleStatus.OnSale }
    );

    // SetMeal
    modelBuilder.Entity<SetMeal>().HasData(
        new SetMeal { Id = 1, Name = "Combo Meal", Price = 8.99m, Status = SaleStatus.OnSale }
    );

    // SetMealMenuItem
    modelBuilder.Entity<SetMealMenuItem>().HasData(
        new SetMealMenuItem { Id = 1, SetMealId = 1, MenuItemId = 1 }, // Burger in Combo Meal
        new SetMealMenuItem { Id = 2, SetMealId = 1, MenuItemId = 2 }  // Fries in Combo Meal
    );

    // Seed Staff
    modelBuilder.Entity<Staff>().HasData(
        new Staff { Id = 1, Name = "Yuan", Position = "Manager" },
        new Staff { Id = 2, Name = "Mike", Position = "Chef" }
    );
  }
}

