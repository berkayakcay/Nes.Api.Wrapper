using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Domain;
using Nes.Api.Wrapper.Legacy.Domain.Account;
using Nes.Api.Wrapper.Legacy.Domain.Login;

namespace Nes.Api.Wrapper.Legacy
{
    public class ApiClient
    {
        public const string ApiUrl = "http://apitest.nesbilgi.com.tr";

        private readonly string _username;
        private readonly string _password;
        public string AccessToken { get; set; } = "";
        public DateTime ExpireDate { get; set; }

        public ApiClient(string username, string password)
        {
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

                var httpRequestMessege = new HttpRequestMessage(HttpMethod.Post, $"{ApiUrl}/token")
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


        /// <summary>
        /// http://api.nesbilgi.com.tr/account/templateList/{xsltType}
        /// </summary>
        public async Task<GeneralResponse<List<AccountTemplate>>> AccountTemplateList(Domain.Account.XsltType xsltType)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/account/templateList/{xsltType.ToString()}");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<List<AccountTemplate>>>(content);
                return model;
            }
        }



        /// <summary>
        /// http://api.nesbilgi.com.tr/invoicegeneral/getInvoiceNumber/{uuid}
        /// </summary>
        public async Task<GeneralResponse<string>> DetailInvoiceNumber(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/invoicegeneral/getInvoiceNumber/{uuid}");

                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<string>>(content);
                return model;
            }
        }




        /// <summary>
        /// http://apitest.nesbilgi.com.tr/earchive/documentStatus/{uuid}
        /// </summary>
        public async Task<GeneralResponse<DocumentStatus>> DocumentStatus(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/earchive/documentStatus/{uuid}");

                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<DocumentStatus>>(content);
                return model;
            }
        }
    }
}