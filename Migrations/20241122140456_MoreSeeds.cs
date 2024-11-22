using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeeds : Migration
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
                    Producer = table.Column<string>(type: "character varying(800)", maxLength: 800, nullable: true),
                    Cell = table.Column<string>(type: "character varying(800)", maxLength: 800, nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "ID_Warehouse",
                        onDelete: ReferentialAction.Restrict);
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
                    { new Guid("000560d5-8ca4-4139-bd4f-332113b252ea"), "802 Banana St, Newcity, USA", "Bob Marley", "bob.marley@example.com", "333-111-4444" },
                    { new Guid("1bff5891-57fa-428f-99e2-3536d3510c76"), "468 Berry St, Thiscity, USA", "Paula Teal", "paula.teal@example.com", "111-999-2222" },
                    { new Guid("3b3ef280-6b8a-40e0-b0f4-6f0242a28e56"), "456 Elm St, Othertown, USA", "Jane Smith", "jane.smith@example.com", "444-555-6666" },
                    { new Guid("4fe91387-85a8-49b8-b1d3-658d202ce9b0"), "357 Grape St, Thatcity, USA", "Oscar Magenta", "oscar.magenta@example.com", "000-888-1111" },
                    { new Guid("55fafe62-99d7-4f37-9978-be4d1ed93056"), "246 Cedar St, Oldtown, USA", "Diana Prince", "diana.prince@example.com", "777-888-9999" },
                    { new Guid("70b4da1e-7b0c-4fa9-81bb-212f2784d32c"), "791 Ash St, Anycity, USA", "Ian Gray", "ian.gray@example.com", "444-222-5555" },
                    { new Guid("77fa4da5-d422-4df1-9ba2-9fad50a15522"), "024 Plum St, Newcity, USA", "Laura Pink", "laura.pink@example.com", "777-555-8888" },
                    { new Guid("78be7ef6-b1bd-4983-a74d-e8d6df827c95"), "802 Cherry St, Somecity, USA", "Julia Red", "julia.red@example.com", "555-333-6666" },
                    { new Guid("7df36448-61d5-4691-b5df-7d85497b5c2b"), "246 Lime St, Yourcity, USA", "Nina Cyan", "nina.cyan@example.com", "999-777-0000" },
                    { new Guid("7f76aca1-32ea-4c94-b039-fd4e1af0cfcc"), "357 Birch St, Yourtown, USA", "Ethan Hunt", "ethan.hunt@example.com", "333-444-5555" },
                    { new Guid("7fe5c280-66aa-441f-9d60-8c63a9c38889"), "135 Maple St, Newtown, USA", "Charlie Davis", "charlie.davis@example.com", "888-999-0000" },
                    { new Guid("9088e531-a9e2-4d12-885e-1fab1a3ef4a9"), "357 Papaya St, Anycity, USA", "Yvonne Nickel", "yvonne.nickel@example.com", "000-888-1111" },
                    { new Guid("91527ea6-09c5-4459-9084-444843fd99f3"), "789 Pine St, Sometown, USA", "Alice Johnson", "alice.johnson@example.com", "222-333-4444" },
                    { new Guid("92d95be7-a2c2-4bd5-aca5-6f1cc13d2829"), "135 Pineapple St, Thatcity, USA", "Wendy Iron", "wendy.iron@example.com", "888-666-9999" },
                    { new Guid("9968614d-c178-4d2d-948f-00d3372b7557"), "123 Main St, Anytown, USA", "John Doe", "john.doe@example.com", "111-222-3333" },
                    { new Guid("a22af5cd-77d4-4e16-8c69-25109af63219"), "791 Olive St, Othercity, USA", "Steve Gold", "steve.gold@example.com", "444-222-5555" },
                    { new Guid("a4be202c-5dcf-47a3-9b10-a01a17895efc"), "579 Fig St, Anycity, USA", "Quinn Brown", "quinn.brown@example.com", "222-000-3333" },
                    { new Guid("a67b611d-5283-457b-862b-a1c202e07885"), "913 Chestnut St, Oldcity, USA", "Ursula Bronze", "ursula.bronze@example.com", "666-444-7777" },
                    { new Guid("c3279e8a-949a-41ba-80b7-915d431edcb6"), "680 Willow St, Thatown, USA", "Hannah Blue", "hannah.blue@example.com", "222-111-3333" },
                    { new Guid("c44cdd70-aab1-4609-bf89-d3adb04f04e5"), "913 Peach St, Othercity, USA", "Kevin Black", "kevin.black@example.com", "666-444-7777" },
                    { new Guid("c59ae328-7ab8-4eaf-9093-be0581921dff"), "680 Date St, Somecity, USA", "Rachel Silver", "rachel.silver@example.com", "333-111-4444" },
                    { new Guid("c73a201d-d6fa-4647-a899-66a212ebec48"), "468 Spruce St, Hometown, USA", "Fiona Green", "fiona.green@example.com", "666-777-8888" },
                    { new Guid("ca6fbe44-afce-43ee-8fdf-a0e873fd6e75"), "246 Coconut St, Thiscity, USA", "Xander Zinc", "xander.zinc@example.com", "999-777-0000" },
                    { new Guid("ce0d2f02-0212-4938-853e-af303be593da"), "802 Walnut St, Newcity, USA", "Tina Copper", "tina.copper@example.com", "555-333-6666" },
                    { new Guid("ce280b61-edc2-4b48-ad0d-c4aece68967e"), "579 Fir St, Thistown, USA", "George White", "george.white@example.com", "999-000-1111" },
                    { new Guid("d6111caa-3080-40aa-a929-59f4543a2c6c"), "680 Kiwi St, Somecity, USA", "Zachary Lead", "zachary.lead@example.com", "111-999-2222" },
                    { new Guid("db64165e-c9c5-4902-95d4-2bdfae7e6a9e"), "321 Oak St, Anothertown, USA", "Bob Brown", "bob.brown@example.com", "555-666-7777" },
                    { new Guid("e40966e7-be50-4271-9ca7-bc0c462fd562"), "135 Lemon St, Oldcity, USA", "Mike Yellow", "mike.yellow@example.com", "888-666-9999" },
                    { new Guid("e49fb541-fcb1-4efc-a1eb-bd4781340fcf"), "791 Mango St, Othercity, USA", "Alice Cooper", "alice.cooper@example.com", "222-000-3333" },
                    { new Guid("f7c19f58-f85a-4d26-9433-bf1d720e00b7"), "024 Maple St, Yourcity, USA", "Victor Steel", "victor.steel@example.com", "777-555-8888" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID_Supplier", "ContactName", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { new Guid("04d1efb8-0849-4f39-9d22-c618d529756c"), "George Blue", "george.blue@gourmetfoods.com", "555-0109", "Gourmet Foods" },
                    { new Guid("124127e1-9781-4556-8e33-3283fc113f91"), "Oscar Magenta", "oscar.magenta@cleaningsupplies.com", "555-0117", "Cleaning Supplies" },
                    { new Guid("13af075e-a923-42fc-a866-6b0cfe6b79d6"), "Bob", "bob@supplier.com", "098-765-4321", "Supplier B" },
                    { new Guid("1cdbe5db-4292-4fb5-9601-1773ac101eea"), "Alice Johnson", "alice.johnson@techinnovations.com", "555-0103", "Tech Innovations" },
                    { new Guid("22c39cb1-24bb-43c2-b60e-aa655031e4f6"), "Charlie Davis", "charlie.davis@fastdelivery.com", "555-0105", "Fast Delivery" },
                    { new Guid("376d4527-7957-45c3-bc0e-fe2b2c11205a"), "Mike Yellow", "mike.yellow@constructionmaterials.com", "555-0115", "Construction Materials" },
                    { new Guid("6c074e28-87e7-4ad2-8562-8c4b3d4862c2"), "Ethan White", "ethan.white@homeessentials.com", "555-0107", "Home Essentials" },
                    { new Guid("7c0c3b60-8a06-4572-8b1a-ae5efb34f507"), "John Doe", "john.doe@acmecorp.com", "555-0101", "Acme Corp" },
                    { new Guid("85e16251-16ae-411a-9314-2f917a2b65e2"), "Nina Cyan", "nina.cyan@beveragedistributors.com", "555-0116", "Beverage Distributors" },
                    { new Guid("88cfa22b-02fa-468f-9aeb-7fa8f81e01dc"), "Kevin Purple", "kevin.purple@petsupplies.com", "555-0113", "Pet Supplies" },
                    { new Guid("8c18cad4-c33a-4f24-8f20-e76da325fa37"), "Julia Orange", "julia.orange@sportsgear.com", "555-0112", "Sports Gear" },
                    { new Guid("8ee2e9b2-b343-4a62-b141-5da65066b1f0"), "Rachel Silver", "rachel.silver@digitalsolutions.com", "555-0120", "Digital Solutions" },
                    { new Guid("906e55ef-0090-41e9-a703-4d8f2509d552"), "Paula Teal", "paula.teal@furnitureworld.com", "555-0118", "Furniture World" },
                    { new Guid("939a8fb8-8dba-4a34-abea-2a9b85aa1655"), "Laura Pink", "laura.pink@automotiveparts.com", "555-0114", "Automotive Parts" },
                    { new Guid("9c6a8113-ba44-4b94-bebf-31aacb96a183"), "Alice", "alice@supplier.com", "123-456-7890", "Supplier A" },
                    { new Guid("9ecd1896-b951-40f8-b13d-91a4b1bf09f3"), "Diana", "diana@supplier.com", "987-654-3210", "Supplier D" },
                    { new Guid("a0506634-cc3e-414e-860c-f9ae15d1daf8"), "Diana Green", "diana.green@ecoproducts.com", "555-0106", "Eco Products" },
                    { new Guid("a251085b-5a70-4764-94f5-981e42951d84"), "Quinn Brown", "quinn.brown@gardensupplies.com", "555-0119", "Garden Supplies" },
                    { new Guid("aae5c6fe-5eca-41d0-8984-205f938534e7"), "Ian Gray", "ian.gray@healthwellness.com", "555-0111", "Health & Wellness" },
                    { new Guid("d8920fb8-b027-46e1-be6d-66e3808c8f9b"), "Jane Smith", "jane.smith@globalsupplies.com", "555-0102", "Global Supplies" },
                    { new Guid("eb180958-e017-4e60-8e78-df8f361c9bf6"), "Charlie", "charlie@supplier.com", "321-654-0987", "Supplier C" },
                    { new Guid("ef76beb7-0876-49ef-9dd1-eb309bd07269"), "Fiona Black", "fiona.black@officesuppliesco.com", "555-0108", "Office Supplies Co." },
                    { new Guid("f1404bea-0c13-4c3c-8608-72a4cf1142ea"), "Bob Brown", "bob.brown@qualitygoods.com", "555-0104", "Quality Goods" },
                    { new Guid("f5240207-4281-4dbf-8d12-ce189e3fe3e6"), "Hannah Red", "hannah.red@fashionhub.com", "555-0110", "Fashion Hub" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "ID_Warehouse", "Capacity", "Location", "ManagerName", "WarehouseName" },
                values: new object[,]
                {
                    { new Guid("12158fdf-5485-4df7-9842-3b49d240bdec"), 6000, "Industrial Park", "Fiona Green", "Logistics Hub" },
                    { new Guid("25f075a3-d55d-4a93-ad67-1ec095dc4597"), 35000, "West District", "Diana Prince", "Westside Warehouse" },
                    { new Guid("3232ab97-72d0-4a78-9ba9-b9a69b1d7cde"), 2500, "Location D", "Manager D", "Warehouse 4" },
                    { new Guid("3312aa85-d4a2-46d0-b8fc-3a504a2108e4"), 8000, "Port Area", "Julia Red", "Bulk Storage" },
                    { new Guid("9109fa2b-a485-4f3c-b657-5271a8bea7de"), 4500, "South District", "Ethan Hunt", "Southside Warehouse" },
                    { new Guid("ac73118a-f69f-423a-aa64-f4b01dfdcafc"), 30000, "North District", "Bob Smith", "Northside Warehouse" },
                    { new Guid("b0537ac5-d718-4d97-9638-d43f7d203885"), 1500, "Location C", "Manager C", "Warehouse 3" },
                    { new Guid("c447c363-4528-437c-ae09-41d9304e6594"), 40000, "East District", "Charlie Brown", "Eastside Warehouse" },
                    { new Guid("c774729c-690c-4c53-8468-3c73e8ffb632"), 1000, "Location A", "Manager A", "Warehouse 1" },
                    { new Guid("cc50f20e-acbd-4667-bac5-71da8e43938e"), 7000, "Airport Road", "George White", "Distribution Center" },
                    { new Guid("d014bdd3-018a-4b71-a1c1-7fb2594643de"), 2500, "Suburban Area", "Hannah Blue", "Storage Facility" },
                    { new Guid("e4a36000-c5c6-4836-999b-57b3a5f5ce6c"), 50000, "Downtown", "Alice Johnson", "Central Warehouse" },
                    { new Guid("f0d04b50-203a-436f-abb2-0225b006ad16"), 2000, "Market Street", "Ian Gray", "Cold Storage" },
                    { new Guid("f8f8d9e9-90e4-49ad-9336-2b2dc0fc35e3"), 2000, "Location B", "Manager B", "Warehouse 2" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID_Order", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("0fe8b904-2a93-4382-8586-cf0b6f889cfd"), new Guid("91527ea6-09c5-4459-9084-444843fd99f3"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(209), "Completed", 80.00m },
                    { new Guid("1bf16c75-1a5d-4c23-a0df-87e723493599"), new Guid("70b4da1e-7b0c-4fa9-81bb-212f2784d32c"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(255), "Pending", 800.00m },
                    { new Guid("4247b966-c5e1-437d-9ca8-de358f8214b0"), new Guid("7f76aca1-32ea-4c94-b039-fd4e1af0cfcc"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(233), "Shipped", 6000.50m },
                    { new Guid("5395a48c-db13-45eb-996f-081a02914be8"), new Guid("ce280b61-edc2-4b48-ad0d-c4aece68967e"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(245), "Pending", 1100.20m },
                    { new Guid("6a4616a6-6776-4633-b811-26fc5372b568"), new Guid("c73a201d-d6fa-4647-a899-66a212ebec48"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(239), "Completed", 5001.30m },
                    { new Guid("78ab56cb-4c81-4cd8-9418-8a53e5219cfc"), new Guid("77fa4da5-d422-4df1-9ba2-9fad50a15522"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(272), "Pending", 6300.80m },
                    { new Guid("7fabd021-404b-458a-9e50-aa8e3add31f6"), new Guid("c44cdd70-aab1-4609-bf89-d3adb04f04e5"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(266), "Completed", 3201.00m },
                    { new Guid("86de8a5e-5aac-4055-87d0-c987a492b78d"), new Guid("55fafe62-99d7-4f37-9978-be4d1ed93056"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(227), "Pending", 300.50m },
                    { new Guid("97ec1e5f-8749-4222-9ea5-32b6149417b0"), new Guid("3b3ef280-6b8a-40e0-b0f4-6f0242a28e56"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(203), "Pending", 20.00m },
                    { new Guid("ad90ee49-6232-4d23-893a-c7156a77cf5d"), new Guid("db64165e-c9c5-4902-95d4-2bdfae7e6a9e"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(215), "Shipped", 70.00m },
                    { new Guid("b24b920d-d5a7-4775-b27d-3df293c626d3"), new Guid("9968614d-c178-4d2d-948f-00d3372b7557"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(196), "Completed", 35.00m },
                    { new Guid("c6e7ec3b-46ad-405e-a991-a02ca6a8e4ba"), new Guid("7fe5c280-66aa-441f-9d60-8c63a9c38889"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(222), "Completed", 300.50m },
                    { new Guid("d1e44f99-3d8e-4e38-b2b0-be5e71151431"), new Guid("78be7ef6-b1bd-4983-a74d-e8d6df827c95"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(261), "Shipped", 1400.20m },
                    { new Guid("d32a5232-c659-486c-bd9a-9284a768c923"), new Guid("c3279e8a-949a-41ba-80b7-915d431edcb6"), new DateTime(2024, 11, 22, 14, 4, 55, 699, DateTimeKind.Utc).AddTicks(250), "Completed", 3500.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID_Product", "Cell", "Producer", "ProductName", "QuantityInStock", "SupplierID", "UnitPrice", "WarehouseID" },
                values: new object[,]
                {
                    { new Guid("015cd4a6-7581-40ff-9d9f-bf2abe283b02"), "a128", "Healthy Snacks", "Nut Mix", 90, new Guid("13af075e-a923-42fc-a866-6b0cfe6b79d6"), 600.00m, new Guid("ac73118a-f69f-423a-aa64-f4b01dfdcafc") },
                    { new Guid("01e9c78b-d3ca-4133-a72c-55ba67085521"), "a14", "Farm Fresh", "Free-Range Eggs", 60, new Guid("939a8fb8-8dba-4a34-abea-2a9b85aa1655"), 2000.50m, new Guid("b0537ac5-d718-4d97-9638-d43f7d203885") },
                    { new Guid("0e1efc12-6035-4d18-8ead-a1b9203dd841"), "a12", "Nutty Delights", "Almond Milk", 100, new Guid("939a8fb8-8dba-4a34-abea-2a9b85aa1655"), 300.50m, new Guid("f8f8d9e9-90e4-49ad-9336-2b2dc0fc35e3") },
                    { new Guid("0f329756-e609-4306-96a9-89d9efcd7d5a"), "a131", "Nutty Delights", "Almonds", 80, new Guid("04d1efb8-0849-4f39-9d22-c618d529756c"), 8000.00m, new Guid("25f075a3-d55d-4a93-ad67-1ec095dc4597") },
                    { new Guid("11f2b8bb-f6ec-4a61-a1f5-ad0c7eb9ce85"), "a105", "Producer 3", "Product 6", 40, new Guid("9ecd1896-b951-40f8-b13d-91a4b1bf09f3"), 35.00m, new Guid("25f075a3-d55d-4a93-ad67-1ec095dc4597") },
                    { new Guid("12383e39-59ec-4c76-b5df-d74e455b379a"), "a113", "Legume Lovers", "Canned Chickpeas", 300, new Guid("a0506634-cc3e-414e-860c-f9ae15d1daf8"), 1000.20m, new Guid("3232ab97-72d0-4a78-9ba9-b9a69b1d7cde") },
                    { new Guid("189d7451-0786-461c-8fba-7705e8e33ac6"), "a110", "Healthy Mornings", "Oatmeal", 200, new Guid("7c0c3b60-8a06-4572-8b1a-ae5efb34f507"), 3000.00m, new Guid("c447c363-4528-437c-ae09-41d9304e6594") },
                    { new Guid("28367500-eb25-4f02-882f-c90c64af5ec6"), "a101", "Producer 2", "Product 2", 200, new Guid("9c6a8113-ba44-4b94-bebf-31aacb96a183"), 15.00m, new Guid("e4a36000-c5c6-4836-999b-57b3a5f5ce6c") },
                    { new Guid("3d463c1e-f535-417d-b478-a720d306ed01"), "a104", "Producer 3", "Product 5", 60, new Guid("eb180958-e017-4e60-8e78-df8f361c9bf6"), 30.00m, new Guid("c447c363-4528-437c-ae09-41d9304e6594") },
                    { new Guid("3f4810d0-2338-460d-9f80-f3c39699af53"), "a107", "Tropical Goods", "Coconut Oil", 70, new Guid("376d4527-7957-45c3-bc0e-fe2b2c11205a"), 6000.00m, new Guid("f8f8d9e9-90e4-49ad-9336-2b2dc0fc35e3") },
                    { new Guid("446eb2d5-9ab6-401a-bb5a-380465afca6d"), "a106", "Healthy Grains", "Quinoa", 90, new Guid("376d4527-7957-45c3-bc0e-fe2b2c11205a"), 4000.50m, new Guid("3232ab97-72d0-4a78-9ba9-b9a69b1d7cde") },
                    { new Guid("4485e0fa-8f90-4348-8676-2769eb6ba5e8"), "a116", "Tropical Refreshments", "Coconut Water", 200, new Guid("6c074e28-87e7-4ad2-8562-8c4b3d4862c2"), 200.50m, new Guid("f0d04b50-203a-436f-abb2-0225b006ad16") },
                    { new Guid("564ab390-fb6f-490e-9af3-4941f8907f41"), "a134", "Fresh Greens", "Cabbage", 120, new Guid("8c18cad4-c33a-4f24-8f20-e76da325fa37"), 166.80m, new Guid("c447c363-4528-437c-ae09-41d9304e6594") },
                    { new Guid("5aad2270-ff2f-43e3-b655-2b819d1b3471"), "a111", "Superfoods Co.", "Chia Seeds", 150, new Guid("d8920fb8-b027-46e1-be6d-66e3808c8f9b"), 500.00m, new Guid("9109fa2b-a485-4f3c-b657-5271a8bea7de") },
                    { new Guid("5b433591-26b1-4ae9-8922-118a1156a635"), "a100", "Producer 1", "Product 1", 100, new Guid("9c6a8113-ba44-4b94-bebf-31aacb96a183"), 10.00m, new Guid("e4a36000-c5c6-4836-999b-57b3a5f5ce6c") },
                    { new Guid("6a7dba93-3d3e-4126-88f7-843d0d8944f1"), "a136", "Snack Time", "Pumpkin Seeds", 90, new Guid("939a8fb8-8dba-4a34-abea-2a9b85aa1655"), 4777.00m, new Guid("e4a36000-c5c6-4836-999b-57b3a5f5ce6c") },
                    { new Guid("729ec85d-fa0d-477b-8005-8899c4599a41"), "a15", "Grain Masters", "Brown Rice", 120, new Guid("376d4527-7957-45c3-bc0e-fe2b2c11205a"), 1000.80m, new Guid("3232ab97-72d0-4a78-9ba9-b9a69b1d7cde") },
                    { new Guid("74fe2d32-4c00-40c8-b9ce-9a7a06cd3c6e"), "a138", "Tropical Goods", "Coconut Milk", 110, new Guid("eb180958-e017-4e60-8e78-df8f361c9bf6"), 2777.50m, new Guid("c447c363-4528-437c-ae09-41d9304e6594") },
                    { new Guid("75b0e70c-1bf4-4f48-bb4c-ddc62f3a35f5"), "a135", "Healthy Harvest", "Lentils", 180, new Guid("88cfa22b-02fa-468f-9aeb-7fa8f81e01dc"), 177.20m, new Guid("25f075a3-d55d-4a93-ad67-1ec095dc4597") },
                    { new Guid("83572000-5201-4653-bc78-7a4b483a50f4"), "a112", "Nature's Best", "Avocado Oil", 80, new Guid("1cdbe5db-4292-4fb5-9601-1773ac101eea"), 800.00m, new Guid("b0537ac5-d718-4d97-9638-d43f7d203885") },
                    { new Guid("88ef40aa-9911-4916-9130-1c9f07175c9a"), "a103", "Producer 2", "Product 4", 80, new Guid("eb180958-e017-4e60-8e78-df8f361c9bf6"), 25.00m, new Guid("c447c363-4528-437c-ae09-41d9304e6594") },
                    { new Guid("8b300791-586f-4061-bef6-6d6b88e12240"), "a115", "Nutty Spread", "Peanut Butter", 90, new Guid("f1404bea-0c13-4c3c-8608-72a4cf1142ea"), 3000.50m, new Guid("3312aa85-d4a2-46d0-b8fc-3a504a2108e4") },
                    { new Guid("9030ecc4-5e68-4ff7-b3b6-da50bd741ea5"), "a139", "Asian Cuisine", "Rice Noodles", 130, new Guid("9ecd1896-b951-40f8-b13d-91a4b1bf09f3"), 3777.50m, new Guid("25f075a3-d55d-4a93-ad67-1ec095dc4597") },
                    { new Guid("9f1c1f9b-87f2-4f6e-a0af-b3228c7c4d15"), "a108", "Choco Bliss", "Dark Chocolate", 50, new Guid("85e16251-16ae-411a-9314-2f917a2b65e2"), 3000.00m, new Guid("d014bdd3-018a-4b71-a1c1-7fb2594643de") },
                    { new Guid("a3a73285-10bc-400f-bab8-8d740c128192"), "a132", "Spice World", "Cinnamon", 150, new Guid("f5240207-4281-4dbf-8d12-ce189e3fe3e6"), 300.00m, new Guid("e4a36000-c5c6-4836-999b-57b3a5f5ce6c") },
                    { new Guid("a6794630-264d-4da1-a35d-651c4ee0f00d"), "a102", "Producer 2", "Product 3", 150, new Guid("13af075e-a923-42fc-a866-6b0cfe6b79d6"), 20.00m, new Guid("ac73118a-f69f-423a-aa64-f4b01dfdcafc") },
                    { new Guid("a980e830-1ec8-4cb3-b07d-fce0badc7cbf"), "a127", "Garden Fresh", "Canned Tomatoes", 300, new Guid("9ecd1896-b951-40f8-b13d-91a4b1bf09f3"), 1000.00m, new Guid("25f075a3-d55d-4a93-ad67-1ec095dc4597") },
                    { new Guid("aaaac5d2-8576-48e9-b348-2aedca1650f5"), "a13", "Dairy Best", "Greek Yogurt", 80, new Guid("939a8fb8-8dba-4a34-abea-2a9b85aa1655"), 4000.00m, new Guid("b0537ac5-d718-4d97-9638-d43f7d203885") },
                    { new Guid("ac9e84c9-b819-4a75-a0f0-978874753705"), "a129", "Gourmet Essentials", "Balsamic Vinegar", 70, new Guid("9c6a8113-ba44-4b94-bebf-31aacb96a183"), 4000.50m, new Guid("e4a36000-c5c6-4836-999b-57b3a5f5ce6c") },
                    { new Guid("bbf39327-3ebe-4ca3-9789-d334c45c4654"), "a114", "Berry Good", "Frozen Berries", 120, new Guid("22c39cb1-24bb-43c2-b60e-aa655031e4f6"), 400.00m, new Guid("f8f8d9e9-90e4-49ad-9336-2b2dc0fc35e3") },
                    { new Guid("c2685135-2196-483b-b6f9-c397b56b4870"), "a118", "Dips & Spreads", "Hummus", 100, new Guid("04d1efb8-0849-4f39-9d22-c618d529756c"), 200.00m, new Guid("cc50f20e-acbd-4667-bac5-71da8e43938e") },
                    { new Guid("c5d44187-c0f1-414e-95d1-a0d4ef427dcc"), "a11", "Bakery Co.", "Whole Wheat Bread", 200, new Guid("88cfa22b-02fa-468f-9aeb-7fa8f81e01dc"), 200.00m, new Guid("c774729c-690c-4c53-8468-3c73e8ffb632") },
                    { new Guid("cb3845d9-64d2-4c9e-afc6-4a0aac33fdbd"), "a126", "Root Veggies", "Sweet Potatoes", 120, new Guid("eb180958-e017-4e60-8e78-df8f361c9bf6"), 100.80m, new Guid("c447c363-4528-437c-ae09-41d9304e6594") },
                    { new Guid("cd435b50-146c-4b35-8aaa-df60255589b8"), "a119", "Sweet Harvest", "Maple Syrup", 70, new Guid("ef76beb7-0876-49ef-9dd1-eb309bd07269"), 6000.00m, new Guid("12158fdf-5485-4df7-9842-3b49d240bdec") },
                    { new Guid("ce30b8bc-c5f1-4431-a3eb-bcb5a22afbe3"), "a133", "Legume Lovers", "Black Beans", 200, new Guid("aae5c6fe-5eca-41d0-8984-205f938534e7"), 100.50m, new Guid("ac73118a-f69f-423a-aa64-f4b01dfdcafc") },
                    { new Guid("d2b8687a-070a-4817-96e3-365bebb693c4"), "a117", "Snack Time", "Granola Bars", 150, new Guid("f5240207-4281-4dbf-8d12-ce189e3fe3e6"), 100.80m, new Guid("d014bdd3-018a-4b71-a1c1-7fb2594643de") },
                    { new Guid("d9a5f831-e4fe-42c6-bbfa-d21fca5741dd"), "a10", "Fresh Farms", "Organic Apples", 150, new Guid("88cfa22b-02fa-468f-9aeb-7fa8f81e01dc"), 100.50m, new Guid("c774729c-690c-4c53-8468-3c73e8ffb632") },
                    { new Guid("f5f33578-1f17-48ee-b04a-3d2e3b74edeb"), "a130", "Plant Protein Co.", "Tofu", 100, new Guid("ef76beb7-0876-49ef-9dd1-eb309bd07269"), 200.50m, new Guid("c447c363-4528-437c-ae09-41d9304e6594") },
                    { new Guid("f924bda0-f643-4b8f-88e8-5272e4f044de"), "a109", "Green Leaf", "Spinach", 110, new Guid("124127e1-9781-4556-8e33-3283fc113f91"), 2000.20m, new Guid("cc50f20e-acbd-4667-bac5-71da8e43938e") },
                    { new Guid("faec27f8-469a-4574-8b76-e78c1aed9da8"), "a137", "Garden Fresh", "Zucchini", 150, new Guid("13af075e-a923-42fc-a866-6b0cfe6b79d6"), 1777.00m, new Guid("ac73118a-f69f-423a-aa64-f4b01dfdcafc") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "ID_OrderDetails", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("022ce0ca-e5c1-4234-847d-c8a39e2c93d1"), new Guid("4247b966-c5e1-437d-9ca8-de358f8214b0"), new Guid("aaaac5d2-8576-48e9-b348-2aedca1650f5"), 1, 4000.00m },
                    { new Guid("1737176d-fe85-4074-b5ef-fbe64fedf6e8"), new Guid("b24b920d-d5a7-4775-b27d-3df293c626d3"), new Guid("28367500-eb25-4f02-882f-c90c64af5ec6"), 1, 15.00m },
                    { new Guid("1776dc33-5602-4ce2-ba94-e9cb5de5e9d5"), new Guid("6a4616a6-6776-4633-b811-26fc5372b568"), new Guid("446eb2d5-9ab6-401a-bb5a-380465afca6d"), 1, 4000.50m },
                    { new Guid("1b272d79-4c1e-4bce-ada6-5594ddb1c112"), new Guid("b24b920d-d5a7-4775-b27d-3df293c626d3"), new Guid("5b433591-26b1-4ae9-8922-118a1156a635"), 2, 10.00m },
                    { new Guid("1d1b9000-70a6-49fe-b8ad-91a0086bdd47"), new Guid("6a4616a6-6776-4633-b811-26fc5372b568"), new Guid("729ec85d-fa0d-477b-8005-8899c4599a41"), 1, 1000.80m },
                    { new Guid("200c167d-d9a6-40eb-b820-8509d65161d8"), new Guid("97ec1e5f-8749-4222-9ea5-32b6149417b0"), new Guid("a6794630-264d-4da1-a35d-651c4ee0f00d"), 1, 20.00m },
                    { new Guid("2b74da7a-beff-4542-9c80-2cc5d5993b53"), new Guid("4247b966-c5e1-437d-9ca8-de358f8214b0"), new Guid("01e9c78b-d3ca-4133-a72c-55ba67085521"), 1, 2000.50m },
                    { new Guid("33be799f-5c9b-4ea3-93a3-35fb52fdfbc9"), new Guid("d1e44f99-3d8e-4e38-b2b0-be5e71151431"), new Guid("12383e39-59ec-4c76-b5df-d74e455b379a"), 1, 1000.20m },
                    { new Guid("51444ade-1717-4f68-8e1b-5a227f01de7a"), new Guid("78ab56cb-4c81-4cd8-9418-8a53e5219cfc"), new Guid("cd435b50-146c-4b35-8aaa-df60255589b8"), 1, 6000.00m },
                    { new Guid("65676a57-4edb-4e5f-9290-12599dfd62fa"), new Guid("d1e44f99-3d8e-4e38-b2b0-be5e71151431"), new Guid("bbf39327-3ebe-4ca3-9789-d334c45c4654"), 1, 400.00m },
                    { new Guid("6609766b-0f15-4a38-889e-1ba03f405a11"), new Guid("c6e7ec3b-46ad-405e-a991-a02ca6a8e4ba"), new Guid("d9a5f831-e4fe-42c6-bbfa-d21fca5741dd"), 1, 100.50m },
                    { new Guid("666ed0c4-651f-4b19-a04a-75b2da4416ac"), new Guid("5395a48c-db13-45eb-996f-081a02914be8"), new Guid("9f1c1f9b-87f2-4f6e-a0af-b3228c7c4d15"), 1, 3000.00m },
                    { new Guid("6848c3bd-21ca-4be2-8d7c-2890399b127c"), new Guid("5395a48c-db13-45eb-996f-081a02914be8"), new Guid("f924bda0-f643-4b8f-88e8-5272e4f044de"), 1, 2000.20m },
                    { new Guid("837877f6-9d48-41c4-a35d-5d62faebe422"), new Guid("d32a5232-c659-486c-bd9a-9284a768c923"), new Guid("189d7451-0786-461c-8fba-7705e8e33ac6"), 1, 3000.00m },
                    { new Guid("89b02f07-0cc4-4db8-b7eb-fc43e7b6d15d"), new Guid("7fabd021-404b-458a-9e50-aa8e3add31f6"), new Guid("4485e0fa-8f90-4348-8676-2769eb6ba5e8"), 1, 200.50m },
                    { new Guid("9192827e-ac17-4779-91a6-3d5241c2ef1f"), new Guid("0fe8b904-2a93-4382-8586-cf0b6f889cfd"), new Guid("3d463c1e-f535-417d-b478-a720d306ed01"), 1, 30.00m },
                    { new Guid("97be6a03-5f45-4bb0-8940-fafbd7150263"), new Guid("ad90ee49-6232-4d23-893a-c7156a77cf5d"), new Guid("11f2b8bb-f6ec-4a61-a1f5-ad0c7eb9ce85"), 2, 35.00m },
                    { new Guid("a5e49eec-e167-4347-bbd5-ec6db894fd3d"), new Guid("5395a48c-db13-45eb-996f-081a02914be8"), new Guid("3f4810d0-2338-460d-9f80-f3c39699af53"), 1, 6000.00m },
                    { new Guid("a7e65e60-2fd2-4a81-8760-0a1362f007c8"), new Guid("1bf16c75-1a5d-4c23-a0df-87e723493599"), new Guid("83572000-5201-4653-bc78-7a4b483a50f4"), 1, 800.00m },
                    { new Guid("bd5212d7-f0f6-4d94-8d65-a1c76beb0407"), new Guid("78ab56cb-4c81-4cd8-9418-8a53e5219cfc"), new Guid("c2685135-2196-483b-b6f9-c397b56b4870"), 1, 200.00m },
                    { new Guid("c42ae8f3-f999-46e6-803a-10b5ffdc5636"), new Guid("c6e7ec3b-46ad-405e-a991-a02ca6a8e4ba"), new Guid("c5d44187-c0f1-414e-95d1-a0d4ef427dcc"), 1, 200.00m },
                    { new Guid("d027667a-dd9b-46e1-af4a-d7e18afc143e"), new Guid("7fabd021-404b-458a-9e50-aa8e3add31f6"), new Guid("8b300791-586f-4061-bef6-6d6b88e12240"), 1, 3000.50m },
                    { new Guid("e3e3ad0e-d043-4601-8d48-ef4196951a8b"), new Guid("86de8a5e-5aac-4055-87d0-c987a492b78d"), new Guid("0e1efc12-6035-4d18-8ead-a1b9203dd841"), 1, 300.50m },
                    { new Guid("e997f342-5d97-4526-b232-d8d26bc8c4f7"), new Guid("78ab56cb-4c81-4cd8-9418-8a53e5219cfc"), new Guid("d2b8687a-070a-4817-96e3-365bebb693c4"), 1, 100.80m },
                    { new Guid("f54dfe74-bad7-4151-9e2d-b329811dfed8"), new Guid("0fe8b904-2a93-4382-8586-cf0b6f889cfd"), new Guid("88ef40aa-9911-4916-9130-1c9f07175c9a"), 2, 25.00m },
                    { new Guid("fd205d81-28ab-4ffc-a607-b5960164c926"), new Guid("d32a5232-c659-486c-bd9a-9284a768c923"), new Guid("5aad2270-ff2f-43e3-b655-2b819d1b3471"), 1, 500.00m }
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
