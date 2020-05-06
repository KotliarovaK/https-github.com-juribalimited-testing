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

        public enum ObjectType
        {
            Devices,
            Users,
            Applications
        }
        public OnboardedObjects OnboardObjectsToProjectAPI(ObjectType objectType, string projectName, Table table, out string exception)
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

                    Object.DevicesList = objectType == ObjectType.Devices ? DatabaseHelper.GetDeviceDetailsIdByName(Object.DevicesList) : "";
                    
                    Object.UsersList = objectType == ObjectType.Users ? DatabaseHelper.GetUserId(Object.UsersList) : "";

                    Object.ApplicationsList = objectType == ObjectType.Applications ? DatabaseHelper.GetApplicationDetailsIdByName(Object.ApplicationsList) : "";

                    request.AddJsonBody(Object);
                    var response = _client.Evergreen.Post(request);

                    if (!response.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        exception = $"Unable to create Onboard Object: {response.StatusCode}, {response.ErrorMessage}";
                        return onboardedObjects;
                    }

                    var content = response.Content;
                    var onboardObjResponse = JsonConvert.DeserializeObject<OnboardingDto>(content);

                    Object.ApplicationBucketId = onboardObjResponse.ApplicationBucketId;
                    Object.ApplicationCategoryId = onboardObjResponse.ApplicationCategoryId;
                    Object.ApplicationRequestTypeId = onboardObjResponse.ApplicationRequestTypeId;
                    Object.ApplicationsList = onboardObjResponse.ApplicationsList;
                    Object.DeviceBucketId = onboardObjResponse.DeviceBucketId;
                    Object.DeviceCategoryId = onboardObjResponse.DeviceCategoryId;
                    Object.DeviceRequestTypeId = onboardObjResponse.DeviceRequestTypeId;
                    Object.DevicesList = onboardObjResponse.DevicesList;
                    Object.MailboxBucketId = onboardObjResponse.MailboxBucketId;
                    Object.MailboxCategoryId = onboardObjResponse.MailboxCategoryId;
                    Object.MailboxRequestTypeId = onboardObjResponse.MailboxRequestTypeId;
                    Object.MailboxesList = onboardObjResponse.MailboxesList;
                    Object.RemoveApplications = onboardObjResponse.RemoveApplications;
                    Object.RemoveDevices = onboardObjResponse.RemoveDevices;
                    Object.RemoveMailboxes = onboardObjResponse.RemoveMailboxes;
                    Object.RemoveObjectsList = onboardObjResponse.RemoveObjectsList;
                    Object.RemoveUsers = onboardObjResponse.RemoveUsers;
                    Object.RingId = onboardObjResponse.RingId;
                    Object.Type = onboardObjResponse.Type;
                    Object.UserBucketId = onboardObjResponse.UserBucketId;
                    Object.UserCategoryId = onboardObjResponse.UserCategoryId;
                    Object.UserRequestTypeId = onboardObjResponse.UserRequestTypeId;
                    Object.UsersList = onboardObjResponse.UsersList;

                    onboardedObjects.Value.Add(Object);
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