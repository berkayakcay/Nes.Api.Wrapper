using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class NesInvoiceSendRequest
    {
        /// <summary>
        ///Fatura değerleri gönderilecek nesne
        /// </summary>
        public NESInvoice NesInvoice { get; set; }
        /// <summary>
        ///Fatura profili bilgisi
        /// </summary>
        public InvoceProfile InvoiceProfile { get; set; }
        /// <summary>
        ///Alıcı firma/kişi nin vkn/tckn bilgisi.
        /// </summary>
        public string CustomerRegisterNumber { get; set; }
        /// <summary>
        ///Faturanın direkt gönderilip/gönderilmeyeceği bu alanla belirlenir.
        /// </summary>
        public bool IsDirectSend { get; set; } 
    }
}
