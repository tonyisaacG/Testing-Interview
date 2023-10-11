using System.ComponentModel.DataAnnotations;

namespace Core.Entitys.identity
{
    public class TokenRequestModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}