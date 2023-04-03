using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver184 : Migration
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
                    { new Guid("5b8444f5-3a97-453b-86c9-f66e37b3257d"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("697ab5b3-e503-468e-a264-4b79f119fb13"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("85e6bc25-dfa4-410e-a01c-936ac8207691"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("89a82518-2660-4ed1-8e3e-7330ecb4b808"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("8ab74f6f-a984-49e8-87a3-bb6101cbbc6a"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("b5245844-ecc8-4f8c-bf74-0fed1f8bd0ee"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("ca607ab3-9a8e-4a24-838f-42f9147e4906"), "Short time", new DateTime(2023, 4, 3, 16, 21, 40, 885, DateTimeKind.Local).AddTicks(3295), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da5b9e28-26f5-493f-bff1-81df1a69b0f9"), "Half Year", new DateTime(2023, 4, 3, 16, 21, 40, 885, DateTimeKind.Local).AddTicks(3302), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("edbd9331-5d4b-4514-b8f8-72f0e8e1b191"), "1 Year", new DateTime(2023, 4, 3, 16, 21, 40, 885, DateTimeKind.Local).AddTicks(3305), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "ImageID", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01292221-a6a8-4630-94c6-0dd786656add"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$z3jlAU5Uyyuytt4nDnJeueqa6nXKugc6cM60Sk9UFuUW5qngxdavO", null, false, new DateTime(2023, 4, 3, 16, 21, 40, 20, DateTimeKind.Local).AddTicks(8584), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("01b59769-be23-4e13-bbfb-cdcf975812db"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$fit2tDdPRPGvkKVpTkyvaOdaJDmifDElyA/a4HJCi615ofTfVhjAa", null, false, new DateTime(2023, 4, 3, 16, 21, 37, 734, DateTimeKind.Local).AddTicks(1958), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("0662d802-abbb-4c0f-b70e-53e1fcb19050"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$gPo7GrjLlFVdwtWh9r.EyO11umFKnIQoJaPokkH/WlHcFJR2yC0My", null, false, new DateTime(2023, 4, 3, 16, 21, 30, 626, DateTimeKind.Local).AddTicks(197), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("076aec24-4fba-40ed-8cad-6d18870a2157"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$RbEsjXy3AMspEIKHzolMdeXUOj.7/27s7cvtDvacb1LDK0lMqmr.K", null, false, new DateTime(2023, 4, 3, 16, 21, 32, 874, DateTimeKind.Local).AddTicks(4551), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("09836933-25f9-49c2-85ce-aa0dbe14f5bd"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$LbV2jl/e8RItC.Sa.cizOu6J9s9jDIXHQUuyfLCjzYAgumRuhY7qy", null, false, new DateTime(2023, 4, 3, 16, 21, 28, 916, DateTimeKind.Local).AddTicks(6541), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("0bd179bf-7b07-4021-8102-e5f24e8fc96e"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$IP143VqlGvKADjkQuOxfpuyVC.UrAYouNndePuqb3cwndOeHjm9BG", null, false, new DateTime(2023, 4, 3, 16, 21, 29, 982, DateTimeKind.Local).AddTicks(9537), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("12897b63-1be0-49ed-ada6-1a040c7fd3a8"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$Ijm91dqtlKfY9NPtk9Ab8OtxxsTgh76rvh3IOYDg5GfWMcYwFfFe6", null, false, new DateTime(2023, 4, 3, 16, 21, 36, 892, DateTimeKind.Local).AddTicks(4371), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("12949abb-6388-4d88-a321-0c738c13d6da"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$0vpt3eFv6wpG5sUfbZ2yKufgUv9YFtkWxtnryRL2KzZ/yXcPRi6hO", null, false, new DateTime(2023, 4, 3, 16, 21, 31, 634, DateTimeKind.Local).AddTicks(3807), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("16031ea2-90b3-4081-bfed-b9f381c1c3c0"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$cdWvKvPUb7q.l8SGfn15P.sIc.3tlTnOTpP8yNE33LbID1bItMSd6", null, false, new DateTime(2023, 4, 3, 16, 21, 28, 249, DateTimeKind.Local).AddTicks(8445), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("16e12f2d-ef99-431e-820a-787f37275fe8"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$2H6eVsZ/ajm7segiq1APYuYHEB2dSIU7lGooAy9JiRD6k1mMtlRj.", null, false, new DateTime(2023, 4, 3, 16, 21, 29, 882, DateTimeKind.Local).AddTicks(7496), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("17b91029-45ba-458c-b9bc-7b7cb9c3faa3"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$nNgMxNRGcdGS5wUH3NKiK.5xoLiPmiv45bnbC0N6AmnoVSAkg5LBa", null, false, new DateTime(2023, 4, 3, 16, 21, 30, 832, DateTimeKind.Local).AddTicks(8124), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("20ec357c-a0c0-4551-b35d-6e406d3701ae"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$Z7wNnr8S3FZLKKBH9w7BuONnrt1S2P2FGQ/twUwIgad7gZb6Ua0L6", null, false, new DateTime(2023, 4, 3, 16, 21, 31, 167, DateTimeKind.Local).AddTicks(4275), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("21bacff9-1bcd-4907-8364-efe572b38b87"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$V/VcZ4BGzva.Kddsid6wK./D/RZWT.Eagu/h3fy2Sia5gXtaKTX/e", null, false, new DateTime(2023, 4, 3, 16, 21, 32, 991, DateTimeKind.Local).AddTicks(8078), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("22fccd3d-d97c-4c76-a8c4-7d3c28a287bb"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$44PtP9ptES/5BEtfJaO0k.fZlEBU/15NT/XAwB.PbNw8jifTivp9e", null, false, new DateTime(2023, 4, 3, 16, 21, 28, 807, DateTimeKind.Local).AddTicks(6073), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("23813ec1-687b-4045-8aeb-462217118138"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$ttXO6CdaYnYhFbD3EeFba.TChmaXFeS7zZ6YZVJ9rXIbvLxb1/8Y6", null, false, new DateTime(2023, 4, 3, 16, 21, 34, 41, DateTimeKind.Local).AddTicks(2326), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("242e237a-2df6-4a01-8a8a-6a2195aed592"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$De54Fft4LLjW14i1HfUz9OBXPVxIPbV4d7R785FxKEOFyQG.6.Qa2", null, false, new DateTime(2023, 4, 3, 16, 21, 31, 862, DateTimeKind.Local).AddTicks(4828), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("289f95d4-00f0-452f-87e3-8ce577a85dc2"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$f9b/dodJEydhUJh9a7QtDutOtP3i04v/qQl/yTHKQhUQHBOPsjhV.", null, false, new DateTime(2023, 4, 3, 16, 21, 30, 937, DateTimeKind.Local).AddTicks(6320), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("29b57002-9039-47ef-bad9-834ae1cc2fbd"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$PIOOdgwnlJrHsiT8SDCnTe0757O93sYkUhFLiK10MWanELK5pCI5W", null, false, new DateTime(2023, 4, 3, 16, 21, 30, 730, DateTimeKind.Local).AddTicks(8039), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("2d010e00-ca94-4a48-910c-9579b0bd2cf7"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$uZpRJ.lOy82F1vymfCFmXOAzv7uBvK9i37324TMuPisz0yTeMak16", null, false, new DateTime(2023, 4, 3, 16, 21, 39, 428, DateTimeKind.Local).AddTicks(8937), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("306e44ac-0081-4b7e-8c92-340b0bc8808b"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$a7YgqBxEIsXKIhH9LGq8ZOI9aJFXl.j9/y27SYp.1LlJdZYBGJ85O", null, false, new DateTime(2023, 4, 3, 16, 21, 28, 384, DateTimeKind.Local).AddTicks(4606), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("352caea2-7180-4ded-80bc-2ccafdd601f3"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$IHyJ7ujtm1.esHcXVzU83eA7vk.NKUGYRfvyo6zr6LyFFsLhNqhty", null, false, new DateTime(2023, 4, 3, 16, 21, 27, 557, DateTimeKind.Local).AddTicks(3183), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("369c2974-9cc6-4d7d-b733-f96f72349166"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$LHF0ySmIspd4b0W/TVYICO7MvexiTYfZO.TiU..OeTWNED/hqB1VG", null, false, new DateTime(2023, 4, 3, 16, 21, 36, 511, DateTimeKind.Local).AddTicks(4148), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("39541452-b98d-4c7f-ab07-1dece55124b8"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$081HVSQy6Mulu4ARjzyHRuF.e72H3hSVgn25qmsqkWJDqT0blZMLy", null, false, new DateTime(2023, 4, 3, 16, 21, 38, 15, DateTimeKind.Local).AddTicks(5927), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("3c13f087-4bd8-4d58-8a13-26f1206600d8"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$UNFodJ3JPTlxReiRY17S1OzGtQ9cP2kzXlKLq7dCLbu/rAXt6lwnO", null, false, new DateTime(2023, 4, 3, 16, 21, 38, 257, DateTimeKind.Local).AddTicks(1197), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("431cb3ef-6a3a-4966-b6dd-3183cc84414f"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$RhxbnooPD/GH8zv6.nNmEObM3DZKltETDdhlqB7QA.N8W5OwSbP9y", null, false, new DateTime(2023, 4, 3, 16, 21, 33, 383, DateTimeKind.Local).AddTicks(4298), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("43a65d3f-03c2-4183-8e5d-81d4e4e1261e"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$7vkndYrLrpPKfzU0H687UuIDO/JCaBCvOKBYfH/aBzF1KSbC63QeW", null, false, new DateTime(2023, 4, 3, 16, 21, 35, 969, DateTimeKind.Local).AddTicks(6924), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("44951fba-2722-409f-ad3b-707652386b3f"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$LtFN75SurvYikK73C.WjjOmSCmnAuWgeJNxuf89K/I6FIIa4.eT2W", null, false, new DateTime(2023, 4, 3, 16, 21, 39, 208, DateTimeKind.Local).AddTicks(9777), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("4f99b318-a654-48b4-9b88-5c6451b04281"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$YSTAZdQUScUWrqRhlKmMNOJCUHFFzoPRCdx2r2iyzTLklI28ASStC", null, false, new DateTime(2023, 4, 3, 16, 21, 36, 652, DateTimeKind.Local).AddTicks(7829), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("509f4ada-96cd-4f9f-b674-23c5b3abc03c"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$9nPecN/Osfra6WYwOO2BgudFjhD93YyX0/f8X9ZVC00qTMJO8i63O", null, false, new DateTime(2023, 4, 3, 16, 21, 29, 389, DateTimeKind.Local).AddTicks(5887), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("510a1585-1dde-4f41-aae3-199dfda71ebf"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$ivwI5slhOOhh8lAcPjItg.XqQ7vz2GpQ2v3EfVMFip7MQWbvJXgKq", null, false, new DateTime(2023, 4, 3, 16, 21, 39, 544, DateTimeKind.Local).AddTicks(8754), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("5745f4c0-58af-40a2-8b94-7755417c6a14"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$0KYmk8oLs0LQ.JeTlLj94u18CdcxT4SvFJWYQpiFa6xnrEADWJINS", null, false, new DateTime(2023, 4, 3, 16, 21, 34, 425, DateTimeKind.Local).AddTicks(7498), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("58640e68-aaa1-4031-a752-785ce9ff8344"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$h9fFKEX9dXum4t9kf9tH0e.QWxAkSO0HrTy2gMH9xB4Nhnk7qE6WS", null, false, new DateTime(2023, 4, 3, 16, 21, 34, 307, DateTimeKind.Local).AddTicks(2681), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("5b7ab684-0e4f-402f-ae41-369a66e04d35"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$Elzjjhe.m/vQ4lRAsaYmVe1RIffoKVCOeh1Ia2RhWf0R3waLKD7G.", null, false, new DateTime(2023, 4, 3, 16, 21, 39, 708, DateTimeKind.Local).AddTicks(6024), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("61db9768-ed34-4a47-bdd1-6de37921bf90"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$IufKN9rI6inTLCX./2TyBOlgt7i3uZkP2SbWVxYxOL/JYZD95vhfS", null, false, new DateTime(2023, 4, 3, 16, 21, 38, 138, DateTimeKind.Local).AddTicks(8162), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("63616004-a927-4c1d-ac58-c367ff6b5f86"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$HK/FT.lho.Ae1aFpWGXZvuyrTCloRfH02eNUG5ouYVE/a1r8lZUjq", null, false, new DateTime(2023, 4, 3, 16, 21, 34, 549, DateTimeKind.Local).AddTicks(1011), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("6373177e-637e-472b-b7b2-70b3f6c73054"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$SFB3d3kij05X4bWUtFP7euqy9ve3fcJdPboSvVYNwnxMcmAa/lfua", null, false, new DateTime(2023, 4, 3, 16, 21, 34, 186, DateTimeKind.Local).AddTicks(1929), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("6496bf71-7d7c-4943-9550-d37a834ee81a"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$7.n92qE8J1JQ2l/86QgyQOOXJX8pDzr2uk7A/wqTYu5fnqEHPaJgq", null, false, new DateTime(2023, 4, 3, 16, 21, 39, 819, DateTimeKind.Local).AddTicks(3518), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("6557bdb9-b86f-4029-b682-3f80cd76f4a4"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$WazBbo4jttQvr77j4nR9PeHCqEn/JGXSzEFBd3rS3sbHu7REPMpfK", null, false, new DateTime(2023, 4, 3, 16, 21, 30, 405, DateTimeKind.Local).AddTicks(6012), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("682f9922-1714-48c2-a56c-75b246efa6ca"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$w7vdUceRhJB/FfXf5x7J.uobCV7PPpvH/updjeoLYQz/eGmmBqxqK", null, false, new DateTime(2023, 4, 3, 16, 21, 37, 351, DateTimeKind.Local).AddTicks(8649), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("6998fee7-7e28-4619-a868-0205089fc18d"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$yQVvE1JQ47L0Q81f3jAlFuxhw4BK92R3LZt5TuIhSYVRTljI74mSC", null, false, new DateTime(2023, 4, 3, 16, 21, 40, 573, DateTimeKind.Local).AddTicks(8459), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("6e387746-4b54-4363-af59-4fb96bf4d51c"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$niEH.IAHNaUtzC5PbolideS9ngTsUpBgZaCxe/388.hv1CcNhPNV.", null, false, new DateTime(2023, 4, 3, 16, 21, 39, 919, DateTimeKind.Local).AddTicks(7586), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("75e0a978-be3c-4d61-950f-d95fd2cb0593"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$AGTExSugI4aBf3VK4/LatOD45VBugFJg.KigLedZv8XTXwIuc6rxK", null, false, new DateTime(2023, 4, 3, 16, 21, 40, 122, DateTimeKind.Local).AddTicks(1886), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("7695668d-7e08-49e3-958f-acf089aa5846"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$K.G4tusHWI6EQu7YClm4Muc0dtcj0uComgowRfHrpA7umAX.0g5DG", null, false, new DateTime(2023, 4, 3, 16, 21, 35, 22, DateTimeKind.Local).AddTicks(4073), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("76cc445e-5a58-4bf1-a58d-e111e8abeb51"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$p0zzhRsjFx5.8p.zIx.GjuHqyKTaB.nwhzRBoBnNnLWOGmMQxomcq", null, false, new DateTime(2023, 4, 3, 16, 21, 31, 507, DateTimeKind.Local).AddTicks(3478), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("78cf12cc-6893-4556-bec4-35a71f591423"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$4MmpdXrgZMdLh7WqVWfUqueTslQFn78zqAV.Sy3XycEF2lnhzemUe", null, false, new DateTime(2023, 4, 3, 16, 21, 32, 64, DateTimeKind.Local).AddTicks(6737), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("792c8617-4b1c-4ae7-950d-a15cbfb2eca7"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$EjvCiz5XFlJcKgN2TfzjlOixLOQMtHXCZHLQMaEI0KIlWtAv1cGji", null, false, new DateTime(2023, 4, 3, 16, 21, 40, 770, DateTimeKind.Local).AddTicks(8954), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("7a8dfe14-f693-4c5b-a5e5-b3d200a8b162"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$UzH9mPgRfzjPtCd91Sj6Ee4tIkeCxRBJpT750vXuLDF4vV4q/8r9q", null, false, new DateTime(2023, 4, 3, 16, 21, 36, 997, DateTimeKind.Local).AddTicks(9603), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("7c949200-00bc-4550-b33a-d4d514ee0578"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$Jm3vEnegBOlw0wzNGtiUwedCCfJOAvKnc6JHRdonaQLsCRoPmOdEO", null, false, new DateTime(2023, 4, 3, 16, 21, 33, 831, DateTimeKind.Local).AddTicks(9895), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("8734f5a6-f848-4b90-9aff-f4866e441334"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$NzQeGGXTqvjTrRQ6F8HIceds5kb/jw0yJlKkvZN4dhsBtZXGxYaIq", null, false, new DateTime(2023, 4, 3, 16, 21, 39, 316, DateTimeKind.Local).AddTicks(8131), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("8bf58d8b-1da6-473a-8cf0-108f01081599"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$VHagSqZKq6pNOAdq2s1zce5cGwh4JSlNoQKLWObzRx5asxvOivPqu", null, false, new DateTime(2023, 4, 3, 16, 21, 35, 728, DateTimeKind.Local).AddTicks(4762), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("8d08b3b1-5651-4b88-a497-c3985c18a958"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$YA3.82pfmSBufmLXisVave0CqzGQBUTsbCsN8RO1bhFrOKgRRn56.", null, false, new DateTime(2023, 4, 3, 16, 21, 38, 364, DateTimeKind.Local).AddTicks(2449), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("8ebfc21d-96d7-436f-a4c1-c28fceb68e65"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$yOcA06YVVPU8HJ1AnSt0I.xaJ4TxDRESnCVQjGbsVoAmj9saDVgou", null, false, new DateTime(2023, 4, 3, 16, 21, 31, 388, DateTimeKind.Local).AddTicks(7178), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("8f371bf8-bb91-410a-9bb4-e89e3a7b93a2"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$QiTNUAgAPv7NSaAKDpMwxOg1p7LExysRcADHaChAaI5VXzYwTnQDu", null, false, new DateTime(2023, 4, 3, 16, 21, 32, 160, DateTimeKind.Local).AddTicks(2845), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("8fc33bed-0c76-4e0f-be06-2c6ae45acbc8"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$5hUXAcARwSxGbwjzll.hIOqCEccveLKGMKO1tzu.LjhoMamIldbcW", null, false, new DateTime(2023, 4, 3, 16, 21, 35, 856, DateTimeKind.Local).AddTicks(9021), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("90df099c-30fa-4c8b-b40e-f1797acf02b0"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$7F8H3zrZNOmG5V6JJmVRmuca7RmTHcJUI66UfvHX2W1OWfb1e4cLC", null, false, new DateTime(2023, 4, 3, 16, 21, 27, 953, DateTimeKind.Local).AddTicks(3884), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("9207adce-4eff-4401-ad11-6646ca82caf7"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$byZPd54W9uktn2rpwQ7sKufnfb2SgdB8MCmqX4u4APtQ/zMrA5by.", null, false, new DateTime(2023, 4, 3, 16, 21, 34, 674, DateTimeKind.Local).AddTicks(8781), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("92d08f07-f364-4a9a-94f0-9fd5109a4ba8"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$39sDJ06/9Hkx/RsugaO9tOSLBDBQ4jDsb0Fk4UxyNlbA2zM76JbnS", null, false, new DateTime(2023, 4, 3, 16, 21, 28, 114, DateTimeKind.Local).AddTicks(4004), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("93b86107-f6b5-4168-b9c5-3931e0e18d49"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$Eo2B93kmh6t9Q38pQtCI2.mjlJ5XhE2R2UFXipAT7QNit789xZTYa", null, false, new DateTime(2023, 4, 3, 16, 21, 29, 25, DateTimeKind.Local).AddTicks(1194), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("93c483da-0baf-451b-8596-90aaa7a8de11"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$sheXOrYyEXiSpXMZn9TKqO90.ViiWVny9xvIoGWtSl.cPG/akDU7e", null, false, new DateTime(2023, 4, 3, 16, 21, 37, 864, DateTimeKind.Local).AddTicks(4361), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("943929a5-a30b-436c-95cb-6ea4d0e6cc27"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$AvnSLSSz.T/dBjU7oEuKvOu2K84Cs1BUNz8D7Qogu8S7ila2KtOXS", null, false, new DateTime(2023, 4, 3, 16, 21, 33, 102, DateTimeKind.Local).AddTicks(8173), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("96e42fc6-6104-47e9-a0b1-9095d77d516d"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$K9QgjAHIpkk5kYyia9TezO..HfgD9YTvVJkQUuRexcqBz8ApK0WOy", null, false, new DateTime(2023, 4, 3, 16, 21, 32, 539, DateTimeKind.Local).AddTicks(7264), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("9a4d5cdd-16de-47cd-b5f3-7beccfdecbb8"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$G4.r/4wAYTdch/Ct2GC1MuhU0CCArGX.sOEQeZTzvasU/IMixARpG", null, false, new DateTime(2023, 4, 3, 16, 21, 39, 55, DateTimeKind.Local).AddTicks(1476), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("9ad99f8e-a3bc-4ee2-a620-48ff92f7e4e1"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$zDB/AEUA2/agLmz3tgJNme2z/sxZjeW.o42m7WD0BOZyY66Kf1B46", null, false, new DateTime(2023, 4, 3, 16, 21, 37, 105, DateTimeKind.Local).AddTicks(2838), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("9c1eee67-5d5c-4cf1-a7d5-2c3a62fedac5"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$0oWV3pJX94cbLoqeEqsrruksHOcL423ywPS2zyDpjIPlOdv6usTVu", null, false, new DateTime(2023, 4, 3, 16, 21, 31, 960, DateTimeKind.Local).AddTicks(4759), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("9cbfd311-60b9-4915-9cef-0290be7c514d"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$lCqqqy3Kl2ctsAYuLrDUJevYkvNoN6mKqHMFFn9NBM3yelc9a4MCW", null, false, new DateTime(2023, 4, 3, 16, 21, 33, 617, DateTimeKind.Local).AddTicks(8378), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("a1afd851-2dcc-4534-a94f-adfd4e7225ae"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$x/o5XEgbQTPHcHbjogFicejERZSF8nZSD3Y6oOvEHBTivZxCnFMzG", null, false, new DateTime(2023, 4, 3, 16, 21, 31, 58, DateTimeKind.Local).AddTicks(4238), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("a1c1691e-190f-421a-b098-1505e97a3f79"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$zvkSPjNQ6AUerw90HQlnhem0ZQ/ch6EcH47PsTlCoMGs3ai05QQ5y", null, false, new DateTime(2023, 4, 3, 16, 21, 36, 89, DateTimeKind.Local).AddTicks(5756), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("a2e8c786-2aab-4ab2-8d37-39b004f700a7"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$25hnVg2P.1OmkoIWAXit8uFNOsqyAPJcpPgEoCT8vlrbu3a5zDZ5y", null, false, new DateTime(2023, 4, 3, 16, 21, 30, 287, DateTimeKind.Local).AddTicks(8095), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("a5530f5f-07fe-4101-b2d4-dfd91f845c52"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$wq5QbOI/2nopefJsLLQDauc8.blufVz0Xjpv2SnsktbIKunGbgsIm", null, false, new DateTime(2023, 4, 3, 16, 21, 40, 885, DateTimeKind.Local).AddTicks(2325), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("a68c1bcc-a1f1-4eff-a832-41ce55373aab"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$xy/ss41eiTl4jtdAJ2L.re9/JAETUvyIOJ/VHxni7DCMsdWeuXuJu", null, false, new DateTime(2023, 4, 3, 16, 21, 31, 290, DateTimeKind.Local).AddTicks(461), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("a706ec12-699c-4bb6-939a-e628a89c62bb"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$Bv2sLek3NWQZB/0cPJxmWOCU7feFs/44CPGxxz06IWUaUfgoDJEmG", null, false, new DateTime(2023, 4, 3, 16, 21, 35, 144, DateTimeKind.Local).AddTicks(9489), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("b1430d41-5cae-4879-bb13-db10a84a34f5"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$mouK82CkVqh4kbq1pyDQ/OijIGOu3uBIGtpdfRhuVIMgjk/QI8HEq", null, false, new DateTime(2023, 4, 3, 16, 21, 32, 281, DateTimeKind.Local).AddTicks(1249), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("b167df6c-8f47-4fe1-b405-8b63ba9d323d"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$U4n75AoDv8w/sV8XQjK5dukMdoG3wpG6/5JUl5faB/wApVooV0yM2", null, false, new DateTime(2023, 4, 3, 16, 21, 40, 234, DateTimeKind.Local).AddTicks(7898), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("b2dde891-0b6f-4bc3-a8f9-b4bc1eb1cebe"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$Kk73gNgjCAvjiMrIVcmkOO9rzKzc/HHQZ1BSrF1eGQ0N52SSU9kFe", null, false, new DateTime(2023, 4, 3, 16, 21, 27, 830, DateTimeKind.Local).AddTicks(373), " Nguyen Van", null, null, "0966416708", -772000, "customer" },
                    { new Guid("b319fdec-c373-4fe9-a3c6-185d91e141a4"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$k02k0zrT2Gj388epC2H/c.kd5Fo3JwR3jfZnZzzJZB/4401voonYC", null, false, new DateTime(2023, 4, 3, 16, 21, 35, 389, DateTimeKind.Local).AddTicks(7578), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("b42613da-bbe4-4abe-87c5-aab82b547970"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$oQNyBMs/P.g0MaZwd3mreeWzaTVC9wYvFydormz4AMpVgVFKjvdlC", null, false, new DateTime(2023, 4, 3, 16, 21, 32, 420, DateTimeKind.Local).AddTicks(6542), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("b60722f0-2a51-47e1-a9fd-7d2df5602475"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$VCY/wsdIYCY7wbtSlbbGkOfMrfaEWK6tTxjNlgs.qQOjpjHArSVc2", null, false, new DateTime(2023, 4, 3, 16, 21, 40, 471, DateTimeKind.Local).AddTicks(3709), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("b64f4d37-b6d3-4c94-8afe-d2cb8c1aaa5b"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$WtHe0zW8gGFe7PzYWBFg6./39a6u1nKC4bdbkU2NsYAUFupvoX2Oe", null, false, new DateTime(2023, 4, 3, 16, 21, 38, 836, DateTimeKind.Local).AddTicks(8122), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("ba098d1d-5741-4bd5-891b-6c5562855e70"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$QTYhotchOM261pHw/VJtdueUggK5LIPxLYC//PdI6CkidkjfiXw.m", null, false, new DateTime(2023, 4, 3, 16, 21, 35, 283, DateTimeKind.Local).AddTicks(4996), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("bf51fd82-e4a4-44bf-82e5-8d94ba841207"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$.EG/a113idIgSM3TMnKaFeEMgDnIzEsdiUb58V/LwgYdhnj1dbi2O", null, false, new DateTime(2023, 4, 3, 16, 21, 36, 773, DateTimeKind.Local).AddTicks(6449), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("c0de3431-c279-41dd-b333-2a47831b9c20"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$8D.yLwVSAbX87T9x8MaHGuz41VZ23EMZw6ZYbno3KiF9UdvcoqJ56", null, false, new DateTime(2023, 4, 3, 16, 21, 29, 259, DateTimeKind.Local).AddTicks(1767), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("c13a2bac-2cd0-4349-bd98-626a9664e8f1"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$/WrzkJmTJMkmVqwgqiEE8O0UXk11F7QRQ4k9lAuhhcXuoc45OdRmO", null, false, new DateTime(2023, 4, 3, 16, 21, 28, 526, DateTimeKind.Local).AddTicks(1083), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("c16cbd38-6f43-4197-b5db-bff76a3b36cd"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$./ICHyyoTnT4qRDvWq4dOO7J.W3lrXauhBChOVcILyFRJBblsXSkC", null, false, new DateTime(2023, 4, 3, 16, 21, 30, 81, DateTimeKind.Local).AddTicks(144), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("c34bc212-1115-4eec-b8fc-11eddcac52a5"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$t/E1BbRUSZMY1dXuhOGEwu6n6ZvKEdb24GZZf8CuRj8Fr93xWZkHu", null, false, new DateTime(2023, 4, 3, 16, 21, 29, 127, DateTimeKind.Local).AddTicks(7949), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("c7af7a29-9d36-4639-8e0e-ea2913b3e55d"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$woA7qmS1S6A1u7L22mXU0OCbDILLF3NE745sJEyxaVCxcFUim4QW.", null, false, new DateTime(2023, 4, 3, 16, 21, 37, 217, DateTimeKind.Local).AddTicks(3734), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("c7d4c623-3ee5-40f7-94dd-96cf27f60c82"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$XysM8hbE.rpKADlSv2q.GeshhkpoFldu1c2tpCH1grAvYhv.55ao6", null, false, new DateTime(2023, 4, 3, 16, 21, 38, 615, DateTimeKind.Local).AddTicks(7468), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("c80f032e-1d4a-4cad-8a0a-c459a4735ebd"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$vbJEOXG/hyHI539YQMN8SObueV.T8vVn10D15xVyLX8/IzxIUOhBu", null, false, new DateTime(2023, 4, 3, 16, 21, 30, 180, DateTimeKind.Local).AddTicks(5148), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("cb2ee398-7864-4c0b-9437-3b2fd853942f"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$Yap2GmhkXSX37xmSEEZwSeq/xlFPxEApgTvxAFQWcN5t.JIouQB2u", null, false, new DateTime(2023, 4, 3, 16, 21, 38, 477, DateTimeKind.Local).AddTicks(5516), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("cbd30530-f6ad-43ab-8f41-3b20c3fa94c7"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$TXC7B0lHm8vDdmm9KeQd8e5Ti1Bb5icLDOGOjQBUbgaPdXi8D1G1u", null, false, new DateTime(2023, 4, 3, 16, 21, 37, 480, DateTimeKind.Local).AddTicks(9314), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("cc4c2acd-6721-4cae-9e6b-c06377ff08a4"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$At/iRgDub3gU9dQ.xxsMEOyMFw1jqcgd3SCMzAgeix1kcMH9rtfJK", null, false, new DateTime(2023, 4, 3, 16, 21, 28, 666, DateTimeKind.Local).AddTicks(5169), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("cd7ee450-5bfd-4ccf-99cf-eb25d051035d"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$jeL/AubVnyc3R3aGzIsZxeT.K1eu5x/TJQ6pIwY4vp6hrmhSv0UK.", null, false, new DateTime(2023, 4, 3, 16, 21, 33, 719, DateTimeKind.Local).AddTicks(4517), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("cee10f23-1823-489e-b79e-682341ad56fe"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$PjqwyERruv6zNfycUtosu.b/dvyNiMlSuZCJwDSlwhxC3ZfidCMe2", null, false, new DateTime(2023, 4, 3, 16, 21, 32, 649, DateTimeKind.Local).AddTicks(4858), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("d11166e3-8a38-4d71-8ea8-255229815f55"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$mTN7dXreT2Vs7U7qWiqBCOMQs9EmJWP3Xms9OCmoeRUMiuTt40I7K", null, false, new DateTime(2023, 4, 3, 16, 21, 37, 619, DateTimeKind.Local).AddTicks(8928), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("d5b1a870-f1ea-408e-b433-0a7255efac7a"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$m81QHh.ExazWiFgpXiqzQ.5MSi5AtZQQzXouhyLxhr8AkoAtuU9kW", null, false, new DateTime(2023, 4, 3, 16, 21, 40, 672, DateTimeKind.Local).AddTicks(4704), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("d7236070-1cfb-44ff-958c-1e68ded000b3"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$gYj/bmdoMrqyJuShyjuK.euOYoDtHrf3CKcuO9ILdNY0gzb7fTZ2.", null, false, new DateTime(2023, 4, 3, 16, 21, 35, 620, DateTimeKind.Local).AddTicks(9403), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("d8dfe5ed-527a-4cfa-8214-7b9ccb9c144e"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$CRi/UQZzVLWbzLaj/h0CDukVJpmgDpvXP8mYA4frqf12TaRNHwxLS", null, false, new DateTime(2023, 4, 3, 16, 21, 36, 409, DateTimeKind.Local).AddTicks(3387), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("e27d5a31-cc50-4592-a1cf-866424e11420"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$fIVXKwHGuGBNw8u9JOnAsOC.MOhM0q3HtOvH2SX9zFwpSd3caZAc6", null, false, new DateTime(2023, 4, 3, 16, 21, 38, 732, DateTimeKind.Local).AddTicks(339), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("e3195113-b501-4cd2-95f9-18def94ae794"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$wVH2kH1BdvwlV/tro1YmqOotG.NYNj.LUaFE8/TnV3abHusnP4kGO", null, false, new DateTime(2023, 4, 3, 16, 21, 29, 657, DateTimeKind.Local).AddTicks(3590), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("e39dd020-74c0-49c0-b855-e7a6717b4a1e"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$dO6tyJivwY7BOkFnpoFSROMaaneZb0Y9sQM.Nc2Yj3JEd2m0yEIe.", null, false, new DateTime(2023, 4, 3, 16, 21, 36, 202, DateTimeKind.Local).AddTicks(1898), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("e3bd3d23-e490-443b-9fc2-4b658720d4f2"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$i5Zv.UKKwv7PQ6/Bl9roKunHS4Y2niKsVQALIlqV1/FVCaEo38Xsm", null, false, new DateTime(2023, 4, 3, 16, 21, 33, 939, DateTimeKind.Local).AddTicks(1726), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("e43d47c6-c1b9-48b7-8831-32f5f536034c"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$qf/EB.KUPgOHufKW4VURDOBQPRJZvfmnbEAU3X7PZ1FJKIfGdlL5K", null, false, new DateTime(2023, 4, 3, 16, 21, 34, 814, DateTimeKind.Local).AddTicks(7468), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("e7bec958-f6f6-478d-8193-8d4e1f654c00"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$DMwDBnOMShEoKlRD0BppM.6YD9n6tS5A/tJCWekKnTFZ6idha4Fnu", null, false, new DateTime(2023, 4, 3, 16, 21, 40, 360, DateTimeKind.Local).AddTicks(7192), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("e849a4f5-7f4b-4304-bffb-b2da609a04f5"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$gMcVnnvOaWm.hgh1Yh341us6G7R7r03qQUnAFDXAzkPyq21lMeKpa", null, false, new DateTime(2023, 4, 3, 16, 21, 31, 755, DateTimeKind.Local).AddTicks(8488), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("e9c55751-d4b2-4cd4-8bd7-b9cf99dd92ef"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$u3JZ1SYt.dVuGPOMTnzdy.vGJRsZt.ZMlXsl/.5X6R3ifdk9CYc/O", null, false, new DateTime(2023, 4, 3, 16, 21, 27, 694, DateTimeKind.Local).AddTicks(8454), " Ass min", null, null, "0966416708", -772000, "admin" },
                    { new Guid("eb371ca2-54a1-42a5-a7f1-135f4d139130"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$IfsIv8oIrhu60FOOehbfAeTS75d3NxB7tSjMgzq9k7glP.yzXOtBu", null, false, new DateTime(2023, 4, 3, 16, 21, 32, 754, DateTimeKind.Local).AddTicks(4528), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("ebb25c01-d59c-4cc8-8819-27233a32fce6"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$lkKToOz0r2pQoTb4e96VK.Jd0UywkTuke225sn9ilPpWvoDx.X5/6", null, false, new DateTime(2023, 4, 3, 16, 21, 35, 492, DateTimeKind.Local).AddTicks(5013), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("eefad1e2-9c74-440e-a9af-30e4aa013c01"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$Sp0Ft9W50HEKp9VtFB8URe966gNcm.WmBxu0HfqgrNuHjVBPoaE0W", null, false, new DateTime(2023, 4, 3, 16, 21, 34, 921, DateTimeKind.Local).AddTicks(384), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("f3e55684-01eb-45c0-9006-d00e45794152"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$4zHz1TrDMe7zejkqysHU3ODlGtZWzr0D.qHaPtc/dzYU01tBHuYeG", null, false, new DateTime(2023, 4, 3, 16, 21, 36, 303, DateTimeKind.Local).AddTicks(8538), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("f5bf1ad0-3e81-4e12-a367-7e2c75bb28bb"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$ZcC9dZcO36Ao.BR6iKNWRe9kyszXNZjVzWdKHevLzwJtjkdcjz8rq", null, false, new DateTime(2023, 4, 3, 16, 21, 29, 537, DateTimeKind.Local).AddTicks(7920), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("f6d12f55-2f65-49b2-80c9-792ce0d19d86"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$S0LuuFO3/yuj336AWTdOq.GfgvxD67IXY2UDxzp3u8nx9ZiDfifGW", null, false, new DateTime(2023, 4, 3, 16, 21, 38, 935, DateTimeKind.Local).AddTicks(6944), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("f918f40b-1b38-4eee-9017-6bdf76fa164c"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$F/O/mb.6bwWD1yU8NGt/kevRJYIayTWohAJ9oruyGar1Q2JNlsFOC", null, false, new DateTime(2023, 4, 3, 16, 21, 33, 492, DateTimeKind.Local).AddTicks(2095), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("f9d9df0d-2b8b-48c0-8541-98f1a98638e1"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$0//Hvhh80Rd1QcFnyx/nYuHSs2FWLxFprLkP6XHdPq12qFrDsU.vK", null, false, new DateTime(2023, 4, 3, 16, 21, 29, 778, DateTimeKind.Local).AddTicks(6838), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("fcc1dfe6-a1de-4a20-a605-5ef728936ad0"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$qqNf.okz66hOgY/sdmPiNey/fAukpmT1F2FGSN92YfFGqlT.TH3a6", null, false, new DateTime(2023, 4, 3, 16, 21, 33, 252, DateTimeKind.Local).AddTicks(4369), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("fe07caee-178d-4c05-ab3f-e99610ec6dbf"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$Gvwvaz22L417V7t7V.oX4unF/FAKa5/xU4tnSdCFxpALLuN5i78U2", null, false, new DateTime(2023, 4, 3, 16, 21, 30, 524, DateTimeKind.Local).AddTicks(2383), "McCloy", null, null, "08418620623", 2, "tmccloyl" }
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
