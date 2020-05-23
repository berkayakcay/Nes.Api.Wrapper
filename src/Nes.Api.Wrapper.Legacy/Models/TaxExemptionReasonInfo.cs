using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class TaxExemptionReasonInfo
    {
        /// <summary>
        ///Bu alan faturada birden fazla verdi var ise vergi kodunun girileceği alandır
        /// </summary>
        public string KDVExemptionReasonCode { get; set; }
        /// <summary>
        ///Bu alan faturada ÖTV var ise vergi kodunun girileceği alandır
        /// </summary>
        public string OTVExemptionReasonCode { get; set; }
    }
}
