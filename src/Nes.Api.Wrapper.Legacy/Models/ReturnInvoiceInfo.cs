using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class ReturnInvoiceInfo
    {
        /// <summary>
        ///İade edilen faturanın numarası bu alana girilir. Fatura numarası 16 haneli olmak zorundadır.
        /// </summary>
        public string InvoiceNumber { get; set; }
        /// <summary>
        ///İade edilen faturanın tarihi bu alana girilir.
        /// </summary>
        public DateTime IssueDate { get; set; }
    }
}
