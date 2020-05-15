using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.Onboarding;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.Onboarding;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Onboarding
{
    public class OnboardObjectsToProjectAPIMethods
    {
        private readonly RestWebClient _client;
        private readonly OnboardedObjects _onboardedObjects;

        public OnboardObjectsToProjectAPIMethods(RestWebClient client, OnboardedObjects onboardedObjects)
        {
            _onboardedObjects = onboardedObjects;
            _client = client;

        }

        public void OnboardObjectsToProjectAPI(string projectName, Table table)
        {
            var projectId = DatabaseHelper.GetProjectId(projectName);


            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/{projectId}/updateProjectScope";
            var onboardingObjects = table.CreateSet<OnboardingDto>();

            foreach (OnboardingDto Object in onboardingObjects)
            {
                Object.RingId = DatabaseHelper.GetRingIdByProjectName(projectName);
                Object.ApplicationRequestTypeId = GetRequestTypes(projectId).ApplicationRequestTypes.Select(x => x.Value).FirstOrDefault();
                Object.DeviceRequestTypeId = GetRequestTypes(projectId).DeviceRequestTypes.Select(x => x.Value).FirstOrDefault();
                Object.UserRequestTypeId = GetRequestTypes(projectId).UserRequestTypes.Select(x => x.Value).FirstOrDefault();
                Object.ApplicationBucketId = Object.DeviceBucketId = Object.MailboxBucketId = Object.UserBucketId = GetBucketId(projectId);

                RestRequest request = requestUri.GenerateRequest();

                request.AddJsonBody(Object);
                var response = _client.Evergreen.Put(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to create Onboard Object: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
        }
    }

    #region Request Types Data

    private RequestTypes GetRequestTypes(string projectId)
    {
        var requestTypes = $"{UrlProvider.RestClientBaseUrl}admin/projects/{projectId}/requestTypes".GenerateRequest();
        var response = _client.Evergreen.Get(requestTypes);

        if (!response.StatusCode.Equals(HttpStatusCode.OK))
        {
            throw new Exception($"Unable to get Request Types Data: {response.StatusCode}, {response.ErrorMessage}");
        }

        var content = response.Content;
        return JsonConvert.DeserializeObject<RequestTypes>(content);
    }

    private class RequestTypes
    {
        [JsonProperty("userRequestTypes")]
        public List<Values> UserRequestTypes { get; set; }

        [JsonProperty("deviceRequestTypes")]
        public List<Values> DeviceRequestTypes { get; set; }

        [JsonProperty("applicationRequestTypes")]
        public List<Values> ApplicationRequestTypes { get; set; }
    }

    private class Values
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    #endregion

    #region Buckets Data

    private string GetBucketId(string projectId)
    {
        var requestTypes = $"{UrlProvider.RestClientBaseUrl}admin/projects/{projectId}/buckets".GenerateRequest();
        var response = _client.Evergreen.Get(requestTypes);

        if (!response.StatusCode.Equals(HttpStatusCode.OK))
        {
            throw new Exception($"Unable to get Bucket Data: {response.StatusCode}, {response.ErrorMessage}");
        }

        var content = response.Content;
        return JsonConvert.DeserializeObject<Buckets[]>(content)[0].Value;
    }

    private class Buckets
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    #endregion
}