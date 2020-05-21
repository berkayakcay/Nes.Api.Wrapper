using System.Collections.Generic;
using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Models;

namespace Nes.Api.Wrapper.Legacy.Interfaces
{
    public interface IAccountService
    {
        // GET Şablon (XSLT) Listesi
        // http://apitest.nesbilgi.com.tr/account/templateList/{xsltTypeResponseParameter}
        Task<GeneralResponse<List<AccountTemplaterResponse>>> TemplateList(XsltTypeResponseParameter xsltTypeResponseParameter);

        /// <summary>
        /// GET Şablon (XSLT) içeriğini alma
        /// http://apitest.nesbilgi.com.tr/account/downloadTemplate/{xsltTypeResponseParameter}/{title}
        /// </summary>
        /// <param name="xsltTypeResponseParameter"></param>
        /// <param name="title"></param>
        Task<GeneralResponse<string>> DownloadTemplate(XsltTypeResponseParameter xsltTypeResponseParameter, string title);

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