using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class PartyIdentification
    {
        /// <summary>
        ///Bu alana aşağıdaki listeden birisi yazılmalıdır.
        /// </summary>
        public string SchemeID { get; set; }
        /// <summary>
        ///Bu alana seçilen tipin değeri girilmelidir.
        /// </summary>
        public string Value { get; set; }
    }
}
