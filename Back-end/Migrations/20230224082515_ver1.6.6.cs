using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver166 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("2c59e238-1da0-4ec0-a243-5bc5c15c90d6"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("3e97bdcc-c9ab-4e8c-806c-8a20dfa80660"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("5121a810-8032-4c0f-9b9f-ca36978a1372"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("ccc75c1f-5c65-4896-8c2c-764906c360d2"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("e4976a8a-35ad-4d98-9475-aa9911e30706"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("f9efbedc-eae2-4a6b-a267-b27471bfbad5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01f1a277-e765-4b7f-b55f-2517241e09c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("047bfd41-f27a-4e4f-a0a0-0a127e5dfae0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05602db6-37f9-4720-9347-1198bf4120d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05c4e3e3-4c4d-4b65-be48-3804f1835f6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05d20112-70a8-4d16-aa12-3fa7f1e51e77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0b4866de-e8d1-4cab-b33f-35ddefaa3133"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("104260c1-4162-4ade-84bc-f9acf18ecbbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("11a9a150-0e26-4786-bae3-de299e52179c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("11cfb069-2c32-4f09-9bd3-00ef78f1f823"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("13543eb1-49f6-4c87-8117-21dc26a0d477"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("136d6c21-b9a7-41ce-ab11-8792d068dbaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("15536165-4744-4fa9-82a9-1468a6917258"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("18185f2a-1ed1-4a4f-9821-153117f00133"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b46d3f6-c4ab-4b95-883d-d260f223f3f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("21524e98-f755-43f4-8d98-1b35475d7970"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("25edd851-cae6-4ad4-81ee-3a2562e61dd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("291abba1-019b-4b7e-adbc-09e143b9a5d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("293a428e-e370-4f4f-811a-1b83bf67f359"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2d00cc04-033d-45d7-b4ed-32260bf65c3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2ddc20dd-13e5-49e4-9d84-ec43d64be8bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3008bf7f-2d1c-47ec-89fe-6a68cc5b9390"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3060c0ad-cb26-45f2-bad7-09a18888885d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("321af58e-99bd-4c01-9afc-d74864b7e9fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("32fe22c9-429c-476b-87a2-a76b52ab4a29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3308ba9a-785f-410b-a086-3e603a50853a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3785ef56-0602-4d36-8962-e53644038ddb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("395aa456-610f-407c-819c-02a48537b1ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3eaba745-569b-4a30-a25c-971561cee38d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3ec16b51-9704-4451-b80a-e09f053a0741"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("50c4d679-d5cc-4a7c-9d8f-6ea758ca046f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5289ec61-bbc3-4ebc-a9bc-9f8d15e0f8b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("53efc40c-1e99-4ad8-a7cb-eadfc14e0d90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("54607227-0140-481f-bb3e-49fa982c36d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("55154d4b-8204-4f43-a2b6-43df3ec6ce11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("58502c4b-fbb8-488f-8ffb-f30c704ffd7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("58cf397e-c6cb-4639-b1ea-bb3b4dd63dcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5e278c2c-2dcb-449a-ad04-46807782547a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ff5285d-dae9-4042-9af4-5d59edf4c5ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("608dd82d-a129-4413-acd3-2a083aea14a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("65bb6295-736f-4e7e-9bde-f1c0ff7d5349"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6cfc4e86-c586-4377-ae57-de5a8375ef4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6d6517e2-d699-4129-9d14-ee85f2f220f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6e0580a0-f418-427e-8722-a2bbbb3ff819"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6e53457f-5191-4720-8c65-d95bb6a49128"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f47b522-cba9-477b-b3a9-eaa24c13f53b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("72b4cd5c-dd2f-4133-9a27-b69d94ee9892"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("72df9ffc-3437-4041-ae4b-6f1f77eace37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("758156bb-2a85-4913-93a1-eb16399d7dc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7752e1ab-8cb1-4ad9-bff2-85ed8b1e80a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("78dfe61b-e986-4644-ace6-743f45cd4aa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d4ac7bd-5952-4b99-8d34-71d503be0d64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d68b131-beff-4509-8a5a-f1da99b1799e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7db6fe35-00a3-401c-96d1-af884fafc71d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("804fd8d9-6535-4733-997c-17197b970b73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("823261ad-e66d-4f63-8926-291c5459ed84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("856ea2c3-ba93-4b9b-9ea9-eb198ecca5c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("86251e4a-6c64-4cab-ae2e-6c114714f3cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8d351e77-1850-4555-bb2f-26a7010f515d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8e01c3a4-8f40-4c57-b179-e2f51f493c27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8f20d302-b3ae-4b49-93f6-eae84fecceeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("93b43bd5-4e6c-4f3d-b776-47a83088cfcf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("93d24d75-0c45-44c6-a1f8-4b7f8bb45515"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9534d522-45cb-4485-aadc-d568dec879f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("96da5712-5866-4ebd-b969-6e3d2d83baee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9873c2a2-1195-4233-8576-7b0fe83e1e0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("99b75264-7f92-4755-bd22-69e52c9e7f50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9b0f16ed-6c5b-42eb-b6f7-59d370590259"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9b2b52fd-2770-4017-8f6e-97fa320b6653"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9e67e714-97e1-4d06-b7a4-223bf67995fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a525ef3e-b706-41b4-a8ec-2facd4a36a8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a6a79e56-ab95-429d-87a4-e444e0685c19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a712c413-4aad-4143-a382-3d542400f533"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aa78c7bc-c42e-40c6-89cb-9305191b283b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("af9642b0-0042-4bac-9c07-5aa6079d1abb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b0baf274-42e2-4509-a1e2-e54f5da15097"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b0e56e12-8fd7-41c6-90aa-e9dafb893d76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b40ce9c1-8fb8-463c-846d-086d7184841e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b6a67262-43c4-4a4a-9c33-38d9f3c45461"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b78f228b-61a6-49bf-9e6b-754b6c588c1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b8e038fc-2939-4b4e-9ac9-7d89f626381a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b97698af-84af-402c-ac7d-c7f9ffd4d1af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("be76fc0e-4a41-40ba-b790-f4586c3c82b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c20f4963-6ddd-4cbb-91d7-0657c7f84052"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c260b105-5531-42ac-af12-dbd8b968791e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c563aea4-df53-4d0e-9ac6-234d2aca1442"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c73ac387-02c4-48ed-a129-4f1790d80847"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cb29504a-79c0-4ed4-863f-aea2df1a5266"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cc6d2e2a-d8a0-4238-b9d5-25bbde55adc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cda780ef-e3d1-44ed-b164-f5bfc83fe543"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cdb93948-be86-44d1-8f84-7039ad1a4fd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d4e68381-25f4-4fe3-aca4-4ba61dd5b38c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d58bc123-f067-4807-9477-2932216c5f9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d77dbf2c-72e4-48f8-be29-c244e0d32c0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d9d180b9-8692-4cdc-86bc-87fb583cf9bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("db7b141e-c7c2-437f-a2c6-49aa0d735de2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dbcd87c9-2184-46d0-9064-0b0bebd53c4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e2120919-b44e-4ef2-a2cf-833851488923"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e28c8bba-f492-47df-aaa7-834445044bf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e5659345-e564-483f-b25f-c5eca715fe9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e82e00a2-21ef-429b-87ba-e89e43b603f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ea4e3a10-4fdc-4816-8c81-20d2b1f66368"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eb064e4e-21a0-48e5-b5e5-b0b3c168263d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f1fbe8ee-d179-435e-a507-309e069d9c20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f348671e-ea32-4d34-91cf-92281b268ac0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3b52c02-07b9-4337-94a0-94c2ef6519d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3ff20fb-9337-4d4c-86d7-87f0f8a1a89e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f40d44e7-59b1-4f6d-ad4c-b9805be3c356"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f772b82c-62bf-4cde-a8bd-ddaa7aec743e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f97aab1b-e473-410e-9d4b-1dadca9d9888"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("faec6a79-606f-42fd-883e-646fc1db4aac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fc97937c-45d6-4cbf-adfa-c5053760562f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ff9e1800-0f20-4209-8fb1-a25372e7cd63"));

            migrationBuilder.AddColumn<string>(
                name: "AddressDetail",
                table: "Parkings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("35d50894-ef75-41a8-b223-01e674dba854"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("41170324-d376-48ef-bd1e-323144a6aebb"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("515cede9-67f1-4ab6-9907-75bbb7d580fd"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("7f35f078-2d46-4b4f-bafc-67ba2f80f703"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("b18cb312-0bb1-469d-8967-f75ec7599966"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("e334eb7c-6ef0-4f81-a03f-414ce975d6b4"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("032834cf-cbee-4b75-a95e-c652400d257e"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$uUUCiTwkcI7pi.MgBpbqNO8DHfTlkZsQBGYMriZ.Zk7pbBnvgC2X.", false, new DateTime(2023, 2, 24, 15, 25, 9, 215, DateTimeKind.Local).AddTicks(7972), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("07b81604-f281-4aff-8172-ec5ad029f03e"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$IOAi7w8XDKRJwfIOC7M5Te72DnoN9P38mAy6pBJnzm.2gvrQGxwfy", false, new DateTime(2023, 2, 24, 15, 25, 9, 535, DateTimeKind.Local).AddTicks(6360), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("0bab334d-6f65-439b-a6d4-5b7ba4e82c5e"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$PHIIGk48DfrRTupCcbmD9u1/YUsIlPPYm7QCGlP4TjbfPB9EaIk3S", false, new DateTime(2023, 2, 24, 15, 25, 8, 107, DateTimeKind.Local).AddTicks(575), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("0c03fb1a-8efc-4a2e-863a-822b29e688aa"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$TGOcb8lSgIfm6lTuo8Kfc.cn38yW/nB47PCY1NZWjKtwE6SDWUPHy", false, new DateTime(2023, 2, 24, 15, 25, 12, 939, DateTimeKind.Local).AddTicks(3865), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("0e4a665b-32a8-4d83-8d58-4a6105563779"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$9wYw2WlOp9M9Pe60qb59Ne4iiHPpA/HEKMicaMu5vGL3r2zEFHbEi", false, new DateTime(2023, 2, 24, 15, 25, 7, 948, DateTimeKind.Local).AddTicks(768), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("18f74d75-4e7f-4709-9c2d-c9637a67088c"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$jzITILSh1CifoBJmM1tzx.oaEK7OEFy3hpMgje/sJ10R/wHEEp.8a", false, new DateTime(2023, 2, 24, 15, 25, 5, 48, DateTimeKind.Local).AddTicks(2197), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("19c1f873-f736-42f8-b5f3-197248b3ad4b"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$wj0hO0/i7txpAwPHso/heek6O4bjScIXOiM23NTmtFY3WPYRIPPwy", false, new DateTime(2023, 2, 24, 15, 25, 10, 942, DateTimeKind.Local).AddTicks(7965), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("1accf5b4-12c4-4165-985b-cc9c1cb40cb7"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$CTqPZs7gZIJ8BJV9DSkDNuJTYNeX8.X/b8W6Nog68YMAb3LhYTQJG", false, new DateTime(2023, 2, 24, 15, 25, 9, 694, DateTimeKind.Local).AddTicks(2823), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("1be5b4e2-89d6-48fd-9fbe-78bf357c4ed9"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$rUO8yNNNrCvsk41fhGafUuUiBCsH7Tqnnqo7tpidW.kotlwPwVlVa", false, new DateTime(2023, 2, 24, 15, 25, 12, 326, DateTimeKind.Local).AddTicks(3971), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("1d783d2f-9225-477b-aea0-a4f57fa03580"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$0shq/03RJZ1nnDWtJVYLtezRhlOWDpceqt3MBur82vGVKZvSi9Unq", false, new DateTime(2023, 2, 24, 15, 25, 13, 717, DateTimeKind.Local).AddTicks(9614), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("203d0788-d645-4b9e-8559-c8333e2b17b4"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$se45HnzDj.tt3PvGNUYPzORtcmPf6EurhueM9EZh9za9ysr018I1O", false, new DateTime(2023, 2, 24, 15, 25, 6, 78, DateTimeKind.Local).AddTicks(4100), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("264ba803-5628-4c8e-97fd-22cd40dbb9f3"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$DFVrYPMhQYTZ8hLGmm2k1OUHxhZUfxGGbgEuMj4gJqGBP1yOdzCMi", false, new DateTime(2023, 2, 24, 15, 25, 14, 275, DateTimeKind.Local).AddTicks(1986), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("2f72b926-84c7-41f4-b669-5da604193224"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$37rdCLvc9VGmh/zs40Aki.a7Nxlo651DTZXCbHpIFoJnZbOE6o1G2", false, new DateTime(2023, 2, 24, 15, 25, 9, 376, DateTimeKind.Local).AddTicks(6048), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("301eb817-decf-4cad-a2b7-3315057ba973"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$fRnXffGdNYFLv1MEyOXJCOJepOq14s68hnRRLJxjsZuMfeCReyo6u", false, new DateTime(2023, 2, 24, 15, 25, 11, 464, DateTimeKind.Local).AddTicks(6102), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("3454c5b9-ca8f-4e56-a6f2-7053178093c1"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$HVeXb5koa3AaYnfKxj0vIOvHmFA5KVOPr9d7m5XeRkP81y2Qlm3PC", false, new DateTime(2023, 2, 24, 15, 25, 10, 13, DateTimeKind.Local).AddTicks(8742), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("35401608-cdd6-4ddc-afb3-58de0004470c"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$qz9HckbLz7hNkhq3I4XGBO8d5euMMAJELHNMLg5EUKbYK951Oj5ja", false, new DateTime(2023, 2, 24, 15, 25, 14, 762, DateTimeKind.Local).AddTicks(2027), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("38a10fe6-a3f9-484c-ac56-ec4abdf1e450"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$qZHMvroKqCQFE5Ei7a/7luEfhUVTImHyh1wPEMrWCo3GPrz7xuBMS", false, new DateTime(2023, 2, 24, 15, 25, 12, 254, DateTimeKind.Local).AddTicks(6046), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("38ed153b-2098-4109-b68c-6747fdb83df5"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$zvtiBZkI5KY/V5EYQaCYKOJiPlnOyrfIqVmqb/wJYCw9aoP5ROT2m", false, new DateTime(2023, 2, 24, 15, 25, 7, 789, DateTimeKind.Local).AddTicks(5501), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("39ec5b28-7d17-4a62-89cd-3b3d31e27d04"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$tcsML9mqqPb2Yna75Jgd0.19sH2/WFG2anehVGUi69OTki0M.L0b2", false, new DateTime(2023, 2, 24, 15, 25, 13, 222, DateTimeKind.Local).AddTicks(3614), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("3a394e22-f98d-4428-8f16-e8a058b1c5d3"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$5NbS34r4Krrxy5rKQYtBA.gfy3uJLENkA2bjwg81T7x7wAK8.Zeq6", false, new DateTime(2023, 2, 24, 15, 25, 11, 400, DateTimeKind.Local).AddTicks(4362), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("3a73526f-8bfd-445b-a83c-3ea1b65328f9"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$Ib0lAYUOkvJMH2hRDK98F.zME3BkCYaCel2viZ8OBX/wuYg0GWXjS", false, new DateTime(2023, 2, 24, 15, 25, 5, 661, DateTimeKind.Local).AddTicks(2418), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("3d4cccc1-f22f-4a44-a77b-cd2a0cbe2f6e"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$UQmkwoYAHw0Az1i58Pr5TuU3vS7cq.hcJyCvgbIDnotOmAg6gm3l2", false, new DateTime(2023, 2, 24, 15, 25, 8, 582, DateTimeKind.Local).AddTicks(1230), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("3db4267d-adab-412e-9e0d-66dc8148116d"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$XAetaNK0Y7rKB3oJCmb39.UsA9drRnQRrTKiQ6BPpDddEOfhqI0uW", false, new DateTime(2023, 2, 24, 15, 25, 6, 362, DateTimeKind.Local).AddTicks(7769), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("407155db-dec4-4cce-9331-8915dfcf26a9"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$k4BAserto1xAFlUZNHjoOeg/qHKU2vPGzlgNj0hwSasnUUQdR0O12", false, new DateTime(2023, 2, 24, 15, 25, 12, 535, DateTimeKind.Local).AddTicks(9976), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("4079f7fb-64fa-4939-8d77-779d863609e2"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$TxdYUxVJD0p.uEawgaW73.Zquzu.yjWRHr4qdJfqHjRdCwxBXG4Yi", false, new DateTime(2023, 2, 24, 15, 25, 4, 983, DateTimeKind.Local).AddTicks(9466), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("4159f330-8a59-472e-8d0c-7a97c0be9f54"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$RZbI/0DTzWSNrdTqMunmKekOChTJvNMZ7yyo9kee1FaflWx88uvIa", false, new DateTime(2023, 2, 24, 15, 25, 9, 852, DateTimeKind.Local).AddTicks(8087), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("42dcdc09-10c2-4773-97ef-e070f7bd6631"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$FjB4BnmKHxTnm1KHWzEQjOmrkU74kJizoWRi1AALA4bcUlqiGyilq", false, new DateTime(2023, 2, 24, 15, 25, 14, 413, DateTimeKind.Local).AddTicks(1731), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("450c1c7b-20e4-473e-8875-2fd5eac3f900"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$9Heo/.IcnfFPdxWJYyHQwuaMUkBp9F8TmbssTg010h2z3ApcpI/O.", false, new DateTime(2023, 2, 24, 15, 25, 12, 181, DateTimeKind.Local).AddTicks(5674), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("45553496-14e2-48fc-9979-9e7ec1a3dd75"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$d6SobqF4KQQSJSz1NqViQOlajBnICVmPQAQbOHqZ3u0gJajRbtpWy", false, new DateTime(2023, 2, 24, 15, 25, 8, 739, DateTimeKind.Local).AddTicks(7547), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("5201c4de-c2ba-42e5-ae6d-194b215dae42"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$U60SuJ.p0rOxu8JwPPx8l.Che4R21jk2Yf7OwNTUfatXcZnAcHjCu", false, new DateTime(2023, 2, 24, 15, 25, 5, 112, DateTimeKind.Local).AddTicks(8729), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("52471814-f662-4a1e-bbe3-7be3b750f500"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$QrJNnUs7N7/51GYlwaw4yui43DQVdor09D3pGRtOQUUB0Nv4q5Eoq", false, new DateTime(2023, 2, 24, 15, 25, 14, 907, DateTimeKind.Local).AddTicks(8319), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("554445c4-43f1-4471-b2bc-13a6b2ba00fd"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$jSSPyNBrtuqG7Axw3bWr3.I6vze79Y.GjQZwRFa3mi43a3Lp8oHiC", false, new DateTime(2023, 2, 24, 15, 25, 13, 645, DateTimeKind.Local).AddTicks(3376), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("56447d18-36d9-476a-b1dd-fbef6141cc54"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$MAopaCjnCcEznUznGgiYcOQ.IhFJ0XcuNElkeOi5ttFFOUlkUoh.6", false, new DateTime(2023, 2, 24, 15, 25, 7, 631, DateTimeKind.Local).AddTicks(2595), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("5927ff44-cb66-46f6-a117-ec60086075f7"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$BCmJAnSBruYUF/e.vw28ouJ.XJN/GxhTgYzxNmmHNlJmj7Ty7ke3i", false, new DateTime(2023, 2, 24, 15, 25, 6, 521, DateTimeKind.Local).AddTicks(6712), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("5a67d636-f6ad-483b-a035-7eac95dfced8"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$ut236cN0kUpmK0bT9vuQWueVMpugfWjMspbbs0VZkQzUm8WcHxknm", false, new DateTime(2023, 2, 24, 15, 25, 11, 7, DateTimeKind.Local).AddTicks(3290), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("5ac04bfa-d7a3-4ebe-bda4-c1218841f69e"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$Ty1NQJvDy/zMJwldIYeize4AhEppuPEdYnv5xnfmVonA.B3XrPzM6", false, new DateTime(2023, 2, 24, 15, 25, 14, 976, DateTimeKind.Local).AddTicks(9303), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("5d298c1f-a2b9-4281-bb22-4eed90dcb696"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$mA8DSQEQE6Is0tyXX48IhenS6WeSkrbgc.Zh1AD/KlRiX0CfYWeny", false, new DateTime(2023, 2, 24, 15, 25, 5, 180, DateTimeKind.Local).AddTicks(5806), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("62092ccd-8918-4c73-b2c5-4716a25db683"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$rCVqdb6DB4x1P6LuB3L4DOJ7Vuz8kP2gIAVwlcQtRIpSz2qyfn44u", false, new DateTime(2023, 2, 24, 15, 25, 13, 933, DateTimeKind.Local).AddTicks(97), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("64d97a67-d7fd-45e9-b577-ab6aa3f0124e"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$dGZPl0DDaDC/A1nO/3nIBOnx2dYkitFvaxMzC8ypVJQXx7UV2nYL.", false, new DateTime(2023, 2, 24, 15, 25, 5, 368, DateTimeKind.Local).AddTicks(1251), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("65493b04-5076-4515-86a8-b618b9c2b66b"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$PJ97kQUyvw.EseHN2vzVreq5Q6yUfzJ4F3NLcmhISOyz8YovpdTUK", false, new DateTime(2023, 2, 24, 15, 25, 13, 148, DateTimeKind.Local).AddTicks(9028), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("69b31113-ddfa-4542-ae66-18306b8ba610"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$ky7xxwQzFCiGJ/Kz7okHXunHJ.Lp3HHuRKBwKyebFruMXFFmq6DR6", false, new DateTime(2023, 2, 24, 15, 25, 10, 617, DateTimeKind.Local).AddTicks(8024), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("6c9969a6-97b8-46c4-b7c5-994fdbab86be"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$hK75NMzBDz.LQCscM8JyduqZrA897j.m7vMf5IfUZIaRs5btSr/06", false, new DateTime(2023, 2, 24, 15, 25, 10, 683, DateTimeKind.Local).AddTicks(6743), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("762552ee-4806-49e5-883c-8ddac7ae0750"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$s9bj3s7WFEkpr6EityilGOririJNYWGzYfRLad2KSh3KLAY1FD/w2", false, new DateTime(2023, 2, 24, 15, 25, 6, 203, DateTimeKind.Local).AddTicks(8272), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("7745d848-3222-4752-8526-cc2155579040"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$.0HwW4zyK4f1GQbq75nbS.T/I7nVfDF/ue8q9nqrXFT2bI.E5b1PK", false, new DateTime(2023, 2, 24, 15, 25, 13, 497, DateTimeKind.Local).AddTicks(2121), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("78890ad4-ef5c-4c7a-8c31-9d139a7fde92"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$T440NfErmmjaVldY8ktSZ.lv.LFpPGzEYhZXvNmo.Bfkz3COnVdga", false, new DateTime(2023, 2, 24, 15, 25, 13, 287, DateTimeKind.Local).AddTicks(3168), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("79e55b7d-1bf4-4175-a638-338d82933297"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$/IQGO3SUi6TD/3x8pWYaXuT7vBPJciLBsEXCaTETFQo5tJxSLsIvi", false, new DateTime(2023, 2, 24, 15, 25, 8, 265, DateTimeKind.Local).AddTicks(2208), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("7b630680-30a0-4848-8229-424b190b01f5"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$3aI9eGoP2PV4YnIwxp3FmO9WYhqqjlSAKzpQCKLfLTJcecfsdCF9e", false, new DateTime(2023, 2, 24, 15, 25, 7, 473, DateTimeKind.Local).AddTicks(3615), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("7fd60b1f-0be3-4096-93fb-ab81831a58f4"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$B.Jun4P08mLjWi0EaxqwG.UcxlvVeffHU.3DXdocSvIj01lX8.tDu", false, new DateTime(2023, 2, 24, 15, 25, 7, 315, DateTimeKind.Local).AddTicks(1319), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("83bc6716-d341-44d2-bf2c-d06e57cee931"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$Y85tkK/MeGOyq8j5kLUXh.zFK28E.3dyXT.m.qup7VdbeanZMgYMe", false, new DateTime(2023, 2, 24, 15, 25, 10, 417, DateTimeKind.Local).AddTicks(829), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("85affaf7-cc79-4fa3-8603-a06cd3b40aea"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$DCOcEXyi2JMuiHyI5Phj0u5jrwVpFzjsVF7QO1s2lhg6CQLZQwZ.u", false, new DateTime(2023, 2, 24, 15, 25, 11, 731, DateTimeKind.Local).AddTicks(3869), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("86226c08-fe51-4086-a80a-231a830c7725"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$6ZIRSEwIvR/rxzQwkbbhqukLWtdr6.ryR1jN1fX9OzbUgyd37lTg2", false, new DateTime(2023, 2, 24, 15, 25, 6, 838, DateTimeKind.Local).AddTicks(8318), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("88c8e3fb-cc22-43ef-96b6-4f7c7dbf1071"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$aTY5Lk8crAYvCJxwhgy7le.X58cvU.5v3Z09e2ll99JbxelY4Pxzy", false, new DateTime(2023, 2, 24, 15, 25, 11, 335, DateTimeKind.Local).AddTicks(571), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("8aa89af5-3d8f-49e7-ad48-2ab2a7c406bb"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$gxaFXkEoUMYzUkW/9vZtWOkwepESG.SZNw/u/Sp0o1QsspAZqyDFi", false, new DateTime(2023, 2, 24, 15, 25, 11, 528, DateTimeKind.Local).AddTicks(1847), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("8d504997-f0b7-4bb5-900e-e0bc17882467"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$C1fLMBEq/Ts99TsOlO0eWe2Eqvyjf.g.p2Gv9KgXh7DL59SbCrjTa", false, new DateTime(2023, 2, 24, 15, 25, 10, 217, DateTimeKind.Local).AddTicks(2096), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("8de2e2c0-719d-4367-8a7f-b0ddeea972b7"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$smC9IujMIGbx6UlExKDkQu7mEa6O2qwakfJ2q0fhJONx1RSlt0jFO", false, new DateTime(2023, 2, 24, 15, 25, 10, 483, DateTimeKind.Local).AddTicks(5893), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("8ea6db50-4376-4e8c-9fbb-69e0f0d87755"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$ksPg/3EtenaYGP6OlXtpK.YCIylQyW2Np6YnKgzbIknw79oqTEDni", false, new DateTime(2023, 2, 24, 15, 25, 10, 815, DateTimeKind.Local).AddTicks(4495), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("9184728a-c40d-426f-8062-9c4cd12996ec"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$nqKY/u8zEEoEULkyYhn1L.jEJSbsBxjTwT198jVGVzBcRizY4sDgq", false, new DateTime(2023, 2, 24, 15, 25, 10, 552, DateTimeKind.Local).AddTicks(78), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("92087a64-cf30-4f58-b1ef-0a7f622e1c52"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$d3VR2cuJXnCtDMyWJZNv4OXRv.BZUvdNfPJjfHsey0e7mClDCgYc.", false, new DateTime(2023, 2, 24, 15, 25, 11, 953, DateTimeKind.Local).AddTicks(7463), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("9782fcec-ea61-4aab-b877-6e198f7359da"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$2m86Cygn1wCqGjx5LOn3xecNU8/bXuZ8FLbCXkuB8imajzG6Fgsii", false, new DateTime(2023, 2, 24, 15, 25, 12, 604, DateTimeKind.Local).AddTicks(9062), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("9aeff0b6-9714-46cb-b0a8-2fde558f2961"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$KBmfSC3a/d9nlSZkSJF5xOw9dbQlURNnhqFvCd0s2Jlsn6LJLaj/a", false, new DateTime(2023, 2, 24, 15, 25, 10, 749, DateTimeKind.Local).AddTicks(6516), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("9c1ae8b4-b6cb-4048-aef7-7d54708232fb"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$6YgUntT1KKYze5NHpsCC2etAyV61LcPjHZPjzcsS0GICkRZcy7gku", false, new DateTime(2023, 2, 24, 15, 25, 12, 873, DateTimeKind.Local).AddTicks(2918), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("9eb4bdbc-dae5-459e-a84d-bead57eb8473"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$hM3EIa0Ikx/2OGcN86gS4uUjd93NJzKNASX6m71gZaWqoMQgPbGsK", false, new DateTime(2023, 2, 24, 15, 25, 14, 209, DateTimeKind.Local).AddTicks(4718), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("a0ef574b-1f5c-42a0-9352-ff81607266b9"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$g7ou.C5X3gqY56UkChDLzOqSFbgY5.ZWBbx4EOAeXioOdZJmE0pZ.", false, new DateTime(2023, 2, 24, 15, 25, 10, 879, DateTimeKind.Local).AddTicks(4315), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("a64eb0f8-7f67-49de-9b62-a66999503e40"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$YbydJR3Aq8Zas84wS9fED.mdkPdqf7pUSt2fE/IYNz8VjuCF3mbwS", false, new DateTime(2023, 2, 24, 15, 25, 5, 742, DateTimeKind.Local).AddTicks(3613), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("a92abadc-ff93-46a1-8ad5-accb226c2343"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$TTPKOPkHgmhFnSo/mmWj7e8wrOgxa5j/YFKaiOlc9pZXocX1vSmZC", false, new DateTime(2023, 2, 24, 15, 25, 12, 35, DateTimeKind.Local).AddTicks(3470), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("aa600d03-95c3-413e-bffa-2a32aad89020"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$9yfD4aPUIa.SqxB5JU3NqOdcWPjOu/2iSH4TvA6bYzbN7OSVeDlbq", false, new DateTime(2023, 2, 24, 15, 25, 8, 423, DateTimeKind.Local).AddTicks(8575), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("ab4a20bf-4dc8-4c9f-a6b7-fe5da971080d"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$dMhKgG8pxjyODVl2qfVrveJVVcBEZqrgQuBONh71Om4VQE.JlA1/6", false, new DateTime(2023, 2, 24, 15, 25, 12, 462, DateTimeKind.Local).AddTicks(8092), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("ab8b873e-8c37-4064-9d15-0bca9c499573"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$QUsXI/UlATuJuTgTwQwFuu0FDj7UkUuB50I9R3EqV9aP/OWRnqGBy", false, new DateTime(2023, 2, 24, 15, 25, 13, 862, DateTimeKind.Local).AddTicks(6216), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("acd75a0f-ddfe-40e0-b209-34e68612ae6f"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$DjONLlFU680d2HvZhum52.3V/BqQeLuITSyjQLH.lKJIdmaOZ6ceC", false, new DateTime(2023, 2, 24, 15, 25, 13, 74, DateTimeKind.Local).AddTicks(8363), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("ae1e1968-08b9-4b7a-ab8d-57cfe1c71286"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$u1TMCOJscZL4apg3a3d6XOAougpRje5dlFaq6H80vV.P6PDYpQ/mm", false, new DateTime(2023, 2, 24, 15, 25, 5, 877, DateTimeKind.Local).AddTicks(3003), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("ae83bbec-6c25-4a37-af02-7efa8567aa70"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$y.fTvVv.iwMHPviGIZa0AeZRORhMhjn94NqciWE.q.uKlnwgQql5G", false, new DateTime(2023, 2, 24, 15, 25, 11, 139, DateTimeKind.Local).AddTicks(4765), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("b0ae1748-c85e-412b-bbb3-9a2aa147748a"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$8aEEdI.q0vqyeAEbHIHkCOibsYz6FR.J/vGADhglsh52v72aUdcDy", false, new DateTime(2023, 2, 24, 15, 25, 10, 149, DateTimeKind.Local).AddTicks(1021), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("b307ace7-1362-44b2-9823-3c618ab8b9ea"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$5MXlPJUZK91zs6Bz1PqqQ.Dl1iT3vRwZa2te6mxjwpK/G1D/9gUSS", false, new DateTime(2023, 2, 24, 15, 25, 8, 899, DateTimeKind.Local).AddTicks(3225), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("b40762c1-ad9f-4c81-b45b-e139537f8a6b"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$Q1jdkPkA4zAKrV6gm/qrVOJeoJwMlDcycOmH5BAOW2ONkp0lPMbEO", false, new DateTime(2023, 2, 24, 15, 25, 11, 596, DateTimeKind.Local).AddTicks(9117), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("b466a306-0b0d-48b6-8f8f-fb1adb3a6181"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$33iwUvoeJGz7GJjmiWg.9OTHhg3rfiWHBQfK.DKShtApBJdeAl8Gm", false, new DateTime(2023, 2, 24, 15, 25, 11, 203, DateTimeKind.Local).AddTicks(8656), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("b54f09c9-e904-43dd-92fb-7dc9de6fdd3f"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$KJ5JHcJ7YoP9u5DSA4yUjevdBY1gh5V5GwnqaRKE8qpIYr/g7mD5y", false, new DateTime(2023, 2, 24, 15, 25, 14, 693, DateTimeKind.Local).AddTicks(9235), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("b5f60ca9-db32-4dc5-9432-7f591ad24ac5"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$CjLIW61EalVaHiii5hY8v.Pc7Kr/bkjmx4PXAROO4tyVnzXVlyXqO", false, new DateTime(2023, 2, 24, 15, 25, 13, 572, DateTimeKind.Local).AddTicks(1488), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("b8a76eeb-1678-40e2-8332-005afe71348d"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$506BE4LgJmIThPufuyqqZ.v2XqIzUNsDzxGB4Gc6it7qkrSrEa4RS", false, new DateTime(2023, 2, 24, 15, 25, 5, 523, DateTimeKind.Local).AddTicks(1639), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("baa609a9-88d8-4fb3-9696-515e9a8a6a68"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$qUsj0MwxkV0wOBtQcjKp5uQjQvXnfcC9FozTdPr4QovjjRbEvzZTO", false, new DateTime(2023, 2, 24, 15, 25, 14, 837, DateTimeKind.Local).AddTicks(9717), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("bc7afe74-e651-4e0c-b4b7-6668e3925f43"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$/8nS75C2UBI5wiczOKv/tOuoiqgoWlxEk2yWOrLcwRzBOeD7Tdso.", false, new DateTime(2023, 2, 24, 15, 25, 11, 74, DateTimeKind.Local).AddTicks(4673), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("c2fdc4aa-b11e-48d6-90ab-3aad36665db3"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$RC6/MbGWayZbzPleRcotguocpeDgBO/ga9FpNUwcg6dmyeSvut.uy", false, new DateTime(2023, 2, 24, 15, 25, 6, 680, DateTimeKind.Local).AddTicks(2020), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("c3c8f2bb-f988-4443-80bb-9acdd30c4fa0"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$nodl0AFV0wmeAqS1o/dmjuHLdULlRw.axmHnpc/P44x9HXeP1qaq6", false, new DateTime(2023, 2, 24, 15, 25, 5, 810, DateTimeKind.Local).AddTicks(6702), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("c63d83c0-1b2f-48ae-9632-85e0345767da"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$RnhxxsvuUj6M6Cuyytg96.Jlfd28THHoRdnMg4U2kg9NePkvMY1xK", false, new DateTime(2023, 2, 24, 15, 25, 6, 10, DateTimeKind.Local).AddTicks(2897), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("c6688e9d-e694-4607-9196-b87471a48d74"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$3Dg3GeJ9gEf8OYf0W9CsxOrby.s/bquoYSjVQjRGRwg6G9.vkMrfS", false, new DateTime(2023, 2, 24, 15, 25, 13, 424, DateTimeKind.Local).AddTicks(6253), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("c76fb133-6bd0-4e83-aef7-26f1d196ebe0"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$5J6u9VfQgEvp/9Is.mJzYuJFYAFmUYZD.G86dphzxihBNnb/jNfme", false, new DateTime(2023, 2, 24, 15, 25, 13, 789, DateTimeKind.Local).AddTicks(505), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("c78e2c29-27d6-4cc6-834b-09e52e66057d"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$vyZntcnQF.NUK07C3WR7lOKGYPzV/XEmGRuiJ983HEk6OshX8BpVC", false, new DateTime(2023, 2, 24, 15, 25, 14, 5, DateTimeKind.Local).AddTicks(9308), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("c85d05ca-5079-4251-bf27-f549900419b6"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$9WAEbxmTzNcBVXxMIAtI.OjCO6kKFJFGzvz0Wfkt.ESLSqgzjsRxK", false, new DateTime(2023, 2, 24, 15, 25, 6, 997, DateTimeKind.Local).AddTicks(3500), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("cfd15984-c283-4a3f-946a-0d17e4a183a7"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$pBeRZbJfuXG2rN5HMOo1iOrDGLKcRUvSGXWN1x1/R0w5ZgfHWoFGi", false, new DateTime(2023, 2, 24, 15, 25, 5, 589, DateTimeKind.Local).AddTicks(9181), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("d0d10586-272f-49e7-b30e-ab273a4a83f6"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$/dtWQwFvK5s4KsN5h/y.6eMn3JEBs4rBXTC7xaGDpe292xGOx732C", false, new DateTime(2023, 2, 24, 15, 25, 13, 352, DateTimeKind.Local).AddTicks(666), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("d0d10834-88f5-47f5-b421-e13ae03fb9b9"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$qdj3A2d4IEg/Ehq4AMhnVeo9GIBM.AOta6HgZ/493O2a3/NatuBuu", false, new DateTime(2023, 2, 24, 15, 25, 11, 667, DateTimeKind.Local).AddTicks(416), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("d45f2292-a9ed-4b7e-9463-a5a05566849a"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$x5YVtC9xw.wigCez2ZBz0Orcl/6A27yPAsKL3mbZ.NULC9iZQK3Y2", false, new DateTime(2023, 2, 24, 15, 25, 14, 555, DateTimeKind.Local).AddTicks(6556), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("d7f14f0e-417c-4558-aa0e-8f3dd1b53fdc"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$pZBLo7dHtzjfO.e94Lx13u2Imgw3p16ItJbmZwAMzLbbBl1ytBbaG", false, new DateTime(2023, 2, 24, 15, 25, 13, 4, DateTimeKind.Local).AddTicks(2851), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("d968f361-43b0-49d0-9138-611a27f5544e"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$TzD4HXNintvEjR.x4lsH..KEy4mAsIHaMwgDq4q8atsLP1Tb9qV0e", false, new DateTime(2023, 2, 24, 15, 25, 11, 269, DateTimeKind.Local).AddTicks(3838), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("daa5df0c-4a76-43c8-96e5-e93e4c5b3ee8"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$8momeNfU7rYQy7U8hWjr7.dsIeffIgT6tyH5vwNX91oH.JNwCto6.", false, new DateTime(2023, 2, 24, 15, 25, 12, 804, DateTimeKind.Local).AddTicks(4375), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("dae67af4-4e1f-4078-a57c-d61ea0841069"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$uYnDNIH4NUVD6yfBrln8tek3af8CvEE/JoSWXQO96x1149.A4e0MW", false, new DateTime(2023, 2, 24, 15, 25, 5, 275, DateTimeKind.Local).AddTicks(7891), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("e009d174-c7b3-4c92-9734-bdcf466107f3"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$hGxzCAtu4umseUm.dTG5hu7Ur2duoU1BTiAvmJ92DBPCbcrRLjh5K", false, new DateTime(2023, 2, 24, 15, 25, 9, 57, DateTimeKind.Local).AddTicks(1777), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("e02d294b-0ad4-49c8-89ac-0344d7047270"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$RHiFk82ygGwnmbzZLjdKT.mHqtm7Ej.v1PVOHcCErGAWD8VWrK3Sm", false, new DateTime(2023, 2, 24, 15, 25, 12, 735, DateTimeKind.Local).AddTicks(4347), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("e0b2721f-17d5-42b9-8ffe-76cfe2ad270d"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$oA1bQozx20WI1lKv47/8su23zza3HsmhWmvSFluT0ZFjMkf4IVSXa", false, new DateTime(2023, 2, 24, 15, 25, 11, 875, DateTimeKind.Local).AddTicks(1663), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("e28fcd35-3eab-4f6d-9ddd-4e021734470b"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$QaN.Xr4WkN5I5UUqdI3csen0CX0jDgUHfYyD08v5fbGfFgLXn9RES", false, new DateTime(2023, 2, 24, 15, 25, 14, 142, DateTimeKind.Local).AddTicks(6634), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("e2fc91c5-d3cc-4867-9ae9-9b4f06267b09"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$M4JpxeaNelsmyVoWORgzC.F.QXipkVk/gWVGqvSenyL39m/djN7Am", false, new DateTime(2023, 2, 24, 15, 25, 11, 800, DateTimeKind.Local).AddTicks(4456), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("e7e2eeec-a083-410c-9d66-1215b864a58a"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$vd4gnix02WiC3OuHAhzOVOaiI4om4x4Ecrtj2.cStWzW6LSmQ.VLO", false, new DateTime(2023, 2, 24, 15, 25, 10, 283, DateTimeKind.Local).AddTicks(5166), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("e901e724-3c28-44c6-b741-2db95d7e3e2d"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$xOLK/42cbB4gGjORoTtHheSDLR0AX/i4CgYK7ozSDvObi63dXoMai", false, new DateTime(2023, 2, 24, 15, 25, 10, 349, DateTimeKind.Local).AddTicks(3821), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("ea9bbc7e-51b3-46ab-a5c7-143b98ad4078"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$mI8R9gSk9cLgP5IgjMP2q.X9.buB9H2fzrviYDeUBlO7QGMlYHyjO", false, new DateTime(2023, 2, 24, 15, 25, 5, 451, DateTimeKind.Local).AddTicks(802), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("ebe5ae41-9563-481d-8468-590919d4374d"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$v3jhpUm6dDbCIUR/xvKppun85/1vbIiUEFxBnEJvuq86RCHw4dQxm", false, new DateTime(2023, 2, 24, 15, 25, 14, 487, DateTimeKind.Local).AddTicks(8520), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("ee97fbb5-9472-461f-80e4-dc1d1a296162"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$dDKBCJvoAP4L6v1wd2bh8utaEF152Uq6XKf6HPGdlqRR0FvL.6vFy", false, new DateTime(2023, 2, 24, 15, 25, 7, 156, DateTimeKind.Local).AddTicks(6572), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("eeaf72e3-cbef-4536-ad45-637589e37051"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$Lzk4ZK82dqGCDht77nWcMuE1KuUrHLxSJYbjWy6JrfMyGBrJv8wEu", false, new DateTime(2023, 2, 24, 15, 25, 12, 670, DateTimeKind.Local).AddTicks(6088), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("f4bf0ab0-2781-4ce8-b52a-13005d800416"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$cDrXa252JoQ2WTxGjFH5JennHhDUHlf0M2BJN5J6OOfLLqWXCEaQq", false, new DateTime(2023, 2, 24, 15, 25, 14, 77, DateTimeKind.Local).AddTicks(173), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("f55e72f7-d0ba-4992-b53d-1d5298d33a7d"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$hpsSuX4RWrQR4vuSdQPzY.boMncumsqh0fMK2ScTDHqSDdw3phJmC", false, new DateTime(2023, 2, 24, 15, 25, 14, 340, DateTimeKind.Local).AddTicks(6798), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("f9e3b215-b4f0-41f2-972b-25f59755ad5b"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$.L/KeuBH2apvusRSIE7cSerHos5oY6pvv6hdL6qhTvNTK2zjmls5K", false, new DateTime(2023, 2, 24, 15, 25, 5, 944, DateTimeKind.Local).AddTicks(841), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("fa8b3368-77f7-4719-9502-5554dc9bba5f"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$JEbC1WPYBLVs6W050DhfWeaSH0MhvGWDoSlI5tAMrZP3TrfTGadFO", false, new DateTime(2023, 2, 24, 15, 25, 12, 393, DateTimeKind.Local).AddTicks(239), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("fd47e6e9-d6d2-419d-b16d-9f6e6986812f"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$GfDyuHwzmR.NUo4olRX.aeraBf2jpV8a3RoWZH/ZoNzNkZFStVOrO", false, new DateTime(2023, 2, 24, 15, 25, 14, 626, DateTimeKind.Local).AddTicks(6280), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("ffa94ddc-f488-4c79-8144-8d590820fd4b"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$cWnTmrFK3.89J351gQcrJu0jX3xwzSh0MLukDDXg2A.3sJIg4Szpq", false, new DateTime(2023, 2, 24, 15, 25, 12, 109, DateTimeKind.Local).AddTicks(1117), "Stranger", null, null, "03239623484", 2, "gstranger1x" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("35d50894-ef75-41a8-b223-01e674dba854"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("41170324-d376-48ef-bd1e-323144a6aebb"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("515cede9-67f1-4ab6-9907-75bbb7d580fd"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("7f35f078-2d46-4b4f-bafc-67ba2f80f703"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("b18cb312-0bb1-469d-8967-f75ec7599966"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("e334eb7c-6ef0-4f81-a03f-414ce975d6b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("032834cf-cbee-4b75-a95e-c652400d257e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("07b81604-f281-4aff-8172-ec5ad029f03e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0bab334d-6f65-439b-a6d4-5b7ba4e82c5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0c03fb1a-8efc-4a2e-863a-822b29e688aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0e4a665b-32a8-4d83-8d58-4a6105563779"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("18f74d75-4e7f-4709-9c2d-c9637a67088c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("19c1f873-f736-42f8-b5f3-197248b3ad4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1accf5b4-12c4-4165-985b-cc9c1cb40cb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1be5b4e2-89d6-48fd-9fbe-78bf357c4ed9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1d783d2f-9225-477b-aea0-a4f57fa03580"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("203d0788-d645-4b9e-8559-c8333e2b17b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("264ba803-5628-4c8e-97fd-22cd40dbb9f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f72b926-84c7-41f4-b669-5da604193224"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("301eb817-decf-4cad-a2b7-3315057ba973"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3454c5b9-ca8f-4e56-a6f2-7053178093c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("35401608-cdd6-4ddc-afb3-58de0004470c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("38a10fe6-a3f9-484c-ac56-ec4abdf1e450"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("38ed153b-2098-4109-b68c-6747fdb83df5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("39ec5b28-7d17-4a62-89cd-3b3d31e27d04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3a394e22-f98d-4428-8f16-e8a058b1c5d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3a73526f-8bfd-445b-a83c-3ea1b65328f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3d4cccc1-f22f-4a44-a77b-cd2a0cbe2f6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3db4267d-adab-412e-9e0d-66dc8148116d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("407155db-dec4-4cce-9331-8915dfcf26a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4079f7fb-64fa-4939-8d77-779d863609e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4159f330-8a59-472e-8d0c-7a97c0be9f54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("42dcdc09-10c2-4773-97ef-e070f7bd6631"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("450c1c7b-20e4-473e-8875-2fd5eac3f900"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("45553496-14e2-48fc-9979-9e7ec1a3dd75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5201c4de-c2ba-42e5-ae6d-194b215dae42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("52471814-f662-4a1e-bbe3-7be3b750f500"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("554445c4-43f1-4471-b2bc-13a6b2ba00fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("56447d18-36d9-476a-b1dd-fbef6141cc54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5927ff44-cb66-46f6-a117-ec60086075f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5a67d636-f6ad-483b-a035-7eac95dfced8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ac04bfa-d7a3-4ebe-bda4-c1218841f69e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5d298c1f-a2b9-4281-bb22-4eed90dcb696"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62092ccd-8918-4c73-b2c5-4716a25db683"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("64d97a67-d7fd-45e9-b577-ab6aa3f0124e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("65493b04-5076-4515-86a8-b618b9c2b66b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("69b31113-ddfa-4542-ae66-18306b8ba610"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6c9969a6-97b8-46c4-b7c5-994fdbab86be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("762552ee-4806-49e5-883c-8ddac7ae0750"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7745d848-3222-4752-8526-cc2155579040"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("78890ad4-ef5c-4c7a-8c31-9d139a7fde92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("79e55b7d-1bf4-4175-a638-338d82933297"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7b630680-30a0-4848-8229-424b190b01f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7fd60b1f-0be3-4096-93fb-ab81831a58f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83bc6716-d341-44d2-bf2c-d06e57cee931"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("85affaf7-cc79-4fa3-8603-a06cd3b40aea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("86226c08-fe51-4086-a80a-231a830c7725"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("88c8e3fb-cc22-43ef-96b6-4f7c7dbf1071"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8aa89af5-3d8f-49e7-ad48-2ab2a7c406bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8d504997-f0b7-4bb5-900e-e0bc17882467"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8de2e2c0-719d-4367-8a7f-b0ddeea972b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8ea6db50-4376-4e8c-9fbb-69e0f0d87755"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9184728a-c40d-426f-8062-9c4cd12996ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("92087a64-cf30-4f58-b1ef-0a7f622e1c52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9782fcec-ea61-4aab-b877-6e198f7359da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9aeff0b6-9714-46cb-b0a8-2fde558f2961"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9c1ae8b4-b6cb-4048-aef7-7d54708232fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9eb4bdbc-dae5-459e-a84d-bead57eb8473"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a0ef574b-1f5c-42a0-9352-ff81607266b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a64eb0f8-7f67-49de-9b62-a66999503e40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a92abadc-ff93-46a1-8ad5-accb226c2343"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aa600d03-95c3-413e-bffa-2a32aad89020"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab4a20bf-4dc8-4c9f-a6b7-fe5da971080d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab8b873e-8c37-4064-9d15-0bca9c499573"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("acd75a0f-ddfe-40e0-b209-34e68612ae6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ae1e1968-08b9-4b7a-ab8d-57cfe1c71286"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ae83bbec-6c25-4a37-af02-7efa8567aa70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b0ae1748-c85e-412b-bbb3-9a2aa147748a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b307ace7-1362-44b2-9823-3c618ab8b9ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b40762c1-ad9f-4c81-b45b-e139537f8a6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b466a306-0b0d-48b6-8f8f-fb1adb3a6181"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b54f09c9-e904-43dd-92fb-7dc9de6fdd3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b5f60ca9-db32-4dc5-9432-7f591ad24ac5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b8a76eeb-1678-40e2-8332-005afe71348d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("baa609a9-88d8-4fb3-9696-515e9a8a6a68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bc7afe74-e651-4e0c-b4b7-6668e3925f43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c2fdc4aa-b11e-48d6-90ab-3aad36665db3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c3c8f2bb-f988-4443-80bb-9acdd30c4fa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c63d83c0-1b2f-48ae-9632-85e0345767da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c6688e9d-e694-4607-9196-b87471a48d74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c76fb133-6bd0-4e83-aef7-26f1d196ebe0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c78e2c29-27d6-4cc6-834b-09e52e66057d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c85d05ca-5079-4251-bf27-f549900419b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cfd15984-c283-4a3f-946a-0d17e4a183a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d0d10586-272f-49e7-b30e-ab273a4a83f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d0d10834-88f5-47f5-b421-e13ae03fb9b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d45f2292-a9ed-4b7e-9463-a5a05566849a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d7f14f0e-417c-4558-aa0e-8f3dd1b53fdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d968f361-43b0-49d0-9138-611a27f5544e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("daa5df0c-4a76-43c8-96e5-e93e4c5b3ee8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dae67af4-4e1f-4078-a57c-d61ea0841069"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e009d174-c7b3-4c92-9734-bdcf466107f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e02d294b-0ad4-49c8-89ac-0344d7047270"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e0b2721f-17d5-42b9-8ffe-76cfe2ad270d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e28fcd35-3eab-4f6d-9ddd-4e021734470b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e2fc91c5-d3cc-4867-9ae9-9b4f06267b09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7e2eeec-a083-410c-9d66-1215b864a58a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e901e724-3c28-44c6-b741-2db95d7e3e2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ea9bbc7e-51b3-46ab-a5c7-143b98ad4078"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ebe5ae41-9563-481d-8468-590919d4374d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee97fbb5-9472-461f-80e4-dc1d1a296162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eeaf72e3-cbef-4536-ad45-637589e37051"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f4bf0ab0-2781-4ce8-b52a-13005d800416"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f55e72f7-d0ba-4992-b53d-1d5298d33a7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f9e3b215-b4f0-41f2-972b-25f59755ad5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa8b3368-77f7-4719-9502-5554dc9bba5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fd47e6e9-d6d2-419d-b16d-9f6e6986812f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ffa94ddc-f488-4c79-8144-8d590820fd4b"));

            migrationBuilder.DropColumn(
                name: "AddressDetail",
                table: "Parkings");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("2c59e238-1da0-4ec0-a243-5bc5c15c90d6"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("3e97bdcc-c9ab-4e8c-806c-8a20dfa80660"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("5121a810-8032-4c0f-9b9f-ca36978a1372"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("ccc75c1f-5c65-4896-8c2c-764906c360d2"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("e4976a8a-35ad-4d98-9475-aa9911e30706"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("f9efbedc-eae2-4a6b-a267-b27471bfbad5"), "Xe 2 khoang", null, null, "Mini", 15000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01f1a277-e765-4b7f-b55f-2517241e09c6"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$pvvaPQr8Cbfh0kjtshxfxe7We8IQwl5pXcuF3z0o8UKyBxfMgvtCa", false, new DateTime(2023, 2, 24, 15, 13, 27, 857, DateTimeKind.Local).AddTicks(6201), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("047bfd41-f27a-4e4f-a0a0-0a127e5dfae0"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$RMcoeVNt3ZR5h.Gkhe.3hOKLGPDujhpfMjd8USPd0VkTenwvmDKuy", false, new DateTime(2023, 2, 24, 15, 13, 34, 725, DateTimeKind.Local).AddTicks(7363), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("05602db6-37f9-4720-9347-1198bf4120d9"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$7eOs816OG2JsAxA3tfpHyu87gV3vgXXT9XKrNn.g8noLHUDyUe/wi", false, new DateTime(2023, 2, 24, 15, 13, 33, 653, DateTimeKind.Local).AddTicks(8290), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("05c4e3e3-4c4d-4b65-be48-3804f1835f6d"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$h1DfyAadD3I9ID/CIvfpbe6jXByGR/X7o.gSCbQmYBEtcnAmblxly", false, new DateTime(2023, 2, 24, 15, 13, 38, 43, DateTimeKind.Local).AddTicks(4356), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("05d20112-70a8-4d16-aa12-3fa7f1e51e77"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$XqH7gg3m.whJ367Ne/YSZ.esR7GR8fepxk8O.u8U7JpjKqv7.bzfS", false, new DateTime(2023, 2, 24, 15, 13, 37, 939, DateTimeKind.Local).AddTicks(6648), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("0b4866de-e8d1-4cab-b33f-35ddefaa3133"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$rXBlDG03cuZffz0En/KSmeSRMDIM73xZcfX5JKDXzDuKHlXAtwLWe", false, new DateTime(2023, 2, 24, 15, 13, 32, 852, DateTimeKind.Local).AddTicks(5527), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("104260c1-4162-4ade-84bc-f9acf18ecbbb"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$7qoJ9q6yenF303foGmess.lEEdKYJLB232.tQQ5yt.lsXyP282ySC", false, new DateTime(2023, 2, 24, 15, 13, 37, 438, DateTimeKind.Local).AddTicks(7044), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("11a9a150-0e26-4786-bae3-de299e52179c"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$8H3N7GkbFfibnzgBIYmPgOoVnX2jzY2GHToUC6g8LbyocOApZ91bC", false, new DateTime(2023, 2, 24, 15, 13, 30, 707, DateTimeKind.Local).AddTicks(3691), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("11cfb069-2c32-4f09-9bd3-00ef78f1f823"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$.TMs2uSwgUCLo0M8Cr/fV.GZdAacxlZsc4Yw4LA7eNDecfCsnYAKC", false, new DateTime(2023, 2, 24, 15, 13, 34, 2, DateTimeKind.Local).AddTicks(7026), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("13543eb1-49f6-4c87-8117-21dc26a0d477"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$RWurQJ5iZQ6plo89HRmZoOv35HllSaPmGVG0X3xM6Eord9d315fPy", false, new DateTime(2023, 2, 24, 15, 13, 33, 78, DateTimeKind.Local).AddTicks(5089), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("136d6c21-b9a7-41ce-ab11-8792d068dbaf"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$Dm28Ykv0Uux/X.xdNukRb.A8tYi4/hh5CLeKXCWDngEZUOG3Cd0ES", false, new DateTime(2023, 2, 24, 15, 13, 37, 715, DateTimeKind.Local).AddTicks(5801), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("15536165-4744-4fa9-82a9-1468a6917258"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$V.U7LMUMqrvuBec2AqOlWupatCBT82brx5nkB/VMzZW5RqcuEH9he", false, new DateTime(2023, 2, 24, 15, 13, 31, 454, DateTimeKind.Local).AddTicks(4909), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("18185f2a-1ed1-4a4f-9821-153117f00133"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$ANbSdxTg7av5WF1z0dbqbe0ZBCo7dSZr8MDooVKrJNreKHa7ppmBG", false, new DateTime(2023, 2, 24, 15, 13, 34, 171, DateTimeKind.Local).AddTicks(8846), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("1b46d3f6-c4ab-4b95-883d-d260f223f3f8"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$URUK0q7rHbYb4J0j6ZCJAuWKlLSYGBpEpawtYv5oxi7.QWHvmusXq", false, new DateTime(2023, 2, 24, 15, 13, 35, 800, DateTimeKind.Local).AddTicks(3469), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("21524e98-f755-43f4-8d98-1b35475d7970"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$.OVbrPybCb.ZpSIBgzI1k.wn5QQ/ic5Zmm2wPHxQWbYETuYDGei0q", false, new DateTime(2023, 2, 24, 15, 13, 36, 456, DateTimeKind.Local).AddTicks(3413), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("25edd851-cae6-4ad4-81ee-3a2562e61dd6"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$mN3iS/XlQIZNuXPh4NidPeoyVuNUgBOreMdLqNomBCbrtKirYqo92", false, new DateTime(2023, 2, 24, 15, 13, 32, 735, DateTimeKind.Local).AddTicks(8695), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("291abba1-019b-4b7e-adbc-09e143b9a5d5"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$HdkyERXk9wQYkDfpcRmwk.psdoOamTNMj/sHVrpi56OCtMVMP.sw2", false, new DateTime(2023, 2, 24, 15, 13, 30, 231, DateTimeKind.Local).AddTicks(7322), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("293a428e-e370-4f4f-811a-1b83bf67f359"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$qZMg1vjRNxNllBPKfOcXF.0WCUZHN/s3xLxTMxQZAu7q.k0ARJrPi", false, new DateTime(2023, 2, 24, 15, 13, 27, 674, DateTimeKind.Local).AddTicks(2509), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("2d00cc04-033d-45d7-b4ed-32260bf65c3e"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$pzdqbkN0yC9OCONyBfKhOOrvfFhGsySXJEJvwenglGxt5koNkSDyG", false, new DateTime(2023, 2, 24, 15, 13, 27, 529, DateTimeKind.Local).AddTicks(7661), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("2ddc20dd-13e5-49e4-9d84-ec43d64be8bc"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$4sZJZaKCbNoPwkyV.3ChguzDjofY1tKBN2NLw2pi1R5SDKkbRvZz6", false, new DateTime(2023, 2, 24, 15, 13, 29, 7, DateTimeKind.Local).AddTicks(3960), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("3008bf7f-2d1c-47ec-89fe-6a68cc5b9390"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$DwGZqzq82AZeHQ0RapkSrO/izfsjPpDN0c/eBCmMnii2fVg4H.3/y", false, new DateTime(2023, 2, 24, 15, 13, 28, 145, DateTimeKind.Local).AddTicks(4711), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("3060c0ad-cb26-45f2-bad7-09a18888885d"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$aFgQiVF4UF/1pY6q852FmOFwb0.g0K4jzBT.Jk2cvkxsCY2s6Dk7S", false, new DateTime(2023, 2, 24, 15, 13, 36, 665, DateTimeKind.Local).AddTicks(4796), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("321af58e-99bd-4c01-9afc-d74864b7e9fd"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$WmQoYVvZcSY73RaAWJqaLujW.RaxuOOBb3lvycAtGudP9UF0dqLNK", false, new DateTime(2023, 2, 24, 15, 13, 33, 257, DateTimeKind.Local).AddTicks(6087), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("32fe22c9-429c-476b-87a2-a76b52ab4a29"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$QIhvjlyfFq2oGJFj.se5hOunytEL10cAcKVCzmHdyakk6NGT.7Ig.", false, new DateTime(2023, 2, 24, 15, 13, 35, 96, DateTimeKind.Local).AddTicks(7585), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("3308ba9a-785f-410b-a086-3e603a50853a"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$FJoOh0dQs99g2Q600W.uH.MDvrJtSpjLxek0Sh6Bvd8KNWhzOETAO", false, new DateTime(2023, 2, 24, 15, 13, 28, 518, DateTimeKind.Local).AddTicks(85), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("3785ef56-0602-4d36-8962-e53644038ddb"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$8oQTlOiWAIZMYCPJo2yTDuaT9hqYHbmdffS74Wss3PHf9HCKXcmuC", false, new DateTime(2023, 2, 24, 15, 13, 29, 150, DateTimeKind.Local).AddTicks(3394), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("395aa456-610f-407c-819c-02a48537b1ef"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$4h2JRmemYVW59aafAuZh9uRyf4OK.C2E7mUVo9U6JoamKR/oxCoOe", false, new DateTime(2023, 2, 24, 15, 13, 38, 355, DateTimeKind.Local).AddTicks(2980), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("3eaba745-569b-4a30-a25c-971561cee38d"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$P4YFHl3DgZI4wPKyh7BfR.QDVR/EiyGGf/Y4F8.kxIjjzbkkOBiNC", false, new DateTime(2023, 2, 24, 15, 13, 38, 154, DateTimeKind.Local).AddTicks(9543), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("3ec16b51-9704-4451-b80a-e09f053a0741"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$0flHiKLK.6PlKpq5SX8P/utCMicUjixZHWtMZN3H9eh08Us81Bi/W", false, new DateTime(2023, 2, 24, 15, 13, 34, 332, DateTimeKind.Local).AddTicks(9306), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("50c4d679-d5cc-4a7c-9d8f-6ea758ca046f"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$8j4yvJSGE4YvD8rt1CwtO./84jv/Xg3ElsY2NOqxLVU/q5X3qFmO.", false, new DateTime(2023, 2, 24, 15, 13, 30, 845, DateTimeKind.Local).AddTicks(949), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("5289ec61-bbc3-4ebc-a9bc-9f8d15e0f8b1"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$OYXgY/JpDpiebU/RFxhhdunlgc6Ggzq4KM/KClnK2Srn9SH0YovbS", false, new DateTime(2023, 2, 24, 15, 13, 33, 169, DateTimeKind.Local).AddTicks(6077), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("53efc40c-1e99-4ad8-a7cb-eadfc14e0d90"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$6HBpGSxh9A37kAgRJFu6f.9ojnus9xo/P3BY3wt0/rZ7737VsVbuy", false, new DateTime(2023, 2, 24, 15, 13, 28, 379, DateTimeKind.Local).AddTicks(2205), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("54607227-0140-481f-bb3e-49fa982c36d9"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$NUqQbXqVpK07MMy8MtxecuJIPX/Id0hC2XVuu9nVl1aiA7GnE8Nuy", false, new DateTime(2023, 2, 24, 15, 13, 27, 921, DateTimeKind.Local).AddTicks(7506), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("55154d4b-8204-4f43-a2b6-43df3ec6ce11"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$idArOah9ymXETJMQY6RAZu8oxLHF2AxbjniIXTXhJsv5h3E0FDLC.", false, new DateTime(2023, 2, 24, 15, 13, 30, 345, DateTimeKind.Local).AddTicks(3062), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("58502c4b-fbb8-488f-8ffb-f30c704ffd7d"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$8X.oej8JcICehSjRjj9xNOgmkSKdi8E6SsxddoEhGPNelCl784tKC", false, new DateTime(2023, 2, 24, 15, 13, 28, 241, DateTimeKind.Local).AddTicks(4380), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("58cf397e-c6cb-4639-b1ea-bb3b4dd63dcc"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$eRgUUsDlIYT9XS5/SMiTOOla7ddBjD3H0MZVp7/Cw1NGUWyQwtjm2", false, new DateTime(2023, 2, 24, 15, 13, 34, 415, DateTimeKind.Local).AddTicks(3027), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("5e278c2c-2dcb-449a-ad04-46807782547a"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$eYhcuOJUetV6TPLPgr4SE.6d12JMaPHQcrllGQ1Q0YHK5oITJ.MMO", false, new DateTime(2023, 2, 24, 15, 13, 30, 443, DateTimeKind.Local).AddTicks(6202), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("5ff5285d-dae9-4042-9af4-5d59edf4c5ec"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$k6NBHO6zeinOEbpgIHjmBO6q.CQv/1kOEwbrtgS8DEbD5zm3uTS22", false, new DateTime(2023, 2, 24, 15, 13, 29, 608, DateTimeKind.Local).AddTicks(1812), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("608dd82d-a129-4413-acd3-2a083aea14a1"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$u2GngBi9i84LCvlVIveVquPVQ1pn39hUsA/VqY00KZ/AcrUQ8GWgm", false, new DateTime(2023, 2, 24, 15, 13, 35, 545, DateTimeKind.Local).AddTicks(4575), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("65bb6295-736f-4e7e-9bde-f1c0ff7d5349"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$MSAcdKiYQgCN6W1hNkeHJesOSNuRhV7O.erILnUVrPCIW6ldLB9oe", false, new DateTime(2023, 2, 24, 15, 13, 36, 211, DateTimeKind.Local).AddTicks(6637), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("6cfc4e86-c586-4377-ae57-de5a8375ef4a"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$Dl.crxaNbzM8e3DWr4PGl.JyyPf9TN5TupAcPV3q7FJ4fGKfrFzH6", false, new DateTime(2023, 2, 24, 15, 13, 33, 557, DateTimeKind.Local).AddTicks(2933), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("6d6517e2-d699-4129-9d14-ee85f2f220f4"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$HFUotd2P2AL62zC5..3oG.8XErrEIqqM9DAHdLj8pI/lHzjWGtyMK", false, new DateTime(2023, 2, 24, 15, 13, 31, 779, DateTimeKind.Local).AddTicks(6882), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("6e0580a0-f418-427e-8722-a2bbbb3ff819"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$Vx5TaYHy6EEhuRDUR4lRrel2kJl.AkK8Dpd0.G2DHff9Sql0K1HIG", false, new DateTime(2023, 2, 24, 15, 13, 29, 731, DateTimeKind.Local).AddTicks(3650), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("6e53457f-5191-4720-8c65-d95bb6a49128"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$TcxWjnRCPuBXQf/wNyzmGuO5cl0qVRrNX13PQUHmmVtz70GGYlV62", false, new DateTime(2023, 2, 24, 15, 13, 34, 506, DateTimeKind.Local).AddTicks(4677), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("6f47b522-cba9-477b-b3a9-eaa24c13f53b"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$n6.FrGZHRdC4FV2y6G3HL.47H/0FTsyRhaxSGoUj.Vbfg73kh.f4G", false, new DateTime(2023, 2, 24, 15, 13, 29, 80, DateTimeKind.Local).AddTicks(8674), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("72b4cd5c-dd2f-4133-9a27-b69d94ee9892"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$0C.jy5sbebv5AhYN/1e5m.SM17vRiaX3W/yUeBFPzoraXH4spM.Vm", false, new DateTime(2023, 2, 24, 15, 13, 35, 901, DateTimeKind.Local).AddTicks(343), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("72df9ffc-3437-4041-ae4b-6f1f77eace37"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$vzqseqfpmiI1Nd8r8ljN4eFJAjbLxfOdZoe5cwhdnnjc93yJJ6Ff6", false, new DateTime(2023, 2, 24, 15, 13, 38, 255, DateTimeKind.Local).AddTicks(8429), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("758156bb-2a85-4913-93a1-eb16399d7dc5"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$rk0E1yje4iRPUfGt89p6Auy1DVhqG.D/g0Kl0.ImX1PbEb2IRWwHu", false, new DateTime(2023, 2, 24, 15, 13, 29, 819, DateTimeKind.Local).AddTicks(3609), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("7752e1ab-8cb1-4ad9-bff2-85ed8b1e80a6"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$t8XlM3HkbqmZoTwz0yaUY.1Aox10/mCd69BVBTG1dc60oO8I2yb9i", false, new DateTime(2023, 2, 24, 15, 13, 31, 361, DateTimeKind.Local).AddTicks(2170), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("78dfe61b-e986-4644-ace6-743f45cd4aa0"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$i7I2PjgA48AYt/z86y237eEIRPIHrCU4Ok/DsZU1UUe.tVcilxSnK", false, new DateTime(2023, 2, 24, 15, 13, 27, 594, DateTimeKind.Local).AddTicks(8807), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("7d4ac7bd-5952-4b99-8d34-71d503be0d64"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$VQ2fRO6mH4CDWkxwDm0tNu/aEniIrRoovUUERRvz3sII8wlfWhiA2", false, new DateTime(2023, 2, 24, 15, 13, 28, 796, DateTimeKind.Local).AddTicks(1193), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("7d68b131-beff-4509-8a5a-f1da99b1799e"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$/uPseGx2sGr6kABTobkRMOjSGhLnoK21TG09r7SIJueFPYBgqFTj6", false, new DateTime(2023, 2, 24, 15, 13, 33, 745, DateTimeKind.Local).AddTicks(4310), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("7db6fe35-00a3-401c-96d1-af884fafc71d"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$Bdz634LW7GT5JFfo7E0cD.gDKcv/KtmT5s7y767TLyAxP1xZBynky", false, new DateTime(2023, 2, 24, 15, 13, 31, 263, DateTimeKind.Local).AddTicks(8303), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("804fd8d9-6535-4733-997c-17197b970b73"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$9KjS2mIID3nnwkJa3uvUXuNKUKh03cXkJqqWSO0fPDFAUQUk1MB26", false, new DateTime(2023, 2, 24, 15, 13, 37, 152, DateTimeKind.Local).AddTicks(7884), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("823261ad-e66d-4f63-8926-291c5459ed84"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$cRpqjWTdymFP3ncs3zaR1eVntOLnRP5sobr4yruyB1Qw0sajN2E16", false, new DateTime(2023, 2, 24, 15, 13, 36, 340, DateTimeKind.Local).AddTicks(785), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("856ea2c3-ba93-4b9b-9ea9-eb198ecca5c1"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$xaPBJPFSaX8o3YPDbclsWegvwhKWm22Ia1/M8c3HAyPPtaf8GC1Q6", false, new DateTime(2023, 2, 24, 15, 13, 32, 420, DateTimeKind.Local).AddTicks(7581), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("86251e4a-6c64-4cab-ae2e-6c114714f3cf"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$IdKntlVh.wNXJ8K1V4j6B.tndZsw9EF2.3NaG9fLzWZioeCSlK2KG", false, new DateTime(2023, 2, 24, 15, 13, 35, 391, DateTimeKind.Local).AddTicks(6257), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("8d351e77-1850-4555-bb2f-26a7010f515d"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$c215G7cNw7B3XJxgL5QFGe3ByDfbOmLTwu2N6BwpC8MstzDuZRb4y", false, new DateTime(2023, 2, 24, 15, 13, 34, 963, DateTimeKind.Local).AddTicks(6388), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("8e01c3a4-8f40-4c57-b179-e2f51f493c27"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$eBMuAiwcmhDb1bkv0vp9T.2TAQwiGbjXjYOmmUrSxfTXYj0HwL.RC", false, new DateTime(2023, 2, 24, 15, 13, 32, 642, DateTimeKind.Local).AddTicks(6708), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("8f20d302-b3ae-4b49-93f6-eae84fecceeb"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$JtLJPFuyOqKTuKDeHv68zO2ArUE4/.Q1KpvFrBD.ucjaV1lIPvC1O", false, new DateTime(2023, 2, 24, 15, 13, 30, 618, DateTimeKind.Local).AddTicks(4446), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("93b43bd5-4e6c-4f3d-b776-47a83088cfcf"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$PtoE59FCEUv9jF2DvnOHduO0Xlkeff63s5o4wZloYvHGWoDb.d7je", false, new DateTime(2023, 2, 24, 15, 13, 29, 356, DateTimeKind.Local).AddTicks(4130), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("93d24d75-0c45-44c6-a1f8-4b7f8bb45515"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$fm3lSJcO8HWU41R6CSKHEOB6FB9RPjZj5hSGtXmffsGE4/cKf8OZy", false, new DateTime(2023, 2, 24, 15, 13, 31, 991, DateTimeKind.Local).AddTicks(1758), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("9534d522-45cb-4485-aadc-d568dec879f9"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$gCXhxhLHFaNU9Q54RJx2cOg8r.1x3gDyxZVvPyDXJN/oC/WkPYoXC", false, new DateTime(2023, 2, 24, 15, 13, 33, 456, DateTimeKind.Local).AddTicks(7432), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("96da5712-5866-4ebd-b969-6e3d2d83baee"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$Q1LBhlQQMt.aOQ8YWt9quOR/JKpBUiXf1xoHTAjPZD4ODBz21VJXy", false, new DateTime(2023, 2, 24, 15, 13, 35, 248, DateTimeKind.Local).AddTicks(9461), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("9873c2a2-1195-4233-8576-7b0fe83e1e0c"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$Avx82Dhfald9VvPNkJp21.cCvwBwaxktXIXjfbm4SPvGiod0iZvd2", false, new DateTime(2023, 2, 24, 15, 13, 28, 589, DateTimeKind.Local).AddTicks(3884), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("99b75264-7f92-4755-bd22-69e52c9e7f50"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$dU7aWBONGBs0pRVQ3hgUieWGzLB5DWgjmvf8/nK1/PcJZJpG/tahK", false, new DateTime(2023, 2, 24, 15, 13, 36, 104, DateTimeKind.Local).AddTicks(4637), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("9b0f16ed-6c5b-42eb-b6f7-59d370590259"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$QSV3a0jwQCxFaTwr3YCLdugyRzCZUMMSdmaIEco58LjzNBs2jNvZ6", false, new DateTime(2023, 2, 24, 15, 13, 35, 681, DateTimeKind.Local).AddTicks(1776), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("9b2b52fd-2770-4017-8f6e-97fa320b6653"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$J.UyMR9j3qo5b8X/svu7ceXTpwEjmeoDr6YMoLp.40lBwTkenYl4K", false, new DateTime(2023, 2, 24, 15, 13, 38, 449, DateTimeKind.Local).AddTicks(4582), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("9e67e714-97e1-4d06-b7a4-223bf67995fa"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$5MauEfo1JpS5Ml4dmpPGeuapSdtd3M68yJqA.ZFiUBCFUev3CdTKW", false, new DateTime(2023, 2, 24, 15, 13, 33, 361, DateTimeKind.Local).AddTicks(5853), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("a525ef3e-b706-41b4-a8ec-2facd4a36a8f"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$y2PzPXl9PuJT/6pKsEKcQeMXm7cMjbnKDJ95qRMzyLhhJfZNnWBeG", false, new DateTime(2023, 2, 24, 15, 13, 31, 70, DateTimeKind.Local).AddTicks(6217), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("a6a79e56-ab95-429d-87a4-e444e0685c19"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$dAUI7XejN0YqwQUKv40lUOxQg1buWqJu0sBL7xGcNZ/uu0e2w44ZK", false, new DateTime(2023, 2, 24, 15, 13, 28, 658, DateTimeKind.Local).AddTicks(7503), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("a712c413-4aad-4143-a382-3d542400f533"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$lipYfNpEv1.XFpW9j9IF4uPHvrhtMiPW8oW3TtDgZkkpYDLjHxjL6", false, new DateTime(2023, 2, 24, 15, 13, 35, 999, DateTimeKind.Local).AddTicks(957), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("aa78c7bc-c42e-40c6-89cb-9305191b283b"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$Yj4IRpdu3jcEk2uMbzBNG.P8u2/E3LVWg5tlEhNaK63MayWlehZcm", false, new DateTime(2023, 2, 24, 15, 13, 36, 560, DateTimeKind.Local).AddTicks(1371), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("af9642b0-0042-4bac-9c07-5aa6079d1abb"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$mpDRDsEhuJhog4rvljwOu.5KQt.VkpOvemU5PCWz.KqQjRlLSORo2", false, new DateTime(2023, 2, 24, 15, 13, 33, 916, DateTimeKind.Local).AddTicks(9378), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("b0baf274-42e2-4509-a1e2-e54f5da15097"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$jPGw8HaIM50yKwyAmf8Fium8.BU5Mrn6yVbBaYBNSneXJuwxotvdi", false, new DateTime(2023, 2, 24, 15, 13, 30, 132, DateTimeKind.Local).AddTicks(6538), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("b0e56e12-8fd7-41c6-90aa-e9dafb893d76"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$BfbPHsSPeABeNp.oeX4uF.t5Afa3meNYLy1QCN5zpfsf/yyMrSacm", false, new DateTime(2023, 2, 24, 15, 13, 34, 609, DateTimeKind.Local).AddTicks(9484), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("b40ce9c1-8fb8-463c-846d-086d7184841e"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$A103TfN.owKU4xyaYYF7Xe.9RSVz4YqlMAd.IqqT.puINPsxdmKbC", false, new DateTime(2023, 2, 24, 15, 13, 31, 576, DateTimeKind.Local).AddTicks(2889), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("b6a67262-43c4-4a4a-9c33-38d9f3c45461"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$cjoo5eDiLc/w.IZnoNA3hO9yiSkAvHLcr1ibr0MsbgSniR63RxYge", false, new DateTime(2023, 2, 24, 15, 13, 29, 216, DateTimeKind.Local).AddTicks(1256), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("b78f228b-61a6-49bf-9e6b-754b6c588c1e"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$1Fl8hYDswFwFAoA3KQfgeOkWRekXk..pWS5Lkcz3BCvpnzBHee2SS", false, new DateTime(2023, 2, 24, 15, 13, 32, 980, DateTimeKind.Local).AddTicks(9403), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("b8e038fc-2939-4b4e-9ac9-7d89f626381a"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$ydI/GldufJVibCpP4wLT0uDUuDtS0b3xJlPpwu4crUm2Ji8jyi28G", false, new DateTime(2023, 2, 24, 15, 13, 30, 40, DateTimeKind.Local).AddTicks(2884), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("b97698af-84af-402c-ac7d-c7f9ffd4d1af"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$bMAq2w0kuqrY076CllN3s.l9yzbRZK4.lRhHivT7wGgjpeUmfuH.K", false, new DateTime(2023, 2, 24, 15, 13, 31, 160, DateTimeKind.Local).AddTicks(7026), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("be76fc0e-4a41-40ba-b790-f4586c3c82b4"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$aOnb/ui1FasBZ.Qi8NQ78eRZ5CB/O344fHHPzB6c5I7.nPpso7yYW", false, new DateTime(2023, 2, 24, 15, 13, 29, 898, DateTimeKind.Local).AddTicks(7094), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("c20f4963-6ddd-4cbb-91d7-0657c7f84052"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$7soIf9RtwLmFY6hqoNw2M.zWxHRJXqjq7E8GCeWStU8qjkmB.AOou", false, new DateTime(2023, 2, 24, 15, 13, 32, 542, DateTimeKind.Local).AddTicks(162), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("c260b105-5531-42ac-af12-dbd8b968791e"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$0LLkC2hlc4Ulz7ZgsfUPwuysaKi2jyQ/kghuM9Nvwx2groXEgw/I2", false, new DateTime(2023, 2, 24, 15, 13, 31, 651, DateTimeKind.Local).AddTicks(5363), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("c563aea4-df53-4d0e-9ac6-234d2aca1442"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$qi.f4iEntWpXQAJykBXnm.AnlKlwH0I7/HbBoCcTDLwTVBGIfKAUi", false, new DateTime(2023, 2, 24, 15, 13, 32, 206, DateTimeKind.Local).AddTicks(3540), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("c73ac387-02c4-48ed-a129-4f1790d80847"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$JpG.wPy/MRVQoEJvB6iJTezMacN3EjXJl2VxMaHi7Zam6YC.irAqS", false, new DateTime(2023, 2, 24, 15, 13, 28, 939, DateTimeKind.Local).AddTicks(2038), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("cb29504a-79c0-4ed4-863f-aea2df1a5266"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$b9KEGQuq5.TmtuktG38ZhO/KyymGWvZF/3VqTLkFItLIe1EsXoy5q", false, new DateTime(2023, 2, 24, 15, 13, 27, 776, DateTimeKind.Local).AddTicks(7080), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("cc6d2e2a-d8a0-4238-b9d5-25bbde55adc5"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$Ii3SNjpS8FS8Gs0LRPj27evFMYeuCCZkkH5kvd89rtjwbMKmO4gl.", false, new DateTime(2023, 2, 24, 15, 13, 29, 516, DateTimeKind.Local).AddTicks(6049), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("cda780ef-e3d1-44ed-b164-f5bfc83fe543"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$OyVBAHGCWpbjwn/2.1jCrOBAG7YGWLSI05sHQzI09ePCx2Nj08ZWm", false, new DateTime(2023, 2, 24, 15, 13, 27, 990, DateTimeKind.Local).AddTicks(4061), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("cdb93948-be86-44d1-8f84-7039ad1a4fd6"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$sHjoWiipqJr9k7Vg0cr6ceMfVEJlQR1tzs8HZdFXIUixlBCu/3a9O", false, new DateTime(2023, 2, 24, 15, 13, 30, 989, DateTimeKind.Local).AddTicks(473), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("d4e68381-25f4-4fe3-aca4-4ba61dd5b38c"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$uYL/Rvs6QcmYRHKiPFHs7eEXyYoWlJeLsigKlpBT9oQRS/HsRHEx.", false, new DateTime(2023, 2, 24, 15, 13, 28, 873, DateTimeKind.Local).AddTicks(8234), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("d58bc123-f067-4807-9477-2932216c5f9b"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$6DhzF8Uz2okBK5GsIBO0/uULdfO6x2ruo505mN9GHq8zjakpc0PnS", false, new DateTime(2023, 2, 24, 15, 13, 28, 55, DateTimeKind.Local).AddTicks(4202), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("d77dbf2c-72e4-48f8-be29-c244e0d32c0a"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$jUi7XtFSuutiL2xCgnvYkuGvxYV8OkdDlklukfbe6RjuKGZwlIb5y", false, new DateTime(2023, 2, 24, 15, 13, 37, 4, DateTimeKind.Local).AddTicks(8290), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("d9d180b9-8692-4cdc-86bc-87fb583cf9bb"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$ZnnesI25OFfQqYmCWdRDp.h1FXdx/5IPHlQlJgDkmjyXdMhMPFs46", false, new DateTime(2023, 2, 24, 15, 13, 32, 302, DateTimeKind.Local).AddTicks(6213), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("db7b141e-c7c2-437f-a2c6-49aa0d735de2"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$z7.oKuOmtVagjdvBWbIwieag97KYpbPfa20zyj1D94QusvvWUYgdy", false, new DateTime(2023, 2, 24, 15, 13, 37, 308, DateTimeKind.Local).AddTicks(1695), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("dbcd87c9-2184-46d0-9064-0b0bebd53c4a"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$Z2ak5VsWKPSK4qADAARetOG039y9l4vzUgWMh5BMH6n3r/R.VbKFi", false, new DateTime(2023, 2, 24, 15, 13, 36, 768, DateTimeKind.Local).AddTicks(7534), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("e2120919-b44e-4ef2-a2cf-833851488923"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$B48FMwEUAt1yxaCxqYxZGu7h3XMS9SBIaoxcqQduoaJiE97N3.Bii", false, new DateTime(2023, 2, 24, 15, 13, 37, 819, DateTimeKind.Local).AddTicks(7154), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("e28c8bba-f492-47df-aaa7-834445044bf4"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$Z94NxqucMO9jCcydPKRJr.s68HGr.HwdTndDL6fOvk.fpVkf7eLHi", false, new DateTime(2023, 2, 24, 15, 13, 28, 310, DateTimeKind.Local).AddTicks(7430), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("e5659345-e564-483f-b25f-c5eca715fe9d"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$yV/Niqxox4pzEl3v4LCQ/uZ5MlWo.3swhH.urP2W7fh6gSx683eCa", false, new DateTime(2023, 2, 24, 15, 13, 29, 282, DateTimeKind.Local).AddTicks(7777), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("e82e00a2-21ef-429b-87ba-e89e43b603f4"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$867W2u6mPE77F2huXJgpI.0uqEfCb/SC1TfjI5vAbVJewFLct43Du", false, new DateTime(2023, 2, 24, 15, 13, 31, 900, DateTimeKind.Local).AddTicks(3260), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("ea4e3a10-4fdc-4816-8c81-20d2b1f66368"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$Z5Vs3TFP2ENZjHYat4.I1eeXfeejuuXzCGyN0RDU.WkjdjnNLFC0a", false, new DateTime(2023, 2, 24, 15, 13, 37, 604, DateTimeKind.Local).AddTicks(6012), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("eb064e4e-21a0-48e5-b5e5-b0b3c168263d"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$V6.8akPr5iT6G0df5vvTteRXdCaMORRzaq7/UcL3Tlv1whmnXXy.m", false, new DateTime(2023, 2, 24, 15, 13, 28, 727, DateTimeKind.Local).AddTicks(3567), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("f1fbe8ee-d179-435e-a507-309e069d9c20"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$6Z3DJuZ37XrnYgDlAG00.OflvUO1douQowHkR/uBZ3Dxk/zmQ8P76", false, new DateTime(2023, 2, 24, 15, 13, 29, 430, DateTimeKind.Local).AddTicks(6720), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("f348671e-ea32-4d34-91cf-92281b268ac0"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$sE8GCahQI6lh/SE15pJZuOTIDMOWgypRXbLagMBpNWiOuw20U5z26", false, new DateTime(2023, 2, 24, 15, 13, 34, 251, DateTimeKind.Local).AddTicks(171), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("f3b52c02-07b9-4337-94a0-94c2ef6519d5"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$tAIkn6wDsNSGkGI1b3ld4.Wchpta8OuuMSFMJ2n7o5aCZQ0tOKFOe", false, new DateTime(2023, 2, 24, 15, 13, 38, 538, DateTimeKind.Local).AddTicks(7898), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("f3ff20fb-9337-4d4c-86d7-87f0f8a1a89e"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$pmG7d6ueBm.eUb6q/JxIFuyZJwcIlMFSV3fZq1HTfV0imoHXKZPO6", false, new DateTime(2023, 2, 24, 15, 13, 32, 98, DateTimeKind.Local).AddTicks(466), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("f40d44e7-59b1-4f6d-ad4c-b9805be3c356"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$CNq/Fp39VNzRGbY6f6ZkjeJaENm/qUfWYtecQdBFOF25m2J73lXxG", false, new DateTime(2023, 2, 24, 15, 13, 36, 882, DateTimeKind.Local).AddTicks(259), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("f772b82c-62bf-4cde-a8bd-ddaa7aec743e"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$UIGu8/BFaM0WYzQqfUwNxemE8s9IK.25u37C.8JJj29VIdCgjsrmK", false, new DateTime(2023, 2, 24, 15, 13, 34, 840, DateTimeKind.Local).AddTicks(7075), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("f97aab1b-e473-410e-9d4b-1dadca9d9888"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$PzRmGSYXMuSxuJVJLIz2x.uISiuhbSdUzZEl.sPCzBMhwLkja2R9.", false, new DateTime(2023, 2, 24, 15, 13, 33, 833, DateTimeKind.Local).AddTicks(1422), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("faec6a79-606f-42fd-883e-646fc1db4aac"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$PnbExqdWirrGCsrZsjIAEuPrMCAkib.6yK95yWnepIuSo2pgh2BuS", false, new DateTime(2023, 2, 24, 15, 13, 30, 543, DateTimeKind.Local).AddTicks(2751), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("fc97937c-45d6-4cbf-adfa-c5053760562f"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$xrjBKG8bY/LMGyCdNB3mX.cg/KoWTSsfGmR3NLpcP.rxv4c2oL962", false, new DateTime(2023, 2, 24, 15, 13, 34, 89, DateTimeKind.Local).AddTicks(8542), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("ff9e1800-0f20-4209-8fb1-a25372e7cd63"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$Jdq80XxBCV4CMdkwNIk9j.inO.1aoaqlR1qXvaf0mViRNqxSMXmeK", false, new DateTime(2023, 2, 24, 15, 13, 28, 448, DateTimeKind.Local).AddTicks(5269), "Varga", null, null, "0652741657", 1, "evargab" }
                });
        }
    }
}
