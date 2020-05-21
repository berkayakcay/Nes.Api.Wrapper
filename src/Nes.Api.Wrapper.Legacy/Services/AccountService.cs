using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Interfaces;
using Nes.Api.Wrapper.Legacy.Models;

namespace Nes.Api.Wrapper.Legacy.Services
{
    public class AccountService : ServiceBase, IAccountService
    {
        public AccountService(string apiUrl, string accessToken) : base(apiUrl, accessToken)
        {
        }
        
        public async Task<GeneralResponse<List<AccountTemplaterResponse>>> TemplateList(XsltTypeResponseParameter xsltTypeResponseParameter)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/account/templateList/{xsltTypeResponseParameter.ToString()}");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<List<AccountTemplaterResponse>>>(content);
                return model;
            }
        }

        public async Task<GeneralResponse<string>> DownloadTemplate(XsltTypeResponseParameter xsltTypeResponseParameter, string title)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/account/downloadTemplate/{xsltTypeResponseParameter.ToString()}");
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