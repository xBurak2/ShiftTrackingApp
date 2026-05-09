using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftTrackingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddShiftSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "Name", "StartTime", "EndTime", "Color" },
                values: new object[,]
                {
                    { 4, "Tatil", new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0), "#ef4444" },
                    { 5, "İzinli", new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0), "#22c55e" },
                    { 6, "Part Time", new TimeSpan(8, 0, 0), new TimeSpan(12, 0, 0), "#14b8a6" },
                    { 7, "Sabah Fazla Mesai", new TimeSpan(16, 0, 0), new TimeSpan(18, 0, 0), "#f97316" },
                    { 8, "Öğleden Sonra Fazla Mesai", new TimeSpan(22, 0, 0), new TimeSpan(0, 0, 0), "#6366f1" },
                    { 9, "Gece Fazla Mesai", new TimeSpan(6, 0, 0), new TimeSpan(8, 0, 0), "#ec4899" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
