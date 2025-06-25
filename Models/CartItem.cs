using System.ComponentModel.DataAnnotations.Schema;

namespace CarsProject.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car? Car { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User? User { get; set; }
        public int? Quantity { get; set; }
    }
}
