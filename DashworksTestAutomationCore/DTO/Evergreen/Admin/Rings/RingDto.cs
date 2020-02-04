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
        private string _id;

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }

        public string Project { get; set; }

        public RingDto(string id)
        {
            _id = id;
        }

        public RingDto() { }

        public string GetId()
        {
            if (string.IsNullOrEmpty(_id))
            {
                _id = string.IsNullOrEmpty(this.Project) ?
                    DatabaseHelper.GetRing(this.Name)._id : GetId(this.Project);
            }
            return _id;
        }

        public string GetId(string projectName)
        {
            if (string.IsNullOrEmpty(_id))
            {
                _id = DatabaseHelper.GetRing(this.Name, projectName)._id;
            }
            return _id;
        }
    }
}
