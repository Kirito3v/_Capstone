using System.ComponentModel.DataAnnotations;

namespace GraduationProj.Models
{
    public class ProductWishlist
    {

        [Key]
        public int Id { get; set; }
        // Composite PK
        public int WishlistId { get; set; }
        public int ProductId { get; set; }

        // Navigation back to the principals
        public Wishlist Wishlist { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }

}
