using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class InvoiceLine
    {
        /// <summary>
        /// Fatura kaleminin sıra numarasının belirtileceği alandır.
        /// </summary>
        public string Index { get; set; }
        /// <summary>
        /// Bu alana ürünün satıcı kodu girilir.
        /// </summary>
        public string SellerCode { get; set; }
        /// <summary>
        /// Bu alana ürünün alıcı kodu girilir.
        /// </summary>
        public string BuyerCode { get; set; }
        /// <summary>
        /// Bu alana ürünün adı girilir.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Bu alana ürünün açıklaması girilir.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Bu alana miktar girilir.
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// Bu alana birim tipi girilmelidir. 
        /// </summary>
        public string UnitType { get; set; }
        /// <summary>
        /// Bu alana ürünün fiyatı girilir.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Bu alana iskonto tutarı girilir.
        /// </summary>
        public decimal AllowanceTotal { get; set; }
        /// <summary>
        /// Bu alana ürünün KDV oranı girilir.
        /// </summary>
        public decimal KDVPercent { get; set; }
        /// <summary>
        /// Bu alana ürünün diğer vergileri girilir. 
        /// </summary>
        public List<Tax> Taxes { get; set; }
        /// <summary>
        /// Bu alana Üretici Kodu bilgisi girilir.
        /// </summary>
        public string ManufacturerCode { get; set; }
        /// <summary>
        /// Bu alana Marka adı bilgisi girilir.
        /// </summary>
        public string BrandName { get; set; }
        /// <summary>
        /// Bu alana Model adı bilgisi girilir.
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// Bu alana not eklenir.
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// IHRACAT faturalarında İhracat bilgilerinin girildiği bölümdür.
        /// </summary>
        public DeliveryInfo DeliveryInfo { get; set; }
    }
}
