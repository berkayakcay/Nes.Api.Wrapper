using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class ExportCustomerInfo
    {
        /// <summary>
        /// Bu alana yabancı alıcı ünvanı girilir.
        /// </summary>
        public string PartyName { get; set; }
        /// <summary>
        /// Bu alana yabancı alıcının adı girilir.
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// Bu alana yabancı alıcının soyadı girilir.
        /// </summary>
        public string PersonSurName { get; set; }
        /// <summary>
        /// Bu alana yabancı alıcının ülkesindeki VKN(VAT-No) bilgisi girilir.
        /// </summary>
        public string CompanyID { get; set; }
        /// <summary>
        /// Bu alana yabancı alıcının ülkesindeki Resmi Ünvan bilgisi girilir.
        /// </summary>
        public string LegalRegistrationName { get; set; }
        /// <summary>
        /// Bu alana yabancı alıcının adres bilgileri girilir.
        /// </summary>
        public AddressInfo AddressInfo { get; set; }
    }
}
