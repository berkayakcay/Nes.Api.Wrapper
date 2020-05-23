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

        ///<summary>
        ///http://api.nesbilgi.com.tr/invoicegeneral/pdf/{uuid}
        ///</summary>
        Task<GeneralResponse<byte[]>> Pdf(string uuid);

        ///<summary>
        ///http://apitest.nesbilgi.com.tr/invoicegeneral/deletedraft/{uuid}
        ///</summary>
        Task<GeneralResponse<string>> DeleteDraft(string uuid);

        ///<summary>
        ///http://apitest.nesbilgi.com.tr/invoicegeneral/approveandsenddraft/{uuid}
        ///</summary>
        Task<GeneralResponse<string>> ApproveandSendDraft(string uuid);

        ///<summary>
        ///http://apitest.nesbilgi.com.tr/invoicegeneral/sendNESInvoice
        ///</summary>
        Task<GeneralResponse<string>> SendNesInvoice(NesInvoiceSendRequest nesInvoiceSendRequest);

        ///<summary>
        ///http://apitest.nesbilgi.com.tr/invoicegeneral/sendUBLInvoice
        ///</summary>
        Task<GeneralResponse<bool>> SendUblInvoice(UblInvoiceSendRequest ublInvoiceSendRequest);
    }
}