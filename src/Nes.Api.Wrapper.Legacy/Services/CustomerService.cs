using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Interfaces;
using Nes.Api.Wrapper.Legacy.Models;

namespace Nes.Api.Wrapper.Legacy.Services
{
    public class CustomerService : ServiceBase, ICustomerService
    {
        public CustomerService(string apiUrl, string accesToken) : base(apiUrl, accesToken)
        {
        }


        public async Task<GeneralResponse<CustomerCheckResponse>> Check(string registerNumber)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/customer/check/{registerNumber}");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<CustomerCheckResponse>>(content);
                return model;
            }
        }


        public async Task<GeneralResponse<List<GlobalCustomerResponse>>> AllCustomer()
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/customer/all");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<List<GlobalCustomerResponse>>>(content);
                return model;
            }
        }

        public async Task<GeneralResponse<byte[]>> DownloadZip()
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/customer/downloadZip");
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
    }
}