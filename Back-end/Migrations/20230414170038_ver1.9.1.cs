using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver191 : Migration
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
                    { new Guid("58c63213-5dc1-4b3e-a1bc-1555c33133ca"), "Xe 4 chỗ du lịch", null, null, "Sedan" },
                    { new Guid("60f8c2e1-b70e-4cd1-9adc-3e5a96160988"), "Xe bán tải", null, null, "Pickup" },
                    { new Guid("802ffca2-b0be-4ca1-a009-5fecb52978df"), "Xe 7 chỗ", null, null, "SUV7" },
                    { new Guid("98609785-f403-48c5-aab9-9368b48112e0"), "Xe van con", null, null, "Minivan" },
                    { new Guid("a6b1aa26-c3be-4979-9dd8-b0e22e9cda3f"), "Xe 2 khoang", null, null, "Mini" },
                    { new Guid("ae3bb6f2-ccf9-4bd7-9f36-f43da44b7f7e"), "xe 5 chỗ", null, null, "SUV5" }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("23873508-db90-465c-9cea-f052841a5b29"), "Half Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, "Medium", 70000.0 },
                    { new Guid("52bdf9c6-552a-49cf-b2b2-958b29d7af02"), "1 Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L, "Long", 130000.0 },
                    { new Guid("936a557e-8f91-4ccb-a5c4-50791081e92c"), "Short time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, "Short", 40000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "ImageID", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "TransactionID", "UserName" },
                values: new object[,]
                {
                    { new Guid("01ec34df-71a1-417c-b43f-46b25b560030"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$.AARZBkPqNWGZMKn0Y4Hb.95yJPcpEJuQyVZDeTRSLC.2WQ3gZBqW", null, false, new DateTime(2023, 4, 15, 0, 0, 26, 244, DateTimeKind.Local).AddTicks(3664), "Lavens", null, null, "06895509784", 2, null, "rlavensh" },
                    { new Guid("0472f0f8-6bae-400c-8b81-cbfc09f1f1ec"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$xX.g.YjBSa5ghL3IwQgIXOZhjLMvau22/pb1Ld5xR0u9u7Mwztvuu", null, false, new DateTime(2023, 4, 15, 0, 0, 33, 567, DateTimeKind.Local).AddTicks(2283), "Scheffel", null, null, "0355632555", 2, null, "hscheffel23" },
                    { new Guid("07708026-5b02-4f03-9d9e-2b48c446a0d7"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$P2sT7htVsZQdBq8YXm6G9eitr/M1UuW99sAilRhDgM67qnW5p48bS", null, false, new DateTime(2023, 4, 15, 0, 0, 32, 627, DateTimeKind.Local).AddTicks(8502), "Zamorano", null, null, "0619225384", 2, null, "czamorano1v" },
                    { new Guid("0a3a83ad-36e6-4abf-a5bb-0ff71296a67d"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$OuThhUf17fu97tYHK6Ki3OePQ5w1RGlGhA43YRwZWOiARNHQw/I6u", null, false, new DateTime(2023, 4, 15, 0, 0, 27, 281, DateTimeKind.Local).AddTicks(1770), "Dunsford", null, null, "00868235500", 1, null, "rdunsfordp" },
                    { new Guid("0b44f200-3842-4b7a-9eb6-8c0330c481f4"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$eyvs1CXBlX5zNC8ljn0GhuJwKswbfFLX.NgJ28B5faI4PuxrEax7i", null, false, new DateTime(2023, 4, 15, 0, 0, 27, 539, DateTimeKind.Local).AddTicks(8641), "Featherstonhaugh", null, null, "0737666977", 2, null, "dfeatherstonhaughr" },
                    { new Guid("0ccc3bc1-487e-4900-93df-7be72e133349"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$iKQO3DPiSasQn3UsOhLQgOb3SyFHLw3mJRFhrrUB7i9x40Q0guhQe", null, false, new DateTime(2023, 4, 15, 0, 0, 31, 352, DateTimeKind.Local).AddTicks(5665), "Margrie", null, null, "0153784673", 1, null, "cmargrie1m" },
                    { new Guid("102a8c1a-3397-4360-a8af-5a446f6d796b"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$mmJH9Psj3xar90ts.iGrpekFsrFSZ8ZU936.ETGPgk2U7kZPENw1a", null, false, new DateTime(2023, 4, 15, 0, 0, 30, 566, DateTimeKind.Local).AddTicks(1195), "Mattam", null, null, "0865586458", 2, null, "emattam1f" },
                    { new Guid("14893154-0664-4d57-ac97-0710456943e8"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$KCvFiGB6Pn./Wj2LTjOqx.JvvXBjK9tm2PwM.tqaFchcXwkJBeHUe", null, false, new DateTime(2023, 4, 15, 0, 0, 36, 145, DateTimeKind.Local).AddTicks(2554), "Saban", null, null, "02156386100", 1, null, "csaban2n" },
                    { new Guid("15575ed7-d1c6-4879-a75a-7017109e9e1b"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$HK4bLKVEh9CueDMmf5Yk9OrpyRkKvAYQmW6kbfOQH4dLISKpEiyai", null, false, new DateTime(2023, 4, 15, 0, 0, 38, 87, DateTimeKind.Local).AddTicks(7049), "Struss", null, null, "06928824187", 2, null, "astruss31" },
                    { new Guid("17c9d1a8-bf11-4292-bd09-986331fb9075"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$nFr4WB3RVc4qZuyf3CMUYOaC43eZ/Zzv8SCICcSFGEaiX.9uOHwtu", null, false, new DateTime(2023, 4, 15, 0, 0, 32, 753, DateTimeKind.Local).AddTicks(3237), "Polden", null, null, "0831072797", 1, null, "rpolden1w" },
                    { new Guid("18116e5c-db51-49e5-9b25-4d3d6866a6b6"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$U0cvuBlaaa1kOuJT.DLzmO2wbjq0LLL6p9MmFbLwcwzwBL1dq8wfO", null, false, new DateTime(2023, 4, 15, 0, 0, 37, 836, DateTimeKind.Local).AddTicks(9440), "Beamson", null, null, "07242980517", 1, null, "kbeamson2z" },
                    { new Guid("18e869e4-bd2d-4328-96a8-8b74776b2c74"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$RdwqsMWdNukW0dAim1zvmeqRFXncwYrDmjTQ8kBEvkplXnYIH1a.C", null, false, new DateTime(2023, 4, 15, 0, 0, 30, 781, DateTimeKind.Local).AddTicks(8587), "Ashpole", null, null, "03667705539", 1, null, "kashpole1h" },
                    { new Guid("1d4b7364-f8c4-497b-b517-436f8a222def"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$jlMtncwirK4sBJw14BGP/u/AkrzKYB0qTrorxz7SrZo2FsSq.wFsG", null, false, new DateTime(2023, 4, 15, 0, 0, 33, 7, DateTimeKind.Local).AddTicks(3146), "Batrip", null, null, "0734926905", 1, null, "abatrip1y" },
                    { new Guid("1e77bb06-0d59-4760-9c42-0aa580bbf9cc"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$omwYh.Fd5JBtroEhS57INOc1srA6QTlf2P0mYlZPKTFqs8V9UzD6u", null, false, new DateTime(2023, 4, 15, 0, 0, 30, 149, DateTimeKind.Local).AddTicks(4391), "Middlehurst", null, null, "03494633510", 2, null, "dmiddlehurst1c" },
                    { new Guid("2059872f-e7be-48e6-a613-c1d6229d8b15"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$Ff2vkSnQbn.xFjD7ZroXfOqrr7mOlT/jYiNRtI7BVFifgKpX6xLt6", null, false, new DateTime(2023, 4, 15, 0, 0, 36, 995, DateTimeKind.Local).AddTicks(4447), "Brechin", null, null, "0285671009", 1, null, "lbrechin2t" },
                    { new Guid("2406a356-5be5-4d9f-9e38-2e3f8753fff7"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$QU3Pz.8W4Uu3AH4WVYUNaufz125.m0nvOv1.ZTJxbbtc1pb5w6S4q", null, false, new DateTime(2023, 4, 15, 0, 0, 28, 150, DateTimeKind.Local).AddTicks(386), "Lere", null, null, "04037990815", 1, null, "rlerew" },
                    { new Guid("29c12646-de05-4f2c-89e1-b00ea4814e77"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$ZX5.ZggekImCLZ1RkOtIA.uom2vfMIPxiethQaWFq5jWcxFAp6DFa", null, false, new DateTime(2023, 4, 15, 0, 0, 28, 269, DateTimeKind.Local).AddTicks(6091), "McKinlay", null, null, "03957603316", 2, null, "dmckinlayx" },
                    { new Guid("2afb46e5-8c36-4802-bc76-32d3d784d1bf"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$5Nu7/vNcPe4LItRxX5QGDu27PaUXMaptV.VhlVMxfcQLYIGvsSq3W", null, false, new DateTime(2023, 4, 15, 0, 0, 35, 431, DateTimeKind.Local).AddTicks(8896), "Oubridge", null, null, "0429461131", 2, null, "eoubridge2h" },
                    { new Guid("2c540e3c-de58-4113-bd96-606613581a15"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$apwn17c2Rb5VRrwsq3qHV.iuSz0o.6j1BLlpKN91DM2.Hvi4IcEBe", null, false, new DateTime(2023, 4, 15, 0, 0, 37, 544, DateTimeKind.Local).AddTicks(6872), "Elgee", null, null, "0961523438", 2, null, "melgee2x" },
                    { new Guid("2efb97ad-ccc7-452f-a8f6-ba0a315b2a9e"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$p5GSvHqMK27oD4KZLMx.I.ijBG/RyIfNl4JGz55fmy0gV8C5Tvyxi", null, false, new DateTime(2023, 4, 15, 0, 0, 31, 478, DateTimeKind.Local).AddTicks(7150), "Hannen", null, null, "06533305742", 2, null, "channen1n" },
                    { new Guid("3442da38-23a6-46e6-86ce-89b6b1bfe950"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$iuyCBIC/z2hGGTya4/HGpO6AAy1F7nmNHnnW8YX6TwzOoRI2PTxVa", null, false, new DateTime(2023, 4, 15, 0, 0, 35, 542, DateTimeKind.Local).AddTicks(8728), "Haney", null, null, "0041887086", 2, null, "dhaney2i" },
                    { new Guid("36ac35a1-81de-4552-b261-aef5c393de50"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$kfnEm5tDX.gWIZgUmfeHiOBDaYSy/oHaTTLoIhBVHsdCYCV5FE2zK", null, false, new DateTime(2023, 4, 15, 0, 0, 33, 138, DateTimeKind.Local).AddTicks(6877), "Kearns", null, null, "0461097167", 1, null, "skearns1z" },
                    { new Guid("3d984e9b-4e9a-4b1c-b966-47cd6c0d0f1f"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$wzIzN80VuFa0Bna.wu1M8epMImvcZ8enF6Abf22jwROAXDEXnYvtW", null, false, new DateTime(2023, 4, 15, 0, 0, 28, 529, DateTimeKind.Local).AddTicks(9189), "Maestrini", null, null, "0312994030", 2, null, "fmaestriniz" },
                    { new Guid("3de08acf-779a-41ff-a9bf-2a92e6bb58ce"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$pgrNe77yOs8gj1klHwMPeehYI2gDxOtRI0l75VVYRORp8nMLU8iY2", null, false, new DateTime(2023, 4, 15, 0, 0, 30, 675, DateTimeKind.Local).AddTicks(8289), "Gareisr", null, null, "07314447051", 2, null, "tgareisr1g" },
                    { new Guid("4553669e-887b-4c6e-93c4-b2e000ffbc24"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$n9By9PAnP6vY6EHcqsVObOKZAdy1fheG/OBGIydJY4qGoutBP0m8y", null, false, new DateTime(2023, 4, 15, 0, 0, 33, 459, DateTimeKind.Local).AddTicks(2479), "Webley", null, null, "0821411907", 1, null, "jwebley22" },
                    { new Guid("457037e6-26f7-48ef-8de6-04b5b10c4504"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$g2et1xF4Yw61YqAFk9Bljef9oEvPghrTp5DDDo9d9Euy9CaNYj6Z.", null, false, new DateTime(2023, 4, 15, 0, 0, 25, 931, DateTimeKind.Local).AddTicks(7304), " Nguyen Van", null, null, "0966416708", 2, null, "owner" },
                    { new Guid("48d87e0d-635e-44b3-b902-c3bc2978e616"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$LRExmfPDsOjEiqU.KUk28eGQo689Tv0yG5.mf5LJEa/IblHKYA2Ri", null, false, new DateTime(2023, 4, 15, 0, 0, 33, 356, DateTimeKind.Local).AddTicks(3399), "Latan", null, null, "07949258154", 1, null, "rlatan21" },
                    { new Guid("4a6b6a1c-e744-4429-b031-12817004dc35"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$XuJlJWO4jGcPHWphuhsGZe0xGdEU/WuOTvrFcW21kQeI/eiw0lFPq", null, false, new DateTime(2023, 4, 15, 0, 0, 26, 906, DateTimeKind.Local).AddTicks(8523), "Maddyson", null, null, "0915548406", 2, null, "cmaddysonm" },
                    { new Guid("4ca0db66-b874-4f01-af5c-ca9ed6bee825"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$4e8hyu2bpjKfUdPAed/gretddjA5W0GqEbvybiYVLiRTzBDuwNn0K", null, false, new DateTime(2023, 4, 15, 0, 0, 27, 794, DateTimeKind.Local).AddTicks(3696), "Gostick", null, null, "05617299637", 1, null, "bgostickt" },
                    { new Guid("4d39ea65-40ab-415c-9d65-4cc314142890"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$eWrmBSDllWydBiDMoH1NUe6iGEYUVRpRais83XIhkEL1lH6iv3C/u", null, false, new DateTime(2023, 4, 15, 0, 0, 37, 285, DateTimeKind.Local).AddTicks(2060), "Masser", null, null, "0612845922", 2, null, "smasser2v" },
                    { new Guid("4fe38a43-c5ec-4ce8-bea4-67246c00604c"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$4J/dB6hAaSWi5wb.oti1vujN3jXrR0JDrcCIhQ/6hQTmpieBe8yhy", null, false, new DateTime(2023, 4, 15, 0, 0, 26, 412, DateTimeKind.Local).AddTicks(562), "Martinyuk", null, null, "0766805261", 2, null, "nmartinyuki" },
                    { new Guid("50efff99-8329-4042-a9a2-733a8932ba21"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$dslvfmL7ut2q58O1Azxm1./hrqn3ySnNRLVcSowk7.wa0DsBNVT.a", null, false, new DateTime(2023, 4, 15, 0, 0, 34, 499, DateTimeKind.Local).AddTicks(9967), "Ainscow", null, null, "0878444767", 1, null, "fainscow2a" },
                    { new Guid("51aba8f7-c1df-45e7-9d93-b1621e2b98a6"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$MLjbVLpaEkEFBDhxeSOpd.5pgvFIQMMQGOWZ.r.vnSi8f0bMewuNi", null, false, new DateTime(2023, 4, 15, 0, 0, 30, 40, DateTimeKind.Local).AddTicks(5404), "Petteford", null, null, "0939882707", 2, null, "spetteford1b" },
                    { new Guid("52c49307-ce93-48ac-a68d-602d3eec5f54"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$ASgYdosEwBpFByyguj/E0esaa7bk26QI1l.RH1n5swreuvly56JeK", null, false, new DateTime(2023, 4, 15, 0, 0, 25, 785, DateTimeKind.Local).AddTicks(5635), " Nguyen Van", null, null, "0966416708", 1, null, "customer" },
                    { new Guid("542ae8d2-3d58-458b-bea5-4a3d2ae36838"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$VuZUgJ.ojIwDaH27Ty7IUeWr74mRrmsu.mYpJ80tcXbgxDR6azi8i", null, false, new DateTime(2023, 4, 15, 0, 0, 35, 661, DateTimeKind.Local).AddTicks(4770), "Petrescu", null, null, "0719013924", 1, null, "bpetrescu2j" },
                    { new Guid("5941bcd7-c954-4a25-aa53-7633bb2965ad"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$f9vxm.GIYVN4QrBTZh45uuhreAjSDRHjqFDXfbn.8th.Iflg2Xr/.", null, false, new DateTime(2023, 4, 15, 0, 0, 33, 705, DateTimeKind.Local).AddTicks(5838), "Swanson", null, null, "09572022187", 1, null, "gswanson24" },
                    { new Guid("5f67bb59-bedd-447d-b4f3-f5bad5ffdbbd"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$gA4ehBnEu.GP/t53.kG0D.oLJP88p6jZGI4x2dmE7giQDCU.oemj2", null, false, new DateTime(2023, 4, 15, 0, 0, 37, 123, DateTimeKind.Local).AddTicks(3119), "Gonzalo", null, null, "0459531972", 2, null, "lgonzalo2u" },
                    { new Guid("61f039c7-e5e6-42e6-babb-494df8a520ee"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$QLYnIIMphmtaw5MvkLVsc.nDqKJe2apqqHvx3mrrnA2E.JZeyhWZS", null, false, new DateTime(2023, 4, 15, 0, 0, 38, 217, DateTimeKind.Local).AddTicks(97), "Prater", null, null, "0629137900", 1, null, "tprater32" },
                    { new Guid("63461da0-b7fb-4c1c-b94b-9e8982f10cbc"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$P93eIfQGQOifHFucVbFRoemh38uZGEUcd2crsZK5nqFcy1..9fvCC", null, false, new DateTime(2023, 4, 15, 0, 0, 29, 257, DateTimeKind.Local).AddTicks(1531), "Filipchikov", null, null, "0663461504", 2, null, "afilipchikov15" },
                    { new Guid("6581a002-6ae4-479f-b665-82a6e4b5bca7"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$Z2Y64HV69c2r3f5U6rihJuWjIHK/VboGXUTc0sO3nTFDoJnn7gFG2", null, false, new DateTime(2023, 4, 15, 0, 0, 30, 888, DateTimeKind.Local).AddTicks(7644), "Mackieson", null, null, "07046670689", 2, null, "smackieson1i" },
                    { new Guid("65865f86-6fe1-4a21-87c9-4055b310679b"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$.nyJ2NJgUQ8DOsDCEfLLYecTBT7QgkibH.dZET/J0g61.D4A6Yegu", null, false, new DateTime(2023, 4, 15, 0, 0, 27, 13, DateTimeKind.Local).AddTicks(7498), "Skirvin", null, null, "0614302061", 1, null, "mskirvinn" },
                    { new Guid("6c0437a1-b8f3-48e2-8e34-c94090d5290d"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$0P2/e2pmcjjPt8TFrv3opuCM6TYa15ihKuPnmpstEDlSDm7TwlcT2", null, false, new DateTime(2023, 4, 15, 0, 0, 30, 428, DateTimeKind.Local).AddTicks(2565), "Laidel", null, null, "06837677860", 2, null, "blaidel1e" },
                    { new Guid("6d9ddfc6-fcb9-4c82-b3db-7dded6141d4f"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$TaKNFBBlG3hfyXUQNYy7.uaCRj4k0cmcUpErRLdXhUD0Sz3xNz0ly", null, false, new DateTime(2023, 4, 15, 0, 0, 31, 95, DateTimeKind.Local).AddTicks(6318), "Droghan", null, null, "0910618733", 2, null, "kdroghan1k" },
                    { new Guid("6f35ddb4-e441-4c2a-bc20-26611e84227c"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$8lx1FIuxSjZZvu2tKvrGb.8aLEWKCGjxe0I1lf3a7tDu9g9TuR2.G", null, false, new DateTime(2023, 4, 15, 0, 0, 34, 78, DateTimeKind.Local).AddTicks(7345), "Glison", null, null, "06769810772", 1, null, "rglison27" },
                    { new Guid("71105363-2c7b-472f-9c7a-0f419dc6e9f6"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$6IdgdSqbrAsSUHfXcWcrt.gu3b2obUcJ0oij6U9Zm7pjur7wvx5d.", null, false, new DateTime(2023, 4, 15, 0, 0, 25, 493, DateTimeKind.Local).AddTicks(7572), " Nguyen Van", null, null, "0966416708", -772000, null, "phucnv" },
                    { new Guid("7333f75c-bc45-4503-9b25-e1350da493ae"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$L8gw7Op3VM3.3CcmDrMzzusOiw.cTs2db.//.A4PRkcMoKO.CJO8a", null, false, new DateTime(2023, 4, 15, 0, 0, 28, 27, DateTimeKind.Local).AddTicks(5820), "Warnes", null, null, "0812419659", 2, null, "ewarnesv" },
                    { new Guid("74789186-d779-4e08-89f4-eb6563af5a92"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$avdnrzy5NWLF/Gd7KRAubOAy2vgeWMdmAFE41ffiN5003lwN7PlzG", null, false, new DateTime(2023, 4, 15, 0, 0, 32, 204, DateTimeKind.Local).AddTicks(6830), "Webling", null, null, "0390471753", 2, null, "bwebling1s" },
                    { new Guid("7599751c-d8f1-47a6-b729-af73bf55aa52"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$vaJjbv.n5Rqhi2G91MECYuMOuysLJh.Z13bRbJeAmvpDzQPX3w34q", null, false, new DateTime(2023, 4, 15, 0, 0, 25, 626, DateTimeKind.Local).AddTicks(1904), " Ass min", null, null, "0966416708", -772000, null, "admin" },
                    { new Guid("76bbf4a5-89ee-4215-b381-5f1d5693345b"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$peDKy1RUDI5iSE4gq3LDfeEsxdkJG5l4BctMF.UWetGFCv4lyuP4y", null, false, new DateTime(2023, 4, 15, 0, 0, 36, 30, DateTimeKind.Local).AddTicks(2012), "Barhem", null, null, "08054760577", 1, null, "sbarhem2m" },
                    { new Guid("7d9b9343-e641-4edc-b9a8-236a2c13be5b"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$9ncPY5W5qZ18mK7Z.N/qY.aZRqRDUz0.PMe1GeSCYyt2tgTAnhTxC", null, false, new DateTime(2023, 4, 15, 0, 0, 36, 582, DateTimeKind.Local).AddTicks(9719), "Baldacchino", null, null, "05380625199", 1, null, "mbaldacchino2q" },
                    { new Guid("7df76968-72d5-449b-bf8f-12a62547fea4"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$XD2wi8EUIintZg7TsfsR7.Q6mZhEzHTFkb/XishMNWcBoEaJF8cWa", null, false, new DateTime(2023, 4, 15, 0, 0, 33, 948, DateTimeKind.Local).AddTicks(7940), "MacKegg", null, null, "05989129010", 2, null, "wmackegg26" },
                    { new Guid("7e97a100-e90a-4043-918a-c6218a25c913"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$1rP8Sc1k33ajQtIwMyBhy.d63..TmjUPL51clkrnuqRbm2K8FSlrC", null, false, new DateTime(2023, 4, 15, 0, 0, 30, 298, DateTimeKind.Local).AddTicks(5011), "MacGorrie", null, null, "0259328059", 2, null, "kmacgorrie1d" },
                    { new Guid("807c497c-fa76-4c72-afe4-048dc9e2d243"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$/Zbfdt761dgzLfNxd0t9JuYrDE1x2uEwjIGUCePSEUc5Xt2imLiLi", null, false, new DateTime(2023, 4, 15, 0, 0, 31, 209, DateTimeKind.Local).AddTicks(6053), "Berks", null, null, "04613021719", 2, null, "fberks1l" },
                    { new Guid("81b69aa2-93eb-4e33-baa0-df01c50e43eb"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$638wa41QdaF4qUwhL.yUU.zDKPYYNKQmptFuTYCkfkWPnCJD7ep2e", null, false, new DateTime(2023, 4, 15, 0, 0, 26, 543, DateTimeKind.Local).AddTicks(9021), "Powdrell", null, null, "0569083168", 1, null, "mpowdrellj" },
                    { new Guid("874ccf52-6dfa-48cf-9c5f-c8ae92523e63"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$ELtlAExnd1oHr9yVenkLiO9bViNb0xxO8yP8w1jzQH4vl0GM4EA4K", null, false, new DateTime(2023, 4, 15, 0, 0, 36, 285, DateTimeKind.Local).AddTicks(3760), "Andriessen", null, null, "05873824805", 2, null, "candriessen2o" },
                    { new Guid("87ae04ac-6b12-49ae-98df-48c7f095bb87"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$nn6lWnfUKS5qd8bTvsGCBOrg/JPV0ncKzt4Hb3AZuu0Od79oSReJK", null, false, new DateTime(2023, 4, 15, 0, 0, 28, 674, DateTimeKind.Local).AddTicks(7787), "Briston", null, null, "02637402338", 2, null, "cbriston10" },
                    { new Guid("87c9b83e-e89c-403f-ba40-b1729cb4d4aa"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$gQ6s0NNPNBdiPvoLIT7yNOUB/oq1.n3Oo5rP7kvG0ZJw8gUfHb8GS", null, false, new DateTime(2023, 4, 15, 0, 0, 29, 412, DateTimeKind.Local).AddTicks(3219), "Kroch", null, null, "09201855247", 1, null, "okroch16" },
                    { new Guid("8bd25f0b-5760-4f1e-bb2f-a01779983751"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$vA53RRa9eXiybnhD62oxe.DBPemsMYeXcRQwjvIRnEBdvvD56UqI.", null, false, new DateTime(2023, 4, 15, 0, 0, 29, 134, DateTimeKind.Local).AddTicks(9548), "O'Connor", null, null, "0750854688", 1, null, "aoconnor14" },
                    { new Guid("8c6e734b-88e2-4f1e-ba67-7c14cd6819d3"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$QjpTPq1GQvnJKpHvy53zvuiyokLSBzVcMd7iDNZepOhcjwCwMGLdG", null, false, new DateTime(2023, 4, 15, 0, 0, 29, 551, DateTimeKind.Local).AddTicks(7749), "McMechan", null, null, "0613503781", 2, null, "mmcmechan17" },
                    { new Guid("8cb54e89-e7c3-4365-b65a-9b11c4429df2"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$2yIdIxefGGsxpH/.JQ0CqeIpxkpWte9blG0DZy7ffWRG9stjcp7F2", null, false, new DateTime(2023, 4, 15, 0, 0, 37, 967, DateTimeKind.Local).AddTicks(4287), "Gerrish", null, null, "04944713025", 1, null, "rgerrish30" },
                    { new Guid("8ec709bf-7a4a-4e5b-9020-4996edc149f2"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$BHvgWuyRSxN2Qa5zUVUCPeTqiPHU8uQB9RRh8xP9ZS/EUDKjcTqHq", null, false, new DateTime(2023, 4, 15, 0, 0, 34, 896, DateTimeKind.Local).AddTicks(7282), "Faber", null, null, "08586159848", 2, null, "afaber2d" },
                    { new Guid("9400c722-c3f4-4ba8-a271-29100883f0ae"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$S6VgJAM6601GOvz1EFzFUOT4r15/4lF.oD9P3FYZdvSVx7cjPMPX.", null, false, new DateTime(2023, 4, 15, 0, 0, 26, 113, DateTimeKind.Local).AddTicks(2029), "Tubbs", null, null, "0630308378", 2, null, "gtubbsg" },
                    { new Guid("95e328b3-9fa6-47fc-bc8c-3ef78744a3d1"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$2Js9OOxiXr7Uf2vjcAQDMel3wiO5SARfKK7edUVkOGxirng5zu8SG", null, false, new DateTime(2023, 4, 15, 0, 0, 27, 131, DateTimeKind.Local).AddTicks(1714), "Goddman", null, null, "00110582594", 2, null, "kgoddmano" },
                    { new Guid("96a2576b-bb7d-4c47-80c4-85100f38a67e"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$XkL.JbORzE6bpaRnSgLeC.KocGUR/Odiny6Q.YLwXGu4Hb18L1f/i", null, false, new DateTime(2023, 4, 15, 0, 0, 31, 960, DateTimeKind.Local).AddTicks(7155), "Brockelsby", null, null, "04963800585", 1, null, "jbrockelsby1q" },
                    { new Guid("9a588720-a64e-40fc-9675-26bdfe5f955a"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$BVMQk8ym2xJUkJOwxrClNeJylUd4lOxm4F2Rj36gVs9OPooFOTVrG", null, false, new DateTime(2023, 4, 15, 0, 0, 31, 789, DateTimeKind.Local).AddTicks(6377), "Rameaux", null, null, "0213510408", 2, null, "vrameaux1p" },
                    { new Guid("9d682b9a-a954-4f04-96d2-cc906455a478"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$Q54xxcbTnHPa/2WbxGu3AO13QW23xxnI1IRfOoBJ0UqifutLSjdGW", null, false, new DateTime(2023, 4, 15, 0, 0, 35, 36, DateTimeKind.Local).AddTicks(5743), "Izhakov", null, null, "05872358652", 1, null, "cizhakov2e" },
                    { new Guid("a2d0ca3f-be6b-489f-9405-213dda04f4ac"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$0jIq2jwxrIV/taKP9/nosuCMH0YTQyMf7VsHzw/WPi7MuMFUX2orK", null, false, new DateTime(2023, 4, 15, 0, 0, 34, 648, DateTimeKind.Local).AddTicks(9217), "Spaldin", null, null, "0596030481", 1, null, "mspaldin2b" },
                    { new Guid("a4b97d7e-6cdf-4339-a594-54e1e72babd6"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$wFys4YwJ/8byamEDg4g8ie4WXmChDb7qQFzPCIJmGFyHMTiijltVO", null, false, new DateTime(2023, 4, 15, 0, 0, 35, 315, DateTimeKind.Local).AddTicks(5945), "Fitzhenry", null, null, "04780696921", 1, null, "afitzhenry2g" },
                    { new Guid("a9471fa2-73ce-476b-a7c0-4abdcba61baa"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$TN8AOc8ewhL5o3Dxu5YJLuJjHehpFIaBx49JU2r1aCZmUVoXJi9OG", null, false, new DateTime(2023, 4, 15, 0, 0, 37, 684, DateTimeKind.Local).AddTicks(8871), "Abrahamsohn", null, null, "08144581503", 1, null, "babrahamsohn2y" },
                    { new Guid("aa4f5736-77de-4364-b852-1355fa438189"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$IAakyEVuKfMvcira7lTiA.Trl/4qkYH6eNxqzMUH91bUHwYb9/RcW", null, false, new DateTime(2023, 4, 15, 0, 0, 27, 421, DateTimeKind.Local).AddTicks(812), "Bolver", null, null, "0361641052", 2, null, "bbolverq" },
                    { new Guid("aeaaa147-e9f8-49ee-ab30-8c86f5f4f433"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$v6jeFCMokxsabwhdYCScvOkVXbhlNMXsEgqd.geRgcdW.wJKp87IK", null, false, new DateTime(2023, 4, 15, 0, 0, 29, 799, DateTimeKind.Local).AddTicks(901), "Martugin", null, null, "02340159874", 2, null, "smartugin19" },
                    { new Guid("b2a89f7a-9e6a-4f2d-ab22-7ca627acd4d3"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$MlSc84EMqBlmY3OonmNz0.GiD63n9jlF/C/6z7edTDEtRMBzNmdSK", null, false, new DateTime(2023, 4, 15, 0, 0, 31, 640, DateTimeKind.Local).AddTicks(1907), "Ormerod", null, null, "02807987147", 1, null, "oormerod1o" },
                    { new Guid("b383be22-e2f8-468f-b52e-dcbeacff8bce"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$cjwcXz2hh3QZVyGqkFMBtelIpZ8D/C.bF2gXmKnSv4M2Ni5B/44jW", null, false, new DateTime(2023, 4, 15, 0, 0, 28, 905, DateTimeKind.Local).AddTicks(8006), "Dolder", null, null, "0857765771", 2, null, "pdolder12" },
                    { new Guid("b44bc3b9-6fdb-445e-86d2-3a4ca492387c"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$FLjB60SKpXB8/VozXn/o7uUSNVC8VYKrDf5WcoJsOGHU7nvLyAPC2", null, false, new DateTime(2023, 4, 15, 0, 0, 29, 676, DateTimeKind.Local).AddTicks(910), "Strooband", null, null, "0129884328", 1, null, "tstrooband18" },
                    { new Guid("b68f5b1e-9d9d-43b3-9cc7-dc3e255adc1e"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$GhlYXr6rkoaY16pX7T.l7.t9HWvD8OSUB44n9MPRrdby2.RBtfhZS", null, false, new DateTime(2023, 4, 15, 0, 0, 34, 349, DateTimeKind.Local).AddTicks(6233), "Hargitt", null, null, "04664308348", 1, null, "ahargitt29" },
                    { new Guid("b89057c2-cd30-40f4-ab59-01319aede82a"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$hKGNJ9lQ.ovdISvs09oXIuZcdJLKEqVIDHshpAyNi7OFcifhgUcEq", null, false, new DateTime(2023, 4, 15, 0, 0, 32, 100, DateTimeKind.Local).AddTicks(9636), "Hallard", null, null, "03332477053", 2, null, "mhallard1r" },
                    { new Guid("b960076c-8027-4412-a194-2d9f6174b16d"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$S.bWmkfK6V6HYbYnD.K.Du3Co.VIIB33KvjVKDGQOBgVeMDM1l0rS", null, false, new DateTime(2023, 4, 15, 0, 0, 29, 916, DateTimeKind.Local).AddTicks(8859), "Milton-White", null, null, "0602588523", 2, null, "jmiltonwhite1a" },
                    { new Guid("ba9fe55c-4230-4b78-b980-0fab2bd41ebe"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$3AaR3ZAniX7Exwl7.drrbeuLNZyk9nOzRaQ5XscJLWYQlBXuCfXcK", null, false, new DateTime(2023, 4, 15, 0, 0, 26, 798, DateTimeKind.Local).AddTicks(621), "McCloy", null, null, "08418620623", 2, null, "tmccloyl" },
                    { new Guid("bb6973db-1f17-47db-8e6b-fb2803742029"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$S.dDCr/0ayoLkQ1z2f.WsO9KWtPG5LJSK6fmnqymq5JhNoZpsh0dm", null, false, new DateTime(2023, 4, 15, 0, 0, 28, 785, DateTimeKind.Local).AddTicks(565), "Dreossi", null, null, "03724370545", 2, null, "cdreossi11" },
                    { new Guid("bcbd0b98-18f9-41f8-94c5-0b657bea4385"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$ML4TKeaoHrxV5X//BJhmNO8T7zejYB48Gyd35jMApdXyuqR5pBS8C", null, false, new DateTime(2023, 4, 15, 0, 0, 36, 868, DateTimeKind.Local).AddTicks(3067), "Yuille", null, null, "00670067189", 2, null, "ryuille2s" },
                    { new Guid("bf8589b5-5ba7-4181-890b-b73e1a10bc99"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$SkMl/7yNqcYOgKaT/DCpc.s.lbC8jJNCr3lRCyrLYDidct2.KGgMe", null, false, new DateTime(2023, 4, 15, 0, 0, 33, 821, DateTimeKind.Local).AddTicks(6461), "Lannen", null, null, "04000508789", 1, null, "dlannen25" },
                    { new Guid("c0b9f331-346c-4f1a-ae80-f457b7750da8"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$/qUaj6Ty1Ol.Zsg0m9PpwOwim3iFDjYCWXL1HCS28Nq4HiFsQ6lpK", null, false, new DateTime(2023, 4, 15, 0, 0, 36, 435, DateTimeKind.Local).AddTicks(5603), "Vernall", null, null, "05157407415", 1, null, "overnall2p" },
                    { new Guid("c0ea3f06-ed4a-4720-9ad5-2cbe12a4040c"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$p2tMiSeo2A/o6P42xdPxYOaPVV/glb6OFiw7ZfEHONmRGimIRMesq", null, false, new DateTime(2023, 4, 15, 0, 0, 36, 692, DateTimeKind.Local).AddTicks(7301), "Iacovacci", null, null, "0770070777", 1, null, "siacovacci2r" },
                    { new Guid("c10dc26f-25c6-477a-95a5-f81f2ea025c7"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$xMbMyv71V11w4OPulYQuEurUCi9.q6y.FVYmWC46Kg6D/I8i4NMS2", null, false, new DateTime(2023, 4, 15, 0, 0, 35, 795, DateTimeKind.Local).AddTicks(9934), "Howland", null, null, "00133370415", 1, null, "lhowland2k" },
                    { new Guid("c24e1aa9-3c1c-4baf-86a3-76d652eb5696"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$DIr8sAQ2d2/cr2JBFEl9XerwnLknl0JgUAQ/U/tOs7bDm69w8tZJy", null, false, new DateTime(2023, 4, 15, 0, 0, 34, 202, DateTimeKind.Local).AddTicks(8232), "Canti", null, null, "07734012207", 1, null, "gcanti28" },
                    { new Guid("c2e25e31-beed-4893-bedc-b7170d06c138"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$oJ.sIgCLPgedMXKfmAZfa.JDN1YdgIgNRsvrmJOrvTgYFSIm4KQ8.", null, false, new DateTime(2023, 4, 15, 0, 0, 32, 345, DateTimeKind.Local).AddTicks(9834), "Trippitt", null, null, "00615614760", 1, null, "atrippitt1t" },
                    { new Guid("c9d40774-eeb9-426b-8972-1fd8fc1506f9"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$zwmCioeUzZ9g3gb/a09QSurkQFIcrLfqxhAd5dl2Luzmdc.Ss4SDy", null, false, new DateTime(2023, 4, 15, 0, 0, 27, 658, DateTimeKind.Local).AddTicks(9060), "Beament", null, null, "0756962604", 2, null, "obeaments" },
                    { new Guid("cf2169d5-f028-4a60-bdf0-4637aa9c6c46"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$qLJcHUBQacY8Hi1NiOqSd.6s2NpwsTWuH828S.94kk8Q.NsnkhB2.", null, false, new DateTime(2023, 4, 15, 0, 0, 29, 30, DateTimeKind.Local).AddTicks(7373), "Cantor", null, null, "0218299981", 1, null, "jcantor13" },
                    { new Guid("d0e5a133-93b0-49c6-ae63-66d98c7842f0"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$vrMBTh5sjAUbxh2RX1vJ5ObJh9W04ki3OcujW9vnWMQb4BdFO4L9i", null, false, new DateTime(2023, 4, 15, 0, 0, 35, 917, DateTimeKind.Local).AddTicks(4603), "Gasperi", null, null, "03723162025", 2, null, "ogasperi2l" },
                    { new Guid("d3837e15-a4ff-4a93-803b-b750c2ea078a"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$N0ioAsnquizZsqIjotBLxuG8.GG/lA/TwXn2nE787j6ytLKnMY5JC", null, false, new DateTime(2023, 4, 15, 0, 0, 26, 674, DateTimeKind.Local).AddTicks(6247), "Garrioch", null, null, "0072752247", 1, null, "mgarriochk" },
                    { new Guid("d48e748f-d4b5-4fe6-bccb-7051fdf1090c"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$Bgw7LUN5SA4mKM/e2WnlqO0R57FRCPa1sG0Btk09GYnV2JuOiAGlu", null, false, new DateTime(2023, 4, 15, 0, 0, 27, 913, DateTimeKind.Local).AddTicks(2932), "Harnott", null, null, "00039497181", 2, null, "mharnottu" },
                    { new Guid("d5454223-d0ec-4c88-8ef8-20d3af073a4c"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$VIWi8kvPzWyJK4fONWzqO.LAk44J.QuxP7wjXvDD//cw6t/kzm3Ta", null, false, new DateTime(2023, 4, 15, 0, 0, 34, 776, DateTimeKind.Local).AddTicks(1982), "Jilkes", null, null, "00677856497", 2, null, "bjilkes2c" },
                    { new Guid("e3e5aba9-b4e6-4f9f-b355-e00d8e0e76eb"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$eXrergHEFN9V4FciQV5JdeDQeqfUhs7443JA4Ytbr71Tfql5gA8OC", null, false, new DateTime(2023, 4, 15, 0, 0, 28, 389, DateTimeKind.Local).AddTicks(8619), "Springham", null, null, "00834111266", 1, null, "sspringhamy" },
                    { new Guid("f064f7ee-1bb4-49f8-a987-2b03d6b5610d"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$rZuqR/bKG00ibb.fXN47e.sHv9UodUKW3mfKhKY0tADz.QqfYLoe.", null, false, new DateTime(2023, 4, 15, 0, 0, 33, 244, DateTimeKind.Local).AddTicks(6745), "Oliffe", null, null, "0002143579", 1, null, "koliffe20" },
                    { new Guid("f3a91c53-eb0e-4b13-8e14-6ef2007a84c5"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$B/ZwFnyjQ0T/kEp6NHqqou0RKgI5IYfdVpWKz9H2DFV9c0NGkXBXy", null, false, new DateTime(2023, 4, 15, 0, 0, 30, 994, DateTimeKind.Local).AddTicks(961), "Shufflebotham", null, null, "0960301131", 2, null, "pshufflebotham1j" },
                    { new Guid("f409e73c-bdc8-4e88-a573-afa6b6f8acb8"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$3CbqqDXtRc217LSDH09cz.Weirx080CIzkCclVc9wEGcaOoPpD1p2", null, false, new DateTime(2023, 4, 15, 0, 0, 32, 504, DateTimeKind.Local).AddTicks(7970), "Scirman", null, null, "0195375651", 1, null, "ascirman1u" },
                    { new Guid("fb110b84-6e04-472f-b7b2-6bd011455a91"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$GvIN.Q6VQP0/f3ln.4V2JeAxOz8gNi9kYpch/.RsK8fI9QVccQbKy", null, false, new DateTime(2023, 4, 15, 0, 0, 37, 411, DateTimeKind.Local).AddTicks(6198), "Bolliver", null, null, "0699230163", 2, null, "sbolliver2w" },
                    { new Guid("fd57ad04-00ec-4cf4-a475-4d17d10d1f85"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$tItYr62CPn8.ATE98X2YGOb6oWq3EHxYR3yKXmsiAy7qUBHI2vpua", null, false, new DateTime(2023, 4, 15, 0, 0, 35, 158, DateTimeKind.Local).AddTicks(1297), "Eliassen", null, null, "06497524328", 1, null, "jeliassen2f" },
                    { new Guid("ffacedc1-c0b5-4036-a2fe-c528f4a93f29"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$2TSIryPWiMIsN61MUYiea.ShqAztzq7evPOTqs/V1oKKy2Cm54.Ea", null, false, new DateTime(2023, 4, 15, 0, 0, 32, 882, DateTimeKind.Local).AddTicks(8447), "Stranger", null, null, "03239623484", 2, null, "gstranger1x" }
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
