using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.ManagementConsole.Users.Api
{
    [Binding]
    class CreateUserViaApi : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly DTO.RuntimeVariables.Users _users;
        protected readonly AuthObject _authObject;

        public CreateUserViaApi(RestWebClient client, DTO.RuntimeVariables.Users users, AuthObject authObject)
        {
            _client = client;
            _users = users;
            _authObject = authObject;
        }

        //	| Username  | Email | FullName | Password | Roles |
        [When(@"User create new User via API")]
        public void WhenUserCreateNewUserViaAPI(Table table)
        {
            var users = table.CreateSet<UserDto>();

            //Mandatory to login to evergreen
            foreach (UserDto dto in users)
            {
                dto.UserRoles.AddRange(new List<string>() { "Dashworks Users", "Dashworks Evergreen Users" });
            }

            var requestUri = $"{UrlProvider.RestClientBaseUrl}users/createUser";

            foreach (UserDto user in users)
            {
                var request = new RestRequest(requestUri);
                request.AddHeader("Host", UrlProvider.Host);
                request.AddHeader("Referer", UrlProvider.EvergreenUrl);
                request.AddParameter("Email", user.Email);
                request.AddParameter("UserName", user.Username);
                request.AddParameter("Password", user.Password);
                request.AddParameter("FullName", user.FullName);
                request.AddParameter("Roles", user.ApiUserRoles.Aggregate((a, b) => $"{a},{b}"));

                var response = _client.Evergreen.Put(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"Unable to create '{user.Username}' user via API");
                }

                _users.Value.Add(user);
            }
        }
    }
}