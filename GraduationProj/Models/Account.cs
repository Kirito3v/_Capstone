using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GraduationProj.Models
{
    [Table("Accounts")]
    public class Account
    {
        // Primary key (auto-increment)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [MaxLength(256)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string PasswordHash { get; set; } = string.Empty;

        // You might choose to store a created date, etc.
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

      
        public int UserItemsId { get; set; }

        [ForeignKey(nameof(UserItemsId))]
        public virtual UserItems? UserItems { get; set; }
    }
}
