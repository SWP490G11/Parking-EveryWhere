using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver185 : Migration
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

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("41252dc3-08e5-410a-bbf6-540d48286490"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("5add8da2-15d2-4021-8d88-b07783f3295f"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("5c26c38c-b015-450b-845b-ec7e85902d4c"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("6d00a2cd-2d30-4545-bfbc-2fa0235e8dc1"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("7e1cfe4b-8ee4-432e-89ab-4c6fbc79fd75"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("b1a88ee1-409e-4a98-8301-b4481be969c5"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("20f9e3f4-e90e-40ef-ae9f-6f15f0793569"), "Half Year", new DateTime(2023, 4, 6, 2, 41, 34, 266, DateTimeKind.Local).AddTicks(998), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a217d74-c2df-47f9-b3a2-d67171427dc5"), "1 Year", new DateTime(2023, 4, 6, 2, 41, 34, 266, DateTimeKind.Local).AddTicks(1002), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d0716338-3369-4663-966e-f0a0d42f5d3a"), "Short time", new DateTime(2023, 4, 6, 2, 41, 34, 266, DateTimeKind.Local).AddTicks(988), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "ImageID", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("03818230-1660-4865-8c47-0c2f2ccb4903"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$lkJ2LQMubRW0Rhw.mv9nb.76dMn1DhEwzxB7NfrLx4qmjIm7idwlW", null, false, new DateTime(2023, 4, 6, 2, 41, 12, 932, DateTimeKind.Local).AddTicks(6508), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("04d29470-f759-496c-ac84-2fbcfcbcc8b7"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$PzzlIAi.4YDscw8wfEctO.XTmIApN7tqTRoX8y.mFaAJK5hSJuSg6", null, false, new DateTime(2023, 4, 6, 2, 41, 15, 933, DateTimeKind.Local).AddTicks(7781), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("0aad22c1-1121-47a1-9e4b-2fdcb11bc3b4"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$r4FedrC3gqWZhp3YhVC6yugCEpLt2lL.nRih4XTUWd.ZdV3kITa12", null, false, new DateTime(2023, 4, 6, 2, 41, 29, 286, DateTimeKind.Local).AddTicks(1196), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("0ca42be0-7530-46de-bc2c-0eeba66e6601"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$viUOySg7/vi3AuPC129SU.D0sDHNC1rGR9u/BTR4sNAMB9SdJri1W", null, false, new DateTime(2023, 4, 6, 2, 41, 9, 510, DateTimeKind.Local).AddTicks(3349), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("0d0d3b86-c27f-439a-b229-2197f1b26f8f"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$e3q1gmwmp8a0zarQaf5Uo.Zjtri/9zPk1xJ9duvHg13UCCtI1H3..", null, false, new DateTime(2023, 4, 6, 2, 41, 26, 641, DateTimeKind.Local).AddTicks(4830), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("0e65a500-50f4-484d-be94-b4f4decadcf5"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$YITep7cPjPasjucLNxvuleuCqk3NgSP2i6D5EneSYaRdxHQ6fxiGy", null, false, new DateTime(2023, 4, 6, 2, 41, 9, 735, DateTimeKind.Local).AddTicks(2220), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("1113148c-5ec7-4c93-a1b0-c65c47985418"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$n/AyrOWp6mvZHjN3C3OYYeUlrH5ejm5coZEFS03kvvu6Sv4XmfiRa", null, false, new DateTime(2023, 4, 6, 2, 41, 23, 175, DateTimeKind.Local).AddTicks(9751), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("11869cfa-26c9-497b-8d97-dd32f819af8a"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$mVfbNLgtmbWposnzAAF69.CP0LNfwAPYi.ANmFtSCqm7hXxYmWfr.", null, false, new DateTime(2023, 4, 6, 2, 41, 12, 260, DateTimeKind.Local).AddTicks(670), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("140499e8-7147-4b03-bf72-8c7f67f30cc5"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$ZEgjFUH6W8m0wnvBeAj3mue/6pPoVpX/ElVNXPHFiQ845TheC9ble", null, false, new DateTime(2023, 4, 6, 2, 41, 20, 845, DateTimeKind.Local).AddTicks(9877), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("151dfb17-7b84-487a-9074-1d882de6eb95"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$6awPuzCAz1XhkEsauojfsubYpP2MbakA1aJXX92NxelrYiMRKC46y", null, false, new DateTime(2023, 4, 6, 2, 41, 6, 925, DateTimeKind.Local).AddTicks(510), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("18a7e2d2-a238-4fde-bedb-97c09b33cd20"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$NU2rCZZavdfPeNEU/3uKYeF0QK8TDnkpYPStFMzuUHWKWFAmRzaq2", null, false, new DateTime(2023, 4, 6, 2, 41, 9, 101, DateTimeKind.Local).AddTicks(3697), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("1988b0d4-5c1a-4748-b80e-da931a9e5686"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$obyMlKV./iSgDHetrPqxhe4hOiYEuDVXYFEI0g.lmUVBniQUDRVFi", null, false, new DateTime(2023, 4, 6, 2, 41, 19, 43, DateTimeKind.Local).AddTicks(7582), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("1a5a7f45-81aa-48f6-85fc-4043f56fa50e"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$QfE/Pf1SoXy81SZT7ZdM1OxEhE7JGTKvDh1N2xH6G87bSnRkLCRBy", null, false, new DateTime(2023, 4, 6, 2, 41, 7, 370, DateTimeKind.Local).AddTicks(4345), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("1acafdc8-a2e4-4f94-bc23-e7e3233854ea"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$BmyvA1gBZX6kDMdaHsuTY.Oy2zsWJGp3nYiEj2aR4jzMeiXqzCbaO", null, false, new DateTime(2023, 4, 6, 2, 41, 14, 626, DateTimeKind.Local).AddTicks(781), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("1f3048b0-3a62-475e-9b24-1f08ac472363"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$0m3YSMSoO3fqJtumBdC4L.518bWLJhL77zDUNtr.vGtQhdgnLT1Yq", null, false, new DateTime(2023, 4, 6, 2, 41, 13, 936, DateTimeKind.Local).AddTicks(8169), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("20c7f71e-b6e8-4688-8ae8-1462f5030211"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$KcaTSG448kavuzUelZ4ZZu/a2MR7KBXBWep1Gh/GzO755dj/K8/9i", null, false, new DateTime(2023, 4, 6, 2, 41, 14, 821, DateTimeKind.Local).AddTicks(4020), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("2347208b-38e2-4d38-b4a5-9e189cc0318d"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$DaVJnctZyxbzOLRmTvr.Au8NtgLJOdH7wlhQ54cFLIdaJkyPN6BPG", null, false, new DateTime(2023, 4, 6, 2, 41, 27, 476, DateTimeKind.Local).AddTicks(9981), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("245c0daf-4281-4eb3-9a7e-dce064c95a53"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$4tUQMV9aYRA8XZtSmI0W1e81A/LbdoEWFxmcqn96/N6OYKAr8f4oS", null, false, new DateTime(2023, 4, 6, 2, 41, 13, 462, DateTimeKind.Local).AddTicks(6931), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("2b433ca0-0a7a-4fe8-a230-47c17fe535e9"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$w.EFCab01rADgiUoiWVIIOajtV.wHxR4EV9ePXqxY8RJFonydTapG", null, false, new DateTime(2023, 4, 6, 2, 41, 17, 508, DateTimeKind.Local).AddTicks(3865), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("2caf795d-a432-4ffc-af74-893259aeefef"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$p4aAjCc5EIYbcSDpVxkT3.3dhGaxWsKtKZC9XDF45eKo6F.ebkGzK", null, false, new DateTime(2023, 4, 6, 2, 41, 33, 237, DateTimeKind.Local).AddTicks(3329), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("2cfa2815-ab07-482f-a25e-feae79e3c7d8"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$BFDbSzF25qH2DehKXGTliuE4qDwozS5u4Kq/EOQWWnFHfRNXU.D5.", null, false, new DateTime(2023, 4, 6, 2, 41, 26, 322, DateTimeKind.Local).AddTicks(260), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("2e0267ca-21c6-417b-9375-87b082d80c23"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$B8d8UM72zD23aWfGs/FDAOWJqg0E8S4YmzXtLEj21tQQoQkNQBmDa", null, false, new DateTime(2023, 4, 6, 2, 41, 15, 77, DateTimeKind.Local).AddTicks(5643), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("3322abf4-ef3b-4b11-a425-c1682bd89e5a"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$GeJMeOu9B2O8n/vWk4Z6te/mV8W69whDcJ8dwCSqb3L3DWPrLedfW", null, false, new DateTime(2023, 4, 6, 2, 41, 14, 400, DateTimeKind.Local).AddTicks(1931), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("37d757bb-ee58-4f48-87d5-f883a129c10b"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$xaVV.b05DOMID2sNwAdBRef9XXNpfaD43XESS.3GuezTZn1VmXILS", null, false, new DateTime(2023, 4, 6, 2, 41, 23, 636, DateTimeKind.Local).AddTicks(6741), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("38cef0bc-642d-453c-a84d-76cc3f742a73"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$TIgAA43ZPr8Nscbe6tCEAOvMWSQRtrZZ96g0KJS3D8YHbYBGsMT22", null, false, new DateTime(2023, 4, 6, 2, 41, 31, 857, DateTimeKind.Local).AddTicks(7701), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("38dca9da-92b4-4854-9a2f-ad5385c3b1c2"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$NZMg.HEN7LJyayBUyIN2WecPMx7XV2W1YquzWU2/V9uRcB9eohg5W", null, false, new DateTime(2023, 4, 6, 2, 41, 20, 79, DateTimeKind.Local).AddTicks(5693), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("3bdde94c-03bd-4461-9d2a-556c188dc885"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$IJWu/CB6ZnahGSuv8OVJwurXTFtpCT9FI9v7.pzAjzt.OqlspraZK", null, false, new DateTime(2023, 4, 6, 2, 41, 15, 279, DateTimeKind.Local).AddTicks(4254), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("3cbdb5ee-ff90-446a-9da1-dd523854d605"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$HBOBwketUFPMLfMol.j38uI3FEzt.Ep47s6Ugj12bsjGCyk4kSEN6", null, false, new DateTime(2023, 4, 6, 2, 41, 29, 798, DateTimeKind.Local).AddTicks(5858), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("3dbad14a-6325-4924-863f-e270093b4a9e"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$b95Rm48MKIrgjHScfaAt2.hDPH3lgiyvJ4BdA.vGYP0lxAtJyx9pS", null, false, new DateTime(2023, 4, 6, 2, 41, 21, 976, DateTimeKind.Local).AddTicks(2597), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("3e464b87-49a5-46da-b064-e0167d38aacc"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$4Ti1BSXUABQRrTyeHVy9e.daL3uux2DDRWpx/KeNKBBNp8IsKT.t.", null, false, new DateTime(2023, 4, 6, 2, 41, 13, 244, DateTimeKind.Local).AddTicks(2532), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("428afd01-e6dc-425a-940d-e025f906ece1"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$3UfQ9Dt9cHdOgkpt4/VN5.iLC6Zh4gartBZJQWJliz33eTvgjxE2i", null, false, new DateTime(2023, 4, 6, 2, 41, 31, 62, DateTimeKind.Local).AddTicks(4955), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("43005f16-08ec-4dc2-884b-c1207b4e3faf"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$0BMK6J71Hdtj51phMsnC5uZT9vd/7Ycjp8fO6JxwTdyi.nU7Vrt3W", null, false, new DateTime(2023, 4, 6, 2, 41, 30, 241, DateTimeKind.Local).AddTicks(4552), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("43c7d5c7-30ee-4dad-859a-77b6c9eb56dd"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$PfMSwOx7ib3ydHBMpy1aeO3LysAStbKtBFTd7lv6AZXQ92pc61uYi", null, false, new DateTime(2023, 4, 6, 2, 41, 6, 474, DateTimeKind.Local).AddTicks(2511), " Nguyen Van", null, null, "0966416708", 1, "owner" },
                    { new Guid("44d56bcf-830e-4c3e-8926-5d4822728bc9"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$G/4r2/3hO082jjV8YUzLbuydBg.CdCMoxymK5l3sBD9Wn3D8u3ecK", null, false, new DateTime(2023, 4, 6, 2, 41, 27, 778, DateTimeKind.Local).AddTicks(7432), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("47971375-a195-4574-a168-5ccebd9d429c"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$CB8AnX4KwjykFqK8zlieyOSrIYypf52lNSRYQUqGgpEDTHOC/bjDK", null, false, new DateTime(2023, 4, 6, 2, 41, 31, 333, DateTimeKind.Local).AddTicks(648), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("47bb4f50-b5be-4ca0-9c23-5b5a6007e63f"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$5CuUGnLJ/6R4fMFa.ohMO.seZaZU7c7al0AEmNjGj/oujiu8Ypq4W", null, false, new DateTime(2023, 4, 6, 2, 41, 7, 163, DateTimeKind.Local).AddTicks(422), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("47cb5458-bd65-40c5-a9cd-3df1af918ef1"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$WyaH2XIe/IM70sq4uK1IHemI.MaaXkZnZFeUE4I5kmmBhf77i0ABW", null, false, new DateTime(2023, 4, 6, 2, 41, 29, 534, DateTimeKind.Local).AddTicks(6603), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("4ce0949b-c190-4a30-9f6a-f21136ff3607"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$ZiEY9k5VBw4PbHA1Zf4ba.l8CdQucGVSN5oLkBxcNu4K70JYNI3pK", null, false, new DateTime(2023, 4, 6, 2, 41, 19, 534, DateTimeKind.Local).AddTicks(2645), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("4e3a443d-d212-48c9-a4b6-d6841cc3dbfe"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$j75iHblTsQHrYjTDGT6wHuqSFhE9LoEiLHxArNwClpU99Cn.Zyvd.", null, false, new DateTime(2023, 4, 6, 2, 41, 12, 485, DateTimeKind.Local).AddTicks(8306), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("4eda28ed-e26b-436d-8fe1-775afe3ce19c"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$SXnCfBzknFF38ZySurlKKe2JXWHDOMBP7SGBxiDgJG8atpZqGkQ8a", null, false, new DateTime(2023, 4, 6, 2, 41, 21, 310, DateTimeKind.Local).AddTicks(6600), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("50af8be0-937b-4418-9799-9a8fb7b4b29e"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$J.7ouERphwR71vON3kmxy.3RwbHrTjIAcRsHhgzMrxXtprP5m1.qq", null, false, new DateTime(2023, 4, 6, 2, 41, 31, 596, DateTimeKind.Local).AddTicks(3372), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("51a49142-9732-466f-8128-9b5ce9bcae53"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$Me0J/Rzr480gx0398dSndOGOqzGkA9QH7rsF5ubdJhbEAcuXxAPf6", null, false, new DateTime(2023, 4, 6, 2, 41, 16, 869, DateTimeKind.Local).AddTicks(145), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("56ff9022-eeb2-4de6-af1f-e131e5cff1d7"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$GvXFXX4eucwlGuAq5Md/suUHp1Kx7qWrvCYUIOV.P784Ds6zJP5kK", null, false, new DateTime(2023, 4, 6, 2, 41, 17, 311, DateTimeKind.Local).AddTicks(6246), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("572eb8c6-a067-41d4-b042-dc2a404e0b90"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$CUsPoBfin1x2tgfDtcP3muLpYrCDzp/fTtOuu1E9iHpybzkU0IUaC", null, false, new DateTime(2023, 4, 6, 2, 41, 22, 908, DateTimeKind.Local).AddTicks(7470), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("582c5594-45a3-4fd8-aba1-6e9c76297cf0"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$FlzxN6CI9Gg4T/0whq3Ld.sYxtLbLnd.dj3EN6x2txArX6/wn36QS", null, false, new DateTime(2023, 4, 6, 2, 41, 12, 673, DateTimeKind.Local).AddTicks(8228), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("5fe2aed1-4b22-4db1-87ef-12e2ed07cc2c"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$u.wW69oik1e/xrjFzkEZ7.68Hy5es.N/rMuiD7rINI/lEm8XVfWkq", null, false, new DateTime(2023, 4, 6, 2, 41, 15, 538, DateTimeKind.Local).AddTicks(4269), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("644ca5d1-715f-43f7-90c2-cc3b416ac218"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$1i9irRp1ymhw72rAP6dFFOkHGlXtdquV7bm55xk4cCDYjCV0fc98q", null, false, new DateTime(2023, 4, 6, 2, 41, 25, 364, DateTimeKind.Local).AddTicks(152), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("662d95a6-bbf8-48fc-a0ab-c5ca0be033d2"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$VKHikNJvHAWeMj8cC18/W.2dQ9nNlgilk5vxBS/AxCjVZTvRb4tiy", null, false, new DateTime(2023, 4, 6, 2, 41, 24, 352, DateTimeKind.Local).AddTicks(5237), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("66a79d73-f5b6-47b7-a728-d5cf9779c272"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$VhKJi2oa79l8dNpQbWYfaOEdJaSkd9EWhREwJb5kDN/oOjFltPo5W", null, false, new DateTime(2023, 4, 6, 2, 41, 28, 743, DateTimeKind.Local).AddTicks(5073), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("703576a2-28ec-4635-b094-cc7c00e8a803"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$rE2F89G7X9FxqQ6jyc8N7eX0bg08/ah8z5.HXunbJLWlpdTFaUDwO", null, false, new DateTime(2023, 4, 6, 2, 41, 32, 975, DateTimeKind.Local).AddTicks(6593), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("7055fb44-5bdb-4e70-b4a0-2945f2c839df"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$Mm3VsG9tYtUq60ls1RRKu.M2d0Syv2uoaYWEQmyhLYHAmbh/8VDCy", null, false, new DateTime(2023, 4, 6, 2, 41, 18, 450, DateTimeKind.Local).AddTicks(721), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("711db8bd-c7f8-4a6c-9265-fde026eba476"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$QYHrbUC9nRfQc0Mif1SO2u0DAw7gIriLbfGRD8WXNXyPtS5ccP2J6", null, false, new DateTime(2023, 4, 6, 2, 41, 9, 324, DateTimeKind.Local).AddTicks(1890), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("72e93a63-6717-4ff2-96da-cd7753c450bb"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$zfSzlWQzqocJO7I.g5tcS.FUzi3UNMi9Ygvx5wQIqEK52WEkHuPaW", null, false, new DateTime(2023, 4, 6, 2, 41, 24, 77, DateTimeKind.Local).AddTicks(3669), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("7377bcc1-c986-46ea-b33e-f923bf0e13fa"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$M6udw4Vws21y7J8qrmAgT.05RU4.swfDfYw2JABeYHyUtHrINWytO", null, false, new DateTime(2023, 4, 6, 2, 41, 22, 223, DateTimeKind.Local).AddTicks(8424), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("749b4989-f174-4a77-b4da-44fe2e730a31"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$zNIbmDQwzm8CO6Sbi.oNROl89CZf4YKvK.ALdTXK2.DtTXNKh9hEC", null, false, new DateTime(2023, 4, 6, 2, 41, 30, 808, DateTimeKind.Local).AddTicks(8452), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("7707994c-2bdb-4767-af75-abbd429983f3"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$Xm1GkB2dqOypoE./G/0Inu.vtgeUEStkhdw1UcLeREsZl.8dSCzU.", null, false, new DateTime(2023, 4, 6, 2, 41, 22, 462, DateTimeKind.Local).AddTicks(8875), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("770da654-6f7d-4ce6-932d-ce24d10a392a"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$dDX91VQKyoBdoqBYXy4T4ONrlf6Lt9EQe5WW6FcVAP269egyKwTPe", null, false, new DateTime(2023, 4, 6, 2, 41, 7, 799, DateTimeKind.Local).AddTicks(4912), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("78c000d1-7ec5-46da-b53e-242e8f704d6d"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$YOcL8jFM.6AAG3wzpZw6hOpw3Er/ksMGby3yTMUGRxtHR/0/wqF/.", null, false, new DateTime(2023, 4, 6, 2, 41, 8, 658, DateTimeKind.Local).AddTicks(1998), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("78f74505-6b81-4937-ae97-f86c9974d278"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$RTn5KYg6k4yVZnvPA4z3beufscBO1.dk1UQhWF8eXl.YXpRpBfkeW", null, false, new DateTime(2023, 4, 6, 2, 41, 24, 718, DateTimeKind.Local).AddTicks(8720), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("798dd581-1c07-42da-9066-fd9cc5793520"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$ZZgyJihEEenRjlXt5l2X7.GBmGRv4LJKOBADqeFEYSsBmjGJg98f2", null, false, new DateTime(2023, 4, 6, 2, 41, 14, 176, DateTimeKind.Local).AddTicks(5349), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("79daa7a7-a53a-46de-b7d5-4e83e0fe6a7a"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$rwx5fQQaDnQtJxQwMU7f3.bgnrejMj.8r2kaWYZzRJwt09N7NDRrC", null, false, new DateTime(2023, 4, 6, 2, 41, 8, 21, DateTimeKind.Local).AddTicks(629), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("7a06121f-f18d-47eb-a39a-add0ba0e49b3"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$ztK/.TqcHufj8I/BnTazXeo/Y21gRpEISGlvlRto5n8XwVbmmTAqi", null, false, new DateTime(2023, 4, 6, 2, 41, 33, 776, DateTimeKind.Local).AddTicks(3797), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("7d8b6e25-f18f-490a-8e59-19f378b0a9c3"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$zp02sy4Dvs1ysL5Yzr4B9.gbTGg3AWK6CW38lLfETal87JUhEq/e2", null, false, new DateTime(2023, 4, 6, 2, 41, 16, 651, DateTimeKind.Local).AddTicks(3280), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("81934759-ebc0-4d1d-8b64-697cadb8bcda"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$dWxQl127Rhj5NNGqir.P8OJ6m197bd9yM6ol1iPy2z126kCVBB46K", null, false, new DateTime(2023, 4, 6, 2, 41, 11, 849, DateTimeKind.Local).AddTicks(9624), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("82ab71a6-a9ee-4035-8af9-e31dccd4bd73"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$eYNteYG3wIyxPSPhCW7ZkempzZW8dEP3/KxI/AkQMz5sGW5bzX1Ne", null, false, new DateTime(2023, 4, 6, 2, 41, 30, 30, DateTimeKind.Local).AddTicks(1786), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("830ecd08-310d-4e84-902a-e460484bd160"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$fcNRKeP2PtSN/exmjBWkCOjQDBBsUFrlRPIwh3Lfa3.4JlTOl1vX6", null, false, new DateTime(2023, 4, 6, 2, 41, 12, 48, DateTimeKind.Local).AddTicks(4634), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("842a4c82-8592-4de7-bcc4-e04b6394c512"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$x79IWK6.xM9GZndm9cQotOSZwdZmTLhvU9/zV3dpfnIVL5MSohUsS", null, false, new DateTime(2023, 4, 6, 2, 41, 8, 259, DateTimeKind.Local).AddTicks(7080), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("872dd9fc-b8c3-49db-b5c3-9a733ef938d6"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$ZCvgUdwJK0SqXGXn5r/0L.2TvhBWf1wyNpU5wrD8FAVjbGmYCxNpu", null, false, new DateTime(2023, 4, 6, 2, 41, 21, 81, DateTimeKind.Local).AddTicks(8900), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("879ac9d9-8178-4977-aeb0-cf55c2b40393"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$gxOlEbTQSnncUIrxjWtu0uD638L9whzzHDy3SFxO3hyFJlO8kEBdi", null, false, new DateTime(2023, 4, 6, 2, 41, 17, 98, DateTimeKind.Local).AddTicks(5486), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("8af9f52e-71e7-43c2-b327-83a63e64775b"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$MCPP4l5Zb15xnRV3c0Hzb.q/jy0HruJaN..Eda2gSPV55dS1j7gVK", null, false, new DateTime(2023, 4, 6, 2, 41, 26, 22, DateTimeKind.Local).AddTicks(3469), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("9004f4c2-479e-4676-b9f0-fab9293262eb"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$HeKyQFMkidEgXL1yzO0KauIC5TU2xklBh043HA7SzKr/sMf8mbUz6", null, false, new DateTime(2023, 4, 6, 2, 41, 8, 458, DateTimeKind.Local).AddTicks(6773), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("914bc7fe-8a74-4e86-9fa9-e868c4646494"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$YfPeBOpb0PUnkuhI16kQZukFl5BF0WDCXRDCVyAqBLYh3zx2njJNS", null, false, new DateTime(2023, 4, 6, 2, 41, 32, 127, DateTimeKind.Local).AddTicks(1812), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("91a160b2-d330-450d-a47c-dc097b8d31b3"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$K7Xvx104YI8cMt2v4Mzls.81sbnpYvBxlj.yJOMTMHNoPaV6mcMeu", null, false, new DateTime(2023, 4, 6, 2, 41, 16, 159, DateTimeKind.Local).AddTicks(3107), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("937524d0-7798-4d45-a359-96ab79fc063f"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$CTHkgskUKGPjGl.6Lcq35e2Y2QDE5Wvk7FmKJ7WyB1Y.YjIxDfI62", null, false, new DateTime(2023, 4, 6, 2, 41, 21, 759, DateTimeKind.Local).AddTicks(9727), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("9cbc3a2e-dfbc-4ba2-bf79-b7302a0c6c1f"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$IFazbre9qK4fSaSmR3ftnecSAntAC4JXpsU9n0zGfWAN1oDU81kWq", null, false, new DateTime(2023, 4, 6, 2, 41, 19, 318, DateTimeKind.Local).AddTicks(5026), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("9fddbb9b-64fa-4e59-a134-5a81668ec9fa"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$GkfMJO8clvaj3ebwrjt7RuHoYeuviR0URiTY0GCe6gd7s8zZWXHdm", null, false, new DateTime(2023, 4, 6, 2, 41, 6, 720, DateTimeKind.Local).AddTicks(9439), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("a3da1d90-07b6-4d23-898a-2dcfb9895374"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$rfuCeOk/hfyw62bula.M8.9HDuOJH08v/SAhdF1egTCLsK9z59myK", null, false, new DateTime(2023, 4, 6, 2, 41, 34, 33, DateTimeKind.Local).AddTicks(109), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("a5b8e704-e729-4c17-b24a-c214594f5dfa"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$JSljtWRhzMRU9QOmvnyttOT8tKgD2nvogg9Jmf0JroAuRx3piSpwm", null, false, new DateTime(2023, 4, 6, 2, 41, 11, 428, DateTimeKind.Local).AddTicks(9736), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("a5e80e6e-b9bf-4f80-917c-def04d7d4dc1"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$5dOqFepvZdLnT5Xnw7fcXOSPKLcq/UKCGUYYngZDZHFIh7C/Ekk3i", null, false, new DateTime(2023, 4, 6, 2, 41, 20, 391, DateTimeKind.Local).AddTicks(1002), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("a827c0ed-f3b9-4cc3-aaad-7cd99951ce3f"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$t2U2IzIolCkICMgQ3Spdbuz5ep1il7Ko3vIajiWJcq3ZLuH7PyU9W", null, false, new DateTime(2023, 4, 6, 2, 41, 28, 113, DateTimeKind.Local).AddTicks(4691), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("a9d99eb3-1ee8-4d5e-adee-85188cdf984f"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$.6iqMngtKd8cBSo2U463EuHUupuRa4uG9eFhIHsY5NGFmMpgQk/ky", null, false, new DateTime(2023, 4, 6, 2, 41, 18, 692, DateTimeKind.Local).AddTicks(3670), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("ab3e84d9-8d8a-4d60-b76b-1619cfc79e42"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$9uC0kblcKa0tJZ1jtADwgeA8gYSx69kwp6a7XtXuBeNoAgYtYOGfi", null, false, new DateTime(2023, 4, 6, 2, 41, 16, 423, DateTimeKind.Local).AddTicks(8678), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("abb27a04-422e-42f0-8b6f-ea302d4fb9a9"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$S9M9kLZTpfkgt2EOnYnP4.dZ2TVHynsaG6sNad1.97VCC3i5SqMBy", null, false, new DateTime(2023, 4, 6, 2, 41, 23, 412, DateTimeKind.Local).AddTicks(424), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("ac5f2269-df60-462a-b26c-8639624db318"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$7Sp8eqvBLfbQOET7VMH6jOPE6/IGY0PLQ5rp988Dg4Y38m5qWmIve", null, false, new DateTime(2023, 4, 6, 2, 41, 30, 464, DateTimeKind.Local).AddTicks(5184), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("ad37f3ef-b535-4f3e-83fb-9ae2fdd7c93f"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$mF0kqf/IsANlPQgz2TSv0e4mHeNFwByUDXvQ6CUO0Jc0ziTDoSMyW", null, false, new DateTime(2023, 4, 6, 2, 41, 10, 775, DateTimeKind.Local).AddTicks(3404), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("aefa62ac-f489-4e90-b505-ed9b8da248b3"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$oPVykUBqsaFocR5l0rO0sOOtVCQx7/Gg8ctEXaNZKv8g4SZTXG73.", null, false, new DateTime(2023, 4, 6, 2, 41, 10, 586, DateTimeKind.Local).AddTicks(7472), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("b0afb3f3-7283-4e96-96f1-5a1d7e2409c6"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$lbUdKrzTl3QCqA00kWqktuMTY95YNCKohbYlh7nLPTXoippTcG/q2", null, false, new DateTime(2023, 4, 6, 2, 41, 17, 797, DateTimeKind.Local).AddTicks(5853), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("b32d3181-2b37-4c45-a314-e1f550b867ff"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$lzWi9UK8SxYD2sRzSf/p3eiQeE8jylEBXH/sYVkz9mLYDs.83P2/W", null, false, new DateTime(2023, 4, 6, 2, 41, 29, 19, DateTimeKind.Local).AddTicks(4716), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("baa89cd8-6f23-4a08-820a-ccf4e5eb1488"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$V/bvtKC6.887/iHAXfWbYucO3eUOblftuAfFf2/Qt6Vfs/pFCLHMy", null, false, new DateTime(2023, 4, 6, 2, 41, 25, 663, DateTimeKind.Local).AddTicks(6274), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("bb5ed196-435b-46da-8348-e78811c8fae9"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$DRmqtcn7ZGjnleL5m.k5t.w6jR1ujX3pGYnZEL9xYhtxh5xnA5jvq", null, false, new DateTime(2023, 4, 6, 2, 41, 5, 986, DateTimeKind.Local).AddTicks(4518), " Ass min", null, null, "0966416708", -772000, "admin" },
                    { new Guid("bf920297-c720-4eb9-8316-fa0fde739164"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$lkKYD9OwNAdnxzqQ6qyJCeVC69pF2oFhroTpx1h4kc./GXbdjT6CC", null, false, new DateTime(2023, 4, 6, 2, 41, 10, 141, DateTimeKind.Local).AddTicks(6673), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("c0f22cce-3747-4893-8316-f97f747ed838"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$GqY95a5ioz7P/rhwS4KmaOIFma/VJjEPTm6L/Zfr4kSCbQXtpwyTy", null, false, new DateTime(2023, 4, 6, 2, 41, 6, 220, DateTimeKind.Local).AddTicks(4612), " Nguyen Van", null, null, "0966416708", 1, "customer" },
                    { new Guid("c1bcf9bf-83af-4ef0-8c01-0e31f0040963"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$2iTlttk97jnVvTgmaB5ywO/0OWa7EG3xargVpDhELEwCMu2rATu3C", null, false, new DateTime(2023, 4, 6, 2, 41, 9, 942, DateTimeKind.Local).AddTicks(9466), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("c2ac967c-5e4d-4db7-9844-cf07370aa17c"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$7llyV2VM3APX9exRgQWCiOwArZK2iQsvsCDnlo0l8IVp45Teicooa", null, false, new DateTime(2023, 4, 6, 2, 41, 10, 996, DateTimeKind.Local).AddTicks(8368), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("c63e1097-6c54-4c9a-bf97-8e11fa4695b8"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$lm7/OoGQreleGvTLyDBSmOYIqDLGoDSfyNyuOrn8GegjONuVAnX6e", null, false, new DateTime(2023, 4, 6, 2, 41, 32, 696, DateTimeKind.Local).AddTicks(1986), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("c7935994-5004-4c98-94c7-a7a5dc98a276"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$3dNBd978atzz0HugIaXCgeU7KtM1CsvbA4KVcyv1cywqw3o0H4Fc2", null, false, new DateTime(2023, 4, 6, 2, 41, 26, 930, DateTimeKind.Local).AddTicks(7538), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("c84c0c7a-f53f-4d90-a313-1ffdfa5fd0ee"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$r7m1RH/iac54ZwHJ1avSyu3YR9MxV6T2RDiNKZu2ZiyK8dx5Nyhye", null, false, new DateTime(2023, 4, 6, 2, 41, 8, 896, DateTimeKind.Local).AddTicks(5837), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("ca1c5680-faff-4ccf-b661-478fd0ac0765"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$wfqQZT/K45oglcQwJ2m4keqrW7sE3Fbypwgk8Lrhcp4DhnsX..vdS", null, false, new DateTime(2023, 4, 6, 2, 41, 20, 614, DateTimeKind.Local).AddTicks(512), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("d0843249-059c-46db-b596-73547eb21cc8"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$f36UP6WUruShiKX/gOiA/eu8p7IUpqNtbVeLdWt0kZ/vZqSbxVqHW", null, false, new DateTime(2023, 4, 6, 2, 41, 33, 501, DateTimeKind.Local).AddTicks(5327), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("d188843e-3509-4f2f-ad90-f9e6e57044a4"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$ZgtYw/25Ca5aMX1eZqQu7OMKvh.ETzehZgcUCe7GfTUSUlrIk8V5C", null, false, new DateTime(2023, 4, 6, 2, 41, 22, 691, DateTimeKind.Local).AddTicks(5527), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("d2c9bcd6-ba3c-45f6-9f69-3a3cb8af8c40"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$PmeW/BkdR3lyhHiyjyPF0uFAo2YimDZ2nHJow8RfOUloBWFvp0Eii", null, false, new DateTime(2023, 4, 6, 2, 41, 11, 641, DateTimeKind.Local).AddTicks(1804), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("d2cb5561-7d14-4c06-8113-98baff4dcd2e"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$m/sVdkAhzhDdqXkktvKSPeZ/znE3gnVA.dI/2b4VzKw/S8XgQ1jMG", null, false, new DateTime(2023, 4, 6, 2, 41, 34, 265, DateTimeKind.Local).AddTicks(9892), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("d38711ff-febe-4580-a113-fec835dc8c4f"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$HFQXXRVo89WESlZaG8Zj5uJ50Deju4VAuv0563qGZAZ319TdiVgBm", null, false, new DateTime(2023, 4, 6, 2, 41, 15, 741, DateTimeKind.Local).AddTicks(835), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("d64fb40c-1807-4c81-a320-73e10cd165fa"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$gu0O.jetje9MsFDkCdI0LuISZ9Z4.FAQz2JxPikx18KfBQSr/NNbq", null, false, new DateTime(2023, 4, 6, 2, 41, 10, 391, DateTimeKind.Local).AddTicks(3493), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("dd2db691-e388-4762-9421-6e975006319d"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$mGAPC4URx.nUHr8YM3Rj8.WSvTmX9VHohKycm1xfuAzXQ6JFrKDiy", null, false, new DateTime(2023, 4, 6, 2, 41, 7, 567, DateTimeKind.Local).AddTicks(5427), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("ddeba6b8-8dc4-4e03-a11a-ea365ce761d2"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$RX./o8n.dklRI2rWIZKWcO7Ytbz5EtODuxUyj.zaFIPwPQ1bMLLKO", null, false, new DateTime(2023, 4, 6, 2, 41, 27, 200, DateTimeKind.Local).AddTicks(4689), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("df16e246-10d4-4e09-bb89-cf1d8f613fc3"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$3A.X1xVk4zTRLlwkC/4fwOP98ilDlARfVOVq7qPo9UNzpFIEkrGZG", null, false, new DateTime(2023, 4, 6, 2, 41, 19, 836, DateTimeKind.Local).AddTicks(439), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("e05e16ba-e12b-4ea7-948a-bf20c7b237b6"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$Ne0VkPcO.2iEms.6RXCXw.PCu62B6s9ODPjWdOEYCNb8SSxHNZ5/O", null, false, new DateTime(2023, 4, 6, 2, 41, 11, 216, DateTimeKind.Local).AddTicks(2391), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("e17e0917-7103-4a6b-9eeb-85b370d47c22"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$msvnKL4hj0VyZ5gPMsMypeCEwpJxnJ.tApjC0ivSULM8Pci144FSa", null, false, new DateTime(2023, 4, 6, 2, 41, 5, 724, DateTimeKind.Local).AddTicks(3079), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("e6595871-12a9-4711-ba9a-99bc21aee2e7"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$S0b0vObSMYnKW/ZoHyKWle.qejaOaZiH9k.ENdHgqTIktvdVlOAoK", null, false, new DateTime(2023, 4, 6, 2, 41, 21, 544, DateTimeKind.Local).AddTicks(9410), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("f1c77cd8-a21b-4b55-b864-6aca683dd2f8"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$Tf3o4kxFicimPzkWa5dfA.kJkNQYJJXMRwBeTeJw1pjIGMLP4.gkK", null, false, new DateTime(2023, 4, 6, 2, 41, 28, 465, DateTimeKind.Local).AddTicks(230), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("f678ec9d-ad0c-42ed-9e13-5e76e7ca63d9"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$SSvDPxMSK.5PIw5c/bf92.2IgfFJFcyx4N6L6RX1s02Tp7KoUeBtK", null, false, new DateTime(2023, 4, 6, 2, 41, 32, 408, DateTimeKind.Local).AddTicks(6969), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("f6af737e-d2f4-4507-9395-8240856176bc"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$ifceU./2yuIVARkIJmf8FOloXcUhBbuXNF.o6vMOhRL94r41wMIWa", null, false, new DateTime(2023, 4, 6, 2, 41, 13, 688, DateTimeKind.Local).AddTicks(894), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("fd48709f-48ad-43ce-9a19-c4f026d62da3"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$CpQfluNVaiefZfn6x.AR5e61d45nyIt79CyrvcOic4RGpmcE8UYTm", null, false, new DateTime(2023, 4, 6, 2, 41, 18, 134, DateTimeKind.Local).AddTicks(2613), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("feb627ee-4550-406e-a421-00c6674ac1f7"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$FkVbZHwcQhD0wq6cFJIUBu0AnwxDu0DntElYx0MvSg0O3xbl9jZvW", null, false, new DateTime(2023, 4, 6, 2, 41, 25, 54, DateTimeKind.Local).AddTicks(3253), "Lannen", null, null, "04000508789", 1, "dlannen25" }
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
