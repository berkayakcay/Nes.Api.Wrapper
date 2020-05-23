using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class NESInvoice
    {
        /// <summary>
        ///Bu nesne, fatura üst bilgilerini barındıran nesnedir.
        /// </summary>
        public InvoiceInfo InvoiceInfo { get; set; }
        /// <summary>
        ///Gönderici bilgilerinin girileceği alandır.
        /// </summary>
        public PartyInfo CompanyInfo { get; set; }
        /// <summary>
        ///Alıcı bilgilerinin girileceği alandır.
        /// </summary>
        public PartyInfo CustomerInfo { get; set; }
        /// <summary>
        ///Bu alan İhracat faturalarında yabancı alıcı genel bilgilerinin girileceği alandır.
        /// </summary>
        public ExportCustomerInfo ExportCustomerInfo { get; set; }
        /// <summary>
        ///YOLCUBERABERFATURA ' da turistin bilgilerinin girileceği alandır. 
        /// </summary>
        public TaxFreeInfo TaxFreeInfo { get; set; }
        /// <summary>
        ///Fatura kalemlerinin(Mal/Hizmet) tüm detaylarının girileceği alandır.
        /// </summary>
        public List<InvoiceLine> InvoiceLines { get; set; }
        /// <summary>
        ///Bu alana sınırsız not eklenebilir.
        /// </summary>
        public List<string> Notes { get; set; }
        /// <summary>
        ///Bu parametre ile faturanın e-Fatura veya e-Arşiv ayrımını belirleyebilirsiniz. Eğer fatura e-Arşiv faturası değilse false olarak set edilmelidir
        /// </summary>
        public bool ISEArchiveInvoice { get; set; }
    }
}
