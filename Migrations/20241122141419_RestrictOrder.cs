using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class RestrictOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("000560d5-8ca4-4139-bd4f-332113b252ea"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("1bff5891-57fa-428f-99e2-3536d3510c76"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("4fe91387-85a8-49b8-b1d3-658d202ce9b0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("7df36448-61d5-4691-b5df-7d85497b5c2b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("9088e531-a9e2-4d12-885e-1fab1a3ef4a9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("92d95be7-a2c2-4bd5-aca5-6f1cc13d2829"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("a22af5cd-77d4-4e16-8c69-25109af63219"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("a4be202c-5dcf-47a3-9b10-a01a17895efc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("a67b611d-5283-457b-862b-a1c202e07885"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("c59ae328-7ab8-4eaf-9093-be0581921dff"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("ca6fbe44-afce-43ee-8fdf-a0e873fd6e75"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("ce0d2f02-0212-4938-853e-af303be593da"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("d6111caa-3080-40aa-a929-59f4543a2c6c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("e40966e7-be50-4271-9ca7-bc0c462fd562"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("e49fb541-fcb1-4efc-a1eb-bd4781340fcf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("f7c19f58-f85a-4d26-9433-bf1d720e00b7"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("022ce0ca-e5c1-4234-847d-c8a39e2c93d1"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("1737176d-fe85-4074-b5ef-fbe64fedf6e8"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("1776dc33-5602-4ce2-ba94-e9cb5de5e9d5"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("1b272d79-4c1e-4bce-ada6-5594ddb1c112"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("1d1b9000-70a6-49fe-b8ad-91a0086bdd47"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("200c167d-d9a6-40eb-b820-8509d65161d8"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("2b74da7a-beff-4542-9c80-2cc5d5993b53"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("33be799f-5c9b-4ea3-93a3-35fb52fdfbc9"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("51444ade-1717-4f68-8e1b-5a227f01de7a"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("65676a57-4edb-4e5f-9290-12599dfd62fa"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("6609766b-0f15-4a38-889e-1ba03f405a11"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("666ed0c4-651f-4b19-a04a-75b2da4416ac"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("6848c3bd-21ca-4be2-8d7c-2890399b127c"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("837877f6-9d48-41c4-a35d-5d62faebe422"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("89b02f07-0cc4-4db8-b7eb-fc43e7b6d15d"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("9192827e-ac17-4779-91a6-3d5241c2ef1f"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("97be6a03-5f45-4bb0-8940-fafbd7150263"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("a5e49eec-e167-4347-bbd5-ec6db894fd3d"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("a7e65e60-2fd2-4a81-8760-0a1362f007c8"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("bd5212d7-f0f6-4d94-8d65-a1c76beb0407"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("c42ae8f3-f999-46e6-803a-10b5ffdc5636"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("d027667a-dd9b-46e1-af4a-d7e18afc143e"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("e3e3ad0e-d043-4601-8d48-ef4196951a8b"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("e997f342-5d97-4526-b232-d8d26bc8c4f7"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("f54dfe74-bad7-4151-9e2d-b329811dfed8"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("fd205d81-28ab-4ffc-a607-b5960164c926"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("015cd4a6-7581-40ff-9d9f-bf2abe283b02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("0f329756-e609-4306-96a9-89d9efcd7d5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("564ab390-fb6f-490e-9af3-4941f8907f41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("6a7dba93-3d3e-4126-88f7-843d0d8944f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("74fe2d32-4c00-40c8-b9ce-9a7a06cd3c6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("75b0e70c-1bf4-4f48-bb4c-ddc62f3a35f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("9030ecc4-5e68-4ff7-b3b6-da50bd741ea5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("a3a73285-10bc-400f-bab8-8d740c128192"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("a980e830-1ec8-4cb3-b07d-fce0badc7cbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("ac9e84c9-b819-4a75-a0f0-978874753705"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("cb3845d9-64d2-4c9e-afc6-4a0aac33fdbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("ce30b8bc-c5f1-4431-a3eb-bcb5a22afbe3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("f5f33578-1f17-48ee-b04a-3d2e3b74edeb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("faec27f8-469a-4574-8b76-e78c1aed9da8"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("8ee2e9b2-b343-4a62-b141-5da65066b1f0"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("906e55ef-0090-41e9-a703-4d8f2509d552"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("a251085b-5a70-4764-94f5-981e42951d84"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("0fe8b904-2a93-4382-8586-cf0b6f889cfd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("1bf16c75-1a5d-4c23-a0df-87e723493599"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("4247b966-c5e1-437d-9ca8-de358f8214b0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("5395a48c-db13-45eb-996f-081a02914be8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("6a4616a6-6776-4633-b811-26fc5372b568"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("78ab56cb-4c81-4cd8-9418-8a53e5219cfc"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("7fabd021-404b-458a-9e50-aa8e3add31f6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("86de8a5e-5aac-4055-87d0-c987a492b78d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("97ec1e5f-8749-4222-9ea5-32b6149417b0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("ad90ee49-6232-4d23-893a-c7156a77cf5d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("b24b920d-d5a7-4775-b27d-3df293c626d3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("c6e7ec3b-46ad-405e-a991-a02ca6a8e4ba"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("d1e44f99-3d8e-4e38-b2b0-be5e71151431"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("d32a5232-c659-486c-bd9a-9284a768c923"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("01e9c78b-d3ca-4133-a72c-55ba67085521"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("0e1efc12-6035-4d18-8ead-a1b9203dd841"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("11f2b8bb-f6ec-4a61-a1f5-ad0c7eb9ce85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("12383e39-59ec-4c76-b5df-d74e455b379a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("189d7451-0786-461c-8fba-7705e8e33ac6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("28367500-eb25-4f02-882f-c90c64af5ec6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3d463c1e-f535-417d-b478-a720d306ed01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3f4810d0-2338-460d-9f80-f3c39699af53"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("446eb2d5-9ab6-401a-bb5a-380465afca6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("4485e0fa-8f90-4348-8676-2769eb6ba5e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("5aad2270-ff2f-43e3-b655-2b819d1b3471"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("5b433591-26b1-4ae9-8922-118a1156a635"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("729ec85d-fa0d-477b-8005-8899c4599a41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("83572000-5201-4653-bc78-7a4b483a50f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("88ef40aa-9911-4916-9130-1c9f07175c9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("8b300791-586f-4061-bef6-6d6b88e12240"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("9f1c1f9b-87f2-4f6e-a0af-b3228c7c4d15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("a6794630-264d-4da1-a35d-651c4ee0f00d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("aaaac5d2-8576-48e9-b348-2aedca1650f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("bbf39327-3ebe-4ca3-9789-d334c45c4654"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("c2685135-2196-483b-b6f9-c397b56b4870"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("c5d44187-c0f1-414e-95d1-a0d4ef427dcc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("cd435b50-146c-4b35-8aaa-df60255589b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("d2b8687a-070a-4817-96e3-365bebb693c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("d9a5f831-e4fe-42c6-bbfa-d21fca5741dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("f924bda0-f643-4b8f-88e8-5272e4f044de"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("8c18cad4-c33a-4f24-8f20-e76da325fa37"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("aae5c6fe-5eca-41d0-8984-205f938534e7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("3b3ef280-6b8a-40e0-b0f4-6f0242a28e56"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("55fafe62-99d7-4f37-9978-be4d1ed93056"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("70b4da1e-7b0c-4fa9-81bb-212f2784d32c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("77fa4da5-d422-4df1-9ba2-9fad50a15522"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("78be7ef6-b1bd-4983-a74d-e8d6df827c95"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("7f76aca1-32ea-4c94-b039-fd4e1af0cfcc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("7fe5c280-66aa-441f-9d60-8c63a9c38889"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("91527ea6-09c5-4459-9084-444843fd99f3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("9968614d-c178-4d2d-948f-00d3372b7557"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("c3279e8a-949a-41ba-80b7-915d431edcb6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("c44cdd70-aab1-4609-bf89-d3adb04f04e5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("c73a201d-d6fa-4647-a899-66a212ebec48"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("ce280b61-edc2-4b48-ad0d-c4aece68967e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("db64165e-c9c5-4902-95d4-2bdfae7e6a9e"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("04d1efb8-0849-4f39-9d22-c618d529756c"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("124127e1-9781-4556-8e33-3283fc113f91"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("13af075e-a923-42fc-a866-6b0cfe6b79d6"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("1cdbe5db-4292-4fb5-9601-1773ac101eea"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("22c39cb1-24bb-43c2-b60e-aa655031e4f6"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("376d4527-7957-45c3-bc0e-fe2b2c11205a"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("6c074e28-87e7-4ad2-8562-8c4b3d4862c2"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("7c0c3b60-8a06-4572-8b1a-ae5efb34f507"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("85e16251-16ae-411a-9314-2f917a2b65e2"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("88cfa22b-02fa-468f-9aeb-7fa8f81e01dc"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("939a8fb8-8dba-4a34-abea-2a9b85aa1655"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("9c6a8113-ba44-4b94-bebf-31aacb96a183"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("9ecd1896-b951-40f8-b13d-91a4b1bf09f3"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("a0506634-cc3e-414e-860c-f9ae15d1daf8"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("d8920fb8-b027-46e1-be6d-66e3808c8f9b"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("eb180958-e017-4e60-8e78-df8f361c9bf6"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("ef76beb7-0876-49ef-9dd1-eb309bd07269"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("f1404bea-0c13-4c3c-8608-72a4cf1142ea"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("f5240207-4281-4dbf-8d12-ce189e3fe3e6"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("12158fdf-5485-4df7-9842-3b49d240bdec"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("25f075a3-d55d-4a93-ad67-1ec095dc4597"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("3232ab97-72d0-4a78-9ba9-b9a69b1d7cde"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("3312aa85-d4a2-46d0-b8fc-3a504a2108e4"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("9109fa2b-a485-4f3c-b657-5271a8bea7de"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("ac73118a-f69f-423a-aa64-f4b01dfdcafc"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("b0537ac5-d718-4d97-9638-d43f7d203885"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("c447c363-4528-437c-ae09-41d9304e6594"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("c774729c-690c-4c53-8468-3c73e8ffb632"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("cc50f20e-acbd-4667-bac5-71da8e43938e"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("d014bdd3-018a-4b71-a1c1-7fb2594643de"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("e4a36000-c5c6-4836-999b-57b3a5f5ce6c"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("f0d04b50-203a-436f-abb2-0225b006ad16"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("f8f8d9e9-90e4-49ad-9336-2b2dc0fc35e3"));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID_Customer", "Address", "CustomerName", "Email", "Phone" },
                values: new object[,]
                {
                    { new Guid("01cf6e53-225e-4d97-8527-241d64096e77"), "123 Main St, Anytown, USA", "John Doe", "john.doe@example.com", "111-222-3333" },
                    { new Guid("0591e36c-5c8c-48a3-af20-77a5c58ceab8"), "789 Pine St, Sometown, USA", "Alice Johnson", "alice.johnson@example.com", "222-333-4444" },
                    { new Guid("05e52de3-e8d1-4def-8b3a-f73c1f8fbc16"), "135 Maple St, Newtown, USA", "Charlie Davis", "charlie.davis@example.com", "888-999-0000" },
                    { new Guid("07f4b0f9-0109-44e4-98e7-f9305afe2680"), "913 Peach St, Othercity, USA", "Kevin Black", "kevin.black@example.com", "666-444-7777" },
                    { new Guid("1411103b-91b0-4c1c-b787-66c17b54fd4f"), "913 Chestnut St, Oldcity, USA", "Ursula Bronze", "ursula.bronze@example.com", "666-444-7777" },
                    { new Guid("1420dd59-c914-4806-aff4-4d8e66cc5c33"), "680 Date St, Somecity, USA", "Rachel Silver", "rachel.silver@example.com", "333-111-4444" },
                    { new Guid("1a62b98a-9122-46cb-b4e2-d805876c19d2"), "246 Coconut St, Thiscity, USA", "Xander Zinc", "xander.zinc@example.com", "999-777-0000" },
                    { new Guid("2738e822-164a-42df-8be2-41a8ad0bb17d"), "468 Berry St, Thiscity, USA", "Paula Teal", "paula.teal@example.com", "111-999-2222" },
                    { new Guid("2fc6ca95-0c55-4964-b962-7724d5ea2040"), "024 Maple St, Yourcity, USA", "Victor Steel", "victor.steel@example.com", "777-555-8888" },
                    { new Guid("345bc33a-4577-4b0d-b78e-b1bc3112ddb7"), "802 Cherry St, Somecity, USA", "Julia Red", "julia.red@example.com", "555-333-6666" },
                    { new Guid("35af6d3c-5244-409e-b0d4-0f19b3a5d435"), "246 Cedar St, Oldtown, USA", "Diana Prince", "diana.prince@example.com", "777-888-9999" },
                    { new Guid("38d16c73-a500-4402-a854-96f2245d5df2"), "024 Plum St, Newcity, USA", "Laura Pink", "laura.pink@example.com", "777-555-8888" },
                    { new Guid("431a2ef2-59de-4540-bd52-5e1c90cc6183"), "246 Lime St, Yourcity, USA", "Nina Cyan", "nina.cyan@example.com", "999-777-0000" },
                    { new Guid("475e350c-7567-4515-abb3-fd9a0ebf1280"), "135 Pineapple St, Thatcity, USA", "Wendy Iron", "wendy.iron@example.com", "888-666-9999" },
                    { new Guid("491003a8-8603-402b-9636-66b81884ca02"), "357 Grape St, Thatcity, USA", "Oscar Magenta", "oscar.magenta@example.com", "000-888-1111" },
                    { new Guid("4f9826c7-7a7f-4786-a469-f0a82e63991a"), "802 Banana St, Newcity, USA", "Bob Marley", "bob.marley@example.com", "333-111-4444" },
                    { new Guid("54e8d890-f148-4d22-9eab-29c3d7e017ce"), "680 Willow St, Thatown, USA", "Hannah Blue", "hannah.blue@example.com", "222-111-3333" },
                    { new Guid("5f2462e9-827d-4331-8e9b-6adfdb0a5833"), "456 Elm St, Othertown, USA", "Jane Smith", "jane.smith@example.com", "444-555-6666" },
                    { new Guid("670c1794-dbcf-454b-a539-5d5921e19bcd"), "579 Fir St, Thistown, USA", "George White", "george.white@example.com", "999-000-1111" },
                    { new Guid("6f3ffbc6-1334-445e-ac9c-0da0fa449f10"), "357 Papaya St, Anycity, USA", "Yvonne Nickel", "yvonne.nickel@example.com", "000-888-1111" },
                    { new Guid("878251d8-97dc-4912-a0e0-85be7b4fbf22"), "791 Mango St, Othercity, USA", "Alice Cooper", "alice.cooper@example.com", "222-000-3333" },
                    { new Guid("8a81746a-65bc-42e3-9503-5c0cf2aa3bd3"), "802 Walnut St, Newcity, USA", "Tina Copper", "tina.copper@example.com", "555-333-6666" },
                    { new Guid("8ea30d57-0684-454f-85c7-8a5050aafd0e"), "357 Birch St, Yourtown, USA", "Ethan Hunt", "ethan.hunt@example.com", "333-444-5555" },
                    { new Guid("8fa5437e-c656-4dba-85f0-26c7115afe54"), "135 Lemon St, Oldcity, USA", "Mike Yellow", "mike.yellow@example.com", "888-666-9999" },
                    { new Guid("94ecb7cf-3070-4431-bb2b-1e9ae59b677a"), "321 Oak St, Anothertown, USA", "Bob Brown", "bob.brown@example.com", "555-666-7777" },
                    { new Guid("b6e81c51-fcf4-4d4b-a94d-0a3f24b0ff22"), "680 Kiwi St, Somecity, USA", "Zachary Lead", "zachary.lead@example.com", "111-999-2222" },
                    { new Guid("c8aaaafd-5ff1-488c-be22-3915564fb7c2"), "579 Fig St, Anycity, USA", "Quinn Brown", "quinn.brown@example.com", "222-000-3333" },
                    { new Guid("d0d88b30-1b63-42af-a902-de0c85468a85"), "791 Ash St, Anycity, USA", "Ian Gray", "ian.gray@example.com", "444-222-5555" },
                    { new Guid("d24e3782-8e0f-4dc3-b0f3-da6785d40843"), "468 Spruce St, Hometown, USA", "Fiona Green", "fiona.green@example.com", "666-777-8888" },
                    { new Guid("ff382f41-ca4b-4398-8e38-c521cef28455"), "791 Olive St, Othercity, USA", "Steve Gold", "steve.gold@example.com", "444-222-5555" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID_Supplier", "ContactName", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { new Guid("00ec677e-f5d9-45bc-8f2e-df7d906b8921"), "Kevin Purple", "kevin.purple@petsupplies.com", "555-0113", "Pet Supplies" },
                    { new Guid("0857631e-4fce-4a52-b717-75c195dc1881"), "Charlie Davis", "charlie.davis@fastdelivery.com", "555-0105", "Fast Delivery" },
                    { new Guid("0da33d2b-1118-4635-bb96-5382a56747d3"), "Quinn Brown", "quinn.brown@gardensupplies.com", "555-0119", "Garden Supplies" },
                    { new Guid("14fbefad-8f63-430f-82d0-c10d28f7862a"), "Jane Smith", "jane.smith@globalsupplies.com", "555-0102", "Global Supplies" },
                    { new Guid("15d152bd-1831-47ac-9a0a-f89d409ef70e"), "Paula Teal", "paula.teal@furnitureworld.com", "555-0118", "Furniture World" },
                    { new Guid("22f8cce8-dad5-4d31-a827-35b2790c7348"), "Ian Gray", "ian.gray@healthwellness.com", "555-0111", "Health & Wellness" },
                    { new Guid("315e9973-c145-4bfd-985e-6a04aad99aeb"), "Bob", "bob@supplier.com", "098-765-4321", "Supplier B" },
                    { new Guid("33b3d61a-77dc-4090-8f7c-858b8c8691cd"), "Diana", "diana@supplier.com", "987-654-3210", "Supplier D" },
                    { new Guid("33bd5409-2f0e-4d59-b21c-c4a9685b4ea0"), "Mike Yellow", "mike.yellow@constructionmaterials.com", "555-0115", "Construction Materials" },
                    { new Guid("39daa169-047e-4184-bd37-15f04b127175"), "John Doe", "john.doe@acmecorp.com", "555-0101", "Acme Corp" },
                    { new Guid("3d5eb318-3442-4200-9ed7-7cb267c816fd"), "Oscar Magenta", "oscar.magenta@cleaningsupplies.com", "555-0117", "Cleaning Supplies" },
                    { new Guid("5a2d932c-6505-451f-877f-6be7273bb271"), "Ethan White", "ethan.white@homeessentials.com", "555-0107", "Home Essentials" },
                    { new Guid("71466897-d17c-49d1-9d9f-d8eb8670fd9c"), "Fiona Black", "fiona.black@officesuppliesco.com", "555-0108", "Office Supplies Co." },
                    { new Guid("7bb086a8-c6d7-48c2-9e13-d8b3316a0421"), "Hannah Red", "hannah.red@fashionhub.com", "555-0110", "Fashion Hub" },
                    { new Guid("7ddd3d5b-3bf3-41ea-a1de-e3f304ddfeea"), "Bob Brown", "bob.brown@qualitygoods.com", "555-0104", "Quality Goods" },
                    { new Guid("825256d5-a3d1-4985-af2d-aa01389b9dd7"), "Julia Orange", "julia.orange@sportsgear.com", "555-0112", "Sports Gear" },
                    { new Guid("89148db9-f165-4cb6-90f9-eb1a7b4e58e6"), "Charlie", "charlie@supplier.com", "321-654-0987", "Supplier C" },
                    { new Guid("ac9757bd-f556-4ec5-b80a-2cc8896e5bdf"), "Rachel Silver", "rachel.silver@digitalsolutions.com", "555-0120", "Digital Solutions" },
                    { new Guid("b7a01094-3afb-4e13-818a-59a931c2f48b"), "Diana Green", "diana.green@ecoproducts.com", "555-0106", "Eco Products" },
                    { new Guid("ba329989-ac8c-4044-9a7d-b7566f0355c1"), "Laura Pink", "laura.pink@automotiveparts.com", "555-0114", "Automotive Parts" },
                    { new Guid("c82e5c62-ea18-4c29-93dc-28b309561404"), "Nina Cyan", "nina.cyan@beveragedistributors.com", "555-0116", "Beverage Distributors" },
                    { new Guid("d97d0cf9-9dd0-433a-9c98-08b75063a346"), "Alice Johnson", "alice.johnson@techinnovations.com", "555-0103", "Tech Innovations" },
                    { new Guid("f0566ed2-52ef-4ddc-9161-26bcb73b60bd"), "George Blue", "george.blue@gourmetfoods.com", "555-0109", "Gourmet Foods" },
                    { new Guid("fb0fc0b4-f311-4bcb-ad20-b838b1ad1920"), "Alice", "alice@supplier.com", "123-456-7890", "Supplier A" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "ID_Warehouse", "Capacity", "Location", "ManagerName", "WarehouseName" },
                values: new object[,]
                {
                    { new Guid("16274e2c-83ef-4ddd-b504-18a637e94a66"), 8000, "Port Area", "Julia Red", "Bulk Storage" },
                    { new Guid("3b4ed331-9392-4d7c-bf65-56a315c6efac"), 1500, "Location C", "Manager C", "Warehouse 3" },
                    { new Guid("42bf36ef-7634-4ba8-8be5-b8a171ddab12"), 2000, "Market Street", "Ian Gray", "Cold Storage" },
                    { new Guid("45a11d4e-5089-4ef9-83d2-5fea83a28e42"), 40000, "East District", "Charlie Brown", "Eastside Warehouse" },
                    { new Guid("4f5e5098-3074-4dde-94cf-90ef7a2b56c3"), 4500, "South District", "Ethan Hunt", "Southside Warehouse" },
                    { new Guid("67ab8e0f-fad1-4515-95a6-9114c3aeb382"), 6000, "Industrial Park", "Fiona Green", "Logistics Hub" },
                    { new Guid("6b901674-76cd-4aca-8e3c-1d19c2732341"), 7000, "Airport Road", "George White", "Distribution Center" },
                    { new Guid("79620bb0-fec4-4921-9b55-c3d1d9da57cc"), 35000, "West District", "Diana Prince", "Westside Warehouse" },
                    { new Guid("7c9914ff-256d-4beb-9ef8-c6eebaf1760e"), 50000, "Downtown", "Alice Johnson", "Central Warehouse" },
                    { new Guid("839b4827-3e7f-4c35-9d2e-6e6501ac4f8e"), 2500, "Suburban Area", "Hannah Blue", "Storage Facility" },
                    { new Guid("c3fb3a21-ca5d-47e0-b5f6-1f3556cd01b3"), 30000, "North District", "Bob Smith", "Northside Warehouse" },
                    { new Guid("dc7eeb83-ee94-44fe-93eb-da812056e029"), 1000, "Location A", "Manager A", "Warehouse 1" },
                    { new Guid("ea734f6f-b128-4202-9f81-337a0bf64783"), 2000, "Location B", "Manager B", "Warehouse 2" },
                    { new Guid("fca5864c-4e08-453e-979d-dc28807d2842"), 2500, "Location D", "Manager D", "Warehouse 4" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID_Order", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("037fd886-5a76-4239-8533-3b22a792932f"), new Guid("8ea30d57-0684-454f-85c7-8a5050aafd0e"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3305), "Shipped", 6000.50m },
                    { new Guid("04cb98fe-49ff-4c59-810e-5c1d6751fa2f"), new Guid("54e8d890-f148-4d22-9eab-29c3d7e017ce"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3321), "Completed", 3500.00m },
                    { new Guid("0dca7f0a-7e5b-4449-808d-a59a79dae0f5"), new Guid("38d16c73-a500-4402-a854-96f2245d5df2"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3337), "Pending", 6300.80m },
                    { new Guid("108c73fe-ef1b-4b49-808c-94d025da79e5"), new Guid("0591e36c-5c8c-48a3-af20-77a5c58ceab8"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3289), "Completed", 80.00m },
                    { new Guid("1457d5bc-0753-431b-b18c-133d41b2744b"), new Guid("d0d88b30-1b63-42af-a902-de0c85468a85"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3325), "Pending", 800.00m },
                    { new Guid("3a90befc-db71-4b9b-a153-577da2accbf6"), new Guid("05e52de3-e8d1-4def-8b3a-f73c1f8fbc16"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3297), "Completed", 300.50m },
                    { new Guid("5c7b2551-5591-4c4a-9f95-42c83924b3f1"), new Guid("01cf6e53-225e-4d97-8527-241d64096e77"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3270), "Completed", 35.00m },
                    { new Guid("5e8217be-12dc-4fd4-940d-7f9a064f9882"), new Guid("07f4b0f9-0109-44e4-98e7-f9305afe2680"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3333), "Completed", 3201.00m },
                    { new Guid("6aeefae0-0f8e-4793-99b5-fe61522429fd"), new Guid("d24e3782-8e0f-4dc3-b0f3-da6785d40843"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3309), "Completed", 5001.30m },
                    { new Guid("7c2aa6f4-0e26-4f20-b14e-b1e5fdcaddca"), new Guid("670c1794-dbcf-454b-a539-5d5921e19bcd"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3313), "Pending", 1100.20m },
                    { new Guid("89f1b8dc-8083-4a0d-b5cd-d592be9cea76"), new Guid("5f2462e9-827d-4331-8e9b-6adfdb0a5833"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3285), "Pending", 20.00m },
                    { new Guid("dde98dd8-ba50-4cf3-9608-7c9d907ab22e"), new Guid("35af6d3c-5244-409e-b0d4-0f19b3a5d435"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3301), "Pending", 300.50m },
                    { new Guid("f235b7ac-c009-4fdd-9d45-e8e58602aaca"), new Guid("345bc33a-4577-4b0d-b78e-b1bc3112ddb7"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3329), "Shipped", 1400.20m },
                    { new Guid("fb46131e-77d7-4e26-b059-aaabeae8d536"), new Guid("94ecb7cf-3070-4431-bb2b-1e9ae59b677a"), new DateTime(2024, 11, 22, 14, 14, 18, 861, DateTimeKind.Utc).AddTicks(3293), "Shipped", 70.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID_Product", "Cell", "Producer", "ProductName", "QuantityInStock", "SupplierID", "UnitPrice", "WarehouseID" },
                values: new object[,]
                {
                    { new Guid("047a9786-cc61-4100-b23b-37649f6adb75"), "a115", "Nutty Spread", "Peanut Butter", 90, new Guid("7ddd3d5b-3bf3-41ea-a1de-e3f304ddfeea"), 3000.50m, new Guid("16274e2c-83ef-4ddd-b504-18a637e94a66") },
                    { new Guid("0b85f7c4-10c4-48b7-8e33-b2bcc6c930e0"), "a136", "Snack Time", "Pumpkin Seeds", 90, new Guid("ba329989-ac8c-4044-9a7d-b7566f0355c1"), 4777.00m, new Guid("7c9914ff-256d-4beb-9ef8-c6eebaf1760e") },
                    { new Guid("1d40e538-8733-484e-ae46-598c6d83e211"), "a130", "Plant Protein Co.", "Tofu", 100, new Guid("71466897-d17c-49d1-9d9f-d8eb8670fd9c"), 200.50m, new Guid("45a11d4e-5089-4ef9-83d2-5fea83a28e42") },
                    { new Guid("1e2d7f43-aa9f-4d98-aae6-c7b0a86d611c"), "a131", "Nutty Delights", "Almonds", 80, new Guid("f0566ed2-52ef-4ddc-9161-26bcb73b60bd"), 8000.00m, new Guid("79620bb0-fec4-4921-9b55-c3d1d9da57cc") },
                    { new Guid("1f8bee0b-a286-4e8d-9bcf-7928b96cd4d6"), "a106", "Healthy Grains", "Quinoa", 90, new Guid("33bd5409-2f0e-4d59-b21c-c4a9685b4ea0"), 4000.50m, new Guid("fca5864c-4e08-453e-979d-dc28807d2842") },
                    { new Guid("20b7970e-3cd5-4bcd-9eb3-3e6d9083460a"), "a135", "Healthy Harvest", "Lentils", 180, new Guid("00ec677e-f5d9-45bc-8f2e-df7d906b8921"), 177.20m, new Guid("79620bb0-fec4-4921-9b55-c3d1d9da57cc") },
                    { new Guid("27aa32c9-8ab2-4487-9512-59f09eabe58b"), "a11", "Bakery Co.", "Whole Wheat Bread", 200, new Guid("00ec677e-f5d9-45bc-8f2e-df7d906b8921"), 200.00m, new Guid("dc7eeb83-ee94-44fe-93eb-da812056e029") },
                    { new Guid("2b1ef509-e614-40e4-a635-07f2c8d80026"), "a110", "Healthy Mornings", "Oatmeal", 200, new Guid("39daa169-047e-4184-bd37-15f04b127175"), 3000.00m, new Guid("45a11d4e-5089-4ef9-83d2-5fea83a28e42") },
                    { new Guid("2ca7a9db-c84a-4036-bde9-68d1bb1d38cf"), "a128", "Healthy Snacks", "Nut Mix", 90, new Guid("315e9973-c145-4bfd-985e-6a04aad99aeb"), 600.00m, new Guid("c3fb3a21-ca5d-47e0-b5f6-1f3556cd01b3") },
                    { new Guid("2dcecc62-ca85-40b5-a28f-95b0d8272087"), "a10", "Fresh Farms", "Organic Apples", 150, new Guid("00ec677e-f5d9-45bc-8f2e-df7d906b8921"), 100.50m, new Guid("dc7eeb83-ee94-44fe-93eb-da812056e029") },
                    { new Guid("2ebcd021-bb15-4a6e-907f-04f14e38d8ad"), "a104", "Producer 3", "Product 5", 60, new Guid("89148db9-f165-4cb6-90f9-eb1a7b4e58e6"), 30.00m, new Guid("45a11d4e-5089-4ef9-83d2-5fea83a28e42") },
                    { new Guid("308a3607-1463-497c-a673-88614fc90078"), "a119", "Sweet Harvest", "Maple Syrup", 70, new Guid("71466897-d17c-49d1-9d9f-d8eb8670fd9c"), 6000.00m, new Guid("67ab8e0f-fad1-4515-95a6-9114c3aeb382") },
                    { new Guid("3334d44a-6caa-48ea-8ca4-1222cd4b245e"), "a103", "Producer 2", "Product 4", 80, new Guid("89148db9-f165-4cb6-90f9-eb1a7b4e58e6"), 25.00m, new Guid("45a11d4e-5089-4ef9-83d2-5fea83a28e42") },
                    { new Guid("33a8587b-b03f-4daa-8dec-68d94f86d2c7"), "a118", "Dips & Spreads", "Hummus", 100, new Guid("f0566ed2-52ef-4ddc-9161-26bcb73b60bd"), 200.00m, new Guid("6b901674-76cd-4aca-8e3c-1d19c2732341") },
                    { new Guid("36298747-c223-42da-99c7-803effd46d99"), "a102", "Producer 2", "Product 3", 150, new Guid("315e9973-c145-4bfd-985e-6a04aad99aeb"), 20.00m, new Guid("c3fb3a21-ca5d-47e0-b5f6-1f3556cd01b3") },
                    { new Guid("3b3ddcb9-7488-4676-91dc-a23de8bba02c"), "a107", "Tropical Goods", "Coconut Oil", 70, new Guid("33bd5409-2f0e-4d59-b21c-c4a9685b4ea0"), 6000.00m, new Guid("ea734f6f-b128-4202-9f81-337a0bf64783") },
                    { new Guid("5292c381-750d-4213-a9aa-730f09a95305"), "a129", "Gourmet Essentials", "Balsamic Vinegar", 70, new Guid("fb0fc0b4-f311-4bcb-ad20-b838b1ad1920"), 4000.50m, new Guid("7c9914ff-256d-4beb-9ef8-c6eebaf1760e") },
                    { new Guid("6b2c275c-e851-48b1-9efc-94e93f165466"), "a12", "Nutty Delights", "Almond Milk", 100, new Guid("ba329989-ac8c-4044-9a7d-b7566f0355c1"), 300.50m, new Guid("ea734f6f-b128-4202-9f81-337a0bf64783") },
                    { new Guid("6e79c779-d656-4c20-9be5-fddf4821a170"), "a101", "Producer 2", "Product 2", 200, new Guid("fb0fc0b4-f311-4bcb-ad20-b838b1ad1920"), 15.00m, new Guid("7c9914ff-256d-4beb-9ef8-c6eebaf1760e") },
                    { new Guid("71430cea-5a57-4d87-a865-cfde3e2f6829"), "a126", "Root Veggies", "Sweet Potatoes", 120, new Guid("89148db9-f165-4cb6-90f9-eb1a7b4e58e6"), 100.80m, new Guid("45a11d4e-5089-4ef9-83d2-5fea83a28e42") },
                    { new Guid("755911b1-7e91-4c7c-8539-d6eb7a3cd395"), "a114", "Berry Good", "Frozen Berries", 120, new Guid("0857631e-4fce-4a52-b717-75c195dc1881"), 400.00m, new Guid("ea734f6f-b128-4202-9f81-337a0bf64783") },
                    { new Guid("7dc1ac21-5a81-4d58-9140-5acae67137a1"), "a112", "Nature's Best", "Avocado Oil", 80, new Guid("d97d0cf9-9dd0-433a-9c98-08b75063a346"), 800.00m, new Guid("3b4ed331-9392-4d7c-bf65-56a315c6efac") },
                    { new Guid("803f1b7a-6108-4c01-86ba-5b7ce183bd51"), "a132", "Spice World", "Cinnamon", 150, new Guid("7bb086a8-c6d7-48c2-9e13-d8b3316a0421"), 300.00m, new Guid("7c9914ff-256d-4beb-9ef8-c6eebaf1760e") },
                    { new Guid("862d502b-3e00-4d1a-998f-8b3c179ccf01"), "a109", "Green Leaf", "Spinach", 110, new Guid("3d5eb318-3442-4200-9ed7-7cb267c816fd"), 2000.20m, new Guid("6b901674-76cd-4aca-8e3c-1d19c2732341") },
                    { new Guid("9480b47d-dffc-4ab2-abcf-6a6dc7f8c0ba"), "a13", "Dairy Best", "Greek Yogurt", 80, new Guid("ba329989-ac8c-4044-9a7d-b7566f0355c1"), 4000.00m, new Guid("3b4ed331-9392-4d7c-bf65-56a315c6efac") },
                    { new Guid("98d5875b-a87a-441a-9349-6d0fa15569da"), "a137", "Garden Fresh", "Zucchini", 150, new Guid("315e9973-c145-4bfd-985e-6a04aad99aeb"), 1777.00m, new Guid("c3fb3a21-ca5d-47e0-b5f6-1f3556cd01b3") },
                    { new Guid("a2096caa-4059-4eba-ad4d-c41456b56e52"), "a111", "Superfoods Co.", "Chia Seeds", 150, new Guid("14fbefad-8f63-430f-82d0-c10d28f7862a"), 500.00m, new Guid("4f5e5098-3074-4dde-94cf-90ef7a2b56c3") },
                    { new Guid("b0feacec-c662-41c2-94f1-2ca100f08333"), "a113", "Legume Lovers", "Canned Chickpeas", 300, new Guid("b7a01094-3afb-4e13-818a-59a931c2f48b"), 1000.20m, new Guid("fca5864c-4e08-453e-979d-dc28807d2842") },
                    { new Guid("bd26ad66-0697-43df-9730-49858e2e0beb"), "a15", "Grain Masters", "Brown Rice", 120, new Guid("33bd5409-2f0e-4d59-b21c-c4a9685b4ea0"), 1000.80m, new Guid("fca5864c-4e08-453e-979d-dc28807d2842") },
                    { new Guid("c105ae86-9dbe-4331-9665-0afe4fb881e3"), "a134", "Fresh Greens", "Cabbage", 120, new Guid("825256d5-a3d1-4985-af2d-aa01389b9dd7"), 166.80m, new Guid("45a11d4e-5089-4ef9-83d2-5fea83a28e42") },
                    { new Guid("c151326f-3730-4cbc-9dd6-4b9b7766ccc9"), "a127", "Garden Fresh", "Canned Tomatoes", 300, new Guid("33b3d61a-77dc-4090-8f7c-858b8c8691cd"), 1000.00m, new Guid("79620bb0-fec4-4921-9b55-c3d1d9da57cc") },
                    { new Guid("ca137355-72a2-42de-b91a-539a14bc1198"), "a108", "Choco Bliss", "Dark Chocolate", 50, new Guid("c82e5c62-ea18-4c29-93dc-28b309561404"), 3000.00m, new Guid("839b4827-3e7f-4c35-9d2e-6e6501ac4f8e") },
                    { new Guid("ca83b676-760d-4416-a308-0dcd22323870"), "a100", "Producer 1", "Product 1", 100, new Guid("fb0fc0b4-f311-4bcb-ad20-b838b1ad1920"), 10.00m, new Guid("7c9914ff-256d-4beb-9ef8-c6eebaf1760e") },
                    { new Guid("cb69c898-b389-4a93-9130-f36b7d31b2ee"), "a139", "Asian Cuisine", "Rice Noodles", 130, new Guid("33b3d61a-77dc-4090-8f7c-858b8c8691cd"), 3777.50m, new Guid("79620bb0-fec4-4921-9b55-c3d1d9da57cc") },
                    { new Guid("e0423371-2973-411d-aa0b-9166c2613577"), "a117", "Snack Time", "Granola Bars", 150, new Guid("7bb086a8-c6d7-48c2-9e13-d8b3316a0421"), 100.80m, new Guid("839b4827-3e7f-4c35-9d2e-6e6501ac4f8e") },
                    { new Guid("e05974f2-7506-42b9-b18e-c4d6f849c5df"), "a138", "Tropical Goods", "Coconut Milk", 110, new Guid("89148db9-f165-4cb6-90f9-eb1a7b4e58e6"), 2777.50m, new Guid("45a11d4e-5089-4ef9-83d2-5fea83a28e42") },
                    { new Guid("e6d5cc8f-9799-49ca-8f62-e86d1064c021"), "a105", "Producer 3", "Product 6", 40, new Guid("33b3d61a-77dc-4090-8f7c-858b8c8691cd"), 35.00m, new Guid("79620bb0-fec4-4921-9b55-c3d1d9da57cc") },
                    { new Guid("f0bcffd8-2ccc-4969-bab9-69ee81d4a2d1"), "a133", "Legume Lovers", "Black Beans", 200, new Guid("22f8cce8-dad5-4d31-a827-35b2790c7348"), 100.50m, new Guid("c3fb3a21-ca5d-47e0-b5f6-1f3556cd01b3") },
                    { new Guid("fa5f7e33-1935-45a0-9684-24f9466da4e5"), "a116", "Tropical Refreshments", "Coconut Water", 200, new Guid("5a2d932c-6505-451f-877f-6be7273bb271"), 200.50m, new Guid("42bf36ef-7634-4ba8-8be5-b8a171ddab12") },
                    { new Guid("fd672b8b-07df-4ec6-a57b-b43d78ea1534"), "a14", "Farm Fresh", "Free-Range Eggs", 60, new Guid("ba329989-ac8c-4044-9a7d-b7566f0355c1"), 2000.50m, new Guid("3b4ed331-9392-4d7c-bf65-56a315c6efac") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "ID_OrderDetails", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("1d9400cc-32e9-48ac-961a-2e26e83039ec"), new Guid("0dca7f0a-7e5b-4449-808d-a59a79dae0f5"), new Guid("33a8587b-b03f-4daa-8dec-68d94f86d2c7"), 1, 200.00m },
                    { new Guid("1eecdebc-d76d-4f12-8d08-a5022cb2a89f"), new Guid("04cb98fe-49ff-4c59-810e-5c1d6751fa2f"), new Guid("a2096caa-4059-4eba-ad4d-c41456b56e52"), 1, 500.00m },
                    { new Guid("24b903b1-5dec-4707-9797-f3516c798913"), new Guid("108c73fe-ef1b-4b49-808c-94d025da79e5"), new Guid("3334d44a-6caa-48ea-8ca4-1222cd4b245e"), 2, 25.00m },
                    { new Guid("2a7e56a5-884c-4098-b798-a5c90d3c11c6"), new Guid("5e8217be-12dc-4fd4-940d-7f9a064f9882"), new Guid("047a9786-cc61-4100-b23b-37649f6adb75"), 1, 3000.50m },
                    { new Guid("37e0ee70-e3db-4e61-b411-2789a549dceb"), new Guid("7c2aa6f4-0e26-4f20-b14e-b1e5fdcaddca"), new Guid("ca137355-72a2-42de-b91a-539a14bc1198"), 1, 3000.00m },
                    { new Guid("3e5d419a-e163-4875-8bc2-a2d785a0c2df"), new Guid("f235b7ac-c009-4fdd-9d45-e8e58602aaca"), new Guid("755911b1-7e91-4c7c-8539-d6eb7a3cd395"), 1, 400.00m },
                    { new Guid("4692aa1f-84d2-4ee9-9bf0-b3ddf28b25b5"), new Guid("3a90befc-db71-4b9b-a153-577da2accbf6"), new Guid("27aa32c9-8ab2-4487-9512-59f09eabe58b"), 1, 200.00m },
                    { new Guid("47206b95-92a4-4017-8705-d7bc7e1a2973"), new Guid("04cb98fe-49ff-4c59-810e-5c1d6751fa2f"), new Guid("2b1ef509-e614-40e4-a635-07f2c8d80026"), 1, 3000.00m },
                    { new Guid("49740892-6e8d-45bf-8c5d-7cd4e9eb4de2"), new Guid("3a90befc-db71-4b9b-a153-577da2accbf6"), new Guid("2dcecc62-ca85-40b5-a28f-95b0d8272087"), 1, 100.50m },
                    { new Guid("4a7adb25-0feb-4ffc-9615-12fed08f1228"), new Guid("7c2aa6f4-0e26-4f20-b14e-b1e5fdcaddca"), new Guid("3b3ddcb9-7488-4676-91dc-a23de8bba02c"), 1, 6000.00m },
                    { new Guid("54631b53-9904-432b-a931-76ce72633618"), new Guid("6aeefae0-0f8e-4793-99b5-fe61522429fd"), new Guid("1f8bee0b-a286-4e8d-9bcf-7928b96cd4d6"), 1, 4000.50m },
                    { new Guid("60866448-b428-4a69-ae5f-74fd6f3f4494"), new Guid("f235b7ac-c009-4fdd-9d45-e8e58602aaca"), new Guid("b0feacec-c662-41c2-94f1-2ca100f08333"), 1, 1000.20m },
                    { new Guid("6b81ec45-4890-4332-8df0-1e3f55d5e5d4"), new Guid("0dca7f0a-7e5b-4449-808d-a59a79dae0f5"), new Guid("308a3607-1463-497c-a673-88614fc90078"), 1, 6000.00m },
                    { new Guid("70bf833e-99b7-4e02-a536-7aa7dccfe251"), new Guid("037fd886-5a76-4239-8533-3b22a792932f"), new Guid("fd672b8b-07df-4ec6-a57b-b43d78ea1534"), 1, 2000.50m },
                    { new Guid("752a9026-8083-4d8f-8e49-6fda2b99ddea"), new Guid("6aeefae0-0f8e-4793-99b5-fe61522429fd"), new Guid("bd26ad66-0697-43df-9730-49858e2e0beb"), 1, 1000.80m },
                    { new Guid("7a4e44bb-65a9-4908-b641-c13d61ea626b"), new Guid("0dca7f0a-7e5b-4449-808d-a59a79dae0f5"), new Guid("e0423371-2973-411d-aa0b-9166c2613577"), 1, 100.80m },
                    { new Guid("864fdd56-6a0e-454d-8dd9-3309164482db"), new Guid("5c7b2551-5591-4c4a-9f95-42c83924b3f1"), new Guid("ca83b676-760d-4416-a308-0dcd22323870"), 2, 10.00m },
                    { new Guid("8b79d2e4-891e-4d73-8f02-375b8b14c3db"), new Guid("5e8217be-12dc-4fd4-940d-7f9a064f9882"), new Guid("fa5f7e33-1935-45a0-9684-24f9466da4e5"), 1, 200.50m },
                    { new Guid("96d2879a-cd55-4600-b07a-098040df2c27"), new Guid("dde98dd8-ba50-4cf3-9608-7c9d907ab22e"), new Guid("6b2c275c-e851-48b1-9efc-94e93f165466"), 1, 300.50m },
                    { new Guid("a72788f8-52bc-4eab-b156-0ecf1ca2993e"), new Guid("5c7b2551-5591-4c4a-9f95-42c83924b3f1"), new Guid("6e79c779-d656-4c20-9be5-fddf4821a170"), 1, 15.00m },
                    { new Guid("aded7c5b-d160-4a0d-b46f-1cc7db7911b2"), new Guid("7c2aa6f4-0e26-4f20-b14e-b1e5fdcaddca"), new Guid("862d502b-3e00-4d1a-998f-8b3c179ccf01"), 1, 2000.20m },
                    { new Guid("d455eb8c-7bf9-4d1c-9e22-da32896e9e46"), new Guid("fb46131e-77d7-4e26-b059-aaabeae8d536"), new Guid("e6d5cc8f-9799-49ca-8f62-e86d1064c021"), 2, 35.00m },
                    { new Guid("de2e29b5-95e7-41cf-ac26-30535a27e0eb"), new Guid("1457d5bc-0753-431b-b18c-133d41b2744b"), new Guid("7dc1ac21-5a81-4d58-9140-5acae67137a1"), 1, 800.00m },
                    { new Guid("e82819d7-8838-411d-8aee-3f4f27a51f21"), new Guid("89f1b8dc-8083-4a0d-b5cd-d592be9cea76"), new Guid("36298747-c223-42da-99c7-803effd46d99"), 1, 20.00m },
                    { new Guid("f7fe09c2-9a5c-4ef2-9e04-d00a724d5c3d"), new Guid("108c73fe-ef1b-4b49-808c-94d025da79e5"), new Guid("2ebcd021-bb15-4a6e-907f-04f14e38d8ad"), 1, 30.00m },
                    { new Guid("f924aa36-5720-4668-ba5f-332ab13ff1bf"), new Guid("037fd886-5a76-4239-8533-3b22a792932f"), new Guid("9480b47d-dffc-4ab2-abcf-6a6dc7f8c0ba"), 1, 4000.00m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID_Customer",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("1411103b-91b0-4c1c-b787-66c17b54fd4f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("1420dd59-c914-4806-aff4-4d8e66cc5c33"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("1a62b98a-9122-46cb-b4e2-d805876c19d2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("2738e822-164a-42df-8be2-41a8ad0bb17d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("2fc6ca95-0c55-4964-b962-7724d5ea2040"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("431a2ef2-59de-4540-bd52-5e1c90cc6183"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("475e350c-7567-4515-abb3-fd9a0ebf1280"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("491003a8-8603-402b-9636-66b81884ca02"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("4f9826c7-7a7f-4786-a469-f0a82e63991a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("6f3ffbc6-1334-445e-ac9c-0da0fa449f10"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("878251d8-97dc-4912-a0e0-85be7b4fbf22"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("8a81746a-65bc-42e3-9503-5c0cf2aa3bd3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("8fa5437e-c656-4dba-85f0-26c7115afe54"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("b6e81c51-fcf4-4d4b-a94d-0a3f24b0ff22"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("c8aaaafd-5ff1-488c-be22-3915564fb7c2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("ff382f41-ca4b-4398-8e38-c521cef28455"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("1d9400cc-32e9-48ac-961a-2e26e83039ec"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("1eecdebc-d76d-4f12-8d08-a5022cb2a89f"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("24b903b1-5dec-4707-9797-f3516c798913"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("2a7e56a5-884c-4098-b798-a5c90d3c11c6"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("37e0ee70-e3db-4e61-b411-2789a549dceb"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("3e5d419a-e163-4875-8bc2-a2d785a0c2df"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("4692aa1f-84d2-4ee9-9bf0-b3ddf28b25b5"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("47206b95-92a4-4017-8705-d7bc7e1a2973"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("49740892-6e8d-45bf-8c5d-7cd4e9eb4de2"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("4a7adb25-0feb-4ffc-9615-12fed08f1228"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("54631b53-9904-432b-a931-76ce72633618"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("60866448-b428-4a69-ae5f-74fd6f3f4494"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("6b81ec45-4890-4332-8df0-1e3f55d5e5d4"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("70bf833e-99b7-4e02-a536-7aa7dccfe251"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("752a9026-8083-4d8f-8e49-6fda2b99ddea"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("7a4e44bb-65a9-4908-b641-c13d61ea626b"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("864fdd56-6a0e-454d-8dd9-3309164482db"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("8b79d2e4-891e-4d73-8f02-375b8b14c3db"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("96d2879a-cd55-4600-b07a-098040df2c27"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("a72788f8-52bc-4eab-b156-0ecf1ca2993e"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("aded7c5b-d160-4a0d-b46f-1cc7db7911b2"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("d455eb8c-7bf9-4d1c-9e22-da32896e9e46"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("de2e29b5-95e7-41cf-ac26-30535a27e0eb"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("e82819d7-8838-411d-8aee-3f4f27a51f21"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("f7fe09c2-9a5c-4ef2-9e04-d00a724d5c3d"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("f924aa36-5720-4668-ba5f-332ab13ff1bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("0b85f7c4-10c4-48b7-8e33-b2bcc6c930e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("1d40e538-8733-484e-ae46-598c6d83e211"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("1e2d7f43-aa9f-4d98-aae6-c7b0a86d611c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("20b7970e-3cd5-4bcd-9eb3-3e6d9083460a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("2ca7a9db-c84a-4036-bde9-68d1bb1d38cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("5292c381-750d-4213-a9aa-730f09a95305"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("71430cea-5a57-4d87-a865-cfde3e2f6829"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("803f1b7a-6108-4c01-86ba-5b7ce183bd51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("98d5875b-a87a-441a-9349-6d0fa15569da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("c105ae86-9dbe-4331-9665-0afe4fb881e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("c151326f-3730-4cbc-9dd6-4b9b7766ccc9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("cb69c898-b389-4a93-9130-f36b7d31b2ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("e05974f2-7506-42b9-b18e-c4d6f849c5df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("f0bcffd8-2ccc-4969-bab9-69ee81d4a2d1"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("0da33d2b-1118-4635-bb96-5382a56747d3"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("15d152bd-1831-47ac-9a0a-f89d409ef70e"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("ac9757bd-f556-4ec5-b80a-2cc8896e5bdf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("037fd886-5a76-4239-8533-3b22a792932f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("04cb98fe-49ff-4c59-810e-5c1d6751fa2f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("0dca7f0a-7e5b-4449-808d-a59a79dae0f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("108c73fe-ef1b-4b49-808c-94d025da79e5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("1457d5bc-0753-431b-b18c-133d41b2744b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("3a90befc-db71-4b9b-a153-577da2accbf6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("5c7b2551-5591-4c4a-9f95-42c83924b3f1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("5e8217be-12dc-4fd4-940d-7f9a064f9882"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("6aeefae0-0f8e-4793-99b5-fe61522429fd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("7c2aa6f4-0e26-4f20-b14e-b1e5fdcaddca"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("89f1b8dc-8083-4a0d-b5cd-d592be9cea76"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("dde98dd8-ba50-4cf3-9608-7c9d907ab22e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("f235b7ac-c009-4fdd-9d45-e8e58602aaca"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("fb46131e-77d7-4e26-b059-aaabeae8d536"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("047a9786-cc61-4100-b23b-37649f6adb75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("1f8bee0b-a286-4e8d-9bcf-7928b96cd4d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("27aa32c9-8ab2-4487-9512-59f09eabe58b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("2b1ef509-e614-40e4-a635-07f2c8d80026"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("2dcecc62-ca85-40b5-a28f-95b0d8272087"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("2ebcd021-bb15-4a6e-907f-04f14e38d8ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("308a3607-1463-497c-a673-88614fc90078"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3334d44a-6caa-48ea-8ca4-1222cd4b245e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("33a8587b-b03f-4daa-8dec-68d94f86d2c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("36298747-c223-42da-99c7-803effd46d99"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3b3ddcb9-7488-4676-91dc-a23de8bba02c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("6b2c275c-e851-48b1-9efc-94e93f165466"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("6e79c779-d656-4c20-9be5-fddf4821a170"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("755911b1-7e91-4c7c-8539-d6eb7a3cd395"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("7dc1ac21-5a81-4d58-9140-5acae67137a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("862d502b-3e00-4d1a-998f-8b3c179ccf01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("9480b47d-dffc-4ab2-abcf-6a6dc7f8c0ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("a2096caa-4059-4eba-ad4d-c41456b56e52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("b0feacec-c662-41c2-94f1-2ca100f08333"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("bd26ad66-0697-43df-9730-49858e2e0beb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("ca137355-72a2-42de-b91a-539a14bc1198"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("ca83b676-760d-4416-a308-0dcd22323870"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("e0423371-2973-411d-aa0b-9166c2613577"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("e6d5cc8f-9799-49ca-8f62-e86d1064c021"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("fa5f7e33-1935-45a0-9684-24f9466da4e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("fd672b8b-07df-4ec6-a57b-b43d78ea1534"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("22f8cce8-dad5-4d31-a827-35b2790c7348"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("825256d5-a3d1-4985-af2d-aa01389b9dd7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("01cf6e53-225e-4d97-8527-241d64096e77"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("0591e36c-5c8c-48a3-af20-77a5c58ceab8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("05e52de3-e8d1-4def-8b3a-f73c1f8fbc16"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("07f4b0f9-0109-44e4-98e7-f9305afe2680"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("345bc33a-4577-4b0d-b78e-b1bc3112ddb7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("35af6d3c-5244-409e-b0d4-0f19b3a5d435"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("38d16c73-a500-4402-a854-96f2245d5df2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("54e8d890-f148-4d22-9eab-29c3d7e017ce"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("5f2462e9-827d-4331-8e9b-6adfdb0a5833"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("670c1794-dbcf-454b-a539-5d5921e19bcd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("8ea30d57-0684-454f-85c7-8a5050aafd0e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("94ecb7cf-3070-4431-bb2b-1e9ae59b677a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("d0d88b30-1b63-42af-a902-de0c85468a85"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("d24e3782-8e0f-4dc3-b0f3-da6785d40843"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("00ec677e-f5d9-45bc-8f2e-df7d906b8921"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("0857631e-4fce-4a52-b717-75c195dc1881"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("14fbefad-8f63-430f-82d0-c10d28f7862a"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("315e9973-c145-4bfd-985e-6a04aad99aeb"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("33b3d61a-77dc-4090-8f7c-858b8c8691cd"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("33bd5409-2f0e-4d59-b21c-c4a9685b4ea0"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("39daa169-047e-4184-bd37-15f04b127175"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("3d5eb318-3442-4200-9ed7-7cb267c816fd"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("5a2d932c-6505-451f-877f-6be7273bb271"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("71466897-d17c-49d1-9d9f-d8eb8670fd9c"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("7bb086a8-c6d7-48c2-9e13-d8b3316a0421"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("7ddd3d5b-3bf3-41ea-a1de-e3f304ddfeea"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("89148db9-f165-4cb6-90f9-eb1a7b4e58e6"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("b7a01094-3afb-4e13-818a-59a931c2f48b"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("ba329989-ac8c-4044-9a7d-b7566f0355c1"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("c82e5c62-ea18-4c29-93dc-28b309561404"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("d97d0cf9-9dd0-433a-9c98-08b75063a346"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("f0566ed2-52ef-4ddc-9161-26bcb73b60bd"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("fb0fc0b4-f311-4bcb-ad20-b838b1ad1920"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("16274e2c-83ef-4ddd-b504-18a637e94a66"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("3b4ed331-9392-4d7c-bf65-56a315c6efac"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("42bf36ef-7634-4ba8-8be5-b8a171ddab12"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("45a11d4e-5089-4ef9-83d2-5fea83a28e42"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("4f5e5098-3074-4dde-94cf-90ef7a2b56c3"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("67ab8e0f-fad1-4515-95a6-9114c3aeb382"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("6b901674-76cd-4aca-8e3c-1d19c2732341"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("79620bb0-fec4-4921-9b55-c3d1d9da57cc"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("7c9914ff-256d-4beb-9ef8-c6eebaf1760e"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("839b4827-3e7f-4c35-9d2e-6e6501ac4f8e"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("c3fb3a21-ca5d-47e0-b5f6-1f3556cd01b3"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("dc7eeb83-ee94-44fe-93eb-da812056e029"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("ea734f6f-b128-4202-9f81-337a0bf64783"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("fca5864c-4e08-453e-979d-dc28807d2842"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID_Customer",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
