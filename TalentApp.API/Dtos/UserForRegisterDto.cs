using System.ComponentModel.DataAnnotations;

namespace TalentApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(12, MinimumLength=6, ErrorMessage="You must enter a password between 6 to 12 characters.")]
        public string Password { get; set; }
    }
}