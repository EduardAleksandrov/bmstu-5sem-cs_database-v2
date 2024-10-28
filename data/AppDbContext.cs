using Microsoft.EntityFrameworkCore;
using DBase.Models;

namespace DBase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerID);

            modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Order)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Product)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.ProductId);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Supplier)
            .WithMany(s => s.Products)
            .HasForeignKey(p => p.SupplierID);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Warehouse)
            .WithMany(w => w.Products)
            .HasForeignKey(p => p.WarehouseID);

            // UTC Datetime
            modelBuilder.Entity<Order>()
                .Property(o => o.OrderDate)
                .HasConversion(
                v => v, // Store as is
                v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Ensure it's treated as UTC
            );

            // Seed data for Suppliers
            Guid ID_Supplier1 = Guid.NewGuid();
            Guid ID_Supplier2 = Guid.NewGuid();
            Guid ID_Supplier3 = Guid.NewGuid();
            Guid ID_Supplier4 = Guid.NewGuid();

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { ID_Supplier = ID_Supplier1, SupplierName = "Supplier A", ContactName = "Alice", Email = "alice@supplier.com", Phone = "123-456-7890" },
                new Supplier { ID_Supplier = ID_Supplier2, SupplierName = "Supplier B", ContactName = "Bob", Email = "bob@supplier.com", Phone = "098-765-4321" },
                new Supplier { ID_Supplier = ID_Supplier3, SupplierName = "Supplier C", ContactName = "Charlie", Email = "charlie@supplier.com", Phone = "321-654-0987" },
                new Supplier { ID_Supplier = ID_Supplier4, SupplierName = "Supplier D", ContactName = "Diana", Email = "diana@supplier.com", Phone = "987-654-3210" }
            );

            // Seed data for Warehouses
            Guid ID_Warehouse1 = Guid.NewGuid();
            Guid ID_Warehouse2 = Guid.NewGuid();
            Guid ID_Warehouse3 = Guid.NewGuid();
            Guid ID_Warehouse4 = Guid.NewGuid();

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { ID_Warehouse = ID_Warehouse1, WarehouseName = "Warehouse 1", Location = "Location A", ManagerName = "Manager A", Capacity = 1000 },
                new Warehouse { ID_Warehouse = ID_Warehouse2, WarehouseName = "Warehouse 2", Location = "Location B", ManagerName = "Manager B", Capacity = 2000 },
                new Warehouse { ID_Warehouse = ID_Warehouse3, WarehouseName = "Warehouse 3", Location = "Location C", ManagerName = "Manager C", Capacity = 1500 },
                new Warehouse { ID_Warehouse = ID_Warehouse4, WarehouseName = "Warehouse 4", Location = "Location D", ManagerName = "Manager D", Capacity = 2500 }
            );
            
            // Seed data for Products
            Guid ID_Product1 = Guid.NewGuid();
            Guid ID_Product2 = Guid.NewGuid();
            Guid ID_Product3 = Guid.NewGuid();
            Guid ID_Product4 = Guid.NewGuid();
            Guid ID_Product5 = Guid.NewGuid();
            Guid ID_Product6 = Guid.NewGuid();

            modelBuilder.Entity<Product>().HasData(
                new Product { ID_Product = ID_Product1, SupplierID = ID_Supplier1, WarehouseID = ID_Warehouse1, ProductName = "Product 1", Producer = "Producer 1", UnitPrice = 10.00m, QuantityInStock = 100},
                new Product { ID_Product = ID_Product2, SupplierID = ID_Supplier1, WarehouseID = ID_Warehouse1, ProductName = "Product 2", Producer = "Producer 2", UnitPrice = 15.00m, QuantityInStock = 200},
                new Product { ID_Product = ID_Product3, SupplierID = ID_Supplier2, WarehouseID = ID_Warehouse2, ProductName = "Product 3", Producer = "Producer 2", UnitPrice = 20.00m, QuantityInStock = 150},
                new Product { ID_Product = ID_Product4, SupplierID = ID_Supplier3, WarehouseID = ID_Warehouse3, ProductName = "Product 4", Producer = "Producer 2", UnitPrice = 25.00m, QuantityInStock = 80 },
                new Product { ID_Product = ID_Product5, SupplierID = ID_Supplier3, WarehouseID = ID_Warehouse3, ProductName = "Product 5", Producer = "Producer 3", UnitPrice = 30.00m, QuantityInStock = 60 },
                new Product { ID_Product = ID_Product6, SupplierID = ID_Supplier4, WarehouseID = ID_Warehouse4, ProductName = "Product 6", Producer = "Producer 3", UnitPrice = 35.00m, QuantityInStock = 40 }
            );

            // Seed data for Customers
            Guid ID_Customer1 = Guid.NewGuid();
            Guid ID_Customer2 = Guid.NewGuid();
            Guid ID_Customer3 = Guid.NewGuid();
            Guid ID_Customer4 = Guid.NewGuid();

            modelBuilder.Entity<Customer>().HasData(
                new Customer { ID_Customer = ID_Customer1, CustomerName = "John Doe", Phone = "111-222-3333", Email = "john.doe@example.com", Address = "123 Main St, Anytown, USA" },
                new Customer { ID_Customer = ID_Customer2, CustomerName = "Jane Smith", Phone = "444-555-6666", Email = "jane.smith@example.com", Address = "456 Elm St, Othertown, USA" },
                new Customer { ID_Customer = ID_Customer3, CustomerName = "Alice Johnson", Phone = "222-333-4444", Email = "alice.johnson@example.com", Address = "789 Pine St, Sometown, USA" },
                new Customer { ID_Customer = ID_Customer4, CustomerName = "Bob Brown", Phone = "555-666-7777", Email = "bob.brown@example.com", Address = "321 Oak St, Anothertown, USA" }
            );
            
            // Seed data for Orders
            Guid ID_Order1 = Guid.NewGuid();
            Guid ID_Order2 = Guid.NewGuid();
            Guid ID_Order3 = Guid.NewGuid();
            Guid ID_Order4 = Guid.NewGuid();

            modelBuilder.Entity<Order>().HasData(
                new Order { ID_Order = ID_Order1, CustomerID = ID_Customer1, TotalAmount = 25.00m, OrderDate = DateTime.UtcNow, Status = "Completed" },
                new Order { ID_Order = ID_Order2, CustomerID = ID_Customer2, TotalAmount = 30.00m, OrderDate = DateTime.UtcNow, Status = "Pending" },
                new Order { ID_Order = ID_Order3, CustomerID = ID_Customer3, TotalAmount = 50.00m, OrderDate = DateTime.UtcNow, Status = "Completed" },
                new Order { ID_Order = ID_Order4, CustomerID = ID_Customer4, TotalAmount = 70.00m, OrderDate = DateTime.UtcNow, Status = "Shipped" }
            );
            
            // Seed data for OrderDetails
            Guid ID_OrderDetails1 = Guid.NewGuid();
            Guid ID_OrderDetails2 = Guid.NewGuid();
            Guid ID_OrderDetails3 = Guid.NewGuid();
            Guid ID_OrderDetails4 = Guid.NewGuid();
            Guid ID_OrderDetails5 = Guid.NewGuid();
            Guid ID_OrderDetails6 = Guid.NewGuid();

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { ID_OrderDetails = ID_OrderDetails1, OrderId = ID_Order1, ProductId = ID_Product1, Quantity = 2, UnitPrice = 10.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails2, OrderId = ID_Order1, ProductId = ID_Product2, Quantity = 1, UnitPrice = 15.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails3, OrderId = ID_Order2, ProductId = ID_Product3, Quantity = 1, UnitPrice = 20.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails4, OrderId = ID_Order3, ProductId = ID_Product4, Quantity = 2, UnitPrice = 25.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails5, OrderId = ID_Order3, ProductId = ID_Product5, Quantity = 1, UnitPrice = 30.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails6, OrderId = ID_Order4, ProductId = ID_Product6, Quantity = 2, UnitPrice = 35.00m }
            );
        }
    }
}