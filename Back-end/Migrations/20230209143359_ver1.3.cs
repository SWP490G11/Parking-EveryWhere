using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MembershipPackages_Users_UserID",
                table: "MembershipPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_Parkings_TimeFrame_TimeFrameID",
                table: "Parkings");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_LastModifyByID",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Requests_LastModifyByID",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Parkings_TimeFrameID",
                table: "Parkings");

            migrationBuilder.DropIndex(
                name: "IX_MembershipPackages_UserID",
                table: "MembershipPackages");

            migrationBuilder.DropColumn(
                name: "LastModifyByID",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "TimeFrameID",
                table: "Parkings");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "MembershipPackages");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifyAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "MembershipPackageID",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoleID",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "TypeOfSlot",
                table: "Slots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "LAT",
                table: "Parkings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LON",
                table: "Parkings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifyAt",
                table: "ParkingPrices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifyByID",
                table: "ParkingPrices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ParkingTimeFrame",
                columns: table => new
                {
                    ParkingsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeFramesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingTimeFrame", x => new { x.ParkingsID, x.TimeFramesID });
                    table.ForeignKey(
                        name: "FK_ParkingTimeFrame_Parkings_ParkingsID",
                        column: x => x.ParkingsID,
                        principalTable: "Parkings",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ParkingTimeFrame_TimeFrame_TimeFramesID",
                        column: x => x.TimeFramesID,
                        principalTable: "TimeFrame",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_MembershipPackageID",
                table: "Users",
                column: "MembershipPackageID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingPrices_LastModifyByID",
                table: "ParkingPrices",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingTimeFrame_TimeFramesID",
                table: "ParkingTimeFrame",
                column: "TimeFramesID");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingPrices_Users_LastModifyByID",
                table: "ParkingPrices",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MembershipPackages_MembershipPackageID",
                table: "Users",
                column: "MembershipPackageID",
                principalTable: "MembershipPackages",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleID",
                table: "Users",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkingPrices_Users_LastModifyByID",
                table: "ParkingPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_MembershipPackages_MembershipPackageID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ParkingTimeFrame");

            migrationBuilder.DropIndex(
                name: "IX_Users_MembershipPackageID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ParkingPrices_LastModifyByID",
                table: "ParkingPrices");

            migrationBuilder.DropColumn(
                name: "LastModifyAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MembershipPackageID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TypeOfSlot",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "LAT",
                table: "Parkings");

            migrationBuilder.DropColumn(
                name: "LON",
                table: "Parkings");

            migrationBuilder.DropColumn(
                name: "LastModifyAt",
                table: "ParkingPrices");

            migrationBuilder.DropColumn(
                name: "LastModifyByID",
                table: "ParkingPrices");

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifyByID",
                table: "Requests",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TimeFrameID",
                table: "Parkings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "MembershipPackages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParkingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAT = table.Column<long>(type: "bigint", nullable: false),
                    LNT = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Locations_Parkings_ParkingID",
                        column: x => x.ParkingID,
                        principalTable: "Parkings",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Locations_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_LastModifyByID",
                table: "Requests",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_TimeFrameID",
                table: "Parkings",
                column: "TimeFrameID");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipPackages_UserID",
                table: "MembershipPackages",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ParkingID",
                table: "Locations",
                column: "ParkingID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_UserID",
                table: "Locations",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_MembershipPackages_Users_UserID",
                table: "MembershipPackages",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Parkings_TimeFrame_TimeFrameID",
                table: "Parkings",
                column: "TimeFrameID",
                principalTable: "TimeFrame",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_LastModifyByID",
                table: "Requests",
                column: "LastModifyByID",
                principalTable: "Users",
                principalColumn: "ID");
        }
    }
}
