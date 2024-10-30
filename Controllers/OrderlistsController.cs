using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using DBase.Models;
using DBase.Data;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderlistsController : ControllerBase
{
    private readonly AppDbContext _context;

    private readonly ILogger<OrderlistsController> _logger;

    public OrderlistsController(ILogger<OrderlistsController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    

    // GET: api/orderlist/{id}
    [HttpGet("{id}", Name = "GetOrderlistById")]
    public async Task<ActionResult<Order>> GetOrderlist(Guid id)
    {
        var order = await _context.Orders
            .Include(o => o.OrderDetails)
            .FirstOrDefaultAsync(o => o.ID_Order == id);

        if (order == null)
        {
            return NotFound();
        }

        return order;
    }
    // GET: api/orderlists/
    [HttpGet(Name = "GetOrderlists")]
    public async Task<ActionResult<Order>> GetOrderlists()
    {
        // var order = await _context.Orders.ToListAsync();
        var order = await _context.Orders
            .Include(o => o.OrderDetails) // Eagerly load OrderDetails
            .ToListAsync();

        if (order == null || !order.Any())
        {
            return NotFound();
        }

        return Ok(order);
    }

    // PUT: api/orderlist/{id}
    [HttpPut("{id}", Name = "UpdateOrderlist")]
    public async Task<IActionResult> UpdateOrderlist(Guid id, [FromBody] Order order)
    {
        if (id != order.ID_Order)
        {
            return BadRequest("Order ID mismatch.");
        }

        // Check if the order exists
        var existingOrder = await _context.Orders.FindAsync(id);
        if (existingOrder == null)
        {
            return NotFound();
        }

        // Update the properties of the existing order
        existingOrder.Status = order.Status;

        // Update the order details if necessary
        // You may want to handle this based on your business logic

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!OrderExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent(); // 204 No Content
    }

    private bool OrderExists(Guid id)
    {
        return _context.Orders.Any(e => e.ID_Order == id);
    }
}
