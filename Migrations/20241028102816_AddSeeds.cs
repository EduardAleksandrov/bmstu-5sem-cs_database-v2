using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("812b2b73-7921-4dc7-b51f-6dc190cffa08"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("97a1c8f3-8b6b-4dce-9196-f2587b35f24d"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("bb7c67a1-59a6-450a-a5b3-ae0ef9f5a3e1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("166c07bf-b0a0-4383-8d27-9c8900dcff3b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("2d92985c-e2f1-4a10-b868-2d53b4149d52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3079a0ac-680e-4576-b66c-d98db7f7f906"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("e1c7b261-0a7b-4059-ac7e-11eeb7a8a924"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("f9c2b5f4-9a87-4894-89d0-e46c23f38518"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("682b7d05-a744-4c9b-a828-6bd700c4a16d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("d288a406-4540-4fef-8b92-6620bb45a715"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("43c0313e-60d5-4209-a72c-9a115f8b2b0d"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("b622cdde-ca1f-425f-bf28-44558976647f"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("6ba477ab-a78d-4afa-8de2-863529e4aa3d"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("99467b92-232f-442f-8c54-f36a64dedcc5"));

            migrationBuilder.AddColumn<string>(
                name: "Producer",
                table: "Products",
                type: "character varying(800)",
                maxLength: 800,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID_Customer", "Address", "CustomerName", "Email", "Phone" },
                values: new object[,]
                {
                    { new Guid("5dde43ea-efc2-4890-9ca1-a083f5845c4d"), "789 Pine St, Sometown, USA", "Alice Johnson", "alice.johnson@example.com", "222-333-4444" },
                    { new Guid("cd10daad-9572-41b5-a0cb-a4cf89740b13"), "321 Oak St, Anothertown, USA", "Bob Brown", "bob.brown@example.com", "555-666-7777" },
                    { new Guid("d5b8dcce-07c9-428b-ab93-88ca6ca1eeb4"), "456 Elm St, Othertown, USA", "Jane Smith", "jane.smith@example.com", "444-555-6666" },
                    { new Guid("dbaaf315-b12f-48a2-90ae-44ab9e8c927e"), "123 Main St, Anytown, USA", "John Doe", "john.doe@example.com", "111-222-3333" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID_Supplier", "ContactName", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { new Guid("3366d527-f425-4951-97ff-76c51f22ac15"), "Charlie", "charlie@supplier.com", "321-654-0987", "Supplier C" },
                    { new Guid("b9bf157c-4a39-484e-8c5d-4ce21bb4d420"), "Bob", "bob@supplier.com", "098-765-4321", "Supplier B" },
                    { new Guid("cb8c6415-4feb-4615-bda4-35f2404fa63b"), "Diana", "diana@supplier.com", "987-654-3210", "Supplier D" },
                    { new Guid("e47e5495-d0cd-43e0-afca-3716aea53e9c"), "Alice", "alice@supplier.com", "123-456-7890", "Supplier A" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "ID_Warehouse", "Capacity", "Location", "ManagerName", "WarehouseName" },
                values: new object[,]
                {
                    { new Guid("10eb5383-8f4d-43ec-887b-a220ee17ade4"), 1000, "Location A", "Manager A", "Warehouse 1" },
                    { new Guid("177c534f-f59c-4f99-bd79-ad99828c1d29"), 1500, "Location C", "Manager C", "Warehouse 3" },
                    { new Guid("39aaf70b-dcff-43a0-9ca1-00b945cbb761"), 2500, "Location D", "Manager D", "Warehouse 4" },
                    { new Guid("b6d0d532-7005-4ac1-9f6f-9cb41eb9fa3d"), 2000, "Location B", "Manager B", "Warehouse 2" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID_Order", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("4715c991-cadf-46b8-8d5d-7c3345662a6f"), new Guid("dbaaf315-b12f-48a2-90ae-44ab9e8c927e"), new DateTime(2024, 10, 28, 10, 28, 15, 658, DateTimeKind.Utc).AddTicks(580), "Completed", 25.00m },
                    { new Guid("6c9adfe8-cee0-4c77-a4ac-e72aefac0467"), new Guid("cd10daad-9572-41b5-a0cb-a4cf89740b13"), new DateTime(2024, 10, 28, 10, 28, 15, 658, DateTimeKind.Utc).AddTicks(592), "Shipped", 70.00m },
                    { new Guid("b49bb357-cf70-4ecc-b7a5-5aef750eb35a"), new Guid("d5b8dcce-07c9-428b-ab93-88ca6ca1eeb4"), new DateTime(2024, 10, 28, 10, 28, 15, 658, DateTimeKind.Utc).AddTicks(584), "Pending", 30.00m },
                    { new Guid("ddbcdb77-31c9-481d-9788-f700a1d57325"), new Guid("5dde43ea-efc2-4890-9ca1-a083f5845c4d"), new DateTime(2024, 10, 28, 10, 28, 15, 658, DateTimeKind.Utc).AddTicks(588), "Completed", 50.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID_Product", "Producer", "ProductName", "QuantityInStock", "SupplierID", "UnitPrice", "WarehouseID" },
                values: new object[,]
                {
                    { new Guid("1bf9e1cf-4708-409a-b902-33515b025bac"), "Producer 2", "Product 2", 200, new Guid("e47e5495-d0cd-43e0-afca-3716aea53e9c"), 15.00m, new Guid("10eb5383-8f4d-43ec-887b-a220ee17ade4") },
                    { new Guid("1e2fbe56-ff03-4dc8-9272-07c514ccdd33"), "Producer 1", "Product 1", 100, new Guid("e47e5495-d0cd-43e0-afca-3716aea53e9c"), 10.00m, new Guid("10eb5383-8f4d-43ec-887b-a220ee17ade4") },
                    { new Guid("3f8b7d19-df8b-4b3f-8d8f-7f6065e65272"), "Producer 6", "Product 6", 40, new Guid("cb8c6415-4feb-4615-bda4-35f2404fa63b"), 35.00m, new Guid("39aaf70b-dcff-43a0-9ca1-00b945cbb761") },
                    { new Guid("62929d0f-cd54-4707-a300-9e97f76277d2"), "Producer 3", "Product 3", 150, new Guid("b9bf157c-4a39-484e-8c5d-4ce21bb4d420"), 20.00m, new Guid("b6d0d532-7005-4ac1-9f6f-9cb41eb9fa3d") },
                    { new Guid("666e14f6-25b4-46f5-ab4d-4318e5369991"), "Producer 5", "Product 5", 60, new Guid("3366d527-f425-4951-97ff-76c51f22ac15"), 30.00m, new Guid("177c534f-f59c-4f99-bd79-ad99828c1d29") },
                    { new Guid("bf2b0fc6-863d-4f7f-ab14-987350645e2d"), "Producer 4", "Product 4", 80, new Guid("3366d527-f425-4951-97ff-76c51f22ac15"), 25.00m, new Guid("177c534f-f59c-4f99-bd79-ad99828c1d29") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "ID_OrderDetails", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("0dd0b168-7011-4522-b9c1-f193eeee5ec9"), new Guid("6c9adfe8-cee0-4c77-a4ac-e72aefac0467"), new Guid("3f8b7d19-df8b-4b3f-8d8f-7f6065e65272"), 2, 35.00m },
                    { new Guid("712abce0-c8a1-4409-951f-0dd33d3be448"), new Guid("4715c991-cadf-46b8-8d5d-7c3345662a6f"), new Guid("1e2fbe56-ff03-4dc8-9272-07c514ccdd33"), 2, 10.00m },
                    { new Guid("76b15641-1b5c-40c1-8197-cae39ab812a1"), new Guid("4715c991-cadf-46b8-8d5d-7c3345662a6f"), new Guid("1bf9e1cf-4708-409a-b902-33515b025bac"), 1, 15.00m },
                    { new Guid("82e6cfe6-5937-4b91-94c4-63c94415964c"), new Guid("ddbcdb77-31c9-481d-9788-f700a1d57325"), new Guid("bf2b0fc6-863d-4f7f-ab14-987350645e2d"), 2, 25.00m },
                    { new Guid("e1016e01-6976-4ba7-9072-37a1f58ef51f"), new Guid("ddbcdb77-31c9-481d-9788-f700a1d57325"), new Guid("666e14f6-25b4-46f5-ab4d-4318e5369991"), 1, 30.00m },
                    { new Guid("fdd06504-7d59-4fbb-9514-8b42b017ffc2"), new Guid("b49bb357-cf70-4ecc-b7a5-5aef750eb35a"), new Guid("62929d0f-cd54-4707-a300-9e97f76277d2"), 1, 20.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("0dd0b168-7011-4522-b9c1-f193eeee5ec9"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("712abce0-c8a1-4409-951f-0dd33d3be448"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("76b15641-1b5c-40c1-8197-cae39ab812a1"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("82e6cfe6-5937-4b91-94c4-63c94415964c"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("e1016e01-6976-4ba7-9072-37a1f58ef51f"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("fdd06504-7d59-4fbb-9514-8b42b017ffc2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("4715c991-cadf-46b8-8d5d-7c3345662a6f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("6c9adfe8-cee0-4c77-a4ac-e72aefac0467"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("b49bb357-cf70-4ecc-b7a5-5aef750eb35a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("ddbcdb77-31c9-481d-9788-f700a1d57325"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("1bf9e1cf-4708-409a-b902-33515b025bac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("1e2fbe56-ff03-4dc8-9272-07c514ccdd33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3f8b7d19-df8b-4b3f-8d8f-7f6065e65272"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("62929d0f-cd54-4707-a300-9e97f76277d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("666e14f6-25b4-46f5-ab4d-4318e5369991"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("bf2b0fc6-863d-4f7f-ab14-987350645e2d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("5dde43ea-efc2-4890-9ca1-a083f5845c4d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("cd10daad-9572-41b5-a0cb-a4cf89740b13"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("d5b8dcce-07c9-428b-ab93-88ca6ca1eeb4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("dbaaf315-b12f-48a2-90ae-44ab9e8c927e"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("3366d527-f425-4951-97ff-76c51f22ac15"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("b9bf157c-4a39-484e-8c5d-4ce21bb4d420"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("cb8c6415-4feb-4615-bda4-35f2404fa63b"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("e47e5495-d0cd-43e0-afca-3716aea53e9c"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("10eb5383-8f4d-43ec-887b-a220ee17ade4"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("177c534f-f59c-4f99-bd79-ad99828c1d29"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("39aaf70b-dcff-43a0-9ca1-00b945cbb761"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("b6d0d532-7005-4ac1-9f6f-9cb41eb9fa3d"));

            migrationBuilder.DropColumn(
                name: "Producer",
                table: "Products");

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
        }
    }
}
