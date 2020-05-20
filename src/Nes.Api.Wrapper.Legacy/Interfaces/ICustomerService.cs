using Nes.Api.Wrapper.Legacy.Customer;
using Nes.Api.Wrapper.Legacy.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nes.Api.Wrapper.Legacy.Interfaces
{
    interface ICustomerService
    {
        // GET Belirtilen VKN/TCKN'nin e-Fatura mükellefi olup olmadığını sorgulama
        // http://apitest.nesbilgi.com.tr/customer/check/{registerNumber}
        Task<GeneralResponse<CustomerCheckResult>> Check(string registerNumber);

        // GET Sistemde kayıtlı tüm e-Fatura mükelleflerini çekme
        // http://apitest.nesbilgi.com.tr/customer/all
        Task<GeneralResponse<List<GlobalCustomer>>> AllCustomer();
    }
}
