namespace Nes.Api.Wrapper.Legacy.Models
{
    public class LoginResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int? expires_in { get; set; }
        public string error { get; set; }
    }
}