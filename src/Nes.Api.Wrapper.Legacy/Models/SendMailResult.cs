using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class SendMailResult
    {
        /// <summary>
        /// Mail gönderim sonucu
        /// </summary>
        public bool ResultStatus { get; set; }
        /// <summary>
        /// Alıcı mail adresi
        /// </summary>
        public string ReceiverMail { get; set; }
        /// <summary>
        /// Mail gönderim durum açıklaması.
        /// </summary>
        public string Description { get; set; }
    }
}
