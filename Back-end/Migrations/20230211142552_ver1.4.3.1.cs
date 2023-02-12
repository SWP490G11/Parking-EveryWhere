using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ver1431 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a4a94882-fbae-430a-a649-424e2a8e225c"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "DateOfBirth", "FirstName", "Gender", "HashPasword", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("4ed83d2b-8482-4a29-b1ec-dfa568e63bde"), new DateTime(2000, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duy", 0, "$2b$10$w4S73i0JCV157iepOOrPKeS31E0jFPuTeO56ltq8GFO0G2c.MGCDm", new DateTime(2023, 2, 11, 21, 25, 52, 84, DateTimeKind.Local).AddTicks(1893), "Phung Nam", null, null, "0945454587", 0, "duypn" },
                    { new Guid("ab6de029-f760-4099-8296-37fd7b3c2b6b"), new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phuc", 0, "$2b$10$SN0Axy2LTcHVHmWrl6BRn.J0Plj092pWemt..ItvMtjua8XnMGibi", new DateTime(2023, 2, 11, 21, 25, 52, 9, DateTimeKind.Local).AddTicks(8503), "Nguyen Van", null, null, "0966416708", 0, "phucnv" },
                    { new Guid("e7f8fe74-ae77-48a2-8b31-a39d5d642279"), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phong", 0, "$2b$10$zbi2FWhtzgo4YyuTtulwBeQyt/Dw.ikDuw2GdlOkmTvuRmltSUlii", new DateTime(2023, 2, 11, 21, 25, 52, 153, DateTimeKind.Local).AddTicks(437), "Dao Tuan", null, null, "0832323201", 0, "phongdt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4ed83d2b-8482-4a29-b1ec-dfa568e63bde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab6de029-f760-4099-8296-37fd7b3c2b6b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e7f8fe74-ae77-48a2-8b31-a39d5d642279"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "DateOfBirth", "FirstName", "Gender", "HashPasword", "LastModifyAt", "LastName", "MembershipPackageID", "ParkingID", "PhoneNumber", "Role", "UserName" },
                values: new object[] { new Guid("a4a94882-fbae-430a-a649-424e2a8e225c"), new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phuc", 0, "$2b$10$QWSR9sJPc6KMUOlNL3OYsO32wqVFULwHh0FUU0yZNsMiSJh9lSMK6", new DateTime(2023, 2, 11, 21, 8, 35, 968, DateTimeKind.Local).AddTicks(5152), "Nguyen Van", null, null, "0966416708", 0, "phucnv" });
        }
    }
}
