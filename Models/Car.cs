
     using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsProject.Models
    {
        public class Car
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "Car name is required")]
            [StringLength(100, ErrorMessage = "Car name cannot exceed 100 characters")]
            [Display(Name = "Car Name")]
            public string Name { get; set; }

            [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
            [Display(Name = "Description")]
            public string? Description { get; set; }

            [Required(ErrorMessage = "Image URL is required")]
            [Url(ErrorMessage = "Please enter a valid URL")]
            [Display(Name = "Image URL")]
            public string ImageUrl { get; set; }

            [Required(ErrorMessage = "Price is required")]
            [Range(1, 10000000, ErrorMessage = "Price must be between $1 and $10,000,000")]
            [Display(Name = "Price ($)")]
            public int Price { get; set; }

            [StringLength(20, ErrorMessage = "Condition cannot exceed 20 characters")]
            [Display(Name = "Condition")]
            public string? Condition { get; set; } // New / Used

            [Required(ErrorMessage = "Status is required")]
            [StringLength(20, ErrorMessage = "Status cannot exceed 20 characters")]
            [Display(Name = "Status")]
            public string Status { get; set; } // Available / Sold

            [Required(ErrorMessage = "Color is required")]
            [StringLength(30, ErrorMessage = "Color cannot exceed 30 characters")]
            [Display(Name = "Color")]
            public string Color { get; set; } // Red, Blue, Black, etc.

            [StringLength(20, ErrorMessage = "Transmission cannot exceed 20 characters")]
            [Display(Name = "Transmission")]
            public string? Transmission { get; set; } // Automatic / Manual

            [Required(ErrorMessage = "Please select a category")]
            [Display(Name = "Category")]
            [ForeignKey("Category")]
            public int CategoryId { get; set; } // Foreign key for Category

            // Navigation properties
            public Category? Category { get; set; } // Navigation property for Category
            public List<Review>? Reviews { get; set; }
            public List<CartItem>? CartItems { get; set; }
            public List<OrderItem>? OrderItems { get; set; }
        }
    
}
