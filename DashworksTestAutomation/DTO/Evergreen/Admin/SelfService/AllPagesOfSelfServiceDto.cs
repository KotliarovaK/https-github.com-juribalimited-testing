using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService
{
    public partial class AllPagesOfSelfServiceDto
    {
        [JsonProperty("pageId")]
        public int PageId { get; set; }

        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }
     
        [JsonProperty("objectTypeId")]
        public int ObjectTypeId { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("showInSelfService")]
        public bool ShowInSelfService { get; set; }

        [JsonProperty("deviceListId")]
        public int DeviceListId { get; set; }

        [JsonProperty("userListId")]
        public int UserListId { get; set; }
    }
}