using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace GraduationProj.Models
{
    [Table("ProductsDetails")]
    public class ProductDetails
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public string Details { get; set; } = string.Empty;
        public string[] ImagePaths { get; set; } = Array.Empty<string>();

        public virtual IList<Product> RelatedProducts { get; set; } = new List<Product>();

        public virtual IList<ProductTrait> Traits { get; set; } = new List<ProductTrait>();
        // Foreign key
        public int ProductId { get; set; }

        // Navigation property (1-to-1)
        public virtual Product product { get; set; } = new Product();
    }
}
