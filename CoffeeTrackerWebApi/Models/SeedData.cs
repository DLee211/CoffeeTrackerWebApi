using Microsoft.EntityFrameworkCore;

namespace CoffeeTrackerWebApi.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CoffeeDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<CoffeeDbContext>>()))
        {
            // Look for any coffees.
            if (context.Coffees.Any())
            {
                // DB has been seeded
                return;
            }

            for (int i = 1; i <= 10; i++)
            {
                context.Coffees.Add(new Coffee
                {
                    DateConsumed = DateTime.Now.AddDays(-i),
                    Cups = i,
                    Notes = $"Coffee note {i}"
                });
            }

            context.SaveChanges();
        }
    }
    
    public static void ClearDatabase(IServiceProvider serviceProvider)
    {
        using (var context = new CoffeeDbContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<CoffeeDbContext>>()))
        {
            context.Coffees.RemoveRange(context.Coffees);
            context.SaveChanges();
        }
    }
}