using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
