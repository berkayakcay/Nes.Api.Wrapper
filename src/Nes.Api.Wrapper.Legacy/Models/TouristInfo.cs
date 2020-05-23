using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class TouristInfo
    {
        /// <summary>
        ///Bu alan turistin ad bilgisi girilir.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///Bu alan turistin soyad bilgisi girilir.
        /// </summary>
        public string SurName { get; set; }
        /// <summary>
        ///Bu alan turistin ülke kodu bilgisi girilir.(örn:TR)
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        ///Bu alan turistin pasaport numarası bilgisi girilir.
        /// </summary>
        public string PassportNo { get; set; }
        /// <summary>
        ///Bu alan turistin pasaport tarihi bilgisi girilir.
        /// </summary>
        public DateTime PassportDate { get; set; }
        /// <summary>
        ///Bu alan turistin adres bilgileri girilir.
        /// </summary>
        public AddressInfo AddressInfo { get; set; }
        /// <summary>
        ///Bu alana turistin banka hesap bilgileri girilir.
        /// </summary>
        public FinancialAccountInfo FinancialAccountInfo { get; set; }
    }
}
