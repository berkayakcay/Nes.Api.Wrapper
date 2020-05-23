using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class TaxFreeInfo
    {
        /// <summary>
        ///Bu alan turistin bilgilerinin girileceği alandır.
        /// </summary>
        public TouristInfo TouristInfo { get; set; }
        /// <summary>
        ///Bu alana Aracı Kurum bilgileri girilir.
        /// </summary>
        public TaxRepresentativeInfo TaxRepresentativeInfo { get; set; }
    }
}
