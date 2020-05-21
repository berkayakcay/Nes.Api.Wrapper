using System;
using System.Globalization;

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
            System.IO.File.WriteAllText($"D:\\{uuid}.html", invoiceGeneralHtmlResponse.Result);

            //// GET Şablon (XSLT) içeriğini alma 
            var downloadTemplateXsltResponse = apiClient.Account.DownloadTemplate(Domain.Account.XsltType.eArchive, "default").Result;
            System.IO.File.WriteAllText($"D:\\default.xslt", downloadTemplateXsltResponse.Result);

            // 
            var creditsInfoResponse = apiClient.Account.CreditsInfo().Result;
            System.Console.WriteLine(creditsInfoResponse.Result.TotalUseCount);


            //UUID gönderip faturanın XML alma işlemi
            var invoiceGeneralXmlResponse = apiClient.InvoiceGeneral.UblXmlContent(uuid).Result;
            System.IO.File.WriteAllText($"D:\\{uuid}.xml", invoiceGeneralXmlResponse.Result);



            // Belirtilen VKN/TCKN'nin e-Fatura mükellefi olup olmadığını sorgulama
            var checkListResponse = apiClient.Customer.Check("5555553487").Result;
            foreach (var customerCheckResult in checkListResponse.Result.CustomerList)
            {
                System.Console.WriteLine($"{customerCheckResult.RegisterNumber}");
                System.Console.WriteLine($"{customerCheckResult.Title}");
                System.Console.WriteLine($"{customerCheckResult.Alias}");
                System.Console.WriteLine($"{customerCheckResult.Type}");
                System.Console.WriteLine($"{customerCheckResult.FirstCreationTime.ToString(CultureInfo.InvariantCulture)}");
                System.Console.WriteLine($"{customerCheckResult.AliasCreationTime.ToString(CultureInfo.InvariantCulture)}");
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
                System.Console.WriteLine($"{allCustomerResult.FirstCreationTime.ToString(CultureInfo.InvariantCulture)}");
                System.Console.WriteLine($"{allCustomerResult.AliasCreationTime.ToString(CultureInfo.InvariantCulture)}");
            }

            var downloadZipResponse = apiClient.Customer.DownloadZip().Result;
            System.IO.File.WriteAllBytesAsync(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"userList.zip"),downloadZipResponse.Result);

            System.Console.ReadLine();
        }
    }
}