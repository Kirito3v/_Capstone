using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduationProj.Models
{
    public class ShippingInfo
    {
        [Key]
        public int UserId { get; set; }
        public string Method { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }

        [NotMapped]
        public bool Added { get; set; }
    }
}
