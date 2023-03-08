using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver178 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("2f4a29b4-dbe0-44c5-b633-0fb41cae171c"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("4cb5df24-221e-402d-9283-7577f8f9fa1f"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("6f7232ac-619c-45c2-a7a7-412f6ab8feac"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("7d830af3-d501-4f73-8ff4-5c2b9ea0b5ac"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("a609bc85-c32e-4989-8bc9-c09efd6616ae"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("c20529b5-c876-4493-b314-d830c0e47603"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("8176ceee-caa6-42c0-9f31-3e66731e575a"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("8d6f1a17-e75e-437f-bf5d-b76a9a445e1c"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("b345dd8b-cec3-439f-b1b2-4535937ce04e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0296661d-fd04-4358-9603-7a0ac26e7ad0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("046bc6d4-74af-4668-ae8d-9ab70e08c3f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05fc9de1-e343-4a6f-ab08-cc51167e9d42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("15e612dd-ac27-4b39-bbc8-b736a20db326"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17126f2f-878a-4215-b377-678ed0d17387"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17226789-5b99-4f0c-b3cd-cd64ca4c3f60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17b8df4c-eeff-4cfe-8484-98a8347a2fca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1da54cd6-7a30-4992-a53c-7f40a540be44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("23ce00ab-272a-4ae0-929d-50ed80a8117a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("240abebe-916e-412e-97ab-7e13b2c364d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("242f00a5-c9b9-4d8a-afed-7d5edfd4810d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2497af69-9f17-4401-816c-9a7e75240fa0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("27a16918-1f53-44d1-84a7-11875fb7a262"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2caa8881-bde5-49a1-b678-a17af9a5660f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2e625470-0fd0-4b77-a911-4617bb157701"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f568284-42a8-4c3c-b82c-b938f309c0df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2f74dc83-cdbe-41c7-83e4-c727ed023e9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("31d877d2-2ef7-4882-8497-6351036c383e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("327c1fae-7f93-4ee9-bb4c-4997e08fd542"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3291fe2c-d67d-498a-95ff-cbb9efe2266c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3555b85b-374b-40b4-ba6b-0ce43ef5aa65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("36a86eae-a3c0-48e0-96f5-41c9732e9127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("36e067ca-3832-4de6-ad82-a86a6e70d01b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("38e63c88-d62b-4ab6-9e9e-3303c33283e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3ce555f4-184b-4490-a9d3-a484d72bd5a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3e2b76b3-cdd9-45b3-b8cc-ca6ae28fb07a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3ef27aca-9a6e-4786-8ec0-957ffd4cd355"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3f9083b4-2d56-486b-a818-c49fc38b30d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("469ec473-5b2d-435d-849f-559c6e27aa08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("46ff1a64-6920-4f14-b8bc-750ae0c7714a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("48002b45-65b0-4d38-be5d-b46243aa5e05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4f140505-d89c-47fd-8d30-c01d17bacd86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("50fb2ce7-22ab-4294-a54d-e8346fcc47a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("55d7bfbb-030e-45ad-8a57-01026a116e51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5b5bc0ae-6c7f-4600-b123-3a89da6d71ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5bf3b881-0216-4c7a-ae79-7ef6c2d8989d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ec228bb-bef8-40f1-abe5-b19a285676dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5f6b6189-af53-4ca1-baa2-6f16089eafde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("614083f7-11e4-4494-b1f4-0e939bb11dfe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("66e39412-1b21-4c0e-9529-fed2b03a3d39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("67391340-9165-4aa8-bcc6-dfa2b9b359fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6b09bf07-4c41-4343-a6ec-8f99ccf6b079"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6b6509f1-eb85-4cb8-afa4-e212e6c6eeed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6d9069ab-3598-4de5-851d-11fb31b4e9a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74fbbb8e-4b69-4085-bd60-f91601a76f5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("76d4193f-1cdb-4b3a-bb13-b9d037efc7a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7a838f4b-1c30-415a-a31c-f4b02f28de53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7b149f6c-7eaa-478e-ab44-7a3728927434"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7cd93494-06ae-4ada-af2a-6f00362b1887"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d8b49f1-216e-4a10-b217-7dcd9d6ff034"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7e82d339-2770-4333-acc9-39493fb4ce5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("80a0e556-1fe3-4c3f-9978-833cd4b756c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83981925-6ce6-433a-8f46-f0158bb2364d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83afb878-c8e0-42f0-9783-976e1ca4ffd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("847045cb-77c9-4b34-881a-c02711f3b1d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("89aca45c-b796-44b9-bc6b-9f4e28e3e126"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8cfd128f-48be-4498-9b9d-32a8b8ff5f4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("949817cf-6da3-4a29-bc45-c2b81f9c98e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("958f0b21-8c36-4e2e-aee9-4460d74924a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9871d1f1-b516-4c03-8e1f-68060a451a83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9afa117c-4f22-45bc-a55d-a411abfcb22e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9e9b6c13-7cb1-42bf-bc40-d0ea236f4e67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f30cec6-2472-4fb7-9735-fa08bf340d10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f4bad8f-bb37-4008-be0a-5f26aaef9bf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a2e9c662-c943-4887-a3b4-c02c38375db3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a4d93d23-244c-4b1d-adf7-609e09e982fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a7366bd3-8c2d-41f6-a036-c727ebaf5b6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a7acca7a-6765-4446-b230-4abc0d73bf66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aaa6e4ad-29e3-4ce9-8c9c-b5df5f846e1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab164413-1801-4154-8c0c-8f1782ae4880"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("abc9c256-39fe-4a81-b83a-8d08d8f2dd28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ad4b2ee0-93dc-4802-89d8-cca5c8097d60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b5f484ae-c77b-4dd4-987a-d3074c3ed036"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b669568c-467e-4028-9c46-cd11451c053b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b857e605-2dab-4b9c-a95a-e89ba530ea04"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bb1faf4a-6143-44a7-8b0c-79723daaf238"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bc42eaf9-1b7e-4138-b053-19ac4e9ec1ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c463af87-900c-4780-94cc-7ad75d35f148"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7bdad93-6338-487b-8a5f-d89e5940398a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ca804158-9deb-4593-b9cd-6549407317a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cc0e0773-0175-4a9d-a618-b196ba9026ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ccfff54b-1ba0-4aa7-8fa1-e4b0313e3741"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ce4011dd-0801-4900-a550-7f77c7ccf4f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ceaa0de7-2507-41a1-8cf4-a44837cc3e51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cf6c24eb-55ac-4eed-bb03-b324b761e965"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d06c78e9-a805-43bf-8cc8-a973eddb439d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d0bd9e0b-e435-4e99-8cd4-29843e51cb05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d33ae76a-fffa-4055-8cfc-54bf852f16cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d58b2509-b306-407c-9045-a3eed8a1bda5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d6d7a3d5-0d43-4ee8-9b0a-a7a5b5f86859"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d8ac6170-bd39-4d20-b29e-52f37d20e785"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ddc76b80-07ca-4987-8309-dc5101da5a27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("df3453e2-d903-4546-9b01-49310d5c5b2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e01cdce2-8662-4559-bb2a-093ee37c9047"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e0274120-3714-4aa6-a509-f9364f27ab99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e0ae4881-b83a-4f36-ba27-5928af789d21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e0b5e076-d115-4341-8639-a3438c965a52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e17b36ae-a505-44ed-887e-2b6907fcc76d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4d70b68-227e-4b3c-a8f7-fa691770abad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e56aee9e-69ff-4666-88d3-936da0a3b583"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e9a3d8e6-1caa-42d3-a03f-d83e6efe6b3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ea234077-bf2c-49b2-a04f-be098396bd07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eddd403c-5120-48f5-a6fd-dcd4b3831200"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ede138ab-ea56-41b0-8e2b-cc963a484db8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eeebba58-e1a3-4ce2-9aa8-aca3e3b8c245"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f0586e5b-3221-4d19-b279-4cb57e6c25fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f55824fa-d937-41e0-8ba3-bd74e02fcaa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f656fe11-f258-483d-9bc0-415e755d6e56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f66e4100-2777-4793-8fcf-e30478e8d22e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f784c439-07be-4355-a633-44f64e718f00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f7b30fe3-b819-4b68-a74d-f80ffb6a2362"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fb6d5c59-5741-434d-8572-72dc612cb93e"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParkingID",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("43ec4e47-e993-4421-a876-173b569f6974"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("55580a18-62ee-4cb5-9099-d7d154693f47"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("62df047c-6ff3-4ed0-87bf-41d62f0e5a1f"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("6bd37165-81f0-48da-846d-ef67c3879028"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("8821e9ae-ceea-4912-903b-88352bfdb050"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("fd3c84c4-76cc-4431-97ec-82cc54b7af49"), "Xe bán tải", null, null, "Pickup", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("4a754282-9498-456b-8ce3-59f27c151140"), "Half Year", new DateTime(2023, 3, 9, 0, 4, 35, 113, DateTimeKind.Local).AddTicks(8987), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6b0fc88-94a4-45bb-9271-466fc2dbb16c"), "1 Year", new DateTime(2023, 3, 9, 0, 4, 35, 113, DateTimeKind.Local).AddTicks(8989), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d13b3ece-38cf-4e7b-8e60-8fb2c75ec759"), "Short time", new DateTime(2023, 3, 9, 0, 4, 35, 113, DateTimeKind.Local).AddTicks(8981), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("0b3ff8fe-13ed-4afd-bfa8-316eabb4df48"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$xag26TNFufYo3ef./ARH2exYhR4v4vlX/RG9q63HIzmSLZ7fPeJTe", false, new DateTime(2023, 3, 9, 0, 4, 33, 225, DateTimeKind.Local).AddTicks(3442), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("0ba114bf-1ac6-4e46-a9d8-adbdc7df3816"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$1JlcaWyOAehRzLrxDGFFUuPZ2qIOiDg3C7BSMK6.wkivR65nAEn1y", false, new DateTime(2023, 3, 9, 0, 4, 29, 685, DateTimeKind.Local).AddTicks(442), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("0bccd85c-850f-4ee8-b9ed-89bc0f2577b8"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$hXdikQcGi9DT00uBWDyBWuuyT0hvBHMQjAdHurpBw3x9uP4Y.4R0e", false, new DateTime(2023, 3, 9, 0, 4, 29, 608, DateTimeKind.Local).AddTicks(3458), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("0f87bea8-f43d-41a9-bab8-502cd5873f18"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$AFrgkRawqZMkmgxfa5lKBu49S2QUaIWC/lW6wBp0rGrq4/ECcbTwW", false, new DateTime(2023, 3, 9, 0, 4, 26, 6, DateTimeKind.Local).AddTicks(6448), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("119b9d47-9950-41b9-b837-bb4478b9f109"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$vRBHl4zcaXairmOcVatzx.YtnT5eq.ETAz9fMtAsCZIt9BZvw5OW.", false, new DateTime(2023, 3, 9, 0, 4, 34, 207, DateTimeKind.Local).AddTicks(9325), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("12f07579-47a8-4942-ab6d-1e32cf562421"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$TigaCVCEvIHCskvf7eNtmOQS8HrhREOKKTgpa8E/zpMCZXFMZjm2C", false, new DateTime(2023, 3, 9, 0, 4, 28, 908, DateTimeKind.Local).AddTicks(6808), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("1506d507-4c32-43fb-bb23-4e53ce96fd24"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$7s2XqW1rRHSueZZmffpD7O2m2VJ1vFILQUkjwBXKY1bPz3vFxA5MW", false, new DateTime(2023, 3, 9, 0, 4, 32, 134, DateTimeKind.Local).AddTicks(2166), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("15b9a6c8-210e-43ea-b75a-03d55981a31c"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$hyc2JUv/UuQf3aXrwKO4Tey4nPjQMEBbloNSBEu7UAbBNsSVVptwO", false, new DateTime(2023, 3, 9, 0, 4, 35, 113, DateTimeKind.Local).AddTicks(8398), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("16404a44-88e1-4eb8-b2b5-1149fdd037ea"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$ULXO7495ibphq0AANze03eZlyu.mlgfhkKsShLSLwQONGYzgpkOV2", false, new DateTime(2023, 3, 9, 0, 4, 27, 803, DateTimeKind.Local).AddTicks(7605), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("189b24bc-9be2-40f0-9eee-2e19b4a40ec7"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$s39xVSblTkGgZiovFy1oFergBUgOC/Y/.i4CqPJgYSwWekQTrObDu", false, new DateTime(2023, 3, 9, 0, 4, 33, 925, DateTimeKind.Local).AddTicks(9420), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("1964466e-8e8d-4ba7-9d66-20684cca26e6"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$H0943N2CYCg3xhfR75k.guI0JkvIe0OYnZUvSiUzCtSZ3XfY96Bxq", false, new DateTime(2023, 3, 9, 0, 4, 28, 449, DateTimeKind.Local).AddTicks(8904), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("19f8b245-1c39-4835-b4c4-05243a5e0516"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$MMhdabfFCKAiAhwwQ7ilHeoUNz9hDd6yc1uDQkUjCLiKuN6P8kstC", false, new DateTime(2023, 3, 9, 0, 4, 27, 236, DateTimeKind.Local).AddTicks(7922), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("20691608-d85e-4afe-ae8b-1fd6a7bc0ae8"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$fT4z6WmJGLqlffr3y4coCek2AZu6Bmayd9LhqgVam0l6xMi/DdgIC", false, new DateTime(2023, 3, 9, 0, 4, 26, 589, DateTimeKind.Local).AddTicks(5056), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("22bf8c91-e8ad-493a-8a3c-4782e6090438"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$kstqSXIuYBMlmAIhznHAYeW.CK9MFaJKn6En7H1svZhR6c/Z56cPy", false, new DateTime(2023, 3, 9, 0, 4, 26, 770, DateTimeKind.Local).AddTicks(4907), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("27ede62e-276d-45c4-8fb8-55ac39e8fdca"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$UNpWWQ5pZLVikbPiDHaJE.P/kqAbTtJLMi7G9eqmS6bv9CoItzcoG", false, new DateTime(2023, 3, 9, 0, 4, 29, 532, DateTimeKind.Local).AddTicks(3527), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("28dd6be6-e112-471b-ad0d-e9149bca4f51"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$ExvkUqPQVf.6lrVNx2/16OE9WLOoKU/CcmrDSpcrjfZB1q75KW7.a", false, new DateTime(2023, 3, 9, 0, 4, 27, 77, DateTimeKind.Local).AddTicks(8954), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("34722266-b687-4974-b952-f59396fe184f"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$wo4s.WwzImnV2hiKTL0HeeA8OJ3DURp46c3iq8ceEQxslbIl3Mgju", false, new DateTime(2023, 3, 9, 0, 4, 35, 35, DateTimeKind.Local).AddTicks(1907), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("34ddc59d-10a8-4e57-853f-dd09d662e63c"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$auVrBmB4SbTm/pW3hch5P.dJ2TMkI4jPKPS3nUOk7DSoWNsVJofQW", false, new DateTime(2023, 3, 9, 0, 4, 29, 918, DateTimeKind.Local).AddTicks(4322), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("382c0060-f87a-4f92-9695-594df0569746"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$1KJWXvzwseTvuIn5huaNUO.y5ANtjRC4nrXaFNS5/SZqJT37rADRq", false, new DateTime(2023, 3, 9, 0, 4, 28, 757, DateTimeKind.Local).AddTicks(8798), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("3b7fe7f6-1d1e-480c-9032-488521f407c2"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$QnpPWYBwF4Q13BrIzL661eifTEA6Nxw3vY/L5GsL4lethknzKOziy", false, new DateTime(2023, 3, 9, 0, 4, 31, 203, DateTimeKind.Local).AddTicks(1995), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("3c8936da-0366-42e8-ab9b-c82760a064ea"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$.4n16blhmUylsUnSqg8FcuKVXfBIO.csCDpM43ToCoqtAKPlj9LaG", false, new DateTime(2023, 3, 9, 0, 4, 32, 829, DateTimeKind.Local).AddTicks(741), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("3c8ac11a-4417-4271-9103-17de5ffd1fa3"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$CEOdgp6QyPnnJkHJXZCrju.X/K.qxH/b4RK6D56mAIbo6UH1/yur6", false, new DateTime(2023, 3, 9, 0, 4, 26, 849, DateTimeKind.Local).AddTicks(6377), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("3e265a8f-683c-4ec1-badb-db8abca0af97"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$VBvTFyHDDmD/ltRYdgjj0un7qKjMWllWwSEFdwdrlWMtLyOBm6p92", false, new DateTime(2023, 3, 9, 0, 4, 33, 333, DateTimeKind.Local).AddTicks(4522), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("3efa4c9a-fb95-4378-be16-ac57a1877109"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$e76pPc4SCyk/BZfxAAcma.Ln/2BmjBueT9xwkxI72gYi84tf7wPem", false, new DateTime(2023, 3, 9, 0, 4, 34, 706, DateTimeKind.Local).AddTicks(9889), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("3efe37e0-7808-41ea-972f-63c5363ac9c7"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$8gxWb5OmSe4KcUNxvwZji.nUgNf4KzHMutqFq9BZiYiMwapma68Du", false, new DateTime(2023, 3, 9, 0, 4, 31, 668, DateTimeKind.Local).AddTicks(7244), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("402a6bc0-6f4a-43d7-8b25-3e98edca28af"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$5eRgeJIHiYICmhF13rlKIuWm89aNY1Hewyafb/RQMHH5Xfarlwo9.", false, new DateTime(2023, 3, 9, 0, 4, 34, 108, DateTimeKind.Local).AddTicks(7100), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("41a42c31-2b98-4635-9998-1c6cb36f235d"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$vnOX65d8VvCoxyEyTP88kOIMb3GEpszBO1OZEeWwNAQwhAoL5zi76", false, new DateTime(2023, 3, 9, 0, 4, 32, 213, DateTimeKind.Local).AddTicks(7701), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("4480fe76-a72d-4bd2-97a0-b9e65599476d"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$eU/m.CfJInLGnRfQjPkTvOuxr7vW073Gis6yoEPjEyknC/CeFcxXq", false, new DateTime(2023, 3, 9, 0, 4, 34, 439, DateTimeKind.Local).AddTicks(7939), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("459926c5-1319-42de-8415-0a02f5c1d460"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$aWY82XdtFcuf.TamO4.xAux79S1WzMHtgBmD2Pc4tsYSjbWlh7Tba", false, new DateTime(2023, 3, 9, 0, 4, 33, 415, DateTimeKind.Local).AddTicks(244), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("4833a8f6-99eb-44f5-87d1-80f6dca57887"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$NAEpWDh16Ig3yf6k9rvFmO5ABDiGjxckii8cctlw4DLf39OVqp01G", false, new DateTime(2023, 3, 9, 0, 4, 27, 2, DateTimeKind.Local).AddTicks(8703), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("4d639595-27f2-48c7-b7da-81cf6a2e0644"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$hb9TbMhGxCJ6HGw42UNDh.QcS459vusv7z7hKutw/5FZxL1uKKYVW", false, new DateTime(2023, 3, 9, 0, 4, 31, 977, DateTimeKind.Local).AddTicks(7774), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("4d7e054b-626a-487d-9ca6-562b2f8efba5"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$O9eAI7Hib7944brdPTXkIe7hQOb93SXiFAYcpmQThYjH2GRBKIJEC", false, new DateTime(2023, 3, 9, 0, 4, 31, 432, DateTimeKind.Local).AddTicks(2761), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("4e563743-75eb-4d1d-b93f-e5bbf85be0b9"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$WIOQ8zUi3cllVRu75MII1uhfV1hzNYwIp07wjpEhnxTx/jrYvg79W", false, new DateTime(2023, 3, 9, 0, 4, 34, 803, DateTimeKind.Local).AddTicks(3737), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("50149f8e-60b6-48d7-ab35-7b34035990ad"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$Laf0XmmXpBdvyec643JcGeWJIbNgim20Qu4eqsKoE2cESkg57oaKa", false, new DateTime(2023, 3, 9, 0, 4, 31, 357, DateTimeKind.Local).AddTicks(3426), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("546f02c0-7a6c-4abe-813c-2e2b8e288bcd"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$kU6ILBt5MM0J1SRFt6QEAeHa0.xt06VRLlfliGR9PGR6U/LtZXruO", false, new DateTime(2023, 3, 9, 0, 4, 34, 286, DateTimeKind.Local).AddTicks(690), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("57a79f97-fdfa-470b-843d-29d99beb336a"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$1U.e8T9qbYsXaf7zjHDnNOjIQJx1kkYVY3MOgvI2acVMTRqzuFq2W", false, new DateTime(2023, 3, 9, 0, 4, 28, 988, DateTimeKind.Local).AddTicks(6104), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("5822f8a5-e9ca-4994-9b69-3f7305862f9e"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$OyNFk.p1ilaUTkF1sNpUvOUJMzpJLsqIAorKriQcUBg65beUVduOS", false, new DateTime(2023, 3, 9, 0, 4, 34, 881, DateTimeKind.Local).AddTicks(2622), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("5a85385d-81e1-4279-b8ee-2193733fa602"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$ToE873VcUtnHvPuUjkjvfes4H/wgJZXeE/4EV4QdIfuEVmCwCKzWa", false, new DateTime(2023, 3, 9, 0, 4, 31, 123, DateTimeKind.Local).AddTicks(2368), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("5aa08667-c76d-406a-8924-1284e00c460e"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$2VfQcyZl.yZ7LPmqewKdfeYKowk08Dyam5th7WB6EPDeH/67BIzOC", false, new DateTime(2023, 3, 9, 0, 4, 26, 478, DateTimeKind.Local).AddTicks(6194), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("5bb9d614-a543-4cb5-aae0-1c419e17862c"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$bX/FM14pJ25G5f9zGzmIoewCamwGDyQxpJbwkMGyoot5VxKDDua52", false, new DateTime(2023, 3, 9, 0, 4, 26, 185, DateTimeKind.Local).AddTicks(9773), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("5f89f8bc-257b-41b9-8d7d-cbe437069d31"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$Xa7ZzNxiFj18EzkWTB9bOejLXm7RkJkfDsAFETigBLG85ZfsTioYO", false, new DateTime(2023, 3, 9, 0, 4, 28, 269, DateTimeKind.Local).AddTicks(1515), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("62902bef-eb17-4626-9ddf-2da6f6ac93c7"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$C0SRwVIPZbePAPTu3KVyFOonFyNhCVfKzywvYXN4mSyv.OS/e1kdi", false, new DateTime(2023, 3, 9, 0, 4, 34, 958, DateTimeKind.Local).AddTicks(7594), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("666e8b1d-0750-4229-a02e-e0d5227e71ad"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$cRSxU/GlhJd3fEMWDg7Ez.gLznetLmiuEhpKdOclSYFPBobO9AwLy", false, new DateTime(2023, 3, 9, 0, 4, 29, 374, DateTimeKind.Local).AddTicks(8677), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("682782b4-d879-4e05-9b61-a3605efa9954"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$eQTcqlIflQa9EKeJZ.XgAOFGSWtvJ1ihNWeVOz.pYAVEpNsmnGKty", false, new DateTime(2023, 3, 9, 0, 4, 28, 189, DateTimeKind.Local).AddTicks(2458), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("68eb680f-0367-47b2-ac7c-0f4f4ba84cca"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$GBbgDBHjO21Ohp8yDLlIf.a1GZCNpHejUm87fT1tzZtt95KCKSLNq", false, new DateTime(2023, 3, 9, 0, 4, 31, 43, DateTimeKind.Local).AddTicks(7685), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("6aa7c97a-f42d-43e6-af12-bdacf43f7a3d"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$Bypj0nLTS3iFT6EKwwdSguANG8MTbfr.o.gpoq4bfcfSFObtQSiv6", false, new DateTime(2023, 3, 9, 0, 4, 27, 882, DateTimeKind.Local).AddTicks(1117), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("6c2a815f-8e0c-4f01-a411-5c4829a98af9"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$DmoxoNpYPBV2NYJ8chqTG.GRp0oySEFXXgMV4VNa4lostNVXmESG.", false, new DateTime(2023, 3, 9, 0, 4, 30, 887, DateTimeKind.Local).AddTicks(7486), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("6c8bf3b7-2c59-4cb1-8f21-c1d9a6af653e"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$9ZQuxn4HpqOHZrc2xRfkSeIljZS030eO/NFHRzrJBBE/4UxyV8Vr6", false, new DateTime(2023, 3, 9, 0, 4, 28, 37, DateTimeKind.Local).AddTicks(2826), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("6f283482-b0b8-4494-945a-e875e85aa237"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$jtz0R0yCbxnMyDZa79J7F.QK7ZDGWcsQEu9556lzi12Tco4dyTUE.", false, new DateTime(2023, 3, 9, 0, 4, 30, 236, DateTimeKind.Local).AddTicks(8969), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("727b2fbc-37bb-443e-a519-ce99e7c21ebe"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$HRs.UY3iOTLWy.stYgTIH.KrXMCPnXMjZvVoi.skZxflInHVjWVwa", false, new DateTime(2023, 3, 9, 0, 4, 28, 527, DateTimeKind.Local).AddTicks(9221), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("7cf3196f-f0db-4337-922e-2d167d30a10d"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$iqhvsIosq0yse9S7gGIhl.FlnAoAoroNyycjOW7Zek3DFLGyTR3PG", false, new DateTime(2023, 3, 9, 0, 4, 33, 135, DateTimeKind.Local).AddTicks(5705), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("7fd558b7-e6e8-4437-bae6-79f321c62aa3"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$tgKTzZvhXpzQkOXd0q9dUuuG1IDSWQVxJDii4TyC6wHtwA6iDXP1a", false, new DateTime(2023, 3, 9, 0, 4, 29, 221, DateTimeKind.Local).AddTicks(7428), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("80715813-424c-4ff1-bca7-b17aca9eab02"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$4xjcH1Aooh0jU3SF/oEA7uVGn6iO.X8knoKXzuqfBM8V6b8N5MQ.m", false, new DateTime(2023, 3, 9, 0, 4, 32, 56, DateTimeKind.Local).AddTicks(1633), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("817ee94f-0717-4b52-a19f-3bfdac2fc96a"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$LtiXTZjfkE9l1vjQfH2sb.HA4EqM01Zq2aeJpsCoYeh7GN9gFtgDi", false, new DateTime(2023, 3, 9, 0, 4, 28, 111, DateTimeKind.Local).AddTicks(6424), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("821bc835-e126-4451-b841-3b459b7d79fe"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$AojEAr9ZC0JZ08QXJJGAAOBd/C0bbfCMBVPw/9Yf.I4uOKhRhGN3u", false, new DateTime(2023, 3, 9, 0, 4, 32, 751, DateTimeKind.Local).AddTicks(7198), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("83cbab6c-6512-4a2c-ac43-165bd47fff76"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$4PCAhxhYc/WJ1/rm.7L3qeoMNDo6332yyy81shw1pI.V02/3wUgjS", false, new DateTime(2023, 3, 9, 0, 4, 27, 356, DateTimeKind.Local).AddTicks(4605), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("873349ae-46a9-4f55-ab3b-22f3c1b040a7"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$OZzpxlNWe5dGZdgwbhZdDO8b8cWzPmSkT8lUcLzVFMLGr90H.v2ni", false, new DateTime(2023, 3, 9, 0, 4, 33, 492, DateTimeKind.Local).AddTicks(2141), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("89000b73-10bb-428e-9155-1e9408934677"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$SxCocm7fr.zKk1UnHq0A/O97WeEBE5YRc8xjwJIl4GCJLxlmamTfG", false, new DateTime(2023, 3, 9, 0, 4, 29, 144, DateTimeKind.Local).AddTicks(3953), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("8e983350-d856-43f9-87bd-bd0d8dc178e4"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$5NL0AzNV17hPzPZ4W8rJFuhK3vgyWQy17.wU4feK909R.v4l2QnM.", false, new DateTime(2023, 3, 9, 0, 4, 27, 497, DateTimeKind.Local).AddTicks(6040), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("90b520b1-383b-40b2-bd74-2c63ca4183ce"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$.40ZSHJY1UpAyoRb4BM1ge9Tai797kOTtzIXKrPRb94I/467xnAbK", false, new DateTime(2023, 3, 9, 0, 4, 31, 821, DateTimeKind.Local).AddTicks(2924), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("90dab47d-d147-4869-8d21-fab3d9f31074"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$HzOC0eV49ckSJTzgF2.yDunUAwM9fBTzsuI38mTArKRRtyf2F4FpK", false, new DateTime(2023, 3, 9, 0, 4, 30, 811, DateTimeKind.Local).AddTicks(3538), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("914f8df6-61fc-4cb9-a715-e7e4680e7dc3"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$wWk75zOtmb0jhCud1xTXreu.l2QyTjTKLJkk3ssFOk9.QUmKoWbD6", false, new DateTime(2023, 3, 9, 0, 4, 31, 745, DateTimeKind.Local).AddTicks(4196), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("92dcebea-7aea-4319-a540-e4495b647ff7"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$Zs8kvXV10xBXpHw7ohj6wOBmx/hHpBEGQm8U/vi/9i4cQvvd1NFWS", false, new DateTime(2023, 3, 9, 0, 4, 28, 832, DateTimeKind.Local).AddTicks(7386), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("9301f9b3-1cf5-4d9b-8c9d-af5d393dbf82"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$HIFLpzd587FZbWlAA1JDw.SgLlgP/kTXQKhWsMkiNl3yfYKNe2DLG", false, new DateTime(2023, 3, 9, 0, 4, 28, 681, DateTimeKind.Local).AddTicks(9262), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("937ca712-78c6-4da1-b76b-65fdf3f2e693"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$bkhJNibA/fnCqPDB220mbuchYPcBEXXZ5UtvpTpHMKLbWslIRQEHi", false, new DateTime(2023, 3, 9, 0, 4, 30, 734, DateTimeKind.Local).AddTicks(9164), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("962111b5-e232-4dd0-9ab2-cae345eee209"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$CUCGQ0Kbbm0/o4dRZFUf/.Is5ssrn7AwNz7QiThqZxfxgb19J8c62", false, new DateTime(2023, 3, 9, 0, 4, 30, 483, DateTimeKind.Local).AddTicks(1476), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("9788103c-9a65-4a09-a2bd-ba0fb04931f8"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$cW7oT8.Cw.BhWgSs9F9uteSDy2n7x6J3wa9wzR3nicoztPmgaGsuq", false, new DateTime(2023, 3, 9, 0, 4, 29, 994, DateTimeKind.Local).AddTicks(7922), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("97e72ce0-e2a0-4793-b8b5-8d61ab0d4bc2"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$5GTiMaPND0FlKIWTTj1jsuNXh1HPUxB/aEgJtf5I/hJGE9nsHdjUa", false, new DateTime(2023, 3, 9, 0, 4, 27, 727, DateTimeKind.Local).AddTicks(262), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("98499e59-058d-452d-8fb8-35115068e77a"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$q8NURUr/8gDsz2kd7t4EKOSR7xwyRo9Ljvgu30uiEawVVm0XLtLh6", false, new DateTime(2023, 3, 9, 0, 4, 31, 280, DateTimeKind.Local).AddTicks(7397), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("9de5aac8-438c-4efd-a503-fedbbbbc8ad0"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$SLnAE6FcA55bTBoxL6biQ.7XwpiXxMxul4AT81R1gpa70fQ5k10Ha", false, new DateTime(2023, 3, 9, 0, 4, 30, 567, DateTimeKind.Local).AddTicks(4055), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("a0912fc5-55dd-4944-bbb5-59cebcd39b0a"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$xfjXQKmbWejxGgfLr9l4XO2sG5CWjeNRF1/Ek3asXAJmbQVh7vmEG", false, new DateTime(2023, 3, 9, 0, 4, 26, 925, DateTimeKind.Local).AddTicks(7095), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("a3033585-24ec-4673-973b-a0eb435c2eff"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$nMrKk26gR/cMOeo.Q2OFIOkuaAYwOUqscdjf2UvrbjdYTnXOltzZy", false, new DateTime(2023, 3, 9, 0, 4, 27, 959, DateTimeKind.Local).AddTicks(3374), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("a4616f60-b44b-44c3-bf42-9825b4013fa9"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$6zwiBdBw9tmtOChK/Ah/ku.dM0.QR4t53LKXMmvu5sx4eEGPjVauy", false, new DateTime(2023, 3, 9, 0, 4, 33, 846, DateTimeKind.Local).AddTicks(5981), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("a55f5eb1-1a0a-4b14-b536-3f1d9d75ea95"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$01Q0yd0Om62uBCKjupi9PeHsdFSPoclggV6/OQ5rNfeIuGJBF4esu", false, new DateTime(2023, 3, 9, 0, 4, 30, 964, DateTimeKind.Local).AddTicks(9072), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("a81d9d7f-05a9-454a-853c-a1e6df4d15bd"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$qMJFLuV49sDOCw.Rm5OBZ.jh3ZwdTHNRLs/02A3PeJi1EjMMdceM2", false, new DateTime(2023, 3, 9, 0, 4, 32, 290, DateTimeKind.Local).AddTicks(7744), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("a8cf071f-c8cb-479c-ba79-5f9390952a2a"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$2BmLyqufVvlASkeCj5AQYeF1A.O3JSo2a5z7qMw3W7j.p9MnO7MXO", false, new DateTime(2023, 3, 9, 0, 4, 32, 596, DateTimeKind.Local).AddTicks(8066), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("ad7b0661-4c3e-4161-8f3b-3bdd91160c5f"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$MIgr0L.i4ytXz.bf6GWZq.nGJtWOkoCzXqJdStp/rOIFxeykqx4be", false, new DateTime(2023, 3, 9, 0, 4, 29, 66, DateTimeKind.Local).AddTicks(1983), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("af5b5e89-7185-4cfb-8d36-e9a34d6dca13"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$ojGrJrs8YZrUuoY83PbOwuHVDzxI/m6bymEVKV/ITK9qfvBEDsvKe", false, new DateTime(2023, 3, 9, 0, 4, 31, 510, DateTimeKind.Local).AddTicks(3297), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("b0682f00-c5e6-404f-bb02-162ee9e7f42f"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$7vK2g1OB0rsIOwjf2Qb3SunmeN7BTRqxkQu03DqA7WVwAYc5LKr7O", false, new DateTime(2023, 3, 9, 0, 4, 34, 362, DateTimeKind.Local).AddTicks(7408), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("b1d38094-1140-43f5-936e-a49ccee3ec87"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$dRbhOgsOfrq18fSdzI2yWOiHfOJ1uQURHOnjPNY3tewbqfcf/m/K.", false, new DateTime(2023, 3, 9, 0, 4, 31, 899, DateTimeKind.Local).AddTicks(9879), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("b275fc63-4611-4087-83b9-b642b4049aeb"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$2gZOjufjIfobG0vhNxKDB.KfE.aSBUbpjMobm1iNVYBx9yr3K/eQW", false, new DateTime(2023, 3, 9, 0, 4, 30, 399, DateTimeKind.Local).AddTicks(6642), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("b2aeb156-dc1f-4459-a2e9-c28da860125d"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$TV8s8bN3ofo0EYx54IeDmOF9GyY./U5Wv5lJHaY4.7kaZGdTdsbcC", false, new DateTime(2023, 3, 9, 0, 4, 26, 292, DateTimeKind.Local).AddTicks(1745), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("b3848703-f93b-4095-9b86-10ae70a33f2d"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$IIqiBFzcpz2kDchgu56YjuFtJjMhGB0LGN7NEynFdKzpNsj66Sjc2", false, new DateTime(2023, 3, 9, 0, 4, 27, 575, DateTimeKind.Local).AddTicks(1996), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("b5f52795-e1ab-4514-b237-99854f791c58"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$v4LUa9RUeTc4tmbzz4YgBO2.mexxa.y8henSDniN0i8Ec/.PnUJaK", false, new DateTime(2023, 3, 9, 0, 4, 28, 356, DateTimeKind.Local).AddTicks(1474), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("b7cc2163-3523-43dd-ba5a-5df385be3c16"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$sCSRW/od4RNN8lAQUx7xb.sokX97G0LJMND.dUFKfdW5yEAaBYQ/e", false, new DateTime(2023, 3, 9, 0, 4, 32, 442, DateTimeKind.Local).AddTicks(8127), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("b7d4fe47-3ca0-45a5-afaf-2d80b44e0c8f"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$Bub3IEG.1ssruSYFef9fEuJTMAShVNoXb8sTY5UJMvB6Bb.OPOYAS", false, new DateTime(2023, 3, 9, 0, 4, 34, 0, DateTimeKind.Local).AddTicks(7659), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("b9e466ee-5721-43e2-a11a-b34974ec18fe"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$Ndt7zo37Q2LIsyGDioBrWeWTfcqRshfXaNZl9fa08KIA39nK1x6My", false, new DateTime(2023, 3, 9, 0, 4, 30, 156, DateTimeKind.Local).AddTicks(8823), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("ba9116df-3dbb-4b4c-841a-2197f76015f9"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$1MGugvylnVBDgGokfdqnzefkCS6EPRqJXH7oJymn8DwGbsubJfTAi", false, new DateTime(2023, 3, 9, 0, 4, 30, 317, DateTimeKind.Local).AddTicks(2933), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("bd8ef9f1-42fb-4ced-b98c-2bd117a82794"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$4pVSnm6vdDR8fe1Gq1ovLOIoOPQDmX.v1qB2VwuzMTkBx/ojb8fWu", false, new DateTime(2023, 3, 9, 0, 4, 29, 836, DateTimeKind.Local).AddTicks(3937), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("c15e0416-ed0e-4616-83bd-61e1da004043"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$r/7T.2UlD.dvLdHvi5N0r.QrheQa20v62OEqvg0rGb7BPNYhvVQ.K", false, new DateTime(2023, 3, 9, 0, 4, 30, 76, DateTimeKind.Local).AddTicks(4382), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("c8156295-e2ef-4484-8389-ca2a5f255941"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$jsfHZl5ht44pr/QeKe8aQezl2XWw1Et9fhdpvYbiY8XfXncscZiqO", false, new DateTime(2023, 3, 9, 0, 4, 34, 517, DateTimeKind.Local).AddTicks(246), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("c9f20647-045b-49ce-80b4-13b7373cc044"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$IjdAg7kdk.UMIc7E9m3do.peKElHgiLf.V1FNxanh2H6Izq6CygB6", false, new DateTime(2023, 3, 9, 0, 4, 32, 676, DateTimeKind.Local).AddTicks(3371), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("cd8bda92-38ba-40ab-8384-9555ebd63248"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$R59bKCTmeUBSZQxGgwv1iemwLvSO.4sdMgTVCWbbnnn7wJpuenH7O", false, new DateTime(2023, 3, 9, 0, 4, 29, 761, DateTimeKind.Local).AddTicks(1386), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("cee2c9a1-be31-4498-88b9-f8b552ffd7c7"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$j/cXIz8njlAgo.U9pvdnSOh3iF.Lbx3hKQ5x9..bQdatXU2af2q6a", false, new DateTime(2023, 3, 9, 0, 4, 32, 905, DateTimeKind.Local).AddTicks(9), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("cf4d8bc1-5e32-4eb8-837f-20e39ec93760"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$rXaHCk/0F6u4tXCCt4wDweAPAMSdDOxWYvyrKF0v1hPandqicSkIq", false, new DateTime(2023, 3, 9, 0, 4, 29, 299, DateTimeKind.Local).AddTicks(680), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("d2a5494c-f8ac-48be-aea3-586bab06f158"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$ZnQO33EpH/6ECAswyK/g.OKEQ5St8R01cw3oAWBCpuc.v0GjRFU6q", false, new DateTime(2023, 3, 9, 0, 4, 33, 54, DateTimeKind.Local).AddTicks(8084), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("d70b6bee-cfc1-4521-bb94-61320c1562f0"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$rrxe92VVHISzEUN89KqDR.6HLAkkXbtP2EartpYHSJDI4dwoerTqS", false, new DateTime(2023, 3, 9, 0, 4, 26, 387, DateTimeKind.Local).AddTicks(8467), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("d93f2923-0f72-4f61-a49b-f75a631d51c3"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$pmjewBwuvsj30x77lwuhXupro1x4KBZkI6YaGgf2P1fdxPeDfLxpm", false, new DateTime(2023, 3, 9, 0, 4, 32, 367, DateTimeKind.Local).AddTicks(2964), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("d9fe6e55-bef7-4a20-950a-bd0144591d15"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$QkcyFHAc/tfgYy9YW0Bo7.H48qapStJsIHVMk4qMEhslIfmCrrfle", false, new DateTime(2023, 3, 9, 0, 4, 26, 680, DateTimeKind.Local).AddTicks(4430), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("de8c518f-f781-4475-9368-bd981734a870"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$8Y0Gxhd6WrOCWvV1virld.qu5mH.OXwEVGpi39S4Tn/SpJIEPyRs.", false, new DateTime(2023, 3, 9, 0, 4, 33, 770, DateTimeKind.Local).AddTicks(2985), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("e018c2d0-64e8-4d32-be6d-9ed0515179e9"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$Q5F4U5gT31jloeMAB2L9Q.HOnocJwLa.7aUvnrg/r1YvosEMy/lha", false, new DateTime(2023, 3, 9, 0, 4, 28, 605, DateTimeKind.Local).AddTicks(3762), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("e10052bb-fb7e-4345-bf45-04080890c15d"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$J/L3BX1xdSQ1ARvpf32bQuWeHP7Trlafo9dQyjOEdCK36QvEYk9Sm", false, new DateTime(2023, 3, 9, 0, 4, 33, 591, DateTimeKind.Local).AddTicks(7730), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("eeff8ef5-367b-487b-9d69-d8599704e196"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$szByLB.unRJvshIr11wgx.dFGWTeM4GbNtq6GNsB/GfUg5dKZuHqa", false, new DateTime(2023, 3, 9, 0, 4, 34, 596, DateTimeKind.Local).AddTicks(3335), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("ef202b7b-5788-4893-aa5f-9b497f8567c4"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$.OZdaEq432X4SIo4e7Oyp.nEo7Y/pePXW2TfoXr8QLOUBn4B4c2r.", false, new DateTime(2023, 3, 9, 0, 4, 30, 649, DateTimeKind.Local).AddTicks(2261), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("f4e2b488-0604-4c0f-865b-786f5b9c6660"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$o6zfpiXZGY9ZvwdyI75d8eBWfT1GzvB7hmGEMmR5Ry9sE7On2EH2G", false, new DateTime(2023, 3, 9, 0, 4, 31, 590, DateTimeKind.Local).AddTicks(5396), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("f585042f-4870-43fb-8de1-2e6a409d0f10"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$HqIHaK5tL9YDWPiFIR1EhuMI.he9KPW8tawF3l5m6T2p5iWZEVw7e", false, new DateTime(2023, 3, 9, 0, 4, 27, 153, DateTimeKind.Local).AddTicks(4721), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("f654256f-d847-4e3b-a58e-f72a6937823b"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$T6Mi.q.x.qbKe9rEwTsme.EefAY47jydshh67wtZYtiKi3RCK5JiK", false, new DateTime(2023, 3, 9, 0, 4, 32, 979, DateTimeKind.Local).AddTicks(3053), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("f9114e95-3bf4-4990-92da-aec74497a9ef"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$mxV8TRSfclben1cUYpirce/5VvBoJW98yRz7UxNd.4wzppCNJUXqu", false, new DateTime(2023, 3, 9, 0, 4, 32, 519, DateTimeKind.Local).AddTicks(2546), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("fa307795-d155-43f6-bdfe-8daccc6cb26d"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$Xw3udqQOiRqAC6GECmKgpetfHLJrH8V8jt8xJ2c51Q1lAXY.owaYy", false, new DateTime(2023, 3, 9, 0, 4, 33, 693, DateTimeKind.Local).AddTicks(5240), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("fa6baac8-bad2-4ec4-896c-15ceb9c8ea11"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$FxzZXoQ5orNwWj.h8uqCt.Hh0nYNIZnhWfkCBhLIR.kWZAo0ZPes6", false, new DateTime(2023, 3, 9, 0, 4, 29, 455, DateTimeKind.Local).AddTicks(2755), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("fad23e78-bb8e-4348-8b44-4c87ec80d090"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$NwPHg7Aq3pTm6AKmslr7v.PodfEDua9uiMKSh4RS8uKViwnAoq4k2", false, new DateTime(2023, 3, 9, 0, 4, 27, 651, DateTimeKind.Local).AddTicks(8008), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("ff5886ef-d0c8-47eb-8357-bb2418385858"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$D0ohAZhWhW4RACs.q.38OuX.FVYsmYBqNLC8PHH1FCwYcjQ3pP7hK", false, new DateTime(2023, 3, 9, 0, 4, 26, 79, DateTimeKind.Local).AddTicks(9829), "Boustead", null, null, "06868143899", 1, "mboustead0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("43ec4e47-e993-4421-a876-173b569f6974"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("55580a18-62ee-4cb5-9099-d7d154693f47"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("62df047c-6ff3-4ed0-87bf-41d62f0e5a1f"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("6bd37165-81f0-48da-846d-ef67c3879028"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("8821e9ae-ceea-4912-903b-88352bfdb050"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("fd3c84c4-76cc-4431-97ec-82cc54b7af49"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("4a754282-9498-456b-8ce3-59f27c151140"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("a6b0fc88-94a4-45bb-9271-466fc2dbb16c"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("d13b3ece-38cf-4e7b-8e60-8fb2c75ec759"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0b3ff8fe-13ed-4afd-bfa8-316eabb4df48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0ba114bf-1ac6-4e46-a9d8-adbdc7df3816"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0bccd85c-850f-4ee8-b9ed-89bc0f2577b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0f87bea8-f43d-41a9-bab8-502cd5873f18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("119b9d47-9950-41b9-b837-bb4478b9f109"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("12f07579-47a8-4942-ab6d-1e32cf562421"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1506d507-4c32-43fb-bb23-4e53ce96fd24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("15b9a6c8-210e-43ea-b75a-03d55981a31c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("16404a44-88e1-4eb8-b2b5-1149fdd037ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("189b24bc-9be2-40f0-9eee-2e19b4a40ec7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1964466e-8e8d-4ba7-9d66-20684cca26e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("19f8b245-1c39-4835-b4c4-05243a5e0516"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("20691608-d85e-4afe-ae8b-1fd6a7bc0ae8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("22bf8c91-e8ad-493a-8a3c-4782e6090438"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("27ede62e-276d-45c4-8fb8-55ac39e8fdca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("28dd6be6-e112-471b-ad0d-e9149bca4f51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("34722266-b687-4974-b952-f59396fe184f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("34ddc59d-10a8-4e57-853f-dd09d662e63c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("382c0060-f87a-4f92-9695-594df0569746"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3b7fe7f6-1d1e-480c-9032-488521f407c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3c8936da-0366-42e8-ab9b-c82760a064ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3c8ac11a-4417-4271-9103-17de5ffd1fa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3e265a8f-683c-4ec1-badb-db8abca0af97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3efa4c9a-fb95-4378-be16-ac57a1877109"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3efe37e0-7808-41ea-972f-63c5363ac9c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("402a6bc0-6f4a-43d7-8b25-3e98edca28af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("41a42c31-2b98-4635-9998-1c6cb36f235d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4480fe76-a72d-4bd2-97a0-b9e65599476d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("459926c5-1319-42de-8415-0a02f5c1d460"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4833a8f6-99eb-44f5-87d1-80f6dca57887"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4d639595-27f2-48c7-b7da-81cf6a2e0644"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4d7e054b-626a-487d-9ca6-562b2f8efba5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4e563743-75eb-4d1d-b93f-e5bbf85be0b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("50149f8e-60b6-48d7-ab35-7b34035990ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("546f02c0-7a6c-4abe-813c-2e2b8e288bcd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("57a79f97-fdfa-470b-843d-29d99beb336a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5822f8a5-e9ca-4994-9b69-3f7305862f9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5a85385d-81e1-4279-b8ee-2193733fa602"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5aa08667-c76d-406a-8924-1284e00c460e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5bb9d614-a543-4cb5-aae0-1c419e17862c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5f89f8bc-257b-41b9-8d7d-cbe437069d31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62902bef-eb17-4626-9ddf-2da6f6ac93c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("666e8b1d-0750-4229-a02e-e0d5227e71ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("682782b4-d879-4e05-9b61-a3605efa9954"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("68eb680f-0367-47b2-ac7c-0f4f4ba84cca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6aa7c97a-f42d-43e6-af12-bdacf43f7a3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6c2a815f-8e0c-4f01-a411-5c4829a98af9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6c8bf3b7-2c59-4cb1-8f21-c1d9a6af653e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f283482-b0b8-4494-945a-e875e85aa237"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("727b2fbc-37bb-443e-a519-ce99e7c21ebe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7cf3196f-f0db-4337-922e-2d167d30a10d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7fd558b7-e6e8-4437-bae6-79f321c62aa3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("80715813-424c-4ff1-bca7-b17aca9eab02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("817ee94f-0717-4b52-a19f-3bfdac2fc96a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("821bc835-e126-4451-b841-3b459b7d79fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83cbab6c-6512-4a2c-ac43-165bd47fff76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("873349ae-46a9-4f55-ab3b-22f3c1b040a7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("89000b73-10bb-428e-9155-1e9408934677"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8e983350-d856-43f9-87bd-bd0d8dc178e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("90b520b1-383b-40b2-bd74-2c63ca4183ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("90dab47d-d147-4869-8d21-fab3d9f31074"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("914f8df6-61fc-4cb9-a715-e7e4680e7dc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("92dcebea-7aea-4319-a540-e4495b647ff7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9301f9b3-1cf5-4d9b-8c9d-af5d393dbf82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("937ca712-78c6-4da1-b76b-65fdf3f2e693"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("962111b5-e232-4dd0-9ab2-cae345eee209"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9788103c-9a65-4a09-a2bd-ba0fb04931f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("97e72ce0-e2a0-4793-b8b5-8d61ab0d4bc2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("98499e59-058d-452d-8fb8-35115068e77a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9de5aac8-438c-4efd-a503-fedbbbbc8ad0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a0912fc5-55dd-4944-bbb5-59cebcd39b0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a3033585-24ec-4673-973b-a0eb435c2eff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a4616f60-b44b-44c3-bf42-9825b4013fa9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a55f5eb1-1a0a-4b14-b536-3f1d9d75ea95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a81d9d7f-05a9-454a-853c-a1e6df4d15bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a8cf071f-c8cb-479c-ba79-5f9390952a2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ad7b0661-4c3e-4161-8f3b-3bdd91160c5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("af5b5e89-7185-4cfb-8d36-e9a34d6dca13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b0682f00-c5e6-404f-bb02-162ee9e7f42f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1d38094-1140-43f5-936e-a49ccee3ec87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b275fc63-4611-4087-83b9-b642b4049aeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b2aeb156-dc1f-4459-a2e9-c28da860125d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b3848703-f93b-4095-9b86-10ae70a33f2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b5f52795-e1ab-4514-b237-99854f791c58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b7cc2163-3523-43dd-ba5a-5df385be3c16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b7d4fe47-3ca0-45a5-afaf-2d80b44e0c8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b9e466ee-5721-43e2-a11a-b34974ec18fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba9116df-3dbb-4b4c-841a-2197f76015f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd8ef9f1-42fb-4ced-b98c-2bd117a82794"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c15e0416-ed0e-4616-83bd-61e1da004043"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c8156295-e2ef-4484-8389-ca2a5f255941"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c9f20647-045b-49ce-80b4-13b7373cc044"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cd8bda92-38ba-40ab-8384-9555ebd63248"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cee2c9a1-be31-4498-88b9-f8b552ffd7c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cf4d8bc1-5e32-4eb8-837f-20e39ec93760"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d2a5494c-f8ac-48be-aea3-586bab06f158"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d70b6bee-cfc1-4521-bb94-61320c1562f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d93f2923-0f72-4f61-a49b-f75a631d51c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d9fe6e55-bef7-4a20-950a-bd0144591d15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("de8c518f-f781-4475-9368-bd981734a870"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e018c2d0-64e8-4d32-be6d-9ed0515179e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e10052bb-fb7e-4345-bf45-04080890c15d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eeff8ef5-367b-487b-9d69-d8599704e196"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ef202b7b-5788-4893-aa5f-9b497f8567c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f4e2b488-0604-4c0f-865b-786f5b9c6660"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f585042f-4870-43fb-8de1-2e6a409d0f10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f654256f-d847-4e3b-a58e-f72a6937823b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f9114e95-3bf4-4990-92da-aec74497a9ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa307795-d155-43f6-bdfe-8daccc6cb26d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa6baac8-bad2-4ec4-896c-15ceb9c8ea11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fad23e78-bb8e-4348-8b44-4c87ec80d090"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ff5886ef-d0c8-47eb-8357-bb2418385858"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ParkingID",
                table: "Images",
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
                    { new Guid("2f4a29b4-dbe0-44c5-b633-0fb41cae171c"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("4cb5df24-221e-402d-9283-7577f8f9fa1f"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("6f7232ac-619c-45c2-a7a7-412f6ab8feac"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("7d830af3-d501-4f73-8ff4-5c2b9ea0b5ac"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("a609bc85-c32e-4989-8bc9-c09efd6616ae"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("c20529b5-c876-4493-b314-d830c0e47603"), "Xe bán tải", null, null, "Pickup", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("8176ceee-caa6-42c0-9f31-3e66731e575a"), "Half Year", new DateTime(2023, 3, 8, 23, 40, 10, 170, DateTimeKind.Local).AddTicks(4229), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d6f1a17-e75e-437f-bf5d-b76a9a445e1c"), "Short time", new DateTime(2023, 3, 8, 23, 40, 10, 170, DateTimeKind.Local).AddTicks(4212), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b345dd8b-cec3-439f-b1b2-4535937ce04e"), "1 Year", new DateTime(2023, 3, 8, 23, 40, 10, 170, DateTimeKind.Local).AddTicks(4231), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("0296661d-fd04-4358-9603-7a0ac26e7ad0"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$67IEdDkbKAHMa7iETcqiBugFzWxwGEdciD7/WeIFCeNkAjYxIAYMa", false, new DateTime(2023, 3, 8, 23, 40, 3, 659, DateTimeKind.Local).AddTicks(1630), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("046bc6d4-74af-4668-ae8d-9ab70e08c3f1"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$4sB9dMFlMqrHLOxDvPil0eIVHvQjtcz4kVKsYwn0kwR1n9nnlbXti", false, new DateTime(2023, 3, 8, 23, 40, 0, 884, DateTimeKind.Local).AddTicks(485), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("05fc9de1-e343-4a6f-ab08-cc51167e9d42"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$ySPbOPAZY6gSFD/U.3DW0OiYKJ6CULpkfCKWKmpJUG.wcmmaJ44B6", false, new DateTime(2023, 3, 8, 23, 40, 3, 738, DateTimeKind.Local).AddTicks(4065), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("15e612dd-ac27-4b39-bbc8-b736a20db326"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$.Z1eDgRMmBMZKqGe7bNgPeUWzEDMWBnBQHClURwV.//vYgQzkt566", false, new DateTime(2023, 3, 8, 23, 40, 5, 619, DateTimeKind.Local).AddTicks(8908), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("17126f2f-878a-4215-b377-678ed0d17387"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$BBdBqmteJ7pufY1JqqneOOwQAdIyVoC2uvOQ6iGNHb0Odx7wmcl1G", false, new DateTime(2023, 3, 8, 23, 40, 4, 126, DateTimeKind.Local).AddTicks(1435), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("17226789-5b99-4f0c-b3cd-cd64ca4c3f60"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$iOy.Mjf3ZlRvpgH8L7EYcOMNJMKfwHsNvAfpdCh8fF653Nk33NP52", false, new DateTime(2023, 3, 8, 23, 40, 10, 170, DateTimeKind.Local).AddTicks(3648), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("17b8df4c-eeff-4cfe-8484-98a8347a2fca"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$fdBfLZjVbu6lupuLPqttAOuSUNs3BHsGy6HSYt4MsBUIFbHNArhBK", false, new DateTime(2023, 3, 8, 23, 40, 3, 498, DateTimeKind.Local).AddTicks(1432), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("1da54cd6-7a30-4992-a53c-7f40a540be44"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$mgCNXLgRnyyc33EqKd0w9u3khIjIbKBvUFB1TZw5S.ueBzAXmb1tC", false, new DateTime(2023, 3, 8, 23, 40, 0, 802, DateTimeKind.Local).AddTicks(8369), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("23ce00ab-272a-4ae0-929d-50ed80a8117a"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$wQvhS4A5qNh9Uir4BkQTUOwaC0um0rKFNhrEEQJ2yZ0Jj3Rf7Rc4u", false, new DateTime(2023, 3, 8, 23, 40, 6, 978, DateTimeKind.Local).AddTicks(7499), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("240abebe-916e-412e-97ab-7e13b2c364d7"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$TBjzO8OJplFbfAD7FWPYwOzokM8GmTTlpR8VveR1e2ov8GnPkZghO", false, new DateTime(2023, 3, 8, 23, 40, 9, 549, DateTimeKind.Local).AddTicks(7647), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("242f00a5-c9b9-4d8a-afed-7d5edfd4810d"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$cbtrWi2cEwGpHsn016SKS.tN8/sxNEfsjraoYoxdXYREAwoaOdH7.", false, new DateTime(2023, 3, 8, 23, 40, 9, 152, DateTimeKind.Local).AddTicks(5782), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("2497af69-9f17-4401-816c-9a7e75240fa0"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$iSrop687ixLobrnua1NEJuKyBVWtrnwaMqvQUHPL.SJmUGcC7wIjG", false, new DateTime(2023, 3, 8, 23, 40, 7, 72, DateTimeKind.Local).AddTicks(633), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("27a16918-1f53-44d1-84a7-11875fb7a262"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$ad7fZpvOIbzAPZrxRfhnGuG30gBQDv4K3/jBUWAQsoMvf9EY7dqY6", false, new DateTime(2023, 3, 8, 23, 40, 1, 225, DateTimeKind.Local).AddTicks(3282), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("2caa8881-bde5-49a1-b678-a17af9a5660f"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$JzfRJuirZWwuKwBZXoKZZOEyk2gbF//uMI/nUUW9b.TpPqKfrDemG", false, new DateTime(2023, 3, 8, 23, 40, 1, 393, DateTimeKind.Local).AddTicks(5630), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("2e625470-0fd0-4b77-a911-4617bb157701"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$NOP7Mz.7Yi93JW9i8cupfeY6grgUieRNym6Xlvk.l8J5sIhD/vDhW", false, new DateTime(2023, 3, 8, 23, 40, 1, 569, DateTimeKind.Local).AddTicks(1840), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("2f568284-42a8-4c3c-b82c-b938f309c0df"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$3O7mn/NnEzLKstUKGiKY5.FNHI6GlA1YEwakXXb3.wufjqEL3BnCq", false, new DateTime(2023, 3, 8, 23, 39, 59, 582, DateTimeKind.Local).AddTicks(7021), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("2f74dc83-cdbe-41c7-83e4-c727ed023e9f"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$DTCGaxMQHHFRi4NymTEo4edbxhQMNA00R6bwQKuGH.VqhDOY0R./O", false, new DateTime(2023, 3, 8, 23, 40, 3, 8, DateTimeKind.Local).AddTicks(2725), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("31d877d2-2ef7-4882-8497-6351036c383e"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$M3zJeCnXTycJT12CZ86O/uTG9XKZAuJFmjWSmv3lu4DTaUGgC8RiO", false, new DateTime(2023, 3, 8, 23, 40, 2, 603, DateTimeKind.Local).AddTicks(6842), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("327c1fae-7f93-4ee9-bb4c-4997e08fd542"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$qKkQiiMcAu4DjPcqLbV7L.cZ.y431xD.wREQA85yhtf1hcm8SAnsa", false, new DateTime(2023, 3, 8, 23, 40, 5, 316, DateTimeKind.Local).AddTicks(2638), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("3291fe2c-d67d-498a-95ff-cbb9efe2266c"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$.iBbYHx3lgIPecWZDuL5E.bDK75FPcpe7ipjP1.j.fB.A0AUgOg0S", false, new DateTime(2023, 3, 8, 23, 40, 5, 808, DateTimeKind.Local).AddTicks(7400), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("3555b85b-374b-40b4-ba6b-0ce43ef5aa65"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$hh9r6UGDdgf6bx1XsayLG.Eo4sEC22lcdFM9Hke9XgrvFZbtyp6nO", false, new DateTime(2023, 3, 8, 23, 39, 59, 806, DateTimeKind.Local).AddTicks(5806), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("36a86eae-a3c0-48e0-96f5-41c9732e9127"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$n/BKfrWMHxUObz4IniqZdeBXy6s3nqDpb7.RdtAUfIfd46oHwINty", false, new DateTime(2023, 3, 8, 23, 40, 9, 984, DateTimeKind.Local).AddTicks(8797), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("36e067ca-3832-4de6-ad82-a86a6e70d01b"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$.BPJC0nleOISY9UZVhKRgOa31O9nM42Om4W6zy49FwhEFmkTx3Ny.", false, new DateTime(2023, 3, 8, 23, 40, 0, 375, DateTimeKind.Local).AddTicks(1171), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("38e63c88-d62b-4ab6-9e9e-3303c33283e1"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$SXZXWcx6okpx0lBCHzgJe.V7zP/u1GVs8Ze/MqLtMovUrKcXUOmzu", false, new DateTime(2023, 3, 8, 23, 40, 2, 843, DateTimeKind.Local).AddTicks(6355), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("3ce555f4-184b-4490-a9d3-a484d72bd5a3"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$hkDeSZI.730F0e.1IFO5C.yr9fu0pbimfCFOdmgd1fWe/Vu6e4O2i", false, new DateTime(2023, 3, 8, 23, 40, 4, 539, DateTimeKind.Local).AddTicks(3879), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("3e2b76b3-cdd9-45b3-b8cc-ca6ae28fb07a"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$B1/biUbtSucZZpkZdGgD9uVsETw62Xe.XeWWJPHEddQe8HvSR9Hnq", false, new DateTime(2023, 3, 8, 23, 40, 6, 596, DateTimeKind.Local).AddTicks(6704), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("3ef27aca-9a6e-4786-8ec0-957ffd4cd355"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$mJaYpeSYyl6wqY7s4nvRqOpLkz81H6j9UBvKTvYCigPlLpZOnJcD6", false, new DateTime(2023, 3, 8, 23, 40, 6, 318, DateTimeKind.Local).AddTicks(2600), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("3f9083b4-2d56-486b-a818-c49fc38b30d5"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$oPLyDiKme.R0oNm6YaL/ceVaaH4/wx7MehO6qpzWzAfpnNxUYOfb2", false, new DateTime(2023, 3, 8, 23, 39, 59, 913, DateTimeKind.Local).AddTicks(1281), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("469ec473-5b2d-435d-849f-559c6e27aa08"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$UU1zN1Y2YJvvXCL7lQ7d0ucfLAY.Qo1Fvw7WujUdDCRSpImXBuvi2", false, new DateTime(2023, 3, 8, 23, 40, 1, 481, DateTimeKind.Local).AddTicks(1182), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("46ff1a64-6920-4f14-b8bc-750ae0c7714a"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$0H2xZGnQBvF1peN8u7fRH.Sb./X8Nl4uDisb2IuzzMm3bE6v9/vsi", false, new DateTime(2023, 3, 8, 23, 40, 4, 907, DateTimeKind.Local).AddTicks(9144), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("48002b45-65b0-4d38-be5d-b46243aa5e05"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$f64ECPuGYJZuSVTN8Bgc9e6U9dfTOAcCN1.hMGc.4uJdmKBU1TYUC", false, new DateTime(2023, 3, 8, 23, 40, 4, 725, DateTimeKind.Local).AddTicks(2891), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("4f140505-d89c-47fd-8d30-c01d17bacd86"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$h/VEhm3ETdMl/p3AVfM.SOhdulMj0O9.8VMwctfK65R1o09JWfMKW", false, new DateTime(2023, 3, 8, 23, 40, 7, 768, DateTimeKind.Local).AddTicks(1563), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("50fb2ce7-22ab-4294-a54d-e8346fcc47a0"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$Onj1ocydeqeeadJOHpxpleH/fvTsF8L837UmE3QNTzVJQXxqKn1wG", false, new DateTime(2023, 3, 8, 23, 40, 5, 209, DateTimeKind.Local).AddTicks(4219), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("55d7bfbb-030e-45ad-8a57-01026a116e51"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$q1NVsuLspBoE9QSFzmtQP.ZQFEgKiqdJX.D06V4CW2IP4aplq5Wh6", false, new DateTime(2023, 3, 8, 23, 39, 59, 346, DateTimeKind.Local).AddTicks(8492), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("5b5bc0ae-6c7f-4600-b123-3a89da6d71ca"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$LRg5F4OEo7EGYWcVFkj6GOolEchPhYAkwHRdAvRIGrYCmsX0DelSC", false, new DateTime(2023, 3, 8, 23, 40, 3, 973, DateTimeKind.Local).AddTicks(8285), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("5bf3b881-0216-4c7a-ae79-7ef6c2d8989d"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$Sfcmt8WC6PmHg2Asg9m.R.83T.IqxpeGTomz657eZdNJB4qNGpa1G", false, new DateTime(2023, 3, 8, 23, 40, 1, 893, DateTimeKind.Local).AddTicks(7770), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("5ec228bb-bef8-40f1-abe5-b19a285676dd"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$lH7sDTd8Sp/aEoNhemyQy.EsqMSOO4WJw.8D7e5e2aUqXr6bmmH3y", false, new DateTime(2023, 3, 8, 23, 40, 5, 920, DateTimeKind.Local).AddTicks(5276), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("5f6b6189-af53-4ca1-baa2-6f16089eafde"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$Vfwa/w29hb/5ck8Nr9e5BulEKlJLvNx45tr7oX1OFqMVFzVHWf/Uy", false, new DateTime(2023, 3, 8, 23, 40, 7, 163, DateTimeKind.Local).AddTicks(7639), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("614083f7-11e4-4494-b1f4-0e939bb11dfe"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$J7EDGZqHCXEpDsWrgRgqaOS6h0tezUInpRGGy0hX2BCGF/4wxAG7i", false, new DateTime(2023, 3, 8, 23, 40, 6, 29, DateTimeKind.Local).AddTicks(9860), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("66e39412-1b21-4c0e-9529-fed2b03a3d39"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$zmE.KsSHMXRf1voTXTAQ9.YipKDg0.oU7s.mLF2x3/jLCd4Gs.InS", false, new DateTime(2023, 3, 8, 23, 40, 0, 547, DateTimeKind.Local).AddTicks(8799), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("67391340-9165-4aa8-bcc6-dfa2b9b359fb"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$En.a0gGOslE8JRr5I5Scd.11WcQKb7.4lGtm12fIkIHWxS.2WUwca", false, new DateTime(2023, 3, 8, 23, 40, 4, 50, DateTimeKind.Local).AddTicks(7183), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("6b09bf07-4c41-4343-a6ec-8f99ccf6b079"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$ACWHz.4h.gxWGirAKasv.u2mKqU2XeLO107DgwQTEhxgurSOQ485W", false, new DateTime(2023, 3, 8, 23, 40, 2, 524, DateTimeKind.Local).AddTicks(6722), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("6b6509f1-eb85-4cb8-afa4-e212e6c6eeed"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$XqO0enc3NPFGeZOicmjrveNC8kPM3jb5lZ4iMiIVZN2WAHDtDFpt.", false, new DateTime(2023, 3, 8, 23, 40, 6, 128, DateTimeKind.Local).AddTicks(238), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("6d9069ab-3598-4de5-851d-11fb31b4e9a4"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$i42YOSBDMv9PE5NGbilUxeF8vlMaBiPMiWTU9/JCefP7lAaMTpxPO", false, new DateTime(2023, 3, 8, 23, 40, 1, 141, DateTimeKind.Local).AddTicks(2552), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("74fbbb8e-4b69-4085-bd60-f91601a76f5a"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$wKn/wQpXxdsMB3v6iH8UwelZJHyIeyWmzkVP6bvN22HacqQCnNCYm", false, new DateTime(2023, 3, 8, 23, 40, 4, 201, DateTimeKind.Local).AddTicks(766), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("76d4193f-1cdb-4b3a-bb13-b9d037efc7a5"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$/bF7p6TMemgcQLzNKRhn6.WOcH3ouHLNV2fM.xIpYyfLEsbeCdhWa", false, new DateTime(2023, 3, 8, 23, 40, 1, 654, DateTimeKind.Local).AddTicks(1564), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("7a838f4b-1c30-415a-a31c-f4b02f28de53"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$JMLcmqwjupllWg3isKyWIuusisTK4yJzxu6ZP/TsPNFo.iiKRx0ym", false, new DateTime(2023, 3, 8, 23, 40, 2, 54, DateTimeKind.Local).AddTicks(4951), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("7b149f6c-7eaa-478e-ab44-7a3728927434"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$2xjAa/R6QHklPVOZY8eNy.FrqGDw2fwSRznXGkhOywAxaztgjDf5.", false, new DateTime(2023, 3, 8, 23, 40, 0, 286, DateTimeKind.Local).AddTicks(1915), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("7cd93494-06ae-4ada-af2a-6f00362b1887"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$VRVN3zX7ACTHh77imlYEF.AJ4S6ZUb4zlS7SmWbyhfpPvXnKMLX0C", false, new DateTime(2023, 3, 8, 23, 40, 6, 423, DateTimeKind.Local).AddTicks(6654), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("7d8b49f1-216e-4a10-b217-7dcd9d6ff034"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$fXWoa7HBZ6LhZ9yGRKm/Le8RUk0Q7qPRqIVNR5VL5jC4mbvlOiOxW", false, new DateTime(2023, 3, 8, 23, 40, 3, 249, DateTimeKind.Local).AddTicks(6873), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("7e82d339-2770-4333-acc9-39493fb4ce5d"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$Lqh3Y2nNQ4u5iiUnih0XIul0NUZuNs4xm/KVhLFF4b7GYeiQ2DsBa", false, new DateTime(2023, 3, 8, 23, 40, 4, 627, DateTimeKind.Local).AddTicks(6782), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("80a0e556-1fe3-4c3f-9978-833cd4b756c4"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$pm.xFI2bj3sMhc/zJckLn.IevRV4kV5Zl41kLNyPiP1bv.er2teK.", false, new DateTime(2023, 3, 8, 23, 40, 7, 449, DateTimeKind.Local).AddTicks(7813), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("83981925-6ce6-433a-8f46-f0158bb2364d"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$KV0BFS/FNzRdNR.we3FhZeJa9Q4Oiar4o1mkO2Z76ghW4qsHnms6m", false, new DateTime(2023, 3, 8, 23, 40, 7, 665, DateTimeKind.Local).AddTicks(4551), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("83afb878-c8e0-42f0-9783-976e1ca4ffd7"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$AXiY5hV6dLG5uORelafThOggiJ/vuAyzJJsI.UZ.TK18N1wngyP7K", false, new DateTime(2023, 3, 8, 23, 40, 2, 294, DateTimeKind.Local).AddTicks(599), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("847045cb-77c9-4b34-881a-c02711f3b1d6"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$MLMEw.65mAzBJjwUUe/LEequc4ggMZ876gYOT0sMVq3d5UB7z3NMG", false, new DateTime(2023, 3, 8, 23, 40, 4, 279, DateTimeKind.Local).AddTicks(3438), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("89aca45c-b796-44b9-bc6b-9f4e28e3e126"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$yvAm.qwnBDSzPmObpknCAedfFqlBNSHUH8/46r79gnWcnzCGjelRO", false, new DateTime(2023, 3, 8, 23, 40, 3, 330, DateTimeKind.Local).AddTicks(3280), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("8cfd128f-48be-4498-9b9d-32a8b8ff5f4d"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$KFIP4rbbzQJN2Gypfszv0eVzR1ykqfAZ/BXFWdLoKErXcm3NLxUve", false, new DateTime(2023, 3, 8, 23, 40, 2, 926, DateTimeKind.Local).AddTicks(9914), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("949817cf-6da3-4a29-bc45-c2b81f9c98e0"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$4ym62IvuSpNoYnNuH91avOSNUmYsboYU8cLj2HUfyu9JyY0feUkIK", false, new DateTime(2023, 3, 8, 23, 40, 0, 968, DateTimeKind.Local).AddTicks(3690), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("958f0b21-8c36-4e2e-aee9-4460d74924a5"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$zwCq99XQ3K7zz7RAWSiZcO/0zKD.xd9Rk/vOn6GCveF56KewNut2q", false, new DateTime(2023, 3, 8, 23, 40, 10, 79, DateTimeKind.Local).AddTicks(2794), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("9871d1f1-b516-4c03-8e1f-68060a451a83"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$vdXTXU0klfk6.Q5V9Jicb.pceNazDfHnYrmPVXdcDIRXXjI2HwVxq", false, new DateTime(2023, 3, 8, 23, 40, 3, 897, DateTimeKind.Local).AddTicks(373), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("9afa117c-4f22-45bc-a55d-a411abfcb22e"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$KfyJ6UeIxVpHVJSxHEKugeR.mDGg6X3s3UInCbQj1oty0Ezh2AlVq", false, new DateTime(2023, 3, 8, 23, 40, 1, 814, DateTimeKind.Local).AddTicks(4190), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("9e9b6c13-7cb1-42bf-bc40-d0ea236f4e67"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$ONehNP/utDGXVO11TdCYjeQv1/FQVEy4BIDSeyoQ2gnqGAh/T/54.", false, new DateTime(2023, 3, 8, 23, 40, 7, 874, DateTimeKind.Local).AddTicks(1159), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("9f30cec6-2472-4fb7-9735-fa08bf340d10"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$Z4ITe6CvgTkzK/nySSvr5ePKomV/eUaHCuYhAm9V3ldyYan7ipBY6", false, new DateTime(2023, 3, 8, 23, 40, 9, 425, DateTimeKind.Local).AddTicks(3703), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("9f4bad8f-bb37-4008-be0a-5f26aaef9bf9"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$yDocDg1otzCPVGm5UYw1DuLADNcb3fWTrcV6fRIpGaYtAh03VJpO.", false, new DateTime(2023, 3, 8, 23, 40, 9, 784, DateTimeKind.Local).AddTicks(5955), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("a2e9c662-c943-4887-a3b4-c02c38375db3"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$YdJzlHMq.DfQzUv10LbD6.EnT1Fcxce9zK1LW2oKuxBxeEGgGSUDa", false, new DateTime(2023, 3, 8, 23, 40, 8, 793, DateTimeKind.Local).AddTicks(813), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("a4d93d23-244c-4b1d-adf7-609e09e982fb"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$BblqlTmf3HqojWc9FmuJ/OolCUv5BaecQdg90c5tpetTBBur.VB0m", false, new DateTime(2023, 3, 8, 23, 40, 6, 679, DateTimeKind.Local).AddTicks(2445), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("a7366bd3-8c2d-41f6-a036-c727ebaf5b6e"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$h79T.5e6awh5LJls4RkdRuBgeOncpF3AdHAf0QdsTmOo1WOuwm2by", false, new DateTime(2023, 3, 8, 23, 40, 8, 595, DateTimeKind.Local).AddTicks(1060), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("a7acca7a-6765-4446-b230-4abc0d73bf66"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$rlAxUw8cW309Q9Tu6z0mBuRzaVTksQeGmvKGV7r7ja7PnxjsmUsKm", false, new DateTime(2023, 3, 8, 23, 40, 4, 453, DateTimeKind.Local).AddTicks(1423), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("aaa6e4ad-29e3-4ce9-8c9c-b5df5f846e1a"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$pYR2dAV93RjGNpQBLKNI2un8l9iSJjmf3.mlDo/BgxZhKCTAvyV9.", false, new DateTime(2023, 3, 8, 23, 40, 7, 303, DateTimeKind.Local).AddTicks(91), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("ab164413-1801-4154-8c0c-8f1782ae4880"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$0hf3qftRwmzz3HCUdgOi2u8/wwnhQAB0AE9khcd0kM0VJLkYGWeIu", false, new DateTime(2023, 3, 8, 23, 40, 3, 579, DateTimeKind.Local).AddTicks(5893), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("abc9c256-39fe-4a81-b83a-8d08d8f2dd28"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$n5UTksTTx6/IXrOyxa9ViuI.k4SiE.RHasv0cm2mxxD/AjlT0BVku", false, new DateTime(2023, 3, 8, 23, 40, 9, 298, DateTimeKind.Local).AddTicks(3691), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("ad4b2ee0-93dc-4802-89d8-cca5c8097d60"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$XDCLR.7O.qIYD/3O/k5tEekhwuzTa5c9fVnLj99WaQ6Mrjpn723MG", false, new DateTime(2023, 3, 8, 23, 40, 2, 134, DateTimeKind.Local).AddTicks(7010), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("b5f484ae-c77b-4dd4-987a-d3074c3ed036"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$hiaPaR9WSedgxKaOX9Lt3eEssk4osEXQyHrtgjsgYmSKXyzK5gMDS", false, new DateTime(2023, 3, 8, 23, 40, 2, 764, DateTimeKind.Local).AddTicks(5770), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("b669568c-467e-4028-9c46-cd11451c053b"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$mmxBdL3OhbNVA73PYJ60z.piIBCh8EPk2/5X11mQ2riccb70eJLx.", false, new DateTime(2023, 3, 8, 23, 40, 6, 773, DateTimeKind.Local).AddTicks(6811), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("b857e605-2dab-4b9c-a95a-e89ba530ea04"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$w5hRutGMDyeSrY6Kne/0JOCGqVTmL77UVUNh4MlnDSuEqV8QR8s5G", false, new DateTime(2023, 3, 8, 23, 40, 6, 884, DateTimeKind.Local).AddTicks(4871), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("bb1faf4a-6143-44a7-8b0c-79723daaf238"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$.7vKMnguN/632gyzqIRk5ugMC532CTAHuixj47eF45L0tg843lYZS", false, new DateTime(2023, 3, 8, 23, 40, 2, 372, DateTimeKind.Local).AddTicks(5261), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("bc42eaf9-1b7e-4138-b053-19ac4e9ec1ac"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$M0ymmaNZTOWZ4nuoni16PeqTb/pgX3sPbImTGnqSCPQ/Fv0B/IrhC", false, new DateTime(2023, 3, 8, 23, 40, 0, 102, DateTimeKind.Local).AddTicks(1537), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("c463af87-900c-4780-94cc-7ad75d35f148"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$JFXqOJ0zkuguGgB6uygZSOEKBhN00e.B1.jPiXx1QRamGQ3SB37fu", false, new DateTime(2023, 3, 8, 23, 40, 4, 816, DateTimeKind.Local).AddTicks(8829), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("c7bdad93-6338-487b-8a5f-d89e5940398a"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$JZxmAR3nopzjpUvHBme9Fe2kVODMPO97bMugBsPJDOjV0clkhr0hW", false, new DateTime(2023, 3, 8, 23, 39, 59, 470, DateTimeKind.Local).AddTicks(2563), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("ca804158-9deb-4593-b9cd-6549407317a5"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$S73MGZHcu/wg7GkpE7r0qulIf5ZOCJC7/DUYbNcFw2k6LH.h40QJK", false, new DateTime(2023, 3, 8, 23, 39, 59, 688, DateTimeKind.Local).AddTicks(2886), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("cc0e0773-0175-4a9d-a618-b196ba9026ac"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$BcDLEOnFgH6nbGlpMUjs6eSowdKTnNJKZSLK1WQDPpgjAvHoScYvm", false, new DateTime(2023, 3, 8, 23, 40, 1, 735, DateTimeKind.Local).AddTicks(3057), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("ccfff54b-1ba0-4aa7-8fa1-e4b0313e3741"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$jQX9xH50oHEhBIlfrKZ4E.tPYICR/8UJLi.QvOg6DtZSW6xJN8TVW", false, new DateTime(2023, 3, 8, 23, 40, 3, 91, DateTimeKind.Local).AddTicks(461), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("ce4011dd-0801-4900-a550-7f77c7ccf4f3"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$5yD9BCv0NxqkJSlFnmyvEu0FoL.k.3VwF/yIzNu52JqOIUPYx8jCi", false, new DateTime(2023, 3, 8, 23, 40, 5, 505, DateTimeKind.Local).AddTicks(9060), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("ceaa0de7-2507-41a1-8cf4-a44837cc3e51"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$c6hJ.tVoqV/1TsS2balDLuRB5MmlsaaB3qkpUkLjK70vNT.PM5YSe", false, new DateTime(2023, 3, 8, 23, 40, 1, 53, DateTimeKind.Local).AddTicks(3781), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("cf6c24eb-55ac-4eed-bb03-b324b761e965"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$/BnvXbg3G/4KVLQpQOnpyOtZQoGlLqp63LJeEqLyPR/Xg9fedKNRO", false, new DateTime(2023, 3, 8, 23, 40, 0, 637, DateTimeKind.Local).AddTicks(4261), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("d06c78e9-a805-43bf-8cc8-a973eddb439d"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$kn3kYq2pyFmGA661zhpBTuCi9un5PdIoWUqrGV3KcUY4CBZTOnxn2", false, new DateTime(2023, 3, 8, 23, 40, 8, 456, DateTimeKind.Local).AddTicks(6487), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("d0bd9e0b-e435-4e99-8cd4-29843e51cb05"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$kMqArbcDnVNx4Rlsbfa5XefdABrcSCKQxL6NwaRPTB4w/u1Xdgz7e", false, new DateTime(2023, 3, 8, 23, 40, 2, 215, DateTimeKind.Local).AddTicks(5717), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("d33ae76a-fffa-4055-8cfc-54bf852f16cd"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$5NxvwxWzorkcyMmXAcBqyeuNCXfVhydJYHnrYoE4RvD8TnxF0d2Zi", false, new DateTime(2023, 3, 8, 23, 40, 5, 413, DateTimeKind.Local).AddTicks(4468), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("d58b2509-b306-407c-9045-a3eed8a1bda5"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$pbQp9zTOZmMVeOmD8.PkdeOmN4dBV4qbtXoHiHSGyJtJtMWIjr1e6", false, new DateTime(2023, 3, 8, 23, 40, 2, 449, DateTimeKind.Local).AddTicks(4743), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("d6d7a3d5-0d43-4ee8-9b0a-a7a5b5f86859"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$vyNwh2tJUBCrLtjkyfnAieit1N3Q1ojPgg3naRe7Oq1ILonxpw1eG", false, new DateTime(2023, 3, 8, 23, 40, 3, 415, DateTimeKind.Local).AddTicks(7571), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("d8ac6170-bd39-4d20-b29e-52f37d20e785"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$RTMV8hEHIslm25D5voYnvuhXU188pbv1InFSMG9nKvu4tjewbgxe2", false, new DateTime(2023, 3, 8, 23, 40, 0, 196, DateTimeKind.Local).AddTicks(1775), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("ddc76b80-07ca-4987-8309-dc5101da5a27"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$QY2hF6JtRZ0otW1Z6i3f5uwPTj.Iszq.nhVFiJ2K56/Bat./kw1a6", false, new DateTime(2023, 3, 8, 23, 40, 3, 170, DateTimeKind.Local).AddTicks(7001), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("df3453e2-d903-4546-9b01-49310d5c5b2a"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$hlVm2U32WCIjpBEKnHv4De5f9H9uSpps8BDsyEg9M2TUHU56CbqTG", false, new DateTime(2023, 3, 8, 23, 40, 5, 117, DateTimeKind.Local).AddTicks(3123), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("e01cdce2-8662-4559-bb2a-093ee37c9047"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$oQ0OyYMrbfD7UTYdzbHw8OJ6Hfr3hJfmgSSFh.mSyEd3olMk96CEe", false, new DateTime(2023, 3, 8, 23, 40, 6, 218, DateTimeKind.Local).AddTicks(8353), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("e0274120-3714-4aa6-a509-f9364f27ab99"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$S7A/jjCJJYEBXnNds5THXOFYiRmnEK4Nu1YvwfsTbpziupd8WGK0m", false, new DateTime(2023, 3, 8, 23, 40, 4, 359, DateTimeKind.Local).AddTicks(9587), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("e0ae4881-b83a-4f36-ba27-5928af789d21"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$4I4uwlm8ilV4GExAYLKGAeZe7zV5kqwhHdzCFqJp8wU7PIY5aDdnO", false, new DateTime(2023, 3, 8, 23, 40, 9, 4, DateTimeKind.Local).AddTicks(3218), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("e0b5e076-d115-4341-8639-a3438c965a52"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$Lnhy3BUuikdsUBn7pT.aduPUgaVu09cg1e1phhCXCdJP1fo2Euvle", false, new DateTime(2023, 3, 8, 23, 40, 5, 715, DateTimeKind.Local).AddTicks(7580), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("e17b36ae-a505-44ed-887e-2b6907fcc76d"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$hxizvFI9ws85iVeO6J9y6.j6a9zU0VRxpc441uzxBs8duw3blu9k2", false, new DateTime(2023, 3, 8, 23, 40, 6, 511, DateTimeKind.Local).AddTicks(9589), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("e4d70b68-227e-4b3c-a8f7-fa691770abad"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$mkAOojyFWy0zyTiBLLGt/eOFgTudVM.zKLSMpbzch6n/erV68TM9O", false, new DateTime(2023, 3, 8, 23, 39, 59, 227, DateTimeKind.Local).AddTicks(763), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("e56aee9e-69ff-4666-88d3-936da0a3b583"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$yjvTA7qvTVkHAm5OUisppObd76DSGCEvkElpp/2spdW8ja0gMBhKK", false, new DateTime(2023, 3, 8, 23, 40, 8, 119, DateTimeKind.Local).AddTicks(4564), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("e9a3d8e6-1caa-42d3-a03f-d83e6efe6b3d"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$Cjjho01hMHA/6EpKAcY7geDeOxP49wlJYFEC4Gq7xO3zY478qZ8dG", false, new DateTime(2023, 3, 8, 23, 40, 1, 974, DateTimeKind.Local).AddTicks(1495), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("ea234077-bf2c-49b2-a04f-be098396bd07"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$nhvDuCS4brKie.xNxknWJOGCA9t0E2FGWMqF61cpEhY4/CZDorkmu", false, new DateTime(2023, 3, 8, 23, 40, 9, 888, DateTimeKind.Local).AddTicks(9837), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("eddd403c-5120-48f5-a6fd-dcd4b3831200"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$54gL/OYpgHH.GUWtXsZjw.o/svEWw.Rwq2IsI8L2I2H500oOECFXu", false, new DateTime(2023, 3, 8, 23, 40, 0, 459, DateTimeKind.Local).AddTicks(7466), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("ede138ab-ea56-41b0-8e2b-cc963a484db8"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$6PfxYHU0GYkhe9ZJu2eNE.Iu/5oYKSXn..YdDNfm51eu4YDjVbL5u", false, new DateTime(2023, 3, 8, 23, 40, 9, 679, DateTimeKind.Local).AddTicks(9660), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("eeebba58-e1a3-4ce2-9aa8-aca3e3b8c245"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$6g2jC8Ta0lhc9OSE3LfieOYCJKAEX34M1flyEW06On3jAZPgSGl8i", false, new DateTime(2023, 3, 8, 23, 40, 7, 558, DateTimeKind.Local).AddTicks(8841), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("f0586e5b-3221-4d19-b279-4cb57e6c25fc"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$40w5alHHhwlm/dZJ28ed6uWfzQB0sV08YWyb9/GRqc3LwupNl6dT6", false, new DateTime(2023, 3, 8, 23, 40, 8, 319, DateTimeKind.Local).AddTicks(6429), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("f55824fa-d937-41e0-8ba3-bd74e02fcaa3"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$fOXrL420FvpZXmM7lHYqAu1jIOVnGA6eJbTAfsyDrJJrK3gYwNO6W", false, new DateTime(2023, 3, 8, 23, 40, 5, 13, DateTimeKind.Local).AddTicks(7288), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("f656fe11-f258-483d-9bc0-415e755d6e56"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$RvbGHFxrbw/.FqDUUkFd6OTotLUhW5y1Do5nuf33mXVi6Z1SAZIPC", false, new DateTime(2023, 3, 8, 23, 40, 3, 819, DateTimeKind.Local).AddTicks(5680), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("f66e4100-2777-4793-8fcf-e30478e8d22e"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$I.HVdPVk0a2WvsLpAz3n/uubN5bjG0gwoEaIYLA7eF/ix42ZjkyaG", false, new DateTime(2023, 3, 8, 23, 40, 2, 685, DateTimeKind.Local).AddTicks(1158), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("f784c439-07be-4355-a633-44f64e718f00"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$VBj7zKsh3BCtHpr6/cVsrO0/SuFdKwtZJ38hSNl3XvOq3liP/Kvgq", false, new DateTime(2023, 3, 8, 23, 40, 1, 308, DateTimeKind.Local).AddTicks(43), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("f7b30fe3-b819-4b68-a74d-f80ffb6a2362"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$WXtTqTnLECHxtyLFJAFWKOZEWaCiBM5HHk3fcqpMb/d.QZZSXVlGq", false, new DateTime(2023, 3, 8, 23, 40, 0, 720, DateTimeKind.Local).AddTicks(9362), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("fb6d5c59-5741-434d-8572-72dc612cb93e"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$VuptkHDEC5GDo88qRflrE.XDtmE3Yk5F5RgCq5x1s.cHQjFobXn2O", false, new DateTime(2023, 3, 8, 23, 40, 0, 8, DateTimeKind.Local).AddTicks(2774), "Bartosek", null, null, "0266983899", 1, "cbartosek6" }
                });
        }
    }
}
