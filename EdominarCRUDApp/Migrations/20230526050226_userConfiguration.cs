using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EdominarCRUDApp.Migrations
{
    /// <inheritdoc />
    public partial class userConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "Gender", "HobbyId", "Mobile", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, "Chowrangi Road ", "das@gmail.com", 1, 4, "987456123", "Shubho Das", 28 },
                    { 2, "61/2 Chowrashta Road", "anushka@gmail.com", 0, 5, "9874466123", "Anushka Das", 29 }
                });
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
