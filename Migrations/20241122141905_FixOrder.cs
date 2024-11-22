using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class FixOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("08c02564-5018-43ca-a685-8e7697a9ef0c"), "802 Walnut St, Newcity, USA", "Tina Copper", "tina.copper@example.com", "555-333-6666" },
                    { new Guid("0ec25c74-e709-455d-8c24-bf5c8a0ffd0e"), "802 Cherry St, Somecity, USA", "Julia Red", "julia.red@example.com", "555-333-6666" },
                    { new Guid("15de8c1e-7568-437b-94cb-bee7037ee15b"), "357 Grape St, Thatcity, USA", "Oscar Magenta", "oscar.magenta@example.com", "000-888-1111" },
                    { new Guid("16e1a3bf-cd29-4fcd-a8ca-9e08fcd3db6e"), "579 Fir St, Thistown, USA", "George White", "george.white@example.com", "999-000-1111" },
                    { new Guid("181fc13a-5e8b-4933-b052-c69fd8b6b0dc"), "680 Willow St, Thatown, USA", "Hannah Blue", "hannah.blue@example.com", "222-111-3333" },
                    { new Guid("24b4742d-16fe-4952-a520-0b4a331475a7"), "456 Elm St, Othertown, USA", "Jane Smith", "jane.smith@example.com", "444-555-6666" },
                    { new Guid("2bbd6bc5-0639-428e-ae18-35f49e7dd7d2"), "024 Plum St, Newcity, USA", "Laura Pink", "laura.pink@example.com", "777-555-8888" },
                    { new Guid("2e61adc7-7fdf-4e90-8bcd-e0982f3b232e"), "579 Fig St, Anycity, USA", "Quinn Brown", "quinn.brown@example.com", "222-000-3333" },
                    { new Guid("334e649c-8c4c-4a70-94ca-4d458588ecd9"), "246 Coconut St, Thiscity, USA", "Xander Zinc", "xander.zinc@example.com", "999-777-0000" },
                    { new Guid("3eae8071-f7ec-4c8b-bff0-43d5d2980a85"), "791 Mango St, Othercity, USA", "Alice Cooper", "alice.cooper@example.com", "222-000-3333" },
                    { new Guid("441cc2ae-b2d9-49d0-b630-9f468cacbb62"), "789 Pine St, Sometown, USA", "Alice Johnson", "alice.johnson@example.com", "222-333-4444" },
                    { new Guid("5c1a41ae-6d6e-46ab-bd82-49169506aa2c"), "321 Oak St, Anothertown, USA", "Bob Brown", "bob.brown@example.com", "555-666-7777" },
                    { new Guid("60654cb0-e74a-401e-8675-6f1fd832f1c2"), "135 Pineapple St, Thatcity, USA", "Wendy Iron", "wendy.iron@example.com", "888-666-9999" },
                    { new Guid("7baab2a4-2f40-4601-8902-8cfae2cb1b89"), "468 Berry St, Thiscity, USA", "Paula Teal", "paula.teal@example.com", "111-999-2222" },
                    { new Guid("7d9dac09-0063-4c7b-861e-b6451040f7cc"), "680 Kiwi St, Somecity, USA", "Zachary Lead", "zachary.lead@example.com", "111-999-2222" },
                    { new Guid("815ca9bd-442b-420c-b55e-7e9dcf9df7f3"), "802 Banana St, Newcity, USA", "Bob Marley", "bob.marley@example.com", "333-111-4444" },
                    { new Guid("8dd656c7-8401-4228-999e-ea543409b517"), "135 Lemon St, Oldcity, USA", "Mike Yellow", "mike.yellow@example.com", "888-666-9999" },
                    { new Guid("957c7645-fb90-4fdd-b3e9-3d32efa33798"), "913 Peach St, Othercity, USA", "Kevin Black", "kevin.black@example.com", "666-444-7777" },
                    { new Guid("992fc6e3-aff7-4fae-be1d-1e8a092964fd"), "357 Birch St, Yourtown, USA", "Ethan Hunt", "ethan.hunt@example.com", "333-444-5555" },
                    { new Guid("c177b56c-5a97-4e82-960e-596ffc85bcfa"), "791 Ash St, Anycity, USA", "Ian Gray", "ian.gray@example.com", "444-222-5555" },
                    { new Guid("c19393fd-d964-4245-b6f0-4544c6ef892c"), "680 Date St, Somecity, USA", "Rachel Silver", "rachel.silver@example.com", "333-111-4444" },
                    { new Guid("c1cba954-41e5-439b-ad83-06a60a52201c"), "246 Lime St, Yourcity, USA", "Nina Cyan", "nina.cyan@example.com", "999-777-0000" },
                    { new Guid("d1505e24-7ae2-4585-b700-5aab163eb192"), "791 Olive St, Othercity, USA", "Steve Gold", "steve.gold@example.com", "444-222-5555" },
                    { new Guid("d3b8b9f7-0ac0-4598-a29e-469e4cb68723"), "135 Maple St, Newtown, USA", "Charlie Davis", "charlie.davis@example.com", "888-999-0000" },
                    { new Guid("d5b13830-820f-4ce9-8833-4055edf045bb"), "024 Maple St, Yourcity, USA", "Victor Steel", "victor.steel@example.com", "777-555-8888" },
                    { new Guid("d75dab49-a7bc-4b3b-b70a-8e75ddf0f11a"), "357 Papaya St, Anycity, USA", "Yvonne Nickel", "yvonne.nickel@example.com", "000-888-1111" },
                    { new Guid("de6dae74-ca42-4ef6-95c6-e4f2ccd69f5d"), "123 Main St, Anytown, USA", "John Doe", "john.doe@example.com", "111-222-3333" },
                    { new Guid("eea28bf0-eb7a-412c-b2b7-3789576198b7"), "913 Chestnut St, Oldcity, USA", "Ursula Bronze", "ursula.bronze@example.com", "666-444-7777" },
                    { new Guid("f49847e4-eb96-4f97-aea4-ce7935686e36"), "246 Cedar St, Oldtown, USA", "Diana Prince", "diana.prince@example.com", "777-888-9999" },
                    { new Guid("fa28d787-7b98-4edc-a94f-bd2b05d43eb7"), "468 Spruce St, Hometown, USA", "Fiona Green", "fiona.green@example.com", "666-777-8888" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID_Supplier", "ContactName", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { new Guid("00f472e3-e729-4c4b-afb4-47b7b4bf942d"), "Oscar Magenta", "oscar.magenta@cleaningsupplies.com", "555-0117", "Cleaning Supplies" },
                    { new Guid("150ff357-4e1b-4257-90f4-7da242f3ffaa"), "Kevin Purple", "kevin.purple@petsupplies.com", "555-0113", "Pet Supplies" },
                    { new Guid("26672d2c-5bfa-40cd-9a24-b15d3be0c2be"), "Fiona Black", "fiona.black@officesuppliesco.com", "555-0108", "Office Supplies Co." },
                    { new Guid("2b7e4611-7977-409c-9872-73aad4cbddab"), "Bob", "bob@supplier.com", "098-765-4321", "Supplier B" },
                    { new Guid("306a79d3-dd09-463b-aed3-999231eeb121"), "Jane Smith", "jane.smith@globalsupplies.com", "555-0102", "Global Supplies" },
                    { new Guid("425882c1-de8b-4c50-a464-e667c9e8bf96"), "Mike Yellow", "mike.yellow@constructionmaterials.com", "555-0115", "Construction Materials" },
                    { new Guid("468b2e06-394b-44e3-914f-be7924c10f8d"), "Ethan White", "ethan.white@homeessentials.com", "555-0107", "Home Essentials" },
                    { new Guid("49283e03-ec1f-4eb1-977c-a96fe799c63d"), "Charlie", "charlie@supplier.com", "321-654-0987", "Supplier C" },
                    { new Guid("5636731c-722c-4c85-9d6f-452f4904a50d"), "Alice", "alice@supplier.com", "123-456-7890", "Supplier A" },
                    { new Guid("583539ac-99ff-4810-b062-4ab12b4eee2e"), "John Doe", "john.doe@acmecorp.com", "555-0101", "Acme Corp" },
                    { new Guid("5f5805c9-30be-4768-bf5c-9e1e7df831aa"), "Alice Johnson", "alice.johnson@techinnovations.com", "555-0103", "Tech Innovations" },
                    { new Guid("622eb028-4176-4e50-b7b1-fd061b1c12c0"), "Laura Pink", "laura.pink@automotiveparts.com", "555-0114", "Automotive Parts" },
                    { new Guid("681cf02d-f394-45dc-8a0f-5dfb24c16d01"), "Diana Green", "diana.green@ecoproducts.com", "555-0106", "Eco Products" },
                    { new Guid("819c4baa-aacd-4b59-94f0-698f5ba47072"), "George Blue", "george.blue@gourmetfoods.com", "555-0109", "Gourmet Foods" },
                    { new Guid("822c14bf-bb0f-468f-bd5f-77e16183700f"), "Charlie Davis", "charlie.davis@fastdelivery.com", "555-0105", "Fast Delivery" },
                    { new Guid("85f3c6bc-a4a8-4b59-9ce2-2f960c2f4de3"), "Paula Teal", "paula.teal@furnitureworld.com", "555-0118", "Furniture World" },
                    { new Guid("8a7047d7-4c81-4aed-8bdb-d114e3eee048"), "Bob Brown", "bob.brown@qualitygoods.com", "555-0104", "Quality Goods" },
                    { new Guid("9939120d-d873-44d0-9f94-149f43b78739"), "Nina Cyan", "nina.cyan@beveragedistributors.com", "555-0116", "Beverage Distributors" },
                    { new Guid("b4e43cb3-97e2-4e95-9945-7fe0efb90dfc"), "Diana", "diana@supplier.com", "987-654-3210", "Supplier D" },
                    { new Guid("cf34d94c-7388-4324-ab89-1a6144eba52c"), "Hannah Red", "hannah.red@fashionhub.com", "555-0110", "Fashion Hub" },
                    { new Guid("d7b77dc7-16d0-430b-9427-8bc2714c30e0"), "Julia Orange", "julia.orange@sportsgear.com", "555-0112", "Sports Gear" },
                    { new Guid("de5ca043-7fe1-4ff2-963e-10035018d805"), "Rachel Silver", "rachel.silver@digitalsolutions.com", "555-0120", "Digital Solutions" },
                    { new Guid("f558f1db-72a1-4347-8472-7715f43772d6"), "Ian Gray", "ian.gray@healthwellness.com", "555-0111", "Health & Wellness" },
                    { new Guid("ffab429b-b9e1-4020-bcbb-093d6b684142"), "Quinn Brown", "quinn.brown@gardensupplies.com", "555-0119", "Garden Supplies" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "ID_Warehouse", "Capacity", "Location", "ManagerName", "WarehouseName" },
                values: new object[,]
                {
                    { new Guid("0bb9f8e0-0500-40e8-88f8-62b1d6b4b451"), 30000, "North District", "Bob Smith", "Northside Warehouse" },
                    { new Guid("0d21dfff-cea4-4304-9306-0e4beb5950b1"), 8000, "Port Area", "Julia Red", "Bulk Storage" },
                    { new Guid("18424185-38c4-494d-99a1-9243c270528c"), 50000, "Downtown", "Alice Johnson", "Central Warehouse" },
                    { new Guid("29733313-63c1-4b11-bcbe-43ab106b1259"), 2500, "Suburban Area", "Hannah Blue", "Storage Facility" },
                    { new Guid("548245ff-5cb1-48bc-a855-43c744f2fc35"), 2500, "Location D", "Manager D", "Warehouse 4" },
                    { new Guid("5660eaea-4240-4362-9b13-403a765bbc54"), 1000, "Location A", "Manager A", "Warehouse 1" },
                    { new Guid("58e3105d-db58-4960-ab72-de93a731a60a"), 7000, "Airport Road", "George White", "Distribution Center" },
                    { new Guid("74795400-2abb-40bf-9a3c-88d7bcccd648"), 2000, "Market Street", "Ian Gray", "Cold Storage" },
                    { new Guid("b879b027-9089-4574-a773-7bcd5b150b3f"), 6000, "Industrial Park", "Fiona Green", "Logistics Hub" },
                    { new Guid("c6aef0fe-4974-41ba-bfd7-7502ebb9967a"), 1500, "Location C", "Manager C", "Warehouse 3" },
                    { new Guid("e60a4bcd-9372-4524-a3b8-7fe95158b845"), 2000, "Location B", "Manager B", "Warehouse 2" },
                    { new Guid("f458867f-fb75-423a-910c-893bb4d79c9f"), 40000, "East District", "Charlie Brown", "Eastside Warehouse" },
                    { new Guid("f6df8f8f-9eb0-4332-a1a6-5707ba8003d9"), 35000, "West District", "Diana Prince", "Westside Warehouse" },
                    { new Guid("fedf9557-059f-4eea-b5b0-29203109e14b"), 4500, "South District", "Ethan Hunt", "Southside Warehouse" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID_Order", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("30eb9510-3f26-486c-aa13-b6262fb69b0e"), new Guid("de6dae74-ca42-4ef6-95c6-e4f2ccd69f5d"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3466), "Completed", 35.00m },
                    { new Guid("39cb2674-bfc0-4ab3-9da1-f822388ffa9c"), new Guid("5c1a41ae-6d6e-46ab-bd82-49169506aa2c"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3480), "Shipped", 70.00m },
                    { new Guid("4c959a69-5354-4b3a-aae2-859a840c3b58"), new Guid("fa28d787-7b98-4edc-a94f-bd2b05d43eb7"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3496), "Completed", 5001.30m },
                    { new Guid("7318025b-fe5d-4a25-a9f3-afef7d83ebe2"), new Guid("441cc2ae-b2d9-49d0-b630-9f468cacbb62"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3476), "Completed", 80.00m },
                    { new Guid("81f2b9d2-eba5-43ec-8b18-5075eda47d88"), new Guid("16e1a3bf-cd29-4fcd-a8ca-9e08fcd3db6e"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3500), "Pending", 11000.20m },
                    { new Guid("874b6bd8-6437-45f1-ad27-af40ee1e9221"), new Guid("2bbd6bc5-0639-428e-ae18-35f49e7dd7d2"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3519), "Pending", 6300.80m },
                    { new Guid("90327cc8-0605-40b0-91bf-f17b25a09e52"), new Guid("f49847e4-eb96-4f97-aea4-ce7935686e36"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3488), "Pending", 300.50m },
                    { new Guid("a84ef213-d5d1-4b88-9598-ab1d50945976"), new Guid("d3b8b9f7-0ac0-4598-a29e-469e4cb68723"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3484), "Completed", 300.50m },
                    { new Guid("b0cf6fad-e3e0-4153-99ce-bd960b348da4"), new Guid("992fc6e3-aff7-4fae-be1d-1e8a092964fd"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3492), "Shipped", 6000.50m },
                    { new Guid("be28d647-c9ea-4cd1-a365-ebd6b9b9b6d2"), new Guid("24b4742d-16fe-4952-a520-0b4a331475a7"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3472), "Pending", 20.00m },
                    { new Guid("beec2dad-3809-4f16-84aa-bae57627bfa9"), new Guid("957c7645-fb90-4fdd-b3e9-3d32efa33798"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3515), "Completed", 3201.00m },
                    { new Guid("c761f43b-088d-4efe-b211-f31e6c42a173"), new Guid("181fc13a-5e8b-4933-b052-c69fd8b6b0dc"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3504), "Completed", 3500.00m },
                    { new Guid("c8643637-5b69-4af0-9a6d-3429d236d1df"), new Guid("0ec25c74-e709-455d-8c24-bf5c8a0ffd0e"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3511), "Shipped", 1400.20m },
                    { new Guid("db67442d-f2de-44ba-b41b-a7712cc27320"), new Guid("c177b56c-5a97-4e82-960e-596ffc85bcfa"), new DateTime(2024, 11, 22, 14, 19, 4, 903, DateTimeKind.Utc).AddTicks(3507), "Pending", 800.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID_Product", "Cell", "Producer", "ProductName", "QuantityInStock", "SupplierID", "UnitPrice", "WarehouseID" },
                values: new object[,]
                {
                    { new Guid("02c58195-8d04-4106-987b-6205e2bd582d"), "a114", "Berry Good", "Frozen Berries", 120, new Guid("822c14bf-bb0f-468f-bd5f-77e16183700f"), 400.00m, new Guid("e60a4bcd-9372-4524-a3b8-7fe95158b845") },
                    { new Guid("0c37c3dc-0322-419e-b7b7-eb7216f01af2"), "a137", "Garden Fresh", "Zucchini", 150, new Guid("2b7e4611-7977-409c-9872-73aad4cbddab"), 1777.00m, new Guid("0bb9f8e0-0500-40e8-88f8-62b1d6b4b451") },
                    { new Guid("0dc583e3-2692-4b21-87f6-eee8cab6e458"), "a12", "Nutty Delights", "Almond Milk", 100, new Guid("622eb028-4176-4e50-b7b1-fd061b1c12c0"), 300.50m, new Guid("e60a4bcd-9372-4524-a3b8-7fe95158b845") },
                    { new Guid("1d126102-f297-4f5e-a387-432d117a178f"), "a107", "Tropical Goods", "Coconut Oil", 70, new Guid("425882c1-de8b-4c50-a464-e667c9e8bf96"), 6000.00m, new Guid("e60a4bcd-9372-4524-a3b8-7fe95158b845") },
                    { new Guid("22712885-e0cd-40b6-ac06-db6cf07f7e59"), "a115", "Nutty Spread", "Peanut Butter", 90, new Guid("8a7047d7-4c81-4aed-8bdb-d114e3eee048"), 3000.50m, new Guid("0d21dfff-cea4-4304-9306-0e4beb5950b1") },
                    { new Guid("2a81ea83-c027-48e6-ad93-b1314f804ff1"), "a136", "Snack Time", "Pumpkin Seeds", 90, new Guid("622eb028-4176-4e50-b7b1-fd061b1c12c0"), 4777.00m, new Guid("18424185-38c4-494d-99a1-9243c270528c") },
                    { new Guid("3000aba2-70eb-4b0f-8801-fcbb05379828"), "a126", "Root Veggies", "Sweet Potatoes", 120, new Guid("49283e03-ec1f-4eb1-977c-a96fe799c63d"), 100.80m, new Guid("f458867f-fb75-423a-910c-893bb4d79c9f") },
                    { new Guid("386cb7d0-c604-47d5-9ad7-22dcc22510d2"), "a103", "Producer 2", "Product 4", 80, new Guid("49283e03-ec1f-4eb1-977c-a96fe799c63d"), 25.00m, new Guid("f458867f-fb75-423a-910c-893bb4d79c9f") },
                    { new Guid("3cfa5bb1-5871-47eb-924d-da44f31eb32c"), "a139", "Asian Cuisine", "Rice Noodles", 130, new Guid("b4e43cb3-97e2-4e95-9945-7fe0efb90dfc"), 3777.50m, new Guid("f6df8f8f-9eb0-4332-a1a6-5707ba8003d9") },
                    { new Guid("4270c1f7-6610-4e54-8e79-5016ac00e18a"), "a111", "Superfoods Co.", "Chia Seeds", 150, new Guid("306a79d3-dd09-463b-aed3-999231eeb121"), 500.00m, new Guid("fedf9557-059f-4eea-b5b0-29203109e14b") },
                    { new Guid("45f64507-75a8-41d9-b178-f6c0be3ae039"), "a113", "Legume Lovers", "Canned Chickpeas", 300, new Guid("681cf02d-f394-45dc-8a0f-5dfb24c16d01"), 1000.20m, new Guid("548245ff-5cb1-48bc-a855-43c744f2fc35") },
                    { new Guid("52c220ad-b160-47c8-99ce-c6bcf0d3d0a1"), "a10", "Fresh Farms", "Organic Apples", 150, new Guid("150ff357-4e1b-4257-90f4-7da242f3ffaa"), 100.50m, new Guid("5660eaea-4240-4362-9b13-403a765bbc54") },
                    { new Guid("5920611e-362f-428c-a273-6e1085c795ff"), "a104", "Producer 3", "Product 5", 60, new Guid("49283e03-ec1f-4eb1-977c-a96fe799c63d"), 30.00m, new Guid("f458867f-fb75-423a-910c-893bb4d79c9f") },
                    { new Guid("6082b477-c64c-4b5e-8b64-7e84c499ea98"), "a13", "Dairy Best", "Greek Yogurt", 80, new Guid("622eb028-4176-4e50-b7b1-fd061b1c12c0"), 4000.00m, new Guid("c6aef0fe-4974-41ba-bfd7-7502ebb9967a") },
                    { new Guid("646fbdce-e801-4f2f-91c7-c196362f6b7b"), "a108", "Choco Bliss", "Dark Chocolate", 50, new Guid("9939120d-d873-44d0-9f94-149f43b78739"), 3000.00m, new Guid("29733313-63c1-4b11-bcbe-43ab106b1259") },
                    { new Guid("67e05ad3-708d-4a0f-8ceb-0de7f1521dc8"), "a132", "Spice World", "Cinnamon", 150, new Guid("cf34d94c-7388-4324-ab89-1a6144eba52c"), 300.00m, new Guid("18424185-38c4-494d-99a1-9243c270528c") },
                    { new Guid("6ce0a939-fe14-4d26-bebc-c77ad67ca5c5"), "a11", "Bakery Co.", "Whole Wheat Bread", 200, new Guid("150ff357-4e1b-4257-90f4-7da242f3ffaa"), 200.00m, new Guid("5660eaea-4240-4362-9b13-403a765bbc54") },
                    { new Guid("73d7c52f-176b-49ed-89ff-ad6f07521687"), "a109", "Green Leaf", "Spinach", 110, new Guid("00f472e3-e729-4c4b-afb4-47b7b4bf942d"), 2000.20m, new Guid("58e3105d-db58-4960-ab72-de93a731a60a") },
                    { new Guid("7b81bb69-5c13-41af-9cda-5223d1e28944"), "a129", "Gourmet Essentials", "Balsamic Vinegar", 70, new Guid("5636731c-722c-4c85-9d6f-452f4904a50d"), 4000.50m, new Guid("18424185-38c4-494d-99a1-9243c270528c") },
                    { new Guid("878f48a7-db76-449f-a750-8bf7c41da1d3"), "a135", "Healthy Harvest", "Lentils", 180, new Guid("150ff357-4e1b-4257-90f4-7da242f3ffaa"), 177.20m, new Guid("f6df8f8f-9eb0-4332-a1a6-5707ba8003d9") },
                    { new Guid("925c7bbb-bb82-4754-befd-2f4c176b34d7"), "a127", "Garden Fresh", "Canned Tomatoes", 300, new Guid("b4e43cb3-97e2-4e95-9945-7fe0efb90dfc"), 1000.00m, new Guid("f6df8f8f-9eb0-4332-a1a6-5707ba8003d9") },
                    { new Guid("92fe2ca3-6717-4194-abbb-f16ef82ce71f"), "a131", "Nutty Delights", "Almonds", 80, new Guid("819c4baa-aacd-4b59-94f0-698f5ba47072"), 8000.00m, new Guid("f6df8f8f-9eb0-4332-a1a6-5707ba8003d9") },
                    { new Guid("9570aacc-51ed-45c3-b79f-ecfbc4352cb0"), "a102", "Producer 2", "Product 3", 150, new Guid("2b7e4611-7977-409c-9872-73aad4cbddab"), 20.00m, new Guid("0bb9f8e0-0500-40e8-88f8-62b1d6b4b451") },
                    { new Guid("96b1a41c-8b34-495b-b76f-58451a206e4c"), "a130", "Plant Protein Co.", "Tofu", 100, new Guid("26672d2c-5bfa-40cd-9a24-b15d3be0c2be"), 200.50m, new Guid("f458867f-fb75-423a-910c-893bb4d79c9f") },
                    { new Guid("9b4ddf17-05e4-4d09-9ffa-1a1783deff38"), "a116", "Tropical Refreshments", "Coconut Water", 200, new Guid("468b2e06-394b-44e3-914f-be7924c10f8d"), 200.50m, new Guid("74795400-2abb-40bf-9a3c-88d7bcccd648") },
                    { new Guid("a31a169b-5c58-4d4d-afc9-1578ef17de0e"), "a14", "Farm Fresh", "Free-Range Eggs", 60, new Guid("622eb028-4176-4e50-b7b1-fd061b1c12c0"), 2000.50m, new Guid("c6aef0fe-4974-41ba-bfd7-7502ebb9967a") },
                    { new Guid("a4713f2f-2cdf-44e1-afc0-200ba0b9bfd1"), "a15", "Grain Masters", "Brown Rice", 120, new Guid("425882c1-de8b-4c50-a464-e667c9e8bf96"), 1000.80m, new Guid("548245ff-5cb1-48bc-a855-43c744f2fc35") },
                    { new Guid("a70a1dd7-102d-4afb-adab-e0673aeddaaa"), "a106", "Healthy Grains", "Quinoa", 90, new Guid("425882c1-de8b-4c50-a464-e667c9e8bf96"), 4000.50m, new Guid("548245ff-5cb1-48bc-a855-43c744f2fc35") },
                    { new Guid("aee79716-865e-4c46-a528-839efb7c2b7f"), "a133", "Legume Lovers", "Black Beans", 200, new Guid("f558f1db-72a1-4347-8472-7715f43772d6"), 100.50m, new Guid("0bb9f8e0-0500-40e8-88f8-62b1d6b4b451") },
                    { new Guid("b7a50599-43ee-4205-975f-cd8d282dc3ec"), "a119", "Sweet Harvest", "Maple Syrup", 70, new Guid("26672d2c-5bfa-40cd-9a24-b15d3be0c2be"), 6000.00m, new Guid("b879b027-9089-4574-a773-7bcd5b150b3f") },
                    { new Guid("c1b7e3dd-46ee-49ac-879e-5cb15ebe4480"), "a101", "Producer 2", "Product 2", 200, new Guid("5636731c-722c-4c85-9d6f-452f4904a50d"), 15.00m, new Guid("18424185-38c4-494d-99a1-9243c270528c") },
                    { new Guid("c449035c-eb8c-4c9c-9777-6d709d5514c9"), "a117", "Snack Time", "Granola Bars", 150, new Guid("cf34d94c-7388-4324-ab89-1a6144eba52c"), 100.80m, new Guid("29733313-63c1-4b11-bcbe-43ab106b1259") },
                    { new Guid("d4ef38f1-cbf4-47ee-a7ae-72ca3d030159"), "a112", "Nature's Best", "Avocado Oil", 80, new Guid("5f5805c9-30be-4768-bf5c-9e1e7df831aa"), 800.00m, new Guid("c6aef0fe-4974-41ba-bfd7-7502ebb9967a") },
                    { new Guid("d725d188-f960-41c9-a3cc-000b81f48e5e"), "a138", "Tropical Goods", "Coconut Milk", 110, new Guid("49283e03-ec1f-4eb1-977c-a96fe799c63d"), 2777.50m, new Guid("f458867f-fb75-423a-910c-893bb4d79c9f") },
                    { new Guid("ddaafc36-f7c7-438f-bedc-e754b148da68"), "a118", "Dips & Spreads", "Hummus", 100, new Guid("819c4baa-aacd-4b59-94f0-698f5ba47072"), 200.00m, new Guid("58e3105d-db58-4960-ab72-de93a731a60a") },
                    { new Guid("ddd739d0-d947-4dd6-bca6-74434ddd059f"), "a128", "Healthy Snacks", "Nut Mix", 90, new Guid("2b7e4611-7977-409c-9872-73aad4cbddab"), 600.00m, new Guid("0bb9f8e0-0500-40e8-88f8-62b1d6b4b451") },
                    { new Guid("eb5e5f1f-730d-4876-9106-a0a341faa2ad"), "a105", "Producer 3", "Product 6", 40, new Guid("b4e43cb3-97e2-4e95-9945-7fe0efb90dfc"), 35.00m, new Guid("f6df8f8f-9eb0-4332-a1a6-5707ba8003d9") },
                    { new Guid("ecabd6cd-c907-4f61-8659-308721950e03"), "a100", "Producer 1", "Product 1", 100, new Guid("5636731c-722c-4c85-9d6f-452f4904a50d"), 10.00m, new Guid("18424185-38c4-494d-99a1-9243c270528c") },
                    { new Guid("f69e4b89-6144-4c54-880d-9ea214d764b1"), "a110", "Healthy Mornings", "Oatmeal", 200, new Guid("583539ac-99ff-4810-b062-4ab12b4eee2e"), 3000.00m, new Guid("f458867f-fb75-423a-910c-893bb4d79c9f") },
                    { new Guid("fb24b90f-a154-4790-9879-2cd0a2b7b01e"), "a134", "Fresh Greens", "Cabbage", 120, new Guid("d7b77dc7-16d0-430b-9427-8bc2714c30e0"), 166.80m, new Guid("f458867f-fb75-423a-910c-893bb4d79c9f") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "ID_OrderDetails", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("20fee1be-9bf0-45f1-b013-7fda500ae5f5"), new Guid("81f2b9d2-eba5-43ec-8b18-5075eda47d88"), new Guid("1d126102-f297-4f5e-a387-432d117a178f"), 1, 6000.00m },
                    { new Guid("39eff660-b936-4f47-91fb-2871744cbbcc"), new Guid("c8643637-5b69-4af0-9a6d-3429d236d1df"), new Guid("02c58195-8d04-4106-987b-6205e2bd582d"), 1, 400.00m },
                    { new Guid("3dfcc6fa-d8c1-42f7-8917-4a559702ebf9"), new Guid("7318025b-fe5d-4a25-a9f3-afef7d83ebe2"), new Guid("386cb7d0-c604-47d5-9ad7-22dcc22510d2"), 2, 25.00m },
                    { new Guid("4eeaa75c-2b41-405c-a5d4-13f954a64c46"), new Guid("81f2b9d2-eba5-43ec-8b18-5075eda47d88"), new Guid("73d7c52f-176b-49ed-89ff-ad6f07521687"), 1, 2000.20m },
                    { new Guid("50b5c1af-237f-4cd5-aa4c-1f9e2b3ae053"), new Guid("4c959a69-5354-4b3a-aae2-859a840c3b58"), new Guid("a70a1dd7-102d-4afb-adab-e0673aeddaaa"), 1, 4000.50m },
                    { new Guid("5bc93166-3e7b-4b32-94a0-ad588efcbce3"), new Guid("b0cf6fad-e3e0-4153-99ce-bd960b348da4"), new Guid("6082b477-c64c-4b5e-8b64-7e84c499ea98"), 1, 4000.00m },
                    { new Guid("5e7881ac-07e1-4728-80fb-8c95c66d5f8e"), new Guid("b0cf6fad-e3e0-4153-99ce-bd960b348da4"), new Guid("a31a169b-5c58-4d4d-afc9-1578ef17de0e"), 1, 2000.50m },
                    { new Guid("640904f7-f688-4643-a71c-541339eec669"), new Guid("874b6bd8-6437-45f1-ad27-af40ee1e9221"), new Guid("ddaafc36-f7c7-438f-bedc-e754b148da68"), 1, 200.00m },
                    { new Guid("65fc9065-546d-4aea-84b1-84e6a0f574a7"), new Guid("30eb9510-3f26-486c-aa13-b6262fb69b0e"), new Guid("ecabd6cd-c907-4f61-8659-308721950e03"), 2, 10.00m },
                    { new Guid("75bd291d-23c7-49bb-ae2e-9ef8f7cce691"), new Guid("7318025b-fe5d-4a25-a9f3-afef7d83ebe2"), new Guid("5920611e-362f-428c-a273-6e1085c795ff"), 1, 30.00m },
                    { new Guid("7bca3d48-0a0a-4ff2-bb3d-72ab848bca6e"), new Guid("a84ef213-d5d1-4b88-9598-ab1d50945976"), new Guid("52c220ad-b160-47c8-99ce-c6bcf0d3d0a1"), 1, 100.50m },
                    { new Guid("90a066ca-fe11-4a2c-b415-f34052ac47c1"), new Guid("4c959a69-5354-4b3a-aae2-859a840c3b58"), new Guid("a4713f2f-2cdf-44e1-afc0-200ba0b9bfd1"), 1, 1000.80m },
                    { new Guid("92dc4106-f5a8-4d0e-a6a5-41f735f892ea"), new Guid("c8643637-5b69-4af0-9a6d-3429d236d1df"), new Guid("45f64507-75a8-41d9-b178-f6c0be3ae039"), 1, 1000.20m },
                    { new Guid("9741fbd5-6886-49f5-b94f-c79cdc24fe03"), new Guid("39cb2674-bfc0-4ab3-9da1-f822388ffa9c"), new Guid("eb5e5f1f-730d-4876-9106-a0a341faa2ad"), 2, 35.00m },
                    { new Guid("ac7aa424-79e2-4929-8f96-e00e51b0b2f1"), new Guid("be28d647-c9ea-4cd1-a365-ebd6b9b9b6d2"), new Guid("9570aacc-51ed-45c3-b79f-ecfbc4352cb0"), 1, 20.00m },
                    { new Guid("ad1868b5-52ac-452a-be51-3187d2a85f42"), new Guid("81f2b9d2-eba5-43ec-8b18-5075eda47d88"), new Guid("646fbdce-e801-4f2f-91c7-c196362f6b7b"), 1, 3000.00m },
                    { new Guid("bf3acefc-8c06-41a4-9346-11b2cf898b79"), new Guid("874b6bd8-6437-45f1-ad27-af40ee1e9221"), new Guid("b7a50599-43ee-4205-975f-cd8d282dc3ec"), 1, 6000.00m },
                    { new Guid("cd989b02-e514-408c-8d89-c380121ff2dd"), new Guid("beec2dad-3809-4f16-84aa-bae57627bfa9"), new Guid("9b4ddf17-05e4-4d09-9ffa-1a1783deff38"), 1, 200.50m },
                    { new Guid("cfbc7a1d-c8b9-4ce6-91bf-1217150eb690"), new Guid("a84ef213-d5d1-4b88-9598-ab1d50945976"), new Guid("6ce0a939-fe14-4d26-bebc-c77ad67ca5c5"), 1, 200.00m },
                    { new Guid("d1b41f40-748d-4e8d-bace-312a87cf816a"), new Guid("beec2dad-3809-4f16-84aa-bae57627bfa9"), new Guid("22712885-e0cd-40b6-ac06-db6cf07f7e59"), 1, 3000.50m },
                    { new Guid("d45aedb8-c0e6-48b8-b835-a1839e272047"), new Guid("c761f43b-088d-4efe-b211-f31e6c42a173"), new Guid("4270c1f7-6610-4e54-8e79-5016ac00e18a"), 1, 500.00m },
                    { new Guid("d49a2309-f4ae-48c0-894d-4438b7577d8f"), new Guid("c761f43b-088d-4efe-b211-f31e6c42a173"), new Guid("f69e4b89-6144-4c54-880d-9ea214d764b1"), 1, 3000.00m },
                    { new Guid("e9cee9ad-a39a-45af-a3c9-e781753ef2e2"), new Guid("30eb9510-3f26-486c-aa13-b6262fb69b0e"), new Guid("c1b7e3dd-46ee-49ac-879e-5cb15ebe4480"), 1, 15.00m },
                    { new Guid("f2ff20bf-606a-4e09-b078-52c85c1faee2"), new Guid("874b6bd8-6437-45f1-ad27-af40ee1e9221"), new Guid("c449035c-eb8c-4c9c-9777-6d709d5514c9"), 1, 100.80m },
                    { new Guid("f34be459-2b5b-4c30-8027-458fabc52917"), new Guid("90327cc8-0605-40b0-91bf-f17b25a09e52"), new Guid("0dc583e3-2692-4b21-87f6-eee8cab6e458"), 1, 300.50m },
                    { new Guid("f3c0cb21-f38a-4daa-bd3f-bd0b35925aad"), new Guid("db67442d-f2de-44ba-b41b-a7712cc27320"), new Guid("d4ef38f1-cbf4-47ee-a7ae-72ca3d030159"), 1, 800.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("08c02564-5018-43ca-a685-8e7697a9ef0c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("15de8c1e-7568-437b-94cb-bee7037ee15b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("2e61adc7-7fdf-4e90-8bcd-e0982f3b232e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("334e649c-8c4c-4a70-94ca-4d458588ecd9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("3eae8071-f7ec-4c8b-bff0-43d5d2980a85"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("60654cb0-e74a-401e-8675-6f1fd832f1c2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("7baab2a4-2f40-4601-8902-8cfae2cb1b89"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("7d9dac09-0063-4c7b-861e-b6451040f7cc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("815ca9bd-442b-420c-b55e-7e9dcf9df7f3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("8dd656c7-8401-4228-999e-ea543409b517"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("c19393fd-d964-4245-b6f0-4544c6ef892c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("c1cba954-41e5-439b-ad83-06a60a52201c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("d1505e24-7ae2-4585-b700-5aab163eb192"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("d5b13830-820f-4ce9-8833-4055edf045bb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("d75dab49-a7bc-4b3b-b70a-8e75ddf0f11a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("eea28bf0-eb7a-412c-b2b7-3789576198b7"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("20fee1be-9bf0-45f1-b013-7fda500ae5f5"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("39eff660-b936-4f47-91fb-2871744cbbcc"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("3dfcc6fa-d8c1-42f7-8917-4a559702ebf9"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("4eeaa75c-2b41-405c-a5d4-13f954a64c46"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("50b5c1af-237f-4cd5-aa4c-1f9e2b3ae053"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("5bc93166-3e7b-4b32-94a0-ad588efcbce3"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("5e7881ac-07e1-4728-80fb-8c95c66d5f8e"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("640904f7-f688-4643-a71c-541339eec669"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("65fc9065-546d-4aea-84b1-84e6a0f574a7"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("75bd291d-23c7-49bb-ae2e-9ef8f7cce691"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("7bca3d48-0a0a-4ff2-bb3d-72ab848bca6e"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("90a066ca-fe11-4a2c-b415-f34052ac47c1"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("92dc4106-f5a8-4d0e-a6a5-41f735f892ea"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("9741fbd5-6886-49f5-b94f-c79cdc24fe03"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("ac7aa424-79e2-4929-8f96-e00e51b0b2f1"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("ad1868b5-52ac-452a-be51-3187d2a85f42"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("bf3acefc-8c06-41a4-9346-11b2cf898b79"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("cd989b02-e514-408c-8d89-c380121ff2dd"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("cfbc7a1d-c8b9-4ce6-91bf-1217150eb690"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("d1b41f40-748d-4e8d-bace-312a87cf816a"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("d45aedb8-c0e6-48b8-b835-a1839e272047"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("d49a2309-f4ae-48c0-894d-4438b7577d8f"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("e9cee9ad-a39a-45af-a3c9-e781753ef2e2"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("f2ff20bf-606a-4e09-b078-52c85c1faee2"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("f34be459-2b5b-4c30-8027-458fabc52917"));

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "ID_OrderDetails",
                keyValue: new Guid("f3c0cb21-f38a-4daa-bd3f-bd0b35925aad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("0c37c3dc-0322-419e-b7b7-eb7216f01af2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("2a81ea83-c027-48e6-ad93-b1314f804ff1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3000aba2-70eb-4b0f-8801-fcbb05379828"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("3cfa5bb1-5871-47eb-924d-da44f31eb32c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("67e05ad3-708d-4a0f-8ceb-0de7f1521dc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("7b81bb69-5c13-41af-9cda-5223d1e28944"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("878f48a7-db76-449f-a750-8bf7c41da1d3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("925c7bbb-bb82-4754-befd-2f4c176b34d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("92fe2ca3-6717-4194-abbb-f16ef82ce71f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("96b1a41c-8b34-495b-b76f-58451a206e4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("aee79716-865e-4c46-a528-839efb7c2b7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("d725d188-f960-41c9-a3cc-000b81f48e5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("ddd739d0-d947-4dd6-bca6-74434ddd059f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("fb24b90f-a154-4790-9879-2cd0a2b7b01e"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("85f3c6bc-a4a8-4b59-9ce2-2f960c2f4de3"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("de5ca043-7fe1-4ff2-963e-10035018d805"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("ffab429b-b9e1-4020-bcbb-093d6b684142"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("30eb9510-3f26-486c-aa13-b6262fb69b0e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("39cb2674-bfc0-4ab3-9da1-f822388ffa9c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("4c959a69-5354-4b3a-aae2-859a840c3b58"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("7318025b-fe5d-4a25-a9f3-afef7d83ebe2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("81f2b9d2-eba5-43ec-8b18-5075eda47d88"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("874b6bd8-6437-45f1-ad27-af40ee1e9221"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("90327cc8-0605-40b0-91bf-f17b25a09e52"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("a84ef213-d5d1-4b88-9598-ab1d50945976"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("b0cf6fad-e3e0-4153-99ce-bd960b348da4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("be28d647-c9ea-4cd1-a365-ebd6b9b9b6d2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("beec2dad-3809-4f16-84aa-bae57627bfa9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("c761f43b-088d-4efe-b211-f31e6c42a173"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("c8643637-5b69-4af0-9a6d-3429d236d1df"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID_Order",
                keyValue: new Guid("db67442d-f2de-44ba-b41b-a7712cc27320"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("02c58195-8d04-4106-987b-6205e2bd582d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("0dc583e3-2692-4b21-87f6-eee8cab6e458"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("1d126102-f297-4f5e-a387-432d117a178f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("22712885-e0cd-40b6-ac06-db6cf07f7e59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("386cb7d0-c604-47d5-9ad7-22dcc22510d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("4270c1f7-6610-4e54-8e79-5016ac00e18a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("45f64507-75a8-41d9-b178-f6c0be3ae039"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("52c220ad-b160-47c8-99ce-c6bcf0d3d0a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("5920611e-362f-428c-a273-6e1085c795ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("6082b477-c64c-4b5e-8b64-7e84c499ea98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("646fbdce-e801-4f2f-91c7-c196362f6b7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("6ce0a939-fe14-4d26-bebc-c77ad67ca5c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("73d7c52f-176b-49ed-89ff-ad6f07521687"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("9570aacc-51ed-45c3-b79f-ecfbc4352cb0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("9b4ddf17-05e4-4d09-9ffa-1a1783deff38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("a31a169b-5c58-4d4d-afc9-1578ef17de0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("a4713f2f-2cdf-44e1-afc0-200ba0b9bfd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("a70a1dd7-102d-4afb-adab-e0673aeddaaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("b7a50599-43ee-4205-975f-cd8d282dc3ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("c1b7e3dd-46ee-49ac-879e-5cb15ebe4480"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("c449035c-eb8c-4c9c-9777-6d709d5514c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("d4ef38f1-cbf4-47ee-a7ae-72ca3d030159"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("ddaafc36-f7c7-438f-bedc-e754b148da68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("eb5e5f1f-730d-4876-9106-a0a341faa2ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("ecabd6cd-c907-4f61-8659-308721950e03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID_Product",
                keyValue: new Guid("f69e4b89-6144-4c54-880d-9ea214d764b1"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("d7b77dc7-16d0-430b-9427-8bc2714c30e0"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("f558f1db-72a1-4347-8472-7715f43772d6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("0ec25c74-e709-455d-8c24-bf5c8a0ffd0e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("16e1a3bf-cd29-4fcd-a8ca-9e08fcd3db6e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("181fc13a-5e8b-4933-b052-c69fd8b6b0dc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("24b4742d-16fe-4952-a520-0b4a331475a7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("2bbd6bc5-0639-428e-ae18-35f49e7dd7d2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("441cc2ae-b2d9-49d0-b630-9f468cacbb62"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("5c1a41ae-6d6e-46ab-bd82-49169506aa2c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("957c7645-fb90-4fdd-b3e9-3d32efa33798"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("992fc6e3-aff7-4fae-be1d-1e8a092964fd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("c177b56c-5a97-4e82-960e-596ffc85bcfa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("d3b8b9f7-0ac0-4598-a29e-469e4cb68723"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("de6dae74-ca42-4ef6-95c6-e4f2ccd69f5d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("f49847e4-eb96-4f97-aea4-ce7935686e36"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID_Customer",
                keyValue: new Guid("fa28d787-7b98-4edc-a94f-bd2b05d43eb7"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("00f472e3-e729-4c4b-afb4-47b7b4bf942d"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("150ff357-4e1b-4257-90f4-7da242f3ffaa"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("26672d2c-5bfa-40cd-9a24-b15d3be0c2be"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("2b7e4611-7977-409c-9872-73aad4cbddab"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("306a79d3-dd09-463b-aed3-999231eeb121"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("425882c1-de8b-4c50-a464-e667c9e8bf96"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("468b2e06-394b-44e3-914f-be7924c10f8d"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("49283e03-ec1f-4eb1-977c-a96fe799c63d"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("5636731c-722c-4c85-9d6f-452f4904a50d"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("583539ac-99ff-4810-b062-4ab12b4eee2e"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("5f5805c9-30be-4768-bf5c-9e1e7df831aa"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("622eb028-4176-4e50-b7b1-fd061b1c12c0"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("681cf02d-f394-45dc-8a0f-5dfb24c16d01"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("819c4baa-aacd-4b59-94f0-698f5ba47072"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("822c14bf-bb0f-468f-bd5f-77e16183700f"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("8a7047d7-4c81-4aed-8bdb-d114e3eee048"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("9939120d-d873-44d0-9f94-149f43b78739"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("b4e43cb3-97e2-4e95-9945-7fe0efb90dfc"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID_Supplier",
                keyValue: new Guid("cf34d94c-7388-4324-ab89-1a6144eba52c"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("0bb9f8e0-0500-40e8-88f8-62b1d6b4b451"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("0d21dfff-cea4-4304-9306-0e4beb5950b1"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("18424185-38c4-494d-99a1-9243c270528c"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("29733313-63c1-4b11-bcbe-43ab106b1259"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("548245ff-5cb1-48bc-a855-43c744f2fc35"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("5660eaea-4240-4362-9b13-403a765bbc54"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("58e3105d-db58-4960-ab72-de93a731a60a"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("74795400-2abb-40bf-9a3c-88d7bcccd648"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("b879b027-9089-4574-a773-7bcd5b150b3f"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("c6aef0fe-4974-41ba-bfd7-7502ebb9967a"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("e60a4bcd-9372-4524-a3b8-7fe95158b845"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("f458867f-fb75-423a-910c-893bb4d79c9f"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("f6df8f8f-9eb0-4332-a1a6-5707ba8003d9"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "ID_Warehouse",
                keyValue: new Guid("fedf9557-059f-4eea-b5b0-29203109e14b"));

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
        }
    }
}
