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


            System.Console.ReadLine();
        }
    }
}