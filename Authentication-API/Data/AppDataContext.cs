using Microsoft.EntityFrameworkCore;

namespace Authentication-API.Data;

public class AppDataContext : DbContext
{

public AppDataContext(DbContextOptions<AppDataContext> options)
    :base(options)
    {}

    public DbSet<Product> Product {get; set;}
    public DbSet<ShoppingCart> ShoppingCart {get; set;}
    public DbSet<Category> Category {get; set;} 
}