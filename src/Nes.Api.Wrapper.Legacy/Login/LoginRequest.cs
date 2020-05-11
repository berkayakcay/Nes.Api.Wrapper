namespace Nes.Api.Wrapper.Legacy.Domain.Login
{
    /// <summary>
    /// Request = İstek
    /// </summary>
    /// <example>
    ///{
    ///  "grant_type": "password",
    ///  "username": "USERNAME",
    ///  "password": "PASSWORD"
    ///}
    /// </example>
    public class LoginRequest
    {
        public string grant_type { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}