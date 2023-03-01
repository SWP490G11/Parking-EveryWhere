using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver173 : Migration
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
                    table.PrimaryKey("PK_TimeFrames", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TimeFrames_Parkings_ParkingsID",
                        column: x => x.ParkingsID,
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
                    { new Guid("0a4e0bd5-2bbc-436f-826c-32e7f8a5e4d6"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("768fd745-03cd-44df-bc00-9beec3147890"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("9d2f5060-4330-47ed-b8c0-0d61987f7eb9"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("a548719b-69f6-4fe3-add1-1a644b4cb05f"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("d0457187-dc97-4d36-b364-ad3b85ea279b"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("fe3327ea-2937-4b23-bb02-d8e0e4f96b71"), "Xe van con", null, null, "Minivan", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("6fe00b84-4ae5-4cb7-bfec-645847385872"), "Short time", new DateTime(2023, 3, 1, 20, 37, 47, 132, DateTimeKind.Local).AddTicks(9512), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73113af9-bf81-4e4d-92f9-f3fe9bd906f7"), "Half Year", new DateTime(2023, 3, 1, 20, 37, 47, 132, DateTimeKind.Local).AddTicks(9516), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79b4e925-a627-4969-a9b0-9dc7fe4dd9ef"), "1 Year", new DateTime(2023, 3, 1, 20, 37, 47, 132, DateTimeKind.Local).AddTicks(9518), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("03944709-6e50-4287-b13d-fe15d2a93191"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$fswq9QbtPW5qKemDa3S8kuV3uhkdIgVHf6Lwp/lYpQd0BjBaJVNkK", false, new DateTime(2023, 3, 1, 20, 37, 38, 63, DateTimeKind.Local).AddTicks(6867), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("0403c6ac-c260-497c-a7d9-61aa78846470"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$SpTiUDaZwB7rRIIkptj..uTqLh0qRzvUHsFfUxOxBhOrXGLB3MSqm", false, new DateTime(2023, 3, 1, 20, 37, 46, 112, DateTimeKind.Local).AddTicks(714), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("0430c883-c3d9-4487-b644-1be052ad32b9"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$DVri/pax.2/DnmmHTB194O92fhx38UefhaR2GucSRYcN1R.ijKHiK", false, new DateTime(2023, 3, 1, 20, 37, 41, 734, DateTimeKind.Local).AddTicks(9178), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("04a6cdce-a08b-4b32-aff0-f2d4c275d176"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$m0MAOJzwfyYPqEKmka9pRu6KLBo8LFsYlZ0dngC2ij./HP1BEtAOa", false, new DateTime(2023, 3, 1, 20, 37, 42, 110, DateTimeKind.Local).AddTicks(8594), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("052b0934-621d-40a1-a9a9-e99e7e966f79"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$9v/im1HptmcN53xSHs2KN.lXC2DUeReqEkx3VgakVo.lDevrY1GUm", false, new DateTime(2023, 3, 1, 20, 37, 39, 337, DateTimeKind.Local).AddTicks(5169), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("098b67a4-e78f-4337-a5f4-7e6c8bdb2dc0"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$0HwXezW15g4QI1wKyE4XguvZIzC7DUD.4NIaNvzZM1Afij96h9aAy", false, new DateTime(2023, 3, 1, 20, 37, 38, 571, DateTimeKind.Local).AddTicks(2642), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("0cbffe8e-7c89-4541-baf1-d2d0f45ac592"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$fUTcy2ATpUl2xsLdo.vWIOrZG5e9p9e6Fnqw9XHIGiH4HYsumA.Hi", false, new DateTime(2023, 3, 1, 20, 37, 42, 365, DateTimeKind.Local).AddTicks(5986), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("0dc68b5e-80dd-4f79-be36-030eab6abf28"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$V/j9/cvodDYeCy3sm.CNRefl6ViW7qkRKHxSWSJrcFEphHaxp/JSa", false, new DateTime(2023, 3, 1, 20, 37, 42, 908, DateTimeKind.Local).AddTicks(5105), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("0ed0ae0f-03cf-4bbb-b5e9-e0cfa4972895"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$4Hj2U0IZEIi29iucRF3tw.aGazDDxNTeufGtXM4O0Bq6hhyzw4fb2", false, new DateTime(2023, 3, 1, 20, 37, 44, 868, DateTimeKind.Local).AddTicks(2641), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("0f423b02-9fa5-441d-be79-2bfb05dd591a"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$i/E3tcRJX1DY2fel9L.RAuvi1Tp9Ge7JcJHNUViCtnPVRJUN9YqNm", false, new DateTime(2023, 3, 1, 20, 37, 45, 67, DateTimeKind.Local).AddTicks(7815), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("12752653-c002-496f-bdf4-450c5db56f11"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$q5DPGUmXB6r8NSKWZgMM6uMwczrJNwPXqiBsp4MfrgdwuvP6Lgtpm", false, new DateTime(2023, 3, 1, 20, 37, 43, 985, DateTimeKind.Local).AddTicks(3984), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("13be8d34-435f-4b0d-84db-defb6e424d05"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$RXeUTV6lpasZlBExIIw5BubxZirDESE.U/kx3n.0WotFdQhcn6tQG", false, new DateTime(2023, 3, 1, 20, 37, 40, 699, DateTimeKind.Local).AddTicks(9684), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("17a2315d-b733-45c6-89db-c65ac867e407"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$xMI5oQmnH7Ix5nr3SRdVDOXyZao2Rdaw9BNRWipQJqAhvBwiCWXsC", false, new DateTime(2023, 3, 1, 20, 37, 46, 941, DateTimeKind.Local).AddTicks(5822), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("188a7e24-23c4-40cf-bac5-9d77fda17105"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$85B1KQS6mIrxUAToaQORIOJsiz8ZCOElHBMESEcvBFxc7vtm5Mpte", false, new DateTime(2023, 3, 1, 20, 37, 41, 143, DateTimeKind.Local).AddTicks(7216), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("199626ec-9e22-4f22-9d8a-a5d52907811e"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$kh/K1vQp0j8koQmednYqAeMh/ZoulLy177gcarpOj2vOckfMUwr1S", false, new DateTime(2023, 3, 1, 20, 37, 41, 318, DateTimeKind.Local).AddTicks(98), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("1b81ea8f-bf4f-4389-872e-24ca2e922307"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$o3Mtj/eZ8ukS/tnk1aGlveDra0zBHTQ6we4/iyW44i6x38Jm4YKI2", false, new DateTime(2023, 3, 1, 20, 37, 37, 671, DateTimeKind.Local).AddTicks(3660), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("1d1a7c0f-de20-4853-ada4-9cfb8e77f1fd"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$BpJvOnY8O85iWFFw66omReEUnNiM1.PQ14ye6GBezdNaO4Y31uD2W", false, new DateTime(2023, 3, 1, 20, 37, 41, 232, DateTimeKind.Local).AddTicks(90), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("22b88474-4af5-4dbe-8d41-a79da95ea248"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$InC0VkJAH1Lmesi.uVgaTuYjigpm6xfcLbyEhd/aWO3Wl8benvyfi", false, new DateTime(2023, 3, 1, 20, 37, 42, 445, DateTimeKind.Local).AddTicks(190), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("248ae652-ec10-4130-8fc0-965c33564cc7"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$NL38GrNrvuHM9dEqYEzOGuAzRklY8PKfcqlvDF1m/EMqHh3fQbywO", false, new DateTime(2023, 3, 1, 20, 37, 44, 772, DateTimeKind.Local).AddTicks(8434), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("26945795-54d6-41c7-9468-a8ce8c96590d"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$8zCyjHqiW7XhSqcvteDHye5qY3IL.vP.KDU4Kld9IRZFDStSYYD6i", false, new DateTime(2023, 3, 1, 20, 37, 45, 265, DateTimeKind.Local).AddTicks(6003), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("27b37250-887c-4aba-a5b1-06677efc6b94"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$Epu.eZpOx5tKzXk811Ta1ewJxIX.0XDrWAj5EX1LjUdQROzRvtHuq", false, new DateTime(2023, 3, 1, 20, 37, 43, 210, DateTimeKind.Local).AddTicks(355), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("27bc423d-e48e-4529-a9c8-f8b6ac99bd50"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$GhMDzs76PDErntssGZkKD.CkjUTqT66I29BUGzSDLb5s81hmNlPrO", false, new DateTime(2023, 3, 1, 20, 37, 40, 84, DateTimeKind.Local).AddTicks(4396), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("2adbaba8-a056-4c9c-9e1c-7c900208caed"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$eFF13Yr58qX8Gnr28AfZY.UM4D9tcvRsEt/DMBclR5p.5f6niAstq", false, new DateTime(2023, 3, 1, 20, 37, 46, 503, DateTimeKind.Local).AddTicks(9927), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("2ae4f23b-9901-439e-a78b-3d4dbc2dbeda"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$FqNpDgd07AmtnaMaT6y1M.1x74QC2g0MZcxI5aPAke7vxU4tTtQuy", false, new DateTime(2023, 3, 1, 20, 37, 43, 293, DateTimeKind.Local).AddTicks(7053), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("32668061-3b90-416b-823c-5c00bc66e34d"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$eftTJ2MAcNThKz5gpotS6OVUnvVv5ZoPLnXGArNpGH7eQSrTJaNt.", false, new DateTime(2023, 3, 1, 20, 37, 38, 661, DateTimeKind.Local).AddTicks(7052), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("339b66b3-cdc5-400a-8687-d3bd35ccf3cf"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$WwfZOannbD57VrkzlktOhuPt1WMbUbo0qwQjzkHlhApMx07.RaLDu", false, new DateTime(2023, 3, 1, 20, 37, 38, 950, DateTimeKind.Local).AddTicks(3697), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("339e564d-3cde-4df2-84bf-bad9aaca2893"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$9BqjtCC4syDNmHM0x/gkVeb2EgJFW4rHS3oE7GQh0mCSG4UIZnj3C", false, new DateTime(2023, 3, 1, 20, 37, 42, 524, DateTimeKind.Local).AddTicks(5859), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("3604289d-6e21-4964-a559-e1655763e065"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$W4l980AHDkcFJJ4Z0nSeqeFCgoFGLyxEm2TqcKksh8H.T.pOqQ2NC", false, new DateTime(2023, 3, 1, 20, 37, 41, 830, DateTimeKind.Local).AddTicks(7073), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("3693e3ed-5d35-4719-96ac-8b661d68f49c"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$.mJrFuxJ3.xCnBpXPUhtqOhzfVLP.XJnmJ.v3T7cCw/p0uMbTVni2", false, new DateTime(2023, 3, 1, 20, 37, 37, 66, DateTimeKind.Local).AddTicks(1124), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("37260b6f-6970-4f7d-89b4-4e1629b93de8"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$DiIIlmHSMpxVa0BoKLA2su0eAnfByEdV.Lq6iRytUlyxAoi1ZrPBq", false, new DateTime(2023, 3, 1, 20, 37, 43, 608, DateTimeKind.Local).AddTicks(5147), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("38cad204-4cf0-4d17-9806-4d1645a9f53f"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$H5pFX.gBqZ7pcAo93nJzB./1pv8PNM98DXLo22thuVOTF7N89SQXG", false, new DateTime(2023, 3, 1, 20, 37, 45, 171, DateTimeKind.Local).AddTicks(2167), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("398dcf39-0f49-4ae9-b7df-be1bb63ac353"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$kDptAHknwf9igFrbBLwiyOdKS9vD7UbjvQA.MQC9w5r08Qcn3WQZG", false, new DateTime(2023, 3, 1, 20, 37, 46, 602, DateTimeKind.Local).AddTicks(5408), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("3b5f8090-77bd-4a2a-8258-96cd005b7bc8"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$Ij06nQVdMNitAuuy.VndtumXbfL09K8mRN1afMKYmKuSTJNgbr.y.", false, new DateTime(2023, 3, 1, 20, 37, 44, 960, DateTimeKind.Local).AddTicks(3801), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("3b9bb181-a132-4b3c-89f1-e423ff5f7346"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$U8q4Xs3nFSkCp8UELS1TTuXpCwaqskFlsnPCyfhEJA.8EHtKS6pUa", false, new DateTime(2023, 3, 1, 20, 37, 41, 922, DateTimeKind.Local).AddTicks(3826), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("3bd81460-1c70-4776-8268-c3ef7cc5dce8"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$QGP2UUNjU8UsZ.0WojeK3uYS2fx9Fq1Hq4NmXrSiX4im9ly/HlnIK", false, new DateTime(2023, 3, 1, 20, 37, 45, 933, DateTimeKind.Local).AddTicks(43), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("44bb5b58-d779-407a-9d98-d1585e9f2073"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$JRo8Pn5FxhM5OxYIx6NuG.biM3aeN7Wg9gnAGZrw3eR6UZqZixrCO", false, new DateTime(2023, 3, 1, 20, 37, 40, 610, DateTimeKind.Local).AddTicks(8038), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("4500d310-4352-4900-9e16-1e8fe188a31e"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$qZHcxd5/jlr8xbkyUBq1ledg7.xBrFxeZF/HdlD87A3O6avU.E9km", false, new DateTime(2023, 3, 1, 20, 37, 46, 21, DateTimeKind.Local).AddTicks(2794), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("4516469a-938e-4b34-963b-140732bd3354"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$OVo8NoDrxeiZW.L35HMr/uj.EPmj.P2eC99g513/V4JT/qm9tPk92", false, new DateTime(2023, 3, 1, 20, 37, 41, 569, DateTimeKind.Local).AddTicks(8152), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("47e71e2e-93a4-427e-8f66-007fe1936693"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$xjbsZDtbh89OjdBPgFLBiOpnhG1d3MtHoCvbcEWU5KtEMwTrpokHa", false, new DateTime(2023, 3, 1, 20, 37, 41, 488, DateTimeKind.Local).AddTicks(389), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("4828ff1d-451b-450a-bfb9-773f6a2f5926"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$E5LrUAnmm/vSSieoWalNZO3Fhle4pWqBLbbmkbQich4Ords38k8MC", false, new DateTime(2023, 3, 1, 20, 37, 38, 480, DateTimeKind.Local).AddTicks(5280), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("48b23ed0-4e33-4922-96c1-570b72e9885c"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$eB/I0aSiJ/eNyYYUSxutMO5.U.yNCcGKbHR6I.aEICg4jW9ZBGHlu", false, new DateTime(2023, 3, 1, 20, 37, 44, 675, DateTimeKind.Local).AddTicks(8315), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("4ae8adf9-c446-47ee-b91b-704d1d6f5904"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$3SZSiRcJJl.m7S1XWQU3uuhFo7WnVUWdn27sO412Tit2rNyJyI2BS", false, new DateTime(2023, 3, 1, 20, 37, 38, 147, DateTimeKind.Local).AddTicks(3256), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("4ba7f53a-929a-4aaf-98f3-bcd2090c002f"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$Y7sDHxVK54ECZvdJ7VEynehdtJD2SzWbkbB1AAMIwTUwQtlDL5Rse", false, new DateTime(2023, 3, 1, 20, 37, 46, 777, DateTimeKind.Local).AddTicks(3763), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("4bdc26ee-77f4-40e8-9f45-b1db0d6d6070"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$x8p42.028PXFXOfhhuNMaukCVBi43kanCGrSaXCLN6dZMBBB3UdW.", false, new DateTime(2023, 3, 1, 20, 37, 37, 175, DateTimeKind.Local).AddTicks(8431), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("4ff8a65a-0b6d-4a80-abb9-11832211c2c5"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$ElXysEuGs3ZZfosVYLCzQOgH/siRF/ssclW0ACLYzl3Vq86Q6rzlS", false, new DateTime(2023, 3, 1, 20, 37, 39, 912, DateTimeKind.Local).AddTicks(5378), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("506a066f-3581-4977-8355-1761c404ea9d"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$l7KqDirsaqadx3Hx4HkHBOdJTbkwyX2e8xmctMBt3fU4jfywfXGjm", false, new DateTime(2023, 3, 1, 20, 37, 47, 22, DateTimeKind.Local).AddTicks(3596), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("5353c9eb-7aa4-4729-bda0-5b4d6bab8984"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$tldz2X1oWwhsbLh5ADtnh.wnZCNBEUxSDgYUmFOywnGHLN758PiqW", false, new DateTime(2023, 3, 1, 20, 37, 37, 279, DateTimeKind.Local).AddTicks(7937), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("53a5654b-2811-4c51-b1d6-6718f69b70f5"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$iB2rrduQXq4Tf7SVDhaI1.s.m3LKWop16G1ZZrQiAetTQjKt4O.ta", false, new DateTime(2023, 3, 1, 20, 37, 41, 53, DateTimeKind.Local).AddTicks(8798), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("58f62372-b5c6-4681-a78a-5f9a604dff5d"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$nnSGlManOs4whrT.wMhQK.Mcc4GfZ7BK17d2TEBKvKWUnIYch.h2y", false, new DateTime(2023, 3, 1, 20, 37, 44, 270, DateTimeKind.Local).AddTicks(5100), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("59ef5813-2875-4e1a-a1aa-a4a1ff15cc71"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$Z3qgTWwhAtwvMFaOif/NR.c1z3JKwWpDH1W15BTm5V8R/xAYAjzH6", false, new DateTime(2023, 3, 1, 20, 37, 37, 977, DateTimeKind.Local).AddTicks(3494), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("5d4abb2d-bac6-4811-8a10-1749790526e2"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$OnIToo61e81vKBuyZG7PFOCRZ4zKFuy8g5eTizCNzAruYfvolBTde", false, new DateTime(2023, 3, 1, 20, 37, 38, 308, DateTimeKind.Local).AddTicks(7801), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("602019d9-3ba6-451f-8b6e-d104abbd1e46"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$L0VeONVBzvsqhK8y7MBxcOrIJRnUv5HPujy.5uhhyElyN2.8fdfr2", false, new DateTime(2023, 3, 1, 20, 37, 45, 841, DateTimeKind.Local).AddTicks(6216), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("60719c29-d35c-417a-a410-be358d8ded1a"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$EiwJjV/bI/NRUVijTPyj2.sKrmJHiNusCsQb0YdwoFqWmpqnsg5IC", false, new DateTime(2023, 3, 1, 20, 37, 43, 686, DateTimeKind.Local).AddTicks(3850), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("60d58982-4c9a-43ca-8aab-e6b47e0f0262"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$gcc.0mf6jWsK8qOJ0DB9H.NDPenYgA4Ghy0ys2ugrECNFXUv1y8MG", false, new DateTime(2023, 3, 1, 20, 37, 43, 836, DateTimeKind.Local).AddTicks(5003), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("6179ad96-e08d-44fa-a0a4-52a0154caae4"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$Q6FHH/oUfGF86xWkd3x.Z./wn.ZXwOpgRjmnSUFbEfC4bPB5PZsG2", false, new DateTime(2023, 3, 1, 20, 37, 44, 359, DateTimeKind.Local).AddTicks(2691), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("61c9aca9-7c73-4db2-925f-7fb84d9d33d7"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$hZQy8Rr1zT5g4xY2rvW.Q.M3nYUZGqqJltdRho/tRxeJKg6W3syFa", false, new DateTime(2023, 3, 1, 20, 37, 38, 753, DateTimeKind.Local).AddTicks(4608), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("63e8a1d7-8c6d-4733-8b0d-88c3115b67da"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$gg9d4rL7XKKJXpV9ayjMseANXftkBBUMqVJZIgO0ubqPQnluBuugW", false, new DateTime(2023, 3, 1, 20, 37, 45, 441, DateTimeKind.Local).AddTicks(3831), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("64cfc5ae-68c5-4082-a382-751a205043ad"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$OiMeUe60SETtJoZWAlG8AOw8Bpwwu0gfnAMp567iMLjUgYygXBZPq", false, new DateTime(2023, 3, 1, 20, 37, 39, 726, DateTimeKind.Local).AddTicks(1640), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("65a476e6-c630-4a6c-a2ff-37cd46e1ed64"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$9sY67Blw40lvKXgQZ1Kv5eheKCh/GDNyUO21/j3W9QVBbPVP9UJ/G", false, new DateTime(2023, 3, 1, 20, 37, 39, 999, DateTimeKind.Local).AddTicks(6814), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("6bf224c4-6914-4c36-8aeb-03741e994b0a"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$EQuX7l3Bhsrf6F3CVIsYDuldmRQKafMHc2pOq2adwXd.Olo5GwQ9G", false, new DateTime(2023, 3, 1, 20, 37, 44, 169, DateTimeKind.Local).AddTicks(4319), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("6c95ca94-f93f-41b5-b449-d8235f46166a"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$iFRBuTYtK72SW0a2qIuPROFIQEWn4aMD2hll4Uqp9hjVUq6j7c/PG", false, new DateTime(2023, 3, 1, 20, 37, 44, 60, DateTimeKind.Local).AddTicks(9918), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("6ffcb771-a3e0-4cf7-96e7-ba559823ccd1"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$tM4BWsq6UYBvpetPGcLWmeD0G9XiQ5wkmSypJixjCab18K/ieWlL6", false, new DateTime(2023, 3, 1, 20, 37, 42, 284, DateTimeKind.Local).AddTicks(3093), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("73612610-e855-42d2-85be-7cfcc195d6c9"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$c1iYJjJ1bnEV2Kb.HULl/OlQ.ZkvLokDDJSEMUIEgt15vTQkUBifC", false, new DateTime(2023, 3, 1, 20, 37, 39, 527, DateTimeKind.Local).AddTicks(3937), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("74b60640-af16-4ad7-9588-8d2a38e2db54"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$NFd/Xxj5XWlT/n5w8en1Uu69OYHo.2uKw6Ka6gyoGPT4oGcvu4arO", false, new DateTime(2023, 3, 1, 20, 37, 37, 787, DateTimeKind.Local).AddTicks(3904), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("74f71cb0-9435-4538-9c9a-cd3d281e9304"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$fwvP9bxXzAI0Lcft52bphea3wpyz42VWPZp2P07dQNbFpZg1Mo2VK", false, new DateTime(2023, 3, 1, 20, 37, 46, 317, DateTimeKind.Local).AddTicks(7164), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("79043346-fa53-4bc7-8e58-32fd6d0bc2e5"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$I1N3xUn.aAKqSY9aYckCPO9w.Tk0l2OVC34bO25hJ/dszVIkpRPyO", false, new DateTime(2023, 3, 1, 20, 37, 42, 602, DateTimeKind.Local).AddTicks(6622), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("7a344525-0b99-426f-9cdf-7fa8dfd800b6"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$ix7fGc4Z7AXt04YQsw1SGOArpfhjFv7kEZ9.YJLxquex.Z8pxagiO", false, new DateTime(2023, 3, 1, 20, 37, 40, 439, DateTimeKind.Local).AddTicks(6337), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("7cd6c8b7-6e62-48e7-9830-a38645b664f7"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$.Ab4YuXudE77zWa1dORc8uJtRDFSucrB1MfWGXDpiJL3vE8xD9T0a", false, new DateTime(2023, 3, 1, 20, 37, 45, 744, DateTimeKind.Local).AddTicks(7315), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("7d312e33-3fff-4a9f-9636-27e590092d84"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$YNTPYPYMJHuyH1NnTiTU/.vJdCNp3kqx5Dv1Vj6YvDAGwqFzOTf5C", false, new DateTime(2023, 3, 1, 20, 37, 43, 760, DateTimeKind.Local).AddTicks(5422), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("80128c90-9124-4291-b68e-cdfe9eba8d76"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$O9H948lzD/R6Vw.0j/v5sehoxfxUddX2FPHHNW2mbXlkBFfsjCUGS", false, new DateTime(2023, 3, 1, 20, 37, 46, 860, DateTimeKind.Local).AddTicks(643), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("835e2501-de2c-45f3-94ed-809fdd5058b8"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$/TMm5yyDunzoRsBK0/8MROiUOIryqWpUw/xy0FJtgnbE.uXwturDm", false, new DateTime(2023, 3, 1, 20, 37, 37, 568, DateTimeKind.Local).AddTicks(1096), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("8659427b-f794-43a9-9bf3-e10abee1ab14"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$XbC1WjsVWb9MSDdpba3XJeccz7QVsAcIveDbt99jLhMTAOWa27urO", false, new DateTime(2023, 3, 1, 20, 37, 38, 854, DateTimeKind.Local).AddTicks(2704), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("8a2829aa-e1f6-4441-a498-3944623ad85d"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$04VgMnUi/wQyNFYjt8tFo.QgqAGStMSZ7s/RXEiYLX9wrh4OkDkD2", false, new DateTime(2023, 3, 1, 20, 37, 39, 622, DateTimeKind.Local).AddTicks(9512), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("8c78ef6c-14e0-4fee-b379-a145ffea4bf5"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$Xs0/26MLU5FQtbkFkC1F/.32pZdsMFE6FG8it5h1zf4p8W9C2FIY6", false, new DateTime(2023, 3, 1, 20, 37, 45, 547, DateTimeKind.Local).AddTicks(1789), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("923d24af-8921-4933-a9cd-acb864066b54"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$t.7Os4UTTjQltfCvy.PKdOSIEvFkki00676B6/tKZDQwGIHKrWVzW", false, new DateTime(2023, 3, 1, 20, 37, 40, 524, DateTimeKind.Local).AddTicks(5331), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("92fc0793-f0d3-4cdb-bd1c-c4e98efce857"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$gyqKgLHNSyRpQYhLeyGFu.pZb8zZUumJFAEUgzNjFE7.9CSmMEKBW", false, new DateTime(2023, 3, 1, 20, 37, 40, 345, DateTimeKind.Local).AddTicks(4579), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("936dee0e-a96f-490b-82ef-c1e142c8093d"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$VJY6cbBo7lVLPf69y1r60.xuX0Uz8RAch457TeNmi0bEHRMkXGaOG", false, new DateTime(2023, 3, 1, 20, 37, 37, 473, DateTimeKind.Local).AddTicks(6282), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("93d19c2d-0dcf-439d-b284-3c293146b923"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$KW016c7axvkDxuzkUpb3mOTMDB8jMQs7JYrnvofPdxMWi.wFlS0Na", false, new DateTime(2023, 3, 1, 20, 37, 40, 882, DateTimeKind.Local).AddTicks(9660), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("94d71877-32ce-4a48-b262-c63499f62aa9"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$jLJG9j3iFc0VNKwycabM6OuWo4bFD8ZpFitcl55PbTnKwqsYmypim", false, new DateTime(2023, 3, 1, 20, 37, 42, 18, DateTimeKind.Local).AddTicks(5608), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("94eb52f0-6129-4c76-878f-3c98c3bda66f"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$eiZrmsDIzyO2ms0sPFBPU.Z5FDnFgCsJ9a3HJGznTFXSivOyLILLy", false, new DateTime(2023, 3, 1, 20, 37, 44, 473, DateTimeKind.Local).AddTicks(854), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("96aac68e-ca07-4591-b4df-9a725ef807c5"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$yGPpO/PLc3qTFQTp4YJ3ueSeVYxfEPo06I.Rd4cSrdX2gXeZqbU8S", false, new DateTime(2023, 3, 1, 20, 37, 39, 45, DateTimeKind.Local).AddTicks(7728), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("99bd185b-c3eb-4de1-a31c-d9d580ea79b3"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$5McgcXqwdDyLpRzc6pJjTugwaPI3Vqnib5HF3gscIc1dsk5Tw/wou", false, new DateTime(2023, 3, 1, 20, 37, 43, 374, DateTimeKind.Local).AddTicks(6150), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("9c83cd8c-5ab5-4a8d-a3a6-f6afae29a0f6"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$iLKQAO7HYLHCvK2bkYZdQ.8TP5Vnwck2S4b7wsXhLXSkR8PKfxG7.", false, new DateTime(2023, 3, 1, 20, 37, 39, 239, DateTimeKind.Local).AddTicks(7229), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("a04d90f0-3ceb-467e-bd7f-829f83055422"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$lwXlTsO5tnshnX7VQbmejeyXcZP2E4R14JJblkrk8va3w8x3Kr69i", false, new DateTime(2023, 3, 1, 20, 37, 40, 966, DateTimeKind.Local).AddTicks(3170), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("a592c3bf-85ca-4abc-a99e-d9f558d32c49"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$VNtlqPCgq6CMSVpZ8gH4u.fKWInN290pytm1BdAIBZuUV4uZka7v2", false, new DateTime(2023, 3, 1, 20, 37, 45, 355, DateTimeKind.Local).AddTicks(4741), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("b259a72d-2b11-4195-8ff9-cdd1d533c6bb"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$pNrsCM/mj1wp/gnWhZdLBO0FAKMBYdftApY.xIpWNz8ur07UWFiI6", false, new DateTime(2023, 3, 1, 20, 37, 38, 228, DateTimeKind.Local).AddTicks(1150), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("b3d41472-a953-43f1-ba4e-5d075c143197"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$CHoPwxuX1o.VUaaxOYjHLOohIoKmznI.mkenHPs5hWREhGMyChoiC", false, new DateTime(2023, 3, 1, 20, 37, 43, 453, DateTimeKind.Local).AddTicks(8619), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("b54ca494-ee02-446b-877e-3aa2a7b4ba59"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$FTDGLkePsYteBxQEHA2DaOh2A7PD/b32twONKgdsk5DjjrE12DYvq", false, new DateTime(2023, 3, 1, 20, 37, 43, 21, DateTimeKind.Local).AddTicks(1782), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("b70dec09-e4a4-4931-8b6e-bdbf5c171ef2"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$c2S.sq1bGNKrjQjrtWrXv.bDIVBz36iymHBMGq36DBYCao33Ults6", false, new DateTime(2023, 3, 1, 20, 37, 44, 582, DateTimeKind.Local).AddTicks(5731), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("b8dc9b1c-e78d-4527-8103-09491036e056"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$XQEWiYf6CaY2Fd2qkZMUpevwbNqvSU20vUU/KgCDi0K8BV/SvCd5K", false, new DateTime(2023, 3, 1, 20, 37, 45, 651, DateTimeKind.Local).AddTicks(6174), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("bb91d3a5-4685-4abf-8f36-25c7ef877e71"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$L77Vno2IGkSisKqLmppwxechegDxQ.eAuOsvVqonEqb9iQdFoMeZu", false, new DateTime(2023, 3, 1, 20, 37, 46, 207, DateTimeKind.Local).AddTicks(7876), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("c074ec84-46ba-4b96-ac68-3534308d003d"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$MAOyYRp8AWq8i7vLseRmxe9emezRQRRMV.PRHSdPLPg0YXzsh45gK", false, new DateTime(2023, 3, 1, 20, 37, 42, 756, DateTimeKind.Local).AddTicks(3917), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("c0821f4a-eb78-455e-83bc-d3901d51cee0"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$KtqaVPSKwILfeNHhhOLEvOooO1zzFpBvkcnz/zXwcJBLFDP.ryzFS", false, new DateTime(2023, 3, 1, 20, 37, 40, 250, DateTimeKind.Local).AddTicks(1361), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("c103760f-ccfc-4faf-a868-a9fb4be99ca8"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$qG2dtW/WXfC8kNkxcY8B7eYk5QYkRoZpZ1EZLt/sD7o/SgY8S55UO", false, new DateTime(2023, 3, 1, 20, 37, 40, 797, DateTimeKind.Local).AddTicks(1253), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("c7e4d232-e876-4133-93b0-b6517b1ac8d8"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$4YmP2nTMN/LTg4FgX7XA9unHlnh/8ZT5oRKumP2VXAo2Z3C5jvXAW", false, new DateTime(2023, 3, 1, 20, 37, 39, 820, DateTimeKind.Local).AddTicks(8215), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("cc8bd194-1f77-4964-a727-ecc3d2dff651"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$hCV5cJ2ljFyqcTCGvE3Iuej02Ks3J9shA4d/u9QUw610aukkdUsb6", false, new DateTime(2023, 3, 1, 20, 37, 38, 394, DateTimeKind.Local).AddTicks(3594), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("d03d2617-c532-463b-81b1-a748f82eae7c"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$HOfoxeB0CbJmpJxBNoaNjeS5zdmyvxC6Z04Bwte1.NRRhgO.aZioW", false, new DateTime(2023, 3, 1, 20, 37, 37, 887, DateTimeKind.Local).AddTicks(346), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("d6c5e024-443f-4ed8-ac3d-b9ca1701b901"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$AXfT48E7zpfrreg1dTCNjuQOG7mdg22Ax8ZPHvo6UIbTv1vyFlmhW", false, new DateTime(2023, 3, 1, 20, 37, 43, 122, DateTimeKind.Local).AddTicks(7030), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("d8253673-60d8-4cee-b7ad-952f8adb236e"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$QYvCuVAJVVOhTrUPaO73/OH8ngzi3/5UQG6Y1bu60RZ2KeDJeReoK", false, new DateTime(2023, 3, 1, 20, 37, 46, 412, DateTimeKind.Local).AddTicks(6763), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("d881a36d-dbb6-4c8c-9b66-a929c21c1370"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$ciIVBYUuvCsroUQ2U3gequyRLOjvKBrmRsl7fExiTxKqkODK9hzku", false, new DateTime(2023, 3, 1, 20, 37, 37, 378, DateTimeKind.Local).AddTicks(9144), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("da9e2838-75b7-43a7-9c4a-86ad69419ddb"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$vU4Swphl.INhU7m8W17hAe7ytNLYV0pppy0hfOA6Ew3tgLgh4wz66", false, new DateTime(2023, 3, 1, 20, 37, 47, 132, DateTimeKind.Local).AddTicks(8872), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("e269eafb-53a3-4644-a542-00412908e920"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$7pWQk2WTFPxXH/95vYMPeemT9RzF7SLD7Ee7r3o3arT0tIl55GjDq", false, new DateTime(2023, 3, 1, 20, 37, 41, 403, DateTimeKind.Local).AddTicks(1993), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("e551894d-08cf-46b3-9d6c-7f15a5eb819f"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$aPRIEd2JU5r9IBJnBcdL6O7GKulDDBmMmVMnCrb.n5pyTEFp28q6S", false, new DateTime(2023, 3, 1, 20, 37, 39, 430, DateTimeKind.Local).AddTicks(6781), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("ea919a49-a021-4bc1-97eb-5e2964ab70f3"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$2cOi13xDSNJpUx2Op23KDe.o2Rom5rmGpakoWIymq4y0XDqmzqH9C", false, new DateTime(2023, 3, 1, 20, 37, 42, 198, DateTimeKind.Local).AddTicks(8986), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("ec5a9abc-2c68-468d-853c-e707461292b1"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$vQdBYQRaX27rUFgF5cH0u.1xLX8SEW3Em3NFhldhvo3HI9gJiOgw.", false, new DateTime(2023, 3, 1, 20, 37, 43, 911, DateTimeKind.Local).AddTicks(1024), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("f2b5601b-4850-4a71-954c-9a1a1181f705"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$luGj5L.qt4jJ0ADvnsIlNu1PA0etrPnakVV8uUpw70WILZbuWsPwa", false, new DateTime(2023, 3, 1, 20, 37, 41, 649, DateTimeKind.Local).AddTicks(3504), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("f2d5db5f-39a8-44c9-800b-f32911bce9b4"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$iA7reAl00P4XAidWE.XPQOBZpZQvLXsiIJ6cS7dIpQLfweTxAu1G.", false, new DateTime(2023, 3, 1, 20, 37, 40, 168, DateTimeKind.Local).AddTicks(307), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("f514da66-59b8-4f88-8994-e11a01b500f3"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$pYfP62GaTzQINI.hJKLH4OLNRogNQplAVMUPZTp5gDOZZV6RDJ.NS", false, new DateTime(2023, 3, 1, 20, 37, 39, 134, DateTimeKind.Local).AddTicks(6560), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("f632088d-24e6-4995-92f6-6569bd6d97db"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$idzwVAg/1PI8dIsgNunRG.tjXlz85dq11rfFD2Yt7wQIgxJoBRdI.", false, new DateTime(2023, 3, 1, 20, 37, 43, 531, DateTimeKind.Local).AddTicks(683), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("f7e80d4a-70b4-4177-ab9c-997c07dfc2b9"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$1BF4WWEMdMO4M5.s4SwOAeGdBXPMOkC9kerdk9RM4GQI0kVtZBXXm", false, new DateTime(2023, 3, 1, 20, 37, 42, 831, DateTimeKind.Local).AddTicks(433), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("f80bd91e-065e-4970-94a0-b5f2b86682c2"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$neMofPtECcMaoj5Zsdem6.Wms7//FZTpBB4RoWjGstbm0Be5avknW", false, new DateTime(2023, 3, 1, 20, 37, 42, 679, DateTimeKind.Local).AddTicks(545), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("fb5ef06b-eae2-4a2b-b414-3b9a845245ad"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$7f/2oqcb1A/LR2jkzEtlDedmINVio7P5As1yBjpRy0JjGgqWxh7v2", false, new DateTime(2023, 3, 1, 20, 37, 46, 692, DateTimeKind.Local).AddTicks(4179), "Elgee", null, null, "0961523438", 2, "melgee2x" }
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
                name: "IX_TimeFrames_ParkingsID",
                table: "TimeFrames",
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
