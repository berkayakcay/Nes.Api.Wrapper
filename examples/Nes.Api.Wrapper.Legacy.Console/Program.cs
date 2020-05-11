namespace Nes.Api.Wrapper.Legacy.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıların yaratacağı nesne
            var apiClient = new ApiClient("test01@nesbilgi.com.tr", "V9zH7Hh55LIl");

            // Örnek Token alma işlemi
            var loginResponse = apiClient.Token().Result;

            // Örnek Xslt listesini alma işlemi
            var generalResponse = apiClient.AccountTemplateList(Nes.Api.Wrapper.Legacy.Domain.Account.XsltType.eArchive).Result;
            foreach (var accountTemplate in generalResponse.Result)
            {
                System.Console.WriteLine($"{accountTemplate.Title} {accountTemplate.IsDefault}");
            }




            //Gönderilecek UUDI
            var uuid = "A7D94DF0-3FEA-4FD1-BD03-3B06D83B1485";
            //UUDI gönderip Fatura Numarasını Alma İşlemi
            var detailInvoiceNumberResponse = apiClient.DetailInvoiceNumber(uuid).Result;
            System.Console.WriteLine("Invoice Number:" + detailInvoiceNumberResponse.Result);






            //UUDI gönderip Fatura Numarasını Alma İşlemi
            var documentStatusResponse = apiClient.DocumentStatus(uuid).Result;
            System.Console.WriteLine("DOCUMENT STATUS:");
            System.Console.WriteLine("Code:" + documentStatusResponse.Result.InvoiceStatusCode);
            System.Console.WriteLine("Açıklama:" + documentStatusResponse.Result.InvoiceStatusDescription);
            System.Console.WriteLine("Açıklama Detayı:" + documentStatusResponse.Result.InvoiceStatusDetailDescription);
            System.Console.WriteLine("İptal Mı:" + documentStatusResponse.Result.IsCancel);





            System.Console.ReadLine();
        }
    }
}