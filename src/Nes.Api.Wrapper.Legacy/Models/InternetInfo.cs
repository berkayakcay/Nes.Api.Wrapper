using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class InternetInfo
    {
        /// <summary>
        /// Satışın yapıldığı web sitesi bilgisinin girileceği alandır.
        /// </summary>
        public string WebSite { get; set; }
        /// <summary>
        /// Ödeme yönteminin girilebileceği alandır. KREDIKARTI/BANKAKARTI, EFT/HAVALE, KAPIDAODEME, ODEMEARACISI yada DIGER değerlerini alabilir.
        /// </summary>
        public string PaymentMethod { get; set; }
        /// <summary>
        /// Ödeme yöntemi olarak DIGER yada ODEMEARACISI girildiğinde buraya diğerin açıklaması/ödemearacısı adı girilmesi gerekir.
        /// </summary>
        public string PaymentMethodName { get; set; }
        /// <summary>
        /// Ödeme tarihinin girileceği alandır.
        /// </summary>
        public DateTime? PaymentDate { get; set; }
        /// <summary>
        /// Taşıyıcı firma/kişi ünvanı.
        /// </summary>
        public string TransporterName { get; set; }
        /// <summary>
        /// Taşıyıcı firma/kişi vergi/tc kimlik numarası.
        /// </summary>
        public string TransporterRegisterNumber { get; set; }
        /// <summary>
        /// Taşıma tarihi
        /// </summary>
        public DateTime? TransportDate { get; set; }
    }
}
