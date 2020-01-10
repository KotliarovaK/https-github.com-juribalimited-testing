using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService
{
    class ListOfComponentsTypesForSelfServicePageDto
    {
        [JsonProperty("componentTypeId")]
        public long ComponentTypeId { get; set; }

        [JsonProperty("componentTypeName")]
        public string ComponentTypeName { get; set; }

        [JsonProperty("componentTypeDescription")]
        public string ComponentTypeDescription { get; set; }
    }
}