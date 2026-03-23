using Microsoft.EntityFrameworkCore;
using Users;
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=1234;Username=postgres;Password=230907;Database=users_db");
    }
}
