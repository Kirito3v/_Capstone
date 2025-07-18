using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduationProj.Models
{

    [Table("Carts")]
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
            = new List<CartItem>();

        [Required]
        public int UserItemsId { get; set; }

        [ForeignKey(nameof(UserItemsId))]
        public virtual UserItems? UserItems { get; set; }
    }
}
