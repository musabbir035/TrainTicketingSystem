using System.ComponentModel.DataAnnotations;

namespace TrainTicketingSystem.App.Web.Models
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        [MaxLength(100, ErrorMessage = "Maximum password length can be 100 characters.")]
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        [Required(ErrorMessage = "Please enter your mobile number.")]
        [MinLength(11, ErrorMessage = "Invalid mobile number.")]
        [MaxLength(11, ErrorMessage = "Invalid mobile number.")]
        public string MobileNo { get; set; }
    }
}