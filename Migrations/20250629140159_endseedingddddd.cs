using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsProject.Migrations
{
    /// <inheritdoc />
    public partial class endseedingddddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://tse2.mm.bing.net/th/id/OIP.ohiuKuqks-SiNrOWW32xPAHaEY?rs=1&pid=ImgDetMain&o=7&rm=3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606220945770-b5b6c2c55bf1?w=500&q=80");
        }
    }
}
