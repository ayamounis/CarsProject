using System.ComponentModel.DataAnnotations.Schema;

namespace CarsProject.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car? Car { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
