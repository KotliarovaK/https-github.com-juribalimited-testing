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

        [When(@"User create new User via API")]
        public void WhenUserCreateNewUserViaAPI(Table table)
        {
            var users = table.CreateSet<UserDto>();

            foreach (UserDto dto in users)
            {
                dto.UserRoles.AddRange(new List<string>() { "Dashworks Users", "Dashworks Evergreen Users" });
            }

            var requestUri = $"{UrlProvider.Url}Manage/ManageUser.aspx";

            foreach (UserDto user in users)
            {
                var request = new RestRequest("http://automation.corp.juriba.com/Manage/ManageUser.aspx");
                //request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddHeader("Host", "automation.corp.juriba.com");
                request.AddHeader("Origin", "http://automation.corp.juriba.com");
                request.AddHeader("Referer", "http://automation.corp.juriba.com/Manage/ManageUsers.aspx");
                request.AddHeader("Upgrade-Insecure-Requests", "1");
                //request.AddHeader("Accept-Encoding", "gzip, deflate");
                //request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.142 Safari/537.36");
                //request.AddHeader("Cache-Control", "max-age=0");
                //request.AddHeader("Connection", "keep-alive");
                //request.AddHeader("Accept-Language", "en-US,en;q=0.9,uk;q=0.8,ru;q=0.7");
                //request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3");
                request.AddParameter("__LASTFOCUS", String.Empty, ParameterType.QueryString);
                request.AddParameter("__EVENTTARGET", String.Empty, ParameterType.QueryString);
                request.AddParameter("__EVENTARGUMENT", String.Empty, ParameterType.QueryString);
                request.AddParameter("__VIEWSTATE", _authObject.Viewstate, ParameterType.QueryString);
                request.AddParameter("__VIEWSTATEGENERATOR", _authObject.ViewstateGenerator, ParameterType.QueryString);
                request.AddParameter("__EVENTVALIDATION", _authObject.Eventvalidation);

                //request.AddParameter("ctl00$MainContent$TB_UserName", "AAAAAbd", ParameterType.QueryString);
                request.AddParameter("ctl00$MainContent$TB_FullName", "AAAAAbd");
                request.AddParameter("ctl00$MainContent$TB_Email", user.Email);
                //request.AddParameter("ctl00$MainContent$DDL_TimeZone", user.TimeZone);
                request.AddParameter("ctl00$MainContent$DDL_TimeZone", "Kaliningrad Standard Time");
                request.AddParameter("ctl00$MainContent$TB_NewPwd", user.Password);
                request.AddParameter("ctl00$MainContent$TB_ConfirmPwd", user.ConfirmPassword);
                foreach (string role in user.UserRoles)
                {
                    if (!string.IsNullOrEmpty(role))
                        request.AddParameter("ctl00$MainContent$SelectUserRoles$selectedRoles", role);
                }
                //request.AddParameter("ctl00$MainContent$UC_StartDate$TB_SelectDateTime", user.StartDate.ToString("dd MMM yyyy hh:mm tt"));
                request.AddParameter("ctl00$MainContent$UC_StartDate$TB_SelectDateTime", string.Empty);
                request.AddParameter("ctl00$MainContent$UC_StartDate$TB_CapacitySlotTime", string.Empty);
                //request.AddParameter("ctl00$MainContent$UC_EndDate$TB_SelectDateTime", user.EndDate.ToString("dd MMM yyyy hh:mm tt"));
                request.AddParameter("ctl00$MainContent$UC_EndDate$TB_SelectDateTime", string.Empty);
                request.AddParameter("ctl00$MainContent$UC_EndDate$TB_CapacitySlotTime", string.Empty);
                request.AddParameter("ctl00$MainContent$Btn_Save", "Create User");
                //request.AddParameter("ctl00$DwFooter1$HF_PageLanguageId", 0, ParameterType.QueryString);

                var response = _client.Value.Post(request);

                if (response.Content.Contains("as successfully creat"))
                {
                    var t = 0;
                    var tt = t;
                }

                if (response.Content.Contains("enableEventValidation"))
                {
                    var t = 0;
                    var tt = t;
                }

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"Unable to create '{user.Username}' user via API");
            }

            _users.Value.AddRange(users);
        }
    }
}
