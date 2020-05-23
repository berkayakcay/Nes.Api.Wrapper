using System;
using System.Collections.Generic;
using System.Text;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public enum InvoceProfile
    {
        TEMELFATURA = 0, 
        TICARIFATURA = 1, 
        IHRACAT = 2, 
        YOLCUBERABERFATURA = 3, 
        EARSIVFATURA = 4
    }

    public enum InvoiceType
    {
        SATIS = 0,
        IADE = 1,
        ISTISNA = 2,
        TEVKIFAT = 3,
        IHRACKAYITLI = 4
    }

    public enum SendType
    {
        KAGIT = 0,
        ELEKTRONIK = 1
    }

    public enum SalesPlatform
    {
        NORMAL = 0,
        INTERNET = 1
    }
}
