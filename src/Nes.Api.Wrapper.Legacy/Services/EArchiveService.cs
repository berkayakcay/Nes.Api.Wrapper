using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Models;

namespace Nes.Api.Wrapper.Legacy.Services
{
    public class EArchiveService : ServiceBase
    {
        public EArchiveService(string apiUrl, string accesToken) : base(apiUrl, accesToken)
        {
        }


        /// <summary>
        /// http://apitest.nesbilgi.com.tr/earchive/documentStatus/{uuid}
        /// </summary>
        public async Task<GeneralResponse<DocumentStatusResponse>> DocumentStatus(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/earchive/documentStatus/{uuid}");

                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<DocumentStatusResponse>>(content);
                return model;
            }
        }
    }
}