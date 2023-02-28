using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver169 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<Guid>(
                name: "DashboardID",
                table: "Parkings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("3baa715e-56fa-4621-95b6-189491d35b20"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("3bf906c7-c9a8-4771-8cff-f72a075e9b27"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("6223f7d0-c482-4146-af42-2a247e32eb7b"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("8059c1a1-0a68-42bf-abd8-141e768e1a0a"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("bc7a21d2-9571-4e52-b124-d1f709c5e31c"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("c5277fc7-f19e-4e43-a423-9555d650ce69"), "Xe bán tải", null, null, "Pickup", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("19668dec-2c86-4c5b-8070-96554ed6c2f4"), "Short time", new DateTime(2023, 2, 28, 20, 0, 12, 135, DateTimeKind.Local).AddTicks(1051), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1968486e-90dc-4119-9cf0-c376cf312d4a"), "1 Year", new DateTime(2023, 2, 28, 20, 0, 12, 135, DateTimeKind.Local).AddTicks(1056), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9c09eae-7f4d-454c-a90e-014a7c5607cd"), "Half Year", new DateTime(2023, 2, 28, 20, 0, 12, 135, DateTimeKind.Local).AddTicks(1055), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01000c24-a482-449f-883d-d90732ba643a"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$IvLRuGv4l7OfPIwxKNz3Ker4W3Gy/aIe7.sTDOTUyWXH12qWyWcQu", false, new DateTime(2023, 2, 28, 20, 0, 10, 134, DateTimeKind.Local).AddTicks(2058), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("01b0cc99-9b84-43ef-9aa1-633172e7cc1b"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$QLMEOTVNv6ayond4CDQ9leyixrUd36pkCDkBxsmqheQOKGXXYlwW6", false, new DateTime(2023, 2, 28, 20, 0, 10, 408, DateTimeKind.Local).AddTicks(302), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("03c8ff81-9645-4cdf-8427-8d3f94e13354"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$kVRS3rqt6W.2RICRWmxOde14uZ5qRd3cf5BprfWzNH5/tsx9JdelS", false, new DateTime(2023, 2, 28, 20, 0, 12, 135, DateTimeKind.Local).AddTicks(495), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("05ca8d5e-03b5-40e9-bfdd-eb0a4fb62496"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$9CVRL1Cy8ORJ8B8kl9MloOgPa1FHcyNB8KTba2NqCsRNMIi/7j62e", false, new DateTime(2023, 2, 28, 20, 0, 9, 939, DateTimeKind.Local).AddTicks(408), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("06c394ec-9c28-458b-ae6d-78f145b97866"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$AHQAAKTKEhFgUsXFWFuDn.ib1VIHOMD/xrQnad.n.MKIJnO6U.VeG", false, new DateTime(2023, 2, 28, 20, 0, 4, 170, DateTimeKind.Local).AddTicks(1003), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("07b83eab-b9c4-4acb-aed5-db300e6270bf"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$NPDvHY6Xkd4JAuNoLmzhyO852ZR4kPAz.qxnZEp5k7z4SFYFFMxkW", false, new DateTime(2023, 2, 28, 20, 0, 6, 139, DateTimeKind.Local).AddTicks(8945), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("07ba8d21-9f3d-4dfe-96af-0d5218733d77"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$ET/YJ4zmaF2Lr2YxDW38IeAGTdbpiYcFbLtcCcP/Q8r0hs0/1AOCe", false, new DateTime(2023, 2, 28, 20, 0, 1, 814, DateTimeKind.Local).AddTicks(6819), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("090e6e0d-711c-4fd1-a615-f693a3b73e5c"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$4dFxZ/JC7ZeDVgWNbvrK3.5MofpRqajnTrIJp5plLYntZxCylOIHu", false, new DateTime(2023, 2, 28, 20, 0, 10, 976, DateTimeKind.Local).AddTicks(3895), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("11864bf1-f249-4e03-a62b-59edd78ce033"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$HqNhjnEhHESGBG6wBjgLGO/bips2Kingfn5COdRXatX9XLciWHLuy", false, new DateTime(2023, 2, 28, 20, 0, 2, 301, DateTimeKind.Local).AddTicks(1910), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("122d3b59-82eb-4315-ad56-4bc8bb7c94be"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$XmqFIcO4eKpoRGtszAE9veStZVNQu4KeNs0FUkb6B6Tpt8n1Rr39O", false, new DateTime(2023, 2, 28, 20, 0, 7, 434, DateTimeKind.Local).AddTicks(3516), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("15e3ffb8-c080-48b6-a85d-3c4b8dba26f0"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$76D9LN8gFwfCZIoCvejSlu1JuWM2MiOyoqP32aaw9KO3h.PDyHm62", false, new DateTime(2023, 2, 28, 20, 0, 9, 0, DateTimeKind.Local).AddTicks(9128), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("1ac3b055-ccd7-435a-bc8d-4244474e7e78"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$oh4/hD7m4TGXGheSW7gTCuGKtqrp/5dKKYaSPC1cPRcBIQAdL6vHe", false, new DateTime(2023, 2, 28, 20, 0, 7, 509, DateTimeKind.Local).AddTicks(5432), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("21f1d9bd-b743-4ad8-aa5c-37867161d267"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$FlYPF2xnrcwf.hVsYnD5mOJjz5AEFYxDHbyN.GbhhbX/mKPQ5gP7q", false, new DateTime(2023, 2, 28, 20, 0, 4, 745, DateTimeKind.Local).AddTicks(6217), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("221f945d-ab30-4f83-acef-109ca7f1b9ce"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$SpMPob0HL/Nlrp4Mu4X.SeJRJgSfNduU.MwgMP.OwWZk64v1GL8I6", false, new DateTime(2023, 2, 28, 20, 0, 12, 1, DateTimeKind.Local).AddTicks(8971), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("22fbb647-eaf7-4777-8e88-47823797e9b9"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$0H2Nv56UEzqHYE0pb0shGexMoLsel93C4VjTUOI5c.Us0h0jJ/n7.", false, new DateTime(2023, 2, 28, 20, 0, 2, 854, DateTimeKind.Local).AddTicks(9650), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("23bd6c1a-ae2d-4339-8ceb-595b058d5aca"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$zbqMdYSGCXATSgj4Sjv3XedLBl30tQ7N/uNSAAgKlPySiBoMUFJ1a", false, new DateTime(2023, 2, 28, 20, 0, 11, 47, DateTimeKind.Local).AddTicks(6405), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("27df9b26-2e2d-48b4-87b1-a15143daaea7"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$6B1zwCBcTz5fcS2u/6Pe3ej7MTHMF7tqCANudO/Gbmj..tdMg2NUq", false, new DateTime(2023, 2, 28, 20, 0, 5, 540, DateTimeKind.Local).AddTicks(4483), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("2b1aa6a7-c0a2-427e-997f-18fc211fa7e8"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$yt/e2dBCpiNY9LxI.SLtq.xMNPUDOwEH5je30oeGukKo20.FynEpu", false, new DateTime(2023, 2, 28, 20, 0, 4, 501, DateTimeKind.Local).AddTicks(7938), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("2bf7d5e2-4a0e-4b89-bfe2-145e016a5388"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$QfDohggOn0IzpDnTMUjfSukZlWwNU.4/nwk7Avh8yhNt4QoC1l1Cu", false, new DateTime(2023, 2, 28, 20, 0, 8, 871, DateTimeKind.Local).AddTicks(1695), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("32b62f9a-d069-4e5a-849a-0d3bb27b67bf"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$KjjYoPLr7Kj8JPtx6wip1eUmGgzjha.MJca.RGI/m2tctKnSY9qeO", false, new DateTime(2023, 2, 28, 20, 0, 9, 330, DateTimeKind.Local).AddTicks(7181), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("32dbed5b-73cb-4150-b690-e7698d0d9167"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$p7h8h1qojDmWK6X7EijlJO5SxgsDQT7b01A7mozuQzOSXkOtTHkay", false, new DateTime(2023, 2, 28, 20, 0, 7, 93, DateTimeKind.Local).AddTicks(6294), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("34548108-3191-4035-b3f6-62a64206ea53"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$hxPIIxQ4ymAU4RjiJf1KKOq.Bu7tWIlBCGF2CMr/fyLxfcpWQ3l4W", false, new DateTime(2023, 2, 28, 20, 0, 7, 756, DateTimeKind.Local).AddTicks(8040), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("39ba08f4-523a-4066-93dd-a2ff8de791a9"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$4qwbwTaWXZ861Mp1IvMkK.azCRG8bvf.U0WevJirT0oIa5AgBSz2m", false, new DateTime(2023, 2, 28, 20, 0, 9, 264, DateTimeKind.Local).AddTicks(2847), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("3c934291-cd8a-4ab0-a106-99432eddeb63"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$LnjjT4.3cqfYm/A6GuBeH.jh7LMNWyjDDbGNK.CvxdQiEhiJF5UH6", false, new DateTime(2023, 2, 28, 20, 0, 5, 678, DateTimeKind.Local).AddTicks(8241), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("3e42c79a-919b-4819-9e62-29381ddf5097"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$7ZnKgWfdc5XOyOITv8EJhe/ir7XMJG46Tv7UZGZNuWthsXZwb7Sw2", false, new DateTime(2023, 2, 28, 20, 0, 10, 703, DateTimeKind.Local).AddTicks(6806), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("3f603e5b-7ed1-4b9d-95bd-5522a9ff9726"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$qhOLzH5D.fl6i0jCx.Wp0O2sKWsfxPWC70XMmG6dwxZhi0UqjosxK", false, new DateTime(2023, 2, 28, 20, 0, 8, 326, DateTimeKind.Local).AddTicks(2489), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("3fc737dd-3ac3-4898-9272-3449301192e4"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$SjV2HtNDMxd0ZP4RaY2EP.NWfpp3mc.C7D9yIBshRpzQKiIGaoPS2", false, new DateTime(2023, 2, 28, 20, 0, 7, 962, DateTimeKind.Local).AddTicks(6808), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("3fdad8ef-6fc3-415e-a331-7e7493fb20e2"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$HLkWe.nS2m/1CJ5v6pAZI.hdF6cZMG1oSxzylK6o4wjzUTWqGnQr6", false, new DateTime(2023, 2, 28, 20, 0, 6, 216, DateTimeKind.Local).AddTicks(9335), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("423a454a-40f0-47d0-bea6-5ef7ae4fe332"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$xIWvCm08yllVFIsHFodM/eK/8j9.Pj7aHRpCq1gHdgcw0gVjkH0YG", false, new DateTime(2023, 2, 28, 20, 0, 8, 41, DateTimeKind.Local).AddTicks(5830), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("424be942-ea42-496b-9d24-685a623fa9d1"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$6zykHgqb2a982xJxCLQRNeIumfgQSzBD0PQ.15KLDiN4TxXFZd1uu", false, new DateTime(2023, 2, 28, 20, 0, 6, 873, DateTimeKind.Local).AddTicks(5429), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("44322c99-9c68-4e8f-b2f6-7c2d77986588"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$yEvxsYu8hEgqhpBawZq46.mfsHVbRorZsp8kOA9WUWgLj/GZg7Squ", false, new DateTime(2023, 2, 28, 20, 0, 11, 871, DateTimeKind.Local).AddTicks(3563), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("45711f7e-bffa-4ce5-9e64-4cf2a95502e6"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$JdF22dRfHEFj/PZ/kHSIz.yHy2Ub4Rbfp3/M7v9FBKIzhPrzch5ze", false, new DateTime(2023, 2, 28, 20, 0, 8, 194, DateTimeKind.Local).AddTicks(9670), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("47dc0a77-1b9a-4782-9900-110ac9b027e5"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$Hm6/AeAFdpraPhbX5DvJD.aNRrDl88A6M5F5sVuy.JlJHGCy8hMmK", false, new DateTime(2023, 2, 28, 20, 0, 5, 401, DateTimeKind.Local).AddTicks(7049), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("490bff77-06c1-4e05-acc7-2a4dcd7d1a9c"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$XR9AVGs.LVDs0GwuYp9c9.tFGvwFb6MzEUF0vX/xotrBj6VEyINmG", false, new DateTime(2023, 2, 28, 20, 0, 8, 482, DateTimeKind.Local).AddTicks(203), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("4c211c66-9b28-4c33-bed8-2907806df3c3"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$pEAGM45cRc0QmUA.F1wJG.9WGAj8OIHRbtaSFZ/6g2Q0LNqPSAMkS", false, new DateTime(2023, 2, 28, 20, 0, 5, 206, DateTimeKind.Local).AddTicks(7829), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("4dea1442-951f-45df-a595-c3d91003af5b"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$B4aefDUj0jkC9iEryjFwaO7B8eFYQhCC.K0xHHzUr0G5CGBNsL4Ie", false, new DateTime(2023, 2, 28, 20, 0, 9, 132, DateTimeKind.Local).AddTicks(3034), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("4ef0b1a6-41e6-4995-a0da-e2a5f63f2008"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$Y.3HV6/fM66Gy8daXTWcp.sb/aR4MFgZzqko5wiV.Lb4D6Nj24Dvy", false, new DateTime(2023, 2, 28, 20, 0, 5, 875, DateTimeKind.Local).AddTicks(4220), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("502d8e46-4a08-4ac1-8b94-6ead453c918b"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$7gsPJ7afOkXWtAqnADgmDOfzVJAuQFUSnjCkM1e4WxN6uh5HaOhZ2", false, new DateTime(2023, 2, 28, 20, 0, 6, 55, DateTimeKind.Local).AddTicks(3454), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("524c6bec-47da-4c93-990f-e6dd159f1740"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$MhRic7N1tK/E354SLmN5w.Fuaxx8UikDMLf0ZTv5HDfaLWi5VQyDW", false, new DateTime(2023, 2, 28, 20, 0, 4, 825, DateTimeKind.Local).AddTicks(4893), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("55f18400-c41e-49a6-98b1-92e5cc6da33c"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$v/Vkwbb1KRCiJ4EbeUyg8uYkAFfdpm1JOlQ95OlRDMKtveDFDU68y", false, new DateTime(2023, 2, 28, 20, 0, 9, 738, DateTimeKind.Local).AddTicks(3463), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("57b2672b-1178-42a8-986a-dfcceb3f95af"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$kX4YXkHX8Bhq7AOhblVcCuh3l2jcOljTbQ1WwIiPfdoonD2KGNTsu", false, new DateTime(2023, 2, 28, 20, 0, 9, 596, DateTimeKind.Local).AddTicks(9426), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("586fd4b1-fd7c-4983-a969-e5c2693b66dd"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$6fl9z4eC2S8.KIs4D7iKh.LybnwLXzn3NdjNpQf0t1xeW5Q1pogrG", false, new DateTime(2023, 2, 28, 20, 0, 9, 872, DateTimeKind.Local).AddTicks(1462), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("5cc3324e-feda-4fdc-bd11-d45e7f0aaf19"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$xeD8RzPeAw50GQP1mzSnFOCBfg/Q3HGJoccQCg0KyouM3xISmOLTG", false, new DateTime(2023, 2, 28, 20, 0, 10, 6, DateTimeKind.Local).AddTicks(498), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("5e0a39a7-8d9b-4348-a6db-a77f86463967"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$3noDWhr1/nsBK/bJIvGj2OZ27uGQHloffNoIcFnSzZPcD9KPgNvBO", false, new DateTime(2023, 2, 28, 20, 0, 1, 491, DateTimeKind.Local).AddTicks(7477), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("5f909ad8-5160-415c-ae15-cf887609b7a9"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$TppNZPK7/N6JmrdBRiS1E.JtYM470S5WMrmkX.6w7Jr7xPWR/g1qG", false, new DateTime(2023, 2, 28, 20, 0, 10, 206, DateTimeKind.Local).AddTicks(6862), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("617fa16a-01cb-4726-9dd9-52712d108d83"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$7LnRuxo81QoLVLtPqP74iuASz/hI3EwEqy1xrM4g9L0n3WStsLPHC", false, new DateTime(2023, 2, 28, 20, 0, 7, 886, DateTimeKind.Local).AddTicks(3052), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("62f56d94-30a8-491b-9f2d-7919ae06c205"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$GxMRfcmNDushEJKDzpeis.BKBI4yds0a5ViQFf5EbHNIwLVxYS4A.", false, new DateTime(2023, 2, 28, 20, 0, 5, 777, DateTimeKind.Local).AddTicks(6481), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("63561411-55c4-442e-a0c9-79aa88e8ea10"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$Ba3y6wtb922nDo5rIRXEZeosYW1djBw5tIuiAdmFQ4V/YEZxwFp0u", false, new DateTime(2023, 2, 28, 20, 0, 11, 935, DateTimeKind.Local).AddTicks(9716), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("67d0b027-3931-4758-a9f4-6c8e6d9abefb"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$w4ot86Iaa0i.Af/DY80B...wTDYYOs1NkIQ/wnoYPi3FX57e6uA6y", false, new DateTime(2023, 2, 28, 20, 0, 7, 350, DateTimeKind.Local).AddTicks(7977), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("6880a5b6-629c-4206-aa7f-d0c42c240415"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$oWEAKjluXziEfT3KbYmqMOdDC1KwktOlHVWdsaHTGOIlil6Z3KhxW", false, new DateTime(2023, 2, 28, 20, 0, 8, 688, DateTimeKind.Local).AddTicks(8207), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("696ad3fd-82dc-4216-821f-4c4cfa5dffa1"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$6R43M2S8N24xatcI.nX8x.vWTdmjkVY.57dI3vbJvGBRpLdlXRhF6", false, new DateTime(2023, 2, 28, 20, 0, 2, 676, DateTimeKind.Local).AddTicks(7683), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("6a06be8d-48bf-4719-8e89-e55edfeb7a6f"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$l..QXCEThBsACP5iKaxAueMUg0KnrlW1bxGU./PePwMksqFfOQugu", false, new DateTime(2023, 2, 28, 20, 0, 9, 671, DateTimeKind.Local).AddTicks(5068), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("6a3d8064-6e85-407a-ab34-fbd48d19e811"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$ju/Y1ia3qSHe64A4nl1.duW.Kw/Uykcni7PllH2R07c.msVKxQuKC", false, new DateTime(2023, 2, 28, 20, 0, 9, 198, DateTimeKind.Local).AddTicks(497), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("6f166428-2982-4305-b407-2491c9fca2a2"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$XakTy2THnMhYDU6HGrrm.e3WHP9hlNveEDZnzs/46voyYxPz.XOmO", false, new DateTime(2023, 2, 28, 20, 0, 11, 717, DateTimeKind.Local).AddTicks(2477), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("701635cd-5285-47a5-9a4b-0672d848c3ba"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$iVhrOyoBnzpfACtA6GSQvepucoDFsM2P5fanOEez3CtMcFj9bggbW", false, new DateTime(2023, 2, 28, 20, 0, 7, 667, DateTimeKind.Local).AddTicks(8588), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("71261898-5920-4f32-b675-f5405949324c"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$qdUzdhwDns/tJvqlyEaQi.WGZ/iuRwqfyFQxm8zbqoFtvgv2iTFFq", false, new DateTime(2023, 2, 28, 20, 0, 8, 259, DateTimeKind.Local).AddTicks(3779), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("72268cd9-5540-465d-a6e2-d696e03e4d31"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$zzjyckJyFHl5/irkIK/E0u/6/kgUDFlkoKpSAun2cVsf.ajQIVmMK", false, new DateTime(2023, 2, 28, 20, 0, 3, 12, DateTimeKind.Local).AddTicks(8112), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("7429931f-7d09-4c83-ad74-f381a1b51749"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$zxgPFlh8eCo.qTpTH8I7N.9yWxYmytYeI95ht8iy6RIu9Hk/sed1a", false, new DateTime(2023, 2, 28, 20, 0, 10, 637, DateTimeKind.Local).AddTicks(8921), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("757b0090-72be-4760-8d3e-5a0bdc36d7e3"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$/DBCQDnNUZ3JIKCk4BNKRebVbMsyZQdZNIlSWFkIJFGYLhWKhuDDu", false, new DateTime(2023, 2, 28, 20, 0, 10, 571, DateTimeKind.Local).AddTicks(512), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("7783584e-707f-4af8-8f52-f2a78df3d695"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$boZdpWww2NiDkWoAJ2srA.75e2WWocPyBf2nX0bIKONAm27ZxH3iu", false, new DateTime(2023, 2, 28, 20, 0, 5, 104, DateTimeKind.Local).AddTicks(3884), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("79e6b531-d422-4db3-8020-f4ddbfca333d"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$9f1DZrCPmWiNq985eq6CZ.b5p/YvRCu1m3uZi//eNZ3LGtupEyXte", false, new DateTime(2023, 2, 28, 20, 0, 7, 254, DateTimeKind.Local).AddTicks(7698), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("7b5a2021-329b-4d20-a2ba-8d30965743eb"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$kGOlBoTkzIlQbSOkCOA7HuFoEmwZ2F5LAH10zewB4JbXAW9DgStTW", false, new DateTime(2023, 2, 28, 20, 0, 3, 672, DateTimeKind.Local).AddTicks(1420), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("7d3e8efc-1faf-45df-9bdc-8f2bceff4da8"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$sAP2WnKl256JvMu65bTuWelgd6dkQeIg79skWDWPWaH/lsg.vzCoi", false, new DateTime(2023, 2, 28, 20, 0, 3, 840, DateTimeKind.Local).AddTicks(6099), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("87b0c1c7-8316-4182-a163-31d5738f0cbe"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$j0Ad2XcSWhCZcmd6dsztwOmK4NtLKMVYX6a4n8NqmmveXUGvQ4QtG", false, new DateTime(2023, 2, 28, 20, 0, 3, 504, DateTimeKind.Local).AddTicks(1568), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("88fe0719-f7c0-4cb9-b231-396bed994b61"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$umVlkCeS3xgtF/5keESDP.gLk8lbQauS4drSRk1ZIHifh.CU4laTC", false, new DateTime(2023, 2, 28, 20, 0, 3, 174, DateTimeKind.Local).AddTicks(106), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("896de7a1-f18c-4f86-a8d7-b8fb3a7aa560"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$DAtvh19Sik6EmEHf0FEQjugT0P4ez1FgT95rhSHh49EB2ljwrDjWO", false, new DateTime(2023, 2, 28, 20, 0, 11, 252, DateTimeKind.Local).AddTicks(2525), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("954e6fc3-c218-4de4-8ee8-c139d60d1153"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$N/EeWkS79/NodTKwK5efUe5IRs9flv0SidvMlhVQ0ih0NfpX7ukeK", false, new DateTime(2023, 2, 28, 20, 0, 8, 567, DateTimeKind.Local).AddTicks(6489), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("96235b60-8190-4c8e-8107-9ff19743c2c9"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$KS.QE7nA3RIUTIs.PrjjDOtW6ZVPiS1nEvrzFiBDLu/Gv17f69adW", false, new DateTime(2023, 2, 28, 20, 0, 6, 420, DateTimeKind.Local).AddTicks(2999), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("9e235abd-48ad-422f-bfca-506ede51e267"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$WlhQHPgETNSMUU74SS.hw.kUpQXBJmlOL1RLbIQZIWn4bPsEBdVy6", false, new DateTime(2023, 2, 28, 20, 0, 2, 136, DateTimeKind.Local).AddTicks(144), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("9e361e5e-5d53-4e15-84b8-bffa7798bdb3"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$35QjfFiJMG3kSKGl5Y21R.mA1yAdbDBlNJXjSrXr0dfRTOUu2/kNS", false, new DateTime(2023, 2, 28, 20, 0, 1, 975, DateTimeKind.Local).AddTicks(2840), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("a2120c04-3752-4dc6-bd3e-670c67cd8846"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$wAR6nHZecgsaTa6Za3OoNOzN3Bcta54AnpmNyogcBir6dIrkWHcjW", false, new DateTime(2023, 2, 28, 20, 0, 10, 496, DateTimeKind.Local).AddTicks(8076), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("a747da3a-c802-4172-930e-3921001d27aa"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$cl54bQSoK/bTGACP/1RRCuiu./e/3R7LHS8WixbvKIv0kHW7JjWtm", false, new DateTime(2023, 2, 28, 20, 0, 8, 806, DateTimeKind.Local).AddTicks(4419), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("a8ebe146-bb1d-47f9-9ca0-a148b1a07c50"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$EYtp/FCDYPgCc3eUW6LH8ux3TBZx3nBcRrjORboc8eBc6hc9SNytK", false, new DateTime(2023, 2, 28, 20, 0, 11, 539, DateTimeKind.Local).AddTicks(2045), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("ab388e9b-8193-4ba5-9de2-25c3e02dc12b"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$/Kd.NSWlwMfWARaZIYWAdOjr8sWn.7bBuesh8lEIquAIoeYgmIetm", false, new DateTime(2023, 2, 28, 20, 0, 5, 968, DateTimeKind.Local).AddTicks(7156), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("ac8ca72c-fc20-4547-9807-83f3b93597a2"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$LMbxHKF2CR0Nu3D8PFPdDeQGVLICs.IJab/K9.WRfu./tFtmU7bmW", false, new DateTime(2023, 2, 28, 20, 0, 8, 397, DateTimeKind.Local).AddTicks(4671), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("ae27e493-7132-4017-846e-ea4182f5d8b9"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$/gEQchm7AS0GZb180xHDbe7zHL3XSrjqTg2OwkQDc/9vAgyOO2ic.", false, new DateTime(2023, 2, 28, 20, 0, 11, 421, DateTimeKind.Local).AddTicks(4400), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("b4bdc006-5844-4064-b93e-c0b64f64825c"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$pNxORn04ls1yIvLU3iDqZ.jIZEueAcIAUTkzm995BqQ1SR5T.RKdy", false, new DateTime(2023, 2, 28, 20, 0, 6, 946, DateTimeKind.Local).AddTicks(7890), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("b7c6e5db-cf10-45da-bb9f-e4bf414e5c07"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$zaMyugqwTgKy93W2dXsvJOxY8Af6OqU4s64w6r5oQdKW/3bXIwZQq", false, new DateTime(2023, 2, 28, 20, 0, 12, 69, DateTimeKind.Local).AddTicks(4938), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("bae44e23-b42d-4cc5-a748-15f06078ef3b"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$b80h.aVMsKl23eRKAT/Oj.0R5S93o2EuWUzAMTPrMwjac.gJypWm6", false, new DateTime(2023, 2, 28, 20, 0, 10, 910, DateTimeKind.Local).AddTicks(682), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("bc85ca16-cbbf-4d01-ade3-80a2a874b795"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$BvoK9uVd/HHjTfNw9ecnOOKLV.jyOUd5e9HMKsp.lH/9DJQutJstG", false, new DateTime(2023, 2, 28, 20, 0, 9, 804, DateTimeKind.Local).AddTicks(9966), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("bf05fed6-8ff3-4086-929f-1e08209f323f"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$ETasX7oGn6M4P.JtVPjIIejQ98p10ILLD9fmMvI0OkhRO7A8BdFXy", false, new DateTime(2023, 2, 28, 20, 0, 10, 842, DateTimeKind.Local).AddTicks(3808), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("c13ad99e-0ac5-4fe8-afce-38c119d9e161"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$vYB3wc2VlgG7GJ5Gh4iqke.eOlVDhn.48e5331Rf819A6RcJPIatK", false, new DateTime(2023, 2, 28, 20, 0, 10, 300, DateTimeKind.Local).AddTicks(3261), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("c7f835dc-e28c-4798-a7ca-d9110c370c4b"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$Tz683pnPY1zlfeG525JQCO7NR.fFmOSAUj5s6hl/H3kxgaVG60Qwq", false, new DateTime(2023, 2, 28, 20, 0, 6, 798, DateTimeKind.Local).AddTicks(5397), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("ca524129-0a25-4e85-a522-be68daa89074"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$lyu7Hj5KVALTa2v6BfInG.v.j4U4IMyMzPKAkkhFYjMqO7sJ/rXaC", false, new DateTime(2023, 2, 28, 20, 0, 9, 416, DateTimeKind.Local).AddTicks(2985), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("cb8e94bf-01f9-418e-81b5-5ff6f0eb47b6"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$2Wf/O1xQhcDoZ4ceKFwboePEIDsSx2B7mW.KkOf7qDLsKhtGbYVee", false, new DateTime(2023, 2, 28, 20, 0, 11, 803, DateTimeKind.Local).AddTicks(2454), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("cfd807c8-4776-45da-9fe5-a4af71960a7d"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$zMJN4rBiC1GenxQf.NdyHu6h1VmyIpAlomtRra/OnK/5O.6rJtaoO", false, new DateTime(2023, 2, 28, 20, 0, 8, 936, DateTimeKind.Local).AddTicks(317), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("d33c6257-7782-4ca4-9c2e-1e9eeffdc3e2"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$tDhqe7dyNitcCiHIXIJq2.HG.Jic2ijMHPg2dznFSTSIJ5LZ8bvfi", false, new DateTime(2023, 2, 28, 20, 0, 6, 598, DateTimeKind.Local).AddTicks(9117), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("d33f78b5-335e-481b-bd39-63f169f07742"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$0QE6kM5RBB72L5W2N7IOZuk.EsDpW.0a4V.CPFxSw/2vgoxqT/Jc2", false, new DateTime(2023, 2, 28, 20, 0, 5, 296, DateTimeKind.Local).AddTicks(6853), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("d7596f32-375d-4cb6-ac88-32f11d939b6b"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$1UWGN2geoTeuEZBZdPNABeVzyXwFXMiiFgtVZ.z5qhQKG5GHtm8Dy", false, new DateTime(2023, 2, 28, 20, 0, 11, 628, DateTimeKind.Local).AddTicks(2233), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("dc693bbb-8327-47a8-8aaa-34e688971b12"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$yquMBTuxhHt4pEyPIfXlgeToMyJWUfacwlHvKrHKNNiOcOjyNBYFa", false, new DateTime(2023, 2, 28, 20, 0, 10, 70, DateTimeKind.Local).AddTicks(2663), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("dea950bb-bf38-452c-b3ea-284258d91312"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$tYnx.LLOSMOvvWGckuhc8OTpR.VO45zKv7NDcE8/UCB25sjDDJdgC", false, new DateTime(2023, 2, 28, 20, 0, 5, 22, DateTimeKind.Local).AddTicks(8854), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("e41b16f4-41c7-4087-82b5-36212f5819e5"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$QgQ4BBe8tzNdGUCHi7ASneoiwDuwbSUr6t8mgCbPCxZJOGUCw2nai", false, new DateTime(2023, 2, 28, 20, 0, 4, 1, DateTimeKind.Local).AddTicks(7176), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("e4dbc4aa-e387-4d87-ba87-579ef5e731ff"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$R36v1SjP8wdGpxi.r2qHgemt.nwjDcgHq7J9DN4uuyw30ITzjGeCa", false, new DateTime(2023, 2, 28, 20, 0, 10, 776, DateTimeKind.Local).AddTicks(1287), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("e7f91054-7ab8-4863-b1a5-d40f32432d13"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$AQBG5Bg61hSzcWtyYQI/9uWOONKNefVKUMP.Kv2DFGIAgc7BjxULC", false, new DateTime(2023, 2, 28, 20, 0, 8, 122, DateTimeKind.Local).AddTicks(5977), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("e97b3996-90e4-4928-a16e-5f3e828d630a"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$Hc.guaC.rkB0o3O.kCZry.bBcQmJRZ1/lkW/6wF.gMtGehHnfvdGK", false, new DateTime(2023, 2, 28, 20, 0, 11, 113, DateTimeKind.Local).AddTicks(7089), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("e9c726f6-b04a-469a-9ccb-157404bd0e2e"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$uqvlvMp/ZU4DnqO8pvlen.O0bmHy.hSGQnEQsoFRAsoHy/LBDLdNG", false, new DateTime(2023, 2, 28, 20, 0, 9, 519, DateTimeKind.Local).AddTicks(5032), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("eb1ef836-ee38-4110-87b8-01ca11523d33"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$xZSIVicMcCOLAJPKrUcxFOfxL7Lh0IrjN2VDCHw17q07S1nkiD/fK", false, new DateTime(2023, 2, 28, 20, 0, 11, 183, DateTimeKind.Local).AddTicks(9241), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("eb8af941-d352-4b97-b43c-2cfa12e03e50"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$stSdvLnIG55eoeBCIoN9se44mEF4klfmGatilfrBTnKq/sLKqsShS", false, new DateTime(2023, 2, 28, 20, 0, 6, 317, DateTimeKind.Local).AddTicks(7309), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("ec010708-19f9-4138-8a81-2634a153825e"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$ODiDzqZyF6N.WvgNQH7RhuYogCkSAOEnUdrN9GLIdxunYtXvpSDRK", false, new DateTime(2023, 2, 28, 20, 0, 6, 513, DateTimeKind.Local).AddTicks(4646), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("ec854914-e3ab-40fc-bf26-38cba540d6e5"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$U0obd6zMYUwQyXojNmDEC.xAbYXv7F5L34eAPmn2q5CtaB8hEc8kq", false, new DateTime(2023, 2, 28, 20, 0, 2, 517, DateTimeKind.Local).AddTicks(8459), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("edb4875e-3e62-4ed6-b7ed-c5bfa95e4749"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$fFzm.yRPCpay23ShSFAL3OQnViGPcnPCgkwqmFrtdIH8a9GybEzeK", false, new DateTime(2023, 2, 28, 20, 0, 7, 576, DateTimeKind.Local).AddTicks(4199), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("f1251716-9e08-4d3e-96d8-e98621e79ae4"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$TE5cTR.qpfra0f9voajY3uRODNdVmz19qn5cJkTCDEv/65wEK1tyG", false, new DateTime(2023, 2, 28, 20, 0, 4, 337, DateTimeKind.Local).AddTicks(1883), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("f2e0a55c-9cc5-4f11-b872-9fdfae77e31e"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$rxc04K8nA6g7J1OPu8KK.Ob85gUDBK/3FYwJzwBo.FQW0U5oUzZAO", false, new DateTime(2023, 2, 28, 20, 0, 7, 166, DateTimeKind.Local).AddTicks(7705), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("f33ad934-f905-4359-9d6d-2da271c1a60b"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$El8aIyLmebu6dDgGsxkxGu8FsGEZCVPMPyGbeuXJJJ1BdE62QyCpK", false, new DateTime(2023, 2, 28, 20, 0, 11, 320, DateTimeKind.Local).AddTicks(3255), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("f421d590-f6de-4e9f-8f75-728cfe9dbca6"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$vxR.7FKZTvHCoL.3Wod4AuGG09fZxqlvpv2ZybgqR6hbj.IUEmoZS", false, new DateTime(2023, 2, 28, 20, 0, 7, 822, DateTimeKind.Local).AddTicks(2881), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("f6160cc6-fe0a-4597-92d0-e12582f32f3e"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$3JmtK6NFMpEtnP8EdTrLj.F1A6qyy9r1BhpmTBiPb2ekwCllenKBS", false, new DateTime(2023, 2, 28, 20, 0, 4, 665, DateTimeKind.Local).AddTicks(1801), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("f65ede3a-44b7-40b3-87f5-68861ac33883"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$2Ih36lJZ6BRhCldtFgBrROGixi0UStQOt/iIBDcNFwItPmRwVsnee", false, new DateTime(2023, 2, 28, 20, 0, 9, 65, DateTimeKind.Local).AddTicks(4967), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("fc66898b-a1d1-43ac-a0fb-f8babeb2a816"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$ObjGs0jQwV3y7zesqmOxTuwQAYYjrZdt1jk.l3BxiAxNl157O4c9G", false, new DateTime(2023, 2, 28, 20, 0, 1, 656, DateTimeKind.Local).AddTicks(8063), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("fcc83eba-e6bb-487d-8dcf-66ed5778b1ab"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$jZFU7Uf1rAV1yy32HxW5W.SXzF6n4QcwIZM.Lypdrem48K8WVzkpu", false, new DateTime(2023, 2, 28, 20, 0, 7, 20, DateTimeKind.Local).AddTicks(4641), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("fe69e50e-2e33-4989-9fc7-73596e89064e"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$RxAY9grpiB4PTL3myJq5pe7WyaIld6kDHCw3twsB7nL6OFx7aExdO", false, new DateTime(2023, 2, 28, 20, 0, 3, 340, DateTimeKind.Local).AddTicks(7515), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("ff213a1f-7337-4f61-b430-48a97d54a1f3"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$F20vbsl2QXpWYlrA2Tg2SOGw.m.iu4.1poYKPKe3BtKBICR1QZxca", false, new DateTime(2023, 2, 28, 20, 0, 4, 926, DateTimeKind.Local).AddTicks(9360), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("ff2c83c6-742d-4d9e-8518-ff6ad9ac3ed7"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$kVvRyYHAlYOA7J3lJ55ROuM/EBZUBQPTclh6rZ2d2a.WmnTVeCJUq", false, new DateTime(2023, 2, 28, 20, 0, 6, 696, DateTimeKind.Local).AddTicks(8736), "Cantor", null, null, "0218299981", 1, "jcantor13" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("3baa715e-56fa-4621-95b6-189491d35b20"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("3bf906c7-c9a8-4771-8cff-f72a075e9b27"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("6223f7d0-c482-4146-af42-2a247e32eb7b"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("8059c1a1-0a68-42bf-abd8-141e768e1a0a"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("bc7a21d2-9571-4e52-b124-d1f709c5e31c"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("c5277fc7-f19e-4e43-a423-9555d650ce69"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("19668dec-2c86-4c5b-8070-96554ed6c2f4"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("1968486e-90dc-4119-9cf0-c376cf312d4a"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("b9c09eae-7f4d-454c-a90e-014a7c5607cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01000c24-a482-449f-883d-d90732ba643a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01b0cc99-9b84-43ef-9aa1-633172e7cc1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("03c8ff81-9645-4cdf-8427-8d3f94e13354"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05ca8d5e-03b5-40e9-bfdd-eb0a4fb62496"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("06c394ec-9c28-458b-ae6d-78f145b97866"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("07b83eab-b9c4-4acb-aed5-db300e6270bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("07ba8d21-9f3d-4dfe-96af-0d5218733d77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("090e6e0d-711c-4fd1-a615-f693a3b73e5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("11864bf1-f249-4e03-a62b-59edd78ce033"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("122d3b59-82eb-4315-ad56-4bc8bb7c94be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("15e3ffb8-c080-48b6-a85d-3c4b8dba26f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1ac3b055-ccd7-435a-bc8d-4244474e7e78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("21f1d9bd-b743-4ad8-aa5c-37867161d267"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("221f945d-ab30-4f83-acef-109ca7f1b9ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("22fbb647-eaf7-4777-8e88-47823797e9b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("23bd6c1a-ae2d-4339-8ceb-595b058d5aca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("27df9b26-2e2d-48b4-87b1-a15143daaea7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2b1aa6a7-c0a2-427e-997f-18fc211fa7e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2bf7d5e2-4a0e-4b89-bfe2-145e016a5388"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("32b62f9a-d069-4e5a-849a-0d3bb27b67bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("32dbed5b-73cb-4150-b690-e7698d0d9167"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("34548108-3191-4035-b3f6-62a64206ea53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("39ba08f4-523a-4066-93dd-a2ff8de791a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3c934291-cd8a-4ab0-a106-99432eddeb63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3e42c79a-919b-4819-9e62-29381ddf5097"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3f603e5b-7ed1-4b9d-95bd-5522a9ff9726"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3fc737dd-3ac3-4898-9272-3449301192e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3fdad8ef-6fc3-415e-a331-7e7493fb20e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("423a454a-40f0-47d0-bea6-5ef7ae4fe332"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("424be942-ea42-496b-9d24-685a623fa9d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("44322c99-9c68-4e8f-b2f6-7c2d77986588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("45711f7e-bffa-4ce5-9e64-4cf2a95502e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("47dc0a77-1b9a-4782-9900-110ac9b027e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("490bff77-06c1-4e05-acc7-2a4dcd7d1a9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4c211c66-9b28-4c33-bed8-2907806df3c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4dea1442-951f-45df-a595-c3d91003af5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4ef0b1a6-41e6-4995-a0da-e2a5f63f2008"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("502d8e46-4a08-4ac1-8b94-6ead453c918b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("524c6bec-47da-4c93-990f-e6dd159f1740"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("55f18400-c41e-49a6-98b1-92e5cc6da33c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("57b2672b-1178-42a8-986a-dfcceb3f95af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("586fd4b1-fd7c-4983-a969-e5c2693b66dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5cc3324e-feda-4fdc-bd11-d45e7f0aaf19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5e0a39a7-8d9b-4348-a6db-a77f86463967"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5f909ad8-5160-415c-ae15-cf887609b7a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("617fa16a-01cb-4726-9dd9-52712d108d83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62f56d94-30a8-491b-9f2d-7919ae06c205"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("63561411-55c4-442e-a0c9-79aa88e8ea10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("67d0b027-3931-4758-a9f4-6c8e6d9abefb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6880a5b6-629c-4206-aa7f-d0c42c240415"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("696ad3fd-82dc-4216-821f-4c4cfa5dffa1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6a06be8d-48bf-4719-8e89-e55edfeb7a6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6a3d8064-6e85-407a-ab34-fbd48d19e811"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f166428-2982-4305-b407-2491c9fca2a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("701635cd-5285-47a5-9a4b-0672d848c3ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("71261898-5920-4f32-b675-f5405949324c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("72268cd9-5540-465d-a6e2-d696e03e4d31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7429931f-7d09-4c83-ad74-f381a1b51749"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("757b0090-72be-4760-8d3e-5a0bdc36d7e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7783584e-707f-4af8-8f52-f2a78df3d695"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("79e6b531-d422-4db3-8020-f4ddbfca333d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7b5a2021-329b-4d20-a2ba-8d30965743eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d3e8efc-1faf-45df-9bdc-8f2bceff4da8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("87b0c1c7-8316-4182-a163-31d5738f0cbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("88fe0719-f7c0-4cb9-b231-396bed994b61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("896de7a1-f18c-4f86-a8d7-b8fb3a7aa560"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("954e6fc3-c218-4de4-8ee8-c139d60d1153"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("96235b60-8190-4c8e-8107-9ff19743c2c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9e235abd-48ad-422f-bfca-506ede51e267"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9e361e5e-5d53-4e15-84b8-bffa7798bdb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a2120c04-3752-4dc6-bd3e-670c67cd8846"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a747da3a-c802-4172-930e-3921001d27aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a8ebe146-bb1d-47f9-9ca0-a148b1a07c50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab388e9b-8193-4ba5-9de2-25c3e02dc12b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ac8ca72c-fc20-4547-9807-83f3b93597a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ae27e493-7132-4017-846e-ea4182f5d8b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b4bdc006-5844-4064-b93e-c0b64f64825c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b7c6e5db-cf10-45da-bb9f-e4bf414e5c07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bae44e23-b42d-4cc5-a748-15f06078ef3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bc85ca16-cbbf-4d01-ade3-80a2a874b795"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bf05fed6-8ff3-4086-929f-1e08209f323f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c13ad99e-0ac5-4fe8-afce-38c119d9e161"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7f835dc-e28c-4798-a7ca-d9110c370c4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ca524129-0a25-4e85-a522-be68daa89074"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cb8e94bf-01f9-418e-81b5-5ff6f0eb47b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cfd807c8-4776-45da-9fe5-a4af71960a7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d33c6257-7782-4ca4-9c2e-1e9eeffdc3e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d33f78b5-335e-481b-bd39-63f169f07742"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d7596f32-375d-4cb6-ac88-32f11d939b6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dc693bbb-8327-47a8-8aaa-34e688971b12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dea950bb-bf38-452c-b3ea-284258d91312"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e41b16f4-41c7-4087-82b5-36212f5819e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4dbc4aa-e387-4d87-ba87-579ef5e731ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7f91054-7ab8-4863-b1a5-d40f32432d13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e97b3996-90e4-4928-a16e-5f3e828d630a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e9c726f6-b04a-469a-9ccb-157404bd0e2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eb1ef836-ee38-4110-87b8-01ca11523d33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eb8af941-d352-4b97-b43c-2cfa12e03e50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec010708-19f9-4138-8a81-2634a153825e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec854914-e3ab-40fc-bf26-38cba540d6e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("edb4875e-3e62-4ed6-b7ed-c5bfa95e4749"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f1251716-9e08-4d3e-96d8-e98621e79ae4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f2e0a55c-9cc5-4f11-b872-9fdfae77e31e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f33ad934-f905-4359-9d6d-2da271c1a60b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f421d590-f6de-4e9f-8f75-728cfe9dbca6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f6160cc6-fe0a-4597-92d0-e12582f32f3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f65ede3a-44b7-40b3-87f5-68861ac33883"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fc66898b-a1d1-43ac-a0fb-f8babeb2a816"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fcc83eba-e6bb-487d-8dcf-66ed5778b1ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fe69e50e-2e33-4989-9fc7-73596e89064e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ff213a1f-7337-4f61-b430-48a97d54a1f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ff2c83c6-742d-4d9e-8518-ff6ad9ac3ed7"));

            migrationBuilder.AlterColumn<Guid>(
                name: "DashboardID",
                table: "Parkings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
        }
    }
}
