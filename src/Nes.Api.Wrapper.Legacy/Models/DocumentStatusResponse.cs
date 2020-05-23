namespace Nes.Api.Wrapper.Legacy.Models
{
    public class DocumentStatusResponse
    {
        /// <summary>
        /// Fatura durumunun kodu bu alanda döner
        /// </summary>
        public int InvoiceStatusCode { get; set; }
        /// <summary>
        /// Fatura durum açıklaması bu alanda döner
        /// </summary>
        public string InvoiceStatusDescription { get; set; }
        /// <summary>
        /// Fatura durum açıklamasının detayı bu alanda döner
        /// </summary>
        public string InvoiceStatusDetailDescription { get; set; }
        /// <summary>
        /// Faturanın iptal edilip edilmediği bu alanda dönülür. 
        /// </summary>
        public bool IsCancel { get; set; } 
    }
}
