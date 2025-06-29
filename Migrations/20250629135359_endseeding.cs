using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsProject.Migrations
{
    /// <inheritdoc />
    public partial class endseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Transmission",
                table: "Cars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Cars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cars",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cars",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Condition",
                table: "Cars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Cars",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1621007947382-bb3c3994e3fb?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1584345604476-8ec5e12e42dd?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606664515524-ed2f786a0bd6?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1555215695-3004980ad54e?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1618843479313-40f8afb4b4d8?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1552519507-da3b142c6e3d?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1560958089-b8a1929cea89?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606016838648-b8e527f7daf8?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1619767886558-efdc259cde1a?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1609521263047-f8f205293f24?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1583121274602-3e2820c69888?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1621007947382-bb3c3994e3fb?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606220945770-b5b6c2c55bf1?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1549317661-bd32c8ce0db2?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1506905925346-21bda4d32df4?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1555215695-3004980ad54e?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1621007947382-bb3c3994e3fb?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1584345604476-8ec5e12e42dd?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606664515524-ed2f786a0bd6?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1555215695-3004980ad54e?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1618843479313-40f8afb4b4d8?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1552519507-da3b142c6e3d?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1560958089-b8a1929cea89?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606016838648-b8e527f7daf8?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1619767886558-efdc259cde1a?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1609521263047-f8f205293f24?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1583121274602-3e2820c69888?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1621007947382-bb3c3994e3fb?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1606220945770-b5b6c2c55bf1?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1549317661-bd32c8ce0db2?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1549317661-bd32c8ce0db2?w=500&q=80");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Transmission",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Condition",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg");
        }
    }
}
