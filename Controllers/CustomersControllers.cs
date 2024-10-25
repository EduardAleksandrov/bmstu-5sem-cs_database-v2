using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using DBase.Models;
using DBase.Data;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly AppDbContext _context;

    private readonly ILogger<CustomersController> _logger;

    public CustomersController(ILogger<CustomersController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    // GET: api/customers/
    [HttpGet(Name = "GetCustomers")]
    public async Task<ActionResult<Customer>> GetCustomer()
    {
        var customer = await _context.Customers.ToListAsync();

        if (customer == null || !customer.Any())
        {
            return NotFound();
        }

        return Ok(customer);
    }

    [HttpPost(Name = "AddCustomer")]
    public async Task<ActionResult<Customer>> PostCustomer(Customer cus)
    {
        // Validate the incoming DTO
        if (cus == null || cus.CustomerName == null || cus.Phone == null || cus.Email == null || cus.Address == null)
        {
            return BadRequest("Supplier cannot be null or empty.");
        }

        // Create a new Order object
        Guid id_c = Guid.NewGuid();
        var customer = new Customer
        {
            ID_Customer = id_c,
            CustomerName = cus.CustomerName,
            Phone = cus.Phone,
            Email = cus.Email,
            Address = cus.Address
        };

        // Add the order to the context
        _context.Customers.Add(customer);
        // Save changes to the database
        await _context.SaveChangesAsync();

        // Return the created order with a 201 Created response
        return CreatedAtAction(nameof(GetCustomer), new { id = customer.ID_Customer }, customer);
    }

    // DELETE: api/customers/{id}
    [HttpDelete("{id}", Name = "DeleteCustomer")]
    public async Task<IActionResult> DeleteCustomer(Guid id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null)
        {
            return NotFound(); // Return 404 if the order is not found
        }

        _context.Customers.Remove(customer); // Remove the order from the context
        await _context.SaveChangesAsync(); // Save changes to the database

        return NoContent(); // Return 204 No Content
    }

    // PUT: api/customers/{id}
    [HttpPut("{id}", Name = "UpdateCustomer")]
    public async Task<IActionResult> UpdateCustomer(Guid id, [FromBody] Customer customer)
    {
        if (id != customer.ID_Customer)
        {
            return BadRequest("Supplier ID mismatch.");
        }

        // Check if the order exists
        var existingCustomer = await _context.Customers.FindAsync(id); // reference
        if (existingCustomer == null)
        {
            return NotFound();
        }

        // Update the properties of the existing supplier
        existingCustomer.CustomerName = customer.CustomerName;
        existingCustomer.Phone = customer.Phone;
        existingCustomer.Email = customer.Email;
        existingCustomer.Address = customer.Address;
        
        await _context.SaveChangesAsync();

        return NoContent(); // 204 No Content
    }


}
