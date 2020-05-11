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
    public class AccountService :  ServiceBase , IAccountService
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

        public Task<string> DownloadTemplate(XsltType xsltType, string title)
        {
            throw new System.NotImplementedException();
        }

        public Task<GeneralResponse<CreditDetailResponse>> CreditsInfo(XsltType xsltType, string title)
        {
            throw new System.NotImplementedException();
        }
    }
}