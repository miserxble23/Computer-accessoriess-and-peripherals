using Microsoft.EntityFrameworkCore;
using Products;
public class ProductsDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=1234;Username=postgres;Password=230907;Database=products_db");
    }
}