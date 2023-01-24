using System.ComponentModel.DataAnnotations;

namespace Restaurent_Management_System.Models
{
    public class BookingModel
    {
        [Key]
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Menu { get; set; }
        public DateTime? BookingDate { get; set; }
        public string? Dishes { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
    }
}
