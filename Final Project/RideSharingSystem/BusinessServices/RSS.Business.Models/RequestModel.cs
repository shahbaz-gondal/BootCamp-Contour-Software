using System.ComponentModel.DataAnnotations;

namespace RSS.Business.Models
{
    public class RequestModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FromCity { get; set; } = string.Empty;
        [Required]
        public string ToCity { get; set; } = string.Empty;
        [Required]
        public DateTime DepartureDateTime { get; set; }
    }
}