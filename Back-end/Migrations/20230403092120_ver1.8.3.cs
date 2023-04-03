using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver183 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MembershipPackages",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Months = table.Column<long>(type: "bigint", nullable: false),
                    SubcribeAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipPackages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarModelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CarOwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cars_CarModels_CarModelID",
                        column: x => x.CarModelID,
                        principalTable: "CarModels",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Revenue = table.Column<double>(type: "float", nullable: false),
                    NumberOfMember = table.Column<long>(type: "bigint", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    FeedbackByID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FeedbackID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SlotID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_Feedbacks_FeedbackID",
                        column: x => x.FeedbackID,
                        principalTable: "Feedbacks",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ParkingDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeFrameID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParkingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickUpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ParkingDetails_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Parkings",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ParkingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DashboardID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsLegal = table.Column<bool>(type: "bit", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LON = table.Column<double>(type: "float", nullable: false),
                    LAT = table.Column<double>(type: "float", nullable: false),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Parkings_Dashboards_DashboardID",
                        column: x => x.DashboardID,
                        principalTable: "Dashboards",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDisable = table.Column<bool>(type: "bit", nullable: false),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MembershipPackageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_MembershipPackages_MembershipPackageID",
                        column: x => x.MembershipPackageID,
                        principalTable: "MembershipPackages",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Parkings_ParkingID",
                        column: x => x.ParkingID,
                        principalTable: "Parkings",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestbyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Requests_Parkings_ParkingID",
                        column: x => x.ParkingID,
                        principalTable: "Parkings",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Requests_Users_RequestbyID",
                        column: x => x.RequestbyID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TypeOfSlot = table.Column<int>(type: "int", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarModelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Slots_CarModels_CarModelID",
                        column: x => x.CarModelID,
                        principalTable: "CarModels",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Slots_Parkings_ParkingID",
                        column: x => x.ParkingID,
                        principalTable: "Parkings",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Slots_Users_LastModifyByID",
                        column: x => x.LastModifyByID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TimeFrames",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<double>(type: "float", nullable: false),
                    End = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeFrames", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TimeFrames_Parkings_ParkingID",
                        column: x => x.ParkingID,
                        principalTable: "Parkings",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TimeFrames_Users_LastModifyByID",
                        column: x => x.LastModifyByID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("36db94e2-fe69-496a-988b-6b433d7e48ce"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("47ece2a8-fe05-4286-97d3-ec0cfc7ff8a3"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("82f57184-66a9-4f24-a772-796a773e1a0c"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("b97349a8-92a3-44bc-8b57-834445ea3feb"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("c108b8ad-516c-44be-b017-9942d79ad44d"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("f330b2e9-5637-4ee1-86e1-28cee5c4c640"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("39956c36-e329-483c-9467-2a83a7f3bda0"), "Half Year", new DateTime(2023, 4, 3, 16, 21, 20, 167, DateTimeKind.Local).AddTicks(8417), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9193b84d-7fd9-451f-9ced-d078b645ef15"), "1 Year", new DateTime(2023, 4, 3, 16, 21, 20, 167, DateTimeKind.Local).AddTicks(8419), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b7b1d01-c205-4e9c-9da7-49cdcadc7bb8"), "Short time", new DateTime(2023, 4, 3, 16, 21, 20, 167, DateTimeKind.Local).AddTicks(8412), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "ImageID", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("0143b9a7-52ee-4ca3-8b3f-d3d7d960ec85"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$a1dUHtQViYGmTxV3DQJDgezy6Iuv3cBFzj2ZG84cuW3QYl87HFCzq", null, false, new DateTime(2023, 4, 3, 16, 21, 18, 415, DateTimeKind.Local).AddTicks(8019), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("01988567-3886-4ffe-ba83-a5b5851ac431"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$u5YHE9oWMJX0nrTdN8cl4uJZbmYTrexZ4TwUPq0aBTabtnl9ZWhsa", null, false, new DateTime(2023, 4, 3, 16, 21, 12, 448, DateTimeKind.Local).AddTicks(2004), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("0268c09f-5d46-46ab-93ef-463b94fa206d"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$XRmXeEtMrrBgCpd/UQLjB.aZmr8TehtK3HLlQg2O1UFbSpNIYyToi", null, false, new DateTime(2023, 4, 3, 16, 21, 15, 385, DateTimeKind.Local).AddTicks(9325), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("07975059-4b9e-4193-8a8f-a0c804cedfad"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$/ZYnClHpY1mApEuQcar4euWMst2oflieMIWHB41H1Gi1oOigcmR4G", null, false, new DateTime(2023, 4, 3, 16, 21, 3, 464, DateTimeKind.Local).AddTicks(1149), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("07bd340f-3791-40aa-8235-da3e62ebadfe"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$GJNTbAgmgj1e9QQyyNKBH.2kxwIcOJLR.Z7tBTyCuvO0X0OJUCMpq", null, false, new DateTime(2023, 4, 3, 16, 21, 4, 869, DateTimeKind.Local).AddTicks(4653), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("08d43dc6-a8b5-4ca1-b52f-6cd641c7f6e1"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$qcSwyyksGV5P/FPWxbWXqe2yVefi4T8FAMmZcnH7esV9YI6DeXhq6", null, false, new DateTime(2023, 4, 3, 16, 21, 8, 315, DateTimeKind.Local).AddTicks(5347), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("0d644f37-cc83-4702-b0b5-714902b52ca9"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$SLZ/nJMRTaI1cYrY9RjGgesY2s1X8a4rxz9nSn4Kzd7GqODJd1YnC", null, false, new DateTime(2023, 4, 3, 16, 21, 19, 528, DateTimeKind.Local).AddTicks(4675), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("0fa62636-f3a9-47df-a22c-3e7a0ad00b9c"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$biMmlPFMIitITL4tCVJjser4z6b/M8zfyeSsleOt.n1HaPwTxPuUq", null, false, new DateTime(2023, 4, 3, 16, 21, 11, 811, DateTimeKind.Local).AddTicks(5423), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("11061bf1-1a74-4069-b64c-667aed023cc1"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$jwKwU.tZ7vCyPJSRoXpTl.jCfGN/zIRUynrFZqklDNKoOT9KxqI5.", null, false, new DateTime(2023, 4, 3, 16, 21, 8, 947, DateTimeKind.Local).AddTicks(9869), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("11502315-847c-42f2-bf9d-e8750afb9789"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$rw/y6XmVNp5/Vkyky9.fR.Zg5DHTJETJtUgMASPU0qX79Mr8wDYXy", null, false, new DateTime(2023, 4, 3, 16, 21, 9, 938, DateTimeKind.Local).AddTicks(3746), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("1685a54c-eaae-485a-a854-445f7bcaa993"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$Bdigy95ezi1Gllh.hZP0z.uWurQWgUwstBYWonyDFMVpb2Vxm85Tm", null, false, new DateTime(2023, 4, 3, 16, 21, 9, 703, DateTimeKind.Local).AddTicks(8483), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("184776e7-d730-49a6-b4ba-91a859cda5fc"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$akDiB51bkFnZdUu5gJ7K6ePLgiayDosH3uYerXR/ZwOksnlH7wY5O", null, false, new DateTime(2023, 4, 3, 16, 21, 16, 171, DateTimeKind.Local).AddTicks(3703), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("1b61cc9e-935c-42ce-885a-cfe6548aa34d"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$MW5FwuqF5HBaTJ3fq71oaeYiiI9cNHfzLrPVU7a7T/JGVTWmi6PbK", null, false, new DateTime(2023, 4, 3, 16, 21, 2, 779, DateTimeKind.Local).AddTicks(7648), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("1ddf3c48-b814-45fa-8cd6-7ebf238fc536"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$cd1dYIEpNdvhqDlO1ZQp8OwfR34Nb/h.8MCEOY/3wsAFoYTL3.bo2", null, false, new DateTime(2023, 4, 3, 16, 21, 5, 353, DateTimeKind.Local).AddTicks(411), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("1e182a51-131a-4282-96c2-94c9bef5626f"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$C/AFT73J0w7DIbWrSiOQL.YRTYNdPt.x78F6TiUYznRkOCX7lu1Gq", null, false, new DateTime(2023, 4, 3, 16, 21, 5, 49, DateTimeKind.Local).AddTicks(5), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("1edbbbee-2dd8-4bba-8e0f-c737e500fc4b"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$KD/3hZN9zwn43hcGPdT8u.LCktfsN20jED1C.ZxTukeONtzlOXFde", null, false, new DateTime(2023, 4, 3, 16, 21, 14, 294, DateTimeKind.Local).AddTicks(9649), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("1f7c0e41-6bd6-4151-a89b-d49df52e755b"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$TmX6VNNG3R8PZ4G6P4zC3OBEk1rbu5CyI1n67R.ZhQ1umkym45l7m", null, false, new DateTime(2023, 4, 3, 16, 21, 19, 920, DateTimeKind.Local).AddTicks(7867), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("21c62c89-08a4-4bc9-99cf-76e7a9729802"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$2ZnsUJ8PHkg1axUHzrTiZOujT82XjJdFG7iE3FFyBt7rUMtgCyvAO", null, false, new DateTime(2023, 4, 3, 16, 21, 12, 913, DateTimeKind.Local).AddTicks(8512), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("222ea69f-6f28-40d0-b6f1-e664260ffd94"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$0lZ6.pgKBvxArq/cNOGste4vU/4.L5TbStyRXQxtmOg6D1pkUFIGy", null, false, new DateTime(2023, 4, 3, 16, 21, 7, 690, DateTimeKind.Local).AddTicks(6247), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("28652e54-41b2-4aeb-a5dd-85d137d30d0e"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$JLrljw7HFlddP3mloJYtKub/EUH91.cGOY/1QFHB3zuS7n3qT13wK", null, false, new DateTime(2023, 4, 3, 16, 21, 3, 213, DateTimeKind.Local).AddTicks(1122), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("2d8cd2f5-14a6-47ce-81d1-4c730f26f17b"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$CnAHgaY.tEC.SBu8rY2yIOxkRb.OPXDYnzsTA0YroW2Dfy4BGs1YO", null, false, new DateTime(2023, 4, 3, 16, 21, 14, 22, DateTimeKind.Local).AddTicks(9455), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("30943e09-eef7-4f93-89d9-6a8e9708df71"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$EvqDvVE3fgD3jsRwVP2D6edcctKZROdfWaRxSvnMP7JK6cVRAlikG", null, false, new DateTime(2023, 4, 3, 16, 21, 7, 356, DateTimeKind.Local).AddTicks(5924), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("325b338a-27d9-4e7f-af84-cc416c91f4b0"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$/WPk.AREZX68htJBzB0mAO43stjiQw8RETG9Rja4iIw..81kuiQFm", null, false, new DateTime(2023, 4, 3, 16, 21, 4, 340, DateTimeKind.Local).AddTicks(4414), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("34fb6a34-8c67-4aea-aeff-31f5f821fe29"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$mkPjT3aJ3EDJiPGB8VJ6wuJUSfEH5UsqzH6BejZbbToVrf6nYsQxS", null, false, new DateTime(2023, 4, 3, 16, 21, 16, 7, DateTimeKind.Local).AddTicks(2034), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("35be6b5b-5973-40e7-bae7-a04a8529c3c1"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$LhGGOdvYCEw6xsORKdXQBefdazOSqGRD86VmXtvxqQ1ikpiBtyS6e", null, false, new DateTime(2023, 4, 3, 16, 21, 11, 286, DateTimeKind.Local).AddTicks(2195), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("36db0600-f8c6-42a6-b753-363a213be46f"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$BZZfxDbuxBWyP28HcaBE2edYo3.eljxjOME0Tv0BdxlDQHIx87fta", null, false, new DateTime(2023, 4, 3, 16, 21, 17, 138, DateTimeKind.Local).AddTicks(607), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("37f94850-f89d-448b-a3c3-4f951baab0bd"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$E5F.qq5.G/izXob1ob90FOMEwObZfbtKT.mR9wwldQb9Uw4Njb2ja", null, false, new DateTime(2023, 4, 3, 16, 21, 16, 988, DateTimeKind.Local).AddTicks(6890), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("3f350a98-84d1-42d1-af43-86d3c62b23bb"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$rZQ52bKx6fKwqvJW7rhBsOzOeakzKd183bsEqvfoC0RI1WFFUYFAa", null, false, new DateTime(2023, 4, 3, 16, 21, 18, 144, DateTimeKind.Local).AddTicks(4022), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("3fedfef2-6001-468e-aeec-c5a3dec4c7d7"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$rXuX2BqdpQReObuHrf52oOiR5r9Ro9o4uGTqt7x3j7Kiv8ePzbsUu", null, false, new DateTime(2023, 4, 3, 16, 21, 18, 986, DateTimeKind.Local).AddTicks(5396), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("49c22f61-cf07-4444-92f5-e7ba9b71bf88"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$7sTWqS6XzlUgdnZrrPJgLeTvxQ0WSj6rLJVXvpyJj60sGuIPF9iyK", null, false, new DateTime(2023, 4, 3, 16, 21, 14, 899, DateTimeKind.Local).AddTicks(4368), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("4ecec05a-ef95-41e0-8968-3d9232eb059f"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$aMEse7w5wXGfOycURYV4fOQLR4cfMFqmaMGURvlVvV/ZFKh0ZTRk6", null, false, new DateTime(2023, 4, 3, 16, 21, 20, 53, DateTimeKind.Local).AddTicks(3976), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("4f00691a-6392-4ec7-870e-1ceab41fde80"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$LIdMojarQZ3w1vtLOILfcexLid.YgWy1cNxoJcOd.fjM2yAViCeHC", null, false, new DateTime(2023, 4, 3, 16, 21, 13, 691, DateTimeKind.Local).AddTicks(4267), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("528451a9-aa35-4fac-8e26-45ded01046a0"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$XCjVgALyKX/q42XcbzBnfuCsMVKu5z.X/cBrxp8M3HA25UlXivPYm", null, false, new DateTime(2023, 4, 3, 16, 21, 19, 261, DateTimeKind.Local).AddTicks(7296), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("547a7e39-81ee-47db-8d3e-fdd1a49fc7de"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$ueXmDq7yjQAcPvGf/F0SQOK.LakrT5O9yuHdXnJLcrXCkMieVKp52", null, false, new DateTime(2023, 4, 3, 16, 21, 15, 219, DateTimeKind.Local).AddTicks(8121), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("560ec3bc-4a3e-43aa-af34-535c55458066"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$NwQNOmpaYni4aVJLWjVg7.A..fiBWbshJVfsmc96jRsw62y4mLgua", null, false, new DateTime(2023, 4, 3, 16, 21, 17, 441, DateTimeKind.Local).AddTicks(7503), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("5664b37f-0fdc-47cb-8bef-805f3a5a7bfc"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$tNmG.GivUjQ2vU5XFlPw7.fO8B7zYSkUt9nVC9aUiXzt3/mJbFMtq", null, false, new DateTime(2023, 4, 3, 16, 21, 6, 889, DateTimeKind.Local).AddTicks(2336), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("58288982-cfcb-4a54-b306-b9b5ea946707"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$WeUhfp0B5X83zFLH9s4xquLRnwREsYiNyeJhD.e/fYjIHHW2R530i", null, false, new DateTime(2023, 4, 3, 16, 21, 6, 631, DateTimeKind.Local).AddTicks(9742), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("5d9b2a93-7e48-485a-ab50-557ea5e34375"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$X/7u8VJuod.2y/8F53/i5OYhmJ/N1V8Mg2xaRPnBAp2eTQOdP9ole", null, false, new DateTime(2023, 4, 3, 16, 21, 7, 877, DateTimeKind.Local).AddTicks(9118), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("6259a070-f2a3-4729-91b5-03ed17282336"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$Bq/T6KPK5TZZnfYsD51ShuAmDlbb7w3h51FBPY5rUGRZ0QwHVD6eu", null, false, new DateTime(2023, 4, 3, 16, 21, 13, 557, DateTimeKind.Local).AddTicks(8894), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("62bff8e7-2691-4c03-9d6b-8f1651546244"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$CgfWFRtccc1Ts.Y4pwi2deauO5lySoLNxnarQ19bw8P36Nuet.US6", null, false, new DateTime(2023, 4, 3, 16, 21, 13, 91, DateTimeKind.Local).AddTicks(82), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("6366c676-c38a-4eb4-972d-0e823b550984"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$BLWwEfcGOCrV9kHVPM6QL.SrpLu.oLbgRhRhUTRXEm32ga1zo.T9e", null, false, new DateTime(2023, 4, 3, 16, 21, 17, 587, DateTimeKind.Local).AddTicks(42), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("649e89b9-3c73-4fe4-9663-536888132745"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$HQlcOyz.QPLESQqA8Bfd1.ylw5wcGq77CG6TdbBI9i3XiBZZ0MgJa", null, false, new DateTime(2023, 4, 3, 16, 21, 13, 415, DateTimeKind.Local).AddTicks(7796), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("64d8c189-eb0e-4461-be59-6591d1c04d3a"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$3aVrZlCRxVSQnuhFTH8JW.TeDpmV.bCWxFous38mdPvlwLhp/K2mK", null, false, new DateTime(2023, 4, 3, 16, 21, 10, 313, DateTimeKind.Local).AddTicks(8541), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("67b93a9d-e8f7-4338-a7aa-c0cfbf70a52a"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$THe5H3omb77WbkzctqYUheTRulS.Ask/PUz.NIM92dJuESVIOCInS", null, false, new DateTime(2023, 4, 3, 16, 21, 10, 932, DateTimeKind.Local).AddTicks(2910), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("68a8fed4-7d10-46be-b1a3-d14ac2c3fe5b"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$VXN6J.LnpjZvbfFZMlTXXeg2Qq4Q1Tyd53kaSUMheMAsTtbTWNEuq", null, false, new DateTime(2023, 4, 3, 16, 21, 6, 295, DateTimeKind.Local).AddTicks(4271), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("69671930-e4da-4aa0-a6e5-f454d5ba640c"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$QT9EU/NR/udanmes10JgLeH1FRrkfy.9ZXRU82F/y1gpnNTVvUnyu", null, false, new DateTime(2023, 4, 3, 16, 21, 16, 845, DateTimeKind.Local).AddTicks(3087), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("6f346de0-82e6-4caf-962e-632e8551851d"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$S/yc5QYB/g4uwqTz9YBQEuuFmRYYKrHut5KFS08PdvfHU3JK88qaK", null, false, new DateTime(2023, 4, 3, 16, 21, 17, 728, DateTimeKind.Local).AddTicks(2174), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("70c7ad5c-3c40-4441-a4c7-a74fb6dc8f0d"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$tktPmm6cYQiqHJTJUgo.Xe8fWIYC5BJAGKITZ6gWU5VMb2g5KxRmG", null, false, new DateTime(2023, 4, 3, 16, 21, 18, 259, DateTimeKind.Local).AddTicks(358), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("7151e788-579e-4ac7-9383-15f6422623c5"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$LOvcIn41qotauusGtIU2weuM5hryog4smURMiTkw.eqRZQ6rI0Pee", null, false, new DateTime(2023, 4, 3, 16, 21, 10, 764, DateTimeKind.Local).AddTicks(26), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("719954d3-4acb-4a8e-b094-b325add92d59"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$porE9ldqfV5GLR4QpZy5Tu5oYud8Lfuw6X4Ie278kwFAOwHqqf47K", null, false, new DateTime(2023, 4, 3, 16, 21, 10, 463, DateTimeKind.Local).AddTicks(5937), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("72395b47-f426-487f-a1dc-17eb0097c599"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$8jCpSfmPUcnLllqSL.5fc.LN0OfKo4CEHNY77MtNoRk/.OsfP6wL.", null, false, new DateTime(2023, 4, 3, 16, 21, 18, 554, DateTimeKind.Local).AddTicks(8857), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("73889c58-14f1-4082-ba37-300c4f67d1c5"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$U3k2urBqaYPxNQGKEVO/zuMdHr5SetI.lqWDoolvyNLO9hlvQso1a", null, false, new DateTime(2023, 4, 3, 16, 21, 8, 658, DateTimeKind.Local).AddTicks(5648), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("73bd10a6-2990-41bb-b068-cc0c44c885d0"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$JDj/sMooR2LLSe7r/WDs8.svYUZC0q9TQC8xuB8B3Agxk5S4MRmpC", null, false, new DateTime(2023, 4, 3, 16, 21, 3, 686, DateTimeKind.Local).AddTicks(5844), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("744ac1d0-f735-4eba-b83f-e80040a754ac"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$NeNj7XWwWtyIvf6HjzyW8.CXGD/D6jsqNqcgEoTgi7ENI7RMWMw/K", null, false, new DateTime(2023, 4, 3, 16, 21, 4, 232, DateTimeKind.Local).AddTicks(345), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("797d0c2b-bf54-4b42-85c6-dff86e7e9d5b"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$m84aEZao2i.wQ2R7Obfq2eE8rebN3lJqjdCJEJAoVWSCpR8/TTFEi", null, false, new DateTime(2023, 4, 3, 16, 21, 17, 287, DateTimeKind.Local).AddTicks(6856), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("7c914656-e65e-4ca9-b604-3767e204af10"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$24DnL0gnHPgH4I6hpl55s.AwsloniTVTt4wCQHSVNreznjfl3EmAO", null, false, new DateTime(2023, 4, 3, 16, 21, 16, 522, DateTimeKind.Local).AddTicks(52), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("7d1be694-926e-4b91-933f-aab9efa29655"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$obPJRQvE62RHGtRMbdrgB.a6Bf0sCVRLu7PaaTrMfYgK4tjK72HIK", null, false, new DateTime(2023, 4, 3, 16, 21, 6, 154, DateTimeKind.Local).AddTicks(5253), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("7d7a0a06-d83c-4051-b747-62a1504fefe9"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$0eQiFCseGT/wK3kZPnpyoeA6ctMKtsJiN7PhAU/Lyni74CYExl.dq", null, false, new DateTime(2023, 4, 3, 16, 21, 15, 545, DateTimeKind.Local).AddTicks(8173), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("7e7b57a7-2413-4ca2-a9cd-aecd901005d0"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$F1Am1ItsOVCsqNq3BjqFa..H3V4Dg8lLARWL7RxitGj.t1YaUtxMy", null, false, new DateTime(2023, 4, 3, 16, 21, 12, 281, DateTimeKind.Local).AddTicks(8394), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("7f025c39-9083-4f41-89b5-e68f0709c2f8"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$y5DvU49j4369DMDrHexqGe3nYp1JWhKB3hF7c/4al60y2RoU0FmBi", null, false, new DateTime(2023, 4, 3, 16, 21, 14, 468, DateTimeKind.Local).AddTicks(3585), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("80aeb788-7533-414c-ad24-89f0b3fad95a"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$U.Jl.5GZU7YI98/9CNiQ..djhvQUoxyNgy2x9kpAoeAtYilANXWxq", null, false, new DateTime(2023, 4, 3, 16, 21, 3, 349, DateTimeKind.Local).AddTicks(8991), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("83bf8558-ec45-4bdc-b185-5163f6f64c58"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$xiFdQKUng735hH79.0Qh3eW93AIItqoY.mvTNY9tOGMHLbKzPHGRO", null, false, new DateTime(2023, 4, 3, 16, 21, 13, 863, DateTimeKind.Local).AddTicks(3081), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("87446e51-62a6-48ef-a193-c787a1a0d625"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$rI9P9ht9dx4ee2fH5H.Wbeq8COKv2Hd/quEt5Iyk/SdogAFQnDAgS", null, false, new DateTime(2023, 4, 3, 16, 21, 3, 578, DateTimeKind.Local).AddTicks(5888), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("8dae8ad8-57b9-4649-9689-827753c072e2"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$kGq6MLuLDDbuD7OB1lqRs.H9JwmwoyLsDlNt7Jq74P4xw9k/ph98m", null, false, new DateTime(2023, 4, 3, 16, 21, 8, 507, DateTimeKind.Local).AddTicks(9012), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("8dc211e7-2feb-4be5-a59c-60de41897f7d"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$7hmLsx7FStc8gvxEGuS2TuPwGqoufHK25IbTFxFefBmVFraIOZMiC", null, false, new DateTime(2023, 4, 3, 16, 21, 4, 462, DateTimeKind.Local).AddTicks(4521), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("8e2472c0-c7ec-4462-a061-0beb9017391e"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$aiiPJDpDEvxxD99LuKPIAODV18IU.6ttEsQ24vWdkOW29y6ucSXbu", null, false, new DateTime(2023, 4, 3, 16, 21, 8, 99, DateTimeKind.Local).AddTicks(1566), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("9289036c-3333-4593-afeb-17fcc7c779e6"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$zcWD8wdKrKWRBlVqj6alqegzpxwjvRF3ryl47Yk4puPufuGDriwCe", null, false, new DateTime(2023, 4, 3, 16, 21, 19, 648, DateTimeKind.Local).AddTicks(515), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("967274bb-1c67-44d1-b16c-753d11024e5f"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$5KH4S.wg9knfzboJweNehOiD0nk9OTqh.GE/4EmxDAjXkGY8BZsEK", null, false, new DateTime(2023, 4, 3, 16, 21, 11, 974, DateTimeKind.Local).AddTicks(513), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("9728e0b6-9212-45fc-bfca-c67d0b26276c"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$inwiJRBEAaj2su84HaUrE.kbhOwkHRsWAoYapBiCf5AyzbSnc1mpG", null, false, new DateTime(2023, 4, 3, 16, 21, 3, 902, DateTimeKind.Local).AddTicks(1631), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("9c7e835e-93b5-454d-ad59-ad2309a12d3e"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$OLPGz20/NxWjLb5PqrxWfe53EwFy0xUsSAHaHFj5gc58ew7Vo5kte", null, false, new DateTime(2023, 4, 3, 16, 21, 5, 974, DateTimeKind.Local).AddTicks(6835), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("9f280d56-1b63-4fbc-9412-ef0a599a92fb"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$sCwwiFGl/0RTzKTE/O3S0uzTfrxkrP05SmnrMPfxC/yAe/2mXp4qW", null, false, new DateTime(2023, 4, 3, 16, 21, 6, 765, DateTimeKind.Local).AddTicks(7413), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("9ff3d1eb-e6fe-4a62-b54b-171dec1642c2"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$55BxWFDljJ5hSq2ZF8yQ1u6Tv1YVyKBWwjJyTmT5JcSIC10EPA4ZS", null, false, new DateTime(2023, 4, 3, 16, 21, 9, 333, DateTimeKind.Local).AddTicks(5788), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("a0e3f4b9-183b-4b61-a59b-ba02a1040000"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$C7M2fHAh0o78.tHg00g.4OK45W9yoqDhYhlPghLnNkeg8YWxmiNb2", null, false, new DateTime(2023, 4, 3, 16, 21, 15, 58, DateTimeKind.Local).AddTicks(9821), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("a1086b51-9a12-458e-befd-3ff175b76007"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$ckF8veYZlRfhXncNcPyIH.C4iCUBVx4lKqmASEbMW.aCXIMXleSo6", null, false, new DateTime(2023, 4, 3, 16, 21, 12, 777, DateTimeKind.Local).AddTicks(9971), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("a2a32f9d-2fae-4d05-b802-28a44a1c6f4c"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$F7w0pj/HFhz2jq2AL/6To.Uk6GPF7tW.fy64He2kE5717umCKel5y", null, false, new DateTime(2023, 4, 3, 16, 21, 16, 350, DateTimeKind.Local).AddTicks(9991), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("a3a6a9aa-29c4-4683-97a1-2b352115f96a"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$xhIaBnh28FpMRLo8cruBbOL7CY8JPmGz9VP4LApNSbsyC1Qs7nROa", null, false, new DateTime(2023, 4, 3, 16, 21, 5, 779, DateTimeKind.Local).AddTicks(1270), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("a9022d64-587e-490f-8643-55f26ab006da"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$xftH3TN2x.Wg.Yo/ZrOEduH7RgaJYvC4uQbaVk6p3o.wtLPzQV.rq", null, false, new DateTime(2023, 4, 3, 16, 21, 5, 482, DateTimeKind.Local).AddTicks(8038), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("ab43570d-db19-4181-952f-8e078d48160b"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$qO1yAAU3krdhTbyWxTiINO1sY.z9tSnnMCwzaM1hxeDyn1V9p.tTK", null, false, new DateTime(2023, 4, 3, 16, 21, 9, 108, DateTimeKind.Local).AddTicks(1483), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("b25357f7-275e-453c-b6cd-8440903a4466"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$no9d3icNkaVQlCHyLeD6M.1K5fBO6p3nJ88ioV3Amhb/v8kAZaq0W", null, false, new DateTime(2023, 4, 3, 16, 21, 14, 746, DateTimeKind.Local).AddTicks(7205), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("b40e2906-df84-46d4-ba2d-e466bcd87c0b"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$SD1k4Ai7Xa6S2X.Y4sZHt.84e8S1ZdRVsEtH2mjVE7foy8syxCjAy", null, false, new DateTime(2023, 4, 3, 16, 21, 15, 852, DateTimeKind.Local).AddTicks(9499), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("b4a7241e-6354-4d43-ad7b-1bf181b2166e"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$Hg8JpW48kItCgHRZQdlQducRtwnfRbZ1uy1BEVS6HpyLnHGYO8JSm", null, false, new DateTime(2023, 4, 3, 16, 21, 10, 618, DateTimeKind.Local).AddTicks(8209), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("b4e3c42f-04d3-420c-ad93-eee4a2468ab0"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$5xUeAY0geBfXcF2I8svjXeeByAvKfYllLakXsrU5oxYutXo7o0wOO", null, false, new DateTime(2023, 4, 3, 16, 21, 19, 384, DateTimeKind.Local).AddTicks(7599), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("b8224048-2dc1-45ef-a533-e3b27a65e6f1"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$J8t3z64U8s.DCvdFRV2IJeasWtPb4HH1Rds3w5j5Klo4oBg/TNz1y", null, false, new DateTime(2023, 4, 3, 16, 21, 5, 234, DateTimeKind.Local).AddTicks(7098), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("b911f09f-13aa-4fad-992f-9d26203e2738"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$q7oyrgaTsnqrDvCXE9ybWu3K5vMZUZWgDm4/UA0Klus60aNorcz2W", null, false, new DateTime(2023, 4, 3, 16, 21, 19, 115, DateTimeKind.Local).AddTicks(1411), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("b93cf03d-5def-4e01-8918-4fc1f1eaa4be"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$3R5jJZMh1yEqUey1E6/50./BLzea8GM3ZRE.AaEOcDromEWXclQIO", null, false, new DateTime(2023, 4, 3, 16, 21, 4, 585, DateTimeKind.Local).AddTicks(4375), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("baae6120-39f6-45b8-bcf6-a439ee8e511e"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$iU.aKFv8nFEYC3zJWx7RMuafuiDH0pjNbE6O73/l92ji2Fb7vzd7e", null, false, new DateTime(2023, 4, 3, 16, 21, 18, 868, DateTimeKind.Local).AddTicks(7596), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("bf565fc3-849c-4736-b7ab-91134cba20b9"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$tl8TswDZMEr4xzvN1t2G6.LdOQZSFrbro..oEHNOj2zFMZwM0rEUi", null, false, new DateTime(2023, 4, 3, 16, 21, 4, 125, DateTimeKind.Local).AddTicks(937), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("bff91fb9-3e93-4b6e-a3f9-8ec853fae01e"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$sP4AeIuXKKTr.13hFVj9luwBdFKykXOMUZgNU8k9tAbrpGsFYQdyu", null, false, new DateTime(2023, 4, 3, 16, 21, 12, 612, DateTimeKind.Local).AddTicks(612), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("c087db4c-d065-4b08-b9ea-adbb14345960"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$gLPMLI/k7e5YwFMbd1RRUuz134EVB5F45eczr1dB5h1qC42Pyfqz2", null, false, new DateTime(2023, 4, 3, 16, 21, 3, 794, DateTimeKind.Local).AddTicks(3325), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("c308f446-3753-4d77-a8bc-d6272414905b"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$.Jctb367fiKtT816LhOmWOwxdX78odgtSqsupH7MNQLBZl8iZEPHq", null, false, new DateTime(2023, 4, 3, 16, 21, 11, 451, DateTimeKind.Local).AddTicks(143), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("c473f1bc-2ce3-49c7-a19b-e88ec614192c"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$FoVH9kORemAx4nwZiKNIUugm3lOCGQnBYgRk51ajle0TiLsL3V/4.", null, false, new DateTime(2023, 4, 3, 16, 21, 18, 17, DateTimeKind.Local).AddTicks(3365), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("c9979044-0499-49b0-a21d-1e6aa63f3035"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$JR.Y1nfXkwY2F7j0I.aQJuUMBe8ud1VRjNxBb930K7PoN//xTaJe2", null, false, new DateTime(2023, 4, 3, 16, 21, 10, 92, DateTimeKind.Local).AddTicks(8302), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("cc8f0bc8-4ae5-4e8a-903e-547b39ef823a"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$3LwWIQE7vQl6c1JRr3C0MOrsdYyn3MM7z3XpSzAIYrlEJWLzuqRmS", null, false, new DateTime(2023, 4, 3, 16, 21, 19, 759, DateTimeKind.Local).AddTicks(7148), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("ce6b7d94-282b-48d0-b3e8-91ae7059cc45"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$x2isaZi/W7WQoiAUUyjJruZdIHhpVsn6pir5xpEzNp6s6QMAX0f96", null, false, new DateTime(2023, 4, 3, 16, 21, 15, 718, DateTimeKind.Local).AddTicks(8629), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("d04716f9-46fe-436a-ad9a-23b8ed4512ba"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$2xMq6IDaG0ZMfSlyxd8QV.nxSNM/W2XNq8kov29soELInG5Zcavfm", null, false, new DateTime(2023, 4, 3, 16, 21, 4, 703, DateTimeKind.Local).AddTicks(676), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("d0b03e19-75e1-42e3-acd9-6663723b4494"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$n./f580S5PhCue4Vq4.MsOhWLGKIPRAIUn5IywexURF7OMDFMz3eO", null, false, new DateTime(2023, 4, 3, 16, 21, 16, 696, DateTimeKind.Local).AddTicks(8905), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("d20d5b7b-f266-44c8-9ce0-00291db91ed4"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$MMcA/trOIWK4KttOB3zw9uiYTJun1RGhUpA0JVpqfzJcG4GLkKIbu", null, false, new DateTime(2023, 4, 3, 16, 21, 11, 85, DateTimeKind.Local).AddTicks(4169), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("d2a2d72e-f468-4426-be47-d670b12ba5a6"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$AcWP4IT4JUdebF7ELVbq8OlYP3poO1AigmJtAfOx0Q2DsL0OWOQOu", null, false, new DateTime(2023, 4, 3, 16, 21, 11, 641, DateTimeKind.Local).AddTicks(4693), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("d5ac4cb3-8aae-428c-98d8-4d9f91d48c72"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$9wt0ClnbplHBpC1ib9zYherz/ycP9Wf.OAE5B2HD.b1ylIQJEdW2G", null, false, new DateTime(2023, 4, 3, 16, 21, 7, 133, DateTimeKind.Local).AddTicks(2832), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("da0ac5ce-8b77-491e-af52-5bbac2dc0b63"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$HVG./MyK3oK0hAapWGT3Jug8v8HnBsaV4WzTiLW6kuwZHOCDzB0A2", null, false, new DateTime(2023, 4, 3, 16, 21, 5, 609, DateTimeKind.Local).AddTicks(8385), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("dc101461-94a6-425e-81c0-0ae4843721ac"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$lGgNlmYuXy5.ogt8ifIoH..c7jOuqdaFvUsIJGrtalVDSYrrxIkVy", null, false, new DateTime(2023, 4, 3, 16, 21, 9, 510, DateTimeKind.Local).AddTicks(7860), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("dc5b6e98-2b0b-4a57-9047-f51e2731f549"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$Hb3eDNSHJ220FY9tq6oyKOxdO.pR0brkoZS0WhfnPLLSfS5LHSPOS", null, false, new DateTime(2023, 4, 3, 16, 21, 14, 138, DateTimeKind.Local).AddTicks(1699), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("ded71a54-d53e-4ee3-b94c-e7c411687537"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$eQbwp6RUM0EkxceIPRtgK.fR4SppmZTnry6ykaiwPL4g97rPU2.S6", null, false, new DateTime(2023, 4, 3, 16, 21, 2, 934, DateTimeKind.Local).AddTicks(6374), " Ass min", null, null, "0966416708", -772000, "admin" },
                    { new Guid("e1436ea7-9d71-4673-8be4-ce40d2a1785b"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$BFBYs/WzUmTUae5KzQg3yuqvQHyWu3QvX6UNoasu.4vXfKgYI.wvy", null, false, new DateTime(2023, 4, 3, 16, 21, 17, 867, DateTimeKind.Local).AddTicks(3110), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("e2f501f1-45fd-4686-9a21-0eef9c6554d7"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$43SP3.5yCJY72er0IkuR6OtFJaoF5z1Fn0hhfYZqyn7yXm4.bnCQy", null, false, new DateTime(2023, 4, 3, 16, 21, 14, 600, DateTimeKind.Local).AddTicks(2664), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("e6f612ab-51b1-4f6e-8226-ac6cf2fde5be"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$KZz6OAyMocUxhh7FSvKc0Ozs2CRCxSBVSW0aHk8mXJzjIxMe8xLiC", null, false, new DateTime(2023, 4, 3, 16, 21, 13, 246, DateTimeKind.Local).AddTicks(8905), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("ebc1e661-dfe6-404c-8d24-3b8a904f267c"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$6IvniQd3sK2OS01h.MjiIOczv0Bx6b9hV9Zve/767GHaSn.KMR19C", null, false, new DateTime(2023, 4, 3, 16, 21, 12, 128, DateTimeKind.Local).AddTicks(1315), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("ec9a7e2c-afe5-4067-88e5-b74194264964"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$3dp1ljGbVWUPv1/B4vM0Ju52M3oW/tKzdk5XmnCzXcBVaXCBGPUSu", null, false, new DateTime(2023, 4, 3, 16, 21, 3, 62, DateTimeKind.Local).AddTicks(9679), " Nguyen Van", null, null, "0966416708", -772000, "customer" },
                    { new Guid("f1aa5fde-3c90-4ede-940a-6fddbff2b988"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$qgqmjACBmsAaAPa9xVS1kuWnZk3LAHJmY05znDOZUNRUhrBzsPqIq", null, false, new DateTime(2023, 4, 3, 16, 21, 18, 695, DateTimeKind.Local).AddTicks(5264), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("f42dba4c-a7f1-4d66-aa62-3ff53cf4f523"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$EMusEmhxeMkAT38R0z37xO5xrQkR/7F8Ash1DlaaBPljSWsn8u9JG", null, false, new DateTime(2023, 4, 3, 16, 21, 4, 9, DateTimeKind.Local).AddTicks(6048), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("f63d575f-033b-47d8-a430-8c6384e75dec"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$TbXlhaB1Efpvcbh44xchRujYM3OobHDjQtEmh.rjQrqxXbcOdjK4W", null, false, new DateTime(2023, 4, 3, 16, 21, 6, 489, DateTimeKind.Local).AddTicks(5232), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("f7805e01-de84-4720-b84d-852514858fbf"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$kfGZHsemCuZJh2rqLUeF6.uuUBfj4g/2tIezLFFLcnfecgUrIFsI2", null, false, new DateTime(2023, 4, 3, 16, 21, 20, 167, DateTimeKind.Local).AddTicks(7759), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("f87f6ba3-2945-4148-919b-d611d335d60a"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$LyzG8sKWfV3biVpOHoJPk.8JTLwMEy9bll1pMZ37XJ2K2QEhbNe8S", null, false, new DateTime(2023, 4, 3, 16, 21, 8, 812, DateTimeKind.Local).AddTicks(3846), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("fd13ee33-b4f9-42f5-a906-14a061065e66"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$QxIs0Y1gusbks1.6OO2gBOa/JmdE2VILisu9t9m5rZAEifaXOIxfe", null, false, new DateTime(2023, 4, 3, 16, 21, 7, 525, DateTimeKind.Local).AddTicks(6728), "Harnott", null, null, "00039497181", 2, "mharnottu" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_LastModifyByID",
                table: "CarModels",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarModelID",
                table: "Cars",
                column: "CarModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarOwnerID",
                table: "Cars",
                column: "CarOwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Dashboards_LastModifyByID",
                table: "Dashboards",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_FeedbackByID",
                table: "Feedbacks",
                column: "FeedbackByID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ParkingID",
                table: "Feedbacks",
                column: "ParkingID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_FeedbackID",
                table: "Images",
                column: "FeedbackID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ParkingID",
                table: "Images",
                column: "ParkingID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_SlotID",
                table: "Images",
                column: "SlotID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserID",
                table: "Images",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingDetails_CarID",
                table: "ParkingDetails",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingDetails_LastModifyByID",
                table: "ParkingDetails",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingDetails_SlotID",
                table: "ParkingDetails",
                column: "SlotID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingDetails_TimeFrameID",
                table: "ParkingDetails",
                column: "TimeFrameID");

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_DashboardID",
                table: "Parkings",
                column: "DashboardID");

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_OwnerID",
                table: "Parkings",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ParkingID",
                table: "Requests",
                column: "ParkingID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestbyID",
                table: "Requests",
                column: "RequestbyID");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_CarModelID",
                table: "Slots",
                column: "CarModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_LastModifyByID",
                table: "Slots",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ParkingID",
                table: "Slots",
                column: "ParkingID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeFrames_LastModifyByID",
                table: "TimeFrames",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeFrames_ParkingID",
                table: "TimeFrames",
                column: "ParkingID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ImageID",
                table: "Users",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MembershipPackageID",
                table: "Users",
                column: "MembershipPackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ParkingID",
                table: "Users",
                column: "ParkingID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_Users_LastModifyByID",
                table: "CarModels",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_CarOwnerID",
                table: "Cars",
                column: "CarOwnerID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dashboards_Users_LastModifyByID",
                table: "Dashboards",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Parkings_ParkingID",
                table: "Feedbacks",
                column: "ParkingID",
                principalTable: "Parkings",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Users_FeedbackByID",
                table: "Feedbacks",
                column: "FeedbackByID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Parkings_ParkingID",
                table: "Images",
                column: "ParkingID",
                principalTable: "Parkings",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Slots_SlotID",
                table: "Images",
                column: "SlotID",
                principalTable: "Slots",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Users_UserID",
                table: "Images",
                column: "UserID",
                principalTable: "Users",
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
                name: "FK_CarModels_Users_LastModifyByID",
                table: "CarModels");

            migrationBuilder.DropForeignKey(
                name: "FK_Dashboards_Users_LastModifyByID",
                table: "Dashboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Users_FeedbackByID",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Users_UserID",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Parkings_Users_OwnerID",
                table: "Parkings");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Users_LastModifyByID",
                table: "Slots");

            migrationBuilder.DropTable(
                name: "ParkingDetails");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "TimeFrames");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "MembershipPackages");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Parkings");

            migrationBuilder.DropTable(
                name: "Dashboards");
        }
    }
}
