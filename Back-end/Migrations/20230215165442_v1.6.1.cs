using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class v161 : Migration
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
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "ParkingDetail",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeFrameID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ParkingDetail_Cars_CarID",
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
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DashboardID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsLegal = table.Column<bool>(type: "bit", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LON = table.Column<double>(type: "float", nullable: false),
                    LAT = table.Column<double>(type: "float", nullable: false)
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
                    MembershipPackageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
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
                    CarID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TypeOfSlot = table.Column<int>(type: "int", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Slots_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
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
                name: "TimeFrame",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParkingsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeFrame", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TimeFrame_Parkings_ParkingsID",
                        column: x => x.ParkingsID,
                        principalTable: "Parkings",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TimeFrame_Users_LastModifyByID",
                        column: x => x.LastModifyByID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_LastModifyByID",
                table: "CarModels",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarModelID",
                table: "Cars",
                column: "CarModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_LastModifyByID",
                table: "Cars",
                column: "LastModifyByID");

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
                name: "IX_ParkingDetail_CarID",
                table: "ParkingDetail",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingDetail_LastModifyByID",
                table: "ParkingDetail",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingDetail_SlotID",
                table: "ParkingDetail",
                column: "SlotID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingDetail_TimeFrameID",
                table: "ParkingDetail",
                column: "TimeFrameID");

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_DashboardID",
                table: "Parkings",
                column: "DashboardID");

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_LastModifyByID",
                table: "Parkings",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ParkingID",
                table: "Requests",
                column: "ParkingID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestbyID",
                table: "Requests",
                column: "RequestbyID");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_CarID",
                table: "Slots",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_LastModifyByID",
                table: "Slots",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ParkingID",
                table: "Slots",
                column: "ParkingID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeFrame_LastModifyByID",
                table: "TimeFrame",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeFrame_ParkingsID",
                table: "TimeFrame",
                column: "ParkingsID");

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
                name: "FK_Cars_Users_LastModifyByID",
                table: "Cars",
                column: "LastModifyByID",
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
                name: "FK_ParkingDetail_Slots_SlotID",
                table: "ParkingDetail",
                column: "SlotID",
                principalTable: "Slots",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetail_TimeFrame_TimeFrameID",
                table: "ParkingDetail",
                column: "TimeFrameID",
                principalTable: "TimeFrame",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingDetail_Users_LastModifyByID",
                table: "ParkingDetail",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Parkings_Users_LastModifyByID",
                table: "Parkings",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dashboards_Users_LastModifyByID",
                table: "Dashboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Parkings_Users_LastModifyByID",
                table: "Parkings");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "ParkingDetail");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "TimeFrame");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MembershipPackages");

            migrationBuilder.DropTable(
                name: "Parkings");

            migrationBuilder.DropTable(
                name: "Dashboards");
        }
    }
}
