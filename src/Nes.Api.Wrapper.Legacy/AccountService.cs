using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Account;
using Nes.Api.Wrapper.Legacy.Domain;
using Nes.Api.Wrapper.Legacy.Domain.Account;
using Nes.Api.Wrapper.Legacy.Interfaces;

namespace Nes.Api.Wrapper.Legacy
{
    public class AccountService : ServiceBase, IAccountService
    {
        public AccountService(string apiUrl, string accessToken) : base(apiUrl, accessToken)
        {
        }

        public async Task<GeneralResponse<List<AccountTemplate>>> TemplateList(Domain.Account.XsltType xsltType)
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

        public async Task<GeneralResponse<string>> DownloadTemplate(XsltType xsltType, string title)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/account/downloadTemplate/{xsltType.ToString()}");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = new GeneralResponse<string>()
                {
                    Result = content
                };
                return model;
            }
        }

        public async Task<GeneralResponse<CreditDetailResponse>> CreditsInfo()
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/account/creditsInfo");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<CreditDetailResponse>>(content);
                
                return model;
            }
        }
    }
}