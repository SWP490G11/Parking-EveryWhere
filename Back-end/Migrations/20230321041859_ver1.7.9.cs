using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver179 : Migration
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
                    PublicID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
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
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MembershipPackageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { new Guid("23c3c40f-c1b4-4d50-afc7-765a1a1bccea"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("2d569106-0e51-4c21-9e67-161a035a73c8"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("3bae70b1-dc12-497b-bf24-bbe6dc9bd869"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("74df1b83-9f77-40cc-bff0-0d7c0c7030eb"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("af6aae8f-a950-4d84-8bff-b882d4975b61"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("dcfc5dfb-a945-41b2-89d5-9615cfefe94a"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("67c9d456-e766-4241-97f7-12641d6f6eaa"), "Half Year", new DateTime(2023, 3, 21, 11, 18, 59, 200, DateTimeKind.Local).AddTicks(2886), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c06f628c-f259-4689-a546-b78defe3b1e9"), "Short time", new DateTime(2023, 3, 21, 11, 18, 59, 200, DateTimeKind.Local).AddTicks(2881), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2c616ad-ee50-4394-a687-c897c4ff80fc"), "1 Year", new DateTime(2023, 3, 21, 11, 18, 59, 200, DateTimeKind.Local).AddTicks(2888), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("03b88cf2-0138-4949-837a-4173df2c6cd7"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$kdEZ3ByRyjWXKzPR20.NG.xJx2xM3nI34g48DeAaD0rH1/o92RSkC", false, new DateTime(2023, 3, 21, 11, 18, 55, 82, DateTimeKind.Local).AddTicks(803), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("05e40c3b-2083-4793-89f8-4940fc12c2ce"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$c2YY61fZmb2Sh.LgeFJ4Y.rxe3W0z.LYKM5Mx76zKtNwEtKjR7WoW", false, new DateTime(2023, 3, 21, 11, 18, 50, 999, DateTimeKind.Local).AddTicks(8308), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("07555f9f-f71f-49a4-adad-e9b6454e44fc"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$kn0w6/PVf.akm./A1.OWY.oTrVR8uxv9c.K2TjP6cE0R7hMbVklWa", false, new DateTime(2023, 3, 21, 11, 18, 51, 483, DateTimeKind.Local).AddTicks(2128), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("089ef8ad-3951-4e78-b013-614c6c4ce9f9"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$wvwjTbzXvN84HGx6LstCiuv.3S5I8N.CkvGhPgmaK96oqT1k3I57q", false, new DateTime(2023, 3, 21, 11, 18, 56, 487, DateTimeKind.Local).AddTicks(6077), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("0c0db2f1-d989-4614-b8c9-9cbafeed34a8"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$oHtgU2Gs7l6eaZg6W4xwKOH3KUYmwaJR5XuEOIeFqOuaU7we9pVRW", false, new DateTime(2023, 3, 21, 11, 18, 49, 688, DateTimeKind.Local).AddTicks(9809), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("101e9299-84e1-4f07-843c-75fd3077abc2"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$jGTE6WJOesUeufJfEoOjDew2waB/NYfAM2yxLqil8N8wgCNRoMfpq", false, new DateTime(2023, 3, 21, 11, 18, 58, 996, DateTimeKind.Local).AddTicks(7210), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("11488978-0c13-41f8-a981-80d174ceddcb"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$BkKJV2c0N/hYSADvXzM9FO4dIG.H6Xzg8cvMtffT69jbDSL0t9xEu", false, new DateTime(2023, 3, 21, 11, 18, 55, 424, DateTimeKind.Local).AddTicks(1910), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("118860c6-e4a4-4c72-835f-5d04a5855c1b"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$BQufN9Mvvq95DjQ4KlbXieY9a4ctiQxYsllMUQXHsJ/hEI2aBjhe6", false, new DateTime(2023, 3, 21, 11, 18, 52, 493, DateTimeKind.Local).AddTicks(6393), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("11d65846-2465-4810-8035-b322a6219a0e"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$CsfIwqUPsosv6FNv/eoKQ.skrPz/SLBEn.tJEQ9D6wWhSB8p/E8Te", false, new DateTime(2023, 3, 21, 11, 18, 55, 877, DateTimeKind.Local).AddTicks(9621), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("154120f3-969b-4cdf-a596-a6feb6455e19"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$4OM.PiI8aF3BNM.PEO2fOezA0h7Lm6Qjr98Sv4ZXiUkwE7ssZkmry", false, new DateTime(2023, 3, 21, 11, 18, 52, 632, DateTimeKind.Local).AddTicks(3979), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("169132dd-2a3a-455c-bd17-1faccf377494"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$E37MEO1q7reXj2cqa9KFm.qogQpdwJFomBrwL54Q504OV1p7PI2EG", false, new DateTime(2023, 3, 21, 11, 18, 51, 389, DateTimeKind.Local).AddTicks(1827), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("16e946db-ec8a-4b17-9564-449ebcc3a4ef"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$5x.Bu4HvfTyoRtZbd94LfOnPYf5YKLTwVmb9vxqJpeejTmEh1UdWm", false, new DateTime(2023, 3, 21, 11, 18, 53, 256, DateTimeKind.Local).AddTicks(4818), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("1b2783de-04b5-45a2-9263-64f26a1364b2"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$xcL1bLFDC.zKjTxgL7sg7OYWnxZuLhjUhBdavnqeWpSPb/X6ZSUpK", false, new DateTime(2023, 3, 21, 11, 18, 55, 200, DateTimeKind.Local).AddTicks(9005), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("1d98c0f3-605e-47d4-9369-23db5636707a"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$a1zNLMGX0AUYoCa.Nh9bT.7g1BpWWHQhCt1vdXVbNiPijwh9Eg4li", false, new DateTime(2023, 3, 21, 11, 18, 56, 383, DateTimeKind.Local).AddTicks(3388), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("1d9edd7e-3d73-4351-8268-b750e735091e"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$3KzECQY4mCwrshdjDWZ1/ev2oi6uNd7ZCOEUKLXx7Wu2e02QG03E2", false, new DateTime(2023, 3, 21, 11, 18, 58, 293, DateTimeKind.Local).AddTicks(2741), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("1eaf8a6d-80c7-49ae-bb85-9069b7ee5937"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$3GSXQvfq305V7Zf8lXsVEe2eUIbn1yfq5gYXf0ybmtIusWusbrAYS", false, new DateTime(2023, 3, 21, 11, 18, 49, 155, DateTimeKind.Local).AddTicks(8539), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("20ad28dc-50a4-4962-b399-be1dbfea68e1"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$D1Y.xXgu0UqBZNSMcZWssukoPmtGnQSowM2ThJd03SH4YJgBjVlvS", false, new DateTime(2023, 3, 21, 11, 18, 50, 318, DateTimeKind.Local).AddTicks(3142), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("22e20167-882d-4a15-9b6d-63feb8c46489"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$9ZAd9DZbuTxoobl2L.is7e1PgsTz2UWaoHEDKAfGBS0Z2G4lYQNea", false, new DateTime(2023, 3, 21, 11, 18, 56, 823, DateTimeKind.Local).AddTicks(5822), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("27d0ac1a-1062-41a0-a573-bce99f16f802"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$Ue8f021w8aeISz6VXIH4SOMeRI86sRfDfGQnKUb7.V2/bo2oS0nNG", false, new DateTime(2023, 3, 21, 11, 18, 49, 272, DateTimeKind.Local).AddTicks(7412), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("2acce6bd-091c-44b3-bcfa-a9561ea3e8a2"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$KARyT8nPzEblmkoNFQbwIO4xmj483ZKgF9/KN3MDC8h4pu/2eZO7q", false, new DateTime(2023, 3, 21, 11, 18, 48, 724, DateTimeKind.Local).AddTicks(2277), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("2b290295-dea1-4138-a8de-b65ef601bc93"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$ph7DffnrZMfa/ELcV/CtVuLF4.WXwGzGdaSmU3mMqKLpxKuwnBMJq", false, new DateTime(2023, 3, 21, 11, 18, 57, 750, DateTimeKind.Local).AddTicks(6349), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("2eee6557-90b5-4a82-a0ad-154d5568f3d9"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$T2Wgjhn0VT7YiwOIwAhjs.cH9nQq/VGBwUlonXldZTer18AjryHvm", false, new DateTime(2023, 3, 21, 11, 18, 58, 605, DateTimeKind.Local).AddTicks(6281), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("2fa14ba4-48b8-40b1-a66e-132a9f20d07b"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$eOXDhroboMoKBe6j3AX82.1vMHLYX70A.I4kSrQP5IA5SYnLBTewC", false, new DateTime(2023, 3, 21, 11, 18, 56, 608, DateTimeKind.Local).AddTicks(2490), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("340a4dbc-2ad6-4470-8095-d3301c370d0b"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$t2QjPihlPXSrif/yyXHhougNhlF4D4hZzpfVqsPEQmuHT3zam.EF.", false, new DateTime(2023, 3, 21, 11, 18, 58, 683, DateTimeKind.Local).AddTicks(223), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("37f46434-4376-4c4f-9211-50d4d07fae21"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$FIzvrx0rEpg0Q4a59lw8w.teccQD8/Bmb4ot32cB8r5Ww/VuYhfTC", false, new DateTime(2023, 3, 21, 11, 18, 48, 825, DateTimeKind.Local).AddTicks(3507), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("383c1b64-5d1d-4422-8813-9e12856e9f9e"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$YOPaVA6/gpncIBbHNg7PAu0AlqqxMFLgiYqVNbGo9amLLvSyNVjg2", false, new DateTime(2023, 3, 21, 11, 18, 52, 758, DateTimeKind.Local).AddTicks(4770), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("3e64a623-fd8c-4731-be84-88e0a5c59d03"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$0yBbGNYZA7UIo/SkRKsZgOVnqsTE3zCGwiwq4YyHIxz8G/PBIPTLe", false, new DateTime(2023, 3, 21, 11, 18, 55, 681, DateTimeKind.Local).AddTicks(8850), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("3edd7d4b-a76f-4cda-ab19-d36d0bb98209"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$AxhWO2MgqgELlTiV2O8V1uDJbooQAoKyN/HpihFnRQ2tpco83XCD.", false, new DateTime(2023, 3, 21, 11, 18, 54, 523, DateTimeKind.Local).AddTicks(6811), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("3eff5738-e677-4205-96bb-ecdb2f413728"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$9dY54TcyY41hBSkivFAB/evmWLcnUD4IQ6SbZZjkGuOijjls2RD5y", false, new DateTime(2023, 3, 21, 11, 18, 47, 617, DateTimeKind.Local).AddTicks(5606), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("40351a8c-f6a1-4de1-886e-ffe586fd1ee4"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$mNORa1YI58F8gv5VjrzkMun/Okqfs4HiyXC189CtKQPmqRLD0RLZq", false, new DateTime(2023, 3, 21, 11, 18, 58, 372, DateTimeKind.Local).AddTicks(3436), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("41d8aefa-4204-43c4-b2c3-80f943ac7cd3"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$1Wl2U5csDP4XtMo8mgkKuer5v/JMk1kQxnV8y9ND5lKommxfGFd52", false, new DateTime(2023, 3, 21, 11, 18, 50, 417, DateTimeKind.Local).AddTicks(5806), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("4308e25b-e06a-4730-9af6-0610b775b7a5"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$Nq7.5o9xDlgvacY4HUbM..CdHQAHgKV8ZLbuBrRIoAZ7zTK6Jd91W", false, new DateTime(2023, 3, 21, 11, 18, 59, 200, DateTimeKind.Local).AddTicks(2291), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("4afc2647-a1ed-4ac9-ad53-77ce00b70c50"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$i1MxL3TrjaSAjP78UobD2eHb.0YWOPh8s2IFVILrCR9PyRJAOaDdu", false, new DateTime(2023, 3, 21, 11, 18, 57, 910, DateTimeKind.Local).AddTicks(6964), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("4c012130-1640-4b09-b028-e3c909122367"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$gFC4lKXLtpvN5v5NR5nckO8iasVXzdpmvc3VqatFa33ZCznIFNPhK", false, new DateTime(2023, 3, 21, 11, 18, 49, 795, DateTimeKind.Local).AddTicks(7970), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("4cefb5df-89fb-4d5b-9201-e6b2acdf1f5d"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$ZsyvYwIH43yts0QAKML7XusxDUu3rjJlQanSo7AlGAo8WBOscmTAu", false, new DateTime(2023, 3, 21, 11, 18, 53, 813, DateTimeKind.Local).AddTicks(3454), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("4dbf23de-ab73-4a80-a32c-bb7e15d6393d"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$PbNP3QNp2IZ1r6c3aQ1eyOkgZsB7AS87BIiL5pT4mr3hVjVRluIQO", false, new DateTime(2023, 3, 21, 11, 18, 57, 827, DateTimeKind.Local).AddTicks(7282), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("4dfe9858-ca7f-47f3-bc92-ecfb7a5c4d1c"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$lvpRp5ss/81ko5MzwXU0A.ULczfTutOBhVoTGWPGieS/n2SwSQAoS", false, new DateTime(2023, 3, 21, 11, 18, 57, 670, DateTimeKind.Local).AddTicks(8269), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("4f134486-0b5e-456d-91b0-ac8f90c84beb"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$IaUPnt0ypzEJMuGT.NMcgeTHk85.CtPsqVw1zFOSW3.4EI2TX44Gm", false, new DateTime(2023, 3, 21, 11, 18, 56, 36, DateTimeKind.Local).AddTicks(9194), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("501e7a9c-f157-4ea4-9008-1c7c2e7038ca"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$OQsAIRhraSex/OMtewIwi.3f3qh24wJPegEBlF/pKFlywodW/63xa", false, new DateTime(2023, 3, 21, 11, 18, 47, 828, DateTimeKind.Local).AddTicks(7718), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("51592217-ce60-4f9d-a8c4-85179e387cca"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$b7R8PoYmL3gw4NspKkARd.kidDmUXJhFYh4QoE3aAKVebQ.vHZkRy", false, new DateTime(2023, 3, 21, 11, 18, 59, 105, DateTimeKind.Local).AddTicks(7578), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("519f51af-a66d-433d-acfc-00969eafe9b8"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$Pa7itPR2M6igSfJfzrbYbu7jmQrgwIpSTswRI5Dd.mHtyIpnv9wQu", false, new DateTime(2023, 3, 21, 11, 18, 49, 589, DateTimeKind.Local).AddTicks(2373), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("53903841-8c76-4272-9957-0a4fac4284c1"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$WSq0WuQk0V30yhqbGpjyC.iTPz3dnZEybg4gu.YgpgZnHkSvwfyV.", false, new DateTime(2023, 3, 21, 11, 18, 47, 989, DateTimeKind.Local).AddTicks(9919), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("54fd07f8-e133-47a7-88f5-ac9e2c9c6f64"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$ute9GUDphNOyMjjQ.D7pPOqoADwJijhN5ejIPtIHiFR/62Qf0lDaC", false, new DateTime(2023, 3, 21, 11, 18, 48, 209, DateTimeKind.Local).AddTicks(2257), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("57b2c8a7-ef74-486d-9493-370a3f0cd8e6"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$nr8OaZVYpSg1AlnpHhZW2uQX18rXw6toDmed8sOfV0oRkIymoU68u", false, new DateTime(2023, 3, 21, 11, 18, 52, 99, DateTimeKind.Local).AddTicks(639), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("5a625273-221f-4878-9203-3fbb17e1de97"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$IgAlJ5NPVcaX7UlToAio3eXgIEe3cymzuL/vkqdXZplEwsnYF/Q4K", false, new DateTime(2023, 3, 21, 11, 18, 57, 499, DateTimeKind.Local).AddTicks(3144), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("5b0d75d6-f7d9-4bde-a352-3ebcdc969f5f"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$yybTaJ19GMx29ICCqETVVOCKdIenZ6bkJcgT5kY6otrM76Webx2Gu", false, new DateTime(2023, 3, 21, 11, 18, 51, 290, DateTimeKind.Local).AddTicks(3597), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("60da9bab-eb37-4c91-8429-812134b12a61"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$8y41n3qIm9JLmANRDK1DlOM9o4WfrSlvlEetwGC2YGrp4Du2JVqeG", false, new DateTime(2023, 3, 21, 11, 18, 50, 822, DateTimeKind.Local).AddTicks(4850), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("627a1114-e3e6-41c0-a85f-6477dca9297f"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$74CYEOaoC2B/aCB.D0zlhOWTu2mifFvOQThLnWhtNdfTmM4jGAN7q", false, new DateTime(2023, 3, 21, 11, 18, 50, 517, DateTimeKind.Local).AddTicks(302), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("63c0d4cf-68b5-4afa-b03d-3840fa7159a0"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$r4Y4TRsW3ZAMjly5oWMs2O3J1XFPEbNaKrD.Wph0rGjeL/nitg3/u", false, new DateTime(2023, 3, 21, 11, 18, 54, 984, DateTimeKind.Local).AddTicks(440), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("66334a92-3c76-4ec2-81e6-bcc1bec2cdfe"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$h108yPeZm37OY9edu5BBo.fRvHGXyGGVaIMicWd.KYFubcoYMWVvu", false, new DateTime(2023, 3, 21, 11, 18, 54, 622, DateTimeKind.Local).AddTicks(1097), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("67808e43-4bd0-4293-8cc9-fab4cdf6a38e"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$hVBkr5tUqd0NrKQ0YOKtr.aWWx1bMc.VgapyQ4GagGIzNMSKSetva", false, new DateTime(2023, 3, 21, 11, 18, 52, 0, DateTimeKind.Local).AddTicks(8370), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("698f0d2b-4a60-4c42-8d7b-f40b4dfed7c8"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$H0Hws9iv4uAJ00ZOpyttVOo/8BZUe0ERKRou.0P3naNgnAgOrwtO2", false, new DateTime(2023, 3, 21, 11, 18, 53, 697, DateTimeKind.Local).AddTicks(3448), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("698f8d1a-3de4-40be-a7bd-cfc378fbd1ca"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$f0gPE7Pyho4ttjv/JGesGO.DKHGFPYozCnJddYy69xHMW5RChWpZS", false, new DateTime(2023, 3, 21, 11, 18, 56, 165, DateTimeKind.Local).AddTicks(6566), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("6ac0832d-3e52-40ee-8690-2336f5096850"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$OzTynkfBMXIVEWcKDxyLzOH.bcGsVf64I2PUcjtkQD4qUCahVA6oO", false, new DateTime(2023, 3, 21, 11, 18, 58, 528, DateTimeKind.Local).AddTicks(3749), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("6b4d3b27-21a8-4529-a79c-21c32c1db51a"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$LEDVRTzG4UOVD7qmgbGpJuV6W/F0MOkRnveRLzMQq676fpbKt936O", false, new DateTime(2023, 3, 21, 11, 18, 58, 450, DateTimeKind.Local).AddTicks(8131), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("6c3a2068-7296-4f31-a320-109152966215"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$h6ypykTJAzf4nmE005zwNuLOqPHaiHpGvS4GvLvqqoIaghKxfvcda", false, new DateTime(2023, 3, 21, 11, 18, 49, 390, DateTimeKind.Local).AddTicks(1177), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("6c910095-9a74-4f25-9383-706cce73042c"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$ldbs8XqyWjzMblsP2zsJlOlgs0vcUxg4sq3G/Mi1MTPfqq7d4q/QK", false, new DateTime(2023, 3, 21, 11, 18, 51, 575, DateTimeKind.Local).AddTicks(7664), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("6f51f9bb-b6c0-42a3-b741-fc43dc0df467"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$DCSB7jETxHBYAlEJINxoQOe9dj/Cqb0GFWT3qt23ZbNmMq7IbZ8Xy", false, new DateTime(2023, 3, 21, 11, 18, 51, 880, DateTimeKind.Local).AddTicks(5046), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("6f57788a-2f87-4373-bf69-674933854570"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$Y9DL1KrRu1Gq4edrrmDCc./M6DvNGGbhIjOucKjZuYP01.5U.6tZu", false, new DateTime(2023, 3, 21, 11, 18, 52, 198, DateTimeKind.Local).AddTicks(695), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("6fed6a6f-3583-4d51-b61d-60e9b0dc47be"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$3osuJ5NMWr83DwYpSu5XHux8/FIMVII71FctdV3B/QR4Pasi.YdfG", false, new DateTime(2023, 3, 21, 11, 18, 49, 56, DateTimeKind.Local).AddTicks(8700), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("7133d536-5360-4771-b528-b000e221d9ff"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$eD94m.YFz0vuHlzjNXQwje9HEVJpTFpE1HoQO0cbmGjzp1NtuoaDC", false, new DateTime(2023, 3, 21, 11, 18, 52, 909, DateTimeKind.Local).AddTicks(2683), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("7201d41d-7dd3-41fe-923d-9e1c170e7375"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$ax3NFINDP/gIGxuBqX14L.kax4jxZJe0CmfIFBxieLTmZ302zpiL2", false, new DateTime(2023, 3, 21, 11, 18, 52, 383, DateTimeKind.Local).AddTicks(5841), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("77adda92-fb7a-413b-a0f1-b7e88c3a6199"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$00FB.G6qDEt.QFcqDVeGveyv2/CtY.F8RpiQknmVcFXUrM/NfQCl.", false, new DateTime(2023, 3, 21, 11, 18, 50, 203, DateTimeKind.Local).AddTicks(7395), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("789319f2-f7d0-4e5b-ab7f-4e3b45af4524"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$o5pOsxClnFAeWlF.1k1P2ONDoVk4EZe6UqKRALgSWf1nKrZp5nliK", false, new DateTime(2023, 3, 21, 11, 18, 53, 602, DateTimeKind.Local).AddTicks(7066), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("78a0b0d4-b217-4235-968c-39b7c0d2819b"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$t1vz31IxRTdKu.o6DGOe/uZIaWBHO2v6ZrgJP5kgJ93VJXgJCZ34e", false, new DateTime(2023, 3, 21, 11, 18, 50, 622, DateTimeKind.Local).AddTicks(4321), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("7a8f9566-5432-440f-a599-b3da67093aa5"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$99N5KFiLHCPW8u7joOQAGOP9DbOTnW.FsYmHBF5S.EsBYRXmhAfJm", false, new DateTime(2023, 3, 21, 11, 18, 57, 84, DateTimeKind.Local).AddTicks(6709), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("7ec6f8b6-44b8-4d25-8449-db775484de79"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$U8ZiJM8KDCDUqmtkbP1C2eN50halzvxzPAQNJkg6BNCcAIve6s2GO", false, new DateTime(2023, 3, 21, 11, 18, 51, 756, DateTimeKind.Local).AddTicks(110), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("810e85b4-5624-4fcf-9468-6f51f64116ee"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$ZjxREMB1ocBKitnFO413T.ewzPuus3II/jN4dZ/AE15FT3c1Sd6qC", false, new DateTime(2023, 3, 21, 11, 18, 54, 412, DateTimeKind.Local).AddTicks(6024), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("83d35264-d0d5-4cad-a13a-24e802f14f45"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$Qehv4eE8yNs1gyv1hNz9oeO5In1qkzvT2D6gY5UDActvXeavq6xL.", false, new DateTime(2023, 3, 21, 11, 18, 49, 495, DateTimeKind.Local).AddTicks(9331), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("84003dc2-9b29-4517-ac9f-6cc691642661"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$cvKFL2/6oEG6kOx6mXNy1.1ztOIjr6HxmWg8CA8OfGeCRYLRkdHJK", false, new DateTime(2023, 3, 21, 11, 18, 56, 716, DateTimeKind.Local).AddTicks(3416), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("84520370-2d74-4915-8243-283b02191c2d"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$CqvgIMYG6XkWB.vNAQDG7ebWrlCqGzDVvKcwSNN2jQ41gJLoMUbeu", false, new DateTime(2023, 3, 21, 11, 18, 54, 756, DateTimeKind.Local).AddTicks(6580), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("86d43d6e-b428-4387-ad20-55dfe22f5ecf"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$YHRgotApNd4KUWOGcf9MkOG/Wfst77R5s0AVt9s7dd5/sKFEOOlzO", false, new DateTime(2023, 3, 21, 11, 18, 51, 666, DateTimeKind.Local).AddTicks(6671), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("888d0e95-a518-4e1a-8b4d-3510df74c42a"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$zNTeqmi9N0B3jQWHOMn5VeoO8j4KXrbwY8FDgW/R/Ih2x8Bx5KSQu", false, new DateTime(2023, 3, 21, 11, 18, 54, 877, DateTimeKind.Local).AddTicks(9644), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("8ca79379-28f0-4d02-be28-40ba4abbfd12"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$Ri322esLPHPz8KeMjk1txufFrqS7m2adD9S8ozEg9tIf/LN370MSi", false, new DateTime(2023, 3, 21, 11, 18, 48, 957, DateTimeKind.Local).AddTicks(3041), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("8dac3676-4a52-478f-95ca-d9086d5bb1ac"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$TGYT2wXTrteL/x0nh9hYfuetzkzXMfpGHy7MCfkuct/jqnq7h/K9.", false, new DateTime(2023, 3, 21, 11, 18, 57, 290, DateTimeKind.Local).AddTicks(4434), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("921cc02d-aac7-4ab9-a75e-b63854f9d31b"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$Qw0GyLrfrXk2KKqte9FfeuHS1s7R9d46Ej4ROjer9yRXlSXTVE28a", false, new DateTime(2023, 3, 21, 11, 18, 47, 469, DateTimeKind.Local).AddTicks(4574), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("92a18444-6855-43cd-82e4-5836ac0580c0"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$UT1B8pdStfWVaARdf0rNQePS51CLU85.pC4gCeC6CVdHqwhBKLdQi", false, new DateTime(2023, 3, 21, 11, 18, 56, 915, DateTimeKind.Local).AddTicks(8845), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("92ca544e-34f9-4830-b20b-07d572c7fad9"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$0zK9CNBJZecxiDx0V0Ks3.KDc2WxhtJAz2xL6aw9vP2d4FZ/af/CS", false, new DateTime(2023, 3, 21, 11, 18, 50, 913, DateTimeKind.Local).AddTicks(9161), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("93cb3ac5-5ef9-4931-a780-187b0787c734"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$Wcxhz1ZAXFHIg6O/YhL2Y.Zy3gcAc7cyUCUKg/LbRBsxOwa5ZYRHu", false, new DateTime(2023, 3, 21, 11, 18, 48, 518, DateTimeKind.Local).AddTicks(934), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("997d6fd2-ceeb-4459-a0a2-099bfde46a34"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$Pmx6.yKYGymxJDLVrH5Jae9lvZ4mvLb3gbTsEBv78UsPYD3i8a2Zi", false, new DateTime(2023, 3, 21, 11, 18, 49, 990, DateTimeKind.Local).AddTicks(9028), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("9b5d1e0e-c753-475d-bea5-82194bd726ab"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$41173ccYquARtSCO2SQ8iOMyWAPJzpRbemPtdePsjyKjoaYbvwfMe", false, new DateTime(2023, 3, 21, 11, 18, 58, 15, DateTimeKind.Local).AddTicks(5060), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("9eff428b-ceb3-4cdf-a8b2-1d8076c87d66"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$36..btY8A0pVdL2XNHDKSOtOt/fKFEbFbzcGSxEABEMGU0fyRqAdu", false, new DateTime(2023, 3, 21, 11, 18, 53, 925, DateTimeKind.Local).AddTicks(2990), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("aada867f-03b8-4f84-a1e0-8167e526a9c3"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$R.v8XPFCUkqjHxEkFSVyxe3FQ.b1aD0x1kJP6lzbxv5icQkQnVtWm", false, new DateTime(2023, 3, 21, 11, 18, 57, 2, DateTimeKind.Local).AddTicks(4453), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("ab6ba68d-5e60-483a-88e5-6fb859370bb0"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$ZfvRbbX7mVRZu9s34P9dVejvzB9qhb.au1D7EXHbaD6ELRtxEQIz2", false, new DateTime(2023, 3, 21, 11, 18, 56, 277, DateTimeKind.Local).AddTicks(1872), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("ace62858-7117-4ecf-90f7-ba2423a30afa"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$TNpF51L8u0ROahQ9tE/4Fe7ZeFnLoHANSfcK/cptRI5.7I6ZsZt2i", false, new DateTime(2023, 3, 21, 11, 18, 54, 180, DateTimeKind.Local).AddTicks(2910), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("ae4d4225-a99f-4f26-a077-b612b637d2d9"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$5lPi8M9FsiLXKIMlZP8cEuQb6wr99Ag7GpmqCN1v8tXgLT/Gck9Fe", false, new DateTime(2023, 3, 21, 11, 18, 51, 186, DateTimeKind.Local).AddTicks(2271), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("b5368d80-6955-4909-95c8-e1ac32ed0bb9"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$kmxB8wwtdmw/HXCx5nRIRORqyR2K4IaMlb/Ufe/e9h9bCp5yJGwQW", false, new DateTime(2023, 3, 21, 11, 18, 47, 726, DateTimeKind.Local).AddTicks(5782), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("b5bb1924-f710-49c3-8f41-9741ae0b6fce"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$JNpE4xekkDRFwwkrG8mL1Ob2H3UvjYKP5Gi0skj1W8ee8GIylvTee", false, new DateTime(2023, 3, 21, 11, 18, 57, 168, DateTimeKind.Local).AddTicks(263), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("c0c2078b-b9ee-4da8-90e0-953672f2960c"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$VRSzzEheYpmKMj3F0vHl3eBbo4WpREnBgwfPojnClmNQcC67OaZPy", false, new DateTime(2023, 3, 21, 11, 18, 50, 723, DateTimeKind.Local).AddTicks(5430), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("c0f1bbf0-1065-41c1-88f5-9ee4dafee63e"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$1EAwAvQvPNYogMGjdEN/9eiHHl/0DYZ4xwghwQlWdF3SCs57BqDJW", false, new DateTime(2023, 3, 21, 11, 18, 48, 314, DateTimeKind.Local).AddTicks(2272), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("c18ea66a-ca23-4dde-99f1-a6d3ac43e763"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$QxCetMtwF1zYT1PaqOVcauOTk9WYBt7s4J64/2R67PUXYgLid3BIy", false, new DateTime(2023, 3, 21, 11, 18, 54, 285, DateTimeKind.Local).AddTicks(2036), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("c3c297f6-9a4f-41e8-9da1-c4e735ae41a0"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$F4QZAGQ6Uu07RI2xBAhtEe7hZfo59Rvn5XO0eXCkMgNUrSh/roGqW", false, new DateTime(2023, 3, 21, 11, 18, 54, 45, DateTimeKind.Local).AddTicks(265), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("c64fbb23-7d92-4615-9119-0f567f6962b3"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$ZgfvZtX.lqek5FzJaH7M7OA2dd127xBDqTVHAFO3D3CXwQBzsXtbK", false, new DateTime(2023, 3, 21, 11, 18, 58, 903, DateTimeKind.Local).AddTicks(3182), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("c74bc67b-6764-450a-bbcf-18e0cd3bc7a8"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$NozfqapdzrOrm6If2t7wouomf5LAXNwrwkQdG0U1sqxthGViHiiH6", false, new DateTime(2023, 3, 21, 11, 18, 55, 550, DateTimeKind.Local).AddTicks(8483), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("cc3d5756-55d8-43d6-a5c0-789c592df49b"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$WKJMmuMhvZaXExr2nRGMIO/.aUt/p5wXwWFBy.ZuhihcgCfj9/r2K", false, new DateTime(2023, 3, 21, 11, 18, 53, 16, DateTimeKind.Local).AddTicks(6175), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("cd31ef2e-9c2a-4825-9ca0-73a794f0134b"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$Y0bikf52ujM.AWK.1SDYDOrt4b1FTkexN6fih2K28Lc72kpQcViY.", false, new DateTime(2023, 3, 21, 11, 18, 51, 84, DateTimeKind.Local).AddTicks(4358), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("cf38f939-701d-4eb2-b5bc-9e37dfd27632"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$rUemVAQ5HWGiWR8gty.BY.Emd4ARsG0hnHVMaNsH9J36hGfrF/XwS", false, new DateTime(2023, 3, 21, 11, 18, 48, 427, DateTimeKind.Local).AddTicks(7670), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("cfa78623-2165-44e4-85fa-9960b3a60c20"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$xNecpp/oVnXfcOIVdbM/deU.8LdG5AwhVHWTH18lOzTgbd12xdkOe", false, new DateTime(2023, 3, 21, 11, 18, 58, 126, DateTimeKind.Local).AddTicks(6558), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("d961e3ee-7b53-410d-bc73-5fc68378f345"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$kV3vC3f782ahSw7G1gOGvu0.kSsn4gIIxMfCNqv5BFNjReBPTAiby", false, new DateTime(2023, 3, 21, 11, 18, 53, 479, DateTimeKind.Local).AddTicks(9582), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("db57f0e5-b8b3-42e1-ada0-d58226672b7d"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$wCfO0qu6479On5hHTQOoX.BGMiT4g1puIK4R7LrfP7sUYUOrOcAjK", false, new DateTime(2023, 3, 21, 11, 18, 55, 781, DateTimeKind.Local).AddTicks(9883), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("e3299220-a668-4d4c-82a9-e6060e3cbd53"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$ndaNHP05nWDub0iz.uCoA.cZOgf7cpPjeg1DHvLRg3DNqtWV/S3cy", false, new DateTime(2023, 3, 21, 11, 18, 53, 369, DateTimeKind.Local).AddTicks(5757), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("e42b7fdb-8895-4452-95ed-c013c3ca65de"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$gSUgOH9ewAw4I9BzqiSDu.eJO4VuQbrLISw1WyYHpzB4Os7ZU.SHW", false, new DateTime(2023, 3, 21, 11, 18, 48, 626, DateTimeKind.Local).AddTicks(6482), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("e748d394-9b3f-4283-b69a-612eaaa48371"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$pirMPcoApwQWO6btuPmzW.HON4Ier3I1OSYyQ/Y2Y6IeUA5myaLQi", false, new DateTime(2023, 3, 21, 11, 18, 57, 389, DateTimeKind.Local).AddTicks(2163), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("e82db93e-f4fa-4ae6-b6be-46448c741afb"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$AdaC5gLA6i8y0ZCDgpmQMOtL8sbQqMtwcTWq4O6e0Q4Ey9b.sRLES", false, new DateTime(2023, 3, 21, 11, 18, 48, 105, DateTimeKind.Local).AddTicks(1613), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("ea83d953-872f-4d2c-871d-151f2d8a116c"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$wb0..lr9da1998BuaezSauE1/0djv46FCs..rTC7fZldTVDC1ZOIK", false, new DateTime(2023, 3, 21, 11, 18, 55, 292, DateTimeKind.Local).AddTicks(3755), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("ec32b0bc-0597-4b75-b27a-24f628ea4fb3"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$esnfalS05PhCzIOg2UbIb.NeoVER0QUc8QrEK2HXMJMsm2GphVl9W", false, new DateTime(2023, 3, 21, 11, 18, 53, 115, DateTimeKind.Local).AddTicks(1825), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("eeb44fba-135b-4baa-a774-6e6378265cf7"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$UpLX78b.ltHwLevBB8gGy.HzGAXZcLQ0sj6wo9PxhC.VAg4XpcriO", false, new DateTime(2023, 3, 21, 11, 18, 50, 101, DateTimeKind.Local).AddTicks(6825), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("f4cc5f63-1fdb-45bf-8cab-ab55e06bf6d7"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$o86/Is5JGXFR0RT319r6HO90rjLg86UHK7qAsn9nSIuoQnrSgE9Nq", false, new DateTime(2023, 3, 21, 11, 18, 49, 896, DateTimeKind.Local).AddTicks(4088), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("f5300ffd-de00-4cd0-a5fb-6b45383055a1"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$JkKY.hmYQif5kkqgl5I0Me17rbPslcInjCnW9B9YQXzyCxWHWVL2q", false, new DateTime(2023, 3, 21, 11, 18, 58, 801, DateTimeKind.Local).AddTicks(4270), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("f6ba78ab-aae5-45ca-9841-06a735df4289"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$d8zo4EK8UCRGnxQGtTTsJuZLS4Kgib2cXAv3bX4.5f3qMoGfv6zZe", false, new DateTime(2023, 3, 21, 11, 18, 52, 294, DateTimeKind.Local).AddTicks(9661), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("f6dbd926-f977-4f37-8e78-70b9d0b36169"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$65QsYiUy0J9CFGO6YqWp9.HLZtPo.qAvydMCpgJsFkA5AFJ.4Y.Fy", false, new DateTime(2023, 3, 21, 11, 18, 57, 587, DateTimeKind.Local).AddTicks(5711), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("fe8f42e8-f876-4f13-8469-239a008bbac9"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$CcV.mV1xcc/mLlHxGhG0V.dZEvOKu4EnqFd6gdkMe10cdkPzJBNyW", false, new DateTime(2023, 3, 21, 11, 18, 58, 211, DateTimeKind.Local).AddTicks(9211), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" }
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
                name: "FK_Dashboards_Users_LastModifyByID",
                table: "Dashboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Parkings_Users_OwnerID",
                table: "Parkings");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "ParkingDetails");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "TimeFrames");

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
