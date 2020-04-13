using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.ItemDetails
{
    public class CustomFieldDto
    {
        public string ObjectType { get; set; }
        public string ObjectId { get; set; }
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("fieldIndex")]
        public int FieldIndex { get; set; }
    }
}
