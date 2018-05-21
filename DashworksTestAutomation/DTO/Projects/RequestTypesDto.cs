using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class RequestTypesDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ObjectTypeEnum ObjectType;

        public RequestTypesDto()
        {
            ObjectType = ObjectTypeEnum.Computer;
        }
    }

    public enum ObjectTypeEnum
    {
        Computer,
        Application,
        User
    }
}