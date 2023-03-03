using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver175 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("279092a8-9411-4dfe-ad03-f75aac2fae27"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("28ae7761-dc35-44bb-a322-2df33cc0f62d"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("6091a122-b21a-40e7-b09a-a22b8c950292"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("7e35ea37-7a1b-497e-82e0-e9a4833697c1"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("a9c0e67e-0b20-43ee-a951-15bf4fefd4a6"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("d7a0fc7a-b31d-4296-b3b1-e0751a306c9d"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("29aa7d64-271b-4473-b9a8-0415af8a59a3"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("7ec471dc-a39b-4049-aacc-0d906e1ceb8d"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("986b7326-beba-474e-9715-2fbee32543da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01d8426b-575a-4cb2-913d-ba29310c6f73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0362eda6-26df-4b23-b771-e6bcb68a1fd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("04c8782a-32b9-4980-b8c6-77fa86074273"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("06e15531-d93f-4868-a56d-1c2d240a2073"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("06e6eb11-5826-419c-bcd8-1d29534c90d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("07689db2-c1b6-4919-b9ff-0bdca711db6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("080e03f4-487b-4ee5-9fb0-672641e4f69e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("083dc127-a9ed-46fc-ab90-9b88839cfe54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("085b49a6-41ee-45de-8e66-85581e6add52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0e24cb24-cb86-4857-a0bc-2d3171c86fba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("14366df3-d4b1-4c90-a4c8-d04a859dc9de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("14733ee1-0dad-4202-8b24-4208f5046428"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("165cd76a-26cb-4b4c-ae26-18c1d52df23b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17554523-245f-4cc8-85d7-06eff029bad7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b39ec15-743c-442d-9cd6-b8bd9df7a5a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b9b9820-e6b2-49b7-aa24-01955e116fb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1e3fe25f-d70b-4204-895b-5b92cd65d7a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("208713cc-9bcd-437b-ab65-ace0bd549143"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("21cad711-c81d-431c-885f-18e9b185ec1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("23f21282-e64d-4e38-a644-8bd7c704e230"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2959d2a5-c12f-4b81-abd8-5593ddf18f45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2cfd108d-fc08-409b-b503-da5b9f0ea0e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2eb2139f-8151-4534-a87b-42d6b1ebbc7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2ec11130-a249-46e9-a299-b56ecb4bbcea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2fb6d048-9264-42c2-905d-a615761a3d03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2ff57026-1ca8-40c2-a678-bfb4ced9aec6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("340956fd-6534-4c62-9041-a7f14d5ac84e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("353cdf28-8395-47d6-b800-8bd21f546998"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("360c8aa6-bfdd-4194-929d-09efee72b9b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("36fea784-518a-429c-a8ce-d96138e0e30d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("38647945-1fa6-4402-9037-5b24cdd8faa5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3bb74fec-79c1-43db-b767-0dbc740bc73e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3eb8994c-3cdf-4b4f-991e-9c938764f386"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4633b666-83a1-40dc-b918-c3658e5ab0b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("47acc4ad-9ca6-4f61-a93c-3424b3cc270d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("49474833-239b-4846-9f2b-dae17f690835"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("49d340c3-c2c8-4ff8-9b34-3337be53451a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4b288f1e-0456-4e50-b513-f59405fc0c77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4b93290d-972f-43a9-ad29-ff2c9d810577"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4dc7f26d-398f-4388-9213-c12868bc8dbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("529cfd82-a4dd-4bd3-b809-31302d54e3c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("533bc74c-3010-470a-bd99-351bff713ef8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("55fabadd-998b-44e7-ab34-3e8fdb5f0272"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5867f176-9ffe-46ef-b108-233694adf361"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("59dab54a-731e-49ad-93ee-6512283efc10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5bff324e-1bcc-4ae5-a113-30351cd8ff9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5d45d059-9269-4fb8-8c7e-55b574befa6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ed868ca-7995-419e-a20c-1cf99ef6d98b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ee39796-7a46-48c0-b86a-6bf0c1e69398"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62359336-37b1-49ef-9114-27f60dc99497"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("627ffe57-1483-4994-bb7c-c9959b5069f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("661bb57e-e4ad-4a18-ae38-a35e111fed21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("67e87870-b20b-49ab-9e1f-232961ffab82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("68777897-6e25-45af-ae4e-b32f70adf13d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6e657f65-e52e-4188-9c17-00e897fcc613"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("72bd551f-7dd6-4d60-8866-23bc2783aadd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("72df4792-4a89-4ce4-b6d1-751a30b350fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74aa6779-6780-43d0-b6a1-c3eb97ddef75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7574ff0c-b267-488c-9cd0-94ac1a23fa83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d6c6688-4a75-4206-baf8-3c104e95f98c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7e9178c4-a4b5-46da-bc03-619cb1909036"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("846ade99-ae68-43bc-9c22-8add0b1fcfcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("875dec37-8436-465b-ba41-428dc63f945e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8a4b979e-4ae8-4023-9252-4946fa34414b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("914a495e-e3ff-467d-9b9d-e26441bac5e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("93c7078b-461b-4981-aff9-b5d5ccf22c94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("94dec8cb-1a60-4e22-9679-2d4e7d05baad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("971e64d4-c167-4f1e-8cd0-302e152df766"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9c6846df-c72b-40d3-9f61-a27e3e458965"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a3d414fe-3f49-4822-b9f9-b50edc340286"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a507ca0b-69bc-4bd7-a60d-b5f7bb6a735d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a53b876d-c7c1-439d-a073-a3e28a9d7bc5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a971b3e3-eb1a-4329-bb36-398bb2f12f56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aee4bbfc-69b5-4c59-a71e-82b5198230cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("afb57879-c1c2-46cc-8ac7-4b5840950570"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b3d16f9c-a7e9-47f0-8c17-02e2c2a5f588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b3e79fe3-765f-4711-a86b-01f8629f617a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b603b3be-ab06-405a-91ab-8c271b773ce6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b8e271fa-da38-452b-b57c-a80a382b0664"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b947f1e8-d0d3-43a0-92b6-184e1ae16d81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b9712980-509a-4fbd-9ec6-58e202fa083b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba00882d-867f-484f-8c8a-3226a99fc851"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("baf98389-cf7f-4760-92d1-b349d3c65267"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bb2669e9-9f2e-40ec-92ae-bb168efee4b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bbe34f4a-8a41-4a92-8609-ce7280eada87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c0f8fd7f-8de9-40f8-aae1-72a88c23de9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c8b28b45-91ab-4830-b520-bbacaabd7c63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cc267c3f-154d-474b-a83a-36b4486fa858"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cd8ad964-25e9-44f3-bfeb-7d22a167f443"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cf235923-503c-447a-a56f-9ff8a2b68e0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cf794d06-c933-4657-8c60-3b6c37ab7b34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d4f5bc8d-5fb6-48c2-99b3-8a7fd32cc97a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d50b207d-12eb-49a9-8978-c19812a937c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d6633382-29dd-4bbc-88cc-8b1ffc9ceff3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7b8f2de-2b43-4626-ac64-904b7ecbd2ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e957cbd8-5e7c-48e2-9bbd-9d64415541a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e9936356-d6be-45e0-a381-f52e7f270342"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eb28480d-c75e-4040-b6d0-137c17f71387"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec08817d-80ba-4927-b7cb-1e7738a53c4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ece83656-cdd1-4872-80a2-8e1f1f359fd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee24dd48-5c85-4f8b-9d0e-0d11824d5158"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee966e7e-fc92-49f4-96b1-7991dc4d8ee1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f0aab958-3e90-4931-942d-3b46b556dae7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f1e4bf89-b498-4f61-8360-f1d10d5250cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f27cfd77-48b3-4b75-9c1e-f1b48e560e94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f4b244dd-2cd5-41cf-b912-866768bb3935"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f94deaec-c160-4d92-96d2-186847908e19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fbf4e941-3a24-4658-8beb-ebf45b54d1db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fd1a8354-119b-4f85-9f45-da19f67b2818"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fd3b7a73-66c0-414e-888c-7ecd1e8d5b34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fd6703e2-fd3e-40c4-a11c-ccae6c173a3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("feca751b-abbc-448a-b028-67e1097cdcff"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ParkingDate",
                table: "ParkingDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUpDate",
                table: "ParkingDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0fc8f1e8-0821-4f4b-8e42-0f5d577bad6c"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("442fc2c1-d156-4119-8be3-6e2c3b6b8356"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("5115b8fb-77f2-495b-bd33-5c65d20b06dd"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("861794e3-003f-429c-98cf-fbdff209fb0c"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("a8f65ca1-a515-4abd-9566-0febec1c7d84"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("c9369d2b-5404-4dc5-9ee7-510407ff225e"), "Xe van con", null, null, "Minivan", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("7774dbab-cc42-460e-b48c-8115768a9800"), "Short time", new DateTime(2023, 3, 3, 19, 25, 57, 25, DateTimeKind.Local).AddTicks(2709), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bdcbaf4d-6b3b-44b2-85f0-81ccdbb8488e"), "Half Year", new DateTime(2023, 3, 3, 19, 25, 57, 25, DateTimeKind.Local).AddTicks(2716), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fff2979e-d774-465c-b7ac-6ab3fd18f60a"), "1 Year", new DateTime(2023, 3, 3, 19, 25, 57, 25, DateTimeKind.Local).AddTicks(2719), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("00653215-e0e4-4639-b994-dd7ea161d1ec"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$T05RQA5stXFXa5wbwb5.Fu8GJ/NIKtWfJf/hcy7aO/XnD9otCKENG", false, new DateTime(2023, 3, 3, 19, 25, 52, 412, DateTimeKind.Local).AddTicks(3455), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("02bdb0c2-c909-4493-b5b8-ec37e9849704"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$i08IoLJsqHpkfK4glEeBUObaZ13f3PK6b6i1jw..idBP0/aSGcGJW", false, new DateTime(2023, 3, 3, 19, 25, 48, 895, DateTimeKind.Local).AddTicks(4970), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("039c2322-3687-4074-9cce-456ed70e6260"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$zq4UKgIJVraokIFTj2uiSeY2gQsRkTJtBYXgTYtN42xQpJj17UETO", false, new DateTime(2023, 3, 3, 19, 25, 45, 998, DateTimeKind.Local).AddTicks(245), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("089db72a-23e0-4158-8f33-84ed334d84e3"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$WYubOnRVEVjLPHd3Ta2inOdb2YBZ.mHWIM0IGwx39cO8i4TOy/0bW", false, new DateTime(2023, 3, 3, 19, 25, 56, 530, DateTimeKind.Local).AddTicks(625), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("0e0a4ca0-4b36-4bc7-994c-14823bcaced6"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$cD91K/KAxdZUPhnca2oH5.zk1JfTFdGuFzRyzuITcZVt7G.c8JYHm", false, new DateTime(2023, 3, 3, 19, 25, 54, 10, DateTimeKind.Local).AddTicks(2037), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("0ead7c6c-53b0-43ca-aaf1-1a6004b0f9fc"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$nt/m1oPjRmJWoxn10cnauuNVTQruOY..LKz0hcad5M0y4CvScWgnW", false, new DateTime(2023, 3, 3, 19, 25, 53, 850, DateTimeKind.Local).AddTicks(3488), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("10c1c116-dc0a-4581-ad1a-d0fac5e8d5ad"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$xeYkLlWFOpOdExl9U9DjVuCi7Zto8T3BYj4fiD2xim9XWdpWe0l4y", false, new DateTime(2023, 3, 3, 19, 25, 51, 528, DateTimeKind.Local).AddTicks(1709), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("1424c63f-edfd-40ca-9dad-a80543ec2a56"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$41jAalGBxTLzv2AzgSSojupEs4zY1spUgLru/qAIui7qvhsZ6nMQy", false, new DateTime(2023, 3, 3, 19, 25, 50, 424, DateTimeKind.Local).AddTicks(6752), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("1700571d-d839-467c-b13c-1481926ef5f7"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$ckCWNyJAtzxMOcNvNnmBxOFMe7gJbB.Y/di2v0NMZhr/pb01Qt5sS", false, new DateTime(2023, 3, 3, 19, 25, 55, 850, DateTimeKind.Local).AddTicks(2572), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("19420d75-df6e-437e-8ace-c57b4dc6f0b8"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$OmRgPOrNZ0o6knbJULe6Fex3tSNYs6hmOQkancgNdjh4XZvIgtS8.", false, new DateTime(2023, 3, 3, 19, 25, 56, 199, DateTimeKind.Local).AddTicks(9759), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("1d121134-a43f-4973-987e-7ff69732edce"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$lN4yXrgW9.j/DFs.B.Y18OL7irmBrJGee5VplcKsMMEzgPCzZcy.e", false, new DateTime(2023, 3, 3, 19, 25, 45, 681, DateTimeKind.Local).AddTicks(3070), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("202fd3e6-9346-4db8-8025-ea025e3c668f"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$EiSUznCU36i8EnJi9n8rGO1BxrC3WcVl2BDPw7DQe1je31DGCQfqW", false, new DateTime(2023, 3, 3, 19, 25, 48, 475, DateTimeKind.Local).AddTicks(4099), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("219bd8e6-3228-4e7d-a9cb-687e686be1d7"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$AoOYncd2nB8xoxgRgiQBo.G5IAniushwq9Ewfa7XrdoFlbOQwB5AG", false, new DateTime(2023, 3, 3, 19, 25, 56, 859, DateTimeKind.Local).AddTicks(2907), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("2237990d-38c2-4261-a736-32b4b49fed8f"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$lINf/SfXimKJSekXRJljqeraDhiUflWzzzsrI635rvZ/5HqFyQFu6", false, new DateTime(2023, 3, 3, 19, 25, 45, 527, DateTimeKind.Local).AddTicks(4791), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("22d0f486-f6f1-441c-84fe-009429c7d643"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$gFHOXdFbJVGIiKkLMsE38e6W4u.oSDWk8P/vB.Xlgv.AupvjXg9eW", false, new DateTime(2023, 3, 3, 19, 25, 47, 607, DateTimeKind.Local).AddTicks(1508), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("23786d7f-3c5f-4b5d-846f-09307c51bd7e"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$1mZOcZLSbF.DTfyy0C3OcuNG0ihxU72GeTK7ldhE7J1tgvIeDqBgC", false, new DateTime(2023, 3, 3, 19, 25, 50, 646, DateTimeKind.Local).AddTicks(3035), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("23be69df-240c-4f1d-9310-d242dadf68d7"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$OiST.8LA5O0EC6/m3SbyKu7xeZ.XZlKPxLWX1oI1U7hRru7sC7loq", false, new DateTime(2023, 3, 3, 19, 25, 49, 424, DateTimeKind.Local).AddTicks(5483), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("23bfaddf-be3d-4aa2-8ba0-03100380ae56"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$BSSb1Atcuxar/nFoMEOnUetDMAz3It.gvkECRHP9Z6WgTKYVOai0C", false, new DateTime(2023, 3, 3, 19, 25, 48, 58, DateTimeKind.Local).AddTicks(5302), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("29d834e5-9f31-442b-8b5f-da28949e62d7"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$6PIHQBU/qBURb0SFRoim3u1E8R3bBVhVBnWy6bVhR6uwB24n.MeS6", false, new DateTime(2023, 3, 3, 19, 25, 45, 805, DateTimeKind.Local).AddTicks(5938), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("2a20ac3b-4fbe-4f68-ac04-525310f6f47e"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$U6DXEQpR6AV1P1eAjuPvwOIXWjfHwRzuxyQzaNoSkqfHFkfqVGCX6", false, new DateTime(2023, 3, 3, 19, 25, 51, 439, DateTimeKind.Local).AddTicks(2843), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("2b652877-2340-4f27-af28-2c803d805c73"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$U9Kivs76Sn5jqN9YYl84xeP6XR.stXkKxBW8bDLZ00PrsjQ8shzV6", false, new DateTime(2023, 3, 3, 19, 25, 50, 893, DateTimeKind.Local).AddTicks(3540), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("2bd286a1-5f55-42d3-8af9-94c64a95ac88"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$E6j5Gf7KrTyKxFzjWGsV2ur..kevH69K/FHLWEr/Xs63s7Mt5fLby", false, new DateTime(2023, 3, 3, 19, 25, 50, 352, DateTimeKind.Local).AddTicks(4614), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("2c303738-9349-4b68-bc1c-31fc09b418ee"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$WT.3SuZKdFfb/Jdj7UTQVu0gFhCF//Fij6.orfGwsQsHZDz/bA5ay", false, new DateTime(2023, 3, 3, 19, 25, 50, 203, DateTimeKind.Local).AddTicks(2493), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("2da59c0d-47ad-4a65-b8ca-8e40e5cd7b00"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$Wo25uclgdpLYHEMzYke1iuorh5TkLn/UJJ3qubtFtecLmfSsBf7ba", false, new DateTime(2023, 3, 3, 19, 25, 44, 237, DateTimeKind.Local).AddTicks(2354), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("301f64b1-b205-4575-b3ae-8155c5a185ab"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$QKwUFVtuOCd7SSxC7.K08uw7whdthcj2FheciOEZKQjTR4wAWvevi", false, new DateTime(2023, 3, 3, 19, 25, 49, 208, DateTimeKind.Local).AddTicks(4932), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("37a54bc6-042f-4265-b6d3-b7cc762dcc16"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$uq83N6xJD8HcMTAINklBaevqzrV8pFdgcMywo9D4EHuRgyz.he0FC", false, new DateTime(2023, 3, 3, 19, 25, 45, 286, DateTimeKind.Local).AddTicks(366), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("38802969-babe-46b1-a1a4-bb6f35a1f0b8"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$edz4HL7e6gHw8N3g3j8Wd.e4MVvdXDUI6xxMSWdE7ocbAgDk2cXv6", false, new DateTime(2023, 3, 3, 19, 25, 51, 930, DateTimeKind.Local).AddTicks(276), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("3fe8e114-ee81-408b-ae5a-af1896ae9d9b"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$bZsFoA.IdSAw8y8KXSMynuCdmJqmG5oopaxTRmQXAvWcfbwSZTdHO", false, new DateTime(2023, 3, 3, 19, 25, 48, 973, DateTimeKind.Local).AddTicks(2274), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("41fafc85-204a-41c5-a9d6-89cf4a4d1f0a"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$xLw4c0Y2wlgMyZruZBRHAu.bUVpPfzcwhsG6MO4GuHoUznh.fPRcO", false, new DateTime(2023, 3, 3, 19, 25, 55, 169, DateTimeKind.Local).AddTicks(9363), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("463e7a26-3930-4e5f-8110-f3b6fedf3e15"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$tSucEhch4Zi0t0qJgTTTm.1.0fjNB/MfrFPcnDIcsc8VAwTjhmjMO", false, new DateTime(2023, 3, 3, 19, 25, 50, 276, DateTimeKind.Local).AddTicks(4791), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("4693f2ce-4fb2-45bd-8247-74b16980a984"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$9J9qGBtjGTmFiSaW3MvBNO7L529KKlBcuB17JNk9innkwWsDOC3j2", false, new DateTime(2023, 3, 3, 19, 25, 53, 526, DateTimeKind.Local).AddTicks(3791), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("474c0029-29b4-4ea7-be61-9434b87f22de"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$Ook/QX0pa3C708Nroxhgtu4Yu5A1C2nax4HXoP6EZ4LaxcvHhYk6q", false, new DateTime(2023, 3, 3, 19, 25, 49, 135, DateTimeKind.Local).AddTicks(3847), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("49208268-0f36-4c33-a55b-4a8eea54e2f5"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$0MWCKC6U163QM1bqfpw5pe/AHvIs1H1rTST5B75esC90rrF2chzp2", false, new DateTime(2023, 3, 3, 19, 25, 51, 351, DateTimeKind.Local).AddTicks(4760), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("49a55853-1fae-4e1f-a1f4-e3f72d231100"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$A.7SENccE971nV5cBMH1vOXgjjlUfYNNmdQ99S3yWHpX5o3MNYt4q", false, new DateTime(2023, 3, 3, 19, 25, 47, 868, DateTimeKind.Local).AddTicks(4230), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("4c195d66-dcb5-4cd6-95e2-d9c203ba248c"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$tO5zgq59i0OrUJLnc.d/2.7rQPyWRrEOk.b6WjIfq6R1Kn1zsJw7K", false, new DateTime(2023, 3, 3, 19, 25, 47, 14, DateTimeKind.Local).AddTicks(6420), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("4dd8bb4d-5435-4f95-b11f-e8d03aa8491c"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$6g6UcRYHm6Q.wL3SiuMMn.Sgqv01WUABAiNtjwEHtskhvcHJSwgH2", false, new DateTime(2023, 3, 3, 19, 25, 50, 43, DateTimeKind.Local).AddTicks(3108), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("52a2c8ec-c951-4cca-b50c-9845692fa887"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$ACJloE5gX2jucsgon.G6UOrYjAi1YWUHLCq8SmyrkWvLa86xo2Rsa", false, new DateTime(2023, 3, 3, 19, 25, 47, 687, DateTimeKind.Local).AddTicks(7644), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("535bfae7-c40e-47d8-b03f-c0e6dba56b68"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$mRgXiL/aC8vSlM8X.ZQdH.XXTRK1in/8k/5MKLhZHcOMqoKlDwp4C", false, new DateTime(2023, 3, 3, 19, 25, 43, 704, DateTimeKind.Local).AddTicks(504), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("53651c23-8b63-44ac-aa79-0d1b812ebd97"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$pIvtlPhiHhMCpIJt9wvhdOtA7TtwLBsDkwLXA7pgX63tbscHHveQe", false, new DateTime(2023, 3, 3, 19, 25, 50, 573, DateTimeKind.Local).AddTicks(3180), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("5d8d2c30-80f4-4cbd-9945-699ccb46f09f"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$lRpC4cJO653i7/JCjnOl3.FZZy3oXh5Vw5ZKIFGEgpWyRAQn1MS..", false, new DateTime(2023, 3, 3, 19, 25, 52, 571, DateTimeKind.Local).AddTicks(815), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("627a72d5-efe6-485d-b4ed-435f2dbabf1e"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$vmecUnhXE4AIuIK9.GXzVOVhj3bJzqlQmVgk3kRSq0Ea9I3uJMMpe", false, new DateTime(2023, 3, 3, 19, 25, 44, 518, DateTimeKind.Local).AddTicks(6308), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("65e9d35f-97a0-4d73-a2f0-365fbed36acb"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$LdApfWkeyMWbHFWa7Lja9uOLD/u498n2ZDd5D2RLH.rJhsFNRfw6C", false, new DateTime(2023, 3, 3, 19, 25, 48, 230, DateTimeKind.Local).AddTicks(3996), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("65f28854-2abb-4df6-b65c-536e8087061a"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$UejCs9ffGhNgS8NFjCqkHeK/P7SHb920pa4fGguyT91KCbnddqNFC", false, new DateTime(2023, 3, 3, 19, 25, 50, 126, DateTimeKind.Local).AddTicks(766), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("6af132b6-f905-4ab2-ad2c-ce8c6f818cf0"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$9pCyq7r8kPrWe07eYMKEXOW8d.RP6D5V3O2ZDqo6qYAPFKdds8gsi", false, new DateTime(2023, 3, 3, 19, 25, 54, 171, DateTimeKind.Local).AddTicks(5806), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("6b3f660a-9749-44e3-9a96-f72bad8a6a3a"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$3gPoAiWC41XYmuuFtbOoU.N7njuxr/lfdRdihS9fR5vdMPy3yg9Ey", false, new DateTime(2023, 3, 3, 19, 25, 53, 686, DateTimeKind.Local).AddTicks(4935), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("6fc25815-18db-446f-898f-6c6e234aea4d"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$XFo9oZvhbqACoWk9uJYCuetNm941teqD81vu6QqKhR2I8ERs8GBoC", false, new DateTime(2023, 3, 3, 19, 25, 51, 158, DateTimeKind.Local).AddTicks(9593), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("7513b25e-01af-435b-8b7c-a0649c86201f"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$4VH1DIDCgWn1jNSNP78bheDsybF72U2ptxyYmEJeGmilM23Hhfr.S", false, new DateTime(2023, 3, 3, 19, 25, 51, 67, DateTimeKind.Local).AddTicks(6223), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("75b463b6-d635-4d7d-9fcd-879249d98174"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$VFTC.0Ox85VUzBGcNZD9deBwfUvJmuP5LSP0UOIpsv2RVoBDfdzpW", false, new DateTime(2023, 3, 3, 19, 25, 55, 10, DateTimeKind.Local).AddTicks(7850), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("77ee1238-971a-4212-8e75-60e85481eecd"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$p4fX3EJg5eWV3MN5Ixm43.1xIKSsnAB3DdVDV4UGprAC5rIRuvHUK", false, new DateTime(2023, 3, 3, 19, 25, 54, 843, DateTimeKind.Local).AddTicks(6369), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("7aba8825-aee1-4965-81cc-1517f9b07f1c"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$TivmmbOnLSwBKnbwxG6CXeKKEg0yVb9zg75Ym.Hh725tW/NtuocZi", false, new DateTime(2023, 3, 3, 19, 25, 51, 615, DateTimeKind.Local).AddTicks(3813), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("7afe073e-e0e0-4f78-b3d5-3ed8edb1f4fa"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$P9iPZ1pUNh8jCIlR.RZVb.7w0njQV4id5rvIQQUKQ6kRT2B.v.bjC", false, new DateTime(2023, 3, 3, 19, 25, 53, 366, DateTimeKind.Local).AddTicks(3194), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("7d6f6084-d162-4a0a-b51b-243b188af5c0"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$fK/SemcNLX9BqGbi4DmDKu87JP4zLPhOYc2Y5tByX0QYS5kNCQQ5y", false, new DateTime(2023, 3, 3, 19, 25, 48, 146, DateTimeKind.Local).AddTicks(1879), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("80865287-eb10-4251-b8bf-032b26e307bb"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$1nynZSrl8HK3dkAhbKVgWe3kFwhwhD5Wz70Bxg69aziTLeGaU/Y/2", false, new DateTime(2023, 3, 3, 19, 25, 46, 212, DateTimeKind.Local).AddTicks(6808), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("819daefb-f6ab-4b1c-85cc-670112306116"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$UJooqTYGWZzKoPXlb1s4rO4eJzHbaUiyZ9uTtyE5XO6U23QaR.1ya", false, new DateTime(2023, 3, 3, 19, 25, 49, 501, DateTimeKind.Local).AddTicks(7419), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("81d51cf9-d483-499b-96a6-c4fea7d8b663"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$rROifSlgPDF0yYoSZz2UbeyBJK0EXZEVk3dxwe89cH3dClPWlqVZi", false, new DateTime(2023, 3, 3, 19, 25, 49, 875, DateTimeKind.Local).AddTicks(6494), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("81dca2fd-55be-4394-9a7a-610ad5c97856"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$E2nboaCKM56s2G/d2SS6SeRGUz56MOWhAezPu9MclnKc4xZnt7aku", false, new DateTime(2023, 3, 3, 19, 25, 48, 567, DateTimeKind.Local).AddTicks(5014), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("871e806c-ebc3-489e-9b61-4e7054b46a4f"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$KCHMYBwiz992i./RsPuI7eALKykaZoA0JbzP4.pWo1DrtNv5ymRsm", false, new DateTime(2023, 3, 3, 19, 25, 44, 658, DateTimeKind.Local).AddTicks(4189), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("87f4ee90-00c2-4f42-995e-140b00b63dcd"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$8v/04Iknzg/CEyNG489JiuVPWcUeqBjA3HIZy6wx7Nb0.9IX.mXSy", false, new DateTime(2023, 3, 3, 19, 25, 49, 802, DateTimeKind.Local).AddTicks(8626), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("8b10f891-eb1a-48ae-a1b2-e6cd59c306ea"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$dnkO55vax8XIlEjAf2rNKOnDW8Y/2UpXtMq268IwoCVQEcMhxEw2.", false, new DateTime(2023, 3, 3, 19, 25, 46, 413, DateTimeKind.Local).AddTicks(7478), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("8beae48f-6041-4aeb-b1c3-73172f4d9918"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$IraNjrLAQtcfXmDLljNjpeh3Cc3ZnFg5t7Hn2BBd1nihZvD2Ta9LK", false, new DateTime(2023, 3, 3, 19, 25, 44, 343, DateTimeKind.Local).AddTicks(7037), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("91110ddf-ddd0-4d07-b882-579bf936ca2a"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$bEls84LHaQR5ke6wsexN6OQ7sssKMt2A9cI/tTAVyhBmis5KsAG3G", false, new DateTime(2023, 3, 3, 19, 25, 49, 56, DateTimeKind.Local).AddTicks(3585), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("92bfaee8-e5cb-48ad-93bf-63753b05987b"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$mS/X.xsgWKt/eOZoKEL2GuG9L1veAIL6xDtiL1Nh/zxu92UcxQPTu", false, new DateTime(2023, 3, 3, 19, 25, 56, 692, DateTimeKind.Local).AddTicks(8979), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("98bda988-1c3d-4906-803a-b996fa86dcb4"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$KSs6zmcGe0.lJFWlt3pFVuak0MTLCwb9C4Up9mDG.i9PtL5umBYOq", false, new DateTime(2023, 3, 3, 19, 25, 44, 2, DateTimeKind.Local).AddTicks(9330), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("9afc077d-34c6-404b-bcb6-67c2151f70f9"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$zwDRGb8F82zvWe/0oyDq.uVTASxPVIlGpm0b1b2ZH5/AoL.ann89i", false, new DateTime(2023, 3, 3, 19, 25, 51, 770, DateTimeKind.Local).AddTicks(4491), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("9d0c58a2-4e9a-4345-bc66-82bd3bbed204"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$lHQKbXEN.bKW.LIDEgvulOmTOJ42CSGbHSD2w1qOECmY4fc4QzL76", false, new DateTime(2023, 3, 3, 19, 25, 51, 253, DateTimeKind.Local).AddTicks(9312), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("a2159fbb-5fdd-4cff-b807-d99a7418ae9b"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$DPaZ7MWTLx8tHuJeDuQEXOEf6rBYGc2GmQH/hStFIXKT/y.3/4r0K", false, new DateTime(2023, 3, 3, 19, 25, 49, 659, DateTimeKind.Local).AddTicks(3111), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("a6f0770e-d9a8-4ae4-95c5-82b056c699a4"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$Mj94M8zIsmfuV1Jr2jYTqewYx.XC7Hbr.MUKYz1SRi3m9sI0EgsfG", false, new DateTime(2023, 3, 3, 19, 25, 44, 78, DateTimeKind.Local).AddTicks(6884), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("aa88d41b-9f9b-44ef-9684-d20808b6fa2f"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$Hp9v2K4LQtwxwgeleKGO/.1QLyqavtkzed1HaZDg/kWGS46SuKWnm", false, new DateTime(2023, 3, 3, 19, 25, 43, 811, DateTimeKind.Local).AddTicks(7882), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("aec5d85c-3035-4c99-9e0e-6c6e6729663e"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$PZBFEc/61uP2do.VpHLaOehRzuTLsGFX.ttvEK0xZ/jsnNSm3adDC", false, new DateTime(2023, 3, 3, 19, 25, 52, 731, DateTimeKind.Local).AddTicks(861), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("af43b5cd-4163-487c-94cd-a364dc9ae264"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$pjExM8Q1APInbWw5hY9lr.VqiubOTH/5AhN0s4cDIcim7AZix5HkK", false, new DateTime(2023, 3, 3, 19, 25, 43, 915, DateTimeKind.Local).AddTicks(411), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("b11c64f6-32b5-4429-b844-8d78da841c07"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$IFhsJZ6NbsaDXk/hBRtdi.3U8FbBNfzZGjIG.eKSctXkgVlVvRngy", false, new DateTime(2023, 3, 3, 19, 25, 53, 48, DateTimeKind.Local).AddTicks(6732), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("b1502b19-d036-4367-9975-8251cc11bb35"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$Z2iZ8RgHWBBzdWg0p5fKsO4NvEE2cuuWxoItQBchNf1or7q52zYG2", false, new DateTime(2023, 3, 3, 19, 25, 48, 658, DateTimeKind.Local).AddTicks(1381), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("ba05b859-66a7-4f4b-953f-6ee062390e51"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$9akTJmku2tNPcFbPa2UU3upaCpJ1yn36YWYhtCshghn8BqZ/uNb6y", false, new DateTime(2023, 3, 3, 19, 25, 45, 182, DateTimeKind.Local).AddTicks(4101), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("ba0b5f50-0bdf-4747-8e3c-5797940a88db"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$Df.NrEOl1bDBLNOHO8Ft0uE9zvF.VvhG4t9RSvvm99HhRId5eO6gO", false, new DateTime(2023, 3, 3, 19, 25, 49, 585, DateTimeKind.Local).AddTicks(3112), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("ba13ff51-d404-4b2a-9a48-0cb1aec3fc3d"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$hfIN.QZzFTfzpzX4mNKGEul8sF3XEF1gsvc7ZeMAwl5wX/QTmSWve", false, new DateTime(2023, 3, 3, 19, 25, 49, 959, DateTimeKind.Local).AddTicks(825), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("ba5b5409-9b92-4a91-8873-593ea48cd478"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$mVksIoU9wELEQAQBM/mcqunXaUdrzacTmgRWj36hQ6HRrQDXyX9PS", false, new DateTime(2023, 3, 3, 19, 25, 55, 685, DateTimeKind.Local).AddTicks(4643), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("be16a535-e392-4abd-bb40-028cedac394d"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$kMJMLaOIejlQcOcrSsCJguqck0khOXoFDMBF9DdJs3n6SZ9HCAdke", false, new DateTime(2023, 3, 3, 19, 25, 54, 501, DateTimeKind.Local).AddTicks(121), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("befc6ef8-b4ef-4366-89bd-1d7e5d165a17"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$tgTGt6bwb.E5YkXSD2KZYuQYCvv.1D00It8S7l8FW3Ao1xghwvjbm", false, new DateTime(2023, 3, 3, 19, 25, 48, 791, DateTimeKind.Local).AddTicks(6236), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("c0d3dfe2-0a32-4025-8b16-ea219a6bc1c3"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$cdbsdTnWY21tXpRS01JliO06OVS2LQY/epeJ3W6/BEwizNCB3ZObu", false, new DateTime(2023, 3, 3, 19, 25, 54, 669, DateTimeKind.Local).AddTicks(8724), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("c122cdf4-c58d-46dd-8635-1355fa1de21b"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$16BjaOEftlZj0oqDYEx/dONGCRrYYBxtydGvddP9OLUaTT9QMFM82", false, new DateTime(2023, 3, 3, 19, 25, 49, 730, DateTimeKind.Local).AddTicks(1003), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("c77f06a9-47d3-412c-bfc0-250e94634d94"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$pMdI3vOfTT28/DgNE3Rmn.unJUzuAQS5NLoovfL4Xbu4wxFOIlCVm", false, new DateTime(2023, 3, 3, 19, 25, 43, 503, DateTimeKind.Local).AddTicks(1984), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("ca292688-d831-4c58-9d70-2cc804c94b0a"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$X8pRcHa3MAgA.Ydx4I9PYeiOLLKNJ8V2/K.ZXpEaq1mmzSvUt3Gba", false, new DateTime(2023, 3, 3, 19, 25, 50, 720, DateTimeKind.Local).AddTicks(97), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("cd82e97e-2b0e-49b9-97c1-9120e0f1da04"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$EOfkNiu3kraRnHAPLQ7pi.Gk7DLd5hX6fACKIxsfRlR6uMXJx1fCW", false, new DateTime(2023, 3, 3, 19, 25, 50, 499, DateTimeKind.Local).AddTicks(2560), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("cd9db17c-f129-45b9-88b1-a590d44efbf7"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$CtocgNzh9Ia6lVIZCBQe3uH1UKvEgCm74t98erq8Dsir35W/Coz7m", false, new DateTime(2023, 3, 3, 19, 25, 47, 777, DateTimeKind.Local).AddTicks(694), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("cdd32e1c-9c38-4503-8f4a-1935c8e8afd2"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$.hHEmyyXlsR3T8cYCF7hD.PJdMXLUyADnt/cjkDXh85DV3xxcs7Zy", false, new DateTime(2023, 3, 3, 19, 25, 46, 867, DateTimeKind.Local).AddTicks(4175), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("ce7a37d2-f960-4748-81b6-117186ae092b"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$98lCK86PeVYJJpqkLV40PeUv3qwihBlJrKgENfRi.WqUZsTN2Oa.q", false, new DateTime(2023, 3, 3, 19, 25, 46, 580, DateTimeKind.Local).AddTicks(2961), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("ceca8209-0f1b-427b-b480-c4c3cbc64acb"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$1j80QoLebCcW.3VjndPIfObS9Cb0JvLVFWTNq71AMFnrPcbuqmw2y", false, new DateTime(2023, 3, 3, 19, 25, 47, 448, DateTimeKind.Local).AddTicks(4825), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("cef56cb9-2d19-4ac5-8086-9275f4443513"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$6BA17HwAceIXxuQ/TiF7zOoz58YIqhv0O/G4HK15Pin9FtFusdjVK", false, new DateTime(2023, 3, 3, 19, 25, 50, 980, DateTimeKind.Local).AddTicks(3360), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("d2d94a69-76d4-46f6-b1bd-e436a379c383"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$mVgoez43uP/bBoQZBbehrOIVTp/d2tNoYKrVqlP1qgl3et59KHfk2", false, new DateTime(2023, 3, 3, 19, 25, 52, 890, DateTimeKind.Local).AddTicks(1550), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("d3d6801f-b1c2-4cc9-a690-e799bd3160e4"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$G3iVQQGaogjjQxtHIhRzPOeFz4p93Nayr.ELW9Kzm8PxeM5s.p2jG", false, new DateTime(2023, 3, 3, 19, 25, 50, 804, DateTimeKind.Local).AddTicks(4057), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("d54e0235-a065-4813-9da6-511b1f2acbb9"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$uDS3f8KspFylHXMkovBa6uq87BelIPZDm9flCiLL.OulUAqe5qLM6", false, new DateTime(2023, 3, 3, 19, 25, 49, 281, DateTimeKind.Local).AddTicks(5791), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("d56e0ccb-cbaf-4907-935f-d0727002567f"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$ZkKPFZiVAFkOQWO6y3EI0.DOLCq4vOTO4srhyHHFTzoQXO5O5egKO", false, new DateTime(2023, 3, 3, 19, 25, 55, 327, DateTimeKind.Local).AddTicks(9647), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("dbd05f1d-6944-49ea-8524-479e221ee734"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$x42ebtkldkgfPA.uoSdCOehSG.h2udiqpCbFpFhWjkttKmQUwD7D2", false, new DateTime(2023, 3, 3, 19, 25, 45, 397, DateTimeKind.Local).AddTicks(6881), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("dc320dce-8d79-4f6f-862c-2c08057fcce8"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$mWlOILKfdJf47mkQezWzkOT3hb2PRYaNnWK9sh1U7eIr.aUUmrJoW", false, new DateTime(2023, 3, 3, 19, 25, 47, 531, DateTimeKind.Local).AddTicks(3934), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("dc340e90-d45a-4fe5-8b79-546d54981bf9"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$1zZ9aGrTJZYYBEpGgf4IvejDs4mvDhgB96NKRaQkHx12XL9NMI5Iq", false, new DateTime(2023, 3, 3, 19, 25, 45, 26, DateTimeKind.Local).AddTicks(724), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("df9fe1d4-f18a-4cfa-94bb-7065cdb64816"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$ucFBdnIY0rnMsK8s6Antbu76bPMKEgBnwqzG0NCKO4LHpAfJk/1I2", false, new DateTime(2023, 3, 3, 19, 25, 49, 354, DateTimeKind.Local).AddTicks(1761), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("e00e4da7-564e-463d-9d07-9a422b68e699"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$KRoPl1Y.SZAIIfwEJiSAVOxlkoTdy73kDC0fnt/Kxx6bQl3OzJcce", false, new DateTime(2023, 3, 3, 19, 25, 48, 393, DateTimeKind.Local).AddTicks(5709), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("e21d78f8-a0a5-4a2e-9f1b-e22a1134997d"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$NOBzs/1rggK6PWGWyFA6TOy9XtGjYh3cdN9STewJiCHvHNfb0zV7q", false, new DateTime(2023, 3, 3, 19, 25, 48, 309, DateTimeKind.Local).AddTicks(6065), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("e4349328-8d4c-4e9a-8a59-aa23896838fd"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$14itwQL.Med7RoUZ5j0e5.ANXGm5vH8cO6V9kho.3gO0x7PasChmW", false, new DateTime(2023, 3, 3, 19, 25, 52, 89, DateTimeKind.Local).AddTicks(2910), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("e446294f-4613-4e7f-b225-058857d5139c"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$zkVL0IuDVKrN5W8WKhsbw.989QUu1g0tI1tcBJT0ckiFJWDiriHSG", false, new DateTime(2023, 3, 3, 19, 25, 47, 963, DateTimeKind.Local).AddTicks(4273), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("e4bae403-8587-41fd-baab-42e13cb18478"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$IbZp2Y5aH73/GyFN.7FH9e0PISxUpv8TidxMeXllOHOcK94.m357m", false, new DateTime(2023, 3, 3, 19, 25, 53, 207, DateTimeKind.Local).AddTicks(4390), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("e84b6541-f9f1-42c1-9efd-8651ebb76a9f"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$ePRcZlgx.JXGvqCehIxPf.82jGK6q23LUUDRYXMvo441lGvWI7u52", false, new DateTime(2023, 3, 3, 19, 25, 54, 333, DateTimeKind.Local).AddTicks(6727), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("ee280efd-7091-4f98-8d61-639e609e30ce"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$X.69ipjqM7XNI7xQBgJZ9.xr6pu8KS5PCaOnr.ANxfktB/nJo.9Gm", false, new DateTime(2023, 3, 3, 19, 25, 55, 509, DateTimeKind.Local).AddTicks(3190), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("f202c469-f1a4-4bb3-a3ed-a4cd8c2436d2"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$0FYvoAEIxc/UoTSvgjWuO.GEBpDXXApA57R8ULxJC8r66gr/EuAwO", false, new DateTime(2023, 3, 3, 19, 25, 47, 270, DateTimeKind.Local).AddTicks(6630), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("f3d7bf7a-4b80-4edb-9a49-90494bb3e7d3"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$XNhgW7wyIK6p7HhrEM3FcePbAWPqjmnX21NPDYZyVbXmxo8Jd6DNm", false, new DateTime(2023, 3, 3, 19, 25, 43, 601, DateTimeKind.Local).AddTicks(1279), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("f3fa2fcd-da7b-4892-bd7c-bdadae620dd7"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$aTlBimmuRSBy8LfExhGcI.rnjGbXCcHk0T2bQn4ERaCNp4JPup6Za", false, new DateTime(2023, 3, 3, 19, 25, 57, 25, DateTimeKind.Local).AddTicks(1883), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("f6af4899-01da-438e-9bc9-2b9ff057d9cb"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$Q3YlWbCVD85Uq9zyLdhleOHa9x0/WH.G9dw6H1OJkgAzje2WwgJIC", false, new DateTime(2023, 3, 3, 19, 25, 44, 158, DateTimeKind.Local).AddTicks(7456), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("f81e8075-3e88-4e07-8d79-d7e6cf2bdfbb"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$TxS181dP/WeX9pG6x7KPuuKXYBIiSRcaM0kK/rCC3VB0O2vJajM8G", false, new DateTime(2023, 3, 3, 19, 25, 56, 23, DateTimeKind.Local).AddTicks(3209), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("fa2b681c-8e9d-4fc4-853b-8feb9bd7fe3a"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$T5Q3QX28FqcIk.fbE7MXcOw8Z/Ld7XHYKUyb5Ub4mZRdJHuvRkUTa", false, new DateTime(2023, 3, 3, 19, 25, 52, 251, DateTimeKind.Local).AddTicks(8711), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("fba9514f-cb55-452c-82da-f7e51b8515e4"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$mPzR5UufVGjO.SH6o2U8zOMo2gXsJF9zgJBK83e2eA/CfTwn2hjUC", false, new DateTime(2023, 3, 3, 19, 25, 56, 370, DateTimeKind.Local).AddTicks(4088), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("fc6151d7-96e3-4bfb-90c4-be094fcf1e3d"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$b9CwRtG9Bs4olLz9Pn.7feMoR4bpxiJVyTUkKyHei6Pe05u5TPj3S", false, new DateTime(2023, 3, 3, 19, 25, 46, 721, DateTimeKind.Local).AddTicks(4866), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("fd3d5762-ac88-4379-b20b-5318a6eee88f"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$ZOiTn.KSR0UPcLEumue0I.NFpi9JvYfbHXGn7qsi/057l0iThc8/e", false, new DateTime(2023, 3, 3, 19, 25, 44, 798, DateTimeKind.Local).AddTicks(5136), "Varga", null, null, "0652741657", 1, "evargab" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("0fc8f1e8-0821-4f4b-8e42-0f5d577bad6c"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("442fc2c1-d156-4119-8be3-6e2c3b6b8356"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("5115b8fb-77f2-495b-bd33-5c65d20b06dd"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("861794e3-003f-429c-98cf-fbdff209fb0c"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("a8f65ca1-a515-4abd-9566-0febec1c7d84"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("c9369d2b-5404-4dc5-9ee7-510407ff225e"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("7774dbab-cc42-460e-b48c-8115768a9800"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("bdcbaf4d-6b3b-44b2-85f0-81ccdbb8488e"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("fff2979e-d774-465c-b7ac-6ab3fd18f60a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("00653215-e0e4-4639-b994-dd7ea161d1ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("02bdb0c2-c909-4493-b5b8-ec37e9849704"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("039c2322-3687-4074-9cce-456ed70e6260"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("089db72a-23e0-4158-8f33-84ed334d84e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0e0a4ca0-4b36-4bc7-994c-14823bcaced6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0ead7c6c-53b0-43ca-aaf1-1a6004b0f9fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("10c1c116-dc0a-4581-ad1a-d0fac5e8d5ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1424c63f-edfd-40ca-9dad-a80543ec2a56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1700571d-d839-467c-b13c-1481926ef5f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("19420d75-df6e-437e-8ace-c57b4dc6f0b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1d121134-a43f-4973-987e-7ff69732edce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("202fd3e6-9346-4db8-8025-ea025e3c668f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("219bd8e6-3228-4e7d-a9cb-687e686be1d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2237990d-38c2-4261-a736-32b4b49fed8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("22d0f486-f6f1-441c-84fe-009429c7d643"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("23786d7f-3c5f-4b5d-846f-09307c51bd7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("23be69df-240c-4f1d-9310-d242dadf68d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("23bfaddf-be3d-4aa2-8ba0-03100380ae56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("29d834e5-9f31-442b-8b5f-da28949e62d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2a20ac3b-4fbe-4f68-ac04-525310f6f47e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2b652877-2340-4f27-af28-2c803d805c73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2bd286a1-5f55-42d3-8af9-94c64a95ac88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2c303738-9349-4b68-bc1c-31fc09b418ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2da59c0d-47ad-4a65-b8ca-8e40e5cd7b00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("301f64b1-b205-4575-b3ae-8155c5a185ab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("37a54bc6-042f-4265-b6d3-b7cc762dcc16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("38802969-babe-46b1-a1a4-bb6f35a1f0b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3fe8e114-ee81-408b-ae5a-af1896ae9d9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("41fafc85-204a-41c5-a9d6-89cf4a4d1f0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("463e7a26-3930-4e5f-8110-f3b6fedf3e15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4693f2ce-4fb2-45bd-8247-74b16980a984"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("474c0029-29b4-4ea7-be61-9434b87f22de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("49208268-0f36-4c33-a55b-4a8eea54e2f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("49a55853-1fae-4e1f-a1f4-e3f72d231100"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4c195d66-dcb5-4cd6-95e2-d9c203ba248c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4dd8bb4d-5435-4f95-b11f-e8d03aa8491c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("52a2c8ec-c951-4cca-b50c-9845692fa887"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("535bfae7-c40e-47d8-b03f-c0e6dba56b68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("53651c23-8b63-44ac-aa79-0d1b812ebd97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5d8d2c30-80f4-4cbd-9945-699ccb46f09f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("627a72d5-efe6-485d-b4ed-435f2dbabf1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("65e9d35f-97a0-4d73-a2f0-365fbed36acb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("65f28854-2abb-4df6-b65c-536e8087061a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6af132b6-f905-4ab2-ad2c-ce8c6f818cf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6b3f660a-9749-44e3-9a96-f72bad8a6a3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6fc25815-18db-446f-898f-6c6e234aea4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7513b25e-01af-435b-8b7c-a0649c86201f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("75b463b6-d635-4d7d-9fcd-879249d98174"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("77ee1238-971a-4212-8e75-60e85481eecd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7aba8825-aee1-4965-81cc-1517f9b07f1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7afe073e-e0e0-4f78-b3d5-3ed8edb1f4fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d6f6084-d162-4a0a-b51b-243b188af5c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("80865287-eb10-4251-b8bf-032b26e307bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("819daefb-f6ab-4b1c-85cc-670112306116"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("81d51cf9-d483-499b-96a6-c4fea7d8b663"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("81dca2fd-55be-4394-9a7a-610ad5c97856"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("871e806c-ebc3-489e-9b61-4e7054b46a4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("87f4ee90-00c2-4f42-995e-140b00b63dcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8b10f891-eb1a-48ae-a1b2-e6cd59c306ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8beae48f-6041-4aeb-b1c3-73172f4d9918"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("91110ddf-ddd0-4d07-b882-579bf936ca2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("92bfaee8-e5cb-48ad-93bf-63753b05987b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("98bda988-1c3d-4906-803a-b996fa86dcb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9afc077d-34c6-404b-bcb6-67c2151f70f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9d0c58a2-4e9a-4345-bc66-82bd3bbed204"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a2159fbb-5fdd-4cff-b807-d99a7418ae9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a6f0770e-d9a8-4ae4-95c5-82b056c699a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aa88d41b-9f9b-44ef-9684-d20808b6fa2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aec5d85c-3035-4c99-9e0e-6c6e6729663e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("af43b5cd-4163-487c-94cd-a364dc9ae264"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b11c64f6-32b5-4429-b844-8d78da841c07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1502b19-d036-4367-9975-8251cc11bb35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba05b859-66a7-4f4b-953f-6ee062390e51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba0b5f50-0bdf-4747-8e3c-5797940a88db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba13ff51-d404-4b2a-9a48-0cb1aec3fc3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba5b5409-9b92-4a91-8873-593ea48cd478"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("be16a535-e392-4abd-bb40-028cedac394d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("befc6ef8-b4ef-4366-89bd-1d7e5d165a17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c0d3dfe2-0a32-4025-8b16-ea219a6bc1c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c122cdf4-c58d-46dd-8635-1355fa1de21b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c77f06a9-47d3-412c-bfc0-250e94634d94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ca292688-d831-4c58-9d70-2cc804c94b0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cd82e97e-2b0e-49b9-97c1-9120e0f1da04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cd9db17c-f129-45b9-88b1-a590d44efbf7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cdd32e1c-9c38-4503-8f4a-1935c8e8afd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ce7a37d2-f960-4748-81b6-117186ae092b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ceca8209-0f1b-427b-b480-c4c3cbc64acb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cef56cb9-2d19-4ac5-8086-9275f4443513"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d2d94a69-76d4-46f6-b1bd-e436a379c383"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d3d6801f-b1c2-4cc9-a690-e799bd3160e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d54e0235-a065-4813-9da6-511b1f2acbb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d56e0ccb-cbaf-4907-935f-d0727002567f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dbd05f1d-6944-49ea-8524-479e221ee734"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dc320dce-8d79-4f6f-862c-2c08057fcce8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dc340e90-d45a-4fe5-8b79-546d54981bf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("df9fe1d4-f18a-4cfa-94bb-7065cdb64816"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e00e4da7-564e-463d-9d07-9a422b68e699"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e21d78f8-a0a5-4a2e-9f1b-e22a1134997d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4349328-8d4c-4e9a-8a59-aa23896838fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e446294f-4613-4e7f-b225-058857d5139c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4bae403-8587-41fd-baab-42e13cb18478"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e84b6541-f9f1-42c1-9efd-8651ebb76a9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee280efd-7091-4f98-8d61-639e609e30ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f202c469-f1a4-4bb3-a3ed-a4cd8c2436d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3d7bf7a-4b80-4edb-9a49-90494bb3e7d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3fa2fcd-da7b-4892-bd7c-bdadae620dd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f6af4899-01da-438e-9bc9-2b9ff057d9cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f81e8075-3e88-4e07-8d79-d7e6cf2bdfbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa2b681c-8e9d-4fc4-853b-8feb9bd7fe3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fba9514f-cb55-452c-82da-f7e51b8515e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fc6151d7-96e3-4bfb-90c4-be094fcf1e3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fd3d5762-ac88-4379-b20b-5318a6eee88f"));

            migrationBuilder.DropColumn(
                name: "ParkingDate",
                table: "ParkingDetail");

            migrationBuilder.DropColumn(
                name: "PickUpDate",
                table: "ParkingDetail");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("279092a8-9411-4dfe-ad03-f75aac2fae27"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("28ae7761-dc35-44bb-a322-2df33cc0f62d"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("6091a122-b21a-40e7-b09a-a22b8c950292"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("7e35ea37-7a1b-497e-82e0-e9a4833697c1"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("a9c0e67e-0b20-43ee-a951-15bf4fefd4a6"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("d7a0fc7a-b31d-4296-b3b1-e0751a306c9d"), "xe 5 chỗ", null, null, "SUV5", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("29aa7d64-271b-4473-b9a8-0415af8a59a3"), "1 Year", new DateTime(2023, 3, 2, 0, 16, 23, 437, DateTimeKind.Local).AddTicks(3099), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ec471dc-a39b-4049-aacc-0d906e1ceb8d"), "Short time", new DateTime(2023, 3, 2, 0, 16, 23, 437, DateTimeKind.Local).AddTicks(3091), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("986b7326-beba-474e-9715-2fbee32543da"), "Half Year", new DateTime(2023, 3, 2, 0, 16, 23, 437, DateTimeKind.Local).AddTicks(3097), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01d8426b-575a-4cb2-913d-ba29310c6f73"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$c0X9zSBjJ7YSfnVwRQukQ.J8wnABu/iCHr/Pj9ZH875OR6ScGmMf6", false, new DateTime(2023, 3, 2, 0, 16, 14, 671, DateTimeKind.Local).AddTicks(3198), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("0362eda6-26df-4b23-b771-e6bcb68a1fd7"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$fJ0DjN6UrGHCzmlZo4sm9eyCZSdu9tnGMUNlaN1LmMH6y1i/Zlwhq", false, new DateTime(2023, 3, 2, 0, 16, 19, 687, DateTimeKind.Local).AddTicks(9838), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("04c8782a-32b9-4980-b8c6-77fa86074273"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$/AordvBKdLOf7/uqiPbF/OXDkwMAoKqYLwIGwI1JkXjqhU9y3V5zG", false, new DateTime(2023, 3, 2, 0, 16, 13, 311, DateTimeKind.Local).AddTicks(5344), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("06e15531-d93f-4868-a56d-1c2d240a2073"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$v6S7AwZSC7gyqI5xU1hd8uGr3W3qjfyBmD9WElW8ama.oh50omUIS", false, new DateTime(2023, 3, 2, 0, 16, 14, 321, DateTimeKind.Local).AddTicks(351), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("06e6eb11-5826-419c-bcd8-1d29534c90d7"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$IQJP/G10zHKBS.mqOBLHCemBaj8QRV.jaVNxoP2sIMoPTg1KtZ4eS", false, new DateTime(2023, 3, 2, 0, 16, 16, 491, DateTimeKind.Local).AddTicks(8197), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("07689db2-c1b6-4919-b9ff-0bdca711db6e"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$33/WNGpDo8yRaw0DgAq4ful4GOlulR10RZ3Z.gMmDHR3Uq.Tm8nm6", false, new DateTime(2023, 3, 2, 0, 16, 15, 620, DateTimeKind.Local).AddTicks(534), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("080e03f4-487b-4ee5-9fb0-672641e4f69e"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$.3yah/wgA/aD.V2ftjLYg.1JLEuWeoPYr7wbhCOAQ3CwaSYdqz2ty", false, new DateTime(2023, 3, 2, 0, 16, 22, 755, DateTimeKind.Local).AddTicks(883), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("083dc127-a9ed-46fc-ab90-9b88839cfe54"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$Me3K.w3urTDP4eqVNiqKL.Q5HrwiURSoRXGNTWOenJ18.wFKlyQdu", false, new DateTime(2023, 3, 2, 0, 16, 16, 99, DateTimeKind.Local).AddTicks(1258), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("085b49a6-41ee-45de-8e66-85581e6add52"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$aKaYb1wpncjBg2uPb.aFf.R4f8cYuqctaZmKRsUH7RcpDvfssazHu", false, new DateTime(2023, 3, 2, 0, 16, 19, 613, DateTimeKind.Local).AddTicks(2235), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("0e24cb24-cb86-4857-a0bc-2d3171c86fba"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$5iwqoT0cY9o/NFRF2RWlzOWjyIXhCGy0eG7tzC74Wsf.3XROsBHF2", false, new DateTime(2023, 3, 2, 0, 16, 20, 206, DateTimeKind.Local).AddTicks(1792), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("14366df3-d4b1-4c90-a4c8-d04a859dc9de"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$2iWMif3dKIKdEiiIwXBhVem2f9CQnJkZbOg7vaMMrK.28LXjf1qAO", false, new DateTime(2023, 3, 2, 0, 16, 15, 772, DateTimeKind.Local).AddTicks(1487), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("14733ee1-0dad-4202-8b24-4208f5046428"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$oQf3jIUdNkVo7eTyQq7LieyqNh2lH6.Wj8DBUXAuDhxS8TRxVD0Gy", false, new DateTime(2023, 3, 2, 0, 16, 18, 346, DateTimeKind.Local).AddTicks(6574), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("165cd76a-26cb-4b4c-ae26-18c1d52df23b"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$URutIOh2QhLhnynQsX4Squ1E7ZjQHlOYn/Z0poFGzxKSn8rYIZhx2", false, new DateTime(2023, 3, 2, 0, 16, 13, 789, DateTimeKind.Local).AddTicks(3642), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("17554523-245f-4cc8-85d7-06eff029bad7"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$zp2tQNnxw9Q9iGahkb/HT.uRDDM4eJyXwVdcdXylyJJx4rNtunsni", false, new DateTime(2023, 3, 2, 0, 16, 21, 597, DateTimeKind.Local).AddTicks(1033), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("1b39ec15-743c-442d-9cd6-b8bd9df7a5a5"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$Z9CLz7DHBJTcLgqx6REo7uQJ4xAiLI1JTGeYvGU9R3RWVpUKArf06", false, new DateTime(2023, 3, 2, 0, 16, 22, 233, DateTimeKind.Local).AddTicks(8197), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("1b9b9820-e6b2-49b7-aa24-01955e116fb1"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$V4UM5R2uZ.NrEC6b47e4Yu6uOFjip1BFUm.LSQ16/wmY7kxfhuxz6", false, new DateTime(2023, 3, 2, 0, 16, 14, 522, DateTimeKind.Local).AddTicks(7216), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("1e3fe25f-d70b-4204-895b-5b92cd65d7a1"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$k12wFjm6MSTwRItR5S1x3OAnVfA6M6bwQb0QFTSO9b1mq53UFOnxi", false, new DateTime(2023, 3, 2, 0, 16, 18, 568, DateTimeKind.Local).AddTicks(8726), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("208713cc-9bcd-437b-ab65-ace0bd549143"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$QRgzEUTF69IjeuSygW5kAuGIu7IpSd/OM4GSTGPl.U2xKiHr.z3Ky", false, new DateTime(2023, 3, 2, 0, 16, 13, 529, DateTimeKind.Local).AddTicks(5730), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("21cad711-c81d-431c-885f-18e9b185ec1d"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$m4wjQGdpeTXYUQuv2kQIWu2a8TEeWTP0JyB06HjW4SBVGlcmbPc8u", false, new DateTime(2023, 3, 2, 0, 16, 17, 718, DateTimeKind.Local).AddTicks(1904), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("23f21282-e64d-4e38-a644-8bd7c704e230"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$m0HUO2HR7AfD6UWagIEbke4A/eRz88ne4w/8uHBjM3Zaa.7Cyzom2", false, new DateTime(2023, 3, 2, 0, 16, 20, 674, DateTimeKind.Local).AddTicks(9657), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("2959d2a5-c12f-4b81-abd8-5593ddf18f45"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$PAWbVrX51XLFgVTzo9WMeuRy3fx8qFSVhP32QZHoWDnqaa7pS9FgG", false, new DateTime(2023, 3, 2, 0, 16, 17, 851, DateTimeKind.Local).AddTicks(437), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("2cfd108d-fc08-409b-b503-da5b9f0ea0e0"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$pY4og1bMe.kxd9Dai3j7KeYj6rBDI71pRR229YQjfWaDswkL2t852", false, new DateTime(2023, 3, 2, 0, 16, 23, 91, DateTimeKind.Local).AddTicks(2820), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("2eb2139f-8151-4534-a87b-42d6b1ebbc7b"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$.lpc.t8svIXc5wJjFhnTF.ekZdhPWCq2KkVjRk3r3Mr/pT4MbIIca", false, new DateTime(2023, 3, 2, 0, 16, 21, 368, DateTimeKind.Local).AddTicks(9236), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("2ec11130-a249-46e9-a299-b56ecb4bbcea"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$QbJXNVl/bvZG.qQDyVG1X.ifFKe9xLYO8CudW3zeKO8fdi8g3z/36", false, new DateTime(2023, 3, 2, 0, 16, 19, 289, DateTimeKind.Local).AddTicks(535), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("2fb6d048-9264-42c2-905d-a615761a3d03"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$7LYLpPYot/1.polDLk/04OyRR9WLrfR7myNovZlzPFhNv8hz8vqM.", false, new DateTime(2023, 3, 2, 0, 16, 19, 534, DateTimeKind.Local).AddTicks(5686), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("2ff57026-1ca8-40c2-a678-bfb4ced9aec6"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$QhAkjgzatk17QZrjiT490.zkK2h0p/1yuBRQ9gR8jdW5EsOZsRi9O", false, new DateTime(2023, 3, 2, 0, 16, 18, 5, DateTimeKind.Local).AddTicks(7152), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("340956fd-6534-4c62-9041-a7f14d5ac84e"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$TSJEjgS.ibMaK0rSvC1.JufcES5NFKsfyu9s4IslfHGqiVgNXLolK", false, new DateTime(2023, 3, 2, 0, 16, 17, 918, DateTimeKind.Local).AddTicks(5317), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("353cdf28-8395-47d6-b800-8bd21f546998"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$0rlfIjg1Ya3byGPbd8YSY.JfsqvO41HRlACwQZjRT8qrv7nCJaS/i", false, new DateTime(2023, 3, 2, 0, 16, 22, 95, DateTimeKind.Local).AddTicks(7855), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("360c8aa6-bfdd-4194-929d-09efee72b9b8"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$y/xKDJLZTOQ/4e.5DE8z9ul5NKwe/LHKsNqm9gpGSLFUrz.HdVafe", false, new DateTime(2023, 3, 2, 0, 16, 19, 373, DateTimeKind.Local).AddTicks(8530), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("36fea784-518a-429c-a8ce-d96138e0e30d"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$Vffn9nnuOjYWq9S2V/kcm.8DZB1J2EOQ8q/F5qwoxTNzLmk7FlXaq", false, new DateTime(2023, 3, 2, 0, 16, 20, 999, DateTimeKind.Local).AddTicks(5407), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("38647945-1fa6-4402-9037-5b24cdd8faa5"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$nXQkf/Z.bLkYdWGcbc6hl.TrD2TgbaljS1xyXHFaFUtlC8wTJbmKG", false, new DateTime(2023, 3, 2, 0, 16, 18, 484, DateTimeKind.Local).AddTicks(3646), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("3bb74fec-79c1-43db-b767-0dbc740bc73e"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$VS5PbHRZNiOxdGLVlTaGo.ChCHFksncFWt4kr.BpCT6K6rVOWqe4W", false, new DateTime(2023, 3, 2, 0, 16, 13, 432, DateTimeKind.Local).AddTicks(9585), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("3eb8994c-3cdf-4b4f-991e-9c938764f386"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$NeFayTSJc8leyo/ag9VHqu.2i5/VmU.RMp.Nlw52nzvG4TePmBviS", false, new DateTime(2023, 3, 2, 0, 16, 20, 367, DateTimeKind.Local).AddTicks(8664), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("4633b666-83a1-40dc-b918-c3658e5ab0b0"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$pPQMl80AKQMZ7Rsfh1s90.FcrMETQrVb3UbWglSgWMBPWnqrJtPOW", false, new DateTime(2023, 3, 2, 0, 16, 18, 802, DateTimeKind.Local).AddTicks(9945), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("47acc4ad-9ca6-4f61-a93c-3424b3cc270d"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$xFBmoVCv6MGoCstKN7Di0erNA/kuUfHmKt1PypKlwmSusstWBgJGO", false, new DateTime(2023, 3, 2, 0, 16, 22, 856, DateTimeKind.Local).AddTicks(6747), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("49474833-239b-4846-9f2b-dae17f690835"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$/ijHOYZe71aiyPF08JMSguLAh3g9fY2fV2a7iMNUo66rwqi0kCPyC", false, new DateTime(2023, 3, 2, 0, 16, 20, 444, DateTimeKind.Local).AddTicks(40), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("49d340c3-c2c8-4ff8-9b34-3337be53451a"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$kZfdVi1XsDvKiwQBAw8z3.jEKhj29ZNMLW5mCYmpi08yiJGgRYAOW", false, new DateTime(2023, 3, 2, 0, 16, 21, 475, DateTimeKind.Local).AddTicks(1273), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("4b288f1e-0456-4e50-b513-f59405fc0c77"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$FrqKBkJ4mAfR.eqlz3ZP6eJas90wM6lcehL/aIRcotxzlGz15sowG", false, new DateTime(2023, 3, 2, 0, 16, 14, 257, DateTimeKind.Local).AddTicks(4362), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("4b93290d-972f-43a9-ad29-ff2c9d810577"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$NyVQ4jfE6/Olj/II9k6FnO4qMh2zs2aeM3bKjBaAxF3.E5zjmJaqS", false, new DateTime(2023, 3, 2, 0, 16, 19, 46, DateTimeKind.Local).AddTicks(9658), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("4dc7f26d-398f-4388-9213-c12868bc8dbb"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$17LLn9vng0JCoAYlf3XOp.6NbgUGUVdqwedcijPNPvHtO.mm5Om6y", false, new DateTime(2023, 3, 2, 0, 16, 16, 771, DateTimeKind.Local).AddTicks(8167), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("529cfd82-a4dd-4bd3-b809-31302d54e3c3"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$LCFVX3p1weAYEGpvX0snlexWmHBR160YpZGqZpy4xr2o01b7hdf2m", false, new DateTime(2023, 3, 2, 0, 16, 19, 130, DateTimeKind.Local).AddTicks(300), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("533bc74c-3010-470a-bd99-351bff713ef8"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$ZtauTaECBKO.5b2VzAdT4uqmmQ2URHu461GxZlLwNPD1VLULG5QxG", false, new DateTime(2023, 3, 2, 0, 16, 19, 835, DateTimeKind.Local).AddTicks(4266), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("55fabadd-998b-44e7-ab34-3e8fdb5f0272"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$35bFZpfvmrzV2Z2xm045sOJfMg.pV.aEveBcQYNOYeNYQpW/cZFJm", false, new DateTime(2023, 3, 2, 0, 16, 18, 873, DateTimeKind.Local).AddTicks(4489), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("5867f176-9ffe-46ef-b108-233694adf361"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$FMFgFKqWMuAFvQJutSlDAOghaS/ozVS5u4qzuLQ085o6Dbra4Tcly", false, new DateTime(2023, 3, 2, 0, 16, 16, 972, DateTimeKind.Local).AddTicks(2923), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("59dab54a-731e-49ad-93ee-6512283efc10"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$6MtI27kal0Aqnjxb/FgyIu/0qVOiFSWtdq59zy1/6pxR6Xe8mCgEG", false, new DateTime(2023, 3, 2, 0, 16, 21, 92, DateTimeKind.Local).AddTicks(683), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("5bff324e-1bcc-4ae5-a113-30351cd8ff9c"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$i5rorqnJrFwP0aEDxcnIFOg3Sv.W2SOMMwTXJUDLnTUkHBc0L5zgC", false, new DateTime(2023, 3, 2, 0, 16, 16, 391, DateTimeKind.Local).AddTicks(6274), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("5d45d059-9269-4fb8-8c7e-55b574befa6c"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$Z/m9L8Ae4R/VFYTI5bLDnOfIcN.1Gp69VIMb19PF894jjAtLlE2tK", false, new DateTime(2023, 3, 2, 0, 16, 23, 310, DateTimeKind.Local).AddTicks(170), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("5ed868ca-7995-419e-a20c-1cf99ef6d98b"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$y9cWued9Hg06Vrn3DBbdcu1HPQrZU/GKQ2KBd5MIrfP63/jSxPR/W", false, new DateTime(2023, 3, 2, 0, 16, 18, 963, DateTimeKind.Local).AddTicks(5985), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("5ee39796-7a46-48c0-b86a-6bf0c1e69398"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$G5j0RJ2caS3h2Z4KwhupCuA/qSLH.FQsKWVm1gj5SPtyGxCtrKu.m", false, new DateTime(2023, 3, 2, 0, 16, 16, 586, DateTimeKind.Local).AddTicks(5489), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("62359336-37b1-49ef-9114-27f60dc99497"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$VKxMNqIap4LE/5CqveIWDu4oazJSv1NSqVEi3JbCnv.4OIeQ3nCEC", false, new DateTime(2023, 3, 2, 0, 16, 15, 999, DateTimeKind.Local).AddTicks(3216), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("627ffe57-1483-4994-bb7c-c9959b5069f6"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$swnsySLjgsL2/GliuSfDCOdRQwWJV7.3KVWPivcnjFtpn0Lfw72Gu", false, new DateTime(2023, 3, 2, 0, 16, 22, 960, DateTimeKind.Local).AddTicks(3984), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("661bb57e-e4ad-4a18-ae38-a35e111fed21"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$BVbzg3/Td/lPy3bl.N5cFumdOUE762gA2/81Vt7/KnjW24T6vH5HW", false, new DateTime(2023, 3, 2, 0, 16, 18, 110, DateTimeKind.Local).AddTicks(3849), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("67e87870-b20b-49ab-9e1f-232961ffab82"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$bpS1q7XIu4tpwtF2MeImDuzz7TIVmcImSLpurejNqyCPQzuRuMi6C", false, new DateTime(2023, 3, 2, 0, 16, 23, 437, DateTimeKind.Local).AddTicks(2323), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("68777897-6e25-45af-ae4e-b32f70adf13d"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$7eXK.vllqXqZ3w8Anj.uVe6WRCPZsRgCmznHaV1PXrlvV8QIOA5ZW", false, new DateTime(2023, 3, 2, 0, 16, 21, 280, DateTimeKind.Local).AddTicks(777), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("6e657f65-e52e-4188-9c17-00e897fcc613"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$.UWwBT.p86h0Oa78cyJzjOH2nxVyheMapDZM79HcQQFKz1kdWVQQ6", false, new DateTime(2023, 3, 2, 0, 16, 18, 278, DateTimeKind.Local).AddTicks(884), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("72bd551f-7dd6-4d60-8866-23bc2783aadd"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$F8.ZLMzDfDOMF04W2QPMJ.VJT9OlTE5kZ2OBNkI5Xdj6eCLzF2goe", false, new DateTime(2023, 3, 2, 0, 16, 18, 658, DateTimeKind.Local).AddTicks(289), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("72df4792-4a89-4ce4-b6d1-751a30b350fe"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$fKehlEGp1faDz/0RsriXM.iqtJYRIgDBOb0l5Caa288.G4dcvxKoy", false, new DateTime(2023, 3, 2, 0, 16, 21, 897, DateTimeKind.Local).AddTicks(4738), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("74aa6779-6780-43d0-b6a1-c3eb97ddef75"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$q8JvAbvKA1YsEGsCO1Mfv.GcOEGNhvld8WLN5z2D.YcdquFI87uXu", false, new DateTime(2023, 3, 2, 0, 16, 19, 207, DateTimeKind.Local).AddTicks(8720), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("7574ff0c-b267-488c-9cd0-94ac1a23fa83"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$VTVc7FEHDvpP50VNUHkGo.LSLdwq5CyxjWrpDR2DwiHD4JE3z1T4u", false, new DateTime(2023, 3, 2, 0, 16, 15, 130, DateTimeKind.Local).AddTicks(5632), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("7d6c6688-4a75-4206-baf8-3c104e95f98c"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$b7Q7HB1Eso7XdAQccE2Gz.bs58jA7HBaK7Qo5TTPHoGYHtRj5FjD6", false, new DateTime(2023, 3, 2, 0, 16, 20, 826, DateTimeKind.Local).AddTicks(4658), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("7e9178c4-a4b5-46da-bc03-619cb1909036"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$QI.r2F6XocQlY0ZsKsRluef7CbEZtvJnMYaJA1vjUUseHGGCx/6dm", false, new DateTime(2023, 3, 2, 0, 16, 14, 803, DateTimeKind.Local).AddTicks(1656), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("846ade99-ae68-43bc-9c22-8add0b1fcfcd"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$K1e8YKn6UIaP91VKSemOo.tTYm6GMvCzzu5HraPfHNJeYDkxXO4Da", false, new DateTime(2023, 3, 2, 0, 16, 18, 731, DateTimeKind.Local).AddTicks(7742), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("875dec37-8436-465b-ba41-428dc63f945e"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$FW26Es8gM0kNcWQdmpJZSulJxkZJobzb3NL2.dmOiMK35COOOGtRC", false, new DateTime(2023, 3, 2, 0, 16, 15, 918, DateTimeKind.Local).AddTicks(2755), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("8a4b979e-4ae8-4023-9252-4946fa34414b"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$nG3u2xb1pKodmY8EmCAU4ew2fyoJKUQkdet69PbHkcYQb7yzv3Ri2", false, new DateTime(2023, 3, 2, 0, 16, 19, 914, DateTimeKind.Local).AddTicks(7889), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("914a495e-e3ff-467d-9b9d-e26441bac5e5"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$AGcmlQf2SQZPNbes3x.kdetDTBTToHsQFeNJqN16CX5G9J8bgYH86", false, new DateTime(2023, 3, 2, 0, 16, 14, 737, DateTimeKind.Local).AddTicks(5279), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("93c7078b-461b-4981-aff9-b5d5ccf22c94"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$qNOVFWI1byxJfe/vVgP9m.9EaNrgfhkIwlZtkXNW6ZgsvRQp1vRBe", false, new DateTime(2023, 3, 2, 0, 16, 14, 414, DateTimeKind.Local).AddTicks(8469), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("94dec8cb-1a60-4e22-9679-2d4e7d05baad"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$sM94vi8MUrmFz83/7Bt34OB2BsuLg88Sy8S7AJVa.P9OtV5YlnxNe", false, new DateTime(2023, 3, 2, 0, 16, 16, 681, DateTimeKind.Local).AddTicks(6960), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("971e64d4-c167-4f1e-8cd0-302e152df766"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$meYfNSKnAkOKQ2POOC2ykuzVpBHz2HcxiL7loFKvJHHh5K.tdAABK", false, new DateTime(2023, 3, 2, 0, 16, 17, 570, DateTimeKind.Local).AddTicks(2146), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("9c6846df-c72b-40d3-9f61-a27e3e458965"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$/o6yeEjzFFxC1GXfr1qT3euerZq4yJEHGt.tDpXB0c5DMQziIOsDG", false, new DateTime(2023, 3, 2, 0, 16, 20, 28, DateTimeKind.Local).AddTicks(188), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("a3d414fe-3f49-4822-b9f9-b50edc340286"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$Bj277RKJw/y4X5c1oIIqveXVNcXHiN8iUJdPHjkbadsHrX23wdYuC", false, new DateTime(2023, 3, 2, 0, 16, 19, 455, DateTimeKind.Local).AddTicks(6528), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("a507ca0b-69bc-4bd7-a60d-b5f7bb6a735d"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$ABP4xzCm.Gp3N93gd06cNuXsktfjvWsYr/ifyj6aniMO26qYsxQX6", false, new DateTime(2023, 3, 2, 0, 16, 15, 218, DateTimeKind.Local).AddTicks(7177), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("a53b876d-c7c1-439d-a073-a3e28a9d7bc5"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$9l8oDdPX1wAReV6ZWjdbVO7HEUmz8/Wtv8Fsxzy3tP.tG.bRt0u0S", false, new DateTime(2023, 3, 2, 0, 16, 15, 539, DateTimeKind.Local).AddTicks(1188), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("a971b3e3-eb1a-4329-bb36-398bb2f12f56"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$.CjRAr/OJGAWfxyaJEShd.PxQymEAMjJ4H5sg1z7B2JNtnFddx.kS", false, new DateTime(2023, 3, 2, 0, 16, 14, 879, DateTimeKind.Local).AddTicks(7831), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("aee4bbfc-69b5-4c59-a71e-82b5198230cc"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$KglOONj6eJ9jnEwsTmQgNux/1/NshDziYdG3fkvoyEDR4HWz49D9K", false, new DateTime(2023, 3, 2, 0, 16, 15, 371, DateTimeKind.Local).AddTicks(1878), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("afb57879-c1c2-46cc-8ac7-4b5840950570"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$F8Ecc2KiBHUIK4IpDGefJup4VfgoxiLvbPfWEbSdJ1BgjV9HJeyJ6", false, new DateTime(2023, 3, 2, 0, 16, 17, 441, DateTimeKind.Local).AddTicks(1467), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("b3d16f9c-a7e9-47f0-8c17-02e2c2a5f588"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$D1PKWfyrvP4yJgaLQQMPre3kiW3YHRPKZBQMstKNhQ/HV79nr1nFS", false, new DateTime(2023, 3, 2, 0, 16, 20, 288, DateTimeKind.Local).AddTicks(6378), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("b3e79fe3-765f-4711-a86b-01f8629f617a"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$BwNDUNJUD.4h3Uzh9xJvtuLM3631LCZyjqqKwErGeBdXe3ZqhM86y", false, new DateTime(2023, 3, 2, 0, 16, 14, 13, DateTimeKind.Local).AddTicks(435), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("b603b3be-ab06-405a-91ab-8c271b773ce6"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$AcqNOURGyOibb7zAyr7B6.6gP3OTkAODSYiYD9lv0AsStK/7x2lCG", false, new DateTime(2023, 3, 2, 0, 16, 22, 505, DateTimeKind.Local).AddTicks(5740), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("b8e271fa-da38-452b-b57c-a80a382b0664"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$3SMUUUzV8DXdLhxPj6zWy.xKqAArU8zlGNqA3bQVZFk2ajxgT/N2q", false, new DateTime(2023, 3, 2, 0, 16, 13, 615, DateTimeKind.Local).AddTicks(9521), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("b947f1e8-d0d3-43a0-92b6-184e1ae16d81"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$vzOU7SK7AmTRswtWOJM3AuqKqLEg8xAYVUqR8Rn3Mn0drWXVVAvvW", false, new DateTime(2023, 3, 2, 0, 16, 17, 264, DateTimeKind.Local).AddTicks(9068), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("b9712980-509a-4fbd-9ec6-58e202fa083b"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$UeQPHAt.Mt9SShgPO10B5eto/IdBgdUP0fP.AZqFEuS/0AbAlTcty", false, new DateTime(2023, 3, 2, 0, 16, 14, 962, DateTimeKind.Local).AddTicks(5219), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("ba00882d-867f-484f-8c8a-3226a99fc851"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$W1uruuSKVH6bEh88/7mBIO59XzrGqGuotKI6.xnfrnvk7Sv1MVSbG", false, new DateTime(2023, 3, 2, 0, 16, 14, 604, DateTimeKind.Local).AddTicks(7469), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("baf98389-cf7f-4760-92d1-b349d3c65267"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$Jv8bRNLhsOgrHHhJdNuWsu9mnoMMVwhSjufFT7a0mVAOa0d9J/a2q", false, new DateTime(2023, 3, 2, 0, 16, 14, 171, DateTimeKind.Local).AddTicks(7920), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("bb2669e9-9f2e-40ec-92ae-bb168efee4b8"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$ZZ9ocP38JJogdqQWdWDftuT2e08DQkcxgf7SEmVUb4..0HkSr2Rmi", false, new DateTime(2023, 3, 2, 0, 16, 22, 626, DateTimeKind.Local).AddTicks(8862), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("bbe34f4a-8a41-4a92-8609-ce7280eada87"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$.aWwqVaXPUB0SklIi0DO8O4eic5z2HqXZUIWJykQM0jq1oBtcz872", false, new DateTime(2023, 3, 2, 0, 16, 19, 762, DateTimeKind.Local).AddTicks(7738), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("c0f8fd7f-8de9-40f8-aae1-72a88c23de9c"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$5gxuqW2RMAsZGH8Us7NR/uq5iUxrZpKaoYKncV68PolOtdv.bl/B.", false, new DateTime(2023, 3, 2, 0, 16, 18, 201, DateTimeKind.Local).AddTicks(3923), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("c8b28b45-91ab-4830-b520-bbacaabd7c63"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$shzrNc4RXNY5T7jdUxr3PujSTDv7gcqIhwGzyrTcYWFhb3GsWGl/O", false, new DateTime(2023, 3, 2, 0, 16, 15, 697, DateTimeKind.Local).AddTicks(2651), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("cc267c3f-154d-474b-a83a-36b4486fa858"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$WjnIyCX16lBYqkFilkEsK.t/.Nez0/5wyJzSgPU9cGR8uhsjJg1MK", false, new DateTime(2023, 3, 2, 0, 16, 15, 46, DateTimeKind.Local).AddTicks(7392), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("cd8ad964-25e9-44f3-bfeb-7d22a167f443"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$.11FlggqllAGFTEEUQekPeoCNuoJr1PN963Tv1IqTjDf.j9nfpBMC", false, new DateTime(2023, 3, 2, 0, 16, 21, 185, DateTimeKind.Local).AddTicks(297), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("cf235923-503c-447a-a56f-9ff8a2b68e0d"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$keaQ1Ue1ILgiNSDRlyNIfeiWkR9zTIlvOcmVnpmfoXHgX/wp4WQfe", false, new DateTime(2023, 3, 2, 0, 16, 17, 650, DateTimeKind.Local).AddTicks(6673), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("cf794d06-c933-4657-8c60-3b6c37ab7b34"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$d/5m6bppscmUsg2qwPJ8velBhMstEPJ.a5CU8aawVpVRMIGUOTWYu", false, new DateTime(2023, 3, 2, 0, 16, 20, 591, DateTimeKind.Local).AddTicks(9250), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("d4f5bc8d-5fb6-48c2-99b3-8a7fd32cc97a"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$rs0B8tW4Y1ASUa8EKvb/XuXllRS80pAFUf5wyicsykXrNzYctuhu.", false, new DateTime(2023, 3, 2, 0, 16, 23, 196, DateTimeKind.Local).AddTicks(2047), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("d50b207d-12eb-49a9-8978-c19812a937c2"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$OJHTEesPldn37YH9Eo3IDeavkSkTohZvhHNnttRezbRQRHA49u.tu", false, new DateTime(2023, 3, 2, 0, 16, 15, 845, DateTimeKind.Local).AddTicks(5054), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("d6633382-29dd-4bbc-88cc-8b1ffc9ceff3"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$wghOe3i.gnNTQPppcovV2upJ3GcbSYC3MnxZ3c9zhBCICgKLcbDBe", false, new DateTime(2023, 3, 2, 0, 16, 17, 177, DateTimeKind.Local).AddTicks(3923), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("e7b8f2de-2b43-4626-ac64-904b7ecbd2ea"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$wDU4LGtCcU2MTM/ky3Z8Z.rgcBAi.vOBerkK6.CxBjEkOq8F/DxEq", false, new DateTime(2023, 3, 2, 0, 16, 20, 749, DateTimeKind.Local).AddTicks(6577), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("e957cbd8-5e7c-48e2-9bbd-9d64415541a2"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$VsQ0oE/gsCF7TmFPADqaAe2Ua1AqfEM4KmhuVBQ.2k/PglGwsjLI.", false, new DateTime(2023, 3, 2, 0, 16, 22, 360, DateTimeKind.Local).AddTicks(1912), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("e9936356-d6be-45e0-a381-f52e7f270342"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$c8/DLfqacEYAboq7b1mKcuW17GoST.GdAZTaBpp5Bip0F4jIlVQiu", false, new DateTime(2023, 3, 2, 0, 16, 21, 701, DateTimeKind.Local).AddTicks(4575), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("eb28480d-c75e-4040-b6d0-137c17f71387"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$JcXdpZcSezueYu8Hz.iS3OwJX1EqekEeKnQdRH0HmmHPpxkvzRcGe", false, new DateTime(2023, 3, 2, 0, 16, 20, 518, DateTimeKind.Local).AddTicks(5492), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("ec08817d-80ba-4927-b7cb-1e7738a53c4e"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$iKSw52nAfAsofwh4Ocuuxehe0x5/mMGZ0hHjjFyWjMlitWRM2yAce", false, new DateTime(2023, 3, 2, 0, 16, 17, 784, DateTimeKind.Local).AddTicks(8584), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("ece83656-cdd1-4872-80a2-8e1f1f359fd4"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$qT0FwA43DLlZm5p86IuEc.XpzABY8nJvy9GYAnlLqs4u8NDbjPMV2", false, new DateTime(2023, 3, 2, 0, 16, 20, 120, DateTimeKind.Local).AddTicks(862), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("ee24dd48-5c85-4f8b-9d0e-0d11824d5158"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$UVISJu8mvNPgfLObBoenDOnYVoXmylv0SCQt9bYkBeQGaq/Q6dXoq", false, new DateTime(2023, 3, 2, 0, 16, 16, 288, DateTimeKind.Local).AddTicks(4687), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("ee966e7e-fc92-49f4-96b1-7991dc4d8ee1"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$sMIz4FW/wxqRwK0YH6VM5..6MkVRJlpA3ay4yWJuF9HihPOYA0qaa", false, new DateTime(2023, 3, 2, 0, 16, 17, 83, DateTimeKind.Local).AddTicks(5637), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("f0aab958-3e90-4931-942d-3b46b556dae7"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$DyHNqgKOidl.t7GmmbtODu6ZGdQLl58u4fludkz12Z9k5tUm.bW5i", false, new DateTime(2023, 3, 2, 0, 16, 15, 451, DateTimeKind.Local).AddTicks(7390), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("f1e4bf89-b498-4f61-8360-f1d10d5250cc"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$dEuZyfB/eqNvZ3LZp5go9uQKu8/6rI5K0TA3rFOSf0uHohe6y7f2G", false, new DateTime(2023, 3, 2, 0, 16, 17, 348, DateTimeKind.Local).AddTicks(5968), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("f27cfd77-48b3-4b75-9c1e-f1b48e560e94"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$j6gxx2biyzdXKx3vZCP/jOd2fraop6rJk6YHStrdnjsd63GAM8PFS", false, new DateTime(2023, 3, 2, 0, 16, 16, 867, DateTimeKind.Local).AddTicks(834), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("f4b244dd-2cd5-41cf-b912-866768bb3935"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$FsIGJDw9n26NEiqS2UBhW.2DPIVRUpPk541HawviHYjCpH9MwcfEO", false, new DateTime(2023, 3, 2, 0, 16, 14, 83, DateTimeKind.Local).AddTicks(2040), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("f94deaec-c160-4d92-96d2-186847908e19"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$.b61a.c3Jqd6J2VEPBu4Gu2bJ0zG4bh3Te6cl1pTg38.ILsW37WlC", false, new DateTime(2023, 3, 2, 0, 16, 16, 191, DateTimeKind.Local).AddTicks(2416), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("fbf4e941-3a24-4658-8beb-ebf45b54d1db"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$UyPg/5sngeP3KH244oG3ueReo9GBAyyu1VxzzVjmII5nRXWGQeBrW", false, new DateTime(2023, 3, 2, 0, 16, 15, 295, DateTimeKind.Local).AddTicks(5621), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("fd1a8354-119b-4f85-9f45-da19f67b2818"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$MR5ReMfBrOzseYfpR65YieChSEylbmQpbLxuG7iHL5yslg.0YLGMS", false, new DateTime(2023, 3, 2, 0, 16, 20, 912, DateTimeKind.Local).AddTicks(7918), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("fd3b7a73-66c0-414e-888c-7ecd1e8d5b34"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$5mkZgG4VloMz6yqh5sA5FuQxKpkORB4JIQfa309t4s1zHlajiQtYK", false, new DateTime(2023, 3, 2, 0, 16, 13, 914, DateTimeKind.Local).AddTicks(4557), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("fd6703e2-fd3e-40c4-a11c-ccae6c173a3c"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$wsmbyrI9XbP.UkPkoGqFp.n/9UnNHXgwhiu6SxIIZacJXiyUCplyG", false, new DateTime(2023, 3, 2, 0, 16, 18, 415, DateTimeKind.Local).AddTicks(9458), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("feca751b-abbc-448a-b028-67e1097cdcff"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$Lpnz.deUw6RgDPnBd4XAgu27gBzn58yyOKZjGrmFRJebUVPFzwrPC", false, new DateTime(2023, 3, 2, 0, 16, 13, 700, DateTimeKind.Local).AddTicks(5003), "Buzine", null, null, "0519358893", 2, "rbuzine3" }
                });
        }
    }
}
