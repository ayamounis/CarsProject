using System.ComponentModel.DataAnnotations.Schema;

namespace CarsProject.Models
{
    public class Car
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String? Description { get; set; }
        public String ImageUrl { get; set; }
        public int Price { get; set; }
        public string? Condition { get; set; } // New / Used
        public string Status { get; set; } // Available / Sold
        public string Color { get; set; } // Red, Blue, Black, etc.
        public string? Transmission { get; set; } // Automatic / Manual
        /// <summary>
        /// </summary>
        [ForeignKey("Category")]
        public int CategoryId { get; set; } // Foreign key for Category
        //navigation properties
        public Category Category { get; set; } // Navigation property for Category

        public List<Review>? Reviews { get; set; }
        public List<CartItem>? CartItems { get; set; }
        public List<OrderItem>? OrderItems { get; set; }


    }
}
