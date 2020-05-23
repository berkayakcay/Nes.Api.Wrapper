using System.ComponentModel.DataAnnotations;

namespace Nes.Api.Wrapper.Legacy.Mvc.Models
{
    public class TokenViewModel
    {
        [Required]
        public string Mail { get; set; }

        [Required]
        public string Password { get; set; }

        public string Token { get; set; }
    }
}