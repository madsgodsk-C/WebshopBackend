
namespace Webshop.Api.Models;

public class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public DateTimeOffset CreatedAt { get; set; }
        = DateTimeOffset.UtcNow;

    public string Status { get; set; } = "Pending";

    public List<OrderItem> Items { get; set; } = [];
}
