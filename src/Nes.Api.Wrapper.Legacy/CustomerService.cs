using Nes.Api.Wrapper.Legacy.Customer;
using Nes.Api.Wrapper.Legacy.Domain;
using Nes.Api.Wrapper.Legacy.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Nes.Api.Wrapper.Legacy
{
    public class CustomerService : ServiceBase, ICustomerService
    {
        public CustomerService(string apiUrl, string accesToken) : base(apiUrl, accesToken)
        {
        }


        public async Task<GeneralResponse<CustomerCheckResult>> Check(string registerNumber)
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/customer/check/{registerNumber}");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<CustomerCheckResult>>(content);
                return model;
            }
        }


        public async Task<GeneralResponse<List<GlobalCustomer>>> AllCustomer()
        {
            using (var httpClient = new HttpClient())
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ApiUrl}/customer/all");
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<GeneralResponse<List<GlobalCustomer>>>(content);
                return model;
            }
        }

    }
}
