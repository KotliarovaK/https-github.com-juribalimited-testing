using System;
using System.Collections.Generic;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Onboarding
{
    public class OnboardingDto
    {
        [JsonProperty("applicationBucketId")]
        public string ApplicationBucketId { get; set; }

        [JsonProperty("applicationCategoryId")]
        public int ApplicationCategoryId { get; set; }

        [JsonProperty("applicationRequestTypeId")]
        public string ApplicationRequestTypeId { get; set; }

        [JsonProperty("applicationsList")]
        public string ApplicationsList { get; set; }

        [JsonProperty("deviceBucketId")]
        public string DeviceBucketId { get; set; }

        [JsonProperty("deviceCategoryId")]
        public int DeviceCategoryId { get; set; }

        [JsonProperty("deviceRequestTypeId")]
        public string DeviceRequestTypeId { get; set; }

        [JsonProperty("devicesList")]
        public string DevicesList { get; set; }

        [JsonProperty("mailboxBucketId")]
        public string MailboxBucketId { get; set; }

        [JsonProperty("mailboxCategoryId")]
        public int MailboxCategoryId { get; set; }

        [JsonProperty("mailboxRequestTypeId")]
        public string MailboxRequestTypeId { get; set; }

        [JsonProperty("mailboxesList")]
        public string MailboxesList { get; set; }

        [JsonProperty("removeApplications")]
        public List<object> RemoveApplications { get; set; }

        [JsonProperty("removeDevices")]
        public List<object> RemoveDevices { get; set; }

        [JsonProperty("removeMailboxes")]
        public List<object> RemoveMailboxes { get; set; }

        [JsonProperty("removeObjectsList")]
        public string RemoveObjectsList { get; set; }

        [JsonProperty("removeUsers")]
        public List<object> RemoveUsers { get; set; }

        [JsonProperty("ringId")]
        public string RingId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("userBucketId")]
        public string UserBucketId { get; set; }

        [JsonProperty("userCategoryId")]
        public int UserCategoryId { get; set; }

        [JsonProperty("userRequestTypeId")]
        public string UserRequestTypeId { get; set; }

        [JsonProperty("usersList")]
        public string UsersList { get; set; }
    }
}