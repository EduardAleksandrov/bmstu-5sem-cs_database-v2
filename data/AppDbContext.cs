using Microsoft.EntityFrameworkCore;
using DBase.Models;

namespace DBase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderDetail>? OrderDetails { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Supplier>? Suppliers { get; set; }
        public DbSet<Warehouse>? Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerID)
            .OnDelete(DeleteBehavior.Restrict);

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
            .HasForeignKey(p => p.SupplierID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Warehouse)
            .WithMany(w => w.Products)
            .HasForeignKey(p => p.WarehouseID)
            .OnDelete(DeleteBehavior.Restrict);

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
            Guid ID_Supplier_id1 = Guid.NewGuid();
            Guid ID_Supplier_id2 = Guid.NewGuid();
            Guid ID_Supplier_id3 = Guid.NewGuid();
            Guid ID_Supplier_id4 = Guid.NewGuid();
            Guid ID_Supplier_id5 = Guid.NewGuid();
            Guid ID_Supplier_id6 = Guid.NewGuid();
            Guid ID_Supplier_id7 = Guid.NewGuid();
            Guid ID_Supplier_id8 = Guid.NewGuid();
            Guid ID_Supplier_id9 = Guid.NewGuid();
            Guid ID_Supplier_id10 = Guid.NewGuid();
            Guid ID_Supplier_id11 = Guid.NewGuid();
            Guid ID_Supplier_id12 = Guid.NewGuid();
            Guid ID_Supplier_id13 = Guid.NewGuid();
            Guid ID_Supplier_id14 = Guid.NewGuid();
            Guid ID_Supplier_id15 = Guid.NewGuid();
            Guid ID_Supplier_id16 = Guid.NewGuid();
            Guid ID_Supplier_id17 = Guid.NewGuid();
            Guid ID_Supplier_id18 = Guid.NewGuid();
            Guid ID_Supplier_id19 = Guid.NewGuid();
            Guid ID_Supplier_id20 = Guid.NewGuid();

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { ID_Supplier = ID_Supplier1, SupplierName = "Supplier A", ContactName = "Alice", Email = "alice@supplier.com", Phone = "123-456-7890" },
                new Supplier { ID_Supplier = ID_Supplier2, SupplierName = "Supplier B", ContactName = "Bob", Email = "bob@supplier.com", Phone = "098-765-4321" },
                new Supplier { ID_Supplier = ID_Supplier3, SupplierName = "Supplier C", ContactName = "Charlie", Email = "charlie@supplier.com", Phone = "321-654-0987" },
                new Supplier { ID_Supplier = ID_Supplier4, SupplierName = "Supplier D", ContactName = "Diana", Email = "diana@supplier.com", Phone = "987-654-3210" },
                new Supplier { ID_Supplier = ID_Supplier_id1, SupplierName = "Acme Corp", ContactName = "John Doe", Email = "john.doe@acmecorp.com", Phone = "555-0101" },
                new Supplier { ID_Supplier = ID_Supplier_id2, SupplierName = "Global Supplies", ContactName = "Jane Smith", Email = "jane.smith@globalsupplies.com", Phone = "555-0102" },
                new Supplier { ID_Supplier = ID_Supplier_id3, SupplierName = "Tech Innovations", ContactName = "Alice Johnson", Email = "alice.johnson@techinnovations.com", Phone = "555-0103" },
                new Supplier { ID_Supplier = ID_Supplier_id4, SupplierName = "Quality Goods", ContactName = "Bob Brown", Email = "bob.brown@qualitygoods.com", Phone = "555-0104" },
                new Supplier { ID_Supplier = ID_Supplier_id5, SupplierName = "Fast Delivery", ContactName = "Charlie Davis", Email = "charlie.davis@fastdelivery.com", Phone = "555-0105" },
                new Supplier { ID_Supplier = ID_Supplier_id6, SupplierName = "Eco Products", ContactName = "Diana Green", Email = "diana.green@ecoproducts.com", Phone = "555-0106" },
                new Supplier { ID_Supplier = ID_Supplier_id7, SupplierName = "Home Essentials", ContactName = "Ethan White", Email = "ethan.white@homeessentials.com", Phone = "555-0107" },
                new Supplier { ID_Supplier = ID_Supplier_id8, SupplierName = "Office Supplies Co.", ContactName = "Fiona Black", Email = "fiona.black@officesuppliesco.com", Phone = "555-0108" },
                new Supplier { ID_Supplier = ID_Supplier_id9, SupplierName = "Gourmet Foods", ContactName = "George Blue", Email = "george.blue@gourmetfoods.com", Phone = "555-0109" },
                new Supplier { ID_Supplier = ID_Supplier_id10, SupplierName = "Fashion Hub", ContactName = "Hannah Red", Email = "hannah.red@fashionhub.com", Phone = "555-0110" },
                new Supplier { ID_Supplier = ID_Supplier_id11, SupplierName = "Health & Wellness", ContactName = "Ian Gray", Email = "ian.gray@healthwellness.com", Phone = "555-0111" },
                new Supplier { ID_Supplier = ID_Supplier_id12, SupplierName = "Sports Gear", ContactName = "Julia Orange", Email = "julia.orange@sportsgear.com", Phone = "555-0112" },
                new Supplier { ID_Supplier = ID_Supplier_id13, SupplierName = "Pet Supplies", ContactName = "Kevin Purple", Email = "kevin.purple@petsupplies.com", Phone = "555-0113" },
                new Supplier { ID_Supplier = ID_Supplier_id14, SupplierName = "Automotive Parts", ContactName = "Laura Pink", Email = "laura.pink@automotiveparts.com", Phone = "555-0114" },
                new Supplier { ID_Supplier = ID_Supplier_id15, SupplierName = "Construction Materials", ContactName = "Mike Yellow", Email = "mike.yellow@constructionmaterials.com", Phone = "555-0115" },
                new Supplier { ID_Supplier = ID_Supplier_id16, SupplierName = "Beverage Distributors", ContactName = "Nina Cyan", Email = "nina.cyan@beveragedistributors.com", Phone = "555-0116" },
                new Supplier { ID_Supplier = ID_Supplier_id17, SupplierName = "Cleaning Supplies", ContactName = "Oscar Magenta", Email = "oscar.magenta@cleaningsupplies.com", Phone = "555-0117" },
                new Supplier { ID_Supplier = ID_Supplier_id18, SupplierName = "Furniture World", ContactName = "Paula Teal", Email = "paula.teal@furnitureworld.com", Phone = "555-0118" },
                new Supplier { ID_Supplier = ID_Supplier_id19, SupplierName = "Garden Supplies", ContactName = "Quinn Brown", Email = "quinn.brown@gardensupplies.com", Phone = "555-0119" },
                new Supplier { ID_Supplier = ID_Supplier_id20, SupplierName = "Digital Solutions", ContactName = "Rachel Silver", Email = "rachel.silver@digitalsolutions.com", Phone = "555-0120" }
            );

            // Seed data for Warehouses
            Guid ID_Warehouse1 = Guid.NewGuid();
            Guid ID_Warehouse2 = Guid.NewGuid();
            Guid ID_Warehouse3 = Guid.NewGuid();
            Guid ID_Warehouse4 = Guid.NewGuid();
            Guid ID_Warehouse5 = Guid.NewGuid();
            Guid ID_Warehouse6 = Guid.NewGuid();
            Guid ID_Warehouse7 = Guid.NewGuid();
            Guid ID_Warehouse8 = Guid.NewGuid();
            Guid ID_Warehouse9 = Guid.NewGuid();
            Guid ID_Warehouse10 = Guid.NewGuid();
            Guid ID_Warehouse11 = Guid.NewGuid();
            Guid ID_Warehouse12 = Guid.NewGuid();
            Guid ID_Warehouse13 = Guid.NewGuid();
            Guid ID_Warehouse14 = Guid.NewGuid();

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { ID_Warehouse = ID_Warehouse1, WarehouseName = "Central Warehouse", Location = "Downtown", ManagerName = "Alice Johnson", Capacity = 50000 },
                new Warehouse { ID_Warehouse = ID_Warehouse2, WarehouseName = "Northside Warehouse", Location = "North District", ManagerName = "Bob Smith", Capacity = 30000 },
                new Warehouse { ID_Warehouse = ID_Warehouse3, WarehouseName = "Eastside Warehouse", Location = "East District", ManagerName = "Charlie Brown", Capacity = 40000 },
                new Warehouse { ID_Warehouse = ID_Warehouse4, WarehouseName = "Westside Warehouse", Location = "West District", ManagerName = "Diana Prince", Capacity = 35000 },
                new Warehouse { ID_Warehouse = ID_Warehouse5, WarehouseName = "Southside Warehouse", Location = "South District", ManagerName = "Ethan Hunt", Capacity = 4500 },
                new Warehouse { ID_Warehouse = ID_Warehouse6, WarehouseName = "Logistics Hub", Location = "Industrial Park", ManagerName = "Fiona Green", Capacity = 6000 },
                new Warehouse { ID_Warehouse = ID_Warehouse7, WarehouseName = "Distribution Center", Location = "Airport Road", ManagerName = "George White", Capacity = 7000 },
                new Warehouse { ID_Warehouse = ID_Warehouse8, WarehouseName = "Storage Facility", Location = "Suburban Area", ManagerName = "Hannah Blue", Capacity = 2500 },
                new Warehouse { ID_Warehouse = ID_Warehouse9, WarehouseName = "Cold Storage", Location = "Market Street", ManagerName = "Ian Gray", Capacity = 2000 },
                new Warehouse { ID_Warehouse = ID_Warehouse10, WarehouseName = "Bulk Storage", Location = "Port Area", ManagerName = "Julia Red", Capacity = 8000 },
                new Warehouse { ID_Warehouse = ID_Warehouse11, WarehouseName = "Warehouse 1", Location = "Location A", ManagerName = "Manager A", Capacity = 1000 },
                new Warehouse { ID_Warehouse = ID_Warehouse12, WarehouseName = "Warehouse 2", Location = "Location B", ManagerName = "Manager B", Capacity = 2000 },
                new Warehouse { ID_Warehouse = ID_Warehouse13, WarehouseName = "Warehouse 3", Location = "Location C", ManagerName = "Manager C", Capacity = 1500 },
                new Warehouse { ID_Warehouse = ID_Warehouse14, WarehouseName = "Warehouse 4", Location = "Location D", ManagerName = "Manager D", Capacity = 2500 }
                
            );
            
            // Seed data for Products
            Guid ID_Product1 = Guid.NewGuid();
            Guid ID_Product2 = Guid.NewGuid();
            Guid ID_Product3 = Guid.NewGuid();
            Guid ID_Product4 = Guid.NewGuid();
            Guid ID_Product5 = Guid.NewGuid();
            Guid ID_Product6 = Guid.NewGuid();
            Guid ID_Product7 = Guid.NewGuid();
            Guid ID_Product8 = Guid.NewGuid();
            Guid ID_Product9 = Guid.NewGuid();
            Guid ID_Product10 = Guid.NewGuid();
            Guid ID_Product11 = Guid.NewGuid();
            Guid ID_Product12 = Guid.NewGuid();
            Guid ID_Product13 = Guid.NewGuid();
            Guid ID_Product14 = Guid.NewGuid();
            Guid ID_Product15 = Guid.NewGuid();
            Guid ID_Product16 = Guid.NewGuid();
            Guid ID_Product17 = Guid.NewGuid();
            Guid ID_Product18 = Guid.NewGuid();
            Guid ID_Product19 = Guid.NewGuid();
            Guid ID_Product20 = Guid.NewGuid();
            Guid ID_Product21 = Guid.NewGuid();
            Guid ID_Product22 = Guid.NewGuid();
            Guid ID_Product23 = Guid.NewGuid();
            Guid ID_Product24 = Guid.NewGuid();
            Guid ID_Product25 = Guid.NewGuid();
            Guid ID_Product26 = Guid.NewGuid();
            Guid ID_Product27 = Guid.NewGuid();
            Guid ID_Product28 = Guid.NewGuid();
            Guid ID_Product29 = Guid.NewGuid();
            Guid ID_Product30 = Guid.NewGuid();
            Guid ID_Product31 = Guid.NewGuid();
            Guid ID_Product32 = Guid.NewGuid();
            Guid ID_Product33 = Guid.NewGuid();
            Guid ID_Product34 = Guid.NewGuid();
            Guid ID_Product35 = Guid.NewGuid();
            Guid ID_Product36 = Guid.NewGuid();
            Guid ID_Product37 = Guid.NewGuid();
            Guid ID_Product38 = Guid.NewGuid();
            Guid ID_Product39 = Guid.NewGuid();
            Guid ID_Product40 = Guid.NewGuid();

            modelBuilder.Entity<Product>().HasData(
                new Product { ID_Product = ID_Product1, SupplierID = ID_Supplier1, WarehouseID = ID_Warehouse1, ProductName = "Product 1", Producer = "Producer 1", Cell = "a100", UnitPrice = 10.00m, QuantityInStock = 100},
                new Product { ID_Product = ID_Product2, SupplierID = ID_Supplier1, WarehouseID = ID_Warehouse1, ProductName = "Product 2", Producer = "Producer 2", Cell = "a101", UnitPrice = 15.00m, QuantityInStock = 200},
                new Product { ID_Product = ID_Product3, SupplierID = ID_Supplier2, WarehouseID = ID_Warehouse2, ProductName = "Product 3", Producer = "Producer 2", Cell = "a102", UnitPrice = 20.00m, QuantityInStock = 150},
                new Product { ID_Product = ID_Product4, SupplierID = ID_Supplier3, WarehouseID = ID_Warehouse3, ProductName = "Product 4", Producer = "Producer 2", Cell = "a103", UnitPrice = 25.00m, QuantityInStock = 80 },
                new Product { ID_Product = ID_Product5, SupplierID = ID_Supplier3, WarehouseID = ID_Warehouse3, ProductName = "Product 5", Producer = "Producer 3", Cell = "a104", UnitPrice = 30.00m, QuantityInStock = 60 },
                new Product { ID_Product = ID_Product6, SupplierID = ID_Supplier4, WarehouseID = ID_Warehouse4, ProductName = "Product 6", Producer = "Producer 3", Cell = "a105", UnitPrice = 35.00m, QuantityInStock = 40 },
                new Product { ID_Product = ID_Product7, SupplierID = ID_Supplier_id13, WarehouseID = ID_Warehouse11, ProductName = "Organic Apples", Producer = "Fresh Farms", Cell = "a10", UnitPrice = 100.50m, QuantityInStock = 150 },
                new Product { ID_Product = ID_Product8, SupplierID = ID_Supplier_id13, WarehouseID = ID_Warehouse11, ProductName = "Whole Wheat Bread", Producer = "Bakery Co.", Cell = "a11", UnitPrice = 200.00m, QuantityInStock = 200 },
                new Product { ID_Product = ID_Product9, SupplierID = ID_Supplier_id14, WarehouseID = ID_Warehouse12, ProductName = "Almond Milk", Producer = "Nutty Delights", Cell = "a12", UnitPrice = 300.50m, QuantityInStock = 100 },
                new Product { ID_Product = ID_Product10, SupplierID = ID_Supplier_id14, WarehouseID = ID_Warehouse13, ProductName = "Greek Yogurt", Producer = "Dairy Best", Cell = "a13", UnitPrice = 4000.00m, QuantityInStock = 80 },
                new Product { ID_Product = ID_Product11, SupplierID = ID_Supplier_id14, WarehouseID = ID_Warehouse13, ProductName = "Free-Range Eggs", Producer = "Farm Fresh", Cell = "a14", UnitPrice = 2000.50m, QuantityInStock = 60 },
                new Product { ID_Product = ID_Product12, SupplierID = ID_Supplier_id15, WarehouseID = ID_Warehouse14, ProductName = "Brown Rice", Producer = "Grain Masters", Cell = "a15", UnitPrice = 1000.80m, QuantityInStock = 120 },
                new Product { ID_Product = ID_Product13, SupplierID = ID_Supplier_id15, WarehouseID = ID_Warehouse14, ProductName = "Quinoa", Producer = "Healthy Grains", Cell = "a106", UnitPrice = 4000.50m, QuantityInStock = 90 },
                new Product { ID_Product = ID_Product14, SupplierID = ID_Supplier_id15, WarehouseID = ID_Warehouse12, ProductName = "Coconut Oil", Producer = "Tropical Goods", Cell = "a107", UnitPrice = 6000.00m, QuantityInStock = 70 },
                new Product { ID_Product = ID_Product15, SupplierID = ID_Supplier_id16, WarehouseID = ID_Warehouse8, ProductName = "Dark Chocolate", Producer = "Choco Bliss", Cell = "a108", UnitPrice = 3000.00m, QuantityInStock = 50 },
                new Product { ID_Product = ID_Product16, SupplierID = ID_Supplier_id17, WarehouseID = ID_Warehouse7, ProductName = "Spinach", Producer = "Green Leaf", Cell = "a109", UnitPrice = 2000.20m, QuantityInStock = 110 },
                new Product { ID_Product = ID_Product17, SupplierID = ID_Supplier_id1, WarehouseID = ID_Warehouse3, ProductName = "Oatmeal", Producer = "Healthy Mornings", Cell = "a110", UnitPrice = 3000.00m, QuantityInStock = 200 },
                new Product { ID_Product = ID_Product18, SupplierID = ID_Supplier_id2, WarehouseID = ID_Warehouse5, ProductName = "Chia Seeds", Producer = "Superfoods Co.", Cell = "a111", UnitPrice = 500.00m, QuantityInStock = 150 },
                new Product { ID_Product = ID_Product19, SupplierID = ID_Supplier_id3, WarehouseID = ID_Warehouse13, ProductName = "Avocado Oil", Producer = "Nature's Best", Cell = "a112", UnitPrice = 800.00m, QuantityInStock = 80 },
                new Product { ID_Product = ID_Product20, SupplierID = ID_Supplier_id6, WarehouseID = ID_Warehouse14, ProductName = "Canned Chickpeas", Producer = "Legume Lovers", Cell = "a113", UnitPrice = 1000.20m, QuantityInStock = 300 },
                new Product { ID_Product = ID_Product21, SupplierID = ID_Supplier_id5, WarehouseID = ID_Warehouse12, ProductName = "Frozen Berries", Producer = "Berry Good", Cell = "a114", UnitPrice = 400.00m, QuantityInStock = 120 },
                new Product { ID_Product = ID_Product22, SupplierID = ID_Supplier_id4, WarehouseID = ID_Warehouse10, ProductName = "Peanut Butter", Producer = "Nutty Spread", Cell = "a115", UnitPrice = 3000.50m, QuantityInStock = 90 },
                new Product { ID_Product = ID_Product23, SupplierID = ID_Supplier_id7, WarehouseID = ID_Warehouse9, ProductName = "Coconut Water", Producer = "Tropical Refreshments", Cell = "a116", UnitPrice = 200.50m, QuantityInStock = 200 },
                new Product { ID_Product = ID_Product24, SupplierID = ID_Supplier_id10, WarehouseID = ID_Warehouse8, ProductName = "Granola Bars", Producer = "Snack Time", Cell = "a117", UnitPrice = 100.80m, QuantityInStock = 150 },
                new Product { ID_Product = ID_Product25, SupplierID = ID_Supplier_id9, WarehouseID = ID_Warehouse7, ProductName = "Hummus", Producer = "Dips & Spreads", Cell = "a118", UnitPrice = 200.00m, QuantityInStock = 100 },
                new Product { ID_Product = ID_Product26, SupplierID = ID_Supplier_id8, WarehouseID = ID_Warehouse6, ProductName = "Maple Syrup", Producer = "Sweet Harvest", Cell = "a119", UnitPrice = 6000.00m, QuantityInStock = 70 },
                new Product { ID_Product = ID_Product27, SupplierID = ID_Supplier3, WarehouseID = ID_Warehouse3, ProductName = "Sweet Potatoes", Producer = "Root Veggies", Cell = "a126", UnitPrice = 100.80m, QuantityInStock = 120 },
                new Product { ID_Product = ID_Product28, SupplierID = ID_Supplier4, WarehouseID = ID_Warehouse4, ProductName = "Canned Tomatoes", Producer = "Garden Fresh", Cell = "a127", UnitPrice = 1000.00m, QuantityInStock = 300 },
                new Product { ID_Product = ID_Product29, SupplierID = ID_Supplier2, WarehouseID = ID_Warehouse2, ProductName = "Nut Mix", Producer = "Healthy Snacks", Cell = "a128", UnitPrice = 600.00m, QuantityInStock = 90 },
                new Product { ID_Product = ID_Product30, SupplierID = ID_Supplier1, WarehouseID = ID_Warehouse1, ProductName = "Balsamic Vinegar", Producer = "Gourmet Essentials", Cell = "a129", UnitPrice = 4000.50m, QuantityInStock = 70 },
                new Product { ID_Product = ID_Product31, SupplierID = ID_Supplier_id8, WarehouseID = ID_Warehouse3, ProductName = "Tofu", Producer = "Plant Protein Co.", Cell = "a130", UnitPrice = 200.50m, QuantityInStock = 100 },
                new Product { ID_Product = ID_Product32, SupplierID = ID_Supplier_id9, WarehouseID = ID_Warehouse4, ProductName = "Almonds", Producer = "Nutty Delights", Cell = "a131", UnitPrice = 8000.00m, QuantityInStock = 80 },
                new Product { ID_Product = ID_Product33, SupplierID = ID_Supplier_id10, WarehouseID = ID_Warehouse1, ProductName = "Cinnamon", Producer = "Spice World", Cell = "a132", UnitPrice = 300.00m, QuantityInStock = 150 },
                new Product { ID_Product = ID_Product34, SupplierID = ID_Supplier_id11, WarehouseID = ID_Warehouse2, ProductName = "Black Beans", Producer = "Legume Lovers", Cell = "a133", UnitPrice = 100.50m, QuantityInStock = 200 },
                new Product { ID_Product = ID_Product35, SupplierID = ID_Supplier_id12, WarehouseID = ID_Warehouse3, ProductName = "Cabbage", Producer = "Fresh Greens", Cell = "a134", UnitPrice = 166.80m, QuantityInStock = 120 },
                new Product { ID_Product = ID_Product36, SupplierID = ID_Supplier_id13, WarehouseID = ID_Warehouse4, ProductName = "Lentils", Producer = "Healthy Harvest", Cell = "a135", UnitPrice = 177.20m, QuantityInStock = 180 },
                new Product { ID_Product = ID_Product37, SupplierID = ID_Supplier_id14, WarehouseID = ID_Warehouse1, ProductName = "Pumpkin Seeds", Producer = "Snack Time", Cell = "a136", UnitPrice = 4777.00m, QuantityInStock = 90 },
                new Product { ID_Product = ID_Product38, SupplierID = ID_Supplier2, WarehouseID = ID_Warehouse2, ProductName = "Zucchini", Producer = "Garden Fresh", Cell = "a137", UnitPrice = 1777.00m, QuantityInStock = 150 },
                new Product { ID_Product = ID_Product39, SupplierID = ID_Supplier3, WarehouseID = ID_Warehouse3, ProductName = "Coconut Milk", Producer = "Tropical Goods", Cell = "a138", UnitPrice = 2777.50m, QuantityInStock = 110 },
                new Product { ID_Product = ID_Product40, SupplierID = ID_Supplier4, WarehouseID = ID_Warehouse4, ProductName = "Rice Noodles", Producer = "Asian Cuisine", Cell = "a139", UnitPrice = 3777.50m, QuantityInStock = 130 }
            );

            // Seed data for Customers
            Guid ID_Customer1 = Guid.NewGuid();
            Guid ID_Customer2 = Guid.NewGuid();
            Guid ID_Customer3 = Guid.NewGuid();
            Guid ID_Customer4 = Guid.NewGuid();
            Guid ID_Customer5 = Guid.NewGuid();
            Guid ID_Customer6 = Guid.NewGuid();
            Guid ID_Customer7 = Guid.NewGuid();
            Guid ID_Customer8 = Guid.NewGuid();
            Guid ID_Customer9 = Guid.NewGuid();
            Guid ID_Customer10 = Guid.NewGuid();
            Guid ID_Customer11 = Guid.NewGuid();
            Guid ID_Customer12 = Guid.NewGuid();
            Guid ID_Customer13 = Guid.NewGuid();
            Guid ID_Customer14 = Guid.NewGuid();
            Guid ID_Customer15 = Guid.NewGuid();
            Guid ID_Customer16 = Guid.NewGuid();
            Guid ID_Customer17 = Guid.NewGuid();
            Guid ID_Customer18 = Guid.NewGuid();
            Guid ID_Customer19 = Guid.NewGuid();
            Guid ID_Customer20 = Guid.NewGuid();
            Guid ID_Customer21 = Guid.NewGuid();
            Guid ID_Customer22 = Guid.NewGuid();
            Guid ID_Customer23 = Guid.NewGuid();
            Guid ID_Customer24 = Guid.NewGuid();
            Guid ID_Customer25 = Guid.NewGuid();
            Guid ID_Customer26 = Guid.NewGuid();
            Guid ID_Customer27 = Guid.NewGuid();
            Guid ID_Customer28 = Guid.NewGuid();
            Guid ID_Customer29 = Guid.NewGuid();
            Guid ID_Customer30 = Guid.NewGuid();

            modelBuilder.Entity<Customer>().HasData(
                new Customer { ID_Customer = ID_Customer1, CustomerName = "John Doe", Phone = "111-222-3333", Email = "john.doe@example.com", Address = "123 Main St, Anytown, USA" },
                new Customer { ID_Customer = ID_Customer2, CustomerName = "Jane Smith", Phone = "444-555-6666", Email = "jane.smith@example.com", Address = "456 Elm St, Othertown, USA" },
                new Customer { ID_Customer = ID_Customer3, CustomerName = "Alice Johnson", Phone = "222-333-4444", Email = "alice.johnson@example.com", Address = "789 Pine St, Sometown, USA" },
                new Customer { ID_Customer = ID_Customer4, CustomerName = "Bob Brown", Phone = "555-666-7777", Email = "bob.brown@example.com", Address = "321 Oak St, Anothertown, USA" },
                new Customer { ID_Customer = ID_Customer5, CustomerName = "Charlie Davis", Phone = "888-999-0000", Email = "charlie.davis@example.com", Address = "135 Maple St, Newtown, USA" },
                new Customer { ID_Customer = ID_Customer6, CustomerName = "Diana Prince", Phone = "777-888-9999", Email = "diana.prince@example.com", Address = "246 Cedar St, Oldtown, USA" },
                new Customer { ID_Customer = ID_Customer7, CustomerName = "Ethan Hunt", Phone = "333-444-5555", Email = "ethan.hunt@example.com", Address = "357 Birch St, Yourtown, USA" },
                new Customer { ID_Customer = ID_Customer8, CustomerName = "Fiona Green", Phone = "666-777-8888", Email = "fiona.green@example.com", Address = "468 Spruce St, Hometown, USA" },
                new Customer { ID_Customer = ID_Customer9, CustomerName = "George White", Phone = "999-000-1111", Email = "george.white@example.com", Address = "579 Fir St, Thistown, USA" },
                new Customer { ID_Customer = ID_Customer10, CustomerName = "Hannah Blue", Phone = "222-111-3333", Email = "hannah.blue@example.com", Address = "680 Willow St, Thatown, USA" },
                new Customer { ID_Customer = ID_Customer11, CustomerName = "Ian Gray", Phone = "444-222-5555", Email = "ian.gray@example.com", Address = "791 Ash St, Anycity, USA" },
                new Customer { ID_Customer = ID_Customer12, CustomerName = "Julia Red", Phone = "555-333-6666", Email = "julia.red@example.com", Address = "802 Cherry St, Somecity, USA" },
                new Customer { ID_Customer = ID_Customer13, CustomerName = "Kevin Black", Phone = "666-444-7777", Email = "kevin.black@example.com", Address = "913 Peach St, Othercity, USA" },
                new Customer { ID_Customer = ID_Customer14, CustomerName = "Laura Pink", Phone = "777-555-8888", Email = "laura.pink@example.com", Address = "024 Plum St, Newcity, USA" },
                new Customer { ID_Customer = ID_Customer15, CustomerName = "Mike Yellow", Phone = "888-666-9999", Email = "mike.yellow@example.com", Address = "135 Lemon St, Oldcity, USA" },
                new Customer { ID_Customer = ID_Customer16, CustomerName = "Nina Cyan", Phone = "999-777-0000", Email = "nina.cyan@example.com", Address = "246 Lime St, Yourcity, USA" },
                new Customer { ID_Customer = ID_Customer17, CustomerName = "Oscar Magenta", Phone = "000-888-1111", Email = "oscar.magenta@example.com", Address = "357 Grape St, Thatcity, USA" },
                new Customer { ID_Customer = ID_Customer18, CustomerName = "Paula Teal", Phone = "111-999-2222", Email = "paula.teal@example.com", Address = "468 Berry St, Thiscity, USA" },
                new Customer { ID_Customer = ID_Customer19, CustomerName = "Quinn Brown", Phone = "222-000-3333", Email = "quinn.brown@example.com", Address = "579 Fig St, Anycity, USA" },
                new Customer { ID_Customer = ID_Customer20, CustomerName = "Rachel Silver", Phone = "333-111-4444", Email = "rachel.silver@example.com", Address = "680 Date St, Somecity, USA" },
                new Customer { ID_Customer = ID_Customer21, CustomerName = "Steve Gold", Phone = "444-222-5555", Email = "steve.gold@example.com", Address = "791 Olive St, Othercity, USA" },
                new Customer { ID_Customer = ID_Customer22, CustomerName = "Tina Copper", Phone = "555-333-6666", Email = "tina.copper@example.com", Address = "802 Walnut St, Newcity, USA" },
                new Customer { ID_Customer = ID_Customer23, CustomerName = "Ursula Bronze", Phone = "666-444-7777", Email = "ursula.bronze@example.com", Address = "913 Chestnut St, Oldcity, USA" },
                new Customer { ID_Customer = ID_Customer24, CustomerName = "Victor Steel", Phone = "777-555-8888", Email = "victor.steel@example.com", Address = "024 Maple St, Yourcity, USA" },
                new Customer { ID_Customer = ID_Customer25, CustomerName = "Wendy Iron", Phone = "888-666-9999", Email = "wendy.iron@example.com", Address = "135 Pineapple St, Thatcity, USA" },
                new Customer { ID_Customer = ID_Customer26, CustomerName = "Xander Zinc", Phone = "999-777-0000", Email = "xander.zinc@example.com", Address = "246 Coconut St, Thiscity, USA" },
                new Customer { ID_Customer = ID_Customer27, CustomerName = "Yvonne Nickel", Phone = "000-888-1111", Email = "yvonne.nickel@example.com", Address = "357 Papaya St, Anycity, USA" },
                new Customer { ID_Customer = ID_Customer28, CustomerName = "Zachary Lead", Phone = "111-999-2222", Email = "zachary.lead@example.com", Address = "680 Kiwi St, Somecity, USA" },
                new Customer { ID_Customer = ID_Customer29, CustomerName = "Alice Cooper", Phone = "222-000-3333", Email = "alice.cooper@example.com", Address = "791 Mango St, Othercity, USA" },
                new Customer { ID_Customer = ID_Customer30, CustomerName = "Bob Marley", Phone = "333-111-4444", Email = "bob.marley@example.com", Address = "802 Banana St, Newcity, USA" }
            );
            
            // Seed data for Orders
            Guid ID_Order1 = Guid.NewGuid();
            Guid ID_Order2 = Guid.NewGuid();
            Guid ID_Order3 = Guid.NewGuid();
            Guid ID_Order4 = Guid.NewGuid();
            Guid ID_Order5 = Guid.NewGuid();
            Guid ID_Order6 = Guid.NewGuid();
            Guid ID_Order7 = Guid.NewGuid();
            Guid ID_Order8 = Guid.NewGuid();
            Guid ID_Order9 = Guid.NewGuid();
            Guid ID_Order10 = Guid.NewGuid();
            Guid ID_Order11 = Guid.NewGuid();
            Guid ID_Order12 = Guid.NewGuid();
            Guid ID_Order13 = Guid.NewGuid();
            Guid ID_Order14 = Guid.NewGuid();

            modelBuilder.Entity<Order>().HasData(
                new Order { ID_Order = ID_Order1, CustomerID = ID_Customer1, TotalAmount = 35.00m, OrderDate = DateTime.UtcNow, Status = "Completed" },
                new Order { ID_Order = ID_Order2, CustomerID = ID_Customer2, TotalAmount = 20.00m, OrderDate = DateTime.UtcNow, Status = "Pending" },
                new Order { ID_Order = ID_Order3, CustomerID = ID_Customer3, TotalAmount = 80.00m, OrderDate = DateTime.UtcNow, Status = "Completed" },
                new Order { ID_Order = ID_Order4, CustomerID = ID_Customer4, TotalAmount = 70.00m, OrderDate = DateTime.UtcNow, Status = "Shipped" },
                new Order { ID_Order = ID_Order5, CustomerID = ID_Customer5, TotalAmount = 300.50m, OrderDate = DateTime.UtcNow, Status = "Completed" },
                new Order { ID_Order = ID_Order6, CustomerID = ID_Customer6, TotalAmount = 300.50m, OrderDate = DateTime.UtcNow, Status = "Pending" },
                new Order { ID_Order = ID_Order7, CustomerID = ID_Customer7, TotalAmount = 6000.50m, OrderDate = DateTime.UtcNow, Status = "Shipped" },
                new Order { ID_Order = ID_Order8, CustomerID = ID_Customer8, TotalAmount = 5001.30m, OrderDate = DateTime.UtcNow, Status = "Completed" },
                new Order { ID_Order = ID_Order9, CustomerID = ID_Customer9, TotalAmount = 11000.20m, OrderDate = DateTime.UtcNow, Status = "Pending" },
                new Order { ID_Order = ID_Order10, CustomerID = ID_Customer10, TotalAmount = 3500.00m, OrderDate = DateTime.UtcNow, Status = "Completed" },
                new Order { ID_Order = ID_Order11, CustomerID = ID_Customer11, TotalAmount = 800.00m, OrderDate = DateTime.UtcNow, Status = "Pending" },
                new Order { ID_Order = ID_Order12, CustomerID = ID_Customer12, TotalAmount = 1400.20m, OrderDate = DateTime.UtcNow, Status = "Shipped" },
                new Order { ID_Order = ID_Order13, CustomerID = ID_Customer13, TotalAmount = 3201.00m, OrderDate = DateTime.UtcNow, Status = "Completed" },
                new Order { ID_Order = ID_Order14, CustomerID = ID_Customer14, TotalAmount = 6300.80m, OrderDate = DateTime.UtcNow, Status = "Pending" }
            );
            
            // Seed data for OrderDetails
            Guid ID_OrderDetails1 = Guid.NewGuid();
            Guid ID_OrderDetails2 = Guid.NewGuid();
            Guid ID_OrderDetails3 = Guid.NewGuid();
            Guid ID_OrderDetails4 = Guid.NewGuid();
            Guid ID_OrderDetails5 = Guid.NewGuid();
            Guid ID_OrderDetails6 = Guid.NewGuid();
            Guid ID_OrderDetails7 = Guid.NewGuid();
            Guid ID_OrderDetails8 = Guid.NewGuid();
            Guid ID_OrderDetails9 = Guid.NewGuid();
            Guid ID_OrderDetails10 = Guid.NewGuid();
            Guid ID_OrderDetails11 = Guid.NewGuid();
            Guid ID_OrderDetails12 = Guid.NewGuid();
            Guid ID_OrderDetails13 = Guid.NewGuid();
            Guid ID_OrderDetails14 = Guid.NewGuid();
            Guid ID_OrderDetails15 = Guid.NewGuid();
            Guid ID_OrderDetails16 = Guid.NewGuid();
            Guid ID_OrderDetails17 = Guid.NewGuid();
            Guid ID_OrderDetails18 = Guid.NewGuid();
            Guid ID_OrderDetails19 = Guid.NewGuid();
            Guid ID_OrderDetails20 = Guid.NewGuid();
            Guid ID_OrderDetails21 = Guid.NewGuid();
            Guid ID_OrderDetails22 = Guid.NewGuid();
            Guid ID_OrderDetails23 = Guid.NewGuid();
            Guid ID_OrderDetails24 = Guid.NewGuid();
            Guid ID_OrderDetails25 = Guid.NewGuid();
            Guid ID_OrderDetails26 = Guid.NewGuid();

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { ID_OrderDetails = ID_OrderDetails1, OrderId = ID_Order1, ProductId = ID_Product1, Quantity = 2, UnitPrice = 10.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails2, OrderId = ID_Order1, ProductId = ID_Product2, Quantity = 1, UnitPrice = 15.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails3, OrderId = ID_Order2, ProductId = ID_Product3, Quantity = 1, UnitPrice = 20.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails4, OrderId = ID_Order3, ProductId = ID_Product4, Quantity = 2, UnitPrice = 25.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails5, OrderId = ID_Order3, ProductId = ID_Product5, Quantity = 1, UnitPrice = 30.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails6, OrderId = ID_Order4, ProductId = ID_Product6, Quantity = 2, UnitPrice = 35.00m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails7, OrderId = ID_Order5, ProductId = ID_Product7, Quantity = 1, UnitPrice = 100.50m }, // Organic Apples
                new OrderDetail { ID_OrderDetails = ID_OrderDetails8, OrderId = ID_Order5, ProductId = ID_Product8, Quantity = 1, UnitPrice = 200.00m }, // Whole Wheat Bread
                new OrderDetail { ID_OrderDetails = ID_OrderDetails9, OrderId = ID_Order6, ProductId = ID_Product9, Quantity = 1, UnitPrice = 300.50m }, // Almond Milk
                new OrderDetail { ID_OrderDetails = ID_OrderDetails10, OrderId = ID_Order7, ProductId = ID_Product10, Quantity = 1, UnitPrice = 4000.00m }, // Greek Yogurt
                new OrderDetail { ID_OrderDetails = ID_OrderDetails11, OrderId = ID_Order7, ProductId = ID_Product11, Quantity = 1, UnitPrice = 2000.50m }, // Free-Range Eggs
                new OrderDetail { ID_OrderDetails = ID_OrderDetails12, OrderId = ID_Order8, ProductId = ID_Product12, Quantity = 1, UnitPrice = 1000.80m }, // Brown Rice
                new OrderDetail { ID_OrderDetails = ID_OrderDetails13, OrderId = ID_Order8, ProductId = ID_Product13, Quantity = 1, UnitPrice = 4000.50m }, // Quinoa
                new OrderDetail { ID_OrderDetails = ID_OrderDetails14, OrderId = ID_Order9, ProductId = ID_Product14, Quantity = 1, UnitPrice = 6000.00m }, // Coconut Oil
                new OrderDetail { ID_OrderDetails = ID_OrderDetails15, OrderId = ID_Order9, ProductId = ID_Product15, Quantity = 1, UnitPrice = 3000.00m }, // Dark Chocolate
                new OrderDetail { ID_OrderDetails = ID_OrderDetails16, OrderId = ID_Order9, ProductId = ID_Product16, Quantity = 1, UnitPrice = 2000.20m },
                new OrderDetail { ID_OrderDetails = ID_OrderDetails17, OrderId = ID_Order10, ProductId = ID_Product17, Quantity = 1, UnitPrice = 3000.00m }, // Oatmeal
                new OrderDetail { ID_OrderDetails = ID_OrderDetails18, OrderId = ID_Order10, ProductId = ID_Product18, Quantity = 1, UnitPrice = 500.00m }, // Chia Seeds
                new OrderDetail { ID_OrderDetails = ID_OrderDetails19, OrderId = ID_Order11, ProductId = ID_Product19, Quantity = 1, UnitPrice = 800.00m }, // Avocado Oil
                new OrderDetail { ID_OrderDetails = ID_OrderDetails20, OrderId = ID_Order12, ProductId = ID_Product20, Quantity = 1, UnitPrice = 1000.20m }, // Canned Chickpeas
                new OrderDetail { ID_OrderDetails = ID_OrderDetails21, OrderId = ID_Order12, ProductId = ID_Product21, Quantity = 1, UnitPrice = 400.00m }, // Frozen Berries
                new OrderDetail { ID_OrderDetails = ID_OrderDetails22, OrderId = ID_Order13, ProductId = ID_Product22, Quantity = 1, UnitPrice = 3000.50m }, // Peanut Butter
                new OrderDetail { ID_OrderDetails = ID_OrderDetails23, OrderId = ID_Order13, ProductId = ID_Product23, Quantity = 1, UnitPrice = 200.50m }, // Coconut Water
                new OrderDetail { ID_OrderDetails = ID_OrderDetails24, OrderId = ID_Order14, ProductId = ID_Product24, Quantity = 1, UnitPrice = 100.80m }, // Granola Bars
                new OrderDetail { ID_OrderDetails = ID_OrderDetails25, OrderId = ID_Order14, ProductId = ID_Product25, Quantity = 1, UnitPrice = 200.00m }, // Hummus
                new OrderDetail { ID_OrderDetails = ID_OrderDetails26, OrderId = ID_Order14, ProductId = ID_Product26, Quantity = 1, UnitPrice = 6000.00m }
            );
        }
    }
}