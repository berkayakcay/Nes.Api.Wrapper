using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class Tax
    {
        /// <summary>
        ///Bu alana verginin kodu girilmelidir.
        /// </summary>
        public string TaxCode { get; set; }
        /// <summary>
        ///Vergi toplamının girileceği alandır.
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        ///Verginin oranı bu alana girilir.
        /// </summary>
        public decimal Percent { get; set; }
        /// <summary>
        ///Verginin istisna sebebinin yada tevkifatın kodunun girilebileceği alandır.
        /// </summary>
        public string ReasonCode { get; set; }
    }
}
