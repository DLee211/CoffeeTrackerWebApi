using CoffeeTrackerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTrackerWebApi.Services;

public class CoffeeService
{
    private readonly CoffeeDbContext _context;

    public CoffeeService(CoffeeDbContext context)
    {
        _context = context;
    }
    
    public List<Coffee> GetAllCoffees()
    {
        return _context.Coffees.ToList();
    }
    
    public Coffee GetCoffeeById(int id)
    {
        return _context.Coffees.FirstOrDefault(c => c.Id == id);
    }
    
    public Coffee AddCoffee(Coffee coffee)
    {
        _context.Coffees.Add(coffee);
        _context.SaveChanges();
        return coffee;
    }
    
    public Coffee UpdateCoffee(Coffee coffee)
    {
        _context.Entry(coffee).State = EntityState.Modified;
        _context.SaveChanges();
        return coffee;
    }
    
    public void DeleteCoffee(int id)
    {
        var coffee = _context.Coffees.FirstOrDefault(c => c.Id == id);
        if (coffee != null)
        {
            _context.Coffees.Remove(coffee);
            _context.SaveChanges();
        }
    }
}