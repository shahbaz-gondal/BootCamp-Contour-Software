using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS.Data.Models
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FromCity { get; set; } = string.Empty;
        [Required]
        public string ToCity { get; set; } = string.Empty;
        [Required]
        public DateTime DepartureDateTime { get; set; }
        [Required]
        public int Cost { get; set; }
    }
}
