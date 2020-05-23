using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class AdditioanlDocumentReference
    {
        /// <summary>
        /// Eklenen dosyanın yada diğer bilginin değeri buraya girilebilir.
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Eklenen belgenin tarihi. Not: Bir belge değil sadece değer girişi olarak kullanılacaksa da fatura tarihi olarak girilebilir.
        /// </summary>
        public DateTime? IssueDate { get; set; }
        /// <summary>
        /// Eklenen belgenin tipi veya sabit değer serbest metin şeklinde yazılabilir.
        /// </summary>
        public string DocumentType { get; set; }
        /// <summary>
        /// Eklenen belgenin tipi veya sabit değer serbest metin şeklinde yazılabilir.
        /// </summary>
        public string DocumentTypeCode { get; set; }
        /// <summary>
        /// Eğer bir dosya eklenecekse, dosya bu alanda girilebilir.
        /// </summary>
        public Attachment Attachment { get; set; }
    }
}
