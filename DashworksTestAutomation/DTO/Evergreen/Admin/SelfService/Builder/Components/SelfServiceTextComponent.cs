using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components
{
    public class SelfServiceTextComponent : BaseSelfServiceComponent
    {
        [JsonProperty("extraProperties")]
        public ExtraProperties ExtraProperties = new ExtraProperties();

        public string ExtraPropertiesText
        {
            get => ExtraProperties.Text;
            set => ExtraProperties.Text = value;
        }

        public SelfServiceTextComponent()
        {
            ComponentId = 1;
            ComponentTypeId = 1;
        }
    }

    public class ExtraProperties
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
