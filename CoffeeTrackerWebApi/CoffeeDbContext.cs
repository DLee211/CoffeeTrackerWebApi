using CoffeeTrackerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTrackerWebApi;

public class CoffeeDbContext : DbContext
{
    public CoffeeDbContext (DbContextOptions<CoffeeDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Coffee> Coffees { get; set; }
}