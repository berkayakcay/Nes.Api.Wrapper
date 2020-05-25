using System;

namespace Nes.Api.Wrapper.Legacy.Models
{

    public class MailSendInfo

    {
        /// <summary>
        /// Mailin gönderildiği adres bilgisi bu alanda döner.
        /// </summary>
        public string ReceiverMail { get; set; }
        /// <summary>
        /// Gönderilen mailin okunup okunmadığı bilgisi bu alanda döner.
        /// </summary>
        public bool IsRead { get; set; }
        /// <summary>
        ///Mailin okunma tarihi.
        /// </summary>
        public DateTime ReadDate { get; set; }
        /// <summary>
        /// Mailin başarıyla gönderilip gönderilmediği bilgisi bu alanda döner.
        /// </summary>
        public bool IsSend { get; set; }
        /// <summary>
        /// Mailin gönderilme tarihi.
        /// </summary>
        public DateTime SendDate { get; set; }
        /// <summary>
        /// Gönderilen mailing durumunun sorgulanıp sorgulanmadığının bilgisi bu alanda döner.
        /// </summary>
        public bool IsStatusCheck { get; set; }
        /// <summary>
        /// Mailin içerisindeki XML/PDF dosyasının indirilip indirilemediği bilgisi bu alanda döner.
        /// </summary>
        public bool IsDownload { get; set; }
        /// <summary>
        /// Mailin içerisindeki faturanın görüntülenip görüntülenmediği bilgisi bu alanda döner. 
        /// </summary>
        public bool IsView { get; set; }
        /// <summary>
        /// /Mail gönderiminde hata olması durumunda hata detayı bu alnda döner.
        /// </summary>
        public string SendErrorDescription { get; set; }
    }

}