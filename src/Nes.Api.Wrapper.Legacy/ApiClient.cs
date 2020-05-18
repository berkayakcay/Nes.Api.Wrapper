using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Domain.Login;

namespace Nes.Api.Wrapper.Legacy
{
    public class ApiClient
    {
        private readonly string _apiUrl;
        private readonly string _username;
        private readonly string _password;


        /// <summary>
        /// Bilgileri sağlayacağımız bir yönetici class yapabiliriz
        /// </summary>
        private string AccessToken { get; set; }

        private DateTime ExpireDate { get; set; }

        public ApiClient(string apiUrl, string username, string password)
        {
            _apiUrl = apiUrl;
            _username = username;
            _password = password;
        }

        public async Task<LoginResponse> Token()
        {
            using (var httpClient = new HttpClient())
            {
                var loginRequest = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", _username),
                    new KeyValuePair<string, string>("password", _password)
                };

                var httpRequestMessege = new HttpRequestMessage(HttpMethod.Post, $"{_apiUrl}/token")
                {
                    Content = new FormUrlEncodedContent(loginRequest)
                };

                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessege);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<LoginResponse>(content);

                AccessToken = model.access_token;
                ExpireDate = DateTime.Now.AddSeconds(model.expires_in ?? 0);

                return model;
            }

        }


        public AccountService Account => new AccountService(_apiUrl, AccessToken);

        public InvoiceGeneralService InvoiceGeneral => new InvoiceGeneralService(_apiUrl, AccessToken);

        public EArchiveService EArchive => new EArchiveService(_apiUrl, AccessToken);



        
    }
}