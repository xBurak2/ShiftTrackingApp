using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShiftTrackingApp.Migrations
{
    /// <inheritdoc />
    public partial class SetUserPasswords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "HireDate", "Position" },
                values: new object[] { "$2a$11$F.sfeiJJml3fxcIVJaCAd..dCqvOj4lxyYkU5G/ntppmqcz/49LGG", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İK Müdürü" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "HireDate", "Position" },
                values: new object[] { "$2a$11$M7vuZGpSlgLJF7JVBddg6uk5RHNb12QOPrvybvFot8o4N8bKJ.deq", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazılım Geliştirici" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
