using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver168 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("0fae940b-9d05-4a84-9ece-b616e6591ff4"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("17b6c38c-7e7a-4d78-b120-cfb0c7e52e71"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("1b202270-a576-4e97-b65b-b59515306046"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("2469ac8a-95c5-4830-8635-1b960af98040"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("2738ee91-9d70-49ec-89a8-e7016ac5e65b"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("7f752060-b813-48f5-a111-102288c2c667"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("85f8e0e6-c985-4c98-9e8e-3ddc8a75aa6d"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("97bbdcfa-0de6-412f-9fef-31c7b71331ce"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("a2bdec44-a613-4d77-a3de-6d1c06ffec86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0022fd4d-df34-4b30-b932-2b1de17ae834"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0426ce6f-4854-4d3d-a893-54589c03516d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("06081c76-34c5-4eea-938c-99991f358c77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0b8a09c7-abd4-47ec-a95d-b2f6abbb7d2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0dc4b0ea-769d-4a4f-9f4b-b7cc63837ea0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0e1541c6-7a53-4553-8436-e464dd0fc76e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0f6e0bf3-cd4c-4fb0-bda0-a91e6af44ef8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0fc4b91a-b9c1-4600-aaba-e990b580e041"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("108b1377-bcb4-458f-9bd9-c1bb7e60d5e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("11e85125-73df-4085-8be9-f0bd01ff9ecf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("15e3a4d1-2feb-465b-ac16-9e082e1f26bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("165d3abc-37f9-4834-9477-b6c5965d68a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("190554ce-91af-4dcb-b87e-0a991808463a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1a0d4c24-eab9-4397-96f5-0cf032bd11bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b2ce735-e724-484a-ae36-2352d9d1cfeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("22bb2f57-a23a-4940-b2d3-26ee696bac28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("235e37e2-90df-4e84-820b-d43fdc5f196f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("24a4f099-35c1-459e-bde4-cd2cab275ceb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("250c0b1f-78b7-4c71-9a54-2b402b1d067a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2604e1e0-8515-4f84-9727-5b18afd9bca6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2889d190-c0d1-4660-a65c-0a905ce8daa6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2b5ca429-06f8-4b6f-9850-c8b19f669057"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2de7a31a-d1ea-4ec4-bdcd-92a6244a41bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f9b4f93-8225-402a-9f62-3c634058fa55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2fe8ba23-81af-4e45-a501-b5f1db2e2ef9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("35a7f86d-d57f-4f1c-819f-e849a17b09c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("37386abf-580f-4b94-a3dc-685c4aadc062"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3765557a-e34e-4e70-8fbe-fba1870d3c32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("377f6b9f-0b71-4605-8ab0-2669c3e82bbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3bdb5293-3d67-425a-bc32-73117a657482"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3d3b7946-8cea-4bdf-ae67-9157ea969116"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3d985924-5e1d-494a-abcd-7ac00e795c39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3ddc0f27-2fc7-4d31-be12-3674ec4c40d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("401f4aed-1de8-425c-992d-83a9c62c7a1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("40b272ea-cb08-467f-92c3-6ff21094098a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("414756a2-b5e7-43f2-92ed-b9acb5f514b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("430a978f-3def-4ba7-8535-e3eececf011c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("440c13b2-504b-4741-9c50-2a21731a48f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4513b3a1-4447-437d-a23d-3018fc094250"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("47080f7e-43ef-4eb8-8896-becb5ab59f5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4747ca34-dcd0-4969-b2b0-b21771229172"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4b6b829d-3980-407e-8641-27d10d050c3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4e3795b6-5461-4ae4-ad06-cb5282745f7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4fe0e50a-16ee-46aa-a6f1-9010bda715d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5080792d-6ed5-4894-80aa-3404c09f2f71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("54e0f956-8a4a-4502-a155-2882e5e68766"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5bc4138c-2e61-415d-a385-f0dcd2c09b4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5bda0c0d-8651-4012-84b7-3d67298f40cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5fb1a797-72f3-410c-9072-c9df8d89645e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6cc0323c-050f-4457-a5b7-2e9113b90fa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("77572bec-cb72-4dbd-a02a-34764d8269ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("779792e4-2699-4c43-b30d-c27029efd866"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("79dffd78-298a-442f-b6fa-7152f1e34c7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7c10cae9-5630-4686-ba8a-440325472c34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8697620e-d49d-47f8-9987-5f8019738ad3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8b067d3c-5caf-4a3b-aa8a-d56616bc7b2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("93e5b13d-1978-44b9-9f01-0fa954baf3df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("95ce9058-7ec9-4b83-946f-a776555a9e33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("99ad2e7c-b805-42dc-a8f3-e752ade89cdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9ab91338-4db8-48fa-821a-74fcc47d1f7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f0bfa15-2b4d-4a13-a0ee-d88bc3a984cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a00dc0de-143e-4b3c-b940-7d54546eb592"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a38c62b2-ffa5-4c2b-8250-1b0b920302ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a45cb3eb-241d-4365-b61e-c1647b9c2615"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a5c61618-99d0-4d72-9cf8-2d6b581125bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ac6714a2-e7ad-4903-bf35-17582bc65839"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1bb1d27-283f-46b1-9fe9-737730b7d4bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b2daef7b-00b0-42fb-83be-5cd1c7d0e8fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b378e7ae-9e71-44da-9936-48f7e982e032"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b786c245-864e-4912-9938-35a2803f92e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b78f495f-3f4e-48b8-bb09-2728d2fe86fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b7bca624-6e43-40a5-a1e7-6d5534639a40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b9839e7c-1c71-47d7-91e4-5b7e83da0b55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba4c5f72-df3f-4419-84b2-c8915b4f496f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba786e63-9e45-4604-a2d3-2dde615ef0a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba921fbf-2872-4ec4-8927-cd924d8bf60d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bc6da56a-faa8-4ee7-aac6-25466074617a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd8b2e34-4ef8-471e-994b-2fc6ea17133e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd97c3b2-e392-45c0-a1c5-3f9be11d36ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bf8822a8-991d-4d01-8bc0-0c60a18ac505"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c0ac435b-f472-4775-92aa-03b8fd061579"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("caddc873-4196-4804-9435-b63d75f77f30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d63fe045-cdcb-4c97-a031-f0efbd0daa56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d6f4cf33-9ede-46a9-9feb-7c134c9ba171"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d717836c-1ebc-4e01-a774-cfd921c8bce5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dc416857-ba51-488e-a356-b5f065e5c7aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dc85e30b-06e3-4445-8166-a1899d43f4ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("de6f32ad-7510-426a-b42e-4d44c7474ef9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dfe72099-0572-4868-8a36-441045a09e39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dfeb78c1-3ae7-4d9b-84a2-6e4d671ca42e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e1c59063-4f3e-40fa-952f-5240288c3150"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e306f6c6-f8b7-486b-b5dc-6e81cbac9273"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e409f144-1fde-4cf2-95fb-ddc4eb6fdd5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4cdcfd7-9ee9-4a71-927e-a032528c9187"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e88ce0cc-ca3f-4e5e-8ea3-52454016df21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ead446f8-8100-4346-a278-61ecf2dfb69a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ebd34878-dfa3-43bb-8232-9b73af3f076e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ebee2131-5dcf-41e1-b786-8ea4ba9494ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec10d11a-1fbd-42d7-970a-18465ad79dea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec7fd5b8-b394-4732-911b-2535ed2b0076"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec92720f-e294-43cc-86fa-ddd9f3d9a09c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eee9b7d4-b7c8-49f9-b168-6aa4a6c01d28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f1055956-660b-4a4a-8c11-4fa914b254f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f1cdd001-593e-4b47-b46b-da2e252f6c59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f2c99868-efbb-4352-a13e-6c426c6e00b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f350aadf-df49-414b-a30c-437f349399cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f5f88e13-533e-4d42-af63-a085c5f14414"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f6342ba5-3828-43a2-8023-4b4606b88d74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f64f418f-9c28-4b46-9354-f0e429b14caf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f78ae8d6-6c44-4385-bec7-0665c6f3f4f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fb737827-ac35-44f9-b952-78d37cf17c4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fbc5a901-daa8-434d-ab4a-43036d2a2652"));

            migrationBuilder.AddColumn<Guid>(
                name: "CarModelID",
                table: "Slots",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("2f985036-fe37-4676-88ec-c08505c43aaa"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("6fa0be83-8a60-41cd-8d22-f5e2f73b97f2"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("7dbd726f-1e99-41cb-8ee3-15bb2a2b38b5"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("9148302b-5b38-4799-95e8-aed413e20d3c"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("9ed67ad3-c592-401d-ac7c-2a279e739b05"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("a66d1a77-f0d7-4883-902a-1bf4f11dff45"), "xe 5 chỗ", null, null, "SUV5", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("42d7c65d-4c4f-49b6-b53b-e138a70ad12a"), "1 Year", new DateTime(2023, 2, 28, 18, 45, 27, 163, DateTimeKind.Local).AddTicks(7379), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("584afdde-5425-4249-a7aa-12b9fd7d34f5"), "Short time", new DateTime(2023, 2, 28, 18, 45, 27, 163, DateTimeKind.Local).AddTicks(7374), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95a05634-6125-4690-808b-c0f2257c766d"), "Half Year", new DateTime(2023, 2, 28, 18, 45, 27, 163, DateTimeKind.Local).AddTicks(7378), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("00c65788-e629-4a37-9cfe-19f4f3e1e114"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$Zgr8PFw/M5ux5nVuau.jA.ZaiTvvWQcrSIwUJBZXJ8RJpKtR/9AfG", false, new DateTime(2023, 2, 28, 18, 45, 19, 613, DateTimeKind.Local).AddTicks(4236), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("02b21902-41fb-4e6f-850c-12578907ff9e"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$KQhiZt7zMyao8q.WhRi8HO1LfENmSvUhjHdQIP6.r3dqv.HYrzQfi", false, new DateTime(2023, 2, 28, 18, 45, 27, 163, DateTimeKind.Local).AddTicks(6784), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("02c36ff4-ad1d-4ab2-a397-c6f048b914c6"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$HO1RgIdR/W5blfhTrP/./uHAHZ3pNJ8.8ET4pJJePwGel50poLNBm", false, new DateTime(2023, 2, 28, 18, 45, 24, 732, DateTimeKind.Local).AddTicks(9256), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("0916ab52-1003-4aa4-bbb1-bbdac53f7053"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$O6huyQWRoeaVkacaVXPBVeZQa8SAlk9ZJmO2ohkh2Mz9tFnytGuZe", false, new DateTime(2023, 2, 28, 18, 45, 17, 441, DateTimeKind.Local).AddTicks(9218), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("0c7d1a00-ffab-478b-b70e-6059f528c65b"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$qGuAF0cAfg9E1IBFJY.LjesEo.fXHd0EpJyqcCeqwp0EKRaiKASEy", false, new DateTime(2023, 2, 28, 18, 45, 18, 257, DateTimeKind.Local).AddTicks(4672), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("0e7f03a5-9e08-49a5-a571-74b5d32af111"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$v0KznxnaWczhZ0yIMjgeC.qbsgl21uwLQEWD7yK1V06ZKmIPJIvXq", false, new DateTime(2023, 2, 28, 18, 45, 18, 95, DateTimeKind.Local).AddTicks(9060), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("11390c58-73ce-4e93-8d71-f063451e26c7"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$Wg8VvkFlAytyIaVV9R4AQeOP0o13oZjar28DWhwaQjbwxRHuaVx0m", false, new DateTime(2023, 2, 28, 18, 45, 18, 783, DateTimeKind.Local).AddTicks(7812), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("12f4baee-3f73-4020-9836-301564bae113"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$zxQ5g1.af6En9Bgj1esY9O.rmFTfTzxgeNZUkG3MTOapkxwc7d/7u", false, new DateTime(2023, 2, 28, 18, 45, 22, 811, DateTimeKind.Local).AddTicks(9907), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("1460fe16-bb67-408c-bc34-01c5818afb71"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$Jm/2o1k58w32gCUuJCyqhuZlcf1mFKfj2uuY0N1yBkuiYsYb8.qPO", false, new DateTime(2023, 2, 28, 18, 45, 26, 947, DateTimeKind.Local).AddTicks(6541), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("17670509-00fc-4926-b224-8710692cf76e"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$/c/VtFMd2GHSNOFBCHIFLOv68vqm5zerrhN5puRC4PeW5bBErnYBa", false, new DateTime(2023, 2, 28, 18, 45, 19, 247, DateTimeKind.Local).AddTicks(9583), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("183c7228-8df7-46ac-b376-95a6c4336b28"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$dLiIvcNvyXzVg/J4BBdo0eAL6E1HGN4rjKpMdpge4R62YjSGyg13a", false, new DateTime(2023, 2, 28, 18, 45, 17, 830, DateTimeKind.Local).AddTicks(3391), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("18514da9-e0ac-4c2e-befa-6fa24f55f306"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$6N0D668hrCJ/Y86L7v9N..h/NwFHP5b1wLdRBShQSnpWRiEQw21tK", false, new DateTime(2023, 2, 28, 18, 45, 24, 514, DateTimeKind.Local).AddTicks(4323), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("1866008f-f610-4e93-86b0-970652c0340d"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$tbrD3UNr80CD6/qERG5p6OTpkIBLIBl7Oo/21uEqzvUnOWXyM6qNO", false, new DateTime(2023, 2, 28, 18, 45, 23, 954, DateTimeKind.Local).AddTicks(566), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("1bfb84d8-d3da-42d2-b673-b5696df88619"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$nqUmUMdoFO0DzmVr5DEXDe6ipMLLAWcF/TGx7E/H8e7YrBFGOJBie", false, new DateTime(2023, 2, 28, 18, 45, 21, 261, DateTimeKind.Local).AddTicks(9633), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("1d42d5b1-6ab5-4d6f-a6c9-85ad22941684"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$gaRa.6vBGUrQOANXJzoQSeEs.uuDNYC91p4D1vjCzNJtEvNctSen.", false, new DateTime(2023, 2, 28, 18, 45, 19, 957, DateTimeKind.Local).AddTicks(5160), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("218608c6-a754-4964-bc2a-8ad79bce2386"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$mBnEW3bbDA2XvTwM77CuIe175xjiOwjoKgW1O40OwA5ATB1G0xuZy", false, new DateTime(2023, 2, 28, 18, 45, 25, 160, DateTimeKind.Local).AddTicks(5488), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("2458743e-e234-4a20-bd2e-038fe1e68ead"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$RkhIThM6ft0j065J1UxNje/wEfMEIGSnRcs7PK3ai/JBrA/XQb6n6", false, new DateTime(2023, 2, 28, 18, 45, 18, 401, DateTimeKind.Local).AddTicks(8265), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("254b3a0d-a33b-4e7a-87ec-1ae472aff70e"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$RilAMDjfyW.pGSN.8AYj0.vNMQnqk0XWgOdYgXjk7iGgC7JWSSXIG", false, new DateTime(2023, 2, 28, 18, 45, 20, 582, DateTimeKind.Local).AddTicks(2289), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("25dbebf4-151d-4714-b36c-8e650c631311"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$4sUyeV./EhVFI4dSqZaKeONcJjqnZLDmU8GK/DqMel/4S4DiS19J.", false, new DateTime(2023, 2, 28, 18, 45, 22, 128, DateTimeKind.Local).AddTicks(6596), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("29c83a68-91da-4b72-ab02-450885c4f68f"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$rw5MhVfgaGxb/HeA2t3zYeNSaOE0A5kOQhKbaOu5IrH6SxXYhuTZ2", false, new DateTime(2023, 2, 28, 18, 45, 21, 181, DateTimeKind.Local).AddTicks(814), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("2af992b3-45a8-49c2-84d4-07a99635419f"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$yS7f/sjZ2hilV.7xJBhyH.hvnpTkUMz3YI0EvSJ6W0XoYnWpwOcIe", false, new DateTime(2023, 2, 28, 18, 45, 22, 552, DateTimeKind.Local).AddTicks(1903), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("2d2771d8-6a3b-405e-9719-c7fdaf004581"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$v5w2Dd1WDuMdSZUyqEdSBuQ6.8Z0H6uLluyBjxM8bMpQovfb.fhfS", false, new DateTime(2023, 2, 28, 18, 45, 24, 658, DateTimeKind.Local).AddTicks(3235), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("2f1f195f-78f3-4cfd-adca-37628a909511"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$fhfTupmlDhUIm9gyBd4h4ucVgu.XbFVruS8eBlp5HUikB2J3vzVj2", false, new DateTime(2023, 2, 28, 18, 45, 20, 502, DateTimeKind.Local).AddTicks(2751), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("2f57a17a-3631-493b-91d4-c35cc2a5c243"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$xBBLycmuWjeHDR4cpIMnaeUZemvLnCHaXoYbKhA.Bo6OdR8xHfM6K", false, new DateTime(2023, 2, 28, 18, 45, 22, 52, DateTimeKind.Local).AddTicks(8650), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("32fa8ee4-a87c-4df0-a02e-a7ee63818f9f"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$29GEy1J1ftbTtxz9vlbqTO22RvfaygDqN.nf1uAPHz9.z5SuqWJBi", false, new DateTime(2023, 2, 28, 18, 45, 19, 321, DateTimeKind.Local).AddTicks(4969), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("3489d3d6-8f15-4f6d-bb1d-dea069b13c5c"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$lgnALQWGyPG8g/srtTnmuOXhpu4T3aoOrv6VFVzbsQTmDhoCQ8s7S", false, new DateTime(2023, 2, 28, 18, 45, 26, 417, DateTimeKind.Local).AddTicks(4426), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("3601337c-9f07-4192-9a37-33f8e611b34e"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$Q0kFTn8g1ylqI070YJ1m8epwCHFeAGAgtv3pxWqkYBFbk9KmxBbb6", false, new DateTime(2023, 2, 28, 18, 45, 23, 111, DateTimeKind.Local).AddTicks(7118), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("3cfe45ed-b90d-4b93-ba00-11987375b2bc"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$/2BwLQuXJEnUlUWtvQjI7.ltYhQ0596Crvz/hcsgdG2C4dsIyVDeq", false, new DateTime(2023, 2, 28, 18, 45, 20, 664, DateTimeKind.Local).AddTicks(5278), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("3e69b936-d39a-42d4-84be-f2afb69cedd0"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$72oEfem9OxXTGO5eBZqNduRzqqtAb9ActD14eIfGEyHLC0e6Z9L.G", false, new DateTime(2023, 2, 28, 18, 45, 26, 511, DateTimeKind.Local).AddTicks(9864), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("42ea9a19-eb13-4f52-9e8f-c0a2462202ce"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$4wlWRSC/j39wM9r.whzpn.ywhM178zP8Y7zVKnRRSKA1NP3E31rkS", false, new DateTime(2023, 2, 28, 18, 45, 25, 833, DateTimeKind.Local).AddTicks(6022), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("4432c978-c4a4-464b-ba1d-e5c9a6a5e7de"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$PaV7010yWmrBsf.5klqfW.BGHRhX//sfjk9/TewTDC0z6Jch6ShH.", false, new DateTime(2023, 2, 28, 18, 45, 21, 887, DateTimeKind.Local).AddTicks(2955), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("468b29ca-4a1f-4586-82ca-effeaf579bc5"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$/fxnsHwIOfvsn1OAxa8aleS0WmiU8SWKPbRtVUxxJE64nT7TevBoG", false, new DateTime(2023, 2, 28, 18, 45, 24, 914, DateTimeKind.Local).AddTicks(8435), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("4a29b6ae-abd6-44e8-9fc7-906a3b26e1ca"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$sgADXLtQVzWu3/HzFP0Yt.PB5.FqySVrLZ0MtcbQoq6tS.SFYSfTO", false, new DateTime(2023, 2, 28, 18, 45, 26, 682, DateTimeKind.Local).AddTicks(8243), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("4f6f47fb-5762-4b15-89f9-b516155141e2"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$9jfnP0HFLMa4b6lPue7IM.uo5GAavcyeRBFyhHDExHr2odS43rgOi", false, new DateTime(2023, 2, 28, 18, 45, 25, 999, DateTimeKind.Local).AddTicks(1623), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("50e34142-4ae8-4785-b413-e1de3dcf2e74"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$5xv4bJ6In/9MeFhv1q.9Q.9DzJyfG39KJEnBbUR1vTkAJ.0OLOp1y", false, new DateTime(2023, 2, 28, 18, 45, 27, 90, DateTimeKind.Local).AddTicks(6314), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("53f52ee5-c74f-48d4-90de-f6d48dc3c7a9"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$hoY4cRF5MTEpDoW8/5dkHuYG6rK2hQhJUBL.0kwLe9hA65KUFPz/a", false, new DateTime(2023, 2, 28, 18, 45, 22, 377, DateTimeKind.Local).AddTicks(293), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("54c0a688-b087-455d-8a29-a2ed01b63c4a"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$DuwIZK/dQ588HdZ4DC3aKO.ZZBMHTijw1Xxn0hoHhxIuNI11hK5..", false, new DateTime(2023, 2, 28, 18, 45, 18, 930, DateTimeKind.Local).AddTicks(5510), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("5559a5e4-c8b8-46b4-9588-82c14883eb8e"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$Tg.1kt2OJoe0FDbpwTMgAurP9Fb1IQVTX6WWPgczRH7dy/d4mpFyG", false, new DateTime(2023, 2, 28, 18, 45, 25, 516, DateTimeKind.Local).AddTicks(4714), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("5885f657-6c82-4cda-807c-1ac1642fdea3"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$aP6fLRicPolD8RcrrAFpa.g4V2IkE9AYaCi0DQffKnti3DTZbghV.", false, new DateTime(2023, 2, 28, 18, 45, 24, 988, DateTimeKind.Local).AddTicks(8744), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("593ef50c-9686-4d3a-a913-2ed3d59d4973"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$wAVTW0.JwZ39gsLL8JgQa.XHXa4Ze1wh1L7Bx5Jr5X/vd5MyOlPaW", false, new DateTime(2023, 2, 28, 18, 45, 17, 533, DateTimeKind.Local).AddTicks(8728), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("5a3dbb3b-25d1-48d2-8f3e-1eeb612e9fd7"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$vK31oTUUx/7Lt7teZGIht.ktZR9W6Ep1qxOe1wcD6njMYauZh4U3W", false, new DateTime(2023, 2, 28, 18, 45, 23, 26, DateTimeKind.Local).AddTicks(7838), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("5bb6e190-1744-4e0c-8519-5fd60cef35f3"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$aZ1xpAMGJCk3ytbqjLhqd.q4tSI0yePub486c.3AbySYF8.a1IMK.", false, new DateTime(2023, 2, 28, 18, 45, 24, 26, DateTimeKind.Local).AddTicks(8012), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("5df6b22c-9383-48f9-b9e7-68c4ecedcaaf"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$3CkxU1JM2xZLym4Bi4JvOuvFot35xOiI7XDPLm.ssLME3gGapvXo.", false, new DateTime(2023, 2, 28, 18, 45, 21, 806, DateTimeKind.Local).AddTicks(555), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("5e7aac65-ad54-49f7-ae09-96e053784701"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$t.ni0oUjP.Bp/dTglb4Oteb0yq0Xq82SFHUoMYLgEDrdg/CKZbOOq", false, new DateTime(2023, 2, 28, 18, 45, 23, 460, DateTimeKind.Local).AddTicks(7268), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("5efcc8ad-fa40-45c8-92e3-38f5b6aba7bf"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$GcKM//Zu3ns/oPC0ux5jcOaGkgn5ZoLA9eECQDWoxfUbvZECg7BUe", false, new DateTime(2023, 2, 28, 18, 45, 21, 553, DateTimeKind.Local).AddTicks(8510), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("61abfbe0-0ba5-4c2f-ab03-972ca135b5bd"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$YZ9xj0x3bvTEc0ducpywUOelKU6QWrVmp/84ZA8yy4nZgRjpxT5hi", false, new DateTime(2023, 2, 28, 18, 45, 19, 497, DateTimeKind.Local).AddTicks(2454), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("6353da16-36e9-4198-bc35-8be8faf21b5e"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$XVhyg8UoZcXsYSH9KvjqTunTRMCCsQj2ltBVwivPKz6SOs28lOMQO", false, new DateTime(2023, 2, 28, 18, 45, 20, 257, DateTimeKind.Local).AddTicks(4635), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("67b293a9-b60b-4905-9639-e1f4dcd147a5"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$zxlB/IGWY00zNm.Wjoug8.JdPQi6KtysHus85.ijQ0vjh3pZUrP2K", false, new DateTime(2023, 2, 28, 18, 45, 21, 406, DateTimeKind.Local).AddTicks(3741), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("6b1009f0-0891-4f24-adbc-ab5d4d99c887"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$9k/qSITYMYMl9v04b04PHeBraZogsbieAGjwYct8L9EhNagYuZUwe", false, new DateTime(2023, 2, 28, 18, 45, 24, 221, DateTimeKind.Local).AddTicks(8967), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("6dbb7ee5-be5f-4b2c-8503-0f4f71db2736"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$PPrUMdzBbx50NBfEoNCT6.HeyzBp7zYzN23BKAPAuJibNp.E5wLxu", false, new DateTime(2023, 2, 28, 18, 45, 20, 69, DateTimeKind.Local).AddTicks(8916), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("7219132c-cbaa-46c6-a248-9f082f5ae1a6"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$ns/WtomQsp5JpdMvuP6HpuWavaAdB1swe9KsztwHPx.L0bXmhBkfC", false, new DateTime(2023, 2, 28, 18, 45, 26, 233, DateTimeKind.Local).AddTicks(4535), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("72542dbe-3d42-4463-99cc-9f1eb5080206"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$l6m2Bytt6CJZo52e2CSbyOtKU2.UOerghYeokmf5YpufxJudFFjFO", false, new DateTime(2023, 2, 28, 18, 45, 25, 61, DateTimeKind.Local).AddTicks(5360), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("72bd0437-4534-480c-a832-2c6fda735931"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$relwZWzCt.C4sjJOJ0iZGeyulkl0HWoeqNF8mOeXHIrr.At17i49i", false, new DateTime(2023, 2, 28, 18, 45, 24, 811, DateTimeKind.Local).AddTicks(7803), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("731b146d-5ff4-46d4-a08b-df92e9d2f23d"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$Re0ZFfI6lZm6giPzhXdi6eqjyqNYbe2s/u40mxNpe5QVcIaKvfr96", false, new DateTime(2023, 2, 28, 18, 45, 23, 290, DateTimeKind.Local).AddTicks(5707), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("760897e9-6d2b-4398-83c7-905f52181e9e"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$7HnPvF9go.x/E..Jeleeb.X7LM.Li/SExvHQnyWr/mGB0pBYrRCx6", false, new DateTime(2023, 2, 28, 18, 45, 24, 585, DateTimeKind.Local).AddTicks(7862), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("76e088a9-7068-4ab5-9f8a-4e0a46e38ae8"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$/KX/uDu6FEFQnPQ9/kERr.NKXxNi/owfjEUb47P6DLJpkLudkeytK", false, new DateTime(2023, 2, 28, 18, 45, 21, 334, DateTimeKind.Local).AddTicks(1287), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("7b69f4d4-bc62-4c20-b2c5-f7c150b2cde9"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$qEPdBKw8aC72fIb.3bfC1Om87dN2qP8m1ieDenIBFShcJO2ZHiNVG", false, new DateTime(2023, 2, 28, 18, 45, 23, 811, DateTimeKind.Local).AddTicks(8922), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("7b7a537c-3092-4fcf-9ac6-5f6910e0c76f"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$q4L1NM.y3R6O5J1iHRG8feNQ6xywYFuH1/flUIHcz/Rl2VEsWVJ/a", false, new DateTime(2023, 2, 28, 18, 45, 23, 882, DateTimeKind.Local).AddTicks(9317), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("7d963b6d-c93a-4f13-be14-94cd4a8bfaae"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$bj0yWSBx6FeP.Zps15kyzeBcjrhifWnAma8Xp3LETEspO36MISAfO", false, new DateTime(2023, 2, 28, 18, 45, 26, 160, DateTimeKind.Local).AddTicks(9554), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("7db64fd2-6573-49fd-8b72-54a00629af1d"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$yDLTeaOerGVFLVrGN.UV/.veLrcnriR1lCodDL/RBUytQW3dd.UaK", false, new DateTime(2023, 2, 28, 18, 45, 26, 84, DateTimeKind.Local).AddTicks(5624), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("7ffe1127-410a-4c46-bfd4-268d23671f84"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$GmRMB.mntAWS5FheNtiaReJ/8n3JPW9zHKjyRmqnSDENjxhYaHspG", false, new DateTime(2023, 2, 28, 18, 45, 26, 307, DateTimeKind.Local).AddTicks(8144), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("821a7a00-0d04-4b12-af59-baf954ad57c4"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$7BJn6UPL0h/s84OUr9pga.UWQ/hW0bIAgfgoECt97x2kdtLwuV/PW", false, new DateTime(2023, 2, 28, 18, 45, 27, 19, DateTimeKind.Local).AddTicks(335), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("83999874-4092-436d-b316-36169204aab4"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$bhW3SAVNjgF7m.YL5E6fsuG0CmXFCe9RWofAndJofZGDNUMJGvN9a", false, new DateTime(2023, 2, 28, 18, 45, 21, 480, DateTimeKind.Local).AddTicks(5406), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("83c4f6f4-6743-4657-b1aa-a4d79353e017"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$L..tOeqGpDAeOoumDxsNmehfi7cR6JTA5T77CPpT53zl5/CaV2CWW", false, new DateTime(2023, 2, 28, 18, 45, 21, 979, DateTimeKind.Local).AddTicks(2947), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("842c9b25-c485-4787-a2a9-c152a6478102"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$hWl2yZBp1a/2kkFigCHDw.mwaLDpg.SllBmnJ.gW.8kls7Xx/5VTS", false, new DateTime(2023, 2, 28, 18, 45, 18, 10, DateTimeKind.Local).AddTicks(2867), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("8d0f4dac-9bc7-4d4f-9b7b-7804a1e61bd1"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$2hkx6uWMjc9SLXoecjyKf.noaKJ6DegJyGwRu.qbU7ReQ7XJLt0hS", false, new DateTime(2023, 2, 28, 18, 45, 22, 637, DateTimeKind.Local).AddTicks(4691), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("8d4c6c86-af40-4ecd-9aac-11c0ae76a1ac"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$zur1EUrP4e.CW7q7pbJQD.6pnUCYsAOIcuYC3zscxc4x16tgU4sWO", false, new DateTime(2023, 2, 28, 18, 45, 22, 883, DateTimeKind.Local).AddTicks(2736), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("8d52b61a-1c7e-48eb-91a6-4ef86b3ca0f9"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$6LxAdTK2qVQxXTgPgV26ge.oUaeO79wyGuovOnrJjY6w.7USeTyBy", false, new DateTime(2023, 2, 28, 18, 45, 19, 867, DateTimeKind.Local).AddTicks(7822), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("9206731d-8bd3-4850-948c-ed624d217239"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$OudW/.ITJfWtb.YoA86q5.Q9NgPFSbrbvtHPTIOTnPwc31J.2Zfmu", false, new DateTime(2023, 2, 28, 18, 45, 25, 761, DateTimeKind.Local).AddTicks(7087), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("93f7f22f-50e3-4af6-9858-118866cda074"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$ju2vvQfe23kCoXP5sSHsLOf2.iqYcvTBFhXo5b2nnZOFzLp.4rVPi", false, new DateTime(2023, 2, 28, 18, 45, 22, 287, DateTimeKind.Local).AddTicks(7006), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("9a426d9b-f0fd-4866-bef6-c86c8be540df"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$2VDol1Dm1W7TxuFHpficPOnJ64t4KLQ3LnmYbBVEhMvAJt8ztKcsm", false, new DateTime(2023, 2, 28, 18, 45, 17, 633, DateTimeKind.Local).AddTicks(2670), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("9cf77a9a-5692-4ce7-8d30-7cf67bdba063"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$kvyse9kXh2p6rrqeDY8ni.zG1yoBToePpMjpTeDw0nfSeteIVsNEe", false, new DateTime(2023, 2, 28, 18, 45, 18, 181, DateTimeKind.Local).AddTicks(4446), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("9e8c6229-17d7-4c6d-a421-ce8cfad08899"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$VCNhlDNKWk0N7KIMrOz0P.naByDU1i3gwkiNScTOj1N.ZCnsYMD6m", false, new DateTime(2023, 2, 28, 18, 45, 25, 603, DateTimeKind.Local).AddTicks(8767), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("a028db8e-a6a8-4b42-a8ce-bccaf3eb0af1"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$DEm7r6vYJYxjw4FPCnbi8u7EZV.OzCWVYCCqz.yT.V2yrnFvqujWu", false, new DateTime(2023, 2, 28, 18, 45, 23, 371, DateTimeKind.Local).AddTicks(1623), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("a21dddf0-1a92-4475-bc83-f1b3adda43f6"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$E5iTL9TRG9SLPZJ5gnC7oOi4WkJ/X4MyQIY9qzymIZ/JwybUOSuXi", false, new DateTime(2023, 2, 28, 18, 45, 25, 348, DateTimeKind.Local).AddTicks(4792), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("a324f238-f4a3-4810-a2f2-0a49efb67758"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$W/oV6N0dyB9.hsEbjmOqxeogojv/slPHEUTchFpUv.pZ8yYHYY4w2", false, new DateTime(2023, 2, 28, 18, 45, 20, 836, DateTimeKind.Local).AddTicks(4997), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("a44a2164-2751-4440-9f14-e1de9810b17e"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$WyRH3a4q8xSxDH1grJ4FLeU5PHaBeO163GRLLp8/9bEq95Sv0Skqm", false, new DateTime(2023, 2, 28, 18, 45, 22, 955, DateTimeKind.Local).AddTicks(2882), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("a4660baa-1cdb-48b0-9fda-bd7c8e6b5edd"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$LUY1lR5ZSUNeKeUsaWUKBeLQepuYmqS9E8EsJ7KG0kFYhfF3rqwUK", false, new DateTime(2023, 2, 28, 18, 45, 25, 912, DateTimeKind.Local).AddTicks(2149), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("a4e1d5f9-74ba-4390-8986-3bfa6ec3c09f"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$Iig0tPwHpUS0flZYH2akGej4ACIObWq7nS87ZEi623iwq34Nm59mq", false, new DateTime(2023, 2, 28, 18, 45, 23, 213, DateTimeKind.Local).AddTicks(4252), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("a9747d15-fbea-4533-a7ad-25b9301313b8"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$eUhDizTMy1YraIZEgLkPEuFv9fOlmu0ijDFuoY7Jc/f4/.0QjBkG2", false, new DateTime(2023, 2, 28, 18, 45, 18, 607, DateTimeKind.Local).AddTicks(8363), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("aab15be6-d88a-4d60-b765-b7fe79c87b0c"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$JRxEWX26PwMr8.RjqaVnoOQ6s.rzroAErtwiMBhIXyv/15dXxuh0u", false, new DateTime(2023, 2, 28, 18, 45, 24, 135, DateTimeKind.Local).AddTicks(5155), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("ae30210c-8f5d-4616-a1dd-6650cdd1680b"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$7LufmTfZrbNDEqxPGIs7BuOYOQy.Ryct221kTkByrJFZp.XF50m1G", false, new DateTime(2023, 2, 28, 18, 45, 19, 711, DateTimeKind.Local).AddTicks(3255), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("b1419e49-6ac4-4a31-a259-6ef630117221"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$nrKhlMzQcoVZJ4407fMT/.2ahPCsjeXLTE9VVwT6kA.d06E/ylble", false, new DateTime(2023, 2, 28, 18, 45, 25, 687, DateTimeKind.Local).AddTicks(3797), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("b94321f7-dd4d-4e58-b699-6ffb0edd78a5"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$KU0wV3vdslOMQ3OOC5cvoucbOfg2UDAFTY//l4pVCcD0X/ImcSN8W", false, new DateTime(2023, 2, 28, 18, 45, 19, 794, DateTimeKind.Local).AddTicks(9491), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("ba7ede51-fc98-4b75-ab4c-58579c1484da"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$PtkaVL8MGwVioA69UPwg0OBk7NrPN0CKMqECRzs/D.G8o87BLnYfW", false, new DateTime(2023, 2, 28, 18, 45, 26, 859, DateTimeKind.Local).AddTicks(7029), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("bb928817-afa4-48ef-843a-d59db626e2f8"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$3qQ9gCPHLyQaeWqGnoTEgeQhQ1P7xesl44nv5PBzkGUmEkhtN0.Yi", false, new DateTime(2023, 2, 28, 18, 45, 26, 600, DateTimeKind.Local).AddTicks(7037), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("bcfed8b4-1f83-49db-8647-46b1c8f1300e"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$oC6jFhNCLJ1IdaXv2HamEOg.J0GpgfmsMA5unZHgUGJRBChLgRHHi", false, new DateTime(2023, 2, 28, 18, 45, 23, 660, DateTimeKind.Local).AddTicks(4094), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("bd2bd63e-8e06-49dd-9988-ecee83e71ec9"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$u7za8YYX8yxOigAXOwri3.XMm9TUSZNuNK.ZYnMKUM.rR4aeVPwGy", false, new DateTime(2023, 2, 28, 18, 45, 21, 65, DateTimeKind.Local).AddTicks(9889), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("bd645cc4-452f-46b2-8a80-83452571510f"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$LWrcBUaMWgjoGWcsJ8S5O.Pg8T7VqpWAr9U.w1riTmhFdAUhfzVYC", false, new DateTime(2023, 2, 28, 18, 45, 20, 408, DateTimeKind.Local).AddTicks(2180), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("bd8d6bfb-0280-4f14-8d69-592afa8d0b7c"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$M2/W3pJGeN6fkPk2LBRiAubsrMjZjCOydeN8JB76UDqAU2RG8bIdK", false, new DateTime(2023, 2, 28, 18, 45, 24, 315, DateTimeKind.Local).AddTicks(3577), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("bfe99e9e-7511-4a60-b8cc-372068f2f3ab"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$yvTiCMYs1tul5jdSCJC4du1AGfwYItHjG.RoDgED2zCOqTP3a0aTm", false, new DateTime(2023, 2, 28, 18, 45, 17, 731, DateTimeKind.Local).AddTicks(3381), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("c620fc8d-0f94-40fb-a498-4644be014dfb"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$oRTsWCIuKFZaSS0dE.B4Qu9eAmK2ZMR.Rd.BYsELpAM0MDSDSgAXy", false, new DateTime(2023, 2, 28, 18, 45, 26, 761, DateTimeKind.Local).AddTicks(2610), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("c6f66cc0-34a8-4579-829b-d88ec7d829bb"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$byqN15Uf7/Da93zBtDBCEuuy3TlRaEreoI9ecfWPcnHmb.vS3eYym", false, new DateTime(2023, 2, 28, 18, 45, 18, 857, DateTimeKind.Local).AddTicks(9750), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("c7976191-c38a-47e7-928d-7cc8a2423363"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$3i7s2Ad.iT7TCUmqHoiJO.VLjMGJVr13RY1RJQH5zxJrKnRFLZpxG", false, new DateTime(2023, 2, 28, 18, 45, 19, 170, DateTimeKind.Local).AddTicks(6094), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("d12f77a1-dba6-4a2b-9963-e48e28571cf3"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$HfPrFRS8QFvXXTQ1s60hJusb0DQM2lgj3Wqhb8lAd7GWVNtxjhXUy", false, new DateTime(2023, 2, 28, 18, 45, 17, 924, DateTimeKind.Local).AddTicks(3650), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("d29793a6-d00d-42f7-88e4-0fb026bae913"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$uhcF56JRKw6TBxWiX3MVou5gIr.q4omA41mSyVAEWEnPM1D0gZhpu", false, new DateTime(2023, 2, 28, 18, 45, 20, 751, DateTimeKind.Local).AddTicks(4965), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("d358986d-5eae-462c-b729-6bd3d82d3c26"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$.VN3AGu3JySCRWl4qAZEWexXBJo0P8dsQq.0u1LvfZY1AHGMBHHWK", false, new DateTime(2023, 2, 28, 18, 45, 25, 255, DateTimeKind.Local).AddTicks(8855), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("d6c1ebbb-9a8f-4871-b665-02b20eb32d22"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$CH.xCged4NPg1vGLHNKvoOxDFefX0wcERaTPyzRR0xaX/rVjma7gi", false, new DateTime(2023, 2, 28, 18, 45, 19, 85, DateTimeKind.Local).AddTicks(8836), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("d94953fd-2a90-4486-a48e-3a6012269ea9"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$NE.SnklW9LkJ/WyT9hMUgeQA1ynSdCx027sh7VHNwMhlsHmTmxECK", false, new DateTime(2023, 2, 28, 18, 45, 21, 660, DateTimeKind.Local).AddTicks(4090), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("e7310940-404b-4cbb-b5fc-5dafc0c07b8e"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$IyEJyoQpY1BxNgsX5X83kuja.uglkjLxpUsfZzVEd6VrVHBmSVTiu", false, new DateTime(2023, 2, 28, 18, 45, 19, 2, DateTimeKind.Local).AddTicks(2090), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("e7c668d7-4be9-4a5d-b739-c7cbd942d048"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$HneeY.8AaWz/tWh/hkDyhuJoLFOZ873UC5H43r1khNr3akxmdk6oO", false, new DateTime(2023, 2, 28, 18, 45, 19, 395, DateTimeKind.Local).AddTicks(256), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("e9c1fda9-2ec9-4494-b4c6-a7abbf99e82c"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$9tSwJX3T7h/5HHOOI1jnPeA2avmE9K8mbQoNmwOPakqtf1jdS9N2G", false, new DateTime(2023, 2, 28, 18, 45, 22, 726, DateTimeKind.Local).AddTicks(1762), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("ea90b947-f70a-492a-90c7-fd2fce60fa5c"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$Xltrqoz9m7uGXkSD4dMNxuFMXokMaC1q.lWtTXSLtXZitvElZDss2", false, new DateTime(2023, 2, 28, 18, 45, 18, 329, DateTimeKind.Local).AddTicks(625), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("ebe7ad88-52b6-463b-95af-745a3b8565f4"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$mX99FvhTKoB2u9uyvJTv6u8F4EBtc8ekyIk6BpPkNvQtdFEFvzkn6", false, new DateTime(2023, 2, 28, 18, 45, 23, 740, DateTimeKind.Local).AddTicks(5791), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("ee37248d-5587-44c1-b290-68329eb59922"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$1/n6cUDngWlQxa9AFlBSvuQRe7SMOMIVhLR9DlcMGoXE8yFxKsnC.", false, new DateTime(2023, 2, 28, 18, 45, 25, 431, DateTimeKind.Local).AddTicks(7771), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("f1b09906-3ae4-4fe8-b4ef-1d47a8452c20"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$v5ftpAgjxZikdT/kjdEjdOppdUqGFKFPiQBZcE0DcraY3VMYca4Pq", false, new DateTime(2023, 2, 28, 18, 45, 22, 202, DateTimeKind.Local).AddTicks(132), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("f4800f74-79e4-4a6a-bf87-31ece71f5b39"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$nQsn/HQjvI3a870hE02h.O1R1/L9NvHiOtyVvnkbYzDAPd0p.o0Fi", false, new DateTime(2023, 2, 28, 18, 45, 18, 699, DateTimeKind.Local).AddTicks(8954), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("f48c56fd-92b9-48bd-982e-b53d51506680"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$grxBV7PMX/PwVbwt47pKB.zDqXmKn/XX88k9CkmuaMYpPmN0F2stO", false, new DateTime(2023, 2, 28, 18, 45, 23, 545, DateTimeKind.Local).AddTicks(208), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("f6218bf2-85b6-4b7b-ab9a-531c53be9daa"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$ejTdRJhqibVp9ZpNogrAmunRfnGoT4KUFClqTEHvGRDGSf6nvWkza", false, new DateTime(2023, 2, 28, 18, 45, 20, 956, DateTimeKind.Local).AddTicks(3715), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("f6221bd8-ecfc-4b2f-9da0-f355c57a49db"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$2e6QaExiTOd.gtyrGr9Sp.BURihLCxkQHzNTY0og/k1iOzgvNUa/.", false, new DateTime(2023, 2, 28, 18, 45, 18, 508, DateTimeKind.Local).AddTicks(1628), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("fa3436e2-2af8-4994-9cce-a4db4859301d"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$Ae7bf7ngyDJvT3rMVtl6K.dkacIkTy/CHgqOT6Q2o8XwdqoV77XHu", false, new DateTime(2023, 2, 28, 18, 45, 24, 440, DateTimeKind.Local).AddTicks(6742), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("ffae8af6-a943-434b-915e-7f63e31e759f"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$o4ucE1Kxz2D4F/d4tayJK.jDO7.RaVcbAAaFeMDbonh5kH8wrkCSm", false, new DateTime(2023, 2, 28, 18, 45, 22, 467, DateTimeKind.Local).AddTicks(2261), "Mackieson", null, null, "07046670689", 2, "smackieson1i" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Slots_CarModelID",
                table: "Slots",
                column: "CarModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_CarModels_CarModelID",
                table: "Slots",
                column: "CarModelID",
                principalTable: "CarModels",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slots_CarModels_CarModelID",
                table: "Slots");

            migrationBuilder.DropIndex(
                name: "IX_Slots_CarModelID",
                table: "Slots");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("2f985036-fe37-4676-88ec-c08505c43aaa"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("6fa0be83-8a60-41cd-8d22-f5e2f73b97f2"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("7dbd726f-1e99-41cb-8ee3-15bb2a2b38b5"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("9148302b-5b38-4799-95e8-aed413e20d3c"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("9ed67ad3-c592-401d-ac7c-2a279e739b05"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("a66d1a77-f0d7-4883-902a-1bf4f11dff45"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("42d7c65d-4c4f-49b6-b53b-e138a70ad12a"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("584afdde-5425-4249-a7aa-12b9fd7d34f5"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("95a05634-6125-4690-808b-c0f2257c766d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("00c65788-e629-4a37-9cfe-19f4f3e1e114"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("02b21902-41fb-4e6f-850c-12578907ff9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("02c36ff4-ad1d-4ab2-a397-c6f048b914c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0916ab52-1003-4aa4-bbb1-bbdac53f7053"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0c7d1a00-ffab-478b-b70e-6059f528c65b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0e7f03a5-9e08-49a5-a571-74b5d32af111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("11390c58-73ce-4e93-8d71-f063451e26c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("12f4baee-3f73-4020-9836-301564bae113"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1460fe16-bb67-408c-bc34-01c5818afb71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17670509-00fc-4926-b224-8710692cf76e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("183c7228-8df7-46ac-b376-95a6c4336b28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("18514da9-e0ac-4c2e-befa-6fa24f55f306"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1866008f-f610-4e93-86b0-970652c0340d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1bfb84d8-d3da-42d2-b673-b5696df88619"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1d42d5b1-6ab5-4d6f-a6c9-85ad22941684"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("218608c6-a754-4964-bc2a-8ad79bce2386"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2458743e-e234-4a20-bd2e-038fe1e68ead"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("254b3a0d-a33b-4e7a-87ec-1ae472aff70e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("25dbebf4-151d-4714-b36c-8e650c631311"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("29c83a68-91da-4b72-ab02-450885c4f68f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2af992b3-45a8-49c2-84d4-07a99635419f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2d2771d8-6a3b-405e-9719-c7fdaf004581"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f1f195f-78f3-4cfd-adca-37628a909511"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f57a17a-3631-493b-91d4-c35cc2a5c243"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("32fa8ee4-a87c-4df0-a02e-a7ee63818f9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3489d3d6-8f15-4f6d-bb1d-dea069b13c5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3601337c-9f07-4192-9a37-33f8e611b34e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3cfe45ed-b90d-4b93-ba00-11987375b2bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3e69b936-d39a-42d4-84be-f2afb69cedd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("42ea9a19-eb13-4f52-9e8f-c0a2462202ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4432c978-c4a4-464b-ba1d-e5c9a6a5e7de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("468b29ca-4a1f-4586-82ca-effeaf579bc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4a29b6ae-abd6-44e8-9fc7-906a3b26e1ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4f6f47fb-5762-4b15-89f9-b516155141e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("50e34142-4ae8-4785-b413-e1de3dcf2e74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("53f52ee5-c74f-48d4-90de-f6d48dc3c7a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("54c0a688-b087-455d-8a29-a2ed01b63c4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5559a5e4-c8b8-46b4-9588-82c14883eb8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5885f657-6c82-4cda-807c-1ac1642fdea3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("593ef50c-9686-4d3a-a913-2ed3d59d4973"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5a3dbb3b-25d1-48d2-8f3e-1eeb612e9fd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5bb6e190-1744-4e0c-8519-5fd60cef35f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5df6b22c-9383-48f9-b9e7-68c4ecedcaaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5e7aac65-ad54-49f7-ae09-96e053784701"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5efcc8ad-fa40-45c8-92e3-38f5b6aba7bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("61abfbe0-0ba5-4c2f-ab03-972ca135b5bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6353da16-36e9-4198-bc35-8be8faf21b5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("67b293a9-b60b-4905-9639-e1f4dcd147a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6b1009f0-0891-4f24-adbc-ab5d4d99c887"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6dbb7ee5-be5f-4b2c-8503-0f4f71db2736"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7219132c-cbaa-46c6-a248-9f082f5ae1a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("72542dbe-3d42-4463-99cc-9f1eb5080206"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("72bd0437-4534-480c-a832-2c6fda735931"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("731b146d-5ff4-46d4-a08b-df92e9d2f23d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("760897e9-6d2b-4398-83c7-905f52181e9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("76e088a9-7068-4ab5-9f8a-4e0a46e38ae8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7b69f4d4-bc62-4c20-b2c5-f7c150b2cde9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7b7a537c-3092-4fcf-9ac6-5f6910e0c76f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d963b6d-c93a-4f13-be14-94cd4a8bfaae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7db64fd2-6573-49fd-8b72-54a00629af1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7ffe1127-410a-4c46-bfd4-268d23671f84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("821a7a00-0d04-4b12-af59-baf954ad57c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83999874-4092-436d-b316-36169204aab4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83c4f6f4-6743-4657-b1aa-a4d79353e017"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("842c9b25-c485-4787-a2a9-c152a6478102"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8d0f4dac-9bc7-4d4f-9b7b-7804a1e61bd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8d4c6c86-af40-4ecd-9aac-11c0ae76a1ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8d52b61a-1c7e-48eb-91a6-4ef86b3ca0f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9206731d-8bd3-4850-948c-ed624d217239"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("93f7f22f-50e3-4af6-9858-118866cda074"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9a426d9b-f0fd-4866-bef6-c86c8be540df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9cf77a9a-5692-4ce7-8d30-7cf67bdba063"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9e8c6229-17d7-4c6d-a421-ce8cfad08899"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a028db8e-a6a8-4b42-a8ce-bccaf3eb0af1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a21dddf0-1a92-4475-bc83-f1b3adda43f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a324f238-f4a3-4810-a2f2-0a49efb67758"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a44a2164-2751-4440-9f14-e1de9810b17e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a4660baa-1cdb-48b0-9fda-bd7c8e6b5edd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a4e1d5f9-74ba-4390-8986-3bfa6ec3c09f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a9747d15-fbea-4533-a7ad-25b9301313b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aab15be6-d88a-4d60-b765-b7fe79c87b0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ae30210c-8f5d-4616-a1dd-6650cdd1680b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1419e49-6ac4-4a31-a259-6ef630117221"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b94321f7-dd4d-4e58-b699-6ffb0edd78a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba7ede51-fc98-4b75-ab4c-58579c1484da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bb928817-afa4-48ef-843a-d59db626e2f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bcfed8b4-1f83-49db-8647-46b1c8f1300e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd2bd63e-8e06-49dd-9988-ecee83e71ec9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd645cc4-452f-46b2-8a80-83452571510f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd8d6bfb-0280-4f14-8d69-592afa8d0b7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bfe99e9e-7511-4a60-b8cc-372068f2f3ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c620fc8d-0f94-40fb-a498-4644be014dfb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c6f66cc0-34a8-4579-829b-d88ec7d829bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7976191-c38a-47e7-928d-7cc8a2423363"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d12f77a1-dba6-4a2b-9963-e48e28571cf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d29793a6-d00d-42f7-88e4-0fb026bae913"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d358986d-5eae-462c-b729-6bd3d82d3c26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d6c1ebbb-9a8f-4871-b665-02b20eb32d22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d94953fd-2a90-4486-a48e-3a6012269ea9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7310940-404b-4cbb-b5fc-5dafc0c07b8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7c668d7-4be9-4a5d-b739-c7cbd942d048"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e9c1fda9-2ec9-4494-b4c6-a7abbf99e82c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ea90b947-f70a-492a-90c7-fd2fce60fa5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ebe7ad88-52b6-463b-95af-745a3b8565f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee37248d-5587-44c1-b290-68329eb59922"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f1b09906-3ae4-4fe8-b4ef-1d47a8452c20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f4800f74-79e4-4a6a-bf87-31ece71f5b39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f48c56fd-92b9-48bd-982e-b53d51506680"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f6218bf2-85b6-4b7b-ab9a-531c53be9daa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f6221bd8-ecfc-4b2f-9da0-f355c57a49db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa3436e2-2af8-4994-9cce-a4db4859301d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ffae8af6-a943-434b-915e-7f63e31e759f"));

            migrationBuilder.DropColumn(
                name: "CarModelID",
                table: "Slots");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0fae940b-9d05-4a84-9ece-b616e6591ff4"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("17b6c38c-7e7a-4d78-b120-cfb0c7e52e71"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("1b202270-a576-4e97-b65b-b59515306046"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("2469ac8a-95c5-4830-8635-1b960af98040"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("2738ee91-9d70-49ec-89a8-e7016ac5e65b"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("7f752060-b813-48f5-a111-102288c2c667"), "Xe van con", null, null, "Minivan", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("85f8e0e6-c985-4c98-9e8e-3ddc8a75aa6d"), "Short time", new DateTime(2023, 2, 24, 16, 33, 43, 40, DateTimeKind.Local).AddTicks(3538), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97bbdcfa-0de6-412f-9fef-31c7b71331ce"), "Half Year", new DateTime(2023, 2, 24, 16, 33, 43, 40, DateTimeKind.Local).AddTicks(3543), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2bdec44-a613-4d77-a3de-6d1c06ffec86"), "1 Year", new DateTime(2023, 2, 24, 16, 33, 43, 40, DateTimeKind.Local).AddTicks(3545), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("0022fd4d-df34-4b30-b932-2b1de17ae834"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$bJ69VgmC0B9kKXcchsivkeNWC/AbHi2y9juhaO1BKgMkTsmk1FnJ6", false, new DateTime(2023, 2, 24, 16, 33, 34, 75, DateTimeKind.Local).AddTicks(8047), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("0426ce6f-4854-4d3d-a893-54589c03516d"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$NSsGqY6.GD8R8QpGpU7e3.q32Hl7b3LW/.1KyokYycYM1fe4KBW9y", false, new DateTime(2023, 2, 24, 16, 33, 35, 129, DateTimeKind.Local).AddTicks(5529), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("06081c76-34c5-4eea-938c-99991f358c77"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$AqY9WByQN4Wrf0yqcs/UHOhijzFvr7ISW.zZ1Bn/M3mTZnfGeBjzW", false, new DateTime(2023, 2, 24, 16, 33, 40, 126, DateTimeKind.Local).AddTicks(9490), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("0b8a09c7-abd4-47ec-a95d-b2f6abbb7d2a"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$BufoW3c6teR7jdHBUP3V4uQ6IN2Au48TKLJTjh.cu0aFOfLVRtNfu", false, new DateTime(2023, 2, 24, 16, 33, 32, 892, DateTimeKind.Local).AddTicks(8725), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("0dc4b0ea-769d-4a4f-9f4b-b7cc63837ea0"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$eBNoJJbLCulx0Ux6hP3bO.J6CzOoM6w5hpseCXfB0e2ZFOZWjxwbC", false, new DateTime(2023, 2, 24, 16, 33, 36, 971, DateTimeKind.Local).AddTicks(6575), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("0e1541c6-7a53-4553-8436-e464dd0fc76e"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$KlDZMhLN.qbqthZBKAoLxe/6Ot637x7EPcGVFj3Vz7dofNORWbx3e", false, new DateTime(2023, 2, 24, 16, 33, 32, 283, DateTimeKind.Local).AddTicks(2915), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("0f6e0bf3-cd4c-4fb0-bda0-a91e6af44ef8"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$8QeqexvRrkJtop6gRbfwdeLmqzmuoIYzA8Xl4JB3wvxsPVh7LGZjG", false, new DateTime(2023, 2, 24, 16, 33, 33, 875, DateTimeKind.Local).AddTicks(3843), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("0fc4b91a-b9c1-4600-aaba-e990b580e041"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$v10S4jZOodxLSyQ50AEppecanvalOz/Cun8l9ebaHWEKXyQGwSPRG", false, new DateTime(2023, 2, 24, 16, 33, 41, 746, DateTimeKind.Local).AddTicks(2877), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("108b1377-bcb4-458f-9bd9-c1bb7e60d5e5"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$.jLGifAjUnN164x6Wzb/SeLV3w.PA7/kSJR1DrAUPzISgRLhiieGW", false, new DateTime(2023, 2, 24, 16, 33, 40, 744, DateTimeKind.Local).AddTicks(8133), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("11e85125-73df-4085-8be9-f0bd01ff9ecf"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$KzJuArypbc1lOOGWlQdHmeKtJY0Tyx9vhThlPilYgbzVWc7KsRoue", false, new DateTime(2023, 2, 24, 16, 33, 33, 442, DateTimeKind.Local).AddTicks(7163), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("15e3a4d1-2feb-465b-ac16-9e082e1f26bf"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$wHM/MkH796934MbG8BhJe.TDWho4BCdx0gSBOB1jF7j9b8Gbx9tbm", false, new DateTime(2023, 2, 24, 16, 33, 37, 114, DateTimeKind.Local).AddTicks(7551), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("165d3abc-37f9-4834-9477-b6c5965d68a4"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$YAELnIbmBVCJD2kSheL74.Qd.Jqnc6CwzT7dJZGrq3wonJIG1qVPa", false, new DateTime(2023, 2, 24, 16, 33, 41, 454, DateTimeKind.Local).AddTicks(1403), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("190554ce-91af-4dcb-b87e-0a991808463a"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$NORVCeaCrcs7CmN02h2P5eQ7jaZDhIDwnmdPNBiIze2IHQa3JiGbi", false, new DateTime(2023, 2, 24, 16, 33, 39, 260, DateTimeKind.Local).AddTicks(904), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("1a0d4c24-eab9-4397-96f5-0cf032bd11bc"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$5eHCa7PAaN7ce9ehpraul.WO3yADBH.KZ04ppsyq9uNO.9fNIUbjO", false, new DateTime(2023, 2, 24, 16, 33, 33, 319, DateTimeKind.Local).AddTicks(1017), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("1b2ce735-e724-484a-ae36-2352d9d1cfeb"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$anwXkcxKT/puKbur06NMzebP6vJhwed9TRhjlkl8LjekbYU.6nXBK", false, new DateTime(2023, 2, 24, 16, 33, 36, 437, DateTimeKind.Local).AddTicks(5596), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("22bb2f57-a23a-4940-b2d3-26ee696bac28"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$jAAHWs2nUvkA5atD9JYnR.iTXv8vP2D7kygB8tcCNjE.pOYYIMil.", false, new DateTime(2023, 2, 24, 16, 33, 42, 958, DateTimeKind.Local).AddTicks(7397), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("235e37e2-90df-4e84-820b-d43fdc5f196f"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$QLsfVaHuW4.91jeV2VHFl.2nZZh9SepyijUhr5slgDPCKvOYmusP2", false, new DateTime(2023, 2, 24, 16, 33, 34, 370, DateTimeKind.Local).AddTicks(9961), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("24a4f099-35c1-459e-bde4-cd2cab275ceb"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$UUWUcfp5bbPNIwSinir10eSLhqp0ufqj/tWvvpGpD5adhZw8eJUrC", false, new DateTime(2023, 2, 24, 16, 33, 38, 744, DateTimeKind.Local).AddTicks(6676), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("250c0b1f-78b7-4c71-9a54-2b402b1d067a"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$d1mkh5XXKG4lXFVgd7q0A.0ZK0sA6qTzkwQWGztMvT1RWLEFAwrSa", false, new DateTime(2023, 2, 24, 16, 33, 36, 101, DateTimeKind.Local).AddTicks(9525), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("2604e1e0-8515-4f84-9727-5b18afd9bca6"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$sBK0034IoQTGiMWeFpH7Cutp8xKvwV7AOF4FQ00V1Bq1LIPXkeiO2", false, new DateTime(2023, 2, 24, 16, 33, 41, 657, DateTimeKind.Local).AddTicks(3415), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("2889d190-c0d1-4660-a65c-0a905ce8daa6"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$bmaUgOaKy6yWldkNo2QBqeiahZDlwryn5ffsG8pO5svFn7h0lUZP6", false, new DateTime(2023, 2, 24, 16, 33, 41, 836, DateTimeKind.Local).AddTicks(9675), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("2b5ca429-06f8-4b6f-9850-c8b19f669057"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$AB4qv6kXdOntxQUCIHRrdOoo6FTKxGuC/pn8uEJ5oqoItovn7fcHe", false, new DateTime(2023, 2, 24, 16, 33, 32, 696, DateTimeKind.Local).AddTicks(1917), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("2de7a31a-d1ea-4ec4-bdcd-92a6244a41bd"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$mZGE4siBsnFAWzsvjcqrL.pVW.pt5TiZ6t21NqTNyHED6vkqdNShW", false, new DateTime(2023, 2, 24, 16, 33, 39, 710, DateTimeKind.Local).AddTicks(8352), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("2f9b4f93-8225-402a-9f62-3c634058fa55"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$Q7IjT5kU1nl06mdSBrjxxuGb55kb6FH8pnE.U9itYjbMsOhfNoIbK", false, new DateTime(2023, 2, 24, 16, 33, 42, 94, DateTimeKind.Local).AddTicks(2365), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("2fe8ba23-81af-4e45-a501-b5f1db2e2ef9"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$J6wtfMOMyutgUNsX1ItgvuHrkpvyyFtnEkSbQXPdkE54dHbFC/IKu", false, new DateTime(2023, 2, 24, 16, 33, 34, 880, DateTimeKind.Local).AddTicks(6937), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("35a7f86d-d57f-4f1c-819f-e849a17b09c5"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$c3XiKRssdgb3l0FiWzhMKev/uWEkw/JQ6M7yxz8xNiPBwEse7GpNu", false, new DateTime(2023, 2, 24, 16, 33, 37, 832, DateTimeKind.Local).AddTicks(3471), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("37386abf-580f-4b94-a3dc-685c4aadc062"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$UVuqJ2f0mBYFeY2aeos5buWa0Cu0ml0OhP3c1EQ4ZLAOQOM99Bn2e", false, new DateTime(2023, 2, 24, 16, 33, 32, 591, DateTimeKind.Local).AddTicks(297), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("3765557a-e34e-4e70-8fbe-fba1870d3c32"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$1FjQk00ATOVytdrKcQHCvukMUcH.jaLIz5OMrsF3Kl5SkwO9.keMO", false, new DateTime(2023, 2, 24, 16, 33, 37, 562, DateTimeKind.Local).AddTicks(1472), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("377f6b9f-0b71-4605-8ab0-2669c3e82bbd"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$/TY0kftt8VmMYT1YG49HT.s3W4y8txrl.Y0Mjj0SFKkouvxiy3N7C", false, new DateTime(2023, 2, 24, 16, 33, 35, 225, DateTimeKind.Local).AddTicks(4486), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("3bdb5293-3d67-425a-bc32-73117a657482"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$3HaMwvSbiED23BcOtzJ1ce9abrkNKDD/LardQuA/LSYFV9xxUuEZi", false, new DateTime(2023, 2, 24, 16, 33, 42, 639, DateTimeKind.Local).AddTicks(6309), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("3d3b7946-8cea-4bdf-ae67-9157ea969116"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$C6xq9wjsKmFoLS.M35TJ2esXrxD06mL2UcBj7qNEf6Om6iDtUm3iS", false, new DateTime(2023, 2, 24, 16, 33, 39, 429, DateTimeKind.Local).AddTicks(895), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("3d985924-5e1d-494a-abcd-7ac00e795c39"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$xwEPOBpvDjphsJnHB4b0d.R8l5FH0aR22X6G/OccGbKxMWOgD6Tg6", false, new DateTime(2023, 2, 24, 16, 33, 38, 568, DateTimeKind.Local).AddTicks(3726), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("3ddc0f27-2fc7-4d31-be12-3674ec4c40d5"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$qU9jmBkJ0axoKoEQf6U6FufzUtTZ1VhHgtd//5uM.5s3ygvtE0qj6", false, new DateTime(2023, 2, 24, 16, 33, 35, 898, DateTimeKind.Local).AddTicks(5832), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("401f4aed-1de8-425c-992d-83a9c62c7a1d"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$Fo9aHzq5wEbyJGB3Nweeeur.vsg6CwbNMlvu04dwRua0/fheuW.TS", false, new DateTime(2023, 2, 24, 16, 33, 35, 322, DateTimeKind.Local).AddTicks(9577), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("40b272ea-cb08-467f-92c3-6ff21094098a"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$Xw3M8Kp2AuajxvlCVLMOHuqNhWReVT0Y8ZD4zFTiDHZWOex9RH6um", false, new DateTime(2023, 2, 24, 16, 33, 33, 768, DateTimeKind.Local).AddTicks(4282), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("414756a2-b5e7-43f2-92ed-b9acb5f514b9"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$FDdVcVlCgnB5ISr22iB.KOBeA6jX7h/BzuBD3KV3Gc2cSsBz2D8lm", false, new DateTime(2023, 2, 24, 16, 33, 42, 880, DateTimeKind.Local).AddTicks(3926), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("430a978f-3def-4ba7-8535-e3eececf011c"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$8xcePv1yn169GXeQe0VnPOddK.CwDC2hwgtxzkSvIzF0GJDgtrXVG", false, new DateTime(2023, 2, 24, 16, 33, 41, 924, DateTimeKind.Local).AddTicks(8466), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("440c13b2-504b-4741-9c50-2a21731a48f3"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$fwHGS6vnarifgBMI05ZEZOqY6aHRk57/q6S3S0AjwnDqZZnTD7MP6", false, new DateTime(2023, 2, 24, 16, 33, 33, 209, DateTimeKind.Local).AddTicks(8019), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("4513b3a1-4447-437d-a23d-3018fc094250"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$5RpXdPIKEAocpWXLhYKUDe.tpJBDJnHEL0/U0nL3Vh2qRcHUOaxVa", false, new DateTime(2023, 2, 24, 16, 33, 39, 7, DateTimeKind.Local).AddTicks(1431), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("47080f7e-43ef-4eb8-8896-becb5ab59f5b"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$h8OVFTHd0Y/2QUjTMZPCruy2BcsMd.tffGwQKfGFq3yWnfvfKLIkS", false, new DateTime(2023, 2, 24, 16, 33, 41, 187, DateTimeKind.Local).AddTicks(2467), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("4747ca34-dcd0-4969-b2b0-b21771229172"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$WP1TaEwsGNL0d3cG.tlF7.KKYXFa8yzRGbgi2aGLhHybf.UCR20Ua", false, new DateTime(2023, 2, 24, 16, 33, 35, 47, DateTimeKind.Local).AddTicks(5405), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("4b6b829d-3980-407e-8641-27d10d050c3f"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$iAHaPLmt.SzkzJ5EljttD.5i7..pjBhAF9MMX9kxVcLGjZ2C9dLKy", false, new DateTime(2023, 2, 24, 16, 33, 40, 835, DateTimeKind.Local).AddTicks(7166), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("4e3795b6-5461-4ae4-ad06-cb5282745f7b"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$lRiqzNZ4LNNhk5xvu6gBOOOgyuiNs.zJzGqpz4a053RzcRtsGEaUa", false, new DateTime(2023, 2, 24, 16, 33, 34, 268, DateTimeKind.Local).AddTicks(3777), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("4fe0e50a-16ee-46aa-a6f1-9010bda715d9"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$6PIZ5GC91Og6/aMI3DOsveWDzDNnkLCUG5rTu0gHSRRXzsOBbY2lG", false, new DateTime(2023, 2, 24, 16, 33, 36, 297, DateTimeKind.Local).AddTicks(4356), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("5080792d-6ed5-4894-80aa-3404c09f2f71"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$jOtP5f0pDc1YP5jRas06LuIJXryqMG1Wa92oKVKWuD/x2PgXq5liG", false, new DateTime(2023, 2, 24, 16, 33, 42, 474, DateTimeKind.Local).AddTicks(2036), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("54e0f956-8a4a-4502-a155-2882e5e68766"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$lGiS3AjcR/gf5L8zs9owgeI1zWQcsDiXgYJrwJUFLlHTLx0UVZj7C", false, new DateTime(2023, 2, 24, 16, 33, 42, 800, DateTimeKind.Local).AddTicks(7033), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("5bc4138c-2e61-415d-a385-f0dcd2c09b4e"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$u4wPCmw7hThvelYSWTNof.knvD1.V4L1SsQTeGcohWl6DQVpShvMi", false, new DateTime(2023, 2, 24, 16, 33, 32, 793, DateTimeKind.Local).AddTicks(5418), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("5bda0c0d-8651-4012-84b7-3d67298f40cb"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$vOn3C3sYLzuReCUo2Sm3z.dC.VaVQhNeh/hDcdk144AL7o0PcfK1O", false, new DateTime(2023, 2, 24, 16, 33, 36, 822, DateTimeKind.Local).AddTicks(982), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("5fb1a797-72f3-410c-9072-c9df8d89645e"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$byXZj/PjWKzF1a970Nezsugy/5C5EDo4YsBxVx1raqh/VintSpDnW", false, new DateTime(2023, 2, 24, 16, 33, 41, 6, DateTimeKind.Local).AddTicks(4845), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("6cc0323c-050f-4457-a5b7-2e9113b90fa0"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$UTFC1ux9FuI6a2wFGpYy5uqktudNjD7oOWNdaUprBMUQBXvEIASka", false, new DateTime(2023, 2, 24, 16, 33, 42, 11, DateTimeKind.Local).AddTicks(2742), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("77572bec-cb72-4dbd-a02a-34764d8269ab"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$gW0EIp5UE9N9lSzTLfHBNOdh2WFtZGlMeSMhUBgTuXDCw/xPrd.Zi", false, new DateTime(2023, 2, 24, 16, 33, 41, 356, DateTimeKind.Local).AddTicks(8587), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("779792e4-2699-4c43-b30d-c27029efd866"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$8MVJ.d0MXuXJIoDX4POZweTp3kz.IU09B0vtYiH6Xr72k.Y2.LF/S", false, new DateTime(2023, 2, 24, 16, 33, 37, 962, DateTimeKind.Local).AddTicks(3059), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("79dffd78-298a-442f-b6fa-7152f1e34c7f"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$AohwnMzTJkiOTpcCS6dGTOuOq6x4T/QNhAsWUFzjFulu9PwVk1dwe", false, new DateTime(2023, 2, 24, 16, 33, 40, 297, DateTimeKind.Local).AddTicks(3408), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("7c10cae9-5630-4686-ba8a-440325472c34"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$3LIDlLhju4s5XKKKdBwlbe7930FJneCROzsIOGQO9iyOwcX3Fkiga", false, new DateTime(2023, 2, 24, 16, 33, 32, 173, DateTimeKind.Local).AddTicks(5353), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("8697620e-d49d-47f8-9987-5f8019738ad3"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$Uo97n5NaQjZ2A1OnVDnif.QwMMt2cILOW5/YXT8Z/AOgVftnPNyLy", false, new DateTime(2023, 2, 24, 16, 33, 39, 794, DateTimeKind.Local).AddTicks(3017), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("8b067d3c-5caf-4a3b-aa8a-d56616bc7b2a"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$tIqlSd3gokO1t7onK2kjxusG2EPoIbjQq9Cs3.Q72m3W1TVGpeiLO", false, new DateTime(2023, 2, 24, 16, 33, 35, 801, DateTimeKind.Local).AddTicks(9156), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("93e5b13d-1978-44b9-9f01-0fa954baf3df"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$z/evexZNPF6F4MsNEI1tIujUE5MU31OgKxLkmXH7vmwPZ2NqJqHwu", false, new DateTime(2023, 2, 24, 16, 33, 34, 172, DateTimeKind.Local).AddTicks(5050), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("95ce9058-7ec9-4b83-946f-a776555a9e33"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$.ZHuD9dbAs9m5LVg2YtI8eSkKUoK0yqcJQGoI7ZCu.EMbhnEmOStS", false, new DateTime(2023, 2, 24, 16, 33, 40, 212, DateTimeKind.Local).AddTicks(4594), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("99ad2e7c-b805-42dc-a8f3-e752ade89cdc"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$AZLlKcMp3/N1zrrZGTGxLOW/SYWvQvof6GvxoqouVIVenYIus9.fa", false, new DateTime(2023, 2, 24, 16, 33, 37, 462, DateTimeKind.Local).AddTicks(2674), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("9ab91338-4db8-48fa-821a-74fcc47d1f7f"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$DPHf.hB5hFHgqIHAcI9TuOAmq4BaN1YN3n7wlU2Ljx3qpdyducDTm", false, new DateTime(2023, 2, 24, 16, 33, 38, 271, DateTimeKind.Local).AddTicks(5236), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("9f0bfa15-2b4d-4a13-a0ee-d88bc3a984cd"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$mfg13kogNl3to.URnYq1pOx9VK.O1gkwjfkw9sHz0zv.sC141X1ni", false, new DateTime(2023, 2, 24, 16, 33, 34, 470, DateTimeKind.Local).AddTicks(6335), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("a00dc0de-143e-4b3c-b940-7d54546eb592"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$uq7C2eM6kUQzf4qWjCjFsuLbC1tnAA6ftHbIFMvPhbtCvlNmSxLzy", false, new DateTime(2023, 2, 24, 16, 33, 39, 179, DateTimeKind.Local).AddTicks(7626), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("a38c62b2-ffa5-4c2b-8250-1b0b920302ee"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$huwVTDAYKJckJKdIVjQliubnqQ715t/v4t4GJoIGpqagNQIKeaY4W", false, new DateTime(2023, 2, 24, 16, 33, 35, 999, DateTimeKind.Local).AddTicks(6060), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("a45cb3eb-241d-4365-b61e-c1647b9c2615"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$c9ixAdWA2PvnfW.pgEbUWO1p1OUJFfHsnypHUZ1ENWqlCoyLwrxk2", false, new DateTime(2023, 2, 24, 16, 33, 33, 556, DateTimeKind.Local).AddTicks(4169), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("a5c61618-99d0-4d72-9cf8-2d6b581125bc"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$nR6GbSxgUdYAXnr2D1ykUeLJfcG5Z82M/FgQJJWsjrA4QArICvyPi", false, new DateTime(2023, 2, 24, 16, 33, 41, 273, DateTimeKind.Local).AddTicks(2396), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("ac6714a2-e7ad-4903-bf35-17582bc65839"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$3dMddq91ZGfx/12dvURki.0Id45Dgir3vAMPDGEPdXmihN7MheA2K", false, new DateTime(2023, 2, 24, 16, 33, 34, 965, DateTimeKind.Local).AddTicks(5576), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("b1bb1d27-283f-46b1-9fe9-737730b7d4bc"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$no.SiiLihu059QvMfiqbOuFti7NIwVCq5n4PHJcOPlgfEzU7aSaTG", false, new DateTime(2023, 2, 24, 16, 33, 41, 554, DateTimeKind.Local).AddTicks(6916), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("b2daef7b-00b0-42fb-83be-5cd1c7d0e8fc"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$67Cuw1Cana.jPm51zK.CEuZpJei0DFOGVuDr3sZAKtlZ9JW5TNi6i", false, new DateTime(2023, 2, 24, 16, 33, 39, 954, DateTimeKind.Local).AddTicks(8724), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("b378e7ae-9e71-44da-9936-48f7e982e032"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$D5N5KefUD0jASqvOc354QO0Bqt9uRVqFGSlo/tWnsvWVrGqgj.crq", false, new DateTime(2023, 2, 24, 16, 33, 37, 364, DateTimeKind.Local).AddTicks(9859), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("b786c245-864e-4912-9938-35a2803f92e4"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$hM17o0e8lCpJSMwCiSzFoenU5aLZBlpCpIDiOS3DntbZa37wkVimG", false, new DateTime(2023, 2, 24, 16, 33, 40, 628, DateTimeKind.Local).AddTicks(1089), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("b78f495f-3f4e-48b8-bb09-2728d2fe86fd"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$N5EAeYurzLQQrlSeDAETWe.I1pIWc21IK3ZevdlkmfXhoMWx2rNCG", false, new DateTime(2023, 2, 24, 16, 33, 38, 359, DateTimeKind.Local).AddTicks(8446), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("b7bca624-6e43-40a5-a1e7-6d5534639a40"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$hrgKl6g1opDPOvExN3DxC.TWyLvcV.Vdsx.qJa6UdDhDYN6em9z.S", false, new DateTime(2023, 2, 24, 16, 33, 38, 659, DateTimeKind.Local).AddTicks(1938), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("b9839e7c-1c71-47d7-91e4-5b7e83da0b55"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$.JSQhkYM2hrD6PfcTRSx4.k4QaiCgGR10b5.BbfuoS2AjuexAGdLK", false, new DateTime(2023, 2, 24, 16, 33, 35, 517, DateTimeKind.Local).AddTicks(3306), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("ba4c5f72-df3f-4419-84b2-c8915b4f496f"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$2IL/1XX2nZZ1wEt.CSPLjeT/rh2RA0xKY/vfgoaccxC1Qfr/vjL7C", false, new DateTime(2023, 2, 24, 16, 33, 37, 254, DateTimeKind.Local).AddTicks(6661), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("ba786e63-9e45-4604-a2d3-2dde615ef0a3"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$mug/8MzzF4QJIJkMMh.6U.msO2JHcMmOiyUkBaOTbzoBJevEr13Zi", false, new DateTime(2023, 2, 24, 16, 33, 40, 463, DateTimeKind.Local).AddTicks(5990), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("ba921fbf-2872-4ec4-8927-cd924d8bf60d"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$pRKcyv3VctxtuiBZ9n3viedZ6hOga6fJxnh3AhacvuzdTw.VWDv7W", false, new DateTime(2023, 2, 24, 16, 33, 39, 532, DateTimeKind.Local).AddTicks(6721), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("bc6da56a-faa8-4ee7-aac6-25466074617a"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$I3Y2I1RpLuoyJ19kE0Qm9.rIVQL5UnYrHgSk5ktWTbLSnaIlon6sm", false, new DateTime(2023, 2, 24, 16, 33, 40, 39, DateTimeKind.Local).AddTicks(7312), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("bd8b2e34-4ef8-471e-994b-2fc6ea17133e"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$k2//rl8iOi70ApcT.cOz0e/EB8ryVE4xqOEQf5fwBw.QgVMl8yEJm", false, new DateTime(2023, 2, 24, 16, 33, 33, 663, DateTimeKind.Local).AddTicks(866), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("bd97c3b2-e392-45c0-a1c5-3f9be11d36ee"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$.sJMok2tAZ6UGmwSgGfN3O2H3GGNc3F.d8zhLPqAE7wcC0aeccYXC", false, new DateTime(2023, 2, 24, 16, 33, 39, 875, DateTimeKind.Local).AddTicks(6549), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("bf8822a8-991d-4d01-8bc0-0c60a18ac505"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$C9.G8xqSDNqgjJY9R9lc.O6z2yu7aoS0hmcUN.lARsmYeGTUdRHSe", false, new DateTime(2023, 2, 24, 16, 33, 33, 108, DateTimeKind.Local).AddTicks(8308), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("c0ac435b-f472-4775-92aa-03b8fd061579"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$VE10NiGWebiP38iI9ARguex5B1QGTYJ8o2pSNUDS.P2FUXvpG7tyG", false, new DateTime(2023, 2, 24, 16, 33, 35, 707, DateTimeKind.Local).AddTicks(6078), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("caddc873-4196-4804-9435-b63d75f77f30"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$Juffwx1CENVF8auND4yhCOpfn6tdc6L4w8RKlL4yvxqfRzTwj2sk6", false, new DateTime(2023, 2, 24, 16, 33, 39, 337, DateTimeKind.Local).AddTicks(7694), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("d63fe045-cdcb-4c97-a031-f0efbd0daa56"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$GLFybOr8.Bb9ph5sWiuboe.ZGY2CBU794xOqKXQvNCtIJym4HyJ4S", false, new DateTime(2023, 2, 24, 16, 33, 40, 380, DateTimeKind.Local).AddTicks(9973), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("d6f4cf33-9ede-46a9-9feb-7c134c9ba171"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$v8/fLXjvywuOYtZ7FzegeuQjM/lwGhj41F5ogGtrZguqAdeIVXYaK", false, new DateTime(2023, 2, 24, 16, 33, 37, 659, DateTimeKind.Local).AddTicks(1479), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("d717836c-1ebc-4e01-a774-cfd921c8bce5"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$rbPNSneM9tRECG30Hmv.keZ4RKnaWBev6wX8H47g/afRBiGn9Yx0m", false, new DateTime(2023, 2, 24, 16, 33, 42, 558, DateTimeKind.Local).AddTicks(1847), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("dc416857-ba51-488e-a356-b5f065e5c7aa"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$y1cYwgNQ1YUGiwz/FQtLhuGzKpNvZwMJ5IJkWikfQ78o9LvRPlrvW", false, new DateTime(2023, 2, 24, 16, 33, 32, 486, DateTimeKind.Local).AddTicks(5345), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("dc85e30b-06e3-4445-8166-a1899d43f4ea"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$4DMGk1KRD/7zgDhCC3BG3OVYDfLzv1qix4j0LJ5Pb8MgrBK7l376G", false, new DateTime(2023, 2, 24, 16, 33, 41, 98, DateTimeKind.Local).AddTicks(5826), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("de6f32ad-7510-426a-b42e-4d44c7474ef9"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$cvbegVCYjHT5s6ZzQJ09guRs87cxg9uUQXWOlBQs2qFDkbR2FSdxi", false, new DateTime(2023, 2, 24, 16, 33, 35, 606, DateTimeKind.Local).AddTicks(3805), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("dfe72099-0572-4868-8a36-441045a09e39"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$3Q6MXchVMQng5.62BfopOO0RVK5gvlb6nW9v18628Rg4NMtrpjS32", false, new DateTime(2023, 2, 24, 16, 33, 43, 40, DateTimeKind.Local).AddTicks(2664), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("dfeb78c1-3ae7-4d9b-84a2-6e4d671ca42e"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$7tAWE4BSHc76W.3eBmhtTend9AynGdic8f/UKfjuINhmkA3CkAM9e", false, new DateTime(2023, 2, 24, 16, 33, 38, 912, DateTimeKind.Local).AddTicks(774), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("e1c59063-4f3e-40fa-952f-5240288c3150"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$DUQtmCdQrq0CN79XFylCmunnw.E9pyDSbhl8FwIX1fppI4TFaepIO", false, new DateTime(2023, 2, 24, 16, 33, 40, 920, DateTimeKind.Local).AddTicks(9213), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("e306f6c6-f8b7-486b-b5dc-6e81cbac9273"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$Z1NbchStFz1M3gK1rFaGi.hBJ4zVOwjPhhVsXVpv1zTYyik6Ntsau", false, new DateTime(2023, 2, 24, 16, 33, 34, 591, DateTimeKind.Local).AddTicks(8227), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("e409f144-1fde-4cf2-95fb-ddc4eb6fdd5e"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$W1ehUL9laQus96GL0cgOz.uimojFnMEEfuls8xsucKPO6qLQ30Q/O", false, new DateTime(2023, 2, 24, 16, 33, 38, 456, DateTimeKind.Local).AddTicks(836), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("e4cdcfd7-9ee9-4a71-927e-a032528c9187"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$hoAmHn1c0fY0tQjP7M/5l.xNmD1yOW7Q2pFXwslsZZlG0ozcWxQkm", false, new DateTime(2023, 2, 24, 16, 33, 42, 386, DateTimeKind.Local).AddTicks(8598), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("e88ce0cc-ca3f-4e5e-8ea3-52454016df21"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$uryApM3VBZmRexWkslmcXefAps43zD0DxPrk1BbsniQ0rFQCZ11We", false, new DateTime(2023, 2, 24, 16, 33, 37, 747, DateTimeKind.Local).AddTicks(3824), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("ead446f8-8100-4346-a278-61ecf2dfb69a"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$sfowaeLW0Vzg9gu4vU7ilO77NwjGPlCl4ux5jTHxJdVmtl.JfitEy", false, new DateTime(2023, 2, 24, 16, 33, 34, 696, DateTimeKind.Local).AddTicks(155), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("ebd34878-dfa3-43bb-8232-9b73af3f076e"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$hHkQKOdt.jl6SbMw4rU89OGw1816kvs/EDw6mW6KhBU6Mswl0L0JO", false, new DateTime(2023, 2, 24, 16, 33, 39, 623, DateTimeKind.Local).AddTicks(2992), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("ebee2131-5dcf-41e1-b786-8ea4ba9494ed"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$2gOCRCOZ9R7tvT13M9/9f.wLlj82yhzmAoXk08eH..SwLeY6QjR16", false, new DateTime(2023, 2, 24, 16, 33, 40, 545, DateTimeKind.Local).AddTicks(8395), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("ec10d11a-1fbd-42d7-970a-18465ad79dea"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$UW7EuBr4w8vwG2OgYXm6JuAXpWSrfmFfS4oFGTNedAdCIAd8ZWUsm", false, new DateTime(2023, 2, 24, 16, 33, 32, 378, DateTimeKind.Local).AddTicks(5236), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("ec7fd5b8-b394-4732-911b-2535ed2b0076"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$cflgCMmfveyqWNGLXXKDseY1OzYZjcHHjLnogtpgWlEq5SgoST3ky", false, new DateTime(2023, 2, 24, 16, 33, 38, 71, DateTimeKind.Local).AddTicks(9047), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("ec92720f-e294-43cc-86fa-ddd9f3d9a09c"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$v268JgvJDSouxtkW8FutmecZv02iYoFU5MP6ojQ5sJYxZVMoglpFa", false, new DateTime(2023, 2, 24, 16, 33, 35, 428, DateTimeKind.Local).AddTicks(3844), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("eee9b7d4-b7c8-49f9-b168-6aa4a6c01d28"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$x68q.zuSTd/r0w3XNK6lz.7IijuYolRPgwfiFFc0AtGHdJtwBGA0y", false, new DateTime(2023, 2, 24, 16, 33, 36, 568, DateTimeKind.Local).AddTicks(4864), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("f1055956-660b-4a4a-8c11-4fa914b254f0"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$xhn7wpMF1hpc4ENOfAaUKOT7/EOYxPU2rdYZ4Fr1fKvNxM2Jr4qWC", false, new DateTime(2023, 2, 24, 16, 33, 36, 689, DateTimeKind.Local).AddTicks(8223), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("f1cdd001-593e-4b47-b46b-da2e252f6c59"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$prTqq9i1FT5.cvjLOT7nUOpZJt/0jCZORL0PZ9pkQYf8aEtpFfegC", false, new DateTime(2023, 2, 24, 16, 33, 32, 988, DateTimeKind.Local).AddTicks(2522), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("f2c99868-efbb-4352-a13e-6c426c6e00b2"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$VcnNaOk8XkcaP8UuhxzhWuUnEAhsDpZptFG8elqK3bR.qZQR/XbIC", false, new DateTime(2023, 2, 24, 16, 33, 38, 167, DateTimeKind.Local).AddTicks(5033), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("f350aadf-df49-414b-a30c-437f349399cd"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$NXa9ppFWhmUOh3mav5HlxeWNliYqD4ubnvXAtQwPLmhaTK1dTEaW6", false, new DateTime(2023, 2, 24, 16, 33, 38, 825, DateTimeKind.Local).AddTicks(6323), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("f5f88e13-533e-4d42-af63-a085c5f14414"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$MGA5PmKghFdfsA5TxkbqCOsbaxzfmZBdkLl3ohHEtCi8.jemcqkAO", false, new DateTime(2023, 2, 24, 16, 33, 42, 296, DateTimeKind.Local).AddTicks(7275), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("f6342ba5-3828-43a2-8023-4b4606b88d74"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$5sAHtT/JUFIC1YEcj2HPNOd76xUgaQysUenP2qKST0RndkD5N5NYe", false, new DateTime(2023, 2, 24, 16, 33, 39, 97, DateTimeKind.Local).AddTicks(8291), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("f64f418f-9c28-4b46-9354-f0e429b14caf"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$Ol9gUQB2lRe0aQlld.VoMu724mWw5kedRk5Dn4eVXUn77Nt86xsTW", false, new DateTime(2023, 2, 24, 16, 33, 34, 790, DateTimeKind.Local).AddTicks(5566), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("f78ae8d6-6c44-4385-bec7-0665c6f3f4f3"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$mdY9OGwT6A1G1mBB0cNateLZbe8uPcT5Ju2xqZ3ef7MBZF5rd0hJG", false, new DateTime(2023, 2, 24, 16, 33, 42, 195, DateTimeKind.Local).AddTicks(2707), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("fb737827-ac35-44f9-b952-78d37cf17c4e"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$TygC2PTnPQ86ppVDmxblXOaFfOK4nZF8K6d8xUn5KPNKRkvafesqq", false, new DateTime(2023, 2, 24, 16, 33, 33, 978, DateTimeKind.Local).AddTicks(8235), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("fbc5a901-daa8-434d-ab4a-43036d2a2652"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$Dz0NaX5TxAqo9Mmwp1lapOta9HOskAXhkmOXu529kB5hjAR8Ijk0u", false, new DateTime(2023, 2, 24, 16, 33, 42, 720, DateTimeKind.Local).AddTicks(8175), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" }
                });
        }
    }
}
