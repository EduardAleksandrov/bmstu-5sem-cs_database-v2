using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedsv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
