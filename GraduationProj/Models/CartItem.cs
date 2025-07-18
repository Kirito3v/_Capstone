    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduationProj.Models
{
    [Table("CartItems")]
    public class CartItem
    {

        [Key]
        public int Id { get; set; }

        // FK to Cart
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;

        // FK to Product
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public float Quantity { get; set; } = 1;
    }
}
