using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class PaymentTerms
    {
        /// <summary>
        ///Ödemenin gecikmesi durumunda uygulanacak ceza oranı numerik olarak girilir.
        /// </summary>
        public decimal Percent { get; set; }
        /// <summary>
        ///Ödeme tutarı numerik olarak girilebilir.
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        ///Ödeme koşulları ile ilgili açıklama serbest metin olarak girilir.
        /// </summary>
        public string Note { get; set; }
    }
}
