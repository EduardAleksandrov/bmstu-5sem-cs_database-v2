using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using DBase.Models;
using DBase.Data;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SuppliersController : ControllerBase
{
    private readonly AppDbContext _context;

    private readonly ILogger<OrdersController> _logger;

    public SuppliersController(ILogger<OrdersController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    // GET: api/suppliers/
    [HttpGet(Name = "GetSuppliers")]
    public async Task<ActionResult<Supplier>> GetSupplier()
    {
        var supplier = await _context.Suppliers.ToListAsync();

        if (supplier == null || !supplier.Any())
        {
            return NotFound();
        }

        return Ok(supplier);
    }

    [HttpPost(Name = "AddSupplier")]
    public async Task<ActionResult<Supplier>> PostSupplier(Supplier sup)
    {
        // Validate the incoming DTO
        if (sup == null || sup.SupplierName == null || sup.ContactName == null || sup.Email == null || sup.Phone == null)
        {
            return BadRequest("Supplier cannot be null or empty.");
        }


        // Create a new Order object
        Guid id_s = Guid.NewGuid();
        var supplier = new Supplier
        {
            ID_Supplier = id_s,
            SupplierName = sup.SupplierName,
            ContactName = sup.ContactName,
            Email = sup.Email,
            Phone = sup.Phone
        };

        // Add the order to the context
        _context.Suppliers.Add(supplier);
        // Save changes to the database
        await _context.SaveChangesAsync();

        // Return the created order with a 201 Created response
        return CreatedAtAction(nameof(GetSupplier), new { id = supplier.ID_Supplier }, supplier);
    }

}
