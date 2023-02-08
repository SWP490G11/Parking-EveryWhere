using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Roles_NameID",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_NameID",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "NameID",
                table: "Roles");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "Roles");

            migrationBuilder.AddColumn<Guid>(
                name: "NameID",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Roles_NameID",
                table: "Roles",
                column: "NameID");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Roles_NameID",
                table: "Roles",
                column: "NameID",
                principalTable: "Roles",
                principalColumn: "ID");
        }
    }
}
