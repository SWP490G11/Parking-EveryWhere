using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver177 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetail_Cars_CarID",
                table: "ParkingDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetail_Slots_SlotID",
                table: "ParkingDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetail_TimeFrames_TimeFrameID",
                table: "ParkingDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetail_Users_LastModifyByID",
                table: "ParkingDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkingDetail",
                table: "ParkingDetail");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("2f72327f-c5db-4bcd-934c-a0d6ab480570"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("690c93be-6a9b-4e2c-9493-a048c9ee2b2c"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("8c1e5706-f75f-45c9-bf70-f6fa6d9cff3b"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("ad4e7b09-aa63-42df-a611-f0aaccba6d93"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("e8963ee2-fa4a-4d4b-b68f-0f25b76982de"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("f4325f84-803c-4a7c-993a-d8f912e3fe91"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("65b1d02e-9abf-4906-a1a5-f66a5803502d"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("afd035f0-8197-48c3-9cd6-eac0723231be"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("ea0bd066-3ddd-4b60-a59c-03b38c3ee26f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("02669ff6-4409-4936-970b-a8d6fa9679c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0466d993-11f2-427d-8fad-004699c7a736"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("04dae511-0cac-45c8-8a1e-1b06d24b85e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("051828a2-607d-49ea-8051-e6d582e8619c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("054c020d-32cd-46fe-95ca-78ce3e3b81c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("08f0e308-3ed8-43b5-91f5-a9289c87ae28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0a3f0eff-e27a-4018-9eb1-e21043c8da7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0b4b5212-8f22-464d-ab8b-942fab26e357"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0c2e0238-67ec-435c-92bd-7c1a308cb49a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0edfa40d-7479-41bb-8c65-dc171d94d3db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("132e4d19-d526-48af-92da-b46d9600952f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("149d4b61-316d-4c94-a960-ad232855ba65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1629aa31-777b-4fdd-9efc-b3f20c62de10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1d24c599-d9be-459f-802e-da14b8685e1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1d69b426-62b7-4aae-b91f-427a2fce8f09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("20c9145c-76ce-46ae-b1db-c5f99a33ad7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("215f7d61-1fd4-40ea-bdcd-51763754d4f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("21c710a2-e8e1-4e59-a854-dd8df1805142"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("22658863-1443-4205-84d0-33ac0a417235"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("26f87233-8260-405d-9032-ffc755264462"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("291b6209-18a4-4899-8db8-a456db1cc817"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("29da4179-4959-4150-b34d-ccc19b38ec55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2fe84655-450f-4d01-abc1-5c8fa807a1b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("31e33406-61a3-49dd-ae6b-6f2103d081d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("33d02cc5-fa54-4f04-b550-520c6fe89a47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("363199c4-7cf9-48f0-81a1-fffb3a89182f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("37e9f7c8-c0e1-4980-932b-e07361107690"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3ada371b-2a6b-403a-ad7b-07b338f84cd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3e0291fb-9f9a-412f-91fe-bdcd297a9d9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3f6944af-25c0-483e-a092-4cdee45ec7af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("410640ae-b850-4b10-bcdf-e7a3865c8480"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("43f057ad-8447-4d37-9f4e-bf6168bb572c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("44e8a138-c2ad-44c3-b148-09f049cc6863"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("494bb58f-38b6-4705-a107-fc50da6873b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("497eafc0-80f2-42e1-a615-52ed0c135e66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("49819253-38f1-4215-951a-cdc4cdb7dc0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4a1abdf2-6981-4c7b-b5e2-b7a44227420a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4b928b19-97e7-4c44-bb94-02aa49303739"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5211fb2c-7714-49f4-8b03-bc1fb77ba2e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5231e00a-6764-4671-a624-453d8c6ab36c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("52abe7f9-ad6c-49c4-b4d0-30a03a22c31b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("57ba35ea-8d4a-41ff-afe5-9baecd8186c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("58c5fcf3-0bd3-4855-bcc5-a3cd45d215f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("590594dc-742d-4802-b441-e1d58bd33940"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("59bdbc23-8cea-4153-a14f-bcac02311f22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5df1c6c3-c1de-42b1-a92c-bc0463d17140"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5eb4cdf9-7e29-4c2c-a58d-6b7e75bbd902"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("60509131-3fb9-4af5-884c-2a4949c7ac6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("610aa9b6-c917-4979-a165-8d50a8752cdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("614afcd2-2fd7-47e4-87ba-6d8f26032ed0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("634b1489-1213-4b02-9222-8039c289aa20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6403ea20-4d91-406c-9979-86497ca8b772"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("66515378-07de-4299-96ef-a92336e64c12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6896f6a7-012d-4ba2-a9ec-4c1465374ad6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6ab6e29d-8868-4a23-b1c2-943624f9eef5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6ce91831-90fb-4cd2-8932-1564e1162ef1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6dc67c92-2a8b-4355-9689-bdeb478d9fa1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6e2140a9-9b49-4456-bf3c-efc307d956ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7338db61-9e48-4173-bd84-a210a8029c96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("744c9299-6955-4743-a581-a87276f693b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("78b52f00-d7e8-4cef-b471-72ce400c9a05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7ac212c8-f0fa-4763-981c-62f62792751d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7b4a6b51-9252-4a04-8fbb-d5c4ef52ff98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7c6d27d4-0706-482b-92a4-a760fb9ae269"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7cbc1148-771e-46ad-98b8-2ce042a7593b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7deb329f-eb18-410d-ac9a-51429c60de6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("820642cd-382b-4c77-9005-6694bec2cf7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("83203798-7700-41a2-9946-60629e92cb4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("89a53855-cfc2-4eba-984a-252e0f463dbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8bd83374-ef45-4e3c-8efe-ec81701b6943"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("902cc7e2-4c62-4fd8-9782-a5858bfa198d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("95548208-7b5f-4b43-9af2-02db7e893593"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("95b7088e-ffcc-4635-b639-ea8c37302ca2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9bbabcbb-c9d2-4e8d-8299-5239a688d39d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9bf071e8-4a03-4697-8969-fef8b41e4cfa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9c13959a-7675-49b8-8f98-a4c416b8ff8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9d00cd2a-42d4-4952-b791-3d8b7af06084"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f7976c4-a490-4e86-8e83-942ebe05d1a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a119d2d0-aa4e-402c-bf85-dad58ea21f3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a251185e-c85b-4963-b161-f6893cfff933"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a805a67e-a118-4053-8d7c-7f0e689540b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a8934c37-a09e-4a66-aae5-7d96872ae8f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aaf8586d-3e16-4ab1-910a-b004abc0c289"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab4e97f4-7615-4fc0-8cad-d632e55b31fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ac7f3284-5c8b-4933-89c5-51b51d40d861"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ade25e52-7880-42c9-8cfc-d3a4c96e5497"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aeef6fa7-d1ba-4c7e-b219-62bbf793d29b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b0569a31-0288-4f95-bb69-a0b72940351a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b3d3cbbd-ce42-4b73-abdc-2688c391b2b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b57dfd7d-cd09-400d-85ca-5a8e3b495146"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b84cd8dc-3c94-4025-b17a-7e17d3489681"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b9a14b48-4fbc-4d23-a506-06f79be61216"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba3f4ad7-ebca-46af-8a9a-689567438001"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c006bdbb-edf0-4613-8454-285fbf0fcbd4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c1014168-2d5d-4cf3-9ced-810fa66cc2a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c1a67a92-917c-48e1-86a9-dad1352c8985"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c4b7df2f-a980-4196-a18c-c56b8b145f2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c5056c91-3e75-441d-bdee-9e4c76662ac8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c6547fa0-e165-4fde-b3ab-c74111adce40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cf46ee22-a2bd-407e-94ad-2ce5cc17dea6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d15e20d7-e8d0-40c4-96b8-7104b39286fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("de396385-8929-4b60-b6f2-9fabc946c912"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("de7fdee6-a79d-4df6-abf2-3990e938e6c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e63a120e-d290-4aa4-acfc-e5fb9d4fdd22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e6b6e36a-64bc-4b81-aa5a-ca994d3bb8bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("edd680ce-3410-4127-946e-b0a1fb8470f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee5667a7-f456-45c2-b13c-7907d35a9fa7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f18f01df-6e75-4fa3-91ba-478d6d605d71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f48363ac-5d6e-4d25-8c02-7bcf283bbdac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f9df6bab-c581-4622-b065-173bda4122d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fb5393a2-afc7-45be-92f9-096bdd14418d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fbd5f812-69d4-4208-b3da-9dfe14f77f91"));

            migrationBuilder.RenameTable(
                name: "ParkingDetail",
                newName: "ParkingDetails");

            migrationBuilder.RenameIndex(
                name: "IX_ParkingDetail_TimeFrameID",
                table: "ParkingDetails",
                newName: "IX_ParkingDetails_TimeFrameID");

            migrationBuilder.RenameIndex(
                name: "IX_ParkingDetail_SlotID",
                table: "ParkingDetails",
                newName: "IX_ParkingDetails_SlotID");

            migrationBuilder.RenameIndex(
                name: "IX_ParkingDetail_LastModifyByID",
                table: "ParkingDetails",
                newName: "IX_ParkingDetails_LastModifyByID");

            migrationBuilder.RenameIndex(
                name: "IX_ParkingDetail_CarID",
                table: "ParkingDetails",
                newName: "IX_ParkingDetails_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkingDetails",
                table: "ParkingDetails",
                column: "ID");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("147b00dc-ed2c-479c-a308-693f31b14450"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("68746971-a6a4-442d-9016-023707bbbc60"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("774b7ede-eba0-4d2f-bc07-d2dac8c77bd3"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("a1fd311c-edbc-4ea2-9e38-4a58e67edb36"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("c99c4fa7-6051-4097-afab-29a2633a5a7b"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("fb4dc9a6-4f15-467a-a004-5b6d2d3e6380"), "Xe bán tải", null, null, "Pickup", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("c42f9dae-d197-41a0-a32b-47c98082707f"), "Short time", new DateTime(2023, 3, 8, 13, 31, 36, 196, DateTimeKind.Local).AddTicks(8600), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dda0f6ba-9e37-42b5-9f55-f5563d394e9c"), "1 Year", new DateTime(2023, 3, 8, 13, 31, 36, 196, DateTimeKind.Local).AddTicks(8620), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1395c48-89b4-4d72-b084-47d42933e387"), "Half Year", new DateTime(2023, 3, 8, 13, 31, 36, 196, DateTimeKind.Local).AddTicks(8619), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("00d036b2-d4f6-4fb8-991f-9e654c2ff095"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$OyT4J8qpg.vJBxrIfR4w..d9QCSHGmcWQ9E/kqNexX/C/1W0HoooC", false, new DateTime(2023, 3, 8, 13, 31, 27, 491, DateTimeKind.Local).AddTicks(5059), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("01b18f76-c875-4e81-9867-40be076f0dd2"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$75w0.2ZiyhTeHjQMlagwkeBjy2TKRpQnqOllkhE.rIKWPw4keWDQW", false, new DateTime(2023, 3, 8, 13, 31, 33, 507, DateTimeKind.Local).AddTicks(367), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("039ea838-dcb0-48b7-9093-663fdc18b762"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$IENvtmlIbbBXfsIEyY3vN.gPgLP4a3Na.9Kwc3t1Whu7CQz2uWWvW", false, new DateTime(2023, 3, 8, 13, 31, 28, 482, DateTimeKind.Local).AddTicks(3134), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("0612b844-55d5-405b-9864-d04f05e44241"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$iUJWFcav5a5pXEXytU2p3u/7hO9JmGj8T.V5nj15Ejkk8KDBH4K9m", false, new DateTime(2023, 3, 8, 13, 31, 35, 810, DateTimeKind.Local).AddTicks(2837), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("07b2e78f-5b61-42e8-88c4-43d080078869"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$nawJNv2Au43nUe8asPZTf.fBTce4Con.JoiVkLFEZbz6YwwBEMT9G", false, new DateTime(2023, 3, 8, 13, 31, 35, 619, DateTimeKind.Local).AddTicks(4974), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("09e20f9b-1672-4429-aa4a-3ff128b05d65"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$L1NomL2kIu7qstOOoreo3eKQdLupoYfkKzBfl/mfietGKpeUyPHcS", false, new DateTime(2023, 3, 8, 13, 31, 30, 185, DateTimeKind.Local).AddTicks(6555), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("0c80bcdb-e88e-4d94-a4a5-e63868e016fc"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$wxjtrhxhcKq2hvkr78jcYOYvcLFXFEK/g4W5na7VIrNbVsBOB9/eS", false, new DateTime(2023, 3, 8, 13, 31, 30, 381, DateTimeKind.Local).AddTicks(9452), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("0c821903-ebe7-4651-8597-be0a7f8b160a"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$Ha2ZWDwqeuwsr14xwzsV9O6Od/jBgGWhzSqO00FxmJ91wNCFNDs4.", false, new DateTime(2023, 3, 8, 13, 31, 29, 531, DateTimeKind.Local).AddTicks(9170), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("0ee84bf1-f12e-4864-8e44-5d65226af54f"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$jYFP.Uf39st0URAkYcit2OD7g6tO8sJ2CpZmqDjPSgvBJzp8V7BjG", false, new DateTime(2023, 3, 8, 13, 31, 36, 196, DateTimeKind.Local).AddTicks(7860), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("0f7cb015-04ac-4a1f-9e49-301b4c85c837"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$fAqI9lUrGhNNgFBAhWtB5uCLpQo5Aas1PpVVzqhP58IlmmuN7iQky", false, new DateTime(2023, 3, 8, 13, 31, 28, 615, DateTimeKind.Local).AddTicks(8883), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("0ff5aad2-d6ee-4362-a2cb-0523eaa21b7c"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$oXE79TX9Cr9xzTPM1PF9FOsWYiCE/cbJWDJmt4Ny1LhNzR4NVPilS", false, new DateTime(2023, 3, 8, 13, 31, 33, 664, DateTimeKind.Local).AddTicks(8531), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("106008be-b064-461b-8ff4-c8b33c9266a2"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$D019dLcoYq/zYwVFxo/yH.TSCg6NEYT5HpKyEVcsx..6btxbshrWu", false, new DateTime(2023, 3, 8, 13, 31, 31, 927, DateTimeKind.Local).AddTicks(7380), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("12536ac2-120a-4e5e-9059-9ae6f5f28c60"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$4r8ykCNZh7rPg6kw1hYpAej/sFf7jSxyM1ME6KhXrqd6syqufmXRG", false, new DateTime(2023, 3, 8, 13, 31, 34, 457, DateTimeKind.Local).AddTicks(6749), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("15f8afb0-e656-41ff-a0d5-20dbe8335ded"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$bDbNYcHU84Y9jV85Yma1Oe.ZLGfaASXdu11ib11a0aPfnTm8TP7Ma", false, new DateTime(2023, 3, 8, 13, 31, 32, 243, DateTimeKind.Local).AddTicks(7423), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("18b2656a-b5a2-4dcb-b8de-a130a2ccf087"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$3zlQp0BtBp/1LO7n3Vi5meQ2f495JE5GTEh7/U1svV81eADnjcaWi", false, new DateTime(2023, 3, 8, 13, 31, 28, 351, DateTimeKind.Local).AddTicks(4770), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("18f1b941-18b9-4956-89b2-96b7f8cdc6d0"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$sYtdgI9azkYNu0ix3BQAWuE839qZt3EIa22fHPmSC4uhh3HTvEthy", false, new DateTime(2023, 3, 8, 13, 31, 35, 248, DateTimeKind.Local).AddTicks(2351), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("1b28b2cb-9f05-426c-8e1a-aaeb398cd259"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$1SEwFtQojJtorswrD6C0PuFz21kpTMkvW.DSBmyKkcz/N2LS6Z5mO", false, new DateTime(2023, 3, 8, 13, 31, 29, 203, DateTimeKind.Local).AddTicks(4365), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("1f4b3ff2-f04e-422b-840f-18bff9f1aa39"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$IjMYH0cnQ2YwsgZPlNi9yOspCAnCwb024ORdnYVSxDsRKnGKqTuaG", false, new DateTime(2023, 3, 8, 13, 31, 27, 573, DateTimeKind.Local).AddTicks(5960), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("232ee841-557d-4cd0-985d-8869862bc66a"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$o2E1G6IzCc2tFZia/eRls.zv2c.hUz0sueggiWkObLVwWicxV3p7e", false, new DateTime(2023, 3, 8, 13, 31, 30, 53, DateTimeKind.Local).AddTicks(6027), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("2358226c-4823-4ea9-9307-26b53e6457f7"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$BAiaIbfRKOP6aJMJCHIZCe1S2SNQtMnKutQJfElkoF4Dh.t3cdLcu", false, new DateTime(2023, 3, 8, 13, 31, 29, 792, DateTimeKind.Local).AddTicks(6213), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("236b9d99-f16e-4936-aba1-01d6752ec6cd"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$gCO8Ym73MimhWngTV/eF2O046K9kmtE2ac0zfEieMankzUxIfOnGa", false, new DateTime(2023, 3, 8, 13, 31, 28, 547, DateTimeKind.Local).AddTicks(5675), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("250b5d5b-f3fa-4de9-886d-9a4fbdb53d5c"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$FuBf0wuvUnpOFNW0xG3UOeaEHxbR5/d5OAsjUK.UxyOWukq1SedUq", false, new DateTime(2023, 3, 8, 13, 31, 29, 68, DateTimeKind.Local).AddTicks(2480), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("2bbf94a0-59db-44d9-8569-5b2befe07bd7"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$idFgyUTANXQnwjSd9O.7xOisWCfND07iR3o6hSJe2zLDAUk15duJi", false, new DateTime(2023, 3, 8, 13, 31, 28, 220, DateTimeKind.Local).AddTicks(9704), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("2bddd866-9d33-4b9d-bfed-5dd43f17c992"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$YmlXQhLm6V56e.z4ZRXRuOdZM.A.yspz2EpaZLtGdgXxmw4DzhOOC", false, new DateTime(2023, 3, 8, 13, 31, 31, 305, DateTimeKind.Local).AddTicks(8063), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("2efb2436-36af-43f7-be38-356230a575f2"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$1prmSnYmG.07rbwX1kSDwu0S086Qh.dtNW17qbYLuKEPXZ1VBR.ZC", false, new DateTime(2023, 3, 8, 13, 31, 27, 638, DateTimeKind.Local).AddTicks(2265), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("31404cd0-fd50-49ad-a005-196d960742f0"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$cQ1p.Tacbh8vTd0YlciWce8a26B/e7MHvU58n4WF0w0py2woFfUsi", false, new DateTime(2023, 3, 8, 13, 31, 30, 251, DateTimeKind.Local).AddTicks(3822), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("35a7ea65-0984-4d51-8e92-b5c261ebf18f"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$Gwuvu5AbmsOioC.1/UpGweq0TWq8dOknyXy8/l8dNboHIrUCWaNqe", false, new DateTime(2023, 3, 8, 13, 31, 26, 543, DateTimeKind.Local).AddTicks(6050), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("398bb0b1-7ab1-4fee-9ac5-cd985b270404"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$vDbbyt.VcllsqLgN0sUwKOGU11b4/YRxfQs0XwaxncxlT.49w.lvi", false, new DateTime(2023, 3, 8, 13, 31, 34, 932, DateTimeKind.Local).AddTicks(3885), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("3ad380e4-ed33-45da-8da9-1b76e5ae3004"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$54Re5MXNaXSKIm5BixlXWuiDoVkiQNvrvBKtk6QVcdpbQU5bf5iXO", false, new DateTime(2023, 3, 8, 13, 31, 36, 68, DateTimeKind.Local).AddTicks(1546), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("3df35531-98ad-423f-a371-e5b47a0214e7"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$3BMAa2q0h0Sff3OYfRod7uKRh6uPrJKXSyuF0BVXR3IGA8Qo25Fyi", false, new DateTime(2023, 3, 8, 13, 31, 30, 513, DateTimeKind.Local).AddTicks(6366), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("3f375ea8-220c-413c-a4a1-733ab93670e9"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$3QM1PzxFH43px9K8JrqoAOsq4UqAfeda8WTPIFnBWEJ3Z/sPixbpq", false, new DateTime(2023, 3, 8, 13, 31, 25, 578, DateTimeKind.Local).AddTicks(7454), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("426cb61d-50d8-4b4e-8c29-bd63a58336b9"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$71QSfShLtTUzPN82sTElReRTHv7vIx9qQDDVNKM.T2UXR1/M2M00C", false, new DateTime(2023, 3, 8, 13, 31, 35, 874, DateTimeKind.Local).AddTicks(3096), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("42d951c2-db4c-4cf4-9c98-a13ae11876dc"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$dSj621fqF5Yomk4McQxNaeVUvlKJOO1u5Tcv49ZVaJjQbkP0n3LWS", false, new DateTime(2023, 3, 8, 13, 31, 26, 71, DateTimeKind.Local).AddTicks(2832), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("42e2d011-05d0-4ec2-a691-59c0f7c81f1c"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$LCVNkKn7itgdMgZTqGnKd.SHKgBXLhXTnJREHNXeWxEr/wCX.AhVS", false, new DateTime(2023, 3, 8, 13, 31, 26, 386, DateTimeKind.Local).AddTicks(1816), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("48b5f346-bef6-4284-9da2-592b1a7c83a9"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$LgDEyRyly/xRgxFpTnzxleGIFVr1kAXn/OvlKuD4YQhr78lm/ALA2", false, new DateTime(2023, 3, 8, 13, 31, 28, 156, DateTimeKind.Local).AddTicks(769), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("4a95c700-f50c-4ad7-a4d9-cf4a0982962e"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$OrH9Rs.JNvO8Borep/ZfmO3ht8FbbtL5uwrp8H79rw3wUz1AS1xaS", false, new DateTime(2023, 3, 8, 13, 31, 29, 134, DateTimeKind.Local).AddTicks(770), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("4d97dd4b-0059-44c3-b507-8d013608d054"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$0sygKTsJo09elmu2Np.4eeN2y949ykxQbWnXt1SAwS130Fk/nwj0K", false, new DateTime(2023, 3, 8, 13, 31, 28, 807, DateTimeKind.Local).AddTicks(9960), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("4dcba3a6-b7af-4ce8-9d64-d2226e976d57"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$bxk/Pdf5OmJqmDkbQ62.hO1jjuTLPDQ0uBRVXSTQmBuQVeLwNDHpe", false, new DateTime(2023, 3, 8, 13, 31, 35, 90, DateTimeKind.Local).AddTicks(2420), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("4e3d429a-7846-445b-b861-12f5a4d73459"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$Av6wxEKfI0IQeQG7.D/lz.f/yINRlGeWXz18ftwBF7HFZvAgfSOvm", false, new DateTime(2023, 3, 8, 13, 31, 30, 776, DateTimeKind.Local).AddTicks(6626), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("4e55c64a-6739-4732-8e81-7cd3f229337a"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$4MyqunfZUEI0s5syztiKQua3O6eIoYgH7zH5mO0t9zCL0NrPzZ7E2", false, new DateTime(2023, 3, 8, 13, 31, 29, 270, DateTimeKind.Local).AddTicks(705), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("4fb2bb72-0d70-4479-88cf-5a6d63354f56"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$ArAznKs2dHjbs9gl25XqO.kFpfWrEFLX4xek3XMf/s8CgzFK3rvQG", false, new DateTime(2023, 3, 8, 13, 31, 36, 3, DateTimeKind.Local).AddTicks(7319), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("4fb7bc4e-e713-4f21-9f53-572cb24e4977"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$u8uFEiQq9gYgmgEFaOPw9eC1QM7wftQJSVWSGbcFP/vBO/dNEmYcG", false, new DateTime(2023, 3, 8, 13, 31, 30, 841, DateTimeKind.Local).AddTicks(5647), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("50f3c4fa-6437-4c62-8910-265f79872bbd"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$NXqFU5A6OsAoGfhuGp2TJ.hXfYPrJr8tf3nutwVuZsNVvYqi.9VX.", false, new DateTime(2023, 3, 8, 13, 31, 30, 908, DateTimeKind.Local).AddTicks(4627), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("5219f34a-86a9-467f-a79e-5869550cc5f2"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$AbqRKIuED9aZuAyH0JU3GutRemaPYGVbLkAuexoXgS/8cvtVbAD7G", false, new DateTime(2023, 3, 8, 13, 31, 25, 902, DateTimeKind.Local).AddTicks(668), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("53cae597-ff2d-4cfc-a73d-8c6bb95e63be"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$EcCvT3ONjxet/TXUl2cun.MzY1xg6lGm16pL4g8UBXgTnt0PB/Ueu", false, new DateTime(2023, 3, 8, 13, 31, 33, 32, DateTimeKind.Local).AddTicks(1012), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("547cdeb7-9aeb-4fc3-83bd-9c83490cf45c"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$wMKAOAOMWm2//jBxLo0AROwCSOg8lvdNjDeBnUmQc.L4cbFl8m34u", false, new DateTime(2023, 3, 8, 13, 31, 28, 90, DateTimeKind.Local).AddTicks(5909), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("5750c12f-c0f1-4385-aa4d-a78c3e17b77a"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$IfJblTbjLMauFzQWUKmsBOC3DwFA8Vi99dywb1al1p8nvfE41iPU2", false, new DateTime(2023, 3, 8, 13, 31, 28, 417, DateTimeKind.Local).AddTicks(8142), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("5839bf5e-6616-450b-bba8-4b946dc86182"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$NAQRgRUQki4aPmpB6yNAUujR9XlvtQ6vVmhX.MjHxCCmNfa2hOj4S", false, new DateTime(2023, 3, 8, 13, 31, 31, 370, DateTimeKind.Local).AddTicks(4416), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("58e840d4-c1ad-42ae-bd48-ca78af57f499"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$Mbuu88nBlTM3Aj5fDuk46ubDlK9SyRuNnn5kScisiHS7msRCxbrBu", false, new DateTime(2023, 3, 8, 13, 31, 32, 715, DateTimeKind.Local).AddTicks(9106), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("5b0ab8e6-b59b-4d8e-b983-c1958e5b9530"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$f.q4kb.iyFZ8ZcYhim/J7exqdWjmJQQ1eyjY91TRlCxt6YtVbn8M2", false, new DateTime(2023, 3, 8, 13, 31, 32, 401, DateTimeKind.Local).AddTicks(393), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("5f571e63-3703-4bbd-8381-eb6533103681"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$VhDY.G2Q9T/r/B5STxSRJeWHeTlXtyq4V2iv.q7GsBk4qiQNQjdI6", false, new DateTime(2023, 3, 8, 13, 31, 28, 873, DateTimeKind.Local).AddTicks(8139), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("5ff9eff4-4aff-4947-822a-68347f39926d"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$RUeNTuSxRaU6YSdvBgVpHuT7Hc7YRJZT/n1UkKtdAHwzd/aI8mWKS", false, new DateTime(2023, 3, 8, 13, 31, 29, 857, DateTimeKind.Local).AddTicks(1198), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("61f903d5-9d1a-4ad0-9f45-000ba77ea4fb"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$df95D.xM5QiipQAZRW9v/.ET6CyU3QWiLhE9xj9fGcLNcC4Y3iedi", false, new DateTime(2023, 3, 8, 13, 31, 33, 826, DateTimeKind.Local).AddTicks(111), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("64dc64c3-e245-4dcf-a2cf-aa36d7232878"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$xyh4Q9pbYFgH69KK1Nxum.fQd0aDehaserJMFmm2955Y0/tuAXUFq", false, new DateTime(2023, 3, 8, 13, 31, 35, 555, DateTimeKind.Local).AddTicks(2559), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("6684b7a1-d1a9-4813-8c6a-61b1ccdd5eee"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$1PSjAfgDYvEosmfPBwlpqu0jgaX0c2feSBkniph1DdAu6kPpEofsa", false, new DateTime(2023, 3, 8, 13, 31, 25, 741, DateTimeKind.Local).AddTicks(6078), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("6858a636-099e-4c7e-92df-62ce543e0f75"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$WjGc.8nCJ2EDZVzd18JbVut2gSt8qiy6eGgZUls4q82bEDG5T1wU.", false, new DateTime(2023, 3, 8, 13, 31, 35, 939, DateTimeKind.Local).AddTicks(4415), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("68f66fa4-df2d-4416-9bab-dd89e7565923"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$bmdS82NftrDswGi/NAlIyO.JM/PrPAW10V8XdSOsYgjeM0W3fVfrq", false, new DateTime(2023, 3, 8, 13, 31, 29, 987, DateTimeKind.Local).AddTicks(9720), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("6bceb26d-1cb1-463a-9503-02bd26c969ad"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$euJIeZIX8tuu1Xb2vZZtzuOxXxrmbUaFQHj7Je69didiv1bgRifRq", false, new DateTime(2023, 3, 8, 13, 31, 35, 746, DateTimeKind.Local).AddTicks(4896), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("6cb51a46-de65-474d-a5f9-2170709d214a"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$0.tH7NATm17rXozDnjHxz.RwU3tnmQ2InnWI3DUf/zD3LDyXlB5s6", false, new DateTime(2023, 3, 8, 13, 31, 31, 501, DateTimeKind.Local).AddTicks(2123), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("6f5c3d55-c6ae-4857-a78c-26ff951dcfb8"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$.gUMupjnAEDfbVj6yXjJx..rOz9KgCwN5eqbMOW3E/s7ckCP670xm", false, new DateTime(2023, 3, 8, 13, 31, 29, 3, DateTimeKind.Local).AddTicks(3773), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("718777f4-7c27-4672-bc54-edc110c380cd"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$OA6eJwuf2g.2B8ak6Jw35.hT43zdhSvM8ya7m.7daF1HrzjqX2Poa", false, new DateTime(2023, 3, 8, 13, 31, 30, 119, DateTimeKind.Local).AddTicks(4832), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("75f4704e-7e54-4125-8556-6ebb09b52e1a"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$Sd0Bm5qFixdMQwPalZtXneQ2PzJNtLTodeigSNPoE.gmDp0W.TSYi", false, new DateTime(2023, 3, 8, 13, 31, 31, 769, DateTimeKind.Local).AddTicks(6006), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("764f183c-3cb6-4dbc-8129-810730783812"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$sj9ZdRU5XlDCXpayyKkIEOVGDS3gka1JfB3IV/Or7b5ceUgsQaLZy", false, new DateTime(2023, 3, 8, 13, 31, 26, 861, DateTimeKind.Local).AddTicks(408), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("7868e310-6511-49eb-a177-f9ab86619e32"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$Dqx2H0UK2RwWhZct4i4GeeblhZ1rKk81FUGVf5c9klY/EB0EPT1Wi", false, new DateTime(2023, 3, 8, 13, 31, 27, 897, DateTimeKind.Local).AddTicks(1492), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("7bf2eb9e-a6ff-48aa-b17b-58d03ac239be"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$2yINRBcV3vIQ1OK7VnlRj.t7vUJKGL39mh97Uvrh4VweEAFdqP/ZG", false, new DateTime(2023, 3, 8, 13, 31, 34, 299, DateTimeKind.Local).AddTicks(9098), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("7f6161d6-1232-494b-8eb9-f0c52cab1842"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$z9DScul/faTceatdZEYnNunSuCP3R38lt.yDIro6kXK3.6mBd6CGm", false, new DateTime(2023, 3, 8, 13, 31, 31, 612, DateTimeKind.Local).AddTicks(350), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("80a3ae90-83b5-4422-9088-1af1c82120f8"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$Oi45rggmz58W.tKMBkl2I.brIPSYJaiLMo/39r2L5.tM0HAPVbx4C", false, new DateTime(2023, 3, 8, 13, 31, 29, 664, DateTimeKind.Local).AddTicks(1984), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("81e24f08-df30-4445-ac3f-f33f34d18f43"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$y3uy640IFp1af8n96dKfWOrmcMracFLyhPKiN4kYKnmBB0Yy6oMWW", false, new DateTime(2023, 3, 8, 13, 31, 29, 335, DateTimeKind.Local).AddTicks(835), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("847aa096-8dea-4367-9cb7-1dee5c6bcc64"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$op5U6pB9f0aihnghpp1J7er7wx2W1gx/UsDqiszUoIoGGYk5Ztasq", false, new DateTime(2023, 3, 8, 13, 31, 26, 700, DateTimeKind.Local).AddTicks(9733), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("867c5a14-e9f9-436f-9d48-f1364968ee8e"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$WLPa8uyTRt18vFy0JkdHsu2odXPj/nU7GkNfY.k7HlRWHFFzfxgQe", false, new DateTime(2023, 3, 8, 13, 31, 35, 682, DateTimeKind.Local).AddTicks(9232), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("894f666c-ab0c-40ed-bdbb-24b1a40498bb"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$U5icym.u7ei0Bg4XDi6N8uw8vIB.b2VVU.UipwHT1.onOFk70AuYS", false, new DateTime(2023, 3, 8, 13, 31, 34, 615, DateTimeKind.Local).AddTicks(9000), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("9013be96-1ac0-493f-bf10-2a42822efd1a"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$NKsqOASicv45GW8trWJ2ruPcs/8zPX7yn1xdPHTAgqiEJMyQJdfAy", false, new DateTime(2023, 3, 8, 13, 31, 32, 85, DateTimeKind.Local).AddTicks(9758), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("94d405bf-b632-459f-a05a-bbdb72cac4b7"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$DA7tfREDoH1JcIaXYnIKo.Pxzfox5Wae8dvqa0jVlGusyXs.QOUOG", false, new DateTime(2023, 3, 8, 13, 31, 30, 316, DateTimeKind.Local).AddTicks(5659), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("9bedce7f-39ac-494c-86ec-8d00b47d4275"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$/agN/8T5uPeTQzWtoyKDUOWEuWdmFXNu2QMdTM98EHO.YcVPMd/Qy", false, new DateTime(2023, 3, 8, 13, 31, 28, 744, DateTimeKind.Local).AddTicks(2208), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("9bfbc6e0-a5aa-4364-99b6-a35ed4b6d22a"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$HTja.8hDBgj8fI50yuXQw.d0s57NrnSb1aq.X6DHM61McLjwuFcAu", false, new DateTime(2023, 3, 8, 13, 31, 27, 832, DateTimeKind.Local).AddTicks(2180), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("9c6101cd-11ea-41fa-8e55-3e8102a7eabf"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$ZGC2kZzt4we0lDgm8gMeVuTv8qygbtvaQtGucUl0WOqo75YqRxMKK", false, new DateTime(2023, 3, 8, 13, 31, 34, 142, DateTimeKind.Local).AddTicks(4156), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("9f89e9f2-3fbd-4157-a162-1955727a4010"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$rLzxfxzup0.leHWId.JvceMjsfrSBXRvSWOLyLwFY0LZffTOq9x8i", false, new DateTime(2023, 3, 8, 13, 31, 25, 263, DateTimeKind.Local).AddTicks(2506), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("9fd953a4-7d71-4868-abc1-d6111ab63a74"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$opyGTW5yd/supZL9koC0ge/KNzqPbkH5pBTwEf7M4Qt4K0ammcR6W", false, new DateTime(2023, 3, 8, 13, 31, 26, 228, DateTimeKind.Local).AddTicks(7276), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("a26f0509-1de9-40b3-8cfc-45898428c436"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$IvBcxrKEkFcdon8EqVQnJuWVULk/jixk8NI4W5xdZG3ILt3ISpIGS", false, new DateTime(2023, 3, 8, 13, 31, 29, 598, DateTimeKind.Local).AddTicks(6195), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("a6ac855f-0bdb-4094-87d1-d87dcbbc1a5e"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$EfeJnB4g5Upgw9x4NXoGsOxsW/SVSKo.HaAoaNwnVLvf6CGoXK2/i", false, new DateTime(2023, 3, 8, 13, 31, 29, 400, DateTimeKind.Local).AddTicks(3003), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("a83ca7ee-d155-40fe-9905-2cfa82e806ad"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$Ecmkf1Dd0aOCAvulxHLNwOmBEazGuTDH255uH5RQA39wMZpwQSpMe", false, new DateTime(2023, 3, 8, 13, 31, 28, 680, DateTimeKind.Local).AddTicks(3640), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("aad0a661-5275-4cd7-b1ca-3a4fd5f355c7"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$.9sbu56tTNJyStjfk6Jax.gIlCBtdVgr3.KSRxO/993fbll6mQUvu", false, new DateTime(2023, 3, 8, 13, 31, 29, 466, DateTimeKind.Local).AddTicks(2422), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("ac9df3b0-3c05-4f00-8b4f-040f3eaf1bdc"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$LDAc/R1Z7oaW8g8O.S/wKu9VFp3nUIVE8iZQjMrLbzO.sxwymZAia", false, new DateTime(2023, 3, 8, 13, 31, 32, 558, DateTimeKind.Local).AddTicks(5316), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("ae718613-33cc-48c9-b205-cf2031895514"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$Pxnvwhil0n99x3duk8TY9eY1ma.CQAsgQ.4AQxp6XkVguisAyL.Yq", false, new DateTime(2023, 3, 8, 13, 31, 28, 286, DateTimeKind.Local).AddTicks(2720), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("b1db47e9-b7cd-4724-910d-350ea954fa22"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$XhKF1LKtiBZdubeD4cfE..ATn5voP48Cuyx4QSMtxJ3e4r1U0iBJq", false, new DateTime(2023, 3, 8, 13, 31, 27, 767, DateTimeKind.Local).AddTicks(1433), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("b8f48b31-b106-42f6-bac9-cdbd3eaa42fe"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$0pn7hZ43TQxM3HDV0SE1kOEEWctqRAm/0eumQZ6OKCOxl3H9oZDh.", false, new DateTime(2023, 3, 8, 13, 31, 32, 873, DateTimeKind.Local).AddTicks(8419), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("bafa0c84-a9cf-4aed-9b25-09e7e03daee6"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$ItOzz4Z2X30i9Re2kc7twOsG5MAaUD3ZxJVcEVe3tkpfS1P45Pgwq", false, new DateTime(2023, 3, 8, 13, 31, 36, 132, DateTimeKind.Local).AddTicks(7296), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("bbee4994-33a1-42fb-947d-6ebbf9b8330c"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$0fCUFVWwvqWk.JNBQWR4leuULvI3stF8ZIM/Q5.pBmJpK3t1e7Fdm", false, new DateTime(2023, 3, 8, 13, 31, 27, 19, DateTimeKind.Local).AddTicks(3902), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("bf5bc625-ab33-4132-bb84-2c856d3258f7"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$NoHHLHiI3Evs79sECELIoeTix7KiemSefYrOIX8UQV0.DwoULUS5W", false, new DateTime(2023, 3, 8, 13, 31, 28, 939, DateTimeKind.Local).AddTicks(2810), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("bf91fe51-8278-46e6-8a40-da1f0d005e2b"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$Xjp6vl42djQFjw3/1YRjo.5zql90eUp/8e7Oge9JzQgLGP0PZeZdq", false, new DateTime(2023, 3, 8, 13, 31, 33, 985, DateTimeKind.Local).AddTicks(1114), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("ccda755f-4b13-4ce0-80be-07275181e954"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$b7P5WTNym1GvTM/UNwqv3ecn27RCoTWCl2PwvjttJj5JqDh31mpV2", false, new DateTime(2023, 3, 8, 13, 31, 31, 436, DateTimeKind.Local).AddTicks(172), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("ceaab3af-e720-431b-9bc2-5bc65d666194"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$rW2emCB/TwDmDV3s.BCNcupKagmnb1xkP9bzxIB7FqHpTapWKO.fG", false, new DateTime(2023, 3, 8, 13, 31, 28, 25, DateTimeKind.Local).AddTicks(6279), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("d0d2964d-4f8a-45ab-be2d-766451f0ce0d"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$UUVIY14.o4mbpm0xz8ix6OQa9t.jhasAzTj3Q3HxwMJFBeXskbn56", false, new DateTime(2023, 3, 8, 13, 31, 35, 405, DateTimeKind.Local).AddTicks(8812), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("d222489f-5e82-469e-a9ba-4ddcdc5f9767"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$NH/1NGNVxOEYrNixO2XnWuyrUdQarU/hSBIY6fj1KLNHlSo5nnDf6", false, new DateTime(2023, 3, 8, 13, 31, 30, 645, DateTimeKind.Local).AddTicks(6093), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("d2a69183-4465-4741-b0e0-632e8ff180c9"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$1/aFGL9c6JK2d6xYLgBqxeyHrt7zh5VMY60hOHLD3/dW03DsnWt16", false, new DateTime(2023, 3, 8, 13, 31, 27, 703, DateTimeKind.Local).AddTicks(1722), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("d398b984-2877-4e24-849d-aef2af967c52"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$x2GIA5K2Vc1TWqIcM7aVUOPhiXkCjvxx0iSnuYPSk/j8c.KZ/pZfS", false, new DateTime(2023, 3, 8, 13, 31, 31, 41, DateTimeKind.Local).AddTicks(4501), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("d868fa13-ee4c-47a8-8a1d-f5b419c65a7b"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$YycDiZ67KGM3OnlBnA4Sg.MggK37daax72u.HEgfA76tk2LWN2cxS", false, new DateTime(2023, 3, 8, 13, 31, 27, 334, DateTimeKind.Local).AddTicks(798), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("daaf664a-322a-44ed-8e99-ad0cb1a42729"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$.x9LFg/P9zQl77H6Cqdo2e2FRT5K0pxKs5F4pXNJNvyK/MGfEmf06", false, new DateTime(2023, 3, 8, 13, 31, 31, 171, DateTimeKind.Local).AddTicks(3248), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("dd4d91ec-46e4-452f-8cf9-172b30212f0b"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$6i6sKf2paM4.Ca11hl5S5uYZdtnLq8LkW3VFutWYRsiZRs6gfq8Ru", false, new DateTime(2023, 3, 8, 13, 31, 31, 106, DateTimeKind.Local).AddTicks(2037), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("dd77abd8-d34a-4ca4-8bf8-4f5763f4b755"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$OgxQbafbB.sNurIv6R7CUe3kjMB2C6XoMfDu5/FDuxJbT6w3xhwhy", false, new DateTime(2023, 3, 8, 13, 31, 30, 976, DateTimeKind.Local).AddTicks(8530), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("de9ea59d-df97-45f5-b64a-117f9f466859"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$zljUUhzRtZLlcGXd7UYFJuiUtWteQFD0kgMod215HqsnO8uxEu.P6", false, new DateTime(2023, 3, 8, 13, 31, 27, 961, DateTimeKind.Local).AddTicks(5577), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("df42b357-0552-4814-a7fe-c5cfc2636732"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$cKKDh3TL2qv8aUa4QeLA0u.E4ud.2a3cuhDEus/h2h7Ez6m9bRuOG", false, new DateTime(2023, 3, 8, 13, 31, 30, 447, DateTimeKind.Local).AddTicks(4009), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("e00e1ff0-f614-4884-b1b3-ca0456380bd5"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$fNNDzfCtKH82fU4Hwo61zeiTt0R6WRp.jJh1yyfWRs/vVH8d.IOGe", false, new DateTime(2023, 3, 8, 13, 31, 30, 711, DateTimeKind.Local).AddTicks(2083), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("e309c60d-0511-4b7c-be1e-ee56770cc74e"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$l/JR7G8ohfwr1BMmWsOxDOXJ8E9ZqHxVRhI6NBRpawu/ANWRhBUAG", false, new DateTime(2023, 3, 8, 13, 31, 27, 176, DateTimeKind.Local).AddTicks(6352), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("e7574323-1fe7-41c1-926b-a0bec596612b"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$V6vHsefmUls0.aDzKqDSLOpBH67XM6sBceFCAmXmTXg4VFaTzxLZa", false, new DateTime(2023, 3, 8, 13, 31, 25, 421, DateTimeKind.Local).AddTicks(3404), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("ea419892-6112-437f-9124-56d63f9736ea"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$9fmC1cf8.pSwr8y8qHuIoueiw5VSdQqy3ISFQwS6afsVLNp5LVr0C", false, new DateTime(2023, 3, 8, 13, 31, 29, 922, DateTimeKind.Local).AddTicks(5109), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("f27db8a2-7d07-48ac-a057-ae9af18fe408"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$MsTkGs8edpqxGks9kd1hr.ydJ/Ak2otadFBZs2Js9skgKgqUZU3Ky", false, new DateTime(2023, 3, 8, 13, 31, 33, 189, DateTimeKind.Local).AddTicks(6014), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("f4fdaed9-6da6-4d71-8351-36989ef4fa62"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$B7V2BmB0TSJgvwPUf6JUtud1lrYqmz07PFdvOAfA7/It6Pi9ov.c2", false, new DateTime(2023, 3, 8, 13, 31, 30, 579, DateTimeKind.Local).AddTicks(499), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("f58eff6c-05bd-4663-bea3-06599eb72202"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$plj39ypNtTNZXIlvEHMbpOgds3sAH.lwMd/pDZYhAkLnxIrcWjmt2", false, new DateTime(2023, 3, 8, 13, 31, 31, 240, DateTimeKind.Local).AddTicks(4285), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("f5ac43a3-ad75-405d-8965-9a0367962cda"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$N9B96s6gHmqJ61Ecj3yILe6YZkW4oa2uWm0hrOacb.HcYgVm3Kxba", false, new DateTime(2023, 3, 8, 13, 31, 34, 773, DateTimeKind.Local).AddTicks(2243), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("f9e81a74-a89e-48c3-ac3d-d9ff28d7b31f"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$dWufFATz7CYa61IY5phfU.o1hCK.uKM6VPyD03.WtcfBL/h9qlsAC", false, new DateTime(2023, 3, 8, 13, 31, 29, 728, DateTimeKind.Local).AddTicks(8854), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("fb887052-e3d0-44cd-b327-079f3cf0475c"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$/jXZ/DAPs/joA4S/DRqJGuZSuO6s4vs.J12.nFvgElTGFSyBYfZ2e", false, new DateTime(2023, 3, 8, 13, 31, 33, 349, DateTimeKind.Local).AddTicks(6495), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetails_Cars_CarID",
                table: "ParkingDetails",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetails_Slots_SlotID",
                table: "ParkingDetails",
                column: "SlotID",
                principalTable: "Slots",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetails_TimeFrames_TimeFrameID",
                table: "ParkingDetails",
                column: "TimeFrameID",
                principalTable: "TimeFrames",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetails_Users_LastModifyByID",
                table: "ParkingDetails",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetails_Cars_CarID",
                table: "ParkingDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetails_Slots_SlotID",
                table: "ParkingDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetails_TimeFrames_TimeFrameID",
                table: "ParkingDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkingDetails_Users_LastModifyByID",
                table: "ParkingDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkingDetails",
                table: "ParkingDetails");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("147b00dc-ed2c-479c-a308-693f31b14450"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("68746971-a6a4-442d-9016-023707bbbc60"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("774b7ede-eba0-4d2f-bc07-d2dac8c77bd3"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("a1fd311c-edbc-4ea2-9e38-4a58e67edb36"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("c99c4fa7-6051-4097-afab-29a2633a5a7b"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("fb4dc9a6-4f15-467a-a004-5b6d2d3e6380"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("c42f9dae-d197-41a0-a32b-47c98082707f"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("dda0f6ba-9e37-42b5-9f55-f5563d394e9c"));

            migrationBuilder.DeleteData(
                table: "MembershipPackages",
                keyColumn: "ID",
                keyValue: new Guid("f1395c48-89b4-4d72-b084-47d42933e387"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("00d036b2-d4f6-4fb8-991f-9e654c2ff095"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("01b18f76-c875-4e81-9867-40be076f0dd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("039ea838-dcb0-48b7-9093-663fdc18b762"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0612b844-55d5-405b-9864-d04f05e44241"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("07b2e78f-5b61-42e8-88c4-43d080078869"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("09e20f9b-1672-4429-aa4a-3ff128b05d65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0c80bcdb-e88e-4d94-a4a5-e63868e016fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0c821903-ebe7-4651-8597-be0a7f8b160a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0ee84bf1-f12e-4864-8e44-5d65226af54f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0f7cb015-04ac-4a1f-9e49-301b4c85c837"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0ff5aad2-d6ee-4362-a2cb-0523eaa21b7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("106008be-b064-461b-8ff4-c8b33c9266a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("12536ac2-120a-4e5e-9059-9ae6f5f28c60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("15f8afb0-e656-41ff-a0d5-20dbe8335ded"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("18b2656a-b5a2-4dcb-b8de-a130a2ccf087"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("18f1b941-18b9-4956-89b2-96b7f8cdc6d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b28b2cb-9f05-426c-8e1a-aaeb398cd259"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1f4b3ff2-f04e-422b-840f-18bff9f1aa39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("232ee841-557d-4cd0-985d-8869862bc66a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2358226c-4823-4ea9-9307-26b53e6457f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("236b9d99-f16e-4936-aba1-01d6752ec6cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("250b5d5b-f3fa-4de9-886d-9a4fbdb53d5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2bbf94a0-59db-44d9-8569-5b2befe07bd7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2bddd866-9d33-4b9d-bfed-5dd43f17c992"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2efb2436-36af-43f7-be38-356230a575f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("31404cd0-fd50-49ad-a005-196d960742f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("35a7ea65-0984-4d51-8e92-b5c261ebf18f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("398bb0b1-7ab1-4fee-9ac5-cd985b270404"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3ad380e4-ed33-45da-8da9-1b76e5ae3004"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3df35531-98ad-423f-a371-e5b47a0214e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3f375ea8-220c-413c-a4a1-733ab93670e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("426cb61d-50d8-4b4e-8c29-bd63a58336b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("42d951c2-db4c-4cf4-9c98-a13ae11876dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("42e2d011-05d0-4ec2-a691-59c0f7c81f1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("48b5f346-bef6-4284-9da2-592b1a7c83a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4a95c700-f50c-4ad7-a4d9-cf4a0982962e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4d97dd4b-0059-44c3-b507-8d013608d054"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4dcba3a6-b7af-4ce8-9d64-d2226e976d57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4e3d429a-7846-445b-b861-12f5a4d73459"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4e55c64a-6739-4732-8e81-7cd3f229337a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4fb2bb72-0d70-4479-88cf-5a6d63354f56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4fb7bc4e-e713-4f21-9f53-572cb24e4977"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("50f3c4fa-6437-4c62-8910-265f79872bbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5219f34a-86a9-467f-a79e-5869550cc5f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("53cae597-ff2d-4cfc-a73d-8c6bb95e63be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("547cdeb7-9aeb-4fc3-83bd-9c83490cf45c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5750c12f-c0f1-4385-aa4d-a78c3e17b77a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5839bf5e-6616-450b-bba8-4b946dc86182"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("58e840d4-c1ad-42ae-bd48-ca78af57f499"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5b0ab8e6-b59b-4d8e-b983-c1958e5b9530"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5f571e63-3703-4bbd-8381-eb6533103681"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ff9eff4-4aff-4947-822a-68347f39926d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("61f903d5-9d1a-4ad0-9f45-000ba77ea4fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("64dc64c3-e245-4dcf-a2cf-aa36d7232878"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6684b7a1-d1a9-4813-8c6a-61b1ccdd5eee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6858a636-099e-4c7e-92df-62ce543e0f75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("68f66fa4-df2d-4416-9bab-dd89e7565923"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6bceb26d-1cb1-463a-9503-02bd26c969ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6cb51a46-de65-474d-a5f9-2170709d214a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f5c3d55-c6ae-4857-a78c-26ff951dcfb8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("718777f4-7c27-4672-bc54-edc110c380cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("75f4704e-7e54-4125-8556-6ebb09b52e1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("764f183c-3cb6-4dbc-8129-810730783812"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7868e310-6511-49eb-a177-f9ab86619e32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7bf2eb9e-a6ff-48aa-b17b-58d03ac239be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7f6161d6-1232-494b-8eb9-f0c52cab1842"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("80a3ae90-83b5-4422-9088-1af1c82120f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("81e24f08-df30-4445-ac3f-f33f34d18f43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("847aa096-8dea-4367-9cb7-1dee5c6bcc64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("867c5a14-e9f9-436f-9d48-f1364968ee8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("894f666c-ab0c-40ed-bdbb-24b1a40498bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9013be96-1ac0-493f-bf10-2a42822efd1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("94d405bf-b632-459f-a05a-bbdb72cac4b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9bedce7f-39ac-494c-86ec-8d00b47d4275"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9bfbc6e0-a5aa-4364-99b6-a35ed4b6d22a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9c6101cd-11ea-41fa-8e55-3e8102a7eabf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9f89e9f2-3fbd-4157-a162-1955727a4010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9fd953a4-7d71-4868-abc1-d6111ab63a74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a26f0509-1de9-40b3-8cfc-45898428c436"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a6ac855f-0bdb-4094-87d1-d87dcbbc1a5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a83ca7ee-d155-40fe-9905-2cfa82e806ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aad0a661-5275-4cd7-b1ca-3a4fd5f355c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ac9df3b0-3c05-4f00-8b4f-040f3eaf1bdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ae718613-33cc-48c9-b205-cf2031895514"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1db47e9-b7cd-4724-910d-350ea954fa22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b8f48b31-b106-42f6-bac9-cdbd3eaa42fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bafa0c84-a9cf-4aed-9b25-09e7e03daee6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bbee4994-33a1-42fb-947d-6ebbf9b8330c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bf5bc625-ab33-4132-bb84-2c856d3258f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bf91fe51-8278-46e6-8a40-da1f0d005e2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ccda755f-4b13-4ce0-80be-07275181e954"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ceaab3af-e720-431b-9bc2-5bc65d666194"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d0d2964d-4f8a-45ab-be2d-766451f0ce0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d222489f-5e82-469e-a9ba-4ddcdc5f9767"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d2a69183-4465-4741-b0e0-632e8ff180c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d398b984-2877-4e24-849d-aef2af967c52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d868fa13-ee4c-47a8-8a1d-f5b419c65a7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("daaf664a-322a-44ed-8e99-ad0cb1a42729"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dd4d91ec-46e4-452f-8cf9-172b30212f0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dd77abd8-d34a-4ca4-8bf8-4f5763f4b755"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("de9ea59d-df97-45f5-b64a-117f9f466859"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("df42b357-0552-4814-a7fe-c5cfc2636732"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e00e1ff0-f614-4884-b1b3-ca0456380bd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e309c60d-0511-4b7c-be1e-ee56770cc74e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7574323-1fe7-41c1-926b-a0bec596612b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ea419892-6112-437f-9124-56d63f9736ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f27db8a2-7d07-48ac-a057-ae9af18fe408"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f4fdaed9-6da6-4d71-8351-36989ef4fa62"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f58eff6c-05bd-4663-bea3-06599eb72202"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f5ac43a3-ad75-405d-8965-9a0367962cda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f9e81a74-a89e-48c3-ac3d-d9ff28d7b31f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fb887052-e3d0-44cd-b327-079f3cf0475c"));

            migrationBuilder.RenameTable(
                name: "ParkingDetails",
                newName: "ParkingDetail");

            migrationBuilder.RenameIndex(
                name: "IX_ParkingDetails_TimeFrameID",
                table: "ParkingDetail",
                newName: "IX_ParkingDetail_TimeFrameID");

            migrationBuilder.RenameIndex(
                name: "IX_ParkingDetails_SlotID",
                table: "ParkingDetail",
                newName: "IX_ParkingDetail_SlotID");

            migrationBuilder.RenameIndex(
                name: "IX_ParkingDetails_LastModifyByID",
                table: "ParkingDetail",
                newName: "IX_ParkingDetail_LastModifyByID");

            migrationBuilder.RenameIndex(
                name: "IX_ParkingDetails_CarID",
                table: "ParkingDetail",
                newName: "IX_ParkingDetail_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkingDetail",
                table: "ParkingDetail",
                column: "ID");

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("2f72327f-c5db-4bcd-934c-a0d6ab480570"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("690c93be-6a9b-4e2c-9493-a048c9ee2b2c"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("8c1e5706-f75f-45c9-bf70-f6fa6d9cff3b"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("ad4e7b09-aa63-42df-a611-f0aaccba6d93"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("e8963ee2-fa4a-4d4b-b68f-0f25b76982de"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("f4325f84-803c-4a7c-993a-d8f912e3fe91"), "Xe van con", null, null, "Minivan", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("65b1d02e-9abf-4906-a1a5-f66a5803502d"), "1 Year", new DateTime(2023, 3, 8, 13, 19, 15, 183, DateTimeKind.Local).AddTicks(3406), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("afd035f0-8197-48c3-9cd6-eac0723231be"), "Short time", new DateTime(2023, 3, 8, 13, 19, 15, 183, DateTimeKind.Local).AddTicks(3392), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea0bd066-3ddd-4b60-a59c-03b38c3ee26f"), "Half Year", new DateTime(2023, 3, 8, 13, 19, 15, 183, DateTimeKind.Local).AddTicks(3403), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("02669ff6-4409-4936-970b-a8d6fa9679c9"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$Apm5f.YgLlkRLCMFTLp59uELrU1M6rVE2GKe2tY105bOxkPa3Rn16", false, new DateTime(2023, 3, 8, 13, 19, 13, 95, DateTimeKind.Local).AddTicks(7355), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("0466d993-11f2-427d-8fad-004699c7a736"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$szX3vMtMD5bShwlD5fqqSOq74iT7DYjJ7v/nYpLKvqHGFngEkIHm2", false, new DateTime(2023, 3, 8, 13, 19, 9, 248, DateTimeKind.Local).AddTicks(5797), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("04dae511-0cac-45c8-8a1e-1b06d24b85e6"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$91pKCl3shWKFWXzTLDHSReHPImFXfJyw08DsWZPipNrMJ.XbqG6oa", false, new DateTime(2023, 3, 8, 13, 19, 8, 332, DateTimeKind.Local).AddTicks(4844), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("051828a2-607d-49ea-8051-e6d582e8619c"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$WlL4PvNwEq2Epy179cZy7.52HVrhPALh1zuCFbhv0XBgMr8He9JWK", false, new DateTime(2023, 3, 8, 13, 19, 10, 961, DateTimeKind.Local).AddTicks(9007), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("054c020d-32cd-46fe-95ca-78ce3e3b81c1"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$/5NELgMmrNcKbIhXiA5I5OLxdHrPT6sGNwQNRbJETl.NzMKEvMHHG", false, new DateTime(2023, 3, 8, 13, 19, 12, 374, DateTimeKind.Local).AddTicks(8703), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("08f0e308-3ed8-43b5-91f5-a9289c87ae28"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$ooexxRb8YiNVslZ6CpjvieaIbA7lKK3Xs.5OkCwPSA4UBisfmP4W.", false, new DateTime(2023, 3, 8, 13, 19, 11, 541, DateTimeKind.Local).AddTicks(1165), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("0a3f0eff-e27a-4018-9eb1-e21043c8da7e"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$DCTUVaqvlu4zfvdeUFZTL.AZTRKzCGMIqS1sqUQ4vLZglxQbAR7NS", false, new DateTime(2023, 3, 8, 13, 19, 13, 867, DateTimeKind.Local).AddTicks(9346), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("0b4b5212-8f22-464d-ab8b-942fab26e357"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$GEb5WRt3GQ194NqZMYMvV.md6GlNTeUg3l2XFXzoPJPD8UNmrVEu2", false, new DateTime(2023, 3, 8, 13, 19, 10, 109, DateTimeKind.Local).AddTicks(5751), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("0c2e0238-67ec-435c-92bd-7c1a308cb49a"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$KZXInjA4iu0WD3juD4o4OuTUwKxCD/dym5NhR/.cuAJyYaIXIU0my", false, new DateTime(2023, 3, 8, 13, 19, 13, 294, DateTimeKind.Local).AddTicks(5846), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("0edfa40d-7479-41bb-8c65-dc171d94d3db"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$wxYtEwtq7iW9EkFIsXQUv.i42n5OfYKpgWy0stQwcKcp4TawAkLh.", false, new DateTime(2023, 3, 8, 13, 19, 10, 537, DateTimeKind.Local).AddTicks(7547), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("132e4d19-d526-48af-92da-b46d9600952f"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$3QUICVrxNN/dy8ayIdlKnOLq8SPn0MQFX.6QeE71N2U0drDjI8wg6", false, new DateTime(2023, 3, 8, 13, 19, 6, 477, DateTimeKind.Local).AddTicks(6098), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("149d4b61-316d-4c94-a960-ad232855ba65"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$87vGWaRnGJ2q2HbRGLanKuHCKICZL19eMgW2NkS1H9C4KIvcAXcre", false, new DateTime(2023, 3, 8, 13, 19, 7, 943, DateTimeKind.Local).AddTicks(2673), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("1629aa31-777b-4fdd-9efc-b3f20c62de10"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$QvMXrXVG8tqkRxwrc7nkXe.zwFxfSNZuhHv69WyCS0JTMAO5zhc/C", false, new DateTime(2023, 3, 8, 13, 19, 11, 952, DateTimeKind.Local).AddTicks(4256), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("1d24c599-d9be-459f-802e-da14b8685e1a"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$yj52JJaEM9yGmbju7FzVH.gquYil7wrJyPqcbUYLy7BOiJ9Hce/RO", false, new DateTime(2023, 3, 8, 13, 19, 6, 849, DateTimeKind.Local).AddTicks(5109), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("1d69b426-62b7-4aae-b91f-427a2fce8f09"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$KZqKXdkscezcSJuFJl4QfOiqVTTqxDU9W02vfKZ8/736xTBtyqkx.", false, new DateTime(2023, 3, 8, 13, 19, 15, 183, DateTimeKind.Local).AddTicks(2626), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("20c9145c-76ce-46ae-b1db-c5f99a33ad7d"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$inkpcJW2kajxPlohiGlOEuLPubPEuO6N2yD8kv/PPdiaqRQ9wAyEy", false, new DateTime(2023, 3, 8, 13, 19, 14, 344, DateTimeKind.Local).AddTicks(9770), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("215f7d61-1fd4-40ea-bdcd-51763754d4f4"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$Uyc9OEiSCEcwjqmrdsoTR.eXG6MYH4iUDN/TXfmatiaGy/XxTmol2", false, new DateTime(2023, 3, 8, 13, 19, 14, 447, DateTimeKind.Local).AddTicks(1045), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("21c710a2-e8e1-4e59-a854-dd8df1805142"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$aLPaOTwhPeBcxZx9M73EeOh0Fmz1fgYEoRCpUsy/XiFJOVOIyF5Ki", false, new DateTime(2023, 3, 8, 13, 19, 13, 223, DateTimeKind.Local).AddTicks(2581), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("22658863-1443-4205-84d0-33ac0a417235"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$0wv468QtyYqGhsMtFFd9POkpTEL1mHUTlH1eX9y1h8j/JtKFVzHLu", false, new DateTime(2023, 3, 8, 13, 19, 13, 789, DateTimeKind.Local).AddTicks(3995), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("26f87233-8260-405d-9032-ffc755264462"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$OAZHeVeSvfMLl0VkfFpjEO.989WOGwULCASsYhnOifatRlIYjl2DK", false, new DateTime(2023, 3, 8, 13, 19, 9, 422, DateTimeKind.Local).AddTicks(5189), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("291b6209-18a4-4899-8db8-a456db1cc817"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$bDQ/Qqq38Cn5sDHAAnzk0uXLRcAZ45HiiHwadp6gVXTap5do34RLa", false, new DateTime(2023, 3, 8, 13, 19, 11, 678, DateTimeKind.Local).AddTicks(9871), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("29da4179-4959-4150-b34d-ccc19b38ec55"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$K05RD2KfAf3t3CbpwmEzIO5sVTtGxM2glCGbOCTSQpN7hC1oKSLxm", false, new DateTime(2023, 3, 8, 13, 19, 12, 197, DateTimeKind.Local).AddTicks(1994), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("2fe84655-450f-4d01-abc1-5c8fa807a1b2"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$l8OhI7jrFm8ha1DF2/b4OO3gzwHIUNnzExADAl7dH3T632ihRRsHi", false, new DateTime(2023, 3, 8, 13, 19, 7, 336, DateTimeKind.Local).AddTicks(2899), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("31e33406-61a3-49dd-ae6b-6f2103d081d1"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$ly1uMyswlxOEp6yFfOJgt.vA7NE8YPyAJOFR3OzSizTsRJcTxFSaG", false, new DateTime(2023, 3, 8, 13, 19, 9, 509, DateTimeKind.Local).AddTicks(643), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("33d02cc5-fa54-4f04-b550-520c6fe89a47"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$SAcxg5ISlkc2b8k1EJOs7.pDXXkFrO8jx8hJNiwGS53yX5Dr0nJt6", false, new DateTime(2023, 3, 8, 13, 19, 6, 667, DateTimeKind.Local).AddTicks(2325), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("363199c4-7cf9-48f0-81a1-fffb3a89182f"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$pdKncWVseWymczm/PZF23uIWur09dXwlosqj1GIZFVrWR3VY88p0G", false, new DateTime(2023, 3, 8, 13, 19, 11, 357, DateTimeKind.Local).AddTicks(8642), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("37e9f7c8-c0e1-4980-932b-e07361107690"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$i.G8jkyManQ9b5KpMP4J3Ow34yQiX6cRM6gQ4SHcZ.XR.DYIwkUaO", false, new DateTime(2023, 3, 8, 13, 19, 8, 184, DateTimeKind.Local).AddTicks(6553), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("3ada371b-2a6b-403a-ad7b-07b338f84cd4"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$e7o5GJFgQ/myhufHvVXH/u42nlOwYMqH0G/9p.seIu9uik3DWkiGC", false, new DateTime(2023, 3, 8, 13, 19, 10, 462, DateTimeKind.Local).AddTicks(5193), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("3e0291fb-9f9a-412f-91fe-bdcd297a9d9e"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$QFc4KJKP5sp9L5lSUsmVXe6pCQt7vIaqBMCMwTIun5cXOPCi.h28G", false, new DateTime(2023, 3, 8, 13, 19, 7, 486, DateTimeKind.Local).AddTicks(1271), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("3f6944af-25c0-483e-a092-4cdee45ec7af"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$Gp.4CD09FpRhYNXUrGi6b.up287nWzFjmaRqpL9xQsPzKAu8Ln1XC", false, new DateTime(2023, 3, 8, 13, 19, 11, 455, DateTimeKind.Local).AddTicks(7601), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("410640ae-b850-4b10-bcdf-e7a3865c8480"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$/eKu0YaGZHBNffjyu/FrjOLI/DsYHtXvwfOLTSubwHXoCjexCxhkS", false, new DateTime(2023, 3, 8, 13, 19, 13, 360, DateTimeKind.Local).AddTicks(7422), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("43f057ad-8447-4d37-9f4e-bf6168bb572c"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$fjJGjMEP8HFWez.WD9FkBeMVLvuZGq2O0mQau4mpjSWxaBtbpir5G", false, new DateTime(2023, 3, 8, 13, 19, 11, 814, DateTimeKind.Local).AddTicks(5139), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("44e8a138-c2ad-44c3-b148-09f049cc6863"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$sDqDsVqiTfFwZGtKuDI9yug9y3jAydpr1TocfoaN.BOnm.mOhfIre", false, new DateTime(2023, 3, 8, 13, 19, 12, 296, DateTimeKind.Local).AddTicks(9466), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("494bb58f-38b6-4705-a107-fc50da6873b3"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$kaYl.f/Ezk.TkevVUiEiT.BZCCu7/hdS7IPjigIOzWeD4TUK3ead6", false, new DateTime(2023, 3, 8, 13, 19, 6, 571, DateTimeKind.Local).AddTicks(138), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("497eafc0-80f2-42e1-a615-52ed0c135e66"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$yikCIdjafQFiBKONXHdHYe.xxqZubP0uQuTtPqOlz46amTroXHkXq", false, new DateTime(2023, 3, 8, 13, 19, 11, 746, DateTimeKind.Local).AddTicks(8846), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("49819253-38f1-4215-951a-cdc4cdb7dc0c"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$Ze.zrBSKl2WZpWw3mst/a.zYtFgJBDXgw1/GnB1y0yI7m8xcRJsq6", false, new DateTime(2023, 3, 8, 13, 19, 11, 881, DateTimeKind.Local).AddTicks(3301), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("4a1abdf2-6981-4c7b-b5e2-b7a44227420a"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$UqPZ85EHTrCtdVq.FBqDGusQ7huI05EFjNXiLeRpdiNZyFSBikfDy", false, new DateTime(2023, 3, 8, 13, 19, 9, 933, DateTimeKind.Local).AddTicks(132), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("4b928b19-97e7-4c44-bb94-02aa49303739"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$.CrZeR2UA45mrEKqxCIgs.bUxWFhJRuN5m3fjoeWdwQJL61YKBnEy", false, new DateTime(2023, 3, 8, 13, 19, 7, 560, DateTimeKind.Local).AddTicks(3618), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("5211fb2c-7714-49f4-8b03-bc1fb77ba2e1"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$lbIMyGigEPP.UW6jEKV81.FwNiXwkIsyviIYELU8PRT5C2TU//yla", false, new DateTime(2023, 3, 8, 13, 19, 8, 25, DateTimeKind.Local).AddTicks(6291), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("5231e00a-6764-4671-a624-453d8c6ab36c"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$IjWvdcO4IDcYia6jVDAiI.0IY/HMLi8Aq1XeC07vLGDkw4Gaj8G2e", false, new DateTime(2023, 3, 8, 13, 19, 11, 112, DateTimeKind.Local).AddTicks(9416), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("52abe7f9-ad6c-49c4-b4d0-30a03a22c31b"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$Y3tyXNZFDrz3lNVgn1wasuCB5vl.JaIsTkAVTPqfxjyyajOMChH6e", false, new DateTime(2023, 3, 8, 13, 19, 9, 679, DateTimeKind.Local).AddTicks(4581), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("57ba35ea-8d4a-41ff-afe5-9baecd8186c1"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$XEoocjEl/q5cKnlo.mrdXuhslwA3OiZkJ6Z/jDXY2hyKX7ubcDZpO", false, new DateTime(2023, 3, 8, 13, 19, 12, 41, DateTimeKind.Local).AddTicks(3338), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("58c5fcf3-0bd3-4855-bcc5-a3cd45d215f7"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$eYlAm7mDzqAoieFrC1tOxO.69xOK7hjX07ogELEG7xoTMasifIzD6", false, new DateTime(2023, 3, 8, 13, 19, 8, 762, DateTimeKind.Local).AddTicks(2424), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("590594dc-742d-4802-b441-e1d58bd33940"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$PtCRASX0ADu1tZyd1HeZdueiYfaME0VPyKH9c2bVpz.VFrmb5.Kxy", false, new DateTime(2023, 3, 8, 13, 19, 15, 73, DateTimeKind.Local).AddTicks(4816), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("59bdbc23-8cea-4153-a14f-bcac02311f22"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$iLBrnv/aG2ulBZCg9r5XWugN6Ol2SMJESpjw56lFWmwwUYGVAg9m.", false, new DateTime(2023, 3, 8, 13, 19, 9, 767, DateTimeKind.Local).AddTicks(3364), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("5df1c6c3-c1de-42b1-a92c-bc0463d17140"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$.ue/uOBAawopMQSrRcxuW.sqGaXuaqLLwLqYtg3Svad54FJe/3pGe", false, new DateTime(2023, 3, 8, 13, 19, 6, 931, DateTimeKind.Local).AddTicks(3354), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("5eb4cdf9-7e29-4c2c-a58d-6b7e75bbd902"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$RadU/34uAMBHE683TL5kNOzANPhrDIx7TzbnZObEOwLEhCSmoYxsS", false, new DateTime(2023, 3, 8, 13, 19, 12, 870, DateTimeKind.Local).AddTicks(3314), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("60509131-3fb9-4af5-884c-2a4949c7ac6e"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$bOGWQBpJihQV9AzOhN8XrOuPXRgo6YrV5gGiLLeV.XVv/YeuQv1BK", false, new DateTime(2023, 3, 8, 13, 19, 7, 865, DateTimeKind.Local).AddTicks(4004), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("610aa9b6-c917-4979-a165-8d50a8752cdc"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$am4a2Zbi1BANXVU4iwClw.C.ZmuUemQrbPGBo7QKDb0cncok8VPiS", false, new DateTime(2023, 3, 8, 13, 19, 12, 641, DateTimeKind.Local).AddTicks(1528), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("614afcd2-2fd7-47e4-87ba-6d8f26032ed0"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$kPQtUIblg41RbEgy.37n9.Mf9QgIZwxmr8JdITbFnnjlkN4TC52ba", false, new DateTime(2023, 3, 8, 13, 19, 12, 781, DateTimeKind.Local).AddTicks(9888), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("634b1489-1213-4b02-9222-8039c289aa20"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$X8zrUOa3vvTHdHDxPITbSuNK2hyxjiPd16Da2LiGFsXgf4J5u.lym", false, new DateTime(2023, 3, 8, 13, 19, 14, 589, DateTimeKind.Local).AddTicks(5412), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("6403ea20-4d91-406c-9979-86497ca8b772"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$WTQ.ayONYP4/CfGYtLcSReMHf1aJdl1jncA1MpYIfbgpt4fyxNoyK", false, new DateTime(2023, 3, 8, 13, 19, 13, 933, DateTimeKind.Local).AddTicks(7087), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("66515378-07de-4299-96ef-a92336e64c12"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$zVfMc.PcqLYgmD3w6//IP.GEl2/mgkw9ypl/yuB7lWW0/6wMUAtTi", false, new DateTime(2023, 3, 8, 13, 19, 10, 716, DateTimeKind.Local).AddTicks(2076), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("6896f6a7-012d-4ba2-a9ec-4c1465374ad6"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$pDOX6zcKXEvM31kRYI6lZu7ZXlHXBhmjas8j662wJXobHaPn0rrnO", false, new DateTime(2023, 3, 8, 13, 19, 10, 313, DateTimeKind.Local).AddTicks(7741), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("6ab6e29d-8868-4a23-b1c2-943624f9eef5"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$Uhg0fsmViuOMzLjdmXrxme9oAMt0NuhajHTZ.oEK4neZOFVKHPYD2", false, new DateTime(2023, 3, 8, 13, 19, 9, 852, DateTimeKind.Local).AddTicks(2598), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("6ce91831-90fb-4cd2-8932-1564e1162ef1"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$hxkRjT7WEbXTE4JSEoDG/.3p1/iQ6nGXbi5AO707XtxJFq3ctAJoW", false, new DateTime(2023, 3, 8, 13, 19, 10, 813, DateTimeKind.Local).AddTicks(4307), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("6dc67c92-2a8b-4355-9689-bdeb478d9fa1"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$5x7xWqbrQKDPijeE/hzFZes.2MmEOENA4ymVKIfsxYjx2i7pD3Pyq", false, new DateTime(2023, 3, 8, 13, 19, 10, 625, DateTimeKind.Local).AddTicks(8067), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("6e2140a9-9b49-4456-bf3c-efc307d956ec"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$.7/Vmi/hlVmFOCtHkVZ0G.148KuKRbN8N0VrRkWtm0dnYYkke5x6C", false, new DateTime(2023, 3, 8, 13, 19, 10, 389, DateTimeKind.Local).AddTicks(1161), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("7338db61-9e48-4173-bd84-a210a8029c96"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$jPxklodK2iP6I1531YkxMOgrQEMrhgal86SEIee9ryMJ6pgmgOb/G", false, new DateTime(2023, 3, 8, 13, 19, 10, 225, DateTimeKind.Local).AddTicks(5707), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("744c9299-6955-4743-a581-a87276f693b5"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$dWxZVLJy35sfY9lfVadVCOzSLwrk8cKTPmn5Juhc2fL4Rnktc3p1O", false, new DateTime(2023, 3, 8, 13, 19, 13, 702, DateTimeKind.Local).AddTicks(2828), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("78b52f00-d7e8-4cef-b471-72ce400c9a05"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$XKUWhFSMjosnwOBwVaPskO0WODI8uojXmAodS00q6S0d34JpGX2fG", false, new DateTime(2023, 3, 8, 13, 19, 6, 223, DateTimeKind.Local).AddTicks(7334), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("7ac212c8-f0fa-4763-981c-62f62792751d"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$1OyiQAx3vuPG0Q8Nhu8V/eFzJky1Rgyiog0sqss58QyLMSAbCrDga", false, new DateTime(2023, 3, 8, 13, 19, 7, 713, DateTimeKind.Local).AddTicks(9901), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("7b4a6b51-9252-4a04-8fbb-d5c4ef52ff98"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$RtHH9h9cjWwQp2rs1AbXSON9m4WOcuEuOKUS4aDSWdQm3eGXtnkKW", false, new DateTime(2023, 3, 8, 13, 19, 7, 636, DateTimeKind.Local).AddTicks(680), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("7c6d27d4-0706-482b-92a4-a760fb9ae269"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$j4SBcD9DrFj/44YN76mAhemb7XWk6DyVc7HJIpHOzEAp51Gk.eXfm", false, new DateTime(2023, 3, 8, 13, 19, 11, 34, DateTimeKind.Local).AddTicks(3075), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("7cbc1148-771e-46ad-98b8-2ce042a7593b"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$3geUaadYn5VsjjUOKv7pU.ginQmldXbGcNxzzG4ndWJKiZNuBQCuK", false, new DateTime(2023, 3, 8, 13, 19, 8, 837, DateTimeKind.Local).AddTicks(5671), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("7deb329f-eb18-410d-ac9a-51429c60de6a"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$P4ZPbYronV29oXZSuHgBc.myD8BHttQ8RlhfwJgbHMMwJPsm2mv/y", false, new DateTime(2023, 3, 8, 13, 19, 14, 522, DateTimeKind.Local).AddTicks(2086), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("820642cd-382b-4c77-9005-6694bec2cf7c"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$f7Q6EJyJZoAhskk/moBOn.qaFaljhN155SG6PNDtoFxE0VriLzZZK", false, new DateTime(2023, 3, 8, 13, 19, 12, 573, DateTimeKind.Local).AddTicks(9264), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("83203798-7700-41a2-9946-60629e92cb4d"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$gZpKSia236fWcsHZsFuPjOwcmOKHMH3jkDHzovMOmPKO5quxIcVmS", false, new DateTime(2023, 3, 8, 13, 19, 10, 17, DateTimeKind.Local).AddTicks(9436), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("89a53855-cfc2-4eba-984a-252e0f463dbb"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$rLR.18SfPAD8i0WvInHB.eiGvyohNrahTzKfG0Jm5lznJB6Jyvmfy", false, new DateTime(2023, 3, 8, 13, 19, 6, 760, DateTimeKind.Local).AddTicks(3249), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("8bd83374-ef45-4e3c-8efe-ec81701b6943"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$To6T38DyaoIW4QL6o1mnxuxm39vf.hg.RJuV4KgeaX5jbHQTjArgq", false, new DateTime(2023, 3, 8, 13, 19, 7, 174, DateTimeKind.Local).AddTicks(203), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("902cc7e2-4c62-4fd8-9782-a5858bfa198d"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$x.2dPgG7u3G2oZovLZi58uPuBZ6xQLuAsCUG0kBEgOPrFGz/8Gtpe", false, new DateTime(2023, 3, 8, 13, 19, 9, 78, DateTimeKind.Local).AddTicks(9291), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("95548208-7b5f-4b43-9af2-02db7e893593"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$77sm4vHYOVM3UmxMzQQJIOmVQT8hS0rhrRMx4AlUp/g81ver3hB6u", false, new DateTime(2023, 3, 8, 13, 19, 8, 473, DateTimeKind.Local).AddTicks(5335), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("95b7088e-ffcc-4635-b639-ea8c37302ca2"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$I3tPjzEuTg2RK2I0L028QOOw85yc7zc3BWwnNI.Dgh/i9N480rRea", false, new DateTime(2023, 3, 8, 13, 19, 13, 998, DateTimeKind.Local).AddTicks(9479), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("9bbabcbb-c9d2-4e8d-8299-5239a688d39d"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$NVih.beVtWW26NiTwdinheaiLtI0lMOlYscDiUVz4ka195hlYbSA.", false, new DateTime(2023, 3, 8, 13, 19, 6, 300, DateTimeKind.Local).AddTicks(901), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("9bf071e8-4a03-4697-8969-fef8b41e4cfa"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$xKkyrMVxTcCi9xw1YR5z6.BjfoVs.RhAsPNPpfqm7YN5vr58UUwfq", false, new DateTime(2023, 3, 8, 13, 19, 14, 264, DateTimeKind.Local).AddTicks(1349), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("9c13959a-7675-49b8-8f98-a4c416b8ff8c"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$BKvOpFIC9ya9YarbNjJN7uxMWmKMDqd6.7dL3USPDzScnkt.MKhVW", false, new DateTime(2023, 3, 8, 13, 19, 11, 180, DateTimeKind.Local).AddTicks(7312), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("9d00cd2a-42d4-4952-b791-3d8b7af06084"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$cyyOyTpMFxOna1COl7iY/uf92PTaDS9IgdD7cqbcAIOJ2.kzRWgG6", false, new DateTime(2023, 3, 8, 13, 19, 7, 89, DateTimeKind.Local).AddTicks(6034), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("9f7976c4-a490-4e86-8e83-942ebe05d1a0"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$MjBlEQIsD7ufuSr7/CDXqexoBq4xMA6FGYwy76mF/KyV3gMhT7HRW", false, new DateTime(2023, 3, 8, 13, 19, 14, 74, DateTimeKind.Local).AddTicks(7649), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("a119d2d0-aa4e-402c-bf85-dad58ea21f3c"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$6PV6ds2l2Od6c0Kl5s.V1uggmDSJDK7T6NHt1wPk27WPcJxw6M3ra", false, new DateTime(2023, 3, 8, 13, 19, 13, 559, DateTimeKind.Local).AddTicks(3039), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("a251185e-c85b-4963-b161-f6893cfff933"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$WpFQFIOn/A6PcgmhyT4mZ.IqSOC6Vf1n6RBkB4uC3sqzySKyA3/yC", false, new DateTime(2023, 3, 8, 13, 19, 11, 610, DateTimeKind.Local).AddTicks(1799), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("a805a67e-a118-4053-8d7c-7f0e689540b4"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$5b1/DLzfbNQzoadQU4KhAe6YN7/ZVF/2FvpDbo8tq6xkTomJMntzK", false, new DateTime(2023, 3, 8, 13, 19, 8, 914, DateTimeKind.Local).AddTicks(3667), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("a8934c37-a09e-4a66-aae5-7d96872ae8f4"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$2iH0a9hRDq88sjT32sPkZOt5ER0mDhhP.zuSKnqsYZT9Z4JCtkkzu", false, new DateTime(2023, 3, 8, 13, 19, 6, 386, DateTimeKind.Local).AddTicks(390), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("aaf8586d-3e16-4ab1-910a-b004abc0c289"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$AnvGIhHS7Zw60KWduuSTg.VidR2GB9fOWa362cGqd2Yq325fD/zTa", false, new DateTime(2023, 3, 8, 13, 19, 13, 426, DateTimeKind.Local).AddTicks(7499), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("ab4e97f4-7615-4fc0-8cad-d632e55b31fe"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$FqMxOcb12mkZsoJ2HG.inutcLt3von8G6P3lZU3Ek0sRSToGCVv/y", false, new DateTime(2023, 3, 8, 13, 19, 7, 412, DateTimeKind.Local).AddTicks(3882), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("ac7f3284-5c8b-4933-89c5-51b51d40d861"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$.EJxhj.m/6OHv5LGuF2rKeawFMiZXPk5zd.ZUPyuZSEb92a8gVd/2", false, new DateTime(2023, 3, 8, 13, 19, 14, 184, DateTimeKind.Local).AddTicks(3717), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("ade25e52-7880-42c9-8cfc-d3a4c96e5497"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$p5iHgqB7apdjou5BWGJk6.F/NCkjd.SaLTQ7q5U5FRUkS2IRcazWC", false, new DateTime(2023, 3, 8, 13, 19, 7, 790, DateTimeKind.Local).AddTicks(9019), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("aeef6fa7-d1ba-4c7e-b219-62bbf793d29b"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$wPqLUj1QtDfCoXugin2F1OhHTNlAVE0VJEX/x3P/pMw5LsctyImwm", false, new DateTime(2023, 3, 8, 13, 19, 8, 682, DateTimeKind.Local).AddTicks(4236), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("b0569a31-0288-4f95-bb69-a0b72940351a"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$izM16/VNubhW7vdhKl73Q.XFsQe0v8ZveYlqo.qvAzLKZ7IG.xEF6", false, new DateTime(2023, 3, 8, 13, 19, 8, 107, DateTimeKind.Local).AddTicks(1151), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("b3d3cbbd-ce42-4b73-abdc-2688c391b2b1"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$lezKTlqxszQVmyT3RuB5lOtxLO4IlNV486uiUy7FaBwUGF8PeYF5e", false, new DateTime(2023, 3, 8, 13, 19, 10, 892, DateTimeKind.Local).AddTicks(1204), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("b57dfd7d-cd09-400d-85ca-5a8e3b495146"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$75GK0yIoC0iXlpugVObG4eI2ggxxIUo4aZ2nCgHGtKloLCjFuouPO", false, new DateTime(2023, 3, 8, 13, 19, 8, 542, DateTimeKind.Local).AddTicks(8518), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("b84cd8dc-3c94-4025-b17a-7e17d3489681"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$KxdSAGwJ88PNa9geNaLJi.eaU8OoExz89gpUFxIBD9YnFiAFExAka", false, new DateTime(2023, 3, 8, 13, 19, 11, 265, DateTimeKind.Local).AddTicks(2290), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("b9a14b48-4fbc-4d23-a506-06f79be61216"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$Tn2H2B4iihTMjnBTY9.lm.mnyb1aF3fkdWIuWgVc3rfzyGTEOqZES", false, new DateTime(2023, 3, 8, 13, 19, 14, 675, DateTimeKind.Local).AddTicks(7826), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("ba3f4ad7-ebca-46af-8a9a-689567438001"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$/0iOORy.4ussEovfwHAMee.txO1hddg/g59s0wtWcEtS5RwCXFOpO", false, new DateTime(2023, 3, 8, 13, 19, 12, 441, DateTimeKind.Local).AddTicks(2035), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("c006bdbb-edf0-4613-8454-285fbf0fcbd4"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$LNZpMYxawUdUocLDIfUxKOyjqK7DYzbcqnqvmsyjcpzareov9lCZ.", false, new DateTime(2023, 3, 8, 13, 19, 13, 492, DateTimeKind.Local).AddTicks(3014), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("c1014168-2d5d-4cf3-9ced-810fa66cc2a8"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$gPMG//Kn6RoztcGtKyq.FODIvh3KlfxGb7t8hTQ71CRYJgbFiZ6GC", false, new DateTime(2023, 3, 8, 13, 19, 14, 964, DateTimeKind.Local).AddTicks(4618), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("c1a67a92-917c-48e1-86a9-dad1352c8985"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$NgbOcMxplgRoLvUp/ZqmveZRJ6AM9T..W46Ch2Mrpd.eZWB.wBfES", false, new DateTime(2023, 3, 8, 13, 19, 12, 949, DateTimeKind.Local).AddTicks(8623), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("c4b7df2f-a980-4196-a18c-c56b8b145f2c"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$Q938hZDDdutn5Dliz37sQuj2F1jicjAg2dtjcx3FnsXOIT5UkIrP6", false, new DateTime(2023, 3, 8, 13, 19, 12, 506, DateTimeKind.Local).AddTicks(8228), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("c5056c91-3e75-441d-bdee-9e4c76662ac8"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$wVq2GegvWWlaAhtAU4CEVe5baV5ouRUF66dSDZkUVObnjcErB8r.S", false, new DateTime(2023, 3, 8, 13, 19, 13, 15, DateTimeKind.Local).AddTicks(2390), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("c6547fa0-e165-4fde-b3ab-c74111adce40"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$YiGnj9KWttf.UicG.YeyMuXoap6m9Vk73Qz6jxA5oRV2qa6DxJwt2", false, new DateTime(2023, 3, 8, 13, 19, 9, 592, DateTimeKind.Local).AddTicks(4260), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("cf46ee22-a2bd-407e-94ad-2ce5cc17dea6"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$Owzq/LOdgKJQWvC8TtgvwOlBPSUWv166URdq/jBkVJm/lFKAOy/JO", false, new DateTime(2023, 3, 8, 13, 19, 14, 888, DateTimeKind.Local).AddTicks(1984), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("d15e20d7-e8d0-40c4-96b8-7104b39286fe"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$5aJNKdYuV2AzcYRJi5OUiu2oTA3O8cgTdVpkt75U9ZLUSOej2Q.oC", false, new DateTime(2023, 3, 8, 13, 19, 9, 335, DateTimeKind.Local).AddTicks(7970), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("de396385-8929-4b60-b6f2-9fabc946c912"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$4yvKkUb6VNAZH3XEFcYIaeY.qFQIpKFkZwQE9gXYKfIPLm5Wm2lpC", false, new DateTime(2023, 3, 8, 13, 19, 7, 9, DateTimeKind.Local).AddTicks(9719), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("de7fdee6-a79d-4df6-abf2-3990e938e6c4"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$RvLdLa4kyDzVvt2LMMpHtu9u7xg7y1OUvEcq4OOAOtCg0I.qtR9lC", false, new DateTime(2023, 3, 8, 13, 19, 8, 403, DateTimeKind.Local).AddTicks(8303), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("e63a120e-d290-4aa4-acfc-e5fb9d4fdd22"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$KTyZ41KES0tKRrVP9cz3eu48xKdGDziAIjz6PM7tiPoSeJjHoPyYG", false, new DateTime(2023, 3, 8, 13, 19, 7, 256, DateTimeKind.Local).AddTicks(8624), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("e6b6e36a-64bc-4b81-aa5a-ca994d3bb8bc"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$t7GvQ204HmTlLASgg3FtWet4KKYvMd.9QIWcT5Oe.80yg.wd/1Hk2", false, new DateTime(2023, 3, 8, 13, 19, 8, 611, DateTimeKind.Local).AddTicks(4339), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("edd680ce-3410-4127-946e-b0a1fb8470f3"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$yi0eRxYSI4jaeb27aBlxR.EB1aZQLGJBaUAuYow67grcytMs/Aqc2", false, new DateTime(2023, 3, 8, 13, 19, 13, 627, DateTimeKind.Local).AddTicks(790), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("ee5667a7-f456-45c2-b13c-7907d35a9fa7"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$cyw4Gaua0gWCn06DxlRgJOYqiKxxOZnXl6D4eIhWfVUNG63s6ylnm", false, new DateTime(2023, 3, 8, 13, 19, 8, 995, DateTimeKind.Local).AddTicks(6355), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("f18f01df-6e75-4fa3-91ba-478d6d605d71"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$/tznglPNmnyvF.yjagsAOezFMlUrzXmNjClZ2fZ33nOm/RD/PmJFW", false, new DateTime(2023, 3, 8, 13, 19, 14, 810, DateTimeKind.Local).AddTicks(9963), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("f48363ac-5d6e-4d25-8c02-7bcf283bbdac"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$SV1jaG4cHmzRyKdoeJiZvO7J23jAld9xhLuYgD35QHXkzSAI4wrMK", false, new DateTime(2023, 3, 8, 13, 19, 12, 707, DateTimeKind.Local).AddTicks(5065), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("f9df6bab-c581-4622-b065-173bda4122d0"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$3U4LNiaGZjhxLLO0rjZ17.VO8gZr/lZJF9hUpHvF1XDyiaM8dhgn2", false, new DateTime(2023, 3, 8, 13, 19, 9, 162, DateTimeKind.Local).AddTicks(3637), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("fb5393a2-afc7-45be-92f9-096bdd14418d"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$u/gvIz/OeDy82Vw7pzSuWOm65FV84yMXZ6Vw5hwDkEKuQf7FoPDGO", false, new DateTime(2023, 3, 8, 13, 19, 12, 119, DateTimeKind.Local).AddTicks(6429), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("fbd5f812-69d4-4208-b3da-9dfe14f77f91"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$JULdQS6uRNnFwmOxK1H1w.3gX1ci/Q.0/UgYq4u804TB6Zm7kdJxi", false, new DateTime(2023, 3, 8, 13, 19, 8, 259, DateTimeKind.Local).AddTicks(6712), "Goddman", null, null, "00110582594", 2, "kgoddmano" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetail_Cars_CarID",
                table: "ParkingDetail",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetail_Slots_SlotID",
                table: "ParkingDetail",
                column: "SlotID",
                principalTable: "Slots",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetail_TimeFrames_TimeFrameID",
                table: "ParkingDetail",
                column: "TimeFrameID",
                principalTable: "TimeFrames",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetail_Users_LastModifyByID",
                table: "ParkingDetail",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");
        }
    }
}
