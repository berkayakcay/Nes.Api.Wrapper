using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Nes.Api.Wrapper.Legacy.Account;
using Nes.Api.Wrapper.Legacy.Domain;
using Nes.Api.Wrapper.Legacy.Domain.Account;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;

namespace Nes.Api.Wrapper.Legacy.Interfaces
{
    public interface IAccountService
    {
        // GET Şablon (XSLT) Listesi
        // http://apitest.nesbilgi.com.tr/account/templateList/{xsltType}
        Task<GeneralResponse<List<AccountTemplate>>> TemplateList(XsltType xsltType);

        /// <summary>
        /// GET Şablon (XSLT) içeriğini alma
        /// http://apitest.nesbilgi.com.tr/account/downloadTemplate/{xsltType}/{title}
        /// </summary>
        /// <param name="xsltType"></param>
        /// <param name="title"></param>
        Task<GeneralResponse<string>> DownloadTemplate(XsltType xsltType, string title);

        /// <summary>
        /// GET Firmanın kontör detaylarını alma
        /// http://apitest.nesbilgi.com.tr/account/creditsInfo
        /// </summary>
        /// <remarks>
        /// Firmanın kalan kontör ve kullanım detayları gibi bilgilere erişim için kullanılır.
        /// </remarks>
        Task<GeneralResponse<CreditDetailResponse>> CreditsInfo();
    }
}