using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using DBase.Models;
using DBase.Data;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WarehousesController : ControllerBase
{
    private readonly AppDbContext _context;

    private readonly ILogger<WarehousesController> _logger;

    public WarehousesController(ILogger<WarehousesController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    // GET: api/warehouses/
    [HttpGet(Name = "GetWarehouses")]
    public async Task<ActionResult<Warehouse>> GetWarehouse()
    {
        var warehouse = await _context.Warehouses.ToListAsync();

        if (warehouse == null || !warehouse.Any())
        {
            return NotFound();
        }

        return Ok(warehouse);
    }

    [HttpPost(Name = "AddWarehouse")]
    public async Task<ActionResult<Warehouse>> PostWarehouse(Warehouse ware)
    {
        // Validate the incoming DTO
        if (ware == null || ware.WarehouseName == null || ware.Location == null || ware.ManagerName == null || ware.Capacity == 0)
        {
            return BadRequest("Warehouse cannot be null or empty.");
        }


        // Create a new Order object
        Guid id_w = Guid.NewGuid();
        var warehouse = new Warehouse
        {
            ID_Warehouse = id_w,
            WarehouseName = ware.WarehouseName,
            Location = ware.Location,
            ManagerName = ware.ManagerName,
            Capacity = ware.Capacity
        };

        // Add the order to the context
        _context.Warehouses.Add(warehouse);
        // Save changes to the database
        await _context.SaveChangesAsync();

        // Return the created order with a 201 Created response
        return CreatedAtAction(nameof(GetWarehouse), new { id = warehouse.ID_Warehouse }, warehouse);
    }

    // DELETE: api/warehouses/{id}
    [HttpDelete("{id}", Name = "DeleteWarehouse")]
    public async Task<IActionResult> DeleteWarehouse(Guid id)
    {
        var warehouse = await _context.Warehouses.FindAsync(id);
        if (warehouse == null)
        {
            return NotFound(); // Return 404 if the order is not found
        }

        try
        {
            _context.Warehouses.Remove(warehouse); // Remove the order from the context
            await _context.SaveChangesAsync(); // Save changes to the database
        } catch(DbUpdateException ex) {
            // Здесь вы можете проверить, является ли исключение результатом ограничения внешнего ключа
            // Например, вы можете проверить, содержит ли сообщение об ошибке определенные ключевые слова
            if (ex.InnerException != null && ex.InnerException.Message.Contains("update or delete"))
            {
                return Conflict("Cannot delete warehouse because it is referenced by other entities."); // Возвращаем 409 Conflict
            }
            // Если это не связано с ограничением внешнего ключа, вы можете обработать другие ошибки
            return StatusCode(500, "An error occurred while deleting the warehouse."); // Возвращаем 500 Internal Server Error
        }

        return NoContent(); // Return 204 No Content
    }

    // PUT: api/warehouses/{id}
    [HttpPut("{id}", Name = "UpdateWarehouse")]
    public async Task<IActionResult> UpdateWarehouse(Guid id, [FromBody] Warehouse warehouse)
    {
        if (id != warehouse.ID_Warehouse)
        {
            return BadRequest("Supplier ID mismatch.");
        }

        // Check if the order exists
        var existingWarehouse = await _context.Warehouses.FindAsync(id); // reference
        if (existingWarehouse == null)
        {
            return NotFound();
        }

        // Update the properties of the existing supplier
        existingWarehouse.WarehouseName = warehouse.WarehouseName;
        existingWarehouse.Location = warehouse.Location;
        existingWarehouse.ManagerName = warehouse.ManagerName;
        existingWarehouse.Capacity = warehouse.Capacity;
        
        await _context.SaveChangesAsync();

        return NoContent(); // 204 No Content
    }


}
