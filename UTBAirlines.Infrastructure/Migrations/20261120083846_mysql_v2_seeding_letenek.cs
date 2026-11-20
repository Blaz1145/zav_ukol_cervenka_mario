using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UTBAirlines.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mysql_v2_seeding_letenek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Letenky",
                columns: new[] { "Id", "Cena", "Destinace" },
                values: new object[,]
                {
                    { 1, 1500.0, "Praha" },
                    { 2, 3200.0, "Londýn" },
                    { 3, 15000.0, "New York" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Letenky",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Letenky",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Letenky",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
