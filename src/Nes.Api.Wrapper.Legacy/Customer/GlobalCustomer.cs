
using System;
using System.Collections.Generic;

namespace Nes.Api.Wrapper.Legacy.Customer
{
    public class GlobalCustomer
    {
        public string RegisterNumber { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Type { get; set; }
        public DateTime FirstCreationTime { get; set; }
        public DateTime AliasCreationTime { get; set; }
    }


    public class CustomerCheckResult
    {
        public List<GlobalCustomer> CustomerList { get; set; }
        public bool ISEInvoiceCustomer { get; set; }
    }
}
