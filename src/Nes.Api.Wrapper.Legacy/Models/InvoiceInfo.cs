using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class InvoiceInfo
    {
        /// <summary>
        /// Guid veri tipinde faturanın takibi için kullanılacak unique numaradır.
        /// </summary>
        public string UUID { get; set; }
        /// <summary>
        /// Enum veri tipinde bir nesnedir.
        /// </summary>
        public InvoiceType InvoiceType { get; set; }
        /// <summary>
        /// Bu alana 16 haneli e-Fatura/e-Arşiv fatura numarasını, 3 haneli seri bilgisini girebilirsiniz. 
        /// </summary>
        public string InvoiceSerieOrNumber { get; set; }
        /// <summary>
        /// Bu alana fatura tarihi girilir.
        /// </summary>
        public DateTime IssueDate { get; set; }
        /// <summary>
        /// Bu alana fatura düzenleme saati girilir.
        /// </summary>
        public DateTime IssueTime { get; set; }
        /// <summary>
        /// Bu alan faturanın para biriminin girileceği alandır.
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Bu alan faturanın türk lirasından farklı bir para biriminde kesildiğinde döviz kurunun girileceği alandır. Fatura üzerinde kur bilgisi görünecektir.
        /// </summary>
        public decimal ExchangeRate { get; set; }
        /// <summary>
        /// Bu alan e-faturanın senaryosunun belirtileceği alandır.
        /// </summary>
        public InvoceProfile InvoiceProfile { get; set; }
        /// <summary>
        /// Bu alan faturaya ait irsaliye bilgilerinin girilebileceği alandır. Birden fazla irsaliye girilebilir
        /// </summary>
        public List<KeyValue> DespatchDocumentReference { get; set; }
        /// <summary>
        /// Bu alan faturaya ait sipariş bilgilerinin girilebileceği alandır.
        /// </summary>
        public KeyValue OrderReference { get; set; }
        /// <summary>
        /// Bu alan faturaya ait sipariş bilgilerinin girilebileceği alandır. 
        /// </summary>
        public AdditioanlDocumentReference OrderReferenceDocument { get; set; }
        /// <summary>
        /// Fatura içerisine Word,excel,pdf vs. gibi dosyalar eklemek yada farklı bilgileri eklemek için kullanabileceğiniz alandır.
        /// </summary>
        public List<AdditioanlDocumentReference> AdditionalDocumentReferences { get; set; }
        /// <summary>
        /// Bu alan faturadaki 0 KDV/ÖTV lerin vergi muafiyet sebeplerini girebileceğiniz alandır.
        /// </summary>
        public TaxExemptionReasonInfo TaxExemptionReasonInfo { get; set; }
        /// <summary>
        /// Bu alan faturaya eklenecek olan XSLT’yi seçmeniz için kullanılır. Burada girilen değer portalde tanımlı XSLT’nizi otomatik olarak faturaya ekler.
        /// </summary>
        public string XSLTTitle { get; set; }
        /// <summary>
        /// Bu alan faturaya eklenecek olan XSLT’nin dosya sistemindeki yolunu belirtmek için kullanılır. Burada girilen değer üzerinden dosya sistemindeki XSLT faturaya eklenir.
        /// </summary>
        public string XSLTPath { get; set; }
        /// <summary>
        /// Bu alan fatura ile ERP arasında bağlantı kurmak istendiğinde kullanılmalıdır. ERP’den referans olarak erp’deki unique bir değer girilebilir.
        /// </summary>
        public string ERPRefNo { get; set; }
        /// <summary>
        /// Bu alan fatura ile ERP de kayıtlı alıcı arasında bağlantı kurmak istendiğinde kullanılmalıdır. ERP’den referans olarak erp’deki alıcı ile alakalı unique bir değer girilebilir.
        /// </summary>
        public string ERPCustomerRefNo { get; set; }
        /// <summary>
        /// Faturanın e-Arşiv faturası olması durumunda e-Arşiv’e özgü bilgilerin girileceği alandır.
        /// </summary>
        public EArchiveInfo EArchiveInfo { get; set; }
        /// <summary>
        /// SQL Scriptler ile NES Bilgi eCon.online ürününün kullanılması durumunda kullanılacak bir alandır. Standart web servis erişimleri için UBL üretilmek istendiğinde kullanılması gerekmez.
        /// </summary>
        public int DraftInvoiceID { get; set; }
        /// <summary>
        /// Bu alan Ödeme Koşulları bilgisinin girileceği alandır.
        /// </summary>
        public PaymentTerms PaymentTermsInfo { get; set; }
        /// <summary>
        /// Bu alan Ödeme Şekli bilgisinin girileceği alandır.
        /// </summary>
        public PaymentMeans PaymentMeansInfo { get; set; }
        /// <summary>
        /// Bu alan Ödeme kaydedici cihaz ve fiş bilgisinin girileceği alandır.
        /// </summary>
        public OKCInfo OKCInfo { get; set; }
        /// <summary>
        /// Bu alan İade edilen faturaların bilgilerinin girileceği alandır.
        /// </summary>
        public ReturnInvoiceInfo ReturnInvoiceInfo { get; set; }

    }
}
