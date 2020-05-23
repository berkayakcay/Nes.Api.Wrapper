using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class UBLInvoiceSendRequest
    {
        /// <summary>
        ///Gönderilecek olan UBL faturanın detay bilgileri bu alana eklenir.
        /// </summary>
        public NESTransferDocument TransferDocument { get; set; }
        /// <summary>
        ///Fatura profili bilgisi
        /// </summary>
        public InvoceProfile InvoiceProfile { get; set; }
        /// <summary>
        ///Alıcı firma/kişi nin vkn/tckn bilgisi.
        /// </summary>
        public string CustomerRegisterNumber { get; set; }
        /// <summary>
        ///Faturayı alıcısının etiket/alias bilgisi.
        /// </summary>
        public string eInvoiceAlias { get; set; }
    }
}
