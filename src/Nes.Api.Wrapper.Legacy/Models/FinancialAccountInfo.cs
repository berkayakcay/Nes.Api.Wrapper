using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class FinancialAccountInfo
    {
        /// <summary>
        /// Bu alan Banka Adı bilgisi girilir.
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// Bu alan Banka Şube Adı bilgisi girilir.
        /// </summary>
        public string BranchName { get; set; }
        /// <summary>
        /// Bu alan Banka Hesap Numarası bilgisi girilir.
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Bu alan Para Birimi bilgisi girilir.
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Bu alan Ödeme Notu bilgisi girilir.
        /// </summary>
        public string PaymentNote { get; set; }
    }
}
