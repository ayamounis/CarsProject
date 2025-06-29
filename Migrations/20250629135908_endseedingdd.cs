using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsProject.Migrations
{
    /// <inheritdoc />
    public partial class endseedingdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://cdn.motor1.com/images/mgl/JOA6zK/s1/mini-john-cooper-works-electric-2024.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1506905925346-21bda4d32df4?w=500&q=80");
        }
    }
}
