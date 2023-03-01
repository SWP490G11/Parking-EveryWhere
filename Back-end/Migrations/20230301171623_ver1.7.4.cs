using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver174 : Migration
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
                    { new Guid("279092a8-9411-4dfe-ad03-f75aac2fae27"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("28ae7761-dc35-44bb-a322-2df33cc0f62d"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("6091a122-b21a-40e7-b09a-a22b8c950292"), "Xe 2 khoang", null, null, "Mini", 15000.0 },
                    { new Guid("7e35ea37-7a1b-497e-82e0-e9a4833697c1"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("a9c0e67e-0b20-43ee-a951-15bf4fefd4a6"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("d7a0fc7a-b31d-4296-b3b1-e0751a306c9d"), "xe 5 chỗ", null, null, "SUV5", 20000.0 }
                });

            migrationBuilder.InsertData(
                table: "MembershipPackages",
                columns: new[] { "ID", "Discription", "LastModifyAt", "Months", "Name", "Price", "SubcribeAt" },
                values: new object[,]
                {
                    { new Guid("29aa7d64-271b-4473-b9a8-0415af8a59a3"), "1 Year", new DateTime(2023, 3, 2, 0, 16, 23, 437, DateTimeKind.Local).AddTicks(3099), 12L, "Long", 130000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ec471dc-a39b-4049-aacc-0d906e1ceb8d"), "Short time", new DateTime(2023, 3, 2, 0, 16, 23, 437, DateTimeKind.Local).AddTicks(3091), 1L, "Short", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("986b7326-beba-474e-9715-2fbee32543da"), "Half Year", new DateTime(2023, 3, 2, 0, 16, 23, 437, DateTimeKind.Local).AddTicks(3097), 6L, "Medium", 70000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01d8426b-575a-4cb2-913d-ba29310c6f73"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$c0X9zSBjJ7YSfnVwRQukQ.J8wnABu/iCHr/Pj9ZH875OR6ScGmMf6", false, new DateTime(2023, 3, 2, 0, 16, 14, 671, DateTimeKind.Local).AddTicks(3198), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("0362eda6-26df-4b23-b771-e6bcb68a1fd7"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$fJ0DjN6UrGHCzmlZo4sm9eyCZSdu9tnGMUNlaN1LmMH6y1i/Zlwhq", false, new DateTime(2023, 3, 2, 0, 16, 19, 687, DateTimeKind.Local).AddTicks(9838), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("04c8782a-32b9-4980-b8c6-77fa86074273"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$/AordvBKdLOf7/uqiPbF/OXDkwMAoKqYLwIGwI1JkXjqhU9y3V5zG", false, new DateTime(2023, 3, 2, 0, 16, 13, 311, DateTimeKind.Local).AddTicks(5344), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("06e15531-d93f-4868-a56d-1c2d240a2073"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$v6S7AwZSC7gyqI5xU1hd8uGr3W3qjfyBmD9WElW8ama.oh50omUIS", false, new DateTime(2023, 3, 2, 0, 16, 14, 321, DateTimeKind.Local).AddTicks(351), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("06e6eb11-5826-419c-bcd8-1d29534c90d7"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$IQJP/G10zHKBS.mqOBLHCemBaj8QRV.jaVNxoP2sIMoPTg1KtZ4eS", false, new DateTime(2023, 3, 2, 0, 16, 16, 491, DateTimeKind.Local).AddTicks(8197), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("07689db2-c1b6-4919-b9ff-0bdca711db6e"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$33/WNGpDo8yRaw0DgAq4ful4GOlulR10RZ3Z.gMmDHR3Uq.Tm8nm6", false, new DateTime(2023, 3, 2, 0, 16, 15, 620, DateTimeKind.Local).AddTicks(534), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("080e03f4-487b-4ee5-9fb0-672641e4f69e"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$.3yah/wgA/aD.V2ftjLYg.1JLEuWeoPYr7wbhCOAQ3CwaSYdqz2ty", false, new DateTime(2023, 3, 2, 0, 16, 22, 755, DateTimeKind.Local).AddTicks(883), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("083dc127-a9ed-46fc-ab90-9b88839cfe54"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$Me3K.w3urTDP4eqVNiqKL.Q5HrwiURSoRXGNTWOenJ18.wFKlyQdu", false, new DateTime(2023, 3, 2, 0, 16, 16, 99, DateTimeKind.Local).AddTicks(1258), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("085b49a6-41ee-45de-8e66-85581e6add52"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$aKaYb1wpncjBg2uPb.aFf.R4f8cYuqctaZmKRsUH7RcpDvfssazHu", false, new DateTime(2023, 3, 2, 0, 16, 19, 613, DateTimeKind.Local).AddTicks(2235), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("0e24cb24-cb86-4857-a0bc-2d3171c86fba"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$5iwqoT0cY9o/NFRF2RWlzOWjyIXhCGy0eG7tzC74Wsf.3XROsBHF2", false, new DateTime(2023, 3, 2, 0, 16, 20, 206, DateTimeKind.Local).AddTicks(1792), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("14366df3-d4b1-4c90-a4c8-d04a859dc9de"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$2iWMif3dKIKdEiiIwXBhVem2f9CQnJkZbOg7vaMMrK.28LXjf1qAO", false, new DateTime(2023, 3, 2, 0, 16, 15, 772, DateTimeKind.Local).AddTicks(1487), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("14733ee1-0dad-4202-8b24-4208f5046428"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$oQf3jIUdNkVo7eTyQq7LieyqNh2lH6.Wj8DBUXAuDhxS8TRxVD0Gy", false, new DateTime(2023, 3, 2, 0, 16, 18, 346, DateTimeKind.Local).AddTicks(6574), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("165cd76a-26cb-4b4c-ae26-18c1d52df23b"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$URutIOh2QhLhnynQsX4Squ1E7ZjQHlOYn/Z0poFGzxKSn8rYIZhx2", false, new DateTime(2023, 3, 2, 0, 16, 13, 789, DateTimeKind.Local).AddTicks(3642), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("17554523-245f-4cc8-85d7-06eff029bad7"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$zp2tQNnxw9Q9iGahkb/HT.uRDDM4eJyXwVdcdXylyJJx4rNtunsni", false, new DateTime(2023, 3, 2, 0, 16, 21, 597, DateTimeKind.Local).AddTicks(1033), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("1b39ec15-743c-442d-9cd6-b8bd9df7a5a5"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$Z9CLz7DHBJTcLgqx6REo7uQJ4xAiLI1JTGeYvGU9R3RWVpUKArf06", false, new DateTime(2023, 3, 2, 0, 16, 22, 233, DateTimeKind.Local).AddTicks(8197), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("1b9b9820-e6b2-49b7-aa24-01955e116fb1"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$V4UM5R2uZ.NrEC6b47e4Yu6uOFjip1BFUm.LSQ16/wmY7kxfhuxz6", false, new DateTime(2023, 3, 2, 0, 16, 14, 522, DateTimeKind.Local).AddTicks(7216), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("1e3fe25f-d70b-4204-895b-5b92cd65d7a1"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$k12wFjm6MSTwRItR5S1x3OAnVfA6M6bwQb0QFTSO9b1mq53UFOnxi", false, new DateTime(2023, 3, 2, 0, 16, 18, 568, DateTimeKind.Local).AddTicks(8726), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("208713cc-9bcd-437b-ab65-ace0bd549143"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$QRgzEUTF69IjeuSygW5kAuGIu7IpSd/OM4GSTGPl.U2xKiHr.z3Ky", false, new DateTime(2023, 3, 2, 0, 16, 13, 529, DateTimeKind.Local).AddTicks(5730), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("21cad711-c81d-431c-885f-18e9b185ec1d"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$m4wjQGdpeTXYUQuv2kQIWu2a8TEeWTP0JyB06HjW4SBVGlcmbPc8u", false, new DateTime(2023, 3, 2, 0, 16, 17, 718, DateTimeKind.Local).AddTicks(1904), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("23f21282-e64d-4e38-a644-8bd7c704e230"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$m0HUO2HR7AfD6UWagIEbke4A/eRz88ne4w/8uHBjM3Zaa.7Cyzom2", false, new DateTime(2023, 3, 2, 0, 16, 20, 674, DateTimeKind.Local).AddTicks(9657), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("2959d2a5-c12f-4b81-abd8-5593ddf18f45"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$PAWbVrX51XLFgVTzo9WMeuRy3fx8qFSVhP32QZHoWDnqaa7pS9FgG", false, new DateTime(2023, 3, 2, 0, 16, 17, 851, DateTimeKind.Local).AddTicks(437), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("2cfd108d-fc08-409b-b503-da5b9f0ea0e0"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$pY4og1bMe.kxd9Dai3j7KeYj6rBDI71pRR229YQjfWaDswkL2t852", false, new DateTime(2023, 3, 2, 0, 16, 23, 91, DateTimeKind.Local).AddTicks(2820), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("2eb2139f-8151-4534-a87b-42d6b1ebbc7b"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$.lpc.t8svIXc5wJjFhnTF.ekZdhPWCq2KkVjRk3r3Mr/pT4MbIIca", false, new DateTime(2023, 3, 2, 0, 16, 21, 368, DateTimeKind.Local).AddTicks(9236), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("2ec11130-a249-46e9-a299-b56ecb4bbcea"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$QbJXNVl/bvZG.qQDyVG1X.ifFKe9xLYO8CudW3zeKO8fdi8g3z/36", false, new DateTime(2023, 3, 2, 0, 16, 19, 289, DateTimeKind.Local).AddTicks(535), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("2fb6d048-9264-42c2-905d-a615761a3d03"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$7LYLpPYot/1.polDLk/04OyRR9WLrfR7myNovZlzPFhNv8hz8vqM.", false, new DateTime(2023, 3, 2, 0, 16, 19, 534, DateTimeKind.Local).AddTicks(5686), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("2ff57026-1ca8-40c2-a678-bfb4ced9aec6"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$QhAkjgzatk17QZrjiT490.zkK2h0p/1yuBRQ9gR8jdW5EsOZsRi9O", false, new DateTime(2023, 3, 2, 0, 16, 18, 5, DateTimeKind.Local).AddTicks(7152), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("340956fd-6534-4c62-9041-a7f14d5ac84e"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$TSJEjgS.ibMaK0rSvC1.JufcES5NFKsfyu9s4IslfHGqiVgNXLolK", false, new DateTime(2023, 3, 2, 0, 16, 17, 918, DateTimeKind.Local).AddTicks(5317), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("353cdf28-8395-47d6-b800-8bd21f546998"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$0rlfIjg1Ya3byGPbd8YSY.JfsqvO41HRlACwQZjRT8qrv7nCJaS/i", false, new DateTime(2023, 3, 2, 0, 16, 22, 95, DateTimeKind.Local).AddTicks(7855), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("360c8aa6-bfdd-4194-929d-09efee72b9b8"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$y/xKDJLZTOQ/4e.5DE8z9ul5NKwe/LHKsNqm9gpGSLFUrz.HdVafe", false, new DateTime(2023, 3, 2, 0, 16, 19, 373, DateTimeKind.Local).AddTicks(8530), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("36fea784-518a-429c-a8ce-d96138e0e30d"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$Vffn9nnuOjYWq9S2V/kcm.8DZB1J2EOQ8q/F5qwoxTNzLmk7FlXaq", false, new DateTime(2023, 3, 2, 0, 16, 20, 999, DateTimeKind.Local).AddTicks(5407), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("38647945-1fa6-4402-9037-5b24cdd8faa5"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$nXQkf/Z.bLkYdWGcbc6hl.TrD2TgbaljS1xyXHFaFUtlC8wTJbmKG", false, new DateTime(2023, 3, 2, 0, 16, 18, 484, DateTimeKind.Local).AddTicks(3646), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("3bb74fec-79c1-43db-b767-0dbc740bc73e"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$VS5PbHRZNiOxdGLVlTaGo.ChCHFksncFWt4kr.BpCT6K6rVOWqe4W", false, new DateTime(2023, 3, 2, 0, 16, 13, 432, DateTimeKind.Local).AddTicks(9585), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("3eb8994c-3cdf-4b4f-991e-9c938764f386"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$NeFayTSJc8leyo/ag9VHqu.2i5/VmU.RMp.Nlw52nzvG4TePmBviS", false, new DateTime(2023, 3, 2, 0, 16, 20, 367, DateTimeKind.Local).AddTicks(8664), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("4633b666-83a1-40dc-b918-c3658e5ab0b0"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$pPQMl80AKQMZ7Rsfh1s90.FcrMETQrVb3UbWglSgWMBPWnqrJtPOW", false, new DateTime(2023, 3, 2, 0, 16, 18, 802, DateTimeKind.Local).AddTicks(9945), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("47acc4ad-9ca6-4f61-a93c-3424b3cc270d"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$xFBmoVCv6MGoCstKN7Di0erNA/kuUfHmKt1PypKlwmSusstWBgJGO", false, new DateTime(2023, 3, 2, 0, 16, 22, 856, DateTimeKind.Local).AddTicks(6747), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("49474833-239b-4846-9f2b-dae17f690835"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$/ijHOYZe71aiyPF08JMSguLAh3g9fY2fV2a7iMNUo66rwqi0kCPyC", false, new DateTime(2023, 3, 2, 0, 16, 20, 444, DateTimeKind.Local).AddTicks(40), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("49d340c3-c2c8-4ff8-9b34-3337be53451a"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$kZfdVi1XsDvKiwQBAw8z3.jEKhj29ZNMLW5mCYmpi08yiJGgRYAOW", false, new DateTime(2023, 3, 2, 0, 16, 21, 475, DateTimeKind.Local).AddTicks(1273), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("4b288f1e-0456-4e50-b513-f59405fc0c77"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$FrqKBkJ4mAfR.eqlz3ZP6eJas90wM6lcehL/aIRcotxzlGz15sowG", false, new DateTime(2023, 3, 2, 0, 16, 14, 257, DateTimeKind.Local).AddTicks(4362), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("4b93290d-972f-43a9-ad29-ff2c9d810577"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$NyVQ4jfE6/Olj/II9k6FnO4qMh2zs2aeM3bKjBaAxF3.E5zjmJaqS", false, new DateTime(2023, 3, 2, 0, 16, 19, 46, DateTimeKind.Local).AddTicks(9658), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("4dc7f26d-398f-4388-9213-c12868bc8dbb"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$17LLn9vng0JCoAYlf3XOp.6NbgUGUVdqwedcijPNPvHtO.mm5Om6y", false, new DateTime(2023, 3, 2, 0, 16, 16, 771, DateTimeKind.Local).AddTicks(8167), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("529cfd82-a4dd-4bd3-b809-31302d54e3c3"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$LCFVX3p1weAYEGpvX0snlexWmHBR160YpZGqZpy4xr2o01b7hdf2m", false, new DateTime(2023, 3, 2, 0, 16, 19, 130, DateTimeKind.Local).AddTicks(300), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("533bc74c-3010-470a-bd99-351bff713ef8"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$ZtauTaECBKO.5b2VzAdT4uqmmQ2URHu461GxZlLwNPD1VLULG5QxG", false, new DateTime(2023, 3, 2, 0, 16, 19, 835, DateTimeKind.Local).AddTicks(4266), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("55fabadd-998b-44e7-ab34-3e8fdb5f0272"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$35bFZpfvmrzV2Z2xm045sOJfMg.pV.aEveBcQYNOYeNYQpW/cZFJm", false, new DateTime(2023, 3, 2, 0, 16, 18, 873, DateTimeKind.Local).AddTicks(4489), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("5867f176-9ffe-46ef-b108-233694adf361"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$FMFgFKqWMuAFvQJutSlDAOghaS/ozVS5u4qzuLQ085o6Dbra4Tcly", false, new DateTime(2023, 3, 2, 0, 16, 16, 972, DateTimeKind.Local).AddTicks(2923), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("59dab54a-731e-49ad-93ee-6512283efc10"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$6MtI27kal0Aqnjxb/FgyIu/0qVOiFSWtdq59zy1/6pxR6Xe8mCgEG", false, new DateTime(2023, 3, 2, 0, 16, 21, 92, DateTimeKind.Local).AddTicks(683), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("5bff324e-1bcc-4ae5-a113-30351cd8ff9c"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$i5rorqnJrFwP0aEDxcnIFOg3Sv.W2SOMMwTXJUDLnTUkHBc0L5zgC", false, new DateTime(2023, 3, 2, 0, 16, 16, 391, DateTimeKind.Local).AddTicks(6274), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("5d45d059-9269-4fb8-8c7e-55b574befa6c"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$Z/m9L8Ae4R/VFYTI5bLDnOfIcN.1Gp69VIMb19PF894jjAtLlE2tK", false, new DateTime(2023, 3, 2, 0, 16, 23, 310, DateTimeKind.Local).AddTicks(170), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("5ed868ca-7995-419e-a20c-1cf99ef6d98b"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$y9cWued9Hg06Vrn3DBbdcu1HPQrZU/GKQ2KBd5MIrfP63/jSxPR/W", false, new DateTime(2023, 3, 2, 0, 16, 18, 963, DateTimeKind.Local).AddTicks(5985), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("5ee39796-7a46-48c0-b86a-6bf0c1e69398"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$G5j0RJ2caS3h2Z4KwhupCuA/qSLH.FQsKWVm1gj5SPtyGxCtrKu.m", false, new DateTime(2023, 3, 2, 0, 16, 16, 586, DateTimeKind.Local).AddTicks(5489), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("62359336-37b1-49ef-9114-27f60dc99497"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$VKxMNqIap4LE/5CqveIWDu4oazJSv1NSqVEi3JbCnv.4OIeQ3nCEC", false, new DateTime(2023, 3, 2, 0, 16, 15, 999, DateTimeKind.Local).AddTicks(3216), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("627ffe57-1483-4994-bb7c-c9959b5069f6"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$swnsySLjgsL2/GliuSfDCOdRQwWJV7.3KVWPivcnjFtpn0Lfw72Gu", false, new DateTime(2023, 3, 2, 0, 16, 22, 960, DateTimeKind.Local).AddTicks(3984), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("661bb57e-e4ad-4a18-ae38-a35e111fed21"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$BVbzg3/Td/lPy3bl.N5cFumdOUE762gA2/81Vt7/KnjW24T6vH5HW", false, new DateTime(2023, 3, 2, 0, 16, 18, 110, DateTimeKind.Local).AddTicks(3849), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("67e87870-b20b-49ab-9e1f-232961ffab82"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$bpS1q7XIu4tpwtF2MeImDuzz7TIVmcImSLpurejNqyCPQzuRuMi6C", false, new DateTime(2023, 3, 2, 0, 16, 23, 437, DateTimeKind.Local).AddTicks(2323), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("68777897-6e25-45af-ae4e-b32f70adf13d"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$7eXK.vllqXqZ3w8Anj.uVe6WRCPZsRgCmznHaV1PXrlvV8QIOA5ZW", false, new DateTime(2023, 3, 2, 0, 16, 21, 280, DateTimeKind.Local).AddTicks(777), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("6e657f65-e52e-4188-9c17-00e897fcc613"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$.UWwBT.p86h0Oa78cyJzjOH2nxVyheMapDZM79HcQQFKz1kdWVQQ6", false, new DateTime(2023, 3, 2, 0, 16, 18, 278, DateTimeKind.Local).AddTicks(884), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("72bd551f-7dd6-4d60-8866-23bc2783aadd"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$F8.ZLMzDfDOMF04W2QPMJ.VJT9OlTE5kZ2OBNkI5Xdj6eCLzF2goe", false, new DateTime(2023, 3, 2, 0, 16, 18, 658, DateTimeKind.Local).AddTicks(289), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("72df4792-4a89-4ce4-b6d1-751a30b350fe"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$fKehlEGp1faDz/0RsriXM.iqtJYRIgDBOb0l5Caa288.G4dcvxKoy", false, new DateTime(2023, 3, 2, 0, 16, 21, 897, DateTimeKind.Local).AddTicks(4738), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("74aa6779-6780-43d0-b6a1-c3eb97ddef75"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$q8JvAbvKA1YsEGsCO1Mfv.GcOEGNhvld8WLN5z2D.YcdquFI87uXu", false, new DateTime(2023, 3, 2, 0, 16, 19, 207, DateTimeKind.Local).AddTicks(8720), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("7574ff0c-b267-488c-9cd0-94ac1a23fa83"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$VTVc7FEHDvpP50VNUHkGo.LSLdwq5CyxjWrpDR2DwiHD4JE3z1T4u", false, new DateTime(2023, 3, 2, 0, 16, 15, 130, DateTimeKind.Local).AddTicks(5632), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("7d6c6688-4a75-4206-baf8-3c104e95f98c"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$b7Q7HB1Eso7XdAQccE2Gz.bs58jA7HBaK7Qo5TTPHoGYHtRj5FjD6", false, new DateTime(2023, 3, 2, 0, 16, 20, 826, DateTimeKind.Local).AddTicks(4658), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("7e9178c4-a4b5-46da-bc03-619cb1909036"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$QI.r2F6XocQlY0ZsKsRluef7CbEZtvJnMYaJA1vjUUseHGGCx/6dm", false, new DateTime(2023, 3, 2, 0, 16, 14, 803, DateTimeKind.Local).AddTicks(1656), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("846ade99-ae68-43bc-9c22-8add0b1fcfcd"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$K1e8YKn6UIaP91VKSemOo.tTYm6GMvCzzu5HraPfHNJeYDkxXO4Da", false, new DateTime(2023, 3, 2, 0, 16, 18, 731, DateTimeKind.Local).AddTicks(7742), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("875dec37-8436-465b-ba41-428dc63f945e"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$FW26Es8gM0kNcWQdmpJZSulJxkZJobzb3NL2.dmOiMK35COOOGtRC", false, new DateTime(2023, 3, 2, 0, 16, 15, 918, DateTimeKind.Local).AddTicks(2755), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("8a4b979e-4ae8-4023-9252-4946fa34414b"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$nG3u2xb1pKodmY8EmCAU4ew2fyoJKUQkdet69PbHkcYQb7yzv3Ri2", false, new DateTime(2023, 3, 2, 0, 16, 19, 914, DateTimeKind.Local).AddTicks(7889), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("914a495e-e3ff-467d-9b9d-e26441bac5e5"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$AGcmlQf2SQZPNbes3x.kdetDTBTToHsQFeNJqN16CX5G9J8bgYH86", false, new DateTime(2023, 3, 2, 0, 16, 14, 737, DateTimeKind.Local).AddTicks(5279), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("93c7078b-461b-4981-aff9-b5d5ccf22c94"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$qNOVFWI1byxJfe/vVgP9m.9EaNrgfhkIwlZtkXNW6ZgsvRQp1vRBe", false, new DateTime(2023, 3, 2, 0, 16, 14, 414, DateTimeKind.Local).AddTicks(8469), "Varga", null, null, "0652741657", 1, "evargab" },
                    { new Guid("94dec8cb-1a60-4e22-9679-2d4e7d05baad"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$sM94vi8MUrmFz83/7Bt34OB2BsuLg88Sy8S7AJVa.P9OtV5YlnxNe", false, new DateTime(2023, 3, 2, 0, 16, 16, 681, DateTimeKind.Local).AddTicks(6960), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("971e64d4-c167-4f1e-8cd0-302e152df766"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$meYfNSKnAkOKQ2POOC2ykuzVpBHz2HcxiL7loFKvJHHh5K.tdAABK", false, new DateTime(2023, 3, 2, 0, 16, 17, 570, DateTimeKind.Local).AddTicks(2146), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("9c6846df-c72b-40d3-9f61-a27e3e458965"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$/o6yeEjzFFxC1GXfr1qT3euerZq4yJEHGt.tDpXB0c5DMQziIOsDG", false, new DateTime(2023, 3, 2, 0, 16, 20, 28, DateTimeKind.Local).AddTicks(188), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("a3d414fe-3f49-4822-b9f9-b50edc340286"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$Bj277RKJw/y4X5c1oIIqveXVNcXHiN8iUJdPHjkbadsHrX23wdYuC", false, new DateTime(2023, 3, 2, 0, 16, 19, 455, DateTimeKind.Local).AddTicks(6528), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("a507ca0b-69bc-4bd7-a60d-b5f7bb6a735d"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$ABP4xzCm.Gp3N93gd06cNuXsktfjvWsYr/ifyj6aniMO26qYsxQX6", false, new DateTime(2023, 3, 2, 0, 16, 15, 218, DateTimeKind.Local).AddTicks(7177), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("a53b876d-c7c1-439d-a073-a3e28a9d7bc5"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$9l8oDdPX1wAReV6ZWjdbVO7HEUmz8/Wtv8Fsxzy3tP.tG.bRt0u0S", false, new DateTime(2023, 3, 2, 0, 16, 15, 539, DateTimeKind.Local).AddTicks(1188), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("a971b3e3-eb1a-4329-bb36-398bb2f12f56"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$.CjRAr/OJGAWfxyaJEShd.PxQymEAMjJ4H5sg1z7B2JNtnFddx.kS", false, new DateTime(2023, 3, 2, 0, 16, 14, 879, DateTimeKind.Local).AddTicks(7831), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("aee4bbfc-69b5-4c59-a71e-82b5198230cc"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$KglOONj6eJ9jnEwsTmQgNux/1/NshDziYdG3fkvoyEDR4HWz49D9K", false, new DateTime(2023, 3, 2, 0, 16, 15, 371, DateTimeKind.Local).AddTicks(1878), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("afb57879-c1c2-46cc-8ac7-4b5840950570"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$F8Ecc2KiBHUIK4IpDGefJup4VfgoxiLvbPfWEbSdJ1BgjV9HJeyJ6", false, new DateTime(2023, 3, 2, 0, 16, 17, 441, DateTimeKind.Local).AddTicks(1467), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("b3d16f9c-a7e9-47f0-8c17-02e2c2a5f588"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$D1PKWfyrvP4yJgaLQQMPre3kiW3YHRPKZBQMstKNhQ/HV79nr1nFS", false, new DateTime(2023, 3, 2, 0, 16, 20, 288, DateTimeKind.Local).AddTicks(6378), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("b3e79fe3-765f-4711-a86b-01f8629f617a"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$BwNDUNJUD.4h3Uzh9xJvtuLM3631LCZyjqqKwErGeBdXe3ZqhM86y", false, new DateTime(2023, 3, 2, 0, 16, 14, 13, DateTimeKind.Local).AddTicks(435), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("b603b3be-ab06-405a-91ab-8c271b773ce6"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$AcqNOURGyOibb7zAyr7B6.6gP3OTkAODSYiYD9lv0AsStK/7x2lCG", false, new DateTime(2023, 3, 2, 0, 16, 22, 505, DateTimeKind.Local).AddTicks(5740), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("b8e271fa-da38-452b-b57c-a80a382b0664"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$3SMUUUzV8DXdLhxPj6zWy.xKqAArU8zlGNqA3bQVZFk2ajxgT/N2q", false, new DateTime(2023, 3, 2, 0, 16, 13, 615, DateTimeKind.Local).AddTicks(9521), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("b947f1e8-d0d3-43a0-92b6-184e1ae16d81"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$vzOU7SK7AmTRswtWOJM3AuqKqLEg8xAYVUqR8Rn3Mn0drWXVVAvvW", false, new DateTime(2023, 3, 2, 0, 16, 17, 264, DateTimeKind.Local).AddTicks(9068), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("b9712980-509a-4fbd-9ec6-58e202fa083b"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$UeQPHAt.Mt9SShgPO10B5eto/IdBgdUP0fP.AZqFEuS/0AbAlTcty", false, new DateTime(2023, 3, 2, 0, 16, 14, 962, DateTimeKind.Local).AddTicks(5219), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("ba00882d-867f-484f-8c8a-3226a99fc851"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$W1uruuSKVH6bEh88/7mBIO59XzrGqGuotKI6.xnfrnvk7Sv1MVSbG", false, new DateTime(2023, 3, 2, 0, 16, 14, 604, DateTimeKind.Local).AddTicks(7469), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("baf98389-cf7f-4760-92d1-b349d3c65267"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$Jv8bRNLhsOgrHHhJdNuWsu9mnoMMVwhSjufFT7a0mVAOa0d9J/a2q", false, new DateTime(2023, 3, 2, 0, 16, 14, 171, DateTimeKind.Local).AddTicks(7920), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("bb2669e9-9f2e-40ec-92ae-bb168efee4b8"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$ZZ9ocP38JJogdqQWdWDftuT2e08DQkcxgf7SEmVUb4..0HkSr2Rmi", false, new DateTime(2023, 3, 2, 0, 16, 22, 626, DateTimeKind.Local).AddTicks(8862), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("bbe34f4a-8a41-4a92-8609-ce7280eada87"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$.aWwqVaXPUB0SklIi0DO8O4eic5z2HqXZUIWJykQM0jq1oBtcz872", false, new DateTime(2023, 3, 2, 0, 16, 19, 762, DateTimeKind.Local).AddTicks(7738), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("c0f8fd7f-8de9-40f8-aae1-72a88c23de9c"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$5gxuqW2RMAsZGH8Us7NR/uq5iUxrZpKaoYKncV68PolOtdv.bl/B.", false, new DateTime(2023, 3, 2, 0, 16, 18, 201, DateTimeKind.Local).AddTicks(3923), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("c8b28b45-91ab-4830-b520-bbacaabd7c63"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$shzrNc4RXNY5T7jdUxr3PujSTDv7gcqIhwGzyrTcYWFhb3GsWGl/O", false, new DateTime(2023, 3, 2, 0, 16, 15, 697, DateTimeKind.Local).AddTicks(2651), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("cc267c3f-154d-474b-a83a-36b4486fa858"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$WjnIyCX16lBYqkFilkEsK.t/.Nez0/5wyJzSgPU9cGR8uhsjJg1MK", false, new DateTime(2023, 3, 2, 0, 16, 15, 46, DateTimeKind.Local).AddTicks(7392), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("cd8ad964-25e9-44f3-bfeb-7d22a167f443"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$.11FlggqllAGFTEEUQekPeoCNuoJr1PN963Tv1IqTjDf.j9nfpBMC", false, new DateTime(2023, 3, 2, 0, 16, 21, 185, DateTimeKind.Local).AddTicks(297), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("cf235923-503c-447a-a56f-9ff8a2b68e0d"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$keaQ1Ue1ILgiNSDRlyNIfeiWkR9zTIlvOcmVnpmfoXHgX/wp4WQfe", false, new DateTime(2023, 3, 2, 0, 16, 17, 650, DateTimeKind.Local).AddTicks(6673), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("cf794d06-c933-4657-8c60-3b6c37ab7b34"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$d/5m6bppscmUsg2qwPJ8velBhMstEPJ.a5CU8aawVpVRMIGUOTWYu", false, new DateTime(2023, 3, 2, 0, 16, 20, 591, DateTimeKind.Local).AddTicks(9250), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("d4f5bc8d-5fb6-48c2-99b3-8a7fd32cc97a"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$rs0B8tW4Y1ASUa8EKvb/XuXllRS80pAFUf5wyicsykXrNzYctuhu.", false, new DateTime(2023, 3, 2, 0, 16, 23, 196, DateTimeKind.Local).AddTicks(2047), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("d50b207d-12eb-49a9-8978-c19812a937c2"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$OJHTEesPldn37YH9Eo3IDeavkSkTohZvhHNnttRezbRQRHA49u.tu", false, new DateTime(2023, 3, 2, 0, 16, 15, 845, DateTimeKind.Local).AddTicks(5054), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("d6633382-29dd-4bbc-88cc-8b1ffc9ceff3"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$wghOe3i.gnNTQPppcovV2upJ3GcbSYC3MnxZ3c9zhBCICgKLcbDBe", false, new DateTime(2023, 3, 2, 0, 16, 17, 177, DateTimeKind.Local).AddTicks(3923), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("e7b8f2de-2b43-4626-ac64-904b7ecbd2ea"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$wDU4LGtCcU2MTM/ky3Z8Z.rgcBAi.vOBerkK6.CxBjEkOq8F/DxEq", false, new DateTime(2023, 3, 2, 0, 16, 20, 749, DateTimeKind.Local).AddTicks(6577), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("e957cbd8-5e7c-48e2-9bbd-9d64415541a2"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$VsQ0oE/gsCF7TmFPADqaAe2Ua1AqfEM4KmhuVBQ.2k/PglGwsjLI.", false, new DateTime(2023, 3, 2, 0, 16, 22, 360, DateTimeKind.Local).AddTicks(1912), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("e9936356-d6be-45e0-a381-f52e7f270342"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$c8/DLfqacEYAboq7b1mKcuW17GoST.GdAZTaBpp5Bip0F4jIlVQiu", false, new DateTime(2023, 3, 2, 0, 16, 21, 701, DateTimeKind.Local).AddTicks(4575), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("eb28480d-c75e-4040-b6d0-137c17f71387"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$JcXdpZcSezueYu8Hz.iS3OwJX1EqekEeKnQdRH0HmmHPpxkvzRcGe", false, new DateTime(2023, 3, 2, 0, 16, 20, 518, DateTimeKind.Local).AddTicks(5492), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("ec08817d-80ba-4927-b7cb-1e7738a53c4e"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$iKSw52nAfAsofwh4Ocuuxehe0x5/mMGZ0hHjjFyWjMlitWRM2yAce", false, new DateTime(2023, 3, 2, 0, 16, 17, 784, DateTimeKind.Local).AddTicks(8584), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("ece83656-cdd1-4872-80a2-8e1f1f359fd4"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$qT0FwA43DLlZm5p86IuEc.XpzABY8nJvy9GYAnlLqs4u8NDbjPMV2", false, new DateTime(2023, 3, 2, 0, 16, 20, 120, DateTimeKind.Local).AddTicks(862), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("ee24dd48-5c85-4f8b-9d0e-0d11824d5158"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$UVISJu8mvNPgfLObBoenDOnYVoXmylv0SCQt9bYkBeQGaq/Q6dXoq", false, new DateTime(2023, 3, 2, 0, 16, 16, 288, DateTimeKind.Local).AddTicks(4687), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("ee966e7e-fc92-49f4-96b1-7991dc4d8ee1"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$sMIz4FW/wxqRwK0YH6VM5..6MkVRJlpA3ay4yWJuF9HihPOYA0qaa", false, new DateTime(2023, 3, 2, 0, 16, 17, 83, DateTimeKind.Local).AddTicks(5637), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("f0aab958-3e90-4931-942d-3b46b556dae7"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$DyHNqgKOidl.t7GmmbtODu6ZGdQLl58u4fludkz12Z9k5tUm.bW5i", false, new DateTime(2023, 3, 2, 0, 16, 15, 451, DateTimeKind.Local).AddTicks(7390), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("f1e4bf89-b498-4f61-8360-f1d10d5250cc"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$dEuZyfB/eqNvZ3LZp5go9uQKu8/6rI5K0TA3rFOSf0uHohe6y7f2G", false, new DateTime(2023, 3, 2, 0, 16, 17, 348, DateTimeKind.Local).AddTicks(5968), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("f27cfd77-48b3-4b75-9c1e-f1b48e560e94"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$j6gxx2biyzdXKx3vZCP/jOd2fraop6rJk6YHStrdnjsd63GAM8PFS", false, new DateTime(2023, 3, 2, 0, 16, 16, 867, DateTimeKind.Local).AddTicks(834), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("f4b244dd-2cd5-41cf-b912-866768bb3935"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$FsIGJDw9n26NEiqS2UBhW.2DPIVRUpPk541HawviHYjCpH9MwcfEO", false, new DateTime(2023, 3, 2, 0, 16, 14, 83, DateTimeKind.Local).AddTicks(2040), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("f94deaec-c160-4d92-96d2-186847908e19"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$.b61a.c3Jqd6J2VEPBu4Gu2bJ0zG4bh3Te6cl1pTg38.ILsW37WlC", false, new DateTime(2023, 3, 2, 0, 16, 16, 191, DateTimeKind.Local).AddTicks(2416), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("fbf4e941-3a24-4658-8beb-ebf45b54d1db"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$UyPg/5sngeP3KH244oG3ueReo9GBAyyu1VxzzVjmII5nRXWGQeBrW", false, new DateTime(2023, 3, 2, 0, 16, 15, 295, DateTimeKind.Local).AddTicks(5621), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("fd1a8354-119b-4f85-9f45-da19f67b2818"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$MR5ReMfBrOzseYfpR65YieChSEylbmQpbLxuG7iHL5yslg.0YLGMS", false, new DateTime(2023, 3, 2, 0, 16, 20, 912, DateTimeKind.Local).AddTicks(7918), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("fd3b7a73-66c0-414e-888c-7ecd1e8d5b34"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$5mkZgG4VloMz6yqh5sA5FuQxKpkORB4JIQfa309t4s1zHlajiQtYK", false, new DateTime(2023, 3, 2, 0, 16, 13, 914, DateTimeKind.Local).AddTicks(4557), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("fd6703e2-fd3e-40c4-a11c-ccae6c173a3c"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$wsmbyrI9XbP.UkPkoGqFp.n/9UnNHXgwhiu6SxIIZacJXiyUCplyG", false, new DateTime(2023, 3, 2, 0, 16, 18, 415, DateTimeKind.Local).AddTicks(9458), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("feca751b-abbc-448a-b028-67e1097cdcff"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$Lpnz.deUw6RgDPnBd4XAgu27gBzn58yyOKZjGrmFRJebUVPFzwrPC", false, new DateTime(2023, 3, 2, 0, 16, 13, 700, DateTimeKind.Local).AddTicks(5003), "Buzine", null, null, "0519358893", 2, "rbuzine3" }
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
