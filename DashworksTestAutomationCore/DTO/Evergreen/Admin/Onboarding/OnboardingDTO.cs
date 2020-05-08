using System.Collections.Generic;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;
using TechTalk.SpecRun.Common.Helper;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Onboarding
{
    public class OnboardingDto
    {
        [JsonProperty("applicationBucketId")] public string ApplicationBucketId = "955";

        [JsonProperty("applicationCategoryId")] public int ApplicationCategoryId = -1;

        [JsonProperty("applicationRequestTypeId")] public string ApplicationRequestTypeId = "725";

        [JsonProperty("applicationsList")] public string ApplicationsList = string.Empty;
        public string ApplicationObject
        {
            set => ApplicationsList = GetApplicationId(value);
        }

        [JsonProperty("deviceBucketId")] public string DeviceBucketId = "955";

        [JsonProperty("deviceCategoryId")] public int DeviceCategoryId = -1;

        [JsonProperty("deviceRequestTypeId")] public string DeviceRequestTypeId = "724";

        [JsonProperty("devicesList")]
        public string DevicesList = string.Empty;
        public string DeviceObject
        {
            set => DevicesList = GetDeviceId(value);
        }

        [JsonProperty("mailboxBucketId")] public string MailboxBucketId = "955";

        [JsonProperty("mailboxCategoryId")] public int MailboxCategoryId = -1;

        [JsonProperty("mailboxRequestTypeId")] public string MailboxRequestTypeId = "0";

        [JsonProperty("mailboxesList")] public string MailboxesList = "0";

        [JsonProperty("removeApplications")] public List<object> RemoveApplications = new List<object>();

        [JsonProperty("removeDevices")] public List<object> RemoveDevices = new List<object>();

        [JsonProperty("removeMailboxes")] public List<object> RemoveMailboxes = new List<object>();

        [JsonProperty("removeObjectsList")] public string RemoveObjectsList = string.Empty;

        [JsonProperty("removeUsers")] public List<object> RemoveUsers = new List<object>();

        [JsonProperty("ringId")] public string RingId = "145";

        [JsonProperty("type")] public string Type = "All";

        [JsonProperty("userBucketId")] public string UserBucketId = "955";

        [JsonProperty("userCategoryId")] public int UserCategoryId = -1;

        [JsonProperty("userRequestTypeId")] public string UserRequestTypeId = "723";

        [JsonProperty("usersList")]
        public string UsersList = string.Empty;
        public string UserObject
        {
            set => UsersList = GetUsersId(value);
        }

        private string GetDeviceId(string name)
        {
            return name.IsNotNullOrEmpty() ? DatabaseHelper.GetDeviceDetailsIdByName(name) : string.Empty;
        }

        private string GetUsersId(string name)
        {
            return name.IsNotNullOrEmpty() ? DatabaseHelper.GetUserDetailsIdByName(name) : string.Empty;
        }

        private string GetApplicationId(string name)
        {
            return name.IsNotNullOrEmpty() ? DatabaseHelper.GetApplicationDetailsIdByName(name) : string.Empty;
        }
    }
}