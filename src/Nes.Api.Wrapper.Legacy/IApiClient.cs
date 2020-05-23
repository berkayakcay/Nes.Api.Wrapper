using System;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Models;
using Nes.Api.Wrapper.Legacy.Services;

namespace Nes.Api.Wrapper.Legacy
{
    public interface IApiClient
    {
        /// <summary>
        /// Bilgileri sağlayacağımız bir yönetici class yapabiliriz
        /// </summary>
        string AccessToken { get; set; }

        DateTime ExpireDate { get; set; }
        AccountService Account { get; }
        InvoiceGeneralService InvoiceGeneral { get; }
        EArchiveService EArchive { get; }
        CustomerService Customer { get; }

        /// <summary>
        /// Token
        /// </summary>
        Task<LoginResponse> Token();
    }
}