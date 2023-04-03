using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver18 : Migration
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
                    { new Guid("033ce7f4-f5a2-463b-b7a0-182ec0e14372"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("23dc6801-bef0-4672-9c20-7a4f3d2a00df"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("3d4590e3-a598-43c6-b36b-770961c6c3bc"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("bf99f479-3026-42c0-b76a-adcaf075b3c3"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("e51660a1-6311-4c41-9858-e9173f5fdd44"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("fd086be9-646c-4717-8ba6-8981268ee0ca"), "Xe van con", null, null, "Minivan", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("13580ab0-6db6-4a2a-a72f-1f375cba7de8"), "Half Year", new DateTime(2023, 4, 2, 22, 19, 58, 720, DateTimeKind.Local).AddTicks(2418), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c0b51c0-84b0-438f-9c21-7a161da08ca0"), "1 Year", new DateTime(2023, 4, 2, 22, 19, 58, 720, DateTimeKind.Local).AddTicks(2421), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df3f9103-9066-4b10-8d79-73cb73a94574"), "Short time", new DateTime(2023, 4, 2, 22, 19, 58, 720, DateTimeKind.Local).AddTicks(2409), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("00c53958-5445-435e-9e0e-c617b92fec87"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$EK91RfJmi2tCbD85XK9oB.8VV./8B4cl0Hck5I0xBYE80w1oSAVMq", false, new DateTime(2023, 4, 2, 22, 19, 55, 110, DateTimeKind.Local).AddTicks(5362), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("0258f86d-02c7-4c43-a692-76b5b9f27f52"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$EKZzicT7eeRVpPDG4DpjZucpbqGu8AWGHaq87pr2E1r6Bc/.sticy", false, new DateTime(2023, 4, 2, 22, 19, 49, 859, DateTimeKind.Local).AddTicks(2505), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("03ed1eae-b208-49d0-86a1-f3ea7e4b929a"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$votWASm5Rp3ID/BcDNCDPe199hlAYiRwSeEl3iGKz4YtC3kUuf5U6", false, new DateTime(2023, 4, 2, 22, 19, 48, 256, DateTimeKind.Local).AddTicks(1451), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("0464b4f8-ab24-4e4a-be00-88394377b581"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$VmFKDFjoLy/xhswzbnZAm.v4nH0xs30ruYsUfVVpRBQU7ZnNInETq", false, new DateTime(2023, 4, 2, 22, 19, 54, 477, DateTimeKind.Local).AddTicks(6300), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("08642f23-9514-4493-852e-b6764ed05f2f"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$Nf/Prl/RNsQBb4Sd4kgbf.4rRuXuIl9/Xu302rnv2742csgXcjfim", false, new DateTime(2023, 4, 2, 22, 19, 55, 13, DateTimeKind.Local).AddTicks(1489), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("0a722f3f-b3c3-4afb-9280-dcc01a7f0fbf"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$ZlQhz7hao7XjOkxgbeMgyuJxoI.zHHTejzBnAgrpoXvXvuM.zHy12", false, new DateTime(2023, 4, 2, 22, 19, 50, 68, DateTimeKind.Local).AddTicks(6265), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("0da5234d-3dcb-4b01-b885-82a1cce5ea48"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$qmqoK/2FH79OW4f9en0Wlu6E2.SIb7M6aKSSaOHsqYdxY2Zzyi80i", false, new DateTime(2023, 4, 2, 22, 19, 52, 368, DateTimeKind.Local).AddTicks(2352), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("0e6ce6b6-3b6a-4475-b19c-cc9611c55061"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$hx2AiMTGWHK8EC1x44xbpOko6JM3dnxqXpZqfYGMuY1azZwtmiWAW", false, new DateTime(2023, 4, 2, 22, 19, 58, 720, DateTimeKind.Local).AddTicks(1535), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("0f709710-ae25-41fd-8d9e-e07c648fa5e0"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$cKFReppPqJPsnzkHQ0LlUOv0siNZrd24Kry.4KA7yBuCNy0kViPVC", false, new DateTime(2023, 4, 2, 22, 19, 52, 62, DateTimeKind.Local).AddTicks(9916), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("148315de-98f5-422b-adc3-b4e72e7fbadc"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$Vv9kcyiUt5OyHbO4woVS3uobeS7ckWPRkHq7j1Irp6SbeV6UuS1r2", false, new DateTime(2023, 4, 2, 22, 19, 46, 534, DateTimeKind.Local).AddTicks(7219), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("19c4f4c0-8e26-44f1-b21b-6957ae6e82ce"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$KQhx0lUHLYQDZW3ly3o3KuFbKRVIgMw/foM1NbXk0hVFYicYd3DDi", false, new DateTime(2023, 4, 2, 22, 19, 50, 203, DateTimeKind.Local).AddTicks(634), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("1a6e827c-e840-412a-adb6-851b6d05940e"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$eDCK.UC639Luf48KDrs8yeSMFas.jXy3HCkzDZtiqyK6ok1xC9dU2", false, new DateTime(2023, 4, 2, 22, 19, 54, 723, DateTimeKind.Local).AddTicks(5212), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("1bac41d4-480c-4c8f-bbf9-e89077cb4907"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$UehAJiDRUtE8SdvK1MtwK.PwdD9QJaGBlNFs02.TRutdDwyBCPpIm", false, new DateTime(2023, 4, 2, 22, 19, 51, 829, DateTimeKind.Local).AddTicks(1813), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("1d687a98-5113-4f61-9d54-a5857cd5fe8a"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$OdY71q.sh9gM44dXdJ1RvejAv29.NZvoZVrCGxC2uSsMvWegqKl6q", false, new DateTime(2023, 4, 2, 22, 19, 56, 179, DateTimeKind.Local).AddTicks(1601), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("1e020901-1eec-45fd-a400-bc89b858c13f"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$qQ4XtRofrP8rMhDv17uPB.7ae5eZPiA4g18uyMQaBsKmjF5CRlEmy", false, new DateTime(2023, 4, 2, 22, 19, 58, 386, DateTimeKind.Local).AddTicks(9259), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("205191cb-8069-464e-a7e8-fe8036183ac9"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$kcEqOD7y9Gq/x0sbDacH5ejjso9xqsR1woLiDUN7DdboeKjHkWx6m", false, new DateTime(2023, 4, 2, 22, 19, 57, 484, DateTimeKind.Local).AddTicks(5892), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("26a65a47-e3a7-4a55-9c88-9e671f2dbee1"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$.3xztpJUwoNw9YW4v64UUu2S.HX./aC02tln6H/IhmblQOcjlpiFC", false, new DateTime(2023, 4, 2, 22, 19, 58, 64, DateTimeKind.Local).AddTicks(2370), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("27907f54-a7cd-4931-9f78-ffca7f5e3d81"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$SUaxEPdxIVaFvaUhWqK9Buwek1VAlbYm7e/5Ov4SY25MNOXKwFfU2", false, new DateTime(2023, 4, 2, 22, 19, 50, 829, DateTimeKind.Local).AddTicks(2287), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("2850d411-8189-49f3-a12c-d3b903043268"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$qTWKie/.p/37VwAADRlRXOKoq.m5fMOhESAlpIedZC9wSb2VYiN5m", false, new DateTime(2023, 4, 2, 22, 19, 57, 812, DateTimeKind.Local).AddTicks(7498), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("28a8dfb7-5b1a-45cb-86c1-7f7016395164"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$AaqTI9Be.Ym1z4aE9Ks1feYM2puzGlxb9ZAPGP8KM.J51Mw86EkYK", false, new DateTime(2023, 4, 2, 22, 19, 54, 821, DateTimeKind.Local).AddTicks(5141), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("29b6087c-ddf8-4a35-8c5c-1557c4809bfe"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$2gfxNRSwA.wn6S.lBeugK.gCQlnfUnioCHDyqRQ.orscw5SNDDej.", false, new DateTime(2023, 4, 2, 22, 19, 48, 3, DateTimeKind.Local).AddTicks(9617), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("2c1f9382-79e5-4c37-9d1e-13c3aad45971"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$ahOq19F4lnlOuVA8X3Tu4OvrHP8jVyOpjEaLE06VgUu9s.g7.cWAC", false, new DateTime(2023, 4, 2, 22, 19, 56, 635, DateTimeKind.Local).AddTicks(6181), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("2c22fed8-1b48-430d-b3b9-d760b219f705"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$TB7NRBygNxMJbAh/.jzWWuSfD9w4.fLwSkSgOI9ZsVCSe/QswQbCm", false, new DateTime(2023, 4, 2, 22, 19, 56, 880, DateTimeKind.Local).AddTicks(6053), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("31b58a92-99ba-44f2-921f-10242c146671"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$HLeZZg5fkoaMaFLXoDc7E.1AQaSyTBZWpu4FvjHawb4KsK4gA51Ye", false, new DateTime(2023, 4, 2, 22, 19, 52, 471, DateTimeKind.Local).AddTicks(2600), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("31b87614-1a8b-48cf-8198-33ba23573ebc"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$d1bDp.mUHCuZEHpHKFywx.YnZWa/ZQC1i.qV273PGgs90fZ9jhTb6", false, new DateTime(2023, 4, 2, 22, 19, 49, 521, DateTimeKind.Local).AddTicks(9858), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("364ebc8c-6c93-4bbb-a05e-0e0710dbbbcd"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$/fOUzaZDvMdRi/R6k6wcEeAdzOtQazJKn4ydCarHMM3HzervK8Igi", false, new DateTime(2023, 4, 2, 22, 19, 51, 478, DateTimeKind.Local).AddTicks(6964), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("40ba6a7d-4a67-46d0-9dd2-d84df37af9b4"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$9YIMf4DaQzUvpq0gUOnuqu/gAeJ4sb1NadZxnrYIDYfn6OoLImRDi", false, new DateTime(2023, 4, 2, 22, 19, 49, 951, DateTimeKind.Local).AddTicks(7469), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("40bc29e1-9207-4e42-ae7a-dac380df0f10"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$sJx4OO7/vhWqcmwaJKSZ8uJcZfDMRAxHfMzdO3gEoBSQi0y.EnRmC", false, new DateTime(2023, 4, 2, 22, 19, 53, 422, DateTimeKind.Local).AddTicks(3974), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("415e3c93-1616-4890-a57b-f8357463cc63"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$xQBdW.HgQb0j44OHP2AW5O/KYvyI9zNBwjcHjd3ejaVikoNbnQ4zm", false, new DateTime(2023, 4, 2, 22, 19, 50, 980, DateTimeKind.Local).AddTicks(1269), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("46181c80-bd78-4541-a5a3-94982fb71945"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$JPV9nruqqCKVkg.lfa40NOhHGOob.PuzUDugJeSUQvF9Lmq0x9MZq", false, new DateTime(2023, 4, 2, 22, 19, 52, 889, DateTimeKind.Local).AddTicks(2331), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("4738f085-c1a2-4395-bd51-bd4aa5acd364"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$rsnRYu1v5oAngU0KzvHHMuGZ1R2YkDQ8Ca7eFYBtxyqngv.vrsose", false, new DateTime(2023, 4, 2, 22, 19, 52, 781, DateTimeKind.Local).AddTicks(2444), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("484afb3c-49e9-4c40-9db8-7faac0ad5704"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$2QjTv/TsREg8zTVvliqxxeIcCQ19CYCvF4JlPAmu4V7PWCuAtxlLm", false, new DateTime(2023, 4, 2, 22, 19, 50, 430, DateTimeKind.Local).AddTicks(6904), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("49b93d12-6a0b-43eb-be24-520c8b6b65e3"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$OcWsOhure810vsM2wARpAuIQ4BFumsZxXjqYtMB342bATAOcOGf5y", false, new DateTime(2023, 4, 2, 22, 19, 49, 287, DateTimeKind.Local).AddTicks(2570), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("4a6cc02e-aca6-429d-aad0-a96bbafec277"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$HD1Dm.urYgdTS95CDLY3N.CeyxjfI./iC2VRmX07itR9yGK8nFTR2", false, new DateTime(2023, 4, 2, 22, 19, 54, 74, DateTimeKind.Local).AddTicks(1910), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("4debdf82-66fc-4b56-9c94-b96a6b50a4c8"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$rBLQ4lnWaK5yQezH.rWe/OyXPKb4IEPF2.FBhT2LSbuOf2UCx0Gvm", false, new DateTime(2023, 4, 2, 22, 19, 52, 158, DateTimeKind.Local).AddTicks(8965), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("4fc8ab6f-39ff-4ca0-8e8f-7f19817700d0"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$X0mQSVuc4/e9ugKXUj44xuOSq14alvvFMnuaZeYAzwIkh0KKw9MqK", false, new DateTime(2023, 4, 2, 22, 19, 55, 210, DateTimeKind.Local).AddTicks(2101), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("52169fa9-cd56-48ce-897b-56298f952022"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$2eU3rU4/AtNB8cCRybyygeEemadpW0lcBD.uCsKbkgTbNZApa.VOK", false, new DateTime(2023, 4, 2, 22, 19, 51, 962, DateTimeKind.Local).AddTicks(8629), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("52378d2f-a293-4cc4-aa89-2cff3fc25447"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$ddPK65Hwzlk.rgcHx/zuIuPr6rcsOvPoyk96DAFgZ74KYgSWUeIM.", false, new DateTime(2023, 4, 2, 22, 19, 52, 573, DateTimeKind.Local).AddTicks(5101), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("52f60199-f308-494b-a68d-2a8c30cb0f49"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$QKe0RLrWqMjv2rTAea/BCO8I/GVDcxxg2Bobo6Q8PZbNA3.AIc9ja", false, new DateTime(2023, 4, 2, 22, 19, 49, 191, DateTimeKind.Local).AddTicks(6675), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("5491bb7f-7ddc-4065-87fa-1817622bb682"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$xZ/sYeCtCmExP8HfQDFpQ.f5xI5/0136qIMQFR3BAFzFhlkmRk52O", false, new DateTime(2023, 4, 2, 22, 19, 53, 88, DateTimeKind.Local).AddTicks(4971), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("5494c57e-65a3-44da-adfa-8473026c8ba2"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$HN/hDTnvoAxIGFXqkPSgwe5t.O2Acsi61ABVGt/d4fXkv3vXgCHti", false, new DateTime(2023, 4, 2, 22, 19, 52, 987, DateTimeKind.Local).AddTicks(7767), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("559814aa-5779-4e01-930b-62047230812d"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$BV1Y9CY1tg.8ECd6okHyOeIoVhkq4E3DLZTHDSJp9m3082NpPaTva", false, new DateTime(2023, 4, 2, 22, 19, 47, 765, DateTimeKind.Local).AddTicks(7143), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("5678e40b-b498-4594-a32e-6cccec535282"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$YNZELxW1flsitmGHp5TKNuIwke3Q6zvP2VEhUMbykPriDcoRG8hKG", false, new DateTime(2023, 4, 2, 22, 19, 53, 723, DateTimeKind.Local).AddTicks(9275), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("5c728096-c9c6-4e0e-8b7b-1584a86ae551"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$gMZLKZomwyy8NXh/QY9XLO5jDsmOeuxdoVKZgoVxlNlDmbIRPjAG6", false, new DateTime(2023, 4, 2, 22, 19, 49, 93, DateTimeKind.Local).AddTicks(1854), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("5dd04dfc-c821-46e7-910c-c83eeffd698c"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$reJLFwfDjs53QGjLyIV.3.2OitOjDvVPIZHTmgQuVlgaEEfifXQNC", false, new DateTime(2023, 4, 2, 22, 19, 55, 582, DateTimeKind.Local).AddTicks(778), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("6021f360-8bf3-47ae-a2dc-ae8dd82b5649"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$EJgm6dbdJjxZP8OwFvZr/uF9u9JjwC4k2MFihvLXxz/25kp6D9Qc6", false, new DateTime(2023, 4, 2, 22, 19, 57, 234, DateTimeKind.Local).AddTicks(290), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("64247117-6208-4eb9-9158-fc9b3b9d5465"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$ZNZ/6vT9JKZdRBe0LL1rGOdQkCrZjsxzGo53HQnUbzD1Y0B0oQHXC", false, new DateTime(2023, 4, 2, 22, 19, 46, 942, DateTimeKind.Local).AddTicks(2280), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("65d2c23d-e29c-453e-ad6f-1ac43ecc3c49"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$pXj.jgGKcksVe4gz7OtN8eJREEALh2y9Ix2F5qwvTNuqgRS0VBZGi", false, new DateTime(2023, 4, 2, 22, 19, 55, 966, DateTimeKind.Local).AddTicks(4515), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("67a379f9-27e9-43de-9522-3b9317c07bf2"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$abk1lfni19GKRyEMolIAU.BVySDMrAwqjwrutEYKVBQj3esiqH5eq", false, new DateTime(2023, 4, 2, 22, 19, 53, 959, DateTimeKind.Local).AddTicks(2432), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("69583560-f67b-4afa-a874-f761ccfdc41d"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$VsRdWMDtOT8w8eqSvI5dTOnAKwpgXdE0ti1bY9u1ktjohn4xHZ.XK", false, new DateTime(2023, 4, 2, 22, 19, 47, 230, DateTimeKind.Local).AddTicks(839), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("6ccad5d8-a01f-4487-abd2-678391d3e853"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$J8.saHSfmvCPnkFTtpf.LerubeCOejxc77DSKwW8go9DRs5GKUudu", false, new DateTime(2023, 4, 2, 22, 19, 48, 374, DateTimeKind.Local).AddTicks(9472), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("6e86f698-5619-47fb-862d-6008af293a5e"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$fXVJ0DsY64SkFDwvLC2yTOUL/U2tHXBy4oEcLxAt4iZTWOU2PU7ti", false, new DateTime(2023, 4, 2, 22, 19, 56, 761, DateTimeKind.Local).AddTicks(1521), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("6f5dabb7-7f4d-4b00-ba5e-9ced38820485"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$xBn8qlrFzhtehXRVz61he.aUOjRnBZS3exgSI9yBX5CDAE84U5ZVW", false, new DateTime(2023, 4, 2, 22, 19, 57, 595, DateTimeKind.Local).AddTicks(6886), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("70af0b87-5d63-43cc-b37a-927614f925a1"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$Uf99LOtJFw.fjxRrR.iveOnGbNNeGZ5huFslx8NIj5G2sMg82B.Su", false, new DateTime(2023, 4, 2, 22, 19, 46, 245, DateTimeKind.Local).AddTicks(4035), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("7217fe6d-a407-44cc-b2ac-4e30fc7a8a28"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$iNqp/NCQCeenH6cH/.tO6O1OI77gIctQ2E/Vgc5JJzD2RjbD/0V6e", false, new DateTime(2023, 4, 2, 22, 19, 57, 345, DateTimeKind.Local).AddTicks(9995), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("76fb4b65-436e-4450-b81e-f4585fee9e43"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$c3VFpWnLhWcDxifv/eyt3unm0KNIn7IRhNDR3gpbHgcOba0v5drWW", false, new DateTime(2023, 4, 2, 22, 19, 54, 174, DateTimeKind.Local).AddTicks(1631), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("7731f4e0-7907-4382-9c54-bb3e5b502600"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$GGLr9k7KChqoaGX5LIWRmeJx6IxZdxZqyp5VHThIzrag1HdpiKd2O", false, new DateTime(2023, 4, 2, 22, 19, 46, 813, DateTimeKind.Local).AddTicks(228), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("7a9c63a7-922a-4392-a0e5-55abdfa3732c"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$MwMrNrSk8k2sM2snoOAOxuQzflVN5U2jwsF2ieqLdvTLnyOmjmzc.", false, new DateTime(2023, 4, 2, 22, 19, 49, 655, DateTimeKind.Local).AddTicks(7706), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("7cd6402a-ec2c-42df-b52c-5b066e39c0e2"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$PXLzyL54aJiesVK2djB3C.s3O0bvTXuumTHvlJDDdvh93haUr1qpi", false, new DateTime(2023, 4, 2, 22, 19, 51, 115, DateTimeKind.Local).AddTicks(8003), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("7df80260-fbdd-4540-92db-10a260f80c0d"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$P8E3IqFeFnu3GcWv7eB7yuYdGzHsTUkNH9PTXilv9fmjZnz065UYO", false, new DateTime(2023, 4, 2, 22, 19, 51, 338, DateTimeKind.Local).AddTicks(8253), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("7e7bb932-5f81-4e04-a875-46d4ec62bd31"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$tTL4548sUlgjht5vC5Dd/u34YfskLNrsoqKqJLR.a5r4H1IWvzwSq", false, new DateTime(2023, 4, 2, 22, 19, 57, 131, DateTimeKind.Local).AddTicks(3477), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("7f17dbe0-782e-4846-bdb1-3d42069b36f4"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$5LCC4p9E.NS4byEmn8A8zOmDw8Xy.29zCUatVYLgspc2KdPFkKoR2", false, new DateTime(2023, 4, 2, 22, 19, 54, 919, DateTimeKind.Local).AddTicks(4699), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("81b2c502-fe4b-4e56-a31c-0ff85f106eb4"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$y4ar65FY63jUAYNipJvk1uK8UHPcK83EM8QYAyTc1uRmRGueh/UE2", false, new DateTime(2023, 4, 2, 22, 19, 46, 92, DateTimeKind.Local).AddTicks(8059), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("843c5d87-005d-4ecb-b458-6a2a3249ec14"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$cqBtOON9LQVTcuo/4HIdpObCjjMDIfkTz61pIHm1lQyqHyQBZ1gua", false, new DateTime(2023, 4, 2, 22, 19, 48, 609, DateTimeKind.Local).AddTicks(6741), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("84c32bf2-96e4-4ae9-be80-a3ad1599381a"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$amnoaC8TH0aj7zfiPk/rbOx7rbdhko4PTdtgE.p6QBVp1x4kJthe.", false, new DateTime(2023, 4, 2, 22, 19, 50, 621, DateTimeKind.Local).AddTicks(4320), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("8897660e-c983-4079-bd4d-779387423975"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$bt3WNNvrCKzRD33DXeRfSeULrVfehzDznwSIe/RQfs.0QQXXykmFu", false, new DateTime(2023, 4, 2, 22, 19, 50, 526, DateTimeKind.Local).AddTicks(8456), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("8a9c341d-1b23-4c40-af45-178bec7a27eb"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$vznKqIFIGgj9sXpYl84d4e7YMXqP.BG/6cDnEcPzQeK/ApQlwchgi", false, new DateTime(2023, 4, 2, 22, 19, 58, 270, DateTimeKind.Local).AddTicks(2998), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("8faa9b08-0218-4f84-8807-57893e00365d"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$cdwRv/vh1BJxSGsvP0YZnOPp6Gb4.LHDmD0ZAGCYOo1E.K1vGVwga", false, new DateTime(2023, 4, 2, 22, 19, 53, 289, DateTimeKind.Local).AddTicks(7818), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("934605d1-4b1e-4a55-ab6b-0da9c2dbecb8"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$JTjR4VU5kd3c3evmKB8ADuY.J9pRSh5Qx2Z1mVy3VruMh6rVmdfSe", false, new DateTime(2023, 4, 2, 22, 19, 51, 693, DateTimeKind.Local).AddTicks(1701), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("94711250-42ed-4133-9a1c-4e18d1681608"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$CxogxF5aq2FOhDlqpYg6We2Lq0bBVhzhz77PiAxwIyyiS3p4Nk8t.", false, new DateTime(2023, 4, 2, 22, 19, 46, 364, DateTimeKind.Local).AddTicks(503), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("95e232d9-539b-44b7-91e2-812445e36c27"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$01ybfXZ/sxfQEyZ1DEWLYuVoJmk.ubeYp81Jmq3cfh6BPA7zKU9N6", false, new DateTime(2023, 4, 2, 22, 19, 55, 331, DateTimeKind.Local).AddTicks(672), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("96c37002-f140-4627-ae66-ac6750ffd63d"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$x8dGwvthHLQmWAnEUV9zwO3wKMPmH0jXS9pMWZdE3urxWDtlc0fnK", false, new DateTime(2023, 4, 2, 22, 19, 54, 369, DateTimeKind.Local).AddTicks(2089), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("9aad9f61-76d7-47d4-b0eb-a7c1cdfba4d3"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$YxZePD1IDmPlf1FcaMHb3OU7rGrVgIDPxsYqs.rcNqdcpZzsQ11vy", false, new DateTime(2023, 4, 2, 22, 19, 58, 169, DateTimeKind.Local).AddTicks(1706), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("9c9e04da-d3d7-4228-8091-6361ab3150d8"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$3dQdlp/WTXSIceEmegyYV.xjggCYFcspSsJZd60UzbPN4iQpPJGhi", false, new DateTime(2023, 4, 2, 22, 19, 54, 602, DateTimeKind.Local).AddTicks(7061), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("9d85ebcb-8fd4-4daa-85ee-c46f1cda84a0"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$X04Yth/YE7WkrAq3XDd.wOlqArhKOvdLBiVRVC2/LZ6tm8k2q6v/a", false, new DateTime(2023, 4, 2, 22, 19, 51, 582, DateTimeKind.Local).AddTicks(3856), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("9fa17eb4-661b-4ada-8be0-1070e249aefe"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$6doyhQ6NksE2IwlZ5pCDi.NsVZkI7yG4dFbqF/FPXGe2RXmb/11Gy", false, new DateTime(2023, 4, 2, 22, 19, 56, 985, DateTimeKind.Local).AddTicks(7362), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("a47a81a4-36a4-4ca3-b955-6397ef73ef56"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$GI.B0pgn7FbrYY7JubocWOGAkxv/O7jnva7zuRFmzYfqEbzs6TUk.", false, new DateTime(2023, 4, 2, 22, 19, 55, 874, DateTimeKind.Local).AddTicks(1042), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("a4e78bfb-a66a-4b50-9858-3060a98f1ce6"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$yLSqfJJmy.LVJFWqlBg4euMqB5NLLHFT9chx0YLJbAxgiF9XtnHuK", false, new DateTime(2023, 4, 2, 22, 19, 47, 654, DateTimeKind.Local).AddTicks(80), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("a589771d-82d7-46e6-af35-301ac0ab91f2"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$PtJNCp6lDcWTFTEqCRK/YuLBZDFgeoYttI2ikLs6ucVwRnAN4yPCu", false, new DateTime(2023, 4, 2, 22, 19, 45, 968, DateTimeKind.Local).AddTicks(988), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("b0e75bf2-4aa9-4942-8408-0063ee91d48b"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$SjfcUsFJAvpTHAVVDGx1xuYNf8YosJBfHwy481zkCPAUsRR92myzK", false, new DateTime(2023, 4, 2, 22, 19, 49, 397, DateTimeKind.Local).AddTicks(8845), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("b2637f85-5167-452b-a8c9-757fb400b34f"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$0duJMNNuHdozP4qAHVHl/O34dg49hYUf7EzE6bw4fwlGlltwgGgYm", false, new DateTime(2023, 4, 2, 22, 19, 48, 838, DateTimeKind.Local).AddTicks(4534), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("b29a5ecb-1eda-48b4-96db-06a47ab04774"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$BkkwhVqk9T2p3ZaWzgwuXOoqw6XFa4dAogbMH40OG8vrDxfpTOh8y", false, new DateTime(2023, 4, 2, 22, 19, 53, 845, DateTimeKind.Local).AddTicks(8752), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("b467ab70-9eb7-4594-a49b-08ba55116c67"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$p2ymAO80yXjPYVHXZHUZRedx2UiXaK4z8u4jdV8yB5OH6ms4hr71.", false, new DateTime(2023, 4, 2, 22, 19, 49, 764, DateTimeKind.Local).AddTicks(819), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("b9880bfc-669e-40ef-9dac-bcb09aaa49eb"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$5KSBIiPNrX/uDFVuWMNjWOU1xd0iOEGsgeFOnJmakpBJk.YASXi86", false, new DateTime(2023, 4, 2, 22, 19, 47, 517, DateTimeKind.Local).AddTicks(898), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("b9ab773b-94f9-407d-ae07-f8716947ee6a"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$IsIJ6IF.ue/8wjW.klvkoO9m3HRwv6KY.eQW/iTpRhxytglTrY/4O", false, new DateTime(2023, 4, 2, 22, 19, 53, 188, DateTimeKind.Local).AddTicks(3966), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("bc9f6f6c-eeb3-4e13-9ca7-9eb62ac3cfd5"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$9p1eco5SBYU6BQlHrDo/Ne4zeG2ICxvMWZXzQ7.1g63Fa1Ys4JZay", false, new DateTime(2023, 4, 2, 22, 19, 58, 623, DateTimeKind.Local).AddTicks(4684), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("bea7e9a2-9fe3-4b7c-8f39-6afe12f24b47"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$KfPv0niMATtLNN2whwHWCONNBXpoV5RCtpqhoD30jqilOzp73wcL2", false, new DateTime(2023, 4, 2, 22, 19, 55, 681, DateTimeKind.Local).AddTicks(9025), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("c037e8af-56cc-4c08-aae5-9deac7e9b0e6"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$FxJIIjt7I.BpSZih/Q6F5uTWclTge4WCOs3Qcewqq.WYbNfGJFYAe", false, new DateTime(2023, 4, 2, 22, 19, 54, 271, DateTimeKind.Local).AddTicks(4506), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("c0af81d4-fbe6-427c-abaa-0753994249e2"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$4pMpNtZwjDpjAAAFKhiroupCRA8LAHWIU8lHP2eWzctLMvpIr3fDi", false, new DateTime(2023, 4, 2, 22, 19, 53, 529, DateTimeKind.Local).AddTicks(6248), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("c38091e8-5b68-49ae-bec7-80a31288a295"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$/JXGpkwUj.o1G8cG23akQ.99xayYnXdPnsHzzAep1oavAxTEzIXga", false, new DateTime(2023, 4, 2, 22, 19, 47, 87, DateTimeKind.Local).AddTicks(2283), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("c46864a2-4dd9-47f5-9179-aaccd3119316"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$uPH9KyFo7wSD/VocFSf6vePkLuwoNzrisJL4WNBoJkcUTjatXORYi", false, new DateTime(2023, 4, 2, 22, 19, 48, 968, DateTimeKind.Local).AddTicks(4698), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("c68d0910-492a-4eb9-8992-cec8c1552bf6"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$FEMZuZVvWgEXcjpF4fo1n.ggREyAuXd3L77hg9gJN4NOs5cHv.bD6", false, new DateTime(2023, 4, 2, 22, 19, 55, 776, DateTimeKind.Local).AddTicks(3593), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("c8e204de-96aa-4d43-9dc8-e3abd331d311"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$o.59AyYdfgwe.jd20LPn5./3QdhD7IOX6wSLLj7P/EWLTxJl8.96O", false, new DateTime(2023, 4, 2, 22, 19, 48, 127, DateTimeKind.Local).AddTicks(1619), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("c9e503d8-d371-45cd-aaef-83ac4704e92b"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$sNqHCS6dQhMCilUbaWpawu88lA0PkXsmoGkOnZbTNwgYC0hz6F7cK", false, new DateTime(2023, 4, 2, 22, 19, 52, 263, DateTimeKind.Local).AddTicks(7399), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("cbf41c1a-ccfb-4e36-8d60-bdd4dcd4dc78"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$vOI7C9O.1WOxb4RqBayFz.pOts5CFmGrSVsHE9IyUSloHoPvBQcMO", false, new DateTime(2023, 4, 2, 22, 19, 55, 467, DateTimeKind.Local).AddTicks(4710), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("d02fd295-bc0f-41a8-8bd2-22869e29a2b8"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$TCRVqzzZT1FzcgcpFkK2duuDDH5sWqh/M1GMYVFYBRK4l3oY1ZJm.", false, new DateTime(2023, 4, 2, 22, 19, 56, 415, DateTimeKind.Local).AddTicks(2919), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("d116528d-6b98-49a9-b15f-c825a8a5b6c8"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$10wjQLC5MqdDt1tdP3um3.8J0nc.KflkjPA/bJnzJPcjAJp.jcm46", false, new DateTime(2023, 4, 2, 22, 19, 56, 523, DateTimeKind.Local).AddTicks(4990), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("d24e5e1d-e891-4e1f-9e99-577d2ea23a9c"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$j9TwcJvfuQZfaO1zXmdri.B5bfDYGzsauPWJ1pmctpU1GNKwi2gvq", false, new DateTime(2023, 4, 2, 22, 19, 57, 951, DateTimeKind.Local).AddTicks(4401), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("d97be407-4d8a-4862-94c8-cb56032f0dae"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$QVAs.07F8r0OoqTha55MneB4iMh4bDOHP9DwyrHjnIiaVlzKzifca", false, new DateTime(2023, 4, 2, 22, 19, 53, 627, DateTimeKind.Local).AddTicks(8700), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("e466dfa6-9032-4d28-b755-50a5fa8dbfd7"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$IkGMhaMLC.fxFAFwxb0/Du9e0Ic6iLjef3dIrTfh1adiRk1hSy8yK", false, new DateTime(2023, 4, 2, 22, 19, 47, 889, DateTimeKind.Local).AddTicks(8253), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("e4dcdfa9-dfbf-41be-a38a-ee1602fdf90a"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$MU717g/8xuurQItlz6.h9uSbCKTBLiGVPWixiwvaG.37zPxfkPHdS", false, new DateTime(2023, 4, 2, 22, 19, 48, 504, DateTimeKind.Local).AddTicks(3541), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("e99a1406-5d61-4a56-8f7d-517db7e7a2ab"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$47CC.GU..gIblrvuPUuiI.zm52NSM2OlG7u90JMGCexWpQgY.iEKm", false, new DateTime(2023, 4, 2, 22, 19, 52, 673, DateTimeKind.Local).AddTicks(6570), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("e9a4d39e-a56a-4a1e-bef5-525d9d71d1c9"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$ksX6RpIXL8ECDtR0/2RTd.K6y.naEkV9oCFWTDAwDOyDkw5/WB0je", false, new DateTime(2023, 4, 2, 22, 19, 57, 698, DateTimeKind.Local).AddTicks(3282), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("ef3bad8e-a0c1-4b02-8722-d38b396d7238"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$jrWh3KWLHUgxKYW9iFBOT.hrEhd/s2yfPYg6kIwtQ0Wz7o4YiUPMu", false, new DateTime(2023, 4, 2, 22, 19, 58, 522, DateTimeKind.Local).AddTicks(2480), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("f5d70b3c-c193-497b-b5eb-a071e1e37754"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$pgwMFdnCFC5Pi091fDzKgeqpXycmXXAz0hnVUa7F5yoCnzfHIa8bO", false, new DateTime(2023, 4, 2, 22, 19, 56, 66, DateTimeKind.Local).AddTicks(5451), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("f6692234-c078-4586-a4bd-abee07e6d1d8"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$9MCIiZ2geF46E18FzqkF4egyshwTvdhMADmfykYgtIkKxjEheos/6", false, new DateTime(2023, 4, 2, 22, 19, 50, 334, DateTimeKind.Local).AddTicks(3006), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("f7e3819f-7dbd-4a5b-a884-0b7e7fd1dd9d"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$/WCy2xhm/hPlGCBa4pgxIOEB45PDsZeXO6BZw/Cb6Ujk6SXDS1ia2", false, new DateTime(2023, 4, 2, 22, 19, 46, 663, DateTimeKind.Local).AddTicks(5846), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("fc01b7d6-77bd-493d-9e33-3db909ff05ff"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$DIHWSkR3oEDi1s4tIVJo9Ou2ryZSUI.G1uTDix90e/8BWktWS0h7m", false, new DateTime(2023, 4, 2, 22, 19, 50, 714, DateTimeKind.Local).AddTicks(7003), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("fd6fe73c-852c-4ecf-9c36-5847827eba41"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$Rk5ps3T9z2Oh4TfPuHRzSOPItwl4MsltgDIyHopmVOFah608XqePe", false, new DateTime(2023, 4, 2, 22, 19, 51, 233, DateTimeKind.Local).AddTicks(845), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("fdacb7af-5a4a-458b-b4c5-855e371c8570"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$FP34t8H/S4H5rsq1o2SAauw7uUJaUEiDOT681DkOiVnyzKVoOzlQG", false, new DateTime(2023, 4, 2, 22, 19, 56, 286, DateTimeKind.Local).AddTicks(6815), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("fed9635d-6bde-46e3-a7d1-7e7711bcc0b5"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$AtQks125gfL05EVmYqgdj.DAcPZegJgrIIkKm4oIXmwMvWquo5gQ2", false, new DateTime(2023, 4, 2, 22, 19, 47, 374, DateTimeKind.Local).AddTicks(3715), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("ff7a7763-726a-4ea6-a0c6-dada7d5b90ad"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$Ls5cmAjKZYxhcmslZtObgOUE7I6vdz3jpGjprQXyPKdB0OgGBxAly", false, new DateTime(2023, 4, 2, 22, 19, 48, 721, DateTimeKind.Local).AddTicks(9370), "Garrioch", null, null, "0072752247", 1, "mgarriochk" }
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
