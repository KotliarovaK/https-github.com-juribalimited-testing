using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits
{
    public class CapacityUnitDto
    {
        private string Id;

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }

        public string Project { get; set; }

        public CapacityUnitDto(string id)
        {
            Id = id;
        }

        public CapacityUnitDto() { }

        public string GetId()
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = string.IsNullOrEmpty(this.Project) ?
                    DatabaseHelper.GetCapacityUnit(this.Name).Id : GetId(this.Project);
            }
            return Id;
        }

        public string GetId(string projectName)
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = DatabaseHelper.GetCapacityUnit(this.Name, projectName).Id;
            }
            return Id;
        }
    }
}