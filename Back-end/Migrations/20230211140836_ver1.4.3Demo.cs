using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver143Demo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("261a5004-4246-4a06-bc52-f08693f70638"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "DateOfBirth", "FirstName", "Gender", "HashPasword", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[] { new Guid("a4a94882-fbae-430a-a649-424e2a8e225c"), new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phuc", 0, "$2b$10$QWSR9sJPc6KMUOlNL3OYsO32wqVFULwHh0FUU0yZNsMiSJh9lSMK6", new DateTime(2023, 2, 11, 21, 8, 35, 968, DateTimeKind.Local).AddTicks(5152), "Nguyen Van", null, null, "0966416708", 0, "phucnv" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a4a94882-fbae-430a-a649-424e2a8e225c"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "DateOfBirth", "FirstName", "Gender", "HashPasword", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[] { new Guid("261a5004-4246-4a06-bc52-f08693f70638"), new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phuc", 0, "$2b$10$Z7PZKP7tFg8r5lP76UYxMeYNP0l2LiAAXq8xlKXD9m80H1NuA0A2u", new DateTime(2023, 2, 11, 21, 2, 3, 742, DateTimeKind.Local).AddTicks(3077), "Nguyen Van", null, null, "0966416708", 0, "phucnv" });
        }
    }
}
