using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Interfaces;
using Nes.Api.Wrapper.Legacy.Models;

namespace Nes.Api.Wrapper.Legacy.Services
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

        public async Task<GeneralResponse<byte[]>> Pdf(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/invoicegeneral/pdf/{uuid}");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsByteArrayAsync();
                var model = new GeneralResponse<byte[]>()
                {
                    Result = content
                };

                return model;
            }
        }


        public async Task<GeneralResponse<string>> DeleteDraft(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/invoicegeneral/deletedraft/{uuid}");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);


                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<string>>(content);

                return model;
            }
        }

        public async Task<GeneralResponse<string>> ApproveandSendDraft(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/invoicegeneral/approveandsenddraft/{uuid}");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);


                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<string>>(content);

                return model;
            }
        }



        public async Task<GeneralResponse<string>> SendNesInvoice(NesInvoiceSendRequest nesInvoiceSendRequest)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, $"{ApiUrl}/invoicegeneral/sendNESInvoice");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var contentJsonString = System.Text.Json.JsonSerializer.Serialize(nesInvoiceSendRequest);
                
                httpRequestMessage.Content = new StringContent(contentJsonString,System.Text.Encoding.UTF8,"application/json");

                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<string>>(content);

                return model;
            }
        }


        public async Task<GeneralResponse<bool>> SendUblInvoice(UblInvoiceSendRequest ublInvoiceSendRequest)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, $"{ApiUrl}/invoicegeneral/sendUBLInvoice");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var contentJsonString = System.Text.Json.JsonSerializer.Serialize(ublInvoiceSendRequest);

                httpRequestMessage.Content = new StringContent(contentJsonString, System.Text.Encoding.UTF8, "application/json");

                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<bool>>(content);

                return model;
            }
        }
    }
}