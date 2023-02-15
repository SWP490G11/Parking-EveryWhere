using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver151 : Migration
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
                    HashPasword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "ID", "DateOfBirth", "Email", "FirstName", "Gender", "HashPasword", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[] { new Guid("09910b99-0370-4929-a377-20d52813d2a8"), new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucnvhd772000@gmail.com", "Phuc", 0, "$2b$10$fHDE1P8C49b4wrh5RRJHUOHAAV/3ev0ikrQNQEDCLJxctQvCrYBW2", new DateTime(2023, 2, 12, 22, 5, 35, 194, DateTimeKind.Local).AddTicks(1611), " Nguyen Van", null, null, "0966416708", -772000, "phucnv" });

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
