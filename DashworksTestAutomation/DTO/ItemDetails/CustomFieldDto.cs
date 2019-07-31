using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.ItemDetails
{
    class CustomFieldDto
    {
        public string List { get; set; }
        public string ObjectId { get; set; }
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("fieldIndex")]
        public string FieldIndex { get; set; }

        private string _id;
        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                    _id = DatabaseHelper.GetCustomFieldId(this.FieldName);

                return _id;
            }
        }
    }
}
