using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Celladd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("5debb45f-46cf-4bab-addf-33dfd54c4cef"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("85869e2e-0f8b-429b-b3c6-b9ba348205dd"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("9605de62-ca9d-47c3-b4f4-bf7c9fc1935c"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("ae56d31c-4061-443a-909a-72832316c9d6"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("e0e6da09-90d1-4c25-b249-a7f99819ba31"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("e319e9d5-8b55-4652-8d49-017d14b9a2f6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("122189ba-dcff-45fa-95e0-c6c730cea839"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("1c318181-eba4-4257-b814-b23c7060c232"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("58f5608d-3576-4ce4-921c-cfc1eac38346"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("84baad39-9601-4def-ab33-0375b546a364"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("27274e5a-ec71-46ce-a3c2-6ae38ccf7f04"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("2be1bc92-f148-4982-868d-8730fcb36e94"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3d86c84d-3eeb-4716-92a7-ab46c2285b24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("7ae5747f-d93a-48d3-aa66-286c8ac96866"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("7bda535b-8987-441a-a27c-a3f17130057e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("ab71556f-0eef-4112-8c4a-ec1c38fc0ab7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("74368c6f-2875-4f41-88c9-a5c1cc7411bd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("7df7e5c6-7827-47ef-989e-a872099081b1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("9ce6f493-f800-4080-bfb2-174a33fa1db9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("ed43fb00-1cf9-4302-a462-7a14d256f7df"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("423e412e-5bc4-40e8-a293-b6ff00da0858"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("56f552cd-e7d3-431a-b141-38cafe618b60"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("9249059d-a860-4abd-a5af-b7e903b69381"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("a3fe4dc4-dbf1-4933-b07b-33f4da24816c"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("9ddcc8e3-681d-4fc8-9d1f-d1f25b4f7cfa"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("bc0ace60-4af9-423f-ab19-e9deb97c38aa"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("ccd019cf-68d6-42e2-87b3-6240b5137ffb"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("cfc02977-4cb7-4979-80da-866a23282440"));

            migrationBuilder.AddColumn<string>(
                name: "Cell",
                table: "Products",
                type: "character varying(800)",
                maxLength: 800,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID_Customer", "Address", "CustomerName", "Email", "Phone" },
                values: new object[,]
                {
                    { new Guid("079803a8-edfd-480f-8727-a9f68a0695b7"), "789 Pine St, Sometown, USA", "Alice Johnson", "alice.johnson@example.com", "222-333-4444" },
                    { new Guid("08d4e9f2-df76-4057-849d-9e86c882a9f6"), "456 Elm St, Othertown, USA", "Jane Smith", "jane.smith@example.com", "444-555-6666" },
                    { new Guid("6e91d741-be01-40f4-8694-bffead189ca8"), "321 Oak St, Anothertown, USA", "Bob Brown", "bob.brown@example.com", "555-666-7777" },
                    { new Guid("deeea0e9-096e-45f9-9411-387a66eac70f"), "123 Main St, Anytown, USA", "John Doe", "john.doe@example.com", "111-222-3333" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID_Supplier", "ContactName", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { new Guid("4ab6969a-79cd-4f8b-b031-d75d608ac69a"), "Charlie", "charlie@supplier.com", "321-654-0987", "Supplier C" },
                    { new Guid("7f6216db-5696-4b47-a0d7-7522811b800c"), "Bob", "bob@supplier.com", "098-765-4321", "Supplier B" },
                    { new Guid("8c101589-4f3e-4e68-b4ab-e2a7865b04e4"), "Alice", "alice@supplier.com", "123-456-7890", "Supplier A" },
                    { new Guid("f36c1003-7533-406a-91b4-f39db2586d1f"), "Diana", "diana@supplier.com", "987-654-3210", "Supplier D" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "ID_Warehouse", "Capacity", "Location", "ManagerName", "WarehouseName" },
                values: new object[,]
                {
                    { new Guid("24a7253d-a080-4de8-a276-4c51023bc2f2"), 1000, "Location A", "Manager A", "Warehouse 1" },
                    { new Guid("3f88d6f5-f73b-4b26-98ac-366976420924"), 1500, "Location C", "Manager C", "Warehouse 3" },
                    { new Guid("654fe7db-a286-4954-9659-f63c3dea2561"), 2000, "Location B", "Manager B", "Warehouse 2" },
                    { new Guid("f1c35c81-6a13-4081-9a1e-a78174f5a509"), 2500, "Location D", "Manager D", "Warehouse 4" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID_Order", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("6df16525-d3ed-4aea-b2ed-4f339eb4ff00"), new Guid("079803a8-edfd-480f-8727-a9f68a0695b7"), new DateTime(2024, 10, 29, 8, 14, 59, 60, DateTimeKind.Utc).AddTicks(9319), "Completed", 50.00m },
                    { new Guid("abe81b9d-1c56-468d-a30f-2ff4d17b547b"), new Guid("6e91d741-be01-40f4-8694-bffead189ca8"), new DateTime(2024, 10, 29, 8, 14, 59, 60, DateTimeKind.Utc).AddTicks(9323), "Shipped", 70.00m },
                    { new Guid("d16665d6-ec3b-4628-8551-dc8d7eb92a9e"), new Guid("08d4e9f2-df76-4057-849d-9e86c882a9f6"), new DateTime(2024, 10, 29, 8, 14, 59, 60, DateTimeKind.Utc).AddTicks(9315), "Pending", 30.00m },
                    { new Guid("d88e0641-41a3-4bcc-ace5-a939ec3612ca"), new Guid("deeea0e9-096e-45f9-9411-387a66eac70f"), new DateTime(2024, 10, 29, 8, 14, 59, 60, DateTimeKind.Utc).AddTicks(9306), "Completed", 25.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID_Product", "Cell", "Producer", "ProductName", "QuantityInStock", "SupplierID", "UnitPrice", "WarehouseID" },
                values: new object[,]
                {
                    { new Guid("18344cc7-03b8-4a3a-8aee-6f2cd6fb2156"), "a105", "Producer 3", "Product 6", 40, new Guid("f36c1003-7533-406a-91b4-f39db2586d1f"), 35.00m, new Guid("f1c35c81-6a13-4081-9a1e-a78174f5a509") },
                    { new Guid("225cb8bf-0d64-4e14-a3c5-9bf0aabf19c8"), "a103", "Producer 2", "Product 4", 80, new Guid("4ab6969a-79cd-4f8b-b031-d75d608ac69a"), 25.00m, new Guid("3f88d6f5-f73b-4b26-98ac-366976420924") },
                    { new Guid("3658ac8c-7640-43dd-86a7-bb69b10ffbf6"), "a101", "Producer 2", "Product 2", 200, new Guid("8c101589-4f3e-4e68-b4ab-e2a7865b04e4"), 15.00m, new Guid("24a7253d-a080-4de8-a276-4c51023bc2f2") },
                    { new Guid("41bcbcfc-241e-488b-af2a-5f6a5dbb0e06"), "a104", "Producer 3", "Product 5", 60, new Guid("4ab6969a-79cd-4f8b-b031-d75d608ac69a"), 30.00m, new Guid("3f88d6f5-f73b-4b26-98ac-366976420924") },
                    { new Guid("44951b94-d737-4c0e-9ef7-d29dd366175b"), "a100", "Producer 1", "Product 1", 100, new Guid("8c101589-4f3e-4e68-b4ab-e2a7865b04e4"), 10.00m, new Guid("24a7253d-a080-4de8-a276-4c51023bc2f2") },
                    { new Guid("cb03ff15-967a-435b-b9d1-e2458430aa78"), "a102", "Producer 2", "Product 3", 150, new Guid("7f6216db-5696-4b47-a0d7-7522811b800c"), 20.00m, new Guid("654fe7db-a286-4954-9659-f63c3dea2561") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "ID_OrderDetails", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("37e93242-069d-483a-ba6b-8ef23a2f6716"), new Guid("d88e0641-41a3-4bcc-ace5-a939ec3612ca"), new Guid("44951b94-d737-4c0e-9ef7-d29dd366175b"), 2, 10.00m },
                    { new Guid("4b94a5a9-f803-42d6-8b22-cd5898b3a7e5"), new Guid("d88e0641-41a3-4bcc-ace5-a939ec3612ca"), new Guid("3658ac8c-7640-43dd-86a7-bb69b10ffbf6"), 1, 15.00m },
                    { new Guid("576b19fe-a493-4b2c-be3b-45f9def2f219"), new Guid("6df16525-d3ed-4aea-b2ed-4f339eb4ff00"), new Guid("225cb8bf-0d64-4e14-a3c5-9bf0aabf19c8"), 2, 25.00m },
                    { new Guid("95bd81f1-8e17-493f-8097-68afec0bac71"), new Guid("abe81b9d-1c56-468d-a30f-2ff4d17b547b"), new Guid("18344cc7-03b8-4a3a-8aee-6f2cd6fb2156"), 2, 35.00m },
                    { new Guid("db579e5e-1e39-4cc8-8f0c-3e7b5b62a52b"), new Guid("d16665d6-ec3b-4628-8551-dc8d7eb92a9e"), new Guid("cb03ff15-967a-435b-b9d1-e2458430aa78"), 1, 20.00m },
                    { new Guid("e4f27535-8b80-4f64-966f-1708e126d41f"), new Guid("6df16525-d3ed-4aea-b2ed-4f339eb4ff00"), new Guid("41bcbcfc-241e-488b-af2a-5f6a5dbb0e06"), 1, 30.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("37e93242-069d-483a-ba6b-8ef23a2f6716"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("4b94a5a9-f803-42d6-8b22-cd5898b3a7e5"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("576b19fe-a493-4b2c-be3b-45f9def2f219"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("95bd81f1-8e17-493f-8097-68afec0bac71"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("db579e5e-1e39-4cc8-8f0c-3e7b5b62a52b"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("e4f27535-8b80-4f64-966f-1708e126d41f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("6df16525-d3ed-4aea-b2ed-4f339eb4ff00"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("abe81b9d-1c56-468d-a30f-2ff4d17b547b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("d16665d6-ec3b-4628-8551-dc8d7eb92a9e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("d88e0641-41a3-4bcc-ace5-a939ec3612ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("18344cc7-03b8-4a3a-8aee-6f2cd6fb2156"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("225cb8bf-0d64-4e14-a3c5-9bf0aabf19c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3658ac8c-7640-43dd-86a7-bb69b10ffbf6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("41bcbcfc-241e-488b-af2a-5f6a5dbb0e06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("44951b94-d737-4c0e-9ef7-d29dd366175b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("cb03ff15-967a-435b-b9d1-e2458430aa78"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("079803a8-edfd-480f-8727-a9f68a0695b7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("08d4e9f2-df76-4057-849d-9e86c882a9f6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("6e91d741-be01-40f4-8694-bffead189ca8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("deeea0e9-096e-45f9-9411-387a66eac70f"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("4ab6969a-79cd-4f8b-b031-d75d608ac69a"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("7f6216db-5696-4b47-a0d7-7522811b800c"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("8c101589-4f3e-4e68-b4ab-e2a7865b04e4"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("f36c1003-7533-406a-91b4-f39db2586d1f"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("24a7253d-a080-4de8-a276-4c51023bc2f2"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("3f88d6f5-f73b-4b26-98ac-366976420924"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("654fe7db-a286-4954-9659-f63c3dea2561"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("f1c35c81-6a13-4081-9a1e-a78174f5a509"));

            migrationBuilder.DropColumn(
                name: "Cell",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID_Customer", "Address", "CustomerName", "Email", "Phone" },
                values: new object[,]
                {
                    { new Guid("74368c6f-2875-4f41-88c9-a5c1cc7411bd"), "789 Pine St, Sometown, USA", "Alice Johnson", "alice.johnson@example.com", "222-333-4444" },
                    { new Guid("7df7e5c6-7827-47ef-989e-a872099081b1"), "456 Elm St, Othertown, USA", "Jane Smith", "jane.smith@example.com", "444-555-6666" },
                    { new Guid("9ce6f493-f800-4080-bfb2-174a33fa1db9"), "123 Main St, Anytown, USA", "John Doe", "john.doe@example.com", "111-222-3333" },
                    { new Guid("ed43fb00-1cf9-4302-a462-7a14d256f7df"), "321 Oak St, Anothertown, USA", "Bob Brown", "bob.brown@example.com", "555-666-7777" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID_Supplier", "ContactName", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { new Guid("423e412e-5bc4-40e8-a293-b6ff00da0858"), "Alice", "alice@supplier.com", "123-456-7890", "Supplier A" },
                    { new Guid("56f552cd-e7d3-431a-b141-38cafe618b60"), "Diana", "diana@supplier.com", "987-654-3210", "Supplier D" },
                    { new Guid("9249059d-a860-4abd-a5af-b7e903b69381"), "Bob", "bob@supplier.com", "098-765-4321", "Supplier B" },
                    { new Guid("a3fe4dc4-dbf1-4933-b07b-33f4da24816c"), "Charlie", "charlie@supplier.com", "321-654-0987", "Supplier C" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "ID_Warehouse", "Capacity", "Location", "ManagerName", "WarehouseName" },
                values: new object[,]
                {
                    { new Guid("9ddcc8e3-681d-4fc8-9d1f-d1f25b4f7cfa"), 2500, "Location D", "Manager D", "Warehouse 4" },
                    { new Guid("bc0ace60-4af9-423f-ab19-e9deb97c38aa"), 1000, "Location A", "Manager A", "Warehouse 1" },
                    { new Guid("ccd019cf-68d6-42e2-87b3-6240b5137ffb"), 1500, "Location C", "Manager C", "Warehouse 3" },
                    { new Guid("cfc02977-4cb7-4979-80da-866a23282440"), 2000, "Location B", "Manager B", "Warehouse 2" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID_Order", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("122189ba-dcff-45fa-95e0-c6c730cea839"), new Guid("ed43fb00-1cf9-4302-a462-7a14d256f7df"), new DateTime(2024, 10, 28, 11, 0, 6, 244, DateTimeKind.Utc).AddTicks(5847), "Shipped", 70.00m },
                    { new Guid("1c318181-eba4-4257-b814-b23c7060c232"), new Guid("7df7e5c6-7827-47ef-989e-a872099081b1"), new DateTime(2024, 10, 28, 11, 0, 6, 244, DateTimeKind.Utc).AddTicks(5836), "Pending", 30.00m },
                    { new Guid("58f5608d-3576-4ce4-921c-cfc1eac38346"), new Guid("9ce6f493-f800-4080-bfb2-174a33fa1db9"), new DateTime(2024, 10, 28, 11, 0, 6, 244, DateTimeKind.Utc).AddTicks(5826), "Completed", 25.00m },
                    { new Guid("84baad39-9601-4def-ab33-0375b546a364"), new Guid("74368c6f-2875-4f41-88c9-a5c1cc7411bd"), new DateTime(2024, 10, 28, 11, 0, 6, 244, DateTimeKind.Utc).AddTicks(5841), "Completed", 50.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID_Product", "Producer", "ProductName", "QuantityInStock", "SupplierID", "UnitPrice", "WarehouseID" },
                values: new object[,]
                {
                    { new Guid("27274e5a-ec71-46ce-a3c2-6ae38ccf7f04"), "Producer 2", "Product 2", 200, new Guid("423e412e-5bc4-40e8-a293-b6ff00da0858"), 15.00m, new Guid("bc0ace60-4af9-423f-ab19-e9deb97c38aa") },
                    { new Guid("2be1bc92-f148-4982-868d-8730fcb36e94"), "Producer 1", "Product 1", 100, new Guid("423e412e-5bc4-40e8-a293-b6ff00da0858"), 10.00m, new Guid("bc0ace60-4af9-423f-ab19-e9deb97c38aa") },
                    { new Guid("3d86c84d-3eeb-4716-92a7-ab46c2285b24"), "Producer 2", "Product 3", 150, new Guid("9249059d-a860-4abd-a5af-b7e903b69381"), 20.00m, new Guid("cfc02977-4cb7-4979-80da-866a23282440") },
                    { new Guid("7ae5747f-d93a-48d3-aa66-286c8ac96866"), "Producer 3", "Product 5", 60, new Guid("a3fe4dc4-dbf1-4933-b07b-33f4da24816c"), 30.00m, new Guid("ccd019cf-68d6-42e2-87b3-6240b5137ffb") },
                    { new Guid("7bda535b-8987-441a-a27c-a3f17130057e"), "Producer 3", "Product 6", 40, new Guid("56f552cd-e7d3-431a-b141-38cafe618b60"), 35.00m, new Guid("9ddcc8e3-681d-4fc8-9d1f-d1f25b4f7cfa") },
                    { new Guid("ab71556f-0eef-4112-8c4a-ec1c38fc0ab7"), "Producer 2", "Product 4", 80, new Guid("a3fe4dc4-dbf1-4933-b07b-33f4da24816c"), 25.00m, new Guid("ccd019cf-68d6-42e2-87b3-6240b5137ffb") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "ID_OrderDetails", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("5debb45f-46cf-4bab-addf-33dfd54c4cef"), new Guid("1c318181-eba4-4257-b814-b23c7060c232"), new Guid("3d86c84d-3eeb-4716-92a7-ab46c2285b24"), 1, 20.00m },
                    { new Guid("85869e2e-0f8b-429b-b3c6-b9ba348205dd"), new Guid("58f5608d-3576-4ce4-921c-cfc1eac38346"), new Guid("2be1bc92-f148-4982-868d-8730fcb36e94"), 2, 10.00m },
                    { new Guid("9605de62-ca9d-47c3-b4f4-bf7c9fc1935c"), new Guid("58f5608d-3576-4ce4-921c-cfc1eac38346"), new Guid("27274e5a-ec71-46ce-a3c2-6ae38ccf7f04"), 1, 15.00m },
                    { new Guid("ae56d31c-4061-443a-909a-72832316c9d6"), new Guid("84baad39-9601-4def-ab33-0375b546a364"), new Guid("ab71556f-0eef-4112-8c4a-ec1c38fc0ab7"), 2, 25.00m },
                    { new Guid("e0e6da09-90d1-4c25-b249-a7f99819ba31"), new Guid("84baad39-9601-4def-ab33-0375b546a364"), new Guid("7ae5747f-d93a-48d3-aa66-286c8ac96866"), 1, 30.00m },
                    { new Guid("e319e9d5-8b55-4652-8d49-017d14b9a2f6"), new Guid("122189ba-dcff-45fa-95e0-c6c730cea839"), new Guid("7bda535b-8987-441a-a27c-a3f17130057e"), 2, 35.00m }
                });
        }
    }
}
