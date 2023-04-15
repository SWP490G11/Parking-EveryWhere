using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver192 : Migration
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
                    CarOwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
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
                    { new Guid("15e404ac-d94a-4305-89f6-aed477db4423"), "Xe 7 chỗ", null, null, "SUV7" },
                    { new Guid("3bb78b9d-303b-4f0d-b6f7-5bb5ca570d8f"), "Xe bán tải", null, null, "Pickup" },
                    { new Guid("839b23d1-d110-4514-9e59-065d75113ee7"), "Xe 2 khoang", null, null, "Mini" },
                    { new Guid("bd677bdf-e834-473e-979a-8e0668a6ad6f"), "xe 5 chỗ", null, null, "SUV5" },
                    { new Guid("e5c137bc-1ade-409c-8b94-761ca2b2f95f"), "Xe 4 chỗ du lịch", null, null, "Sedan" },
                    { new Guid("ffddcd9b-1699-4190-8a8e-31ae091c9e4c"), "Xe van con", null, null, "Minivan" }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("af0886cb-1a7a-4bb1-9875-c2918493a61e"), "Short time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, "Short", 40000.0 },
                    { new Guid("f5c2aac1-6dca-4ed3-b018-e4885adad971"), "Half Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, "Medium", 70000.0 },
                    { new Guid("fcca1360-9e29-42fe-ae6b-2fe4439cf720"), "1 Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L, "Long", 130000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "ImageID", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "TransactionID", "UserName" },
                values: new object[,]
                {
                    { new Guid("0081b808-000a-467d-b964-cb1c59ecaaab"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$TYo4jdhw4fw4q6nHH/iQbuKY7tM9DABtKLIWYrwG9FtRzXbpefTzm", null, false, new DateTime(2023, 4, 15, 21, 49, 42, 589, DateTimeKind.Local).AddTicks(6016), "Briston", null, null, "02637402338", 2, null, "cbriston10" },
                    { new Guid("024431a6-e58f-4cfe-bad5-05d1150545b0"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$1OGMTPKgkeXVe94riHfpmOkoeBmjMh6K2zI5y/asEOuT0NJ/IMnSO", null, false, new DateTime(2023, 4, 15, 21, 49, 50, 356, DateTimeKind.Local).AddTicks(4057), "Struss", null, null, "06928824187", 2, null, "astruss31" },
                    { new Guid("06864982-5da9-4051-9545-367629803ba1"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$CwFfHQ5c1URUSlz.SyiEiestCIge9l81jgK3oQ9sHy5YdM77sX1sG", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 444, DateTimeKind.Local).AddTicks(7148), "Petrescu", null, null, "0719013924", 1, null, "bpetrescu2j" },
                    { new Guid("06bd18f3-97ec-4043-a90f-3b29a5476352"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$bSBy52hB3LhuH1opYtCunuumj.ISVD.Swc4mDAP/psUVFNv7Wl6g2", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 943, DateTimeKind.Local).AddTicks(5746), "Zamorano", null, null, "0619225384", 2, null, "czamorano1v" },
                    { new Guid("0731e2b4-07de-4c8f-a9ec-15869ee4f268"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$a6z.FOjhPTM29/bOX1XLHumCt3MdrzkB4kdWJq3qfmJsqQvh27.iq", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 9, DateTimeKind.Local).AddTicks(8969), "Margrie", null, null, "0153784673", 1, null, "cmargrie1m" },
                    { new Guid("075ca681-1531-4f40-a5e6-ab1d2e36f118"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$bWGHZdbwPFcwS393JU.0qOcPo1W1rkMcpR67SbCFP7kfmBjRzTYkS", null, false, new DateTime(2023, 4, 15, 21, 49, 44, 308, DateTimeKind.Local).AddTicks(5415), "Gareisr", null, null, "07314447051", 2, null, "tgareisr1g" },
                    { new Guid("0876a935-4b10-4540-8413-279b6d687eff"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$7TzVxuFTyTsefx82oK7zFewJ/4JzSLPyPJg0EV0eYKI5Kc06geA36", null, false, new DateTime(2023, 4, 15, 21, 49, 40, 93, DateTimeKind.Local).AddTicks(6258), " Ass min", null, null, "0966416708", -772000, null, "admin" },
                    { new Guid("0b9583fe-3b59-46ff-a489-910805869797"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$q4SfBkln/MNRpnaWRAEIZeQ4vWl/WyTfVJNOHEKzc4ifOG9R2D3DO", null, false, new DateTime(2023, 4, 15, 21, 49, 42, 275, DateTimeKind.Local).AddTicks(9495), "McKinlay", null, null, "03957603316", 2, null, "dmckinlayx" },
                    { new Guid("0bc3a320-bade-422c-9a76-5d76e1e09e20"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$8ZbhUoWPvWixiG/GrHtom.u3Bs2//mpITAw2ytmM3qsjrEdjKXKn6", null, false, new DateTime(2023, 4, 15, 21, 49, 47, 707, DateTimeKind.Local).AddTicks(4018), "Jilkes", null, null, "00677856497", 2, null, "bjilkes2c" },
                    { new Guid("0dfb360e-b227-49bb-93c3-d700029e5c17"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$TPILXXyooKabmEXA55QaD.i3LTjojAF5kVsMTXV0vUeBiFPEYnJqC", null, false, new DateTime(2023, 4, 15, 21, 49, 44, 556, DateTimeKind.Local).AddTicks(8361), "Mackieson", null, null, "07046670689", 2, null, "smackieson1i" },
                    { new Guid("0e4506ee-96ca-4c90-98ea-1fe9692d3b56"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$ixdQ6OKOEs7GEOztb1iFce3MbNMa5xgWtKvs7qZBTFDeSyRxU3mYS", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 426, DateTimeKind.Local).AddTicks(7113), "Dunsford", null, null, "00868235500", 1, null, "rdunsfordp" },
                    { new Guid("0e969128-891f-4459-8569-a6545cf0156f"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$IX6DFy/Bq7YQUIIYlvgTEu3yzU80DcogHr10XeQKI6Nn0ZgX14a5G", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 222, DateTimeKind.Local).AddTicks(2485), "Ormerod", null, null, "02807987147", 1, null, "oormerod1o" },
                    { new Guid("14a0a35f-07b1-4395-9a17-cd14e74a7cbb"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$4anNdQD1hTvaDZdWO2w29.2hCgh2ECA2Wm2kYkich29wfpyka6BZu", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 110, DateTimeKind.Local).AddTicks(8068), "Hannen", null, null, "06533305742", 2, null, "channen1n" },
                    { new Guid("159dda21-fbc9-4459-9265-b43520e29d2d"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$bFz0VFbAdPhrn4jVeMPWmeQbv.TS9x5BbRUXOrHqZSc7uLAeHFx5S", null, false, new DateTime(2023, 4, 15, 21, 49, 39, 967, DateTimeKind.Local).AddTicks(1784), " Nguyen Van", null, null, "0966416708", -772000, null, "phucnv" },
                    { new Guid("160e3ca6-0246-42f5-b17d-8a44f3fb31a0"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$aVpSLBJT/mOMELkWTpJzXOl5MApKYPjQJNVm3L7bJkjJw/dFnpNUO", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 882, DateTimeKind.Local).AddTicks(2837), "Swanson", null, null, "09572022187", 1, null, "gswanson24" },
                    { new Guid("164c216b-f6c4-49d9-9209-870cb9ac0105"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$HEXy79dLszDddCvNHk5qAuEYvuPQjC7lWQe0zfjQWH33IQp26.ebW", null, false, new DateTime(2023, 4, 15, 21, 49, 47, 402, DateTimeKind.Local).AddTicks(3814), "Hargitt", null, null, "04664308348", 1, null, "ahargitt29" },
                    { new Guid("1ad23cbe-ab65-4120-91ee-a4d2536e40a8"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$Plg5pPZJw500JM5hvonu3eBsauDwq7JH0pvvssu1ciJ4AkjfLDvn6", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 624, DateTimeKind.Local).AddTicks(3599), "Milton-White", null, null, "0602588523", 2, null, "jmiltonwhite1a" },
                    { new Guid("1b464a94-326e-4f67-a1d9-e43df530ec5c"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$oeKHVzyeRmVIopWo6fv8s.LkHKlKVzltquYX1h/ITa4DDQkhPMgES", null, false, new DateTime(2023, 4, 15, 21, 49, 40, 666, DateTimeKind.Local).AddTicks(1340), "Martinyuk", null, null, "0766805261", 2, null, "nmartinyuki" },
                    { new Guid("2206d768-222f-4714-80ee-efab364c5857"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$nkxFVf3AM5a3LQCfEEI18eisA7RZSICrG1Eq8tCn48o7VGrIK26EC", null, false, new DateTime(2023, 4, 15, 21, 49, 49, 500, DateTimeKind.Local).AddTicks(6134), "Brechin", null, null, "0285671009", 1, null, "lbrechin2t" },
                    { new Guid("23629ce1-c872-4a3d-b792-ca8d6f153b7e"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$zKvSIb9t.uE7W1hTJJkYOeeOMfwqndZXEfkpnhBoyKDFQCscALqZi", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 645, DateTimeKind.Local).AddTicks(7763), "Gasperi", null, null, "03723162025", 2, null, "ogasperi2l" },
                    { new Guid("24789e01-f762-4031-9919-9ad795beea13"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$FfUt5V85LskClxEE32H./eejk4jEDQxkeqvlmzOcAgb3kA0baO3ne", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 532, DateTimeKind.Local).AddTicks(4176), "Bolver", null, null, "0361641052", 2, null, "bbolverq" },
                    { new Guid("289fdf2c-35eb-4198-9a5f-6061bbf2b511"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$AzfoDEYbVqnzqaZT2d4npuikrG661LONcrme.1D271EbuQsVIFjNK", null, false, new DateTime(2023, 4, 15, 21, 49, 42, 493, DateTimeKind.Local).AddTicks(3162), "Maestrini", null, null, "0312994030", 2, null, "fmaestriniz" },
                    { new Guid("2d83a446-251c-4248-bce7-0d5f59aa5cec"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$nwPRvp5JXXtfXd5nUgRo5u1l6Z6mjdCqgITlOtMWcRQvowzlP67Ci", null, false, new DateTime(2023, 4, 15, 21, 49, 49, 81, DateTimeKind.Local).AddTicks(3709), "Vernall", null, null, "05157407415", 1, null, "overnall2p" },
                    { new Guid("330e221b-b4e2-4a32-bbf8-c9fc0657cc76"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$qsjLPDjPudWGx0eGp1aZSO8/ESlTQrMObuwJV57ok2AeA0nms5ip2", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 985, DateTimeKind.Local).AddTicks(6694), "Lannen", null, null, "04000508789", 1, null, "dlannen25" },
                    { new Guid("330e8a2f-7553-422a-aef5-617fa193946c"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$JcAaGRW45T8hTG9pekHXfecYyr2/5.fcor3944tkVNknOT0Ms/Tj2", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 844, DateTimeKind.Local).AddTicks(9448), "Middlehurst", null, null, "03494633510", 2, null, "dmiddlehurst1c" },
                    { new Guid("35eb96bb-7b85-4fd1-be7c-582d9767900f"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$M3/IxT4rYnrfYqYqFZNMYeYdv7HBaBwxYOcsYCWZb5dHkMJxsyu3m", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 745, DateTimeKind.Local).AddTicks(5793), "Barhem", null, null, "08054760577", 1, null, "sbarhem2m" },
                    { new Guid("3940e1a4-e1d4-490a-8b16-38138e526ae4"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$Okws4t.BIS3IRpAuFfvrpOmpiCa5KYrVBgqqQQ2bfJxuSAavcMG2C", null, false, new DateTime(2023, 4, 15, 21, 49, 40, 896, DateTimeKind.Local).AddTicks(6351), "Garrioch", null, null, "0072752247", 1, null, "mgarriochk" },
                    { new Guid("3aa1cc2e-0c9d-4057-ac97-d67c3dffaf7b"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$v9Tj.hL9QDrhbA2YFO9oYepi/CqPL6koYtZHmBgHIaVdY4zjTw5Qe", null, false, new DateTime(2023, 4, 15, 21, 49, 50, 40, DateTimeKind.Local).AddTicks(9470), "Abrahamsohn", null, null, "08144581503", 1, null, "babrahamsohn2y" },
                    { new Guid("3ae2225a-1f39-41f8-9985-688552c9b052"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$BGZtSVqZD11QzPhlkQnsQ.Xh7oGabchJh/j1pCnoyMk8XMV.7di.u", null, false, new DateTime(2023, 4, 15, 21, 49, 42, 895, DateTimeKind.Local).AddTicks(385), "Cantor", null, null, "0218299981", 1, null, "jcantor13" },
                    { new Guid("3d79194c-4a31-4f1a-ba62-c2fe8c7e9ce6"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$C97X9j5bIk0LN/G5u6DHK.8dujshemXEI.6kxxtHjt2M4JTbiT7Oe", null, false, new DateTime(2023, 4, 15, 21, 49, 50, 252, DateTimeKind.Local).AddTicks(7725), "Gerrish", null, null, "04944713025", 1, null, "rgerrish30" },
                    { new Guid("3f8c5e88-31f7-4b76-8c9e-e5cbe6fb39d2"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$B1aNgbEXozuTFLyfRdLCW.YmHjI37NGZB3C9W2CL1LR39uFXHXkJW", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 949, DateTimeKind.Local).AddTicks(6753), "Harnott", null, null, "00039497181", 2, null, "mharnottu" },
                    { new Guid("41db246d-ed87-438d-99a2-b225b89cae52"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$WD/HnJUu99l5tKqQtf8EWewZ75g0JcPZyzbzJ/fojvskH5OhOWiyu", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 539, DateTimeKind.Local).AddTicks(5740), "Hallard", null, null, "03332477053", 2, null, "mhallard1r" },
                    { new Guid("4229b448-881a-44cd-8e84-14c5c36fd511"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$A2zFO3wGSaamUvc/a/qv5.UoINFPS.PdsMndxroCw7W8VqNaT3jlC", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 118, DateTimeKind.Local).AddTicks(3934), "Filipchikov", null, null, "0663461504", 2, null, "afilipchikov15" },
                    { new Guid("4497520a-bb97-42c5-ae97-e8e9c9def4ba"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$fkNOXJWf3x8NE1HTELFEz.yttiFb88QHcBGoSxDdl4bmkeKbTdYeC", null, false, new DateTime(2023, 4, 15, 21, 49, 47, 504, DateTimeKind.Local).AddTicks(390), "Ainscow", null, null, "0878444767", 1, null, "fainscow2a" },
                    { new Guid("457ad8b3-0066-4b35-9b60-90f4e99ced6c"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$.87RgY7ExP5i771qItJV..Xk0/dFcpxaZIuubw65sWQBlcScEzEzi", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 576, DateTimeKind.Local).AddTicks(5548), "Latan", null, null, "07949258154", 1, null, "rlatan21" },
                    { new Guid("47bb5d26-da95-41c2-be65-5229da93eb58"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$I4KbnS2a9eEr2D7DxCIztOS5.S4FFTUS76QfhshtmdOPZUYfRS5T.", null, false, new DateTime(2023, 4, 15, 21, 49, 40, 553, DateTimeKind.Local).AddTicks(7899), "Lavens", null, null, "06895509784", 2, null, "rlavensh" },
                    { new Guid("4ec7c970-7761-42e5-b2da-3a307dd11c2a"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$sXnSFQ.7n7M8yy244DBYkeDBQ9cTMBtZRdsNzcnX7HgUJI0rV3gKa", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 0, DateTimeKind.Local).AddTicks(7474), "McCloy", null, null, "08418620623", 2, null, "tmccloyl" },
                    { new Guid("530d470b-d862-4a77-9023-cbcf48373ffd"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$lA/XVZa5yWVbiD88uIDZvOUGv9s7lUnYYiKq5zP/n7YfzOLg40SNG", null, false, new DateTime(2023, 4, 15, 21, 49, 40, 779, DateTimeKind.Local).AddTicks(929), "Powdrell", null, null, "0569083168", 1, null, "mpowdrellj" },
                    { new Guid("538b5f8f-330d-4171-9f9a-6babe88f3858"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$py/muJQOXblXjT6ZytT/8uJ5U4MsqaEU0RWGpGtQsO8XjYGI3BYaq", null, false, new DateTime(2023, 4, 15, 21, 49, 47, 602, DateTimeKind.Local).AddTicks(166), "Spaldin", null, null, "0596030481", 1, null, "mspaldin2b" },
                    { new Guid("579146ad-4c35-4035-9ff3-25ec83ea346d"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$A0twPjkX8JP5g7kQE2UvNeV5k/ZCgrX4AQpJ/EpxVbjzAUtzUyInu", null, false, new DateTime(2023, 4, 15, 21, 49, 49, 387, DateTimeKind.Local).AddTicks(6307), "Yuille", null, null, "00670067189", 2, null, "ryuille2s" },
                    { new Guid("57bff8ab-7bdf-4564-aff3-f625950de46a"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$qBvt8p/.M92p3nJcU45lS.80JYKoPxxrJltCld1dkpaebudyvmC3e", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 32, DateTimeKind.Local).AddTicks(8157), "Eliassen", null, null, "06497524328", 1, null, "jeliassen2f" },
                    { new Guid("5c869538-0598-45a1-87c6-dce87d0bb051"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$bGQuN7ODwCYOX/9Sf1AoMuckf2DtoOilMLd1dSL8ts5EO3fTEIw8e", null, false, new DateTime(2023, 4, 15, 21, 49, 44, 184, DateTimeKind.Local).AddTicks(4505), "Mattam", null, null, "0865586458", 2, null, "emattam1f" },
                    { new Guid("5d2e736d-d4b9-4ea1-a9fa-a882bf94db2d"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$7pc/lU2wJxgRecMaYKKdcuhzdO9era2NRlfsi/wPwhnIC7fmJq5/.", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 735, DateTimeKind.Local).AddTicks(2397), "Petteford", null, null, "0939882707", 2, null, "spetteford1b" },
                    { new Guid("6460b743-e4c1-4091-943d-565bc906e3c6"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$PnbI6sji.op7Z8taRaMuTuOkQ4N5wQMG4az7I5zs/s9uo9WOT0YMK", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 232, DateTimeKind.Local).AddTicks(9665), "Oubridge", null, null, "0429461131", 2, null, "eoubridge2h" },
                    { new Guid("646e62cc-6eae-4d32-af96-1fb98c81ad3b"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$xb9yc1cGtvlFdqk1kJZkae7qeJwtREgYES9Uh7Zz8vMFvsHPqg9am", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 736, DateTimeKind.Local).AddTicks(8607), "Trippitt", null, null, "00615614760", 1, null, "atrippitt1t" },
                    { new Guid("656484d9-2423-443b-b08c-8343c9ce338f"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$9kHBrizfTHanEBMv5m.iKuPQpxNXv4Ufd2Dtd98zgSQhuMGRVPtJ.", null, false, new DateTime(2023, 4, 15, 21, 49, 47, 84, DateTimeKind.Local).AddTicks(2838), "MacKegg", null, null, "05989129010", 2, null, "wmackegg26" },
                    { new Guid("69b96e06-c970-43af-a093-d279d443fb02"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$ljYmVwakOUiQkLpKihKuHu4TYRoKrgUfeg./X7z1Eja4zlZJw9wNe", null, false, new DateTime(2023, 4, 15, 21, 49, 44, 57, DateTimeKind.Local).AddTicks(1759), "Laidel", null, null, "06837677860", 2, null, "blaidel1e" },
                    { new Guid("6fe3dcbb-c44b-4c0c-9b68-06e40c751213"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$GbhcY4fDSjGZyBdLHGnJXeZF28qsEQ//i8qGS7edoyoiVIaK0BMzi", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 959, DateTimeKind.Local).AddTicks(1168), "MacGorrie", null, null, "0259328059", 2, null, "kmacgorrie1d" },
                    { new Guid("73797714-522b-4a20-a51d-91f8d0f188e5"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$WpmtReWjJ3ir0H3TCZp54OEKlOsKWTlr4VWaG0jieteE.7d3l3E/S", null, false, new DateTime(2023, 4, 15, 21, 49, 44, 888, DateTimeKind.Local).AddTicks(7043), "Berks", null, null, "04613021719", 2, null, "fberks1l" },
                    { new Guid("73fe07d6-c32d-40ff-b41a-16f2eb9ea8fe"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$5agIlVTnYvW0bO6pQwR3su/sh707j7aVll20nSepNboMhi5UTd1Ay", null, false, new DateTime(2023, 4, 15, 21, 49, 42, 792, DateTimeKind.Local).AddTicks(5642), "Dolder", null, null, "0857765771", 2, null, "pdolder12" },
                    { new Guid("770930db-e1e0-4f8d-b566-8aedcdba63fd"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$EGY34JxoTrPjyzXi3S0clu8NSJGXyoAxbPFqHPbYW9BA.9p0C159a", null, false, new DateTime(2023, 4, 15, 21, 49, 42, 60, DateTimeKind.Local).AddTicks(1268), "Warnes", null, null, "0812419659", 2, null, "ewarnesv" },
                    { new Guid("78faa333-e72f-465e-903e-52d1ff33b4aa"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$IJpwZO79glutJuJrB0PDj.Fxra9w4yhRw9NcC8DS7hUNf984xlUDq", null, false, new DateTime(2023, 4, 15, 21, 49, 42, 372, DateTimeKind.Local).AddTicks(5348), "Springham", null, null, "00834111266", 1, null, "sspringhamy" },
                    { new Guid("7a4429a7-a19a-4ceb-bb0a-638a92d998d4"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$WwmXYOrCTy9Ue/COTRRXIe7z.mZHWMaL1umLRzoAOY2cdoinFAWuO", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 522, DateTimeKind.Local).AddTicks(9378), "Martugin", null, null, "02340159874", 2, null, "smartugin19" },
                    { new Guid("7ae90542-5a09-4df2-957b-71189459aaad"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$OdVhsZQSj4amRN17cOV/0.9mXpvSTcLSgdo0PN0OILz6NfgQPfmCe", null, false, new DateTime(2023, 4, 15, 21, 49, 49, 819, DateTimeKind.Local).AddTicks(1761), "Bolliver", null, null, "0699230163", 2, null, "sbolliver2w" },
                    { new Guid("7af5d14b-12ff-45df-a190-f129819b0f2e"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$X7q3SjcnicwFYOyD7vPBSOlQZf6nFrCLhnN2WwPw7bFluYTGjinCe", null, false, new DateTime(2023, 4, 15, 21, 49, 42, 158, DateTimeKind.Local).AddTicks(4979), "Lere", null, null, "04037990815", 1, null, "rlerew" },
                    { new Guid("7bd3dc03-59ac-4e8b-9a57-ada565fd4044"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$bZj7r1caYzrobsoXEHIxqecfejf.Kxl.ee5Trzygxc7o8F5Yp3nCq", null, false, new DateTime(2023, 4, 15, 21, 49, 49, 710, DateTimeKind.Local).AddTicks(4924), "Masser", null, null, "0612845922", 2, null, "smasser2v" },
                    { new Guid("7e138332-7627-48cd-aad9-6cecfd905f95"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$mqCvwAud4CbhYS5jxoLi.OdUfHCbLmbiR1AsBuh47BOiUJsXH8qTC", null, false, new DateTime(2023, 4, 15, 21, 49, 50, 150, DateTimeKind.Local).AddTicks(6927), "Beamson", null, null, "07242980517", 1, null, "kbeamson2z" },
                    { new Guid("7fad578a-593a-40cd-891f-9531db57c1c5"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$snAQVBHYLcmp/mJSJ9CoSOepGSkvLgEYSLdgTdJ1cZJJI9Bt78W8.", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 374, DateTimeKind.Local).AddTicks(6184), "Kearns", null, null, "0461097167", 1, null, "skearns1z" },
                    { new Guid("8266a39c-9b35-40bf-bf6b-240ea5c6add6"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$OjwwbUKpUwMFNGTJNH4L9exwVw7e1owinKDVj8q9L5blWz/VLc49i", null, false, new DateTime(2023, 4, 15, 21, 49, 47, 915, DateTimeKind.Local).AddTicks(2722), "Izhakov", null, null, "05872358652", 1, null, "cizhakov2e" },
                    { new Guid("848caa97-8d0f-4f9d-8774-a9539285a5b5"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$5khIvYlB/Vh6MKfkZkmpJO5.zLc1mxsDpEicLhvB7wfThEVmSGmiG", null, false, new DateTime(2023, 4, 15, 21, 49, 44, 779, DateTimeKind.Local).AddTicks(5532), "Droghan", null, null, "0910618733", 2, null, "kdroghan1k" },
                    { new Guid("8621a098-8249-426c-96f8-a5000c9752bf"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$k6/Om2YjlCkB5ga7QIJl6e.kUEqGr99h2DsNtVhgoZcjbw.xUhpeG", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 432, DateTimeKind.Local).AddTicks(854), "Brockelsby", null, null, "04963800585", 1, null, "jbrockelsby1q" },
                    { new Guid("875251c3-adf4-432a-bbc4-0bc347cec050"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$EboFS8/ezsUSHpGqwsaLm.Qvg0LaQ5DscBPOtfIr9toiJ2vbJWVZi", null, false, new DateTime(2023, 4, 15, 21, 49, 49, 601, DateTimeKind.Local).AddTicks(6315), "Gonzalo", null, null, "0459531972", 2, null, "lgonzalo2u" },
                    { new Guid("88bd2754-93c0-4828-a2d9-f8114e820e1a"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$72Y5kBF4.4LKlqe/EBqGKed8dTzhQlQ6Olz31qpcTJWI47P351lLG", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 862, DateTimeKind.Local).AddTicks(9853), "Saban", null, null, "02156386100", 1, null, "csaban2n" },
                    { new Guid("8abd1ab3-0653-4a15-9322-e24049fe3bba"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$NicqVwPbO1ESnRNVWZC7wONSoy6DxeAhtgyXvzfCXOzJPpUIA65AW", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 134, DateTimeKind.Local).AddTicks(1971), "Fitzhenry", null, null, "04780696921", 1, null, "afitzhenry2g" },
                    { new Guid("8c8e0aa7-1fae-4d91-abdb-c8011a8cbbb1"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$ZiPq5SFhkYi3XD7PYvvgIuDoo3wOCFZK9LFaPuj35sf2TxuG8KxfG", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 338, DateTimeKind.Local).AddTicks(4017), "Haney", null, null, "0041887086", 2, null, "dhaney2i" },
                    { new Guid("8d61421d-cb16-491b-b3b1-411878b0278b"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$HYTvyOYh5TuB3VNpJ8hpWeRqSK8MHoBrvKtVq43Wy3MzPlMlyV25.", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 327, DateTimeKind.Local).AddTicks(9479), "Rameaux", null, null, "0213510408", 2, null, "vrameaux1p" },
                    { new Guid("97780f14-af07-4276-95cb-c8abaf7e3452"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$NrBe1poihXF60D.zUUhsrO.ZW1bmNeX9bs/5ngUr0O.Hw2QTAAd2y", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 638, DateTimeKind.Local).AddTicks(15), "Webling", null, null, "0390471753", 2, null, "bwebling1s" },
                    { new Guid("a16a0531-166a-4eab-8879-5d93f1484511"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$KlepFT9F9/vyWVlEL1ZYl.zW7X37bhyuq7fdhz/.v3lonZFnAz8zC", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 50, DateTimeKind.Local).AddTicks(2723), "Polden", null, null, "0831072797", 1, null, "rpolden1w" },
                    { new Guid("a413e011-6f0b-4035-ab0f-d3b16408cb88"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$3OyEmQk.yssSs5DCP4HH3ej1yWnriB7axi9EU4M5oJ3GDQ2gt.XLK", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 739, DateTimeKind.Local).AddTicks(4940), "Beament", null, null, "0756962604", 2, null, "obeaments" },
                    { new Guid("a4a40a23-9bfa-4672-a78a-be9f02417e92"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$LPha3WJTZgS31kRPuuiIG.fGZwg6M/sX.jBSbbFgsMMZlsmbjDTWu", null, false, new DateTime(2023, 4, 15, 21, 49, 42, 692, DateTimeKind.Local).AddTicks(7099), "Dreossi", null, null, "03724370545", 2, null, "cdreossi11" },
                    { new Guid("a4a925e1-8194-4898-9b97-95d30ce2e0d0"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$VlIiMtA1rI0sPowhvViCIu2omDfbl6VdlBVCcHsrSiGaMP.7fXJLu", null, false, new DateTime(2023, 4, 15, 21, 49, 49, 183, DateTimeKind.Local).AddTicks(4535), "Baldacchino", null, null, "05380625199", 1, null, "mbaldacchino2q" },
                    { new Guid("a7aef945-b9d2-4949-9ad5-bbbbd9792d22"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$VB1AxGzSnW8BWsczzDF0a.s5IRgliTzkGVS.ERjDif9zVpsRgUs5C", null, false, new DateTime(2023, 4, 15, 21, 49, 44, 437, DateTimeKind.Local).AddTicks(6090), "Ashpole", null, null, "03667705539", 1, null, "kashpole1h" },
                    { new Guid("a7ceaf5d-fc28-420e-b343-b50420990d60"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$LdD9uJ.4HuYyoXRy0NzAC.xbak2ne/L9ySGr1tvyqfpTA03nj8d5K", null, false, new DateTime(2023, 4, 15, 21, 49, 47, 291, DateTimeKind.Local).AddTicks(9204), "Canti", null, null, "07734012207", 1, null, "gcanti28" },
                    { new Guid("acd944d7-c9f0-4fd4-9687-3f47bee0f951"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$eV3k0mR.0URa9xfcb76i2urwEjjkKYixRLcKkbgvLTJmqN7iKI5xi", null, false, new DateTime(2023, 4, 15, 21, 49, 47, 815, DateTimeKind.Local).AddTicks(6394), "Faber", null, null, "08586159848", 2, null, "afaber2d" },
                    { new Guid("b19f1e05-c1a5-43a2-b278-ae2d45dadba0"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$kHmJQI0H38EAWxEtpziMkOauGeQtehHRV0CDY6K987cPYb0MEtP9W", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 477, DateTimeKind.Local).AddTicks(3156), "Oliffe", null, null, "0002143579", 1, null, "koliffe20" },
                    { new Guid("b2e01bbd-bc2d-4ceb-b5a0-e04347ff0804"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$ipBUPle57EKbCE5IYb1vf.T.yJrVgOhvnzBnCUZLMhSG6SKFd3xh.", null, false, new DateTime(2023, 4, 15, 21, 49, 50, 470, DateTimeKind.Local).AddTicks(8046), "Prater", null, null, "0629137900", 1, null, "tprater32" },
                    { new Guid("b6c3a84a-e4f8-4fbf-8c94-955be475ed7a"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$1lw5RPYN4m/EPLvIiVG9zetIypHkSqlDYUlfrmaveEroH9Mv6GLS2", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 679, DateTimeKind.Local).AddTicks(984), "Webley", null, null, "0821411907", 1, null, "jwebley22" },
                    { new Guid("b6fb046d-b735-4a8a-b201-0052b9e114e6"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$2UvnCm4FyVUwh0vhXcM0yuvAdFcXPyYM/MMrX0.Mn7d0GTZrJb9HS", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 99, DateTimeKind.Local).AddTicks(553), "Maddyson", null, null, "0915548406", 2, null, "cmaddysonm" },
                    { new Guid("c365d638-2580-42d8-ba02-2fcc2967e8ad"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$0RKlxbOngZoMzcnQ2KPvyOvFvwKIFSaQBFCS0F0U/4JBNk6OPYPo6", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 846, DateTimeKind.Local).AddTicks(2784), "Gostick", null, null, "05617299637", 1, null, "bgostickt" },
                    { new Guid("c4a9cd2b-4ece-43f1-a5fc-523e1adf1084"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$H3mrO38U3mJkj28qEa4Yi.DOfC.9LwXNxmzglMoZcr2gV1txQVym2", null, false, new DateTime(2023, 4, 15, 21, 49, 47, 182, DateTimeKind.Local).AddTicks(3996), "Glison", null, null, "06769810772", 1, null, "rglison27" },
                    { new Guid("cdc4220b-c3bc-4e00-a1aa-d08d5d3d7b4b"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$Q4Nqy7l6hZ8XRh1IOZu5m.ljgj4SoLB6gRDMdN06b3M0IOsEaByou", null, false, new DateTime(2023, 4, 15, 21, 49, 49, 938, DateTimeKind.Local).AddTicks(9882), "Elgee", null, null, "0961523438", 2, null, "melgee2x" },
                    { new Guid("ceed30f6-70c4-4f85-af13-e6bd43ff9037"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$9maivw1I41oomgB0HYoJA.W/J44dy5KX9PBUCG8IhNlNg08jNF.kq", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 422, DateTimeKind.Local).AddTicks(8788), "Strooband", null, null, "0129884328", 1, null, "tstrooband18" },
                    { new Guid("d4a817a5-0bff-4f09-80da-2f37e4ad0fe7"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$SzAhg6hGraSkVCJaMuJCg.PX75aQ5F0m3UcreB1YeF8/bRX49266O", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 972, DateTimeKind.Local).AddTicks(3532), "Andriessen", null, null, "05873824805", 2, null, "candriessen2o" },
                    { new Guid("d5b7e3c7-e52f-4b8a-b563-4b7361d5acd6"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$6FbRI02GLlMrOfBPRdePDuP3PT4fafLKgQccO0Qiw7uVNLqtsijYi", null, false, new DateTime(2023, 4, 15, 21, 49, 40, 328, DateTimeKind.Local).AddTicks(6373), " Nguyen Van", null, null, "0966416708", 2, null, "owner" },
                    { new Guid("d9ac4ac6-7bdd-47ba-963d-b18a98178110"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$XD30KEZMvtjDdlvZjz4KYu2QJdQ/sktkFYlT03gPdaeahnxrRYFLa", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 322, DateTimeKind.Local).AddTicks(7020), "McMechan", null, null, "0613503781", 2, null, "mmcmechan17" },
                    { new Guid("dbe5e5de-68e9-4e79-b518-250d36b4b720"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$bKuekEGi6/pDONK7HLvOuOIcRIRV2xphCpQwmOM1kAoorLyqy8oTu", null, false, new DateTime(2023, 4, 15, 21, 49, 40, 445, DateTimeKind.Local).AddTicks(1579), "Tubbs", null, null, "0630308378", 2, null, "gtubbsg" },
                    { new Guid("dc41d063-eaac-4721-9976-c969f4eeb7bf"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$kx4JsxKDlji.00UJ/6ZTJuyrM4Q/SMlLHs1UbiapjKaUf7JDIi86i", null, false, new DateTime(2023, 4, 15, 21, 49, 40, 209, DateTimeKind.Local).AddTicks(4299), " Nguyen Van", null, null, "0966416708", 1, null, "customer" },
                    { new Guid("df4b06e4-0a91-49d8-82fe-17b24f4294f4"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$ZzTHUuRjQ2kgN.powgFiQ.fH9rOf0tOQ8lLbVeO6T2VGI3vghQ5EG", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 1, DateTimeKind.Local).AddTicks(2733), "O'Connor", null, null, "0750854688", 1, null, "aoconnor14" },
                    { new Guid("e13a00e5-4953-411e-bdf1-6ced5e6eb2f9"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$CLgGmck.QaPN5wZN7DTLrOvU9us7vlBNgpHi9ceXPNeGZ7w1uRiUi", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 783, DateTimeKind.Local).AddTicks(281), "Scheffel", null, null, "0355632555", 2, null, "hscheffel23" },
                    { new Guid("e201bea7-44ff-4888-83e1-e73c4cc2c4ff"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$qi9Z60t5O8Fl7kSNzBRAMOEG3n4KClf1LqcBTpWksUtyRx8KYQaFK", null, false, new DateTime(2023, 4, 15, 21, 49, 45, 842, DateTimeKind.Local).AddTicks(1684), "Scirman", null, null, "0195375651", 1, null, "ascirman1u" },
                    { new Guid("e2b14842-6179-4bee-89a8-c2ec1c2fd916"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$eTFBQasOPne0dENItULuLelk8vnj8v2cYzp7nZY5OArwOgzbIB/GS", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 317, DateTimeKind.Local).AddTicks(3990), "Goddman", null, null, "00110582594", 2, null, "kgoddmano" },
                    { new Guid("e59c23f0-ecd5-427c-a375-e92bfcd20113"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$QQjWNiwA4Rr02FgcVyRHMuQ4e1EAsjU7fqhpQ8PoXjOMEfeo5HCSq", null, false, new DateTime(2023, 4, 15, 21, 49, 49, 289, DateTimeKind.Local).AddTicks(5362), "Iacovacci", null, null, "0770070777", 1, null, "siacovacci2r" },
                    { new Guid("e8ee42c4-1083-44c7-b854-ca0c01216e95"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$1nhL9cNRtaTBARITvgElTunlwEvqVr1t/WIJlEtU6k5pwqw2mvZHC", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 637, DateTimeKind.Local).AddTicks(6389), "Featherstonhaugh", null, null, "0737666977", 2, null, "dfeatherstonhaughr" },
                    { new Guid("eff0936a-1b54-4753-b2dc-35cdf903306a"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$lN/O9rZmNGhviP8XROi2R.FcbbIxbiZT5ZRCC1we8pL664429o8lm", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 157, DateTimeKind.Local).AddTicks(742), "Stranger", null, null, "03239623484", 2, null, "gstranger1x" },
                    { new Guid("f39672a2-b617-4c54-bb29-f11804d581a1"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$hWAFhfpKuQ5Sunuyt5gPtu2a4dPHKT85IUr8uM4eUANQzJiRFDKfK", null, false, new DateTime(2023, 4, 15, 21, 49, 43, 216, DateTimeKind.Local).AddTicks(6669), "Kroch", null, null, "09201855247", 1, null, "okroch16" },
                    { new Guid("f4d8c845-5614-457b-81b7-16f35518a359"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$48.11G3OT5Et9DjgcmiQ4.fJ1TIL2d7UXXJH0/pK5lIKxuWOcerLO", null, false, new DateTime(2023, 4, 15, 21, 49, 46, 255, DateTimeKind.Local).AddTicks(2243), "Batrip", null, null, "0734926905", 1, null, "abatrip1y" },
                    { new Guid("f6723d5b-f9c1-4ced-bcd5-8f6bc2e02982"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$YLLy4y.1JtmJcJTnsRqBAu5odLUM/eFg/uPWJypntS2gXx8jh7YIe", null, false, new DateTime(2023, 4, 15, 21, 49, 48, 546, DateTimeKind.Local).AddTicks(331), "Howland", null, null, "00133370415", 1, null, "lhowland2k" },
                    { new Guid("fbddfd59-0b25-42b0-b62e-5185ed4fd8f2"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$bomEsOcXkCWjaQfGBYcW1.sRxEGSKsAjFFxSg6neAi5yYmMmENv.K", null, false, new DateTime(2023, 4, 15, 21, 49, 44, 666, DateTimeKind.Local).AddTicks(8747), "Shufflebotham", null, null, "0960301131", 2, null, "pshufflebotham1j" },
                    { new Guid("fe0ccf03-0ccf-41e6-8752-e599e35e1157"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$doA0BY8cWJcbXfzzkO/zheSpRwMHiLtd.9/YxOBYRee8HYrrw76lW", null, false, new DateTime(2023, 4, 15, 21, 49, 41, 199, DateTimeKind.Local).AddTicks(8685), "Skirvin", null, null, "0614302061", 1, null, "mskirvinn" }
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
