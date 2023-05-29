using System.ComponentModel.DataAnnotations;

namespace BusinessParktenants.Models
{
    public class SignUp
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }

        [Compare("ConfirmPassward")]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassward { get; set; }

    }
}
