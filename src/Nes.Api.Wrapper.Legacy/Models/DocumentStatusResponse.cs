namespace Nes.Api.Wrapper.Legacy.Models
{
    public class DocumentStatusResponse
    {
        public int InvoiceStatusCode { get; set; } //Fatura durumunun kodu bu alanda döner
        public string InvoiceStatusDescription { get; set; } //Fatura durum açıklaması bu alanda döner
        public string InvoiceStatusDetailDescription { get; set; } //Fatura durum açıklamasının detayı bu alanda döner
        public bool IsCancel { get; set; } //Faturanın iptal edilip edilmediği bu alanda dönülür.
    }
}
