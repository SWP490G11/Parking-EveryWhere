using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver165 : Migration
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
                    OwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    { new Guid("2c59e238-1da0-4ec0-a243-5bc5c15c90d6"), "Xe 4 chỗ du lịch", null, null, "Sedan", 15000.0 },
                    { new Guid("3e97bdcc-c9ab-4e8c-806c-8a20dfa80660"), "Xe bán tải", null, null, "Pickup", 20000.0 },
                    { new Guid("5121a810-8032-4c0f-9b9f-ca36978a1372"), "Xe 7 chỗ", null, null, "SUV7", 25000.0 },
                    { new Guid("ccc75c1f-5c65-4896-8c2c-764906c360d2"), "Xe van con", null, null, "Minivan", 25000.0 },
                    { new Guid("e4976a8a-35ad-4d98-9475-aa9911e30706"), "xe 5 chỗ", null, null, "SUV5", 20000.0 },
                    { new Guid("f9efbedc-eae2-4a6b-a267-b27471bfbad5"), "Xe 2 khoang", null, null, "Mini", 15000.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CitizenID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPassword", "IsDisable", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("01f1a277-e765-4b7f-b55f-2517241e09c6"), "030674043571", new DateTime(2006, 5, 6, 0, 28, 27, 0, DateTimeKind.Unspecified), "rbuzine3@pen.io", "Raviv", 2, "$2b$10$pvvaPQr8Cbfh0kjtshxfxe7We8IQwl5pXcuF3z0o8UKyBxfMgvtCa", false, new DateTime(2023, 2, 24, 15, 13, 27, 857, DateTimeKind.Local).AddTicks(6201), "Buzine", null, null, "0519358893", 2, "rbuzine3" },
                    { new Guid("047bfd41-f27a-4e4f-a0a0-0a127e5dfae0"), "067204083505", new DateTime(2010, 12, 9, 5, 42, 45, 0, DateTimeKind.Unspecified), "wmackegg26@acquirethisname.com", "Wilek", 1, "$2b$10$RMcoeVNt3ZR5h.Gkhe.3hOKLGPDujhpfMjd8USPd0VkTenwvmDKuy", false, new DateTime(2023, 2, 24, 15, 13, 34, 725, DateTimeKind.Local).AddTicks(7363), "MacKegg", null, null, "05989129010", 2, "wmackegg26" },
                    { new Guid("05602db6-37f9-4720-9347-1198bf4120d9"), "051569747161", new DateTime(2020, 3, 3, 11, 52, 30, 0, DateTimeKind.Unspecified), "ascirman1u@berkeley.edu", "Annmaria", 0, "$2b$10$7eOs816OG2JsAxA3tfpHyu87gV3vgXXT9XKrNn.g8noLHUDyUe/wi", false, new DateTime(2023, 2, 24, 15, 13, 33, 653, DateTimeKind.Local).AddTicks(8290), "Scirman", null, null, "0195375651", 1, "ascirman1u" },
                    { new Guid("05c4e3e3-4c4d-4b65-be48-3804f1835f6d"), "027126621016", new DateTime(2005, 5, 17, 5, 32, 10, 0, DateTimeKind.Unspecified), "melgee2x@smugmug.com", "Miriam", 0, "$2b$10$h1DfyAadD3I9ID/CIvfpbe6jXByGR/X7o.gSCbQmYBEtcnAmblxly", false, new DateTime(2023, 2, 24, 15, 13, 38, 43, DateTimeKind.Local).AddTicks(4356), "Elgee", null, null, "0961523438", 2, "melgee2x" },
                    { new Guid("05d20112-70a8-4d16-aa12-3fa7f1e51e77"), "049818254726", new DateTime(2015, 4, 14, 12, 38, 32, 0, DateTimeKind.Unspecified), "sbolliver2w@webnode.com", "Suzanne", 1, "$2b$10$XqH7gg3m.whJ367Ne/YSZ.esR7GR8fepxk8O.u8U7JpjKqv7.bzfS", false, new DateTime(2023, 2, 24, 15, 13, 37, 939, DateTimeKind.Local).AddTicks(6648), "Bolliver", null, null, "0699230163", 2, "sbolliver2w" },
                    { new Guid("0b4866de-e8d1-4cab-b33f-35ddefaa3133"), "000896471415", new DateTime(2017, 9, 15, 15, 0, 13, 0, DateTimeKind.Unspecified), "cmargrie1m@last.fm", "Charmine", 0, "$2b$10$rXBlDG03cuZffz0En/KSmeSRMDIM73xZcfX5JKDXzDuKHlXAtwLWe", false, new DateTime(2023, 2, 24, 15, 13, 32, 852, DateTimeKind.Local).AddTicks(5527), "Margrie", null, null, "0153784673", 1, "cmargrie1m" },
                    { new Guid("104260c1-4162-4ade-84bc-f9acf18ecbbb"), "010529649645", new DateTime(2007, 3, 4, 14, 18, 34, 0, DateTimeKind.Unspecified), "ryuille2s@naver.com", "Rafaela", 1, "$2b$10$7qoJ9q6yenF303foGmess.lEEdKYJLB232.tQQ5yt.lsXyP282ySC", false, new DateTime(2023, 2, 24, 15, 13, 37, 438, DateTimeKind.Local).AddTicks(7044), "Yuille", null, null, "00670067189", 2, "ryuille2s" },
                    { new Guid("11a9a150-0e26-4786-bae3-de299e52179c"), "024650612878", new DateTime(2020, 1, 4, 23, 10, 36, 0, DateTimeKind.Unspecified), "pdolder12@dailymail.co.uk", "Phillida", 2, "$2b$10$8H3N7GkbFfibnzgBIYmPgOoVnX2jzY2GHToUC6g8LbyocOApZ91bC", false, new DateTime(2023, 2, 24, 15, 13, 30, 707, DateTimeKind.Local).AddTicks(3691), "Dolder", null, null, "0857765771", 2, "pdolder12" },
                    { new Guid("11cfb069-2c32-4f09-9bd3-00ef78f1f823"), "066323560698", new DateTime(2017, 9, 25, 16, 3, 27, 0, DateTimeKind.Unspecified), "abatrip1y@opensource.org", "Ashlen", 2, "$2b$10$.TMs2uSwgUCLo0M8Cr/fV.GZdAacxlZsc4Yw4LA7eNDecfCsnYAKC", false, new DateTime(2023, 2, 24, 15, 13, 34, 2, DateTimeKind.Local).AddTicks(7026), "Batrip", null, null, "0734926905", 1, "abatrip1y" },
                    { new Guid("13543eb1-49f6-4c87-8117-21dc26a0d477"), "054250845949", new DateTime(2021, 7, 15, 13, 52, 50, 0, DateTimeKind.Unspecified), "oormerod1o@businesswire.com", "Ophelie", 2, "$2b$10$RWurQJ5iZQ6plo89HRmZoOv35HllSaPmGVG0X3xM6Eord9d315fPy", false, new DateTime(2023, 2, 24, 15, 13, 33, 78, DateTimeKind.Local).AddTicks(5089), "Ormerod", null, null, "02807987147", 1, "oormerod1o" },
                    { new Guid("136d6c21-b9a7-41ce-ab11-8792d068dbaf"), "083968511675", new DateTime(2013, 10, 15, 2, 51, 11, 0, DateTimeKind.Unspecified), "lgonzalo2u@netlog.com", "Lilllie", 0, "$2b$10$Dm28Ykv0Uux/X.xdNukRb.A8tYi4/hh5CLeKXCWDngEZUOG3Cd0ES", false, new DateTime(2023, 2, 24, 15, 13, 37, 715, DateTimeKind.Local).AddTicks(5801), "Gonzalo", null, null, "0459531972", 2, "lgonzalo2u" },
                    { new Guid("15536165-4744-4fa9-82a9-1468a6917258"), "072336544246", new DateTime(2007, 4, 27, 6, 19, 46, 0, DateTimeKind.Unspecified), "smartugin19@springer.com", "Sinclair", 1, "$2b$10$V.U7LMUMqrvuBec2AqOlWupatCBT82brx5nkB/VMzZW5RqcuEH9he", false, new DateTime(2023, 2, 24, 15, 13, 31, 454, DateTimeKind.Local).AddTicks(4909), "Martugin", null, null, "02340159874", 2, "smartugin19" },
                    { new Guid("18185f2a-1ed1-4a4f-9821-153117f00133"), "030636956184", new DateTime(2011, 5, 25, 22, 45, 0, 0, DateTimeKind.Unspecified), "koliffe20@hp.com", "Keefer", 1, "$2b$10$ANbSdxTg7av5WF1z0dbqbe0ZBCo7dSZr8MDooVKrJNreKHa7ppmBG", false, new DateTime(2023, 2, 24, 15, 13, 34, 171, DateTimeKind.Local).AddTicks(8846), "Oliffe", null, null, "0002143579", 1, "koliffe20" },
                    { new Guid("1b46d3f6-c4ab-4b95-883d-d260f223f3f8"), "089891343248", new DateTime(2011, 2, 28, 6, 24, 40, 0, DateTimeKind.Unspecified), "cizhakov2e@ed.gov", "Crysta", 2, "$2b$10$URUK0q7rHbYb4J0j6ZCJAuWKlLSYGBpEpawtYv5oxi7.QWHvmusXq", false, new DateTime(2023, 2, 24, 15, 13, 35, 800, DateTimeKind.Local).AddTicks(3469), "Izhakov", null, null, "05872358652", 1, "cizhakov2e" },
                    { new Guid("21524e98-f755-43f4-8d98-1b35475d7970"), "072383893429", new DateTime(2009, 8, 3, 22, 43, 42, 0, DateTimeKind.Unspecified), "lhowland2k@state.tx.us", "Leila", 0, "$2b$10$.OVbrPybCb.ZpSIBgzI1k.wn5QQ/ic5Zmm2wPHxQWbYETuYDGei0q", false, new DateTime(2023, 2, 24, 15, 13, 36, 456, DateTimeKind.Local).AddTicks(3413), "Howland", null, null, "00133370415", 1, "lhowland2k" },
                    { new Guid("25edd851-cae6-4ad4-81ee-3a2562e61dd6"), "043469299501", new DateTime(2011, 5, 18, 0, 29, 35, 0, DateTimeKind.Unspecified), "fberks1l@yelp.com", "Fianna", 2, "$2b$10$mN3iS/XlQIZNuXPh4NidPeoyVuNUgBOreMdLqNomBCbrtKirYqo92", false, new DateTime(2023, 2, 24, 15, 13, 32, 735, DateTimeKind.Local).AddTicks(8695), "Berks", null, null, "04613021719", 2, "fberks1l" },
                    { new Guid("291abba1-019b-4b7e-adbc-09e143b9a5d5"), "060650320572", new DateTime(2016, 9, 18, 21, 57, 45, 0, DateTimeKind.Unspecified), "dmckinlayx@guardian.co.uk", "Dewie", 2, "$2b$10$HdkyERXk9wQYkDfpcRmwk.psdoOamTNMj/sHVrpi56OCtMVMP.sw2", false, new DateTime(2023, 2, 24, 15, 13, 30, 231, DateTimeKind.Local).AddTicks(7322), "McKinlay", null, null, "03957603316", 2, "dmckinlayx" },
                    { new Guid("293a428e-e370-4f4f-811a-1b83bf67f359"), "014280490976", new DateTime(2014, 10, 29, 23, 29, 28, 0, DateTimeKind.Unspecified), "istonebanks1@auda.org.au", "Ingeborg", 2, "$2b$10$qZMg1vjRNxNllBPKfOcXF.0WCUZHN/s3xLxTMxQZAu7q.k0ARJrPi", false, new DateTime(2023, 2, 24, 15, 13, 27, 674, DateTimeKind.Local).AddTicks(2509), "Stonebanks", null, null, "0633691068", 1, "istonebanks1" },
                    { new Guid("2d00cc04-033d-45d7-b4ed-32260bf65c3e"), null, new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$pzdqbkN0yC9OCONyBfKhOOrvfFhGsySXJEJvwenglGxt5koNkSDyG", false, new DateTime(2023, 2, 24, 15, 13, 27, 529, DateTimeKind.Local).AddTicks(7661), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" },
                    { new Guid("2ddc20dd-13e5-49e4-9d84-ec43d64be8bc"), "060822531573", new DateTime(2014, 7, 28, 10, 33, 41, 0, DateTimeKind.Unspecified), "mpowdrellj@accuweather.com", "Maren", 0, "$2b$10$4sZJZaKCbNoPwkyV.3ChguzDjofY1tKBN2NLw2pi1R5SDKkbRvZz6", false, new DateTime(2023, 2, 24, 15, 13, 29, 7, DateTimeKind.Local).AddTicks(3960), "Powdrell", null, null, "0569083168", 1, "mpowdrellj" },
                    { new Guid("3008bf7f-2d1c-47ec-89fe-6a68cc5b9390"), "017271291718", new DateTime(2008, 3, 31, 22, 29, 54, 0, DateTimeKind.Unspecified), "arobley7@zdnet.com", "Andee", 2, "$2b$10$DwGZqzq82AZeHQ0RapkSrO/izfsjPpDN0c/eBCmMnii2fVg4H.3/y", false, new DateTime(2023, 2, 24, 15, 13, 28, 145, DateTimeKind.Local).AddTicks(4711), "Robley", null, null, "0910759650", 2, "arobley7" },
                    { new Guid("3060c0ad-cb26-45f2-bad7-09a18888885d"), "010958057874", new DateTime(2013, 9, 15, 4, 55, 53, 0, DateTimeKind.Unspecified), "sbarhem2m@barnesandnoble.com", "Sukey", 1, "$2b$10$aFgQiVF4UF/1pY6q852FmOFwb0.g0K4jzBT.Jk2cvkxsCY2s6Dk7S", false, new DateTime(2023, 2, 24, 15, 13, 36, 665, DateTimeKind.Local).AddTicks(4796), "Barhem", null, null, "08054760577", 1, "sbarhem2m" },
                    { new Guid("321af58e-99bd-4c01-9afc-d74864b7e9fd"), "044342332159", new DateTime(2013, 4, 16, 14, 16, 11, 0, DateTimeKind.Unspecified), "jbrockelsby1q@etsy.com", "Jeramie", 2, "$2b$10$WmQoYVvZcSY73RaAWJqaLujW.RaxuOOBb3lvycAtGudP9UF0dqLNK", false, new DateTime(2023, 2, 24, 15, 13, 33, 257, DateTimeKind.Local).AddTicks(6087), "Brockelsby", null, null, "04963800585", 1, "jbrockelsby1q" },
                    { new Guid("32fe22c9-429c-476b-87a2-a76b52ab4a29"), "092508260671", new DateTime(2007, 11, 16, 8, 30, 13, 0, DateTimeKind.Unspecified), "ahargitt29@nyu.edu", "Adan", 1, "$2b$10$QIhvjlyfFq2oGJFj.se5hOunytEL10cAcKVCzmHdyakk6NGT.7Ig.", false, new DateTime(2023, 2, 24, 15, 13, 35, 96, DateTimeKind.Local).AddTicks(7585), "Hargitt", null, null, "04664308348", 1, "ahargitt29" },
                    { new Guid("3308ba9a-785f-410b-a086-3e603a50853a"), "097541590766", new DateTime(2016, 3, 13, 6, 14, 18, 0, DateTimeKind.Unspecified), "mloudc@opensource.org", "Mela", 2, "$2b$10$FJoOh0dQs99g2Q600W.uH.MDvrJtSpjLxek0Sh6Bvd8KNWhzOETAO", false, new DateTime(2023, 2, 24, 15, 13, 28, 518, DateTimeKind.Local).AddTicks(85), "Loud", null, null, "01641918486", 1, "mloudc" },
                    { new Guid("3785ef56-0602-4d36-8962-e53644038ddb"), "011426328012", new DateTime(2008, 5, 2, 0, 20, 44, 0, DateTimeKind.Unspecified), "tmccloyl@sun.com", "Talya", 2, "$2b$10$8oQTlOiWAIZMYCPJo2yTDuaT9hqYHbmdffS74Wss3PHf9HCKXcmuC", false, new DateTime(2023, 2, 24, 15, 13, 29, 150, DateTimeKind.Local).AddTicks(3394), "McCloy", null, null, "08418620623", 2, "tmccloyl" },
                    { new Guid("395aa456-610f-407c-819c-02a48537b1ef"), "034993466710", new DateTime(2019, 3, 21, 8, 13, 47, 0, DateTimeKind.Unspecified), "rgerrish30@typepad.com", "Rhianon", 2, "$2b$10$4h2JRmemYVW59aafAuZh9uRyf4OK.C2E7mUVo9U6JoamKR/oxCoOe", false, new DateTime(2023, 2, 24, 15, 13, 38, 355, DateTimeKind.Local).AddTicks(2980), "Gerrish", null, null, "04944713025", 1, "rgerrish30" },
                    { new Guid("3eaba745-569b-4a30-a25c-971561cee38d"), "029228944870", new DateTime(2015, 11, 23, 16, 33, 31, 0, DateTimeKind.Unspecified), "babrahamsohn2y@diigo.com", "Broddie", 1, "$2b$10$P4YFHl3DgZI4wPKyh7BfR.QDVR/EiyGGf/Y4F8.kxIjjzbkkOBiNC", false, new DateTime(2023, 2, 24, 15, 13, 38, 154, DateTimeKind.Local).AddTicks(9543), "Abrahamsohn", null, null, "08144581503", 1, "babrahamsohn2y" },
                    { new Guid("3ec16b51-9704-4451-b80a-e09f053a0741"), "081889240844", new DateTime(2019, 2, 10, 16, 11, 1, 0, DateTimeKind.Unspecified), "jwebley22@shareasale.com", "Jethro", 2, "$2b$10$0flHiKLK.6PlKpq5SX8P/utCMicUjixZHWtMZN3H9eh08Us81Bi/W", false, new DateTime(2023, 2, 24, 15, 13, 34, 332, DateTimeKind.Local).AddTicks(9306), "Webley", null, null, "0821411907", 1, "jwebley22" },
                    { new Guid("50c4d679-d5cc-4a7c-9d8f-6ea758ca046f"), "024065529024", new DateTime(2008, 5, 18, 11, 9, 18, 0, DateTimeKind.Unspecified), "jcantor13@cocolog-nifty.com", "Jillayne", 1, "$2b$10$8j4yvJSGE4YvD8rt1CwtO./84jv/Xg3ElsY2NOqxLVU/q5X3qFmO.", false, new DateTime(2023, 2, 24, 15, 13, 30, 845, DateTimeKind.Local).AddTicks(949), "Cantor", null, null, "0218299981", 1, "jcantor13" },
                    { new Guid("5289ec61-bbc3-4ebc-a9bc-9f8d15e0f8b1"), "058831865897", new DateTime(2011, 1, 2, 20, 27, 50, 0, DateTimeKind.Unspecified), "vrameaux1p@histats.com", "Vern", 2, "$2b$10$OYXgY/JpDpiebU/RFxhhdunlgc6Ggzq4KM/KClnK2Srn9SH0YovbS", false, new DateTime(2023, 2, 24, 15, 13, 33, 169, DateTimeKind.Local).AddTicks(6077), "Rameaux", null, null, "0213510408", 2, "vrameaux1p" },
                    { new Guid("53efc40c-1e99-4ad8-a7cb-eadfc14e0d90"), "059220509985", new DateTime(2016, 10, 25, 3, 27, 31, 0, DateTimeKind.Unspecified), "acookseya@storify.com", "Amie", 0, "$2b$10$6HBpGSxh9A37kAgRJFu6f.9ojnus9xo/P3BY3wt0/rZ7737VsVbuy", false, new DateTime(2023, 2, 24, 15, 13, 28, 379, DateTimeKind.Local).AddTicks(2205), "Cooksey", null, null, "02935053805", 2, "acookseya" },
                    { new Guid("54607227-0140-481f-bb3e-49fa982c36d9"), "029664078144", new DateTime(2015, 10, 13, 18, 2, 20, 0, DateTimeKind.Unspecified), "ogreenalf4@facebook.com", "Olympia", 0, "$2b$10$NUqQbXqVpK07MMy8MtxecuJIPX/Id0hC2XVuu9nVl1aiA7GnE8Nuy", false, new DateTime(2023, 2, 24, 15, 13, 27, 921, DateTimeKind.Local).AddTicks(7506), "Greenalf", null, null, "0752660557", 2, "ogreenalf4" },
                    { new Guid("55154d4b-8204-4f43-a2b6-43df3ec6ce11"), "037624203471", new DateTime(2015, 3, 9, 13, 20, 19, 0, DateTimeKind.Unspecified), "sspringhamy@typepad.com", "Sinclair", 1, "$2b$10$idArOah9ymXETJMQY6RAZu8oxLHF2AxbjniIXTXhJsv5h3E0FDLC.", false, new DateTime(2023, 2, 24, 15, 13, 30, 345, DateTimeKind.Local).AddTicks(3062), "Springham", null, null, "00834111266", 1, "sspringhamy" },
                    { new Guid("58502c4b-fbb8-488f-8ffb-f30c704ffd7d"), "088837943287", new DateTime(2004, 3, 23, 13, 15, 4, 0, DateTimeKind.Unspecified), "fguillet8@ft.com", "Farra", 0, "$2b$10$8X.oej8JcICehSjRjj9xNOgmkSKdi8E6SsxddoEhGPNelCl784tKC", false, new DateTime(2023, 2, 24, 15, 13, 28, 241, DateTimeKind.Local).AddTicks(4380), "Guillet", null, null, "0134210264", 2, "fguillet8" },
                    { new Guid("58cf397e-c6cb-4639-b1ea-bb3b4dd63dcc"), "070259732553", new DateTime(2009, 7, 23, 1, 45, 40, 0, DateTimeKind.Unspecified), "hscheffel23@salon.com", "Hayden", 1, "$2b$10$eRgUUsDlIYT9XS5/SMiTOOla7ddBjD3H0MZVp7/Cw1NGUWyQwtjm2", false, new DateTime(2023, 2, 24, 15, 13, 34, 415, DateTimeKind.Local).AddTicks(3027), "Scheffel", null, null, "0355632555", 2, "hscheffel23" },
                    { new Guid("5e278c2c-2dcb-449a-ad04-46807782547a"), "022302525112", new DateTime(2007, 6, 25, 23, 2, 4, 0, DateTimeKind.Unspecified), "fmaestriniz@vistaprint.com", "Friedrick", 1, "$2b$10$eYhcuOJUetV6TPLPgr4SE.6d12JMaPHQcrllGQ1Q0YHK5oITJ.MMO", false, new DateTime(2023, 2, 24, 15, 13, 30, 443, DateTimeKind.Local).AddTicks(6202), "Maestrini", null, null, "0312994030", 2, "fmaestriniz" },
                    { new Guid("5ff5285d-dae9-4042-9af4-5d59edf4c5ec"), "073588774155", new DateTime(2007, 1, 9, 9, 16, 15, 0, DateTimeKind.Unspecified), "dfeatherstonhaughr@artisteer.com", "Daniella", 1, "$2b$10$k6NBHO6zeinOEbpgIHjmBO6q.CQv/1kOEwbrtgS8DEbD5zm3uTS22", false, new DateTime(2023, 2, 24, 15, 13, 29, 608, DateTimeKind.Local).AddTicks(1812), "Featherstonhaugh", null, null, "0737666977", 2, "dfeatherstonhaughr" },
                    { new Guid("608dd82d-a129-4413-acd3-2a083aea14a1"), "088913475479", new DateTime(2011, 1, 2, 5, 9, 22, 0, DateTimeKind.Unspecified), "bjilkes2c@google.nl", "Boot", 1, "$2b$10$u2GngBi9i84LCvlVIveVquPVQ1pn39hUsA/VqY00KZ/AcrUQ8GWgm", false, new DateTime(2023, 2, 24, 15, 13, 35, 545, DateTimeKind.Local).AddTicks(4575), "Jilkes", null, null, "00677856497", 2, "bjilkes2c" },
                    { new Guid("65bb6295-736f-4e7e-9bde-f1c0ff7d5349"), "033336925033", new DateTime(2005, 1, 8, 19, 2, 19, 0, DateTimeKind.Unspecified), "dhaney2i@ox.ac.uk", "Dalli", 0, "$2b$10$MSAcdKiYQgCN6W1hNkeHJesOSNuRhV7O.erILnUVrPCIW6ldLB9oe", false, new DateTime(2023, 2, 24, 15, 13, 36, 211, DateTimeKind.Local).AddTicks(6637), "Haney", null, null, "0041887086", 2, "dhaney2i" },
                    { new Guid("6cfc4e86-c586-4377-ae57-de5a8375ef4a"), "083356691455", new DateTime(2011, 12, 5, 2, 47, 25, 0, DateTimeKind.Unspecified), "atrippitt1t@unblog.fr", "Arnaldo", 1, "$2b$10$Dl.crxaNbzM8e3DWr4PGl.JyyPf9TN5TupAcPV3q7FJ4fGKfrFzH6", false, new DateTime(2023, 2, 24, 15, 13, 33, 557, DateTimeKind.Local).AddTicks(2933), "Trippitt", null, null, "00615614760", 1, "atrippitt1t" },
                    { new Guid("6d6517e2-d699-4129-9d14-ee85f2f220f4"), "013013528487", new DateTime(2015, 12, 3, 8, 15, 12, 0, DateTimeKind.Unspecified), "dmiddlehurst1c@paginegialle.it", "Davis", 0, "$2b$10$HFUotd2P2AL62zC5..3oG.8XErrEIqqM9DAHdLj8pI/lHzjWGtyMK", false, new DateTime(2023, 2, 24, 15, 13, 31, 779, DateTimeKind.Local).AddTicks(6882), "Middlehurst", null, null, "03494633510", 2, "dmiddlehurst1c" },
                    { new Guid("6e0580a0-f418-427e-8722-a2bbbb3ff819"), "086080433821", new DateTime(2011, 10, 21, 9, 10, 42, 0, DateTimeKind.Unspecified), "obeaments@bbb.org", "Otho", 2, "$2b$10$Vx5TaYHy6EEhuRDUR4lRrel2kJl.AkK8Dpd0.G2DHff9Sql0K1HIG", false, new DateTime(2023, 2, 24, 15, 13, 29, 731, DateTimeKind.Local).AddTicks(3650), "Beament", null, null, "0756962604", 2, "obeaments" },
                    { new Guid("6e53457f-5191-4720-8c65-d95bb6a49128"), "035388482385", new DateTime(2010, 11, 22, 14, 55, 17, 0, DateTimeKind.Unspecified), "gswanson24@umn.edu", "Gray", 2, "$2b$10$TcxWjnRCPuBXQf/wNyzmGuO5cl0qVRrNX13PQUHmmVtz70GGYlV62", false, new DateTime(2023, 2, 24, 15, 13, 34, 506, DateTimeKind.Local).AddTicks(4677), "Swanson", null, null, "09572022187", 1, "gswanson24" },
                    { new Guid("6f47b522-cba9-477b-b3a9-eaa24c13f53b"), "089699705242", new DateTime(2021, 7, 17, 16, 50, 18, 0, DateTimeKind.Unspecified), "mgarriochk@alexa.com", "Mavra", 2, "$2b$10$n6.FrGZHRdC4FV2y6G3HL.47H/0FTsyRhaxSGoUj.Vbfg73kh.f4G", false, new DateTime(2023, 2, 24, 15, 13, 29, 80, DateTimeKind.Local).AddTicks(8674), "Garrioch", null, null, "0072752247", 1, "mgarriochk" },
                    { new Guid("72b4cd5c-dd2f-4133-9a27-b69d94ee9892"), "087469312826", new DateTime(2009, 10, 2, 1, 14, 43, 0, DateTimeKind.Unspecified), "jeliassen2f@github.com", "Jack", 1, "$2b$10$0C.jy5sbebv5AhYN/1e5m.SM17vRiaX3W/yUeBFPzoraXH4spM.Vm", false, new DateTime(2023, 2, 24, 15, 13, 35, 901, DateTimeKind.Local).AddTicks(343), "Eliassen", null, null, "06497524328", 1, "jeliassen2f" },
                    { new Guid("72df9ffc-3437-4041-ae4b-6f1f77eace37"), "058273945153", new DateTime(2012, 5, 7, 16, 43, 46, 0, DateTimeKind.Unspecified), "kbeamson2z@a8.net", "Kathy", 1, "$2b$10$vzqseqfpmiI1Nd8r8ljN4eFJAjbLxfOdZoe5cwhdnnjc93yJJ6Ff6", false, new DateTime(2023, 2, 24, 15, 13, 38, 255, DateTimeKind.Local).AddTicks(8429), "Beamson", null, null, "07242980517", 1, "kbeamson2z" },
                    { new Guid("758156bb-2a85-4913-93a1-eb16399d7dc5"), "068384339812", new DateTime(2019, 12, 19, 12, 9, 19, 0, DateTimeKind.Unspecified), "bgostickt@youtu.be", "Bentlee", 1, "$2b$10$rk0E1yje4iRPUfGt89p6Auy1DVhqG.D/g0Kl0.ImX1PbEb2IRWwHu", false, new DateTime(2023, 2, 24, 15, 13, 29, 819, DateTimeKind.Local).AddTicks(3609), "Gostick", null, null, "05617299637", 1, "bgostickt" },
                    { new Guid("7752e1ab-8cb1-4ad9-bff2-85ed8b1e80a6"), "017928584847", new DateTime(2011, 4, 24, 12, 40, 5, 0, DateTimeKind.Unspecified), "tstrooband18@yolasite.com", "Tawsha", 2, "$2b$10$t8XlM3HkbqmZoTwz0yaUY.1Aox10/mCd69BVBTG1dc60oO8I2yb9i", false, new DateTime(2023, 2, 24, 15, 13, 31, 361, DateTimeKind.Local).AddTicks(2170), "Strooband", null, null, "0129884328", 1, "tstrooband18" },
                    { new Guid("78dfe61b-e986-4644-ace6-743f45cd4aa0"), "019502501861", new DateTime(2016, 11, 24, 13, 12, 53, 0, DateTimeKind.Unspecified), "mboustead0@businessweek.com", "Martita", 0, "$2b$10$i7I2PjgA48AYt/z86y237eEIRPIHrCU4Ok/DsZU1UUe.tVcilxSnK", false, new DateTime(2023, 2, 24, 15, 13, 27, 594, DateTimeKind.Local).AddTicks(8807), "Boustead", null, null, "06868143899", 1, "mboustead0" },
                    { new Guid("7d4ac7bd-5952-4b99-8d34-71d503be0d64"), "039352634296", new DateTime(2009, 3, 26, 6, 33, 21, 0, DateTimeKind.Unspecified), "gtubbsg@examiner.com", "Gwyneth", 2, "$2b$10$VQ2fRO6mH4CDWkxwDm0tNu/aEniIrRoovUUERRvz3sII8wlfWhiA2", false, new DateTime(2023, 2, 24, 15, 13, 28, 796, DateTimeKind.Local).AddTicks(1193), "Tubbs", null, null, "0630308378", 2, "gtubbsg" },
                    { new Guid("7d68b131-beff-4509-8a5a-f1da99b1799e"), "094844289819", new DateTime(2011, 9, 8, 19, 44, 33, 0, DateTimeKind.Unspecified), "czamorano1v@sakura.ne.jp", "Christophorus", 2, "$2b$10$/uPseGx2sGr6kABTobkRMOjSGhLnoK21TG09r7SIJueFPYBgqFTj6", false, new DateTime(2023, 2, 24, 15, 13, 33, 745, DateTimeKind.Local).AddTicks(4310), "Zamorano", null, null, "0619225384", 2, "czamorano1v" },
                    { new Guid("7db6fe35-00a3-401c-96d1-af884fafc71d"), "042819995246", new DateTime(2004, 9, 30, 14, 11, 23, 0, DateTimeKind.Unspecified), "mmcmechan17@lycos.com", "Malinde", 1, "$2b$10$Bdz634LW7GT5JFfo7E0cD.gDKcv/KtmT5s7y767TLyAxP1xZBynky", false, new DateTime(2023, 2, 24, 15, 13, 31, 263, DateTimeKind.Local).AddTicks(8303), "McMechan", null, null, "0613503781", 2, "mmcmechan17" },
                    { new Guid("804fd8d9-6535-4733-997c-17197b970b73"), "089749871106", new DateTime(2011, 12, 5, 0, 28, 56, 0, DateTimeKind.Unspecified), "mbaldacchino2q@alexa.com", "Marcus", 0, "$2b$10$9KjS2mIID3nnwkJa3uvUXuNKUKh03cXkJqqWSO0fPDFAUQUk1MB26", false, new DateTime(2023, 2, 24, 15, 13, 37, 152, DateTimeKind.Local).AddTicks(7884), "Baldacchino", null, null, "05380625199", 1, "mbaldacchino2q" },
                    { new Guid("823261ad-e66d-4f63-8926-291c5459ed84"), "067016693206", new DateTime(2011, 2, 26, 17, 55, 50, 0, DateTimeKind.Unspecified), "bpetrescu2j@walmart.com", "Brook", 2, "$2b$10$cRpqjWTdymFP3ncs3zaR1eVntOLnRP5sobr4yruyB1Qw0sajN2E16", false, new DateTime(2023, 2, 24, 15, 13, 36, 340, DateTimeKind.Local).AddTicks(785), "Petrescu", null, null, "0719013924", 1, "bpetrescu2j" },
                    { new Guid("856ea2c3-ba93-4b9b-9ea9-eb198ecca5c1"), "077582527961", new DateTime(2007, 12, 6, 5, 32, 27, 0, DateTimeKind.Unspecified), "smackieson1i@microsoft.com", "Sande", 1, "$2b$10$xaPBJPFSaX8o3YPDbclsWegvwhKWm22Ia1/M8c3HAyPPtaf8GC1Q6", false, new DateTime(2023, 2, 24, 15, 13, 32, 420, DateTimeKind.Local).AddTicks(7581), "Mackieson", null, null, "07046670689", 2, "smackieson1i" },
                    { new Guid("86251e4a-6c64-4cab-ae2e-6c114714f3cf"), "078854231390", new DateTime(2010, 9, 16, 18, 2, 55, 0, DateTimeKind.Unspecified), "mspaldin2b@oakley.com", "Maud", 0, "$2b$10$IdKntlVh.wNXJ8K1V4j6B.tndZsw9EF2.3NaG9fLzWZioeCSlK2KG", false, new DateTime(2023, 2, 24, 15, 13, 35, 391, DateTimeKind.Local).AddTicks(6257), "Spaldin", null, null, "0596030481", 1, "mspaldin2b" },
                    { new Guid("8d351e77-1850-4555-bb2f-26a7010f515d"), "037904808301", new DateTime(2006, 8, 30, 9, 3, 21, 0, DateTimeKind.Unspecified), "gcanti28@ucoz.ru", "Gram", 1, "$2b$10$c215G7cNw7B3XJxgL5QFGe3ByDfbOmLTwu2N6BwpC8MstzDuZRb4y", false, new DateTime(2023, 2, 24, 15, 13, 34, 963, DateTimeKind.Local).AddTicks(6388), "Canti", null, null, "07734012207", 1, "gcanti28" },
                    { new Guid("8e01c3a4-8f40-4c57-b179-e2f51f493c27"), "021190690053", new DateTime(2015, 5, 10, 0, 52, 10, 0, DateTimeKind.Unspecified), "kdroghan1k@netscape.com", "Koressa", 1, "$2b$10$eBMuAiwcmhDb1bkv0vp9T.2TAQwiGbjXjYOmmUrSxfTXYj0HwL.RC", false, new DateTime(2023, 2, 24, 15, 13, 32, 642, DateTimeKind.Local).AddTicks(6708), "Droghan", null, null, "0910618733", 2, "kdroghan1k" },
                    { new Guid("8f20d302-b3ae-4b49-93f6-eae84fecceeb"), "051040211116", new DateTime(2016, 4, 12, 2, 53, 13, 0, DateTimeKind.Unspecified), "cdreossi11@google.com", "Cozmo", 0, "$2b$10$JtLJPFuyOqKTuKDeHv68zO2ArUE4/.Q1KpvFrBD.ucjaV1lIPvC1O", false, new DateTime(2023, 2, 24, 15, 13, 30, 618, DateTimeKind.Local).AddTicks(4446), "Dreossi", null, null, "03724370545", 2, "cdreossi11" },
                    { new Guid("93b43bd5-4e6c-4f3d-b776-47a83088cfcf"), "071531684528", new DateTime(2021, 5, 7, 14, 13, 30, 0, DateTimeKind.Unspecified), "kgoddmano@quantcast.com", "Karl", 1, "$2b$10$PtoE59FCEUv9jF2DvnOHduO0Xlkeff63s5o4wZloYvHGWoDb.d7je", false, new DateTime(2023, 2, 24, 15, 13, 29, 356, DateTimeKind.Local).AddTicks(4130), "Goddman", null, null, "00110582594", 2, "kgoddmano" },
                    { new Guid("93d24d75-0c45-44c6-a1f8-4b7f8bb45515"), "001109382787", new DateTime(2021, 10, 26, 16, 18, 3, 0, DateTimeKind.Unspecified), "blaidel1e@ucla.edu", "Betsey", 2, "$2b$10$fm3lSJcO8HWU41R6CSKHEOB6FB9RPjZj5hSGtXmffsGE4/cKf8OZy", false, new DateTime(2023, 2, 24, 15, 13, 31, 991, DateTimeKind.Local).AddTicks(1758), "Laidel", null, null, "06837677860", 2, "blaidel1e" },
                    { new Guid("9534d522-45cb-4485-aadc-d568dec879f9"), "056534722467", new DateTime(2018, 8, 13, 15, 36, 44, 0, DateTimeKind.Unspecified), "bwebling1s@google.co.jp", "Blinni", 0, "$2b$10$gCXhxhLHFaNU9Q54RJx2cOg8r.1x3gDyxZVvPyDXJN/oC/WkPYoXC", false, new DateTime(2023, 2, 24, 15, 13, 33, 456, DateTimeKind.Local).AddTicks(7432), "Webling", null, null, "0390471753", 2, "bwebling1s" },
                    { new Guid("96da5712-5866-4ebd-b969-6e3d2d83baee"), "045861002417", new DateTime(2021, 3, 10, 15, 21, 20, 0, DateTimeKind.Unspecified), "fainscow2a@cnbc.com", "Falkner", 2, "$2b$10$Q1LBhlQQMt.aOQ8YWt9quOR/JKpBUiXf1xoHTAjPZD4ODBz21VJXy", false, new DateTime(2023, 2, 24, 15, 13, 35, 248, DateTimeKind.Local).AddTicks(9461), "Ainscow", null, null, "0878444767", 1, "fainscow2a" },
                    { new Guid("9873c2a2-1195-4233-8576-7b0fe83e1e0c"), "051913950498", new DateTime(2020, 2, 21, 20, 25, 10, 0, DateTimeKind.Unspecified), "sdemeltd@cafepress.com", "Sunny", 0, "$2b$10$Avx82Dhfald9VvPNkJp21.cCvwBwaxktXIXjfbm4SPvGiod0iZvd2", false, new DateTime(2023, 2, 24, 15, 13, 28, 589, DateTimeKind.Local).AddTicks(3884), "Demelt", null, null, "0795784606", 1, "sdemeltd" },
                    { new Guid("99b75264-7f92-4755-bd22-69e52c9e7f50"), "016258873676", new DateTime(2019, 10, 21, 10, 25, 58, 0, DateTimeKind.Unspecified), "eoubridge2h@jiathis.com", "Ezra", 2, "$2b$10$dU7aWBONGBs0pRVQ3hgUieWGzLB5DWgjmvf8/nK1/PcJZJpG/tahK", false, new DateTime(2023, 2, 24, 15, 13, 36, 104, DateTimeKind.Local).AddTicks(4637), "Oubridge", null, null, "0429461131", 2, "eoubridge2h" },
                    { new Guid("9b0f16ed-6c5b-42eb-b6f7-59d370590259"), "094191070869", new DateTime(2017, 7, 13, 6, 59, 37, 0, DateTimeKind.Unspecified), "afaber2d@ed.gov", "Allison", 0, "$2b$10$QSV3a0jwQCxFaTwr3YCLdugyRzCZUMMSdmaIEco58LjzNBs2jNvZ6", false, new DateTime(2023, 2, 24, 15, 13, 35, 681, DateTimeKind.Local).AddTicks(1776), "Faber", null, null, "08586159848", 2, "afaber2d" },
                    { new Guid("9b2b52fd-2770-4017-8f6e-97fa320b6653"), "048688112760", new DateTime(2012, 7, 16, 20, 33, 8, 0, DateTimeKind.Unspecified), "astruss31@apache.org", "Alfons", 0, "$2b$10$J.UyMR9j3qo5b8X/svu7ceXTpwEjmeoDr6YMoLp.40lBwTkenYl4K", false, new DateTime(2023, 2, 24, 15, 13, 38, 449, DateTimeKind.Local).AddTicks(4582), "Struss", null, null, "06928824187", 2, "astruss31" },
                    { new Guid("9e67e714-97e1-4d06-b7a4-223bf67995fa"), "004140346503", new DateTime(2015, 5, 3, 9, 24, 20, 0, DateTimeKind.Unspecified), "mhallard1r@bbc.co.uk", "Madelyn", 0, "$2b$10$5MauEfo1JpS5Ml4dmpPGeuapSdtd3M68yJqA.ZFiUBCFUev3CdTKW", false, new DateTime(2023, 2, 24, 15, 13, 33, 361, DateTimeKind.Local).AddTicks(5853), "Hallard", null, null, "03332477053", 2, "mhallard1r" },
                    { new Guid("a525ef3e-b706-41b4-a8ec-2facd4a36a8f"), "036525634125", new DateTime(2009, 6, 7, 18, 22, 1, 0, DateTimeKind.Unspecified), "afilipchikov15@flickr.com", "Alric", 0, "$2b$10$y2PzPXl9PuJT/6pKsEKcQeMXm7cMjbnKDJ95qRMzyLhhJfZNnWBeG", false, new DateTime(2023, 2, 24, 15, 13, 31, 70, DateTimeKind.Local).AddTicks(6217), "Filipchikov", null, null, "0663461504", 2, "afilipchikov15" },
                    { new Guid("a6a79e56-ab95-429d-87a4-e444e0685c19"), "021166108883", new DateTime(2015, 4, 4, 6, 17, 4, 0, DateTimeKind.Unspecified), "mgleesone@youtu.be", "Myrna", 0, "$2b$10$dAUI7XejN0YqwQUKv40lUOxQg1buWqJu0sBL7xGcNZ/uu0e2w44ZK", false, new DateTime(2023, 2, 24, 15, 13, 28, 658, DateTimeKind.Local).AddTicks(7503), "Gleeson", null, null, "0060336533", 1, "mgleesone" },
                    { new Guid("a712c413-4aad-4143-a382-3d542400f533"), "097057026915", new DateTime(2005, 11, 24, 5, 43, 18, 0, DateTimeKind.Unspecified), "afitzhenry2g@weibo.com", "Alexis", 1, "$2b$10$lipYfNpEv1.XFpW9j9IF4uPHvrhtMiPW8oW3TtDgZkkpYDLjHxjL6", false, new DateTime(2023, 2, 24, 15, 13, 35, 999, DateTimeKind.Local).AddTicks(957), "Fitzhenry", null, null, "04780696921", 1, "afitzhenry2g" },
                    { new Guid("aa78c7bc-c42e-40c6-89cb-9305191b283b"), "063520674382", new DateTime(2020, 7, 27, 16, 29, 14, 0, DateTimeKind.Unspecified), "ogasperi2l@furl.net", "Orson", 2, "$2b$10$Yj4IRpdu3jcEk2uMbzBNG.P8u2/E3LVWg5tlEhNaK63MayWlehZcm", false, new DateTime(2023, 2, 24, 15, 13, 36, 560, DateTimeKind.Local).AddTicks(1371), "Gasperi", null, null, "03723162025", 2, "ogasperi2l" },
                    { new Guid("af9642b0-0042-4bac-9c07-5aa6079d1abb"), "009972130313", new DateTime(2020, 2, 18, 3, 49, 41, 0, DateTimeKind.Unspecified), "gstranger1x@github.io", "Grantley", 1, "$2b$10$mpDRDsEhuJhog4rvljwOu.5KQt.VkpOvemU5PCWz.KqQjRlLSORo2", false, new DateTime(2023, 2, 24, 15, 13, 33, 916, DateTimeKind.Local).AddTicks(9378), "Stranger", null, null, "03239623484", 2, "gstranger1x" },
                    { new Guid("b0baf274-42e2-4509-a1e2-e54f5da15097"), "016226254596", new DateTime(2009, 12, 18, 14, 29, 44, 0, DateTimeKind.Unspecified), "rlerew@newyorker.com", "Reinaldo", 2, "$2b$10$jPGw8HaIM50yKwyAmf8Fium8.BU5Mrn6yVbBaYBNSneXJuwxotvdi", false, new DateTime(2023, 2, 24, 15, 13, 30, 132, DateTimeKind.Local).AddTicks(6538), "Lere", null, null, "04037990815", 1, "rlerew" },
                    { new Guid("b0e56e12-8fd7-41c6-90aa-e9dafb893d76"), "057500382194", new DateTime(2020, 10, 20, 16, 48, 58, 0, DateTimeKind.Unspecified), "dlannen25@godaddy.com", "Drake", 2, "$2b$10$BfbPHsSPeABeNp.oeX4uF.t5Afa3meNYLy1QCN5zpfsf/yyMrSacm", false, new DateTime(2023, 2, 24, 15, 13, 34, 609, DateTimeKind.Local).AddTicks(9484), "Lannen", null, null, "04000508789", 1, "dlannen25" },
                    { new Guid("b40ce9c1-8fb8-463c-846d-086d7184841e"), "025425126590", new DateTime(2016, 11, 11, 3, 36, 31, 0, DateTimeKind.Unspecified), "jmiltonwhite1a@com.com", "Justine", 1, "$2b$10$A103TfN.owKU4xyaYYF7Xe.9RSVz4YqlMAd.IqqT.puINPsxdmKbC", false, new DateTime(2023, 2, 24, 15, 13, 31, 576, DateTimeKind.Local).AddTicks(2889), "Milton-White", null, null, "0602588523", 2, "jmiltonwhite1a" },
                    { new Guid("b6a67262-43c4-4a4a-9c33-38d9f3c45461"), "058847964276", new DateTime(2011, 4, 12, 12, 19, 15, 0, DateTimeKind.Unspecified), "cmaddysonm@technorati.com", "Crawford", 1, "$2b$10$cjoo5eDiLc/w.IZnoNA3hO9yiSkAvHLcr1ibr0MsbgSniR63RxYge", false, new DateTime(2023, 2, 24, 15, 13, 29, 216, DateTimeKind.Local).AddTicks(1256), "Maddyson", null, null, "0915548406", 2, "cmaddysonm" },
                    { new Guid("b78f228b-61a6-49bf-9e6b-754b6c588c1e"), "070158745130", new DateTime(2013, 3, 26, 2, 47, 36, 0, DateTimeKind.Unspecified), "channen1n@ihg.com", "Catarina", 0, "$2b$10$1Fl8hYDswFwFAoA3KQfgeOkWRekXk..pWS5Lkcz3BCvpnzBHee2SS", false, new DateTime(2023, 2, 24, 15, 13, 32, 980, DateTimeKind.Local).AddTicks(9403), "Hannen", null, null, "06533305742", 2, "channen1n" },
                    { new Guid("b8e038fc-2939-4b4e-9ac9-7d89f626381a"), "085576611181", new DateTime(2017, 9, 4, 20, 7, 33, 0, DateTimeKind.Unspecified), "ewarnesv@chron.com", "Ellette", 2, "$2b$10$ydI/GldufJVibCpP4wLT0uDUuDtS0b3xJlPpwu4crUm2Ji8jyi28G", false, new DateTime(2023, 2, 24, 15, 13, 30, 40, DateTimeKind.Local).AddTicks(2884), "Warnes", null, null, "0812419659", 2, "ewarnesv" },
                    { new Guid("b97698af-84af-402c-ac7d-c7f9ffd4d1af"), "092881420122", new DateTime(2017, 10, 31, 19, 50, 36, 0, DateTimeKind.Unspecified), "okroch16@amazon.com", "Olenka", 2, "$2b$10$bMAq2w0kuqrY076CllN3s.l9yzbRZK4.lRhHivT7wGgjpeUmfuH.K", false, new DateTime(2023, 2, 24, 15, 13, 31, 160, DateTimeKind.Local).AddTicks(7026), "Kroch", null, null, "09201855247", 1, "okroch16" },
                    { new Guid("be76fc0e-4a41-40ba-b790-f4586c3c82b4"), "094925101592", new DateTime(2012, 12, 24, 11, 22, 7, 0, DateTimeKind.Unspecified), "mharnottu@ibm.com", "Maressa", 1, "$2b$10$aOnb/ui1FasBZ.Qi8NQ78eRZ5CB/O344fHHPzB6c5I7.nPpso7yYW", false, new DateTime(2023, 2, 24, 15, 13, 29, 898, DateTimeKind.Local).AddTicks(7094), "Harnott", null, null, "00039497181", 2, "mharnottu" },
                    { new Guid("c20f4963-6ddd-4cbb-91d7-0657c7f84052"), "013377261786", new DateTime(2020, 1, 8, 12, 55, 9, 0, DateTimeKind.Unspecified), "pshufflebotham1j@hatena.ne.jp", "Pavlov", 0, "$2b$10$7soIf9RtwLmFY6hqoNw2M.zWxHRJXqjq7E8GCeWStU8qjkmB.AOou", false, new DateTime(2023, 2, 24, 15, 13, 32, 542, DateTimeKind.Local).AddTicks(162), "Shufflebotham", null, null, "0960301131", 2, "pshufflebotham1j" },
                    { new Guid("c260b105-5531-42ac-af12-dbd8b968791e"), "040760923509", new DateTime(2016, 11, 21, 23, 37, 37, 0, DateTimeKind.Unspecified), "spetteford1b@jugem.jp", "Sean", 2, "$2b$10$0LLkC2hlc4Ulz7ZgsfUPwuysaKi2jyQ/kghuM9Nvwx2groXEgw/I2", false, new DateTime(2023, 2, 24, 15, 13, 31, 651, DateTimeKind.Local).AddTicks(5363), "Petteford", null, null, "0939882707", 2, "spetteford1b" },
                    { new Guid("c563aea4-df53-4d0e-9ac6-234d2aca1442"), "033840798257", new DateTime(2007, 9, 30, 12, 3, 49, 0, DateTimeKind.Unspecified), "tgareisr1g@theglobeandmail.com", "Tina", 2, "$2b$10$qi.f4iEntWpXQAJykBXnm.AnlKlwH0I7/HbBoCcTDLwTVBGIfKAUi", false, new DateTime(2023, 2, 24, 15, 13, 32, 206, DateTimeKind.Local).AddTicks(3540), "Gareisr", null, null, "07314447051", 2, "tgareisr1g" },
                    { new Guid("c73ac387-02c4-48ed-a129-4f1790d80847"), "041401323997", new DateTime(2011, 8, 11, 17, 37, 59, 0, DateTimeKind.Unspecified), "nmartinyuki@g.co", "Nadine", 0, "$2b$10$JpG.wPy/MRVQoEJvB6iJTezMacN3EjXJl2VxMaHi7Zam6YC.irAqS", false, new DateTime(2023, 2, 24, 15, 13, 28, 939, DateTimeKind.Local).AddTicks(2038), "Martinyuk", null, null, "0766805261", 2, "nmartinyuki" },
                    { new Guid("cb29504a-79c0-4ed4-863f-aea2df1a5266"), "052011153408", new DateTime(2017, 4, 13, 21, 35, 29, 0, DateTimeKind.Unspecified), "astewart2@businesswire.com", "Aliza", 2, "$2b$10$b9KEGQuq5.TmtuktG38ZhO/KyymGWvZF/3VqTLkFItLIe1EsXoy5q", false, new DateTime(2023, 2, 24, 15, 13, 27, 776, DateTimeKind.Local).AddTicks(7080), "Stewart", null, null, "07343082906", 1, "astewart2" },
                    { new Guid("cc6d2e2a-d8a0-4238-b9d5-25bbde55adc5"), "043599301481", new DateTime(2010, 8, 17, 9, 15, 10, 0, DateTimeKind.Unspecified), "bbolverq@geocities.com", "Brigit", 1, "$2b$10$Ii3SNjpS8FS8Gs0LRPj27evFMYeuCCZkkH5kvd89rtjwbMKmO4gl.", false, new DateTime(2023, 2, 24, 15, 13, 29, 516, DateTimeKind.Local).AddTicks(6049), "Bolver", null, null, "0361641052", 2, "bbolverq" },
                    { new Guid("cda780ef-e3d1-44ed-b164-f5bfc83fe543"), "084002745064", new DateTime(2009, 7, 20, 0, 0, 45, 0, DateTimeKind.Unspecified), "cstorie5@merriam-webster.com", "Charlot", 1, "$2b$10$OyVBAHGCWpbjwn/2.1jCrOBAG7YGWLSI05sHQzI09ePCx2Nj08ZWm", false, new DateTime(2023, 2, 24, 15, 13, 27, 990, DateTimeKind.Local).AddTicks(4061), "Storie", null, null, "0812332458", 1, "cstorie5" },
                    { new Guid("cdb93948-be86-44d1-8f84-7039ad1a4fd6"), "094290985539", new DateTime(2005, 10, 19, 23, 47, 55, 0, DateTimeKind.Unspecified), "aoconnor14@e-recht24.de", "Almeta", 0, "$2b$10$sHjoWiipqJr9k7Vg0cr6ceMfVEJlQR1tzs8HZdFXIUixlBCu/3a9O", false, new DateTime(2023, 2, 24, 15, 13, 30, 989, DateTimeKind.Local).AddTicks(473), "O'Connor", null, null, "0750854688", 1, "aoconnor14" },
                    { new Guid("d4e68381-25f4-4fe3-aca4-4ba61dd5b38c"), "027587962774", new DateTime(2011, 2, 14, 16, 13, 43, 0, DateTimeKind.Unspecified), "rlavensh@livejournal.com", "Rosalyn", 2, "$2b$10$uYL/Rvs6QcmYRHKiPFHs7eEXyYoWlJeLsigKlpBT9oQRS/HsRHEx.", false, new DateTime(2023, 2, 24, 15, 13, 28, 873, DateTimeKind.Local).AddTicks(8234), "Lavens", null, null, "06895509784", 2, "rlavensh" },
                    { new Guid("d58bc123-f067-4807-9477-2932216c5f9b"), "093312640912", new DateTime(2006, 4, 28, 13, 16, 9, 0, DateTimeKind.Unspecified), "cbartosek6@ebay.com", "Carmela", 0, "$2b$10$6DhzF8Uz2okBK5GsIBO0/uULdfO6x2ruo505mN9GHq8zjakpc0PnS", false, new DateTime(2023, 2, 24, 15, 13, 28, 55, DateTimeKind.Local).AddTicks(4202), "Bartosek", null, null, "0266983899", 1, "cbartosek6" },
                    { new Guid("d77dbf2c-72e4-48f8-be29-c244e0d32c0a"), "074959046988", new DateTime(2017, 2, 22, 11, 44, 21, 0, DateTimeKind.Unspecified), "overnall2p@ameblo.jp", "Oneida", 1, "$2b$10$jUi7XtFSuutiL2xCgnvYkuGvxYV8OkdDlklukfbe6RjuKGZwlIb5y", false, new DateTime(2023, 2, 24, 15, 13, 37, 4, DateTimeKind.Local).AddTicks(8290), "Vernall", null, null, "05157407415", 1, "overnall2p" },
                    { new Guid("d9d180b9-8692-4cdc-86bc-87fb583cf9bb"), "039542282063", new DateTime(2017, 7, 26, 22, 10, 59, 0, DateTimeKind.Unspecified), "kashpole1h@nifty.com", "Kirstin", 1, "$2b$10$ZnnesI25OFfQqYmCWdRDp.h1FXdx/5IPHlQlJgDkmjyXdMhMPFs46", false, new DateTime(2023, 2, 24, 15, 13, 32, 302, DateTimeKind.Local).AddTicks(6213), "Ashpole", null, null, "03667705539", 1, "kashpole1h" },
                    { new Guid("db7b141e-c7c2-437f-a2c6-49aa0d735de2"), "016396077329", new DateTime(2018, 3, 20, 9, 6, 41, 0, DateTimeKind.Unspecified), "siacovacci2r@seattletimes.com", "Shanna", 0, "$2b$10$z7.oKuOmtVagjdvBWbIwieag97KYpbPfa20zyj1D94QusvvWUYgdy", false, new DateTime(2023, 2, 24, 15, 13, 37, 308, DateTimeKind.Local).AddTicks(1695), "Iacovacci", null, null, "0770070777", 1, "siacovacci2r" },
                    { new Guid("dbcd87c9-2184-46d0-9064-0b0bebd53c4a"), "078923959822", new DateTime(2005, 9, 1, 0, 43, 2, 0, DateTimeKind.Unspecified), "csaban2n@admin.ch", "Cobbie", 0, "$2b$10$Z2ak5VsWKPSK4qADAARetOG039y9l4vzUgWMh5BMH6n3r/R.VbKFi", false, new DateTime(2023, 2, 24, 15, 13, 36, 768, DateTimeKind.Local).AddTicks(7534), "Saban", null, null, "02156386100", 1, "csaban2n" },
                    { new Guid("e2120919-b44e-4ef2-a2cf-833851488923"), "096684216299", new DateTime(2021, 10, 9, 9, 27, 7, 0, DateTimeKind.Unspecified), "smasser2v@virginia.edu", "Sandie", 0, "$2b$10$B48FMwEUAt1yxaCxqYxZGu7h3XMS9SBIaoxcqQduoaJiE97N3.Bii", false, new DateTime(2023, 2, 24, 15, 13, 37, 819, DateTimeKind.Local).AddTicks(7154), "Masser", null, null, "0612845922", 2, "smasser2v" },
                    { new Guid("e28c8bba-f492-47df-aaa7-834445044bf4"), "017193152173", new DateTime(2020, 8, 11, 20, 40, 0, 0, DateTimeKind.Unspecified), "imilesap9@plala.or.jp", "Iorgo", 1, "$2b$10$Z94NxqucMO9jCcydPKRJr.s68HGr.HwdTndDL6fOvk.fpVkf7eLHi", false, new DateTime(2023, 2, 24, 15, 13, 28, 310, DateTimeKind.Local).AddTicks(7430), "Milesap", null, null, "08524784466", 1, "imilesap9" },
                    { new Guid("e5659345-e564-483f-b25f-c5eca715fe9d"), "098782331580", new DateTime(2016, 11, 3, 18, 7, 41, 0, DateTimeKind.Unspecified), "mskirvinn@blogs.com", "Marley", 1, "$2b$10$yV/Niqxox4pzEl3v4LCQ/uZ5MlWo.3swhH.urP2W7fh6gSx683eCa", false, new DateTime(2023, 2, 24, 15, 13, 29, 282, DateTimeKind.Local).AddTicks(7777), "Skirvin", null, null, "0614302061", 1, "mskirvinn" },
                    { new Guid("e82e00a2-21ef-429b-87ba-e89e43b603f4"), "021177218653", new DateTime(2018, 1, 18, 15, 2, 2, 0, DateTimeKind.Unspecified), "kmacgorrie1d@quantcast.com", "Koren", 2, "$2b$10$867W2u6mPE77F2huXJgpI.0uqEfCb/SC1TfjI5vAbVJewFLct43Du", false, new DateTime(2023, 2, 24, 15, 13, 31, 900, DateTimeKind.Local).AddTicks(3260), "MacGorrie", null, null, "0259328059", 2, "kmacgorrie1d" },
                    { new Guid("ea4e3a10-4fdc-4816-8c81-20d2b1f66368"), "098716602446", new DateTime(2009, 11, 27, 8, 32, 15, 0, DateTimeKind.Unspecified), "lbrechin2t@myspace.com", "Lisette", 1, "$2b$10$Z5Vs3TFP2ENZjHYat4.I1eeXfeejuuXzCGyN0RDU.WkjdjnNLFC0a", false, new DateTime(2023, 2, 24, 15, 13, 37, 604, DateTimeKind.Local).AddTicks(6012), "Brechin", null, null, "0285671009", 1, "lbrechin2t" },
                    { new Guid("eb064e4e-21a0-48e5-b5e5-b0b3c168263d"), "048251664467", new DateTime(2006, 4, 4, 5, 50, 12, 0, DateTimeKind.Unspecified), "ngrandhamf@ihg.com", "Nonna", 0, "$2b$10$V6.8akPr5iT6G0df5vvTteRXdCaMORRzaq7/UcL3Tlv1whmnXXy.m", false, new DateTime(2023, 2, 24, 15, 13, 28, 727, DateTimeKind.Local).AddTicks(3567), "Grandham", null, null, "07995009500", 2, "ngrandhamf" },
                    { new Guid("f1fbe8ee-d179-435e-a507-309e069d9c20"), "003103660901", new DateTime(2017, 11, 17, 20, 18, 20, 0, DateTimeKind.Unspecified), "rdunsfordp@wikispaces.com", "Ryon", 2, "$2b$10$6Z3DJuZ37XrnYgDlAG00.OflvUO1douQowHkR/uBZ3Dxk/zmQ8P76", false, new DateTime(2023, 2, 24, 15, 13, 29, 430, DateTimeKind.Local).AddTicks(6720), "Dunsford", null, null, "00868235500", 1, "rdunsfordp" },
                    { new Guid("f348671e-ea32-4d34-91cf-92281b268ac0"), "074563912201", new DateTime(2018, 10, 29, 20, 37, 6, 0, DateTimeKind.Unspecified), "rlatan21@google.de", "Rorke", 2, "$2b$10$sE8GCahQI6lh/SE15pJZuOTIDMOWgypRXbLagMBpNWiOuw20U5z26", false, new DateTime(2023, 2, 24, 15, 13, 34, 251, DateTimeKind.Local).AddTicks(171), "Latan", null, null, "07949258154", 1, "rlatan21" },
                    { new Guid("f3b52c02-07b9-4337-94a0-94c2ef6519d5"), "023468783438", new DateTime(2020, 3, 25, 1, 18, 42, 0, DateTimeKind.Unspecified), "tprater32@squarespace.com", "Trev", 0, "$2b$10$tAIkn6wDsNSGkGI1b3ld4.Wchpta8OuuMSFMJ2n7o5aCZQ0tOKFOe", false, new DateTime(2023, 2, 24, 15, 13, 38, 538, DateTimeKind.Local).AddTicks(7898), "Prater", null, null, "0629137900", 1, "tprater32" },
                    { new Guid("f3ff20fb-9337-4d4c-86d7-87f0f8a1a89e"), "003413126760", new DateTime(2011, 8, 20, 12, 3, 46, 0, DateTimeKind.Unspecified), "emattam1f@opensource.org", "Elmo", 1, "$2b$10$pmG7d6ueBm.eUb6q/JxIFuyZJwcIlMFSV3fZq1HTfV0imoHXKZPO6", false, new DateTime(2023, 2, 24, 15, 13, 32, 98, DateTimeKind.Local).AddTicks(466), "Mattam", null, null, "0865586458", 2, "emattam1f" },
                    { new Guid("f40d44e7-59b1-4f6d-ad4c-b9805be3c356"), "022362093227", new DateTime(2010, 7, 29, 22, 50, 40, 0, DateTimeKind.Unspecified), "candriessen2o@myspace.com", "Clair", 0, "$2b$10$CNq/Fp39VNzRGbY6f6ZkjeJaENm/qUfWYtecQdBFOF25m2J73lXxG", false, new DateTime(2023, 2, 24, 15, 13, 36, 882, DateTimeKind.Local).AddTicks(259), "Andriessen", null, null, "05873824805", 2, "candriessen2o" },
                    { new Guid("f772b82c-62bf-4cde-a8bd-ddaa7aec743e"), "044455502617", new DateTime(2018, 2, 7, 1, 51, 37, 0, DateTimeKind.Unspecified), "rglison27@cbslocal.com", "Renee", 1, "$2b$10$UIGu8/BFaM0WYzQqfUwNxemE8s9IK.25u37C.8JJj29VIdCgjsrmK", false, new DateTime(2023, 2, 24, 15, 13, 34, 840, DateTimeKind.Local).AddTicks(7075), "Glison", null, null, "06769810772", 1, "rglison27" },
                    { new Guid("f97aab1b-e473-410e-9d4b-1dadca9d9888"), "061656096074", new DateTime(2016, 8, 21, 2, 23, 29, 0, DateTimeKind.Unspecified), "rpolden1w@pinterest.com", "Randy", 1, "$2b$10$PzRmGSYXMuSxuJVJLIz2x.uISiuhbSdUzZEl.sPCzBMhwLkja2R9.", false, new DateTime(2023, 2, 24, 15, 13, 33, 833, DateTimeKind.Local).AddTicks(1422), "Polden", null, null, "0831072797", 1, "rpolden1w" },
                    { new Guid("faec6a79-606f-42fd-883e-646fc1db4aac"), "009549428401", new DateTime(2019, 10, 11, 14, 57, 7, 0, DateTimeKind.Unspecified), "cbriston10@imgur.com", "Cesar", 1, "$2b$10$PnbExqdWirrGCsrZsjIAEuPrMCAkib.6yK95yWnepIuSo2pgh2BuS", false, new DateTime(2023, 2, 24, 15, 13, 30, 543, DateTimeKind.Local).AddTicks(2751), "Briston", null, null, "02637402338", 2, "cbriston10" },
                    { new Guid("fc97937c-45d6-4cbf-adfa-c5053760562f"), "067750080669", new DateTime(2014, 11, 30, 22, 35, 53, 0, DateTimeKind.Unspecified), "skearns1z@soup.io", "Sela", 2, "$2b$10$xrjBKG8bY/LMGyCdNB3mX.cg/KoWTSsfGmR3NLpcP.rxv4c2oL962", false, new DateTime(2023, 2, 24, 15, 13, 34, 89, DateTimeKind.Local).AddTicks(8542), "Kearns", null, null, "0461097167", 1, "skearns1z" },
                    { new Guid("ff9e1800-0f20-4209-8fb1-a25372e7cd63"), "097345428208", new DateTime(2005, 10, 17, 6, 16, 37, 0, DateTimeKind.Unspecified), "evargab@dot.gov", "Ellyn", 0, "$2b$10$Jdq80XxBCV4CMdkwNIk9j.inO.1aoaqlR1qXvaf0mViRNqxSMXmeK", false, new DateTime(2023, 2, 24, 15, 13, 28, 448, DateTimeKind.Local).AddTicks(5269), "Varga", null, null, "0652741657", 1, "evargab" }
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
                name: "Slots");

            migrationBuilder.DropTable(
                name: "TimeFrames");

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
