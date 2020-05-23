using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class KeyValue
    {
        /// <summary>
        /// kullanıldığı yerle alakalı tarih verisi girilir. (Örn: İrsaliye Tarihi)
        /// </summary>
        public DateTime IssueDate { get; set; }
        /// <summary>
        /// kullanıldığı yerle alakalı değer girilir. (Örn: İrsaliye Numarası)
        /// </summary>
        public string Value { get; set; }
    }
}
