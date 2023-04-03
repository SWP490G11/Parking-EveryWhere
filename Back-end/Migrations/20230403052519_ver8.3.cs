using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver83 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("0099045a-a32f-4e7e-8a31-01602f145460"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("57af7173-8268-467e-bb67-c0d64fe9b21c"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("ac2d4a7d-2372-42bc-badb-e84dd6652cfa"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("b0ebbd50-deab-45cd-84c7-1bff5501e95a"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("b5500fb3-1927-405a-b8d4-36ae7e55d914"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("f751c094-ff1b-4c2d-9ef4-68389d544f21"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("2fcc6c82-6c00-43eb-855c-766bb6bf3f1d"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("3b257a55-6a35-48b1-ae78-71343b8176b4"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("fc1393ac-0e9f-48ba-b3c0-12ca169ea14c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01539818-dd4f-4a62-ba7c-24aba9c30262"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0243bf79-4776-4adc-8b5b-56d5e78af683"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("034158b4-3c9c-45af-82b3-b7aa57e84d6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("035449e1-5990-49e1-8485-47ac839d7728"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("03f1f1dc-615b-451e-a267-31f2b0f8d5aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("04a89a22-4d7d-48bd-8f69-14541cfdd644"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05e1b528-6a56-42bd-ad2a-ed4754165863"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0762ca48-84e4-4ab7-ac89-2a632eda8069"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("083daa44-a053-468c-839c-a64b46fdfe9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0992bd70-7669-40f8-90d6-e6c5fb3504fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0afde098-0a56-4130-a40b-36372ded8215"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0bbb64d5-1848-4f70-b37b-039e6ee16600"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("12c5cdf3-edea-4782-87e3-f5eb9bdff6d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17651456-6edc-4204-b635-31e159d03546"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17a3c8e1-8c6a-49d7-a550-b7a339d26089"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("19c72691-6c5c-4b03-9633-99d56bfd0321"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1a0484ab-f3e1-44d0-b3a6-df120f698c9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1aadfdea-18f4-4222-819d-ee99b83446fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("20440839-e2e8-473b-947f-70347c65fe0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("21c72b12-2436-48b3-af18-795d42ea2947"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2200d21d-a795-479a-8fae-0222cf2e579b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2570ff72-01a9-49a0-9ac2-4af522b9976f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("276d3658-af87-4918-8974-f556bffc0590"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("28dfeab2-b98c-4469-b058-686adb4feb64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2d39c9c3-f6a7-4aa0-ada3-38857e632a55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2fb76a09-ae6b-424b-9afc-a9a471e8f043"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3178f9ca-80cb-45a2-af60-bcaddac79960"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("31a192f6-b07d-4296-9cde-120b626031b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("31b77618-cb01-4e9f-a755-edc84954e71a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("331d9deb-ba18-48e0-8792-30e221d3767d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("34631a6a-1ba8-43ef-851f-fb90f3219df7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("34b82da9-6660-490d-be64-5eb06e46e935"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("35c62e00-a694-45b0-a264-9d61d46c947e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("36af18bf-1b2a-4593-b2e2-e599543e5fbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("38d9c589-4e90-49a9-a8f4-3466aa22390d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("39f8b45a-8e27-4b4a-8b7b-21047262475e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3c0075f2-a73c-452a-8080-4dac314deca9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4177b460-f2fb-4f89-8fb2-88816f4c3269"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("487d9dc6-17ad-4207-8b67-df67e51c13e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("493f4030-9f5a-47fd-a08b-c715bf0efc6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4b497080-6a52-49c3-b632-75f467da0383"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4bae5117-4ebf-4b8a-af8d-18b5104e7ec4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4f2bf3fd-b37c-474e-a829-41ed21d9ce71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4fafe2c3-afae-4fc2-9915-140dca5daefd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("527b799a-7900-49a1-9816-3129e4ad7ead"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5325f594-b66f-4410-b56c-8c81bf6571a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5a5b3c71-ab1d-4072-8dfb-5ff748d1ab77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ab26f10-315b-4ade-8623-c58dc1ed0e88"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5b7f230b-0d06-4f8f-872a-397f97629b66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62b8e36a-4b0f-4719-8f3e-8ec0bdf8f3a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("64a78d09-01fc-4aea-8e49-4d8cf057b6e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6770e215-eac8-4e3c-b5e9-1151a1e7e40d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6aa5d534-7f97-416a-9f86-4084c828550a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6afbf6ca-e96e-4ee4-a910-90256b81b078"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6e547c60-30dc-45ed-bab2-0eb8fb33a611"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7321bedd-7b5d-4fb0-bea1-1fa54465d44b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74a179fa-88fb-4b52-b0d6-e9a1cc53d656"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74e0656d-a357-4018-96d8-7e91037ffbbf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("75282bcc-7171-4785-9d2c-854fce5779bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("760adb58-2cea-4c3e-b675-9daa6893515a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7666e789-fe6c-4914-84e9-19cc65492e62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7799dfe3-2ac7-4920-9edf-36d1630cb8f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7a3d7f48-9a4a-4e35-aaa6-eaaf5a1226d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7cd6d20e-ed52-4ace-b972-d1b38ee1dded"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d1fd6d3-b555-4264-9aef-a0fd7a52c2c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("80b6f457-5943-440d-8dc6-c5f03daf4b55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("812eecde-d9be-48d1-aefe-2d71aeeafdc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83c825b7-6a8f-49a0-ba45-194aa5df0aa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("841682eb-99b1-4533-809e-ac0cb1b97162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("84ea59fb-2c6c-49b4-a611-2a410dfb50a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("898028ad-3c2a-4bc0-ae0e-7b75b60c8ebc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("89f9f845-84c4-4372-a446-d3ae8cea825d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("90bc8607-cb1f-4a19-8192-f19da3cd2e67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("926b1b6f-9b44-4352-a5b5-9940c5ce1f80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("944fa584-2321-4c60-9de5-ea0409864f6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9a80d06a-752d-48db-a688-189030dda07f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9b53525a-5cb9-42a7-a893-3da571bffe27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9dac4881-db8b-4a2b-af64-5a49ba17b991"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9dc5883b-61aa-48ef-a661-849c41e3ee9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f43de80-a5e1-413d-9f84-2c6dd3c63ce1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a463fcde-54f9-41bf-abe5-3e4fbf72a470"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a69411f8-d000-49a7-a68f-6a1c91e291bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a92bb3a4-3774-4635-97c4-a5be34d40726"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b0bb5422-34d6-444c-8b84-dc396f212663"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1446209-d26e-485d-9036-fffee3642f98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b2a70b15-486f-48cb-9fd7-09aaaa3275b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b5886d91-afc1-4d17-b71f-c1fdd0a07f2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b75914cd-49ea-477c-a006-1fdeaeaaaa60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b7cdb0a5-b954-4c7c-8d42-2c542d815188"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bcdd6694-fac0-43da-bde6-39194cc9c01a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd7f1948-b5e9-403f-a7ab-c947dd757253"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c0e68864-0891-474e-af3d-ed807499587a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c4666f5d-d83b-4781-b19b-8d98414cfa2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c53d67e7-eccd-4694-b322-00ee11419c42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c74764f4-8fee-4cd2-83db-c7d4bb711f94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cce916ab-8c74-4ca2-a716-4227ecb3092e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d3231650-cb7e-43f6-9cf7-2b009acc7ab7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d45ebf03-9da3-4124-87ad-c73e2bc7612a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("da7d433b-e811-4b39-ac11-eaebbefdbb1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("df1fde54-004e-44e8-bf81-de2faaf07e14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e1877b18-df36-4e59-92f9-4efa49e11a76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e363018a-e38d-478e-a366-1bfd9bf2c4bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4793e61-f5ea-4917-8fd1-c6fa5235bc73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e62cead2-64ed-49b0-a984-1fc7eb11e2ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee13ac84-d40d-4a08-8ef2-7697258ba555"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee240a02-cdff-46ef-a230-2139a4d04c01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f04c5c1d-9ea9-41c4-b6fd-0511344a7f5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f39c3c4b-ddb4-40b8-9412-0b58a2771f3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3e10a6a-0bb5-4317-895b-4b7789665207"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f593be9f-501d-42c1-a6a9-316abbd1b170"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fb7ed84f-5aca-41e9-8d8c-ef5a4bd6c68e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fc82c8b4-af0c-49c0-b5dc-542c618f87a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fd43f104-04a0-45e3-85b7-4bcfd1e5e8c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ff89ee6c-7dc5-4ba7-ab8d-0c12530e8177"));

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("09583c37-6d8c-4487-bdcd-3c4df85bb51b"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("24514283-8d21-4550-9d6f-cfeb5716c5e5"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("4b5214a8-044a-43ef-98e9-43cba23b5ea1"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("844bc9c7-fc72-48a3-9a28-686c8760b63a"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("9c888cff-e135-4d4a-a4a5-73036aa15e3b"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("d8648d76-d3e4-4250-a585-c53ef5d91c56"), "Xe bán tải", null, null, "Pickup", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("262cb4dc-97ce-441a-bcd1-c102c55d1704"), "1 Year", new DateTime(2023, 4, 3, 12, 25, 19, 30, DateTimeKind.Local).AddTicks(3714), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa1263b5-a98e-4479-95f7-8767acc08f8f"), "Short time", new DateTime(2023, 4, 3, 12, 25, 19, 30, DateTimeKind.Local).AddTicks(3708), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3ba3d8c-469b-4c4c-b318-186bc903cacd"), "Half Year", new DateTime(2023, 4, 3, 12, 25, 19, 30, DateTimeKind.Local).AddTicks(3712), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("03e0d88d-eeda-4ccb-9c29-7448bbb63ef3"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$gZz4B4.2kdR3YnX3zgnq2OMPg2IHHXlv5aQrWfepycxdSZGhFV7CS", false, new DateTime(2023, 4, 3, 12, 25, 11, 597, DateTimeKind.Local).AddTicks(3112), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("04dabb36-aa17-46d2-9b9a-8b3fc67448e6"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$76A5HoARjKgxbXVJ3bFTpeufrkRV6FsSqbo9Ba1oILBT1ncILdQuy", false, new DateTime(2023, 4, 3, 12, 25, 12, 549, DateTimeKind.Local).AddTicks(3746), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("071a32fb-c9e0-4bf1-bc14-74ffcacd0c5e"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$pfUiNO4jRD8sNaXrbYBZU.eKoPyf0PVUPWiAp9EGrCMeSTunUHNC2", false, new DateTime(2023, 4, 3, 12, 25, 17, 41, DateTimeKind.Local).AddTicks(2307), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("07972fbc-e619-4921-9cb5-f8a38cea54b1"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$i20WPjWuMaIX0CxMDZizUOWj.fP7ATEiIvwtW3Eppg1dIRWeGVbqm", false, new DateTime(2023, 4, 3, 12, 25, 15, 508, DateTimeKind.Local).AddTicks(3761), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("08e98864-98d3-45b3-8a0f-0e5c42928707"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$KK8xVS9P4weItYScajmXZ.Q180CZTS2cuiOCw8X.RxSEOLWK07BFO", false, new DateTime(2023, 4, 3, 12, 25, 17, 128, DateTimeKind.Local).AddTicks(1563), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("0961ebc6-1a08-4c9b-84c6-57f3701ffe4a"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$/NQlnIJQgDKx7MmxlPAdBOBbju3S/U0tjvz1RNgYHbKbJkbjDrIL6", false, new DateTime(2023, 4, 3, 12, 25, 12, 363, DateTimeKind.Local).AddTicks(9500), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("0d82f234-b849-4357-a981-b5d7aee5e091"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$yCqR96Rpxlgse4N.0IzgMOFGLfVTZXauMAE/5mzXncHImocTe0uou", false, new DateTime(2023, 4, 3, 12, 25, 11, 163, DateTimeKind.Local).AddTicks(797), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("1070fc9e-2735-4bbc-bbff-ec4727bb09fa"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$a/25XhzZqS35GE0Vz9d3F.a1PIm0tuxRiviK0sQ92XpeD4cgimDo6", false, new DateTime(2023, 4, 3, 12, 25, 14, 171, DateTimeKind.Local).AddTicks(5203), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("11528182-c13c-40d4-9523-270552a264bf"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$xGv.IF2VlaDZ63lgd8WmAeQ28SGOtWAXz4uW/1nDQDGxl0y21veC.", false, new DateTime(2023, 4, 3, 12, 25, 16, 295, DateTimeKind.Local).AddTicks(4242), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("16b58086-333d-4450-be72-bf552e7e8417"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$FGE20CufqI2FlthciWOHyeZtDUbOnFzuijtq.Wci85C6LW5qYm2Y2", false, new DateTime(2023, 4, 3, 12, 25, 18, 597, DateTimeKind.Local).AddTicks(5811), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("16d25e37-cfd6-433f-9741-842141561b40"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$EsIPNRSBJxAotsTei3U9reVjMRhRE.umeqSsmcREbGfDpznR.YVM6", false, new DateTime(2023, 4, 3, 12, 25, 18, 268, DateTimeKind.Local).AddTicks(1434), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("174685be-0384-4024-9a6b-e0e67e54c891"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$HJd3HYx99ZnUAm8yUaJU7u4.WDf0acZfFsEy.qO0QvCeoiDHcNAkW", false, new DateTime(2023, 4, 3, 12, 25, 12, 450, DateTimeKind.Local).AddTicks(8913), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("17a28b5a-3eba-4f8e-b281-3bf367db6c9b"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$CS9zoZTnEbWLMhaw6XEEYOCqZv2IKeA0ZdqSc84o96Qoevg4nt2Yi", false, new DateTime(2023, 4, 3, 12, 25, 18, 857, DateTimeKind.Local).AddTicks(7864), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("17f13939-cf69-4540-ad29-e9dc1bd12cd0"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$5FvGSQYMoJovZV4kBbawBuIsw9Of91min6p929aSbcH6xVEjS7TZK", false, new DateTime(2023, 4, 3, 12, 25, 15, 130, DateTimeKind.Local).AddTicks(7624), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("187af0d5-8956-465e-af07-e3cf56c39e6f"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$/j/Xj5EaPLZxCUqXzO0ytOsAkq4Bsw9AxCIhT75IVsV2IS6QRQ9uK", false, new DateTime(2023, 4, 3, 12, 25, 16, 820, DateTimeKind.Local).AddTicks(7913), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("19834e9f-0ac4-44ec-ba80-1350adc309f9"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$Vq6wKeOBN81sT2fJp4Qy3.cpLYeVS2PV3uZ221btiIFUr1AdTRTtK", false, new DateTime(2023, 4, 3, 12, 25, 15, 44, DateTimeKind.Local).AddTicks(4275), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("1b81fb20-cad7-42e9-a95c-3111565015ee"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$OkWQRNL.mk19hUhJuuaAS.79ODE5bDMvBmtmmdem49QJPgc/1k/jG", false, new DateTime(2023, 4, 3, 12, 25, 9, 418, DateTimeKind.Local).AddTicks(5068), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("1cff0e16-51cd-4918-8bb5-7b73234abb42"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$PmKG9nMslxbh3LgJxn/q1.H0O22OONEVSVBeGx7GvzjJHNiOapNy2", false, new DateTime(2023, 4, 3, 12, 25, 15, 237, DateTimeKind.Local).AddTicks(1666), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("1d2cbbe2-d9b5-4edc-b980-286b9275da2c"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$CAHMhRnYAQt2WzabduUbKOyIHffYCXpn/LlGADkAQcgW2vHURljue", false, new DateTime(2023, 4, 3, 12, 25, 14, 754, DateTimeKind.Local).AddTicks(7158), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("1e22ab99-8126-436a-8e70-22a22c631d37"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$p.YZORF6Yt5kTGQrg7gxt.ed48zxicRFywuJLlzMqNRDM040U11OO", false, new DateTime(2023, 4, 3, 12, 25, 10, 266, DateTimeKind.Local).AddTicks(4027), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("1ec1c2ba-e9db-4f4f-a74b-9fd7f8b29967"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$ngq3JIcYtd0v98LIW6qG4uF34uqD.7jMRn2NmcQ15SnrNcaTQTyqq", false, new DateTime(2023, 4, 3, 12, 25, 8, 221, DateTimeKind.Local).AddTicks(1097), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("21f5d62d-0208-473b-b39d-1f3cbffe7325"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$PH9cilbuNyT1ubkXGKUqDOxBv8B8aeyOe8tLwyU49zP7.Nrp086pK", false, new DateTime(2023, 4, 3, 12, 25, 17, 756, DateTimeKind.Local).AddTicks(4761), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("262ab8fa-25de-4e9e-adea-c34a010af00a"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$YLJFDvqpE8wAu1012PxpzOs.tn5MRdvjKN.McTAvkeonu0DR2jVIC", false, new DateTime(2023, 4, 3, 12, 25, 14, 665, DateTimeKind.Local).AddTicks(8827), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("26f8cc94-d3d9-4cac-8e7c-c40a5086ee2b"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$u6zdziNGZvw.JQTv4UDkteKBuo4FW0LvEA.X3n64g5F.m25mQGLNe", false, new DateTime(2023, 4, 3, 12, 25, 10, 702, DateTimeKind.Local).AddTicks(2635), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("270248bd-737e-436a-84cc-cfdd5197b1d2"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$Q.oW5bBlv9H/4BiZLo06BeWxvmmICxlVExQZ00R910vcOQe4ZeGJC", false, new DateTime(2023, 4, 3, 12, 25, 14, 959, DateTimeKind.Local).AddTicks(1853), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("2a6b5cc9-fc3b-4b18-9b2f-5c0e995b2043"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$MZ8PuaviQSukBg59mR9xhu7Bi0X48gfUOvRX0InojPJF6/Y.ETn.C", false, new DateTime(2023, 4, 3, 12, 25, 16, 733, DateTimeKind.Local).AddTicks(6588), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("2b6baecb-956f-4721-8e36-3b96a494c552"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$xZAh47EsVBVEQzTDEbyADuJU/XmIyCluKH6PkovKTKlwazXjYv/u2", false, new DateTime(2023, 4, 3, 12, 25, 9, 501, DateTimeKind.Local).AddTicks(3695), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("2c75f431-06fd-4716-bde7-00799f27c828"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$xLFZiZxvRNkWSH.IMuGkBe1qezC..MYYuy6H5igbkmDo5.S0gjHce", false, new DateTime(2023, 4, 3, 12, 25, 12, 757, DateTimeKind.Local).AddTicks(8815), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("2cdc963c-4426-4380-b317-bf88b7225b8a"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$QohetYioo/SWCx.Bzw0qyeEzK1.QOT49VpcgIUiDOHKJlcsMHLyWG", false, new DateTime(2023, 4, 3, 12, 25, 13, 743, DateTimeKind.Local).AddTicks(4146), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("2e803f61-3a81-49d7-b4a7-b4012dce5f58"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$8.9Cdaih3Ql2/7eUf6anX.0le8nfC/QtApVJJw.TFmqiaa2oNzXEa", false, new DateTime(2023, 4, 3, 12, 25, 12, 672, DateTimeKind.Local).AddTicks(6315), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("38236c18-8a93-4b4d-9750-5db163b88faa"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$hvyE8N61cbxvHYDnya4YieEcQJsEqS4tpbZPer.rYpoFp9cQ1HGq.", false, new DateTime(2023, 4, 3, 12, 25, 11, 510, DateTimeKind.Local).AddTicks(3606), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("3d8a07a3-ecef-42d2-b52c-9b71470345d6"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$4.6RPAGipbstlZH8mzSl1OsKkwsKi33hnB5GoFFWGIl9ydfUXOVY6", false, new DateTime(2023, 4, 3, 12, 25, 11, 942, DateTimeKind.Local).AddTicks(4869), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("4147ea02-bf11-4a70-8717-2d6f8c653386"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$UyfKLl0Lbhyev/CYnGMFue5inykfkuPAi2HZ1jWbQjL3qvYKoFxsG", false, new DateTime(2023, 4, 3, 12, 25, 13, 13, DateTimeKind.Local).AddTicks(6774), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("44dba8a9-cfb4-4520-ad48-f061ad8a105f"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$k/H87gh6kxweTVX.pxNXS.v5LuYxJ4sEoRiT65IvH/IHsvrt33eu2", false, new DateTime(2023, 4, 3, 12, 25, 18, 771, DateTimeKind.Local).AddTicks(5153), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("44eb25bf-c115-4f77-9da8-e01cb0bf361b"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$KbYX3c/9u4P5O3DQUDEbROdxO/QNFBrEQYpyinH3Lki84I3hkdiTa", false, new DateTime(2023, 4, 3, 12, 25, 10, 597, DateTimeKind.Local).AddTicks(6644), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("4523280a-f32b-4fca-91b7-777586930e00"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$imrZ9tbY6zIFIKPp4ZOrvuTT8sX1xmCsBsFNpJCpcjlQyh3tXQ71W", false, new DateTime(2023, 4, 3, 12, 25, 18, 499, DateTimeKind.Local).AddTicks(8677), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("487997e4-f8dc-4ffb-8755-c3bbfad2a5f1"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$skzfRCxJ57FwfgqHlfXpT.lcUpCMseAwKi3cVThWF4RWz7Zq32876", false, new DateTime(2023, 4, 3, 12, 25, 17, 395, DateTimeKind.Local).AddTicks(4094), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("4acf3193-fa3e-4443-b1f9-84cda9a31fa4"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$RQtfe/7DLsoiwyvjTfD0vODQAuPldkhQEkZwvf.OM.4.lhwJS6JYq", false, new DateTime(2023, 4, 3, 12, 25, 10, 127, DateTimeKind.Local).AddTicks(3134), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("544c20d4-36a1-4640-a7ed-bb253744a7b1"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$RYJeQbzBXRbV3M6nDPl3U.5oqINQFuwzz9f5htle4gkfViWK5YjNa", false, new DateTime(2023, 4, 3, 12, 25, 10, 480, DateTimeKind.Local).AddTicks(3371), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("5676e3b0-8277-4cfa-8584-dd3c8fb1321a"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$p6YUBQYgfB/xfCzrkwa7du9UrOyvjMP6atsq6orG/zSvmVOTI1CZa", false, new DateTime(2023, 4, 3, 12, 25, 8, 526, DateTimeKind.Local).AddTicks(6314), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("57a6426a-d762-474f-94da-a5686625c8de"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$6XYZBkf8uSS/wQwKICU.B./kb8MmJzGxbbcU3dmOF53I7Om0FkveW", false, new DateTime(2023, 4, 3, 12, 25, 16, 512, DateTimeKind.Local).AddTicks(9940), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("57b698cf-bae8-45b8-b6fc-2bd438be2208"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$LsDe7u6YgBOUyJWqS3t.9uxMZgmDmlL.BbpSB20rsZNeaNzK8sZZi", false, new DateTime(2023, 4, 3, 12, 25, 17, 226, DateTimeKind.Local).AddTicks(3361), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("57d26f89-72fb-4279-b5bc-85edf72df0a8"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$EImlNld6FLlgIz2PcgF3bOJSV4E479NFsFz3My/nbyxhXx6XsQSnm", false, new DateTime(2023, 4, 3, 12, 25, 15, 421, DateTimeKind.Local).AddTicks(8684), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("588a09a4-6c58-4386-9021-a05d5d0ff8ea"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$jsD1nDho3H7v3NDJiwttOezEJul9S/diKizqu72Hk8C38DpgdyrfO", false, new DateTime(2023, 4, 3, 12, 25, 15, 596, DateTimeKind.Local).AddTicks(2559), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("591a4906-c836-4fd7-900b-593773433cb7"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$jya/WOJjkBMtZFxmMfYN5Owe0DAzdMUFmC/X9ASu.Un8Ok7mXEBj6", false, new DateTime(2023, 4, 3, 12, 25, 17, 847, DateTimeKind.Local).AddTicks(7419), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("5d41cf58-7904-4a17-b9e6-466fedcab525"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$.MBwbeRtkRiYbnz2tielX.H8S83eP1dGVZS2GyfNfyPj/qvgpepCW", false, new DateTime(2023, 4, 3, 12, 25, 7, 950, DateTimeKind.Local).AddTicks(555), " Ass min", null, null, "0966416708", -772000, "admin" },
                    { new Guid("6203cad0-9fb4-4697-a355-050af6fde6bf"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$bCHNggIfDXpQTt12.zcqk.WwhsLv9fkS/i/BUwJbRuKu9h35BrsiW", false, new DateTime(2023, 4, 3, 12, 25, 8, 622, DateTimeKind.Local).AddTicks(2188), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("62bcd66d-c6d9-4520-adf9-b35448f9298c"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$50XyjprKxvh6iexkQpapG.0L0yQPcULodJdVX3VIJjlqZhRUDJT3O", false, new DateTime(2023, 4, 3, 12, 25, 17, 482, DateTimeKind.Local).AddTicks(9139), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("6338c626-d523-4d6d-848a-120ba4ba81a6"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$g5VNhrWcLB186fH6iDzuzeIV3aROm8yOqhU/eSnMyWvTH5zrmBTKq", false, new DateTime(2023, 4, 3, 12, 25, 8, 334, DateTimeKind.Local).AddTicks(2375), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("649553a6-ffcf-49a4-a6f8-60be4e2ace69"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$U7Ty88G2VRpUiFV3S.3G6egGNLbUNYvzV3XOHvHVni9j1pli0TG56", false, new DateTime(2023, 4, 3, 12, 25, 12, 28, DateTimeKind.Local).AddTicks(7760), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("64bd5548-1ea0-40dd-a991-7854f44eafdc"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$kEqyusX/4BzjxETKT322B.6J4Tmo3v3H2X.k4Y7JLqdR3LFLBkRDK", false, new DateTime(2023, 4, 3, 12, 25, 10, 989, DateTimeKind.Local).AddTicks(3708), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("6746c0ad-2ea0-4c4b-92cd-6b797f226e50"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$A.4zxyi5q6ZNBidccojzleHjeW060QmZe9y0V8JMYoDbxNvk.Z93S", false, new DateTime(2023, 4, 3, 12, 25, 17, 660, DateTimeKind.Local).AddTicks(2414), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("692bf3c8-0d92-45d2-8da3-44ad760bb0db"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$qWUoqyayRuc.cKRYdVSA/uViw8ahG8xL5ujC7xB61qBH0dIApFWxe", false, new DateTime(2023, 4, 3, 12, 25, 16, 400, DateTimeKind.Local).AddTicks(3344), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("6b8bbea5-3f4d-4b93-93e6-3fccc73ccb7b"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$W6ItmtDCx9EpWAeoXCZAveXy8TY7g.N6Hze85lLGu2gEs4lrXp.y.", false, new DateTime(2023, 4, 3, 12, 25, 13, 914, DateTimeKind.Local).AddTicks(9971), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("6fc95508-d1eb-4150-aa30-6428d9514970"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$cg.wySlhFcLM/W6sisFlk.fuzpc7kcbaYqUBTX3KDRTY2pMoLeVU6", false, new DateTime(2023, 4, 3, 12, 25, 11, 857, DateTimeKind.Local).AddTicks(4707), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("720b7a91-adaf-4031-ac3d-bb2b79c082aa"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$4yrfHH6I9Mea6pqIz80I6O4FMSLvrwuuXdTnviRFs5IREd8/WWrxa", false, new DateTime(2023, 4, 3, 12, 25, 11, 337, DateTimeKind.Local).AddTicks(828), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("723e1c70-544f-4580-983f-eda57958b73d"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$VVbn/Qhq/coz.yavsq4nDODx4AdS5Qt0Hu94MHiH5taGlsuJJdwzq", false, new DateTime(2023, 4, 3, 12, 25, 14, 255, DateTimeKind.Local).AddTicks(9927), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("73cd0415-4b03-4d27-8a46-dfb65d2e88df"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$/G5bkBunFBVQ.wPYpLHu0O9Fo2dhvh0QZIg8CjVghDHFhtxFCMVuS", false, new DateTime(2023, 4, 3, 12, 25, 8, 39, DateTimeKind.Local).AddTicks(7496), " Nguyen Van", null, null, "0966416708", -772000, "customer" },
                    { new Guid("74cd02f9-b072-446e-937c-2f3efbe55a83"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$OJrJ1gtFjj4qc8CoCSkGZu9cqQjMwwDGf2TjjW.nsVObScTtW3uIm", false, new DateTime(2023, 4, 3, 12, 25, 16, 634, DateTimeKind.Local).AddTicks(458), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("792e5fab-7d3b-4293-b040-ccfab35518e3"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$dIJ.PiCGa3oON5cCXmbYJOn0ava5ej7tVXO9dWYPHL/8VUVugPsva", false, new DateTime(2023, 4, 3, 12, 25, 15, 952, DateTimeKind.Local).AddTicks(4219), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("7cfafaa9-fa72-4e6f-8889-a56bd994f289"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$Wf7k3p7ftDjtVIhxlbrC5.xlKEhjDtGfRHPuUYaO0x4H3HufEXJcS", false, new DateTime(2023, 4, 3, 12, 25, 15, 865, DateTimeKind.Local).AddTicks(6144), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("7d7fe8bf-e45e-4f13-9c32-4722c600d6f8"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$r0PP4aKPgHbIEGs3BAnzYO8j2bWtKC6ZKSy0/H/1H5uySJ2Zf87XW", false, new DateTime(2023, 4, 3, 12, 25, 8, 824, DateTimeKind.Local).AddTicks(3191), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("7f14773c-a18f-4904-8f8e-9eb8ad6aad20"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$MfUm25l2IQlCddMYxU0avOn4EDpe14kkiD8xgB4mMcfQgxGoM1h4a", false, new DateTime(2023, 4, 3, 12, 25, 9, 755, DateTimeKind.Local).AddTicks(3010), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("7f6c08d2-dd01-4180-a22a-9b923e8fd2b6"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$e1BvVgtRX/EuCVPwabErDe8.ZiD2M7oxEIq4io4malM9MhQIhww6W", false, new DateTime(2023, 4, 3, 12, 25, 15, 694, DateTimeKind.Local).AddTicks(7145), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("7fb7c1a7-2ec0-4e76-9519-43ebeca6ac45"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$bFybam2Rps5o2KCX.axpfeyNtRrDwWbSV2gPZLCnLhzRcndrJHT1C", false, new DateTime(2023, 4, 3, 12, 25, 18, 395, DateTimeKind.Local).AddTicks(3826), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("81d4f01f-1d6d-4de8-abad-50e9348ed1f7"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$0ioWE.bU5ALkNden1PthWuPidEfABWmCqua/nOnS/jXKQyJuoR95G", false, new DateTime(2023, 4, 3, 12, 25, 12, 843, DateTimeKind.Local).AddTicks(2315), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("821bff10-4c9b-4752-b6ca-90c509aa7a9b"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$4JDVMVOiVbL6Elvf.JuOSe/4uUu8dpfD/aCY1btwOYIJ2rWxoBsW.", false, new DateTime(2023, 4, 3, 12, 25, 15, 781, DateTimeKind.Local).AddTicks(9556), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("8385f317-6365-4ff1-983c-ecc1f9102539"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$lgGg3ruJ47Sz/.pn92PHQeYfG5IugcAiVe4X5CwnHf7ka1CVYn7f.", false, new DateTime(2023, 4, 3, 12, 25, 18, 34, DateTimeKind.Local).AddTicks(7613), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("83aabb06-6c0a-4387-8183-759ae2e378da"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$dRwV0D4CZWmnqb4yyI2IK.nL.Qbb.XPylybmnahWUi34GmkFcLLp.", false, new DateTime(2023, 4, 3, 12, 25, 19, 30, DateTimeKind.Local).AddTicks(3091), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("8746125e-301d-4836-8913-301341a89db8"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$DD5yoKw4vX5eIhJN3dcK7e2mRTWPW10ilj8qO5Xugqq.vorZszoIS", false, new DateTime(2023, 4, 3, 12, 25, 12, 115, DateTimeKind.Local).AddTicks(1706), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("89a8b7fc-a865-48c1-9ca9-f70c3e9f569f"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$UeFp.7hokxGKPm7YFbU4c.hlV9CCWjsNq9QizkZGIrwcgrvultZxG", false, new DateTime(2023, 4, 3, 12, 25, 13, 269, DateTimeKind.Local).AddTicks(9835), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("8f927138-f979-41fa-a185-7b1e5c8d0153"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$KbK174kzd/FktBifSl8QHO8tRPCQAJGV2d0ayQDOOh40xUtduGqi2", false, new DateTime(2023, 4, 3, 12, 25, 18, 943, DateTimeKind.Local).AddTicks(6810), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("8f92ab11-b77e-4d6b-b31f-918f1a24a7a6"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$3j5Q.UOZnBioNVt4crSqT.fCZCWI41zEFk7iHvF1iNS77x/kMtQmy", false, new DateTime(2023, 4, 3, 12, 25, 17, 569, DateTimeKind.Local).AddTicks(4172), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("91fa7033-9326-499a-b55c-342e1944f3b4"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$6qotesyyIQfmsVm13qhhVuVigLZteUUr2PEvq9h40m1nMxar6Hvv2", false, new DateTime(2023, 4, 3, 12, 25, 14, 861, DateTimeKind.Local).AddTicks(7685), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("9247df3b-61e8-4d4c-99cd-d991917b7a50"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$hCnJuaeFreryzGaCRMxtpOpODZDEwdZb93H9LH9Zt1WSCdWRmWZ.y", false, new DateTime(2023, 4, 3, 12, 25, 14, 578, DateTimeKind.Local).AddTicks(4942), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("97ff61d5-9d3f-491f-a894-961a540c4316"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$hNMqi5Ya/RFLYFDUT8jV..nwA8jfPMlN5qTDwD65ANxVMKLCamD3G", false, new DateTime(2023, 4, 3, 12, 25, 17, 947, DateTimeKind.Local).AddTicks(5404), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("9805925c-6e51-488e-8316-5c753368e747"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$oJfasu9qzJFOg6tFuazFJOJgO51XPZIvO1ZpJnzoirQTlpHdbdKG.", false, new DateTime(2023, 4, 3, 12, 25, 13, 98, DateTimeKind.Local).AddTicks(6769), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("9bbd05a3-c679-46d7-bce4-d7012f501621"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$e5dE4.avH.y3iwLIW5A75uiJg6SWh8iqVn/A3QFp38sW8nN/1a6Ji", false, new DateTime(2023, 4, 3, 12, 25, 18, 684, DateTimeKind.Local).AddTicks(9244), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("9f09ccfb-4fbb-434e-9487-1af3581371e4"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$vYD1uLOCHy6ZWZYmOYdLiey.h07pUXIC6wqgsUxkZqo6XkmzQXx4i", false, new DateTime(2023, 4, 3, 12, 25, 14, 0, DateTimeKind.Local).AddTicks(8441), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("a1630255-1427-409c-a843-49f7249ec856"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$UeFSULFspPEF08MU7w30muHcyHExohBPccP/KyaV9JMZVTVOHWpTu", false, new DateTime(2023, 4, 3, 12, 25, 10, 899, DateTimeKind.Local).AddTicks(6445), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("ab3a5ee5-7c33-4f26-a00c-f1d81dbf54f9"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$/8506c/DAE0D8SLsXacW7usNy6yJQpTJx8ycx6K8omfyFwSKEFfDm", false, new DateTime(2023, 4, 3, 12, 25, 13, 183, DateTimeKind.Local).AddTicks(5851), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("af73f4e3-8938-4aca-8737-88c9fa23fec0"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$xHF2WDoJGF7Ejw99s.5PZOc1TZJFvIFoQWoQSrkvhbsELG0g9DIiy", false, new DateTime(2023, 4, 3, 12, 25, 14, 377, DateTimeKind.Local).AddTicks(5273), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("af8c11e3-d9ea-4c4a-8010-2788ac0318ce"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$pHe5v83TvieNS9uYF4VwXuxNXrh3tJ1T5qQQOHaioLBlsgeFm3CnO", false, new DateTime(2023, 4, 3, 12, 25, 16, 947, DateTimeKind.Local).AddTicks(7816), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("b1164c6e-bd48-485e-b4b0-1b481e174193"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$WayTXRC0X.4FWzt089elVeyX5Vpcfvsd/hJupOWBa6sEnvR.EtKSe", false, new DateTime(2023, 4, 3, 12, 25, 9, 165, DateTimeKind.Local).AddTicks(4055), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("b258a8df-d124-46cc-9b22-3b2543c7465a"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$80SM95idtps.7zwyMmY5B.W0heSKtl1wQ95.kEE/9Vuwv6gTTnsB2", false, new DateTime(2023, 4, 3, 12, 25, 10, 393, DateTimeKind.Local).AddTicks(6481), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("b6d2b153-b17e-41ec-91c2-c3e44a06b551"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$aEg2UDH1BW8aIBebN6V9HOWsQw9iMAforOrHDbAT.qYijoVLWxPjW", false, new DateTime(2023, 4, 3, 12, 25, 11, 686, DateTimeKind.Local).AddTicks(180), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("bfe399b7-181b-475f-83f9-eab0291c1b5d"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$qL9WddLOiP2tTJWfAO7TCeIQ8H2UMfD86iYgMgdat9uEWwsfwOJfK", false, new DateTime(2023, 4, 3, 12, 25, 13, 489, DateTimeKind.Local).AddTicks(9063), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("c06462a5-7c8d-4adf-8809-91074994b505"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$q9mAmFyuIWN.0cZe6MhB/Ox7dAtk5lCpAbYIqUMW3d6yeUWYoA4J2", false, new DateTime(2023, 4, 3, 12, 25, 18, 179, DateTimeKind.Local).AddTicks(2829), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("c2153309-3bf2-4f9e-9b88-05c919bbc5de"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$9J1mZTOClKmg7sr9Z/Nq8.Uym4mn3/3UeeID4/9r/ukoMcQIj8rsG", false, new DateTime(2023, 4, 3, 12, 25, 10, 807, DateTimeKind.Local).AddTicks(8739), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("c6cbc359-3626-43b1-b09c-ca423539ad00"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$oEJcfXjBnNz1rtvQWdueROahmYMOhDABUg09Z6OamAn8J0wWv.fYK", false, new DateTime(2023, 4, 3, 12, 25, 9, 920, DateTimeKind.Local).AddTicks(6489), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("c7b35960-071f-4560-b78c-a0cc3c2451d1"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$QpPA5pi5rJ.6PBdJfSImEeMpVJrRLnWPDZ//QeYO.TI7Z2FyoLO7.", false, new DateTime(2023, 4, 3, 12, 25, 11, 424, DateTimeKind.Local).AddTicks(2230), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("ccaabf67-360e-449c-ad4a-700381313840"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$/axnu5CnricmjRsAJVpGaeY5Y1Mmg42SQyNkrkxs5CZu3AJF3.bNW", false, new DateTime(2023, 4, 3, 12, 25, 9, 81, DateTimeKind.Local).AddTicks(1341), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("cedcb164-b8d9-46b1-8c2e-54d708116a9b"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$6az/omFA5BXniLkdglP9ROWXyzBR39.smcs9LVS/iRJL08czoF1fG", false, new DateTime(2023, 4, 3, 12, 25, 11, 249, DateTimeKind.Local).AddTicks(9605), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("d05c3146-bbf6-45bc-9526-16d7e656b0f7"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$4aAPytbP7m5TSZVD6TxfWODTeD3KuNo.KgW6VrCYtZ3b7pNJdnfG2", false, new DateTime(2023, 4, 3, 12, 25, 7, 834, DateTimeKind.Local).AddTicks(3942), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("d0b0568f-d265-4a7f-81bf-945c7af6e2a9"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$6vxOhXSHyCFWFy6Bqm31leTlxr9z2BEq6JZxXNsM71tpSJFu3FZ1C", false, new DateTime(2023, 4, 3, 12, 25, 9, 334, DateTimeKind.Local).AddTicks(1546), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("d12ab538-3388-4fbf-874b-896ad5925c0e"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$cdA5IoZE0s8XbiJtBfMsCuGzwKq6Uw1a0LiMLq0V5RETbJJRYVTAy", false, new DateTime(2023, 4, 3, 12, 25, 8, 737, DateTimeKind.Local).AddTicks(3216), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("d4cdd1dd-761b-424c-a77c-8c61e4c2879d"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$IGgi5K8LIDMpbp0.U2JQ.O1bpylrlBomHPNI9R9AK4LfocpsqtTPO", false, new DateTime(2023, 4, 3, 12, 25, 16, 124, DateTimeKind.Local).AddTicks(2950), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("d88016c0-edee-4eb8-8d0d-9bd8cba14a9a"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$8xN7xuXmn02OnM9Mz5oVAeSxraXWiQ/Diik/GJKyy/plm4h8eB5OG", false, new DateTime(2023, 4, 3, 12, 25, 13, 828, DateTimeKind.Local).AddTicks(4536), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("dab0beaa-c91f-4892-8e4a-910b07c0f8a9"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$JidENZisHzKpR3iNZl.RxutH9zdpX2xMcfmHRMd/XMU.GUQ1ksBHm", false, new DateTime(2023, 4, 3, 12, 25, 16, 40, DateTimeKind.Local).AddTicks(453), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("daeaac8b-a7c7-40f2-a720-905379ab57ce"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$uq2pJ.WkJqGVcldHX.hhD.dstJWU.dw3RrBeUC05gReDbdicFY11y", false, new DateTime(2023, 4, 3, 12, 25, 11, 772, DateTimeKind.Local).AddTicks(3386), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("dccc3596-fd5c-4e8e-a434-3f7b389f4fd1"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$so8FJGKok/K6WHuiWgGwsOGlOqUlWEaz/Kwml7d6M/rNzr3MsySGW", false, new DateTime(2023, 4, 3, 12, 25, 14, 86, DateTimeKind.Local).AddTicks(7809), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("df23b55d-91fa-4c79-982b-256596bd1b53"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$hWGwjuMrCjAWnSyoU4429uPHda3UvtFxbp6Yv0i0.xfCyE0ZSQAXO", false, new DateTime(2023, 4, 3, 12, 25, 9, 249, DateTimeKind.Local).AddTicks(237), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("df28bfa9-7079-40a8-a0f8-1e2e7d26a641"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$J86kzsHzrNMLmrzh7DUSX.6II35zVkWgFKjiLUlOj5TKxNAaP185q", false, new DateTime(2023, 4, 3, 12, 25, 11, 76, DateTimeKind.Local).AddTicks(9077), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("e1fe5eae-9450-479c-8513-e31d7c2b3532"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$63c70KyGYgsh3xBSxQ1NZe525v8UHUJvMvq0vvK3AZG4mCilZOx/y", false, new DateTime(2023, 4, 3, 12, 25, 12, 927, DateTimeKind.Local).AddTicks(8616), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("e229d183-671b-4dae-b017-7e88c5a40a6e"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$3IUnwo3tKAx4pRNLSYzoBuSC3uoNLCvdXAOGwsDZxPPEqhO3degGm", false, new DateTime(2023, 4, 3, 12, 25, 13, 656, DateTimeKind.Local).AddTicks(5896), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("e8716659-f024-4181-9322-c61f7da4b748"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$Gov3qTq8OURgtbkLpvWQrecfUs/LJgHnVE23UcZswAY2MZj.19s5a", false, new DateTime(2023, 4, 3, 12, 25, 8, 911, DateTimeKind.Local).AddTicks(8451), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("f131243b-b557-4b48-8ba8-61f956ab38a0"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$7K1xWX1ao4gQctI0jnaQCukh/WaU6naBWhBToRl3QLUQdKB8ntRky", false, new DateTime(2023, 4, 3, 12, 25, 8, 996, DateTimeKind.Local).AddTicks(8040), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("f288756f-081b-4562-a52b-f53d0d0e78b6"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$snCqmezQ2oxYCDZQcHVXoufSHvD7/CuhRVg0Y7IDoXkHKqgvVdFDG", false, new DateTime(2023, 4, 3, 12, 25, 13, 356, DateTimeKind.Local).AddTicks(1796), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("f2ad3905-2fd7-4ae5-a0c1-dfda97c827b8"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$/9UYeBeUkgV9MbwZZOf6QuiUI91Qi80HOphzjiiaU1hTDCrPboFQa", false, new DateTime(2023, 4, 3, 12, 25, 16, 208, DateTimeKind.Local).AddTicks(2975), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("f303a58b-9702-41b6-866a-c2b8b2c7fa5f"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$xlxE3/cjrPV1Q.h/GBmFVeuTZxdE4xXN7SJg5mq0hvogg04Rr3kHS", false, new DateTime(2023, 4, 3, 12, 25, 9, 624, DateTimeKind.Local).AddTicks(5802), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("f3d916c1-90ae-4d39-b3c7-d1d09b66aadc"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$2ZUMjbLLzPd9DNEPMwYm2uVoc.EauVErHiSfO9yJ.4cHXKxll8UuK", false, new DateTime(2023, 4, 3, 12, 25, 8, 129, DateTimeKind.Local).AddTicks(4777), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("f65e8f70-0976-45f8-a3c7-13edf0c7161b"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$f5PDIf2/E6qfdAw9dhb6fu/4mjF4ax9Vtyb8sjLsyjPVzTnrU5qg6", false, new DateTime(2023, 4, 3, 12, 25, 10, 33, DateTimeKind.Local).AddTicks(8545), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("f6bc4b22-af21-4949-997d-a8dc4cf77815"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$sRnT0lmOmcvl3DGOIjny8uEFtFifVWusUfoSk4UHN/7/1FVclcqAi", false, new DateTime(2023, 4, 3, 12, 25, 12, 213, DateTimeKind.Local).AddTicks(9980), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("fc59a944-e31b-4791-930e-0eba7af06f78"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$juz.kfODn.U/bOwMqyEMUeqvR.8gBxmo.YEmQ4/7wIewDP/KaZ5ke", false, new DateTime(2023, 4, 3, 12, 25, 14, 468, DateTimeKind.Local).AddTicks(4920), "Webling", null, null, "0390471753", 2, "bwebling1s" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("09583c37-6d8c-4487-bdcd-3c4df85bb51b"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("24514283-8d21-4550-9d6f-cfeb5716c5e5"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("4b5214a8-044a-43ef-98e9-43cba23b5ea1"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("844bc9c7-fc72-48a3-9a28-686c8760b63a"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("9c888cff-e135-4d4a-a4a5-73036aa15e3b"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("d8648d76-d3e4-4250-a585-c53ef5d91c56"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("262cb4dc-97ce-441a-bcd1-c102c55d1704"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("aa1263b5-a98e-4479-95f7-8767acc08f8f"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("f3ba3d8c-469b-4c4c-b318-186bc903cacd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("03e0d88d-eeda-4ccb-9c29-7448bbb63ef3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("04dabb36-aa17-46d2-9b9a-8b3fc67448e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("071a32fb-c9e0-4bf1-bc14-74ffcacd0c5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("07972fbc-e619-4921-9cb5-f8a38cea54b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("08e98864-98d3-45b3-8a0f-0e5c42928707"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0961ebc6-1a08-4c9b-84c6-57f3701ffe4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0d82f234-b849-4357-a981-b5d7aee5e091"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1070fc9e-2735-4bbc-bbff-ec4727bb09fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("11528182-c13c-40d4-9523-270552a264bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("16b58086-333d-4450-be72-bf552e7e8417"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("16d25e37-cfd6-433f-9741-842141561b40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("174685be-0384-4024-9a6b-e0e67e54c891"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17a28b5a-3eba-4f8e-b281-3bf367db6c9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17f13939-cf69-4540-ad29-e9dc1bd12cd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("187af0d5-8956-465e-af07-e3cf56c39e6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("19834e9f-0ac4-44ec-ba80-1350adc309f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b81fb20-cad7-42e9-a95c-3111565015ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1cff0e16-51cd-4918-8bb5-7b73234abb42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1d2cbbe2-d9b5-4edc-b980-286b9275da2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1e22ab99-8126-436a-8e70-22a22c631d37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1ec1c2ba-e9db-4f4f-a74b-9fd7f8b29967"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("21f5d62d-0208-473b-b39d-1f3cbffe7325"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("262ab8fa-25de-4e9e-adea-c34a010af00a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("26f8cc94-d3d9-4cac-8e7c-c40a5086ee2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("270248bd-737e-436a-84cc-cfdd5197b1d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2a6b5cc9-fc3b-4b18-9b2f-5c0e995b2043"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2b6baecb-956f-4721-8e36-3b96a494c552"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2c75f431-06fd-4716-bde7-00799f27c828"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2cdc963c-4426-4380-b317-bf88b7225b8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2e803f61-3a81-49d7-b4a7-b4012dce5f58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("38236c18-8a93-4b4d-9750-5db163b88faa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3d8a07a3-ecef-42d2-b52c-9b71470345d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4147ea02-bf11-4a70-8717-2d6f8c653386"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("44dba8a9-cfb4-4520-ad48-f061ad8a105f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("44eb25bf-c115-4f77-9da8-e01cb0bf361b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4523280a-f32b-4fca-91b7-777586930e00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("487997e4-f8dc-4ffb-8755-c3bbfad2a5f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4acf3193-fa3e-4443-b1f9-84cda9a31fa4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("544c20d4-36a1-4640-a7ed-bb253744a7b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5676e3b0-8277-4cfa-8584-dd3c8fb1321a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("57a6426a-d762-474f-94da-a5686625c8de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("57b698cf-bae8-45b8-b6fc-2bd438be2208"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("57d26f89-72fb-4279-b5bc-85edf72df0a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("588a09a4-6c58-4386-9021-a05d5d0ff8ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("591a4906-c836-4fd7-900b-593773433cb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5d41cf58-7904-4a17-b9e6-466fedcab525"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6203cad0-9fb4-4697-a355-050af6fde6bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62bcd66d-c6d9-4520-adf9-b35448f9298c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6338c626-d523-4d6d-848a-120ba4ba81a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("649553a6-ffcf-49a4-a6f8-60be4e2ace69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("64bd5548-1ea0-40dd-a991-7854f44eafdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6746c0ad-2ea0-4c4b-92cd-6b797f226e50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("692bf3c8-0d92-45d2-8da3-44ad760bb0db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6b8bbea5-3f4d-4b93-93e6-3fccc73ccb7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6fc95508-d1eb-4150-aa30-6428d9514970"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("720b7a91-adaf-4031-ac3d-bb2b79c082aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("723e1c70-544f-4580-983f-eda57958b73d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("73cd0415-4b03-4d27-8a46-dfb65d2e88df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74cd02f9-b072-446e-937c-2f3efbe55a83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("792e5fab-7d3b-4293-b040-ccfab35518e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7cfafaa9-fa72-4e6f-8889-a56bd994f289"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d7fe8bf-e45e-4f13-9c32-4722c600d6f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7f14773c-a18f-4904-8f8e-9eb8ad6aad20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7f6c08d2-dd01-4180-a22a-9b923e8fd2b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7fb7c1a7-2ec0-4e76-9519-43ebeca6ac45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("81d4f01f-1d6d-4de8-abad-50e9348ed1f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("821bff10-4c9b-4752-b6ca-90c509aa7a9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8385f317-6365-4ff1-983c-ecc1f9102539"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83aabb06-6c0a-4387-8183-759ae2e378da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8746125e-301d-4836-8913-301341a89db8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("89a8b7fc-a865-48c1-9ca9-f70c3e9f569f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8f927138-f979-41fa-a185-7b1e5c8d0153"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8f92ab11-b77e-4d6b-b31f-918f1a24a7a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("91fa7033-9326-499a-b55c-342e1944f3b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9247df3b-61e8-4d4c-99cd-d991917b7a50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("97ff61d5-9d3f-491f-a894-961a540c4316"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9805925c-6e51-488e-8316-5c753368e747"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9bbd05a3-c679-46d7-bce4-d7012f501621"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f09ccfb-4fbb-434e-9487-1af3581371e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a1630255-1427-409c-a843-49f7249ec856"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab3a5ee5-7c33-4f26-a00c-f1d81dbf54f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("af73f4e3-8938-4aca-8737-88c9fa23fec0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("af8c11e3-d9ea-4c4a-8010-2788ac0318ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1164c6e-bd48-485e-b4b0-1b481e174193"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b258a8df-d124-46cc-9b22-3b2543c7465a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b6d2b153-b17e-41ec-91c2-c3e44a06b551"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bfe399b7-181b-475f-83f9-eab0291c1b5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c06462a5-7c8d-4adf-8809-91074994b505"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c2153309-3bf2-4f9e-9b88-05c919bbc5de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c6cbc359-3626-43b1-b09c-ca423539ad00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7b35960-071f-4560-b78c-a0cc3c2451d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ccaabf67-360e-449c-ad4a-700381313840"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cedcb164-b8d9-46b1-8c2e-54d708116a9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d05c3146-bbf6-45bc-9526-16d7e656b0f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d0b0568f-d265-4a7f-81bf-945c7af6e2a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d12ab538-3388-4fbf-874b-896ad5925c0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d4cdd1dd-761b-424c-a77c-8c61e4c2879d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d88016c0-edee-4eb8-8d0d-9bd8cba14a9a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dab0beaa-c91f-4892-8e4a-910b07c0f8a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("daeaac8b-a7c7-40f2-a720-905379ab57ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dccc3596-fd5c-4e8e-a434-3f7b389f4fd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("df23b55d-91fa-4c79-982b-256596bd1b53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("df28bfa9-7079-40a8-a0f8-1e2e7d26a641"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e1fe5eae-9450-479c-8513-e31d7c2b3532"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e229d183-671b-4dae-b017-7e88c5a40a6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e8716659-f024-4181-9322-c61f7da4b748"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f131243b-b557-4b48-8ba8-61f956ab38a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f288756f-081b-4562-a52b-f53d0d0e78b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f2ad3905-2fd7-4ae5-a0c1-dfda97c827b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f303a58b-9702-41b6-866a-c2b8b2c7fa5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3d916c1-90ae-4d39-b3c7-d1d09b66aadc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f65e8f70-0976-45f8-a3c7-13edf0c7161b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f6bc4b22-af21-4949-997d-a8dc4cf77815"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fc59a944-e31b-4791-930e-0eba7af06f78"));

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0099045a-a32f-4e7e-8a31-01602f145460"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("57af7173-8268-467e-bb67-c0d64fe9b21c"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("ac2d4a7d-2372-42bc-badb-e84dd6652cfa"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("b0ebbd50-deab-45cd-84c7-1bff5501e95a"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("b5500fb3-1927-405a-b8d4-36ae7e55d914"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("f751c094-ff1b-4c2d-9ef4-68389d544f21"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("2fcc6c82-6c00-43eb-855c-766bb6bf3f1d"), "Half Year", new DateTime(2023, 4, 3, 8, 44, 56, 238, DateTimeKind.Local).AddTicks(9018), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b257a55-6a35-48b1-ae78-71343b8176b4"), "1 Year", new DateTime(2023, 4, 3, 8, 44, 56, 238, DateTimeKind.Local).AddTicks(9020), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc1393ac-0e9f-48ba-b3c0-12ca169ea14c"), "Short time", new DateTime(2023, 4, 3, 8, 44, 56, 238, DateTimeKind.Local).AddTicks(9012), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01539818-dd4f-4a62-ba7c-24aba9c30262"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$2QJ4IFxqqVGUW1W/rvc2Sef56O5g.VUsJl8DBVwHxbounvsjG0xMy", false, new DateTime(2023, 4, 3, 8, 44, 46, 759, DateTimeKind.Local).AddTicks(8702), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("0243bf79-4776-4adc-8b5b-56d5e78af683"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$lIKjJdT7p3FueMR.U2eWAOIaNN8MvVN3zDlKENVoopI6g1I3a7Xli", false, new DateTime(2023, 4, 3, 8, 44, 53, 676, DateTimeKind.Local).AddTicks(6244), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("034158b4-3c9c-45af-82b3-b7aa57e84d6c"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$zt73ezku/O2OjXPLm6ueGuomqcyjSUX4tth6r7ijbt40td1IeU5cO", false, new DateTime(2023, 4, 3, 8, 44, 45, 631, DateTimeKind.Local).AddTicks(4235), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("035449e1-5990-49e1-8485-47ac839d7728"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$zdMdObspPI3pWmy3psEZSuTLgszTw92cdK2KJrLdGXgYcOhE0mkx.", false, new DateTime(2023, 4, 3, 8, 44, 44, 2, DateTimeKind.Local).AddTicks(3694), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("03f1f1dc-615b-451e-a267-31f2b0f8d5aa"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$0wm2ym5U14BJVv360HMfvu3j5pP0nKvu4MssoP27X1LZIhMBKC19.", false, new DateTime(2023, 4, 3, 8, 44, 48, 608, DateTimeKind.Local).AddTicks(3068), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("04a89a22-4d7d-48bd-8f69-14541cfdd644"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$WaQFpHpyHVHBI2aXcs9M7eRDHhP3weEf.eOUzuSn.NYTrdq.GCB0y", false, new DateTime(2023, 4, 3, 8, 44, 53, 157, DateTimeKind.Local).AddTicks(6058), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("05e1b528-6a56-42bd-ad2a-ed4754165863"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$E8zm8WVBPi9EvEGn9a6HGuLaPsre4Z7L3itT0.S.9tYc/rVW/cnmW", false, new DateTime(2023, 4, 3, 8, 44, 50, 46, DateTimeKind.Local).AddTicks(2505), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("0762ca48-84e4-4ab7-ac89-2a632eda8069"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$hTyLNvGkY.O.queblXS7ieA6HrfklC1vCpoi9urG3JkJXpQ.IJs6y", false, new DateTime(2023, 4, 3, 8, 44, 45, 43, DateTimeKind.Local).AddTicks(4462), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("083daa44-a053-468c-839c-a64b46fdfe9d"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$0aQd5e2qZVmktU5W9er6eOM4wOqRe4ru.TxqMeeFQ.u4qOW0Qfp/u", false, new DateTime(2023, 4, 3, 8, 44, 44, 785, DateTimeKind.Local).AddTicks(5630), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("0992bd70-7669-40f8-90d6-e6c5fb3504fe"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$F/Yi.GIrb.0oVa9fE41U9OK59YjUozMYYtqVeEYfJUMmg5FiAguSy", false, new DateTime(2023, 4, 3, 8, 44, 43, 304, DateTimeKind.Local).AddTicks(6423), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("0afde098-0a56-4130-a40b-36372ded8215"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$vPIFcLFZbFDqlcY4rqy6aesxFQzNb4390HpwBSrDu0Zg2mdghPPzi", false, new DateTime(2023, 4, 3, 8, 44, 49, 46, DateTimeKind.Local).AddTicks(7412), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("0bbb64d5-1848-4f70-b37b-039e6ee16600"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$nAwT0sJKO3hilk1wpLLo7eLAGP64LijLF7Cht18iyhYSetcHWQb0.", false, new DateTime(2023, 4, 3, 8, 44, 43, 590, DateTimeKind.Local).AddTicks(6387), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("12c5cdf3-edea-4782-87e3-f5eb9bdff6d8"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$lsCWPOvSKSodUtmXNPlpoehtaTGq5WQIhT6X90lFSXU2gw1USjqUq", false, new DateTime(2023, 4, 3, 8, 44, 50, 340, DateTimeKind.Local).AddTicks(7044), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("17651456-6edc-4204-b635-31e159d03546"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$f41uolWTV//gD6ZqBpcHkON.AibfSJDacUCJCkIqh7.COjjutVuh6", false, new DateTime(2023, 4, 3, 8, 44, 54, 597, DateTimeKind.Local).AddTicks(5819), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("17a3c8e1-8c6a-49d7-a550-b7a339d26089"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$ohoH3FmmVEfDGpNSiDzYpOo.RJud67oTYCIpCHbhmPOY3ygmotARy", false, new DateTime(2023, 4, 3, 8, 44, 48, 706, DateTimeKind.Local).AddTicks(6974), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("19c72691-6c5c-4b03-9633-99d56bfd0321"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$sbv0lor17YX/mmAPud8QXuBkDAC4k3DDeYfmWZVjyK1N34CalVZWC", false, new DateTime(2023, 4, 3, 8, 44, 48, 819, DateTimeKind.Local).AddTicks(8528), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("1a0484ab-f3e1-44d0-b3a6-df120f698c9d"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$bFyFioUvxuBl2fLC15iIwexvrTymF.dw9PI2YqqN3uvKWWLU5ihQi", false, new DateTime(2023, 4, 3, 8, 44, 46, 339, DateTimeKind.Local).AddTicks(2200), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("1aadfdea-18f4-4222-819d-ee99b83446fe"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$TY.99K.iU6..Z2o.B3WPkODYHuLG8zZtYXbtOjYlPjBT2/Ruyrw1u", false, new DateTime(2023, 4, 3, 8, 44, 47, 656, DateTimeKind.Local).AddTicks(928), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("20440839-e2e8-473b-947f-70347c65fe0c"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$JkuM9Zg5SUxH330zkF3kz.UHcbn7X1EMPLJpVJnirXlOUMa4HkrrK", false, new DateTime(2023, 4, 3, 8, 44, 54, 807, DateTimeKind.Local).AddTicks(6553), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("21c72b12-2436-48b3-af18-795d42ea2947"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$ShLxBN4a/ncqWBcNOE2y5eiNB2SdNpalzPEU8cRFTY1uEXgefbeAe", false, new DateTime(2023, 4, 3, 8, 44, 53, 25, DateTimeKind.Local).AddTicks(1879), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("2200d21d-a795-479a-8fae-0222cf2e579b"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$JgzzCjQFHY2wF1YImnVx4.gzGWCLjDWPgiroDx2gkysaPFhDs6iDa", false, new DateTime(2023, 4, 3, 8, 44, 48, 922, DateTimeKind.Local).AddTicks(8312), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("2570ff72-01a9-49a0-9ac2-4af522b9976f"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$W2VRHOva.ZvPwduo7hEGnOABhns/Fw6RfhohnCfJQ4r.7rbkQCMZC", false, new DateTime(2023, 4, 3, 8, 44, 54, 146, DateTimeKind.Local).AddTicks(9992), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("276d3658-af87-4918-8974-f556bffc0590"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$muYFAD4c6OdTrgn6ikWFmOk60KUSPeKM4ZsK/vf7uZzGf9bZ.TLYq", false, new DateTime(2023, 4, 3, 8, 44, 50, 194, DateTimeKind.Local).AddTicks(5179), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("28dfeab2-b98c-4469-b058-686adb4feb64"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$0Uga8tRwTYLId/TBw5/JFOUX35ASVvF31BQ1hW/VqQPFMt3wItYFS", false, new DateTime(2023, 4, 3, 8, 44, 43, 880, DateTimeKind.Local).AddTicks(7173), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("2d39c9c3-f6a7-4aa0-ada3-38857e632a55"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$9Tt/ZSY7agv9paT69lHhAuBkrviViVeaYzCYYklZdPqE3CJWtWTve", false, new DateTime(2023, 4, 3, 8, 44, 52, 781, DateTimeKind.Local).AddTicks(5001), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("2fb76a09-ae6b-424b-9afc-a9a471e8f043"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$XQ73ypQx7cdr5Jriy5FIz.hZn34LmL0aJz.sfTTxhOIuM/VZ9LkzG", false, new DateTime(2023, 4, 3, 8, 44, 55, 456, DateTimeKind.Local).AddTicks(2374), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("3178f9ca-80cb-45a2-af60-bcaddac79960"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$HTr.0n9fzZJKrRVuaalcLuuDAlBvh/7PnKxkFPEgkKQ2gunQ47HMK", false, new DateTime(2023, 4, 3, 8, 44, 49, 156, DateTimeKind.Local).AddTicks(545), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("31a192f6-b07d-4296-9cde-120b626031b4"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$cdMJAWBGEKNQ8vGXoApzUutEPbQ8JlVG94NBHFFvSeaACXC.6nASe", false, new DateTime(2023, 4, 3, 8, 44, 45, 158, DateTimeKind.Local).AddTicks(3178), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("31b77618-cb01-4e9f-a755-edc84954e71a"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$rvuDLLllQk.MEBF/OR.KOOXt5D/Y6Rb1v7XKNlPMfcRC1rAM2doOS", false, new DateTime(2023, 4, 3, 8, 44, 45, 783, DateTimeKind.Local).AddTicks(9720), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("331d9deb-ba18-48e0-8792-30e221d3767d"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$FqV7DR7iNL/O.gnQNLQpkeVh8bXLk12tXcyULmx.CcU8mP5FQm.HK", false, new DateTime(2023, 4, 3, 8, 44, 48, 244, DateTimeKind.Local).AddTicks(833), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("34631a6a-1ba8-43ef-851f-fb90f3219df7"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$ksrbrOunk93KL5HU1u2/cOjY9Lsclh0BzTHOnNgiTF.oqGAiU1DjW", false, new DateTime(2023, 4, 3, 8, 44, 54, 481, DateTimeKind.Local).AddTicks(8273), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("34b82da9-6660-490d-be64-5eb06e46e935"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$Che47B11gfVQ/zzcZyS43.aMXFF5upPGx0V1sB53FxERETW3UZnOS", false, new DateTime(2023, 4, 3, 8, 44, 54, 16, DateTimeKind.Local).AddTicks(4326), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("35c62e00-a694-45b0-a264-9d61d46c947e"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$iYOP9ASDdeJc.3E8AkEwdeHS0SS8HONWya2ODCBn8On2Yic5mVmz.", false, new DateTime(2023, 4, 3, 8, 44, 46, 648, DateTimeKind.Local).AddTicks(7156), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("36af18bf-1b2a-4593-b2e2-e599543e5fbb"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$xh5wMZkRMHrcDaYBUp1DLeuME2rt4nMo8Hn.EhZt9KPGpx9NDm0h6", false, new DateTime(2023, 4, 3, 8, 44, 42, 997, DateTimeKind.Local).AddTicks(4164), " Nguyen Van", null, null, "0966416708", -772000, "customer" },
                    { new Guid("38d9c589-4e90-49a9-a8f4-3466aa22390d"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$Vfgblx/uEdgGg5Za/HrRm.tnVzQ0SAKMJ9/mA0i1PIGJNcLnlcDWG", false, new DateTime(2023, 4, 3, 8, 44, 49, 907, DateTimeKind.Local).AddTicks(1963), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("39f8b45a-8e27-4b4a-8b7b-21047262475e"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$dfzO6E1wwO4eA.2CjusVp.fCr3lnhInl7OdjPC425lwB1NT0WdNZ.", false, new DateTime(2023, 4, 3, 8, 44, 53, 785, DateTimeKind.Local).AddTicks(1686), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("3c0075f2-a73c-452a-8080-4dac314deca9"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$V69NVrW77bV6QgLR0RB8XeWr8RQTpfql1A9JvvlMWqednvnU1t7vi", false, new DateTime(2023, 4, 3, 8, 44, 42, 880, DateTimeKind.Local).AddTicks(7922), " Ass min", null, null, "0966416708", -772000, "admin" },
                    { new Guid("4177b460-f2fb-4f89-8fb2-88816f4c3269"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$gxtJy2v8BExe0suNCAySNe2fFlXO3FhjE7qN1IOTlcspWQlAUMzh2", false, new DateTime(2023, 4, 3, 8, 44, 49, 291, DateTimeKind.Local).AddTicks(5369), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("487d9dc6-17ad-4207-8b67-df67e51c13e0"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$HkGDoH47/hwxpl2UUp3oJumhK3Imjh94wiD2aMY2dZdQIZnXfxEla", false, new DateTime(2023, 4, 3, 8, 44, 47, 13, DateTimeKind.Local).AddTicks(4809), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("493f4030-9f5a-47fd-a08b-c715bf0efc6a"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$RtHLPkL3M.zBTkV4hWLQ/Oo46N/b8EscGyx5WGN8viUP5PiLr0nRG", false, new DateTime(2023, 4, 3, 8, 44, 52, 180, DateTimeKind.Local).AddTicks(3093), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("4b497080-6a52-49c3-b632-75f467da0383"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$7APfJjEUP5YptqIrjy0Oce4oDzOtdiWKG7bMdejFbGQHUQSXjcvc6", false, new DateTime(2023, 4, 3, 8, 44, 43, 155, DateTimeKind.Local).AddTicks(407), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("4bae5117-4ebf-4b8a-af8d-18b5104e7ec4"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$Qw2HIpq0RcIjWrGtS/N/fOGgnHbikR7rNEIoABMxDPYl1wxFIaKFC", false, new DateTime(2023, 4, 3, 8, 44, 51, 258, DateTimeKind.Local).AddTicks(1008), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("4f2bf3fd-b37c-474e-a829-41ed21d9ce71"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$XyYuck/Ox7W8L4kUjzEpKOEnTeZ3yRP9QX0MFhzdfhCVowr6Qx6N6", false, new DateTime(2023, 4, 3, 8, 44, 52, 645, DateTimeKind.Local).AddTicks(4589), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("4fafe2c3-afae-4fc2-9915-140dca5daefd"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$OdtmvLPi2tYm0rcdlJZnkOpwEP8JnAMWz1oruFPXp89Ue6QJzJY/m", false, new DateTime(2023, 4, 3, 8, 44, 50, 991, DateTimeKind.Local).AddTicks(4507), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("527b799a-7900-49a1-9816-3129e4ad7ead"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$KWPDxI3xULe4/YLDZXL0seVhSrADr3kcJCqiJHj6g1MFls00cPEWG", false, new DateTime(2023, 4, 3, 8, 44, 55, 153, DateTimeKind.Local).AddTicks(5318), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("5325f594-b66f-4410-b56c-8c81bf6571a0"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$lpgifGyxsA64X6MNnllkBeobhWpEUnni4Y1WEMQI9BVpkDAJz8qL.", false, new DateTime(2023, 4, 3, 8, 44, 51, 362, DateTimeKind.Local).AddTicks(4973), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("5a5b3c71-ab1d-4072-8dfb-5ff748d1ab77"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$Q7wO2V/F6pnjwnXxdqYBb.cdZzOUVZSrjooxg2ZSaGVwPUIWrxDoq", false, new DateTime(2023, 4, 3, 8, 44, 48, 2, DateTimeKind.Local).AddTicks(8042), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("5ab26f10-315b-4ade-8623-c58dc1ed0e88"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$SRZNq/KaPmIep9NMsNo4zOPJYjj6RA4sLwA/tSR.hV0zwQZyiOaAa", false, new DateTime(2023, 4, 3, 8, 44, 51, 131, DateTimeKind.Local).AddTicks(9625), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("5b7f230b-0d06-4f8f-872a-397f97629b66"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$IqpkfrmudU0IeN1bjU237ePVglEd/eRfDIc.CKdGQXvBj6o3moXBS", false, new DateTime(2023, 4, 3, 8, 44, 43, 709, DateTimeKind.Local).AddTicks(7886), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("62b8e36a-4b0f-4719-8f3e-8ec0bdf8f3a3"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$vRF0vfEbgm/iljmDbE1Q/eYqL0b2Muj7JB1Yn9mnVO6uPLoyNiLDq", false, new DateTime(2023, 4, 3, 8, 44, 53, 893, DateTimeKind.Local).AddTicks(5338), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("64a78d09-01fc-4aea-8e49-4d8cf057b6e4"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$wbLXO930UJiAejgcLRxbv.ZON361LHPaQ6F1XVEV/WxA4ygbctVse", false, new DateTime(2023, 4, 3, 8, 44, 47, 763, DateTimeKind.Local).AddTicks(6446), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("6770e215-eac8-4e3c-b5e9-1151a1e7e40d"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$f9kQbH5TW4Q8J.7pqhwOs.0wFBsxcYPRSOS87DApoibVcQtdv9.gi", false, new DateTime(2023, 4, 3, 8, 44, 56, 238, DateTimeKind.Local).AddTicks(8319), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("6aa5d534-7f97-416a-9f86-4084c828550a"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$UGWZ3o0utimkoSlZ4yhTPe.O5HOHb95Mmz7MP8uhuIqWXuvhrdhlu", false, new DateTime(2023, 4, 3, 8, 44, 52, 294, DateTimeKind.Local).AddTicks(6063), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("6afbf6ca-e96e-4ee4-a910-90256b81b078"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$3nxhss4wvx/ZRw3nEnb0g.N1FHOeW5uX6Oe0XWYnbZ7CmTV.PiR4S", false, new DateTime(2023, 4, 3, 8, 44, 53, 278, DateTimeKind.Local).AddTicks(9840), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("6e547c60-30dc-45ed-bab2-0eb8fb33a611"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$W9Jj9j3cpbmVmujXR6fhcOveN1QSRdmePYzJ7AgGYh6U.IJB5B/n2", false, new DateTime(2023, 4, 3, 8, 44, 47, 445, DateTimeKind.Local).AddTicks(9845), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("7321bedd-7b5d-4fb0-bea1-1fa54465d44b"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$rm2l2RkvHHH64/3WNFgVLOYYB2NB4uiXGgKN4ReJR8HMftORUNLS2", false, new DateTime(2023, 4, 3, 8, 44, 50, 763, DateTimeKind.Local).AddTicks(7836), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("74a179fa-88fb-4b52-b0d6-e9a1cc53d656"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$5dBFObig7B8L34ReaQHdL.vdRCUIB/vC/4OFjhsvBiJPhnyzEu6o2", false, new DateTime(2023, 4, 3, 8, 44, 48, 141, DateTimeKind.Local).AddTicks(404), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("74e0656d-a357-4018-96d8-7e91037ffbbf"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$HC7NYkJF3T0v/ZY9baLMJOrngfkzGC5NOuYktVxeeHIeqW5l68YZW", false, new DateTime(2023, 4, 3, 8, 44, 54, 914, DateTimeKind.Local).AddTicks(5478), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("75282bcc-7171-4785-9d2c-854fce5779bd"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$XN86nl8gu8XA6cznEfJ5wuH64s/kJEF9Rz3FVOCXj5v42Xfl1g6mC", false, new DateTime(2023, 4, 3, 8, 44, 56, 143, DateTimeKind.Local).AddTicks(9187), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("760adb58-2cea-4c3e-b675-9daa6893515a"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$ukKdug.FtLnwdMz6A0xFkOWdyB5bQytHLfNZh45fpl.GqrlnPuq5a", false, new DateTime(2023, 4, 3, 8, 44, 44, 926, DateTimeKind.Local).AddTicks(2665), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("7666e789-fe6c-4914-84e9-19cc65492e62"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$tO9pRaOFa81ABdJpz8g5c./Mxu3Bowd3G9R.xhGg1w5JWvwBL0bAq", false, new DateTime(2023, 4, 3, 8, 44, 44, 685, DateTimeKind.Local).AddTicks(2981), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("7799dfe3-2ac7-4920-9edf-36d1630cb8f0"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$U3B3TueMsbYvm.Pk5Q3DU.mcGpukdQ2pn7hRb51IjsOPyMdc.0qZC", false, new DateTime(2023, 4, 3, 8, 44, 55, 683, DateTimeKind.Local).AddTicks(9644), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("7a3d7f48-9a4a-4e35-aaa6-eaaf5a1226d5"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$1uVaXYD5byZuWLo9vs1s1e0EMJgZtGfXDZwe00Kylo1hFYhuShzOW", false, new DateTime(2023, 4, 3, 8, 44, 49, 763, DateTimeKind.Local).AddTicks(9422), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("7cd6d20e-ed52-4ace-b972-d1b38ee1dded"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$mGvkzEJ.1EtDVHPppq8y6u0ittAJQm1aFbzJDC6XU/1tG8HPhCHGu", false, new DateTime(2023, 4, 3, 8, 44, 50, 619, DateTimeKind.Local).AddTicks(7254), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("7d1fd6d3-b555-4264-9aef-a0fd7a52c2c2"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$bbRJ5tlwet5x/a29UlYNkeg2VavP4vMVSe2AqYJhLXoXiKrRFajlm", false, new DateTime(2023, 4, 3, 8, 44, 44, 233, DateTimeKind.Local).AddTicks(4757), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("80b6f457-5943-440d-8dc6-c5f03daf4b55"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$MtX51ldRNIOq84tYy20kd.xBVnt610jwu2f4K09kkSSQDoHNK5pSS", false, new DateTime(2023, 4, 3, 8, 44, 53, 394, DateTimeKind.Local).AddTicks(6680), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("812eecde-d9be-48d1-aefe-2d71aeeafdc6"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$0Z9pwUS2LRgJ7lJI8RBhXuLbMrLYJO.1YpRVmLU6gS6I4tm76s/.O", false, new DateTime(2023, 4, 3, 8, 44, 44, 454, DateTimeKind.Local).AddTicks(447), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("83c825b7-6a8f-49a0-ba45-194aa5df0aa9"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$CYsCrn1IZzHQl7jWipCfBuv6ym.48/oRr5bCBnNGhO0wVL90fJwSG", false, new DateTime(2023, 4, 3, 8, 44, 56, 43, DateTimeKind.Local).AddTicks(349), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("841682eb-99b1-4533-809e-ac0cb1b97162"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$njBNn8JF4W4z5gld6rf1nu9AQxtpWJ0ftUsktInRIEVCQz1GFxEtG", false, new DateTime(2023, 4, 3, 8, 44, 47, 552, DateTimeKind.Local).AddTicks(8013), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("84ea59fb-2c6c-49b4-a611-2a410dfb50a9"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$507L9tRGe425929hiCDkQuvu0mUKgLnqhesPRw0gMlVFpgob1oxFW", false, new DateTime(2023, 4, 3, 8, 44, 50, 883, DateTimeKind.Local).AddTicks(6338), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("898028ad-3c2a-4bc0-ae0e-7b75b60c8ebc"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$Wuu19dOjyRygnDRkB4zWnOHFvPSa1sO1m91mhYzpyVl2gH8kpsv2.", false, new DateTime(2023, 4, 3, 8, 44, 44, 117, DateTimeKind.Local).AddTicks(328), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("89f9f845-84c4-4372-a446-d3ae8cea825d"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$5Tzig7bzU8D2iR4Iktm05etaMiRDV0tai8gib6X2L8VnkrQ5ychce", false, new DateTime(2023, 4, 3, 8, 44, 48, 374, DateTimeKind.Local).AddTicks(9836), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("90bc8607-cb1f-4a19-8192-f19da3cd2e67"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$.wRAtE9LR4IAYOk2YZ7PxOKsymylcN47MiV2SAsCQbnh./FvIcG/m", false, new DateTime(2023, 4, 3, 8, 44, 55, 26, DateTimeKind.Local).AddTicks(4044), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("926b1b6f-9b44-4352-a5b5-9940c5ce1f80"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$pdkPPP8fv71d8nj3jSqcRu3jHm1kKrKG5xCRUfuLoiJn.HV6mKflu", false, new DateTime(2023, 4, 3, 8, 44, 45, 994, DateTimeKind.Local).AddTicks(8944), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("944fa584-2321-4c60-9de5-ea0409864f6a"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$lo2UWFKdSSLeOz9MQSYkO.fCCGEgVb8PKWeTPHbKmmaf9Dc5XFJdW", false, new DateTime(2023, 4, 3, 8, 44, 51, 818, DateTimeKind.Local).AddTicks(7315), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("9a80d06a-752d-48db-a688-189030dda07f"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$KkfUcNCvFQJ48EDl9Ld5NO7ekAYxqafp2vZmzKb9mzMRzeZzHlyY.", false, new DateTime(2023, 4, 3, 8, 44, 51, 604, DateTimeKind.Local).AddTicks(882), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("9b53525a-5cb9-42a7-a893-3da571bffe27"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$IBzi3.6bhVdRfQrwTma8R.HqsROyov1fz6N.WmYYYtsudr8zLapYu", false, new DateTime(2023, 4, 3, 8, 44, 45, 275, DateTimeKind.Local).AddTicks(6117), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("9dac4881-db8b-4a2b-af64-5a49ba17b991"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$DIiauu6SeeF4a05zqa/c4eq4Lx9QNgRZrOD5S9EBuRUUEsLBXLfZq", false, new DateTime(2023, 4, 3, 8, 44, 42, 741, DateTimeKind.Local).AddTicks(8249), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("9dc5883b-61aa-48ef-a661-849c41e3ee9b"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$f5njVNlzAouXqhWTqvnbHeZFU2C5JgbdMHyHvkEopEs6nUBeLd0qq", false, new DateTime(2023, 4, 3, 8, 44, 55, 938, DateTimeKind.Local).AddTicks(7212), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("9f43de80-a5e1-413d-9f84-2c6dd3c63ce1"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$HYE1hjfLgKbttbXRXj2Iqec4WC0XdSpCk8.G0n4TTQZIid7xZv1UC", false, new DateTime(2023, 4, 3, 8, 44, 54, 258, DateTimeKind.Local).AddTicks(445), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("a463fcde-54f9-41bf-abe5-3e4fbf72a470"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$jf0J0qwsk3g8DPP2V4tPXeED9XyJn8QgqOAAEkmp3KLWQ9A6yiM7i", false, new DateTime(2023, 4, 3, 8, 44, 54, 364, DateTimeKind.Local).AddTicks(4090), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("a69411f8-d000-49a7-a68f-6a1c91e291bc"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$W2mpdHFhNVnVsJzm0RxTKuktAZYwNfV3VbnTD8cdP9Upwm.PLyHi2", false, new DateTime(2023, 4, 3, 8, 44, 43, 455, DateTimeKind.Local).AddTicks(6745), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("a92bb3a4-3774-4635-97c4-a5be34d40726"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$FEa1NXCJSnQa7dFuWg1SJePGcUvvY7Lq3ROyDtrwumz/ZII.QCli.", false, new DateTime(2023, 4, 3, 8, 44, 50, 493, DateTimeKind.Local).AddTicks(2127), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("b0bb5422-34d6-444c-8b84-dc396f212663"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$m8LeHljpk1mI2vFEy0Gji.VQuYS.zW8FOTR.7L7V4dOq2bYAkoPPa", false, new DateTime(2023, 4, 3, 8, 44, 52, 520, DateTimeKind.Local).AddTicks(3989), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("b1446209-d26e-485d-9036-fffee3642f98"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$C72gP0Ia3Cd5cMjHIwkKoOV83UJBWSVf3gRNPWlBRfMz9lPkQXtnK", false, new DateTime(2023, 4, 3, 8, 44, 48, 500, DateTimeKind.Local).AddTicks(7556), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("b2a70b15-486f-48cb-9fd7-09aaaa3275b0"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$n52T6dPE5ReojUKmdKeZ7OnGGXr8OtrWqWdWr2p7cIn/JJb9k1oiG", false, new DateTime(2023, 4, 3, 8, 44, 46, 90, DateTimeKind.Local).AddTicks(4309), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("b5886d91-afc1-4d17-b71f-c1fdd0a07f2c"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$fzMYaAHWtlW.izc3XKnDCeeNUxOR/sDGO10a6qmv5j34DQX7ztd.2", false, new DateTime(2023, 4, 3, 8, 44, 55, 256, DateTimeKind.Local).AddTicks(4126), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("b75914cd-49ea-477c-a006-1fdeaeaaaa60"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$c0BBtnZJBmyCLVP5yNPMNe7h1xzvSaYZxPuZ873LF6uG14CvudQ/C", false, new DateTime(2023, 4, 3, 8, 44, 47, 890, DateTimeKind.Local).AddTicks(6426), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("b7cdb0a5-b954-4c7c-8d42-2c542d815188"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$GXP/6lRA/Inv.yGhkzLRIuKKbFkXUblH5kaDsox0ZzGkAGCP2BfqW", false, new DateTime(2023, 4, 3, 8, 44, 52, 916, DateTimeKind.Local).AddTicks(7740), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("bcdd6694-fac0-43da-bde6-39194cc9c01a"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$G7OGm5wtCLquaniaKLYy8eXkIWdf.plwE.1C5PGGHMLmMCpglubQa", false, new DateTime(2023, 4, 3, 8, 44, 47, 231, DateTimeKind.Local).AddTicks(6676), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("bd7f1948-b5e9-403f-a7ab-c947dd757253"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$Dxe6vzqy6pPnpkqrUVup1eC5wS3bq4naw9uzHOdp5hr12SYwlnsOm", false, new DateTime(2023, 4, 3, 8, 44, 46, 209, DateTimeKind.Local).AddTicks(5007), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("c0e68864-0891-474e-af3d-ed807499587a"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$YoewGiGBOzrrB5ioT4aYx.SBgyKE4QEICysEG4ZhCZgA.vBWrFr3W", false, new DateTime(2023, 4, 3, 8, 44, 55, 358, DateTimeKind.Local).AddTicks(3932), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("c4666f5d-d83b-4781-b19b-8d98414cfa2d"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$LNcC8cNrl3ojnHC.vTBuF.nlKgIZXObvnnTDCxWpMfpvYaMOzFtfe", false, new DateTime(2023, 4, 3, 8, 44, 46, 553, DateTimeKind.Local).AddTicks(437), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("c53d67e7-eccd-4694-b322-00ee11419c42"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$EaehvDbUsCZsl0oi7wEfeee9OVh8/lScK.qETDwYQH8XyBsNEDTZy", false, new DateTime(2023, 4, 3, 8, 44, 49, 421, DateTimeKind.Local).AddTicks(4684), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("c74764f4-8fee-4cd2-83db-c7d4bb711f94"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$wpDZ2sqCYZFfOwp71wdTHO40DMv1iE3PedXOuTtzjrnChXXy7E1jW", false, new DateTime(2023, 4, 3, 8, 44, 47, 115, DateTimeKind.Local).AddTicks(5614), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("cce916ab-8c74-4ca2-a716-4227ecb3092e"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$JWPS4a47LAWlu3W/HZUn9eVVvLsyePDq1zjKd47LDQ2/p/qhHxVK.", false, new DateTime(2023, 4, 3, 8, 44, 51, 475, DateTimeKind.Local).AddTicks(6851), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("d3231650-cb7e-43f6-9cf7-2b009acc7ab7"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$jaTGnFB6uV9f2zPUhhSLWex2tUYyTx48iawzs4NaTv/3LXoEHFIcy", false, new DateTime(2023, 4, 3, 8, 44, 49, 534, DateTimeKind.Local).AddTicks(8029), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("d45ebf03-9da3-4124-87ad-c73e2bc7612a"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$s5wAwGHlMJJPrkJxVMq7ZeIlIZkxqmtUgcnsen38JI/nFntZkzGc6", false, new DateTime(2023, 4, 3, 8, 44, 47, 340, DateTimeKind.Local).AddTicks(8623), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("da7d433b-e811-4b39-ac11-eaebbefdbb1d"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$Zc7sg2wllqlT8/xoTQCC9Oe7Wk.X.P30iLVh8x/XfLTeLrBZKEWA.", false, new DateTime(2023, 4, 3, 8, 44, 54, 708, DateTimeKind.Local).AddTicks(6029), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("df1fde54-004e-44e8-bf81-de2faaf07e14"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$cXAQHcZ8FUxYc0xU2kvJous8oNhcqrtK9MDjT5Jei7St5mfUkA9o.", false, new DateTime(2023, 4, 3, 8, 44, 55, 559, DateTimeKind.Local).AddTicks(3100), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("e1877b18-df36-4e59-92f9-4efa49e11a76"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$99ob6r7CePwji0N96cB2g.S77Lrtlm3LAAekeysuleGyd/pUln.De", false, new DateTime(2023, 4, 3, 8, 44, 44, 564, DateTimeKind.Local).AddTicks(5469), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("e363018a-e38d-478e-a366-1bfd9bf2c4bf"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$UmWKHqNcO0xM1Xp9JmKOPeGppPJWZcSdgV6za/hXWiXOm.hEMaCjW", false, new DateTime(2023, 4, 3, 8, 44, 46, 442, DateTimeKind.Local).AddTicks(60), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("e4793e61-f5ea-4917-8fd1-c6fa5235bc73"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$m.35ynDgn2vZVqiqn0.h4OE5J4grrHEeitr3RMFnFef0fjXFwEuYO", false, new DateTime(2023, 4, 3, 8, 44, 45, 891, DateTimeKind.Local).AddTicks(1499), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("e62cead2-64ed-49b0-a984-1fc7eb11e2ff"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$Tk326lzwm3nFTq3Udnk5mOSLmoqLHXKZVbuTvm0sJBViS2r3M4MTm", false, new DateTime(2023, 4, 3, 8, 44, 51, 716, DateTimeKind.Local).AddTicks(8856), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("ee13ac84-d40d-4a08-8ef2-7697258ba555"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$8cH.4gJKO0x7.AFiXUzviOzwpdbDswGbKvE6K8aLHMTsXhU2rZi2i", false, new DateTime(2023, 4, 3, 8, 44, 46, 867, DateTimeKind.Local).AddTicks(9661), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("ee240a02-cdff-46ef-a230-2139a4d04c01"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$CdR7iPj6ckAbdpuVUOdh7uNAJrEpsdLcYt9LeGjLQsMt4sPGQyNfK", false, new DateTime(2023, 4, 3, 8, 44, 49, 657, DateTimeKind.Local).AddTicks(2264), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("f04c5c1d-9ea9-41c4-b6fd-0511344a7f5b"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$/pg1qdeUVteVKjEIMAN3K.kduKtRfPkf4Jouv2Jcl.o0zhH00Ee4u", false, new DateTime(2023, 4, 3, 8, 44, 44, 347, DateTimeKind.Local).AddTicks(7836), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("f39c3c4b-ddb4-40b8-9412-0b58a2771f3d"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$uAehPHNysJBIGLf62tqAm.zYXKeWqs5IqmXezA.XJYvCUqeZVBw0K", false, new DateTime(2023, 4, 3, 8, 44, 45, 382, DateTimeKind.Local).AddTicks(3687), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("f3e10a6a-0bb5-4317-895b-4b7789665207"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$XJxE8LOI/Z/lR.c2aC4.uuwEV2IdN/BQMPa/BAJzrs6nIvfWdvTpu", false, new DateTime(2023, 4, 3, 8, 44, 45, 495, DateTimeKind.Local).AddTicks(4188), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("f593be9f-501d-42c1-a6a9-316abbd1b170"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$FvaaIgsh/T.FOnBfdaa1SOLs8Y9txL30yV0BMGc0IBUb0MXPPAzfG", false, new DateTime(2023, 4, 3, 8, 44, 51, 933, DateTimeKind.Local).AddTicks(6724), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("fb7ed84f-5aca-41e9-8d8c-ef5a4bd6c68e"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$ptRwAtSFNGcMu84R4DIe8elFDThv0bz9dRmL8JUdWoX/Qje3BhZdy", false, new DateTime(2023, 4, 3, 8, 44, 52, 71, DateTimeKind.Local).AddTicks(6801), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("fc82c8b4-af0c-49c0-b5dc-542c618f87a5"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$jP4lQOMqvuSI1v1MAALmrev6GT7lgo6tava1R.Qtxnv77H/Z.WJvC", false, new DateTime(2023, 4, 3, 8, 44, 55, 812, DateTimeKind.Local).AddTicks(8996), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("fd43f104-04a0-45e3-85b7-4bcfd1e5e8c8"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$b9I1xJVoRz7SfndPTLVvH.PvC4Lm16SrbcAl5Tf65w6oRaj9f7DP2", false, new DateTime(2023, 4, 3, 8, 44, 53, 532, DateTimeKind.Local).AddTicks(2369), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("ff89ee6c-7dc5-4ba7-ab8d-0c12530e8177"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$j7GcRg7UMrAbe2aYd.gtR./nKKamg34/Erd6fqLd/4/uzNuHoTyxa", false, new DateTime(2023, 4, 3, 8, 44, 52, 404, DateTimeKind.Local).AddTicks(5317), "Lannen", null, null, "04000508789", 1, "dlannen25" }
                });
        }
    }
}
