using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 4, ErrorMessage = "Must Specify password")]
        public string Password { get; set; }
    }
}