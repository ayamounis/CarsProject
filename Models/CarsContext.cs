using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace CarsProject.Models
{
    public class CarsContext : IdentityDbContext<User>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        public CarsContext() : base()
        {
        }
        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=AYA\\SQLEXPRESS;Initial Catalog=MVC_CarsProj;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
        //Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Seed Car  ..
            modelBuilder.Entity<Car>().HasData(
                                       new Car { Id = 1, Name = "Toyota Corolla 2022", Description = "Reliable and efficient sedan.", ImageUrl = "https://images.unsplash.com/photo-1621007947382-bb3c3994e3fb?w=500&q=80", Price = 22000, Condition = "New", Status = "Available", Color = "White", Transmission = "Automatic", CategoryId = 1 },
new Car { Id = 2, Name = "Ford Mustang 2021", Description = "Classic American muscle car.", ImageUrl = "https://images.unsplash.com/photo-1584345604476-8ec5e12e42dd?w=500&q=80", Price = 35000, Condition = "Used", Status = "Available", Color = "Red", Transmission = "Manual", CategoryId = 2 },
new Car { Id = 3, Name = "Honda Civic 2020", Description = "Compact car with great value.", ImageUrl = "https://images.unsplash.com/photo-1606664515524-ed2f786a0bd6?w=500&q=80", Price = 19000, Condition = "Used", Status = "Sold", Color = "Blue", Transmission = "Automatic", CategoryId = 3 },
new Car { Id = 4, Name = "BMW 3 Series 2019", Description = "Luxury and performance combined.", ImageUrl = "https://images.unsplash.com/photo-1555215695-3004980ad54e?w=500&q=80", Price = 28000, Condition = "Used", Status = "Available", Color = "Black", Transmission = "Automatic", CategoryId = 4 },
new Car { Id = 5, Name = "Mercedes C-Class 2023", Description = "Elegant and high-tech sedan.", ImageUrl = "https://images.unsplash.com/photo-1618843479313-40f8afb4b4d8?w=500&q=80", Price = 40000, Condition = "New", Status = "Available", Color = "Silver", Transmission = "Automatic", CategoryId = 5 },
new Car { Id = 6, Name = "Chevrolet Camaro 2021", Description = "Sporty and stylish ride.", ImageUrl = "https://images.unsplash.com/photo-1552519507-da3b142c6e3d?w=500&q=80", Price = 33000, Condition = "Used", Status = "Available", Color = "Yellow", Transmission = "Manual", CategoryId = 1 },
new Car { Id = 7, Name = "Tesla Model 3 2022", Description = "Electric sedan with autopilot.", ImageUrl = "https://images.unsplash.com/photo-1560958089-b8a1929cea89?w=500&q=80", Price = 45000, Condition = "New", Status = "Available", Color = "White", Transmission = "Automatic", CategoryId = 2 },
new Car { Id = 8, Name = "Volkswagen Golf 2020", Description = "Compact hatchback with agility.", ImageUrl = "https://images.unsplash.com/photo-1606016838648-b8e527f7daf8?w=500&q=80", Price = 20000, Condition = "Used", Status = "Sold", Color = "Green", Transmission = "Manual", CategoryId = 3 },
new Car { Id = 9, Name = "Nissan Altima 2021", Description = "Reliable midsize family sedan.", ImageUrl = "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80", Price = 23000, Condition = "New", Status = "Available", Color = "Blue", Transmission = "Automatic", CategoryId = 4 },
new Car { Id = 10, Name = "Hyundai Elantra 2019", Description = "Affordable and efficient.", ImageUrl = "https://images.unsplash.com/photo-1619767886558-efdc259cde1a?w=500&q=80", Price = 17000, Condition = "Used", Status = "Sold", Color = "Grey", Transmission = "Manual", CategoryId = 5 },

new Car { Id = 11, Name = "Kia Forte 2022", Description = "Stylish and compact.", ImageUrl = "https://images.unsplash.com/photo-1609521263047-f8f205293f24?w=500&q=80", Price = 18500, Condition = "New", Status = "Available", Color = "Black", Transmission = "Automatic", CategoryId = 1 },
new Car { Id = 12, Name = "Mazda 3 2021", Description = "Fun to drive compact car.", ImageUrl = "https://images.unsplash.com/photo-1583121274602-3e2820c69888?w=500&q=80", Price = 21000, Condition = "Used", Status = "Available", Color = "Red", Transmission = "Manual", CategoryId = 2 },
new Car { Id = 13, Name = "Toyota Camry 2020", Description = "Spacious and dependable.", ImageUrl = "https://images.unsplash.com/photo-1621007947382-bb3c3994e3fb?w=500&q=80", Price = 25000, Condition = "Used", Status = "Available", Color = "White", Transmission = "Automatic", CategoryId = 3 },
new Car { Id = 14, Name = "Audi A4 2023", Description = "Premium interior and design.", ImageUrl = "https://tse2.mm.bing.net/th/id/OIP.ohiuKuqks-SiNrOWW32xPAHaEY?rs=1&pid=ImgDetMain&o=7&rm=3", Price = 39000, Condition = "New", Status = "Available", Color = "Silver", Transmission = "Automatic", CategoryId = 4 },
new Car { Id = 15, Name = "Skoda Octavia 2021", Description = "Efficient family car.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 24000, Condition = "Used", Status = "Sold", Color = "Blue", Transmission = "Manual", CategoryId = 5 },

new Car { Id = 16, Name = "Seat Leon 2022", Description = "Sporty and agile hatchback.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 23000, Condition = "New", Status = "Available", Color = "Red", Transmission = "Automatic", CategoryId = 1 },
new Car { Id = 17, Name = "Opel Astra 2021", Description = "Reliable and spacious.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 21000, Condition = "Used", Status = "Available", Color = "Grey", Transmission = "Manual", CategoryId = 2 },
new Car { Id = 18, Name = "Peugeot 3008 2023", Description = "Stylish compact SUV.", ImageUrl = "https://images.unsplash.com/photo-1549317661-bd32c8ce0db2?w=500&q=80", Price = 32000, Condition = "New", Status = "Available", Color = "White", Transmission = "Automatic", CategoryId = 3 },
new Car { Id = 19, Name = "Renault Megane 2020", Description = "Affordable hatchback.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 18000, Condition = "Used", Status = "Sold", Color = "Black", Transmission = "Manual", CategoryId = 4 },
new Car { Id = 20, Name = "Volvo S60 2022", Description = "Safe and elegant sedan.", ImageUrl = "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80", Price = 37000, Condition = "New", Status = "Available", Color = "Silver", Transmission = "Automatic", CategoryId = 5 },
new Car { Id = 21, Name = "Citroen C4 2016", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 23300, Condition = "Used", Status = "Sold", Color = "Grey", Transmission = "Manual", CategoryId = 2 },
new Car { Id = 22, Name = "Jeep Grand Cherokee 2017", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80", Price = 23600, Condition = "New", Status = "Available", Color = "Green", Transmission = "Automatic", CategoryId = 3 },
new Car { Id = 23, Name = "Land Rover Discovery 2018", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80", Price = 23900, Condition = "Used", Status = "Sold", Color = "Yellow", Transmission = "Manual", CategoryId = 4 },
new Car { Id = 24, Name = "Fiat Tipo 2019", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 24200, Condition = "New", Status = "Available", Color = "Red", Transmission = "Automatic", CategoryId = 5 },
new Car { Id = 25, Name = "Mini Cooper 2020", Description = "High quality vehicle.", ImageUrl = "https://cdn.motor1.com/images/mgl/JOA6zK/s1/mini-john-cooper-works-electric-2024.jpg", Price = 24500, Condition = "Used", Status = "Sold", Color = "Blue", Transmission = "Manual", CategoryId = 1 },
new Car { Id = 26, Name = "Porsche Cayenne 2021", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80", Price = 24800, Condition = "New", Status = "Available", Color = "Black", Transmission = "Automatic", CategoryId = 2 },
new Car { Id = 27, Name = "Jaguar XE 2022", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1555215695-3004980ad54e?w=500&q=80", Price = 25100, Condition = "Used", Status = "Sold", Color = "White", Transmission = "Manual", CategoryId = 3 },
new Car { Id = 28, Name = "Ford Explorer 2023", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80", Price = 25400, Condition = "New", Status = "Available", Color = "Silver", Transmission = "Automatic", CategoryId = 4 },
new Car { Id = 29, Name = "Chevy Tahoe 2024", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1544636331-e26879cd4d9b?w=500&q=80", Price = 25700, Condition = "Used", Status = "Sold", Color = "Grey", Transmission = "Manual", CategoryId = 5 },
new Car { Id = 30, Name = "Toyota Corolla 2015", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1621007947382-bb3c3994e3fb?w=500&q=80", Price = 26000, Condition = "New", Status = "Available", Color = "Green", Transmission = "Automatic", CategoryId = 1 },

new Car { Id = 31, Name = "Ford Mustang 2016", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1584345604476-8ec5e12e42dd?w=500&q=80", Price = 26300, Condition = "Used", Status = "Sold", Color = "Yellow", Transmission = "Manual", CategoryId = 2 },
new Car { Id = 32, Name = "Honda Civic 2017", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1606664515524-ed2f786a0bd6?w=500&q=80", Price = 26600, Condition = "New", Status = "Available", Color = "Red", Transmission = "Automatic", CategoryId = 3 },
new Car { Id = 33, Name = "BMW 3 Series 2018", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1555215695-3004980ad54e?w=500&q=80", Price = 26900, Condition = "Used", Status = "Sold", Color = "Blue", Transmission = "Manual", CategoryId = 4 },
new Car { Id = 34, Name = "Mercedes C-Class 2019", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1618843479313-40f8afb4b4d8?w=500&q=80", Price = 27200, Condition = "New", Status = "Available", Color = "Black", Transmission = "Automatic", CategoryId = 5 },
new Car { Id = 35, Name = "Chevrolet Camaro 2020", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1552519507-da3b142c6e3d?w=500&q=80", Price = 27500, Condition = "Used", Status = "Sold", Color = "White", Transmission = "Manual", CategoryId = 1 },
new Car { Id = 36, Name = "Tesla Model 3 2021", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1560958089-b8a1929cea89?w=500&q=80", Price = 27800, Condition = "New", Status = "Available", Color = "Silver", Transmission = "Automatic", CategoryId = 2 },
new Car { Id = 37, Name = "Volkswagen Golf 2022", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1606016838648-b8e527f7daf8?w=500&q=80", Price = 28100, Condition = "Used", Status = "Sold", Color = "Grey", Transmission = "Manual", CategoryId = 3 },
new Car { Id = 38, Name = "Nissan Altima 2023", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80", Price = 28400, Condition = "New", Status = "Available", Color = "Green", Transmission = "Automatic", CategoryId = 4 },
new Car { Id = 39, Name = "Hyundai Elantra 2024", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1619767886558-efdc259cde1a?w=500&q=80", Price = 28700, Condition = "Used", Status = "Sold", Color = "Yellow", Transmission = "Manual", CategoryId = 5 },
new Car { Id = 40, Name = "Kia Forte 2015", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1609521263047-f8f205293f24?w=500&q=80", Price = 29000, Condition = "New", Status = "Available", Color = "Red", Transmission = "Automatic", CategoryId = 1 },

new Car { Id = 41, Name = "Mazda 3 2016", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1583121274602-3e2820c69888?w=500&q=80", Price = 29300, Condition = "Used", Status = "Sold", Color = "Blue", Transmission = "Manual", CategoryId = 2 },
new Car { Id = 42, Name = "Toyota Camry 2017", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1621007947382-bb3c3994e3fb?w=500&q=80", Price = 29600, Condition = "New", Status = "Available", Color = "Black", Transmission = "Automatic", CategoryId = 3 },
new Car { Id = 43, Name = "Audi A4 2018", Description = "High quality vehicle.", ImageUrl = "https://tse2.mm.bing.net/th/id/OIP.pPz82J8frXVoAwOZ58aHsgHaEK?rs=1&pid=ImgDetMain&o=7&rm=3", Price = 29900, Condition = "Used", Status = "Sold", Color = "White", Transmission = "Manual", CategoryId = 4 },
new Car { Id = 44, Name = "Skoda Octavia 2019", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 30200, Condition = "New", Status = "Available", Color = "Silver", Transmission = "Automatic", CategoryId = 5 },
new Car { Id = 45, Name = "Seat Leon 2020", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 30500, Condition = "Used", Status = "Sold", Color = "Grey", Transmission = "Manual", CategoryId = 1 },
new Car { Id = 46, Name = "Opel Astra 2021", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 30800, Condition = "New", Status = "Available", Color = "Green", Transmission = "Automatic", CategoryId = 2 },
new Car { Id = 47, Name = "Peugeot 3008 2022", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1549317661-bd32c8ce0db2?w=500&q=80", Price = 31100, Condition = "Used", Status = "Sold", Color = "Yellow", Transmission = "Manual", CategoryId = 3 },
new Car { Id = 48, Name = "Renault Megane 2023", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1600712242805-5f78671b24da?w=500&q=80", Price = 31400, Condition = "New", Status = "Available", Color = "Red", Transmission = "Automatic", CategoryId = 4 },
new Car { Id = 49, Name = "Volvo S60 2024", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1605559424843-9e4c228bf1c2?w=500&q=80", Price = 31700, Condition = "Used", Status = "Sold", Color = "Blue", Transmission = "Manual", CategoryId = 5 },
new Car { Id = 50, Name = "Peugeot 508 2015", Description = "High quality vehicle.", ImageUrl = "https://images.unsplash.com/photo-1549317661-bd32c8ce0db2?w=500&q=80", Price = 32000, Condition = "New", Status = "Available", Color = "Black", Transmission = "Automatic", CategoryId = 1 }

               );
            #endregion

            #region Seed Category
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sedan" },
                new Category { Id = 2, Name = "SUV" },
                new Category { Id = 3, Name = "Hatchback" },
                new Category { Id = 4, Name = "Luxury" },
                new Category { Id = 5, Name = "Sports" }
            );
            #endregion

            #region Seed User
            //modelBuilder.Entity<User>().HasData(
            //    new User { Id = 1, UserName = "admin", Password = "admin123", Email = "admin@example.com" },
            //    new User { Id = 2, UserName = "aya", Password = "aya123", Email = "aya@example.com" },
            //    new User { Id = 3, UserName = "mohamed", Password = "mohe123", Email = "mohamed@example.com" }
            //);
            #endregion

            #region Seed Review
            //modelBuilder.Entity<Review>().HasData(
            //    new Review { Id = 1, Content = "Great car!", Rating = 5, CarId = 1, UserId = 2 },
            //    new Review { Id = 2, Content = "Smooth ride", Rating = 4, CarId = 2, UserId = 3 },
            //    new Review { Id = 3, Content = "Worth the price", Rating = 4, CarId = 3, UserId = 1 }
            //);
            #endregion

            #region Seed Order
            //modelBuilder.Entity<Order>().HasData(
            //    new Order { Id = 1, OrderDate = new DateTime(2025, 6, 1), UserId = 2 },
            //    new Order { Id = 2, OrderDate = new DateTime(2025, 6, 10), UserId = 3 }
            //);
            #endregion

            #region Seed OrderItem
            //modelBuilder.Entity<OrderItem>().HasData(
            //    new OrderItem { Id = 1, OrderId = 1, CarId = 5, Quantity = 1, Price = 30000 },
            //    new OrderItem { Id = 2, OrderId = 1, CarId = 10, Quantity = 2, Price = 17000 },
            //    new OrderItem { Id = 3, OrderId = 2, CarId = 20, Quantity = 1, Price = 37000 }
            //);
            #endregion

            #region Seed CartItem
            //modelBuilder.Entity<CartItem>().HasData(
            //    new CartItem { Id = 1, CarId = 4, UserId = 2, Quantity = 1 },
            //    new CartItem { Id = 2, CarId = 15, UserId = 3, Quantity = 2 }
            //);
            #endregion


        }
    }
}
