using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components
{
    public class SelfServiceTextComponent
    {
        public SelfServicePageDto SelfServicePage { get; set; }

        [JsonProperty("componentId")] public int ComponentId = 1;

        [JsonProperty("pageId")] public int PageId => SelfServicePage.PageId;

        [JsonProperty("componentTypeId")] public int ComponentTypeId = 1;

        [JsonProperty("order")] public int Order = 1;

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

        [JsonProperty("extraProperties")]
        public ExtraProperties ExtraProperties = new ExtraProperties();

        public string ExtraPropertiesText
        {
            get => ExtraProperties.Text;
            set => ExtraProperties.Text = value;
        }
    }

    public class ExtraProperties
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
