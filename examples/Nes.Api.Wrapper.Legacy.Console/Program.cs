using System;

namespace Nes.Api.Wrapper.Legacy.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıların yaratacağı nesne
            var apiClient = new ApiClient("http://apitest.nesbilgi.com.tr/", "test01@nesbilgi.com.tr", "V9zH7Hh55LIl");

            // Örnek Token alma işlemi
            var loginResponse = apiClient.Token().Result;

            // Örnek Xslt listesini alma işlemi
            var generalResponse = apiClient.Account.TemplateList(Nes.Api.Wrapper.Legacy.Domain.Account.XsltType.eArchive).Result;
            foreach (var accountTemplate in generalResponse.Result)
            {
                System.Console.WriteLine($"{accountTemplate.Title} {accountTemplate.IsDefault}");
            }


            //Gönderilecek UUDI
            var uuid = "A7D94DF0-3FEA-4FD1-BD03-3B06D83B1485";
            //UUDI gönderip Fatura Numarasını Alma İşlemi
            var detailInvoiceNumberResponse = apiClient.InvoiceGeneral.DetailInvoiceNumber(uuid).Result;
            System.Console.WriteLine("Invoice Number:" + detailInvoiceNumberResponse.Result);


            //UUDI gönderip Fatura Numarasını Alma İşlemi
            var documentStatusResponse = apiClient.EArchive.DocumentStatus(uuid).Result;
            System.Console.WriteLine("DOCUMENT STATUS:");
            System.Console.WriteLine("Code:" + documentStatusResponse.Result.InvoiceStatusCode);
            System.Console.WriteLine("Açıklama:" + documentStatusResponse.Result.InvoiceStatusDescription);
            System.Console.WriteLine("Açıklama Detayı:" + documentStatusResponse.Result.InvoiceStatusDetailDescription);
            System.Console.WriteLine("İptal Mı:" + documentStatusResponse.Result.IsCancel);

            //UUID gönderip faturanın html alma işlemi
            var invoiceGeneralHtmlResponse = apiClient.InvoiceGeneral.Html(uuid).Result;
            System.IO.File.WriteAllText($"D:\\{uuid}.html", invoiceGeneralHtmlResponse);

            //// GET Şablon (XSLT) içeriğini alma 
            var downloadTemplateXslt = apiClient.Account.DownloadTemplate(Domain.Account.XsltType.eArchive, "default").Result;
            System.IO.File.WriteAllText($"D:\\default.xslt", downloadTemplateXslt);


            //UUID gönderip faturanın XML alma işlemi
            var invoiceGeneralXMLResponse = apiClient.InvoiceGeneral.ublXMLContent(uuid).Result;
            System.IO.File.WriteAllText($"D:\\{uuid}.xml", invoiceGeneralXMLResponse);



            // Belirtilen VKN/TCKN'nin e-Fatura mükellefi olup olmadığını sorgulama
            var checkListResponse = apiClient.Customer.Check("5555553487").Result;
            foreach (var CustomerCheckResult in checkListResponse.Result.CustomerList)
            {
                System.Console.WriteLine($"{CustomerCheckResult.RegisterNumber}");
                System.Console.WriteLine($"{CustomerCheckResult.Title}");
                System.Console.WriteLine($"{CustomerCheckResult.Alias}");
                System.Console.WriteLine($"{CustomerCheckResult.Type}");
                System.Console.WriteLine($"{CustomerCheckResult.FirstCreationTime.ToString()}");
                System.Console.WriteLine($"{CustomerCheckResult.AliasCreationTime.ToString()}");
            }
            System.Console.WriteLine($"{checkListResponse.Result.ISEInvoiceCustomer}");


            // Sistemde kayıtlı tüm e-Fatura mükelleflerini çekme
            var allCustomerListResponse = apiClient.Customer.AllCustomer().Result;
            foreach (var allCustomerResult in allCustomerListResponse.Result)
            {
                System.Console.WriteLine($"{allCustomerResult.RegisterNumber}");
                System.Console.WriteLine($"{allCustomerResult.Title}");
                System.Console.WriteLine($"{allCustomerResult.Alias}");
                System.Console.WriteLine($"{allCustomerResult.Type}");
                System.Console.WriteLine($"{allCustomerResult.FirstCreationTime.ToString()}");
                System.Console.WriteLine($"{allCustomerResult.AliasCreationTime.ToString()}");
            }

            var downloadZipResponse = apiClient.Customer.DownloadZip().Result;
            System.IO.File.WriteAllBytesAsync(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"userList.zip"),downloadZipResponse.Result);

            System.Console.ReadLine();
        }
    }
}