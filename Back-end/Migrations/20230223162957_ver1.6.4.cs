using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver164 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parkings_Users_LastModifyByID",
                table: "Parkings");

            migrationBuilder.DropIndex(
                name: "IX_Parkings_LastModifyByID",
                table: "Parkings");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("07c0abb7-c3ee-456c-bab0-c24880632164"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("0c01bd21-4843-4825-afaf-8ed2cd985094"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("35b0c816-7e7e-4482-b42b-b19b43b05fc1"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("368664b5-42ec-42e9-9ec5-44f8d9339dde"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("586698cc-7e14-44f3-8b88-c0de5d42baa5"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("d236d2ac-eb0b-47b2-bd2f-1a338918771d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("03117ef0-fc63-46df-8b92-4deaf2473b59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0743bd5c-12b8-4873-ad50-48c0b28a7001"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("08717f46-54ff-47aa-9b63-173de16e9f83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0aefb431-7720-4a9f-b038-da2fddc75db2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0eb67b02-6cf3-4fb1-bbf9-054063215fee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0ed43038-1d7a-4553-9c45-78ba08d0ff5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0f906cda-ff8d-40d0-81c5-bd792be27dd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("15beeaa2-1adf-4c9e-90c8-88f433131ac9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("16268a77-280c-431c-ac23-8f403ec823f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("167fd983-1747-43fd-9e0b-2f3801e01ec2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("16d0e1b6-ab84-4f9e-a1f5-6b89d3c056a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("17d41bfc-6056-454c-bee7-3c73c5a58daa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1ac013ff-adf4-40e8-a671-65365b5ecf4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b0db95f-17bc-4730-9e12-7975d65a60b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b1ae92a-04d6-40ff-ba16-43d98ade59e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1bd000d0-2ff3-46f9-a4cf-1b5e7af71c22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1c12719d-fb58-4037-bf1a-4ab35b5ee03d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1c84edfc-adc0-4669-87ad-e35ee1e18ae1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1fd78362-941e-40e9-982f-ccba3e8aa8ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("225392f3-cffb-40d9-ad7b-5da2fc4c09c3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("23d19a0d-9cde-43df-847d-77f100ceceb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("299c65f7-d4d9-46de-b15a-08a59fdabf07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2b307aaa-9f18-42c9-b373-f787baeb9668"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2bec8b7a-a215-4e6d-9c8a-75edd4fa05df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2d434350-a351-46ec-acef-47c1e32163e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("30305ea7-57d9-4e09-8e2f-f87b0a8337ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3249dcff-7018-460e-98d2-ffc911245498"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3835389a-e64b-4285-bb7b-b6dcba2e4446"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3dee57be-b05a-4966-9cd9-a1f8f482b0a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3e72f54f-7d44-45bd-ad43-cbb616841adb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("40b73121-9d7e-429a-bd60-127e6b14b19b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("40c44b5b-b82f-4fcb-83d3-1dab7cbd761f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("40e2c034-2169-4318-8670-2fd5a9d1d936"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("45082b3c-c9a8-45cd-a68b-9d12f45b718f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("46cc23ca-f47c-4e84-8c05-e7fe780316ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4bb471ba-4cc7-49ba-b8ac-09d3d4ea586b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4c865e92-fccd-4fd2-81df-3b18c39b7b16"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4cb9bf7f-2cde-4e2d-80b2-6610ecffb53c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4f0088d8-6b01-46c9-b944-c1c3bb3a98df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4f45a0ab-1fa8-46b0-a825-a1936e48a839"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("51d3014e-8cf1-4e15-8aea-3923a86f36c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("52afb11a-e7d0-4083-8cc4-9a5bdb34ad5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("53e1e512-a75e-41df-81d9-e9271c0ce3ea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("572202c0-7f54-41ce-b5ea-14c42e653981"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5774aee5-11b1-40bb-8016-778931974076"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5aed001d-6ff5-44fb-a0b6-26ab026b7acf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5d8ea1d0-bd1f-46a3-931c-b522874e696d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("602ac6e6-9e81-4488-8595-e41c81a9aa48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6202047d-3460-410d-a882-61449f635e4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("64b81f09-500f-48bc-b7b0-bea181a62c25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("64cc5e57-fc6d-43d1-b747-e6119ded804c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("65921b4d-a95c-4660-9c84-52139bc1fc83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("682faf95-1f71-4187-ad2e-482945491d24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("69625d7d-e4d2-4500-bf26-7584b1bcd1e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6a4c90e8-2588-436a-ab3a-110167c10127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6ccf6fa1-ed10-4db3-aaf6-5c011450ec06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7316b0b7-3821-45c9-b50d-ae31f639f132"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("77086632-1a24-43e7-b33b-2b2c0669efc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("792f1226-ef21-49e7-a499-b5e01ec8c3a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7cf1a9b8-6266-41a1-a3b6-66e4388d5767"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d9e854e-16b6-4483-a957-161ad0029a17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7ec048d6-ca75-4ea6-b6ba-0d0889f94b78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7f1251a9-826e-4f03-ba8b-3ec892f37bea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("85d7f52d-28ad-4b74-a7ef-b2f22e943268"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8988a99e-342d-43e5-87e7-b9d401807898"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8a282d5f-17bf-49d8-b3d8-872b4ea168c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8a376cd5-d4ee-4c2b-a0f0-08366fb71fd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8aa35713-c583-4f80-9042-549c4aefa911"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8bba4805-a832-4655-8282-a7c15c6a400f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("93a7adf0-8fe5-428d-a68e-cfe9292afb26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9445c592-9b39-4b28-bd42-2b1bbd084457"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("94684b4d-9702-4e1e-8db5-82861f87b799"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("96609731-fe5f-45b7-a9b5-d3ad0da12d30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9872580d-8e14-477f-b5eb-e16fb264dc53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("99dc3948-b7b7-40ee-890b-c7186b1e685c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9cce6a30-8437-4688-a6e9-5dd243c76451"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a094c0b1-4af2-43aa-880e-c7a8cad589e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a27e1cdb-1bc2-4876-ac76-67cdaf9af2c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a43eedf8-caa8-4fc3-98c7-f5a6314c83bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a4de98ec-aaa2-4a2e-95f3-20315ad34cb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aa1de720-41a4-4ac6-87cd-83746f5895dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ace6a572-2636-49a9-b40f-0620e0bb5f75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b0286853-6d06-4de4-8454-1b48db2966bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b35f9bb6-c187-4fb7-8540-4a25829b409a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b93a0677-7b2f-447a-a205-8d9660e344d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b94c6efe-9782-41b8-a281-79e06ebdb37c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b98b3f99-47b6-4ef1-8fb8-0a4103c98f7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd2f25a6-077b-4aef-9d26-0bacfd6092f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c1547a98-9ec3-482e-a4a5-3e1b3eea2f3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7777777-a262-4d8f-888a-ac7abe109dd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c84c7480-e58a-47c2-8503-9cbf925338bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cac14f23-8ef0-41a8-a4cc-383fe6c65135"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cc4b3d7f-53b8-4790-9265-af8ddb7ea58b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ce5eaaa4-b4c1-45d8-8730-7535a3d02e40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d5b2fe38-d772-410a-9281-36e331978541"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d810a0ee-b6e9-46b2-8c23-1011c49f4711"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d9aae942-150f-4db3-9ced-74ba62decd7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("db17c297-dc71-49ba-9e28-c4c1e294ccfa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dcfc0d46-c1e9-49fd-8d83-51d104bb4fea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("de3c4728-974e-4ed9-b4d4-48ed952592ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("deeb1f29-a29f-4b2c-9329-6444f28159c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e06dc60f-b6b3-47e7-bef5-eb3d480aa1f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e095657b-e3fe-44dc-85bb-6417f393794c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e29e6827-12ea-4954-98c8-86b87bea289f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e40d71e6-f13c-4b2e-88b6-ff2198d1799a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e6276041-7dfc-42a3-bb74-16474b331481"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f3e092eb-5086-4888-8c3b-d0d66635ebef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f4600998-6b58-4538-ba53-ef6749c7c927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f7976caf-4906-4ccd-bc36-ec0cc3f0fb80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fc1459a2-9075-410a-a77f-63f3900e8347"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fedb33d5-7114-4724-851d-3a1f918364e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ffeee650-3745-4907-a1b8-e7b40e4185f4"));

            migrationBuilder.DropColumn(
                name: "LastModifyByID",
                table: "Parkings");

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerID",
                table: "Parkings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("3fcd037c-179c-47cf-8f57-4c13ffc30b42"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("9075e922-302e-4a58-b8f0-2e451cebf34a"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("92d8e7ba-b4fa-4eda-9e34-516515d67e09"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("9845faef-c914-42a3-afbf-b4743c8db698"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("c48539f0-c6b4-4b5a-829c-01759200ade0"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("fca8d662-5979-4a25-b31b-67f2fd499df9"), "xe 5 chỗ", null, null, "SUV5", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("0053995a-4531-4a83-b9d1-a1a42b0b4218"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$ESczTcLKcFQOQXLA5QQoxeH1/Fgw/rWAZGFRId2JpzqfaDHnI9P8C", false, new DateTime(2023, 2, 23, 23, 29, 56, 404, DateTimeKind.Local).AddTicks(398), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("04c00751-37ec-42fd-808f-4fde6c742f0f"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$5Br7VNlGR5tDLO3msFes3O.jyNSS8cqI8PnvBrf0zc3cvqRWAxcW.", false, new DateTime(2023, 2, 23, 23, 29, 56, 154, DateTimeKind.Local).AddTicks(9824), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("088d3cc6-6dc4-484a-9859-e491b5acd844"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$65Cj7COkMrqtKDVmOiwyquCmH3UN.WgnjL9fskR69qJErY5JDTvTq", false, new DateTime(2023, 2, 23, 23, 29, 54, 99, DateTimeKind.Local).AddTicks(1431), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("0ca28a8e-cf2c-4197-98b8-2e874a6126d7"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$iRRqPxspVdw0gU6wMr4OuePaduVXYd/OSafNn1ZN.HAbSlrwtUzBu", false, new DateTime(2023, 2, 23, 23, 29, 49, 646, DateTimeKind.Local).AddTicks(9854), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("0f5964d5-faf4-466d-aaf6-633d6015be73"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$RRlXLh0aredhHGGjXUYDpOsiN7yO34rD0fq/1qljkZQuAc91xM.cC", false, new DateTime(2023, 2, 23, 23, 29, 56, 613, DateTimeKind.Local).AddTicks(1093), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("10abdf9a-1281-425d-85c6-e4d145ff4e6e"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$aRtGFAlwm7nw37KIK8H20uUSBqb7TMG2Mw9OUJzIxoHA6mB9qAA5u", false, new DateTime(2023, 2, 23, 23, 29, 53, 860, DateTimeKind.Local).AddTicks(6890), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("10afa38c-a6d7-4d52-af48-425152d07f68"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$Pa0YEMlk50Mhe7J8HhilYeXIW4KeupYdNF1/cvriSxYTRw7JGfJq.", false, new DateTime(2023, 2, 23, 23, 29, 51, 380, DateTimeKind.Local).AddTicks(1587), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("112656e2-4554-4c42-bff4-14500766d5d2"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$cBYF2IGoMAm/7xaUTYm1muMgtEj0ENtt/bUO4nXl.JDFJvHJpP7Ou", false, new DateTime(2023, 2, 23, 23, 29, 56, 4, DateTimeKind.Local).AddTicks(2107), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("138e1060-cc0b-4851-877a-116033a0521e"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$nsHoqUN8GpEdGhR2Si5EjeahyMbn6MFF9XgtA9o84cvxqFF/XWvQS", false, new DateTime(2023, 2, 23, 23, 29, 54, 384, DateTimeKind.Local).AddTicks(9995), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("13f4d093-a11f-4d77-b27d-e85a97c1ef3a"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$lO5qb5LIMMmZqC15tv6dwemVwCRBcc1Ct0wDOSRIZUEznbNln/9VC", false, new DateTime(2023, 2, 23, 23, 29, 54, 706, DateTimeKind.Local).AddTicks(3082), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("1b6b46fe-1eb0-460a-bd58-53b41b1a3cd2"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$wDvwIhPSGsWVQ8JVLH5jHuLVlDxojDOXgKJbjWmIcidGC7VraODkK", false, new DateTime(2023, 2, 23, 23, 29, 51, 46, DateTimeKind.Local).AddTicks(8720), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("22ffe42d-fe8e-48d1-889f-84ed8f4c774d"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$sR/q/Hgm4wF19/rwX1KECOP40wbQsYn01yeYoJY9.3.aQXHSha44G", false, new DateTime(2023, 2, 23, 23, 29, 48, 729, DateTimeKind.Local).AddTicks(954), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("24232efd-a937-44b0-8c3f-82da669fc31c"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$cYO6tXXlDOQkoQO3U3r4QetTcIUvu2H3mRX9sNO5WRcwPHfnRiPPq", false, new DateTime(2023, 2, 23, 23, 29, 49, 198, DateTimeKind.Local).AddTicks(462), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("24614e9f-f7f8-4299-9030-ddc029b921f4"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$C8DqRRocqN3z4sUo5PwAUOf7U1u3K92z1ZNznxnkKlzgdtD3ZlRnO", false, new DateTime(2023, 2, 23, 23, 29, 57, 238, DateTimeKind.Local).AddTicks(2070), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("257a241f-b973-4fc3-a871-82bc5cb95b0c"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$bCqbpJ9a0Ohs201KIzFkweWCoGFKtV/DPMrOOOQOzsmC6nhteSXla", false, new DateTime(2023, 2, 23, 23, 29, 57, 38, DateTimeKind.Local).AddTicks(2914), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("2892b78e-72e8-4c19-95e3-691f824ae0d9"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$8cFzzzKUmv/tHjSMaol3ye7tj.2.OzeMkLwMPLZjtnQrJIcxhvNrG", false, new DateTime(2023, 2, 23, 23, 29, 53, 269, DateTimeKind.Local).AddTicks(4806), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("28c866c1-95d9-4c11-b06a-449bc7bc590b"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$BWDrrfv0FJygTk2vmWcMg.dqtj.01ollGK62znw6zSQB.uWoDw3Wm", false, new DateTime(2023, 2, 23, 23, 29, 49, 286, DateTimeKind.Local).AddTicks(4172), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("2d853d1a-49ba-42c9-9a08-548d65267eb4"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$gu2knec5UDG0LgH/3dwYeuOPXU6ILb/OcNx1UXTTPKx4rKh.sMBYm", false, new DateTime(2023, 2, 23, 23, 29, 53, 605, DateTimeKind.Local).AddTicks(3198), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("2d933ebf-46b4-41cd-95ff-2478db9378c4"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$7ASmntBmXA7vT.OhA1Oy9OobZCxLKt5HVSFXJ/TLw6gFeJTDdmPTa", false, new DateTime(2023, 2, 23, 23, 29, 48, 811, DateTimeKind.Local).AddTicks(342), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("3158eadc-0878-4077-9102-4b0a17b1da09"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$5csYosJGsvu9GNQp6TcpLOpn2JWpPLA18LsiVo0k/.P3Aq5lxZbxa", false, new DateTime(2023, 2, 23, 23, 29, 50, 78, DateTimeKind.Local).AddTicks(7569), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("350e3955-44b1-447c-a178-26c7707020ac"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$nkJd/PDVYDDRkyu2z.fbauUGcBXZoV3DwPORl4prVMHrNuDFg/LZ.", false, new DateTime(2023, 2, 23, 23, 29, 47, 212, DateTimeKind.Local).AddTicks(6432), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("3b17df90-e042-4276-8b16-7e9e0a359d89"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$4nWSMw2NSdRAii88TAI5i.pFMa91Peih66to0itNOwKtPqgXcIuca", false, new DateTime(2023, 2, 23, 23, 29, 50, 612, DateTimeKind.Local).AddTicks(2878), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("3f10fa23-6da5-49aa-b8bb-c4878317a016"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$xA/2fMm.wuJuOTQ1Koaa/eaYMvAzv4kIamzKp.KQI.DM9UqfsavM6", false, new DateTime(2023, 2, 23, 23, 29, 50, 172, DateTimeKind.Local).AddTicks(6030), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("41d65e31-5a50-4799-99f2-06e1ea812a7f"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$iPJ9cjcRBJkxclQch3r/p.XriMhqTiNIhuTTTcceHOtJPAb5zJwQa", false, new DateTime(2023, 2, 23, 23, 29, 49, 10, DateTimeKind.Local).AddTicks(634), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("45c37340-73b0-42d4-83f0-29ff3fb5c34d"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$mICUCpGlf/OyHauSzim5e.wzwN8kz1A34AZN69q2VDacjN0I8DmAO", false, new DateTime(2023, 2, 23, 23, 29, 55, 45, DateTimeKind.Local).AddTicks(752), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("469f2f12-9338-4107-95d9-ecbffc3d89a6"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$FhFc4fTVWJH63WPxhSgOkuyLrdrL7J8/J8r0cDg3tjW21gl48nhkS", false, new DateTime(2023, 2, 23, 23, 29, 54, 550, DateTimeKind.Local).AddTicks(5110), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("48322c21-aa69-42bb-bed8-0e0058aecafa"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$QGrYANBltGDFhD8DURorfu8fQS/w4v3BeGPJMKyHL0UwuDoOps1gq", false, new DateTime(2023, 2, 23, 23, 29, 52, 350, DateTimeKind.Local).AddTicks(2131), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("4d642e5f-c4e1-4204-b39f-b31920f62563"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$.gl19Zg63cTZ8W4Srucp6urWk/7zdFMFVYptpFh0bia2Fs3CjD6rW", false, new DateTime(2023, 2, 23, 23, 29, 49, 370, DateTimeKind.Local).AddTicks(3689), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("50ce66d9-d357-4710-8a55-cdc388e6a9cc"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$/eAiCZB2et.id0PVVWVpSuVDlbSfEg4FU2CbbDwKSvs5MCHAgZGCK", false, new DateTime(2023, 2, 23, 23, 29, 53, 78, DateTimeKind.Local).AddTicks(2522), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("517eff13-c427-4598-a4ac-c1a306c3be7c"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$AQKgCKb62L1xTW3NwjbgUOYE4YoyDst74zo.OVlOpjZCpQgi7YHF.", false, new DateTime(2023, 2, 23, 23, 29, 47, 721, DateTimeKind.Local).AddTicks(71), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("520b366f-4be7-4fb7-9c25-d49482fdc208"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$DCk9SKqkSVn/OgWVhFTwhetHz1EGDc.vpGifaWgJE.Nb6JG7OKFRi", false, new DateTime(2023, 2, 23, 23, 29, 50, 877, DateTimeKind.Local).AddTicks(6421), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("5895ef33-a633-435b-b96d-07eebf9b031f"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$UoP3b3hskneNargZW2tGMOFkzElV/QQf.eZuYhHgz3XG7xNNSEJCe", false, new DateTime(2023, 2, 23, 23, 29, 51, 294, DateTimeKind.Local).AddTicks(9304), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("5c6301c1-bd64-488c-a932-2a046c57c4f4"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$pPHn.QE7agFqOcAwDwoKpe8dsMn9UTGyCs68Vb.my8P3kQu9rKyUy", false, new DateTime(2023, 2, 23, 23, 29, 55, 760, DateTimeKind.Local).AddTicks(2173), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("5eb0bd99-9457-4525-a435-417aea075e05"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$koDRctsNjqgn4rgpuG3jm.aZ2uK/Js58jfT0hd.s9RTCCpzziC6ZG", false, new DateTime(2023, 2, 23, 23, 29, 53, 434, DateTimeKind.Local).AddTicks(4241), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("5f237504-14c9-49c8-a49a-61593b1d2205"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$1Ar3lfiAa4U5.Z9a/M5Rde9OBJcKLbihq6JUBuNZvD27Wa/4qw0Su", false, new DateTime(2023, 2, 23, 23, 29, 50, 782, DateTimeKind.Local).AddTicks(8568), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("5f42a76a-e554-4b4e-b9ab-982a3ed59f57"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$vdIJmJux9AipUBqAvSB4KO6IGXJbptw3oGukWxq/p9xc3rbRWNG8S", false, new DateTime(2023, 2, 23, 23, 29, 47, 937, DateTimeKind.Local).AddTicks(506), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("604c330c-18fa-498c-9802-9f9333f1f8e9"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$GU6D03ctGtKDkFJcSm6kZujvGjKDaBFK6UWTgYZSsDJmmUBDZWQzm", false, new DateTime(2023, 2, 23, 23, 29, 52, 626, DateTimeKind.Local).AddTicks(3326), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("61c534ed-9624-4a50-aeae-bcd7d68082d5"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$Sgui5mA/v..LEal3H1qSO.q2GVt3CyhAAhOrxtJbNfZ9LnaGQBz2e", false, new DateTime(2023, 2, 23, 23, 29, 52, 883, DateTimeKind.Local).AddTicks(2397), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("62088e61-14be-45c8-bb20-ff2dd9e0fa42"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$F9O6zlEHIKtlsAqyCQZxQu.tAAks27mE3tKo.7Es9a0tqEwhBWmO2", false, new DateTime(2023, 2, 23, 23, 29, 55, 213, DateTimeKind.Local).AddTicks(5203), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("6397a509-e7ad-40da-a264-e887b8f6e74b"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$nH0ipFCpedMBCTvx2rS50u.e6S5.6E.2ElBzaNVzoG5.h7wUy2SEO", false, new DateTime(2023, 2, 23, 23, 29, 50, 344, DateTimeKind.Local).AddTicks(2664), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("69cdc5c5-b49d-44cd-a9e5-a224f4944ecd"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$am.VcH5kjPG25cV5LoMxKu4Fql09YnuLzJ7HRGgWI6ibNPD9QygWm", false, new DateTime(2023, 2, 23, 23, 29, 50, 693, DateTimeKind.Local).AddTicks(1389), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("6badbfc0-b901-4e54-8e3d-dc9e2e9ca093"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$Ui5pV4H5239ZRmFe9mEKkOgoEwBusuZdEew17N0IS7CR4UTQht2TO", false, new DateTime(2023, 2, 23, 23, 29, 56, 309, DateTimeKind.Local).AddTicks(2352), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("6c375a03-4a79-4bdd-96aa-f088017618b3"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$xgy8mBkcP6IrHlc7AiBxX.wz9rQ668tAh7ocfnqsE1r8jMzAKvU06", false, new DateTime(2023, 2, 23, 23, 29, 47, 474, DateTimeKind.Local).AddTicks(5745), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("6dd02af6-beec-41f1-83d6-d9e2cd412d52"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$LBmuGzBrV/xpqbUCppbuIekJ7pQmAwSgeyXrFSqQ.V.r1zclO6ckC", false, new DateTime(2023, 2, 23, 23, 29, 53, 179, DateTimeKind.Local).AddTicks(7971), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("6e576c2a-3860-44ad-a531-3d723b6b9463"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$yZ6X0GiQAGEW0elfSs62NeKQoq6OyaNry8lMLNqviCvnXa455qcw2", false, new DateTime(2023, 2, 23, 23, 29, 50, 528, DateTimeKind.Local).AddTicks(6557), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("6f850fdd-6a91-4228-a285-d24f14987607"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$3J5/Js9z0BXg3tfRdqAyg.DenkTqSyjVkA13gPBkCPICan2MrXKKK", false, new DateTime(2023, 2, 23, 23, 29, 47, 833, DateTimeKind.Local).AddTicks(6026), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("704f5c3b-3b14-4069-a333-844dd610e1f6"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$Eh1dyFO9WBpA3CPQpYvU7ee2X67yfabCcL1PUvyBcd.gEFmSv4Ycy", false, new DateTime(2023, 2, 23, 23, 29, 54, 787, DateTimeKind.Local).AddTicks(5958), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("77ca87db-89c4-4c91-b243-ff606a8bb972"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$sjDViwVkMfexz5g7o9xzf.jnTLI/.BvfcqTJUDkaZNLCygjJknY9K", false, new DateTime(2023, 2, 23, 23, 29, 55, 670, DateTimeKind.Local).AddTicks(4435), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("787c0377-e2b0-4400-847d-d0207de83f5a"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$mcxgiygzxC.XoyFzB01/fuGvupHeH4BAJBDdBYhtMgiH9eUkmbGK.", false, new DateTime(2023, 2, 23, 23, 29, 48, 318, DateTimeKind.Local).AddTicks(7181), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("78f97b95-cc59-44b6-af1b-cef1adca0eeb"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$FPOky3GOOtF1xsezvCpG3uBq6BiNVxGhToiclwW/DxP9XUv8VM8iu", false, new DateTime(2023, 2, 23, 23, 29, 55, 382, DateTimeKind.Local).AddTicks(9873), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("800935df-eddf-45f4-85bf-16e45669e639"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$r6.VJuWvFOoM2xKbITqQQOiW02oBP4OuRxh3kL/Fcxmi8iZ9oe8S6", false, new DateTime(2023, 2, 23, 23, 29, 51, 126, DateTimeKind.Local).AddTicks(7533), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("836285b5-6c9f-49d8-8dad-6b110c1f036e"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$znm1GiQYnk/TEIBTfHpe6eI/3to6n1USorKgMJlC7RNU.r.NH9usm", false, new DateTime(2023, 2, 23, 23, 29, 51, 662, DateTimeKind.Local).AddTicks(5511), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("842b7c82-3b20-4a29-adf1-3203168364c9"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$Og7eRKgDRp4lNfnDKaa.Uerkqs03ypJoehRENqbu7rknUiFP/8anK", false, new DateTime(2023, 2, 23, 23, 29, 54, 875, DateTimeKind.Local).AddTicks(4610), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("862f0ef0-e73b-4fc0-a899-954893169d89"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$0gaUa7Ay.UibZ4h/D4X5t.heJmyS9E/XL/bq8Ykw9vcuxv64uW5Yi", false, new DateTime(2023, 2, 23, 23, 29, 51, 208, DateTimeKind.Local).AddTicks(9874), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("86930a7c-67a9-4410-b9de-f66c127f0009"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$RYz.7oUf/0JNwJfv8gtt8.Yv0tk/dlHiTuKqt4.WGImuJuTEgse9a", false, new DateTime(2023, 2, 23, 23, 29, 51, 461, DateTimeKind.Local).AddTicks(8720), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("8975e93d-0265-4ef4-8c64-d8b3f392a213"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$nZ8qWUcp1JajdGeXF1Cvv.v3UYd3TYh91bYUqKrd/XOo3Nh1bYup6", false, new DateTime(2023, 2, 23, 23, 29, 52, 29, DateTimeKind.Local).AddTicks(878), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("8b4eb8d3-e154-441f-a6c8-1a84f800730b"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$9lW9.KG94ik.hJHPxveOy.ftK7VbpnOPa96tvwwxBHnRJYIgqpAje", false, new DateTime(2023, 2, 23, 23, 29, 48, 451, DateTimeKind.Local).AddTicks(760), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("8bb7b382-3e3e-460c-ab13-9414e651987f"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$vAgwbFCRY9FuidXQUtbVDuNU2MgdejDkVb7yOwSRr2D6jRHiyvUay", false, new DateTime(2023, 2, 23, 23, 29, 51, 555, DateTimeKind.Local).AddTicks(1861), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("8bc21216-2fbd-4ead-82ec-ad19541f7c3f"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$Fguorxrwbu4y.hOqYSRqP.0zzQmt.TqX9U0nJiPvCXCQW8kFN4X3i", false, new DateTime(2023, 2, 23, 23, 29, 49, 914, DateTimeKind.Local).AddTicks(9750), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("8e44ec20-0289-439d-9ced-93509bcb7e4f"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$RmtyeBUG.EvJNhsFKZ3uPurLakpcTlj5DJ5Q2/T3kdGxwjmxGNLOq", false, new DateTime(2023, 2, 23, 23, 29, 52, 435, DateTimeKind.Local).AddTicks(5103), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("8fea0b75-f161-43cb-825d-b81402be2df4"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$uF010qA7fVBa.dsp0jrYYeQ4xuMAx2eQvl5Y9FCoGrvVRDFVMDeYO", false, new DateTime(2023, 2, 23, 23, 29, 52, 259, DateTimeKind.Local).AddTicks(3799), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("92ea49bf-657d-4a7a-9358-41aae782e1c4"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$LPwgEnmsNb.lrxA0HbrI6enGmZkPk5rn1jzAhohiESO9TnezovNTa", false, new DateTime(2023, 2, 23, 23, 29, 52, 801, DateTimeKind.Local).AddTicks(7071), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("9407d351-29dc-49df-bbd9-92bdc2e34616"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$cZM.NPBKSfFsIegBXQsFKOAhOvdr1/nQ6YhggLcB79xR/sqzr5T0i", false, new DateTime(2023, 2, 23, 23, 29, 56, 927, DateTimeKind.Local).AddTicks(6607), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("953d68f0-03fb-4e01-831b-2483e26e49f4"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$UgO8UXhCqTeu0tXJPIUzY.SlWJcHMR5I9ovZ5/K7GQlBL7r2nILFy", false, new DateTime(2023, 2, 23, 23, 29, 48, 553, DateTimeKind.Local).AddTicks(9563), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("9717e65c-b51f-438f-afe2-da2766b9ef21"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$qxqNQROiuMMGrQ7PJwrrfu3GGHkaR4B3SVeaYDsGjuRs/i8S2ZqTq", false, new DateTime(2023, 2, 23, 23, 29, 54, 15, DateTimeKind.Local).AddTicks(7488), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("982511e5-2b8f-4c5f-a39f-c9a8d1c7766a"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$cU6dNU60ro8GeT7XmxJjsequj4u8Nf6SMacf06GhY97.i9mPWCCh2", false, new DateTime(2023, 2, 23, 23, 29, 52, 520, DateTimeKind.Local).AddTicks(5660), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("9a022e29-bb45-407c-8a55-03b127d3a44f"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$QM9S4N0thryKkAq1FqcI5.M/pZd0W0GUZTqdYsoerqNlcupUGjLt.", false, new DateTime(2023, 2, 23, 23, 29, 56, 228, DateTimeKind.Local).AddTicks(8891), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("9d9d86a7-c39c-4036-86d3-1a0b807e09bc"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$RGQ3wGrLe.fEgrDtrBXDwuRXfkA5IyfjO9p7MpcHeH7D3eh81PzgO", false, new DateTime(2023, 2, 23, 23, 29, 56, 713, DateTimeKind.Local).AddTicks(3150), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("a2a9f339-a22c-41f0-bf40-af353477d145"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$FdPQpCmt4rxk6/fXsn7mGO/cyWoy8OeY56lkCBNVR22z9e081eI1m", false, new DateTime(2023, 2, 23, 23, 29, 55, 845, DateTimeKind.Local).AddTicks(2408), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("a447bf7e-3de4-44b4-b43a-d6c56a035895"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$knmL.8sUuM45cgrqLytbq.MSRv5AA2ccXDvyLa58IpO/V.1shHPSq", false, new DateTime(2023, 2, 23, 23, 29, 49, 738, DateTimeKind.Local).AddTicks(3813), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("a52c0510-a7b3-4bcc-887d-951dfd3bb52e"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$nEIyTXNzWozeStB53kEcqe.TyFmHl1GeGKCoVVNlLz12yTu2wnjv2", false, new DateTime(2023, 2, 23, 23, 29, 52, 128, DateTimeKind.Local).AddTicks(1819), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("a5ac913e-a4bd-4b58-b0a0-29cf7c0cc851"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$j.2fY4bfher/KeY6S9mh5e0LbmGB9oBigkNjbN9IsQkpBIuVNW1aK", false, new DateTime(2023, 2, 23, 23, 29, 57, 350, DateTimeKind.Local).AddTicks(8338), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("a7e230f0-8763-4b54-a4a1-0695ef78aa85"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$TQQWpiYAmFRpkzEWn0w.g.VEnZIJY/wvs7pAgQ0ExePKYqSQZxLje", false, new DateTime(2023, 2, 23, 23, 29, 55, 300, DateTimeKind.Local).AddTicks(5855), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("a93bc847-b3db-46e9-ab1d-51fd88a031dd"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$4tK7oPytDng/YUG3ccXC4OLN2J8ke4noaqi2f0eFxR08Q.iKBvzuq", false, new DateTime(2023, 2, 23, 23, 29, 56, 806, DateTimeKind.Local).AddTicks(5432), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("ab5d6621-b78e-4c11-8572-5fb46f35163e"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$1xzES.wyEf7GfN9r4u3twuK7uyHK1ifrodGHrp5xTcgzyYOzrK4DO", false, new DateTime(2023, 2, 23, 23, 29, 49, 454, DateTimeKind.Local).AddTicks(4481), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("abc21727-7556-4fbb-81b5-1ce60e5aff2d"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$fT60NPkOY0nGumZaDiYjfeiQLN9VG1N4MXcBpYmL3JTLbXd6LqKr2", false, new DateTime(2023, 2, 23, 23, 29, 49, 829, DateTimeKind.Local).AddTicks(1470), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("addf31fe-4be4-4dd1-9e28-968a6a58a132"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$guABqawYI4MEpMMhdCKkPOHaO.gtlZDPxK0kNVD5C7M2GqHK6CejS", false, new DateTime(2023, 2, 23, 23, 29, 57, 132, DateTimeKind.Local).AddTicks(8903), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("af2f0a89-4d91-4358-991e-2c2802cbcd3e"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$tMNXvwrRBSY./YFJR0iOtu2IzEANoxM/HsPLvIkENjhnBavxEuDbm", false, new DateTime(2023, 2, 23, 23, 29, 47, 337, DateTimeKind.Local).AddTicks(2453), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("b1dba65d-2d09-4478-b68b-a657dd15a7a5"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$4UEuvHIZFmNFkols5S7ahuFaDn5Y3Oi3AiXDaYr.Xy6xkkwJ15j/m", false, new DateTime(2023, 2, 23, 23, 29, 54, 469, DateTimeKind.Local).AddTicks(8312), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("b46f1c7d-5952-41fb-a400-ff45eb0da045"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$jH2zR/gegtgp/7JHHwGdZekxtoRKX3V.rOeWek/aLy/OvzLTEQToS", false, new DateTime(2023, 2, 23, 23, 29, 54, 961, DateTimeKind.Local).AddTicks(8663), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("b845fca6-d7f0-461c-9191-aef7f37940c4"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$BWyRPWGsYgIVVVravZ8lheAWPvHcA31Frho0TxmdgMMwkwIRXRV92", false, new DateTime(2023, 2, 23, 23, 29, 47, 583, DateTimeKind.Local).AddTicks(6774), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("bba035dd-e93b-47b7-8f07-acbda0282e54"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$C0OmqKZvO86C2nVOcTkEpuxMo6R5EslBMxruDClwlwNvEaXeNIYx.", false, new DateTime(2023, 2, 23, 23, 29, 50, 261, DateTimeKind.Local).AddTicks(154), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("bcc69bd7-032f-4d81-91e7-9efcbd788498"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$2/gyjcfnQNNJZl5vyBitFuvYl6QNwAdm2GwkdwfZ2oB8TSAELCqQC", false, new DateTime(2023, 2, 23, 23, 29, 53, 938, DateTimeKind.Local).AddTicks(6871), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("bdae8e9b-c944-4d04-a0b3-dd0d7bb15658"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$y/5hkZu1qomDlE1qye4lJeUbjd5ETQDf3aLddPo5UYK8eVT3fmV/C", false, new DateTime(2023, 2, 23, 23, 29, 54, 629, DateTimeKind.Local).AddTicks(5386), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("bf8182cc-fb89-4a99-bc71-32c2127ded0f"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$s0991W8uGotJFG6fuiiZ5ud/1GO5ngWFnsJtcdrGOepZm/ABo19sS", false, new DateTime(2023, 2, 23, 23, 29, 51, 757, DateTimeKind.Local).AddTicks(3893), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("c3eac257-d769-4308-8cf4-58c3ee16d75a"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$JogG9sXHVkaeEUd3Wm9xuu6XZP1l5NAnahHvElK0GTeCR9x66SV1y", false, new DateTime(2023, 2, 23, 23, 29, 55, 570, DateTimeKind.Local).AddTicks(1080), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("c6cea83b-df90-476a-af88-9138c0c000f0"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$wxpZFb1UlwlYYoWkoiihHOZYWk21FmPF4homdXxDIQQOtvHiKDHfa", false, new DateTime(2023, 2, 23, 23, 29, 48, 44, DateTimeKind.Local).AddTicks(3308), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("c6e7883f-8429-4117-a530-47cc1d84f909"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$pWhyuIXGw/Q/BcTvENCF3eZf4PfrKyEUiDGu9xvohJqXGVpDYyCEK", false, new DateTime(2023, 2, 23, 23, 29, 54, 199, DateTimeKind.Local).AddTicks(3759), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("c7ee2d6d-da87-49d5-8607-f46628c72c9e"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$m5QhePE56v0l/5V6P7qIF.ILL3fGFA6bCyqa3mMqLeo1216Mxnhte", false, new DateTime(2023, 2, 23, 23, 29, 49, 107, DateTimeKind.Local).AddTicks(3376), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("c83edfaa-5ef8-4673-8dff-2398c9adc011"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$kzEdKW8SFD6dGCU3IfwNqOP.d8RxRyBdQYOZ/rolbyyZQYINUSNOm", false, new DateTime(2023, 2, 23, 23, 29, 53, 694, DateTimeKind.Local).AddTicks(3903), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("caa340c6-3746-4ca4-8e67-066eff4d48ce"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$WJ6TrkPwAFVkIkTwzi4QNOITZHLYbpQ9jL6SkCp2y/ivPTYfsuOsS", false, new DateTime(2023, 2, 23, 23, 29, 48, 903, DateTimeKind.Local).AddTicks(7495), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("d0e70ea0-57cc-40ce-aea7-e189c31d794b"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$q7pSW3d82.cZDAi1gSUxbOkEsghtxbfyc/qGXSXhSbOPLVyBofH.W", false, new DateTime(2023, 2, 23, 23, 29, 53, 353, DateTimeKind.Local).AddTicks(8043), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("d3033ab2-bf25-4cb9-8491-1a04330899ba"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$I/7/wOdZ2Wy4G5zQXTgPhuMjFlN6gPAvXT0Fp.MvOg0MLFukwFoRi", false, new DateTime(2023, 2, 23, 23, 29, 56, 494, DateTimeKind.Local).AddTicks(7228), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("d60162a7-f8ab-4572-9675-eab501343adf"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$HEbVhqViilDizzLTvwjT8Ofdg.c/gnOcsa0eT3iV5tJhDlIS3Q57G", false, new DateTime(2023, 2, 23, 23, 29, 56, 80, DateTimeKind.Local).AddTicks(438), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("d60aa6e0-a56f-4f57-adac-0de68f5ba5bb"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$72nLRm4K4WAgGfw4RaM/HOB0DbHnnxODxUMRmD/lp8tYCv7PUgXQ2", false, new DateTime(2023, 2, 23, 23, 29, 54, 290, DateTimeKind.Local).AddTicks(8814), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("d67a9c2f-805d-4b63-a4e0-b3b8bb0ddc93"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$APKFNYSauzeqaKSXjIXDD.gRkcqnX7CPxPrJCs4Y/Ix84Vz.XmIO2", false, new DateTime(2023, 2, 23, 23, 29, 55, 466, DateTimeKind.Local).AddTicks(2571), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("d90b4a36-725d-4fbd-a521-ffdbcb123c5d"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$x03KUX0lfPjJNCXq6nD3UuXfVqkjUKdFfC/ksJFnpsqpgIGC/gWzC", false, new DateTime(2023, 2, 23, 23, 29, 50, 963, DateTimeKind.Local).AddTicks(9242), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("db3202fb-50ea-43fb-a62f-02c5e67f760f"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$EnTLpBRuPOh/xhjfONRdqedF0YkuZxlzyQfJvQfH6PKBEMd2vXRiW", false, new DateTime(2023, 2, 23, 23, 29, 55, 925, DateTimeKind.Local).AddTicks(8925), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("dc99594f-9118-44e6-84b8-9a6a334a5f0e"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$0Qr/CNIfWlpexSsgWDXJRuNbUya3qv0rBlHZX0QauoqQ4naeg8u6q", false, new DateTime(2023, 2, 23, 23, 29, 52, 963, DateTimeKind.Local).AddTicks(2491), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("dd703226-b368-448b-b5c2-e967f0f717da"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$xDofLRNETt5d2xtfW/3H.Oxl5rBqpg7vTBop3tvCsgD79y3f6elnm", false, new DateTime(2023, 2, 23, 23, 29, 51, 944, DateTimeKind.Local).AddTicks(633), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("dfb2772d-e03b-410a-940a-9a3d75d2cebd"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$yxxQ5tomdnBZNITcUtUcEOAFluGrlxlFjxVf02NXnmneh0.NzJFle", false, new DateTime(2023, 2, 23, 23, 29, 53, 779, DateTimeKind.Local).AddTicks(1942), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("e57ab80e-f283-4661-860a-0d88c6eb7c97"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$QvL1ta92qPkVHmct/oxbw.O0Tf1lu6AmCZuqFIu4QnaElndL7yzCu", false, new DateTime(2023, 2, 23, 23, 29, 49, 997, DateTimeKind.Local).AddTicks(2257), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("e6897f86-4d22-4adb-b042-e4613d41cd21"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$/C/D0OdsmZuX4G5XjBpXLu0Rf8mvrid24qfW1P7MOvBQvBD3Zwt6O", false, new DateTime(2023, 2, 23, 23, 29, 53, 515, DateTimeKind.Local).AddTicks(9917), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("e81c3112-2671-482a-9415-b5f426220378"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$Z4fSo3.a/dl0YJQw44IFK.ZEYSIxt8XUdg2yKGxQMXBQIxu/kl.lC", false, new DateTime(2023, 2, 23, 23, 29, 48, 644, DateTimeKind.Local).AddTicks(66), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("eaadfd8d-b95a-4c11-a768-c6f439246c33"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$et9lRcvWR7ybl5.1g1T4Seyp8bIxK/PiOiEZu5kuaN6ts5TeJr3Je", false, new DateTime(2023, 2, 23, 23, 29, 48, 232, DateTimeKind.Local).AddTicks(1430), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("ed51482b-2e31-4b4a-9fdf-91f168be1c42"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$k6CJ9kvNjG5XmJPyLwVVTuBssqTKg/2fDToMSiomsPDmrCAQH7cve", false, new DateTime(2023, 2, 23, 23, 29, 50, 434, DateTimeKind.Local).AddTicks(9543), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("ed84b18a-e540-48c4-b473-62dcb9168510"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$/4VPrxF5Fajfb7W0oaarleW5haLOuekTdJ0g2KaoVasFgmmGJd0vu", false, new DateTime(2023, 2, 23, 23, 29, 55, 126, DateTimeKind.Local).AddTicks(8046), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("edbf4c7d-9f04-4617-a4e1-29b148043da2"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$LMTtSARo2WyMkwr/03.7tOQTI1cX/QIBRqxiQwjRNJagBte9QEVJq", false, new DateTime(2023, 2, 23, 23, 29, 51, 852, DateTimeKind.Local).AddTicks(5609), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("f004693b-00f4-49e2-830a-6d9ef9f7b50e"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$uz6FTguhcq9oGhh9sAfRjeHQ74wK1xyVhlPVTk7tohXQ1nlhYOP5K", false, new DateTime(2023, 2, 23, 23, 29, 52, 716, DateTimeKind.Local).AddTicks(5370), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("f8e2b185-4153-4d3b-b5f4-9b4144c1fa58"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$G4IiBupTp2eXwcF46T/QUOGPYBMUK8wZkuh1J6rTFAczsWsHylw.a", false, new DateTime(2023, 2, 23, 23, 29, 47, 97, DateTimeKind.Local).AddTicks(780), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("fa7742b7-59d0-4cd1-9966-2891b0ae903b"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$EiK/pZzwjoNUr0PnZq1qYu4ljWcBfEJRiyq9IFHeaslCSSiHBzNPS", false, new DateTime(2023, 2, 23, 23, 29, 49, 556, DateTimeKind.Local).AddTicks(5421), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("fe3770e9-fc5f-4219-9f59-3a2faa0ef0f1"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$S0yl14EQrO2tjdQ67adNrehX9/G.LsPdxWsITuP1sWE9ewOs.bjom", false, new DateTime(2023, 2, 23, 23, 29, 48, 141, DateTimeKind.Local).AddTicks(1822), "Guillet", null, null, "0134210264", 2, "fguillet8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_OwnerID",
                table: "Parkings",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Parkings_Users_OwnerID",
                table: "Parkings",
                column: "OwnerID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parkings_Users_OwnerID",
                table: "Parkings");

            migrationBuilder.DropIndex(
                name: "IX_Parkings_OwnerID",
                table: "Parkings");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("3fcd037c-179c-47cf-8f57-4c13ffc30b42"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("9075e922-302e-4a58-b8f0-2e451cebf34a"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("92d8e7ba-b4fa-4eda-9e34-516515d67e09"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("9845faef-c914-42a3-afbf-b4743c8db698"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("c48539f0-c6b4-4b5a-829c-01759200ade0"));

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "ID",
                keyValue: new Guid("fca8d662-5979-4a25-b31b-67f2fd499df9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0053995a-4531-4a83-b9d1-a1a42b0b4218"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("04c00751-37ec-42fd-808f-4fde6c742f0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("088d3cc6-6dc4-484a-9859-e491b5acd844"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0ca28a8e-cf2c-4197-98b8-2e874a6126d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0f5964d5-faf4-466d-aaf6-633d6015be73"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("10abdf9a-1281-425d-85c6-e4d145ff4e6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("10afa38c-a6d7-4d52-af48-425152d07f68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("112656e2-4554-4c42-bff4-14500766d5d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("138e1060-cc0b-4851-877a-116033a0521e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("13f4d093-a11f-4d77-b27d-e85a97c1ef3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b6b46fe-1eb0-460a-bd58-53b41b1a3cd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("22ffe42d-fe8e-48d1-889f-84ed8f4c774d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("24232efd-a937-44b0-8c3f-82da669fc31c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("24614e9f-f7f8-4299-9030-ddc029b921f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("257a241f-b973-4fc3-a871-82bc5cb95b0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2892b78e-72e8-4c19-95e3-691f824ae0d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("28c866c1-95d9-4c11-b06a-449bc7bc590b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2d853d1a-49ba-42c9-9a08-548d65267eb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2d933ebf-46b4-41cd-95ff-2478db9378c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3158eadc-0878-4077-9102-4b0a17b1da09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("350e3955-44b1-447c-a178-26c7707020ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3b17df90-e042-4276-8b16-7e9e0a359d89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3f10fa23-6da5-49aa-b8bb-c4878317a016"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("41d65e31-5a50-4799-99f2-06e1ea812a7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("45c37340-73b0-42d4-83f0-29ff3fb5c34d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("469f2f12-9338-4107-95d9-ecbffc3d89a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("48322c21-aa69-42bb-bed8-0e0058aecafa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4d642e5f-c4e1-4204-b39f-b31920f62563"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("50ce66d9-d357-4710-8a55-cdc388e6a9cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("517eff13-c427-4598-a4ac-c1a306c3be7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("520b366f-4be7-4fb7-9c25-d49482fdc208"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5895ef33-a633-435b-b96d-07eebf9b031f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5c6301c1-bd64-488c-a932-2a046c57c4f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5eb0bd99-9457-4525-a435-417aea075e05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5f237504-14c9-49c8-a49a-61593b1d2205"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5f42a76a-e554-4b4e-b9ab-982a3ed59f57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("604c330c-18fa-498c-9802-9f9333f1f8e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("61c534ed-9624-4a50-aeae-bcd7d68082d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62088e61-14be-45c8-bb20-ff2dd9e0fa42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6397a509-e7ad-40da-a264-e887b8f6e74b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("69cdc5c5-b49d-44cd-a9e5-a224f4944ecd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6badbfc0-b901-4e54-8e3d-dc9e2e9ca093"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6c375a03-4a79-4bdd-96aa-f088017618b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6dd02af6-beec-41f1-83d6-d9e2cd412d52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6e576c2a-3860-44ad-a531-3d723b6b9463"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f850fdd-6a91-4228-a285-d24f14987607"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("704f5c3b-3b14-4069-a333-844dd610e1f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("77ca87db-89c4-4c91-b243-ff606a8bb972"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("787c0377-e2b0-4400-847d-d0207de83f5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("78f97b95-cc59-44b6-af1b-cef1adca0eeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("800935df-eddf-45f4-85bf-16e45669e639"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("836285b5-6c9f-49d8-8dad-6b110c1f036e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("842b7c82-3b20-4a29-adf1-3203168364c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("862f0ef0-e73b-4fc0-a899-954893169d89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("86930a7c-67a9-4410-b9de-f66c127f0009"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8975e93d-0265-4ef4-8c64-d8b3f392a213"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8b4eb8d3-e154-441f-a6c8-1a84f800730b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8bb7b382-3e3e-460c-ab13-9414e651987f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8bc21216-2fbd-4ead-82ec-ad19541f7c3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8e44ec20-0289-439d-9ced-93509bcb7e4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8fea0b75-f161-43cb-825d-b81402be2df4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("92ea49bf-657d-4a7a-9358-41aae782e1c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9407d351-29dc-49df-bbd9-92bdc2e34616"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("953d68f0-03fb-4e01-831b-2483e26e49f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9717e65c-b51f-438f-afe2-da2766b9ef21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("982511e5-2b8f-4c5f-a39f-c9a8d1c7766a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9a022e29-bb45-407c-8a55-03b127d3a44f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9d9d86a7-c39c-4036-86d3-1a0b807e09bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a2a9f339-a22c-41f0-bf40-af353477d145"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a447bf7e-3de4-44b4-b43a-d6c56a035895"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a52c0510-a7b3-4bcc-887d-951dfd3bb52e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a5ac913e-a4bd-4b58-b0a0-29cf7c0cc851"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a7e230f0-8763-4b54-a4a1-0695ef78aa85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a93bc847-b3db-46e9-ab1d-51fd88a031dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab5d6621-b78e-4c11-8572-5fb46f35163e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("abc21727-7556-4fbb-81b5-1ce60e5aff2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("addf31fe-4be4-4dd1-9e28-968a6a58a132"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("af2f0a89-4d91-4358-991e-2c2802cbcd3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b1dba65d-2d09-4478-b68b-a657dd15a7a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b46f1c7d-5952-41fb-a400-ff45eb0da045"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b845fca6-d7f0-461c-9191-aef7f37940c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bba035dd-e93b-47b7-8f07-acbda0282e54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bcc69bd7-032f-4d81-91e7-9efcbd788498"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bdae8e9b-c944-4d04-a0b3-dd0d7bb15658"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bf8182cc-fb89-4a99-bc71-32c2127ded0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c3eac257-d769-4308-8cf4-58c3ee16d75a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c6cea83b-df90-476a-af88-9138c0c000f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c6e7883f-8429-4117-a530-47cc1d84f909"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7ee2d6d-da87-49d5-8607-f46628c72c9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c83edfaa-5ef8-4673-8dff-2398c9adc011"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("caa340c6-3746-4ca4-8e67-066eff4d48ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d0e70ea0-57cc-40ce-aea7-e189c31d794b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d3033ab2-bf25-4cb9-8491-1a04330899ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d60162a7-f8ab-4572-9675-eab501343adf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d60aa6e0-a56f-4f57-adac-0de68f5ba5bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d67a9c2f-805d-4b63-a4e0-b3b8bb0ddc93"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d90b4a36-725d-4fbd-a521-ffdbcb123c5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("db3202fb-50ea-43fb-a62f-02c5e67f760f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dc99594f-9118-44e6-84b8-9a6a334a5f0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dd703226-b368-448b-b5c2-e967f0f717da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dfb2772d-e03b-410a-940a-9a3d75d2cebd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e57ab80e-f283-4661-860a-0d88c6eb7c97"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e6897f86-4d22-4adb-b042-e4613d41cd21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e81c3112-2671-482a-9415-b5f426220378"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eaadfd8d-b95a-4c11-a768-c6f439246c33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ed51482b-2e31-4b4a-9fdf-91f168be1c42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ed84b18a-e540-48c4-b473-62dcb9168510"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("edbf4c7d-9f04-4617-a4e1-29b148043da2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f004693b-00f4-49e2-830a-6d9ef9f7b50e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f8e2b185-4153-4d3b-b5f4-9b4144c1fa58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fa7742b7-59d0-4cd1-9966-2891b0ae903b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fe3770e9-fc5f-4219-9f59-3a2faa0ef0f1"));

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Parkings");

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifyByID",
                table: "Parkings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("07c0abb7-c3ee-456c-bab0-c24880632164"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("0c01bd21-4843-4825-afaf-8ed2cd985094"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("35b0c816-7e7e-4482-b42b-b19b43b05fc1"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("368664b5-42ec-42e9-9ec5-44f8d9339dde"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("586698cc-7e14-44f3-8b88-c0de5d42baa5"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("d236d2ac-eb0b-47b2-bd2f-1a338918771d"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("03117ef0-fc63-46df-8b92-4deaf2473b59"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$eTrfTCDVZZDqr0IVBouM..TG1pb.7qhbxpU7QChauMYF.qxGRNTvu", false, new DateTime(2023, 2, 23, 21, 38, 2, 17, DateTimeKind.Local).AddTicks(5426), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("0743bd5c-12b8-4873-ad50-48c0b28a7001"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$hgrdgm4DSTvHMMNrbUwIx.0PU1XZaR4UR6u7ZGvoO84C3ETTNLGfi", false, new DateTime(2023, 2, 23, 21, 38, 1, 715, DateTimeKind.Local).AddTicks(8035), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("08717f46-54ff-47aa-9b63-173de16e9f83"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$jmTwhpO4U.3m5e2YG60ciecyJos6SrJljQji/9iPsoobme7/rTVS.", false, new DateTime(2023, 2, 23, 21, 38, 2, 835, DateTimeKind.Local).AddTicks(6620), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("0aefb431-7720-4a9f-b038-da2fddc75db2"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$qWrsap01sHHlVpvOyynmJ.8hElRhjn9uWMoLK86ErRgUdErrM3Chq", false, new DateTime(2023, 2, 23, 21, 38, 1, 364, DateTimeKind.Local).AddTicks(9806), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("0eb67b02-6cf3-4fb1-bbf9-054063215fee"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$cjEDkqHsmyyHyILlOclKgO2tb/67TRFDdcca0hwEMfgl3uz6lVChO", false, new DateTime(2023, 2, 23, 21, 38, 1, 154, DateTimeKind.Local).AddTicks(5081), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("0ed43038-1d7a-4553-9c45-78ba08d0ff5c"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$2K2Rn1xOx4EICOtt0qjLneDGvuyk77zZ8W8gaaDR6wxlzrnQNaIdC", false, new DateTime(2023, 2, 23, 21, 37, 59, 818, DateTimeKind.Local).AddTicks(305), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("0f906cda-ff8d-40d0-81c5-bd792be27dd2"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$/dU15tL6SxyhZKNonEgpguxaLmkTkOkH4es4iHa9Qn0k2EPrOwTcO", false, new DateTime(2023, 2, 23, 21, 38, 0, 501, DateTimeKind.Local).AddTicks(8906), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("15beeaa2-1adf-4c9e-90c8-88f433131ac9"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$QBzFkjGIOT/EniBek.DUfOMWd243shNNUE6k6d7AJcg/8Wr7ZwsDa", false, new DateTime(2023, 2, 23, 21, 37, 57, 776, DateTimeKind.Local).AddTicks(5369), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("16268a77-280c-431c-ac23-8f403ec823f6"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$87EMzwqXCgkRuG6OOsnlyuVy9ZXsMZQCnA8Om2AIvLecvCHIXihry", false, new DateTime(2023, 2, 23, 21, 37, 59, 559, DateTimeKind.Local).AddTicks(1275), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("167fd983-1747-43fd-9e0b-2f3801e01ec2"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$C1ms3yqyjC7gF4kWpIBi3eg0.0dPWeGayqR0yRS3SOTI/hK1NuayS", false, new DateTime(2023, 2, 23, 21, 38, 2, 650, DateTimeKind.Local).AddTicks(5739), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("16d0e1b6-ab84-4f9e-a1f5-6b89d3c056a1"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$Bv/Qjd8svb2IN6WCoTp3POjPruQ1vRsgUds390u/EeKf2NoHT5/42", false, new DateTime(2023, 2, 23, 21, 38, 5, 164, DateTimeKind.Local).AddTicks(8625), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("17d41bfc-6056-454c-bee7-3c73c5a58daa"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$I6nBhYbnjVgh/8ONFSCy8.qlAR8DEIQJRBL1aJ8u61v1G7oeXQl5S", false, new DateTime(2023, 2, 23, 21, 37, 57, 590, DateTimeKind.Local).AddTicks(4583), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("1ac013ff-adf4-40e8-a671-65365b5ecf4a"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$gI8N2kSdPVxr8a9LJ1pzPuMe4VfQPtgwl5Qm.3fcxOuWSY8v0zWZ2", false, new DateTime(2023, 2, 23, 21, 37, 59, 734, DateTimeKind.Local).AddTicks(3171), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("1b0db95f-17bc-4730-9e12-7975d65a60b3"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$8us72kIgneY6US8vSrXO6O1tKHz/nbveUFoiuiCZx.q7uFz1vSZDu", false, new DateTime(2023, 2, 23, 21, 38, 1, 601, DateTimeKind.Local).AddTicks(5218), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("1b1ae92a-04d6-40ff-ba16-43d98ade59e1"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$AIL/Vtir/cwnqJtHoGR8DOu1kStNTkkbJROyGQzRECZKH/na3bLE6", false, new DateTime(2023, 2, 23, 21, 37, 54, 37, DateTimeKind.Local).AddTicks(2775), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("1bd000d0-2ff3-46f9-a4cf-1b5e7af71c22"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$fS4QFq.jMCk7/xZxSMeSYuXzEJkvi/WWXWtfbIDfHGUk/RY3j9jTS", false, new DateTime(2023, 2, 23, 21, 37, 52, 454, DateTimeKind.Local).AddTicks(5915), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("1c12719d-fb58-4037-bf1a-4ab35b5ee03d"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$xTcu2pBH8Bzg.LCaeiVVMOV9UMXpoYl3quY86wPUC8qMxZZLlrmtO", false, new DateTime(2023, 2, 23, 21, 38, 2, 432, DateTimeKind.Local).AddTicks(1791), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("1c84edfc-adc0-4669-87ad-e35ee1e18ae1"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$W3RsPd6kJ53zmHkVzpksbOPptQW/doksY2zhMzWBApb3QdRpn3vFG", false, new DateTime(2023, 2, 23, 21, 37, 57, 358, DateTimeKind.Local).AddTicks(4574), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("1fd78362-941e-40e9-982f-ccba3e8aa8ee"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$tB9jT1FGpZ0gZ6ZbxzS.3OnkOYudlCf.m27SEOv/DbmszxOB58JqO", false, new DateTime(2023, 2, 23, 21, 38, 2, 537, DateTimeKind.Local).AddTicks(8742), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("225392f3-cffb-40d9-ad7b-5da2fc4c09c3"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$A.P26iOi04qzrorNa4FDWOaYryqn2Oykjxk4ewe8NdezjP7G/jA3.", false, new DateTime(2023, 2, 23, 21, 37, 53, 230, DateTimeKind.Local).AddTicks(4565), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("23d19a0d-9cde-43df-847d-77f100ceceb1"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$q8OQ5blmpsSd1W4nwdzdFeG.p0Mpue0lE9LoIvHErLwWPyXoBlZFu", false, new DateTime(2023, 2, 23, 21, 38, 2, 334, DateTimeKind.Local).AddTicks(404), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("299c65f7-d4d9-46de-b15a-08a59fdabf07"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$8n9.gN7TjutQOwVK5y.g9.8LRLQr6.UE87SF4VJJ/hHCtTqXOSD5C", false, new DateTime(2023, 2, 23, 21, 38, 1, 479, DateTimeKind.Local).AddTicks(9155), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("2b307aaa-9f18-42c9-b373-f787baeb9668"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$5Zrbaw.sE0uh6JTVHR6Zi.1j0sWOZSdEM7Vyp9P0p5UdNoJhJADZS", false, new DateTime(2023, 2, 23, 21, 38, 3, 147, DateTimeKind.Local).AddTicks(4903), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("2bec8b7a-a215-4e6d-9c8a-75edd4fa05df"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$Blc3JZ1/ZcoRodSCWb39deKqyS9xj.U7OS6bZOhegnnONiAVUujKm", false, new DateTime(2023, 2, 23, 21, 38, 0, 678, DateTimeKind.Local).AddTicks(4635), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("2d434350-a351-46ec-acef-47c1e32163e1"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$Dd91EVjio7RqgvZotvwCL.uBXUAWSReJnnpEqy6NUbP.b8lXfLb66", false, new DateTime(2023, 2, 23, 21, 37, 55, 293, DateTimeKind.Local).AddTicks(5301), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("30305ea7-57d9-4e09-8e2f-f87b0a8337ed"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$7gBK1Z4HOuQOdM9VLy8G3u/FzlMn2n5EVoFerMGeXslItsYyp2vOC", false, new DateTime(2023, 2, 23, 21, 37, 59, 908, DateTimeKind.Local).AddTicks(7519), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("3249dcff-7018-460e-98d2-ffc911245498"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$D52YwT9qznWdxLxSbogbTuUDl5M7fevsC9wTAPRbetuzPIVOLkuYW", false, new DateTime(2023, 2, 23, 21, 38, 3, 423, DateTimeKind.Local).AddTicks(2443), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("3835389a-e64b-4285-bb7b-b6dcba2e4446"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$OR3g0kNCQkhO1sbJVDY4b.f.d.ZRgwOMZ6lWYJ0MdP7nOVBiRa.1y", false, new DateTime(2023, 2, 23, 21, 37, 55, 461, DateTimeKind.Local).AddTicks(193), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("3dee57be-b05a-4966-9cd9-a1f8f482b0a8"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$0qFvufEO3jQ4nHWfilsvEencFrliu3xAyens/2EHOaxRqB2kexbyq", false, new DateTime(2023, 2, 23, 21, 37, 53, 131, DateTimeKind.Local).AddTicks(3944), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("3e72f54f-7d44-45bd-ad43-cbb616841adb"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$eKc6R2j7s/AEDeOyFKG2AOjsy7GEIfc4IvcL7d2XBJoKjyMP9UtRy", false, new DateTime(2023, 2, 23, 21, 37, 52, 124, DateTimeKind.Local).AddTicks(6885), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("40b73121-9d7e-429a-bd60-127e6b14b19b"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$1xDjiiCtBqdjEbRyU39DcuO4A/V7z3iSkvMRQXIXW04a9oNE3lNzO", false, new DateTime(2023, 2, 23, 21, 37, 55, 776, DateTimeKind.Local).AddTicks(3777), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("40c44b5b-b82f-4fcb-83d3-1dab7cbd761f"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$De56jaOxnIeek4j.UI/SOuOlXC689a.VZJmLVQFuy9CT1fNZCRsja", false, new DateTime(2023, 2, 23, 21, 37, 55, 615, DateTimeKind.Local).AddTicks(4871), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("40e2c034-2169-4318-8670-2fd5a9d1d936"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$Lrlc5xMMu4RgzpEMmrGRDOPK4/HW1c/o9LCACptQtGX509qr0ge1q", false, new DateTime(2023, 2, 23, 21, 38, 2, 927, DateTimeKind.Local).AddTicks(2797), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("45082b3c-c9a8-45cd-a68b-9d12f45b718f"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$DXIyoGexoQGBfBYPv4y9geto.6fHiKt7W0At4AIEADknFcdX4MOm.", false, new DateTime(2023, 2, 23, 21, 38, 4, 434, DateTimeKind.Local).AddTicks(141), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("46cc23ca-f47c-4e84-8c05-e7fe780316ae"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$O46DGNjGnEg0zOqWrNJDoeK1gWd.HMIfrzhbhlr8l4p0nr1397tL6", false, new DateTime(2023, 2, 23, 21, 38, 3, 826, DateTimeKind.Local).AddTicks(3281), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("4bb471ba-4cc7-49ba-b8ac-09d3d4ea586b"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$bNoUqkT/cRoGe6PMsA1kBeq3swr90EbD2.GRRqoVXfYmuQx3HDan.", false, new DateTime(2023, 2, 23, 21, 38, 2, 125, DateTimeKind.Local).AddTicks(6435), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("4c865e92-fccd-4fd2-81df-3b18c39b7b16"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$lznbQ2HPlQsCkt/82.A.0ORrbJU/wGKJNxQHcfhmUI4T5Ud0U3tN.", false, new DateTime(2023, 2, 23, 21, 38, 5, 337, DateTimeKind.Local).AddTicks(6208), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("4cb9bf7f-2cde-4e2d-80b2-6610ecffb53c"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$dhgYkzunIiWI.1YdsQ1ev.2HqyvT4SC0rYGqygVM.1i3DH0WGY6jW", false, new DateTime(2023, 2, 23, 21, 38, 0, 860, DateTimeKind.Local).AddTicks(3532), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("4f0088d8-6b01-46c9-b944-c1c3bb3a98df"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$aoAcFsMIhKJJkK2z5/prV.SafHBSo9Znm2DEftoCnHZtEF2ZqxAYK", false, new DateTime(2023, 2, 23, 21, 37, 54, 390, DateTimeKind.Local).AddTicks(4103), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("4f45a0ab-1fa8-46b0-a825-a1936e48a839"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$SsVwY2D7Vrhi0nGMVBJEROceJBuX9VYxSR5ZNnN4gbxFrE6EbLZdq", false, new DateTime(2023, 2, 23, 21, 38, 0, 115, DateTimeKind.Local).AddTicks(5978), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("51d3014e-8cf1-4e15-8aea-3923a86f36c7"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$CXt1azw/MbK5UD5pWrGxm.pai7RvPsJIcxLlXi2f2X0OKpx9WNO1K", false, new DateTime(2023, 2, 23, 21, 38, 0, 225, DateTimeKind.Local).AddTicks(5345), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("52afb11a-e7d0-4083-8cc4-9a5bdb34ad5f"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$PquJl4k7qy3YuGNRzQNdWO2gH50vEVbVCXgCsZdQQpBxzFPuWt9aO", false, new DateTime(2023, 2, 23, 21, 38, 0, 17, DateTimeKind.Local).AddTicks(3427), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("53e1e512-a75e-41df-81d9-e9271c0ce3ea"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$2P3/aIo8KPNFL3/bvv/COuULXfKkPxn3W6/OnTUApK9vWjE2cgYdW", false, new DateTime(2023, 2, 23, 21, 38, 1, 915, DateTimeKind.Local).AddTicks(2448), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("572202c0-7f54-41ce-b5ea-14c42e653981"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$AoeuEm2x.L4Y2rNf0fy3Ee9WpU1gZQUJi6CJt3fOwo321YZYpWCoG", false, new DateTime(2023, 2, 23, 21, 37, 59, 649, DateTimeKind.Local).AddTicks(1735), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("5774aee5-11b1-40bb-8016-778931974076"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$KhAwUWkkADmu8XIuAjnbmuCDCvzRQNwWRBpe9CmwlQI3.VMi/sQuS", false, new DateTime(2023, 2, 23, 21, 37, 55, 121, DateTimeKind.Local).AddTicks(7552), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("5aed001d-6ff5-44fb-a0b6-26ab026b7acf"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$CRLIZSQlEx7gz5RTsvQPauDlDytvByb5D6V7hsi1wrywQFR3LzQCi", false, new DateTime(2023, 2, 23, 21, 37, 58, 405, DateTimeKind.Local).AddTicks(5761), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("5d8ea1d0-bd1f-46a3-931c-b522874e696d"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$beDMEUmhK1SeM/FbUoixCer7b3UkkvqOcv6vD1YqX4wpmFV7BDlYW", false, new DateTime(2023, 2, 23, 21, 38, 2, 235, DateTimeKind.Local).AddTicks(4882), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("602ac6e6-9e81-4488-8595-e41c81a9aa48"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$bIiStRHcPd6VcVjW5TPcYuqFheuE3BpLwjQ7b.rxuUtmY4UujWwu2", false, new DateTime(2023, 2, 23, 21, 37, 56, 841, DateTimeKind.Local).AddTicks(9492), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("6202047d-3460-410d-a882-61449f635e4a"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$8sTTe5WiKdMyBOElEHZwIe5g/nJnFEujkESvGAc2ObTXBVLay1bAa", false, new DateTime(2023, 2, 23, 21, 37, 59, 70, DateTimeKind.Local).AddTicks(8436), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("64b81f09-500f-48bc-b7b0-bea181a62c25"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$Pj6kcW9tec2c8uFD.3Fn1uuLZSXdi5FhyjmM21sSuiFi.Y/9F7PqS", false, new DateTime(2023, 2, 23, 21, 37, 52, 227, DateTimeKind.Local).AddTicks(1984), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("64cc5e57-fc6d-43d1-b747-e6119ded804c"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$0zhYiy1M4nHO0AYEak9coevDkNiyN34dDMPTJA9Cey1EN5ovNYEkW", false, new DateTime(2023, 2, 23, 21, 38, 3, 38, DateTimeKind.Local).AddTicks(8548), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("65921b4d-a95c-4660-9c84-52139bc1fc83"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$wj.QoPlJRP4JGKfLpwkn/ewF9CUvpXyziNqtEm6XCMUs8t.JpERYe", false, new DateTime(2023, 2, 23, 21, 37, 54, 821, DateTimeKind.Local).AddTicks(5812), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("682faf95-1f71-4187-ad2e-482945491d24"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$zF8Ac9ERrNFSoBlC03PZuOGUR2cdI85hLc2VeYAs7Z2FLMW3Gh.oa", false, new DateTime(2023, 2, 23, 21, 37, 58, 863, DateTimeKind.Local).AddTicks(5385), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("69625d7d-e4d2-4500-bf26-7584b1bcd1e5"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$9kg0zUBlBQMITqkhdYScUuWMW0ySIsQA/J.N9kozXGy4QIlDPU/Tq", false, new DateTime(2023, 2, 23, 21, 38, 4, 318, DateTimeKind.Local).AddTicks(5704), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("6a4c90e8-2588-436a-ab3a-110167c10127"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$.dIinyJF5M6XUfSYnHrnZ.FD2ORZx5vzGNyQFWyPEJUGvbXnENUq.", false, new DateTime(2023, 2, 23, 21, 38, 0, 323, DateTimeKind.Local).AddTicks(9813), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("6ccf6fa1-ed10-4db3-aaf6-5c011450ec06"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$UpbNKBCPnE6Qrq7PXo536u33QQFxpHlmXi5diR2OIuxsfwzLOwwzm", false, new DateTime(2023, 2, 23, 21, 37, 59, 350, DateTimeKind.Local).AddTicks(3725), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("7316b0b7-3821-45c9-b50d-ae31f639f132"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$Wk2SuB4UV1rzgao9f/zuaueKiuSph81AHRYE/Y0EjbLeexRM0IdZO", false, new DateTime(2023, 2, 23, 21, 37, 54, 537, DateTimeKind.Local).AddTicks(5447), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("77086632-1a24-43e7-b33b-2b2c0669efc9"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$FrhFKY7cgRhkkpL3XaMEI.Jd6Hh4VGqQ/aZESGvttla3qXAxQMlmK", false, new DateTime(2023, 2, 23, 21, 37, 53, 4, DateTimeKind.Local).AddTicks(1402), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("792f1226-ef21-49e7-a499-b5e01ec8c3a2"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$Ypkule7k.3Hrw8P4dEl.POQndXgXtDUWtKMOguguseRL4oDHaR7/C", false, new DateTime(2023, 2, 23, 21, 38, 3, 335, DateTimeKind.Local).AddTicks(7265), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("7cf1a9b8-6266-41a1-a3b6-66e4388d5767"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$R.TZiik3XHdZjIy8Gp53e.8eBy8VOmB6PC3zJz4va.I6eW9QPkw3K", false, new DateTime(2023, 2, 23, 21, 37, 58, 968, DateTimeKind.Local).AddTicks(747), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("7d9e854e-16b6-4483-a957-161ad0029a17"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$KG8txjlzUtGdVfNmes4vyu8hqqFNenGJb9FKJMhkAVMMN7z.bBZiO", false, new DateTime(2023, 2, 23, 21, 37, 58, 517, DateTimeKind.Local).AddTicks(3211), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("7ec048d6-ca75-4ea6-b6ba-0d0889f94b78"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$Ni2jxA4HTvPAPNCm.lr/ZOc2F0LJNLybMopiBquLUiFkaourLeEwK", false, new DateTime(2023, 2, 23, 21, 37, 52, 790, DateTimeKind.Local).AddTicks(9297), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("7f1251a9-826e-4f03-ba8b-3ec892f37bea"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$RnIFs2BZIz62xLQiffewOOjjKWgEFyLtQtT/sG6WfvVVe3j7l7n1a", false, new DateTime(2023, 2, 23, 21, 37, 54, 978, DateTimeKind.Local).AddTicks(238), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("85d7f52d-28ad-4b74-a7ef-b2f22e943268"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$bqurI.DT7u6NiJQgI1tL3.lMlh71wRgfSgIgZI7xgwzW08Zc5t2Di", false, new DateTime(2023, 2, 23, 21, 38, 4, 612, DateTimeKind.Local).AddTicks(8147), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("8988a99e-342d-43e5-87e7-b9d401807898"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$it.pLLfWfIJVsghGR40xGekVDR8RUfDTpFaLLaXp96As9oYQWTl9i", false, new DateTime(2023, 2, 23, 21, 38, 0, 588, DateTimeKind.Local).AddTicks(4898), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("8a282d5f-17bf-49d8-b3d8-872b4ea168c0"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$i6/K4jiMzEUfAdtPDU1eRejrIHXmxynXeIVAvA4PgD8jJeanHEYXK", false, new DateTime(2023, 2, 23, 21, 37, 58, 285, DateTimeKind.Local).AddTicks(4080), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("8a376cd5-d4ee-4c2b-a0f0-08366fb71fd6"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$iyDNJa65Md2D5B2cpNS8nesj5v0EjzGDIcpzfv62jeoSBHP8X2XSC", false, new DateTime(2023, 2, 23, 21, 37, 53, 538, DateTimeKind.Local).AddTicks(8439), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("8aa35713-c583-4f80-9042-549c4aefa911"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$mNbqQ9UBG5u3QmbUZDtvOOam4l6H2IIxEuFLLj.Ej94Nx8O9F0mbW", false, new DateTime(2023, 2, 23, 21, 38, 3, 624, DateTimeKind.Local).AddTicks(9708), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("8bba4805-a832-4655-8282-a7c15c6a400f"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$DeTWL8B9CY.rJWSGk8OCw.bTtKC3CXGotCUYP4qNQFTkDzK8Qd9/K", false, new DateTime(2023, 2, 23, 21, 37, 57, 239, DateTimeKind.Local).AddTicks(4176), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("93a7adf0-8fe5-428d-a68e-cfe9292afb26"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$a3Gh8.PxmkBoLx002ukloe3GPBDn7/ch7lH4bNmf9WVM.nPf7RXki", false, new DateTime(2023, 2, 23, 21, 37, 53, 745, DateTimeKind.Local).AddTicks(9745), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("9445c592-9b39-4b28-bd42-2b1bbd084457"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$YSoiAULASrEOYUdKmCpcUeGU5fdnj87abZ9WhgwydfJ24To2KV4p.", false, new DateTime(2023, 2, 23, 21, 38, 5, 66, DateTimeKind.Local).AddTicks(2577), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("94684b4d-9702-4e1e-8db5-82861f87b799"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$.Mt/B2VMVaA6qMxSjsagVuS9b96om90IKDOehl6fHPuVh4Prz.w3q", false, new DateTime(2023, 2, 23, 21, 38, 1, 64, DateTimeKind.Local).AddTicks(1143), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("96609731-fe5f-45b7-a9b5-d3ad0da12d30"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$CJIoN7cI1RvqJnY.J5mCXuXS2A73GlJ55KDlxqOnPVOPHD1W/HIf.", false, new DateTime(2023, 2, 23, 21, 38, 4, 10, DateTimeKind.Local).AddTicks(6512), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("9872580d-8e14-477f-b5eb-e16fb264dc53"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$NZTfJhE7Yw/oOwHkgtYZL.8ELdVcydWfmb/4hDImnCXMD6TCI.ooO", false, new DateTime(2023, 2, 23, 21, 37, 53, 329, DateTimeKind.Local).AddTicks(583), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("99dc3948-b7b7-40ee-890b-c7186b1e685c"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$YoNS3bqx4S.uaKC.XWf5Uuebg9TUZYHiIIcM/SneyrzcAuwsxfwXC", false, new DateTime(2023, 2, 23, 21, 38, 0, 417, DateTimeKind.Local).AddTicks(765), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("9cce6a30-8437-4688-a6e9-5dd243c76451"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$kCnWQYctM1J7v3s1uEfjAeXP6CBKX9o2sTNQ98lIQCyOYYdur6cAa", false, new DateTime(2023, 2, 23, 21, 38, 4, 779, DateTimeKind.Local).AddTicks(6237), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("a094c0b1-4af2-43aa-880e-c7a8cad589e5"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$7/Sn14663xm9R.9KTvTBgOC9tA7iR007vCIsvrnG9bAoUlvDWlqy6", false, new DateTime(2023, 2, 23, 21, 37, 59, 259, DateTimeKind.Local).AddTicks(780), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("a27e1cdb-1bc2-4876-ac76-67cdaf9af2c8"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$MVvMYPDhXJpX42x3w2aqVOkyvkwkCuzSi.vxFpp8xRsHPX/rmRY8W", false, new DateTime(2023, 2, 23, 21, 38, 3, 917, DateTimeKind.Local).AddTicks(8639), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("a43eedf8-caa8-4fc3-98c7-f5a6314c83bb"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$oe626sDef5ke6GmfYh7EGOv/Wmf88oDsjAw1kl3YJVYV4YvApJ/Pq", false, new DateTime(2023, 2, 23, 21, 38, 0, 951, DateTimeKind.Local).AddTicks(2277), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("a4de98ec-aaa2-4a2e-95f3-20315ad34cb4"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$1hGmUWXp6O7TVvyk3BXFjuV6TU8JlC0h.eevtYKEtqwOcjMnRPLIS", false, new DateTime(2023, 2, 23, 21, 37, 54, 681, DateTimeKind.Local).AddTicks(3129), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("aa1de720-41a4-4ac6-87cd-83746f5895dd"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$4mmU4KA8BMFhcdt/.Qn6SeTsm4U7sihOTHfsLQUC9zycW35kDP0MW", false, new DateTime(2023, 2, 23, 21, 37, 56, 964, DateTimeKind.Local).AddTicks(1638), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("ace6a572-2636-49a9-b40f-0620e0bb5f75"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$hiM16cOf24fzGWI22ic4K.jBowkh82r2WW7EL8Im0VhksXN9ALu6G", false, new DateTime(2023, 2, 23, 21, 37, 52, 887, DateTimeKind.Local).AddTicks(2697), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("b0286853-6d06-4de4-8454-1b48db2966bc"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$xRJrnunmKCaNGKTrA2.1lOsFAl8X2m2RP7Kjgq35Oq.Y.yBHohpQi", false, new DateTime(2023, 2, 23, 21, 37, 52, 17, DateTimeKind.Local).AddTicks(4716), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("b35f9bb6-c187-4fb7-8540-4a25829b409a"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$14UhnkxXkRQsq6ODvISNdu4fUqp6zR4Tr0KRUEkfJvmZTh1kEFfSa", false, new DateTime(2023, 2, 23, 21, 37, 52, 576, DateTimeKind.Local).AddTicks(8229), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("b93a0677-7b2f-447a-a205-8d9660e344d5"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$cNAHto1psBBnShrbqsf1bOX7xn9gNz5K8JxJq.XYyOHKM8TBlx8Si", false, new DateTime(2023, 2, 23, 21, 38, 3, 243, DateTimeKind.Local).AddTicks(4153), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("b94c6efe-9782-41b8-a281-79e06ebdb37c"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$cLbd9pLRTje9EKkKprMdMOVePJk7.wape.fuPeJpq6/5Z9mhO6Hie", false, new DateTime(2023, 2, 23, 21, 37, 53, 649, DateTimeKind.Local).AddTicks(1368), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("b98b3f99-47b6-4ef1-8fb8-0a4103c98f7b"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$CxWg56IciT5EkWnuyKPOiutGo8VamwFQExy4pjobj05vW3LFy8sc2", false, new DateTime(2023, 2, 23, 21, 38, 2, 744, DateTimeKind.Local).AddTicks(7922), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("bd2f25a6-077b-4aef-9d26-0bacfd6092f1"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$AiorKXOxEnmLGElkuklKxORXokQTwRBUVZcNBXZkeYS1Ln.UDQMZC", false, new DateTime(2023, 2, 23, 21, 38, 1, 257, DateTimeKind.Local).AddTicks(1696), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("c1547a98-9ec3-482e-a4a5-3e1b3eea2f3b"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$.CgCOb2VHacmofh2Xcp88uezJu3cc7cFt7vDovnQj.4HdMfdoyOHO", false, new DateTime(2023, 2, 23, 21, 37, 57, 969, DateTimeKind.Local).AddTicks(7503), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("c7777777-a262-4d8f-888a-ac7abe109dd1"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$QADktlTEjkKl5fCT3phFCOBfq8Wz3/JvufzZroeNnfVo.lwZSl5gS", false, new DateTime(2023, 2, 23, 21, 37, 52, 690, DateTimeKind.Local).AddTicks(9660), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("c84c7480-e58a-47c2-8503-9cbf925338bf"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$k05RLKIz7FnRI2qjqEn4FejYsukbPD.lEZUDhtB9xwFcJl8.LtTci", false, new DateTime(2023, 2, 23, 21, 37, 59, 167, DateTimeKind.Local).AddTicks(8542), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("cac14f23-8ef0-41a8-a4cc-383fe6c65135"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$31jY/D/moC4BEuG0MeOtguM6vWe1iXnKBnd7WZL1rmMpxqju/16PW", false, new DateTime(2023, 2, 23, 21, 38, 4, 206, DateTimeKind.Local).AddTicks(7852), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("cc4b3d7f-53b8-4790-9265-af8ddb7ea58b"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$xjMc7SWwuDBt407Tmd.b1O8DgBZF74Di4fTNg6kVhnRH1V3mWZhV6", false, new DateTime(2023, 2, 23, 21, 38, 5, 252, DateTimeKind.Local).AddTicks(7977), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("ce5eaaa4-b4c1-45d8-8730-7535a3d02e40"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$dgD.2S.ZFrx.44fn.Lud5uV7zba/GMg8jFTvf3/zJMUsTBDR3I14C", false, new DateTime(2023, 2, 23, 21, 38, 3, 516, DateTimeKind.Local).AddTicks(9998), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("d5b2fe38-d772-410a-9281-36e331978541"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$vvYqFFJQg/ffzU76guAmRevp2PIDkyxuB9Qk3W8qw3oeQszJkSzmy", false, new DateTime(2023, 2, 23, 21, 38, 4, 951, DateTimeKind.Local).AddTicks(1944), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("d810a0ee-b6e9-46b2-8c23-1011c49f4711"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$xvmjfLWFGA24PR128NX7FOVr8XDJgwwzcp.trozPBrcQvgo4K.RTG", false, new DateTime(2023, 2, 23, 21, 37, 57, 469, DateTimeKind.Local).AddTicks(6333), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("d9aae942-150f-4db3-9ced-74ba62decd7c"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$5usrHnFX0DSKBcCm0E0LN.sAW1z/6XriUFdjez1O0OGtB5EnvtlU6", false, new DateTime(2023, 2, 23, 21, 38, 4, 698, DateTimeKind.Local).AddTicks(3236), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("db17c297-dc71-49ba-9e28-c4c1e294ccfa"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$qtLeMwGN0dgOdM35nhXjvemhon5q5KmLZv98CitQ.99PFDJydtreK", false, new DateTime(2023, 2, 23, 21, 38, 0, 769, DateTimeKind.Local).AddTicks(6227), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("dcfc0d46-c1e9-49fd-8d83-51d104bb4fea"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$9.K4rMsBugrb7oWUsOlFAemIfPNE8VxdvC8voEbjPnVxst3Yf9H0S", false, new DateTime(2023, 2, 23, 21, 37, 53, 839, DateTimeKind.Local).AddTicks(1986), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("de3c4728-974e-4ed9-b4d4-48ed952592ba"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$ZHppqn/8Gmi8Oj/2HWgg0uep5NrZvHKv2hhrdwLH9eeTN7WZvMqLa", false, new DateTime(2023, 2, 23, 21, 37, 52, 346, DateTimeKind.Local).AddTicks(1250), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("deeb1f29-a29f-4b2c-9329-6444f28159c9"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$c92lnFX8sQP62hzYZWci.unINl6zvSsLyjogbppe2qYCZgZJH3MQK", false, new DateTime(2023, 2, 23, 21, 38, 1, 816, DateTimeKind.Local).AddTicks(5964), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("e06dc60f-b6b3-47e7-bef5-eb3d480aa1f3"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$mkQBHarNmdHn5k448sxQgefAMpW4sDZ98xNoMFGczegNWQCTXIJCi", false, new DateTime(2023, 2, 23, 21, 38, 4, 524, DateTimeKind.Local).AddTicks(9761), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("e095657b-e3fe-44dc-85bb-6417f393794c"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$.X2Dz3QcodXONHeIsagv4OuWJyGVdJYxjcVugPgSLKTzZKIlhZVuW", false, new DateTime(2023, 2, 23, 21, 37, 53, 442, DateTimeKind.Local).AddTicks(4646), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("e29e6827-12ea-4954-98c8-86b87bea289f"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$w16vskZjPejwc3KzBcCNsOdTZ/RnykwB4mJxIY7fdUI913GFlJd2i", false, new DateTime(2023, 2, 23, 21, 37, 54, 212, DateTimeKind.Local).AddTicks(6484), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("e40d71e6-f13c-4b2e-88b6-ff2198d1799a"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$jhEmJpm.vcn16cJXvqZnt.B2iYJ5McpTLTx/wM1u4d3RJJUxxPZcK", false, new DateTime(2023, 2, 23, 21, 38, 4, 100, DateTimeKind.Local).AddTicks(1423), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("e6276041-7dfc-42a3-bb74-16474b331481"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$x7I0wzjmuGoedcj395QX9OfE6E.ASOo77f5f.t8Jo2IacWLHR6feO", false, new DateTime(2023, 2, 23, 21, 38, 4, 860, DateTimeKind.Local).AddTicks(2170), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("f3e092eb-5086-4888-8c3b-d0d66635ebef"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$lw9ACBMo6z7HX2g3Qza.jeW1Z3rDizYEBazjqPfUgTE0DjY.n7Fzi", false, new DateTime(2023, 2, 23, 21, 37, 58, 145, DateTimeKind.Local).AddTicks(6551), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("f4600998-6b58-4538-ba53-ef6749c7c927"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$HeUxzU4/1f8lcrY1QH/uAOBAfKDiuTDAkOvIHE8iFjs/wQs1HjD/a", false, new DateTime(2023, 2, 23, 21, 37, 58, 752, DateTimeKind.Local).AddTicks(6643), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("f7976caf-4906-4ccd-bc36-ec0cc3f0fb80"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$sKFhYdnieJoDbcAvlqjYc.j.2ZMY645YuOFdVwDj9AhnWLl2o8G6m", false, new DateTime(2023, 2, 23, 21, 37, 57, 91, DateTimeKind.Local).AddTicks(817), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("fc1459a2-9075-410a-a77f-63f3900e8347"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$xmzjG5j3jaSxAYGBOH76aecnBC359QJSuLjsEZ/GMK75ngAGpA7S2", false, new DateTime(2023, 2, 23, 21, 37, 58, 628, DateTimeKind.Local).AddTicks(3516), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("fedb33d5-7114-4724-851d-3a1f918364e6"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$4smFRBbTeMdRTgNsaCyVyO3SWhOaeN0kh91SiIo4eKlZLrnzow2JC", false, new DateTime(2023, 2, 23, 21, 37, 59, 446, DateTimeKind.Local).AddTicks(2463), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("ffeee650-3745-4907-a1b8-e7b40e4185f4"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$rR1iqrzgp1tvqFFVIkT0Me0J1Tl0Wntqq8qVR9Chbt8r86WkbynwG", false, new DateTime(2023, 2, 23, 21, 38, 3, 733, DateTimeKind.Local).AddTicks(1501), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_LastModifyByID",
                table: "Parkings",
                column: "LastModifyByID");

            migrationBuilder.AddForeignKey(
                name: "FK_Parkings_Users_LastModifyByID",
                table: "Parkings",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");
        }
    }
}
