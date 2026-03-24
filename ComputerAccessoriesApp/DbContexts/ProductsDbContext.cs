using Microsoft.EntityFrameworkCore;
using Products;
public class ProductsDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Username=postgres;Password=Almirchik95;Database=products_db");
    }
}