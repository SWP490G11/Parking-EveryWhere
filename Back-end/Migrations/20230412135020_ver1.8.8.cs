using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver188 : Migration
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
                    { new Guid("4bf2ff70-90f1-425e-8614-2f153154b837"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("591c03de-40de-4f0b-946b-3814f3ce0982"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("59da471e-92cc-4112-a2a3-921ec6f1607f"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("8ab16a94-f18d-4bb9-b924-0ae50d9829b6"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("d7e701fa-66cd-475b-a750-d7f617d3f36c"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("ed296ba4-cc6e-444d-aafc-ffb229af9a3a"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("bd4627fd-0dc6-42d4-a503-777ac1ab3a9f"), "1 Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12L, "Long", 130000.0 },
                    { new Guid("bdd2e37a-e13b-4d37-89cc-57b686125b13"), "Half Year", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, "Medium", 70000.0 },
                    { new Guid("f9cf584b-5d17-4ead-a822-7b2473eff853"), "Short time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, "Short", 40000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "ImageID", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "TransactionID", "UserName" },
                values: new object[,]
                {
                    { new Guid("00fbc0d3-efb3-4373-b538-0233ba8e896d"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$kPBt5b2tVMca6v/gQotzhOykRAVlyN5F00J7SL7rvodz/F5dq6R.2", null, false, new DateTime(2023, 4, 12, 20, 50, 17, 460, DateTimeKind.Local).AddTicks(2443), "Iacovacci", null, null, "0770070777", 1, null, "siacovacci2r" },
                    { new Guid("0135cfe3-dfdd-4d98-85dd-4f395e873939"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$rgbVCtCj4LN5.aYPonHk9.0KP3/7YGvA58RkS9euPZoF83.ATUKrO", null, false, new DateTime(2023, 4, 12, 20, 50, 5, 554, DateTimeKind.Local).AddTicks(1105), "Kroch", null, null, "09201855247", 1, null, "okroch16" },
                    { new Guid("013fbbb8-45da-495f-9678-1a46dcea87d8"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$PxEN2sMD/HOemmOZ0HD/7ehkfCHlR3Q0dtJskddhgvkjt.5Dl9unG", null, false, new DateTime(2023, 4, 12, 20, 50, 10, 62, DateTimeKind.Local).AddTicks(9881), "Hallard", null, null, "03332477053", 2, null, "mhallard1r" },
                    { new Guid("046a02a9-854e-4d22-bac6-12004e8b2cfe"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$NBxchyypDdtcXD9bhmHZ1.0PDXF76IoikryFSP8xjAAmT8c9NJUja", null, false, new DateTime(2023, 4, 12, 20, 50, 10, 820, DateTimeKind.Local).AddTicks(8896), "Zamorano", null, null, "0619225384", 2, null, "czamorano1v" },
                    { new Guid("0491dfad-1c70-4ccf-829a-d5167c6e03dd"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$1R04oWTFfElsDm9c3h/BXOnu6ALBBwVm1p3PIFYqS2KFh2VvCpy56", null, false, new DateTime(2023, 4, 12, 20, 50, 14, 682, DateTimeKind.Local).AddTicks(6036), "Jilkes", null, null, "00677856497", 2, null, "bjilkes2c" },
                    { new Guid("04c0a97d-6b9d-49bd-b1e7-72a3775c1c3b"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$xck/IxNBxDw1p3UXb3QVwuf/rusIdKqqOebpkp8Mivauai/kdYbgm", null, false, new DateTime(2023, 4, 12, 20, 50, 8, 31, DateTimeKind.Local).AddTicks(6946), "Ashpole", null, null, "03667705539", 1, null, "kashpole1h" },
                    { new Guid("09272266-abc4-4c38-a4c1-6b58cb8ca897"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$otCoMD3VShpENU7fw0R2XunfmA5yQhJsxfKQMz28aabP3.sqIQuee", null, false, new DateTime(2023, 4, 12, 20, 50, 12, 374, DateTimeKind.Local).AddTicks(7452), "Webley", null, null, "0821411907", 1, null, "jwebley22" },
                    { new Guid("0c7fd921-10d3-473d-abfc-b7dd1866cf21"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$0FPMFKzztaxAzK.2dWxK/.MHu9xSXTR/tshvByYULj27oz2ID5BFS", null, false, new DateTime(2023, 4, 12, 20, 50, 18, 834, DateTimeKind.Local).AddTicks(7508), "Abrahamsohn", null, null, "08144581503", 1, null, "babrahamsohn2y" },
                    { new Guid("0e3f958c-a73d-474b-b495-b279fdc87c26"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$/Z7gKv7VS72nLx/TIyoZKeq4gVpuZlYb.Fd4DK1OTde/rnMtYFyly", null, false, new DateTime(2023, 4, 12, 20, 50, 16, 7, DateTimeKind.Local).AddTicks(27), "Petrescu", null, null, "0719013924", 1, null, "bpetrescu2j" },
                    { new Guid("0fc8aaef-e856-4e7d-8a41-0b80840f19da"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$BHVm3SGcTjx/GoZKxL9qsOjbNxkg2ZsW38HLRtwJwbZXAh.YXRz52", null, false, new DateTime(2023, 4, 12, 20, 50, 12, 624, DateTimeKind.Local).AddTicks(6867), "Scheffel", null, null, "0355632555", 2, null, "hscheffel23" },
                    { new Guid("104ba001-4f98-4430-84c0-2c743a8f57df"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$a9eQYlQHvd0jX3h3by8a/etHT5gyZYwi/jS7tjhuWRaSnPEnraUTG", null, false, new DateTime(2023, 4, 12, 20, 50, 2, 279, DateTimeKind.Local).AddTicks(1014), "Beament", null, null, "0756962604", 2, null, "obeaments" },
                    { new Guid("16bd9964-19fb-48a2-947d-d250e66bec43"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$FdO4RDS.2/LEr7jzwmIN5.jgwELsN41EMo773CsY4tuclFPIo/9Xq", null, false, new DateTime(2023, 4, 12, 20, 50, 16, 480, DateTimeKind.Local).AddTicks(7244), "Barhem", null, null, "08054760577", 1, null, "sbarhem2m" },
                    { new Guid("16cf0340-6b6c-4844-b14c-d82490ad6069"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$BU/dFi6wkxSOXAyB7nY7Ze9ztum59eVRyV1wqCg.lAciGSZDNj26K", null, false, new DateTime(2023, 4, 12, 20, 49, 59, 532, DateTimeKind.Local).AddTicks(7689), "Lavens", null, null, "06895509784", 2, null, "rlavensh" },
                    { new Guid("1a431591-0a12-4e8f-b549-1b6ce5c9cbc7"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$TQd0.47ls8haJ4ffCvbfjOmi/Qa1K4ZCsY1HGFYegD0JBUp6xHzo6", null, false, new DateTime(2023, 4, 12, 20, 50, 8, 780, DateTimeKind.Local).AddTicks(4266), "Berks", null, null, "04613021719", 2, null, "fberks1l" },
                    { new Guid("1a4ae700-cb66-4ef2-afc5-66eb6399b1d2"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$6X6d1Tq3m2Q2gc2BOGDMa.l/ix2gRMWPjA9Aj1Mqfo6gR4eUwRmPC", null, false, new DateTime(2023, 4, 12, 20, 50, 19, 627, DateTimeKind.Local).AddTicks(9851), "Prater", null, null, "0629137900", 1, null, "tprater32" },
                    { new Guid("1c294f67-f229-45c3-b95f-004688fa0eea"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$aOu6MQYZhPGhGLhOWRZpJOHb39Grt/csxx0qou5p0O4NvCZgYcHxC", null, false, new DateTime(2023, 4, 12, 20, 50, 4, 150, DateTimeKind.Local).AddTicks(1351), "Briston", null, null, "02637402338", 2, null, "cbriston10" },
                    { new Guid("1d6d13de-697d-45b0-b1c2-05ca7d5d3237"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$/zH3/5WgR3wnH84WUk1v8.9OP2CjFw3hv/3yNusCgsXp3x8VT54M2", null, false, new DateTime(2023, 4, 12, 20, 50, 3, 191, DateTimeKind.Local).AddTicks(9206), "Lere", null, null, "04037990815", 1, null, "rlerew" },
                    { new Guid("1ef895e8-0d61-4013-a85f-f1cef0067c7f"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$8vwTPA/jLezZywFoOGzqiee8uwt7nJf0DTQKNJitx.0yq4ck65q6q", null, false, new DateTime(2023, 4, 12, 20, 50, 2, 741, DateTimeKind.Local).AddTicks(1042), "Harnott", null, null, "00039497181", 2, null, "mharnottu" },
                    { new Guid("2d401720-e43a-4cf7-84db-6e3d9797f20f"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$XG1RVyIKunkt3z3bTUhOeeenxlYY30p1IXWAnaq5.PDyrQBFslpiW", null, false, new DateTime(2023, 4, 12, 20, 50, 9, 705, DateTimeKind.Local).AddTicks(1087), "Rameaux", null, null, "0213510408", 2, null, "vrameaux1p" },
                    { new Guid("2f83ef88-3da7-4301-a478-3effa1cf1eba"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$jiKe6b3jjVulKAIMbPr/uueRDJrg5wlDzn8SB3e441N4kyAqTbTfe", null, false, new DateTime(2023, 4, 12, 20, 50, 6, 432, DateTimeKind.Local).AddTicks(5163), "Milton-White", null, null, "0602588523", 2, null, "jmiltonwhite1a" },
                    { new Guid("30119dd4-ae58-4821-9930-175c9f57b8e1"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$IFgcfZ85eEa1s0RGM03i8eVuIGjDnFv2SUPuN1sz0GBmmbwIVLHom", null, false, new DateTime(2023, 4, 12, 20, 50, 18, 473, DateTimeKind.Local).AddTicks(5265), "Bolliver", null, null, "0699230163", 2, null, "sbolliver2w" },
                    { new Guid("34247ab6-c0eb-4341-9bfd-4703862bbfea"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$PtiCDxBw/JbiHxMKHov/g.YHmY7c6BFFgJbKPj7ZCUcH4d8Oa7njW", null, false, new DateTime(2023, 4, 12, 20, 50, 16, 650, DateTimeKind.Local).AddTicks(8387), "Saban", null, null, "02156386100", 1, null, "csaban2n" },
                    { new Guid("3612eebe-72fa-4a6f-b488-22b9c4b9cba4"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$DXNB7YA3dzbUhaEHrEdAS.UAvDEnZ1KfLFvxABIAly6RHggQIa1DK", null, false, new DateTime(2023, 4, 12, 20, 50, 10, 628, DateTimeKind.Local).AddTicks(4064), "Scirman", null, null, "0195375651", 1, null, "ascirman1u" },
                    { new Guid("3ba027bd-43fc-4e37-a535-beff1dde7d29"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$VccsPR476xvhjC.LvEHD9Ome6zkQ7QDaXZpvWCh2cK5tK9HnyiwEi", null, false, new DateTime(2023, 4, 12, 20, 50, 0, 302, DateTimeKind.Local).AddTicks(7058), "Garrioch", null, null, "0072752247", 1, null, "mgarriochk" },
                    { new Guid("404f7227-4736-422b-98b4-0f04b44a7cd4"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$.adBGIt2tyOeG5g3ZTHNo.UIfH6uOQguzAT.l.qurg35anZAX9qV.", null, false, new DateTime(2023, 4, 12, 20, 50, 17, 1, DateTimeKind.Local).AddTicks(8930), "Vernall", null, null, "05157407415", 1, null, "overnall2p" },
                    { new Guid("42aeb385-11cd-450f-9055-396d4f8dd1b7"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$MKaQIm/t2WTFBaLWgMdn0OoC/5fvKPKvlqs.Ub178F6vI0brORG.m", null, false, new DateTime(2023, 4, 12, 20, 50, 7, 374, DateTimeKind.Local).AddTicks(1239), "Laidel", null, null, "06837677860", 2, null, "blaidel1e" },
                    { new Guid("43bf55d3-80aa-42c0-9ad6-7a6334e26641"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$zZZyC6I9sEFa5xgSkf9T.eb1OQ14M36a1Kbhb1PNJxytx.aRQxef.", null, false, new DateTime(2023, 4, 12, 20, 50, 0, 762, DateTimeKind.Local).AddTicks(1697), "Maddyson", null, null, "0915548406", 2, null, "cmaddysonm" },
                    { new Guid("445f5e36-a6b8-43e5-8449-c5f7e6650f3f"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$wQSdUFyH6ZLxIx/9xLwSfOqsnwpWO1rC0L.o5k.B3Q/vwbc94cO1u", null, false, new DateTime(2023, 4, 12, 20, 50, 9, 224, DateTimeKind.Local).AddTicks(3153), "Hannen", null, null, "06533305742", 2, null, "channen1n" },
                    { new Guid("47359110-1933-4889-9aec-b605627ea797"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$w.AJm/0XwQGYGDkQsrWyouqO.dTHzi7OTVmTSxLL2BzUM0jnsOVIm", null, false, new DateTime(2023, 4, 12, 20, 50, 10, 234, DateTimeKind.Local).AddTicks(3019), "Webling", null, null, "0390471753", 2, null, "bwebling1s" },
                    { new Guid("476f1b5c-13cf-4920-911b-7bc32229c858"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$hAM6bWx0zIylZm9F5B6kAO48pvpTpyClICcaGXYrgJFHTexzyzjqK", null, false, new DateTime(2023, 4, 12, 20, 50, 1, 27, DateTimeKind.Local).AddTicks(7596), "Skirvin", null, null, "0614302061", 1, null, "mskirvinn" },
                    { new Guid("48b1f1fd-58fd-489e-b67c-39620a2c391c"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$odK3tT7xamXk04y6Qyuc/uC.msv2rjwvZysy4ihM8hNTX6AIrHiQq", null, false, new DateTime(2023, 4, 12, 20, 50, 2, 41, DateTimeKind.Local).AddTicks(6875), "Featherstonhaugh", null, null, "0737666977", 2, null, "dfeatherstonhaughr" },
                    { new Guid("4b8ee3f8-b500-4070-b0a3-1a0390bc5e90"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$e0cA2pIOZHBIPvK61GDi3eDP2rhwGUitTP0S3p8k8P31qSHr8IcTq", null, false, new DateTime(2023, 4, 12, 20, 50, 15, 264, DateTimeKind.Local).AddTicks(4143), "Eliassen", null, null, "06497524328", 1, null, "jeliassen2f" },
                    { new Guid("546cab10-8925-499f-b009-41f17b6defcc"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$MI23itKPXPTyQh4nKwE3VeO2DGc8iGW6PHqLnyK.0gL1F38LZ3Cli", null, false, new DateTime(2023, 4, 12, 20, 49, 59, 749, DateTimeKind.Local).AddTicks(372), "Martinyuk", null, null, "0766805261", 2, null, "nmartinyuki" },
                    { new Guid("54b35693-1e00-4419-b08a-b423085c6000"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$DuTYY9bV04W8YIN5CbEhUeR8ARamMmwXlPZbLfAb/eaMF698/y59W", null, false, new DateTime(2023, 4, 12, 20, 50, 4, 856, DateTimeKind.Local).AddTicks(5799), "Cantor", null, null, "0218299981", 1, null, "jcantor13" },
                    { new Guid("55503b60-75b3-48b7-95b3-c757aee81a13"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$2EQ0ZdOsxTfAScwaku0a7uP.2GrkRiiySxYnsSWb1ZbcwXIDQnw6K", null, false, new DateTime(2023, 4, 12, 20, 50, 3, 432, DateTimeKind.Local).AddTicks(5577), "McKinlay", null, null, "03957603316", 2, null, "dmckinlayx" },
                    { new Guid("5910f32e-2d2c-4b94-a5b0-9f2e785ca008"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$H3Xk3XMxeB2JV3rgDWc8hOFq35S2XyHDWleMOHJz1Qz58dlANfe/i", null, false, new DateTime(2023, 4, 12, 20, 50, 11, 253, DateTimeKind.Local).AddTicks(7756), "Stranger", null, null, "03239623484", 2, null, "gstranger1x" },
                    { new Guid("5bb16ca1-a6ec-4176-a0d7-cd3688e4b86f"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$GfxNJFtUW.Knl5v8B/0L7u4bGhRfJ3XocQ3kv41Z35/EzfJDkESc2", null, false, new DateTime(2023, 4, 12, 20, 50, 8, 179, DateTimeKind.Local).AddTicks(7231), "Mackieson", null, null, "07046670689", 2, null, "smackieson1i" },
                    { new Guid("5d6878cf-2085-4517-91a1-3c1cdba62802"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$qVlWgbiBoSavOSFDriptc.R2muenbMmKQDBqXE0gUu33YsTiw39Fq", null, false, new DateTime(2023, 4, 12, 20, 50, 8, 366, DateTimeKind.Local).AddTicks(6933), "Shufflebotham", null, null, "0960301131", 2, null, "pshufflebotham1j" },
                    { new Guid("5fd8ddbd-1b0d-4eaa-914c-9581b3833863"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$OmZ5KDHqzNFfwPrFLb.jbubmI1B9Mo27ZNHUOJIHiM8vO9fcyqD4.", null, false, new DateTime(2023, 4, 12, 20, 50, 8, 536, DateTimeKind.Local).AddTicks(7334), "Droghan", null, null, "0910618733", 2, null, "kdroghan1k" },
                    { new Guid("61acca45-c66f-4624-a943-d4a39a4da71c"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$n1xrt7eSac5LJCIGiXJsfOLSVxjCkgtMOj8YNQ3/vvH8A5/dGBO5m", null, false, new DateTime(2023, 4, 12, 20, 49, 58, 398, DateTimeKind.Local).AddTicks(1943), " Nguyen Van", null, null, "0966416708", -772000, null, "phucnv" },
                    { new Guid("638f4c35-10a2-416a-b858-8f19789fd6c8"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$NOGRgDUdXmuJX9TyIN3jluA7Fwv01sBx2Q8qwWU2CDGabl/W6RjNi", null, false, new DateTime(2023, 4, 12, 20, 50, 13, 250, DateTimeKind.Local).AddTicks(7914), "MacKegg", null, null, "05989129010", 2, null, "wmackegg26" },
                    { new Guid("65392370-40ce-4566-8a06-b8ca666236d7"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$o9SmQ2cuRaDfNiF.WWX6lerKuHCKxSzIf1y/5G2bch589yWfkPupy", null, false, new DateTime(2023, 4, 12, 20, 50, 18, 114, DateTimeKind.Local).AddTicks(6630), "Gonzalo", null, null, "0459531972", 2, null, "lgonzalo2u" },
                    { new Guid("6a9f041a-dd28-469c-b8d1-ece3c5817cf7"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$PFuuWio7bmhQ0ev0GeuQVeJs/cfsMVutb41mds1zP/MtJ9hM8pt4K", null, false, new DateTime(2023, 4, 12, 20, 50, 19, 16, DateTimeKind.Local).AddTicks(4570), "Beamson", null, null, "07242980517", 1, null, "kbeamson2z" },
                    { new Guid("6e47fc2e-4499-4d6b-9291-ca084438ef46"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$5616ehbMXR2BjRMtDxBysOltWfFQ4lstMbNwKUNVp4HCXex6cMh1e", null, false, new DateTime(2023, 4, 12, 20, 50, 13, 670, DateTimeKind.Local).AddTicks(3182), "Canti", null, null, "07734012207", 1, null, "gcanti28" },
                    { new Guid("6f61c40c-41db-4d3e-bc26-3460c65a6c7e"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$EWB.rgwZYUq.BAyJ7sJLV.qXzd0VAB/V9OJze.nkKEQIhw0FkPZaW", null, false, new DateTime(2023, 4, 12, 20, 50, 7, 131, DateTimeKind.Local).AddTicks(4517), "MacGorrie", null, null, "0259328059", 2, null, "kmacgorrie1d" },
                    { new Guid("6f7cb4a9-a280-4794-abda-c3bc0d46ea6b"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$Vl9FBOwu25/OKyHm1CAKwu1n.lHgFqSU1LXxUB8LAvEf4p6qG1kaC", null, false, new DateTime(2023, 4, 12, 20, 50, 16, 164, DateTimeKind.Local).AddTicks(3257), "Howland", null, null, "00133370415", 1, null, "lhowland2k" },
                    { new Guid("7001ab04-43c1-4506-9fbd-ed7790d5d96e"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$vVQQIgkx9lT.7T/HcgVPJOLSeNdNsrTzSiBOUEN5m7R5SQIHfO5VG", null, false, new DateTime(2023, 4, 12, 20, 50, 17, 668, DateTimeKind.Local).AddTicks(2434), "Yuille", null, null, "00670067189", 2, null, "ryuille2s" },
                    { new Guid("71748885-f466-45a0-a392-9287de363db6"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$BFs768un1knnfCHiPT7yNe7XSYuUQz9IZIxKIR5PvxOwXaDUUzgX2", null, false, new DateTime(2023, 4, 12, 20, 50, 2, 534, DateTimeKind.Local).AddTicks(8890), "Gostick", null, null, "05617299637", 1, null, "bgostickt" },
                    { new Guid("740661a6-3e86-4a45-b5c3-c3748a644329"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$rfU7u3JqYsg1EwSWpXCXB.hRdTHM5ikSmwT1IIgtNWR2d3fNSUzHC", null, false, new DateTime(2023, 4, 12, 20, 50, 5, 793, DateTimeKind.Local).AddTicks(9536), "McMechan", null, null, "0613503781", 2, null, "mmcmechan17" },
                    { new Guid("745ca954-2d55-4f5e-8caf-0e0aabcbc2fd"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$.0uP5SbTYjLRIRW2uSoitufdp2B1hRx1O8X5lTQLIe46IHntvLk.m", null, false, new DateTime(2023, 4, 12, 20, 50, 14, 443, DateTimeKind.Local).AddTicks(1395), "Spaldin", null, null, "0596030481", 1, null, "mspaldin2b" },
                    { new Guid("79568f89-a339-418c-891b-f9897ef7d221"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$nTbz/icSAWVXqFxrWaz9ReeW5sgiNphYMhEd2LtuoSbUU41C1QZ7u", null, false, new DateTime(2023, 4, 12, 20, 50, 4, 390, DateTimeKind.Local).AddTicks(7404), "Dreossi", null, null, "03724370545", 2, null, "cdreossi11" },
                    { new Guid("7c81e33a-dfb8-4aec-aa08-31717740de19"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$VuWL.zUWiA9eHvoYjEHVW.K0LrekUbkbZ7Egz54aUUAUVVtAQm6NO", null, false, new DateTime(2023, 4, 12, 20, 50, 12, 144, DateTimeKind.Local).AddTicks(6795), "Latan", null, null, "07949258154", 1, null, "rlatan21" },
                    { new Guid("87b34f37-6c93-49c4-a465-2f4aa408ca7e"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$PnaNhGKkfaesSqReMUoNV.BMOgDfocILsoGL8pGEtvVHUdUlLsiwK", null, false, new DateTime(2023, 4, 12, 20, 50, 6, 195, DateTimeKind.Local).AddTicks(3581), "Martugin", null, null, "02340159874", 2, null, "smartugin19" },
                    { new Guid("87eb30e6-7b83-40d6-b57d-9b3cd4df16c8"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$5v4Y.tdQVhaiPhPbqwSzl.TaIi69YsYXYeuqZZGkMM4F0q0ogXmZe", null, false, new DateTime(2023, 4, 12, 20, 50, 10, 427, DateTimeKind.Local).AddTicks(2677), "Trippitt", null, null, "00615614760", 1, null, "atrippitt1t" },
                    { new Guid("89b5779a-2773-42fe-956c-f17f91f463f8"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$cGFMqGtbVfbHX4FbA21D3OzjtUA5AzAB163Xdi9T4qU0znyDX.pLq", null, false, new DateTime(2023, 4, 12, 20, 50, 11, 466, DateTimeKind.Local).AddTicks(6607), "Batrip", null, null, "0734926905", 1, null, "abatrip1y" },
                    { new Guid("8c766695-8673-4d49-84c9-594e0ce406d8"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$mvnvwVNby6.ID7sGVGp1beQNxzV5OWXpWrsVuONP4uRtje4y9HHae", null, false, new DateTime(2023, 4, 12, 20, 50, 0, 543, DateTimeKind.Local).AddTicks(7330), "McCloy", null, null, "08418620623", 2, null, "tmccloyl" },
                    { new Guid("902c379a-0409-41b5-9802-48feec25093d"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$290TwwwUIqeOtnGiNRBhhOh2QFmLKKDlWOgGhJzOK2Bl234JqRMEm", null, false, new DateTime(2023, 4, 12, 20, 50, 17, 909, DateTimeKind.Local).AddTicks(2581), "Brechin", null, null, "0285671009", 1, null, "lbrechin2t" },
                    { new Guid("934dc2b5-8702-4d16-abdc-0b0513e8830d"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$cfh5xv69MCiH9/DrWAMuEOjWSPqezZY0/k1YPOm91iW7Us9ZP.XgC", null, false, new DateTime(2023, 4, 12, 20, 50, 17, 237, DateTimeKind.Local).AddTicks(932), "Baldacchino", null, null, "05380625199", 1, null, "mbaldacchino2q" },
                    { new Guid("93718e46-8b30-4f73-942c-adc76d9dc6e4"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$g4amu7zAsaGHBQbVRz/N7eWD5JsCmATI2JFqHsdxApY7eftgHK0D.", null, false, new DateTime(2023, 4, 12, 20, 50, 1, 264, DateTimeKind.Local).AddTicks(4977), "Goddman", null, null, "00110582594", 2, null, "kgoddmano" },
                    { new Guid("969b1060-3dba-43df-b1d4-62aa789e65cf"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$ujgBzVHIIPwIY/k1I8XOauymFVVsdHPsEBLbS4cOslAQwQgfiMsku", null, false, new DateTime(2023, 4, 12, 20, 50, 14, 886, DateTimeKind.Local).AddTicks(1593), "Faber", null, null, "08586159848", 2, null, "afaber2d" },
                    { new Guid("96e1b1ec-4876-45e1-966e-ff2965ee6aa4"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$7h9bX2XaeyAJ5dqEgYTjVebhFq9190dyZn2bnPNQ4uh2i8pFZ6Lfy", null, false, new DateTime(2023, 4, 12, 20, 50, 13, 69, DateTimeKind.Local).AddTicks(3409), "Lannen", null, null, "04000508789", 1, null, "dlannen25" },
                    { new Guid("97f6ce31-76ef-44b9-b4e8-db9c129c69e2"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$IBb7aF9LJqwbJXnD/EGcCOt8pI9wKEARKAeR/XLOlfcFpxo5UGLCy", null, false, new DateTime(2023, 4, 12, 20, 50, 7, 631, DateTimeKind.Local).AddTicks(2489), "Mattam", null, null, "0865586458", 2, null, "emattam1f" },
                    { new Guid("99098bc5-25cf-4a3d-b147-f66546d4c820"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$39gCOFx0/fES5vDRuplR/ukvSZ52VdTgkn/wr7p7X/W.SaNNSXvHq", null, false, new DateTime(2023, 4, 12, 20, 49, 59, 286, DateTimeKind.Local).AddTicks(7035), "Tubbs", null, null, "0630308378", 2, null, "gtubbsg" },
                    { new Guid("9b36e63b-14f0-4c66-a59d-f23688074ef9"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$Zt2fSrKjGgavPwR6/6WJNuRWBEM87BvsdZEjPfSGRNZodN7kxg0RW", null, false, new DateTime(2023, 4, 12, 20, 50, 7, 803, DateTimeKind.Local).AddTicks(5347), "Gareisr", null, null, "07314447051", 2, null, "tgareisr1g" },
                    { new Guid("9c5cac7f-4c62-4372-9464-f7adce85c238"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$HgjaIU2nVgN0vkdp.2NDA.lwoOKGe3.qjs3RA5m..Ysd/4THdftTm", null, false, new DateTime(2023, 4, 12, 20, 50, 15, 817, DateTimeKind.Local).AddTicks(8783), "Haney", null, null, "0041887086", 2, null, "dhaney2i" },
                    { new Guid("9e0fbd54-29fa-4fa4-935f-92d0f2c40ecb"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$5KB.hdWeKn4dMLSctN6m9OGyw22WFC3fnUozoPGCM0CQj.Z4JeK1O", null, false, new DateTime(2023, 4, 12, 20, 50, 5, 989, DateTimeKind.Local).AddTicks(9636), "Strooband", null, null, "0129884328", 1, null, "tstrooband18" },
                    { new Guid("a6d83746-0a95-4420-8166-65648f909d6d"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$/zz2ZXfoKQ7PbZGTS4Ug4.ym6u/0Mjoto8S0CndI0UhC4MuBk80MW", null, false, new DateTime(2023, 4, 12, 20, 50, 15, 610, DateTimeKind.Local).AddTicks(5149), "Oubridge", null, null, "0429461131", 2, null, "eoubridge2h" },
                    { new Guid("ab9615a0-5386-44a6-a6f2-b6406792e67b"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$2e2AxLeKUnwG6xkaFzVt/.uUQe0767FgzWgsY3gsWgFXJJKX3o41C", null, false, new DateTime(2023, 4, 12, 20, 50, 14, 177, DateTimeKind.Local).AddTicks(3063), "Ainscow", null, null, "0878444767", 1, null, "fainscow2a" },
                    { new Guid("abf6bb0b-49c5-4982-ac88-8e630c4c7995"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$cXM/qjRewICkUJssfNdRMOoz8K/bBdIqbdK2qKTNV7/xXvs/UaoNC", null, false, new DateTime(2023, 4, 12, 20, 50, 1, 506, DateTimeKind.Local).AddTicks(292), "Dunsford", null, null, "00868235500", 1, null, "rdunsfordp" },
                    { new Guid("ac2908b9-49c1-431e-a341-1bffefe8b6d4"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$Ge9lOesBpulExChk7WSKW.PVFsToga2RGH0d1JboJNXlz61barHhC", null, false, new DateTime(2023, 4, 12, 20, 50, 15, 441, DateTimeKind.Local).AddTicks(5311), "Fitzhenry", null, null, "04780696921", 1, null, "afitzhenry2g" },
                    { new Guid("acf176c1-41d9-42f7-bfd5-395553849bb1"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$m6Jo84KjKqKSDRWxsiFG3.K/GyxgOu11pTZBZwjHwvCaJiwph.udu", null, false, new DateTime(2023, 4, 12, 20, 50, 11, 726, DateTimeKind.Local).AddTicks(6940), "Kearns", null, null, "0461097167", 1, null, "skearns1z" },
                    { new Guid("b0929e02-5e5c-4af0-b4db-5154727e5be9"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$7OiM/CR1N4Snm4TS4s2QfuRjt/MeVhxrQlzg/DpktIJ63DPcvbHCu", null, false, new DateTime(2023, 4, 12, 20, 50, 11, 927, DateTimeKind.Local).AddTicks(2913), "Oliffe", null, null, "0002143579", 1, null, "koliffe20" },
                    { new Guid("b1df73c9-0625-41ee-8cef-87f85d5fa43c"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$NxwoMqUQQfZGl3KkFVLQTOxqPjCLKp2P1bXr/ghmlXyxdHtxSTXne", null, false, new DateTime(2023, 4, 12, 20, 50, 9, 448, DateTimeKind.Local).AddTicks(8151), "Ormerod", null, null, "02807987147", 1, null, "oormerod1o" },
                    { new Guid("b658a3b6-2e6a-4500-98ae-9de6538274db"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$n1Etd9KmVDo9LybDTwVuleLSBiCTWJxe1rqQrey7YT4vJrGAgGElO", null, false, new DateTime(2023, 4, 12, 20, 50, 16, 835, DateTimeKind.Local).AddTicks(4373), "Andriessen", null, null, "05873824805", 2, null, "candriessen2o" },
                    { new Guid("bf0bac43-2412-4c62-81c0-cf8465d2c188"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$iwkkLGM4WP3ezevLM38F1eduj17Lf611haQFMtSvK9DzFnX6IB/r2", null, false, new DateTime(2023, 4, 12, 20, 50, 18, 649, DateTimeKind.Local).AddTicks(3324), "Elgee", null, null, "0961523438", 2, null, "melgee2x" },
                    { new Guid("c3228500-fca6-4a0f-aa82-2be1bb275926"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$4BnBKrlNFWDW/YhfZkdGbu0nZH3qOVllSLnJO3Drsu6PoFbJRo09u", null, false, new DateTime(2023, 4, 12, 20, 50, 4, 614, DateTimeKind.Local).AddTicks(5661), "Dolder", null, null, "0857765771", 2, null, "pdolder12" },
                    { new Guid("c329f5dc-e5fa-448d-a41a-cf4e3d5d6080"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$0ZaPzAGdGW554ELcof58sehoMw3fufGXHGMwPTPreoni9MwGm2d9C", null, false, new DateTime(2023, 4, 12, 20, 50, 11, 32, DateTimeKind.Local).AddTicks(1181), "Polden", null, null, "0831072797", 1, null, "rpolden1w" },
                    { new Guid("c383efad-3e95-455c-993a-9536a2a38460"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$YODhCdgpY3HuH4u55mMS7.bVsqYdRD2DCU8yy5f8eUJXbL1fOIMQS", null, false, new DateTime(2023, 4, 12, 20, 50, 0, 17, DateTimeKind.Local).AddTicks(837), "Powdrell", null, null, "0569083168", 1, null, "mpowdrellj" },
                    { new Guid("c90c94f9-f2a4-4579-a40b-25640726d534"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$JT3Ku1TPMeiquX5NUoqioO8CUfgdnXq5MJjr4vM.bBjf4iSkWnhJy", null, false, new DateTime(2023, 4, 12, 20, 50, 3, 703, DateTimeKind.Local).AddTicks(1603), "Springham", null, null, "00834111266", 1, null, "sspringhamy" },
                    { new Guid("ca2c2faa-3ea0-400d-ba19-0000914a9d60"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$pBTo0/SeKRQG7gwMMUx4mOzDh49ipj6fwGH6Jz.ZxzmIcPh3aNyaG", null, false, new DateTime(2023, 4, 12, 20, 50, 9, 902, DateTimeKind.Local).AddTicks(8240), "Brockelsby", null, null, "04963800585", 1, null, "jbrockelsby1q" },
                    { new Guid("ca6a95c2-c809-4ed2-8cf4-b5852b634ff9"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$mK6OD3ZkSKWZBSMwxZ5xS.awBBWzX6aDaBf0SRjqPG3jTbHcMGF56", null, false, new DateTime(2023, 4, 12, 20, 50, 13, 964, DateTimeKind.Local).AddTicks(2122), "Hargitt", null, null, "04664308348", 1, null, "ahargitt29" },
                    { new Guid("cab6995b-aea4-4802-9629-d8debfaa1900"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$NfwofsL2XHtfXjR4V2wgHORxKFlAzwyzpRSC.y41aFGJTQqG2KC9q", null, false, new DateTime(2023, 4, 12, 20, 50, 12, 834, DateTimeKind.Local).AddTicks(9550), "Swanson", null, null, "09572022187", 1, null, "gswanson24" },
                    { new Guid("cbd93480-c790-4ce7-b543-ebf439450915"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$jF7eTdu8afNZJU/4P/3VR.T1zHlwQx6mOj8P.gV3wJcka5vSm.6pW", null, false, new DateTime(2023, 4, 12, 20, 50, 6, 909, DateTimeKind.Local).AddTicks(2465), "Middlehurst", null, null, "03494633510", 2, null, "dmiddlehurst1c" },
                    { new Guid("d0945271-b221-4d97-9ab5-a40fbd7c0d8b"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$GcXAZdBGtQZSzjLmzHcqYepVyhSu0/IKWrmw5pqRsu1rib9kdY6i2", null, false, new DateTime(2023, 4, 12, 20, 49, 58, 786, DateTimeKind.Local).AddTicks(2613), " Nguyen Van", null, null, "0966416708", 1, null, "customer" },
                    { new Guid("d4ceaa8e-162f-483b-87b0-c32fabdf1eac"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$TX5.6Hk6bGIwdJ4x1pWX7elUyHm1pfVPvw49Sl2218B6BQanYy2Um", null, false, new DateTime(2023, 4, 12, 20, 50, 1, 764, DateTimeKind.Local).AddTicks(9301), "Bolver", null, null, "0361641052", 2, null, "bbolverq" },
                    { new Guid("d536152b-5901-4255-a224-7a1f7bc1bd9c"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$r.vcLuvYwn35Rp8sO/id2.wAN/OTFfT7yWtV3bnvdgxwY6xpJEuSS", null, false, new DateTime(2023, 4, 12, 20, 50, 3, 916, DateTimeKind.Local).AddTicks(2076), "Maestrini", null, null, "0312994030", 2, null, "fmaestriniz" },
                    { new Guid("d795c33d-cd48-4531-9695-cdde9603dc68"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$KxDt9BMjXQyM4KsUsi6jUeX2EnD88uHJ/5.tatQSkHgQVve/HsFWe", null, false, new DateTime(2023, 4, 12, 20, 50, 2, 956, DateTimeKind.Local).AddTicks(738), "Warnes", null, null, "0812419659", 2, null, "ewarnesv" },
                    { new Guid("d9bd34ce-3efb-4874-a4c7-9e4e7b5aaad2"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$e1hotycziHMtBS07XZcpsusNKSULjCdWfXLm40HmWXemhfxJERHV6", null, false, new DateTime(2023, 4, 12, 20, 49, 59, 23, DateTimeKind.Local).AddTicks(4225), " Nguyen Van", null, null, "0966416708", 2, null, "owner" },
                    { new Guid("dd08a5fa-e02b-4fb0-b2fb-24b7935621ee"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$kNnYTl1HlykMygFtcJ4NdOjEbeNym3QmtM.2aJ8BeHEgUyhUZ7DuO", null, false, new DateTime(2023, 4, 12, 20, 50, 5, 339, DateTimeKind.Local).AddTicks(7742), "Filipchikov", null, null, "0663461504", 2, null, "afilipchikov15" },
                    { new Guid("de9a09cc-d925-4f80-9f24-17f6607715d5"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$.G5B/8D.klJlu/79FoIUnO6qHKLkGcgVZEdeFRSt1M/AsweC50ap2", null, false, new DateTime(2023, 4, 12, 20, 50, 9, 20, DateTimeKind.Local).AddTicks(7717), "Margrie", null, null, "0153784673", 1, null, "cmargrie1m" },
                    { new Guid("e0a25c12-ba3e-4bd5-b52d-ca05e23d6571"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$FMIUu74yiMtVL4C9CVc6YeZa3wxlJ/siGPIBY65P/tcJVrL57uIq2", null, false, new DateTime(2023, 4, 12, 20, 50, 13, 458, DateTimeKind.Local).AddTicks(4151), "Glison", null, null, "06769810772", 1, null, "rglison27" },
                    { new Guid("e2628e0f-5978-40a1-827f-673e88b38a0f"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$bDrTo9v3QAiuAP0LRk3LVOR1qLmf3UZ2FjACynEHuDEplb2kJJFd2", null, false, new DateTime(2023, 4, 12, 20, 50, 19, 181, DateTimeKind.Local).AddTicks(9435), "Gerrish", null, null, "04944713025", 1, null, "rgerrish30" },
                    { new Guid("e45842a6-8ba5-4184-ba6f-1bb67cea0533"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Admin", 0, "$2b$10$sWAsNR8M3sfPmoR5mRRXx.QwemJobJ.TDWPJYPaCDT2vi/YEMFXIK", null, false, new DateTime(2023, 4, 12, 20, 49, 58, 599, DateTimeKind.Local).AddTicks(6812), " Ass min", null, null, "0966416708", -772000, null, "admin" },
                    { new Guid("eec2d02f-d9b0-4ab5-875b-f0c694245a82"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$BNhJ3p5z0zhlSth6qkzJXuTP.dt31Rog8TL7So5uOSyZrrjmWdFjm", null, false, new DateTime(2023, 4, 12, 20, 50, 18, 299, DateTimeKind.Local).AddTicks(2780), "Masser", null, null, "0612845922", 2, null, "smasser2v" },
                    { new Guid("f4372e99-07da-4c3b-a1a3-22980f71e88a"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$Fb6zrTcU78SaZgerHeJ9VuSBWR0xJBjM8bciAKAS/1qT6lD2Rfkse", null, false, new DateTime(2023, 4, 12, 20, 50, 6, 635, DateTimeKind.Local).AddTicks(4931), "Petteford", null, null, "0939882707", 2, null, "spetteford1b" },
                    { new Guid("f9476d75-88f9-4b88-b229-a873a39ae614"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$aPy35QPV5U9.LX7izowakOfO0aGOub0apj8/S0QrMbAG7Qj5cWzYy", null, false, new DateTime(2023, 4, 12, 20, 50, 5, 81, DateTimeKind.Local).AddTicks(8388), "O'Connor", null, null, "0750854688", 1, null, "aoconnor14" },
                    { new Guid("fc2306ac-c2d8-4aa9-b0f1-0bc4f9cb5e61"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$QkF.S19jlWCYXdqHeWVqVuw8feQm/kT7g7zYNMQInAXfQoc8DemcW", null, false, new DateTime(2023, 4, 12, 20, 50, 19, 401, DateTimeKind.Local).AddTicks(2160), "Struss", null, null, "06928824187", 2, null, "astruss31" },
                    { new Guid("fd758545-0761-4601-add8-5fb418792891"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$p2Z9Np9eBZEsGnfp1WVNz.znegBY03RjwBO38KtHeHoZU1LQkhgg6", null, false, new DateTime(2023, 4, 12, 20, 50, 16, 312, DateTimeKind.Local).AddTicks(9787), "Gasperi", null, null, "03723162025", 2, null, "ogasperi2l" },
                    { new Guid("fdba16d6-badc-4969-ba0d-35a4b023c446"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$.cpF61sL7F0acqAjEbU1nOtUH6UJlfp2GQLsCkBI1dlmgXkUO7r6u", null, false, new DateTime(2023, 4, 12, 20, 50, 15, 83, DateTimeKind.Local).AddTicks(7939), "Izhakov", null, null, "05872358652", 1, null, "cizhakov2e" }
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
