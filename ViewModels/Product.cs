using System.ComponentModel.DataAnnotations;

namespace Mvc.ViewModels;

public class Product
{
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public int Amount { get; set; }
}