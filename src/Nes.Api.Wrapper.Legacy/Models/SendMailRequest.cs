using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class SendMailRequest
    {
        /// <summary>
        /// Mail gönderilmek istenen faturanın ETTN değeri.
        /// </summary>
        public string InvoiceUUID { get; set; }
        /// <summary>
        /// Faturanın mail olarak gönderilmesini istediğiniz mail adresi listesi girilir.
        /// </summary>
        public List<string> ReceiverMailList { get; set; }
    }
}
