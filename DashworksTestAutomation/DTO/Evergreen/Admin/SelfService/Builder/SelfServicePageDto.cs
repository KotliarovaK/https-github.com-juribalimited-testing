using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder
{
    public class SelfServicePageDto
    {
        public string ServiceIdentifier { private get; set; }

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

        [JsonProperty("objectTypeId")]
        public int ObjectTypeId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("showInSelfService")]
        public bool ShowInSelfService { get; set; }
    }
}
