using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace GraduationProj.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; } = string.Empty;
        [NotNull]
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // Navigation property (1-to-1)
        public virtual ProductDetails? Details { get; set; }

    }
}
