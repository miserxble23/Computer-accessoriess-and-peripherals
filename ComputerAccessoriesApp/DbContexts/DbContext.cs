using Microsoft.EntityFrameworkCore;
using Products;
using Users;
using Categories;
using CurrencySettings;
using Shipments;
using Supplies;
using WriteOffs;
public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Product> products { get; set; }
    public DbSet<Category> categories { get; set; }
    public DbSet<User> users { get; set; }
    public DbSet<CurrencySetting> currencysettings{  get; set; }
    public DbSet<Shipment> shipments{ get; set; }
    public DbSet<Supplie> supplies{ get; set; }
    public DbSet<WriteOff> writeoffs{ get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Username=postgres;Password=2307;Database=CAAP_db");
    }
}