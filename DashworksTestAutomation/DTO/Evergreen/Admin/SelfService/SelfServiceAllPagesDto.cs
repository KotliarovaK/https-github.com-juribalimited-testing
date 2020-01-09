using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService
{
    public partial class SelfServiceAllPagesDto
    {
        [JsonProperty("pageId")]
        public long PageId { get; set; }

        [JsonProperty("serviceId")]
        public long ServiceId { get; set; }

        [JsonProperty("objectTypeId")]
        public long ObjectTypeId { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("showInSelfService")]
        public bool ShowInSelfService { get; set; }

        [JsonProperty("deviceListId")]
        public long DeviceListId { get; set; }

        [JsonProperty("userListId")]
        public long UserListId { get; set; }
    }
}
