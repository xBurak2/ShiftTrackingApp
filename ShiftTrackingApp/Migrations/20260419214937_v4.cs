using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftTrackingApp.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "#f59e0b");

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "#4f6ef7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "HireDate", "PasswordHash", "Position" },
                values: new object[] { new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$wBTf352uLhJANFFVjPxoz.LUSJ8NItFlVPmbtZBMYO6c5K1E9pL4G", "İK Müdürü" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "HireDate", "PasswordHash", "Position" },
                values: new object[] { new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$NILxwMq380IEPJusn5v7A.aa2zIIZlOUy3aHfohUhVtG93iTZVeGm", "Yazılım Geliştirici" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "#f5a623");

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "#4f7eff");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "HireDate", "PasswordHash", "Position" },
                values: new object[] { new DateTime(2026, 4, 19, 18, 58, 39, 334, DateTimeKind.Utc).AddTicks(6060), null, "$2a$11$xJ2X7osfeEuJ9tTnxrDV1ukJk.CYY/vzSo9CrVyFsC3AqCOZdGdES", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "HireDate", "PasswordHash", "Position" },
                values: new object[] { new DateTime(2026, 4, 19, 18, 58, 39, 467, DateTimeKind.Utc).AddTicks(4315), null, "$2a$11$92K7hEC8gWcR0qaAwQWSPu9WMBZjVN9k33sdiJxh.vxQ5KZ0xZqfm", null });
        }
    }
}
