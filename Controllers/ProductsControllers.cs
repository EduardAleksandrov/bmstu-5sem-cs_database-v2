using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using DBase.Models;
using DBase.Data;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    // GET: api/products/
    [HttpGet(Name = "GetProducts")]
    public async Task<ActionResult<Product>> GetProduct()
    {
        var product= await _context.Products.ToListAsync();

        if (product == null || !product.Any())
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost(Name = "AddProduct")]
    public async Task<ActionResult<Product>> PostProduct(Product prod)
    {
        // Validate the incoming DTO
        if (prod == null || prod.ProductName == null || prod.Producer == null || prod.UnitPrice == 0)
        {
            return BadRequest("Product cannot be null or empty.");
        }


        // Create a new Order object
        Guid id_p = Guid.NewGuid();
        var product = new Product
        {
            ID_Product = id_p,
            SupplierID = prod.SupplierID,
            WarehouseID = prod.WarehouseID,
            ProductName = prod.ProductName,
            Producer = prod.Producer,
            UnitPrice = prod.UnitPrice,
            QuantityInStock = prod.QuantityInStock
        };

        // Add the order to the context
        _context.Products.Add(product);
        // Save changes to the database
        await _context.SaveChangesAsync();

        // Return the created order with a 201 Created response
        return CreatedAtAction(nameof(GetProduct), new { id = product.ID_Product }, product);
    }

    // DELETE: api/products/{id}
    [HttpDelete("{id}", Name = "DeleteProduct")]
    public async Task<IActionResult> DeleteProduct(Guid id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound(); // Return 404 if the order is not found
        }

        _context.Products.Remove(product); // Remove the order from the context
        await _context.SaveChangesAsync(); // Save changes to the database

        return NoContent(); // Return 204 No Content
    }

    // PUT: api/products/{id}
    [HttpPut("{id}", Name = "UpdateProduct")]
    public async Task<IActionResult> UpdateProduct(Guid id, [FromBody] Product product)
    {
        if (id != product.ID_Product)
        {
            return BadRequest("Product ID mismatch.");
        }

        // Check if the order exists
        var existingProduct = await _context.Products.FindAsync(id); // reference
        if (existingProduct == null)
        {
            return NotFound();
        }

        // Update the properties of the existing product
        existingProduct.SupplierID = product.SupplierID;
        existingProduct.WarehouseID = product.WarehouseID;
        existingProduct.ProductName = product.ProductName;
        existingProduct.Producer = product.Producer;
        existingProduct.UnitPrice = product.UnitPrice;
        existingProduct.QuantityInStock = product.QuantityInStock;
        
        await _context.SaveChangesAsync();

        return NoContent(); // 204 No Content
    }


}
