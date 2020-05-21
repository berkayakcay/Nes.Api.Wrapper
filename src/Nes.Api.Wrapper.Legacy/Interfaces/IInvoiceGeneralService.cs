using System.Threading.Tasks;
using Nes.Api.Wrapper.Legacy.Models;

namespace Nes.Api.Wrapper.Legacy.Interfaces
{
    public interface IInvoiceGeneralService
    {
        /// <summary>
        /// http://api.nesbilgi.com.tr/invoicegeneral/getInvoiceNumber/{uuid}
        /// </summary>
        Task<GeneralResponse<string>> DetailInvoiceNumber(string uuid);

        ///<summary>
        ///http://api.nesbilgi.com.tr/invoicegeneral/html/{uuid}
        ///</summary>
        Task<GeneralResponse<string>> Html(string uuid);

        ///<summary>
        /// http://api.nesbilgi.com.tr/invoicegeneral/ublXmlContent/{uuid}
        ///</summary>
        Task<GeneralResponse<string>> UblXmlContent(string uuid);
    }
}