using System;
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

        public OnboardedObjects OnboardObjectsToProjectAPI(string projectName, Table table, out string exception)
        {
            exception = string.Empty;

            try
            {
                OnboardedObjects onboardedObjects = new OnboardedObjects();

                var projectId = DatabaseHelper.GetProjectId(projectName);
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/{projectId}/updateProjectScope";
                var onboardingObjects = table.CreateSet<OnboardingDto>();

                foreach (OnboardingDto Object in onboardingObjects)
                {
                    var request = requestUri.GenerateRequest();

                    request.AddJsonBody(Object);
                    var response = _client.Evergreen.Put(request);

                    if (!response.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        exception = $"Unable to create Onboard Object: {response.StatusCode}, {response.ErrorMessage}";
                        return onboardedObjects;
                    }

                    var content = response.Content;
                    var onboardObjResponse = JsonConvert.DeserializeObject<OnboardingDto>(content);

                    onboardedObjects.Value.Add(onboardObjResponse);
                }

                return onboardedObjects;
            }
            catch (Exception e)
            {
                exception = e.Message;
                return null;
            }
        }
    }
}