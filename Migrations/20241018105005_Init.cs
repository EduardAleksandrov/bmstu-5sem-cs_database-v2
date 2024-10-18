using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID_Customer = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Auto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID_Customer);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID_Supplier = table.Column<Guid>(type: "uuid", nullable: false),
                    SupplierName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    ContactName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Auto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID_Supplier);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    ID_Warehouse = table.Column<Guid>(type: "uuid", nullable: false),
                    WarehouseName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Location = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: false),
                    ManagerName = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    Auto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.ID_Warehouse);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID_Order = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uuid", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Auto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID_Order);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID_Customer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID_Product = table.Column<Guid>(type: "uuid", nullable: false),
                    SupplierID = table.Column<Guid>(type: "uuid", nullable: false),
                    WarehouseID = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductName = table.Column<string>(type: "character varying(800)", maxLength: 800, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    QuantityInStock = table.Column<int>(type: "integer", nullable: false),
                    Auto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID_Product);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID_Supplier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "ID_Warehouse",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID_OrderDetails = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Auto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID_OrderDetails);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "ID_Order",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID_Product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID_Customer", "Address", "CustomerName", "Email", "Phone" },
                values: new object[,]
                {
                    { new Guid("682b7d05-a744-4c9b-a828-6bd700c4a16d"), "123 Main St, Anytown, USA", "John Doe", "john.doe@example.com", "111-222-3333" },
                    { new Guid("d288a406-4540-4fef-8b92-6620bb45a715"), "456 Elm St, Othertown, USA", "Jane Smith", "jane.smith@example.com", "444-555-6666" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID_Supplier", "ContactName", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { new Guid("43c0313e-60d5-4209-a72c-9a115f8b2b0d"), "Bob", "bob@supplier.com", "098-765-4321", "Supplier B" },
                    { new Guid("b622cdde-ca1f-425f-bf28-44558976647f"), "Alice", "alice@supplier.com", "123-456-7890", "Supplier A" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "ID_Warehouse", "Capacity", "Location", "ManagerName", "WarehouseName" },
                values: new object[,]
                {
                    { new Guid("6ba477ab-a78d-4afa-8de2-863529e4aa3d"), 2000, "Location B", "Manager B", "Warehouse 2" },
                    { new Guid("99467b92-232f-442f-8c54-f36a64dedcc5"), 1000, "Location A", "Manager A", "Warehouse 1" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID_Order", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("166c07bf-b0a0-4383-8d27-9c8900dcff3b"), new Guid("682b7d05-a744-4c9b-a828-6bd700c4a16d"), new DateTime(2024, 10, 18, 10, 50, 5, 445, DateTimeKind.Utc).AddTicks(6564), "Completed", 25.00m },
                    { new Guid("2d92985c-e2f1-4a10-b868-2d53b4149d52"), new Guid("d288a406-4540-4fef-8b92-6620bb45a715"), new DateTime(2024, 10, 18, 10, 50, 5, 445, DateTimeKind.Utc).AddTicks(6570), "Pending", 30.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID_Product", "ProductName", "QuantityInStock", "SupplierID", "UnitPrice", "WarehouseID" },
                values: new object[,]
                {
                    { new Guid("3079a0ac-680e-4576-b66c-d98db7f7f906"), "Product 1", 100, new Guid("b622cdde-ca1f-425f-bf28-44558976647f"), 10.00m, new Guid("99467b92-232f-442f-8c54-f36a64dedcc5") },
                    { new Guid("e1c7b261-0a7b-4059-ac7e-11eeb7a8a924"), "Product 3", 150, new Guid("43c0313e-60d5-4209-a72c-9a115f8b2b0d"), 20.00m, new Guid("6ba477ab-a78d-4afa-8de2-863529e4aa3d") },
                    { new Guid("f9c2b5f4-9a87-4894-89d0-e46c23f38518"), "Product 2", 200, new Guid("b622cdde-ca1f-425f-bf28-44558976647f"), 15.00m, new Guid("99467b92-232f-442f-8c54-f36a64dedcc5") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "ID_OrderDetails", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("812b2b73-7921-4dc7-b51f-6dc190cffa08"), new Guid("166c07bf-b0a0-4383-8d27-9c8900dcff3b"), new Guid("f9c2b5f4-9a87-4894-89d0-e46c23f38518"), 1, 15.00m },
                    { new Guid("97a1c8f3-8b6b-4dce-9196-f2587b35f24d"), new Guid("2d92985c-e2f1-4a10-b868-2d53b4149d52"), new Guid("e1c7b261-0a7b-4059-ac7e-11eeb7a8a924"), 1, 20.00m },
                    { new Guid("bb7c67a1-59a6-450a-a5b3-ae0ef9f5a3e1"), new Guid("166c07bf-b0a0-4383-8d27-9c8900dcff3b"), new Guid("3079a0ac-680e-4576-b66c-d98db7f7f906"), 2, 10.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WarehouseID",
                table: "Products",
                column: "WarehouseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
