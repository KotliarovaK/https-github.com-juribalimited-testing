using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components
{
    public abstract class BaseSelfServiceComponent
    {
        [JsonProperty("componentId")] public int ComponentId = 1;

        [JsonProperty("pageId")] public int PageId { get; set; }

        [JsonProperty("componentTypeId")]
        public int ComponentTypeId { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("componentName")]
        public string ComponentName { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("componentType")]
        public string ComponentType { get; set; }

        [JsonProperty("componentTypeDescription")]
        public string ComponentTypeDescription { get; set; }

        [JsonProperty("showInSelfService")]
        public bool ShowInSelfService { get; set; }
    }

    class SelfServiceComponentConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(BaseSelfServiceComponent));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, typeof(SelfServiceTextComponent));
            //JObject jo = JObject.Load(reader);
            //var componentTypeId = (int)jo["componentTypeId"];
            //switch (componentTypeId)
            //{
            //    case 1:
            //        return serializer.Deserialize(reader, typeof(SelfServiceTextComponent));
            //    case 2:
            //        return serializer.Deserialize(reader, typeof(SelfServiceApplicationOwnershipComponent));
            //    default:
            //        throw new Exception($"Unable deserialize Self Service Component with '{componentTypeId}' type id");
            //}
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value, typeof(SelfServiceTextComponent));
            throw new NotImplementedException();
        }
    }
}
