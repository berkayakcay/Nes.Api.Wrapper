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

        // GET Şablon (XSLT) içeriğini alma
        // http://apitest.nesbilgi.com.tr/account/downloadTemplate/{xsltType}/{title}
        Task<string> DownloadTemplate(XsltType xsltType, string title);
      
        // GET Firmanın kontör detaylarını alma
        // http://apitest.nesbilgi.com.tr/account/creditsInfo
        Task<GeneralResponse<CreditDetailResponse>> CreditsInfo(XsltType xsltType, string title);
    }
}