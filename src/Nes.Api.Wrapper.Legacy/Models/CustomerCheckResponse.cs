using System.Collections.Generic;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class CustomerCheckResponse
    {
        public List<GlobalCustomerResponse> CustomerList { get; set; }
        public bool ISEInvoiceCustomer { get; set; }
    }
}