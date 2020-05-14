using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Domain;

namespace Nes.Api.Wrapper.Legacy
{
    public class InvoiceGeneralService : ServiceBase
    {
        public InvoiceGeneralService(string apiUrl, string accessToken) : base(apiUrl, accessToken)
        {
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

        ///<summary>
        ///http://api.nesbilgi.com.tr/invoicegeneral/html/{uuid}
        ///</summary>
        public async Task<string> Html(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/invoicegeneral/html/{uuid}");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();

                return content;
            }

        }
    }
}