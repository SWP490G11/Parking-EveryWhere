using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver16 : Migration
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
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("0191d0f9-653c-4565-ba59-b92e2149a4ac"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$p8BzOUnf1mCARDb/CjKH2e7B8Lo4orjq0IJ0Prt0F12Yd/VF0hFXq", false, new DateTime(2023, 2, 15, 21, 15, 37, 5, DateTimeKind.Local).AddTicks(1605), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("022bcd1d-fa20-4a5f-880d-d03b31907841"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$PxZuVEBIQ7coOpsADKIWaeH6ebCkY6jWsjJW6OlPQjEl7eBDf1ayy", false, new DateTime(2023, 2, 15, 21, 15, 45, 2, DateTimeKind.Local).AddTicks(7575), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("0a924832-ac54-4595-96a9-8316bf7d5f2e"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$b5Nw50tfOR2Hgy9yS2sq1uXl4uKMe0na7GTP/aOkXC53SytbE14sG", false, new DateTime(2023, 2, 15, 21, 15, 39, 415, DateTimeKind.Local).AddTicks(9258), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("0b1611b2-f6a0-4695-a730-4cf984f664aa"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$eH3Z56CqU1oT0YJAr3Nt2uh9TiR3BEoSULDx1x5sPcEZHr1yu6i8e", false, new DateTime(2023, 2, 15, 21, 15, 36, 710, DateTimeKind.Local).AddTicks(3042), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("0d4b7252-8390-41b3-a550-df399e276adb"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$qKNah79UQ7NtpQ.Hiy8x8.2Dzflf4yKLfk1347R/j.cCED/IeRKQm", false, new DateTime(2023, 2, 15, 21, 15, 42, 898, DateTimeKind.Local).AddTicks(8279), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("0d6704ae-42ff-4aec-9189-38c7a979d0f7"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$k.4riMZ6ibtT79BLcpm40eKdjjIdsX391lMBUVEqAmOUGkUVgDKjS", false, new DateTime(2023, 2, 15, 21, 15, 41, 766, DateTimeKind.Local).AddTicks(3595), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("0f53a993-10c8-4817-8d9d-1da720c282a2"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$jQw9GqU7XsXCorj6o56ldO5AM9qIzjXiZALf3OCl8DY5TTHVqE1Sq", false, new DateTime(2023, 2, 15, 21, 15, 41, 253, DateTimeKind.Local).AddTicks(5586), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("10241350-2f9b-4ff6-926c-b5a04ebd7baf"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$sXx4puU8D54L6SO9OMhekOIzgAMg9cGHpSyYkMBmdEpvIxHO/HYj6", false, new DateTime(2023, 2, 15, 21, 15, 43, 420, DateTimeKind.Local).AddTicks(531), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("11c875c3-a252-445e-88ba-72ce868ace78"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$KkYXJSOudI3C/AEvW4.An.dI5KxJTMeSKoi7Vl6IijtwAyV3fvgl.", false, new DateTime(2023, 2, 15, 21, 15, 44, 71, DateTimeKind.Local).AddTicks(9608), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("129d9a2f-00b5-477b-9ec7-af30df883df4"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$OcZ1ycGQoCglLjuzwr8Xauu9bpT0Rr3HizJ6uKhz98Bx/138VONG2", false, new DateTime(2023, 2, 15, 21, 15, 44, 322, DateTimeKind.Local).AddTicks(7690), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("1477a11d-5241-4cfb-8dae-d317c3d95933"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$Z32Fj1li7dr1TzjzTWedKOe7pQe8yfyD3Ssi5gK037rmGvVnACocW", false, new DateTime(2023, 2, 15, 21, 15, 39, 707, DateTimeKind.Local).AddTicks(4481), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("15066245-352c-4e58-9dfd-d26e98dc43b8"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$0RfMbibLl.Klx9T7W2MAL.ytDZWZ8IFUWe3nm6IBV2mIyVgWeiTwq", false, new DateTime(2023, 2, 15, 21, 15, 38, 715, DateTimeKind.Local).AddTicks(8103), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("191905f1-f238-443c-ab09-8c942a537c6a"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$8.C8D42FHQLeanm4VBtYlOJ30GCOk8eDAGo7lfsJSh7FgnGbR7ZDK", false, new DateTime(2023, 2, 15, 21, 15, 36, 22, DateTimeKind.Local).AddTicks(6317), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("19d153d6-c0dd-4c4c-972d-8eaa8a4cfbd1"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$CGt4V2412nevuXeVPIowGeCgFzgv7khvrvr3PC0DHWyCCiOOmT0kS", false, new DateTime(2023, 2, 15, 21, 15, 43, 266, DateTimeKind.Local).AddTicks(2009), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("1a2d78c3-54fd-49e0-abb7-5e704f897f4b"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$e9vmfNOGVJZbQFja.BTEYeXIPSta/vADkQzzvYYP8XhUydv8ULwWG", false, new DateTime(2023, 2, 15, 21, 15, 38, 225, DateTimeKind.Local).AddTicks(4861), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("1a417cef-d5ea-4ffe-95d7-66e07fca1311"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$8//Uhaddl4uGD.DuTAYJZ.T3Baz.7Z1.s4A0fPGz.nWluosC/ZP4K", false, new DateTime(2023, 2, 15, 21, 15, 40, 738, DateTimeKind.Local).AddTicks(3425), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("1c94836e-d5f1-4818-bb6e-e97bec90187b"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$nZPwOE9iTZzUHL/wU22ntOsf5n5B2iFQeDt2Je7I3dJ4hGnKRijCa", false, new DateTime(2023, 2, 15, 21, 15, 37, 91, DateTimeKind.Local).AddTicks(8563), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("1f3d8df4-8fdf-483c-a699-4a9f0e6d7938"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$ueIQRnYnILtlAoTNniQ8Ku/yV9SsgBogd.UC/Zs2vJr/PYTjeImhm", false, new DateTime(2023, 2, 15, 21, 15, 40, 48, DateTimeKind.Local).AddTicks(8031), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("1fd79796-1776-49a7-bbba-63abaef8d354"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$A.JiWtWQ2eFYlMujrdZzMeOqDvoXX9F049CzgTDLIwX5E6akpx7Ci", false, new DateTime(2023, 2, 15, 21, 15, 40, 124, DateTimeKind.Local).AddTicks(5532), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("222e89ac-3e48-411f-a74d-29e7b61ecd24"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$Wf8lyKr7eVSrpKtNMt9FOuRjdtqoEPevyRNrTQcE8zGBWnVZz3PHW", false, new DateTime(2023, 2, 15, 21, 15, 41, 676, DateTimeKind.Local).AddTicks(9843), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("22ded830-2898-4f45-b8d8-12774c5a56ca"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$ABDCvAbBGBGUdt5IvnNn4.3/pUVh8Q22m6oaXBTb2EWBp3F/uViD2", false, new DateTime(2023, 2, 15, 21, 15, 43, 344, DateTimeKind.Local).AddTicks(7342), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("2404b888-ceee-43d9-b34f-e17efcab26e7"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$hL.H0MfUPG2nMpi4Sp6MKOirafG5E9zd54eFNOKT8WA/deEFEW4UC", false, new DateTime(2023, 2, 15, 21, 15, 37, 619, DateTimeKind.Local).AddTicks(2581), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("2721694d-d215-4fa4-9a80-50d581fcdedc"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$VWWixSFD05VZ8h1V/sKjsu8iKq4pZ.iNl9LkfM/DWPsamK89WPKSe", false, new DateTime(2023, 2, 15, 21, 15, 40, 895, DateTimeKind.Local).AddTicks(645), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("281c4945-b186-4cd2-9cec-77e4f052fb8b"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$NRNLtsz9iK3IonPgiAeLPucud/yomYWQ7UR.BkaJEKRrBr9IF8.hi", false, new DateTime(2023, 2, 15, 21, 15, 40, 269, DateTimeKind.Local).AddTicks(2408), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("2905988b-1f19-4944-928f-0d7c712f7ec3"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$9468BT8kNcdLnsZC7ipAlOOQZ0HntRethvv4SyRDQHWFNI0bOsQKC", false, new DateTime(2023, 2, 15, 21, 15, 41, 42, DateTimeKind.Local).AddTicks(3245), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("29230107-d802-4b1f-815f-f138b64b5442"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$ZRiJaNgw.Q/hsAEH55X6WOdnTipVLGlmXffcnfCv2qnBKA7ceRfFi", false, new DateTime(2023, 2, 15, 21, 15, 40, 410, DateTimeKind.Local).AddTicks(427), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("2ab36151-2d9f-4952-9cb5-b7f09c6b6651"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$bSFpEM7eaO8VskuZ8Wb8lO0x3Pw9Di2XzSEOp5K/TzfgJNFQYYZ9m", false, new DateTime(2023, 2, 15, 21, 15, 44, 416, DateTimeKind.Local).AddTicks(1787), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("2df427a2-c4cc-4b93-b95b-ba5ae50d3d9d"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$mdLJ/cFSIJ8OfXfJdo3o1eNwZW4XnGY8WQuuxnkM.OlysSXajQGky", false, new DateTime(2023, 2, 15, 21, 15, 35, 863, DateTimeKind.Local).AddTicks(7104), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("33087c4e-80e6-4ce2-98f8-9ca550170e14"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$WzgaTPcrjlrXawPBDBdu8.1Y4gjklBl9BUfwunfB6OshP827O72uS", false, new DateTime(2023, 2, 15, 21, 15, 40, 494, DateTimeKind.Local).AddTicks(1595), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("34b11ae3-b690-418a-ac80-74572bafdb47"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$iVxfV0ZYB/Aymn0k./Xynu2jliVJHaK8EXo8y7Eu0RBMl0MiqSAsu", false, new DateTime(2023, 2, 15, 21, 15, 37, 540, DateTimeKind.Local).AddTicks(4214), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("34ec130a-05fc-429a-9234-17dd6f7521a4"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$0cvIuVCBiTGjqNslcWP6DOPD/tpdjtcwGt1Zd/.1FHCl7gs4VikCa", false, new DateTime(2023, 2, 15, 21, 15, 44, 917, DateTimeKind.Local).AddTicks(6997), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("357db707-2476-4c36-b4ec-1d56b446b204"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$sdzxwvg80z6uB3JcWVLG2eQ4l69nCvrIm83MQSOmJ2gP4Nz9KJvkm", false, new DateTime(2023, 2, 15, 21, 15, 42, 327, DateTimeKind.Local).AddTicks(7288), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("3796ebbc-d5a3-4f54-b13c-a6846d361eee"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$yQaNVyNgXC90LQGMdaEoX.isy9UFl3ROArnV.n1llWRFX1kfmApcy", false, new DateTime(2023, 2, 15, 21, 15, 42, 538, DateTimeKind.Local).AddTicks(8177), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("3a4e174e-f749-4248-8274-3a5bdf80c9b6"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$ZWQR5Etb98k4H1OwEw0GouWNW5o0UOxf34fsH1zd4EB6CkXFEevYq", false, new DateTime(2023, 2, 15, 21, 15, 37, 973, DateTimeKind.Local).AddTicks(8828), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("3de98be4-9ef7-4225-9179-4e7bce8dd1db"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$c/Dgac58n7NOmEUQHA/VWuZ6J32D7eZkCWb3TSahBNT3/ofyaxsJO", false, new DateTime(2023, 2, 15, 21, 15, 39, 558, DateTimeKind.Local).AddTicks(7867), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("3e63b8a6-c569-4d47-880e-adcfa21ee530"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$IfvzLUmKumSoy1YL2NSHL.mEAM8WBwuYlPE1oxXDiX18L4KcOeSB6", false, new DateTime(2023, 2, 15, 21, 15, 38, 639, DateTimeKind.Local).AddTicks(5989), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("421ae115-c5c6-4c3b-b6e4-50b770f444c3"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$5l45cYBDXGcW29ckWlOtYeY0AsY14fooRNibwAhs1R/rSlqNrYbX6", false, new DateTime(2023, 2, 15, 21, 15, 44, 756, DateTimeKind.Local).AddTicks(5103), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("46336c72-528c-45fb-bc41-c44d7564ec53"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$Xy7NEHkrME9PDdcEWLmpt.VPT0Gnaj7jq2A0ABRKnLYaowjn0ZLna", false, new DateTime(2023, 2, 15, 21, 15, 40, 969, DateTimeKind.Local).AddTicks(3235), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("46ef2159-815b-4333-b2f6-4b0df1ba5c9d"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$g0ldqry1AunJP6pCUqyKtelsEwhSYa2/a7kvnNL3JWer5pTW0LLJa", false, new DateTime(2023, 2, 15, 21, 15, 38, 560, DateTimeKind.Local).AddTicks(478), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("49a890c4-e192-4c7a-9eb6-0bb23072116b"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$W8XHXjM2Ttg6dxvcn8pZ3OXlmTKvjQ89jK5PGhC7WxJFqEf5OBE/2", false, new DateTime(2023, 2, 15, 21, 15, 44, 148, DateTimeKind.Local).AddTicks(2341), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("4a0b85b0-5a4c-4c32-8905-b0b13d5ce1ad"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$SePdO3c5sd3N.lt.IzB8Ze8j.BIfcS7DM.dKIEg9jQre9fGHKSvhq", false, new DateTime(2023, 2, 15, 21, 15, 38, 382, DateTimeKind.Local).AddTicks(4822), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("4b6c2ba1-7843-49ed-b2f6-2bb1f7a0f505"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$Imfx2.CaYaw2YrXvCgGMie2mb849b.s0hlTIh5Ah7AVXPtngySDfq", false, new DateTime(2023, 2, 15, 21, 15, 42, 986, DateTimeKind.Local).AddTicks(3644), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("4c6ad360-55c4-45a2-ac4e-4a08398a2bb8"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$7insAXfMAwjAoBoi7ORIMObXlr3O6Pqg9kCiMEGNR38/N1L91IeDO", false, new DateTime(2023, 2, 15, 21, 15, 37, 265, DateTimeKind.Local).AddTicks(4481), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("4f9f93eb-746f-4634-96b2-8825d2ba4c45"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$ht6p6h8ukwXJASvKUTbdaOtyxYXXz8AQyxBizZqiv6GkEt00sYxvq", false, new DateTime(2023, 2, 15, 21, 15, 38, 475, DateTimeKind.Local).AddTicks(2184), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("4ffb8833-3d41-4f4f-bf8b-e5d00e1b33d1"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$OlNoH9khJ7A23go9Ks.R9uM6DFkBlHwFUJtGut9HPo.qawwIydeJO", false, new DateTime(2023, 2, 15, 21, 15, 45, 275, DateTimeKind.Local).AddTicks(1180), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("50b94e21-35f9-4034-833e-7a68e11cd37a"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$8XEFTdmeZ/GFr8TbZHAIg.oYOp4sbfow6zgWeccJ4jSlKeh5Pds/K", false, new DateTime(2023, 2, 15, 21, 15, 38, 936, DateTimeKind.Local).AddTicks(2712), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("53eb9abc-39fb-4192-bf9e-677911d122c0"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$DJ.DQ2R1dQCi2zZPEawV9uy3FqfpL7L3nMCeZpcARfAYU6r7rSIk6", false, new DateTime(2023, 2, 15, 21, 15, 39, 802, DateTimeKind.Local).AddTicks(9733), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("57a043e7-4544-4ba7-b140-0902f373d9c5"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$SeLL2XARmGk9qK4qKTkLNePqu2V2oZy4ZLBIEEVcox6j8pAnk4UEa", false, new DateTime(2023, 2, 15, 21, 15, 39, 184, DateTimeKind.Local).AddTicks(3718), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("59468767-35ad-4db6-87ca-e7b0e321583d"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$rhepD7XZRcT04fF6j4zziuugNGlHJU0EK73.g4CU7T6/yr2ZNxqbG", false, new DateTime(2023, 2, 15, 21, 15, 36, 913, DateTimeKind.Local).AddTicks(7246), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("5bdaebeb-74d2-47ea-84de-384215d8c801"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$lz/njSgUY1HgKHDyx2aG9.delRB2.q7QUrIARIte.7kirQBnymhEi", false, new DateTime(2023, 2, 15, 21, 15, 44, 674, DateTimeKind.Local).AddTicks(7179), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("5cbd2e4c-2a59-4127-a913-96c1d07b5a46"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$sagK6.Uc4LC3an1iD1v5JeOu0OZsdQbexecgHX8B1o/SEseY5SfUa", false, new DateTime(2023, 2, 15, 21, 15, 43, 671, DateTimeKind.Local).AddTicks(1800), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("5f2ebe99-1829-45f9-b579-b0283b6d6b84"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$5wpNRd9e31itvkrVndDGzO5fSd2yBTgv.7S4211zf7Y3RvgMWGzhS", false, new DateTime(2023, 2, 15, 21, 15, 36, 295, DateTimeKind.Local).AddTicks(5770), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("600d9fe6-6463-4f89-9688-e5a353afe027"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$p.QplhZ6Tt1hT6c7YVaW8eAISdlyVCbzF2c97TbjUj69kmIcEqiZ.", false, new DateTime(2023, 2, 15, 21, 15, 43, 183, DateTimeKind.Local).AddTicks(9041), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("61703653-6219-4b95-9961-f68c8d95c530"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$9Yvgsv8Cznn2yYmMD9s/6euC/.578wxhNgMOpqwq7cJqlqImFuotS", false, new DateTime(2023, 2, 15, 21, 15, 44, 228, DateTimeKind.Local).AddTicks(8118), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("64946dcc-f230-43de-9862-8300f9e3e8ef"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$xyups6C6FFc7uLDatRv/OOZuzh3iTZdI3s2Ps2OckM66.L/TYpm2q", false, new DateTime(2023, 2, 15, 21, 15, 43, 996, DateTimeKind.Local).AddTicks(1598), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("65fc5bcc-7fbb-45a2-b248-db23ef56b5cc"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$ITfDdgibEne.WR5IKzIIi.QQq1chsBSRuD1qMgCe3HB1WgIbniCPy", false, new DateTime(2023, 2, 15, 21, 15, 44, 836, DateTimeKind.Local).AddTicks(844), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("668ea8bc-4155-47d1-9a84-7b9d83d9f260"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$U/YjTAwKfQWsve4zPG572u/vVKNrd.xheIUWZfHDi7H0yURdHkn/W", false, new DateTime(2023, 2, 15, 21, 15, 41, 323, DateTimeKind.Local).AddTicks(2095), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("6942c19e-6db0-4dd0-bd0a-bbe5720d49ad"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$tsH1kFJneJNSUsCy2KYuLOn5QAzshnkoKgdD3FJu0ZOdNrVZsANXS", false, new DateTime(2023, 2, 15, 21, 15, 37, 888, DateTimeKind.Local).AddTicks(4739), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("6da4fb95-02ee-4d30-b0fc-ee4bcd662ec8"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$sAn2HKKzQyR3UYBbnSpXfe/0P6I5Pl6x/URWGhEgzVwnojPgayS1.", false, new DateTime(2023, 2, 15, 21, 15, 38, 789, DateTimeKind.Local).AddTicks(4469), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("6fc8dbcd-df0a-40fb-9f55-b0fd7dc31d03"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$HmROZ3mLNQ2hfelArw/FU.1wx7vB1KdmWK8I7kPQ.x./VxXaNiZYq", false, new DateTime(2023, 2, 15, 21, 15, 42, 423, DateTimeKind.Local).AddTicks(9341), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("7a5beee1-5f97-43bc-8bf1-6583151ea1e9"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$2d9P2ATAnFOAk2.KpKaPROzEMZr92.Ffcu.OtmQhLOIWutbm4pQGm", false, new DateTime(2023, 2, 15, 21, 15, 36, 607, DateTimeKind.Local).AddTicks(8808), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("7b6ee799-65ee-4fc1-bd7c-e6eba857a173"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$QojXl49XNunWXxKrjfZxwO.ldefDm1BKqaUxh2UqYYqbQ83t01VCu", false, new DateTime(2023, 2, 15, 21, 15, 38, 59, DateTimeKind.Local).AddTicks(7762), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("7bed76d9-feed-4636-9d7c-3821f52426e3"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$mYUzuEpJ3i6.0CkvQJqYu.AlRFtMuHlCj92MZpuTYzEJA.0R8M3VO", false, new DateTime(2023, 2, 15, 21, 15, 42, 644, DateTimeKind.Local).AddTicks(3666), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("7d23273f-eed1-4065-baef-38f7e0569306"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$11WBncJeipPPY3mFM5LMceeVGU2mLHqmvjQKMrGD9GXyhYq/20GVG", false, new DateTime(2023, 2, 15, 21, 15, 40, 657, DateTimeKind.Local).AddTicks(5152), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("7d5ffe34-c6b3-4dc5-8caa-885761230552"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$9gT78wxvDX43xwponoPZGOpQ6KvS8Zn.l8pdxLzzlawxu8bTMn5Rq", false, new DateTime(2023, 2, 15, 21, 15, 39, 488, DateTimeKind.Local).AddTicks(265), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("7f4f65b9-0598-496b-ae12-c6d0f4ae18a1"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$kShQoiZb92qerCPe2ux3eeRqM80ebMGPF0WVY9lpFBO0QJoJe8Qvm", false, new DateTime(2023, 2, 15, 21, 15, 41, 952, DateTimeKind.Local).AddTicks(2940), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("7f8dd8bc-d7c2-4840-ac50-a34f35c09bb8"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$ffozlrHdrtnPf09VPDY9mu5Lw2Nf17uuvdL3etIFLiZpZbutLmPza", false, new DateTime(2023, 2, 15, 21, 15, 37, 697, DateTimeKind.Local).AddTicks(7999), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("833a6638-50ab-427c-a1e8-50c6a30a6e79"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$cJmnARkQ6BJ/7SMihN6K7OxKMmvqIW54rjqQj0EidvhtJocWLei36", false, new DateTime(2023, 2, 15, 21, 15, 43, 585, DateTimeKind.Local).AddTicks(2842), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("83d8a0a9-02a7-4987-8415-749efc43d5f0"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$ym.U7t/SDvppTaotaaGhVuFDHcJVhspyXwapepyJNZVAjz7aU2.Uy", false, new DateTime(2023, 2, 15, 21, 15, 37, 368, DateTimeKind.Local).AddTicks(1532), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("8dc3be76-ec04-472b-a531-3698999496e7"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$G102HP7LTJCw2SYlXlhjOuLqlSQjlb526hJOEW11atpmFJOxipZQ.", false, new DateTime(2023, 2, 15, 21, 15, 39, 341, DateTimeKind.Local).AddTicks(6595), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("90eafef8-71bf-484c-86b4-9ce0c815c19d"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$gDlSSA6tXXAUp9.tq0ntouotoBR/ddfZvmklLks9dxpI6MxLJerIe", false, new DateTime(2023, 2, 15, 21, 15, 42, 733, DateTimeKind.Local).AddTicks(9093), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("92175a2e-0915-4875-9d3c-1ba0d07a6ad0"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$3mMVPQfDKku4XNOTb8E0TOiuX9Mxl8q9uKf7GdU2VR6wv/swWO23q", false, new DateTime(2023, 2, 15, 21, 15, 43, 96, DateTimeKind.Local).AddTicks(3511), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("97a77be0-596f-4642-88e8-cc5574722b76"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$sxLOZrO7PmvMZrBU3WibZ.Nujo50oT2WkjO5sRa/P4MUPXgaPiXD6", false, new DateTime(2023, 2, 15, 21, 15, 39, 886, DateTimeKind.Local).AddTicks(6242), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("98567917-69e0-4bb4-87f2-cd0c8d237b28"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$73/OPtuQt6EnfFh2T2oXCO0CLYbVOot3c/K2dTwg8KZg8sAIq2Vaa", false, new DateTime(2023, 2, 15, 21, 15, 36, 188, DateTimeKind.Local).AddTicks(3381), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("9c166b29-6933-470a-a937-86b8916ec3dd"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$BuVxRXlvIvHWdJz9Nh5HGOHv3JOvXs8AmahFKBGbAw2ctwa5k3nda", false, new DateTime(2023, 2, 15, 21, 15, 42, 147, DateTimeKind.Local).AddTicks(7417), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("a4d8f3d1-ccff-496e-a6bc-c2512cb53ccc"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$BcGysfc6S44CxOYF5ikd8OkF3m12sqs9rTMFrZEBzCoyDasPDUh4y", false, new DateTime(2023, 2, 15, 21, 15, 39, 17, DateTimeKind.Local).AddTicks(5300), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("a5ba7e82-6f98-45d4-b662-4e63f056cf41"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$T89HrCfzUC0mQokLJH4xFeZETRe8lWDPKMdyzEWHt93UEqcb329xq", false, new DateTime(2023, 2, 15, 21, 15, 43, 839, DateTimeKind.Local).AddTicks(1779), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("a81eee8e-9b74-42a3-9ab5-c16ad410079b"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$21LW5DH7M6bz9GyD9okWi.TlKCn83hoCOoXDzZUWikNHAQK0Vy2P6", false, new DateTime(2023, 2, 15, 21, 15, 35, 941, DateTimeKind.Local).AddTicks(240), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("b1ac8b67-fbc8-4910-9627-a53dfd1e2f39"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$gz4oyjyOBhURhawxi0WeHOZBBtfDIgZigq/yuYlouTCGaNcGarZPi", false, new DateTime(2023, 2, 15, 21, 15, 38, 862, DateTimeKind.Local).AddTicks(1455), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("b3910ec9-41ac-406a-b459-1bcf7de80788"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$Ho.83TinRVQbDRhrir42h.3ZcaiC4qmyXY2YoIDEZ72TklRjcR0Xe", false, new DateTime(2023, 2, 15, 21, 15, 36, 806, DateTimeKind.Local).AddTicks(5596), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("b59640b8-8319-44f2-b7e6-4e9e3cd7e769"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$lddTdZqnEs2N8kD9lvmCiOO..123NhLg/6r.A6Lv1Pb/Bb.VZPnjq", false, new DateTime(2023, 2, 15, 21, 15, 39, 969, DateTimeKind.Local).AddTicks(7422), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("b6131fc1-5a69-4bcf-8a8e-48e43c70deaf"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$SvsrX4QnykUGWlQH1xi7XO9QHTtfRyyYbQD0LnuusUDV1fuW7o40S", false, new DateTime(2023, 2, 15, 21, 15, 41, 184, DateTimeKind.Local).AddTicks(843), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("bc4d9594-9802-4d11-8409-24756f9f6127"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$PfhscLYZ.OdPVkFvVLIhdOYjftg77u3d6nkSgt9UHuicBavjqu2FO", false, new DateTime(2023, 2, 15, 21, 15, 43, 918, DateTimeKind.Local).AddTicks(7704), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("c0e1e585-51b3-406e-b3e3-06c4f7c19c83"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$Ab5OUJyKPpyrn90C759nBel5QaXF8znMrdgZH9Rz/3iDPcBkedahW", false, new DateTime(2023, 2, 15, 21, 15, 43, 504, DateTimeKind.Local).AddTicks(5192), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("c1cb62b8-4f18-4e0c-a6de-3b44f0b3db23"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$xw9oInEr/kGEVlXj6ipCceO23dCY3T1r/2xH03L/jA/p4IhZhPwn6", false, new DateTime(2023, 2, 15, 21, 15, 36, 99, DateTimeKind.Local).AddTicks(9117), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("c645a735-4798-4e13-bdc2-483410881c43"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$qza94pJmJ45VM6exvT9DH.BFYTLpOOJmb/LrIyrYfmKcGkzGqeoe.", false, new DateTime(2023, 2, 15, 21, 15, 43, 756, DateTimeKind.Local).AddTicks(8462), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("c6d0fa87-1dec-4403-8ac1-ca97806bc49e"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$AdOfXuMXY4iqQwMYfGIa3eyfVHF2PEXtTou7Ev6oTTkXrd/upZByu", false, new DateTime(2023, 2, 15, 21, 15, 40, 818, DateTimeKind.Local).AddTicks(4548), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("c9eb36ea-dc98-4767-9a09-d47b9eebff0b"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$9VLWnAXy1aftAGFfRet7qOT6IElPeVjNNDaVzrcT1f.7dXKdcTES6", false, new DateTime(2023, 2, 15, 21, 15, 44, 500, DateTimeKind.Local).AddTicks(3496), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("ccef67ca-4b01-4ee2-bdaf-ece3e1ea23d0"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$4TUXcSCgJg8i0hqZPfOK.u9m/5ZLBWyfbZ5W1GWBgd7ChCeO9HO5.", false, new DateTime(2023, 2, 15, 21, 15, 41, 864, DateTimeKind.Local).AddTicks(5827), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("cf00843e-e3a3-4168-ac72-2ca922523626"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$RQ8RibtXly76CCj5nQAyoOhaBSOP94h8037G.rmAbFzCfbpWFJs5.", false, new DateTime(2023, 2, 15, 21, 15, 42, 817, DateTimeKind.Local).AddTicks(8060), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("d0fca2a9-c251-432a-bee8-be46839a4a58"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$Woz35p1QX2biv1qrNQB1QuxG5VATvTtAJTBxmO/zY73TvRWgeHFxi", false, new DateTime(2023, 2, 15, 21, 15, 39, 264, DateTimeKind.Local).AddTicks(6215), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("d12fcad1-9eef-4569-af09-65305fb73477"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$2WAih7GmUILBawgIDG.UFeY/.kh27KpbO2GoTSW4J60OnSRqhcSiy", false, new DateTime(2023, 2, 15, 21, 15, 37, 457, DateTimeKind.Local).AddTicks(9049), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("d1e656d2-038e-4fa9-9cde-46f57400f101"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$6918Co1ALkcc.ooauwYC0OVAukzviaC2x6bEdH8zv/kkQ.T.58VkW", false, new DateTime(2023, 2, 15, 21, 15, 36, 408, DateTimeKind.Local).AddTicks(758), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("d3e66c67-1195-459f-aca4-35ffe53167ba"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$fXDh.NnDdFpfZTTkyrFgcOZw1OvVWbON/zhme3nPq6OemwvMi0UlG", false, new DateTime(2023, 2, 15, 21, 15, 45, 100, DateTimeKind.Local).AddTicks(9492), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("d8ec356e-f2c7-4aff-a395-c0e39e6f8bfb"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$O/8DKJVOFwGtD4K3iNnHw.5wFE4DgekkkJkASFp/SV589qsOXYlpe", false, new DateTime(2023, 2, 15, 21, 15, 37, 801, DateTimeKind.Local).AddTicks(3330), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("db9652e7-ada7-479e-b413-16fd406faddb"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$nQXJRqIutmnd8NZLz6mCM.Ex57hF6DALD9E0M9MDImsTE4UjpR8o.", false, new DateTime(2023, 2, 15, 21, 15, 42, 240, DateTimeKind.Local).AddTicks(7698), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("deecd186-b905-4c91-a356-577922859e5b"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$oS.RGa1Qjtvy4thBYOTPX.PWP0.AU0HoZqasJUwqLW7nPxmD/jYbm", false, new DateTime(2023, 2, 15, 21, 15, 39, 633, DateTimeKind.Local).AddTicks(6383), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("e12ef976-5a5d-4fa7-a449-5522ee4088e2"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$JldQlw0jY0xr8y3XuPh9Oe9DBFr/jxk2nR6ZOjDKesaRLkn7P/e7u", false, new DateTime(2023, 2, 15, 21, 15, 41, 113, DateTimeKind.Local).AddTicks(4476), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("e1fe15c6-cdb7-43be-85ee-dc177347a34a"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$j8ZlYZa3cdcZnImSNnLjquHm49X0VNznwflQQzjXE6v2ere0qnzVO", false, new DateTime(2023, 2, 15, 21, 15, 40, 339, DateTimeKind.Local).AddTicks(4064), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("e3f12146-52b4-43c7-a046-43f3905b5fa2"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$3hgep9HReC3aozEeYXmVsO16lFjgg.c.YoR6R7iBpMqOYO9fzGvky", false, new DateTime(2023, 2, 15, 21, 15, 45, 188, DateTimeKind.Local).AddTicks(3871), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("e889d93d-a853-424f-8a07-328431336486"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$j6UAYMPLwWWeDJTg/E/DL.Q7qxq9ptKx.dZ4vHpGY8MVEyE/T13pK", false, new DateTime(2023, 2, 15, 21, 15, 38, 300, DateTimeKind.Local).AddTicks(6408), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("eac5a2d8-6ecf-414b-8ad2-e326609bbdb6"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$NjreXGaCY6ploydu.S1dLejdu7i/cPDwFbHimMbPgrxJzjEh3Nwia", false, new DateTime(2023, 2, 15, 21, 15, 39, 99, DateTimeKind.Local).AddTicks(8672), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("eb6a0553-37fd-4ebf-a084-cff5edbe4099"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$eTGT2BZYTgjBrKu4r4hCzO3O9uB6UKriIvP6nAFdkqoAKkeeormpa", false, new DateTime(2023, 2, 15, 21, 15, 37, 175, DateTimeKind.Local).AddTicks(1123), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("ebf297e3-df49-428c-92d4-2712066df317"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$w2A/847bKCWhcNLvxmve5ODXlSUuxq75SDCk9anNEbmYjrDRdIM5W", false, new DateTime(2023, 2, 15, 21, 15, 41, 584, DateTimeKind.Local).AddTicks(3490), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("f252544b-bacc-4aba-b944-1bddce02dbca"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$BTd9H0dHLAQ5tojOizVFzOIxuiV8BwVvGjfUfe131bdD4SjqFO3dy", false, new DateTime(2023, 2, 15, 21, 15, 42, 41, DateTimeKind.Local).AddTicks(8827), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("f3050092-c4b6-4131-8279-3f6b4373fecf"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$DnMeNI3xYJrEuWbfwGEgLecI7maB8hXvSiH5kyI56PHBL/3K4W8xG", false, new DateTime(2023, 2, 15, 21, 15, 41, 498, DateTimeKind.Local).AddTicks(8984), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("f30830bc-ddb5-418f-9177-8cf03be5b1b4"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$9DS.v2YVJ1IEm0CBRdvtgeKGD1V.mtUohFW7Cysh0sKg1pCCIpTf6", false, new DateTime(2023, 2, 15, 21, 15, 40, 197, DateTimeKind.Local).AddTicks(8142), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("f43ec52a-d735-4b17-9f00-c8bedffb7fe1"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$VF9F0yGVcJGNtKRgc/hHxuUduM7G2cQxt5bp176Bx97/.NHzdOVAK", false, new DateTime(2023, 2, 15, 21, 15, 44, 592, DateTimeKind.Local).AddTicks(5738), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("f59e637a-e1b7-4f26-8bf1-e73f6dd88eb6"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$zZwTzGMepqTx9rTfqFawheq/wxO/LN3jwpEKAPEM89b/KSnOdNZze", false, new DateTime(2023, 2, 15, 21, 15, 40, 577, DateTimeKind.Local).AddTicks(4912), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("f7d76f01-2a0f-4609-97fc-42c220d4cc05"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$5EpybXKJNxgHGRH3waDe7O1cW2p/pTsDpJaGKMjSbk4wgYeGAawWW", false, new DateTime(2023, 2, 15, 21, 15, 36, 506, DateTimeKind.Local).AddTicks(17), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("ff33f64b-dab7-4841-9d0c-252ee04fde77"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$NumWMGwuuYW2JBnBsf.xMOfVEYTvR2RF./Y11PMxcgJ6V/QlfNQUe", false, new DateTime(2023, 2, 15, 21, 15, 41, 401, DateTimeKind.Local).AddTicks(1842), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("ff888ee0-3d64-4833-9fca-f6d9764c5188"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$iSShLIBktrI8NeF2iF9yHe9Kt674lcTzfjtxBLn0EWZOeZLGkCyOm", false, new DateTime(2023, 2, 15, 21, 15, 38, 137, DateTimeKind.Local).AddTicks(5145), "Goddman", null, null, "00110582594", 2, "kgoddmano" }
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
