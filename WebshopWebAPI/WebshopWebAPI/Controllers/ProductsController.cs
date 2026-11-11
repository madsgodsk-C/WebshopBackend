/*
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webshop.Api.Data;

namespace Webshop.Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _context.Products
            .AsNoTracking()
            .ToListAsync();

        return Ok(products);
    }
}
*/


using Microsoft.AspNetCore.Mvc;

namespace Webshop.Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var products = new[]
        {
            new
            {
                Id = 1,
                Name = "Gaming Keyboard",
                Price = 599.00m
            },
            new
            {
                Id = 2,
                Name = "Gaming Mouse",
                Price = 299.00m
            }
        };

        return Ok(products);
    }
}

