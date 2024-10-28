using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddRestrictProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Warehouses_WarehouseID",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("1c5e8e90-615b-4d41-a105-2c2c3922e5d4"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("28d37e7f-9edc-489a-9bc3-4e6f9069094c"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("4277b559-dc5a-4c3e-a449-b65296abbb8a"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("4d390f2e-0719-407d-8201-ea5978bff533"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("7085974c-79fb-4df8-8d09-b26492a6834c"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("f3c27b7b-f418-4f40-ae71-637772e1315e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("1a6b752a-0d0f-4126-ba0c-b0d70ca168f6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("6771d369-c174-4c20-bca1-a7780e99a51e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("8c7d5b08-505d-4d00-9557-866648608c4e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("cdb78f2c-1e54-4329-b93f-feb2152c8481"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("1d88ff7e-0a37-44a0-8bfe-d382ed746b69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("2c439fa7-a63c-4e97-be31-6593091279f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("30101d30-76e5-4c42-b47f-9e079bf24b8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("41269096-8133-4bb7-9b3a-6531e471cf5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("bc2fcb70-37f5-4e1f-8249-3ff027d883a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("e885c463-146b-4421-86c7-3f9090c004fe"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("44c3edca-e622-4a7b-8089-01dc3f51fac4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("5f070460-535c-4d34-9dcc-64ef70dcaa10"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("62b36541-e014-4dc8-a5c8-0c8d67fe4e2d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("ef456aed-853b-484a-9b8e-7a354343a9f6"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("17047b9b-939d-420a-b069-52a95f923682"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("5856651c-1d91-434e-85f8-ded3da132755"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("8de4871d-ff52-42f2-a664-308c7c1672dd"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("b35f2979-36c6-4e3e-8a33-65f3659b75ba"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("00bd2a5b-6f2d-4067-82c2-22873e9d4c03"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("569427e8-3cf6-4330-8420-611d878120a6"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("c976f926-8da4-4ebb-8869-d102216b9438"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("ebf8cdb6-f892-42ee-a69c-6ed05bb2dd74"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID_Supplier",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Warehouses_WarehouseID",
                table: "Products",
                column: "WarehouseID",
                principalTable: "Warehouses",
                principalColumn: "ID_Warehouse",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Warehouses_WarehouseID",
                table: "Products");

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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID_Customer", "Address", "CustomerName", "Email", "Phone" },
                values: new object[,]
                {
                    { new Guid("44c3edca-e622-4a7b-8089-01dc3f51fac4"), "321 Oak St, Anothertown, USA", "Bob Brown", "bob.brown@example.com", "555-666-7777" },
                    { new Guid("5f070460-535c-4d34-9dcc-64ef70dcaa10"), "123 Main St, Anytown, USA", "John Doe", "john.doe@example.com", "111-222-3333" },
                    { new Guid("62b36541-e014-4dc8-a5c8-0c8d67fe4e2d"), "789 Pine St, Sometown, USA", "Alice Johnson", "alice.johnson@example.com", "222-333-4444" },
                    { new Guid("ef456aed-853b-484a-9b8e-7a354343a9f6"), "456 Elm St, Othertown, USA", "Jane Smith", "jane.smith@example.com", "444-555-6666" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID_Supplier", "ContactName", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { new Guid("17047b9b-939d-420a-b069-52a95f923682"), "Diana", "diana@supplier.com", "987-654-3210", "Supplier D" },
                    { new Guid("5856651c-1d91-434e-85f8-ded3da132755"), "Charlie", "charlie@supplier.com", "321-654-0987", "Supplier C" },
                    { new Guid("8de4871d-ff52-42f2-a664-308c7c1672dd"), "Alice", "alice@supplier.com", "123-456-7890", "Supplier A" },
                    { new Guid("b35f2979-36c6-4e3e-8a33-65f3659b75ba"), "Bob", "bob@supplier.com", "098-765-4321", "Supplier B" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "ID_Warehouse", "Capacity", "Location", "ManagerName", "WarehouseName" },
                values: new object[,]
                {
                    { new Guid("00bd2a5b-6f2d-4067-82c2-22873e9d4c03"), 2000, "Location B", "Manager B", "Warehouse 2" },
                    { new Guid("569427e8-3cf6-4330-8420-611d878120a6"), 1500, "Location C", "Manager C", "Warehouse 3" },
                    { new Guid("c976f926-8da4-4ebb-8869-d102216b9438"), 2500, "Location D", "Manager D", "Warehouse 4" },
                    { new Guid("ebf8cdb6-f892-42ee-a69c-6ed05bb2dd74"), 1000, "Location A", "Manager A", "Warehouse 1" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID_Order", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("1a6b752a-0d0f-4126-ba0c-b0d70ca168f6"), new Guid("62b36541-e014-4dc8-a5c8-0c8d67fe4e2d"), new DateTime(2024, 10, 28, 10, 32, 31, 182, DateTimeKind.Utc).AddTicks(8781), "Completed", 50.00m },
                    { new Guid("6771d369-c174-4c20-bca1-a7780e99a51e"), new Guid("44c3edca-e622-4a7b-8089-01dc3f51fac4"), new DateTime(2024, 10, 28, 10, 32, 31, 182, DateTimeKind.Utc).AddTicks(8785), "Shipped", 70.00m },
                    { new Guid("8c7d5b08-505d-4d00-9557-866648608c4e"), new Guid("5f070460-535c-4d34-9dcc-64ef70dcaa10"), new DateTime(2024, 10, 28, 10, 32, 31, 182, DateTimeKind.Utc).AddTicks(8772), "Completed", 25.00m },
                    { new Guid("cdb78f2c-1e54-4329-b93f-feb2152c8481"), new Guid("ef456aed-853b-484a-9b8e-7a354343a9f6"), new DateTime(2024, 10, 28, 10, 32, 31, 182, DateTimeKind.Utc).AddTicks(8777), "Pending", 30.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID_Product", "Producer", "ProductName", "QuantityInStock", "SupplierID", "UnitPrice", "WarehouseID" },
                values: new object[,]
                {
                    { new Guid("1d88ff7e-0a37-44a0-8bfe-d382ed746b69"), "Producer 3", "Product 6", 40, new Guid("17047b9b-939d-420a-b069-52a95f923682"), 35.00m, new Guid("c976f926-8da4-4ebb-8869-d102216b9438") },
                    { new Guid("2c439fa7-a63c-4e97-be31-6593091279f5"), "Producer 2", "Product 2", 200, new Guid("8de4871d-ff52-42f2-a664-308c7c1672dd"), 15.00m, new Guid("ebf8cdb6-f892-42ee-a69c-6ed05bb2dd74") },
                    { new Guid("30101d30-76e5-4c42-b47f-9e079bf24b8e"), "Producer 1", "Product 1", 100, new Guid("8de4871d-ff52-42f2-a664-308c7c1672dd"), 10.00m, new Guid("ebf8cdb6-f892-42ee-a69c-6ed05bb2dd74") },
                    { new Guid("41269096-8133-4bb7-9b3a-6531e471cf5a"), "Producer 3", "Product 5", 60, new Guid("5856651c-1d91-434e-85f8-ded3da132755"), 30.00m, new Guid("569427e8-3cf6-4330-8420-611d878120a6") },
                    { new Guid("bc2fcb70-37f5-4e1f-8249-3ff027d883a1"), "Producer 2", "Product 3", 150, new Guid("b35f2979-36c6-4e3e-8a33-65f3659b75ba"), 20.00m, new Guid("00bd2a5b-6f2d-4067-82c2-22873e9d4c03") },
                    { new Guid("e885c463-146b-4421-86c7-3f9090c004fe"), "Producer 2", "Product 4", 80, new Guid("5856651c-1d91-434e-85f8-ded3da132755"), 25.00m, new Guid("569427e8-3cf6-4330-8420-611d878120a6") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "ID_OrderDetails", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("1c5e8e90-615b-4d41-a105-2c2c3922e5d4"), new Guid("1a6b752a-0d0f-4126-ba0c-b0d70ca168f6"), new Guid("e885c463-146b-4421-86c7-3f9090c004fe"), 2, 25.00m },
                    { new Guid("28d37e7f-9edc-489a-9bc3-4e6f9069094c"), new Guid("6771d369-c174-4c20-bca1-a7780e99a51e"), new Guid("1d88ff7e-0a37-44a0-8bfe-d382ed746b69"), 2, 35.00m },
                    { new Guid("4277b559-dc5a-4c3e-a449-b65296abbb8a"), new Guid("8c7d5b08-505d-4d00-9557-866648608c4e"), new Guid("2c439fa7-a63c-4e97-be31-6593091279f5"), 1, 15.00m },
                    { new Guid("4d390f2e-0719-407d-8201-ea5978bff533"), new Guid("cdb78f2c-1e54-4329-b93f-feb2152c8481"), new Guid("bc2fcb70-37f5-4e1f-8249-3ff027d883a1"), 1, 20.00m },
                    { new Guid("7085974c-79fb-4df8-8d09-b26492a6834c"), new Guid("1a6b752a-0d0f-4126-ba0c-b0d70ca168f6"), new Guid("41269096-8133-4bb7-9b3a-6531e471cf5a"), 1, 30.00m },
                    { new Guid("f3c27b7b-f418-4f40-ae71-637772e1315e"), new Guid("8c7d5b08-505d-4d00-9557-866648608c4e"), new Guid("30101d30-76e5-4c42-b47f-9e079bf24b8e"), 2, 10.00m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID_Supplier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Warehouses_WarehouseID",
                table: "Products",
                column: "WarehouseID",
                principalTable: "Warehouses",
                principalColumn: "ID_Warehouse",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
