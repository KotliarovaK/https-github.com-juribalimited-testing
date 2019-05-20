using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits
{
    public class CapacityUnitDto
    {
        private string Id;

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }

        public string GetId()
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = DatabaseHelper.GetCapacityUnitId(this.Name);
            }
            return Id;
        }
    }
}