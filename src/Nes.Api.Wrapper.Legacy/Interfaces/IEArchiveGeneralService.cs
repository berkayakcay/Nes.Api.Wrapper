using Nes.Api.Wrapper.Legacy.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Nes.Api.Wrapper.Legacy.Interfaces
{
    interface IEArchiveGeneralService
    {

        ///<summary>
        ///GET Belirtilen UUID'ye ait faturanın mail istatistiklerini alma
        ///http://api.nesbilgi.com.tr/earchive/mailStatistics/{uuid}
        ///</summary>
        Task<GeneralResponse<List<MailSendInfo>>> MailStatistics(string uuid);

        ///<summary>
        /// GET Belirtilen UUID'ye ait faturayı iptal etme
        ///http://api.nesbilgi.com.tr/earchive/invoiceCancel/{uuid}
        ///</summary>
        Task<GeneralResponse<string>> InvoiceCancel(string uuid);

        ///<summary>
        /// POST Belirtilen UUID'ye ait faturayı belirtilen kişilere mail atma
        ///http://api.nesbilgi.com.tr/earchive/sendMail
        ///</summary>
        //Task<GeneralResponse<List<SendMailResult>>> SendMail(SendMailRequest sendMailRequest);

    }
}

