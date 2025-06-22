using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarsProject.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sedan" },
                    { 2, "SUV" },
                    { 3, "Hatchback" },
                    { 4, "Luxury" },
                    { 5, "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "admin@example.com", "admin123", "admin" },
                    { 2, "aya@example.com", "aya123", "aya" },
                    { 3, "mohamed@example.com", "mohe123", "mohamed" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "Condition", "Description", "ImageUrl", "Name", "Price", "Status", "Transmission" },
                values: new object[,]
                {
                    { 1, 1, "White", "New", "Reliable and efficient sedan.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Toyota Corolla 2022", 22000, "Available", "Automatic" },
                    { 2, 2, "Red", "Used", "Classic American muscle car.", "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg", "Ford Mustang 2021", 35000, "Available", "Manual" },
                    { 3, 3, "Blue", "Used", "Compact car with great value.", "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg", "Honda Civic 2020", 19000, "Sold", "Automatic" },
                    { 4, 4, "Black", "Used", "Luxury and performance combined.", "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg", "BMW 3 Series 2019", 28000, "Available", "Automatic" },
                    { 5, 5, "Silver", "New", "Elegant and high-tech sedan.", "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg", "Mercedes C-Class 2023", 40000, "Available", "Automatic" },
                    { 6, 1, "Yellow", "Used", "Sporty and stylish ride.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Chevrolet Camaro 2021", 33000, "Available", "Manual" },
                    { 7, 2, "White", "New", "Electric sedan with autopilot.", "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg", "Tesla Model 3 2022", 45000, "Available", "Automatic" },
                    { 8, 3, "Green", "Used", "Compact hatchback with agility.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Volkswagen Golf 2020", 20000, "Sold", "Manual" },
                    { 9, 4, "Blue", "New", "Reliable midsize family sedan.", "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg", "Nissan Altima 2021", 23000, "Available", "Automatic" },
                    { 10, 5, "Grey", "Used", "Affordable and efficient.", "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg", "Hyundai Elantra 2019", 17000, "Sold", "Manual" },
                    { 11, 1, "Black", "New", "Stylish and compact.", "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg", "Kia Forte 2022", 18500, "Available", "Automatic" },
                    { 12, 2, "Red", "Used", "Fun to drive compact car.", "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg", "Mazda 3 2021", 21000, "Available", "Manual" },
                    { 13, 3, "White", "Used", "Spacious and dependable.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Toyota Camry 2020", 25000, "Available", "Automatic" },
                    { 14, 4, "Silver", "New", "Premium interior and design.", "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg", "Audi A4 2023", 39000, "Available", "Automatic" },
                    { 15, 5, "Blue", "Used", "Efficient family car.", "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg", "Skoda Octavia 2021", 24000, "Sold", "Manual" },
                    { 16, 1, "Red", "New", "Sporty and agile hatchback.", "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg", "Seat Leon 2022", 23000, "Available", "Automatic" },
                    { 17, 2, "Grey", "Used", "Reliable and spacious.", "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg", "Opel Astra 2021", 21000, "Available", "Manual" },
                    { 18, 3, "White", "New", "Stylish compact SUV.", "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg", "Peugeot 3008 2023", 32000, "Available", "Automatic" },
                    { 19, 4, "Black", "Used", "Affordable hatchback.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Renault Megane 2020", 18000, "Sold", "Manual" },
                    { 20, 5, "Silver", "New", "Safe and elegant sedan.", "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg", "Volvo S60 2022", 37000, "Available", "Automatic" },
                    { 21, 2, "Grey", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg", "Citroen C4 2016", 23300, "Sold", "Manual" },
                    { 22, 3, "Green", "New", "High quality vehicle.", "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg", "Jeep Grand Cherokee 2017", 23600, "Available", "Automatic" },
                    { 23, 4, "Yellow", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg", "Land Rover Discovery 2018", 23900, "Sold", "Manual" },
                    { 24, 5, "Red", "New", "High quality vehicle.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Fiat Tipo 2019", 24200, "Available", "Automatic" },
                    { 25, 1, "Blue", "Used", "High quality vehicle.", "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg", "Mini Cooper 2020", 24500, "Sold", "Manual" },
                    { 26, 2, "Black", "New", "High quality vehicle.", "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg", "Porsche Cayenne 2021", 24800, "Available", "Automatic" },
                    { 27, 3, "White", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg", "Jaguar XE 2022", 25100, "Sold", "Manual" },
                    { 28, 4, "Silver", "New", "High quality vehicle.", "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg", "Ford Explorer 2023", 25400, "Available", "Automatic" },
                    { 29, 5, "Grey", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg", "Chevy Tahoe 2024", 25700, "Sold", "Manual" },
                    { 30, 1, "Green", "New", "High quality vehicle.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Toyota Corolla 2015", 26000, "Available", "Automatic" },
                    { 31, 2, "Yellow", "Used", "High quality vehicle.", "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg", "Ford Mustang 2016", 26300, "Sold", "Manual" },
                    { 32, 3, "Red", "New", "High quality vehicle.", "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg", "Honda Civic 2017", 26600, "Available", "Automatic" },
                    { 33, 4, "Blue", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg", "BMW 3 Series 2018", 26900, "Sold", "Manual" },
                    { 34, 5, "Black", "New", "High quality vehicle.", "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg", "Mercedes C-Class 2019", 27200, "Available", "Automatic" },
                    { 35, 1, "White", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg", "Chevrolet Camaro 2020", 27500, "Sold", "Manual" },
                    { 36, 2, "Silver", "New", "High quality vehicle.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Tesla Model 3 2021", 27800, "Available", "Automatic" },
                    { 37, 3, "Grey", "Used", "High quality vehicle.", "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg", "Volkswagen Golf 2022", 28100, "Sold", "Manual" },
                    { 38, 4, "Green", "New", "High quality vehicle.", "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg", "Nissan Altima 2023", 28400, "Available", "Automatic" },
                    { 39, 5, "Yellow", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg", "Hyundai Elantra 2024", 28700, "Sold", "Manual" },
                    { 40, 1, "Red", "New", "High quality vehicle.", "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg", "Kia Forte 2015", 29000, "Available", "Automatic" },
                    { 41, 2, "Blue", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg", "Mazda 3 2016", 29300, "Sold", "Manual" },
                    { 42, 3, "Black", "New", "High quality vehicle.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Toyota Camry 2017", 29600, "Available", "Automatic" },
                    { 43, 4, "White", "Used", "High quality vehicle.", "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg", "Audi A4 2018", 29900, "Sold", "Manual" },
                    { 44, 5, "Silver", "New", "High quality vehicle.", "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg", "Skoda Octavia 2019", 30200, "Available", "Automatic" },
                    { 45, 1, "Grey", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1007415/pexels-photo-1007415.jpeg", "Seat Leon 2020", 30500, "Sold", "Manual" },
                    { 46, 2, "Green", "New", "High quality vehicle.", "https://images.pexels.com/photos/112460/pexels-photo-112460.jpeg", "Opel Astra 2021", 30800, "Available", "Automatic" },
                    { 47, 3, "Yellow", "Used", "High quality vehicle.", "https://images.pexels.com/photos/1402788/pexels-photo-1402788.jpeg", "Peugeot 3008 2022", 31100, "Sold", "Manual" },
                    { 48, 4, "Red", "New", "High quality vehicle.", "https://images.pexels.com/photos/358070/pexels-photo-358070.jpeg", "Renault Megane 2023", 31400, "Available", "Automatic" },
                    { 49, 5, "Blue", "Used", "High quality vehicle.", "https://images.pexels.com/photos/210019/pexels-photo-210019.jpeg", "Volvo S60 2024", 31700, "Sold", "Manual" },
                    { 50, 1, "Black", "New", "High quality vehicle.", "https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg", "Peugeot 508 2015", 32000, "Available", "Automatic" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 2, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "Id", "CarId", "Quantity", "UserId" },
                values: new object[,]
                {
                    { 1, 4, 1, 2 },
                    { 2, 15, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CarId", "OrderId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 5, 1, 30000, 1 },
                    { 2, 10, 1, 17000, 2 },
                    { 3, 20, 2, 37000, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CarId", "Content", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Great car!", 5, 2 },
                    { 2, 2, "Smooth ride", 4, 3 },
                    { 3, 3, "Worth the price", 4, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
