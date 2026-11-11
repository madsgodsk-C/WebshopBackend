
namespace Webshop.Api.Models;

public class ProductVariant
{
    public int Id { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public string SKU { get; set; } = string.Empty;

    public string Color { get; set; } = string.Empty;
    public string Size { get; set; } = string.Empty;

    public decimal Price { get; set; }
    public int Stock { get; set; }
}
