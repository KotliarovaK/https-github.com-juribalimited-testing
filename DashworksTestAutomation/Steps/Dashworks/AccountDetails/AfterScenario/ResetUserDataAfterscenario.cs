using System;
using System.Net;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AccountDetails.AfterScenario
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
            //Update Account details
            try
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}/userProfile/updateAccountDetails";

                var request = requestUri.GenerateRequest();
                request.AddParameter("fullName", _userDto.FullName);
                request.AddParameter("userName", _userDto.Username);
                request.AddParameter("userId", DatabaseHelper.GetUserId(_userDto.Username));
                request.AddParameter("email", _userDto.Email);

                var response = _client.Evergreen.Put(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Logger.Write($"Unable to drop Account details: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to drop account details: {e}");
            }

            //Update Preferences
            try
            {
                var prefRequestUri = $"{UrlProvider.RestClientBaseUrl}/userProfile/updatePreferences";

                var prefRequest = prefRequestUri.GenerateRequest();
                prefRequest.AddParameter("languageName", "en-GB");
                prefRequest.AddParameter("displayMode", 0);
                prefRequest.AddParameter("userId", DatabaseHelper.GetUserId(_userDto.Username));
                prefRequest.AddParameter("timeZone", "GMT Standard Time");

                var prefResponse = _client.Evergreen.Put(prefRequest);

                if (!prefResponse.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Logger.Write(
                        $"Unable to drop User preferences: {prefResponse.StatusCode}, {prefResponse.ErrorMessage}");
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to drop Preferences: {e}");
            }

            //Updated Advanced settings
            try
            {
                var prefRequestUri = $"{UrlProvider.RestClientBaseUrl}/userProfile/updatePreferences";

                var prefRequest = prefRequestUri.GenerateRequest();
                prefRequest.AddParameter("gridPageCache", "10");
                prefRequest.AddParameter("gridPageSize", 1000);
                prefRequest.AddParameter("userId", DatabaseHelper.GetUserId(_userDto.Username));

                var prefResponse = _client.Evergreen.Put(prefRequest);

                if (!prefResponse.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Logger.Write(
                        $"Unable to drop Advanced settings: {prefResponse.StatusCode}, {prefResponse.ErrorMessage}");
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to drop Advanced settings: {e}");
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

                var response = _client.Evergreen.Put(request);

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
