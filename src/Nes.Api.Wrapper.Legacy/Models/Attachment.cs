using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class Attachment
    {
        /// <summary>
        /// Bu alana alıcı/göndericinin web site bilgisi girilir.
        /// </summary>
        public string Base64Data { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin web site bilgisi girilir.
        /// </summary>
        public string MimeCode { get; set; }
        /// <summary>
        /// Bu alana alıcı/göndericinin web site bilgisi girilir.
        /// </summary>
        public string FileName { get; set; }
    }
}
