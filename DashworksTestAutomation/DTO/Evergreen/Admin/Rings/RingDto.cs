using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Rings
{
    class RingDto
    {
        private string Id;

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }

        public string Project { get; set; }

        public RingDto(string id)
        {
            Id = id;
        }

        public RingDto() { }

        public string GetId()
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = string.IsNullOrEmpty(this.Project) ?
                    DatabaseHelper.GetRing(this.Name).Id : GetId(this.Project);
            }
            return Id;
        }

        public string GetId(string projectName)
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = DatabaseHelper.GetRing(this.Name, projectName).Id;
            }
            return Id;
        }
    }
}
