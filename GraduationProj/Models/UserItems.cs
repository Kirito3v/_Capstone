using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduationProj.Models
{

    [Table("UserItems")]
    public class UserItems
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        public int AccountId { get; set; }

        [ForeignKey(nameof(AccountId))]
        public virtual Account? Account { get; set; }

        [Required]
        public int CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public virtual Cart? Cart { get; set; }

        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public virtual Address? Address { get; set; }

        [Required]
        public int WishlistId { get; set; }

        [ForeignKey(nameof(WishlistId))]
        public virtual Wishlist? Wishlist { get; set; }
    }
}

