using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage = "Product Name is required")]
    public string? ProductName { get; set; } = String.Empty;
    [Required(ErrorMessage = "Price is required")]
    public decimal Price { get; set; }
    public int? CategoryId { get; set; }  //FK
    public Category? Category { get; set; }  //Navigation property
}
