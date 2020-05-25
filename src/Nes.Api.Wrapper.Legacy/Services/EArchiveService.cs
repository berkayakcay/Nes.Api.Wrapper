using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Interfaces;
using Nes.Api.Wrapper.Legacy.Models;

namespace Nes.Api.Wrapper.Legacy.Services
{
    public class EArchiveService : ServiceBase, IEArchiveGeneralService
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


        public async Task<GeneralResponse<string>> InvoiceCancel(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/earchive/invoiceCancel/{uuid}");

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

        public async Task<GeneralResponse<List<MailSendInfo>>> MailStatistics(string uuid)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/earchive/mailStatistics/{uuid}");

                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<List<MailSendInfo>>>(content);
                return model;
            }
        }

        public async Task<GeneralResponse<List<SendMailResult>>> SendMail(SendMailRequest sendMailRequest)
        {
            using (var httpClient = new HttpClient())
            {


                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, $"{ApiUrl}/earchive/sendMail");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var contentJsonString = System.Text.Json.JsonSerializer.Serialize(sendMailRequest);
                httpRequestMessage.Content = new StringContent(contentJsonString, System.Text.Encoding.UTF8, "application/json");

                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<List<SendMailResult>>>(content);
                return model;

            }
        }         

    }
}

