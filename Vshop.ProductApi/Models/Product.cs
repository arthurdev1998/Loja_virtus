using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Vshop.ProductApi.Models;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public long Stock { get; set; }
    public string? ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}