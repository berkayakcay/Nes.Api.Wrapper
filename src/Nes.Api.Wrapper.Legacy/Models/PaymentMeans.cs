using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class PaymentMeans
    {
        /// <summary>
        ///Ödeme şeklinin kodu girilir. 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        ///Ödeme kanalı kodunun girileceği alandır. 
        /// </summary>
        public string ChannelCode { get; set; }
        /// <summary>
        ///Son ödeme günü yıl-ay-gün formatında girilir.
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        ///Ödeme yapılacak hesap girilir.
        /// </summary>
        public string PayeeFinancialAccountID { get; set; }
        /// <summary>
        ///Ödeme ile ilgili açıklamalar serbest metin olarak girilir.
        /// </summary>
        public string Note { get; set; }
    }
}
