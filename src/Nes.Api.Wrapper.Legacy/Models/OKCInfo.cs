using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class OKCInfo
    {
        /// <summary>
        ///Fiş No
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        ///Fiş Tarihi
        /// </summary>
        public DateTime IssueDate { get; set; }
        /// <summary>
        ///Fiş Saati
        /// </summary>
        public string Time { get; set; }
        /// <summary>
        ///Z Rapor No
        /// </summary>
        public string ZNo { get; set; }
        /// <summary>
        ///ÖKC Seri No
        /// </summary>
        public string EndPointID { get; set; }
        /// <summary>
        ///Fiş Açıklaması
        /// </summary>
        public string DocumentDescription { get; set; }
    }
}
