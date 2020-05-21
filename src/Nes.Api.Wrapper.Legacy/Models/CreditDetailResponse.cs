using System;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class CreditDetailResponse
    {
        /// <summary>
        /// E-Fatura tarafında kullanılan kontör sayısı bu alanda dönülür.
        /// </summary>
        public int EInvoiceUseCount { get; set; }

        /// <summary>
        /// E-Arşiv tarafında kullanılan kontör sayısı bu alanda dönülür.
        /// </summary>
        public int EArchiveUseCount { get; set; }

        /// <summary>
        /// E-Defter tarafında kullanılan kontör sayısı bu alanda dönülür.
        /// </summary>
        public int EBookUseCount { get; set; }

        /// <summary>
        /// Mail için kullanılan kontör sayısı bu alanda dönülür.
        /// </summary>
        public int MailUseCount { get; set; }

        /// <summary>
        /// SMS için kullanılan kontör sayısı bu alanda dönülür.
        /// </summary>
        public int SMSUseCount { get; set; }

        /// <summary>
        /// Kontör kullanımının en son ne zaman hesaplandığı bilgisi bu alanda dönülür.
        /// </summary>
        public DateTime CalculateDate { get; set; }

        /// <summary>
        /// Toplam kullanılan kontör sayısı bu alanda dönülür.
        /// </summary>
        public int TotalUseCount { get; set; }

        /// <summary>
        /// Toplam satın alınan kontör sayısı bu alanda dönülür.
        /// </summary>
        public int TotalBuyCount { get; set; }

        /// <summary>
        /// Kalan kontör sayısı bu alanda dönülür.
        /// </summary>
        public int Result { get; set; }

        /// <summary>
        /// Kullanılan kontörün yüzde cinsinden değeri bu alanda dönülür.
        /// </summary>
        public int UsePercentage { get; set; }
    }
}