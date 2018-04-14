using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class CategoryPropertiesDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryObjectTypeEnum ObjectType;

        public CategoryPropertiesDto()
        {
            ObjectType = EnumExtensions.GetRandomValue<CategoryObjectTypeEnum>();
        }
    }

    public enum CategoryObjectTypeEnum
    {
        User,
        Computer,
        Application
    }
}