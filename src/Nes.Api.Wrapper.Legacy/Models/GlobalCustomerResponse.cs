using System;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class GlobalCustomerResponse
    {
        public string RegisterNumber { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Type { get; set; }
        public DateTime FirstCreationTime { get; set; }
        public DateTime AliasCreationTime { get; set; }
    }
}
