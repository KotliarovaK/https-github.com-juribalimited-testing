using System.Collections.Generic;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;
using TechTalk.SpecRun.Common.Helper;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Onboarding
{
    public class OnboardingDto
    {
        [JsonProperty("applicationBucketId")] 
        public string ApplicationBucketId = string.Empty;

        [JsonProperty("applicationCategoryId")] 
        public int ApplicationCategoryId = -1;

        [JsonProperty("applicationRequestTypeId")] 
        public string ApplicationRequestTypeId = string.Empty;

        [JsonProperty("applicationsList")] 
        public string ApplicationsList = string.Empty;
        public string ApplicationObjects
        {
            set => ApplicationsList = value.IsNotNullOrEmpty() ? DatabaseHelper.GetApplicationDetailsIdByName(value) : string.Empty;
        }

        [JsonProperty("deviceBucketId")] 
        public string DeviceBucketId = string.Empty;

        [JsonProperty("deviceCategoryId")] 
        public int DeviceCategoryId = -1;

        [JsonProperty("deviceRequestTypeId")] 
        public string DeviceRequestTypeId = string.Empty;

        [JsonProperty("devicesList")] 
        public string DevicesList = string.Empty;
        public string DeviceObjects
        {
            set => DevicesList = value.IsNotNullOrEmpty() ? DatabaseHelper.GetDeviceDetailsIdByName(value) : string.Empty;
        }

        [JsonProperty("mailboxBucketId")] 
        public string MailboxBucketId = string.Empty;

        [JsonProperty("mailboxCategoryId")] 
        public int MailboxCategoryId = -1;

        [JsonProperty("mailboxRequestTypeId")] 
        public string MailboxRequestTypeId = "0";

        [JsonProperty("mailboxesList")] 
        public string MailboxesList = string.Empty;

        [JsonProperty("removeApplications")] 
        public List<object> RemoveApplications = new List<object>();

        [JsonProperty("removeDevices")] 
        public List<object> RemoveDevices = new List<object>();

        [JsonProperty("removeMailboxes")] 
        public List<object> RemoveMailboxes = new List<object>();

        [JsonProperty("removeObjectsList")] 
        public string RemoveObjectsList = string.Empty;

        [JsonProperty("removeUsers")] 
        public List<object> RemoveUsers = new List<object>();

        [JsonProperty("ringId")] 
        public string RingId = string.Empty;

        [JsonProperty("type")] 
        public string Type = "All";

        [JsonProperty("userBucketId")] 
        public string UserBucketId = string.Empty;

        [JsonProperty("userCategoryId")] 
        public int UserCategoryId = -1;

        [JsonProperty("userRequestTypeId")] 
        public string UserRequestTypeId = string.Empty;

        [JsonProperty("usersList")]
        public string UsersList = string.Empty;
        public string UserObjects
        {
            set => UsersList = value.IsNotNullOrEmpty() ? DatabaseHelper.GetUserDetailsIdByName(value) : string.Empty;
        }
    }
}