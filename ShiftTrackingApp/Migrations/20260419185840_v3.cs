using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftTrackingApp.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoBase64",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "ShiftAssignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasMedicalReport",
                table: "LeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "HireDate", "PasswordHash", "PhoneNumber", "PhotoBase64", "Position" },
                values: new object[] { new DateTime(2026, 4, 19, 18, 58, 39, 334, DateTimeKind.Utc).AddTicks(6060), null, "$2a$11$xJ2X7osfeEuJ9tTnxrDV1ukJk.CYY/vzSo9CrVyFsC3AqCOZdGdES", null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "HireDate", "PasswordHash", "PhoneNumber", "PhotoBase64", "Position" },
                values: new object[] { new DateTime(2026, 4, 19, 18, 58, 39, 467, DateTimeKind.Utc).AddTicks(4315), null, "$2a$11$92K7hEC8gWcR0qaAwQWSPu9WMBZjVN9k33sdiJxh.vxQ5KZ0xZqfm", null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhotoBase64",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "ShiftAssignments");

            migrationBuilder.DropColumn(
                name: "HasMedicalReport",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 3, 18, 18, 50, 4, 580, DateTimeKind.Utc).AddTicks(5144), "$2a$11$zA.WUMKNHIIyNijAIVHVMuCItuGqT4OrnLZuaJya/dylXTZBLNdW2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 3, 18, 18, 50, 4, 714, DateTimeKind.Utc).AddTicks(3366), "$2a$11$.TbAlcPJzB4z9VOBN8uOCuBvjeIXH9ovFXK7Q26BFD1yqVD8MrGLG" });
        }
    }
}
