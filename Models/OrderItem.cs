using System.ComponentModel.DataAnnotations.Schema;

namespace CarsProject.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int? Quantity { get; set; }
        public int Price { get; set; }
    }
}
