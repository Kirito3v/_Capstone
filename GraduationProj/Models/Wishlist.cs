using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraduationProj.Models
{
    public class Wishlist
    {
        [Key]
        public int Id { get; set; }

        public virtual ICollection<ProductWishlist> ProductWishlists { get; set; } = new List<ProductWishlist>();

        [Required]
        public int UserItemsId { get; set; }

        [ForeignKey(nameof(UserItemsId))]
        public virtual UserItems? UserItems { get; set; }
    }

}
