using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class DeliveryInfo
    {
        /// <summary>
        /// GTIP (Gümrük Tarife İstatistik Pozisyonu) No
        /// </summary>
        public string GTIPNo { get; set; }
        /// <summary>
        /// Bu alana Mal/Hizmetin Teslim şartı bilgisi girilir.
        /// </summary>
        public string DeliveryTermCode { get; set; }
        /// <summary>
        /// Bu alana Gönderim şekli bilgisi girilir. 
        /// </summary>
        public string TransportModeCode { get; set; }
        /// <summary>
        /// Bu alana Mal/Hizmetin bulunduğu Kabın Marka isim bilgisi girilir.
        /// </summary>
        public string PackageBrandName { get; set; }
        /// <summary>
        /// Bu alana Gümrük Takip Numarası girilir.
        /// </summary>
        public string ProductTraceID { get; set; }
        /// <summary>
        /// Bu alana Mal/Hizmetin bulunduğu kabın numarası girilir.
        /// </summary>
        public string PackageID { get; set; }
        /// <summary>
        /// Bu alana Mal/Hizmetin Bulunduğu Kabın Adedi bilgisi girilir.
        /// </summary>
        public decimal PackageQuantity { get; set; }
        /// <summary>
        /// Bu alana Mal/Hizmetin Bulunduğu Kabın Cinsi girilir.
        /// </summary>
        public string PackageTypeCode { get; set; }
        /// <summary>
        /// Bu alan turistin adres bilgileri girilir. 
        /// </summary>
        public AddressInfo DeliveryAddress { get; set; }
    }
}
