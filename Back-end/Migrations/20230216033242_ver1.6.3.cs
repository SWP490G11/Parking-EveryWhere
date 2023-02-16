using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver163 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetail_TimeFrame_TimeFrameID",
                table: "ParkingDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeFrame_Parkings_ParkingsID",
                table: "TimeFrame");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeFrame_Users_LastModifyByID",
                table: "TimeFrame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeFrame",
                table: "TimeFrame");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("0b777377-1313-4039-910d-ae432cb5d3a2"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("50fb1a58-72a2-447c-975d-ed556940185d"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("54dccc71-e1b3-451f-bfea-d66fa0695061"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("84d5a602-b066-4631-9247-92d09af8d4c1"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("cca3d0eb-6fd5-45a8-852a-f60c182dfef7"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("e4f78d50-f783-415b-9a54-a892ce1d896c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("02906116-86fb-4c34-88ae-de3abdf4dd00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("03f2fc62-f349-45a7-b007-4443ffc2640a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("08ecb841-bb65-4135-867c-17e5572c8307"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0c379b5e-84ae-439b-a60f-29bf68b9a8c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0daa55db-2fd0-4e0c-a650-b45221a98a34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("136876ee-dd47-4d8d-999d-b6dbc8433605"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("165ecc96-9c21-4431-8c1c-a36aede60cda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1af96fde-7bf7-4310-b14d-15d7099dd001"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1fd0fe9e-497c-4155-963c-0c60ee676e04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("211dad79-d064-4a15-845d-1aa6fb240240"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("23bc3d84-dfe4-4afd-8f2f-317d38b4e16f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2b9d54cd-8035-41cb-a786-9f970b21c6db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2dd0b9d7-ea66-487b-8809-ea99dd9b1693"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f05b3f5-2da8-4c08-87a6-1d7ab6fcd4e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("318bbec2-34a8-49ef-abdd-f9e8748ff420"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("32dd4e3e-4e26-4d05-9f09-175e21a2c785"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("35383933-15ab-4586-a8ae-cb437929a1ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("358ece71-f939-4c62-abea-d60815208757"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("39fb4d78-5ee8-4ab7-93be-9ef8ce515f4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("40c57a2d-e944-4a5d-ae4c-f59faac44bda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("441ec007-8afc-4b05-b9c4-e82c9f6d22be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("485758e2-d96b-459a-832a-6d02dec850a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("48958247-55b3-4802-b910-84f28f84ddbf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("49ca803a-2e79-45ff-9fef-b152c5517304"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4a90e61a-ed53-4ecb-a271-25f27dddfd21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4bf5d588-bafa-4869-a595-e5707f2e8b46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4c0f7cea-c4d7-4eb0-87ca-ea63e9dd3e46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4e660ad6-1e81-4521-b659-bedb5de78911"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4e872c17-2017-4c1c-87ef-49ca5b7ea891"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("52c12018-c9f2-4711-81c9-d541588d921b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5722f9cf-59f5-4e40-85cc-aeac731b4ecf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("587ce45f-043f-4c5e-879b-67231a9f5c2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5934e235-a49f-4e5c-ade6-ccbf1b3a4aae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5973e8b2-d2c8-4c44-a4ca-919872ff24be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5b85de45-0ec9-4554-94c9-a50f68fcef53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ccf8f60-5610-4dbf-885f-d5f58256d611"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("68f1f3fa-2bec-4bb6-8f52-a82152182c78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6dee78dc-1628-4dcb-b87e-02f9ead56fdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6e25c107-6c7d-4234-87c3-724c69f538ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f13ba95-5d9e-4de7-9af1-385260e60efc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6fc31e73-047d-4e5a-8a26-6ca2336b1fa8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6ff43d2b-2ec1-4c1b-916b-74c9eda575b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7208f313-4082-4670-a3b2-ebe81e430bd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74961cd5-cafc-436e-806d-2322df9db7bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74b5aaf0-4e35-4521-a1b2-6c594965ac91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7bf53c0a-7886-44c8-9072-1a2a1d83c252"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7da87185-7f1d-4ba5-b23e-e138ac3fa86a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("81c355b2-7fac-425b-a3f4-497d0fea49cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("88ccfbf1-971f-4a61-8d29-2912d8228665"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("89e451c1-abd2-425d-becf-4987ef6e16c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8a31d7fb-7af4-4754-8260-25cbf828765b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8c014a2f-9107-48b7-8e60-7f210ecb1cc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("935dfc3d-abeb-4db8-917b-0bf137ffd5e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("955b56f8-f3d8-4439-8ebe-a48fd0dfe3bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("988ae3f2-24b8-44ac-a942-5bb9ba26288a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("99e1e922-4bc9-441b-8bc3-f4b38d001a9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9a64e129-9e0d-418e-bb71-873da4b03ddc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9e2d691a-349d-4eb5-9e7e-1c4f22619fbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9ed302cc-1017-4615-b37b-0381bbb0ebeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f06d473-060c-457e-be59-f6105edbbd30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a279e05a-44e4-4856-a279-83703a8df19f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a3919699-0459-4865-9d4f-8816d2a3961f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a61a07b9-a084-4d0f-b31f-a824d1eb6eda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a62cd4ca-fbaa-4696-8017-0f2f274f4d19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a8b3383a-0e4e-446d-9756-0cb37aa43409"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a8f05761-3e9a-4a77-b065-b9158cd9ac9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aa447cb6-7fe0-4a17-87c3-a1c85c508588"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aa7abaa5-06ae-43bf-bfdc-1558dd586f4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b22f33e4-9e5d-42e5-8514-dd10516f1a4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b5691c6c-146a-4dfb-8452-bd00fb9403ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b86625ed-c400-4aef-a12b-45243297c698"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b8e67bac-aa93-412d-b9a4-9f683fc4ff0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bb0accf0-810e-4012-b8c3-e1e7c9d4e596"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bc19d216-c98f-4abb-aafe-0a7750ce34e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c0de52ad-db1b-43af-8986-5d763748f956"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c83b643e-8216-4bdf-a3c9-d3fc47792bf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c905bedf-1a91-4766-ae78-5f515b5f31b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cb99d134-6089-4861-8c9d-a57dca5bc9f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cbace887-6e19-454d-a0f6-18abebf4e6fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cc967fa8-b01c-40da-9457-128bacc7677c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d14ab06f-5e91-4ae8-bf91-1169ce0afeb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d1946468-4e96-47f3-8d92-6aed62860456"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d1ddb657-de2f-401c-a71c-d5d62a4485af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d29ea182-bd61-41a8-984c-1b0304ac0a45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d2e5759e-325b-4b8e-8336-6a43dd0f21af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d45c3213-1810-43c3-adf6-dd5c8f911470"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d5418868-93d2-47bf-a737-875d55f0742e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d5d390b5-bcc4-4cc9-a5a1-e7df5ad7a842"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d79ba0a1-b5ff-4804-9d76-154ea5582bf6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d9e192e0-e40c-48a1-b646-993a8f5a9666"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dd9c3305-fb74-4794-99ad-7b1fab7fa80b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e1e9a269-aa0f-4fd9-8aa4-1540c98b7f19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e395f7f3-6be8-4de8-a486-339fca7bc345"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e5a8eec3-6dbf-47d2-a875-9df78ae43302"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e60190a7-b5a6-4ff7-b650-fb4905000853"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e6b9f294-1e5e-472f-b839-cb63450d1c98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e8c641b7-8466-4f77-aa39-b78023428e7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e95a9e77-0a06-4b3b-b503-7e7f86582d38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ea97cfa9-3d18-47f8-8785-59965f5b1832"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ecb7438d-7803-4db4-8f1f-6208e59d9c5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eddac32f-0222-45cc-bf30-cde749ebb00b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eddbd3c5-0ff4-4180-a6f7-80f199b395ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ef3fa92a-759d-40c7-b5da-5f49dec4ccf8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f05a0dfa-743a-485c-8216-6fdf3101797c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f1156cdc-88fd-4f63-91de-aa002e282e0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f25a97e2-3e1b-48a7-9b38-fa7e6883219a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3c145fb-e04c-4046-a76a-56f0a30a7283"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3dcadd5-4216-478a-8bed-3685fa57ecb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa6c5309-75b5-41b3-ad38-1ed4850cda70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa745c30-4924-4d82-9349-b261e1cdf04f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fee67f2a-f9ce-41fe-80bb-90c5f2dcf80f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ffdf50e4-4dc2-41b0-b55f-f301a4cbc420"));

            migrationBuilder.RenameTable(
                name: "TimeFrame",
                newName: "TimeFrames");

            migrationBuilder.RenameIndex(
                name: "IX_TimeFrame_ParkingsID",
                table: "TimeFrames",
                newName: "IX_TimeFrames_ParkingsID");

            migrationBuilder.RenameIndex(
                name: "IX_TimeFrame_LastModifyByID",
                table: "TimeFrames",
                newName: "IX_TimeFrames_LastModifyByID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeFrames",
                table: "TimeFrames",
                column: "ID");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("099e08c0-b9b0-4556-9fd5-94fb6ddb2d03"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("5b823c2b-b06b-4c92-b115-48c8fe2746b8"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("6ad70515-6408-40de-8160-f63a0aba3c7d"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("72be680c-d294-41bf-a411-181688fd0835"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("cc5106fc-12fe-4ac4-b95b-7ab23b8bdb1f"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("cfab174d-de04-4dc8-9774-bc6bf0348a5c"), "Xe 2 khoang", null, null, "Mini", 15000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01036dcd-883c-4198-9abc-2f5792d9e52e"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$fFea1Eocmk24LyrZD39p0e.VKm3GfN18b8TlyFetjp0hhmVxmJi8y", false, new DateTime(2023, 2, 16, 10, 32, 39, 456, DateTimeKind.Local).AddTicks(9245), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("025638e0-60d7-4f51-970f-aa8f16a88f32"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$nJ8Q0yEXDI1nhGJ26uR9fe0.3SdNwGkrp8jHMDwlpKRDF2b4KhqS2", false, new DateTime(2023, 2, 16, 10, 32, 28, 690, DateTimeKind.Local).AddTicks(9757), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("027faf4e-7157-4389-a40b-a9f7a67a4b01"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$ZOZgzMsQmemRSCtyWMpEG.8jcoY98Y3S9dLBSz8AgpP.kgy4z3IE6", false, new DateTime(2023, 2, 16, 10, 32, 30, 500, DateTimeKind.Local).AddTicks(1000), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("0297b3bd-ad3c-40d0-842e-b4e5197160f7"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$Wmg0yvAANuPjp0awgff.COF8ezrhiCCgNZW7Xn6oH9S7/prMRU.EG", false, new DateTime(2023, 2, 16, 10, 32, 39, 363, DateTimeKind.Local).AddTicks(2554), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("02ea94cd-f516-4150-85df-71330f3ecedf"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$8C2KAPzPGNSurQOXGytNRuJmqz0lOxkXhlR3Qc8bAMQkzSVBu.SOy", false, new DateTime(2023, 2, 16, 10, 32, 36, 114, DateTimeKind.Local).AddTicks(7077), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("07420ea6-a88c-45ba-be7c-d0366a204cd3"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$4BkKvfzUZgqlmyFTaK4c7.67lSB.l6RynSlUkonLv/38l3PTbyDTC", false, new DateTime(2023, 2, 16, 10, 32, 29, 927, DateTimeKind.Local).AddTicks(7177), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("0bc2acd4-b3e8-4351-afca-88ad73cca6f5"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$.0u1BdrZNW5d87CWyP1XjucQXE6gWNcK2pMD5NFnJz.jWbml1Kb3y", false, new DateTime(2023, 2, 16, 10, 32, 30, 785, DateTimeKind.Local).AddTicks(1688), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("0d8295f4-74e3-4c99-bdab-0ad43f5c9ed3"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$/PrZ/RRsR7gleZ0NfUkiYempFc6dwMm/sRZ.5qDwzMiX4ZUzecZBG", false, new DateTime(2023, 2, 16, 10, 32, 36, 935, DateTimeKind.Local).AddTicks(8262), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("164c2b54-c72c-4e70-8ce4-a618114262c3"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$1m1OjBYLc1hPptE1gu77ouxiXFuo78XK/2weYNkxffk1gZBuIDsvO", false, new DateTime(2023, 2, 16, 10, 32, 40, 18, DateTimeKind.Local).AddTicks(8505), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("1714c19c-3f6f-42a5-9b1a-862b946217e6"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$4Nx6C0X3qeNRHrIsj7TMN..pLJKULjn85HLWIhSk85jttga7qHwRy", false, new DateTime(2023, 2, 16, 10, 32, 38, 551, DateTimeKind.Local).AddTicks(7008), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("1b09afb9-50d8-4bda-bea4-df964f47c0e1"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$Y8xtJKb7rB6Tg8Ir.vWGWe9tG6fMA.8uj1/HTAjNpbFIbtZoWTudG", false, new DateTime(2023, 2, 16, 10, 32, 34, 581, DateTimeKind.Local).AddTicks(2927), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("1d2b70d6-0157-41fc-bc1b-ff6279e67c87"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$N5c.oxrS376YGrEETthkquqom1VOXfCW6gNYmGdgadt5oAO9J.beC", false, new DateTime(2023, 2, 16, 10, 32, 35, 185, DateTimeKind.Local).AddTicks(8127), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("1fa640d8-e01b-4f96-a0fc-ac86cd3333ba"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$.kgA2qMfuyzOYZAPaW4Ej.X4sOOI1zLf.5z0IOG65QMiYJNqh6giS", false, new DateTime(2023, 2, 16, 10, 32, 36, 394, DateTimeKind.Local).AddTicks(1523), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("225f29fb-46ce-485e-81e5-9a8a98cbb12d"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$a8rcZdXZr2WhSnf7PQJfUOSoXjQI.Su2qZLRtSDnEhlUO.Zh.4I4S", false, new DateTime(2023, 2, 16, 10, 32, 30, 256, DateTimeKind.Local).AddTicks(2252), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("22de366c-9647-4e01-bac7-e4e390daae0e"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$aJlBBe8YMadVxE5J0/YrUurLG9FMN.esUkoQU2ng88Gkd/6VOWNC2", false, new DateTime(2023, 2, 16, 10, 32, 31, 512, DateTimeKind.Local).AddTicks(9871), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("2331926f-edff-41fb-ab70-52b17686f154"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$vDrvhuO2sjcGqYqO1hsEb.XfzU2.c.p0Io57BV96jKKEORxy08UBm", false, new DateTime(2023, 2, 16, 10, 32, 41, 845, DateTimeKind.Local).AddTicks(7616), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("27e048dd-8f1e-4b20-8fe8-04d9f08ec82e"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$MA8TIoKENLHyxl2YhNlZO.VmDGDQh98J9pv5KoJmHPOoORIthPY.a", false, new DateTime(2023, 2, 16, 10, 32, 38, 18, DateTimeKind.Local).AddTicks(366), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("27f9cacd-ba9c-420d-832b-88dfa00289f7"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$ERb4tX1GCD/SLxmdb8.daOhb/wuNBvgKRqHNRZ11Z946dO4QdQmsK", false, new DateTime(2023, 2, 16, 10, 32, 39, 272, DateTimeKind.Local).AddTicks(2677), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("2939030c-5d1b-4053-9377-d1ecce34570c"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$/nIStncliVuwP8e8YCW1AusH82svZNXxz3BnQ.AzURRLDKioSjYa2", false, new DateTime(2023, 2, 16, 10, 32, 31, 334, DateTimeKind.Local).AddTicks(7331), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("2f0a8a40-27f8-4e16-8422-58e179a70897"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$/Ag.R2nxRE6X0jW5/76ksurZBcMqhuspDTVs1DUvGhwvntZzlc2Fq", false, new DateTime(2023, 2, 16, 10, 32, 29, 395, DateTimeKind.Local).AddTicks(9394), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("338a8892-f902-44a0-9183-918c8a7e0e2e"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$cATuW9LouYPcZvWJY.AOSuq5Y8k26p1tH8UBWNG9qlCDT/Ol5Oena", false, new DateTime(2023, 2, 16, 10, 32, 32, 764, DateTimeKind.Local).AddTicks(4451), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("3572d479-f40f-470e-b9f5-e74063e1d837"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$mTf2/3863lhxGI2KQzWWZ.bkhUFg7fl.NAJwDFgxbNqudVnuq1mi2", false, new DateTime(2023, 2, 16, 10, 32, 39, 712, DateTimeKind.Local).AddTicks(8838), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("39f7f3a6-40ab-4ca0-86ae-8e6f2739e641"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$tqpvMlhTZokoW.2sIy25hOMxU/V.kZYgjlzTh97bf4ZmYhy8uUBsm", false, new DateTime(2023, 2, 16, 10, 32, 29, 797, DateTimeKind.Local).AddTicks(6982), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("3b35a335-80e3-4507-8387-f966de11e186"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$NJvynpjIRmSnOFDrNPRGqOMAA/NkBmnOn2acBYvnt/TSkwprgPS4e", false, new DateTime(2023, 2, 16, 10, 32, 29, 78, DateTimeKind.Local).AddTicks(2902), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("3c8887a5-dd58-4533-bdd4-f82f93e8218d"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$hEzVgC564o1D2OAgHdOUfu.lWoc7bcrug0PtO83GC7A/2lwG2MxqK", false, new DateTime(2023, 2, 16, 10, 32, 30, 36, DateTimeKind.Local).AddTicks(9946), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("3ca30f1d-aca3-4416-8112-8a3b92fa6e12"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$vRHwHltsac7khe4.VdZG0uyPcCWBDf3fD1mVN.sET/pky3/xmPWB.", false, new DateTime(2023, 2, 16, 10, 32, 40, 354, DateTimeKind.Local).AddTicks(4156), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("3cd870f1-a869-4aea-84fc-de9b0d3df475"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$XtkbvNWuylsm8QiK3nJwCuUknMsfzf7xOWlI/5i0e8W7a34uBnCHu", false, new DateTime(2023, 2, 16, 10, 32, 30, 377, DateTimeKind.Local).AddTicks(336), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("3d229841-1530-43e8-b779-38a6aade6f0d"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$eLhWKsXulpRZorJkXMMYk.TjBevFFaH1kTl2lg7STNZJNIoV2KYqO", false, new DateTime(2023, 2, 16, 10, 32, 34, 58, DateTimeKind.Local).AddTicks(2639), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("3f4a1a1f-a0c4-45e8-a1d5-3ce17514a8b3"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$ZagBtjT9Z48d3LvIcNIhYeWiqOKKkgOpJliaTUbixzO7KR8wtPNGu", false, new DateTime(2023, 2, 16, 10, 32, 33, 936, DateTimeKind.Local).AddTicks(6473), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("44ae769f-2c50-438e-8b30-6281f2d0731a"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$lnOaC6uDNjcbYugDWG3H8edVcMUmkkmbYR61VZ699puoKXa6AcM9e", false, new DateTime(2023, 2, 16, 10, 32, 39, 547, DateTimeKind.Local).AddTicks(60), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("4526f776-5ef7-4719-b7da-c28c36d8791d"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$MbDU6GlNWkL6war3GFnaveKSmQwEWkMpB9J/knfMne8urYY7j53c.", false, new DateTime(2023, 2, 16, 10, 32, 38, 871, DateTimeKind.Local).AddTicks(6186), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("462c8e9d-be42-4462-bdae-7e44a0529193"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$f3RpANW.PZG.5wD2U93BCuEKA/A37P2jG.1XK40xP7hkvRLPY/g9W", false, new DateTime(2023, 2, 16, 10, 32, 33, 543, DateTimeKind.Local).AddTicks(837), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("47c8667f-101a-46c0-b380-fb25fa3e46c5"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$pJ1mbZbatsGiF5UwuRlRHuryt3An1.GNONAh4YNqlYjs9.y4cBDbO", false, new DateTime(2023, 2, 16, 10, 32, 35, 979, DateTimeKind.Local).AddTicks(725), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("4ca1d5d9-024b-4e14-a6df-337968960512"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$9JQDMkF5bdENm7KhJV/7Eu5TBiNhTacIwZsay5vs0OIXxgg2F8IC.", false, new DateTime(2023, 2, 16, 10, 32, 40, 718, DateTimeKind.Local).AddTicks(3736), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("4ca707a2-f3df-49bb-9d5e-8aad6c00e58f"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$tUKpkQqRvEbkO3Zl6wAiH.j00K/DFJbDihYWU1syvnGEFqrV0.4Sy", false, new DateTime(2023, 2, 16, 10, 32, 34, 171, DateTimeKind.Local).AddTicks(2305), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("4fd36a4a-4b8b-476f-8805-0ddb4a877b33"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$5ODigJea1MPG1URhhXb5aerV5b4ykh5.ajXqtn.TyzKDdAMuvUH/q", false, new DateTime(2023, 2, 16, 10, 32, 32, 127, DateTimeKind.Local).AddTicks(3732), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("520b995d-75bd-4285-8905-89e14583434c"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$PvvXjCK3xio8AGMElxW2AuqPn/Tqs86AwtqkxQYH9B.n6KfrrWWOe", false, new DateTime(2023, 2, 16, 10, 32, 28, 582, DateTimeKind.Local).AddTicks(596), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("53c37b83-4bd4-4448-8c75-4343b05462be"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$NSbaOPFKvoo2wZgG/ax28.WsHaWcIKi5DWjkRNAK25Ni.Sdh0qYbO", false, new DateTime(2023, 2, 16, 10, 32, 32, 909, DateTimeKind.Local).AddTicks(9755), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("5477daa6-bbe6-4188-b544-8f5a42b73f64"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$Q7z7NlmZAD1.yl8jRkGiYuO/TIgyvv/1eIg3Csf55CeE0mG7/pjDu", false, new DateTime(2023, 2, 16, 10, 32, 35, 362, DateTimeKind.Local).AddTicks(7301), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("54a3dab3-7881-4ab0-b30a-98ca25b59897"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$pxqZjpvssvSYXqQtyTDXI.W5EGLQBl1eIoJFg/Wsl3dC8GfbV6D0C", false, new DateTime(2023, 2, 16, 10, 32, 38, 173, DateTimeKind.Local).AddTicks(2953), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("57351dba-418a-4e98-8a70-a13a557c5dc7"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$zwOQGccwf/cUDSdpPM7iruKv2Nw04yYpORpULZBBEQDshB3Y5fF6a", false, new DateTime(2023, 2, 16, 10, 32, 29, 654, DateTimeKind.Local).AddTicks(5869), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("5761ea33-7cad-431b-947a-6747dd972695"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$bOqcIsubRpTbzPGQEmuZfuxfD37c8vx.M1BLvhdowS8aIhlq06gse", false, new DateTime(2023, 2, 16, 10, 32, 37, 529, DateTimeKind.Local).AddTicks(439), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("5d15b7e1-25db-4c8f-b895-1910f11e47e0"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$bpS0RITHITWRYSfA5U4GUOn3s.Y9GQv3k/lszrJ/yMtV5BV0wX0LK", false, new DateTime(2023, 2, 16, 10, 32, 33, 679, DateTimeKind.Local).AddTicks(2098), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("60485848-f9fa-46cf-b994-569119f30aba"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$tybnznqfLjTUrC/SF5gYr.m1lEAMuvk1XqMch00mJ97Py4T72PWzG", false, new DateTime(2023, 2, 16, 10, 32, 39, 631, DateTimeKind.Local).AddTicks(5078), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("6663886a-e5a9-404d-8e60-97d3e93bd922"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$cuw9xrBr.bXEZCKiJU4gVuY8XI0H1t.8EUPSIDL/3UyLtH2GiUTAq", false, new DateTime(2023, 2, 16, 10, 32, 30, 957, DateTimeKind.Local).AddTicks(1915), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("70543f08-4867-431d-a37d-f38a84b32f6f"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$IaYeOzcJ4rEMNbnqLhT7Y.3BKLl73d9M3de9LIewVWxcYOHyQNbaa", false, new DateTime(2023, 2, 16, 10, 32, 28, 959, DateTimeKind.Local).AddTicks(5006), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("7057b111-c6d4-414b-944f-86ea8c11fe7d"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$YChTnxNnEWB5ZeQVF56wOu8EV0sSCqKo7WfLTb.sQW6RP3WyudVkO", false, new DateTime(2023, 2, 16, 10, 32, 31, 245, DateTimeKind.Local).AddTicks(7318), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("76301a4a-57c3-4867-a7af-0b20069889e4"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$6E5iAdLtCEjInqAYM5FWue/CzC8qWysIxKaYd7ETAqF6KAdItWRY6", false, new DateTime(2023, 2, 16, 10, 32, 37, 856, DateTimeKind.Local).AddTicks(7107), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("76b89181-6134-4390-af00-6fcc08e8a415"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$KKLq8/UVScOF9U0ZxNEEtephsHVcc6aHfrrGHhej/rif1JjRpNuBS", false, new DateTime(2023, 2, 16, 10, 32, 39, 903, DateTimeKind.Local).AddTicks(5845), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("80203e03-611b-4754-a731-b24c149e7158"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$Bou4Siys/HO/F21nP4MWTe3mI2/O6yQVaxp1Qz9bTQUeHZctH5qlC", false, new DateTime(2023, 2, 16, 10, 32, 38, 435, DateTimeKind.Local).AddTicks(3675), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("82f54fe1-7ade-4a8d-9b18-4d126293d5b4"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$NjhZhMv.pbGye6sDKka0weoLkGENns6LlV//2OZWL8wtjWY356fJu", false, new DateTime(2023, 2, 16, 10, 32, 31, 806, DateTimeKind.Local).AddTicks(135), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("8408ac61-3a35-4548-bf7f-d5cf206cef05"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$qpNt/a.xr1BU9mxznPtJFONEhU8/EuYY/DImtBeBwGNwpdmN6MZEm", false, new DateTime(2023, 2, 16, 10, 32, 38, 752, DateTimeKind.Local).AddTicks(9875), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("850c509d-f9ef-4b5b-b269-7a4234208e72"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$Txwmf8Z2fu6Tr4Ha6N3FSuxNeKAf1/t0MHE4d4BS6oEikKtoMoJ2K", false, new DateTime(2023, 2, 16, 10, 32, 33, 419, DateTimeKind.Local).AddTicks(290), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("87e3365f-516a-46aa-90d4-9c926ed513d7"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$4hOxYQ2F4sUP4vIc68fQ9ut1mV2JnT3zN.jZWVCOqm3.q6mu12BBG", false, new DateTime(2023, 2, 16, 10, 32, 33, 154, DateTimeKind.Local).AddTicks(9691), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("88ae02d7-c89d-477e-bda9-6f7b299da1bc"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$p/dDtJxVJmzKpo2r4v76Me86nfrj1a31avAM1ZG1dwPF8UNBS4Cme", false, new DateTime(2023, 2, 16, 10, 32, 34, 405, DateTimeKind.Local).AddTicks(7345), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("8c83b44c-d5cf-4f4e-b354-5f54f5f3b4cd"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$Bg9BnkG5VZfJC9iu9.VHyuP527SSmgeXBIuaXaMZ73CSJhl5hss42", false, new DateTime(2023, 2, 16, 10, 32, 31, 706, DateTimeKind.Local).AddTicks(6797), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("8e5fa1a5-7227-4a61-9d68-aa5f3b83cfb6"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$6KLd8yfxu1EH9VlKFg0B7uY07FHs8O27246i52VPialP/Z7q3.Bha", false, new DateTime(2023, 2, 16, 10, 32, 32, 247, DateTimeKind.Local).AddTicks(7113), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("90e1cd6b-75a3-4962-971c-14f7a403f4fd"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$vdDGSpGZNNtHrXRxPg3FAeekq3FUCWwihj.csV0d7JAPNpgfINzh.", false, new DateTime(2023, 2, 16, 10, 32, 40, 809, DateTimeKind.Local).AddTicks(411), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("9765ea0b-f4a2-4f94-aa4f-cb9364dd6a74"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$owuC9FkrXXfPZNkjFi8yR.y4tpP1GH./nTLlzCoI.cseJB14bz/oW", false, new DateTime(2023, 2, 16, 10, 32, 31, 418, DateTimeKind.Local).AddTicks(4174), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("9810b437-b89f-4fd3-870b-da31ee729f45"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$B/FeMYx.PQa9hubdsBnq/uprLY9J8TBSusUO.1krI10swySOPIDua", false, new DateTime(2023, 2, 16, 10, 32, 39, 804, DateTimeKind.Local).AddTicks(8565), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("9979e214-bf8a-4667-9bd6-943d9a2dea02"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$BR8zBhNR7QMgCBWO2uFW1.DogyjZhCX0JsnIsJTV4k7Bg6oc.KunK", false, new DateTime(2023, 2, 16, 10, 32, 37, 701, DateTimeKind.Local).AddTicks(6641), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("9a4814c5-2e15-426d-9728-32f3b08894d0"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$JilFV/LPpf7kPXi9Cjh3wuz1F9HkM/aHegSp4IyKAuHpLJrncvD1S", false, new DateTime(2023, 2, 16, 10, 32, 40, 436, DateTimeKind.Local).AddTicks(1930), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("9da7b0c5-020e-4776-affa-56185044d9b0"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$2NHJHxI/1PO1qE79KPNq5.CL.Kxty.oC4kckS6rLkXx22wmMc70aO", false, new DateTime(2023, 2, 16, 10, 32, 32, 481, DateTimeKind.Local).AddTicks(6282), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("a214e33c-3e07-4734-8bec-08a97aca00c7"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$Gf66H4hE7sPIrCYhclj19OFhuYSjMPLni4AptMS7zt6NX4CGTAT9C", false, new DateTime(2023, 2, 16, 10, 32, 40, 999, DateTimeKind.Local).AddTicks(3010), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("a4f3d473-eb2d-4e16-ade2-e8b7d1a87079"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$P/BFHwSu9xlLhiIOEuKqYeFEPCgqlKnNDrI0Lb34CIGlaQgnt3u6.", false, new DateTime(2023, 2, 16, 10, 32, 40, 190, DateTimeKind.Local).AddTicks(9983), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("a516b796-86c6-4c38-b350-3981f7f019cb"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$RdEAp7j.ZznBAQ6HeRzi.eV5ZADFKIUWETW4.5O1HfdMh133FwSGu", false, new DateTime(2023, 2, 16, 10, 32, 34, 727, DateTimeKind.Local).AddTicks(8416), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("a62366c2-6c52-4382-85cc-3d0526b6e5f2"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$u/FmB81P4ZOy6cw5jAGD8Osi8oeahaot9ymX1vtycn6uKHlQJgZC6", false, new DateTime(2023, 2, 16, 10, 32, 31, 600, DateTimeKind.Local).AddTicks(4452), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("a8d1dda3-b2d2-4f25-bcfa-1af16d8c16b4"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$fxukQMvHfW2dgC/UPmcWEuJsDkDYhaDRNvLZq6xUnkfTlag665P7.", false, new DateTime(2023, 2, 16, 10, 32, 29, 523, DateTimeKind.Local).AddTicks(7419), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("ab36b29d-03b1-4323-a8d3-87dcdb49a9de"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$xOuiubcc3CWdIXIxWiYdO.FGOl1uzM58j5G0kKNfrXey.nZqmlUXu", false, new DateTime(2023, 2, 16, 10, 32, 36, 506, DateTimeKind.Local).AddTicks(3266), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("afb5c17e-d70c-4acb-9413-d21acff32759"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$PtJ83.Bih78gazUJvrTqceOhX74JqUmdwoKnW403im3zLolPTfo0S", false, new DateTime(2023, 2, 16, 10, 32, 34, 870, DateTimeKind.Local).AddTicks(3864), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("b001828c-f38a-4649-baa2-e9bbf8fc206e"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$jat7qWxQTo9QdlxzPpwqKu6f/nU87d.xRLWAUyAECp4zdHydm1X6W", false, new DateTime(2023, 2, 16, 10, 32, 30, 696, DateTimeKind.Local).AddTicks(8554), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("b30e0d2a-2f37-4ca4-9ac1-5f0d93f9c5de"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$M5KWiatSDGXMWm3ixyAtQebABEaMl.m/bMuTwAuSL9LIuBDViJ8DG", false, new DateTime(2023, 2, 16, 10, 32, 31, 152, DateTimeKind.Local).AddTicks(8991), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("b4cff6a7-deb5-422e-92bb-912ea38ca3a7"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$RzpmC7Zr5MR8yhWc0eJzPuUe/G8dhuRDBqxvPKrCYNHABmAl8Zfti", false, new DateTime(2023, 2, 16, 10, 32, 35, 689, DateTimeKind.Local).AddTicks(9999), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("b5a48cb8-3095-4e08-be06-99ad8de2ecc8"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$Yn2Vl0Tkj3i4p5kMh1Jf/.wzlZagmCbU5YmQ98h72cimDZL0p5epe", false, new DateTime(2023, 2, 16, 10, 32, 36, 776, DateTimeKind.Local).AddTicks(8607), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("b748dd85-23c9-49c8-ac95-943d75d79ad0"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$DNVdgxWqtMdXRIgSr8WMuePf/vTQx5yKul.DzNClrS7zNiw/kngP6", false, new DateTime(2023, 2, 16, 10, 32, 35, 32, DateTimeKind.Local).AddTicks(877), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("b7f15335-685b-44fe-bf41-03e51160704b"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$jEgFVn4C32NjPfBGz5VxW.NH5cjFMRzyyr6t46WImmwcoNHPzhD/.", false, new DateTime(2023, 2, 16, 10, 32, 28, 832, DateTimeKind.Local).AddTicks(7697), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("b82c0f1d-d6f3-4afd-b7dd-43cedfa2ad68"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$eLvLiewZXCScAtPaBipYtO7zRURjgKjRIhs9LZcSBFyy2ZC7NlobG", false, new DateTime(2023, 2, 16, 10, 32, 41, 544, DateTimeKind.Local).AddTicks(1301), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("b944df39-3352-46bd-8a7e-d887028c811f"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$SLLmNDBfLR1K2uaHkJfB7usewel6eL3pB/iwZqazt7U1gsgm8BMRa", false, new DateTime(2023, 2, 16, 10, 32, 38, 989, DateTimeKind.Local).AddTicks(1502), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("ba8370d3-81d5-41b9-bdcb-89a2149069f3"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$4r0ZJHVwBodYKMW2xWjRee1tjGug/u5OtFqJxPABGe0TGbw.mk8Wy", false, new DateTime(2023, 2, 16, 10, 32, 32, 25, DateTimeKind.Local).AddTicks(5925), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("bbe4fa2c-2895-4fde-812b-0a28b112b3ad"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$3FkV5Hff4uKy6bGauahgve9BVAQFIiw3ySZabHNY0VWr0PWtBuIEW", false, new DateTime(2023, 2, 16, 10, 32, 39, 182, DateTimeKind.Local).AddTicks(8086), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("bcda644b-2649-4fdc-b259-88b0f79e4722"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$LSspztBlmxyhrgfVoUuDAu0UEqPrLcpsEVgdNATfNaux1VhTVT6oS", false, new DateTime(2023, 2, 16, 10, 32, 30, 598, DateTimeKind.Local).AddTicks(498), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("bdf2c786-37e5-4781-b92b-7a1324eddaaa"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$vc.yjCynGQqj0w2nPopKk.vwbfeme2M.s6sjZFPo0YzmVmBfLSvMa", false, new DateTime(2023, 2, 16, 10, 32, 33, 800, DateTimeKind.Local).AddTicks(3756), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("c08e3181-30be-4edb-9314-c4dbc4b72f5a"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$ITNkaKnR.uQNWUY9FKifveAQLZVBqJ6tNPebCieOPWvm5gtGp3Gkq", false, new DateTime(2023, 2, 16, 10, 32, 37, 373, DateTimeKind.Local).AddTicks(4343), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("c3993824-3182-4abb-8a0e-e087f8e66de3"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$NxskoW75PO/rt82IS8.5meeo.slr4j.7abKogQGn4WapK04fR5nQW", false, new DateTime(2023, 2, 16, 10, 32, 31, 909, DateTimeKind.Local).AddTicks(2058), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("cc71468b-2ce1-47ee-ad8a-25efdbd1e77f"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$kSwWgXeMkFC6.gFiLHhwhOhWrByS.XpRKmVIw7WktXBTX8UJzu7bK", false, new DateTime(2023, 2, 16, 10, 32, 38, 307, DateTimeKind.Local).AddTicks(2181), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("cce11894-a501-4c78-ae16-6067ca9229ea"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$AdRQPS77z7veUw18l6LbCOzbaKUTgVRasM3wcmG/XZd7q6ArLJ6s2", false, new DateTime(2023, 2, 16, 10, 32, 40, 630, DateTimeKind.Local).AddTicks(439), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("ce6ec81b-32cb-486b-a71b-ebd20ec15091"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$z75AkyPiw55QweYSdDcrWuX4zXekvjOzk988pcL6i3Hvs5YO0J.Ii", false, new DateTime(2023, 2, 16, 10, 32, 41, 976, DateTimeKind.Local).AddTicks(3050), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("cf87d790-5a06-4e9d-b553-f8d93aade5e4"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$GCxAATCFLD5X62YDXfVzEu7O/a38cWtQPNuJ/OIvjmATuSX3Umtqu", false, new DateTime(2023, 2, 16, 10, 32, 33, 24, DateTimeKind.Local).AddTicks(1190), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("d248f865-f8ef-414e-83b2-d85cacbf4b6d"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$GkOhRu61FULhkvjsn.cxWOrYBfZB5LMbXOE2pQdkGCKjYm9JZparC", false, new DateTime(2023, 2, 16, 10, 32, 37, 85, DateTimeKind.Local).AddTicks(1529), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("d340aa09-1918-4321-99e5-e4fe5c1602a2"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$aWHEDyKmSNgj8ULah.gSL.fXs4nfD/QOeZUczb9zxnYUEDmdrolvK", false, new DateTime(2023, 2, 16, 10, 32, 40, 905, DateTimeKind.Local).AddTicks(1808), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("d64e49c9-1480-4bc6-8cd4-833d4f0b7ced"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$lHagtabORKxcncetbmexf.lkDBqu.WJBnCkkLGn7NGCC5i0.Rs.Na", false, new DateTime(2023, 2, 16, 10, 32, 32, 631, DateTimeKind.Local).AddTicks(7880), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("d7aa2002-5d1c-4af9-934f-bc98b55d1b2e"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$aHQwgvHz0BaCX7oBPmLRGePKQHATDPlexDHxucYqSoAXPOglwaTdi", false, new DateTime(2023, 2, 16, 10, 32, 41, 745, DateTimeKind.Local).AddTicks(9130), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("dbfda2ac-355d-4db1-9d69-6adbb6666107"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$y6WuyBRj2UvGVBZroefue.XxED6BseG.K9kR5.HOtpsk8tiKPy4NW", false, new DateTime(2023, 2, 16, 10, 32, 30, 869, DateTimeKind.Local).AddTicks(8549), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("dcfb47d9-0a0a-439f-8420-fcdbc2a81570"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$IZE3xD/N9JFeSgvDBqbPte2deDXqi7/K03f2206H9ZiOmj01SuOCq", false, new DateTime(2023, 2, 16, 10, 32, 35, 535, DateTimeKind.Local).AddTicks(8644), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("ddd0c869-3ebb-41ce-9b24-18d365853250"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$CdganH/oDg50U4/I6E4AoO0PzWvaxYRcBeAEcSsjgntIWB1wEjiae", false, new DateTime(2023, 2, 16, 10, 32, 31, 51, DateTimeKind.Local).AddTicks(5254), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("ddf0d2c4-6429-4c9c-a940-527e0ed29159"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$u3MMSihR4UTo1cyelblNwOo8BZ.1t6NBK0jOiMBxay/P9QOLL601u", false, new DateTime(2023, 2, 16, 10, 32, 36, 645, DateTimeKind.Local).AddTicks(6769), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("de116ede-0588-4c85-91f3-f599450e5bc3"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$UhScQtIT6Kge.D/6qsQltO0wa.0MY09tLuvDoLYms6ae9Y5An5cNK", false, new DateTime(2023, 2, 16, 10, 32, 41, 312, DateTimeKind.Local).AddTicks(8105), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("de3e4ad7-5ac7-4c84-bb26-4e46b0f01835"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$i7vdJcW.3nofJXEuDOgcK.J5wBka1u8ayh3CZU5KrwXkgnsUGn7dS", false, new DateTime(2023, 2, 16, 10, 32, 33, 281, DateTimeKind.Local).AddTicks(1727), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("dea4c2c3-48ad-4495-ab44-c78d11b4047b"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$plM983sXykpfBWMz6oRtU.X0weDiCc/ch.r7TwvfGm7XWAEBFvMHu", false, new DateTime(2023, 2, 16, 10, 32, 39, 88, DateTimeKind.Local).AddTicks(1892), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("dfb489ee-ad4d-4bba-9a55-9eaa13874245"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$sEnUT9uaXKfiynAMFCkGDOuIPAgU6ZaCGpn20qjxEdYYJZUUzKryO", false, new DateTime(2023, 2, 16, 10, 32, 40, 273, DateTimeKind.Local).AddTicks(6507), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("e104e97c-a272-4f8a-9099-eb646c6b7a28"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$voLPDQ/OHjyZYxZcyJpzxeGfSayfngLp0SelCjwTt2TtfJLJEPvey", false, new DateTime(2023, 2, 16, 10, 32, 41, 93, DateTimeKind.Local).AddTicks(5885), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("e1d42680-4732-49dc-b3ff-8958352cf73a"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$vGW3OtywnIkwotwtfjVpxOo/suYi5.ocWEAxCjFwxmKtFPGoaH0wG", false, new DateTime(2023, 2, 16, 10, 32, 37, 216, DateTimeKind.Local).AddTicks(186), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("e4497c47-1e5e-4bd9-8d88-973310b2959d"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$ChXXHJKm97ixoXz9Yi4BWOv53t3EmKNGSoWBm1V18MFt5MgVOn4a6", false, new DateTime(2023, 2, 16, 10, 32, 30, 146, DateTimeKind.Local).AddTicks(2416), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("e55426e5-fdd3-4341-ac63-72a83e25df46"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$j.fuUnIVG5QcQAHZt1S8f.GaRNEpm6ab8vygem.or.xngdrsmKoO2", false, new DateTime(2023, 2, 16, 10, 32, 29, 212, DateTimeKind.Local).AddTicks(7959), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("ea1baeb2-50cc-4759-a3e3-393027f1eae2"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$AuOqlDf.Y80cZvj3ImeTt.xyHs7TZWofVvP369rgUrK9eVIvYJ0p2", false, new DateTime(2023, 2, 16, 10, 32, 41, 202, DateTimeKind.Local).AddTicks(5132), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("ec6119f9-4484-4b49-ba1a-6b10daef1fe4"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$wFHe2Y11LCGH6ymmy9fun.DdQLBcdBLW58yBvkpvIl3EjwQG7f/zm", false, new DateTime(2023, 2, 16, 10, 32, 36, 248, DateTimeKind.Local).AddTicks(3037), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("ed48f6fa-fa80-4d54-9d0a-ca8015d1b099"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$tsNbuQlxoM40zDgofINuYO6BSAn3YmteC7AfffMcNiiCymklMMWO.", false, new DateTime(2023, 2, 16, 10, 32, 41, 649, DateTimeKind.Local).AddTicks(2947), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("f03560f6-ff0b-48df-92a3-0c7717e1a8c2"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$alLvV8FNBj3sncAJ2VvBXuU6czycDXB.UcTnTDvACFGmFx1y8F7TC", false, new DateTime(2023, 2, 16, 10, 32, 40, 107, DateTimeKind.Local).AddTicks(515), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("f388c1e2-5e87-4ac8-a1ed-0d1ac9426159"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$rZaPrWfo7EQPiMl4Rg7BuOQY8RIShCQnIi6QhZRVZBjhok7ALjzLW", false, new DateTime(2023, 2, 16, 10, 32, 41, 425, DateTimeKind.Local).AddTicks(1308), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("f7357b5f-ba88-41cf-b816-a698607aac96"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$VqGAG7aMkKlZD9JGFybYN.Oxrlx7/lO/Oyx0tgt5qFTQA3ehLEeBG", false, new DateTime(2023, 2, 16, 10, 32, 35, 840, DateTimeKind.Local).AddTicks(379), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("fc4b3cbc-ffcd-494b-a3ac-5038a0e41990"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$I2oTxHh4yZ11s1VVQgCNwuRRbhmLR5woE/0gS7CZWwKDeBBpSrO2W", false, new DateTime(2023, 2, 16, 10, 32, 38, 652, DateTimeKind.Local).AddTicks(3472), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("fcc09efa-6141-4d26-9586-3221cdb26af9"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$JG4C61e/Ndq3zhSWlwziWepoQDzDxKZdvMMIT/jkioRGVi1pzqqTe", false, new DateTime(2023, 2, 16, 10, 32, 40, 534, DateTimeKind.Local).AddTicks(5897), "Andriessen", null, null, "05873824805", 2, "candriessen2o" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetail_TimeFrames_TimeFrameID",
                table: "ParkingDetail",
                column: "TimeFrameID",
                principalTable: "TimeFrames",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeFrames_Parkings_ParkingsID",
                table: "TimeFrames",
                column: "ParkingsID",
                principalTable: "Parkings",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeFrames_Users_LastModifyByID",
                table: "TimeFrames",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetail_TimeFrames_TimeFrameID",
                table: "ParkingDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeFrames_Parkings_ParkingsID",
                table: "TimeFrames");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeFrames_Users_LastModifyByID",
                table: "TimeFrames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeFrames",
                table: "TimeFrames");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("099e08c0-b9b0-4556-9fd5-94fb6ddb2d03"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("5b823c2b-b06b-4c92-b115-48c8fe2746b8"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("6ad70515-6408-40de-8160-f63a0aba3c7d"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("72be680c-d294-41bf-a411-181688fd0835"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("cc5106fc-12fe-4ac4-b95b-7ab23b8bdb1f"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("cfab174d-de04-4dc8-9774-bc6bf0348a5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01036dcd-883c-4198-9abc-2f5792d9e52e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("025638e0-60d7-4f51-970f-aa8f16a88f32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("027faf4e-7157-4389-a40b-a9f7a67a4b01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0297b3bd-ad3c-40d0-842e-b4e5197160f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("02ea94cd-f516-4150-85df-71330f3ecedf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("07420ea6-a88c-45ba-be7c-d0366a204cd3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0bc2acd4-b3e8-4351-afca-88ad73cca6f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0d8295f4-74e3-4c99-bdab-0ad43f5c9ed3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("164c2b54-c72c-4e70-8ce4-a618114262c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1714c19c-3f6f-42a5-9b1a-862b946217e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b09afb9-50d8-4bda-bea4-df964f47c0e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1d2b70d6-0157-41fc-bc1b-ff6279e67c87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1fa640d8-e01b-4f96-a0fc-ac86cd3333ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("225f29fb-46ce-485e-81e5-9a8a98cbb12d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("22de366c-9647-4e01-bac7-e4e390daae0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2331926f-edff-41fb-ab70-52b17686f154"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("27e048dd-8f1e-4b20-8fe8-04d9f08ec82e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("27f9cacd-ba9c-420d-832b-88dfa00289f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2939030c-5d1b-4053-9377-d1ecce34570c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f0a8a40-27f8-4e16-8422-58e179a70897"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("338a8892-f902-44a0-9183-918c8a7e0e2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3572d479-f40f-470e-b9f5-e74063e1d837"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("39f7f3a6-40ab-4ca0-86ae-8e6f2739e641"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3b35a335-80e3-4507-8387-f966de11e186"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3c8887a5-dd58-4533-bdd4-f82f93e8218d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3ca30f1d-aca3-4416-8112-8a3b92fa6e12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3cd870f1-a869-4aea-84fc-de9b0d3df475"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3d229841-1530-43e8-b779-38a6aade6f0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3f4a1a1f-a0c4-45e8-a1d5-3ce17514a8b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("44ae769f-2c50-438e-8b30-6281f2d0731a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4526f776-5ef7-4719-b7da-c28c36d8791d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("462c8e9d-be42-4462-bdae-7e44a0529193"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("47c8667f-101a-46c0-b380-fb25fa3e46c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4ca1d5d9-024b-4e14-a6df-337968960512"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4ca707a2-f3df-49bb-9d5e-8aad6c00e58f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4fd36a4a-4b8b-476f-8805-0ddb4a877b33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("520b995d-75bd-4285-8905-89e14583434c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("53c37b83-4bd4-4448-8c75-4343b05462be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5477daa6-bbe6-4188-b544-8f5a42b73f64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("54a3dab3-7881-4ab0-b30a-98ca25b59897"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("57351dba-418a-4e98-8a70-a13a557c5dc7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5761ea33-7cad-431b-947a-6747dd972695"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5d15b7e1-25db-4c8f-b895-1910f11e47e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("60485848-f9fa-46cf-b994-569119f30aba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6663886a-e5a9-404d-8e60-97d3e93bd922"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("70543f08-4867-431d-a37d-f38a84b32f6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7057b111-c6d4-414b-944f-86ea8c11fe7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("76301a4a-57c3-4867-a7af-0b20069889e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("76b89181-6134-4390-af00-6fcc08e8a415"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("80203e03-611b-4754-a731-b24c149e7158"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("82f54fe1-7ade-4a8d-9b18-4d126293d5b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8408ac61-3a35-4548-bf7f-d5cf206cef05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("850c509d-f9ef-4b5b-b269-7a4234208e72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("87e3365f-516a-46aa-90d4-9c926ed513d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("88ae02d7-c89d-477e-bda9-6f7b299da1bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8c83b44c-d5cf-4f4e-b354-5f54f5f3b4cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8e5fa1a5-7227-4a61-9d68-aa5f3b83cfb6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("90e1cd6b-75a3-4962-971c-14f7a403f4fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9765ea0b-f4a2-4f94-aa4f-cb9364dd6a74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9810b437-b89f-4fd3-870b-da31ee729f45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9979e214-bf8a-4667-9bd6-943d9a2dea02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9a4814c5-2e15-426d-9728-32f3b08894d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9da7b0c5-020e-4776-affa-56185044d9b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a214e33c-3e07-4734-8bec-08a97aca00c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a4f3d473-eb2d-4e16-ade2-e8b7d1a87079"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a516b796-86c6-4c38-b350-3981f7f019cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a62366c2-6c52-4382-85cc-3d0526b6e5f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a8d1dda3-b2d2-4f25-bcfa-1af16d8c16b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab36b29d-03b1-4323-a8d3-87dcdb49a9de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("afb5c17e-d70c-4acb-9413-d21acff32759"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b001828c-f38a-4649-baa2-e9bbf8fc206e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b30e0d2a-2f37-4ca4-9ac1-5f0d93f9c5de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b4cff6a7-deb5-422e-92bb-912ea38ca3a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b5a48cb8-3095-4e08-be06-99ad8de2ecc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b748dd85-23c9-49c8-ac95-943d75d79ad0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b7f15335-685b-44fe-bf41-03e51160704b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b82c0f1d-d6f3-4afd-b7dd-43cedfa2ad68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b944df39-3352-46bd-8a7e-d887028c811f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba8370d3-81d5-41b9-bdcb-89a2149069f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bbe4fa2c-2895-4fde-812b-0a28b112b3ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bcda644b-2649-4fdc-b259-88b0f79e4722"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bdf2c786-37e5-4781-b92b-7a1324eddaaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c08e3181-30be-4edb-9314-c4dbc4b72f5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c3993824-3182-4abb-8a0e-e087f8e66de3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cc71468b-2ce1-47ee-ad8a-25efdbd1e77f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cce11894-a501-4c78-ae16-6067ca9229ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ce6ec81b-32cb-486b-a71b-ebd20ec15091"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cf87d790-5a06-4e9d-b553-f8d93aade5e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d248f865-f8ef-414e-83b2-d85cacbf4b6d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d340aa09-1918-4321-99e5-e4fe5c1602a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d64e49c9-1480-4bc6-8cd4-833d4f0b7ced"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d7aa2002-5d1c-4af9-934f-bc98b55d1b2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dbfda2ac-355d-4db1-9d69-6adbb6666107"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dcfb47d9-0a0a-439f-8420-fcdbc2a81570"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ddd0c869-3ebb-41ce-9b24-18d365853250"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ddf0d2c4-6429-4c9c-a940-527e0ed29159"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("de116ede-0588-4c85-91f3-f599450e5bc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("de3e4ad7-5ac7-4c84-bb26-4e46b0f01835"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dea4c2c3-48ad-4495-ab44-c78d11b4047b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dfb489ee-ad4d-4bba-9a55-9eaa13874245"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e104e97c-a272-4f8a-9099-eb646c6b7a28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e1d42680-4732-49dc-b3ff-8958352cf73a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4497c47-1e5e-4bd9-8d88-973310b2959d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e55426e5-fdd3-4341-ac63-72a83e25df46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ea1baeb2-50cc-4759-a3e3-393027f1eae2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec6119f9-4484-4b49-ba1a-6b10daef1fe4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ed48f6fa-fa80-4d54-9d0a-ca8015d1b099"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f03560f6-ff0b-48df-92a3-0c7717e1a8c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f388c1e2-5e87-4ac8-a1ed-0d1ac9426159"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f7357b5f-ba88-41cf-b816-a698607aac96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fc4b3cbc-ffcd-494b-a3ac-5038a0e41990"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fcc09efa-6141-4d26-9586-3221cdb26af9"));

            migrationBuilder.RenameTable(
                name: "TimeFrames",
                newName: "TimeFrame");

            migrationBuilder.RenameIndex(
                name: "IX_TimeFrames_ParkingsID",
                table: "TimeFrame",
                newName: "IX_TimeFrame_ParkingsID");

            migrationBuilder.RenameIndex(
                name: "IX_TimeFrames_LastModifyByID",
                table: "TimeFrame",
                newName: "IX_TimeFrame_LastModifyByID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeFrame",
                table: "TimeFrame",
                column: "ID");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("0b777377-1313-4039-910d-ae432cb5d3a2"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("50fb1a58-72a2-447c-975d-ed556940185d"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("54dccc71-e1b3-451f-bfea-d66fa0695061"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("84d5a602-b066-4631-9247-92d09af8d4c1"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("cca3d0eb-6fd5-45a8-852a-f60c182dfef7"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("e4f78d50-f783-415b-9a54-a892ce1d896c"), "Xe bán tải", null, null, "Pickup", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("02906116-86fb-4c34-88ae-de3abdf4dd00"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$x91T6X6gFuL3.WEo8OPvNO.CmV8CqQy4NuaYyqxUlSvWyNZb3IBqm", false, new DateTime(2023, 2, 15, 23, 54, 38, 309, DateTimeKind.Local).AddTicks(8177), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("03f2fc62-f349-45a7-b007-4443ffc2640a"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$BKLAlKxDL6ZG5ht.Pl.d/Os1zs.0Ql4C47.YXigmnagan066yZ4/O", false, new DateTime(2023, 2, 15, 23, 54, 36, 460, DateTimeKind.Local).AddTicks(4448), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("08ecb841-bb65-4135-867c-17e5572c8307"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$GEV8GSRM4TH9SPvZCR8CuuY24RxkoudJ70XHbQ6NN04G0cgPuE4Ii", false, new DateTime(2023, 2, 15, 23, 54, 39, 864, DateTimeKind.Local).AddTicks(5292), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("0c379b5e-84ae-439b-a60f-29bf68b9a8c6"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$w2kC4ij3ODrNzXHbFby02Ou0.Q4GoMw/ITG1vYGNgw7CNppSZxzF6", false, new DateTime(2023, 2, 15, 23, 54, 36, 529, DateTimeKind.Local).AddTicks(6400), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("0daa55db-2fd0-4e0c-a650-b45221a98a34"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$YtPjxgdW9Dh4V9mDe/SUQegfQLQUNTl2aYUdXZNOH12uw5wM/JDLG", false, new DateTime(2023, 2, 15, 23, 54, 41, 262, DateTimeKind.Local).AddTicks(8800), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("136876ee-dd47-4d8d-999d-b6dbc8433605"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$ylagKSpPdNOKVK5h9H0mUODcMAh/HL0OMXS2w9a0CgfqyFgOcrCWK", false, new DateTime(2023, 2, 15, 23, 54, 40, 914, DateTimeKind.Local).AddTicks(1179), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("165ecc96-9c21-4431-8c1c-a36aede60cda"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$I42wcBq.MkyLg0u5DU9p/Oq.ED5.DP.mLbHcqquHftpkiFeXzqX1y", false, new DateTime(2023, 2, 15, 23, 54, 38, 597, DateTimeKind.Local).AddTicks(6463), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("1af96fde-7bf7-4310-b14d-15d7099dd001"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$L8Etqh/g9A5cImzvetEuS.ZEIu7YgZggEBKX/VjFZ3kAdGppAJjqS", false, new DateTime(2023, 2, 15, 23, 54, 35, 664, DateTimeKind.Local).AddTicks(9121), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("1fd0fe9e-497c-4155-963c-0c60ee676e04"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$nxJZLQowO5lphf6le.qxK.oym2WsodTs3Vh093Nb2td7wZIdJTVx.", false, new DateTime(2023, 2, 15, 23, 54, 37, 311, DateTimeKind.Local).AddTicks(2304), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("211dad79-d064-4a15-845d-1aa6fb240240"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$KTSVTt0utSeRZP4O5WbXi.8Fc4swYY81gKwY6qBCBoxzfFS6oIz.6", false, new DateTime(2023, 2, 15, 23, 54, 36, 815, DateTimeKind.Local).AddTicks(9764), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("23bc3d84-dfe4-4afd-8f2f-317d38b4e16f"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$IncOqo4eqOGq6gLFDvj5N.7vrj7Th3dmdZbvqRxeQ6evfjiq5v7Ye", false, new DateTime(2023, 2, 15, 23, 54, 42, 300, DateTimeKind.Local).AddTicks(9514), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("2b9d54cd-8035-41cb-a786-9f970b21c6db"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$bFpqno0hI5uKmzR6KCuFOu9RFwTPnSmr/yDBFCkkpKn7n2.MsbwpC", false, new DateTime(2023, 2, 15, 23, 54, 42, 162, DateTimeKind.Local).AddTicks(2525), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("2dd0b9d7-ea66-487b-8809-ea99dd9b1693"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$cCExU.Sz60w3X13LEQuz1uIc/oRAZlI/vIEUVFj7RZKPt91hVKuPS", false, new DateTime(2023, 2, 15, 23, 54, 37, 738, DateTimeKind.Local).AddTicks(5067), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("2f05b3f5-2da8-4c08-87a6-1d7ab6fcd4e2"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$Ab9NhVPifSsZSER2RNNe4OL/ylQRpJpUtNfPQZr5TiKEBjySPYvxi", false, new DateTime(2023, 2, 15, 23, 54, 38, 807, DateTimeKind.Local).AddTicks(6745), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("318bbec2-34a8-49ef-abdd-f9e8748ff420"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$m6YETpiZBqUKeDmLArm/SewJPbI3R92oQelj5nZ8lk7YWmytWFjIq", false, new DateTime(2023, 2, 15, 23, 54, 36, 384, DateTimeKind.Local).AddTicks(7064), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("32dd4e3e-4e26-4d05-9f09-175e21a2c785"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$a/SVUlqMzMnf23lG7gwjR.DQCpmaUQsFNUryXKWLI2Ex81a7p/uD6", false, new DateTime(2023, 2, 15, 23, 54, 38, 25, DateTimeKind.Local).AddTicks(6976), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("35383933-15ab-4586-a8ae-cb437929a1ca"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$fGgFvjxtiTPeVjv3PVR9Se0/ucRpyijz.h7.nGeGj9ParK7LbFIPu", false, new DateTime(2023, 2, 15, 23, 54, 40, 633, DateTimeKind.Local).AddTicks(2646), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("358ece71-f939-4c62-abea-d60815208757"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$5kQQU04D0scLURK5iYtsHuIbBurO/RcdIS56Q27t5Z/IgucIsr42i", false, new DateTime(2023, 2, 15, 23, 54, 39, 444, DateTimeKind.Local).AddTicks(6880), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("39fb4d78-5ee8-4ab7-93be-9ef8ce515f4b"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$3fs3jNp4nBgrH2AwTZY3q.QX723FsPfHpna.9brkrrqc.zayMYl3O", false, new DateTime(2023, 2, 15, 23, 54, 36, 600, DateTimeKind.Local).AddTicks(1694), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("40c57a2d-e944-4a5d-ae4c-f59faac44bda"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$PqbSqGhyxZ/d5pSkkN6KqONo9KS29G5rUa1NumFmhzJRjUNm0j2u2", false, new DateTime(2023, 2, 15, 23, 54, 40, 211, DateTimeKind.Local).AddTicks(4965), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("441ec007-8afc-4b05-b9c4-e82c9f6d22be"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$JqvdxvqtmJA1iwwmTEvKceFEdsFjlZZZYLD3y8D2FS8Oc3m00VbmO", false, new DateTime(2023, 2, 15, 23, 54, 41, 471, DateTimeKind.Local).AddTicks(4369), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("485758e2-d96b-459a-832a-6d02dec850a1"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$V7tciVeZXVOB3yOp0vhqXOEve.GrXWiW.AU6ZiRb/H3BaoELnPT.y", false, new DateTime(2023, 2, 15, 23, 54, 41, 192, DateTimeKind.Local).AddTicks(5417), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("48958247-55b3-4802-b910-84f28f84ddbf"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$Be5vLjTbXKwf89Coq7nigu5/BHIsuVTSPf.dxMML1Qs2tQSUYisVe", false, new DateTime(2023, 2, 15, 23, 54, 34, 814, DateTimeKind.Local).AddTicks(7593), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("49ca803a-2e79-45ff-9fef-b152c5517304"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$9ph5tZu35Y4bYPo4szcZRO9Bci0lcwqq/vzWjrMMB/Or5H0mUMyR6", false, new DateTime(2023, 2, 15, 23, 54, 39, 159, DateTimeKind.Local).AddTicks(1126), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("4a90e61a-ed53-4ecb-a271-25f27dddfd21"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$4s0hxYRaPD6TwB27doBaO.0PBRvdRzZSrXDxwYAbyqnNtxFfBZT2.", false, new DateTime(2023, 2, 15, 23, 54, 39, 656, DateTimeKind.Local).AddTicks(7956), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("4bf5d588-bafa-4869-a595-e5707f2e8b46"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$IsqAJF66aLthZXH4n20tZe3GRNJJq6I4cy7RzGsr7mbkUqnV2uSFS", false, new DateTime(2023, 2, 15, 23, 54, 41, 54, DateTimeKind.Local).AddTicks(4895), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("4c0f7cea-c4d7-4eb0-87ca-ea63e9dd3e46"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$HVi0C3K30bq0CRM.BFpF.um.86iLicnnXvFAa8SVCq5KUUUNqNwKa", false, new DateTime(2023, 2, 15, 23, 54, 40, 702, DateTimeKind.Local).AddTicks(3306), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("4e660ad6-1e81-4521-b659-bedb5de78911"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$GJNakiJ1JT4x76tJ3qcRFOLUlWxgvMNaXPbqMTIt3zH/f/JQQnwOO", false, new DateTime(2023, 2, 15, 23, 54, 38, 94, DateTimeKind.Local).AddTicks(7401), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("4e872c17-2017-4c1c-87ef-49ca5b7ea891"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$AW3jpfx/swcjnscC1BVfley/j9WemkeoIaGITg/KUUgWY1XvAFusG", false, new DateTime(2023, 2, 15, 23, 54, 37, 102, DateTimeKind.Local).AddTicks(2490), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("52c12018-c9f2-4711-81c9-d541588d921b"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$OqdFsZSpiGFv0EChRo4oBeJWgOhNgHUTPY1QbIeFKOlG0jMISVAqu", false, new DateTime(2023, 2, 15, 23, 54, 38, 946, DateTimeKind.Local).AddTicks(7724), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("5722f9cf-59f5-4e40-85cc-aeac731b4ecf"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$SF1tmzOX1BPRKs4BW0jZiO0RQWRUSTXGAZ0G4j2qBIfiK3XWkcUb.", false, new DateTime(2023, 2, 15, 23, 54, 36, 20, DateTimeKind.Local).AddTicks(8518), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("587ce45f-043f-4c5e-879b-67231a9f5c2a"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$hYF8Tn5ZdA5aTbo/piw1buM2JJ.A6pGpygSUKBCLgJHj7vSj9frXS", false, new DateTime(2023, 2, 15, 23, 54, 35, 235, DateTimeKind.Local).AddTicks(3801), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("5934e235-a49f-4e5c-ade6-ccbf1b3a4aae"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$mqkUqUAsqFUsMPkGA36M3OE.xAForZafoyqLgbjSb2OX.DBufxEQK", false, new DateTime(2023, 2, 15, 23, 54, 35, 882, DateTimeKind.Local).AddTicks(6535), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("5973e8b2-d2c8-4c44-a4ca-919872ff24be"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$Hn/hwQ4hby/zouzVOda.IuqY0nkALJg6A41Fo6pu8PAE2653041wG", false, new DateTime(2023, 2, 15, 23, 54, 39, 372, DateTimeKind.Local).AddTicks(8573), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("5b85de45-0ec9-4554-94c9-a50f68fcef53"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$UCqbQ3IO/0dp9eEi6a7ET.Uf6tNFEfs/qVfWXTw.rIUAH/S1hMqpC", false, new DateTime(2023, 2, 15, 23, 54, 38, 526, DateTimeKind.Local).AddTicks(9935), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("5ccf8f60-5610-4dbf-885f-d5f58256d611"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$GZ4ynzcNu4KZJPdqWlgNUeChkSuIRxO2Lb4jsxrOmoVo.pPBVNK6a", false, new DateTime(2023, 2, 15, 23, 54, 38, 448, DateTimeKind.Local).AddTicks(4017), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("68f1f3fa-2bec-4bb6-8f52-a82152182c78"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$2gftrdMtKCynrOkpjooKWeREPuQcgpR05FEPdVW9zS0zk8AfZKkw2", false, new DateTime(2023, 2, 15, 23, 54, 37, 599, DateTimeKind.Local).AddTicks(5957), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("6dee78dc-1628-4dcb-b87e-02f9ead56fdd"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$4J5PbmzZpZd3jVXaQKN80OMB6zucn6IU4Kkb2qLfpXCT0JzZHCrE6", false, new DateTime(2023, 2, 15, 23, 54, 37, 810, DateTimeKind.Local).AddTicks(1288), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("6e25c107-6c7d-4234-87c3-724c69f538ae"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$Yh69BvAeRg8Fazl3g6bvg.WfiudNftkt/aehq07gPMf.lnVSYW2j.", false, new DateTime(2023, 2, 15, 23, 54, 42, 372, DateTimeKind.Local).AddTicks(9508), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("6f13ba95-5d9e-4de7-9af1-385260e60efc"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$SYhGOwq2p45um4.ZhGl7f.OcafOuw4rTBkwx6ZDiGSrlBmSBtiTP.", false, new DateTime(2023, 2, 15, 23, 54, 35, 307, DateTimeKind.Local).AddTicks(7456), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("6fc31e73-047d-4e5a-8a26-6ca2336b1fa8"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$98LL.wpNLxsZCB.EhQsdr.3iVND7D/nFRN039lPdbmXCXU6xBxkTC", false, new DateTime(2023, 2, 15, 23, 54, 39, 586, DateTimeKind.Local).AddTicks(8351), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("6ff43d2b-2ec1-4c1b-916b-74c9eda575b2"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$ELQSD5tWywyRDhwrNJjkwO7JL6PiklS//URurnP5oPbxYjk2RRZri", false, new DateTime(2023, 2, 15, 23, 54, 36, 95, DateTimeKind.Local).AddTicks(1169), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("7208f313-4082-4670-a3b2-ebe81e430bd8"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$kMn0/5Wa5CDHdCv8f6gRL.zCTRFBRgEI3Ad0fu9s5QdsmA/IQqQt6", false, new DateTime(2023, 2, 15, 23, 54, 38, 666, DateTimeKind.Local).AddTicks(5641), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("74961cd5-cafc-436e-806d-2322df9db7bd"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$j0e6.Y4KC2zbTauBzg7kk.oJ5o6Ona/6Y16RRtUmCgOgd8tWoxN6O", false, new DateTime(2023, 2, 15, 23, 54, 37, 32, DateTimeKind.Local).AddTicks(7647), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("74b5aaf0-4e35-4521-a1b2-6c594965ac91"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$WVz12pFOapgo1evcZhWf7uRwbOA3hg4DiLnqHhsVFfK4luL34BMuC", false, new DateTime(2023, 2, 15, 23, 54, 36, 235, DateTimeKind.Local).AddTicks(5503), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("7bf53c0a-7886-44c8-9072-1a2a1d83c252"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$Zo6Gl0/AICyCLC1nxYWA0.7NyHoVTY4DEt6kW1dtxV98SO5RSWLOm", false, new DateTime(2023, 2, 15, 23, 54, 40, 72, DateTimeKind.Local).AddTicks(3571), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("7da87185-7f1d-4ba5-b23e-e138ac3fa86a"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$nfAYm9VjZSZ/Xs9OQK3oGeXN4RPWUyXnaoK8KXyk9YXEbP9YSI/dW", false, new DateTime(2023, 2, 15, 23, 54, 41, 539, DateTimeKind.Local).AddTicks(4444), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("81c355b2-7fac-425b-a3f4-497d0fea49cd"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$1RXzzFrNrmH96PY2Pvs5eeulNtWaXjMHDoyhIowokrSnowEzjfGqu", false, new DateTime(2023, 2, 15, 23, 54, 40, 3, DateTimeKind.Local).AddTicks(8238), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("88ccfbf1-971f-4a61-8d29-2912d8228665"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$NvYfK7/wVmNgYfdiE0Fs0.Wdl.K/JxHTWOcVEhpYxLRHpleWNCH2i", false, new DateTime(2023, 2, 15, 23, 54, 37, 955, DateTimeKind.Local).AddTicks(9147), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("89e451c1-abd2-425d-becf-4987ef6e16c0"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$DcjriHG2Lkb7VI7ayy3RNehuvsOjmeJpuxLDtH1J4vr3saN.Engrm", false, new DateTime(2023, 2, 15, 23, 54, 35, 379, DateTimeKind.Local).AddTicks(5301), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("8a31d7fb-7af4-4754-8260-25cbf828765b"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$tm/bVSfCd4rQEdxo0GCFhOQJNQNXpPHzyUvWcde2N6qVDatm7QOZ6", false, new DateTime(2023, 2, 15, 23, 54, 39, 15, DateTimeKind.Local).AddTicks(9423), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("8c014a2f-9107-48b7-8e60-7f210ecb1cc8"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$Kz42.G0jNU4ZMotBZLONiuFE5BrqssiUNYTo7zEd5LaopTchekkp6", false, new DateTime(2023, 2, 15, 23, 54, 35, 166, DateTimeKind.Local).AddTicks(8111), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("935dfc3d-abeb-4db8-917b-0bf137ffd5e8"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$cG7zdUPMDdmOQh/nUGyg3Ov3DFEuMue12m40v95XCh36GfeZh2ism", false, new DateTime(2023, 2, 15, 23, 54, 34, 884, DateTimeKind.Local).AddTicks(5909), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("955b56f8-f3d8-4439-8ebe-a48fd0dfe3bc"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$W8gcLwKBn/rzd5zabDh6aeRfaXz.p56uMzvgg3uetXIyhhM6NPyUS", false, new DateTime(2023, 2, 15, 23, 54, 38, 240, DateTimeKind.Local).AddTicks(6560), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("988ae3f2-24b8-44ac-a942-5bb9ba26288a"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$j/lNJxPObY6vJYszJn6DR.ytmh.eaxvieqjuaLqQWlTtH/X9t94w.", false, new DateTime(2023, 2, 15, 23, 54, 37, 879, DateTimeKind.Local).AddTicks(7240), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("99e1e922-4bc9-441b-8bc3-f4b38d001a9d"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$iT.n.P1kas5drPxrUr3RE.19rgD1xU6WI4iSoeOsZUPg8sLd/kecK", false, new DateTime(2023, 2, 15, 23, 54, 40, 563, DateTimeKind.Local).AddTicks(3407), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("9a64e129-9e0d-418e-bb71-873da4b03ddc"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$LBp2XiXeoiiTs5Q/EAjf2.XAIypU7RJh0sB5QLW5bm9nbg2ap3F.C", false, new DateTime(2023, 2, 15, 23, 54, 42, 231, DateTimeKind.Local).AddTicks(6933), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("9e2d691a-349d-4eb5-9e7e-1c4f22619fbb"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$EzvtkbwfvwadaEWYz7R0e.h53v4opcTvthQgIAuu1x1vD0AoQ4p.6", false, new DateTime(2023, 2, 15, 23, 54, 36, 740, DateTimeKind.Local).AddTicks(783), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("9ed302cc-1017-4615-b37b-0381bbb0ebeb"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$ezR2I.eMmdLMe4R1B2Jl7Ogp0E/m5BRzulrDd1Bp2Hxf8qcbT5Bui", false, new DateTime(2023, 2, 15, 23, 54, 40, 425, DateTimeKind.Local).AddTicks(737), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("9f06d473-060c-457e-be59-f6105edbbd30"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$vnye9fdUw0dRYLJthn7b/uMJf5.QCGJE1n1cPwZWyADQ/YTHktL3W", false, new DateTime(2023, 2, 15, 23, 54, 35, 25, DateTimeKind.Local).AddTicks(3267), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("a279e05a-44e4-4856-a279-83703a8df19f"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$PwctGYEpmNYcr2ctZfPO6.PYjiUhHCSH7QRzv9Bnx5kjz3hl/7CI6", false, new DateTime(2023, 2, 15, 23, 54, 35, 811, DateTimeKind.Local).AddTicks(3014), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("a3919699-0459-4865-9d4f-8816d2a3961f"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$KpC072pmHSymBlaHuFwCqOA1Ray10Byb7W.Ehndch54BJuvHZRWey", false, new DateTime(2023, 2, 15, 23, 54, 39, 85, DateTimeKind.Local).AddTicks(5969), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("a61a07b9-a084-4d0f-b31f-a824d1eb6eda"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$vxw6F54/yFd1YW.t2OQxMuZ.2RS/VhbIdCbvyRhOjcDWqs.MC9zLC", false, new DateTime(2023, 2, 15, 23, 54, 36, 892, DateTimeKind.Local).AddTicks(8863), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("a62cd4ca-fbaa-4696-8017-0f2f274f4d19"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$QMh6brkxclm/sn3blZJuueKUt5KA5bsmtstkGEfoiHHzLrZ4QOSpi", false, new DateTime(2023, 2, 15, 23, 54, 35, 736, DateTimeKind.Local).AddTicks(7662), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("a8b3383a-0e4e-446d-9756-0cb37aa43409"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$NfNAlzZUR7A4NjD4iYTDkuVRPSEVecmbKAf5wfGHO.bXAbqc.r9yS", false, new DateTime(2023, 2, 15, 23, 54, 40, 775, DateTimeKind.Local).AddTicks(6872), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("a8f05761-3e9a-4a77-b065-b9158cd9ac9f"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$u8MvE8cTkiVSSD3Qq95loetbpLBYL/9tjf2.nBOfNOSets04g28yS", false, new DateTime(2023, 2, 15, 23, 54, 41, 608, DateTimeKind.Local).AddTicks(460), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("aa447cb6-7fe0-4a17-87c3-a1c85c508588"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$rSWvfezae9CBLi4PvO5M9eg7Q3Cz1dIzuEgOU1WUlsfGKdqdxOkT6", false, new DateTime(2023, 2, 15, 23, 54, 42, 442, DateTimeKind.Local).AddTicks(9451), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("aa7abaa5-06ae-43bf-bfdc-1558dd586f4f"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$Wqlq.BZ6rF3Y0CVwYRCMxOgEmTKLpEVNC2naT2uS.PPJ5GyDZ43Ja", false, new DateTime(2023, 2, 15, 23, 54, 35, 519, DateTimeKind.Local).AddTicks(8285), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("b22f33e4-9e5d-42e5-8514-dd10516f1a4f"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$sFKiHXniI7/owAknJaFtquovCq.gQLh9aBErq6BgB3.VwcWPDGZBW", false, new DateTime(2023, 2, 15, 23, 54, 39, 725, DateTimeKind.Local).AddTicks(8536), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("b5691c6c-146a-4dfb-8452-bd00fb9403ca"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$BnGyKX9qPNlXSAu7A1op.uns3WdP4BZTGM8D8ivXzXXbCYoAZznXG", false, new DateTime(2023, 2, 15, 23, 54, 35, 450, DateTimeKind.Local).AddTicks(4354), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("b86625ed-c400-4aef-a12b-45243297c698"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$qyGbZhykWMHfaHidjHfzcuYvX9QqAJOr8tCeRLZLAYS.oOMhwRO9u", false, new DateTime(2023, 2, 15, 23, 54, 37, 668, DateTimeKind.Local).AddTicks(2898), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("b8e67bac-aa93-412d-b9a4-9f683fc4ff0f"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$s8GCj7rkeAH7SdF1YI6kfe8p757Uo.NohcAmWNCLSqN2mHH6B.ul.", false, new DateTime(2023, 2, 15, 23, 54, 41, 403, DateTimeKind.Local).AddTicks(3074), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("bb0accf0-810e-4012-b8c3-e1e7c9d4e596"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$9Ob7wOiZ7fb8Oop0.Zf6pemJi9J2qTl7i1I1kSzjSUF7yAWpeJ.DK", false, new DateTime(2023, 2, 15, 23, 54, 40, 141, DateTimeKind.Local).AddTicks(6027), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("bc19d216-c98f-4abb-aafe-0a7750ce34e0"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$25HPs1SfoU72bU9eNUeGS.zWU2deiYNkxcXHBswYtIrGfRoWbw2QC", false, new DateTime(2023, 2, 15, 23, 54, 41, 333, DateTimeKind.Local).AddTicks(6058), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("c0de52ad-db1b-43af-8986-5d763748f956"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$gMXJuQBPkcGOhUjEXynW8eG7rvnfoCwjBdeUXf4z.vS/ZDNMO8dgC", false, new DateTime(2023, 2, 15, 23, 54, 41, 885, DateTimeKind.Local).AddTicks(3815), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("c83b643e-8216-4bdf-a3c9-d3fc47792bf0"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$kn0rnQlUGMb6Bvwbrn6DEOvmzOfXfN.MUSPLgXiHR.CLnsnAKJxQu", false, new DateTime(2023, 2, 15, 23, 54, 36, 962, DateTimeKind.Local).AddTicks(1647), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("c905bedf-1a91-4766-ae78-5f515b5f31b8"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$gGqt59zgwU/0IT6SaLWhFOuoCqrDbZy/no2AqrwGTx9omfxLH6tJK", false, new DateTime(2023, 2, 15, 23, 54, 37, 240, DateTimeKind.Local).AddTicks(5715), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("cb99d134-6089-4861-8c9d-a57dca5bc9f9"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$Y8kqUtC9gXFi5qjoDThpUeDKZ.U0vnNgNRZuApUuyYNgVMqjVUmpe", false, new DateTime(2023, 2, 15, 23, 54, 39, 301, DateTimeKind.Local).AddTicks(485), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("cbace887-6e19-454d-a0f6-18abebf4e6fd"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$TdCa7IkyQRwN4jf9j4iRpuLV1Clk5omMlrKMh/4fkneeqe7Sg3VvG", false, new DateTime(2023, 2, 15, 23, 54, 34, 603, DateTimeKind.Local).AddTicks(4779), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("cc967fa8-b01c-40da-9457-128bacc7677c"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$wWV1LUxygr91F8wRr0cCGOH/mkI8fun78jeSoenCNLro2R7XWRxgC", false, new DateTime(2023, 2, 15, 23, 54, 42, 92, DateTimeKind.Local).AddTicks(9422), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("d14ab06f-5e91-4ae8-bf91-1169ce0afeb1"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$m/xkZq3vE1YTzr3rF3knlOSD67b4kzwzUBLY5sbjyuFXG./b.Rt4u", false, new DateTime(2023, 2, 15, 23, 54, 37, 171, DateTimeKind.Local).AddTicks(6295), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("d1946468-4e96-47f3-8d92-6aed62860456"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$eCKz9Kwz7DZjm3BTT0xbqufLHIUzcvSIbVw9QzXf/aamM/JgFFhiW", false, new DateTime(2023, 2, 15, 23, 54, 41, 953, DateTimeKind.Local).AddTicks(6717), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("d1ddb657-de2f-401c-a71c-d5d62a4485af"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$hoLFIpW8txvwrKFi/pb2MOv34eTHRKmE1N.pUAR5eePHEgDcKNtK.", false, new DateTime(2023, 2, 15, 23, 54, 41, 679, DateTimeKind.Local).AddTicks(7233), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("d29ea182-bd61-41a8-984c-1b0304ac0a45"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$tQWMA1HtbBREjEeQXynSyOHjqVNHG1q/zi0jkt23hQ6kuvEGyILri", false, new DateTime(2023, 2, 15, 23, 54, 41, 124, DateTimeKind.Local).AddTicks(5126), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("d2e5759e-325b-4b8e-8336-6a43dd0f21af"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$EMKCau8MaKxPr1IA/Nsr5.AVYfkfULqcSuPmcYYsjhpShaPNVfUDi", false, new DateTime(2023, 2, 15, 23, 54, 34, 954, DateTimeKind.Local).AddTicks(2636), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("d45c3213-1810-43c3-adf6-dd5c8f911470"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$8jot0AgSJERfd7EEwrz7Tug.bN3k3jYEmYCo5gYNoPmR6a9spGkdi", false, new DateTime(2023, 2, 15, 23, 54, 35, 98, DateTimeKind.Local).AddTicks(70), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("d5418868-93d2-47bf-a737-875d55f0742e"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$PYvgezU6JGGLxWolWmdt6.2y2kgJ04q652EOXw7SbXpFbU3QfOz26", false, new DateTime(2023, 2, 15, 23, 54, 42, 22, DateTimeKind.Local).AddTicks(1028), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("d5d390b5-bcc4-4cc9-a5a1-e7df5ad7a842"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$xflNSEGl7fRD9W7syD5mLenC0s0SMmNJmTB/2u8Z9sZxeEh22vv4O", false, new DateTime(2023, 2, 15, 23, 54, 37, 459, DateTimeKind.Local).AddTicks(6112), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("d79ba0a1-b5ff-4804-9d76-154ea5582bf6"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$mukif6reVqSz5UFUf2XmceZq49hLNTBnuvSEQiEAN7nVqTnIR2Fm6", false, new DateTime(2023, 2, 15, 23, 54, 40, 349, DateTimeKind.Local).AddTicks(9127), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("d9e192e0-e40c-48a1-b646-993a8f5a9666"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$DTYSTRq0srUL.c1E.ib/ouhtGKXEqy/OfJ7UUQqS5aQqqItvCChX6", false, new DateTime(2023, 2, 15, 23, 54, 38, 378, DateTimeKind.Local).AddTicks(9726), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("dd9c3305-fb74-4794-99ad-7b1fab7fa80b"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$FkOOQcUOkwzv7i4RcqFe5uLY57r5I9wNiWUIiOfPj4iLpHI3N3F7.", false, new DateTime(2023, 2, 15, 23, 54, 41, 747, DateTimeKind.Local).AddTicks(8362), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("e1e9a269-aa0f-4fd9-8aa4-1540c98b7f19"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$7n/Rx4c1nRbutdbqk.Jxlu/s9vaEa6o7fgXwVwCEGBWwOtew6KzI.", false, new DateTime(2023, 2, 15, 23, 54, 35, 952, DateTimeKind.Local).AddTicks(527), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("e395f7f3-6be8-4de8-a486-339fca7bc345"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$t5B1g1oZN11qj4o7g61THuEdrJbEV1aU0O3nkLDnJkfSW.V/B5hWG", false, new DateTime(2023, 2, 15, 23, 54, 39, 795, DateTimeKind.Local).AddTicks(5596), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("e5a8eec3-6dbf-47d2-a875-9df78ae43302"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$rMewZ1W/A0aLTw2f4sWb5.HB5bUcGhlOwFsUs0OQGaNgkjUqL9FHK", false, new DateTime(2023, 2, 15, 23, 54, 40, 845, DateTimeKind.Local).AddTicks(1721), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("e60190a7-b5a6-4ff7-b650-fb4905000853"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$80bsifiPYXNRpFnKH5IEueaX9L81I/nO5aj.nVMcHUxHbHNDtt6q2", false, new DateTime(2023, 2, 15, 23, 54, 38, 172, DateTimeKind.Local).AddTicks(1423), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("e6b9f294-1e5e-472f-b839-cb63450d1c98"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$nl/BfFFUyE2vCIdsUOqtYeuBkb/svxDcR/6hBaB/s0U9WU4TEdeIS", false, new DateTime(2023, 2, 15, 23, 54, 36, 669, DateTimeKind.Local).AddTicks(6896), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("e8c641b7-8466-4f77-aa39-b78023428e7c"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$6.EfaCSrXp0m/uyFPAOnNOstnr2/A/ZZOmAyo2r7uFG3UD4Q8WNDO", false, new DateTime(2023, 2, 15, 23, 54, 39, 933, DateTimeKind.Local).AddTicks(9021), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("e95a9e77-0a06-4b3b-b503-7e7f86582d38"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$CaERS9k7jOmorJ3PlAEm4us0RhbSpmUxdetB5zfPcX.TRcBkHXPqi", false, new DateTime(2023, 2, 15, 23, 54, 35, 589, DateTimeKind.Local).AddTicks(6408), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("ea97cfa9-3d18-47f8-8785-59965f5b1832"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$uO5RBJbz2NVV.UDrgKLCLutVUoAkWS0yNFEgXOh0UDe3m8sIWORWy", false, new DateTime(2023, 2, 15, 23, 54, 37, 529, DateTimeKind.Local).AddTicks(4787), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("ecb7438d-7803-4db4-8f1f-6208e59d9c5b"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$v9pxV8pDtKyA2cbgP/uqOuJ1n2nPyXklr1cu76pqXux4jKhntvBje", false, new DateTime(2023, 2, 15, 23, 54, 39, 517, DateTimeKind.Local).AddTicks(9906), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("eddac32f-0222-45cc-bf30-cde749ebb00b"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$YEQj3zuQJxEp.TclwOEUI.yecJTgwfkAqZcfjRnpRzceTb0vUXLeu", false, new DateTime(2023, 2, 15, 23, 54, 40, 280, DateTimeKind.Local).AddTicks(5540), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("eddbd3c5-0ff4-4180-a6f7-80f199b395ed"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$OY/b4pKDL5oDgqJi4y4NpuiX8srw3poR8DuxWqCe76BRKfO3l9oVS", false, new DateTime(2023, 2, 15, 23, 54, 38, 738, DateTimeKind.Local).AddTicks(3950), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("ef3fa92a-759d-40c7-b5da-5f49dec4ccf8"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$6.qVJJpmXruIHtgruoMD0ecghZ6C.HQ4qopV3QG61Mjr.fpfuVbTS", false, new DateTime(2023, 2, 15, 23, 54, 36, 164, DateTimeKind.Local).AddTicks(6304), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("f05a0dfa-743a-485c-8216-6fdf3101797c"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$/VEBeuvEOk.w1nqTtb/8KuWpMQQNx3L8vuZ2Os/z0asxdaVdgmxoa", false, new DateTime(2023, 2, 15, 23, 54, 40, 494, DateTimeKind.Local).AddTicks(4924), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("f1156cdc-88fd-4f63-91de-aa002e282e0b"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$MRAutt9haGKGuhhqLv1Ru.CW8p1qWtE3.K0My.z.fGdvtNYbTd5.G", false, new DateTime(2023, 2, 15, 23, 54, 34, 745, DateTimeKind.Local).AddTicks(5810), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("f25a97e2-3e1b-48a7-9b38-fa7e6883219a"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$f.VpjejFD1yv5DYiWOfPR.uFuQ2njLbHt.WlHXCPoitLJDqwzuiSi", false, new DateTime(2023, 2, 15, 23, 54, 34, 675, DateTimeKind.Local).AddTicks(1337), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("f3c145fb-e04c-4046-a76a-56f0a30a7283"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$Z4Pe01i/hBVCyzuNa2K31uzPB60F2fZYQu/y2LrRfGI5ExpcksNYu", false, new DateTime(2023, 2, 15, 23, 54, 36, 308, DateTimeKind.Local).AddTicks(1905), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("f3dcadd5-4216-478a-8bed-3685fa57ecb1"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$SNVnZz91xj64PotgzLX8SOa8TkjaAHiSOlffMK1obrPubLeQbTyqO", false, new DateTime(2023, 2, 15, 23, 54, 37, 380, DateTimeKind.Local).AddTicks(6347), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("fa6c5309-75b5-41b3-ad38-1ed4850cda70"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$jkfvjqPwgDhiZceAHUg.R.RyooqFraumQ8/mUBHuEuR5JZJlEbI9S", false, new DateTime(2023, 2, 15, 23, 54, 41, 815, DateTimeKind.Local).AddTicks(9696), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("fa745c30-4924-4d82-9349-b261e1cdf04f"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$wLkIUXF.YweeuhcrF3qPue40fyMnPSxjtbhnTjH184UxZWEKjYh7G", false, new DateTime(2023, 2, 15, 23, 54, 40, 983, DateTimeKind.Local).AddTicks(4214), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("fee67f2a-f9ce-41fe-80bb-90c5f2dcf80f"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$y04Vs8K2df7CRUXRrVo3tOqCZfkZYhROkP3nRbXBEZvf3/D9JKSRm", false, new DateTime(2023, 2, 15, 23, 54, 39, 229, DateTimeKind.Local).AddTicks(3559), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("ffdf50e4-4dc2-41b0-b55f-f301a4cbc420"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$u1P1tcP1pDU3d9lteYt6LeLHXvzF/FrLQYR9eGMc1QKJbmLWv/e3u", false, new DateTime(2023, 2, 15, 23, 54, 38, 877, DateTimeKind.Local).AddTicks(6388), "Hannen", null, null, "06533305742", 2, "channen1n" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetail_TimeFrame_TimeFrameID",
                table: "ParkingDetail",
                column: "TimeFrameID",
                principalTable: "TimeFrame",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeFrame_Parkings_ParkingsID",
                table: "TimeFrame",
                column: "ParkingsID",
                principalTable: "Parkings",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeFrame_Users_LastModifyByID",
                table: "TimeFrame",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");
        }
    }
}
