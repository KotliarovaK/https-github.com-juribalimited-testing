using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.Evergreen.Admin;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Dashboards.AfterScenario
{
    [Binding]
    class RemoveDashboardAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly UsedUsers _usedUsers;
        private readonly DTO.RuntimeVariables.Dashboards _dashboard;

        public RemoveDashboardAfterScenario(RestWebClient client, UsedUsers usedUsers, DTO.RuntimeVariables.Dashboards dashboard)
        {
            _client = client;
            _usedUsers = usedUsers;
            _dashboard = dashboard;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedDashboard()
        {
            if (!_dashboard.Value.Any())
                return;

            List<UserDto> noDupes = _usedUsers.Value.GroupBy(x => x.Username).Select(y => y.FirstOrDefault()).ToList();

            foreach (UserDto user in noDupes)
            {
                var restClient = new RestClient(UrlProvider.Url);

                //Get cookies
                var client = new HttpClientHelper(user, restClient);

                //Add cookies to the RestClient to authorize it
                _client.Evergreen.AddCookies(client.CookiesJar);

                foreach (DashboardDto dashboardDto in _dashboard.Value)
                {
                    try
                    {
                        var requestUri = $"{UrlProvider.RestClientBaseUrl}dashboard/{dashboardDto.DashboardId}";

                        var request = new RestRequest(requestUri);
                        request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                        request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                        request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                        var response = _client.Evergreen.Delete(request);

                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            Console.WriteLine($"Unable to delete dashboard with '{dashboardDto.DashboardName}' name: {response.StatusCode}");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Unable to delete dashboard with '{dashboardDto.DashboardName}' name: {e}");
                    }
                }
            }
        }
    }
}
