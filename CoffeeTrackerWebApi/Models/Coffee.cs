using System.ComponentModel.DataAnnotations;

namespace CoffeeTrackerWebApi.Models;

public class Coffee
{
    public int Id { get; set; }
    [Required]
    public DateTime DateConsumed { get; set; }
    [Required]
    public int Cups { get; set; }
    [MaxLength(200)]
    public string Notes { get; set; }
}