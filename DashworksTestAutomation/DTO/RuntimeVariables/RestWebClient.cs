using DashworksTestAutomation.Providers;
using RestSharp;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    class RestWebClient
    {
        public RestClient Value { get; set; }

        public RestWebClient()
        {
            Value = new RestClient(UrlProvider.RestClientBaseUrl);
        }
    }
}
