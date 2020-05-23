using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class PartyInfo : AddressInfo
    {
        /// <summary>
        ///Bu alana alıcı/göndericinin vergi/t.c. kimlik numarası girilir.
        /// </summary>
        public string RegisterNumber { get; set; }
        /// <summary>
        ///Bu alana alıcı/göndericinin ünvanı/adı soyadı girilir.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///Bu alana alıcı/göndericinin vergi dairesi girilir.
        /// </summary>
        public string TaxOffice { get; set; }
        /// <summary>
        ///Bu alana alıcı/göndericinin diğer resmi bilgileri girilebilir. 
        /// </summary>
        public List<PartyIdentification> PartyIdentifications { get; set; }
        /// <summary>
        ///Bu alana aracı kurum'a ait bilgiler girilir.
        /// </summary>
        public List<PartyIdentification> AgentPartyIdentifications { get; set; }
        /// <summary>
        ///Alıcının e-Fatura mükellefi olması durumunda faturanın hangi etikete gönderileceği bu alanda belirtilir.
        /// </summary>
        public string ReceiverAlias { get; set; }
    }
}
