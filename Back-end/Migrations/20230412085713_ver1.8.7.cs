using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver187 : Migration
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
                columns: new[] { "ID", "Discript", "LastModifyAt", "LastModifyByID", "Model", "Price" },
                values: new object[,]
                {
                    { new Guid("2d4082bb-f519-4916-943d-108818d42a96"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("3eb7a507-61fb-4f8f-913d-209b847ac971"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("65e4c384-58ea-4cbd-9bd6-bd67729f558f"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("c1eb9f89-6fc1-4b0c-9ac1-e9258c97907d"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("cf33dacc-1685-4d7e-b518-c81ecc19e151"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("dbc421cf-c444-47fb-9a95-c873df2a52a0"), "xe 5 chỗ", null, null, "SUV5", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("ac2789fb-d487-4ee2-968f-6bf9c8b17a4b"), "Half Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, "Medium", 70000.0 },
                    { new Guid("ddc33c3b-760e-4cd1-8ce7-c7f83493cdfd"), "Short time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, "Short", 40000.0 },
                    { new Guid("ed1028aa-b332-4876-a71f-474ec11eafe5"), "1 Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L, "Long", 130000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "ImageID", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "TransactionID", "UserName" },
                values: new object[,]
                {
                    { new Guid("04a239b0-c1d7-40da-8396-fea07be46f55"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$10OT4MpdYz29.T/klBbTZumeOHxh1OGjRaijMf63h818GxSSPcZaq", null, false, new DateTime(2023, 4, 12, 15, 57, 7, 449, DateTimeKind.Local).AddTicks(347), "Berks", null, null, "04613021719", 2, null, "fberks1l" },
                    { new Guid("097838a9-dee8-4bd4-b3ca-cf72998421f1"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$wcK7eB8Gi58z9E11lPOpMO60PyF6RqeRzV04SW6.ZRP1gaKuXqYii", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 880, DateTimeKind.Local).AddTicks(9526), "Glison", null, null, "06769810772", 1, null, "rglison27" },
                    { new Guid("0d2c65f4-1d55-4ff7-bd02-9691adcac7b3"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$3.3wjOykN2NwVvlvhbd4tOJhGaPzX2lPbrKHpX12LzJygdU4VRkNG", null, false, new DateTime(2023, 4, 12, 15, 57, 4, 40, DateTimeKind.Local).AddTicks(6139), "Harnott", null, null, "00039497181", 2, null, "mharnottu" },
                    { new Guid("0e9f6ece-3609-4ff8-8e35-9b1ab398c937"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$ti4cIxK./uDTI5qUtTl5tOvZpl1PxS7nOFIhInjbeaub8bw6fnVWu", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 856, DateTimeKind.Local).AddTicks(1872), "Struss", null, null, "06928824187", 2, null, "astruss31" },
                    { new Guid("10289408-62d3-4609-9dd4-c2023d87bc3e"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$QoR0L9JuJgacm5tTuchvyuWIbUWzkepAF8y8bas45Wb.J0clzFC2q", null, false, new DateTime(2023, 4, 12, 15, 57, 1, 834, DateTimeKind.Local).AddTicks(4849), " Ass min", null, null, "0966416708", -772000, null, "admin" },
                    { new Guid("13e97ecd-6ac5-4266-a893-d9d01121238c"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$PBsMOnCuM4GX1Ho6oio7cul04UWkniHiKTu7nQBXB/G70/H.nsFRq", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 382, DateTimeKind.Local).AddTicks(1927), "Bolliver", null, null, "0699230163", 2, null, "sbolliver2w" },
                    { new Guid("14ac11a4-ab0e-4f32-bf74-931039dbaa74"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$fWpjY2bfl.G29NscgcJwMO3WHae.Bj1pUQEjG3FeOA3A/BeqG8Cgm", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 212, DateTimeKind.Local).AddTicks(2278), "Howland", null, null, "00133370415", 1, null, "lhowland2k" },
                    { new Guid("15109aaf-dbc6-4704-bf5a-27f4edaf23b1"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$1cANkwMduA.RKXlAzio3p.5jg992.qsD14WO7sITrN6s8HsNxgjFm", null, false, new DateTime(2023, 4, 12, 15, 57, 4, 725, DateTimeKind.Local).AddTicks(1822), "Maestrini", null, null, "0312994030", 2, null, "fmaestriniz" },
                    { new Guid("15cb3e05-5330-4b54-878b-2f850ff394ac"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$.YI8IF/IJbjc2wAZL9JcNObtDiEMiskMtyGzTUYWBWfwH.5i2Z3hW", null, false, new DateTime(2023, 4, 12, 15, 57, 2, 179, DateTimeKind.Local).AddTicks(6449), "Tubbs", null, null, "0630308378", 2, null, "gtubbsg" },
                    { new Guid("18bfdb72-1473-4ec2-bf9d-f40ad44c5168"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$806i0ow7wp.KE6EEosXFTe7apLFRpN7y29emDTGV7Xrvu7lLFu69e", null, false, new DateTime(2023, 4, 12, 15, 57, 6, 315, DateTimeKind.Local).AddTicks(4699), "Middlehurst", null, null, "03494633510", 2, null, "dmiddlehurst1c" },
                    { new Guid("20241372-2724-4155-9d13-287d43e2f22f"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$IGAnZSIqK3SP/PnF4IPvUultnBX5l6jPt6n0AMxJeCAyN9I.viv/C", null, false, new DateTime(2023, 4, 12, 15, 57, 8, 487, DateTimeKind.Local).AddTicks(8650), "Scirman", null, null, "0195375651", 1, null, "ascirman1u" },
                    { new Guid("204a1b0c-194b-4d74-ab0d-0355282f6aff"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$6fRwP9cLZ8Hu69YTJDzd8Oy/JF8FhkQ1KoI1AGlusK5QkPWTvbkRm", null, false, new DateTime(2023, 4, 12, 15, 57, 1, 960, DateTimeKind.Local).AddTicks(3555), " Nguyen Van", null, null, "0966416708", 1, null, "customer" },
                    { new Guid("27a9af51-1caa-4302-9b38-2feb76a41e2b"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$H16NnFme51VY9MGPVBopPepDpPTwRo6xnpTCoQJE5miOynGasqQka", null, false, new DateTime(2023, 4, 12, 15, 57, 10, 475, DateTimeKind.Local).AddTicks(6293), "Faber", null, null, "08586159848", 2, null, "afaber2d" },
                    { new Guid("2964d4dd-ee3a-4779-98c7-fc03e4f3c247"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$k4dTQQlrRKQIBRoU3xSsF.fdDxEignhwCMpQfeh3Lk5PkRC7j1zMC", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 761, DateTimeKind.Local).AddTicks(3369), "Gerrish", null, null, "04944713025", 1, null, "rgerrish30" },
                    { new Guid("29c5d5e1-4422-4f3b-8626-6c132d98eeb8"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$RYI7locVj1NUSGdjq2j8ZOLRWT7DnjSBGF/.qLSm5hzzFuGHoWgRO", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 667, DateTimeKind.Local).AddTicks(3402), "Lannen", null, null, "04000508789", 1, null, "dlannen25" },
                    { new Guid("2d2600f6-aac0-450f-94d5-30afab7a540a"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$1RZ8Lf0arLJlDvwWvuYCZO6TqfFzJ6foS1WSFRQBmjALtj4OxIxcW", null, false, new DateTime(2023, 4, 12, 15, 57, 2, 868, DateTimeKind.Local).AddTicks(6943), "McCloy", null, null, "08418620623", 2, null, "tmccloyl" },
                    { new Guid("2d75a7e0-059e-4eb8-86cc-98f66808d95c"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$6Dr/dU6hYbi3QtFnnHwG8u7cfureek0UUOjgIqA0X7.pMw5kmbJhe", null, false, new DateTime(2023, 4, 12, 15, 57, 2, 586, DateTimeKind.Local).AddTicks(2149), "Powdrell", null, null, "0569083168", 1, null, "mpowdrellj" },
                    { new Guid("310b98f5-b43f-4d57-86ef-e8adccebd5c5"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$wCmS/DsobW2NXxD/0CldL.xXRuKT9rIGrNiAaAi74lyoGQ9f89IRy", null, false, new DateTime(2023, 4, 12, 15, 57, 10, 796, DateTimeKind.Local).AddTicks(3701), "Fitzhenry", null, null, "04780696921", 1, null, "afitzhenry2g" },
                    { new Guid("317d0478-9fc2-4e79-ad65-1ce1dfb36177"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$ernNXhjgqwP64ohD/Uv6cuFCEKu8QQ5jjq5rhSjZam/GGYyi0dN2a", null, false, new DateTime(2023, 4, 12, 15, 57, 1, 680, DateTimeKind.Local).AddTicks(2964), " Nguyen Van", null, null, "0966416708", -772000, null, "phucnv" },
                    { new Guid("336db27b-b492-48b2-9549-c112fb0b759b"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$VLw63UaX/aHFk57nStViu.TgJkqhTMaXy8usmZUY1DlC542GNdGZ6", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 309, DateTimeKind.Local).AddTicks(7636), "Gasperi", null, null, "03723162025", 2, null, "ogasperi2l" },
                    { new Guid("3410c487-bd87-43b2-90f4-0fd05aa5b05a"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$x4uFvWrJ4dftqc9HgrFnDeo2Y9KDhoKLUj4ogEVcF9d9Kmsn.Y0Aq", null, false, new DateTime(2023, 4, 12, 15, 57, 7, 312, DateTimeKind.Local).AddTicks(4544), "Droghan", null, null, "0910618733", 2, null, "kdroghan1k" },
                    { new Guid("34d403bc-9ecb-426b-876f-c8b1c071eb1c"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$5Df8.VFebDypFPmC7VRvdeYHx74enZ9za4ha5OV.Aw8vc1FLF21ry", null, false, new DateTime(2023, 4, 12, 15, 57, 10, 276, DateTimeKind.Local).AddTicks(2292), "Spaldin", null, null, "0596030481", 1, null, "mspaldin2b" },
                    { new Guid("359335b3-35d8-40cb-aaac-25d310e40883"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$sR.v4upUFA8oO4ar7VfIDOZUXMYKOXEwtgK7ctGuD6u/eh2Fg7sdm", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 574, DateTimeKind.Local).AddTicks(6768), "Abrahamsohn", null, null, "08144581503", 1, null, "babrahamsohn2y" },
                    { new Guid("369b2465-e1cc-410c-b149-fa5776134e65"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$GTINo83H9PTH5nFsuqpu3ujFBDu41mpnad4kXMhh5YGW1yYNyHjMi", null, false, new DateTime(2023, 4, 12, 15, 57, 3, 908, DateTimeKind.Local).AddTicks(2979), "Gostick", null, null, "05617299637", 1, null, "bgostickt" },
                    { new Guid("37773d5c-68ad-4c1b-aeac-27e4985f0570"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$.f4mMVsNL/5SRQG51i8fAOYlD0UQR995paqsnnbiMQ4vZFVYRDkp.", null, false, new DateTime(2023, 4, 12, 15, 57, 3, 417, DateTimeKind.Local).AddTicks(2895), "Dunsford", null, null, "00868235500", 1, null, "rdunsfordp" },
                    { new Guid("37fc6828-df12-4338-bafd-371fc67ea8f6"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$A0vvUVMO4XmmQadNGL3NWOTTHoSy14FjL2ZCnesvAl917YzKaZMaG", null, false, new DateTime(2023, 4, 12, 15, 57, 7, 48, DateTimeKind.Local).AddTicks(3373), "Mackieson", null, null, "07046670689", 2, null, "smackieson1i" },
                    { new Guid("39ba46d9-cb50-4f14-b75d-363124bf550e"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$4KEXtPOK0Ry8MTl6Y4PEluALo4QIwYwrF5odhZiPfb26s4EKzzeqe", null, false, new DateTime(2023, 4, 12, 15, 57, 10, 180, DateTimeKind.Local).AddTicks(1308), "Ainscow", null, null, "0878444767", 1, null, "fainscow2a" },
                    { new Guid("3b6599a8-35e0-48f7-af5f-7153b3e05085"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$eQ3W/OVfywoY.5FrTZ4bPeLjQuL1ZzeutwFf5x2rwQ0vZwnEmM5Fe", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 469, DateTimeKind.Local).AddTicks(8673), "Scheffel", null, null, "0355632555", 2, null, "hscheffel23" },
                    { new Guid("3d545f28-3b82-4b2e-92ba-d60dfa04f70b"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$mREZ4PTEGbDNGALEOSk4ae236xuIISOOtDhBKc6MH8HsqsINE9yc.", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 131, DateTimeKind.Local).AddTicks(9726), "Oliffe", null, null, "0002143579", 1, null, "koliffe20" },
                    { new Guid("3e9c3c46-d6f2-43db-ac04-6f4ea3526aa4"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$HPZ1.sjQRABEqN/l2LNkxOBkMQ8hvS8IfQ2wc0Xx1AyXHDTbCO7dy", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 88, DateTimeKind.Local).AddTicks(7984), "Brechin", null, null, "0285671009", 1, null, "lbrechin2t" },
                    { new Guid("41d0eef5-edfc-4079-960d-798dbddc0bef"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$Y4.0Hv/rjz/WxTrhnGB.EulhEOVDmiriCKMg6NTz7eK1e3OgFh8M2", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 404, DateTimeKind.Local).AddTicks(4642), "Barhem", null, null, "08054760577", 1, null, "sbarhem2m" },
                    { new Guid("42066d19-70ef-4b0c-b15f-41f2ea17ab3a"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$fHn91PLBidoBrJndbkqEB..UbdnyEJoYOp4B2byv/Xj3B.r45b8y2", null, false, new DateTime(2023, 4, 12, 15, 57, 3, 13, DateTimeKind.Local).AddTicks(732), "Maddyson", null, null, "0915548406", 2, null, "cmaddysonm" },
                    { new Guid("4448341f-2d5e-48d3-a2ac-41483b266b0f"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$QrrtMS8LRd8hblrZsgVt/OALJBNmxrNL8PHo3jVewVjFVaSrmms2C", null, false, new DateTime(2023, 4, 12, 15, 57, 10, 367, DateTimeKind.Local).AddTicks(8386), "Jilkes", null, null, "00677856497", 2, null, "bjilkes2c" },
                    { new Guid("44ef0bf9-4101-4732-8da5-5128925b9e08"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$LMc7q/w5Um6mEEZ4cNGDyOSiFn8S1CWDE2buo7IfJ/OLBb57ugD42", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 766, DateTimeKind.Local).AddTicks(1091), "MacKegg", null, null, "05989129010", 2, null, "wmackegg26" },
                    { new Guid("4afdec66-d970-4e4a-9bce-4bebd6d235c5"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$rQK1Wfo6H93URTWnmKPywOmHj217AhwdwUI2z9yBd1jSiuEsj0BWe", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 568, DateTimeKind.Local).AddTicks(2800), "Swanson", null, null, "09572022187", 1, null, "gswanson24" },
                    { new Guid("4b2cf3b8-51ec-4a91-9dc7-de1163ef414a"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$OXG2dUtnSl1JO8CkQEOegO7wDRIYZkMJ3rtSvgyNTmprqrbdj7pNK", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 605, DateTimeKind.Local).AddTicks(7879), "Andriessen", null, null, "05873824805", 2, null, "candriessen2o" },
                    { new Guid("4f425be9-2224-4a68-ace3-3446e81579e1"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$M/s/KhEdD.78Z6rFng2y..KjzmIIF/Y8buEFjU/L3qTO5CmBLHUCu", null, false, new DateTime(2023, 4, 12, 15, 57, 5, 467, DateTimeKind.Local).AddTicks(8736), "Filipchikov", null, null, "0663461504", 2, null, "afilipchikov15" },
                    { new Guid("55f40125-eb63-496e-b2b2-5bd278e8bbd7"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$1bJTIwTNC/bVSY7E9qgoEOwJk4TOW7u9RJm16WwecZb/NTD0eX80S", null, false, new DateTime(2023, 4, 12, 15, 57, 5, 714, DateTimeKind.Local).AddTicks(205), "McMechan", null, null, "0613503781", 2, null, "mmcmechan17" },
                    { new Guid("57fe7f75-1a69-4ef2-b06f-d9d9e259ddd3"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$eHvMTGfgo/B/dMSQcvUdceDlKJztJDfse70k2GDptd727xJxGDyM6", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 286, DateTimeKind.Local).AddTicks(2566), "Masser", null, null, "0612845922", 2, null, "smasser2v" },
                    { new Guid("5cae3ef7-99e1-4174-b52b-c0b952b00cb8"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$I37ydef/sfEnOeTP0LC4F.Unv/cgnqVK9GeLyZAoj9GLRG1p2WXqy", null, false, new DateTime(2023, 4, 12, 15, 57, 2, 467, DateTimeKind.Local).AddTicks(8978), "Martinyuk", null, null, "0766805261", 2, null, "nmartinyuki" },
                    { new Guid("600d0643-f47c-446a-b38e-e0a8036520a0"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$IVJlXy7R72J3Wfaikf6vZeu2JUMp29D4T/fvWleovkwW1C5JsKCnu", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 2, DateTimeKind.Local).AddTicks(2099), "Haney", null, null, "0041887086", 2, null, "dhaney2i" },
                    { new Guid("665f978a-94ff-4fdd-9cc3-f2061f649d70"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$NIUEJcjKxq1BNEtBf6gtIujiYU..zudGXUoqpH4bqLBvNUNM200MK", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 511, DateTimeKind.Local).AddTicks(2356), "Saban", null, null, "02156386100", 1, null, "csaban2n" },
                    { new Guid("6b5d2508-df92-45d0-888a-0003898245d9"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$uBBH2J2nopatd0j0KLsM/.igqAxhP8pCO1e/RNGol5LlsiAL4Eae2", null, false, new DateTime(2023, 4, 12, 15, 57, 8, 27, DateTimeKind.Local).AddTicks(8224), "Brockelsby", null, null, "04963800585", 1, null, "jbrockelsby1q" },
                    { new Guid("6b6052b8-6f88-4872-83de-3356880d030b"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$RWlCxq5I5gPE8vW9.ID1Vu1xurDKO6pjaSE0ugQp/a1KzfE0HfLum", null, false, new DateTime(2023, 4, 12, 15, 57, 3, 548, DateTimeKind.Local).AddTicks(3729), "Bolver", null, null, "0361641052", 2, null, "bbolverq" },
                    { new Guid("6b9f742d-2ad0-4ff3-a6b2-cc08233adc70"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$TD6thB0Hp23ZUY7MYLG/5uUQIaXz4y95ZSnvpTYtN3gHMsSByH2Fi", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 975, DateTimeKind.Local).AddTicks(3926), "Canti", null, null, "07734012207", 1, null, "gcanti28" },
                    { new Guid("6f4196f8-e809-48de-b8dd-846b912b39f8"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$APBmfdXdgikN5yCsdxbvaOAOOfQ81tw0a1EV8QWTUo4rpZPHoL0hW", null, false, new DateTime(2023, 4, 12, 15, 57, 8, 706, DateTimeKind.Local).AddTicks(24), "Polden", null, null, "0831072797", 1, null, "rpolden1w" },
                    { new Guid("7334857d-ad65-4efd-8591-542e6ce0a847"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$LXUoxHb8w9OZ91Kj3oGLtOP7NP2JJETBUulfvW9e9374J/k4PYsHC", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 342, DateTimeKind.Local).AddTicks(2624), "Webley", null, null, "0821411907", 1, null, "jwebley22" },
                    { new Guid("7729f797-7ac6-4adc-8627-200484fe4f4b"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$looKFFlkN0ltz4mRmiUhk.82Yh4y9bh/2vOgcCg7kUuAYvn0lD1Ue", null, false, new DateTime(2023, 4, 12, 15, 57, 6, 63, DateTimeKind.Local).AddTicks(4795), "Milton-White", null, null, "0602588523", 2, null, "jmiltonwhite1a" },
                    { new Guid("79960f3a-5947-4447-a0fe-e692fb7a35a3"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$zZgBcVVvRL1I8yD9cqyxWemD6RaVbIcAbY6breLFFvC37LeYUHLnO", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 184, DateTimeKind.Local).AddTicks(4570), "Gonzalo", null, null, "0459531972", 2, null, "lgonzalo2u" },
                    { new Guid("7a779e4e-280a-4d25-ad48-49c520cc1b2e"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$rxpsYE65XuUoewHpqQWS5.KbVc35KENNIZzDu4BTC1m5VVU3U6M82", null, false, new DateTime(2023, 4, 12, 15, 57, 5, 839, DateTimeKind.Local).AddTicks(3557), "Strooband", null, null, "0129884328", 1, null, "tstrooband18" },
                    { new Guid("7d38e038-7777-451e-b788-7ce65909b3a8"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$w2V/xI8pv17LKu8vfVSdzu5TR5Yx6nePWR5TpjR7uaaVZfOd7cn6e", null, false, new DateTime(2023, 4, 12, 15, 57, 4, 572, DateTimeKind.Local).AddTicks(8383), "Springham", null, null, "00834111266", 1, null, "sspringhamy" },
                    { new Guid("7da0e1ae-dd25-48cc-9031-ab14f2a19300"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$WCxXpoGO2n5fnO2b1aKOUu.c4ySgCxtzbKv5EJUsm4At/Sj9rFu3C", null, false, new DateTime(2023, 4, 12, 15, 57, 8, 389, DateTimeKind.Local).AddTicks(4628), "Trippitt", null, null, "00615614760", 1, null, "atrippitt1t" },
                    { new Guid("7e7c6d8b-e051-4c54-9ec7-58ba0d91230c"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$QWSWJIW0Pj8A8C5AXzg8de0xXBx2ktVRBWNfcMN8.IPj2Rt4iC8d6", null, false, new DateTime(2023, 4, 12, 15, 57, 8, 153, DateTimeKind.Local).AddTicks(8293), "Hallard", null, null, "03332477053", 2, null, "mhallard1r" },
                    { new Guid("8352b4bb-aa92-4c79-a23a-fce3ce7ac28e"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$pRfxrM4TpG2EsmIcynBObu7CMhyu7hn38Cn70Vs55aS/82Eq0c37G", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 895, DateTimeKind.Local).AddTicks(415), "Iacovacci", null, null, "0770070777", 1, null, "siacovacci2r" },
                    { new Guid("866dca6b-021b-45e5-88fa-d45374e7817c"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$B7RQ03y3/8g6Vq4Z.XDraefxLdbhk43nncSovdT3.8a9UYcNFRj8O", null, false, new DateTime(2023, 4, 12, 15, 57, 6, 429, DateTimeKind.Local).AddTicks(6684), "MacGorrie", null, null, "0259328059", 2, null, "kmacgorrie1d" },
                    { new Guid("8a36205f-3e1e-4ac5-bf11-165354795d08"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$2ec84TjIkTVEsy63/a5tfeOW7O8z1rqaVFrUI.pMetNm1GCiTalq2", null, false, new DateTime(2023, 4, 12, 15, 57, 6, 169, DateTimeKind.Local).AddTicks(6659), "Petteford", null, null, "0939882707", 2, null, "spetteford1b" },
                    { new Guid("8e17887c-e75f-40d7-bd74-45a77a366208"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$QzKl/I8BjsdhcJSAZN.jQeudX.N2s6bJBZ4NjOtU73PqI2VO1vvZu", null, false, new DateTime(2023, 4, 12, 15, 57, 10, 574, DateTimeKind.Local).AddTicks(2848), "Izhakov", null, null, "05872358652", 1, null, "cizhakov2e" },
                    { new Guid("8f074bca-3684-4558-8610-120385b85941"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$ESRsF5M5gxaJIIYqQObnSudmaRaO/JJsUlxBVQwx5PQhzTu79sUDm", null, false, new DateTime(2023, 4, 12, 15, 57, 7, 150, DateTimeKind.Local).AddTicks(3092), "Shufflebotham", null, null, "0960301131", 2, null, "pshufflebotham1j" },
                    { new Guid("9463fbde-97b3-476a-814c-06015b87c456"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$R6bxVR3UGOUf4GTxSqtO3.pqAgfFhaHYWNmreu.YT.4.3IFd/TFeG", null, false, new DateTime(2023, 4, 12, 15, 57, 5, 347, DateTimeKind.Local).AddTicks(7562), "O'Connor", null, null, "0750854688", 1, null, "aoconnor14" },
                    { new Guid("9bc72d6b-dd3d-4d73-b5b9-a274a8a86d8f"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$exOEA4OEa5dvmWCIW/gz0etwVLnCpbvohmrKQXEO3YK9JiVMehreq", null, false, new DateTime(2023, 4, 12, 15, 57, 10, 903, DateTimeKind.Local).AddTicks(7125), "Oubridge", null, null, "0429461131", 2, null, "eoubridge2h" },
                    { new Guid("9c770e23-c17a-4b75-90f1-b5770771783e"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$5nY4nZOj1DvU7.fAHK9cv.rC.GgMSdvF0ICNq2pO45sKNCHjmFsw2", null, false, new DateTime(2023, 4, 12, 15, 57, 5, 604, DateTimeKind.Local).AddTicks(4262), "Kroch", null, null, "09201855247", 1, null, "okroch16" },
                    { new Guid("9c9c01f0-3372-4184-8846-9931c1fbcd8d"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$au7JMwzJrC044G7i.WtHV.Xe7vC84T2Wzjm3EOlEfnKh9eTD2wl6m", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 995, DateTimeKind.Local).AddTicks(7940), "Yuille", null, null, "00670067189", 2, null, "ryuille2s" },
                    { new Guid("a3660444-7fc0-4539-9349-039c31803baf"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$wqvFMzl9anWkByFSylP7xenDDi6PGjeoSQastx6t4ov7CtoSeS8Gy", null, false, new DateTime(2023, 4, 12, 15, 57, 10, 85, DateTimeKind.Local).AddTicks(4863), "Hargitt", null, null, "04664308348", 1, null, "ahargitt29" },
                    { new Guid("a3c88392-6f5d-45bd-8702-2c7a78bff422"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$6rZ5279FjeW.lA1t7mi5OOfpVI0xl3lz4P2F7JaMQ/Nem0Ov4lDWa", null, false, new DateTime(2023, 4, 12, 15, 57, 6, 919, DateTimeKind.Local).AddTicks(8511), "Ashpole", null, null, "03667705539", 1, null, "kashpole1h" },
                    { new Guid("ab327439-852a-41d9-9349-f7df4196241e"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$K3mv3pSt18Z3YApKRs3teOfeHDVP51sXtL5LRegWTEaj6i0jSik6O", null, false, new DateTime(2023, 4, 12, 15, 57, 5, 110, DateTimeKind.Local).AddTicks(8645), "Dolder", null, null, "0857765771", 2, null, "pdolder12" },
                    { new Guid("b046723b-d1fa-4c4b-abd6-ff1e40af5f65"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$RUVSXVR3xfSf3caEKFJ08.8ZpqlAy6OiOR9BoZDUk5mdbXTbB5vkO", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 704, DateTimeKind.Local).AddTicks(8085), "Vernall", null, null, "05157407415", 1, null, "overnall2p" },
                    { new Guid("b12c6240-f926-4030-8868-6c6ec655f310"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$oLY.trYegzJKJMDhPvVuTuWsE/IFHnxVTVcEuByEnZpmT8EgeqvSi", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 482, DateTimeKind.Local).AddTicks(8901), "Elgee", null, null, "0961523438", 2, null, "melgee2x" },
                    { new Guid("b654efab-f25b-4037-a9db-bba6cbd50e79"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$jpOukmeqnLNZDx0.8LbAbOtcp2V4f/zA5ANIb0hFCbA16r0tflAV6", null, false, new DateTime(2023, 4, 12, 15, 57, 7, 661, DateTimeKind.Local).AddTicks(8459), "Hannen", null, null, "06533305742", 2, null, "channen1n" },
                    { new Guid("b6e2316b-34df-498e-a86a-d114a8ee8ac2"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$LXXdeqRWgJO.PL.hPADVb.rpSJF4D4tPkPsenXTAhCUDNr6yQaAFe", null, false, new DateTime(2023, 4, 12, 15, 57, 3, 770, DateTimeKind.Local).AddTicks(9217), "Beament", null, null, "0756962604", 2, null, "obeaments" },
                    { new Guid("b7151d39-2544-4e1e-ad1b-7361c615e1c7"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$qHfm4fUDAWum4ODcoBQHKuaLgn7X56F3VpCLXTXnD85Tx0k58yZmi", null, false, new DateTime(2023, 4, 12, 15, 57, 4, 302, DateTimeKind.Local).AddTicks(3490), "Lere", null, null, "04037990815", 1, null, "rlerew" },
                    { new Guid("b9b309ce-d707-4a4f-9a39-73ff068b0ea1"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$CuYXG4Ez2vHZoxd7vdXeOOLkKJ6kDSqsRyRPgrN/zDzgecsH5KDTG", null, false, new DateTime(2023, 4, 12, 15, 57, 4, 850, DateTimeKind.Local).AddTicks(6756), "Briston", null, null, "02637402338", 2, null, "cbriston10" },
                    { new Guid("be581f73-674b-4f2d-90f0-e05b83bbdda7"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$wXQE3YN3m6YedrQJh/22H.yv9UUyGjt4Wmkx9CF/At4Cr90Ytcb2y", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 800, DateTimeKind.Local).AddTicks(6877), "Baldacchino", null, null, "05380625199", 1, null, "mbaldacchino2q" },
                    { new Guid("c0976397-9412-4cb7-8b20-153effa6197b"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$DfShbRXGten/FFHi9XO.LOhue9/B9elTd8bmmS.N.U3G4Kor.6TTi", null, false, new DateTime(2023, 4, 12, 15, 57, 7, 904, DateTimeKind.Local).AddTicks(94), "Rameaux", null, null, "0213510408", 2, null, "vrameaux1p" },
                    { new Guid("c1c2fab6-9977-4b25-a879-d2676fde1c34"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$0ffMouZWBNbLN0FsrxN3NO.nW4GSmzQqN1zScqeYTj/4myKHxgK5i", null, false, new DateTime(2023, 4, 12, 15, 57, 7, 551, DateTimeKind.Local).AddTicks(4031), "Margrie", null, null, "0153784673", 1, null, "cmargrie1m" },
                    { new Guid("c2d2e51d-2644-45e3-a9b8-e01e9cd97ce3"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$tSV3AEuTvcyvsunWf.ZkLOORjaelfiyClFfuXKRfzCVD4GBN7zzI.", null, false, new DateTime(2023, 4, 12, 15, 57, 8, 929, DateTimeKind.Local).AddTicks(384), "Batrip", null, null, "0734926905", 1, null, "abatrip1y" },
                    { new Guid("c33e09a5-3625-40b4-b6a1-0d9c16c0d586"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$UBSO8YaVjp2uNewOVstECuJG1IDND72cXwrNqx3IrO5/WIoHCfYPa", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 668, DateTimeKind.Local).AddTicks(9137), "Beamson", null, null, "07242980517", 1, null, "kbeamson2z" },
                    { new Guid("c5ee5d4c-33a4-407e-b9e4-dc06d50c4ed9"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$bqTTdRfL65n4hwVyg16YNuHmxiu19yLZOnYMlMJzwI4SkD3RNxmga", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 231, DateTimeKind.Local).AddTicks(5697), "Latan", null, null, "07949258154", 1, null, "rlatan21" },
                    { new Guid("c79fde65-ece0-4039-b915-c890f14b2524"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$Z3FfhB0D2RwLthNulQs0eepnZo/61pzaxIOiEWS6qqcYZlKPcD/JG", null, false, new DateTime(2023, 4, 12, 15, 57, 6, 795, DateTimeKind.Local).AddTicks(4948), "Gareisr", null, null, "07314447051", 2, null, "tgareisr1g" },
                    { new Guid("c98e52ff-f20b-4afa-ad20-742c2385645d"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$5Ew9UywXrzIu6/4XAu0Io.nQLyCWClJCBX5FoC9Fu2PyrU9IOl4z6", null, false, new DateTime(2023, 4, 12, 15, 57, 4, 443, DateTimeKind.Local).AddTicks(5189), "McKinlay", null, null, "03957603316", 2, null, "dmckinlayx" },
                    { new Guid("cc5ac9a9-3b90-4339-9fbe-18b8b4e628a6"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$OFWh.1vYS6NRgYWXY0FhG.PxWGcvDw6Rr/cYUrhPb.uQsBwxFnFG.", null, false, new DateTime(2023, 4, 12, 15, 57, 4, 187, DateTimeKind.Local).AddTicks(4974), "Warnes", null, null, "0812419659", 2, null, "ewarnesv" },
                    { new Guid("cd46eab5-7c09-4f77-ba50-1c53e1ec458c"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$rbe/um091cYxjcmWvD/x6OuFYiknHgtyJPuSQLCXswDK01x8J1Ev6", null, false, new DateTime(2023, 4, 12, 15, 57, 5, 228, DateTimeKind.Local).AddTicks(5379), "Cantor", null, null, "0218299981", 1, null, "jcantor13" },
                    { new Guid("cdf5a946-e46d-47e7-b46d-56fd025625d0"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$IB767EKod62KjNC4S.t0iOkQ9cN151piQtm6sMnZauu7T6XDRkRpi", null, false, new DateTime(2023, 4, 12, 15, 57, 8, 289, DateTimeKind.Local).AddTicks(9721), "Webling", null, null, "0390471753", 2, null, "bwebling1s" },
                    { new Guid("d503ed31-c298-4efc-8f4e-96d61bc64006"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$WtNIzpCxAcJV13rHvIFnnu5JftNPV4fMcVRugAVV.tBhdl2cWoMU6", null, false, new DateTime(2023, 4, 12, 15, 57, 6, 544, DateTimeKind.Local).AddTicks(7515), "Laidel", null, null, "06837677860", 2, null, "blaidel1e" },
                    { new Guid("d749e430-56cb-4499-8efc-2a269b8de0c3"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$5p8VuVZ7RPs9sSsJD2XrEORBbkqcN0op24iXV7KVnBN4hBeCXcWpu", null, false, new DateTime(2023, 4, 12, 15, 57, 11, 107, DateTimeKind.Local).AddTicks(2751), "Petrescu", null, null, "0719013924", 1, null, "bpetrescu2j" },
                    { new Guid("dec6f843-0c2a-4c5b-b8cd-95a8538274d2"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$K3q4A8wOaMfCYynWDzjE.e51KwOMOtlm.s.3pA9zYqoW2e9OnR0/e", null, false, new DateTime(2023, 4, 12, 15, 57, 8, 586, DateTimeKind.Local).AddTicks(4306), "Zamorano", null, null, "0619225384", 2, null, "czamorano1v" },
                    { new Guid("e0c12437-e8f0-4a88-8140-44e600c84445"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$KPxHgWBbfcTDioYbgQ2Ys.E9KLMOLjxCo2fcJ8ryna/UtGtJIDYJy", null, false, new DateTime(2023, 4, 12, 15, 57, 3, 134, DateTimeKind.Local).AddTicks(3672), "Skirvin", null, null, "0614302061", 1, null, "mskirvinn" },
                    { new Guid("e1439dfe-515f-43db-90ba-bd2105a2574a"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$ivQGypGSL1SqQKAii.d7JeP3zXUYz6tSLVGLqaELJ1xiqP8yB/56u", null, false, new DateTime(2023, 4, 12, 15, 57, 10, 680, DateTimeKind.Local).AddTicks(5322), "Eliassen", null, null, "06497524328", 1, null, "jeliassen2f" },
                    { new Guid("e8953fb2-dced-4600-a16b-e79905dc1e4e"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$31Oaakm2iEgu/YFKh9Ivge7XTMRToQdMMJUmDeP9.tTdRK8kGZHDa", null, false, new DateTime(2023, 4, 12, 15, 57, 9, 30, DateTimeKind.Local).AddTicks(5768), "Kearns", null, null, "0461097167", 1, null, "skearns1z" },
                    { new Guid("ea19e2d8-bd4c-4434-bf84-050181eca5da"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$F047M4KwsJrcz7zQr1HZsenUWyUQU864nLroy61epp3Zwu60NkTXC", null, false, new DateTime(2023, 4, 12, 15, 57, 5, 939, DateTimeKind.Local).AddTicks(717), "Martugin", null, null, "02340159874", 2, null, "smartugin19" },
                    { new Guid("ea57745d-d29d-4b08-bc2c-8281e76285f2"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$KErwELUwpmKEO29fuczBAOCSLIBu15AILtTZbxMB5eC5BLY3eMjlK", null, false, new DateTime(2023, 4, 12, 15, 57, 2, 731, DateTimeKind.Local).AddTicks(8607), "Garrioch", null, null, "0072752247", 1, null, "mgarriochk" },
                    { new Guid("ec69ce92-8c0e-4e54-8cd1-59149a517ce4"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$tM2HGYZZbEuTKl6E80NL.e9g2KvsbuIvYHFnUa9dYFQh1h4f1G.RG", null, false, new DateTime(2023, 4, 12, 15, 57, 12, 964, DateTimeKind.Local).AddTicks(519), "Prater", null, null, "0629137900", 1, null, "tprater32" },
                    { new Guid("f2675808-976f-4b46-932e-e48ebd1696c8"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$Na/d8eVtmoEYAs9I07dy/OqjCnU6alMm.Zun9kx/mLyciioVtH09y", null, false, new DateTime(2023, 4, 12, 15, 57, 2, 74, DateTimeKind.Local).AddTicks(4655), " Nguyen Van", null, null, "0966416708", 2, null, "owner" },
                    { new Guid("f26938a0-fd48-4376-81ef-e3446ad28665"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$HipKaWxXE2Qfrr9lnH.QpeM3Lci/4oVe0VHrBB8DGb2ga91iUpD4.", null, false, new DateTime(2023, 4, 12, 15, 57, 3, 269, DateTimeKind.Local).AddTicks(6346), "Goddman", null, null, "00110582594", 2, null, "kgoddmano" },
                    { new Guid("f4a045a7-7431-4821-a950-3cb68634f567"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$7hdBguFTwFEOivmu/X3EQOnIpbnb9AETzY9Aei2Akm73VQTGbi/TO", null, false, new DateTime(2023, 4, 12, 15, 57, 4, 959, DateTimeKind.Local).AddTicks(9070), "Dreossi", null, null, "03724370545", 2, null, "cdreossi11" },
                    { new Guid("f678ce40-d908-4f45-b414-b587a974b08b"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$USTLzebz230ruArAKZ2UQ.sWsmXa6pWWGBgj02vmxLgthvUInMLQ2", null, false, new DateTime(2023, 4, 12, 15, 57, 3, 657, DateTimeKind.Local).AddTicks(6856), "Featherstonhaugh", null, null, "0737666977", 2, null, "dfeatherstonhaughr" },
                    { new Guid("f7aba501-746d-49f0-bfb3-6927ae06e1a0"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$2Z5Vui04q7G3K6GtQuQfbOiND/fZarjkX9KpyYAUiNCP2p0/KKOhu", null, false, new DateTime(2023, 4, 12, 15, 57, 7, 799, DateTimeKind.Local).AddTicks(7406), "Ormerod", null, null, "02807987147", 1, null, "oormerod1o" },
                    { new Guid("f808a290-f93a-4774-b936-0b277fa46126"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$iUZjVxGGsohrWstMIolzhuedVFoKfpCS6SwENPNv2L.9e50xOFFxi", null, false, new DateTime(2023, 4, 12, 15, 57, 8, 826, DateTimeKind.Local).AddTicks(4111), "Stranger", null, null, "03239623484", 2, null, "gstranger1x" },
                    { new Guid("f902f507-b57d-45fa-8266-3b74411eaf6c"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$ZBcK7DnDD8P4mxgDmYa22OWNNaV.Kz0WSxH7ibTlkpKujNVDM4SZu", null, false, new DateTime(2023, 4, 12, 15, 57, 6, 675, DateTimeKind.Local).AddTicks(4639), "Mattam", null, null, "0865586458", 2, null, "emattam1f" },
                    { new Guid("fce87460-a6a6-42a6-a9c9-119cfae8f1a5"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$5ae87r3iHGDWR.8VPoiAruzuVJ1/l2RKSwA4zNi1R7BhtBd7xLk8O", null, false, new DateTime(2023, 4, 12, 15, 57, 2, 305, DateTimeKind.Local).AddTicks(967), "Lavens", null, null, "06895509784", 2, null, "rlavensh" }
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
