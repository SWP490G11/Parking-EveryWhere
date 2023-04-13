using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver19 : Migration
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
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipPackages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Success = table.Column<bool>(type: "bit", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VnPayResponseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactorID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discript = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ParkingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickUpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
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
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Users_Transactions_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transactions",
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
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.ID);
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

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model" },
                values: new object[,]
                {
                    { new Guid("0929fb27-75ad-4bf7-8148-7e1f7cf8f2be"), "Xe 4 chỗ du lịch", null, null, "Sedan" },
                    { new Guid("11fafeb8-9d71-4f2b-97bd-fd03488a3572"), "Xe 7 chỗ", null, null, "SUV7" },
                    { new Guid("66e7ba62-b5d8-49d5-b7ac-1950c068cf99"), "Xe van con", null, null, "Minivan" },
                    { new Guid("9c752d6c-9741-4a8d-8de1-6f232be5ae50"), "Xe 2 khoang", null, null, "Mini" },
                    { new Guid("b443bb3f-a14a-4b02-b0b6-64a8f285e0a8"), "Xe bán tải", null, null, "Pickup" },
                    { new Guid("d2318e1a-a521-49e9-962c-24aeb5a8d617"), "xe 5 chỗ", null, null, "SUV5" }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("606f91fe-97c4-4d3c-988b-04ab4be6f079"), "1 Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L, "Long", 130000.0 },
                    { new Guid("9a4040ce-2098-4869-a63b-47472dee24b7"), "Half Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, "Medium", 70000.0 },
                    { new Guid("f701d6a6-3e0f-4897-9919-7e72cc32f90f"), "Short time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, "Short", 40000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "ImageID", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "TransactionID", "UserName" },
                values: new object[,]
                {
                    { new Guid("02b827c5-1e12-4513-8511-6c577033f5d6"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$ZSbphcsoWLd0GiMfh04cUe14XGFb2z4UsnYb.bZ0qox8NWx4xtG3e", null, false, new DateTime(2023, 4, 14, 1, 28, 33, 976, DateTimeKind.Local).AddTicks(6282), "Webling", null, null, "0390471753", 2, null, "bwebling1s" },
                    { new Guid("0455e5d4-6688-404f-bd81-a5434693a490"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$KOljGtA1PKVkwJpgWybTcOpCxMtf29qu4QYJhvRG8GYRBQ6fVLT92", null, false, new DateTime(2023, 4, 14, 1, 28, 33, 158, DateTimeKind.Local).AddTicks(5622), "Berks", null, null, "04613021719", 2, null, "fberks1l" },
                    { new Guid("04af4219-0742-437d-ae32-ac0608330b1b"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$BGhEYtgVZhQN/5YEl6d01.Nju7TfvOyUBHPfPASbFACh6hUY6CdhO", null, false, new DateTime(2023, 4, 14, 1, 28, 31, 680, DateTimeKind.Local).AddTicks(2351), "Martugin", null, null, "02340159874", 2, null, "smartugin19" },
                    { new Guid("0555023a-d279-4546-b9f0-0a5f514c1c38"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$QsdEWGyqgFbSgwVpGcIkHeScnKBc11gHWjTWTI55DHRRNi9NNiZtu", null, false, new DateTime(2023, 4, 14, 1, 28, 32, 746, DateTimeKind.Local).AddTicks(3378), "Mackieson", null, null, "07046670689", 2, null, "smackieson1i" },
                    { new Guid("095994c3-b10e-4882-a9fe-a7a86a1f01ae"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$gbrYRXeelMyjp5oXJiK.8uTMq1QEq5ceAcwARD.c4Qy4EirT3XTUS", null, false, new DateTime(2023, 4, 14, 1, 28, 34, 82, DateTimeKind.Local).AddTicks(3250), "Trippitt", null, null, "00615614760", 1, null, "atrippitt1t" },
                    { new Guid("0b9d41f8-4b57-4935-b0fb-d8684292652b"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$Ly8C55nHjPVaoIYAlUbLLeXyKtkSMyaWYcEyqbNwOhxeqWEAzR.gu", null, false, new DateTime(2023, 4, 14, 1, 28, 30, 437, DateTimeKind.Local).AddTicks(296), "Springham", null, null, "00834111266", 1, null, "sspringhamy" },
                    { new Guid("0ff74650-bb9f-442b-9978-2f2723b96dd1"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$ByFpBi.QjOl16TizHUYgUO2.EBNwIRh9167Xy4laPhh3PB8UTF/D2", null, false, new DateTime(2023, 4, 14, 1, 28, 29, 869, DateTimeKind.Local).AddTicks(3938), "Gostick", null, null, "05617299637", 1, null, "bgostickt" },
                    { new Guid("135657c2-508a-4f42-b753-a627807db235"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$fj/RvmeDPkioutGkG/abTuB7hCjNFwQcAnLoHUYKinrljvkX5iCOO", null, false, new DateTime(2023, 4, 14, 1, 28, 30, 795, DateTimeKind.Local).AddTicks(548), "Dreossi", null, null, "03724370545", 2, null, "cdreossi11" },
                    { new Guid("13720ae1-7031-44cb-861d-d41fa53ef23a"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$yoFtvjDzItrn9gV2Vd47G.bxkS3rcrrniaw7sItxPu19sBXqUYOJC", null, false, new DateTime(2023, 4, 14, 1, 28, 35, 37, DateTimeKind.Local).AddTicks(820), "Latan", null, null, "07949258154", 1, null, "rlatan21" },
                    { new Guid("14035060-948c-49cd-869d-44bcc604f711"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$j6qgCU5LevKHvCUP0J33Y.V9wy.yR.wTmilBYVXNWQxur9i.ZG5ne", null, false, new DateTime(2023, 4, 14, 1, 28, 32, 525, DateTimeKind.Local).AddTicks(4276), "Gareisr", null, null, "07314447051", 2, null, "tgareisr1g" },
                    { new Guid("14aecda4-7d6a-45d9-92f2-546013d966ce"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$ySpBH0XpZF5IKdqPL7LzB.5gvTsZp.pUubqCmdBHF1V1tjxYZ2b7O", null, false, new DateTime(2023, 4, 14, 1, 28, 37, 719, DateTimeKind.Local).AddTicks(7294), "Vernall", null, null, "05157407415", 1, null, "overnall2p" },
                    { new Guid("20a98cec-5ad1-42c0-a699-22264c2ec288"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$a1l9VJorYM6t63uVskUmwegcMw4UpZWtm0R/15pleD7GMI7m2mch.", null, false, new DateTime(2023, 4, 14, 1, 28, 33, 282, DateTimeKind.Local).AddTicks(6879), "Margrie", null, null, "0153784673", 1, null, "cmargrie1m" },
                    { new Guid("2201a057-a630-4041-b8a9-640fd89bcbfc"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$ErHuC91arQW1mV/KPNOhRustyMAvYlbWYbi6GbOnQDsEbgnguFfrO", null, false, new DateTime(2023, 4, 14, 1, 28, 34, 546, DateTimeKind.Local).AddTicks(3874), "Stranger", null, null, "03239623484", 2, null, "gstranger1x" },
                    { new Guid("240e0c41-5a61-43d1-9420-8dec197c5825"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$bkjS8oL4AOtz2e5XydvEquHdD06nuTUxFJrbj1nhuHp2a7aLQEv/S", null, false, new DateTime(2023, 4, 14, 1, 28, 38, 906, DateTimeKind.Local).AddTicks(9454), "Beamson", null, null, "07242980517", 1, null, "kbeamson2z" },
                    { new Guid("257fc13a-3ec3-4f79-927d-5d1f6a94e935"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$KJG6nn5ioB4Quz3xPvJvFuZAKKvCyEg3H/IW3KagZucrIkQnR4jjW", null, false, new DateTime(2023, 4, 14, 1, 28, 31, 454, DateTimeKind.Local).AddTicks(3403), "McMechan", null, null, "0613503781", 2, null, "mmcmechan17" },
                    { new Guid("25840863-ef59-4384-a8e4-f166d2f48f2c"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$7.lk/wxCgBLHAmOzznmGM..rae8GPzQU8/8oVDcAKzbdhTF6wbkR6", null, false, new DateTime(2023, 4, 14, 1, 28, 32, 372, DateTimeKind.Local).AddTicks(1894), "Mattam", null, null, "0865586458", 2, null, "emattam1f" },
                    { new Guid("26f01cc6-5228-4ddc-b66e-9eae52e82678"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$xAFGLgwolY2ZCo/nZMiqV./C0XCu5NkgBhZoc8AcOcyMrwdV8RHrO", null, false, new DateTime(2023, 4, 14, 1, 28, 29, 312, DateTimeKind.Local).AddTicks(598), "Goddman", null, null, "00110582594", 2, null, "kgoddmano" },
                    { new Guid("2a37b01c-5861-4c8b-8837-f54d14641be6"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$AlCHgdWpZXthAYtsrUhOvuAUssKnzshKKNm29yAiRve9NQ6RYdtg6", null, false, new DateTime(2023, 4, 14, 1, 28, 35, 839, DateTimeKind.Local).AddTicks(4192), "Canti", null, null, "07734012207", 1, null, "gcanti28" },
                    { new Guid("2e4f105e-973d-442b-84a8-35a1bfa807f2"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$zZlAZOyd7URs6JyvTg1jq.gSRUr/6sLbww5K2UwTdQ.5GL5s2MKvK", null, false, new DateTime(2023, 4, 14, 1, 28, 38, 96, DateTimeKind.Local).AddTicks(7586), "Yuille", null, null, "00670067189", 2, null, "ryuille2s" },
                    { new Guid("2f418f29-286f-4d1e-a3cc-61909afae685"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$RvZuYuB1n4aMRDj3XOZLA.f2yeniO728AE1i8DKlstALWs6La7JmG", null, false, new DateTime(2023, 4, 14, 1, 28, 28, 979, DateTimeKind.Local).AddTicks(8593), "McCloy", null, null, "08418620623", 2, null, "tmccloyl" },
                    { new Guid("309620fc-c467-411e-8070-3928a07d7ebd"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$RGaIw2J.hX0lqGgSTKy65.Q7blIVW557ERrFV2mX0pBsWd7TyClXq", null, false, new DateTime(2023, 4, 14, 1, 28, 32, 250, DateTimeKind.Local).AddTicks(4110), "Laidel", null, null, "06837677860", 2, null, "blaidel1e" },
                    { new Guid("3151870c-2b25-4d79-82b1-067c882cf218"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$6xvhEJn2azia/K5njYCVI.wwQRNKi9Eg3x5Lld8Y1./ZvC6xpSGfS", null, false, new DateTime(2023, 4, 14, 1, 28, 29, 200, DateTimeKind.Local).AddTicks(4371), "Skirvin", null, null, "0614302061", 1, null, "mskirvinn" },
                    { new Guid("318aef38-ae4a-4843-812f-2fab1459a191"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$OugR9kGw5F/hQ25RF4LRoe32.nmG9FoDly8eCk6ZAk2NAwN2kVlfm", null, false, new DateTime(2023, 4, 14, 1, 28, 37, 848, DateTimeKind.Local).AddTicks(9910), "Baldacchino", null, null, "05380625199", 1, null, "mbaldacchino2q" },
                    { new Guid("3232b8e8-536a-4116-bbf7-4466b509d7d9"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$qjwGxva/CCpd5qNgiHrPkOkJQLLRvLCXYy7VbsfqGjly0B5fkw70y", null, false, new DateTime(2023, 4, 14, 1, 28, 34, 670, DateTimeKind.Local).AddTicks(651), "Batrip", null, null, "0734926905", 1, null, "abatrip1y" },
                    { new Guid("35e668d5-50d2-4ba7-bd3f-1e880b9f128e"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$5fDZHc7fc88IflnZZHOo8O3c/jbt1RnHP6.a33RsQFQMvdHA71vDC", null, false, new DateTime(2023, 4, 14, 1, 28, 39, 253, DateTimeKind.Local).AddTicks(8688), "Prater", null, null, "0629137900", 1, null, "tprater32" },
                    { new Guid("3d49d6e8-676e-4993-9d2f-7481d56ab866"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$.NjpdTwrElJ.UZcc1TPLDOp7SpIAzSAvF/IZR8D5Vg6ev0q8x0VGW", null, false, new DateTime(2023, 4, 14, 1, 28, 30, 230, DateTimeKind.Local).AddTicks(7842), "Lere", null, null, "04037990815", 1, null, "rlerew" },
                    { new Guid("40b7c254-e5cb-4170-b7ff-270cd066406c"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$AYiFDtzSblpnRQ4UYebFzOMC.c3gWVscLy.09PB4Sav0Q909.w8OS", null, false, new DateTime(2023, 4, 14, 1, 28, 31, 220, DateTimeKind.Local).AddTicks(8111), "Filipchikov", null, null, "0663461504", 2, null, "afilipchikov15" },
                    { new Guid("40ea3559-a122-410d-bb64-e6f537015e70"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$.5C4bQgiMgIFMCcORC4vK.4gZXv6BbH1SakZzv6dy3YYUOSx4g87i", null, false, new DateTime(2023, 4, 14, 1, 28, 39, 41, DateTimeKind.Local).AddTicks(7229), "Gerrish", null, null, "04944713025", 1, null, "rgerrish30" },
                    { new Guid("446a8be9-9985-4d28-bfcb-8bc510c540c0"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$THQ1ba5zPSSZlYqtrCT1p.mxcKfuBbYW0fTh2zNVBcRX7gUUeyBG2", null, false, new DateTime(2023, 4, 14, 1, 28, 36, 386, DateTimeKind.Local).AddTicks(9730), "Faber", null, null, "08586159848", 2, null, "afaber2d" },
                    { new Guid("44a4f143-529b-4423-bf11-ada27e776263"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$JDPd78kEjC4zkCA1y/uwc.E32dc2/f89xbO3T9RCga2sjTxU8nz8S", null, false, new DateTime(2023, 4, 14, 1, 28, 32, 882, DateTimeKind.Local).AddTicks(9583), "Shufflebotham", null, null, "0960301131", 2, null, "pshufflebotham1j" },
                    { new Guid("4691f073-0193-4099-9a82-80a311c5fdce"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$GnkeTBzeXfLk5q4YlNtNxua.Ow.lpiABPrwGAlJ2dCGnqgUObTumO", null, false, new DateTime(2023, 4, 14, 1, 28, 36, 866, DateTimeKind.Local).AddTicks(4761), "Oubridge", null, null, "0429461131", 2, null, "eoubridge2h" },
                    { new Guid("475b64b9-b718-43d6-b1b5-f8422a79f5b8"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$vXUUyxK5/v52JC7dOwRd9O7IHq.YB..zu0RzzYIXCKqYOB.J3.vwO", null, false, new DateTime(2023, 4, 14, 1, 28, 31, 119, DateTimeKind.Local).AddTicks(4780), "O'Connor", null, null, "0750854688", 1, null, "aoconnor14" },
                    { new Guid("47d7392a-34d1-4b0f-b6b8-caa6422e8982"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$hs42XPhoD1XcoV/XzFeiHuMs6FRSZKk8Qn0TkL2cYa4i6UQdlFYlS", null, false, new DateTime(2023, 4, 14, 1, 28, 33, 27, DateTimeKind.Local).AddTicks(4813), "Droghan", null, null, "0910618733", 2, null, "kdroghan1k" },
                    { new Guid("49d702a8-77ac-4e1c-a509-2e2278ffff60"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$/CV/IOKXNEstAiRemAj8j.HsN5S75gjfzBkk9wVej8.ahbUxYjS8i", null, false, new DateTime(2023, 4, 14, 1, 28, 36, 66, DateTimeKind.Local).AddTicks(9405), "Ainscow", null, null, "0878444767", 1, null, "fainscow2a" },
                    { new Guid("4bf30da9-f909-4260-ad7f-e7f63adbfd32"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$8dLrHlOXgLfRQfchUSxr1ejJASnTrzMcuVWmJlWituh4kOjCdzwfG", null, false, new DateTime(2023, 4, 14, 1, 28, 36, 500, DateTimeKind.Local).AddTicks(6190), "Izhakov", null, null, "05872358652", 1, null, "cizhakov2e" },
                    { new Guid("4cf0c69c-c8e6-44cf-a08f-7b9160aedbfa"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$6V2v2NbMd//.w9xVDLfpoOYife.vVzuYgJVKYoLjbIYkhxLnKivLO", null, false, new DateTime(2023, 4, 14, 1, 28, 36, 629, DateTimeKind.Local).AddTicks(3215), "Eliassen", null, null, "06497524328", 1, null, "jeliassen2f" },
                    { new Guid("58fea790-35ed-48ec-9e57-d0b369f05cf6"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$aoABr4o6Y09vHbDsjZwqWOhvqLS8KOTzm13TjIP6ih0ImU3vf/cJO", null, false, new DateTime(2023, 4, 14, 1, 28, 35, 494, DateTimeKind.Local).AddTicks(7633), "Lannen", null, null, "04000508789", 1, null, "dlannen25" },
                    { new Guid("5ac58e85-4223-4ec7-96d0-2f57b9d2723a"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$bFfwKPNer9favPWlJJARiehUoo0BmQAMERT2BN4w2HT2PvyleMHW6", null, false, new DateTime(2023, 4, 14, 1, 28, 29, 556, DateTimeKind.Local).AddTicks(3745), "Bolver", null, null, "0361641052", 2, null, "bbolverq" },
                    { new Guid("604fd2f1-5f21-44e6-8ac9-bff8cb21cdad"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$5MDSKxjeL/Qt7WmaFSVH7.eN6OECnjVFHpCxLltJeagQ0h6vEx4FS", null, false, new DateTime(2023, 4, 14, 1, 28, 34, 299, DateTimeKind.Local).AddTicks(7736), "Zamorano", null, null, "0619225384", 2, null, "czamorano1v" },
                    { new Guid("609555b7-ac14-4809-9e5d-3b57eb491e98"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$cn0t7rQ.tsZrKG1EzrwqmOf208wkeNgYVOj1SLexHOACv5WhW6rQq", null, false, new DateTime(2023, 4, 14, 1, 28, 37, 975, DateTimeKind.Local).AddTicks(3282), "Iacovacci", null, null, "0770070777", 1, null, "siacovacci2r" },
                    { new Guid("63ccdafa-8801-4a5e-97f1-8cf8cc7c6d63"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$Y/2uOJK8uxvOXYxvDEzu/OtgYI85Z4HI58KXfc4fDDXe2/FFrBMmy", null, false, new DateTime(2023, 4, 14, 1, 28, 28, 19, DateTimeKind.Local).AddTicks(7578), " Nguyen Van", null, null, "0966416708", 1, null, "customer" },
                    { new Guid("655560ba-ce79-4288-86ab-4eab6f1294e9"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$4phEAtUgxvP75Va7oyfECeAnPw3q1OPNhoyI2Xi7TiFrnM4yCidXa", null, false, new DateTime(2023, 4, 14, 1, 28, 35, 383, DateTimeKind.Local).AddTicks(5463), "Swanson", null, null, "09572022187", 1, null, "gswanson24" },
                    { new Guid("6ba62fcf-4902-49e2-ade0-7dada985b01b"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$mLTpRgX0PPXdtHX3rCQDUuJdp0mXYq5z4bfz3QqLUMpGiPst1LsXa", null, false, new DateTime(2023, 4, 14, 1, 28, 32, 117, DateTimeKind.Local).AddTicks(9673), "MacGorrie", null, null, "0259328059", 2, null, "kmacgorrie1d" },
                    { new Guid("6c4f1607-f270-4baf-9762-1a44ab906677"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$n106.FSgR1YzE8bHh0hREORN4Ul9xc7uZgc8L56h24bBVKHFdm/YW", null, false, new DateTime(2023, 4, 14, 1, 28, 34, 887, DateTimeKind.Local).AddTicks(7134), "Oliffe", null, null, "0002143579", 1, null, "koliffe20" },
                    { new Guid("6f8db362-8731-4606-a210-be4e482a46df"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$FBJ/oY7sT2OUxTGptCmok.UhVHG.FU/UB2oYWkZfa/5JcNG73i8oa", null, false, new DateTime(2023, 4, 14, 1, 28, 29, 661, DateTimeKind.Local).AddTicks(9345), "Featherstonhaugh", null, null, "0737666977", 2, null, "dfeatherstonhaughr" },
                    { new Guid("7021a71e-31f6-451e-a378-74fd971ca9a9"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$c8xwHf.j2YtgfgxmlJvDsO.OOi/UoOtQq272aXb.7yBrNezZYTJ2G", null, false, new DateTime(2023, 4, 14, 1, 28, 31, 331, DateTimeKind.Local).AddTicks(259), "Kroch", null, null, "09201855247", 1, null, "okroch16" },
                    { new Guid("7d6d353f-a270-41ba-a098-2e615fc8ea56"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$ais52iZJ86MeHF5s/RfjguIvGFiwMZwibbwcT9.9V/pWwKzJKmCEy", null, false, new DateTime(2023, 4, 14, 1, 28, 35, 956, DateTimeKind.Local).AddTicks(1151), "Hargitt", null, null, "04664308348", 1, null, "ahargitt29" },
                    { new Guid("7f737f55-079f-4d2d-9712-89b4c9d47a11"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$11GHMQ/equjunusSt141n.3jaCdR4NSYz3BqgD0TaJA2wwFhRfdE.", null, false, new DateTime(2023, 4, 14, 1, 28, 35, 722, DateTimeKind.Local).AddTicks(3177), "Glison", null, null, "06769810772", 1, null, "rglison27" },
                    { new Guid("815af78a-0819-4c81-bdae-b70ee52ea0f3"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$nZzn7RWHH/0KuvhpETRjIuOziPJcRurM2sUsK5fOWcvggeOjgFFIC", null, false, new DateTime(2023, 4, 14, 1, 28, 28, 329, DateTimeKind.Local).AddTicks(8490), "Tubbs", null, null, "0630308378", 2, null, "gtubbsg" },
                    { new Guid("878c60ca-fdc5-46a0-89b9-3a5cd42491c6"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$T.fanXSiCmOrThLZGfZAXOf4bZ/w1nk6/OoAg6BQ5xKrr5WyFQvea", null, false, new DateTime(2023, 4, 14, 1, 28, 38, 683, DateTimeKind.Local).AddTicks(4781), "Elgee", null, null, "0961523438", 2, null, "melgee2x" },
                    { new Guid("89be9898-4929-41eb-873d-f67bd0f0c612"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$bJFkWKxfp4FC4rZd/0468eKYapCPZ9/EZHfgwy39J/zY3XKiheAeu", null, false, new DateTime(2023, 4, 14, 1, 28, 37, 498, DateTimeKind.Local).AddTicks(3233), "Saban", null, null, "02156386100", 1, null, "csaban2n" },
                    { new Guid("8e6c242e-e957-4b6a-9db4-b5d117b9b43a"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$UYAFml.0mABTIkW8zAyoDuOCeYVmilBYA8rWCWxtLDMEhzDghUVjm", null, false, new DateTime(2023, 4, 14, 1, 28, 33, 860, DateTimeKind.Local).AddTicks(5766), "Hallard", null, null, "03332477053", 2, null, "mhallard1r" },
                    { new Guid("90de0225-3232-415a-9fee-df8978dd1dd5"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$c6XQchqBY6FCmjhqVwKDHOvY0uCLO.ozOoQ7ne1MdLkRh6A5DfZrW", null, false, new DateTime(2023, 4, 14, 1, 28, 31, 569, DateTimeKind.Local).AddTicks(4872), "Strooband", null, null, "0129884328", 1, null, "tstrooband18" },
                    { new Guid("9182320f-4225-4655-bc7c-d8f852dd1ec0"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$8Z7POE21mebwfpnl1J61TuG1qoyTaz4g4Bt1ineAXyV5Va0tgZE1C", null, false, new DateTime(2023, 4, 14, 1, 28, 38, 202, DateTimeKind.Local).AddTicks(9861), "Brechin", null, null, "0285671009", 1, null, "lbrechin2t" },
                    { new Guid("93c59f78-da37-4069-810a-18bb6a0d5bd0"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$pXv5TFgGsiXvWSnPCifXEeqflWp6BglNt4PszxlCmw.Nm1wCBF4VG", null, false, new DateTime(2023, 4, 14, 1, 28, 38, 452, DateTimeKind.Local).AddTicks(7401), "Masser", null, null, "0612845922", 2, null, "smasser2v" },
                    { new Guid("95935a83-c979-44cc-9d24-6f63f4294f92"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$icOW8vHNFagxYgQ.nLIMDey3qKYXQ1YGyKjrqOo2MqV9zzsOheULW", null, false, new DateTime(2023, 4, 14, 1, 28, 34, 187, DateTimeKind.Local).AddTicks(2515), "Scirman", null, null, "0195375651", 1, null, "ascirman1u" },
                    { new Guid("9bca5b80-6578-463c-b2a3-06ac127e8da4"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$HMkTghp0GFvvGxh28zced.ETJqG9td1bLdqRRJMSmc7Usi.OTmn/2", null, false, new DateTime(2023, 4, 14, 1, 28, 33, 738, DateTimeKind.Local).AddTicks(3753), "Brockelsby", null, null, "04963800585", 1, null, "jbrockelsby1q" },
                    { new Guid("9fce2dba-dffe-4396-8658-53eca5ba2e27"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$l/uw37gvgppKuncogfmngOi5whN2GpP2SWOWacUN.VTIl7IxOv7Qu", null, false, new DateTime(2023, 4, 14, 1, 28, 27, 760, DateTimeKind.Local).AddTicks(5529), " Nguyen Van", null, null, "0966416708", -772000, null, "phucnv" },
                    { new Guid("a1fb7a0e-deb5-4094-a2e6-aad13ecac2a7"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$FYQ7bQkaFwjSGV34P8jVLOH/7BjGTG3u/ArVvTOBgTG0Kpfpn9y4e", null, false, new DateTime(2023, 4, 14, 1, 28, 33, 505, DateTimeKind.Local).AddTicks(8440), "Ormerod", null, null, "02807987147", 1, null, "oormerod1o" },
                    { new Guid("a498dce0-1dcb-4959-bf1d-0b5f5f11fe00"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$ofLLm5qtJ1TBm6pEu9mlFenkMJBZC4if/SUZkO0BlezstxEBpwxO2", null, false, new DateTime(2023, 4, 14, 1, 28, 30, 678, DateTimeKind.Local).AddTicks(3294), "Briston", null, null, "02637402338", 2, null, "cbriston10" },
                    { new Guid("a7181e79-8084-492b-9fb2-dc41619e6c1b"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$OIRTjJB2/R5Z7/vOV0tpcemqjxigP.14b3yJYTgu0doF1NU6k.lMS", null, false, new DateTime(2023, 4, 14, 1, 28, 31, 9, DateTimeKind.Local).AddTicks(6515), "Cantor", null, null, "0218299981", 1, null, "jcantor13" },
                    { new Guid("a8cebb1a-80c8-412c-8afe-6d993ef19931"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$ONfWjothHavtyUnrSsUma.GawLN3ml.A4JL1uozSrEGqhmiEWbtBq", null, false, new DateTime(2023, 4, 14, 1, 28, 36, 177, DateTimeKind.Local).AddTicks(3842), "Spaldin", null, null, "0596030481", 1, null, "mspaldin2b" },
                    { new Guid("b00093b6-bd52-43c8-a1c2-8b90acaa5155"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$pUcTEx8agDyrNwAZBKN8f.EYp2IvTVh3roX9CdAEiT6B3Fm8up0pS", null, false, new DateTime(2023, 4, 14, 1, 28, 29, 763, DateTimeKind.Local).AddTicks(5978), "Beament", null, null, "0756962604", 2, null, "obeaments" },
                    { new Guid("b2a43891-46fe-485e-8db5-4cfa7215e726"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$n9tYKdb2x8Xedtd/7UQxF./JMZUrXS3i9eguVbAXRV3CtqVxlQqkm", null, false, new DateTime(2023, 4, 14, 1, 28, 38, 308, DateTimeKind.Local).AddTicks(54), "Gonzalo", null, null, "0459531972", 2, null, "lgonzalo2u" },
                    { new Guid("b5dc3acd-b811-414b-8235-e46ee4f39391"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$HYTJ/9Ndc4rrZGDP5nU9uOF0X1KBox9zmpkc4Atdr44.CZLKHuJVS", null, false, new DateTime(2023, 4, 14, 1, 28, 37, 276, DateTimeKind.Local).AddTicks(4559), "Gasperi", null, null, "03723162025", 2, null, "ogasperi2l" },
                    { new Guid("b8bbdef0-6fc3-40e7-b98e-55f58b2e6173"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$WtN1Gq8Xz70L/2wfJdQHBePixq.huSTpvv3ItQ9BrbDyDsAZOXJv2", null, false, new DateTime(2023, 4, 14, 1, 28, 30, 333, DateTimeKind.Local).AddTicks(8950), "McKinlay", null, null, "03957603316", 2, null, "dmckinlayx" },
                    { new Guid("bcdea771-172b-4640-9c68-6c734cbdf9bb"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$885X3E6sYl/63ZNZM/cE0eHU/47lokBQhWdaoJHm.fe5E8vpHhFtK", null, false, new DateTime(2023, 4, 14, 1, 28, 36, 971, DateTimeKind.Local).AddTicks(4661), "Haney", null, null, "0041887086", 2, null, "dhaney2i" },
                    { new Guid("bf5f1a88-694f-47e3-9581-ddfca5abf6c1"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$tbybzJdoRHLGmsmom5qVdeQQmUvTGCEsiy68g9d9DXix/36eT1Csa", null, false, new DateTime(2023, 4, 14, 1, 28, 30, 125, DateTimeKind.Local).AddTicks(6714), "Warnes", null, null, "0812419659", 2, null, "ewarnesv" },
                    { new Guid("c4719153-3786-43d2-87ad-a32dba83b3db"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$srB0oTbtoRgH9A3aqEfjA./UvZPafzP.N3hKVhzcmck6ojGWlbRmq", null, false, new DateTime(2023, 4, 14, 1, 28, 32, 640, DateTimeKind.Local).AddTicks(4543), "Ashpole", null, null, "03667705539", 1, null, "kashpole1h" },
                    { new Guid("c74ee603-44ac-456b-a04b-5821c0dc0620"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$giU8sCFYV35JPASym78AR.TyJ2TdWPwKgXpGAUX6NGUI3D.zwfV6C", null, false, new DateTime(2023, 4, 14, 1, 28, 34, 423, DateTimeKind.Local).AddTicks(8606), "Polden", null, null, "0831072797", 1, null, "rpolden1w" },
                    { new Guid("c867d226-ace4-4e73-a056-07cfe7183b58"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$foIoltOBZwybmZHKmKLoVOPdoEdBL0wuW6ScCU7Pb1ZAbpgCQ3IG2", null, false, new DateTime(2023, 4, 14, 1, 28, 33, 613, DateTimeKind.Local).AddTicks(4793), "Rameaux", null, null, "0213510408", 2, null, "vrameaux1p" },
                    { new Guid("ca7870f7-b8af-4c44-a2df-c94abedcb318"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$VW.lzImnzcZ74vW/J1cHe.Gyaj7nwKg5jC8MiD5tqULLIKayHLiP2", null, false, new DateTime(2023, 4, 14, 1, 28, 38, 785, DateTimeKind.Local).AddTicks(5140), "Abrahamsohn", null, null, "08144581503", 1, null, "babrahamsohn2y" },
                    { new Guid("ccce65f4-83ec-49a2-a989-b8e09d754c17"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$3rnvr6vH9yflPgX8bEZb1O9cBcQqHs/SSOBFZOZiSjfD2rnHp3tki", null, false, new DateTime(2023, 4, 14, 1, 28, 35, 163, DateTimeKind.Local).AddTicks(8218), "Webley", null, null, "0821411907", 1, null, "jwebley22" },
                    { new Guid("cf343f46-0488-4689-bf67-3dbfb4f3461f"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$9N6IxTpJ6o4koQOEvkTkn.cs9fzWur1zWmF0fyE4AYnxBV4fZCY72", null, false, new DateTime(2023, 4, 14, 1, 28, 37, 178, DateTimeKind.Local).AddTicks(4162), "Howland", null, null, "00133370415", 1, null, "lhowland2k" },
                    { new Guid("cfe3a747-61f9-4f7d-a451-f0ef622aefe6"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$mZQRgrMVnGNJTNi.g1Jlh.6apDtgDygBajluHk99ee/zuzfODbH7m", null, false, new DateTime(2023, 4, 14, 1, 28, 27, 878, DateTimeKind.Local).AddTicks(1039), " Ass min", null, null, "0966416708", -772000, null, "admin" },
                    { new Guid("d0929011-4d75-45a2-800a-8d973c1fa842"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$V2/wYSoFI25YKVhXYrvF.eUzraQdJlbWU3y0R1pYWUo2qNX/KVh6m", null, false, new DateTime(2023, 4, 14, 1, 28, 36, 757, DateTimeKind.Local).AddTicks(2487), "Fitzhenry", null, null, "04780696921", 1, null, "afitzhenry2g" },
                    { new Guid("d336a8c0-8a78-47ba-a224-66b0760e762e"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$scrPd0TS73ejQgLs.1WyQObg0C1By64gYimcsLKJi2saYevHrY73C", null, false, new DateTime(2023, 4, 14, 1, 28, 35, 602, DateTimeKind.Local).AddTicks(6317), "MacKegg", null, null, "05989129010", 2, null, "wmackegg26" },
                    { new Guid("d41ba31e-b173-4f43-a084-a67b99daa979"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$uguRfzbBT44.k9ca4.IqKOpbBLkAWi4ahd4jDNvFru8v.7LVUOlCy", null, false, new DateTime(2023, 4, 14, 1, 28, 31, 904, DateTimeKind.Local).AddTicks(4859), "Petteford", null, null, "0939882707", 2, null, "spetteford1b" },
                    { new Guid("d566267f-2f54-4534-b43b-57b7bdaf0cf0"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$6dRHkHKB7nQ6qOgICk/ds.2/AcoTyTTbd9Gx2.sDoYBf1jz/zmZcC", null, false, new DateTime(2023, 4, 14, 1, 28, 28, 609, DateTimeKind.Local).AddTicks(603), "Martinyuk", null, null, "0766805261", 2, null, "nmartinyuki" },
                    { new Guid("d6183d87-eb46-4093-9511-09be9980d0e7"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$MMY6tgHKzwnUEqyoohBDqe3Q0VuJSl50iebrl6VUO3rqdYey9PF5u", null, false, new DateTime(2023, 4, 14, 1, 28, 37, 76, DateTimeKind.Local).AddTicks(2404), "Petrescu", null, null, "0719013924", 1, null, "bpetrescu2j" },
                    { new Guid("d85ec5df-e7bb-4b18-b2c7-c4a337176ba0"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$jr79cPSj.hLPPAB3PhTCTO16Hdi55/nIPTDBgDhg5nUz5EqGcvpWC", null, false, new DateTime(2023, 4, 14, 1, 28, 28, 842, DateTimeKind.Local).AddTicks(8665), "Garrioch", null, null, "0072752247", 1, null, "mgarriochk" },
                    { new Guid("da9af357-bc98-4389-b248-433e958d1536"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$siJcqg4y84CBVankuvn6juN0nnHP7Vd85gTGY2eMqcacrcAVNcvni", null, false, new DateTime(2023, 4, 14, 1, 28, 38, 578, DateTimeKind.Local).AddTicks(5991), "Bolliver", null, null, "0699230163", 2, null, "sbolliver2w" },
                    { new Guid("df108c91-d57e-4084-91aa-4887b0cf7142"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$QRG6Q8ZYupQQzWEWE4ijYub7kyyV/gRKpsvczVvryKB7tzjNCz1Aa", null, false, new DateTime(2023, 4, 14, 1, 28, 29, 437, DateTimeKind.Local).AddTicks(8815), "Dunsford", null, null, "00868235500", 1, null, "rdunsfordp" },
                    { new Guid("df4ad2e0-2dd1-4c99-a678-5f6a79a02d92"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$yzM..S3/wFnhHU2pnqf9eeFwpj7uZ5zyUJG1A1RQkizEXcwB1/VyG", null, false, new DateTime(2023, 4, 14, 1, 28, 35, 276, DateTimeKind.Local).AddTicks(1381), "Scheffel", null, null, "0355632555", 2, null, "hscheffel23" },
                    { new Guid("dffbd93c-132f-450e-b73b-141213112f14"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$GDwkVn16VOe7AuDoAeg6Nuadu41j2hwETACpPOS9Ts09dapz54TQu", null, false, new DateTime(2023, 4, 14, 1, 28, 28, 473, DateTimeKind.Local).AddTicks(8732), "Lavens", null, null, "06895509784", 2, null, "rlavensh" },
                    { new Guid("e1fdc061-8198-4467-948b-755f57e22fc5"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$wk6AgfpwuPdOrGA0S9L.7.FDtDyUC9dW1M4TVe3nvx.jWgpS63cEa", null, false, new DateTime(2023, 4, 14, 1, 28, 36, 279, DateTimeKind.Local).AddTicks(1453), "Jilkes", null, null, "00677856497", 2, null, "bjilkes2c" },
                    { new Guid("e6f23901-a893-4f0a-b0ef-0326d8afffee"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$9XqPhbDqHdhON6ArVibDlu4wjllUfZYivrtZFY/eUp60lsOz2Y6yq", null, false, new DateTime(2023, 4, 14, 1, 28, 28, 724, DateTimeKind.Local).AddTicks(4662), "Powdrell", null, null, "0569083168", 1, null, "mpowdrellj" },
                    { new Guid("e828654a-bc24-4cad-bc15-ae3b623f1c57"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$xUwUHwwmwDMiZK6DkNusAeNvNSDFik0J1pEOxTZQeCNPaPgEpJbYG", null, false, new DateTime(2023, 4, 14, 1, 28, 31, 795, DateTimeKind.Local).AddTicks(885), "Milton-White", null, null, "0602588523", 2, null, "jmiltonwhite1a" },
                    { new Guid("eb2a1f41-6fba-48ce-a332-41b6a1474dcb"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$e75BgndA8dQ2tPPTKbWDouh/CKKYcVLH8fhc3UXB/7FKo5bvIPBZu", null, false, new DateTime(2023, 4, 14, 1, 28, 28, 201, DateTimeKind.Local).AddTicks(2600), " Nguyen Van", null, null, "0966416708", 2, null, "owner" },
                    { new Guid("ec61d88e-240b-4abe-8b6f-927f673b64fd"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$/HTskZvT5oR814PcF1AXNuktKrKsUwWeALOYLXYWqw.ynmyc2Hqy6", null, false, new DateTime(2023, 4, 14, 1, 28, 30, 899, DateTimeKind.Local).AddTicks(1174), "Dolder", null, null, "0857765771", 2, null, "pdolder12" },
                    { new Guid("ece2bc48-b3df-4bee-9613-3864b4a2b0fe"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$WZj8Z8UDza0dHGtjDEWxr.91PgDmNXSKwCgevo/YUX2s1dc9Y2jgK", null, false, new DateTime(2023, 4, 14, 1, 28, 39, 145, DateTimeKind.Local).AddTicks(7967), "Struss", null, null, "06928824187", 2, null, "astruss31" },
                    { new Guid("f03982b2-dad3-4f99-9473-d86ab77d6d3c"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$YUoOgYpg.ZNBbseoqN8lyePiptMVtRka4na1/D8OPSMUI57HX4UPa", null, false, new DateTime(2023, 4, 14, 1, 28, 30, 1, DateTimeKind.Local).AddTicks(3895), "Harnott", null, null, "00039497181", 2, null, "mharnottu" },
                    { new Guid("f2fb7b66-09ba-4029-980b-354dc3e17c5c"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$gVhNsaLuUnxEBXroKb1OCeqOUcw4k8dEPtFzHFsgnaalXp/LkEYQC", null, false, new DateTime(2023, 4, 14, 1, 28, 30, 553, DateTimeKind.Local).AddTicks(8767), "Maestrini", null, null, "0312994030", 2, null, "fmaestriniz" },
                    { new Guid("f2feeb99-9ecf-4a69-98e6-9df7af4386bf"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$03YW1uuFGs/Wi1.YzHbn5.rScHqLFKM6g0SIa/UtVKxj2.OdRUVS.", null, false, new DateTime(2023, 4, 14, 1, 28, 33, 394, DateTimeKind.Local).AddTicks(5693), "Hannen", null, null, "06533305742", 2, null, "channen1n" },
                    { new Guid("f64e132e-90b8-477d-a179-2e9b2ced0e70"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$shrzUHVJT0VEd9GRZBMYz.4.w9/kXgDtvyWfi/wZCxt9WRsPGr.s2", null, false, new DateTime(2023, 4, 14, 1, 28, 32, 6, DateTimeKind.Local).AddTicks(2980), "Middlehurst", null, null, "03494633510", 2, null, "dmiddlehurst1c" },
                    { new Guid("f67080fe-607e-478c-90db-c4ce7032093d"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$dLVDv0iEqJ5GNEvZegjyuev2kYzNEo24McSbnC6V4fjXJa8vYXcd2", null, false, new DateTime(2023, 4, 14, 1, 28, 34, 771, DateTimeKind.Local).AddTicks(8870), "Kearns", null, null, "0461097167", 1, null, "skearns1z" },
                    { new Guid("faef2f9d-c1ec-4388-87e0-74eb9adeb894"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$vd9rvRFFNCQvN5bU9i3yP.VLMup/RVDq1yTljpFw4AofxNN3TtKeW", null, false, new DateTime(2023, 4, 14, 1, 28, 37, 609, DateTimeKind.Local).AddTicks(5960), "Andriessen", null, null, "05873824805", 2, null, "candriessen2o" },
                    { new Guid("fbf0d7de-9bf7-4f61-920f-ba26283c78d6"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$SRBJYheLcZs292WBDxWASOLUMXV7tUY5F.MRiukywBHnhCK5Sssxq", null, false, new DateTime(2023, 4, 14, 1, 28, 29, 86, DateTimeKind.Local).AddTicks(5384), "Maddyson", null, null, "0915548406", 2, null, "cmaddysonm" },
                    { new Guid("ffad8044-6818-4743-9269-e345c31e18fc"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$ee5k.BeQE6sQhTbi31.1LeghsM2EXNd6zF9N3XUIbXEQiy2mRCx6e", null, false, new DateTime(2023, 4, 14, 1, 28, 37, 380, DateTimeKind.Local).AddTicks(8746), "Barhem", null, null, "08054760577", 1, null, "sbarhem2m" }
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
                name: "IX_Slots_LastModifyByID",
                table: "Slots",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ParkingID",
                table: "Slots",
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

            migrationBuilder.CreateIndex(
                name: "IX_Users_TransactionID",
                table: "Users",
                column: "TransactionID",
                unique: true,
                filter: "[TransactionID] IS NOT NULL");

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
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "MembershipPackages");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "Parkings");

            migrationBuilder.DropTable(
                name: "Dashboards");
        }
    }
}
