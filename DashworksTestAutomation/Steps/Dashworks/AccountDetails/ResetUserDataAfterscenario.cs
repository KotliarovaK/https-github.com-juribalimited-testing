using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AccountDetails
{
    [Binding]
    class ResetUserDataAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly UserDto _userDto;

        public ResetUserDataAfterScenario(UserDto userDto, RestWebClient client)
        {
            _userDto = userDto;
            _client = client;
        }

        [AfterScenario("Remove_Profile_Changes")]
        public void RemoveProfileChangesAfterScenario()
        {
            try
            {
                //Update Account details

                var requestUri = $"{UrlProvider.RestClientBaseUrl}/userProfile/updateAccountDetails";

                var request = requestUri.GenerateRequest();
                request.AddParameter("fullName", _userDto.FullName);
                request.AddParameter("userName", _userDto.Username);
                request.AddParameter("userId", DatabaseHelper.GetUserId(_userDto.Username));
                request.AddParameter("email", _userDto.Email);

                var response = _client.Value.Put(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Logger.Write($"Unable to drop Account details: {response.StatusCode}, {response.ErrorMessage}");
                }

                //Update Preferences

                var prefRequestUri = $"{UrlProvider.RestClientBaseUrl}/userProfile/updatePreferences";

                var prefRequest = prefRequestUri.GenerateRequest();
                prefRequest.AddParameter("languageName", "en-GB");
                prefRequest.AddParameter("displayMode", 0);
                prefRequest.AddParameter("userId", DatabaseHelper.GetUserId(_userDto.Username));
                prefRequest.AddParameter("timeZone", "GMT Standard Time");

                var prefResponse = _client.Value.Put(prefRequest);

                if (!prefResponse.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Logger.Write(
                        $"Unable to drop User preferences: {prefResponse.StatusCode}, {prefResponse.ErrorMessage}");
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to drop User profile changes: {e}");
            }
        }

        [AfterScenario("Remove_Password_Changes")]
        public void RemovePasswordChangesAfterScenario()
        {
            try
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}/userProfile/changePassword";

                var request = requestUri.GenerateRequest();
                request.AddParameter("currentPassword", "test5846");
                request.AddParameter("newPassword", UserProvider.Password);
                request.AddParameter("userName", _userDto.Username);

                var response = _client.Value.Put(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Logger.Write($"Unable to reset user password: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to reset user password: {e}");
            }
        }
    }
}
