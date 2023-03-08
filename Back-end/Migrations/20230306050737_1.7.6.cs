using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class _176 : Migration
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
                    ParkingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    { new Guid("446ea22c-3c7c-48c7-8222-b6d9359d2d92"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("4bd4b3a0-1229-4e6c-9041-db42f2d3552b"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("525194c2-9f12-45bd-a367-82d4d0fd4e67"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("6089e41d-8d7b-4ce4-b056-86ee18f8e5d3"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("f85226a4-c904-48ab-9b56-457d7152138f"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("fce7c8bc-276d-4569-9b02-95f765c29fd5"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("1e31ece5-7fb3-496c-b5b9-ad83a8c89379"), "1 Year", new DateTime(2023, 3, 6, 12, 7, 36, 824, DateTimeKind.Local).AddTicks(6754), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6dc04ff7-5b09-4926-adb2-53894e4f1250"), "Short time", new DateTime(2023, 3, 6, 12, 7, 36, 824, DateTimeKind.Local).AddTicks(6748), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88b90d99-74c3-444f-baa8-b4304f7652aa"), "Half Year", new DateTime(2023, 3, 6, 12, 7, 36, 824, DateTimeKind.Local).AddTicks(6752), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("0078ecfd-f321-4589-8968-0a946f7985ae"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$Ic6Yb2Jd9tdUAOmfs0wDk.9fT1Ip8xPwbv.VAz11ZKaWiCJ7qjiuC", false, new DateTime(2023, 3, 6, 12, 7, 31, 791, DateTimeKind.Local).AddTicks(3731), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("02e9b20e-2ec6-4519-8b54-eefb5c349b4a"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$K5MQ.6vBu0IYAKQYbGBmEeJ0dq8RADmHQ/Tx2FU67ChmLktb3wIwi", false, new DateTime(2023, 3, 6, 12, 7, 32, 554, DateTimeKind.Local).AddTicks(24), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("047083e1-a1b3-4170-83fd-bd2f5701ad1f"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$SSjlUafbBRObFu0tsAaWQ.mxRMchlSKetvPa37orXKpbK6kBXAP6.", false, new DateTime(2023, 3, 6, 12, 7, 23, 23, DateTimeKind.Local).AddTicks(8869), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("0528704c-3804-4161-9140-dc5c16f12d93"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$/eCShzlf.OQVGMcLlWMta.waKU8avsLitIqmWyt3FbKmpKB9eGZBa", false, new DateTime(2023, 3, 6, 12, 7, 32, 329, DateTimeKind.Local).AddTicks(328), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("05f59bca-fd19-4f65-9152-51f0393b6b2b"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$ZCccc.z5gCgycDziWmiM/eXEWupWtEoP9qkfkUUo4phQzmv1m3os2", false, new DateTime(2023, 3, 6, 12, 7, 31, 524, DateTimeKind.Local).AddTicks(702), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("0a405679-fe03-42c5-aab3-d8f8e2b0177a"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$nEQd4ke/VLCmPJgHRh.PdOlU8r/ivTD/laWGWv801wmO2Ylghxtqi", false, new DateTime(2023, 3, 6, 12, 7, 25, 746, DateTimeKind.Local).AddTicks(3723), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("0b66de4f-96dd-4b8d-aa72-ecc360e1eef0"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$dFzv9E/cQ45eXaz0XDgrg.CzCKkNTpbPF6R5kbwFW62T4/3GowTjy", false, new DateTime(2023, 3, 6, 12, 7, 34, 212, DateTimeKind.Local).AddTicks(5843), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("0e464c87-3a97-4db0-905c-c6192355b41f"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$0bCDxez90MirRS0vJoB24.swxdn7TKxmW8tbqaAC25BgW7LcR4DMu", false, new DateTime(2023, 3, 6, 12, 7, 24, 477, DateTimeKind.Local).AddTicks(951), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("0ee0ce7f-5896-4f3c-a045-251bdcb0bc50"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$rLZ6QCzJTXCxZqZcKXnFG.zi1WS6pQnnJ9bhHyXT4YNTbVTb5P/ZO", false, new DateTime(2023, 3, 6, 12, 7, 24, 303, DateTimeKind.Local).AddTicks(492), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("0fe49ea3-5b9b-4cd3-b550-645df6466598"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$VSOFM4UqA1kY.98K/k2/Ee2N1e5JWwT4EkvzyiYWoHCg10o2DsY1y", false, new DateTime(2023, 3, 6, 12, 7, 29, 842, DateTimeKind.Local).AddTicks(4474), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("135f6a24-e0de-4247-823b-1cf09698476d"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$fXIZk6x/.hD.moOLS.D5o.C8HGoh6BCZCZIOXpwLWbATZU.AE9qPq", false, new DateTime(2023, 3, 6, 12, 7, 25, 924, DateTimeKind.Local).AddTicks(1079), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("1423bc1d-3e8b-4278-bc6b-86c442f33f6d"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$Jp7GZ2NSStHaRCuXUYqmsuBkSZZQQFL7snZDC.o6yqamfBQW7OtEW", false, new DateTime(2023, 3, 6, 12, 7, 24, 973, DateTimeKind.Local).AddTicks(6788), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("17382263-9cc6-47df-bbda-5ba1d1b84a7b"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$BweKviTWmh.5rLuXQ0VyEeALCcysSZdNqcmMooSzDUjY8SkD//ei2", false, new DateTime(2023, 3, 6, 12, 7, 33, 591, DateTimeKind.Local).AddTicks(2328), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("18f1519f-d179-4360-bcda-944601ca9763"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$pmh1/opl77Kl39Y5WTxtZepgMNjHfpYRym8VQbqpyKl3vBNrBKYJ6", false, new DateTime(2023, 3, 6, 12, 7, 33, 485, DateTimeKind.Local).AddTicks(4646), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("1b539288-2224-4641-a961-a23042524bb0"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$ozoVPLk//aOa7nsXBEy2fen2tIVXhUA2pL/JmwyRKeiKTKD9x0Xj.", false, new DateTime(2023, 3, 6, 12, 7, 32, 203, DateTimeKind.Local).AddTicks(5112), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("1c1ac8cb-edf7-4fa3-beb3-0032e1a995b3"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$hi1rStzDjtIJh3Vxf5uoruSfeW1uXDls/M48i5sGmi8wBxqSn.ZMO", false, new DateTime(2023, 3, 6, 12, 7, 35, 405, DateTimeKind.Local).AddTicks(684), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("1e33b1d1-a0b8-4969-958b-f2ba9e07b3a2"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$K5bPWKPqoETunz/2CrJsme4.z7nUnzDM/ZLo.4m3GYsymJguPi.Tq", false, new DateTime(2023, 3, 6, 12, 7, 33, 141, DateTimeKind.Local).AddTicks(5993), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("1eeef4bf-7866-4632-9994-2fb913aa6f57"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$U0m5bLcVcRMwhQpNjugVY.Q.B6lUKh8KYUOb3akNLh3kujfdVxhDS", false, new DateTime(2023, 3, 6, 12, 7, 28, 687, DateTimeKind.Local).AddTicks(5449), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("21af130c-ba21-47ed-961f-b84223efe0ff"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$QnsAUx9KPRntupfbILAgWOEtnjKxmyzInEbls1QYkPnR.RWpOgmMa", false, new DateTime(2023, 3, 6, 12, 7, 31, 929, DateTimeKind.Local).AddTicks(3001), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("23c6ffbe-a125-431e-8d1b-cfe7f12c5483"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$KVEMcM1a8wcLnpDlRQ1DX.R1fQo/YRbaWJXWKeAvpUEHZfe6fECT2", false, new DateTime(2023, 3, 6, 12, 7, 36, 738, DateTimeKind.Local).AddTicks(6317), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("244cce28-0e4a-4b11-a55a-7de9bd5cabbc"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$u/RGZ95NPPcNco4uqPFZXe6/Gg34NGtUytg8vVHhfU5.46madnlcm", false, new DateTime(2023, 3, 6, 12, 7, 33, 690, DateTimeKind.Local).AddTicks(1946), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("25250c3b-3824-4eb4-af5a-5c36b5bb35f5"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$vw1XfH1aa9Kh5TOs.MGoS.3h/ZfQiztycmFil9s5yXYj4Re4m9UkO", false, new DateTime(2023, 3, 6, 12, 7, 34, 105, DateTimeKind.Local).AddTicks(5083), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("27204021-0f1d-4d1a-90e5-40292579e8b5"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$Kr0lvtxrIizzXWHSVmRJVeqwQIkehzhulgUAXuGKkgp1fZMM7jylu", false, new DateTime(2023, 3, 6, 12, 7, 34, 989, DateTimeKind.Local).AddTicks(7970), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("2a19a107-c815-490e-96b0-97c67b1f6be3"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$0JELllhN2FuuPRLjmoxgc.V0YbQiPFGoCG6LpQsVBZpTekEwsnYlm", false, new DateTime(2023, 3, 6, 12, 7, 33, 252, DateTimeKind.Local).AddTicks(786), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("2c8a5b4a-54b2-4e7f-8923-5aae7aeaf323"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$WiBIOPLGqqwRcr2lrPiPy.GJ42yGnD/QxifPKq1UhFo2R2snvqE.6", false, new DateTime(2023, 3, 6, 12, 7, 27, 154, DateTimeKind.Local).AddTicks(4185), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("2d680cbd-d232-4c16-8602-dab4b4e2a2fb"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$pgkpDq.VmL5IhUbQbTG44OtXW65G9OkKcaH69nPE1kU7vwNd0rZqW", false, new DateTime(2023, 3, 6, 12, 7, 25, 162, DateTimeKind.Local).AddTicks(829), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("2fcda8a9-44bb-4f70-9192-546cff40b197"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$5d3sc3bFQNpWCQXpswEwjuBqi5X0rDM3W7QO5EoePZN2BgdrXezya", false, new DateTime(2023, 3, 6, 12, 7, 33, 375, DateTimeKind.Local).AddTicks(8993), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("30d98f01-ceab-4273-8366-0bb663d023a4"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$FLHazexQVG64u3ERmPzsC.xzhd/yuUPtpsBcXV2k4y7zSmU.yLika", false, new DateTime(2023, 3, 6, 12, 7, 29, 241, DateTimeKind.Local).AddTicks(1792), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("33576764-1abf-4740-a011-51221e15122a"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$rN5DXYfT8XO0SqceS7mL7eTsVmrJ/1lr00y8NfqUsSJV/DpS352HS", false, new DateTime(2023, 3, 6, 12, 7, 34, 839, DateTimeKind.Local).AddTicks(4948), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("33754381-f690-4515-949c-60e90edb5434"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$GndoNaskS09NvvNoWpayUeKjJVPZlK94/LSepkvcYiCcCOs07VSnS", false, new DateTime(2023, 3, 6, 12, 7, 27, 321, DateTimeKind.Local).AddTicks(647), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("360a084b-3094-4c0f-963d-8bbcd1cecf5c"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$7UNdIzeubd6wTxqCrN6BzeeVi6d4qDYCeH8qT/iwbWcIPZzuElNqq", false, new DateTime(2023, 3, 6, 12, 7, 23, 916, DateTimeKind.Local).AddTicks(6435), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("40fb3e0c-5f0c-4b5c-80a9-734b55a9da3f"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$h53fSLpXJ6qg1Uo3X301luKid/YxRGOfbPpZL5svWmlwLUOJl4vBm", false, new DateTime(2023, 3, 6, 12, 7, 24, 636, DateTimeKind.Local).AddTicks(4695), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("415842a2-8825-4849-a35f-a7fe7e772934"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$/EX3MKmGFAqCiryBcGaxp.BwqkHnH45t5z0E1G7A2r7ELrRPBcvBK", false, new DateTime(2023, 3, 6, 12, 7, 34, 676, DateTimeKind.Local).AddTicks(7935), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("41eeb48c-6c3b-49c5-8d65-e9b1f8a48888"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$rL2f7Nglc2yuFsAmdW8greJ7YVCGFpCLvk7s.cJJJFc.Z4D16ng/i", false, new DateTime(2023, 3, 6, 12, 7, 35, 993, DateTimeKind.Local).AddTicks(8493), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("42955235-2d2b-4cf2-89de-2cb9dda18d6b"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$ni0nK2j4wm8wjgmZagPCduobdzpvBJJoJIW6ZNYoyYhagz6.dKZru", false, new DateTime(2023, 3, 6, 12, 7, 27, 10, DateTimeKind.Local).AddTicks(211), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("459fe06b-c86c-49da-930a-8c63e6abb81d"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$T/UdjDT86dfeSTlxoS62M.GCVGvPTuEQX1DIBNUqXPO8vpnV6ZbS6", false, new DateTime(2023, 3, 6, 12, 7, 30, 414, DateTimeKind.Local).AddTicks(1135), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("47411d0a-7c49-4387-97e8-36870c5a70b8"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$xK1OoY7vYnpnGkMUdO6wyO8HxR83nP3c9FePFAKZzaT1cUJv9DT6S", false, new DateTime(2023, 3, 6, 12, 7, 35, 806, DateTimeKind.Local).AddTicks(2518), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("47fad9fc-8fea-420e-91f5-70102f3c9d51"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$qHjZ54yLlPd7pVedp1tkJ.AZJb3iontjRk5og0ZnMdE6VVzNFB6vG", false, new DateTime(2023, 3, 6, 12, 7, 28, 535, DateTimeKind.Local).AddTicks(1563), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("483beb08-92c6-42d2-9d60-52153546e7e7"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$TJ.mYLxThuT5HfF3bOHNo.eCOdkeDxl6uh00pU.H5vgORK0.wqqGK", false, new DateTime(2023, 3, 6, 12, 7, 27, 445, DateTimeKind.Local).AddTicks(2020), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("48a38b72-89a5-499b-9f93-10a359a8557f"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$3WE8mAgABeoAHZZZIIaHK.jL6zyuYUIa3.vchWDXEp/p70p9GHfKi", false, new DateTime(2023, 3, 6, 12, 7, 22, 857, DateTimeKind.Local).AddTicks(2858), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("4a3f610b-b776-4a62-b8fe-b52a220124e1"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$w9prF60MXAQc8ZidM29KLe9sfsTohesZfAYLwzaRnI4VwST98v1k6", false, new DateTime(2023, 3, 6, 12, 7, 32, 675, DateTimeKind.Local).AddTicks(2122), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("4a7e4d3f-d506-4862-8afe-99e0b74b7468"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$J.bJ.Iapfm3YBjziGQC0yeWrjlatbtThcar10BKzxAyla5u5Rsv1u", false, new DateTime(2023, 3, 6, 12, 7, 26, 443, DateTimeKind.Local).AddTicks(3301), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("4ac18544-c4c6-4ab2-9d95-c480e79987f8"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$majZ3vk4ewub/s5.hFEcPuuoxvDCPLxgPA/ghPNr94UAn0Kw8Y.oS", false, new DateTime(2023, 3, 6, 12, 7, 36, 176, DateTimeKind.Local).AddTicks(8528), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("4deb0c90-3bf0-4936-a4ab-55896a7a48e8"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$7C.Tgqf0Lb3UvxtZSg1tXudQzyy4YpIQBG3BvNY4uDzAJwaAd9N32", false, new DateTime(2023, 3, 6, 12, 7, 31, 400, DateTimeKind.Local).AddTicks(7080), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("513380a7-fd4a-470d-b8f3-cbbbe4b42b35"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$qmgquDKLlV5llcJVDqp9ku1DzKhJV/g0ZB.1QLTLeTePoHTGx.l2C", false, new DateTime(2023, 3, 6, 12, 7, 24, 44, DateTimeKind.Local).AddTicks(2809), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("566d4ecb-26b1-47a1-89a8-0cc2a9b12ac0"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$YdcWGh0PKh0Fe3YHrEvA1uZH8muuCP6M9spf14sERA2qtsr5zSmFy", false, new DateTime(2023, 3, 6, 12, 7, 31, 112, DateTimeKind.Local).AddTicks(379), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("5aef6216-67c3-4c9b-ad80-57fb4c8e0450"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$kC5kL2fOpbi8dbghv/QTuuo3auIuORCRmdS38hu42U6WU19.rFIm.", false, new DateTime(2023, 3, 6, 12, 7, 33, 788, DateTimeKind.Local).AddTicks(2510), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("5df3d9eb-5fef-4b35-b4ea-e9623ac4bb3e"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$0IX8Mm8kQUCwrRB4T0lIle5gdnObu.ZdKFEnAd2GOmktScukP5jAS", false, new DateTime(2023, 3, 6, 12, 7, 34, 303, DateTimeKind.Local).AddTicks(9521), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("5fac2be7-04ea-4cca-a5f4-1e40ca941d97"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$QwkfCVoKtRQKiFkKaQ6MyOxRmdYtNnr1OjoqyrfJRlXGF1yIEhi.W", false, new DateTime(2023, 3, 6, 12, 7, 30, 268, DateTimeKind.Local).AddTicks(3103), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("60af7598-0b0e-4fcd-af2f-55aa1fa7f269"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$690y9ODTL/vhDlqZSphGseFBWTOoRNp/FL0QNehJtRvxQ2eE614pq", false, new DateTime(2023, 3, 6, 12, 7, 23, 550, DateTimeKind.Local).AddTicks(6218), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("61331e1d-512b-491e-b8d1-9184627d6548"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$sq0ugd8c/K1XvgvEitA2nOTBp/nO2AZDxINK.7WvapqQidbEEnebC", false, new DateTime(2023, 3, 6, 12, 7, 29, 392, DateTimeKind.Local).AddTicks(9258), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("657a52bf-3327-471f-b12c-1b6d51f7e47a"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$.x3yf.vkGYCFot9Gcoc1WuZzShYrKBdolxWKcy8o498UL/jBKeCW6", false, new DateTime(2023, 3, 6, 12, 7, 32, 446, DateTimeKind.Local).AddTicks(139), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("67345430-3dca-4041-83cb-16cfd480348a"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$7sDJHsSlkWjYbzgbwNu5outKSFAB9lY2Uuky7SjeAtMxp3GNQtAPW", false, new DateTime(2023, 3, 6, 12, 7, 35, 146, DateTimeKind.Local).AddTicks(8834), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("6b1bfa5f-a25f-45dd-ac07-ade353ae6f22"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$Rt10wJEq8mwFsnC.mMkXe.ldLIJHSeTysLxvPwSB0dnoxHsG4GSsW", false, new DateTime(2023, 3, 6, 12, 7, 33, 896, DateTimeKind.Local).AddTicks(2607), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("6e565ab9-6a3a-45e2-9b43-2f1fb6a77426"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$vOqClACWV0b6BSYx1txSM.o0x09EGyJ4Jxlk9ZJExemEIBr9iKt7S", false, new DateTime(2023, 3, 6, 12, 7, 36, 478, DateTimeKind.Local).AddTicks(5064), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("6eb079f0-947b-4c56-8e14-d7a10a8c69fd"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$.JpW5qPQHHyzZffy9KU0DenbH6qsKs/DhFachMaNvj3JjwV8HkxtW", false, new DateTime(2023, 3, 6, 12, 7, 30, 696, DateTimeKind.Local).AddTicks(1557), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("70c89420-97a3-43dd-866f-23ed3540140a"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$t/prgQPgzJ6c8POXeQx3iOtSEksBlDYL5c5.hPZM83G/2d.nTS3Wq", false, new DateTime(2023, 3, 6, 12, 7, 36, 82, DateTimeKind.Local).AddTicks(7419), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("70fb157c-404b-412e-9905-8b782c54fa67"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$RhDq8ktkLi3hCzwLhvriZ.ivWP0PrpnmKh2SJMokrFq/DgvrMHe1a", false, new DateTime(2023, 3, 6, 12, 7, 35, 898, DateTimeKind.Local).AddTicks(4501), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("71e49971-9935-44ab-ae25-908b877f4884"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$QltxHO9Ib5aVibUs88PCmOHdj3DB2oEDUFSrZOFlUooDJ64FS.3j6", false, new DateTime(2023, 3, 6, 12, 7, 35, 62, DateTimeKind.Local).AddTicks(4507), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("739169a1-148e-4a93-ba84-9b2a5cdaf495"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$S6kwxYWct6t0zevkJ96NZ.A5030nql18/0Ew3t1fkweOyVtDGCabu", false, new DateTime(2023, 3, 6, 12, 7, 24, 163, DateTimeKind.Local).AddTicks(6519), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("76233a80-000e-4c63-94fa-2b5ae9caa61c"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$1s.73uRkK5040O0vG/dueui/bJ5NP.faB.zbTDeJwJUevynccwFWe", false, new DateTime(2023, 3, 6, 12, 7, 27, 737, DateTimeKind.Local).AddTicks(6308), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("762613a6-4a32-408d-b50a-3113d58257c6"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$2bUc2ByNXylRMBJl60EGHuBs/KTF2ca7qBXXxQfvGlnh6zQShGB.m", false, new DateTime(2023, 3, 6, 12, 7, 23, 796, DateTimeKind.Local).AddTicks(2090), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("7c97815e-c285-463d-a3ab-3e4e68d8ca5c"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$GFdDNSvgFPd1PWLaj1Gawen0AS.SHa2A0XJFgBa5IGwzAGyGYflAS", false, new DateTime(2023, 3, 6, 12, 7, 28, 133, DateTimeKind.Local).AddTicks(7484), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("8277f589-d130-4fbf-aac2-3813534af82f"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$xgsmQ/1zDIJDkP/Lt1aRUuVwb8pa/qxAP7IIDCewm6X871zDR0nyG", false, new DateTime(2023, 3, 6, 12, 7, 32, 924, DateTimeKind.Local).AddTicks(4215), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("844a05ec-d3aa-4247-84f5-e3c6ebee0334"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$11nhtTqollHzo7VmGfK9seqsCV8lrLwodcYkKPx3yJI97dLEIDHRO", false, new DateTime(2023, 3, 6, 12, 7, 35, 483, DateTimeKind.Local).AddTicks(9989), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("87a18606-b283-4d37-b148-6dc5fa294da5"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$CNoxBUNtZaOLNTSvpyC0PuNaz8u6bNUf8H/X5Gh.JWeJC84CYd41W", false, new DateTime(2023, 3, 6, 12, 7, 28, 956, DateTimeKind.Local).AddTicks(4347), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("87ff54dc-d1ab-43eb-a328-81de7d86126e"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$F2YZnH/HKlnSQkS1hWhj9ugmvb4PxTAzjGD84Syj1EwBmETFcyBC2", false, new DateTime(2023, 3, 6, 12, 7, 24, 794, DateTimeKind.Local).AddTicks(7802), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("8892d963-83af-4a0f-911b-4c3bfab58211"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$/jO3iOmwmXUC0BKO7Go8ee6.TUbmEZSXGrTtWgTR/D47U4SwZr6TK", false, new DateTime(2023, 3, 6, 12, 7, 36, 278, DateTimeKind.Local).AddTicks(2286), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("89601e74-65e2-436b-af41-9e1a3bfcf37b"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$2aZptC.xsXI8euCJi2RW3.a3CI/iwt8j9837pD1rPtY2nOx3YnYmC", false, new DateTime(2023, 3, 6, 12, 7, 26, 845, DateTimeKind.Local).AddTicks(113), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("8b5a65a2-3d2d-4fbc-9fa0-0b1d41ec0f4c"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$VguCKzFsnZ.Gyo0xOZUvE.9icXNkiGWqm9yJVaEhtekByCHamV14K", false, new DateTime(2023, 3, 6, 12, 7, 28, 0, DateTimeKind.Local).AddTicks(3399), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("8b8b0fe7-5c10-4f69-a364-1c2192d98995"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$CtTTMsqvMhK4TuxLmH8lGOpL46kmawdC2pvaQh5T/QR7Xy7fZCnCm", false, new DateTime(2023, 3, 6, 12, 7, 34, 587, DateTimeKind.Local).AddTicks(7907), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("92007dab-7e90-42e8-8d42-91672c1ae56b"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$rUZ.6OZMKn3Trv.ON3oS9.Mo4tXC6jhm6VGKUHEP7y8.W4HW/SAxu", false, new DateTime(2023, 3, 6, 12, 7, 31, 673, DateTimeKind.Local).AddTicks(1507), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("92a1c7b8-726a-4143-98d3-18712423164c"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$jyUiCQbLUNSGXOZncNIz2uHHG2gk5KUxlO3KmhdSK0GOaMFV8M.3.", false, new DateTime(2023, 3, 6, 12, 7, 34, 8, DateTimeKind.Local).AddTicks(9460), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("95cd47bd-9cf7-4119-8971-afaf05a3f937"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$S9Mbi60avbeaD5.gN7120.wNhdqQI634SUC4Q0o2II7Ys09qU4ayK", false, new DateTime(2023, 3, 6, 12, 7, 35, 324, DateTimeKind.Local).AddTicks(4553), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("95cdf913-2def-40d3-a662-bcb00afa96d5"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$d.22sUVjoCoYq9a7ehUckuXmEJVZP945UroLq/WSnUCyHvTRRnwxG", false, new DateTime(2023, 3, 6, 12, 7, 23, 311, DateTimeKind.Local).AddTicks(3326), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("9d76be0e-0eb1-4d97-b035-6248c9c9d63e"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$9vzbykgBscBJhwvbMBnpye0fVJ9qN62164GRNANt3OBTL5jixM00W", false, new DateTime(2023, 3, 6, 12, 7, 34, 759, DateTimeKind.Local).AddTicks(9696), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("9ebf25c1-b91c-496e-a3e0-61369a4f3358"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$5mj9.RGIW5wLanxpabyDsOMNNt0F7oIUI0RG3GADZc6Xu5EMHCZq6", false, new DateTime(2023, 3, 6, 12, 7, 22, 740, DateTimeKind.Local).AddTicks(769), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("a1f58cef-954c-4f6b-848e-22e5d93432ea"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$BFoB5lpgbxJAlvFkJNkXk.rtI1Vl0q2HNTkD1bQfTj7mimxFI//4O", false, new DateTime(2023, 3, 6, 12, 7, 36, 569, DateTimeKind.Local).AddTicks(127), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("a298296e-04fe-47d7-b799-da4c65179e69"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$TVEJdujCRaqec7KjYFkm8./h5Qje4OV5xcL8RRMrHC/RjWdSrcdL2", false, new DateTime(2023, 3, 6, 12, 7, 36, 379, DateTimeKind.Local).AddTicks(6308), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("a4707452-b0af-4ebe-bd4d-7d9e6c4a1d17"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$nM2yMr1pjrI941/fK11KQ.6Nsn9GZesokSOftBkkprQw9QfIu1nHi", false, new DateTime(2023, 3, 6, 12, 7, 33, 31, DateTimeKind.Local).AddTicks(8490), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("a5f0031a-319d-432d-8fdc-989ad85efb5a"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$Zfxo9gbV9saFhsZahD5GbOs0hqXCa9nnPmAwnpC33KRX5EpYNfa7i", false, new DateTime(2023, 3, 6, 12, 7, 30, 826, DateTimeKind.Local).AddTicks(680), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("b435c2ab-fe4e-47a2-8862-8d778a2c6182"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$mf43V9ENU7N/mxlHt5SEeu8psm9sGoLz0o3piWJEo1h55VqUrNx1u", false, new DateTime(2023, 3, 6, 12, 7, 35, 644, DateTimeKind.Local).AddTicks(5111), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("b462b33a-ca70-4543-a722-5e18844740d5"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$ZeYztITICXEon/E93kbEkui3LuhaT2SAFzgRMer64mhGATf9c.Pg2", false, new DateTime(2023, 3, 6, 12, 7, 23, 680, DateTimeKind.Local).AddTicks(9890), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("b4c46df5-2244-459f-b494-ac27dedde432"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$tHf1nlDerGja0geb.K694u2.rOEMgzll.OAC/.WxhbvZplkBUdGxK", false, new DateTime(2023, 3, 6, 12, 7, 32, 79, DateTimeKind.Local).AddTicks(5366), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("b86efa90-2fb1-497d-a7f9-49380429f11a"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$j/cfqjrcGk5DD.QF2P/sD.kVvDfRcpR6nxWT2AmPWL6.MJwYyzic6", false, new DateTime(2023, 3, 6, 12, 7, 25, 552, DateTimeKind.Local).AddTicks(8722), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("ba9d4ce3-a764-4b84-b93f-eb86b6f69664"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$ZpFpBTUgpzQ8DY0Jqqk5XOE2vjTbT5xOfrR/oLDA/93N39DAcF7PK", false, new DateTime(2023, 3, 6, 12, 7, 36, 654, DateTimeKind.Local).AddTicks(4735), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("bbd274d2-e125-4713-a4a7-37058a760e65"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$3.nwbjUvlCcstS83lMDHKeAp.dtZgZF.ywfs2xg463T4WdhT1fl9S", false, new DateTime(2023, 3, 6, 12, 7, 28, 826, DateTimeKind.Local).AddTicks(7464), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("bbe195d9-79ed-423c-aa08-d13386d6cad8"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$h3kaGzPq30WbzuGthJIuO.SzfkIXV9NS6kSgg/ReJ.V32MVIQyeU.", false, new DateTime(2023, 3, 6, 12, 7, 35, 563, DateTimeKind.Local).AddTicks(6060), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("be3333b3-b8f0-43d1-a268-b55586461bd8"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$Su3mw4oBWHZi3bUi2DHJqOO.XdI8BPdIot0bH/iQ0UT98TvnGl9ui", false, new DateTime(2023, 3, 6, 12, 7, 29, 984, DateTimeKind.Local).AddTicks(7041), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("c0d7b92e-f727-48af-a48e-9d3b452618d9"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$yvXb4O8A2dQy3xoZ2rJl9.xZwFbSDjeXxBu9B/ykmTjnrTfUu1mQK", false, new DateTime(2023, 3, 6, 12, 7, 31, 251, DateTimeKind.Local).AddTicks(2545), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("c0e7acb4-2165-47bf-b4ae-30e48f25ab68"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$Wh//EV9vtcNOaGB2yvWW7.uPOePvDXfOIUMrlG95UvY5ZIaAjH5Xa", false, new DateTime(2023, 3, 6, 12, 7, 30, 971, DateTimeKind.Local).AddTicks(1876), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("c33a4c18-120e-49b5-b473-6f5a8914d1c7"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$60uVP6gAv1DewNt0j/ZASe2TEdaJ2MHgCyqURzM0s23i2tH9sPjo.", false, new DateTime(2023, 3, 6, 12, 7, 36, 824, DateTimeKind.Local).AddTicks(6101), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("c8809dbb-f44b-438a-b301-7580d87d1738"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$NHKaxwPzkNi..J2/meoMg.Lv67FoxUFro4/u7K2rAu6hLnQN3JQxK", false, new DateTime(2023, 3, 6, 12, 7, 30, 535, DateTimeKind.Local).AddTicks(9948), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("ca5a79a2-0434-4068-bb3c-b0dfa8948f61"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$NjGIWGG5yPmEH4KVOAtYPuVdX2S3aV1jq2upK16FELW8vEa35Hdba", false, new DateTime(2023, 3, 6, 12, 7, 29, 700, DateTimeKind.Local).AddTicks(9359), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("ca91fca2-90c1-47f1-9e25-50d53b22a379"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$oJOYKnkQVGtjHXQFISLiI.MegWNfwVQRPlNyvwceCToAPZ.4RbvGK", false, new DateTime(2023, 3, 6, 12, 7, 23, 434, DateTimeKind.Local).AddTicks(217), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("d257ab48-5bfa-4035-a2f6-79bf44c4c0a8"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$1DQFxdABjwiNgoGV5a0lA.uNIQZkVyVeDwLh.QRSdO.kaUiIRqkiW", false, new DateTime(2023, 3, 6, 12, 7, 28, 279, DateTimeKind.Local).AddTicks(7424), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("d2d4107d-3477-4e9d-9989-df1f897c6255"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$P0jm28RObpaIS1367TyyHe2x3fesX1V7VqZOMbjx6FSGEmcqM7W6.", false, new DateTime(2023, 3, 6, 12, 7, 27, 879, DateTimeKind.Local).AddTicks(2201), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("d5c9621f-73fc-457f-9fea-a585a08e0c2b"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$MD6xSlSh2GGJnM8ZzaILceyBDi.jKNJbYq20TLYxXlry8gSwVMg.u", false, new DateTime(2023, 3, 6, 12, 7, 35, 725, DateTimeKind.Local).AddTicks(3717), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("dd34e7f2-54af-4301-a2bb-acf19e2b477b"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$D2VzdnRqtv9xu145qImWhelGnPKa0TSMLDjhXLW3Q9QjeU8jcGK0W", false, new DateTime(2023, 3, 6, 12, 7, 34, 915, DateTimeKind.Local).AddTicks(7882), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("de968387-6b0d-47a6-919e-03086858d59b"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$2E.MUlMZQpX6T5cd/XGxEOLxIqlNy.fP7fgpR01xzK2ejQZ8T3vsi", false, new DateTime(2023, 3, 6, 12, 7, 29, 104, DateTimeKind.Local).AddTicks(3682), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("e02f52cd-27a2-4018-bdad-4ca258e0f2f0"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$I/OUyuFdaunCdM.6.vghtu8gbZjSYVAPErApa.R05D6H3hugI7y.C", false, new DateTime(2023, 3, 6, 12, 7, 25, 339, DateTimeKind.Local).AddTicks(8750), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("e0397f73-eb82-4b77-a689-29bcb3c313b5"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$EfYYMd5a0.w1uWLJc1dI1..Ge/6jxoXdIecQuWSpYKgMUFz6dbmuW", false, new DateTime(2023, 3, 6, 12, 7, 23, 171, DateTimeKind.Local).AddTicks(5945), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("e140f76a-6928-4f62-a145-7f0d01faf390"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$Rl9U6YK..EH8yuqEVKq0nOYI23qOs2q23czUkf7UilN0EbhA9efwW", false, new DateTime(2023, 3, 6, 12, 7, 29, 548, DateTimeKind.Local).AddTicks(718), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("e1d30d68-fcad-4d10-9708-842c78db4ac7"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$A7C5JTaSanpxXeA2Xt3Q9uQcDNq9AhTwbuTnj/h7AcNa2jin96kf.", false, new DateTime(2023, 3, 6, 12, 7, 27, 606, DateTimeKind.Local).AddTicks(1559), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("e739f978-3f28-41a2-a722-f44ab2f15b6b"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$CHo6Dep7at5g4GpeBUCYtudOnjvL4DCqTdkOB/UAf5XUxqX96Lbwy", false, new DateTime(2023, 3, 6, 12, 7, 30, 124, DateTimeKind.Local).AddTicks(9959), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("ec8d250b-e721-457e-a0e7-b18109d38ea7"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$0AUEcfRkQPuo8EEZcgTyrOJng3UMnbe9K8w8ofDMN3Rxh/SoIqkv2", false, new DateTime(2023, 3, 6, 12, 7, 32, 797, DateTimeKind.Local).AddTicks(5260), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("eecf312a-40d7-4f5f-826c-1b1726bd40cc"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$7LSo1Mom7M5wf6oFCRvE9.mMtcv3ahHuI8SWhLg23n8ptu.rHub16", false, new DateTime(2023, 3, 6, 12, 7, 35, 238, DateTimeKind.Local).AddTicks(6415), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("f27c7b4e-d944-4c93-af11-26db47910efd"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$3G6pLlCSEN6D0wkjeWztSOcNLWR38aJKx69He.a2qrcSfwsmt2h0y", false, new DateTime(2023, 3, 6, 12, 7, 26, 644, DateTimeKind.Local).AddTicks(7164), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("f44b215a-2c3d-4905-95cb-11633470a9e9"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$Ybnag.8szscgkYRbD.qgXer5iUDU99jV3jsF.DtqwKR.EQxvH3EWO", false, new DateTime(2023, 3, 6, 12, 7, 34, 391, DateTimeKind.Local).AddTicks(8022), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("f46bbf2d-01ba-464d-aaba-f1a7d7b289d1"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$kjuvD/TQ3fXKLlg.EJWNzeJbFu9anxcSs1AS710Qfwh.Vllgt9L/G", false, new DateTime(2023, 3, 6, 12, 7, 26, 223, DateTimeKind.Local).AddTicks(9998), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("fa5ca4a0-75b2-4684-8e4e-a9a1b827bc3c"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$S3auF4GZW7E6N/DZ2GlyouGSrGlxF9R0Zk6dHefaKPVAsh5zFORPW", false, new DateTime(2023, 3, 6, 12, 7, 34, 484, DateTimeKind.Local).AddTicks(8282), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("ff107ca1-2fc9-4673-b8bf-74def4b92a83"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$lcMkh8kms4webeq4MdZ5UO0StqDsY6Dn.79C8Rq/OlMh1JpGeqtzS", false, new DateTime(2023, 3, 6, 12, 7, 28, 409, DateTimeKind.Local).AddTicks(2982), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" }
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
                name: "ParkingDetail");

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
