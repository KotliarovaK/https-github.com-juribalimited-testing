using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService
{
    class ComponentsOfSelfServicePageDto
    {
        [JsonProperty("componentId")]
        public int ComponentId { get; set; }

        [JsonProperty("pageId")]
        public int PageId { get; set; }

        [JsonProperty("componentTypeId")]
        public int ComponentTypeId { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("componentName")]
        public string ComponentName { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("componentType")]
        public int ComponentType { get; set; }

        [JsonProperty("componentTypeDescription")]
        public int ComponentTypeDescription { get; set; }

        [JsonProperty("showInSelfService")]
        public int ShowInSelfService { get; set; }

        [JsonProperty("components")]
        public List<Component> Components { get; set; }

        public class Component
        {
            [JsonProperty("componentId")]
            public int ComponentId { get; set; }

            [JsonProperty("pageId")]
            public int PageId { get; set; }

            [JsonProperty("componentTypeId")]
            public int ComponentTypeId { get; set; }

            [JsonProperty("order")]
            public string Order { get; set; }

            [JsonProperty("componentName")]
            public string ComponentName { get; set; }

            [JsonProperty("helpText")]
            public string HelpText { get; set; }

            [JsonProperty("componentType")]
            public int ComponentType { get; set; }

            [JsonProperty("componentTypeDescription")]
            public int ComponentTypeDescription { get; set; }

            [JsonProperty("showInSelfService")]
            public int ShowInSelfService { get; set; }
        }
    }
}