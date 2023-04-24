using Data.Config;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class TestContext : DbContext
{

    public DbSet<Plane> Planes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string connectionString = "server=localhost;port=3306;database=tpdotnet;user=root;password=root";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PlaneConfig()); 
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<DateTime>().HaveColumnType("date"); 
    }
}