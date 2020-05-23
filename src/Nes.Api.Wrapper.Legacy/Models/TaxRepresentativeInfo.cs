using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class TaxRepresentativeInfo
    {
        /// <summary>
        ///Bu alana Aracı Kurumun Vergi Kimlik Numarası girilir.
        /// </summary>
        public string RegisterNumber { get; set; }
        /// <summary>
        ///Bu alana Aracı Kurumun Etiket bilgisi girilir.
        /// </summary>
        public string Alias { get; set; }
        /// <summary>
        ///Bu alan turistin adres bilgileri girilir.
        /// </summary>
        public AddressInfo Address { get; set; }
    }
}
