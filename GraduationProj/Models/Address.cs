using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraduationProj.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = string.Empty;
        [Required]
        public string StreetAdress { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string Country { get; set; } = string.Empty;
        [Required]
        public string PostalCode { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        [Required]
        public string AddressType { get; set; } = "Home";


        [Required]
        public int UserItemsId { get; set; }

        [ForeignKey(nameof(UserItemsId))]
        public virtual UserItems? UserItems { get; set; }


    }
}
