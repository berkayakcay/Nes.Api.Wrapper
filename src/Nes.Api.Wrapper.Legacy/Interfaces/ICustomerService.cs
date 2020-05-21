using System.Collections.Generic;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Models;

namespace Nes.Api.Wrapper.Legacy.Interfaces
{
    interface ICustomerService
    {
        /// <summary>
        /// GET Belirtilen VKN/TCKN'nin e-Fatura mükellefi olup olmadığını sorgulama
        /// http://apitest.nesbilgi.com.tr/customer/check/{registerNumber}
        /// </summary>
        /// <param name="registerNumber"></param>
        Task<GeneralResponse<CustomerCheckResponse>> Check(string registerNumber);


        /// <summary>
        /// GET Sistemde kayıtlı tüm e-Fatura mükelleflerini çekme
        /// http://apitest.nesbilgi.com.tr/customer/all
        /// </summary>
        Task<GeneralResponse<List<GlobalCustomerResponse>>> AllCustomer();
        

        /// <summary>
        /// GET Sistemde kayıtlı tüm e-Fatura mükelleflerini ZIP olarak indirme
        /// http://api.nesbilgi.com.tr/customer/downloadZip
        /// </summary>
        Task<GeneralResponse<byte[]>> DownloadZip();
    }
}
