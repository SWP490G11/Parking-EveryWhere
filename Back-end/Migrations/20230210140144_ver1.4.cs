using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_ParkingPrices_ParkingPriceID",
                table: "CarModels");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_ParkingPrices_ParkingPriceID",
                table: "Slots");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeFrame_ParkingPrices_ParkingPriceID",
                table: "TimeFrame");

            migrationBuilder.DropTable(
                name: "ParkingPrices");

            migrationBuilder.DropTable(
                name: "ParkingTimeFrame");

            migrationBuilder.DropIndex(
                name: "IX_Slots_ParkingPriceID",
                table: "Slots");

            migrationBuilder.DropIndex(
                name: "IX_CarModels_ParkingPriceID",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "ParkingPriceID",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "ParkingPriceID",
                table: "CarModels");

            migrationBuilder.RenameColumn(
                name: "ParkingPriceID",
                table: "TimeFrame",
                newName: "ParkingsID");

            migrationBuilder.RenameIndex(
                name: "IX_TimeFrame_ParkingPriceID",
                table: "TimeFrame",
                newName: "IX_TimeFrame_ParkingsID");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "TimeFrame",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Slots",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<Guid>(
                name: "ParkingID",
                table: "Requests",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "CarModels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeFrame_Parkings_ParkingsID",
                table: "TimeFrame",
                column: "ParkingsID",
                principalTable: "Parkings",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeFrame_Parkings_ParkingsID",
                table: "TimeFrame");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "TimeFrame");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CarModels");

            migrationBuilder.RenameColumn(
                name: "ParkingsID",
                table: "TimeFrame",
                newName: "ParkingPriceID");

            migrationBuilder.RenameIndex(
                name: "IX_TimeFrame_ParkingsID",
                table: "TimeFrame",
                newName: "IX_TimeFrame_ParkingPriceID");

            migrationBuilder.AddColumn<Guid>(
                name: "ParkingPriceID",
                table: "Slots",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ParkingID",
                table: "Requests",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ParkingPriceID",
                table: "CarModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ParkingPrices",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifyByID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifyAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingPrices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ParkingPrices_Users_LastModifyByID",
                        column: x => x.LastModifyByID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

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
                name: "IX_Slots_ParkingPriceID",
                table: "Slots",
                column: "ParkingPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_ParkingPriceID",
                table: "CarModels",
                column: "ParkingPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingPrices_LastModifyByID",
                table: "ParkingPrices",
                column: "LastModifyByID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingTimeFrame_TimeFramesID",
                table: "ParkingTimeFrame",
                column: "TimeFramesID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_ParkingPrices_ParkingPriceID",
                table: "CarModels",
                column: "ParkingPriceID",
                principalTable: "ParkingPrices",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_ParkingPrices_ParkingPriceID",
                table: "Slots",
                column: "ParkingPriceID",
                principalTable: "ParkingPrices",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeFrame_ParkingPrices_ParkingPriceID",
                table: "TimeFrame",
                column: "ParkingPriceID",
                principalTable: "ParkingPrices",
                principalColumn: "ID");
        }
    }
}
