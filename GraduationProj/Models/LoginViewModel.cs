using System.ComponentModel.DataAnnotations;

namespace GraduationProj.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6,
         ErrorMessage = "Password must be at least {2} characters long.")]
        public string Password { get; set; } = string.Empty;
    }
}