using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver189 : Migration
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

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model" },
                values: new object[,]
                {
                    { new Guid("44ac0396-509f-47cb-8c05-a16989d9d94f"), "Xe 7 chỗ", null, null, "SUV7" },
                    { new Guid("44d3ba99-2d0a-4188-820e-fbc56eab2ea3"), "Xe bán tải", null, null, "Pickup" },
                    { new Guid("69931f1b-3100-4322-85d0-2a05fd8a966b"), "Xe van con", null, null, "Minivan" },
                    { new Guid("82a6c1af-7007-4eb4-8573-ff851c258a8e"), "Xe 4 chỗ du lịch", null, null, "Sedan" },
                    { new Guid("b5136f19-7abe-4d79-96eb-e882546e6f79"), "xe 5 chỗ", null, null, "SUV5" },
                    { new Guid("bcfefd71-c4de-435a-8e02-bfb80b122f12"), "Xe 2 khoang", null, null, "Mini" }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1fd94a3a-d369-4a59-9aee-d4fd6a732048"), "1 Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L, "Long", 130000.0 },
                    { new Guid("64c54362-ff5d-43b2-bc0e-55723c415678"), "Half Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, "Medium", 70000.0 },
                    { new Guid("d88264e9-a156-4bc9-905b-ed2649f40fd5"), "Short time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, "Short", 40000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "ImageID", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "TransactionID", "UserName" },
                values: new object[,]
                {
                    { new Guid("030a60e7-5453-48ab-aedb-4b926c8293fc"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$6JRLZyT9QpBbLwFm7ku7vOK.yoqqxHu0J8QTtCRhZLzy./wKAkzrq", null, false, new DateTime(2023, 4, 13, 16, 50, 16, 935, DateTimeKind.Local).AddTicks(9092), "Rameaux", null, null, "0213510408", 2, null, "vrameaux1p" },
                    { new Guid("0941cc8c-5a65-4464-8ac8-d2cda471257f"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$0oAv/Ucrhv5YSGdWVmm9C.pcMsBObR27fgudLxKRGJeelPQlD0UKm", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 145, DateTimeKind.Local).AddTicks(2038), "Iacovacci", null, null, "0770070777", 1, null, "siacovacci2r" },
                    { new Guid("0ce442b9-df00-4b9b-8f62-13c7f717dde8"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$F4mZ4c5INNCT3mowFVKM2eRZNF0/794SsS.YkAJSIBDVZRj4uPTSy", null, false, new DateTime(2023, 4, 13, 16, 50, 19, 19, DateTimeKind.Local).AddTicks(4098), "Hargitt", null, null, "04664308348", 1, null, "ahargitt29" },
                    { new Guid("0d1d698d-68f1-46b5-b6a2-7600ead51e86"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$triDriD5Snnt4d2rHHP4reeECweSLBkfUETneQqwrI3.9hIpAGZpq", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 576, DateTimeKind.Local).AddTicks(4895), "McCloy", null, null, "08418620623", 2, null, "tmccloyl" },
                    { new Guid("1063635d-ab46-40ac-b1e2-ed02a100f0f2"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$zvxkZpEJLr6Cg7BvN2IXBu5ZzN7UmvkBWScaWyZsVYbzFQrjQea7i", null, false, new DateTime(2023, 4, 13, 16, 50, 20, 33, DateTimeKind.Local).AddTicks(4887), "Haney", null, null, "0041887086", 2, null, "dhaney2i" },
                    { new Guid("110a817c-fcf3-4627-b273-60a2b69c4f81"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$xB/gxT0OoN.fVD6udcRA2eDzbQVz.TEhIqvJwhsaT4Qu1pjs8zqM2", null, false, new DateTime(2023, 4, 13, 16, 50, 14, 213, DateTimeKind.Local).AddTicks(4572), "Dolder", null, null, "0857765771", 2, null, "pdolder12" },
                    { new Guid("16461f8b-17c2-4a89-ae74-4032f92617d8"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$gLUJjIoQ2I0eTh70MHpd7OAJMepqPkFqg35S3GcXEpjyiTNcSzOdS", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 340, DateTimeKind.Local).AddTicks(5207), "Brechin", null, null, "0285671009", 1, null, "lbrechin2t" },
                    { new Guid("16e95d07-8931-4408-981b-3ef10e276399"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$4IA0Keh/d5TC7Z11abP2z.p1fkl6pyotISTYo9A1icuVr2kz830fi", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 255, DateTimeKind.Local).AddTicks(6162), "Webling", null, null, "0390471753", 2, null, "bwebling1s" },
                    { new Guid("1d50b2b6-36b9-4703-a76e-4411e2d45b74"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$D/yZpsB7QDrqm9FltOjBw.d4ZbrlMeYupMKwnOiJt66ifZGTDNIvi", null, false, new DateTime(2023, 4, 13, 16, 50, 14, 103, DateTimeKind.Local).AddTicks(5946), "Dreossi", null, null, "03724370545", 2, null, "cdreossi11" },
                    { new Guid("1fdea77e-d081-4370-853d-b8c48d2d43b9"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$UfvuFNzfilQT8LRu6V2uVu2qPX1te9PuJFAjc.uxY4snYVqCCVND.", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 582, DateTimeKind.Local).AddTicks(5077), "Masser", null, null, "0612845922", 2, null, "smasser2v" },
                    { new Guid("24713050-c415-4f74-a9ac-49a597bceb27"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$QvIGKf5lVWEZ6GTVjLdqYOWursHtZ8MuQZUKdjwvt5dwFy5BA7JMm", null, false, new DateTime(2023, 4, 13, 16, 50, 11, 799, DateTimeKind.Local).AddTicks(4654), " Nguyen Van", null, null, "0966416708", 1, null, "customer" },
                    { new Guid("25ddc702-45bd-41cc-bdd5-e3630e9470fb"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$gTGwk194gjotW2iEB/neS.g8ZeCKqrJ45OtE/wgHpUtgKqkNXq.Ne", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 366, DateTimeKind.Local).AddTicks(9556), "Powdrell", null, null, "0569083168", 1, null, "mpowdrellj" },
                    { new Guid("291bbf62-2d7c-4b2a-ade9-cc0c151f851d"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$po/8z/H.g6Isv7mvn6Rd8ObF.Hr70g7UsITLDzfTaBoKYTvILy4GS", null, false, new DateTime(2023, 4, 13, 16, 50, 15, 326, DateTimeKind.Local).AddTicks(1452), "Petteford", null, null, "0939882707", 2, null, "spetteford1b" },
                    { new Guid("2a51a42e-df4b-4fd9-a365-4fce381ddce3"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$ntJ2foSLob.abMCHsj7oretupT4HigSRGyqAwNHO4XBm1LpoKmnMm", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 812, DateTimeKind.Local).AddTicks(4468), "Springham", null, null, "00834111266", 1, null, "sspringhamy" },
                    { new Guid("2d9be929-2a5a-4751-ab3e-4dcb10832056"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$7zRKIH1Zh0JSiCgCgk2A8OtwaBlW29FCa5eaN5S5n..hQxUGEFdCm", null, false, new DateTime(2023, 4, 13, 16, 50, 16, 837, DateTimeKind.Local).AddTicks(9323), "Ormerod", null, null, "02807987147", 1, null, "oormerod1o" },
                    { new Guid("33a92f3c-8ab8-4969-aef2-de1407a6098f"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$Pfi4/6W/XcINupD.ae.y0OwxMy7KAH6qEsMTd18mdH0yPQWkD/B8i", null, false, new DateTime(2023, 4, 13, 16, 50, 15, 821, DateTimeKind.Local).AddTicks(490), "Mattam", null, null, "0865586458", 2, null, "emattam1f" },
                    { new Guid("33e9b9c4-140d-4bfe-a1f0-cf3a8e9d63bf"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$.6giWS.83XOZ2PZ2t4Yd0Ofktj3HQON7Q4BeQePu1f5k6KXsnom.K", null, false, new DateTime(2023, 4, 13, 16, 50, 14, 960, DateTimeKind.Local).AddTicks(2479), "Strooband", null, null, "0129884328", 1, null, "tstrooband18" },
                    { new Guid("34a3e298-8d17-466d-9609-1b4145e1676b"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$Wq8M8hMhPBAUyTSYUpBu1uvi51tzyrSNKqR4DX5cBoAYaPw4sINMa", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 470, DateTimeKind.Local).AddTicks(9310), "Scirman", null, null, "0195375651", 1, null, "ascirman1u" },
                    { new Guid("3ddd328d-780a-4075-90e4-35d66e166b3e"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$1nVw8Y/ZDZwglpUHt0xNeuiaYRNmOXfrDjCxqJlkprN6/3GWUfa6W", null, false, new DateTime(2023, 4, 13, 16, 50, 15, 678, DateTimeKind.Local).AddTicks(537), "Laidel", null, null, "06837677860", 2, null, "blaidel1e" },
                    { new Guid("4027a6d8-14d7-416c-a633-c0c9f64edf0d"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$83IhTb7nOOy.sK.fgK9Hue25lQ/aLROkeB6oofsAMecnjiOVxE6TO", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 152, DateTimeKind.Local).AddTicks(5133), "Lavens", null, null, "06895509784", 2, null, "rlavensh" },
                    { new Guid("41ebb8ec-7c69-470b-bd87-c997de6f08b4"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$OjBXIAI0uynRaPYoZjopF.IR2iFDXWGW3qbKv4ilQY/EoXvL/sFlq", null, false, new DateTime(2023, 4, 13, 16, 50, 18, 111, DateTimeKind.Local).AddTicks(6810), "Oliffe", null, null, "0002143579", 1, null, "koliffe20" },
                    { new Guid("467aad4d-2343-4482-8ef4-6575d7977a7b"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$7DccafGkpuBpE2ES90i98euwbC79Wzp8hFRwMiKeL8CBW3.FdFERa", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 363, DateTimeKind.Local).AddTicks(7990), "Gostick", null, null, "05617299637", 1, null, "bgostickt" },
                    { new Guid("46b790e9-e660-4052-a341-ca453a3d800a"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$4X/CPjJtHOJvM6EYQ67BzOOVk66ud4T5YFG/Ta.J/0I9U4Skpema2", null, false, new DateTime(2023, 4, 13, 16, 50, 18, 306, DateTimeKind.Local).AddTicks(3280), "Webley", null, null, "0821411907", 1, null, "jwebley22" },
                    { new Guid("4a182976-ae41-458a-9dfc-7bd94cf35225"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$60VDP1j6mSekuk28y3ctb.hPZyohkJsqrgB6D9uxXP7DcwTKDcp0y", null, false, new DateTime(2023, 4, 13, 16, 50, 19, 217, DateTimeKind.Local).AddTicks(5233), "Spaldin", null, null, "0596030481", 1, null, "mspaldin2b" },
                    { new Guid("4b19e4ac-0220-4859-bc4a-7cba4004bcc9"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$rVL.6gSfu9rLABieUGHpP.d.86HJzKzO8gbn1WVND81ThStkJcB.y", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 47, DateTimeKind.Local).AddTicks(4634), "Tubbs", null, null, "0630308378", 2, null, "gtubbsg" },
                    { new Guid("4c754904-4404-40e1-814d-264652012891"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$JKG8qlPzU081Yuuf.0fc8uUfhRtmnULlfRjezhBrxk9ZHDLEzF.DK", null, false, new DateTime(2023, 4, 13, 16, 50, 18, 927, DateTimeKind.Local).AddTicks(157), "Canti", null, null, "07734012207", 1, null, "gcanti28" },
                    { new Guid("595b5d9d-d61a-44ad-bdc1-e79812ff23c1"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$D9tNi8xAYykhPGVaYbgyq.XpH6b7uVpz8FNjK1kaRnK5vJYSR7YaO", null, false, new DateTime(2023, 4, 13, 16, 50, 20, 160, DateTimeKind.Local).AddTicks(7384), "Petrescu", null, null, "0719013924", 1, null, "bpetrescu2j" },
                    { new Guid("5d6d05ee-7630-41f3-8b68-eff63951f2d1"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$yEGfw8dNnhTBGYOdqoUoKe/4n9NR6JV3kK2i5idXXPBHmKo3AcJDO", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 955, DateTimeKind.Local).AddTicks(1571), "Dunsford", null, null, "00868235500", 1, null, "rdunsfordp" },
                    { new Guid("5fd32fb8-5c61-4bf1-bee2-c83bbd1627fa"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$oFHoMhRval7c9C9SkjPgr.hAbamjqyGw41TmMg2Hoso7OkpZUZNBW", null, false, new DateTime(2023, 4, 13, 16, 50, 16, 611, DateTimeKind.Local).AddTicks(9308), "Margrie", null, null, "0153784673", 1, null, "cmargrie1m" },
                    { new Guid("64f7101d-91c0-4a26-bf1c-4d214931c269"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$vKR0oqeELMb9M8npvH36qeEVdlyBuGL24Iyu6xRZXyAhHW2H96hRa", null, false, new DateTime(2023, 4, 13, 16, 50, 14, 589, DateTimeKind.Local).AddTicks(7856), "Filipchikov", null, null, "0663461504", 2, null, "afilipchikov15" },
                    { new Guid("65396b87-ab00-4533-8313-0b602d9526c9"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$E.IN60FEhPQUzf/.1sEkDOejDXGEqqTJ7oJObUAJBaGuS2r4nj8aW", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 692, DateTimeKind.Local).AddTicks(5442), "Bolliver", null, null, "0699230163", 2, null, "sbolliver2w" },
                    { new Guid("676c21d4-a40a-44df-a749-77667bbfd4e1"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$xbqH801RaP/jIfhCtCwxe.1VTLVbubzDDNI0/4HnjVY6pbKzAf2xa", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 993, DateTimeKind.Local).AddTicks(2441), "Beamson", null, null, "07242980517", 1, null, "kbeamson2z" },
                    { new Guid("6c14647f-18be-4cd7-b60d-6d8830395a62"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$tEDL6EloelMftjkic.P19.LCJd/kaWEc2XpGf3dS65W9xY1ZA4LKO", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 881, DateTimeKind.Local).AddTicks(2087), "Batrip", null, null, "0734926905", 1, null, "abatrip1y" },
                    { new Guid("6e1276be-9b28-44a9-a4a4-68434af11578"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$XOmS14oJuew9Ar0K7Av4guYBtpLl0PyHBnqF.knz2DbNaDWw3uc.O", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 458, DateTimeKind.Local).AddTicks(6008), "Harnott", null, null, "00039497181", 2, null, "mharnottu" },
                    { new Guid("6e2b4663-9d87-473a-8bfa-955a777b2b5b"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$jNTeuW5s1uHqknlwxeXAc.Yj6qoK4KZCuikYWTmNyKylY5ZZItT0y", null, false, new DateTime(2023, 4, 13, 16, 50, 16, 308, DateTimeKind.Local).AddTicks(8430), "Shufflebotham", null, null, "0960301131", 2, null, "pshufflebotham1j" },
                    { new Guid("6f4a0a10-b0cd-46fb-8986-bc4146ab4ae9"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$5Xc3NNSsnk8lljZhqjpGSuoaGyDrJIUUg.5vIehAzUJNOsYkCp5jq", null, false, new DateTime(2023, 4, 13, 16, 50, 14, 694, DateTimeKind.Local).AddTicks(905), "Kroch", null, null, "09201855247", 1, null, "okroch16" },
                    { new Guid("706528b6-30e9-4688-9cd0-83efc709d21a"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$nWurOXrzwxEHRqE9UuosFON7jP6c96xA4WSQRDTQCziJv4PMEtIqu", null, false, new DateTime(2023, 4, 13, 16, 50, 22, 199, DateTimeKind.Local).AddTicks(2317), "Struss", null, null, "06928824187", 2, null, "astruss31" },
                    { new Guid("70f92245-1854-44cf-b80e-4c4d6961bf23"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$OVOu.P9JBDThXr2jRnWnueIyaHXna9VxaaNl9rcCuGWURF5WWu8mW", null, false, new DateTime(2023, 4, 13, 16, 50, 22, 101, DateTimeKind.Local).AddTicks(2608), "Gerrish", null, null, "04944713025", 1, null, "rgerrish30" },
                    { new Guid("71426fe6-9697-4cd2-a402-128f0858dee0"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$COKAI96RcXmrM27m0QwGfOl2.xZLZJIhXhV3F3.Eg5vfLnEn3SpL.", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 726, DateTimeKind.Local).AddTicks(6819), "McKinlay", null, null, "03957603316", 2, null, "dmckinlayx" },
                    { new Guid("72dce6f9-704a-4537-9820-04f03da595c9"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$Gt3iU3aNjMl718PjSEmlUeNd9.rAnXc.g1JiusOGVT1blv96mU95i", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 265, DateTimeKind.Local).AddTicks(1960), "Martinyuk", null, null, "0766805261", 2, null, "nmartinyuki" },
                    { new Guid("764e50b9-f029-487b-a095-36952bd0152f"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$.5em0/bdge7fYFQXaQK.yezdJMSeCBLJeZX/GvmwZY2/AfZcbI3pC", null, false, new DateTime(2023, 4, 13, 16, 50, 20, 802, DateTimeKind.Local).AddTicks(9272), "Andriessen", null, null, "05873824805", 2, null, "candriessen2o" },
                    { new Guid("76bc9ae6-fe7e-4da6-824a-d18d4bb2226c"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$TZ4q35IpbSj65i6nqSXg/OHNXk.ojn2iBrgpugmz3SxLFqqOZYYky", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 462, DateTimeKind.Local).AddTicks(5482), "Garrioch", null, null, "0072752247", 1, null, "mgarriochk" },
                    { new Guid("780eac32-8d6b-4197-961a-70b5cebd82a2"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$F14yQMr0k6jR5Dgtw/e7ZeKpU3dRegTTwbs8Twa8CPEn2pniBQ.r2", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 368, DateTimeKind.Local).AddTicks(4955), "Trippitt", null, null, "00615614760", 1, null, "atrippitt1t" },
                    { new Guid("8104c7c4-e927-4c7f-b4b2-a12800afd72c"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$vVkGfwhmQXIvURMjW257cu/wW69PsJ.ZxnjpYr0jacBinmgSTyR8S", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 772, DateTimeKind.Local).AddTicks(8225), "Skirvin", null, null, "0614302061", 1, null, "mskirvinn" },
                    { new Guid("833b1b58-d2a4-4184-b805-7f65c2ad80a0"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$ncI3sjbx/8SmC5MWr3NpM.WNjUintg8pLfkL4CoZpsWBhCDg8WZC6", null, false, new DateTime(2023, 4, 13, 16, 50, 15, 167, DateTimeKind.Local).AddTicks(8612), "Milton-White", null, null, "0602588523", 2, null, "jmiltonwhite1a" },
                    { new Guid("8570eb63-5df0-4513-b139-5d87f3099f0f"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$M/QsbAA/.jv5Uso0jO5UCe1whJJc4OUO0ydKA0LX/XD6iBP0RINRm", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 134, DateTimeKind.Local).AddTicks(2537), "Hallard", null, null, "03332477053", 2, null, "mhallard1r" },
                    { new Guid("8be033ea-433d-4df0-a09b-8d9e9dd2f890"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$NVC6wrejAeTYSR3GvwVsJ.A53STiifapFpL6kmY3ZxnQ/hDAuDtuK", null, false, new DateTime(2023, 4, 13, 16, 50, 19, 494, DateTimeKind.Local).AddTicks(4795), "Izhakov", null, null, "05872358652", 1, null, "cizhakov2e" },
                    { new Guid("8c77d038-d6c7-45b4-a9b0-e58aa1dd3428"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$fwKDx51DhIxJr/D76sD90u08Crga4D8dOtitRlweg/ApLznmmaxve", null, false, new DateTime(2023, 4, 13, 16, 50, 11, 700, DateTimeKind.Local).AddTicks(9465), " Ass min", null, null, "0966416708", -772000, null, "admin" },
                    { new Guid("95d64cc9-ac77-4aa4-880f-664496dac189"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$TaHK/IKrY/jqRCm3pjYKzuvzdzYinR24bzboNsu2mceXEj7qdNGaq", null, false, new DateTime(2023, 4, 13, 16, 50, 16, 714, DateTimeKind.Local).AddTicks(9453), "Hannen", null, null, "06533305742", 2, null, "channen1n" },
                    { new Guid("97b99623-5185-4757-9a0c-24ab899b5ff9"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$M39jmix/h8cNs0HkWwIdCOYBvJ2WQvXfMi125X5XUjaWyoehZR9sS", null, false, new DateTime(2023, 4, 13, 16, 50, 20, 293, DateTimeKind.Local).AddTicks(8922), "Howland", null, null, "00133370415", 1, null, "lhowland2k" },
                    { new Guid("98d32c04-0e2a-4795-bcf9-35b7f28df4b2"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$OFWhZf5ONRu9agDuLYNnCeRnou.2LiIC6lpx1cmpFhJmWFSe9smI2", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 129, DateTimeKind.Local).AddTicks(1101), "Featherstonhaugh", null, null, "0737666977", 2, null, "dfeatherstonhaughr" },
                    { new Guid("9902b5b2-8e78-4636-a7a2-35ca63438c53"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$bxRb0XAhGl4UU3LWZU0buuyJpXface1dMeJAXaZN1sZsSAyzgJnUS", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 892, DateTimeKind.Local).AddTicks(2961), "Abrahamsohn", null, null, "08144581503", 1, null, "babrahamsohn2y" },
                    { new Guid("9990bda0-1384-4297-abce-d90e97a45bd2"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$d6uN8qy.s05EzL5ewBnmD.dbUnl/AJ2gG7b5ANIc6dit6Pghv/WNW", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 677, DateTimeKind.Local).AddTicks(9331), "Maddyson", null, null, "0915548406", 2, null, "cmaddysonm" },
                    { new Guid("9baa5e4c-d79e-4b82-86fb-d7960a02610c"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$12xmufMf1AH2FDssrMbRSOmx4QHcCPSRYWuLWzSU2r8dnOjYYnvkS", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 985, DateTimeKind.Local).AddTicks(9621), "Kearns", null, null, "0461097167", 1, null, "skearns1z" },
                    { new Guid("9fd150e1-8914-4012-b830-3617b3ec60e7"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$blSvDNVeGXdZrz7tFGG4EerOlVCjkZX7m0CprQDMFzEesnoK1sP9K", null, false, new DateTime(2023, 4, 13, 16, 50, 22, 293, DateTimeKind.Local).AddTicks(2225), "Prater", null, null, "0629137900", 1, null, "tprater32" },
                    { new Guid("a2bb4a5f-c690-45ae-83e0-431aaaade539"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$471SSU0xes1/ttp.4TRh8u1G7MJLBtxHK/z1a.XGHojBG76BYf91C", null, false, new DateTime(2023, 4, 13, 16, 50, 15, 932, DateTimeKind.Local).AddTicks(2048), "Gareisr", null, null, "07314447051", 2, null, "tgareisr1g" },
                    { new Guid("abb1fa27-4651-48c9-a104-aa83b894a787"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$Gbpv4694CRUU3c0j6AriKetGp6GN3ub/m6/oUwDRZ9y.THgXh1mdi", null, false, new DateTime(2023, 4, 13, 16, 50, 19, 402, DateTimeKind.Local).AddTicks(4781), "Faber", null, null, "08586159848", 2, null, "afaber2d" },
                    { new Guid("abf965ed-53f8-46b8-9c2c-09e571027527"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$ujX6g4llaAcfBZsVD4VoEexVeR0Q6JJa4IowOzd0xJ2QHvF6dvtV2", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 780, DateTimeKind.Local).AddTicks(1220), "Stranger", null, null, "03239623484", 2, null, "gstranger1x" },
                    { new Guid("af8918e3-c0b9-4663-8925-ee12f3c07edd"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$jbkYZGx6O80E8dr1.wyKG.B.VSKWmeDcysgJkFoJZjnGX2TPgFTSm", null, false, new DateTime(2023, 4, 13, 16, 50, 18, 523, DateTimeKind.Local).AddTicks(7288), "Swanson", null, null, "09572022187", 1, null, "gswanson24" },
                    { new Guid("b736a208-83fd-41a1-8b4f-8eb09c881c3e"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$WsjL4dwHc2pgOzXFqSkwoOre8.b/oO1lkY0lqyLlnG59Y07/P.gtu", null, false, new DateTime(2023, 4, 13, 16, 50, 20, 402, DateTimeKind.Local).AddTicks(1531), "Gasperi", null, null, "03723162025", 2, null, "ogasperi2l" },
                    { new Guid("b92eea41-fb17-4090-9af0-0975e62f018b"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$GmZ/OooCm1rEaWMk9id96eiFigUXJ8Iy9DrNIfJO1Jil0kaFc1t5W", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 42, DateTimeKind.Local).AddTicks(2867), "Baldacchino", null, null, "05380625199", 1, null, "mbaldacchino2q" },
                    { new Guid("ba7ea821-95a0-40f9-913e-86857494e017"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$2oByJQLcDm9XesHsA14Mmu/DWPR6fk.MUvqJnHPuWMQf8ZzxHa88.", null, false, new DateTime(2023, 4, 13, 16, 50, 19, 740, DateTimeKind.Local).AddTicks(1233), "Fitzhenry", null, null, "04780696921", 1, null, "afitzhenry2g" },
                    { new Guid("bb164956-8dd9-4609-ab98-5237d5463223"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$cyF8Aq3hVZ7FTzKBwpiFZ.suQZBIVG2lB1q/u7ziR3R9bBBQFqTTi", null, false, new DateTime(2023, 4, 13, 16, 50, 20, 534, DateTimeKind.Local).AddTicks(7367), "Barhem", null, null, "08054760577", 1, null, "sbarhem2m" },
                    { new Guid("bbb31bf7-6c9c-414b-b223-2586c07e40a9"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$90I7.25jEqhCYKcpfTCYoeS3JAnQej0naXsv3Ikwty4dD5kdk1iMG", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 794, DateTimeKind.Local).AddTicks(9902), "Elgee", null, null, "0961523438", 2, null, "melgee2x" },
                    { new Guid("c00d0683-089c-4222-ac9a-717432452d59"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$R2PjzyUzSxwBmLxHlhNUWeeuTqv5UKLWYLYhArJ.826DjUFKnuhoq", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 676, DateTimeKind.Local).AddTicks(3220), "Polden", null, null, "0831072797", 1, null, "rpolden1w" },
                    { new Guid("c10e46f2-db1b-40cb-b773-8d2906dba52e"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$5qPC5UurIzdKOT0qvhzJN.aicuDmscpePk6NQEXUFBgPyKwXH/hSm", null, false, new DateTime(2023, 4, 13, 16, 50, 19, 310, DateTimeKind.Local).AddTicks(5881), "Jilkes", null, null, "00677856497", 2, null, "bjilkes2c" },
                    { new Guid("c1284502-ba89-4d67-b120-7e5bee4a9fc3"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$mbVjOfKBiAeig/Aiyx3dR.wSYKP.mN1XBUAZOCMmKhTzaSF7GHO1K", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 32, DateTimeKind.Local).AddTicks(4589), "Brockelsby", null, null, "04963800585", 1, null, "jbrockelsby1q" },
                    { new Guid("c47d96d7-34e5-4e86-bb7b-0b6cb9a7c52b"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$oRQwe8IuG6jcO2TDl44F8e8FviijB3RoL20Yl..faUig59zDk2BOu", null, false, new DateTime(2023, 4, 13, 16, 50, 14, 434, DateTimeKind.Local).AddTicks(9513), "O'Connor", null, null, "0750854688", 1, null, "aoconnor14" },
                    { new Guid("c7381dc9-f92b-4a0d-b6ff-28d4c6c47445"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$l2SMz08B3ZQSaot1dkUW6eDDwpJTrtzBgMKGbM7ybhPQjy6Ljvb5O", null, false, new DateTime(2023, 4, 13, 16, 50, 18, 420, DateTimeKind.Local).AddTicks(2165), "Scheffel", null, null, "0355632555", 2, null, "hscheffel23" },
                    { new Guid("c761ae83-dbbd-4a62-ae64-da30af7ce96d"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$A.6ariSHTyAM7XEOtmGX3eEXnyWaKkUgupaJ1tCzhzDnDMiHgg.qW", null, false, new DateTime(2023, 4, 13, 16, 50, 15, 442, DateTimeKind.Local).AddTicks(9359), "Middlehurst", null, null, "03494633510", 2, null, "dmiddlehurst1c" },
                    { new Guid("c77f69b8-48e8-4fc3-89be-b2ea3a397e3d"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$IwlB/3wqCpSBEitLwNs5.e7Q3q7xqFSEZ1ChUH./.tcseECHZ.VtO", null, false, new DateTime(2023, 4, 13, 16, 50, 18, 821, DateTimeKind.Local).AddTicks(9001), "Glison", null, null, "06769810772", 1, null, "rglison27" },
                    { new Guid("c7cca9d3-97b9-48b2-a527-93dfc96e5b41"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$dSnlYLUBcC0hvc7ObM2A0uc7HA1NYzjWXX9pEI0D0VApQVnn8f0EG", null, false, new DateTime(2023, 4, 13, 16, 50, 20, 655, DateTimeKind.Local).AddTicks(1225), "Saban", null, null, "02156386100", 1, null, "csaban2n" },
                    { new Guid("cab471e4-3a56-461b-b61f-81d8f5abe344"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$u04dJLKbP3iqpkSspgnQGOsBXn2KTeGvgtS8JXY/LiRNsZ2k3px.6", null, false, new DateTime(2023, 4, 13, 16, 50, 16, 176, DateTimeKind.Local).AddTicks(8241), "Mackieson", null, null, "07046670689", 2, null, "smackieson1i" },
                    { new Guid("cc49ff9e-85d9-40c5-9cc8-e7a6d3fb1931"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$vXCd3PTCKX7VMA.SkKsWFe99WLiFJbbXgDqpk4jJtml.XKBY6rJVG", null, false, new DateTime(2023, 4, 13, 16, 50, 14, 333, DateTimeKind.Local).AddTicks(5629), "Cantor", null, null, "0218299981", 1, null, "jcantor13" },
                    { new Guid("cd462c3f-46e3-422a-a08e-c98f12e261a7"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$VuuGzWtgOGJ7zZT8he0Ve.vEHP9NFvBPpyxx9eNsyN6Wqg2IoPkHG", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 550, DateTimeKind.Local).AddTicks(746), "Warnes", null, null, "0812419659", 2, null, "ewarnesv" },
                    { new Guid("ce23edd2-646a-426f-a494-615c1bbd07fd"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$8owB.fuqVkAB9OI9YqEI7OiNq6qLZ8ZI9AkQ6MunlX.eCxBeYOgMO", null, false, new DateTime(2023, 4, 13, 16, 50, 11, 602, DateTimeKind.Local).AddTicks(5443), " Nguyen Van", null, null, "0966416708", -772000, null, "phucnv" },
                    { new Guid("d47b5a35-17dd-4cda-803e-b26491ca99da"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$DJsGqvab7eJDD5qg5bc9Y.bSxT5Vqh54mCXWa8yKMHqYOZafes7sy", null, false, new DateTime(2023, 4, 13, 16, 50, 12, 864, DateTimeKind.Local).AddTicks(7580), "Goddman", null, null, "00110582594", 2, null, "kgoddmano" },
                    { new Guid("d58573f7-9de5-472e-a92c-c3d12eaf9fb0"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$GFEuy.7ysF.19lhddmoO9OBQiPmRiM/iRY0f8zOAz/gC7iAXNTNV.", null, false, new DateTime(2023, 4, 13, 16, 50, 15, 60, DateTimeKind.Local).AddTicks(7), "Martugin", null, null, "02340159874", 2, null, "smartugin19" },
                    { new Guid("d7a1cefe-6505-4644-8f9f-f9743212350a"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$hQlqMqn1cAUjNnAoNZdC8emCAmLeavh9kTJByPrhW5QOKCXh7APpi", null, false, new DateTime(2023, 4, 13, 16, 50, 18, 207, DateTimeKind.Local).AddTicks(1023), "Latan", null, null, "07949258154", 1, null, "rlatan21" },
                    { new Guid("d82f1e13-4bd7-42f5-8357-44865ed78c7e"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$IBS2ENAoOpndtC/4BR09Muh9eWoydpslh/mSG6JsAyXyTnbG.gBjG", null, false, new DateTime(2023, 4, 13, 16, 50, 18, 709, DateTimeKind.Local).AddTicks(3504), "MacKegg", null, null, "05989129010", 2, null, "wmackegg26" },
                    { new Guid("d896d1d8-3f6a-4039-934f-0fc3a462f4dd"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$Jz4fu8PnMSiQXrA65xMDjuNyOmtoklWKT2RznHJLN6/lQJAhr2SOa", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 898, DateTimeKind.Local).AddTicks(6935), "Maestrini", null, null, "0312994030", 2, null, "fmaestriniz" },
                    { new Guid("d926e200-b225-4464-9ed0-862e852d591f"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$1ts6xE9xbkj1ILl6QufjOOgcxobr8WLwgdaLsPX/WkD2pscdOQODa", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 41, DateTimeKind.Local).AddTicks(9859), "Bolver", null, null, "0361641052", 2, null, "bbolverq" },
                    { new Guid("db316bfb-8e45-4977-9dc8-2362daa0c296"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$T1F73eZmdbbLB9nm6Io2Wu4o0n1cLV/r7E2AcJwrwOSG7lw.GfyvK", null, false, new DateTime(2023, 4, 13, 16, 50, 16, 509, DateTimeKind.Local).AddTicks(4939), "Berks", null, null, "04613021719", 2, null, "fberks1l" },
                    { new Guid("dc54c66d-8708-4575-8284-c7c4055a68dc"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$V18GryMPLeyWUAhA1sGYAu4xwmmATl2wt.RDrA48rVZ88ZCGukya6", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 260, DateTimeKind.Local).AddTicks(3470), "Beament", null, null, "0756962604", 2, null, "obeaments" },
                    { new Guid("dce28bd5-ac7c-4456-ba05-d5ffafb89590"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$bqgV1G6nuY9wOdrKHPFIUO7/B6OWMJ0WvlFDnPe2xcy0k4Kk5fuMm", null, false, new DateTime(2023, 4, 13, 16, 50, 19, 629, DateTimeKind.Local).AddTicks(419), "Eliassen", null, null, "06497524328", 1, null, "jeliassen2f" },
                    { new Guid("e14b3dc7-4b97-42b7-ac25-7883ee395f4e"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$NDqXmR8SbYGyW2P14hNZjenBjgYIW4EUqXMlev0jRKWaIO17XpZXa", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 246, DateTimeKind.Local).AddTicks(838), "Yuille", null, null, "00670067189", 2, null, "ryuille2s" },
                    { new Guid("e19c5e4d-cf83-4729-9e4a-dbbed1cd89bd"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$8BWIaEkLgJAbLBpmX.UQDepMM62U3xudqx3CfxL2qsTHHy5NIj4QW", null, false, new DateTime(2023, 4, 13, 16, 50, 17, 570, DateTimeKind.Local).AddTicks(6672), "Zamorano", null, null, "0619225384", 2, null, "czamorano1v" },
                    { new Guid("e503f144-0283-44a0-9479-76c6fdb1deae"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$Rh8xY.pviBWL67EpKaEIY.vCv73k3vB7hKPw3uK.pv1t.WVAGdIai", null, false, new DateTime(2023, 4, 13, 16, 50, 15, 546, DateTimeKind.Local).AddTicks(6291), "MacGorrie", null, null, "0259328059", 2, null, "kmacgorrie1d" },
                    { new Guid("e633a1e3-2243-4ac6-9a8f-c288dd66d11e"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$YfUxsulu65FXh0hJpjlOu.jpapspSuzdstnvYPXtNgWr97mnl0q3.", null, false, new DateTime(2023, 4, 13, 16, 50, 18, 615, DateTimeKind.Local).AddTicks(1681), "Lannen", null, null, "04000508789", 1, null, "dlannen25" },
                    { new Guid("e70c017f-c164-4fe7-aad4-bdf0a6d4f913"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$w1ierrvONxROc7eXcTMgauoUCKtmSecZ5kgvF5S6.ectfoNVB0VJi", null, false, new DateTime(2023, 4, 13, 16, 50, 19, 113, DateTimeKind.Local).AddTicks(7457), "Ainscow", null, null, "0878444767", 1, null, "fainscow2a" },
                    { new Guid("e83ba8af-00f1-4fe2-b29d-a12b32aea0d4"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$cq9ACF7pSBwAMbs2OWARqOzQbLxy7cAIN2Rd3MOlbOCg1lZzIe5mu", null, false, new DateTime(2023, 4, 13, 16, 50, 14, 813, DateTimeKind.Local).AddTicks(1942), "McMechan", null, null, "0613503781", 2, null, "mmcmechan17" },
                    { new Guid("e87d40f3-59a0-4e67-ae20-e1d8ed9c5f2e"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$NRmoEuuvgCJ.QQf4MzhsQO2hv052FyXm7/Iq0xGqp24hdvfQ999Qm", null, false, new DateTime(2023, 4, 13, 16, 50, 11, 901, DateTimeKind.Local).AddTicks(3476), " Nguyen Van", null, null, "0966416708", 2, null, "owner" },
                    { new Guid("e96685cc-b9e7-4040-a8ac-02afca06068e"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$NrkyZov5u5/qzVEPr..svej8Lq8HzaXTy2IXdKj3sr0pFTF9NMUXW", null, false, new DateTime(2023, 4, 13, 16, 50, 20, 921, DateTimeKind.Local).AddTicks(5711), "Vernall", null, null, "05157407415", 1, null, "overnall2p" },
                    { new Guid("e9b4f067-61e1-4738-8ae9-ac6ba0f026b7"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$v17hIywsHs98JRHK/PZZAeRZZAN9EZ0hV9LRwv0/b0mL.Eh201q6e", null, false, new DateTime(2023, 4, 13, 16, 50, 19, 884, DateTimeKind.Local).AddTicks(7527), "Oubridge", null, null, "0429461131", 2, null, "eoubridge2h" },
                    { new Guid("ebd15bed-63bc-434b-8afb-4caff8a7472f"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$A31N8/AxID7R4TV60zxi5uTRD68BI6aAyKopBTIfY2HVK2jbPC4RC", null, false, new DateTime(2023, 4, 13, 16, 50, 16, 406, DateTimeKind.Local).AddTicks(2644), "Droghan", null, null, "0910618733", 2, null, "kdroghan1k" },
                    { new Guid("f05fb8f5-51f3-49be-92ba-15af0ecff663"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$N7Ry8l84WcCGYg36.UEfL.NfW8vM9PCN83./7i4xbpVA4XDwEX7Iy", null, false, new DateTime(2023, 4, 13, 16, 50, 14, 6, DateTimeKind.Local).AddTicks(7760), "Briston", null, null, "02637402338", 2, null, "cbriston10" },
                    { new Guid("f534d2ba-def0-49f2-93c3-5873c8ef58f4"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$bY6LdwOWrGASWGJd6ahxqOU3iI8Zg.cuRA9CWtrGNVF1buLez7b1m", null, false, new DateTime(2023, 4, 13, 16, 50, 13, 639, DateTimeKind.Local).AddTicks(1054), "Lere", null, null, "04037990815", 1, null, "rlerew" },
                    { new Guid("fe6e204e-b3cf-4efd-a4a3-18ca0e88aa9e"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$VzKbs/qSxq4N49YBMQaWvu5ZNT8qiCmYJ6X2k8IaG/lWvkIMDQYjq", null, false, new DateTime(2023, 4, 13, 16, 50, 16, 65, DateTimeKind.Local).AddTicks(7495), "Ashpole", null, null, "03667705539", 1, null, "kashpole1h" },
                    { new Guid("ff26e3a1-eec8-4dda-b9d3-368fce0470ea"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$.zU1qFyckiPZ4dC9UzdGbeO48biRw7F8ClTetOSAQbTJbvp9TiFLq", null, false, new DateTime(2023, 4, 13, 16, 50, 21, 461, DateTimeKind.Local).AddTicks(3944), "Gonzalo", null, null, "0459531972", 2, null, "lgonzalo2u" }
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
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Parkings");

            migrationBuilder.DropTable(
                name: "Dashboards");
        }
    }
}
