using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class RequestTypesDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ObjectTypeString { get; set; }
        public ObjectTypeEnum ObjectType;
    }

    public enum ObjectTypeEnum
    {
        Computer,
        Application,
        User
    }
}