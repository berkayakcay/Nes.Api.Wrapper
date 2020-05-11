using System;

namespace Nes.Api.Wrapper.Legacy
{
    public abstract class ServiceBase
    {
        protected readonly string ApiUrl;
        protected readonly string AccessToken;

        public ServiceBase(string apiUrl, string accesToken)
        {
            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                throw new ArgumentNullException(nameof(apiUrl));
            }

            if (string.IsNullOrWhiteSpace(accesToken))
            {
                throw new ArgumentNullException(nameof(accesToken));
            }

            ApiUrl = apiUrl;
            AccessToken = accesToken;
        }
    }
}