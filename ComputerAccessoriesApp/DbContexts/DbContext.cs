using Microsoft.EntityFrameworkCore;
using Products;
using Users;
public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Product> products { get; set; }
    public DbSet<Category> categories { get; set; }
    public DbSet<User> users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=1234;Username=postgres;Password=230907;Database=products_db");
    }
}