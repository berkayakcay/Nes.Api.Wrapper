using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Interfaces;

namespace Nes.Api.Wrapper.Legacy
{
    public class InvoiceGeneralService : ServiceBase, IInvoiceGeneralService
    {
        public InvoiceGeneralService(string apiUrl, string accessToken) : base(apiUrl, accessToken)
        {
        }

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

        public async Task<GeneralResponse<string>> Html(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/invoicegeneral/html/{uuid}");
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


        public async Task<GeneralResponse<string>> UblXmlContent(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/invoicegeneral/ublXmlContent/{uuid}");
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
    }
}