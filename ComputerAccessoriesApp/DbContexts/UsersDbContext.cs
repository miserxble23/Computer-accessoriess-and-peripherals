using Microsoft.EntityFrameworkCore;
using Users;
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Username=postgres;Password=Almirchik95;Database=users_db");
    }
}
