using System.ComponentModel.DataAnnotations;

namespace RSS.Business.Models
{
    public class RequestModel
    {
        [Key]
        public int Id { get; set; }
        public string FromCity { get; set; } = string.Empty;
        public string ToCity { get; set; } = string.Empty;
        public DateTime DepartureDateTime { get; set; }
    }
}