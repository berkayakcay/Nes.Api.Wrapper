using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class AddressInfo
    {
        /// <summary>
        /// Bu alana alıcı/göndericinin adres bilgisi girilir.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin ilçe bilgisi girilir.
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin şehir bilgisi girilir.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin ülke bilgisi girilir.
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin posta kodu girilir.
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin telefon bilgisi girilir.
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin Fax bilgisi girilir.
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin Mail bilgisi girilir.
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin web site bilgisi girilir.
        /// </summary>
        public string WebSite { get; set; }
    }
}
