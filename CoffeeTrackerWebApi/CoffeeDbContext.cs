using CoffeeTrackerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTrackerWebApi;

public class CoffeeDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CoffeeTracker.db;Integrated Security=True");
    }
    
    public DbSet<Coffee> Coffees { get; set; }
}