using CoffeeTrackerWebApi.Models;
using CoffeeTrackerWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTrackerWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoffeeController : ControllerBase
{
    private readonly CoffeeService _coffeeService;

    public CoffeeController(CoffeeService coffeeService)
    {
        _coffeeService = coffeeService;
    }
    
    [HttpGet]
    public ActionResult<List<Coffee>> GetAllCoffees()
    {
        return _coffeeService.GetAllCoffees();
    }
    
    [HttpGet("{id}")]
    public ActionResult<Coffee> GetCoffeeById(int id)
    {
        var coffee = _coffeeService.GetCoffeeById(id);
        if (coffee == null)
        {
            return NotFound();
        }
        return coffee;
    }
    
    [HttpPost]
    public ActionResult<Coffee> AddCoffee(Coffee coffee)
    {
        var createdCoffee = _coffeeService.AddCoffee(coffee);
        return CreatedAtAction(nameof(GetCoffeeById), new { id = createdCoffee.Id }, createdCoffee);
    }
    
    [HttpPut("{id}")]
    public ActionResult UpdateCoffee(int id, Coffee coffee)
    {
        coffee.Id = id;
        var existingCoffee = _coffeeService.GetCoffeeById(id);
        if (existingCoffee == null)
        {
            return BadRequest();
        }
        _coffeeService.UpdateCoffee(coffee);
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public ActionResult DeleteCoffee(int id)
    {
        _coffeeService.DeleteCoffee(id);
        return NoContent();
    }
}