using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver171 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Cars_CarID",
                table: "Slots");

            migrationBuilder.DropIndex(
                name: "IX_Slots_CarID",
                table: "Slots");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("037764c0-486c-4c07-aecc-31a6d244ead7"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("0897514a-f884-4aa9-a109-ab22c6deb9c8"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("27819c23-e949-4347-be88-012e7ae06bb2"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("5030cdd6-f2ae-47d3-bc2f-0e6a0f1f34f9"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("5cc877e4-858a-44aa-9777-969af598697e"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("720b9484-a933-46c2-8d1f-557bcd7fcd07"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("2675d2d8-aa1c-4739-a3af-a12822eec77d"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("8e256b2b-acc2-4e14-bfb5-ac5082c0707c"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("e31b4c75-a76e-4923-bcff-0c36c564f091"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01248517-025d-4573-b18c-7459177d2127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01ab5afb-ebcc-44f8-9a06-4724f8aba83d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("031a736a-7f7f-4f5d-949b-bfd6ed88d953"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0417cdb2-605d-43ae-a2db-911a098f439a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("04671dfe-10fd-446b-9207-110df183277f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("04fb341b-4aee-4ac9-964b-7f5694eabbe0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0664da20-2011-4d1b-8516-085b950ce73d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("092694d7-59b2-401c-834a-65a2366e43d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0baf34ce-fef4-4a1f-a392-a660a7fbefb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("10395355-afe0-4b9b-9705-0ec78e445f8d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("11dde897-880b-4749-adc4-6fae4ca311bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("126b5f10-60d4-4ff1-8251-9bbe54eed797"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1291467e-ecf4-4a4a-9b0f-c2d289076d76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("159cf391-6a35-423a-91e2-89254d8bab70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("18e7f3f9-82be-4e60-8ebe-09486e3c7695"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1c366f3a-e3c1-4f03-8bef-3f986c98f4ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1dd8ca62-990b-45e2-b76f-38e86601f3e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1de4bed8-380c-48de-81c7-ed55c00c71df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("240ae2a7-55c3-43ea-9a44-93a085056d21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("25605ac4-e411-46f5-8301-8cad38b79618"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2749a28c-559c-46ed-a9c4-ba37cd1857e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("289869e1-f613-4627-b83d-de5a33ae61ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2e9fa4a2-bb5f-4a83-a72f-6870ca9a1576"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("354833ca-5a66-45b7-90ea-f2d081f03b12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("36d5de9d-5d9a-413f-928c-612c2f113b3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3912de42-bd93-4753-8fdb-b5e848b423ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3c4a7e9c-6839-4bc1-953e-e3c41d5bb44c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3d2cc589-5382-4b7f-8118-ad2432124c8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3dbc224a-f0f1-4700-8b11-ffbe0a7ddbd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3e3ac7d0-682a-4e82-b6f5-5d18001868f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3f4e7467-1a68-440e-800d-e3442ea897a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("452fa997-932b-4a46-afb5-f49df9c923c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("47bf75e6-21a8-4eb8-93f0-d39d71953a34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4978e7a2-b5f5-451e-848e-bbfc172a9f9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("498f4071-1bf1-4db4-9428-cbef0cfe668e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4a6d5d51-2d86-4395-9f66-04d917087de1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4b7a5e3d-655a-48b1-a070-1e83be7414fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("50115667-8769-4f2a-8cd4-698263bf6528"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("502451ee-5ebc-4c2b-947d-59b90719b594"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("50c819c9-85c3-4663-bf9d-e94e1388ecd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5468a97b-7e1c-4d0f-b233-09a67a3cb9a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("57037881-f16f-4720-9d97-80d94f9f0db3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("583af59a-03ed-4caa-82c2-aa0e48d08528"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ea9c96a-4ebb-4bbc-8d66-22624cc2a822"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6438cedc-d8f9-48b1-8797-70c38a80b999"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("64f096f6-c411-4cdc-acd6-a5cfcbc5cfa6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("673c2ad5-79ff-4de9-a57d-587d00981982"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("679f3032-de69-4009-8804-59cd65125c7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("67d45ebc-b7a8-47c2-b4c6-9e34206c4981"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7157e165-9976-4e6d-b704-ce2e17455d08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7320d6df-8599-48d8-aa7f-6223ddcc7e91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74730d37-1870-4d16-9922-37c3483bdbd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("775cbdc9-b4e3-4d72-bff7-296ac916f6b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("788e357e-3636-4e3a-875f-05ea3603283b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("79aee4ca-8adc-4a19-831a-f6bf75ec407e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7bb47433-4688-4240-a801-b83f3a079ee6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7bba2457-bbad-4366-84b5-a2f92c15e2ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7bd43200-8867-40dc-93be-90e1b3bdf6ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7be927c7-0725-438b-b925-61701a3d2a64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d01d6ff-89f6-4d7d-a468-844268fdeddf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7df11826-07c2-44da-82b3-06af190f619f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("81fa3406-56bd-4bcd-8659-db30438d6246"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8396318e-1ed9-4e01-8113-9ccc80b91878"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("85d808c0-18d3-4e69-9ec5-c447055d7346"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8894fd0e-7255-4326-9e58-16feb6cf9488"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("891bd037-beb3-4539-93de-7ec499f0eabe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8c0522fb-f45a-4763-a33f-32f9c3d480f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8cd722d4-9c81-4325-bfc1-29a37aa2abed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8f8e12c0-6223-4b2b-95e6-89ae29b3f063"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("937d83cb-c801-4e24-8854-bd8fd3031f50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("93cef053-e96c-4201-8c88-3a9479a80e65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("95bc60ab-2ece-477e-b91c-2ea565867349"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("95c2edb0-ff8d-43b5-b034-728be533e5c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("98a5d744-1cd4-465e-b7f6-45f0f27d1056"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9987db58-3b58-4295-b7a3-ea84149e8e7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9d0d3250-0cd7-45ee-8a7d-2ad3fdd444b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f9d67cf-867b-49ca-9041-08d04e8036a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a086d608-9e41-4b28-94ff-a245f727b1d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a2282839-cea7-4320-b767-e72f82846980"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("af75e8c2-61c6-47fe-bc55-3204acb9b40d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b73e6963-3a59-4266-9d4a-85f3da9b6ba3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b9842202-d485-4f0a-b645-b36f5153437f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd5021fe-a088-4775-a359-896a96c8047c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c6425a4e-98ef-43fd-9666-45ceaedec64d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c6d1a53b-dbbd-4bc7-98d5-f3b5b692c85b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c74b7346-3163-449e-90d0-d98c7aa50b9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7a8f421-714c-44fa-be2a-5528f13d770f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7b401d8-e182-4ebf-b10f-45dbf9e767e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ca8a328c-3f06-4638-8640-de53e58f7b07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ce622a34-9376-454f-8bf3-27d2864965ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cef9a540-e97c-4316-9457-13f1bae12e2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d1a31b88-233f-41e4-84fd-072419f7bd31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d6a8d981-f2ec-4918-9c56-ff35c5f7d010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d7454f5a-75b0-4ed4-8e00-509c3b7e33aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d9bb2daa-2cf8-45e2-bb57-a7e32c43a7bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("db4ebb00-7cb7-4783-9a0d-5c5379b8a37b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("deb261e7-4d9f-4259-b8a6-9b656a947efb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("df886c2d-f3dd-468b-af9b-64ddaea528cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e22506b9-e25f-43ab-8c29-904bd95b32a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e3c5e6d4-b9ca-472c-a002-013665a5e7b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e5fe14c7-2fa7-4e50-b703-cf671ad968ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e748eae6-4f3c-4465-8ff8-dd8901112856"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7919cb3-4a10-488e-9e05-5ae0f252a57d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e8d3c463-6e9a-45ca-aadf-ff000158d54f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eaf9730a-4b03-4282-8e7a-816f7540da0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eb2cc043-2265-41be-8f0c-b4d34d0bbd12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eef61ed1-5633-4f72-b223-66b9276f06cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f0f29705-2d45-43e4-bc4f-f7e8f4c4159e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f1a22f54-24f4-4ac4-8b58-1534f737ad98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("faa5e7b0-a9c0-482f-9d96-b2feeca32c04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fac4146a-ef81-4d63-9827-9a98338f1406"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ffd22c93-00f3-428e-b6af-be71b6d6f3b0"));

            migrationBuilder.DropColumn(
                name: "CarID",
                table: "Slots");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("61122d8e-dca9-4cc1-879a-5e6aeb643da0"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("7dc66cfd-c967-4ad0-927c-04cf2d522ef4"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("95f6d5f3-6f9d-4402-853b-55bab0714204"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("a9d818b3-9377-41c8-b11f-288a9e9f34d8"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("cdaf625f-053e-4ba6-be0b-7dc1d37163fe"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("ef7e67ae-4dbc-4494-9e0c-b92e32cef836"), "Xe 2 khoang", null, null, "Mini", 15000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("5ee0b1b8-ba75-4c41-b451-9449b3730ecb"), "1 Year", new DateTime(2023, 2, 28, 21, 9, 51, 855, DateTimeKind.Local).AddTicks(8759), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("888f183a-28ff-480b-aa4b-a0a6fec6fa5e"), "Half Year", new DateTime(2023, 2, 28, 21, 9, 51, 855, DateTimeKind.Local).AddTicks(8734), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b27ead9b-ece6-4e1f-9c83-3e246f63b6b6"), "Short time", new DateTime(2023, 2, 28, 21, 9, 51, 855, DateTimeKind.Local).AddTicks(8727), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("05bc5f49-4ae4-4225-a61c-d03de0b0bd11"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$32Z3ILqZKw/gv.p683DHz.dBor.DNkXSAsE2qH5r/hZKFKOMsAiHS", false, new DateTime(2023, 2, 28, 21, 9, 45, 19, DateTimeKind.Local).AddTicks(618), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("061477b2-5d7f-4876-ae6b-f0794cde5400"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$9dAoUL9StzbXul59/qDEdemx/WsesZ3dlo3VYqYq6Be5VTklZnqZS", false, new DateTime(2023, 2, 28, 21, 9, 48, 0, DateTimeKind.Local).AddTicks(4971), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("09b62c47-5ef7-4d96-a55a-d5f69ce50390"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$wHCOn04XYLVoa5MXzXxX6.JGZ/YKQ98Cj3y08cJ47/tBU2pQoMYbi", false, new DateTime(2023, 2, 28, 21, 9, 47, 933, DateTimeKind.Local).AddTicks(753), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("0c15b87b-37f6-4aff-8701-703f6539c79b"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$Et2SvNi4rye29Ap/lo.hfuyOxGkKw/op3ri3nmYxhkE0KOh83XPOa", false, new DateTime(2023, 2, 28, 21, 9, 46, 671, DateTimeKind.Local).AddTicks(757), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("10b8abee-92cc-4201-b88e-e9aa8fa21342"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$AuOCxBGJAZDNAP7QksJTyePJgC14zR74fbIqGgv54tO6Y8bIwt2kG", false, new DateTime(2023, 2, 28, 21, 9, 49, 396, DateTimeKind.Local).AddTicks(1927), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("136a7397-531b-4eb1-80a2-8003585a493c"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$xGtJX5RQz1XXZh20wh3YiejOZGkqEIbGALy1WIgbd5KxIkR5ngz2W", false, new DateTime(2023, 2, 28, 21, 9, 44, 57, DateTimeKind.Local).AddTicks(5279), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("15eae7d8-9f23-4b92-a291-ef0df47148f0"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$bGnqXiGrT1uqjLIhfxH65eo8m9Y5wtR3BVvfQp7N4l2ur9OlBD/aW", false, new DateTime(2023, 2, 28, 21, 9, 48, 139, DateTimeKind.Local).AddTicks(8368), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("17bdc8c8-88cc-4490-a648-b37594903689"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$vfWyuj16/KJCQPlujhzW8.VVHG9pw1VfBaXwhgG2ax/XQBJsMX1qK", false, new DateTime(2023, 2, 28, 21, 9, 45, 146, DateTimeKind.Local).AddTicks(9754), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("1cb32f05-7a75-46c4-9dc0-638fb6962986"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$1xMJ21O.AQE3rjU8v5BUHOKiypwE8Fq1a3hj3cpveVm5dc5u/V/hC", false, new DateTime(2023, 2, 28, 21, 9, 49, 124, DateTimeKind.Local).AddTicks(5346), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("1d4f941e-b643-4eb0-b485-06766ea0b5f8"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$arr4BfLJMQ6JITQ6OLFlveQFXKnUwdbHXXx3ipxwFjX/2iUXwkysm", false, new DateTime(2023, 2, 28, 21, 9, 44, 186, DateTimeKind.Local).AddTicks(9091), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("2301215e-1d70-4679-af64-962efe14fff0"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$NyakmQgqlwpjoGrHup94yOs9SbjRcChVL4TCno8/OpE74ZXdUTVKO", false, new DateTime(2023, 2, 28, 21, 9, 46, 539, DateTimeKind.Local).AddTicks(7617), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("262a1106-c5bb-4ab4-bc9f-20664379d802"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$HuGc5EVkAogWv4Fqoq1.w.cqMn7a.416FRbURBga/WqCw7WpJjL.O", false, new DateTime(2023, 2, 28, 21, 9, 47, 79, DateTimeKind.Local).AddTicks(9887), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("27de115b-43ab-4cea-827c-3ed78db81af1"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$K1wu7qFHZdCzj3RFwZb3Vu0uo69KvSQiySaUPMA3z7V32sgSzE81C", false, new DateTime(2023, 2, 28, 21, 9, 43, 993, DateTimeKind.Local).AddTicks(5022), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("29be69e6-5d73-4c3a-8180-7a321aebd00a"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$wdzGndahEXItNl3RP55mK.KC3KEB3XMVjtaomofgIbst3EsfZt7Bi", false, new DateTime(2023, 2, 28, 21, 9, 43, 415, DateTimeKind.Local).AddTicks(4640), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("2a2e52a9-316a-44f0-8e1c-f618a80cd232"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$.I2KvEPeFD79AAi8caHMruPmT1dUKrzwq8vddmSgvYjwoRSyeF.8W", false, new DateTime(2023, 2, 28, 21, 9, 42, 784, DateTimeKind.Local).AddTicks(5538), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("2b785660-3121-47b3-ba59-ff07b37b29d8"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$N1rQ7PIHxk1FI1fnP0kjjua2vlm0w.Fhy.fuIefZ/PGYQ3Mv1h0ea", false, new DateTime(2023, 2, 28, 21, 9, 50, 356, DateTimeKind.Local).AddTicks(1075), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("30b311cb-8508-4c86-a918-9ba4674bc2f3"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$bKCXtuO.wKuvbsTbIgMK7.OULAAJ3NF/M.4vK8fp0eSLPzmLGQJgS", false, new DateTime(2023, 2, 28, 21, 9, 48, 346, DateTimeKind.Local).AddTicks(9827), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("340913b3-a28d-4946-88db-a3e8d71d5794"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$LGwFE4bE8n9.KPwKY30LZ.17DjAzwJHYb6allQnL5B5cIjYM52JVy", false, new DateTime(2023, 2, 28, 21, 9, 51, 531, DateTimeKind.Local).AddTicks(5880), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("3b599809-a486-49af-856e-b160c6f3d214"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$MQPw2TMRgo81Gme67w0KwuRim.vdaZA8jRWIfECRZQiaz313gZ3lC", false, new DateTime(2023, 2, 28, 21, 9, 43, 928, DateTimeKind.Local).AddTicks(6519), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("3eec793b-019e-413a-93b5-fcef847fb67a"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$pUz2imKgtEUJahWLNtqqAuYRodlBoE6pPUfGiqjsFDslco0Z45U6e", false, new DateTime(2023, 2, 28, 21, 9, 46, 220, DateTimeKind.Local).AddTicks(4054), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("44015f4b-faa8-433f-bd08-7251ca959d23"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$Nl8E0gp.gAFMl5Aoz1MtFepg8TV4Xd1CxUjaq.CiiVtPd33NoFaAy", false, new DateTime(2023, 2, 28, 21, 9, 43, 351, DateTimeKind.Local).AddTicks(1943), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("45893e6f-1d31-48d6-9774-1ce172a88068"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$YN.27FLbeP63/2TkzEVYhevTYngETBPSsD838i40Ix4f4OC1cycp2", false, new DateTime(2023, 2, 28, 21, 9, 47, 559, DateTimeKind.Local).AddTicks(8791), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("45aaf2a0-bbc4-4279-a069-56678612d68a"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$j7sF50/fN/H/1WOxxJ4Ev.j2qwbIVLJT0wfHnmdFELGAaHRlCGKAC", false, new DateTime(2023, 2, 28, 21, 9, 43, 864, DateTimeKind.Local).AddTicks(1314), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("45d8aa42-225e-4344-bbea-12b7b91d7ca0"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$Tv4YsvHoQpncMmjXl6JjqeyobIPItk084S2Hmvc5Rprmy5yKSv4tW", false, new DateTime(2023, 2, 28, 21, 9, 48, 215, DateTimeKind.Local).AddTicks(2063), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("46e11e89-9f65-486d-98b5-0a4295762926"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$OWe6Gk9kGKLNzhqAv9cRvOIeYZaqEA85bXA0K.8q6SuRNJmFtEGzi", false, new DateTime(2023, 2, 28, 21, 9, 47, 145, DateTimeKind.Local).AddTicks(7509), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("4e49f0d9-dd84-4408-a2da-c810c71938cd"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$O8RZkYSko6ZYxd0JknF5d.kzhaqfTH1voq7AD9W2FBC.K/eJUy/Cu", false, new DateTime(2023, 2, 28, 21, 9, 50, 699, DateTimeKind.Local).AddTicks(6664), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("4fcc32f1-5193-4a8a-ba93-bad539b86b5e"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$zCzlk8/Ad2ioUs5OFnYx/e5pxWKmjEFjuG9Q0PKAv7drfVBUgDpBG", false, new DateTime(2023, 2, 28, 21, 9, 48, 887, DateTimeKind.Local).AddTicks(7929), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("51ac816b-1c11-402f-90a7-9f1b6eac975b"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$KBkEzuFiiMJQq9/x.VYqCuxuRN7pbrxNAzO8MMqj0sohlO6RLTUBS", false, new DateTime(2023, 2, 28, 21, 9, 51, 855, DateTimeKind.Local).AddTicks(7936), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("544f1d2c-132d-46e5-b337-7d946fc6899b"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$gtjGyB0K5Ze4TkGIfJJSOedc/sb877sueC1CRTfvJENzveYaF1Lye", false, new DateTime(2023, 2, 28, 21, 9, 48, 281, DateTimeKind.Local).AddTicks(7284), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("550fd933-1e69-4632-8a64-c1c05308c261"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$NjeqAr6A1ACdPXQmS3ySAeESMmMyHTSx22J7wuCkhSP2ElU6tW7X6", false, new DateTime(2023, 2, 28, 21, 9, 47, 410, DateTimeKind.Local).AddTicks(5951), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("58968f33-2794-4794-a45f-80b122bf9be7"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$4bdoOdYoZGhlh61Vp0bOre7Su87kZbQ0Q9rBnVSUgYntCIqYE4C/q", false, new DateTime(2023, 2, 28, 21, 9, 46, 93, DateTimeKind.Local).AddTicks(263), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("58c70154-d959-49de-8e5a-1571264caafb"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$O3q9XzxGPIFmVVgMFX.YzObUt.fD/ahuF1Xub8T1XXiVZjLTPtxVe", false, new DateTime(2023, 2, 28, 21, 9, 43, 607, DateTimeKind.Local).AddTicks(4146), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("5bb153e3-ec0f-47dd-bf54-8855d689f867"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$nOEZX4YLZ7oEiR0yhPOlZupgyS9oFQol9e095UzyseVKx.vEjK00S", false, new DateTime(2023, 2, 28, 21, 9, 49, 47, DateTimeKind.Local).AddTicks(9958), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("5c9995ee-cb61-4bec-ba8e-d10efd97a58e"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$hoTo/.IMOkaXyu4nT.ezkO4iXVmlxOWQXD61P.7II51bz9aSoOcTu", false, new DateTime(2023, 2, 28, 21, 9, 51, 695, DateTimeKind.Local).AddTicks(641), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("60dabc00-70ea-4c13-86e3-c833196f13be"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$5ZUmz4mAlUQz3WyrmDbx1ueJAW6yxUA5ME7AAygzrV82MkcIb4Kom", false, new DateTime(2023, 2, 28, 21, 9, 45, 83, DateTimeKind.Local).AddTicks(242), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("612d8a09-6c0a-4f61-a39c-f59e7309d577"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$MS7kp4k6necJPvJY6CZpKutttzz/bfnBtC1TMnmlzSHAehN6BLmi.", false, new DateTime(2023, 2, 28, 21, 9, 50, 198, DateTimeKind.Local).AddTicks(1234), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("66e0392d-3086-4dd9-bcae-df0de7a93fb4"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$W4230LA8kios3d9e2q18c.f8jRz0srnMFNdhxQRpUx5vnIKBk2U3u", false, new DateTime(2023, 2, 28, 21, 9, 45, 901, DateTimeKind.Local).AddTicks(8032), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("6715a9f0-fb9f-4970-ba7d-50c54c708f8f"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$P5pp/qNrxyMCKgZOGc3JXuAS/zYX9KGnpe6RwRoKTd1Jud7aSN4lC", false, new DateTime(2023, 2, 28, 21, 9, 44, 891, DateTimeKind.Local).AddTicks(1992), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("697f3dca-3f37-431f-8abf-f37f255b0d22"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$g/GLFBfg5wz5/Es1BMzchOIlBaOwt563ZkCVfpW2sDyYy9nrHWEmG", false, new DateTime(2023, 2, 28, 21, 9, 47, 709, DateTimeKind.Local).AddTicks(7710), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("6b3ba772-4542-40b9-87d4-b0a171303709"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$6xNFcSH.lcErfG2ha0B.uO43s2k73RMzGLhYrOGGWeps.wB10R4Py", false, new DateTime(2023, 2, 28, 21, 9, 43, 736, DateTimeKind.Local).AddTicks(3857), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("6b872160-e2b7-4fc6-97cd-de9a046af331"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$7ZxAcFsFkPp2OU2msK5EMOs9DhGa9mVZ9kXaQi.wsUq9j4h81kA5S", false, new DateTime(2023, 2, 28, 21, 9, 46, 28, DateTimeKind.Local).AddTicks(8080), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("6da0ec43-01f3-4f2c-8c35-06a278220752"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$fEY5KgzSX.Y78O67esZ2GOEYQe6QIpkQ/O5c2MsUn88lh2tY5aFri", false, new DateTime(2023, 2, 28, 21, 9, 44, 251, DateTimeKind.Local).AddTicks(640), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("6dfc7e8a-7f45-45c1-9480-a43d06f53943"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$W2YtYLub49OQZsXK21YLqOAh6XJPw3jPWYwlUTUHCebHFInmEgrDm", false, new DateTime(2023, 2, 28, 21, 9, 44, 762, DateTimeKind.Local).AddTicks(9255), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("6f28b930-d8b7-4cf2-a259-6957b8d6e213"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$d3kaPIN9.sjFQd16KCKgl..HU2OuIgojhzYiONMrQjFzDCEGASc5K", false, new DateTime(2023, 2, 28, 21, 9, 46, 605, DateTimeKind.Local).AddTicks(4488), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("6fc199a2-e9ae-4d52-8707-145f7110c15d"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$4MwgfQhZhHZIKr9vG3V67Op5b/bwWEYjH87hdVUHjV1GWILRbrXDa", false, new DateTime(2023, 2, 28, 21, 9, 44, 444, DateTimeKind.Local).AddTicks(2709), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("74d54a40-fd97-43d2-b51a-c89d0cb63794"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$y.0GwI9w.muKsT/YFpovwuGxrBtwMxl/eB.4opWu4yNJnZc6fHH4q", false, new DateTime(2023, 2, 28, 21, 9, 50, 866, DateTimeKind.Local).AddTicks(5007), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("77ad9c0c-5e22-4205-b5d0-2b3e53c32825"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$.mxkUkmMS98wjaxNXc8AmOql5Em2nHQznda/3Sm6NqgcVUXAlqWqO", false, new DateTime(2023, 2, 28, 21, 9, 45, 364, DateTimeKind.Local).AddTicks(4593), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("77cc5130-7f07-4605-95ec-4dd8b1ab4e39"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$GWfvmhAdHU/1kPGAXr1utOG4lBOHcRbU7V7PNaIKh4N3Hc9J2gqe6", false, new DateTime(2023, 2, 28, 21, 9, 49, 199, DateTimeKind.Local).AddTicks(8229), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("790bef4c-1f47-480d-9cce-cdec3c1c2155"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$hZ7bztnr1Cz7mQhAQGtdBuU0uI4d85Aufdf1qJlw5AJnNT28uBIpK", false, new DateTime(2023, 2, 28, 21, 9, 48, 650, DateTimeKind.Local).AddTicks(6361), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("7cfc1eeb-bafd-4526-85f6-fe1db1732ed2"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$edBxrjpHuOWWJEKrlKsIQ.zHdXo7otxPuylNjk7o3SNeoTg2IcTjO", false, new DateTime(2023, 2, 28, 21, 9, 44, 508, DateTimeKind.Local).AddTicks(1780), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("7d378a0f-1ce4-4383-99d1-be698717e4ec"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$Grcm1xuhxSuQ8SvbvHEXkew7SwMgYDSDGYRL1zQ7rNNTROvft/aOG", false, new DateTime(2023, 2, 28, 21, 9, 45, 775, DateTimeKind.Local).AddTicks(1708), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("7e035e10-7738-4de4-83e8-77439cfd02b0"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$sCRXsbVyHtkw02Tht5pVduDGXs5MLwlEQymFOMxs3/2Rwf6vQyV0q", false, new DateTime(2023, 2, 28, 21, 9, 46, 807, DateTimeKind.Local).AddTicks(2354), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("7e22697d-7339-4bb5-943b-cfa93eb3fdf5"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$wJ3l0c1vG30RE6Wz55wFt.JVa2qxKG41L13Im.T7q5ckkqDF.FkMi", false, new DateTime(2023, 2, 28, 21, 9, 43, 141, DateTimeKind.Local).AddTicks(5654), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("80213a22-634c-4490-8f74-e57981fcf0f2"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$FsGoxr7qUqMttJ5sxJ3YHe78ccq844XjUwA7oe0oH9LaV9bgbm8ja", false, new DateTime(2023, 2, 28, 21, 9, 44, 379, DateTimeKind.Local).AddTicks(6831), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("817bf479-67ec-4524-8078-7ffea8786c8e"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$mNcHGcS12qitiwRbXyvAwuaGEK.DEnL0stBOcPCpemTQv9FksApR.", false, new DateTime(2023, 2, 28, 21, 9, 49, 281, DateTimeKind.Local).AddTicks(4751), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("83fef9d4-a60d-4336-8489-4d2230176dca"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$yX3n5rdxvNysQcC/xddmhO/cNP4QXJijj5yUy55EsKcijyOR/cOI2", false, new DateTime(2023, 2, 28, 21, 9, 43, 284, DateTimeKind.Local).AddTicks(1284), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("8463c0b3-843f-473a-b4bc-07e9bcbb09fb"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$HFS7b793Mn68tsewSrrcvep7x5JbIkZQtk8VpXlJV7XHUW.PQ1xNS", false, new DateTime(2023, 2, 28, 21, 9, 49, 882, DateTimeKind.Local).AddTicks(2540), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("87ed0472-22f3-4063-bd58-519e721316f5"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$nI6mUf/q0IfNhw9jUGvrAOLiuk9T2ROtRViuvbdV0.8g1hKppWhHm", false, new DateTime(2023, 2, 28, 21, 9, 48, 567, DateTimeKind.Local).AddTicks(40), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("898a91db-5171-4e52-a2b3-330687a9f989"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$eHtRPLFTOFTU3uUwTEXHXuljut8SY51xJawxbtmuRjlyAvn5UBhJe", false, new DateTime(2023, 2, 28, 21, 9, 42, 915, DateTimeKind.Local).AddTicks(969), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("8eb6ebb2-d567-462e-87f1-4f6696714331"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$Lf4ZPS6TSrwQQymuCaFKBer9YWsqNKs8XN7OX0.Dz2egEmIbzOh7m", false, new DateTime(2023, 2, 28, 21, 9, 48, 66, DateTimeKind.Local).AddTicks(5766), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("8fd5ab93-f4c0-4c09-ab53-2dc78e14c1d1"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$.4zizS7s9xQT6C/3bWpiK.1VpcmvecuL.qDHN.HnevWeL7urEiso.", false, new DateTime(2023, 2, 28, 21, 9, 47, 636, DateTimeKind.Local).AddTicks(7031), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("96906031-db41-45e2-a1e5-76e8c6d4b927"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$asSXVILlXcDJHu8hck.I/.9gspBdtBxAQyd7fjiQuZlu9dyT/FZ86", false, new DateTime(2023, 2, 28, 21, 9, 44, 699, DateTimeKind.Local).AddTicks(301), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("9699ffa2-396c-47bd-9384-66af03871d63"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$Hz2nqCpK0v3J4sbTf/pNC.KZ1VcspLffvWNxCo2d0HNBaPt2Y5EP.", false, new DateTime(2023, 2, 28, 21, 9, 44, 955, DateTimeKind.Local).AddTicks(1683), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("96bd3b85-c791-41c9-afd5-1a5159b72c02"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$Dj299GN27MIOcUGVXQq3teL5LQL9ha4cIXOwJUYABWiJMaR/5/0Bi", false, new DateTime(2023, 2, 28, 21, 9, 46, 736, DateTimeKind.Local).AddTicks(6627), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("9a58b3a5-32e4-4805-8bf1-0a5bf2a0feec"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$.GjYo7bTbLFraFG9AvePre1km1wRawA3eCfk/n41qRRkvYE96jtC6", false, new DateTime(2023, 2, 28, 21, 9, 49, 720, DateTimeKind.Local).AddTicks(9187), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("9ad3c721-de6c-458e-9f7e-70a9c885e7fd"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$6FnbvdTYAZ0Ix26BUHb11eTuxHQvqRtarkbdDhOl71rcE5OWyuBma", false, new DateTime(2023, 2, 28, 21, 9, 48, 412, DateTimeKind.Local).AddTicks(2382), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("9b331241-ee7b-4d87-bf5d-f1bdd85a6be5"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$XDTNDIuj6hIhXhxAoqOYNuaRx3CPdvho5MTxixPGUN8U12PHWjiV.", false, new DateTime(2023, 2, 28, 21, 9, 45, 440, DateTimeKind.Local).AddTicks(7043), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("9d7b11c2-8778-4851-8eee-f66d03dff6ae"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$zo4fhXYiKg/7flKlwFGjpOGeTky1DwGnMqNyZwPFC0QM8Y3omP8cu", false, new DateTime(2023, 2, 28, 21, 9, 46, 283, DateTimeKind.Local).AddTicks(7084), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("a677fc54-df7a-4148-8147-09cbf688fe0f"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$g1sn/59gypL4kKT9QeDaHekce/zF6/J/uRyj1cYFXKCq22w77ljU2", false, new DateTime(2023, 2, 28, 21, 9, 49, 554, DateTimeKind.Local).AddTicks(2714), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("a7702e94-36c4-4fd7-9ee8-1f0b83874ac5"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$J1/jpHRiQFzg65E0BqS3N.nuY/iDLtJz0GyRg1r/aOlXitQr4uz7G", false, new DateTime(2023, 2, 28, 21, 9, 42, 851, DateTimeKind.Local).AddTicks(1455), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("ac35f249-4732-492c-92be-063835ab3216"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$uP8jswLPTOpd3tNTWzR95eDjneZmpUP5555OdkSCTYHDZKgfC42jy", false, new DateTime(2023, 2, 28, 21, 9, 45, 218, DateTimeKind.Local).AddTicks(1298), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("ac611287-e5c2-4b98-a339-73fa41785464"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$LmSDCq.R7PiV93wHWYeESOAm/1DquiQb0v4UuIC/v4OJbfwZR85xi", false, new DateTime(2023, 2, 28, 21, 9, 50, 536, DateTimeKind.Local).AddTicks(3549), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("ad32eb0a-eaca-421d-ac9a-58e3825f3368"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$pMj0jysaM2LcqIKNrS9YPOnFT6WwBfNy5qZdQDUpAVEGBMwh374ia", false, new DateTime(2023, 2, 28, 21, 9, 50, 40, DateTimeKind.Local).AddTicks(6596), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("adb16c1c-80f4-4b84-8bb0-e6bd33bfe1d4"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$JZJj9VJlvj6wjAfnhvJhZezLXW08H0Gjie1BHXyQC0DsniPqrGXZK", false, new DateTime(2023, 2, 28, 21, 9, 43, 672, DateTimeKind.Local).AddTicks(876), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("b506c1a0-0d8c-41b4-abdc-e66ca3d4101b"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$KQHZ8F6AU0uLofmQ4d9rZui7AvFLZrCG1kG.y6p04wfukSq1rKQdi", false, new DateTime(2023, 2, 28, 21, 9, 44, 315, DateTimeKind.Local).AddTicks(7982), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("b562979e-4dbd-49bc-baa9-abee365c92ee"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$pYA7CiMzHsO54quZ3UIRae1.PiGyC289SwIA8gHCNQox346qRwPwm", false, new DateTime(2023, 2, 28, 21, 9, 43, 214, DateTimeKind.Local).AddTicks(6261), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("b7d2917e-baec-4f92-8ea7-e694d31991b6"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$oWkbmAK8tplP7pdGgf95dOCCz2AZU40kVEcGtjoH6vBDF2wjxBttu", false, new DateTime(2023, 2, 28, 21, 9, 43, 543, DateTimeKind.Local).AddTicks(4439), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("b88850a7-a170-4df2-8016-2804e457e3f5"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$wdyw/0zc/qjiuRpjadAwLubUNHN46EQwc6jnD4Yd2EFt4pxiQe41K", false, new DateTime(2023, 2, 28, 21, 9, 45, 838, DateTimeKind.Local).AddTicks(6049), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("b9b90dc9-1663-4724-906a-194dcbeb1b81"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$NQPgxPGv2a4gdejB07Nhxer2WiPP0xWTg97RgthFX4.FozORlTO7S", false, new DateTime(2023, 2, 28, 21, 9, 48, 963, DateTimeKind.Local).AddTicks(6071), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("ba61e45b-77fa-4c8b-b5cc-0e8eef53c6d9"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$srQRhpI5nA/o3bnjhQucJ.pfbdNGuRL0cuqcvcz2LqZsTrYsOl9Qy", false, new DateTime(2023, 2, 28, 21, 9, 44, 571, DateTimeKind.Local).AddTicks(4717), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("ba815702-4f70-442b-9444-3416bb53834c"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$p2q72gV8sYSrGMoFXBeRfOG/PzM4dbcQ3DnaVtBB21AWaFy0TchdG", false, new DateTime(2023, 2, 28, 21, 9, 44, 122, DateTimeKind.Local).AddTicks(8130), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("bb9a77a7-e7fa-442d-9e78-7bb0fb04654b"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$veBTEy4H96y.hYqpXpIKhupJslgFOozIs0hNf3ncw83fxO3xyoPkK", false, new DateTime(2023, 2, 28, 21, 9, 44, 827, DateTimeKind.Local).AddTicks(5759), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("bcb64af4-c3ab-4118-8c32-6e3a64b78bbc"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$G8c.rGvmpKmnpEJSBE0nzeC2ktPeRL9e.eAEkR95MbWNN8n.ISsjK", false, new DateTime(2023, 2, 28, 21, 9, 42, 981, DateTimeKind.Local).AddTicks(9735), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("c3f8da6e-035c-48ef-a0c0-bf7df1b9d433"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$hvQXqjtt49soNuEgNt6mYO4IXbiKulx7LFUBH66xj1BgbQ4MJkVXi", false, new DateTime(2023, 2, 28, 21, 9, 45, 711, DateTimeKind.Local).AddTicks(14), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("c66b8703-add4-46f3-af57-3ff14144ab7c"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$ktwgL6i.g7L05.bznys0keszon5YiDoFUnMu34zbCHBq4qoXM34YG", false, new DateTime(2023, 2, 28, 21, 9, 47, 211, DateTimeKind.Local).AddTicks(77), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("c6f7e531-0b21-41a5-b722-26c64f4a596a"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$KmOlPMseh2rGJ/POf.LMeeXeo9BWmPTm01c.fvEbJsEwUP1cHvIku", false, new DateTime(2023, 2, 28, 21, 9, 43, 479, DateTimeKind.Local).AddTicks(3689), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("c7b98503-befe-4b98-ae68-b1f8d8172fb9"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$6qgHhdM0R/ojEzTPW7L4K.a5ZK6BrLILFaTuvz0AdELgMU.wu8q.2", false, new DateTime(2023, 2, 28, 21, 9, 43, 49, DateTimeKind.Local).AddTicks(5712), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("cbeedee7-0447-4f5b-a4d3-ec30adc083cf"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$.XvagYuklum011S6kswuMeCoDFArgR4xio/mfYg977hFr8h0Sjx3.", false, new DateTime(2023, 2, 28, 21, 9, 46, 411, DateTimeKind.Local).AddTicks(4967), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("cc8394dc-2ac4-4c85-ba30-fd7fa0bd7ac1"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$rV/tLldkK1dNAZZcj1CEfukA6O6DwiexjGNLSXNXxI9EleuncSjzi", false, new DateTime(2023, 2, 28, 21, 9, 46, 949, DateTimeKind.Local).AddTicks(3171), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("d477b1e7-d4c7-4f99-a940-4cf4a985df77"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$4yk9bH2TjGs4h/IasbwJ9OULez21C9kTzaP3sHaNAgKfPzeVx16Hu", false, new DateTime(2023, 2, 28, 21, 9, 48, 809, DateTimeKind.Local).AddTicks(7827), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("d807afdf-063f-4a88-b649-4eb4a37f16b3"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$x74fY7SwP.1eXVOB9SMAUeBioXzaGOxGIE68TciKaA3NvGgHQwd6a", false, new DateTime(2023, 2, 28, 21, 9, 47, 14, DateTimeKind.Local).AddTicks(4212), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("dbc78ba7-fd39-47c5-976c-f219fab809b3"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$k8auwjRa5uAWAyl2RsIsTOotBcO2JOiNQw576NBSzmKivjZGWVzTW", false, new DateTime(2023, 2, 28, 21, 9, 47, 344, DateTimeKind.Local).AddTicks(2805), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("dc10fb81-acb8-42ed-bae4-baa10b3dd5c4"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$c6ytVW5Jw1IffFqTbUPeNOAWqV8UiCZK2PEvkLrAw/x0hKQMdmmqi", false, new DateTime(2023, 2, 28, 21, 9, 46, 879, DateTimeKind.Local).AddTicks(6307), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("dd5d4e2c-315e-4f0d-9f53-00e3a9f7334e"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$KsVWGVB.wDgjsGlYZJ22rOu/vqXKwcI6rEurf6wyUYc/uulpkAOWm", false, new DateTime(2023, 2, 28, 21, 9, 48, 730, DateTimeKind.Local).AddTicks(6638), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("e0215b32-c96d-4b58-88fb-e1f97aa9b2df"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$Lvp0uij6e80BZdSYI0GoCuwzwh8I5hPRrhuSeQU7YNckotd7d7Wya", false, new DateTime(2023, 2, 28, 21, 9, 46, 476, DateTimeKind.Local).AddTicks(2773), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("e3a03b88-8393-4c37-9d30-282766a8515e"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$Gwe7m7vzzIqSDk686vqBiOjhZIrd7QmN/LWms2BSD7l9n0y.DWDRy", false, new DateTime(2023, 2, 28, 21, 9, 46, 347, DateTimeKind.Local).AddTicks(9466), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("e5f8890d-78eb-4117-824c-007dea7fe82c"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$T9J59gPELSqihBU.Xwb6UumvWX5Mv.7x61I94h2iPYyLnBTKLP5Dm", false, new DateTime(2023, 2, 28, 21, 9, 48, 481, DateTimeKind.Local).AddTicks(8395), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("e6648764-714b-4263-8707-08c2bcf04a10"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$WX57teXoibvHPfI7Yj7u2eZGMRKqPyTrlf3wZdWKzjo26yLVQSh3K", false, new DateTime(2023, 2, 28, 21, 9, 44, 635, DateTimeKind.Local).AddTicks(248), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("e6c34e39-56af-477d-92c9-9c45e504dd49"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$zZQgC29VL6HNuMPcdmByBeaV6kVSluScZ78izieq.pFyP0hlemFIa", false, new DateTime(2023, 2, 28, 21, 9, 47, 861, DateTimeKind.Local).AddTicks(2106), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("e734cb0f-f5ea-499b-8c98-def7376868cf"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$M5./QF0CeFZ0mbwsZQ4BWuetGMigy75bfmCaG4GCFli4.1XvexN7C", false, new DateTime(2023, 2, 28, 21, 9, 51, 362, DateTimeKind.Local).AddTicks(3292), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("e7b3bb49-d853-4eb9-affe-467680316203"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$kUbwUZ.Rqm5GV7LD6McwteyYlHp6jItk3FRdkGE1fIn2HCKYjjqDC", false, new DateTime(2023, 2, 28, 21, 9, 45, 965, DateTimeKind.Local).AddTicks(5699), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("e89a372a-1fa1-43b7-a605-1cccdf37ff94"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$JfsYsBTACxhJTuPYrYtWjOu0MrGzBSeFyufPHSw2OTjA4lc89Lu4m", false, new DateTime(2023, 2, 28, 21, 9, 47, 483, DateTimeKind.Local).AddTicks(8303), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("eaff0e67-dbd0-4932-b4ee-a0e2ee066eef"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$lkcdfYUsY8aJdw3VGgjmkumEIkLciJX5Wm9J.1cYR4meIwta5U4K6", false, new DateTime(2023, 2, 28, 21, 9, 51, 196, DateTimeKind.Local).AddTicks(2854), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("eca9e0d6-d429-44cf-9e6c-d1a0d3f0dd0f"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$259kFgXXFaaY1vxhHvtSB.mLCKa1LUsbdrQL64a7STmZO8YxbxEF.", false, new DateTime(2023, 2, 28, 21, 9, 51, 26, DateTimeKind.Local).AddTicks(8832), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("eed94b09-a0b8-43da-a12a-829eea4acf9e"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$iRHQPPLTxbeG9hqkqgxf9eEIiMnJK2TfGXKsBI9SZOMi5RtQl85ta", false, new DateTime(2023, 2, 28, 21, 9, 43, 800, DateTimeKind.Local).AddTicks(1955), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("f0f99cf2-cdf0-42c6-86b4-7288d6fb440d"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$/ApWCIYrGcZ9pRALBQ6QoOO24vDMLRFKbXJb1OLxtTcE.wDvM3tJ6", false, new DateTime(2023, 2, 28, 21, 9, 45, 645, DateTimeKind.Local).AddTicks(5459), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("f2107ec1-bb2e-4957-be99-3a2d1289be48"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$m5YoBlBde.8paUB5rsYLG.xuMzTWfXobY/d4YFDmZLkdSMd3Ui21K", false, new DateTime(2023, 2, 28, 21, 9, 45, 513, DateTimeKind.Local).AddTicks(7436), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("f412005d-5ff0-45a2-9a8a-a104478d4108"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$7fcnZYfmubQsOH9iHoeMZO6.FHjFhVq2Gvy.MHjnZ7YD.AiNjh3cm", false, new DateTime(2023, 2, 28, 21, 9, 46, 156, DateTimeKind.Local).AddTicks(5051), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("f423a539-c476-4bf8-9f7e-79ec38c6b73f"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$CS0sLDTBRRcjnge6XaT86.bXx56egwUhqgCjFQz9eKr2aSahM8fC6", false, new DateTime(2023, 2, 28, 21, 9, 47, 784, DateTimeKind.Local).AddTicks(4190), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("f554efcf-fdc5-464c-8e30-c2f9c86862b1"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$TRYqhy8IzwhHGFyLg2trs.JsJyT9eIFnaStxlWzGyrwWfKNvDiSNq", false, new DateTime(2023, 2, 28, 21, 9, 45, 287, DateTimeKind.Local).AddTicks(614), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("fab25cf6-b40f-4e05-ad47-07da1f170801"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$/bYk5iTazY5x6/nALKaMle92F1hjS8Bu15mcbKKdDU0gThpBmY2Nq", false, new DateTime(2023, 2, 28, 21, 9, 47, 277, DateTimeKind.Local).AddTicks(4220), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("ff285e4d-5136-4b46-822a-b5ec6a0ce875"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$fnkwAzN/LPOE5S8h3zkSeOkHNvmPya9WO/sxG1F3UKmHj6TmfOMha", false, new DateTime(2023, 2, 28, 21, 9, 45, 578, DateTimeKind.Local).AddTicks(476), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("61122d8e-dca9-4cc1-879a-5e6aeb643da0"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("7dc66cfd-c967-4ad0-927c-04cf2d522ef4"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("95f6d5f3-6f9d-4402-853b-55bab0714204"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("a9d818b3-9377-41c8-b11f-288a9e9f34d8"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("cdaf625f-053e-4ba6-be0b-7dc1d37163fe"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("ef7e67ae-4dbc-4494-9e0c-b92e32cef836"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("5ee0b1b8-ba75-4c41-b451-9449b3730ecb"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("888f183a-28ff-480b-aa4b-a0a6fec6fa5e"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("b27ead9b-ece6-4e1f-9c83-3e246f63b6b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05bc5f49-4ae4-4225-a61c-d03de0b0bd11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("061477b2-5d7f-4876-ae6b-f0794cde5400"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("09b62c47-5ef7-4d96-a55a-d5f69ce50390"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0c15b87b-37f6-4aff-8701-703f6539c79b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("10b8abee-92cc-4201-b88e-e9aa8fa21342"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("136a7397-531b-4eb1-80a2-8003585a493c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("15eae7d8-9f23-4b92-a291-ef0df47148f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17bdc8c8-88cc-4490-a648-b37594903689"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1cb32f05-7a75-46c4-9dc0-638fb6962986"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1d4f941e-b643-4eb0-b485-06766ea0b5f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2301215e-1d70-4679-af64-962efe14fff0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("262a1106-c5bb-4ab4-bc9f-20664379d802"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("27de115b-43ab-4cea-827c-3ed78db81af1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("29be69e6-5d73-4c3a-8180-7a321aebd00a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2a2e52a9-316a-44f0-8e1c-f618a80cd232"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2b785660-3121-47b3-ba59-ff07b37b29d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("30b311cb-8508-4c86-a918-9ba4674bc2f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("340913b3-a28d-4946-88db-a3e8d71d5794"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3b599809-a486-49af-856e-b160c6f3d214"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3eec793b-019e-413a-93b5-fcef847fb67a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("44015f4b-faa8-433f-bd08-7251ca959d23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("45893e6f-1d31-48d6-9774-1ce172a88068"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("45aaf2a0-bbc4-4279-a069-56678612d68a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("45d8aa42-225e-4344-bbea-12b7b91d7ca0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("46e11e89-9f65-486d-98b5-0a4295762926"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4e49f0d9-dd84-4408-a2da-c810c71938cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4fcc32f1-5193-4a8a-ba93-bad539b86b5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("51ac816b-1c11-402f-90a7-9f1b6eac975b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("544f1d2c-132d-46e5-b337-7d946fc6899b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("550fd933-1e69-4632-8a64-c1c05308c261"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("58968f33-2794-4794-a45f-80b122bf9be7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("58c70154-d959-49de-8e5a-1571264caafb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5bb153e3-ec0f-47dd-bf54-8855d689f867"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5c9995ee-cb61-4bec-ba8e-d10efd97a58e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("60dabc00-70ea-4c13-86e3-c833196f13be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("612d8a09-6c0a-4f61-a39c-f59e7309d577"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("66e0392d-3086-4dd9-bcae-df0de7a93fb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6715a9f0-fb9f-4970-ba7d-50c54c708f8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("697f3dca-3f37-431f-8abf-f37f255b0d22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6b3ba772-4542-40b9-87d4-b0a171303709"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6b872160-e2b7-4fc6-97cd-de9a046af331"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6da0ec43-01f3-4f2c-8c35-06a278220752"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6dfc7e8a-7f45-45c1-9480-a43d06f53943"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f28b930-d8b7-4cf2-a259-6957b8d6e213"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6fc199a2-e9ae-4d52-8707-145f7110c15d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74d54a40-fd97-43d2-b51a-c89d0cb63794"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("77ad9c0c-5e22-4205-b5d0-2b3e53c32825"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("77cc5130-7f07-4605-95ec-4dd8b1ab4e39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("790bef4c-1f47-480d-9cce-cdec3c1c2155"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7cfc1eeb-bafd-4526-85f6-fe1db1732ed2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d378a0f-1ce4-4383-99d1-be698717e4ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7e035e10-7738-4de4-83e8-77439cfd02b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7e22697d-7339-4bb5-943b-cfa93eb3fdf5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("80213a22-634c-4490-8f74-e57981fcf0f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("817bf479-67ec-4524-8078-7ffea8786c8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83fef9d4-a60d-4336-8489-4d2230176dca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8463c0b3-843f-473a-b4bc-07e9bcbb09fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("87ed0472-22f3-4063-bd58-519e721316f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("898a91db-5171-4e52-a2b3-330687a9f989"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8eb6ebb2-d567-462e-87f1-4f6696714331"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8fd5ab93-f4c0-4c09-ab53-2dc78e14c1d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("96906031-db41-45e2-a1e5-76e8c6d4b927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9699ffa2-396c-47bd-9384-66af03871d63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("96bd3b85-c791-41c9-afd5-1a5159b72c02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9a58b3a5-32e4-4805-8bf1-0a5bf2a0feec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9ad3c721-de6c-458e-9f7e-70a9c885e7fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9b331241-ee7b-4d87-bf5d-f1bdd85a6be5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9d7b11c2-8778-4851-8eee-f66d03dff6ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a677fc54-df7a-4148-8147-09cbf688fe0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a7702e94-36c4-4fd7-9ee8-1f0b83874ac5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ac35f249-4732-492c-92be-063835ab3216"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ac611287-e5c2-4b98-a339-73fa41785464"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ad32eb0a-eaca-421d-ac9a-58e3825f3368"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("adb16c1c-80f4-4b84-8bb0-e6bd33bfe1d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b506c1a0-0d8c-41b4-abdc-e66ca3d4101b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b562979e-4dbd-49bc-baa9-abee365c92ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b7d2917e-baec-4f92-8ea7-e694d31991b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b88850a7-a170-4df2-8016-2804e457e3f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b9b90dc9-1663-4724-906a-194dcbeb1b81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba61e45b-77fa-4c8b-b5cc-0e8eef53c6d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba815702-4f70-442b-9444-3416bb53834c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bb9a77a7-e7fa-442d-9e78-7bb0fb04654b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bcb64af4-c3ab-4118-8c32-6e3a64b78bbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c3f8da6e-035c-48ef-a0c0-bf7df1b9d433"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c66b8703-add4-46f3-af57-3ff14144ab7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c6f7e531-0b21-41a5-b722-26c64f4a596a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7b98503-befe-4b98-ae68-b1f8d8172fb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cbeedee7-0447-4f5b-a4d3-ec30adc083cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cc8394dc-2ac4-4c85-ba30-fd7fa0bd7ac1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d477b1e7-d4c7-4f99-a940-4cf4a985df77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d807afdf-063f-4a88-b649-4eb4a37f16b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dbc78ba7-fd39-47c5-976c-f219fab809b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dc10fb81-acb8-42ed-bae4-baa10b3dd5c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dd5d4e2c-315e-4f0d-9f53-00e3a9f7334e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e0215b32-c96d-4b58-88fb-e1f97aa9b2df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e3a03b88-8393-4c37-9d30-282766a8515e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e5f8890d-78eb-4117-824c-007dea7fe82c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e6648764-714b-4263-8707-08c2bcf04a10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e6c34e39-56af-477d-92c9-9c45e504dd49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e734cb0f-f5ea-499b-8c98-def7376868cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7b3bb49-d853-4eb9-affe-467680316203"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e89a372a-1fa1-43b7-a605-1cccdf37ff94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eaff0e67-dbd0-4932-b4ee-a0e2ee066eef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eca9e0d6-d429-44cf-9e6c-d1a0d3f0dd0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eed94b09-a0b8-43da-a12a-829eea4acf9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f0f99cf2-cdf0-42c6-86b4-7288d6fb440d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f2107ec1-bb2e-4957-be99-3a2d1289be48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f412005d-5ff0-45a2-9a8a-a104478d4108"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f423a539-c476-4bf8-9f7e-79ec38c6b73f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f554efcf-fdc5-464c-8e30-c2f9c86862b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fab25cf6-b40f-4e05-ad47-07da1f170801"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ff285e4d-5136-4b46-822a-b5ec6a0ce875"));

            migrationBuilder.AddColumn<Guid>(
                name: "CarID",
                table: "Slots",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("037764c0-486c-4c07-aecc-31a6d244ead7"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("0897514a-f884-4aa9-a109-ab22c6deb9c8"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("27819c23-e949-4347-be88-012e7ae06bb2"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("5030cdd6-f2ae-47d3-bc2f-0e6a0f1f34f9"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("5cc877e4-858a-44aa-9777-969af598697e"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("720b9484-a933-46c2-8d1f-557bcd7fcd07"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("2675d2d8-aa1c-4739-a3af-a12822eec77d"), "Short time", new DateTime(2023, 2, 28, 21, 2, 2, 647, DateTimeKind.Local).AddTicks(4328), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e256b2b-acc2-4e14-bfb5-ac5082c0707c"), "Half Year", new DateTime(2023, 2, 28, 21, 2, 2, 647, DateTimeKind.Local).AddTicks(4332), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e31b4c75-a76e-4923-bcff-0c36c564f091"), "1 Year", new DateTime(2023, 2, 28, 21, 2, 2, 647, DateTimeKind.Local).AddTicks(4334), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01248517-025d-4573-b18c-7459177d2127"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$zEnQCpBoJQEPLpiwLOoa.uQE6GObUCq/c8R8IyPDoj5Vg6/lzkJhG", false, new DateTime(2023, 2, 28, 21, 2, 2, 647, DateTimeKind.Local).AddTicks(3641), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("01ab5afb-ebcc-44f8-9a06-4724f8aba83d"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$XMFZpMKJggib/720H15O5ex9EKTCkaocvcLB6USqTjw87/voJi60G", false, new DateTime(2023, 2, 28, 21, 1, 52, 700, DateTimeKind.Local).AddTicks(4257), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("031a736a-7f7f-4f5d-949b-bfd6ed88d953"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$MOMDkmbQDGzq/DOpLbrxwu8zSHuAZOCdVcf5SPmyKa2pnAfbsvp16", false, new DateTime(2023, 2, 28, 21, 1, 56, 898, DateTimeKind.Local).AddTicks(2520), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("0417cdb2-605d-43ae-a2db-911a098f439a"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$ObUgfAXhEl.noQ3wcazI4.ti3P24A8ZPpuI1/9iGd9f7nj5gFtutq", false, new DateTime(2023, 2, 28, 21, 1, 53, 774, DateTimeKind.Local).AddTicks(5231), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("04671dfe-10fd-446b-9207-110df183277f"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$XrQDJI2Zy3zVd6AMsljSBedD7eQRQKcT0lX/YNnkNodXZw5hemOPe", false, new DateTime(2023, 2, 28, 21, 1, 54, 743, DateTimeKind.Local).AddTicks(2807), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("04fb341b-4aee-4ac9-964b-7f5694eabbe0"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$HabWysBNaH5wpHXswHTTwueCHjz2B3KujGpmVatTbigeMgr4Ki./e", false, new DateTime(2023, 2, 28, 21, 1, 58, 428, DateTimeKind.Local).AddTicks(2924), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("0664da20-2011-4d1b-8516-085b950ce73d"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$ix4dPwfoWT1L.3sYkrrvxOlUDkbIY4S799DQapMo8omFGmbfuHk9K", false, new DateTime(2023, 2, 28, 21, 2, 1, 228, DateTimeKind.Local).AddTicks(1693), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("092694d7-59b2-401c-834a-65a2366e43d8"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$UqfuhdRj/rbYNfRWGOx.ROnQzjJ/8/iXRJbMgHqZLHCzppet73Oxm", false, new DateTime(2023, 2, 28, 21, 2, 1, 552, DateTimeKind.Local).AddTicks(9044), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("0baf34ce-fef4-4a1f-a392-a660a7fbefb6"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$q45LbPRKOYngK5wZwOKAbeqsBuZ/xONHrCG2a4O2Aj8D/5/1WZnGy", false, new DateTime(2023, 2, 28, 21, 1, 55, 696, DateTimeKind.Local).AddTicks(7127), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("10395355-afe0-4b9b-9705-0ec78e445f8d"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$pPhhRuhNlVP4m92q1CjtH.XrVyuebV5SHG0p0UZt5PlabmhRZZZaW", false, new DateTime(2023, 2, 28, 21, 2, 1, 120, DateTimeKind.Local).AddTicks(2174), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("11dde897-880b-4749-adc4-6fae4ca311bf"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$2SYPvncBkL/szOlUTVG.2eMF3QesFyqgmsxQD3vqlHe/3wI807fO2", false, new DateTime(2023, 2, 28, 21, 1, 54, 829, DateTimeKind.Local).AddTicks(30), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("126b5f10-60d4-4ff1-8251-9bbe54eed797"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$C8QyL./Zj3XxG8.IdFHrWOMUM9BoxcSAZRESYAuzyPLvwH3sxbiOG", false, new DateTime(2023, 2, 28, 21, 2, 2, 544, DateTimeKind.Local).AddTicks(5375), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("1291467e-ecf4-4a4a-9b0f-c2d289076d76"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$w.aaitSOKtm3s1OjAaesOuUcQhvfROmwlvgF2Z3cPSdGRt8t2zil.", false, new DateTime(2023, 2, 28, 21, 1, 57, 538, DateTimeKind.Local).AddTicks(6927), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("159cf391-6a35-423a-91e2-89254d8bab70"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$Z.fOFKNXIPG7KwCyJoo8yeILqkRagUynuzVV7ZDcbp8rZnEtOH2ji", false, new DateTime(2023, 2, 28, 21, 1, 58, 522, DateTimeKind.Local).AddTicks(7854), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("18e7f3f9-82be-4e60-8ebe-09486e3c7695"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$6O7hqtNcAV6JKUQHRpq1y.0e4TCQpbCllecP3bgrQYYJVP2LKKb7q", false, new DateTime(2023, 2, 28, 21, 1, 57, 329, DateTimeKind.Local).AddTicks(195), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("1c366f3a-e3c1-4f03-8bef-3f986c98f4ad"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$jLkqqqN3Q7wR1nNwefxNweUqr.3h73mSze3PI5oOoxNkeXHIiNQ0q", false, new DateTime(2023, 2, 28, 21, 1, 51, 919, DateTimeKind.Local).AddTicks(4925), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("1dd8ca62-990b-45e2-b76f-38e86601f3e0"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$SNDafRh80TOQt6oGFYOnjuBs992vg8fngA73332A855/IHNgAKXzG", false, new DateTime(2023, 2, 28, 21, 1, 53, 469, DateTimeKind.Local).AddTicks(926), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("1de4bed8-380c-48de-81c7-ed55c00c71df"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$uqzBriva5hll51lfhVP7J.V94OlcqKjrjy8ajFQEtH6JR.J9Uv8r6", false, new DateTime(2023, 2, 28, 21, 1, 54, 911, DateTimeKind.Local).AddTicks(644), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("240ae2a7-55c3-43ea-9a44-93a085056d21"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$a.on7LRQ70Lj51P7.0Twhu8uoU97x01qSZoqOLO9aVuKBnOHt9mCO", false, new DateTime(2023, 2, 28, 21, 1, 55, 78, DateTimeKind.Local).AddTicks(9882), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("25605ac4-e411-46f5-8301-8cad38b79618"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$9HPf.cZKs38XIh/41lzZ7eBpvYcflQMthtktC/xcBhh.6a3qCtqka", false, new DateTime(2023, 2, 28, 21, 1, 51, 286, DateTimeKind.Local).AddTicks(9965), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("2749a28c-559c-46ed-a9c4-ba37cd1857e0"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$RlRSWNW5n9TMhwZ0Bt.1xeYGg2teUavuvfPvuwbWDNLRPvUAd1gDe", false, new DateTime(2023, 2, 28, 21, 1, 52, 239, DateTimeKind.Local).AddTicks(3981), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("289869e1-f613-4627-b83d-de5a33ae61ff"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$Rxt45WT0RhtlN6TqQRYGyuVK9noCZFn60kbSCvh832Mr1i1T9oagu", false, new DateTime(2023, 2, 28, 21, 2, 0, 77, DateTimeKind.Local).AddTicks(6159), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("2e9fa4a2-bb5f-4a83-a72f-6870ca9a1576"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$k4lBHTOnVOwqtpjbXw6VhODwGMVYmhwy.3yzeoDHTbiG3kqT9nzaK", false, new DateTime(2023, 2, 28, 21, 1, 53, 388, DateTimeKind.Local).AddTicks(9579), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("354833ca-5a66-45b7-90ea-f2d081f03b12"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$w0Z6P8FSLn.ripq1zRreWuzih1nmDr6h8Zdwh5bKus1ILonnaeMTW", false, new DateTime(2023, 2, 28, 21, 1, 54, 442, DateTimeKind.Local).AddTicks(3457), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("36d5de9d-5d9a-413f-928c-612c2f113b3b"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$VGa3H6DFk5IbUwcwv0grV.jlmz/J28qglIySnlmzxv0ZlTSjPOh1C", false, new DateTime(2023, 2, 28, 21, 1, 51, 128, DateTimeKind.Local).AddTicks(2853), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("3912de42-bd93-4753-8fdb-b5e848b423ab"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$pwhC/AUEdUhzmXY8QxW7Gu22AZySvu/yLSDiqSa3EzXjX6.aRMsVW", false, new DateTime(2023, 2, 28, 21, 1, 57, 439, DateTimeKind.Local).AddTicks(9861), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("3c4a7e9c-6839-4bc1-953e-e3c41d5bb44c"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$XD5yfLd9cJDd7PgRgGMT6ebizXzPXtYpimmnip.tEAEydH4xKQmZO", false, new DateTime(2023, 2, 28, 21, 2, 1, 684, DateTimeKind.Local).AddTicks(2201), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("3d2cc589-5382-4b7f-8118-ad2432124c8b"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$ptP0Ipo6wEkMh8Gawv3Eq.1ek9pC6u3qx.faVuroJElWweHddSOeu", false, new DateTime(2023, 2, 28, 21, 1, 57, 774, DateTimeKind.Local).AddTicks(217), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("3dbc224a-f0f1-4700-8b11-ffbe0a7ddbd0"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$tIAId9emL7JK1CAaGIrXZuKUHQFrZm7IgAiOHf.MqhTuC35kKc8Ye", false, new DateTime(2023, 2, 28, 21, 2, 0, 654, DateTimeKind.Local).AddTicks(8561), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("3e3ac7d0-682a-4e82-b6f5-5d18001868f3"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$7LlnrKMmSrBo.YFiX/Ma3ewmTvPYixQtFuBom/CQx7zwXNs.6RnX2", false, new DateTime(2023, 2, 28, 21, 1, 57, 697, DateTimeKind.Local).AddTicks(4866), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("3f4e7467-1a68-440e-800d-e3442ea897a9"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$myho/SpawEsdwPiHn00E6e3qxulYgfuZJTdqS5V672N13YNTMY3Yq", false, new DateTime(2023, 2, 28, 21, 1, 53, 68, DateTimeKind.Local).AddTicks(7987), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("452fa997-932b-4a46-afb5-f49df9c923c0"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$5OVXJ3twvXBN6an011x0J.aRFiCd8soydkRDyEus8T3L2Wl3ttnCy", false, new DateTime(2023, 2, 28, 21, 1, 56, 623, DateTimeKind.Local).AddTicks(5002), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("47bf75e6-21a8-4eb8-93f0-d39d71953a34"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$7Gmop7pBcvlda78.xZmS8..wNT4KNMQoFaWmEVpDZT9i//5dLaXW.", false, new DateTime(2023, 2, 28, 21, 1, 59, 623, DateTimeKind.Local).AddTicks(4220), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("4978e7a2-b5f5-451e-848e-bbfc172a9f9f"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$paaciRBh4jPn01VjZlH0geQ/FS9eq1dx6eCo77i50YKF7sgzmeL1e", false, new DateTime(2023, 2, 28, 21, 1, 52, 891, DateTimeKind.Local).AddTicks(9673), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("498f4071-1bf1-4db4-9428-cbef0cfe668e"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$gNzqRBH/2jnAQX7GU7mzG.LU4gnRazztrrmM2x9tKj2hsjg9E5WDu", false, new DateTime(2023, 2, 28, 21, 1, 59, 383, DateTimeKind.Local).AddTicks(3344), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("4a6d5d51-2d86-4395-9f66-04d917087de1"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$SE4FTUGNz/89BWgISI.uNeepyAaIZ4I5QImHr7RlwQ8Cit6zwPAs.", false, new DateTime(2023, 2, 28, 21, 1, 58, 242, DateTimeKind.Local).AddTicks(5518), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("4b7a5e3d-655a-48b1-a070-1e83be7414fd"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$2sO0XKq6bsyblbhcGQLd3OfJ5fqpNV/CZUoH3gBDYxM3s9qjXuQPe", false, new DateTime(2023, 2, 28, 21, 1, 53, 291, DateTimeKind.Local).AddTicks(557), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("50115667-8769-4f2a-8cd4-698263bf6528"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$B70LRiI9uSjw4JMP1d0SJ.R3bc3mpxKseVhmxRZtqp24WhhtizKwy", false, new DateTime(2023, 2, 28, 21, 1, 54, 990, DateTimeKind.Local).AddTicks(1705), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("502451ee-5ebc-4c2b-947d-59b90719b594"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$AuvR1hakDzbUwO0tKTG3HuDeQ11Ma7ksVms4elWQFW9H8FFbQ/Yne", false, new DateTime(2023, 2, 28, 21, 1, 58, 323, DateTimeKind.Local).AddTicks(7587), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("50c819c9-85c3-4663-bf9d-e94e1388ecd5"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$DaFpgsv9O3DWM9LKqwm80eZiePQAefzKunBWKmoJfrP3qRJqImVzK", false, new DateTime(2023, 2, 28, 21, 2, 2, 127, DateTimeKind.Local).AddTicks(6330), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("5468a97b-7e1c-4d0f-b233-09a67a3cb9a3"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$82XRmfFlx200voPebyy.k.QBc1mnX6Tm1uNwyUeEhDoaAHV7ysz.i", false, new DateTime(2023, 2, 28, 21, 1, 59, 183, DateTimeKind.Local).AddTicks(7473), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("57037881-f16f-4720-9d97-80d94f9f0db3"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$GykcJba1mfZTbVNSNUNx4u5CadbkIGhTVnQ9EYxOv071tkPxSDk9y", false, new DateTime(2023, 2, 28, 21, 1, 57, 851, DateTimeKind.Local).AddTicks(8295), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("583af59a-03ed-4caa-82c2-aa0e48d08528"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$BqEWRweovWRvSoVCL2VoEulThb8zb93rKgPPk9I/CRi/BHftYcRbS", false, new DateTime(2023, 2, 28, 21, 1, 58, 895, DateTimeKind.Local).AddTicks(4012), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("5ea9c96a-4ebb-4bbc-8d66-22624cc2a822"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$w1bnbTmPGIW1OrZ4sYio.OVADcztrxFPedONM0oMIPPiAsRdjKYWG", false, new DateTime(2023, 2, 28, 21, 1, 56, 811, DateTimeKind.Local).AddTicks(4132), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("6438cedc-d8f9-48b1-8797-70c38a80b999"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$qJkybuQYAuCgb8IFBa3RnetGWRmVk2GSbBIjq3/Nukc2B8aHNSu5i", false, new DateTime(2023, 2, 28, 21, 2, 0, 426, DateTimeKind.Local).AddTicks(8528), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("64f096f6-c411-4cdc-acd6-a5cfcbc5cfa6"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$KcoLXmlwh2sBjtfFcP5GYOoYrAR8SvpXtTQGqjiqQByI1BUTadHpm", false, new DateTime(2023, 2, 28, 21, 1, 51, 771, DateTimeKind.Local).AddTicks(1621), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("673c2ad5-79ff-4de9-a57d-587d00981982"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$5OCCt.wimzLHMN3VyfL73.al2fSHSN16ZpYtpmdGXhvxUBIepRvvq", false, new DateTime(2023, 2, 28, 21, 1, 58, 714, DateTimeKind.Local).AddTicks(2423), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("679f3032-de69-4009-8804-59cd65125c7b"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$QaEqWhm2aDPmO0OeFbMuTuGRAGzf2ru4dOjcdsSEvspSLdbwoZn2C", false, new DateTime(2023, 2, 28, 21, 1, 55, 458, DateTimeKind.Local).AddTicks(172), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("67d45ebc-b7a8-47c2-b4c6-9e34206c4981"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$ZQH8gwltW9S2LGaU.P1G2egDDvUeJSpaYYo3MDu0XOg2cExTwtTo.", false, new DateTime(2023, 2, 28, 21, 1, 59, 86, DateTimeKind.Local).AddTicks(5853), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("7157e165-9976-4e6d-b704-ce2e17455d08"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$0wQf7hzqJB9osY9cPjfZH.iHhgxPYublgXYBYpvbFvrxULkwY0PQy", false, new DateTime(2023, 2, 28, 21, 1, 57, 620, DateTimeKind.Local).AddTicks(6060), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("7320d6df-8599-48d8-aa7f-6223ddcc7e91"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$RPJHtzHAPjHwxcBlloGnxOUOIVW9IfGsMydX356t3L.AUVwQTzTRO", false, new DateTime(2023, 2, 28, 21, 2, 1, 4, DateTimeKind.Local).AddTicks(2285), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("74730d37-1870-4d16-9922-37c3483bdbd6"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$gwYwcfpbeEDmiZafhRexpOju1xR1QsGqQzBZjwjJTX7lm.LWLwHLa", false, new DateTime(2023, 2, 28, 21, 1, 56, 726, DateTimeKind.Local).AddTicks(6372), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("775cbdc9-b4e3-4d72-bff7-296ac916f6b5"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$VYY8dEZT2LNhDmC1Wv0RnuWyDDxNTJmeQBmfervKqt.J.b1NjPtKG", false, new DateTime(2023, 2, 28, 21, 1, 56, 125, DateTimeKind.Local).AddTicks(7240), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("788e357e-3636-4e3a-875f-05ea3603283b"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$DPiXM.olUKUPc7zsDbypceOWXe7jJ6H3DSE2Fo42uUiPaRkTpz2eO", false, new DateTime(2023, 2, 28, 21, 1, 52, 88, DateTimeKind.Local).AddTicks(718), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("79aee4ca-8adc-4a19-831a-f6bf75ec407e"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$kPGhDfReGvaAAfaSahSpFerf2jxkqiwKqQ7iyvhipIvTPe.s.0urq", false, new DateTime(2023, 2, 28, 21, 1, 54, 154, DateTimeKind.Local).AddTicks(5533), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("7bb47433-4688-4240-a801-b83f3a079ee6"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$z4GLqV0Y6b12fBvqn3mPHOCYBc8lgzplfRytzUE2.NicihSZlIMWy", false, new DateTime(2023, 2, 28, 21, 1, 59, 281, DateTimeKind.Local).AddTicks(7050), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("7bba2457-bbad-4366-84b5-a2f92c15e2ed"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$e9jiWYZoxMoFxqiKM4KnvefgQrBAgNqFJccdi6CM6bqahvZOZ87b.", false, new DateTime(2023, 2, 28, 21, 2, 0, 877, DateTimeKind.Local).AddTicks(4874), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("7bd43200-8867-40dc-93be-90e1b3bdf6ae"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$PsatHxrVzSMsZS36CGL2PuS3I4bOXoczSfAKGSYVlHs8T/pNQLHe6", false, new DateTime(2023, 2, 28, 21, 1, 55, 536, DateTimeKind.Local).AddTicks(2086), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("7be927c7-0725-438b-b925-61701a3d2a64"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$f2d.B2lxaTdHa2BwdShFUOCGLr0/no6I63F.B4SQbFypUuFQVAp7m", false, new DateTime(2023, 2, 28, 21, 2, 0, 536, DateTimeKind.Local).AddTicks(4169), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("7d01d6ff-89f6-4d7d-a468-844268fdeddf"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$JoBax/9lFbT64DnmcOMqDOWXz0tuxTuA/70tjUY4yCvnqiKbxLlui", false, new DateTime(2023, 2, 28, 21, 1, 53, 156, DateTimeKind.Local).AddTicks(5642), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("7df11826-07c2-44da-82b3-06af190f619f"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$/8/1v0UofSzT/vK3U7NbZO5Fd3EI8IMy38nQF3yrAqr38kDeGRUh.", false, new DateTime(2023, 2, 28, 21, 1, 52, 369, DateTimeKind.Local).AddTicks(2364), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("81fa3406-56bd-4bcd-8659-db30438d6246"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$ITlqkaM/nn9BOuY9IiXwaeyMSVN9ShT.e3TcSX39humLZ0axbCnMy", false, new DateTime(2023, 2, 28, 21, 2, 2, 436, DateTimeKind.Local).AddTicks(5892), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("8396318e-1ed9-4e01-8113-9ccc80b91878"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$Y1KuKxbuEUZT6qaq9HZz2u4Etntp5w46PW9MMkIxe4QrkIzg3R5MG", false, new DateTime(2023, 2, 28, 21, 1, 51, 453, DateTimeKind.Local).AddTicks(7711), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("85d808c0-18d3-4e69-9ec5-c447055d7346"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$76FHrmlBd9ihZd8alBxIteisbupzKm/vsC8MKguRCdzaygWtAgw.G", false, new DateTime(2023, 2, 28, 21, 1, 52, 606, DateTimeKind.Local).AddTicks(4481), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("8894fd0e-7255-4326-9e58-16feb6cf9488"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$UjMh2Y3kA/vZ6OFmjyx4J.kK8XC5AvMsoDe835Hj4R1z9N.zRuMai", false, new DateTime(2023, 2, 28, 21, 1, 55, 810, DateTimeKind.Local).AddTicks(4289), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("891bd037-beb3-4539-93de-7ec499f0eabe"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$Omu8sHEWnnKJsIkmjU9nme1IyC.UYO573daB.jKE.mtF6cJx8EqUu", false, new DateTime(2023, 2, 28, 21, 1, 58, 86, DateTimeKind.Local).AddTicks(2873), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("8c0522fb-f45a-4763-a33f-32f9c3d480f0"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$14AI8WGcV6j64BNF.5S8OOBGNlmpifFSMYe3CyoFmcxMEINHwyMcS", false, new DateTime(2023, 2, 28, 21, 2, 2, 220, DateTimeKind.Local).AddTicks(8400), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("8cd722d4-9c81-4325-bfc1-29a37aa2abed"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$IwE4YysSJ0kdVNyp6ItR.uhk28Cw1B13dYeDjyis.9pqLOwDPw8BS", false, new DateTime(2023, 2, 28, 21, 1, 53, 851, DateTimeKind.Local).AddTicks(3362), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("8f8e12c0-6223-4b2b-95e6-89ae29b3f063"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$ZqBrSApi47zPSzXkItGMu.6VQC.RmySvK2TY/Itf4xILYc6BivCE2", false, new DateTime(2023, 2, 28, 21, 1, 57, 229, DateTimeKind.Local).AddTicks(390), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("937d83cb-c801-4e24-8854-bd8fd3031f50"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$C2OPKOC8GeFy7/0nxU8kDevKoWvh6zYSok9UN7vFA49BaGeqVJac.", false, new DateTime(2023, 2, 28, 21, 2, 0, 306, DateTimeKind.Local).AddTicks(8541), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("93cef053-e96c-4201-8c88-3a9479a80e65"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$LI24wVA9Y.vfk/AuW.vhUOjgiLsXVjRHvah7pyj38LnBmfP0ge05O", false, new DateTime(2023, 2, 28, 21, 1, 55, 377, DateTimeKind.Local).AddTicks(5333), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("95bc60ab-2ece-477e-b91c-2ea565867349"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$kWlyeFb85NKzm8v/o/nPk.9N89GIjHJg.5UUt.iCP2HgFDGEwNO76", false, new DateTime(2023, 2, 28, 21, 1, 58, 986, DateTimeKind.Local).AddTicks(3987), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("95c2edb0-ff8d-43b5-b034-728be533e5c3"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$Xd8Kub8fzchcwwM9yTVAoO5NHCNt8etTgbe1W3LbQCAbYiP2yWT0a", false, new DateTime(2023, 2, 28, 21, 1, 57, 927, DateTimeKind.Local).AddTicks(5184), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("98a5d744-1cd4-465e-b7f6-45f0f27d1056"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$T6A4zLmpk3qwvsf8pocNEOToTgUWb.KpK2nbD4SorjDBc6IcQMcyG", false, new DateTime(2023, 2, 28, 21, 1, 56, 487, DateTimeKind.Local).AddTicks(3996), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("9987db58-3b58-4295-b7a3-ea84149e8e7c"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$rpAB6w39Z0BowFB7mGqEP.ELcWQ4F/cv8q8sPp.Ml2Zsozm8sO7gG", false, new DateTime(2023, 2, 28, 21, 1, 55, 971, DateTimeKind.Local).AddTicks(7703), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("9d0d3250-0cd7-45ee-8a7d-2ad3fdd444b3"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$HVzKVcYIneqDGR/LVH3IcOka5BQmrRiLFq4mzVDslffqOhz6JEb8u", false, new DateTime(2023, 2, 28, 21, 1, 54, 538, DateTimeKind.Local).AddTicks(5905), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("9f9d67cf-867b-49ca-9041-08d04e8036a7"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$l8v.OKZCfwlUi4c1IUQ/G.DaD2Rl4j9foi1Vy/E570ELXXTkI5.yC", false, new DateTime(2023, 2, 28, 21, 2, 0, 190, DateTimeKind.Local).AddTicks(9340), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("a086d608-9e41-4b28-94ff-a245f727b1d6"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$g/BiYgWVqUMpAk/SxPp2huV.6MPPGV87Qy9Pd1kfAguA9u8tipM6.", false, new DateTime(2023, 2, 28, 21, 1, 56, 980, DateTimeKind.Local).AddTicks(8493), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("a2282839-cea7-4320-b767-e72f82846980"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$KMDfQ9i/4HjUuM4hhuJAaOQEjy/8rELugDWLWozxd.RPGSL1C5Ime", false, new DateTime(2023, 2, 28, 21, 1, 52, 500, DateTimeKind.Local).AddTicks(9310), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("af75e8c2-61c6-47fe-bc55-3204acb9b40d"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$0.JXfJv8DI1ifOkESZT/gOY8KRNxTWOgtNzEJfSVZFXUd2aoUh6QW", false, new DateTime(2023, 2, 28, 21, 2, 2, 318, DateTimeKind.Local).AddTicks(8183), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("b73e6963-3a59-4266-9d4a-85f3da9b6ba3"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$TsK/fnLPAo8.x64iLEtc1e/Khxdo6ltQyoAdzFnrygHob3NzvYwai", false, new DateTime(2023, 2, 28, 21, 1, 57, 137, DateTimeKind.Local).AddTicks(4963), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("b9842202-d485-4f0a-b645-b36f5153437f"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$ZwNcHF4dA4PHEn7O1oai0eoDEAUT2gUxOon09KnI2sVYW.9ZCXoA2", false, new DateTime(2023, 2, 28, 21, 1, 59, 730, DateTimeKind.Local).AddTicks(9058), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("bd5021fe-a088-4775-a359-896a96c8047c"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$mYauxpiEg5GIrEh/RXDGhea3sUTp6fRtl8TtGfyRA7jjzYEC1dUNu", false, new DateTime(2023, 2, 28, 21, 1, 52, 984, DateTimeKind.Local).AddTicks(2229), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("c6425a4e-98ef-43fd-9666-45ceaedec64d"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$DySKIlg2L.0jDrBYSpfBd.SrZ87mEJ1QbsVaaj/B5T/b6OICT5hiW", false, new DateTime(2023, 2, 28, 21, 1, 54, 252, DateTimeKind.Local).AddTicks(1413), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("c6d1a53b-dbbd-4bc7-98d5-f3b5b692c85b"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$ncllRmgFyDMum1ebmV3Dou1pR4q.y3Y13h1Q4XQ9yL7HCePcUftDK", false, new DateTime(2023, 2, 28, 21, 1, 56, 291, DateTimeKind.Local).AddTicks(6645), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("c74b7346-3163-449e-90d0-d98c7aa50b9f"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$3Ea8fvn4VVKMowECfOtFn.IU5ea.xmjSK/Gc4Hi3jryc9nl99qS5m", false, new DateTime(2023, 2, 28, 21, 2, 2, 28, DateTimeKind.Local).AddTicks(7191), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("c7a8f421-714c-44fa-be2a-5528f13d770f"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$qngezEN6mTi5JzXejR4K5.EeoEoHRNoooO.8U70b.KKJHYROXfYL6", false, new DateTime(2023, 2, 28, 21, 1, 54, 1, DateTimeKind.Local).AddTicks(6375), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("c7b401d8-e182-4ebf-b10f-45dbf9e767e4"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$lMVNc.zXPTtVzZKixLgAcuHcB24X5nyLDzxSIh26lVvXyGR48dBzS", false, new DateTime(2023, 2, 28, 21, 2, 1, 330, DateTimeKind.Local).AddTicks(2081), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("ca8a328c-3f06-4638-8640-de53e58f7b07"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$xcb.D/EOP9cpaMEZpvDVNuCGt7iHBEN2EbpFOp0kVSdcM.XJ3J4XW", false, new DateTime(2023, 2, 28, 21, 1, 53, 622, DateTimeKind.Local).AddTicks(7315), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("ce622a34-9376-454f-8bf3-27d2864965ec"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$i7LA91bYKHbJHJNH2vHaIuCmXvoNtNIJQaEeavbPkhHSuOnN3ZgDi", false, new DateTime(2023, 2, 28, 21, 2, 1, 918, DateTimeKind.Local).AddTicks(5342), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("cef9a540-e97c-4316-9457-13f1bae12e2a"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$/ZkiPNnA4gGTqcGvx3V.ZOTYuoI8fZSkT1Rxqkgi/QpgAs35HvpvO", false, new DateTime(2023, 2, 28, 21, 1, 59, 965, DateTimeKind.Local).AddTicks(7787), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("d1a31b88-233f-41e4-84fd-072419f7bd31"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$Db01vY43TeFymt4nnnMXBe4LgOl1xPSBiRaqJwiDmuigprE0FdJDe", false, new DateTime(2023, 2, 28, 21, 2, 1, 803, DateTimeKind.Local).AddTicks(4712), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("d6a8d981-f2ec-4918-9c56-ff35c5f7d010"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$SEJOGZ6Cc7h6y19UkiIJ4uzdCnEw6w.A7rtBuszzAvxda7pkHIQey", false, new DateTime(2023, 2, 28, 21, 1, 55, 611, DateTimeKind.Local).AddTicks(6906), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("d7454f5a-75b0-4ed4-8e00-509c3b7e33aa"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$g4SGf1IkK03/8LTUAyRwx.urvq9/jrOlefvv/egfiBIVFNdusfAOS", false, new DateTime(2023, 2, 28, 21, 1, 53, 548, DateTimeKind.Local).AddTicks(1904), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("d9bb2daa-2cf8-45e2-bb57-a7e32c43a7bd"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$5yzMvJumqFSZKcz.3QvFi.VD9Kp0k/CRb.t3iCcHSI/HRomD24fpO", false, new DateTime(2023, 2, 28, 21, 1, 53, 698, DateTimeKind.Local).AddTicks(1630), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("db4ebb00-7cb7-4783-9a0d-5c5379b8a37b"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$tA0mJ1YG1lMGJAmNwGEb/uoc52JxYl6AwSsvXD6lSKEw4ZMU8Bxam", false, new DateTime(2023, 2, 28, 21, 1, 58, 808, DateTimeKind.Local).AddTicks(193), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("deb261e7-4d9f-4259-b8a6-9b656a947efb"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$Un4NoN57qr8pg.bOL/Mtve2DC6.fktRNSUdSAlkVDrP8gi7Im2Zk2", false, new DateTime(2023, 2, 28, 21, 1, 57, 999, DateTimeKind.Local).AddTicks(6692), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("df886c2d-f3dd-468b-af9b-64ddaea528cf"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$aLu9goiaX89lYFQY4OfFTemGjRxxqG50/.KNqBtGDkgBpS7Hw9Ydi", false, new DateTime(2023, 2, 28, 21, 1, 53, 926, DateTimeKind.Local).AddTicks(5158), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("e22506b9-e25f-43ab-8c29-904bd95b32a3"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$VGNikhoNkjAPIFd7.r26V.Ft29aN9lAwqzcNMHhna348ejoam9KG2", false, new DateTime(2023, 2, 28, 21, 1, 55, 181, DateTimeKind.Local).AddTicks(3509), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("e3c5e6d4-b9ca-472c-a002-013665a5e7b9"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$TXXaKYBlQ7YaNhlwevDta.pwFCa5.uhjKuOvB3GSPy/dS/3JkU5C2", false, new DateTime(2023, 2, 28, 21, 1, 54, 345, DateTimeKind.Local).AddTicks(5022), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("e5fe14c7-2fa7-4e50-b703-cf671ad968ee"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$CgP0NbNVf4AwdVd9vetApO2o9BSWHPNyeYJSr5gqomQ8wkZNPzDlm", false, new DateTime(2023, 2, 28, 21, 1, 58, 614, DateTimeKind.Local).AddTicks(3710), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("e748eae6-4f3c-4465-8ff8-dd8901112856"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$S3iELF/5/RtC2rkQEB3DDeUdftdoQA8LYr3R59jJf4Yfy4pT6iKe2", false, new DateTime(2023, 2, 28, 21, 1, 54, 645, DateTimeKind.Local).AddTicks(6126), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("e7919cb3-4a10-488e-9e05-5ae0f252a57d"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$3zQyLemABX4SmN9F.1jn4eD8wEH.Y0UZ7.4gknt9GnjVByXC6ZET2", false, new DateTime(2023, 2, 28, 21, 1, 59, 496, DateTimeKind.Local).AddTicks(6097), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("e8d3c463-6e9a-45ca-aadf-ff000158d54f"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$.DfymAObgsVh0B0Hs9X0xeTdBY.AkZhciq0CakN8WAlPWNBLFHB5W", false, new DateTime(2023, 2, 28, 21, 1, 59, 839, DateTimeKind.Local).AddTicks(7004), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("eaf9730a-4b03-4282-8e7a-816f7540da0f"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$Se7lkVUA.ajEEu8LA7Hc5.h/FH9WwUEfo1cu.xEzztOicSBM25Qqq", false, new DateTime(2023, 2, 28, 21, 2, 1, 428, DateTimeKind.Local).AddTicks(8624), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("eb2cc043-2265-41be-8f0c-b4d34d0bbd12"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$innXwHC0N2ynHu2z02IXZO3BipjPJPxA1zpyAQeLV9FJAS2/u2FSS", false, new DateTime(2023, 2, 28, 21, 1, 58, 165, DateTimeKind.Local).AddTicks(3916), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("eef61ed1-5633-4f72-b223-66b9276f06cb"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$uF2fGucYAUMVwv3btV7YZ.4PP/JpPDGAzswNmnoDXI0SogdP6CA4y", false, new DateTime(2023, 2, 28, 21, 1, 52, 804, DateTimeKind.Local).AddTicks(4695), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("f0f29705-2d45-43e4-bc4f-f7e8f4c4159e"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$JPvruAJik/6zu./Niy00P.wI.NnBxQI1To2.Tl5k0df961uU2sVoC", false, new DateTime(2023, 2, 28, 21, 2, 0, 769, DateTimeKind.Local).AddTicks(749), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("f1a22f54-24f4-4ac4-8b58-1534f737ad98"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$lh.QrBEZ.3mYd5rd1zdTy.4kgYazrVaVdKZ0bQYGLB2eaWJJuD9le", false, new DateTime(2023, 2, 28, 21, 1, 57, 61, DateTimeKind.Local).AddTicks(1393), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("faa5e7b0-a9c0-482f-9d96-b2feeca32c04"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$0inYb.SAPmcx3Ho9EgViQOnwjWBrYnoaEhjV9nFfn1maTo.EHRA5G", false, new DateTime(2023, 2, 28, 21, 1, 55, 284, DateTimeKind.Local).AddTicks(1929), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("fac4146a-ef81-4d63-9827-9a98338f1406"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$0cfFKWbQ1J588tj3I/Bbv.BqYvHO8ERfe1.7JBhvm/8iVmpGi/HWq", false, new DateTime(2023, 2, 28, 21, 1, 54, 77, DateTimeKind.Local).AddTicks(2673), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("ffd22c93-00f3-428e-b6af-be71b6d6f3b0"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$81noGSnvm1fVNr1qGBhD.OZEPA7Yv.I1KMkU0mKbuT8NNgpiuCD8.", false, new DateTime(2023, 2, 28, 21, 1, 51, 3, DateTimeKind.Local).AddTicks(5112), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Slots_CarID",
                table: "Slots",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Cars_CarID",
                table: "Slots",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "ID");
        }
    }
}
