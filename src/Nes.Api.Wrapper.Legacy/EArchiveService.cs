using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Domain;
using Nes.Api.Wrapper.Legacy.Domain.Account;

namespace Nes.Api.Wrapper.Legacy
{
    public class EArchiveService : ServiceBase
    {
        public EArchiveService(string apiUrl, string accesToken) : base(apiUrl, accesToken)
        {
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