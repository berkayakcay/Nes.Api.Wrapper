using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class NESTransferDocument
    {
        /// <summary>
        ///	Faturanın UUID değeri.
        /// </summary>
        public string UUID { get; set; }
        /// <summary>
        ///{Fatura UUID}.xml şeklinde olmalıdır.
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Gönderilecek XML formatındaki faturanın zip halindeki string Base64 değeri bu alana eklenir.
        /// </summary>
        public string ZIPFileBase64 { get; set; }
        /// <summary>
        ///Faturanın direkt gönderilip/gönderilmeyeceği bu alanla belirlenir.
        /// </summary>
        public bool IsDirectSend { get; set; }
    }
}
