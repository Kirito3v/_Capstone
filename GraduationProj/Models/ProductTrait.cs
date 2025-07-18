using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace GraduationProj.Models
{
    [Table("ProductTraits")]
    public class ProductTrait
    {

        [Key]
        public int Id { get; set; }
        [NotNull]
        public string TraitName { get; set; } = string.Empty;
        [NotNull]
        public string Description { get; set; } = string.Empty;

        public int ProductDetailsId { get; set; }
        public ProductDetails? Details { get; set; }

    }
}
