using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class EArchiveInfo
    {
        /// <summary>
        /// Enum veri tipinde bir nesnedir. Satışın yapıldığı platformu belirtmek için kullanılır. INTERNET, NORMAL değerlerini alabilir.
        /// </summary>
        public SalesPlatform SalesPlatform { get; set; }
        /// <summary>
        /// Enum veri tipinde bir nesnedir. E-Arşiv faturasının alıcısına nasıl teslim edildiğinin belirtileceği alandır. KAGIT, ELEKTRONIK değerlerini alabilir.
        /// </summary>
        public SendType SendType { get; set; }
        /// <summary>
        /// e-Arşiv fatura üzerinde “İrsaliye yerine geçer” ibaresinin bulunup bulunmamasının belirtileceği alandır. 
        /// </summary>
        public bool ISDespatch { get; set; }
        /// <summary>
        /// İnternet satışlarında e-Arşiv faturada olması gereken zorunlu bilgilerin girileceği alandır.
        /// </summary>
        public InternetInfo InternetInfo { get; set; }
    }
}
