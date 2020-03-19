using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder
{
    public class SelfServicePageDto
    {
        public string ServiceIdentifier { get; set; }

        private int _pid;
        [JsonProperty("pageId")]
        public int PageId
        {
            get
            {
                if (_pid.Equals(0))
                {
                    try
                    {
                        _pid = DatabaseHelper.GetSelfServicePageId(this);
                    }
                    catch
                    {
                        //Ignore for case when Page is not created
                    }
                }
                return _pid;
            }
            set { _pid = value; }
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        private string _id;
        [JsonProperty("serviceId")]
        public int ServiceId
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                {
                    _id = string.IsNullOrEmpty(_id) ?
                        DatabaseHelper.GetSelfServiceIdByIdentifier(this.ServiceIdentifier) : _id;
                }
                return int.Parse(_id);
            }
            set
            {
                _id = value.ToString();
            }
        }

        [JsonProperty("objectTypeId")] public int ObjectTypeId => 3;

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("showInSelfService")]
        public bool ShowInSelfService { get; set; }

        [JsonProperty("deviceListId")]
        public string DeviceListId { get; set; }

        [JsonProperty("userListId")]
        public string UserListId { get; set; }

        [JsonProperty("components")]
        public List<BaseSelfServiceComponent> Components { get; set; }
    }
}
