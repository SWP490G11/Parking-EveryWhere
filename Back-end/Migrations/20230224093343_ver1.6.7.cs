using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver167 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("004dae25-4c10-4e2d-8294-cf8021fbc0c1"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("4ea30399-eca1-4ced-a5ad-d330855be704"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("ac2d79a9-1217-47c3-ae2a-8030449e56c3"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("dc0e2575-5da5-4ae0-bfc4-75e0e576b0a5"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("e15471b7-1621-4aab-8db9-cc3adc0d90a2"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("e8b8ab3d-cd05-46f1-8f3f-d3b35509fb95"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("55597828-cf6a-405a-a8fa-0534aaeb4a3a"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("90a8946b-b16c-4412-9c9f-4b2897f99761"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("c9438219-ca91-4f62-9a1b-fa9931381afc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05f6bbc1-abb3-4a7d-933b-1a88d624b87b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("06e1634a-a1d7-4bcb-9e56-713148f603d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("08156203-21c4-4a13-9562-55f429bd0a9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0bf65e6e-c91d-4906-8340-1fbbbb158b5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0c4a20aa-cba6-40e0-9c91-1ce420670c0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0d7bc5ec-9ca2-41c8-8cda-ecb08e4cfd92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("115cb0fb-29df-499c-9253-4c68f4731d7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("11ac7f26-61a6-49ce-b03a-b4dc0b8dccbc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("120e0972-d8e5-4bb2-b529-834dabc102bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("13e27326-548b-48db-9188-b1b24370681d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("169f9845-354e-435e-9e4c-274fd4415b84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1cc2c7b3-af2f-49a4-8cf7-575b66bc9af8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("24b605de-9ee7-44fa-b0f1-d70c93fe4287"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2531d835-923a-419e-8043-4c179bcd691e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2873f240-2973-4e44-9f7a-77377e39ad68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2a4521e4-53db-44b8-a6ab-2f7e30ed2237"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("30ae993c-d38b-4300-8f2d-76af326d60cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("36e300a6-994a-4fb9-a68f-309d229caef5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3cf726fc-9553-4906-bf59-32ff1562825d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3ec45df9-de96-45af-b57f-286a7b8ab991"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3f5331bc-fb9a-48b4-94a2-1f22b325f8ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("409abc46-966b-417a-afa0-45c715541f64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("41da0eca-9af8-4a01-8296-6051d7dc8aaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("427ee94e-369f-474d-8f07-a69a7d594f60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("42e4ea8d-7203-4681-8a74-d968776efe14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("44ce67e6-8afa-4228-95a5-4d11922f8b65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4733ae1f-74f7-4622-882b-723f2085a466"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4c0e2c64-a503-47a1-8efe-a93be6ea2522"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4ca516ab-b49a-4f8d-abd6-282567c2c125"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4e7194c4-0ccd-4516-9337-c6de2b315e4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4fabcae4-e895-4039-bf7d-5f67a4132fdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4fd00042-18b8-45a8-a1c5-e3b84f8f01f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("52371c8a-644b-425f-9d83-0b0554edcd82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("54822743-9713-4da8-9839-153a9ab4e0cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("55a70b2e-2040-4ddb-9ed2-91be423cd281"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("560455ec-4b1e-44e3-b4db-90ee90be6408"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("57059921-a915-4d71-9192-1d67ffa0631a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5de2d568-d360-41a1-937e-690d6e182d2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("605446ae-42b2-481f-ad0f-674b5a2fe92b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62e1876d-20c7-48ba-b898-60995404b252"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("65644005-4e8f-4efe-938e-8334b41deab2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6570b5eb-d50b-40fe-8a22-05c23bc3a231"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("65fdd40a-d1b7-4255-b808-e3d503e858c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6932e46b-7277-4425-ad85-9d2bcdb00195"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6a1bfe80-b7f8-4aa4-ab3b-0a1c1f1322dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6beafd2e-0d2e-48a7-9768-501a842a88d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6c0b7d8a-0f2e-4f5f-a6ec-5ddc7cde79d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6c456279-ae3a-4957-b7bc-3b65e65dd464"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6dcf768f-2f75-420c-8acc-75d6f5a8444d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6de276c1-57d6-4900-964d-262b03f13431"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6e6122c6-c3e4-49b2-8335-4a496674b1fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f4d166c-6047-4134-8d8f-0fe52f97e142"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("73d68ea8-41bc-4f63-b017-ae7f0d684014"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("747e5e4b-d934-4696-a6be-b661647655b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("761f69dc-0a67-4cb0-8549-35343eb79508"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("80e9b7b1-111f-4a8f-b7af-7f5c81fe64cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("88bbfd92-d994-4c20-8d8c-b55c6e468da8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8a7cb740-0954-436a-8874-425b2d7d1573"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8b2cebf9-cc64-477c-8986-291afac521b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8be7ca8f-8293-4b74-98df-24f702673186"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("930152fd-a6aa-4c7e-a17e-02dd989bcebb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("938d1dec-82a6-47e5-80ca-ae5692eeca6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("94147883-aee4-4917-b5ec-73c4f8ca6a85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("94174f6d-fe49-45ec-a390-6bb67a7b52c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("95261125-f152-408e-8d37-f825db7ed674"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("974a6237-8054-41dc-879f-7f19efff72e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9a4290db-1274-4531-bfcf-ed69c5d37e93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a08dfedd-c831-46ad-93e8-0d6cc485fa69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a2656f9a-ca23-4097-9992-82d504bb7c58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a53b4976-7830-4c0b-bfb6-0781b567c3b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a87d8ceb-2b36-407d-9157-ad873dca29b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a9384a12-86ef-48d6-9621-065e2a2e1376"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a97603a1-25e6-4199-80aa-af071ff6e0cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("accea3c6-6190-4608-91d7-b0d5ca6fd495"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("acdff56c-b2aa-4626-960e-457eb01d3167"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b16487a7-72fd-4e56-bc57-d3947dfa822c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1672a5d-2de5-41fa-b023-172a9db6430d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b4474ddc-819c-42fc-994b-f909a906b761"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b659e8e9-f063-4690-8582-890e72462ba9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b6d87f4c-68a8-4aea-a883-8759dcb680dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b7d8c604-8ec7-4c76-91c7-e4c282c5efd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bb1a7e82-779f-4167-a001-4ae00063f342"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bb227049-07fc-40d3-bcc4-1ab5bfd01072"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bb5e1074-6bbf-4df0-927d-ddce2a2ba83a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bc2b323d-9065-42d3-93af-0d6a1bdee74e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("be3fc07b-e00b-4b7d-8b84-489eeb061440"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d1d52564-6417-4e19-8d58-987917621f25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d4469f21-51a4-4251-8f6c-dce68e3755ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d54749dc-5bda-4c47-8ddc-f0f59355217a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d557d019-61eb-4903-9554-b01e6ab3e57f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d59fd696-7177-41cb-a08d-e11c51bb8a50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e370e1d5-39b4-4b36-a787-47f00f43f732"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4ad3bab-6a0e-4dcf-be75-806f5a7a0a06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e52c32b6-29c4-4f0f-a64a-ed7269e92e21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e698de89-f0d4-4c6e-a689-4467ac47c843"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e6f93e30-ed7a-474d-84c7-48885f5181d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7cb40c0-37b6-450b-9419-a68d19161d3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7f6d13a-3745-48bb-a8d0-0b8cfe5ad52b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e8a0153a-5194-430a-aed3-a4d4767dd1e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ea806a8f-69f2-40b3-9171-bced5316cfee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ea8fc0df-2919-4c47-8069-d6c88917f05c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec80413a-87be-4474-8c33-945137852c8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ef04561b-1d58-4f8d-9fac-6eef77a98d44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("efb2306b-9d10-4d0a-92ff-cc2cc4fae57d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f167fb93-fdaa-41c8-a594-35c595ac1af6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3e61f61-8212-4f07-8a57-1a16f5af48ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f4622b54-e1ad-4f6c-8759-f59b55277ac2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f7c91e20-f341-4cee-80fc-5575db0289d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f89e3bab-4086-46a6-bd76-d1a301a6eed6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f8b2526e-a9dc-4b4e-93b8-ec1f16513b68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f989f35f-27c9-490f-b4f6-e481dc062d00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa076382-41d8-48ac-8a9a-54aa1226fccb"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("004dae25-4c10-4e2d-8294-cf8021fbc0c1"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("4ea30399-eca1-4ced-a5ad-d330855be704"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("ac2d79a9-1217-47c3-ae2a-8030449e56c3"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("dc0e2575-5da5-4ae0-bfc4-75e0e576b0a5"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("e15471b7-1621-4aab-8db9-cc3adc0d90a2"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("e8b8ab3d-cd05-46f1-8f3f-d3b35509fb95"), "xe 5 chỗ", null, null, "SUV5", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("55597828-cf6a-405a-a8fa-0534aaeb4a3a"), "Half Year", new DateTime(2023, 2, 24, 16, 24, 37, 210, DateTimeKind.Local).AddTicks(2161), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90a8946b-b16c-4412-9c9f-4b2897f99761"), "Short time", new DateTime(2023, 2, 24, 16, 24, 37, 210, DateTimeKind.Local).AddTicks(2157), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9438219-ca91-4f62-9a1b-fa9931381afc"), "1 Year", new DateTime(2023, 2, 24, 16, 24, 37, 210, DateTimeKind.Local).AddTicks(2163), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("05f6bbc1-abb3-4a7d-933b-1a88d624b87b"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$Y4NXYU5BMqmh8h13QTg2DOgM2ILXpusqhIe7Yxj83kyt/TEmkEnnG", false, new DateTime(2023, 2, 24, 16, 24, 36, 2, DateTimeKind.Local).AddTicks(6572), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("06e1634a-a1d7-4bcb-9e56-713148f603d3"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$65mF/E79ue.BTzKUm/o4t.pZgBU.Xs5hh0uLtGYaZza/N2GxUjdYS", false, new DateTime(2023, 2, 24, 16, 24, 27, 340, DateTimeKind.Local).AddTicks(6810), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("08156203-21c4-4a13-9562-55f429bd0a9f"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$AjW1GmmnCfp9hjFYPRUqv.g7SQbr4Lpnrccbj3X7WOiWw5ZX80F02", false, new DateTime(2023, 2, 24, 16, 24, 32, 302, DateTimeKind.Local).AddTicks(505), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("0bf65e6e-c91d-4906-8340-1fbbbb158b5a"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$lsStZ.WxmN458G.wwLRCx.8j1HcQmEZp9Pc9gpgNeWTBOw.JWYG7C", false, new DateTime(2023, 2, 24, 16, 24, 32, 769, DateTimeKind.Local).AddTicks(79), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("0c4a20aa-cba6-40e0-9c91-1ce420670c0f"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$6eexZA9b.aVi9BMRiZG/.OdlIqgixqQUjTKwyIMDZCaXocWPBEG/a", false, new DateTime(2023, 2, 24, 16, 24, 36, 718, DateTimeKind.Local).AddTicks(5022), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("0d7bc5ec-9ca2-41c8-8cda-ecb08e4cfd92"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$dvDV7EdDUbUjNDzIaTuUMuTQ9rxmfsp4xuIqm9ZpKIy/eULV58vbW", false, new DateTime(2023, 2, 24, 16, 24, 31, 91, DateTimeKind.Local).AddTicks(6746), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("115cb0fb-29df-499c-9253-4c68f4731d7a"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$mpu.UVg8kwLm8z/Wqs5xpeE67K.qJR6HsTytMAJywj8eA43uq/d/i", false, new DateTime(2023, 2, 24, 16, 24, 35, 145, DateTimeKind.Local).AddTicks(5907), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("11ac7f26-61a6-49ce-b03a-b4dc0b8dccbc"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$Sziym6vQEsGrJZHZUciWvuKiq.Scjbmasg5VDDOC6fMfYW.DJMVFe", false, new DateTime(2023, 2, 24, 16, 24, 36, 215, DateTimeKind.Local).AddTicks(204), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("120e0972-d8e5-4bb2-b529-834dabc102bf"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$B97RmhDUwUv5bgPRmJRpWu1H11h1P4QDLlOnfMeNrW.mJV2.KNNZe", false, new DateTime(2023, 2, 24, 16, 24, 36, 930, DateTimeKind.Local).AddTicks(2142), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("13e27326-548b-48db-9188-b1b24370681d"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$YbQyVZc8MrnwqqdwMtZZ..rvYGDN6WjA5zbc4CgjSVzVqTIIP4cVW", false, new DateTime(2023, 2, 24, 16, 24, 26, 996, DateTimeKind.Local).AddTicks(6695), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("169f9845-354e-435e-9e4c-274fd4415b84"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$EIIKfH57DVh9BhWZMU2zmOvp.pmjlc/Si.2yW85qyDcnhNKFVuEl.", false, new DateTime(2023, 2, 24, 16, 24, 33, 179, DateTimeKind.Local).AddTicks(3093), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("1cc2c7b3-af2f-49a4-8cf7-575b66bc9af8"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$lwy44VFJXwGIAk/Wo4DBv.0kHCL0K2rAoGvkLJS3dH19C2kRUfA7a", false, new DateTime(2023, 2, 24, 16, 24, 35, 357, DateTimeKind.Local).AddTicks(2797), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("24b605de-9ee7-44fa-b0f1-d70c93fe4287"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$S3bUaoxKHOxEPjJlqIMTKOd55pn754Q4M0P2710i.O8tB1OgaLYeK", false, new DateTime(2023, 2, 24, 16, 24, 36, 360, DateTimeKind.Local).AddTicks(6208), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("2531d835-923a-419e-8043-4c179bcd691e"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$TqiolnX9L6Gb.mnkSprab.SqE5x765ePM0.BD2RmhXExVrWV7mCGm", false, new DateTime(2023, 2, 24, 16, 24, 35, 583, DateTimeKind.Local).AddTicks(760), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("2873f240-2973-4e44-9f7a-77377e39ad68"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$RTJCbtBfywzFvGyuu7RIMOAForDW60pEktKawUAVLl6ncNm60Rvp6", false, new DateTime(2023, 2, 24, 16, 24, 34, 846, DateTimeKind.Local).AddTicks(8224), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("2a4521e4-53db-44b8-a6ab-2f7e30ed2237"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$pxPSVZrgiEX0yvbRrCEQTeVn5NerpdC0vTGgHWaT1aMa8TzycJ4vS", false, new DateTime(2023, 2, 24, 16, 24, 33, 267, DateTimeKind.Local).AddTicks(1503), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("30ae993c-d38b-4300-8f2d-76af326d60cb"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$bygQF6WMbSrMmmuX0a.ssOmhJv1FpMyEuQITumIY435zDluWpemvq", false, new DateTime(2023, 2, 24, 16, 24, 29, 753, DateTimeKind.Local).AddTicks(1827), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("36e300a6-994a-4fb9-a68f-309d229caef5"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$KGCynNUN8CpHdr8sloqLuuBG.unwcFZDtpHhENoxR/zR4LWW8gWmW", false, new DateTime(2023, 2, 24, 16, 24, 32, 502, DateTimeKind.Local).AddTicks(6338), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("3cf726fc-9553-4906-bf59-32ff1562825d"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$pi0dcxm4iDKizm202dxN1OAFep3M8/28WkpfcQGJstiosi99tYmLq", false, new DateTime(2023, 2, 24, 16, 24, 37, 139, DateTimeKind.Local).AddTicks(9742), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("3ec45df9-de96-45af-b57f-286a7b8ab991"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$gSXCY3orzaSB4xlX2T./vuuWnTMHy5DiS/7SSHGPMnBQsfOlGPhGC", false, new DateTime(2023, 2, 24, 16, 24, 33, 816, DateTimeKind.Local).AddTicks(9386), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("3f5331bc-fb9a-48b4-94a2-1f22b325f8ea"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$45mG/gt6.jaK9QcG5qAq3.Su4n1.eQZD4VfgWylNe/bmTAbrKOBEO", false, new DateTime(2023, 2, 24, 16, 24, 27, 489, DateTimeKind.Local).AddTicks(72), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("409abc46-966b-417a-afa0-45c715541f64"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$Jf6V0BC1udUAosnpM.jyr.dtKMdGc4hHqHKil23V/pKRnLAi/Pb6y", false, new DateTime(2023, 2, 24, 16, 24, 35, 659, DateTimeKind.Local).AddTicks(9592), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("41da0eca-9af8-4a01-8296-6051d7dc8aaa"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$nNPuihCS5IWydAPEi7.BIOiKOJ9Tu9xNNdq0tN/6XC5sSMOIh9zp.", false, new DateTime(2023, 2, 24, 16, 24, 30, 394, DateTimeKind.Local).AddTicks(1877), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("427ee94e-369f-474d-8f07-a69a7d594f60"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$2blBs7tQ4PylEIF/Siv7B.Hx8F/ctcpn6oCqgs7gM/MG8930V/kMC", false, new DateTime(2023, 2, 24, 16, 24, 27, 65, DateTimeKind.Local).AddTicks(5138), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("42e4ea8d-7203-4681-8a74-d968776efe14"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$jYzLDrFMbzeL47g.Z27mRuKrWEBVjlmBHlm40A2L9nDtgwBPh1wCu", false, new DateTime(2023, 2, 24, 16, 24, 33, 444, DateTimeKind.Local).AddTicks(9774), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("44ce67e6-8afa-4228-95a5-4d11922f8b65"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$HKZYBW0Cgira9SpgqW0ct.qoH1UA6ZIoUU8lb9eAngMHO5gcnvqpm", false, new DateTime(2023, 2, 24, 16, 24, 29, 426, DateTimeKind.Local).AddTicks(5698), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("4733ae1f-74f7-4622-882b-723f2085a466"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$xOr27eHBhNJQIf.OPsNFP.pSHW7jciQEbwIh.T8l3zprfejvqlvbW", false, new DateTime(2023, 2, 24, 16, 24, 33, 31, DateTimeKind.Local).AddTicks(725), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("4c0e2c64-a503-47a1-8efe-a93be6ea2522"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$Jm991i7pOfpj6CfLaLUI1OAdHaTJEgq4JnlkaI8pRd/o.OFYqFaL2", false, new DateTime(2023, 2, 24, 16, 24, 26, 646, DateTimeKind.Local).AddTicks(8550), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("4ca516ab-b49a-4f8d-abd6-282567c2c125"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$EUVrQ8iFwGFoXQY30cIw.OoZzz6d72sSFWlTklr3Bu1t2iHHqAwnC", false, new DateTime(2023, 2, 24, 16, 24, 27, 842, DateTimeKind.Local).AddTicks(4725), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("4e7194c4-0ccd-4516-9337-c6de2b315e4a"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$gLOuP7khu0XlPlWlPhqSaOh4.fEH.EskYmyofjb2aZZtVtkY71Df6", false, new DateTime(2023, 2, 24, 16, 24, 34, 931, DateTimeKind.Local).AddTicks(412), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("4fabcae4-e895-4039-bf7d-5f67a4132fdc"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$MibpvxCtV.oOiomFogY/yuai2mszsn9rG/ZnMTUHF0h36ioSrMmCS", false, new DateTime(2023, 2, 24, 16, 24, 34, 594, DateTimeKind.Local).AddTicks(2876), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("4fd00042-18b8-45a8-a1c5-e3b84f8f01f6"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$hPPzvbfuAETypZVcVA48muce.jzxK4bMeOeGVqG2GqMOCx4PCFZFK", false, new DateTime(2023, 2, 24, 16, 24, 31, 255, DateTimeKind.Local).AddTicks(9641), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("52371c8a-644b-425f-9d83-0b0554edcd82"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$ZXmVj6786Ms6bYKP3ovQLeez7rSFNkoFoRJiEaVczmZBIG3xSmWgy", false, new DateTime(2023, 2, 24, 16, 24, 35, 78, DateTimeKind.Local).AddTicks(6833), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("54822743-9713-4da8-9839-153a9ab4e0cf"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$mV9elS9z.tmF4/XM3x.O1e74.U/affTSxBziwl6DVcpga3S5uvZ3y", false, new DateTime(2023, 2, 24, 16, 24, 28, 943, DateTimeKind.Local).AddTicks(5411), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("55a70b2e-2040-4ddb-9ed2-91be423cd281"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$sHMs03OiSKSaRKYLDzuoRuUk9bM.8fBytOXKOgMt7cFDDjvXKjOfS", false, new DateTime(2023, 2, 24, 16, 24, 36, 75, DateTimeKind.Local).AddTicks(7872), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("560455ec-4b1e-44e3-b4db-90ee90be6408"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$YdhcONuowQrWzDx4WeSZuO8jdEe.icsUT7xsmECNgqyv0htJcIFFq", false, new DateTime(2023, 2, 24, 16, 24, 34, 146, DateTimeKind.Local).AddTicks(4247), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("57059921-a915-4d71-9192-1d67ffa0631a"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$4NJheridpKwdD0O5nWsiB..H2rCZFcdqxw4HjSpoyIwnv9pGdRQVW", false, new DateTime(2023, 2, 24, 16, 24, 34, 761, DateTimeKind.Local).AddTicks(5852), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("5de2d568-d360-41a1-937e-690d6e182d2a"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$YBKMI8ILTwXuoPCBCZ4aIOSufLrpNhilxbK5rm7hz6IfQ00YCOkeC", false, new DateTime(2023, 2, 24, 16, 24, 30, 73, DateTimeKind.Local).AddTicks(7688), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("605446ae-42b2-481f-ad0f-674b5a2fe92b"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$sSKJz3TOrfLSF.Q0rBNr8uXxpNeWuTXfcagCs8aEdcDnnCX2wb3Da", false, new DateTime(2023, 2, 24, 16, 24, 36, 784, DateTimeKind.Local).AddTicks(7850), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("62e1876d-20c7-48ba-b898-60995404b252"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$OgEAEFXMWvuCnnVHNMbhS.Eofgy4QeND0FzAw7vitZiZDBTf3P6gO", false, new DateTime(2023, 2, 24, 16, 24, 27, 420, DateTimeKind.Local).AddTicks(3270), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("65644005-4e8f-4efe-938e-8334b41deab2"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$cmtcftUK3fgZhMw0c/GwwuJF3CtU97LiQAUv5elHwgwByMnCgua76", false, new DateTime(2023, 2, 24, 16, 24, 34, 296, DateTimeKind.Local).AddTicks(2126), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("6570b5eb-d50b-40fe-8a22-05c23bc3a231"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$Ln4d3WNCdChIUTTxR9eWJumxkOLAelSnY0NWyLjnILiPEE.i7w7tG", false, new DateTime(2023, 2, 24, 16, 24, 31, 615, DateTimeKind.Local).AddTicks(9143), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("65fdd40a-d1b7-4255-b808-e3d503e858c4"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$JVpB5ZEJ.3YxjzJHj5gz/ugf0BfHmXvoZ3t0X.7A8aKSGAcmwb/pW", false, new DateTime(2023, 2, 24, 16, 24, 34, 444, DateTimeKind.Local).AddTicks(5123), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("6932e46b-7277-4425-ad85-9d2bcdb00195"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$med0aNVmlYkIGMxERgLr/exy5m6787Uwp52/K.GpvBfSpQs3E4xwi", false, new DateTime(2023, 2, 24, 16, 24, 29, 913, DateTimeKind.Local).AddTicks(9691), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("6a1bfe80-b7f8-4aa4-ab3b-0a1c1f1322dc"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$FVoWvSJNYUxmlfZ1jTjtQezeewtTzDpWeZiesoZ7WiS2ItdrxtEaS", false, new DateTime(2023, 2, 24, 16, 24, 27, 205, DateTimeKind.Local).AddTicks(3716), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("6beafd2e-0d2e-48a7-9768-501a842a88d6"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$SwDAzdKtoTM04nCvlRgaAeZ/LRpDnVx9i/3twqrrB1Obyj13eTH7S", false, new DateTime(2023, 2, 24, 16, 24, 33, 596, DateTimeKind.Local).AddTicks(5358), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("6c0b7d8a-0f2e-4f5f-a6ec-5ddc7cde79d7"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$BPGkY9leaDyZGXz09qa/h.U.YKURvoTG3aZStknoJZOnBpV/eyK/S", false, new DateTime(2023, 2, 24, 16, 24, 35, 429, DateTimeKind.Local).AddTicks(822), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("6c456279-ae3a-4957-b7bc-3b65e65dd464"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$junHHsQIwz2RC1khr55EEOc5ndmJL7hf3CwJFg72Ajs40K94cy1mG", false, new DateTime(2023, 2, 24, 16, 24, 35, 757, DateTimeKind.Local).AddTicks(1428), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("6dcf768f-2f75-420c-8acc-75d6f5a8444d"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$./URdustlqpCAERmHHoxZOR6wRaEQrUPFqIVWphqTpCeKshHBfu0y", false, new DateTime(2023, 2, 24, 16, 24, 34, 69, DateTimeKind.Local).AddTicks(7347), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("6de276c1-57d6-4900-964d-262b03f13431"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$N6FH5eaHymgo4Y7ZJok0YOEY7STXMhwSXGcFgbj0K79oyvAuwZpWS", false, new DateTime(2023, 2, 24, 16, 24, 26, 733, DateTimeKind.Local).AddTicks(5411), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("6e6122c6-c3e4-49b2-8335-4a496674b1fc"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$U5psvTS7jMhboY51Q8i2ZebPBSPnpw1PVMhGZ9RT4Q2A54jAHEzx.", false, new DateTime(2023, 2, 24, 16, 24, 27, 669, DateTimeKind.Local).AddTicks(3938), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("6f4d166c-6047-4134-8d8f-0fe52f97e142"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$GBfGQ/9Tzz/DUY0G5srLdO/8NXHyzRJ9Q9aCx1JBzCqacma/krRxK", false, new DateTime(2023, 2, 24, 16, 24, 33, 989, DateTimeKind.Local).AddTicks(9504), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("73d68ea8-41bc-4f63-b017-ae7f0d684014"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$pz77CXqzXHg.mr31qD6SKeOgXOr.L76.kvgM9O5ShZvwpMAPXGJny", false, new DateTime(2023, 2, 24, 16, 24, 27, 132, DateTimeKind.Local).AddTicks(8659), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("747e5e4b-d934-4696-a6be-b661647655b9"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$JDNBYXvOmQYAgGn4h96qpueAaWacn0g9Uj3CqNo5pxc8GnbE7GsRW", false, new DateTime(2023, 2, 24, 16, 24, 30, 600, DateTimeKind.Local).AddTicks(2385), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("761f69dc-0a67-4cb0-8549-35343eb79508"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$SpQDsvmRW23VL6bKiIHw3uRMJVMlJyCw6qN.ZIEvXiNfiJoVHq15S", false, new DateTime(2023, 2, 24, 16, 24, 37, 70, DateTimeKind.Local).AddTicks(7319), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("80e9b7b1-111f-4a8f-b7af-7f5c81fe64cc"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$yqZK3yb6j9SXcPXoWxuAeedhjYnnn/Dio.nUJNPmxwHskYsVOLFgK", false, new DateTime(2023, 2, 24, 16, 24, 37, 210, DateTimeKind.Local).AddTicks(903), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("88bbfd92-d994-4c20-8d8c-b55c6e468da8"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$XQRH7b70c.pYzDnyFzysvuCrKOs6en9x60S5/U.1cHvMnmMp/FoM.", false, new DateTime(2023, 2, 24, 16, 24, 32, 854, DateTimeKind.Local).AddTicks(1544), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("8a7cb740-0954-436a-8874-425b2d7d1573"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$ccA0D5mrlbPu10R0xPM6buZvjzWCcrqVmekHyORs/5oASdZgdf2Qu", false, new DateTime(2023, 2, 24, 16, 24, 33, 668, DateTimeKind.Local).AddTicks(7797), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("8b2cebf9-cc64-477c-8986-291afac521b0"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$S2LvJfKtLS6PCvPw9C9qVugh6mqIJjCZZMdwizgJ.C282hKcqSJOK", false, new DateTime(2023, 2, 24, 16, 24, 31, 956, DateTimeKind.Local).AddTicks(9185), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("8be7ca8f-8293-4b74-98df-24f702673186"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$SK/cs3s59C4XA03Lt4AY/OolKN0bpGh0rfp7IYZ/.JqLQldrnfUG6", false, new DateTime(2023, 2, 24, 16, 24, 34, 669, DateTimeKind.Local).AddTicks(4944), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("930152fd-a6aa-4c7e-a17e-02dd989bcebb"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$jT/Hcg/dUZeufgzUUvVzGum2jGYATZb5m3GzDa.n74vu6qx/FppE.", false, new DateTime(2023, 2, 24, 16, 24, 28, 2, DateTimeKind.Local).AddTicks(9364), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("938d1dec-82a6-47e5-80ca-ae5692eeca6c"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$wFoO7jQSvyxXu5iDEXjdTu1UdO3eIOkopTLf0M91ISkSrOE5uDcw6", false, new DateTime(2023, 2, 24, 16, 24, 26, 399, DateTimeKind.Local).AddTicks(5875), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("94147883-aee4-4917-b5ec-73c4f8ca6a85"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$NFMqT5Dn03MttcyFniIeNuz.vpOTZc2Gc2J5psGHszQVoxilYzLgC", false, new DateTime(2023, 2, 24, 16, 24, 32, 128, DateTimeKind.Local).AddTicks(7180), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("94174f6d-fe49-45ec-a390-6bb67a7b52c5"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$/1s6j5.1FdUt/xq5W4SH8uCuXdhmhUbKQQE0XqJo5l.9w5XBY5/yi", false, new DateTime(2023, 2, 24, 16, 24, 35, 285, DateTimeKind.Local).AddTicks(6364), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("95261125-f152-408e-8d37-f825db7ed674"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$FwXIjJ/K4qazxj90GDX.xOXNFDWzS.hqxfqYD7viKjhLklj9HNvaO", false, new DateTime(2023, 2, 24, 16, 24, 32, 954, DateTimeKind.Local).AddTicks(94), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("974a6237-8054-41dc-879f-7f19efff72e7"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$cQ6von3mqZaHhIm.6yAIOOhI5MOwYteCRDZnqzzkcDKucvPcgkBt.", false, new DateTime(2023, 2, 24, 16, 24, 27, 923, DateTimeKind.Local).AddTicks(9207), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("9a4290db-1274-4531-bfcf-ed69c5d37e93"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$bnwG.Bpfap2JH9KofHWAaedDtCWsqxlvjhEfcQfqAu5zJOZ0MLcgi", false, new DateTime(2023, 2, 24, 16, 24, 28, 778, DateTimeKind.Local).AddTicks(1555), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("a08dfedd-c831-46ad-93e8-0d6cc485fa69"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$5cdHHLAVXM2b4cbGuHwEoeXeI5MScsTjy/LLQkNA/dFFuSXGZtoOW", false, new DateTime(2023, 2, 24, 16, 24, 28, 253, DateTimeKind.Local).AddTicks(9392), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("a2656f9a-ca23-4097-9992-82d504bb7c58"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$ngRl6l9FhYFCjbUmLg5HOuVev9yslex316nYuLJ0XzvLC0qhxr2Nu", false, new DateTime(2023, 2, 24, 16, 24, 30, 770, DateTimeKind.Local).AddTicks(5324), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("a53b4976-7830-4c0b-bfb6-0781b567c3b6"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$HEO6hZ9.rozqRb/4clTteeVYz3ptFmItx815C2E4Vue0bCD9ItA0i", false, new DateTime(2023, 2, 24, 16, 24, 29, 264, DateTimeKind.Local).AddTicks(5138), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("a87d8ceb-2b36-407d-9157-ad873dca29b6"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$acAAFKh2jPKGr81JrSi8O.D6QQ8oaOcaP1t.nOkkdccPv200N3RX2", false, new DateTime(2023, 2, 24, 16, 24, 33, 743, DateTimeKind.Local).AddTicks(8184), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("a9384a12-86ef-48d6-9621-065e2a2e1376"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$AisZXC4KKndye231avoAguyVXZbedMLZK8yvx0fvJUUIPu6XE58xq", false, new DateTime(2023, 2, 24, 16, 24, 33, 522, DateTimeKind.Local).AddTicks(2287), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("a97603a1-25e6-4199-80aa-af071ff6e0cf"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$jbgbD0Hh.TOUU8XLf8PSFeIogo66g/uk1Fpbijh/GbtKXroYqm5eS", false, new DateTime(2023, 2, 24, 16, 24, 31, 417, DateTimeKind.Local).AddTicks(7765), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("accea3c6-6190-4608-91d7-b0d5ca6fd495"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$zoOdZok1NX9FfMXlJfM5nuW7v8mySBHLMPGOlJbRsfWfMMtjNA7uO", false, new DateTime(2023, 2, 24, 16, 24, 30, 233, DateTimeKind.Local).AddTicks(4896), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("acdff56c-b2aa-4626-960e-457eb01d3167"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$xSEYiQzSHg8OwfNqf/HHiOazfS8QUj3iZ1h7vp3xqfZftm2Daour6", false, new DateTime(2023, 2, 24, 16, 24, 36, 653, DateTimeKind.Local).AddTicks(5508), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("b16487a7-72fd-4e56-bc57-d3947dfa822c"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$f.QXLUEwWj7lEbUEKE1YouNYuWXbHxaBDBo5J/U6L2o89Pog5usUy", false, new DateTime(2023, 2, 24, 16, 24, 36, 289, DateTimeKind.Local).AddTicks(7883), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("b1672a5d-2de5-41fa-b023-172a9db6430d"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$BA0M6g/J5Ec2WDMD8bNoyuOsjfvrF.KZx.i4QCCUZWfXxS8/DKnOC", false, new DateTime(2023, 2, 24, 16, 24, 33, 899, DateTimeKind.Local).AddTicks(7325), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("b4474ddc-819c-42fc-994b-f909a906b761"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$bgDLuRkUFQbxns8yngD1XeZlZ88f7YMMqtBhfkLPHImvul1JS/38W", false, new DateTime(2023, 2, 24, 16, 24, 33, 362, DateTimeKind.Local).AddTicks(8435), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("b659e8e9-f063-4690-8582-890e72462ba9"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$wOG1Vl7l.mO12CL1UxT6GuyTnah7mGPnY.DBwosG9I9rNOH8BY.8G", false, new DateTime(2023, 2, 24, 16, 24, 32, 429, DateTimeKind.Local).AddTicks(2657), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("b6d87f4c-68a8-4aea-a883-8759dcb680dc"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$U.whUVLTRF5yh5qxmmzXgOnRv1/U0XAduzjNuTLmk7yw7ELKL.Hrq", false, new DateTime(2023, 2, 24, 16, 24, 27, 573, DateTimeKind.Local).AddTicks(531), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("b7d8c604-8ec7-4c76-91c7-e4c282c5efd7"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$.3Ra3wu8BMP1MQsDpQfraetfLBC5Tx4uuuNg9qlL636CYRnKyPy.C", false, new DateTime(2023, 2, 24, 16, 24, 28, 618, DateTimeKind.Local).AddTicks(7591), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("bb1a7e82-779f-4167-a001-4ae00063f342"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$6f2jykaOXCxUx.jSJFalbO/voJZkCedfO8eG1nI866JSXAvxJjPKm", false, new DateTime(2023, 2, 24, 16, 24, 28, 167, DateTimeKind.Local).AddTicks(2310), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("bb227049-07fc-40d3-bcc4-1ab5bfd01072"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$4nBIzySGeTlvTpthgCs0hOOeJjGhGX3M8VxjxGFIORthVFQukrKRW", false, new DateTime(2023, 2, 24, 16, 24, 35, 6, DateTimeKind.Local).AddTicks(4325), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("bb5e1074-6bbf-4df0-927d-ddce2a2ba83a"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$yHq4kujdD/NXhQ1BIY6QO.5Pm7/LSJ43UEbzGd95y7WQ2EpxqCSGW", false, new DateTime(2023, 2, 24, 16, 24, 26, 474, DateTimeKind.Local).AddTicks(5359), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("bc2b323d-9065-42d3-93af-0d6a1bdee74e"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$DP1N/k7VvGnb9UPnCi7ZJuz9MfN4eEtqst4Ed2ylLHYd10ZcDxmmq", false, new DateTime(2023, 2, 24, 16, 24, 36, 516, DateTimeKind.Local).AddTicks(2711), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("be3fc07b-e00b-4b7d-8b84-489eeb061440"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$tocW/G02uF2nNWyewIFT7ON8OxjZzNJVgB1KQ.oaIVVzfO1zYMMDy", false, new DateTime(2023, 2, 24, 16, 24, 36, 854, DateTimeKind.Local).AddTicks(2251), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("d1d52564-6417-4e19-8d58-987917621f25"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$/0fUXNaZ7aDWkdEkir3ltO/uzmLWGIbCDfuoH3txHmnhI6zYbPwze", false, new DateTime(2023, 2, 24, 16, 24, 35, 932, DateTimeKind.Local).AddTicks(3681), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("d4469f21-51a4-4251-8f6c-dce68e3755ee"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$qbvTH7tjx1lR2by.J08fmugGWO1gJbLZFqXUPy2HbjFstcpNBH0q.", false, new DateTime(2023, 2, 24, 16, 24, 35, 507, DateTimeKind.Local).AddTicks(5405), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("d54749dc-5bda-4c47-8ddc-f0f59355217a"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$SUWEqxM5hkZmJ/npI3bhr.Xi0FtVMl3UaZvGouT6jWuFOYJQNUNVe", false, new DateTime(2023, 2, 24, 16, 24, 33, 104, DateTimeKind.Local).AddTicks(6344), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("d557d019-61eb-4903-9554-b01e6ab3e57f"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$liOFHw9uzAK6LjYH21xyHe.rtOoANC8YT5Ug6AJozqlsO1QlEiI06", false, new DateTime(2023, 2, 24, 16, 24, 34, 369, DateTimeKind.Local).AddTicks(5221), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("d59fd696-7177-41cb-a08d-e11c51bb8a50"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$166A1Vh3dXdyCN9C41Sdze9uK8Co/6al/rAtUYFVPpuPLXK/FTZcW", false, new DateTime(2023, 2, 24, 16, 24, 26, 920, DateTimeKind.Local).AddTicks(1293), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("e370e1d5-39b4-4b36-a787-47f00f43f732"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$OMPgn/Z6rGEj.zNlZZdf/uhQqtoAddmfRlDjLdlTvMHfg3tv17ZaS", false, new DateTime(2023, 2, 24, 16, 24, 28, 450, DateTimeKind.Local).AddTicks(3147), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("e4ad3bab-6a0e-4dcf-be75-806f5a7a0a06"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$VI6BW6Alyk1at4Sp00rCB.d4Wn/QTcF9HoWS9dtZkuyF7MCuipK7S", false, new DateTime(2023, 2, 24, 16, 24, 35, 214, DateTimeKind.Local).AddTicks(5707), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("e52c32b6-29c4-4f0f-a64a-ed7269e92e21"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$AYnqRnKkedv5WatgF8GsLezHFbGZnebPThd5YVIgVonggImk4CO0O", false, new DateTime(2023, 2, 24, 16, 24, 36, 441, DateTimeKind.Local).AddTicks(2745), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("e698de89-f0d4-4c6e-a689-4467ac47c843"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$NHLTMEy9nuFb0od6OR/5cO3w0j7ia9pMDWgDVVi.PxC9YXnSX73wK", false, new DateTime(2023, 2, 24, 16, 24, 26, 835, DateTimeKind.Local).AddTicks(9535), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("e6f93e30-ed7a-474d-84c7-48885f5181d0"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$azkLYA98xgQi/9Q0IYw0ouPAQ8pKRiw9HqZbpev3Exc5NXal7YG2e", false, new DateTime(2023, 2, 24, 16, 24, 27, 752, DateTimeKind.Local).AddTicks(8721), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("e7cb40c0-37b6-450b-9419-a68d19161d3a"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$pnV/xo.nLEQCyD13650AEOUlOZPvOcL5pgbh3sqClD5dQx7qT98T2", false, new DateTime(2023, 2, 24, 16, 24, 29, 105, DateTimeKind.Local).AddTicks(6955), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("e7f6d13a-3745-48bb-a8d0-0b8cfe5ad52b"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$uguDOCOf.XTXgDQVhP3.w.y9s2eeagPEPRW36ADSqBGdhIdP/yzUy", false, new DateTime(2023, 2, 24, 16, 24, 27, 273, DateTimeKind.Local).AddTicks(1885), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("e8a0153a-5194-430a-aed3-a4d4767dd1e6"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$CoVHmifjblC4c.X5Ydj.o.JaWQETXJYZbgGSdM8PSjTkn0S.44aO.", false, new DateTime(2023, 2, 24, 16, 24, 36, 147, DateTimeKind.Local).AddTicks(8454), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("ea806a8f-69f2-40b3-9171-bced5316cfee"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$RxuGBh7q57SnTCVnWEqVUeJUfqbdiMMi9uio9GinrCE23oNUHpvbW", false, new DateTime(2023, 2, 24, 16, 24, 32, 689, DateTimeKind.Local).AddTicks(3573), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("ea8fc0df-2919-4c47-8069-d6c88917f05c"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$1do6KV2FK86VBLXODU8EK.hK/o4XDaHYyKLsPxs1AHdPM/qmJFkuS", false, new DateTime(2023, 2, 24, 16, 24, 28, 86, DateTimeKind.Local).AddTicks(7921), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("ec80413a-87be-4474-8c33-945137852c8f"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$sw4eMoGGkC8J51U5dX4bNeNxf0feFvp2iTgSaL2UEtTp/8hvZwdCW", false, new DateTime(2023, 2, 24, 16, 24, 29, 594, DateTimeKind.Local).AddTicks(2707), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("ef04561b-1d58-4f8d-9fac-6eef77a98d44"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$6scaOUreNHUhBqjw8fyWd.ncqp8Qub6wDS7H.IDRc.dEqxmFVWqNu", false, new DateTime(2023, 2, 24, 16, 24, 26, 562, DateTimeKind.Local).AddTicks(2885), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("efb2306b-9d10-4d0a-92ff-cc2cc4fae57d"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$KxstfdRod9AEzcZSxSqUJuCVxxG3wDDaSDxpFoqqt4eSmrsknCoWq", false, new DateTime(2023, 2, 24, 16, 24, 30, 929, DateTimeKind.Local).AddTicks(7891), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("f167fb93-fdaa-41c8-a594-35c595ac1af6"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$yn7j9E.m90DF0cvqqEFVj.miCADeuNhBRhPEdfywkr.LyNM4/RrFS", false, new DateTime(2023, 2, 24, 16, 24, 36, 585, DateTimeKind.Local).AddTicks(6983), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("f3e61f61-8212-4f07-8a57-1a16f5af48ff"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$KHfuNjBFvFAMq0PQGRIYTuKUr6JUv297qXJDXJG8cz1XqP2lXWsT.", false, new DateTime(2023, 2, 24, 16, 24, 28, 332, DateTimeKind.Local).AddTicks(8425), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("f4622b54-e1ad-4f6c-8759-f59b55277ac2"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$KpyfPwUGxAG7.BXf14lXU.6WWIPRokaFbhqG1ZSfVO60Hl9csHMiK", false, new DateTime(2023, 2, 24, 16, 24, 34, 222, DateTimeKind.Local).AddTicks(5885), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("f7c91e20-f341-4cee-80fc-5575db0289d1"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$V66ZFMiE5MY0Y8xca1tQyOKN8qQFZu5nrhB17BVypqWRXg7g5UclO", false, new DateTime(2023, 2, 24, 16, 24, 31, 796, DateTimeKind.Local).AddTicks(3643), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("f89e3bab-4086-46a6-bd76-d1a301a6eed6"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$2HxobVYYfN3r8qf4hg7CG.TMVMHf8Tgwy2CcKJXkj5lnz0FLqgVE6", false, new DateTime(2023, 2, 24, 16, 24, 35, 853, DateTimeKind.Local).AddTicks(7494), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("f8b2526e-a9dc-4b4e-93b8-ec1f16513b68"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$A6EFpU8R9thF9KUDEGaLzOR.AkbsERxffond2am6QjetOiFgwWAYe", false, new DateTime(2023, 2, 24, 16, 24, 36, 999, DateTimeKind.Local).AddTicks(5905), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("f989f35f-27c9-490f-b4f6-e481dc062d00"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$kHlcik/XC7PibGqPFsXZPOXvzeJJxaPYqHRrWzHAqC5CBeQVJ4wcG", false, new DateTime(2023, 2, 24, 16, 24, 34, 517, DateTimeKind.Local).AddTicks(9341), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("fa076382-41d8-48ac-8a9a-54aa1226fccb"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$kBuT7.zegJPk8etAH4LVVuxQjwMqk.uMJ4wEgueFpxxsxzAptgQ6G", false, new DateTime(2023, 2, 24, 16, 24, 32, 592, DateTimeKind.Local).AddTicks(822), "Laidel", null, null, "06837677860", 2, "blaidel1e" }
                });
        }
    }
}
